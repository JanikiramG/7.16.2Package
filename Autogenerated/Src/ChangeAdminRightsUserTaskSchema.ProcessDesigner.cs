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

	#region Class: ChangeAdminRightsUserTaskSchema

	/// <exclude/>
	public class ChangeAdminRightsUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public ChangeAdminRightsUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public ChangeAdminRightsUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081");
			RealUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081");
			Name = "ChangeAdminRightsUserTask";
			CreatedInPackageId = new Guid("456be734-98b3-4bf5-b071-1b32916f1035");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			ParametersEditPageSchemaV2UId = new Guid("2f8c067c-82ba-4187-a4f2-4eecb4fc0b96");
			DcmParametersEditPageSchemaV2UId = new Guid("7de7da69-6148-4d70-af2c-1ea73d6b6664");
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,85,203,82,219,48,20,93,219,95,113,195,130,113,102,130,7,182,205,163,13,36,48,116,250,0,92,86,12,11,97,223,36,106,21,137,145,228,50,166,228,223,43,201,38,200,114,104,105,103,178,241,213,125,156,123,206,145,242,97,143,46,32,153,115,77,117,149,229,43,92,147,235,243,2,198,99,56,43,105,145,206,215,247,186,130,167,39,72,148,150,148,47,211,115,245,165,100,236,171,116,7,201,12,25,106,188,162,203,149,86,125,91,196,205,33,236,239,195,206,236,105,81,4,169,253,62,252,138,35,137,186,148,28,180,44,113,24,111,226,159,68,66,225,53,134,49,244,222,48,253,61,124,84,130,167,51,84,40,41,97,244,17,71,159,168,210,163,25,205,53,21,156,200,106,84,119,25,128,184,251,142,185,158,76,38,237,22,113,244,14,56,62,192,223,202,146,195,254,208,161,36,207,11,189,10,209,91,249,191,240,189,212,255,19,56,43,169,79,97,122,34,74,174,45,235,135,86,157,45,110,47,190,75,9,223,21,128,254,199,24,174,205,26,39,130,115,116,72,82,63,245,51,225,100,137,50,61,165,188,56,231,74,19,158,227,113,101,108,21,218,172,65,218,238,220,56,99,7,28,155,219,243,147,211,105,177,166,220,16,34,137,198,226,184,186,194,92,200,66,189,102,42,191,244,178,68,89,153,53,44,165,243,48,222,66,228,186,153,109,221,172,173,220,11,194,20,198,155,97,220,105,106,64,21,83,198,234,200,137,96,229,154,171,164,191,43,241,66,210,181,145,208,125,212,137,198,61,83,246,64,42,149,25,241,114,35,76,131,127,70,52,201,68,41,115,60,165,76,91,226,25,171,137,135,69,24,168,249,171,153,237,101,59,239,77,208,77,213,215,240,66,138,28,149,178,194,126,35,234,199,181,166,140,106,138,42,205,238,49,167,139,106,158,93,54,249,73,91,252,1,232,21,85,131,22,191,131,46,219,3,232,14,30,198,209,157,16,12,168,114,208,234,176,89,161,75,86,83,225,57,214,212,186,29,219,181,198,222,111,40,62,114,27,71,214,21,53,129,103,82,148,247,127,26,124,115,120,11,68,117,189,18,10,98,80,57,88,126,219,222,203,195,232,133,195,203,23,181,61,27,69,155,216,252,124,235,182,84,238,34,61,67,61,15,242,2,165,12,223,179,227,12,243,82,154,172,57,95,82,142,80,220,5,129,206,221,14,75,134,241,66,72,36,249,234,249,127,163,193,2,148,119,128,186,205,182,233,175,191,91,254,139,111,251,20,173,183,221,178,211,60,213,238,138,187,120,18,34,127,246,220,192,175,182,22,219,56,8,144,80,67,55,53,251,133,239,223,1,28,13,205,193,196,154,10,232,193,65,61,208,190,189,111,154,182,109,119,67,111,235,113,155,216,151,114,239,55,202,108,111,72,100,7,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = true;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateEntitySchemaUIdParameter());
			Parameters.Add(CreateDataSourceFiltersParameter());
			Parameters.Add(CreateDeleteRightsParameter());
			Parameters.Add(CreateAddRightsParameter());
		}

		protected virtual ProcessSchemaParameter CreateEntitySchemaUIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("c3cce1f9-375e-4eaf-a0c5-d93969d036e7"),
				Name = "EntitySchemaUId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
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
				UId = new Guid("ccb6d7be-508f-4337-8120-f042ff8e5cec"),
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

		protected virtual ProcessSchemaParameter CreateDeleteRightsParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("9fe621f1-a3b6-45dd-b329-6a3c2bffd2ce"),
				Name = "DeleteRights",
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateAddRightsParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("2185aa6e-7e5e-4212-8164-38d402636512"),
				Name = "AddRights",
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType"),
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
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("fc57179c-6011-46d9-8aa7-39b58da5c2a0"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				CreatedInPackageId = new Guid("456be734-98b3-4bf5-b071-1b32916f1035"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("42b287ab-7598-44b3-97ed-3d78fb515f7f"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				ModifiedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("456be734-98b3-4bf5-b071-1b32916f1035")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("3b949d18-9478-413c-8d0f-d8c32e7ee827"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				ModifiedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("456be734-98b3-4bf5-b071-1b32916f1035")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,113,47,205,76,209,81,40,46,41,202,204,75,183,211,208,180,6,0,179,24,102,192,38,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ChangeAdminRightsUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new ChangeAdminRightsUserTask(userConnection) {
				SchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081")
			};
		}

		#endregion

	}

	#endregion

	#region Class: ChangeAdminRightsUserTask

	[DesignModeProperty(Name = "EntitySchemaUId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "0ebbb23cf6db45ebad13a1445b7ef081", CaptionResourceItem = "Parameters.EntitySchemaUId.Caption", DescriptionResourceItem = "Parameters.EntitySchemaUId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "DataSourceFilters", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "0ebbb23cf6db45ebad13a1445b7ef081", CaptionResourceItem = "Parameters.DataSourceFilters.Caption", DescriptionResourceItem = "Parameters.DataSourceFilters.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "DeleteRights", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "0ebbb23cf6db45ebad13a1445b7ef081", CaptionResourceItem = "Parameters.DeleteRights.Caption", DescriptionResourceItem = "Parameters.DeleteRights.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "AddRights", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "0ebbb23cf6db45ebad13a1445b7ef081", CaptionResourceItem = "Parameters.AddRights.Caption", DescriptionResourceItem = "Parameters.AddRights.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public partial class ChangeAdminRightsUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public ChangeAdminRightsUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081");
		}

		#endregion

		#region Properties: Public

		public virtual Guid EntitySchemaUId {
			get;
			set;
		}

		public virtual string DataSourceFilters {
			get;
			set;
		}

		public virtual string DeleteRights {
			get;
			set;
		}

		public virtual string AddRights {
			get;
			set;
		}

		#endregion

		#region Methods: Public

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
			if (!HasMapping("DataSourceFilters")) {
				writer.WriteValue("DataSourceFilters", DataSourceFilters, null);
			}
			if (!HasMapping("DeleteRights")) {
				writer.WriteValue("DeleteRights", DeleteRights, null);
			}
			if (!HasMapping("AddRights")) {
				writer.WriteValue("AddRights", AddRights, null);
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
				case "DataSourceFilters":
					DataSourceFilters = reader.GetStringValue();
				break;
				case "DeleteRights":
					DeleteRights = reader.GetStringValue();
				break;
				case "AddRights":
					AddRights = reader.GetStringValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

