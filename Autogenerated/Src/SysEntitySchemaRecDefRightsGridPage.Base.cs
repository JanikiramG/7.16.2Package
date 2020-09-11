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
	using System.Security;
	using System.Text;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.OperationLog;
	using Terrasoft.Core.Packages;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: SysEntitySchemaRecDefRightsGridPageSchema

	/// <exclude/>
	public class SysEntitySchemaRecDefRightsGridPageSchema : Terrasoft.WebApp.BaseVirtualGridPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.Button _upButton;
		public Terrasoft.UI.WebControls.Controls.Button UpButton {
			get {
				return _upButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _downButton;
		public Terrasoft.UI.WebControls.Controls.Button DownButton {
			get {
				return _downButton;
			}
		}

		#endregion

		#region Constructors: Public

		public SysEntitySchemaRecDefRightsGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SysEntitySchemaRecDefRightsGridPageSchema(SysEntitySchemaRecDefRightsGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("5ba7b94b-3b7d-442b-8e19-20a44f6b5148");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.Hidden = true;
			CopyButton.ModifiedInSchemaUId = new Guid("5ba7b94b-3b7d-442b-8e19-20a44f6b5148");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("5ba7b94b-3b7d-442b-8e19-20a44f6b5148");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("5ba7b94b-3b7d-442b-8e19-20a44f6b5148");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {};
			PrintButton.ModifiedInSchemaUId = new Guid("5ba7b94b-3b7d-442b-8e19-20a44f6b5148");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.HelpContextId = "254";
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("5ba7b94b-3b7d-442b-8e19-20a44f6b5148");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("5ba7b94b-3b7d-442b-8e19-20a44f6b5148");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5ba7b94b-3b7d-442b-8e19-20a44f6b5148");
			RealUId = new Guid("5ba7b94b-3b7d-442b-8e19-20a44f6b5148");
			Name = "SysEntitySchemaRecDefRightsGridPage";
			ParentSchemaUId = new Guid("dbe94191-fb4c-4c41-b1eb-37ac77da867d");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysEntitySchemaRecDefRightsGridPageEventsProcessSchema();
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
			ButtonsControlLayout.InsertItem(4, CreateUpButton());
			ButtonsControlLayout.InsertItem(5, CreateDownButton());
			ButtonsControlLayout.MoveItem(6, Spacer);
			ButtonsControlLayout.MoveItem(7, PrintButton);
			ButtonsControlLayout.MoveItem(8, ContextHelpButton);
			TopLevelControl.MoveItem(1, TreeGrid);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateSysEntitySchemaRecDefRightsGridPageEventsProcessSchema() {
			var schema = new SysEntitySchemaRecDefRightsGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateUpButton() {
			_upButton = new Terrasoft.UI.WebControls.Controls.Button();
			_upButton.UId = new Guid("debf8dda-3901-4ba6-8b2e-7d638b56e2b4");
			_upButton.Name = "UpButton";
			_upButton.CreatedInSchemaUId = new Guid("5ba7b94b-3b7d-442b-8e19-20a44f6b5148");
			_upButton.ModifiedInSchemaUId = new Guid("5ba7b94b-3b7d-442b-8e19-20a44f6b5148");
			_upButton.CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc");
			_upButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_upButton.Tag = "";
			_upButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("5ba7b94b-3b7d-442b-8e19-20a44f6b5148"),
				ImageHash = @"d750648003bd03fa671a61970fb4b87c"
			};
			_upButton.Enabled = false;
			return _upButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateDownButton() {
			_downButton = new Terrasoft.UI.WebControls.Controls.Button();
			_downButton.UId = new Guid("f1deb9c8-c5cd-4aa2-a459-0c33af93e173");
			_downButton.Name = "DownButton";
			_downButton.CreatedInSchemaUId = new Guid("5ba7b94b-3b7d-442b-8e19-20a44f6b5148");
			_downButton.ModifiedInSchemaUId = new Guid("5ba7b94b-3b7d-442b-8e19-20a44f6b5148");
			_downButton.CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc");
			_downButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_downButton.Tag = "";
			_downButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("5ba7b94b-3b7d-442b-8e19-20a44f6b5148"),
				ImageHash = @"69bdd585cf6cddefbae2954e7d7762a7"
			};
			_downButton.Enabled = false;
			return _downButton;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new SysEntitySchemaRecDefRightsGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new SysEntitySchemaRecDefRightsGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5ba7b94b-3b7d-442b-8e19-20a44f6b5148"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysEntitySchemaRecDefRightsGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SysEntitySchemaRecDefRightsGridPageEventsProcess

	/// <exclude/>
	public class SysEntitySchemaRecDefRightsGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseVirtualGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.SysEntitySchemaRecDefRightsGridPageSchemaUserControl
	{

		public SysEntitySchemaRecDefRightsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysEntitySchemaRecDefRightsGridPageEventsProcess";
			SchemaUId = new Guid("5ba7b94b-3b7d-442b-8e19-20a44f6b5148");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5ba7b94b-3b7d-442b-8e19-20a44f6b5148");
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

		private ProcessFlowElement _eventSubProcess2;
		public ProcessFlowElement EventSubProcess2 {
			get {
				return _eventSubProcess2 ?? (_eventSubProcess2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess2",
					SchemaElementUId = new Guid("fdb1e46b-849a-4fa7-83a4-fdea8586cc55"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage2;
		public ProcessFlowElement StartMessage2 {
			get {
				return _startMessage2 ?? (_startMessage2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage2",
					SchemaElementUId = new Guid("f7ce822b-11eb-466d-b315-08ef4bb6fbfe"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask2;
		public ProcessScriptTask ScriptTask2 {
			get {
				return _scriptTask2 ?? (_scriptTask2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask2",
					SchemaElementUId = new Guid("34be9fb9-7c2a-4c83-abcd-c62e15f83a21"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask2Execute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess1;
		public ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("28207991-bff6-4055-a813-dac828febf2d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage1;
		public ProcessFlowElement StartMessage1 {
			get {
				return _startMessage1 ?? (_startMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage1",
					SchemaElementUId = new Guid("85ca07a9-5f91-4584-b072-176ffe22f3ca"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask1;
		public ProcessScriptTask ScriptTask1 {
			get {
				return _scriptTask1 ?? (_scriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask1",
					SchemaElementUId = new Guid("3ecee94a-06e6-4dfb-837e-b99437c26de0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
				});
			}
		}

		private LocalizableString _warning;
		public LocalizableString Warning {
			get {
				return _warning ?? (_warning = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.Warning.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[StartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2 };
			FlowElements[ScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask2 };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess2":
						break;
					case "StartMessage2":
						e.Context.QueueTasks.Enqueue("ScriptTask2");
						break;
					case "ScriptTask2":
						break;
					case "EventSubProcess1":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "ScriptTask1":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage2");
			ActivatedEventElements.Add("StartMessage1");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage2";
					result = StartMessage2.Execute(context);
					break;
				case "ScriptTask2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask2";
					result = ScriptTask2.Execute(context, ScriptTask2Execute);
					break;
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1";
					result = StartMessage1.Execute(context);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
					break;
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

		public virtual bool ScriptTask2Execute(ProcessExecutingContext context) {
			ChangeRightItemPosition(false);
			return true;
		}

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			ChangeRightItemPosition(true);
			return true;
		}

		public override bool GetIsContextHelpButtonHidden() {
			return false;
		}

		public override void PageInitMethod() {
			EditPageUId = new Guid("62fad1a0-975e-4c78-bb1e-e18e1c00cf15");
			base.PageInitMethod();
		}

		public override DataSourceRowConfig TreeGridConfigHandler(Entity row) {
			var config = new DataSourceRowConfig(row.PrimaryColumnValue);
			var icons = new Dictionary<string, ImageConfigValue>();		
			var dataSource = GetDataSource();
			foreach (var column in dataSource.CurrentStructure.Columns) {
				if (column.Name == "RightLevel") {
					var rightId = row.GetTypedColumnValue<Guid>(column.ValueColumnName);
					var columnIconImageName = string.Empty;
					if (rightId == new Guid("{33E0F782-B2E1-DF11-971B-001D60E938C6}")) {
						columnIconImageName = "Allow.png";
					}
					if (rightId == new Guid("{B19D0E8C-B2E1-DF11-971B-001D60E938C6}")) {
						columnIconImageName = "AllowAndGrant.png";
					}
					if (rightId == new Guid("{32E0F782-B2E1-DF11-971B-001D60E938C6}")) {
						columnIconImageName = "Deny.png";
					}
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
			if ((nodeId != null) && (iconId != null)) {
				Guid recordId = (Guid)Json.Deserialize(nodeId, typeof(Guid));
				var column = (string)Json.Deserialize(iconId, typeof(String));
				if (column == "RightLevel") {
					var entity = GetEntity(recordId);
					var rightLevel = entity.GetTypedColumnValue<Guid>("RightLevelId");
					var rightOperation = entity.GetTypedColumnValue<Guid>("OperationId");
					var authorId = entity.GetTypedColumnValue<Guid>("AuthorId");
					var granteeId = entity.GetTypedColumnValue<Guid>("GranteeId");
					var schemaUId = WorkspaceUtilities.GetSchemaUIdById(SelectedNodePrimaryColumnValue, UserConnection);
					var entitySchema =  UserConnection.EntitySchemaManager.GetInstanceByUId(schemaUId);
					bool useDenyRecordRights = entitySchema.UseDenyRecordRights;
					int rightCode = -1;
					if (rightLevel == new Guid("32E0F782-B2E1-DF11-971B-001D60E938C6")) {
						rightCode = 1;
					}
					if (rightLevel == new Guid("33E0F782-B2E1-DF11-971B-001D60E938C6")) {
						rightCode = 2;
					}
					if (rightLevel == new Guid("B19D0E8C-B2E1-DF11-971B-001D60E938C6")) {
						rightCode = useDenyRecordRights ? 0 : 1;
					}
					int operationCode = -1;
					if (rightOperation == new Guid("C742B793-4DF3-E011-A271-00155D04C01D")) {
						operationCode = 0;
					}
					if (rightOperation == new Guid("868FC699-4DF3-E011-A271-00155D04C01D")) {
						operationCode = 1;
					}
					if (rightOperation == new Guid("878FC699-4DF3-E011-A271-00155D04C01D")) {
						operationCode = 2;
					}
					if (rightCode != -1 && operationCode != -1) {
						try {
							recordId = UserConnection.DBSecurityEngine.SetEntitySchemaRecordDefRightLevel(authorId, granteeId, schemaUId,
								(Terrasoft.Core.Configuration.EntitySchemaRecordRightOperation) operationCode, 
								(Terrasoft.Core.Configuration.EntitySchemaRecordRightLevel) rightCode);
							GetDataSource().LoadRow(recordId);
						} catch (SecurityException securityException) {
							MessagePanel messagePanel = ControlUtilities.FindControl(Page.AspPage.Controls[0], "BaseMessagePanel", true) as MessagePanel;
							if (messagePanel != null) {
								messagePanel.Clear();
								messagePanel.AddMessage(Warning, securityException.Message, MessageType.Warning);
							}
						}
					}
				}
			}
		}

		public override List<string> GetButtons() {
			var result = base.GetButtons();
			result.Add(Page.UpButton.Name);
			result.Add(Page.DownButton.Name);
			return result;
		}

		public override void ActivateButtons(bool activate) {
			base.ActivateButtons(activate);
			bool administratedByRecords = true;
			Guid schemaUId = Guid.Empty;
			if (SelectedNodePrimaryColumnValue != Guid.Empty) {
				schemaUId = WorkspaceUtilities.GetSchemaUIdById(SelectedNodePrimaryColumnValue, UserConnection);
			}
			var entitySchema = UserConnection.EntitySchemaManager.FindInstanceByUId(schemaUId);
			if (entitySchema != null) {
				administratedByRecords = entitySchema.AdministratedByRecordsIncludeParents;
			}
			var canChangeRight = administratedByRecords &&
				UserConnection.DBSecurityEngine.GetCanExecuteOperation("CanChangeEntitySchemaRecordDefRight");
			if (!canChangeRight) {
				Page.AddButton.Enabled = false;
				Page.EditButton.Enabled = false;
				Page.DeleteButton.Enabled = false;
				Page.UpButton.Enabled = false;
				Page.DownButton.Enabled = false;
			}
		}

		public override bool RowsDeleteMethod(Guid recordId) {
			UserConnection.DBSecurityEngine.DeleteEntitySchemaRecordDefRightLevel(recordId);
			Normalize();
			return true;
		}

		public override Select CreateSelect() {
			var viewCode = GetViewCode();
			//Page.AddScript(string.Format("{0}.setCustomData('viewCode', '{1}');", Page.AddButton.ClientID, viewCode));
			var page = Page.AspPage as Terrasoft.UI.WebControls.Page;
			var data = new JObject();
			data["viewCode"] = new JValue(viewCode);
			JObject tempData = null;
			string tempDataKey = "tempData";
			if (page.CustomData.ContainsKey(tempDataKey)) {
				tempData = page.CustomData[tempDataKey] as JObject;
			} else {
				tempData = new JObject();
			}
			tempData[Page.AddButton.ClientID] = data;
			page.CustomData["tempData"] = tempData;
			var select = new Terrasoft.Core.DB.Select(Page.UserConnection)
				.Column("SysEntitySchemaRecordDefRight", "Id")
				.Column("Author", "Id").As("AuthorId")
				.Column("Author", "Name").As("AuthorName")
				.Column("Grantee", "Id").As("GranteeId")
				.Column("Grantee", "Name").As("GranteeName")
				.Column("EntitySchemaRecRightOperation", "Id").As("OperationId")
				.Column("EntitySchemaRecRightOperation", "Name").As("OperationName")
				.Column("SysEntitySchemaRecOprRightLvl", "Id").As("RightLevelId")
				.Column("SysEntitySchemaRecOprRightLvl", "Name").As("RightLevelName")
				.Column("Position").As("Position")
				.From("SysEntitySchemaRecordDefRight")
				.InnerJoin("SysAdminUnit").As("Author").On("Author", "Id").IsEqual("SysEntitySchemaRecordDefRight", "AuthorSysAdminUnitId")
				.InnerJoin("SysAdminUnit").As("Grantee").On("Grantee", "Id").IsEqual("SysEntitySchemaRecordDefRight", "GranteeSysAdminUnitId")
				.InnerJoin("EntitySchemaRecRightOperation").On("EntitySchemaRecRightOperation", "Value").IsEqual("SysEntitySchemaRecordDefRight", "Operation")
				.InnerJoin("SysEntitySchemaRecOprRightLvl").On("SysEntitySchemaRecOprRightLvl", "Value").IsEqual("SysEntitySchemaRecordDefRight", "RightLevel")
				.InnerJoin("SysSchema").On("SysSchema", "UId").IsEqual("SysEntitySchemaRecordDefRight", "SubjectSchemaUId")
				.Where("SysSchema", "Id").IsEqual(Terrasoft.Core.DB.Column.Parameter(SelectedNodePrimaryColumnValue))
				.And("SysEntitySchemaRecordDefRight", "Operation").IsEqual(new QueryParameter(viewCode))
				.OrderByAsc("Position") as Terrasoft.Core.DB.Select;
			return select;
		}

		public override List<Dictionary<string, object>> GetStructureDefinition() {
			List<Dictionary<string, object>> structure = new List<Dictionary<string, object>>();
			var schema = UserConnection.EntitySchemaManager.GetInstanceByName("SysEntitySchemaRecordDefRight");
			var entitySchemaManager = Page.UserConnection.EntitySchemaManager;
			var valueListSchemaManager = Page.UserConnection.ValueListSchemaManager;
			var column = new Dictionary<string, object> {
				{"Name", "Id"},
				{"ValueColumnName", "Id"},
				{"DisplayColumnName", "Id"},
				{"DataValueType", "Guid"},
				{"Caption", "Id"},
				{"IsVisible", false},
				{"IsSortable", false},
				{"IsPrimaryColumn", true}
			};
			structure.Add(column);
			column = new Dictionary<string, object> {
				{"Name", "Position"},
				{"ValueColumnName", "Position"},
				{"DisplayColumnName", "Position"},
				{"DataValueType", "Integer"},
				{"Caption", schema.Columns.GetByName("Position").Caption},
				{"IsVisible", false},
				{"IsSortable", false}
			};
			structure.Add(column);
			column = new Dictionary<string, object> {
				{"Name", "Author"},
				{"ValueColumnName", "AuthorId"},
				{"DisplayColumnName", "AuthorName"},
				{"DataValueType", "Lookup"},
				{"ReferenceSchemaUId", entitySchemaManager.GetInstanceByName("VwSysAdminUnit").UId},
				{"ReferenceSchemaName", "VwSysAdminUnit"},
				{"ReferenceSchemaPrimaryColumnName", "Id"},
				{"ReferenceSchemaPrimaryDisplayColumnName", "Name"},
				{"Caption", schema.Columns.GetByName("Author").Caption},
				{"IsVisible", true},
				{"IsSortable", false}
			};
			structure.Add(column);
			column = new Dictionary<string, object> {
				{"Name", "Grantee"},
				{"ValueColumnName", "GranteeId"},
				{"DisplayColumnName", "GranteeName"},
				{"DataValueType", "Lookup"},
				{"ReferenceSchemaUId", entitySchemaManager.GetInstanceByName("VwSysAdminUnit").UId},
				{"ReferenceSchemaName", "VwSysAdminUnit"},
				{"ReferenceSchemaPrimaryColumnName", "Id"},
				{"ReferenceSchemaPrimaryDisplayColumnName", "Name"},
				{"Caption", schema.Columns.GetByName("Grantee").Caption},
				{"IsVisible", true},
				{"IsSortable", false}
			};
			structure.Add(column);
			column = new Dictionary<string, object> {
				{"Name", "Operation"},
				{"ValueColumnName", "OperationId"},
				{"DisplayColumnName", "OperationName"},
				{"DataValueType", "Lookup"},
				{"ReferenceSchemaUId", entitySchemaManager.GetInstanceByName("EntitySchemaRecRightOperation").UId},
				{"ReferenceSchemaName", "EntitySchemaRecRightOperation"},
				{"ReferenceSchemaPrimaryColumnName", "Id"},
				{"ReferenceSchemaPrimaryDisplayColumnName", "Name"},
				{"Caption", schema.Columns.GetByName("Operation").Caption},
				{"IsVisible", false},
				{"IsSortable", false}
			};
			structure.Add(column);
			column = new Dictionary<string, object> {
				{"Name", "RightLevel"},
				{"ValueColumnName", "RightLevelId"},
				{"DisplayColumnName", "RightLevelName"},
				{"DataValueType", "Lookup"},
				{"ReferenceSchemaUId", entitySchemaManager.GetInstanceByName("SysEntitySchemaRecOprRightLvl").UId},
				{"ReferenceSchemaName", "SysEntitySchemaRecOprRightLvl"},
				{"ReferenceSchemaPrimaryColumnName", "Id"},
				{"ReferenceSchemaPrimaryDisplayColumnName", "Name"},
				{"Caption", schema.Columns.GetByName("RightLevel").Caption},
				{"IsVisible", true},
				{"IsSortable", false}
			};
			structure.Add(column);
			return structure;
		}

		public override void ModifyAddPageParameters(Dictionary<string, object> openPageParameters, Dictionary<string, string> queryStringParameters) {
			queryStringParameters["operation"] = string.Format("{0}.getCustomData('viewCode')", Page.AddButton.ClientID);
		}

		public virtual void ChangeRightItemPosition(bool moveUp) {
			var dataSource = GetDataSource();
			Guid recordId = dataSource.ActiveRowPrimaryColumnValue;
			var entity = GetEntity(recordId);
			var position = entity.GetTypedColumnValue<int>("Position");
			position += moveUp ? -1 : 1;
			if (position < 0) {
				return;
			}
			string grouppingColumnNames = "Operation, SubjectSchemaUId";
			string rightsSchemaName = "SysEntitySchemaRecordDefRight";
			StoredProcedure setRecordPositionProcedure = new StoredProcedure(Page.UserConnection, "tsp_SetRecordPosition")
				.WithParameter("TableName", rightsSchemaName)
				.WithParameter("PrimaryColumnName", "Id")
				.WithParameter("PrimaryColumnValue", recordId)
				.WithParameter("GrouppingColumnNames", grouppingColumnNames)
				.WithParameter("Position", position) as StoredProcedure;
			setRecordPositionProcedure.PackageName = Page.UserConnection.DBEngine.SystemPackageName;
			setRecordPositionProcedure.Execute();
			OperationLogger.Instance.LogEntitySchemaRecordDefRightEdit(UserConnection, recordId);
			FillData(null);
		}

		public virtual void Normalize() {
			var viewCode = GetViewCode();
			Select select = new Select(UserConnection)
				.Column("Id")
				.Column("Position")
				.From("SysEntitySchemaRecordDefRight")
				.Where("SubjectSchemaUId").IsEqual(Terrasoft.Core.DB.Column.Parameter(SelectedNodePrimaryColumnValue))
				.And("Operation").IsEqual(new QueryParameter(viewCode))
				.OrderByAsc("Position") as Select;
			Guid recordId = Guid.Empty;
			using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				using (var reader = select.ExecuteReader(dbExecutor)) {
					while(reader.Read()) {
						int columnOrdinal = reader.GetOrdinal("Id");
						recordId = reader.GetGuid(columnOrdinal);
						break;
					}
				}
			}
			if (recordId == Guid.Empty) {
				return;
			}
			SetRecordPosition(recordId, 0);
		}

		public virtual void SetRecordPosition(Guid recordId, int position) {
			string grouppingColumnNames = "Operation, SubjectSchemaUId";
			string rightsSchemaName = "SysEntitySchemaRecordDefRight";
			StoredProcedure setRecordPositionProcedure = new StoredProcedure(Page.UserConnection, "tsp_SetRecordPosition")
				.WithParameter("TableName", rightsSchemaName)
				.WithParameter("PrimaryColumnName", "Id")
				.WithParameter("PrimaryColumnValue", recordId)
				.WithParameter("GrouppingColumnNames", grouppingColumnNames)
				.WithParameter("Position", position) as StoredProcedure;
			setRecordPositionProcedure.PackageName = Page.UserConnection.DBEngine.SystemPackageName;
			setRecordPositionProcedure.Execute();
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "DownButtonClick":
							if (ActivatedEventElements.Contains("StartMessage2")) {
							context.QueueTasks.Enqueue("StartMessage2");
						}
						break;
					case "UpButtonClick":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
						}
						break;
			}
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

	#region Class: SysEntitySchemaRecDefRightsGridPageEventsProcess

	/// <exclude/>
	public class SysEntitySchemaRecDefRightsGridPageEventsProcess : SysEntitySchemaRecDefRightsGridPageEventsProcess<Terrasoft.WebApp.SysEntitySchemaRecDefRightsGridPageSchemaUserControl>
	{

		public SysEntitySchemaRecDefRightsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysEntitySchemaRecDefRightsGridPageSchemaUserControl

	/// <exclude/>
	public partial class SysEntitySchemaRecDefRightsGridPageSchemaUserControl : Terrasoft.WebApp.BaseVirtualGridPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.Button UpButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("UpButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button DownButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("DownButton", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			UpButton.AjaxEvents.Click.Event += UpButtonClick;
			DownButton.AjaxEvents.Click.Event += DownButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			UpButton.AjaxEvents.Click.Event -= UpButtonClick;
			DownButton.AjaxEvents.Click.Event -= DownButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (SysEntitySchemaRecDefRightsGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SysEntitySchemaRecDefRightsGridPageEventsProcess(UserConnection);
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

		public virtual void UpButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("UpButtonClick");
		}

		public virtual void DownButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("DownButtonClick");
		}

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
			SchemaName = "SysEntitySchemaRecDefRightsGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: SysEntitySchemaRecDefRightsGridPageEventsProcessSchema

	/// <exclude/>
	public class SysEntitySchemaRecDefRightsGridPageEventsProcessSchema : Terrasoft.WebApp.BaseVirtualGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public SysEntitySchemaRecDefRightsGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysEntitySchemaRecDefRightsGridPageEventsProcessSchema(SysEntitySchemaRecDefRightsGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysEntitySchemaRecDefRightsGridPageEventsProcess";
			UId = new Guid("970b371a-83aa-4787-9af5-dd4748e8e39e");
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

		protected override ProcessSchemaParameter CreateIsContextHelpButtonInitializedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("40ae2d30-f814-4800-9d98-e16762ed99ec"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Name = @"IsContextHelpButtonInitialized",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane2 = CreateLane2Lane();
			schemaLaneSet1.Lanes.Add(schemaLane2);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaStartMessageEvent startmessage2 = CreateStartMessage2StartMessageEvent();
			eventsubprocess2.FlowElements.Add(startmessage2);
			ProcessSchemaScriptTask scripttask2 = CreateScriptTask2ScriptTask();
			eventsubprocess2.FlowElements.Add(scripttask2);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			eventsubprocess1.FlowElements.Add(startmessage1);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			eventsubprocess1.FlowElements.Add(scripttask1);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateWarningLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateWarningLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b1429e61-4526-49d8-a172-85f8fbe4f2d6"),
				Name = "Warning",
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7"),
				CreatedInSchemaUId = new Guid("970b371a-83aa-4787-9af5-dd4748e8e39e"),
				ModifiedInSchemaUId = new Guid("970b371a-83aa-4787-9af5-dd4748e8e39e")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("a47dd577-a88e-4b2f-aaba-e93640653ecf"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc"),
				CreatedInSchemaUId = new Guid("970b371a-83aa-4787-9af5-dd4748e8e39e"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("970b371a-83aa-4787-9af5-dd4748e8e39e"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("85ca07a9-5f91-4584-b072-176ffe22f3ca"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3ecee94a-06e6-4dfb-837e-b99437c26de0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("d170fc73-bed7-49e7-acde-d8ebafdb9460"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc"),
				CreatedInSchemaUId = new Guid("970b371a-83aa-4787-9af5-dd4748e8e39e"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("970b371a-83aa-4787-9af5-dd4748e8e39e"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f7ce822b-11eb-466d-b315-08ef4bb6fbfe"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("34be9fb9-7c2a-4c83-abcd-c62e15f83a21"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("245d3662-439f-49d4-a56c-078cc702bab5"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc"),
				CreatedInSchemaUId = new Guid("970b371a-83aa-4787-9af5-dd4748e8e39e"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("970b371a-83aa-4787-9af5-dd4748e8e39e"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(1085, 159),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("05b5b5ac-1a71-42c6-9faa-e4a0daad54ea"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("245d3662-439f-49d4-a56c-078cc702bab5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc"),
				CreatedInSchemaUId = new Guid("970b371a-83aa-4787-9af5-dd4748e8e39e"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("970b371a-83aa-4787-9af5-dd4748e8e39e"),
				Name = @"Lane2",
				Position = new Point(29, 0),
				Size = new Size(1056, 159),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("fdb1e46b-849a-4fa7-83a4-fdea8586cc55"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("05b5b5ac-1a71-42c6-9faa-e4a0daad54ea"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc"),
				CreatedInSchemaUId = new Guid("970b371a-83aa-4787-9af5-dd4748e8e39e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("970b371a-83aa-4787-9af5-dd4748e8e39e"),
				Name = @"EventSubProcess2",
				Position = new Point(36, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(178, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f7ce822b-11eb-466d-b315-08ef4bb6fbfe"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fdb1e46b-849a-4fa7-83a4-fdea8586cc55"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc"),
				CreatedInSchemaUId = new Guid("970b371a-83aa-4787-9af5-dd4748e8e39e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DownButtonClick",
				ModifiedInSchemaUId = new Guid("970b371a-83aa-4787-9af5-dd4748e8e39e"),
				Name = @"StartMessage2",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("34be9fb9-7c2a-4c83-abcd-c62e15f83a21"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fdb1e46b-849a-4fa7-83a4-fdea8586cc55"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc"),
				CreatedInSchemaUId = new Guid("970b371a-83aa-4787-9af5-dd4748e8e39e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("970b371a-83aa-4787-9af5-dd4748e8e39e"),
				Name = @"ScriptTask2",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,206,72,204,75,79,13,202,76,207,40,241,44,73,205,13,200,47,206,44,201,204,207,211,72,75,204,41,78,213,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,153,196,212,58,45,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("28207991-bff6-4055-a813-dac828febf2d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("05b5b5ac-1a71-42c6-9faa-e4a0daad54ea"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc"),
				CreatedInSchemaUId = new Guid("970b371a-83aa-4787-9af5-dd4748e8e39e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("970b371a-83aa-4787-9af5-dd4748e8e39e"),
				Name = @"EventSubProcess1",
				Position = new Point(36, 174),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(178, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("85ca07a9-5f91-4584-b072-176ffe22f3ca"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("28207991-bff6-4055-a813-dac828febf2d"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc"),
				CreatedInSchemaUId = new Guid("970b371a-83aa-4787-9af5-dd4748e8e39e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"UpButtonClick",
				ModifiedInSchemaUId = new Guid("970b371a-83aa-4787-9af5-dd4748e8e39e"),
				Name = @"StartMessage1",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3ecee94a-06e6-4dfb-837e-b99437c26de0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("28207991-bff6-4055-a813-dac828febf2d"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc"),
				CreatedInSchemaUId = new Guid("970b371a-83aa-4787-9af5-dd4748e8e39e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("970b371a-83aa-4787-9af5-dd4748e8e39e"),
				Name = @"ScriptTask1",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,206,72,204,75,79,13,202,76,207,40,241,44,73,205,13,200,47,206,44,201,204,207,211,40,41,42,77,213,180,230,229,42,74,45,41,45,202,83,0,113,173,1,216,45,42,23,44,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateChangeRightItemPositionMethod());
			Methods.Add(CreateNormalizeMethod());
			Methods.Add(CreateSetRecordPositionMethod());
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
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74211cba-57f0-461b-a892-5931c4748eac"),
				Name = "Terrasoft.Core.OperationLog",
				Alias = "",
				CreatedInPackageId = new Guid("0bea0088-e6a2-4f3a-b02e-e01a15923e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("01bc7cbf-01e6-45a0-92dd-4eef52197003"),
				Name = "System.Security",
				Alias = "",
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e54748e6-3005-48b5-8145-75e9945f4381"),
				Name = "Terrasoft.Core.Packages",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
		}

		protected override SchemaMethod CreateGetIsContextHelpButtonHiddenMethod() {
			SchemaMethod method = base.CreateGetIsContextHelpButtonHiddenMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,75,204,41,78,181,6,0,112,193,6,27,13,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreatePageInitMethodMethod() {
			SchemaMethod method = base.CreatePageInitMethodMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,77,201,44,9,72,76,79,13,245,76,81,176,85,200,75,45,87,112,47,205,76,209,80,50,51,74,75,76,49,76,52,208,181,52,55,77,213,53,73,54,183,208,77,74,50,76,213,77,53,180,72,53,76,54,48,72,78,51,52,85,210,180,230,74,74,44,78,213,3,25,224,153,151,89,226,155,90,146,145,159,162,161,105,13,0,192,197,22,100,86,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateTreeGridConfigHandlerMethod() {
			SchemaMethod method = base.CreateTreeGridConfigHandlerMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,83,91,107,194,48,20,126,174,191,34,244,169,130,45,173,130,83,188,128,182,85,132,177,137,142,189,135,54,214,64,155,74,154,42,69,252,239,59,73,188,84,17,25,108,143,77,190,219,73,191,179,199,28,69,57,219,208,4,141,16,35,7,20,96,129,215,121,201,35,178,202,15,190,186,177,120,126,112,150,156,102,152,87,126,158,150,25,251,198,105,73,154,131,198,30,216,20,232,197,133,76,35,65,115,6,184,97,33,56,101,73,11,45,50,156,16,173,163,88,99,171,57,48,12,197,140,175,86,64,159,19,113,179,6,76,99,147,115,130,163,45,178,246,42,162,180,69,148,213,72,142,95,114,78,152,88,11,94,70,162,228,112,160,80,69,19,29,27,6,221,32,75,179,156,15,156,129,195,8,153,43,154,108,197,59,217,147,212,84,24,67,74,115,121,184,136,33,130,28,19,98,124,85,59,18,215,230,28,206,75,26,143,47,98,234,72,223,74,93,8,170,101,244,245,2,30,67,77,172,61,145,126,5,39,204,118,162,146,72,153,234,106,168,223,76,170,91,230,177,211,9,221,217,91,175,109,79,219,161,103,7,51,207,179,251,111,222,212,118,93,47,232,186,97,191,211,243,187,39,179,169,115,27,207,221,204,73,154,194,12,59,150,152,210,236,244,210,112,234,245,3,55,236,249,127,55,156,176,120,206,49,19,191,52,238,180,255,97,210,128,176,234,206,79,85,241,214,181,115,33,31,219,103,61,145,83,191,176,70,117,2,90,236,82,92,41,192,39,75,43,208,130,138,145,71,152,186,95,230,5,149,149,7,204,221,183,227,67,51,9,87,28,185,32,206,36,142,235,125,108,213,195,202,4,167,198,233,186,78,254,139,133,188,196,47,234,83,41,11,181,87,122,151,165,219,121,119,111,122,224,194,9,236,9,59,47,252,224,7,47,190,202,156,252,3,0,0 };
			return method;
		}

		protected override SchemaMethod CreateCellIconClickHandlerMethod() {
			SchemaMethod method = base.CreateCellIconClickHandlerMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,85,209,110,218,48,20,125,78,165,254,131,203,195,20,164,16,5,104,11,108,235,38,72,66,213,169,221,16,180,235,67,213,7,47,185,128,181,96,35,219,105,203,38,254,125,142,157,64,128,162,118,237,3,133,218,231,158,115,124,175,239,245,3,230,136,178,24,46,98,116,134,192,13,159,36,199,3,204,241,12,36,112,113,87,49,123,149,251,79,135,7,15,10,74,34,70,247,65,205,158,134,146,49,178,237,156,246,232,12,209,52,73,170,232,195,7,100,231,241,197,90,21,253,61,60,176,206,83,18,35,14,17,227,177,230,182,179,133,234,55,193,168,27,128,0,78,112,66,254,64,206,231,32,185,152,3,27,27,80,85,137,89,153,177,136,37,233,140,102,193,66,114,66,39,187,225,70,122,21,62,50,48,77,144,217,45,8,206,80,101,72,38,83,121,9,15,144,84,140,65,173,0,84,18,185,80,10,231,32,67,253,219,46,60,107,18,13,226,171,208,44,71,26,229,42,252,181,210,140,125,173,240,19,39,41,124,206,204,127,177,75,74,42,113,91,44,63,230,192,177,36,140,190,138,105,133,222,32,194,169,156,50,110,10,246,34,69,55,7,151,226,39,28,83,9,240,74,130,243,2,93,98,16,209,20,102,248,70,51,220,50,254,91,204,113,4,55,146,36,68,18,16,25,219,168,64,244,22,23,177,61,130,4,34,9,241,119,85,236,1,39,51,204,23,37,37,7,221,168,130,250,140,82,5,82,135,93,235,24,119,134,75,73,109,225,220,176,180,125,133,41,158,0,207,180,47,168,144,152,70,208,91,40,125,123,229,213,208,254,98,44,65,169,128,0,232,98,168,43,173,203,37,86,185,48,116,238,205,46,68,199,19,42,77,37,125,117,22,21,84,171,155,101,117,217,202,215,68,181,2,60,162,44,133,118,165,217,8,189,126,171,221,168,245,26,97,189,22,244,235,245,90,167,85,239,213,60,175,30,156,122,97,167,217,246,79,43,121,215,88,86,153,220,112,47,95,20,104,190,85,160,241,58,129,94,189,19,120,97,219,255,127,129,231,50,253,21,121,232,227,198,217,84,78,89,113,213,247,228,181,212,56,101,103,126,235,184,209,107,117,154,181,227,160,223,172,133,158,114,214,109,180,234,153,179,147,147,192,59,246,149,195,181,179,109,17,239,153,227,239,17,106,159,182,251,254,105,167,243,54,161,231,10,185,79,168,245,30,161,231,10,170,183,142,178,148,102,211,122,51,66,47,23,100,146,47,242,95,86,105,112,111,53,93,208,27,65,148,114,213,41,33,157,16,10,238,168,152,156,166,115,76,169,3,24,175,199,160,93,76,44,103,61,123,156,245,16,113,140,164,101,95,3,231,88,176,177,116,125,198,65,253,161,99,50,73,141,91,119,87,99,184,145,197,234,230,201,28,244,30,86,109,187,186,110,116,51,59,44,75,77,151,0,75,60,98,41,143,192,174,186,151,12,199,67,246,184,245,102,88,75,20,97,25,77,145,189,74,213,83,4,115,93,107,177,189,82,36,223,186,2,33,212,8,27,96,170,218,111,86,254,231,12,41,211,146,179,100,61,98,251,132,198,249,162,61,80,64,183,43,230,250,59,95,20,119,222,189,131,42,61,44,160,204,91,81,47,37,79,161,138,176,64,229,245,252,120,217,149,217,80,94,61,243,185,71,171,188,235,250,9,96,110,23,185,217,220,235,198,113,46,96,223,98,78,213,171,236,236,158,221,205,33,78,97,38,123,132,220,28,95,240,46,77,74,139,123,173,62,203,127,152,255,162,220,224,8,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetButtonsMethod() {
			SchemaMethod method = base.CreateGetButtonsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,40,74,45,46,205,41,81,176,85,72,74,44,78,213,115,79,45,113,42,45,41,201,207,43,214,208,180,230,229,130,72,234,57,166,164,104,4,36,166,167,234,133,22,64,100,245,252,18,115,83,177,41,112,201,47,207,195,80,82,82,90,148,7,181,199,26,0,160,102,188,183,115,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateActivateButtonsMethod() {
			SchemaMethod method = base.CreateActivateButtonsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,146,193,110,194,48,12,134,207,67,226,29,2,7,84,164,169,47,48,237,64,75,135,56,108,67,160,110,103,147,24,136,150,58,85,146,178,85,19,239,62,119,133,173,76,67,28,227,124,254,127,255,78,214,224,49,158,200,160,247,16,48,169,66,176,228,35,56,158,199,119,253,222,218,90,35,64,21,154,180,15,142,139,42,169,151,40,173,83,94,220,139,224,42,100,104,86,105,37,188,220,97,1,249,92,113,189,41,196,89,81,134,154,111,245,70,68,43,52,40,185,249,201,42,92,56,93,128,171,83,107,170,130,94,192,84,40,6,221,150,177,248,236,247,110,186,114,175,214,189,249,18,36,230,65,27,29,52,250,120,134,97,117,34,146,122,174,174,56,220,138,220,163,75,45,17,67,218,82,19,237,208,239,237,193,9,164,160,67,221,138,177,215,57,23,103,157,219,71,32,216,162,139,31,52,169,57,249,0,36,49,169,121,128,232,103,216,241,49,239,153,40,167,163,202,152,54,215,197,93,118,91,226,201,191,212,156,164,169,56,30,56,134,253,111,4,9,148,238,128,182,184,212,219,93,96,173,11,38,163,17,15,240,39,224,52,89,161,172,28,91,103,180,213,132,205,102,83,160,236,131,171,1,159,75,100,13,230,162,97,122,50,233,174,164,85,158,226,230,219,121,120,138,63,56,159,168,77,190,224,229,113,48,213,126,51,222,44,172,13,54,207,187,1,227,155,111,212,18,153,210,225,10,50,229,183,62,125,215,139,80,94,94,83,177,239,116,17,57,124,1,133,165,165,198,26,3,0,0 };
			return method;
		}

		protected override SchemaMethod CreateRowsDeleteMethodMethod() {
			SchemaMethod method = base.CreateRowsDeleteMethodMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,29,200,65,14,64,48,16,5,208,189,83,88,178,113,1,59,218,133,68,44,136,3,72,125,53,73,77,147,49,149,112,122,98,249,222,124,66,218,200,12,167,20,185,50,205,4,151,132,244,182,236,137,81,25,4,40,44,235,87,147,219,113,44,35,92,148,213,96,27,201,239,218,227,66,40,228,191,110,45,235,108,136,114,44,129,30,20,31,4,154,132,115,149,132,250,5,45,165,74,182,106,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateCreateSelectMethod() {
			SchemaMethod method = base.CreateCreateSelectMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,85,77,111,226,48,16,61,47,18,255,33,202,133,68,66,233,238,25,237,129,143,182,162,187,42,108,89,218,3,234,193,37,3,120,149,216,236,216,161,66,136,255,190,227,56,33,95,91,40,167,200,51,111,222,123,30,79,236,29,67,103,199,225,125,40,67,112,190,59,247,160,159,179,149,231,247,218,173,155,155,41,91,67,208,15,195,217,18,249,86,123,74,35,23,235,224,78,98,204,180,231,30,190,30,3,5,122,152,40,45,227,17,211,204,235,228,108,157,174,211,57,124,59,118,252,158,219,117,114,150,65,162,181,20,193,48,226,32,244,120,212,61,105,251,70,109,71,102,182,132,36,35,182,64,109,205,215,97,202,249,13,136,76,201,149,14,230,227,224,5,222,134,82,104,148,145,10,12,32,43,13,73,159,74,5,188,59,15,147,183,63,176,212,233,30,76,120,225,230,66,238,107,14,121,102,81,2,222,201,0,33,179,42,71,67,188,29,101,100,73,20,81,198,110,251,148,248,1,123,202,185,249,210,37,4,95,57,158,241,30,20,189,8,140,73,198,133,34,184,87,42,245,125,231,208,110,125,41,169,212,10,23,37,240,171,217,125,102,140,100,142,14,68,10,234,245,245,45,31,219,173,60,187,248,160,245,166,13,166,51,132,174,171,23,251,50,160,124,145,53,89,65,100,90,100,53,139,83,25,74,132,96,52,8,102,105,218,75,69,231,10,144,90,32,40,192,165,240,201,50,193,162,36,22,158,59,219,171,91,161,185,222,207,150,27,136,217,19,44,37,134,35,88,61,241,245,70,211,188,184,227,208,173,20,244,19,189,145,152,103,104,50,242,208,199,192,71,22,67,5,106,3,101,240,61,50,161,1,42,180,89,172,206,91,130,150,136,179,104,147,185,182,187,116,95,147,45,32,51,173,168,232,157,162,117,197,139,20,37,31,167,120,211,73,179,213,147,45,166,100,63,119,81,197,137,13,194,14,162,186,149,139,28,37,43,5,75,211,203,84,42,158,186,183,208,98,105,64,119,40,227,75,147,145,2,199,52,82,248,32,185,53,214,15,99,46,230,130,235,202,89,211,98,210,28,155,177,186,253,155,176,232,19,243,103,11,203,244,121,79,206,171,231,99,98,229,235,243,245,121,253,172,242,130,129,243,35,98,61,92,28,163,244,30,188,202,92,73,162,217,145,51,131,98,13,93,28,166,235,13,21,51,247,63,71,182,170,80,207,214,84,55,191,242,84,102,73,122,199,218,244,60,63,144,151,13,32,212,152,43,196,205,107,210,254,16,244,120,33,253,35,26,208,179,247,38,132,143,244,20,77,145,199,12,247,22,147,54,195,79,117,250,34,188,238,112,78,6,204,93,253,43,1,220,23,130,197,195,107,168,39,24,2,14,246,125,181,44,255,149,213,135,183,122,197,211,115,128,160,19,20,217,139,208,251,7,51,30,130,84,74,8,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetStructureDefinitionMethod() {
			SchemaMethod method = base.CreateGetStructureDefinitionMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,151,93,107,194,48,20,134,175,39,248,31,74,175,20,164,127,64,39,56,29,34,184,41,58,189,143,237,81,179,181,73,73,82,165,136,255,125,105,250,225,71,99,235,4,197,139,93,137,57,239,57,201,121,243,156,90,135,152,139,86,15,219,2,83,130,88,216,226,130,97,178,106,24,116,241,13,182,104,183,13,185,16,216,34,96,96,188,26,4,182,198,176,36,161,86,111,86,43,27,196,12,110,175,193,67,50,107,198,129,117,41,33,160,114,172,119,34,176,8,167,42,250,129,8,90,1,179,250,32,6,132,11,68,108,120,11,63,145,7,53,115,26,242,99,229,4,108,202,156,30,44,39,120,181,22,102,186,9,228,139,201,29,199,242,211,42,223,54,169,177,65,110,0,81,91,215,148,153,107,197,73,37,155,186,129,71,18,163,46,123,100,236,170,149,151,157,25,245,105,54,12,115,224,152,251,134,90,81,197,187,170,72,62,216,195,220,119,81,120,49,140,4,82,249,95,161,175,66,253,0,103,193,46,242,163,179,156,102,12,248,28,115,188,112,35,245,18,185,28,178,245,41,101,2,233,2,99,134,61,217,80,124,6,25,149,108,192,190,90,217,203,254,51,78,172,142,227,212,98,39,162,91,186,205,147,49,229,88,157,248,178,51,231,18,173,63,57,209,185,75,3,34,64,94,96,222,168,24,95,43,46,199,35,66,83,50,179,154,117,43,145,255,221,208,123,120,214,9,196,154,178,2,199,98,65,9,81,177,72,125,187,228,217,144,210,159,192,79,195,19,88,2,3,57,185,241,68,204,100,253,134,110,46,117,67,62,223,202,49,239,56,30,38,51,130,229,84,91,50,91,95,54,61,222,89,134,94,124,130,105,126,84,244,106,173,27,199,62,92,195,70,114,7,69,100,168,153,121,40,24,125,134,36,229,80,64,70,162,40,65,35,81,253,179,113,27,27,233,53,60,23,28,35,31,24,42,121,212,102,154,18,64,50,221,131,16,57,123,65,80,175,6,135,126,174,32,166,184,192,179,1,116,220,218,83,253,242,40,223,134,176,1,183,0,162,131,168,132,162,131,240,65,24,229,95,53,71,62,139,79,177,113,175,193,168,184,192,179,97,116,116,91,247,122,20,49,144,139,228,240,223,161,249,11,189,193,32,40,103,12,0,0 };
			return method;
		}

		protected override SchemaMethod CreateModifyAddPageParametersMethod() {
			SchemaMethod method = base.CreateModifyAddPageParametersMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,29,201,177,10,194,48,16,6,224,87,9,89,218,130,4,119,233,80,83,132,110,5,71,113,56,200,17,2,38,167,151,63,150,34,190,187,224,183,126,175,198,186,95,161,169,196,149,148,50,131,181,222,172,60,89,9,73,138,189,155,209,212,255,187,139,104,38,244,246,115,252,186,200,240,173,66,242,76,160,190,123,39,222,188,4,238,6,123,48,43,69,118,83,8,231,6,72,113,254,145,184,96,153,135,211,15,99,185,213,94,109,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateChangeRightItemPositionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4ae1056b-4c06-4f3d-96bf-3da7d09fa685"),
				Name = "ChangeRightItemPosition",
				CreatedInSchemaUId = new Guid("970b371a-83aa-4787-9af5-dd4748e8e39e"),
				CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b8a942fd-4f98-4a48-bbe0-8937e5941506"),
				Name = "moveUp",
				CreatedInSchemaUId = new Guid("970b371a-83aa-4787-9af5-dd4748e8e39e"),
				ModifiedInSchemaUId = new Guid("970b371a-83aa-4787-9af5-dd4748e8e39e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,147,77,111,211,64,16,134,207,245,175,24,237,201,22,193,162,87,220,80,65,19,162,72,8,172,184,129,99,181,181,167,206,130,189,107,205,206,166,68,136,255,206,218,142,221,144,186,112,219,143,231,157,157,153,119,103,47,9,10,201,50,51,142,114,132,57,172,144,23,227,62,140,146,96,229,84,1,132,185,161,98,93,120,224,137,142,223,231,172,246,184,49,143,41,169,90,210,225,198,84,174,214,95,101,229,48,9,246,62,50,106,86,124,232,163,46,187,117,56,68,138,122,162,49,86,177,50,218,51,61,28,123,244,246,208,96,113,18,236,74,105,126,23,138,244,200,10,175,29,117,175,230,80,155,61,110,27,184,134,215,151,240,22,46,147,64,61,64,56,2,87,240,38,130,95,193,5,33,59,210,73,240,59,176,76,74,151,80,146,113,77,227,87,253,75,159,101,141,214,167,33,190,52,72,178,149,206,32,115,247,223,49,231,44,223,97,45,183,235,66,36,131,152,84,185,99,219,95,180,202,86,152,29,108,95,100,127,188,233,42,93,224,195,166,101,189,52,99,67,88,164,100,114,44,28,33,88,228,158,25,10,123,186,154,131,198,71,56,19,132,169,44,49,222,90,164,27,163,181,207,171,203,81,176,109,238,178,243,80,34,10,46,226,111,138,119,169,36,159,30,35,133,226,86,222,87,216,38,43,102,207,242,159,192,255,50,245,40,19,190,7,255,67,59,203,218,39,6,167,159,243,171,137,214,123,197,148,35,83,175,13,53,206,198,239,19,129,180,231,237,242,94,189,216,224,56,149,249,15,223,205,163,117,19,141,141,23,31,150,186,84,26,99,111,43,99,125,34,248,103,224,229,79,204,29,119,147,51,126,164,79,166,44,145,226,181,182,44,181,159,27,191,127,249,163,44,11,197,225,185,201,39,83,243,81,85,85,59,161,161,118,85,21,37,127,0,237,55,160,252,193,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateNormalizeMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("37cc78c7-769a-428b-8832-4652d6289308"),
				Name = "Normalize",
				CreatedInSchemaUId = new Guid("970b371a-83aa-4787-9af5-dd4748e8e39e"),
				CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,82,203,110,194,48,16,60,131,196,63,88,57,57,82,21,245,30,113,224,145,34,46,133,66,161,103,19,47,224,54,177,233,218,134,70,85,255,189,155,56,16,144,242,176,215,179,179,59,179,62,11,100,103,5,151,137,145,192,134,108,6,110,219,238,120,156,14,250,107,40,32,119,204,134,223,144,105,184,176,16,227,27,11,56,49,90,211,90,25,29,15,250,189,100,98,10,95,106,30,205,101,244,176,95,26,171,106,80,136,190,160,41,121,180,174,108,166,157,114,213,58,63,66,41,86,144,27,148,83,216,175,212,225,232,2,240,227,8,8,132,244,187,79,42,18,112,155,154,59,153,219,236,219,139,130,191,3,162,176,102,239,168,20,66,50,29,183,37,147,165,64,81,130,3,228,161,91,144,175,36,105,137,170,20,88,5,204,86,20,30,226,166,208,72,75,30,45,78,128,34,116,121,227,175,229,190,121,192,170,227,187,154,21,50,23,40,1,199,213,200,230,247,42,153,176,173,75,100,225,204,43,201,176,145,55,151,181,197,180,79,178,242,228,42,58,244,86,233,3,227,103,154,130,220,101,63,144,123,103,144,64,143,230,38,153,182,30,97,58,238,66,60,142,217,47,117,112,71,128,32,168,25,74,14,211,74,2,29,172,154,48,239,232,219,204,222,229,168,10,224,33,43,169,81,87,206,94,79,105,199,242,198,37,18,168,180,40,136,181,5,210,13,105,99,97,206,105,147,112,167,175,195,213,74,249,3,77,139,222,17,230,171,89,254,209,135,94,122,212,158,241,142,229,222,166,208,20,130,243,168,211,6,187,6,23,238,203,213,242,91,230,19,123,142,211,127,213,71,144,229,212,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetRecordPositionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("95eea540-eca6-4d73-ab38-3bc1e0d48843"),
				Name = "SetRecordPosition",
				CreatedInSchemaUId = new Guid("970b371a-83aa-4787-9af5-dd4748e8e39e"),
				CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("84b8147f-0b57-4874-a482-04172de2168f"),
				Name = "recordId",
				CreatedInSchemaUId = new Guid("970b371a-83aa-4787-9af5-dd4748e8e39e"),
				ModifiedInSchemaUId = new Guid("970b371a-83aa-4787-9af5-dd4748e8e39e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("36932d20-eea6-472d-9505-1d63c5e104bc"),
				Name = "position",
				CreatedInSchemaUId = new Guid("970b371a-83aa-4787-9af5-dd4748e8e39e"),
				ModifiedInSchemaUId = new Guid("970b371a-83aa-4787-9af5-dd4748e8e39e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "int",
				CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,145,193,78,195,48,12,134,207,244,41,162,156,90,169,234,11,76,187,176,85,104,23,136,86,6,71,148,165,166,13,180,73,229,56,130,189,61,105,59,52,84,2,187,89,241,255,217,127,126,59,66,109,26,214,160,245,195,16,170,141,237,124,111,238,101,15,142,173,25,127,24,0,37,105,107,114,86,249,227,27,40,170,84,11,189,60,236,106,190,74,220,12,163,110,90,114,115,99,36,71,176,58,185,210,144,166,211,252,188,7,101,177,222,194,235,126,212,6,180,34,139,80,11,180,10,106,143,192,28,208,172,17,214,233,113,225,165,181,102,6,62,216,2,72,133,108,160,56,56,192,141,53,38,248,154,60,114,114,195,75,181,28,197,179,228,166,120,214,212,10,137,193,30,1,166,252,81,30,59,24,205,242,252,151,255,136,92,160,238,37,158,46,233,4,140,135,12,174,73,159,100,231,167,21,147,161,93,29,209,223,69,162,15,68,236,34,177,109,223,127,204,217,112,46,51,38,221,50,174,112,171,63,3,46,132,84,239,33,205,243,233,34,193,22,219,219,210,52,218,64,17,206,74,208,255,0,254,29,92,126,130,242,4,105,182,74,190,0,104,126,221,51,104,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysEntitySchemaRecDefRightsGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("970b371a-83aa-4787-9af5-dd4748e8e39e"));
		}

		#endregion

	}

	#endregion

}

