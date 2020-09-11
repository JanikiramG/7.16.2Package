namespace Terrasoft.Core.Process.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using System.Text.RegularExpressions;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.UI.WebControls.Controls;

	#region Class: ReadDataIntoEntityCollectionItemsUserTaskSchema

	/// <exclude/>
	public class ReadDataIntoEntityCollectionItemsUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public ReadDataIntoEntityCollectionItemsUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public ReadDataIntoEntityCollectionItemsUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602");
			RealUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602");
			Name = "ReadDataIntoEntityCollectionItemsUserTask";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,87,203,118,219,54,16,93,75,95,129,234,116,65,213,44,143,179,173,44,37,245,43,85,235,56,142,31,221,196,89,192,212,200,66,67,129,42,0,214,102,27,255,123,7,0,37,128,32,104,167,143,156,147,133,48,175,59,51,23,151,240,155,17,91,146,68,42,193,248,125,54,151,231,85,81,188,23,39,235,141,170,147,75,144,85,161,78,184,98,170,190,202,87,176,166,23,162,204,65,202,99,170,232,120,76,254,26,14,212,74,148,15,132,195,3,241,2,79,30,115,216,40,86,242,100,52,122,54,199,104,52,158,12,159,134,26,128,245,56,42,139,2,114,29,74,166,83,194,49,37,249,242,133,132,182,236,168,172,184,210,30,251,6,132,0,85,9,78,148,168,64,167,243,139,189,163,156,222,131,32,16,57,155,146,27,9,226,168,228,188,73,27,9,156,12,255,160,130,108,28,100,140,250,89,162,239,49,96,44,163,5,251,19,14,122,186,155,189,48,192,73,11,41,217,80,129,40,155,31,211,24,226,236,45,168,57,151,138,242,28,14,235,155,249,34,241,128,101,23,94,60,218,194,244,162,131,165,167,200,105,41,114,192,74,246,212,47,49,182,211,144,198,240,161,2,81,207,249,178,196,52,122,255,199,204,12,145,138,186,53,143,212,55,88,150,165,125,190,184,225,106,205,83,98,221,102,179,89,210,84,20,112,15,143,214,122,78,215,128,157,74,179,63,93,247,82,219,146,55,163,209,237,199,228,245,193,53,189,43,64,251,204,62,222,62,220,126,255,105,111,252,3,158,186,80,119,252,26,207,47,4,91,35,136,142,249,187,241,237,167,111,13,57,151,165,0,154,175,72,242,11,212,191,210,162,194,218,76,28,188,173,216,98,7,147,72,208,188,132,133,77,99,72,194,56,233,91,141,245,122,7,138,94,80,181,50,252,181,137,154,185,182,237,216,100,55,125,102,144,76,162,129,77,144,79,166,108,183,76,231,114,88,111,43,36,177,178,99,151,28,103,236,7,235,41,97,254,43,99,188,81,172,96,138,129,204,142,10,160,252,102,227,124,146,16,148,78,217,93,118,132,150,141,97,26,49,101,214,38,117,71,135,181,41,19,129,215,83,41,223,230,61,101,124,113,202,132,84,103,101,249,185,218,248,78,222,88,252,9,166,209,221,164,195,193,32,202,76,13,64,107,218,182,162,85,50,179,234,65,94,34,50,110,182,247,212,134,217,186,140,8,211,70,103,151,176,4,68,146,131,53,184,197,104,106,178,123,222,225,176,11,181,103,134,44,218,224,66,173,29,69,194,249,226,143,236,186,180,107,77,76,3,168,176,56,40,120,212,20,140,116,159,205,181,241,253,50,217,37,243,72,35,52,232,24,223,251,146,93,85,119,54,52,177,53,247,28,198,236,12,248,61,70,238,145,87,94,5,144,191,183,8,239,15,239,5,194,247,130,211,233,255,189,90,53,141,93,66,65,181,187,108,72,240,77,32,151,217,181,168,17,159,217,74,2,45,165,44,43,21,38,177,95,217,65,112,218,149,220,127,136,213,108,120,16,34,251,113,177,8,16,133,104,44,107,191,174,72,107,37,205,197,109,207,100,151,183,53,147,62,94,219,249,68,146,54,51,138,88,158,255,52,5,120,253,153,56,100,122,38,253,136,98,104,236,140,34,22,147,171,79,239,210,54,163,205,187,200,127,62,120,175,159,157,66,116,115,77,204,91,42,220,107,240,92,138,167,197,124,225,209,164,243,180,186,43,203,130,48,121,94,162,118,210,5,44,122,83,217,0,173,33,168,163,56,42,5,66,54,247,120,74,94,237,239,239,247,125,90,255,183,183,67,248,76,153,43,88,235,239,114,112,108,38,242,156,12,71,210,100,136,24,103,227,222,66,254,197,140,249,111,191,215,241,150,255,155,206,184,158,220,53,181,154,97,133,114,19,249,62,132,98,217,97,118,115,23,94,252,208,180,11,55,115,49,131,113,107,111,46,225,25,147,234,160,188,251,13,41,50,75,66,82,152,114,94,255,214,47,181,65,118,24,216,248,138,202,149,121,224,97,74,68,253,211,246,231,51,23,20,181,254,101,190,154,234,154,171,159,161,150,205,101,113,197,116,87,210,222,33,237,183,219,161,197,232,26,53,11,213,219,104,71,218,101,12,92,199,70,6,218,81,6,128,81,70,207,109,119,107,59,55,8,255,36,138,249,237,208,55,37,191,86,167,183,15,204,80,58,131,229,110,73,140,255,58,23,30,181,43,34,2,184,163,147,171,15,161,33,233,48,178,173,163,169,41,49,208,155,139,34,75,189,230,237,224,252,225,234,135,168,72,154,115,189,116,239,17,36,99,165,119,219,74,99,93,164,113,12,54,63,202,188,254,255,132,194,232,235,228,232,111,110,46,32,172,83,15,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateEntityCollectionParameter());
			Parameters.Add(CreateResultEntitySchemaProcessDataParameter());
			Parameters.Add(CreateResultEntityCollectionParameter());
		}

		protected virtual ProcessSchemaParameter CreateEntityCollectionParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("49027490-8fdb-465a-a97b-d618b1a9701c"),
				Name = "EntityCollection",
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateResultEntitySchemaProcessDataParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("4ea466b9-7dad-4e7f-84f2-e0e3c288734b"),
				Name = "ResultEntitySchemaProcessData",
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateResultEntityCollectionParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("0bf60687-1cd6-4a2d-8f50-ae9ca1e1c473"),
				Name = "ResultEntityCollection",
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType"),
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
			Methods.Add(CreateCancelExecutingMethod());
			Methods.Add(CreateGetESQEntityCollectionMethod());
			Methods.Add(CreateLoadColumnValuesMethod());
			Methods.Add(CreateGetHashTableMethod());
			Methods.Add(CreateFindFirstLookupSchemaColumnByMetaPathMethod());
			Methods.Add(CreateCopyColumnValuesMethod());
			Methods.Add(CreateCopyColumnValueMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("67b185f3-96a2-4531-a1a8-59234d214d08"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e9483095-890b-4b0b-91d6-1e7712cbe699"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("481640ab-7ba3-4747-b33a-e762be1894a8"),
				Name = "System.Text.RegularExpressions",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("164b23d8-3ce7-420c-9df6-caf96f444f77"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("622eb23d-af5e-4405-8ff2-a82288320504"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				ModifiedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4648a1f8-885f-4e77-bc3a-12deccc99463"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				ModifiedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,113,47,205,76,209,81,40,46,41,202,204,75,183,211,208,180,6,0,179,24,102,192,38,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f7e87509-4e94-4394-835a-117c2dabb081"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8937adba-5950-43d0-b1a2-68ad18330286"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				ModifiedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,74,44,78,213,115,206,207,45,200,73,45,73,117,173,72,77,46,45,201,204,75,215,40,72,44,74,204,5,138,20,21,107,90,3,0,145,9,166,203,42,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCancelExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("030471a5-056d-493a-a411-31907b9dd036"),
				Name = "CancelExecuting",
				CreatedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e50d5cbe-9ead-40cf-a1c1-6cc4bd7b583a"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				ModifiedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,115,78,204,75,78,205,113,173,72,77,46,45,201,204,75,215,40,72,44,74,204,77,45,73,45,42,214,180,6,0,4,172,171,3,33,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetESQEntityCollectionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("151e0c29-26f5-4d09-882d-719a8d729fe8"),
				Name = "GetESQEntityCollection",
				CreatedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "EntityCollection"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("7632395b-fa44-491e-9c9b-1695a3fd1bda"),
				Name = "primaryColumnName",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("1fd7ba96-a4f7-42fd-86cf-d4cb14157691"),
				Name = "entitySchema",
				CreatedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				ModifiedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntitySchema",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("36234985-201f-4dad-872b-3316c1093a77"),
				Name = "selectedSchemaColumns",
				CreatedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				ModifiedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ref Dictionary<EntitySchemaColumn, string>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("90f683e4-41fe-48a0-b6c4-5ccd77f0f0e3"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				ModifiedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "List<object>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,82,209,106,195,48,12,124,94,191,194,143,9,148,252,64,182,65,73,187,81,6,163,219,186,238,217,75,212,70,224,56,169,100,119,132,177,127,159,18,151,46,3,211,71,75,119,231,211,73,39,77,10,248,168,238,148,133,47,181,178,14,93,255,86,214,208,232,23,15,212,39,48,169,164,249,76,160,217,59,195,162,106,208,190,226,161,118,44,204,189,54,12,161,183,33,108,52,245,35,183,104,141,111,108,182,230,29,50,126,26,16,164,35,47,192,147,252,201,163,98,128,60,235,6,182,8,124,54,177,196,210,97,107,69,230,118,234,39,96,231,138,29,161,61,220,39,12,6,74,7,213,180,203,89,209,122,235,196,232,190,37,208,101,173,146,39,232,119,218,120,216,104,164,107,122,42,166,167,208,70,235,156,170,239,217,77,96,170,114,58,132,204,48,228,176,168,170,128,140,218,204,70,71,105,54,112,114,209,137,100,49,40,196,185,50,208,252,255,159,50,238,207,152,254,3,26,7,20,184,195,187,144,12,28,132,234,7,186,122,163,73,24,3,36,9,197,162,109,58,77,200,173,221,246,29,100,171,163,215,102,174,186,176,196,63,67,82,186,48,211,243,21,172,15,86,34,94,34,119,70,135,132,249,178,224,104,100,210,141,13,154,207,8,156,39,59,198,246,8,46,172,72,48,131,132,156,65,34,231,38,62,173,13,207,52,255,5,162,87,85,124,178,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateLoadColumnValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4c4b6b4d-a456-451c-a38b-a15fa708d774"),
				Name = "LoadColumnValues",
				CreatedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("621cd1b1-d655-421b-8eb1-110e2c68590f"),
				Name = "esqColumnValueName",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f0244eef-1511-4bdf-b798-4152bad571da"),
				Name = "hashTable",
				CreatedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				ModifiedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<object, List<Entity>>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("bc33f8f4-09f7-4f29-94de-a2245c0b197a"),
				Name = "esqEntityCollection",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntityCollection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("85a26027-0876-40bd-aa58-7a6262afcfa6"),
				Name = "selectedSchemaColumns",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<EntitySchemaColumn, string>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,83,93,111,155,48,20,125,134,95,225,167,42,145,34,255,129,44,145,214,143,77,209,210,170,82,210,190,187,112,91,188,57,56,197,118,39,52,241,223,107,27,8,6,108,210,77,93,164,68,49,215,247,156,115,207,185,188,145,2,29,136,76,178,29,48,72,36,164,187,36,131,3,185,226,76,29,114,129,86,40,135,223,232,154,38,146,242,156,20,229,151,155,92,82,89,186,151,22,104,252,108,61,19,62,56,124,197,85,46,231,203,216,237,64,32,94,123,231,85,247,68,247,25,24,205,141,235,226,50,126,230,5,144,36,67,179,31,80,62,18,166,224,158,208,194,43,75,200,130,230,47,107,228,147,130,104,238,125,46,230,232,79,28,133,13,193,95,211,212,59,27,214,114,22,195,81,112,219,245,29,228,101,121,71,14,224,239,181,115,204,181,47,85,55,94,141,211,33,26,197,30,95,172,94,254,244,83,159,76,217,34,185,14,26,234,154,197,150,102,186,224,28,141,36,77,27,109,169,144,141,135,107,84,128,80,76,218,19,5,161,171,244,25,205,50,34,178,61,121,98,128,247,69,169,49,79,104,246,207,2,113,37,7,141,115,43,45,26,14,228,92,178,51,13,154,108,79,244,241,144,61,187,23,222,103,195,23,206,182,225,142,198,144,61,209,189,194,42,140,103,54,98,105,1,187,120,78,233,181,1,76,69,21,70,182,117,236,201,81,127,76,88,126,38,253,46,43,198,218,41,163,241,13,119,202,190,70,183,130,191,241,34,1,173,117,116,113,66,177,246,34,160,215,10,14,48,227,214,229,129,244,232,220,253,96,96,13,103,21,79,194,180,99,27,210,166,35,225,250,86,174,160,62,214,253,61,87,182,156,164,255,236,197,194,187,28,78,162,161,121,240,70,108,57,255,165,142,251,242,8,232,226,194,217,166,141,112,160,140,58,72,207,174,212,53,21,71,70,202,97,82,39,227,63,123,133,3,124,203,113,60,127,233,175,31,120,210,230,10,1,19,128,206,184,125,171,11,180,179,252,191,57,179,227,74,191,101,117,225,97,147,126,190,67,211,4,211,78,197,205,143,254,86,113,245,14,197,35,146,44,67,8,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetHashTableMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("bab4264f-6650-47ea-9ee8-06c6f8eaa40d"),
				Name = "GetHashTable",
				CreatedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Dictionary<object, List<Entity>>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("fc14fdbc-670c-4d91-aa9c-18908dc91a9f"),
				Name = "columnValueName",
				CreatedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				ModifiedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("101ef30f-4331-4fa8-8149-b09f53190fb3"),
				Name = "isNotLoadedResultEntityCollection",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ref bool",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,83,203,110,194,48,16,60,219,95,177,189,37,18,10,247,6,168,42,168,122,65,28,10,237,221,36,27,197,149,177,43,63,168,162,42,255,94,131,3,56,16,196,209,187,179,227,153,89,123,207,52,160,180,220,54,115,37,4,22,150,43,9,83,224,102,165,236,82,177,18,203,15,52,78,216,183,107,204,11,220,148,158,97,24,155,211,189,191,165,102,166,222,176,173,64,79,47,241,23,22,252,216,100,186,153,168,237,183,71,142,96,201,141,157,132,233,217,44,73,115,90,41,141,172,168,33,9,197,78,41,112,121,163,57,133,63,74,58,148,142,84,228,148,240,10,146,135,126,142,243,36,158,236,100,134,67,242,105,80,207,149,148,49,154,172,139,26,119,204,3,135,57,179,208,247,200,214,203,32,227,113,76,159,173,209,46,176,242,104,183,147,95,76,56,52,7,199,132,204,213,79,211,171,6,171,163,158,173,35,242,206,173,175,101,153,92,99,91,64,97,112,200,35,158,98,106,41,137,243,15,13,142,198,183,194,126,160,184,168,242,131,61,51,239,104,35,205,73,132,92,177,29,166,221,22,122,4,62,94,39,68,72,178,80,158,70,58,12,50,14,208,167,243,115,201,54,186,241,244,55,196,35,80,206,158,85,166,129,232,116,236,150,23,27,10,233,94,104,15,49,245,232,206,84,65,197,233,56,148,103,75,31,127,144,41,84,204,103,158,83,141,214,105,121,121,255,249,63,70,158,95,119,116,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFindFirstLookupSchemaColumnByMetaPathMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9310027e-643c-463d-a62e-e336470c8cf8"),
				Name = "FindFirstLookupSchemaColumnByMetaPath",
				CreatedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "EntitySchemaColumn"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("48a51482-139b-4a19-afd9-c106894519c4"),
				Name = "entitySchema",
				CreatedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				ModifiedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntitySchema",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("65ed4df6-354f-4e36-95d7-347d239be349"),
				Name = "columnMetaPath",
				CreatedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				ModifiedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("43c43558-e08c-4b81-95a2-3c48f7b096fb"),
				Name = "regexColumnNameParser",
				CreatedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				ModifiedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Regex",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,83,203,110,219,48,16,60,83,95,65,232,18,9,73,137,246,172,250,208,10,134,107,192,78,130,218,233,197,240,129,166,215,18,27,137,20,248,112,226,22,254,247,146,148,99,61,210,75,46,146,168,157,217,157,217,93,242,3,78,180,81,92,20,100,174,239,109,85,61,168,105,221,152,83,194,100,101,107,177,4,67,31,169,41,211,20,255,141,144,41,149,124,193,2,94,240,55,85,216,26,132,233,49,166,175,12,26,195,165,72,226,33,55,78,179,232,28,181,69,54,91,220,6,159,230,123,141,39,120,136,36,171,166,226,38,185,33,55,142,50,21,134,155,211,138,149,80,83,204,172,82,174,220,229,52,193,208,11,14,161,121,200,136,43,41,159,109,115,57,76,176,112,58,179,232,32,21,78,142,84,97,238,126,125,206,220,235,107,79,14,89,128,40,76,137,63,225,47,46,116,123,27,44,183,178,59,212,85,179,103,108,248,54,139,208,146,26,86,226,58,60,39,88,65,1,175,109,221,123,90,195,35,85,26,20,9,152,228,202,116,246,16,119,157,15,36,178,178,140,129,214,161,30,26,59,125,114,244,92,10,1,204,247,150,244,173,46,169,160,5,40,71,66,100,6,102,46,180,161,130,193,247,147,171,144,248,41,205,44,223,95,106,204,148,180,141,222,196,107,186,171,192,11,139,183,228,23,173,44,164,94,11,98,210,229,21,22,220,247,57,66,163,230,13,36,145,246,183,246,21,71,149,58,123,111,254,250,137,220,126,45,194,113,125,106,224,255,94,7,240,159,112,0,23,101,240,54,101,20,82,142,56,237,104,219,116,189,253,156,139,35,173,248,254,97,247,219,245,109,101,168,129,110,61,61,18,121,208,66,50,7,250,227,59,178,10,99,78,226,53,40,69,181,60,24,103,83,65,124,23,176,40,126,191,96,228,154,111,44,52,92,134,56,109,169,3,71,57,13,132,208,112,215,229,51,134,74,67,80,254,78,184,239,81,78,181,233,84,127,64,112,156,203,186,150,125,137,173,128,165,213,230,7,61,66,55,134,56,76,202,105,217,41,160,207,254,154,42,48,86,13,175,79,246,15,39,226,78,115,36,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCopyColumnValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ca3c6577-fffb-404b-9947-28a335b4b656"),
				Name = "CopyColumnValues",
				CreatedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2dd06e0e-b8ba-45fb-9e0c-7cf3faa4cb63"),
				Name = "sourceEntity",
				CreatedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				ModifiedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6d893e5b-0916-4520-9599-10351a109bb3"),
				Name = "targetEntity",
				CreatedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				ModifiedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,145,189,14,130,48,20,133,103,120,138,235,6,137,225,5,8,19,50,144,168,11,234,222,148,2,141,165,37,180,29,136,225,221,69,138,4,80,49,44,77,122,127,206,119,78,110,196,21,85,77,130,11,82,162,80,48,93,242,238,101,4,43,42,56,200,73,89,66,0,82,232,26,147,168,95,241,204,142,55,116,125,59,19,53,65,184,0,39,250,144,156,9,1,93,8,187,240,176,45,169,106,202,115,192,125,233,134,152,38,103,84,146,23,115,50,58,192,198,182,111,91,161,168,154,73,213,153,90,220,131,66,117,78,212,251,183,16,119,253,17,155,82,89,49,212,132,235,244,195,215,169,78,133,102,224,44,157,239,130,31,170,125,220,77,190,127,232,116,224,214,176,103,46,99,121,210,76,209,163,16,119,93,93,154,106,0,14,73,13,199,28,231,26,167,127,18,39,171,211,254,198,28,235,108,147,167,125,2,218,137,13,81,145,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCopyColumnValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("42245f00-9f6e-45ed-bf4c-cbdf5074bba6"),
				Name = "CopyColumnValue",
				CreatedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a2200e1a-7ae9-43ae-9a04-38a21760844d"),
				Name = "sourceEntity",
				CreatedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				ModifiedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("eea5bacc-6694-45b8-8c0b-06e8fe4058e8"),
				Name = "targetEntity",
				CreatedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				ModifiedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("7a89025f-60dd-4a77-91e8-206810e4ba4f"),
				Name = "columnValueName",
				CreatedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				ModifiedInSchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,145,189,10,194,48,16,199,231,228,41,110,108,65,250,2,165,147,180,34,136,139,224,30,154,83,2,105,2,249,24,68,242,238,182,17,169,122,113,113,59,238,126,252,63,184,222,4,21,110,91,171,227,100,206,66,71,4,36,155,14,188,141,110,196,62,95,154,65,25,217,127,67,213,184,206,71,49,97,221,114,117,129,170,32,214,129,137,90,215,112,231,204,97,136,206,180,60,149,217,102,239,15,86,72,148,25,46,35,84,148,145,108,16,132,187,98,160,251,238,227,210,12,118,46,185,43,128,133,114,140,253,16,125,37,202,129,102,46,1,106,143,57,24,53,59,97,120,183,161,245,22,183,13,125,201,211,100,137,145,248,106,240,119,153,244,0,227,211,184,134,6,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ReadDataIntoEntityCollectionItemsUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("18553bfd-3ef6-4691-80df-ebe71def3602"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new ReadDataIntoEntityCollectionItemsUserTask(userConnection) {
				SchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602")
			};
		}

		#endregion

	}

	#endregion

	#region Class: ReadDataIntoEntityCollectionItemsUserTask

	[DesignModeProperty(Name = "EntityCollection", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "18553bfd3ef6469180dfebe71def3602", CaptionResourceItem = "Parameters.EntityCollection.Caption", DescriptionResourceItem = "Parameters.EntityCollection.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ResultEntitySchemaProcessData", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "18553bfd3ef6469180dfebe71def3602", CaptionResourceItem = "Parameters.ResultEntitySchemaProcessData.Caption", DescriptionResourceItem = "Parameters.ResultEntitySchemaProcessData.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ResultEntityCollection", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "18553bfd3ef6469180dfebe71def3602", CaptionResourceItem = "Parameters.ResultEntityCollection.Caption", DescriptionResourceItem = "Parameters.ResultEntityCollection.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class ReadDataIntoEntityCollectionItemsUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public ReadDataIntoEntityCollectionItemsUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("18553bfd-3ef6-4691-80df-ebe71def3602");
		}

		#endregion

		#region Properties: Public

		public virtual EntityCollection EntityCollection {
			get;
			set;
		}

		public virtual string ResultEntitySchemaProcessData {
			get;
			set;
		}

		public virtual EntityCollection ResultEntityCollection {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			if (string.IsNullOrEmpty(ResultEntitySchemaProcessData)) {
				throw new NullOrEmptyException("ResultEntitySchemaProcessData");
			}
			if (EntityCollection == null || EntityCollection.Count == 0) {
				return true;
			}
			EntitySchemaManager entitySchemaManager = UserConnection.EntitySchemaManager;
			var processData = Json.Deserialize<EntitySchemaProcessData>(ResultEntitySchemaProcessData);
			EntitySchema parentSchema = entitySchemaManager.GetInstanceByUId(processData.ParentSchemaUId);
			EntitySchema resultEntitySchema = entitySchemaManager.ForceGetSchema(processData);
			var schemaQueryInfo = new Dictionary<EntitySchema, Dictionary<string, Dictionary<EntitySchemaColumn, string>>>();
			var regexColumnNameParser = new Regex(@"\[(?<TableName>[\w\-]+):(?<ColumnName>[\w\-]+):?(?<PrimaryColumnName>[\w\-]*)\]$");
			foreach (KeyValuePair<Guid, string> selectedColumnData in processData.ParentSchemaColumnMetaPath) {
				string schemaColumnMetaPath = selectedColumnData.Value;
				string schemaColumnPath = parentSchema.GetSchemaColumnPathByMetaPath(schemaColumnMetaPath);
				string newSchemaColumnName = StringUtilities.CleanUpColumnName(schemaColumnPath);
				EntitySchemaColumn resultEntitySchemaColumn = resultEntitySchema.Columns.GetByName(newSchemaColumnName);
				EntitySchemaColumn column = FindFirstLookupSchemaColumnByMetaPath(parentSchema, schemaColumnMetaPath,
					regexColumnNameParser);
				if (column == null) {
					continue;
				}
				EntitySchema entitySchema = column.ReferenceSchema;
				string foreignPrimaryColumnName = column.ColumnValueName;
				string columnUId = column.UId.ToString();
				int index = schemaColumnMetaPath.IndexOf(columnUId);
				string referSchemaColumnMetaPath = schemaColumnMetaPath.Substring(index + columnUId.Length + 1);
				string esqColumnPath = entitySchema.GetSchemaColumnPathByMetaPath(referSchemaColumnMetaPath);
				Dictionary<string, Dictionary<EntitySchemaColumn, string>> schemaRelations;
				if (!schemaQueryInfo.TryGetValue(entitySchema, out schemaRelations)) {
					schemaRelations = new Dictionary<string, Dictionary<EntitySchemaColumn, string>>();
					schemaQueryInfo.Add(entitySchema, schemaRelations);
				}
				Dictionary<EntitySchemaColumn, string> entitySchemaColumns;
				if (!schemaRelations.TryGetValue(foreignPrimaryColumnName, out entitySchemaColumns)) {
					entitySchemaColumns = new Dictionary<EntitySchemaColumn, string>();
					schemaRelations.Add(foreignPrimaryColumnName, entitySchemaColumns);
				}
				entitySchemaColumns.Add(resultEntitySchemaColumn, esqColumnPath);
			}
			ResultEntityCollection.Schema = resultEntitySchema;
			if (schemaQueryInfo.Count == 0) {
				ResultEntityCollection = EntityCollection;
				return true;
			}
			bool isNotLoadedResultEntityCollection = true;
			int parametersLength = 1000;
			foreach (KeyValuePair<EntitySchema, Dictionary<string, Dictionary<EntitySchemaColumn, string>>> schemaQueryInfoItem in schemaQueryInfo) {
				EntitySchema entitySchema = schemaQueryInfoItem.Key;
				var schemaRelations = schemaQueryInfoItem.Value;
				foreach (KeyValuePair<string, Dictionary<EntitySchemaColumn, string>> schemaRelation in schemaRelations) {
					string primaryColumnName = entitySchema.GetPrimaryColumnName();
					string foreignPrimaryColumnName = schemaRelation.Key;
					var parameters = new List<object>(parametersLength);
					Dictionary<object, List<Entity>> hashTable = GetHashTable(foreignPrimaryColumnName, ref isNotLoadedResultEntityCollection);
					int keysCount = hashTable.Keys.Count;
					foreach (object parameterValue in hashTable.Keys) {
						parameters.Add(parameterValue);
						if (parameters.Count == parametersLength || parameters.Count == keysCount) {
							Dictionary<EntitySchemaColumn, string> selectedSchemaColumns = schemaRelation.Value;
							EntityCollection esqEntityCollection = GetESQEntityCollection(primaryColumnName, entitySchema,
								ref selectedSchemaColumns, parameters);
							parameters.Clear();
							LoadColumnValues(primaryColumnName, hashTable, esqEntityCollection, selectedSchemaColumns);
						}
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

		public virtual EntityCollection GetESQEntityCollection(string primaryColumnName, EntitySchema entitySchema, ref Dictionary<EntitySchemaColumn, string> selectedSchemaColumns, List<object> parameters) {
			var esq = new EntitySchemaQuery(entitySchema);
			esq.UseAdminRights = false;
			esq.PrimaryQueryColumn.IsVisible = true;
			var schemaColumnNameTies = new Dictionary<EntitySchemaColumn, string>(selectedSchemaColumns.Count);
			foreach (KeyValuePair<EntitySchemaColumn, string> selectedSchemaColumn in selectedSchemaColumns) {
				string columnNameTie = esq.AddColumn(selectedSchemaColumn.Value).Name;
				schemaColumnNameTies.Add(selectedSchemaColumn.Key, columnNameTie);
			}
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, primaryColumnName, parameters));
			esq.IgnoreDisplayValues = true;
			selectedSchemaColumns = schemaColumnNameTies;
			return esq.GetEntityCollection(UserConnection);
		}

		public virtual void LoadColumnValues(string esqColumnValueName, Dictionary<object, List<Entity>> hashTable, EntityCollection esqEntityCollection, Dictionary<EntitySchemaColumn, string> selectedSchemaColumns) {
			var matchSelectedSchemaColumns = new Dictionary<EntitySchemaColumn, EntitySchemaColumn>(selectedSchemaColumns.Count);
			EntitySchema esqEntitySchema = esqEntityCollection.Schema;
			foreach (KeyValuePair<EntitySchemaColumn, string> selectedSchemaColumn in selectedSchemaColumns) {
				matchSelectedSchemaColumns.Add(selectedSchemaColumn.Key, esqEntitySchema.Columns.GetByName(selectedSchemaColumn.Value));
			}
			foreach (Entity esqEntity in esqEntityCollection) {
				object esqValue = esqEntity.GetColumnValue(esqColumnValueName);
				List<Entity> resultEntities;
				if (hashTable.TryGetValue(esqValue, out resultEntities)) {
					foreach (Entity resultEntity in resultEntities) {
						foreach (KeyValuePair<EntitySchemaColumn, EntitySchemaColumn> matchSelectedSchemaColumn in matchSelectedSchemaColumns) {
							EntitySchemaColumn resultEntitySchemaColumn = matchSelectedSchemaColumn.Key;
							object esqEntityColumnValue = esqEntity.GetColumnValue(matchSelectedSchemaColumn.Value.ColumnValueName);
							if (esqEntityColumnValue == null) {
								EntityColumnValue resultEntityColumnValue = resultEntity.ForceGetEntityColumnValue(matchSelectedSchemaColumn.Key.ColumnValueName);
								if (resultEntityColumnValue.Column == null) {
									resultEntityColumnValue.Column = resultEntitySchemaColumn;
								}
								resultEntityColumnValue.Value = null;
								continue;
							}
							resultEntity.LoadColumnValue(matchSelectedSchemaColumn.Key.ColumnValueName, esqEntityColumnValue);
							if (resultEntitySchemaColumn.IsLookupType && esqEntity.IsColumnValueLoaded(matchSelectedSchemaColumn.Value.DisplayColumnValueName)) {
								esqEntityColumnValue = esqEntity.GetColumnValue(matchSelectedSchemaColumn.Value.DisplayColumnValueName);
								resultEntity.LoadColumnValue(matchSelectedSchemaColumn.Key.DisplayColumnValueName, esqEntityColumnValue);
							} else if (resultEntitySchemaColumn.IsMultiLookupType) {
								esqEntityColumnValue = esqEntity.GetColumnValue(matchSelectedSchemaColumn.Value.SourceSchemaUIdColumnValueName);
								resultEntity.LoadColumnValue(matchSelectedSchemaColumn.Key.SourceSchemaUIdColumnValueName, esqEntityColumnValue);
							}
						}
					}
				}
			}
		}

		public virtual Dictionary<object, List<Entity>> GetHashTable(string columnValueName, ref bool isNotLoadedResultEntityCollection) {
			var entityCollection = isNotLoadedResultEntityCollection ? EntityCollection : ResultEntityCollection;
			var hashTable = new Dictionary<object, List<Entity>>();
			foreach (Entity entity in entityCollection) {
				Entity resultEntity;
				if (isNotLoadedResultEntityCollection) {
					resultEntity = new Entity(UserConnection) {
						Schema = ResultEntityCollection.Schema
					};
					//resultEntity.SetDefColumnValues();
					CopyColumnValues(entity, resultEntity);
					ResultEntityCollection.Add(resultEntity);
				} else {
					resultEntity = entity;
				}
				List<Entity> entities;
				object columnValue = resultEntity.GetColumnValue(columnValueName);
				if (columnValue == null) {
					continue;
				}
				if (!hashTable.TryGetValue(columnValue, out entities)) {
					entities = new List<Entity>();
					hashTable.Add(columnValue, entities);
				}
				entities.Add(resultEntity);
			}
			isNotLoadedResultEntityCollection = false;
			return hashTable;
		}

		public virtual EntitySchemaColumn FindFirstLookupSchemaColumnByMetaPath(EntitySchema entitySchema, string columnMetaPath, Regex regexColumnNameParser) {
			if (string.IsNullOrEmpty(columnMetaPath)) {
				throw new ArgumentNullOrEmptyException("columnMetaPath");
			}
			string[] columnUIds = columnMetaPath.Split('.');
			EntitySchema currentSchema = entitySchema;
			EntitySchemaColumn lookupColumn = null;
			for (var i = 0; i < columnUIds.Length - 1; i++) {
				string columnUId = columnUIds[i];
				Match match = regexColumnNameParser.Match(columnUId);
				if (match.Success) {
					currentSchema = UserConnection.EntitySchemaManager
						.GetInstanceByUId(new Guid(match.Groups["TableName"].Value));
					continue;
				}
				lookupColumn = currentSchema.Columns.GetByUId(new Guid(columnUId));
				if (lookupColumn.IsLookupType) {
					currentSchema = lookupColumn.ReferenceSchema;
					if (currentSchema == null) {
						throw new InvalidObjectStateException(
							new LocalizableString("Terrasoft.Core",
								"EntitySchemaColumn.Exception.ReferenceSchemaEmpty"),
							lookupColumn.Caption);
					}
				} else {
					throw new InvalidTypeCastException(new LocalizableString("Terrasoft.Core",
						"Common.Exception.ColumnMustHaveLookupType"));
				}
				break;
			}
			return lookupColumn;
		}

		public virtual void CopyColumnValues(Entity sourceEntity, Entity targetEntity) {
			EntitySchemaColumnCollection schemaColumns = sourceEntity.Schema.Columns;
			foreach (EntitySchemaColumn schemaColumn in schemaColumns) {
				string columnValueName = schemaColumn.ColumnValueName;
				CopyColumnValue(sourceEntity, targetEntity, columnValueName);
				string displayColumnValueName = schemaColumn.DisplayColumnValueName;
				if (columnValueName != displayColumnValueName) {
					CopyColumnValue(sourceEntity, targetEntity, displayColumnValueName);
				}
				if (schemaColumn.IsMultiLookupType) {
					string sourceSchemaUIdColumnValueName = schemaColumn.SourceSchemaUIdColumnValueName;
					CopyColumnValue(sourceEntity, targetEntity, sourceSchemaUIdColumnValueName);
				}
			}
		}

		public virtual void CopyColumnValue(Entity sourceEntity, Entity targetEntity, string columnValueName) {
			EntityColumnValue entityColumnValue = sourceEntity.FindEntityColumnValue(columnValueName);
			if (entityColumnValue == null) {
				return;
			}
			if (entityColumnValue.IsLoaded) {
				if (entityColumnValue.Value == null) {
					EntityColumnValue targetEntityColumnValue = targetEntity.ForceGetEntityColumnValue(columnValueName);
					targetEntityColumnValue.Value = null;
				} else {
					targetEntity.ForceSetColumnValue(entityColumnValue.Name, entityColumnValue.Value);
				}
			} else {
				targetEntity.ForceGetEntityColumnValue(columnValueName);
			}
		}

		public override void WritePropertiesData(DataWriter writer) {
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer);
			if (Status == Core.Process.ProcessStatus.Inactive) {
				writer.WriteFinishObject();
				return;
			}
			if (!HasMapping("ResultEntitySchemaProcessData")) {
				writer.WriteValue("ResultEntitySchemaProcessData", ResultEntitySchemaProcessData, null);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "ResultEntitySchemaProcessData":
					ResultEntitySchemaProcessData = reader.GetStringValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

