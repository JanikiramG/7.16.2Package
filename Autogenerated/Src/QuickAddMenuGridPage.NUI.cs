namespace Terrasoft.WebApp
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.ComponentModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Text;
	using System.Threading;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
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

	#region Class: QuickAddMenuGridPageSchema

	/// <exclude/>
	public class QuickAddMenuGridPageSchema : Terrasoft.WebApp.BaseLookupGridPageSchema
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

		public QuickAddMenuGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public QuickAddMenuGridPageSchema(QuickAddMenuGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.ModifiedInSchemaUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
		}

		private void UpdateDownloadTemplateForImportProductsButton() {
			DownloadTemplateForImportProductsButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DownloadTemplateForImportProductsButton.Image = new ControlImage {};
			DownloadTemplateForImportProductsButton.ModifiedInSchemaUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
		}

		private void UpdateImportProductsButton() {
			ImportProductsButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ImportProductsButton.Image = new ControlImage {};
			ImportProductsButton.ModifiedInSchemaUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
			RealUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
			Name = "QuickAddMenuGridPage";
			ParentSchemaUId = new Guid("39f129b6-b225-4949-95a6-820d78cf6294");
			CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateQuickAddMenuGridPageEventsProcessSchema();
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
			UpdateImportProductsButton();
			UpdateDownloadTemplateForImportProductsButton();
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
			ButtonsControlLayout.InsertItem(5, CreateUpButton());
			ButtonsControlLayout.InsertItem(6, CreateDownButton());
			ButtonsControlLayout.MoveItem(7, PrintButton);
			ButtonsControlLayout.MoveItem(8, ContextHelpButton);
			ButtonsControlLayout.MoveItem(9, DownloadTemplateForImportProductsButton);
			ButtonsControlLayout.MoveItem(10, ImportProductsButton);
			ButtonsControlLayout.MoveItem(11, ActionButton);
			TopLevelControl.MoveItem(1, TreeGrid);
			TreeGrid.MoveItem(0, SendEmailMenuItem);
			TreeGrid.MoveItem(1, SendTemplateEmailMenuItem);
			TreeGrid.MoveItem(2, CallMenuItem);
			TreeGrid.MoveItem(3, ShowChangelogMenuItem);
			TopLevelControl.MoveItem(2, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateQuickAddMenuGridPageEventsProcessSchema() {
			var schema = new QuickAddMenuGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateUpButton() {
			_upButton = new Terrasoft.UI.WebControls.Controls.Button();
			_upButton.UId = new Guid("369bfa17-7699-4aa9-915f-ca3c1c99d0d8");
			_upButton.Name = "UpButton";
			_upButton.CreatedInSchemaUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
			_upButton.ModifiedInSchemaUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
			_upButton.CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e");
			_upButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_upButton.Tag = "";
			_upButton.Image = new ControlImage {};
			return _upButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateDownButton() {
			_downButton = new Terrasoft.UI.WebControls.Controls.Button();
			_downButton.UId = new Guid("5f508102-4f57-47ad-8198-3e2c5383ebe7");
			_downButton.Name = "DownButton";
			_downButton.CreatedInSchemaUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
			_downButton.ModifiedInSchemaUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
			_downButton.CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e");
			_downButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_downButton.Tag = "";
			_downButton.Image = new ControlImage {};
			return _downButton;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("4aa8a1e1-77b5-421c-9e74-303810fbc561");
			DataSource.ModifiedInSchemaUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("5afaa777-6df7-4407-83d0-759f33d1b77a");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
				column.ModifiedInSchemaUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("28720826-c112-45b6-b357-4e322fffb809");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
				column.ModifiedInSchemaUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("5f3a98ee-870e-4c3c-b17f-4444630efcb5");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
				column.ModifiedInSchemaUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("fe4f693f-7239-4275-b366-613fec064b5d");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
				column.ModifiedInSchemaUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("63a0afe4-4e58-4278-bde5-fad276062fbe");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
				column.ModifiedInSchemaUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("027b20cd-e708-4a17-9cc3-b2e017765585");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
				column.ModifiedInSchemaUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("8c43e182-f864-47b7-b369-70f0950aa521");
			if (column != null) {
				column.UId = new Guid("e1552130-8f47-4dae-b022-52737e39a59b");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
				column.ModifiedInSchemaUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsSortable = false;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("5f7ab108-e282-4ce1-9191-fa921423b59f");
			if (column != null) {
				column.UId = new Guid("0e6ae85c-493f-4aac-8a73-31858eb23365");
				column.Name = @"SysAdminUnit";
				column.CreatedInSchemaUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
				column.ModifiedInSchemaUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9c5ae550-ef98-471c-b03c-1c2aedb70381");
			if (column != null) {
				column.UId = new Guid("eb8e9df1-253d-41d2-9e64-421f8ea57b7e");
				column.Name = @"Position";
				column.CreatedInSchemaUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
				column.ModifiedInSchemaUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.Required = true;
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new QuickAddMenuGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new QuickAddMenuGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new QuickAddMenuGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: QuickAddMenuGridPageEventsProcess

	/// <exclude/>
	public class QuickAddMenuGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.QuickAddMenuGridPageSchemaUserControl
	{

		public QuickAddMenuGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "QuickAddMenuGridPageEventsProcess";
			SchemaUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
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

		public virtual Guid MovedPrimaryColumnValue {
			get;
			set;
		}

		public virtual int DataSourceRowsCount {
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

		private ProcessFlowElement _eventSubProcess8;
		public ProcessFlowElement EventSubProcess8 {
			get {
				return _eventSubProcess8 ?? (_eventSubProcess8 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess8",
					SchemaElementUId = new Guid("65dcd7ef-8c59-4bd7-ba87-721a6327b3b6"),
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
					SchemaElementUId = new Guid("6b7b8ed8-36ca-4eba-9ccc-4feb69b56fae"),
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
					SchemaElementUId = new Guid("c8cf1793-d050-4706-8faa-0974b6d9ba01"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
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
					SchemaElementUId = new Guid("5f089eba-f195-4afb-8c11-0b9e3d50b899"),
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
					SchemaElementUId = new Guid("39f0953f-61c0-400e-a3a6-6f8821603a82"),
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
					SchemaElementUId = new Guid("a83b84d8-15a4-4e4d-a879-fa667c00b55f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask2Execute,
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
					SchemaElementUId = new Guid("d1995ed2-2be9-4e0e-af83-49471cec03af"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _dataSourceLoadRowsResponseRegistered;
		public ProcessFlowElement DataSourceLoadRowsResponseRegistered {
			get {
				return _dataSourceLoadRowsResponseRegistered ?? (_dataSourceLoadRowsResponseRegistered = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DataSourceLoadRowsResponseRegistered",
					SchemaElementUId = new Guid("267b4378-4112-4f60-b2f3-77d72845306d"),
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
					SchemaElementUId = new Guid("4b4d953e-de02-4fbc-9fc5-7b2e44c14a50"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3Execute,
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
					SchemaElementUId = new Guid("1ad8498f-4439-4599-8db9-9d098a112174"),
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
					SchemaElementUId = new Guid("1738ae79-99d4-498d-ba56-da844e8c9935"),
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
					SchemaElementUId = new Guid("33c42882-33cf-4375-a0a5-143c74e2fdcd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask4Execute,
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
					SchemaElementUId = new Guid("ddc5a3a4-05f3-415e-95c1-214abad2ee12"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "DeleteYesMessage",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess13;
		public ProcessFlowElement EventSubProcess13 {
			get {
				return _eventSubProcess13 ?? (_eventSubProcess13 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess13",
					SchemaElementUId = new Guid("f9734e58-9f7c-4614-bfc4-29586a67f0e3"),
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
					SchemaElementUId = new Guid("7c4f2a7f-f0ab-45ed-b0d8-2e1314ca93a5"),
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
					SchemaElementUId = new Guid("bd607bc7-11bc-4839-987c-4b184ec24a03"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEventInit;
		public ProcessThrowMessageEvent IntermediateThrowMessageEventInit {
			get {
				return _intermediateThrowMessageEventInit ?? (_intermediateThrowMessageEventInit = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEventInit",
					SchemaElementUId = new Guid("0768c1ba-3960-4c4e-9983-c163484a604c"),
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
			FlowElements[EventSubProcess8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8 };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[EventSubProcess9.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess9 };
			FlowElements[StartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2 };
			FlowElements[ScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask2 };
			FlowElements[EventSubProcess11.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess11 };
			FlowElements[DataSourceLoadRowsResponseRegistered.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceLoadRowsResponseRegistered };
			FlowElements[ScriptTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3 };
			FlowElements[EventSubProcess12.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess12 };
			FlowElements[StartMessage3.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3 };
			FlowElements[ScriptTask4.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask4 };
			FlowElements[IntermediateThrowMessageEvent3.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent3 };
			FlowElements[EventSubProcess13.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess13 };
			FlowElements[StartMessageInit.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageInit };
			FlowElements[InitScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InitScriptTask };
			FlowElements[IntermediateThrowMessageEventInit.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEventInit };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess8":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "ScriptTask1":
						break;
					case "EventSubProcess9":
						break;
					case "StartMessage2":
						e.Context.QueueTasks.Enqueue("ScriptTask2");
						break;
					case "ScriptTask2":
						break;
					case "EventSubProcess11":
						break;
					case "DataSourceLoadRowsResponseRegistered":
						e.Context.QueueTasks.Enqueue("ScriptTask3");
						break;
					case "ScriptTask3":
						break;
					case "EventSubProcess12":
						break;
					case "StartMessage3":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent3");
						break;
					case "ScriptTask4":
						break;
					case "IntermediateThrowMessageEvent3":
						e.Context.QueueTasks.Enqueue("ScriptTask4");
						break;
					case "EventSubProcess13":
						break;
					case "StartMessageInit":
						e.Context.QueueTasks.Enqueue("InitScriptTask");
						break;
					case "InitScriptTask":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEventInit");
						break;
					case "IntermediateThrowMessageEventInit":
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
			ActivatedEventElements.Add("DataSourceLoadRowsResponseRegistered");
			ActivatedEventElements.Add("StartMessage3");
			ActivatedEventElements.Add("StartMessageInit");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess8":
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
				case "EventSubProcess9":
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
				case "EventSubProcess11":
					context.QueueTasks.Dequeue();
					break;
				case "DataSourceLoadRowsResponseRegistered":
					context.QueueTasks.Dequeue();
					context.SenderName = "DataSourceLoadRowsResponseRegistered";
					result = DataSourceLoadRowsResponseRegistered.Execute(context);
					break;
				case "ScriptTask3":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3";
					result = ScriptTask3.Execute(context, ScriptTask3Execute);
					break;
				case "EventSubProcess12":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3";
					result = StartMessage3.Execute(context);
					break;
				case "ScriptTask4":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask4";
					result = ScriptTask4.Execute(context, ScriptTask4Execute);
					break;
				case "IntermediateThrowMessageEvent3":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "DeleteYesMessage");
					result = IntermediateThrowMessageEvent3.Execute(context);
					break;
				case "EventSubProcess13":
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
				case "IntermediateThrowMessageEventInit":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = IntermediateThrowMessageEventInit.Execute(context);
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
				case "DataSourceRowsCount":
					DataSourceRowsCount = reader.GetValue<System.Int32>();
				break;
				case "MovedPrimaryColumnValue":
					MovedPrimaryColumnValue = reader.GetValue<System.Guid>();
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
					var selectPos = 
						new Select(UserConnection)
						.Column(Func.Max("Position")).As("MaxPosition")
						.Column(Func.Min("Position")).As("MinPosition")
						.From("QuickAddMenuSettings")
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
							if (ActivatedEventElements.Contains("DataSourceLoadRowsResponseRegistered")) {
							context.QueueTasks.Enqueue("DataSourceLoadRowsResponseRegistered");
							ProcessQueue(context);
							return;
						}
						break;
					case "DeleteYesMessage":
							if (ActivatedEventElements.Contains("StartMessage3")) {
							context.QueueTasks.Enqueue("StartMessage3");
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
			if (!HasMapping("DataSourceRowsCount") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("DataSourceRowsCount", DataSourceRowsCount, 0);
			}
			if (!HasMapping("MovedPrimaryColumnValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("MovedPrimaryColumnValue", MovedPrimaryColumnValue, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: QuickAddMenuGridPageEventsProcess

	/// <exclude/>
	public class QuickAddMenuGridPageEventsProcess : QuickAddMenuGridPageEventsProcess<Terrasoft.WebApp.QuickAddMenuGridPageSchemaUserControl>
	{

		public QuickAddMenuGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: QuickAddMenuGridPageSchemaUserControl

	/// <exclude/>
	public partial class QuickAddMenuGridPageSchemaUserControl : Terrasoft.WebApp.BaseLookupGridPageSchemaUserControl
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
			var process = (QuickAddMenuGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new QuickAddMenuGridPageEventsProcess(UserConnection);
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
			SchemaName = "QuickAddMenuGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: QuickAddMenuGridPageEventsProcessSchema

	/// <exclude/>
	public class QuickAddMenuGridPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public QuickAddMenuGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public QuickAddMenuGridPageEventsProcessSchema(QuickAddMenuGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "QuickAddMenuGridPageEventsProcess";
			UId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b");
			CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateMovedPrimaryColumnValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("56494e2c-aa49-403a-8be8-e6accf11aec6"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				Name = @"MovedPrimaryColumnValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDataSourceRowsCountParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("1fb0fd9b-d171-4823-aac8-af8be055cb72"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				Name = @"DataSourceRowsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMaxPositionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a08f8e5b-a63c-4dd9-ad50-951ba2e376a7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				Name = @"MaxPosition",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMinPositionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a63ed546-1399-4544-96ef-64885db01d33"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				Name = @"MinPosition",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateMovedPrimaryColumnValueParameter());
			Parameters.Add(CreateDataSourceRowsCountParameter());
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
			ProcessSchemaEventSubProcess eventsubprocess8 = CreateEventSubProcess8EventSubProcess();
			FlowElements.Add(eventsubprocess8);
			ProcessSchemaEventSubProcess eventsubprocess9 = CreateEventSubProcess9EventSubProcess();
			FlowElements.Add(eventsubprocess9);
			ProcessSchemaEventSubProcess eventsubprocess11 = CreateEventSubProcess11EventSubProcess();
			FlowElements.Add(eventsubprocess11);
			ProcessSchemaEventSubProcess eventsubprocess12 = CreateEventSubProcess12EventSubProcess();
			FlowElements.Add(eventsubprocess12);
			ProcessSchemaEventSubProcess eventsubprocess13 = CreateEventSubProcess13EventSubProcess();
			FlowElements.Add(eventsubprocess13);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			eventsubprocess8.FlowElements.Add(startmessage1);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			eventsubprocess8.FlowElements.Add(scripttask1);
			ProcessSchemaStartMessageEvent startmessage2 = CreateStartMessage2StartMessageEvent();
			eventsubprocess9.FlowElements.Add(startmessage2);
			ProcessSchemaScriptTask scripttask2 = CreateScriptTask2ScriptTask();
			eventsubprocess9.FlowElements.Add(scripttask2);
			ProcessSchemaStartMessageEvent datasourceloadrowsresponseregistered = CreateDataSourceLoadRowsResponseRegisteredStartMessageEvent();
			eventsubprocess11.FlowElements.Add(datasourceloadrowsresponseregistered);
			ProcessSchemaScriptTask scripttask3 = CreateScriptTask3ScriptTask();
			eventsubprocess11.FlowElements.Add(scripttask3);
			ProcessSchemaStartMessageEvent startmessage3 = CreateStartMessage3StartMessageEvent();
			eventsubprocess12.FlowElements.Add(startmessage3);
			ProcessSchemaScriptTask scripttask4 = CreateScriptTask4ScriptTask();
			eventsubprocess12.FlowElements.Add(scripttask4);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent3 = CreateIntermediateThrowMessageEvent3IntermediateThrowMessageEvent();
			eventsubprocess12.FlowElements.Add(intermediatethrowmessageevent3);
			ProcessSchemaStartMessageEvent startmessageinit = CreateStartMessageInitStartMessageEvent();
			eventsubprocess13.FlowElements.Add(startmessageinit);
			ProcessSchemaScriptTask initscripttask = CreateInitScriptTaskScriptTask();
			eventsubprocess13.FlowElements.Add(initscripttask);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageeventinit = CreateIntermediateThrowMessageEventInitIntermediateThrowMessageEvent();
			eventsubprocess13.FlowElements.Add(intermediatethrowmessageeventinit);
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
			FlowElements.Add(CreateSequenceFlow15SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16SequenceFlow());
			FlowElements.Add(CreateSequenceFlow17SequenceFlow());
			FlowElements.Add(CreateSequenceFlow18SequenceFlow());
			FlowElements.Add(CreateSequenceFlow19SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("57c507ea-f972-47af-ae6d-d1e0891831d8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6b7b8ed8-36ca-4eba-9ccc-4feb69b56fae"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c8cf1793-d050-4706-8faa-0974b6d9ba01"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14",
				UId = new Guid("a78ded48-2c86-409e-b847-8838ee630bcb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("39f0953f-61c0-400e-a3a6-6f8821603a82"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a83b84d8-15a4-4e4d-a879-fa667c00b55f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow15",
				UId = new Guid("12ca4759-f6ac-4133-a54d-12635074d8b1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				CurveCenterPosition = new Point(130, 423),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("267b4378-4112-4f60-b2f3-77d72845306d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4b4d953e-de02-4fbc-9fc5-7b2e44c14a50"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16",
				UId = new Guid("1cf972a3-7e94-4eec-81cf-b4d426c7627e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				CurveCenterPosition = new Point(152, 603),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1738ae79-99d4-498d-ba56-da844e8c9935"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ddc5a3a4-05f3-415e-95c1-214abad2ee12"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow17SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow17",
				UId = new Guid("b28e4999-66d0-4f2e-af27-2a4bd0aba13e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				CurveCenterPosition = new Point(152, 603),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ddc5a3a4-05f3-415e-95c1-214abad2ee12"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("33c42882-33cf-4375-a0a5-143c74e2fdcd"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow18SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow18",
				UId = new Guid("e51683fe-bd67-4d17-9d9c-25627f3279b3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				CurveCenterPosition = new Point(344, 429),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7c4f2a7f-f0ab-45ed-b0d8-2e1314ca93a5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bd607bc7-11bc-4839-987c-4b184ec24a03"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow19SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow19",
				UId = new Guid("98eb2868-fbba-4557-9472-dfd84427b0a9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				CurveCenterPosition = new Point(482, 427),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bd607bc7-11bc-4839-987c-4b184ec24a03"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0768c1ba-3960-4c4e-9983-c163484a604c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("ddbd7e3d-d9a2-4dc8-921a-5675ca9010e0"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(840, 688),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("797be6ef-1a45-49da-b913-b7660abeb4cf"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("ddbd7e3d-d9a2-4dc8-921a-5675ca9010e0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				Name = @"Lane1",
				Position = new Point(29, 164),
				Size = new Size(811, 159),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("c1f0498c-dbeb-41e5-98d2-41a8ee68613e"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("ddbd7e3d-d9a2-4dc8-921a-5675ca9010e0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				Name = @"Lane2",
				Position = new Point(29, 0),
				Size = new Size(811, 159),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaLane CreateLane3Lane() {
			ProcessSchemaLane schemaLane3 = new ProcessSchemaLane(this) {
				UId = new Guid("e4fccc58-1b95-48b8-aa10-7baaf76e66b8"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("ddbd7e3d-d9a2-4dc8-921a-5675ca9010e0"),
				CreatedInOwnerSchemaUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				Name = @"Lane3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 328),
				Size = new Size(811, 180),
				UseBackgroundMode = false
			};
			return schemaLane3;
		}

		protected virtual ProcessSchemaLane CreateLane4Lane() {
			ProcessSchemaLane schemaLane4 = new ProcessSchemaLane(this) {
				UId = new Guid("4c8a86ff-3a86-4da1-9bb9-341072226fd3"),
				ContainerItemIndex = 4,
				ContainerUId = new Guid("ddbd7e3d-d9a2-4dc8-921a-5675ca9010e0"),
				CreatedInOwnerSchemaUId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				Name = @"Lane4",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 513),
				Size = new Size(811, 175),
				UseBackgroundMode = false
			};
			return schemaLane4;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess8EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess8 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("65dcd7ef-8c59-4bd7-ba87-721a6327b3b6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("797be6ef-1a45-49da-b913-b7660abeb4cf"),
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				Name = @"EventSubProcess8",
				Position = new Point(36, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(181, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess8;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6b7b8ed8-36ca-4eba-9ccc-4feb69b56fae"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65dcd7ef-8c59-4bd7-ba87-721a6327b3b6"),
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"UpButtonClick",
				ModifiedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
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
				UId = new Guid("c8cf1793-d050-4706-8faa-0974b6d9ba01"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65dcd7ef-8c59-4bd7-ba87-721a6327b3b6"),
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
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

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5f089eba-f195-4afb-8c11-0b9e3d50b899"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c1f0498c-dbeb-41e5-98d2-41a8ee68613e"),
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				Name = @"EventSubProcess9",
				Position = new Point(36, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(181, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess9;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("39f0953f-61c0-400e-a3a6-6f8821603a82"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5f089eba-f195-4afb-8c11-0b9e3d50b899"),
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DownButtonClick",
				ModifiedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
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
				UId = new Guid("a83b84d8-15a4-4e4d-a879-fa667c00b55f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5f089eba-f195-4afb-8c11-0b9e3d50b899"),
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
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

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess11EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess11 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("d1995ed2-2be9-4e0e-af83-49471cec03af"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e4fccc58-1b95-48b8-aa10-7baaf76e66b8"),
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				Name = @"EventSubProcess11",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(182, 156),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess11;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDataSourceLoadRowsResponseRegisteredStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("267b4378-4112-4f60-b2f3-77d72845306d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d1995ed2-2be9-4e0e-af83-49471cec03af"),
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DataSourceLoadRowsResponseRegistered",
				ModifiedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				Name = @"DataSourceLoadRowsResponseRegistered",
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
				UId = new Guid("4b4d953e-de02-4fbc-9fc5-7b2e44c14a50"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d1995ed2-2be9-4e0e-af83-49471cec03af"),
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				Name = @"ScriptTask3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(77, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,146,77,107,194,64,16,134,207,6,242,31,86,15,69,161,4,239,98,193,26,17,193,22,169,109,47,165,135,37,59,181,11,155,221,178,59,27,43,197,255,94,119,155,196,144,15,41,230,144,195,206,204,59,207,204,59,49,69,186,85,86,39,240,164,246,102,174,172,68,50,37,27,186,131,40,46,67,145,139,69,62,56,9,131,122,112,11,2,18,4,182,66,72,55,154,167,84,31,230,74,216,84,190,82,97,225,84,39,128,234,225,232,84,201,63,200,240,65,101,192,154,105,164,63,37,75,203,89,180,72,191,240,48,34,63,97,208,107,54,194,185,224,32,113,150,32,207,28,112,151,154,107,214,82,126,153,115,198,216,69,189,46,242,42,248,41,239,72,64,24,240,3,100,84,19,90,176,190,172,88,61,181,231,22,18,183,56,112,71,198,127,43,240,18,174,69,162,36,194,55,70,207,159,90,237,23,153,91,130,222,25,66,13,57,215,151,207,78,218,107,251,181,74,43,4,185,185,33,222,198,226,33,151,239,213,240,124,78,212,28,210,43,86,38,107,20,182,93,204,219,248,189,83,202,253,254,225,111,181,203,45,65,157,91,113,149,183,30,219,127,245,234,178,95,135,243,213,193,175,135,62,230,134,247,87,38,6,164,92,44,53,103,185,15,5,255,163,98,208,122,98,85,77,191,129,53,55,8,18,244,249,32,134,197,147,67,220,104,149,128,49,158,96,224,26,173,21,101,206,148,65,201,226,129,41,194,189,69,84,210,116,30,162,187,233,48,8,3,13,104,181,244,243,76,126,1,188,200,120,3,55,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess12EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess12 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1ad8498f-4439-4599-8db9-9d098a112174"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4c8a86ff-3a86-4da1-9bb9-341072226fd3"),
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				Name = @"EventSubProcess12",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(277, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess12;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage3StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("1738ae79-99d4-498d-ba56-da844e8c9935"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1ad8498f-4439-4599-8db9-9d098a112174"),
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DeleteYesMessage",
				ModifiedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				Name = @"StartMessage3",
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
				UId = new Guid("33c42882-33cf-4375-a0a5-143c74e2fdcd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1ad8498f-4439-4599-8db9-9d098a112174"),
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				Name = @"ScriptTask4",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(176, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,203,47,202,77,204,201,172,74,13,200,47,206,44,201,204,207,43,214,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,114,48,85,35,35,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent3IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("ddc5a3a4-05f3-415e-95c1-214abad2ee12"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1ad8498f-4439-4599-8db9-9d098a112174"),
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"DeleteYesMessage",
				ModifiedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				Name = @"IntermediateThrowMessageEvent3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(106, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess13EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess13 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f9734e58-9f7c-4614-bfc4-29586a67f0e3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e4fccc58-1b95-48b8-aa10-7baaf76e66b8"),
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				Name = @"EventSubProcess13",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(231, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(308, 159),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess13;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageInitStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7c4f2a7f-f0ab-45ed-b0d8-2e1314ca93a5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f9734e58-9f7c-4614-bfc4-29586a67f0e3"),
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				Name = @"StartMessageInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 73),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("bd607bc7-11bc-4839-987c-4b184ec24a03"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f9734e58-9f7c-4614-bfc4-29586a67f0e3"),
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				Name = @"InitScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(106, 59),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,73,44,73,12,206,47,45,74,78,213,115,205,75,76,202,73,13,78,45,42,75,45,114,76,46,201,44,75,13,202,47,87,176,85,40,41,42,77,181,230,229,42,74,45,41,45,202,131,240,0,204,224,101,21,59,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEventInitIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("0768c1ba-3960-4c4e-9983-c163484a604c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f9734e58-9f7c-4614-bfc4-29586a67f0e3"),
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				Name = @"IntermediateThrowMessageEventInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(253, 73),
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
				UId = new Guid("2ec18d58-d5ad-4b15-9d7a-8ac963b89dfd"),
				Name = "Terrasoft.Configuration",
				Alias = "",
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
				UId = new Guid("775363c7-62ae-4a8d-b363-4350699b5cf2"),
				Name = "System.IO",
				Alias = "",
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("51e927e4-70cf-41b6-867a-8768292a856e"),
				Name = "System.Data",
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

		protected override SchemaMethod CreateActivateButtonsMethod() {
			SchemaMethod method = base.CreateActivateButtonsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,86,77,111,226,48,16,61,7,169,255,193,229,80,5,105,21,177,215,210,82,241,165,110,165,109,23,149,118,247,108,226,1,172,53,118,100,59,208,104,203,127,223,49,78,104,128,6,186,109,247,130,148,248,205,123,51,227,55,19,22,84,147,113,106,173,146,134,92,146,107,176,93,255,16,54,90,39,181,5,30,50,106,233,72,165,58,134,123,181,52,61,149,74,139,192,33,157,66,212,223,28,69,157,216,242,133,67,12,53,159,83,157,245,148,72,231,242,39,21,41,144,75,228,77,57,139,6,243,196,102,228,249,153,156,82,135,166,22,200,21,105,146,115,242,21,165,198,74,9,66,25,243,242,3,73,199,2,88,55,187,231,211,153,117,153,89,157,66,1,99,32,192,194,91,144,192,184,125,11,46,86,73,118,4,199,177,238,56,213,26,164,29,42,195,45,87,18,15,155,120,178,219,11,79,49,2,189,0,189,233,203,11,145,107,42,146,112,155,141,226,25,204,233,43,221,244,7,78,116,66,194,45,236,233,37,145,169,16,13,242,231,164,22,172,175,103,60,2,76,11,17,3,57,229,18,10,182,71,3,186,167,164,132,216,101,26,245,187,219,48,228,14,140,213,92,78,137,89,51,223,209,185,139,45,139,69,238,157,3,30,238,247,110,6,17,154,232,198,12,74,68,125,23,143,82,29,33,212,18,88,248,162,232,76,22,28,184,245,227,220,157,36,1,201,170,201,15,221,236,199,217,15,249,235,56,251,0,163,171,185,17,126,75,159,110,185,44,236,22,250,130,246,60,24,86,14,227,198,46,24,23,92,85,15,173,75,237,33,75,128,149,198,246,2,13,223,14,235,133,78,125,205,113,78,74,249,96,54,171,147,218,68,105,160,241,44,116,102,140,149,180,26,199,137,75,175,149,239,146,158,127,253,157,102,42,181,81,254,100,94,60,236,247,15,86,82,196,83,67,30,64,107,106,212,196,70,143,55,209,47,24,23,81,155,240,156,220,181,196,77,73,206,145,23,76,206,206,136,183,55,226,231,9,213,240,67,227,53,82,145,227,214,214,254,66,234,142,12,158,236,55,16,137,167,171,55,28,69,211,231,86,34,246,186,148,227,98,44,49,52,114,92,96,150,220,198,51,178,117,150,31,5,49,53,64,234,157,194,228,245,115,255,58,200,177,185,113,176,250,170,57,104,249,128,49,246,249,119,171,204,217,47,205,101,53,109,248,218,6,111,187,26,177,73,7,70,187,82,118,176,49,253,59,69,43,167,166,82,178,183,153,226,119,74,86,174,129,74,201,199,228,67,130,225,238,156,182,203,163,211,168,190,83,181,148,159,43,124,65,112,141,28,18,102,48,161,169,176,228,223,245,246,201,86,238,119,69,64,96,45,222,255,123,108,249,103,208,99,87,235,29,226,230,236,198,244,1,7,76,92,107,206,92,29,35,116,102,108,129,221,41,6,199,254,84,248,89,251,224,38,250,148,85,244,255,118,209,126,35,39,20,187,220,10,130,114,47,255,2,37,115,36,211,207,9,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateMoveItemMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8aed6aa2-0656-496f-985f-3b68b2f4e51b"),
				Name = "MoveItem",
				CreatedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4b891b37-6312-48c8-afb8-233b8e00f4ca"),
				Name = "incrementPosition",
				CreatedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				ModifiedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "int",
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,85,77,111,219,48,12,61,39,191,66,232,73,198,2,33,247,116,5,186,124,97,192,90,164,77,186,29,134,29,4,155,109,4,216,82,34,203,41,130,181,255,125,148,101,59,146,157,118,46,208,147,1,250,145,124,228,123,146,14,92,147,132,27,190,86,133,142,129,124,37,43,254,4,108,214,68,38,195,3,34,242,120,11,25,239,254,101,235,242,135,3,61,10,157,155,185,52,194,28,31,190,39,8,62,213,101,215,177,17,7,184,87,207,43,45,50,174,143,83,149,22,153,252,201,211,162,238,0,177,146,137,159,189,44,68,194,230,217,206,28,29,98,95,128,62,98,92,194,51,113,56,215,252,206,198,169,99,24,57,232,206,111,114,203,51,59,87,153,206,174,147,196,69,171,4,182,4,179,106,163,105,20,49,251,173,138,169,92,24,161,228,187,213,46,86,21,234,194,79,61,45,96,33,82,3,58,15,151,50,45,180,6,105,214,70,23,177,41,52,176,10,197,54,170,51,160,251,133,221,82,136,109,31,90,50,192,121,29,147,58,19,25,209,78,215,106,43,80,214,108,200,227,228,174,11,125,200,109,101,41,93,229,81,75,72,204,22,143,132,214,217,40,64,145,166,17,249,59,28,104,64,214,114,50,124,61,201,95,175,1,187,184,4,219,102,115,220,65,226,41,126,41,164,185,162,221,189,6,60,221,236,55,92,162,227,52,150,11,73,178,121,23,212,222,57,186,109,170,10,105,238,250,25,231,141,196,222,150,121,187,66,111,113,4,132,14,9,203,52,130,121,46,8,183,130,181,102,126,114,94,102,215,90,96,117,86,6,156,160,52,20,236,11,17,50,214,144,33,180,142,69,228,146,140,201,203,11,233,3,189,34,103,90,183,108,18,122,117,154,2,215,180,177,240,61,228,96,214,96,39,115,202,244,54,119,23,229,34,83,13,220,84,184,95,194,108,87,92,163,84,22,68,235,227,148,237,184,22,185,146,214,162,108,190,47,120,58,34,195,193,233,52,143,200,255,71,255,68,6,183,202,52,36,222,117,91,231,144,34,9,207,66,251,254,134,105,206,118,99,15,148,114,92,10,215,189,147,107,224,239,241,159,179,7,219,222,217,120,178,219,124,163,224,142,152,215,247,80,53,161,91,210,217,187,168,226,231,165,177,5,152,120,187,208,42,155,125,163,237,29,88,210,62,118,13,198,99,71,63,38,235,164,85,139,31,192,90,114,112,163,14,144,116,159,49,156,39,164,83,207,236,111,241,35,67,251,121,193,212,45,89,162,142,86,189,231,182,227,132,137,213,144,175,195,242,161,223,104,128,165,198,103,184,57,170,222,235,245,67,241,196,30,116,12,255,3,47,200,67,239,69,8,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateNormalizePositionsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0609a520-c7c9-45d0-a56d-2e49ba3c94ca"),
				Name = "NormalizePositions",
				CreatedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,83,65,110,219,48,16,60,203,128,255,192,250,68,33,6,145,246,234,36,128,235,186,70,128,162,113,107,167,61,20,61,16,210,166,33,32,145,234,146,76,42,20,249,123,150,148,228,90,182,236,75,47,54,196,221,153,157,157,33,159,36,50,91,219,121,94,42,125,87,1,74,167,140,94,161,212,14,96,147,61,66,41,191,120,192,154,93,51,13,207,108,169,157,114,245,222,57,95,203,95,32,62,72,39,55,198,99,6,162,169,165,179,241,232,137,152,43,84,165,196,22,176,48,133,47,245,103,89,2,177,13,227,196,10,220,186,193,252,235,230,29,27,28,78,255,63,85,177,181,39,234,104,128,152,231,121,211,193,79,172,146,138,240,75,196,231,176,147,181,177,42,24,59,73,197,29,230,128,239,235,185,205,118,123,229,59,161,31,85,225,0,237,128,63,11,143,72,35,54,14,125,230,60,130,104,91,197,214,28,173,223,148,104,118,1,89,152,202,143,180,165,131,130,59,74,18,206,143,52,245,66,80,96,7,237,162,248,26,53,123,195,239,109,208,162,117,243,25,104,218,20,90,79,214,18,101,217,38,25,89,226,1,208,76,242,237,237,100,202,46,251,249,223,230,103,17,239,8,177,242,42,23,203,178,114,117,7,245,21,45,4,45,230,62,126,28,8,155,158,186,146,49,229,241,40,17,27,112,123,73,78,251,11,196,142,239,143,128,112,250,166,220,218,229,111,47,11,222,219,35,101,210,182,138,102,44,9,230,60,24,100,60,136,86,164,247,114,70,127,87,59,215,197,194,120,237,232,236,226,34,101,127,105,166,122,96,188,43,254,80,63,67,2,219,186,130,246,230,125,147,133,135,43,165,221,205,254,29,100,111,174,153,106,224,73,79,139,136,253,93,178,103,24,131,193,55,124,248,29,5,203,147,164,103,206,142,87,197,90,19,134,88,254,129,204,187,240,188,19,218,59,121,25,143,94,194,250,49,134,45,2,172,144,82,92,20,32,49,190,148,195,120,62,25,153,127,53,207,150,138,175,80,220,30,254,197,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetMaxMinPositionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2ad491a4-d4f4-4181-9522-0e686033250f"),
				Name = "GetMaxMinPosition",
				CreatedInSchemaUId = new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,144,203,78,195,48,16,69,215,65,226,31,76,86,206,198,234,190,20,41,244,181,170,84,26,96,111,156,161,88,184,99,201,143,166,18,205,191,99,39,161,73,170,74,44,146,56,119,238,25,207,92,249,73,232,150,239,129,45,184,227,133,246,70,0,203,133,147,71,216,233,138,60,204,8,122,165,200,249,76,26,211,171,1,88,27,89,14,221,193,103,217,92,123,116,209,62,201,200,207,253,93,146,28,185,33,22,20,8,183,213,150,204,72,212,18,132,138,20,141,72,223,44,152,185,70,12,103,169,49,107,202,161,139,242,7,164,43,143,130,109,248,137,166,129,149,177,158,102,25,203,45,77,131,216,75,55,24,137,55,24,137,215,204,202,232,3,77,95,188,20,223,121,89,110,0,125,1,206,73,220,219,206,193,109,55,231,52,252,122,27,42,132,198,141,202,143,229,9,132,119,218,132,149,198,43,176,37,90,111,96,241,220,75,52,235,194,24,182,48,192,75,136,248,37,29,214,246,132,93,83,161,253,29,23,60,169,190,164,2,218,162,44,250,250,214,73,50,8,37,180,237,76,107,112,109,50,239,92,121,120,148,232,158,174,226,155,254,225,125,62,255,225,195,36,59,188,110,62,241,29,158,154,128,178,208,12,54,30,106,18,221,227,139,162,84,255,2,42,129,84,122,126,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new QuickAddMenuGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d7dcfba3-4711-467e-871c-0bf0ed85e85b"));
		}

		#endregion

	}

	#endregion

}

