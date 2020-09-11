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

	#region Class: SupplyPaymentElement_Passport_TerrasoftSchema

	/// <exclude/>
	public class SupplyPaymentElement_Passport_TerrasoftSchema : Terrasoft.Configuration.SupplyPaymentSchema
	{

		#region Constructors: Public

		public SupplyPaymentElement_Passport_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SupplyPaymentElement_Passport_TerrasoftSchema(SupplyPaymentElement_Passport_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SupplyPaymentElement_Passport_TerrasoftSchema(SupplyPaymentElement_Passport_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIeY97HvuWyT8xw8jpwkpEpPnhiUsIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = true,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("3bd175a6-d977-41b0-9091-566ad73135f7");
			index.Name = "IeY97HvuWyT8xw8jpwkpEpPnhiUs";
			index.CreatedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e");
			index.ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e");
			index.CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a");
			EntitySchemaIndexColumn idIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("4f208c25-99a7-4192-a03e-fcb48d4a9abc"),
				ColumnUId = new Guid("ae0e45ca-c495-4fe7-a39d-3ab7278e1617"),
				CreatedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(idIndexColumn);
			EntitySchemaIndexColumn typeIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("6ff85e23-059a-44f7-b128-f5e452ca9c05"),
				ColumnUId = new Guid("dd703360-9b62-47fe-abb5-2f3ff6a57911"),
				CreatedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(typeIdIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e");
			RealUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e");
			Name = "SupplyPaymentElement_Passport_Terrasoft";
			ParentSchemaUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818");
			ExtendParent = false;
			CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializePrimaryOrderColumn() {
			base.InitializePrimaryOrderColumn();
			PrimaryOrderColumn = CreateDatePlanColumn();
			if (Columns.FindByUId(PrimaryOrderColumn.UId) == null) {
				Columns.Add(PrimaryOrderColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("eba7d360-42b7-462d-a77a-9a88bc0341eb")) == null) {
				Columns.Add(CreateDateFactColumn());
			}
			if (Columns.FindByUId(new Guid("0a3324bb-55c8-4791-b51f-409cfedc6fe2")) == null) {
				Columns.Add(CreateStateColumn());
			}
			if (Columns.FindByUId(new Guid("8db4ebad-d676-40ac-8794-e7595b45a380")) == null) {
				Columns.Add(CreateAmountPlanColumn());
			}
			if (Columns.FindByUId(new Guid("17e30b16-182b-49de-b2eb-f3e22b748da4")) == null) {
				Columns.Add(CreateAmountFactColumn());
			}
			if (Columns.FindByUId(new Guid("bffa49c8-f12c-4d40-b2d0-872ff5affd26")) == null) {
				Columns.Add(CreateProductColumn());
			}
			if (Columns.FindByUId(new Guid("b96f2cd9-fee2-4165-85da-7941232abaa8")) == null) {
				Columns.Add(CreateOrderColumn());
			}
			if (Columns.FindByUId(new Guid("0466d76c-ac6c-4404-ab86-769840c37023")) == null) {
				Columns.Add(CreatePreviousElementColumn());
			}
			if (Columns.FindByUId(new Guid("e220d88e-6cd0-40c1-9b5a-4a2f460c48d2")) == null) {
				Columns.Add(CreateInvoiceColumn());
			}
			if (Columns.FindByUId(new Guid("66261c3c-a0a6-4a54-8e50-39752634604e")) == null) {
				Columns.Add(CreateContractColumn());
			}
			if (Columns.FindByUId(new Guid("d72b2f87-802a-4608-b41c-9d271ba1fd0b")) == null) {
				Columns.Add(CreatePrimaryAmountPlanColumn());
			}
			if (Columns.FindByUId(new Guid("9f4daaf1-654c-4f57-9200-73d27570bde0")) == null) {
				Columns.Add(CreatePrimaryAmountFactColumn());
			}
			if (Columns.FindByUId(new Guid("d0235de8-8f51-44ff-98f3-a8f701a34931")) == null) {
				Columns.Add(CreateProductsColumn());
			}
		}

		protected override EntitySchemaColumn CreatePositionColumn() {
			EntitySchemaColumn column = base.CreatePositionColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e");
			return column;
		}

		protected override EntitySchemaColumn CreateTypeColumn() {
			EntitySchemaColumn column = base.CreateTypeColumn();
			column.RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel;
			column.ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e");
			return column;
		}

		protected override EntitySchemaColumn CreateDelayTypeColumn() {
			EntitySchemaColumn column = base.CreateDelayTypeColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Const,
				ValueSource = @"6fc58059-9c4a-4481-8775-bbadf4a4ad51"
			};
			column.ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e");
			return column;
		}

		protected override EntitySchemaColumn CreateDelayColumn() {
			EntitySchemaColumn column = base.CreateDelayColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Const,
				ValueSource = @"0"
			};
			column.ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e");
			return column;
		}

		protected override EntitySchemaColumn CreatePercentageColumn() {
			EntitySchemaColumn column = base.CreatePercentageColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Const,
				ValueSource = @"0"
			};
			column.ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e");
			return column;
		}

		protected virtual EntitySchemaColumn CreateDatePlanColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("72478c19-2ca7-4043-849a-98b8a98379b8"),
				Name = @"DatePlan",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentDate")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateDateFactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("eba7d360-42b7-462d-a77a-9a88bc0341eb"),
				Name = @"DateFact",
				CreatedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d")
			};
		}

		protected virtual EntitySchemaColumn CreateStateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0a3324bb-55c8-4791-b51f-409cfedc6fe2"),
				Name = @"State",
				ReferenceSchemaUId = new Guid("270f817e-6b26-499c-8a5a-61d02846ee36"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"b801edd0-33f8-45ed-aee8-2e26307b0456"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateAmountPlanColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("8db4ebad-d676-40ac-8794-e7595b45a380"),
				Name = @"AmountPlan",
				CreatedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d")
			};
		}

		protected virtual EntitySchemaColumn CreateAmountFactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("17e30b16-182b-49de-b2eb-f3e22b748da4"),
				Name = @"AmountFact",
				CreatedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d")
			};
		}

		protected virtual EntitySchemaColumn CreateProductColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("bffa49c8-f12c-4d40-b2d0-872ff5affd26"),
				Name = @"Product",
				ReferenceSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e"),
				IsIndexed = true,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d")
			};
		}

		protected virtual EntitySchemaColumn CreateOrderColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b96f2cd9-fee2-4165-85da-7941232abaa8"),
				Name = @"Order",
				ReferenceSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d")
			};
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("34a51039-9d1e-4b9d-bbef-f6018add0691"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d")
			};
		}

		protected virtual EntitySchemaColumn CreatePreviousElementColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0466d76c-ac6c-4404-ab86-769840c37023"),
				Name = @"PreviousElement",
				ReferenceSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				IsIndexed = true,
				IsWeakReference = true,
				CreatedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d")
			};
		}

		protected virtual EntitySchemaColumn CreateInvoiceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e220d88e-6cd0-40c1-9b5a-4a2f460c48d2"),
				Name = @"Invoice",
				ReferenceSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				CreatedInPackageId = new Guid("d9ceb238-704d-4d40-8dc8-6e1f79ab2ddb")
			};
		}

		protected virtual EntitySchemaColumn CreateContractColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("66261c3c-a0a6-4a54-8e50-39752634604e"),
				Name = @"Contract",
				ReferenceSchemaUId = new Guid("897be3e4-0333-467d-88e2-b7a945c0d810"),
				IsIndexed = true,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				CreatedInPackageId = new Guid("d9ceb238-704d-4d40-8dc8-6e1f79ab2ddb")
			};
		}

		protected virtual EntitySchemaColumn CreatePrimaryAmountPlanColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("d72b2f87-802a-4608-b41c-9d271ba1fd0b"),
				Name = @"PrimaryAmountPlan",
				CreatedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				CreatedInPackageId = new Guid("d9ceb238-704d-4d40-8dc8-6e1f79ab2ddb")
			};
		}

		protected virtual EntitySchemaColumn CreatePrimaryAmountFactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("9f4daaf1-654c-4f57-9200-73d27570bde0"),
				Name = @"PrimaryAmountFact",
				CreatedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				CreatedInPackageId = new Guid("d9ceb238-704d-4d40-8dc8-6e1f79ab2ddb")
			};
		}

		protected virtual EntitySchemaColumn CreateProductsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("d0235de8-8f51-44ff-98f3-a8f701a34931"),
				Name = @"Products",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIeY97HvuWyT8xw8jpwkpEpPnhiUsIndex());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSupplyPaymentElement_Passport_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSupplyPaymentElement_Passport_TerrasoftEventsProcessSchema() {
			var schema = new SupplyPaymentElement_Passport_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SupplyPaymentElement_Passport_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SupplyPaymentElement_PassportEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SupplyPaymentElement_Passport_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SupplyPaymentElement_Passport_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"));
		}

		#endregion

	}

	#endregion

	#region Class: SupplyPaymentElement_Passport_Terrasoft

	/// <summary>
	/// Installment plan: new entry.
	/// </summary>
	public class SupplyPaymentElement_Passport_Terrasoft : Terrasoft.Configuration.SupplyPayment
	{

		#region Constructors: Public

		public SupplyPaymentElement_Passport_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SupplyPaymentElement_Passport_Terrasoft";
		}

		public SupplyPaymentElement_Passport_Terrasoft(SupplyPaymentElement_Passport_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Due date.
		/// </summary>
		public DateTime DatePlan {
			get {
				return GetTypedColumnValue<DateTime>("DatePlan");
			}
			set {
				SetColumnValue("DatePlan", value);
			}
		}

		/// <summary>
		/// Actual date.
		/// </summary>
		public DateTime DateFact {
			get {
				return GetTypedColumnValue<DateTime>("DateFact");
			}
			set {
				SetColumnValue("DateFact", value);
			}
		}

		/// <exclude/>
		public Guid StateId {
			get {
				return GetTypedColumnValue<Guid>("StateId");
			}
			set {
				SetColumnValue("StateId", value);
				_state = null;
			}
		}

		/// <exclude/>
		public string StateName {
			get {
				return GetTypedColumnValue<string>("StateName");
			}
			set {
				SetColumnValue("StateName", value);
				if (_state != null) {
					_state.Name = value;
				}
			}
		}

		private SupplyPaymentState _state;
		/// <summary>
		/// Status.
		/// </summary>
		public SupplyPaymentState State {
			get {
				return _state ??
					(_state = LookupColumnEntities.GetEntity("State") as SupplyPaymentState);
			}
		}

		/// <summary>
		/// Expected amount.
		/// </summary>
		public Decimal AmountPlan {
			get {
				return GetTypedColumnValue<Decimal>("AmountPlan");
			}
			set {
				SetColumnValue("AmountPlan", value);
			}
		}

		/// <summary>
		/// Actual amount.
		/// </summary>
		public Decimal AmountFact {
			get {
				return GetTypedColumnValue<Decimal>("AmountFact");
			}
			set {
				SetColumnValue("AmountFact", value);
			}
		}

		/// <exclude/>
		public Guid ProductId {
			get {
				return GetTypedColumnValue<Guid>("ProductId");
			}
			set {
				SetColumnValue("ProductId", value);
				_product = null;
			}
		}

		/// <exclude/>
		public string ProductName {
			get {
				return GetTypedColumnValue<string>("ProductName");
			}
			set {
				SetColumnValue("ProductName", value);
				if (_product != null) {
					_product.Name = value;
				}
			}
		}

		private OrderProduct _product;
		/// <summary>
		/// Product.
		/// </summary>
		/// <remarks>
		/// Deprecated.
		/// </remarks>
		public OrderProduct Product {
			get {
				return _product ??
					(_product = LookupColumnEntities.GetEntity("Product") as OrderProduct);
			}
		}

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

		/// <summary>
		/// Name.
		/// </summary>
		public string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

		/// <exclude/>
		public Guid PreviousElementId {
			get {
				return GetTypedColumnValue<Guid>("PreviousElementId");
			}
			set {
				SetColumnValue("PreviousElementId", value);
				_previousElement = null;
			}
		}

		/// <exclude/>
		public string PreviousElementName {
			get {
				return GetTypedColumnValue<string>("PreviousElementName");
			}
			set {
				SetColumnValue("PreviousElementName", value);
				if (_previousElement != null) {
					_previousElement.Name = value;
				}
			}
		}

		private SupplyPaymentElement _previousElement;
		/// <summary>
		/// Previous entry.
		/// </summary>
		public SupplyPaymentElement PreviousElement {
			get {
				return _previousElement ??
					(_previousElement = LookupColumnEntities.GetEntity("PreviousElement") as SupplyPaymentElement);
			}
		}

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

		/// <exclude/>
		public Guid ContractId {
			get {
				return GetTypedColumnValue<Guid>("ContractId");
			}
			set {
				SetColumnValue("ContractId", value);
				_contract = null;
			}
		}

		/// <exclude/>
		public string ContractNumber {
			get {
				return GetTypedColumnValue<string>("ContractNumber");
			}
			set {
				SetColumnValue("ContractNumber", value);
				if (_contract != null) {
					_contract.Number = value;
				}
			}
		}

		private Contract _contract;
		/// <summary>
		/// Contract.
		/// </summary>
		public Contract Contract {
			get {
				return _contract ??
					(_contract = LookupColumnEntities.GetEntity("Contract") as Contract);
			}
		}

		/// <summary>
		/// Expected amount, base currency.
		/// </summary>
		public Decimal PrimaryAmountPlan {
			get {
				return GetTypedColumnValue<Decimal>("PrimaryAmountPlan");
			}
			set {
				SetColumnValue("PrimaryAmountPlan", value);
			}
		}

		/// <summary>
		/// Actual amount, base currency.
		/// </summary>
		public Decimal PrimaryAmountFact {
			get {
				return GetTypedColumnValue<Decimal>("PrimaryAmountFact");
			}
			set {
				SetColumnValue("PrimaryAmountFact", value);
			}
		}

		/// <summary>
		/// Products.
		/// </summary>
		public string Products {
			get {
				return GetTypedColumnValue<string>("Products");
			}
			set {
				SetColumnValue("Products", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SupplyPaymentElement_PassportEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SupplyPaymentElement_Passport_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("SupplyPaymentElement_Passport_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("SupplyPaymentElement_Passport_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("SupplyPaymentElement_Passport_TerrasoftSaving", e);
			Updated += (s, e) => ThrowEvent("SupplyPaymentElement_Passport_TerrasoftUpdated", e);
			Validating += (s, e) => ThrowEvent("SupplyPaymentElement_Passport_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SupplyPaymentElement_Passport_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: SupplyPaymentElement_PassportEventsProcess

	/// <exclude/>
	public partial class SupplyPaymentElement_PassportEventsProcess<TEntity> : Terrasoft.Configuration.SupplyPayment_PassportEventsProcess<TEntity> where TEntity : SupplyPaymentElement_Passport_Terrasoft
	{

		public SupplyPaymentElement_PassportEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SupplyPaymentElement_PassportEventsProcess";
			SchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual bool DoNotUpdateLinkedElements {
			get;
			set;
		}

		public virtual bool NeedToUpdateInvoice {
			get;
			set;
		}

		public virtual bool NeedToUpdateOrderPaymentAmount {
			get;
			set;
		}

		public virtual bool IsInvoiceExists {
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
					SchemaElementUId = new Guid("88d39c80-d385-4069-9ec4-30b36e97c5a9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _supplyPaymentElementSaved;
		public ProcessFlowElement SupplyPaymentElementSaved {
			get {
				return _supplyPaymentElementSaved ?? (_supplyPaymentElementSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SupplyPaymentElementSaved",
					SchemaElementUId = new Guid("55194912-0cee-4f96-9da6-fe041197c3f7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("5b1db116-ccdf-45eb-81f5-1506f4680f1c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
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
					SchemaElementUId = new Guid("a216c70e-29ed-4f63-84b3-7d65596d9a8b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _supplyPaymentElementSavingStartMessage;
		public ProcessFlowElement SupplyPaymentElementSavingStartMessage {
			get {
				return _supplyPaymentElementSavingStartMessage ?? (_supplyPaymentElementSavingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SupplyPaymentElementSavingStartMessage",
					SchemaElementUId = new Guid("56a05eca-743e-4d54-93d6-cca831c2cf98"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _checkInvoiceNeedUpdateScriptTask;
		public ProcessScriptTask CheckInvoiceNeedUpdateScriptTask {
			get {
				return _checkInvoiceNeedUpdateScriptTask ?? (_checkInvoiceNeedUpdateScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CheckInvoiceNeedUpdateScriptTask",
					SchemaElementUId = new Guid("0ea07475-f856-4e3d-9b58-b6b745da3991"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CheckInvoiceNeedUpdateScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _supplyPaymentElementDeletedEventSubProcess;
		public ProcessFlowElement SupplyPaymentElementDeletedEventSubProcess {
			get {
				return _supplyPaymentElementDeletedEventSubProcess ?? (_supplyPaymentElementDeletedEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SupplyPaymentElementDeletedEventSubProcess",
					SchemaElementUId = new Guid("e4bee66c-0ff7-42e7-9824-f214e0d3fb5e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _supplyPaymentElementDeletedStartMessage;
		public ProcessFlowElement SupplyPaymentElementDeletedStartMessage {
			get {
				return _supplyPaymentElementDeletedStartMessage ?? (_supplyPaymentElementDeletedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SupplyPaymentElementDeletedStartMessage",
					SchemaElementUId = new Guid("1792cffb-b8de-44c5-b48e-1b23db8f8b95"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _onDeleteScriptTask;
		public ProcessScriptTask OnDeleteScriptTask {
			get {
				return _onDeleteScriptTask ?? (_onDeleteScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OnDeleteScriptTask",
					SchemaElementUId = new Guid("1a4223a7-90ba-442c-9b5b-01688c42ef3c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OnDeleteScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess3_d7a18bd282c54b13836036d86a86368d;
		public ProcessFlowElement EventSubProcess3_d7a18bd282c54b13836036d86a86368d {
			get {
				return _eventSubProcess3_d7a18bd282c54b13836036d86a86368d ?? (_eventSubProcess3_d7a18bd282c54b13836036d86a86368d = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3_d7a18bd282c54b13836036d86a86368d",
					SchemaElementUId = new Guid("d7a18bd2-82c5-4b13-8360-36d86a86368d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3_53d7f47c41274e0fb1ee96cc0619f7d2;
		public ProcessFlowElement StartMessage3_53d7f47c41274e0fb1ee96cc0619f7d2 {
			get {
				return _startMessage3_53d7f47c41274e0fb1ee96cc0619f7d2 ?? (_startMessage3_53d7f47c41274e0fb1ee96cc0619f7d2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3_53d7f47c41274e0fb1ee96cc0619f7d2",
					SchemaElementUId = new Guid("53d7f47c-4127-4e0f-b1ee-96cc0619f7d2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _updateSupplyPaymentInvoiceScriptTask;
		public ProcessScriptTask UpdateSupplyPaymentInvoiceScriptTask {
			get {
				return _updateSupplyPaymentInvoiceScriptTask ?? (_updateSupplyPaymentInvoiceScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "UpdateSupplyPaymentInvoiceScriptTask",
					SchemaElementUId = new Guid("09f2781c-5316-43ab-a946-23280be5e4c1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = UpdateSupplyPaymentInvoiceScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[SupplyPaymentElementSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { SupplyPaymentElementSaved };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[SupplyPaymentElementSavingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SupplyPaymentElementSavingStartMessage };
			FlowElements[CheckInvoiceNeedUpdateScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckInvoiceNeedUpdateScriptTask };
			FlowElements[SupplyPaymentElementDeletedEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { SupplyPaymentElementDeletedEventSubProcess };
			FlowElements[SupplyPaymentElementDeletedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SupplyPaymentElementDeletedStartMessage };
			FlowElements[OnDeleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OnDeleteScriptTask };
			FlowElements[EventSubProcess3_d7a18bd282c54b13836036d86a86368d.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3_d7a18bd282c54b13836036d86a86368d };
			FlowElements[StartMessage3_53d7f47c41274e0fb1ee96cc0619f7d2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3_53d7f47c41274e0fb1ee96cc0619f7d2 };
			FlowElements[UpdateSupplyPaymentInvoiceScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { UpdateSupplyPaymentInvoiceScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "SupplyPaymentElementSaved":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "ScriptTask1":
						break;
					case "EventSubProcess2":
						break;
					case "SupplyPaymentElementSavingStartMessage":
						e.Context.QueueTasks.Enqueue("CheckInvoiceNeedUpdateScriptTask");
						break;
					case "CheckInvoiceNeedUpdateScriptTask":
						break;
					case "SupplyPaymentElementDeletedEventSubProcess":
						break;
					case "SupplyPaymentElementDeletedStartMessage":
						e.Context.QueueTasks.Enqueue("OnDeleteScriptTask");
						break;
					case "OnDeleteScriptTask":
						break;
					case "EventSubProcess3_d7a18bd282c54b13836036d86a86368d":
						break;
					case "StartMessage3_53d7f47c41274e0fb1ee96cc0619f7d2":
						e.Context.QueueTasks.Enqueue("UpdateSupplyPaymentInvoiceScriptTask");
						break;
					case "UpdateSupplyPaymentInvoiceScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("SupplyPaymentElementSaved");
			ActivatedEventElements.Add("SupplyPaymentElementSavingStartMessage");
			ActivatedEventElements.Add("SupplyPaymentElementDeletedStartMessage");
			ActivatedEventElements.Add("StartMessage3_53d7f47c41274e0fb1ee96cc0619f7d2");
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
				case "SupplyPaymentElementSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "SupplyPaymentElementSaved";
					result = SupplyPaymentElementSaved.Execute(context);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "SupplyPaymentElementSavingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SupplyPaymentElementSavingStartMessage";
					result = SupplyPaymentElementSavingStartMessage.Execute(context);
					break;
				case "CheckInvoiceNeedUpdateScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CheckInvoiceNeedUpdateScriptTask";
					result = CheckInvoiceNeedUpdateScriptTask.Execute(context, CheckInvoiceNeedUpdateScriptTaskExecute);
					break;
				case "SupplyPaymentElementDeletedEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "SupplyPaymentElementDeletedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SupplyPaymentElementDeletedStartMessage";
					result = SupplyPaymentElementDeletedStartMessage.Execute(context);
					break;
				case "OnDeleteScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OnDeleteScriptTask";
					result = OnDeleteScriptTask.Execute(context, OnDeleteScriptTaskExecute);
					break;
				case "EventSubProcess3_d7a18bd282c54b13836036d86a86368d":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3_53d7f47c41274e0fb1ee96cc0619f7d2":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3_53d7f47c41274e0fb1ee96cc0619f7d2";
					result = StartMessage3_53d7f47c41274e0fb1ee96cc0619f7d2.Execute(context);
					break;
				case "UpdateSupplyPaymentInvoiceScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "UpdateSupplyPaymentInvoiceScriptTask";
					result = UpdateSupplyPaymentInvoiceScriptTask.Execute(context, UpdateSupplyPaymentInvoiceScriptTaskExecute);
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
				case "IsInvoiceExists":
					IsInvoiceExists = reader.GetValue<System.Boolean>();
				break;
				case "NeedToUpdateOrderPaymentAmount":
					NeedToUpdateOrderPaymentAmount = reader.GetValue<System.Boolean>();
				break;
				case "NeedToUpdateInvoice":
					NeedToUpdateInvoice = reader.GetValue<System.Boolean>();
				break;
				case "DoNotUpdateLinkedElements":
					DoNotUpdateLinkedElements = reader.GetValue<System.Boolean>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			UpdateLinkedElements();
			OnSaved();
			return true;
		}

		public virtual bool CheckInvoiceNeedUpdateScriptTaskExecute(ProcessExecutingContext context) {
			CheckNeedToUpdateInvoice();
			return true;
		}

		public virtual bool OnDeleteScriptTaskExecute(ProcessExecutingContext context) {
			OnDeleted();
			return true;
		}

		public virtual bool UpdateSupplyPaymentInvoiceScriptTaskExecute(ProcessExecutingContext context) {
			Guid invoiceId = Entity.GetTypedColumnValue<Guid>("InvoiceId");
			Guid invoiceOldId = Entity.GetTypedOldColumnValue<Guid>("InvoiceId");
			if (invoiceId != invoiceOldId) {
				var orderPassportHelper = ClassFactory.Get<OrderPassportHelper>(new ConstructorArgument("userConnection", UserConnection));
				var orderAmountHelper = ClassFactory.Get<OrderAmountHelper>(new ConstructorArgument("userConnection", UserConnection));
				var supplyPaymentElementId = Entity.GetTypedColumnValue<Guid>("Id");
				if (IsInvoiceExists) {
					invoiceId = Entity.GetTypedColumnValue<Guid>("InvoiceId");
					orderPassportHelper.BindSupplyPaymentElementInvoice(supplyPaymentElementId, invoiceId);
				}
				else {
					invoiceId = Entity.GetTypedOldColumnValue<Guid>("InvoiceId");
					orderPassportHelper.UnbindSupplyPaymentElementInvoice(supplyPaymentElementId, invoiceOldId);
					orderAmountHelper.UpdateOrderPaymentAmountOnSPEChanged(Entity.PrimaryColumnValue);
				}
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "SupplyPaymentElement_Passport_TerrasoftSaved":
							if (ActivatedEventElements.Contains("SupplyPaymentElementSaved")) {
							context.QueueTasks.Enqueue("SupplyPaymentElementSaved");
						}
						break;
					case "SupplyPaymentElement_Passport_TerrasoftSaving":
							if (ActivatedEventElements.Contains("SupplyPaymentElementSavingStartMessage")) {
							context.QueueTasks.Enqueue("SupplyPaymentElementSavingStartMessage");
						}
						break;
					case "SupplyPaymentElement_Passport_TerrasoftDeleted":
							if (ActivatedEventElements.Contains("SupplyPaymentElementDeletedStartMessage")) {
							context.QueueTasks.Enqueue("SupplyPaymentElementDeletedStartMessage");
						}
						break;
					case "SupplyPaymentElement_Passport_TerrasoftUpdated":
							if (ActivatedEventElements.Contains("StartMessage3_53d7f47c41274e0fb1ee96cc0619f7d2")) {
							context.QueueTasks.Enqueue("StartMessage3_53d7f47c41274e0fb1ee96cc0619f7d2");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("IsInvoiceExists") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsInvoiceExists", IsInvoiceExists, false);
			}
			if (!HasMapping("NeedToUpdateOrderPaymentAmount") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("NeedToUpdateOrderPaymentAmount", NeedToUpdateOrderPaymentAmount, false);
			}
			if (!HasMapping("NeedToUpdateInvoice") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("NeedToUpdateInvoice", NeedToUpdateInvoice, false);
			}
			if (!HasMapping("DoNotUpdateLinkedElements") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("DoNotUpdateLinkedElements", DoNotUpdateLinkedElements, false);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: SupplyPaymentElement_PassportEventsProcess

	/// <exclude/>
	public class SupplyPaymentElement_PassportEventsProcess : SupplyPaymentElement_PassportEventsProcess<SupplyPaymentElement_Passport_Terrasoft>
	{

		public SupplyPaymentElement_PassportEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SupplyPaymentElement_PassportEventsProcess

	public partial class SupplyPaymentElement_PassportEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void UpdateLinkedElements() {
			var passportHelper = ClassFactory.Get<OrderPassportHelper>(new ConstructorArgument("userConnection", UserConnection));
			passportHelper.UpdateLinkedElements(Entity);
		}

		public virtual void CheckNeedToUpdateInvoice() {
			List<string> changedColumnNames = Entity.GetChangedColumnValues().ToList().ConvertAll(cv => cv.Column.Name);
			IsInvoiceExists = Entity.GetTypedColumnValue<Guid>("InvoiceId") != Guid.Empty;
			NeedToUpdateInvoice = IsInvoiceExists && changedColumnNames.Any(c => c == "PrimaryAmountPlan");
			NeedToUpdateOrderPaymentAmount = changedColumnNames.Any(c => c == "PrimaryAmountFact");
		}

		public virtual void OnDeleted() {
			var orderAmountHelper = ClassFactory.Get<OrderAmountHelper>(new ConstructorArgument("userConnection", UserConnection));
			orderAmountHelper.UpdateOrderPaymentAmountOnSupplyPaymentElementDeleted(Entity.GetTypedColumnValue<Guid>("OrderId"));
		}

		public virtual void OnSaved() {
			var orderAmountHelper = ClassFactory.Get<OrderAmountHelper>(new ConstructorArgument("userConnection", UserConnection));
			if (NeedToUpdateInvoice) {
				EntitySchemaColumn invoiceColumn = Entity.Schema.Columns.GetByName("Invoice");
				if (!Entity.GetIsColumnValueLoaded(invoiceColumn) || Entity.GetTypedColumnValue<Guid>(invoiceColumn) != Guid.Empty) {
					orderAmountHelper.UpdateInvoiceBySupplyPaymentElementId(Entity.PrimaryColumnValue);
				}
			}
			if (NeedToUpdateOrderPaymentAmount) {
				orderAmountHelper.UpdateOrderPaymentAmountOnSPEChanged(Entity.PrimaryColumnValue);
			}
		}

		#endregion

	}

	#endregion

	#region Class: SupplyPaymentElement_Passport_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class SupplyPaymentElement_Passport_TerrasoftEventsProcessSchema : Terrasoft.Configuration.SupplyPaymentEventsProcessSchema
	{

		#region Constructors: Public

		public SupplyPaymentElement_Passport_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SupplyPaymentElement_Passport_TerrasoftEventsProcessSchema(SupplyPaymentElement_Passport_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SupplyPaymentElement_PassportEventsProcess";
			UId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc");
			CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("db60083d-10e3-43cb-8693-cadea909585f");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateDoNotUpdateLinkedElementsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("192fda80-870c-42b1-9083-93d1497c34a0"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				Name = @"DoNotUpdateLinkedElements",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNeedToUpdateInvoiceParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("22aac5fa-56f9-45bb-8b6d-5823d08cebad"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				Name = @"NeedToUpdateInvoice",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNeedToUpdateOrderPaymentAmountParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("8c98d084-c342-4e61-a78d-4e9b1aedfd65"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				Name = @"NeedToUpdateOrderPaymentAmount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsInvoiceExistsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a9d0095b-4dce-482b-90ee-3cf1ffda4b01"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				Name = @"IsInvoiceExists",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateDoNotUpdateLinkedElementsParameter());
			Parameters.Add(CreateNeedToUpdateInvoiceParameter());
			Parameters.Add(CreateNeedToUpdateOrderPaymentAmountParameter());
			Parameters.Add(CreateIsInvoiceExistsParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess supplypaymentelementdeletedeventsubprocess = CreateSupplyPaymentElementDeletedEventSubProcessEventSubProcess();
			FlowElements.Add(supplypaymentelementdeletedeventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess3_d7a18bd282c54b13836036d86a86368d = CreateEventSubProcess3_d7a18bd282c54b13836036d86a86368dEventSubProcess();
			FlowElements.Add(eventsubprocess3_d7a18bd282c54b13836036d86a86368d);
			ProcessSchemaStartMessageEvent supplypaymentelementsaved = CreateSupplyPaymentElementSavedStartMessageEvent();
			eventsubprocess1.FlowElements.Add(supplypaymentelementsaved);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			eventsubprocess1.FlowElements.Add(scripttask1);
			ProcessSchemaStartMessageEvent supplypaymentelementsavingstartmessage = CreateSupplyPaymentElementSavingStartMessageStartMessageEvent();
			eventsubprocess2.FlowElements.Add(supplypaymentelementsavingstartmessage);
			ProcessSchemaScriptTask checkinvoiceneedupdatescripttask = CreateCheckInvoiceNeedUpdateScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(checkinvoiceneedupdatescripttask);
			ProcessSchemaStartMessageEvent supplypaymentelementdeletedstartmessage = CreateSupplyPaymentElementDeletedStartMessageStartMessageEvent();
			supplypaymentelementdeletedeventsubprocess.FlowElements.Add(supplypaymentelementdeletedstartmessage);
			ProcessSchemaScriptTask ondeletescripttask = CreateOnDeleteScriptTaskScriptTask();
			supplypaymentelementdeletedeventsubprocess.FlowElements.Add(ondeletescripttask);
			ProcessSchemaStartMessageEvent startmessage3_53d7f47c41274e0fb1ee96cc0619f7d2 = CreateStartMessage3_53d7f47c41274e0fb1ee96cc0619f7d2StartMessageEvent();
			eventsubprocess3_d7a18bd282c54b13836036d86a86368d.FlowElements.Add(startmessage3_53d7f47c41274e0fb1ee96cc0619f7d2);
			ProcessSchemaScriptTask updatesupplypaymentinvoicescripttask = CreateUpdateSupplyPaymentInvoiceScriptTaskScriptTask();
			eventsubprocess3_d7a18bd282c54b13836036d86a86368d.FlowElements.Add(updatesupplypaymentinvoicescripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4_6c351d9595ee402dbef3e0eb2e8a4820SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("78510dc0-e198-46eb-8fce-4c7fad9097fb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("db60083d-10e3-43cb-8693-cadea909585f"),
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d"),
				CreatedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				CurveCenterPosition = new Point(259, 94),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("55194912-0cee-4f96-9da6-fe041197c3f7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5b1db116-ccdf-45eb-81f5-1506f4680f1c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("eb4e3667-1401-41e4-8a5a-857971b24d12"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("db60083d-10e3-43cb-8693-cadea909585f"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				CreatedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				CurveCenterPosition = new Point(160, 94),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("56a05eca-743e-4d54-93d6-cca831c2cf98"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0ea07475-f856-4e3d-9b58-b6b745da3991"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("c1e95ea8-edb3-4f4f-84cc-e67a48b972c2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("db60083d-10e3-43cb-8693-cadea909585f"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				CreatedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				CurveCenterPosition = new Point(616, 98),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1792cffb-b8de-44c5-b48e-1b23db8f8b95"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1a4223a7-90ba-442c-9b5b-01688c42ef3c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4_6c351d9595ee402dbef3e0eb2e8a4820SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4_6c351d9595ee402dbef3e0eb2e8a4820",
				UId = new Guid("6c351d95-95ee-402d-bef3-e0eb2e8a4820"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("db60083d-10e3-43cb-8693-cadea909585f"),
				CreatedInPackageId = new Guid("0e488ac0-fe51-4dc3-8d9a-11caac414976"),
				CreatedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("53d7f47c-4127-4e0f-b1ee-96cc0619f7d2"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("09f2781c-5316-43ab-a946-23280be5e4c1"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("f0654747-d48c-4458-a3ad-cee4a797413e"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("db60083d-10e3-43cb-8693-cadea909585f"),
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d"),
				CreatedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1189, 205),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("71f1a514-7487-4ae2-8235-356ebe193ccf"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("f0654747-d48c-4458-a3ad-cee4a797413e"),
				CreatedInOwnerSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d"),
				CreatedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1160, 205),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("88d39c80-d385-4069-9ec4-30b36e97c5a9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("71f1a514-7487-4ae2-8235-356ebe193ccf"),
				CreatedInOwnerSchemaUId = new Guid("db60083d-10e3-43cb-8693-cadea909585f"),
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d"),
				CreatedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(266, 21),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(216, 131),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSupplyPaymentElementSavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("55194912-0cee-4f96-9da6-fe041197c3f7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("88d39c80-d385-4069-9ec4-30b36e97c5a9"),
				CreatedInOwnerSchemaUId = new Guid("db60083d-10e3-43cb-8693-cadea909585f"),
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d"),
				CreatedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SupplyPaymentElementSaved",
				ModifiedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				Name = @"SupplyPaymentElementSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5b1db116-ccdf-45eb-81f5-1506f4680f1c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("88d39c80-d385-4069-9ec4-30b36e97c5a9"),
				CreatedInOwnerSchemaUId = new Guid("db60083d-10e3-43cb-8693-cadea909585f"),
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d"),
				CreatedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				Name = @"ScriptTask1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(105, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,72,73,44,73,245,201,204,203,78,77,113,205,73,205,77,205,43,41,214,208,180,230,229,242,207,11,78,44,75,77,1,179,139,82,75,74,139,242,20,74,138,74,83,173,1,86,123,206,73,49,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a216c70e-29ed-4f63-84b3-7d65596d9a8b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("71f1a514-7487-4ae2-8235-356ebe193ccf"),
				CreatedInOwnerSchemaUId = new Guid("db60083d-10e3-43cb-8693-cadea909585f"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				CreatedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(42, 21),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(212, 170),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSupplyPaymentElementSavingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("56a05eca-743e-4d54-93d6-cca831c2cf98"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a216c70e-29ed-4f63-84b3-7d65596d9a8b"),
				CreatedInOwnerSchemaUId = new Guid("db60083d-10e3-43cb-8693-cadea909585f"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				CreatedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SupplyPaymentElementSaving",
				ModifiedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				Name = @"SupplyPaymentElementSavingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCheckInvoiceNeedUpdateScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0ea07475-f856-4e3d-9b58-b6b745da3991"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a216c70e-29ed-4f63-84b3-7d65596d9a8b"),
				CreatedInOwnerSchemaUId = new Guid("db60083d-10e3-43cb-8693-cadea909585f"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				CreatedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				Name = @"CheckInvoiceNeedUpdateScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(93, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,206,72,77,206,246,75,77,77,9,201,15,45,72,73,44,73,245,204,43,203,207,76,78,213,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,97,141,42,128,41,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSupplyPaymentElementDeletedEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSupplyPaymentElementDeletedEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e4bee66c-0ff7-42e7-9824-f214e0d3fb5e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("71f1a514-7487-4ae2-8235-356ebe193ccf"),
				CreatedInOwnerSchemaUId = new Guid("db60083d-10e3-43cb-8693-cadea909585f"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				CreatedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				Name = @"SupplyPaymentElementDeletedEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(490, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(222, 142),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSupplyPaymentElementDeletedEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSupplyPaymentElementDeletedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("1792cffb-b8de-44c5-b48e-1b23db8f8b95"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e4bee66c-0ff7-42e7-9824-f214e0d3fb5e"),
				CreatedInOwnerSchemaUId = new Guid("db60083d-10e3-43cb-8693-cadea909585f"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				CreatedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SupplyPaymentElementDeleted",
				ModifiedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				Name = @"SupplyPaymentElementDeletedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(14, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOnDeleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1a4223a7-90ba-442c-9b5b-01688c42ef3c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e4bee66c-0ff7-42e7-9824-f214e0d3fb5e"),
				CreatedInOwnerSchemaUId = new Guid("db60083d-10e3-43cb-8693-cadea909585f"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				CreatedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				Name = @"OnDeleteScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(112, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,115,73,205,73,45,73,77,209,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,249,5,76,61,26,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3_d7a18bd282c54b13836036d86a86368dEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3_d7a18bd282c54b13836036d86a86368d = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("d7a18bd2-82c5-4b13-8360-36d86a86368d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("71f1a514-7487-4ae2-8235-356ebe193ccf"),
				CreatedInOwnerSchemaUId = new Guid("db60083d-10e3-43cb-8693-cadea909585f"),
				CreatedInPackageId = new Guid("0e488ac0-fe51-4dc3-8d9a-11caac414976"),
				CreatedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				Name = @"EventSubProcess3_d7a18bd282c54b13836036d86a86368d",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(42, 240),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(211, 160),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3_d7a18bd282c54b13836036d86a86368d;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage3_53d7f47c41274e0fb1ee96cc0619f7d2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("53d7f47c-4127-4e0f-b1ee-96cc0619f7d2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d7a18bd2-82c5-4b13-8360-36d86a86368d"),
				CreatedInOwnerSchemaUId = new Guid("db60083d-10e3-43cb-8693-cadea909585f"),
				CreatedInPackageId = new Guid("0e488ac0-fe51-4dc3-8d9a-11caac414976"),
				CreatedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SupplyPaymentElementUpdated",
				ModifiedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				Name = @"StartMessage3_53d7f47c41274e0fb1ee96cc0619f7d2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(23, 50),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateUpdateSupplyPaymentInvoiceScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("09f2781c-5316-43ab-a946-23280be5e4c1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d7a18bd2-82c5-4b13-8360-36d86a86368d"),
				CreatedInOwnerSchemaUId = new Guid("db60083d-10e3-43cb-8693-cadea909585f"),
				CreatedInPackageId = new Guid("0e488ac0-fe51-4dc3-8d9a-11caac414976"),
				CreatedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				Name = @"UpdateSupplyPaymentInvoiceScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(92, 36),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,82,203,106,195,48,16,60,219,95,161,250,228,64,200,15,228,1,169,113,221,156,98,72,211,187,26,109,82,129,188,50,43,41,173,41,249,247,202,118,218,56,212,224,64,122,18,172,102,103,102,119,39,115,82,48,137,71,45,119,176,18,108,206,82,180,210,86,147,12,236,75,85,130,72,180,114,5,190,114,229,96,150,121,236,34,142,86,63,232,104,52,13,179,78,255,90,137,62,10,95,30,98,145,123,22,95,76,60,204,175,24,71,236,43,12,142,156,152,38,1,148,115,99,74,77,246,25,84,9,228,213,18,229,43,79,124,103,53,53,154,179,245,95,216,34,70,248,96,137,70,99,201,213,200,37,29,92,1,104,227,200,25,32,255,129,176,179,82,99,52,102,219,171,194,200,187,187,136,47,11,237,112,72,186,11,250,7,97,227,202,82,85,57,175,234,182,84,65,253,220,122,169,102,185,65,189,221,149,57,47,60,253,148,198,154,102,167,193,29,119,15,130,158,107,76,30,37,138,77,159,223,182,53,238,159,101,124,9,96,205,124,10,3,80,6,134,28,222,16,171,126,147,91,124,187,207,102,155,202,95,250,238,189,39,219,82,112,11,231,8,54,253,237,247,26,55,121,154,188,115,60,128,136,207,147,228,36,11,78,85,103,138,118,252,83,72,96,29,33,243,153,129,233,55,218,127,165,105,162,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateUpdateLinkedElementsMethod());
			Methods.Add(CreateCheckNeedToUpdateInvoiceMethod());
			Methods.Add(CreateOnDeletedMethod());
			Methods.Add(CreateOnSavedMethod());
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
				UId = new Guid("c442178e-14df-43af-a229-af2fa82d362d"),
				Name = "Terrasoft.Configuration.Passport",
				Alias = "",
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("05c69784-4475-4d19-bd6f-240b54e6e627"),
				Name = "System.Linq",
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

		protected virtual SchemaMethod CreateUpdateLinkedElementsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e7921d38-b864-44fa-9fcc-613fd8e82fed"),
				Name = "UpdateLinkedElements",
				CreatedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,141,75,10,194,48,20,69,231,174,34,116,148,130,116,3,126,64,74,173,3,161,78,186,128,208,92,36,24,95,194,203,139,165,187,55,29,102,122,238,225,220,159,97,21,77,74,49,176,60,224,35,88,93,84,239,11,185,155,69,2,111,221,8,57,79,108,193,175,74,187,106,194,170,250,64,73,56,239,230,141,223,249,11,18,221,228,4,46,3,97,17,23,168,57,170,185,2,109,123,58,212,151,221,28,173,17,60,29,125,96,7,143,61,147,244,64,226,100,43,242,31,192,240,102,145,164,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCheckNeedToUpdateInvoiceMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d4653ee2-ccbc-4843-831a-28b6602da4e2"),
				Name = "CheckNeedToUpdateInvoice",
				CreatedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,207,207,138,194,48,16,6,240,187,224,59,196,30,164,189,228,5,214,8,165,84,41,136,246,208,221,123,72,6,13,36,147,146,76,203,230,237,141,127,14,171,236,197,91,72,190,249,125,147,131,137,180,137,20,12,158,183,76,93,36,158,65,55,222,78,14,143,210,65,100,130,181,72,134,18,223,3,53,127,159,127,164,157,32,150,21,31,252,33,27,249,208,120,156,33,80,109,109,169,102,38,50,55,243,71,150,223,172,234,107,185,232,98,135,179,55,10,218,223,60,243,170,15,105,124,177,55,251,201,232,109,89,60,39,58,93,84,108,37,216,237,150,183,110,164,148,189,35,128,30,252,247,168,37,193,51,151,205,247,150,245,250,159,159,241,26,83,169,238,107,50,33,88,209,7,227,100,72,181,243,19,82,111,37,22,213,91,193,41,104,8,189,76,14,144,30,177,220,245,33,188,147,138,50,124,5,201,180,238,150,118,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnDeletedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5936b84c-a7cb-4c6b-8700-52c4d941f695"),
				Name = "OnDeleted",
				CreatedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,142,193,10,194,48,16,68,239,130,255,16,114,106,65,250,3,214,66,169,181,122,170,160,245,30,154,69,10,233,38,108,54,74,254,222,182,122,81,79,3,51,195,188,121,40,18,150,52,80,57,218,128,124,4,227,128,196,78,84,70,121,127,80,61,91,138,89,3,156,183,191,165,34,65,120,138,202,162,103,10,115,175,164,123,24,1,57,145,193,3,77,1,66,207,131,69,185,17,221,151,145,166,219,245,234,15,154,117,78,43,134,133,115,86,113,94,122,199,45,94,130,115,38,126,204,218,192,44,123,48,192,160,147,26,121,224,229,226,53,58,208,149,53,97,196,155,50,1,242,38,12,186,72,228,178,120,210,114,194,190,0,2,125,0,22,238,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnSavedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ecfcd7db-e960-4c55-b916-84d3c6f48637"),
				Name = "OnSaved",
				CreatedInSchemaUId = new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,145,209,106,194,48,20,134,175,91,240,29,98,175,82,24,125,129,89,65,75,231,10,67,11,213,221,135,230,76,3,77,82,210,196,17,102,223,125,198,20,102,45,178,171,144,115,190,63,255,127,78,206,68,33,169,40,168,21,151,70,232,119,104,90,80,40,69,89,67,186,238,141,212,90,42,155,108,64,47,118,143,208,18,11,248,70,153,20,157,86,198,113,43,117,52,28,132,198,145,233,64,93,27,2,106,205,164,136,94,208,97,84,136,227,215,89,200,190,16,222,2,208,189,60,180,148,104,40,196,89,178,26,98,244,51,11,131,92,104,166,109,85,159,128,147,76,54,134,11,196,124,127,184,165,200,35,137,103,18,95,238,92,210,181,221,18,14,56,26,30,140,156,89,224,220,230,131,228,202,20,157,23,124,146,198,192,135,36,20,40,30,25,196,232,114,65,127,252,222,182,64,239,36,139,141,97,116,249,40,153,167,200,213,147,156,183,218,250,65,130,201,110,147,209,184,107,91,153,182,109,108,73,172,91,93,222,128,59,10,138,7,239,82,49,78,148,189,179,190,141,211,207,194,126,186,194,219,23,13,47,121,75,31,226,89,134,41,191,19,85,153,103,39,34,142,240,79,132,254,23,235,45,97,47,57,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SupplyPaymentElement_Passport_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9f1bb66e-53fb-4b4b-9451-58b32cb493dc"));
		}

		#endregion

	}

	#endregion

}

