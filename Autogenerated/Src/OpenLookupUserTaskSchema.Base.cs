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

	#region Class: OpenLookupUserTaskSchema

	/// <exclude/>
	public class OpenLookupUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public OpenLookupUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public OpenLookupUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae");
			RealUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae");
			Name = "OpenLookupUserTask";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,87,223,83,220,54,16,126,190,251,43,132,95,206,78,92,243,158,107,75,18,2,132,41,80,166,7,244,33,205,131,176,5,184,248,236,27,73,230,114,211,220,255,222,93,201,150,37,91,198,9,195,140,237,253,241,105,181,218,253,180,247,62,168,238,255,101,169,36,34,125,98,107,122,69,215,108,57,119,68,183,231,89,39,97,101,198,184,249,76,105,81,220,211,244,249,180,46,83,153,87,165,81,112,246,192,56,43,83,182,82,16,23,185,144,70,199,178,92,94,86,89,183,76,81,85,207,245,230,52,47,36,227,194,90,138,242,244,233,142,22,117,103,153,214,66,86,235,227,162,18,44,59,121,97,165,236,97,156,241,60,187,166,143,236,152,110,156,112,180,22,53,171,193,150,214,117,33,243,21,43,224,221,137,202,146,95,120,3,172,5,251,156,51,142,81,238,140,240,41,207,216,199,90,202,170,236,12,73,90,21,245,26,5,183,130,241,227,170,148,236,155,252,131,237,200,111,228,172,206,179,228,138,109,241,25,70,201,77,181,146,60,47,31,195,104,57,127,161,28,151,64,251,146,169,236,130,125,170,157,147,91,71,161,141,55,176,189,107,202,225,0,49,76,48,14,63,229,74,77,249,142,252,42,20,112,76,116,76,191,71,215,142,245,114,238,122,39,55,124,119,198,164,202,126,24,4,93,109,4,1,64,212,118,181,68,63,228,11,25,119,93,65,48,233,169,138,205,184,169,175,41,159,126,69,182,222,125,249,20,142,167,128,91,40,143,106,10,173,45,249,22,162,253,158,242,115,10,175,117,118,218,101,10,97,172,138,91,176,49,253,100,158,251,157,104,18,221,87,76,159,178,233,243,238,168,141,104,202,219,219,247,110,166,122,202,31,67,116,184,194,197,115,84,63,145,127,187,0,122,226,41,20,155,106,90,8,91,54,229,111,177,82,235,110,137,38,79,232,169,218,30,107,10,51,167,172,63,193,243,190,170,10,146,139,187,156,203,154,22,184,25,96,158,7,90,8,96,210,252,129,132,61,100,100,63,154,151,2,232,15,144,207,109,191,32,136,34,242,223,124,214,7,11,113,137,200,197,249,50,240,253,186,156,239,21,13,74,182,222,168,200,145,2,75,182,37,29,11,246,73,16,105,22,99,60,112,150,212,65,128,184,227,56,114,0,80,117,81,68,160,81,170,3,141,148,156,139,43,16,255,201,79,214,27,185,179,28,44,38,143,148,211,12,67,91,211,18,118,193,33,46,151,216,19,72,182,174,168,75,109,1,169,57,41,101,46,119,142,20,18,68,168,32,55,140,115,42,170,7,9,201,228,44,81,134,57,19,137,199,99,137,43,207,12,225,194,194,77,8,184,226,121,41,36,5,26,251,184,195,136,71,130,79,192,205,185,150,102,179,253,28,255,187,4,41,96,157,31,242,253,59,121,37,51,46,150,62,109,2,127,156,201,154,151,68,114,188,234,1,124,79,24,212,15,106,187,195,76,62,100,217,176,98,98,183,244,48,62,189,62,121,233,164,206,141,219,132,167,194,90,234,109,252,124,137,206,198,208,7,85,122,231,51,132,106,117,115,186,247,236,116,196,51,246,239,44,194,242,199,205,88,125,109,170,214,155,201,30,39,184,124,176,159,15,236,171,13,43,245,21,161,121,139,101,90,141,206,83,109,6,136,175,224,93,243,42,101,66,52,219,235,190,124,94,131,75,172,127,27,14,60,94,187,1,95,185,253,6,56,163,55,205,216,45,51,64,240,222,153,190,251,114,224,217,231,127,251,155,28,29,169,206,241,249,245,152,187,99,237,30,255,172,32,225,240,252,68,37,253,226,206,168,95,161,168,59,216,229,188,233,46,145,242,124,35,65,247,62,8,20,235,218,28,179,8,2,242,214,199,14,71,122,222,85,189,103,53,0,121,71,188,252,0,32,0,191,208,211,173,30,255,0,189,1,111,62,13,114,16,108,243,50,171,182,160,126,215,24,15,177,52,212,179,106,213,240,4,230,232,92,104,126,2,17,216,28,181,184,73,137,164,255,214,10,139,179,77,65,83,22,30,254,114,248,24,47,22,17,6,13,78,26,176,63,92,182,81,146,112,168,49,1,131,9,190,169,120,251,102,99,145,123,70,79,147,17,175,206,74,143,89,204,99,56,182,158,53,136,117,123,114,132,222,237,52,28,11,85,148,82,9,101,184,192,226,179,220,172,229,98,162,212,238,178,237,120,172,215,196,205,117,18,223,142,90,173,133,11,175,23,213,22,110,82,23,185,238,138,219,174,213,222,239,50,187,238,60,51,159,73,185,87,231,11,208,99,56,150,242,222,100,216,165,96,160,240,45,164,146,9,214,61,99,111,98,192,76,231,190,93,190,27,44,46,28,74,75,144,70,176,69,226,166,177,226,65,193,198,93,171,196,190,2,139,205,25,57,133,16,247,14,36,246,101,42,246,76,203,109,182,240,190,197,94,238,66,191,61,79,254,102,247,8,201,171,66,36,136,20,173,118,2,56,12,229,201,103,41,55,205,122,201,113,205,33,76,243,252,76,203,172,192,153,73,243,25,18,220,165,25,216,198,87,48,47,43,219,69,205,171,106,245,228,20,120,169,49,130,94,112,172,32,249,203,249,225,27,53,81,66,13,54,129,124,128,148,190,48,21,57,222,220,134,107,131,64,53,199,55,150,214,82,169,65,166,73,47,89,195,192,162,36,48,128,105,209,210,54,76,216,11,45,66,93,26,26,46,249,171,33,52,56,249,127,176,61,241,9,47,145,173,88,180,138,133,173,128,111,117,239,1,154,46,30,48,140,150,120,34,251,55,135,115,39,113,120,13,233,13,135,90,222,252,212,72,110,224,74,177,154,78,93,87,110,19,130,165,61,22,6,255,3,40,220,92,160,168,18,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreatePageParametersParameter());
			Parameters.Add(CreateProcessKeyParameter());
			Parameters.Add(CreateUserContextKeyParameter());
			Parameters.Add(CreateUseCurrentActivePageParameter());
		}

		protected virtual ProcessSchemaParameter CreatePageParametersParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("93f7e7eb-8c81-4770-a074-a64f2f77a71f"),
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

		protected virtual ProcessSchemaParameter CreateProcessKeyParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("f7adec9d-5919-4b45-aadb-ebe9235fc244"),
				Name = "ProcessKey",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateUserContextKeyParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("5ce1fc40-96e5-4559-9411-b10f6f6fb77e"),
				Name = "UserContextKey",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
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
				UId = new Guid("76ca6aa7-40ea-4400-9739-2fe39cf4bca9"),
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

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetSelectedValuesMethod());
			Methods.Add(CreateUpdateFiltersRightExprMetaDataByParameterValueMethod());
		}

		protected virtual SchemaMethod CreateGetSelectedValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("cba2a3d3-cba9-476a-8486-9ea50552ce3e"),
				Name = "GetSelectedValues",
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Dictionary<string, object>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e14722cc-bd18-4680-8c2c-2982add3160b"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,144,187,14,130,64,16,69,107,246,43,70,10,2,137,225,7,80,27,233,180,67,109,136,197,168,163,89,197,93,178,15,148,24,254,221,5,141,98,161,86,211,204,156,123,230,86,168,160,194,194,146,134,49,8,186,64,202,183,134,75,129,170,30,105,163,184,56,12,65,110,142,180,53,147,48,74,24,223,67,184,212,164,166,82,24,186,154,25,213,48,112,119,182,40,34,184,49,175,114,180,18,21,158,201,144,106,137,246,177,43,168,131,198,25,105,237,102,138,6,243,79,76,188,144,89,23,23,70,107,64,253,67,35,97,94,107,209,139,121,26,64,16,244,194,227,150,141,92,104,7,15,125,89,146,152,75,121,178,101,70,133,163,208,110,213,61,237,71,157,183,247,170,224,13,200,191,31,253,55,108,88,195,20,25,171,196,179,221,228,14,178,75,189,50,105,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateFiltersRightExprMetaDataByParameterValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("311346b7-4697-4b9a-b409-c62156c29ee7"),
				Name = "UpdateFiltersRightExprMetaDataByParameterValue",
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void",
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9c607a64-9f5e-4415-b782-09ed2adf95e1"),
				Name = "process",
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Process",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("721f8b86-1889-4794-85e7-d10ba1bd0158"),
				Name = "filters",
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
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
			return new OpenLookupUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new OpenLookupUserTask(userConnection) {
				SchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae")
			};
		}

		#endregion

	}

	#endregion

	#region Class: OpenLookupUserTask

	[DesignModeProperty(Name = "PageParameters", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "1aac6458231840e58592778f3a94fdae", CaptionResourceItem = "Parameters.PageParameters.Caption", DescriptionResourceItem = "Parameters.PageParameters.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ProcessKey", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "1aac6458231840e58592778f3a94fdae", CaptionResourceItem = "Parameters.ProcessKey.Caption", DescriptionResourceItem = "Parameters.ProcessKey.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "UserContextKey", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "1aac6458231840e58592778f3a94fdae", CaptionResourceItem = "Parameters.UserContextKey.Caption", DescriptionResourceItem = "Parameters.UserContextKey.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "UseCurrentActivePage", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "1aac6458231840e58592778f3a94fdae", CaptionResourceItem = "Parameters.UseCurrentActivePage.Caption", DescriptionResourceItem = "Parameters.UseCurrentActivePage.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class OpenLookupUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public OpenLookupUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae");
		}

		#endregion

		#region Properties: Public

		public virtual Object PageParameters {
			get;
			set;
		}

		public virtual string ProcessKey {
			get;
			set;
		}

		public virtual string UserContextKey {
			get;
			set;
		}

		public virtual bool UseCurrentActivePage {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			object schemaName;
			object schemaUId;
			object sender;
			object callbackFunction;
			object referenceSchemaList;
			object editMode;
			object lookupFilters;
			object searchValue;
			object customClosedEvent;
			object lookupGridPageCaption;
			object lookupPageSchemaUId;
			object multiSelectMode;
			object multiSelectLookupFilters;
			object useHierarchy;
			object hideButtons;
			object  columns;
			UserContextKey = Guid.NewGuid().ToString();
			var userConnection = context.UserConnection;
			var pageParameters = (Dictionary <string, object>)PageParameters;
			pageParameters.TryGetValue("schemaName", out schemaName);
			pageParameters.TryGetValue("schemaUId", out schemaUId);
			pageParameters.TryGetValue("sender", out sender);
			pageParameters.TryGetValue("callbackFunction", out callbackFunction);
			pageParameters.TryGetValue("referenceSchemaList", out referenceSchemaList);
			pageParameters.TryGetValue("editMode", out editMode);
			pageParameters.TryGetValue("LookupFilters", out lookupFilters);
			pageParameters.TryGetValue("multiSelectLookupFilters", out multiSelectLookupFilters);
			pageParameters.TryGetValue("customClosedEvent", out customClosedEvent);
			pageParameters.TryGetValue("searchValue", out searchValue);
			pageParameters.TryGetValue("lookupGridPageCaption", out lookupGridPageCaption);
			pageParameters.TryGetValue("lookupPageSchemaUId", out lookupPageSchemaUId);
			pageParameters.TryGetValue("multiSelectMode", out multiSelectMode);
			pageParameters.TryGetValue("useHierarchy", out useHierarchy);
			pageParameters.TryGetValue("hideButtons", out hideButtons);
			pageParameters.TryGetValue("showColumns", out columns);
			bool isVirtualMode = false;
			if (pageParameters.ContainsKey("IsVirtualMode")) {
				isVirtualMode = (bool)pageParameters["IsVirtualMode"];
			}
			var tempValues = new Dictionary<string, object>();
			if (!isVirtualMode) {
				if (schemaName != null){
					if (!string.IsNullOrEmpty(schemaName.ToString())){
						var manager = userConnection.GetSchemaManager("EntitySchemaManager") as Terrasoft.Core.Entities.EntitySchemaManager;
							schemaUId = manager.GetInstanceByName(schemaName.ToString()).UId.ToString();
					}
				}
				if (schemaUId == null || string.IsNullOrEmpty(schemaUId.ToString())) {
				    return true;
				}
			} else {
				tempValues.Add("IsVirtualMode", isVirtualMode);
				string virtualModeContextKey = string.Empty;
				if (pageParameters.ContainsKey("IsVirtualMode")) {
					virtualModeContextKey = pageParameters["VirtualModeContextKey"].ToString();
				}
				tempValues.Add("VirtualModeContextKey", virtualModeContextKey);
			}
			if (hideButtons != null) {
				tempValues.Add("hideButtons", hideButtons);
			}
			tempValues.Add("openLookupSelectedValues", new Dictionary<string, object>());
			tempValues.Add("openLookupProcessKey", ProcessKey);
			tempValues.Add("LookupFilters", lookupFilters);
			tempValues.Add("multiSelectLookupFilters", multiSelectLookupFilters);
			tempValues.Add("lookupGridPageCaption", lookupGridPageCaption);
			tempValues.Add("customClosedEvent", customClosedEvent);
			tempValues.Add("useHierarchy", useHierarchy ?? true);
			tempValues.Add("showColumns", columns);
			userConnection.SessionData[UserContextKey] = tempValues;
			string script = @"
			var schemaUId = '" + (schemaUId == null ? Guid.Empty.ToString() : schemaUId.ToString()) + @"';
			var sender = " + (sender == null ? "window" : sender.ToString()) + @";
			var key = (Ext.isEmpty(key)) ? (sender.name + schemaUId.replace(/-/g,'')) : key;
			var callbackFunction = " +  (callbackFunction == null ?  "null" : callbackFunction.ToString()) + @";
			var referenceSchemaList = " + (referenceSchemaList == null ? "null" : referenceSchemaList.ToString()) + @";
			var searchValue = " +  (searchValue == null ?  "null" : string.Concat("'", searchValue.ToString(), "'")) + @";
			var editMode = "  + (editMode == null ? "null" : editMode.ToString().ToLower()) + @";
			var userContextUId = '" + UserContextKey + @"';
			var lookupPageSchemaUId = " + (lookupPageSchemaUId == null ? "null" : lookupPageSchemaUId.ToString()) + @";
			var multiSelectMode = "  + (multiSelectMode == null ? "null" : "'" + multiSelectMode.ToString().ToLower() + "'") + @";
			Terrasoft.LookupGridPage.show(key, sender, callbackFunction, schemaUId, referenceSchemaList, editMode, searchValue, userContextUId, lookupPageSchemaUId, multiSelectMode);
			";
			var page = (Terrasoft.UI.WebControls.Page)System.Web.HttpContext.Current.CurrentHandler;
			var scriptManager = (Terrasoft.UI.WebControls.Controls.ScriptManager)page.Page.FindControl("ScriptManager");
			/*if (!UseCurrentActivePage) {
				script = "var executePage = window.mainPage || window; executePage.eval('" + script.Replace(@"\", @"\\").Replace(@"'", @"\'").Replace("\n", " ") + "');";
			}*/
			scriptManager.AddScript(script);
			page.TempUserContext.Add(UserContextKey);
			return true;
		}

		#endregion

		#region Methods: Public

		public virtual Dictionary<string, object> GetSelectedValues(UserConnection userConnection) {
			var values = new Dictionary<string, object>();
			if (UserContextKey != null) {
				var parameters = userConnection.SessionData[UserContextKey.ToString()] as Dictionary<string, object>;
				if (parameters != null && parameters.ContainsKey("openLookupSelectedValues")) {
					values = parameters["openLookupSelectedValues"] as Dictionary<string, object>;
				}
			}
			return values;
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
			if (PageParameters != null) {
				if (PageParameters.GetType().IsSerializable || PageParameters.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("PageParameters", PageParameters, null);
				}
			}
			if (!HasMapping("ProcessKey")) {
				writer.WriteValue("ProcessKey", ProcessKey, null);
			}
			if (!HasMapping("UserContextKey")) {
				writer.WriteValue("UserContextKey", UserContextKey, null);
			}
			if (!HasMapping("UseCurrentActivePage")) {
				writer.WriteValue("UseCurrentActivePage", UseCurrentActivePage, false);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "PageParameters":
					PageParameters = reader.GetSerializableObjectValue();
				break;
				case "ProcessKey":
					ProcessKey = reader.GetStringValue();
				break;
				case "UserContextKey":
					UserContextKey = reader.GetStringValue();
				break;
				case "UseCurrentActivePage":
					UseCurrentActivePage = reader.GetBoolValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

