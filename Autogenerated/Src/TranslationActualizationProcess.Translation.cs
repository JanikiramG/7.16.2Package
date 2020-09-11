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
	using Terrasoft.Configuration.Translation;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Core.Translation;

	#region Class: TranslationActualizationProcessSchema

	/// <exclude/>
	public class TranslationActualizationProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public TranslationActualizationProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public TranslationActualizationProcessSchema(TranslationActualizationProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "TranslationActualizationProcess";
			UId = new Guid("2e8af05a-20e3-4721-a092-cd856bb6319a");
			CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.8.0.0";
			CultureName = @"ru-RU";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsLogging = false;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = false;
			SerializeToMemory = false;
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			UseForceCompile = true;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,82,193,106,195,48,12,61,111,176,127,16,57,57,80,242,3,107,10,93,74,199,14,221,14,73,119,247,18,53,24,82,187,216,74,75,54,246,239,179,205,146,54,155,27,198,46,70,146,165,247,158,159,117,104,223,26,81,194,81,104,106,121,3,71,37,42,88,150,46,22,239,88,104,46,77,195,73,40,201,98,248,184,187,189,41,149,52,4,134,180,144,53,208,249,122,24,169,94,100,222,153,28,137,108,135,201,84,133,144,66,84,132,59,163,123,11,185,226,132,133,216,35,84,125,144,194,5,68,242,136,244,202,155,22,231,125,227,130,109,13,234,76,73,137,165,67,156,253,81,200,204,146,13,108,201,70,72,15,27,127,107,224,62,43,186,131,23,114,145,165,48,166,75,70,205,27,46,121,141,218,169,28,213,31,186,33,100,100,15,181,99,61,117,28,143,158,125,69,188,229,61,79,140,20,13,142,172,149,206,249,17,127,217,209,27,233,121,158,66,222,107,179,230,37,41,221,5,217,207,183,41,100,13,55,125,234,136,231,147,112,11,230,60,150,120,130,204,45,138,110,93,117,169,235,118,143,146,88,212,142,132,70,179,31,206,198,19,130,195,66,173,192,201,7,56,197,65,56,230,169,130,179,73,112,253,175,252,146,135,185,220,86,27,172,112,231,191,231,191,107,10,195,142,110,169,124,86,39,199,241,249,5,160,132,82,157,168,3,0,0 };
			RealUId = new Guid("2e8af05a-20e3-4721-a092-cd856bb6319a");
			Version = 0;
			PackageUId = new Guid("77e888d2-c4a4-45ce-a906-ac00adb364a2");
			UseSystemSecurityContext = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaTranslationActualizationProcessLaneSet = CreateTranslationActualizationProcessLaneSetLaneSet();
			LaneSets.Add(schemaTranslationActualizationProcessLaneSet);
			ProcessSchemaLane schemaTranslationActualizationProcessLane = CreateTranslationActualizationProcessLaneLane();
			schemaTranslationActualizationProcessLaneSet.Lanes.Add(schemaTranslationActualizationProcessLane);
			ProcessSchemaStartEvent translationactualizationprocessstart = CreateTranslationActualizationProcessStartStartEvent();
			FlowElements.Add(translationactualizationprocessstart);
			ProcessSchemaTerminateEvent translationactualizationprocessterminate = CreateTranslationActualizationProcessTerminateTerminateEvent();
			FlowElements.Add(translationactualizationprocessterminate);
			ProcessSchemaScriptTask translationactualizationprocessscripttask = CreateTranslationActualizationProcessScriptTaskScriptTask();
			FlowElements.Add(translationactualizationprocessscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("7e9cebf2-338d-4072-8e98-209dc3d91967"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a"),
				CreatedInSchemaUId = new Guid("2e8af05a-20e3-4721-a092-cd856bb6319a"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2e8af05a-20e3-4721-a092-cd856bb6319a"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5ef54ee7-7f79-4ebe-a3de-490e0c49bd08"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("58db64e5-e7e4-4675-95f6-6ab024df5ffa"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("2b5b29c6-1850-4e1a-8968-a9644cbf7c5e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a"),
				CreatedInSchemaUId = new Guid("2e8af05a-20e3-4721-a092-cd856bb6319a"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2e8af05a-20e3-4721-a092-cd856bb6319a"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("58db64e5-e7e4-4675-95f6-6ab024df5ffa"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("dad0e78c-6ec2-4914-bf30-87182a2ba079"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateTranslationActualizationProcessLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaTranslationActualizationProcessLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("feae7991-70d2-4f1c-8160-827494f7128a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a"),
				CreatedInSchemaUId = new Guid("2e8af05a-20e3-4721-a092-cd856bb6319a"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("2e8af05a-20e3-4721-a092-cd856bb6319a"),
				Name = @"TranslationActualizationProcessLaneSet",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaTranslationActualizationProcessLaneSet;
		}

		protected virtual ProcessSchemaLane CreateTranslationActualizationProcessLaneLane() {
			ProcessSchemaLane schemaTranslationActualizationProcessLane = new ProcessSchemaLane(this) {
				UId = new Guid("709fd794-e645-4432-a1ae-eedde6ad6f8b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("feae7991-70d2-4f1c-8160-827494f7128a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a"),
				CreatedInSchemaUId = new Guid("2e8af05a-20e3-4721-a092-cd856bb6319a"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("2e8af05a-20e3-4721-a092-cd856bb6319a"),
				Name = @"TranslationActualizationProcessLane",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaTranslationActualizationProcessLane;
		}

		protected virtual ProcessSchemaStartEvent CreateTranslationActualizationProcessStartStartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("5ef54ee7-7f79-4ebe-a3de-490e0c49bd08"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("709fd794-e645-4432-a1ae-eedde6ad6f8b"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a"),
				CreatedInSchemaUId = new Guid("2e8af05a-20e3-4721-a092-cd856bb6319a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("2e8af05a-20e3-4721-a092-cd856bb6319a"),
				Name = @"TranslationActualizationProcessStart",
				Position = new Point(50, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTranslationActualizationProcessTerminateTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("dad0e78c-6ec2-4914-bf30-87182a2ba079"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("709fd794-e645-4432-a1ae-eedde6ad6f8b"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a"),
				CreatedInSchemaUId = new Guid("2e8af05a-20e3-4721-a092-cd856bb6319a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("2e8af05a-20e3-4721-a092-cd856bb6319a"),
				Name = @"TranslationActualizationProcessTerminate",
				Position = new Point(273, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateTranslationActualizationProcessScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("58db64e5-e7e4-4675-95f6-6ab024df5ffa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("709fd794-e645-4432-a1ae-eedde6ad6f8b"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a"),
				CreatedInSchemaUId = new Guid("2e8af05a-20e3-4721-a092-cd856bb6319a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2e8af05a-20e3-4721-a092-cd856bb6319a"),
				Name = @"TranslationActualizationProcessScriptTask",
				Position = new Point(140, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,76,46,41,77,204,201,172,74,13,41,74,204,43,206,73,44,201,204,207,211,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,29,203,142,99,36,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ff9dca82-977a-4ce9-8062-8ac2eaaeb786"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("1fdd7fb9-f16a-484d-a501-9028841e2925"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("1ea5ceef-5c8f-4fad-9acb-a04bdc64b6bb"),
				Name = "Terrasoft.Core.Translation",
				Alias = "",
				CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("56050a26-d70f-4468-96c1-eb3ce2704f77"),
				Name = "Terrasoft.Configuration.Translation",
				Alias = "",
				CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new TranslationActualizationProcess(userConnection);
		}

		public override object Clone() {
			return new TranslationActualizationProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2e8af05a-20e3-4721-a092-cd856bb6319a"));
		}

		#endregion

	}

	#endregion

	#region Class: TranslationActualizationProcess

	/// <exclude/>
	public class TranslationActualizationProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessTranslationActualizationProcessLane

		/// <exclude/>
		public class ProcessTranslationActualizationProcessLane : ProcessLane
		{

			public ProcessTranslationActualizationProcessLane(UserConnection userConnection, TranslationActualizationProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public TranslationActualizationProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "TranslationActualizationProcess";
			SchemaUId = new Guid("2e8af05a-20e3-4721-a092-cd856bb6319a");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = false;
			SerializeToMemory = false;
			IsLogging = false;
			UseSystemSecurityContext = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("2e8af05a-20e3-4721-a092-cd856bb6319a");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: TranslationActualizationProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: TranslationActualizationProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		private ProcessTranslationActualizationProcessLane _translationActualizationProcessLane;
		public ProcessTranslationActualizationProcessLane TranslationActualizationProcessLane {
			get {
				return _translationActualizationProcessLane ?? ((_translationActualizationProcessLane) = new ProcessTranslationActualizationProcessLane(UserConnection, this));
			}
		}

		private ProcessFlowElement _translationActualizationProcessStart;
		public ProcessFlowElement TranslationActualizationProcessStart {
			get {
				return _translationActualizationProcessStart ?? (_translationActualizationProcessStart = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "TranslationActualizationProcessStart",
					SchemaElementUId = new Guid("5ef54ee7-7f79-4ebe-a3de-490e0c49bd08"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessTerminateEvent _translationActualizationProcessTerminate;
		public ProcessTerminateEvent TranslationActualizationProcessTerminate {
			get {
				return _translationActualizationProcessTerminate ?? (_translationActualizationProcessTerminate = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TranslationActualizationProcessTerminate",
					SchemaElementUId = new Guid("dad0e78c-6ec2-4914-bf30-87182a2ba079"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _translationActualizationProcessScriptTask;
		public ProcessScriptTask TranslationActualizationProcessScriptTask {
			get {
				return _translationActualizationProcessScriptTask ?? (_translationActualizationProcessScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "TranslationActualizationProcessScriptTask",
					SchemaElementUId = new Guid("58db64e5-e7e4-4675-95f6-6ab024df5ffa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = TranslationActualizationProcessScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[TranslationActualizationProcessStart.SchemaElementUId] = new Collection<ProcessFlowElement> { TranslationActualizationProcessStart };
			FlowElements[TranslationActualizationProcessTerminate.SchemaElementUId] = new Collection<ProcessFlowElement> { TranslationActualizationProcessTerminate };
			FlowElements[TranslationActualizationProcessScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { TranslationActualizationProcessScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "TranslationActualizationProcessStart":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TranslationActualizationProcessScriptTask", e.Context.SenderName));
						break;
					case "TranslationActualizationProcessTerminate":
						CompleteProcess();
						break;
					case "TranslationActualizationProcessScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TranslationActualizationProcessTerminate", e.Context.SenderName));
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
			context.QueueTasksV2.Enqueue(new ProcessQueueElement("TranslationActualizationProcessStart", string.Empty));
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

		public virtual bool TranslationActualizationProcessScriptTaskExecute(ProcessExecutingContext context) {
			ActualizeTranslation();
			return true;
		}

			public virtual void ActualizeTranslation() {
				const string translationActualizedOnSysSettingsCode = "TranslationActualizedOn";
				DateTime dateTime = SysSettings.GetValue<DateTime>(UserConnection, translationActualizedOnSysSettingsCode,
					DateTime.MinValue);
				DataValueType dataValueType = UserConnection.DataValueTypeManager.GetDataValueTypeByValueType(typeof(DateTime));
				DateTime translationActualizedOn = (DateTime)dataValueType.GetValueForSave(UserConnection, dateTime);
				ITranslationActualizersFactory translationActualizersFactory = ClassFactory.Get<TranslationActualizersFactory>(
					new ConstructorArgument("userConnection", UserConnection));
				ITranslationActualizer translationActualizer = translationActualizersFactory.GetTranslationActualizer();
				translationActualizer.ActualizeTranslation(translationActualizedOn);
				SysSettings.SetDefValue(UserConnection, translationActualizedOnSysSettingsCode, DateTime.UtcNow);
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
			var cloneItem = (TranslationActualizationProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

