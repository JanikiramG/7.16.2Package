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

	#region Class: DocumentStatusTypeEntryGridPageSchema

	/// <exclude/>
	public class DocumentStatusTypeEntryGridPageSchema : Terrasoft.WebApp.BaseManyToManyGridPageSchema
	{

		#region Constructors: Public

		public DocumentStatusTypeEntryGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public DocumentStatusTypeEntryGridPageSchema(DocumentStatusTypeEntryGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateParentTab() {
			ParentTab.Image = new ControlImage {};
			ParentTab.ModifiedInSchemaUId = new Guid("50643ace-c176-4878-9cc5-dde3be620995");
		}

		private void UpdateDetailTab() {
			DetailTab.Image = new ControlImage {};
			DetailTab.ModifiedInSchemaUId = new Guid("50643ace-c176-4878-9cc5-dde3be620995");
		}

		private void UpdateCloseButton() {
			CloseButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CloseButton.Image = new ControlImage {};
			CloseButton.ModifiedInSchemaUId = new Guid("50643ace-c176-4878-9cc5-dde3be620995");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("50643ace-c176-4878-9cc5-dde3be620995");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("50643ace-c176-4878-9cc5-dde3be620995");
			RealUId = new Guid("50643ace-c176-4878-9cc5-dde3be620995");
			Name = "DocumentStatusTypeEntryGridPage";
			ParentSchemaUId = new Guid("52f8c0bc-211e-42e7-a3cc-62a947032cf3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateDocumentStatusTypeEntryGridPageEventsProcessSchema();
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

		protected virtual EmbeddedProcessSchema CreateDocumentStatusTypeEntryGridPageEventsProcessSchema() {
			var schema = new DocumentStatusTypeEntryGridPageEventsProcessSchema(ProcessSchemaManager, this);
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
			return new DocumentStatusTypeEntryGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new DocumentStatusTypeEntryGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("50643ace-c176-4878-9cc5-dde3be620995"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new DocumentStatusTypeEntryGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: DocumentStatusTypeEntryGridPageEventsProcess

	/// <exclude/>
	public class DocumentStatusTypeEntryGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseManyToManyGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.DocumentStatusTypeEntryGridPageSchemaUserControl
	{

		public DocumentStatusTypeEntryGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DocumentStatusTypeEntryGridPageEventsProcess";
			SchemaUId = new Guid("50643ace-c176-4878-9cc5-dde3be620995");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("50643ace-c176-4878-9cc5-dde3be620995");
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
					SchemaElementUId = new Guid("c67d5ceb-4c4c-4557-85a0-5ac72c059a90"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _ducumentStatusTypeEntryGridPageInitStartMessage;
		public ProcessFlowElement DucumentStatusTypeEntryGridPageInitStartMessage {
			get {
				return _ducumentStatusTypeEntryGridPageInitStartMessage ?? (_ducumentStatusTypeEntryGridPageInitStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DucumentStatusTypeEntryGridPageInitStartMessage",
					SchemaElementUId = new Guid("fd30a718-4171-4044-b792-25c5def28ebf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _ducumentStatusTypeEntryGridPageInitScriptTask;
		public ProcessScriptTask DucumentStatusTypeEntryGridPageInitScriptTask {
			get {
				return _ducumentStatusTypeEntryGridPageInitScriptTask ?? (_ducumentStatusTypeEntryGridPageInitScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DucumentStatusTypeEntryGridPageInitScriptTask",
					SchemaElementUId = new Guid("51343511-69c8-4ff4-96dd-9383b444f698"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DucumentStatusTypeEntryGridPageInitScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _ducumentStatusTypeEntryGridPageInitIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent DucumentStatusTypeEntryGridPageInitIntermediateThrowMessageEvent {
			get {
				return _ducumentStatusTypeEntryGridPageInitIntermediateThrowMessageEvent ?? (_ducumentStatusTypeEntryGridPageInitIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "DucumentStatusTypeEntryGridPageInitIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("81c5c35a-6893-4f20-9b57-2420b10c796f"),
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
			FlowElements[DucumentStatusTypeEntryGridPageInitStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DucumentStatusTypeEntryGridPageInitStartMessage };
			FlowElements[DucumentStatusTypeEntryGridPageInitScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DucumentStatusTypeEntryGridPageInitScriptTask };
			FlowElements[DucumentStatusTypeEntryGridPageInitIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { DucumentStatusTypeEntryGridPageInitIntermediateThrowMessageEvent };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "DucumentStatusTypeEntryGridPageInitStartMessage":
						e.Context.QueueTasks.Enqueue("DucumentStatusTypeEntryGridPageInitScriptTask");
						break;
					case "DucumentStatusTypeEntryGridPageInitScriptTask":
						e.Context.QueueTasks.Enqueue("DucumentStatusTypeEntryGridPageInitIntermediateThrowMessageEvent");
						break;
					case "DucumentStatusTypeEntryGridPageInitIntermediateThrowMessageEvent":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("DucumentStatusTypeEntryGridPageInitStartMessage");
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
				case "DucumentStatusTypeEntryGridPageInitStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "DucumentStatusTypeEntryGridPageInitStartMessage";
					result = DucumentStatusTypeEntryGridPageInitStartMessage.Execute(context);
					break;
				case "DucumentStatusTypeEntryGridPageInitScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DucumentStatusTypeEntryGridPageInitScriptTask";
					result = DucumentStatusTypeEntryGridPageInitScriptTask.Execute(context, DucumentStatusTypeEntryGridPageInitScriptTaskExecute);
					break;
				case "DucumentStatusTypeEntryGridPageInitIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = DucumentStatusTypeEntryGridPageInitIntermediateThrowMessageEvent.Execute(context);
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

		public virtual bool DucumentStatusTypeEntryGridPageInitScriptTaskExecute(ProcessExecutingContext context) {
			// Set parameters for parent detail compliance
			ParentGridPageSchemaId = new Guid("39f129b6-b225-4949-95a6-820d78cf6294");
			ParentEntitySchemaId = new Guid("d32d5914-e52f-40c6-a0eb-f80ef1d2e252");
			DetailGridPageSchemaId = new Guid("955b45a6-2849-4729-b1a9-facec23ccdf1");
			DetailEntitySchemaId = new Guid("ff4fb6bb-9770-4264-8083-c1290cc0039b");
			DetailAssociationColumnUId = new Guid("1fb4771c-59ad-4923-9106-0e1e76b9a96a");
			DetailSelectionColumnUId = new Guid("43c02c0b-5823-45b7-9984-ae9d934042cb");
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Init":
							if (ActivatedEventElements.Contains("DucumentStatusTypeEntryGridPageInitStartMessage")) {
							context.QueueTasks.Enqueue("DucumentStatusTypeEntryGridPageInitStartMessage");
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

	#region Class: DocumentStatusTypeEntryGridPageEventsProcess

	/// <exclude/>
	public class DocumentStatusTypeEntryGridPageEventsProcess : DocumentStatusTypeEntryGridPageEventsProcess<Terrasoft.WebApp.DocumentStatusTypeEntryGridPageSchemaUserControl>
	{

		public DocumentStatusTypeEntryGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: DocumentStatusTypeEntryGridPageSchemaUserControl

	/// <exclude/>
	public partial class DocumentStatusTypeEntryGridPageSchemaUserControl : Terrasoft.WebApp.BaseManyToManyGridPageSchemaUserControl
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
			var process = (DocumentStatusTypeEntryGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new DocumentStatusTypeEntryGridPageEventsProcess(UserConnection);
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
			SchemaName = "DocumentStatusTypeEntryGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: DocumentStatusTypeEntryGridPageEventsProcessSchema

	/// <exclude/>
	public class DocumentStatusTypeEntryGridPageEventsProcessSchema : Terrasoft.WebApp.BaseManyToManyGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public DocumentStatusTypeEntryGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public DocumentStatusTypeEntryGridPageEventsProcessSchema(DocumentStatusTypeEntryGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "DocumentStatusTypeEntryGridPageEventsProcess";
			UId = new Guid("bb7594a9-bec6-400e-ae21-00e8d41343de");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
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
			ProcessSchemaLaneSet schemaLaneSet410 = CreateLaneSet410LaneSet();
			LaneSets.Add(schemaLaneSet410);
			ProcessSchemaLane schemaLane1218 = CreateLane1218Lane();
			schemaLaneSet410.Lanes.Add(schemaLane1218);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaStartMessageEvent ducumentstatustypeentrygridpageinitstartmessage = CreateDucumentStatusTypeEntryGridPageInitStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(ducumentstatustypeentrygridpageinitstartmessage);
			ProcessSchemaScriptTask ducumentstatustypeentrygridpageinitscripttask = CreateDucumentStatusTypeEntryGridPageInitScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(ducumentstatustypeentrygridpageinitscripttask);
			ProcessSchemaIntermediateThrowMessageEvent ducumentstatustypeentrygridpageinitintermediatethrowmessageevent = CreateDucumentStatusTypeEntryGridPageInitIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(ducumentstatustypeentrygridpageinitintermediatethrowmessageevent);
			FlowElements.Add(CreateSequenceFlow6886SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6887SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6886SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6886",
				UId = new Guid("d72e1ffd-0e98-44a5-8e7e-f24fa130b1da"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("bb7594a9-bec6-400e-ae21-00e8d41343de"),
				CurveCenterPosition = new Point(183, 92),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bb7594a9-bec6-400e-ae21-00e8d41343de"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fd30a718-4171-4044-b792-25c5def28ebf"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("51343511-69c8-4ff4-96dd-9383b444f698"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6887SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6887",
				UId = new Guid("3723e3e9-c713-49b4-946e-8f59fc90bfba"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("bb7594a9-bec6-400e-ae21-00e8d41343de"),
				CurveCenterPosition = new Point(338, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bb7594a9-bec6-400e-ae21-00e8d41343de"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("51343511-69c8-4ff4-96dd-9383b444f698"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("81c5c35a-6893-4f20-9b57-2420b10c796f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet410LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet410 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("b1c32e8f-acfc-4ec3-aa6c-ee848aeb2462"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("bb7594a9-bec6-400e-ae21-00e8d41343de"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("bb7594a9-bec6-400e-ae21-00e8d41343de"),
				Name = @"LaneSet410",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(791, 177),
				UseBackgroundMode = false
			};
			return schemaLaneSet410;
		}

		protected virtual ProcessSchemaLane CreateLane1218Lane() {
			ProcessSchemaLane schemaLane1218 = new ProcessSchemaLane(this) {
				UId = new Guid("a3e85b54-2348-4ac6-a58e-9c1bbaf1f8b5"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("b1c32e8f-acfc-4ec3-aa6c-ee848aeb2462"),
				CreatedInOwnerSchemaUId = new Guid("50643ace-c176-4878-9cc5-dde3be620995"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("bb7594a9-bec6-400e-ae21-00e8d41343de"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("bb7594a9-bec6-400e-ae21-00e8d41343de"),
				Name = @"Lane1218",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(762, 177),
				UseBackgroundMode = false
			};
			return schemaLane1218;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c67d5ceb-4c4c-4557-85a0-5ac72c059a90"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a3e85b54-2348-4ac6-a58e-9c1bbaf1f8b5"),
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("bb7594a9-bec6-400e-ae21-00e8d41343de"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("bb7594a9-bec6-400e-ae21-00e8d41343de"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(350, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDucumentStatusTypeEntryGridPageInitStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("fd30a718-4171-4044-b792-25c5def28ebf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c67d5ceb-4c4c-4557-85a0-5ac72c059a90"),
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("bb7594a9-bec6-400e-ae21-00e8d41343de"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("bb7594a9-bec6-400e-ae21-00e8d41343de"),
				Name = @"DucumentStatusTypeEntryGridPageInitStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(21, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDucumentStatusTypeEntryGridPageInitScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("51343511-69c8-4ff4-96dd-9383b444f698"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c67d5ceb-4c4c-4557-85a0-5ac72c059a90"),
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("bb7594a9-bec6-400e-ae21-00e8d41343de"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("bb7594a9-bec6-400e-ae21-00e8d41343de"),
				Name = @"DucumentStatusTypeEntryGridPageInitScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(147, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,208,205,74,3,49,16,192,241,187,79,17,122,210,195,208,100,54,201,102,40,30,68,165,120,43,20,31,32,153,76,116,97,63,202,54,69,124,123,183,69,40,136,122,28,6,126,252,103,214,107,181,151,170,14,113,142,131,84,153,143,170,76,243,121,148,177,170,44,53,118,189,226,105,56,244,93,28,89,110,118,151,197,118,238,242,46,190,201,158,223,101,136,47,89,221,171,81,62,212,246,212,229,219,85,67,197,32,37,15,9,209,129,37,75,64,46,122,8,168,115,27,184,120,36,187,186,219,124,83,207,99,237,234,231,175,80,110,48,59,50,22,196,97,1,171,217,67,212,146,160,4,45,197,100,20,116,120,134,158,46,149,255,54,145,115,201,158,35,48,44,57,182,69,130,100,34,65,137,44,140,13,115,46,230,74,253,211,84,138,45,201,167,4,212,182,26,44,122,11,65,135,6,120,57,89,51,107,221,80,186,66,15,199,227,196,93,172,221,52,62,78,253,105,24,95,127,112,166,36,219,182,134,193,81,204,203,175,176,1,50,218,131,22,35,173,79,20,201,199,43,183,151,94,248,111,204,54,172,145,117,2,23,22,199,186,212,2,81,176,16,133,50,53,86,91,228,75,219,44,245,52,143,170,206,39,217,124,1,230,102,92,48,255,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateDucumentStatusTypeEntryGridPageInitIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("81c5c35a-6893-4f20-9b57-2420b10c796f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c67d5ceb-4c4c-4557-85a0-5ac72c059a90"),
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("bb7594a9-bec6-400e-ae21-00e8d41343de"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("bb7594a9-bec6-400e-ae21-00e8d41343de"),
				Name = @"DucumentStatusTypeEntryGridPageInitIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(308, 63),
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
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new DocumentStatusTypeEntryGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bb7594a9-bec6-400e-ae21-00e8d41343de"));
		}

		#endregion

	}

	#endregion

}

