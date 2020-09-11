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
	using System.IO;
	using System.Linq;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Mail;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.Web.Common;
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: MailServerEditPageSchema

	/// <exclude/>
	public class MailServerEditPageSchema : Terrasoft.WebApp.MailServerEditPage_Base_TerrasoftSchema
	{

		#region Constructors: Public

		public MailServerEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public MailServerEditPageSchema(MailServerEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ModifiedInSchemaUId = new Guid("c9262cdc-0bc3-44d7-a0e4-c486be7ffb39");
		}

		private void UpdateAllowEmailDownloadingCheckBox() {
			AllowEmailDownloadingCheckBox.AjaxEvents.Check.IsProcessEventHandler = true;
		}

		private void UpdateEmailProtocolComboBoxEdit() {
			EmailProtocolComboBoxEdit.Image = new ControlImage {};
			EmailProtocolComboBoxEdit.ModifiedInSchemaUId = new Guid("c9262cdc-0bc3-44d7-a0e4-c486be7ffb39");
		}

		private void UpdateControlLayout2() {
			ControlLayout2.Image = new ControlImage {};
			ControlLayout2.ModifiedInSchemaUId = new Guid("c9262cdc-0bc3-44d7-a0e4-c486be7ffb39");
		}

		private void UpdateAddressEdit() {
			AddressEdit.Image = new ControlImage {};
			AddressEdit.ModifiedInSchemaUId = new Guid("c9262cdc-0bc3-44d7-a0e4-c486be7ffb39");
		}

		private void UpdatePortEdit() {
			PortEdit.Image = new ControlImage {};
			PortEdit.ModifiedInSchemaUId = new Guid("c9262cdc-0bc3-44d7-a0e4-c486be7ffb39");
		}

		private void UpdateControlLayout1() {
			ControlLayout1.Image = new ControlImage {};
			ControlLayout1.ModifiedInSchemaUId = new Guid("c9262cdc-0bc3-44d7-a0e4-c486be7ffb39");
		}

		private void UpdateAllowEmailSendingCheckBox() {
			AllowEmailSendingCheckBox.AjaxEvents.Check.IsProcessEventHandler = true;
		}

		private void UpdateSMTPServerAddressTextEdit() {
			SMTPServerAddressTextEdit.Image = new ControlImage {};
			SMTPServerAddressTextEdit.ModifiedInSchemaUId = new Guid("c9262cdc-0bc3-44d7-a0e4-c486be7ffb39");
		}

		private void UpdateSMTPPortEdit() {
			SMTPPortEdit.Image = new ControlImage {};
			SMTPPortEdit.ModifiedInSchemaUId = new Guid("c9262cdc-0bc3-44d7-a0e4-c486be7ffb39");
		}

		private void UpdateControlLayout3() {
			ControlLayout3.Image = new ControlImage {};
			ControlLayout3.ModifiedInSchemaUId = new Guid("c9262cdc-0bc3-44d7-a0e4-c486be7ffb39");
		}

		private void UpdateSMTPServerTimeoutEdit() {
			SMTPServerTimeoutEdit.Image = new ControlImage {};
			SMTPServerTimeoutEdit.ModifiedInSchemaUId = new Guid("c9262cdc-0bc3-44d7-a0e4-c486be7ffb39");
		}

		private void UpdateLoginParametersControlLayout() {
			LoginParametersControlLayout.Image = new ControlImage {};
			LoginParametersControlLayout.ModifiedInSchemaUId = new Guid("c9262cdc-0bc3-44d7-a0e4-c486be7ffb39");
		}

		private void UpdateLogoEdit() {
			LogoEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			LogoEdit.AjaxEvents.Change.ShowLoadMask = true;
			LogoEdit.Image = new ControlImage {};
			LogoEdit.ModifiedInSchemaUId = new Guid("c9262cdc-0bc3-44d7-a0e4-c486be7ffb39");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("c9262cdc-0bc3-44d7-a0e4-c486be7ffb39");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("c9262cdc-0bc3-44d7-a0e4-c486be7ffb39");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("c9262cdc-0bc3-44d7-a0e4-c486be7ffb39");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("c9262cdc-0bc3-44d7-a0e4-c486be7ffb39");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("c9262cdc-0bc3-44d7-a0e4-c486be7ffb39");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("c9262cdc-0bc3-44d7-a0e4-c486be7ffb39");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("c9262cdc-0bc3-44d7-a0e4-c486be7ffb39");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("c9262cdc-0bc3-44d7-a0e4-c486be7ffb39");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("c9262cdc-0bc3-44d7-a0e4-c486be7ffb39");
			Name = "MailServerEditPage";
			ParentSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			CreatedInPackageId = new Guid("24c6dcbf-ddce-46c1-876f-ee548e2ae17a");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateMailServerEditPageEventsProcessSchema();
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
			UpdateLogoEdit();
			UpdateLoginParametersControlLayout();
			UpdateSMTPServerTimeoutEdit();
			UpdateControlLayout3();
			UpdateSMTPPortEdit();
			UpdateSMTPServerAddressTextEdit();
			UpdateAllowEmailSendingCheckBox();
			UpdateControlLayout1();
			UpdatePortEdit();
			UpdateAddressEdit();
			UpdateControlLayout2();
			UpdateEmailProtocolComboBoxEdit();
			UpdateAllowEmailDownloadingCheckBox();
			UpdateNameEdit();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.MoveItem(0, NameEdit);
			MainControlLayout.MoveItem(1, Downloading);
			MainControlLayout.MoveItem(2, ControlLayout2);
			ControlLayout2.MoveItem(0, AllowEmailDownloadingCheckBox);
			ControlLayout2.MoveItem(1, EmailProtocolComboBoxEdit);
			MainControlLayout.MoveItem(3, ControlLayout1);
			ControlLayout1.MoveItem(0, AddressEdit);
			ControlLayout1.MoveItem(1, PortEdit);
			MainControlLayout.MoveItem(4, UseSSLEdit);
			MainControlLayout.MoveItem(5, IsStartTlsEdit);
			MainControlLayout.MoveItem(6, Sending);
			MainControlLayout.MoveItem(7, AllowEmailSendingCheckBox);
			MainControlLayout.MoveItem(8, ControlLayout3);
			ControlLayout3.MoveItem(0, SMTPServerAddressTextEdit);
			ControlLayout3.MoveItem(1, SMTPPortEdit);
			MainControlLayout.MoveItem(9, SMTPServerTimeoutEdit);
			MainControlLayout.MoveItem(10, UseSSLforSendingCheckBox);
			MainControlLayout.MoveItem(11, LoginParametersControlLayout);
			LoginParametersControlLayout.MoveItem(0, UseLoginRadioButton);
			LoginParametersControlLayout.MoveItem(1, UseUserNameAsLoginRadioButton);
			LoginParametersControlLayout.MoveItem(2, UseEmailAddressAsLoginRadioButton);
			MainControlLayout.MoveItem(12, ImageAndSettingsLabel);
			MainControlLayout.MoveItem(13, LogoEdit);
			MainControlLayout.MoveItem(14, CustomControls);
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

		protected virtual EmbeddedProcessSchema CreateMailServerEditPageEventsProcessSchema() {
			var schema = new MailServerEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.Columns.FindByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.Required = true;
				column.ModifiedInSchemaUId = new Guid("c9262cdc-0bc3-44d7-a0e4-c486be7ffb39");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("f0fec10e-c639-4ebb-b0d4-75ba7beb2b30");
			if (column != null) {
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
				column.ModifiedInSchemaUId = new Guid("c9262cdc-0bc3-44d7-a0e4-c486be7ffb39");
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("5a1ceded-281a-4994-bf5f-5fe57b752e0b");
			if (column != null) {
				column.UId = new Guid("2c4127db-f9b9-43c8-a508-a7d7be16f16a");
				column.Name = @"IsExchengeAutodiscover";
				column.CreatedInSchemaUId = new Guid("c9262cdc-0bc3-44d7-a0e4-c486be7ffb39");
				column.ModifiedInSchemaUId = new Guid("c9262cdc-0bc3-44d7-a0e4-c486be7ffb39");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ff05d2f5-bc16-4d80-b361-13120a07867e");
			if (column != null) {
				column.UId = new Guid("c1c41359-f1e2-45cb-be12-55fa186a8a35");
				column.Name = @"ExchangeEmailAddress";
				column.CreatedInSchemaUId = new Guid("c9262cdc-0bc3-44d7-a0e4-c486be7ffb39");
				column.ModifiedInSchemaUId = new Guid("c9262cdc-0bc3-44d7-a0e4-c486be7ffb39");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("411a2310-81f3-4a83-896e-87eccdbae77f");
			if (column != null) {
				column.UId = new Guid("ed4ee216-de91-4c4a-94d7-e70a04f14fe2");
				column.Name = @"Type";
				column.CreatedInSchemaUId = new Guid("c9262cdc-0bc3-44d7-a0e4-c486be7ffb39");
				column.ModifiedInSchemaUId = new Guid("c9262cdc-0bc3-44d7-a0e4-c486be7ffb39");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("cbfbbbe3-f97b-40ca-824b-b551a7081806");
			if (column != null) {
				column.UId = new Guid("f1f201f7-c259-4957-856e-057904cc4811");
				column.Name = @"UseLogin";
				column.CreatedInSchemaUId = new Guid("c9262cdc-0bc3-44d7-a0e4-c486be7ffb39");
				column.ModifiedInSchemaUId = new Guid("c9262cdc-0bc3-44d7-a0e4-c486be7ffb39");
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
			return new MailServerEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new MailServerEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c9262cdc-0bc3-44d7-a0e4-c486be7ffb39"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new MailServerEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: MailServerEditPageEventsProcess

	/// <exclude/>
	public class MailServerEditPageEventsProcess<TPage> : Terrasoft.WebApp.MailServerEditPage_Base_TerrasoftEventsProcess<TPage> where TPage : Terrasoft.WebApp.MailServerEditPageSchemaUserControl
	{

		public MailServerEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "MailServerEditPageEventsProcess";
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c9262cdc-0bc3-44d7-a0e4-c486be7ffb39");
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

		private ProcessFlowElement _childInitMailServerEventSubProcess;
		public ProcessFlowElement ChildInitMailServerEventSubProcess {
			get {
				return _childInitMailServerEventSubProcess ?? (_childInitMailServerEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ChildInitMailServerEventSubProcess",
					SchemaElementUId = new Guid("028960e1-18c9-4fd1-80b8-1c78bd296e8b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _childInitMailServerStartMessage;
		public ProcessFlowElement ChildInitMailServerStartMessage {
			get {
				return _childInitMailServerStartMessage ?? (_childInitMailServerStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChildInitMailServerStartMessage",
					SchemaElementUId = new Guid("84f862f9-dde8-482b-a723-1acd06eadae8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _childInitMailboxScriptTask;
		public ProcessScriptTask ChildInitMailboxScriptTask {
			get {
				return _childInitMailboxScriptTask ?? (_childInitMailboxScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChildInitMailboxScriptTask",
					SchemaElementUId = new Guid("627073d6-4291-4e93-ae7d-b20ba1cc5566"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChildInitMailboxScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _initIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent InitIntermediateThrowMessageEvent {
			get {
				return _initIntermediateThrowMessageEvent ?? (_initIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "InitIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("fdd04386-9188-4d19-a8c6-98ca160653fe"),
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
			FlowElements[ChildInitMailServerEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildInitMailServerEventSubProcess };
			FlowElements[ChildInitMailServerStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildInitMailServerStartMessage };
			FlowElements[ChildInitMailboxScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildInitMailboxScriptTask };
			FlowElements[InitIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { InitIntermediateThrowMessageEvent };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "ChildInitMailServerEventSubProcess":
						break;
					case "ChildInitMailServerStartMessage":
						e.Context.QueueTasks.Enqueue("ChildInitMailboxScriptTask");
						break;
					case "ChildInitMailboxScriptTask":
						e.Context.QueueTasks.Enqueue("InitIntermediateThrowMessageEvent");
						break;
					case "InitIntermediateThrowMessageEvent":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ChildInitMailServerStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "ChildInitMailServerEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ChildInitMailServerStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildInitMailServerStartMessage";
					result = ChildInitMailServerStartMessage.Execute(context);
					break;
				case "ChildInitMailboxScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildInitMailboxScriptTask";
					result = ChildInitMailboxScriptTask.Execute(context, ChildInitMailboxScriptTaskExecute);
					break;
				case "InitIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = InitIntermediateThrowMessageEvent.Execute(context);
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

		public virtual bool ChildInitMailboxScriptTaskExecute(ProcessExecutingContext context) {
			Page.DataSource.BeforeSaveRow +=
			 delegate(object sender, DataSourceEventArgs e) {
				e.Row.SetColumnValue("TypeId", new Guid("844F0837-EAA0-4F40-B965-71F5DB9EAE6E"));
			};
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Init":
							if (ActivatedEventElements.Contains("ChildInitMailServerStartMessage")) {
							context.QueueTasks.Enqueue("ChildInitMailServerStartMessage");
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

	#region Class: MailServerEditPageEventsProcess

	/// <exclude/>
	public class MailServerEditPageEventsProcess : MailServerEditPageEventsProcess<Terrasoft.WebApp.MailServerEditPageSchemaUserControl>
	{

		public MailServerEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: MailServerEditPageSchemaUserControl

	/// <exclude/>
	public partial class MailServerEditPageSchemaUserControl : Terrasoft.WebApp.MailServerEditPage_Base_TerrasoftSchemaUserControl
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
			var process = (MailServerEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new MailServerEditPageEventsProcess(UserConnection);
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
			SchemaName = "MailServerEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: MailServerEditPageEventsProcessSchema

	/// <exclude/>
	public class MailServerEditPageEventsProcessSchema : Terrasoft.WebApp.MailServerEditPage_Base_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public MailServerEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public MailServerEditPageEventsProcessSchema(MailServerEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "MailServerEditPageEventsProcess";
			UId = new Guid("2319a7c0-b765-4a9c-bf50-ddeb8bf70cef");
			CreatedInPackageId = new Guid("24c6dcbf-ddce-46c1-876f-ee548e2ae17a");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaExchangeLaneSet = CreateExchangeLaneSetLaneSet();
			LaneSets.Add(schemaExchangeLaneSet);
			ProcessSchemaLane schemaChildPageEventsLane = CreateChildPageEventsLaneLane();
			schemaExchangeLaneSet.Lanes.Add(schemaChildPageEventsLane);
			ProcessSchemaEventSubProcess childinitmailservereventsubprocess = CreateChildInitMailServerEventSubProcessEventSubProcess();
			FlowElements.Add(childinitmailservereventsubprocess);
			ProcessSchemaStartMessageEvent childinitmailserverstartmessage = CreateChildInitMailServerStartMessageStartMessageEvent();
			childinitmailservereventsubprocess.FlowElements.Add(childinitmailserverstartmessage);
			ProcessSchemaScriptTask childinitmailboxscripttask = CreateChildInitMailboxScriptTaskScriptTask();
			childinitmailservereventsubprocess.FlowElements.Add(childinitmailboxscripttask);
			ProcessSchemaIntermediateThrowMessageEvent initintermediatethrowmessageevent = CreateInitIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			childinitmailservereventsubprocess.FlowElements.Add(initintermediatethrowmessageevent);
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("0fca3727-8239-47e8-92e6-9abadeaec549"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("2319a7c0-b765-4a9c-bf50-ddeb8bf70cef"),
				CurveCenterPosition = new Point(192, 92),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2319a7c0-b765-4a9c-bf50-ddeb8bf70cef"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("84f862f9-dde8-482b-a723-1acd06eadae8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("627073d6-4291-4e93-ae7d-b20ba1cc5566"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12",
				UId = new Guid("aa6b1ba9-17d0-44f9-965f-576fca14007d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("2319a7c0-b765-4a9c-bf50-ddeb8bf70cef"),
				CurveCenterPosition = new Point(322, 88),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2319a7c0-b765-4a9c-bf50-ddeb8bf70cef"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("627073d6-4291-4e93-ae7d-b20ba1cc5566"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fdd04386-9188-4d19-a8c6-98ca160653fe"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateExchangeLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaExchangeLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("25585460-0075-4012-83d8-b7f9b60766c3"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				CreatedInPackageId = new Guid("24c6dcbf-ddce-46c1-876f-ee548e2ae17a"),
				CreatedInSchemaUId = new Guid("2319a7c0-b765-4a9c-bf50-ddeb8bf70cef"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("2319a7c0-b765-4a9c-bf50-ddeb8bf70cef"),
				Name = @"ExchangeLaneSet",
				Position = new Point(5, 5),
				Size = new Size(737, 177),
				UseBackgroundMode = false
			};
			return schemaExchangeLaneSet;
		}

		protected virtual ProcessSchemaLane CreateChildPageEventsLaneLane() {
			ProcessSchemaLane schemaChildPageEventsLane = new ProcessSchemaLane(this) {
				UId = new Guid("2641e865-ce6c-4acf-8d76-7e5385c4ef8c"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("25585460-0075-4012-83d8-b7f9b60766c3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("24c6dcbf-ddce-46c1-876f-ee548e2ae17a"),
				CreatedInSchemaUId = new Guid("2319a7c0-b765-4a9c-bf50-ddeb8bf70cef"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("2319a7c0-b765-4a9c-bf50-ddeb8bf70cef"),
				Name = @"ChildPageEventsLane",
				Position = new Point(29, 0),
				Size = new Size(708, 177),
				UseBackgroundMode = false
			};
			return schemaChildPageEventsLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateChildInitMailServerEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaChildInitMailServerEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("028960e1-18c9-4fd1-80b8-1c78bd296e8b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2641e865-ce6c-4acf-8d76-7e5385c4ef8c"),
				CreatedInOwnerSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("2319a7c0-b765-4a9c-bf50-ddeb8bf70cef"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("2319a7c0-b765-4a9c-bf50-ddeb8bf70cef"),
				Name = @"ChildInitMailServerEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(49, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(347, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaChildInitMailServerEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChildInitMailServerStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("84f862f9-dde8-482b-a723-1acd06eadae8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("028960e1-18c9-4fd1-80b8-1c78bd296e8b"),
				CreatedInOwnerSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("2319a7c0-b765-4a9c-bf50-ddeb8bf70cef"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("2319a7c0-b765-4a9c-bf50-ddeb8bf70cef"),
				Name = @"ChildInitMailServerStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChildInitMailboxScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("627073d6-4291-4e93-ae7d-b20ba1cc5566"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("028960e1-18c9-4fd1-80b8-1c78bd296e8b"),
				CreatedInOwnerSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("2319a7c0-b765-4a9c-bf50-ddeb8bf70cef"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2319a7c0-b765-4a9c-bf50-ddeb8bf70cef"),
				Name = @"ChildInitMailboxScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(139, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,69,203,49,11,130,64,24,6,224,57,193,255,240,225,164,148,98,164,150,72,131,230,25,109,145,209,126,229,155,20,118,23,231,157,18,209,127,175,173,225,25,159,61,111,17,148,92,243,90,26,117,65,80,224,42,21,106,62,224,32,71,154,174,109,139,26,116,104,185,134,43,207,119,92,52,245,16,13,212,140,254,139,13,16,58,87,109,79,240,232,109,91,19,4,191,29,212,208,27,217,153,135,56,241,206,192,117,142,175,39,118,141,51,35,129,145,182,230,214,184,206,42,138,170,112,181,88,250,44,207,67,63,170,162,208,47,210,36,246,151,243,42,46,139,148,229,44,97,142,231,101,182,245,249,81,208,70,9,210,202,32,251,2,39,244,174,247,185,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateInitIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("fdd04386-9188-4d19-a8c6-98ca160653fe"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("028960e1-18c9-4fd1-80b8-1c78bd296e8b"),
				CreatedInOwnerSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("2319a7c0-b765-4a9c-bf50-ddeb8bf70cef"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("2319a7c0-b765-4a9c-bf50-ddeb8bf70cef"),
				Name = @"InitIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(267, 65),
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
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b22cedfd-39cd-46e5-b5c4-6f7cd276eb74"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("24c6dcbf-ddce-46c1-876f-ee548e2ae17a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9f48e174-05f2-41d4-b29d-f1e0149ba290"),
				Name = "Terrasoft.Mail",
				Alias = "",
				CreatedInPackageId = new Guid("24c6dcbf-ddce-46c1-876f-ee548e2ae17a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0da240a7-6b5c-4da2-ab4b-e82287d805bd"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("24c6dcbf-ddce-46c1-876f-ee548e2ae17a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("24c6dcbf-ddce-46c1-876f-ee548e2ae17a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fcbf9a12-418d-4916-83ba-c99935976293"),
				Name = "System.IO",
				Alias = "",
				CreatedInPackageId = new Guid("fa2eb5ad-958f-4492-adde-c5914e708d28")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cfaac687-6f5f-4ae3-87aa-b12b61d54e6b"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("fa2eb5ad-958f-4492-adde-c5914e708d28")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("84a4ee49-5ba8-4d0e-b440-a84f85976746"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("fa2eb5ad-958f-4492-adde-c5914e708d28")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new MailServerEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2319a7c0-b765-4a9c-bf50-ddeb8bf70cef"));
		}

		#endregion

	}

	#endregion

}

