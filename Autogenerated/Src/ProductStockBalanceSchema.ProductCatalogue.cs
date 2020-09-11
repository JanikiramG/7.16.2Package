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

	#region Class: ProductStockBalanceSchema

	/// <exclude/>
	public class ProductStockBalanceSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ProductStockBalanceSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ProductStockBalanceSchema(ProductStockBalanceSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ProductStockBalanceSchema(ProductStockBalanceSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("45ca8581-a0f1-40d9-b08a-924d9be42a8c");
			RealUId = new Guid("45ca8581-a0f1-40d9-b08a-924d9be42a8c");
			Name = "ProductStockBalance";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("46234a17-f20d-4296-8bf9-ed56380208a0")) == null) {
				Columns.Add(CreateProductColumn());
			}
			if (Columns.FindByUId(new Guid("fef0f8bc-f68c-4c86-b10a-a4b3daea65fd")) == null) {
				Columns.Add(CreateTotalQuantityColumn());
			}
			if (Columns.FindByUId(new Guid("d904455a-12f0-4626-ae10-d2719eeff146")) == null) {
				Columns.Add(CreateReserveQuantityColumn());
			}
			if (Columns.FindByUId(new Guid("047898fd-2b76-45f5-8f07-9659214c9103")) == null) {
				Columns.Add(CreateAvailableQuantityColumn());
			}
			if (Columns.FindByUId(new Guid("8e73ef53-54b6-4302-9caa-50e1f4be8c14")) == null) {
				Columns.Add(CreateWarehouseColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("45ca8581-a0f1-40d9-b08a-924d9be42a8c");
			column.CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("45ca8581-a0f1-40d9-b08a-924d9be42a8c");
			column.CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("45ca8581-a0f1-40d9-b08a-924d9be42a8c");
			column.CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("45ca8581-a0f1-40d9-b08a-924d9be42a8c");
			column.CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("45ca8581-a0f1-40d9-b08a-924d9be42a8c");
			column.CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("45ca8581-a0f1-40d9-b08a-924d9be42a8c");
			column.CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			return column;
		}

		protected virtual EntitySchemaColumn CreateProductColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("46234a17-f20d-4296-8bf9-ed56380208a0"),
				Name = @"Product",
				ReferenceSchemaUId = new Guid("4c7a6ead-4eb8-4fc0-863e-98a664569fed"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("45ca8581-a0f1-40d9-b08a-924d9be42a8c"),
				ModifiedInSchemaUId = new Guid("45ca8581-a0f1-40d9-b08a-924d9be42a8c"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			};
		}

		protected virtual EntitySchemaColumn CreateTotalQuantityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float3")) {
				UId = new Guid("fef0f8bc-f68c-4c86-b10a-a4b3daea65fd"),
				Name = @"TotalQuantity",
				CreatedInSchemaUId = new Guid("45ca8581-a0f1-40d9-b08a-924d9be42a8c"),
				ModifiedInSchemaUId = new Guid("45ca8581-a0f1-40d9-b08a-924d9be42a8c"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			};
		}

		protected virtual EntitySchemaColumn CreateReserveQuantityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float3")) {
				UId = new Guid("d904455a-12f0-4626-ae10-d2719eeff146"),
				Name = @"ReserveQuantity",
				CreatedInSchemaUId = new Guid("45ca8581-a0f1-40d9-b08a-924d9be42a8c"),
				ModifiedInSchemaUId = new Guid("45ca8581-a0f1-40d9-b08a-924d9be42a8c"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			};
		}

		protected virtual EntitySchemaColumn CreateAvailableQuantityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float3")) {
				UId = new Guid("047898fd-2b76-45f5-8f07-9659214c9103"),
				Name = @"AvailableQuantity",
				CreatedInSchemaUId = new Guid("45ca8581-a0f1-40d9-b08a-924d9be42a8c"),
				ModifiedInSchemaUId = new Guid("45ca8581-a0f1-40d9-b08a-924d9be42a8c"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			};
		}

		protected virtual EntitySchemaColumn CreateWarehouseColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8e73ef53-54b6-4302-9caa-50e1f4be8c14"),
				Name = @"Warehouse",
				ReferenceSchemaUId = new Guid("70daff1b-1b40-4ac3-9c93-cd76e1835fe3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("45ca8581-a0f1-40d9-b08a-924d9be42a8c"),
				ModifiedInSchemaUId = new Guid("45ca8581-a0f1-40d9-b08a-924d9be42a8c"),
				CreatedInPackageId = new Guid("a637dd4e-eb51-48a6-87f0-a0fabbc2fa75")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateProductStockBalanceEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateProductStockBalanceEventsProcessSchema() {
			var schema = new ProductStockBalanceEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ProductStockBalance(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ProductStockBalance_ProductCatalogueEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ProductStockBalanceSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ProductStockBalanceSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("45ca8581-a0f1-40d9-b08a-924d9be42a8c"));
		}

		#endregion

	}

	#endregion

	#region Class: ProductStockBalance

	/// <summary>
	/// Product in stock.
	/// </summary>
	public class ProductStockBalance : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ProductStockBalance(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ProductStockBalance";
		}

		public ProductStockBalance(ProductStockBalance source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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
		/// Available.
		/// </summary>
		public Decimal TotalQuantity {
			get {
				return GetTypedColumnValue<Decimal>("TotalQuantity");
			}
			set {
				SetColumnValue("TotalQuantity", value);
			}
		}

		/// <summary>
		/// Reserved.
		/// </summary>
		public Decimal ReserveQuantity {
			get {
				return GetTypedColumnValue<Decimal>("ReserveQuantity");
			}
			set {
				SetColumnValue("ReserveQuantity", value);
			}
		}

		/// <summary>
		/// Available.
		/// </summary>
		public Decimal AvailableQuantity {
			get {
				return GetTypedColumnValue<Decimal>("AvailableQuantity");
			}
			set {
				SetColumnValue("AvailableQuantity", value);
			}
		}

		/// <exclude/>
		public Guid WarehouseId {
			get {
				return GetTypedColumnValue<Guid>("WarehouseId");
			}
			set {
				SetColumnValue("WarehouseId", value);
				_warehouse = null;
			}
		}

		/// <exclude/>
		public string WarehouseName {
			get {
				return GetTypedColumnValue<string>("WarehouseName");
			}
			set {
				SetColumnValue("WarehouseName", value);
				if (_warehouse != null) {
					_warehouse.Name = value;
				}
			}
		}

		private Warehouse _warehouse;
		/// <summary>
		/// Warehouse.
		/// </summary>
		public Warehouse Warehouse {
			get {
				return _warehouse ??
					(_warehouse = LookupColumnEntities.GetEntity("Warehouse") as Warehouse);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ProductStockBalance_ProductCatalogueEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ProductStockBalanceDeleted", e);
			Inserting += (s, e) => ThrowEvent("ProductStockBalanceInserting", e);
			Validating += (s, e) => ThrowEvent("ProductStockBalanceValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ProductStockBalance(this);
		}

		#endregion

	}

	#endregion

	#region Class: ProductStockBalance_ProductCatalogueEventsProcess

	/// <exclude/>
	public partial class ProductStockBalance_ProductCatalogueEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : ProductStockBalance
	{

		public ProductStockBalance_ProductCatalogueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProductStockBalance_ProductCatalogueEventsProcess";
			SchemaUId = new Guid("45ca8581-a0f1-40d9-b08a-924d9be42a8c");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("45ca8581-a0f1-40d9-b08a-924d9be42a8c");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
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

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
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

	#region Class: ProductStockBalance_ProductCatalogueEventsProcess

	/// <exclude/>
	public class ProductStockBalance_ProductCatalogueEventsProcess : ProductStockBalance_ProductCatalogueEventsProcess<ProductStockBalance>
	{

		public ProductStockBalance_ProductCatalogueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ProductStockBalance_ProductCatalogueEventsProcess

	public partial class ProductStockBalance_ProductCatalogueEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: ProductStockBalanceEventsProcessSchema

	/// <exclude/>
	public class ProductStockBalanceEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public ProductStockBalanceEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ProductStockBalanceEventsProcessSchema(ProductStockBalanceEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ProductStockBalance_ProductCatalogueEventsProcess";
			UId = new Guid("4a1e5472-a29c-4305-b31f-bf1df31858fe");
			CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
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
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
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
			return new ProductStockBalanceEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4a1e5472-a29c-4305-b31f-bf1df31858fe"));
		}

		#endregion

	}

	#endregion


	#region Class: ProductStockBalanceEventsProcess

	/// <exclude/>
	public class ProductStockBalanceEventsProcess : ProductStockBalance_ProductCatalogueEventsProcess
	{

		public ProductStockBalanceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

