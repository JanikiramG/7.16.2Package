namespace Terrasoft.Core.Process.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.UI.WebControls.Controls;

	#region Class: SynchronizeParentEntityDataSchema

	/// <exclude/>
	public class SynchronizeParentEntityDataSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public SynchronizeParentEntityDataSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public SynchronizeParentEntityDataSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3e6374da-0124-4817-bb7c-34b2b4ba4816");
			RealUId = new Guid("3e6374da-0124-4817-bb7c-34b2b4ba4816");
			Name = "SynchronizeParentEntityData";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,80,42,75,44,82,40,45,72,73,44,73,13,44,77,45,170,84,176,85,112,46,74,5,242,66,17,98,26,201,249,121,37,169,21,37,154,214,92,153,105,10,26,200,170,21,109,21,242,74,115,114,52,21,170,185,56,145,196,245,92,43,82,147,75,75,82,53,128,90,106,185,138,82,75,74,139,242,20,74,138,74,83,173,149,0,26,54,241,205,114,0,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateParentEntityColumnUIdParameter());
			Parameters.Add(CreateConditionMappingColumnsParameter());
			Parameters.Add(CreateMappingColumnsParameter());
			Parameters.Add(CreateDefaultValuesParameter());
			Parameters.Add(CreateDeleteChildParameter());
		}

		protected virtual ProcessSchemaParameter CreateParentEntityColumnUIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("14ea59bf-afe0-4d9d-ac41-8c7276179346"),
				Name = "ParentEntityColumnUId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateConditionMappingColumnsParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("437ef444-9a16-4d1b-8ea8-f84f905c6480"),
				Name = "ConditionMappingColumns",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateMappingColumnsParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("7d775cd5-9214-4da4-9083-febfefa977e4"),
				Name = "MappingColumns",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateDefaultValuesParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("e8a937ea-d43d-4afc-98ff-b519b9ab11b8"),
				Name = "DefaultValues",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateDeleteChildParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("3a220fa1-769d-440b-9e87-482b834bc245"),
				Name = "DeleteChild",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
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
			Methods.Add(CreateCreateParametersMethod());
			Methods.Add(CreateCreateUpdateQueryMethod());
			Methods.Add(CreateCreateEmptyParametersMethod());
		}

		protected virtual SchemaMethod CreateCreateParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0fb951ea-ffd9-4fd9-8157-873149a1c631"),
				Name = "CreateParameters",
				CreatedInSchemaUId = new Guid("3e6374da-0124-4817-bb7c-34b2b4ba4816"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "object"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a8cee6e4-2533-43f2-9880-b15390433e53"),
				Name = "context",
				CreatedInSchemaUId = new Guid("3e6374da-0124-4817-bb7c-34b2b4ba4816"),
				ModifiedInSchemaUId = new Guid("3e6374da-0124-4817-bb7c-34b2b4ba4816"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,85,221,110,211,48,20,190,110,158,194,236,42,145,42,191,64,216,38,104,171,9,33,80,197,24,55,85,47,220,228,132,26,18,39,216,14,16,161,190,59,199,118,150,56,110,3,27,72,85,21,159,159,239,59,127,62,230,5,137,215,80,130,134,213,145,151,121,242,43,90,72,208,173,20,100,37,129,105,216,84,141,238,182,76,178,10,77,164,138,179,90,104,248,169,147,52,58,69,223,153,36,120,206,185,230,181,120,199,154,134,139,207,171,186,45,43,161,200,53,89,157,105,202,214,104,152,34,247,157,210,80,81,148,148,144,25,19,69,239,64,128,228,25,93,115,43,96,178,123,25,221,181,60,95,62,207,184,62,124,65,163,155,232,38,181,209,85,83,234,107,242,159,177,152,255,30,186,25,106,130,176,2,126,252,83,156,113,226,192,114,40,88,91,234,79,172,108,193,224,173,39,103,140,210,67,152,0,144,219,91,75,62,167,127,36,0,161,185,238,16,185,239,31,221,202,58,3,101,66,212,248,217,128,212,157,101,139,175,54,214,244,42,49,180,31,65,74,166,234,66,99,90,18,168,85,113,80,238,163,243,161,239,179,35,84,12,9,220,145,186,243,80,42,148,58,31,87,249,193,206,153,209,190,31,38,154,215,221,195,155,60,222,158,185,160,52,57,135,27,104,207,57,232,7,40,0,133,25,60,198,82,96,14,44,59,146,120,126,112,223,66,71,184,152,155,106,138,106,149,16,188,35,19,4,229,234,122,241,30,236,102,121,246,207,152,190,197,98,210,213,52,90,28,234,186,36,152,208,67,147,227,45,197,0,180,108,1,229,151,115,12,211,242,50,153,166,242,196,246,248,192,216,149,139,32,118,156,198,129,64,95,79,30,7,198,212,211,189,199,123,101,65,253,244,92,230,116,243,173,101,165,10,189,29,213,210,203,111,231,71,184,183,104,28,55,221,139,1,210,229,190,56,96,181,190,26,237,41,50,63,99,19,152,184,204,250,9,196,64,130,157,242,135,254,166,19,239,39,212,116,28,115,231,56,172,152,191,149,114,182,130,227,146,162,175,114,175,109,97,172,203,128,203,56,159,112,195,79,166,201,95,82,253,64,77,246,214,56,83,166,140,30,53,190,4,154,113,161,80,31,7,32,137,43,178,217,74,92,216,1,198,46,4,81,7,46,203,41,235,46,80,239,237,211,212,191,97,35,82,250,27,95,118,71,158,233,6,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateUpdateQueryMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2a8b2c78-7815-42ac-bf24-f70a7edd0716"),
				Name = "CreateUpdateQuery",
				CreatedInSchemaUId = new Guid("3e6374da-0124-4817-bb7c-34b2b4ba4816"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Terrasoft.Core.DB.Update"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4ce86fa7-6cf5-4259-9aeb-e9d72ae322d7"),
				Name = "context",
				CreatedInSchemaUId = new Guid("3e6374da-0124-4817-bb7c-34b2b4ba4816"),
				ModifiedInSchemaUId = new Guid("3e6374da-0124-4817-bb7c-34b2b4ba4816"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,93,79,194,48,20,125,150,132,255,208,240,212,37,75,227,251,196,7,129,16,98,98,22,1,125,48,62,212,113,9,53,91,55,219,14,93,196,255,238,93,59,70,97,139,241,105,221,253,56,231,220,115,219,61,87,164,224,138,103,96,64,105,50,38,19,5,220,64,220,134,104,146,75,3,95,38,32,92,147,101,165,13,100,108,146,167,41,36,70,228,82,179,57,72,80,34,97,83,97,3,92,85,55,195,193,188,20,155,144,228,111,239,88,117,27,13,7,98,75,168,207,50,38,178,76,83,114,56,120,220,136,90,74,83,231,174,3,242,61,28,92,41,48,165,146,182,18,33,126,134,131,61,106,5,105,132,169,80,103,35,139,197,42,79,64,215,58,12,30,11,80,166,122,226,105,9,116,52,179,165,35,43,124,5,74,113,157,111,13,178,40,96,54,37,64,187,67,21,249,216,203,100,7,25,71,6,247,203,220,127,83,130,114,49,236,186,208,133,50,147,109,161,171,99,46,106,245,220,85,235,197,134,198,157,22,140,6,61,120,45,113,151,132,61,194,22,48,152,192,153,154,178,216,224,174,176,67,194,231,229,136,211,59,182,182,233,227,2,217,90,131,154,228,82,186,205,133,61,220,236,1,119,81,75,219,34,2,79,118,132,238,253,235,113,15,21,17,210,95,25,70,180,91,214,105,152,214,150,30,252,142,57,62,118,77,220,193,169,21,181,88,141,25,238,99,183,92,167,189,54,135,101,51,174,169,17,250,226,243,188,214,13,206,58,182,4,67,47,233,194,30,43,27,230,246,89,208,115,178,240,92,224,148,27,110,227,171,170,128,32,56,221,222,66,137,12,95,200,95,22,197,126,73,212,211,118,116,196,143,245,88,210,12,248,188,195,123,67,59,0,1,91,232,217,71,201,83,138,94,252,99,220,230,45,224,222,60,38,218,115,81,47,132,4,33,226,159,75,237,154,211,60,116,167,56,250,5,242,188,160,175,146,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateEmptyParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0c0e09fc-7d0a-4fe0-8818-2be4a6b47d20"),
				Name = "CreateEmptyParameters",
				CreatedInSchemaUId = new Guid("3e6374da-0124-4817-bb7c-34b2b4ba4816"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "object"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a0c20132-3d47-479e-a43f-fb542c782b16"),
				Name = "context",
				CreatedInSchemaUId = new Guid("3e6374da-0124-4817-bb7c-34b2b4ba4816"),
				ModifiedInSchemaUId = new Guid("3e6374da-0124-4817-bb7c-34b2b4ba4816"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,84,201,78,195,48,16,61,39,95,97,56,37,82,229,31,40,32,177,9,33,4,66,108,151,138,131,155,76,192,224,56,193,75,33,66,253,119,198,113,105,29,183,149,88,164,170,74,102,198,111,153,25,103,198,20,41,26,89,114,195,27,121,201,218,150,203,167,227,198,138,90,106,178,79,142,215,50,194,186,12,211,228,182,211,6,106,138,17,1,133,43,209,244,12,36,40,94,208,19,222,7,152,234,246,210,51,203,203,209,239,138,155,233,11,22,29,164,7,227,116,134,234,234,33,245,62,249,167,22,247,191,128,110,153,98,53,24,80,14,86,194,251,159,116,102,185,7,43,161,98,86,152,7,38,44,232,255,195,129,52,220,116,168,11,167,99,224,195,208,107,213,20,160,29,130,193,199,22,148,233,122,174,108,247,180,47,221,205,93,43,238,64,41,166,155,202,32,171,2,218,167,56,104,255,208,133,208,183,197,51,212,12,9,252,43,245,239,203,198,96,212,159,241,125,94,214,249,50,186,232,190,83,115,212,221,159,151,217,245,218,17,140,230,235,112,75,218,117,14,122,3,21,96,176,128,111,45,21,122,96,197,51,201,102,91,215,244,2,58,194,229,182,29,166,152,214,57,249,76,147,1,130,246,125,221,184,245,147,173,60,143,191,216,181,36,25,76,117,156,38,211,166,17,4,13,221,183,37,51,128,2,140,178,128,241,205,30,99,91,129,147,161,149,31,142,39,4,198,169,108,4,233,215,105,181,16,120,54,136,103,81,49,13,114,87,120,139,122,208,208,158,119,78,79,223,44,19,58,62,237,169,70,129,191,73,168,240,177,71,227,21,201,118,150,144,222,123,50,197,110,189,186,236,60,117,63,87,19,149,172,110,53,61,44,3,231,241,56,71,68,90,33,28,211,60,157,15,87,45,188,203,139,73,12,174,247,106,24,142,63,32,196,15,166,97,92,106,204,103,17,72,238,213,185,235,204,101,63,121,148,31,105,141,142,140,134,172,147,40,237,186,52,79,21,24,171,100,240,45,27,127,1,238,115,80,123,212,5,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SynchronizeParentEntityDataSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3e6374da-0124-4817-bb7c-34b2b4ba4816"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new SynchronizeParentEntityData(userConnection) {
				SchemaUId = new Guid("3e6374da-0124-4817-bb7c-34b2b4ba4816")
			};
		}

		#endregion

	}

	#endregion

	#region Class: SynchronizeParentEntityData

	[DesignModeProperty(Name = "ParentEntityColumnUId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "3e6374da01244817bb7c34b2b4ba4816", CaptionResourceItem = "Parameters.ParentEntityColumnUId.Caption", DescriptionResourceItem = "Parameters.ParentEntityColumnUId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ConditionMappingColumns", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "3e6374da01244817bb7c34b2b4ba4816", CaptionResourceItem = "Parameters.ConditionMappingColumns.Caption", DescriptionResourceItem = "Parameters.ConditionMappingColumns.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "MappingColumns", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "3e6374da01244817bb7c34b2b4ba4816", CaptionResourceItem = "Parameters.MappingColumns.Caption", DescriptionResourceItem = "Parameters.MappingColumns.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "DefaultValues", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "3e6374da01244817bb7c34b2b4ba4816", CaptionResourceItem = "Parameters.DefaultValues.Caption", DescriptionResourceItem = "Parameters.DefaultValues.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "DeleteChild", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "3e6374da01244817bb7c34b2b4ba4816", CaptionResourceItem = "Parameters.DeleteChild.Caption", DescriptionResourceItem = "Parameters.DeleteChild.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class SynchronizeParentEntityData : ProcessUserTask
	{

		#region Constructors: Public

		public SynchronizeParentEntityData(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("3e6374da-0124-4817-bb7c-34b2b4ba4816");
		}

		#endregion

		#region Properties: Public

		public virtual Guid ParentEntityColumnUId {
			get;
			set;
		}

		public virtual Object ConditionMappingColumns {
			get;
			set;
		}

		public virtual Object MappingColumns {
			get;
			set;
		}

		public virtual Object DefaultValues {
			get;
			set;
		}

		public virtual bool DeleteChild {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			var updateQuery = CreateUpdateQuery(context);
			if (updateQuery != null) {
				updateQuery.Execute();
			}
			return true;
		}

		#endregion

		#region Methods: Public

		public virtual object CreateParameters(ProcessExecutingContext context) {
			if (DeleteChild){
				return CreateEmptyParameters(context);
			}
			var conditionMappingCoulmns = ConditionMappingColumns as System.Collections.Generic.Dictionary<
			Guid, System.Collections.Generic.Dictionary<
			Guid, object>
			>;
			var mappingColumns = MappingColumns as System.Collections.Generic.Dictionary<
			Guid, Guid>;
			var parameters = new System.Collections.Generic.Dictionary<
			Guid, object>();
			var defaultValues = DefaultValues as Dictionary<Guid, object> ?? new Dictionary<Guid, object>();
			var entity = context.Process.GetPropertyValue("Entity") as Terrasoft.Core.Entities.Entity;
			var entitySchema = entity.Schema;
			var parentEntityColumn = entitySchema.Columns.GetByUId(ParentEntityColumnUId);
			var parentEntitySchema = parentEntityColumn.ReferenceSchema;
			foreach (var conditionMappingCoulmnKey in conditionMappingCoulmns.Keys) {
				var conditions = conditionMappingCoulmns [conditionMappingCoulmnKey] as System.Collections.Generic.Dictionary<
					Guid, object>;
				bool forUpdate = true;
				foreach (var conditionKey in conditions.Keys) {
					var conditionColumn = entitySchema.Columns.GetByUId(conditionKey);
					var conditionColumnValue = entity.GetColumnValue(conditionColumn.ColumnValueName);
					forUpdate = object.Equals(conditionColumnValue , conditions[conditionKey]);
					if (!forUpdate) {
						break;
					}
				}
				if (forUpdate) {
					var columnUId =  mappingColumns[conditionMappingCoulmnKey];
					var column = entitySchema.Columns.GetByUId(columnUId);
					var parameterValue = entity.GetColumnValue(column.ColumnValueName);
					parameters.Add(conditionMappingCoulmnKey, parameterValue);
				}
			}
			foreach (var defaultValueKey in defaultValues.Keys) {
				if (parameters.ContainsKey(defaultValueKey)) {
					continue;
				}
				parameters.Add(defaultValueKey, defaultValues[defaultValueKey]);
			}
			return parameters;
		}

		public virtual Terrasoft.Core.DB.Update CreateUpdateQuery(ProcessExecutingContext context) {
			var parameters = CreateParameters(context) as System.Collections.Generic.Dictionary<
			Guid, object>;
			if (parameters == null || parameters.Count == 0) {
				return null;
			}
			var entity = context.Process.GetPropertyValue("Entity") as Terrasoft.Core.Entities.Entity;
			var entitySchema = entity.Schema;
			var parentEntityColumn = entitySchema.Columns.GetByUId(ParentEntityColumnUId);
			var parentEntitySchema = parentEntityColumn.ReferenceSchema;
			var update = new Terrasoft.Core.DB.Update(context.UserConnection, parentEntitySchema.Name);
			foreach (var parameterKey in parameters.Keys) {
				var parentColumn = parentEntitySchema.Columns.GetByUId(parameterKey);
				var parentColumnName = parentColumn.ColumnValueName;
				var parameterValue = parameters[parameterKey];
				update.Set(parentColumnName, Terrasoft.Core.DB.Column.Parameter(parameterValue, parentColumn.DataValueType));
			}
			var primaryColumn = parentEntitySchema.PrimaryColumn;
			var primaryColumnName = primaryColumn.ColumnValueName;
			update.Where(primaryColumnName).IsEqual(
				Terrasoft.Core.DB.Column.Parameter(entity.GetColumnValue(parentEntityColumn.ColumnValueName),
				primaryColumn.DataValueType));
			return update;
		}

		public virtual object CreateEmptyParameters(ProcessExecutingContext context) {
			var conditionMappingCoulmns = ConditionMappingColumns as System.Collections.Generic.Dictionary<
			Guid, System.Collections.Generic.Dictionary<
			Guid, object>
			>;
			var mappingColumns = MappingColumns as System.Collections.Generic.Dictionary<
			Guid, Guid>;
			var parameters = new System.Collections.Generic.Dictionary<
			Guid, object>();
			var defaultValues= new System.Collections.Generic.Dictionary<
			Guid, object>();
			var entity = context.Process.GetPropertyValue("Entity") as Terrasoft.Core.Entities.Entity;
			var entitySchema = entity.Schema;
			var parentEntityColumn = entitySchema.Columns.GetByUId(ParentEntityColumnUId);
			var parentEntitySchema = parentEntityColumn.ReferenceSchema;
			foreach (var conditionMappingCoulmnKey in conditionMappingCoulmns.Keys) {
				var conditions = conditionMappingCoulmns [conditionMappingCoulmnKey] as System.Collections.Generic.Dictionary<
					Guid, object>;
				bool forUpdate = true;
				foreach (var conditionKey in conditions.Keys) {
					var conditionColumn = entitySchema.Columns.GetByUId(conditionKey);
					var conditionColumnValue = entity.GetColumnValue(conditionColumn.ColumnValueName);
					forUpdate = object.Equals(conditionColumnValue , conditions[conditionKey]);
					if (!forUpdate) {
						break;
					}
				}
				if (forUpdate) {
					parameters.Add(conditionMappingCoulmnKey, null);
				}
			}
			foreach (var defaultValueKey in defaultValues.Keys) {
				if (parameters.ContainsKey(defaultValueKey)) {
					continue;
				}
				parameters.Add(defaultValueKey, defaultValues[defaultValueKey]);
			}
			return parameters;
		}

		public override void WritePropertiesData(DataWriter writer) {
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer);
			if (Status == Core.Process.ProcessStatus.Inactive) {
				writer.WriteFinishObject();
				return;
			}
			if (!HasMapping("ParentEntityColumnUId")) {
				writer.WriteValue("ParentEntityColumnUId", ParentEntityColumnUId, Guid.Empty);
			}
			if (ConditionMappingColumns != null) {
				if (ConditionMappingColumns.GetType().IsSerializable || ConditionMappingColumns.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ConditionMappingColumns", ConditionMappingColumns, null);
				}
			}
			if (MappingColumns != null) {
				if (MappingColumns.GetType().IsSerializable || MappingColumns.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("MappingColumns", MappingColumns, null);
				}
			}
			if (DefaultValues != null) {
				if (DefaultValues.GetType().IsSerializable || DefaultValues.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("DefaultValues", DefaultValues, null);
				}
			}
			if (!HasMapping("DeleteChild")) {
				writer.WriteValue("DeleteChild", DeleteChild, false);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "ParentEntityColumnUId":
					ParentEntityColumnUId = reader.GetGuidValue();
				break;
				case "ConditionMappingColumns":
					ConditionMappingColumns = reader.GetSerializableObjectValue();
				break;
				case "MappingColumns":
					MappingColumns = reader.GetSerializableObjectValue();
				break;
				case "DefaultValues":
					DefaultValues = reader.GetSerializableObjectValue();
				break;
				case "DeleteChild":
					DeleteChild = reader.GetBoolValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

