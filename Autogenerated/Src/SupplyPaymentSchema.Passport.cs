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

	#region Class: SupplyPaymentSchema

	/// <exclude/>
	[IsVirtual]
	public class SupplyPaymentSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SupplyPaymentSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SupplyPaymentSchema(SupplyPaymentSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SupplyPaymentSchema(SupplyPaymentSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("980a8f16-f64b-4446-8894-4637063d3818");
			RealUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818");
			Name = "SupplyPayment";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("f5e69141-5900-4800-93b7-6c06ca1e991d")) == null) {
				Columns.Add(CreatePositionColumn());
			}
			if (Columns.FindByUId(new Guid("dd703360-9b62-47fe-abb5-2f3ff6a57911")) == null) {
				Columns.Add(CreateTypeColumn());
			}
			if (Columns.FindByUId(new Guid("a3d987f5-d9a8-4016-b260-ee47be3c60b8")) == null) {
				Columns.Add(CreateDelayTypeColumn());
			}
			if (Columns.FindByUId(new Guid("e361f1d8-b6cb-47f5-9496-6347f6499848")) == null) {
				Columns.Add(CreateDelayColumn());
			}
			if (Columns.FindByUId(new Guid("c28a0bba-c826-48dd-8a58-0b80b4f55dee")) == null) {
				Columns.Add(CreatePercentageColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818");
			column.CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818");
			column.CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818");
			column.CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818");
			column.CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818");
			column.CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818");
			column.CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d");
			return column;
		}

		protected virtual EntitySchemaColumn CreatePositionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("f5e69141-5900-4800-93b7-6c06ca1e991d"),
				Name = @"Position",
				CreatedInSchemaUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818"),
				ModifiedInSchemaUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818"),
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d")
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("dd703360-9b62-47fe-abb5-2f3ff6a57911"),
				Name = @"Type",
				ReferenceSchemaUId = new Guid("f9876301-ffbc-4389-a53a-19413e3bd091"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818"),
				ModifiedInSchemaUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818"),
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateDelayTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a3d987f5-d9a8-4016-b260-ee47be3c60b8"),
				Name = @"DelayType",
				ReferenceSchemaUId = new Guid("180c1fb4-d61b-4aca-b6b3-e1fae4eaab1b"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818"),
				ModifiedInSchemaUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818"),
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateDelayColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("e361f1d8-b6cb-47f5-9496-6347f6499848"),
				Name = @"Delay",
				CreatedInSchemaUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818"),
				ModifiedInSchemaUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818"),
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d")
			};
		}

		protected virtual EntitySchemaColumn CreatePercentageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("c28a0bba-c826-48dd-8a58-0b80b4f55dee"),
				Name = @"Percentage",
				CreatedInSchemaUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818"),
				ModifiedInSchemaUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818"),
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSupplyPaymentEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSupplyPaymentEventsProcessSchema() {
			var schema = new SupplyPaymentEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SupplyPayment(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SupplyPayment_PassportEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SupplyPaymentSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SupplyPaymentSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("980a8f16-f64b-4446-8894-4637063d3818"));
		}

		#endregion

	}

	#endregion

	#region Class: SupplyPayment

	/// <summary>
	/// Installment plan.
	/// </summary>
	public class SupplyPayment : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SupplyPayment(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SupplyPayment";
		}

		public SupplyPayment(SupplyPayment source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Position.
		/// </summary>
		public int Position {
			get {
				return GetTypedColumnValue<int>("Position");
			}
			set {
				SetColumnValue("Position", value);
			}
		}

		/// <exclude/>
		public Guid TypeId {
			get {
				return GetTypedColumnValue<Guid>("TypeId");
			}
			set {
				SetColumnValue("TypeId", value);
				_type = null;
			}
		}

		/// <exclude/>
		public string TypeName {
			get {
				return GetTypedColumnValue<string>("TypeName");
			}
			set {
				SetColumnValue("TypeName", value);
				if (_type != null) {
					_type.Name = value;
				}
			}
		}

		private SupplyPaymentType _type;
		/// <summary>
		/// Type.
		/// </summary>
		public SupplyPaymentType Type {
			get {
				return _type ??
					(_type = LookupColumnEntities.GetEntity("Type") as SupplyPaymentType);
			}
		}

		/// <exclude/>
		public Guid DelayTypeId {
			get {
				return GetTypedColumnValue<Guid>("DelayTypeId");
			}
			set {
				SetColumnValue("DelayTypeId", value);
				_delayType = null;
			}
		}

		/// <exclude/>
		public string DelayTypeName {
			get {
				return GetTypedColumnValue<string>("DelayTypeName");
			}
			set {
				SetColumnValue("DelayTypeName", value);
				if (_delayType != null) {
					_delayType.Name = value;
				}
			}
		}

		private SupplyPaymentDelay _delayType;
		/// <summary>
		/// Deferment type.
		/// </summary>
		public SupplyPaymentDelay DelayType {
			get {
				return _delayType ??
					(_delayType = LookupColumnEntities.GetEntity("DelayType") as SupplyPaymentDelay);
			}
		}

		/// <summary>
		/// Deferment (days).
		/// </summary>
		public int Delay {
			get {
				return GetTypedColumnValue<int>("Delay");
			}
			set {
				SetColumnValue("Delay", value);
			}
		}

		/// <summary>
		/// Percentage, %.
		/// </summary>
		public Decimal Percentage {
			get {
				return GetTypedColumnValue<Decimal>("Percentage");
			}
			set {
				SetColumnValue("Percentage", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SupplyPayment_PassportEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SupplyPaymentDeleted", e);
			Inserting += (s, e) => ThrowEvent("SupplyPaymentInserting", e);
			Saving += (s, e) => ThrowEvent("SupplyPaymentSaving", e);
			Validating += (s, e) => ThrowEvent("SupplyPaymentValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SupplyPayment(this);
		}

		#endregion

	}

	#endregion

	#region Class: SupplyPayment_PassportEventsProcess

	/// <exclude/>
	public partial class SupplyPayment_PassportEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SupplyPayment
	{

		public SupplyPayment_PassportEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SupplyPayment_PassportEventsProcess";
			SchemaUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("980a8f16-f64b-4446-8894-4637063d3818");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual bool DoNotCheckCascadeCycle {
			get;
			set;
		}

		private ProcessFlowElement _onSupplyPaymentSavingEventSubProcess;
		public ProcessFlowElement OnSupplyPaymentSavingEventSubProcess {
			get {
				return _onSupplyPaymentSavingEventSubProcess ?? (_onSupplyPaymentSavingEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "OnSupplyPaymentSavingEventSubProcess",
					SchemaElementUId = new Guid("5cf8d3ae-a936-43bc-a753-5d895895e2de"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _supplyPaymentSavingStartMessage;
		public ProcessFlowElement SupplyPaymentSavingStartMessage {
			get {
				return _supplyPaymentSavingStartMessage ?? (_supplyPaymentSavingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SupplyPaymentSavingStartMessage",
					SchemaElementUId = new Guid("f1cc00e9-781c-437b-bd55-068f34f3a2e7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _supplyPaymentOnSavingScriptTask;
		public ProcessScriptTask SupplyPaymentOnSavingScriptTask {
			get {
				return _supplyPaymentOnSavingScriptTask ?? (_supplyPaymentOnSavingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SupplyPaymentOnSavingScriptTask",
					SchemaElementUId = new Guid("e5817a4b-e1d9-4a6c-8018-13b6cc4d3413"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SupplyPaymentOnSavingScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[OnSupplyPaymentSavingEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { OnSupplyPaymentSavingEventSubProcess };
			FlowElements[SupplyPaymentSavingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SupplyPaymentSavingStartMessage };
			FlowElements[SupplyPaymentOnSavingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SupplyPaymentOnSavingScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "OnSupplyPaymentSavingEventSubProcess":
						break;
					case "SupplyPaymentSavingStartMessage":
						e.Context.QueueTasks.Enqueue("SupplyPaymentOnSavingScriptTask");
						break;
					case "SupplyPaymentOnSavingScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("SupplyPaymentSavingStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "OnSupplyPaymentSavingEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "SupplyPaymentSavingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SupplyPaymentSavingStartMessage";
					result = SupplyPaymentSavingStartMessage.Execute(context);
					break;
				case "SupplyPaymentOnSavingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SupplyPaymentOnSavingScriptTask";
					result = SupplyPaymentOnSavingScriptTask.Execute(context, SupplyPaymentOnSavingScriptTaskExecute);
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
				case "DoNotCheckCascadeCycle":
					DoNotCheckCascadeCycle = reader.GetValue<System.Boolean>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool SupplyPaymentOnSavingScriptTaskExecute(ProcessExecutingContext context) {
			CheckCascadeCycle();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "SupplyPaymentSaving":
							if (ActivatedEventElements.Contains("SupplyPaymentSavingStartMessage")) {
							context.QueueTasks.Enqueue("SupplyPaymentSavingStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("DoNotCheckCascadeCycle") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("DoNotCheckCascadeCycle", DoNotCheckCascadeCycle, false);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: SupplyPayment_PassportEventsProcess

	/// <exclude/>
	public class SupplyPayment_PassportEventsProcess : SupplyPayment_PassportEventsProcess<SupplyPayment>
	{

		public SupplyPayment_PassportEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SupplyPayment_PassportEventsProcess

	public partial class SupplyPayment_PassportEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void CheckCascadeCycle() {
			var passportHelper = ClassFactory.Get<Terrasoft.Configuration.Passport.OrderPassportHelper>(new ConstructorArgument("userConnection", UserConnection));
			passportHelper.ThrowIfFindCascadeCycle(Entity);
		}

		#endregion

	}

	#endregion

	#region Class: SupplyPaymentEventsProcessSchema

	/// <exclude/>
	public class SupplyPaymentEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SupplyPaymentEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SupplyPaymentEventsProcessSchema(SupplyPaymentEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SupplyPayment_PassportEventsProcess";
			UId = new Guid("db60083d-10e3-43cb-8693-cadea909585f");
			CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateDoNotCheckCascadeCycleParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("0f9b1a1f-f89e-473b-9251-c8135404d8e9"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db60083d-10e3-43cb-8693-cadea909585f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db60083d-10e3-43cb-8693-cadea909585f"),
				Name = @"DoNotCheckCascadeCycle",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateDoNotCheckCascadeCycleParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaSupplyPaymentLaneSet = CreateSupplyPaymentLaneSetLaneSet();
			LaneSets.Add(schemaSupplyPaymentLaneSet);
			ProcessSchemaLane schemaSupplyPaymentLane = CreateSupplyPaymentLaneLane();
			schemaSupplyPaymentLaneSet.Lanes.Add(schemaSupplyPaymentLane);
			ProcessSchemaEventSubProcess onsupplypaymentsavingeventsubprocess = CreateOnSupplyPaymentSavingEventSubProcessEventSubProcess();
			FlowElements.Add(onsupplypaymentsavingeventsubprocess);
			ProcessSchemaStartMessageEvent supplypaymentsavingstartmessage = CreateSupplyPaymentSavingStartMessageStartMessageEvent();
			onsupplypaymentsavingeventsubprocess.FlowElements.Add(supplypaymentsavingstartmessage);
			ProcessSchemaScriptTask supplypaymentonsavingscripttask = CreateSupplyPaymentOnSavingScriptTaskScriptTask();
			onsupplypaymentsavingeventsubprocess.FlowElements.Add(supplypaymentonsavingscripttask);
			FlowElements.Add(CreateSupplyPaymentSequenceFlow1SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSupplyPaymentSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SupplyPaymentSequenceFlow1",
				UId = new Guid("f34a527e-ae51-4075-8c8f-23c0fb8978c5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				CreatedInSchemaUId = new Guid("db60083d-10e3-43cb-8693-cadea909585f"),
				CurveCenterPosition = new Point(153, 98),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("db60083d-10e3-43cb-8693-cadea909585f"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f1cc00e9-781c-437b-bd55-068f34f3a2e7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e5817a4b-e1d9-4a6c-8018-13b6cc4d3413"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateSupplyPaymentLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaSupplyPaymentLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("0c3359b2-7e57-4767-9374-81ccc29c8493"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				CreatedInSchemaUId = new Guid("db60083d-10e3-43cb-8693-cadea909585f"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("db60083d-10e3-43cb-8693-cadea909585f"),
				Name = @"SupplyPaymentLaneSet",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1088, 179),
				UseBackgroundMode = false
			};
			return schemaSupplyPaymentLaneSet;
		}

		protected virtual ProcessSchemaLane CreateSupplyPaymentLaneLane() {
			ProcessSchemaLane schemaSupplyPaymentLane = new ProcessSchemaLane(this) {
				UId = new Guid("4ea050e2-7088-49e6-bbc6-38cde50f89a7"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("0c3359b2-7e57-4767-9374-81ccc29c8493"),
				CreatedInOwnerSchemaUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				CreatedInSchemaUId = new Guid("db60083d-10e3-43cb-8693-cadea909585f"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("db60083d-10e3-43cb-8693-cadea909585f"),
				Name = @"SupplyPaymentLane",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1059, 179),
				UseBackgroundMode = false
			};
			return schemaSupplyPaymentLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateOnSupplyPaymentSavingEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaOnSupplyPaymentSavingEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5cf8d3ae-a936-43bc-a753-5d895895e2de"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4ea050e2-7088-49e6-bbc6-38cde50f89a7"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				CreatedInSchemaUId = new Guid("db60083d-10e3-43cb-8693-cadea909585f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("db60083d-10e3-43cb-8693-cadea909585f"),
				Name = @"OnSupplyPaymentSavingEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(50, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(195, 156),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaOnSupplyPaymentSavingEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSupplyPaymentSavingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f1cc00e9-781c-437b-bd55-068f34f3a2e7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5cf8d3ae-a936-43bc-a753-5d895895e2de"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				CreatedInSchemaUId = new Guid("db60083d-10e3-43cb-8693-cadea909585f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SupplyPaymentSaving",
				ModifiedInSchemaUId = new Guid("db60083d-10e3-43cb-8693-cadea909585f"),
				Name = @"SupplyPaymentSavingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(7, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSupplyPaymentOnSavingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e5817a4b-e1d9-4a6c-8018-13b6cc4d3413"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5cf8d3ae-a936-43bc-a753-5d895895e2de"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				CreatedInSchemaUId = new Guid("db60083d-10e3-43cb-8693-cadea909585f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("db60083d-10e3-43cb-8693-cadea909585f"),
				Name = @"SupplyPaymentOnSavingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(84, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,206,72,77,206,118,78,44,78,78,76,73,117,174,76,206,73,213,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,2,15,76,34,34,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateCheckCascadeCycleMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("1ac96112-fb04-4624-88a4-cfff3402c464"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a")
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

		protected virtual SchemaMethod CreateCheckCascadeCycleMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2f4281b5-c8dc-40b6-ad72-41f2f1eeb9cf"),
				Name = "CheckCascadeCycle",
				CreatedInSchemaUId = new Guid("db60083d-10e3-43cb-8693-cadea909585f"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,142,65,10,194,48,16,69,247,130,119,8,93,165,32,185,64,85,144,96,213,149,93,212,3,12,233,180,6,234,164,76,38,150,222,222,22,220,100,251,254,255,143,255,5,86,19,196,56,5,150,59,142,19,178,58,41,59,174,164,6,39,129,23,115,67,57,182,200,12,49,244,98,108,160,222,15,137,65,124,32,211,252,151,230,201,29,114,147,121,206,154,112,86,107,63,10,167,77,117,225,33,125,144,68,23,41,34,175,1,161,219,44,197,65,189,50,80,150,213,126,151,159,50,237,155,195,252,232,107,79,157,133,232,160,67,187,184,17,245,149,196,203,82,86,63,104,233,207,209,200,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SupplyPaymentEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("db60083d-10e3-43cb-8693-cadea909585f"));
		}

		#endregion

	}

	#endregion


	#region Class: SupplyPaymentEventsProcess

	/// <exclude/>
	public class SupplyPaymentEventsProcess : SupplyPayment_PassportEventsProcess
	{

		public SupplyPaymentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

