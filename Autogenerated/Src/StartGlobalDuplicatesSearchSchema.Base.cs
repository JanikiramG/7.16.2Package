namespace Terrasoft.Core.Process.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using Quartz;
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
	using Terrasoft.Core.Scheduler;
	using Terrasoft.UI.WebControls.Controls;

	#region Class: StartGlobalDuplicatesSearchSchema

	/// <exclude/>
	public class StartGlobalDuplicatesSearchSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public StartGlobalDuplicatesSearchSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public StartGlobalDuplicatesSearchSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a7f280e4-3d72-4bb2-9a46-fa819c9fcdf1");
			RealUId = new Guid("a7f280e4-3d72-4bb2-9a46-fa819c9fcdf1");
			Name = "StartGlobalDuplicatesSearch";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,143,205,10,194,64,12,132,207,246,41,66,78,10,210,7,176,136,138,130,232,65,132,34,158,183,49,104,181,221,44,217,236,251,219,250,115,240,231,150,153,249,66,38,115,140,166,181,63,195,85,170,189,10,113,140,59,215,50,76,97,88,210,133,91,247,84,83,64,92,16,73,242,134,56,130,89,39,75,115,106,235,70,42,215,188,146,85,10,77,77,206,56,150,236,148,46,136,48,249,4,151,226,205,209,31,176,200,22,33,244,7,79,169,97,205,223,211,166,109,249,84,119,224,171,218,86,170,33,226,247,122,231,34,142,225,55,88,171,164,208,71,217,224,243,189,49,28,34,107,215,198,51,89,45,62,63,138,222,98,112,196,249,223,120,153,84,217,91,239,62,128,81,145,41,91,82,15,166,137,11,188,3,47,76,39,119,70,1,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateSchemaNameParameter());
		}

		protected virtual ProcessSchemaParameter CreateSchemaNameParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("fd50f1c0-720e-4ef7-8397-e5b2ced46c9d"),
				Name = "SchemaName",
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
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
				UId = new Guid("616c22b2-46ec-4fb8-a404-217d8b73e479"),
				Name = "Terrasoft.Core.Scheduler",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("01b51ade-e57b-428f-a2e3-1f5525db872b"),
				Name = "Quartz",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1450d894-c032-4532-abec-996c6b8bcf46"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("a7f280e4-3d72-4bb2-9a46-fa819c9fcdf1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("61ad24ea-7b04-4efc-8180-38efa2d0d694"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("a7f280e4-3d72-4bb2-9a46-fa819c9fcdf1"),
				ModifiedInSchemaUId = new Guid("a7f280e4-3d72-4bb2-9a46-fa819c9fcdf1"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c6e52974-e581-486d-a320-7f04112e728b"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("a7f280e4-3d72-4bb2-9a46-fa819c9fcdf1"),
				ModifiedInSchemaUId = new Guid("a7f280e4-3d72-4bb2-9a46-fa819c9fcdf1"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,113,47,205,76,209,81,40,46,41,202,204,75,183,211,208,180,6,0,179,24,102,192,38,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("34bccac7-940c-4e0b-a16a-85927e3936a1"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("a7f280e4-3d72-4bb2-9a46-fa819c9fcdf1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("cb307909-9703-4d6f-a361-4d699ae5e593"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("a7f280e4-3d72-4bb2-9a46-fa819c9fcdf1"),
				ModifiedInSchemaUId = new Guid("a7f280e4-3d72-4bb2-9a46-fa819c9fcdf1"),
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
			return new StartGlobalDuplicatesSearchSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a7f280e4-3d72-4bb2-9a46-fa819c9fcdf1"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new StartGlobalDuplicatesSearch(userConnection) {
				SchemaUId = new Guid("a7f280e4-3d72-4bb2-9a46-fa819c9fcdf1")
			};
		}

		#endregion

	}

	#endregion

	#region Class: StartGlobalDuplicatesSearch

	[DesignModeProperty(Name = "SchemaName", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "a7f280e43d724bb29a46fa819c9fcdf1", CaptionResourceItem = "Parameters.SchemaName.Caption", DescriptionResourceItem = "Parameters.SchemaName.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class StartGlobalDuplicatesSearch : ProcessUserTask
	{

		#region Constructors: Public

		public StartGlobalDuplicatesSearch(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("a7f280e4-3d72-4bb2-9a46-fa819c9fcdf1");
		}

		#endregion

		#region Properties: Public

		public virtual string SchemaName {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			string jobProcessName = (SchemaName == "Account") ? "StartGlobalAccountDuplicatesSearch" : "StartGlobalContactDuplicatesSearch";
			AppScheduler.ScheduleImmediateProcessJob("DuplicatesSearchJob", "DuplicatesSearchGroup", 
				jobProcessName, UserConnection.Workspace.Name, UserConnection.CurrentUser.Name);
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
			if (!HasMapping("SchemaName")) {
				writer.WriteValue("SchemaName", SchemaName, null);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "SchemaName":
					SchemaName = reader.GetStringValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

