namespace Terrasoft.WebApp
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.ComponentModel;
	using System.Drawing;
	using System.Globalization;
	using System.Linq;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.Web.Common;
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: QuickAddMenuItemEditPageSchema

	/// <exclude/>
	public class QuickAddMenuItemEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.LookupEdit _sysAdminUnitEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit SysAdminUnitEdit {
			get {
				return _sysAdminUnitEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LookupEdit _quickAddMenuSettingsEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit QuickAddMenuSettingsEdit {
			get {
				return _quickAddMenuSettingsEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.IntegerEdit _positionEdit;
		public Terrasoft.UI.WebControls.Controls.IntegerEdit PositionEdit {
			get {
				return _positionEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public QuickAddMenuItemEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public QuickAddMenuItemEditPageSchema(QuickAddMenuItemEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("6b9a7f4b-4fbc-4b70-9559-7684afbb5674");
			NameEdit.ModifiedInSchemaUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("1e74dace-10b6-4e9f-82f1-da6629644dd1");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
			RealUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
			Name = "QuickAddMenuItemEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateQuickAddMenuItemEditPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateButtonsControlLayout();
			UpdateApplyChangesButton();
			UpdateCancelButton();
			UpdateOKButton();
			UpdateDesignerModeButton();
			UpdateContextHelpButton();
			UpdateMainControlLayout();
			UpdateCustomControls();
			UpdateDescriptionEdit();
			UpdateNameEdit();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.MoveItem(0, NameEdit);
			MainControlLayout.InsertItem(1, CreateSysAdminUnitEdit());
			MainControlLayout.InsertItem(2, CreateQuickAddMenuSettingsEdit());
			MainControlLayout.InsertItem(3, CreatePositionEdit());
			MainControlLayout.MoveItem(4, DescriptionEdit);
			MainControlLayout.MoveItem(5, CustomControls);
			TopLevelControl.MoveItem(2, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, ContextHelpButton);
			ButtonsControlLayout.MoveItem(1, DesignerModeButton);
			ButtonsControlLayout.MoveItem(2, SpacerButton);
			ButtonsControlLayout.MoveItem(3, OKButton);
			ButtonsControlLayout.MoveItem(4, CancelButton);
			ButtonsControlLayout.MoveItem(5, ApplyChangesButton);
			TopLevelControl.MoveItem(3, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateQuickAddMenuItemEditPageEventsProcessSchema() {
			var schema = new QuickAddMenuItemEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateSysAdminUnitEdit() {
			_sysAdminUnitEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_sysAdminUnitEdit.UId = new Guid("6bf10020-7d4d-41d2-b146-8022e12f4f4a");
			_sysAdminUnitEdit.Name = "SysAdminUnitEdit";
			_sysAdminUnitEdit.CreatedInSchemaUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
			_sysAdminUnitEdit.ModifiedInSchemaUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
			_sysAdminUnitEdit.CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e");
			_sysAdminUnitEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_sysAdminUnitEdit.Tag = "";
			_sysAdminUnitEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_sysAdminUnitEdit.Image = new ControlImage {};
			_sysAdminUnitEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _sysAdminUnitEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateQuickAddMenuSettingsEdit() {
			_quickAddMenuSettingsEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_quickAddMenuSettingsEdit.UId = new Guid("93cf0d33-0034-4681-8fe4-cafe8b80b610");
			_quickAddMenuSettingsEdit.Name = "QuickAddMenuSettingsEdit";
			_quickAddMenuSettingsEdit.CreatedInSchemaUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
			_quickAddMenuSettingsEdit.ModifiedInSchemaUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
			_quickAddMenuSettingsEdit.CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e");
			_quickAddMenuSettingsEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_quickAddMenuSettingsEdit.Tag = "";
			_quickAddMenuSettingsEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_quickAddMenuSettingsEdit.Image = new ControlImage {};
			_quickAddMenuSettingsEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_quickAddMenuSettingsEdit.DataSource = "DataSource";
			_quickAddMenuSettingsEdit.ColumnUId = new Guid("28346530-c72a-4a5b-9bbb-0ed1f6dd4d5f");
			return _quickAddMenuSettingsEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.IntegerEdit CreatePositionEdit() {
			_positionEdit = new Terrasoft.UI.WebControls.Controls.IntegerEdit();
			_positionEdit.UId = new Guid("311654ab-8465-45ae-bb2d-35b342afb1b2");
			_positionEdit.Name = "PositionEdit";
			_positionEdit.CreatedInSchemaUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
			_positionEdit.ModifiedInSchemaUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
			_positionEdit.CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e");
			_positionEdit.Tag = "";
			_positionEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_positionEdit.Image = new ControlImage {};
			_positionEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_positionEdit.DataSource = "DataSource";
			_positionEdit.ColumnUId = new Guid("f3691f1f-e6a1-4a0d-bb18-1399989c0b2e");
			_positionEdit.Enabled = false;
			return _positionEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("a526ee14-e5f7-4174-8f48-ad030d8862af");
			DataSource.ModifiedInSchemaUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("f143f1ec-8c0f-469b-90ac-c2143e4d8ab7");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
				column.ModifiedInSchemaUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("689b2f22-4068-4a02-b1c1-9a9d66a64014");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
				column.ModifiedInSchemaUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("acfafd46-f53b-409d-8f79-a73e203ffba5");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
				column.ModifiedInSchemaUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("0ea364a4-98ae-45a9-b7d4-e7e6cc5f47d1");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
				column.ModifiedInSchemaUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("c03c532d-8d8d-4c23-958d-8693fc5380a5");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
				column.ModifiedInSchemaUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("f180d72b-278b-4b0c-af89-ebd3fac1c85d");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
				column.ModifiedInSchemaUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("17031297-a36e-490d-b08f-9ae1088678dd");
			if (column != null) {
				column.UId = new Guid("6b9a7f4b-4fbc-4b70-9559-7684afbb5674");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
				column.ModifiedInSchemaUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("055b00cf-3a59-407c-810c-4c4642774ef7");
			if (column != null) {
				column.UId = new Guid("84e756ad-fd4a-4477-90ee-dd06e90398bf");
				column.Name = @"SysModuleEdit";
				column.CreatedInSchemaUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
				column.ModifiedInSchemaUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("b743c56b-8c92-4c20-8fc7-fa62299d16fe");
			if (column != null) {
				column.UId = new Guid("28346530-c72a-4a5b-9bbb-0ed1f6dd4d5f");
				column.Name = @"QuickAddMenuSettings";
				column.CreatedInSchemaUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
				column.ModifiedInSchemaUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("881e0a65-a92c-4a78-af62-796dc72312ba");
			if (column != null) {
				column.UId = new Guid("f3691f1f-e6a1-4a0d-bb18-1399989c0b2e");
				column.Name = @"Position";
				column.CreatedInSchemaUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
				column.ModifiedInSchemaUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("2326f2b8-6c93-4b44-9760-d043a3b4a6fe");
			if (column != null) {
				column.UId = new Guid("1e74dace-10b6-4e9f-82f1-da6629644dd1");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
				column.ModifiedInSchemaUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
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
			return new QuickAddMenuItemEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new QuickAddMenuItemEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new QuickAddMenuItemEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: QuickAddMenuItemEditPageEventsProcess

	/// <exclude/>
	public class QuickAddMenuItemEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.QuickAddMenuItemEditPageSchemaUserControl
	{

		public QuickAddMenuItemEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "QuickAddMenuItemEditPageEventsProcess";
			SchemaUId = new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("dcdcf287-abad-40f2-9348-ca7995a9a075");
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
					SchemaElementUId = new Guid("60d3cf02-c976-4370-a070-acd40baab2f8"),
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
					SchemaElementUId = new Guid("e95404e7-71a4-4b42-933f-acd4655c1f91"),
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
					SchemaElementUId = new Guid("066282c0-60a9-4005-90f9-3fd0c266b383"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask2Execute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediatePageLoadComplete;
		public ProcessThrowMessageEvent IntermediatePageLoadComplete {
			get {
				return _intermediatePageLoadComplete ?? (_intermediatePageLoadComplete = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediatePageLoadComplete",
					SchemaElementUId = new Guid("65a670a6-1bce-45a9-920d-0140706761af"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("a8ad30a8-0a32-4f7b-8daa-09ae1e2603a5"),
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
					SchemaElementUId = new Guid("9b1e9fe5-9d7f-4610-9307-f78b1f275ed5"),
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
					SchemaElementUId = new Guid("d3bc1c50-6791-44a6-8787-bc921c8dd338"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
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
					SchemaElementUId = new Guid("ebf4e7d9-0aa3-4a4d-bfe2-fa2b2be482a7"),
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
					SchemaElementUId = new Guid("ff6dedab-84ec-441b-a055-fa3744508ac8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskSysAdminUnitEditChange;
		public ProcessScriptTask ScriptTaskSysAdminUnitEditChange {
			get {
				return _scriptTaskSysAdminUnitEditChange ?? (_scriptTaskSysAdminUnitEditChange = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskSysAdminUnitEditChange",
					SchemaElementUId = new Guid("18dc63af-181a-492e-86cf-21d2ed74f47b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskSysAdminUnitEditChangeExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[ScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask2 };
			FlowElements[IntermediatePageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediatePageLoadComplete };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[StartMessage3.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3 };
			FlowElements[ScriptTaskSysAdminUnitEditChange.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskSysAdminUnitEditChange };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess2":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("IntermediatePageLoadComplete");
						break;
					case "ScriptTask2":
						break;
					case "IntermediatePageLoadComplete":
						e.Context.QueueTasks.Enqueue("ScriptTask2");
						break;
					case "EventSubProcess1":
						break;
					case "StartMessage2":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "ScriptTask1":
						break;
					case "EventSubProcess3":
						break;
					case "StartMessage3":
						e.Context.QueueTasks.Enqueue("ScriptTaskSysAdminUnitEditChange");
						break;
					case "ScriptTaskSysAdminUnitEditChange":
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
				case "StartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1";
					result = StartMessage1.Execute(context);
					break;
				case "ScriptTask2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask2";
					result = ScriptTask2.Execute(context, ScriptTask2Execute);
					break;
				case "IntermediatePageLoadComplete":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediatePageLoadComplete.Execute(context);
					break;
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage2";
					result = StartMessage2.Execute(context);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3";
					result = StartMessage3.Execute(context);
					break;
				case "ScriptTaskSysAdminUnitEditChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskSysAdminUnitEditChange";
					result = ScriptTaskSysAdminUnitEditChange.Execute(context, ScriptTaskSysAdminUnitEditChangeExecute);
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
			Page.SysAdminUnitEdit.SetLookupSchemaUId(new Guid("779469a1-c8de-4e31-8151-768ee43b50a3"));
			if (IsNew) {
				int Position = 0;
				var selectName = 
					new Select(UserConnection)
					.Column(Func.Count("Position"))
					.From("QuickAddMenuItem")
					as Select;
				if (selectName.ExecuteScalar<int>() > 0) {
					selectName = 
						new Select(UserConnection)
						.Column(Func.Max("Position"))
						.From("QuickAddMenuItem")
						as Select;
					Position = selectName.ExecuteScalar<int>()+1; 
				} 
				Page.DataSource.ActiveRow.SetColumnValue("Position",Position);
			} else {
				var CurrEditPage = Page.DataSource.ActiveRow.GetTypedColumnValue<Guid>("SysModuleEditId");
				if(CurrEditPage != Guid.Empty)
				{
					Page.DataSource.ActiveRow.LoadLookupDisplayValues();
					var CurrEditPageCaption = Page.DataSource.ActiveRow.GetColumnDisplayValue(Page.DataSource.ActiveRow.Schema.Columns.GetByName("SysModuleEdit"));
					Page.SysAdminUnitEdit.SetValueAndText(CurrEditPage,CurrEditPageCaption);
				}	
			}
			return true;
		}

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			if (IsNew) {
				int Position = 0;
				var QuickettingsId = Page.DataSource.ActiveRow.GetTypedColumnValue<Guid>("QuickAddMenuSettingsId");
				var selectName = 
					new Select(UserConnection)
					.Column(Func.Count("Position"))
					.From("QuickAddMenuItem")
					.Where("QuickAddMenuSettingsId").IsEqual(Column.Parameter(QuickettingsId))
					as Select;
				if (selectName.ExecuteScalar<int>() > 0) {
					selectName = 
						new Select(UserConnection)
						.Column(Func.Max("Position"))
						.From("QuickAddMenuItem")
						.Where("QuickAddMenuSettingsId").IsEqual(Column.Parameter(QuickettingsId))
						as Select;
					Position = selectName.ExecuteScalar<int>()+1; 
				} 
				Page.DataSource.ActiveRow.SetColumnValue("Position",Position);
			}
			return true;
			
		}

		public virtual bool ScriptTaskSysAdminUnitEditChangeExecute(ProcessExecutingContext context) {
			var editIdObj = Page.SysAdminUnitEdit.Value;
			if(editIdObj != null){
				var editId = new Guid(editIdObj.ToString());
				Page.DataSource.ActiveRow.SetColumnValue("SysModuleEditId",editId);
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
							ProcessQueue(context);
							return;
						}
						break;
					case "QuickAddMenuSettingsEditChange":
							if (ActivatedEventElements.Contains("StartMessage2")) {
							context.QueueTasks.Enqueue("StartMessage2");
						}
						break;
					case "SysAdminUnitEditChange":
							if (ActivatedEventElements.Contains("StartMessage3")) {
							context.QueueTasks.Enqueue("StartMessage3");
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

	#region Class: QuickAddMenuItemEditPageEventsProcess

	/// <exclude/>
	public class QuickAddMenuItemEditPageEventsProcess : QuickAddMenuItemEditPageEventsProcess<Terrasoft.WebApp.QuickAddMenuItemEditPageSchemaUserControl>
	{

		public QuickAddMenuItemEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: QuickAddMenuItemEditPageSchemaUserControl

	/// <exclude/>
	public partial class QuickAddMenuItemEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.LookupEdit SysAdminUnitEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("SysAdminUnitEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LookupEdit QuickAddMenuSettingsEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("QuickAddMenuSettingsEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.IntegerEdit PositionEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.IntegerEdit)PageContainer.FindPageControl("PositionEdit", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			SysAdminUnitEdit.AjaxEvents.Change.Event += SysAdminUnitEditChange;
			QuickAddMenuSettingsEdit.AjaxEvents.Change.Event += QuickAddMenuSettingsEditChange;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			SysAdminUnitEdit.AjaxEvents.Change.Event -= SysAdminUnitEditChange;
			QuickAddMenuSettingsEdit.AjaxEvents.Change.Event -= QuickAddMenuSettingsEditChange;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (QuickAddMenuItemEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new QuickAddMenuItemEditPageEventsProcess(UserConnection);
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

		public virtual void SysAdminUnitEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("SysAdminUnitEditChange");
		}

		public virtual void QuickAddMenuSettingsEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("QuickAddMenuSettingsEditChange");
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
			SchemaName = "QuickAddMenuItemEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: QuickAddMenuItemEditPageEventsProcessSchema

	/// <exclude/>
	public class QuickAddMenuItemEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public QuickAddMenuItemEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public QuickAddMenuItemEditPageEventsProcessSchema(QuickAddMenuItemEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "QuickAddMenuItemEditPageEventsProcess";
			UId = new Guid("850fa773-a0b3-44bb-93d7-6f437b7355c0");
			CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
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
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			eventsubprocess2.FlowElements.Add(startmessage1);
			ProcessSchemaScriptTask scripttask2 = CreateScriptTask2ScriptTask();
			eventsubprocess2.FlowElements.Add(scripttask2);
			ProcessSchemaIntermediateThrowMessageEvent intermediatepageloadcomplete = CreateIntermediatePageLoadCompleteIntermediateThrowMessageEvent();
			eventsubprocess2.FlowElements.Add(intermediatepageloadcomplete);
			ProcessSchemaStartMessageEvent startmessage2 = CreateStartMessage2StartMessageEvent();
			eventsubprocess1.FlowElements.Add(startmessage2);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			eventsubprocess1.FlowElements.Add(scripttask1);
			ProcessSchemaStartMessageEvent startmessage3 = CreateStartMessage3StartMessageEvent();
			eventsubprocess3.FlowElements.Add(startmessage3);
			ProcessSchemaScriptTask scripttasksysadminuniteditchange = CreateScriptTaskSysAdminUnitEditChangeScriptTask();
			eventsubprocess3.FlowElements.Add(scripttasksysadminuniteditchange);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("a38f0cd7-caba-4539-8cfe-b170ccbeb2a9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("850fa773-a0b3-44bb-93d7-6f437b7355c0"),
				CurveCenterPosition = new Point(179, 77),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("850fa773-a0b3-44bb-93d7-6f437b7355c0"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e95404e7-71a4-4b42-933f-acd4655c1f91"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("65a670a6-1bce-45a9-920d-0140706761af"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("f600f5ff-b22a-45b2-ab58-0b00e9df32c4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("850fa773-a0b3-44bb-93d7-6f437b7355c0"),
				CurveCenterPosition = new Point(286, 79),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("850fa773-a0b3-44bb-93d7-6f437b7355c0"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("65a670a6-1bce-45a9-920d-0140706761af"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("066282c0-60a9-4005-90f9-3fd0c266b383"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("f6b945f2-0449-4c56-8851-f4aeb1adf7cb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("850fa773-a0b3-44bb-93d7-6f437b7355c0"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("850fa773-a0b3-44bb-93d7-6f437b7355c0"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9b1e9fe5-9d7f-4610-9307-f78b1f275ed5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d3bc1c50-6791-44a6-8787-bc921c8dd338"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("b48114f7-e514-4ad0-9559-d9af00de75e3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("b1abd604-524b-4216-8a49-98d3efcbfbe7"),
				CreatedInSchemaUId = new Guid("850fa773-a0b3-44bb-93d7-6f437b7355c0"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("850fa773-a0b3-44bb-93d7-6f437b7355c0"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ff6dedab-84ec-441b-a055-fa3744508ac8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("18dc63af-181a-492e-86cf-21d2ed74f47b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("064c860f-9885-4106-8fe4-6fab26023258"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("850fa773-a0b3-44bb-93d7-6f437b7355c0"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("850fa773-a0b3-44bb-93d7-6f437b7355c0"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(1257, 505),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("1f9c226a-7403-4b31-a6e1-94b0ed9a3c9c"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("064c860f-9885-4106-8fe4-6fab26023258"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("850fa773-a0b3-44bb-93d7-6f437b7355c0"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("850fa773-a0b3-44bb-93d7-6f437b7355c0"),
				Name = @"Lane1",
				Position = new Point(29, 328),
				Size = new Size(1228, 177),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("2fe8e6ee-f8dd-4f36-a625-6c18106e005e"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("064c860f-9885-4106-8fe4-6fab26023258"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("850fa773-a0b3-44bb-93d7-6f437b7355c0"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("850fa773-a0b3-44bb-93d7-6f437b7355c0"),
				Name = @"Lane2",
				Position = new Point(29, 164),
				Size = new Size(1228, 159),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaLane CreateLane3Lane() {
			ProcessSchemaLane schemaLane3 = new ProcessSchemaLane(this) {
				UId = new Guid("57f878bf-bbea-4ac1-a452-f7ea08fbe495"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("064c860f-9885-4106-8fe4-6fab26023258"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("b1abd604-524b-4216-8a49-98d3efcbfbe7"),
				CreatedInSchemaUId = new Guid("850fa773-a0b3-44bb-93d7-6f437b7355c0"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("850fa773-a0b3-44bb-93d7-6f437b7355c0"),
				Name = @"Lane3",
				Position = new Point(29, 0),
				Size = new Size(1228, 159),
				UseBackgroundMode = false
			};
			return schemaLane3;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("60d3cf02-c976-4370-a070-acd40baab2f8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1f9c226a-7403-4b31-a6e1-94b0ed9a3c9c"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("850fa773-a0b3-44bb-93d7-6f437b7355c0"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("850fa773-a0b3-44bb-93d7-6f437b7355c0"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(371, 133),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e95404e7-71a4-4b42-933f-acd4655c1f91"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("60d3cf02-c976-4370-a070-acd40baab2f8"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("850fa773-a0b3-44bb-93d7-6f437b7355c0"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("850fa773-a0b3-44bb-93d7-6f437b7355c0"),
				Name = @"StartMessage1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("066282c0-60a9-4005-90f9-3fd0c266b383"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("60d3cf02-c976-4370-a070-acd40baab2f8"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("850fa773-a0b3-44bb-93d7-6f437b7355c0"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("850fa773-a0b3-44bb-93d7-6f437b7355c0"),
				Name = @"ScriptTask2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(253, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,147,91,111,226,48,16,133,159,131,196,127,112,243,228,104,75,68,4,45,84,180,72,44,165,21,82,169,104,83,246,221,141,103,119,173,38,118,228,75,33,90,241,223,215,118,168,10,229,210,151,200,178,157,115,190,153,51,158,147,63,16,167,149,26,209,130,241,5,103,122,66,153,142,83,208,15,66,188,153,50,205,254,66,65,22,83,138,57,44,209,189,97,20,135,189,222,85,247,242,138,36,173,172,79,161,213,133,78,210,234,39,23,73,171,119,217,7,232,118,94,47,218,164,19,70,209,160,217,96,191,17,158,170,71,88,70,232,95,179,17,48,174,209,92,40,166,153,224,232,6,181,237,141,224,157,72,164,32,135,76,63,146,2,236,174,221,11,156,87,234,55,241,66,129,28,11,206,237,218,254,21,185,211,120,44,114,83,112,124,103,120,102,215,134,107,28,126,200,90,95,127,229,78,138,2,135,79,134,101,111,35,74,103,192,205,84,67,17,250,67,162,54,226,206,223,33,126,250,199,147,21,100,70,67,154,145,156,200,107,11,60,196,17,26,162,118,93,64,176,71,250,13,234,46,235,140,172,246,72,79,163,238,178,6,91,205,251,134,249,71,50,112,124,107,247,153,187,136,111,137,38,169,48,50,131,120,100,249,222,225,89,44,93,204,53,223,47,146,27,216,98,59,255,88,185,20,215,8,114,5,190,1,46,173,177,145,210,13,137,147,181,32,199,213,239,65,191,84,37,208,45,139,107,55,65,67,28,218,129,155,9,106,114,112,66,83,26,70,117,20,120,71,251,236,198,15,92,60,41,74,93,185,118,248,8,142,251,61,8,66,235,169,189,101,170,204,73,229,45,21,246,226,123,232,99,82,110,90,121,178,130,26,126,91,16,159,232,167,127,45,155,204,149,251,253,103,229,34,250,82,112,253,56,54,165,28,122,123,222,103,196,233,11,172,244,78,79,206,15,84,224,181,214,129,205,169,217,144,160,141,228,72,75,3,131,255,245,28,171,182,218,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediatePageLoadCompleteIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("65a670a6-1bce-45a9-920d-0140706761af"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("60d3cf02-c976-4370-a070-acd40baab2f8"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("850fa773-a0b3-44bb-93d7-6f437b7355c0"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("850fa773-a0b3-44bb-93d7-6f437b7355c0"),
				Name = @"IntermediatePageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a8ad30a8-0a32-4f7b-8daa-09ae1e2603a5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2fe8e6ee-f8dd-4f36-a625-6c18106e005e"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("850fa773-a0b3-44bb-93d7-6f437b7355c0"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("850fa773-a0b3-44bb-93d7-6f437b7355c0"),
				Name = @"EventSubProcess1",
				Position = new Point(36, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(178, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("9b1e9fe5-9d7f-4610-9307-f78b1f275ed5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a8ad30a8-0a32-4f7b-8daa-09ae1e2603a5"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("850fa773-a0b3-44bb-93d7-6f437b7355c0"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"QuickAddMenuSettingsEditChange",
				ModifiedInSchemaUId = new Guid("850fa773-a0b3-44bb-93d7-6f437b7355c0"),
				Name = @"StartMessage2",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d3bc1c50-6791-44a6-8787-bc921c8dd338"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a8ad30a8-0a32-4f7b-8daa-09ae1e2603a5"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("850fa773-a0b3-44bb-93d7-6f437b7355c0"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("850fa773-a0b3-44bb-93d7-6f437b7355c0"),
				Name = @"ScriptTask1",
				Position = new Point(77, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,146,205,78,195,48,16,132,207,137,148,119,176,114,114,4,178,202,185,165,82,85,218,42,135,86,129,240,115,182,156,165,88,36,54,216,235,166,8,245,221,113,26,10,137,170,210,11,23,107,181,107,237,204,55,90,249,76,104,106,87,80,39,228,51,10,3,169,144,100,218,74,148,90,145,107,50,24,250,222,134,27,114,235,164,120,5,68,169,214,54,45,252,36,227,107,96,55,28,121,174,157,17,192,38,2,229,6,238,116,205,22,128,247,31,111,80,76,117,233,42,245,200,75,7,163,133,147,197,152,198,251,45,147,162,88,130,114,249,207,182,56,57,168,88,40,65,224,138,87,224,21,124,47,80,80,147,124,223,164,15,22,204,84,43,229,107,239,45,105,166,172,149,160,115,167,132,175,157,66,26,31,204,199,73,251,101,110,116,213,23,78,17,170,184,29,62,189,128,129,211,182,88,106,103,239,142,151,180,213,97,25,55,222,26,130,161,253,56,90,41,110,191,173,54,52,210,199,250,75,195,102,91,16,14,33,23,188,228,102,228,67,30,211,132,140,201,160,13,61,56,226,62,3,222,39,95,242,237,17,247,223,224,255,76,222,71,15,58,247,115,38,130,139,171,97,131,187,107,158,211,7,229,141,117,110,169,131,122,121,168,154,3,218,69,161,1,116,70,17,52,14,124,35,10,191,0,51,240,231,125,220,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ebf4e7d9-0aa3-4a4d-bfe2-fa2b2be482a7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("57f878bf-bbea-4ac1-a452-f7ea08fbe495"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("b1abd604-524b-4216-8a49-98d3efcbfbe7"),
				CreatedInSchemaUId = new Guid("850fa773-a0b3-44bb-93d7-6f437b7355c0"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("850fa773-a0b3-44bb-93d7-6f437b7355c0"),
				Name = @"EventSubProcess3",
				Position = new Point(36, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(187, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage3StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ff6dedab-84ec-441b-a055-fa3744508ac8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ebf4e7d9-0aa3-4a4d-bfe2-fa2b2be482a7"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("b1abd604-524b-4216-8a49-98d3efcbfbe7"),
				CreatedInSchemaUId = new Guid("850fa773-a0b3-44bb-93d7-6f437b7355c0"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SysAdminUnitEditChange",
				ModifiedInSchemaUId = new Guid("850fa773-a0b3-44bb-93d7-6f437b7355c0"),
				Name = @"StartMessage3",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskSysAdminUnitEditChangeScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("18dc63af-181a-492e-86cf-21d2ed74f47b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ebf4e7d9-0aa3-4a4d-bfe2-fa2b2be482a7"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("b1abd604-524b-4216-8a49-98d3efcbfbe7"),
				CreatedInSchemaUId = new Guid("850fa773-a0b3-44bb-93d7-6f437b7355c0"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("850fa773-a0b3-44bb-93d7-6f437b7355c0"),
				Name = @"ScriptTaskSysAdminUnitEditChange",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,69,206,193,10,194,48,16,4,208,115,11,253,135,216,83,11,146,31,144,30,138,22,241,32,138,81,239,177,89,203,74,186,129,184,105,17,241,223,141,21,244,60,195,155,25,180,23,96,144,55,102,119,185,137,74,236,117,7,82,61,238,181,233,145,78,132,220,196,80,158,181,13,176,200,82,188,22,255,242,172,18,20,172,45,159,89,154,12,63,38,26,4,163,88,7,52,255,174,60,58,197,30,169,43,202,50,50,201,180,178,210,172,149,11,190,5,89,183,140,3,28,220,40,21,240,210,217,208,211,52,89,228,241,202,214,153,96,161,153,172,124,254,53,63,202,43,75,61,112,240,36,216,199,119,111,221,162,224,81,202,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b22cedfd-39cd-46e5-b5c4-6f7cd276eb74"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0da240a7-6b5c-4da2-ab4b-e82287d805bd"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("1a594b2c-3502-4669-976e-da9368efcf56"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0e1ff5d4-e0e1-4b5e-bbeb-c2e0ed6ca410"),
				Name = "System.Collections",
				Alias = "",
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new QuickAddMenuItemEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("850fa773-a0b3-44bb-93d7-6f437b7355c0"));
		}

		#endregion

	}

	#endregion

}

