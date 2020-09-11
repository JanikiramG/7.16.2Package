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

	#region Class: SetGlobalDuplicateSearchStateSchema

	/// <exclude/>
	public class SetGlobalDuplicateSearchStateSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public SetGlobalDuplicateSearchStateSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public SetGlobalDuplicateSearchStateSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f3600c2b-cc02-4ab0-b395-a1f077697f01");
			RealUId = new Guid("f3600c2b-cc02-4ab0-b395-a1f077697f01");
			Name = "SetGlobalDuplicateSearchState";
			CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,193,106,3,33,16,134,207,217,167,144,57,41,4,33,231,165,80,216,38,37,151,80,48,161,103,235,14,108,192,213,173,58,180,143,223,49,110,73,233,161,212,139,50,243,253,31,227,60,194,101,25,109,65,65,237,122,16,1,63,68,171,201,75,198,52,196,16,208,149,107,12,91,1,240,236,227,155,245,79,180,248,171,99,194,160,77,110,50,133,159,0,170,219,240,209,6,139,4,184,119,40,31,71,128,237,173,185,169,114,131,158,133,191,228,74,159,227,34,119,205,193,150,33,122,154,3,139,106,120,173,234,67,138,179,252,99,8,202,119,246,117,194,132,12,15,113,172,179,233,99,222,191,147,245,178,137,245,139,77,118,198,130,73,254,140,87,88,169,245,35,223,6,227,38,156,237,57,54,240,196,177,255,248,110,161,10,43,37,108,94,55,218,119,109,205,122,255,137,142,120,195,170,239,18,22,74,65,148,68,216,195,23,59,118,183,24,143,1,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateSearchSchemaNameParameter());
			Parameters.Add(CreateSearchStatusCodeParameter());
		}

		protected virtual ProcessSchemaParameter CreateSearchSchemaNameParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("1c935a42-4061-4bf4-a1f8-d724a31c3ee1"),
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

		protected virtual ProcessSchemaParameter CreateSearchStatusCodeParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("e85b3735-d44f-4e1c-bf62-16e39f34d5c4"),
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

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetResultParameterAllValuesMethod());
			Methods.Add(CreateCompleteExecutingMethod());
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("07ef219e-8434-47f5-9bcd-64c2b8a9cef0"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("f3600c2b-cc02-4ab0-b395-a1f077697f01"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4a16f8e5-ec96-4674-b1d9-10f26de2bf23"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("f3600c2b-cc02-4ab0-b395-a1f077697f01"),
				ModifiedInSchemaUId = new Guid("f3600c2b-cc02-4ab0-b395-a1f077697f01"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("5a4ddea5-963e-4a75-b063-f0026fa0d9f4"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("f3600c2b-cc02-4ab0-b395-a1f077697f01"),
				ModifiedInSchemaUId = new Guid("f3600c2b-cc02-4ab0-b395-a1f077697f01"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,113,47,205,76,209,81,40,46,41,202,204,75,183,211,208,180,6,0,179,24,102,192,38,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6f254ab7-36e0-4ee2-b9ef-e54d5dda862f"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("f3600c2b-cc02-4ab0-b395-a1f077697f01"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				ResultValueTypeName = "bool",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c46d508f-dbf2-46ba-b3e6-d4b66af2392b"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("f3600c2b-cc02-4ab0-b395-a1f077697f01"),
				ModifiedInSchemaUId = new Guid("f3600c2b-cc02-4ab0-b395-a1f077697f01"),
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
			return new SetGlobalDuplicateSearchStateSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f3600c2b-cc02-4ab0-b395-a1f077697f01"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new SetGlobalDuplicateSearchState(userConnection) {
				SchemaUId = new Guid("f3600c2b-cc02-4ab0-b395-a1f077697f01")
			};
		}

		#endregion

	}

	#endregion

	#region Class: SetGlobalDuplicateSearchState

	[DesignModeProperty(Name = "SearchSchemaName", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "f3600c2bcc024ab0b395a1f077697f01", CaptionResourceItem = "Parameters.SearchSchemaName.Caption", DescriptionResourceItem = "Parameters.SearchSchemaName.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "SearchStatusCode", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "f3600c2bcc024ab0b395a1f077697f01", CaptionResourceItem = "Parameters.SearchStatusCode.Caption", DescriptionResourceItem = "Parameters.SearchStatusCode.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class SetGlobalDuplicateSearchState : ProcessUserTask
	{

		#region Constructors: Public

		public SetGlobalDuplicateSearchState(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("f3600c2b-cc02-4ab0-b395-a1f077697f01");
		}

		#endregion

		#region Properties: Public

		public virtual string SearchSchemaName {
			get;
			set;
		}

		public virtual string SearchStatusCode {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			Update update = new Update(UserConnection, "GlobalDuplicateSearchState")
							.Set("SearchStatusId",
								new Select(UserConnection).Top(1)
									.Column("Id")
								.From("GlobalDuplicateSearchStatus")
								.Where("Code").IsEqual(Column.Parameter(SearchStatusCode)))
							.Where("SchemaToSearchName").IsEqual(Column.Parameter(SearchSchemaName)) as Update;
			update.Execute();
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
			if (!HasMapping("SearchStatusCode")) {
				writer.WriteValue("SearchStatusCode", SearchStatusCode, null);
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
				case "SearchStatusCode":
					SearchStatusCode = reader.GetStringValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

