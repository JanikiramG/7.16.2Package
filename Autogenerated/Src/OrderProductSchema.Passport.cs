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
	using Terrasoft.Configuration.Passport;
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

	#region Class: OrderProduct_Passport_TerrasoftSchema

	/// <exclude/>
	public class OrderProduct_Passport_TerrasoftSchema : Terrasoft.Configuration.OrderProduct_ProductCatalogueInOrder_TerrasoftSchema
	{

		#region Constructors: Public

		public OrderProduct_Passport_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OrderProduct_Passport_TerrasoftSchema(OrderProduct_Passport_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OrderProduct_Passport_TerrasoftSchema(OrderProduct_Passport_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("a4db212d-a935-4e07-85be-0f44f761c227");
			Name = "OrderProduct_Passport_Terrasoft";
			ParentSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			ExtendParent = true;
			CreatedInPackageId = new Guid("5ad21e1a-95d7-43e1-8821-5a5bb2a4bde1");
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
			EventsProcessSchema = CreateOrderProduct_Passport_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateOrderProduct_Passport_TerrasoftEventsProcessSchema() {
			var schema = new OrderProduct_Passport_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new OrderProduct_Passport_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OrderProduct_PassportEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OrderProduct_Passport_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OrderProduct_Passport_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a4db212d-a935-4e07-85be-0f44f761c227"));
		}

		#endregion

	}

	#endregion

	#region Class: OrderProduct_Passport_Terrasoft

	/// <summary>
	/// Product in order.
	/// </summary>
	public class OrderProduct_Passport_Terrasoft : Terrasoft.Configuration.OrderProduct_ProductCatalogueInOrder_Terrasoft
	{

		#region Constructors: Public

		public OrderProduct_Passport_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OrderProduct_Passport_Terrasoft";
		}

		public OrderProduct_Passport_Terrasoft(OrderProduct_Passport_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OrderProduct_PassportEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("OrderProduct_Passport_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("OrderProduct_Passport_TerrasoftDeleting", e);
			Saved += (s, e) => ThrowEvent("OrderProduct_Passport_TerrasoftSaved", e);
			Validating += (s, e) => ThrowEvent("OrderProduct_Passport_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OrderProduct_Passport_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: OrderProduct_PassportEventsProcess

	/// <exclude/>
	public partial class OrderProduct_PassportEventsProcess<TEntity> : Terrasoft.Configuration.OrderProduct_ProductCatalogueInOrderEventsProcess<TEntity> where TEntity : OrderProduct_Passport_Terrasoft
	{

		public OrderProduct_PassportEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OrderProduct_PassportEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a4db212d-a935-4e07-85be-0f44f761c227");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual Object SupplyPaymentElementsToRecalc {
			get;
			set;
		}

		private ProcessFlowElement _beforeDeleteEventSubProcess;
		public ProcessFlowElement BeforeDeleteEventSubProcess {
			get {
				return _beforeDeleteEventSubProcess ?? (_beforeDeleteEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BeforeDeleteEventSubProcess",
					SchemaElementUId = new Guid("f0d29e68-a154-4045-b2a3-aa28b1d224f3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _orderProductDeletingStartMessage;
		public ProcessFlowElement OrderProductDeletingStartMessage {
			get {
				return _orderProductDeletingStartMessage ?? (_orderProductDeletingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OrderProductDeletingStartMessage",
					SchemaElementUId = new Guid("30f14d8f-e6ec-447a-85b6-da4e2a8a1bea"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _passportBeforeDeleteScriptTask;
		public ProcessScriptTask PassportBeforeDeleteScriptTask {
			get {
				return _passportBeforeDeleteScriptTask ?? (_passportBeforeDeleteScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PassportBeforeDeleteScriptTask",
					SchemaElementUId = new Guid("648cabb4-e1c3-4b9a-b268-a9efc731e79d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PassportBeforeDeleteScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[BeforeDeleteEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { BeforeDeleteEventSubProcess };
			FlowElements[OrderProductDeletingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { OrderProductDeletingStartMessage };
			FlowElements[PassportBeforeDeleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PassportBeforeDeleteScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "BeforeDeleteEventSubProcess":
						break;
					case "OrderProductDeletingStartMessage":
						e.Context.QueueTasks.Enqueue("PassportBeforeDeleteScriptTask");
						break;
					case "PassportBeforeDeleteScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("OrderProductDeletingStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "BeforeDeleteEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "OrderProductDeletingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OrderProductDeletingStartMessage";
					result = OrderProductDeletingStartMessage.Execute(context);
					break;
				case "PassportBeforeDeleteScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PassportBeforeDeleteScriptTask";
					result = PassportBeforeDeleteScriptTask.Execute(context, PassportBeforeDeleteScriptTaskExecute);
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
				case "SupplyPaymentElementsToRecalc":
					SupplyPaymentElementsToRecalc = reader.GetSerializableObjectValue();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool PassportBeforeDeleteScriptTaskExecute(ProcessExecutingContext context) {
			var helper = ClassFactory.Get<OrderAmountHelper>(new ConstructorArgument("userConnection", UserConnection));
			SupplyPaymentElementsToRecalc = helper.GetSupplyPaymentElementIdsByOrderProduct(Entity.PrimaryColumnValue);
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "OrderProduct_Passport_TerrasoftDeleting":
							if (ActivatedEventElements.Contains("OrderProductDeletingStartMessage")) {
							context.QueueTasks.Enqueue("OrderProductDeletingStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (SupplyPaymentElementsToRecalc != null) {
				if (SupplyPaymentElementsToRecalc.GetType().IsSerializable ||
					SupplyPaymentElementsToRecalc.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("SupplyPaymentElementsToRecalc", SupplyPaymentElementsToRecalc, null);
				}
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: OrderProduct_PassportEventsProcess

	/// <exclude/>
	public class OrderProduct_PassportEventsProcess : OrderProduct_PassportEventsProcess<OrderProduct_Passport_Terrasoft>
	{

		public OrderProduct_PassportEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OrderProduct_PassportEventsProcess

	public partial class OrderProduct_PassportEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void RecalculateOrderAmount() {
			base.RecalculateOrderAmount();
			var helper = ClassFactory.Get<OrderAmountHelper>(new ConstructorArgument("userConnection", UserConnection));
			if (IsProductDeleted){
				if (SupplyPaymentElementsToRecalc != null) {
					var speIds = (List<Guid>)SupplyPaymentElementsToRecalc;
					helper.OnOrderProductDeleted(Entity.GetTypedColumnValue<Guid>("OrderId"), speIds);
				}
			} else {
				var changedColumnValues = ChangedColumnValues as IEnumerable<EntityColumnValue>;
				helper.OnOrderProductChanged(Entity.PrimaryColumnValue, changedColumnValues);
			}
		}

		public override void UpdatePrimaryAmounts() {
			if (NeedRecalcPrimaryValues){
				base.UpdatePrimaryAmounts();
			}
		}

		#endregion

	}

	#endregion

	#region Class: OrderProduct_Passport_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class OrderProduct_Passport_TerrasoftEventsProcessSchema : Terrasoft.Configuration.OrderProduct_ProductCatalogueInOrder_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public OrderProduct_Passport_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public OrderProduct_Passport_TerrasoftEventsProcessSchema(OrderProduct_Passport_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "OrderProduct_PassportEventsProcess";
			UId = new Guid("4547464f-6398-4743-8f75-d961a687af23");
			CreatedInPackageId = new Guid("5ad21e1a-95d7-43e1-8821-5a5bb2a4bde1");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateSupplyPaymentElementsToRecalcParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("bb222fbf-994d-4895-add8-5dc10cc1e228"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4547464f-6398-4743-8f75-d961a687af23"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4547464f-6398-4743-8f75-d961a687af23"),
				Name = @"SupplyPaymentElementsToRecalc",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateSupplyPaymentElementsToRecalcParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaPassportLaneSet = CreatePassportLaneSetLaneSet();
			LaneSets.Add(schemaPassportLaneSet);
			ProcessSchemaLane schemaPassportLane = CreatePassportLaneLane();
			schemaPassportLaneSet.Lanes.Add(schemaPassportLane);
			ProcessSchemaEventSubProcess beforedeleteeventsubprocess = CreateBeforeDeleteEventSubProcessEventSubProcess();
			FlowElements.Add(beforedeleteeventsubprocess);
			ProcessSchemaStartMessageEvent orderproductdeletingstartmessage = CreateOrderProductDeletingStartMessageStartMessageEvent();
			beforedeleteeventsubprocess.FlowElements.Add(orderproductdeletingstartmessage);
			ProcessSchemaScriptTask passportbeforedeletescripttask = CreatePassportBeforeDeleteScriptTaskScriptTask();
			beforedeleteeventsubprocess.FlowElements.Add(passportbeforedeletescripttask);
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("ef8f8d11-8d43-4312-82b6-81a58e34c7e3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				CreatedInSchemaUId = new Guid("4547464f-6398-4743-8f75-d961a687af23"),
				CurveCenterPosition = new Point(158, 92),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4547464f-6398-4743-8f75-d961a687af23"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("30f14d8f-e6ec-447a-85b6-da4e2a8a1bea"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("648cabb4-e1c3-4b9a-b268-a9efc731e79d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreatePassportLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaPassportLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("ca386c06-2777-4043-b043-163efab73b0d"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				CreatedInSchemaUId = new Guid("4547464f-6398-4743-8f75-d961a687af23"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("4547464f-6398-4743-8f75-d961a687af23"),
				Name = @"PassportLaneSet",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1070, 185),
				UseBackgroundMode = false
			};
			return schemaPassportLaneSet;
		}

		protected virtual ProcessSchemaLane CreatePassportLaneLane() {
			ProcessSchemaLane schemaPassportLane = new ProcessSchemaLane(this) {
				UId = new Guid("e73f285c-42a6-4991-af54-4560084a4d3a"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("ca386c06-2777-4043-b043-163efab73b0d"),
				CreatedInOwnerSchemaUId = new Guid("a4db212d-a935-4e07-85be-0f44f761c227"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				CreatedInSchemaUId = new Guid("4547464f-6398-4743-8f75-d961a687af23"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("4547464f-6398-4743-8f75-d961a687af23"),
				Name = @"PassportLane",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1041, 185),
				UseBackgroundMode = false
			};
			return schemaPassportLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateBeforeDeleteEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaBeforeDeleteEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f0d29e68-a154-4045-b2a3-aa28b1d224f3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e73f285c-42a6-4991-af54-4560084a4d3a"),
				CreatedInOwnerSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				CreatedInSchemaUId = new Guid("4547464f-6398-4743-8f75-d961a687af23"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("4547464f-6398-4743-8f75-d961a687af23"),
				Name = @"BeforeDeleteEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(49, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(197, 164),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaBeforeDeleteEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOrderProductDeletingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("30f14d8f-e6ec-447a-85b6-da4e2a8a1bea"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f0d29e68-a154-4045-b2a3-aa28b1d224f3"),
				CreatedInOwnerSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				CreatedInSchemaUId = new Guid("4547464f-6398-4743-8f75-d961a687af23"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OrderProductDeleting",
				ModifiedInSchemaUId = new Guid("4547464f-6398-4743-8f75-d961a687af23"),
				Name = @"OrderProductDeletingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(8, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePassportBeforeDeleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("648cabb4-e1c3-4b9a-b268-a9efc731e79d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f0d29e68-a154-4045-b2a3-aa28b1d224f3"),
				CreatedInOwnerSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				CreatedInSchemaUId = new Guid("4547464f-6398-4743-8f75-d961a687af23"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("4547464f-6398-4743-8f75-d961a687af23"),
				Name = @"PassportBeforeDeleteScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(92, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,142,205,10,194,48,12,128,239,130,239,80,118,154,32,123,129,169,48,199,252,57,57,252,187,151,45,232,160,77,71,154,40,125,123,219,121,18,60,5,146,47,124,223,75,147,122,130,25,129,212,90,213,70,123,191,211,29,59,10,197,30,120,117,162,30,168,178,78,144,15,19,180,201,17,222,170,118,232,153,36,113,21,61,196,2,114,158,137,7,138,7,132,142,7,135,217,82,221,126,22,139,69,57,159,93,100,28,77,104,117,72,47,141,129,52,252,213,157,161,211,166,139,1,223,146,164,254,71,30,123,191,13,83,82,75,174,143,250,188,65,30,56,20,45,13,86,83,168,157,17,139,119,109,4,146,140,128,133,80,197,80,40,63,169,40,106,37,231,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("548ae0cd-ca9a-4b2e-bceb-0a9122f820fe"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("ea2e3ae4-7b44-4850-bdfa-8147ce4d763d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("56e97a4f-c9b4-4a16-ad24-0d5926b8d5a1"),
				Name = "Terrasoft.Configuration.Passport",
				Alias = "",
				CreatedInPackageId = new Guid("ea2e3ae4-7b44-4850-bdfa-8147ce4d763d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f4ae16a-b6b6-4ad3-a4ea-e8db646b0b90"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("d6ad04c1-fa0b-4adb-bfd8-17ec17775a03")
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

		protected override SchemaMethod CreateRecalculateOrderAmountMethod() {
			SchemaMethod method = base.CreateRecalculateOrderAmountMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,221,106,131,64,16,133,175,21,124,135,173,87,10,226,11,196,8,193,218,84,40,68,218,180,247,27,119,154,8,227,174,236,79,139,148,188,123,29,77,65,33,244,106,97,230,156,51,223,217,19,55,144,190,66,195,177,113,200,45,28,180,0,189,235,148,147,54,138,55,129,255,197,53,187,0,246,160,217,150,21,200,141,121,226,141,85,122,72,247,96,179,133,250,121,18,229,145,132,111,86,40,105,172,118,164,219,233,179,235,96,12,11,157,1,61,46,36,52,182,85,50,76,216,251,106,16,211,181,246,147,69,149,169,181,18,163,249,17,16,44,136,248,39,240,61,90,188,185,190,199,161,230,3,229,149,8,244,152,163,154,225,217,195,150,73,135,24,51,146,123,132,109,122,168,132,25,177,163,151,214,216,108,239,90,145,199,255,134,108,200,58,183,77,15,114,42,183,102,137,74,105,91,59,117,63,14,61,136,66,161,235,228,7,71,7,115,126,20,78,174,74,132,113,114,3,160,94,222,53,240,175,12,208,192,132,71,116,205,133,203,243,42,129,80,139,59,83,110,88,85,202,241,23,53,63,33,100,51,194,66,145,211,129,187,212,183,180,63,234,90,183,29,215,75,107,114,15,131,128,71,222,95,248,207,38,227,26,2,0,0 };
			return method;
		}

		protected override SchemaMethod CreateUpdatePrimaryAmountsMethod() {
			SchemaMethod method = base.CreateUpdatePrimaryAmountsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,240,75,77,77,9,74,77,78,204,73,14,40,202,204,77,44,170,12,75,204,41,77,45,214,172,230,229,226,76,74,44,78,213,11,45,72,73,44,73,133,74,58,230,230,151,230,149,20,107,104,90,243,114,213,2,0,89,182,162,134,63,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OrderProduct_Passport_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4547464f-6398-4743-8f75-d961a687af23"));
		}

		#endregion

	}

	#endregion

}

