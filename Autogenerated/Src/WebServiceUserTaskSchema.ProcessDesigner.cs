namespace Terrasoft.Core.Process.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using System.IO;
	using System.Net;
	using System.Xml;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.UI.WebControls.Controls;

	#region Class: WebServiceUserTaskSchema

	/// <exclude/>
	public class WebServiceUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public WebServiceUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public WebServiceUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e7acb2e5-efc6-41d3-8c02-589ae6b943f1");
			RealUId = new Guid("e7acb2e5-efc6-41d3-8c02-589ae6b943f1");
			Name = "WebServiceUserTask";
			CreatedInPackageId = new Guid("47c22e57-1b16-4004-8f6b-0f257046428b");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = new Guid("134ef0f5-10e9-4ebc-b056-636d5aa98fe8");
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,84,193,110,219,48,12,61,71,95,161,249,228,96,155,29,172,216,37,174,131,110,129,215,6,232,186,46,105,144,93,221,152,75,12,200,146,43,201,117,131,53,255,62,202,146,98,103,157,47,18,249,248,200,39,138,214,85,80,254,166,225,10,228,115,185,133,181,100,52,77,233,117,83,22,81,86,213,250,64,95,95,169,210,178,228,187,104,161,238,26,198,126,200,206,239,9,223,65,239,69,49,30,211,63,100,36,65,55,146,83,45,27,72,200,145,88,26,85,131,204,52,228,208,210,21,48,216,234,112,141,200,92,112,142,251,82,240,49,25,69,115,193,154,138,135,65,176,94,222,6,129,241,124,147,162,66,123,3,143,94,160,71,54,123,144,128,208,162,64,27,181,101,79,77,206,186,244,63,27,144,135,251,92,230,21,104,144,46,228,3,237,79,136,106,115,229,84,152,84,217,11,108,27,13,171,109,206,114,121,105,101,207,194,113,66,110,180,174,177,244,18,158,26,80,154,182,253,54,165,115,9,185,134,30,13,251,115,158,106,185,230,36,190,21,61,251,42,8,46,149,200,235,105,198,159,129,137,26,232,75,197,184,154,26,95,26,224,183,199,210,211,56,110,219,54,106,47,34,33,119,241,167,201,228,34,158,124,142,77,200,71,112,52,19,234,168,168,238,13,19,30,157,170,95,209,93,246,16,27,120,70,108,225,27,200,11,144,241,140,140,172,253,85,20,135,89,16,36,196,139,124,159,122,189,6,90,112,236,37,207,217,25,142,167,64,122,220,243,137,51,252,169,186,132,125,219,240,130,49,13,215,183,192,119,122,79,79,5,34,235,72,72,163,76,155,194,149,198,230,86,102,238,204,146,14,26,31,93,131,118,91,27,20,218,209,59,35,110,100,137,98,29,221,25,41,237,38,111,224,10,45,110,249,163,97,112,212,45,161,171,131,215,247,15,60,103,66,129,153,143,209,17,199,220,149,238,38,65,213,130,43,160,210,111,222,74,183,192,255,84,47,187,11,161,178,56,211,106,189,161,207,56,76,114,106,0,230,162,168,209,250,183,166,170,44,34,67,124,16,25,47,78,66,239,37,212,185,4,31,134,107,195,180,65,205,255,255,110,161,110,197,110,135,122,156,220,47,188,240,145,157,214,126,118,221,115,208,61,3,9,25,150,61,71,142,100,248,32,4,127,1,112,17,166,23,104,4,0,0 };
			SerializeToDB = true;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateServiceParameter());
			Parameters.Add(CreateServiceMethodParameter());
			Parameters.Add(CreateServiceUrlParameter());
			Parameters.Add(CreateServiceMethodParametersParameter());
			Parameters.Add(CreateRequestStatusParameter());
			Parameters.Add(CreateResultParameter());
			Parameters.Add(CreateIsLoggingRequestAndResponceParameter());
			Parameters.Add(CreateRequestParameter());
			Parameters.Add(CreateResponceParameter());
			Parameters.Add(CreateRequestBodyInternalParameter());
			Parameters.Add(CreateRequestParametersParameter());
		}

		protected virtual ProcessSchemaParameter CreateServiceParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("3a135987-81ff-45e9-b9ff-9e743d2e09ab"),
				Name = "Service",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("34a72c74-848f-4081-86c8-87310ee15fb5"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateServiceMethodParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("c5d62929-4da2-4eb9-bc43-48a5abb39fe1"),
				Name = "ServiceMethod",
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateServiceUrlParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("7c0c0d3c-3b13-46da-9e2d-786ff6f4e202"),
				Name = "ServiceUrl",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("543e7919-0d37-4610-a08f-443e8605f9bc"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateServiceMethodParametersParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("caa4b459-8e54-402b-8f37-9476968ecf19"),
				Name = "ServiceMethodParameters",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateRequestStatusParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("0bbcd347-2732-4327-a88a-f184b328c46b"),
				Name = "RequestStatus",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateResultParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("99801d29-a800-4f4d-a846-8b831766c3a7"),
				Name = "Result",
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateIsLoggingRequestAndResponceParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("2bb83070-20f5-471e-81b6-055f828798bd"),
				Name = "IsLoggingRequestAndResponce",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateRequestParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("811a93ed-b863-4af5-b23b-4e4c1db60552"),
				Name = "Request",
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateResponceParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("d413a8e2-92ef-4308-b7da-819c94b82a00"),
				Name = "Responce",
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateRequestBodyInternalParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("cc4beb83-d71c-4f7c-84c7-5f1c41411867"),
				Name = "RequestBodyInternal",
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateRequestParametersParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("178743ee-a18e-4708-ab84-dbd724d4af23"),
				Name = "RequestParameters",
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
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
			Methods.Add(CreateGetExecutionDataMethod());
			Methods.Add(CreateCreateWebRequestMethod());
			Methods.Add(CreatePrepareRequestParametersMethod());
			Methods.Add(CreatePrepareResponceResultMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6a25edfd-deba-4e8a-912a-043637d9fae8"),
				Name = "System.IO",
				Alias = "",
				CreatedInPackageId = new Guid("40e7b34d-9c62-44ae-ba50-14667623696b")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("99d24158-b812-421c-978b-888a5995e602"),
				Name = "System.Net",
				Alias = "",
				CreatedInPackageId = new Guid("40e7b34d-9c62-44ae-ba50-14667623696b")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("da316efe-469b-4c38-87b2-57054c98fc0b"),
				Name = "System.Xml",
				Alias = "",
				CreatedInPackageId = new Guid("40e7b34d-9c62-44ae-ba50-14667623696b")
			});
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d0ce97e2-7e5a-48d5-a685-83b165c4055a"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("e7acb2e5-efc6-41d3-8c02-589ae6b943f1"),
				CreatedInPackageId = new Guid("47c22e57-1b16-4004-8f6b-0f257046428b"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9fba0c52-a796-4afa-9b48-c28b47ae788f"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("e7acb2e5-efc6-41d3-8c02-589ae6b943f1"),
				ModifiedInSchemaUId = new Guid("e7acb2e5-efc6-41d3-8c02-589ae6b943f1"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("47c22e57-1b16-4004-8f6b-0f257046428b")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6ab2f166-9063-4497-9ea7-c3b1f64c1bfe"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("e7acb2e5-efc6-41d3-8c02-589ae6b943f1"),
				ModifiedInSchemaUId = new Guid("e7acb2e5-efc6-41d3-8c02-589ae6b943f1"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("47c22e57-1b16-4004-8f6b-0f257046428b")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,113,47,205,76,209,81,40,46,41,202,204,75,183,211,208,180,6,0,179,24,102,192,38,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("30db6779-968c-4a5f-a545-3a6131239eed"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("e7acb2e5-efc6-41d3-8c02-589ae6b943f1"),
				CreatedInPackageId = new Guid("47c22e57-1b16-4004-8f6b-0f257046428b"),
				ResultValueTypeName = "bool",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("178f1cbb-8ec3-4810-831b-03a2f221447e"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("e7acb2e5-efc6-41d3-8c02-589ae6b943f1"),
				ModifiedInSchemaUId = new Guid("e7acb2e5-efc6-41d3-8c02-589ae6b943f1"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("47c22e57-1b16-4004-8f6b-0f257046428b"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,74,44,78,213,115,206,207,45,200,73,45,73,117,173,72,77,46,45,201,204,75,215,40,72,44,74,204,5,138,20,21,107,90,3,0,145,9,166,203,42,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCancelExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1c8ee540-c252-4afe-8db7-e86de169eed9"),
				Name = "CancelExecuting",
				CreatedInSchemaUId = new Guid("e7acb2e5-efc6-41d3-8c02-589ae6b943f1"),
				CreatedInPackageId = new Guid("47c22e57-1b16-4004-8f6b-0f257046428b"),
				ResultValueTypeName = "void",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("74b6f2a5-add1-40a6-8ffa-69c2b29214ac"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("e7acb2e5-efc6-41d3-8c02-589ae6b943f1"),
				ModifiedInSchemaUId = new Guid("e7acb2e5-efc6-41d3-8c02-589ae6b943f1"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("47c22e57-1b16-4004-8f6b-0f257046428b"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,115,78,204,75,78,205,113,173,72,77,46,45,201,204,75,215,40,72,44,74,204,77,45,73,45,42,214,180,6,0,4,172,171,3,33,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetExecutionDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("39b198cd-54e4-4303-b402-9bd26a312f86"),
				Name = "GetExecutionData",
				CreatedInSchemaUId = new Guid("e7acb2e5-efc6-41d3-8c02-589ae6b943f1"),
				CreatedInPackageId = new Guid("47c22e57-1b16-4004-8f6b-0f257046428b"),
				ResultValueTypeName = "string",
				IsOverride = true,
				IsCustom = true
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateWebRequestMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1954ce57-604b-4828-b6f7-dc9383d04f07"),
				Name = "CreateWebRequest",
				CreatedInSchemaUId = new Guid("e7acb2e5-efc6-41d3-8c02-589ae6b943f1"),
				CreatedInPackageId = new Guid("40e7b34d-9c62-44ae-ba50-14667623696b"),
				ResultValueTypeName = "HttpWebRequest"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b062391e-3332-4cf9-9686-7bf3fb928bc6"),
				Name = "url",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("40e7b34d-9c62-44ae-ba50-14667623696b")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c5155a39-46f4-42d0-9abe-116874421b64"),
				Name = "soapAction",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("40e7b34d-9c62-44ae-ba50-14667623696b")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,143,79,15,130,48,12,197,239,124,10,178,19,132,200,174,198,133,3,49,26,18,227,159,232,140,30,184,76,108,2,201,220,230,40,76,191,189,204,11,112,123,237,107,223,175,45,16,205,13,30,103,120,119,208,98,232,70,153,133,81,49,51,227,81,166,107,11,2,33,234,172,140,89,224,38,125,173,16,20,242,175,129,33,128,8,99,100,83,9,108,180,162,173,22,38,249,188,36,171,106,97,91,192,236,202,183,139,37,19,149,119,179,146,212,3,108,69,169,115,46,29,2,91,176,125,83,193,61,61,108,56,37,97,18,250,245,252,63,59,20,164,36,100,198,221,3,214,250,233,145,167,227,133,207,189,29,128,201,101,211,251,139,208,118,192,2,11,216,89,53,121,150,253,0,65,168,139,220,7,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreatePrepareRequestParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("71891f57-ec4d-4070-995a-54602d6c2e81"),
				Name = "PrepareRequestParameters",
				CreatedInSchemaUId = new Guid("e7acb2e5-efc6-41d3-8c02-589ae6b943f1"),
				CreatedInPackageId = new Guid("40e7b34d-9c62-44ae-ba50-14667623696b"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,112,80,226,229,178,41,79,77,178,114,206,207,43,75,45,42,206,204,207,11,74,44,73,181,227,229,226,228,228,4,75,184,21,229,231,58,151,22,21,165,230,37,87,218,133,6,187,216,232,99,136,34,20,135,228,35,148,58,122,64,148,34,137,129,20,66,4,209,172,83,178,230,229,2,0,188,255,43,80,146,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreatePrepareResponceResultMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a6f9adf8-fcd5-4617-ab6c-17796353a2a6"),
				Name = "PrepareResponceResult",
				CreatedInSchemaUId = new Guid("e7acb2e5-efc6-41d3-8c02-589ae6b943f1"),
				CreatedInPackageId = new Guid("40e7b34d-9c62-44ae-ba50-14667623696b"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] {  };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new WebServiceUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e7acb2e5-efc6-41d3-8c02-589ae6b943f1"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new WebServiceUserTask(userConnection) {
				SchemaUId = new Guid("e7acb2e5-efc6-41d3-8c02-589ae6b943f1")
			};
		}

		#endregion

	}

	#endregion

	#region Class: WebServiceUserTask

	[DesignModeProperty(Name = "Service", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e7acb2e5efc641d38c02589ae6b943f1", CaptionResourceItem = "Parameters.Service.Caption", DescriptionResourceItem = "Parameters.Service.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ServiceMethod", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e7acb2e5efc641d38c02589ae6b943f1", CaptionResourceItem = "Parameters.ServiceMethod.Caption", DescriptionResourceItem = "Parameters.ServiceMethod.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ServiceUrl", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e7acb2e5efc641d38c02589ae6b943f1", CaptionResourceItem = "Parameters.ServiceUrl.Caption", DescriptionResourceItem = "Parameters.ServiceUrl.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ServiceMethodParameters", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e7acb2e5efc641d38c02589ae6b943f1", CaptionResourceItem = "Parameters.ServiceMethodParameters.Caption", DescriptionResourceItem = "Parameters.ServiceMethodParameters.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "RequestStatus", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e7acb2e5efc641d38c02589ae6b943f1", CaptionResourceItem = "Parameters.RequestStatus.Caption", DescriptionResourceItem = "Parameters.RequestStatus.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Result", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e7acb2e5efc641d38c02589ae6b943f1", CaptionResourceItem = "Parameters.Result.Caption", DescriptionResourceItem = "Parameters.Result.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "IsLoggingRequestAndResponce", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e7acb2e5efc641d38c02589ae6b943f1", CaptionResourceItem = "Parameters.IsLoggingRequestAndResponce.Caption", DescriptionResourceItem = "Parameters.IsLoggingRequestAndResponce.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Request", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e7acb2e5efc641d38c02589ae6b943f1", CaptionResourceItem = "Parameters.Request.Caption", DescriptionResourceItem = "Parameters.Request.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Responce", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e7acb2e5efc641d38c02589ae6b943f1", CaptionResourceItem = "Parameters.Responce.Caption", DescriptionResourceItem = "Parameters.Responce.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "RequestBodyInternal", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e7acb2e5efc641d38c02589ae6b943f1", CaptionResourceItem = "Parameters.RequestBodyInternal.Caption", DescriptionResourceItem = "Parameters.RequestBodyInternal.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "RequestParameters", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e7acb2e5efc641d38c02589ae6b943f1", CaptionResourceItem = "Parameters.RequestParameters.Caption", DescriptionResourceItem = "Parameters.RequestParameters.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class WebServiceUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public WebServiceUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("e7acb2e5-efc6-41d3-8c02-589ae6b943f1");
		}

		#endregion

		#region Properties: Public

		public virtual Guid Service {
			get;
			set;
		}

		public virtual string ServiceMethod {
			get;
			set;
		}

		public virtual Guid ServiceUrl {
			get;
			set;
		}

		public virtual string ServiceMethodParameters {
			get;
			set;
		}

		public virtual int RequestStatus {
			get;
			set;
		}

		private Entity _result;
		public virtual Entity Result {
			get {
				return _result ?? (_result = new Entity(UserConnection));
			}
			set {
				_result = value;
			}
		}

		public virtual bool IsLoggingRequestAndResponce {
			get;
			set;
		}

		public virtual string Request {
			get;
			set;
		}

		public virtual string Responce {
			get;
			set;
		}

		public virtual string RequestBodyInternal {
			get;
			set;
		}

		public virtual string RequestParameters {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			if (ServiceUrl == Guid.Empty || string.IsNullOrEmpty(ServiceMethod)) {
				return true;
			}
			string serviceUrl = (new Select(UserConnection)
				.Column("URL")
				.From("WebServiceURL")
				.Where("Id").IsEqual(new QueryParameter("Id", ServiceUrl)) as Select)
				.ExecuteScalar<string>();
			HttpWebRequest webRequest = CreateWebRequest(serviceUrl, ServiceMethod);
			string Request = @"<soap:Envelope xmlns:soap=""http://www.w3.org/2003/05/soap-envelope"" xmlns:web=""http://www.webserviceX.NET/"">
			<soap:Header/>
				<soap:Body>";
			Request += RequestBodyInternal;
			Request += @"
				</soap:Body>
			</soap:Envelope>";
			webRequest.ContentLength = Request.Length;
			using (Stream stream = webRequest.GetRequestStream()) {
				using (StreamWriter streamWriter = new StreamWriter(stream)) {
					streamWriter.Write(Request);
					streamWriter.Close();
				}
			}
			using (WebResponse response = webRequest.GetResponse()) {
				using (StreamReader rd = new StreamReader(response.GetResponseStream())) { 
					Responce = rd.ReadToEnd();
				}
			}
			PrepareResponceResult();
			if (!IsLoggingRequestAndResponce) {
				Request = string.Empty;
				Responce = string.Empty;
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

		public override string GetExecutionData() {
			return string.Empty;
		}

		public virtual HttpWebRequest CreateWebRequest(string url, string soapAction) {
			HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
			webRequest.ContentType = "application/soap+xml;charset=UTF-8;action=\"http://www.webserviceX.NET/" + soapAction + "\"";
			webRequest.Method = "POST";
			webRequest.KeepAlive = true;
			return webRequest;
		}

		public virtual string PrepareRequestParameters() {
			return @"
			<web:ConversionRate>
						<web:FromCurrency>USD</web:FromCurrency>
						<web:ToCurrency>UAH</web:ToCurrency>
					</web:ConversionRate>";
		}

		public virtual void PrepareResponceResult() {
		}

		public override void WritePropertiesData(DataWriter writer) {
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer);
			if (Status == Core.Process.ProcessStatus.Inactive) {
				writer.WriteFinishObject();
				return;
			}
			if (!HasMapping("Service")) {
				writer.WriteValue("Service", Service, Guid.Empty);
			}
			if (!HasMapping("ServiceMethod")) {
				writer.WriteValue("ServiceMethod", ServiceMethod, null);
			}
			if (!HasMapping("ServiceUrl")) {
				writer.WriteValue("ServiceUrl", ServiceUrl, Guid.Empty);
			}
			if (!HasMapping("ServiceMethodParameters")) {
				writer.WriteValue("ServiceMethodParameters", ServiceMethodParameters, null);
			}
			if (!HasMapping("RequestStatus")) {
				writer.WriteValue("RequestStatus", RequestStatus, 0);
			}
			if (Result != null && Result.Schema != null) {
				if (UseFlowEngineMode) {
					Result.Write(writer, "Result");
				} else {
					string serializedEntity = Entity.SerializeToJson(Result);
					writer.WriteValue("Result", serializedEntity, null);
				}
			}
			if (!HasMapping("IsLoggingRequestAndResponce")) {
				writer.WriteValue("IsLoggingRequestAndResponce", IsLoggingRequestAndResponce, false);
			}
			if (!HasMapping("Request")) {
				writer.WriteValue("Request", Request, null);
			}
			if (!HasMapping("Responce")) {
				writer.WriteValue("Responce", Responce, null);
			}
			if (!HasMapping("RequestBodyInternal")) {
				writer.WriteValue("RequestBodyInternal", RequestBodyInternal, null);
			}
			if (!HasMapping("RequestParameters")) {
				writer.WriteValue("RequestParameters", RequestParameters, null);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "Service":
					Service = reader.GetGuidValue();
				break;
				case "ServiceMethod":
					ServiceMethod = reader.GetStringValue();
				break;
				case "ServiceUrl":
					ServiceUrl = reader.GetGuidValue();
				break;
				case "ServiceMethodParameters":
					ServiceMethodParameters = reader.GetStringValue();
				break;
				case "RequestStatus":
					RequestStatus = reader.GetIntValue();
				break;
				case "Result":
					if (UseFlowEngineMode) {
						Result = reader.GetValue<Entity>();
					} else {
						Result = Entity.DeserializeFromJson(UserConnection, reader.GetValue<System.String>());
					}
				break;
				case "IsLoggingRequestAndResponce":
					IsLoggingRequestAndResponce = reader.GetBoolValue();
				break;
				case "Request":
					Request = reader.GetStringValue();
				break;
				case "Responce":
					Responce = reader.GetStringValue();
				break;
				case "RequestBodyInternal":
					RequestBodyInternal = reader.GetStringValue();
				break;
				case "RequestParameters":
					RequestParameters = reader.GetStringValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

