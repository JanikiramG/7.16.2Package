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

	#region Class: SysModuleEntitiesEditPageSchema

	/// <exclude/>
	public class SysModuleEntitiesEditPageSchema : Terrasoft.WebApp.BaseEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.LookupEdit _objectLookupEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit ObjectLookupEdit {
			get {
				return _objectLookupEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _typeColumnComboBoxEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit TypeColumnComboBoxEdit {
			get {
				return _typeColumnComboBoxEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public SysModuleEntitiesEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SysModuleEntitiesEditPageSchema(SysModuleEntitiesEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateCustomControls() {
			CustomControls.FitHeightByContent = true;
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("b9b78fd8-abb3-439f-9132-fba839de480d");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("b9b78fd8-abb3-439f-9132-fba839de480d");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("b9b78fd8-abb3-439f-9132-fba839de480d");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("b9b78fd8-abb3-439f-9132-fba839de480d");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("b9b78fd8-abb3-439f-9132-fba839de480d");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("b9b78fd8-abb3-439f-9132-fba839de480d");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("b9b78fd8-abb3-439f-9132-fba839de480d");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("b9b78fd8-abb3-439f-9132-fba839de480d");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b9b78fd8-abb3-439f-9132-fba839de480d");
			RealUId = new Guid("b9b78fd8-abb3-439f-9132-fba839de480d");
			Name = "SysModuleEntitiesEditPage";
			ParentSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysModuleEntitiesEditPageEventsProcessSchema();
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
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.MoveItem(0, CustomControls);
			CustomControls.InsertItem(0, CreateObjectLookupEdit());
			CustomControls.InsertItem(1, CreateTypeColumnComboBoxEdit());
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

		protected virtual EmbeddedProcessSchema CreateSysModuleEntitiesEditPageEventsProcessSchema() {
			var schema = new SysModuleEntitiesEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateObjectLookupEdit() {
			_objectLookupEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_objectLookupEdit.UId = new Guid("03ec43ea-c865-427f-8376-182e2262c301");
			_objectLookupEdit.Name = "ObjectLookupEdit";
			_objectLookupEdit.CreatedInSchemaUId = new Guid("b9b78fd8-abb3-439f-9132-fba839de480d");
			_objectLookupEdit.ModifiedInSchemaUId = new Guid("b9b78fd8-abb3-439f-9132-fba839de480d");
			_objectLookupEdit.CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8");
			_objectLookupEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_objectLookupEdit.Tag = "";
			_objectLookupEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_objectLookupEdit.Image = new ControlImage {};
			_objectLookupEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_objectLookupEdit.Required = true;
			_objectLookupEdit.LookupSchemaUId = new Guid("90fa6d02-3e93-45d6-a72b-58dcffa411ae");
			return _objectLookupEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateTypeColumnComboBoxEdit() {
			_typeColumnComboBoxEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_typeColumnComboBoxEdit.UId = new Guid("156cadb4-ad6b-4094-adfb-f58f6dd17edc");
			_typeColumnComboBoxEdit.Name = "TypeColumnComboBoxEdit";
			_typeColumnComboBoxEdit.CreatedInSchemaUId = new Guid("b9b78fd8-abb3-439f-9132-fba839de480d");
			_typeColumnComboBoxEdit.ModifiedInSchemaUId = new Guid("b9b78fd8-abb3-439f-9132-fba839de480d");
			_typeColumnComboBoxEdit.CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8");
			_typeColumnComboBoxEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_typeColumnComboBoxEdit.Tag = "";
			_typeColumnComboBoxEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_typeColumnComboBoxEdit.Image = new ControlImage {};
			_typeColumnComboBoxEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _typeColumnComboBoxEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("9c762665-90ad-497b-ac4b-45bb729630a1");
			DataSource.ModifiedInSchemaUId = new Guid("b9b78fd8-abb3-439f-9132-fba839de480d");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("cc26a23d-93ea-44df-942c-4c3a0a0e76ec");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("b9b78fd8-abb3-439f-9132-fba839de480d");
				column.ModifiedInSchemaUId = new Guid("b9b78fd8-abb3-439f-9132-fba839de480d");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("b4581491-8e86-40c5-a52b-a478f657ba2b");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("b9b78fd8-abb3-439f-9132-fba839de480d");
				column.ModifiedInSchemaUId = new Guid("b9b78fd8-abb3-439f-9132-fba839de480d");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("7d6baee6-2bf1-4885-b1e0-4b1190f33678");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("b9b78fd8-abb3-439f-9132-fba839de480d");
				column.ModifiedInSchemaUId = new Guid("b9b78fd8-abb3-439f-9132-fba839de480d");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("a72fd8ed-34bd-4612-91c3-9981e5c6affd");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("b9b78fd8-abb3-439f-9132-fba839de480d");
				column.ModifiedInSchemaUId = new Guid("b9b78fd8-abb3-439f-9132-fba839de480d");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("ba3c93fa-edaf-4cf3-9ad2-c3ddf2714513");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("b9b78fd8-abb3-439f-9132-fba839de480d");
				column.ModifiedInSchemaUId = new Guid("b9b78fd8-abb3-439f-9132-fba839de480d");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3107ef98-a02e-4ea8-809a-67dc3025ef4a");
			if (column != null) {
				column.UId = new Guid("6f103186-5682-4f0d-ba2c-c1759688360a");
				column.Name = @"TypeColumnUId";
				column.CreatedInSchemaUId = new Guid("b9b78fd8-abb3-439f-9132-fba839de480d");
				column.ModifiedInSchemaUId = new Guid("b9b78fd8-abb3-439f-9132-fba839de480d");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("1ef4d43b-a471-41c3-ac26-7e52b7cf4411");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("b9b78fd8-abb3-439f-9132-fba839de480d");
				column.ModifiedInSchemaUId = new Guid("b9b78fd8-abb3-439f-9132-fba839de480d");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("0c59594b-490a-4b55-a564-5841cfae3c19");
			if (column != null) {
				column.UId = new Guid("c5b19cd7-a294-48c6-983b-18de616528bd");
				column.Name = @"SysEntitySchemaUId";
				column.CreatedInSchemaUId = new Guid("b9b78fd8-abb3-439f-9132-fba839de480d");
				column.ModifiedInSchemaUId = new Guid("b9b78fd8-abb3-439f-9132-fba839de480d");
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
			return new SysModuleEntitiesEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new SysModuleEntitiesEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b9b78fd8-abb3-439f-9132-fba839de480d"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysModuleEntitiesEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleEntitiesEditPageEventsProcess

	/// <exclude/>
	public class SysModuleEntitiesEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.SysModuleEntitiesEditPageSchemaUserControl
	{

		public SysModuleEntitiesEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysModuleEntitiesEditPageEventsProcess";
			SchemaUId = new Guid("b9b78fd8-abb3-439f-9132-fba839de480d");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("b9b78fd8-abb3-439f-9132-fba839de480d");
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
					SchemaElementUId = new Guid("96155d5b-0c09-4815-ab21-54605d7d09e8"),
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
					SchemaElementUId = new Guid("077a8703-471e-4ec7-b908-6d70c495e914"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("4906b83c-c528-49b4-91e4-dbee5847305a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
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
					SchemaElementUId = new Guid("80222448-966a-44d4-af85-f2b8f2c083d7"),
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
					SchemaElementUId = new Guid("75f3c95d-4ab0-4c81-9a53-29f46079bf9a"),
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
					SchemaElementUId = new Guid("a2ab535c-f31a-4976-ba12-60d0ccabfc95"),
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
					SchemaElementUId = new Guid("92238ecc-2cd2-4f53-9e5a-04368f0171e6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask2Execute,
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
					SchemaElementUId = new Guid("4ccf9412-c50f-4e7f-8b62-1fc9fe60b6f2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("3f43d162-427d-451c-b0be-012cc58aed92"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3Execute,
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
					SchemaElementUId = new Guid("02779e5d-04a3-4561-b55b-5f33f9c8de64"),
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
					SchemaElementUId = new Guid("f11b2622-3e80-4bc6-9440-a565eb062e58"),
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
					SchemaElementUId = new Guid("ad496b99-dbdc-45db-ab5a-0a349b1920c9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask4Execute,
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
					SchemaElementUId = new Guid("79e21fb3-8fa9-43f2-a33f-b5f0611e2383"),
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
					SchemaElementUId = new Guid("f94aa907-320b-4266-8e60-7c1d5af91823"),
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
					SchemaElementUId = new Guid("37922b80-c8be-4e24-9e30-ff179975b11a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask5Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[StartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2 };
			FlowElements[ScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask2 };
			FlowElements[IntermediateThrowMessageEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent2 };
			FlowElements[ScriptTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3 };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[StartMessage3.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3 };
			FlowElements[ScriptTask4.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask4 };
			FlowElements[EventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4 };
			FlowElements[StartMessage4.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage4 };
			FlowElements[ScriptTask5.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask5 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "IntermediateThrowMessageEvent1":
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
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent2");
						break;
					case "IntermediateThrowMessageEvent2":
						e.Context.QueueTasks.Enqueue("ScriptTask3");
						break;
					case "ScriptTask3":
						break;
					case "EventSubProcess3":
						break;
					case "StartMessage3":
						e.Context.QueueTasks.Enqueue("ScriptTask4");
						break;
					case "ScriptTask4":
						break;
					case "EventSubProcess4":
						break;
					case "StartMessage4":
						e.Context.QueueTasks.Enqueue("ScriptTask5");
						break;
					case "ScriptTask5":
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
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = IntermediateThrowMessageEvent1.Execute(context);
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
				case "IntermediateThrowMessageEvent2":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowMessageEvent2.Execute(context);
					break;
				case "ScriptTask3":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3";
					result = ScriptTask3.Execute(context, ScriptTask3Execute);
					break;
				case "EventSubProcess3":
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
				case "EventSubProcess4":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage4":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage4";
					result = StartMessage4.Execute(context);
					break;
				case "ScriptTask5":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask5";
					result = ScriptTask5.Execute(context, ScriptTask5Execute);
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

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			Page.ObjectLookupEdit.PrepareLookupFilter += delegate (object sender, LookupEditEventArgs e) {
				Collection<Dictionary<string, object>> filters = e.Filters;
				filters.Add(new Dictionary<string, object> { 
					{"comparisonType", FilterComparisonType.Equal}, 
					{"leftExpressionColumnPath", "SysWorkspace.Id"},
					{"useDisplayValue", false}, 
					{"rightExpressionParameterValues", new object[] {Page.UserConnection.Workspace.Id}}});
				filters.Add(new Dictionary<string, object> { 
					{"comparisonType", FilterComparisonType.Equal}, 
					{"leftExpressionColumnPath", "ManagerName"},
					{"useDisplayValue", false}, 
					{"rightExpressionParameterValues", new object[] {"EntitySchemaManager"}}});
			};
			return true;
		}

		public virtual bool ScriptTask2Execute(ProcessExecutingContext context) {
			//var sysModuleInWorkspaceId = Guid.Parse(Page.GetParameterValue("ParentEntityId") as string);
			//SelectedModuleId = GetSysModuleId(sysModuleInWorkspaceId);
			return true;
		}

		public virtual bool ScriptTask3Execute(ProcessExecutingContext context) {
			//SelectedModuleEntityId = GetSysModuleEntityId(SelectedModuleId);
			if (Page.DataSource.Rows.Count > 0) {
				var entity = Page.DataSource.Rows[0];
				var entitySchemaId = entity.GetTypedColumnValue<Guid>("SysEntitySchemaUId"); 
				var typeColumnUId = entity.GetTypedColumnValue<Guid>("TypeColumnUId");
				
				FillTypeColumnEdit(entitySchemaId);
				if (entitySchemaId != Guid.Empty) {
					var schema = UserConnection.EntitySchemaManager.GetInstanceByUId(entitySchemaId);
					Page.ObjectLookupEdit.SetValueAndText(schema.UId, schema.Caption);
				}
				if (entitySchemaId != Guid.Empty && typeColumnUId != Guid.Empty) {
					var schema = UserConnection.EntitySchemaManager.GetInstanceByUId(entitySchemaId);
					var typeColumn = schema.Columns.GetByUId(typeColumnUId);
					Page.TypeColumnComboBoxEdit.SetValueAndText(typeColumn.UId, typeColumn.Caption);
				}
				
				/*var pageSchemaColumn = entity.Schema.Columns.GetByName("SysModuleGrid");
				var moduleGridId = entity.GetTypedColumnValue<Guid>(pageSchemaColumn.ColumnValueName);
				var entitySchemaManager = Page.Schema.SchemaManagerProvider.GetManager("EntitySchemaManager") as Terrasoft.Core.Entities.EntitySchemaManager;
				var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, "SysModuleGrid");
				var pageSchemaColumnName = entitySchemaQuery.AddColumn("SysPageSchemaUId").Name;
				var moduleEntitySchemaColumnName = entitySchemaQuery.AddColumn("SysModuleEntity.Id").Name;
				var entitySchemaColumnName = entitySchemaQuery.AddColumn("SysModuleEntity.SysEntitySchemaUId").Name;
				var typeColumnUIdColumnName = entitySchemaQuery.AddColumn("SysModuleEntity.TypeColumnUId").Name;
				entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
					entitySchemaQuery.RootSchema.GetPrimaryColumnName(), moduleGridId));
				var entities = entitySchemaQuery.GetEntityCollection(UserConnection);
				var pageSchemaId = entities[0].GetTypedColumnValue<Guid>(pageSchemaColumnName);
				var entitySchemaId = entities[0].GetTypedColumnValue<Guid>(entitySchemaColumnName); 
				var typeColumnUId = entities[0].GetTypedColumnValue<Guid>(typeColumnUIdColumnName);
				Guid moduleEnityId = entities[0].GetTypedColumnValue<Guid>(moduleEntitySchemaColumnName);
				Page.SysPageSchemaEdit.SetValueAndText(pageSchemaId, GetSchemaDisplayValue(pageSchemaId));
				Page.SysEntitySchemaEdit.SetValueAndText(entitySchemaId, GetSchemaDisplayValue(entitySchemaId));
				SelectedPageSchemaId = pageSchemaId;
				SelectedDetailEntitySchemaId = entitySchemaId;
				FillTypeColumnEdit(entitySchemaId);
				if (entitySchemaId != Guid.Empty && typeColumnUId != Guid.Empty) {
					var schema = UserConnection.EntitySchemaManager.GetInstanceByUId(entitySchemaId);
					var typeColumn = schema.Columns.GetByUId(typeColumnUId);
					Page.TypeColumnEdit.SetValueAndText(typeColumn.UId, typeColumn.Caption);
				}
				Page.SysModuleEditPageContainer.PageInstance.Process.SetPropertyValue("SysModuleEntityId", moduleEnityId);*/
			}/*
			if (!IsNew && !IsCopy) {
				Page.DetailParentAsscContainer.PageInstance.Process.SetPropertyValue("SelectedNodePrimaryColumnValue", EntityPrimaryColumnValue);
				Page.SysModuleEditPageContainer.PageInstance.Process.SetPropertyValue("SelectedNodePrimaryColumnValue", EntityPrimaryColumnValue);
			}
			Page.DetailParentAsscContainer.PageInstance.ThrowEvent("GridPageRefreshRow");
			Page.SysModuleEditPageContainer.PageInstance.ThrowEvent("GridPageRefreshRow");
			Page.OKButton.AjaxEvents.Click.CausesValidation = true;
			var aspPage = Page.AspPage as Terrasoft.UI.WebControls.Page;
			aspPage.CustomData["SysModule_activeDataSource"] = Page.DataSource.ClientID;
			Page.CaptionEdit.LocalizableText = 
				Terrasoft.Configuration.CommonUtilities.GetLocalizableValue(UserConnection, Page.DataSource.Schema.Name, "Caption", Page.DataSource.ActiveRowPrimaryColumnValue);*/
			return true;
		}

		public virtual bool ScriptTask4Execute(ProcessExecutingContext context) {
			var entity = Page.DataSource.ActiveRow;
			if (Page.TypeColumnComboBoxEdit.SelectedItem != null && Page.TypeColumnComboBoxEdit.SelectedItem.Value != null) {
				var typeColumnValue = string.IsNullOrEmpty(Page.TypeColumnComboBoxEdit.SelectedItem.Value.ToString()) ? Guid.Empty :
					new Guid(Page.TypeColumnComboBoxEdit.SelectedItem.Value.ToString());
				entity.SetColumnValue("TypeColumnUId", typeColumnValue);
			} else {
				entity.SetColumnValue("TypeColumnUId", Guid.Empty);
			}
			return true;
		}

		public virtual bool ScriptTask5Execute(ProcessExecutingContext context) {
			var entity = Page.DataSource.ActiveRow;
			Page.TypeColumnComboBoxEdit.ClearItems();
			if (Page.ObjectLookupEdit.Value != null && (Guid)Page.ObjectLookupEdit.Value != Guid.Empty) {
				var objectColumnValue = string.IsNullOrEmpty(Page.ObjectLookupEdit.Value.ToString()) ? Guid.Empty :
					new Guid(Page.ObjectLookupEdit.Value.ToString());
				entity.SetColumnValue("SysEntitySchemaUId", objectColumnValue);
				FillTypeColumnEdit(objectColumnValue);
			} else {
				entity.SetColumnValue("SysEntitySchemaUId", Guid.Empty);
			}
			Page.TypeColumnComboBoxEdit.SetValueAndText(null, null);
			return true;
		}

		public virtual void FillTypeColumnEdit(Guid entitySchemaId) {
			var entitySchemaManager = Page.Schema.SchemaManagerProvider.GetManager("EntitySchemaManager");
			var  entity = entitySchemaManager.GetInstanceByUId(entitySchemaId) as EntitySchema;
			foreach(EntitySchemaColumn item in entity.Columns) {
				var columnTypeName = item.DataValueType.ToString();
				switch(columnTypeName){
				case "Terrasoft.Core.GuidDataValueType":
				case "Terrasoft.Core.LookupDataValueType":
				case "Terrasoft.Core.MultiLookupDataValueType":
					Page.TypeColumnComboBoxEdit.AddItem(item.UId, item.Caption);
					continue;
				}
			}
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Init":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
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
					case "TypeColumnComboBoxEditChange":
							if (ActivatedEventElements.Contains("StartMessage3")) {
							context.QueueTasks.Enqueue("StartMessage3");
						}
						break;
					case "ObjectLookupEditChange":
							if (ActivatedEventElements.Contains("StartMessage4")) {
							context.QueueTasks.Enqueue("StartMessage4");
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

	#region Class: SysModuleEntitiesEditPageEventsProcess

	/// <exclude/>
	public class SysModuleEntitiesEditPageEventsProcess : SysModuleEntitiesEditPageEventsProcess<Terrasoft.WebApp.SysModuleEntitiesEditPageSchemaUserControl>
	{

		public SysModuleEntitiesEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysModuleEntitiesEditPageSchemaUserControl

	/// <exclude/>
	public partial class SysModuleEntitiesEditPageSchemaUserControl : Terrasoft.WebApp.BaseEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.LookupEdit ObjectLookupEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("ObjectLookupEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit TypeColumnComboBoxEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("TypeColumnComboBoxEdit", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			ObjectLookupEdit.AjaxEvents.Change.Event += ObjectLookupEditChange;
			TypeColumnComboBoxEdit.AjaxEvents.Change.Event += TypeColumnComboBoxEditChange;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			ObjectLookupEdit.AjaxEvents.Change.Event -= ObjectLookupEditChange;
			TypeColumnComboBoxEdit.AjaxEvents.Change.Event -= TypeColumnComboBoxEditChange;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (SysModuleEntitiesEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SysModuleEntitiesEditPageEventsProcess(UserConnection);
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

		public virtual void ObjectLookupEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("ObjectLookupEditChange");
		}

		public virtual void TypeColumnComboBoxEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("TypeColumnComboBoxEditChange");
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
			SchemaName = "SysModuleEntitiesEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleEntitiesEditPageEventsProcessSchema

	/// <exclude/>
	public class SysModuleEntitiesEditPageEventsProcessSchema : Terrasoft.WebApp.BaseEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public SysModuleEntitiesEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysModuleEntitiesEditPageEventsProcessSchema(SysModuleEntitiesEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysModuleEntitiesEditPageEventsProcess";
			UId = new Guid("8855db24-1891-490d-953c-f8e0e913804a");
			CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1");
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
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaEventSubProcess eventsubprocess4 = CreateEventSubProcess4EventSubProcess();
			FlowElements.Add(eventsubprocess4);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			eventsubprocess1.FlowElements.Add(startmessage1);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			eventsubprocess1.FlowElements.Add(scripttask1);
			ProcessSchemaStartMessageEvent startmessage2 = CreateStartMessage2StartMessageEvent();
			eventsubprocess2.FlowElements.Add(startmessage2);
			ProcessSchemaScriptTask scripttask2 = CreateScriptTask2ScriptTask();
			eventsubprocess2.FlowElements.Add(scripttask2);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent2 = CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent();
			eventsubprocess2.FlowElements.Add(intermediatethrowmessageevent2);
			ProcessSchemaScriptTask scripttask3 = CreateScriptTask3ScriptTask();
			eventsubprocess2.FlowElements.Add(scripttask3);
			ProcessSchemaStartMessageEvent startmessage3 = CreateStartMessage3StartMessageEvent();
			eventsubprocess3.FlowElements.Add(startmessage3);
			ProcessSchemaScriptTask scripttask4 = CreateScriptTask4ScriptTask();
			eventsubprocess3.FlowElements.Add(scripttask4);
			ProcessSchemaStartMessageEvent startmessage4 = CreateStartMessage4StartMessageEvent();
			eventsubprocess4.FlowElements.Add(startmessage4);
			ProcessSchemaScriptTask scripttask5 = CreateScriptTask5ScriptTask();
			eventsubprocess4.FlowElements.Add(scripttask5);
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
				UId = new Guid("bfc7c34f-3566-489b-bdaf-93a9725c37f6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				CurveCenterPosition = new Point(175, 82),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("077a8703-471e-4ec7-b908-6d70c495e914"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4906b83c-c528-49b4-91e4-dbee5847305a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("ca6b7fa2-087d-42e5-bfb4-73f7fd63c405"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				CurveCenterPosition = new Point(272, 84),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4906b83c-c528-49b4-91e4-dbee5847305a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("80222448-966a-44d4-af85-f2b8f2c083d7"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("abf0d32b-e17b-4125-afdc-4af12e48b23c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				CurveCenterPosition = new Point(168, 264),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a2ab535c-f31a-4976-ba12-60d0ccabfc95"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("92238ecc-2cd2-4f53-9e5a-04368f0171e6"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("5105422c-1169-49d3-9db1-201acced3e5f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				CurveCenterPosition = new Point(292, 278),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("92238ecc-2cd2-4f53-9e5a-04368f0171e6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4ccf9412-c50f-4e7f-8b62-1fc9fe60b6f2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("5ce1e908-3e90-423b-bf27-9d907d0664e8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				CurveCenterPosition = new Point(378, 276),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4ccf9412-c50f-4e7f-8b62-1fc9fe60b6f2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3f43d162-427d-451c-b0be-012cc58aed92"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("5f119d53-b1b1-478e-ae30-47e5643561d6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f11b2622-3e80-4bc6-9440-a565eb062e58"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ad496b99-dbdc-45db-ab5a-0a349b1920c9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("d66fbf9e-c785-44fc-b615-99a89321b7f3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f94aa907-320b-4266-8e60-7c1d5af91823"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("37922b80-c8be-4e24-9e30-ff179975b11a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("b880bfda-e082-4f52-aee6-278b056f967d"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(893, 684),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("0c301692-8cf2-4b1d-84d4-0463b1e306a5"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("b880bfda-e082-4f52-aee6-278b056f967d"),
				CreatedInOwnerSchemaUId = new Guid("b9b78fd8-abb3-439f-9132-fba839de480d"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 328),
				Size = new Size(864, 356),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("156b4ef7-ebde-43e0-ab1b-be5ac67f0ce8"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("b880bfda-e082-4f52-aee6-278b056f967d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				Name = @"Lane2",
				Position = new Point(29, 164),
				Size = new Size(864, 159),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaLane CreateLane3Lane() {
			ProcessSchemaLane schemaLane3 = new ProcessSchemaLane(this) {
				UId = new Guid("52fe13f9-919c-4c6f-ad64-53ffbb4c1e2e"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("b880bfda-e082-4f52-aee6-278b056f967d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				Name = @"Lane3",
				Position = new Point(29, 0),
				Size = new Size(864, 159),
				UseBackgroundMode = false
			};
			return schemaLane3;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("96155d5b-0c09-4815-ab21-54605d7d09e8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0c301692-8cf2-4b1d-84d4-0463b1e306a5"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(336, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("077a8703-471e-4ec7-b908-6d70c495e914"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("96155d5b-0c09-4815-ab21-54605d7d09e8"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				Name = @"StartMessage1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("4906b83c-c528-49b4-91e4-dbee5847305a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("96155d5b-0c09-4815-ab21-54605d7d09e8"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("80222448-966a-44d4-af85-f2b8f2c083d7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("96155d5b-0c09-4815-ab21-54605d7d09e8"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				Name = @"ScriptTask1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(232, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,81,75,75,195,64,16,62,87,240,63,12,57,181,24,242,7,250,128,210,70,16,124,4,234,227,32,30,214,100,146,174,221,236,198,153,141,26,66,254,187,155,108,208,122,240,40,120,88,22,134,239,53,223,36,162,192,232,230,249,5,83,123,105,204,161,174,226,76,218,40,33,172,4,161,159,156,75,101,145,224,108,9,25,42,44,132,69,152,154,129,1,140,58,67,10,225,155,26,191,161,182,107,42,24,112,6,237,233,201,100,99,148,114,80,105,244,98,43,135,95,80,179,96,75,82,23,33,120,157,213,10,242,193,132,97,9,24,121,67,158,59,246,56,142,214,89,54,213,248,14,191,75,64,11,14,63,105,131,212,148,46,187,100,163,111,155,10,131,16,188,220,230,199,56,138,95,107,161,186,112,228,40,204,109,252,81,17,50,59,117,23,185,46,117,34,236,222,177,131,93,195,15,134,14,92,137,20,163,139,44,232,66,207,169,25,183,146,43,37,154,123,161,234,222,40,23,138,241,75,147,100,177,63,18,77,4,137,18,93,144,1,205,14,222,239,227,195,63,62,65,155,244,135,184,227,62,168,214,190,176,232,216,183,235,186,217,63,105,228,74,104,23,150,174,221,62,127,213,70,16,107,43,109,179,75,247,88,138,209,47,24,43,232,220,35,180,53,105,176,84,227,252,19,108,209,23,103,195,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("75f3c95d-4ab0-4c81-9a53-29f46079bf9a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0c301692-8cf2-4b1d-84d4-0463b1e306a5"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 184),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(417, 158),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a2ab535c-f31a-4976-ba12-60d0ccabfc95"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("75f3c95d-4ab0-4c81-9a53-29f46079bf9a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				Name = @"StartMessage2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("92238ecc-2cd2-4f53-9e5a-04368f0171e6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("75f3c95d-4ab0-4c81-9a53-29f46079bf9a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				Name = @"ScriptTask2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,205,177,10,194,64,16,132,225,94,240,29,150,84,151,38,247,0,193,82,66,10,33,16,208,122,201,13,225,240,188,200,238,94,32,111,111,20,177,178,252,139,153,207,251,149,133,116,211,203,18,74,66,159,111,139,220,245,201,19,250,64,39,234,74,12,205,192,162,112,3,207,104,58,216,94,252,128,65,174,156,10,92,181,55,178,157,179,69,219,250,80,213,196,74,106,18,243,92,183,199,131,247,35,18,38,67,248,2,159,87,216,248,19,131,251,175,191,215,2,43,146,201,164,160,125,1,206,43,210,17,170,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("4ccf9412-c50f-4e7f-8b62-1fc9fe60b6f2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("75f3c95d-4ab0-4c81-9a53-29f46079bf9a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				Name = @"IntermediateThrowMessageEvent2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(232, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask3ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3f43d162-427d-451c-b0be-012cc58aed92"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("75f3c95d-4ab0-4c81-9a53-29f46079bf9a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				Name = @"ScriptTask3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(315, 57),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,87,75,111,19,49,16,62,183,82,255,195,146,3,218,173,34,135,123,1,41,77,67,21,1,37,52,9,28,16,66,110,118,74,13,187,235,197,246,182,13,168,255,157,241,35,137,189,113,33,161,136,3,82,14,177,61,243,205,55,79,123,123,189,9,20,48,87,144,191,230,121,83,192,176,82,76,45,70,121,242,44,57,5,53,89,200,112,59,13,165,71,121,118,116,176,207,46,147,116,76,63,3,57,161,138,78,120,35,230,64,206,249,141,36,3,222,84,42,121,158,60,201,146,31,7,251,123,215,84,36,96,128,16,61,166,240,225,201,199,163,64,110,50,191,130,146,26,54,118,131,32,169,233,162,134,124,192,139,166,172,222,209,162,129,167,167,13,203,159,167,29,36,59,244,180,102,163,188,147,29,37,14,79,161,146,213,153,109,9,55,245,53,58,218,207,61,252,189,96,69,177,62,25,230,76,165,33,85,35,168,35,210,242,224,17,6,20,129,201,176,172,213,194,198,195,16,147,70,0,25,205,36,136,1,175,42,12,47,227,21,241,93,121,77,43,140,150,208,108,71,149,84,180,154,195,241,2,89,197,76,239,153,192,190,185,248,130,56,175,56,255,218,212,154,36,153,128,50,222,245,171,124,10,183,42,181,102,9,130,116,29,5,50,160,181,182,108,80,238,182,112,34,121,252,184,21,214,127,230,99,152,81,4,94,186,96,214,82,131,88,229,128,159,23,159,117,10,7,188,188,224,199,252,54,26,165,181,186,141,148,183,110,71,11,127,189,67,205,171,70,124,203,118,197,206,21,219,36,66,242,140,150,96,74,215,54,212,169,96,174,214,52,84,185,218,219,174,102,219,166,137,39,162,13,101,177,238,114,129,95,182,164,35,25,156,141,5,191,102,185,77,142,219,74,59,145,228,117,178,132,202,100,10,66,80,201,47,21,154,23,96,147,204,64,198,178,29,227,243,182,1,161,7,68,5,55,201,176,189,159,70,152,119,147,251,226,215,142,135,142,193,42,142,30,42,233,231,46,154,38,21,227,149,154,233,124,162,213,194,148,248,188,118,130,246,167,41,217,0,135,191,2,27,155,131,129,153,160,41,254,220,78,107,64,174,76,108,130,224,208,84,32,164,6,75,55,79,7,2,168,2,43,243,158,169,171,49,21,136,164,21,82,187,137,45,90,83,193,36,175,180,73,50,252,214,208,162,171,7,123,196,212,57,231,202,149,48,22,235,88,176,146,138,197,218,199,52,235,6,93,149,133,45,129,101,26,141,2,66,89,167,17,169,176,195,43,13,103,89,164,230,214,61,139,176,120,181,237,208,184,247,54,235,14,152,241,98,250,205,141,248,91,212,123,106,199,144,213,18,171,6,89,190,34,182,131,253,85,91,25,108,59,155,252,222,140,14,108,63,250,93,243,130,49,139,19,38,235,130,46,140,104,32,147,5,224,190,253,40,124,152,138,251,12,180,110,44,99,98,249,110,26,135,229,225,115,241,197,78,64,81,86,12,163,153,95,248,10,127,231,61,242,127,92,229,15,189,194,151,101,224,166,28,162,233,29,116,18,115,81,161,63,122,181,116,136,224,157,56,7,41,181,61,252,91,131,80,46,251,237,57,137,179,177,27,118,69,118,116,216,59,216,191,235,29,218,167,243,163,145,60,195,187,14,83,128,255,6,188,118,225,182,15,100,83,7,56,17,49,116,125,41,231,187,147,113,5,117,198,115,8,166,161,57,71,102,150,228,230,81,208,24,15,141,200,67,72,96,102,118,9,197,244,74,240,155,225,53,10,165,29,61,227,245,225,57,92,10,144,87,248,137,97,222,6,59,121,181,45,222,155,151,199,141,82,216,9,253,47,244,214,200,227,247,79,193,230,95,177,204,26,9,18,253,97,57,213,245,134,53,174,68,163,175,74,93,251,84,214,90,127,249,252,234,187,101,240,142,154,141,200,123,184,208,4,5,47,164,225,135,218,78,147,12,26,169,120,169,63,165,62,172,107,239,19,197,190,188,134,245,7,86,231,99,228,163,11,9,34,209,209,201,210,9,215,17,166,145,94,241,57,82,254,78,47,10,208,141,132,218,88,16,254,219,174,186,100,159,27,97,92,194,85,89,242,106,166,88,97,223,122,216,181,158,190,45,131,112,98,116,55,200,184,107,91,143,124,124,210,57,42,157,77,185,190,241,12,131,31,171,23,221,89,2,84,35,42,27,228,159,248,5,15,4,224,14,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("02779e5d-04a3-4561-b55b-5f33f9c8de64"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("156b4ef7-ebde-43e0-ab1b-be5ac67f0ce8"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				Name = @"EventSubProcess3",
				Position = new Point(36, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(178, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage3StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f11b2622-3e80-4bc6-9440-a565eb062e58"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("02779e5d-04a3-4561-b55b-5f33f9c8de64"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"TypeColumnComboBoxEditChange",
				ModifiedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				Name = @"StartMessage3",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask4ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ad496b99-dbdc-45db-ab5a-0a349b1920c9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("02779e5d-04a3-4561-b55b-5f33f9c8de64"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				Name = @"ScriptTask4",
				Position = new Point(77, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,144,79,107,131,64,16,197,207,10,126,135,73,14,162,16,246,3,68,164,52,127,8,94,146,82,109,239,91,157,132,133,117,55,172,179,166,18,250,221,187,93,105,45,61,9,189,206,188,223,155,121,175,231,6,80,145,160,1,114,120,226,23,100,59,78,188,212,214,212,200,30,107,18,61,62,235,91,22,133,226,12,137,223,87,195,21,183,90,218,86,109,117,251,166,55,250,125,223,8,98,37,74,172,9,155,130,176,133,69,14,202,74,9,113,12,115,25,246,202,165,197,111,50,133,123,20,6,189,123,142,126,208,81,144,67,71,70,168,11,43,186,163,19,158,204,190,189,210,48,251,181,241,12,171,116,233,93,146,52,133,7,56,88,209,48,239,3,107,119,54,80,120,243,179,127,184,186,198,130,177,87,39,164,95,1,146,229,228,247,82,52,203,213,223,132,95,232,7,160,236,208,119,48,211,100,138,224,249,40,52,72,214,40,32,99,49,251,4,214,167,31,24,229,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("79e21fb3-8fa9-43f2-a33f-b5f0611e2383"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("52fe13f9-919c-4c6f-ad64-53ffbb4c1e2e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
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
				UId = new Guid("f94aa907-320b-4266-8e60-7c1d5af91823"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("79e21fb3-8fa9-43f2-a33f-b5f0611e2383"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ObjectLookupEditChange",
				ModifiedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				Name = @"StartMessage4",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask5ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("37922b80-c8be-4e24-9e30-ff179975b11a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("79e21fb3-8fa9-43f2-a33f-b5f0611e2383"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				Name = @"ScriptTask5",
				Position = new Point(77, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,145,81,75,195,48,20,133,159,59,216,127,184,238,97,164,48,242,3,28,69,102,173,82,16,39,182,250,158,181,215,25,77,147,146,222,116,43,226,127,183,77,31,44,40,83,95,147,239,158,115,238,185,173,176,128,154,36,117,16,193,189,216,35,191,18,36,50,227,108,129,124,83,144,108,241,193,28,214,243,153,255,203,187,26,99,163,92,165,99,83,237,204,165,57,38,165,36,30,43,20,54,37,172,26,22,246,168,124,6,230,241,237,238,21,11,186,53,230,205,213,30,124,18,202,33,156,69,160,157,82,176,92,2,187,113,178,12,127,129,7,134,39,85,77,93,8,239,243,89,208,246,153,141,167,199,44,35,24,65,67,86,234,61,79,155,187,94,125,107,253,196,169,32,60,55,153,31,97,97,8,23,19,27,56,239,93,2,141,7,255,246,87,137,126,243,96,172,146,103,56,141,198,22,89,215,36,254,39,43,94,176,18,143,105,185,88,125,95,193,43,92,75,165,190,106,30,156,216,143,224,7,160,106,208,247,241,31,211,73,151,131,200,233,187,246,138,94,107,163,203,28,143,196,134,171,173,252,237,134,97,139,228,172,6,178,14,215,159,24,100,134,69,71,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateFillTypeColumnEditMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b22cedfd-39cd-46e5-b5c4-6f7cd276eb74"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0da240a7-6b5c-4da2-ab4b-e82287d805bd"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8")
			});
		}

		protected virtual SchemaMethod CreateFillTypeColumnEditMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ba434a1e-e684-4ca0-b6ee-0b306d1d1e3b"),
				Name = "FillTypeColumnEdit",
				CreatedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a91edaec-93b2-4f75-97c8-ad8c7fd20b90"),
				Name = "entitySchemaId",
				CreatedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				ModifiedInSchemaUId = new Guid("8855db24-1891-490d-953c-f8e0e913804a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,145,65,106,195,48,16,69,215,54,228,14,194,43,27,138,14,208,210,69,227,134,96,104,74,32,110,247,83,105,146,136,218,146,145,71,110,77,201,221,43,217,94,216,180,129,172,132,254,204,188,63,95,234,192,50,212,164,168,63,136,51,214,176,3,13,39,180,236,145,237,253,201,71,145,47,106,123,107,58,37,209,242,45,210,36,165,201,230,47,35,201,30,86,113,231,249,147,129,103,254,227,20,40,133,110,9,180,192,117,255,86,200,116,222,84,200,140,65,203,230,116,15,61,26,139,32,206,233,92,206,77,229,106,205,20,97,205,148,158,156,248,168,182,25,251,89,197,81,216,69,12,66,217,55,248,10,53,250,149,194,0,127,6,130,119,168,28,134,2,47,205,129,172,210,167,52,4,136,218,47,69,222,107,57,152,5,158,128,22,89,82,162,181,208,154,35,121,51,139,124,235,148,92,224,146,251,107,173,47,198,124,186,230,198,230,157,171,72,93,155,136,134,207,10,215,49,112,110,234,15,179,54,223,27,169,136,63,73,89,248,144,233,144,212,63,240,221,152,57,135,134,148,209,67,198,72,24,255,94,218,97,184,92,86,241,229,23,249,165,46,128,23,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysModuleEntitiesEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8855db24-1891-490d-953c-f8e0e913804a"));
		}

		#endregion

	}

	#endregion

}

