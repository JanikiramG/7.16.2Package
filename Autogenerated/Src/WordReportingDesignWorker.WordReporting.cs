namespace Terrasoft.Configuration.Reporting.Word.Worker
{
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Linq;
	using System.Net;
	using System.Net.Http;
	using System.ServiceModel.Web;
	using DocumentFormat.OpenXml.Packaging;
	using Terrasoft.Configuration.FileUpload;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;

	#region Class: WordReportingDesignWorker

	/// <summary>
	/// Provides report generating functionality.
	/// </summary>
	public class WordReportingDesignWorker : IWordReportDesignWorker
	{

		#region Fields: Private

		private readonly UserConnection _userConnection;

		#endregion

		#region Constructors: Public

		public WordReportingDesignWorker(UserConnection userConnection) {
			_userConnection = userConnection;
		}

		#endregion

		#region Methods: Private

		private IEntitySchemaQueryFilterItem CreateReportTypeFilter(EntitySchemaQuery esq) {
			return esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Type.Name", "MS Word");
		}

		private DataObjectSettingsDto GetDataSettingsDto(Guid reportId) {
			var esq = new EntitySchemaQuery(_userConnection.EntitySchemaManager, "SysModuleReport");
			var macrosListName = esq.AddColumn("MacrosList").Name;
			var sysEntitySchemaUIdColumnName = esq.AddColumn("SysModule.SysModuleEntity.SysEntitySchemaUId").Name;
			var sysSchemaCaptionName =
				esq.AddColumn("SysModule.SysModuleEntity.[VwSysSchemaInWorkspace:UId:SysEntitySchemaUId].Caption").Name;
			var entity = esq.GetEntity(_userConnection, reportId);
			if (entity == null) {
				throw new WebFaultException(HttpStatusCode.NotFound);
			}
			return new DataObjectSettingsDto {
				Caption = entity.GetTypedColumnValue<string>(sysSchemaCaptionName),
				MacrosCollection = entity.GetTypedColumnValue<string>(macrosListName),
				EntitySchemaUId = entity.GetTypedColumnValue<Guid>(sysEntitySchemaUIdColumnName),
			};
		}

		private DataObjectSettingsDto[] GetTableDataDto(Guid reportId) {
			var esq = new EntitySchemaQuery(_userConnection.EntitySchemaManager, "SysModuleReportTable");
			var captionColumnName = esq.AddColumn("Caption").Name;
			var objectIdColumnName = esq.AddColumn("ObjectId").Name;
			var macrosListColumnName = esq.AddColumn("MacrosList").Name;
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "SysModuleReport", reportId));
			var collection = esq.GetEntityCollection(_userConnection);
			return collection.Select(x => new DataObjectSettingsDto {
				Caption = x.GetTypedColumnValue<string>(captionColumnName),
				EntitySchemaUId = x.GetTypedColumnValue<Guid>(objectIdColumnName),
				MacrosCollection = x.GetTypedColumnValue<string>(macrosListColumnName)
			}).ToArray();
		}

		private Entity GetTemplateFile(Guid fileId) {
			EntitySchema entitySchema = _userConnection.EntitySchemaManager.GetInstanceByName("SysReportTemplate");
			Entity entity = entitySchema.CreateEntity(_userConnection);
			if (!entity.FetchFromDB(fileId)) {
				throw new ItemNotFoundException(_userConnection, fileId.ToString(), "WordReportingDesignWorker");
			}
			return entity;
		}

		private void SaveEntityFile(Stream template, Guid reportId) {
			Entity entity = GetReportEntity(reportId);
			entity.SetStreamValue("File", template);
			entity.Save();
		}

		private Entity GetReportEntity(Guid reportId) {
			EntitySchema entitySchema = _userConnection.EntitySchemaManager.GetInstanceByName("SysModuleReport");
			Entity entity = entitySchema.CreateEntity(_userConnection);
			if (!entity.FetchFromDB(reportId)) {
				throw new ItemNotFoundException(_userConnection, reportId.ToString(), "WordReportingDesignWorker");
			}
			return entity;
		}
		
		private Entity GetReportTemplateEntity(Guid reportId) {
			EntitySchema entitySchema = _userConnection.EntitySchemaManager.GetInstanceByName("SysModuleReport");
			Entity entity = entitySchema.CreateEntity(_userConnection);
			if (!entity.FetchFromDB(reportId)) {
				throw new ItemNotFoundException(_userConnection, reportId.ToString(), "WordReportingDesignWorker");
			}
			return entity;
		}

		private void ClearTempTemplate(Guid reportId) {
			var date = DateTime.Now.AddDays(-1).Date;
			Query delete = new Delete(_userConnection)
				.From("SysReportTemplate")
				.Where("ReportId")
					.IsEqual(Column.Parameter(reportId))
				.Or("CreatedOn")
					.IsGreaterOrEqual(Column.Parameter(date));
			delete.Execute();
		}
		
		#endregion

		#region Methods: Public

		/// <summary>
		/// Get all reports.
		/// </summary>
		/// <returns>Returns reports collection.</returns>
		public IEnumerable<WordReportMainInfoDto> GetReportsCollection() {
			var esq = new EntitySchemaQuery(_userConnection.EntitySchemaManager, "SysModuleReport");
			var idColumnName = esq.AddColumn("Id").Name;
			var captionColumnName = esq.AddColumn("Caption").Name;
			var sysModuleIdColumnName = esq.AddColumn("SysModule.Id").Name;
			var sysModuleCaptionColumnName = esq.AddColumn("SysModule.Caption").Name;
			esq.Filters.Add(CreateReportTypeFilter(esq));
			return esq.GetEntityCollection(_userConnection).Select(x => new WordReportMainInfoDto {
				ReportId = x.GetTypedColumnValue<Guid>(idColumnName),
				ReportCaption = x.GetTypedColumnValue<string>(captionColumnName),
				SysModuleId = x.GetTypedColumnValue<Guid>(sysModuleIdColumnName),
				SysModuleCaption = x.GetTypedColumnValue<string>(sysModuleCaptionColumnName)
			});
		}

		/// <summary>
		/// Get report.
		/// </summary>
		/// <param name="reportId">Report id.</param>
		/// <returns>Returns report.</returns>
		public WordReportSettingsDto GetReportSettings(Guid reportId) {
			DataObjectSettingsDto settings = GetDataSettingsDto(reportId);
			DataObjectSettingsDto[] tables = GetTableDataDto(reportId);
			return new WordReportSettingsDto {
				ReportId = reportId,
				MainDataObjectSettings = settings,
				TableDataObjectSettingsCollection = tables
			};
		}

		/// <summary>
		/// Upload report template.
		/// </summary>
		/// <param name="template">Template stream.</param>
		/// <param name="reportId">Report id.</param>
		public void SaveTemplate(Stream template, Guid reportId) {
			SaveEntityFile(template, reportId);
			ClearTempTemplate(reportId);
		}

		public Stream ValidateTemplate(Guid fileId) {
			try {
				Entity entity = GetTemplateFile(fileId);
				var bytes = entity.GetBytesValue("File");
				MemoryStream stream = new MemoryStream(bytes);
				using (WordprocessingDocument docx = WordprocessingDocument.Open(stream, false)) {
					docx.Close();
				}
				stream.Seek(0, SeekOrigin.Begin);
				return stream;
			} catch (Exception e) {
				throw new ArgumentException(e.Message);
			}
		}

		/// <summary>
		/// Remove report template.
		/// </summary>
		/// <param name="reportId">Report id.</param>
		/// <returns>Returns base response.</returns>
		public void RemoveTemplate(Guid reportId) {
			SaveEntityFile(null, reportId);
		}

		/// <summary>
		/// Download report template.
		/// </summary>
		/// <param name="reportId">Report id.</param>
		/// <returns>Returns template stream.</returns>
		public (Stream, string) DownloadTemplate(Guid reportId) {
			var entity = GetReportEntity(reportId);
			var file = entity.GetStreamValue("File");
			var caption = entity.GetColumnValue("Caption").ToString();
			return (file, caption);
		}

		#endregion

	}

	#endregion

}

