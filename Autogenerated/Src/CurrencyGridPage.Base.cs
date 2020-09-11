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
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;

	#region Class: CurrencyGridPageSchema

	/// <exclude/>
	public class CurrencyGridPageSchema : Terrasoft.WebApp.BaseManyToManyGridPageSchema
	{

		#region Constructors: Public

		public CurrencyGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public CurrencyGridPageSchema(CurrencyGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateParentTab() {
			ParentTab.Image = new ControlImage {};
			ParentTab.ModifiedInSchemaUId = new Guid("c65115cc-5893-4995-8880-14c917d4793b");
		}

		private void UpdateDetailTab() {
			DetailTab.Image = new ControlImage {};
			DetailTab.ModifiedInSchemaUId = new Guid("c65115cc-5893-4995-8880-14c917d4793b");
		}

		private void UpdateCloseButton() {
			CloseButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CloseButton.Image = new ControlImage {};
			CloseButton.ModifiedInSchemaUId = new Guid("c65115cc-5893-4995-8880-14c917d4793b");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("c65115cc-5893-4995-8880-14c917d4793b");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c65115cc-5893-4995-8880-14c917d4793b");
			RealUId = new Guid("c65115cc-5893-4995-8880-14c917d4793b");
			Name = "CurrencyGridPage";
			ParentSchemaUId = new Guid("52f8c0bc-211e-42e7-a3cc-62a947032cf3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCurrencyGridPageEventsProcessSchema();
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

		protected virtual EmbeddedProcessSchema CreateCurrencyGridPageEventsProcessSchema() {
			var schema = new CurrencyGridPageEventsProcessSchema(ProcessSchemaManager, this);
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
			return new CurrencyGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new CurrencyGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c65115cc-5893-4995-8880-14c917d4793b"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new CurrencyGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: CurrencyGridPageEventsProcess

	/// <exclude/>
	public class CurrencyGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseManyToManyGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.CurrencyGridPageSchemaUserControl
	{

		public CurrencyGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CurrencyGridPageEventsProcess";
			SchemaUId = new Guid("c65115cc-5893-4995-8880-14c917d4793b");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c65115cc-5893-4995-8880-14c917d4793b");
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

		private ProcessFlowElement _currencyRateEditGridPageInitOverrideSubProcess;
		public ProcessFlowElement CurrencyRateEditGridPageInitOverrideSubProcess {
			get {
				return _currencyRateEditGridPageInitOverrideSubProcess ?? (_currencyRateEditGridPageInitOverrideSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "CurrencyRateEditGridPageInitOverrideSubProcess",
					SchemaElementUId = new Guid("7732a4fc-1fad-4790-9acc-f984afb183f8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _currencyRateEditGridPageInitStartMessage;
		public ProcessFlowElement CurrencyRateEditGridPageInitStartMessage {
			get {
				return _currencyRateEditGridPageInitStartMessage ?? (_currencyRateEditGridPageInitStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CurrencyRateEditGridPageInitStartMessage",
					SchemaElementUId = new Guid("e8c77c60-4b31-4e3a-b990-fb3c5eb2fa37"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _currencyRateEditGridPageInitScriptTask;
		public ProcessScriptTask CurrencyRateEditGridPageInitScriptTask {
			get {
				return _currencyRateEditGridPageInitScriptTask ?? (_currencyRateEditGridPageInitScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CurrencyRateEditGridPageInitScriptTask",
					SchemaElementUId = new Guid("712d848a-ab5d-40bc-aaf1-9e41c5b1beae"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CurrencyRateEditGridPageInitScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _currencyRateEditGridPageInitIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent CurrencyRateEditGridPageInitIntermediateThrowMessageEvent {
			get {
				return _currencyRateEditGridPageInitIntermediateThrowMessageEvent ?? (_currencyRateEditGridPageInitIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "CurrencyRateEditGridPageInitIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("679fedc5-97b8-495e-a167-7f4f4127c995"),
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
			FlowElements[CurrencyRateEditGridPageInitOverrideSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { CurrencyRateEditGridPageInitOverrideSubProcess };
			FlowElements[CurrencyRateEditGridPageInitStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { CurrencyRateEditGridPageInitStartMessage };
			FlowElements[CurrencyRateEditGridPageInitScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CurrencyRateEditGridPageInitScriptTask };
			FlowElements[CurrencyRateEditGridPageInitIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { CurrencyRateEditGridPageInitIntermediateThrowMessageEvent };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "CurrencyRateEditGridPageInitOverrideSubProcess":
						break;
					case "CurrencyRateEditGridPageInitStartMessage":
						e.Context.QueueTasks.Enqueue("CurrencyRateEditGridPageInitScriptTask");
						break;
					case "CurrencyRateEditGridPageInitScriptTask":
						e.Context.QueueTasks.Enqueue("CurrencyRateEditGridPageInitIntermediateThrowMessageEvent");
						break;
					case "CurrencyRateEditGridPageInitIntermediateThrowMessageEvent":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("CurrencyRateEditGridPageInitStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "CurrencyRateEditGridPageInitOverrideSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "CurrencyRateEditGridPageInitStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "CurrencyRateEditGridPageInitStartMessage";
					result = CurrencyRateEditGridPageInitStartMessage.Execute(context);
					break;
				case "CurrencyRateEditGridPageInitScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CurrencyRateEditGridPageInitScriptTask";
					result = CurrencyRateEditGridPageInitScriptTask.Execute(context, CurrencyRateEditGridPageInitScriptTaskExecute);
					break;
				case "CurrencyRateEditGridPageInitIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = CurrencyRateEditGridPageInitIntermediateThrowMessageEvent.Execute(context);
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

		public virtual bool CurrencyRateEditGridPageInitScriptTaskExecute(ProcessExecutingContext context) {
			// Set parameters for parent detail association
			ParentGridPageSchemaId = new Guid("39f129b6-b225-4949-95a6-820d78cf6294");
			ParentEntitySchemaId = new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d");
			DetailGridPageSchemaId = new Guid("529e3b57-a4d0-404e-ba32-04682da85192");
			DetailEntitySchemaId = new Guid("e14c6037-56bb-4724-95b6-3dc29d7f6b4f");
			DetailAssociationColumnUId = new Guid("84ce4c1c-f001-4109-86fa-c9b36e8fd5d7");
			IsEntityDetail = true;
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Init":
							if (ActivatedEventElements.Contains("CurrencyRateEditGridPageInitStartMessage")) {
							context.QueueTasks.Enqueue("CurrencyRateEditGridPageInitStartMessage");
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

	#region Class: CurrencyGridPageEventsProcess

	/// <exclude/>
	public class CurrencyGridPageEventsProcess : CurrencyGridPageEventsProcess<Terrasoft.WebApp.CurrencyGridPageSchemaUserControl>
	{

		public CurrencyGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CurrencyGridPageSchemaUserControl

	/// <exclude/>
	public partial class CurrencyGridPageSchemaUserControl : Terrasoft.WebApp.BaseManyToManyGridPageSchemaUserControl
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
			var process = (CurrencyGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new CurrencyGridPageEventsProcess(UserConnection);
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
			SchemaName = "CurrencyGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: CurrencyGridPageEventsProcessSchema

	/// <exclude/>
	public class CurrencyGridPageEventsProcessSchema : Terrasoft.WebApp.BaseManyToManyGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public CurrencyGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CurrencyGridPageEventsProcessSchema(CurrencyGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CurrencyGridPageEventsProcess";
			UId = new Guid("2f5f630c-dcd8-441b-8b5b-b89e027df6a7");
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
			ProcessSchemaLaneSet schemaLaneSet398 = CreateLaneSet398LaneSet();
			LaneSets.Add(schemaLaneSet398);
			ProcessSchemaLane schemaLane1198 = CreateLane1198Lane();
			schemaLaneSet398.Lanes.Add(schemaLane1198);
			ProcessSchemaEventSubProcess currencyrateeditgridpageinitoverridesubprocess = CreateCurrencyRateEditGridPageInitOverrideSubProcessEventSubProcess();
			FlowElements.Add(currencyrateeditgridpageinitoverridesubprocess);
			ProcessSchemaStartMessageEvent currencyrateeditgridpageinitstartmessage = CreateCurrencyRateEditGridPageInitStartMessageStartMessageEvent();
			currencyrateeditgridpageinitoverridesubprocess.FlowElements.Add(currencyrateeditgridpageinitstartmessage);
			ProcessSchemaScriptTask currencyrateeditgridpageinitscripttask = CreateCurrencyRateEditGridPageInitScriptTaskScriptTask();
			currencyrateeditgridpageinitoverridesubprocess.FlowElements.Add(currencyrateeditgridpageinitscripttask);
			ProcessSchemaIntermediateThrowMessageEvent currencyrateeditgridpageinitintermediatethrowmessageevent = CreateCurrencyRateEditGridPageInitIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			currencyrateeditgridpageinitoverridesubprocess.FlowElements.Add(currencyrateeditgridpageinitintermediatethrowmessageevent);
			FlowElements.Add(CreateSequenceFlow6830SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6831SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6830SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6830",
				UId = new Guid("3b0228b6-0b5d-45e8-b036-7a431700d301"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f5f630c-dcd8-441b-8b5b-b89e027df6a7"),
				CurveCenterPosition = new Point(168, 92),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2f5f630c-dcd8-441b-8b5b-b89e027df6a7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e8c77c60-4b31-4e3a-b990-fb3c5eb2fa37"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("712d848a-ab5d-40bc-aaf1-9e41c5b1beae"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6831SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6831",
				UId = new Guid("013e74b5-2be8-40cd-a218-2bec60902f5b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f5f630c-dcd8-441b-8b5b-b89e027df6a7"),
				CurveCenterPosition = new Point(328, 92),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2f5f630c-dcd8-441b-8b5b-b89e027df6a7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("712d848a-ab5d-40bc-aaf1-9e41c5b1beae"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("679fedc5-97b8-495e-a167-7f4f4127c995"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet398LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet398 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("e4306f93-c938-4576-91a7-8acb794705bf"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f5f630c-dcd8-441b-8b5b-b89e027df6a7"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("2f5f630c-dcd8-441b-8b5b-b89e027df6a7"),
				Name = @"LaneSet398",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(791, 177),
				UseBackgroundMode = false
			};
			return schemaLaneSet398;
		}

		protected virtual ProcessSchemaLane CreateLane1198Lane() {
			ProcessSchemaLane schemaLane1198 = new ProcessSchemaLane(this) {
				UId = new Guid("73a8349d-156d-44ae-9889-65d722ea209d"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("e4306f93-c938-4576-91a7-8acb794705bf"),
				CreatedInOwnerSchemaUId = new Guid("c65115cc-5893-4995-8880-14c917d4793b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f5f630c-dcd8-441b-8b5b-b89e027df6a7"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("2f5f630c-dcd8-441b-8b5b-b89e027df6a7"),
				Name = @"Lane1198",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(762, 177),
				UseBackgroundMode = false
			};
			return schemaLane1198;
		}

		protected virtual ProcessSchemaEventSubProcess CreateCurrencyRateEditGridPageInitOverrideSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaCurrencyRateEditGridPageInitOverrideSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7732a4fc-1fad-4790-9acc-f984afb183f8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("73a8349d-156d-44ae-9889-65d722ea209d"),
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f5f630c-dcd8-441b-8b5b-b89e027df6a7"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("2f5f630c-dcd8-441b-8b5b-b89e027df6a7"),
				Name = @"CurrencyRateEditGridPageInitOverrideSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(357, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaCurrencyRateEditGridPageInitOverrideSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCurrencyRateEditGridPageInitStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e8c77c60-4b31-4e3a-b990-fb3c5eb2fa37"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7732a4fc-1fad-4790-9acc-f984afb183f8"),
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f5f630c-dcd8-441b-8b5b-b89e027df6a7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("2f5f630c-dcd8-441b-8b5b-b89e027df6a7"),
				Name = @"CurrencyRateEditGridPageInitStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(14, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCurrencyRateEditGridPageInitScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("712d848a-ab5d-40bc-aaf1-9e41c5b1beae"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7732a4fc-1fad-4790-9acc-f984afb183f8"),
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f5f630c-dcd8-441b-8b5b-b89e027df6a7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2f5f630c-dcd8-441b-8b5b-b89e027df6a7"),
				Name = @"CurrencyRateEditGridPageInitScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(140, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,208,77,75,195,64,16,6,224,187,224,127,88,122,210,195,208,205,236,236,23,226,65,84,74,111,133,226,15,216,143,89,13,180,137,36,27,196,127,111,76,17,139,72,143,179,195,62,188,239,172,215,98,207,85,188,135,33,28,185,242,48,138,210,15,223,35,119,85,100,174,161,61,136,48,142,125,106,67,109,251,238,250,106,183,172,54,67,155,119,225,149,247,233,141,143,97,155,197,189,232,248,67,108,166,54,223,172,148,47,13,250,104,32,34,106,32,79,30,188,14,6,28,202,108,93,42,6,61,173,110,239,126,172,231,174,182,245,243,95,9,179,50,33,205,95,117,116,9,168,65,4,111,200,65,12,69,69,91,28,106,147,23,233,105,73,122,49,149,70,207,42,106,11,129,178,4,146,196,51,163,16,36,25,135,57,56,221,120,60,179,46,164,226,134,146,145,202,130,54,49,2,89,164,185,223,92,87,229,132,62,219,98,34,149,51,233,225,247,124,143,253,97,58,118,47,127,60,71,137,41,53,9,138,148,205,220,82,122,112,166,4,72,62,42,195,174,100,157,237,226,109,199,83,170,147,59,27,117,152,120,126,31,184,78,67,119,154,190,0,97,180,253,159,209,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateCurrencyRateEditGridPageInitIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("679fedc5-97b8-495e-a167-7f4f4127c995"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7732a4fc-1fad-4790-9acc-f984afb183f8"),
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f5f630c-dcd8-441b-8b5b-b89e027df6a7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("2f5f630c-dcd8-441b-8b5b-b89e027df6a7"),
				Name = @"CurrencyRateEditGridPageInitIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(301, 63),
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

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CurrencyGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2f5f630c-dcd8-441b-8b5b-b89e027df6a7"));
		}

		#endregion

	}

	#endregion

}

