namespace Terrasoft.Configuration.FileUpload
{
	using System;
	using System.Linq;
	using System.Collections.Generic;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using TSConfiguration = Terrasoft.Core.Configuration;

	#region Class: FileUploader

	public class FileUploader
	{
		#region Constants: Private

		private const string MaxFileSizeSysSettingName = "MaxFileSize";
		private decimal _maxFileSize = -1;
		
		#endregion

		#region Properties: Private

		private decimal MaxFileSize {
			get {
				if (_maxFileSize > 0) {
					return _maxFileSize;
				}
				int value = TSConfiguration.SysSettings.GetValue(UserConnection, MaxFileSizeSysSettingName, 0);
				_maxFileSize = FileSizeConverter.MbToBytes(value);
				return _maxFileSize;
			}
		}

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Creates instance of type <see cref="FileUploader"/>.
		/// </summary>
		/// <param name="userConnection">User connection.</param>
		public FileUploader(UserConnection userConnection) {
			UserConnection = userConnection;
		}

		#endregion

		#region Properties: Protected

		/// <summary>
		/// User connection.
		/// </summary>
		protected UserConnection UserConnection { get; }

		#endregion

		#region Methods: Private

		/// <summary>
		/// Appends file content into database.
		/// </summary>
		/// <param name="fileUploadInfo">File upload information.</param>
		private void AppendData(IFileUploadInfo fileUploadInfo) {
			DBLobUtilities.AppendBlob(UserConnection, fileUploadInfo.EntitySchemaName, fileUploadInfo.ColumnName,
				fileUploadInfo.FileId, fileUploadInfo.Content);
		}

		/// <summary>
		/// Returns file entity.
		/// </summary>
		/// <param name="fileUploadInfo">File upload info.</param>
		/// <returns>File entity.</returns>
		private Entity GetFileEntity(IFileUploadInfo fileUploadInfo) {
			EntitySchema entitySchema = UserConnection.EntitySchemaManager.GetInstanceByName(fileUploadInfo.EntitySchemaName);
			Entity entity = entitySchema.CreateEntity(UserConnection);
			entity.UseAdminRights = false;
			if (!entity.FetchFromDB(fileUploadInfo.FileId)) {
				entity.SetDefColumnValues();
				EntitySchemaColumn column = entitySchema.Columns.FindByName(fileUploadInfo.ParentColumnName);
				entity.SetColumnValue(column.ColumnValueName, fileUploadInfo.ParentColumnValue);
			}
			entity.SetStreamValue(fileUploadInfo.ColumnName, fileUploadInfo.Content);
			entity.SetColumnValue("Size", fileUploadInfo.TotalFileLength);
			return entity;
		}
		
		private void UploadInternal(IFileUploadConfig fileUploadConfig) {
			if (!fileUploadConfig.IsChunkedUpload || fileUploadConfig.IsFirstChunk) {
				Save(fileUploadConfig.FileUploadInfo, fileUploadConfig.SetCustomColumnsFromConfig);
			} else {
				AppendData(fileUploadConfig);
			}
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Gets maximum file size system setting value in bytes.
		/// </summary>
		/// <returns>File size system setting value in bytes.</returns>
		[Obsolete("7.16.0 | Property is obsolete and will be removed in upcoming releases")]
		protected decimal GetMaxFileSize() => MaxFileSize;

		/// <summary>
		/// Saves file content into database.
		/// </summary>
		/// <param name="fileUploadInfo">File upload information.</param>
		/// <param name="isSetCustomColumns">Is set custom columns.</param>
		protected void Save(IFileUploadInfo fileUploadInfo, bool isSetCustomColumns = true) {
			Entity entity = GetFileEntity(fileUploadInfo);
			if (isSetCustomColumns) {
				SetCustomColumns(entity, fileUploadInfo);
			}
			Dictionary<string, object> additionalParams = fileUploadInfo.AdditionalParams;
			if (!additionalParams.IsNullOrEmpty() && additionalParams.Keys.Count > 0) {
				SetAdditionalColumns(entity, additionalParams);
			}
			entity.Save();
		}

		/// <summary>
		/// Sets custom columns to <paramref name="entity"/> according to <paramref name="fileUploadInfo"/>.
		/// </summary>
		/// <param name="entity">File entity.</param>
		/// <param name="fileUploadInfo">File upload information.</param>
		protected virtual void SetCustomColumns(Entity entity, IFileUploadInfo fileUploadInfo) {
			entity.SetColumnValue("Id", fileUploadInfo.FileId);
			entity.SetColumnValue("Name", fileUploadInfo.FileName);
			entity.SetColumnValue("TypeId", fileUploadInfo.TypeId);
			entity.SetColumnValue("Version", fileUploadInfo.Version);
		}

		/// <summary>
		/// Sets additional columns to <paramref name="entity"/> according to <paramref name="additionalParams"/>.
		/// </summary>
		/// <param name="entity">File entity.</param>
		/// <param name="additionalParams">File upload information.</param>
		protected virtual void SetAdditionalColumns(Entity entity, Dictionary<string, object> additionalParams) {
			var entityColumns = entity.GetColumnValueNames();
			foreach (var additionalColumnName in additionalParams.Keys) {
				if (entityColumns.Any(entityColumnName => entityColumnName == additionalColumnName)) {
					entity.SetColumnValue(additionalColumnName, additionalParams[additionalColumnName]);
				}
			}
		}

		/// <summary>
		/// Checks validity of file size.
		/// </summary>
		/// <param name="totalFileLength"></param>
		/// <returns>Is file size valid.</returns>
		protected bool CheckMaxFileSize(decimal totalFileLength) {
			return MaxFileSize != 0 && totalFileLength > MaxFileSize;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Uploads file content.
		/// </summary>
		/// <param name="fileUploadInfo">File upload information.</param>
		/// <returns>File upload result.</returns>
		[Obsolete("Deprecated since 7.11.2. Use UploadFile instead")]
		public virtual string Upload(IFileUploadInfo fileUploadInfo) {
			UploadFile(fileUploadInfo);
			return "Ok";
		}

		/// <summary>
		/// Uploads file.
		/// </summary>
		/// <param name="fileUploadInfo">File upload information.</param>
		/// <returns>Is operation successful.</returns>
		public virtual bool UploadFile(IFileUploadInfo fileUploadInfo) {
			return UploadFile(fileUploadInfo, true);
		}

		/// <summary>
		/// Uploads file.
		/// </summary>
		/// <param name="fileUploadInfo">File upload information.</param>
		/// <param name="isSetCustomColumns">Is set custom columns.</param>
		/// <returns>Is operation successful.</returns>
		public virtual bool UploadFile(IFileUploadInfo fileUploadInfo, bool isSetCustomColumns) {
			UploadFile(new FileUploadConfig(fileUploadInfo) {
				SetCustomColumnsFromConfig = isSetCustomColumns
			});
			return true;
		}

		/// <summary>
		/// Uploads file.
		/// </summary>
		/// <param name="fileUploadInfoConfig">File upload information.<see cref="IFileUploadConfig"/></param>
		/// <returns></returns>
		/// <exception cref="MaxFileSizeExceededException"></exception>
		public virtual void UploadFile(IFileUploadConfig fileUploadInfoConfig) {
			fileUploadInfoConfig.CheckArgumentNull(nameof(fileUploadInfoConfig));
			_maxFileSize = fileUploadInfoConfig.MaxFileSize;
			if (CheckMaxFileSize(fileUploadInfoConfig.TotalFileLength)) {
				throw new MaxFileSizeExceededException(UserConnection.Workspace.ResourceStorage);
			}
			UploadInternal(fileUploadInfoConfig);
		}

		#endregion
	}

	#endregion
}
