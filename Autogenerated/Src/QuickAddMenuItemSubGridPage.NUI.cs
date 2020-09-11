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
	using System.Threading;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Core.Store;
	using Terrasoft.Reports;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;
	using TSConfiguration = Terrasoft.Configuration;
	using web = System.Web;
	using WebControls = Terrasoft.UI.WebControls.Controls;

	#region Class: QuickAddMenuItemSubGridPageSchema

	/// <exclude/>
	public class QuickAddMenuItemSubGridPageSchema : Terrasoft.WebApp.BaseManyToManyDetailGridPageSchema
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

		public QuickAddMenuItemSubGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public QuickAddMenuItemSubGridPageSchema(QuickAddMenuItemSubGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				ImageHash = @""
			};
			CopyButton.ModifiedInSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
			RealUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
			Name = "QuickAddMenuItemSubGridPage";
			ParentSchemaUId = new Guid("bb5ab5ef-40b7-45f6-b503-17afaa6584a0");
			CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateQuickAddMenuItemSubGridPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateTreeGrid();
			UpdateShowChangelogMenuItem();
			UpdateCallMenuItem();
			UpdateSendTemplateEmailMenuItem();
			UpdateSendEmailMenuItem();
			UpdateButtonsControlLayout();
			UpdateContextHelpButton();
			UpdatePrintButton();
			UpdateActionButton();
			UpdateDeleteButton();
			UpdateEditButton();
			UpdateCopyButton();
			UpdateAddButton();
			TopLevelControl.MoveItem(0, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, AddButton);
			ButtonsControlLayout.MoveItem(1, CopyButton);
			ButtonsControlLayout.MoveItem(2, EditButton);
			ButtonsControlLayout.MoveItem(3, DeleteButton);
			ButtonsControlLayout.MoveItem(4, SpacerPrintButton);
			ButtonsControlLayout.MoveItem(5, ActionButton);
			ButtonsControlLayout.InsertItem(6, CreateUpButton());
			ButtonsControlLayout.InsertItem(7, CreateDownButton());
			ButtonsControlLayout.MoveItem(8, PrintButton);
			ButtonsControlLayout.MoveItem(9, ContextHelpButton);
			TopLevelControl.MoveItem(1, TreeGrid);
			TreeGrid.MoveItem(0, SendEmailMenuItem);
			TreeGrid.MoveItem(1, SendTemplateEmailMenuItem);
			TreeGrid.MoveItem(2, CallMenuItem);
			TreeGrid.MoveItem(3, ShowChangelogMenuItem);
			TopLevelControl.MoveItem(2, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateQuickAddMenuItemSubGridPageEventsProcessSchema() {
			var schema = new QuickAddMenuItemSubGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateUpButton() {
			_upButton = new Terrasoft.UI.WebControls.Controls.Button();
			_upButton.UId = new Guid("1c86dada-ed0b-45b5-8638-155bb7bc681c");
			_upButton.Name = "UpButton";
			_upButton.CreatedInSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
			_upButton.ModifiedInSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
			_upButton.CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e");
			_upButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_upButton.Tag = "";
			_upButton.Image = new ControlImage {};
			return _upButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateDownButton() {
			_downButton = new Terrasoft.UI.WebControls.Controls.Button();
			_downButton.UId = new Guid("f8c72edc-641a-48aa-b703-b1dd806549b6");
			_downButton.Name = "DownButton";
			_downButton.CreatedInSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
			_downButton.ModifiedInSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
			_downButton.CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e");
			_downButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_downButton.Tag = "";
			_downButton.Image = new ControlImage {};
			return _downButton;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("a526ee14-e5f7-4174-8f48-ad030d8862af");
			DataSource.ModifiedInSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("946c5eca-4b1b-4c55-acd6-9056e0f74ac2");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
				column.ModifiedInSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("448b38d0-b1a2-4691-be0c-26120532ded1");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
				column.ModifiedInSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("54da8f3d-50b0-438e-aa9a-ce6098de7ed3");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
				column.ModifiedInSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("831ff8ec-7ff6-496c-8b4c-83b4f2d7d808");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
				column.ModifiedInSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("482b37da-db89-461f-a18e-4b99053a8c28");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
				column.ModifiedInSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("5f53f452-4318-4412-a648-c5aae0ec6a2c");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
				column.ModifiedInSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("17031297-a36e-490d-b08f-9ae1088678dd");
			if (column != null) {
				column.UId = new Guid("d6947b95-ea2d-44ea-a75d-838f026c8783");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
				column.ModifiedInSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("055b00cf-3a59-407c-810c-4c4642774ef7");
			if (column != null) {
				column.UId = new Guid("10ffdefe-ed0a-4773-a32e-49cd45edb901");
				column.Name = @"SysModuleEdit";
				column.CreatedInSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
				column.ModifiedInSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("b743c56b-8c92-4c20-8fc7-fa62299d16fe");
			if (column != null) {
				column.UId = new Guid("429591fb-0549-4150-8b92-1fc976296651");
				column.Name = @"QuickAddMenuSettings";
				column.CreatedInSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
				column.ModifiedInSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("881e0a65-a92c-4a78-af62-796dc72312ba");
			if (column != null) {
				column.UId = new Guid("3841a464-a592-4121-9c2d-e66725244f4c");
				column.Name = @"Position";
				column.CreatedInSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
				column.ModifiedInSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("2326f2b8-6c93-4b44-9760-d043a3b4a6fe");
			if (column != null) {
				column.UId = new Guid("25aff5ea-d084-4322-913c-a94fe83cf6b5");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
				column.ModifiedInSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new QuickAddMenuItemSubGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new QuickAddMenuItemSubGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new QuickAddMenuItemSubGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: QuickAddMenuItemSubGridPageEventsProcess

	/// <exclude/>
	public class QuickAddMenuItemSubGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseManyToManyDetailGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.QuickAddMenuItemSubGridPageSchemaUserControl
	{

		public QuickAddMenuItemSubGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "QuickAddMenuItemSubGridPageEventsProcess";
			SchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
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

		public virtual int DataSourceRowsCount {
			get;
			set;
		}

		public virtual Guid MovedPrimaryColumnValue {
			get;
			set;
		}

		public virtual int MaxPosition {
			get;
			set;
		}

		public virtual int MinPosition {
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
					SchemaElementUId = new Guid("9ce5265c-8b4f-46fc-8072-3a2bdf3e40ed"),
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
					SchemaElementUId = new Guid("1efc39c6-bcbd-4753-9145-4bc1753fa155"),
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
					SchemaElementUId = new Guid("bd8f661f-e32b-4f2c-adbe-31d3f3663827"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
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
					SchemaElementUId = new Guid("76619400-5a7f-4ebd-83ac-bdb24057a3bd"),
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
					SchemaElementUId = new Guid("bddeb7bb-f084-4b6e-b5e0-1cd25c54d185"),
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
					SchemaElementUId = new Guid("f8fccfdd-b85a-4941-8c1f-2927073cba89"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask2Execute,
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
					SchemaElementUId = new Guid("c221c9d2-b58e-4edf-8df7-2e92d97d1fcd"),
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
					SchemaElementUId = new Guid("5545a9db-f7e4-4015-b15e-fe5e6cca4696"),
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
					SchemaElementUId = new Guid("334d476f-ce78-47ff-a9b2-5806ff5d722a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3Execute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess10;
		public ProcessFlowElement EventSubProcess10 {
			get {
				return _eventSubProcess10 ?? (_eventSubProcess10 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess10",
					SchemaElementUId = new Guid("6a42b9c9-b007-4dff-9804-8c9ce63c5965"),
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
					SchemaElementUId = new Guid("59e4c487-ebaa-443a-8ef2-5eb1b50ee91b"),
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
					SchemaElementUId = new Guid("d5f2e457-d945-4787-b85e-5c981de75d63"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask4Execute,
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
					SchemaElementUId = new Guid("e5b9adf2-dd0f-4ce9-a313-f367ec417efd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "DeleteYesMessage",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess11;
		public ProcessFlowElement EventSubProcess11 {
			get {
				return _eventSubProcess11 ?? (_eventSubProcess11 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess11",
					SchemaElementUId = new Guid("15d99c47-bd4c-4b2c-a407-dbb4e6faf254"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageInit;
		public ProcessFlowElement StartMessageInit {
			get {
				return _startMessageInit ?? (_startMessageInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageInit",
					SchemaElementUId = new Guid("85b14b04-0681-437c-bfa6-76e40257db29"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _initScriptTask;
		public ProcessScriptTask InitScriptTask {
			get {
				return _initScriptTask ?? (_initScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InitScriptTask",
					SchemaElementUId = new Guid("00390d6a-0985-4871-9645-4353e942d662"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent3;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent3 {
			get {
				return _intermediateThrowMessageEvent3 ?? (_intermediateThrowMessageEvent3 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent3",
					SchemaElementUId = new Guid("215410a0-20d2-4b8d-9876-51449db53b8f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[EventSubProcess8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8 };
			FlowElements[StartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2 };
			FlowElements[ScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask2 };
			FlowElements[EventSubProcess9.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess9 };
			FlowElements[StartMessage3.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3 };
			FlowElements[ScriptTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3 };
			FlowElements[EventSubProcess10.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess10 };
			FlowElements[StartMessage4.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage4 };
			FlowElements[ScriptTask4.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask4 };
			FlowElements[IntermediateThrowMessageEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent2 };
			FlowElements[EventSubProcess11.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess11 };
			FlowElements[StartMessageInit.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageInit };
			FlowElements[InitScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InitScriptTask };
			FlowElements[IntermediateThrowMessageEvent3.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent3 };
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
					case "EventSubProcess8":
						break;
					case "StartMessage2":
						e.Context.QueueTasks.Enqueue("ScriptTask2");
						break;
					case "ScriptTask2":
						break;
					case "EventSubProcess9":
						break;
					case "StartMessage3":
						e.Context.QueueTasks.Enqueue("ScriptTask3");
						break;
					case "ScriptTask3":
						break;
					case "EventSubProcess10":
						break;
					case "StartMessage4":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent2");
						break;
					case "ScriptTask4":
						break;
					case "IntermediateThrowMessageEvent2":
						e.Context.QueueTasks.Enqueue("ScriptTask4");
						break;
					case "EventSubProcess11":
						break;
					case "StartMessageInit":
						e.Context.QueueTasks.Enqueue("InitScriptTask");
						break;
					case "InitScriptTask":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent3");
						break;
					case "IntermediateThrowMessageEvent3":
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
			ActivatedEventElements.Add("StartMessage4");
			ActivatedEventElements.Add("StartMessageInit");
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
				case "EventSubProcess8":
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
				case "EventSubProcess9":
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
				case "EventSubProcess10":
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
				case "IntermediateThrowMessageEvent2":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "DeleteYesMessage");
					result = IntermediateThrowMessageEvent2.Execute(context);
					break;
				case "EventSubProcess11":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageInit";
					result = StartMessageInit.Execute(context);
					break;
				case "InitScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitScriptTask";
					result = InitScriptTask.Execute(context, InitScriptTaskExecute);
					break;
				case "IntermediateThrowMessageEvent3":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = IntermediateThrowMessageEvent3.Execute(context);
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
				case "MinPosition":
					MinPosition = reader.GetValue<System.Int32>();
				break;
				case "MaxPosition":
					MaxPosition = reader.GetValue<System.Int32>();
				break;
				case "MovedPrimaryColumnValue":
					MovedPrimaryColumnValue = reader.GetValue<System.Guid>();
				break;
				case "DataSourceRowsCount":
					DataSourceRowsCount = reader.GetValue<System.Int32>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			MoveItem(-1);
			return true;
		}

		public virtual bool ScriptTask2Execute(ProcessExecutingContext context) {
			MoveItem(1);
			return true;
		}

		public virtual bool ScriptTask3Execute(ProcessExecutingContext context) {
			DataSourceRowsCount = Page.DataSource.Rows.Count;
			Page.DataSource.SelectedItemPrimaryColumnValues.Clear();
			if (MovedPrimaryColumnValue != Guid.Empty) {
				Page.DataSource.SetClientActiveRow(MovedPrimaryColumnValue);
				Page.DataSource.SelectedItemPrimaryColumnValues.Add(MovedPrimaryColumnValue);
				MovedPrimaryColumnValue = Guid.Empty;
			} else {
				var activeRowUId = Guid.Empty;
				if (DataSourceRowsCount > 0) {
					var e = context.ThrowEventArgs as DataSourceEventArgs;
					if (e != null && e.Row != null) {
						activeRowUId = e.Row.PrimaryColumnValue;
					} else {
						activeRowUId = Page.DataSource.Rows[0].PrimaryColumnValue;
					}
					Page.DataSource.SetClientActiveRow(activeRowUId, true);
					Page.DataSource.SelectedItemPrimaryColumnValues.Add(
											Page.DataSource.ActiveRowPrimaryColumnValue);
				} else {
					Page.DataSource.SetClientActiveRow(activeRowUId, true);
				}
				if (!IsDetailGrid) {
					SelectedNodePrimaryColumnValue = activeRowUId;
					ListenerThrowEvent(ListenerPageProcessUId, "GridLoadRows");
				}
				ActivateButtons(DataSourceRowsCount > 0);
			}
			
			return true;
		}

		public virtual bool ScriptTask4Execute(ProcessExecutingContext context) {
			NormalizePositions();
			return true;
		}

		public virtual bool InitScriptTaskExecute(ProcessExecutingContext context) {
			Page.DataSource.EnableServerActiveRow = true;
			return true;
		}

		public override System.Collections.Generic.List<string> GetButtons() {
			var buttons = new System.Collections.Generic.List<string>();
			buttons.Add(Page.AddButton.Name);
			buttons.Add(Page.EditButton.Name);
			buttons.Add(Page.CopyButton.Name);
			buttons.Add(Page.DeleteButton.Name);
			buttons.Add(Page.PrintButton.Name);
			buttons.Add(Page.UpButton.Name);
			buttons.Add(Page.DownButton.Name);
			return buttons;
		}

		public override void InitializeDetailEditPageId() {
			if (EditPageUId == Guid.Empty) {
				Guid editPageSchemaId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
				EditPageUId = editPageSchemaId;
			}
		}

		public override void ActivateButtons(bool activate) {
			var buttons = GetButtons();
			var dataSourceRowsCount = Page.DataSource.ActiveRowPrimaryColumnValue == Guid.Empty || !activate ? 0 : 1;
			bool addButtonEnabledByRights = true;
			bool deleteButtonEnabledByRights = true;
			bool editButtonEnabledByRights = true;
			bool copyButtonEnabledByRights = true;
			int currentPosition = 0;
			Page.DataSource.EnableServerActiveRow = true;
			var entitySchema = Page.DataSource.Schema;
			if (entitySchema != null) {
				var dbSecurityEngine = Page.UserConnection.DBSecurityEngine;
				string schemaName = entitySchema.Name;
				deleteButtonEnabledByRights = dbSecurityEngine.GetIsEntitySchemaDeletingAllowed(schemaName);
				addButtonEnabledByRights = dbSecurityEngine.GetIsEntitySchemaAppendingAllowed(schemaName);
				copyButtonEnabledByRights = dbSecurityEngine.GetIsEntitySchemaAppendingAllowed(schemaName);
				editButtonEnabledByRights = dbSecurityEngine.GetIsEntitySchemaEditingAllowed(schemaName);
				GetMaxMinPosition();
				currentPosition = (Page.DataSource.ActiveRow != null)
					? Page.DataSource.ActiveRow.GetTypedColumnValue<int>("Position")
					: MinPosition;
			}
			foreach(var control in Page.ButtonsControlLayout.Controls) {
				var button = control as Terrasoft.UI.WebControls.Controls.Button;
				if (button != null && string.CompareOrdinal(button.Name, "ContextHelpButton") != 0) {
					if (buttons.Contains(button.Name)) {
						switch (button.Name) {
							case "AddButton":
								button.Enabled = addButtonEnabledByRights;
							break;
							case "DeleteButton":
								button.Enabled = (dataSourceRowsCount > 0) && deleteButtonEnabledByRights;
							break;
							case "EditButton":
								button.Enabled = (dataSourceRowsCount > 0) && editButtonEnabledByRights;
							break;
							case "CopyButton":
								button.Enabled = (dataSourceRowsCount > 0) && copyButtonEnabledByRights;
							break;
							case "UpButton":
								button.Enabled = (dataSourceRowsCount > 0) && (currentPosition > MinPosition);
							break;
							case "DownButton":
								button.Enabled = (dataSourceRowsCount > 0) && (currentPosition < MaxPosition);
							break;
							default :
								button.Enabled = (dataSourceRowsCount > 0);
							break;
						}
					} else {
						button.Enabled = true;
					}
				}
			}
			if (IsDetailGrid && SelectedNodePrimaryColumnValue == Guid.Empty) {
				foreach(var control in Page.ButtonsControlLayout.Controls) {
					var button = control as Terrasoft.UI.WebControls.Controls.Button;
					if (button != null && string.CompareOrdinal(button.Name, "ContextHelpButton") != 0) {
						button.Enabled = false;		
					}
				}
			}
		}

		public virtual void MoveItem(int incrementPosition) {
			var dataSource = Page.DataSource;
			var schema = Page.DataSource.Schema;
			var firstEntityUId = dataSource.ActiveRowPrimaryColumnValue;
			var secondEntityUId = Guid.Empty;
			var query = new EntitySchemaQuery(schema);
			var primaryColumnName = query.AddColumn(schema.GetPrimaryColumnName()).Name;
			var positionColumnName = query.AddColumn("Position").Name;
			var dataSourceFilters = dataSource.CurrentStructure.Filters.ToEntitySchemaQueryFilterCollection(query);
			query.Filters.Add(dataSourceFilters);
			var entity = query.GetEntity(UserConnection, firstEntityUId);
			if (entity == null) {
				return;
			}
			var firstPosition = entity.GetTypedColumnValue<int>(positionColumnName);
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var dataSourceRowCountQuery = new EntitySchemaQuery(schema);
			dataSourceRowCountQuery.AddColumn(schema.GetPrimaryColumnName());
			dataSourceRowCountQuery.Filters.Add(dataSourceFilters);
			var entities = dataSourceRowCountQuery.GetEntityCollection(UserConnection);
			DataSourceRowsCount = entities.Count;
			if ((firstPosition + incrementPosition) < 0 || (firstPosition + incrementPosition) > DataSourceRowsCount) {
				return;
			}
			query.Filters.Clear();
			query.ResetSelectQuery();
			query.Filters.Add(dataSourceFilters);
			query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.Equal, 
				"Position", firstPosition + incrementPosition));
			query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.NotEqual, 
				schema.GetPrimaryColumnName(), firstEntityUId));
			entities = query.GetEntityCollection(UserConnection);
			if (entities.Count > 0) {
				secondEntityUId = entities[0].GetTypedColumnValue<Guid>(primaryColumnName);
			}
			var firstEntity = schema.CreateEntity(UserConnection);
			if (firstEntity.FetchFromDB(firstEntityUId)) {
				firstEntity.SetColumnValue("Position", firstPosition + incrementPosition);
				firstEntity.Save();
				MovedPrimaryColumnValue = firstEntityUId;
			}
			var secondEntity = schema.CreateEntity(UserConnection);
			if (secondEntity.FetchFromDB(secondEntityUId)) {
				secondEntity.SetColumnValue("Position", firstPosition);
				secondEntity.Save();
			}
			Page.TreeGrid.Clear();
			dataSource.LoadRows();
		}

		public virtual void NormalizePositions() {
			var sysAdminOperationGranteeSchemaQuery = new EntitySchemaQuery(Page.DataSource.Schema);
			var primarySchemaColumnName = Page.DataSource.Schema.GetPrimaryColumnName();
			var entitySchemaQuery = new EntitySchemaQuery(Page.DataSource.Schema);
			var primaryQueryColumnName = entitySchemaQuery.AddColumn(primarySchemaColumnName).Name;
			entitySchemaQuery.AddColumn("Position").OrderByAsc();
			var dataSourceFilters = Page.DataSource.CurrentStructure.Filters.ToEntitySchemaQueryFilterCollection(entitySchemaQuery);
			entitySchemaQuery.Filters.Add(dataSourceFilters);
			var entities = entitySchemaQuery.GetEntityCollection(UserConnection);
			
			var positionParam = new QueryParameter("P1", 0);
			var entityIdParam = new QueryParameter("P2", Guid.Empty);
			var update = new Update(UserConnection, Page.DataSource.Schema.Name)
				.Set("Position", positionParam)
				.Where(primarySchemaColumnName).IsEqual(entityIdParam) as Update; 	
			
			for (var i = 0; i < entities.Count; i++) {
				if (entities[i].GetTypedColumnValue<int>("Position") != i) {
					entityIdParam.Value = entities[i].GetTypedColumnValue<Guid>(primaryQueryColumnName);
					positionParam.Value = i;
					update.Execute();		
				}
			}
			
			Page.TreeGrid.Clear();
			Page.DataSource.LoadRows();
		}

		public virtual void GetMaxMinPosition() {
			if (Page.DataSource.ActiveRow != null || Page.TreeGrid.DataSource.Rows.Count != 0) {
				var QuickettingsId = (Page.DataSource.ActiveRow == null)
					? Page.TreeGrid.DataSource.Rows[0].GetTypedColumnValue<Guid>("QuickAddMenuSettingsId")
					: Page.DataSource.ActiveRow.GetTypedColumnValue<Guid>("QuickAddMenuSettingsId");
					var selectPos = 
						new Select(UserConnection)
						.Column(Func.Max("Position")).As("MaxPosition")
						.Column(Func.Min("Position")).As("MinPosition")
						.From("QuickAddMenuItem")
						.Where("QuickAddMenuSettingsId").IsEqual(Column.Parameter(QuickettingsId))
						as Select;
				using (var dbExecutor = UserConnection.EnsureDBConnection()) {
						using (var reader = selectPos.ExecuteReader(dbExecutor)) {
							while(reader.Read()) {
								MaxPosition = reader.GetColumnValue<int>("MaxPosition");
								MinPosition = reader.GetColumnValue<int>("MinPosition");
							}
						}
				}
			} else {
				MaxPosition = 0;
				MinPosition = 0;
			}
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "UpButtonClick":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
						}
						break;
					case "DownButtonClick":
							if (ActivatedEventElements.Contains("StartMessage2")) {
							context.QueueTasks.Enqueue("StartMessage2");
						}
						break;
					case "DataSourceLoadRowsResponseRegistered":
							if (ActivatedEventElements.Contains("StartMessage3")) {
							context.QueueTasks.Enqueue("StartMessage3");
							ProcessQueue(context);
							return;
						}
						break;
					case "DeleteYesMessage":
							if (ActivatedEventElements.Contains("StartMessage4")) {
							context.QueueTasks.Enqueue("StartMessage4");
							ProcessQueue(context);
							return;
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("StartMessageInit")) {
							context.QueueTasks.Enqueue("StartMessageInit");
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
			if (!HasMapping("MinPosition") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("MinPosition", MinPosition, 0);
			}
			if (!HasMapping("MaxPosition") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("MaxPosition", MaxPosition, 0);
			}
			if (!HasMapping("MovedPrimaryColumnValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("MovedPrimaryColumnValue", MovedPrimaryColumnValue, Guid.Empty);
			}
			if (!HasMapping("DataSourceRowsCount") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("DataSourceRowsCount", DataSourceRowsCount, 0);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: QuickAddMenuItemSubGridPageEventsProcess

	/// <exclude/>
	public class QuickAddMenuItemSubGridPageEventsProcess : QuickAddMenuItemSubGridPageEventsProcess<Terrasoft.WebApp.QuickAddMenuItemSubGridPageSchemaUserControl>
	{

		public QuickAddMenuItemSubGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: QuickAddMenuItemSubGridPageSchemaUserControl

	/// <exclude/>
	public partial class QuickAddMenuItemSubGridPageSchemaUserControl : Terrasoft.WebApp.BaseManyToManyDetailGridPageSchemaUserControl
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
			var process = (QuickAddMenuItemSubGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new QuickAddMenuItemSubGridPageEventsProcess(UserConnection);
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
			SchemaName = "QuickAddMenuItemSubGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: QuickAddMenuItemSubGridPageEventsProcessSchema

	/// <exclude/>
	public class QuickAddMenuItemSubGridPageEventsProcessSchema : Terrasoft.WebApp.BaseManyToManyDetailGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public QuickAddMenuItemSubGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public QuickAddMenuItemSubGridPageEventsProcessSchema(QuickAddMenuItemSubGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "QuickAddMenuItemSubGridPageEventsProcess";
			UId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1");
			CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateDataSourceRowsCountParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("05ee8d3c-80d7-4da2-b078-f233833ed194"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				Name = @"DataSourceRowsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMovedPrimaryColumnValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("683d2627-b262-4ed9-8653-7b5722429f8d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				Name = @"MovedPrimaryColumnValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMaxPositionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9f2966b9-1925-4b79-99c5-83788b702c11"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				Name = @"MaxPosition",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMinPositionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9122dbe3-1ae2-4154-9e48-3d4914f5335d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				Name = @"MinPosition",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateDataSourceRowsCountParameter());
			Parameters.Add(CreateMovedPrimaryColumnValueParameter());
			Parameters.Add(CreateMaxPositionParameter());
			Parameters.Add(CreateMinPositionParameter());
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
			ProcessSchemaLane schemaLane4 = CreateLane4Lane();
			schemaLaneSet1.Lanes.Add(schemaLane4);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess8 = CreateEventSubProcess8EventSubProcess();
			FlowElements.Add(eventsubprocess8);
			ProcessSchemaEventSubProcess eventsubprocess9 = CreateEventSubProcess9EventSubProcess();
			FlowElements.Add(eventsubprocess9);
			ProcessSchemaEventSubProcess eventsubprocess10 = CreateEventSubProcess10EventSubProcess();
			FlowElements.Add(eventsubprocess10);
			ProcessSchemaEventSubProcess eventsubprocess11 = CreateEventSubProcess11EventSubProcess();
			FlowElements.Add(eventsubprocess11);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			eventsubprocess1.FlowElements.Add(startmessage1);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			eventsubprocess1.FlowElements.Add(scripttask1);
			ProcessSchemaStartMessageEvent startmessage2 = CreateStartMessage2StartMessageEvent();
			eventsubprocess8.FlowElements.Add(startmessage2);
			ProcessSchemaScriptTask scripttask2 = CreateScriptTask2ScriptTask();
			eventsubprocess8.FlowElements.Add(scripttask2);
			ProcessSchemaStartMessageEvent startmessage3 = CreateStartMessage3StartMessageEvent();
			eventsubprocess9.FlowElements.Add(startmessage3);
			ProcessSchemaScriptTask scripttask3 = CreateScriptTask3ScriptTask();
			eventsubprocess9.FlowElements.Add(scripttask3);
			ProcessSchemaStartMessageEvent startmessage4 = CreateStartMessage4StartMessageEvent();
			eventsubprocess10.FlowElements.Add(startmessage4);
			ProcessSchemaScriptTask scripttask4 = CreateScriptTask4ScriptTask();
			eventsubprocess10.FlowElements.Add(scripttask4);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent2 = CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent();
			eventsubprocess10.FlowElements.Add(intermediatethrowmessageevent2);
			ProcessSchemaStartMessageEvent startmessageinit = CreateStartMessageInitStartMessageEvent();
			eventsubprocess11.FlowElements.Add(startmessageinit);
			ProcessSchemaScriptTask initscripttask = CreateInitScriptTaskScriptTask();
			eventsubprocess11.FlowElements.Add(initscripttask);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent3 = CreateIntermediateThrowMessageEvent3IntermediateThrowMessageEvent();
			eventsubprocess11.FlowElements.Add(intermediatethrowmessageevent3);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("a956cdc5-6dc9-4c12-9e3f-8f163b49f3ce"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1efc39c6-bcbd-4753-9145-4bc1753fa155"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bd8f661f-e32b-4f2c-adbe-31d3f3663827"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("b66c7495-b1c4-44a0-806c-4537e5b4757b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bddeb7bb-f084-4b6e-b5e0-1cd25c54d185"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f8fccfdd-b85a-4941-8c1f-2927073cba89"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("362a344d-e0b9-4ff0-af1e-168b7cf78c91"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				CurveCenterPosition = new Point(146, 415),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5545a9db-f7e4-4015-b15e-fe5e6cca4696"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("334d476f-ce78-47ff-a9b2-5806ff5d722a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("695c857f-09b4-4e8d-ae2d-a78d4a20e5b9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				CurveCenterPosition = new Point(160, 594),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("59e4c487-ebaa-443a-8ef2-5eb1b50ee91b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e5b9adf2-dd0f-4ce9-a313-f367ec417efd"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("8ac7d7fe-a75d-4b94-a651-2b73284288a1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				CurveCenterPosition = new Point(270, 595),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e5b9adf2-dd0f-4ce9-a313-f367ec417efd"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d5f2e457-d945-4787-b85e-5c981de75d63"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("9da943a4-ed2f-47c4-b814-bab0af2c21bd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				CurveCenterPosition = new Point(368, 415),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("85b14b04-0681-437c-bfa6-76e40257db29"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("00390d6a-0985-4871-9645-4353e942d662"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("f91503d9-cc02-4caa-94c0-d43b2117eaf3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				CurveCenterPosition = new Point(507, 412),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("00390d6a-0985-4871-9645-4353e942d662"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("215410a0-20d2-4b8d-9876-51449db53b8f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("a9a70aeb-f1b2-482c-bb52-7075e1b68eeb"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(822, 681),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("1baf03bb-a3cc-4012-a1c9-5080ac849fd2"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("a9a70aeb-f1b2-482c-bb52-7075e1b68eeb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				Name = @"Lane1",
				Position = new Point(29, 164),
				Size = new Size(793, 159),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("5d1f40a7-3933-4047-aa14-50999c1cd94a"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("a9a70aeb-f1b2-482c-bb52-7075e1b68eeb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				Name = @"Lane2",
				Position = new Point(29, 0),
				Size = new Size(793, 159),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaLane CreateLane3Lane() {
			ProcessSchemaLane schemaLane3 = new ProcessSchemaLane(this) {
				UId = new Guid("88476481-7eea-49f5-b8e0-5bbeb38972e8"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("a9a70aeb-f1b2-482c-bb52-7075e1b68eeb"),
				CreatedInOwnerSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				Name = @"Lane3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 328),
				Size = new Size(793, 173),
				UseBackgroundMode = false
			};
			return schemaLane3;
		}

		protected virtual ProcessSchemaLane CreateLane4Lane() {
			ProcessSchemaLane schemaLane4 = new ProcessSchemaLane(this) {
				UId = new Guid("3604ffd2-6213-4e06-bb7b-c503155d1b9c"),
				ContainerItemIndex = 4,
				ContainerUId = new Guid("a9a70aeb-f1b2-482c-bb52-7075e1b68eeb"),
				CreatedInOwnerSchemaUId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				Name = @"Lane4",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 506),
				Size = new Size(793, 175),
				UseBackgroundMode = false
			};
			return schemaLane4;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("9ce5265c-8b4f-46fc-8072-3a2bdf3e40ed"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1baf03bb-a3cc-4012-a1c9-5080ac849fd2"),
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				Name = @"EventSubProcess1",
				Position = new Point(36, 10),
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
				UId = new Guid("1efc39c6-bcbd-4753-9145-4bc1753fa155"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9ce5265c-8b4f-46fc-8072-3a2bdf3e40ed"),
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"UpButtonClick",
				ModifiedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
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
				UId = new Guid("bd8f661f-e32b-4f2c-adbe-31d3f3663827"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9ce5265c-8b4f-46fc-8072-3a2bdf3e40ed"),
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				Name = @"ScriptTask1",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,205,47,75,245,44,73,205,213,208,53,212,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,81,182,136,39,27,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess8EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess8 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("76619400-5a7f-4ebd-83ac-bdb24057a3bd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5d1f40a7-3933-4047-aa14-50999c1cd94a"),
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
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

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("bddeb7bb-f084-4b6e-b5e0-1cd25c54d185"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("76619400-5a7f-4ebd-83ac-bdb24057a3bd"),
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DownButtonClick",
				ModifiedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
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
				UId = new Guid("f8fccfdd-b85a-4941-8c1f-2927073cba89"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("76619400-5a7f-4ebd-83ac-bdb24057a3bd"),
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				Name = @"ScriptTask2",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,205,47,75,245,44,73,205,213,48,212,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,141,254,176,158,26,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c221c9d2-b58e-4edf-8df7-2e92d97d1fcd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("88476481-7eea-49f5-b8e0-5bbeb38972e8"),
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				Name = @"EventSubProcess9",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 0),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(186, 159),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess9;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage3StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5545a9db-f7e4-4015-b15e-fe5e6cca4696"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c221c9d2-b58e-4edf-8df7-2e92d97d1fcd"),
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DataSourceLoadRowsResponseRegistered",
				ModifiedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				Name = @"StartMessage3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 66),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask3ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("334d476f-ce78-47ff-a9b2-5806ff5d722a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c221c9d2-b58e-4edf-8df7-2e92d97d1fcd"),
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				Name = @"ScriptTask3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(85, 52),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,146,77,107,194,64,16,134,207,6,242,31,86,15,69,161,4,239,98,193,26,17,193,22,169,109,47,165,135,37,59,181,11,155,221,178,59,27,43,197,255,94,119,155,196,144,15,41,230,144,195,206,204,59,207,204,59,49,69,186,85,86,39,240,164,246,102,174,172,68,50,37,27,186,131,40,46,67,145,139,69,62,56,9,131,122,112,11,2,18,4,182,66,72,55,154,167,84,31,230,74,216,84,190,82,97,225,84,39,128,234,225,232,84,201,63,200,240,65,101,192,154,105,164,63,37,75,203,89,180,72,191,240,48,34,63,97,208,107,54,194,185,224,32,113,150,32,207,28,112,151,154,107,214,82,126,153,115,198,216,69,189,46,242,42,248,41,239,72,64,24,240,3,100,84,19,90,176,190,172,88,61,181,231,22,18,183,56,112,71,198,127,43,240,18,174,69,162,36,194,55,70,207,159,90,237,23,153,91,130,222,25,66,13,57,215,151,207,78,218,107,251,181,74,43,4,185,185,33,222,198,226,33,151,239,213,240,124,78,212,28,210,43,86,38,107,20,182,93,204,219,248,189,83,202,253,254,225,111,181,203,45,65,157,91,113,149,183,30,219,127,245,234,178,95,135,243,213,193,175,135,62,230,134,247,87,38,6,164,92,44,53,103,185,15,5,255,163,98,208,122,98,85,77,191,129,53,55,8,18,244,249,32,134,197,147,67,220,104,149,128,49,158,96,224,26,173,21,101,206,148,65,201,226,129,41,194,189,69,84,210,116,30,162,187,233,48,8,3,13,104,181,244,243,76,126,1,188,200,120,3,55,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess10EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess10 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("6a42b9c9-b007-4dff-9804-8c9ce63c5965"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3604ffd2-6213-4e06-bb7b-c503155d1b9c"),
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				Name = @"EventSubProcess10",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(399, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess10;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage4StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("59e4c487-ebaa-443a-8ef2-5eb1b50ee91b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6a42b9c9-b007-4dff-9804-8c9ce63c5965"),
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DeleteYesMessage",
				ModifiedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				Name = @"StartMessage4",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask4ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d5f2e457-d945-4787-b85e-5c981de75d63"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6a42b9c9-b007-4dff-9804-8c9ce63c5965"),
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				Name = @"ScriptTask4",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(232, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,203,47,202,77,204,201,172,74,13,200,47,206,44,201,204,207,43,214,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,114,48,85,35,35,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("e5b9adf2-dd0f-4ce9-a313-f367ec417efd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6a42b9c9-b007-4dff-9804-8c9ce63c5965"),
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"DeleteYesMessage",
				ModifiedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				Name = @"IntermediateThrowMessageEvent2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(127, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess11EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess11 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("15d99c47-bd4c-4b2c-a407-dbb4e6faf254"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("88476481-7eea-49f5-b8e0-5bbeb38972e8"),
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				Name = @"EventSubProcess11",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(232, 3),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(371, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess11;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageInitStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("85b14b04-0681-437c-bfa6-76e40257db29"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("15d99c47-bd4c-4b2c-a407-dbb4e6faf254"),
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				Name = @"StartMessageInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 66),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("00390d6a-0985-4871-9645-4353e942d662"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("15d99c47-bd4c-4b2c-a407-dbb4e6faf254"),
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				Name = @"InitScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 52),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,73,44,73,12,206,47,45,74,78,213,115,205,75,76,202,73,13,78,45,42,75,45,114,76,46,201,44,75,13,202,47,87,176,85,40,41,42,77,181,230,229,42,74,45,41,45,202,131,240,0,204,224,101,21,59,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent3IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("215410a0-20d2-4b8d-9876-51449db53b8f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("15d99c47-bd4c-4b2c-a407-dbb4e6faf254"),
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				Name = @"IntermediateThrowMessageEvent3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(267, 66),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateMoveItemMethod());
			Methods.Add(CreateNormalizePositionsMethod());
			Methods.Add(CreateGetMaxMinPositionMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e166c122-42fa-4f50-991f-89f6d5e40e3c"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "WebControls",
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5869487f-ebcd-414c-9fb2-40b8f070b351"),
				Name = "System.Web",
				Alias = "web",
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("41c60d94-6edf-44e4-9edb-0e16c226d725"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("92dceabc-4c2b-49a1-baa4-e5bdfa59f339"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aa8aa1ac-15e9-42cc-9636-16aa514d5797"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("10a2ccab-756c-4712-b1b8-f4ebab9f54a0"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e450a1d1-32d4-48db-a086-f5426a1a7722"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6f5452a8-39be-4d73-aff7-044da2a7684d"),
				Name = "System.Threading",
				Alias = "",
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0655a6cd-c0cc-42ef-b029-8e7b7f8cbd5b"),
				Name = "Terrasoft.Reports",
				Alias = "",
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e")
			});
		}

		protected override SchemaMethod CreateGetButtonsMethod() {
			SchemaMethod method = base.CreateGetButtonsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,42,45,41,201,207,43,86,176,85,200,75,45,87,8,174,44,46,73,205,213,115,206,207,201,73,77,46,201,4,74,232,185,167,230,165,22,101,38,235,249,100,22,151,216,20,151,20,101,230,165,219,105,104,90,243,114,65,117,234,57,166,164,104,4,36,166,167,130,24,78,96,49,61,191,196,220,84,172,74,92,83,50,75,8,169,113,206,47,168,36,164,198,37,53,39,181,36,149,144,170,0,160,99,9,90,23,90,64,208,178,252,242,60,52,53,69,169,37,165,69,121,176,192,179,6,0,120,209,88,187,73,1,0,0 };
			return method;
		}

		protected override SchemaMethod CreateInitializeDetailEditPageIdMethod() {
			SchemaMethod method = base.CreateInitializeDetailEditPageIdMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,112,77,201,44,9,72,76,79,13,245,76,81,176,181,85,112,47,205,76,209,115,205,45,40,169,212,84,168,230,226,4,113,21,82,161,74,130,147,51,82,115,19,65,234,20,242,82,203,193,74,53,148,82,146,83,146,211,140,44,204,117,19,147,18,83,116,77,12,210,140,116,45,141,77,44,116,147,19,205,45,45,77,19,45,19,13,204,77,149,52,173,185,56,81,44,194,48,211,154,171,22,0,170,171,76,47,142,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateActivateButtonsMethod() {
			SchemaMethod method = base.CreateActivateButtonsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,86,77,111,226,48,16,61,7,169,255,193,229,80,5,105,21,177,215,210,82,241,165,110,165,109,23,149,118,247,108,226,1,172,53,118,100,59,208,104,203,127,223,49,78,104,128,6,186,109,247,130,148,248,205,123,51,227,55,19,22,84,147,113,106,173,146,134,92,146,107,176,93,255,16,54,90,39,181,5,30,50,106,233,72,165,58,134,123,181,52,61,149,74,139,192,33,157,66,212,223,28,69,157,216,242,133,67,12,53,159,83,157,245,148,72,231,242,39,21,41,144,75,228,77,57,139,6,243,196,102,228,249,153,156,82,135,166,22,200,21,105,146,115,242,21,165,198,74,9,66,25,243,242,3,73,199,2,88,55,187,231,211,153,117,153,89,157,66,1,99,32,192,194,91,144,192,184,125,11,46,86,73,118,4,199,177,238,56,213,26,164,29,42,195,45,87,18,15,155,120,178,219,11,79,49,2,189,0,189,233,203,11,145,107,42,146,112,155,141,226,25,204,233,43,221,244,7,78,116,66,194,45,236,233,37,145,169,16,13,242,231,164,22,172,175,103,60,2,76,11,17,3,57,229,18,10,182,71,3,186,167,164,132,216,101,26,245,187,219,48,228,14,140,213,92,78,137,89,51,223,209,185,139,45,139,69,238,157,3,30,238,247,110,6,17,154,232,198,12,74,68,125,23,143,82,29,33,212,18,88,248,162,232,76,22,28,184,245,227,220,157,36,1,201,170,201,15,221,236,199,217,15,249,235,56,251,0,163,171,185,17,126,75,159,110,185,44,236,22,250,130,246,60,24,86,14,227,198,46,24,23,92,85,15,173,75,237,33,75,128,149,198,246,2,13,223,14,235,133,78,125,205,113,78,74,249,96,54,171,147,218,68,105,160,241,44,116,102,140,149,180,26,199,137,75,175,149,239,146,158,127,253,157,102,42,181,81,254,100,94,60,236,247,15,86,82,196,83,67,30,64,107,106,212,196,70,143,55,209,47,24,23,81,155,240,156,220,181,196,77,73,206,145,23,76,206,206,136,183,55,226,231,9,213,240,67,227,53,82,145,227,214,214,254,66,234,142,12,158,236,55,16,137,167,171,55,28,69,211,231,86,34,246,186,148,227,98,44,49,52,114,92,96,150,220,198,51,178,117,150,31,5,49,53,64,234,157,194,228,245,115,255,58,200,177,185,113,176,250,170,57,104,249,128,49,246,249,119,171,204,217,47,205,101,53,109,248,218,6,111,187,26,177,73,7,70,187,82,118,176,49,253,59,69,43,167,166,82,178,183,153,226,119,74,86,174,129,74,201,199,228,67,130,225,238,156,182,203,163,211,168,190,83,181,148,159,43,124,65,112,141,28,18,102,48,161,169,176,228,223,245,246,201,86,238,119,69,64,96,45,222,255,123,108,249,103,208,99,87,235,29,226,230,236,198,244,1,7,76,92,107,206,92,29,35,116,102,108,129,221,41,6,199,254,84,248,89,251,224,38,250,148,85,244,255,118,209,126,35,39,20,187,220,10,130,114,47,255,2,37,115,36,211,207,9,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateMoveItemMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("cbd540ec-535f-465d-be1f-eed19001adb0"),
				Name = "MoveItem",
				CreatedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("3c074ad1-44f9-495f-a66a-cc5af45feb0b"),
				Name = "incrementPosition",
				CreatedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				ModifiedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "int",
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,85,77,111,219,48,12,61,39,191,66,232,73,198,2,33,247,116,5,186,124,97,192,90,164,77,186,29,134,29,4,155,109,4,216,82,34,203,41,130,181,255,125,148,101,59,146,157,118,46,208,147,1,250,145,124,228,123,146,14,92,147,132,27,190,86,133,142,129,124,37,43,254,4,108,214,68,38,195,3,34,242,120,11,25,239,254,101,235,242,135,3,61,10,157,155,185,52,194,28,31,190,39,8,62,213,101,215,177,17,7,184,87,207,43,45,50,174,143,83,149,22,153,252,201,211,162,238,0,177,146,137,159,189,44,68,194,230,217,206,28,29,98,95,128,62,98,92,194,51,113,56,215,252,206,198,169,99,24,57,232,206,111,114,203,51,59,87,153,206,174,147,196,69,171,4,182,4,179,106,163,105,20,49,251,173,138,169,92,24,161,228,187,213,46,86,21,234,194,79,61,45,96,33,82,3,58,15,151,50,45,180,6,105,214,70,23,177,41,52,176,10,197,54,170,51,160,251,133,221,82,136,109,31,90,50,192,121,29,147,58,19,25,209,78,215,106,43,80,214,108,200,227,228,174,11,125,200,109,101,41,93,229,81,75,72,204,22,143,132,214,217,40,64,145,166,17,249,59,28,104,64,214,114,50,124,61,201,95,175,1,187,184,4,219,102,115,220,65,226,41,126,41,164,185,162,221,189,6,60,221,236,55,92,162,227,52,150,11,73,178,121,23,212,222,57,186,109,170,10,105,238,250,25,231,141,196,222,150,121,187,66,111,113,4,132,14,9,203,52,130,121,46,8,183,130,181,102,126,114,94,102,215,90,96,117,86,6,156,160,52,20,236,11,17,50,214,144,33,180,142,69,228,146,140,201,203,11,233,3,189,34,103,90,183,108,18,122,117,154,2,215,180,177,240,61,228,96,214,96,39,115,202,244,54,119,23,229,34,83,13,220,84,184,95,194,108,87,92,163,84,22,68,235,227,148,237,184,22,185,146,214,162,108,190,47,120,58,34,195,193,233,52,143,200,255,71,255,68,6,183,202,52,36,222,117,91,231,144,34,9,207,66,251,254,134,105,206,118,99,15,148,114,92,10,215,189,147,107,224,239,241,159,179,7,219,222,217,120,178,219,124,163,224,142,152,215,247,80,53,161,91,210,217,187,168,226,231,165,177,5,152,120,187,208,42,155,125,163,237,29,88,210,62,118,13,198,99,71,63,38,235,164,85,139,31,192,90,114,112,163,14,144,116,159,49,156,39,164,83,207,236,111,241,35,67,251,121,193,212,45,89,162,142,86,189,231,182,227,132,137,213,144,175,195,242,161,223,104,128,165,198,103,184,57,170,222,235,245,67,241,196,30,116,12,255,3,47,200,67,239,69,8,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateNormalizePositionsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c8c4da8b-6e2d-44c4-bf88-5cbbc5915611"),
				Name = "NormalizePositions",
				CreatedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,83,193,110,219,48,12,61,75,95,161,229,36,163,129,208,237,154,182,64,150,101,65,129,97,205,150,116,59,12,59,8,54,187,10,176,37,143,146,218,25,67,255,125,146,173,164,118,226,228,178,139,13,137,228,227,227,123,212,147,68,102,27,59,47,42,165,239,106,64,233,148,209,43,148,218,1,108,242,71,168,228,23,15,216,176,107,166,225,153,45,181,83,174,233,221,243,181,252,5,226,131,116,114,99,60,230,32,186,88,54,163,79,1,184,70,85,73,76,249,11,83,250,74,127,150,21,4,176,241,50,177,2,183,238,106,94,179,121,2,131,195,222,255,197,169,205,28,80,58,194,23,243,162,232,50,248,137,65,50,17,191,51,122,174,116,178,54,86,69,81,39,153,184,195,2,240,125,51,183,249,110,168,98,207,242,163,42,29,160,29,209,102,225,17,67,135,141,67,159,59,143,32,82,170,216,154,163,217,187,80,104,93,66,30,155,242,35,106,217,24,221,29,98,160,205,143,40,245,245,87,96,71,165,10,198,117,92,122,173,239,109,100,162,117,119,12,40,157,254,73,142,181,68,89,37,11,91,140,246,2,66,195,32,217,219,201,148,93,14,124,191,45,206,22,188,11,5,43,175,10,177,172,106,215,164,74,95,135,89,32,149,220,183,135,3,82,211,83,139,216,186,75,137,216,128,235,57,56,29,178,143,9,223,31,1,225,244,126,220,218,229,111,47,75,62,24,34,99,210,38,62,51,70,40,125,48,200,120,36,172,2,215,203,89,248,93,237,213,22,11,227,181,11,119,23,23,25,251,75,137,122,96,124,23,251,161,126,70,225,183,77,13,105,219,190,201,210,195,149,210,238,166,191,119,236,205,53,83,109,53,25,240,16,109,250,206,207,51,128,81,217,27,62,254,114,130,214,132,12,100,217,195,170,24,234,76,16,203,63,144,123,23,31,51,33,148,188,208,23,74,91,233,183,8,176,194,96,220,162,4,137,241,89,28,58,242,201,200,226,171,121,182,33,246,15,122,20,9,214,173,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetMaxMinPositionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0d57e06e-c993-43c0-bad2-1d4a03c3bb34"),
				Name = "GetMaxMinPosition",
				CreatedInSchemaUId = new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,82,75,79,2,49,16,62,175,137,255,161,238,169,123,105,56,139,104,144,87,56,144,32,160,30,140,135,186,59,66,99,105,181,15,192,8,255,221,182,11,236,46,1,76,60,236,35,51,223,99,250,77,217,59,194,67,58,5,210,166,134,142,165,85,41,144,102,106,216,2,70,114,137,174,26,72,88,206,209,122,141,2,104,162,0,122,138,101,101,180,195,105,210,146,86,24,15,175,37,232,231,242,34,90,80,133,30,44,75,63,192,24,38,166,186,159,161,198,57,163,70,110,148,56,106,116,119,222,235,165,246,74,122,96,38,223,159,144,181,36,183,115,241,68,185,133,155,158,101,217,45,142,131,107,51,203,6,32,236,120,239,30,7,229,107,116,114,130,255,72,214,189,166,63,169,6,14,169,25,74,237,14,233,107,145,128,37,26,135,34,126,212,160,90,82,8,247,207,164,8,99,68,36,55,193,93,43,82,50,160,43,28,59,46,243,253,56,73,72,83,227,216,21,139,210,17,14,19,71,56,76,28,114,186,74,206,171,243,247,13,204,119,221,231,25,40,56,125,60,210,215,157,47,75,57,206,157,201,144,42,58,7,3,10,87,55,155,228,114,84,111,143,236,99,177,218,245,16,246,225,100,111,157,21,164,214,72,229,210,169,166,65,58,66,91,5,237,251,162,132,147,252,2,69,101,9,5,52,3,79,223,7,77,114,77,24,133,14,46,60,246,244,104,57,99,28,112,78,37,30,87,72,71,81,41,95,39,187,5,185,43,80,222,62,19,230,246,96,19,245,29,189,136,250,47,122,121,41,91,250,38,124,252,219,61,27,4,92,67,24,172,58,84,205,163,171,70,190,180,249,5,190,240,23,44,178,3,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new QuickAddMenuItemSubGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("81846264-4aa3-4382-9282-ed748e17d4c1"));
		}

		#endregion

	}

	#endregion

}

