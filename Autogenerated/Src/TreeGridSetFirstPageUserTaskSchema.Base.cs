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

	#region Class: TreeGridSetFirstPageUserTaskSchema

	/// <exclude/>
	public class TreeGridSetFirstPageUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public TreeGridSetFirstPageUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public TreeGridSetFirstPageUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6600988e-b416-46b7-a3b4-382610a1626a");
			RealUId = new Guid("6600988e-b416-46b7-a3b4-382610a1626a");
			Name = "TreeGridSetFirstPageUserTask";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,82,193,110,194,48,12,61,147,175,136,114,161,21,82,184,47,66,98,130,13,113,152,64,2,182,115,214,186,44,82,73,42,199,29,160,137,127,95,154,150,1,98,218,142,121,207,239,217,126,206,88,12,135,124,189,152,46,30,248,12,44,160,38,224,112,200,160,34,227,44,55,5,95,234,45,112,227,185,173,203,146,59,228,176,171,232,200,2,145,68,102,52,138,76,202,191,88,15,129,106,180,188,208,165,7,197,78,140,253,99,189,70,128,25,154,124,82,26,176,52,159,254,222,230,174,234,207,150,159,26,121,21,7,107,39,215,158,175,1,81,123,87,144,220,204,229,27,188,79,156,37,116,165,151,77,193,42,251,128,157,222,120,192,14,86,209,194,103,104,42,122,209,54,148,96,240,106,44,229,12,104,137,174,2,164,227,171,46,107,72,132,88,93,215,9,145,54,253,110,48,245,51,81,11,7,47,54,22,162,1,169,91,44,64,123,99,115,183,151,193,59,228,36,187,215,211,129,228,22,104,178,171,146,190,16,124,112,159,215,128,7,171,126,170,98,78,103,187,152,75,174,73,175,92,141,89,19,196,153,145,23,84,177,94,163,185,0,81,117,37,147,30,232,217,160,167,38,164,36,85,65,112,234,177,147,16,138,177,155,112,228,99,158,183,171,37,151,45,195,72,172,253,30,241,84,225,213,29,138,176,6,37,190,1,99,158,173,192,117,2,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreatePageParameter());
			Parameters.Add(CreateTreeGridClientIDParameter());
		}

		protected virtual ProcessSchemaParameter CreatePageParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("0bd34be9-47c4-49a1-9f8d-1e8ac895d8de"),
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

		protected virtual ProcessSchemaParameter CreateTreeGridClientIDParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("31d2d8b1-61e6-4f83-869e-871c262968d8"),
				Name = "TreeGridClientID",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
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
				UId = new Guid("5a655350-165c-42f6-b34e-70edf1f17f1c"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateUpdateFiltersRightExprMetaDataByParameterValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f7a42671-fa33-4063-b549-f4ba9a345fed"),
				Name = "UpdateFiltersRightExprMetaDataByParameterValue",
				CreatedInSchemaUId = new Guid("6600988e-b416-46b7-a3b4-382610a1626a"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void",
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("18bf3e54-6859-4f62-bdf3-d77329743371"),
				Name = "process",
				CreatedInSchemaUId = new Guid("6600988e-b416-46b7-a3b4-382610a1626a"),
				ModifiedInSchemaUId = new Guid("6600988e-b416-46b7-a3b4-382610a1626a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Process",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("3b7f30fe-d049-4f25-a266-218b1a80ae8a"),
				Name = "filters",
				CreatedInSchemaUId = new Guid("6600988e-b416-46b7-a3b4-382610a1626a"),
				ModifiedInSchemaUId = new Guid("6600988e-b416-46b7-a3b4-382610a1626a"),
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
			return new TreeGridSetFirstPageUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6600988e-b416-46b7-a3b4-382610a1626a"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new TreeGridSetFirstPageUserTask(userConnection) {
				SchemaUId = new Guid("6600988e-b416-46b7-a3b4-382610a1626a")
			};
		}

		#endregion

	}

	#endregion

	#region Class: TreeGridSetFirstPageUserTask

	[DesignModeProperty(Name = "Page", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "6600988eb41646b7a3b4382610a1626a", CaptionResourceItem = "Parameters.Page.Caption", DescriptionResourceItem = "Parameters.Page.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "TreeGridClientID", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "6600988eb41646b7a3b4382610a1626a", CaptionResourceItem = "Parameters.TreeGridClientID.Caption", DescriptionResourceItem = "Parameters.TreeGridClientID.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class TreeGridSetFirstPageUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public TreeGridSetFirstPageUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("6600988e-b416-46b7-a3b4-382610a1626a");
		}

		#endregion

		#region Properties: Public

		public virtual Object Page {
			get;
			set;
		}

		public virtual string TreeGridClientID {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			// TODO: Generate exception if Page is null or empty
			if (Page == null) {
				return false;
			}
			
			// TODO: Generate exception if TreeGridClientID is null or empty
			if (TreeGridClientID == null) {
				return false;
			}
			
			var page = Page as Terrasoft.UI.WebControls.PageSchemaUserControl;
			var scriptManager = page.GetPropertyValue("ScriptManager") as ScriptManager;
			var pageScript = 
			@"var treeGrid = window.opener.window.Ext.getCmp('" + TreeGridClientID + @"');
			if (treeGrid) {
				dataSource = treeGrid.dataSource;
				if (dataSource) {
					dataSource.setFirstPage();;
				}	
			}";
			
			scriptManager.AddScript(pageScript);
			
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
			if (!HasMapping("TreeGridClientID")) {
				writer.WriteValue("TreeGridClientID", TreeGridClientID, null);
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
				case "TreeGridClientID":
					TreeGridClientID = reader.GetStringValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

