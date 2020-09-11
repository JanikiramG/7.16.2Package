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

	#region Class: OrderProduct_Order_TerrasoftSchema

	/// <exclude/>
	public class OrderProduct_Order_TerrasoftSchema : Terrasoft.Configuration.BaseProductEntrySchema
	{

		#region Constructors: Public

		public OrderProduct_Order_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OrderProduct_Order_TerrasoftSchema(OrderProduct_Order_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OrderProduct_Order_TerrasoftSchema(OrderProduct_Order_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			RealUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			Name = "OrderProduct_Order_Terrasoft";
			ParentSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4");
			ExtendParent = false;
			CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("5d990ae6-2f01-4ab2-ae31-d384e6070ec3")) == null) {
				Columns.Add(CreateOrderColumn());
			}
			if (Columns.FindByUId(new Guid("d39634bd-ec70-4b48-964d-47d0c052a47a")) == null) {
				Columns.Add(CreateCurrencyColumn());
			}
			if (Columns.FindByUId(new Guid("727aff73-e56f-401b-af5f-4a4d3a28c235")) == null) {
				Columns.Add(CreateCurrencyRateColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreateNotesColumn() {
			EntitySchemaColumn column = base.CreateNotesColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreateProductColumn() {
			EntitySchemaColumn column = base.CreateProductColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreateCustomProductColumn() {
			EntitySchemaColumn column = base.CreateCustomProductColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreateDeliveryDateColumn() {
			EntitySchemaColumn column = base.CreateDeliveryDateColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreateQuantityColumn() {
			EntitySchemaColumn column = base.CreateQuantityColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreateUnitColumn() {
			EntitySchemaColumn column = base.CreateUnitColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreatePrimaryPriceColumn() {
			EntitySchemaColumn column = base.CreatePrimaryPriceColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreatePriceColumn() {
			EntitySchemaColumn column = base.CreatePriceColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreatePrimaryAmountColumn() {
			EntitySchemaColumn column = base.CreatePrimaryAmountColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreateAmountColumn() {
			EntitySchemaColumn column = base.CreateAmountColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreatePrimaryDiscountAmountColumn() {
			EntitySchemaColumn column = base.CreatePrimaryDiscountAmountColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreateDiscountAmountColumn() {
			EntitySchemaColumn column = base.CreateDiscountAmountColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreateDiscountPercentColumn() {
			EntitySchemaColumn column = base.CreateDiscountPercentColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreateTaxColumn() {
			EntitySchemaColumn column = base.CreateTaxColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreatePrimaryTaxAmountColumn() {
			EntitySchemaColumn column = base.CreatePrimaryTaxAmountColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreateTaxAmountColumn() {
			EntitySchemaColumn column = base.CreateTaxAmountColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreatePrimaryTotalAmountColumn() {
			EntitySchemaColumn column = base.CreatePrimaryTotalAmountColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreateTotalAmountColumn() {
			EntitySchemaColumn column = base.CreateTotalAmountColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreateDiscountTaxColumn() {
			EntitySchemaColumn column = base.CreateDiscountTaxColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected virtual EntitySchemaColumn CreateOrderColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("5d990ae6-2f01-4ab2-ae31-d384e6070ec3"),
				Name = @"Order",
				ReferenceSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e"),
				ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e"),
				CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb")
			};
		}

		protected virtual EntitySchemaColumn CreateCurrencyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d39634bd-ec70-4b48-964d-47d0c052a47a"),
				Name = @"Currency",
				ReferenceSchemaUId = new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e"),
				ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e"),
				CreatedInPackageId = new Guid("6439b666-7603-43a5-90d0-7ee1e44814cf")
			};
		}

		protected virtual EntitySchemaColumn CreateCurrencyRateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float8")) {
				UId = new Guid("727aff73-e56f-401b-af5f-4a4d3a28c235"),
				Name = @"CurrencyRate",
				CreatedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e"),
				ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e"),
				CreatedInPackageId = new Guid("6439b666-7603-43a5-90d0-7ee1e44814cf")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateOrderProduct_Order_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateOrderProduct_Order_TerrasoftEventsProcessSchema() {
			var schema = new OrderProduct_Order_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new OrderProduct_Order_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OrderProduct_OrderEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OrderProduct_Order_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OrderProduct_Order_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e"));
		}

		#endregion

	}

	#endregion

	#region Class: OrderProduct_Order_Terrasoft

	/// <summary>
	/// Product in order.
	/// </summary>
	public class OrderProduct_Order_Terrasoft : Terrasoft.Configuration.BaseProductEntry
	{

		#region Constructors: Public

		public OrderProduct_Order_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OrderProduct_Order_Terrasoft";
		}

		public OrderProduct_Order_Terrasoft(OrderProduct_Order_Terrasoft source)
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

		/// <exclude/>
		public Guid CurrencyId {
			get {
				return GetTypedColumnValue<Guid>("CurrencyId");
			}
			set {
				SetColumnValue("CurrencyId", value);
				_currency = null;
			}
		}

		/// <exclude/>
		public string CurrencyName {
			get {
				return GetTypedColumnValue<string>("CurrencyName");
			}
			set {
				SetColumnValue("CurrencyName", value);
				if (_currency != null) {
					_currency.Name = value;
				}
			}
		}

		private Currency _currency;
		/// <summary>
		/// Currency.
		/// </summary>
		public Currency Currency {
			get {
				return _currency ??
					(_currency = LookupColumnEntities.GetEntity("Currency") as Currency);
			}
		}

		/// <summary>
		/// Exchange rate.
		/// </summary>
		public Decimal CurrencyRate {
			get {
				return GetTypedColumnValue<Decimal>("CurrencyRate");
			}
			set {
				SetColumnValue("CurrencyRate", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OrderProduct_OrderEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("OrderProduct_Order_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("OrderProduct_Order_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("OrderProduct_Order_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("OrderProduct_Order_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("OrderProduct_Order_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OrderProduct_Order_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: OrderProduct_OrderEventsProcess

	/// <exclude/>
	public partial class OrderProduct_OrderEventsProcess<TEntity> : Terrasoft.Configuration.BaseProductEntry_ProductCatalogueEventsProcess<TEntity> where TEntity : OrderProduct_Order_Terrasoft
	{

		public OrderProduct_OrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OrderProduct_OrderEventsProcess";
			SchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual bool NeedUpdateOrderAmount {
			get;
			set;
		}

		public virtual bool IsProductDeleted {
			get;
			set;
		}

		public virtual Object ChangedColumnValues {
			get;
			set;
		}

		public virtual bool NeedRecalcPrimaryValues {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess1;
		public ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("db6e08fa-3572-4cb3-a01f-aea11476efec"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _recalcOrderProductSavedStartMessage;
		public ProcessFlowElement RecalcOrderProductSavedStartMessage {
			get {
				return _recalcOrderProductSavedStartMessage ?? (_recalcOrderProductSavedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "RecalcOrderProductSavedStartMessage",
					SchemaElementUId = new Guid("4f7c89e9-e384-4e17-931a-783ea0cb3197"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _recalcOrderProductDeletedStartMessage;
		public ProcessFlowElement RecalcOrderProductDeletedStartMessage {
			get {
				return _recalcOrderProductDeletedStartMessage ?? (_recalcOrderProductDeletedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "RecalcOrderProductDeletedStartMessage",
					SchemaElementUId = new Guid("beeacac1-ec16-46d9-be2c-f507fe04bc5c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _recalculateOrderAmountScriptTask;
		public ProcessScriptTask RecalculateOrderAmountScriptTask {
			get {
				return _recalculateOrderAmountScriptTask ?? (_recalculateOrderAmountScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "RecalculateOrderAmountScriptTask",
					SchemaElementUId = new Guid("489b00b3-0a19-4c9f-bd85-febdd989d5f7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = RecalculateOrderAmountScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _setNeedUpdateAmountScriptTask;
		public ProcessScriptTask SetNeedUpdateAmountScriptTask {
			get {
				return _setNeedUpdateAmountScriptTask ?? (_setNeedUpdateAmountScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SetNeedUpdateAmountScriptTask",
					SchemaElementUId = new Guid("988e0c7e-a9da-48f7-aced-2826540572fa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SetNeedUpdateAmountScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess2;
		public ProcessFlowElement EventSubProcess2 {
			get {
				return _eventSubProcess2 ?? (_eventSubProcess2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess2",
					SchemaElementUId = new Guid("ca5735a3-2a7f-40e5-afc3-42da98341736"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _orderProductSaving;
		public ProcessFlowElement OrderProductSaving {
			get {
				return _orderProductSaving ?? (_orderProductSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OrderProductSaving",
					SchemaElementUId = new Guid("93237e85-4d8d-445e-b45a-e2328e1f1e02"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageOrderProductSaving;
		public ProcessThrowMessageEvent IntermediateThrowMessageOrderProductSaving {
			get {
				return _intermediateThrowMessageOrderProductSaving ?? (_intermediateThrowMessageOrderProductSaving = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageOrderProductSaving",
					SchemaElementUId = new Guid("f2eeafc8-973a-461e-b4ca-a88f5a569edd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OrderProductSaving",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptUpdateFinance;
		public ProcessScriptTask ScriptUpdateFinance {
			get {
				return _scriptUpdateFinance ?? (_scriptUpdateFinance = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptUpdateFinance",
					SchemaElementUId = new Guid("99f01749-87fc-479c-9937-aefacb13e57a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptUpdateFinanceExecute,
				});
			}
		}

		private ProcessScriptTask _checkNeedUpdateOrderAmountScriptTask;
		public ProcessScriptTask CheckNeedUpdateOrderAmountScriptTask {
			get {
				return _checkNeedUpdateOrderAmountScriptTask ?? (_checkNeedUpdateOrderAmountScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CheckNeedUpdateOrderAmountScriptTask",
					SchemaElementUId = new Guid("2e415177-d5ed-4a47-bd6b-126c99e8b578"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CheckNeedUpdateOrderAmountScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[RecalcOrderProductSavedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { RecalcOrderProductSavedStartMessage };
			FlowElements[RecalcOrderProductDeletedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { RecalcOrderProductDeletedStartMessage };
			FlowElements[RecalculateOrderAmountScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { RecalculateOrderAmountScriptTask };
			FlowElements[SetNeedUpdateAmountScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SetNeedUpdateAmountScriptTask };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[OrderProductSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { OrderProductSaving };
			FlowElements[IntermediateThrowMessageOrderProductSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageOrderProductSaving };
			FlowElements[ScriptUpdateFinance.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptUpdateFinance };
			FlowElements[CheckNeedUpdateOrderAmountScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckNeedUpdateOrderAmountScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "RecalcOrderProductSavedStartMessage":
						e.Context.QueueTasks.Enqueue("RecalculateOrderAmountScriptTask");
						break;
					case "RecalcOrderProductDeletedStartMessage":
						e.Context.QueueTasks.Enqueue("SetNeedUpdateAmountScriptTask");
						break;
					case "RecalculateOrderAmountScriptTask":
						break;
					case "SetNeedUpdateAmountScriptTask":
						e.Context.QueueTasks.Enqueue("RecalculateOrderAmountScriptTask");
						break;
					case "EventSubProcess2":
						break;
					case "OrderProductSaving":
						e.Context.QueueTasks.Enqueue("ScriptUpdateFinance");
						break;
					case "IntermediateThrowMessageOrderProductSaving":
						e.Context.QueueTasks.Enqueue("CheckNeedUpdateOrderAmountScriptTask");
						break;
					case "ScriptUpdateFinance":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageOrderProductSaving");
						break;
					case "CheckNeedUpdateOrderAmountScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("RecalcOrderProductSavedStartMessage");
			ActivatedEventElements.Add("RecalcOrderProductDeletedStartMessage");
			ActivatedEventElements.Add("OrderProductSaving");
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
				case "RecalcOrderProductSavedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "RecalcOrderProductSavedStartMessage";
					result = RecalcOrderProductSavedStartMessage.Execute(context);
					break;
				case "RecalcOrderProductDeletedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "RecalcOrderProductDeletedStartMessage";
					result = RecalcOrderProductDeletedStartMessage.Execute(context);
					break;
				case "RecalculateOrderAmountScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "RecalculateOrderAmountScriptTask";
					result = RecalculateOrderAmountScriptTask.Execute(context, RecalculateOrderAmountScriptTaskExecute);
					break;
				case "SetNeedUpdateAmountScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetNeedUpdateAmountScriptTask";
					result = SetNeedUpdateAmountScriptTask.Execute(context, SetNeedUpdateAmountScriptTaskExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "OrderProductSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "OrderProductSaving";
					result = OrderProductSaving.Execute(context);
					break;
				case "IntermediateThrowMessageOrderProductSaving":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OrderProductSaving");
					result = IntermediateThrowMessageOrderProductSaving.Execute(context);
					break;
				case "ScriptUpdateFinance":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptUpdateFinance";
					result = ScriptUpdateFinance.Execute(context, ScriptUpdateFinanceExecute);
					break;
				case "CheckNeedUpdateOrderAmountScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CheckNeedUpdateOrderAmountScriptTask";
					result = CheckNeedUpdateOrderAmountScriptTask.Execute(context, CheckNeedUpdateOrderAmountScriptTaskExecute);
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
				case "NeedRecalcPrimaryValues":
					NeedRecalcPrimaryValues = reader.GetValue<System.Boolean>();
				break;
				case "ChangedColumnValues":
					ChangedColumnValues = reader.GetSerializableObjectValue();
				break;
				case "IsProductDeleted":
					IsProductDeleted = reader.GetValue<System.Boolean>();
				break;
				case "NeedUpdateOrderAmount":
					NeedUpdateOrderAmount = reader.GetValue<System.Boolean>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool RecalculateOrderAmountScriptTaskExecute(ProcessExecutingContext context) {
			if (NeedUpdateOrderAmount) {
				RecalculateOrderAmount();
			}
			return true;
		}

		public virtual bool SetNeedUpdateAmountScriptTaskExecute(ProcessExecutingContext context) {
			NeedUpdateOrderAmount = true;
			IsProductDeleted = true;
			return true;
		}

		public virtual bool ScriptUpdateFinanceExecute(ProcessExecutingContext context) {
			LoadCurrencyFromOrder();
			return true;
		}

		public virtual bool CheckNeedUpdateOrderAmountScriptTaskExecute(ProcessExecutingContext context) {
			var changedValues = Entity.GetChangedColumnValues();
			List<string> changedColumnNames = changedValues.Where(cv => cv.Value != cv.OldValue).ToList().ConvertAll(cv => cv.Column.Name);
			NeedUpdateOrderAmount = changedColumnNames.Intersect(new[] {"TotalAmount", "PrimaryTotalAmount"}).Any();
			ChangedColumnValues = changedValues;
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "OrderProduct_Order_TerrasoftSaved":
							if (ActivatedEventElements.Contains("RecalcOrderProductSavedStartMessage")) {
							context.QueueTasks.Enqueue("RecalcOrderProductSavedStartMessage");
						}
						break;
					case "OrderProduct_Order_TerrasoftDeleted":
							if (ActivatedEventElements.Contains("RecalcOrderProductDeletedStartMessage")) {
							context.QueueTasks.Enqueue("RecalcOrderProductDeletedStartMessage");
						}
						break;
					case "OrderProduct_Order_TerrasoftSaving":
							if (ActivatedEventElements.Contains("OrderProductSaving")) {
							context.QueueTasks.Enqueue("OrderProductSaving");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("NeedRecalcPrimaryValues") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("NeedRecalcPrimaryValues", NeedRecalcPrimaryValues, false);
			}
			if (ChangedColumnValues != null) {
				if (ChangedColumnValues.GetType().IsSerializable ||
					ChangedColumnValues.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ChangedColumnValues", ChangedColumnValues, null);
				}
			}
			if (!HasMapping("IsProductDeleted") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsProductDeleted", IsProductDeleted, false);
			}
			if (!HasMapping("NeedUpdateOrderAmount") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("NeedUpdateOrderAmount", NeedUpdateOrderAmount, false);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: OrderProduct_OrderEventsProcess

	/// <exclude/>
	public class OrderProduct_OrderEventsProcess : OrderProduct_OrderEventsProcess<OrderProduct_Order_Terrasoft>
	{

		public OrderProduct_OrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OrderProduct_OrderEventsProcess

	public partial class OrderProduct_OrderEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void RecalculateOrderAmount() {
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "OrderProduct");
			var totalAmountColumn = esq.AddColumn(esq.CreateAggregationFunction(AggregationTypeStrict.Sum, "TotalAmount"));
			var primaryTotalAmountColumn = esq.AddColumn(esq.CreateAggregationFunction(AggregationTypeStrict.Sum, "PrimaryTotalAmount"));
			var orderId = Entity.GetTypedColumnValue<Guid>("OrderId");
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Order", orderId));
			var entity = esq.GetEntityCollection(UserConnection).FirstOrDefault();
			if (entity == null) {
				return;
			}
			var order = UserConnection.EntitySchemaManager.GetInstanceByName("Order").CreateEntity(UserConnection);
			if (order.FetchFromDB(orderId)) {
				var amount = entity.GetTypedColumnValue<decimal>(totalAmountColumn.Name);
				var primaryAmount = entity.GetTypedColumnValue<decimal>(primaryTotalAmountColumn.Name);
				order.SetColumnValue("Amount", amount);
				order.SetColumnValue("PrimaryAmount", primaryAmount);
				order.Save(false);
			}
		}

		public virtual void LoadCurrencyFromOrder() {
			var currencyId = Entity.GetColumnValue("CurrencyId");
			if (currencyId == null) {
				var orderId = Entity.GetTypedColumnValue<Guid>("OrderId");
				if (orderId == Guid.Empty) {
					return;
				}
				var orderEsq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "Order");
				var currnecyIdColumn = orderEsq.AddColumn("Currency.Id");
				var currnecyDivisionColumn = orderEsq.AddColumn("Currency.Division");
				var currnecyRateColumn = orderEsq.AddColumn("CurrencyRate");
				var order = orderEsq.GetEntity(UserConnection, orderId);
				if (order != null) {
					var division = order.GetTypedColumnValue<decimal>(currnecyDivisionColumn.Name);
					var currencyRate = order.GetTypedColumnValue<decimal>(currnecyRateColumn.Name);
					Entity.SetColumnValue("CurrencyId", order.GetTypedColumnValue<Guid>(currnecyIdColumn.Name));
					Entity.SetColumnValue("CurrencyRate", currencyRate);
					CurrencyRate = currencyRate / (division != 0 ? division : 1);
					NeedRecalcPrimaryValues = true;
				}
			}
			return;
		}

		public override void UpdatePrimaryAmounts() {
			if (NeedRecalcPrimaryValues){
				base.UpdatePrimaryAmounts();
			}
		}

		#endregion

	}

	#endregion

	#region Class: OrderProduct_Order_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class OrderProduct_Order_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseProductEntryEventsProcessSchema
	{

		#region Constructors: Public

		public OrderProduct_Order_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public OrderProduct_Order_TerrasoftEventsProcessSchema(OrderProduct_Order_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "OrderProduct_OrderEventsProcess";
			UId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58");
			CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateNeedUpdateOrderAmountParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("8d1cb694-fdb0-4c67-bdd5-5c9fd5e719d2"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				Name = @"NeedUpdateOrderAmount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsProductDeletedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("32b5b18d-6bcb-420b-a104-1e1c3424ffdf"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				Name = @"IsProductDeleted",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateChangedColumnValuesParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("1144efb2-97eb-429f-b46e-4e6eabd18f2d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				Name = @"ChangedColumnValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNeedRecalcPrimaryValuesParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("8ff5c143-037a-4bb2-aa97-b31cc4cc5859"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				Name = @"NeedRecalcPrimaryValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateNeedUpdateOrderAmountParameter());
			Parameters.Add(CreateIsProductDeletedParameter());
			Parameters.Add(CreateChangedColumnValuesParameter());
			Parameters.Add(CreateNeedRecalcPrimaryValuesParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaRecalculatOrderAmountLane = CreateRecalculatOrderAmountLaneLane();
			schemaLaneSet1.Lanes.Add(schemaRecalculatOrderAmountLane);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaStartMessageEvent recalcorderproductsavedstartmessage = CreateRecalcOrderProductSavedStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(recalcorderproductsavedstartmessage);
			ProcessSchemaStartMessageEvent recalcorderproductdeletedstartmessage = CreateRecalcOrderProductDeletedStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(recalcorderproductdeletedstartmessage);
			ProcessSchemaScriptTask recalculateorderamountscripttask = CreateRecalculateOrderAmountScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(recalculateorderamountscripttask);
			ProcessSchemaScriptTask setneedupdateamountscripttask = CreateSetNeedUpdateAmountScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(setneedupdateamountscripttask);
			ProcessSchemaStartMessageEvent orderproductsaving = CreateOrderProductSavingStartMessageEvent();
			eventsubprocess2.FlowElements.Add(orderproductsaving);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageorderproductsaving = CreateIntermediateThrowMessageOrderProductSavingIntermediateThrowMessageEvent();
			eventsubprocess2.FlowElements.Add(intermediatethrowmessageorderproductsaving);
			ProcessSchemaScriptTask scriptupdatefinance = CreateScriptUpdateFinanceScriptTask();
			eventsubprocess2.FlowElements.Add(scriptupdatefinance);
			ProcessSchemaScriptTask checkneedupdateorderamountscripttask = CreateCheckNeedUpdateOrderAmountScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(checkneedupdateorderamountscripttask);
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("9d6f78b6-3eec-43cf-b1ef-d5c89e3fdaa2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb"),
				CreatedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				CurveCenterPosition = new Point(149, 62),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4f7c89e9-e384-4e17-931a-783ea0cb3197"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("489b00b3-0a19-4c9f-bd85-febdd989d5f7"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("3b027536-2276-46b4-9185-059e0eaec5a5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("1ed21b51-15f2-4d61-bd88-5b67f16275ad"),
				CreatedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				CurveCenterPosition = new Point(196, 317),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("93237e85-4d8d-445e-b45a-e2328e1f1e02"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("99f01749-87fc-479c-9937-aefacb13e57a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("c09ec4d6-8603-4662-9bd2-a49dbf4b7ad0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("1ed21b51-15f2-4d61-bd88-5b67f16275ad"),
				CreatedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				CurveCenterPosition = new Point(329, 317),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("99f01749-87fc-479c-9937-aefacb13e57a"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f2eeafc8-973a-461e-b4ca-a88f5a569edd"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("19e0dfbf-9799-4e10-9c5e-a4336f215c8f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("d6ad04c1-fa0b-4adb-bfd8-17ec17775a03"),
				CreatedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				CurveCenterPosition = new Point(378, 320),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f2eeafc8-973a-461e-b4ca-a88f5a569edd"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2e415177-d5ed-4a47-bd6b-126c99e8b578"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("114ec83d-4972-470c-8fe2-d6fa303ab8d8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("d6ad04c1-fa0b-4adb-bfd8-17ec17775a03"),
				CreatedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				CurveCenterPosition = new Point(156, 156),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("beeacac1-ec16-46d9-be2c-f507fe04bc5c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("988e0c7e-a9da-48f7-aced-2826540572fa"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("dbea577f-dd61-43bc-b23e-bec3ac314f7e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("d6ad04c1-fa0b-4adb-bfd8-17ec17775a03"),
				CreatedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				CurveCenterPosition = new Point(233, 102),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("988e0c7e-a9da-48f7-aced-2826540572fa"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("489b00b3-0a19-4c9f-bd85-febdd989d5f7"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("5f235d5e-bd61-40f4-9a8a-3165ae794d66"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb"),
				CreatedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1189, 448),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateRecalculatOrderAmountLaneLane() {
			ProcessSchemaLane schemaRecalculatOrderAmountLane = new ProcessSchemaLane(this) {
				UId = new Guid("76c493fc-ad23-489f-a24e-7659ed30e30b"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("5f235d5e-bd61-40f4-9a8a-3165ae794d66"),
				CreatedInOwnerSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e"),
				CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb"),
				CreatedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				Name = @"RecalculatOrderAmountLane",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1160, 261),
				UseBackgroundMode = false
			};
			return schemaRecalculatOrderAmountLane;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("cc43e1bb-07fa-4d1b-9034-6c37beef3343"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("5f235d5e-bd61-40f4-9a8a-3165ae794d66"),
				CreatedInOwnerSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e"),
				CreatedInPackageId = new Guid("1ed21b51-15f2-4d61-bd88-5b67f16275ad"),
				CreatedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 266),
				Size = new Size(1160, 182),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("db6e08fa-3572-4cb3-a01f-aea11476efec"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("76c493fc-ad23-489f-a24e-7659ed30e30b"),
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb"),
				CreatedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(42, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(245, 240),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateRecalcOrderProductSavedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("4f7c89e9-e384-4e17-931a-783ea0cb3197"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("db6e08fa-3572-4cb3-a01f-aea11476efec"),
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb"),
				CreatedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OrderProductSaved",
				ModifiedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				Name = @"RecalcOrderProductSavedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(8, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateRecalcOrderProductDeletedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("beeacac1-ec16-46d9-be2c-f507fe04bc5c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("db6e08fa-3572-4cb3-a01f-aea11476efec"),
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb"),
				CreatedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OrderProductDeleted",
				ModifiedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				Name = @"RecalcOrderProductDeletedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(8, 128),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateRecalculateOrderAmountScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("489b00b3-0a19-4c9f-bd85-febdd989d5f7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("db6e08fa-3572-4cb3-a01f-aea11476efec"),
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb"),
				CreatedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				Name = @"RecalculateOrderAmountScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(120, 16),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,240,75,77,77,9,45,72,73,44,73,245,47,74,73,45,114,204,205,47,205,43,209,84,168,230,229,226,12,74,77,78,204,73,46,205,65,149,211,208,180,230,229,170,229,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,198,117,9,116,73,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateSetNeedUpdateAmountScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("988e0c7e-a9da-48f7-aced-2826540572fa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("db6e08fa-3572-4cb3-a01f-aea11476efec"),
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("d6ad04c1-fa0b-4adb-bfd8-17ec17775a03"),
				CreatedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				Name = @"SetNeedUpdateAmountScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(120, 114),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,75,77,77,9,45,72,73,44,73,245,47,74,73,45,114,204,205,47,205,43,81,176,85,40,41,42,77,181,230,229,242,44,14,40,202,79,41,77,46,113,73,205,73,45,73,77,65,200,20,165,150,148,22,229,65,120,0,212,31,102,84,69,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ca5735a3-2a7f-40e5-afc3-42da98341736"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cc43e1bb-07fa-4d1b-9034-6c37beef3343"),
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("1ed21b51-15f2-4d61-bd88-5b67f16275ad"),
				CreatedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(42, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(440, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOrderProductSavingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("93237e85-4d8d-445e-b45a-e2328e1f1e02"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ca5735a3-2a7f-40e5-afc3-42da98341736"),
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("1ed21b51-15f2-4d61-bd88-5b67f16275ad"),
				CreatedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OrderProductSaving",
				ModifiedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				Name = @"OrderProductSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(15, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageOrderProductSavingIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("f2eeafc8-973a-461e-b4ca-a88f5a569edd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ca5735a3-2a7f-40e5-afc3-42da98341736"),
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("1ed21b51-15f2-4d61-bd88-5b67f16275ad"),
				CreatedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OrderProductSaving",
				ModifiedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				Name = @"IntermediateThrowMessageOrderProductSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(239, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptUpdateFinanceScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("99f01749-87fc-479c-9937-aefacb13e57a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ca5735a3-2a7f-40e5-afc3-42da98341736"),
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("1ed21b51-15f2-4d61-bd88-5b67f16275ad"),
				CreatedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				Name = @"ScriptUpdateFinance",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(106, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,201,79,76,113,46,45,42,74,205,75,174,116,43,202,207,245,47,74,73,45,210,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,188,158,232,141,38,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateCheckNeedUpdateOrderAmountScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2e415177-d5ed-4a47-bd6b-126c99e8b578"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ca5735a3-2a7f-40e5-afc3-42da98341736"),
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("d6ad04c1-fa0b-4adb-bfd8-17ec17775a03"),
				CreatedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				Name = @"CheckNeedUpdateOrderAmountScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(330, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,144,207,10,130,64,16,198,239,65,239,176,121,82,136,125,129,50,16,137,8,34,59,88,29,162,195,162,131,10,235,108,140,179,134,68,239,94,186,68,127,232,54,204,124,223,111,190,153,86,145,200,74,133,5,228,7,165,45,52,34,20,75,228,138,59,185,2,142,221,36,54,218,214,232,230,126,48,27,143,54,85,195,243,134,169,194,98,241,178,59,209,86,213,3,227,139,41,143,37,16,248,89,43,194,167,188,149,67,87,76,194,190,78,180,19,5,50,53,61,214,15,100,108,176,5,226,72,235,183,197,209,101,143,239,3,108,1,242,253,37,87,12,9,229,64,81,109,44,242,123,237,71,22,185,70,6,106,32,99,31,225,122,58,139,155,151,26,86,218,89,188,169,240,118,84,213,138,186,207,238,61,144,17,118,195,169,127,94,240,123,222,83,69,192,150,80,48,89,152,61,0,110,196,1,202,83,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateRecalculateOrderAmountMethod());
			Methods.Add(CreateLoadCurrencyFromOrderMethod());
		}

		protected override void InitializeUsings() {
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

		protected override SchemaMethod CreateUpdatePrimaryAmountsMethod() {
			SchemaMethod method = base.CreateUpdatePrimaryAmountsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,240,75,77,77,9,74,77,78,204,73,14,40,202,204,77,44,170,12,75,204,41,77,45,214,172,230,229,226,76,74,44,78,213,11,45,72,73,44,73,133,74,58,230,230,151,230,149,20,107,104,90,243,114,213,2,0,89,182,162,134,63,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateRecalculateOrderAmountMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ea9db845-63cd-4be5-bfa8-aca6114feaa4"),
				Name = "RecalculateOrderAmount",
				CreatedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				CreatedInPackageId = new Guid("ff240098-07b4-4e4a-beb2-034c3023bd4e"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,146,193,78,195,48,12,134,207,67,226,29,170,158,82,105,234,11,0,147,182,65,167,29,128,162,13,56,91,173,183,69,74,147,225,58,67,21,226,221,73,154,110,43,160,129,56,112,76,100,255,255,231,223,222,1,69,88,191,68,87,145,198,215,232,70,179,228,102,81,108,176,130,7,139,212,136,199,26,105,106,180,198,130,165,209,105,191,224,22,52,172,145,134,81,124,79,37,82,78,166,180,5,199,201,197,249,217,206,169,178,97,80,227,202,88,205,83,163,108,165,157,135,115,74,199,101,25,222,194,191,166,132,192,56,94,175,9,215,224,45,50,171,91,43,209,251,91,54,91,92,48,201,130,211,133,173,156,225,242,168,29,39,123,195,45,201,10,168,89,254,163,111,254,205,226,104,111,124,8,243,210,185,133,144,210,25,178,23,232,92,159,64,89,188,156,89,89,142,68,8,108,94,182,89,121,154,76,42,70,170,61,99,143,46,252,62,75,222,228,64,80,161,47,17,225,115,106,170,45,144,172,3,99,122,243,98,65,237,23,17,15,247,44,7,54,108,137,186,32,28,87,32,116,96,42,236,245,203,154,19,7,68,53,223,211,53,174,192,42,22,94,71,174,34,177,215,113,215,98,149,74,162,183,243,179,1,33,91,210,174,224,189,151,131,179,250,253,114,60,201,92,215,12,186,192,73,115,231,38,236,146,137,147,46,129,208,244,149,174,131,105,141,210,12,185,216,100,100,170,235,137,56,140,221,130,121,24,104,151,228,7,63,189,147,18,11,183,85,53,18,223,46,54,245,76,222,110,208,187,175,241,95,36,79,221,228,81,57,76,177,64,238,245,139,184,59,174,97,55,192,15,149,121,159,202,53,124,162,236,247,193,14,197,10,84,221,218,190,127,0,133,206,3,98,248,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateLoadCurrencyFromOrderMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6771362d-4a62-41a0-9a22-4cdeee0c610a"),
				Name = "LoadCurrencyFromOrder",
				CreatedInSchemaUId = new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"),
				CreatedInPackageId = new Guid("d6ad04c1-fa0b-4adb-bfd8-17ec17775a03"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,147,65,79,195,48,12,133,207,155,180,255,16,118,234,164,170,192,21,216,16,42,211,196,129,1,27,112,143,18,3,145,218,116,184,73,81,133,248,239,164,77,218,166,99,160,34,245,84,61,127,207,126,118,10,138,132,105,68,144,172,188,225,100,78,150,82,9,85,70,43,80,113,150,232,84,62,211,68,67,48,141,91,205,116,118,62,25,139,23,18,248,101,115,34,117,146,204,200,231,100,60,42,12,50,67,14,184,199,123,44,119,192,61,232,197,74,11,190,8,166,119,86,91,115,71,21,184,45,158,147,74,18,45,211,157,42,45,123,132,160,52,202,74,249,229,91,45,243,119,227,37,225,195,249,109,217,27,164,244,65,3,150,193,83,14,24,103,82,2,83,34,147,145,47,184,165,146,190,2,134,196,54,97,91,40,92,36,166,192,204,102,27,54,240,198,39,186,226,238,103,151,74,212,180,239,215,94,139,66,228,198,113,24,161,81,255,228,108,168,130,65,140,74,216,149,215,74,191,194,172,192,206,190,151,72,216,108,171,191,0,114,228,47,181,70,114,215,99,67,61,184,85,14,76,164,52,89,4,135,115,136,214,52,133,218,169,29,178,233,253,127,216,46,22,15,233,174,109,251,251,245,134,127,120,216,131,220,223,189,197,15,226,215,27,8,123,67,217,186,184,63,102,111,234,99,18,180,193,154,204,79,200,101,23,244,25,57,181,128,53,0,223,0,163,9,187,71,147,3,150,181,115,110,88,10,53,184,247,96,62,247,62,190,1,187,129,164,5,215,3,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OrderProduct_Order_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("315d3b08-1cac-49f5-b7c0-1c7aefe4ef58"));
		}

		#endregion

	}

	#endregion

}

