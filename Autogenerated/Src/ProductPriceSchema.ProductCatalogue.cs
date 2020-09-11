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

	#region Class: ProductPrice_ProductCatalogue_TerrasoftSchema

	/// <exclude/>
	public class ProductPrice_ProductCatalogue_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ProductPrice_ProductCatalogue_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ProductPrice_ProductCatalogue_TerrasoftSchema(ProductPrice_ProductCatalogue_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ProductPrice_ProductCatalogue_TerrasoftSchema(ProductPrice_ProductCatalogue_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dd9a991c-01a6-44f1-b1ae-ebaf75800ee3");
			RealUId = new Guid("dd9a991c-01a6-44f1-b1ae-ebaf75800ee3");
			Name = "ProductPrice_ProductCatalogue_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("977fbc10-2e8f-4ad3-a98f-da1d7f52a2e1")) == null) {
				Columns.Add(CreateProductColumn());
			}
			if (Columns.FindByUId(new Guid("b1bb8a4f-0f43-4f71-aaba-5208d9944676")) == null) {
				Columns.Add(CreateCurrencyColumn());
			}
			if (Columns.FindByUId(new Guid("5575acd0-57f5-4eca-a9ff-075495e89ae4")) == null) {
				Columns.Add(CreateTaxColumn());
			}
			if (Columns.FindByUId(new Guid("9c418440-11fc-45d0-b1a2-aea6415f29d3")) == null) {
				Columns.Add(CreatePriceColumn());
			}
			if (Columns.FindByUId(new Guid("302e9470-1bfd-4907-b336-95f891378535")) == null) {
				Columns.Add(CreatePriceListColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("dd9a991c-01a6-44f1-b1ae-ebaf75800ee3");
			column.CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("dd9a991c-01a6-44f1-b1ae-ebaf75800ee3");
			column.CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("dd9a991c-01a6-44f1-b1ae-ebaf75800ee3");
			column.CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("dd9a991c-01a6-44f1-b1ae-ebaf75800ee3");
			column.CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("dd9a991c-01a6-44f1-b1ae-ebaf75800ee3");
			column.CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("dd9a991c-01a6-44f1-b1ae-ebaf75800ee3");
			column.CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467");
			return column;
		}

		protected virtual EntitySchemaColumn CreateProductColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("977fbc10-2e8f-4ad3-a98f-da1d7f52a2e1"),
				Name = @"Product",
				ReferenceSchemaUId = new Guid("4c7a6ead-4eb8-4fc0-863e-98a664569fed"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("dd9a991c-01a6-44f1-b1ae-ebaf75800ee3"),
				ModifiedInSchemaUId = new Guid("dd9a991c-01a6-44f1-b1ae-ebaf75800ee3"),
				CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467")
			};
		}

		protected virtual EntitySchemaColumn CreateCurrencyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b1bb8a4f-0f43-4f71-aaba-5208d9944676"),
				Name = @"Currency",
				ReferenceSchemaUId = new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("dd9a991c-01a6-44f1-b1ae-ebaf75800ee3"),
				ModifiedInSchemaUId = new Guid("dd9a991c-01a6-44f1-b1ae-ebaf75800ee3"),
				CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Settings,
					ValueSource = @"PrimaryCurrency"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateTaxColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("5575acd0-57f5-4eca-a9ff-075495e89ae4"),
				Name = @"Tax",
				ReferenceSchemaUId = new Guid("a32b5f57-0ef1-4d3d-a6ef-a6de2113fbe0"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("dd9a991c-01a6-44f1-b1ae-ebaf75800ee3"),
				ModifiedInSchemaUId = new Guid("dd9a991c-01a6-44f1-b1ae-ebaf75800ee3"),
				CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Settings,
					ValueSource = @"DefaultTax"
				}
			};
		}

		protected virtual EntitySchemaColumn CreatePriceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("9c418440-11fc-45d0-b1a2-aea6415f29d3"),
				Name = @"Price",
				CreatedInSchemaUId = new Guid("dd9a991c-01a6-44f1-b1ae-ebaf75800ee3"),
				ModifiedInSchemaUId = new Guid("dd9a991c-01a6-44f1-b1ae-ebaf75800ee3"),
				CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467")
			};
		}

		protected virtual EntitySchemaColumn CreatePriceListColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("302e9470-1bfd-4907-b336-95f891378535"),
				Name = @"PriceList",
				ReferenceSchemaUId = new Guid("036f6f5b-838d-4187-9749-b54c8539c076"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("dd9a991c-01a6-44f1-b1ae-ebaf75800ee3"),
				ModifiedInSchemaUId = new Guid("dd9a991c-01a6-44f1-b1ae-ebaf75800ee3"),
				CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Settings,
					ValueSource = @"BasePriceList"
				}
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateProductPrice_ProductCatalogue_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateProductPrice_ProductCatalogue_TerrasoftEventsProcessSchema() {
			var schema = new ProductPrice_ProductCatalogue_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ProductPrice_ProductCatalogue_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ProductPrice_ProductCatalogueEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ProductPrice_ProductCatalogue_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ProductPrice_ProductCatalogue_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dd9a991c-01a6-44f1-b1ae-ebaf75800ee3"));
		}

		#endregion

	}

	#endregion

	#region Class: ProductPrice_ProductCatalogue_Terrasoft

	/// <summary>
	/// Product price.
	/// </summary>
	public class ProductPrice_ProductCatalogue_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ProductPrice_ProductCatalogue_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ProductPrice_ProductCatalogue_Terrasoft";
		}

		public ProductPrice_ProductCatalogue_Terrasoft(ProductPrice_ProductCatalogue_Terrasoft source)
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

		/// <exclude/>
		public Guid PriceListId {
			get {
				return GetTypedColumnValue<Guid>("PriceListId");
			}
			set {
				SetColumnValue("PriceListId", value);
				_priceList = null;
			}
		}

		/// <exclude/>
		public string PriceListName {
			get {
				return GetTypedColumnValue<string>("PriceListName");
			}
			set {
				SetColumnValue("PriceListName", value);
				if (_priceList != null) {
					_priceList.Name = value;
				}
			}
		}

		private Pricelist _priceList;
		/// <summary>
		/// Price list.
		/// </summary>
		public Pricelist PriceList {
			get {
				return _priceList ??
					(_priceList = LookupColumnEntities.GetEntity("PriceList") as Pricelist);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ProductPrice_ProductCatalogueEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ProductPrice_ProductCatalogue_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("ProductPrice_ProductCatalogue_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("ProductPrice_ProductCatalogue_TerrasoftSaved", e);
			Validating += (s, e) => ThrowEvent("ProductPrice_ProductCatalogue_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ProductPrice_ProductCatalogue_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: ProductPrice_ProductCatalogueEventsProcess

	/// <exclude/>
	public partial class ProductPrice_ProductCatalogueEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : ProductPrice_ProductCatalogue_Terrasoft
	{

		public ProductPrice_ProductCatalogueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProductPrice_ProductCatalogueEventsProcess";
			SchemaUId = new Guid("dd9a991c-01a6-44f1-b1ae-ebaf75800ee3");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("dd9a991c-01a6-44f1-b1ae-ebaf75800ee3");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
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
					SchemaElementUId = new Guid("7f5039b2-1e9c-4db2-8b04-8fa74e09e62a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _productPriceSaved;
		public ProcessFlowElement ProductPriceSaved {
			get {
				return _productPriceSaved ?? (_productPriceSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ProductPriceSaved",
					SchemaElementUId = new Guid("c09c0cb3-d083-416e-9620-a5d256523132"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _actulizePriceInProduct;
		public ProcessScriptTask ActulizePriceInProduct {
			get {
				return _actulizePriceInProduct ?? (_actulizePriceInProduct = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ActulizePriceInProduct",
					SchemaElementUId = new Guid("eb55167c-466c-458a-aa88-371089f9223b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ActulizePriceInProductExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[ProductPriceSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { ProductPriceSaved };
			FlowElements[ActulizePriceInProduct.SchemaElementUId] = new Collection<ProcessFlowElement> { ActulizePriceInProduct };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "ProductPriceSaved":
						e.Context.QueueTasks.Enqueue("ActulizePriceInProduct");
						break;
					case "ActulizePriceInProduct":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ProductPriceSaved");
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
				case "ProductPriceSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProductPriceSaved";
					result = ProductPriceSaved.Execute(context);
					break;
				case "ActulizePriceInProduct":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActulizePriceInProduct";
					result = ActulizePriceInProduct.Execute(context, ActulizePriceInProductExecute);
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

		public virtual bool ActulizePriceInProductExecute(ProcessExecutingContext context) {
			var productPriceHelper = Terrasoft.Core.Factories.ClassFactory.Get<Terrasoft.Configuration.ProductPriceHelper>(
				new Terrasoft.Core.Factories.ConstructorArgument("userConnection", UserConnection));
			productPriceHelper.SetPriceInProduct(Entity);
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ProductPrice_ProductCatalogue_TerrasoftSaved":
							if (ActivatedEventElements.Contains("ProductPriceSaved")) {
							context.QueueTasks.Enqueue("ProductPriceSaved");
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

	#region Class: ProductPrice_ProductCatalogueEventsProcess

	/// <exclude/>
	public class ProductPrice_ProductCatalogueEventsProcess : ProductPrice_ProductCatalogueEventsProcess<ProductPrice_ProductCatalogue_Terrasoft>
	{

		public ProductPrice_ProductCatalogueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ProductPrice_ProductCatalogueEventsProcess

	public partial class ProductPrice_ProductCatalogueEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: ProductPrice_ProductCatalogue_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class ProductPrice_ProductCatalogue_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public ProductPrice_ProductCatalogue_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ProductPrice_ProductCatalogue_TerrasoftEventsProcessSchema(ProductPrice_ProductCatalogue_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ProductPrice_ProductCatalogueEventsProcess";
			UId = new Guid("b2e9bb28-5646-4171-9bac-0ef8516d4d68");
			CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467");
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
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaStartMessageEvent productpricesaved = CreateProductPriceSavedStartMessageEvent();
			eventsubprocess1.FlowElements.Add(productpricesaved);
			ProcessSchemaScriptTask actulizepriceinproduct = CreateActulizePriceInProductScriptTask();
			eventsubprocess1.FlowElements.Add(actulizepriceinproduct);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("e0ec88b7-f3a6-4713-937b-79e5352f5a4a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("741231e0-c6fd-4dea-b23f-a6b7a76d6de7"),
				CreatedInSchemaUId = new Guid("b2e9bb28-5646-4171-9bac-0ef8516d4d68"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b2e9bb28-5646-4171-9bac-0ef8516d4d68"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c09c0cb3-d083-416e-9620-a5d256523132"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("eb55167c-466c-458a-aa88-371089f9223b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("4f9b3f65-f741-408b-82cf-6fe5aa00e500"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("741231e0-c6fd-4dea-b23f-a6b7a76d6de7"),
				CreatedInSchemaUId = new Guid("b2e9bb28-5646-4171-9bac-0ef8516d4d68"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("b2e9bb28-5646-4171-9bac-0ef8516d4d68"),
				Name = @"LaneSet1",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("21595112-7b1d-4186-a725-79a2808dbf0e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f9b3f65-f741-408b-82cf-6fe5aa00e500"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("741231e0-c6fd-4dea-b23f-a6b7a76d6de7"),
				CreatedInSchemaUId = new Guid("b2e9bb28-5646-4171-9bac-0ef8516d4d68"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("b2e9bb28-5646-4171-9bac-0ef8516d4d68"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7f5039b2-1e9c-4db2-8b04-8fa74e09e62a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("21595112-7b1d-4186-a725-79a2808dbf0e"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("741231e0-c6fd-4dea-b23f-a6b7a76d6de7"),
				CreatedInSchemaUId = new Guid("b2e9bb28-5646-4171-9bac-0ef8516d4d68"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("b2e9bb28-5646-4171-9bac-0ef8516d4d68"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(44, 27),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(300, 300),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateProductPriceSavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c09c0cb3-d083-416e-9620-a5d256523132"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7f5039b2-1e9c-4db2-8b04-8fa74e09e62a"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("741231e0-c6fd-4dea-b23f-a6b7a76d6de7"),
				CreatedInSchemaUId = new Guid("b2e9bb28-5646-4171-9bac-0ef8516d4d68"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ProductPriceSaved",
				ModifiedInSchemaUId = new Guid("b2e9bb28-5646-4171-9bac-0ef8516d4d68"),
				Name = @"ProductPriceSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(31, 131),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateActulizePriceInProductScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("eb55167c-466c-458a-aa88-371089f9223b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7f5039b2-1e9c-4db2-8b04-8fa74e09e62a"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("741231e0-c6fd-4dea-b23f-a6b7a76d6de7"),
				CreatedInSchemaUId = new Guid("b2e9bb28-5646-4171-9bac-0ef8516d4d68"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("b2e9bb28-5646-4171-9bac-0ef8516d4d68"),
				Name = @"ActulizePriceInProduct",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(187, 117),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,143,77,10,194,48,16,133,215,246,20,161,171,22,36,23,168,10,82,252,219,21,212,3,132,56,45,129,118,82,94,38,74,111,111,75,93,40,5,151,223,204,227,155,121,79,3,213,195,63,162,149,10,206,210,153,218,158,160,182,234,70,128,9,190,22,93,122,144,62,26,43,30,142,130,46,91,19,194,140,131,62,145,108,190,147,92,187,38,194,136,243,172,171,133,118,151,37,43,166,215,31,183,231,32,136,19,238,209,196,142,88,178,52,6,194,184,96,178,147,54,93,171,251,207,32,207,139,100,217,64,95,105,198,11,127,254,200,14,44,78,134,49,13,146,8,86,227,33,42,222,49,226,4,214,0,1,0,0 }
			};
			
			return ScriptTask;
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
				CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467")
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
			return new ProductPrice_ProductCatalogue_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b2e9bb28-5646-4171-9bac-0ef8516d4d68"));
		}

		#endregion

	}

	#endregion

}

