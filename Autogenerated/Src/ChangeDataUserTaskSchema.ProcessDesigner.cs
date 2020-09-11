namespace Terrasoft.Core.Process.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.UI.WebControls.Controls;

	#region Class: ChangeDataUserTaskSchema

	/// <exclude/>
	public class ChangeDataUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public ChangeDataUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public ChangeDataUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d3021ca7-7450-4678-a117-060171eb2976");
			RealUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976");
			Name = "ChangeDataUserTask";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
			ParametersEditPageSchemaV2UId = new Guid("f9c58aa4-3c7c-4266-a967-013164e169f1");
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,81,111,155,48,16,126,134,95,65,121,168,136,20,161,238,185,138,180,44,77,163,72,107,183,150,102,123,152,246,224,192,37,88,117,108,102,159,215,177,41,255,189,103,96,173,129,104,171,132,4,220,221,119,247,221,231,79,126,31,243,93,148,44,37,114,172,179,188,132,3,219,172,139,116,249,195,50,97,146,149,229,244,125,168,176,158,76,162,63,97,160,1,173,150,209,142,114,112,25,30,67,31,22,129,255,51,139,54,6,244,66,73,9,57,114,37,83,191,244,134,73,182,7,157,174,0,215,210,32,147,57,124,168,105,236,144,198,228,50,116,228,238,33,87,186,88,40,97,15,242,11,19,22,76,218,189,22,202,74,140,102,179,232,194,167,135,218,54,236,126,50,221,35,117,103,65,215,196,76,194,83,180,28,198,147,255,243,157,246,186,165,183,236,0,196,112,52,33,165,78,243,226,192,229,61,223,151,104,104,96,167,215,184,114,189,151,74,195,21,55,149,96,117,187,19,149,175,132,218,50,49,175,170,12,16,185,220,155,244,26,24,109,6,39,202,215,242,138,33,115,220,31,152,121,52,167,134,204,139,98,46,68,27,105,69,52,73,167,236,218,220,48,204,75,90,187,224,110,107,211,200,248,89,171,28,140,249,219,116,131,92,80,150,228,206,42,200,249,174,94,102,119,215,92,32,104,51,16,109,26,97,201,77,95,166,233,248,8,166,97,16,56,214,153,178,58,135,174,21,49,10,182,74,137,136,155,198,112,109,152,212,24,47,212,33,188,211,39,172,91,231,172,143,61,63,127,11,248,93,179,115,224,204,178,107,114,43,173,108,245,175,193,223,46,190,71,204,140,45,212,166,73,98,209,202,65,172,26,90,126,219,51,178,159,21,194,113,243,194,67,35,19,110,160,66,235,233,32,56,134,238,113,93,123,21,45,10,75,173,158,26,123,223,210,140,79,186,41,88,254,202,161,114,116,18,151,248,168,114,38,248,111,182,21,144,161,38,115,37,113,252,0,90,51,163,118,72,52,52,196,177,59,159,32,142,59,27,116,198,41,153,220,131,239,181,244,165,113,250,154,252,202,177,244,104,197,241,196,157,235,241,229,170,120,21,167,147,215,11,156,82,156,110,136,33,112,224,57,234,191,169,10,134,48,170,27,14,232,59,145,112,254,117,17,63,3,180,178,191,34,8,5,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateEntitySchemaUIdParameter());
			Parameters.Add(CreateIsMatchConditionsParameter());
			Parameters.Add(CreateDataSourceFiltersParameter());
			Parameters.Add(CreateRecordColumnValuesParameter());
		}

		protected virtual ProcessSchemaParameter CreateEntitySchemaUIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("bd2cf1ae-bbc6-4d91-8d6e-c6b40f057e95"),
				Name = "EntitySchemaUId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateIsMatchConditionsParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("d6c84ba1-b6ca-4952-b517-880f22e21fdc"),
				Name = "IsMatchConditions",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"true",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				},
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateDataSourceFiltersParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("03166c4b-2e15-4768-a343-750c16b69691"),
				Name = "DataSourceFilters",
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateRecordColumnValuesParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("effa11ce-90c7-4efe-8a02-be7a659d27e9"),
				Name = "RecordColumnValues",
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetResultParameterAllValuesMethod());
			Methods.Add(CreateUpdateEntityCollectionMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("52fca718-c7ac-437b-9267-8d393a6dc1cc"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("3a8a8efd-87b4-44e2-92ae-c3e975701b97"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("2ede4635-4427-4153-9fb2-d9d46cae996c")
			});
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3585e965-d43b-43f1-97ee-06a8679a50c8"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e62c4114-493a-4303-8cde-814bd0c5e856"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("33392bc2-629e-423d-ad3e-1e59ec675a7a"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,113,47,205,76,209,81,40,46,41,202,204,75,183,211,208,180,6,0,179,24,102,192,38,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateEntityCollectionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c6de7011-ba42-4d78-9943-9f4c045f0d03"),
				Name = "UpdateEntityCollection",
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				CreatedInPackageId = new Guid("3949d191-f356-45da-a437-95abb1839b71"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("fce65d67-6cdc-4dbd-8a66-7f5b6279a7a1"),
				Name = "entityCollection",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntityCollection",
				CreatedInPackageId = new Guid("3949d191-f356-45da-a437-95abb1839b71")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c56c2f30-e948-4de7-bb00-489093c18a94"),
				Name = "entitySchema",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntitySchema",
				CreatedInPackageId = new Guid("3949d191-f356-45da-a437-95abb1839b71")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,83,75,110,219,48,16,93,75,167,24,24,93,208,128,193,3,180,77,1,39,49,138,160,105,107,196,78,55,69,23,12,53,182,216,72,164,48,36,157,8,134,238,94,126,164,84,6,178,17,9,206,155,247,25,82,214,145,210,71,248,138,238,22,159,252,241,78,31,12,219,104,167,92,15,214,120,146,184,132,115,89,156,4,129,10,37,184,2,141,47,176,235,173,195,150,239,241,213,241,93,34,184,246,170,169,144,216,242,83,89,56,234,99,79,17,27,248,186,235,80,87,44,115,241,157,172,177,21,63,68,139,17,120,129,248,176,0,118,190,128,241,45,169,86,80,127,99,26,223,106,30,187,134,143,240,123,2,93,84,127,137,198,227,240,103,185,136,188,3,72,225,100,13,108,243,42,177,115,202,232,20,98,40,11,66,231,73,167,40,124,111,178,245,232,121,40,15,134,80,164,158,28,30,243,162,244,184,11,50,13,202,55,174,41,227,216,198,190,97,159,44,108,133,162,207,54,241,174,192,60,253,13,45,95,64,254,183,24,9,31,80,26,170,102,190,45,207,75,98,46,138,236,32,207,32,163,70,134,48,125,156,213,120,184,180,57,234,186,255,142,78,108,133,171,217,76,145,7,107,105,216,69,182,3,167,228,227,106,238,42,235,39,144,58,0,219,146,145,104,237,163,69,218,11,251,252,232,84,163,156,10,54,131,224,157,221,180,157,235,239,141,121,246,221,79,186,21,14,247,170,197,68,192,18,245,106,100,230,161,38,210,249,190,239,112,57,134,43,38,121,237,155,38,41,14,241,147,115,241,29,186,217,92,198,24,171,108,57,133,136,224,17,27,236,173,171,86,233,7,117,172,157,13,140,7,209,216,20,98,34,19,39,100,233,240,253,71,1,249,109,23,249,186,160,154,222,127,160,186,248,29,50,93,146,191,55,71,190,33,50,196,22,235,208,31,119,96,164,244,68,88,65,229,19,79,151,167,7,216,96,27,90,225,236,106,101,7,120,169,81,131,239,42,225,34,72,76,239,10,206,111,186,195,98,5,217,106,57,252,3,151,212,89,212,151,3,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ChangeDataUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d3021ca7-7450-4678-a117-060171eb2976"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new ChangeDataUserTask(userConnection) {
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976")
			};
		}

		#endregion

	}

	#endregion

	#region Class: ChangeDataUserTask

	[DesignModeProperty(Name = "EntitySchemaUId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "d3021ca774504678a117060171eb2976", CaptionResourceItem = "Parameters.EntitySchemaUId.Caption", DescriptionResourceItem = "Parameters.EntitySchemaUId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "IsMatchConditions", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "d3021ca774504678a117060171eb2976", CaptionResourceItem = "Parameters.IsMatchConditions.Caption", DescriptionResourceItem = "Parameters.IsMatchConditions.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "DataSourceFilters", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "d3021ca774504678a117060171eb2976", CaptionResourceItem = "Parameters.DataSourceFilters.Caption", DescriptionResourceItem = "Parameters.DataSourceFilters.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "RecordColumnValues", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "d3021ca774504678a117060171eb2976", CaptionResourceItem = "Parameters.RecordColumnValues.Caption", DescriptionResourceItem = "Parameters.RecordColumnValues.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class ChangeDataUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public ChangeDataUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976");
			_isMatchConditions = () => { return true; };
		}

		#endregion

		#region Properties: Public

		public virtual Guid EntitySchemaUId {
			get;
			set;
		}

		private Func<bool> _isMatchConditions;
		public virtual bool IsMatchConditions {
			get {
				return (_isMatchConditions ?? (_isMatchConditions = () => false)).Invoke();
			}
			set {
				_isMatchConditions = () => { return value; };
			}
		}

		public virtual string DataSourceFilters {
			get;
			set;
		}

		private EntityColumnMappingValues _recordColumnValues;
		public virtual EntityColumnMappingValues RecordColumnValues {
			get {
				return _recordColumnValues ?? ( _recordColumnValues = new EntityColumnMappingValues (
					new Dictionary<string, object>(),
					new Dictionary<string, string>()));
			}
			set {
				_recordColumnValues = value;
			}
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			if (EntitySchemaUId.Equals(Guid.Empty)) {
				return false;
			}
			EntitySchema entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(EntitySchemaUId);
			if (RecordColumnValues.Values.Count == 0) {
				return true;
			}
			var entitySchemaQuery = new EntitySchemaQuery(UserConnection.EntitySchemaManager, entitySchema.Name);
			entitySchemaQuery.UseAdminRights = false;
			entitySchemaQuery.IgnoreDisplayValues = GlobalAppSettings.FeatureIgnoreDisplayValuesInDataUserTasks;
			entitySchemaQuery.AddAllSchemaColumns();
			if (IsMatchConditions) {
				ProcessUserTaskUtilities.SpecifyESQFilters(UserConnection, this, entitySchema, entitySchemaQuery,
					DataSourceFilters);
				bool isEmptyFilter = entitySchemaQuery.Filters.Count == 0;
				if (!isEmptyFilter && entitySchemaQuery.Filters.Count == 1) {
					var filterGroup = entitySchemaQuery.Filters[0] as EntitySchemaQueryFilterCollection;
					if (filterGroup != null && filterGroup.Count == 0) {
						isEmptyFilter = true;
					}
				}
				if (isEmptyFilter) {
					throw new NullOrEmptyException(new LocalizableString("Terrasoft.Core",
						"ProcessSchemaChangeDataUserTask.Exception.ChangeDataWithEmptyFilter"));
				}
			}
			EntityCollection entityCollection = entitySchemaQuery.GetEntityCollection(UserConnection);
			UpdateEntityCollection(entityCollection, entitySchema);
			return true;
		}

		#endregion

		#region Methods: Public

		public virtual void UpdateFiltersRightExprMetaDataByParameterValue(Process process, DataSourceFilterCollection filters) {
			foreach (var filter in filters) {
				if (filter is DataSourceFilterCollection) {
					UpdateFiltersRightExprMetaDataByParameterValue(process, (DataSourceFilterCollection)filter);
					continue;
				}	
				var dataSourcefilter = (DataSourceFilter)filter;
				if (dataSourcefilter.RightExpression == null) {
					continue;
				}
				if (dataSourcefilter.RightExpression.Type == DataSourceFilterExpressionType.Custom) {
					dataSourcefilter.RightExpression.Type = DataSourceFilterExpressionType.Parameter;
					if (dataSourcefilter.RightExpression.Parameters.Count == 2) {
						var parameters = dataSourcefilter.RightExpression.Parameters;
						var metaPath = parameters[1].Value;
						parameters[1].Value = process.GetParameterValueByMetaPath((string)metaPath);
						parameters.RemoveAt(0);
					}
					if (dataSourcefilter.SubFilters != null && dataSourcefilter.SubFilters.Count > 0) {
						UpdateFiltersRightExprMetaDataByParameterValue(process, dataSourcefilter.SubFilters);
					}
				}
			}
		}

		public virtual void UpdateEntityCollection(EntityCollection entityCollection, EntitySchema entitySchema) {
			string GetDebugInfo(Entity source) {
				var info = new System.Text.StringBuilder();
				try {
					info.Append(source.SchemaName);
					info.Append($" ({source.Schema.PrimaryColumn.Name}: [{source.PrimaryColumnValue}])");
				} catch (Exception) {
				}
				return info.ToString();
			}
			foreach (Entity entity in entityCollection) {
				try {
					foreach(KeyValuePair<string, object> columnValue in RecordColumnValues.Values) {
						EntitySchemaColumn column = entitySchema.GetSchemaColumnByMetaPath(columnValue.Key);
						object value = columnValue.Value;
						if (ProcessUserTaskUtilities.GetIsEmptyLookupOrDateTimeValue(value, column.DataValueType)) {
							value = null;
						}
						entity.SetColumnValue(column, value);
					}
					entity.UseAdminRights = false;
					entity.Save(false);
				} catch (Exception e) {
					string debugInfo = GetDebugInfo(entity);
					Log.Error("An error occurred during process element {this} when updating an entity {debugInfo}", e);
				}
			}
		}

		public override void WritePropertiesData(DataWriter writer) {
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer);
			if (Status == Core.Process.ProcessStatus.Inactive) {
				writer.WriteFinishObject();
				return;
			}
			if (!HasMapping("EntitySchemaUId")) {
				writer.WriteValue("EntitySchemaUId", EntitySchemaUId, Guid.Empty);
			}
			if (!HasMapping("IsMatchConditions")) {
				writer.WriteValue("IsMatchConditions", IsMatchConditions, false);
			}
			if (!HasMapping("DataSourceFilters")) {
				writer.WriteValue("DataSourceFilters", DataSourceFilters, null);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "EntitySchemaUId":
					EntitySchemaUId = reader.GetGuidValue();
				break;
				case "IsMatchConditions":
					IsMatchConditions = reader.GetBoolValue();
				break;
				case "DataSourceFilters":
					DataSourceFilters = reader.GetStringValue();
				break;
				case "RecordColumnValues":
					if (UseFlowEngineMode) {
						RecordColumnValues = reader.GetValue<EntityColumnMappingValues>();
					}
				break;
			}
		}

		#endregion

	}

	#endregion

}

