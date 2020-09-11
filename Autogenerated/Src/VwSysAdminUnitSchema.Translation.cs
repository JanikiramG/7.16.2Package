namespace Terrasoft.Configuration
{

	using DataContract = Terrasoft.Nui.ServiceModel.DataContract;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.OperationLog;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;
	using Terrasoft.Web.Common;

	#region Class: VwSysAdminUnitSchema

	/// <exclude/>
	public class VwSysAdminUnitSchema : Terrasoft.Configuration.VwSysAdminUnit_WebitelCollaborations_TerrasoftSchema
	{

		#region Constructors: Public

		public VwSysAdminUnitSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwSysAdminUnitSchema(VwSysAdminUnitSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwSysAdminUnitSchema(VwSysAdminUnitSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("83ef3898-2ff3-4587-99f5-566b544023f5");
			Name = "VwSysAdminUnit";
			ParentSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364");
			ExtendParent = true;
			CreatedInPackageId = new Guid("0b3cc894-bd0d-4e1b-bb7d-87203708d013");
			IsDBView = true;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwSysAdminUnitEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwSysAdminUnitEventsProcessSchema() {
			var schema = new VwSysAdminUnitEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwSysAdminUnit(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwSysAdminUnit_TranslationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwSysAdminUnitSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwSysAdminUnitSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("83ef3898-2ff3-4587-99f5-566b544023f5"));
		}

		#endregion

	}

	#endregion

	#region Class: VwSysAdminUnit

	/// <summary>
	/// Users/roles (view).
	/// </summary>
	public class VwSysAdminUnit : Terrasoft.Configuration.VwSysAdminUnit_WebitelCollaborations_Terrasoft
	{

		#region Constructors: Public

		public VwSysAdminUnit(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwSysAdminUnit";
		}

		public VwSysAdminUnit(VwSysAdminUnit source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwSysAdminUnit_TranslationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Saving += (s, e) => ThrowEvent("VwSysAdminUnitSaving", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwSysAdminUnit(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwSysAdminUnit_TranslationEventsProcess

	/// <exclude/>
	public partial class VwSysAdminUnit_TranslationEventsProcess<TEntity> : Terrasoft.Configuration.VwSysAdminUnit_WebitelCollaborationsEventsProcess<TEntity> where TEntity : VwSysAdminUnit
	{

		public VwSysAdminUnit_TranslationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwSysAdminUnit_TranslationEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("83ef3898-2ff3-4587-99f5-566b544023f5");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess3_c6053b7c72914c9aa2918330fa10ab85;
		public ProcessFlowElement EventSubProcess3_c6053b7c72914c9aa2918330fa10ab85 {
			get {
				return _eventSubProcess3_c6053b7c72914c9aa2918330fa10ab85 ?? (_eventSubProcess3_c6053b7c72914c9aa2918330fa10ab85 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3_c6053b7c72914c9aa2918330fa10ab85",
					SchemaElementUId = new Guid("c6053b7c-7291-4c9a-a291-8330fa10ab85"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _vwSysAdminUnitSavingStartMessage;
		public ProcessFlowElement VwSysAdminUnitSavingStartMessage {
			get {
				return _vwSysAdminUnitSavingStartMessage ?? (_vwSysAdminUnitSavingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "VwSysAdminUnitSavingStartMessage",
					SchemaElementUId = new Guid("b642d1d0-3b18-4fb1-a688-7908a9b6fbd2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _vwSysAdminUnitSavingScriptTask;
		public ProcessScriptTask VwSysAdminUnitSavingScriptTask {
			get {
				return _vwSysAdminUnitSavingScriptTask ?? (_vwSysAdminUnitSavingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "VwSysAdminUnitSavingScriptTask",
					SchemaElementUId = new Guid("0e465ea1-55e4-40c6-8cef-f7d8bc89b3c8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = VwSysAdminUnitSavingScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess3_c6053b7c72914c9aa2918330fa10ab85.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3_c6053b7c72914c9aa2918330fa10ab85 };
			FlowElements[VwSysAdminUnitSavingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { VwSysAdminUnitSavingStartMessage };
			FlowElements[VwSysAdminUnitSavingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { VwSysAdminUnitSavingScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess3_c6053b7c72914c9aa2918330fa10ab85":
						break;
					case "VwSysAdminUnitSavingStartMessage":
						e.Context.QueueTasks.Enqueue("VwSysAdminUnitSavingScriptTask");
						break;
					case "VwSysAdminUnitSavingScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("VwSysAdminUnitSavingStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess3_c6053b7c72914c9aa2918330fa10ab85":
					context.QueueTasks.Dequeue();
					break;
				case "VwSysAdminUnitSavingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "VwSysAdminUnitSavingStartMessage";
					result = VwSysAdminUnitSavingStartMessage.Execute(context);
					break;
				case "VwSysAdminUnitSavingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "VwSysAdminUnitSavingScriptTask";
					result = VwSysAdminUnitSavingScriptTask.Execute(context, VwSysAdminUnitSavingScriptTaskExecute);
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

		public virtual bool VwSysAdminUnitSavingScriptTaskExecute(ProcessExecutingContext context) {
			EntitySchemaColumn sysCultureColumn = Entity.Schema.Columns.GetByName("SysCulture");
			var sysCultureId = Entity.GetTypedColumnValue<Guid>(sysCultureColumn.ColumnValueName);
			if (sysCultureId == Guid.Empty) {
				var sysCultureUtilities = new SysCultureUtilities(UserConnection);
				Guid sysDefaultCultureId = sysCultureUtilities.GetDefaultCulture();
				Entity.SetColumnValue(sysCultureColumn.ColumnValueName, sysDefaultCultureId);
			} 
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "VwSysAdminUnitSaving":
							if (ActivatedEventElements.Contains("VwSysAdminUnitSavingStartMessage")) {
							context.QueueTasks.Enqueue("VwSysAdminUnitSavingStartMessage");
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

	#region Class: VwSysAdminUnit_TranslationEventsProcess

	/// <exclude/>
	public class VwSysAdminUnit_TranslationEventsProcess : VwSysAdminUnit_TranslationEventsProcess<VwSysAdminUnit>
	{

		public VwSysAdminUnit_TranslationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwSysAdminUnit_TranslationEventsProcess

	public partial class VwSysAdminUnit_TranslationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: VwSysAdminUnitEventsProcessSchema

	/// <exclude/>
	public class VwSysAdminUnitEventsProcessSchema : Terrasoft.Configuration.VwSysAdminUnit_WebitelCollaborations_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public VwSysAdminUnitEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwSysAdminUnitEventsProcessSchema(VwSysAdminUnitEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwSysAdminUnit_TranslationEventsProcess";
			UId = new Guid("9c29e62f-2f63-403c-baaa-e7449aa657f1");
			CreatedInPackageId = new Guid("0b3cc894-bd0d-4e1b-bb7d-87203708d013");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet2_e5a0ab63a04b4de780476e000242e3cc = CreateLaneSet2_e5a0ab63a04b4de780476e000242e3ccLaneSet();
			LaneSets.Add(schemaLaneSet2_e5a0ab63a04b4de780476e000242e3cc);
			ProcessSchemaLane schemaLane3_106c4d68ef354ce5a68d5c6d6e941a0b = CreateLane3_106c4d68ef354ce5a68d5c6d6e941a0bLane();
			schemaLaneSet2_e5a0ab63a04b4de780476e000242e3cc.Lanes.Add(schemaLane3_106c4d68ef354ce5a68d5c6d6e941a0b);
			ProcessSchemaEventSubProcess eventsubprocess3_c6053b7c72914c9aa2918330fa10ab85 = CreateEventSubProcess3_c6053b7c72914c9aa2918330fa10ab85EventSubProcess();
			FlowElements.Add(eventsubprocess3_c6053b7c72914c9aa2918330fa10ab85);
			ProcessSchemaStartMessageEvent vwsysadminunitsavingstartmessage = CreateVwSysAdminUnitSavingStartMessageStartMessageEvent();
			eventsubprocess3_c6053b7c72914c9aa2918330fa10ab85.FlowElements.Add(vwsysadminunitsavingstartmessage);
			ProcessSchemaScriptTask vwsysadminunitsavingscripttask = CreateVwSysAdminUnitSavingScriptTaskScriptTask();
			eventsubprocess3_c6053b7c72914c9aa2918330fa10ab85.FlowElements.Add(vwsysadminunitsavingscripttask);
			FlowElements.Add(CreateSequenceFlow12_bfaba9da280f47389d3bd4850b1e74abSequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12_bfaba9da280f47389d3bd4850b1e74abSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12_bfaba9da280f47389d3bd4850b1e74ab",
				UId = new Guid("bfaba9da-280f-4738-9d3b-d4850b1e74ab"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				CreatedInPackageId = new Guid("0b3cc894-bd0d-4e1b-bb7d-87203708d013"),
				CreatedInSchemaUId = new Guid("9c29e62f-2f63-403c-baaa-e7449aa657f1"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("9c29e62f-2f63-403c-baaa-e7449aa657f1"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b642d1d0-3b18-4fb1-a688-7908a9b6fbd2"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0e465ea1-55e4-40c6-8cef-f7d8bc89b3c8"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(137, 112));
			schemaFlow.PolylinePointPositions.Add(new Point(137, 112));
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet2_e5a0ab63a04b4de780476e000242e3ccLaneSet() {
			ProcessSchemaLaneSet schemaLaneSet2_e5a0ab63a04b4de780476e000242e3cc = new ProcessSchemaLaneSet(this) {
				UId = new Guid("e5a0ab63-a04b-4de7-8047-6e000242e3cc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				CreatedInPackageId = new Guid("0b3cc894-bd0d-4e1b-bb7d-87203708d013"),
				CreatedInSchemaUId = new Guid("9c29e62f-2f63-403c-baaa-e7449aa657f1"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("9c29e62f-2f63-403c-baaa-e7449aa657f1"),
				Name = @"LaneSet2_e5a0ab63a04b4de780476e000242e3cc",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet2_e5a0ab63a04b4de780476e000242e3cc;
		}

		protected virtual ProcessSchemaLane CreateLane3_106c4d68ef354ce5a68d5c6d6e941a0bLane() {
			ProcessSchemaLane schemaLane3_106c4d68ef354ce5a68d5c6d6e941a0b = new ProcessSchemaLane(this) {
				UId = new Guid("106c4d68-ef35-4ce5-a68d-5c6d6e941a0b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e5a0ab63-a04b-4de7-8047-6e000242e3cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("0b3cc894-bd0d-4e1b-bb7d-87203708d013"),
				CreatedInSchemaUId = new Guid("9c29e62f-2f63-403c-baaa-e7449aa657f1"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("9c29e62f-2f63-403c-baaa-e7449aa657f1"),
				Name = @"Lane3_106c4d68ef354ce5a68d5c6d6e941a0b",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane3_106c4d68ef354ce5a68d5c6d6e941a0b;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3_c6053b7c72914c9aa2918330fa10ab85EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3_c6053b7c72914c9aa2918330fa10ab85 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c6053b7c-7291-4c9a-a291-8330fa10ab85"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("106c4d68-ef35-4ce5-a68d-5c6d6e941a0b"),
				CreatedInOwnerSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				CreatedInPackageId = new Guid("0b3cc894-bd0d-4e1b-bb7d-87203708d013"),
				CreatedInSchemaUId = new Guid("9c29e62f-2f63-403c-baaa-e7449aa657f1"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("9c29e62f-2f63-403c-baaa-e7449aa657f1"),
				Name = @"EventSubProcess3_c6053b7c72914c9aa2918330fa10ab85",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(24, 25),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(296, 175),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3_c6053b7c72914c9aa2918330fa10ab85;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateVwSysAdminUnitSavingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b642d1d0-3b18-4fb1-a688-7908a9b6fbd2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c6053b7c-7291-4c9a-a291-8330fa10ab85"),
				CreatedInOwnerSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				CreatedInPackageId = new Guid("0b3cc894-bd0d-4e1b-bb7d-87203708d013"),
				CreatedInSchemaUId = new Guid("9c29e62f-2f63-403c-baaa-e7449aa657f1"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"VwSysAdminUnitSaving",
				ModifiedInSchemaUId = new Guid("9c29e62f-2f63-403c-baaa-e7449aa657f1"),
				Name = @"VwSysAdminUnitSavingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(39, 74),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateVwSysAdminUnitSavingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0e465ea1-55e4-40c6-8cef-f7d8bc89b3c8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c6053b7c-7291-4c9a-a291-8330fa10ab85"),
				CreatedInOwnerSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				CreatedInPackageId = new Guid("0b3cc894-bd0d-4e1b-bb7d-87203708d013"),
				CreatedInSchemaUId = new Guid("9c29e62f-2f63-403c-baaa-e7449aa657f1"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("9c29e62f-2f63-403c-baaa-e7449aa657f1"),
				Name = @"VwSysAdminUnitSavingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(160, 59),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,144,205,10,194,48,16,132,207,237,83,4,79,41,72,94,192,159,131,181,20,47,94,170,222,67,187,197,64,147,150,100,163,4,241,221,77,172,63,173,10,30,119,119,230,155,76,50,133,2,93,81,30,65,242,180,109,172,84,196,56,147,218,6,173,134,199,98,65,178,187,138,245,50,214,175,13,203,1,87,110,203,37,208,73,241,242,76,146,89,124,226,122,64,217,84,111,130,183,236,92,7,85,143,56,240,198,194,60,183,162,90,210,207,84,54,144,132,12,143,21,53,161,99,236,130,4,51,203,100,135,46,33,151,56,26,39,239,81,52,2,5,24,255,0,5,103,82,124,95,232,222,128,78,91,165,160,68,209,42,159,18,5,100,128,172,161,230,94,61,108,241,3,29,42,141,149,52,64,158,63,6,56,232,241,183,228,244,87,174,199,93,73,172,193,79,138,160,182,48,187,1,185,145,144,124,181,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("95aee64a-275c-41cb-bd10-56c1b25c6635"),
				Name = "Terrasoft.Core.OperationLog",
				Alias = "",
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("097b2e1f-2827-4107-9958-89dc67979364"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d5bb3512-71e0-482a-9c7e-16bf22c586b7"),
				Name = "Terrasoft.Nui.ServiceModel.DataContract",
				Alias = "DataContract",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b261d1c9-cc98-44e8-aabd-7806d1dc26ed"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c261d1c9-cc98-44e8-aabd-7806d1dc26ec"),
				Name = "Terrasoft.Core.DcmProcess",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aca2294b-e209-4c40-9400-0d59d9ecd1ea"),
				Name = "Terrasoft.GlobalSearch.Indexing",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5410f06b-83f8-43fa-bc49-82a2dd508d3c"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ad63647f-80ed-400c-82b0-79cd39694ed1"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwSysAdminUnitEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9c29e62f-2f63-403c-baaa-e7449aa657f1"));
		}

		#endregion

	}

	#endregion


	#region Class: VwSysAdminUnitEventsProcess

	/// <exclude/>
	public class VwSysAdminUnitEventsProcess : VwSysAdminUnit_TranslationEventsProcess
	{

		public VwSysAdminUnitEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

