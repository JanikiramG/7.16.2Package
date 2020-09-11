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

	#region Class: TreeGridLoadRowUserTaskSchema

	/// <exclude/>
	public class TreeGridLoadRowUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public TreeGridLoadRowUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public TreeGridLoadRowUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f75d2775-3c53-40fc-b123-f437981440a5");
			RealUId = new Guid("f75d2775-3c53-40fc-b123-f437981440a5");
			Name = "TreeGridLoadRowUserTask";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,85,193,78,219,64,16,61,219,95,49,218,3,177,1,109,218,43,22,18,85,160,17,85,43,80,19,218,11,151,109,60,80,75,182,215,90,175,9,169,241,191,51,187,222,36,78,156,132,246,66,115,136,148,157,55,243,222,188,153,205,94,176,225,16,166,55,151,55,103,48,198,28,149,208,8,248,60,195,66,39,50,135,228,1,110,197,35,66,82,66,94,165,41,72,5,152,21,122,225,83,32,176,145,243,115,27,9,161,246,61,133,186,82,57,60,136,180,196,200,111,124,240,223,168,61,85,136,99,149,196,163,52,193,92,95,95,238,230,233,161,14,113,190,69,121,171,146,76,168,197,72,166,85,150,255,16,105,101,155,235,52,213,143,19,221,184,74,98,126,101,64,150,20,122,172,79,66,65,97,253,104,13,19,37,76,81,41,81,202,7,205,239,174,249,79,252,53,146,185,86,50,45,185,1,76,102,191,49,19,119,37,42,119,28,217,18,229,76,37,133,254,38,114,130,40,170,101,74,242,49,234,91,37,11,84,122,97,5,5,140,77,186,56,198,66,195,183,113,230,202,169,25,21,153,104,149,228,143,173,252,200,54,249,85,138,248,187,156,151,182,153,225,113,97,5,153,108,66,251,158,119,193,152,201,214,206,119,104,237,142,40,98,146,231,73,30,203,57,39,65,228,175,173,224,121,29,232,70,152,187,95,87,207,154,63,162,30,101,69,48,96,12,78,250,147,63,1,98,29,132,134,164,113,68,203,162,142,35,22,90,76,100,165,102,198,228,101,140,175,79,77,170,205,91,31,185,204,149,60,62,75,81,168,192,178,116,11,242,148,12,9,234,166,13,52,158,17,193,88,116,60,244,189,13,11,63,75,149,9,29,244,236,233,182,87,127,104,168,13,216,106,160,6,147,18,151,123,164,91,120,92,90,96,79,44,165,57,129,117,67,18,161,161,15,99,167,61,15,79,119,44,119,24,121,126,3,72,107,250,94,163,198,39,145,6,255,121,222,91,147,165,85,15,234,162,231,205,89,43,173,111,26,159,202,118,224,65,232,116,238,218,140,45,51,9,70,65,99,230,60,239,153,3,47,47,238,32,114,160,118,175,6,251,23,233,254,254,144,115,20,13,163,129,41,102,10,157,184,74,251,246,107,3,72,160,163,163,229,78,237,179,102,201,254,23,230,16,180,113,90,168,243,118,254,196,21,70,239,123,131,250,109,237,28,121,253,177,25,184,91,244,79,119,104,245,15,191,26,248,174,142,14,143,30,214,131,167,30,35,216,182,235,180,243,102,140,100,150,201,156,127,41,151,95,19,84,137,72,147,63,104,209,180,143,27,111,5,255,20,199,173,178,96,45,146,64,126,251,72,187,91,237,187,119,75,171,10,35,246,10,107,197,41,109,251,7,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreatePageParameter());
			Parameters.Add(CreateTreeGridClientIDParameter());
			Parameters.Add(CreatePrimaryColumnValueParameter());
			Parameters.Add(CreateLoadRowsParameter());
		}

		protected virtual ProcessSchemaParameter CreatePageParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("03580f57-aaf3-4040-9e48-068ee2c85902"),
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
				UId = new Guid("ca1d5796-6837-4804-93f8-3a01def3a14b"),
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

		protected virtual ProcessSchemaParameter CreatePrimaryColumnValueParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("97374567-b28f-4a7c-9db3-e7ace09c4ee9"),
				Name = "PrimaryColumnValue",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateLoadRowsParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("ac5713ec-86a9-480b-b113-fc3d88f6f1fd"),
				Name = "LoadRows",
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
				UId = new Guid("115d7a45-5884-4583-af6e-e90166fa183f"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateUpdateFiltersRightExprMetaDataByParameterValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f3fd9844-739e-490e-a405-d52ae0357f29"),
				Name = "UpdateFiltersRightExprMetaDataByParameterValue",
				CreatedInSchemaUId = new Guid("f75d2775-3c53-40fc-b123-f437981440a5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void",
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("cf111c17-8675-4d88-9b3e-a1857e31b444"),
				Name = "process",
				CreatedInSchemaUId = new Guid("f75d2775-3c53-40fc-b123-f437981440a5"),
				ModifiedInSchemaUId = new Guid("f75d2775-3c53-40fc-b123-f437981440a5"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Process",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4fe4e33e-a68d-499d-9a7e-5c2d60ae2776"),
				Name = "filters",
				CreatedInSchemaUId = new Guid("f75d2775-3c53-40fc-b123-f437981440a5"),
				ModifiedInSchemaUId = new Guid("f75d2775-3c53-40fc-b123-f437981440a5"),
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
			return new TreeGridLoadRowUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f75d2775-3c53-40fc-b123-f437981440a5"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new TreeGridLoadRowUserTask(userConnection) {
				SchemaUId = new Guid("f75d2775-3c53-40fc-b123-f437981440a5")
			};
		}

		#endregion

	}

	#endregion

	#region Class: TreeGridLoadRowUserTask

	[DesignModeProperty(Name = "Page", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "f75d27753c5340fcb123f437981440a5", CaptionResourceItem = "Parameters.Page.Caption", DescriptionResourceItem = "Parameters.Page.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "TreeGridClientID", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "f75d27753c5340fcb123f437981440a5", CaptionResourceItem = "Parameters.TreeGridClientID.Caption", DescriptionResourceItem = "Parameters.TreeGridClientID.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "PrimaryColumnValue", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "f75d27753c5340fcb123f437981440a5", CaptionResourceItem = "Parameters.PrimaryColumnValue.Caption", DescriptionResourceItem = "Parameters.PrimaryColumnValue.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "LoadRows", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "f75d27753c5340fcb123f437981440a5", CaptionResourceItem = "Parameters.LoadRows.Caption", DescriptionResourceItem = "Parameters.LoadRows.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class TreeGridLoadRowUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public TreeGridLoadRowUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("f75d2775-3c53-40fc-b123-f437981440a5");
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

		public virtual Guid PrimaryColumnValue {
			get;
			set;
		}

		public virtual bool LoadRows {
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
			
			// TODO: Generate exception if PrimaryColumnValue is empty
			if (PrimaryColumnValue == Guid.Empty) {
				 return false;
			}
			
			var page = Page as Terrasoft.UI.WebControls.PageSchemaUserControl;
			var scriptManager = page.GetPropertyValue("ScriptManager") as ScriptManager;
			var src = String.Empty;
			if (LoadRows) {
				/*pageScript = 
					@"var treeGrid = null;
					if (window.opener) {
						treeGrid = window.opener.window.Ext.getCmp('" + TreeGridClientID + @"');
					}
					if (treeGrid) {
						dataSource = treeGrid.dataSource;
						if (dataSource) {
							treeGrid.clear();
							dataSource.load({});
						}	
					}";*/
				src = String.Format("var treeGrid = Ext.getCmp('{0}'); if (treeGrid) {{ var ds = treeGrid.dataSource; if (ds) {{ treeGrid.clear(); ds.load({{}}); }}}}", TreeGridClientID, PrimaryColumnValue);	
			} else {
				/*pageScript = 
					@"var treeGrid = null;
					if (window.opener) {
						treeGrid = window.opener.window.eval(Ext.getCmp('" + TreeGridClientID + @"');
					}
					if (treeGrid) {
						dataSource = treeGrid.dataSource;
						if (dataSource) {
							dataSource.loadRow({primaryColumnValue:'" + PrimaryColumnValue.ToString() + @"'});
						}	
					}";*/
				/*pageScript = @"
					var wnd = window.opener || window;
					var src = 'var treeGrid = Ext.getCmp(\\'" + TreeGridClientID + @"\\');';
					src += 'var ds = treeGrid.dataSource';
					src += 'ds && ds.loadRow({primaryColumnValue:\\'" + PrimaryColumnValue.ToString() + @"\\'});';
					wnd.eval(src);";*/
				src = String.Format("var treeGrid = Ext.getCmp('{0}'); if (treeGrid) {{ var ds = treeGrid.dataSource; ds && ds.loadRow({{primaryColumnValue:'{1}'}}); }}", TreeGridClientID, PrimaryColumnValue);	
			}
			var pageScript = String.Format("var wnd = window.opener || window; var src = {0}; wnd.eval(src);", Terrasoft.Common.Json.Json.Serialize(src));
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
			if (!HasMapping("PrimaryColumnValue")) {
				writer.WriteValue("PrimaryColumnValue", PrimaryColumnValue, Guid.Empty);
			}
			if (!HasMapping("LoadRows")) {
				writer.WriteValue("LoadRows", LoadRows, false);
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
				case "PrimaryColumnValue":
					PrimaryColumnValue = reader.GetGuidValue();
				break;
				case "LoadRows":
					LoadRows = reader.GetBoolValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

