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
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;

	#region Class: QuickAddMenuSettingsGridPageSchema

	/// <exclude/>
	public class QuickAddMenuSettingsGridPageSchema : Terrasoft.WebApp.BaseManyToManyGridPageSchema
	{

		#region Constructors: Public

		public QuickAddMenuSettingsGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public QuickAddMenuSettingsGridPageSchema(QuickAddMenuSettingsGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateParentTab() {
			ParentTab.Image = new ControlImage {};
			ParentTab.ModifiedInSchemaUId = new Guid("fb494891-305f-40ff-ac8e-b7f458bf0430");
		}

		private void UpdateDetailTab() {
			DetailTab.Image = new ControlImage {};
			DetailTab.ModifiedInSchemaUId = new Guid("fb494891-305f-40ff-ac8e-b7f458bf0430");
		}

		private void UpdateCloseButton() {
			CloseButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CloseButton.Image = new ControlImage {};
			CloseButton.ModifiedInSchemaUId = new Guid("fb494891-305f-40ff-ac8e-b7f458bf0430");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("fb494891-305f-40ff-ac8e-b7f458bf0430");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fb494891-305f-40ff-ac8e-b7f458bf0430");
			RealUId = new Guid("fb494891-305f-40ff-ac8e-b7f458bf0430");
			Name = "QuickAddMenuSettingsGridPage";
			ParentSchemaUId = new Guid("52f8c0bc-211e-42e7-a3cc-62a947032cf3");
			CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateQuickAddMenuSettingsGridPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateButtonsControlLayout();
			UpdateCloseButton();
			UpdateDetailTab();
			UpdateParentTab();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, ParentTabPanel);
			ParentTabPanel.MoveItem(0, ParentTab);
			TopLevelControl.MoveItem(2, DetailTabPanel);
			DetailTabPanel.MoveItem(0, DetailTab);
			TopLevelControl.MoveItem(3, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, Spacer1);
			ButtonsControlLayout.MoveItem(1, CloseButton);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateQuickAddMenuSettingsGridPageEventsProcessSchema() {
			var schema = new QuickAddMenuSettingsGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new QuickAddMenuSettingsGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new QuickAddMenuSettingsGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fb494891-305f-40ff-ac8e-b7f458bf0430"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new QuickAddMenuSettingsGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: QuickAddMenuSettingsGridPageEventsProcess

	/// <exclude/>
	public class QuickAddMenuSettingsGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseManyToManyGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.QuickAddMenuSettingsGridPageSchemaUserControl
	{

		public QuickAddMenuSettingsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "QuickAddMenuSettingsGridPageEventsProcess";
			SchemaUId = new Guid("fb494891-305f-40ff-ac8e-b7f458bf0430");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("fb494891-305f-40ff-ac8e-b7f458bf0430");
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

		private ProcessFlowElement _initEventSubProcess;
		public ProcessFlowElement InitEventSubProcess {
			get {
				return _initEventSubProcess ?? (_initEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "InitEventSubProcess",
					SchemaElementUId = new Guid("11a7722c-f5d9-4297-9395-2a69f3a257f3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _initEventMessage;
		public ProcessFlowElement InitEventMessage {
			get {
				return _initEventMessage ?? (_initEventMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "InitEventMessage",
					SchemaElementUId = new Guid("be44eb57-6b2f-4bbf-b2e8-0c7bd5f76c59"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _quickAddMenuSettingsInitScriptTask;
		public ProcessScriptTask QuickAddMenuSettingsInitScriptTask {
			get {
				return _quickAddMenuSettingsInitScriptTask ?? (_quickAddMenuSettingsInitScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "QuickAddMenuSettingsInitScriptTask",
					SchemaElementUId = new Guid("4446589f-cfff-4e87-b137-75da91db2e16"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = QuickAddMenuSettingsInitScriptTaskExecute,
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
					SchemaElementUId = new Guid("765d168b-dda2-49b5-9b00-4bb841517e69"),
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
			FlowElements[InitEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { InitEventSubProcess };
			FlowElements[InitEventMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { InitEventMessage };
			FlowElements[QuickAddMenuSettingsInitScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { QuickAddMenuSettingsInitScriptTask };
			FlowElements[InitIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { InitIntermediateThrowMessageEvent };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "InitEventSubProcess":
						break;
					case "InitEventMessage":
						e.Context.QueueTasks.Enqueue("QuickAddMenuSettingsInitScriptTask");
						break;
					case "QuickAddMenuSettingsInitScriptTask":
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
			ActivatedEventElements.Add("InitEventMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "InitEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "InitEventMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitEventMessage";
					result = InitEventMessage.Execute(context);
					break;
				case "QuickAddMenuSettingsInitScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "QuickAddMenuSettingsInitScriptTask";
					result = QuickAddMenuSettingsInitScriptTask.Execute(context, QuickAddMenuSettingsInitScriptTaskExecute);
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

		public virtual bool QuickAddMenuSettingsInitScriptTaskExecute(ProcessExecutingContext context) {
			// Идентификатор схемы страницы реестра основного справочника (UId схемы CountryGridPage).
			ParentGridPageSchemaId = new Guid("e31b3cd6-a95b-4416-8916-111fb5c5d5a8");
			
			// Идентификатор схемы объекта Country.
			ParentEntitySchemaId = new Guid("4aa8a1e1-77b5-421c-9e74-303810fbc561");
			
			// Идентификатор схемы страницы реестра подчиненного справочника (UId схемы CityGridPage).
			DetailGridPageSchemaId = new Guid("77bfdf0e-7591-471d-b5ce-2d7b679e2fba");
			
			// Идентификатор схемы объекта City.
			DetailEntitySchemaId = new Guid("a526ee14-e5f7-4174-8f48-ad030d8862af");
			
			// Идентификатор колонки Country объекта City.
			DetailAssociationColumnUId = new Guid("b743c56b-8c92-4c20-8fc7-fa62299d16fe");
			
			// Идентификатор первичной колонки City (идентификатор колонки Id).
			DetailSelectionColumnUId = new Guid("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			
			IsEntityDetail = true;
			
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Init":
							if (ActivatedEventElements.Contains("InitEventMessage")) {
							context.QueueTasks.Enqueue("InitEventMessage");
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

	#region Class: QuickAddMenuSettingsGridPageEventsProcess

	/// <exclude/>
	public class QuickAddMenuSettingsGridPageEventsProcess : QuickAddMenuSettingsGridPageEventsProcess<Terrasoft.WebApp.QuickAddMenuSettingsGridPageSchemaUserControl>
	{

		public QuickAddMenuSettingsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: QuickAddMenuSettingsGridPageSchemaUserControl

	/// <exclude/>
	public partial class QuickAddMenuSettingsGridPageSchemaUserControl : Terrasoft.WebApp.BaseManyToManyGridPageSchemaUserControl
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
			var process = (QuickAddMenuSettingsGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new QuickAddMenuSettingsGridPageEventsProcess(UserConnection);
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
			SchemaName = "QuickAddMenuSettingsGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: QuickAddMenuSettingsGridPageEventsProcessSchema

	/// <exclude/>
	public class QuickAddMenuSettingsGridPageEventsProcessSchema : Terrasoft.WebApp.BaseManyToManyGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public QuickAddMenuSettingsGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public QuickAddMenuSettingsGridPageEventsProcessSchema(QuickAddMenuSettingsGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "QuickAddMenuSettingsGridPageEventsProcess";
			UId = new Guid("2eb8d9a1-d067-4164-842b-56149ea900ed");
			CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106");
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
			ProcessSchemaEventSubProcess initeventsubprocess = CreateInitEventSubProcessEventSubProcess();
			FlowElements.Add(initeventsubprocess);
			ProcessSchemaStartMessageEvent initeventmessage = CreateInitEventMessageStartMessageEvent();
			initeventsubprocess.FlowElements.Add(initeventmessage);
			ProcessSchemaScriptTask quickaddmenusettingsinitscripttask = CreateQuickAddMenuSettingsInitScriptTaskScriptTask();
			initeventsubprocess.FlowElements.Add(quickaddmenusettingsinitscripttask);
			ProcessSchemaIntermediateThrowMessageEvent initintermediatethrowmessageevent = CreateInitIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			initeventsubprocess.FlowElements.Add(initintermediatethrowmessageevent);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("38d71bc0-864b-4955-86e3-c269a2fda66d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("2eb8d9a1-d067-4164-842b-56149ea900ed"),
				CurveCenterPosition = new Point(204, 92),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2eb8d9a1-d067-4164-842b-56149ea900ed"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("be44eb57-6b2f-4bbf-b2e8-0c7bd5f76c59"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4446589f-cfff-4e87-b137-75da91db2e16"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("4ae4af50-f44e-402a-8a69-3c8a83699082"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("2eb8d9a1-d067-4164-842b-56149ea900ed"),
				CurveCenterPosition = new Point(416, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2eb8d9a1-d067-4164-842b-56149ea900ed"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4446589f-cfff-4e87-b137-75da91db2e16"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("765d168b-dda2-49b5-9b00-4bb841517e69"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("43d3c9bc-d4e3-4e2f-9a34-4d140f8622d4"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("2eb8d9a1-d067-4164-842b-56149ea900ed"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("2eb8d9a1-d067-4164-842b-56149ea900ed"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(815, 184),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("780fd269-7cb8-4cc3-bce6-36c7f2f39fab"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("43d3c9bc-d4e3-4e2f-9a34-4d140f8622d4"),
				CreatedInOwnerSchemaUId = new Guid("fb494891-305f-40ff-ac8e-b7f458bf0430"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("2eb8d9a1-d067-4164-842b-56149ea900ed"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("2eb8d9a1-d067-4164-842b-56149ea900ed"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(786, 184),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateInitEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaInitEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("11a7722c-f5d9-4297-9395-2a69f3a257f3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("780fd269-7cb8-4cc3-bce6-36c7f2f39fab"),
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("2eb8d9a1-d067-4164-842b-56149ea900ed"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("2eb8d9a1-d067-4164-842b-56149ea900ed"),
				Name = @"InitEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(651, 163),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaInitEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitEventMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("be44eb57-6b2f-4bbf-b2e8-0c7bd5f76c59"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("11a7722c-f5d9-4297-9395-2a69f3a257f3"),
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("2eb8d9a1-d067-4164-842b-56149ea900ed"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("2eb8d9a1-d067-4164-842b-56149ea900ed"),
				Name = @"InitEventMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateQuickAddMenuSettingsInitScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4446589f-cfff-4e87-b137-75da91db2e16"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("11a7722c-f5d9-4297-9395-2a69f3a257f3"),
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("2eb8d9a1-d067-4164-842b-56149ea900ed"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2eb8d9a1-d067-4164-842b-56149ea900ed"),
				Name = @"QuickAddMenuSettingsInitScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(197, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,146,205,106,219,64,16,199,239,6,191,131,200,201,57,108,173,93,173,180,187,148,30,74,90,130,111,129,144,7,216,143,217,84,224,200,32,203,148,220,156,208,15,104,95,160,143,225,166,9,168,105,45,191,194,234,141,50,182,235,52,244,195,117,232,65,203,236,204,206,240,155,255,95,253,126,20,62,133,235,112,19,230,237,101,168,219,55,161,14,183,97,134,113,211,78,163,246,162,125,139,165,239,237,199,101,120,217,78,195,44,204,241,213,187,101,98,138,149,155,77,58,194,247,23,88,107,194,213,234,252,18,26,108,9,139,85,203,21,22,223,47,27,151,163,163,222,201,192,61,156,124,48,154,20,85,121,126,88,230,238,72,159,194,254,147,110,231,72,151,80,84,155,204,177,125,5,103,26,155,158,69,5,188,142,14,39,185,235,237,65,66,77,98,93,70,180,74,13,225,156,102,68,42,60,40,165,222,164,54,117,169,150,123,251,79,187,157,110,167,191,235,142,200,253,185,253,128,151,91,172,205,54,96,247,60,47,139,42,175,206,255,72,195,181,150,154,2,37,66,152,148,112,70,45,81,32,56,73,226,68,210,216,27,155,102,244,177,52,255,84,124,129,188,215,40,108,141,47,112,218,163,117,199,101,30,138,254,2,42,157,15,183,138,142,219,121,231,99,32,34,85,148,112,65,29,65,173,129,48,39,76,38,20,48,111,244,255,138,142,84,247,48,91,20,215,41,203,0,40,39,144,122,65,56,69,177,165,231,146,104,23,39,177,147,50,99,218,239,132,130,97,19,190,225,55,199,168,222,152,190,21,235,249,120,60,178,185,174,242,81,113,48,26,78,206,138,147,95,224,140,224,9,90,110,136,180,138,17,110,89,140,112,86,16,175,51,198,148,114,52,243,176,27,220,2,13,159,162,145,245,202,200,38,124,253,141,23,193,162,30,54,237,184,223,192,253,244,250,24,134,96,255,190,133,134,24,120,106,53,177,92,225,79,237,65,16,157,40,71,18,109,4,19,18,104,70,197,143,45,6,227,181,85,235,185,56,165,42,39,176,170,148,80,77,202,98,125,191,3,208,170,170,194,109,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateInitIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("765d168b-dda2-49b5-9b00-4bb841517e69"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("11a7722c-f5d9-4297-9395-2a69f3a257f3"),
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e"),
				CreatedInSchemaUId = new Guid("2eb8d9a1-d067-4164-842b-56149ea900ed"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("2eb8d9a1-d067-4164-842b-56149ea900ed"),
				Name = @"InitIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(421, 65),
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
				UId = new Guid("46b4da2e-0028-4749-9503-d1d38c64a418"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("8c3dfc4f-625c-4884-8962-32e1cb97064e")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new QuickAddMenuSettingsGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2eb8d9a1-d067-4164-842b-56149ea900ed"));
		}

		#endregion

	}

	#endregion

}

