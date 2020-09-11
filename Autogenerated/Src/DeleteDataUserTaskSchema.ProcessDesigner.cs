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

	#region Class: DeleteDataUserTaskSchema

	/// <exclude/>
	public class DeleteDataUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public DeleteDataUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public DeleteDataUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("40f4a8f2-edca-432d-a5ea-03e8577b4691");
			RealUId = new Guid("40f4a8f2-edca-432d-a5ea-03e8577b4691");
			Name = "DeleteDataUserTask";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = new Guid("d7864000-6b83-4bb3-b16a-46192af5f15b");
			ParametersEditPageSchemaV2UId = new Guid("ce14ea36-c284-46c4-9489-42ae21e2ac85");
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,83,203,110,219,48,16,60,91,95,193,232,16,200,128,65,164,103,195,69,93,191,96,160,77,155,56,110,15,69,15,180,188,182,136,80,164,74,174,226,170,129,255,189,75,74,110,36,87,215,157,157,217,199,236,126,136,23,26,37,86,155,52,131,92,172,247,124,150,65,250,60,181,199,50,7,141,139,188,192,42,137,175,114,226,120,56,142,218,161,207,66,139,35,88,6,61,177,9,99,91,7,118,102,180,134,20,165,209,188,135,217,149,235,232,144,64,143,44,95,1,174,181,67,161,83,248,88,109,215,251,164,219,34,53,248,34,168,33,247,139,248,26,78,172,13,63,148,96,171,164,71,117,212,41,197,239,69,14,67,246,26,13,104,128,233,62,151,250,81,30,51,116,164,120,16,202,65,116,30,71,84,128,79,247,251,169,82,53,103,102,84,153,107,151,12,107,104,125,212,198,194,92,186,66,137,234,155,80,37,120,246,74,153,157,80,211,162,216,0,162,212,71,199,151,32,176,180,208,147,190,214,115,129,194,111,240,73,184,103,55,142,190,90,147,130,115,151,200,22,165,146,40,193,241,77,1,169,60,84,139,205,195,82,42,4,235,146,238,222,71,12,51,233,186,35,142,252,134,70,204,151,216,152,210,166,208,80,169,253,157,49,138,73,23,46,160,142,122,39,104,166,38,133,207,76,169,145,77,38,236,110,28,201,3,75,110,186,201,183,183,253,217,239,194,70,189,57,135,0,173,172,41,139,174,244,143,187,159,76,184,255,45,171,97,90,177,170,39,26,71,3,95,184,173,115,67,110,151,74,249,234,173,112,171,215,80,125,112,61,23,218,18,72,237,28,157,195,40,29,56,48,48,179,230,20,14,233,158,228,191,216,128,47,126,167,80,248,70,18,15,124,50,169,80,242,143,216,41,216,160,37,91,233,111,158,192,90,225,204,1,169,3,11,113,60,162,218,113,220,88,88,79,54,7,5,8,109,147,249,63,93,254,6,126,151,152,181,154,162,23,36,143,206,205,219,188,173,164,118,87,134,51,243,27,165,55,185,78,185,58,11,146,57,101,82,65,114,97,54,203,122,223,236,170,166,55,87,115,121,70,159,182,148,214,33,15,87,74,171,171,113,222,255,41,23,220,211,30,33,55,47,16,200,254,75,46,196,122,210,36,12,101,129,158,65,215,166,196,127,1,101,76,169,178,161,4,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateEntitySchemaIdParameter());
			Parameters.Add(CreateDataSourceFiltersParameter());
			Parameters.Add(CreateIsMatchConditionsParameter());
		}

		protected virtual ProcessSchemaParameter CreateEntitySchemaIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("d4b2bc79-929e-449b-9fd9-c1b05a86a743"),
				Name = "EntitySchemaId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateDataSourceFiltersParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("bf4c5111-ad4d-488b-99d6-c2a7f95495c4"),
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

		protected virtual ProcessSchemaParameter CreateIsMatchConditionsParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("01c46f30-bbdc-4c7a-888c-4a0adac0b305"),
				Name = "IsMatchConditions",
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
			Methods.Add(CreateGetResultParameterAllValuesMethod());
			Methods.Add(CreateCompleteExecutingMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("1aee6e33-7c50-4a98-a04b-933a02ed78eb"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("415f292c-4eb5-4c80-8e80-df146f3cd0dc")
			});
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("db049e54-3b9b-4404-8982-774fcc2d0930"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("40f4a8f2-edca-432d-a5ea-03e8577b4691"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("db277c9b-6736-42fc-b1a8-21f782835e0f"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("40f4a8f2-edca-432d-a5ea-03e8577b4691"),
				ModifiedInSchemaUId = new Guid("40f4a8f2-edca-432d-a5ea-03e8577b4691"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("64fe04c6-c2d8-47e4-bb30-a12fae1bc186"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("40f4a8f2-edca-432d-a5ea-03e8577b4691"),
				ModifiedInSchemaUId = new Guid("40f4a8f2-edca-432d-a5ea-03e8577b4691"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,113,47,205,76,209,81,40,46,41,202,204,75,183,211,208,180,6,0,179,24,102,192,38,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("cb7fb57e-a31a-4fb1-8879-566ab92033a0"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("40f4a8f2-edca-432d-a5ea-03e8577b4691"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("58292482-1961-43c0-967c-8324509e79aa"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("40f4a8f2-edca-432d-a5ea-03e8577b4691"),
				ModifiedInSchemaUId = new Guid("40f4a8f2-edca-432d-a5ea-03e8577b4691"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,74,44,78,213,115,206,207,45,200,73,45,73,117,173,72,77,46,45,201,204,75,215,40,72,44,74,204,5,138,20,21,107,90,3,0,145,9,166,203,42,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new DeleteDataUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("40f4a8f2-edca-432d-a5ea-03e8577b4691"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new DeleteDataUserTask(userConnection) {
				SchemaUId = new Guid("40f4a8f2-edca-432d-a5ea-03e8577b4691")
			};
		}

		#endregion

	}

	#endregion

	#region Class: DeleteDataUserTask

	[DesignModeGroup(Name = "General", Position = 1, UseSolutionStorage = true, ResourceManager = "40f4a8f2edca432da5ea03e8577b4691", CaptionResourceItem = "Parameters.EntitySchemaId.Group", DescriptionResourceItem = "Parameters.EntitySchemaId.Group")]
	[DesignModeProperty(Name = "EntitySchemaId", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "40f4a8f2edca432da5ea03e8577b4691", CaptionResourceItem = "Parameters.EntitySchemaId.Caption", DescriptionResourceItem = "Parameters.EntitySchemaId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "DataSourceFilters", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "40f4a8f2edca432da5ea03e8577b4691", CaptionResourceItem = "Parameters.DataSourceFilters.Caption", DescriptionResourceItem = "Parameters.DataSourceFilters.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "IsMatchConditions", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "40f4a8f2edca432da5ea03e8577b4691", CaptionResourceItem = "Parameters.IsMatchConditions.Caption", DescriptionResourceItem = "Parameters.IsMatchConditions.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class DeleteDataUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public DeleteDataUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("40f4a8f2-edca-432d-a5ea-03e8577b4691");
		}

		#endregion

		#region Properties: Public

		public virtual Guid EntitySchemaId {
			get;
			set;
		}

		public virtual string DataSourceFilters {
			get;
			set;
		}

		public virtual bool IsMatchConditions {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			EntitySchemaId.CheckArgumentEmpty("EntitySchemaId");
			EntitySchemaManager entitySchemaManager =  UserConnection.EntitySchemaManager;
			EntitySchema entitySchema = entitySchemaManager.GetInstanceByUId(EntitySchemaId);
			var esq = new EntitySchemaQuery(entitySchemaManager, entitySchema.Name) {
				UseAdminRights = false
			};
			esq.AddAllSchemaColumns();
			esq.IgnoreDisplayValues = GlobalAppSettings.FeatureIgnoreDisplayValuesInDataUserTasks;
			ProcessUserTaskUtilities.SpecifyESQFilters(UserConnection, this, entitySchema, esq, DataSourceFilters);
			bool isEmptyFilter = esq.Filters.Count == 0;
			if (!isEmptyFilter && esq.Filters.Count == 1) {
				var filterGroup = esq.Filters[0] as EntitySchemaQueryFilterCollection;
				if (filterGroup != null && filterGroup.Count == 0) {
					isEmptyFilter = true;
				}
			}
			if (isEmptyFilter) {
				throw new NullOrEmptyException(new LocalizableString("Terrasoft.Core",
					"ProcessSchemaDeleteDataUserTask.Exception.DeleteDataWithEmptyFilter"));
			}
			EntityCollection entities = esq.GetEntityCollection(UserConnection);
			while(entities.Count > 0) {
				Entity entity = entities.First.Value;
				entity.UseAdminRights = false;
				entities.RemoveFirst();
				entity.Delete();
			}
			return true;
		}

		#endregion

		#region Methods: Public

		public override bool CompleteExecuting(params object[] parameters) {
			return base.CompleteExecuting(parameters);
		}

		public override void WritePropertiesData(DataWriter writer) {
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer);
			if (Status == Core.Process.ProcessStatus.Inactive) {
				writer.WriteFinishObject();
				return;
			}
			if (!HasMapping("EntitySchemaId")) {
				writer.WriteValue("EntitySchemaId", EntitySchemaId, Guid.Empty);
			}
			if (!HasMapping("DataSourceFilters")) {
				writer.WriteValue("DataSourceFilters", DataSourceFilters, null);
			}
			if (!HasMapping("IsMatchConditions")) {
				writer.WriteValue("IsMatchConditions", IsMatchConditions, false);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "EntitySchemaId":
					EntitySchemaId = reader.GetGuidValue();
				break;
				case "DataSourceFilters":
					DataSourceFilters = reader.GetStringValue();
				break;
				case "IsMatchConditions":
					IsMatchConditions = reader.GetBoolValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

