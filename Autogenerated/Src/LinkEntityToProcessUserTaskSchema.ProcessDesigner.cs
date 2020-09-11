namespace Terrasoft.Core.Process.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.UI.WebControls.Controls;

	#region Class: LinkEntityToProcessUserTaskSchema

	/// <exclude/>
	public class LinkEntityToProcessUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public LinkEntityToProcessUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public LinkEntityToProcessUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a");
			RealUId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a");
			Name = "LinkEntityToProcessUserTask";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.General;
			ParametersEditPageSchemaUId = new Guid("ea509d3f-ee32-41d3-8a63-7f9a36281f78");
			ParametersEditPageSchemaV2UId = new Guid("190c5526-affd-4dc8-b7f2-5b7e837e0215");
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,146,75,75,195,64,16,128,207,201,175,24,114,218,66,9,122,14,5,105,27,37,32,248,104,173,7,241,176,38,99,187,52,217,141,179,89,99,208,254,119,55,217,152,214,170,8,123,152,157,199,55,207,179,64,60,3,139,101,37,170,102,145,110,176,224,73,6,147,9,92,24,145,133,113,81,86,13,124,124,128,179,31,91,70,240,238,123,132,149,33,9,207,60,215,24,249,59,191,53,131,110,244,23,44,242,95,57,1,126,75,112,205,137,23,88,33,193,4,36,214,112,99,144,154,65,121,84,205,200,17,6,228,74,96,189,192,28,211,170,143,118,31,118,167,145,102,74,74,43,11,37,71,161,239,121,75,85,178,211,78,154,169,220,20,146,5,193,93,146,5,65,171,58,39,85,216,255,170,94,12,181,202,123,69,91,93,242,20,157,203,253,6,9,173,143,11,73,116,252,98,120,206,254,104,165,13,184,162,125,134,255,220,129,235,190,242,200,55,90,200,53,176,249,52,126,195,212,84,138,32,123,26,196,9,124,239,44,140,165,54,132,243,233,94,197,70,221,42,122,76,59,45,66,158,117,227,253,101,108,161,67,227,109,231,195,246,169,28,197,171,55,34,71,96,14,17,182,94,61,223,243,14,246,250,179,174,249,116,217,148,104,21,175,72,182,67,251,95,241,220,224,82,181,39,209,227,30,78,30,237,62,45,233,40,54,185,38,149,162,214,177,92,11,137,225,165,144,219,94,179,84,238,28,216,85,45,145,198,135,167,53,30,238,178,99,238,124,251,118,126,127,144,21,25,140,130,79,60,253,91,29,223,2,0,0 };
			SerializeToDB = true;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateEntityIdParameter());
			Parameters.Add(CreateEntitySchemaIdParameter());
		}

		protected virtual ProcessSchemaParameter CreateEntityIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("b4e61a1e-7647-4984-a3b0-64a29ed30681"),
				Name = "EntityId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = false,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateEntitySchemaIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("06bcedca-a817-4027-8844-845966e2499b"),
				Name = "EntitySchemaId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = false,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateCompleteExecutingMethod());
			Methods.Add(CreateGetResultParameterAllValuesMethod());
			Methods.Add(CreateCancelExecutingMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("27d23eba-cfc7-4478-a90f-4c26d9971348"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("10525550-beee-4dbe-ac54-c106453b0210"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("8efeaf31-d30b-45ea-82b7-0f5ad9cf5fd4"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6aea4ff1-ce33-4bc3-b6fd-08f6f908418e"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool",
				IsOverride = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f7302ba6-fb96-47dd-89f2-df5cc538f8d6"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a"),
				ModifiedInSchemaUId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,74,44,78,213,115,206,207,45,200,73,45,73,117,173,72,77,46,45,201,204,75,215,40,72,44,74,204,5,138,20,21,107,90,3,0,145,9,166,203,42,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8826646e-a1dd-4b3f-9100-8e485ff650a5"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("cf214a8d-f988-4dfa-9d8b-097f7369e6ce"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a"),
				ModifiedInSchemaUId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("568be5ef-20d5-4547-8778-796509c8e9f6"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,113,47,205,76,209,81,40,46,41,202,204,75,183,211,208,180,6,0,179,24,102,192,38,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCancelExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("aa2b56b2-0d4c-41f0-b4f7-b3156a807ba5"),
				Name = "CancelExecuting",
				CreatedInSchemaUId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void",
				IsOverride = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ae839086-7328-4cfc-9ecc-8ac17df4c3b5"),
				Name = "parameters",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,115,78,204,75,78,205,113,173,72,77,46,45,201,204,75,215,40,72,44,74,204,77,45,73,45,42,214,180,6,0,4,172,171,3,33,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LinkEntityToProcessUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fcace79b-6103-4992-8a1f-8e443114321a"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new LinkEntityToProcessUserTask(userConnection) {
				SchemaUId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a")
			};
		}

		#endregion

	}

	#endregion

	#region Class: LinkEntityToProcessUserTask

	[DesignModeGroup(Name = "General", Position = 1, UseSolutionStorage = true, ResourceManager = "fcace79b610349928a1f8e443114321a", CaptionResourceItem = "Parameters.EntityId.Group", DescriptionResourceItem = "Parameters.EntityId.Group")]
	[DesignModeProperty(Name = "EntityId", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fcace79b610349928a1f8e443114321a", CaptionResourceItem = "Parameters.EntityId.Caption", DescriptionResourceItem = "Parameters.EntityId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "EntitySchemaId", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fcace79b610349928a1f8e443114321a", CaptionResourceItem = "Parameters.EntitySchemaId.Caption", DescriptionResourceItem = "Parameters.EntitySchemaId.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class LinkEntityToProcessUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public LinkEntityToProcessUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a");
		}

		#endregion

		#region Properties: Public

		public virtual Guid EntityId {
			get;
			set;
		}

		public virtual Guid EntitySchemaId {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			if (EntitySchemaId == Guid.Empty || EntityId == Guid.Empty) {
				return false;
			}
			Guid sysSchemaId;
			var entitySchemaIdParameter = new QueryParameter(EntitySchemaId);
			var sysSchemaViewSelect = new Select(UserConnection).
					Top(1).
					Column("UId").
				From("VwSysSchemaInWorkspace").
				Where("Id").IsEqual(entitySchemaIdParameter).
				Or("UId").IsEqual(entitySchemaIdParameter) as Select;
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
				using (var reader = sysSchemaViewSelect.ExecuteReader(dbExecutor)) {
					while (reader.Read()) {
						sysSchemaId = UserConnection.DBTypeConverter.DBValueToGuid(reader[0]);
						UserConnection.IProcessEngine.LinkProcessToEntity(Owner, sysSchemaId, EntityId);
					}
				}
			}
			return true;
		}

		#endregion

		#region Methods: Public

		public override bool CompleteExecuting(params object[] parameters) {
			return base.CompleteExecuting(parameters);
		}

		public override void CancelExecuting(params object[] parameters) {
			base.CancelExecuting(parameters);
		}

		public override void WritePropertiesData(DataWriter writer) {
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer);
			if (Status == Core.Process.ProcessStatus.Inactive) {
				writer.WriteFinishObject();
				return;
			}
			if (UseFlowEngineMode) {
				if (!HasMapping("EntityId")) {
					writer.WriteValue("EntityId", EntityId, Guid.Empty);
				}
			}
			if (UseFlowEngineMode) {
				if (!HasMapping("EntitySchemaId")) {
					writer.WriteValue("EntitySchemaId", EntitySchemaId, Guid.Empty);
				}
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "EntityId":
					if (!UseFlowEngineMode) {
						break;
					}
					EntityId = reader.GetGuidValue();
				break;
				case "EntitySchemaId":
					if (!UseFlowEngineMode) {
						break;
					}
					EntitySchemaId = reader.GetGuidValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

