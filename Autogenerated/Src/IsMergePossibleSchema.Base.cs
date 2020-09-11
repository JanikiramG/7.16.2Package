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

	#region Class: IsMergePossibleSchema

	/// <exclude/>
	public class IsMergePossibleSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public IsMergePossibleSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public IsMergePossibleSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3b3fd612-5064-4f7d-a70c-dcec574087e4");
			RealUId = new Guid("3b3fd612-5064-4f7d-a70c-dcec574087e4");
			Name = "IsMergePossible";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,84,81,111,218,48,16,126,118,126,133,151,39,35,141,8,74,139,152,40,213,10,73,171,72,171,214,150,110,123,118,147,3,44,37,14,114,108,58,52,241,223,119,142,9,4,200,102,41,15,185,220,125,223,249,187,239,242,213,223,112,69,75,72,140,18,122,27,201,165,144,64,39,244,71,9,106,86,72,9,137,22,133,12,194,233,252,36,99,236,217,170,132,203,39,80,75,8,205,58,19,9,215,80,98,229,41,84,240,8,122,198,101,244,27,163,26,190,175,65,113,11,200,124,127,118,81,236,251,159,207,121,103,70,41,144,218,70,131,56,237,56,218,28,203,248,123,6,113,138,159,196,66,128,178,188,79,45,81,94,210,111,162,212,183,143,70,164,119,99,47,150,27,158,137,52,194,239,90,64,57,43,140,212,88,185,15,191,138,229,74,151,199,119,108,67,243,164,138,44,120,86,226,157,197,130,178,22,242,192,1,221,210,171,14,253,227,145,127,176,104,101,16,98,71,1,161,168,69,250,116,41,95,179,254,208,206,69,97,125,211,121,178,130,156,199,41,157,76,168,132,15,106,111,137,194,246,135,211,104,48,188,233,119,71,15,209,85,247,186,127,243,165,59,10,195,94,247,126,212,27,132,215,195,209,32,12,7,190,223,169,184,172,156,144,175,179,98,11,103,114,90,192,163,118,12,165,39,81,107,98,75,249,216,1,139,118,192,23,3,106,251,204,21,207,65,131,114,208,139,66,1,79,86,148,85,182,114,194,227,197,132,108,27,54,118,78,60,66,26,240,193,125,154,50,75,112,138,205,14,72,29,75,178,243,200,28,50,116,214,161,231,210,189,87,85,251,22,93,132,157,250,176,131,116,245,193,105,103,38,175,28,92,163,163,154,85,2,109,57,36,120,80,69,142,217,181,122,152,92,67,253,167,232,215,10,20,156,113,4,177,100,162,41,3,218,219,181,59,38,71,72,83,10,185,116,66,166,239,110,239,10,117,185,209,145,44,141,130,112,122,12,49,103,9,7,192,226,144,107,254,10,60,5,196,81,141,57,55,53,11,246,123,237,242,216,145,111,15,69,62,86,34,3,202,82,21,216,148,154,129,16,107,42,139,104,205,123,249,175,121,219,174,1,3,27,80,56,68,124,255,201,51,3,111,69,229,111,132,194,95,74,21,97,189,106,172,120,90,60,88,89,162,98,112,57,56,124,251,236,14,251,213,88,239,182,114,183,182,119,180,135,171,231,41,208,70,73,183,137,254,95,138,163,79,111,50,5,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateMergableIdentifiersParameter());
			Parameters.Add(CreateEmployeeIdentifiersParameter());
			Parameters.Add(CreateMergableSchemaIdParameter());
			Parameters.Add(CreateInvalidEntitiesCountParameter());
			Parameters.Add(CreateInvalidRightsParameter());
			Parameters.Add(CreateInvalidContactsParameter());
		}

		protected virtual ProcessSchemaParameter CreateMergableIdentifiersParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("a20a3a0e-ee10-407d-b7fe-a5106e9bfbb1"),
				Name = "MergableIdentifiers",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateEmployeeIdentifiersParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("b865bb97-dff7-45e2-8c93-89e56eb25f4c"),
				Name = "EmployeeIdentifiers",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateMergableSchemaIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("67cb82ab-7de8-49c0-8d37-96319c055be2"),
				Name = "MergableSchemaId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateInvalidEntitiesCountParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("e5b1e57b-967f-4a38-aab8-9fb937abee31"),
				Name = "InvalidEntitiesCount",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateInvalidRightsParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("ca2ea27f-c889-4648-8bc7-140594fe59ee"),
				Name = "InvalidRights",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateInvalidContactsParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("db0d223b-c7ec-4ba1-97bc-51f9761bec75"),
				Name = "InvalidContacts",
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
				UId = new Guid("cc8ba244-b508-4c02-be4b-41dae4bd363b"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("bc6a29cf-f2c5-4d99-a8ec-9ede331227a1"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("3b3fd612-5064-4f7d-a70c-dcec574087e4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("3eb78cb3-34d8-4729-b311-2b2fee8d2e94"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("3b3fd612-5064-4f7d-a70c-dcec574087e4"),
				ModifiedInSchemaUId = new Guid("3b3fd612-5064-4f7d-a70c-dcec574087e4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a982e393-c6b1-427d-b11d-19affb9368ae"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("3b3fd612-5064-4f7d-a70c-dcec574087e4"),
				ModifiedInSchemaUId = new Guid("3b3fd612-5064-4f7d-a70c-dcec574087e4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,113,47,205,76,209,81,40,46,41,202,204,75,183,211,208,180,6,0,179,24,102,192,38,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("24aebdb2-06a9-4ca6-950c-44641dffe5e2"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("3b3fd612-5064-4f7d-a70c-dcec574087e4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("fa840aa8-e7eb-4395-8955-95080dde56ec"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("3b3fd612-5064-4f7d-a70c-dcec574087e4"),
				ModifiedInSchemaUId = new Guid("3b3fd612-5064-4f7d-a70c-dcec574087e4"),
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
			return new IsMergePossibleSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3b3fd612-5064-4f7d-a70c-dcec574087e4"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new IsMergePossible(userConnection) {
				SchemaUId = new Guid("3b3fd612-5064-4f7d-a70c-dcec574087e4")
			};
		}

		#endregion

	}

	#endregion

	#region Class: IsMergePossible

	[DesignModeProperty(Name = "MergableIdentifiers", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "3b3fd61250644f7da70cdcec574087e4", CaptionResourceItem = "Parameters.MergableIdentifiers.Caption", DescriptionResourceItem = "Parameters.MergableIdentifiers.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "EmployeeIdentifiers", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "3b3fd61250644f7da70cdcec574087e4", CaptionResourceItem = "Parameters.EmployeeIdentifiers.Caption", DescriptionResourceItem = "Parameters.EmployeeIdentifiers.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "MergableSchemaId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "3b3fd61250644f7da70cdcec574087e4", CaptionResourceItem = "Parameters.MergableSchemaId.Caption", DescriptionResourceItem = "Parameters.MergableSchemaId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "InvalidEntitiesCount", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "3b3fd61250644f7da70cdcec574087e4", CaptionResourceItem = "Parameters.InvalidEntitiesCount.Caption", DescriptionResourceItem = "Parameters.InvalidEntitiesCount.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "InvalidRights", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "3b3fd61250644f7da70cdcec574087e4", CaptionResourceItem = "Parameters.InvalidRights.Caption", DescriptionResourceItem = "Parameters.InvalidRights.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "InvalidContacts", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "3b3fd61250644f7da70cdcec574087e4", CaptionResourceItem = "Parameters.InvalidContacts.Caption", DescriptionResourceItem = "Parameters.InvalidContacts.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class IsMergePossible : ProcessUserTask
	{

		#region Constructors: Public

		public IsMergePossible(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("3b3fd612-5064-4f7d-a70c-dcec574087e4");
		}

		#endregion

		#region Properties: Public

		public virtual Object MergableIdentifiers {
			get;
			set;
		}

		public virtual Object EmployeeIdentifiers {
			get;
			set;
		}

		public virtual Guid MergableSchemaId {
			get;
			set;
		}

		public virtual bool InvalidEntitiesCount {
			get;
			set;
		}

		public virtual bool InvalidRights {
			get;
			set;
		}

		public virtual bool InvalidContacts {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			var securityEngine = UserConnection.DBSecurityEngine;
			var canMergeDuplicates = securityEngine.GetCanExecuteOperation("CanMergeDuplicates", UserConnection.CurrentUser.Id);
			var mergableIdentifiers = MergableIdentifiers as List<Guid>;
			InvalidEntitiesCount = InvalidRights = InvalidContacts = false;
			if (mergableIdentifiers.Count < 2) {
				InvalidEntitiesCount = true;
			} else if (!canMergeDuplicates) {
				InvalidRights = true;
			} else if (MergableSchemaId == new Guid("16BE3651-8FE2-4159-8DD0-A803D4683DD3")) {
				var employeeIdentifiers = new List<Guid>();
				EmployeeIdentifiers = employeeIdentifiers;
				var identifiers = new List<QueryParameter>();
				foreach (var contactId in mergableIdentifiers) {	
					identifiers.Add(new QueryParameter(contactId));
				}
				Select employeesSelectQuery = new Select(UserConnection)
													.Column("ContactId")
							                    	.From("Employee")								
							                    	.Where("ContactId").In(identifiers) as Select;									
				using (var dbExecutor = UserConnection.EnsureDBConnection()) {
					using(IDataReader dr = employeesSelectQuery.ExecuteReader(dbExecutor)) {
						while (dr.Read()) {
							Guid empId = UserConnection.DBTypeConverter.DBValueToGuid(dr.GetValue(0));
							employeeIdentifiers.Add(empId);
						}
					}
				}
				InvalidContacts = employeeIdentifiers.Count > 0;
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
			if (MergableIdentifiers != null) {
				if (MergableIdentifiers.GetType().IsSerializable || MergableIdentifiers.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("MergableIdentifiers", MergableIdentifiers, null);
				}
			}
			if (EmployeeIdentifiers != null) {
				if (EmployeeIdentifiers.GetType().IsSerializable || EmployeeIdentifiers.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("EmployeeIdentifiers", EmployeeIdentifiers, null);
				}
			}
			if (!HasMapping("MergableSchemaId")) {
				writer.WriteValue("MergableSchemaId", MergableSchemaId, Guid.Empty);
			}
			if (!HasMapping("InvalidEntitiesCount")) {
				writer.WriteValue("InvalidEntitiesCount", InvalidEntitiesCount, false);
			}
			if (!HasMapping("InvalidRights")) {
				writer.WriteValue("InvalidRights", InvalidRights, false);
			}
			if (!HasMapping("InvalidContacts")) {
				writer.WriteValue("InvalidContacts", InvalidContacts, false);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "MergableIdentifiers":
					MergableIdentifiers = reader.GetSerializableObjectValue();
				break;
				case "EmployeeIdentifiers":
					EmployeeIdentifiers = reader.GetSerializableObjectValue();
				break;
				case "MergableSchemaId":
					MergableSchemaId = reader.GetGuidValue();
				break;
				case "InvalidEntitiesCount":
					InvalidEntitiesCount = reader.GetBoolValue();
				break;
				case "InvalidRights":
					InvalidRights = reader.GetBoolValue();
				break;
				case "InvalidContacts":
					InvalidContacts = reader.GetBoolValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

