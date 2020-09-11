namespace Terrasoft.Configuration.FileLoad
{
	using System;
	using System.Data;
	using System.IO;
	using global::Common.Logging;
	using Terrasoft.Configuration.FileUpload;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;

	#region Class: FileLoader

	public class FileLoader
	{
		#region Fields: Private

		private readonly UserConnection _userConnection;

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Creates instance of type <see cref="FileLoader"/>.
		/// </summary>
		/// <param name="userConnection">User connection.</param>
		public FileLoader(UserConnection userConnection) {
			_userConnection = userConnection;
		}

		#endregion

		#region Properties: Protected

		/// <summary>
		/// User connection.
		/// </summary>
		protected UserConnection UserConnection {
			get {
				return _userConnection;
			}
		}

		protected readonly ILog Log = LogManager.GetLogger("FileLoader");

		#endregion

		protected bool CheckReadFileAccess(EntitySchema entitySchema, Guid recordId) {
			DBSecurityEngine securityEngine = UserConnection.DBSecurityEngine;
			SchemaRecordRightLevels rights = securityEngine.GetEntitySchemaRecordRightLevel(entitySchema, recordId);
			return (rights & SchemaRecordRightLevels.CanRead) == SchemaRecordRightLevels.CanRead;

		}

		#region Methods: Public

		public virtual IFileUploadInfo LoadFile(Guid entitySchemaUId, Guid fileId,
			BinaryWriter binaryWriter) {
			EntitySchema entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(entitySchemaUId);
			if (!CheckReadFileAccess(entitySchema, fileId)) {
				Log.Info($"LoadFile: CheckReadFileAccess = false for fileId: ${fileId}");
				return null;
			}
			Entity entity = entitySchema.CreateEntity(UserConnection);
			Select selectData = (new Select(UserConnection)
					.Column("Name")
					.Column(Func.DataLength("Data")).As("Size")
					.Column("Data")
				.From(entity.SchemaName)
				.Where("Id")
					.IsEqual(Column.Parameter(fileId))) as Select;
			selectData.SpecifyNoLockHints();
			using (DBExecutor executor = UserConnection.EnsureDBConnection()) {
				using (IDataReader reader = selectData.ExecuteReader(executor, CommandBehavior.SequentialAccess)) {
					if (reader.Read()) {
						string fileName = reader["Name"].ToString();
						int sizeColumnIndex = reader.GetOrdinal("Size");
						object sizeValue = reader[sizeColumnIndex];
						if (DBNull.Value.Equals(sizeValue)) {
							Log.Info($"LoadFile: file size is null for fileId: ${fileId}");
							return null;
						}
						int size = UserConnection.DBTypeConverter.DBValueToInt(sizeValue);
						long offset = 0;
						int bufferOffset = 0;
						int chunkSize = 524288;
						byte[] buffer = new byte[chunkSize];
						long realBytes = 0;
						while (offset < size) {
							Array.Clear(buffer, 0, buffer.Length);
							realBytes = reader.GetBytes(2, offset, buffer, bufferOffset, chunkSize);
							if (realBytes <= 0) {
								break;
							}
							offset += realBytes;
							binaryWriter.Write(buffer, 0, Convert.ToInt32(realBytes));
							binaryWriter.Flush();
						}
						var feui = new FileEntityUploadInfo(entitySchema.Name, fileId, fileName);
						feui.TotalFileLength = size;
						return feui;
					}
				}
			}
			Log.Info($"LoadFile: file not found with Id: ${fileId}");
			return null;
		}

		#endregion
	}

	#endregion
}
