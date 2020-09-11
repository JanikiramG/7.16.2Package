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

	#region Class: SysModuleReportTableFieldsGridPageSchema

	/// <exclude/>
	public class SysModuleReportTableFieldsGridPageSchema : Terrasoft.WebApp.BaseVirtualGridPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ControlLayout _bottomButtonsControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout BottomButtonsControlLayout {
			get {
				return _bottomButtonsControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _setupMacrosesButton;
		public Terrasoft.UI.WebControls.Controls.Button SetupMacrosesButton {
			get {
				return _setupMacrosesButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _sortButton;
		public Terrasoft.UI.WebControls.Controls.Button SortButton {
			get {
				return _sortButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _defaultMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem DefaultMenuItem {
			get {
				return _defaultMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _ascendingMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem AscendingMenuItem {
			get {
				return _ascendingMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _descendingMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem DescendingMenuItem {
			get {
				return _descendingMenuItem;
			}
		}

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

		public SysModuleReportTableFieldsGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SysModuleReportTableFieldsGridPageSchema(SysModuleReportTableFieldsGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("f293afc3-6364-44e9-b083-cf349186572a");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.ModifiedInSchemaUId = new Guid("f293afc3-6364-44e9-b083-cf349186572a");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("f293afc3-6364-44e9-b083-cf349186572a");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("f293afc3-6364-44e9-b083-cf349186572a");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {};
			PrintButton.ModifiedInSchemaUId = new Guid("f293afc3-6364-44e9-b083-cf349186572a");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("f293afc3-6364-44e9-b083-cf349186572a");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.Hidden = true;
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("f293afc3-6364-44e9-b083-cf349186572a");
		}

		private void UpdateTreeGrid() {
			TreeGrid.IsMultilineMode = false;
			TreeGrid.ModifiedInSchemaUId = new Guid("f293afc3-6364-44e9-b083-cf349186572a");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f293afc3-6364-44e9-b083-cf349186572a");
			RealUId = new Guid("f293afc3-6364-44e9-b083-cf349186572a");
			Name = "SysModuleReportTableFieldsGridPage";
			ParentSchemaUId = new Guid("dbe94191-fb4c-4c41-b1eb-37ac77da867d");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysModuleReportTableFieldsGridPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateTreeGrid();
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
			Controls.AddAt(2, CreateBottomButtonsControlLayout());
			BottomButtonsControlLayout.InsertItem(0, CreateSetupMacrosesButton());
			BottomButtonsControlLayout.InsertItem(1, CreateSortButton());
			SortButton.InsertItem(0, CreateDefaultMenuItem());
			SortButton.InsertItem(1, CreateAscendingMenuItem());
			SortButton.InsertItem(2, CreateDescendingMenuItem());
			BottomButtonsControlLayout.InsertItem(2, CreateUpButton());
			BottomButtonsControlLayout.InsertItem(3, CreateDownButton());
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateSysModuleReportTableFieldsGridPageEventsProcessSchema() {
			var schema = new SysModuleReportTableFieldsGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateSetupMacrosesButton() {
			_setupMacrosesButton = new Terrasoft.UI.WebControls.Controls.Button();
			_setupMacrosesButton.UId = new Guid("4ddf12dc-687e-476a-8a61-e9fbcdb1c4ad");
			_setupMacrosesButton.Name = "SetupMacrosesButton";
			_setupMacrosesButton.CreatedInSchemaUId = new Guid("f293afc3-6364-44e9-b083-cf349186572a");
			_setupMacrosesButton.ModifiedInSchemaUId = new Guid("f293afc3-6364-44e9-b083-cf349186572a");
			_setupMacrosesButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_setupMacrosesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_setupMacrosesButton.Tag = "";
			_setupMacrosesButton.Image = new ControlImage {};
			return _setupMacrosesButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateDefaultMenuItem() {
			_defaultMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_defaultMenuItem.UId = new Guid("c8c4ffc6-7168-4f37-bd92-f104368b2e77");
			_defaultMenuItem.Name = "DefaultMenuItem";
			_defaultMenuItem.CreatedInSchemaUId = new Guid("f293afc3-6364-44e9-b083-cf349186572a");
			_defaultMenuItem.ModifiedInSchemaUId = new Guid("f293afc3-6364-44e9-b083-cf349186572a");
			_defaultMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_defaultMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_defaultMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_defaultMenuItem.Image = new ControlImage {};
			_defaultMenuItem.Tag = "Default";
			return _defaultMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateAscendingMenuItem() {
			_ascendingMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_ascendingMenuItem.UId = new Guid("c0b9e35f-a9eb-490e-b813-605e2061a28f");
			_ascendingMenuItem.Name = "AscendingMenuItem";
			_ascendingMenuItem.CreatedInSchemaUId = new Guid("f293afc3-6364-44e9-b083-cf349186572a");
			_ascendingMenuItem.ModifiedInSchemaUId = new Guid("f293afc3-6364-44e9-b083-cf349186572a");
			_ascendingMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_ascendingMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_ascendingMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_ascendingMenuItem.Image = new ControlImage {};
			_ascendingMenuItem.Tag = "Ascending";
			return _ascendingMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateDescendingMenuItem() {
			_descendingMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_descendingMenuItem.UId = new Guid("f77fe047-82eb-4ccb-be33-5401cf7bcd77");
			_descendingMenuItem.Name = "DescendingMenuItem";
			_descendingMenuItem.CreatedInSchemaUId = new Guid("f293afc3-6364-44e9-b083-cf349186572a");
			_descendingMenuItem.ModifiedInSchemaUId = new Guid("f293afc3-6364-44e9-b083-cf349186572a");
			_descendingMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_descendingMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_descendingMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_descendingMenuItem.Image = new ControlImage {};
			_descendingMenuItem.Tag = "Descending";
			return _descendingMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateSortButton() {
			_sortButton = new Terrasoft.UI.WebControls.Controls.Button();
			_sortButton.UId = new Guid("48a434a9-5340-470a-899b-d494b2c6a000");
			_sortButton.Name = "SortButton";
			_sortButton.CreatedInSchemaUId = new Guid("f293afc3-6364-44e9-b083-cf349186572a");
			_sortButton.ModifiedInSchemaUId = new Guid("f293afc3-6364-44e9-b083-cf349186572a");
			_sortButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_sortButton.Tag = "";
			_sortButton.Image = new ControlImage {};
			return _sortButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateUpButton() {
			_upButton = new Terrasoft.UI.WebControls.Controls.Button();
			_upButton.UId = new Guid("997849c4-8d58-4466-8152-f9063cc81aa1");
			_upButton.Name = "UpButton";
			_upButton.CreatedInSchemaUId = new Guid("f293afc3-6364-44e9-b083-cf349186572a");
			_upButton.ModifiedInSchemaUId = new Guid("f293afc3-6364-44e9-b083-cf349186572a");
			_upButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_upButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_upButton.Tag = "";
			_upButton.Image = new ControlImage {};
			_upButton.AutoWidth = false;
			return _upButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateDownButton() {
			_downButton = new Terrasoft.UI.WebControls.Controls.Button();
			_downButton.UId = new Guid("71af1b5e-020c-44c8-ab5e-c1c4efa4ff92");
			_downButton.Name = "DownButton";
			_downButton.CreatedInSchemaUId = new Guid("f293afc3-6364-44e9-b083-cf349186572a");
			_downButton.ModifiedInSchemaUId = new Guid("f293afc3-6364-44e9-b083-cf349186572a");
			_downButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_downButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_downButton.Tag = "";
			_downButton.Image = new ControlImage {};
			_downButton.AutoWidth = false;
			return _downButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateBottomButtonsControlLayout() {
			_bottomButtonsControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_bottomButtonsControlLayout.UId = new Guid("c95f1356-ea17-414c-a0d6-37df5709add7");
			_bottomButtonsControlLayout.Name = "BottomButtonsControlLayout";
			_bottomButtonsControlLayout.CreatedInSchemaUId = new Guid("f293afc3-6364-44e9-b083-cf349186572a");
			_bottomButtonsControlLayout.ModifiedInSchemaUId = new Guid("f293afc3-6364-44e9-b083-cf349186572a");
			_bottomButtonsControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_bottomButtonsControlLayout.Tag = "";
			_bottomButtonsControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_bottomButtonsControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Footer;
			_bottomButtonsControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_bottomButtonsControlLayout.StartNewAlignGroup = false;
			_bottomButtonsControlLayout.Image = new ControlImage {};
			_bottomButtonsControlLayout.Edges = "1 0 0 0";
			return _bottomButtonsControlLayout;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new SysModuleReportTableFieldsGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new SysModuleReportTableFieldsGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f293afc3-6364-44e9-b083-cf349186572a"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysModuleReportTableFieldsGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleReportTableFieldsGridPageEventsProcess

	/// <exclude/>
	public class SysModuleReportTableFieldsGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseVirtualGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.SysModuleReportTableFieldsGridPageSchemaUserControl
	{

		public SysModuleReportTableFieldsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysModuleReportTableFieldsGridPageEventsProcess";
			SchemaUId = new Guid("f293afc3-6364-44e9-b083-cf349186572a");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f293afc3-6364-44e9-b083-cf349186572a");
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

		public virtual Guid ObjectId {
			get;
			set;
		}

		public virtual string MacrosList {
			get;
			set;
		}

		public virtual bool ColumnStructureExplorerCreated {
			get;
			set;
		}

		public virtual Object ColumnStructureExplorer {
			get;
			set;
		}

		public virtual bool ColumnStructureExplorerRegistered {
			get;
			set;
		}

		public virtual string CurrentNodeKey {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess1;
		public ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("48d5de17-e7d9-4b03-9eaa-b35b47247923"),
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
					SchemaElementUId = new Guid("db5a55fe-31a0-4d64-81b2-78ff4f0d6918"),
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
					SchemaElementUId = new Guid("554bf057-f678-4730-bb98-7752549cea64"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
				});
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
					SchemaElementUId = new Guid("1081a096-4b10-4ffd-81ba-acbc7529a618"),
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
					SchemaElementUId = new Guid("a35f3335-33b7-49b2-b72a-8b5d5c698aa4"),
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
					SchemaElementUId = new Guid("ae77d224-c869-4002-9d3c-6a5489441bd5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask2Execute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent1;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent1 {
			get {
				return _intermediateThrowMessageEvent1 ?? (_intermediateThrowMessageEvent1 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent1",
					SchemaElementUId = new Guid("c8cfab06-9f1b-403e-8a21-dda524a99bff"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess3;
		public ProcessFlowElement EventSubProcess3 {
			get {
				return _eventSubProcess3 ?? (_eventSubProcess3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3",
					SchemaElementUId = new Guid("6167f657-5167-47a5-9c64-c2c02981e842"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3;
		public ProcessFlowElement StartMessage3 {
			get {
				return _startMessage3 ?? (_startMessage3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3",
					SchemaElementUId = new Guid("e15b2b22-6300-4648-8513-41f695589490"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask3;
		public ProcessScriptTask ScriptTask3 {
			get {
				return _scriptTask3 ?? (_scriptTask3 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3",
					SchemaElementUId = new Guid("5505ea0b-ded8-4b79-b2bc-84e3704dd521"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3Execute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess5;
		public ProcessFlowElement EventSubProcess5 {
			get {
				return _eventSubProcess5 ?? (_eventSubProcess5 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess5",
					SchemaElementUId = new Guid("212fc005-ab58-4f00-a542-be628b585536"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage5;
		public ProcessFlowElement StartMessage5 {
			get {
				return _startMessage5 ?? (_startMessage5 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage5",
					SchemaElementUId = new Guid("70e8d502-5ef8-4150-a15e-269733f57e25"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask5;
		public ProcessScriptTask ScriptTask5 {
			get {
				return _scriptTask5 ?? (_scriptTask5 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask5",
					SchemaElementUId = new Guid("9ee83ee2-e08f-486b-81d9-7d63358d00ef"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask5Execute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess6;
		public ProcessFlowElement EventSubProcess6 {
			get {
				return _eventSubProcess6 ?? (_eventSubProcess6 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess6",
					SchemaElementUId = new Guid("9de02101-61d8-4f96-ae3e-13bdaf95be23"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage6;
		public ProcessFlowElement StartMessage6 {
			get {
				return _startMessage6 ?? (_startMessage6 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage6",
					SchemaElementUId = new Guid("411f823b-cab4-4500-962f-ec003f416ae2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask6;
		public ProcessScriptTask ScriptTask6 {
			get {
				return _scriptTask6 ?? (_scriptTask6 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask6",
					SchemaElementUId = new Guid("ba129177-4baf-4a3c-a475-8f5f3fde3e0b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask6Execute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess7;
		public ProcessFlowElement EventSubProcess7 {
			get {
				return _eventSubProcess7 ?? (_eventSubProcess7 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess7",
					SchemaElementUId = new Guid("0332e2dc-4154-457e-8255-a63b5d973faa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage7;
		public ProcessFlowElement StartMessage7 {
			get {
				return _startMessage7 ?? (_startMessage7 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage7",
					SchemaElementUId = new Guid("dea572d7-f79d-4b88-b8f7-4e5be29185c2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask7;
		public ProcessScriptTask ScriptTask7 {
			get {
				return _scriptTask7 ?? (_scriptTask7 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask7",
					SchemaElementUId = new Guid("78e2e222-ecd4-4741-8165-0f0d9438926c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask7Execute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess4;
		public ProcessFlowElement EventSubProcess4 {
			get {
				return _eventSubProcess4 ?? (_eventSubProcess4 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess4",
					SchemaElementUId = new Guid("f4da4dee-d21f-4aa6-8a45-3dc954e7b98d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage4;
		public ProcessFlowElement StartMessage4 {
			get {
				return _startMessage4 ?? (_startMessage4 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage4",
					SchemaElementUId = new Guid("28f1396e-54c3-45d7-a807-32569cc61503"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask4;
		public ProcessScriptTask ScriptTask4 {
			get {
				return _scriptTask4 ?? (_scriptTask4 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask4",
					SchemaElementUId = new Guid("fa912acf-f403-4b8b-ae76-99d9c998fef0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask4Execute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess8;
		public ProcessFlowElement EventSubProcess8 {
			get {
				return _eventSubProcess8 ?? (_eventSubProcess8 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess8",
					SchemaElementUId = new Guid("940a364d-87eb-4add-9881-eb4d9f0de777"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage8;
		public ProcessFlowElement StartMessage8 {
			get {
				return _startMessage8 ?? (_startMessage8 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage8",
					SchemaElementUId = new Guid("f26be364-2157-406a-857f-b306ddb4cede"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask8;
		public ProcessScriptTask ScriptTask8 {
			get {
				return _scriptTask8 ?? (_scriptTask8 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask8",
					SchemaElementUId = new Guid("6b680b27-27ef-4432-8674-2e448e5138cb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask8Execute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess9;
		public ProcessFlowElement EventSubProcess9 {
			get {
				return _eventSubProcess9 ?? (_eventSubProcess9 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess9",
					SchemaElementUId = new Guid("e6a5526c-b94e-45bc-a8c7-09bd83da2708"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage9;
		public ProcessFlowElement StartMessage9 {
			get {
				return _startMessage9 ?? (_startMessage9 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage9",
					SchemaElementUId = new Guid("81c4a40a-a9e3-4719-b1ae-456404c38507"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent2;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent2 {
			get {
				return _intermediateThrowMessageEvent2 ?? (_intermediateThrowMessageEvent2 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent2",
					SchemaElementUId = new Guid("d8be019f-632f-4d5b-ab9d-0ac95cd29e95"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptTask9;
		public ProcessScriptTask ScriptTask9 {
			get {
				return _scriptTask9 ?? (_scriptTask9 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask9",
					SchemaElementUId = new Guid("60ce2921-c893-4dfe-804c-ed4124338b33"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask9Execute,
				});
			}
		}

		private LocalizableString _fieldCaption;
		public LocalizableString FieldCaption {
			get {
				return _fieldCaption ?? (_fieldCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.FieldCaption.Value"));
			}
		}

		private LocalizableString _sortCaption;
		public LocalizableString SortCaption {
			get {
				return _sortCaption ?? (_sortCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.SortCaption.Value"));
			}
		}

		private LocalizableString _defaultMenuItemCaption;
		public LocalizableString DefaultMenuItemCaption {
			get {
				return _defaultMenuItemCaption ?? (_defaultMenuItemCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.DefaultMenuItemCaption.Value"));
			}
		}

		private LocalizableString _ascendingMenuItemCaption;
		public LocalizableString AscendingMenuItemCaption {
			get {
				return _ascendingMenuItemCaption ?? (_ascendingMenuItemCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.AscendingMenuItemCaption.Value"));
			}
		}

		private LocalizableString _descendingMenuItemCaption;
		public LocalizableString DescendingMenuItemCaption {
			get {
				return _descendingMenuItemCaption ?? (_descendingMenuItemCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.DescendingMenuItemCaption.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[StartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2 };
			FlowElements[ScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask2 };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[StartMessage3.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3 };
			FlowElements[ScriptTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3 };
			FlowElements[EventSubProcess5.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess5 };
			FlowElements[StartMessage5.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage5 };
			FlowElements[ScriptTask5.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask5 };
			FlowElements[EventSubProcess6.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess6 };
			FlowElements[StartMessage6.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage6 };
			FlowElements[ScriptTask6.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask6 };
			FlowElements[EventSubProcess7.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess7 };
			FlowElements[StartMessage7.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage7 };
			FlowElements[ScriptTask7.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask7 };
			FlowElements[EventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4 };
			FlowElements[StartMessage4.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage4 };
			FlowElements[ScriptTask4.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask4 };
			FlowElements[EventSubProcess8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8 };
			FlowElements[StartMessage8.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage8 };
			FlowElements[ScriptTask8.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask8 };
			FlowElements[EventSubProcess9.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess9 };
			FlowElements[StartMessage9.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage9 };
			FlowElements[IntermediateThrowMessageEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent2 };
			FlowElements[ScriptTask9.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask9 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "ScriptTask1":
						break;
					case "EventSubProcess2":
						break;
					case "StartMessage2":
						e.Context.QueueTasks.Enqueue("ScriptTask2");
						break;
					case "ScriptTask2":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "IntermediateThrowMessageEvent1":
						break;
					case "EventSubProcess3":
						break;
					case "StartMessage3":
						e.Context.QueueTasks.Enqueue("ScriptTask3");
						break;
					case "ScriptTask3":
						break;
					case "EventSubProcess5":
						break;
					case "StartMessage5":
						e.Context.QueueTasks.Enqueue("ScriptTask5");
						break;
					case "ScriptTask5":
						break;
					case "EventSubProcess6":
						break;
					case "StartMessage6":
						e.Context.QueueTasks.Enqueue("ScriptTask6");
						break;
					case "ScriptTask6":
						break;
					case "EventSubProcess7":
						break;
					case "StartMessage7":
						e.Context.QueueTasks.Enqueue("ScriptTask7");
						break;
					case "ScriptTask7":
						break;
					case "EventSubProcess4":
						break;
					case "StartMessage4":
						e.Context.QueueTasks.Enqueue("ScriptTask4");
						break;
					case "ScriptTask4":
						break;
					case "EventSubProcess8":
						break;
					case "StartMessage8":
						e.Context.QueueTasks.Enqueue("ScriptTask8");
						break;
					case "ScriptTask8":
						break;
					case "EventSubProcess9":
						break;
					case "StartMessage9":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent2");
						break;
					case "IntermediateThrowMessageEvent2":
						e.Context.QueueTasks.Enqueue("ScriptTask9");
						break;
					case "ScriptTask9":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage1");
			ActivatedEventElements.Add("StartMessage2");
			ActivatedEventElements.Add("StartMessage3");
			ActivatedEventElements.Add("StartMessage5");
			ActivatedEventElements.Add("StartMessage6");
			ActivatedEventElements.Add("StartMessage7");
			ActivatedEventElements.Add("StartMessage4");
			ActivatedEventElements.Add("StartMessage8");
			ActivatedEventElements.Add("StartMessage9");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
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
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3";
					result = StartMessage3.Execute(context);
					break;
				case "ScriptTask3":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3";
					result = ScriptTask3.Execute(context, ScriptTask3Execute);
					break;
				case "EventSubProcess5":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage5":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage5";
					result = StartMessage5.Execute(context);
					break;
				case "ScriptTask5":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask5";
					result = ScriptTask5.Execute(context, ScriptTask5Execute);
					break;
				case "EventSubProcess6":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage6":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage6";
					result = StartMessage6.Execute(context);
					break;
				case "ScriptTask6":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask6";
					result = ScriptTask6.Execute(context, ScriptTask6Execute);
					break;
				case "EventSubProcess7":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage7":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage7";
					result = StartMessage7.Execute(context);
					break;
				case "ScriptTask7":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask7";
					result = ScriptTask7.Execute(context, ScriptTask7Execute);
					break;
				case "EventSubProcess4":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage4":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage4";
					result = StartMessage4.Execute(context);
					break;
				case "ScriptTask4":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask4";
					result = ScriptTask4.Execute(context, ScriptTask4Execute);
					break;
				case "EventSubProcess8":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage8":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage8";
					result = StartMessage8.Execute(context);
					break;
				case "ScriptTask8":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask8";
					result = ScriptTask8.Execute(context, ScriptTask8Execute);
					break;
				case "EventSubProcess9":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage9":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage9";
					result = StartMessage9.Execute(context);
					break;
				case "IntermediateThrowMessageEvent2":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowMessageEvent2.Execute(context);
					break;
				case "ScriptTask9":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask9";
					result = ScriptTask9.Execute(context, ScriptTask9Execute);
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

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "CurrentNodeKey":
					CurrentNodeKey = reader.GetValue<System.String>();
				break;
				case "ColumnStructureExplorerRegistered":
					ColumnStructureExplorerRegistered = reader.GetValue<System.Boolean>();
				break;
				case "ColumnStructureExplorer":
					ColumnStructureExplorer = reader.GetSerializableObjectValue();
				break;
				case "ColumnStructureExplorerCreated":
					ColumnStructureExplorerCreated = reader.GetValue<System.Boolean>();
				break;
				case "MacrosList":
					MacrosList = reader.GetValue<System.String>();
				break;
				case "ObjectId":
					ObjectId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			if (ObjectId != Guid.Empty) {
				ShowColumnStructureExplorer(ObjectId);
			}
			
			return true;
		}

		public virtual bool ScriptTask2Execute(ProcessExecutingContext context) {
			if (ColumnStructureExplorerCreated) {
				CreateColumnStructureExplorer();
			}
			
			return true;
		}

		public virtual bool ScriptTask3Execute(ProcessExecutingContext context) {
			FillData(null);
			return true;
		}

		public virtual bool ScriptTask5Execute(ProcessExecutingContext context) {
			SetSortConditionColumn(OrderDirection.None);
			return true;
		}

		public virtual bool ScriptTask6Execute(ProcessExecutingContext context) {
			SetSortConditionColumn(OrderDirection.Ascending);
			return true;
		}

		public virtual bool ScriptTask7Execute(ProcessExecutingContext context) {
			SetSortConditionColumn(OrderDirection.Descending);
			return true;
		}

		public virtual bool ScriptTask4Execute(ProcessExecutingContext context) {
			if (!string.IsNullOrEmpty(MacrosList) && Page.TreeGrid.SelectedNodes.Count > 0) {
				var selectedNode = Page.TreeGrid.SelectedNodes[0];
				var oldMacrosList = Json.Deserialize(MacrosList) as JArray;
				var macrosList = new JArray();
				int index = 0;
				foreach (var macros in oldMacrosList) {
					if (string.Concat(macros.Value<string>("metaPath"), macros.Value<string>("aggregationType")) 
						== selectedNode.Values["Key"].ToString()) {
						CurrentNodeKey = selectedNode.Values["Key"].ToString();
						break;
					}
					index++;
				}
				if (index == 0) {
					return true;
				}
				
				for (int i = 0; i < index - 1; i++) {
					macrosList.Add(oldMacrosList[i]);
				}
				macrosList.Add(oldMacrosList[index]);
				macrosList.Add(oldMacrosList[index - 1]);
				for (int i = index + 1; i < oldMacrosList.Count; i++) {
					macrosList.Add(oldMacrosList[i]);
				}
				
				MacrosList = macrosList.ToString();
			}
			
			FillData(null);
			
			return true;
		}

		public virtual bool ScriptTask8Execute(ProcessExecutingContext context) {
			if (!string.IsNullOrEmpty(MacrosList) && Page.TreeGrid.SelectedNodes.Count > 0) {
				var selectedNode = Page.TreeGrid.SelectedNodes[0];
				var oldMacrosList = Json.Deserialize(MacrosList) as JArray;
				var macrosList = new JArray();
				int index = 0;
				foreach (var macros in oldMacrosList) {
					if (string.Concat(macros.Value<string>("metaPath"), macros.Value<string>("aggregationType")) 
						== selectedNode.Values["Key"].ToString()) {
						CurrentNodeKey = selectedNode.Values["Key"].ToString();
						break;
					}
					index++;
				}
				if (index == oldMacrosList.Count - 1) {
					return true;
				}
				
				for (int i = 0; i < index; i++) {
					macrosList.Add(oldMacrosList[i]);
				}
				macrosList.Add(oldMacrosList[index + 1]);
				macrosList.Add(oldMacrosList[index]);
				for (int i = index + 2; i < oldMacrosList.Count; i++) {
					macrosList.Add(oldMacrosList[i]);
				}
				
				MacrosList = macrosList.ToString();
			}
			
			FillData(null);
			
			return true;
		}

		public virtual bool ScriptTask9Execute(ProcessExecutingContext context) {
			if (ObjectId == Guid.Empty) {
				Page.SetupMacrosesButton.Enabled = false;
				Page.SortButton.Enabled = false;
			} else {
				Page.SetupMacrosesButton.Enabled = true;
				Page.SortButton.Enabled = true;
			}
			
			if (GetDataSource().ActiveRowPrimaryColumnValue != Guid.Empty) {
				Page.SortButton.Enabled = true;
			} else {
				Page.SortButton.Enabled = false;
			}
			
			return true;
		}

		public override Entity GetEntity(Guid recordId) {
			if (!string.IsNullOrEmpty(MacrosList) && Page.TreeGrid.SelectedNodes.Count > 0) {
				var selectedNode = Page.TreeGrid.SelectedNodes[0];
				var macrosList = Json.Deserialize(MacrosList) as JArray;
				foreach (var macros in macrosList) {
					if (string.Concat(macros.Value<string>("metaPath"), macros.Value<string>("aggregationType")) == selectedNode.Values["Key"].ToString()) {
						var row = GetDataSource().CreateRow();	
						row.SetColumnValue("Field", macros.Value<string>("caption"));
						if (!string.IsNullOrEmpty(macros.Value<string>("sort"))) {
							var orderDirection = (OrderDirection)Enum.Parse(typeof(OrderDirection), macros.Value<string>("sort"));
							if (orderDirection == OrderDirection.Ascending) {
								row.SetColumnValue("Sort", AscendingMenuItemCaption);
							} else if (orderDirection == OrderDirection.Descending) {
								row.SetColumnValue("Sort", DescendingMenuItemCaption);
							} else {
								row.SetColumnValue("Sort", DefaultMenuItemCaption);
							}
						} else {
							row.SetColumnValue("Sort", DefaultMenuItemCaption);
						}
						row.SetColumnValue("Key", string.Concat(macros.Value<string>("metaPath"), macros.Value<string>("aggregationType")));
						return row;
					}
				}
			}
			
			return null;
		}

		public override List<Dictionary<string, object>> GetStructureDefinition() {
			var structure = new List<Dictionary<string, object>>();
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
				{"Name", "Field"},
				{"ValueColumnName", "Field"},
				{"DisplayColumnName", "Field"},
				{"DataValueType", "Text"},
				{"Caption", FieldCaption},
				{"IsVisible", true},
				{"IsSortable", false},
				{"IsPrimaryDisplayColumn", true}
			};
			structure.Add(column);
			
			column = new Dictionary<string, object> {
				{"Name", "Sort"},
				{"ValueColumnName", "Sort"},
				{"DisplayColumnName", "Sort"},
				{"DataValueType", "Text"},
				{"Caption", SortCaption},
				{"IsVisible", true},
				{"IsSortable", false}
			};
			structure.Add(column);
			
			column = new Dictionary<string, object> {
				{"Name", "Key"},
				{"ValueColumnName", "Key"},
				{"DisplayColumnName", "Key"},
				{"DataValueType", "Text"},
				{"Caption", "Key"},
				{"IsVisible", false},
				{"IsSortable", false}
			};
			structure.Add(column);
			
			return structure;
		}

		public override void FillData(DataSourceRequest dataSourceRequest) {
			Page.TreeGrid.Clear();
			var dataSource = GetDataSource();
			dataSource.SuspendAjaxEvents();
			dataSource.Clear();
			dataSource.ResumeAjaxEvents();
			var id = Guid.Empty;
			if (ObjectId != Guid.Empty) {
				if (!string.IsNullOrEmpty(MacrosList)) {
					var macrosList = Json.Deserialize(MacrosList) as JArray;
					foreach (var macros in macrosList) {
						var row = dataSource.CreateRow();
						row.SetColumnValue("Id", Guid.NewGuid());
						row.SetColumnValue("Field", macros.Value<string>("caption"));
						if (!string.IsNullOrEmpty(macros.Value<string>("sort"))) {
							var orderDirection = (OrderDirection)Enum.Parse(typeof(OrderDirection), macros.Value<string>("sort"));
							if (orderDirection == OrderDirection.Ascending) {
								row.SetColumnValue("Sort", AscendingMenuItemCaption);
							} else if (orderDirection == OrderDirection.Descending) {
								row.SetColumnValue("Sort", DescendingMenuItemCaption);
							} else {
								row.SetColumnValue("Sort", DefaultMenuItemCaption);
							}
						} else {
							row.SetColumnValue("Sort", DefaultMenuItemCaption);
						}
						row.SetColumnValue("Key", string.Concat(macros.Value<string>("metaPath"), macros.Value<string>("aggregationType")));
						dataSource.Add(row);
						if (row.GetTypedColumnValue<string>("Key") == CurrentNodeKey) {
							id = row.PrimaryColumnValue;
							CurrentNodeKey = string.Empty;
						}
					}
					Page.SortButton.Enabled = true;
				} else {
					Page.SortButton.Enabled = false;
					Page.UpButton.Enabled = false;
					Page.DownButton.Enabled = false;
				}
				
			}
			
			dataSource.LoadRows(dataSourceRequest);
			if (id != Guid.Empty) {
				Page.TreeGrid.SelectNode(id.ToString());
				id = Guid.Empty;
			} else {
				Page.TreeGrid.SelectNode(dataSource.ActiveRowPrimaryColumnValue.ToString());
			}
			
			BaseActiveRowChangedHandler();
			
			if (ObjectId == Guid.Empty) {
				Page.SetupMacrosesButton.Enabled = false;
				Page.SortButton.Enabled = false;
			} else {
				Page.SetupMacrosesButton.Enabled = true;
				Page.SortButton.Enabled = true;
			}
			
			if (GetDataSource().ActiveRowPrimaryColumnValue != Guid.Empty) {
				Page.SortButton.Enabled = true;
			} else {
				Page.SortButton.Enabled = false;
			}
		}

		public override void BaseActiveRowChangedHandler() {
			base.BaseActiveRowChangedHandler();
			if (!string.IsNullOrEmpty(MacrosList) && Page.TreeGrid.SelectedNodes.Count > 0) {
				var selectedNode = Page.TreeGrid.SelectedNodes[0];
				var macrosList = Json.Deserialize(MacrosList) as JArray;
				int index = 0;
				foreach (var macros in macrosList) {
					if (string.Concat(macros.Value<string>("metaPath"), macros.Value<string>("aggregationType")) 
						== selectedNode.Values["Key"].ToString()) {
						break;
					}
					index++;
				}
				Page.UpButton.Enabled = index != 0;
				Page.DownButton.Enabled = index != macrosList.Count - 1;
			} else {
				Page.UpButton.Enabled = false;
				Page.DownButton.Enabled = GetDataSource().Rows.Count > 1;
			}
		}

		public virtual void ShowColumnStructureExplorer(Guid entitySchemaUId) {
			if (!ColumnStructureExplorerCreated) {
				CreateColumnStructureExplorer();
			}
			var sructureExplorer = (StructureExplorer) ColumnStructureExplorer;
			if (sructureExplorer == null) {
				return;
			}
			
			var entitySchemaManager = Page.Schema.SchemaManagerProvider.GetManager("EntitySchemaManager") as Terrasoft.Core.Entities.EntitySchemaManager;
			var schema = entitySchemaManager.GetInstanceByUId(entitySchemaUId);
			sructureExplorer.ManagerName = entitySchemaManager.Name;
			if (!string.IsNullOrEmpty(MacrosList)) {
				var dataSourceStructureColumnCollection = new DataSourceStructureColumnCollection();
				var macrosList = Json.Deserialize(MacrosList) as JArray;
				for (int i = 0; i < macrosList.Count; i++) {
					var dataSourceStructureColumn = new DataSourceStructureColumn();
					dataSourceStructureColumn.UId = Guid.NewGuid();
					dataSourceStructureColumn.MetaPath = macrosList[i].Value<string>("metaPath");
					dataSourceStructureColumn.Name =  schema.GetSchemaColumnPathByMetaPath(dataSourceStructureColumn.MetaPath);
					dataSourceStructureColumn.Caption = macrosList[i].Value<string>("caption");
					dataSourceStructureColumn.MetaPathCaption = macrosList[i].Value<string>("metaPathCaption");
					dataSourceStructureColumn.DataValueType = schema.FindSchemaColumnByMetaPath(dataSourceStructureColumn.MetaPath).DataValueType;
				
					if (!string.IsNullOrEmpty(macrosList[i].Value<string>("aggregationType"))
						&& string.Compare(macrosList[i].Value<string>("aggregationType"), "None", true) != 0) {
						
						dataSourceStructureColumn.AggregationType = (AggregationType)Enum.Parse(typeof(AggregationType),
							macrosList[i].Value<string>("aggregationType"));
						if (dataSourceStructureColumn.AggregationType == AggregationType.Count) {
							DataValueTypeManager dataValueTypeManager = dataSourceStructureColumn.DataValueType.DataValueTypeManager;
							dataSourceStructureColumn.DataValueType = dataValueTypeManager.GetInstanceByName("Integer");
						}	
						
						if (!string.IsNullOrEmpty(macrosList[i].Value<string>("subFilters"))) {
							dataSourceStructureColumn.SubFilters =  macrosList[i].Value<string>("subFilters");
						}
					}
					dataSourceStructureColumnCollection.Add(dataSourceStructureColumn);
				}
				
				sructureExplorer.Columns = dataSourceStructureColumnCollection;
			}
			
			sructureExplorer.ShowEditWindow(schema, null);
		}

		public virtual void CreateColumnStructureExplorer() {
			var param = new Terrasoft.UI.WebControls.Controls.Parameter("itemsInfo", "itemsInfo", ParameterMode.Raw);	
			var structureExplorer = new StructureExplorer(Page.SetupMacrosesButton, "columns", true, false, string.Empty);
			structureExplorer.ExcludeDataValueTypes = new string[] { "File", "Color" };
			structureExplorer.IsShowSystemColumns = true;
			structureExplorer.IsShowOppositeReference = true;
			structureExplorer.IsColumnDuplicationAllowed = true;
			
			ComponentAjaxEvent editComplete = structureExplorer.AjaxEvents.EditComplete;
			editComplete.Event += new AjaxEventHandler(SetMetaPathInfo);
			editComplete.ExtraParameters.Add(param);
			
			structureExplorer.Columns = new DataSourceStructureColumnCollection();
			
			ColumnStructureExplorerCreated = true;
			if (!ColumnStructureExplorerRegistered) {
				structureExplorer.Register();
				ColumnStructureExplorerRegistered = true;
			}
			ColumnStructureExplorer = structureExplorer;
		}

		public virtual void SetMetaPathInfo(object sender, AjaxEventArgs e) {
			var entitySchemaManager = Page.Schema.SchemaManagerProvider.GetManager("EntitySchemaManager") as Terrasoft.Core.Entities.EntitySchemaManager;
			EntitySchema schema = entitySchemaManager.GetInstanceByUId(ObjectId);
			var columns = Json.Deserialize(e.ExtraParameters["itemsInfo"]) as JArray;
			foreach (JObject column in columns) {
				EntitySchemaColumn entitySchemaColumn = schema.GetSchemaColumnByMetaPath(column.Value<string>("metaPath"));
				column.Add(new JProperty("dataValueType", new JValue(entitySchemaColumn.DataValueType.Name)));
			}
			var macrosList = columns;
			var oldMacrosList = Json.Deserialize(MacrosList) as JArray;
			if (macrosList != null && oldMacrosList != null) {
				foreach (var oldMacros in oldMacrosList) {
					foreach (var macros in macrosList) {
						if (macros.Value<string>("metaPath") == oldMacros.Value<string>("metaPath")) {
								macros["sort"] = oldMacros.Value<string>("sort");
							break;
						}
					}
				}
			}
			
			MacrosList = macrosList.ToString();
			FillData(null);
		}

		public virtual void SetSortConditionColumn(OrderDirection orderDirection) {
			if (!string.IsNullOrEmpty(MacrosList) && Page.TreeGrid.SelectedNodes.Count > 0) {
				var selectedNode = Page.TreeGrid.SelectedNodes[0];
				var macrosList = Json.Deserialize(MacrosList) as JArray;
				foreach (var macros in macrosList) {
					if (string.Concat(macros.Value<string>("metaPath"), macros.Value<string>("aggregationType")) == selectedNode.Values["Key"].ToString()) {
						macros["sort"] = orderDirection.ToString();
						CurrentNodeKey = selectedNode.Values["Key"].ToString();			
						break;
					}
				}
				MacrosList = macrosList.ToString();
			}
			
			FillData(null);
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "SetupMacrosesButtonClick":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("StartMessage2")) {
							context.QueueTasks.Enqueue("StartMessage2");
							ProcessQueue(context);
							return;
						}
						break;
					case "FillData":
							if (ActivatedEventElements.Contains("StartMessage3")) {
							context.QueueTasks.Enqueue("StartMessage3");
						}
						break;
					case "DefaultMenuItemClick":
							if (ActivatedEventElements.Contains("StartMessage5")) {
							context.QueueTasks.Enqueue("StartMessage5");
						}
						break;
					case "AscendingMenuItemClick":
							if (ActivatedEventElements.Contains("StartMessage6")) {
							context.QueueTasks.Enqueue("StartMessage6");
						}
						break;
					case "DescendingMenuItemClick":
							if (ActivatedEventElements.Contains("StartMessage7")) {
							context.QueueTasks.Enqueue("StartMessage7");
						}
						break;
					case "UpButtonClick":
							if (ActivatedEventElements.Contains("StartMessage4")) {
							context.QueueTasks.Enqueue("StartMessage4");
						}
						break;
					case "DownButtonClick":
							if (ActivatedEventElements.Contains("StartMessage8")) {
							context.QueueTasks.Enqueue("StartMessage8");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("StartMessage9")) {
							context.QueueTasks.Enqueue("StartMessage9");
							ProcessQueue(context);
							return;
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("CurrentNodeKey") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CurrentNodeKey", CurrentNodeKey, null);
			}
			if (!HasMapping("ColumnStructureExplorerRegistered") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ColumnStructureExplorerRegistered", ColumnStructureExplorerRegistered, false);
			}
			if (ColumnStructureExplorer != null) {
				if (ColumnStructureExplorer.GetType().IsSerializable ||
					ColumnStructureExplorer.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ColumnStructureExplorer", ColumnStructureExplorer, null);
				}
			}
			if (!HasMapping("ColumnStructureExplorerCreated") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ColumnStructureExplorerCreated", ColumnStructureExplorerCreated, false);
			}
			if (!HasMapping("MacrosList") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("MacrosList", MacrosList, null);
			}
			if (!HasMapping("ObjectId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ObjectId", ObjectId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleReportTableFieldsGridPageEventsProcess

	/// <exclude/>
	public class SysModuleReportTableFieldsGridPageEventsProcess : SysModuleReportTableFieldsGridPageEventsProcess<Terrasoft.WebApp.SysModuleReportTableFieldsGridPageSchemaUserControl>
	{

		public SysModuleReportTableFieldsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysModuleReportTableFieldsGridPageSchemaUserControl

	/// <exclude/>
	public partial class SysModuleReportTableFieldsGridPageSchemaUserControl : Terrasoft.WebApp.BaseVirtualGridPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ControlLayout BottomButtonsControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("BottomButtonsControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button SetupMacrosesButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("SetupMacrosesButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button SortButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("SortButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem DefaultMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("DefaultMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem AscendingMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("AscendingMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem DescendingMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("DescendingMenuItem", true);
			}
		}

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
			SetupMacrosesButton.AjaxEvents.Click.Event += SetupMacrosesButtonClick;
			DefaultMenuItem.AjaxEvents.Click.Event += DefaultMenuItemClick;
			AscendingMenuItem.AjaxEvents.Click.Event += AscendingMenuItemClick;
			DescendingMenuItem.AjaxEvents.Click.Event += DescendingMenuItemClick;
			UpButton.AjaxEvents.Click.Event += UpButtonClick;
			DownButton.AjaxEvents.Click.Event += DownButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			SetupMacrosesButton.AjaxEvents.Click.Event -= SetupMacrosesButtonClick;
			DefaultMenuItem.AjaxEvents.Click.Event -= DefaultMenuItemClick;
			AscendingMenuItem.AjaxEvents.Click.Event -= AscendingMenuItemClick;
			DescendingMenuItem.AjaxEvents.Click.Event -= DescendingMenuItemClick;
			UpButton.AjaxEvents.Click.Event -= UpButtonClick;
			DownButton.AjaxEvents.Click.Event -= DownButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (SysModuleReportTableFieldsGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SysModuleReportTableFieldsGridPageEventsProcess(UserConnection);
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

		public virtual void SetupMacrosesButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("SetupMacrosesButtonClick");
		}

		public virtual void DefaultMenuItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("DefaultMenuItemClick");
		}

		public virtual void AscendingMenuItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("AscendingMenuItemClick");
		}

		public virtual void DescendingMenuItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("DescendingMenuItemClick");
		}

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
			SchemaName = "SysModuleReportTableFieldsGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleReportTableFieldsGridPageEventsProcessSchema

	/// <exclude/>
	public class SysModuleReportTableFieldsGridPageEventsProcessSchema : Terrasoft.WebApp.BaseVirtualGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public SysModuleReportTableFieldsGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysModuleReportTableFieldsGridPageEventsProcessSchema(SysModuleReportTableFieldsGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysModuleReportTableFieldsGridPageEventsProcess";
			UId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc");
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

		protected virtual ProcessSchemaParameter CreateObjectIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9fdb9d08-0a32-4cd9-bd20-e6bb8c15def1"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"ObjectId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMacrosListParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("397e55a9-b6d6-44fd-9f2a-0546cc3ae95e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"MacrosList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateColumnStructureExplorerCreatedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ea280faa-dfd3-421a-a1d2-42e52cae315b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"ColumnStructureExplorerCreated",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateColumnStructureExplorerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c0df6b0a-efb8-41a5-9aad-766ee373dfbd"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"ColumnStructureExplorer",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateColumnStructureExplorerRegisteredParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("5a7e3ddd-256b-4b14-ad82-9f90ecdfd6b0"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"ColumnStructureExplorerRegistered",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCurrentNodeKeyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2a6b92da-6ce4-49f5-b86a-d4395e0b7456"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"CurrentNodeKey",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateObjectIdParameter());
			Parameters.Add(CreateMacrosListParameter());
			Parameters.Add(CreateColumnStructureExplorerCreatedParameter());
			Parameters.Add(CreateColumnStructureExplorerParameter());
			Parameters.Add(CreateColumnStructureExplorerRegisteredParameter());
			Parameters.Add(CreateCurrentNodeKeyParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaLane schemaLane2 = CreateLane2Lane();
			schemaLaneSet1.Lanes.Add(schemaLane2);
			ProcessSchemaLane schemaLane3 = CreateLane3Lane();
			schemaLaneSet1.Lanes.Add(schemaLane3);
			ProcessSchemaLane schemaLane5 = CreateLane5Lane();
			schemaLaneSet1.Lanes.Add(schemaLane5);
			ProcessSchemaLane schemaLane6 = CreateLane6Lane();
			schemaLaneSet1.Lanes.Add(schemaLane6);
			ProcessSchemaLane schemaLane7 = CreateLane7Lane();
			schemaLaneSet1.Lanes.Add(schemaLane7);
			ProcessSchemaLane schemaLane4 = CreateLane4Lane();
			schemaLaneSet1.Lanes.Add(schemaLane4);
			ProcessSchemaLane schemaLane8 = CreateLane8Lane();
			schemaLaneSet1.Lanes.Add(schemaLane8);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaEventSubProcess eventsubprocess5 = CreateEventSubProcess5EventSubProcess();
			FlowElements.Add(eventsubprocess5);
			ProcessSchemaEventSubProcess eventsubprocess6 = CreateEventSubProcess6EventSubProcess();
			FlowElements.Add(eventsubprocess6);
			ProcessSchemaEventSubProcess eventsubprocess7 = CreateEventSubProcess7EventSubProcess();
			FlowElements.Add(eventsubprocess7);
			ProcessSchemaEventSubProcess eventsubprocess4 = CreateEventSubProcess4EventSubProcess();
			FlowElements.Add(eventsubprocess4);
			ProcessSchemaEventSubProcess eventsubprocess8 = CreateEventSubProcess8EventSubProcess();
			FlowElements.Add(eventsubprocess8);
			ProcessSchemaEventSubProcess eventsubprocess9 = CreateEventSubProcess9EventSubProcess();
			FlowElements.Add(eventsubprocess9);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			eventsubprocess1.FlowElements.Add(startmessage1);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			eventsubprocess1.FlowElements.Add(scripttask1);
			ProcessSchemaStartMessageEvent startmessage2 = CreateStartMessage2StartMessageEvent();
			eventsubprocess2.FlowElements.Add(startmessage2);
			ProcessSchemaScriptTask scripttask2 = CreateScriptTask2ScriptTask();
			eventsubprocess2.FlowElements.Add(scripttask2);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess2.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaStartMessageEvent startmessage3 = CreateStartMessage3StartMessageEvent();
			eventsubprocess3.FlowElements.Add(startmessage3);
			ProcessSchemaScriptTask scripttask3 = CreateScriptTask3ScriptTask();
			eventsubprocess3.FlowElements.Add(scripttask3);
			ProcessSchemaStartMessageEvent startmessage5 = CreateStartMessage5StartMessageEvent();
			eventsubprocess5.FlowElements.Add(startmessage5);
			ProcessSchemaScriptTask scripttask5 = CreateScriptTask5ScriptTask();
			eventsubprocess5.FlowElements.Add(scripttask5);
			ProcessSchemaStartMessageEvent startmessage6 = CreateStartMessage6StartMessageEvent();
			eventsubprocess6.FlowElements.Add(startmessage6);
			ProcessSchemaScriptTask scripttask6 = CreateScriptTask6ScriptTask();
			eventsubprocess6.FlowElements.Add(scripttask6);
			ProcessSchemaStartMessageEvent startmessage7 = CreateStartMessage7StartMessageEvent();
			eventsubprocess7.FlowElements.Add(startmessage7);
			ProcessSchemaScriptTask scripttask7 = CreateScriptTask7ScriptTask();
			eventsubprocess7.FlowElements.Add(scripttask7);
			ProcessSchemaStartMessageEvent startmessage4 = CreateStartMessage4StartMessageEvent();
			eventsubprocess4.FlowElements.Add(startmessage4);
			ProcessSchemaScriptTask scripttask4 = CreateScriptTask4ScriptTask();
			eventsubprocess4.FlowElements.Add(scripttask4);
			ProcessSchemaStartMessageEvent startmessage8 = CreateStartMessage8StartMessageEvent();
			eventsubprocess8.FlowElements.Add(startmessage8);
			ProcessSchemaScriptTask scripttask8 = CreateScriptTask8ScriptTask();
			eventsubprocess8.FlowElements.Add(scripttask8);
			ProcessSchemaStartMessageEvent startmessage9 = CreateStartMessage9StartMessageEvent();
			eventsubprocess9.FlowElements.Add(startmessage9);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent2 = CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent();
			eventsubprocess9.FlowElements.Add(intermediatethrowmessageevent2);
			ProcessSchemaScriptTask scripttask9 = CreateScriptTask9ScriptTask();
			eventsubprocess9.FlowElements.Add(scripttask9);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateFieldCaptionLocalizableString());
			LocalizableStrings.Add(CreateSortCaptionLocalizableString());
			LocalizableStrings.Add(CreateDefaultMenuItemCaptionLocalizableString());
			LocalizableStrings.Add(CreateAscendingMenuItemCaptionLocalizableString());
			LocalizableStrings.Add(CreateDescendingMenuItemCaptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateFieldCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("8bf8ab6e-0cb9-46a5-b024-b04444e17114"),
				Name = "FieldCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSortCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a9b676c3-7bb2-46c0-96d0-eb09cad375a2"),
				Name = "SortCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDefaultMenuItemCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("aa154e9f-3160-45d7-8ec3-b744c911ae31"),
				Name = "DefaultMenuItemCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateAscendingMenuItemCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("9db8b61e-7a0b-428e-a5a7-b55502eec2e5"),
				Name = "AscendingMenuItemCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDescendingMenuItemCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5a65bf34-3572-4ffa-9ed2-9e6ec9f4240f"),
				Name = "DescendingMenuItemCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("7e42a9b2-4c2b-46fe-81ae-38df0f42f941"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("db5a55fe-31a0-4d64-81b2-78ff4f0d6918"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("554bf057-f678-4730-bb98-7752549cea64"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("0c60f39f-8369-41bd-966f-0b8c95f13241"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				CurveCenterPosition = new Point(194, 278),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a35f3335-33b7-49b2-b72a-8b5d5c698aa4"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ae77d224-c869-4002-9d3c-6a5489441bd5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("7d30dcd0-868e-4bc4-bbb4-c3aacf8aa4fc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				CurveCenterPosition = new Point(338, 280),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ae77d224-c869-4002-9d3c-6a5489441bd5"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c8cfab06-9f1b-403e-8a21-dda524a99bff"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("eca1d1ce-1fd6-47f5-b587-20f7f00724e7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				CurveCenterPosition = new Point(214, 477),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e15b2b22-6300-4648-8513-41f695589490"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5505ea0b-ded8-4b79-b2bc-84e3704dd521"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("79bb73c9-2186-41c1-9db6-e1fed45857b5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("70e8d502-5ef8-4150-a15e-269733f57e25"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9ee83ee2-e08f-486b-81d9-7d63358d00ef"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("1181292e-81c9-4391-9124-16e25b300ea7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("411f823b-cab4-4500-962f-ec003f416ae2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ba129177-4baf-4a3c-a475-8f5f3fde3e0b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("c4988da1-6e64-4f3f-a1b9-e2ea5724539b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dea572d7-f79d-4b88-b8f7-4e5be29185c2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("78e2e222-ecd4-4741-8165-0f0d9438926c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("c100761f-a908-4406-affc-e1084f35189b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("28f1396e-54c3-45d7-a807-32569cc61503"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fa912acf-f403-4b8b-ae76-99d9c998fef0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("a09606ca-7f7b-4335-81a8-808335f0c564"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f26be364-2157-406a-857f-b306ddb4cede"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6b680b27-27ef-4432-8674-2e448e5138cb"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("4327e923-0e5a-4dac-b516-983ddafbabec"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				CurveCenterPosition = new Point(181, 1287),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("81c4a40a-a9e3-4719-b1ae-456404c38507"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d8be019f-632f-4d5b-ab9d-0ac95cd29e95"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("31ca3761-0a78-43cc-99e1-b3065f0f5be9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				CurveCenterPosition = new Point(295, 1287),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d8be019f-632f-4d5b-ab9d-0ac95cd29e95"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("60ce2921-c893-4dfe-804c-ed4124338b33"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("a90e7d7e-0684-46e5-b0de-477bc2e52c52"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(599, 1586),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("a2b863dd-6b85-400d-be14-8e18e337e0db"),
				ContainerItemIndex = 6,
				ContainerUId = new Guid("a90e7d7e-0684-46e5-b0de-477bc2e52c52"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"Lane1",
				Position = new Point(29, 821),
				Size = new Size(570, 173),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("d0c988ff-70df-4562-b5fd-189ac27b527e"),
				ContainerItemIndex = 7,
				ContainerUId = new Guid("a90e7d7e-0684-46e5-b0de-477bc2e52c52"),
				CreatedInOwnerSchemaUId = new Guid("f293afc3-6364-44e9-b083-cf349186572a"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"Lane2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 999),
				Size = new Size(570, 392),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaLane CreateLane3Lane() {
			ProcessSchemaLane schemaLane3 = new ProcessSchemaLane(this) {
				UId = new Guid("c804b7bd-e6ac-4724-82b5-ac585298a9e6"),
				ContainerItemIndex = 8,
				ContainerUId = new Guid("a90e7d7e-0684-46e5-b0de-477bc2e52c52"),
				CreatedInOwnerSchemaUId = new Guid("f293afc3-6364-44e9-b083-cf349186572a"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"Lane3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 1396),
				Size = new Size(570, 190),
				UseBackgroundMode = false
			};
			return schemaLane3;
		}

		protected virtual ProcessSchemaLane CreateLane5Lane() {
			ProcessSchemaLane schemaLane5 = new ProcessSchemaLane(this) {
				UId = new Guid("1118a2d0-6b40-4f18-ace9-e8a453f94ce8"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("a90e7d7e-0684-46e5-b0de-477bc2e52c52"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"Lane5",
				Position = new Point(29, 328),
				Size = new Size(570, 159),
				UseBackgroundMode = false
			};
			return schemaLane5;
		}

		protected virtual ProcessSchemaLane CreateLane6Lane() {
			ProcessSchemaLane schemaLane6 = new ProcessSchemaLane(this) {
				UId = new Guid("a5f41065-ed41-46d4-82a6-0b1a56c7664d"),
				ContainerItemIndex = 4,
				ContainerUId = new Guid("a90e7d7e-0684-46e5-b0de-477bc2e52c52"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"Lane6",
				Position = new Point(29, 492),
				Size = new Size(570, 159),
				UseBackgroundMode = false
			};
			return schemaLane6;
		}

		protected virtual ProcessSchemaLane CreateLane7Lane() {
			ProcessSchemaLane schemaLane7 = new ProcessSchemaLane(this) {
				UId = new Guid("fb6feb6d-58e4-46dc-a04d-204081b040a8"),
				ContainerItemIndex = 5,
				ContainerUId = new Guid("a90e7d7e-0684-46e5-b0de-477bc2e52c52"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"Lane7",
				Position = new Point(29, 656),
				Size = new Size(570, 160),
				UseBackgroundMode = false
			};
			return schemaLane7;
		}

		protected virtual ProcessSchemaLane CreateLane4Lane() {
			ProcessSchemaLane schemaLane4 = new ProcessSchemaLane(this) {
				UId = new Guid("f379aeba-6c5c-479f-acb4-faa8a6ecc565"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("a90e7d7e-0684-46e5-b0de-477bc2e52c52"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"Lane4",
				Position = new Point(29, 164),
				Size = new Size(570, 159),
				UseBackgroundMode = false
			};
			return schemaLane4;
		}

		protected virtual ProcessSchemaLane CreateLane8Lane() {
			ProcessSchemaLane schemaLane8 = new ProcessSchemaLane(this) {
				UId = new Guid("f96c89a8-76e9-4753-aa36-cd642ed5f9c6"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("a90e7d7e-0684-46e5-b0de-477bc2e52c52"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"Lane8",
				Position = new Point(29, 0),
				Size = new Size(570, 159),
				UseBackgroundMode = false
			};
			return schemaLane8;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("48d5de17-e7d9-4b03-9eaa-b35b47247923"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a2b863dd-6b85-400d-be14-8e18e337e0db"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"EventSubProcess1",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(297, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("db5a55fe-31a0-4d64-81b2-78ff4f0d6918"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("48d5de17-e7d9-4b03-9eaa-b35b47247923"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SetupMacrosesButtonClick",
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"StartMessage1",
				Position = new Point(50, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("554bf057-f678-4730-bb98-7752549cea64"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("48d5de17-e7d9-4b03-9eaa-b35b47247923"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"ScriptTask1",
				Position = new Point(190, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,240,79,202,74,77,46,241,76,81,80,180,85,112,47,205,76,209,115,205,45,40,169,212,84,168,230,229,226,12,206,200,47,119,206,207,41,205,205,11,46,41,42,77,46,41,45,74,117,173,40,200,201,47,74,45,130,235,211,180,230,229,170,229,229,226,229,42,74,5,202,231,41,0,21,166,90,3,0,175,54,113,38,89,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1081a096-4b10-4ffd-81ba-acbc7529a618"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d0c988ff-70df-4562-b5fd-189ac27b527e"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(49, 21),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(343, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a35f3335-33b7-49b2-b72a-8b5d5c698aa4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1081a096-4b10-4ffd-81ba-acbc7529a618"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"StartMessage2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 62),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ae77d224-c869-4002-9d3c-6a5489441bd5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1081a096-4b10-4ffd-81ba-acbc7529a618"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"ScriptTask2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,112,206,207,41,205,205,11,46,41,42,77,46,41,45,74,117,173,40,200,201,47,74,45,114,46,74,77,44,73,77,209,84,168,230,229,226,132,112,112,168,212,208,180,230,229,170,229,229,226,229,42,74,5,138,231,41,0,21,164,90,3,0,68,183,36,197,91,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("c8cfab06-9f1b-403e-8a21-dda524a99bff"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1081a096-4b10-4ffd-81ba-acbc7529a618"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(288, 62),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("6167f657-5167-47a5-9c64-c2c02981e842"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c804b7bd-e6ac-4724-82b5-ac585298a9e6"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"EventSubProcess3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 21),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(329, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage3StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e15b2b22-6300-4648-8513-41f695589490"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6167f657-5167-47a5-9c64-c2c02981e842"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"FillData",
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"StartMessage3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(50, 64),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask3ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5505ea0b-ded8-4b79-b2bc-84e3704dd521"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6167f657-5167-47a5-9c64-c2c02981e842"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"ScriptTask3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(169, 50),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,203,204,201,113,73,44,73,212,200,43,205,201,209,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,103,32,54,90,29,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess5EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess5 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("212fc005-ab58-4f00-a542-be628b585536"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1118a2d0-6b40-4f18-ace9-e8a453f94ce8"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"EventSubProcess5",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(311, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess5;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage5StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("70e8d502-5ef8-4150-a15e-269733f57e25"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("212fc005-ab58-4f00-a542-be628b585536"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DefaultMenuItemClick",
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"StartMessage5",
				Position = new Point(43, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask5ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9ee83ee2-e08f-486b-81d9-7d63358d00ef"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("212fc005-ab58-4f00-a542-be628b585536"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"ScriptTask5",
				Position = new Point(204, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,45,9,206,47,42,113,206,207,75,201,44,201,204,207,115,206,207,41,205,205,211,240,47,74,73,45,114,201,44,74,77,6,9,234,249,229,231,165,106,90,243,114,21,165,150,148,22,229,41,148,20,149,166,90,3,0,239,239,130,47,58,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess6EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess6 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("9de02101-61d8-4f96-ae3e-13bdaf95be23"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a5f41065-ed41-46d4-82a6-0b1a56c7664d"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"EventSubProcess6",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(311, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess6;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage6StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("411f823b-cab4-4500-962f-ec003f416ae2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9de02101-61d8-4f96-ae3e-13bdaf95be23"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AscendingMenuItemClick",
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"StartMessage6",
				Position = new Point(43, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask6ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ba129177-4baf-4a3c-a475-8f5f3fde3e0b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9de02101-61d8-4f96-ae3e-13bdaf95be23"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"ScriptTask6",
				Position = new Point(204, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,45,9,206,47,42,113,206,207,75,201,44,201,204,207,115,206,207,41,205,205,211,240,47,74,73,45,114,201,44,74,77,6,9,234,57,22,39,167,2,21,228,165,107,90,243,114,21,165,150,148,22,229,41,148,20,149,166,90,3,0,17,76,235,165,63,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess7EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess7 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("0332e2dc-4154-457e-8255-a63b5d973faa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fb6feb6d-58e4-46dc-a04d-204081b040a8"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"EventSubProcess7",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(311, 139),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess7;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage7StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("dea572d7-f79d-4b88-b8f7-4e5be29185c2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0332e2dc-4154-457e-8255-a63b5d973faa"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DescendingMenuItemClick",
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"StartMessage7",
				Position = new Point(43, 53),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask7ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("78e2e222-ecd4-4741-8165-0f0d9438926c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0332e2dc-4154-457e-8255-a63b5d973faa"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"ScriptTask7",
				Position = new Point(204, 39),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,45,9,206,47,42,113,206,207,75,201,44,201,204,207,115,206,207,41,205,205,211,240,47,74,73,45,114,201,44,74,77,6,9,234,185,164,22,39,167,2,85,228,165,107,90,243,114,21,165,150,148,22,229,41,148,20,149,166,90,3,0,153,60,246,40,64,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f4da4dee-d21f-4aa6-8a45-3dc954e7b98d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f379aeba-6c5c-479f-acb4-faa8a6ecc565"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"EventSubProcess4",
				Position = new Point(36, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(178, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess4;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage4StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("28f1396e-54c3-45d7-a807-32569cc61503"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f4da4dee-d21f-4aa6-8a45-3dc954e7b98d"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"UpButtonClick",
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"StartMessage4",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask4ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("fa912acf-f403-4b8b-ae76-99d9c998fef0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f4da4dee-d21f-4aa6-8a45-3dc954e7b98d"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"ScriptTask4",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,147,81,75,195,48,20,133,159,59,216,127,136,125,24,41,213,50,159,183,14,198,166,226,212,57,216,240,101,236,33,182,119,93,48,75,70,146,170,85,252,239,38,77,203,90,144,41,66,161,77,238,119,146,115,79,82,186,69,248,76,105,73,121,22,221,170,121,206,216,163,188,218,31,116,129,31,72,34,133,186,167,74,7,168,215,67,11,146,65,180,146,0,55,146,166,209,18,24,36,26,210,185,72,65,69,19,145,115,141,70,168,31,160,207,110,199,123,37,18,169,6,128,226,83,234,117,127,51,168,68,130,165,199,93,141,106,166,4,143,166,160,64,82,194,232,7,180,60,17,133,102,99,41,73,81,171,247,77,41,135,183,170,140,3,11,80,99,144,242,20,222,77,173,111,39,182,66,2,73,118,8,31,165,6,104,91,112,237,120,212,100,84,69,52,17,60,33,26,59,62,122,34,44,135,161,43,141,176,191,7,77,22,68,239,252,224,28,253,76,144,44,147,144,17,77,5,95,21,7,240,131,0,217,13,188,56,110,5,230,100,106,237,223,65,225,111,162,149,88,150,11,224,160,50,228,77,114,41,129,107,203,26,4,253,81,61,40,181,207,166,239,151,242,243,171,108,206,134,18,134,118,194,142,109,175,85,78,113,125,158,158,4,157,75,142,180,204,161,230,92,130,150,53,185,150,153,154,215,176,138,248,2,93,154,97,24,86,242,227,193,68,227,52,197,173,136,215,116,19,212,107,158,230,236,202,142,253,157,179,14,28,219,50,233,106,97,233,206,152,109,9,221,37,254,143,109,243,180,110,109,67,215,202,222,176,221,206,53,101,108,74,52,193,220,252,106,118,182,219,105,166,251,13,237,62,192,69,143,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess8EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess8 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("940a364d-87eb-4add-9881-eb4d9f0de777"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f96c89a8-76e9-4753-aa36-cd642ed5f9c6"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"EventSubProcess8",
				Position = new Point(36, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(178, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess8;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage8StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f26be364-2157-406a-857f-b306ddb4cede"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("940a364d-87eb-4add-9881-eb4d9f0de777"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DownButtonClick",
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"StartMessage8",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask8ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6b680b27-27ef-4432-8674-2e448e5138cb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("940a364d-87eb-4add-9881-eb4d9f0de777"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"ScriptTask8",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,83,81,75,195,48,16,126,222,96,255,33,246,65,82,170,101,243,117,235,96,108,42,78,157,131,13,95,198,30,98,123,235,130,93,50,146,84,173,226,127,55,105,82,214,194,152,34,20,154,222,125,223,221,119,223,53,116,131,240,153,84,130,178,52,188,147,179,60,203,158,196,245,110,175,10,252,72,98,193,229,3,149,202,71,231,231,104,78,82,8,151,2,224,86,208,36,92,64,6,177,130,100,198,19,144,225,152,231,76,161,33,234,250,232,171,211,110,189,17,129,100,13,128,162,83,236,85,119,221,119,36,158,37,135,174,154,53,149,156,133,19,144,32,40,201,232,39,52,52,17,137,166,35,33,72,81,177,119,117,42,131,119,151,198,190,1,80,45,144,178,4,62,116,174,107,2,27,46,128,196,91,132,15,84,13,104,74,176,227,180,168,246,200,89,52,230,44,38,10,91,124,248,76,178,28,6,54,53,196,222,14,20,153,19,181,245,252,11,116,28,65,210,84,64,74,20,229,108,89,236,193,243,125,100,26,180,162,168,97,152,165,201,149,119,15,133,183,14,151,124,81,22,192,190,19,212,26,231,66,0,83,6,171,33,232,143,236,126,201,125,209,115,191,150,199,239,114,56,99,74,16,152,128,249,54,179,58,159,162,166,25,110,203,151,168,231,84,8,80,185,96,72,137,28,42,182,245,213,84,208,110,151,78,235,215,192,26,175,143,65,224,168,135,85,133,163,36,193,141,62,43,186,246,171,122,167,113,165,204,0,245,44,254,119,172,197,53,4,86,53,174,172,208,35,3,255,71,182,126,26,255,113,141,215,216,134,198,118,218,55,52,203,38,68,17,204,244,229,51,209,78,187,238,236,15,199,94,157,83,161,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e6a5526c-b94e-45bc-a8c7-09bd83da2708"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d0c988ff-70df-4562-b5fd-189ac27b527e"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"EventSubProcess9",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 203),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(354, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess9;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage9StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("81c4a40a-a9e3-4719-b1ae-456404c38507"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6a5526c-b94e-45bc-a8c7-09bd83da2708"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"StartMessage9",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 67),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("d8be019f-632f-4d5b-ab9d-0ac95cd29e95"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6a5526c-b94e-45bc-a8c7-09bd83da2708"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"IntermediateThrowMessageEvent2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 67),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask9ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("60ce2921-c893-4dfe-804c-ed4124338b33"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6a5526c-b94e-45bc-a8c7-09bd83da2708"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Name = @"ScriptTask9",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(253, 53),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,143,205,10,130,64,20,133,215,9,190,195,180,179,205,188,64,184,232,71,164,69,36,9,237,175,227,53,38,70,71,174,119,10,9,223,189,137,162,69,160,181,187,139,239,156,123,62,93,137,232,80,92,80,241,174,20,113,44,82,167,75,153,212,45,247,11,113,15,131,89,6,103,148,57,178,107,247,160,200,118,216,173,29,179,109,100,210,64,97,208,103,68,5,166,195,229,135,181,196,163,200,32,208,31,255,22,51,185,31,189,111,98,8,131,48,208,222,36,69,222,2,67,110,29,41,140,22,114,165,88,95,241,104,111,25,233,26,168,223,88,227,234,230,4,198,161,152,143,201,78,61,250,222,63,41,251,92,69,222,144,154,87,254,1,11,173,66,188,108,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateShowColumnStructureExplorerMethod());
			Methods.Add(CreateCreateColumnStructureExplorerMethod());
			Methods.Add(CreateSetMetaPathInfoMethod());
			Methods.Add(CreateSetSortConditionColumnMethod());
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

		protected override SchemaMethod CreateGetEntityMethod() {
			SchemaMethod method = base.CreateGetEntityMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,83,79,75,228,48,20,63,143,224,119,200,246,32,9,12,193,251,56,130,116,92,209,93,117,216,25,246,34,30,66,251,166,6,210,100,120,121,81,70,241,187,111,154,214,209,202,84,92,65,104,41,109,126,127,95,19,189,98,252,135,39,212,182,146,231,254,42,24,115,141,167,245,154,54,252,82,21,232,252,111,237,73,176,131,3,54,87,21,200,37,2,156,161,46,229,2,12,20,4,229,149,43,193,203,220,5,75,236,152,29,10,246,180,191,55,186,87,200,252,27,0,155,126,196,190,57,188,157,116,164,122,107,25,41,23,222,89,57,3,15,168,149,209,143,208,11,164,60,187,56,65,84,155,134,186,114,8,170,184,99,252,85,131,105,251,70,173,141,53,210,177,107,87,53,119,182,80,196,91,136,252,171,76,128,163,118,233,152,103,53,144,154,43,186,203,196,152,237,70,168,170,66,168,20,105,103,151,155,53,100,66,176,233,180,215,185,101,248,155,236,23,108,178,91,185,116,139,196,229,162,203,146,250,162,123,136,69,207,128,102,138,212,194,5,44,128,11,153,199,54,4,127,220,3,23,147,81,194,70,92,156,25,229,206,132,218,38,97,158,253,212,96,202,108,40,96,161,214,77,184,24,108,146,20,244,224,111,222,205,247,14,41,146,95,194,166,180,14,75,192,153,198,216,49,74,199,224,252,186,247,69,156,218,80,203,185,66,15,156,226,84,220,234,61,96,40,109,231,214,70,77,89,223,123,77,89,95,74,158,248,2,108,25,233,219,136,59,167,180,104,148,199,108,139,190,4,27,206,9,234,188,157,207,139,229,51,3,227,129,125,202,57,110,201,255,177,126,133,127,236,253,41,169,149,10,134,134,116,210,163,175,246,85,177,231,193,109,215,108,231,49,251,174,83,212,217,35,80,64,219,28,143,244,222,164,137,119,188,246,247,186,37,27,119,240,228,31,150,196,175,0,188,4,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetStructureDefinitionMethod() {
			SchemaMethod method = base.CreateGetStructureDefinitionMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,148,223,74,195,48,20,135,175,45,244,29,66,175,38,148,189,192,230,64,54,28,67,17,193,177,251,179,246,40,145,52,45,249,51,45,163,239,110,146,141,218,184,172,214,193,46,115,190,243,11,231,124,144,236,64,16,169,132,206,148,22,72,238,8,199,79,242,68,165,154,46,104,166,104,201,65,212,83,195,41,127,79,73,185,253,192,76,205,102,163,219,73,28,237,76,48,43,153,46,248,49,117,62,64,246,113,116,179,79,158,161,192,36,37,201,42,79,154,212,85,54,192,52,206,221,37,167,112,65,101,197,160,62,139,65,129,203,175,235,202,161,165,166,45,156,67,101,103,241,19,43,185,161,146,110,153,237,126,3,38,177,173,191,150,66,65,8,188,8,90,152,133,14,51,24,106,68,97,19,71,141,217,191,149,54,190,207,243,209,193,132,245,18,71,151,89,121,160,200,250,196,120,60,232,198,239,248,173,103,141,95,234,84,143,203,28,143,1,77,110,223,161,150,188,161,174,43,203,142,210,227,170,139,131,170,188,134,97,166,108,228,82,81,215,145,240,136,117,143,131,14,13,42,232,242,97,6,186,145,127,188,165,191,150,23,104,202,252,231,19,154,124,3,216,135,189,201,147,4,0,0 };
			return method;
		}

		protected override SchemaMethod CreateFillDataMethod() {
			SchemaMethod method = base.CreateFillDataMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,85,219,110,218,64,16,125,38,18,255,176,225,201,72,145,127,32,165,18,1,154,146,38,128,98,218,247,137,119,32,27,217,187,116,47,80,90,241,239,157,245,13,227,196,36,237,139,45,207,158,57,103,110,158,93,192,26,195,165,70,188,213,130,135,163,4,65,7,253,235,238,197,22,52,227,96,33,82,78,199,200,6,236,22,237,184,250,206,32,199,227,48,114,102,131,146,15,95,224,215,100,139,210,154,38,224,72,92,51,62,162,113,41,54,156,188,176,224,94,208,81,64,147,116,99,247,100,21,43,22,204,159,94,48,182,83,206,46,235,135,125,246,167,123,209,241,231,151,198,106,33,215,225,212,204,92,146,204,117,118,28,60,64,172,149,185,23,198,246,115,104,199,43,164,149,149,148,238,140,146,225,24,13,106,1,137,248,141,117,31,6,134,221,13,181,6,31,69,167,179,82,26,33,126,102,193,145,132,9,89,163,43,52,50,17,173,118,196,94,175,2,57,91,124,84,187,44,83,66,17,34,140,208,142,84,226,82,249,3,18,135,65,111,202,123,87,121,126,51,220,249,119,208,63,131,254,34,48,241,14,121,4,97,102,253,148,23,226,115,208,139,97,99,133,146,189,146,161,189,76,111,251,27,165,45,57,151,73,101,89,41,205,81,143,133,166,94,16,53,37,24,204,79,44,253,137,116,105,184,0,109,48,176,251,13,170,85,19,208,22,109,161,150,135,154,197,218,212,26,176,83,170,112,104,98,154,59,114,175,66,124,179,74,145,103,190,98,21,250,1,165,155,90,76,71,121,125,74,201,3,195,196,32,251,144,50,205,203,191,72,31,225,231,181,63,68,181,2,151,216,54,158,236,117,202,246,191,100,135,214,177,251,134,123,114,46,38,105,164,100,12,182,101,132,82,180,176,0,251,220,107,109,59,172,215,26,215,224,117,151,52,47,126,222,114,249,218,159,51,228,60,160,56,106,99,236,163,162,157,228,61,120,45,180,35,173,15,177,239,27,55,114,90,211,122,153,41,142,100,171,186,149,45,25,207,178,208,34,5,189,175,145,20,165,60,117,36,116,145,111,185,148,202,10,101,143,133,95,164,190,168,55,206,90,154,143,137,132,167,4,189,134,213,57,99,189,39,237,232,21,16,232,186,194,124,223,188,135,24,171,157,108,199,248,216,186,23,244,60,217,188,247,10,56,173,33,19,28,109,143,248,211,33,237,175,98,217,138,55,215,236,226,228,182,136,48,161,159,193,151,135,224,225,82,69,89,121,138,117,245,122,135,215,242,111,229,169,183,156,254,179,173,95,150,175,251,211,208,202,178,187,1,131,149,203,232,25,228,26,249,87,144,60,193,252,222,105,220,33,131,150,228,104,208,221,38,223,255,104,218,203,250,126,255,154,217,158,39,46,103,228,221,41,58,148,153,52,238,227,115,229,106,237,228,89,161,102,252,103,147,253,11,37,208,158,98,71,8,0,0 };
			return method;
		}

		protected override SchemaMethod CreateBaseActiveRowChangedHandlerMethod() {
			SchemaMethod method = base.CreateBaseActiveRowChangedHandlerMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,82,77,79,2,49,16,61,47,9,255,161,236,129,116,131,54,120,70,72,248,10,138,138,68,208,11,225,48,236,14,75,99,105,73,219,5,209,240,223,237,126,68,32,17,46,77,58,125,111,222,123,211,89,128,65,214,113,71,59,180,124,139,111,106,215,93,129,140,49,122,0,25,9,212,52,104,148,75,124,73,104,197,88,205,101,204,30,205,40,17,226,85,247,215,27,187,167,47,16,106,101,158,185,177,1,169,86,201,24,98,100,83,141,56,208,60,98,19,20,24,90,140,70,42,66,195,186,42,145,150,180,72,61,32,63,229,146,183,5,77,204,9,128,52,175,177,103,245,121,163,32,173,255,36,29,101,104,148,100,61,52,168,57,8,254,141,103,134,192,144,97,91,107,216,167,84,238,196,185,140,240,203,177,234,105,97,169,52,66,184,34,244,216,212,1,78,218,231,62,189,52,124,145,189,171,100,8,150,230,16,246,1,34,193,251,252,169,69,253,53,90,24,131,93,249,193,13,249,31,1,113,172,49,6,203,149,156,238,55,232,7,1,73,5,188,102,243,108,18,57,205,204,252,39,220,251,115,54,85,147,172,1,13,10,67,222,194,25,255,76,35,120,135,204,96,154,170,86,75,11,233,61,155,226,251,166,147,88,235,102,211,151,176,16,24,185,208,121,248,74,145,62,67,245,212,78,94,198,29,39,81,252,221,45,185,115,212,3,65,97,48,179,114,73,106,9,14,113,93,101,128,182,7,22,38,42,209,33,210,128,185,197,59,174,72,38,243,11,149,0,62,58,154,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateShowColumnStructureExplorerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("54f6ff21-50d4-4145-bb41-f60014f1b890"),
				Name = "ShowColumnStructureExplorer",
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6db6693f-cd56-4514-b315-0db3864a60e3"),
				Name = "entitySchemaUId",
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,86,77,143,218,48,16,61,7,137,255,224,205,97,149,104,145,213,59,75,37,150,101,87,172,10,69,98,219,30,170,30,220,100,0,75,137,141,108,103,105,90,241,223,215,31,225,35,132,36,75,47,137,50,158,121,243,230,141,61,14,93,162,224,102,196,147,44,101,11,37,178,72,101,2,198,127,54,9,23,32,70,2,136,130,56,68,255,186,29,207,125,212,120,6,97,191,219,217,117,59,111,68,32,121,182,134,6,40,168,4,132,168,6,73,227,80,77,169,10,50,64,44,75,18,199,69,128,94,99,46,165,75,10,76,81,149,47,162,53,164,100,74,24,89,217,188,115,253,198,206,136,75,107,115,193,223,104,12,2,63,131,42,76,129,63,174,98,248,33,34,18,189,130,16,68,242,165,194,35,205,5,91,63,10,18,95,8,232,23,26,88,155,102,112,129,151,201,57,97,82,17,22,193,67,254,109,18,7,167,78,250,219,104,121,94,63,46,130,103,36,133,26,88,179,84,168,119,35,149,160,108,133,39,114,166,53,251,42,198,233,70,229,193,148,68,130,203,47,84,170,208,201,104,152,198,68,145,5,207,68,4,135,86,184,206,232,103,2,145,162,156,233,124,12,182,232,177,221,211,110,3,11,155,30,114,233,232,23,201,25,126,4,9,130,146,132,254,133,83,38,70,223,151,161,214,55,55,161,75,46,80,64,153,66,84,135,125,234,235,215,253,9,148,150,63,99,74,91,239,238,92,1,205,21,180,241,118,108,189,218,120,172,123,161,49,158,51,26,227,25,108,205,187,53,100,10,138,204,137,90,235,184,35,239,159,244,23,254,78,146,12,238,93,95,62,7,126,90,248,249,109,128,69,195,139,29,101,246,142,235,186,91,54,16,15,249,62,105,208,206,171,45,221,136,108,138,150,55,210,143,156,91,43,251,125,218,15,194,166,101,247,86,120,211,90,11,241,154,111,140,74,133,72,79,148,197,167,42,93,167,80,25,213,48,48,36,234,143,85,99,69,100,181,18,176,34,166,26,131,230,135,161,1,243,110,111,81,129,53,226,233,134,8,184,18,165,135,252,25,103,224,247,144,174,2,66,116,163,79,75,113,36,44,219,6,205,134,101,44,51,157,207,76,225,152,101,41,158,19,33,33,80,250,155,47,43,30,61,155,196,187,178,116,219,77,171,228,21,244,6,232,204,228,166,192,190,90,175,212,173,253,232,143,47,25,7,245,163,162,220,115,124,9,211,145,191,98,51,94,226,80,158,253,230,108,7,254,132,41,176,87,141,203,176,243,142,93,252,207,77,39,179,223,79,52,81,32,164,22,253,32,84,61,243,197,193,223,76,154,15,67,23,124,205,115,215,120,78,143,23,4,30,198,113,125,243,45,226,206,29,184,202,5,232,92,100,83,23,143,121,246,191,6,21,148,197,154,111,199,49,85,63,244,136,224,219,192,13,140,158,251,181,232,191,3,25,240,70,118,12,9,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateColumnStructureExplorerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2dc8ada4-28a8-4290-ab41-1ec46c2a4861"),
				Name = "CreateColumnStructureExplorer",
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,82,201,110,219,48,16,61,219,128,255,129,241,73,66,3,254,128,145,131,171,40,168,15,70,12,43,109,15,69,15,83,105,228,40,160,72,130,28,122,65,144,127,239,208,114,100,183,202,114,209,66,188,141,243,102,11,78,88,112,208,138,27,161,113,39,30,208,57,240,166,38,249,125,33,127,226,159,204,104,114,70,121,217,127,172,34,26,9,93,50,109,8,91,191,208,181,153,94,139,127,126,122,204,210,84,40,215,176,75,103,163,201,120,203,94,158,92,40,41,56,204,247,86,25,135,238,228,91,252,127,158,172,96,131,178,64,10,118,9,165,51,30,253,215,64,100,52,91,149,70,133,86,123,54,98,22,94,139,26,148,231,23,107,55,122,35,243,214,210,33,157,77,198,3,47,153,239,75,21,42,188,5,130,31,160,2,62,28,44,250,83,130,142,253,235,183,120,22,211,187,70,97,188,83,102,152,55,21,47,111,138,45,124,241,104,118,197,193,243,197,179,46,17,75,197,68,31,192,239,173,53,158,71,181,198,26,29,234,18,63,166,116,186,183,193,170,166,4,106,140,158,43,101,118,88,157,89,147,113,102,90,107,52,106,154,63,193,62,223,242,135,192,170,161,120,172,184,3,134,14,149,123,168,151,249,5,150,245,46,169,178,83,251,210,13,168,231,124,3,93,41,110,136,203,89,34,193,10,232,49,246,158,14,216,123,114,208,175,130,151,243,170,74,142,187,150,30,115,15,83,157,167,24,253,98,75,133,9,174,196,126,57,58,0,63,21,150,113,26,73,122,154,64,60,30,172,80,230,16,232,114,86,77,45,146,171,119,192,107,220,52,220,164,195,42,21,207,147,241,104,152,238,21,113,52,29,125,42,115,182,125,121,55,225,91,221,204,254,2,184,70,79,250,147,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetMetaPathInfoMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d762b97d-0b69-4cf1-91b0-692cddd65e75"),
				Name = "SetMetaPathInfo",
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("36623fe1-51a0-4158-82c5-fdeead047e32"),
				Name = "sender",
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("20ba189c-5f96-432c-88e0-969390dda016"),
				Name = "e",
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "AjaxEventArgs",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,81,209,78,194,48,20,125,222,190,162,246,129,116,137,233,15,204,153,8,168,25,17,37,1,125,33,60,148,237,2,213,173,37,109,65,167,225,223,237,186,9,27,32,75,150,45,247,156,123,238,185,231,110,153,66,32,12,55,197,56,89,65,206,134,76,176,37,40,20,161,145,253,210,170,72,91,216,72,201,45,79,65,209,71,48,117,137,224,251,83,13,28,32,166,209,4,148,98,90,46,12,237,73,5,212,241,56,104,122,166,33,244,155,69,164,171,79,116,206,95,57,59,22,218,48,145,64,183,120,141,83,242,50,127,135,196,196,105,16,250,91,187,83,34,179,77,46,180,237,30,104,41,104,31,52,40,206,50,254,13,196,154,248,50,138,141,152,98,57,24,80,122,138,185,129,92,199,98,33,241,204,153,30,220,89,211,69,232,47,172,101,150,172,16,25,84,242,181,44,226,226,111,64,128,126,124,175,105,187,87,49,224,180,20,213,27,149,222,155,64,183,24,130,177,118,204,138,84,162,244,141,101,27,184,209,70,113,177,188,37,56,175,97,28,216,229,188,154,115,151,166,68,192,39,26,216,115,172,65,153,130,224,148,25,230,90,39,197,26,240,53,114,176,43,144,83,59,180,223,100,211,103,155,69,80,234,239,92,124,57,75,148,212,79,92,27,107,187,94,181,10,86,102,233,176,9,158,196,123,64,91,81,242,5,34,13,213,171,8,137,77,150,161,78,231,72,177,6,92,174,251,248,91,131,203,244,91,61,142,219,38,231,123,102,126,68,243,14,70,254,207,25,69,209,97,196,133,115,84,138,158,87,233,77,177,150,202,224,25,186,208,236,24,229,25,237,51,183,134,63,220,239,206,119,239,206,166,239,183,210,61,184,167,19,57,118,34,196,118,63,240,44,43,239,71,92,84,225,47,131,227,37,33,197,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetSortConditionColumnMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("66ab635e-74c8-4246-a4bd-0ded5d9b3a44"),
				Name = "SetSortConditionColumn",
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("601f831f-5895-4e43-a4df-1d5ec4ab48de"),
				Name = "orderDirection",
				CreatedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				ModifiedInSchemaUId = new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "OrderDirection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,77,75,3,49,16,134,207,45,244,63,140,123,144,4,36,244,190,182,32,173,138,213,214,66,139,151,210,195,184,59,221,6,211,164,76,178,194,42,254,119,211,221,98,183,32,226,33,185,228,125,158,249,32,122,3,226,194,7,214,182,80,15,126,86,26,243,204,183,187,125,168,196,20,51,118,254,73,251,32,225,242,18,230,88,144,90,50,209,61,235,92,45,200,80,22,40,159,185,156,188,26,185,210,6,24,66,95,194,103,175,219,121,71,6,223,10,192,224,47,122,213,95,167,71,104,247,83,50,34,19,239,172,26,147,39,214,104,244,7,157,53,132,30,38,55,204,88,29,208,141,99,194,108,11,226,228,0,109,91,182,166,173,142,142,179,30,71,29,57,155,97,16,77,68,189,160,41,233,186,121,26,138,100,71,1,231,24,182,137,188,130,223,19,88,20,76,5,6,237,236,178,218,83,34,37,12,6,103,51,55,132,95,37,143,84,37,107,181,116,139,154,21,242,216,75,167,17,175,18,239,56,36,235,56,175,227,156,120,172,57,42,162,182,69,164,117,126,84,50,147,13,7,119,84,194,63,171,165,145,172,241,215,184,162,183,218,244,21,175,195,153,182,151,125,218,213,121,225,24,236,117,239,180,49,99,12,40,108,252,30,50,253,6,248,216,6,12,51,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysModuleReportTableFieldsGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("445827a4-3d9e-4c2f-9ca9-6449578f34bc"));
		}

		#endregion

	}

	#endregion

}

