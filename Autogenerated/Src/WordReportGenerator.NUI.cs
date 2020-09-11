namespace Terrasoft.Configuration.WordReportGenerator
{
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.IO;
	using System.Linq;
	using DocumentFormat.OpenXml;
	using DocumentFormat.OpenXml.Packaging;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;
	using Terrasoft.Configuration.ReportService;

	#region Class: WordReportGenerator

	/// <summary>
	/// Provides report generating functionality.
	/// </summary>
	[DefaultBinding(typeof(IReportGenerator), Name = "Word")]
	public class WordReportGenerator : IReportGenerator
	{

		#region Methods: Private

		private byte[] GetTemplateSource(UserConnection userConnection, Guid templateId) {
			Entity report = userConnection.EntitySchemaManager.GetInstanceByName("SysModuleReport")
				.CreateEntity(userConnection);
			if (report.FetchFromDB("Id", templateId, new Collection<string> { "MacrosList", "File" })) {
				string macrosList = report.GetTypedColumnValue<string>("MacrosList");
				return report.GetBytesValue("File");
			}
			return new byte[1];
		}

		private string GetMacrosListByTemplateId(UserConnection userConnection, Guid templateId) {
			var entitySchemaManager = userConnection.EntitySchemaManager;
			var reportES = entitySchemaManager.GetInstanceByName("SysModuleReport");
			var reportESQ = new EntitySchemaQuery(entitySchemaManager, reportES.Name);
			var macroslistColumnName = reportESQ.AddColumn("MacrosList").Name;
			reportESQ.Filters.Add(reportESQ.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", templateId));
			EntityCollection reportCollection = reportESQ.GetEntityCollection(userConnection);
			if (reportCollection.Count > 0) {
				Entity reportEntity = reportCollection[0];
				return reportEntity.GetTypedColumnValue<string>(macroslistColumnName);
			}
			return string.Empty;
		}

		/// <summary>
		/// Returns entity values by column name.
		/// </summary>
		/// <param name="entityId">Entity id.</param>
		/// <param name="entityName">Entity name.</param>
		/// <param name="captions">Collection of captions.</param>
		/// <param name="templateId">Template id.</param>
		/// <returns>Object.</returns>
		private Dictionary<string, DataValue> GetEntityValuesByColumnName(UserConnection userConnection, Guid entityId, string entityName,
				Collection<string> captions, Guid templateId) {
			Dictionary<string, string> dicEsq = new Dictionary<string, string>();
			Dictionary<string, DataValue> fillDic = new Dictionary<string, DataValue>();
			if (captions.Count == 0) {
				return fillDic;
			}
			var expressionConverterHelper = new ExpressionConverterHelper();
			Dictionary<string, ColumnMacros> dicMacros = new Dictionary<string, ColumnMacros>();
			var entitySchemaManager = userConnection.EntitySchemaManager;
			var entitySchema = entitySchemaManager.GetInstanceByName(entityName);
			var esq = new EntitySchemaQuery(entitySchemaManager, entitySchema.Name);
			string macroslist = GetMacrosListByTemplateId(userConnection, templateId);
			if (string.IsNullOrEmpty(macroslist)) {
				return fillDic;
			}
			var macrosList = Json.Deserialize(macroslist) as JArray;
			foreach (string item in captions) {
				var fullColumnName = item.Trim();
				var currentMacrosList = expressionConverterHelper.MacrosList(fullColumnName);
				var columnName = expressionConverterHelper.GetColumnName(fullColumnName);
				if (currentMacrosList.Count > 0 && !dicMacros.ContainsKey(fullColumnName)) {
					dicMacros.Add(fullColumnName, new ColumnMacros {
						Name = fullColumnName,
						ColumnName = columnName,
						MacrosList = currentMacrosList
					});
				}
				if (!dicEsq.ContainsKey(columnName)) {
					AddColumnToEntitySchemaQuery(userConnection, esq, columnName, macrosList, dicEsq);
				}
			}
			EntitySchemaQueryExpressionCollection selectingQueryExpressions = esq.Columns.GetSelectingExpressions();
			if (selectingQueryExpressions.Count == 0) {
				return fillDic;
			}
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", entityId));
			EntityCollection entityCollection = esq.GetEntityCollection(userConnection);
			if (entityCollection.Count > 0) {
				AdditionalMacrosUtility additionalMacrosUtility = new AdditionalMacrosUtility(userConnection);
				foreach (KeyValuePair<string, string> item in dicEsq) {
					Entity entity = entityCollection[0];
					EntitySchemaColumn entityColumnName = entity.Schema.Columns.GetByName(item.Value);
					object value = additionalMacrosUtility.GetReportColumnValue(entity, entityColumnName);
					fillDic.Add(item.Key, new DataValue(entityColumnName.DataValueType, value));
					if (dicMacros.Count(d => d.Value.ColumnName == item.Key) > 0) {
						foreach (var macrosItem in dicMacros.Where(d => d.Value.ColumnName == item.Key)) {
							ColumnMacros macros = macrosItem.Value;
							ExpressionConverterValue macrosValue =
								expressionConverterHelper.GetValue(macros.MacrosList, value);
							fillDic.Add(macrosItem.Key, new DataValue(macrosValue.ValueType, macrosValue.Data));
						}
					}
				}
			}
			return fillDic;
		}

		private void AddColumnToEntitySchemaQuery(UserConnection userConnection, EntitySchemaQuery query, string caption, JArray columns,
				Dictionary<string, string> dicEsq) {
			JObject column = null;
			string macrosColumn = string.Empty;
			for (int i = 0; i < columns.Count; i++) {
				var metaPathCaptionColumn = columns[i].Value<string>("metaPathCaption");
				var captionColumn = columns[i].Value<string>("caption");
				metaPathCaptionColumn = metaPathCaptionColumn.Replace("\\", "\\\\");
				captionColumn = captionColumn.Replace("\\", "\\\\");
				if (captionColumn.Trim() == caption.Trim()) {
					column = columns[i] as JObject;
					macrosColumn = captionColumn.Trim();
					break;
				} else if (metaPathCaptionColumn.Trim() == caption.Trim()) {
					column = columns[i] as JObject;
					macrosColumn = metaPathCaptionColumn.Trim();
					break;
				}
			}
			if (column == null) {
				return;
			}
			EntitySchemaQueryColumn queryColumn = null;
			foreach (var esqColumn in query.Columns) {
				if (esqColumn.Caption.Value == column.Value<string>("caption")
						|| esqColumn.Caption.Value == column.Value<string>("metaPathCaption")) {
					queryColumn = esqColumn;
				}
			}
			if (queryColumn == null) {
				if (string.IsNullOrEmpty(column.Value<string>("aggregationType"))
						|| string.Compare(column.Value<string>("aggregationType"), "None", true) == 0) {
					queryColumn = query.AddColumn(
						query.RootSchema.GetSchemaColumnPathByMetaPath(column.Value<string>("metaPath")));
					if (queryColumn.DisplayExpression != null) {
						string displayValueMetaPath = queryColumn.DisplayExpression.Path;
						query.RemoveColumn(queryColumn.Name);
						queryColumn = query.AddColumn(displayValueMetaPath);
					}
				} else {
					EntitySchemaQuery subQuery;
					string queryColumnName = StringUtilities.CleanUpColumnName(
						query.RootSchema.GetSchemaColumnPathByMetaPath(column.Value<string>("metaPath")));
					string uniqueSuffix = query.Columns.Any(x => x.Name == queryColumnName)
						? query.Columns.Count.ToString()
						: string.Empty;
					queryColumn = query.AddColumn(
						query.RootSchema.GetSchemaColumnPathByMetaPath(column.Value<string>("metaPath")),
						(AggregationTypeStrict)Enum.Parse(typeof(AggregationTypeStrict),
						column.Value<string>("aggregationType")),
						out subQuery);
					if (!string.IsNullOrEmpty(column.Value<string>("subFilters"))) {
						var converter = new DataSourceFiltersJsonConverter(userConnection, subQuery.RootSchema) {
							PreventRegisteringClientScript = true
						};
						var filters = JsonConvert.DeserializeObject<DataSourceFilterCollection>(
								column.Value<string>("subFilters"), converter);
						EntitySchemaQueryFilterCollection esqFilters =
							filters.ToEntitySchemaQueryFilterCollection(subQuery);
						DisableEmptyEntitySchemaQueryFilters(esqFilters);
						subQuery.Filters.Add(esqFilters);
					}
					queryColumn.Name = queryColumnName + uniqueSuffix;
				}
			}
			queryColumn.UId = !string.IsNullOrEmpty(column.Value<string>("columnUId")) &&
				!new Guid(column.Value<string>("columnUId")).IsEmpty()
				? new Guid(column.Value<string>("columnUId"))
				: Guid.NewGuid();
			if (!string.IsNullOrEmpty(column.Value<string>("caption"))) {
				queryColumn.Caption = column.Value<string>("caption");
			} else if (!string.IsNullOrEmpty(column.Value<string>("metaPathCaption"))) {
				queryColumn.Caption = column.Value<string>("metaPathCaption");
			}
			queryColumn.IsAlwaysSelect = true;
			queryColumn.IsVisible = true;
			dicEsq.Add(macrosColumn, queryColumn.Name);
		}

		private static void DisableEmptyEntitySchemaQueryFilters(
				IEnumerable<IEntitySchemaQueryFilterItem> queryFilterCollection) {
			foreach (IEntitySchemaQueryFilterItem item in queryFilterCollection) {
				var filter = item as EntitySchemaQueryFilter;
				if (filter != null) {
					if (filter.RightExpressions.Count == 0 && filter.ComparisonType != FilterComparisonType.IsNull &&
							filter.ComparisonType != FilterComparisonType.IsNotNull) {
						filter.IsEnabled = false;
						continue;
					}
					if (filter.LeftExpression != null &&
							filter.LeftExpression.ExpressionType == EntitySchemaQueryExpressionType.SubQuery) {
						DisableEmptyEntitySchemaQueryFilters(filter.LeftExpression.SubQuery.Filters);
					}
					foreach (EntitySchemaQueryExpression rightExpression in filter.RightExpressions) {
						if (rightExpression.ExpressionType == EntitySchemaQueryExpressionType.SubQuery) {
							DisableEmptyEntitySchemaQueryFilters(rightExpression.SubQuery.Filters);
						}
					}
				} else {
					DisableEmptyEntitySchemaQueryFilters((EntitySchemaQueryFilterCollection)item);
				}
			}
		}

		private string GetTemplateNameByUId(UserConnection userConnection, Guid templateId) {
			Entity report = userConnection.EntitySchemaManager.GetInstanceByName("SysModuleReport")
				.CreateEntity(userConnection);
			if (report.FetchFromDB("Id", templateId, new Collection<string> { "Caption" })) {
				return report.GetTypedColumnValue<string>("Caption");
			}
			return string.Empty;
		}

		private string GetSchemaNameByTemplateId(UserConnection userConnection, Guid templateId) {
			var entitySchemaManager = userConnection.EntitySchemaManager;
			var reportES = entitySchemaManager.GetInstanceByName("SysModuleReport");
			var reportESQ = new EntitySchemaQuery(entitySchemaManager, reportES.Name);
			reportESQ.AddColumn(reportES.GetPrimaryColumnName());
			reportESQ.AddColumn("SysModule");
			string entitySchemaColumnName = reportESQ.AddColumn("SysModule.SysModuleEntity.SysEntitySchemaUId").Name;
			reportESQ.Filters.Clear();
			reportESQ.Filters.Add(reportESQ.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", templateId));
			EntityCollection reportCollection = reportESQ.GetEntityCollection(userConnection);
			if (reportCollection.Count > 0) {
				Entity reportEntity = reportCollection[0];
				EntitySchemaColumn schemaColumnName = reportEntity.Schema.Columns.GetByName(entitySchemaColumnName);
				var schemaId = reportEntity.GetTypedColumnValue<object>(schemaColumnName);
				return entitySchemaManager.GetInstanceByUId(new Guid(schemaId.ToString())).Name;
			}
			return string.Empty;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Generates DevExpress report.
		/// </summary>
		/// <param name="userConnection">User connection.</param>
		/// <param name="configuration">Provides configuration for report generator.</param>
		/// <returns>Returns prepared report.</returns>
		public ReportData Generate(UserConnection userConnection, ReportGeneratorConfiguration configuration) {
			var templateId = configuration.ReportTemplateId;
			var schemaName = GetSchemaNameByTemplateId(userConnection, templateId);
			var recordUId = configuration.RecordId;
			string reportName = GetTemplateNameByUId(userConnection, templateId);
			byte[] data = GetTemplateSource(userConnection, templateId);
			var openXmlUtility = new OpenXmlUtility(userConnection);
			using (MemoryStream stream = new MemoryStream()) {
				stream.Write(data, 0, data.Length);
				using (WordprocessingDocument docx = WordprocessingDocument.Open(stream, true)) {
					Collection<string> captions = openXmlUtility.GetMergeFieldName(docx);
					Dictionary<string, DataValue> dic = GetEntityValuesByColumnName(userConnection, recordUId, schemaName, captions, templateId);
					WordprocessingDocument report = openXmlUtility.GetWordReport(docx, dic);
					var additionalMacrosUtility = new AdditionalMacrosUtility(userConnection);
					additionalMacrosUtility.FillAdditionalMacros(report, recordUId, schemaName, templateId);
					docx.Close();
				}
				stream.Seek(0, SeekOrigin.Begin);
				return new ReportData { 
					Caption = reportName,
					Format = "docx",
					Data = stream.ToArray()
				};
			}
		}

		#endregion

	}

	#endregion

}

