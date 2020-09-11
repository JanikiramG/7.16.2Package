namespace Terrasoft.Core.Process.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.UI.WebControls.Controls;

	#region Class: QuestionUserTaskSchema

	/// <exclude/>
	public class QuestionUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public QuestionUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public QuestionUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab");
			RealUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab");
			Name = "QuestionUserTask";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,88,221,114,218,58,16,190,134,167,80,125,81,236,9,163,7,8,39,103,74,8,109,221,158,64,202,79,51,157,158,94,8,35,138,91,199,246,145,228,18,154,241,187,159,93,73,14,182,113,66,73,103,50,83,102,2,227,213,234,219,111,255,172,85,94,57,82,137,48,254,74,22,153,82,73,44,223,201,169,126,238,181,173,60,12,146,120,79,120,195,165,100,95,249,121,114,107,22,200,25,113,156,225,173,162,151,247,11,142,115,175,189,228,43,150,69,234,220,88,208,186,227,247,187,245,207,95,106,26,125,33,216,22,212,238,64,49,249,238,56,36,175,67,249,64,74,227,248,163,215,227,125,75,150,133,214,184,48,162,15,25,151,42,76,98,187,132,123,126,48,65,82,163,118,133,63,76,146,25,7,211,50,89,41,58,247,233,53,95,12,146,88,137,36,146,20,21,166,193,154,223,176,185,228,194,138,123,237,112,69,92,139,56,227,183,138,156,157,145,56,139,34,143,220,181,91,130,171,76,196,100,197,34,201,123,237,92,235,94,137,36,0,117,63,150,138,197,1,247,151,197,14,242,242,165,225,242,162,132,128,4,195,146,42,113,221,71,9,122,136,64,251,50,213,15,116,103,133,206,18,147,39,215,235,181,91,13,36,202,102,78,52,17,13,136,232,44,140,185,160,243,56,252,47,227,254,5,58,130,180,4,151,41,100,138,91,231,49,169,147,186,8,226,121,17,6,24,116,38,182,127,153,12,117,137,249,253,219,196,110,31,166,18,192,61,27,49,223,52,96,90,72,116,46,39,109,155,87,193,110,184,226,66,218,236,94,237,4,205,188,146,197,55,30,40,203,171,188,189,196,168,130,218,204,165,192,41,200,32,218,11,179,70,125,57,2,164,177,24,222,164,106,235,218,98,247,52,178,220,132,42,88,147,123,33,202,90,1,147,220,246,202,41,60,182,52,86,61,42,212,38,73,190,231,91,215,244,139,129,132,207,158,110,127,185,180,58,221,90,175,96,97,180,90,57,126,213,222,4,224,234,94,187,159,0,45,10,141,121,66,44,97,189,123,33,56,251,222,43,19,31,244,71,131,225,63,207,75,255,87,204,4,88,235,209,97,83,133,222,115,68,235,211,112,58,26,31,17,170,45,151,135,29,208,74,191,25,172,56,57,108,7,117,158,45,72,71,87,213,159,20,170,63,174,124,45,180,78,198,42,1,41,190,199,42,67,5,156,46,77,39,124,65,254,176,199,6,230,222,219,102,119,141,82,179,171,198,215,227,29,174,178,174,248,157,195,235,157,195,209,142,156,158,224,246,177,78,31,235,114,142,12,127,207,217,252,145,195,11,7,176,234,201,165,37,229,99,203,140,102,167,59,193,117,127,50,242,71,111,42,178,15,243,225,116,230,143,71,21,225,112,50,25,79,64,2,110,235,142,40,77,160,143,123,128,28,154,139,243,104,168,210,160,249,64,218,1,240,137,112,185,153,81,86,89,172,167,135,2,225,60,11,163,37,23,118,180,168,200,112,154,120,64,157,246,211,148,199,216,237,133,130,187,80,152,9,120,61,0,95,109,41,148,243,52,74,24,14,122,118,28,173,14,57,181,215,139,111,213,1,193,204,165,133,222,231,242,218,151,202,172,90,50,225,46,146,36,242,30,218,165,221,183,13,227,130,189,143,44,202,96,58,11,69,125,66,172,207,152,216,78,245,46,240,176,249,14,197,5,125,133,144,224,36,215,209,201,168,161,80,96,1,82,243,106,209,31,199,233,128,83,155,48,94,38,27,186,27,185,251,223,216,237,37,87,235,100,41,233,108,45,146,205,32,10,121,172,134,63,224,203,53,208,37,144,253,49,27,203,161,211,109,230,160,195,96,53,72,7,254,238,118,89,59,37,122,203,59,153,196,116,202,69,200,162,240,39,119,139,101,79,239,34,185,215,179,149,169,19,159,31,174,151,39,57,216,228,85,187,20,183,110,167,249,194,213,1,122,185,102,118,173,173,14,88,138,171,80,46,111,184,178,15,88,229,211,64,132,169,186,100,49,236,17,68,86,158,76,185,21,197,139,23,183,82,1,214,85,15,221,149,166,91,169,248,13,202,233,91,165,82,92,132,27,28,29,100,66,128,183,197,239,91,22,47,35,46,60,250,26,88,91,0,8,93,133,37,182,9,220,41,42,178,94,233,116,168,51,211,215,43,240,26,66,153,114,161,76,7,252,34,104,187,2,134,135,128,209,112,235,215,111,106,95,70,54,109,149,160,151,174,131,149,154,44,221,100,75,42,116,194,211,136,5,200,176,131,163,196,43,199,249,183,131,244,204,86,220,185,127,208,224,154,94,170,252,255,160,36,126,168,58,107,212,186,68,173,67,233,245,116,229,216,27,181,18,25,239,57,255,3,153,58,165,157,185,16,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreatePageParameter());
			Parameters.Add(CreateIconParameter());
			Parameters.Add(CreateButtonsParameter());
			Parameters.Add(CreateWindowCaptionParameter());
			Parameters.Add(CreateMessageTextParameter());
			Parameters.Add(CreateResponseMessagesParameter());
			Parameters.Add(CreateProcessInstanceIdParameter());
			Parameters.Add(CreatePageParametersParameter());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateInfoCaptionLocalizableString());
			LocalizableStrings.Add(CreateWarningCaptionLocalizableString());
			LocalizableStrings.Add(CreateQuestionCaptionLocalizableString());
			LocalizableStrings.Add(CreateErrorCaptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateInfoCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b04c5130-5068-4412-ba00-04d5416b7853"),
				Name = "InfoCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateWarningCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("67c25ca1-2f4f-4f32-b1e2-4c5ef49e1393"),
				Name = "WarningCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateQuestionCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2f6ae593-3336-4297-9ab2-88685d9ffdb0"),
				Name = "QuestionCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateErrorCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("9bb41dfa-4b44-41ac-b707-d26c2c87153e"),
				Name = "ErrorCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaParameter CreatePageParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("fc3525ab-020c-428b-8d32-e932d9ea90ea"),
				Name = "Page",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateIconParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("d9e20c9f-b695-4d5d-a9fe-9babb13a35f3"),
				Name = "Icon",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateButtonsParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("86587788-849f-40f5-9cdc-5067919b87d4"),
				Name = "Buttons",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateWindowCaptionParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("2622a34b-e1f4-4cff-976d-0860689313f2"),
				Name = "WindowCaption",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateMessageTextParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("9075bde7-df39-40cb-b7d5-1d52caec1667"),
				Name = "MessageText",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateResponseMessagesParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("dd8c12d4-5a31-48fe-8dde-3c3ab9613241"),
				Name = "ResponseMessages",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateProcessInstanceIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("22959a44-91d5-4450-a1fa-414fb8eefcd2"),
				Name = "ProcessInstanceId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreatePageParametersParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("224d566c-d537-48ad-9421-3d10efdb001c"),
				Name = "PageParameters",
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
			Methods.Add(CreateGetCaptionMethod());
			Methods.Add(CreateUpdateFiltersRightExprMetaDataByParameterValueMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("dd16e8cb-cb0c-4009-8f79-9128047ba404"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f271e3be-ed6e-4b9c-83b9-df4cb30bae47"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f90400ed-2a55-404e-8bd3-9b68008ff1be"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateGetCaptionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a1b81ff4-5bb7-4cbe-bc6d-946111776fe2"),
				Name = "GetCaption",
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,143,65,14,130,48,16,69,215,244,20,133,21,108,60,128,132,133,49,104,186,41,1,52,172,107,5,109,212,150,76,139,198,24,238,110,33,26,4,195,174,51,243,223,127,169,168,176,95,8,121,84,143,53,171,141,80,18,187,17,150,205,245,26,188,144,35,236,209,213,6,132,60,45,136,166,118,155,64,124,171,205,115,140,44,118,42,239,67,126,16,116,152,3,165,105,64,226,81,40,68,78,139,90,116,103,128,249,199,20,97,207,11,81,39,33,188,27,7,241,167,128,127,209,22,233,135,48,252,220,7,127,117,54,203,153,46,177,71,232,38,241,150,214,61,148,19,89,169,65,238,28,160,100,151,240,155,47,86,25,37,116,59,65,10,6,210,22,207,82,233,62,206,119,36,161,19,44,109,74,221,61,103,185,56,203,146,108,2,197,0,10,254,137,22,77,62,255,6,151,254,129,5,162,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateFiltersRightExprMetaDataByParameterValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f97d5027-ba90-41da-8fa6-c2e52f766f15"),
				Name = "UpdateFiltersRightExprMetaDataByParameterValue",
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void",
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c8fab05e-f44c-487f-b4d9-5c72b6d8ba40"),
				Name = "process",
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Process",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e28b5ec6-7f01-494c-ac3f-4fc9e118b7e9"),
				Name = "filters",
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
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
			return new QuestionUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new QuestionUserTask(userConnection) {
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab")
			};
		}

		#endregion

	}

	#endregion

	#region Class: QuestionUserTask

	[DesignModeProperty(Name = "Page", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "496a664f3aab43d7ab1b2521ab601aab", CaptionResourceItem = "Parameters.Page.Caption", DescriptionResourceItem = "Parameters.Page.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Icon", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "496a664f3aab43d7ab1b2521ab601aab", CaptionResourceItem = "Parameters.Icon.Caption", DescriptionResourceItem = "Parameters.Icon.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Buttons", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "496a664f3aab43d7ab1b2521ab601aab", CaptionResourceItem = "Parameters.Buttons.Caption", DescriptionResourceItem = "Parameters.Buttons.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "WindowCaption", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "496a664f3aab43d7ab1b2521ab601aab", CaptionResourceItem = "Parameters.WindowCaption.Caption", DescriptionResourceItem = "Parameters.WindowCaption.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "MessageText", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "496a664f3aab43d7ab1b2521ab601aab", CaptionResourceItem = "Parameters.MessageText.Caption", DescriptionResourceItem = "Parameters.MessageText.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ResponseMessages", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "496a664f3aab43d7ab1b2521ab601aab", CaptionResourceItem = "Parameters.ResponseMessages.Caption", DescriptionResourceItem = "Parameters.ResponseMessages.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ProcessInstanceId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "496a664f3aab43d7ab1b2521ab601aab", CaptionResourceItem = "Parameters.ProcessInstanceId.Caption", DescriptionResourceItem = "Parameters.ProcessInstanceId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "PageParameters", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "496a664f3aab43d7ab1b2521ab601aab", CaptionResourceItem = "Parameters.PageParameters.Caption", DescriptionResourceItem = "Parameters.PageParameters.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class QuestionUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public QuestionUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab");
		}

		#endregion

		#region Properties: Public

		public virtual Object Page {
			get;
			set;
		}

		public virtual string Icon {
			get;
			set;
		}

		public virtual string Buttons {
			get;
			set;
		}

		public virtual string WindowCaption {
			get;
			set;
		}

		public virtual string MessageText {
			get;
			set;
		}

		public virtual Object ResponseMessages {
			get;
			set;
		}

		public virtual string ProcessInstanceId {
			get;
			set;
		}

		public virtual Object PageParameters {
			get;
			set;
		}

		private LocalizableString _infoCaption;
		public LocalizableString InfoCaption {
			get {
				return _infoCaption ?? (_infoCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "LocalizableStrings.InfoCaption.Value"));
			}
		}

		private LocalizableString _warningCaption;
		public LocalizableString WarningCaption {
			get {
				return _warningCaption ?? (_warningCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "LocalizableStrings.WarningCaption.Value"));
			}
		}

		private LocalizableString _questionCaption;
		public LocalizableString QuestionCaption {
			get {
				return _questionCaption ?? (_questionCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "LocalizableStrings.QuestionCaption.Value"));
			}
		}

		private LocalizableString _errorCaption;
		public LocalizableString ErrorCaption {
			get {
				return _errorCaption ?? (_errorCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "LocalizableStrings.ErrorCaption.Value"));
			}
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			string buttonsJsString;
			string iconJsString;
			string messageBoxString = "Ext.MessageBox";
			string defaultButtons = "OK";
			string[] defaultButtonsArray = { "ok" };
			string defaultIcon = "INFO";
			string defaultMessage = "DefaultQuestionMessage";
			var page = Page as Terrasoft.UI.WebControls.PageSchemaUserControl;
			if (MessageText == null) {
				return false;
			}
			if (ProcessInstanceId == null && page != null) {
				var instanceId = ((Terrasoft.UI.WebControls.Page)page.AspPage).InstanceId.ToString();
				ProcessInstanceId = instanceId + page.PageContainer.UniqueID;
			}
			var responseMessages = ResponseMessages as Dictionary<string, string>;
			if (responseMessages == null) {
				responseMessages = new Dictionary<string,string>();
			} 
			
			var parameters = PageParameters as Dictionary<string, object>;
			if (parameters == null) {
				parameters = new Dictionary<string, object>();
			} 
			
			if (!string.IsNullOrEmpty(Buttons)) {
				switch (Buttons) {
					case "OK":
						if (!responseMessages.ContainsKey("ok")) {
							responseMessages.Add("ok", defaultMessage);
						}
						buttonsJsString = messageBoxString + "." + Buttons;
						break;
					case "OKCANCEL":
						if (!responseMessages.ContainsKey("ok")) {
							responseMessages.Add("ok", defaultMessage);
						}
						if (!responseMessages.ContainsKey("cancel")) {
							responseMessages.Add("cancel", defaultMessage);
						}
						buttonsJsString = messageBoxString + "." + Buttons;
						break;
					case "YESNO":
						if (!responseMessages.ContainsKey("yes")) {
							responseMessages.Add("yes", defaultMessage);
						}
						if (!responseMessages.ContainsKey("no")) {
							responseMessages.Add("no", defaultMessage);
						}
						buttonsJsString = messageBoxString + "." + Buttons;
						break;
					case "YESNOCANCEL":
						if (!responseMessages.ContainsKey("yes")) {
							responseMessages.Add("yes", defaultMessage);
						}
						if (!responseMessages.ContainsKey("no")) {
							responseMessages.Add("no", defaultMessage);
						}
						if (!responseMessages.ContainsKey("cancel")) {
							responseMessages.Add("cancel", defaultMessage);
						}
						buttonsJsString = messageBoxString + "." + Buttons;
						break;
					default:
						foreach (string button in defaultButtonsArray) {
							if (!responseMessages.ContainsKey(button)) {
								responseMessages.Add(button, defaultMessage);
							}
						}
						buttonsJsString = messageBoxString + "." + defaultButtons;
						break;
				}
			} else {
				foreach (string button in defaultButtonsArray) {
					if (!responseMessages.ContainsKey(button)) {
						responseMessages.Add(button, defaultMessage);
					}
				}
				buttonsJsString = messageBoxString + "." + defaultButtons;
			}
			if (!string.IsNullOrEmpty(Icon)) {
				switch (Icon) {
					case "INFO":
					case "WARNING":
					case "QUESTION":
					case "ERROR":			
						iconJsString = messageBoxString + "." + Icon;
						break;
					default:			
						iconJsString = messageBoxString + "." + defaultIcon;
						break;
				}
			} else {	
				iconJsString = messageBoxString + "." + defaultIcon;
			}
			
			var functionJsStringBuilder = new StringBuilder();
			functionJsStringBuilder.Append("function(btn) {");
				
			var isUpload = false;
			if (parameters.ContainsKey("IsUpload") && parameters["IsUpload"] != null) {
				isUpload = (bool)parameters["IsUpload"];
			}
			
			foreach(KeyValuePair<string, string> responseMessage in responseMessages){
				functionJsStringBuilder.Append("if (btn == '" + responseMessage.Key + 
													"') {window.Terrasoft.AjaxMethods.ThrowClientEvent('" + 
													ProcessInstanceId + "','" + responseMessage.Value + "', '', { isUpload : " + Json.Serialize(isUpload) + " });} else ");
			}
			functionJsStringBuilder.Append("{window.Terrasoft.AjaxMethods.ThrowClientEvent('" + ProcessInstanceId + 
											"','DefaultQuestionMessage');}}");
			WindowCaption = GetCaption();
			ScriptManager scriptManager = null;
			if (page == null) {
				scriptManager = ((Terrasoft.UI.WebControls.Page)System.Web.HttpContext.Current.CurrentHandler).FindControl("ScriptManager") as ScriptManager;
			} else {
				scriptManager = page.GetPropertyValue("ScriptManager") as ScriptManager;
			}
			scriptManager.AddScript("Ext.MessageBox.message('" + WindowCaption.ToString() + "','" + MessageText.ToString().Replace("'", @"\'") + "'," +
				buttonsJsString + "," + iconJsString + "," + functionJsStringBuilder.ToString() + ", this);");
			return true;
		}

		#endregion

		#region Methods: Public

		public virtual string GetCaption() {
			if (WindowCaption != null){
				if (!string.IsNullOrEmpty(WindowCaption.ToString())){
					return WindowCaption;
				}
			}
			var caption = "";
			if (Icon == null){
				return caption;
			}
			switch(Icon.ToString()){
				case "INFO":
					caption = InfoCaption;
					break;
				case "WARNING":
					caption = WarningCaption;
					break;
				case "QUESTION":
					caption = QuestionCaption;
					break;
				case "ERROR":
					caption = ErrorCaption;
					break;
			}
			return caption;
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
			if (Page != null) {
				if (Page.GetType().IsSerializable || Page.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("Page", Page, null);
				}
			}
			if (!HasMapping("Icon")) {
				writer.WriteValue("Icon", Icon, null);
			}
			if (!HasMapping("Buttons")) {
				writer.WriteValue("Buttons", Buttons, null);
			}
			if (!HasMapping("WindowCaption")) {
				writer.WriteValue("WindowCaption", WindowCaption, null);
			}
			if (!HasMapping("MessageText")) {
				writer.WriteValue("MessageText", MessageText, null);
			}
			if (ResponseMessages != null) {
				if (ResponseMessages.GetType().IsSerializable || ResponseMessages.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ResponseMessages", ResponseMessages, null);
				}
			}
			if (!HasMapping("ProcessInstanceId")) {
				writer.WriteValue("ProcessInstanceId", ProcessInstanceId, null);
			}
			if (PageParameters != null) {
				if (PageParameters.GetType().IsSerializable || PageParameters.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("PageParameters", PageParameters, null);
				}
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "Page":
					Page = reader.GetSerializableObjectValue();
				break;
				case "Icon":
					Icon = reader.GetStringValue();
				break;
				case "Buttons":
					Buttons = reader.GetStringValue();
				break;
				case "WindowCaption":
					WindowCaption = reader.GetStringValue();
				break;
				case "MessageText":
					MessageText = reader.GetStringValue();
				break;
				case "ResponseMessages":
					ResponseMessages = reader.GetSerializableObjectValue();
				break;
				case "ProcessInstanceId":
					ProcessInstanceId = reader.GetStringValue();
				break;
				case "PageParameters":
					PageParameters = reader.GetSerializableObjectValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

