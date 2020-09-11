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

	#region Class: SysUserInRoleSchema

	/// <exclude/>
	public class SysUserInRoleSchema : Terrasoft.Configuration.SysUserInRole_Base_TerrasoftSchema
	{

		#region Constructors: Public

		public SysUserInRoleSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysUserInRoleSchema(SysUserInRoleSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysUserInRoleSchema(SysUserInRoleSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("1ea0be86-c964-41da-822d-4dfafe084e31");
			Name = "SysUserInRole";
			ParentSchemaUId = new Guid("4b27f502-c296-47cf-af5d-3197d54e0d2a");
			ExtendParent = true;
			CreatedInPackageId = new Guid("efb6fc64-47cd-46f8-840c-96c0bb0b6306");
			IsDBView = false;
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
			EventsProcessSchema = CreateSysUserInRoleEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysUserInRoleEventsProcessSchema() {
			var schema = new SysUserInRoleEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysUserInRole(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysUserInRole_UIv2EventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysUserInRoleSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysUserInRoleSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1ea0be86-c964-41da-822d-4dfafe084e31"));
		}

		#endregion

	}

	#endregion

	#region Class: SysUserInRole

	/// <summary>
	/// User in roles.
	/// </summary>
	public class SysUserInRole : Terrasoft.Configuration.SysUserInRole_Base_Terrasoft
	{

		#region Constructors: Public

		public SysUserInRole(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysUserInRole";
		}

		public SysUserInRole(SysUserInRole source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysUserInRole_UIv2EventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysUserInRoleDeleted", e);
			Deleting += (s, e) => ThrowEvent("SysUserInRoleDeleting", e);
			Inserted += (s, e) => ThrowEvent("SysUserInRoleInserted", e);
			Validating += (s, e) => ThrowEvent("SysUserInRoleValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysUserInRole(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysUserInRole_UIv2EventsProcess

	/// <exclude/>
	public partial class SysUserInRole_UIv2EventsProcess<TEntity> : Terrasoft.Configuration.SysUserInRole_BaseEventsProcess<TEntity> where TEntity : SysUserInRole
	{

		public SysUserInRole_UIv2EventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysUserInRole_UIv2EventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1ea0be86-c964-41da-822d-4dfafe084e31");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
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
					SchemaElementUId = new Guid("55fdb3ef-4b0d-4470-82d2-513cd7f1b7fc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage1;
		public ProcessFlowElement StartMessage1 {
			get {
				return _startMessage1 ?? (_startMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage1",
					SchemaElementUId = new Guid("8aeda9eb-b344-4d71-b475-091cda97ef93"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent1;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent1 {
			get {
				return _intermediateThrowMessageEvent1 ?? (_intermediateThrowMessageEvent1 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent1",
					SchemaElementUId = new Guid("edbf0b7b-bdcb-4cb7-a68d-af48e633bd72"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "SysUserInRoleInserted",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptTask1;
		public ProcessScriptTask ScriptTask1 {
			get {
				return _scriptTask1 ?? (_scriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask1",
					SchemaElementUId = new Guid("ff042787-7f6b-4ed0-bbb5-b7f47503beb8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
				});
			}
		}

		private ProcessFlowElement _startMessage2;
		public ProcessFlowElement StartMessage2 {
			get {
				return _startMessage2 ?? (_startMessage2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage2",
					SchemaElementUId = new Guid("f565c113-a360-4182-a509-d8c83c1c4cc6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent2;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent2 {
			get {
				return _intermediateThrowMessageEvent2 ?? (_intermediateThrowMessageEvent2 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent2",
					SchemaElementUId = new Guid("a5658e44-2959-48f5-9de2-afceaa76335c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "SysUserInRoleDeleted",
						ThrowToBase = true,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[StartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2 };
			FlowElements[IntermediateThrowMessageEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent2 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "IntermediateThrowMessageEvent1":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "ScriptTask1":
						break;
					case "StartMessage2":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent2");
						break;
					case "IntermediateThrowMessageEvent2":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage1");
			ActivatedEventElements.Add("StartMessage2");
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
				case "StartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1";
					result = StartMessage1.Execute(context);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "SysUserInRoleInserted");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
					break;
				case "StartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage2";
					result = StartMessage2.Execute(context);
					break;
				case "IntermediateThrowMessageEvent2":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "SysUserInRoleDeleted");
					result = IntermediateThrowMessageEvent2.Execute(context);
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

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			var userId = Entity.GetTypedColumnValue<Guid>("SysUserId");
			StoredProcedure actualizeAdminUnitInRole = new StoredProcedure(UserConnection, "tsp_ActualizeUserRoles")
				.WithParameter("UserId", userId) as StoredProcedure;
			actualizeAdminUnitInRole.PackageName = UserConnection.DBEngine.CoreUtilitiesPackageName;
			bool result = (actualizeAdminUnitInRole.Execute() == -1);
			if (result) {
				SysAdminUtilities.ReloadSysAdminUnitCache(UserConnection, userId);
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "SysUserInRoleInserted":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
						}
						break;
					case "SysUserInRoleDeleted":
							if (ActivatedEventElements.Contains("StartMessage2")) {
							context.QueueTasks.Enqueue("StartMessage2");
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

	#region Class: SysUserInRole_UIv2EventsProcess

	/// <exclude/>
	public class SysUserInRole_UIv2EventsProcess : SysUserInRole_UIv2EventsProcess<SysUserInRole>
	{

		public SysUserInRole_UIv2EventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysUserInRole_UIv2EventsProcess

	public partial class SysUserInRole_UIv2EventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysUserInRoleEventsProcessSchema

	/// <exclude/>
	public class SysUserInRoleEventsProcessSchema : Terrasoft.Configuration.SysUserInRole_Base_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public SysUserInRoleEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysUserInRoleEventsProcessSchema(SysUserInRoleEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysUserInRole_UIv2EventsProcess";
			UId = new Guid("fbe2880d-bb67-4d0e-a15b-75cadb1c1674");
			CreatedInPackageId = new Guid("efb6fc64-47cd-46f8-840c-96c0bb0b6306");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128");
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
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			eventsubprocess1.FlowElements.Add(startmessage1);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			eventsubprocess1.FlowElements.Add(scripttask1);
			ProcessSchemaStartMessageEvent startmessage2 = CreateStartMessage2StartMessageEvent();
			eventsubprocess1.FlowElements.Add(startmessage2);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent2 = CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(intermediatethrowmessageevent2);
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("b31cdbb5-a12a-4384-8dc2-7cc263ba8fa7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128"),
				CreatedInPackageId = new Guid("efb6fc64-47cd-46f8-840c-96c0bb0b6306"),
				CreatedInSchemaUId = new Guid("fbe2880d-bb67-4d0e-a15b-75cadb1c1674"),
				CurveCenterPosition = new Point(183, 97),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fbe2880d-bb67-4d0e-a15b-75cadb1c1674"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8aeda9eb-b344-4d71-b475-091cda97ef93"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("edbf0b7b-bdcb-4cb7-a68d-af48e633bd72"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("b734b332-0564-4e65-b767-1737ad2bff75"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128"),
				CreatedInPackageId = new Guid("efb6fc64-47cd-46f8-840c-96c0bb0b6306"),
				CreatedInSchemaUId = new Guid("fbe2880d-bb67-4d0e-a15b-75cadb1c1674"),
				CurveCenterPosition = new Point(280, 97),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fbe2880d-bb67-4d0e-a15b-75cadb1c1674"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("edbf0b7b-bdcb-4cb7-a68d-af48e633bd72"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ff042787-7f6b-4ed0-bbb5-b7f47503beb8"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("91f9b63d-77b7-416c-a032-e18ffe42e859"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128"),
				CreatedInPackageId = new Guid("efb6fc64-47cd-46f8-840c-96c0bb0b6306"),
				CreatedInSchemaUId = new Guid("fbe2880d-bb67-4d0e-a15b-75cadb1c1674"),
				CurveCenterPosition = new Point(180, 217),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fbe2880d-bb67-4d0e-a15b-75cadb1c1674"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f565c113-a360-4182-a509-d8c83c1c4cc6"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a5658e44-2959-48f5-9de2-afceaa76335c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("c4fa80a3-400c-4413-9370-f085dc10a2dc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128"),
				CreatedInPackageId = new Guid("efb6fc64-47cd-46f8-840c-96c0bb0b6306"),
				CreatedInSchemaUId = new Guid("fbe2880d-bb67-4d0e-a15b-75cadb1c1674"),
				CurveCenterPosition = new Point(288, 166),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fbe2880d-bb67-4d0e-a15b-75cadb1c1674"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a5658e44-2959-48f5-9de2-afceaa76335c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ff042787-7f6b-4ed0-bbb5-b7f47503beb8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("e81753ae-bdfd-48f3-819c-483b38ffe0ee"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128"),
				CreatedInPackageId = new Guid("efb6fc64-47cd-46f8-840c-96c0bb0b6306"),
				CreatedInSchemaUId = new Guid("fbe2880d-bb67-4d0e-a15b-75cadb1c1674"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("fbe2880d-bb67-4d0e-a15b-75cadb1c1674"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(680, 437),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("a69a685d-898b-4596-85f2-ccbb8bc91199"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("e81753ae-bdfd-48f3-819c-483b38ffe0ee"),
				CreatedInOwnerSchemaUId = new Guid("1ea0be86-c964-41da-822d-4dfafe084e31"),
				CreatedInPackageId = new Guid("efb6fc64-47cd-46f8-840c-96c0bb0b6306"),
				CreatedInSchemaUId = new Guid("fbe2880d-bb67-4d0e-a15b-75cadb1c1674"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("fbe2880d-bb67-4d0e-a15b-75cadb1c1674"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(651, 437),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("55fdb3ef-4b0d-4470-82d2-513cd7f1b7fc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a69a685d-898b-4596-85f2-ccbb8bc91199"),
				CreatedInOwnerSchemaUId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128"),
				CreatedInPackageId = new Guid("efb6fc64-47cd-46f8-840c-96c0bb0b6306"),
				CreatedInSchemaUId = new Guid("fbe2880d-bb67-4d0e-a15b-75cadb1c1674"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fbe2880d-bb67-4d0e-a15b-75cadb1c1674"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(40, 20),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(595, 416),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8aeda9eb-b344-4d71-b475-091cda97ef93"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("55fdb3ef-4b0d-4470-82d2-513cd7f1b7fc"),
				CreatedInOwnerSchemaUId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128"),
				CreatedInPackageId = new Guid("efb6fc64-47cd-46f8-840c-96c0bb0b6306"),
				CreatedInSchemaUId = new Guid("fbe2880d-bb67-4d0e-a15b-75cadb1c1674"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysUserInRoleInserted",
				ModifiedInSchemaUId = new Guid("fbe2880d-bb67-4d0e-a15b-75cadb1c1674"),
				Name = @"StartMessage1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(43, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("edbf0b7b-bdcb-4cb7-a68d-af48e633bd72"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("55fdb3ef-4b0d-4470-82d2-513cd7f1b7fc"),
				CreatedInOwnerSchemaUId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128"),
				CreatedInPackageId = new Guid("efb6fc64-47cd-46f8-840c-96c0bb0b6306"),
				CreatedInSchemaUId = new Guid("fbe2880d-bb67-4d0e-a15b-75cadb1c1674"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"SysUserInRoleInserted",
				ModifiedInSchemaUId = new Guid("fbe2880d-bb67-4d0e-a15b-75cadb1c1674"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(134, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ff042787-7f6b-4ed0-bbb5-b7f47503beb8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("55fdb3ef-4b0d-4470-82d2-513cd7f1b7fc"),
				CreatedInOwnerSchemaUId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128"),
				CreatedInPackageId = new Guid("efb6fc64-47cd-46f8-840c-96c0bb0b6306"),
				CreatedInSchemaUId = new Guid("fbe2880d-bb67-4d0e-a15b-75cadb1c1674"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fbe2880d-bb67-4d0e-a15b-75cadb1c1674"),
				Name = @"ScriptTask1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(232, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,144,209,74,195,48,20,134,175,45,244,29,14,189,74,97,22,188,158,21,102,45,99,55,82,54,171,151,18,147,227,22,76,147,145,156,168,85,124,119,83,215,13,157,236,54,57,255,119,190,243,191,114,7,193,163,91,72,40,161,54,164,168,47,230,72,119,253,22,101,101,117,232,204,61,215,1,47,231,65,201,43,150,173,122,223,254,76,103,249,52,77,86,100,29,202,198,89,129,50,56,4,46,40,112,173,62,112,38,59,101,90,163,104,97,150,86,99,68,27,124,131,163,113,54,144,42,107,12,10,82,214,76,32,35,191,125,156,237,25,195,239,16,246,89,158,38,103,197,131,162,77,195,29,239,144,208,177,108,180,152,140,242,57,112,127,204,143,130,167,132,138,134,139,23,190,198,219,136,139,114,127,69,138,155,235,218,172,149,193,162,138,188,150,148,86,164,208,255,138,68,242,147,181,26,28,250,160,41,2,216,201,69,245,59,138,64,200,114,40,75,56,191,24,90,83,207,192,118,201,28,62,227,105,177,211,93,106,191,169,88,162,182,92,30,222,35,173,226,98,243,191,176,241,246,200,252,74,19,135,20,156,1,114,1,167,223,253,180,7,175,214,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f565c113-a360-4182-a509-d8c83c1c4cc6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("55fdb3ef-4b0d-4470-82d2-513cd7f1b7fc"),
				CreatedInOwnerSchemaUId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128"),
				CreatedInPackageId = new Guid("efb6fc64-47cd-46f8-840c-96c0bb0b6306"),
				CreatedInSchemaUId = new Guid("fbe2880d-bb67-4d0e-a15b-75cadb1c1674"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysUserInRoleDeleted",
				ModifiedInSchemaUId = new Guid("fbe2880d-bb67-4d0e-a15b-75cadb1c1674"),
				Name = @"StartMessage2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(43, 191),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("a5658e44-2959-48f5-9de2-afceaa76335c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("55fdb3ef-4b0d-4470-82d2-513cd7f1b7fc"),
				CreatedInOwnerSchemaUId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128"),
				CreatedInPackageId = new Guid("efb6fc64-47cd-46f8-840c-96c0bb0b6306"),
				CreatedInSchemaUId = new Guid("fbe2880d-bb67-4d0e-a15b-75cadb1c1674"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"SysUserInRoleDeleted",
				ModifiedInSchemaUId = new Guid("fbe2880d-bb67-4d0e-a15b-75cadb1c1674"),
				Name = @"IntermediateThrowMessageEvent2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(253, 191),
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
				UId = new Guid("3262df1a-d5ad-4755-9a75-12b9b495ea65"),
				Name = "Terrasoft.Core.OperationLog",
				Alias = "",
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae")
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
				UId = new Guid("c32b5e04-55b6-40f6-ac41-b09c4c56be27"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysUserInRoleEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fbe2880d-bb67-4d0e-a15b-75cadb1c1674"));
		}

		#endregion

	}

	#endregion


	#region Class: SysUserInRoleEventsProcess

	/// <exclude/>
	public class SysUserInRoleEventsProcess : SysUserInRole_UIv2EventsProcess
	{

		public SysUserInRoleEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

