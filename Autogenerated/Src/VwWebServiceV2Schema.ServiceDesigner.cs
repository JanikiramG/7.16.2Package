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
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: VwWebServiceV2Schema

	/// <exclude/>
	public class VwWebServiceV2Schema : Terrasoft.Configuration.VwSysSchemaInWorkspaceSchema
	{

		#region Constructors: Public

		public VwWebServiceV2Schema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwWebServiceV2Schema(VwWebServiceV2Schema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwWebServiceV2Schema(VwWebServiceV2Schema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("057b56c2-d524-4be3-9668-904d92602fca");
			RealUId = new Guid("057b56c2-d524-4be3-9668-904d92602fca");
			Name = "VwWebServiceV2";
			ParentSchemaUId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868");
			ExtendParent = false;
			CreatedInPackageId = new Guid("9a41e39e-51c2-4a16-b81f-aa6773013744");
			IsDBView = true;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateUIdColumn() {
			EntitySchemaColumn column = base.CreateUIdColumn();
			column.RequirementType = EntitySchemaColumnRequirementType.None;
			column.ModifiedInSchemaUId = new Guid("057b56c2-d524-4be3-9668-904d92602fca");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwWebServiceV2EventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwWebServiceV2EventsProcessSchema() {
			var schema = new VwWebServiceV2EventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwWebServiceV2(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwWebServiceV2_ServiceDesignerEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwWebServiceV2Schema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwWebServiceV2Schema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("057b56c2-d524-4be3-9668-904d92602fca"));
		}

		#endregion

	}

	#endregion

	#region Class: VwWebServiceV2

	/// <summary>
	/// Web Service (view) .
	/// </summary>
	public class VwWebServiceV2 : Terrasoft.Configuration.VwSysSchemaInWorkspace
	{

		#region Constructors: Public

		public VwWebServiceV2(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwWebServiceV2";
		}

		public VwWebServiceV2(VwWebServiceV2 source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwWebServiceV2_ServiceDesignerEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwWebServiceV2Deleted", e);
			Loading += (s, e) => ThrowEvent("VwWebServiceV2Loading", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwWebServiceV2(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwWebServiceV2_ServiceDesignerEventsProcess

	/// <exclude/>
	public partial class VwWebServiceV2_ServiceDesignerEventsProcess<TEntity> : Terrasoft.Configuration.VwSysSchemaInWorkspace_BaseEventsProcess<TEntity> where TEntity : VwWebServiceV2
	{

		public VwWebServiceV2_ServiceDesignerEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwWebServiceV2_ServiceDesignerEventsProcess";
			SchemaUId = new Guid("057b56c2-d524-4be3-9668-904d92602fca");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("057b56c2-d524-4be3-9668-904d92602fca");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess3_1f05c9218a06422f9b2f07451f507087;
		public ProcessFlowElement EventSubProcess3_1f05c9218a06422f9b2f07451f507087 {
			get {
				return _eventSubProcess3_1f05c9218a06422f9b2f07451f507087 ?? (_eventSubProcess3_1f05c9218a06422f9b2f07451f507087 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3_1f05c9218a06422f9b2f07451f507087",
					SchemaElementUId = new Guid("1f05c921-8a06-422f-9b2f-07451f507087"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3_2493be51644144d09f6776a067a34c74;
		public ProcessFlowElement StartMessage3_2493be51644144d09f6776a067a34c74 {
			get {
				return _startMessage3_2493be51644144d09f6776a067a34c74 ?? (_startMessage3_2493be51644144d09f6776a067a34c74 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3_2493be51644144d09f6776a067a34c74",
					SchemaElementUId = new Guid("2493be51-6441-44d0-9f67-76a067a34c74"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask3_b50195c767954d739c619c5e769d6319;
		public ProcessScriptTask ScriptTask3_b50195c767954d739c619c5e769d6319 {
			get {
				return _scriptTask3_b50195c767954d739c619c5e769d6319 ?? (_scriptTask3_b50195c767954d739c619c5e769d6319 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3_b50195c767954d739c619c5e769d6319",
					SchemaElementUId = new Guid("b50195c7-6795-4d73-9c61-9c5e769d6319"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3_b50195c767954d739c619c5e769d6319Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess3_1f05c9218a06422f9b2f07451f507087.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3_1f05c9218a06422f9b2f07451f507087 };
			FlowElements[StartMessage3_2493be51644144d09f6776a067a34c74.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3_2493be51644144d09f6776a067a34c74 };
			FlowElements[ScriptTask3_b50195c767954d739c619c5e769d6319.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3_b50195c767954d739c619c5e769d6319 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess3_1f05c9218a06422f9b2f07451f507087":
						break;
					case "StartMessage3_2493be51644144d09f6776a067a34c74":
						e.Context.QueueTasks.Enqueue("ScriptTask3_b50195c767954d739c619c5e769d6319");
						break;
					case "ScriptTask3_b50195c767954d739c619c5e769d6319":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage3_2493be51644144d09f6776a067a34c74");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess3_1f05c9218a06422f9b2f07451f507087":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3_2493be51644144d09f6776a067a34c74":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3_2493be51644144d09f6776a067a34c74";
					result = StartMessage3_2493be51644144d09f6776a067a34c74.Execute(context);
					break;
				case "ScriptTask3_b50195c767954d739c619c5e769d6319":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3_b50195c767954d739c619c5e769d6319";
					result = ScriptTask3_b50195c767954d739c619c5e769d6319.Execute(context, ScriptTask3_b50195c767954d739c619c5e769d6319Execute);
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

		public virtual bool ScriptTask3_b50195c767954d739c619c5e769d6319Execute(ProcessExecutingContext context) {
			UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageSolution");
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "VwWebServiceV2Loading":
							if (ActivatedEventElements.Contains("StartMessage3_2493be51644144d09f6776a067a34c74")) {
							context.QueueTasks.Enqueue("StartMessage3_2493be51644144d09f6776a067a34c74");
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

	#region Class: VwWebServiceV2_ServiceDesignerEventsProcess

	/// <exclude/>
	public class VwWebServiceV2_ServiceDesignerEventsProcess : VwWebServiceV2_ServiceDesignerEventsProcess<VwWebServiceV2>
	{

		public VwWebServiceV2_ServiceDesignerEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwWebServiceV2_ServiceDesignerEventsProcess

	public partial class VwWebServiceV2_ServiceDesignerEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: VwWebServiceV2EventsProcessSchema

	/// <exclude/>
	public class VwWebServiceV2EventsProcessSchema : Terrasoft.Configuration.VwSysSchemaInWorkspaceEventsProcessSchema
	{

		#region Constructors: Public

		public VwWebServiceV2EventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwWebServiceV2EventsProcessSchema(VwWebServiceV2EventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwWebServiceV2_ServiceDesignerEventsProcess";
			UId = new Guid("30636aec-7ec4-408b-b137-b81d2f16db0f");
			CreatedInPackageId = new Guid("9a41e39e-51c2-4a16-b81f-aa6773013744");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("69f4bd29-1b08-4929-8807-a7deaa2a7889");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet_0ff6dc13710f41ba985e6caa6ab51661 = CreateLaneSet_0ff6dc13710f41ba985e6caa6ab51661LaneSet();
			LaneSets.Add(schemaLaneSet_0ff6dc13710f41ba985e6caa6ab51661);
			ProcessSchemaLane schemaLane_15af594300a040e0b2fb1d0da9761a09 = CreateLane_15af594300a040e0b2fb1d0da9761a09Lane();
			schemaLaneSet_0ff6dc13710f41ba985e6caa6ab51661.Lanes.Add(schemaLane_15af594300a040e0b2fb1d0da9761a09);
			ProcessSchemaEventSubProcess eventsubprocess3_1f05c9218a06422f9b2f07451f507087 = CreateEventSubProcess3_1f05c9218a06422f9b2f07451f507087EventSubProcess();
			FlowElements.Add(eventsubprocess3_1f05c9218a06422f9b2f07451f507087);
			ProcessSchemaStartMessageEvent startmessage3_2493be51644144d09f6776a067a34c74 = CreateStartMessage3_2493be51644144d09f6776a067a34c74StartMessageEvent();
			eventsubprocess3_1f05c9218a06422f9b2f07451f507087.FlowElements.Add(startmessage3_2493be51644144d09f6776a067a34c74);
			ProcessSchemaScriptTask scripttask3_b50195c767954d739c619c5e769d6319 = CreateScriptTask3_b50195c767954d739c619c5e769d6319ScriptTask();
			eventsubprocess3_1f05c9218a06422f9b2f07451f507087.FlowElements.Add(scripttask3_b50195c767954d739c619c5e769d6319);
			FlowElements.Add(CreateSequenceFlow4_af6cd89bd0384c4d92bce9256d1d5fcbSequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4_af6cd89bd0384c4d92bce9256d1d5fcbSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4_af6cd89bd0384c4d92bce9256d1d5fcb",
				UId = new Guid("af6cd89b-d038-4c4d-92bc-e9256d1d5fcb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("69f4bd29-1b08-4929-8807-a7deaa2a7889"),
				CreatedInPackageId = new Guid("39d703cc-a16f-4e81-8304-304288ac685a"),
				CreatedInSchemaUId = new Guid("30636aec-7ec4-408b-b137-b81d2f16db0f"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("30636aec-7ec4-408b-b137-b81d2f16db0f"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2493be51-6441-44d0-9f67-76a067a34c74"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b50195c7-6795-4d73-9c61-9c5e769d6319"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet_0ff6dc13710f41ba985e6caa6ab51661LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet_0ff6dc13710f41ba985e6caa6ab51661 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("0ff6dc13-710f-41ba-985e-6caa6ab51661"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("69f4bd29-1b08-4929-8807-a7deaa2a7889"),
				CreatedInPackageId = new Guid("39d703cc-a16f-4e81-8304-304288ac685a"),
				CreatedInSchemaUId = new Guid("30636aec-7ec4-408b-b137-b81d2f16db0f"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("30636aec-7ec4-408b-b137-b81d2f16db0f"),
				Name = @"LaneSet_0ff6dc13710f41ba985e6caa6ab51661",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(0, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet_0ff6dc13710f41ba985e6caa6ab51661;
		}

		protected virtual ProcessSchemaLane CreateLane_15af594300a040e0b2fb1d0da9761a09Lane() {
			ProcessSchemaLane schemaLane_15af594300a040e0b2fb1d0da9761a09 = new ProcessSchemaLane(this) {
				UId = new Guid("15af5943-00a0-40e0-b2fb-1d0da9761a09"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0ff6dc13-710f-41ba-985e-6caa6ab51661"),
				CreatedInOwnerSchemaUId = new Guid("30636aec-7ec4-408b-b137-b81d2f16db0f"),
				CreatedInPackageId = new Guid("39d703cc-a16f-4e81-8304-304288ac685a"),
				CreatedInSchemaUId = new Guid("30636aec-7ec4-408b-b137-b81d2f16db0f"),
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("30636aec-7ec4-408b-b137-b81d2f16db0f"),
				Name = @"Lane_15af594300a040e0b2fb1d0da9761a09",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane_15af594300a040e0b2fb1d0da9761a09;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3_1f05c9218a06422f9b2f07451f507087EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3_1f05c9218a06422f9b2f07451f507087 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1f05c921-8a06-422f-9b2f-07451f507087"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("15af5943-00a0-40e0-b2fb-1d0da9761a09"),
				CreatedInOwnerSchemaUId = new Guid("69f4bd29-1b08-4929-8807-a7deaa2a7889"),
				CreatedInPackageId = new Guid("39d703cc-a16f-4e81-8304-304288ac685a"),
				CreatedInSchemaUId = new Guid("30636aec-7ec4-408b-b137-b81d2f16db0f"),
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("30636aec-7ec4-408b-b137-b81d2f16db0f"),
				Name = @"EventSubProcess3_1f05c9218a06422f9b2f07451f507087",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(17, 85),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(307, 300),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3_1f05c9218a06422f9b2f07451f507087;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage3_2493be51644144d09f6776a067a34c74StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2493be51-6441-44d0-9f67-76a067a34c74"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1f05c921-8a06-422f-9b2f-07451f507087"),
				CreatedInOwnerSchemaUId = new Guid("69f4bd29-1b08-4929-8807-a7deaa2a7889"),
				CreatedInPackageId = new Guid("39d703cc-a16f-4e81-8304-304288ac685a"),
				CreatedInSchemaUId = new Guid("30636aec-7ec4-408b-b137-b81d2f16db0f"),
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"VwWebServiceV2Loading",
				ModifiedInSchemaUId = new Guid("30636aec-7ec4-408b-b137-b81d2f16db0f"),
				Name = @"StartMessage3_2493be51644144d09f6776a067a34c74",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 137),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask3_b50195c767954d739c619c5e769d6319ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b50195c7-6795-4d73-9c61-9c5e769d6319"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1f05c921-8a06-422f-9b2f-07451f507087"),
				CreatedInOwnerSchemaUId = new Guid("69f4bd29-1b08-4929-8807-a7deaa2a7889"),
				CreatedInPackageId = new Guid("39d703cc-a16f-4e81-8304-304288ac685a"),
				CreatedInSchemaUId = new Guid("30636aec-7ec4-408b-b137-b81d2f16db0f"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("30636aec-7ec4-408b-b137-b81d2f16db0f"),
				Name = @"ScriptTask3_b50195c767954d739c619c5e769d6319",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(207, 123),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = true,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,78,45,114,206,207,203,75,77,46,201,204,207,211,115,113,10,78,77,46,45,202,44,169,116,205,75,207,204,75,213,115,206,72,77,206,118,78,204,115,173,0,138,151,164,250,23,164,22,37,130,84,106,40,1,5,125,19,243,18,211,83,131,243,115,74,65,66,74,154,214,92,69,169,37,165,69,121,10,37,69,165,169,214,0,152,250,208,102,91,0,0,0 }
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
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwWebServiceV2EventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("30636aec-7ec4-408b-b137-b81d2f16db0f"));
		}

		#endregion

	}

	#endregion


	#region Class: VwWebServiceV2EventsProcess

	/// <exclude/>
	public class VwWebServiceV2EventsProcess : VwWebServiceV2_ServiceDesignerEventsProcess
	{

		public VwWebServiceV2EventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

