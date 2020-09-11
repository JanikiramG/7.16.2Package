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

	#region Class: SearchForDuplicatesSchema

	/// <exclude/>
	public class SearchForDuplicatesSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public SearchForDuplicatesSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public SearchForDuplicatesSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dde01b43-31dc-47b2-b249-b8562a9ff203");
			RealUId = new Guid("dde01b43-31dc-47b2-b249-b8562a9ff203");
			Name = "SearchForDuplicates";
			CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,81,111,155,48,20,133,159,225,87,88,60,145,7,71,198,24,48,202,90,13,99,51,85,218,67,181,182,123,103,112,215,34,165,16,25,211,46,154,242,223,103,147,44,73,179,117,218,163,175,207,253,238,241,185,254,24,148,67,111,234,198,220,53,79,240,92,223,180,232,10,245,240,138,62,77,93,27,6,65,148,10,21,167,73,132,121,165,40,102,81,146,99,46,37,193,5,39,177,100,41,143,165,140,131,96,177,242,139,166,25,166,254,29,10,77,100,86,70,133,192,145,84,4,179,132,68,88,48,66,49,161,138,168,164,200,168,76,213,76,145,211,102,221,53,181,129,51,142,99,44,213,243,198,108,87,190,106,59,115,91,63,194,31,23,221,119,20,158,122,174,208,197,163,22,232,167,239,253,13,126,102,178,168,36,151,60,35,56,47,211,2,51,198,41,22,57,81,56,137,83,78,11,37,211,52,226,179,73,239,141,139,243,176,236,99,68,204,9,166,73,21,99,150,49,105,195,82,37,78,237,99,57,139,56,41,202,204,17,60,127,135,96,61,2,186,116,125,17,226,127,185,102,89,70,83,38,176,205,48,199,140,139,12,231,52,229,88,229,130,201,56,87,162,226,241,191,93,151,138,198,76,100,2,103,5,143,48,147,118,57,121,150,43,28,211,138,48,158,147,72,84,114,38,28,76,91,79,26,204,164,123,100,244,4,182,236,191,212,26,141,102,208,208,222,234,161,113,155,1,115,119,60,67,59,105,8,109,255,52,118,253,35,10,157,186,253,166,126,64,51,89,141,85,63,140,160,237,190,122,104,76,55,244,75,213,143,182,65,138,83,41,92,204,73,28,250,111,100,109,234,47,80,183,96,57,174,255,52,122,185,167,194,254,54,60,77,217,3,60,55,90,195,56,173,205,33,130,207,221,104,62,184,28,174,173,65,207,179,146,215,167,110,13,40,108,245,210,65,14,147,61,207,105,16,244,166,51,219,57,191,11,207,82,220,111,55,96,11,47,160,13,104,123,254,90,175,39,184,31,230,140,45,204,38,50,87,66,178,112,187,240,188,189,141,101,209,182,225,111,236,124,177,155,93,28,151,62,86,246,67,184,129,7,125,233,254,7,186,70,100,245,70,117,20,216,242,206,126,47,255,124,67,193,47,164,3,39,196,228,3,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateSchemaIdParameter());
			Parameters.Add(CreateDuplicateSchemaIdParameter());
			Parameters.Add(CreateEditPageIdParameter());
			Parameters.Add(CreateRecordIdParameter());
			Parameters.Add(CreateContactSchemaIdParameter());
			Parameters.Add(CreateAccountSchemaIdParameter());
			Parameters.Add(CreateDuplicatesParameter());
			Parameters.Add(CreateSearchParametersParameter());
			Parameters.Add(CreateDuplicatesFoundParameter());
			Parameters.Add(CreateIdConstraintsParameter());
			Parameters.Add(CreateReadSearchParametersParameter());
			Parameters.Add(CreateSearchParameterNamesParameter());
			Parameters.Add(CreateInsertResultsParameter());
		}

		protected virtual ProcessSchemaParameter CreateSchemaIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("3b7e643f-83ec-4989-ba20-22a413e752e9"),
				Name = "SchemaId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateDuplicateSchemaIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("cdc9bcc1-e72d-4c38-8117-8611d4524b14"),
				Name = "DuplicateSchemaId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateEditPageIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("0adf5181-1556-4f04-a6da-187ccd1f98f7"),
				Name = "EditPageId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateRecordIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("e7c54b1b-31ea-41b5-a43b-1b129bc66821"),
				Name = "RecordId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateContactSchemaIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("8b97bfac-41aa-4465-9632-3dceccdf33e4"),
				Name = "ContactSchemaId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateAccountSchemaIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("c4087bc7-9629-4cb9-a628-4517d2e7ed16"),
				Name = "AccountSchemaId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateDuplicatesParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("6b9fe13d-7de9-4ffa-a7d7-0dae8b38bf7d"),
				Name = "Duplicates",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateSearchParametersParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("63605d7e-cf56-4c3f-93a1-a8722a6f7e1a"),
				Name = "SearchParameters",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateDuplicatesFoundParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("861e3231-1d1b-4c14-8e87-76730cc897cc"),
				Name = "DuplicatesFound",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateIdConstraintsParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("c58653ca-1ebc-4e36-a639-085e38f5ea05"),
				Name = "IdConstraints",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateReadSearchParametersParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("fefd239f-f81c-4753-aa4e-c48c85636da7"),
				Name = "ReadSearchParameters",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateSearchParameterNamesParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("db47fc68-70d9-4e99-81d4-015dd7ecc494"),
				Name = "SearchParameterNames",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateInsertResultsParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("04dc05c3-e1a8-455b-b246-045bdf71c942"),
				Name = "InsertResults",
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
			Methods.Add(CreateGetStoredProcedureMethod());
			Methods.Add(CreateAddStoredProcedureParameterMethod());
			Methods.Add(CreateGetConstraintsStrMethod());
			Methods.Add(CreateReadSearchParamsMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2cf34984-e640-4ea2-9c0f-5342693ef0cc"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			});
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ade96dca-beca-4ddb-8931-68a7217d737c"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("dde01b43-31dc-47b2-b249-b8562a9ff203"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("0d12ac67-d380-4a2f-bfb7-0705b3f55bff"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("dde01b43-31dc-47b2-b249-b8562a9ff203"),
				ModifiedInSchemaUId = new Guid("dde01b43-31dc-47b2-b249-b8562a9ff203"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("304415bc-9918-44da-aeb9-6c5f029500c3"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("dde01b43-31dc-47b2-b249-b8562a9ff203"),
				ModifiedInSchemaUId = new Guid("dde01b43-31dc-47b2-b249-b8562a9ff203"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,113,47,205,76,209,81,40,46,41,202,204,75,183,211,208,180,6,0,179,24,102,192,38,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a6d0aabc-36d0-4359-aedb-1049f97456b9"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("dde01b43-31dc-47b2-b249-b8562a9ff203"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				ResultValueTypeName = "bool",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("60682797-9c10-4b50-9eb5-1857c2f17545"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("dde01b43-31dc-47b2-b249-b8562a9ff203"),
				ModifiedInSchemaUId = new Guid("dde01b43-31dc-47b2-b249-b8562a9ff203"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,74,44,78,213,115,206,207,45,200,73,45,73,117,173,72,77,46,45,201,204,75,215,40,72,44,74,204,5,138,20,21,107,90,3,0,145,9,166,203,42,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetStoredProcedureMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8e658b1a-163d-41f3-8c99-5a5dcde0fb79"),
				Name = "GetStoredProcedure",
				CreatedInSchemaUId = new Guid("dde01b43-31dc-47b2-b249-b8562a9ff203"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				ResultValueTypeName = "StoredProcedure"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,148,193,142,218,48,16,134,207,225,41,220,156,28,41,226,5,40,43,177,165,93,33,117,171,21,208,94,171,89,123,0,75,193,142,236,9,45,90,237,187,119,12,9,90,156,28,64,234,117,102,254,239,183,51,191,115,0,47,106,239,212,15,216,163,152,138,64,222,216,237,248,235,190,166,227,100,116,224,166,6,130,95,80,53,184,62,214,248,12,22,182,232,121,80,206,7,234,197,207,128,254,139,179,22,21,25,103,199,179,186,110,59,47,222,29,140,70,63,126,66,106,75,50,31,66,228,197,217,118,219,24,125,213,143,158,79,105,177,24,58,93,244,88,216,64,96,21,62,30,227,197,100,30,149,29,154,240,47,245,208,235,180,120,51,58,42,59,244,171,115,21,130,237,209,31,7,234,55,27,180,226,206,131,101,184,54,123,236,153,204,135,26,55,187,116,234,104,99,54,66,174,212,14,247,176,208,98,58,21,51,165,92,99,169,43,21,226,109,148,125,8,77,78,161,254,189,66,240,106,247,205,249,118,120,222,212,149,81,12,13,249,100,244,46,176,10,40,82,46,71,133,64,221,200,109,135,175,185,167,163,46,17,244,121,236,5,60,75,9,125,56,177,146,70,144,69,148,196,143,24,200,121,212,156,74,133,186,241,209,204,226,31,177,186,174,202,235,56,151,151,135,194,152,153,214,201,244,197,91,38,240,82,44,81,57,175,23,186,236,199,250,94,20,175,13,61,45,49,52,21,133,114,48,112,247,34,243,13,240,114,242,255,3,235,98,52,126,54,246,4,41,135,3,123,47,151,19,203,155,224,223,19,24,75,97,69,94,22,101,255,37,183,79,36,36,97,224,245,166,249,16,16,196,119,19,232,243,249,143,247,112,14,125,79,248,137,131,209,84,213,41,77,27,62,18,168,157,144,209,162,238,102,132,177,61,63,30,207,178,81,150,221,117,195,11,113,248,94,217,59,71,215,35,53,222,166,233,157,252,3,18,243,96,23,197,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateAddStoredProcedureParameterMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("388d46ea-212a-43e5-ac5b-8c44f5b25283"),
				Name = "AddStoredProcedureParameter",
				CreatedInSchemaUId = new Guid("dde01b43-31dc-47b2-b249-b8562a9ff203"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f425b8a5-2abb-44d9-b2c7-f4a4e242fdc4"),
				Name = "storedProcedure",
				CreatedInSchemaUId = new Guid("dde01b43-31dc-47b2-b249-b8562a9ff203"),
				ModifiedInSchemaUId = new Guid("dde01b43-31dc-47b2-b249-b8562a9ff203"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "StoredProcedure",
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("0e8888df-959b-458f-9fcb-7a94155bb64f"),
				Name = "value",
				CreatedInSchemaUId = new Guid("dde01b43-31dc-47b2-b249-b8562a9ff203"),
				ModifiedInSchemaUId = new Guid("dde01b43-31dc-47b2-b249-b8562a9ff203"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("bfa2d7e8-0182-498e-8216-971c196c7fde"),
				Name = "dataValueType",
				CreatedInSchemaUId = new Guid("dde01b43-31dc-47b2-b249-b8562a9ff203"),
				ModifiedInSchemaUId = new Guid("dde01b43-31dc-47b2-b249-b8562a9ff203"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DataValueType",
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,143,205,14,130,48,16,132,207,242,20,123,44,137,225,5,72,79,104,140,23,197,132,232,185,202,162,77,74,75,250,163,18,194,187,11,197,128,36,134,99,103,190,157,233,92,149,18,192,205,193,9,1,20,10,38,12,198,1,47,128,228,204,178,51,19,14,179,186,194,142,128,12,223,118,243,43,134,208,4,171,241,212,88,205,229,61,218,251,247,81,111,203,202,214,228,217,179,192,204,215,13,227,160,5,236,42,224,111,195,206,241,124,161,129,144,30,8,135,76,74,61,30,249,158,41,119,198,143,164,236,132,158,241,195,6,223,71,27,171,52,230,169,86,55,204,157,198,232,194,237,35,101,154,149,104,81,147,68,9,87,202,40,81,210,88,226,35,102,61,203,199,18,95,112,114,168,235,81,130,6,166,181,20,102,235,215,131,213,201,195,159,219,190,233,3,74,153,208,72,155,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetConstraintsStrMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("bf7b66f5-26b5-4f66-a98c-2cb8bbd1b7ab"),
				Name = "GetConstraintsStr",
				CreatedInSchemaUId = new Guid("dde01b43-31dc-47b2-b249-b8562a9ff203"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,142,203,10,194,48,16,69,215,153,175,24,187,40,9,66,113,31,219,77,21,17,220,233,15,132,62,116,160,77,36,143,130,72,255,221,88,65,72,151,115,239,185,195,153,148,69,106,107,163,157,183,138,180,119,88,226,57,185,149,195,11,57,191,63,5,106,43,9,49,39,125,199,230,79,124,203,56,250,229,197,113,124,250,151,4,234,145,243,244,239,166,68,29,134,65,96,158,99,90,21,181,9,218,99,133,59,33,240,205,128,245,198,118,170,121,32,159,22,59,36,157,58,70,10,24,91,41,108,203,8,21,55,115,93,68,120,118,200,132,4,54,195,12,182,243,193,234,149,178,252,0,80,199,104,241,250,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateReadSearchParamsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("17049883-ca19-4ccd-9014-0ab4fd2822d9"),
				Name = "ReadSearchParams",
				CreatedInSchemaUId = new Guid("dde01b43-31dc-47b2-b249-b8562a9ff203"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,80,65,78,195,48,16,60,199,175,240,209,185,248,3,161,72,52,80,20,9,16,34,148,251,202,222,54,150,154,117,101,111,131,34,212,191,227,212,128,72,219,211,74,59,179,51,59,51,64,144,17,33,152,238,21,2,244,200,24,162,92,72,194,79,249,228,34,223,68,14,142,182,183,170,172,68,123,73,59,191,172,196,48,233,153,14,123,72,240,58,98,168,61,17,26,118,158,244,3,177,227,177,61,161,207,64,176,197,160,31,145,27,138,12,100,112,57,174,27,171,50,220,216,100,152,249,18,243,88,252,232,234,58,32,48,102,80,205,45,210,145,219,72,149,47,244,10,217,116,171,224,251,251,165,122,67,227,131,77,178,165,252,18,197,112,153,250,37,141,41,82,123,109,13,113,214,70,37,138,141,79,95,152,78,170,73,106,255,159,45,29,93,213,62,25,23,231,141,233,59,107,127,255,77,93,188,143,123,180,181,223,29,122,250,128,221,1,255,250,159,89,148,41,103,113,44,196,241,27,227,5,10,54,190,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SearchForDuplicatesSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dde01b43-31dc-47b2-b249-b8562a9ff203"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new SearchForDuplicates(userConnection) {
				SchemaUId = new Guid("dde01b43-31dc-47b2-b249-b8562a9ff203")
			};
		}

		#endregion

	}

	#endregion

	#region Class: SearchForDuplicates

	[DesignModeProperty(Name = "SchemaId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "dde01b4331dc47b2b249b8562a9ff203", CaptionResourceItem = "Parameters.SchemaId.Caption", DescriptionResourceItem = "Parameters.SchemaId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "DuplicateSchemaId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "dde01b4331dc47b2b249b8562a9ff203", CaptionResourceItem = "Parameters.DuplicateSchemaId.Caption", DescriptionResourceItem = "Parameters.DuplicateSchemaId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "EditPageId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "dde01b4331dc47b2b249b8562a9ff203", CaptionResourceItem = "Parameters.EditPageId.Caption", DescriptionResourceItem = "Parameters.EditPageId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "RecordId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "dde01b4331dc47b2b249b8562a9ff203", CaptionResourceItem = "Parameters.RecordId.Caption", DescriptionResourceItem = "Parameters.RecordId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ContactSchemaId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "dde01b4331dc47b2b249b8562a9ff203", CaptionResourceItem = "Parameters.ContactSchemaId.Caption", DescriptionResourceItem = "Parameters.ContactSchemaId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "AccountSchemaId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "dde01b4331dc47b2b249b8562a9ff203", CaptionResourceItem = "Parameters.AccountSchemaId.Caption", DescriptionResourceItem = "Parameters.AccountSchemaId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Duplicates", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "dde01b4331dc47b2b249b8562a9ff203", CaptionResourceItem = "Parameters.Duplicates.Caption", DescriptionResourceItem = "Parameters.Duplicates.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "SearchParameters", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "dde01b4331dc47b2b249b8562a9ff203", CaptionResourceItem = "Parameters.SearchParameters.Caption", DescriptionResourceItem = "Parameters.SearchParameters.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "DuplicatesFound", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "dde01b4331dc47b2b249b8562a9ff203", CaptionResourceItem = "Parameters.DuplicatesFound.Caption", DescriptionResourceItem = "Parameters.DuplicatesFound.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "IdConstraints", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "dde01b4331dc47b2b249b8562a9ff203", CaptionResourceItem = "Parameters.IdConstraints.Caption", DescriptionResourceItem = "Parameters.IdConstraints.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ReadSearchParameters", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "dde01b4331dc47b2b249b8562a9ff203", CaptionResourceItem = "Parameters.ReadSearchParameters.Caption", DescriptionResourceItem = "Parameters.ReadSearchParameters.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "SearchParameterNames", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "dde01b4331dc47b2b249b8562a9ff203", CaptionResourceItem = "Parameters.SearchParameterNames.Caption", DescriptionResourceItem = "Parameters.SearchParameterNames.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "InsertResults", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "dde01b4331dc47b2b249b8562a9ff203", CaptionResourceItem = "Parameters.InsertResults.Caption", DescriptionResourceItem = "Parameters.InsertResults.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class SearchForDuplicates : ProcessUserTask
	{

		#region Constructors: Public

		public SearchForDuplicates(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("dde01b43-31dc-47b2-b249-b8562a9ff203");
		}

		#endregion

		#region Properties: Public

		public virtual Guid SchemaId {
			get;
			set;
		}

		public virtual Guid DuplicateSchemaId {
			get;
			set;
		}

		public virtual Guid EditPageId {
			get;
			set;
		}

		public virtual Guid RecordId {
			get;
			set;
		}

		public virtual Guid ContactSchemaId {
			get;
			set;
		}

		public virtual Guid AccountSchemaId {
			get;
			set;
		}

		public virtual Object Duplicates {
			get;
			set;
		}

		public virtual Object SearchParameters {
			get;
			set;
		}

		public virtual bool DuplicatesFound {
			get;
			set;
		}

		public virtual Object IdConstraints {
			get;
			set;
		}

		public virtual bool ReadSearchParameters {
			get;
			set;
		}

		public virtual Object SearchParameterNames {
			get;
			set;
		}

		public virtual bool InsertResults {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			ContactSchemaId = new Guid("16BE3651-8FE2-4159-8DD0-A803D4683DD3");
			AccountSchemaId = new Guid("25D7C1AB-1DE0-4501-B402-02E0E5A72D6E");
			DuplicateSchemaId = Guid.Empty;
			EditPageId = Guid.Empty;
			if (SchemaId == ContactSchemaId) {
				DuplicateSchemaId = new Guid("AFD8D870-9C6A-4482-B90E-53682AED6618");
				EditPageId = new Guid("10E5B380-25F3-474D-8DEC-6B4084180AC7");	
			} else if (SchemaId == AccountSchemaId) {
				DuplicateSchemaId = new Guid("A477264B-2D69-48B7-9268-E9B4D39EBF83");
				EditPageId = new Guid("CE234B7B-7A81-4D01-979E-32F048901BFD");
			} else {
				return true;
			}
			var storedProc = GetStoredProcedure();
			using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				using (IDataReader dr = storedProc.ExecuteReader(dbExecutor)) {
					var result = new List<Guid>();		
					while (dr.Read()) {
						Guid entityId = UserConnection.DBTypeConverter.DBValueToGuid(dr.GetValue(0));
						result.Add(entityId);
					}		
					DuplicatesFound = result.Count > 0;
					Duplicates = result;
				}	
			}
			return true;
		}

		#endregion

		#region Methods: Public

		public override bool CompleteExecuting(params object[] parameters) {
			return base.CompleteExecuting(parameters);
		}

		public virtual StoredProcedure GetStoredProcedure() {
			var procName = string.Empty;
			var dataValueTypeManager = (DataValueTypeManager)UserConnection.AppManagerProvider.GetManager("DataValueTypeManager");
			var guidDataValueType = (GuidDataValueType)dataValueTypeManager.GetInstanceByName("Guid");
			var textDataValueType = (TextDataValueType)dataValueTypeManager.GetInstanceByName("Text");
			var booleanDataValueType = (BooleanDataValueType)dataValueTypeManager.GetInstanceByName("Boolean");
			var dateTimeDataValueType = (DateTimeDataValueType)dataValueTypeManager.GetInstanceByName("DateTime");
			if (SchemaId == AccountSchemaId) {
				procName = "tsp_SearchForAccountDuplicates";
			} else if (SchemaId == ContactSchemaId) {
				procName = "tsp_SearchForContactDuplicates";
			}
			if (ReadSearchParameters) {
				ReadSearchParams();
			}
			var storedProcedure = new StoredProcedure(UserConnection, procName);
			AddStoredProcedureParameter(storedProcedure, RecordId, guidDataValueType);
			AddStoredProcedureParameter(storedProcedure, InsertResults, booleanDataValueType);
			AddStoredProcedureParameter(storedProcedure, "false", booleanDataValueType);
			AddStoredProcedureParameter(storedProcedure, DateTime.MinValue, dateTimeDataValueType);
			AddStoredProcedureParameter(storedProcedure, GetConstraintsStr(), textDataValueType);
			var searchParameters = SearchParameters as List<string>;
			if (searchParameters != null) {
				foreach (var parameter in searchParameters) {		
					AddStoredProcedureParameter(storedProcedure, parameter, textDataValueType);
				}
			}
			return storedProcedure;
		}

		public virtual void AddStoredProcedureParameter(StoredProcedure storedProcedure, object value, DataValueType dataValueType) {
			bool isNull = false;
			if (dataValueType is TextDataValueType) {
				isNull = string.IsNullOrEmpty(value as string);
			} else if (dataValueType is GuidDataValueType) {
				isNull = ((Guid)value == Guid.Empty);
			} else {
				isNull = (value == null);
			}
			if (isNull) {
				storedProcedure.WithParameter(Column.Const(null));
			} else {
				storedProcedure.WithParameter(new QueryParameter { ValueType = dataValueType, Value = value });
			}
		}

		public virtual string GetConstraintsStr() {
			var idConstraints = IdConstraints as List<Guid>;
			string constraintList = string.Empty;
			if ((idConstraints != null) && (idConstraints.Count > 0)) {	
				foreach (var id in idConstraints) {
					constraintList += id.ToString("D");
				}
			}
			return constraintList;
		}

		public virtual void ReadSearchParams() {
			var searchParameters = new List<string>();
			SearchParameters = searchParameters;
			var schema = UserConnection.EntitySchemaManager.GetInstanceByUId(SchemaId);
			Entity entity = schema.CreateEntity(UserConnection);
			if (entity.FetchFromDB(RecordId)) {
				var searchParameterNames = SearchParameterNames as List<string>;
				foreach (var parameterName in searchParameterNames) {
					searchParameters.Add(entity.GetTypedColumnValue<string>(parameterName));
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
			if (!HasMapping("SchemaId")) {
				writer.WriteValue("SchemaId", SchemaId, Guid.Empty);
			}
			if (!HasMapping("DuplicateSchemaId")) {
				writer.WriteValue("DuplicateSchemaId", DuplicateSchemaId, Guid.Empty);
			}
			if (!HasMapping("EditPageId")) {
				writer.WriteValue("EditPageId", EditPageId, Guid.Empty);
			}
			if (!HasMapping("RecordId")) {
				writer.WriteValue("RecordId", RecordId, Guid.Empty);
			}
			if (!HasMapping("ContactSchemaId")) {
				writer.WriteValue("ContactSchemaId", ContactSchemaId, Guid.Empty);
			}
			if (!HasMapping("AccountSchemaId")) {
				writer.WriteValue("AccountSchemaId", AccountSchemaId, Guid.Empty);
			}
			if (Duplicates != null) {
				if (Duplicates.GetType().IsSerializable || Duplicates.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("Duplicates", Duplicates, null);
				}
			}
			if (SearchParameters != null) {
				if (SearchParameters.GetType().IsSerializable || SearchParameters.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("SearchParameters", SearchParameters, null);
				}
			}
			if (!HasMapping("DuplicatesFound")) {
				writer.WriteValue("DuplicatesFound", DuplicatesFound, false);
			}
			if (IdConstraints != null) {
				if (IdConstraints.GetType().IsSerializable || IdConstraints.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("IdConstraints", IdConstraints, null);
				}
			}
			if (!HasMapping("ReadSearchParameters")) {
				writer.WriteValue("ReadSearchParameters", ReadSearchParameters, false);
			}
			if (SearchParameterNames != null) {
				if (SearchParameterNames.GetType().IsSerializable || SearchParameterNames.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("SearchParameterNames", SearchParameterNames, null);
				}
			}
			if (!HasMapping("InsertResults")) {
				writer.WriteValue("InsertResults", InsertResults, false);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "SchemaId":
					SchemaId = reader.GetGuidValue();
				break;
				case "DuplicateSchemaId":
					DuplicateSchemaId = reader.GetGuidValue();
				break;
				case "EditPageId":
					EditPageId = reader.GetGuidValue();
				break;
				case "RecordId":
					RecordId = reader.GetGuidValue();
				break;
				case "ContactSchemaId":
					ContactSchemaId = reader.GetGuidValue();
				break;
				case "AccountSchemaId":
					AccountSchemaId = reader.GetGuidValue();
				break;
				case "Duplicates":
					Duplicates = reader.GetSerializableObjectValue();
				break;
				case "SearchParameters":
					SearchParameters = reader.GetSerializableObjectValue();
				break;
				case "DuplicatesFound":
					DuplicatesFound = reader.GetBoolValue();
				break;
				case "IdConstraints":
					IdConstraints = reader.GetSerializableObjectValue();
				break;
				case "ReadSearchParameters":
					ReadSearchParameters = reader.GetBoolValue();
				break;
				case "SearchParameterNames":
					SearchParameterNames = reader.GetSerializableObjectValue();
				break;
				case "InsertResults":
					InsertResults = reader.GetBoolValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

