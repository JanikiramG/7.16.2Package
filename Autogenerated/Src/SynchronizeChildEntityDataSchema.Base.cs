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

	#region Class: SynchronizeChildEntityDataSchema

	/// <exclude/>
	public class SynchronizeChildEntityDataSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public SynchronizeChildEntityDataSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public SynchronizeChildEntityDataSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa");
			RealUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa");
			Name = "SynchronizeChildEntityData";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,146,65,79,195,48,12,133,207,237,175,8,59,109,210,20,113,31,155,144,182,49,113,216,133,50,238,161,245,104,80,234,84,137,3,20,212,255,78,210,150,81,85,5,105,66,226,232,23,219,239,179,242,174,39,242,200,166,235,92,170,108,139,36,169,74,210,28,10,113,184,205,216,197,146,237,156,204,248,182,40,169,154,177,143,56,122,17,134,21,162,44,37,62,173,181,83,5,90,182,100,251,47,65,185,32,8,203,146,202,18,20,220,43,10,82,146,26,45,223,1,130,145,41,223,200,70,16,166,186,138,163,176,125,126,102,183,126,124,246,93,171,213,162,165,201,64,1,121,247,27,169,8,76,192,217,12,148,255,230,57,10,167,232,65,40,7,45,77,191,62,155,165,219,222,45,183,254,44,5,119,250,53,1,97,210,252,251,230,100,252,225,15,118,247,96,140,176,250,72,126,212,0,111,162,33,193,242,126,70,24,244,11,31,22,160,13,148,128,153,215,219,190,209,92,205,89,170,145,224,141,248,193,130,89,107,196,150,108,230,109,67,22,199,175,244,28,14,41,100,242,178,137,98,148,84,152,230,70,163,124,135,211,249,211,62,209,201,39,44,174,25,40,11,195,193,189,255,26,233,231,236,47,131,45,212,48,103,158,3,157,82,179,176,112,228,189,163,93,121,216,208,17,53,161,132,198,105,208,57,103,63,90,7,239,58,174,99,3,228,12,50,50,14,22,147,79,136,141,90,232,176,3,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateChildEntitySchemaUIdParameter());
			Parameters.Add(CreateSingleRowSearchFiltersParameter());
			Parameters.Add(CreateMultiRowsSearchFiltersParameter());
			Parameters.Add(CreateMappingColumnsParameter());
			Parameters.Add(CreateDefaultValuesParameter());
			Parameters.Add(CreateRequiredAllFieldsParameter());
			Parameters.Add(CreateRequiredFieldsParameter());
			Parameters.Add(CreateDeletingFiltersParameter());
		}

		protected virtual ProcessSchemaParameter CreateChildEntitySchemaUIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("20ea1940-c145-4d77-b7b9-64cb34ec1214"),
				Name = "ChildEntitySchemaUId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateSingleRowSearchFiltersParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("9f612791-1c76-461a-bcfc-4ececc04b300"),
				Name = "SingleRowSearchFilters",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateMultiRowsSearchFiltersParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("b38bb670-fe41-4138-a531-9d8e3a828e45"),
				Name = "MultiRowsSearchFilters",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateMappingColumnsParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("f12619d3-fdee-4d14-a099-30c3d08c7756"),
				Name = "MappingColumns",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateDefaultValuesParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("5153be1a-dc81-495b-80cf-cf96ed9bfb7a"),
				Name = "DefaultValues",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateRequiredAllFieldsParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("55d0493f-d0b4-42dd-ab54-ca69711189be"),
				Name = "RequiredAllFields",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateRequiredFieldsParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("8b69a7fb-e270-47e4-9a28-5f70fa5ec98d"),
				Name = "RequiredFields",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateDeletingFiltersParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("1c096562-3d04-4dc1-b434-96f1116c87bf"),
				Name = "DeletingFilters",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
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
			Methods.Add(CreateGetDependentEntityMethod());
			Methods.Add(CreateCreateSelectMethod());
			Methods.Add(CreateCreateInsertQueryMethod());
			Methods.Add(CreateCreateParametersMethod());
			Methods.Add(CreateCreateUpdateQueryMethod());
			Methods.Add(CreateSynchronizeSingleRowMethod());
			Methods.Add(CreateSynchronizeMultiRowsMethod());
			Methods.Add(CreateSynchronizeObjectMethod());
			Methods.Add(CreateCheckValueMethod());
			Methods.Add(CreateAllowRowMethod());
			Methods.Add(CreateCreateDeleteQueryMethod());
			Methods.Add(CreateDeleteRowsMethod());
		}

		protected virtual SchemaMethod CreateGetDependentEntityMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("26f495b4-b832-4927-856e-9243151003b0"),
				Name = "GetDependentEntity",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Terrasoft.Core.Entities.EntitySchema"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8b469649-8f3c-4117-9f24-468592e9fc08"),
				Name = "dependentEntitySchemaUId",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				ModifiedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e191fd57-cddb-4df9-9dc8-029a4d3bb7c2"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				ModifiedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,45,78,45,114,206,207,203,75,77,46,201,204,207,211,115,205,43,201,44,169,12,78,206,72,205,77,244,77,204,75,76,79,45,210,115,79,45,241,204,43,46,73,204,75,78,117,170,12,245,76,209,72,73,45,72,205,75,73,205,43,65,86,13,148,208,180,6,0,245,193,17,118,85,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateSelectMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("fe050f6a-d80d-4744-a8e5-a734cfdc5e47"),
				Name = "CreateSelect",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Terrasoft.Core.DB.Select"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("338644f4-70f2-4db7-8294-ea71b84a7f71"),
				Name = "entitySchema",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				ModifiedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Terrasoft.Core.Entities.EntitySchema",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6ef6d33b-1846-4647-a908-0b5c5f95efc1"),
				Name = "searchFilters",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				ModifiedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("3351da5c-730e-4902-950c-21743b9ce2a2"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				ModifiedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,82,75,79,27,49,16,62,175,127,197,148,147,87,66,86,239,219,84,2,66,16,66,66,149,66,219,67,197,193,108,102,27,23,175,77,253,104,181,170,242,223,59,126,16,8,16,229,196,94,188,182,231,155,239,49,254,35,29,12,74,7,116,30,102,224,81,186,126,189,168,123,233,97,57,249,128,163,56,179,90,99,31,148,53,94,92,160,65,167,122,49,87,249,64,186,233,19,187,136,106,117,12,246,238,23,21,125,238,24,187,65,231,164,183,67,32,164,67,49,63,21,75,76,13,136,32,47,51,214,24,252,11,251,202,120,244,232,206,172,49,133,179,21,172,105,72,66,28,13,127,13,89,68,211,211,38,154,240,198,101,65,137,19,114,225,148,191,231,109,155,154,45,156,29,57,154,160,194,180,236,215,56,74,113,45,71,108,59,166,6,224,219,52,102,96,162,214,45,252,99,141,195,16,157,169,234,59,182,97,62,56,101,126,66,159,219,39,48,133,119,116,212,189,52,126,158,56,20,250,242,83,201,138,166,138,133,194,178,67,93,220,192,135,25,124,204,236,119,214,106,80,126,161,156,167,232,32,184,136,29,107,6,34,144,253,26,120,10,31,238,113,2,101,30,71,41,174,112,242,25,219,108,105,118,252,22,13,105,152,225,116,250,122,185,226,132,39,255,143,229,213,209,97,72,61,253,38,117,196,4,74,45,146,147,170,182,72,104,158,121,251,65,168,219,100,109,155,45,125,37,87,241,125,141,14,249,147,130,86,92,250,243,223,81,234,253,131,253,34,29,21,82,227,157,254,199,53,92,49,151,65,102,109,55,211,3,182,217,96,179,1,212,30,15,51,95,147,64,94,33,217,196,118,0,131,164,6,249,162,183,148,144,201,227,200,69,7,140,86,182,19,179,122,111,151,207,77,238,101,125,114,72,218,55,244,170,119,159,249,127,78,47,207,231,27,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateInsertQueryMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("811ecea7-be25-42d2-bab5-482d7050672e"),
				Name = "CreateInsertQuery",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Terrasoft.Core.DB.Insert"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("7d7ea755-6a76-4742-8506-dd42a7db4412"),
				Name = "entitySchema",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				ModifiedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Terrasoft.Core.Entities.EntitySchema",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("dec2842d-ab40-4358-acdd-6082e8958a34"),
				Name = "values",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				ModifiedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b6049764-3af4-4511-abb2-fb143e93ca1d"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				ModifiedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,146,203,78,195,48,16,69,215,245,87,88,89,37,82,229,31,8,101,209,20,85,21,226,33,181,101,131,88,152,100,10,134,196,174,236,73,145,133,248,119,198,77,250,130,22,181,18,130,44,18,123,50,119,238,241,77,22,210,242,185,180,178,2,4,235,120,143,47,100,89,131,227,210,241,177,119,8,149,200,76,89,66,142,202,104,39,134,160,193,170,92,12,212,178,32,173,63,99,195,90,21,93,110,30,95,168,233,60,101,108,2,214,74,103,102,72,74,11,98,208,23,35,237,192,34,87,205,163,199,53,188,241,67,93,113,77,247,204,104,221,88,38,84,70,19,131,70,133,126,156,63,67,37,197,53,193,38,100,228,208,42,253,196,115,83,214,149,14,69,26,29,69,233,87,128,139,160,85,224,154,69,59,36,91,138,90,109,64,170,203,50,101,51,234,151,249,51,143,195,153,248,43,120,98,222,74,71,92,130,119,9,127,103,157,181,110,7,172,25,26,82,194,190,159,142,138,152,38,16,104,103,135,176,217,180,189,119,33,236,240,130,186,214,241,52,11,49,6,140,55,202,238,158,196,154,25,226,118,5,24,111,80,239,201,250,161,187,50,27,72,148,75,171,137,159,67,66,72,31,140,237,179,139,50,58,63,66,209,247,163,34,58,202,145,117,166,59,223,75,100,181,181,20,74,168,82,183,70,153,227,136,126,15,198,219,235,112,96,225,148,91,4,81,242,29,251,39,230,27,253,11,196,4,210,110,201,27,38,138,136,146,211,225,9,229,88,248,43,83,168,153,250,215,196,55,8,39,83,255,65,230,199,210,239,207,220,2,214,86,183,236,233,39,120,156,242,81,236,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8beb9da2-77f1-4590-9f01-73940156478d"),
				Name = "CreateParameters",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "object"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("bc4d082b-c976-4830-9d07-ca9580d3c60d"),
				Name = "context",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				ModifiedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,83,93,107,194,48,20,125,54,191,34,248,32,45,72,254,64,167,176,233,144,33,131,129,219,94,196,135,172,189,157,153,109,90,146,212,45,140,254,247,229,163,174,173,56,135,62,53,189,185,231,220,115,239,185,217,83,129,115,90,150,140,191,207,138,42,203,185,196,19,252,120,8,100,149,13,80,137,87,90,42,200,137,137,100,16,43,86,112,73,22,192,65,176,152,204,153,11,80,161,111,208,162,98,201,248,178,228,226,237,195,36,77,167,17,218,27,41,9,164,180,202,212,43,205,42,176,74,230,189,255,75,133,52,220,17,186,6,133,75,42,104,14,10,132,21,194,225,243,170,218,65,24,33,215,25,112,197,148,54,76,113,193,21,124,41,242,36,138,24,164,165,80,230,88,130,80,218,181,25,12,239,93,234,48,180,253,62,131,16,84,22,169,50,101,5,16,119,197,64,250,131,142,208,249,251,85,188,133,156,122,31,77,97,247,49,189,84,89,22,161,212,228,211,120,139,3,171,23,239,64,99,198,143,86,129,44,65,203,16,127,163,129,247,70,42,198,169,237,179,109,215,208,245,49,107,195,180,185,222,169,65,95,150,173,185,244,210,78,150,111,21,14,88,138,131,147,57,235,134,100,131,153,196,142,117,52,242,244,225,63,249,147,137,157,139,167,31,252,142,207,59,73,252,108,73,243,72,172,141,119,250,229,33,9,44,34,178,128,118,127,200,109,146,4,13,235,248,128,55,0,143,245,174,123,250,208,67,237,142,48,94,129,253,169,209,223,84,231,245,91,174,26,213,167,157,238,189,180,118,140,118,138,157,106,51,35,132,50,46,205,189,107,204,207,162,35,207,168,59,18,183,243,194,58,236,110,37,140,152,26,9,80,149,224,157,151,21,253,0,153,15,198,79,128,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateUpdateQueryMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6bc0f32b-cab2-4caa-871c-a5b6f270e904"),
				Name = "CreateUpdateQuery",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Terrasoft.Core.DB.Update"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f6e7e4b8-e1fe-488e-88d8-365b93538782"),
				Name = "entitySchema",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				ModifiedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Terrasoft.Core.Entities.EntitySchema",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("5aef680d-8bf8-4605-8de1-d2341c4e7f2e"),
				Name = "searchFilters",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				ModifiedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e41be903-4c0c-49f3-a1a1-7254e16513ea"),
				Name = "values",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				ModifiedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("79ad24d9-9820-4699-b710-b55ebe72212d"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				ModifiedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,84,77,143,211,48,16,61,199,191,98,200,41,145,42,139,123,41,18,109,119,87,21,98,65,106,203,30,16,7,111,50,161,6,215,41,254,40,138,80,255,59,227,196,109,83,104,181,93,4,185,36,118,102,222,123,243,252,146,173,48,176,17,70,172,209,161,177,48,130,173,80,30,45,8,11,243,198,58,92,243,73,173,20,22,78,214,218,242,59,212,104,100,193,167,178,221,16,166,121,197,238,188,44,7,80,63,126,165,162,215,67,182,37,192,74,170,136,102,81,152,98,117,27,215,127,13,202,22,104,140,176,117,229,168,211,32,159,142,249,114,83,10,135,224,187,219,8,52,254,128,75,85,153,183,104,38,181,214,29,229,0,80,59,233,154,121,177,194,181,224,247,52,124,78,28,214,25,169,191,64,81,43,191,214,97,147,80,211,116,248,59,247,77,232,149,104,187,135,8,50,105,155,98,111,80,227,149,26,178,138,234,69,177,130,44,140,3,223,176,1,169,123,110,243,183,216,216,28,126,178,228,208,119,34,172,3,13,6,185,113,179,156,149,25,33,144,208,228,68,97,183,136,181,31,195,225,133,23,84,213,57,195,231,232,178,99,195,224,140,71,93,43,255,176,215,149,29,21,126,34,198,207,131,61,199,84,56,209,50,44,154,13,230,164,100,199,88,143,37,125,87,151,178,146,88,142,155,89,153,94,197,196,146,229,201,201,240,137,55,134,60,8,187,84,173,157,40,220,140,130,192,32,94,151,253,9,211,245,37,164,249,159,122,207,137,125,175,255,129,84,82,16,151,196,137,11,73,82,242,163,234,107,69,147,148,51,162,25,147,21,100,241,147,162,118,175,29,188,24,193,203,54,56,143,117,173,64,218,91,105,172,163,48,56,227,195,209,159,205,221,30,225,16,186,36,224,198,222,110,227,153,57,76,174,76,98,199,20,249,219,72,133,1,194,39,18,105,247,89,125,88,161,193,94,90,115,62,179,55,223,189,80,217,21,7,212,199,191,28,89,34,219,1,42,139,79,51,223,147,192,44,182,180,67,28,108,174,4,1,68,3,200,40,221,154,222,22,61,211,192,43,253,123,194,190,56,195,27,93,254,111,239,250,214,93,100,61,250,70,142,236,232,39,97,208,121,163,227,175,122,248,11,88,4,175,77,114,6,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSynchronizeSingleRowMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2a21c22d-ad47-4fc5-8f00-304e0f4f155b"),
				Name = "SynchronizeSingleRow",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f7907533-c38c-4684-a3a4-13172eece651"),
				Name = "entitySchema",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				ModifiedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Terrasoft.Core.Entities.EntitySchema",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c16def2a-35cf-47f8-8d25-f869ef66b5f6"),
				Name = "context",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				ModifiedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,40,72,44,74,204,77,45,73,45,42,86,176,85,112,46,74,77,44,73,13,128,11,105,36,231,231,149,164,86,148,104,90,115,5,87,230,37,103,20,229,231,101,86,165,250,39,101,165,38,151,104,164,230,149,100,150,84,6,39,103,164,230,38,234,40,4,103,230,165,231,164,6,229,151,7,167,38,22,37,103,184,101,230,128,12,208,65,50,95,71,1,97,26,0,5,227,41,33,122,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSynchronizeMultiRowsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5805eacf-4039-4985-bc8a-786e32e7e273"),
				Name = "SynchronizeMultiRows",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("de3c15c1-28ae-4d11-821b-c4655a03141e"),
				Name = "entitySchema",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				ModifiedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Terrasoft.Core.Entities.EntitySchema",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9f7d8b36-0a0f-45d7-835a-fcddcde9a18a"),
				Name = "context",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				ModifiedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,84,193,78,227,48,16,61,39,95,97,56,160,68,138,252,3,165,72,187,176,160,21,90,45,162,176,151,138,131,55,153,108,189,235,56,149,237,0,6,245,223,25,123,92,218,178,165,8,14,92,218,100,252,222,155,103,191,113,110,133,97,157,152,207,165,254,115,220,15,170,211,150,141,217,143,101,65,13,161,32,44,155,120,235,160,227,88,81,80,59,217,107,203,207,64,131,145,53,63,145,177,32,140,63,204,207,6,217,84,239,3,247,191,255,34,232,232,104,148,231,183,193,203,160,156,188,236,239,236,4,132,169,103,167,82,57,48,209,211,246,133,207,244,214,64,43,208,197,47,161,6,8,150,78,54,222,223,235,36,137,39,109,208,78,58,143,162,117,175,29,220,59,126,97,250,26,108,16,112,248,56,7,227,124,108,84,236,127,139,208,253,50,116,188,2,99,132,237,91,135,77,13,240,184,36,193,210,131,31,229,187,215,39,245,12,58,65,49,99,227,248,55,102,122,80,10,93,181,72,16,245,140,21,193,46,251,7,158,73,253,98,84,248,57,120,91,178,199,60,11,91,152,11,35,58,72,113,105,184,251,208,113,20,229,136,212,26,176,78,106,17,80,43,48,10,111,58,152,162,175,155,143,31,125,182,185,201,208,243,156,54,186,181,253,106,191,153,108,89,177,21,51,77,34,55,76,90,22,85,15,14,72,190,124,3,63,30,135,83,38,249,168,79,51,193,41,37,158,110,35,63,149,186,249,234,175,191,55,69,68,239,81,96,101,100,101,207,33,110,231,226,48,173,168,163,200,88,165,198,191,52,77,145,220,84,75,1,100,16,153,134,143,244,75,226,46,194,15,40,11,143,59,149,162,61,34,100,121,244,136,210,122,128,80,10,18,175,241,118,31,87,80,92,252,31,96,251,156,223,218,221,124,145,219,90,195,99,244,34,164,182,8,40,136,92,166,0,222,116,217,38,147,107,125,166,84,77,222,242,108,226,117,61,51,189,150,15,240,51,142,92,138,148,82,169,94,249,216,197,153,174,214,174,83,181,252,40,160,238,34,127,2,83,129,142,121,178,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSynchronizeObjectMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0f895944-f4b1-47fa-a882-5136072110a8"),
				Name = "SynchronizeObject",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("453e7a97-1466-44b3-aaff-effccd98b158"),
				Name = "entitySchema",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				ModifiedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Terrasoft.Core.Entities.EntitySchema",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a9321a63-9a04-486f-93b8-163f92d610d7"),
				Name = "searchFilters",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				ModifiedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("950b2cf9-ca8f-4788-8a28-6665a880b3a8"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				ModifiedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9c72bbb2-4bf2-4597-bab0-93f87b3a2aaf"),
				Name = "context",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				ModifiedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,146,65,111,226,48,16,133,207,201,175,240,222,28,9,89,189,179,93,169,16,90,245,184,64,247,82,245,224,38,195,226,149,177,217,177,13,68,171,254,247,29,219,164,68,20,209,149,246,16,77,252,98,191,124,111,198,59,137,108,165,180,7,116,236,150,57,144,216,172,239,143,107,233,216,162,115,30,54,98,106,181,134,198,43,107,156,120,0,3,168,26,81,171,36,72,236,190,150,15,65,181,35,102,95,127,209,166,111,227,114,71,166,141,213,97,99,126,72,29,32,58,111,37,202,13,252,159,109,185,4,68,233,236,202,211,73,4,81,79,196,2,162,1,113,167,114,203,166,8,210,67,86,57,24,175,124,183,104,214,176,145,163,62,229,136,200,140,135,131,23,79,14,112,106,141,201,4,213,184,84,198,51,180,123,55,181,193,68,179,155,113,25,156,50,63,25,143,129,218,215,217,1,154,224,45,210,167,203,30,98,102,92,64,168,39,39,137,87,21,251,83,22,201,39,217,16,96,11,152,122,29,33,69,54,133,121,146,249,233,39,85,69,199,10,181,98,252,75,62,34,226,150,163,93,81,32,248,128,102,76,175,111,244,12,169,207,144,234,201,178,219,2,9,59,64,202,79,235,52,147,165,125,52,158,103,231,231,155,23,74,79,70,111,105,114,173,244,114,118,80,46,154,221,105,109,247,115,187,231,167,249,141,230,240,59,40,132,246,94,129,110,79,75,218,122,84,134,125,143,109,165,12,3,64,234,107,202,160,86,252,253,79,41,235,199,233,62,26,202,226,153,202,165,159,110,86,191,7,192,238,108,196,195,59,119,101,206,212,214,100,209,247,158,31,211,51,208,14,50,26,251,148,237,105,75,59,128,133,92,122,182,172,94,98,27,92,191,127,132,204,214,103,144,69,100,188,76,84,211,133,34,148,54,151,158,40,171,215,136,174,32,100,175,243,62,149,127,1,7,34,128,72,53,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCheckValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("30a3ce9d-81d9-40dc-a1c6-092fd790676d"),
				Name = "CheckValue",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b131a50f-d1bd-49df-bd89-200f04167b83"),
				Name = "checkValue",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				ModifiedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,72,206,72,77,206,14,75,204,41,77,85,176,181,85,200,43,205,201,209,172,230,226,44,74,45,41,45,202,83,72,75,204,41,78,181,230,170,229,202,4,170,12,46,41,202,204,75,215,243,44,246,3,42,242,47,114,205,45,40,169,68,210,174,23,146,15,81,161,161,169,137,205,8,40,191,164,168,20,200,5,0,169,197,234,20,122,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateAllowRowMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c31f281d-79f0-4f63-87d6-0605fb955bad"),
				Name = "AllowRow",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4826072a-7de5-44a4-abd1-15f054f22d03"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				ModifiedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8c99fb97-861a-40be-9410-6dd7134f9186"),
				Name = "requiredColumns",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				ModifiedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d71edf4c-995c-4707-88bb-b86ff5921ae4"),
				Name = "requiredAllColumns",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				ModifiedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("36d6916c-217f-4527-a550-824e0959871f"),
				Name = "entitySchema",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				ModifiedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Terrasoft.Core.Entities.EntitySchema",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,83,95,107,131,48,16,127,214,79,113,125,41,10,195,47,224,90,40,221,86,198,198,24,148,237,165,244,33,213,115,205,26,227,150,196,110,178,246,187,239,18,173,218,86,80,144,187,223,159,251,37,39,207,32,80,248,93,114,133,233,188,16,101,46,53,76,38,32,75,33,194,63,223,83,104,74,37,193,168,18,99,255,232,239,153,2,38,196,3,71,145,18,14,78,204,153,16,13,57,118,152,148,25,118,255,203,181,33,76,205,61,85,95,21,106,148,182,158,49,161,155,70,226,184,239,76,148,104,85,191,152,98,57,26,84,26,152,134,101,165,13,230,17,233,11,76,12,47,164,142,22,40,81,241,36,186,227,174,192,84,117,187,40,121,122,3,197,230,147,48,211,90,117,79,152,140,247,98,193,101,80,82,215,70,113,249,177,90,15,82,222,30,83,98,73,252,129,103,202,226,60,166,65,24,251,89,161,144,37,91,8,186,225,95,104,98,224,242,82,193,158,161,215,192,29,90,39,91,204,89,221,181,120,58,11,110,170,165,171,70,125,146,199,233,102,250,232,200,89,208,221,116,134,53,208,187,158,58,154,165,233,57,153,138,52,184,69,111,104,152,157,251,60,250,246,61,14,197,177,201,175,211,88,17,178,180,147,245,175,140,230,150,134,113,169,159,176,10,90,126,232,166,179,216,209,124,139,201,206,97,207,120,171,22,187,14,187,204,237,126,53,233,250,187,212,236,204,69,12,207,175,179,32,53,29,231,108,209,234,253,115,8,122,78,152,1,167,97,163,214,199,241,143,126,243,71,4,125,143,241,24,70,157,24,28,14,61,109,219,108,149,195,248,31,160,94,237,53,112,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateDeleteQueryMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ea214b72-021e-4bcb-9a98-ecd60df926ef"),
				Name = "CreateDeleteQuery",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Terrasoft.Core.DB.Delete"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b581959b-5cb1-4840-928c-80f474105fab"),
				Name = "entitySchema",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				ModifiedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Terrasoft.Core.Entities.EntitySchema",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b29bbd62-6298-467b-b8d1-0f3ef5ae5f8c"),
				Name = "searchFilters",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				ModifiedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("64c340e2-7bb4-421c-970d-5eeee067f5fd"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				ModifiedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,82,205,75,195,48,20,63,119,176,255,225,185,83,11,35,120,159,19,220,39,67,16,97,83,15,226,33,107,95,93,52,77,244,37,81,138,248,191,155,44,153,83,134,160,7,161,180,77,250,126,159,205,11,39,168,133,180,72,6,134,96,144,83,185,153,165,53,55,176,108,141,197,134,141,181,148,88,90,161,149,97,115,84,72,162,100,19,177,221,224,212,158,116,59,115,39,170,62,232,245,131,159,58,29,116,59,43,36,226,70,215,214,67,9,217,100,196,38,40,209,34,84,241,49,4,133,175,240,211,84,238,12,210,88,43,21,53,11,79,104,44,9,117,15,165,150,174,81,23,188,9,20,189,222,161,210,84,89,97,5,154,248,210,46,203,13,54,124,188,69,37,112,208,118,82,122,104,244,194,102,164,155,28,191,140,179,192,31,68,69,13,121,42,199,179,59,101,225,104,8,199,5,188,117,59,217,90,107,9,194,204,4,25,235,41,45,57,244,136,172,246,38,120,185,129,60,52,2,143,216,130,80,187,130,217,57,182,38,162,179,64,157,208,105,39,203,62,253,125,51,19,205,135,222,237,168,189,90,84,185,39,13,230,246,136,84,71,92,164,249,107,46,29,134,15,105,50,101,189,217,32,97,190,135,21,108,97,166,207,142,203,252,240,95,68,34,118,201,201,15,122,255,187,42,110,189,129,187,254,78,110,194,45,223,138,173,218,39,44,146,177,125,47,53,151,38,121,40,181,143,165,98,77,217,123,184,253,53,240,111,227,166,176,103,170,250,239,168,62,134,191,8,173,35,149,206,246,224,3,184,25,154,77,83,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateDeleteRowsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6d09a1b0-2e69-4af2-ac64-87e761174b40"),
				Name = "DeleteRows",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e07e6466-ccb3-4a83-9cc5-70c571fa8f0f"),
				Name = "deletingFilters",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				ModifiedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9fd72d3a-4049-4127-81de-64ce086abc8c"),
				Name = "entitySchema",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				ModifiedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Terrasoft.Core.Entities.EntitySchema",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b023dd16-8ecc-45e6-a2f4-208fbf574ed4"),
				Name = "context",
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				ModifiedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,142,65,14,130,48,16,69,215,112,138,46,49,33,189,0,202,6,149,133,43,67,92,25,23,181,126,181,10,211,164,29,8,141,241,238,86,212,3,184,156,63,239,255,188,65,57,113,54,45,195,121,177,16,39,180,96,67,151,245,55,81,94,52,193,51,58,89,217,182,133,102,99,201,203,26,4,103,180,92,154,41,80,46,204,211,186,55,167,252,63,216,30,111,17,42,203,34,61,91,7,165,175,34,27,162,205,29,65,24,250,73,201,13,130,159,61,210,228,253,154,244,16,61,171,200,51,150,211,185,237,225,66,6,98,195,161,209,87,116,42,255,149,247,113,235,144,11,109,137,49,178,220,121,184,202,18,125,212,102,69,154,36,159,69,185,26,161,123,70,22,179,231,11,56,205,148,5,18,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SynchronizeChildEntityDataSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new SynchronizeChildEntityData(userConnection) {
				SchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa")
			};
		}

		#endregion

	}

	#endregion

	#region Class: SynchronizeChildEntityData

	[DesignModeProperty(Name = "ChildEntitySchemaUId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "15b17a1609c543509636904aade4b5aa", CaptionResourceItem = "Parameters.ChildEntitySchemaUId.Caption", DescriptionResourceItem = "Parameters.ChildEntitySchemaUId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "SingleRowSearchFilters", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "15b17a1609c543509636904aade4b5aa", CaptionResourceItem = "Parameters.SingleRowSearchFilters.Caption", DescriptionResourceItem = "Parameters.SingleRowSearchFilters.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "MultiRowsSearchFilters", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "15b17a1609c543509636904aade4b5aa", CaptionResourceItem = "Parameters.MultiRowsSearchFilters.Caption", DescriptionResourceItem = "Parameters.MultiRowsSearchFilters.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "MappingColumns", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "15b17a1609c543509636904aade4b5aa", CaptionResourceItem = "Parameters.MappingColumns.Caption", DescriptionResourceItem = "Parameters.MappingColumns.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "DefaultValues", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "15b17a1609c543509636904aade4b5aa", CaptionResourceItem = "Parameters.DefaultValues.Caption", DescriptionResourceItem = "Parameters.DefaultValues.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "RequiredAllFields", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "15b17a1609c543509636904aade4b5aa", CaptionResourceItem = "Parameters.RequiredAllFields.Caption", DescriptionResourceItem = "Parameters.RequiredAllFields.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "RequiredFields", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "15b17a1609c543509636904aade4b5aa", CaptionResourceItem = "Parameters.RequiredFields.Caption", DescriptionResourceItem = "Parameters.RequiredFields.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "DeletingFilters", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "15b17a1609c543509636904aade4b5aa", CaptionResourceItem = "Parameters.DeletingFilters.Caption", DescriptionResourceItem = "Parameters.DeletingFilters.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class SynchronizeChildEntityData : ProcessUserTask
	{

		#region Constructors: Public

		public SynchronizeChildEntityData(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa");
		}

		#endregion

		#region Properties: Public

		public virtual Guid ChildEntitySchemaUId {
			get;
			set;
		}

		public virtual Object SingleRowSearchFilters {
			get;
			set;
		}

		public virtual Object MultiRowsSearchFilters {
			get;
			set;
		}

		public virtual Object MappingColumns {
			get;
			set;
		}

		public virtual Object DefaultValues {
			get;
			set;
		}

		public virtual bool RequiredAllFields {
			get;
			set;
		}

		public virtual Object RequiredFields {
			get;
			set;
		}

		public virtual Object DeletingFilters {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			if (ChildEntitySchemaUId != Guid.Empty) {
				var mappingCoulmns = MappingColumns as System.Collections.Generic.Dictionary<
				Guid, System.Collections.Generic.Dictionary<
				Guid, object>>;
				var deletingFilters = DeletingFilters as System.Collections.Generic.Dictionary<
				Guid, System.Collections.Generic.Dictionary<
				Guid, object>>;
				var defaultValues = DefaultValues as System.Collections.Generic.Dictionary<
				Guid, object>;
				var singleRowSearchFilters = SingleRowSearchFilters as System.Collections.Generic.Dictionary<
				Guid, object>;
				Terrasoft.Core.Entities.EntitySchema entitySchema = GetDependentEntity(ChildEntitySchemaUId, context.UserConnection);
				if (singleRowSearchFilters.Count != 0) {
					SynchronizeSingleRow(entitySchema, context);
				} else {
					SynchronizeMultiRows(entitySchema, context);
				}
				if (deletingFilters != null){
					if (deletingFilters.Count > 0){
						DeleteRows(deletingFilters, entitySchema, context);
					}
				}
			}
			return true;
		}

		#endregion

		#region Methods: Public

		public virtual Terrasoft.Core.Entities.EntitySchema GetDependentEntity(Guid dependentEntitySchemaUId, UserConnection userConnection) {
			return userConnection.EntitySchemaManager.GetInstanceByUId(dependentEntitySchemaUId);
		}

		public virtual Terrasoft.Core.DB.Select CreateSelect(Terrasoft.Core.Entities.EntitySchema entitySchema, object searchFilters, UserConnection userConnection) {
			var filters = searchFilters as System.Collections.Generic.Dictionary<
			Guid, object>;
			
			Terrasoft.Core.DB.Select select =
				new Terrasoft.Core.DB.Select(userConnection).
					Column(Terrasoft.Core.DB.Func.Count(Terrasoft.Core.DB.Column.Asterisk())).
				From(entitySchema.Name);
			if (filters == null) {
				return select;
			}
			string columnName = "";
			Terrasoft.Core.Entities.EntitySchemaColumn column = null;
			if (filters.Count != 0) {
				bool isFirst = true;
				foreach (Guid key in filters.Keys) {
					column = entitySchema.Columns.GetByUId(key);
					columnName = entitySchema.Columns.GetByUId(key).ColumnValueName;
					if (isFirst) {
						if (filters[key] != null) {
							select.Where(columnName).IsEqual(Terrasoft.Core.DB.Column.Parameter(filters[key], column.DataValueType));
						} else {
							select.Where(columnName).IsNull();
						}
						isFirst = false;
						continue;
					}
					if (filters[key] != null) {
						select.And(columnName).IsEqual(Terrasoft.Core.DB.Column.Parameter(filters[key], column.DataValueType));
					} else {
						select.And(columnName).IsNull();
					}
				}
			}
			return select;
		}

		public virtual Terrasoft.Core.DB.Insert CreateInsertQuery(Terrasoft.Core.Entities.EntitySchema entitySchema, object values, UserConnection userConnection) {
			var parameters = values as System.Collections.Generic.Dictionary<
			Guid, object>;
			
			Terrasoft.Core.DB.Insert insert = new Terrasoft.Core.DB.Insert(userConnection).Into(entitySchema.Name);
			
			string columnName = "";
			Terrasoft.Core.Entities.EntitySchemaColumn column = null;
			foreach (Guid key in parameters.Keys) {
				column = entitySchema.Columns.GetByUId(key);
				columnName = column.ColumnValueName;
				insert = insert.Set(columnName, Terrasoft.Core.DB.Column.Parameter(parameters[key], column.DataValueType));
			}
			
			insert = insert.Set("CreatedById", Terrasoft.Core.DB.Column.Parameter(
				UserConnection.CurrentUser.ContactId, 
			        entitySchema.Columns.GetByName("CreatedBy").DataValueType));
			insert = insert.Set("CreatedOn", Terrasoft.Core.DB.Column.Parameter(
				UserConnection.CurrentUser.GetCurrentDateTime(), 
			        entitySchema.Columns.GetByName("CreatedOn").DataValueType));
			insert = insert.Set("ModifiedById", Terrasoft.Core.DB.Column.Parameter(
				UserConnection.CurrentUser.ContactId, 
			        entitySchema.Columns.GetByName("ModifiedBy").DataValueType));
			insert = insert.Set("ModifiedOn", Terrasoft.Core.DB.Column.Parameter(
				UserConnection.CurrentUser.GetCurrentDateTime(), 
			       entitySchema.Columns.GetByName("ModifiedOn").DataValueType));
			return insert;
		}

		public virtual object CreateParameters(ProcessExecutingContext context) {
			var mappingCoulmns = MappingColumns as System.Collections.Generic.Dictionary<
			Guid, System.Collections.Generic.Dictionary<
			Guid, object>>;
			var defaultValues = DefaultValues as System.Collections.Generic.Dictionary<
			Guid, object>;
			System.Collections.Generic.Dictionary<
			Guid, object> parameters = new System.Collections.Generic.Dictionary<
			Guid, object>();
			
			var entity = context.Process.GetPropertyValue("Entity") as Terrasoft.Core.Entities.Entity;
			Terrasoft.Core.Entities.EntitySchemaColumn column = null;
			foreach (Guid key in mappingCoulmns.Keys) {
				var destinationDictionary = mappingCoulmns[key] as System.Collections.Generic.Dictionary<
			Guid, object>;
				foreach (Guid destKey in destinationDictionary.Keys) {
					if (destinationDictionary[destKey] is Guid && (Guid)destinationDictionary[destKey] == key) {
						column = entity.Schema.Columns.GetByUId(key);
						parameters.Add(destKey, entity.GetColumnValue(column));
						continue;
					}
					parameters.Add(destKey, destinationDictionary[destKey]);
				}
			}
			foreach (Guid key in defaultValues.Keys) {
				if (parameters.ContainsKey(key)) {
					continue;
				}
				parameters.Add(key, defaultValues[key]);
			}
			return parameters;
		}

		public virtual Terrasoft.Core.DB.Update CreateUpdateQuery(Terrasoft.Core.Entities.EntitySchema entitySchema, object searchFilters, object values, UserConnection userConnection) {
			var parameters = values as System.Collections.Generic.Dictionary<
			Guid, object>;
			var filters = searchFilters as System.Collections.Generic.Dictionary<
			Guid, object>;
			
			Terrasoft.Core.DB.Update update = new Terrasoft.Core.DB.Update(userConnection, entitySchema.Name);
			
			string columnName = "";
			Terrasoft.Core.Entities.EntitySchemaColumn column = null;
			foreach (Guid key in parameters.Keys) {
				column = entitySchema.Columns.GetByUId(key);
				columnName = column.ColumnValueName;
				update.Set(columnName, Terrasoft.Core.DB.Column.Parameter(parameters[key], column.DataValueType));
			}
			
			update.Set("ModifiedById", Terrasoft.Core.DB.Column.Parameter(
				UserConnection.CurrentUser.ContactId, 
			        entitySchema.Columns.GetByName("ModifiedBy").DataValueType));
			update.Set("ModifiedOn", Terrasoft.Core.DB.Column.Parameter(
				UserConnection.CurrentUser.GetCurrentDateTime(), 
			       entitySchema.Columns.GetByName("ModifiedOn").DataValueType));
			
			
			if (filters.Count != 0) {
				bool isFirst = true;
				foreach (Guid key in filters.Keys) {
					if (isFirst) {
						column = entitySchema.Columns.GetByUId(key);
						columnName = column.ColumnValueName;
						if (filters[key] != null) {
							update.Where(columnName).IsEqual(Terrasoft.Core.DB.Column.Parameter(filters[key], column.DataValueType));
						} else {
							update.Where(columnName).IsNull();
						}
						isFirst = false;
						continue;
					}
					column = entitySchema.Columns.GetByUId(key);
					columnName = column.ColumnValueName;
					if (filters[key] != null) {
						update.And(columnName).IsEqual(Terrasoft.Core.DB.Column.Parameter(filters[key], column.DataValueType));
					} else {
						update.And(columnName).IsNull();
					}
				}
			}
			return update;
		}

		public virtual void SynchronizeSingleRow(Terrasoft.Core.Entities.EntitySchema entitySchema, ProcessExecutingContext context) {
			var parameters = CreateParameters(context);
			SynchronizeObject(entitySchema, SingleRowSearchFilters, parameters, context);
		}

		public virtual void SynchronizeMultiRows(Terrasoft.Core.Entities.EntitySchema entitySchema, ProcessExecutingContext context) {
			var mappingCoulmns = MappingColumns as System.Collections.Generic.Dictionary<
			Guid, System.Collections.Generic.Dictionary<
			Guid, object>>;
			
			var multiRowsSearchFilters = MultiRowsSearchFilters as System.Collections.Generic.Dictionary<
			Guid, System.Collections.Generic.Dictionary<
			Guid, object>>;
			
			var defaultValues = DefaultValues as System.Collections.Generic.Dictionary<
			Guid, object>;
			
			var entity = context.Process.GetPropertyValue("Entity") as Terrasoft.Core.Entities.Entity;
			Terrasoft.Core.Entities.EntitySchemaColumn column = null;
			
			foreach (Guid key in mappingCoulmns.Keys) {
				var parameters = new System.Collections.Generic.Dictionary<
			Guid, object>();
				var destinationDictionary = mappingCoulmns[key] as System.Collections.Generic.Dictionary<
			Guid, object>;
				foreach (Guid destKey in destinationDictionary.Keys) {
					if (destinationDictionary[destKey] is Guid && (Guid)destinationDictionary[destKey] == key) {
						if (entity.Schema.Columns.FindByUId(key) != null){
							column = entity.Schema.Columns.GetByUId(key);
							parameters.Add(destKey, entity.GetColumnValue(column));
						}
						else{
							parameters.Add(destKey, null);
						}	
						continue;
					}
					parameters.Add(destKey, destinationDictionary[destKey]);
				}
				foreach (Guid defKey in defaultValues.Keys) {
					if (parameters.ContainsKey(defKey)) {
						continue;
					}
					parameters.Add(defKey, defaultValues[defKey]);
				}
			
				SynchronizeObject(entitySchema, multiRowsSearchFilters[key], parameters, context);
			}
		}

		public virtual void SynchronizeObject(Terrasoft.Core.Entities.EntitySchema entitySchema, object searchFilters, object parameters, ProcessExecutingContext context) {
			var filters = searchFilters as System.Collections.Generic.Dictionary<
			Guid, object>;
			var columnValues = parameters as System.Collections.Generic.Dictionary<
			Guid, object>;
			
			Terrasoft.Core.DB.Select select = CreateSelect(entitySchema, filters, context.UserConnection);
			int rowsCount = 0;
			using (var dbExecutor = context.UserConnection.EnsureDBConnection()) {
				using(var reader = select.ExecuteReader(dbExecutor)){
					if (!reader.Read()) {
						return;
					}
					rowsCount = UserConnection.DBTypeConverter.DBValueToInt(reader[0]);
				}
			}
			var dataExist = AllowRow(parameters,RequiredFields,RequiredAllFields,entitySchema);
			if (rowsCount == 0) {
				if(dataExist){
					Terrasoft.Core.DB.Insert insert = CreateInsertQuery(entitySchema, columnValues, context.UserConnection);
					insert.Execute();
				}
			} else {
				if (dataExist){
					Terrasoft.Core.DB.Update update = CreateUpdateQuery(entitySchema, filters, columnValues, context.UserConnection);
					update.Execute();
				}
				else{
					Terrasoft.Core.DB.Delete delete = CreateDeleteQuery(entitySchema, filters,context.UserConnection);
					delete.Execute();
				}
			}
		}

		public virtual bool CheckValue(object checkValue) {
			if (checkValue == null){
				return false;
			}
			if (String.IsNullOrEmpty(checkValue.ToString())){
				return false;
			}
			return true;
		}

		public virtual bool AllowRow(object parameters, object requiredColumns, bool requiredAllColumns, Terrasoft.Core.Entities.EntitySchema entitySchema) {
			if (requiredColumns == null){
				return true;
			}
			var allFields = requiredAllColumns;
			var dataExist = true;
			var dataPresent = false;
			var columnValues = parameters as System.Collections.Generic.Dictionary<Guid, object>;
			var verifiedColumns = requiredColumns as string[];
			var verifiedColumnsUId = new List<Guid>();
			foreach (var columnName in verifiedColumns){
					foreach(var schemaColumn in entitySchema.Columns){
						if (schemaColumn.Name == columnName){
							verifiedColumnsUId.Add(schemaColumn.UId);
							break;
						}
					}
			}
			foreach (var columnUId in verifiedColumnsUId){
				if (columnValues.ContainsKey(columnUId)){
					if (!CheckValue(columnValues[columnUId])){
						if (allFields){
							dataExist = false;
							break;
						}	
					}
					else{
						dataPresent =true;
					}
				}
				else{
					if (allFields){
						dataExist = false;
						break;
					}
				}
			}
			return (dataPresent && !allFields) || (allFields && dataExist);
		}

		public virtual Terrasoft.Core.DB.Delete CreateDeleteQuery(Terrasoft.Core.Entities.EntitySchema entitySchema, object searchFilters, UserConnection userConnection) {
			var filters = searchFilters as System.Collections.Generic.Dictionary<
			Guid, object>;
			Terrasoft.Core.DB.Delete delete = new Terrasoft.Core.DB.Delete(userConnection);
			string columnName = "";
			Terrasoft.Core.Entities.EntitySchemaColumn column = null;
			delete.From(entitySchema.Name);
			if (filters.Count != 0) {
				bool isFirst = true;
				foreach (Guid key in filters.Keys) {
					if (isFirst) {
							column = entitySchema.Columns.GetByUId(key);
							columnName = column.ColumnValueName;
							delete.Where(columnName).IsEqual(Terrasoft.Core.DB.Column.Parameter(filters[key], column.DataValueType));
						isFirst = false;
						continue;
					}
					column = entitySchema.Columns.GetByUId(key);
					columnName = column.ColumnValueName;
					delete.And(columnName).IsEqual(Terrasoft.Core.DB.Column.Parameter(filters[key], column.DataValueType));
				}
			}
			return delete;
		}

		public virtual void DeleteRows(object deletingFilters, Terrasoft.Core.Entities.EntitySchema entitySchema, ProcessExecutingContext context) {
			var filters = deletingFilters as System.Collections.Generic.Dictionary<
			Guid, System.Collections.Generic.Dictionary<
			Guid, object>>;
			foreach (var key in filters.Keys){
				var delete = CreateDeleteQuery(entitySchema, filters[key], context.UserConnection);
					delete.Execute();
			}
		}

		public override void WritePropertiesData(DataWriter writer) {
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer);
			if (Status == Core.Process.ProcessStatus.Inactive) {
				writer.WriteFinishObject();
				return;
			}
			if (!HasMapping("ChildEntitySchemaUId")) {
				writer.WriteValue("ChildEntitySchemaUId", ChildEntitySchemaUId, Guid.Empty);
			}
			if (SingleRowSearchFilters != null) {
				if (SingleRowSearchFilters.GetType().IsSerializable || SingleRowSearchFilters.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("SingleRowSearchFilters", SingleRowSearchFilters, null);
				}
			}
			if (MultiRowsSearchFilters != null) {
				if (MultiRowsSearchFilters.GetType().IsSerializable || MultiRowsSearchFilters.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("MultiRowsSearchFilters", MultiRowsSearchFilters, null);
				}
			}
			if (MappingColumns != null) {
				if (MappingColumns.GetType().IsSerializable || MappingColumns.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("MappingColumns", MappingColumns, null);
				}
			}
			if (DefaultValues != null) {
				if (DefaultValues.GetType().IsSerializable || DefaultValues.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("DefaultValues", DefaultValues, null);
				}
			}
			if (!HasMapping("RequiredAllFields")) {
				writer.WriteValue("RequiredAllFields", RequiredAllFields, false);
			}
			if (RequiredFields != null) {
				if (RequiredFields.GetType().IsSerializable || RequiredFields.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("RequiredFields", RequiredFields, null);
				}
			}
			if (DeletingFilters != null) {
				if (DeletingFilters.GetType().IsSerializable || DeletingFilters.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("DeletingFilters", DeletingFilters, null);
				}
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "ChildEntitySchemaUId":
					ChildEntitySchemaUId = reader.GetGuidValue();
				break;
				case "SingleRowSearchFilters":
					SingleRowSearchFilters = reader.GetSerializableObjectValue();
				break;
				case "MultiRowsSearchFilters":
					MultiRowsSearchFilters = reader.GetSerializableObjectValue();
				break;
				case "MappingColumns":
					MappingColumns = reader.GetSerializableObjectValue();
				break;
				case "DefaultValues":
					DefaultValues = reader.GetSerializableObjectValue();
				break;
				case "RequiredAllFields":
					RequiredAllFields = reader.GetBoolValue();
				break;
				case "RequiredFields":
					RequiredFields = reader.GetSerializableObjectValue();
				break;
				case "DeletingFilters":
					DeletingFilters = reader.GetSerializableObjectValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

