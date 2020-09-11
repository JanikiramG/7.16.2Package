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

	#region Class: PRMTransaction_PRMBase_TerrasoftSchema

	/// <exclude/>
	public class PRMTransaction_PRMBase_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public PRMTransaction_PRMBase_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public PRMTransaction_PRMBase_TerrasoftSchema(PRMTransaction_PRMBase_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public PRMTransaction_PRMBase_TerrasoftSchema(PRMTransaction_PRMBase_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3fd4e44d-f373-4dea-8263-6bcfb3f64d26");
			RealUId = new Guid("3fd4e44d-f373-4dea-8263-6bcfb3f64d26");
			Name = "PRMTransaction_PRMBase_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("e3f6af0f-4ac0-46d1-b2e6-e18d10bd5c8e");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("5f2fbe25-b461-458b-90cc-f306506a7b24")) == null) {
				Columns.Add(CreateAmountColumn());
			}
			if (Columns.FindByUId(new Guid("64288f0c-505b-466c-98d2-ab5cadbd6f0c")) == null) {
				Columns.Add(CreateDateColumn());
			}
			if (Columns.FindByUId(new Guid("4243678b-b970-429d-94d2-70f7b5888882")) == null) {
				Columns.Add(CreateRecordIdColumn());
			}
			if (Columns.FindByUId(new Guid("d21c3641-3022-44c4-9a79-34df75905602")) == null) {
				Columns.Add(CreateEntityIdColumn());
			}
			if (Columns.FindByUId(new Guid("1a4672d4-ea8a-4ecc-9d96-afe7fcf6dd42")) == null) {
				Columns.Add(CreateDescriptionColumn());
			}
			if (Columns.FindByUId(new Guid("f5c3767a-15e0-4e59-8252-165a7f19d80e")) == null) {
				Columns.Add(CreateFundColumn());
			}
			if (Columns.FindByUId(new Guid("50b2e5f6-9b51-4954-9f99-3571ebbed2c1")) == null) {
				Columns.Add(CreatePartnershipColumn());
			}
			if (Columns.FindByUId(new Guid("101f0411-c552-42d7-aada-843a28e74f5a")) == null) {
				Columns.Add(CreateTransactionTypeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("5f2fbe25-b461-458b-90cc-f306506a7b24"),
				Name = @"Amount",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("3fd4e44d-f373-4dea-8263-6bcfb3f64d26"),
				ModifiedInSchemaUId = new Guid("3fd4e44d-f373-4dea-8263-6bcfb3f64d26"),
				CreatedInPackageId = new Guid("e3f6af0f-4ac0-46d1-b2e6-e18d10bd5c8e")
			};
		}

		protected virtual EntitySchemaColumn CreateDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("64288f0c-505b-466c-98d2-ab5cadbd6f0c"),
				Name = @"Date",
				CreatedInSchemaUId = new Guid("3fd4e44d-f373-4dea-8263-6bcfb3f64d26"),
				ModifiedInSchemaUId = new Guid("3fd4e44d-f373-4dea-8263-6bcfb3f64d26"),
				CreatedInPackageId = new Guid("e3f6af0f-4ac0-46d1-b2e6-e18d10bd5c8e"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentDateTime")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateRecordIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("4243678b-b970-429d-94d2-70f7b5888882"),
				Name = @"RecordId",
				CreatedInSchemaUId = new Guid("3fd4e44d-f373-4dea-8263-6bcfb3f64d26"),
				ModifiedInSchemaUId = new Guid("3fd4e44d-f373-4dea-8263-6bcfb3f64d26"),
				CreatedInPackageId = new Guid("e3f6af0f-4ac0-46d1-b2e6-e18d10bd5c8e")
			};
		}

		protected virtual EntitySchemaColumn CreateEntityIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("d21c3641-3022-44c4-9a79-34df75905602"),
				Name = @"EntityId",
				CreatedInSchemaUId = new Guid("3fd4e44d-f373-4dea-8263-6bcfb3f64d26"),
				ModifiedInSchemaUId = new Guid("3fd4e44d-f373-4dea-8263-6bcfb3f64d26"),
				CreatedInPackageId = new Guid("e3f6af0f-4ac0-46d1-b2e6-e18d10bd5c8e")
			};
		}

		protected virtual EntitySchemaColumn CreateDescriptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("1a4672d4-ea8a-4ecc-9d96-afe7fcf6dd42"),
				Name = @"Description",
				CreatedInSchemaUId = new Guid("3fd4e44d-f373-4dea-8263-6bcfb3f64d26"),
				ModifiedInSchemaUId = new Guid("3fd4e44d-f373-4dea-8263-6bcfb3f64d26"),
				CreatedInPackageId = new Guid("e3f6af0f-4ac0-46d1-b2e6-e18d10bd5c8e")
			};
		}

		protected virtual EntitySchemaColumn CreateFundColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f5c3767a-15e0-4e59-8252-165a7f19d80e"),
				Name = @"Fund",
				ReferenceSchemaUId = new Guid("9a734110-378e-4108-9383-726930984f2e"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("3fd4e44d-f373-4dea-8263-6bcfb3f64d26"),
				ModifiedInSchemaUId = new Guid("3fd4e44d-f373-4dea-8263-6bcfb3f64d26"),
				CreatedInPackageId = new Guid("e3f6af0f-4ac0-46d1-b2e6-e18d10bd5c8e")
			};
		}

		protected virtual EntitySchemaColumn CreatePartnershipColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("50b2e5f6-9b51-4954-9f99-3571ebbed2c1"),
				Name = @"Partnership",
				ReferenceSchemaUId = new Guid("f247949a-7c07-4fc7-9a6a-31940b457e5d"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("3fd4e44d-f373-4dea-8263-6bcfb3f64d26"),
				ModifiedInSchemaUId = new Guid("3fd4e44d-f373-4dea-8263-6bcfb3f64d26"),
				CreatedInPackageId = new Guid("1b540174-2dfe-4dee-ae21-9985404549f1")
			};
		}

		protected virtual EntitySchemaColumn CreateTransactionTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("101f0411-c552-42d7-aada-843a28e74f5a"),
				Name = @"TransactionType",
				ReferenceSchemaUId = new Guid("49361e32-f6a5-4eb0-b0b2-7e13b1e2ed30"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("3fd4e44d-f373-4dea-8263-6bcfb3f64d26"),
				ModifiedInSchemaUId = new Guid("3fd4e44d-f373-4dea-8263-6bcfb3f64d26"),
				CreatedInPackageId = new Guid("f43a6760-9275-4070-90a5-eacccad59d8c")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreatePRMTransaction_PRMBase_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreatePRMTransaction_PRMBase_TerrasoftEventsProcessSchema() {
			var schema = new PRMTransaction_PRMBase_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new PRMTransaction_PRMBase_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new PRMTransaction_PRMBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new PRMTransaction_PRMBase_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new PRMTransaction_PRMBase_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3fd4e44d-f373-4dea-8263-6bcfb3f64d26"));
		}

		#endregion

	}

	#endregion

	#region Class: PRMTransaction_PRMBase_Terrasoft

	/// <summary>
	/// Cashflows.
	/// </summary>
	public class PRMTransaction_PRMBase_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public PRMTransaction_PRMBase_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "PRMTransaction_PRMBase_Terrasoft";
		}

		public PRMTransaction_PRMBase_Terrasoft(PRMTransaction_PRMBase_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Amount.
		/// </summary>
		public Decimal Amount {
			get {
				return GetTypedColumnValue<Decimal>("Amount");
			}
			set {
				SetColumnValue("Amount", value);
			}
		}

		/// <summary>
		/// Date.
		/// </summary>
		public DateTime Date {
			get {
				return GetTypedColumnValue<DateTime>("Date");
			}
			set {
				SetColumnValue("Date", value);
			}
		}

		/// <summary>
		/// Record identifier.
		/// </summary>
		public Guid RecordId {
			get {
				return GetTypedColumnValue<Guid>("RecordId");
			}
			set {
				SetColumnValue("RecordId", value);
			}
		}

		/// <summary>
		/// Entity identifier.
		/// </summary>
		public Guid EntityId {
			get {
				return GetTypedColumnValue<Guid>("EntityId");
			}
			set {
				SetColumnValue("EntityId", value);
			}
		}

		/// <summary>
		/// Description.
		/// </summary>
		public string Description {
			get {
				return GetTypedColumnValue<string>("Description");
			}
			set {
				SetColumnValue("Description", value);
			}
		}

		/// <exclude/>
		public Guid FundId {
			get {
				return GetTypedColumnValue<Guid>("FundId");
			}
			set {
				SetColumnValue("FundId", value);
				_fund = null;
			}
		}

		/// <exclude/>
		public string FundName {
			get {
				return GetTypedColumnValue<string>("FundName");
			}
			set {
				SetColumnValue("FundName", value);
				if (_fund != null) {
					_fund.Name = value;
				}
			}
		}

		private Fund _fund;
		/// <summary>
		/// Fund.
		/// </summary>
		public Fund Fund {
			get {
				return _fund ??
					(_fund = LookupColumnEntities.GetEntity("Fund") as Fund);
			}
		}

		/// <exclude/>
		public Guid PartnershipId {
			get {
				return GetTypedColumnValue<Guid>("PartnershipId");
			}
			set {
				SetColumnValue("PartnershipId", value);
				_partnership = null;
			}
		}

		/// <exclude/>
		public string PartnershipName {
			get {
				return GetTypedColumnValue<string>("PartnershipName");
			}
			set {
				SetColumnValue("PartnershipName", value);
				if (_partnership != null) {
					_partnership.Name = value;
				}
			}
		}

		private Partnership _partnership;
		/// <summary>
		/// Partnership.
		/// </summary>
		public Partnership Partnership {
			get {
				return _partnership ??
					(_partnership = LookupColumnEntities.GetEntity("Partnership") as Partnership);
			}
		}

		/// <exclude/>
		public Guid TransactionTypeId {
			get {
				return GetTypedColumnValue<Guid>("TransactionTypeId");
			}
			set {
				SetColumnValue("TransactionTypeId", value);
				_transactionType = null;
			}
		}

		/// <exclude/>
		public string TransactionTypeName {
			get {
				return GetTypedColumnValue<string>("TransactionTypeName");
			}
			set {
				SetColumnValue("TransactionTypeName", value);
				if (_transactionType != null) {
					_transactionType.Name = value;
				}
			}
		}

		private PRMTransactionType _transactionType;
		/// <summary>
		/// Type.
		/// </summary>
		public PRMTransactionType TransactionType {
			get {
				return _transactionType ??
					(_transactionType = LookupColumnEntities.GetEntity("TransactionType") as PRMTransactionType);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new PRMTransaction_PRMBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("PRMTransaction_PRMBase_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("PRMTransaction_PRMBase_TerrasoftDeleting", e);
			Inserting += (s, e) => ThrowEvent("PRMTransaction_PRMBase_TerrasoftInserting", e);
			Validating += (s, e) => ThrowEvent("PRMTransaction_PRMBase_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new PRMTransaction_PRMBase_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: PRMTransaction_PRMBaseEventsProcess

	/// <exclude/>
	public partial class PRMTransaction_PRMBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : PRMTransaction_PRMBase_Terrasoft
	{

		public PRMTransaction_PRMBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "PRMTransaction_PRMBaseEventsProcess";
			SchemaUId = new Guid("3fd4e44d-f373-4dea-8263-6bcfb3f64d26");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("3fd4e44d-f373-4dea-8263-6bcfb3f64d26");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _pRMTransactionInsertingEventSubProcess;
		public ProcessFlowElement PRMTransactionInsertingEventSubProcess {
			get {
				return _pRMTransactionInsertingEventSubProcess ?? (_pRMTransactionInsertingEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "PRMTransactionInsertingEventSubProcess",
					SchemaElementUId = new Guid("716b39c0-c5c1-4fe0-a532-6b7a1b404ad7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _pRMTransactionInsertingScriptTask;
		public ProcessScriptTask PRMTransactionInsertingScriptTask {
			get {
				return _pRMTransactionInsertingScriptTask ?? (_pRMTransactionInsertingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PRMTransactionInsertingScriptTask",
					SchemaElementUId = new Guid("648688a0-bb91-4abe-97d8-273af32e5130"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PRMTransactionInsertingScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _pRMTransactionInsertingStartMessage;
		public ProcessFlowElement PRMTransactionInsertingStartMessage {
			get {
				return _pRMTransactionInsertingStartMessage ?? (_pRMTransactionInsertingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PRMTransactionInsertingStartMessage",
					SchemaElementUId = new Guid("cc8805a5-d83a-48b0-806e-f14c52b8202c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pRMTransactionDeletingEventSubProcess;
		public ProcessFlowElement PRMTransactionDeletingEventSubProcess {
			get {
				return _pRMTransactionDeletingEventSubProcess ?? (_pRMTransactionDeletingEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "PRMTransactionDeletingEventSubProcess",
					SchemaElementUId = new Guid("a7837f4b-403e-4655-8457-3b0cef567271"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pRMTransactionDeletingStartMessage;
		public ProcessFlowElement PRMTransactionDeletingStartMessage {
			get {
				return _pRMTransactionDeletingStartMessage ?? (_pRMTransactionDeletingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PRMTransactionDeletingStartMessage",
					SchemaElementUId = new Guid("b10c2a6e-bf03-47ba-baef-582ce20271db"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _pRMTransactionDeletingScriptTask;
		public ProcessScriptTask PRMTransactionDeletingScriptTask {
			get {
				return _pRMTransactionDeletingScriptTask ?? (_pRMTransactionDeletingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PRMTransactionDeletingScriptTask",
					SchemaElementUId = new Guid("59ce3af1-8c73-4cdd-b777-299fae5fc397"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PRMTransactionDeletingScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[PRMTransactionInsertingEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { PRMTransactionInsertingEventSubProcess };
			FlowElements[PRMTransactionInsertingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PRMTransactionInsertingScriptTask };
			FlowElements[PRMTransactionInsertingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PRMTransactionInsertingStartMessage };
			FlowElements[PRMTransactionDeletingEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { PRMTransactionDeletingEventSubProcess };
			FlowElements[PRMTransactionDeletingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PRMTransactionDeletingStartMessage };
			FlowElements[PRMTransactionDeletingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PRMTransactionDeletingScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "PRMTransactionInsertingEventSubProcess":
						break;
					case "PRMTransactionInsertingScriptTask":
						break;
					case "PRMTransactionInsertingStartMessage":
						e.Context.QueueTasks.Enqueue("PRMTransactionInsertingScriptTask");
						break;
					case "PRMTransactionDeletingEventSubProcess":
						break;
					case "PRMTransactionDeletingStartMessage":
						e.Context.QueueTasks.Enqueue("PRMTransactionDeletingScriptTask");
						break;
					case "PRMTransactionDeletingScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("PRMTransactionInsertingStartMessage");
			ActivatedEventElements.Add("PRMTransactionDeletingStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "PRMTransactionInsertingEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "PRMTransactionInsertingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PRMTransactionInsertingScriptTask";
					result = PRMTransactionInsertingScriptTask.Execute(context, PRMTransactionInsertingScriptTaskExecute);
					break;
				case "PRMTransactionInsertingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PRMTransactionInsertingStartMessage";
					result = PRMTransactionInsertingStartMessage.Execute(context);
					break;
				case "PRMTransactionDeletingEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "PRMTransactionDeletingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PRMTransactionDeletingStartMessage";
					result = PRMTransactionDeletingStartMessage.Execute(context);
					break;
				case "PRMTransactionDeletingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PRMTransactionDeletingScriptTask";
					result = PRMTransactionDeletingScriptTask.Execute(context, PRMTransactionDeletingScriptTaskExecute);
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

		public virtual bool PRMTransactionInsertingScriptTaskExecute(ProcessExecutingContext context) {
			if (UserConnection.GetIsFeatureEnabled("SyncOppWithFund")) {
				OnTransactionInserting();
			}
			return true;
		}

		public virtual bool PRMTransactionDeletingScriptTaskExecute(ProcessExecutingContext context) {
			if (UserConnection.GetIsFeatureEnabled("SyncOppWithFund")) {
				OnTransactionDeleting();
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PRMTransaction_PRMBase_TerrasoftInserting":
							if (ActivatedEventElements.Contains("PRMTransactionInsertingStartMessage")) {
							context.QueueTasks.Enqueue("PRMTransactionInsertingStartMessage");
						}
						break;
					case "PRMTransaction_PRMBase_TerrasoftDeleting":
							if (ActivatedEventElements.Contains("PRMTransactionDeletingStartMessage")) {
							context.QueueTasks.Enqueue("PRMTransactionDeletingStartMessage");
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

	#region Class: PRMTransaction_PRMBaseEventsProcess

	/// <exclude/>
	public class PRMTransaction_PRMBaseEventsProcess : PRMTransaction_PRMBaseEventsProcess<PRMTransaction_PRMBase_Terrasoft>
	{

		public PRMTransaction_PRMBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: PRMTransaction_PRMBaseEventsProcess

	public partial class PRMTransaction_PRMBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void UpdateFundAmount(double transactionAmount) {
			Guid fundId = Entity.GetTypedColumnValue<Guid>("FundId");
			EntitySchema fundSchema = UserConnection.EntitySchemaManager.GetInstanceByName("Fund");
			Entity fundEntity = fundSchema.CreateEntity(UserConnection);
			fundEntity.UseAdminRights = false;
			if (!fundEntity.FetchFromDB(fundId)) {
				return;
			}
			double fundAmount = fundEntity.GetTypedColumnValue<double>("Amount");
			fundEntity.SetColumnValue("Amount", fundAmount + transactionAmount);
			fundEntity.Save();
		}

		public virtual void OnTransactionInserting() {
			Guid typeId = Entity.GetTypedColumnValue<Guid>("TransactionTypeId");
			double transactionAmount = Entity.GetTypedColumnValue<double>("Amount");
			if (typeId == null) {
				return;
			}
			if (Guid.Equals(PRMBaseConstants.CreditTransactionType, typeId)) {
				transactionAmount = Math.Abs(transactionAmount);
			}
			if (Guid.Equals(PRMBaseConstants.DebitTransactionType, typeId)) {
				transactionAmount = -1 * Math.Abs(transactionAmount);
			}
			Entity.SetColumnValue("Amount", transactionAmount);
			UpdateFundAmount(transactionAmount);
		}

		public virtual void OnTransactionDeleting() {
			Guid typeId = Entity.GetTypedColumnValue<Guid>("TransactionTypeId");
			double transactionAmount = Entity.GetTypedColumnValue<double>("Amount");
			if (typeId == null) {
				return;
			}
			if (Guid.Equals(PRMBaseConstants.CreditTransactionType, typeId)) {
				transactionAmount = -1 * Math.Abs(transactionAmount);
			}
			if (Guid.Equals(PRMBaseConstants.DebitTransactionType, typeId)) {
				transactionAmount = Math.Abs(transactionAmount);
			}
			UpdateFundAmount(transactionAmount);
		}

		#endregion

	}

	#endregion

	#region Class: PRMTransaction_PRMBase_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class PRMTransaction_PRMBase_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public PRMTransaction_PRMBase_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public PRMTransaction_PRMBase_TerrasoftEventsProcessSchema(PRMTransaction_PRMBase_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "PRMTransaction_PRMBaseEventsProcess";
			UId = new Guid("9552baed-3ff9-4e81-bb39-5af02d90244e");
			CreatedInPackageId = new Guid("e3f6af0f-4ac0-46d1-b2e6-e18d10bd5c8e");
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

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess prmtransactioninsertingeventsubprocess = CreatePRMTransactionInsertingEventSubProcessEventSubProcess();
			FlowElements.Add(prmtransactioninsertingeventsubprocess);
			ProcessSchemaEventSubProcess prmtransactiondeletingeventsubprocess = CreatePRMTransactionDeletingEventSubProcessEventSubProcess();
			FlowElements.Add(prmtransactiondeletingeventsubprocess);
			ProcessSchemaScriptTask prmtransactioninsertingscripttask = CreatePRMTransactionInsertingScriptTaskScriptTask();
			prmtransactioninsertingeventsubprocess.FlowElements.Add(prmtransactioninsertingscripttask);
			ProcessSchemaStartMessageEvent prmtransactioninsertingstartmessage = CreatePRMTransactionInsertingStartMessageStartMessageEvent();
			prmtransactioninsertingeventsubprocess.FlowElements.Add(prmtransactioninsertingstartmessage);
			ProcessSchemaStartMessageEvent prmtransactiondeletingstartmessage = CreatePRMTransactionDeletingStartMessageStartMessageEvent();
			prmtransactiondeletingeventsubprocess.FlowElements.Add(prmtransactiondeletingstartmessage);
			ProcessSchemaScriptTask prmtransactiondeletingscripttask = CreatePRMTransactionDeletingScriptTaskScriptTask();
			prmtransactiondeletingeventsubprocess.FlowElements.Add(prmtransactiondeletingscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("87d90e39-64d6-4a58-88f5-548fd363fade"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e3f6af0f-4ac0-46d1-b2e6-e18d10bd5c8e"),
				CreatedInSchemaUId = new Guid("9552baed-3ff9-4e81-bb39-5af02d90244e"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("9552baed-3ff9-4e81-bb39-5af02d90244e"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cc8805a5-d83a-48b0-806e-f14c52b8202c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("648688a0-bb91-4abe-97d8-273af32e5130"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("3944ae4f-138a-4d93-b679-6e17ed14d5fa"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e3f6af0f-4ac0-46d1-b2e6-e18d10bd5c8e"),
				CreatedInSchemaUId = new Guid("9552baed-3ff9-4e81-bb39-5af02d90244e"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("9552baed-3ff9-4e81-bb39-5af02d90244e"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b10c2a6e-bf03-47ba-baef-582ce20271db"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("59ce3af1-8c73-4cdd-b777-299fae5fc397"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("169c6f5d-4f12-4f4e-bb3a-6fdd40c711cf"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e3f6af0f-4ac0-46d1-b2e6-e18d10bd5c8e"),
				CreatedInSchemaUId = new Guid("9552baed-3ff9-4e81-bb39-5af02d90244e"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("9552baed-3ff9-4e81-bb39-5af02d90244e"),
				Name = @"LaneSet1",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("77ca8132-d513-4801-8a3c-b06564d4a857"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("169c6f5d-4f12-4f4e-bb3a-6fdd40c711cf"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("e3f6af0f-4ac0-46d1-b2e6-e18d10bd5c8e"),
				CreatedInSchemaUId = new Guid("9552baed-3ff9-4e81-bb39-5af02d90244e"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("9552baed-3ff9-4e81-bb39-5af02d90244e"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreatePRMTransactionInsertingEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaPRMTransactionInsertingEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("716b39c0-c5c1-4fe0-a532-6b7a1b404ad7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("77ca8132-d513-4801-8a3c-b06564d4a857"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e3f6af0f-4ac0-46d1-b2e6-e18d10bd5c8e"),
				CreatedInSchemaUId = new Guid("9552baed-3ff9-4e81-bb39-5af02d90244e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("9552baed-3ff9-4e81-bb39-5af02d90244e"),
				Name = @"PRMTransactionInsertingEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(74, 80),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(305, 300),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaPRMTransactionInsertingEventSubProcess;
		}

		protected virtual ProcessSchemaScriptTask CreatePRMTransactionInsertingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("648688a0-bb91-4abe-97d8-273af32e5130"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("716b39c0-c5c1-4fe0-a532-6b7a1b404ad7"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e3f6af0f-4ac0-46d1-b2e6-e18d10bd5c8e"),
				CreatedInSchemaUId = new Guid("9552baed-3ff9-4e81-bb39-5af02d90244e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("9552baed-3ff9-4e81-bb39-5af02d90244e"),
				Name = @"PRMTransactionInsertingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(162, 122),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,8,45,78,45,114,206,207,203,75,77,46,201,204,207,211,115,79,45,241,44,118,75,77,44,41,45,74,117,205,75,76,202,73,77,209,80,10,174,204,75,246,47,40,8,207,44,201,112,43,205,75,81,210,212,84,168,230,226,244,207,11,41,74,204,43,78,4,107,244,204,3,154,83,146,153,151,174,161,105,205,85,203,85,148,10,52,32,79,161,164,168,52,213,26,0,74,157,105,195,102,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePRMTransactionInsertingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("cc8805a5-d83a-48b0-806e-f14c52b8202c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("716b39c0-c5c1-4fe0-a532-6b7a1b404ad7"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e3f6af0f-4ac0-46d1-b2e6-e18d10bd5c8e"),
				CreatedInSchemaUId = new Guid("9552baed-3ff9-4e81-bb39-5af02d90244e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PRMTransactionInserting",
				ModifiedInSchemaUId = new Guid("9552baed-3ff9-4e81-bb39-5af02d90244e"),
				Name = @"PRMTransactionInsertingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(65, 136),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreatePRMTransactionDeletingEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaPRMTransactionDeletingEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a7837f4b-403e-4655-8457-3b0cef567271"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("77ca8132-d513-4801-8a3c-b06564d4a857"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e3f6af0f-4ac0-46d1-b2e6-e18d10bd5c8e"),
				CreatedInSchemaUId = new Guid("9552baed-3ff9-4e81-bb39-5af02d90244e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("9552baed-3ff9-4e81-bb39-5af02d90244e"),
				Name = @"PRMTransactionDeletingEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(76, 400),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(300, 300),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaPRMTransactionDeletingEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePRMTransactionDeletingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b10c2a6e-bf03-47ba-baef-582ce20271db"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a7837f4b-403e-4655-8457-3b0cef567271"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e3f6af0f-4ac0-46d1-b2e6-e18d10bd5c8e"),
				CreatedInSchemaUId = new Guid("9552baed-3ff9-4e81-bb39-5af02d90244e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PRMTransactionDeleting",
				ModifiedInSchemaUId = new Guid("9552baed-3ff9-4e81-bb39-5af02d90244e"),
				Name = @"PRMTransactionDeletingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(49, 122),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePRMTransactionDeletingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("59ce3af1-8c73-4cdd-b777-299fae5fc397"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a7837f4b-403e-4655-8457-3b0cef567271"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e3f6af0f-4ac0-46d1-b2e6-e18d10bd5c8e"),
				CreatedInSchemaUId = new Guid("9552baed-3ff9-4e81-bb39-5af02d90244e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("9552baed-3ff9-4e81-bb39-5af02d90244e"),
				Name = @"PRMTransactionDeletingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(160, 108),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,8,45,78,45,114,206,207,203,75,77,46,201,204,207,211,115,79,45,241,44,118,75,77,44,41,45,74,117,205,75,76,202,73,77,209,80,10,174,204,75,246,47,40,8,207,44,201,112,43,205,75,81,210,212,84,168,230,226,244,207,11,41,74,204,43,78,4,107,116,73,205,73,45,201,204,75,215,208,180,230,170,229,42,74,5,234,207,83,40,41,42,77,181,6,0,58,53,251,128,101,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateUpdateFundAmountMethod());
			Methods.Add(CreateOnTransactionInsertingMethod());
			Methods.Add(CreateOnTransactionDeletingMethod());
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

		protected virtual SchemaMethod CreateUpdateFundAmountMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7771f5f4-8170-40b2-a8b4-2b07afdbab36"),
				Name = "UpdateFundAmount",
				CreatedInSchemaUId = new Guid("9552baed-3ff9-4e81-bb39-5af02d90244e"),
				CreatedInPackageId = new Guid("e3f6af0f-4ac0-46d1-b2e6-e18d10bd5c8e"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("533bf81f-6a63-48dd-be3e-37d8a421dccd"),
				Name = "transactionAmount",
				CreatedInSchemaUId = new Guid("9552baed-3ff9-4e81-bb39-5af02d90244e"),
				ModifiedInSchemaUId = new Guid("9552baed-3ff9-4e81-bb39-5af02d90244e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "double",
				CreatedInPackageId = new Guid("e3f6af0f-4ac0-46d1-b2e6-e18d10bd5c8e")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,193,78,195,48,12,134,207,244,41,178,158,90,109,234,11,148,34,109,133,86,59,192,129,1,119,211,120,107,164,198,65,137,131,84,33,222,157,46,169,88,199,129,155,21,127,255,103,199,173,87,82,28,61,201,189,20,149,120,32,86,60,22,45,242,203,248,129,178,54,131,215,244,6,131,199,219,118,2,239,178,180,9,104,154,151,73,100,15,93,143,26,130,97,46,43,241,234,208,214,134,8,59,86,134,138,37,248,8,4,39,180,231,9,123,114,12,212,225,110,124,2,141,209,124,241,6,227,92,86,11,125,81,91,4,198,216,201,174,39,77,225,75,170,152,122,91,169,21,61,171,83,207,238,44,129,193,97,153,168,163,200,86,11,174,65,238,250,198,26,125,191,203,226,33,242,92,124,37,55,22,217,91,42,147,239,68,26,255,62,96,88,98,171,141,39,158,55,250,231,90,49,50,221,43,6,210,235,213,14,200,11,248,23,218,44,71,172,5,91,32,7,225,103,241,237,143,4,62,49,203,203,31,253,34,206,176,193,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnTransactionInsertingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9d96d60b-7197-4893-a368-b3739355ccdc"),
				Name = "OnTransactionInserting",
				CreatedInSchemaUId = new Guid("9552baed-3ff9-4e81-bb39-5af02d90244e"),
				CreatedInPackageId = new Guid("e3f6af0f-4ac0-46d1-b2e6-e18d10bd5c8e"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,80,75,107,194,64,16,62,55,191,98,241,148,20,13,120,78,83,208,168,193,131,80,52,122,223,184,35,46,172,179,154,157,57,136,248,223,155,87,109,169,162,226,117,190,231,124,41,107,37,232,184,135,169,18,177,24,35,105,58,134,41,80,86,158,84,98,13,239,112,37,13,195,71,90,18,63,253,78,86,72,116,114,77,218,98,86,171,58,65,228,41,203,185,1,65,191,216,96,103,25,233,190,99,163,42,61,27,114,101,164,55,194,255,41,19,11,100,99,2,113,242,222,10,32,46,48,242,206,53,161,106,18,142,15,44,141,243,191,230,179,161,116,144,88,116,36,145,92,152,20,160,52,253,107,217,109,63,12,106,183,91,53,103,146,182,225,32,119,254,21,24,60,21,59,130,252,133,212,94,95,188,63,138,110,7,92,0,253,217,238,178,89,247,122,244,82,181,220,43,73,48,97,84,205,233,150,245,55,10,93,125,228,249,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnTransactionDeletingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4bce6f6d-b279-4262-a1f8-1d32411483b8"),
				Name = "OnTransactionDeleting",
				CreatedInSchemaUId = new Guid("9552baed-3ff9-4e81-bb39-5af02d90244e"),
				CreatedInPackageId = new Guid("e3f6af0f-4ac0-46d1-b2e6-e18d10bd5c8e"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,143,77,107,194,64,16,134,207,230,87,12,158,18,209,128,103,171,160,49,13,61,8,165,68,239,155,238,20,23,214,217,152,157,57,136,248,223,141,73,69,80,81,241,250,206,243,126,76,38,70,3,239,74,252,210,48,134,148,216,240,46,206,144,243,90,210,137,179,178,161,149,178,130,31,89,13,78,194,110,94,41,242,234,151,141,163,188,113,117,163,81,160,157,20,22,129,47,183,233,198,9,241,227,196,214,85,103,182,240,41,200,252,65,120,30,51,6,18,107,35,216,7,157,10,89,42,26,5,135,6,56,45,137,211,173,40,235,195,239,159,197,76,121,76,28,121,86,196,62,78,42,212,134,175,86,246,255,63,140,154,180,123,51,7,67,232,193,66,241,58,158,22,62,188,33,162,151,186,231,88,188,81,253,164,117,89,106,197,248,41,164,91,241,30,118,4,66,83,45,124,197,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new PRMTransaction_PRMBase_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9552baed-3ff9-4e81-bb39-5af02d90244e"));
		}

		#endregion

	}

	#endregion

}

