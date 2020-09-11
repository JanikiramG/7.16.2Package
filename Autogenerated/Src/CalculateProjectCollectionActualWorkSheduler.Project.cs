namespace Terrasoft.Core.Process
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Configuration.ProjectService;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: CalculateProjectCollectionActualWorkShedulerSchema

	/// <exclude/>
	public class CalculateProjectCollectionActualWorkShedulerSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public CalculateProjectCollectionActualWorkShedulerSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public CalculateProjectCollectionActualWorkShedulerSchema(CalculateProjectCollectionActualWorkShedulerSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CalculateProjectCollectionActualWorkSheduler";
			UId = new Guid("10a4b33c-eb11-45da-bda7-7b4a81fee1f5");
			CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = true;
			SerializeToMemory = true;
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] {  };
			RealUId = new Guid("10a4b33c-eb11-45da-bda7-7b4a81fee1f5");
			Version = 0;
			PackageUId = new Guid("ca17ff09-8a8b-4af9-8a2a-ff4c0983ba30");
			UseSystemSecurityContext = false;
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
			ProcessSchemaStartEvent start1 = CreateStart1StartEvent();
			FlowElements.Add(start1);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			FlowElements.Add(terminate1);
			ProcessSchemaScriptTask calculateprojectcollectionactualworkscripttask = CreateCalculateProjectCollectionActualWorkScriptTaskScriptTask();
			FlowElements.Add(calculateprojectcollectionactualworkscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("449ea911-5a0e-4b5f-96ae-34790e96c4ff"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("10a4b33c-eb11-45da-bda7-7b4a81fee1f5"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("10a4b33c-eb11-45da-bda7-7b4a81fee1f5"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("74e26514-9019-4f98-a031-ee8110a8995e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("12783783-340a-4a65-8b84-0bf6384b866d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("1887873f-76f7-44f1-8095-575b2d17a058"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("10a4b33c-eb11-45da-bda7-7b4a81fee1f5"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("10a4b33c-eb11-45da-bda7-7b4a81fee1f5"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("12783783-340a-4a65-8b84-0bf6384b866d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c523ef31-e731-4236-a1cd-41f6f86659a2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("835e3f32-8d6a-41e4-8140-fcbc9e34a198"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("10a4b33c-eb11-45da-bda7-7b4a81fee1f5"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("10a4b33c-eb11-45da-bda7-7b4a81fee1f5"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("d72af235-75c7-4143-aeb5-434ed505c64f"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("835e3f32-8d6a-41e4-8140-fcbc9e34a198"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("10a4b33c-eb11-45da-bda7-7b4a81fee1f5"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("10a4b33c-eb11-45da-bda7-7b4a81fee1f5"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("74e26514-9019-4f98-a031-ee8110a8995e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d72af235-75c7-4143-aeb5-434ed505c64f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("10a4b33c-eb11-45da-bda7-7b4a81fee1f5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("10a4b33c-eb11-45da-bda7-7b4a81fee1f5"),
				Name = @"Start1",
				Position = new Point(50, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("c523ef31-e731-4236-a1cd-41f6f86659a2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d72af235-75c7-4143-aeb5-434ed505c64f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("10a4b33c-eb11-45da-bda7-7b4a81fee1f5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("10a4b33c-eb11-45da-bda7-7b4a81fee1f5"),
				Name = @"Terminate1",
				Position = new Point(600, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCalculateProjectCollectionActualWorkScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("12783783-340a-4a65-8b84-0bf6384b866d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d72af235-75c7-4143-aeb5-434ed505c64f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("10a4b33c-eb11-45da-bda7-7b4a81fee1f5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("10a4b33c-eb11-45da-bda7-7b4a81fee1f5"),
				Name = @"CalculateProjectCollectionActualWorkScriptTask",
				Position = new Point(295, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,82,93,79,131,48,20,125,134,132,255,208,236,169,36,134,248,62,93,50,201,92,246,224,130,78,221,115,3,119,174,90,218,121,219,206,16,179,255,110,187,130,3,244,177,135,123,62,238,185,20,168,222,161,52,27,192,35,47,129,28,134,207,91,34,225,139,20,3,144,190,104,192,92,73,233,32,174,100,58,77,226,133,52,220,52,155,114,15,53,123,180,128,77,167,179,208,159,173,198,159,145,145,76,214,31,120,96,146,189,1,94,145,73,107,61,241,46,71,134,132,87,185,18,182,150,78,245,98,145,205,171,22,166,61,240,73,41,19,228,178,37,152,2,121,205,176,9,99,107,86,3,77,59,205,150,115,207,133,1,28,10,231,8,204,64,248,178,229,102,95,48,116,84,247,208,52,128,185,170,15,12,185,86,242,185,57,64,182,210,107,43,132,207,205,16,164,233,167,239,169,6,170,246,177,233,192,60,157,18,146,196,131,84,231,90,56,232,97,46,183,80,232,203,237,35,66,129,255,156,133,239,8,29,201,100,185,178,210,144,25,185,78,201,119,18,71,59,229,54,44,247,132,142,45,27,194,229,56,67,160,68,189,209,85,213,203,117,166,249,104,190,138,246,32,175,76,88,184,89,90,94,205,104,119,187,204,215,239,243,69,209,240,119,203,114,38,74,43,92,227,109,113,243,210,88,38,182,10,63,238,154,162,115,164,191,222,103,141,83,18,159,124,103,8,198,162,36,6,45,76,127,0,152,114,33,137,213,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("bdbdefc2-e4c2-4cd8-9637-3fa3674b56bd"),
				Name = "Terrasoft.Configuration.ProjectService",
				Alias = "",
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new CalculateProjectCollectionActualWorkSheduler(userConnection);
		}

		public override object Clone() {
			return new CalculateProjectCollectionActualWorkShedulerSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("10a4b33c-eb11-45da-bda7-7b4a81fee1f5"));
		}

		#endregion

	}

	#endregion

	#region Class: CalculateProjectCollectionActualWorkSheduler

	/// <exclude/>
	public class CalculateProjectCollectionActualWorkSheduler : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, CalculateProjectCollectionActualWorkSheduler process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public CalculateProjectCollectionActualWorkSheduler(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CalculateProjectCollectionActualWorkSheduler";
			SchemaUId = new Guid("10a4b33c-eb11-45da-bda7-7b4a81fee1f5");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("10a4b33c-eb11-45da-bda7-7b4a81fee1f5");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: CalculateProjectCollectionActualWorkSheduler, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: CalculateProjectCollectionActualWorkSheduler, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		private Func<string> _notificationCaption;
		public virtual string NotificationCaption {
			get {
				return (_notificationCaption ?? (_notificationCaption = () => null)).Invoke();
			}
			set {
				_notificationCaption = () => { return value; };
			}
		}

		private ProcessLane1 _lane1;
		public ProcessLane1 Lane1 {
			get {
				return _lane1 ?? ((_lane1) = new ProcessLane1(UserConnection, this));
			}
		}

		private ProcessFlowElement _start1;
		public ProcessFlowElement Start1 {
			get {
				return _start1 ?? (_start1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "Start1",
					SchemaElementUId = new Guid("74e26514-9019-4f98-a031-ee8110a8995e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessTerminateEvent _terminate1;
		public ProcessTerminateEvent Terminate1 {
			get {
				return _terminate1 ?? (_terminate1 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "Terminate1",
					SchemaElementUId = new Guid("c523ef31-e731-4236-a1cd-41f6f86659a2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _calculateProjectCollectionActualWorkScriptTask;
		public ProcessScriptTask CalculateProjectCollectionActualWorkScriptTask {
			get {
				return _calculateProjectCollectionActualWorkScriptTask ?? (_calculateProjectCollectionActualWorkScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CalculateProjectCollectionActualWorkScriptTask",
					SchemaElementUId = new Guid("12783783-340a-4a65-8b84-0bf6384b866d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = CalculateProjectCollectionActualWorkScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start1.SchemaElementUId] = new Collection<ProcessFlowElement> { Start1 };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[CalculateProjectCollectionActualWorkScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CalculateProjectCollectionActualWorkScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("CalculateProjectCollectionActualWorkScriptTask", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "CalculateProjectCollectionActualWorkScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			if (IsProcessExecutedBySignal) {
				return;
			}
			context.QueueTasksV2.Enqueue(new ProcessQueueElement("Start1", string.Empty));
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

		protected override void InitializeMetaPathParameterValues() {
			base.InitializeMetaPathParameterValues();
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool CalculateProjectCollectionActualWorkScriptTaskExecute(ProcessExecutingContext context) {
			ProjectService projectService = new ProjectService(UserConnection);
			EntitySchemaQuery projectEsq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "Project");
			var idColumn = projectEsq.AddColumn(projectEsq.RootSchema.GetPrimaryColumnName());
			var projectFilter = projectEsq.CreateFilterWithParameters(FilterComparisonType.IsNull, "ParentProject");
			projectEsq.Filters.Add(projectFilter);  
			
			var projectEntities = projectEsq.GetEntityCollection(UserConnection);
			if (projectEntities.Count > 0) {
				foreach (var projectEntity in projectEntities) {
					var projectId = projectEntity.GetTypedColumnValue<Guid>(idColumn.Name);
					projectService.CalculateProjectActualWorkByProjectId(projectId);
				}
			}
			
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			base.ThrowEvent(context, message);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			if (Status == Core.Process.ProcessStatus.Inactive) {
				return;
			}
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer, writeFlowElements);
			WritePropertyValues(writer, false);
			writer.WriteFinishObject();
		}

		public override object CloneShallow() {
			var cloneItem = (CalculateProjectCollectionActualWorkSheduler)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

