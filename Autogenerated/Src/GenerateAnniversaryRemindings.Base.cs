namespace Terrasoft.Core.Process
{

	using global::Common.Logging;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.Linq;
	using System.Reflection;
	using System.Text;
	using System.Threading.Tasks;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: GenerateAnniversaryRemindingsSchema

	/// <exclude/>
	public class GenerateAnniversaryRemindingsSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public GenerateAnniversaryRemindingsSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public GenerateAnniversaryRemindingsSchema(GenerateAnniversaryRemindingsSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "GenerateAnniversaryRemindings";
			UId = new Guid("ea728d44-cef0-4c18-8017-0e0532c7338e");
			CreatedInPackageId = new Guid("1cba1048-8bb6-403f-9352-2c23d14f5429");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.7.0.0";
			CultureName = @"ru-RU";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsLogging = false;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = false;
			SerializeToMemory = true;
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			UseForceCompile = true;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] {  };
			RealUId = new Guid("ea728d44-cef0-4c18-8017-0e0532c7338e");
			Version = 0;
			PackageUId = new Guid("5be3998b-c5c3-42bb-a01c-2e4149059a97");
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
			ProcessSchemaScriptTask generatereminding = CreateGenerateRemindingScriptTask();
			FlowElements.Add(generatereminding);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("fa41dea9-7551-47ab-9e2c-1763bd583484"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1cba1048-8bb6-403f-9352-2c23d14f5429"),
				CreatedInSchemaUId = new Guid("ea728d44-cef0-4c18-8017-0e0532c7338e"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ea728d44-cef0-4c18-8017-0e0532c7338e"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("528e9bac-1ed2-4e52-8225-6cb1c5f70e0e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c4cc0ca4-aabf-45e6-af76-18930d341b4c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("3d5af550-2a17-4078-8ba4-35edf569ca6f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1cba1048-8bb6-403f-9352-2c23d14f5429"),
				CreatedInSchemaUId = new Guid("ea728d44-cef0-4c18-8017-0e0532c7338e"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ea728d44-cef0-4c18-8017-0e0532c7338e"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c4cc0ca4-aabf-45e6-af76-18930d341b4c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("621e8ff4-222d-4239-a838-9104b30d406d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("22f42928-141f-4715-8685-d8996ebbbd4f"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1cba1048-8bb6-403f-9352-2c23d14f5429"),
				CreatedInSchemaUId = new Guid("ea728d44-cef0-4c18-8017-0e0532c7338e"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("ea728d44-cef0-4c18-8017-0e0532c7338e"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("2a8d5978-d804-4c5e-9392-eef26de94931"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("22f42928-141f-4715-8685-d8996ebbbd4f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("1cba1048-8bb6-403f-9352-2c23d14f5429"),
				CreatedInSchemaUId = new Guid("ea728d44-cef0-4c18-8017-0e0532c7338e"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("ea728d44-cef0-4c18-8017-0e0532c7338e"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("528e9bac-1ed2-4e52-8225-6cb1c5f70e0e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2a8d5978-d804-4c5e-9392-eef26de94931"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1cba1048-8bb6-403f-9352-2c23d14f5429"),
				CreatedInSchemaUId = new Guid("ea728d44-cef0-4c18-8017-0e0532c7338e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("ea728d44-cef0-4c18-8017-0e0532c7338e"),
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
				UId = new Guid("621e8ff4-222d-4239-a838-9104b30d406d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2a8d5978-d804-4c5e-9392-eef26de94931"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1cba1048-8bb6-403f-9352-2c23d14f5429"),
				CreatedInSchemaUId = new Guid("ea728d44-cef0-4c18-8017-0e0532c7338e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("ea728d44-cef0-4c18-8017-0e0532c7338e"),
				Name = @"Terminate1",
				Position = new Point(353, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateGenerateRemindingScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c4cc0ca4-aabf-45e6-af76-18930d341b4c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2a8d5978-d804-4c5e-9392-eef26de94931"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1cba1048-8bb6-403f-9352-2c23d14f5429"),
				CreatedInSchemaUId = new Guid("ea728d44-cef0-4c18-8017-0e0532c7338e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ea728d44-cef0-4c18-8017-0e0532c7338e"),
				Name = @"GenerateReminding",
				Position = new Point(171, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = true,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,83,219,110,219,48,12,125,150,191,66,245,147,2,4,254,1,55,1,218,34,40,12,172,29,176,164,219,195,176,7,197,165,29,109,142,84,80,116,218,160,200,191,143,148,115,71,159,116,33,207,225,57,164,20,9,157,111,117,31,225,17,60,160,37,23,252,156,80,79,50,53,223,198,57,16,113,56,22,143,64,63,109,215,195,109,76,249,83,83,7,79,240,65,197,75,4,124,8,222,67,45,200,177,206,95,142,76,112,231,189,219,0,70,139,219,31,176,118,254,85,168,114,206,33,236,33,31,149,217,198,226,101,101,61,209,76,198,24,42,22,225,62,132,14,172,55,215,218,24,232,26,109,110,46,238,71,250,51,83,8,212,163,215,66,95,102,187,68,95,119,54,198,103,187,6,166,206,23,128,104,99,104,168,224,42,141,107,251,1,91,220,219,248,165,216,124,144,184,6,90,133,215,3,201,209,93,77,189,237,206,140,149,217,98,251,6,67,197,180,155,104,89,164,119,178,154,163,20,54,80,205,124,191,102,154,101,7,183,18,156,106,231,87,128,142,34,163,238,98,132,245,178,219,10,242,176,55,71,218,81,166,14,148,209,200,225,23,3,193,80,170,56,213,178,22,85,156,247,203,132,248,222,156,33,247,45,183,216,74,25,15,239,58,44,255,242,228,126,255,209,159,95,15,116,87,102,179,143,26,222,210,112,152,135,78,39,38,232,187,174,204,154,128,96,235,149,54,201,115,146,225,252,209,78,154,203,80,133,239,34,89,95,75,99,184,121,110,99,41,96,241,192,104,130,106,31,74,54,198,73,33,139,85,79,169,243,149,111,194,126,8,105,59,25,76,114,19,134,184,57,13,104,44,174,196,142,100,132,198,44,249,13,141,118,66,37,79,230,156,99,144,159,228,41,241,238,188,60,26,181,203,20,225,54,221,158,178,139,202,111,194,63,48,7,3,227,171,222,53,182,139,144,170,48,188,182,36,221,56,53,10,134,34,210,249,46,180,172,254,91,104,159,172,183,45,160,120,224,19,239,76,254,28,200,53,174,78,47,50,202,239,80,138,211,139,25,98,64,3,195,249,106,0,131,224,93,250,14,151,177,155,51,123,180,194,240,126,57,60,254,29,74,169,236,252,191,252,7,101,196,45,223,9,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb29449b-948a-42d8-9ce4-d8a2a70cb237"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("1cba1048-8bb6-403f-9352-2c23d14f5429")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ae5cf1a1-fd3c-4e1a-a803-58809bfaee7d"),
				Name = "System.Threading.Tasks",
				Alias = "",
				CreatedInPackageId = new Guid("1cba1048-8bb6-403f-9352-2c23d14f5429")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("49c070a0-632a-4ee3-85de-d059e293c3ee"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("1cba1048-8bb6-403f-9352-2c23d14f5429")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a4f930e4-62bd-4e84-96b4-2c761af4d3d3"),
				Name = "System.Reflection",
				Alias = "",
				CreatedInPackageId = new Guid("1cba1048-8bb6-403f-9352-2c23d14f5429")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0db02f09-1196-4f60-80e9-5e7f08e20706"),
				Name = "global::Common.Logging",
				Alias = "",
				CreatedInPackageId = new Guid("1cba1048-8bb6-403f-9352-2c23d14f5429")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new GenerateAnniversaryRemindings(userConnection);
		}

		public override object Clone() {
			return new GenerateAnniversaryRemindingsSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ea728d44-cef0-4c18-8017-0e0532c7338e"));
		}

		#endregion

	}

	#endregion

	#region Class: GenerateAnniversaryRemindingsMethodsWrapper

	/// <exclude/>
	public class GenerateAnniversaryRemindingsMethodsWrapper : ProcessModel
	{

		public GenerateAnniversaryRemindingsMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("GenerateRemindingExecute", GenerateRemindingExecute);
		}

		#region Methods: Private

		private bool GenerateRemindingExecute(ProcessExecutingContext context) {
			string useGenerationStr =
				SysSettings.GetValue<string>(context.UserConnection, "UseGenerateAnniversaryRemindings", "true");
			var useGeneration = Convert.ToBoolean(useGenerationStr);
			if (!useGeneration) {
				return true;
			}
			var className = "Terrasoft.Configuration.BaseAnniversaryReminding";
			var methodName = "GenerateActualRemindings";
			Type classType = Type.GetType(className);
			IEnumerable<Type> inherits = Assembly.GetAssembly(classType)
				.GetTypes()
				.Where(type => type.IsSubclassOf(classType));
			var args = new object[] {context.UserConnection};
			Exception lastException = null;
			foreach (Type type in inherits) {
				object instance = Activator.CreateInstance(type, args);
				MethodInfo methodInfo = type.GetMethod(methodName, new[] {typeof(bool)});
				if (methodInfo == null) {
					continue;
				}
				try {
					methodInfo.Invoke(instance, new object[] {false});
				}
				catch (Exception e) {
					var log = LogManager.GetLogger("Notifications");
					log.Error(e);
					lastException = e;
				}
			}
			if (lastException != null) {
				throw lastException;
			}			
			return true;
		}

		#endregion

	}

	#endregion

	#region Class: GenerateAnniversaryRemindings

	/// <exclude/>
	public class GenerateAnniversaryRemindings : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, GenerateAnniversaryRemindings process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public GenerateAnniversaryRemindings(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "GenerateAnniversaryRemindings";
			SchemaUId = new Guid("ea728d44-cef0-4c18-8017-0e0532c7338e");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = false;
			SerializeToMemory = true;
			IsLogging = false;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			ProcessModel = new GenerateAnniversaryRemindingsMethodsWrapper(this);
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ea728d44-cef0-4c18-8017-0e0532c7338e");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: GenerateAnniversaryRemindings, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: GenerateAnniversaryRemindings, Source element: {0}, None of the exclusive gateway conditions are met!";
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
					SchemaElementUId = new Guid("528e9bac-1ed2-4e52-8225-6cb1c5f70e0e"),
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
					SchemaElementUId = new Guid("621e8ff4-222d-4239-a838-9104b30d406d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _generateReminding;
		public ProcessScriptTask GenerateReminding {
			get {
				return _generateReminding ?? (_generateReminding = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "GenerateReminding",
					SchemaElementUId = new Guid("c4cc0ca4-aabf-45e6-af76-18930d341b4c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ProcessModel.GetScriptTaskMethod("GenerateRemindingExecute"),
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start1.SchemaElementUId] = new Collection<ProcessFlowElement> { Start1 };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[GenerateReminding.SchemaElementUId] = new Collection<ProcessFlowElement> { GenerateReminding };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("GenerateReminding", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "GenerateReminding":
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
			var cloneItem = (GenerateAnniversaryRemindings)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

