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

	#region Class: SetDetailFilterSchema

	/// <exclude/>
	public class SetDetailFilterSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public SetDetailFilterSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public SetDetailFilterSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f2200aba-2944-475d-b8dc-e9bc7f9e2d84");
			RealUId = new Guid("f2200aba-2944-475d-b8dc-e9bc7f9e2d84");
			Name = "SetDetailFilter";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,83,77,75,3,49,16,61,119,127,69,204,169,5,89,145,10,30,22,65,172,85,10,82,165,42,158,99,59,171,139,219,164,76,178,109,69,4,63,142,10,222,253,25,162,160,86,244,47,100,255,145,147,110,181,221,90,80,15,11,201,155,153,151,55,111,102,87,121,87,32,107,129,17,81,188,35,142,160,162,36,29,37,32,91,97,235,51,80,161,217,30,32,10,173,66,227,239,215,252,3,56,116,65,84,177,246,191,15,185,146,192,139,66,86,156,249,194,10,147,73,28,151,216,153,87,64,48,9,74,102,48,129,192,59,31,150,104,131,145,60,242,107,186,78,73,219,88,109,119,204,105,113,239,24,85,175,218,5,105,234,162,13,165,97,109,30,35,225,156,111,98,212,114,143,53,32,68,208,199,13,213,227,252,139,119,35,138,13,224,22,132,166,218,239,80,84,71,74,106,54,55,33,198,89,146,104,64,146,42,161,105,40,78,164,77,210,13,125,106,58,23,8,178,236,172,189,117,97,196,174,74,176,233,68,204,106,217,223,136,100,235,11,33,171,214,78,157,226,34,231,227,74,206,169,169,63,185,60,174,33,17,99,143,39,68,76,246,84,88,88,176,247,246,221,62,206,51,251,106,223,211,43,250,46,210,27,251,50,188,218,55,251,97,159,237,192,62,19,120,109,159,210,171,244,50,189,99,46,203,14,210,91,151,194,236,3,59,80,120,162,59,130,168,43,141,197,229,114,121,105,153,136,255,163,52,243,190,162,226,120,228,107,56,4,200,174,10,130,48,163,248,143,78,230,167,198,225,127,11,241,107,173,233,96,137,236,40,236,130,201,113,229,199,224,110,53,169,141,144,142,59,211,224,202,206,105,69,126,203,247,199,235,54,189,141,129,55,235,151,201,134,16,120,14,205,109,72,6,79,110,62,255,4,54,182,184,192,143,3,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateDetailPageContainerParameter());
			Parameters.Add(CreatePageDataSourceParameter());
			Parameters.Add(CreateDetailPageFilterNameParameter());
			Parameters.Add(CreateThrowEventNameParameter());
			Parameters.Add(CreateFilterLeftExpressionsParameter());
			Parameters.Add(CreateFilterRightValueParameter());
			Parameters.Add(CreateFilterNameParameter());
			Parameters.Add(CreateParentColumnMetaPathParameter());
			Parameters.Add(CreateSysEntitySchemaIdParameter());
		}

		protected virtual ProcessSchemaParameter CreateDetailPageContainerParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("fa047804-f95d-4e3f-8cb3-195d48dd9e14"),
				Name = "DetailPageContainer",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = false,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreatePageDataSourceParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("98c33ec6-74c6-44bc-b69d-ca85dcb6d7fb"),
				Name = "PageDataSource",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = false,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateDetailPageFilterNameParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("60e571e7-8028-4167-b7dc-6a7fef13eed3"),
				Name = "DetailPageFilterName",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateThrowEventNameParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("bf904ec0-01dd-4632-a470-5e142d5a72b8"),
				Name = "ThrowEventName",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateFilterLeftExpressionsParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("82f11c84-be07-4934-9ad2-052f9a7e387d"),
				Name = "FilterLeftExpressions",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateFilterRightValueParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("8cee53d4-4b9a-4a59-974e-60514e80cccd"),
				Name = "FilterRightValue",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateFilterNameParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("d6892f15-8b18-43b1-a3eb-ba751f3f2550"),
				Name = "FilterName",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateParentColumnMetaPathParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("d30909cc-ea62-48d7-82d2-a111bd4bb908"),
				Name = "ParentColumnMetaPath",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateSysEntitySchemaIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("7cbfcd2f-6860-494e-9b48-6695cd04ab62"),
				Name = "SysEntitySchemaId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
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
			Methods.Add(CreateCreateFilterMethod());
			Methods.Add(CreateSetFilterMethod());
			Methods.Add(CreateGetFilterRightValueMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("1a8c5ec7-31ba-4186-a4f6-38d4cb2e1062"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateCreateFilterMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b482a0a6-d70a-4e61-b5a0-761437205672"),
				Name = "CreateFilter",
				CreatedInSchemaUId = new Guid("f2200aba-2944-475d-b8dc-e9bc7f9e2d84"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Terrasoft.UI.WebControls.Controls.DataSourceFilterCollection"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b8a1e912-aa02-4a87-ae3f-0d7451fb9d40"),
				Name = "detailDataSource",
				CreatedInSchemaUId = new Guid("f2200aba-2944-475d-b8dc-e9bc7f9e2d84"),
				ModifiedInSchemaUId = new Guid("f2200aba-2944-475d-b8dc-e9bc7f9e2d84"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Terrasoft.UI.WebControls.Controls.DataSource",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d1ff500c-ec21-4b07-8f5f-e65cf54c1d6b"),
				Name = "solutionId",
				CreatedInSchemaUId = new Guid("f2200aba-2944-475d-b8dc-e9bc7f9e2d84"),
				ModifiedInSchemaUId = new Guid("f2200aba-2944-475d-b8dc-e9bc7f9e2d84"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("46be991b-e081-478f-aa17-db1c6e570c3c"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("f2200aba-2944-475d-b8dc-e9bc7f9e2d84"),
				ModifiedInSchemaUId = new Guid("f2200aba-2944-475d-b8dc-e9bc7f9e2d84"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,83,75,79,220,48,16,62,39,191,194,220,18,105,101,113,143,56,172,2,69,72,171,82,177,80,14,85,15,38,59,217,24,121,237,48,30,163,110,11,255,189,227,117,154,221,69,161,106,47,156,50,206,60,190,135,199,207,10,197,10,72,105,179,108,58,216,40,113,54,28,207,21,169,165,11,216,128,76,153,42,191,5,68,229,93,75,242,238,74,222,195,67,237,44,161,51,94,222,145,54,154,52,120,121,97,73,211,118,223,187,207,92,89,254,42,163,127,194,60,144,59,135,118,73,24,26,10,8,197,91,64,161,188,120,23,107,12,222,66,149,127,33,56,6,251,242,17,94,248,49,154,208,94,7,68,176,52,86,87,249,51,59,214,106,67,128,11,104,233,226,71,143,224,189,118,214,115,251,167,201,255,44,103,206,196,182,85,174,91,81,188,211,123,38,108,48,70,188,188,76,15,151,11,176,107,234,98,221,105,41,126,229,25,2,211,177,187,166,42,127,253,47,233,137,101,237,140,129,134,120,248,128,24,5,140,94,200,26,65,209,80,234,47,209,133,190,72,135,207,106,3,51,177,112,107,221,40,115,221,3,170,56,131,13,210,13,201,107,228,107,104,29,247,54,93,193,195,180,93,11,24,85,8,109,167,213,237,20,69,115,14,106,7,71,118,169,172,97,21,218,6,182,63,123,205,179,120,5,238,225,145,217,127,81,168,54,145,248,37,80,162,119,163,215,29,125,85,38,64,17,124,84,105,109,82,89,198,123,72,93,223,190,87,9,238,104,200,201,33,224,96,137,156,175,86,5,31,167,125,185,215,212,237,154,33,214,22,135,239,104,118,176,193,53,251,145,214,53,62,132,63,238,111,122,133,218,59,123,187,237,57,251,20,148,153,49,80,182,119,96,118,164,177,44,163,118,1,198,195,20,193,15,100,120,68,241,31,124,79,204,121,71,135,149,29,152,87,191,1,223,24,14,71,123,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetFilterMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("99ca8fc5-3fe3-4cec-b428-3c4978abd033"),
				Name = "SetFilter",
				CreatedInSchemaUId = new Guid("f2200aba-2944-475d-b8dc-e9bc7f9e2d84"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("de241bd0-2d71-41ea-8654-eb5582b31fad"),
				Name = "pageInstance",
				CreatedInSchemaUId = new Guid("f2200aba-2944-475d-b8dc-e9bc7f9e2d84"),
				ModifiedInSchemaUId = new Guid("f2200aba-2944-475d-b8dc-e9bc7f9e2d84"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Terrasoft.UI.WebControls.PageSchemaUserControl",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c9cb9824-2976-4a38-8f38-44d77e03965e"),
				Name = "filter",
				CreatedInSchemaUId = new Guid("f2200aba-2944-475d-b8dc-e9bc7f9e2d84"),
				ModifiedInSchemaUId = new Guid("f2200aba-2944-475d-b8dc-e9bc7f9e2d84"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Terrasoft.UI.WebControls.Controls.DataSourceFilterCollection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,72,76,79,245,204,43,46,73,204,75,78,213,11,40,202,79,78,45,46,214,11,78,45,1,50,11,82,139,74,42,195,18,115,74,83,53,92,82,75,18,51,115,2,128,106,221,50,115,74,82,139,252,18,115,83,117,20,210,192,108,77,107,46,0,226,34,231,162,69,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetFilterRightValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8008efe4-ef1c-4ed4-ac10-dff7b722b9a6"),
				Name = "GetFilterRightValue",
				CreatedInSchemaUId = new Guid("f2200aba-2944-475d-b8dc-e9bc7f9e2d84"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "object"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2a43ce8f-8c0e-434e-8732-382c8e0ca69f"),
				Name = "userConnection",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,148,77,79,227,48,16,134,207,233,175,112,47,200,145,42,107,57,163,10,209,40,69,61,0,93,88,224,176,218,131,149,204,54,150,18,187,56,99,86,22,234,127,95,127,208,144,38,161,151,52,178,103,158,153,247,157,73,197,95,66,159,108,155,75,20,104,159,138,10,26,190,41,201,124,73,110,141,40,89,222,236,209,146,139,11,50,111,81,11,185,99,155,246,222,212,245,131,14,23,116,203,53,72,204,84,109,26,121,7,200,183,28,171,52,37,31,179,228,157,107,2,61,230,29,151,124,7,154,44,137,105,65,103,74,74,40,80,40,201,242,113,208,213,56,221,229,77,208,216,45,224,70,182,200,101,1,43,251,188,41,199,74,210,79,216,190,215,233,0,198,214,66,150,241,53,222,175,172,215,49,45,206,225,132,115,236,20,183,36,210,153,18,116,39,168,109,248,77,206,85,116,125,159,22,60,242,191,45,154,28,72,193,177,168,200,199,97,150,28,38,154,152,199,38,252,172,250,231,236,158,55,224,47,135,245,183,90,52,92,219,24,229,131,104,28,220,200,250,159,6,156,36,71,135,127,36,31,158,211,137,169,44,78,107,121,118,80,224,193,90,236,42,124,225,181,129,175,194,3,115,2,151,221,148,101,140,160,35,53,105,120,122,226,56,109,45,106,4,221,250,116,58,190,205,52,112,132,24,243,42,176,114,102,59,146,79,160,241,48,83,141,43,39,90,37,127,217,61,176,252,205,240,122,65,252,52,199,176,71,165,240,172,157,11,18,161,143,157,230,180,243,161,80,117,29,63,128,73,245,14,24,173,206,186,56,250,124,242,221,4,146,95,130,47,18,203,148,145,232,183,241,50,78,242,88,201,117,20,202,127,107,118,183,142,52,101,81,65,235,207,86,54,8,153,154,217,49,174,227,250,118,18,13,104,180,236,137,251,253,227,143,7,245,98,233,160,159,148,92,95,247,254,106,194,166,251,5,63,204,62,97,67,15,175,254,3,193,227,232,82,177,4,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SetDetailFilterSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f2200aba-2944-475d-b8dc-e9bc7f9e2d84"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new SetDetailFilter(userConnection) {
				SchemaUId = new Guid("f2200aba-2944-475d-b8dc-e9bc7f9e2d84")
			};
		}

		#endregion

	}

	#endregion

	#region Class: SetDetailFilter

	[DesignModeProperty(Name = "DetailPageContainer", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "f2200aba2944475db8dce9bc7f9e2d84", CaptionResourceItem = "Parameters.DetailPageContainer.Caption", DescriptionResourceItem = "Parameters.DetailPageContainer.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "PageDataSource", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "f2200aba2944475db8dce9bc7f9e2d84", CaptionResourceItem = "Parameters.PageDataSource.Caption", DescriptionResourceItem = "Parameters.PageDataSource.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "DetailPageFilterName", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "f2200aba2944475db8dce9bc7f9e2d84", CaptionResourceItem = "Parameters.DetailPageFilterName.Caption", DescriptionResourceItem = "Parameters.DetailPageFilterName.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ThrowEventName", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "f2200aba2944475db8dce9bc7f9e2d84", CaptionResourceItem = "Parameters.ThrowEventName.Caption", DescriptionResourceItem = "Parameters.ThrowEventName.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "FilterLeftExpressions", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "f2200aba2944475db8dce9bc7f9e2d84", CaptionResourceItem = "Parameters.FilterLeftExpressions.Caption", DescriptionResourceItem = "Parameters.FilterLeftExpressions.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "FilterRightValue", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "f2200aba2944475db8dce9bc7f9e2d84", CaptionResourceItem = "Parameters.FilterRightValue.Caption", DescriptionResourceItem = "Parameters.FilterRightValue.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "FilterName", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "f2200aba2944475db8dce9bc7f9e2d84", CaptionResourceItem = "Parameters.FilterName.Caption", DescriptionResourceItem = "Parameters.FilterName.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ParentColumnMetaPath", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "f2200aba2944475db8dce9bc7f9e2d84", CaptionResourceItem = "Parameters.ParentColumnMetaPath.Caption", DescriptionResourceItem = "Parameters.ParentColumnMetaPath.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "SysEntitySchemaId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "f2200aba2944475db8dce9bc7f9e2d84", CaptionResourceItem = "Parameters.SysEntitySchemaId.Caption", DescriptionResourceItem = "Parameters.SysEntitySchemaId.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class SetDetailFilter : ProcessUserTask
	{

		#region Constructors: Public

		public SetDetailFilter(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("f2200aba-2944-475d-b8dc-e9bc7f9e2d84");
		}

		#endregion

		#region Properties: Public

		public virtual Object DetailPageContainer {
			get;
			set;
		}

		public virtual Object PageDataSource {
			get;
			set;
		}

		public virtual string DetailPageFilterName {
			get;
			set;
		}

		public virtual string ThrowEventName {
			get;
			set;
		}

		public virtual Object FilterLeftExpressions {
			get;
			set;
		}

		public virtual Object FilterRightValue {
			get;
			set;
		}

		public virtual string FilterName {
			get;
			set;
		}

		public virtual string ParentColumnMetaPath {
			get;
			set;
		}

		public virtual Guid SysEntitySchemaId {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			var detailPageContainer = DetailPageContainer as Terrasoft.UI.WebControls.Controls.PageContainer;
			if (detailPageContainer == null) {
				return true;
			}
			if (string.IsNullOrEmpty(ThrowEventName)) {
				ThrowEventName = "GridPageRefreshRow";
			}
			if (FilterLeftExpressions != null) {
				var userConnection = context.UserConnection;
				var detailDataSource = (detailPageContainer.FindPageControlByName("DataSource")) as Terrasoft.UI.WebControls.Controls.DataSource;
				if (detailDataSource != null) {
					//Код, который компилируется только в Workspace CR173347
					Terrasoft.UI.WebControls.Controls.DataSourceFilterCollection filter = CreateFilter(detailDataSource, userConnection.Workspace.Id, userConnection);
					SetFilter(detailPageContainer.PageInstance, filter);
				}
			}
			detailPageContainer.PageInstance.ThrowEvent(ThrowEventName);
			DetailPageContainer = null;
			PageDataSource = null;
			return true;
		}

		#endregion

		#region Methods: Public

		public virtual Terrasoft.UI.WebControls.Controls.DataSourceFilterCollection CreateFilter(Terrasoft.UI.WebControls.Controls.DataSource detailDataSource, Guid solutionId, UserConnection userConnection) {
			var detailSchema = detailDataSource.Schema;
			Terrasoft.UI.WebControls.Utilities.EntityDataSourceUtilities.InitializeAutoDefStructure(detailDataSource as Terrasoft.UI.WebControls.Controls.EntityDataSource);
			Terrasoft.UI.WebControls.Controls.DataSourceStructure structure = detailDataSource.CurrentStructure;
			var filterLeftExpressions = FilterLeftExpressions as Array;
			if (filterLeftExpressions == null || filterLeftExpressions.Length == 0) {
				return null;
			}
			Terrasoft.UI.WebControls.Controls.DataSourceFilterCollection filters = structure.CreateFiltersGroup(FilterName, LogicalOperationStrict.Or);
			foreach(string expression in filterLeftExpressions) {
				if (expression == null) {
					continue;
				}
				var objectParams = GetFilterRightValue(userConnection) as object[];
				if (objectParams != null) {
					filters.Add(
					structure.CreateFilterWithParameters(detailSchema, Terrasoft.Core.Entities.FilterComparisonType.Equal,
						expression, objectParams));
				} else {
					filters.Add(
						structure.CreateFilterWithParameters(detailSchema, Terrasoft.Core.Entities.FilterComparisonType.Equal,
							expression, GetFilterRightValue(userConnection)));
				}
			}
			return filters;
		}

		public virtual void SetFilter(Terrasoft.UI.WebControls.PageSchemaUserControl pageInstance, Terrasoft.UI.WebControls.Controls.DataSourceFilterCollection filter) {
			pageInstance.Process.SetPropertyValue(DetailPageFilterName, filter);
		}

		public virtual object GetFilterRightValue(UserConnection userConnection) {
			if (SysEntitySchemaId != Guid.Empty && !string.IsNullOrEmpty(ParentColumnMetaPath)) {
				var entitySchemaManager = userConnection.EntitySchemaManager;
				var entitySchema = entitySchemaManager.GetInstanceByUId(SysEntitySchemaId);
				var parentColumn = entitySchema.FindSchemaColumnByPath(ParentColumnMetaPath);
				if (parentColumn == null) {
					try {
						parentColumn = entitySchema.GetSchemaColumnByMetaPath(ParentColumnMetaPath);
					} catch {}
				}
				if (parentColumn != null && parentColumn.Name != entitySchema.GetPrimaryColumnName()) {
					var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, entitySchema.Name);
					var rightValueColumnName = entitySchemaQuery.AddColumn(parentColumn.Name).Name;
					entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
						entitySchemaQuery.RootSchema.GetPrimaryColumnName(), FilterRightValue));
					var collection = entitySchemaQuery.GetEntityCollection(UserConnection);
					if (collection.Count == 1) {
						var columnValueName = entitySchemaQuery.GetSchema().Columns.GetByName(rightValueColumnName).ColumnValueName;
						return collection[0].GetColumnValue(columnValueName) ?? Guid.Empty;
					}
				}
			}
			return FilterRightValue;
		}

		public override void WritePropertiesData(DataWriter writer) {
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer);
			if (Status == Core.Process.ProcessStatus.Inactive) {
				writer.WriteFinishObject();
				return;
			}
			if (UseFlowEngineMode) {
				if (DetailPageContainer != null) {
					if (DetailPageContainer.GetType().IsSerializable || DetailPageContainer.GetType().GetInterface("ISerializable") != null) {
						writer.WriteSerializableObjectValue("DetailPageContainer", DetailPageContainer, null);
					}
				}
			}
			if (UseFlowEngineMode) {
				if (PageDataSource != null) {
					if (PageDataSource.GetType().IsSerializable || PageDataSource.GetType().GetInterface("ISerializable") != null) {
						writer.WriteSerializableObjectValue("PageDataSource", PageDataSource, null);
					}
				}
			}
			if (!HasMapping("DetailPageFilterName")) {
				writer.WriteValue("DetailPageFilterName", DetailPageFilterName, null);
			}
			if (!HasMapping("ThrowEventName")) {
				writer.WriteValue("ThrowEventName", ThrowEventName, null);
			}
			if (FilterLeftExpressions != null) {
				if (FilterLeftExpressions.GetType().IsSerializable || FilterLeftExpressions.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("FilterLeftExpressions", FilterLeftExpressions, null);
				}
			}
			if (FilterRightValue != null) {
				if (FilterRightValue.GetType().IsSerializable || FilterRightValue.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("FilterRightValue", FilterRightValue, null);
				}
			}
			if (!HasMapping("FilterName")) {
				writer.WriteValue("FilterName", FilterName, null);
			}
			if (!HasMapping("ParentColumnMetaPath")) {
				writer.WriteValue("ParentColumnMetaPath", ParentColumnMetaPath, null);
			}
			if (!HasMapping("SysEntitySchemaId")) {
				writer.WriteValue("SysEntitySchemaId", SysEntitySchemaId, Guid.Empty);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "DetailPageContainer":
					if (!UseFlowEngineMode) {
						break;
					}
					DetailPageContainer = reader.GetSerializableObjectValue();
				break;
				case "PageDataSource":
					if (!UseFlowEngineMode) {
						break;
					}
					PageDataSource = reader.GetSerializableObjectValue();
				break;
				case "DetailPageFilterName":
					DetailPageFilterName = reader.GetStringValue();
				break;
				case "ThrowEventName":
					ThrowEventName = reader.GetStringValue();
				break;
				case "FilterLeftExpressions":
					FilterLeftExpressions = reader.GetSerializableObjectValue();
				break;
				case "FilterRightValue":
					FilterRightValue = reader.GetSerializableObjectValue();
				break;
				case "FilterName":
					FilterName = reader.GetStringValue();
				break;
				case "ParentColumnMetaPath":
					ParentColumnMetaPath = reader.GetStringValue();
				break;
				case "SysEntitySchemaId":
					SysEntitySchemaId = reader.GetGuidValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

