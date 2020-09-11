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

	#region Class: AdministrativeByOperationsGridPageSchema

	/// <exclude/>
	public class AdministrativeByOperationsGridPageSchema : Terrasoft.WebApp.BaseAdministrativeGridPageSchema
	{

		#region Constructors: Public

		public AdministrativeByOperationsGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public AdministrativeByOperationsGridPageSchema(AdministrativeByOperationsGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.Hidden = true;
			AddButton.ModifiedInSchemaUId = new Guid("7b4c8366-d7de-4948-aca6-7a967d89caa8");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.ModifiedInSchemaUId = new Guid("7b4c8366-d7de-4948-aca6-7a967d89caa8");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("7b4c8366-d7de-4948-aca6-7a967d89caa8");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.Hidden = true;
			DeleteButton.ModifiedInSchemaUId = new Guid("7b4c8366-d7de-4948-aca6-7a967d89caa8");
		}

		private void UpdateUpButton() {
			UpButton.AjaxEvents.Click.IsProcessEventHandler = true;
			UpButton.Image = new ControlImage {};
			UpButton.Hidden = true;
			UpButton.ModifiedInSchemaUId = new Guid("7b4c8366-d7de-4948-aca6-7a967d89caa8");
		}

		private void UpdateDownButton() {
			DownButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DownButton.Image = new ControlImage {};
			DownButton.Hidden = true;
			DownButton.ModifiedInSchemaUId = new Guid("7b4c8366-d7de-4948-aca6-7a967d89caa8");
		}

		private void UpdateShowRelatedRightsCheckBox() {
			ShowRelatedRightsCheckBox.AjaxEvents.Check.IsProcessEventHandler = true;
		}

		private void UpdateCheckBoxControlLayout() {
			CheckBoxControlLayout.Image = new ControlImage {};
			CheckBoxControlLayout.ModifiedInSchemaUId = new Guid("7b4c8366-d7de-4948-aca6-7a967d89caa8");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("7b4c8366-d7de-4948-aca6-7a967d89caa8");
		}

		private void UpdateOwnMenuItem() {
			OwnMenuItem.AjaxEvents.CheckChange.IsProcessEventHandler = true;
			OwnMenuItem.AjaxEvents.CheckChange.ShowLoadMask = true;
			OwnMenuItem.Image = new ControlImage {};
			OwnMenuItem.ModifiedInSchemaUId = new Guid("7b4c8366-d7de-4948-aca6-7a967d89caa8");
		}

		private void UpdateAllMenuItem() {
			AllMenuItem.AjaxEvents.CheckChange.IsProcessEventHandler = true;
			AllMenuItem.AjaxEvents.CheckChange.ShowLoadMask = true;
			AllMenuItem.Image = new ControlImage {};
			AllMenuItem.ModifiedInSchemaUId = new Guid("7b4c8366-d7de-4948-aca6-7a967d89caa8");
		}

		private void UpdateShowRelatedRightsButton() {
			ShowRelatedRightsButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1"),
				ImageHash = @"57f7aae3209afa943cac8813eca36f32"
			};
			ShowRelatedRightsButton.ModifiedInSchemaUId = new Guid("7b4c8366-d7de-4948-aca6-7a967d89caa8");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("7b4c8366-d7de-4948-aca6-7a967d89caa8");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("7b4c8366-d7de-4948-aca6-7a967d89caa8");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("7b4c8366-d7de-4948-aca6-7a967d89caa8");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("7b4c8366-d7de-4948-aca6-7a967d89caa8");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("7b4c8366-d7de-4948-aca6-7a967d89caa8");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("7b4c8366-d7de-4948-aca6-7a967d89caa8");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("7b4c8366-d7de-4948-aca6-7a967d89caa8");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7b4c8366-d7de-4948-aca6-7a967d89caa8");
			RealUId = new Guid("7b4c8366-d7de-4948-aca6-7a967d89caa8");
			Name = "AdministrativeByOperationsGridPage";
			ParentSchemaUId = new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAdministrativeByOperationsGridPageEventsProcessSchema();
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
			UpdateShowRelatedRightsButton();
			UpdateAllMenuItem();
			UpdateOwnMenuItem();
			UpdatePrintButton();
			UpdateCheckBoxControlLayout();
			UpdateShowRelatedRightsCheckBox();
			UpdateDownButton();
			UpdateUpButton();
			UpdateDeleteButton();
			UpdateEditButton();
			UpdateCopyButton();
			UpdateAddButton();
			TopLevelControl.MoveItem(0, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, AddButton);
			ButtonsControlLayout.MoveItem(1, CopyButton);
			ButtonsControlLayout.MoveItem(2, EditButton);
			ButtonsControlLayout.MoveItem(3, DeleteButton);
			ButtonsControlLayout.MoveItem(4, UpButton);
			ButtonsControlLayout.MoveItem(5, DownButton);
			ButtonsControlLayout.MoveItem(6, CheckBoxControlLayout);
			CheckBoxControlLayout.MoveItem(0, ShowRelatedRightsCheckBox);
			ButtonsControlLayout.MoveItem(7, SpacerPrintButton);
			ButtonsControlLayout.MoveItem(8, PrintButton);
			ButtonsControlLayout.MoveItem(9, ShowRelatedRightsButton);
			ShowRelatedRightsButton.MoveItem(0, OwnMenuItem);
			ShowRelatedRightsButton.MoveItem(1, AllMenuItem);
			ButtonsControlLayout.MoveItem(10, ContextHelpButton);
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

		protected virtual EmbeddedProcessSchema CreateAdministrativeByOperationsGridPageEventsProcessSchema() {
			var schema = new AdministrativeByOperationsGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("f028c2c5-facc-4109-8cfa-75b2b6620527");
			DataSource.ModifiedInSchemaUId = new Guid("7b4c8366-d7de-4948-aca6-7a967d89caa8");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("6354dce8-e3f7-465c-aa8d-28bf2c1d6485");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("7b4c8366-d7de-4948-aca6-7a967d89caa8");
				column.ModifiedInSchemaUId = new Guid("7b4c8366-d7de-4948-aca6-7a967d89caa8");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("d27e9964-a7a6-46dd-9f9a-7cb470c33b98");
			if (column != null) {
				column.UId = new Guid("f4e106e4-25b4-4640-a003-fe091c78422f");
				column.Name = @"SysAdminUnit";
				column.CreatedInSchemaUId = new Guid("7b4c8366-d7de-4948-aca6-7a967d89caa8");
				column.ModifiedInSchemaUId = new Guid("7b4c8366-d7de-4948-aca6-7a967d89caa8");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("a3dc68d6-f74e-4a57-8411-77a88dfe0bbb");
			if (column != null) {
				column.UId = new Guid("abebf78d-0826-4e3c-8716-5b1006297c16");
				column.Name = @"CanRead";
				column.CreatedInSchemaUId = new Guid("7b4c8366-d7de-4948-aca6-7a967d89caa8");
				column.ModifiedInSchemaUId = new Guid("7b4c8366-d7de-4948-aca6-7a967d89caa8");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("21a61238-45dc-4089-9882-cc1be097cbf8");
			if (column != null) {
				column.UId = new Guid("49be7452-a2d6-4c93-8757-edf85c7f0b73");
				column.Name = @"CanAppend";
				column.CreatedInSchemaUId = new Guid("7b4c8366-d7de-4948-aca6-7a967d89caa8");
				column.ModifiedInSchemaUId = new Guid("7b4c8366-d7de-4948-aca6-7a967d89caa8");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("379b41a2-dfb5-4069-a267-88ec0653e391");
			if (column != null) {
				column.UId = new Guid("cd4726f4-0758-48c1-8985-f91eb95a0a53");
				column.Name = @"CanEdit";
				column.CreatedInSchemaUId = new Guid("7b4c8366-d7de-4948-aca6-7a967d89caa8");
				column.ModifiedInSchemaUId = new Guid("7b4c8366-d7de-4948-aca6-7a967d89caa8");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("2cda2c20-d48a-44d0-b266-5542730b1ad9");
			if (column != null) {
				column.UId = new Guid("806600ff-000b-4514-8950-e7ab0d2253cf");
				column.Name = @"CanDelete";
				column.CreatedInSchemaUId = new Guid("7b4c8366-d7de-4948-aca6-7a967d89caa8");
				column.ModifiedInSchemaUId = new Guid("7b4c8366-d7de-4948-aca6-7a967d89caa8");
				column.CreatedInPackageId = Guid.Empty;
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new AdministrativeByOperationsGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new AdministrativeByOperationsGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7b4c8366-d7de-4948-aca6-7a967d89caa8"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new AdministrativeByOperationsGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: AdministrativeByOperationsGridPageEventsProcess

	/// <exclude/>
	public class AdministrativeByOperationsGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseAdministrativeGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.AdministrativeByOperationsGridPageSchemaUserControl
	{

		public AdministrativeByOperationsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AdministrativeByOperationsGridPageEventsProcess";
			SchemaUId = new Guid("7b4c8366-d7de-4948-aca6-7a967d89caa8");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7b4c8366-d7de-4948-aca6-7a967d89caa8");
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

		private ProcessFlowElement _subProcess9;
		public ProcessFlowElement SubProcess9 {
			get {
				return _subProcess9 ?? (_subProcess9 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess9",
					SchemaElementUId = new Guid("78776e99-504f-40f4-b439-d8b23a71d077"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _initChild;
		public ProcessFlowElement InitChild {
			get {
				return _initChild ?? (_initChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "InitChild",
					SchemaElementUId = new Guid("ebbaea4b-0579-436f-9689-f743476a3c39"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptInitChild;
		public ProcessScriptTask ScriptInitChild {
			get {
				return _scriptInitChild ?? (_scriptInitChild = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptInitChild",
					SchemaElementUId = new Guid("52b601cb-6fe0-4194-bddc-e281d1b9cb04"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptInitChildExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _throwInitParent;
		public ProcessThrowMessageEvent ThrowInitParent {
			get {
				return _throwInitParent ?? (_throwInitParent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ThrowInitParent",
					SchemaElementUId = new Guid("8770e4d2-e948-4d11-93d6-ba7ba53e8f92"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _subProcess10;
		public ProcessFlowElement SubProcess10 {
			get {
				return _subProcess10 ?? (_subProcess10 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess10",
					SchemaElementUId = new Guid("48829e21-6ea5-4cb6-833a-6233dd783fd5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoadCompleteChild;
		public ProcessFlowElement PageLoadCompleteChild {
			get {
				return _pageLoadCompleteChild ?? (_pageLoadCompleteChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoadCompleteChild",
					SchemaElementUId = new Guid("e589e92a-81c9-48fc-ad32-bdb6cddd98c3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptPageLoadCompleteChild;
		public ProcessScriptTask ScriptPageLoadCompleteChild {
			get {
				return _scriptPageLoadCompleteChild ?? (_scriptPageLoadCompleteChild = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptPageLoadCompleteChild",
					SchemaElementUId = new Guid("05dff5e1-a16d-4b65-a72a-03bf04ee1c61"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptPageLoadCompleteChildExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _throwPageLoadCompleteParent;
		public ProcessThrowMessageEvent ThrowPageLoadCompleteParent {
			get {
				return _throwPageLoadCompleteParent ?? (_throwPageLoadCompleteParent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ThrowPageLoadCompleteParent",
					SchemaElementUId = new Guid("47faab22-9967-43e5-a026-5b845e778ac8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _subProcess11;
		public ProcessFlowElement SubProcess11 {
			get {
				return _subProcess11 ?? (_subProcess11 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess11",
					SchemaElementUId = new Guid("e6bf2529-4da4-4787-8421-f0cf9533b75b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _selectSchemaForAddRightsChild;
		public ProcessFlowElement SelectSchemaForAddRightsChild {
			get {
				return _selectSchemaForAddRightsChild ?? (_selectSchemaForAddRightsChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SelectSchemaForAddRightsChild",
					SchemaElementUId = new Guid("fda2d6f9-e4d5-44f2-b61b-96b88441a9a3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _throwSelectSchemaForAddRightsParent;
		public ProcessThrowMessageEvent ThrowSelectSchemaForAddRightsParent {
			get {
				return _throwSelectSchemaForAddRightsParent ?? (_throwSelectSchemaForAddRightsParent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ThrowSelectSchemaForAddRightsParent",
					SchemaElementUId = new Guid("2d0a7c7f-eeec-4b0d-9030-41d76ee5e8a0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "SelectSchemaForAddRights",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptSelectSchemaForAddRightsChild;
		public ProcessScriptTask ScriptSelectSchemaForAddRightsChild {
			get {
				return _scriptSelectSchemaForAddRightsChild ?? (_scriptSelectSchemaForAddRightsChild = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptSelectSchemaForAddRightsChild",
					SchemaElementUId = new Guid("375b2db8-b7c7-42ac-b81e-9035c0676d2d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptSelectSchemaForAddRightsChildExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[SubProcess9.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess9 };
			FlowElements[InitChild.SchemaElementUId] = new Collection<ProcessFlowElement> { InitChild };
			FlowElements[ScriptInitChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptInitChild };
			FlowElements[ThrowInitParent.SchemaElementUId] = new Collection<ProcessFlowElement> { ThrowInitParent };
			FlowElements[SubProcess10.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess10 };
			FlowElements[PageLoadCompleteChild.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteChild };
			FlowElements[ScriptPageLoadCompleteChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPageLoadCompleteChild };
			FlowElements[ThrowPageLoadCompleteParent.SchemaElementUId] = new Collection<ProcessFlowElement> { ThrowPageLoadCompleteParent };
			FlowElements[SubProcess11.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess11 };
			FlowElements[SelectSchemaForAddRightsChild.SchemaElementUId] = new Collection<ProcessFlowElement> { SelectSchemaForAddRightsChild };
			FlowElements[ThrowSelectSchemaForAddRightsParent.SchemaElementUId] = new Collection<ProcessFlowElement> { ThrowSelectSchemaForAddRightsParent };
			FlowElements[ScriptSelectSchemaForAddRightsChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptSelectSchemaForAddRightsChild };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SubProcess9":
						break;
					case "InitChild":
						e.Context.QueueTasks.Enqueue("ScriptInitChild");
						break;
					case "ScriptInitChild":
						e.Context.QueueTasks.Enqueue("ThrowInitParent");
						break;
					case "ThrowInitParent":
						break;
					case "SubProcess10":
						break;
					case "PageLoadCompleteChild":
						e.Context.QueueTasks.Enqueue("ScriptPageLoadCompleteChild");
						break;
					case "ScriptPageLoadCompleteChild":
						e.Context.QueueTasks.Enqueue("ThrowPageLoadCompleteParent");
						break;
					case "ThrowPageLoadCompleteParent":
						break;
					case "SubProcess11":
						break;
					case "SelectSchemaForAddRightsChild":
						e.Context.QueueTasks.Enqueue("ThrowSelectSchemaForAddRightsParent");
						break;
					case "ThrowSelectSchemaForAddRightsParent":
						e.Context.QueueTasks.Enqueue("ScriptSelectSchemaForAddRightsChild");
						break;
					case "ScriptSelectSchemaForAddRightsChild":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("InitChild");
			ActivatedEventElements.Add("PageLoadCompleteChild");
			ActivatedEventElements.Add("SelectSchemaForAddRightsChild");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SubProcess9":
					context.QueueTasks.Dequeue();
					break;
				case "InitChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitChild";
					result = InitChild.Execute(context);
					break;
				case "ScriptInitChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptInitChild";
					result = ScriptInitChild.Execute(context, ScriptInitChildExecute);
					break;
				case "ThrowInitParent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = ThrowInitParent.Execute(context);
					break;
				case "SubProcess10":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadCompleteChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteChild";
					result = PageLoadCompleteChild.Execute(context);
					break;
				case "ScriptPageLoadCompleteChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptPageLoadCompleteChild";
					result = ScriptPageLoadCompleteChild.Execute(context, ScriptPageLoadCompleteChildExecute);
					break;
				case "ThrowPageLoadCompleteParent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = ThrowPageLoadCompleteParent.Execute(context);
					break;
				case "SubProcess11":
					context.QueueTasks.Dequeue();
					break;
				case "SelectSchemaForAddRightsChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "SelectSchemaForAddRightsChild";
					result = SelectSchemaForAddRightsChild.Execute(context);
					break;
				case "ThrowSelectSchemaForAddRightsParent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "SelectSchemaForAddRights");
					result = ThrowSelectSchemaForAddRightsParent.Execute(context);
					break;
				case "ScriptSelectSchemaForAddRightsChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptSelectSchemaForAddRightsChild";
					result = ScriptSelectSchemaForAddRightsChild.Execute(context, ScriptSelectSchemaForAddRightsChildExecute);
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

		public virtual bool ScriptInitChildExecute(ProcessExecutingContext context) {
			VirtualDataSourceID = "OperationRightsVirtualDataSource";
			OperationRightCode = "CanChangeEntitySchemaOperationRightLevel";
			return true;
		}

		public virtual bool ScriptPageLoadCompleteChildExecute(ProcessExecutingContext context) {
			OperationRightCode = "CanChangeEntitySchemaOperationRightLevel";
			RightsSchemaName = "SysEntitySchemaOperationRight";
			RightsGrouppingColumnNames = "SubjectSchemaUId";
			return true;
		}

		public virtual bool ScriptSelectSchemaForAddRightsChildExecute(ProcessExecutingContext context) {
			if (SelectedNodePrimaryColumnValue.IsEmpty() || 
			SelectedSchemaUIdForAddRights.IsEmpty()) {
				return true;
			}
			Guid schemaId = ShowRightsBySubject ? SelectedNodePrimaryColumnValue : SelectedSchemaUIdForAddRights;
			var granteeId = ShowRightsBySubject ? SelectedSchemaUIdForAddRights : SelectedNodePrimaryColumnValue;
			//Код, который компилируется только в Workspace CR172133
			Select s = new Select(Page.UserConnection).
				Column("UId").From("VwSysSchemaInWorkspace").
				Where("Id").IsEqual(Column.Parameter(schemaId)) as Select;
			using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				using (var dataReader = s.ExecuteReader(dbExecutor)) {
					if (dataReader.Read()) {
						schemaId = Page.UserConnection.DBTypeConverter.DBValueToGuid(dataReader[0]);
					}
				}
			}
			var selectedSchema = Page.UserConnection.EntitySchemaManager.GetInstanceByUId(schemaId);
			SetEntitySchemaAdministratedByOperations(schemaId, true);
			Guid existRecordId = Guid.Empty;
			var recordIdSelect =
				new Terrasoft.Core.DB.Select(Page.UserConnection)
					.Column("Id")
				.From(RightsSchemaName)
				.Where("SubjectSchemaUId")
					.IsEqual(Terrasoft.Core.DB.Column.Parameter(schemaId))
				.And("SysAdminUnitId")
					.IsEqual(Terrasoft.Core.DB.Column.Parameter(granteeId)) as Terrasoft.Core.DB.Select;
			using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				using (var dataReader = recordIdSelect.ExecuteReader(dbExecutor)) {
					if (dataReader.Read()) {
						existRecordId = Page.UserConnection.DBTypeConverter.DBValueToGuid(dataReader[0]);
					}
				}
			}
			Guid recordId = SetOperationAllowed(
				granteeId,
				selectedSchema.UId,
				Terrasoft.Core.DB.SchemaOperationRightLevels.All, true
			);
			if (existRecordId.IsEmpty()) {
				var virtualDataSource = GetVirtualDataSource();
				var newEntity = virtualDataSource.Schema.CreateEntity(Page.UserConnection);
				newEntity.SetColumnValue("Id", recordId);
				newEntity.SetColumnValue("SysSchemaId", schemaId);
				newEntity.SetColumnValue("SysSchemaCaption", selectedSchema.Caption.Value);
				var selectedAdminUnit = new Terrasoft.Core.Configuration.SysAdminUnitSchema(Page.UserConnection.EntitySchemaManager).CreateEntity(Page.UserConnection);
				selectedAdminUnit.FetchFromDB(granteeId);
				newEntity.SetColumnValue("SysAdminUnitId", selectedAdminUnit.GetTypedColumnValue<Guid>("Id"));
				newEntity.SetColumnValue("SysAdminUnitName", selectedAdminUnit.GetTypedColumnValue<string>("Name"));
				newEntity.SetColumnValue("CanRead", true);
				newEntity.SetColumnValue("CanAppend", true);
				newEntity.SetColumnValue("CanEdit", true);
				newEntity.SetColumnValue("CanDelete", true);
				virtualDataSource.Insert(newEntity);
				UserConnection.DBSecurityEngine.ClearOperationRightsCache();
				Page.TreeGrid.Clear();
				virtualDataSource.Clear();
				virtualDataSource.Rows.Clear();
				FillVirtualDataSource(virtualDataSource, null);
				virtualDataSource.LoadRows();
				EnableButtons(virtualDataSource.Rows.Count);
			}
			return true;
		}

		public override void CreateVirtualDataSourceStructure(DataValueTypeManager dataValueTypeManager, DataSourceStructure defStructure) {
			var dataSource = Page.DataSource;
			var schema = dataSource.Schema;
			var entitySchemaManager = Page.UserConnection.EntitySchemaManager;
			var column = new DataSourceStructureColumn {
					Name = "Id",
					ValueColumnName = "Id",
					DataValueType = dataValueTypeManager.GetInstanceByName("Guid"),
					Caption = "Id",
					IsVisible = false,
					IsSortable = false
				};
				defStructure.AddColumn(column);
				column = new DataSourceStructureColumn {
					Name = "UId",
					ValueColumnName = "UId",
					DisplayColumnName = "Caption",
					DataValueType = dataValueTypeManager.GetInstanceByName("Lookup"),
					ReferenceSchemaUId = entitySchemaManager.GetInstanceByName("VwSysSchemaInWorkspace").UId,
					ReferenceSchemaName = "VwSysSchemaInWorkspace",
					ReferenceSchemaPrimaryColumnName = "Id",
					Caption = schema.Columns.GetByName("SubjectSchemaUId").Caption,
					IsVisible = !ShowRightsBySubject,
					IsSortable = false
				};
				defStructure.AddColumn(column);
				column = new DataSourceStructureColumn {
					Name = "SysAdminUnit",
					ValueColumnName = "SysAdminUnitId",
					DisplayColumnName = "SysAdminUnitName",
					DataValueType = dataValueTypeManager.GetInstanceByName("Lookup"),
					ReferenceSchemaUId = entitySchemaManager.GetInstanceByName("VwSysAdminUnit").UId,
					ReferenceSchemaName = "VwSysAdminUnit",
					ReferenceSchemaPrimaryColumnName = "Id",
					ReferenceSchemaPrimaryDisplayColumnName = "Name",
					Caption = schema.Columns.GetByName("SysAdminUnit").Caption,
					IsVisible = true,
					IsSortable = false
				};
				defStructure.AddColumn(column);
				column = new DataSourceStructureColumn {
					Name = "CanRead",
					ValueColumnName = "CanRead",
					DisplayColumnName = "CanRead",
					DataValueType = dataValueTypeManager.GetInstanceByName("Boolean"),
					Caption = schema.Columns.GetByName("CanRead").Caption,
					IsVisible = true,
					IsSortable = false
				};
				defStructure.AddColumn(column);
				column = new DataSourceStructureColumn {
					Name = "CanAppend",
					ValueColumnName = "CanAppend",
					DisplayColumnName = "CanAppend",
					DataValueType = dataValueTypeManager.GetInstanceByName("Boolean"),
					Caption = schema.Columns.GetByName("CanAppend").Caption,
					IsVisible = true,
					IsSortable = false
				};
				defStructure.AddColumn(column);
				column = new DataSourceStructureColumn {
					Name = "CanEdit",
					ValueColumnName = "CanEdit",
					DisplayColumnName = "CanEdit",
					DataValueType = dataValueTypeManager.GetInstanceByName("Boolean"),
					Caption = schema.Columns.GetByName("CanEdit").Caption,
					IsVisible = true,
					IsSortable = false
				};
				defStructure.AddColumn(column);
				column = new DataSourceStructureColumn {
					Name = "CanDelete",
					ValueColumnName = "CanDelete",
					DisplayColumnName = "CanDelete",
					DataValueType = dataValueTypeManager.GetInstanceByName("Boolean"),
					Caption = schema.Columns.GetByName("CanDelete").Caption,
					IsVisible = true,
					IsSortable = false
				};
				defStructure.AddColumn(column);
				column = new DataSourceStructureColumn {
					Name = "Position",
					ValueColumnName = "Position",
					DisplayColumnName = "Position",
					DataValueType = dataValueTypeManager.GetInstanceByName("Integer"),
					Caption = schema.Columns.GetByName("Position").Caption,
					IsVisible = false,
					IsSortable = false
				};
				defStructure.AddColumn(column);
		}

		public override void DataSource_Saved(object sender, AjaxEventArgs e) {
			var virtualDataSource = GetVirtualDataSource();
			var request = virtualDataSource.GetDataSourceRequest(e);
			var schema = Page.DataSource.Schema;
			var entity = schema.CreateEntity(Page.UserConnection);
			if (entity.FetchFromDB(request.Values[schema.PrimaryColumn.ColumnValueName])) {
				var subjectSchemaId = entity.GetTypedColumnValue<Guid>("SubjectSchemaUId");
				string schemaName = schema.EntitySchemaManager.GetItemByUId(subjectSchemaId).Name;
				Guid adminUnitId = entity.GetTypedColumnValue<Guid>("SysAdminUnitId");
				var dbSecurityEngine = Page.UserConnection.DBSecurityEngine;
				SchemaOperationRightLevels rightLevel = dbSecurityEngine.GetEntitySchemaOperationsRightLevel(adminUnitId, schemaName);
				Guid newAdminUnitId = adminUnitId;
				string newSchemaName = schemaName;
				if (request.Values.ContainsKey("SysSchemaId")) {
					Guid sysSchemaId = new Guid(request.Values["SysSchemaId"].ToString());
					//Код, который компилируется только в Workspace CR172133
					var sysSchemaView = new Terrasoft.Core.Configuration.VwSysSchemaInWorkspace(Page.UserConnection);
					var conditions = new Dictionary<string, object> {
						{ "UId", sysSchemaId },
						{ "SysWorkspace", Page.UserConnection.Workspace.Id }
					};
					//if (sysSchemaView.FetchFromDB(conditions)) {
						//}
					newSchemaName = sysSchemaView.Name;
				}
				if (request.Values.ContainsKey("SysAdminUnitId")) {
					newAdminUnitId = new Guid(request.Values["SysAdminUnitId"].ToString());
				}
				if (request.Values.ContainsKey("CanRead")) {
					bool canRead = bool.Parse(request.Values["CanRead"].ToString());
					if (canRead) {
						if (!(rightLevel & SchemaOperationRightLevels.CanRead).Equals(SchemaOperationRightLevels.CanRead)) {
							rightLevel += (int)SchemaOperationRightLevels.CanRead;
						}
					} else {
						if ((rightLevel & SchemaOperationRightLevels.CanRead).Equals(SchemaOperationRightLevels.CanRead)) {
							rightLevel -= (int)SchemaOperationRightLevels.CanRead;
						}
					}
				}
				if (request.Values.ContainsKey("CanAppend")) {
					bool canAppend = bool.Parse(request.Values["CanAppend"].ToString());
					if (canAppend) {
						if (!(rightLevel & SchemaOperationRightLevels.CanAppend).Equals(SchemaOperationRightLevels.CanAppend)) {
							rightLevel += (int)SchemaOperationRightLevels.CanAppend;
						}
					} else {
						if ((rightLevel & SchemaOperationRightLevels.CanAppend).Equals(SchemaOperationRightLevels.CanAppend)) {
							rightLevel -= (int)SchemaOperationRightLevels.CanAppend;
						}
					}
				}
				if (request.Values.ContainsKey("CanEdit")) {
					bool canEdit = bool.Parse(request.Values["CanEdit"].ToString());
					if (canEdit) {
						if (!(rightLevel & SchemaOperationRightLevels.CanEdit).Equals(SchemaOperationRightLevels.CanEdit)) {
							rightLevel += (int)SchemaOperationRightLevels.CanEdit;
						}
					} else {
						if ((rightLevel & SchemaOperationRightLevels.CanEdit).Equals(SchemaOperationRightLevels.CanEdit)) {
							rightLevel -= (int)SchemaOperationRightLevels.CanEdit;
						}
					}
				}
				if (request.Values.ContainsKey("CanDelete")) {
					bool canDelete = bool.Parse(request.Values["CanDelete"].ToString());
					if (canDelete) {
						if (!(rightLevel & SchemaOperationRightLevels.CanDelete).Equals(SchemaOperationRightLevels.CanDelete)) {
							rightLevel += (int)SchemaOperationRightLevels.CanDelete;
						}
					} else {
						if ((rightLevel & SchemaOperationRightLevels.CanDelete).Equals(SchemaOperationRightLevels.CanDelete)) {
							rightLevel -= (int)SchemaOperationRightLevels.CanDelete;
						}
					}
				}
				Page.UserConnection.DBSecurityEngine.ClearOperationRightsCache();
				if (request.Values.ContainsKey("SysAdminUnitId") || request.Values.ContainsKey("SysSchemaId")) {
					dbSecurityEngine.DeleteEntitySchemaOperationRightLevel(adminUnitId, schemaName);
					/*var instanceId = ((Terrasoft.UI.Core.Page)Page.AspPage).InstanceId.ToString();
					string key = instanceId + Page.PageContainer.UniqueID;
					string script = string.Format("if (window.Terrasoft.AjaxMethods.ThrowClientEvent) {{ window.Terrasoft.AjaxMethods.ThrowClientEvent('{0}','GridPageRefreshRow');}}", key);
					Page.AddScript(script);*/
					Page.ThrowEvent("GridPageRefreshRow");
				}
				dbSecurityEngine.SetEntitySchemaOperationsRightLevel(newAdminUnitId, newSchemaName, rightLevel);
				dbSecurityEngine.ClearOperationRightsCache();
			}
		}

		public override void FillVirtualDataSource(VirtualDataSource virtualDataSource, params object[] objectParameters) {
			var select = GetSelectForVirtualDataSource(objectParameters);
			Collection<string> columnValueNames = new Collection<string>() {
				"Id", "SysSchemaId","SysSchemaCaption","SysAdminUnitId", "SysAdminUnitName", "CanRead", "CanAppend", "CanEdit", "CanDelete", "Position"
			};
			using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				using (var reader = select.ExecuteReader(dbExecutor)) {
					while (reader.Read()) {
						var row = virtualDataSource.CreateRow();
						int ordinal = -1;
						foreach (var columnValueName in columnValueNames) {
							ordinal = reader.GetOrdinal(columnValueName);
							if (!reader.IsDBNull(ordinal)) {
								if (columnValueName.StartsWith("Can")) {
									row.SetColumnValue(columnValueName, UserConnection.DBTypeConverter.DBValueToBool(reader.GetValue(ordinal)));
								} else {
									row.SetColumnValue(columnValueName, reader.GetValue(ordinal));
								}
							}
						}
						virtualDataSource.Add(row);
					}
				}
			}
		}

		public override System.Collections.Generic.List<string> GetButtons() {
			var buttons = new System.Collections.Generic.List<string>();
			buttons.Add(Page.AddButton.Name);
			buttons.Add(Page.EditButton.Name);
			buttons.Add(Page.DeleteButton.Name);
			return buttons;
		}

		public override int DeterminePositionForMove(int sourcePosition, bool doIncreasePosition, string sourceSubjectName) {
			if (doIncreasePosition) {
				var selectMin = new Select(Page.UserConnection)
						.Column(Func.Min(RightsSchemaName, "Position"))
					.From(RightsSchemaName)
					.Where(RightsSchemaName, "SubjectSchemaName").IsEqual(Column.Parameter(sourceSubjectName))
					.And(RightsSchemaName, "Position").IsGreater(Column.Parameter(sourcePosition)) as Select;
				if (!ShowRightsBySubject) {
					selectMin.And(RightsSchemaName, "SysAdminUnitId").In(Column.Parameters((object[])SelectParameters));
				}
				using (var dbExecutor = UserConnection.EnsureDBConnection()) {
					using (var reader = selectMin.ExecuteReader(dbExecutor)) {
						if (reader.Read()) {
							return UserConnection.DBTypeConverter.DBValueToInt(reader[0]) + 1;
						}
					}
				}
				return sourcePosition + 1;
			}
			var selectMax = new Select(Page.UserConnection)
						.Column(Func.Max(RightsSchemaName, "Position"))
					.From(RightsSchemaName)
					.Where(RightsSchemaName, "SubjectSchemaName").IsEqual(Column.Parameter(sourceSubjectName))
					.And(RightsSchemaName, "Position").IsLess(Column.Parameter(sourcePosition)) as Select;
			if (!ShowRightsBySubject) {
				selectMax.And(RightsSchemaName, "SysAdminUnitId").In(Column.Parameters((object[])SelectParameters));
			}
			using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				using (var reader = selectMax.ExecuteReader(dbExecutor)) {
					if (reader.Read()) {
						return UserConnection.DBTypeConverter.DBValueToInt(reader[0]);
					}
				}
			}
			return sourcePosition - 1;
		}

		public override Select GetSelectForVirtualDataSource(params object[] objectParameters) {
			if (objectParameters == null) {
				Collection<Guid> adminUnitCollection = new Collection<Guid>();
				Guid filterColumnValue = SelectedNodePrimaryColumnValue;
				if (Page.AllMenuItem.Checked) {
					if(!filterColumnValue.IsEmpty()) {
						adminUnitCollection = Page.UserConnection.DBSecurityEngine.GetUserAdminUnitCollection(filterColumnValue);
					}
				} else {
					adminUnitCollection.Add(filterColumnValue);
				}
				objectParameters = new object[adminUnitCollection.Count];
				for (int i = 0; i < adminUnitCollection.Count; i++) {
					objectParameters[i] = adminUnitCollection[i];
				}
			}
			var entitySchemaManager = Page.UserConnection.EntitySchemaManager;
			var rightsSchema = entitySchemaManager.GetInstanceByName("SysEntitySchemaOperationRight");
			var select = new Select(Page.UserConnection)
					.Column(rightsSchema.Name, "Id")
					.Column(rightsSchema.Name, "SubjectSchemaUId").As("SysSchemaId")
					.Column("VwSysSchemaInWorkspace", "Caption").As("SysSchemaCaption")
					.Column(rightsSchema.Name, "SysAdminUnitId")
					.Column("SysAdminUnit", "Name").As("SysAdminUnitName")
					.Column(rightsSchema.Name,"CanRead")
					.Column(rightsSchema.Name,"CanAppend")
					.Column(rightsSchema.Name,"CanEdit")
					.Column(rightsSchema.Name, "CanDelete")
					.Column(rightsSchema.Name, "Position")
				.From(rightsSchema.Name)
				.InnerJoin("SysAdminUnit").On("SysAdminUnit", "Id").IsEqual(rightsSchema.Name, "SysAdminUnitId")
				.OrderByAsc(rightsSchema.Name, "SubjectSchemaUId")
				.OrderByAsc(rightsSchema.Name, "Position") as Select;
			if (ShowRightsBySubject) {
				select.InnerJoin("VwSysSchemaInWorkspace").On("VwSysSchemaInWorkspace", "UId").IsEqual(rightsSchema.Name, "SubjectSchemaUId");
				select.Where("VwSysSchemaInWorkspace", "Id").IsEqual(Column.Parameter(objectParameters[0]));
			} else {
				select.Where(rightsSchema.Name, "SysAdminUnitId").In(Column.Parameters(objectParameters));
			}
			return select;
		}

		public override bool GetIsContextHelpButtonHidden() {
			return false;
		}

		public override string GetRegisterEditPageScript(Guid editPageUId, Guid sysModuleEditId) {
			return string.Empty;
		}

		public override string GetRegisterCopyPageScript(Guid editPageUId, Guid sysModuleEditId) {
			return string.Empty;
		}

		public override string GetRegisterAddPageScript(Guid editPageUId, Guid sysModuleEditId, Guid typeId) {
			return string.Empty;
		}

		public virtual Guid SetOperationAllowed(Guid adminUnitId, Guid schemaUId, SchemaOperationRightLevels operation, bool isAllowed) {
			return  UserConnection.DBSecurityEngine.SetEntitySchemaOperationAllowed(adminUnitId,
				schemaUId, operation, isAllowed);
		}

		public virtual void SetEntitySchemaAdministratedByOperations(Guid schemaId, bool isAdministrated) {
			UserConnection.DBSecurityEngine.SetEntitySchemaAdministratedByOperations(schemaId, isAdministrated);
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Init":
							if (ActivatedEventElements.Contains("InitChild")) {
							context.QueueTasks.Enqueue("InitChild");
							ProcessQueue(context);
							return;
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteChild")) {
							context.QueueTasks.Enqueue("PageLoadCompleteChild");
							ProcessQueue(context);
							return;
						}
						break;
					case "SelectSchemaForAddRights":
							if (ActivatedEventElements.Contains("SelectSchemaForAddRightsChild")) {
							context.QueueTasks.Enqueue("SelectSchemaForAddRightsChild");
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
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: AdministrativeByOperationsGridPageEventsProcess

	/// <exclude/>
	public class AdministrativeByOperationsGridPageEventsProcess : AdministrativeByOperationsGridPageEventsProcess<Terrasoft.WebApp.AdministrativeByOperationsGridPageSchemaUserControl>
	{

		public AdministrativeByOperationsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AdministrativeByOperationsGridPageSchemaUserControl

	/// <exclude/>
	public partial class AdministrativeByOperationsGridPageSchemaUserControl : Terrasoft.WebApp.BaseAdministrativeGridPageSchemaUserControl
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
			var process = (AdministrativeByOperationsGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new AdministrativeByOperationsGridPageEventsProcess(UserConnection);
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
			SchemaName = "AdministrativeByOperationsGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: AdministrativeByOperationsGridPageEventsProcessSchema

	/// <exclude/>
	public class AdministrativeByOperationsGridPageEventsProcessSchema : Terrasoft.WebApp.BaseAdministrativeGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public AdministrativeByOperationsGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AdministrativeByOperationsGridPageEventsProcessSchema(AdministrativeByOperationsGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AdministrativeByOperationsGridPageEventsProcess";
			UId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet751 = CreateLaneSet751LaneSet();
			LaneSets.Add(schemaLaneSet751);
			ProcessSchemaLane schemaLane2740 = CreateLane2740Lane();
			schemaLaneSet751.Lanes.Add(schemaLane2740);
			ProcessSchemaEventSubProcess subprocess9 = CreateSubProcess9EventSubProcess();
			FlowElements.Add(subprocess9);
			ProcessSchemaEventSubProcess subprocess10 = CreateSubProcess10EventSubProcess();
			FlowElements.Add(subprocess10);
			ProcessSchemaEventSubProcess subprocess11 = CreateSubProcess11EventSubProcess();
			FlowElements.Add(subprocess11);
			ProcessSchemaStartMessageEvent initchild = CreateInitChildStartMessageEvent();
			subprocess9.FlowElements.Add(initchild);
			ProcessSchemaScriptTask scriptinitchild = CreateScriptInitChildScriptTask();
			subprocess9.FlowElements.Add(scriptinitchild);
			ProcessSchemaIntermediateThrowMessageEvent throwinitparent = CreateThrowInitParentIntermediateThrowMessageEvent();
			subprocess9.FlowElements.Add(throwinitparent);
			ProcessSchemaStartMessageEvent pageloadcompletechild = CreatePageLoadCompleteChildStartMessageEvent();
			subprocess10.FlowElements.Add(pageloadcompletechild);
			ProcessSchemaScriptTask scriptpageloadcompletechild = CreateScriptPageLoadCompleteChildScriptTask();
			subprocess10.FlowElements.Add(scriptpageloadcompletechild);
			ProcessSchemaIntermediateThrowMessageEvent throwpageloadcompleteparent = CreateThrowPageLoadCompleteParentIntermediateThrowMessageEvent();
			subprocess10.FlowElements.Add(throwpageloadcompleteparent);
			ProcessSchemaStartMessageEvent selectschemaforaddrightschild = CreateSelectSchemaForAddRightsChildStartMessageEvent();
			subprocess11.FlowElements.Add(selectschemaforaddrightschild);
			ProcessSchemaIntermediateThrowMessageEvent throwselectschemaforaddrightsparent = CreateThrowSelectSchemaForAddRightsParentIntermediateThrowMessageEvent();
			subprocess11.FlowElements.Add(throwselectschemaforaddrightsparent);
			ProcessSchemaScriptTask scriptselectschemaforaddrightschild = CreateScriptSelectSchemaForAddRightsChildScriptTask();
			subprocess11.FlowElements.Add(scriptselectschemaforaddrightschild);
			FlowElements.Add(CreateSequenceFlow16198SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16199SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16200SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16201SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16202SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16203SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16198SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16198",
				UId = new Guid("fd58325f-48c6-4b8c-8605-f3ad1d3ee0f6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CurveCenterPosition = new Point(171, 79),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ebbaea4b-0579-436f-9689-f743476a3c39"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("52b601cb-6fe0-4194-bddc-e281d1b9cb04"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16199SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16199",
				UId = new Guid("8a5d15af-1210-4094-a55f-bb53de94835a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CurveCenterPosition = new Point(285, 79),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("52b601cb-6fe0-4194-bddc-e281d1b9cb04"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8770e4d2-e948-4d11-93d6-ba7ba53e8f92"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16200SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16200",
				UId = new Guid("e91b306e-a363-4277-b35d-a6507682ce9b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CurveCenterPosition = new Point(478, 76),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e589e92a-81c9-48fc-ad32-bdb6cddd98c3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("05dff5e1-a16d-4b65-a72a-03bf04ee1c61"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16201SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16201",
				UId = new Guid("41f4f955-d742-4f5a-b91b-8b3b4b11db5e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CurveCenterPosition = new Point(574, 76),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("05dff5e1-a16d-4b65-a72a-03bf04ee1c61"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("47faab22-9967-43e5-a026-5b845e778ac8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16202SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16202",
				UId = new Guid("00eeaa0c-9e3b-4472-b96d-f9887bc3295a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CurveCenterPosition = new Point(748, 76),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fda2d6f9-e4d5-44f2-b61b-96b88441a9a3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2d0a7c7f-eeec-4b0d-9030-41d76ee5e8a0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16203SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16203",
				UId = new Guid("c463f2fa-1052-42d6-a91b-d531c43b7246"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CurveCenterPosition = new Point(841, 76),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2d0a7c7f-eeec-4b0d-9030-41d76ee5e8a0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("375b2db8-b7c7-42ac-b81e-9035c0676d2d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet751LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet751 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("e0b2648d-6718-4258-92ec-bc6e1f91f26e"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				Name = @"LaneSet751",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(966, 170),
				UseBackgroundMode = false
			};
			return schemaLaneSet751;
		}

		protected virtual ProcessSchemaLane CreateLane2740Lane() {
			ProcessSchemaLane schemaLane2740 = new ProcessSchemaLane(this) {
				UId = new Guid("d83d14b6-bcd8-404e-8dc1-b9554e450d21"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("e0b2648d-6718-4258-92ec-bc6e1f91f26e"),
				CreatedInOwnerSchemaUId = new Guid("7b4c8366-d7de-4948-aca6-7a967d89caa8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				Name = @"Lane2740",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(937, 170),
				UseBackgroundMode = false
			};
			return schemaLane2740;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("78776e99-504f-40f4-b439-d8b23a71d077"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d83d14b6-bcd8-404e-8dc1-b9554e450d21"),
				CreatedInOwnerSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				Name = @"SubProcess9",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 0),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(299, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess9;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ebbaea4b-0579-436f-9689-f743476a3c39"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("78776e99-504f-40f4-b439-d8b23a71d077"),
				CreatedInOwnerSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				Name = @"InitChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptInitChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("52b601cb-6fe0-4194-bddc-e281d1b9cb04"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("78776e99-504f-40f4-b439-d8b23a71d077"),
				CreatedInOwnerSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				Name = @"ScriptInitChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(99, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,204,49,10,128,48,16,5,209,222,83,4,175,33,86,209,66,16,4,3,246,139,126,76,64,55,178,110,4,111,175,150,177,127,51,83,16,77,180,53,164,228,98,146,25,93,99,106,83,14,7,132,52,68,30,195,234,245,156,254,170,172,138,156,216,184,224,11,45,177,245,196,43,90,214,160,183,155,61,118,202,105,143,11,219,59,16,104,18,54,42,9,213,3,196,49,129,96,135,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateThrowInitParentIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("8770e4d2-e948-4d11-93d6-ba7ba53e8f92"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("78776e99-504f-40f4-b439-d8b23a71d077"),
				CreatedInOwnerSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				Name = @"ThrowInitParent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(232, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess10EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess10 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("48829e21-6ea5-4cb6-833a-6233dd783fd5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d83d14b6-bcd8-404e-8dc1-b9554e450d21"),
				CreatedInOwnerSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				Name = @"SubProcess10",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(351, 2),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(271, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess10;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e589e92a-81c9-48fc-ad32-bdb6cddd98c3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("48829e21-6ea5-4cb6-833a-6233dd783fd5"),
				CreatedInOwnerSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				Name = @"PageLoadCompleteChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPageLoadCompleteChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("05dff5e1-a16d-4b65-a72a-03bf04ee1c61"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("48829e21-6ea5-4cb6-833a-6233dd783fd5"),
				CreatedInOwnerSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				Name = @"ScriptPageLoadCompleteChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(91, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,203,65,10,194,48,16,64,209,189,224,29,66,175,81,92,5,145,130,88,176,244,0,99,59,36,145,102,18,38,51,66,111,47,77,23,226,162,203,15,255,245,25,25,36,36,122,6,231,197,166,25,205,197,52,22,200,122,32,135,87,146,32,235,48,121,140,208,255,173,119,252,224,210,180,231,83,173,178,47,15,136,213,15,107,57,150,63,116,227,164,57,7,114,54,45,26,105,211,165,114,125,189,113,146,29,143,221,188,9,70,81,38,35,172,216,126,1,210,92,121,66,181,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateThrowPageLoadCompleteParentIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("47faab22-9967-43e5-a026-5b845e778ac8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("48829e21-6ea5-4cb6-833a-6233dd783fd5"),
				CreatedInOwnerSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				Name = @"ThrowPageLoadCompleteParent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(204, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess11EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess11 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e6bf2529-4da4-4787-8421-f0cf9533b75b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d83d14b6-bcd8-404e-8dc1-b9554e450d21"),
				CreatedInOwnerSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				Name = @"SubProcess11",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(630, 0),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(293, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess11;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSelectSchemaForAddRightsChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("fda2d6f9-e4d5-44f2-b61b-96b88441a9a3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6bf2529-4da4-4787-8421-f0cf9533b75b"),
				CreatedInOwnerSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SelectSchemaForAddRights",
				ModifiedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				Name = @"SelectSchemaForAddRightsChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(21, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateThrowSelectSchemaForAddRightsParentIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("2d0a7c7f-eeec-4b0d-9030-41d76ee5e8a0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6bf2529-4da4-4787-8421-f0cf9533b75b"),
				CreatedInOwnerSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"SelectSchemaForAddRights",
				ModifiedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				Name = @"ThrowSelectSchemaForAddRightsParent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(105, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptSelectSchemaForAddRightsChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("375b2db8-b7c7-42ac-b81e-9035c0676d2d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6bf2529-4da4-4787-8421-f0cf9533b75b"),
				CreatedInOwnerSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				Name = @"ScriptSelectSchemaForAddRightsChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(183, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,86,203,110,19,49,20,93,55,82,254,193,202,106,34,69,134,210,5,18,229,161,188,90,69,130,82,37,109,89,32,22,110,230,54,25,152,216,193,246,52,140,0,137,199,18,36,246,124,6,2,169,80,4,191,48,249,35,174,237,201,100,210,60,26,94,139,168,141,125,239,185,175,115,174,19,156,16,175,3,33,116,53,248,123,194,135,125,25,12,152,140,235,34,140,6,252,136,133,17,208,150,106,14,134,58,246,202,228,197,11,82,44,76,172,59,221,62,12,216,97,203,223,17,178,234,251,237,160,215,215,106,106,92,38,207,139,133,13,9,58,146,156,104,25,193,118,177,240,178,88,216,141,2,159,40,235,218,242,201,45,210,233,139,145,115,173,197,157,232,248,49,66,147,59,100,117,70,228,6,89,153,4,70,58,101,146,244,36,227,26,96,141,48,11,81,114,81,22,167,129,97,174,92,73,62,38,63,146,207,21,146,124,75,126,140,223,224,231,213,248,93,242,213,126,77,190,39,63,147,179,228,60,57,195,195,183,201,151,241,155,241,235,241,7,98,172,146,243,241,123,99,66,146,79,228,129,144,79,212,144,117,129,212,219,155,215,175,109,110,109,77,122,76,20,102,206,97,148,230,225,237,179,30,208,67,5,178,46,56,199,131,64,240,50,197,38,187,156,188,18,22,80,42,211,29,41,6,94,233,104,212,137,149,171,171,197,179,16,37,107,255,160,15,18,188,146,181,198,121,61,141,88,232,57,12,186,207,36,27,128,6,233,77,102,132,131,100,42,205,0,43,142,84,192,123,196,51,253,245,143,155,207,160,27,105,33,49,205,217,180,104,147,171,72,66,163,54,61,154,48,34,15,192,52,107,3,243,193,0,40,234,208,192,157,120,83,244,212,113,35,64,170,78,93,168,249,51,1,221,216,200,81,106,65,155,104,163,118,16,15,1,15,78,65,98,117,248,221,142,240,64,24,62,230,80,31,94,125,84,222,54,128,72,85,243,121,233,168,164,102,136,178,36,70,147,235,64,199,206,228,30,227,104,33,233,46,232,22,87,154,241,46,212,98,156,207,180,173,219,102,202,58,239,83,245,7,1,15,148,150,12,35,213,226,251,67,192,255,16,88,101,78,21,43,36,227,106,101,4,207,208,186,13,93,33,125,91,184,57,164,86,126,169,2,100,122,151,210,233,22,214,100,232,116,0,82,50,37,78,52,173,11,9,216,11,186,130,96,166,25,116,194,48,67,25,60,112,28,115,50,113,185,239,33,107,236,77,202,173,84,99,153,176,74,14,103,194,182,249,12,86,240,207,192,86,185,143,160,177,178,61,58,228,129,254,19,200,108,33,56,78,47,107,195,255,100,249,236,68,254,142,242,23,199,255,143,121,111,41,38,167,240,200,214,140,146,213,48,20,35,240,61,52,206,154,90,193,47,179,58,161,135,238,116,65,163,237,125,6,103,153,116,23,78,33,84,20,161,29,205,139,5,147,145,233,192,76,161,23,95,24,211,226,211,64,106,228,64,3,203,233,136,72,226,42,69,49,128,62,186,120,236,217,26,141,7,202,192,73,15,45,231,188,211,244,104,93,2,74,209,217,45,212,198,182,19,148,179,64,246,232,220,235,96,197,82,201,26,120,137,237,116,89,27,167,252,146,88,199,169,206,134,38,31,227,57,59,128,244,130,90,135,172,248,137,81,38,166,244,153,185,48,39,44,244,36,232,69,110,68,52,47,62,135,190,168,37,139,150,96,121,189,70,206,101,69,119,64,119,251,102,213,52,106,57,237,94,218,147,252,142,168,204,23,107,118,178,17,133,159,243,187,105,200,126,219,237,183,223,8,96,182,222,218,33,112,177,227,78,192,32,214,235,178,48,117,198,141,50,75,211,149,191,218,184,58,28,2,95,223,188,233,7,122,109,227,6,214,167,33,111,62,47,25,124,229,112,195,120,25,142,53,155,91,70,29,92,111,18,111,155,188,23,112,100,88,8,76,206,110,1,85,103,200,29,39,84,203,148,3,9,176,43,241,97,179,198,222,146,240,43,47,219,98,164,242,22,59,65,24,206,239,134,57,191,10,225,81,24,46,193,188,43,152,111,112,29,98,147,179,227,16,106,145,214,230,185,94,150,129,136,184,46,187,159,193,249,223,197,191,0,218,113,50,166,131,11,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateSetOperationAllowedMethod());
			Methods.Add(CreateSetEntitySchemaAdministratedByOperationsMethod());
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

		protected override SchemaMethod CreateCreateVirtualDataSourceStructureMethod() {
			SchemaMethod method = base.CreateCreateVirtualDataSourceStructureMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,150,219,78,227,48,16,134,175,139,196,59,148,92,81,105,149,23,64,92,244,128,80,164,221,85,213,208,238,245,144,76,169,33,177,35,219,161,138,16,239,190,118,227,230,208,218,17,20,84,114,153,153,223,115,248,252,203,202,43,240,97,12,18,66,150,243,8,135,183,195,57,60,161,63,171,34,55,151,23,175,74,34,162,13,166,160,210,181,214,15,119,49,35,64,42,137,44,202,208,31,160,170,8,223,23,91,10,228,83,70,41,70,146,48,234,223,29,43,77,141,136,37,121,74,213,49,138,219,97,61,66,40,121,30,201,156,227,180,204,191,93,94,12,6,127,33,213,211,122,65,236,253,210,223,43,72,114,35,56,76,233,74,187,244,67,145,161,89,161,250,54,19,248,247,40,3,42,36,208,8,39,133,174,112,237,221,231,36,246,70,187,18,83,200,244,236,205,170,129,88,17,65,30,19,93,113,13,137,64,19,13,25,151,208,8,171,232,187,218,111,16,227,186,90,196,31,199,113,57,235,117,185,243,72,43,78,89,127,217,177,127,149,155,17,145,37,80,180,179,102,165,175,33,250,205,216,75,158,25,72,11,92,35,71,149,45,239,86,181,87,149,44,190,176,21,90,109,195,66,148,170,128,254,99,252,69,100,16,161,55,242,85,21,91,241,253,22,142,115,182,35,115,78,82,224,133,221,35,245,5,151,78,247,75,153,208,179,238,103,12,243,199,103,229,225,106,59,53,157,57,118,100,136,171,112,195,182,11,242,180,145,98,82,152,115,63,226,15,69,103,28,167,132,46,41,145,78,163,52,69,157,158,105,10,117,172,79,230,169,215,252,152,105,14,176,124,198,44,118,173,149,88,77,233,67,14,107,175,225,114,151,186,240,159,121,109,166,64,23,8,238,23,167,149,119,188,58,77,197,137,198,153,48,150,32,208,163,183,217,13,118,223,182,159,76,199,89,134,180,147,106,83,225,226,218,210,156,147,172,105,220,79,182,119,113,199,195,215,202,187,184,54,20,231,164,186,107,219,79,166,51,76,80,98,23,213,166,194,197,181,165,57,39,89,211,184,135,108,231,76,144,250,167,204,130,182,45,176,146,61,144,156,8,54,160,18,85,234,19,96,171,190,110,174,223,240,155,252,31,135,246,88,36,175,12,0,0 };
			return method;
		}

		protected override SchemaMethod CreateDataSource_SavedMethod() {
			SchemaMethod method = base.CreateDataSource_SavedMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,87,205,110,219,70,16,62,43,64,222,97,171,67,77,38,234,186,105,14,61,56,9,32,75,178,33,164,105,12,201,118,15,69,14,107,113,44,109,34,45,149,229,74,170,224,8,104,147,99,11,244,222,199,40,18,32,109,138,244,21,168,55,234,236,15,69,82,140,98,90,16,122,176,100,238,206,55,243,205,124,179,212,236,148,73,50,229,82,77,216,176,201,20,235,134,19,217,3,242,144,28,131,58,95,95,246,252,131,219,183,166,8,144,240,114,2,145,66,179,2,148,34,48,125,234,88,67,15,18,100,212,27,192,136,33,240,132,245,129,102,96,93,179,225,172,64,40,174,230,104,101,205,105,67,2,83,208,50,171,158,65,158,69,32,27,161,16,208,83,60,20,218,59,191,36,158,197,209,35,80,189,193,145,12,71,205,67,207,81,165,231,108,136,223,63,58,135,39,146,143,152,156,55,194,225,100,36,168,253,50,22,223,179,17,60,243,125,114,117,251,86,197,240,157,92,60,199,24,150,93,59,64,74,46,6,166,121,58,31,67,144,193,62,56,158,240,224,145,87,237,102,49,103,237,160,170,233,85,34,37,185,232,187,140,116,152,52,61,155,152,181,127,194,4,230,39,181,255,182,130,209,225,28,29,120,107,44,124,170,241,218,169,142,72,88,48,226,226,76,112,85,150,223,60,170,167,16,203,78,231,26,92,116,161,55,145,136,110,137,62,23,144,168,148,175,53,109,30,230,205,52,220,50,123,58,6,201,180,77,135,247,7,234,59,152,194,48,34,114,245,63,250,91,15,161,105,102,179,95,121,136,82,23,94,38,191,90,166,126,254,170,0,2,102,245,92,13,50,136,76,233,209,172,91,172,126,82,74,221,63,249,102,193,190,16,138,113,17,61,134,185,169,90,82,255,170,107,16,27,61,74,55,208,41,6,33,122,121,189,241,114,248,103,244,52,236,26,82,158,111,210,168,236,239,199,127,196,31,227,183,53,18,255,29,127,92,190,198,191,159,151,191,198,127,153,199,248,159,248,223,248,125,252,33,126,143,139,111,226,119,203,215,203,95,150,191,19,109,21,127,88,254,166,77,72,252,39,249,33,148,47,162,49,195,227,219,232,220,251,246,155,123,247,239,107,207,166,139,147,216,231,28,233,89,146,167,32,37,139,194,75,133,105,74,208,185,94,242,254,196,86,159,158,207,82,186,98,229,119,211,209,179,65,122,161,8,184,209,206,69,104,114,99,129,231,236,129,85,160,70,66,211,199,143,108,245,42,87,164,170,143,71,45,87,194,69,45,217,67,10,171,208,104,244,169,94,92,237,83,141,212,192,133,43,167,150,51,151,118,238,173,144,114,77,164,68,136,193,23,154,36,231,35,105,150,69,185,134,201,29,51,23,168,208,172,159,235,152,172,131,66,211,148,33,209,96,162,3,44,141,126,17,134,67,210,179,139,24,91,63,210,19,38,35,40,68,79,144,197,94,213,49,157,139,164,120,122,233,11,47,115,212,191,36,155,95,9,212,185,246,105,235,37,254,118,68,94,9,211,36,80,37,19,227,238,67,226,113,161,252,235,225,134,118,197,246,7,193,117,200,208,254,191,89,127,181,21,235,242,114,215,199,99,16,69,193,237,242,181,146,59,244,70,209,237,254,214,178,59,120,185,18,58,227,237,165,183,14,118,37,254,174,184,151,107,128,34,247,242,45,208,194,119,91,161,1,244,226,181,242,27,228,70,241,245,238,214,210,27,112,185,226,25,211,237,101,215,240,93,137,190,11,214,229,4,95,103,93,94,238,38,12,65,65,65,112,187,124,173,228,14,189,81,116,187,191,181,236,14,94,174,132,206,120,123,233,173,131,93,137,191,43,238,229,26,160,200,221,181,64,153,33,156,54,134,192,100,222,117,212,96,24,208,92,218,110,60,172,144,87,175,200,77,167,225,194,112,111,51,250,228,124,95,114,188,175,236,223,209,163,37,70,85,76,244,192,204,75,158,151,142,174,103,109,59,189,234,18,249,166,78,245,104,108,30,104,123,133,201,116,182,241,233,174,3,47,64,223,48,51,174,239,218,17,83,127,184,92,241,30,134,196,176,10,237,102,22,25,245,36,31,235,151,169,125,166,71,161,28,49,229,85,117,145,103,92,4,225,140,166,20,235,207,217,79,79,64,13,194,32,162,167,3,25,206,26,67,142,119,180,214,20,63,176,112,87,228,70,8,111,239,234,235,197,94,109,239,88,242,64,19,237,192,165,132,104,208,9,103,123,254,193,98,129,99,50,166,101,211,180,229,8,130,174,97,235,89,210,254,193,157,253,213,166,113,110,221,86,139,14,171,171,33,179,32,108,183,196,173,45,63,231,214,242,183,175,90,230,90,104,194,20,66,124,190,159,23,255,1,219,141,46,119,183,16,0,0 };
			return method;
		}

		protected override SchemaMethod CreateFillVirtualDataSourceMethod() {
			SchemaMethod method = base.CreateFillVirtualDataSourceMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,82,65,110,194,48,16,60,39,175,112,57,25,137,70,234,153,182,18,36,180,226,66,17,1,122,54,201,210,184,114,108,100,59,80,84,241,247,110,236,144,84,65,61,244,98,121,39,51,179,179,222,28,153,38,6,4,100,150,60,145,87,176,169,187,191,40,189,229,218,86,76,36,204,178,84,85,58,3,170,118,159,248,105,201,52,43,193,130,54,195,113,24,43,81,211,185,146,143,198,106,46,63,158,73,166,68,85,202,45,19,21,44,144,104,208,86,194,137,220,50,233,144,124,135,193,96,158,15,70,100,144,158,77,154,21,80,178,186,236,170,152,29,106,137,135,38,121,201,229,70,114,219,74,90,164,238,84,99,49,147,43,96,121,115,157,28,14,32,175,197,44,231,182,185,38,56,163,117,252,165,50,220,53,8,47,227,176,50,24,139,208,35,190,72,190,155,125,65,86,89,165,49,254,198,128,142,149,148,62,126,52,147,166,210,144,76,59,136,14,221,40,191,244,26,67,64,173,245,79,27,121,55,88,57,152,118,238,94,24,156,10,46,128,80,175,138,106,86,99,25,4,206,77,157,208,234,216,95,72,20,163,0,77,213,137,226,42,144,203,165,37,74,231,92,50,129,252,251,7,7,238,21,178,178,194,231,234,45,135,112,121,179,175,166,111,208,25,53,177,240,231,120,243,24,237,105,124,247,128,239,9,189,107,200,115,147,76,23,149,16,180,177,185,142,227,89,61,125,148,90,166,173,121,231,182,160,245,126,6,29,59,192,217,163,20,108,220,41,250,234,81,127,65,201,116,125,62,0,2,71,208,248,159,98,237,184,107,53,85,74,208,110,26,239,214,6,108,166,8,46,4,132,129,127,5,248,211,243,106,25,182,167,59,110,87,57,201,115,138,157,156,0,41,151,240,242,3,145,42,50,45,153,3,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetButtonsMethod() {
			SchemaMethod method = base.CreateGetButtonsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,42,45,41,201,207,43,86,176,85,200,75,45,87,8,174,44,46,73,205,213,115,206,207,201,73,77,46,201,4,74,232,185,167,230,165,22,101,38,235,249,100,22,151,216,20,151,20,101,230,165,219,105,104,90,115,65,53,234,57,166,164,104,4,36,166,167,130,24,78,96,49,61,191,196,220,84,108,42,92,83,50,75,8,40,113,73,205,73,45,73,69,85,84,148,90,82,90,148,7,115,169,53,0,61,67,96,227,182,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateDeterminePositionForMoveMethod() {
			SchemaMethod method = base.CreateDeterminePositionForMoveMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,146,203,78,195,48,16,69,215,206,87,152,174,108,1,17,172,43,22,180,180,168,18,160,138,240,88,32,22,110,50,52,70,141,13,118,220,135,80,255,157,113,146,54,64,31,8,42,22,72,201,194,99,207,157,235,235,35,159,40,75,116,79,197,6,132,133,190,182,50,151,90,113,250,22,144,177,48,212,194,8,226,252,82,42,122,66,21,76,104,84,172,89,95,12,33,188,181,96,218,90,41,44,248,150,128,16,18,182,245,200,101,138,117,157,138,67,236,98,215,114,152,230,54,138,83,200,196,149,200,224,128,54,22,51,26,220,183,132,93,163,179,149,99,197,206,125,10,6,214,41,68,110,240,140,67,235,90,131,135,61,219,121,117,98,196,74,3,97,95,24,172,231,96,152,213,206,196,80,181,20,218,133,248,169,74,182,155,67,197,115,204,196,75,108,208,92,134,197,169,176,85,50,205,128,72,76,116,47,74,245,164,148,111,205,170,217,69,166,100,25,232,38,7,209,204,158,38,153,84,183,74,230,189,196,251,80,43,6,44,99,186,208,124,120,228,229,220,122,139,115,244,48,15,136,179,82,13,41,243,143,152,12,58,83,136,93,174,13,190,226,231,87,11,59,202,58,3,103,173,186,196,120,233,244,131,0,230,144,128,111,174,221,151,138,112,93,236,176,122,66,213,92,164,80,182,133,254,204,66,148,16,3,185,51,234,171,141,179,214,205,236,5,176,48,6,131,183,192,245,157,24,57,184,65,50,243,74,231,225,232,145,211,125,122,220,244,50,120,65,255,227,87,233,125,126,146,242,220,60,248,128,176,152,254,6,97,49,253,223,8,95,128,181,63,227,119,43,190,203,44,255,146,222,121,176,43,187,91,208,69,235,223,160,187,137,220,157,192,109,46,120,157,7,235,129,61,68,96,223,1,244,44,251,51,140,5,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetSelectForVirtualDataSourceMethod() {
			SchemaMethod method = base.CreateGetSelectForVirtualDataSourceMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,85,205,110,226,48,16,62,83,169,239,224,205,41,81,87,86,239,180,149,2,165,21,43,181,160,70,180,7,196,193,155,12,224,54,113,178,182,179,40,90,245,221,119,28,71,144,226,208,32,161,82,205,204,247,227,153,177,225,107,226,231,191,223,33,214,115,38,89,6,26,164,34,183,183,68,148,105,26,144,127,151,23,131,113,158,166,152,230,185,184,121,44,121,114,71,88,146,113,177,16,92,31,50,4,1,176,35,199,165,126,48,68,2,243,47,89,243,20,169,177,160,204,196,43,75,75,64,72,4,166,26,146,231,60,129,185,228,25,147,85,171,192,64,57,186,155,179,13,208,48,77,159,64,148,83,13,25,29,111,33,254,128,196,186,195,18,255,135,67,78,167,106,146,21,186,242,131,166,106,208,109,186,230,94,40,131,21,194,70,233,253,40,130,184,148,92,87,19,177,225,2,232,35,104,83,18,186,12,190,35,92,31,120,240,137,127,62,9,164,10,172,122,135,56,13,147,228,4,220,160,221,145,212,13,182,225,101,23,223,56,47,133,94,25,252,58,151,196,231,66,19,142,168,235,33,126,221,116,205,204,34,48,125,117,213,52,233,88,116,201,87,200,208,1,197,68,99,20,63,127,153,36,32,52,246,43,138,183,144,177,39,38,176,171,242,68,119,39,110,229,208,114,72,190,217,106,101,51,8,238,160,52,147,152,10,165,153,136,97,84,61,163,75,223,139,42,213,166,156,21,32,153,17,122,49,108,94,208,112,171,122,211,154,38,218,181,243,59,220,5,166,11,212,206,195,111,251,161,70,236,39,241,166,137,215,91,19,149,117,27,109,112,97,16,52,84,181,81,27,58,230,240,94,119,135,156,120,203,229,135,42,88,12,30,82,141,89,97,108,29,51,236,195,189,86,42,181,223,90,71,182,157,52,98,6,115,80,218,167,108,248,123,37,52,42,94,128,245,54,199,212,133,69,1,226,172,202,73,130,198,122,207,136,133,247,56,80,221,107,146,120,243,92,241,125,227,232,131,204,51,183,172,78,77,113,33,228,175,156,31,119,41,160,179,142,198,213,35,198,7,231,79,201,210,115,199,64,103,50,1,57,170,66,21,159,185,68,103,128,14,231,35,76,53,107,142,23,192,60,162,209,54,223,213,87,66,141,170,134,219,94,122,123,51,218,39,62,177,142,246,236,167,119,117,209,223,6,231,76,195,131,129,183,45,72,248,142,255,11,189,29,50,221,63,85,206,79,216,242,122,21,24,250,214,43,252,69,232,156,49,97,83,28,33,229,40,89,153,203,11,9,186,148,162,121,105,134,255,1,251,142,41,103,87,7,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetIsContextHelpButtonHiddenMethod() {
			SchemaMethod method = base.CreateGetIsContextHelpButtonHiddenMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,75,204,41,78,181,6,0,112,193,6,27,13,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetRegisterEditPageScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterEditPageScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetRegisterCopyPageScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterCopyPageScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetRegisterAddPageScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterAddPageScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetOperationAllowedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e2f19aee-a336-4134-ab0a-2dfdc30a4f3e"),
				Name = "SetOperationAllowed",
				CreatedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Guid"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4889550d-e4bd-49d0-b391-8876b8ed831a"),
				Name = "adminUnitId",
				CreatedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				ModifiedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e69d2c32-5f38-4bf1-8fae-5b237f64ffaa"),
				Name = "schemaUId",
				CreatedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				ModifiedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("3777b10d-9773-4c24-8be3-dd2050316393"),
				Name = "operation",
				CreatedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				ModifiedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "SchemaOperationRightLevels",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("903930a9-8849-4e57-ac9b-91043b042dc9"),
				Name = "isAllowed",
				CreatedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				ModifiedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,80,8,45,78,45,114,206,207,203,75,77,46,201,204,207,211,115,113,10,78,77,46,45,202,44,169,116,205,75,207,204,75,213,11,78,45,113,205,43,1,242,131,147,51,82,115,19,253,11,82,139,18,65,42,29,115,114,242,203,83,83,52,18,83,114,51,243,66,243,50,75,60,83,116,120,185,56,139,193,170,66,129,28,133,124,152,82,29,133,204,98,168,114,77,107,0,89,102,111,191,120,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetEntitySchemaAdministratedByOperationsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ba228573-6a5a-43eb-95c1-7d5d8d8dad37"),
				Name = "SetEntitySchemaAdministratedByOperations",
				CreatedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4c889480-b142-4767-aa12-f1bb9ee42f6c"),
				Name = "schemaId",
				CreatedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				ModifiedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b0b52a3f-6237-4dc8-b11e-19b507bb600e"),
				Name = "isAdministrated",
				CreatedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				ModifiedInSchemaUId = new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,78,45,114,206,207,203,75,77,46,201,204,207,211,115,113,10,78,77,46,45,202,44,169,116,205,75,207,204,75,213,11,78,45,113,205,43,1,242,131,147,51,82,115,19,29,83,114,51,243,50,139,75,138,18,75,82,83,156,42,253,11,82,129,44,160,198,98,141,98,176,188,103,138,142,66,102,49,138,42,77,107,0,248,70,182,170,100,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AdministrativeByOperationsGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bfef080e-ec6f-4af0-b96d-d5868dba0e49"));
		}

		#endregion

	}

	#endregion

}

