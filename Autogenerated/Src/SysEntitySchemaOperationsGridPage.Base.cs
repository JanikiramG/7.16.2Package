namespace Terrasoft.WebApp
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.ComponentModel;
	using System.Drawing;
	using System.Globalization;
	using System.Text;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: SysEntitySchemaOperationsGridPageSchema

	/// <exclude/>
	public class SysEntitySchemaOperationsGridPageSchema : Terrasoft.WebApp.BaseVirtualGridPageSchema
	{

		#region Constructors: Public

		public SysEntitySchemaOperationsGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SysEntitySchemaOperationsGridPageSchema(SysEntitySchemaOperationsGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("79365464-f6e4-4062-b76b-44e5faf08e0a");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.ModifiedInSchemaUId = new Guid("79365464-f6e4-4062-b76b-44e5faf08e0a");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("79365464-f6e4-4062-b76b-44e5faf08e0a");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("79365464-f6e4-4062-b76b-44e5faf08e0a");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {};
			PrintButton.ModifiedInSchemaUId = new Guid("79365464-f6e4-4062-b76b-44e5faf08e0a");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("79365464-f6e4-4062-b76b-44e5faf08e0a");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.Hidden = true;
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("79365464-f6e4-4062-b76b-44e5faf08e0a");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("79365464-f6e4-4062-b76b-44e5faf08e0a");
			RealUId = new Guid("79365464-f6e4-4062-b76b-44e5faf08e0a");
			Name = "SysEntitySchemaOperationsGridPage";
			ParentSchemaUId = new Guid("dbe94191-fb4c-4c41-b1eb-37ac77da867d");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysEntitySchemaOperationsGridPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateButtonsControlLayout();
			UpdateContextHelpButton();
			UpdatePrintButton();
			UpdateDeleteButton();
			UpdateEditButton();
			UpdateCopyButton();
			UpdateAddButton();
			TopLevelControl.MoveItem(0, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, AddButton);
			ButtonsControlLayout.MoveItem(1, CopyButton);
			ButtonsControlLayout.MoveItem(2, EditButton);
			ButtonsControlLayout.MoveItem(3, DeleteButton);
			ButtonsControlLayout.MoveItem(4, Spacer);
			ButtonsControlLayout.MoveItem(5, PrintButton);
			ButtonsControlLayout.MoveItem(6, ContextHelpButton);
			TopLevelControl.MoveItem(1, TreeGrid);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateSysEntitySchemaOperationsGridPageEventsProcessSchema() {
			var schema = new SysEntitySchemaOperationsGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new SysEntitySchemaOperationsGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new SysEntitySchemaOperationsGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("79365464-f6e4-4062-b76b-44e5faf08e0a"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysEntitySchemaOperationsGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SysEntitySchemaOperationsGridPageEventsProcess

	/// <exclude/>
	public class SysEntitySchemaOperationsGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseVirtualGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.SysEntitySchemaOperationsGridPageSchemaUserControl
	{

		public SysEntitySchemaOperationsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysEntitySchemaOperationsGridPageEventsProcess";
			SchemaUId = new Guid("79365464-f6e4-4062-b76b-44e5faf08e0a");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("79365464-f6e4-4062-b76b-44e5faf08e0a");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return ((Terrasoft.UI.WebControls.Page)Page.AspPage).InstanceId.ToString() + 
				Page.PageContainer.UniqueID;
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		protected override void CompleteApplyingFlowElementsPropertiesData() {
			base.CompleteApplyingFlowElementsPropertiesData();
			foreach (var item in FlowElements) {
				foreach (var itemValue in item.Value) {
					if (Guid.Equals(itemValue.CreatedInSchemaUId, InternalSchemaUId)) {
						itemValue.ExecutedEventHandler = OnExecuted;
					}
				}
			}
		}

		#endregion

		#region Methods: Public

		public override DataSourceRowConfig TreeGridConfigHandler(Entity row) {
			string primaryColumnName = "Id";
			string primaryColumnValue =	row.GetColumnValue(primaryColumnName).ToString();
			var config = new DataSourceRowConfig(primaryColumnValue);
			var icons = new Dictionary<string, ImageConfigValue>();
			foreach(var column in row.Schema.Columns) {
				if (column.Name.Contains("Can")) {
					bool columnValue = row.GetTypedColumnValue<bool>(column.ColumnValueName);	
					string columnIconImageName = columnValue ? "Allow.png" : "Deny.png";
					var imageConfig = new ImageConfigValue(columnIconImageName);
					imageConfig.DisplayImageOnly = true;
					imageConfig.ImagePosition = ImagePosition.Center;
					icons.Add(column.Name, imageConfig);
				}
			}
			var iconConfig = new DataSourceRowColumnIconsConfigValue(icons);
			config.AddConfig(iconConfig);
			return config;
		}

		public override void CellIconClickHandler(object sender, AjaxEventArgs e) {
			var nodeId = e.ExtraParameters["nodeId"];
			var iconId = e.ExtraParameters["iconId"];
			Guid newColumnValue = Guid.Empty;
			if ((nodeId != null) && (iconId != null)) {
				Guid recordId = new Guid (nodeId.Replace("\"", string.Empty));
				var columnName = iconId.Replace("\"", "");
				ChangeRight(recordId, columnName);
				GetDataSource().LoadRow(recordId);
			}
		}

		public override Select CreateSelect() {
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var rightsSchemaName = "SysEntitySchemaOperationRight";
			
			//Код, который компилируется только в Workspace CR173389
			var select = new Select(Page.UserConnection)
				.Column(rightsSchemaName, "Id")
				.Column(rightsSchemaName, "SubjectSchemaUId").As("SubjectSchemaId")
				.Column("VwSysSchemaInWorkspace", "Caption").As("SubjectSchemaCaption")
				.Column(rightsSchemaName, "SysAdminUnitId")
				.Column("SysAdminUnit", "Name").As("SysAdminUnitName")
				.Column(rightsSchemaName,"CanRead")
				.Column(rightsSchemaName,"CanAppend")
				.Column(rightsSchemaName,"CanEdit")
				.Column(rightsSchemaName, "CanDelete")
				.Column(rightsSchemaName, "Position")
				.From(rightsSchemaName)
				.InnerJoin("SysAdminUnit").On("SysAdminUnit", "Id").IsEqual(rightsSchemaName, "SysAdminUnitId")
				.OrderByAsc(rightsSchemaName, "SubjectSchemaUId")
				.OrderByAsc(rightsSchemaName, "Position") as Select;
			select.InnerJoin("VwSysSchemaInWorkspace").On("VwSysSchemaInWorkspace", "UId").IsEqual(rightsSchemaName, "SubjectSchemaUId");
			select.Where("SysEntitySchemaOperationRight", "SysAdminUnitId").IsEqual(Column.Parameter(SelectedNodePrimaryColumnValue));
			select.And("VwSysSchemaInWorkspace", "SysWorkspaceId").IsEqual(Column.Parameter(UserConnection.Workspace.Id));
			
			return select;
		}

		public override List<Dictionary<string, object>> GetStructureDefinition() {
			List<Dictionary<string, object>> structure = new List<Dictionary<string, object>>();
			var schema = UserConnection.EntitySchemaManager.GetInstanceByName("SysEntitySchemaOperationRight");
			var entitySchemaManager = Page.UserConnection.EntitySchemaManager;
			var column = new Dictionary <string, object>() {
					{"Name", "Id"},
					{"ValueColumnName", "Id"},
					{"DisplayColumnName", "Id"},
					{"DataValueType", "Guid"},
					{"Caption",  "Id"},
					{"IsVisible", false},
					{"IsSortable", false},
					{"IsPrimaryColumn", true}
				};
			structure.Add(column);
			
			//Код, который компилируется только в Workspace CR173389
			column = new Dictionary <string, object>() {
				{"Name", "SubjectSchema"},
				{"ValueColumnName", "SubjectSchemaUId"},
				{"DisplayColumnName", "SubjectSchemaCaption"},
				{"DataValueType", "Lookup"},
				{"ReferenceSchemaUId", entitySchemaManager.GetItemByName("VwSysSchemaInWorkspace").UId},
				{"ReferenceSchemaName", "VwSysSchemaInWorkspace"},
				{"ReferenceSchemaPrimaryColumnName", "UId"},
				{"Caption", schema.Columns.GetByName("SubjectSchemaUId").Caption},
				{"IsVisible", true},
				{"IsSortable", false}
			};
			
			structure.Add(column);
			column = new Dictionary <string, object>() {
				{"Name", "SysAdminUnit"},
				{"ValueColumnName", "SysAdminUnitId"},
				{"DisplayColumnName", "SysAdminUnitName"},
				{"DataValueType", "Lookup"},
				{"ReferenceSchemaUId", entitySchemaManager.GetInstanceByName("VwSysAdminUnit").UId},
				{"ReferenceSchemaName", "VwSysAdminUnit"},
				{"ReferenceSchemaPrimaryColumnName", "Id"},
				{"ReferenceSchemaPrimaryDisplayColumnName", "Name"},
				{"Caption", schema.Columns.GetByName("SysAdminUnit").Caption},
				{"IsVisible", false},
				{"IsSortable", false}
			};
			structure.Add(column);
			List<string> iconColumnNames = new List<string>() {
				"CanRead",
				"CanAppend",
				"CanEdit",
				"CanDelete"
			};
			foreach (string columnName in iconColumnNames) {
				column = new Dictionary <string, object>() {
					{"Name", columnName},
					{"ValueColumnName", columnName},
					{"DisplayColumnName", columnName},
					{"DataValueType", "Boolean"},
					{"Caption", schema.Columns.GetByName(columnName).Caption},
					{"IsVisible", true},
					{"IsSortable", false}
				};
				structure.Add(column);
			}
			column = new Dictionary <string, object>() {
				{"Name", "Position"},
				{"ValueColumnName", "Position"},
				{"DisplayColumnName", "Position"},
				{"DataValueType", "Integer"},
				{"Caption", schema.Columns.GetByName("Position").Caption},
				{"IsVisible", false},
				{"IsSortable", false}
			};
			structure.Add(column);
			return structure;
		}

		public virtual void ChangeRight(Guid recordId, string redactedColumnName) {
			var schema = UserConnection.EntitySchemaManager.GetInstanceByName("SysEntitySchemaOperationRight");
			var entity = schema.CreateEntity(Page.UserConnection);
			if (entity.FetchFromDB(recordId)) {
				var subjectSchemaId = entity.GetTypedColumnValue<Guid>("SubjectSchemaUId");
				string schemaName = schema.EntitySchemaManager.GetItemByUId(subjectSchemaId).Name;
				Guid adminUnitId = entity.GetTypedColumnValue<Guid>("SysAdminUnitId");
				var dbSecurityEngine = Page.UserConnection.DBSecurityEngine;
				bool redactedValue = !entity.GetTypedColumnValue<bool>(redactedColumnName);
				var rightLevel = Terrasoft.Core.DB.SchemaOperationRightLevels.None;
				foreach (var column in schema.Columns) {
					if (column.Name == redactedColumnName && redactedColumnName == "CanRead") {
						if (redactedValue) {
							rightLevel += (int)SchemaOperationRightLevels.CanRead;
						}
					} else if (column.Name == "CanRead") {
						if (entity.GetTypedColumnValue<bool>(column.ColumnValueName)) {
							rightLevel += (int)SchemaOperationRightLevels.CanRead;
						}
					}
					if (column.Name == redactedColumnName && redactedColumnName == "CanAppend") {
						if (redactedValue) {
							rightLevel += (int)SchemaOperationRightLevels.CanAppend;
						}
					} else if (column.Name == "CanAppend") {
						if (entity.GetTypedColumnValue<bool>(column.ColumnValueName)) {
							rightLevel += (int)SchemaOperationRightLevels.CanAppend;
						}
					}
					if (column.Name == redactedColumnName && redactedColumnName == "CanEdit") {
						if (redactedValue) {
							rightLevel += (int)SchemaOperationRightLevels.CanEdit;
						}
					} else if (column.Name == "CanEdit") {
						if (entity.GetTypedColumnValue<bool>(column.ColumnValueName)) {
							rightLevel += (int)SchemaOperationRightLevels.CanEdit;
						}
					}
					if (column.Name == redactedColumnName && redactedColumnName == "CanDelete") {
						if (redactedValue) {
							rightLevel += (int)SchemaOperationRightLevels.CanDelete;
						}
					} else if (column.Name == "CanDelete") {
						if (entity.GetTypedColumnValue<bool>(column.ColumnValueName)) {
							rightLevel += (int)SchemaOperationRightLevels.CanDelete;
						}
					}
				}
				Page.UserConnection.DBSecurityEngine.ClearOperationRightsCache();
				dbSecurityEngine.SetEntitySchemaOperationsRightLevel(adminUnitId, schemaName, rightLevel);
				dbSecurityEngine.ClearOperationRightsCache();
			}
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: SysEntitySchemaOperationsGridPageEventsProcess

	/// <exclude/>
	public class SysEntitySchemaOperationsGridPageEventsProcess : SysEntitySchemaOperationsGridPageEventsProcess<Terrasoft.WebApp.SysEntitySchemaOperationsGridPageSchemaUserControl>
	{

		public SysEntitySchemaOperationsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysEntitySchemaOperationsGridPageSchemaUserControl

	/// <exclude/>
	public partial class SysEntitySchemaOperationsGridPageSchemaUserControl : Terrasoft.WebApp.BaseVirtualGridPageSchemaUserControl
	{

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (SysEntitySchemaOperationsGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SysEntitySchemaOperationsGridPageEventsProcess(UserConnection);
				process.Page = this;
				Process = process;
				UserConnection.ProcessEngine.SetProcess(process);
				process.Execute(UserConnection);
				UserConnection.ProcessEngine.SetProcessPropertiesData(process);
			} else {
				process.InternalContext = new ProcessExecutingContext(UserConnection) {
					Process = process
				};
				process.Page = this;
				Process = process;
				UserConnection.ProcessEngine.SetProcess(process);
			}
		}

		protected override void InitializePageSchemaControls() {
			base.InitializePageSchemaControls();
			if (!PageContainer.IsDesignMode) {
					InitializeEmbeddedProcess();
				}
		}

		#endregion

		#region Methods: Public

		public override void AddScript(string script) {
			this.ScriptManager.AddScript(script);
		}

		public override void RegisterClientScriptIncludeInternal(string key, string resourceName) {
			this.ScriptManager.RegisterClientScriptIncludeInternal(key, resourceName);
		}

		public override void RegisterClientScriptBlock(string key, string script) {
			this.ScriptManager.RegisterClientScriptBlock(key, script);
		}

		public override void SetSchemaName() {
			SchemaName = "SysEntitySchemaOperationsGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: SysEntitySchemaOperationsGridPageEventsProcessSchema

	/// <exclude/>
	public class SysEntitySchemaOperationsGridPageEventsProcessSchema : Terrasoft.WebApp.BaseVirtualGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public SysEntitySchemaOperationsGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysEntitySchemaOperationsGridPageEventsProcessSchema(SysEntitySchemaOperationsGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysEntitySchemaOperationsGridPageEventsProcess";
			UId = new Guid("bfc5ae62-39e5-493b-8b26-e6f0b99de964");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateChangeRightMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e0c6ae3c-b3a0-4e06-b747-2bf038a88cc7"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("917cbfdc-72d8-4e11-9182-d5a8af1cdec3"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9c1bc255-2fee-462f-bbc2-ac404082e1f1"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("71df11d8-5543-4198-929a-6a80e3ed540a"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f")
			});
		}

		protected override SchemaMethod CreateTreeGridConfigHandlerMethod() {
			SchemaMethod method = base.CreateTreeGridConfigHandlerMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,82,65,110,195,32,16,60,219,175,64,156,176,20,241,128,58,77,21,57,82,149,75,91,53,81,239,212,198,14,18,94,44,192,141,172,42,127,47,96,210,208,36,234,17,118,118,102,118,118,141,213,2,58,52,104,209,51,61,85,74,142,61,188,176,158,163,71,132,183,13,46,115,115,7,240,193,228,232,16,153,86,71,250,204,109,242,73,110,136,10,186,87,187,192,65,138,50,255,98,26,213,10,90,209,57,1,224,71,180,97,150,237,212,168,107,254,174,142,85,168,144,91,173,216,41,92,171,57,55,138,218,10,5,14,183,156,45,46,208,182,103,29,159,57,66,215,202,43,182,74,115,86,31,200,172,236,25,145,0,228,157,239,234,3,239,25,157,101,76,129,190,243,76,180,136,204,32,234,189,187,26,88,38,192,16,92,49,192,69,192,100,159,74,201,72,21,131,64,49,136,253,52,240,38,177,189,244,208,213,153,49,41,132,96,202,204,145,197,120,103,200,214,205,23,134,136,27,72,69,158,16,94,75,233,116,6,232,48,122,64,120,195,97,10,143,210,209,132,116,46,227,199,140,174,3,33,119,100,10,223,158,180,210,141,48,131,100,83,0,188,130,156,28,151,213,35,191,134,133,250,155,50,194,111,193,97,254,188,105,197,193,114,29,122,252,206,232,186,105,210,96,23,169,89,239,224,148,159,126,55,92,253,115,31,103,251,38,157,42,72,56,150,249,176,188,86,60,164,11,155,171,106,110,71,13,241,250,202,31,30,138,159,195,248,2,0,0 };
			return method;
		}

		protected override SchemaMethod CreateCellIconClickHandlerMethod() {
			SchemaMethod method = base.CreateCellIconClickHandlerMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,142,203,106,195,48,16,69,215,246,87,76,181,8,18,4,255,128,201,42,13,38,16,66,113,33,155,38,139,193,154,218,2,89,10,138,148,52,132,252,123,37,63,74,41,116,59,115,238,61,247,138,14,140,149,180,149,176,2,42,54,95,222,225,27,58,236,201,147,187,124,176,241,199,78,101,126,141,164,106,172,249,143,28,127,137,172,130,146,96,232,182,182,58,244,230,128,58,80,140,164,107,177,233,207,254,94,230,234,19,56,159,180,47,43,48,65,107,1,139,5,240,73,48,223,4,60,242,108,168,115,212,88,39,7,119,108,30,202,96,106,40,106,58,107,108,136,179,35,99,75,184,120,167,76,59,154,132,40,243,44,13,111,134,41,251,56,54,22,140,146,63,49,198,18,187,238,208,180,84,171,182,243,124,86,46,127,165,19,83,145,127,69,143,239,54,184,152,22,197,206,162,172,237,237,135,143,204,243,27,128,8,55,20,87,1,0,0 };
			return method;
		}

		protected override SchemaMethod CreateCreateSelectMethod() {
			SchemaMethod method = base.CreateCreateSelectMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,77,79,219,64,16,61,55,82,254,195,202,39,71,66,70,136,67,169,34,14,38,4,41,149,74,162,68,129,243,54,30,17,67,188,118,103,109,144,111,45,28,91,137,123,127,70,213,74,124,137,254,133,245,63,98,214,27,28,227,132,56,7,31,118,230,205,188,247,102,103,125,201,145,129,136,253,56,29,77,166,16,240,47,92,240,51,64,182,207,198,18,176,19,10,1,147,216,15,133,211,93,6,181,155,141,75,42,71,255,108,26,75,147,57,230,1,80,173,53,74,101,185,160,31,1,114,221,102,168,177,22,21,54,27,219,219,234,183,122,86,127,183,152,122,80,207,217,53,125,223,179,159,234,62,63,170,39,245,95,221,169,71,117,71,193,27,245,47,187,206,126,100,183,76,163,212,99,246,75,67,152,250,195,78,67,188,144,17,159,0,235,12,119,62,238,238,238,125,50,146,36,204,72,54,9,17,112,197,70,249,193,30,144,100,231,173,169,86,179,241,193,233,132,179,36,16,118,213,197,22,179,122,158,85,131,24,37,95,207,169,149,137,141,53,222,113,165,253,54,92,233,98,157,92,209,112,230,41,81,24,176,168,91,135,71,90,213,170,38,69,170,70,79,42,93,47,240,197,88,248,113,149,183,156,211,108,186,228,149,170,148,50,225,117,52,164,83,12,129,215,12,71,163,220,40,2,177,1,174,235,145,164,26,107,4,59,164,139,140,107,196,49,107,16,74,127,49,171,35,12,131,37,84,158,233,209,22,224,231,208,175,142,166,229,244,87,76,43,191,219,158,236,126,75,248,108,211,201,247,209,3,60,72,93,57,217,108,119,234,107,22,222,24,151,243,197,166,199,100,214,189,236,232,157,37,51,222,222,223,192,113,173,205,37,209,11,250,211,41,32,216,53,79,127,197,168,10,62,115,167,206,128,35,145,197,128,182,49,8,222,113,232,193,0,253,128,99,106,48,39,124,150,64,171,196,237,10,111,157,47,138,23,231,245,148,149,191,94,81,229,244,188,156,175,217,64,136,19,20,243,95,76,251,5,251,228,177,48,64,5,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetStructureDefinitionMethod() {
			SchemaMethod method = base.CreateGetStructureDefinitionMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,86,81,107,219,48,16,126,110,32,255,65,248,41,129,224,50,250,176,141,118,129,54,45,37,208,109,37,89,187,103,213,185,182,90,29,201,72,242,138,41,129,173,123,220,96,239,251,25,99,131,110,29,221,95,80,254,209,100,217,142,28,71,110,211,142,62,132,32,221,119,167,187,239,62,233,188,71,132,220,216,38,129,36,140,98,158,108,8,201,9,61,233,32,118,244,14,2,217,237,34,189,17,7,50,230,128,94,32,10,231,104,239,14,135,86,123,189,217,120,143,57,18,193,41,140,177,246,58,16,192,123,140,82,48,62,254,14,149,68,38,67,99,125,137,41,62,1,238,239,130,236,83,33,49,13,96,43,121,133,199,208,242,134,137,40,35,95,71,192,113,234,63,32,39,167,210,43,14,129,197,96,250,196,125,253,239,223,125,108,30,35,96,97,60,166,121,121,182,50,84,45,173,213,70,23,205,198,202,202,133,151,102,232,117,144,215,31,121,147,78,182,117,136,195,24,122,38,146,195,186,77,68,20,226,164,222,142,37,54,17,222,36,145,177,237,198,196,90,123,56,74,115,210,251,115,78,125,113,72,4,57,10,83,135,99,28,10,176,134,33,227,18,59,45,251,156,140,117,113,89,38,218,172,187,11,19,109,156,104,50,102,173,246,55,71,163,86,70,75,74,116,179,177,186,170,190,169,27,245,163,131,212,111,117,51,189,212,191,15,211,207,234,151,89,170,63,234,175,186,82,215,234,74,111,126,82,63,167,151,211,143,211,175,40,69,169,235,233,151,20,130,212,119,244,150,241,51,17,225,0,80,111,240,228,233,218,218,179,231,205,198,61,169,183,204,15,99,99,200,218,153,49,226,236,193,28,238,160,32,175,166,33,115,224,130,244,194,161,218,161,61,198,206,226,168,48,15,224,24,56,104,249,218,147,58,46,113,26,165,75,24,23,42,63,60,215,58,207,16,125,58,99,200,107,251,58,130,59,116,145,108,141,167,219,105,174,235,69,132,18,29,86,97,217,173,245,51,164,72,211,157,93,200,42,149,109,63,119,203,131,148,245,104,100,85,108,47,168,177,217,152,24,89,213,9,238,225,178,72,196,230,104,76,232,1,37,242,54,85,148,96,119,105,162,4,53,123,143,160,135,202,203,103,58,107,203,88,86,11,11,133,47,163,1,91,189,27,237,228,164,204,195,82,202,153,47,167,94,53,246,173,186,69,54,117,162,49,131,41,19,72,23,145,128,81,155,180,40,207,174,28,146,107,71,23,64,7,128,117,123,242,197,102,20,1,181,203,157,145,206,185,88,108,67,8,18,188,44,143,99,198,1,7,167,168,149,5,204,199,72,122,28,34,180,154,64,118,216,131,39,141,141,93,63,111,22,49,174,230,57,80,85,37,111,49,22,2,166,142,241,83,219,98,27,117,190,189,117,175,66,93,127,205,24,90,169,235,240,228,63,94,134,125,38,72,249,61,119,188,10,85,136,83,251,11,160,42,123,125,42,65,95,236,251,220,143,89,204,71,187,27,28,244,38,181,223,114,235,255,0,51,60,236,243,247,9,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateChangeRightMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("05bec882-4f9b-4928-9968-6ae5eddd2dc6"),
				Name = "ChangeRight",
				CreatedInSchemaUId = new Guid("bfc5ae62-39e5-493b-8b26-e6f0b99de964"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("24060f08-e2a9-4c16-803f-875e060852f8"),
				Name = "recordId",
				CreatedInSchemaUId = new Guid("bfc5ae62-39e5-493b-8b26-e6f0b99de964"),
				ModifiedInSchemaUId = new Guid("bfc5ae62-39e5-493b-8b26-e6f0b99de964"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("19f4ff56-7c6c-4a2d-9d6b-547957add19e"),
				Name = "redactedColumnName",
				CreatedInSchemaUId = new Guid("bfc5ae62-39e5-493b-8b26-e6f0b99de964"),
				ModifiedInSchemaUId = new Guid("bfc5ae62-39e5-493b-8b26-e6f0b99de964"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,150,193,110,226,48,16,134,207,84,234,59,184,28,42,71,91,249,5,186,84,42,129,86,72,221,118,85,74,239,38,30,192,171,196,70,182,131,20,173,250,238,29,219,180,4,200,178,57,0,7,114,136,231,255,231,155,223,22,206,138,27,98,179,5,20,156,244,200,196,130,73,181,82,144,57,169,21,27,42,39,93,53,14,171,191,184,226,115,48,236,17,220,72,89,199,85,6,253,234,153,23,64,187,227,202,214,43,95,150,96,184,215,191,202,249,194,117,147,219,203,139,21,54,129,80,130,77,98,55,150,26,224,14,162,144,254,70,111,182,221,221,235,228,140,208,168,99,15,224,178,197,131,209,197,160,79,13,100,218,136,145,72,18,242,247,242,162,227,221,109,57,253,131,186,72,48,18,216,102,173,67,222,183,106,9,34,213,121,89,168,119,158,151,240,243,177,148,226,14,185,235,154,201,72,4,212,142,117,70,170,249,154,210,15,184,65,254,87,30,14,138,126,133,6,116,135,34,97,94,239,77,125,71,194,69,33,213,68,73,215,150,175,178,247,27,73,164,243,179,138,233,24,178,210,160,122,168,230,82,121,192,134,252,216,160,191,93,230,229,83,173,115,98,64,240,204,129,8,205,80,124,117,0,197,11,238,232,151,34,174,248,161,190,97,140,223,228,39,88,65,142,78,111,96,12,183,122,230,88,170,13,32,1,107,58,18,161,218,178,103,29,153,102,88,202,179,5,161,222,46,11,29,136,84,223,199,36,188,176,113,167,59,254,64,196,18,22,183,166,71,246,217,200,245,117,211,91,172,237,166,92,189,2,199,44,163,93,240,219,138,227,107,161,83,155,235,71,143,80,169,92,114,96,150,181,239,109,208,126,248,231,7,193,247,64,26,128,27,33,254,187,5,107,147,218,66,216,134,227,241,30,41,222,251,229,18,212,73,2,142,206,173,35,110,0,57,127,200,251,204,71,138,121,40,164,59,69,200,222,183,117,196,123,16,231,15,120,151,247,72,241,14,32,7,7,167,8,56,58,183,142,184,1,228,252,33,239,51,227,195,255,218,92,59,44,205,129,155,109,107,155,226,31,62,208,112,137,236,222,102,108,12,174,241,115,194,110,168,104,237,42,189,169,93,213,55,181,235,168,217,252,48,12,206,244,9,122,39,216,213,16,9,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysEntitySchemaOperationsGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bfc5ae62-39e5-493b-8b26-e6f0b99de964"));
		}

		#endregion

	}

	#endregion

}

