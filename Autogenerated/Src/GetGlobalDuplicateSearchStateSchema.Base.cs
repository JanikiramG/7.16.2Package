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

	#region Class: GetGlobalDuplicateSearchStateSchema

	/// <exclude/>
	public class GetGlobalDuplicateSearchStateSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public GetGlobalDuplicateSearchStateSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public GetGlobalDuplicateSearchStateSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a3c617ae-f962-410f-b2f5-c623fc3fd34a");
			RealUId = new Guid("a3c617ae-f962-410f-b2f5-c623fc3fd34a");
			Name = "GetGlobalDuplicateSearchState";
			CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,83,193,110,212,48,16,61,39,95,49,242,201,65,40,108,225,198,170,2,154,93,170,229,64,91,54,192,217,77,70,155,72,94,123,25,219,45,21,234,191,51,78,182,108,210,102,41,7,172,40,113,60,243,222,204,188,188,188,23,107,212,88,121,168,195,78,183,149,242,184,70,69,85,179,246,221,182,11,157,130,193,91,232,95,228,87,135,84,88,99,120,223,90,147,37,188,96,98,165,201,195,202,11,171,195,214,72,33,6,204,66,188,4,33,46,201,86,232,28,214,133,13,198,11,145,253,29,21,92,15,43,108,141,207,38,239,75,12,209,69,163,204,6,235,11,243,175,224,210,122,165,71,189,77,141,154,127,36,187,101,248,185,182,215,74,47,38,116,100,116,254,193,61,174,48,236,225,147,109,141,140,183,242,110,135,249,138,229,165,216,192,81,202,40,197,19,206,238,240,64,154,228,23,207,74,178,170,35,207,202,45,127,4,165,39,197,238,50,142,207,254,189,65,194,8,172,26,220,170,210,246,4,159,213,22,135,196,209,63,87,1,233,238,82,17,135,60,146,220,87,234,96,49,61,203,64,185,189,201,230,105,112,173,217,128,188,81,4,245,245,242,39,86,193,91,98,35,142,221,151,47,141,11,132,139,179,195,145,100,158,95,105,210,225,123,184,242,234,11,170,26,35,252,184,201,243,190,8,246,169,242,80,180,231,75,110,155,86,35,200,3,91,30,31,251,106,73,210,26,15,187,145,155,159,54,187,56,139,31,151,15,110,144,88,1,126,255,166,116,192,210,174,140,31,18,159,163,239,2,114,150,101,243,72,62,242,48,123,159,169,165,243,196,19,102,83,176,147,9,212,131,243,35,116,193,67,151,45,43,62,5,126,221,131,227,60,254,143,251,255,195,44,111,70,179,240,143,191,33,214,42,182,51,44,115,10,179,12,222,193,12,222,130,124,36,231,11,56,153,113,240,213,160,173,72,120,159,242,117,159,18,250,64,6,60,5,156,139,223,54,217,194,74,212,4,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateSearchSchemaNameParameter());
			Parameters.Add(CreateSearchProgressParameter());
			Parameters.Add(CreateSearchStatusCodeParameter());
			Parameters.Add(CreateSearchStatusChangedOnParameter());
		}

		protected virtual ProcessSchemaParameter CreateSearchSchemaNameParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("56ab8f10-e641-4e56-82f2-0c4696b7cb44"),
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

		protected virtual ProcessSchemaParameter CreateSearchProgressParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("d9d68558-f9e3-475a-94f0-3554fab61bd7"),
				Name = "SearchProgress",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateSearchStatusCodeParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("e6a0fb48-2819-4243-bfdc-2790bc09d2a1"),
				Name = "SearchStatusCode",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateSearchStatusChangedOnParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("54100e2a-9c26-402d-ac3e-bed9ef3be345"),
				Name = "SearchStatusChangedOn",
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime"),
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

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("35c4a661-d53a-4580-82d9-8debc2cdeed1"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("a3c617ae-f962-410f-b2f5-c623fc3fd34a"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("256a48f4-7565-4580-9f49-f67c4bd05ef1"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("a3c617ae-f962-410f-b2f5-c623fc3fd34a"),
				ModifiedInSchemaUId = new Guid("a3c617ae-f962-410f-b2f5-c623fc3fd34a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b31f9893-3c52-4ef8-b156-ef86628cea2b"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("a3c617ae-f962-410f-b2f5-c623fc3fd34a"),
				ModifiedInSchemaUId = new Guid("a3c617ae-f962-410f-b2f5-c623fc3fd34a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,113,47,205,76,209,81,40,46,41,202,204,75,183,211,208,180,6,0,179,24,102,192,38,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("658cbd1e-9f34-4021-a255-8e63d8a5c69c"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("a3c617ae-f962-410f-b2f5-c623fc3fd34a"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				ResultValueTypeName = "bool",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c1099ef0-8f7f-4f2b-83d6-83f155034d57"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("a3c617ae-f962-410f-b2f5-c623fc3fd34a"),
				ModifiedInSchemaUId = new Guid("a3c617ae-f962-410f-b2f5-c623fc3fd34a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,74,44,78,213,115,206,207,45,200,73,45,73,117,173,72,77,46,45,201,204,75,215,40,72,44,74,204,5,138,20,21,107,90,3,0,145,9,166,203,42,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new GetGlobalDuplicateSearchStateSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a3c617ae-f962-410f-b2f5-c623fc3fd34a"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new GetGlobalDuplicateSearchState(userConnection) {
				SchemaUId = new Guid("a3c617ae-f962-410f-b2f5-c623fc3fd34a")
			};
		}

		#endregion

	}

	#endregion

	#region Class: GetGlobalDuplicateSearchState

	[DesignModeProperty(Name = "SearchSchemaName", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "a3c617aef962410fb2f5c623fc3fd34a", CaptionResourceItem = "Parameters.SearchSchemaName.Caption", DescriptionResourceItem = "Parameters.SearchSchemaName.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "SearchProgress", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "a3c617aef962410fb2f5c623fc3fd34a", CaptionResourceItem = "Parameters.SearchProgress.Caption", DescriptionResourceItem = "Parameters.SearchProgress.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "SearchStatusCode", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "a3c617aef962410fb2f5c623fc3fd34a", CaptionResourceItem = "Parameters.SearchStatusCode.Caption", DescriptionResourceItem = "Parameters.SearchStatusCode.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "SearchStatusChangedOn", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "a3c617aef962410fb2f5c623fc3fd34a", CaptionResourceItem = "Parameters.SearchStatusChangedOn.Caption", DescriptionResourceItem = "Parameters.SearchStatusChangedOn.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class GetGlobalDuplicateSearchState : ProcessUserTask
	{

		#region Constructors: Public

		public GetGlobalDuplicateSearchState(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("a3c617ae-f962-410f-b2f5-c623fc3fd34a");
		}

		#endregion

		#region Properties: Public

		public virtual string SearchSchemaName {
			get;
			set;
		}

		public virtual int SearchProgress {
			get;
			set;
		}

		public virtual string SearchStatusCode {
			get;
			set;
		}

		public virtual DateTime SearchStatusChangedOn {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			Select duplicateSearchStateSelect = new Select(UserConnection)				                    
												.Column("SearchState", "ProcessedCount")
												.Column("SearchStatus", "Code")
												.Column("SearchState", "SearchStatusChangedOn")
												.Column("SearchState", "TotalCount")
							                    .From("GlobalDuplicateSearchState").As("SearchState")
												.Join(JoinType.Inner, "GlobalDuplicateSearchStatus").As("SearchStatus")
													.On("SearchState", "SearchStatusId").IsEqual("SearchStatus", "Id")
							                    .Where("SchemaToSearchName").IsEqual(new QueryParameter(SearchSchemaName)) as Select;
			using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				using(var dataReader = duplicateSearchStateSelect.ExecuteReader(dbExecutor)) {
					while (dataReader.Read()) {
						int processedCount = UserConnection.DBTypeConverter.DBValueToInt(dataReader.GetValue(0));
						SearchStatusCode = (string)dataReader.GetValue(1);
						SearchStatusChangedOn = (DateTime)dataReader.GetValue(2);
						int totalCount = UserConnection.DBTypeConverter.DBValueToInt(dataReader.GetValue(3));
						SearchProgress = (totalCount == 0) ? 0 : (processedCount * 100) / totalCount;
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
			if (!HasMapping("SearchProgress")) {
				writer.WriteValue("SearchProgress", SearchProgress, 0);
			}
			if (!HasMapping("SearchStatusCode")) {
				writer.WriteValue("SearchStatusCode", SearchStatusCode, null);
			}
			if (!HasMapping("SearchStatusChangedOn")) {
				writer.WriteValue("SearchStatusChangedOn", SearchStatusChangedOn, DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture));
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
				case "SearchProgress":
					SearchProgress = reader.GetIntValue();
				break;
				case "SearchStatusCode":
					SearchStatusCode = reader.GetStringValue();
				break;
				case "SearchStatusChangedOn":
					SearchStatusChangedOn = reader.GetDateTimeValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

