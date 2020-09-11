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

	#region Class: BaseProductEntry_Base_TerrasoftSchema

	/// <exclude/>
	[IsVirtual]
	public class BaseProductEntry_Base_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public BaseProductEntry_Base_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BaseProductEntry_Base_TerrasoftSchema(BaseProductEntry_Base_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BaseProductEntry_Base_TerrasoftSchema(BaseProductEntry_Base_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4");
			RealUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4");
			Name = "BaseProductEntry_Base_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
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

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("369b4363-6804-473b-92a5-4ee233772082")) == null) {
				Columns.Add(CreateNotesColumn());
			}
			if (Columns.FindByUId(new Guid("a977122d-8f0c-49be-a0ce-bb9faf81bdc6")) == null) {
				Columns.Add(CreateProductColumn());
			}
			if (Columns.FindByUId(new Guid("237ca70c-b45e-46e8-a8eb-67e30584af32")) == null) {
				Columns.Add(CreateCustomProductColumn());
			}
			if (Columns.FindByUId(new Guid("5db18b1c-a7b8-4bd2-bb00-60e6f3663da3")) == null) {
				Columns.Add(CreateDeliveryDateColumn());
			}
			if (Columns.FindByUId(new Guid("c4e45448-ad41-4fc8-9c8b-904790d003ff")) == null) {
				Columns.Add(CreateQuantityColumn());
			}
			if (Columns.FindByUId(new Guid("d7fe119a-a831-4c2a-ba74-bdab58857363")) == null) {
				Columns.Add(CreateUnitColumn());
			}
			if (Columns.FindByUId(new Guid("39182ce0-41eb-4f71-bf55-1deb88489688")) == null) {
				Columns.Add(CreatePrimaryPriceColumn());
			}
			if (Columns.FindByUId(new Guid("1835d8c5-7687-4bad-a4a7-b6a4fbf45948")) == null) {
				Columns.Add(CreatePriceColumn());
			}
			if (Columns.FindByUId(new Guid("7ad56546-758e-4f32-bfe4-b96ac8b48d1f")) == null) {
				Columns.Add(CreatePrimaryAmountColumn());
			}
			if (Columns.FindByUId(new Guid("fcc86ad4-073f-4450-baab-abfa226b9e0a")) == null) {
				Columns.Add(CreateAmountColumn());
			}
			if (Columns.FindByUId(new Guid("08d936ff-1b7e-4a67-af92-2a870180ac9d")) == null) {
				Columns.Add(CreatePrimaryDiscountAmountColumn());
			}
			if (Columns.FindByUId(new Guid("68ea19d8-502b-4732-83a6-a959bcf3eea7")) == null) {
				Columns.Add(CreateDiscountAmountColumn());
			}
			if (Columns.FindByUId(new Guid("17e259cd-0063-46df-8cee-20bb4e2aad8b")) == null) {
				Columns.Add(CreateDiscountPercentColumn());
			}
			if (Columns.FindByUId(new Guid("d833bc97-8f18-416f-aef1-f7218abb2e0d")) == null) {
				Columns.Add(CreateTaxColumn());
			}
			if (Columns.FindByUId(new Guid("04a9e624-8638-48b3-ad41-100a8fd583f9")) == null) {
				Columns.Add(CreatePrimaryTaxAmountColumn());
			}
			if (Columns.FindByUId(new Guid("adb28cb7-3d76-4c93-a54f-97a4c6089946")) == null) {
				Columns.Add(CreateTaxAmountColumn());
			}
			if (Columns.FindByUId(new Guid("16c14cc8-459b-408d-bcc1-8b6c29efb26f")) == null) {
				Columns.Add(CreatePrimaryTotalAmountColumn());
			}
			if (Columns.FindByUId(new Guid("c97c6457-a800-472d-908b-991e63b65b05")) == null) {
				Columns.Add(CreateTotalAmountColumn());
			}
			if (Columns.FindByUId(new Guid("9db15d13-6c10-4818-8e1f-fcb55974c83e")) == null) {
				Columns.Add(CreateDiscountTaxColumn());
			}
			if (Columns.FindByUId(new Guid("f6e0a8f0-6eb4-4496-a092-b229cf31a6d6")) == null) {
				Columns.Add(CreateBaseQuantityColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("037591ee-fc21-4788-9b2e-a005dd21882d"),
				Name = @"Name",
				CreatedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				ModifiedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateNotesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("369b4363-6804-473b-92a5-4ee233772082"),
				Name = @"Notes",
				CreatedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				ModifiedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateProductColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a977122d-8f0c-49be-a0ce-bb9faf81bdc6"),
				Name = @"Product",
				ReferenceSchemaUId = new Guid("4c7a6ead-4eb8-4fc0-863e-98a664569fed"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				ModifiedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateCustomProductColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("237ca70c-b45e-46e8-a8eb-67e30584af32"),
				Name = @"CustomProduct",
				CreatedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				ModifiedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateDeliveryDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("5db18b1c-a7b8-4bd2-bb00-60e6f3663da3"),
				Name = @"DeliveryDate",
				CreatedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				ModifiedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateQuantityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float3")) {
				UId = new Guid("c4e45448-ad41-4fc8-9c8b-904790d003ff"),
				Name = @"Quantity",
				CreatedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				ModifiedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateUnitColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d7fe119a-a831-4c2a-ba74-bdab58857363"),
				Name = @"Unit",
				ReferenceSchemaUId = new Guid("38f2220e-7085-494d-b4c9-396666b6327b"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				ModifiedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreatePrimaryPriceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("39182ce0-41eb-4f71-bf55-1deb88489688"),
				Name = @"PrimaryPrice",
				CreatedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				ModifiedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreatePriceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("1835d8c5-7687-4bad-a4a7-b6a4fbf45948"),
				Name = @"Price",
				CreatedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				ModifiedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreatePrimaryAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("7ad56546-758e-4f32-bfe4-b96ac8b48d1f"),
				Name = @"PrimaryAmount",
				CreatedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				ModifiedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("fcc86ad4-073f-4450-baab-abfa226b9e0a"),
				Name = @"Amount",
				CreatedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				ModifiedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreatePrimaryDiscountAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("08d936ff-1b7e-4a67-af92-2a870180ac9d"),
				Name = @"PrimaryDiscountAmount",
				CreatedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				ModifiedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateDiscountAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("68ea19d8-502b-4732-83a6-a959bcf3eea7"),
				Name = @"DiscountAmount",
				CreatedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				ModifiedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateDiscountPercentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("17e259cd-0063-46df-8cee-20bb4e2aad8b"),
				Name = @"DiscountPercent",
				CreatedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				ModifiedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateTaxColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d833bc97-8f18-416f-aef1-f7218abb2e0d"),
				Name = @"Tax",
				ReferenceSchemaUId = new Guid("a32b5f57-0ef1-4d3d-a6ef-a6de2113fbe0"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				ModifiedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreatePrimaryTaxAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("04a9e624-8638-48b3-ad41-100a8fd583f9"),
				Name = @"PrimaryTaxAmount",
				CreatedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				ModifiedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateTaxAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("adb28cb7-3d76-4c93-a54f-97a4c6089946"),
				Name = @"TaxAmount",
				CreatedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				ModifiedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreatePrimaryTotalAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("16c14cc8-459b-408d-bcc1-8b6c29efb26f"),
				Name = @"PrimaryTotalAmount",
				CreatedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				ModifiedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateTotalAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("c97c6457-a800-472d-908b-991e63b65b05"),
				Name = @"TotalAmount",
				CreatedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				ModifiedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateDiscountTaxColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("9db15d13-6c10-4818-8e1f-fcb55974c83e"),
				Name = @"DiscountTax",
				CreatedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				ModifiedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateBaseQuantityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float3")) {
				UId = new Guid("f6e0a8f0-6eb4-4496-a092-b229cf31a6d6"),
				Name = @"BaseQuantity",
				CreatedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				ModifiedInSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBaseProductEntry_Base_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateBaseProductEntry_Base_TerrasoftEventsProcessSchema() {
			var schema = new BaseProductEntry_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BaseProductEntry_Base_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BaseProductEntry_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BaseProductEntry_Base_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BaseProductEntry_Base_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"));
		}

		#endregion

	}

	#endregion

	#region Class: BaseProductEntry_Base_Terrasoft

	/// <summary>
	/// Base product in item.
	/// </summary>
	public class BaseProductEntry_Base_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public BaseProductEntry_Base_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BaseProductEntry_Base_Terrasoft";
		}

		public BaseProductEntry_Base_Terrasoft(BaseProductEntry_Base_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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

		/// <summary>
		/// Notes.
		/// </summary>
		public string Notes {
			get {
				return GetTypedColumnValue<string>("Notes");
			}
			set {
				SetColumnValue("Notes", value);
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

		private Product _product;
		/// <summary>
		/// Product.
		/// </summary>
		public Product Product {
			get {
				return _product ??
					(_product = LookupColumnEntities.GetEntity("Product") as Product);
			}
		}

		/// <summary>
		/// Custom product.
		/// </summary>
		public string CustomProduct {
			get {
				return GetTypedColumnValue<string>("CustomProduct");
			}
			set {
				SetColumnValue("CustomProduct", value);
			}
		}

		/// <summary>
		/// Delivered on.
		/// </summary>
		public DateTime DeliveryDate {
			get {
				return GetTypedColumnValue<DateTime>("DeliveryDate");
			}
			set {
				SetColumnValue("DeliveryDate", value);
			}
		}

		/// <summary>
		/// Quantity.
		/// </summary>
		public Decimal Quantity {
			get {
				return GetTypedColumnValue<Decimal>("Quantity");
			}
			set {
				SetColumnValue("Quantity", value);
			}
		}

		/// <exclude/>
		public Guid UnitId {
			get {
				return GetTypedColumnValue<Guid>("UnitId");
			}
			set {
				SetColumnValue("UnitId", value);
				_unit = null;
			}
		}

		/// <exclude/>
		public string UnitName {
			get {
				return GetTypedColumnValue<string>("UnitName");
			}
			set {
				SetColumnValue("UnitName", value);
				if (_unit != null) {
					_unit.Name = value;
				}
			}
		}

		private Unit _unit;
		/// <summary>
		/// Unit of measure.
		/// </summary>
		public Unit Unit {
			get {
				return _unit ??
					(_unit = LookupColumnEntities.GetEntity("Unit") as Unit);
			}
		}

		/// <summary>
		/// Price, base currency.
		/// </summary>
		public Decimal PrimaryPrice {
			get {
				return GetTypedColumnValue<Decimal>("PrimaryPrice");
			}
			set {
				SetColumnValue("PrimaryPrice", value);
			}
		}

		/// <summary>
		/// Price.
		/// </summary>
		public Decimal Price {
			get {
				return GetTypedColumnValue<Decimal>("Price");
			}
			set {
				SetColumnValue("Price", value);
			}
		}

		/// <summary>
		/// Amount, base currency.
		/// </summary>
		public Decimal PrimaryAmount {
			get {
				return GetTypedColumnValue<Decimal>("PrimaryAmount");
			}
			set {
				SetColumnValue("PrimaryAmount", value);
			}
		}

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
		/// Discount amount, base currency.
		/// </summary>
		public Decimal PrimaryDiscountAmount {
			get {
				return GetTypedColumnValue<Decimal>("PrimaryDiscountAmount");
			}
			set {
				SetColumnValue("PrimaryDiscountAmount", value);
			}
		}

		/// <summary>
		/// Discount amount.
		/// </summary>
		public Decimal DiscountAmount {
			get {
				return GetTypedColumnValue<Decimal>("DiscountAmount");
			}
			set {
				SetColumnValue("DiscountAmount", value);
			}
		}

		/// <summary>
		/// Discount, %.
		/// </summary>
		public Decimal DiscountPercent {
			get {
				return GetTypedColumnValue<Decimal>("DiscountPercent");
			}
			set {
				SetColumnValue("DiscountPercent", value);
			}
		}

		/// <exclude/>
		public Guid TaxId {
			get {
				return GetTypedColumnValue<Guid>("TaxId");
			}
			set {
				SetColumnValue("TaxId", value);
				_tax = null;
			}
		}

		/// <exclude/>
		public string TaxName {
			get {
				return GetTypedColumnValue<string>("TaxName");
			}
			set {
				SetColumnValue("TaxName", value);
				if (_tax != null) {
					_tax.Name = value;
				}
			}
		}

		private Tax _tax;
		/// <summary>
		/// Tax.
		/// </summary>
		public Tax Tax {
			get {
				return _tax ??
					(_tax = LookupColumnEntities.GetEntity("Tax") as Tax);
			}
		}

		/// <summary>
		/// Tax amount, base currency.
		/// </summary>
		public Decimal PrimaryTaxAmount {
			get {
				return GetTypedColumnValue<Decimal>("PrimaryTaxAmount");
			}
			set {
				SetColumnValue("PrimaryTaxAmount", value);
			}
		}

		/// <summary>
		/// Tax amount.
		/// </summary>
		public Decimal TaxAmount {
			get {
				return GetTypedColumnValue<Decimal>("TaxAmount");
			}
			set {
				SetColumnValue("TaxAmount", value);
			}
		}

		/// <summary>
		/// Total, base currency.
		/// </summary>
		public Decimal PrimaryTotalAmount {
			get {
				return GetTypedColumnValue<Decimal>("PrimaryTotalAmount");
			}
			set {
				SetColumnValue("PrimaryTotalAmount", value);
			}
		}

		/// <summary>
		/// Total.
		/// </summary>
		public Decimal TotalAmount {
			get {
				return GetTypedColumnValue<Decimal>("TotalAmount");
			}
			set {
				SetColumnValue("TotalAmount", value);
			}
		}

		/// <summary>
		/// Tax %.
		/// </summary>
		public Decimal DiscountTax {
			get {
				return GetTypedColumnValue<Decimal>("DiscountTax");
			}
			set {
				SetColumnValue("DiscountTax", value);
			}
		}

		/// <summary>
		/// Quantity, base units..
		/// </summary>
		public Decimal BaseQuantity {
			get {
				return GetTypedColumnValue<Decimal>("BaseQuantity");
			}
			set {
				SetColumnValue("BaseQuantity", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BaseProductEntry_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("BaseProductEntry_Base_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("BaseProductEntry_Base_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("BaseProductEntry_Base_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("BaseProductEntry_Base_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("BaseProductEntry_Base_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("BaseProductEntry_Base_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("BaseProductEntry_Base_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseProductEntry_Base_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: BaseProductEntry_BaseEventsProcess

	/// <exclude/>
	public partial class BaseProductEntry_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : BaseProductEntry_Base_Terrasoft
	{

		public BaseProductEntry_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseProductEntry_BaseEventsProcess";
			SchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("04802832-e447-4188-a324-f2d1ca6efcc4");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private Decimal _currencyRate = 1m;
		public Decimal CurrencyRate {
			get {
				return _currencyRate;
			}
			set {
				_currencyRate = value;
			}
		}

		private ProcessFlowElement _baseProductEntrySavingEventSubProcess;
		public ProcessFlowElement BaseProductEntrySavingEventSubProcess {
			get {
				return _baseProductEntrySavingEventSubProcess ?? (_baseProductEntrySavingEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BaseProductEntrySavingEventSubProcess",
					SchemaElementUId = new Guid("384d7162-c2b6-4f45-aab6-de156c5af932"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseProductEntrySaving;
		public ProcessFlowElement BaseProductEntrySaving {
			get {
				return _baseProductEntrySaving ?? (_baseProductEntrySaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseProductEntrySaving",
					SchemaElementUId = new Guid("f54d58ea-ff7d-4003-9066-cb008f56be3a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _baseProductEntrySavingScriptTask;
		public ProcessScriptTask BaseProductEntrySavingScriptTask {
			get {
				return _baseProductEntrySavingScriptTask ?? (_baseProductEntrySavingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BaseProductEntrySavingScriptTask",
					SchemaElementUId = new Guid("2f934caf-eb61-4f6f-993c-80a28f7161ed"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = BaseProductEntrySavingScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[BaseProductEntrySavingEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseProductEntrySavingEventSubProcess };
			FlowElements[BaseProductEntrySaving.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseProductEntrySaving };
			FlowElements[BaseProductEntrySavingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseProductEntrySavingScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "BaseProductEntrySavingEventSubProcess":
						break;
					case "BaseProductEntrySaving":
						e.Context.QueueTasks.Enqueue("BaseProductEntrySavingScriptTask");
						break;
					case "BaseProductEntrySavingScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("BaseProductEntrySaving");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "BaseProductEntrySavingEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "BaseProductEntrySaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseProductEntrySaving";
					result = BaseProductEntrySaving.Execute(context);
					break;
				case "BaseProductEntrySavingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseProductEntrySavingScriptTask";
					result = BaseProductEntrySavingScriptTask.Execute(context, BaseProductEntrySavingScriptTaskExecute);
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
				case "CurrencyRate":
					CurrencyRate = reader.GetValue<System.Decimal>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool BaseProductEntrySavingScriptTaskExecute(ProcessExecutingContext context) {
			UpdatePrimaryAmounts();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "BaseProductEntry_Base_TerrasoftSaving":
							if (ActivatedEventElements.Contains("BaseProductEntrySaving")) {
							context.QueueTasks.Enqueue("BaseProductEntrySaving");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("CurrencyRate") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CurrencyRate", CurrencyRate, 0m);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: BaseProductEntry_BaseEventsProcess

	/// <exclude/>
	public class BaseProductEntry_BaseEventsProcess : BaseProductEntry_BaseEventsProcess<BaseProductEntry_Base_Terrasoft>
	{

		public BaseProductEntry_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BaseProductEntry_BaseEventsProcess

	public partial class BaseProductEntry_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual decimal Division(decimal arg1, decimal arg2) {
			decimal result = 0;
			if (arg2 > 0) {
				result = arg1 / arg2;
			}
			return result;
		}

		public virtual decimal Multiply(decimal arg1, decimal arg2) {
			var result = arg1* arg2;
			return result;
		}

		public virtual void UpdatePrimaryAmounts() {
			decimal price = this.Entity.GetTypedColumnValue<decimal>("Price");
			decimal amount = this.Entity.GetTypedColumnValue<decimal>("Amount");
			decimal discountAmount = this.Entity.GetTypedColumnValue<decimal>("DiscountAmount");
			decimal taxAmount  = this.Entity.GetTypedColumnValue<decimal>("TaxAmount");
			decimal totalAmount  = this.Entity.GetTypedColumnValue<decimal>("TotalAmount");
			this.Entity.SetColumnValue("PrimaryPrice", Division(price, CurrencyRate));
			this.Entity.SetColumnValue("PrimaryAmount", Division(amount, CurrencyRate));
			this.Entity.SetColumnValue("PrimaryDiscountAmount", Division(discountAmount, CurrencyRate));
			this.Entity.SetColumnValue("PrimaryTaxAmount", Division(taxAmount, CurrencyRate));
			this.Entity.SetColumnValue("PrimaryTotalAmount", Division(totalAmount, CurrencyRate));
		}

		#endregion

	}

	#endregion

	#region Class: BaseProductEntry_Base_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class BaseProductEntry_Base_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public BaseProductEntry_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BaseProductEntry_Base_TerrasoftEventsProcessSchema(BaseProductEntry_Base_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BaseProductEntry_BaseEventsProcess";
			UId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = Guid.Empty;
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateCurrencyRateParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4a598a3f-4f56-497a-9dac-1fad45872779"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				Name = @"CurrencyRate",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Float2"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"1",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateCurrencyRateParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaBaseProductEntryLaneSet = CreateBaseProductEntryLaneSetLaneSet();
			LaneSets.Add(schemaBaseProductEntryLaneSet);
			ProcessSchemaLane schemaBaseProductEntryLane = CreateBaseProductEntryLaneLane();
			schemaBaseProductEntryLaneSet.Lanes.Add(schemaBaseProductEntryLane);
			ProcessSchemaEventSubProcess baseproductentrysavingeventsubprocess = CreateBaseProductEntrySavingEventSubProcessEventSubProcess();
			FlowElements.Add(baseproductentrysavingeventsubprocess);
			ProcessSchemaStartMessageEvent baseproductentrysaving = CreateBaseProductEntrySavingStartMessageEvent();
			baseproductentrysavingeventsubprocess.FlowElements.Add(baseproductentrysaving);
			ProcessSchemaScriptTask baseproductentrysavingscripttask = CreateBaseProductEntrySavingScriptTaskScriptTask();
			baseproductentrysavingeventsubprocess.FlowElements.Add(baseproductentrysavingscripttask);
			FlowElements.Add(CreateFromBaseProductEntrySavingSequenceFlowSequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateFromBaseProductEntrySavingSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "FromBaseProductEntrySavingSequenceFlow",
				UId = new Guid("d492b4f7-c762-40cc-84a4-6b06138443a4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6"),
				CreatedInSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CurveCenterPosition = new Point(173, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f54d58ea-ff7d-4003-9066-cb008f56be3a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2f934caf-eb61-4f6f-993c-80a28f7161ed"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateBaseProductEntryLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaBaseProductEntryLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("58593936-05bc-4f23-b47e-7cca9885575e"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6"),
				CreatedInSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				Name = @"BaseProductEntryLaneSet",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1189, 177),
				UseBackgroundMode = false
			};
			return schemaBaseProductEntryLaneSet;
		}

		protected virtual ProcessSchemaLane CreateBaseProductEntryLaneLane() {
			ProcessSchemaLane schemaBaseProductEntryLane = new ProcessSchemaLane(this) {
				UId = new Guid("88754556-625c-4fa5-b086-321a44932137"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("58593936-05bc-4f23-b47e-7cca9885575e"),
				CreatedInOwnerSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4"),
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6"),
				CreatedInSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				Name = @"BaseProductEntryLane",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1160, 177),
				UseBackgroundMode = false
			};
			return schemaBaseProductEntryLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateBaseProductEntrySavingEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaBaseProductEntrySavingEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("384d7162-c2b6-4f45-aab6-de156c5af932"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("88754556-625c-4fa5-b086-321a44932137"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6"),
				CreatedInSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				Name = @"BaseProductEntrySavingEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(42, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(231, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaBaseProductEntrySavingEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBaseProductEntrySavingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f54d58ea-ff7d-4003-9066-cb008f56be3a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("384d7162-c2b6-4f45-aab6-de156c5af932"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6"),
				CreatedInSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"BaseProductEntrySaving",
				ModifiedInSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				Name = @"BaseProductEntrySaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(21, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateBaseProductEntrySavingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2f934caf-eb61-4f6f-993c-80a28f7161ed"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("384d7162-c2b6-4f45-aab6-de156c5af932"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6"),
				CreatedInSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				Name = @"BaseProductEntrySavingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(120, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,72,73,44,73,13,40,202,204,77,44,170,116,204,205,47,205,43,41,214,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,39,170,223,141,37,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateDivisionMethod());
			Methods.Add(CreateMultiplyMethod());
			Methods.Add(CreateUpdatePrimaryAmountsMethod());
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

		protected virtual SchemaMethod CreateDivisionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("eddf3f7d-0081-45f4-a8d7-43a08a239284"),
				Name = "Division",
				CreatedInSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6"),
				ResultValueTypeName = "decimal"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("06516411-add7-48d1-8259-5e4266923948"),
				Name = "arg1",
				CreatedInSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				ModifiedInSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "decimal",
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("0e4b74c7-d723-432f-9c2d-26c23155ee4c"),
				Name = "arg2",
				CreatedInSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				ModifiedInSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "decimal",
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,73,77,206,204,77,204,81,40,74,45,46,205,41,81,176,85,48,176,230,202,76,83,208,72,44,74,55,82,176,83,48,208,84,168,230,226,132,75,2,69,13,21,244,65,148,145,53,87,45,87,81,106,73,105,81,30,84,175,53,0,26,183,54,182,75,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateMultiplyMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b7b298f4-4d45-42b6-9c54-34460a54f84f"),
				Name = "Multiply",
				CreatedInSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6"),
				ResultValueTypeName = "decimal"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("7f01f4d4-1140-4edd-9335-1d10acc57814"),
				Name = "arg1",
				CreatedInSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				ModifiedInSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "decimal",
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("389ad3a9-606b-45a1-9c60-9431fc6bf8ab"),
				Name = "arg2",
				CreatedInSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				ModifiedInSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "decimal",
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,40,74,45,46,205,41,81,176,85,72,44,74,55,212,2,145,70,214,92,69,169,37,165,69,121,80,57,107,0,143,248,20,247,39,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdatePrimaryAmountsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("99aef178-9859-4e0a-ad45-25a7318c017e"),
				Name = "UpdatePrimaryAmounts",
				CreatedInSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("a1288d21-62a4-4393-85b3-68bfebc0ba21"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,209,201,10,194,48,20,5,208,189,95,17,186,106,161,244,7,28,160,180,226,86,180,184,15,73,192,64,134,146,190,136,249,123,233,160,125,213,141,205,246,145,123,2,247,114,193,164,166,138,180,78,50,65,246,4,238,178,43,142,6,36,132,226,36,160,9,173,224,149,85,94,155,27,85,94,236,248,248,254,144,38,231,62,145,100,219,205,116,34,84,91,111,96,149,81,14,17,140,112,217,177,254,86,174,199,234,69,20,163,64,159,147,183,10,108,222,177,133,101,129,170,40,109,14,246,30,14,94,5,160,204,80,173,166,46,140,13,231,164,150,15,217,73,107,210,97,164,156,84,222,57,97,88,184,80,16,217,127,212,244,47,178,198,181,162,176,175,162,17,186,92,47,10,159,75,71,238,103,192,56,18,53,143,209,249,252,195,190,0,174,136,240,73,23,3,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseProductEntry_Base_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"));
		}

		#endregion

	}

	#endregion

}

