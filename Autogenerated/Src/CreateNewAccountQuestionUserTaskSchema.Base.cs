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

	#region Class: CreateNewAccountQuestionUserTaskSchema

	/// <exclude/>
	public class CreateNewAccountQuestionUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public CreateNewAccountQuestionUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public CreateNewAccountQuestionUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("829b799e-c3d4-4a82-a4c5-60f17413f5e2");
			RealUId = new Guid("829b799e-c3d4-4a82-a4c5-60f17413f5e2");
			Name = "CreateNewAccountQuestionUserTask";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,87,91,107,219,72,20,126,150,127,197,32,88,36,81,35,39,97,3,139,67,161,137,211,146,178,73,90,234,44,125,40,125,152,72,99,107,200,88,99,102,70,113,220,226,255,190,103,110,186,123,155,101,89,28,34,52,231,50,231,124,231,170,119,225,51,22,72,102,130,110,21,122,139,222,133,225,228,129,8,129,37,95,169,116,81,73,197,55,119,68,74,188,38,64,93,85,101,166,40,47,227,4,253,156,4,90,112,71,203,156,239,22,120,171,143,129,35,10,67,244,6,125,237,156,190,209,90,163,11,43,176,145,235,154,205,43,238,48,8,156,83,126,218,215,40,149,160,229,58,253,192,197,6,171,120,33,8,86,100,201,51,138,217,101,150,241,170,84,83,100,95,239,137,218,113,241,148,62,240,165,17,137,147,100,68,255,89,95,255,53,191,231,202,170,117,10,187,82,89,65,178,167,71,254,50,42,183,44,248,174,239,139,19,227,165,18,156,45,24,37,165,250,120,93,139,45,122,231,221,187,140,25,247,100,215,113,240,253,51,176,222,227,13,105,148,28,231,235,42,204,169,204,176,200,13,63,24,63,212,116,61,194,208,243,68,54,62,94,174,49,213,8,40,81,145,190,201,30,60,79,181,228,45,223,86,91,155,20,64,41,201,14,53,57,102,143,99,200,167,160,4,155,230,40,18,34,139,166,240,154,89,172,231,221,36,155,34,32,9,34,233,15,252,200,128,125,133,153,36,154,125,71,115,85,204,209,239,127,156,232,183,149,48,202,180,21,250,181,32,116,93,168,57,58,59,55,212,13,207,49,107,168,134,121,169,246,90,95,180,197,121,14,137,51,71,39,246,103,109,97,92,66,102,88,123,162,130,230,196,28,207,102,43,170,110,140,238,171,189,14,42,0,103,213,78,130,67,162,221,247,37,227,32,66,182,116,108,41,0,140,183,120,207,43,53,0,197,229,135,165,26,108,2,154,195,197,141,136,185,62,200,169,32,222,168,103,34,20,205,48,243,20,185,101,120,239,157,114,137,40,45,209,65,21,157,158,156,252,102,79,152,81,10,215,174,40,120,110,46,12,106,32,162,115,100,126,145,62,62,24,254,227,110,27,191,65,184,9,121,10,122,226,198,114,67,134,35,151,77,35,148,47,186,68,175,42,165,120,41,71,200,11,93,139,87,252,165,79,210,152,50,128,18,88,172,112,220,50,66,115,28,218,241,24,183,192,199,134,249,184,208,82,2,174,46,16,189,11,45,147,113,175,27,190,91,252,72,88,140,126,34,159,194,186,235,29,80,50,102,196,49,103,235,52,49,13,235,246,53,246,212,220,131,124,50,151,216,60,170,171,170,211,104,77,80,125,253,105,130,77,11,211,246,72,222,139,173,97,72,1,223,200,208,163,105,51,24,248,244,25,179,138,36,246,170,97,87,48,212,11,93,194,135,41,82,5,149,141,194,219,6,77,243,110,202,39,248,151,254,156,29,245,167,107,253,200,101,131,200,140,229,89,29,149,204,17,95,29,24,63,65,134,181,238,175,233,186,211,155,56,109,135,60,169,241,201,159,188,34,40,35,141,124,16,148,41,42,43,198,26,205,181,159,6,48,127,217,24,102,174,240,198,16,123,85,73,105,198,71,85,14,64,114,122,155,138,66,209,167,63,35,100,188,159,205,2,16,73,11,92,230,140,8,61,122,192,5,64,226,211,147,149,130,41,155,61,165,54,25,175,9,35,107,120,198,117,238,105,81,131,154,230,2,212,122,114,237,66,151,68,93,50,186,214,204,208,240,136,136,146,110,19,0,85,206,30,119,216,110,194,122,216,174,56,215,98,45,149,36,95,19,169,73,167,110,216,152,12,37,170,18,165,3,172,15,114,207,190,184,110,89,25,223,108,121,73,76,153,217,137,249,173,183,126,124,247,8,75,112,2,86,37,200,38,125,66,87,40,238,151,170,203,149,154,15,116,254,98,45,209,154,14,136,192,48,70,67,217,99,27,136,17,210,89,230,109,79,97,128,177,207,144,155,119,68,21,60,143,181,166,232,161,16,124,103,100,108,87,10,236,124,10,86,176,13,126,22,252,101,127,41,244,148,42,212,134,233,5,209,49,5,207,20,108,85,96,243,29,207,117,217,208,50,99,149,27,220,29,3,231,45,64,60,177,87,37,243,193,2,228,24,251,192,205,7,187,144,225,59,76,3,83,192,80,86,240,28,76,72,179,94,196,131,130,58,86,41,195,154,250,229,250,240,191,110,10,179,89,179,43,156,158,35,255,23,253,247,53,162,113,218,84,24,107,58,197,88,145,184,51,109,148,14,215,188,247,193,226,163,101,128,30,217,193,218,17,161,138,108,164,253,255,237,228,123,205,207,254,129,237,212,178,181,201,218,138,214,109,118,11,5,21,45,183,214,196,65,16,235,15,149,182,112,65,112,78,68,143,129,181,223,135,247,85,114,75,202,220,212,138,28,163,215,178,214,148,33,7,108,214,213,134,28,85,144,187,201,25,235,40,37,174,124,15,147,131,102,157,188,127,81,208,74,191,128,217,251,184,139,60,58,242,77,89,3,164,163,29,134,23,147,165,249,16,189,195,37,16,253,103,169,127,123,139,226,184,209,243,215,199,244,43,121,116,153,46,83,221,51,146,229,94,66,36,244,121,122,163,212,214,164,212,139,190,82,8,221,91,220,243,198,14,138,36,253,0,62,57,5,113,24,118,174,14,195,4,97,137,58,103,23,147,142,61,233,101,158,91,122,108,207,193,5,151,128,230,219,39,252,27,199,183,39,198,91,15,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateCreateNewSocialAccountEventParameter());
			Parameters.Add(CreateControlClientIDParameter());
			Parameters.Add(CreateSocialNetworkParameter());
			Parameters.Add(CreateDiscardCreationEventParameter());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateWindowCaptionLocalizableString());
			LocalizableStrings.Add(CreateMessageLocalizableString());
			LocalizableStrings.Add(CreateCreateSocialAccountLocalizableString());
			LocalizableStrings.Add(CreateDoNotCreateAccountLocalizableString());
			LocalizableStrings.Add(CreateDoNotShowMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateWindowCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("bbc7ccfd-b3c5-4f36-a1a6-390804821d0a"),
				Name = "WindowCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("829b799e-c3d4-4a82-a4c5-60f17413f5e2"),
				ModifiedInSchemaUId = new Guid("829b799e-c3d4-4a82-a4c5-60f17413f5e2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f9155726-14f7-4155-9c53-8782c5788b2f"),
				Name = "Message",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("829b799e-c3d4-4a82-a4c5-60f17413f5e2"),
				ModifiedInSchemaUId = new Guid("829b799e-c3d4-4a82-a4c5-60f17413f5e2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCreateSocialAccountLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("128be5b0-ee53-452c-90a6-ef00e7c73ec6"),
				Name = "CreateSocialAccount",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("829b799e-c3d4-4a82-a4c5-60f17413f5e2"),
				ModifiedInSchemaUId = new Guid("829b799e-c3d4-4a82-a4c5-60f17413f5e2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDoNotCreateAccountLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c663dd99-af66-49fa-ab45-7df05fc5e280"),
				Name = "DoNotCreateAccount",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("829b799e-c3d4-4a82-a4c5-60f17413f5e2"),
				ModifiedInSchemaUId = new Guid("829b799e-c3d4-4a82-a4c5-60f17413f5e2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDoNotShowMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f1540ff9-b825-4e64-bea9-e462b727629c"),
				Name = "DoNotShowMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("829b799e-c3d4-4a82-a4c5-60f17413f5e2"),
				ModifiedInSchemaUId = new Guid("829b799e-c3d4-4a82-a4c5-60f17413f5e2")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaParameter CreateCreateNewSocialAccountEventParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("e58eb6ed-d2d8-414f-8c60-38ba05580d44"),
				Name = "CreateNewSocialAccountEvent",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateControlClientIDParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("f0de090e-5938-440c-b958-3818ef3744b3"),
				Name = "ControlClientID",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateSocialNetworkParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("8218e834-ab91-4888-a419-66d5afcbb4ba"),
				Name = "SocialNetwork",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateDiscardCreationEventParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("161f2a76-ee85-4f01-aba7-1f56ae53a0e4"),
				Name = "DiscardCreationEvent",
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
			Methods.Add(CreateUpdateFiltersRightExprMetaDataByParameterValueMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5f4fe2cf-c34c-4266-9956-fb55e5daf2ec"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9bb11a6b-8156-4b51-bef5-c2217878ca4e"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("829b799e-c3d4-4a82-a4c5-60f17413f5e2"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e52c43dc-077e-4918-badf-1b8d1007f510"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("829b799e-c3d4-4a82-a4c5-60f17413f5e2"),
				ModifiedInSchemaUId = new Guid("829b799e-c3d4-4a82-a4c5-60f17413f5e2"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a77fdf89-c6ba-4328-b6f1-205406f9a81f"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("829b799e-c3d4-4a82-a4c5-60f17413f5e2"),
				ModifiedInSchemaUId = new Guid("829b799e-c3d4-4a82-a4c5-60f17413f5e2"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,113,47,205,76,209,81,40,46,41,202,204,75,183,211,208,180,6,0,179,24,102,192,38,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("fe163218-85e9-441f-840d-9711dfed573a"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("829b799e-c3d4-4a82-a4c5-60f17413f5e2"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("56a6a8f2-68d0-4905-8d54-3abdf8c81e15"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("829b799e-c3d4-4a82-a4c5-60f17413f5e2"),
				ModifiedInSchemaUId = new Guid("829b799e-c3d4-4a82-a4c5-60f17413f5e2"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,74,44,78,213,115,206,207,45,200,73,45,73,117,173,72,77,46,45,201,204,75,215,40,72,44,74,204,5,138,20,21,107,90,3,0,145,9,166,203,42,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateFiltersRightExprMetaDataByParameterValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("93bf62ab-5c93-4900-8a70-5573fb3e9364"),
				Name = "UpdateFiltersRightExprMetaDataByParameterValue",
				CreatedInSchemaUId = new Guid("829b799e-c3d4-4a82-a4c5-60f17413f5e2"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void",
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("529fb192-10bb-4452-a399-cf9646b1c0d3"),
				Name = "process",
				CreatedInSchemaUId = new Guid("829b799e-c3d4-4a82-a4c5-60f17413f5e2"),
				ModifiedInSchemaUId = new Guid("829b799e-c3d4-4a82-a4c5-60f17413f5e2"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Process",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("70215329-81a4-4a9b-bf7c-9bebebbf4d30"),
				Name = "filters",
				CreatedInSchemaUId = new Guid("829b799e-c3d4-4a82-a4c5-60f17413f5e2"),
				ModifiedInSchemaUId = new Guid("829b799e-c3d4-4a82-a4c5-60f17413f5e2"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DataSourceFilterCollection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,82,77,79,194,48,24,62,143,95,81,47,164,75,76,131,94,9,38,130,31,39,18,2,234,197,120,168,227,133,53,217,218,165,125,75,36,102,255,221,118,237,134,130,34,122,235,250,62,95,125,246,174,148,6,158,229,132,110,184,38,43,81,32,104,34,100,60,153,148,188,247,18,177,34,180,157,24,114,195,145,47,148,213,25,220,53,119,19,85,20,144,161,80,178,1,39,143,213,146,99,156,153,185,88,231,120,251,86,233,41,32,247,204,241,118,198,53,47,193,13,159,120,97,129,86,90,101,96,204,57,161,71,132,131,123,58,116,242,153,146,40,164,5,119,174,147,94,226,83,47,59,98,76,57,58,20,139,18,195,240,154,125,6,235,114,186,40,206,144,140,70,68,218,162,8,47,250,108,121,26,159,61,108,43,240,34,251,49,118,16,143,96,19,107,80,149,193,229,68,205,223,36,187,122,125,89,39,101,237,24,134,77,148,149,232,115,95,134,76,77,189,85,55,119,238,127,80,27,182,2,238,147,207,56,230,142,190,211,122,190,120,97,205,6,52,176,111,238,61,58,236,6,187,7,252,186,53,227,237,52,106,82,106,80,11,185,78,91,147,116,79,143,205,161,84,27,184,70,58,104,70,245,79,181,44,236,107,92,90,114,22,254,62,233,247,15,223,187,131,197,182,174,200,32,150,245,223,205,63,226,209,70,174,123,245,7,22,168,67,142,169,3,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CreateNewAccountQuestionUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("829b799e-c3d4-4a82-a4c5-60f17413f5e2"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new CreateNewAccountQuestionUserTask(userConnection) {
				SchemaUId = new Guid("829b799e-c3d4-4a82-a4c5-60f17413f5e2")
			};
		}

		#endregion

	}

	#endregion

	#region Class: CreateNewAccountQuestionUserTask

	[DesignModeProperty(Name = "CreateNewSocialAccountEvent", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "829b799ec3d44a82a4c560f17413f5e2", CaptionResourceItem = "Parameters.CreateNewSocialAccountEvent.Caption", DescriptionResourceItem = "Parameters.CreateNewSocialAccountEvent.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ControlClientID", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "829b799ec3d44a82a4c560f17413f5e2", CaptionResourceItem = "Parameters.ControlClientID.Caption", DescriptionResourceItem = "Parameters.ControlClientID.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "SocialNetwork", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "829b799ec3d44a82a4c560f17413f5e2", CaptionResourceItem = "Parameters.SocialNetwork.Caption", DescriptionResourceItem = "Parameters.SocialNetwork.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "DiscardCreationEvent", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "829b799ec3d44a82a4c560f17413f5e2", CaptionResourceItem = "Parameters.DiscardCreationEvent.Caption", DescriptionResourceItem = "Parameters.DiscardCreationEvent.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class CreateNewAccountQuestionUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public CreateNewAccountQuestionUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("829b799e-c3d4-4a82-a4c5-60f17413f5e2");
		}

		#endregion

		#region Properties: Public

		public virtual string CreateNewSocialAccountEvent {
			get;
			set;
		}

		public virtual string ControlClientID {
			get;
			set;
		}

		public virtual string SocialNetwork {
			get;
			set;
		}

		public virtual string DiscardCreationEvent {
			get;
			set;
		}

		private LocalizableString _windowCaption;
		public LocalizableString WindowCaption {
			get {
				return _windowCaption ?? (_windowCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "LocalizableStrings.WindowCaption.Value"));
			}
		}

		private LocalizableString _message;
		public LocalizableString Message {
			get {
				return _message ?? (_message = new LocalizableString(Storage, Schema.GetResourceManagerName(), "LocalizableStrings.Message.Value"));
			}
		}

		private LocalizableString _createSocialAccount;
		public LocalizableString CreateSocialAccount {
			get {
				return _createSocialAccount ?? (_createSocialAccount = new LocalizableString(Storage, Schema.GetResourceManagerName(), "LocalizableStrings.CreateSocialAccount.Value"));
			}
		}

		private LocalizableString _doNotCreateAccount;
		public LocalizableString DoNotCreateAccount {
			get {
				return _doNotCreateAccount ?? (_doNotCreateAccount = new LocalizableString(Storage, Schema.GetResourceManagerName(), "LocalizableStrings.DoNotCreateAccount.Value"));
			}
		}

		private LocalizableString _doNotShowMessage;
		public LocalizableString DoNotShowMessage {
			get {
				return _doNotShowMessage ?? (_doNotShowMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "LocalizableStrings.DoNotShowMessage.Value"));
			}
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			var script = @"
			Terrasoft.CustomMessage = function() {
				var windowCaption = '" + WindowCaption + @"';
				var msg = '" + Message + @"';
				var radio1Caption = '" + string.Format(CreateSocialAccount, SocialNetwork.ToString()) + @"';
				var radio2Caption = '" + DoNotCreateAccount + @"';
				var checkboxCaption = '" + DoNotShowMessage + @"';
			
				var controlClientID = '" + ControlClientID + @"';
				var createNewSocialAccountEventName = '" + CreateNewSocialAccountEvent + @"';
				var discardCreationEventName = '" + DiscardCreationEvent + @"';
			
				var showMessageAgain = true;
				var createNewAccount = true;
			
				var popupWindow = new Terrasoft.Window({
					name: 'rrc',
					caption: windowCaption, 
					resizable: false,
					width: 480,
					frame: true,
					height: 250,
					modal: true,
					frameStyle: 'padding: 0 0 0 0',
					closeAction: 'hide',
					//fitHeightByContent: true
				});
			
				function create () {
					var mainLayout = new Terrasoft.ControlLayout({
						id: 'mainLayout',
						direction: 'vertical',
						displayStyle: 'controls',
						width: '100%',
						layoutConfig: {
							padding: '5 5 5 5'
						},
						fitHeightByContent: true
					});
					popupWindow.add(mainLayout);
					addMessage(mainLayout);
					addRadioButtons(mainLayout);
					addCheckBox(mainLayout);
					var l = addButton(popupWindow);
				}
			
				function addMessage(mainLayout){
					var layout = insertLayout(mainLayout);
					layout.add(new Terrasoft.Label( { caption:msg } ));
				}
			
				function addRadioButtons(mainLayout) {
					var radioLayout = insertLayout(mainLayout);
					var radio = new Terrasoft.Radio({
						caption: radio1Caption,
						name: 'radio',
						checked: true
					});
					radio.on('check', function(o,value){
						createNewAccount = value; 
					}, this);
					radioLayout.add(radio);
			
					radio = new Terrasoft.Radio({
						caption: radio2Caption,
						name: 'radio'
					});
					radioLayout.add(radio);
				}
			
				function addCheckBox(mainLayout) {
					var checkBoxLayout = insertLayout(mainLayout);
					var checkbox = new Terrasoft.CheckBox({
						caption: checkboxCaption,
						name: 'checkbox'
					});
					checkbox.on('check', function(o,value){
						showMessageAgain = value; 
					}, this, null);
					checkBoxLayout.add(checkbox);
				}
			
				function addButton(mainLayout) {
					var layout = insertLayout(mainLayout);
					var btn = new Terrasoft.Button({ caption: 'OK' });
				//	btn.handler = this.onOkButtonClick.createDelegate(this);
					btn.on('click', onOkButtonClick);
					layout.setAlign('center')
					layout.add(btn);
				//	layout.displayStyle = 'footer';
					layout.edges = '1 0 0 0';
					return layout;
				}
			
				function onOkButtonClick(){
					var component = window[controlClientID];
					var signalName;
					if (createNewAccount){
						signalName = createNewSocialAccountEventName;
					} else {
						signalName = discardCreationEventName;
					}
					component.callPageMethod(
						'ThrowEvent',
							{
								formProxyArg: 'htmlForm',
								viewStateMode: 'include',
								signalName: signalName,
								showMessageAgain: showMessageAgain,
								createNewAccount: createNewAccount
							},	
						null
					);
					popupWindow.close();
				}
			
				function insertLayout(mainLayout) {
					var layout = new Terrasoft.ControlLayout({
						direction: 'vertical',
						displayStyle: 'controls',
						width: '100%',
						layoutConfig: {
							//padding: '15 15 15 15'
							padding: '5 5 5 5'
						},
						fitHeightByContent: true
					});
					mainLayout.add(layout);
					return layout;
				}
			
				return {
					show: function() {
						create();
						var mainLayout = popupWindow.items.items[0];
						var l = popupWindow.items.items[1];
						popupWindow.show();
						var height = mainLayout.getHeight() + popupWindow.header.getHeight() + l.getHeight();
						popupWindow.suspendEvents();
						popupWindow.setHeight(height);
						popupWindow.resumeEvents();
						popupWindow.doLayout(true);
					}
				}
			}();
			
			Ext.onReady(function() {
				 Terrasoft.CustomMessage.show();
			});
			";
			ScriptManager scriptManager = ((Terrasoft.UI.WebControls.Page)System.Web.HttpContext.Current.CurrentHandler).FindControl("ScriptManager") as ScriptManager;
			scriptManager.AddScript(script);
			return true;
		}

		#endregion

		#region Methods: Public

		public override bool CompleteExecuting(params object[] parameters) {
			return base.CompleteExecuting(parameters);
		}

		public virtual void UpdateFiltersRightExprMetaDataByParameterValue(Process process, DataSourceFilterCollection filters) {
			foreach (var filter in filters) {
				if (filter is DataSourceFilterCollection) {
					UpdateFiltersRightExprMetaDataByParameterValue(process, (DataSourceFilterCollection)filter);
					continue;
				}	
				var dataSourcefilter = (DataSourceFilter)filter;
				if (dataSourcefilter.RightExpression == null) {
					continue;
				}
				if (dataSourcefilter.RightExpression.Type == DataSourceFilterExpressionType.Custom) {
					dataSourcefilter.RightExpression.Type = DataSourceFilterExpressionType.Parameter;
					if (dataSourcefilter.RightExpression.Parameters.Count == 2) {
						var parameters = dataSourcefilter.RightExpression.Parameters;
						var metaPath = parameters[1].Value;
						parameters[1].Value = process.GetParameterValueByMetaPath((string)metaPath);
						parameters.RemoveAt(0);
					}
					if (dataSourcefilter.SubFilters != null && dataSourcefilter.SubFilters.Count > 0) {
						UpdateFiltersRightExprMetaDataByParameterValue(process, dataSourcefilter.SubFilters);
					}
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
			if (!HasMapping("CreateNewSocialAccountEvent")) {
				writer.WriteValue("CreateNewSocialAccountEvent", CreateNewSocialAccountEvent, null);
			}
			if (!HasMapping("ControlClientID")) {
				writer.WriteValue("ControlClientID", ControlClientID, null);
			}
			if (!HasMapping("SocialNetwork")) {
				writer.WriteValue("SocialNetwork", SocialNetwork, null);
			}
			if (!HasMapping("DiscardCreationEvent")) {
				writer.WriteValue("DiscardCreationEvent", DiscardCreationEvent, null);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "CreateNewSocialAccountEvent":
					CreateNewSocialAccountEvent = reader.GetStringValue();
				break;
				case "ControlClientID":
					ControlClientID = reader.GetStringValue();
				break;
				case "SocialNetwork":
					SocialNetwork = reader.GetStringValue();
				break;
				case "DiscardCreationEvent":
					DiscardCreationEvent = reader.GetStringValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

