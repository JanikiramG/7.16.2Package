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

	#region Class: ContractSchema

	/// <exclude/>
	public class ContractSchema : Terrasoft.Configuration.Contract_SalesContracts_TerrasoftSchema
	{

		#region Constructors: Public

		public ContractSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ContractSchema(ContractSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ContractSchema(ContractSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("045d818c-9760-4555-9b59-7b6158c6b816");
			Name = "Contract";
			ParentSchemaUId = new Guid("897be3e4-0333-467d-88e2-b7a945c0d810");
			ExtendParent = true;
			CreatedInPackageId = new Guid("2a36bdd9-0ef6-48f3-957f-b7efa409d0a7");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("fe23692e-01f1-476d-9605-3a1fede76644")) == null) {
				Columns.Add(CreateOrderColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateOrderColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("fe23692e-01f1-476d-9605-3a1fede76644"),
				Name = @"Order",
				ReferenceSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("045d818c-9760-4555-9b59-7b6158c6b816"),
				ModifiedInSchemaUId = new Guid("045d818c-9760-4555-9b59-7b6158c6b816"),
				CreatedInPackageId = new Guid("2a36bdd9-0ef6-48f3-957f-b7efa409d0a7")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateContractEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateContractEventsProcessSchema() {
			var schema = new ContractEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Contract(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Contract_ContractInOrderEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ContractSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ContractSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("045d818c-9760-4555-9b59-7b6158c6b816"));
		}

		#endregion

	}

	#endregion

	#region Class: Contract

	/// <summary>
	/// Contract.
	/// </summary>
	public class Contract : Terrasoft.Configuration.Contract_SalesContracts_Terrasoft
	{

		#region Constructors: Public

		public Contract(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Contract";
		}

		public Contract(Contract source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid OrderId {
			get {
				return GetTypedColumnValue<Guid>("OrderId");
			}
			set {
				SetColumnValue("OrderId", value);
				_order = null;
			}
		}

		/// <exclude/>
		public string OrderNumber {
			get {
				return GetTypedColumnValue<string>("OrderNumber");
			}
			set {
				SetColumnValue("OrderNumber", value);
				if (_order != null) {
					_order.Number = value;
				}
			}
		}

		private Order _order;
		/// <summary>
		/// Order.
		/// </summary>
		public Order Order {
			get {
				return _order ??
					(_order = LookupColumnEntities.GetEntity("Order") as Order);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Contract_ContractInOrderEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ContractDeleted", e);
			Deleting += (s, e) => ThrowEvent("ContractDeleting", e);
			Saved += (s, e) => ThrowEvent("ContractSaved", e);
			Saving += (s, e) => ThrowEvent("ContractSaving", e);
			Validating += (s, e) => ThrowEvent("ContractValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Contract(this);
		}

		#endregion

	}

	#endregion

	#region Class: Contract_ContractInOrderEventsProcess

	/// <exclude/>
	public partial class Contract_ContractInOrderEventsProcess<TEntity> : Terrasoft.Configuration.Contract_SalesContractsEventsProcess<TEntity> where TEntity : Contract
	{

		public Contract_ContractInOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Contract_ContractInOrderEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("045d818c-9760-4555-9b59-7b6158c6b816");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual Guid oldOrderId {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcessContractSaving;
		public ProcessFlowElement EventSubProcessContractSaving {
			get {
				return _eventSubProcessContractSaving ?? (_eventSubProcessContractSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessContractSaving",
					SchemaElementUId = new Guid("b1ed7dfb-b4d1-4adf-8967-1ff041663f64"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptContractSaving;
		public ProcessScriptTask ScriptContractSaving {
			get {
				return _scriptContractSaving ?? (_scriptContractSaving = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptContractSaving",
					SchemaElementUId = new Guid("cbf016a7-201d-418f-8a8f-f811accb0aef"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptContractSavingExecute,
				});
			}
		}

		private ProcessFlowElement _contractSaving;
		public ProcessFlowElement ContractSaving {
			get {
				return _contractSaving ?? (_contractSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ContractSaving",
					SchemaElementUId = new Guid("efb0b775-7de6-475c-8faa-c1fadcfe0c6a"),
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
					SchemaElementUId = new Guid("22fe653a-ef27-4baa-a877-1b44a7f3af18"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptContractSaved;
		public ProcessScriptTask ScriptContractSaved {
			get {
				return _scriptContractSaved ?? (_scriptContractSaved = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptContractSaved",
					SchemaElementUId = new Guid("63ada70c-2379-4e06-9798-74c94cdfd02c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptContractSavedExecute,
				});
			}
		}

		private ProcessFlowElement _contractDeleting;
		public ProcessFlowElement ContractDeleting {
			get {
				return _contractDeleting ?? (_contractDeleting = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ContractDeleting",
					SchemaElementUId = new Guid("318899de-4ac6-4604-8d3f-50223dd539d6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptContractDeleting;
		public ProcessScriptTask ScriptContractDeleting {
			get {
				return _scriptContractDeleting ?? (_scriptContractDeleting = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptContractDeleting",
					SchemaElementUId = new Guid("d49e46b6-1618-4036-a186-94d866018fd8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptContractDeletingExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcessContractSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessContractSaving };
			FlowElements[ScriptContractSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptContractSaving };
			FlowElements[ContractSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { ContractSaving };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[ScriptContractSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptContractSaved };
			FlowElements[ContractDeleting.SchemaElementUId] = new Collection<ProcessFlowElement> { ContractDeleting };
			FlowElements[ScriptContractDeleting.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptContractDeleting };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcessContractSaving":
						break;
					case "ScriptContractSaving":
						break;
					case "ContractSaving":
						e.Context.QueueTasks.Enqueue("ScriptContractSaving");
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("ScriptContractSaved");
						break;
					case "ScriptContractSaved":
						break;
					case "ContractDeleting":
						e.Context.QueueTasks.Enqueue("ScriptContractDeleting");
						break;
					case "ScriptContractDeleting":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ContractSaving");
			ActivatedEventElements.Add("StartMessage1");
			ActivatedEventElements.Add("ContractDeleting");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcessContractSaving":
					context.QueueTasks.Dequeue();
					break;
				case "ScriptContractSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptContractSaving";
					result = ScriptContractSaving.Execute(context, ScriptContractSavingExecute);
					break;
				case "ContractSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "ContractSaving";
					result = ContractSaving.Execute(context);
					break;
				case "StartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1";
					result = StartMessage1.Execute(context);
					break;
				case "ScriptContractSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptContractSaved";
					result = ScriptContractSaved.Execute(context, ScriptContractSavedExecute);
					break;
				case "ContractDeleting":
					context.QueueTasks.Dequeue();
					context.SenderName = "ContractDeleting";
					result = ContractDeleting.Execute(context);
					break;
				case "ScriptContractDeleting":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptContractDeleting";
					result = ScriptContractDeleting.Execute(context, ScriptContractDeletingExecute);
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

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "oldOrderId":
					oldOrderId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptContractSavingExecute(ProcessExecutingContext context) {
			oldOrderId = Entity.GetTypedOldColumnValue<Guid>("OrderId");
			return true;
		}

		public virtual bool ScriptContractSavedExecute(ProcessExecutingContext context) {
			var OrderId = Entity.GetTypedColumnValue<Guid>("OrderId");
			var doUpdate = false;
			if (OrderId == null || OrderId.Equals(Guid.Empty)) {
				doUpdate = true;
			} else {
				if (OrderId != oldOrderId) {
					doUpdate = true;
				}
			}
			if (doUpdate) {
				var update = new Update(UserConnection, "OrderProduct")
								.Set("ContractId", Column.Const(null))
								.Where("OrderId").IsEqual(Column.Parameter(oldOrderId));
								update.Execute();	
			}
			return true;
		}

		public virtual bool ScriptContractDeletingExecute(ProcessExecutingContext context) {
			var OrderId = Entity.GetTypedColumnValue<Guid>("OrderId");
			var update = new Update(UserConnection, "OrderProduct")
							.Set("ContractId", Column.Const(null))
							.Where("OrderId").IsEqual(Column.Parameter(OrderId))
							.And("ContractId").IsEqual(Column.Parameter(Entity.Id));
							update.Execute();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ContractSaving":
							if (ActivatedEventElements.Contains("ContractSaving")) {
							context.QueueTasks.Enqueue("ContractSaving");
						}
						break;
					case "ContractSaved":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
						}
						break;
					case "ContractDeleting":
							if (ActivatedEventElements.Contains("ContractDeleting")) {
							context.QueueTasks.Enqueue("ContractDeleting");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("oldOrderId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("oldOrderId", oldOrderId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: Contract_ContractInOrderEventsProcess

	/// <exclude/>
	public class Contract_ContractInOrderEventsProcess : Contract_ContractInOrderEventsProcess<Contract>
	{

		public Contract_ContractInOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Contract_ContractInOrderEventsProcess

	public partial class Contract_ContractInOrderEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: ContractEventsProcessSchema

	/// <exclude/>
	public class ContractEventsProcessSchema : Terrasoft.Configuration.Contract_SalesContracts_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public ContractEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ContractEventsProcessSchema(ContractEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Contract_ContractInOrderEventsProcess";
			UId = new Guid("4968ab85-d40a-49bb-9c91-47c871dfa8c7");
			CreatedInPackageId = new Guid("2a36bdd9-0ef6-48f3-957f-b7efa409d0a7");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("37f144c9-f2b6-4c56-8111-460248e89c07");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateoldOrderIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("56935773-104a-4341-b4c2-7e6497363710"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4968ab85-d40a-49bb-9c91-47c871dfa8c7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4968ab85-d40a-49bb-9c91-47c871dfa8c7"),
				Name = @"oldOrderId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateoldOrderIdParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneContractSaving = CreateLaneContractSavingLaneSet();
			LaneSets.Add(schemaLaneContractSaving);
			ProcessSchemaLane schemaLane1ContractSaving = CreateLane1ContractSavingLane();
			schemaLaneContractSaving.Lanes.Add(schemaLane1ContractSaving);
			ProcessSchemaEventSubProcess eventsubprocesscontractsaving = CreateEventSubProcessContractSavingEventSubProcess();
			FlowElements.Add(eventsubprocesscontractsaving);
			ProcessSchemaScriptTask scriptcontractsaving = CreateScriptContractSavingScriptTask();
			eventsubprocesscontractsaving.FlowElements.Add(scriptcontractsaving);
			ProcessSchemaStartMessageEvent contractsaving = CreateContractSavingStartMessageEvent();
			eventsubprocesscontractsaving.FlowElements.Add(contractsaving);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			eventsubprocesscontractsaving.FlowElements.Add(startmessage1);
			ProcessSchemaScriptTask scriptcontractsaved = CreateScriptContractSavedScriptTask();
			eventsubprocesscontractsaving.FlowElements.Add(scriptcontractsaved);
			ProcessSchemaStartMessageEvent contractdeleting = CreateContractDeletingStartMessageEvent();
			eventsubprocesscontractsaving.FlowElements.Add(contractdeleting);
			ProcessSchemaScriptTask scriptcontractdeleting = CreateScriptContractDeletingScriptTask();
			eventsubprocesscontractsaving.FlowElements.Add(scriptcontractdeleting);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("fb6fff77-9734-4ca1-b934-8d8b6ca188a2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("23a3d81d-008b-49a5-8830-30fe183b4640"),
				CreatedInPackageId = new Guid("5ac6cdcc-e8ea-4080-955f-f02d55e65283"),
				CreatedInSchemaUId = new Guid("4968ab85-d40a-49bb-9c91-47c871dfa8c7"),
				CurveCenterPosition = new Point(153, 117),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4968ab85-d40a-49bb-9c91-47c871dfa8c7"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("efb0b775-7de6-475c-8faa-c1fadcfe0c6a"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cbf016a7-201d-418f-8a8f-f811accb0aef"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("31e0ec69-cacb-469a-bd5e-f2d107e9a054"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("23a3d81d-008b-49a5-8830-30fe183b4640"),
				CreatedInPackageId = new Guid("5ac6cdcc-e8ea-4080-955f-f02d55e65283"),
				CreatedInSchemaUId = new Guid("4968ab85-d40a-49bb-9c91-47c871dfa8c7"),
				CurveCenterPosition = new Point(152, 273),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4968ab85-d40a-49bb-9c91-47c871dfa8c7"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("22fe653a-ef27-4baa-a877-1b44a7f3af18"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("63ada70c-2379-4e06-9798-74c94cdfd02c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("21062b6a-1f46-4082-a1d0-83d90b701eeb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("23a3d81d-008b-49a5-8830-30fe183b4640"),
				CreatedInPackageId = new Guid("5ac6cdcc-e8ea-4080-955f-f02d55e65283"),
				CreatedInSchemaUId = new Guid("4968ab85-d40a-49bb-9c91-47c871dfa8c7"),
				CurveCenterPosition = new Point(154, 302),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4968ab85-d40a-49bb-9c91-47c871dfa8c7"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("318899de-4ac6-4604-8d3f-50223dd539d6"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d49e46b6-1618-4036-a186-94d866018fd8"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneContractSavingLaneSet() {
			ProcessSchemaLaneSet schemaLaneContractSaving = new ProcessSchemaLaneSet(this) {
				UId = new Guid("46903ba5-fce3-4518-b300-3f113294e904"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("23a3d81d-008b-49a5-8830-30fe183b4640"),
				CreatedInPackageId = new Guid("5ac6cdcc-e8ea-4080-955f-f02d55e65283"),
				CreatedInSchemaUId = new Guid("4968ab85-d40a-49bb-9c91-47c871dfa8c7"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("4968ab85-d40a-49bb-9c91-47c871dfa8c7"),
				Name = @"LaneContractSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1256, 410),
				UseBackgroundMode = false
			};
			return schemaLaneContractSaving;
		}

		protected virtual ProcessSchemaLane CreateLane1ContractSavingLane() {
			ProcessSchemaLane schemaLane1ContractSaving = new ProcessSchemaLane(this) {
				UId = new Guid("a5b863ed-0889-4f24-867f-1bfb8eb141c1"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("46903ba5-fce3-4518-b300-3f113294e904"),
				CreatedInOwnerSchemaUId = new Guid("045d818c-9760-4555-9b59-7b6158c6b816"),
				CreatedInPackageId = new Guid("5ac6cdcc-e8ea-4080-955f-f02d55e65283"),
				CreatedInSchemaUId = new Guid("4968ab85-d40a-49bb-9c91-47c871dfa8c7"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("4968ab85-d40a-49bb-9c91-47c871dfa8c7"),
				Name = @"Lane1ContractSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1227, 410),
				UseBackgroundMode = false
			};
			return schemaLane1ContractSaving;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessContractSavingEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessContractSaving = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b1ed7dfb-b4d1-4adf-8967-1ff041663f64"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a5b863ed-0889-4f24-867f-1bfb8eb141c1"),
				CreatedInOwnerSchemaUId = new Guid("23a3d81d-008b-49a5-8830-30fe183b4640"),
				CreatedInPackageId = new Guid("5ac6cdcc-e8ea-4080-955f-f02d55e65283"),
				CreatedInSchemaUId = new Guid("4968ab85-d40a-49bb-9c91-47c871dfa8c7"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("4968ab85-d40a-49bb-9c91-47c871dfa8c7"),
				Name = @"EventSubProcessContractSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(50, 16),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(412, 380),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessContractSaving;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptContractSavingScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("cbf016a7-201d-418f-8a8f-f811accb0aef"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b1ed7dfb-b4d1-4adf-8967-1ff041663f64"),
				CreatedInOwnerSchemaUId = new Guid("23a3d81d-008b-49a5-8830-30fe183b4640"),
				CreatedInPackageId = new Guid("5ac6cdcc-e8ea-4080-955f-f02d55e65283"),
				CreatedInSchemaUId = new Guid("4968ab85-d40a-49bb-9c91-47c871dfa8c7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("4968ab85-d40a-49bb-9c91-47c871dfa8c7"),
				Name = @"ScriptContractSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(99, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,207,73,241,47,74,73,45,242,76,81,176,85,112,205,43,201,44,169,212,115,79,45,9,169,44,72,77,241,207,73,113,206,207,41,205,205,11,75,204,41,77,181,113,47,205,76,177,211,80,130,42,87,210,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,111,150,64,36,74,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateContractSavingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("efb0b775-7de6-475c-8faa-c1fadcfe0c6a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b1ed7dfb-b4d1-4adf-8967-1ff041663f64"),
				CreatedInOwnerSchemaUId = new Guid("23a3d81d-008b-49a5-8830-30fe183b4640"),
				CreatedInPackageId = new Guid("5ac6cdcc-e8ea-4080-955f-f02d55e65283"),
				CreatedInSchemaUId = new Guid("4968ab85-d40a-49bb-9c91-47c871dfa8c7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ContractSaving",
				ModifiedInSchemaUId = new Guid("4968ab85-d40a-49bb-9c91-47c871dfa8c7"),
				Name = @"ContractSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(8, 79),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("22fe653a-ef27-4baa-a877-1b44a7f3af18"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b1ed7dfb-b4d1-4adf-8967-1ff041663f64"),
				CreatedInOwnerSchemaUId = new Guid("23a3d81d-008b-49a5-8830-30fe183b4640"),
				CreatedInPackageId = new Guid("5ac6cdcc-e8ea-4080-955f-f02d55e65283"),
				CreatedInSchemaUId = new Guid("4968ab85-d40a-49bb-9c91-47c871dfa8c7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ContractSaved",
				ModifiedInSchemaUId = new Guid("4968ab85-d40a-49bb-9c91-47c871dfa8c7"),
				Name = @"StartMessage1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(217, 77),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptContractSavedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("63ada70c-2379-4e06-9798-74c94cdfd02c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b1ed7dfb-b4d1-4adf-8967-1ff041663f64"),
				CreatedInOwnerSchemaUId = new Guid("23a3d81d-008b-49a5-8830-30fe183b4640"),
				CreatedInPackageId = new Guid("5ac6cdcc-e8ea-4080-955f-f02d55e65283"),
				CreatedInSchemaUId = new Guid("4968ab85-d40a-49bb-9c91-47c871dfa8c7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("4968ab85-d40a-49bb-9c91-47c871dfa8c7"),
				Name = @"ScriptContractSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(308, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,80,65,106,195,48,16,60,59,144,63,108,125,146,32,232,3,169,123,9,38,228,212,64,155,246,44,172,13,53,200,146,179,94,165,53,77,254,94,217,178,131,15,213,77,187,51,179,51,115,213,4,175,100,144,14,6,10,40,29,215,220,171,61,242,123,223,162,217,121,27,26,247,161,109,192,231,125,168,205,139,200,39,108,46,183,235,213,53,114,141,63,181,70,51,70,242,89,219,14,227,184,62,131,120,72,22,224,130,181,112,187,205,87,84,121,9,17,40,6,61,85,54,45,247,82,194,239,122,149,45,148,152,194,32,116,7,140,138,227,114,169,249,84,128,183,102,250,37,238,63,228,236,30,5,146,153,121,153,176,131,235,48,131,29,126,67,90,138,83,135,180,243,206,97,197,181,119,27,72,81,143,228,77,168,56,151,195,149,248,212,27,178,200,35,142,73,87,28,139,216,64,106,73,197,89,199,98,72,43,31,224,207,47,36,92,148,166,14,221,24,95,76,156,163,38,221,32,35,137,69,162,161,218,145,158,92,170,242,7,171,16,13,202,109,54,70,34,228,64,46,229,252,3,134,49,43,218,191,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateContractDeletingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("318899de-4ac6-4604-8d3f-50223dd539d6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b1ed7dfb-b4d1-4adf-8967-1ff041663f64"),
				CreatedInOwnerSchemaUId = new Guid("23a3d81d-008b-49a5-8830-30fe183b4640"),
				CreatedInPackageId = new Guid("5ac6cdcc-e8ea-4080-955f-f02d55e65283"),
				CreatedInSchemaUId = new Guid("4968ab85-d40a-49bb-9c91-47c871dfa8c7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ContractDeleting",
				ModifiedInSchemaUId = new Guid("4968ab85-d40a-49bb-9c91-47c871dfa8c7"),
				Name = @"ContractDeleting",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(7, 266),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptContractDeletingScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d49e46b6-1618-4036-a186-94d866018fd8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b1ed7dfb-b4d1-4adf-8967-1ff041663f64"),
				CreatedInOwnerSchemaUId = new Guid("23a3d81d-008b-49a5-8830-30fe183b4640"),
				CreatedInPackageId = new Guid("5ac6cdcc-e8ea-4080-955f-f02d55e65283"),
				CreatedInSchemaUId = new Guid("4968ab85-d40a-49bb-9c91-47c871dfa8c7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("4968ab85-d40a-49bb-9c91-47c871dfa8c7"),
				Name = @"ScriptContractDeleting",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(98, 252),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,143,65,10,194,64,12,69,215,10,189,195,208,213,20,100,46,80,21,68,138,116,101,65,171,235,161,19,176,48,166,154,38,106,111,239,212,86,209,141,217,37,188,151,207,191,89,82,91,114,64,185,83,11,149,33,215,220,153,13,240,190,187,128,91,55,94,206,120,176,94,96,190,145,218,45,117,60,178,113,146,70,211,91,112,229,226,44,67,80,17,238,170,124,45,186,108,129,214,13,34,84,92,55,56,83,131,84,80,227,164,226,56,137,166,147,48,102,7,172,227,128,49,217,138,195,199,153,26,226,76,184,181,172,81,188,79,222,236,241,4,4,95,225,38,111,179,171,88,175,71,165,176,100,207,192,64,122,68,62,230,10,221,79,202,31,117,44,223,203,233,96,15,229,76,246,128,74,66,175,254,76,192,66,168,152,4,210,39,131,87,75,33,60,1,0,0 }
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
			return new ContractEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4968ab85-d40a-49bb-9c91-47c871dfa8c7"));
		}

		#endregion

	}

	#endregion


	#region Class: ContractEventsProcess

	/// <exclude/>
	public class ContractEventsProcess : Contract_ContractInOrderEventsProcess
	{

		public ContractEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

