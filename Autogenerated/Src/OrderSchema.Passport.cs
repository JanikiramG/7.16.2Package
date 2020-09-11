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
	using Terrasoft.Configuration;
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

	#region Class: Order_Passport_TerrasoftSchema

	/// <exclude/>
	public class Order_Passport_TerrasoftSchema : Terrasoft.Configuration.Order_Order_TerrasoftSchema
	{

		#region Constructors: Public

		public Order_Passport_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Order_Passport_TerrasoftSchema(Order_Passport_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Order_Passport_TerrasoftSchema(Order_Passport_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("f2688517-820b-4f01-9361-0ce31cc5a1d2");
			Name = "Order_Passport_Terrasoft";
			ParentSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71");
			ExtendParent = true;
			CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a");
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
			EventsProcessSchema = CreateOrder_Passport_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateOrder_Passport_TerrasoftEventsProcessSchema() {
			var schema = new Order_Passport_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Order_Passport_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Order_PassportEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Order_Passport_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Order_Passport_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f2688517-820b-4f01-9361-0ce31cc5a1d2"));
		}

		#endregion

	}

	#endregion

	#region Class: Order_Passport_Terrasoft

	/// <summary>
	/// Order.
	/// </summary>
	public class Order_Passport_Terrasoft : Terrasoft.Configuration.Order_Order_Terrasoft
	{

		#region Constructors: Public

		public Order_Passport_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Order_Passport_Terrasoft";
		}

		public Order_Passport_Terrasoft(Order_Passport_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Order_PassportEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Order_Passport_TerrasoftDeleted", e);
			Inserted += (s, e) => ThrowEvent("Order_Passport_TerrasoftInserted", e);
			Saved += (s, e) => ThrowEvent("Order_Passport_TerrasoftSaved", e);
			Validating += (s, e) => ThrowEvent("Order_Passport_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Order_Passport_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Order_PassportEventsProcess

	/// <exclude/>
	public partial class Order_PassportEventsProcess<TEntity> : Terrasoft.Configuration.Order_OrderEventsProcess<TEntity> where TEntity : Order_Passport_Terrasoft
	{

		public Order_PassportEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Order_PassportEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f2688517-820b-4f01-9361-0ce31cc5a1d2");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _passportOrderInsertedEventSubProcess;
		public ProcessFlowElement PassportOrderInsertedEventSubProcess {
			get {
				return _passportOrderInsertedEventSubProcess ?? (_passportOrderInsertedEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "PassportOrderInsertedEventSubProcess",
					SchemaElementUId = new Guid("66b3c66b-41b1-4a0f-85a2-1163185506b0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _passportOrderInsertedStartMessage;
		public ProcessFlowElement PassportOrderInsertedStartMessage {
			get {
				return _passportOrderInsertedStartMessage ?? (_passportOrderInsertedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PassportOrderInsertedStartMessage",
					SchemaElementUId = new Guid("5b3e219b-6442-427d-ac11-126c4e9845c4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _createSupplyPaymentItemsScriptTask;
		public ProcessScriptTask CreateSupplyPaymentItemsScriptTask {
			get {
				return _createSupplyPaymentItemsScriptTask ?? (_createSupplyPaymentItemsScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CreateSupplyPaymentItemsScriptTask",
					SchemaElementUId = new Guid("83042d05-8267-4714-8415-ad1468ddb281"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CreateSupplyPaymentItemsScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[PassportOrderInsertedEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { PassportOrderInsertedEventSubProcess };
			FlowElements[PassportOrderInsertedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PassportOrderInsertedStartMessage };
			FlowElements[CreateSupplyPaymentItemsScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CreateSupplyPaymentItemsScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "PassportOrderInsertedEventSubProcess":
						break;
					case "PassportOrderInsertedStartMessage":
						e.Context.QueueTasks.Enqueue("CreateSupplyPaymentItemsScriptTask");
						break;
					case "CreateSupplyPaymentItemsScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("PassportOrderInsertedStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "PassportOrderInsertedEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "PassportOrderInsertedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PassportOrderInsertedStartMessage";
					result = PassportOrderInsertedStartMessage.Execute(context);
					break;
				case "CreateSupplyPaymentItemsScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CreateSupplyPaymentItemsScriptTask";
					result = CreateSupplyPaymentItemsScriptTask.Execute(context, CreateSupplyPaymentItemsScriptTaskExecute);
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

		public virtual bool CreateSupplyPaymentItemsScriptTaskExecute(ProcessExecutingContext context) {
			CreateDefSupplyPaymentItems();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Order_Passport_TerrasoftInserted":
							if (ActivatedEventElements.Contains("PassportOrderInsertedStartMessage")) {
							context.QueueTasks.Enqueue("PassportOrderInsertedStartMessage");
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

	#region Class: Order_PassportEventsProcess

	/// <exclude/>
	public class Order_PassportEventsProcess : Order_PassportEventsProcess<Order_Passport_Terrasoft>
	{

		public Order_PassportEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Order_PassportEventsProcess

	public partial class Order_PassportEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void CreateDefSupplyPaymentItems() {
			var passportHelper = ClassFactory.Get<Terrasoft.Configuration.Passport.OrderPassportHelper>(new ConstructorArgument("userConnection", UserConnection));
			passportHelper.SetTemplate(Entity.PrimaryColumnValue);
		}

		public override void UpdateProductAmounts() {
			base.UpdateProductAmounts();
			if (NeedFinRecalc) {
				var orderAmountHelper = ClassFactory.Get<Terrasoft.Configuration.Passport.OrderAmountHelper>(new ConstructorArgument("userConnection", UserConnection));
				orderAmountHelper.UpdateAmountsByOrderId(Entity.GetTypedColumnValue<Guid>("Id"));
			}
		}

		#endregion

	}

	#endregion

	#region Class: Order_Passport_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Order_Passport_TerrasoftEventsProcessSchema : Terrasoft.Configuration.Order_Order_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public Order_Passport_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Order_Passport_TerrasoftEventsProcessSchema(Order_Passport_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Order_PassportEventsProcess";
			UId = new Guid("818540ce-f229-4caa-bde0-4a1fe1f81c5f");
			CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaPassportLaneSet = CreatePassportLaneSetLaneSet();
			LaneSets.Add(schemaPassportLaneSet);
			ProcessSchemaLane schemaPassportLane = CreatePassportLaneLane();
			schemaPassportLaneSet.Lanes.Add(schemaPassportLane);
			ProcessSchemaEventSubProcess passportorderinsertedeventsubprocess = CreatePassportOrderInsertedEventSubProcessEventSubProcess();
			FlowElements.Add(passportorderinsertedeventsubprocess);
			ProcessSchemaStartMessageEvent passportorderinsertedstartmessage = CreatePassportOrderInsertedStartMessageStartMessageEvent();
			passportorderinsertedeventsubprocess.FlowElements.Add(passportorderinsertedstartmessage);
			ProcessSchemaScriptTask createsupplypaymentitemsscripttask = CreateCreateSupplyPaymentItemsScriptTaskScriptTask();
			passportorderinsertedeventsubprocess.FlowElements.Add(createsupplypaymentitemsscripttask);
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("3659ec6c-f0e0-4bbd-802e-2a45a9bfb5a9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				CreatedInPackageId = new Guid("9fba2bd0-c350-44a0-8bb6-40ca8dca7fe5"),
				CreatedInSchemaUId = new Guid("818540ce-f229-4caa-bde0-4a1fe1f81c5f"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("818540ce-f229-4caa-bde0-4a1fe1f81c5f"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5b3e219b-6442-427d-ac11-126c4e9845c4"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("83042d05-8267-4714-8415-ad1468ddb281"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(123, 98));
			schemaFlow.PolylinePointPositions.Add(new Point(123, 96));
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreatePassportLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaPassportLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("f7f81f80-b1e1-4221-8ed1-2a46f676b808"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				CreatedInSchemaUId = new Guid("818540ce-f229-4caa-bde0-4a1fe1f81c5f"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("818540ce-f229-4caa-bde0-4a1fe1f81c5f"),
				Name = @"PassportLaneSet",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1070, 179),
				UseBackgroundMode = false
			};
			return schemaPassportLaneSet;
		}

		protected virtual ProcessSchemaLane CreatePassportLaneLane() {
			ProcessSchemaLane schemaPassportLane = new ProcessSchemaLane(this) {
				UId = new Guid("282753ab-fe0e-425d-8095-f0f906ea6eef"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("f7f81f80-b1e1-4221-8ed1-2a46f676b808"),
				CreatedInOwnerSchemaUId = new Guid("f2688517-820b-4f01-9361-0ce31cc5a1d2"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				CreatedInSchemaUId = new Guid("818540ce-f229-4caa-bde0-4a1fe1f81c5f"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("818540ce-f229-4caa-bde0-4a1fe1f81c5f"),
				Name = @"PassportLane",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1041, 179),
				UseBackgroundMode = false
			};
			return schemaPassportLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreatePassportOrderInsertedEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaPassportOrderInsertedEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("66b3c66b-41b1-4a0f-85a2-1163185506b0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("282753ab-fe0e-425d-8095-f0f906ea6eef"),
				CreatedInOwnerSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				CreatedInSchemaUId = new Guid("818540ce-f229-4caa-bde0-4a1fe1f81c5f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("818540ce-f229-4caa-bde0-4a1fe1f81c5f"),
				Name = @"PassportOrderInsertedEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(49, 20),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(204, 156),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaPassportOrderInsertedEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePassportOrderInsertedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5b3e219b-6442-427d-ac11-126c4e9845c4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("66b3c66b-41b1-4a0f-85a2-1163185506b0"),
				CreatedInOwnerSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				CreatedInSchemaUId = new Guid("818540ce-f229-4caa-bde0-4a1fe1f81c5f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OrderInserted",
				ModifiedInSchemaUId = new Guid("818540ce-f229-4caa-bde0-4a1fe1f81c5f"),
				Name = @"PassportOrderInsertedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(24, 64),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCreateSupplyPaymentItemsScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("83042d05-8267-4714-8415-ad1468ddb281"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("66b3c66b-41b1-4a0f-85a2-1163185506b0"),
				CreatedInOwnerSchemaUId = new Guid("5faa73d5-1e69-46ad-97ad-45af2ba2a37b"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				CreatedInSchemaUId = new Guid("818540ce-f229-4caa-bde0-4a1fe1f81c5f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("818540ce-f229-4caa-bde0-4a1fe1f81c5f"),
				Name = @"CreateSupplyPaymentItemsScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(98, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,46,74,77,44,73,117,73,77,11,46,45,40,200,169,12,72,172,204,77,205,43,241,44,73,205,45,214,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,237,84,71,32,44,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateCreateDefSupplyPaymentItemsMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e367e682-e0e1-481b-90fa-2080cf131acc"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c16ac00d-efc7-4f36-8327-68fce32dfe3c"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6922ed45-6469-416f-93a0-047b732a5c23"),
				Name = "Terrasoft.Configuration.Passport",
				Alias = "",
				CreatedInPackageId = new Guid("a002bd5f-14f1-4196-ac19-0a0feddeb334")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a435aadb-cccf-48cf-b82e-d0bd146a0851"),
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

		protected override SchemaMethod CreateUpdateProductAmountsMethod() {
			SchemaMethod method = base.CreateUpdateProductAmountsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,143,65,110,194,48,16,69,215,112,10,43,43,71,170,124,129,2,18,141,10,101,211,162,10,186,159,218,19,100,201,25,71,227,153,162,8,113,247,38,148,77,219,237,204,211,251,255,127,66,65,119,236,3,8,238,57,7,245,178,238,178,146,20,91,63,206,99,107,236,43,98,216,68,122,71,15,201,215,230,50,159,125,1,155,204,1,249,135,124,193,212,35,155,165,105,18,148,178,1,47,153,7,183,69,89,28,144,25,74,110,197,53,153,218,120,82,6,137,153,220,126,228,250,204,226,222,254,90,86,150,240,108,70,186,8,235,36,90,243,73,59,36,177,149,22,228,241,65,232,39,71,245,96,142,191,14,245,88,119,246,175,213,125,217,125,210,211,112,11,220,5,251,76,18,229,86,242,48,244,24,154,156,180,163,15,72,138,139,173,198,176,178,213,46,84,147,242,250,13,84,85,78,194,32,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateDefSupplyPaymentItemsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("859f39c1-fa12-48a8-beff-c0e40a4efd94"),
				Name = "CreateDefSupplyPaymentItems",
				CreatedInSchemaUId = new Guid("818540ce-f229-4caa-bde0-4a1fe1f81c5f"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,142,75,10,194,64,16,68,247,130,119,24,178,74,64,230,2,81,65,130,159,157,1,163,251,38,118,194,192,252,168,233,81,114,123,19,112,147,237,171,170,71,125,8,42,82,74,49,64,110,108,35,67,29,84,99,103,114,161,94,2,38,125,101,217,119,12,80,10,131,232,38,248,193,140,25,36,38,120,221,254,151,250,142,55,163,93,121,142,165,231,175,154,251,73,144,23,213,9,99,118,236,165,44,114,98,204,129,231,126,177,20,59,245,92,129,170,170,183,155,245,41,253,96,233,216,69,75,194,229,217,139,145,73,183,48,142,48,53,193,102,231,95,100,51,87,245,15,27,121,243,85,207,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Order_Passport_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("818540ce-f229-4caa-bde0-4a1fe1f81c5f"));
		}

		#endregion

	}

	#endregion

}

