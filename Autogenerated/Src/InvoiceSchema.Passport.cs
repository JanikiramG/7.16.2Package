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

	#region Class: Invoice_Passport_TerrasoftSchema

	/// <exclude/>
	public class Invoice_Passport_TerrasoftSchema : Terrasoft.Configuration.Invoice_PRMPortal_TerrasoftSchema
	{

		#region Constructors: Public

		public Invoice_Passport_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Invoice_Passport_TerrasoftSchema(Invoice_Passport_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Invoice_Passport_TerrasoftSchema(Invoice_Passport_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("7a364256-ee50-4219-aed1-dfe247a7832b");
			Name = "Invoice_Passport_Terrasoft";
			ParentSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5");
			ExtendParent = true;
			CreatedInPackageId = new Guid("c4bef748-df1b-4c41-878a-658ffe06f804");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("b419c3b3-22c7-44ad-8fc8-c02618d362dc")) == null) {
				Columns.Add(CreateAmountWithoutTaxColumn());
			}
			if (Columns.FindByUId(new Guid("08be4ee9-724d-45ee-b01a-1906f7e9670c")) == null) {
				Columns.Add(CreatePrimaryAmountWithoutTaxColumn());
			}
			if (Columns.FindByUId(new Guid("a7a263e8-7fc8-409c-9ada-14d2d38ba1d1")) == null) {
				Columns.Add(CreatePaymentAmountWithoutTaxColumn());
			}
			if (Columns.FindByUId(new Guid("f6182f6b-cf24-4858-b9e2-5377f59fa07a")) == null) {
				Columns.Add(CreatePrimaryPaymentAmountWithoutTaxColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateAmountWithoutTaxColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("b419c3b3-22c7-44ad-8fc8-c02618d362dc"),
				Name = @"AmountWithoutTax",
				CreatedInSchemaUId = new Guid("7a364256-ee50-4219-aed1-dfe247a7832b"),
				ModifiedInSchemaUId = new Guid("7a364256-ee50-4219-aed1-dfe247a7832b"),
				CreatedInPackageId = new Guid("a002bd5f-14f1-4196-ac19-0a0feddeb334")
			};
		}

		protected virtual EntitySchemaColumn CreatePrimaryAmountWithoutTaxColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("08be4ee9-724d-45ee-b01a-1906f7e9670c"),
				Name = @"PrimaryAmountWithoutTax",
				CreatedInSchemaUId = new Guid("7a364256-ee50-4219-aed1-dfe247a7832b"),
				ModifiedInSchemaUId = new Guid("7a364256-ee50-4219-aed1-dfe247a7832b"),
				CreatedInPackageId = new Guid("a002bd5f-14f1-4196-ac19-0a0feddeb334")
			};
		}

		protected virtual EntitySchemaColumn CreatePaymentAmountWithoutTaxColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("a7a263e8-7fc8-409c-9ada-14d2d38ba1d1"),
				Name = @"PaymentAmountWithoutTax",
				CreatedInSchemaUId = new Guid("7a364256-ee50-4219-aed1-dfe247a7832b"),
				ModifiedInSchemaUId = new Guid("7a364256-ee50-4219-aed1-dfe247a7832b"),
				CreatedInPackageId = new Guid("a002bd5f-14f1-4196-ac19-0a0feddeb334")
			};
		}

		protected virtual EntitySchemaColumn CreatePrimaryPaymentAmountWithoutTaxColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("f6182f6b-cf24-4858-b9e2-5377f59fa07a"),
				Name = @"PrimaryPaymentAmountWithoutTax",
				CreatedInSchemaUId = new Guid("7a364256-ee50-4219-aed1-dfe247a7832b"),
				ModifiedInSchemaUId = new Guid("7a364256-ee50-4219-aed1-dfe247a7832b"),
				CreatedInPackageId = new Guid("a002bd5f-14f1-4196-ac19-0a0feddeb334")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateInvoice_Passport_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateInvoice_Passport_TerrasoftEventsProcessSchema() {
			var schema = new Invoice_Passport_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Invoice_Passport_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Invoice_PassportEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Invoice_Passport_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Invoice_Passport_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7a364256-ee50-4219-aed1-dfe247a7832b"));
		}

		#endregion

	}

	#endregion

	#region Class: Invoice_Passport_Terrasoft

	/// <summary>
	/// Invoice.
	/// </summary>
	public class Invoice_Passport_Terrasoft : Terrasoft.Configuration.Invoice_PRMPortal_Terrasoft
	{

		#region Constructors: Public

		public Invoice_Passport_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Invoice_Passport_Terrasoft";
		}

		public Invoice_Passport_Terrasoft(Invoice_Passport_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Amount not including taxes.
		/// </summary>
		public Decimal AmountWithoutTax {
			get {
				return GetTypedColumnValue<Decimal>("AmountWithoutTax");
			}
			set {
				SetColumnValue("AmountWithoutTax", value);
			}
		}

		/// <summary>
		/// Amount not including taxes, base currency.
		/// </summary>
		public Decimal PrimaryAmountWithoutTax {
			get {
				return GetTypedColumnValue<Decimal>("PrimaryAmountWithoutTax");
			}
			set {
				SetColumnValue("PrimaryAmountWithoutTax", value);
			}
		}

		/// <summary>
		/// Payment amount not including taxes.
		/// </summary>
		public Decimal PaymentAmountWithoutTax {
			get {
				return GetTypedColumnValue<Decimal>("PaymentAmountWithoutTax");
			}
			set {
				SetColumnValue("PaymentAmountWithoutTax", value);
			}
		}

		/// <summary>
		/// Payment amount not including taxes, base currency.
		/// </summary>
		public Decimal PrimaryPaymentAmountWithoutTax {
			get {
				return GetTypedColumnValue<Decimal>("PrimaryPaymentAmountWithoutTax");
			}
			set {
				SetColumnValue("PrimaryPaymentAmountWithoutTax", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Invoice_PassportEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Invoice_Passport_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("Invoice_Passport_TerrasoftDeleting", e);
			Saved += (s, e) => ThrowEvent("Invoice_Passport_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Invoice_Passport_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Invoice_Passport_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Invoice_Passport_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Invoice_PassportEventsProcess

	/// <exclude/>
	public partial class Invoice_PassportEventsProcess<TEntity> : Terrasoft.Configuration.Invoice_PRMPortalEventsProcess<TEntity> where TEntity : Invoice_Passport_Terrasoft
	{

		public Invoice_PassportEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Invoice_PassportEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			_isInvoiceCanceled = () => {{ return false; }};
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7a364256-ee50-4219-aed1-dfe247a7832b");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private Func<bool> _isInvoiceCanceled;
		public virtual bool IsInvoiceCanceled {
			get {
				return (_isInvoiceCanceled ?? (_isInvoiceCanceled = () => false)).Invoke();
			}
			set {
				_isInvoiceCanceled = () => { return value; };
			}
		}

		public virtual Object ChangedColumnValues {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess2;
		public ProcessFlowElement EventSubProcess2 {
			get {
				return _eventSubProcess2 ?? (_eventSubProcess2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess2",
					SchemaElementUId = new Guid("f66dbaa2-fdd4-4396-92ce-13ebffcab02e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _passportInvoiceSaving;
		public ProcessFlowElement PassportInvoiceSaving {
			get {
				return _passportInvoiceSaving ?? (_passportInvoiceSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PassportInvoiceSaving",
					SchemaElementUId = new Guid("68950f9c-cc32-469f-94d9-d003296355a0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _isPaymentStatusCanceled;
		public ProcessScriptTask IsPaymentStatusCanceled {
			get {
				return _isPaymentStatusCanceled ?? (_isPaymentStatusCanceled = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "IsPaymentStatusCanceled",
					SchemaElementUId = new Guid("c69a5e84-d99a-4154-908d-b90c057a36cd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = IsPaymentStatusCanceledExecute,
				});
			}
		}

		private ProcessFlowElement _deletedEventSubProcess;
		public ProcessFlowElement DeletedEventSubProcess {
			get {
				return _deletedEventSubProcess ?? (_deletedEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "DeletedEventSubProcess",
					SchemaElementUId = new Guid("8238d963-44d7-4d21-b865-45931d931373"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _invoiceDeletedStartMessage;
		public ProcessFlowElement InvoiceDeletedStartMessage {
			get {
				return _invoiceDeletedStartMessage ?? (_invoiceDeletedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "InvoiceDeletedStartMessage",
					SchemaElementUId = new Guid("e99e59b8-9d2a-4073-b182-58303437863e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _onDeletedScriptTask;
		public ProcessScriptTask OnDeletedScriptTask {
			get {
				return _onDeletedScriptTask ?? (_onDeletedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OnDeletedScriptTask",
					SchemaElementUId = new Guid("fed8d9f3-319d-44e4-818f-50436f075221"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OnDeletedScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[PassportInvoiceSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { PassportInvoiceSaving };
			FlowElements[IsPaymentStatusCanceled.SchemaElementUId] = new Collection<ProcessFlowElement> { IsPaymentStatusCanceled };
			FlowElements[DeletedEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { DeletedEventSubProcess };
			FlowElements[InvoiceDeletedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { InvoiceDeletedStartMessage };
			FlowElements[OnDeletedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OnDeletedScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess2":
						break;
					case "PassportInvoiceSaving":
						e.Context.QueueTasks.Enqueue("IsPaymentStatusCanceled");
						break;
					case "IsPaymentStatusCanceled":
						break;
					case "DeletedEventSubProcess":
						break;
					case "InvoiceDeletedStartMessage":
						e.Context.QueueTasks.Enqueue("OnDeletedScriptTask");
						break;
					case "OnDeletedScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("PassportInvoiceSaving");
			ActivatedEventElements.Add("InvoiceDeletedStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "PassportInvoiceSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "PassportInvoiceSaving";
					result = PassportInvoiceSaving.Execute(context);
					break;
				case "IsPaymentStatusCanceled":
					context.QueueTasks.Dequeue();
					context.SenderName = "IsPaymentStatusCanceled";
					result = IsPaymentStatusCanceled.Execute(context, IsPaymentStatusCanceledExecute);
					break;
				case "DeletedEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "InvoiceDeletedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "InvoiceDeletedStartMessage";
					result = InvoiceDeletedStartMessage.Execute(context);
					break;
				case "OnDeletedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OnDeletedScriptTask";
					result = OnDeletedScriptTask.Execute(context, OnDeletedScriptTaskExecute);
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
				case "ChangedColumnValues":
					ChangedColumnValues = reader.GetSerializableObjectValue();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool IsPaymentStatusCanceledExecute(ProcessExecutingContext context) {
			ChangedColumnValues = new List<EntityColumnValue>(Entity.GetChangedColumnValues());
			return true;
		}

		public virtual bool OnDeletedScriptTaskExecute(ProcessExecutingContext context) {
			var orderAmountHelper = ClassFactory.Get<OrderAmountHelper>(new ConstructorArgument("userConnection", UserConnection));
			orderAmountHelper.UpdateOrderPaymentAmountOnInvoiceDeleted(Entity.GetTypedColumnValue<Guid>("OrderId"));
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Invoice_Passport_TerrasoftSaving":
							if (ActivatedEventElements.Contains("PassportInvoiceSaving")) {
							context.QueueTasks.Enqueue("PassportInvoiceSaving");
							ProcessQueue(context);
							return;
						}
						break;
					case "Invoice_Passport_TerrasoftDeleted":
							if (ActivatedEventElements.Contains("InvoiceDeletedStartMessage")) {
							context.QueueTasks.Enqueue("InvoiceDeletedStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (ChangedColumnValues != null) {
				if (ChangedColumnValues.GetType().IsSerializable ||
					ChangedColumnValues.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ChangedColumnValues", ChangedColumnValues, null);
				}
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: Invoice_PassportEventsProcess

	/// <exclude/>
	public class Invoice_PassportEventsProcess : Invoice_PassportEventsProcess<Invoice_Passport_Terrasoft>
	{

		public Invoice_PassportEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Invoice_PassportEventsProcess

	public partial class Invoice_PassportEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void CleanInvoiceIdInSupplyPayment() {
			var supplyPaymentElementSchema = UserConnection.EntitySchemaManager.GetInstanceByName("SupplyPaymentElement");
				var item = supplyPaymentElementSchema.CreateEntity(UserConnection);
				var invoiceId = Entity.GetTypedColumnValue<Guid>("Id");
				if (item.FetchFromDB(new Dictionary<string, object>{{"Invoice", invoiceId}})) {
					item.SetColumnValue("InvoiceId", null);
					item.SetColumnValue("AmountFact", null);
					item.SetColumnValue("PrimaryAmountFact", null);
					item.SetColumnValue("DateFact", null);
					item.SetColumnValue("StateId", PassportConstants.SupplyPaymentStateNotFinished);
					item.Save(false);
				};
		}

		public override void OnSaved() {
			var orderAmountHelper = GetOrderAmountHelper();
			if (NeedFinRecalc) {
				bool productAmountRecalculated = orderAmountHelper.UpdateInvoiceProductAmountOnCurrencyChange(Entity.PrimaryColumnValue);
				NeedFinRecalc = !productAmountRecalculated;
			}
			base.OnSaved();
			var changedColumnValues = ChangedColumnValues as List<EntityColumnValue>;
			if (changedColumnValues == null) {
				return;
			}
			bool orderPaymentAmountUpdated;
			orderAmountHelper.UpdateSupplyPaymentElementOnInvoiceChanged(Entity.PrimaryColumnValue, changedColumnValues, out orderPaymentAmountUpdated);
			var paymentStatusColumnValue = changedColumnValues.FirstOrDefault(changedColumn => changedColumn.Column.Name == "PaymentStatus");
			if (paymentStatusColumnValue != null && (Guid)paymentStatusColumnValue.Value == PassportConstants.InvoicePaymentStatusCanceled) {
				CleanInvoiceIdInSupplyPayment();
			}
			if (!orderPaymentAmountUpdated && changedColumnValues.ConvertAll(cv => cv.Column.Name).Intersect(new[] { "PrimaryPaymentAmount", "PaymentStatus" }).Any()) {
				orderAmountHelper.UpdateOrderPaymentAmountOnInvoiceChanged(Entity.PrimaryColumnValue);
			}
		}

		public virtual OrderAmountHelper GetOrderAmountHelper() {
			return ClassFactory.Get<OrderAmountHelper>(new ConstructorArgument("userConnection", UserConnection));
		}

		#endregion

	}

	#endregion

	#region Class: Invoice_Passport_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Invoice_Passport_TerrasoftEventsProcessSchema : Terrasoft.Configuration.Invoice_PRMPortal_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public Invoice_Passport_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Invoice_Passport_TerrasoftEventsProcessSchema(Invoice_Passport_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Invoice_PassportEventsProcess";
			UId = new Guid("21cabaa7-852a-419f-b1f8-9129aa66fbdc");
			CreatedInPackageId = new Guid("c4bef748-df1b-4c41-878a-658ffe06f804");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("40afb235-de4b-49af-b724-766a30fd0ce2");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateIsInvoiceCanceledParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9c3ca321-dd67-49cb-93db-e1f46adaa80d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("21cabaa7-852a-419f-b1f8-9129aa66fbdc"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("21cabaa7-852a-419f-b1f8-9129aa66fbdc"),
				Name = @"IsInvoiceCanceled",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"false",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("21cabaa7-852a-419f-b1f8-9129aa66fbdc"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateChangedColumnValuesParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("edaf21f2-245c-4b06-93d8-fd679bb83a9f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("21cabaa7-852a-419f-b1f8-9129aa66fbdc"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("21cabaa7-852a-419f-b1f8-9129aa66fbdc"),
				Name = @"ChangedColumnValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateIsInvoiceCanceledParameter());
			Parameters.Add(CreateChangedColumnValuesParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess deletedeventsubprocess = CreateDeletedEventSubProcessEventSubProcess();
			FlowElements.Add(deletedeventsubprocess);
			ProcessSchemaStartMessageEvent passportinvoicesaving = CreatePassportInvoiceSavingStartMessageEvent();
			eventsubprocess2.FlowElements.Add(passportinvoicesaving);
			ProcessSchemaScriptTask ispaymentstatuscanceled = CreateIsPaymentStatusCanceledScriptTask();
			eventsubprocess2.FlowElements.Add(ispaymentstatuscanceled);
			ProcessSchemaStartMessageEvent invoicedeletedstartmessage = CreateInvoiceDeletedStartMessageStartMessageEvent();
			deletedeventsubprocess.FlowElements.Add(invoicedeletedstartmessage);
			ProcessSchemaScriptTask ondeletedscripttask = CreateOnDeletedScriptTaskScriptTask();
			deletedeventsubprocess.FlowElements.Add(ondeletedscripttask);
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("add5ab23-0ce5-4fa8-8c01-49d73710edae"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("20e036ab-8e08-4fdd-a89f-168a92c115ac"),
				CreatedInPackageId = new Guid("6ccace24-b594-4d40-a8b5-ddb59c4e7ca6"),
				CreatedInSchemaUId = new Guid("21cabaa7-852a-419f-b1f8-9129aa66fbdc"),
				CurveCenterPosition = new Point(197, 98),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("21cabaa7-852a-419f-b1f8-9129aa66fbdc"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("68950f9c-cc32-469f-94d9-d003296355a0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c69a5e84-d99a-4154-908d-b90c057a36cd"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("cc804895-31c3-49f8-ad24-1327f92770a2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("20e036ab-8e08-4fdd-a89f-168a92c115ac"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				CreatedInSchemaUId = new Guid("21cabaa7-852a-419f-b1f8-9129aa66fbdc"),
				CurveCenterPosition = new Point(646, 72),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("21cabaa7-852a-419f-b1f8-9129aa66fbdc"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e99e59b8-9d2a-4073-b182-58303437863e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fed8d9f3-319d-44e4-818f-50436f075221"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("fb58dec6-795c-4d51-be17-4f31cf7ff762"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("20e036ab-8e08-4fdd-a89f-168a92c115ac"),
				CreatedInPackageId = new Guid("6ccace24-b594-4d40-a8b5-ddb59c4e7ca6"),
				CreatedInSchemaUId = new Guid("21cabaa7-852a-419f-b1f8-9129aa66fbdc"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("21cabaa7-852a-419f-b1f8-9129aa66fbdc"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1189, 158),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("8a15af82-c407-49a0-a25b-762bc2df3321"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("fb58dec6-795c-4d51-be17-4f31cf7ff762"),
				CreatedInOwnerSchemaUId = new Guid("7a364256-ee50-4219-aed1-dfe247a7832b"),
				CreatedInPackageId = new Guid("6ccace24-b594-4d40-a8b5-ddb59c4e7ca6"),
				CreatedInSchemaUId = new Guid("21cabaa7-852a-419f-b1f8-9129aa66fbdc"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("21cabaa7-852a-419f-b1f8-9129aa66fbdc"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1160, 158),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f66dbaa2-fdd4-4396-92ce-13ebffcab02e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8a15af82-c407-49a0-a25b-762bc2df3321"),
				CreatedInOwnerSchemaUId = new Guid("20e036ab-8e08-4fdd-a89f-168a92c115ac"),
				CreatedInPackageId = new Guid("6ccace24-b594-4d40-a8b5-ddb59c4e7ca6"),
				CreatedInSchemaUId = new Guid("21cabaa7-852a-419f-b1f8-9129aa66fbdc"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("21cabaa7-852a-419f-b1f8-9129aa66fbdc"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(42, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(232, 116),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePassportInvoiceSavingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("68950f9c-cc32-469f-94d9-d003296355a0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f66dbaa2-fdd4-4396-92ce-13ebffcab02e"),
				CreatedInOwnerSchemaUId = new Guid("20e036ab-8e08-4fdd-a89f-168a92c115ac"),
				CreatedInPackageId = new Guid("6ccace24-b594-4d40-a8b5-ddb59c4e7ca6"),
				CreatedInSchemaUId = new Guid("21cabaa7-852a-419f-b1f8-9129aa66fbdc"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"InvoiceSaving",
				ModifiedInSchemaUId = new Guid("21cabaa7-852a-419f-b1f8-9129aa66fbdc"),
				Name = @"PassportInvoiceSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(22, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateIsPaymentStatusCanceledScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c69a5e84-d99a-4154-908d-b90c057a36cd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f66dbaa2-fdd4-4396-92ce-13ebffcab02e"),
				CreatedInOwnerSchemaUId = new Guid("20e036ab-8e08-4fdd-a89f-168a92c115ac"),
				CreatedInPackageId = new Guid("6ccace24-b594-4d40-a8b5-ddb59c4e7ca6"),
				CreatedInSchemaUId = new Guid("21cabaa7-852a-419f-b1f8-9129aa66fbdc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("21cabaa7-852a-419f-b1f8-9129aa66fbdc"),
				Name = @"IsPaymentStatusCanceled",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(106, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,206,72,204,75,79,77,113,206,207,41,205,205,11,75,204,41,77,45,86,176,85,200,75,45,87,240,201,44,46,177,113,205,43,201,44,169,68,146,181,211,128,8,233,185,167,150,56,99,234,213,208,212,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,87,157,225,85,97,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateDeletedEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaDeletedEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("8238d963-44d7-4d21-b865-45931d931373"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8a15af82-c407-49a0-a25b-762bc2df3321"),
				CreatedInOwnerSchemaUId = new Guid("20e036ab-8e08-4fdd-a89f-168a92c115ac"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				CreatedInSchemaUId = new Guid("21cabaa7-852a-419f-b1f8-9129aa66fbdc"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("21cabaa7-852a-419f-b1f8-9129aa66fbdc"),
				Name = @"DeletedEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(288, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(210, 114),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaDeletedEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInvoiceDeletedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e99e59b8-9d2a-4073-b182-58303437863e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8238d963-44d7-4d21-b865-45931d931373"),
				CreatedInOwnerSchemaUId = new Guid("20e036ab-8e08-4fdd-a89f-168a92c115ac"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				CreatedInSchemaUId = new Guid("21cabaa7-852a-419f-b1f8-9129aa66fbdc"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"InvoiceDeleted",
				ModifiedInSchemaUId = new Guid("21cabaa7-852a-419f-b1f8-9129aa66fbdc"),
				Name = @"InvoiceDeletedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(14, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOnDeletedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("fed8d9f3-319d-44e4-818f-50436f075221"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8238d963-44d7-4d21-b865-45931d931373"),
				CreatedInOwnerSchemaUId = new Guid("20e036ab-8e08-4fdd-a89f-168a92c115ac"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				CreatedInSchemaUId = new Guid("21cabaa7-852a-419f-b1f8-9129aa66fbdc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("21cabaa7-852a-419f-b1f8-9129aa66fbdc"),
				Name = @"OnDeletedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(103, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,142,193,10,130,64,20,69,247,65,255,48,184,82,8,127,64,19,196,202,92,217,34,219,15,206,37,132,241,141,60,223,24,254,125,106,171,106,123,239,229,156,59,105,86,142,13,56,239,157,39,185,194,14,96,117,84,133,213,227,120,209,173,56,158,227,18,146,214,191,163,44,36,188,84,225,104,20,246,235,46,231,167,239,65,18,6,126,4,47,5,161,149,206,81,112,80,205,87,16,69,201,126,247,39,141,155,193,104,193,230,185,233,121,37,125,234,154,42,154,92,215,226,4,11,129,9,207,36,157,108,175,238,243,0,83,56,235,123,122,104,235,145,150,190,51,89,24,108,144,202,4,155,137,33,158,73,45,47,145,188,1,128,45,58,33,239,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateCleanInvoiceIdInSupplyPaymentMethod());
			Methods.Add(CreateGetOrderAmountHelperMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("14309d58-28f0-4db9-b520-bf2b1c42dd81"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("301fa723-04d8-4fb4-8b85-b788d7ec5200"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb")
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
				UId = new Guid("039fff2c-6377-49c9-b0c4-212f9c778c5b"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("40620cec-072b-4865-b05c-978dcd5f52b4")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("957e9c93-a97b-4535-9625-5e5094e92fa0"),
				Name = "Terrasoft.Configuration.Passport",
				Alias = "",
				CreatedInPackageId = new Guid("6ccace24-b594-4d40-a8b5-ddb59c4e7ca6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7a66daba-2987-4d09-856f-7033bb29fef1"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0303fc42-2ac3-462c-aa6e-4b6e6a730461"),
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
				UId = new Guid("a7d86598-c4ed-440d-bb25-68d898b60ed1"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("5f05e5ce-515a-40bc-b6f5-74b884e9a4aa")
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

		protected override SchemaMethod CreateOnSavedMethod() {
			SchemaMethod method = base.CreateOnSavedMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,205,106,227,48,16,128,207,205,83,40,57,20,27,130,95,160,155,66,240,54,109,96,169,205,134,237,165,244,48,149,38,91,131,60,50,210,200,139,41,121,247,149,127,10,118,107,67,79,2,141,102,230,155,79,83,131,21,198,42,180,251,210,120,226,7,212,21,90,177,19,247,200,217,231,235,40,190,89,21,103,17,61,34,170,67,65,191,81,130,150,177,120,95,93,189,26,163,69,101,141,242,146,251,140,62,232,53,48,170,80,238,75,139,228,79,165,66,236,72,181,41,36,230,227,212,140,82,111,45,146,108,210,55,160,191,24,221,17,23,220,36,185,45,74,176,77,106,180,47,233,9,180,199,192,115,53,129,9,157,214,139,24,55,171,203,234,21,28,38,25,157,160,70,213,142,83,135,241,101,215,69,141,234,186,80,39,157,185,5,39,126,21,142,127,244,64,163,208,109,47,102,182,210,78,144,215,186,211,100,145,189,165,142,163,21,214,73,201,161,41,145,6,220,94,74,32,93,242,117,242,85,165,155,33,231,78,99,123,100,52,88,28,144,151,125,109,231,102,221,10,227,121,153,101,144,84,245,161,19,3,123,55,74,15,166,102,106,38,135,194,186,176,64,63,241,12,94,243,84,140,216,221,78,115,146,225,120,132,18,91,95,155,124,220,108,51,108,221,34,193,186,55,44,174,175,69,116,239,11,21,47,189,76,6,226,157,200,193,185,202,88,78,13,57,6,98,151,124,44,226,36,21,72,162,14,10,218,191,75,53,194,135,232,163,58,210,228,39,218,85,186,116,148,235,69,145,45,223,156,170,192,80,163,229,189,214,145,172,59,55,245,88,72,28,208,24,173,67,201,17,225,191,231,23,241,30,4,245,95,59,105,179,217,126,22,39,46,113,178,167,38,138,187,1,150,86,42,251,2,252,253,133,106,199,254,15,153,227,213,50,66,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCleanInvoiceIdInSupplyPaymentMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("20dde39a-dd4c-4bd8-8e59-c8339ab6ab57"),
				Name = "CleanInvoiceIdInSupplyPayment",
				CreatedInSchemaUId = new Guid("21cabaa7-852a-419f-b1f8-9129aa66fbdc"),
				CreatedInPackageId = new Guid("6ccace24-b594-4d40-a8b5-ddb59c4e7ca6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,145,93,107,194,48,20,134,175,29,236,63,132,94,69,144,254,1,157,48,63,42,189,152,8,221,118,127,214,30,53,35,57,41,201,105,71,17,255,251,98,202,80,193,225,118,21,72,222,243,60,47,57,45,56,225,155,186,214,221,6,58,131,196,75,141,167,163,40,247,104,64,60,137,55,143,110,110,137,176,100,101,41,93,18,43,238,250,215,23,32,216,161,75,87,200,57,121,6,42,113,214,173,193,160,76,138,27,200,100,56,126,124,24,180,65,168,24,77,64,255,238,77,231,14,129,177,151,201,235,10,103,10,181,86,149,152,87,1,213,39,79,77,94,187,26,171,185,213,141,161,119,208,13,78,86,141,170,166,50,201,171,222,175,182,66,158,252,105,134,92,238,51,103,205,98,38,9,191,196,66,69,60,184,110,226,217,41,218,141,132,253,248,12,206,233,225,144,228,189,43,25,157,173,199,227,112,40,14,129,56,136,184,2,249,194,42,127,38,130,118,36,168,209,58,202,111,71,159,141,109,136,51,40,249,126,118,227,148,9,21,255,51,178,8,63,249,183,100,193,33,26,27,111,192,251,218,186,240,28,23,203,62,189,218,104,12,174,45,103,138,148,223,99,117,201,132,22,229,22,180,199,120,121,28,127,3,161,83,200,50,98,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetOrderAmountHelperMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d55a5f2f-9bcd-404e-87b7-fb0ed1d9e6ec"),
				Name = "GetOrderAmountHelper",
				CreatedInSchemaUId = new Guid("21cabaa7-852a-419f-b1f8-9129aa66fbdc"),
				CreatedInPackageId = new Guid("6f755330-bde3-4969-8b89-b0bc46685fbc"),
				ResultValueTypeName = "OrderAmountHelper"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,202,65,10,64,80,20,133,225,173,188,140,188,146,13,144,146,194,204,200,2,196,73,138,251,116,222,189,201,238,49,52,253,191,159,80,163,184,102,159,98,108,167,89,3,239,188,131,150,3,23,176,62,130,137,246,216,79,176,74,5,151,107,130,68,165,125,95,205,213,14,136,166,137,69,240,5,193,172,91,144,36,115,227,47,120,95,60,187,53,217,92,102,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Invoice_Passport_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("21cabaa7-852a-419f-b1f8-9129aa66fbdc"));
		}

		#endregion

	}

	#endregion

}

