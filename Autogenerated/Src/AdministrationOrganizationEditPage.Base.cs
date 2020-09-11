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

	#region Class: AdministrationOrganizationEditPageSchema

	/// <exclude/>
	public class AdministrationOrganizationEditPageSchema : Terrasoft.WebApp.BaseAdministrationUnitEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.LookupEdit _accountEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit AccountEdit {
			get {
				return _accountEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public AdministrationOrganizationEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public AdministrationOrganizationEditPageSchema(AdministrationOrganizationEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ModifiedInSchemaUId = new Guid("8d64ecff-4f2d-4791-a90a-6610f37fc116");
		}

		private void UpdateSynchronizeWithLDAPCheckBox() {
			SynchronizeWithLDAPCheckBox.AjaxEvents.Check.IsProcessEventHandler = true;
		}

		private void UpdateLDAPEntryButton() {
			LDAPEntryButton.AjaxEvents.Click.IsProcessEventHandler = true;
			LDAPEntryButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2"),
				ItemUId = new Guid("ceeaa064-ff61-470b-8fac-088d723602d5"),
				ImageHash = @"54ac1a2d1db28aa44e6b7837c54cc5e6"
			};
			LDAPEntryButton.ModifiedInSchemaUId = new Guid("8d64ecff-4f2d-4791-a90a-6610f37fc116");
		}

		private void UpdateLDAPEntryEdit() {
			LDAPEntryEdit.Image = new ControlImage {};
			LDAPEntryEdit.ModifiedInSchemaUId = new Guid("8d64ecff-4f2d-4791-a90a-6610f37fc116");
		}

		private void UpdateLDAPControlLayout() {
			LDAPControlLayout.Image = new ControlImage {};
			LDAPControlLayout.ModifiedInSchemaUId = new Guid("8d64ecff-4f2d-4791-a90a-6610f37fc116");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("8d64ecff-4f2d-4791-a90a-6610f37fc116");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("8d64ecff-4f2d-4791-a90a-6610f37fc116");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("8d64ecff-4f2d-4791-a90a-6610f37fc116");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("8d64ecff-4f2d-4791-a90a-6610f37fc116");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("8d64ecff-4f2d-4791-a90a-6610f37fc116");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("8d64ecff-4f2d-4791-a90a-6610f37fc116");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("8d64ecff-4f2d-4791-a90a-6610f37fc116");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("8d64ecff-4f2d-4791-a90a-6610f37fc116");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8d64ecff-4f2d-4791-a90a-6610f37fc116");
			RealUId = new Guid("8d64ecff-4f2d-4791-a90a-6610f37fc116");
			Name = "AdministrationOrganizationEditPage";
			ParentSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 255;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAdministrationOrganizationEditPageEventsProcessSchema();
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
			UpdateLDAPControlLayout();
			UpdateLDAPEntryEdit();
			UpdateLDAPEntryButton();
			UpdateSynchronizeWithLDAPCheckBox();
			UpdateNameEdit();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.MoveItem(0, NameEdit);
			MainControlLayout.InsertItem(1, CreateAccountEdit());
			MainControlLayout.MoveItem(2, LDAPControlLayout);
			LDAPControlLayout.MoveItem(0, SynchronizeWithLDAPCheckBox);
			LDAPControlLayout.MoveItem(1, LDAPEntryEdit);
			LDAPEntryEdit.MoveItem(0, LDAPEntryButton);
			MainControlLayout.MoveItem(3, CustomControls);
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

		protected virtual EmbeddedProcessSchema CreateAdministrationOrganizationEditPageEventsProcessSchema() {
			var schema = new AdministrationOrganizationEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateAccountEdit() {
			_accountEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_accountEdit.UId = new Guid("ac8cc9f5-f313-4e92-b804-9e44179ace5c");
			_accountEdit.Name = "AccountEdit";
			_accountEdit.CreatedInSchemaUId = new Guid("8d64ecff-4f2d-4791-a90a-6610f37fc116");
			_accountEdit.ModifiedInSchemaUId = new Guid("8d64ecff-4f2d-4791-a90a-6610f37fc116");
			_accountEdit.CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			_accountEdit.Tag = "";
			_accountEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_accountEdit.Image = new ControlImage {};
			_accountEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_accountEdit.DataSource = "DataSource";
			_accountEdit.ColumnUId = new Guid("7f38ec11-62de-44cc-9fcc-2aa35eecb246");
			_accountEdit.Required = true;
			_accountEdit.LookupSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e");
			return _accountEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.Columns.FindByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.IsAlwaysSelect = true;
				column.Required = true;
				column.ModifiedInSchemaUId = new Guid("8d64ecff-4f2d-4791-a90a-6610f37fc116");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.IsAlwaysSelect = true;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
				column.ModifiedInSchemaUId = new Guid("8d64ecff-4f2d-4791-a90a-6610f37fc116");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("3678b2d1-343e-4e0c-8a93-f082143be510");
			if (column != null) {
				column.IsAlwaysSelect = true;
				column.ModifiedInSchemaUId = new Guid("8d64ecff-4f2d-4791-a90a-6610f37fc116");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("a07a30ff-b3df-45db-a83c-bf89027250d8");
			if (column != null) {
				column.Required = true;
				column.ModifiedInSchemaUId = new Guid("8d64ecff-4f2d-4791-a90a-6610f37fc116");
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new AdministrationOrganizationEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new AdministrationOrganizationEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8d64ecff-4f2d-4791-a90a-6610f37fc116"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new AdministrationOrganizationEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: AdministrationOrganizationEditPageEventsProcess

	/// <exclude/>
	public class AdministrationOrganizationEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseAdministrationUnitEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.AdministrationOrganizationEditPageSchemaUserControl
	{

		public AdministrationOrganizationEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AdministrationOrganizationEditPageEventsProcess";
			SchemaUId = new Guid("8d64ecff-4f2d-4791-a90a-6610f37fc116");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8d64ecff-4f2d-4791-a90a-6610f37fc116");
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

		private ProcessFlowElement _subProcessChildPageLoadCompleteChild;
		public ProcessFlowElement SubProcessChildPageLoadCompleteChild {
			get {
				return _subProcessChildPageLoadCompleteChild ?? (_subProcessChildPageLoadCompleteChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessChildPageLoadCompleteChild",
					SchemaElementUId = new Guid("6ab46329-05e7-46a9-8a00-84ba0bb1b842"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _childPageLoadComplete;
		public ProcessFlowElement ChildPageLoadComplete {
			get {
				return _childPageLoadComplete ?? (_childPageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChildPageLoadComplete",
					SchemaElementUId = new Guid("6dea2ad2-9cd7-4958-b793-349044480dce"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("97d150a6-f47f-4565-be5b-127e8fda45a1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptChildPageLoadComplete;
		public ProcessScriptTask ScriptChildPageLoadComplete {
			get {
				return _scriptChildPageLoadComplete ?? (_scriptChildPageLoadComplete = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptChildPageLoadComplete",
					SchemaElementUId = new Guid("58a84fa0-95b0-44bb-803f-849e209761bd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChildPageLoadCompleteExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[SubProcessChildPageLoadCompleteChild.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessChildPageLoadCompleteChild };
			FlowElements[ChildPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildPageLoadComplete };
			FlowElements[ThrowPageLoadCompleteParent.SchemaElementUId] = new Collection<ProcessFlowElement> { ThrowPageLoadCompleteParent };
			FlowElements[ScriptChildPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChildPageLoadComplete };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SubProcessChildPageLoadCompleteChild":
						break;
					case "ChildPageLoadComplete":
						e.Context.QueueTasks.Enqueue("ThrowPageLoadCompleteParent");
						break;
					case "ThrowPageLoadCompleteParent":
						e.Context.QueueTasks.Enqueue("ScriptChildPageLoadComplete");
						break;
					case "ScriptChildPageLoadComplete":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ChildPageLoadComplete");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SubProcessChildPageLoadCompleteChild":
					context.QueueTasks.Dequeue();
					break;
				case "ChildPageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildPageLoadComplete";
					result = ChildPageLoadComplete.Execute(context);
					break;
				case "ThrowPageLoadCompleteParent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = ThrowPageLoadCompleteParent.Execute(context);
					break;
				case "ScriptChildPageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptChildPageLoadComplete";
					result = ScriptChildPageLoadComplete.Execute(context, ScriptChildPageLoadCompleteExecute);
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

		public virtual bool ScriptChildPageLoadCompleteExecute(ProcessExecutingContext context) {
			if (!string.IsNullOrEmpty(Page.Request.QueryString["recordId"])) {
				Page.AccountEdit.Enabled = new Guid(Page.Request.QueryString["recordId"]).IsEmpty();
			}
			Page.OKButton.AjaxEvents.Click.CausesValidation = true;
			return true;
		}

		public override Dictionary<string, object> GetDefValues() {
			var defValues = base.GetDefValues();
			var parentRoleIdObj = Page.GetParameterValue("ParentRole");
			if (parentRoleIdObj != null) {
				var parentRoleId = new Guid(parentRoleIdObj.ToString());
				if (parentRoleId != Guid.Empty) {
					defValues["ParentRole"] = parentRoleId;
				}
			}
			if ((Guid)defValues["ParentRole"] != Guid.Empty) {
				var sysAdminUnit = new SysAdminUnit(Page.UserConnection);
				if (sysAdminUnit.FetchFromDB((Guid)defValues["ParentRole"])) {
					defValues["ConnectionType"] = sysAdminUnit.GetColumnValue("ConnectionType");
				}
			}
			return defValues;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("ChildPageLoadComplete")) {
							context.QueueTasks.Enqueue("ChildPageLoadComplete");
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

	#region Class: AdministrationOrganizationEditPageEventsProcess

	/// <exclude/>
	public class AdministrationOrganizationEditPageEventsProcess : AdministrationOrganizationEditPageEventsProcess<Terrasoft.WebApp.AdministrationOrganizationEditPageSchemaUserControl>
	{

		public AdministrationOrganizationEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AdministrationOrganizationEditPageSchemaUserControl

	/// <exclude/>
	public partial class AdministrationOrganizationEditPageSchemaUserControl : Terrasoft.WebApp.BaseAdministrationUnitEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.LookupEdit AccountEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("AccountEdit", true);
			}
		}

		#endregion

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
			var process = (AdministrationOrganizationEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new AdministrationOrganizationEditPageEventsProcess(UserConnection);
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
			SchemaName = "AdministrationOrganizationEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: AdministrationOrganizationEditPageEventsProcessSchema

	/// <exclude/>
	public class AdministrationOrganizationEditPageEventsProcessSchema : Terrasoft.WebApp.BaseAdministrationUnitEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public AdministrationOrganizationEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AdministrationOrganizationEditPageEventsProcessSchema(AdministrationOrganizationEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AdministrationOrganizationEditPageEventsProcess";
			UId = new Guid("3e856cd0-2bd9-4779-90f1-71a5238d9ec6");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1008 = CreateLaneSet1008LaneSet();
			LaneSets.Add(schemaLaneSet1008);
			ProcessSchemaLane schemaLane3519 = CreateLane3519Lane();
			schemaLaneSet1008.Lanes.Add(schemaLane3519);
			ProcessSchemaEventSubProcess subprocesschildpageloadcompletechild = CreateSubProcessChildPageLoadCompleteChildEventSubProcess();
			FlowElements.Add(subprocesschildpageloadcompletechild);
			ProcessSchemaStartMessageEvent childpageloadcomplete = CreateChildPageLoadCompleteStartMessageEvent();
			subprocesschildpageloadcompletechild.FlowElements.Add(childpageloadcomplete);
			ProcessSchemaIntermediateThrowMessageEvent throwpageloadcompleteparent = CreateThrowPageLoadCompleteParentIntermediateThrowMessageEvent();
			subprocesschildpageloadcompletechild.FlowElements.Add(throwpageloadcompleteparent);
			ProcessSchemaScriptTask scriptchildpageloadcomplete = CreateScriptChildPageLoadCompleteScriptTask();
			subprocesschildpageloadcompletechild.FlowElements.Add(scriptchildpageloadcomplete);
			FlowElements.Add(CreateSequenceFlow20136SequenceFlow());
			FlowElements.Add(CreateSequenceFlow20137SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow20136SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow20136",
				UId = new Guid("85e28ea6-3644-4cf4-9316-180d04f7d3e0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("3e856cd0-2bd9-4779-90f1-71a5238d9ec6"),
				CurveCenterPosition = new Point(146, 84),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3e856cd0-2bd9-4779-90f1-71a5238d9ec6"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6dea2ad2-9cd7-4958-b793-349044480dce"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("97d150a6-f47f-4565-be5b-127e8fda45a1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow20137SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow20137",
				UId = new Guid("899f09bb-747d-498b-b14e-fc2e6a9b59db"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("3e856cd0-2bd9-4779-90f1-71a5238d9ec6"),
				CurveCenterPosition = new Point(239, 86),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3e856cd0-2bd9-4779-90f1-71a5238d9ec6"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("97d150a6-f47f-4565-be5b-127e8fda45a1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("58a84fa0-95b0-44bb-803f-849e209761bd"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1008LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1008 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("e0df8ff9-3de8-481a-aff1-18fa43ba9c7b"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("3e856cd0-2bd9-4779-90f1-71a5238d9ec6"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("3e856cd0-2bd9-4779-90f1-71a5238d9ec6"),
				Name = @"LaneSet1008",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(787, 177),
				UseBackgroundMode = false
			};
			return schemaLaneSet1008;
		}

		protected virtual ProcessSchemaLane CreateLane3519Lane() {
			ProcessSchemaLane schemaLane3519 = new ProcessSchemaLane(this) {
				UId = new Guid("46373d56-6995-4eaf-b345-4b28286e1a93"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("e0df8ff9-3de8-481a-aff1-18fa43ba9c7b"),
				CreatedInOwnerSchemaUId = new Guid("8d64ecff-4f2d-4791-a90a-6610f37fc116"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("3e856cd0-2bd9-4779-90f1-71a5238d9ec6"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("3e856cd0-2bd9-4779-90f1-71a5238d9ec6"),
				Name = @"Lane3519",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(758, 177),
				UseBackgroundMode = false
			};
			return schemaLane3519;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessChildPageLoadCompleteChildEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessChildPageLoadCompleteChild = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("6ab46329-05e7-46a9-8a00-84ba0bb1b842"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("46373d56-6995-4eaf-b345-4b28286e1a93"),
				CreatedInOwnerSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("3e856cd0-2bd9-4779-90f1-71a5238d9ec6"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3e856cd0-2bd9-4779-90f1-71a5238d9ec6"),
				Name = @"SubProcessChildPageLoadCompleteChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(292, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessChildPageLoadCompleteChild;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChildPageLoadCompleteStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6dea2ad2-9cd7-4958-b793-349044480dce"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6ab46329-05e7-46a9-8a00-84ba0bb1b842"),
				CreatedInOwnerSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("3e856cd0-2bd9-4779-90f1-71a5238d9ec6"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("3e856cd0-2bd9-4779-90f1-71a5238d9ec6"),
				Name = @"ChildPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateThrowPageLoadCompleteParentIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("97d150a6-f47f-4565-be5b-127e8fda45a1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6ab46329-05e7-46a9-8a00-84ba0bb1b842"),
				CreatedInOwnerSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("3e856cd0-2bd9-4779-90f1-71a5238d9ec6"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("3e856cd0-2bd9-4779-90f1-71a5238d9ec6"),
				Name = @"ThrowPageLoadCompleteParent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(106, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChildPageLoadCompleteScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("58a84fa0-95b0-44bb-803f-849e209761bd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6ab46329-05e7-46a9-8a00-84ba0bb1b842"),
				CreatedInOwnerSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("3e856cd0-2bd9-4779-90f1-71a5238d9ec6"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3e856cd0-2bd9-4779-90f1-71a5238d9ec6"),
				Name = @"ScriptChildPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(183, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,142,77,10,194,48,20,132,215,230,20,177,171,118,147,11,20,23,181,4,41,130,245,7,220,136,139,216,60,75,52,38,154,188,167,22,241,238,150,246,2,46,7,190,153,111,204,153,167,211,136,193,184,86,84,113,69,214,214,65,222,238,216,165,107,213,130,216,194,131,32,162,216,16,132,110,55,96,135,36,64,227,131,174,116,114,204,50,254,97,147,129,44,154,198,147,67,169,13,10,233,212,201,130,230,51,238,224,197,23,100,244,127,107,253,131,209,157,229,236,203,134,74,189,156,19,162,119,162,184,168,183,124,130,195,40,74,107,154,171,40,21,69,136,123,101,141,86,104,188,235,109,24,8,114,22,0,41,184,49,252,0,24,94,138,55,223,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9172e0a8-be67-4466-bee9-4324d80b45f1"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0127c4ec-c32d-490a-92db-dac6957dd282"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0da240a7-6b5c-4da2-ab4b-e82287d805bd"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected override SchemaMethod CreateGetDefValuesMethod() {
			SchemaMethod method = base.CreateGetDefValuesMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,146,189,78,195,48,20,70,231,68,202,59,152,78,246,146,23,168,58,64,75,43,38,34,218,178,32,6,183,185,45,70,246,117,228,159,162,8,245,221,177,147,146,132,20,88,173,239,28,223,239,218,39,110,72,9,135,103,46,61,88,50,35,59,110,33,95,129,91,124,159,81,54,205,210,83,72,85,220,0,186,39,45,225,161,124,220,189,135,108,193,143,77,182,224,134,43,112,96,26,130,78,138,46,57,137,176,56,16,58,134,111,102,4,189,148,140,124,102,105,50,182,7,53,194,7,89,121,81,142,193,124,163,215,206,8,60,82,22,213,201,216,29,197,145,203,239,85,229,234,86,159,116,253,94,134,163,189,134,107,134,104,212,157,179,244,220,14,76,163,133,253,69,254,114,75,44,97,107,123,91,42,129,91,20,238,82,98,61,56,162,205,194,182,22,204,92,35,194,222,9,141,93,139,33,155,47,193,237,223,150,70,171,197,221,255,147,176,235,138,189,123,83,87,109,205,31,238,240,96,115,45,189,194,203,107,141,242,172,223,131,1,231,13,246,223,99,250,5,235,43,132,117,45,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AdministrationOrganizationEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3e856cd0-2bd9-4779-90f1-71a5238d9ec6"));
		}

		#endregion

	}

	#endregion

}

