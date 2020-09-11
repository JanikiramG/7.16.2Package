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

	#region Class: SetControlContextMenuUserTaskSchema

	/// <exclude/>
	public class SetControlContextMenuUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public SetControlContextMenuUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public SetControlContextMenuUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c00edf2e-1e49-48d8-8f0f-ea35d9b13da8");
			RealUId = new Guid("c00edf2e-1e49-48d8-8f0f-ea35d9b13da8");
			Name = "SetControlContextMenuUserTask";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,82,93,107,194,48,20,125,182,191,226,218,23,91,38,97,219,107,231,152,184,57,132,9,3,247,241,48,198,200,234,85,3,105,34,233,173,110,148,254,247,37,169,212,86,92,159,154,123,207,61,247,228,156,220,133,59,110,32,149,200,205,140,48,203,159,68,78,48,130,137,43,204,81,21,190,8,60,7,215,184,201,201,8,181,190,77,130,102,104,90,168,148,132,86,118,102,225,155,236,33,219,210,111,18,136,21,68,39,180,253,17,168,66,202,24,202,160,183,210,6,121,186,129,168,179,30,132,58,209,226,193,189,238,170,139,17,212,66,216,84,155,140,83,20,134,229,101,197,214,72,78,113,20,51,131,153,222,225,88,202,40,78,194,112,216,48,198,73,208,171,130,234,168,173,161,236,119,229,251,173,167,247,59,183,83,171,104,144,106,69,248,67,153,221,61,24,194,234,48,16,197,101,9,229,85,5,85,53,4,218,136,220,75,129,137,5,27,45,39,82,160,162,217,253,176,235,162,21,88,171,123,230,107,132,81,203,47,131,84,24,5,100,10,116,24,231,90,158,26,177,165,57,87,22,107,172,62,55,195,30,145,158,141,222,162,161,223,55,46,11,180,58,23,109,92,24,198,46,205,23,52,134,231,122,69,236,117,198,222,241,251,32,43,103,205,79,103,170,142,179,187,176,157,102,167,195,198,203,101,61,29,157,179,236,96,151,127,92,75,43,123,96,77,250,242,230,37,123,161,150,122,255,113,172,124,218,190,61,48,119,176,246,93,216,167,80,127,53,21,42,254,45,113,114,36,180,112,239,144,107,10,37,168,213,178,79,161,188,174,206,69,208,144,58,216,127,193,248,100,234,84,252,181,147,160,157,72,248,7,64,209,89,124,71,3,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreatePageParameter());
			Parameters.Add(CreateControlClientIDParameter());
			Parameters.Add(CreateMenuClientIDParameter());
			Parameters.Add(CreateClearMenuItemsParameter());
		}

		protected virtual ProcessSchemaParameter CreatePageParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("7a8a0f25-912b-4a41-a2c9-5643f68dc4fb"),
				Name = "Page",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
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
				UId = new Guid("145b1eac-37ae-4008-b4c8-e7176e51bb07"),
				Name = "ControlClientID",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateMenuClientIDParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("6885ba6f-4428-46f5-97b4-e1f71355b227"),
				Name = "MenuClientID",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateClearMenuItemsParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("5a4220d8-9676-4f80-af01-c1df66c359f8"),
				Name = "ClearMenuItems",
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
			Methods.Add(CreateUpdateFiltersRightExprMetaDataByParameterValueMethod());
		}

		protected virtual SchemaMethod CreateUpdateFiltersRightExprMetaDataByParameterValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("04746c0f-2fce-445e-be38-ed372d7d49eb"),
				Name = "UpdateFiltersRightExprMetaDataByParameterValue",
				CreatedInSchemaUId = new Guid("c00edf2e-1e49-48d8-8f0f-ea35d9b13da8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void",
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("15954e23-031f-4fe9-b5b4-1927bfbc39fd"),
				Name = "process",
				CreatedInSchemaUId = new Guid("c00edf2e-1e49-48d8-8f0f-ea35d9b13da8"),
				ModifiedInSchemaUId = new Guid("c00edf2e-1e49-48d8-8f0f-ea35d9b13da8"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Process",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("aebe8776-6096-4591-980b-a3ca8bb57ae4"),
				Name = "filters",
				CreatedInSchemaUId = new Guid("c00edf2e-1e49-48d8-8f0f-ea35d9b13da8"),
				ModifiedInSchemaUId = new Guid("c00edf2e-1e49-48d8-8f0f-ea35d9b13da8"),
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
			return new SetControlContextMenuUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c00edf2e-1e49-48d8-8f0f-ea35d9b13da8"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new SetControlContextMenuUserTask(userConnection) {
				SchemaUId = new Guid("c00edf2e-1e49-48d8-8f0f-ea35d9b13da8")
			};
		}

		#endregion

	}

	#endregion

	#region Class: SetControlContextMenuUserTask

	[DesignModeProperty(Name = "Page", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "c00edf2e1e4948d88f0fea35d9b13da8", CaptionResourceItem = "Parameters.Page.Caption", DescriptionResourceItem = "Parameters.Page.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ControlClientID", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "c00edf2e1e4948d88f0fea35d9b13da8", CaptionResourceItem = "Parameters.ControlClientID.Caption", DescriptionResourceItem = "Parameters.ControlClientID.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "MenuClientID", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "c00edf2e1e4948d88f0fea35d9b13da8", CaptionResourceItem = "Parameters.MenuClientID.Caption", DescriptionResourceItem = "Parameters.MenuClientID.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ClearMenuItems", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "c00edf2e1e4948d88f0fea35d9b13da8", CaptionResourceItem = "Parameters.ClearMenuItems.Caption", DescriptionResourceItem = "Parameters.ClearMenuItems.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class SetControlContextMenuUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public SetControlContextMenuUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("c00edf2e-1e49-48d8-8f0f-ea35d9b13da8");
		}

		#endregion

		#region Properties: Public

		public virtual Object Page {
			get;
			set;
		}

		public virtual string ControlClientID {
			get;
			set;
		}

		public virtual string MenuClientID {
			get;
			set;
		}

		public virtual Object ClearMenuItems {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			var clearItemsList = ClearMenuItems as List<string>;
			var clearFunction = String.Empty;
			if (clearItemsList != null) {
				foreach (var clearItem in clearItemsList) {
					clearFunction += string.Format("{0}.getMenu().removeAll();",clearItem);
				}
			}
			if (clearFunction != String.Empty) {
				clearFunction = string.Format("{0}.on('contextmenu', function(){{ {1} }}, this);", ControlClientID, clearFunction);
			}
			if (Page == null) {
				return true;
			}
			var scriptManager = Page.GetPropertyValue("ScriptManager") as Terrasoft.UI.WebControls.Controls.ScriptManager;
			if (scriptManager != null) {
				scriptManager.AddScript(string.Format("{0}.contextMenuId = '{1}_menu';window['{1}_menu'] = {1}.menu;"+
											"{0}.enableContextMenu = true;{0}.initContextMenu();{2}", ControlClientID,
											MenuClientID, clearFunction));
			}
			Page = null;
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
			if (Page != null) {
				if (Page.GetType().IsSerializable || Page.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("Page", Page, null);
				}
			}
			if (!HasMapping("ControlClientID")) {
				writer.WriteValue("ControlClientID", ControlClientID, null);
			}
			if (!HasMapping("MenuClientID")) {
				writer.WriteValue("MenuClientID", MenuClientID, null);
			}
			if (ClearMenuItems != null) {
				if (ClearMenuItems.GetType().IsSerializable || ClearMenuItems.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ClearMenuItems", ClearMenuItems, null);
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
				case "ControlClientID":
					ControlClientID = reader.GetStringValue();
				break;
				case "MenuClientID":
					MenuClientID = reader.GetStringValue();
				break;
				case "ClearMenuItems":
					ClearMenuItems = reader.GetSerializableObjectValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

