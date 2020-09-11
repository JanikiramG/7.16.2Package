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
	using System.Threading;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Core.Store;
	using Terrasoft.Reports;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: CurrencyRateDetailGridPageSchema

	/// <exclude/>
	public class CurrencyRateDetailGridPageSchema : Terrasoft.WebApp.BaseManyToManyDetailGridPageSchema
	{

		#region Constructors: Public

		public CurrencyRateDetailGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public CurrencyRateDetailGridPageSchema(CurrencyRateDetailGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("529e3b57-a4d0-404e-ba32-04682da85192");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				ImageHash = @""
			};
			CopyButton.ModifiedInSchemaUId = new Guid("529e3b57-a4d0-404e-ba32-04682da85192");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.Hidden = false;
			EditButton.ModifiedInSchemaUId = new Guid("529e3b57-a4d0-404e-ba32-04682da85192");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("529e3b57-a4d0-404e-ba32-04682da85192");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("529e3b57-a4d0-404e-ba32-04682da85192");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("529e3b57-a4d0-404e-ba32-04682da85192");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("529e3b57-a4d0-404e-ba32-04682da85192");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("529e3b57-a4d0-404e-ba32-04682da85192");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("529e3b57-a4d0-404e-ba32-04682da85192");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("529e3b57-a4d0-404e-ba32-04682da85192");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("529e3b57-a4d0-404e-ba32-04682da85192");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("529e3b57-a4d0-404e-ba32-04682da85192");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("529e3b57-a4d0-404e-ba32-04682da85192");
			RealUId = new Guid("529e3b57-a4d0-404e-ba32-04682da85192");
			Name = "CurrencyRateDetailGridPage";
			ParentSchemaUId = new Guid("bb5ab5ef-40b7-45f6-b503-17afaa6584a0");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCurrencyRateDetailGridPageEventsProcessSchema();
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
			ButtonsControlLayout.MoveItem(6, PrintButton);
			ButtonsControlLayout.MoveItem(7, ContextHelpButton);
			TopLevelControl.MoveItem(1, TreeGrid);
			TreeGrid.MoveItem(0, SendEmailMenuItem);
			TreeGrid.MoveItem(1, SendTemplateEmailMenuItem);
			TreeGrid.MoveItem(2, CallMenuItem);
			TreeGrid.MoveItem(3, ShowChangelogMenuItem);
			TopLevelControl.MoveItem(2, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateCurrencyRateDetailGridPageEventsProcessSchema() {
			var schema = new CurrencyRateDetailGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("e14c6037-56bb-4724-95b6-3dc29d7f6b4f");
			DataSource.ModifiedInSchemaUId = new Guid("529e3b57-a4d0-404e-ba32-04682da85192");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("5da7f016-ab78-406a-9b0c-a2f604b685de");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("529e3b57-a4d0-404e-ba32-04682da85192");
				column.ModifiedInSchemaUId = new Guid("529e3b57-a4d0-404e-ba32-04682da85192");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("fffa677c-647e-4b47-9a24-8fb2639fe3a4");
			if (column != null) {
				column.UId = new Guid("d6f442ab-e730-446a-bd64-3165aa31a2c1");
				column.Name = @"StartDate";
				column.CreatedInSchemaUId = new Guid("529e3b57-a4d0-404e-ba32-04682da85192");
				column.ModifiedInSchemaUId = new Guid("529e3b57-a4d0-404e-ba32-04682da85192");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("8484fcf9-f40d-48a1-a787-aba9e26c1fb0");
			if (column != null) {
				column.UId = new Guid("011b3b7b-8c33-4a4b-a973-8c14f2ed81c9");
				column.Name = @"Rate";
				column.CreatedInSchemaUId = new Guid("529e3b57-a4d0-404e-ba32-04682da85192");
				column.ModifiedInSchemaUId = new Guid("529e3b57-a4d0-404e-ba32-04682da85192");
				column.CreatedInPackageId = Guid.Empty;
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
			return new CurrencyRateDetailGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new CurrencyRateDetailGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("529e3b57-a4d0-404e-ba32-04682da85192"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new CurrencyRateDetailGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: CurrencyRateDetailGridPageEventsProcess

	/// <exclude/>
	public class CurrencyRateDetailGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseManyToManyDetailGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.CurrencyRateDetailGridPageSchemaUserControl
	{

		public CurrencyRateDetailGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CurrencyRateDetailGridPageEventsProcess";
			SchemaUId = new Guid("529e3b57-a4d0-404e-ba32-04682da85192");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("529e3b57-a4d0-404e-ba32-04682da85192");
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

		private ProcessFlowElement _currencyRateDetailGridPageOverrideInitSubProcess;
		public ProcessFlowElement CurrencyRateDetailGridPageOverrideInitSubProcess {
			get {
				return _currencyRateDetailGridPageOverrideInitSubProcess ?? (_currencyRateDetailGridPageOverrideInitSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "CurrencyRateDetailGridPageOverrideInitSubProcess",
					SchemaElementUId = new Guid("bea75645-bcc5-406e-a6dc-d3e9c3a769c9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _currencyRateDetailGridPageInitStartMessage;
		public ProcessFlowElement CurrencyRateDetailGridPageInitStartMessage {
			get {
				return _currencyRateDetailGridPageInitStartMessage ?? (_currencyRateDetailGridPageInitStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CurrencyRateDetailGridPageInitStartMessage",
					SchemaElementUId = new Guid("2f089faf-4423-4948-879c-d24b826711fe"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _currencyRateDetailGridPageInitScriptTask;
		public ProcessScriptTask CurrencyRateDetailGridPageInitScriptTask {
			get {
				return _currencyRateDetailGridPageInitScriptTask ?? (_currencyRateDetailGridPageInitScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CurrencyRateDetailGridPageInitScriptTask",
					SchemaElementUId = new Guid("11c59bd4-e1e4-498b-82c0-d6188d6d7809"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CurrencyRateDetailGridPageInitScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _currencyRateDetailGridPageInitIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent CurrencyRateDetailGridPageInitIntermediateThrowMessageEvent {
			get {
				return _currencyRateDetailGridPageInitIntermediateThrowMessageEvent ?? (_currencyRateDetailGridPageInitIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "CurrencyRateDetailGridPageInitIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("49d7c915-5949-48c3-b209-bdb8cf1581d8"),
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
			FlowElements[CurrencyRateDetailGridPageOverrideInitSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { CurrencyRateDetailGridPageOverrideInitSubProcess };
			FlowElements[CurrencyRateDetailGridPageInitStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { CurrencyRateDetailGridPageInitStartMessage };
			FlowElements[CurrencyRateDetailGridPageInitScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CurrencyRateDetailGridPageInitScriptTask };
			FlowElements[CurrencyRateDetailGridPageInitIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { CurrencyRateDetailGridPageInitIntermediateThrowMessageEvent };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "CurrencyRateDetailGridPageOverrideInitSubProcess":
						break;
					case "CurrencyRateDetailGridPageInitStartMessage":
						e.Context.QueueTasks.Enqueue("CurrencyRateDetailGridPageInitScriptTask");
						break;
					case "CurrencyRateDetailGridPageInitScriptTask":
						e.Context.QueueTasks.Enqueue("CurrencyRateDetailGridPageInitIntermediateThrowMessageEvent");
						break;
					case "CurrencyRateDetailGridPageInitIntermediateThrowMessageEvent":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("CurrencyRateDetailGridPageInitStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "CurrencyRateDetailGridPageOverrideInitSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "CurrencyRateDetailGridPageInitStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "CurrencyRateDetailGridPageInitStartMessage";
					result = CurrencyRateDetailGridPageInitStartMessage.Execute(context);
					break;
				case "CurrencyRateDetailGridPageInitScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CurrencyRateDetailGridPageInitScriptTask";
					result = CurrencyRateDetailGridPageInitScriptTask.Execute(context, CurrencyRateDetailGridPageInitScriptTaskExecute);
					break;
				case "CurrencyRateDetailGridPageInitIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = CurrencyRateDetailGridPageInitIntermediateThrowMessageEvent.Execute(context);
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

		public virtual bool CurrencyRateDetailGridPageInitScriptTaskExecute(ProcessExecutingContext context) {
			EditPageUId = new Guid("91efca06-166a-4181-a42e-b9651f192b0e");
			return true;
		}

		public override string GetRegisterEditPageScript(Guid editPageUId, Guid sysModuleEditId) {
			if (IsEntityDetail) {
				return base.GetRegisterEditPageScript(editPageUId, sysModuleEditId);
			} else {
				return string.Empty;
			}
		}

		public override string GetRegisterAddPageScript(Guid editPageUId, Guid sysModuleEditId, Guid typeId) {
			if (IsEntityDetail) {
				return base.GetRegisterAddPageScript(editPageUId, sysModuleEditId, typeId);
			} else {
				Page.AddButton.AjaxEvents.Click.SignalName = "AddButtonClick";
				return string.Empty;
			}
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Init":
							if (ActivatedEventElements.Contains("CurrencyRateDetailGridPageInitStartMessage")) {
							context.QueueTasks.Enqueue("CurrencyRateDetailGridPageInitStartMessage");
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

	#region Class: CurrencyRateDetailGridPageEventsProcess

	/// <exclude/>
	public class CurrencyRateDetailGridPageEventsProcess : CurrencyRateDetailGridPageEventsProcess<Terrasoft.WebApp.CurrencyRateDetailGridPageSchemaUserControl>
	{

		public CurrencyRateDetailGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CurrencyRateDetailGridPageSchemaUserControl

	/// <exclude/>
	public partial class CurrencyRateDetailGridPageSchemaUserControl : Terrasoft.WebApp.BaseManyToManyDetailGridPageSchemaUserControl
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
			var process = (CurrencyRateDetailGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new CurrencyRateDetailGridPageEventsProcess(UserConnection);
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
			SchemaName = "CurrencyRateDetailGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: CurrencyRateDetailGridPageEventsProcessSchema

	/// <exclude/>
	public class CurrencyRateDetailGridPageEventsProcessSchema : Terrasoft.WebApp.BaseManyToManyDetailGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public CurrencyRateDetailGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CurrencyRateDetailGridPageEventsProcessSchema(CurrencyRateDetailGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CurrencyRateDetailGridPageEventsProcess";
			UId = new Guid("11a6496c-3a61-4acb-8e16-a5261845f227");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
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

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet829 = CreateLaneSet829LaneSet();
			LaneSets.Add(schemaLaneSet829);
			ProcessSchemaLane schemaLane3018 = CreateLane3018Lane();
			schemaLaneSet829.Lanes.Add(schemaLane3018);
			ProcessSchemaEventSubProcess currencyratedetailgridpageoverrideinitsubprocess = CreateCurrencyRateDetailGridPageOverrideInitSubProcessEventSubProcess();
			FlowElements.Add(currencyratedetailgridpageoverrideinitsubprocess);
			ProcessSchemaStartMessageEvent currencyratedetailgridpageinitstartmessage = CreateCurrencyRateDetailGridPageInitStartMessageStartMessageEvent();
			currencyratedetailgridpageoverrideinitsubprocess.FlowElements.Add(currencyratedetailgridpageinitstartmessage);
			ProcessSchemaScriptTask currencyratedetailgridpageinitscripttask = CreateCurrencyRateDetailGridPageInitScriptTaskScriptTask();
			currencyratedetailgridpageoverrideinitsubprocess.FlowElements.Add(currencyratedetailgridpageinitscripttask);
			ProcessSchemaIntermediateThrowMessageEvent currencyratedetailgridpageinitintermediatethrowmessageevent = CreateCurrencyRateDetailGridPageInitIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			currencyratedetailgridpageoverrideinitsubprocess.FlowElements.Add(currencyratedetailgridpageinitintermediatethrowmessageevent);
			FlowElements.Add(CreateSequenceFlow17930SequenceFlow());
			FlowElements.Add(CreateSequenceFlow17931SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow17930SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow17930",
				UId = new Guid("044fd38d-93c2-41fb-9cee-a2904e3985d2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("11a6496c-3a61-4acb-8e16-a5261845f227"),
				CurveCenterPosition = new Point(171, 98),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("11a6496c-3a61-4acb-8e16-a5261845f227"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2f089faf-4423-4948-879c-d24b826711fe"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("11c59bd4-e1e4-498b-82c0-d6188d6d7809"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow17931SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow17931",
				UId = new Guid("17937d83-1061-46f3-9ac4-600a6139f6c5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("11a6496c-3a61-4acb-8e16-a5261845f227"),
				CurveCenterPosition = new Point(312, 98),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("11a6496c-3a61-4acb-8e16-a5261845f227"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("11c59bd4-e1e4-498b-82c0-d6188d6d7809"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("49d7c915-5949-48c3-b209-bdb8cf1581d8"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet829LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet829 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("54614334-0364-4e12-aeae-96aa8c9f5ac8"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("11a6496c-3a61-4acb-8e16-a5261845f227"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("11a6496c-3a61-4acb-8e16-a5261845f227"),
				Name = @"LaneSet829",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(718, 184),
				UseBackgroundMode = false
			};
			return schemaLaneSet829;
		}

		protected virtual ProcessSchemaLane CreateLane3018Lane() {
			ProcessSchemaLane schemaLane3018 = new ProcessSchemaLane(this) {
				UId = new Guid("1c8669bc-2c96-4160-ae50-9d2638b7a17c"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("54614334-0364-4e12-aeae-96aa8c9f5ac8"),
				CreatedInOwnerSchemaUId = new Guid("529e3b57-a4d0-404e-ba32-04682da85192"),
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("11a6496c-3a61-4acb-8e16-a5261845f227"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("11a6496c-3a61-4acb-8e16-a5261845f227"),
				Name = @"Lane3018",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(689, 184),
				UseBackgroundMode = false
			};
			return schemaLane3018;
		}

		protected virtual ProcessSchemaEventSubProcess CreateCurrencyRateDetailGridPageOverrideInitSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaCurrencyRateDetailGridPageOverrideInitSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("bea75645-bcc5-406e-a6dc-d3e9c3a769c9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1c8669bc-2c96-4160-ae50-9d2638b7a17c"),
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("11a6496c-3a61-4acb-8e16-a5261845f227"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("11a6496c-3a61-4acb-8e16-a5261845f227"),
				Name = @"CurrencyRateDetailGridPageOverrideInitSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(393, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaCurrencyRateDetailGridPageOverrideInitSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCurrencyRateDetailGridPageInitStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2f089faf-4423-4948-879c-d24b826711fe"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bea75645-bcc5-406e-a6dc-d3e9c3a769c9"),
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("11a6496c-3a61-4acb-8e16-a5261845f227"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("11a6496c-3a61-4acb-8e16-a5261845f227"),
				Name = @"CurrencyRateDetailGridPageInitStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCurrencyRateDetailGridPageInitScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("11c59bd4-e1e4-498b-82c0-d6188d6d7809"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bea75645-bcc5-406e-a6dc-d3e9c3a769c9"),
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("11a6496c-3a61-4acb-8e16-a5261845f227"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("11a6496c-3a61-4acb-8e16-a5261845f227"),
				Name = @"CurrencyRateDetailGridPageInitScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,77,201,44,9,72,76,79,13,245,76,81,176,85,200,75,45,87,112,47,205,76,209,80,178,52,76,77,75,78,52,48,211,53,52,51,75,212,53,49,180,48,212,77,52,49,74,213,77,178,52,51,53,76,51,180,52,74,50,72,85,210,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,60,217,195,96,76,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateCurrencyRateDetailGridPageInitIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("49d7c915-5949-48c3-b209-bdb8cf1581d8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bea75645-bcc5-406e-a6dc-d3e9c3a769c9"),
				CreatedInOwnerSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("11a6496c-3a61-4acb-8e16-a5261845f227"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("11a6496c-3a61-4acb-8e16-a5261845f227"),
				Name = @"CurrencyRateDetailGridPageInitIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(302, 65),
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
				UId = new Guid("2ef3f225-3b94-4535-9431-cc9fccdae4eb"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = Guid.Empty
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

		protected override SchemaMethod CreateGetRegisterEditPageScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterEditPageScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,240,44,118,205,43,201,44,169,116,73,45,73,204,204,209,84,168,230,229,226,44,74,45,41,45,202,83,72,74,44,78,213,115,79,45,9,74,77,207,44,46,73,45,114,77,201,44,9,72,76,79,13,78,46,202,44,40,209,72,133,114,67,61,83,116,20,138,43,139,125,243,83,74,115,82,65,138,60,83,52,173,121,185,106,21,82,115,138,83,145,13,44,46,41,202,204,75,215,115,205,45,40,169,4,41,0,0,27,204,239,221,128,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetRegisterAddPageScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterAddPageScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,61,142,65,10,194,48,16,69,215,246,20,161,171,22,36,23,40,46,170,6,233,66,17,139,7,136,205,24,70,211,180,100,166,98,16,239,110,227,162,203,255,255,227,241,241,46,138,134,148,103,228,184,7,214,232,74,241,201,86,1,120,10,94,220,52,129,60,0,95,192,34,49,132,218,152,179,182,208,118,1,71,46,192,32,167,120,109,204,90,80,164,227,96,38,7,106,110,83,193,113,132,198,148,85,246,21,224,8,146,53,193,114,118,108,39,230,193,203,250,161,223,234,5,158,73,238,28,118,79,217,162,245,218,157,116,15,98,35,242,5,252,143,121,181,188,34,14,232,173,84,253,200,113,214,255,0,77,63,40,24,195,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CurrencyRateDetailGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("11a6496c-3a61-4acb-8e16-a5261845f227"));
		}

		#endregion

	}

	#endregion

}

