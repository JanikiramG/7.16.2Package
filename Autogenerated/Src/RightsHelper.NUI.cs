﻿namespace Terrasoft.Configuration.RightsService
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Security;
	using Newtonsoft.Json;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.OperationLog;

	public class RightsHelper
	{

		private UserConnection _userConnection;

		public RightsHelper(UserConnection userConnection) {
			_userConnection = userConnection;
		}

		#region Methods: Public

		/// <summary>
		/// #########, ### ######## ############, 
		/// ########### ######### #### ####### # ########.
		/// ########## ###### # ####### JSON, # ########### ##########.
		/// </summary>
		/// <returns>C##### # ####### JSON. 
		/// ######## ############### ###### # ######:
		/// Success - ########## ########## ######,
		/// ExMessage - ##### ######, #### Success = false </returns>
		public string CheckCanChangeAdminOperationGrantee(){
			bool success = false;
			string exMessage = String.Empty;
			try {
				DBSecurityEngine engine = _userConnection.DBSecurityEngine;
				engine.CheckCanChangeAdminOperationGrantee();
				success = true;
			}
			catch (Exception ex) {
				if (ex is SecurityException) {
					exMessage = ex.Message;
				} else {
					exMessage = new LocalizableString(_userConnection.ResourceStorage, "RightsHelper", 
						"LocalizableStrings.NonSecurityExeption.Value");
				}
			}
			return JsonConvert.SerializeObject(new {
					Success = success,
					ExMessage = exMessage
				});
		}
		
		/// <summary>
		/// ###### ##### ####### ############ # ########.
		/// ########## ###### # ####### JSON, # ########### ##########.
		/// </summary>
		/// <param name="adminOperationId">Id ########</param>
		/// <param name="adminUnitIds">###### Id #############/#####</param>
		/// <param name="canExecute">###### # ########</param>
		/// <returns>C##### # ####### JSON. 
		/// ######## ############### ###### # ######:
		/// Success - ########## ########## ######,
		/// ExMessage - ##### ######, #### Success = false </returns>
		public string SetAdminOperationGrantee(Guid adminOperationId, Guid[] adminUnitIds, bool canExecute) {
			bool success = false;
			string exMessage = string.Empty;
			try {
				if (_userConnection.IsSystemOperationsRestricted) {
					throw new SystemOperationRestrictedException();
				}
				DBSecurityEngine engine = _userConnection.DBSecurityEngine;
				foreach (var unitId in adminUnitIds) {
					engine.SetAdminOperationGrantee(adminOperationId, unitId, canExecute);
				}
				success = true;
			}
			catch (Exception ex) {
				if (ex is SecurityException) {
					exMessage = ex.Message;
				} else {
					exMessage = new LocalizableString(_userConnection.ResourceStorage, "RightsHelper", 
						"LocalizableStrings.NonSecurityExeption.Value");
				}
			}
			return JsonConvert.SerializeObject(new {
					Success = success,
					ExMessage = exMessage
				});
		}
		
		/// <summary>
		/// ###### ####### ##### ####### ############ # ########.
		/// ########## ###### # ####### JSON, # ########### ##########.
		/// </summary>
		/// <param name="granteeId">############# ##### #######.</param>
		/// <param name="position">##### ######## #### #######.</param>
		/// <returns>C##### # ####### JSON. 
		/// ######## ############### ###### # ######:
		/// Success - ########## ########## ######,
		/// ExMessage - ##### ######, #### Success = false </returns>
		public string SetAdminOperationGranteePosition(Guid granteeId, int position) {
			bool success = false;
			string exMessage = string.Empty;
			try {
				DBSecurityEngine engine = _userConnection.DBSecurityEngine;
				engine.CheckCanChangeAdminOperationGrantee();
				SetCustomRecordPosition("SysAdminOperationGrantee", granteeId, "SysAdminOperationId", position);
				success = true;
			}
			catch (Exception ex) {
				if (ex is SecurityException) {
					exMessage = ex.Message;
				} else {
					exMessage = new LocalizableString(_userConnection.ResourceStorage, "RightsHelper", 
						"LocalizableStrings.NonSecurityExeption.Value");
				}
			}
			return JsonConvert.SerializeObject(new {
					Success = success,
					ExMessage = exMessage
				});
		}
		
		/// <summary>
		/// ####### ##### ####### # ########.
		/// ########## ###### # ####### JSON, # ########### ##########.
		/// </summary>
		/// <param name="recordIds">###### Id #### #######</param>
		/// <returns>C##### # ####### JSON. 
		/// ######## ############### ###### # ######:
		/// Success - ########## ########## ######,
		/// ExMessage - ##### ######, #### Success = false </returns>
		public string DeleteAdminOperationGrantee(Guid[] recordIds) {
			bool success = false;
			string exMessage = string.Empty;
			try {
				DBSecurityEngine engine = _userConnection.DBSecurityEngine;
				foreach (var recordId in recordIds) {
					engine.DeleteAdminOperationGrantee(recordId);
				}
				success = true;
			}
			catch (Exception ex) {
				if (ex is SecurityException) {
					exMessage = ex.Message;
				} else {
					exMessage = new LocalizableString(_userConnection.ResourceStorage, "RightsHelper", 
						"LocalizableStrings.NonSecurityExeption.Value");
				}
			}
			return JsonConvert.SerializeObject(new {
					Success = success,
					ExMessage = exMessage
				});
		}

		/// <summary>
		/// Updates or inserts operation.
		/// </summary>
		/// <param name="recordId">Operation Id</param>
		/// <param name="name">Operation name</param>
		/// <param name="code">Operation code</param>
		/// <param name="description">Operation description</param>
		/// <returns>JSON-format string. 
		/// Includes serialized object whith fields:
		/// Success - the method is successfully executed.,
		/// ExMessage - string with error, if Success = false </returns>
		public string UpsertAdminOperation(Guid recordId, String name, String code, String description) {
			bool success = false;
			string exMessage = string.Empty;
			try {
				DBSecurityEngine engine = _userConnection.DBSecurityEngine;
				engine.CheckCanChangeAdminOperationGrantee();
				EntitySchema adminOperationTableSchema = _userConnection.EntitySchemaManager.GetInstanceByName("SysAdminOperation");
				Entity adminOperationEntity = adminOperationTableSchema.CreateEntity(_userConnection);
				if (!adminOperationEntity.FetchFromDB(recordId)) {
					adminOperationEntity.SetDefColumnValues();
				}
				adminOperationEntity.SetColumnValue("Id", recordId);
				adminOperationEntity.SetColumnValue("Name", name);
				adminOperationEntity.SetColumnValue("Code", code);
				adminOperationEntity.SetColumnValue("Description", description);
				adminOperationEntity.Save();
				success = true;
			}
			catch (Exception ex) {
				if (ex is SecurityException) {
					exMessage = ex.Message;
				} else {
					exMessage = new LocalizableString(_userConnection.ResourceStorage, "RightsHelper", 
						"LocalizableStrings.NonSecurityExeption.Value");
				}
			}
			return JsonConvert.SerializeObject(new {
					Success = success,
					ExMessage = exMessage
				});
		}

		/// <summary>
		/// Removes operations.
		/// Returns a string that is a JSON object representing execution result.
		/// </summary>
		/// <param name="recordIds">Array of operations identity</param>
		/// <returns>JSON-format string.
		/// Includes serialized object whith fields:
		/// Success - the method is successfully executed.,
		/// ExMessage - string with error, if Success = false </returns>
		public string DeleteAdminOperation(Guid[] recordIds) {
			bool success = false;
			string exMessage = string.Empty;
			try {
				DBSecurityEngine engine = _userConnection.DBSecurityEngine;
				engine.CheckCanChangeAdminOperationGrantee();
				EntitySchema adminOperationTableSchema = _userConnection.EntitySchemaManager.GetInstanceByName("SysAdminOperation");
				Entity adminOperationEntity = adminOperationTableSchema.CreateEntity(_userConnection);
				foreach (var recordId in recordIds) {
					if (adminOperationEntity.FetchFromDB("Id", recordId)) {
						adminOperationEntity.Delete();
					}
				}
				success = true;
			}
			catch (Exception ex) {
				if (ex is SecurityException) {
					exMessage = ex.Message;
				} else {
					exMessage = new LocalizableString(_userConnection.ResourceStorage, "RightsHelper", 
						"LocalizableStrings.NonSecurityExeption.Value");
				}
			}
			return JsonConvert.SerializeObject(new {
					Success = success,
					ExMessage = exMessage
				});
		}
		
		public SchemaOperationRightLevels GetSchemaOperationRightLevel(string schemaName) {
			var securityEngine = _userConnection.DBSecurityEngine;
			return securityEngine.GetEntitySchemaOperationsRightLevel(schemaName);
		}
		public bool GetCanAppendSchemaOperationRight(string schemaName) {
			var securityEngine = _userConnection.DBSecurityEngine;
			return securityEngine.GetIsEntitySchemaAppendingAllowed(schemaName);
		}
		public bool GetCanDeleteSchemaOperationRight(string schemaName) {
			var securityEngine = _userConnection.DBSecurityEngine;
			return securityEngine.GetIsEntitySchemaDeletingAllowed(schemaName);
		}
		public bool GetCanEditSchemaOperationRight(string schemaName) {
			var securityEngine = _userConnection.DBSecurityEngine;
			return securityEngine.GetIsEntitySchemaEditingAllowed(schemaName);
		}
		public bool GetCanReadSchemaOperationRight(string schemaName) {
			var securityEngine = _userConnection.DBSecurityEngine;
			return securityEngine.GetIsEntitySchemaReadingAllowed(schemaName);
		}
		public SchemaRecordRightLevels GetSchemaRecordRightLevel(string schemaName, Guid primaryColumnValue) {
			var securityEngine = _userConnection.DBSecurityEngine;
			var rightLevel = securityEngine.GetEntitySchemaRecordRightLevel(schemaName, primaryColumnValue);
			if (_userConnection.IsSystemOperationsRestricted) {
				rightLevel &= SchemaRecordRightLevels.CanRead | SchemaRecordRightLevels.CanEdit |
					SchemaRecordRightLevels.CanDelete;
			}
			return rightLevel;
		}
		
		public bool GetCanDeleteSchemaRecordRight(string schemaName, Guid primaryColumnValue) {
			var canDeleteRight = SchemaRecordRightLevels.CanDelete;
			bool canDeleteRecord = GetHasSchemaRecordRight(schemaName, primaryColumnValue, canDeleteRight);
			if (!canDeleteRecord) {
				OperationLogger.Instance.LogDeniedOperationDelete(_userConnection, schemaName);
			}
			return canDeleteRecord;
		}
		public bool GetCanChangeDeleteSchemaRecordRight(string schemaName, Guid primaryColumnValue) {
			var canDeleteRight = SchemaRecordRightLevels.CanChangeDeleteRight;
			bool canChangeDeleteRight = GetHasSchemaRecordRight(schemaName, primaryColumnValue, canDeleteRight);
			if (!canChangeDeleteRight) {
				OperationLogger.Instance.LogDeniedChangeSchemaRecordRightDelete(_userConnection, schemaName);
			}
			return canChangeDeleteRight;
		}
		
		public bool GetCanReadSchemaRecordRight(string schemaName, Guid primaryColumnValue) {
			var canDeleteRight = SchemaRecordRightLevels.CanRead;
			return GetHasSchemaRecordRight(schemaName, primaryColumnValue, canDeleteRight);
		}

		public bool GetCanChangeReadSchemaRecordRight(string schemaName, Guid primaryColumnValue) {
			var canDeleteRight = SchemaRecordRightLevels.CanChangeReadRight;
			return GetHasSchemaRecordRight(schemaName, primaryColumnValue, canDeleteRight);
		}
		
		public bool GetCanEditSchemaRecordRight(string schemaName, Guid primaryColumnValue) {
			var canEditRight = SchemaRecordRightLevels.CanEdit;
			bool canEditRecord = GetHasSchemaRecordRight(schemaName, primaryColumnValue, canEditRight);
			if (!canEditRecord) {
				OperationLogger.Instance.LogDeniedOperationEdit(_userConnection, schemaName);
			}
			return canEditRecord;
		}
		public bool GetCanChangeEditRightSchemaRecordRight(string schemaName, Guid primaryColumnValue) {
			var canChangeEditRight = SchemaRecordRightLevels.CanChangeEditRight;
			bool canChangeEditRecordRight = GetHasSchemaRecordRight(schemaName, primaryColumnValue, canChangeEditRight);
			if (!canChangeEditRecordRight) {
				OperationLogger.Instance.LogDeniedChangeSchemaRecordRightEdit(_userConnection, schemaName);
			}
			return canChangeEditRecordRight;
		}

		protected bool GetHasSchemaRecordRight(string schemaName, Guid primaryColumnValue, SchemaRecordRightLevels rightLevel) {
			var schemaRightLevel = GetSchemaRecordRightLevel(schemaName, primaryColumnValue);
			return (schemaRightLevel & rightLevel) == rightLevel;
		}

		public bool CheckCanEditColumn(string schemaName, string columnName) {
			var securityEngine = _userConnection.DBSecurityEngine;
			return securityEngine.GetIsEntitySchemaColumnEditingAllowed(schemaName, columnName);
		}

		/// <summary>
		/// Apply changes in record rights.
		/// </summary>
		/// <param name="recordRights">Array of changes</param>
		/// <param name="record">Record information</param>
		public virtual void ApplyChanges(RecordRight[] recordRights, Record record) {
			if (_userConnection.IsSystemOperationsRestricted) {
				throw new SystemOperationRestrictedException();
			}
			var rightsSchemaName = GetRecordRightsSchemaDefName(record.entitySchemaName);
			var newItems = recordRights.Where(newItem => newItem.isNew == true).ToArray();
			var editedItems = recordRights.Where(editedItem => editedItem.isNew == false && editedItem.isDeleted == false).ToArray();
			var deletedItems = recordRights.Where(deletedItem => deletedItem.isDeleted == true).ToArray();
			using (DBExecutor dbExecutor = _userConnection.EnsureDBConnection()) {
				dbExecutor.StartTransaction();
				try {
					AddNewRecordRights(newItems, rightsSchemaName, record);
					UpdateRecordRights(editedItems, rightsSchemaName, record);
					DeleteRecordRights(deletedItems, record);
					dbExecutor.CommitTransaction();
				} catch (SecurityException) {
					dbExecutor.RollbackTransaction();
					throw;
				}
			}
		}

		/// <summary>
		/// Create new rights for record.
		/// </summary>
		/// <param name="recordRights">Array of new rights</param>
		/// <param name="rightsSchemaName">Rights entity schema name</param>
		/// <param name="record">Record information</param>
		public void AddNewRecordRights(RecordRight[] recordRights, string rightsSchemaName, Record record) {
			foreach(var item in recordRights) {
					var newRecordId = SetRecordRight(item.SysAdminUnit.value, record.entitySchemaName, record.primaryColumnValue, item.Operation, item.RightLevel);
					if (item.Position >= 0) {
						SetRecordPosition(rightsSchemaName, newRecordId, item.Position);
					}
			}
		}

		/// <summary>
		/// Update rights for record.
		/// </summary>
		/// <param name="recordRights">Array of changed rights</param>
		/// <param name="rightsSchemaName">Rights entity schema name</param>
		/// <param name="record">Record information</param>
		public void UpdateRecordRights(RecordRight[] recordRights, string rightsSchemaName, Record record) {
			foreach(var item in recordRights) {
					if (item.RightLevel >= 0) {
						SetRecordRight(item.SysAdminUnit.value, record.entitySchemaName, record.primaryColumnValue, item.Operation, item.RightLevel);
					}
					if (item.Position >= 0) {
						SetRecordPosition(rightsSchemaName, item.Id, item.Position);
					}
			}
		}

		/// <summary>
		/// Remove rights for record.
		/// </summary>
		/// <param name="recordRights">Array of removed rights</param>
		/// <param name="record">Record information</param>
		public void DeleteRecordRights(RecordRight[] recordRights, Record record) {
			foreach(var item in recordRights) {
				DeleteEntitySchemaRecordRightLevel(item.SysAdminUnit.value, item.Operation, record.entitySchemaName, new Guid(record.primaryColumnValue));
			}
		}
		
		public  List<RecordRight> GetRecordRights(string tableName, string recordId) {
			var result = new List<RecordRight>();
			var sysRecordRightsSelect = new Select(_userConnection)
				.Column("SysAdminUnit", "Id").As("SysAdminUnitId")
				.Column("SysAdminUnit", "Name").As("SysAdminUnitName")
				.Column("SysAdminUnitType", "Id").As("SysAdminUnitTypeId")
				.Column("SysEntitySchemaRecOprRightLvl", "Value").As("RightLevelValue")
				.Column(tableName, "Id")
				.Column(tableName, "Operation")
				.Column(tableName, "Position")
				.From(tableName)
					.InnerJoin("SysEntitySchemaRecOprRightLvl")
						.On(tableName, "RightLevel")
							.IsEqual("SysEntitySchemaRecOprRightLvl", "Value")
					.InnerJoin("SysAdminUnit")
						.On(tableName, "SysAdminUnitId")
							.IsEqual("SysAdminUnit", "Id")
					.InnerJoin("SysAdminUnitType")
						.On("SysAdminUnit", "SysAdminUnitTypeValue")
							.IsEqual("SysAdminUnitType", "Value")
				.Where(tableName, "RecordId")
					.IsEqual(Column.Parameter(recordId, _userConnection.DataValueTypeManager.GetInstanceByName("Guid")))
				.And("Position")
					.IsGreater(Column.Parameter(-1))
				.OrderByAsc(tableName, "Operation")
				.OrderByAsc(tableName, "Position") as Select;
			using (var dbExecutor = _userConnection.EnsureDBConnection()) {
				using (var dr = sysRecordRightsSelect.ExecuteReader(dbExecutor)) {
					while (dr.Read()) {
						result.Add(new RecordRight {
							Id = _userConnection.DBTypeConverter.DBValueToGuid(dr["Id"]),
							SysAdminUnit = new SysAdminUnit {
								value = _userConnection.DBTypeConverter.DBValueToGuid(dr["SysAdminUnitId"]),
								displayValue = dr["SysAdminUnitName"].ToString()
							},
							SysAdminUnitType = _userConnection.DBTypeConverter.DBValueToGuid(dr["SysAdminUnitTypeId"]),
							Operation = _userConnection.DBTypeConverter.DBValueToInt(dr["Operation"]),
							RightLevel = _userConnection.DBTypeConverter.DBValueToInt(dr["RightLevelValue"]),
							Position = _userConnection.DBTypeConverter.DBValueToInt(dr["Position"])
						});
					}
				}
			}
			return result;
		}

		public virtual Guid SetRecordRight(Guid adminUnitId, string schemaName, string administratedRecordId,
				int operation, int rightLevel) {
			var useDenyRecordRights = _userConnection.EntitySchemaManager.GetInstanceByName(schemaName).UseDenyRecordRights;
			var rightId = _userConnection.DBSecurityEngine.SetEntitySchemaRecordRightLevel(adminUnitId, schemaName,
					Guid.Parse(administratedRecordId), (EntitySchemaRecordRightOperation)operation,
					(EntitySchemaRecordRightLevel)rightLevel, useDenyRecordRights);
			return rightId;
		}

		public virtual void SetCustomRecordPosition(string tableName, Guid primaryColumnValue, string grouppingColumnNames, int position) {
			var setRecordPositionProcedure = new StoredProcedure(_userConnection, "tsp_SetRecordPosition")
				.WithParameter("TableName", tableName)
				.WithParameter("PrimaryColumnName", "Id")
				.WithParameter("PrimaryColumnValue", primaryColumnValue)
				.WithParameter("GrouppingColumnNames", grouppingColumnNames)
				.WithParameter("Position", position) as StoredProcedure;
			setRecordPositionProcedure.PackageName = _userConnection.DBEngine.SystemPackageName;
			setRecordPositionProcedure.Execute();
		}

		public virtual void DeleteEntitySchemaRecordRightLevel(Guid adminUnitId, int operation, string recordSchemaName, Guid primaryColumnValue) {
			var rightsSchemaName = GetRecordRightsSchemaDefName(recordSchemaName);
			var entitySchemaRecordRightOperation = (EntitySchemaRecordRightOperation)operation;
			SchemaRecordRightLevels currentUserRecordRightLevel =
				_userConnection.DBSecurityEngine.GetEntitySchemaRecordRightLevel(recordSchemaName, primaryColumnValue);
			if (!_userConnection.DBSecurityEngine.GetCanExecuteOperation("CanChangeEntitySchemaRecordRight")) {
				if ((entitySchemaRecordRightOperation == EntitySchemaRecordRightOperation.Read &&
						!(currentUserRecordRightLevel.HasFlag(SchemaRecordRightLevels.CanChangeReadRight))) ||
						(entitySchemaRecordRightOperation == EntitySchemaRecordRightOperation.Edit &&
							!currentUserRecordRightLevel.HasFlag(SchemaRecordRightLevels.CanChangeEditRight)) ||
						(entitySchemaRecordRightOperation == EntitySchemaRecordRightOperation.Delete &&
							!currentUserRecordRightLevel.HasFlag(SchemaRecordRightLevels.CanChangeDeleteRight))) {
					throw new SecurityException(string.Format(new LocalizableString("Terrasoft.Core",
						"DBSecurityEngine.Exception.NoDistributingMoreRightsFor.RecordThanYouHave"),
						recordSchemaName));
				}
			}
			_userConnection.DBSecurityEngine.ForceDeleteEntitySchemaRecordRightLevel(adminUnitId,
				entitySchemaRecordRightOperation, recordSchemaName, primaryColumnValue);
		}

		/// <summary>
		/// Copies access rights from a source record to a target record.
		/// </summary>
		/// <param name="schemaName">Name of the schema where the source and the destination records should be</param>
		/// <param name="sourceId">Identifier of the record which access rights will be copied from.</param>
		/// <param name="targetId">Identifier of the record where access rights will be copied to</param>
		/// <returns></returns>
		public void CopyRecordRights(string schemaName, Guid sourceId, Guid targetId) {
			schemaName.CheckArgumentNullOrEmpty("schemaName");
			sourceId.CheckArgumentEmpty("sourceId");
			targetId.CheckArgumentEmpty("targetId");
			var rightsSchemaName = GetRecordRightsSchemaDefName(schemaName);
			var recordRights = GetRecordRights(rightsSchemaName, sourceId.ToString());
			var record = new Record() {
				entitySchemaName = schemaName,
				primaryColumnValue = targetId.ToString()
			};
			ApplyChanges(recordRights.ToArray(), record);
		}

		#endregion

		#region Methods: Private

		private string GetRecordRightsSchemaDefName(string sourceSchema) {
			return sourceSchema.StartsWith("Sys") ?
				string.Concat(sourceSchema, "Right") : string.Concat("Sys", sourceSchema, "Right");
		}

		private void SetRecordPosition(string schemaName, Guid primaryColumnValue, int position) {
			SetCustomRecordPosition(schemaName, primaryColumnValue, "Operation,RecordId", position);
		}

		#endregion
	}
	
	
	public class Record
	{

		#region Properties: Public

		public string entitySchemaName { get; set; }
		public string entitySchemaCaption { get; set; }
		public string primaryColumnValue { get; set; }
		public string primaryDisplayColumnValue { get; set;}

		#endregion

	}

	public class RecordRight
	{

		#region Properties: Public

		public Guid Id { get; set; }
		public Guid SysAdminUnitType { get; set; }
		public SysAdminUnit SysAdminUnit { get; set; }
		public int Operation { get; set; }
		public int RightLevel { get; set; }
		public int Position { get; set; }
		public bool isNew { get; set; }
		public bool isDeleted { get; set; }

		#endregion

		#region Constructors: Public

		public RecordRight() {
			RightLevel = -1;
			Position = -1;
		}

		#endregion

	}

	public class SysAdminUnit
	{

		#region Properties: Public

		public Guid value { get; set; }
		public string displayValue { get; set;}

		#endregion

	}

	public class RightLevel
	{

		#region Properties: Public

		public string Name { get; set; }
		public int Value { get; set;}

		#endregion

	}

}
