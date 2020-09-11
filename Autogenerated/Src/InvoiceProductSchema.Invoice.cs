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

	#region Class: InvoiceProduct_Invoice_TerrasoftSchema

	/// <exclude/>
	public class InvoiceProduct_Invoice_TerrasoftSchema : Terrasoft.Configuration.BaseProductEntrySchema
	{

		#region Constructors: Public

		public InvoiceProduct_Invoice_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public InvoiceProduct_Invoice_TerrasoftSchema(InvoiceProduct_Invoice_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public InvoiceProduct_Invoice_TerrasoftSchema(InvoiceProduct_Invoice_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("732baa21-890b-4894-a457-623630e33a6f");
			RealUId = new Guid("732baa21-890b-4894-a457-623630e33a6f");
			Name = "InvoiceProduct_Invoice_Terrasoft";
			ParentSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("86bbc99f-1967-4f26-8394-3720e7d22144")) == null) {
				Columns.Add(CreateInvoiceColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateInvoiceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("86bbc99f-1967-4f26-8394-3720e7d22144"),
				Name = @"Invoice",
				ReferenceSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("732baa21-890b-4894-a457-623630e33a6f"),
				ModifiedInSchemaUId = new Guid("732baa21-890b-4894-a457-623630e33a6f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateInvoiceProduct_Invoice_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateInvoiceProduct_Invoice_TerrasoftEventsProcessSchema() {
			var schema = new InvoiceProduct_Invoice_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new InvoiceProduct_Invoice_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new InvoiceProduct_InvoiceEventsProcess(userConnection);
		}

		public override object Clone() {
			return new InvoiceProduct_Invoice_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new InvoiceProduct_Invoice_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("732baa21-890b-4894-a457-623630e33a6f"));
		}

		#endregion

	}

	#endregion

	#region Class: InvoiceProduct_Invoice_Terrasoft

	/// <summary>
	/// Product in invoice.
	/// </summary>
	public class InvoiceProduct_Invoice_Terrasoft : Terrasoft.Configuration.BaseProductEntry
	{

		#region Constructors: Public

		public InvoiceProduct_Invoice_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "InvoiceProduct_Invoice_Terrasoft";
		}

		public InvoiceProduct_Invoice_Terrasoft(InvoiceProduct_Invoice_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid InvoiceId {
			get {
				return GetTypedColumnValue<Guid>("InvoiceId");
			}
			set {
				SetColumnValue("InvoiceId", value);
				_invoice = null;
			}
		}

		/// <exclude/>
		public string InvoiceNumber {
			get {
				return GetTypedColumnValue<string>("InvoiceNumber");
			}
			set {
				SetColumnValue("InvoiceNumber", value);
				if (_invoice != null) {
					_invoice.Number = value;
				}
			}
		}

		private Invoice _invoice;
		/// <summary>
		/// Invoice.
		/// </summary>
		public Invoice Invoice {
			get {
				return _invoice ??
					(_invoice = LookupColumnEntities.GetEntity("Invoice") as Invoice);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new InvoiceProduct_InvoiceEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("InvoiceProduct_Invoice_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("InvoiceProduct_Invoice_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("InvoiceProduct_Invoice_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("InvoiceProduct_Invoice_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("InvoiceProduct_Invoice_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("InvoiceProduct_Invoice_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("InvoiceProduct_Invoice_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new InvoiceProduct_Invoice_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: InvoiceProduct_InvoiceEventsProcess

	/// <exclude/>
	public partial class InvoiceProduct_InvoiceEventsProcess<TEntity> : Terrasoft.Configuration.BaseProductEntry_ProductCatalogueEventsProcess<TEntity> where TEntity : InvoiceProduct_Invoice_Terrasoft
	{

		public InvoiceProduct_InvoiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "InvoiceProduct_InvoiceEventsProcess";
			SchemaUId = new Guid("732baa21-890b-4894-a457-623630e33a6f");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("732baa21-890b-4894-a457-623630e33a6f");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _subProcessScriptAmountChange;
		public ProcessFlowElement SubProcessScriptAmountChange {
			get {
				return _subProcessScriptAmountChange ?? (_subProcessScriptAmountChange = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessScriptAmountChange",
					SchemaElementUId = new Guid("4bd077a8-da39-4239-a2d0-055f6cb491cb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _invoiceProductSaved;
		public ProcessFlowElement InvoiceProductSaved {
			get {
				return _invoiceProductSaved ?? (_invoiceProductSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "InvoiceProductSaved",
					SchemaElementUId = new Guid("f8d5afcd-6412-423c-be17-8b36c9264eb7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptAmountChange;
		public ProcessScriptTask ScriptAmountChange {
			get {
				return _scriptAmountChange ?? (_scriptAmountChange = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptAmountChange",
					SchemaElementUId = new Guid("7be32003-5969-418d-9f47-1107bc41de67"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptAmountChangeExecute,
				});
			}
		}

		private ProcessFlowElement _invoiceProductDeleted;
		public ProcessFlowElement InvoiceProductDeleted {
			get {
				return _invoiceProductDeleted ?? (_invoiceProductDeleted = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "InvoiceProductDeleted",
					SchemaElementUId = new Guid("e58caf66-5923-41e7-ae22-5e38b3afab4f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway1;
		public ProcessExclusiveGateway ExclusiveGateway1 {
			get {
				return _exclusiveGateway1 ?? (_exclusiveGateway1 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway1",
					SchemaElementUId = new Guid("787d5a89-4cbc-49c5-b488-b8253792019e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway1.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
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
					SchemaElementUId = new Guid("5d01c5d0-ff6b-49e3-888b-24622b285f96"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _invoiceProductSaving;
		public ProcessFlowElement InvoiceProductSaving {
			get {
				return _invoiceProductSaving ?? (_invoiceProductSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "InvoiceProductSaving",
					SchemaElementUId = new Guid("c916e8c0-6843-484a-8c19-9e28c85f9c7e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _invoiceProductSavingScriptTask;
		public ProcessScriptTask InvoiceProductSavingScriptTask {
			get {
				return _invoiceProductSavingScriptTask ?? (_invoiceProductSavingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InvoiceProductSavingScriptTask",
					SchemaElementUId = new Guid("00ce74b0-f11b-45c7-bb37-9e10891970c1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InvoiceProductSavingScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[SubProcessScriptAmountChange.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessScriptAmountChange };
			FlowElements[InvoiceProductSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { InvoiceProductSaved };
			FlowElements[ScriptAmountChange.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptAmountChange };
			FlowElements[InvoiceProductDeleted.SchemaElementUId] = new Collection<ProcessFlowElement> { InvoiceProductDeleted };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[InvoiceProductSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { InvoiceProductSaving };
			FlowElements[InvoiceProductSavingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InvoiceProductSavingScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SubProcessScriptAmountChange":
						break;
					case "InvoiceProductSaved":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway1");
						break;
					case "ScriptAmountChange":
						break;
					case "InvoiceProductDeleted":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway1");
						break;
					case "ExclusiveGateway1":
							e.Context.QueueTasks.Enqueue("ScriptAmountChange");
						break;
					case "EventSubProcess1":
						break;
					case "InvoiceProductSaving":
						e.Context.QueueTasks.Enqueue("InvoiceProductSavingScriptTask");
						break;
					case "InvoiceProductSavingScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("InvoiceProductSaved");
			ActivatedEventElements.Add("InvoiceProductDeleted");
			ActivatedEventElements.Add("InvoiceProductSaving");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SubProcessScriptAmountChange":
					context.QueueTasks.Dequeue();
					break;
				case "InvoiceProductSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "InvoiceProductSaved";
					result = InvoiceProductSaved.Execute(context);
					break;
				case "ScriptAmountChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptAmountChange";
					result = ScriptAmountChange.Execute(context, ScriptAmountChangeExecute);
					break;
				case "InvoiceProductDeleted":
					context.QueueTasks.Dequeue();
					context.SenderName = "InvoiceProductDeleted";
					result = InvoiceProductDeleted.Execute(context);
					break;
				case "ExclusiveGateway1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway1";
					result = ExclusiveGateway1.Execute(context);
					break;
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "InvoiceProductSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "InvoiceProductSaving";
					result = InvoiceProductSaving.Execute(context);
					break;
				case "InvoiceProductSavingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "InvoiceProductSavingScriptTask";
					result = InvoiceProductSavingScriptTask.Execute(context, InvoiceProductSavingScriptTaskExecute);
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

		public virtual bool ScriptAmountChangeExecute(ProcessExecutingContext context) {
			UpdateInvoiceAmount(UserConnection);
			
			/*var entitySchemaManager = this.UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
			EntitySchemaQuery invoiceProductEntitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, "InvoiceProduct");
			var invoiceIdColumn = invoiceProductEntitySchemaQuery.AddColumn("Invoice");
			var primaryAmountColumn = invoiceProductEntitySchemaQuery.AddColumn(invoiceProductEntitySchemaQuery.CreateAggregationFunction(AggregationTypeStrict.Sum, "PrimaryTotalAmount"));
			var amountColumn = invoiceProductEntitySchemaQuery.AddColumn(invoiceProductEntitySchemaQuery.CreateAggregationFunction(AggregationTypeStrict.Sum, "TotalAmount"));
			var filters = invoiceProductEntitySchemaQuery.Filters;
			var invoiceId = this.Entity.GetTypedColumnValue<Guid>("InvoiceId");
			filters.Add(invoiceProductEntitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "Invoice", invoiceId));
			var entityCollection = invoiceProductEntitySchemaQuery.GetEntityCollection(this.UserConnection);
			var invoice = new Invoice(this.UserConnection);
			invoice.FetchFromDB(invoiceId);
			decimal PrimarySumTotalAmount = 0;
			decimal SumTotalAmount = 0;
			var discountPercent = invoice.GetTypedColumnValue<decimal>("DiscountPercent");
			decimal totalAmount = 0; 
			decimal PrimaryTotalAmount = 0; 
			decimal discountAmount = 0;
			if (entityCollection.Count > 0) {
				PrimarySumTotalAmount = entityCollection[0].GetTypedColumnValue<decimal>(primaryAmountColumn.Name);
				SumTotalAmount = entityCollection[0].GetTypedColumnValue<decimal>(amountColumn.Name);
				totalAmount = SumTotalAmount; 
				PrimaryTotalAmount = PrimarySumTotalAmount; 
				discountAmount = invoice.GetTypedColumnValue<decimal>("DiscountAmount");
				if (discountPercent != 0) {
					discountAmount = Multiply(Division(SumTotalAmount, 100), discountPercent);
					totalAmount = SumTotalAmount - Multiply(Division(SumTotalAmount, 100), discountPercent);
					PrimaryTotalAmount = PrimarySumTotalAmount - Multiply(Division(PrimarySumTotalAmount, 100), discountPercent);
				} else {
					if (discountAmount != 0) {
						totalAmount = SumTotalAmount - discountAmount;
						discountPercent = Division(Multiply(discountAmount, 100), SumTotalAmount);
						PrimaryTotalAmount = PrimarySumTotalAmount - Multiply(Division(PrimarySumTotalAmount, 100), discountPercent);
					} 
				}
			}
			var update = new Update(context.UserConnection, "Invoice")
				.Set("PrimaryAmount",Column.Parameter(PrimarySumTotalAmount))
				.Set("Amount",Column.Parameter(SumTotalAmount))
				.Set("DiscountAmount",Column.Parameter(discountAmount))
				.Set("DiscountPercent",Column.Parameter(discountPercent))
				.Set("TotalAmount",Column.Parameter(totalAmount))
				.Set("PrimaryTotalAmount",Column.Parameter(PrimaryTotalAmount))
				.Where("Id").IsEqual(Column.Parameter(invoiceId)) as Update;
			update.Execute();*/
			return true;
		}

		public virtual bool InvoiceProductSavingScriptTaskExecute(ProcessExecutingContext context) {
			var invoiceId = Entity.GetColumnValue("InvoiceId");
			if (invoiceId != null) {
				Select productFinanceSelect = new Select(UserConnection)
								.Column("Invoice", "CurrencyId")
								.Column("Invoice", "CurrencyRate")
								.Column("c", "Division")
								.From("Invoice").As("Invoice")
								.LeftOuterJoin("Currency").As("c").On("Invoice", "CurrencyId").IsEqual("c", "Id")
					.Where("Invoice", "Id").IsEqual(Column.Parameter(invoiceId)) as Select;
				using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
							using (var dataReader = productFinanceSelect.ExecuteReader(dbExecutor)) {
								while (dataReader.Read()) {
									var rate = UserConnection.DBTypeConverter.DBValueToDecimal(dataReader[1]);
									var division = UserConnection.DBTypeConverter.DBValueToDecimal(dataReader[2]);
									CurrencyRate = rate / (division != 0 ? division : 1);
								}
								
							}
						}
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "InvoiceProduct_Invoice_TerrasoftSaved":
							if (ActivatedEventElements.Contains("InvoiceProductSaved")) {
							context.QueueTasks.Enqueue("InvoiceProductSaved");
						}
						break;
					case "InvoiceProduct_Invoice_TerrasoftDeleted":
							if (ActivatedEventElements.Contains("InvoiceProductDeleted")) {
							context.QueueTasks.Enqueue("InvoiceProductDeleted");
						}
						break;
					case "InvoiceProduct_Invoice_TerrasoftSaving":
							if (ActivatedEventElements.Contains("InvoiceProductSaving")) {
							context.QueueTasks.Enqueue("InvoiceProductSaving");
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

	#region Class: InvoiceProduct_InvoiceEventsProcess

	/// <exclude/>
	public class InvoiceProduct_InvoiceEventsProcess : InvoiceProduct_InvoiceEventsProcess<InvoiceProduct_Invoice_Terrasoft>
	{

		public InvoiceProduct_InvoiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: InvoiceProduct_InvoiceEventsProcess

	public partial class InvoiceProduct_InvoiceEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void UpdateInvoiceAmount(UserConnection userConnection) {
			decimal sumTotalAmount = 0; 
			decimal sumPrimaryTotalAmount = 0; 
			var esq = new EntitySchemaQuery(userConnection.EntitySchemaManager, "InvoiceProduct");
			var totalAmountColumn = esq.AddColumn("TotalAmount");
			var primaryTotalAmountColumn = esq.AddColumn("PrimaryTotalAmount");
			var invoiceId = this.Entity.GetTypedColumnValue<Guid>("InvoiceId");
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Invoice", invoiceId));
			var entityCollection = esq.GetEntityCollection(userConnection);
			if (entityCollection.Count > 0) {
				foreach(var entity in entityCollection) {
					sumTotalAmount += entity.GetTypedColumnValue<decimal>(totalAmountColumn.Name);
					sumPrimaryTotalAmount += entity.GetTypedColumnValue<decimal>(primaryTotalAmountColumn.Name);
				}
			}
			var update = new Update(userConnection, "Invoice")
				.Set("Amount",Column.Parameter(sumTotalAmount))
				.Set("PrimaryAmount",Column.Parameter(sumPrimaryTotalAmount))
				.Where("Id").IsEqual(Column.Parameter(invoiceId)) as Update;
			update.Execute();
		}

		#endregion

	}

	#endregion

	#region Class: InvoiceProduct_Invoice_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class InvoiceProduct_Invoice_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseProductEntryEventsProcessSchema
	{

		#region Constructors: Public

		public InvoiceProduct_Invoice_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public InvoiceProduct_Invoice_TerrasoftEventsProcessSchema(InvoiceProduct_Invoice_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "InvoiceProduct_InvoiceEventsProcess";
			UId = new Guid("e5abce64-9c3a-4284-a869-521d249be745");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet675 = CreateLaneSet675LaneSet();
			LaneSets.Add(schemaLaneSet675);
			ProcessSchemaLane schemaLane2438 = CreateLane2438Lane();
			schemaLaneSet675.Lanes.Add(schemaLane2438);
			ProcessSchemaEventSubProcess subprocessscriptamountchange = CreateSubProcessScriptAmountChangeEventSubProcess();
			FlowElements.Add(subprocessscriptamountchange);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaStartMessageEvent invoiceproductsaved = CreateInvoiceProductSavedStartMessageEvent();
			subprocessscriptamountchange.FlowElements.Add(invoiceproductsaved);
			ProcessSchemaScriptTask scriptamountchange = CreateScriptAmountChangeScriptTask();
			subprocessscriptamountchange.FlowElements.Add(scriptamountchange);
			ProcessSchemaStartMessageEvent invoiceproductdeleted = CreateInvoiceProductDeletedStartMessageEvent();
			subprocessscriptamountchange.FlowElements.Add(invoiceproductdeleted);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			subprocessscriptamountchange.FlowElements.Add(exclusivegateway1);
			ProcessSchemaStartMessageEvent invoiceproductsaving = CreateInvoiceProductSavingStartMessageEvent();
			eventsubprocess1.FlowElements.Add(invoiceproductsaving);
			ProcessSchemaScriptTask invoiceproductsavingscripttask = CreateInvoiceProductSavingScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(invoiceproductsavingscripttask);
			FlowElements.Add(CreateSequenceFlow14582SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14583SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14584SequenceFlow());
			FlowElements.Add(CreateFromInvoiceProductSavingSequenceFlowSequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14582SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14582",
				UId = new Guid("69d0c995-aa9a-4b90-be6c-602acd4e31f2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e5abce64-9c3a-4284-a869-521d249be745"),
				CurveCenterPosition = new Point(149, 84),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e5abce64-9c3a-4284-a869-521d249be745"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f8d5afcd-6412-423c-be17-8b36c9264eb7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("787d5a89-4cbc-49c5-b488-b8253792019e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14583SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14583",
				UId = new Guid("383f843d-ec73-4c66-a5e1-dd138de57651"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e5abce64-9c3a-4284-a869-521d249be745"),
				CurveCenterPosition = new Point(146, 106),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e5abce64-9c3a-4284-a869-521d249be745"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e58caf66-5923-41e7-ae22-5e38b3afab4f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("787d5a89-4cbc-49c5-b488-b8253792019e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14584SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14584",
				UId = new Guid("dbf11a8f-a946-453d-b6d7-0de60076ac08"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e5abce64-9c3a-4284-a869-521d249be745"),
				CurveCenterPosition = new Point(279, 98),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e5abce64-9c3a-4284-a869-521d249be745"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("787d5a89-4cbc-49c5-b488-b8253792019e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7be32003-5969-418d-9f47-1107bc41de67"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateFromInvoiceProductSavingSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "FromInvoiceProductSavingSequenceFlow",
				UId = new Guid("fe8d57b0-eb11-4962-87f1-e42fde551456"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6"),
				CreatedInSchemaUId = new Guid("e5abce64-9c3a-4284-a869-521d249be745"),
				CurveCenterPosition = new Point(158, 304),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e5abce64-9c3a-4284-a869-521d249be745"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c916e8c0-6843-484a-8c19-9e28c85f9c7e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("00ce74b0-f11b-45c7-bb37-9e10891970c1"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet675LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet675 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("d8e61427-972f-4e50-a2ac-cf61f12009f7"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e5abce64-9c3a-4284-a869-521d249be745"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("e5abce64-9c3a-4284-a869-521d249be745"),
				Name = @"LaneSet675",
				Position = new Point(5, 5),
				Size = new Size(1566, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet675;
		}

		protected virtual ProcessSchemaLane CreateLane2438Lane() {
			ProcessSchemaLane schemaLane2438 = new ProcessSchemaLane(this) {
				UId = new Guid("2025a304-914c-44c6-8ca7-760418b338b8"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("d8e61427-972f-4e50-a2ac-cf61f12009f7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e5abce64-9c3a-4284-a869-521d249be745"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("e5abce64-9c3a-4284-a869-521d249be745"),
				Name = @"Lane2438",
				Position = new Point(29, 0),
				Size = new Size(1537, 400),
				UseBackgroundMode = false
			};
			return schemaLane2438;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessScriptAmountChangeEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessScriptAmountChange = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("4bd077a8-da39-4239-a2d0-055f6cb491cb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2025a304-914c-44c6-8ca7-760418b338b8"),
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e5abce64-9c3a-4284-a869-521d249be745"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e5abce64-9c3a-4284-a869-521d249be745"),
				Name = @"SubProcessScriptAmountChange",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(346, 198),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessScriptAmountChange;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInvoiceProductSavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f8d5afcd-6412-423c-be17-8b36c9264eb7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4bd077a8-da39-4239-a2d0-055f6cb491cb"),
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e5abce64-9c3a-4284-a869-521d249be745"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"InvoiceProductSaved",
				ModifiedInSchemaUId = new Guid("e5abce64-9c3a-4284-a869-521d249be745"),
				Name = @"InvoiceProductSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptAmountChangeScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7be32003-5969-418d-9f47-1107bc41de67"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4bd077a8-da39-4239-a2d0-055f6cb491cb"),
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e5abce64-9c3a-4284-a869-521d249be745"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e5abce64-9c3a-4284-a869-521d249be745"),
				Name = @"ScriptAmountChange",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(197, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,86,77,143,218,48,16,61,131,196,127,112,115,114,86,52,75,207,148,149,40,31,43,14,91,81,177,116,15,85,15,86,50,11,150,242,65,29,155,46,170,246,191,215,142,29,136,19,7,104,87,170,122,140,61,111,230,189,55,99,59,235,93,68,56,44,210,125,70,67,24,39,153,72,57,94,231,192,38,89,154,66,200,105,150,250,195,94,183,215,189,189,217,19,134,32,229,148,31,86,225,22,18,242,64,82,178,1,134,70,136,111,105,30,216,160,224,30,184,21,134,189,89,19,235,249,136,228,200,177,33,75,86,87,191,8,96,7,68,53,201,37,203,34,17,242,230,254,8,165,240,19,53,214,177,131,116,31,121,11,43,155,167,84,42,133,166,200,34,154,100,177,72,82,153,244,66,217,96,28,153,88,92,230,60,38,219,49,154,16,118,208,182,254,69,194,75,145,19,6,178,121,227,205,134,193,134,40,219,231,34,45,236,199,149,181,199,195,14,86,156,209,144,7,43,145,72,229,75,205,234,49,227,36,214,212,60,191,100,76,254,47,170,78,142,207,52,230,192,242,43,232,205,117,100,189,181,229,200,106,128,26,85,85,216,40,249,74,98,1,31,239,5,141,238,142,13,93,68,69,75,77,97,165,250,74,189,154,192,19,229,219,37,97,36,1,5,199,122,113,146,37,59,194,104,174,85,7,179,31,130,196,167,177,244,250,39,186,71,225,122,144,37,205,88,31,178,43,28,144,218,102,53,20,118,28,215,218,244,155,163,100,184,180,1,76,112,48,7,30,110,231,44,75,166,159,240,137,180,12,136,32,148,147,22,35,51,112,178,165,149,126,202,26,131,74,140,115,83,81,138,104,30,170,165,37,176,16,138,157,178,174,171,111,38,157,108,221,212,198,121,85,66,188,86,9,53,184,214,185,84,34,74,66,22,83,250,140,112,189,61,193,164,8,184,67,3,31,253,234,117,59,109,54,212,113,223,6,223,207,107,115,92,43,193,103,57,93,74,98,231,237,233,137,51,175,237,153,93,69,217,211,113,58,231,212,92,132,55,108,252,179,182,150,151,130,162,166,204,175,143,201,187,81,105,123,179,210,131,136,57,221,197,7,60,165,123,154,171,35,97,243,235,163,15,131,129,223,175,143,94,81,235,172,15,232,253,219,114,95,111,161,179,146,51,242,92,193,87,4,113,14,218,165,170,137,166,70,197,195,75,178,109,100,33,166,211,60,185,71,166,71,238,54,174,228,106,167,215,222,252,115,115,164,59,202,162,94,247,85,95,68,162,248,83,50,87,227,186,248,192,97,150,114,120,225,181,203,177,114,141,251,50,69,176,2,142,203,87,215,204,109,223,28,175,227,179,224,230,231,159,240,173,192,86,68,237,168,52,145,182,249,14,100,121,119,182,67,75,195,78,216,234,147,221,196,113,39,83,199,31,73,171,65,13,173,79,91,96,32,159,106,249,70,7,139,188,120,71,113,3,92,121,76,213,47,167,110,159,236,178,110,106,48,123,129,80,200,126,250,195,155,219,94,151,1,23,44,69,156,9,24,254,6,223,184,142,119,32,11,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInvoiceProductDeletedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e58caf66-5923-41e7-ae22-5e38b3afab4f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4bd077a8-da39-4239-a2d0-055f6cb491cb"),
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e5abce64-9c3a-4284-a869-521d249be745"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"InvoiceProductDeleted",
				ModifiedInSchemaUId = new Guid("e5abce64-9c3a-4284-a869-521d249be745"),
				Name = @"InvoiceProductDeleted",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 100),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("787d5a89-4cbc-49c5-b488-b8253792019e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4bd077a8-da39-4239-a2d0-055f6cb491cb"),
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e5abce64-9c3a-4284-a869-521d249be745"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("e5abce64-9c3a-4284-a869-521d249be745"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(85, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5d01c5d0-ff6b-49e3-888b-24622b285f96"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2025a304-914c-44c6-8ca7-760418b338b8"),
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6"),
				CreatedInSchemaUId = new Guid("e5abce64-9c3a-4284-a869-521d249be745"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e5abce64-9c3a-4284-a869-521d249be745"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(35, 210),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(322, 159),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInvoiceProductSavingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c916e8c0-6843-484a-8c19-9e28c85f9c7e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5d01c5d0-ff6b-49e3-888b-24622b285f96"),
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6"),
				CreatedInSchemaUId = new Guid("e5abce64-9c3a-4284-a869-521d249be745"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"InvoiceProductSaving",
				ModifiedInSchemaUId = new Guid("e5abce64-9c3a-4284-a869-521d249be745"),
				Name = @"InvoiceProductSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInvoiceProductSavingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("00ce74b0-f11b-45c7-bb37-9e10891970c1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5d01c5d0-ff6b-49e3-888b-24622b285f96"),
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6"),
				CreatedInSchemaUId = new Guid("e5abce64-9c3a-4284-a869-521d249be745"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e5abce64-9c3a-4284-a869-521d249be745"),
				Name = @"InvoiceProductSavingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(120, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,82,77,79,2,49,16,61,239,254,138,145,211,110,98,170,120,148,16,35,44,24,140,9,6,81,15,198,67,237,14,210,100,105,177,219,46,18,195,127,119,150,93,182,16,52,30,236,101,166,211,215,247,230,171,224,6,164,42,180,20,56,74,161,11,3,101,165,93,179,27,180,125,157,185,133,122,226,153,195,168,53,218,65,90,113,39,148,51,136,252,159,147,46,40,151,101,49,124,133,193,3,102,40,44,44,141,78,157,176,67,169,184,18,88,7,9,134,43,168,46,209,99,142,166,175,149,34,95,106,21,135,65,121,88,37,217,168,181,78,161,213,119,198,160,18,235,82,249,111,212,132,91,60,194,137,18,145,200,66,230,36,213,188,14,141,94,120,142,152,93,231,123,183,26,115,135,51,59,118,22,205,173,150,68,180,83,169,209,130,236,248,247,108,217,40,31,124,56,158,213,9,212,5,176,231,57,26,60,248,116,0,174,146,102,247,220,240,5,146,178,111,116,28,3,207,235,254,117,194,192,229,82,189,67,148,244,6,159,40,156,213,6,210,183,198,237,194,97,131,217,64,229,206,96,210,243,161,40,222,78,140,78,205,84,208,38,164,220,242,9,242,20,75,138,159,166,200,42,9,172,64,145,151,108,216,130,213,92,102,8,145,167,98,165,241,114,65,80,42,25,154,212,113,154,73,111,186,94,34,5,10,52,84,60,221,183,251,55,213,9,10,185,160,246,120,214,151,246,43,173,162,39,76,235,1,255,143,244,194,147,238,239,20,145,110,19,62,163,186,118,58,180,247,231,112,229,117,47,161,189,251,187,169,76,216,248,155,112,19,26,180,206,40,176,198,97,231,27,104,102,183,145,118,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateUpdateInvoiceAmountMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("26b07f07-893c-4fe1-9d1b-dba389348fb5"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
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

		protected virtual SchemaMethod CreateUpdateInvoiceAmountMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1a7522a2-e3b5-457b-89ad-005419786ca6"),
				Name = "UpdateInvoiceAmount",
				CreatedInSchemaUId = new Guid("e5abce64-9c3a-4284-a869-521d249be745"),
				CreatedInPackageId = new Guid("0831ed7d-04c4-455d-af2c-3fdb5376a294"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("af6181f9-7661-4399-8b1b-072760147e38"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("e5abce64-9c3a-4284-a869-521d249be745"),
				ModifiedInSchemaUId = new Guid("e5abce64-9c3a-4284-a869-521d249be745"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("0831ed7d-04c4-455d-af2c-3fdb5376a294")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,65,110,194,48,16,60,147,87,88,57,57,42,178,184,167,32,161,136,162,28,90,81,65,203,217,138,151,198,82,98,7,199,166,69,21,127,175,227,24,66,19,168,122,203,198,59,59,51,187,195,32,227,37,45,80,109,202,141,212,180,152,151,210,8,141,166,104,18,163,128,117,143,43,101,191,212,113,216,115,160,10,65,189,183,149,128,79,180,16,154,235,227,58,203,161,164,175,6,212,17,155,26,84,34,133,128,76,115,41,200,117,195,51,21,244,3,212,24,133,169,56,72,158,193,74,73,102,50,29,70,177,27,171,59,178,68,22,166,20,150,196,82,145,57,99,109,141,195,43,61,103,84,53,80,122,15,60,244,116,158,193,91,61,41,179,32,157,243,218,203,38,75,208,155,99,5,126,194,59,45,12,60,46,13,103,51,124,182,144,178,102,70,67,244,196,11,13,170,110,8,113,83,39,10,168,134,246,239,150,235,124,69,21,45,161,105,193,237,207,68,150,21,85,188,150,162,225,32,139,189,161,69,183,155,112,220,169,138,188,76,112,170,172,152,162,221,174,183,104,85,46,122,47,189,51,88,60,223,33,220,199,147,196,29,118,134,38,17,250,14,70,59,105,37,103,57,238,168,172,132,1,169,107,29,245,242,243,48,245,125,55,87,230,115,53,195,131,11,147,23,187,19,171,206,13,188,145,185,127,206,189,151,129,203,248,83,112,114,27,52,21,179,71,241,225,125,115,69,111,85,87,23,136,130,17,89,131,198,161,15,203,216,15,189,92,18,255,222,66,116,1,120,39,127,225,134,102,29,124,155,131,2,155,46,27,43,146,214,46,19,120,0,191,10,6,162,181,247,17,7,173,57,178,248,130,204,88,95,81,252,3,148,240,42,69,237,3,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new InvoiceProduct_Invoice_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e5abce64-9c3a-4284-a869-521d249be745"));
		}

		#endregion

	}

	#endregion

}

