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
	using System.Linq;
	using System.Text;
	using System.Threading;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
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

	#region Class: ChangeLogConfigurationGridPageSchema

	/// <exclude/>
	public class ChangeLogConfigurationGridPageSchema : Terrasoft.WebApp.BaseGridPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.Button _closeButton;
		public Terrasoft.UI.WebControls.Controls.Button CloseButton {
			get {
				return _closeButton;
			}
		}

		#endregion

		#region Constructors: Public

		public ChangeLogConfigurationGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ChangeLogConfigurationGridPageSchema(ChangeLogConfigurationGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("0a2664c6-18b1-489f-b15d-535fd3828546");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.Hidden = true;
			CopyButton.ModifiedInSchemaUId = new Guid("0a2664c6-18b1-489f-b15d-535fd3828546");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("0a2664c6-18b1-489f-b15d-535fd3828546");
		}

		private void UpdateDeleteButton() {
			DeleteButton.AjaxEvents.Click.ShowLoadMask = true;
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("0a2664c6-18b1-489f-b15d-535fd3828546");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("0a2664c6-18b1-489f-b15d-535fd3828546");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("0a2664c6-18b1-489f-b15d-535fd3828546");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("0a2664c6-18b1-489f-b15d-535fd3828546");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("0a2664c6-18b1-489f-b15d-535fd3828546");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("0a2664c6-18b1-489f-b15d-535fd3828546");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("0a2664c6-18b1-489f-b15d-535fd3828546");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("0a2664c6-18b1-489f-b15d-535fd3828546");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("0a2664c6-18b1-489f-b15d-535fd3828546");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0a2664c6-18b1-489f-b15d-535fd3828546");
			RealUId = new Guid("0a2664c6-18b1-489f-b15d-535fd3828546");
			Name = "ChangeLogConfigurationGridPage";
			ParentSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Width = 650;
			Height = 400;
			HelpContextId = "509";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateChangeLogConfigurationGridPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateTreeGrid();
			UpdateShowChangelogMenuItem();
			UpdateCallMenuItem();
			UpdateSendTemplateEmailMenuItem();
			UpdateSendEmailMenuItem();
			UpdateButtonsControlLayout();
			UpdateActionButton();
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
			ButtonsControlLayout.MoveItem(4, SpacerPrintButton);
			ButtonsControlLayout.InsertItem(5, CreateCloseButton());
			ButtonsControlLayout.MoveItem(6, PrintButton);
			ButtonsControlLayout.MoveItem(7, ContextHelpButton);
			ButtonsControlLayout.MoveItem(8, ActionButton);
			TopLevelControl.MoveItem(1, TreeGrid);
			TreeGrid.MoveItem(0, SendEmailMenuItem);
			TreeGrid.MoveItem(1, SendTemplateEmailMenuItem);
			TreeGrid.MoveItem(2, CallMenuItem);
			TreeGrid.MoveItem(3, ShowChangelogMenuItem);
			TopLevelControl.MoveItem(2, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateChangeLogConfigurationGridPageEventsProcessSchema() {
			var schema = new ChangeLogConfigurationGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateCloseButton() {
			_closeButton = new Terrasoft.UI.WebControls.Controls.Button();
			_closeButton.UId = new Guid("7815f9d8-fbb3-4094-ae32-0ae30cbea558");
			_closeButton.Name = "CloseButton";
			_closeButton.CreatedInSchemaUId = new Guid("0a2664c6-18b1-489f-b15d-535fd3828546");
			_closeButton.ModifiedInSchemaUId = new Guid("0a2664c6-18b1-489f-b15d-535fd3828546");
			_closeButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_closeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_closeButton.Tag = "";
			_closeButton.Image = new ControlImage {};
			return _closeButton;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("4adfed7d-3076-4f2a-9ec0-f3c01da99db4");
			DataSource.ModifiedInSchemaUId = new Guid("0a2664c6-18b1-489f-b15d-535fd3828546");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("cdff2413-25e8-4a72-a4e5-6ca6a3d764e5");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("0a2664c6-18b1-489f-b15d-535fd3828546");
				column.ModifiedInSchemaUId = new Guid("0a2664c6-18b1-489f-b15d-535fd3828546");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("986388a5-7f8b-4aaf-aff8-4e6cb86dfccb");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("0a2664c6-18b1-489f-b15d-535fd3828546");
				column.ModifiedInSchemaUId = new Guid("0a2664c6-18b1-489f-b15d-535fd3828546");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("691275d3-250f-4a81-9c1e-4f94506b6a7d");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("0a2664c6-18b1-489f-b15d-535fd3828546");
				column.ModifiedInSchemaUId = new Guid("0a2664c6-18b1-489f-b15d-535fd3828546");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("a34d953d-f27a-4407-be33-b98666140aa1");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("0a2664c6-18b1-489f-b15d-535fd3828546");
				column.ModifiedInSchemaUId = new Guid("0a2664c6-18b1-489f-b15d-535fd3828546");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("3575787b-4dd0-4d0e-b76d-2dad979a9da9");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("0a2664c6-18b1-489f-b15d-535fd3828546");
				column.ModifiedInSchemaUId = new Guid("0a2664c6-18b1-489f-b15d-535fd3828546");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e977d7d1-6a05-4f31-954d-cc4147716f87");
			if (column != null) {
				column.UId = new Guid("5a2f72d7-4833-4a0c-9192-6b78202b1c44");
				column.Name = @"Caption";
				column.CreatedInSchemaUId = new Guid("0a2664c6-18b1-489f-b15d-535fd3828546");
				column.ModifiedInSchemaUId = new Guid("0a2664c6-18b1-489f-b15d-535fd3828546");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("5a3b9252-9837-4623-9cd8-e5fc643cdd46");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("0a2664c6-18b1-489f-b15d-535fd3828546");
				column.ModifiedInSchemaUId = new Guid("0a2664c6-18b1-489f-b15d-535fd3828546");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ff3565e6-4608-4766-a7f3-3ad5b79dc252");
			if (column != null) {
				column.UId = new Guid("b419d6cf-ccbd-4ef5-b5a7-4fe3c2ef6851");
				column.Name = @"SysWorkspace";
				column.CreatedInSchemaUId = new Guid("0a2664c6-18b1-489f-b15d-535fd3828546");
				column.ModifiedInSchemaUId = new Guid("0a2664c6-18b1-489f-b15d-535fd3828546");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("f6ec002d-6240-4984-a452-7f364518c703");
			if (column != null) {
				column.UId = new Guid("7ad9d2ed-7702-4d70-92d1-74d9268f3c27");
				column.Name = @"UId";
				column.CreatedInSchemaUId = new Guid("0a2664c6-18b1-489f-b15d-535fd3828546");
				column.ModifiedInSchemaUId = new Guid("0a2664c6-18b1-489f-b15d-535fd3828546");
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
			return new ChangeLogConfigurationGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new ChangeLogConfigurationGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0a2664c6-18b1-489f-b15d-535fd3828546"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ChangeLogConfigurationGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ChangeLogConfigurationGridPageEventsProcess

	/// <exclude/>
	public class ChangeLogConfigurationGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.ChangeLogConfigurationGridPageSchemaUserControl
	{

		public ChangeLogConfigurationGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ChangeLogConfigurationGridPageEventsProcess";
			SchemaUId = new Guid("0a2664c6-18b1-489f-b15d-535fd3828546");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("0a2664c6-18b1-489f-b15d-535fd3828546");
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

		private ProcessFlowElement _eventSubProcess1;
		public ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("303f9f23-0a3f-4740-8668-33c6a1b4cfe0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _closeButtonClickStartMessage;
		public ProcessFlowElement CloseButtonClickStartMessage {
			get {
				return _closeButtonClickStartMessage ?? (_closeButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CloseButtonClickStartMessage",
					SchemaElementUId = new Guid("8fe7374f-b7a5-416d-a8e2-608b9ac44af1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _closeButtonClickScriptTask;
		public ProcessScriptTask CloseButtonClickScriptTask {
			get {
				return _closeButtonClickScriptTask ?? (_closeButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CloseButtonClickScriptTask",
					SchemaElementUId = new Guid("000da69f-ca36-4f3e-89ef-0911f44b85ca"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CloseButtonClickScriptTaskExecute,
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
					SchemaElementUId = new Guid("729ac983-af44-472e-b857-29ed2eaa4e99"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _deleteStartMessage1;
		public ProcessFlowElement DeleteStartMessage1 {
			get {
				return _deleteStartMessage1 ?? (_deleteStartMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DeleteStartMessage1",
					SchemaElementUId = new Guid("b29eb401-1044-449f-91e0-0743102153d2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _deleteButtonClickIntermediateThrowMessageEvent2;
		public ProcessThrowMessageEvent DeleteButtonClickIntermediateThrowMessageEvent2 {
			get {
				return _deleteButtonClickIntermediateThrowMessageEvent2 ?? (_deleteButtonClickIntermediateThrowMessageEvent2 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "DeleteButtonClickIntermediateThrowMessageEvent2",
					SchemaElementUId = new Guid("adfe9187-7da8-4fe4-bd00-d18bff586c3e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "DeleteButtonClick",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("856d2a02-5ed9-4974-8adb-1370b34dd1d8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess12;
		public ProcessFlowElement EventSubProcess12 {
			get {
				return _eventSubProcess12 ?? (_eventSubProcess12 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess12",
					SchemaElementUId = new Guid("2cd92c81-4753-4c10-b7f7-faf0b0fa6cf2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _deleteButtonClickScriptTask;
		public ProcessScriptTask DeleteButtonClickScriptTask {
			get {
				return _deleteButtonClickScriptTask ?? (_deleteButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DeleteButtonClickScriptTask",
					SchemaElementUId = new Guid("2230ea93-2a78-4d4b-91dd-d6c46b4b2267"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DeleteButtonClickScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _deleteYesMessageStartMessage;
		public ProcessFlowElement DeleteYesMessageStartMessage {
			get {
				return _deleteYesMessageStartMessage ?? (_deleteYesMessageStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DeleteYesMessageStartMessage",
					SchemaElementUId = new Guid("8b05740d-4860-46d5-9555-792d2271d14b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("03dbb9af-343f-4b87-b3f1-cec475895834"),
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
					SchemaElementUId = new Guid("0f6e1337-7a1e-431f-b587-6a92dcbb792c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _pageLoadCompleteScriptTask;
		public ProcessScriptTask PageLoadCompleteScriptTask {
			get {
				return _pageLoadCompleteScriptTask ?? (_pageLoadCompleteScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PageLoadCompleteScriptTask",
					SchemaElementUId = new Guid("8e115343-94a6-4f30-8fa0-2eb0e87fccff"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteScriptTaskExecute,
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
					SchemaElementUId = new Guid("28278dcf-57fb-4f60-8b70-45da69a436d9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("5a27c8ab-0b44-458b-a7a3-b7aad067edcd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _basePrepareFiltersStartMessage;
		public ProcessFlowElement BasePrepareFiltersStartMessage {
			get {
				return _basePrepareFiltersStartMessage ?? (_basePrepareFiltersStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BasePrepareFiltersStartMessage",
					SchemaElementUId = new Guid("da52f95e-2bad-46a5-87c5-5d873feee383"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _basePrepareFiltersScriptTask;
		public ProcessScriptTask BasePrepareFiltersScriptTask {
			get {
				return _basePrepareFiltersScriptTask ?? (_basePrepareFiltersScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BasePrepareFiltersScriptTask",
					SchemaElementUId = new Guid("9ed6ff07-9a68-4169-8069-a3cc0ae2bb44"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = BasePrepareFiltersScriptTaskExecute,
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
					SchemaElementUId = new Guid("0c5da7e4-2874-48c5-acce-d144494dd503"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _refreshDataStartMessage;
		public ProcessFlowElement RefreshDataStartMessage {
			get {
				return _refreshDataStartMessage ?? (_refreshDataStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "RefreshDataStartMessage",
					SchemaElementUId = new Guid("ce3e2484-7f12-492b-8427-da02cbacaf94"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _refreshDataScriptTask;
		public ProcessScriptTask RefreshDataScriptTask {
			get {
				return _refreshDataScriptTask ?? (_refreshDataScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "RefreshDataScriptTask",
					SchemaElementUId = new Guid("9f37b6e6-4a76-4f24-94a3-815c5ad5d55c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = RefreshDataScriptTaskExecute,
				});
			}
		}

		private LocalizableString _cantSetEntitySchemaIsNotTrackMessage;
		public LocalizableString CantSetEntitySchemaIsNotTrackMessage {
			get {
				return _cantSetEntitySchemaIsNotTrackMessage ?? (_cantSetEntitySchemaIsNotTrackMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.CantSetEntitySchemaIsNotTrackMessage.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[CloseButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { CloseButtonClickStartMessage };
			FlowElements[CloseButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CloseButtonClickScriptTask };
			FlowElements[EventSubProcess11.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess11 };
			FlowElements[DeleteStartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteStartMessage1 };
			FlowElements[DeleteButtonClickIntermediateThrowMessageEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteButtonClickIntermediateThrowMessageEvent2 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[EventSubProcess12.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess12 };
			FlowElements[DeleteButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteButtonClickScriptTask };
			FlowElements[DeleteYesMessageStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteYesMessageStartMessage };
			FlowElements[EventSubProcess8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8 };
			FlowElements[StartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2 };
			FlowElements[PageLoadCompleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScriptTask };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[EventSubProcess9.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess9 };
			FlowElements[BasePrepareFiltersStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BasePrepareFiltersStartMessage };
			FlowElements[BasePrepareFiltersScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { BasePrepareFiltersScriptTask };
			FlowElements[EventSubProcess10.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess10 };
			FlowElements[RefreshDataStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { RefreshDataStartMessage };
			FlowElements[RefreshDataScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { RefreshDataScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "CloseButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("CloseButtonClickScriptTask");
						break;
					case "CloseButtonClickScriptTask":
						break;
					case "EventSubProcess11":
						break;
					case "DeleteStartMessage1":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "DeleteButtonClickIntermediateThrowMessageEvent2":
						break;
					case "ScriptTask1":
						e.Context.QueueTasks.Enqueue("DeleteButtonClickIntermediateThrowMessageEvent2");
						break;
					case "EventSubProcess12":
						break;
					case "DeleteButtonClickScriptTask":
						break;
					case "DeleteYesMessageStartMessage":
						e.Context.QueueTasks.Enqueue("DeleteButtonClickScriptTask");
						break;
					case "EventSubProcess8":
						break;
					case "StartMessage2":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteScriptTask");
						break;
					case "PageLoadCompleteScriptTask":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "IntermediateThrowMessageEvent1":
						break;
					case "EventSubProcess9":
						break;
					case "BasePrepareFiltersStartMessage":
						e.Context.QueueTasks.Enqueue("BasePrepareFiltersScriptTask");
						break;
					case "BasePrepareFiltersScriptTask":
						break;
					case "EventSubProcess10":
						break;
					case "RefreshDataStartMessage":
						e.Context.QueueTasks.Enqueue("RefreshDataScriptTask");
						break;
					case "RefreshDataScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("CloseButtonClickStartMessage");
			ActivatedEventElements.Add("DeleteStartMessage1");
			ActivatedEventElements.Add("DeleteYesMessageStartMessage");
			ActivatedEventElements.Add("StartMessage2");
			ActivatedEventElements.Add("BasePrepareFiltersStartMessage");
			ActivatedEventElements.Add("RefreshDataStartMessage");
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
				case "CloseButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "CloseButtonClickStartMessage";
					result = CloseButtonClickStartMessage.Execute(context);
					break;
				case "CloseButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CloseButtonClickScriptTask";
					result = CloseButtonClickScriptTask.Execute(context, CloseButtonClickScriptTaskExecute);
					break;
				case "EventSubProcess11":
					context.QueueTasks.Dequeue();
					break;
				case "DeleteStartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteStartMessage1";
					result = DeleteStartMessage1.Execute(context);
					break;
				case "DeleteButtonClickIntermediateThrowMessageEvent2":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "DeleteButtonClick");
					result = DeleteButtonClickIntermediateThrowMessageEvent2.Execute(context);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
					break;
				case "EventSubProcess12":
					context.QueueTasks.Dequeue();
					break;
				case "DeleteButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteButtonClickScriptTask";
					result = DeleteButtonClickScriptTask.Execute(context, DeleteButtonClickScriptTaskExecute);
					break;
				case "DeleteYesMessageStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteYesMessageStartMessage";
					result = DeleteYesMessageStartMessage.Execute(context);
					break;
				case "EventSubProcess8":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage2";
					result = StartMessage2.Execute(context);
					break;
				case "PageLoadCompleteScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteScriptTask";
					result = PageLoadCompleteScriptTask.Execute(context, PageLoadCompleteScriptTaskExecute);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "EventSubProcess9":
					context.QueueTasks.Dequeue();
					break;
				case "BasePrepareFiltersStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BasePrepareFiltersStartMessage";
					result = BasePrepareFiltersStartMessage.Execute(context);
					break;
				case "BasePrepareFiltersScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "BasePrepareFiltersScriptTask";
					result = BasePrepareFiltersScriptTask.Execute(context, BasePrepareFiltersScriptTaskExecute);
					break;
				case "EventSubProcess10":
					context.QueueTasks.Dequeue();
					break;
				case "RefreshDataStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "RefreshDataStartMessage";
					result = RefreshDataStartMessage.Execute(context);
					break;
				case "RefreshDataScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "RefreshDataScriptTask";
					result = RefreshDataScriptTask.Execute(context, RefreshDataScriptTaskExecute);
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

		public virtual bool CloseButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Close();
			return true;
		}

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			//Page.AddScript("window.opener.location = location");
			return true;
		}

		public virtual bool DeleteButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			var entitySchemaId = Page.DataSource.ActiveRowPrimaryColumnValue;
			if (entitySchemaId == Guid.Empty)
				return false;
			var entitySchemaUId = Terrasoft.Core.Packages.WorkspaceUtilities.GetSchemaUIdById(entitySchemaId, UserConnection);
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var originalSchema = entitySchemaManager.FindItemByUId(entitySchemaUId);
			var designSchema = entitySchemaManager.DesignItem(UserConnection, originalSchema.RealUId);
			var schema = designSchema.Instance as EntitySchema;
			schema.IsTrackChangesInDB = false;
			entitySchemaManager.SaveDesignedItemInSessionData(UserConnection, schema as MetaSchema, schema.UId);
			Terrasoft.Configuration.CommonUtilities.CompileEntitySchema(UserConnection, schema, false);
			Page.AddScript("window.opener.location = window.opener.location");
			Page.TreeGrid.Clear();
			Page.DataSource.LoadRows();
			return true;
		}

		public virtual bool PageLoadCompleteScriptTaskExecute(ProcessExecutingContext context) {
			if (!UserConnection.DBSecurityEngine.GetCanExecuteOperation("CanViewConfiguration")) {
				UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageChangeLog");
			}
			Page.DeleteButton.AjaxEvents.Click.Timeout = 600000;
			Page.DataSource.LoadRows();
			EditPageUId = new Guid("D037E0E3-16ED-4FA4-86BB-5FE0DAC46AD7");
			return true;
		}

		public virtual bool BasePrepareFiltersScriptTaskExecute(ProcessExecutingContext context) {
			var dataSource = Page.DataSource;
			var structure = dataSource.CurrentStructure;
			var filters = structure.CreateFiltersGroup("WorkspaceGroup", LogicalOperationStrict.And);
			filters.Add(structure.CreateFilterWithParameters(dataSource.Schema, 
				Terrasoft.Core.Entities.FilterComparisonType.Equal, "SysWorkspace.Id", 
				UserConnection.Workspace.Id));
			structure.Filters.Add(filters);
			return true;
		}

		public virtual bool RefreshDataScriptTaskExecute(ProcessExecutingContext context) {
			Page.DataSource.LoadRows();
			return true;
		}

		public override bool GetIsContextHelpButtonHidden() {
			return false;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "CloseButtonClick":
							if (ActivatedEventElements.Contains("CloseButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("CloseButtonClickStartMessage");
						}
						break;
					case "DeleteButtonClick":
							if (ActivatedEventElements.Contains("DeleteStartMessage1")) {
							context.QueueTasks.Enqueue("DeleteStartMessage1");
							ProcessQueue(context);
							return;
						}
						break;
					case "DeleteYesMessage":
							if (ActivatedEventElements.Contains("DeleteYesMessageStartMessage")) {
							context.QueueTasks.Enqueue("DeleteYesMessageStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("StartMessage2")) {
							context.QueueTasks.Enqueue("StartMessage2");
							ProcessQueue(context);
							return;
						}
						break;
					case "BasePrepareFilters":
							if (ActivatedEventElements.Contains("BasePrepareFiltersStartMessage")) {
							context.QueueTasks.Enqueue("BasePrepareFiltersStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "RefreshData":
							if (ActivatedEventElements.Contains("RefreshDataStartMessage")) {
							context.QueueTasks.Enqueue("RefreshDataStartMessage");
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

	#region Class: ChangeLogConfigurationGridPageEventsProcess

	/// <exclude/>
	public class ChangeLogConfigurationGridPageEventsProcess : ChangeLogConfigurationGridPageEventsProcess<Terrasoft.WebApp.ChangeLogConfigurationGridPageSchemaUserControl>
	{

		public ChangeLogConfigurationGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ChangeLogConfigurationGridPageSchemaUserControl

	/// <exclude/>
	public partial class ChangeLogConfigurationGridPageSchemaUserControl : Terrasoft.WebApp.BaseGridPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.Button CloseButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("CloseButton", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			CloseButton.AjaxEvents.Click.Event += CloseButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			CloseButton.AjaxEvents.Click.Event -= CloseButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (ChangeLogConfigurationGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ChangeLogConfigurationGridPageEventsProcess(UserConnection);
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

		public virtual void CloseButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("CloseButtonClick");
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
			SchemaName = "ChangeLogConfigurationGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: ChangeLogConfigurationGridPageEventsProcessSchema

	/// <exclude/>
	public class ChangeLogConfigurationGridPageEventsProcessSchema : Terrasoft.WebApp.BaseGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public ChangeLogConfigurationGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ChangeLogConfigurationGridPageEventsProcessSchema(ChangeLogConfigurationGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ChangeLogConfigurationGridPageEventsProcess";
			UId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet469 = CreateLaneSet469LaneSet();
			LaneSets.Add(schemaLaneSet469);
			ProcessSchemaLane schemaButtonsLane1506 = CreateButtonsLane1506Lane();
			schemaLaneSet469.Lanes.Add(schemaButtonsLane1506);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess11 = CreateEventSubProcess11EventSubProcess();
			FlowElements.Add(eventsubprocess11);
			ProcessSchemaEventSubProcess eventsubprocess12 = CreateEventSubProcess12EventSubProcess();
			FlowElements.Add(eventsubprocess12);
			ProcessSchemaEventSubProcess eventsubprocess8 = CreateEventSubProcess8EventSubProcess();
			FlowElements.Add(eventsubprocess8);
			ProcessSchemaEventSubProcess eventsubprocess9 = CreateEventSubProcess9EventSubProcess();
			FlowElements.Add(eventsubprocess9);
			ProcessSchemaEventSubProcess eventsubprocess10 = CreateEventSubProcess10EventSubProcess();
			FlowElements.Add(eventsubprocess10);
			ProcessSchemaStartMessageEvent closebuttonclickstartmessage = CreateCloseButtonClickStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(closebuttonclickstartmessage);
			ProcessSchemaScriptTask closebuttonclickscripttask = CreateCloseButtonClickScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(closebuttonclickscripttask);
			ProcessSchemaStartMessageEvent deletestartmessage1 = CreateDeleteStartMessage1StartMessageEvent();
			eventsubprocess11.FlowElements.Add(deletestartmessage1);
			ProcessSchemaIntermediateThrowMessageEvent deletebuttonclickintermediatethrowmessageevent2 = CreateDeleteButtonClickIntermediateThrowMessageEvent2IntermediateThrowMessageEvent();
			eventsubprocess11.FlowElements.Add(deletebuttonclickintermediatethrowmessageevent2);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			eventsubprocess11.FlowElements.Add(scripttask1);
			ProcessSchemaScriptTask deletebuttonclickscripttask = CreateDeleteButtonClickScriptTaskScriptTask();
			eventsubprocess12.FlowElements.Add(deletebuttonclickscripttask);
			ProcessSchemaStartMessageEvent deleteyesmessagestartmessage = CreateDeleteYesMessageStartMessageStartMessageEvent();
			eventsubprocess12.FlowElements.Add(deleteyesmessagestartmessage);
			ProcessSchemaStartMessageEvent startmessage2 = CreateStartMessage2StartMessageEvent();
			eventsubprocess8.FlowElements.Add(startmessage2);
			ProcessSchemaScriptTask pageloadcompletescripttask = CreatePageLoadCompleteScriptTaskScriptTask();
			eventsubprocess8.FlowElements.Add(pageloadcompletescripttask);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess8.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaStartMessageEvent basepreparefiltersstartmessage = CreateBasePrepareFiltersStartMessageStartMessageEvent();
			eventsubprocess9.FlowElements.Add(basepreparefiltersstartmessage);
			ProcessSchemaScriptTask basepreparefiltersscripttask = CreateBasePrepareFiltersScriptTaskScriptTask();
			eventsubprocess9.FlowElements.Add(basepreparefiltersscripttask);
			ProcessSchemaStartMessageEvent refreshdatastartmessage = CreateRefreshDataStartMessageStartMessageEvent();
			eventsubprocess10.FlowElements.Add(refreshdatastartmessage);
			ProcessSchemaScriptTask refreshdatascripttask = CreateRefreshDataScriptTaskScriptTask();
			eventsubprocess10.FlowElements.Add(refreshdatascripttask);
			FlowElements.Add(CreateSequenceFlow8820SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8821SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8822SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8823SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8824SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateCantSetEntitySchemaIsNotTrackMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateCantSetEntitySchemaIsNotTrackMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2daf199d-14fc-44b3-8e3e-28d493e28685"),
				Name = "CantSetEntitySchemaIsNotTrackMessage",
				CreatedInPackageId = new Guid("8bf8ae5e-52c9-44c1-a099-364797b55805"),
				CreatedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				ModifiedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8820SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8820",
				UId = new Guid("1c4f02e1-085f-49aa-97bb-c7e8d98843b1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8fe7374f-b7a5-416d-a8e2-608b9ac44af1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("000da69f-ca36-4f3e-89ef-0911f44b85ca"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8821SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8821",
				UId = new Guid("031e66e5-d533-4bef-ae49-2fd2b7aa9a8b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				CurveCenterPosition = new Point(346, 265),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8e115343-94a6-4f30-8fa0-2eb0e87fccff"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("28278dcf-57fb-4f60-8b70-45da69a436d9"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8822SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8822",
				UId = new Guid("b3c7a456-dc04-4a2b-82f7-55fe69e0ee3c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				CurveCenterPosition = new Point(181, 265),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0f6e1337-7a1e-431f-b587-6a92dcbb792c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8e115343-94a6-4f30-8fa0-2eb0e87fccff"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8823SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8823",
				UId = new Guid("38334086-3440-4154-a2d7-b8d40454cf6a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				CurveCenterPosition = new Point(178, 442),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("da52f95e-2bad-46a5-87c5-5d873feee383"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9ed6ff07-9a68-4169-8069-a3cc0ae2bb44"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8824SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8824",
				UId = new Guid("8a51815d-c9d0-447d-adde-e65fb54ab445"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				CurveCenterPosition = new Point(184, 618),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ce3e2484-7f12-492b-8427-da02cbacaf94"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9f37b6e6-4a76-4f24-94a3-815c5ad5d55c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("b1848a9e-f9d3-4083-b643-1f569dc0d7b7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				CurveCenterPosition = new Point(185, 404),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8b05740d-4860-46d5-9555-792d2271d14b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2230ea93-2a78-4d4b-91dd-d6c46b4b2267"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("79579092-f641-4d29-b6bd-944a6cbd7c93"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				CurveCenterPosition = new Point(162, 232),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b29eb401-1044-449f-91e0-0743102153d2"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("856d2a02-5ed9-4974-8adb-1370b34dd1d8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("cd5a2d40-c8d9-4637-a1e6-b6e05a988838"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				CurveCenterPosition = new Point(266, 239),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("856d2a02-5ed9-4974-8adb-1370b34dd1d8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("adfe9187-7da8-4fe4-bd00-d18bff586c3e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet469LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet469 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("628538d5-6e48-4af9-9cb2-47ea3851250b"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				Name = @"LaneSet469",
				Position = new Point(5, 5),
				Size = new Size(709, 492),
				UseBackgroundMode = false
			};
			return schemaLaneSet469;
		}

		protected virtual ProcessSchemaLane CreateButtonsLane1506Lane() {
			ProcessSchemaLane schemaButtonsLane1506 = new ProcessSchemaLane(this) {
				UId = new Guid("c98e9462-204d-499b-be09-c74a424f71bd"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("628538d5-6e48-4af9-9cb2-47ea3851250b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				Name = @"ButtonsLane1506",
				Position = new Point(29, 0),
				Size = new Size(680, 492),
				UseBackgroundMode = false
			};
			return schemaButtonsLane1506;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("303f9f23-0a3f-4740-8668-33c6a1b4cfe0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c98e9462-204d-499b-be09-c74a424f71bd"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				Name = @"EventSubProcess1",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(297, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCloseButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8fe7374f-b7a5-416d-a8e2-608b9ac44af1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("303f9f23-0a3f-4740-8668-33c6a1b4cfe0"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"CloseButtonClick",
				ModifiedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				Name = @"CloseButtonClickStartMessage",
				Position = new Point(36, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCloseButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("000da69f-ca36-4f3e-89ef-0911f44b85ca"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("303f9f23-0a3f-4740-8668-33c6a1b4cfe0"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				Name = @"CloseButtonClickScriptTask",
				Position = new Point(155, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,8,72,76,79,213,115,44,46,0,209,10,137,197,10,33,169,69,69,137,197,249,105,37,122,161,158,122,225,169,73,206,249,121,37,69,249,57,197,122,32,5,154,122,206,57,249,197,169,26,154,214,188,92,69,169,37,165,69,121,10,37,69,165,169,214,0,109,49,24,35,70,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess11EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess11 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("729ac983-af44-472e-b857-29ed2eaa4e99"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c98e9462-204d-499b-be09-c74a424f71bd"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				Name = @"EventSubProcess11",
				Position = new Point(35, 161),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(354, 179),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess11;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDeleteStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b29eb401-1044-449f-91e0-0743102153d2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("729ac983-af44-472e-b857-29ed2eaa4e99"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DeleteButtonClick",
				ModifiedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				Name = @"DeleteStartMessage1",
				Position = new Point(15, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateDeleteButtonClickIntermediateThrowMessageEvent2IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("adfe9187-7da8-4fe4-bd00-d18bff586c3e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("729ac983-af44-472e-b857-29ed2eaa4e99"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"DeleteButtonClick",
				ModifiedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				Name = @"DeleteButtonClickIntermediateThrowMessageEvent2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(232, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("856d2a02-5ed9-4974-8adb-1370b34dd1d8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("729ac983-af44-472e-b857-29ed2eaa4e99"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				Name = @"ScriptTask1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(92, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,215,15,72,76,79,213,115,76,73,9,78,46,202,44,40,209,80,42,207,204,75,201,47,215,203,47,72,205,75,45,210,203,201,79,78,44,201,204,207,83,176,85,128,49,149,52,173,121,185,138,82,75,74,139,242,20,74,138,74,83,173,1,176,157,136,37,68,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess12EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess12 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2cd92c81-4753-4c10-b7f7-faf0b0fa6cf2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c98e9462-204d-499b-be09-c74a424f71bd"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				Name = @"EventSubProcess12",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 322),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(294, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess12;
		}

		protected virtual ProcessSchemaScriptTask CreateDeleteButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2230ea93-2a78-4d4b-91dd-d6c46b4b2267"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2cd92c81-4753-4c10-b7f7-faf0b0fa6cf2"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				Name = @"DeleteButtonClickScriptTask",
				Position = new Point(172, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,147,193,110,194,48,12,134,207,67,226,29,162,157,64,66,121,129,137,3,20,134,42,109,18,162,176,157,173,214,176,104,169,83,57,41,168,111,63,183,20,214,117,221,142,113,236,255,255,28,59,103,96,133,20,76,168,146,244,3,115,136,51,53,87,91,56,161,94,65,128,196,149,156,162,94,164,193,156,113,231,46,91,54,57,112,21,57,91,230,244,6,182,196,167,241,200,28,213,164,47,49,87,155,210,100,122,157,23,161,154,142,71,15,140,161,100,82,71,176,190,46,57,247,92,15,141,237,30,153,193,187,99,208,145,99,212,91,72,63,5,196,235,119,199,159,190,128,20,15,193,88,19,140,132,54,24,238,149,203,42,206,122,0,51,117,240,200,145,35,66,65,119,52,29,240,124,5,18,117,22,223,159,185,122,253,59,169,45,119,108,78,134,192,94,239,164,114,64,79,63,27,202,226,128,249,178,58,244,184,228,124,3,201,208,155,19,253,171,179,106,82,106,165,201,79,192,89,143,67,239,16,108,71,219,223,84,187,38,58,38,31,128,82,84,224,85,183,67,41,242,109,134,223,179,60,121,244,1,36,175,30,211,106,41,26,183,137,13,17,38,112,198,43,37,54,29,199,148,160,247,66,88,175,206,47,232,22,75,236,95,81,54,171,57,221,162,186,197,239,110,0,29,205,169,100,104,70,18,185,60,119,244,61,126,57,23,198,98,183,143,63,252,102,215,14,106,241,102,171,23,89,150,164,108,138,48,121,188,200,160,220,69,187,2,73,154,177,46,109,188,164,231,225,139,199,187,198,158,17,55,44,235,29,89,4,158,220,227,157,31,243,226,32,147,255,226,155,203,118,249,3,203,119,249,2,47,245,173,209,112,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDeleteYesMessageStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8b05740d-4860-46d5-9555-792d2271d14b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2cd92c81-4753-4c10-b7f7-faf0b0fa6cf2"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DeleteYesMessage",
				ModifiedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				Name = @"DeleteYesMessageStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess8EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess8 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("03dbb9af-343f-4b87-b3f1-cec475895834"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c98e9462-204d-499b-be09-c74a424f71bd"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				Name = @"EventSubProcess8",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 511),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(413, 155),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess8;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("0f6e1337-7a1e-431f-b587-6a92dcbb792c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("03dbb9af-343f-4b87-b3f1-cec475895834"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				Name = @"StartMessage2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 66),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8e115343-94a6-4f30-8fa0-2eb0e87fccff"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("03dbb9af-343f-4b87-b3f1-cec475895834"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				Name = @"PageLoadCompleteScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(155, 52),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,142,65,75,195,64,16,133,207,6,242,31,214,156,146,67,150,72,99,42,20,15,201,238,182,8,21,197,90,239,75,50,77,215,214,89,217,204,154,138,248,223,221,40,30,197,185,189,143,247,62,198,236,88,122,190,29,192,9,139,8,45,25,139,92,54,27,104,189,51,244,174,176,55,8,124,5,36,52,170,83,160,4,119,175,224,244,212,75,147,0,159,12,140,97,186,51,189,255,161,73,150,177,143,56,58,251,207,41,246,208,30,254,178,222,106,212,61,136,189,198,30,214,182,79,178,69,28,125,198,209,125,128,92,194,17,8,26,79,20,180,245,179,62,169,55,64,26,184,56,154,246,192,31,205,11,88,79,236,154,85,197,116,139,223,149,38,189,177,222,181,192,215,86,119,15,118,28,210,201,170,58,67,83,97,123,211,133,13,194,200,86,222,116,105,34,139,217,92,21,106,150,95,84,74,230,229,178,46,243,171,170,105,242,203,165,42,100,45,202,170,150,243,239,183,28,144,119,200,200,121,8,233,11,252,41,242,222,79,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("28278dcf-57fb-4f60-8b70-45da69a436d9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("03dbb9af-343f-4b87-b3f1-cec475895834"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(323, 66),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5a27c8ab-0b44-458b-a7a3-b7aad067edcd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c98e9462-204d-499b-be09-c74a424f71bd"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				Name = @"EventSubProcess9",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 686),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(413, 155),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess9;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBasePrepareFiltersStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("da52f95e-2bad-46a5-87c5-5d873feee383"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a27c8ab-0b44-458b-a7a3-b7aad067edcd"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"BasePrepareFilters",
				ModifiedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				Name = @"BasePrepareFiltersStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 73),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateBasePrepareFiltersScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9ed6ff07-9a68-4169-8069-a3cc0ae2bb44"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a27c8ab-0b44-458b-a7a3-b7aad067edcd"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				Name = @"BasePrepareFiltersScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(155, 59),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,143,65,106,195,48,16,69,215,13,228,14,194,43,7,204,92,32,116,17,220,166,20,10,13,56,37,235,65,154,36,162,182,164,142,70,129,220,190,82,226,58,94,116,41,253,167,199,211,5,89,25,20,236,124,98,77,234,89,237,240,68,240,50,221,172,151,139,75,70,162,112,210,146,184,16,15,28,218,196,76,78,186,191,117,164,143,182,23,226,152,217,233,29,180,76,40,180,189,47,111,236,83,168,171,131,231,239,24,80,211,237,92,53,234,195,159,172,198,254,51,16,163,88,239,178,216,106,129,141,51,171,172,30,181,176,49,166,254,95,124,176,114,222,33,227,64,5,172,103,165,157,62,211,128,141,90,46,158,246,196,140,209,31,5,90,159,223,191,58,177,98,41,194,93,209,250,33,32,219,232,221,254,26,242,250,147,176,111,84,213,93,227,84,11,239,166,186,153,190,98,225,157,35,93,98,97,14,172,74,240,35,114,59,75,31,191,81,0,166,188,58,149,49,90,255,2,203,234,14,6,138,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess10EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess10 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("0c5da7e4-2874-48c5-acce-d144494dd503"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c98e9462-204d-499b-be09-c74a424f71bd"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				Name = @"EventSubProcess10",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 861),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(413, 162),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess10;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateRefreshDataStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ce3e2484-7f12-492b-8427-da02cbacaf94"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0c5da7e4-2874-48c5-acce-d144494dd503"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"RefreshData",
				ModifiedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				Name = @"RefreshDataStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 80),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateRefreshDataScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9f37b6e6-4a76-4f24-94a3-815c5ad5d55c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0c5da7e4-2874-48c5-acce-d144494dd503"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"),
				Name = @"RefreshDataScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(155, 66),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,73,44,73,12,206,47,45,74,78,213,243,201,79,76,9,202,47,47,214,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,44,223,188,204,40,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9d7efbbf-8549-484c-9592-82bf90843f5d"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("95c66740-e509-4ca4-b1ef-c7a6bb406ec0"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "WebControls",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7c7fbab2-546c-4dd3-ba02-c8f1ddbc356d"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5869487f-ebcd-414c-9fb2-40b8f070b351"),
				Name = "System.Web",
				Alias = "web",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("41c60d94-6edf-44e4-9edb-0e16c226d725"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("92dceabc-4c2b-49a1-baa4-e5bdfa59f339"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aa8aa1ac-15e9-42cc-9636-16aa514d5797"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("10a2ccab-756c-4712-b1b8-f4ebab9f54a0"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e450a1d1-32d4-48db-a086-f5426a1a7722"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6f5452a8-39be-4d73-aff7-044da2a7684d"),
				Name = "System.Threading",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0655a6cd-c0cc-42ef-b029-8e7b7f8cbd5b"),
				Name = "Terrasoft.Reports",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected override SchemaMethod CreateGetIsContextHelpButtonHiddenMethod() {
			SchemaMethod method = base.CreateGetIsContextHelpButtonHiddenMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,75,204,41,78,181,6,0,112,193,6,27,13,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ChangeLogConfigurationGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f5aa7763-da7e-4cb7-88a1-e66a8ef64e1d"));
		}

		#endregion

	}

	#endregion

}

