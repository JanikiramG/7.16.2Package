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
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;

	#region Class: OpenPageUserTaskSchema

	/// <exclude/>
	public class OpenPageUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public OpenPageUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public OpenPageUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828");
			RealUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828");
			Name = "OpenPageUserTask";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,24,91,123,218,54,244,217,254,21,170,31,26,187,99,38,219,35,44,109,19,122,9,95,155,38,95,147,180,15,99,15,194,22,65,139,145,153,36,146,176,212,255,125,231,72,50,182,193,144,176,173,15,41,62,58,247,155,206,209,219,160,219,37,87,231,239,206,123,228,35,19,76,82,205,8,123,72,216,92,243,92,16,62,33,231,115,4,95,208,27,70,230,84,210,25,211,76,18,174,136,88,100,153,223,125,229,95,49,41,169,202,39,58,190,30,198,223,217,120,144,11,45,243,76,197,72,114,153,76,217,140,94,43,38,29,24,120,0,163,35,67,221,247,129,125,88,227,255,194,194,35,242,232,123,221,174,100,122,33,5,153,208,76,177,190,239,57,194,112,63,121,81,197,190,239,23,254,171,174,223,237,222,81,73,254,7,110,254,19,142,67,172,235,97,74,168,72,237,111,153,85,30,84,132,74,70,66,52,151,228,146,176,217,92,47,35,131,74,53,81,128,67,52,135,63,198,67,142,81,60,84,239,17,45,140,200,203,151,68,105,201,197,13,192,190,0,139,115,105,79,156,152,8,60,232,249,94,211,129,133,239,163,225,106,140,222,103,247,228,210,48,56,89,240,44,101,50,140,250,24,75,148,6,230,90,43,191,178,27,174,64,213,203,68,242,185,54,65,81,227,248,120,14,135,105,24,4,200,44,89,72,201,132,182,248,192,247,158,139,52,191,143,115,251,237,194,73,222,172,193,123,238,187,63,146,35,17,4,32,186,193,184,193,52,54,231,38,112,117,156,42,108,200,243,187,97,23,26,84,107,227,128,102,217,152,38,183,219,108,117,88,185,152,240,155,93,56,168,191,61,0,172,32,192,207,32,176,71,137,19,81,59,158,44,68,130,209,15,239,69,10,254,122,36,143,135,5,41,138,146,194,90,109,48,1,1,161,152,66,22,10,81,235,25,247,191,216,136,246,134,231,15,54,125,246,141,179,123,36,140,169,154,63,224,177,215,74,2,226,120,218,107,30,117,200,38,187,13,9,165,82,87,185,53,23,180,106,35,241,252,130,48,200,182,39,53,46,19,181,93,238,243,212,172,98,99,4,251,45,216,232,95,83,114,170,215,56,254,221,156,142,115,232,71,92,125,224,82,105,136,138,150,11,214,95,21,220,69,85,169,245,182,52,201,37,163,201,148,132,182,137,172,250,161,32,225,59,110,130,79,229,242,55,91,156,29,87,164,175,163,38,67,195,200,67,65,78,184,5,120,149,42,101,207,243,42,119,122,173,222,240,10,191,121,48,18,35,253,40,64,80,175,196,104,241,111,13,182,50,33,254,196,150,207,192,7,209,45,48,114,71,179,197,254,34,191,33,213,179,132,22,22,86,172,133,121,164,255,176,105,215,22,251,178,205,219,46,126,70,5,252,198,38,229,250,185,96,38,92,241,71,166,27,24,192,225,98,157,10,24,18,170,200,6,188,191,171,100,155,242,65,240,134,50,40,123,40,148,166,34,97,39,75,224,80,214,153,169,95,195,186,162,137,207,232,3,159,241,191,89,106,211,197,180,142,84,79,123,107,206,93,225,127,199,211,170,98,7,139,12,174,3,54,20,147,60,30,10,80,142,83,161,29,48,218,140,178,113,162,231,89,65,83,198,111,166,122,171,164,83,115,252,223,68,249,245,92,111,183,173,94,240,123,171,251,36,177,201,174,149,10,53,13,48,14,198,151,228,53,57,180,190,175,168,247,117,114,205,200,109,186,21,237,141,207,111,88,134,74,89,183,183,105,181,119,64,254,181,90,133,233,177,92,13,224,198,102,210,94,196,61,98,47,72,3,98,41,100,254,160,252,9,69,132,93,247,141,43,156,18,37,62,165,202,54,131,245,155,3,155,178,21,228,52,116,133,177,162,172,200,218,233,218,77,131,187,26,91,108,123,87,169,93,30,92,93,129,186,39,84,126,227,138,143,51,86,191,70,26,238,217,66,143,211,201,80,188,127,128,65,10,240,156,123,182,241,64,130,91,182,36,138,105,196,70,188,114,142,169,55,248,106,148,128,150,109,166,9,28,222,186,100,19,219,98,109,59,13,130,248,182,98,208,118,110,59,177,137,84,235,184,105,71,180,178,131,65,219,114,225,91,231,180,129,215,175,87,218,43,27,209,249,250,6,208,194,40,220,61,175,71,200,35,62,86,115,243,17,87,2,215,230,150,22,206,134,18,201,144,33,229,56,121,94,11,254,215,130,13,223,153,20,129,249,179,216,225,163,182,147,126,121,53,181,5,17,6,64,231,253,85,40,251,141,172,129,171,42,201,114,101,242,0,221,51,128,15,55,152,159,139,207,57,77,183,248,26,153,35,190,27,185,103,96,75,185,91,185,116,32,143,229,36,213,70,59,210,239,31,116,156,241,113,252,254,14,106,44,134,105,118,53,79,110,205,175,86,94,29,114,144,129,158,7,29,178,154,139,65,54,74,24,105,167,29,90,200,194,104,36,138,168,191,75,169,162,214,107,12,13,153,49,165,192,172,222,142,236,52,30,59,179,120,219,50,243,109,16,216,57,129,39,183,167,121,6,29,178,220,122,62,227,95,187,213,172,212,167,90,227,162,166,6,249,66,184,133,136,233,43,216,211,242,133,14,235,70,66,138,105,185,180,99,91,131,232,231,159,49,253,60,116,177,113,111,57,8,216,157,1,60,54,102,56,97,46,68,139,231,144,208,84,74,85,3,199,127,210,135,51,166,167,121,170,226,171,169,204,239,7,25,7,174,134,117,73,97,230,16,96,254,105,45,219,236,225,118,3,240,223,243,36,133,150,123,231,96,91,8,27,145,104,197,128,56,28,68,253,162,67,126,57,140,172,102,56,216,122,133,157,113,97,215,210,201,52,100,229,156,12,62,104,120,149,28,29,29,149,151,32,120,30,213,35,102,124,182,92,182,7,119,45,162,110,160,6,53,126,61,68,61,138,190,191,131,22,85,45,243,178,165,253,87,32,151,157,31,114,57,163,58,108,238,141,157,122,99,174,117,169,237,87,10,191,17,144,33,95,25,244,38,165,135,233,190,55,146,77,128,47,48,129,239,73,184,80,12,192,25,135,88,64,146,92,80,61,221,147,65,98,182,109,191,92,187,235,245,109,59,146,153,112,44,86,207,90,121,33,243,9,207,152,201,152,6,81,211,165,65,208,64,239,193,218,141,146,135,117,32,121,67,202,169,128,224,162,82,222,255,40,119,83,37,219,112,234,49,116,40,107,230,69,85,211,86,230,153,132,208,52,53,61,27,174,53,251,112,82,46,30,170,241,85,127,1,179,111,81,213,205,87,219,161,215,104,204,45,5,75,3,216,52,103,82,47,205,240,3,106,52,36,185,101,165,1,91,189,125,237,214,233,169,251,245,114,9,185,63,67,120,124,170,245,28,15,25,180,178,129,125,177,41,255,63,165,34,205,152,140,226,15,144,107,142,193,243,148,236,118,79,161,14,122,4,174,240,248,11,211,100,10,40,84,16,42,53,159,240,132,211,140,100,176,2,105,146,11,162,167,140,40,216,134,72,62,177,191,53,80,62,225,242,157,198,213,181,61,89,218,246,54,196,145,163,102,52,144,149,47,129,251,185,2,203,96,205,254,142,121,112,104,243,130,77,238,50,161,142,160,67,212,58,131,155,199,96,137,117,34,142,161,105,223,49,19,158,42,101,204,84,135,141,159,61,176,100,161,205,113,245,62,183,26,10,126,252,40,159,226,234,136,49,131,117,62,132,110,78,126,114,74,196,95,217,60,163,9,195,62,61,66,213,241,127,248,17,213,15,14,202,131,131,250,1,150,183,109,3,100,13,44,43,48,1,73,230,6,192,71,49,152,179,234,254,136,143,211,212,58,40,180,112,51,207,214,94,141,203,82,114,207,157,230,25,39,248,7,80,203,124,67,215,22,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreatePageUIdParameter());
			Parameters.Add(CreatePageUrlParameter());
			Parameters.Add(CreateOpenerInstanceIdParameter());
			Parameters.Add(CreateCloseOpenerOnLoadParameter());
			Parameters.Add(CreatePageParametersParameter());
			Parameters.Add(CreateWidthParameter());
			Parameters.Add(CreateCloseMessageParameter());
			Parameters.Add(CreateHeightParameter());
			Parameters.Add(CreateCenteredParameter());
			Parameters.Add(CreateUseOpenerRegisterScriptParameter());
			Parameters.Add(CreateUseCurrentActivePageParameter());
			Parameters.Add(CreateIgnoreProfileParameter());
		}

		protected virtual ProcessSchemaParameter CreatePageUIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("c8d5a132-343c-4f79-9be3-2fe7cea76c01"),
				Name = "PageUId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreatePageUrlParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("a9324665-fef3-4e2d-bdc7-b4f1a543c4b3"),
				Name = "PageUrl",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateOpenerInstanceIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("4996422d-0ee5-46c6-a0a2-d5b880901719"),
				Name = "OpenerInstanceId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateCloseOpenerOnLoadParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("91a2a154-8e2c-410c-a2ac-cc99518967ca"),
				Name = "CloseOpenerOnLoad",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
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
				UId = new Guid("c48d11b9-261e-4a0b-a707-1b516af36423"),
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

		protected virtual ProcessSchemaParameter CreateWidthParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("370593df-5c54-4fb2-a074-384dbecff3f3"),
				Name = "Width",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateCloseMessageParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("3a6ce3c6-a64e-4c8a-8b28-02a9cab8826c"),
				Name = "CloseMessage",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateHeightParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("04715043-2084-41fc-9b86-86271ee5bc3f"),
				Name = "Height",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateCenteredParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("b4dabd0d-277f-4485-b54f-7e44fe827817"),
				Name = "Centered",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateUseOpenerRegisterScriptParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("0ecb46e8-ff3f-44d8-b918-293844df721f"),
				Name = "UseOpenerRegisterScript",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateUseCurrentActivePageParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("912d1a93-f827-4a4a-9758-272811e7f619"),
				Name = "UseCurrentActivePage",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateIgnoreProfileParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("c1a10f11-3802-4172-98e7-44a11aeb3eb1"),
				Name = "IgnoreProfile",
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
			Methods.Add(CreateUpdateFiltersRightExprMetaDataByParameterValueMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c3f95963-044c-4e17-8b9b-f361b752ce9f"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("465c78b2-1d66-4ed4-9127-4be6deaaff1b"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("83624c49-6b40-4f86-a4ef-3014861e6a44"),
				Name = "System.Globalization",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("70f5028e-f28d-4056-9a18-493a85b09946"),
				Name = "Terrasoft.UI.WebControls",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateUpdateFiltersRightExprMetaDataByParameterValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8cd5d187-efd6-451f-b14d-5fa7f1a6657e"),
				Name = "UpdateFiltersRightExprMetaDataByParameterValue",
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void",
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("71ba3987-40ac-4c4e-9ef1-96e2c300d4b1"),
				Name = "process",
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Process",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f1574df0-2016-4535-b18c-176ef6143695"),
				Name = "filters",
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
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
			return new OpenPageUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new OpenPageUserTask(userConnection) {
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828")
			};
		}

		#endregion

	}

	#endregion

	#region Class: OpenPageUserTask

	[DesignModeProperty(Name = "PageUId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b7042ef4f468443eb3ea39ebbda1c828", CaptionResourceItem = "Parameters.PageUId.Caption", DescriptionResourceItem = "Parameters.PageUId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "PageUrl", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b7042ef4f468443eb3ea39ebbda1c828", CaptionResourceItem = "Parameters.PageUrl.Caption", DescriptionResourceItem = "Parameters.PageUrl.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "OpenerInstanceId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b7042ef4f468443eb3ea39ebbda1c828", CaptionResourceItem = "Parameters.OpenerInstanceId.Caption", DescriptionResourceItem = "Parameters.OpenerInstanceId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "CloseOpenerOnLoad", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b7042ef4f468443eb3ea39ebbda1c828", CaptionResourceItem = "Parameters.CloseOpenerOnLoad.Caption", DescriptionResourceItem = "Parameters.CloseOpenerOnLoad.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "PageParameters", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b7042ef4f468443eb3ea39ebbda1c828", CaptionResourceItem = "Parameters.PageParameters.Caption", DescriptionResourceItem = "Parameters.PageParameters.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Width", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b7042ef4f468443eb3ea39ebbda1c828", CaptionResourceItem = "Parameters.Width.Caption", DescriptionResourceItem = "Parameters.Width.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "CloseMessage", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b7042ef4f468443eb3ea39ebbda1c828", CaptionResourceItem = "Parameters.CloseMessage.Caption", DescriptionResourceItem = "Parameters.CloseMessage.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Height", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b7042ef4f468443eb3ea39ebbda1c828", CaptionResourceItem = "Parameters.Height.Caption", DescriptionResourceItem = "Parameters.Height.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Centered", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b7042ef4f468443eb3ea39ebbda1c828", CaptionResourceItem = "Parameters.Centered.Caption", DescriptionResourceItem = "Parameters.Centered.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "UseOpenerRegisterScript", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b7042ef4f468443eb3ea39ebbda1c828", CaptionResourceItem = "Parameters.UseOpenerRegisterScript.Caption", DescriptionResourceItem = "Parameters.UseOpenerRegisterScript.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "UseCurrentActivePage", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b7042ef4f468443eb3ea39ebbda1c828", CaptionResourceItem = "Parameters.UseCurrentActivePage.Caption", DescriptionResourceItem = "Parameters.UseCurrentActivePage.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "IgnoreProfile", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b7042ef4f468443eb3ea39ebbda1c828", CaptionResourceItem = "Parameters.IgnoreProfile.Caption", DescriptionResourceItem = "Parameters.IgnoreProfile.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class OpenPageUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public OpenPageUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828");
		}

		#endregion

		#region Properties: Public

		public virtual Guid PageUId {
			get;
			set;
		}

		public virtual string PageUrl {
			get;
			set;
		}

		public virtual string OpenerInstanceId {
			get;
			set;
		}

		public virtual bool CloseOpenerOnLoad {
			get;
			set;
		}

		public virtual Object PageParameters {
			get;
			set;
		}

		public virtual int Width {
			get;
			set;
		}

		public virtual string CloseMessage {
			get;
			set;
		}

		public virtual int Height {
			get;
			set;
		}

		public virtual Object Centered {
			get;
			set;
		}

		public virtual bool UseOpenerRegisterScript {
			get;
			set;
		}

		public virtual bool UseCurrentActivePage {
			get;
			set;
		}

		public virtual bool IgnoreProfile {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			// TODO: Generate exception if OpenerPage parameter is null
			/*
			Terrasoft.UI.WebControls.PageSchemaUserControl page = null;
			if (OpenerPage != null) {
				//return false;
				page = (Terrasoft.UI.WebControls.PageSchemaUserControl)OpenerPage;
			}
			*/
			//var page = (Terrasoft.UI.WebControls.PageSchemaUserControl)OpenerPage;
			
			// TODO: Generate exception if PageUId and PageUrl parameters are (null or empty) and at same time 
			if (PageUId.IsEmpty() && string.IsNullOrEmpty(PageUrl)) {	
				return false;
			}
			
			var sb = new StringBuilder();
			/*
			if (UseOpenerRegisterScript) {
				sb.Append("var currentOpener = window.opener != null ? window.opener : window;\r\n");
				sb.Append("currentOpener.");
			}
			*/
			sb.Append("Terrasoft.openWindow(");
			var sbCallback = new StringBuilder();
			var sbConfig = new StringBuilder();
			var nullString = "null";
			var callbackString = "function(wnd) {{ {0} }}";
			var window = "wnd";
			
			// windowUrl:
			if (!PageUId.IsEmpty()) {
				sb.Append("'");
				sb.Append("ViewPage.aspx");	
				sb.Append("'");
				// id:
				sb.Append(", ");
				sb.Append("'");
				sb.Append(PageUId.ToString());
				sb.Append("'");	
			} else {
				sb.Append("'");
				sb.Append(PageUrl);
				sb.Append("'");
				// id:
				sb.Append(", ");
				sb.Append(nullString);	
			}
			sb.Append(", ");
			
			// params:
			sb.Append("[");
			bool isFirst = true;
			if (PageParameters != null) {
				foreach (var parameter in (Dictionary<string, string>)PageParameters) {
					if (isFirst) {
						isFirst = false;
					} else {
						sb.Append(", ");
					}
					sb.Append("\n\t{name: ");
					sb.Append("'");
					sb.Append(parameter.Key);
					sb.Append("'");
					sb.Append(",");
					sb.Append(" value: ");
					sb.Append("'");
					sb.Append(parameter.Value);
					sb.Append("'");
					sb.Append("}");
				}
			}
			sb.Append("\t]");	
			sb.Append(", ");
			
			var pageSchemaManager = UserConnection.GetSchemaManager("PageSchemaManager") as PageSchemaManager;
			if (!PageUId.IsEmpty()) {
				var pageSchema = pageSchemaManager.GetInstanceByUId(PageUId);	
				if (!pageSchema.Maximized) {
					// width:
					sb.Append(pageSchema.Width.ToString(CultureInfo.InvariantCulture));
					sb.Append(", ");		
					// height:
					sb.Append(pageSchema.Height.ToString(CultureInfo.InvariantCulture));
					sb.Append(", ");
				} else {
					// width:
					sb.Append(nullString);
					sb.Append(", ");		
					// height:
					sb.Append(nullString);
					sb.Append(", ");
				}
			} else {
				// width:
				if (Width > 0) {
					sb.Append(Width.ToString(CultureInfo.InvariantCulture));
				} else {
					sb.Append(nullString);
				}
				sb.Append(", ");
				
				// height:
				if (Height > 0) {
					sb.Append(Height.ToString(CultureInfo.InvariantCulture));
				} else {
					sb.Append(nullString);
				}
				sb.Append(", ");
			}
			
			// isCenterWindow: 
			var centered = Centered as bool?;
			if (!centered.HasValue) {
				sb.Append("true");
			} else {	
				if (centered.Value) {
					sb.Append("true");
				} else {
					sb.Append("false");
				}
			}
			sb.Append(", ");
			
			// isToolBarVisible:
			sb.Append(nullString);
			sb.Append(", ");
			
			// openInExistingWindow:
			sb.Append(nullString);
			
			// key setting:
			sbCallback.Append("\nvar windowKey = ");
			// sbCallback.Append(window);
			// sbCallback.Append(".key = ");
			sbCallback.Append("'");
			if (!string.IsNullOrEmpty(OpenerInstanceId)) {
				sbCallback.Append(OpenerInstanceId);
			} else {
				/*
				if (page != null) {
					sbCallback.Append(((Terrasoft.UI.WebControls.Page)page.AspPage).InstanceId.ToString());
					sbCallback.Append(page.PageContainer.UniqueID);
				}*/
			}
			sbCallback.Append("'");
			sbCallback.Append(";");	
			sbCallback.Append("\nwnd.key = windowKey;");
			
			// opener closing:
			if (CloseOpenerOnLoad) {
				sbCallback.Append("\nif (window.mainPage != window) {");
				sbCallback.Append("\n\tExt.lib.Event.on(");	
				sbCallback.Append(window);
				sbCallback.Append(", 'load', function() {\n\t\twindow.close()\n});");
				sbCallback.Append("\n}");
			}
			
			// close message:
			if (!string.IsNullOrEmpty(CloseMessage)) {
				sbCallback.Append(@"
			var pickHoleInRegisterListener = function(attemptsCount) {
				setTimeout(function() {
					try {
						attemptsCount--;
						Ext.EventManager.on(wnd, 'beforeunload', function() {
							if (Terrasoft.AjaxMethods.ThrowClientEvent) {
								var wndKey = windowKey;
								setTimeout(function() {
									Terrasoft.AjaxMethods.ThrowClientEvent(wndKey,'");
				sbCallback.Append(CloseMessage);
				sbCallback.Append(@"');}, 10);
							}
						});
					} catch(e) {
						if (attemptsCount === 0) {
							throw e;
						}
						pickHoleInRegisterListener(attemptsCount);
					}
				}, 200);
			};
			pickHoleInRegisterListener(10);");
			}
			
			sb.Append(", ");
			sb.Append(string.Format(callbackString, sbCallback.ToString()));
			sb.Append(", ");
			
			// ignoreRequestId:
			sb.Append(nullString);
			sb.Append(", ");
			
			// windowName
			sb.Append(nullString);
			sb.Append(", ");
			
			// useApplicationPath
			sb.Append(nullString);
			sb.Append(", ");
			
			// config
			sbConfig.Append("\n{");
			
				// config:ignoreProfile
				sbConfig.Append(string.Format("ignoreProfile:{0}", IgnoreProfile ? "true" : "false"));
			
			sbConfig.Append("}");
			
			sb.Append(sbConfig);
			sb.Append(");");
			
			// script adding:
			/*
			ScriptManager scriptManager = null;
			if (page == null) {
			} else {
				scriptManager = page.GetPropertyValue("ScriptManager") as ScriptManager;
			}
			*/
			//ScriptManager scriptManager = ((Terrasoft.UI.WebControls.Page)System.Web.HttpContext.Current.CurrentHandler).FindControl("ScriptManager") as ScriptManager;
			//Hack: Asp.Net has an artificial limit on the size of the stack
			ScriptManager scriptManager = Terrasoft.UI.WebControls.Page.FindControlByClientId(((System.Web.UI.Control)System.Web.HttpContext.Current.CurrentHandler), "ScriptManager", true) as ScriptManager;
			string script = sb.ToString();
			if (!UseCurrentActivePage) {
				script = "var executePage = window.mainPage || window; executePage.eval('" + script.Replace(@"\", @"\\").Replace(@"'", @"\'").Replace("\n", " ").Replace("\r", " ")  + "');";
			}
			scriptManager.AddScript(script);
			//OpenerPage = null;
			return true;
		}

		#endregion

		#region Methods: Public

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
			if (!HasMapping("PageUId")) {
				writer.WriteValue("PageUId", PageUId, Guid.Empty);
			}
			if (!HasMapping("PageUrl")) {
				writer.WriteValue("PageUrl", PageUrl, null);
			}
			if (!HasMapping("OpenerInstanceId")) {
				writer.WriteValue("OpenerInstanceId", OpenerInstanceId, null);
			}
			if (!HasMapping("CloseOpenerOnLoad")) {
				writer.WriteValue("CloseOpenerOnLoad", CloseOpenerOnLoad, false);
			}
			if (PageParameters != null) {
				if (PageParameters.GetType().IsSerializable || PageParameters.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("PageParameters", PageParameters, null);
				}
			}
			if (!HasMapping("Width")) {
				writer.WriteValue("Width", Width, 0);
			}
			if (!HasMapping("CloseMessage")) {
				writer.WriteValue("CloseMessage", CloseMessage, null);
			}
			if (!HasMapping("Height")) {
				writer.WriteValue("Height", Height, 0);
			}
			if (Centered != null) {
				if (Centered.GetType().IsSerializable || Centered.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("Centered", Centered, null);
				}
			}
			if (!HasMapping("UseOpenerRegisterScript")) {
				writer.WriteValue("UseOpenerRegisterScript", UseOpenerRegisterScript, false);
			}
			if (!HasMapping("UseCurrentActivePage")) {
				writer.WriteValue("UseCurrentActivePage", UseCurrentActivePage, false);
			}
			if (!HasMapping("IgnoreProfile")) {
				writer.WriteValue("IgnoreProfile", IgnoreProfile, false);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "PageUId":
					PageUId = reader.GetGuidValue();
				break;
				case "PageUrl":
					PageUrl = reader.GetStringValue();
				break;
				case "OpenerInstanceId":
					OpenerInstanceId = reader.GetStringValue();
				break;
				case "CloseOpenerOnLoad":
					CloseOpenerOnLoad = reader.GetBoolValue();
				break;
				case "PageParameters":
					PageParameters = reader.GetSerializableObjectValue();
				break;
				case "Width":
					Width = reader.GetIntValue();
				break;
				case "CloseMessage":
					CloseMessage = reader.GetStringValue();
				break;
				case "Height":
					Height = reader.GetIntValue();
				break;
				case "Centered":
					Centered = reader.GetSerializableObjectValue();
				break;
				case "UseOpenerRegisterScript":
					UseOpenerRegisterScript = reader.GetBoolValue();
				break;
				case "UseCurrentActivePage":
					UseCurrentActivePage = reader.GetBoolValue();
				break;
				case "IgnoreProfile":
					IgnoreProfile = reader.GetBoolValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

