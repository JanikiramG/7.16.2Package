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

	#region Class: GetDuplicateSearchSettingsSchema

	/// <exclude/>
	public class GetDuplicateSearchSettingsSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public GetDuplicateSearchSettingsSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public GetDuplicateSearchSettingsSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2cdf118b-2004-41c8-80d0-d8d69b9a6f48");
			RealUId = new Guid("2cdf118b-2004-41c8-80d0-d8d69b9a6f48");
			Name = "GetDuplicateSearchSettings";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,145,65,79,195,48,12,133,207,237,175,136,122,74,47,17,247,9,9,109,29,104,23,24,180,192,57,116,15,90,169,77,38,39,217,152,208,254,59,238,50,54,33,58,9,43,135,216,122,254,236,188,220,100,37,58,212,94,56,120,223,154,15,23,211,199,0,218,137,107,97,176,21,177,34,159,29,104,102,141,225,123,107,77,158,112,136,145,72,147,159,80,51,219,133,222,200,44,91,130,222,45,245,37,52,213,205,131,41,245,6,89,150,159,132,233,37,150,186,37,219,115,127,17,214,93,91,107,15,23,17,75,77,186,135,7,253,143,242,218,128,192,152,178,110,208,235,202,70,200,61,35,184,95,45,140,140,139,170,19,86,70,69,212,15,186,60,23,218,29,141,152,156,39,6,199,142,9,185,209,36,86,111,243,79,212,193,91,98,215,126,91,165,230,198,5,66,49,61,151,36,3,191,210,228,208,47,23,133,246,250,9,122,5,198,12,237,35,95,161,34,29,81,38,207,211,34,40,217,54,109,7,33,87,164,6,197,17,159,36,35,198,255,93,175,152,86,187,53,184,176,1,241,227,57,127,209,93,64,101,167,214,118,3,242,14,254,80,145,87,121,62,57,24,189,79,249,236,83,130,15,100,132,167,128,73,246,13,255,107,85,40,74,2,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateSearchSchemaNameParameter());
			Parameters.Add(CreatePerformSearchOnSaveParameter());
		}

		protected virtual ProcessSchemaParameter CreateSearchSchemaNameParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("426ab11d-e6a2-4838-bcfd-166df437f404"),
				Name = "SearchSchemaName",
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreatePerformSearchOnSaveParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("31f9745d-b8f3-4b7e-8846-19c227cacaef"),
				Name = "PerformSearchOnSave",
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
				UId = new Guid("6275b88a-ebff-4d76-a4de-059efbdda29d"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("17d78e09-720d-474d-a5e0-6fd254919321"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("2cdf118b-2004-41c8-80d0-d8d69b9a6f48"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8f15f747-01ca-4748-a46b-577a2ada4a18"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("2cdf118b-2004-41c8-80d0-d8d69b9a6f48"),
				ModifiedInSchemaUId = new Guid("2cdf118b-2004-41c8-80d0-d8d69b9a6f48"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("821504ce-51a7-49a8-88e5-81159e17dd61"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("2cdf118b-2004-41c8-80d0-d8d69b9a6f48"),
				ModifiedInSchemaUId = new Guid("2cdf118b-2004-41c8-80d0-d8d69b9a6f48"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,113,47,205,76,209,81,40,46,41,202,204,75,183,211,208,180,6,0,179,24,102,192,38,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6089d7dc-2a7d-4509-9eca-4590a766eb64"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("2cdf118b-2004-41c8-80d0-d8d69b9a6f48"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("236f309c-0581-427a-a892-3166f7dfe06f"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("2cdf118b-2004-41c8-80d0-d8d69b9a6f48"),
				ModifiedInSchemaUId = new Guid("2cdf118b-2004-41c8-80d0-d8d69b9a6f48"),
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
			return new GetDuplicateSearchSettingsSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2cdf118b-2004-41c8-80d0-d8d69b9a6f48"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new GetDuplicateSearchSettings(userConnection) {
				SchemaUId = new Guid("2cdf118b-2004-41c8-80d0-d8d69b9a6f48")
			};
		}

		#endregion

	}

	#endregion

	#region Class: GetDuplicateSearchSettings

	[DesignModeProperty(Name = "SearchSchemaName", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "2cdf118b200441c880d0d8d69b9a6f48", CaptionResourceItem = "Parameters.SearchSchemaName.Caption", DescriptionResourceItem = "Parameters.SearchSchemaName.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "PerformSearchOnSave", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "2cdf118b200441c880d0d8d69b9a6f48", CaptionResourceItem = "Parameters.PerformSearchOnSave.Caption", DescriptionResourceItem = "Parameters.PerformSearchOnSave.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class GetDuplicateSearchSettings : ProcessUserTask
	{

		#region Constructors: Public

		public GetDuplicateSearchSettings(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("2cdf118b-2004-41c8-80d0-d8d69b9a6f48");
		}

		#endregion

		#region Properties: Public

		public virtual string SearchSchemaName {
			get;
			set;
		}

		public virtual bool PerformSearchOnSave {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			Select settingsSelectQuery = new Select(UserConnection)				                    
												.Column("PerformSearchOnSave")									
							                    .From("DuplicatesSearchParameter")									
							                    .Where("SchemaToSearchName").In(Column.Parameter(SearchSchemaName)) as Select;									
			using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				using(IDataReader dr = settingsSelectQuery.ExecuteReader(dbExecutor)) {
					while (dr.Read()) {
						PerformSearchOnSave = UserConnection.DBTypeConverter.DBValueToBool(dr.GetValue(0));		
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

		public override void WritePropertiesData(DataWriter writer) {
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer);
			if (Status == Core.Process.ProcessStatus.Inactive) {
				writer.WriteFinishObject();
				return;
			}
			if (!HasMapping("SearchSchemaName")) {
				writer.WriteValue("SearchSchemaName", SearchSchemaName, null);
			}
			if (!HasMapping("PerformSearchOnSave")) {
				writer.WriteValue("PerformSearchOnSave", PerformSearchOnSave, false);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "SearchSchemaName":
					SearchSchemaName = reader.GetStringValue();
				break;
				case "PerformSearchOnSave":
					PerformSearchOnSave = reader.GetBoolValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

