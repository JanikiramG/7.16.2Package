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

	#region Class: Product_ProductCatalogue_TerrasoftSchema

	/// <exclude/>
	public class Product_ProductCatalogue_TerrasoftSchema : Terrasoft.Configuration.Product_ProductBase_TerrasoftSchema
	{

		#region Constructors: Public

		public Product_ProductCatalogue_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Product_ProductCatalogue_TerrasoftSchema(Product_ProductCatalogue_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Product_ProductCatalogue_TerrasoftSchema(Product_ProductCatalogue_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("e2e35eeb-1d87-4ce0-b885-c3a8c6c23bd2");
			Name = "Product_ProductCatalogue_Terrasoft";
			ParentSchemaUId = new Guid("4c7a6ead-4eb8-4fc0-863e-98a664569fed");
			ExtendParent = true;
			CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("84c5953d-e261-449e-9189-8fac859db36d")) == null) {
				Columns.Add(CreateCategoryColumn());
			}
			if (Columns.FindByUId(new Guid("bc105fcf-3068-4525-9c22-efc1942262cd")) == null) {
				Columns.Add(CreateTradeMarkColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCategoryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("84c5953d-e261-449e-9189-8fac859db36d"),
				Name = @"Category",
				ReferenceSchemaUId = new Guid("3e22e8d3-36f6-4c32-adbe-678155527541"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("e2e35eeb-1d87-4ce0-b885-c3a8c6c23bd2"),
				ModifiedInSchemaUId = new Guid("e2e35eeb-1d87-4ce0-b885-c3a8c6c23bd2"),
				CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467")
			};
		}

		protected virtual EntitySchemaColumn CreateTradeMarkColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("bc105fcf-3068-4525-9c22-efc1942262cd"),
				Name = @"TradeMark",
				ReferenceSchemaUId = new Guid("d1084b21-51c3-4fb4-b8b8-158895fbdebc"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("e2e35eeb-1d87-4ce0-b885-c3a8c6c23bd2"),
				ModifiedInSchemaUId = new Guid("e2e35eeb-1d87-4ce0-b885-c3a8c6c23bd2"),
				CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateProduct_ProductCatalogue_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateProduct_ProductCatalogue_TerrasoftEventsProcessSchema() {
			var schema = new Product_ProductCatalogue_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Product_ProductCatalogue_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Product_ProductCatalogueEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Product_ProductCatalogue_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Product_ProductCatalogue_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e2e35eeb-1d87-4ce0-b885-c3a8c6c23bd2"));
		}

		#endregion

	}

	#endregion

	#region Class: Product_ProductCatalogue_Terrasoft

	/// <summary>
	/// Product.
	/// </summary>
	public class Product_ProductCatalogue_Terrasoft : Terrasoft.Configuration.Product_ProductBase_Terrasoft
	{

		#region Constructors: Public

		public Product_ProductCatalogue_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Product_ProductCatalogue_Terrasoft";
		}

		public Product_ProductCatalogue_Terrasoft(Product_ProductCatalogue_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid CategoryId {
			get {
				return GetTypedColumnValue<Guid>("CategoryId");
			}
			set {
				SetColumnValue("CategoryId", value);
				_category = null;
			}
		}

		/// <exclude/>
		public string CategoryName {
			get {
				return GetTypedColumnValue<string>("CategoryName");
			}
			set {
				SetColumnValue("CategoryName", value);
				if (_category != null) {
					_category.Name = value;
				}
			}
		}

		private ProductCategory _category;
		/// <summary>
		/// Category.
		/// </summary>
		public ProductCategory Category {
			get {
				return _category ??
					(_category = LookupColumnEntities.GetEntity("Category") as ProductCategory);
			}
		}

		/// <exclude/>
		public Guid TradeMarkId {
			get {
				return GetTypedColumnValue<Guid>("TradeMarkId");
			}
			set {
				SetColumnValue("TradeMarkId", value);
				_tradeMark = null;
			}
		}

		/// <exclude/>
		public string TradeMarkName {
			get {
				return GetTypedColumnValue<string>("TradeMarkName");
			}
			set {
				SetColumnValue("TradeMarkName", value);
				if (_tradeMark != null) {
					_tradeMark.Name = value;
				}
			}
		}

		private TradeMark _tradeMark;
		/// <summary>
		/// Brand.
		/// </summary>
		public TradeMark TradeMark {
			get {
				return _tradeMark ??
					(_tradeMark = LookupColumnEntities.GetEntity("TradeMark") as TradeMark);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Product_ProductCatalogueEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Product_ProductCatalogue_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("Product_ProductCatalogue_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("Product_ProductCatalogue_TerrasoftSaved", e);
			Validating += (s, e) => ThrowEvent("Product_ProductCatalogue_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Product_ProductCatalogue_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Product_ProductCatalogueEventsProcess

	/// <exclude/>
	public partial class Product_ProductCatalogueEventsProcess<TEntity> : Terrasoft.Configuration.Product_ProductBaseEventsProcess<TEntity> where TEntity : Product_ProductCatalogue_Terrasoft
	{

		public Product_ProductCatalogueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Product_ProductCatalogueEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e2e35eeb-1d87-4ce0-b885-c3a8c6c23bd2");
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
					SchemaElementUId = new Guid("7e06e388-ced2-4eca-8ce1-ee29bc77fdb8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _productSaved;
		public ProcessFlowElement ProductSaved {
			get {
				return _productSaved ?? (_productSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ProductSaved",
					SchemaElementUId = new Guid("7b9bf1e0-4946-406e-b815-42e038ebb1ae"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _setPrices;
		public ProcessScriptTask SetPrices {
			get {
				return _setPrices ?? (_setPrices = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SetPrices",
					SchemaElementUId = new Guid("73a117ec-7b80-4f1d-9866-7b921e5e89e9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SetPricesExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[ProductSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { ProductSaved };
			FlowElements[SetPrices.SchemaElementUId] = new Collection<ProcessFlowElement> { SetPrices };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "ProductSaved":
						e.Context.QueueTasks.Enqueue("SetPrices");
						break;
					case "SetPrices":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ProductSaved");
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
				case "ProductSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProductSaved";
					result = ProductSaved.Execute(context);
					break;
				case "SetPrices":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetPrices";
					result = SetPrices.Execute(context, SetPricesExecute);
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

		public virtual bool SetPricesExecute(ProcessExecutingContext context) {
			var productPriceHelper = Terrasoft.Core.Factories.ClassFactory.Get<Terrasoft.Configuration.ProductPriceHelper>(
				new Terrasoft.Core.Factories.ConstructorArgument("userConnection", UserConnection));
			productPriceHelper.SetPriceInBasePriceList(Entity);
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Product_ProductCatalogue_TerrasoftSaved":
							if (ActivatedEventElements.Contains("ProductSaved")) {
							context.QueueTasks.Enqueue("ProductSaved");
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

	#region Class: Product_ProductCatalogueEventsProcess

	/// <exclude/>
	public class Product_ProductCatalogueEventsProcess : Product_ProductCatalogueEventsProcess<Product_ProductCatalogue_Terrasoft>
	{

		public Product_ProductCatalogueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Product_ProductCatalogueEventsProcess

	public partial class Product_ProductCatalogueEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: Product_ProductCatalogue_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Product_ProductCatalogue_TerrasoftEventsProcessSchema : Terrasoft.Configuration.Product_ProductBase_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public Product_ProductCatalogue_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Product_ProductCatalogue_TerrasoftEventsProcessSchema(Product_ProductCatalogue_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Product_ProductCatalogueEventsProcess";
			UId = new Guid("9b96b2c6-604e-4c43-97a9-947eba4a17cd");
			CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("140443d2-1551-411a-97e2-5d2d450a0335");
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
			ProcessSchemaStartMessageEvent productsaved = CreateProductSavedStartMessageEvent();
			eventsubprocess1.FlowElements.Add(productsaved);
			ProcessSchemaScriptTask setprices = CreateSetPricesScriptTask();
			eventsubprocess1.FlowElements.Add(setprices);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("63145cf3-d6af-4dec-8132-08de9f4fef10"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("140443d2-1551-411a-97e2-5d2d450a0335"),
				CreatedInPackageId = new Guid("741231e0-c6fd-4dea-b23f-a6b7a76d6de7"),
				CreatedInSchemaUId = new Guid("9b96b2c6-604e-4c43-97a9-947eba4a17cd"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("9b96b2c6-604e-4c43-97a9-947eba4a17cd"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7b9bf1e0-4946-406e-b815-42e038ebb1ae"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("73a117ec-7b80-4f1d-9866-7b921e5e89e9"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("31f6990f-7f0d-4d8b-ba1c-8c126b0bf5ad"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("140443d2-1551-411a-97e2-5d2d450a0335"),
				CreatedInPackageId = new Guid("741231e0-c6fd-4dea-b23f-a6b7a76d6de7"),
				CreatedInSchemaUId = new Guid("9b96b2c6-604e-4c43-97a9-947eba4a17cd"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("9b96b2c6-604e-4c43-97a9-947eba4a17cd"),
				Name = @"LaneSet1",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("17764ff2-8bda-4588-9078-d2846bb6338c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("31f6990f-7f0d-4d8b-ba1c-8c126b0bf5ad"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("741231e0-c6fd-4dea-b23f-a6b7a76d6de7"),
				CreatedInSchemaUId = new Guid("9b96b2c6-604e-4c43-97a9-947eba4a17cd"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("9b96b2c6-604e-4c43-97a9-947eba4a17cd"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7e06e388-ced2-4eca-8ce1-ee29bc77fdb8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("17764ff2-8bda-4588-9078-d2846bb6338c"),
				CreatedInOwnerSchemaUId = new Guid("140443d2-1551-411a-97e2-5d2d450a0335"),
				CreatedInPackageId = new Guid("741231e0-c6fd-4dea-b23f-a6b7a76d6de7"),
				CreatedInSchemaUId = new Guid("9b96b2c6-604e-4c43-97a9-947eba4a17cd"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("9b96b2c6-604e-4c43-97a9-947eba4a17cd"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 20),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(306, 300),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateProductSavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7b9bf1e0-4946-406e-b815-42e038ebb1ae"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7e06e388-ced2-4eca-8ce1-ee29bc77fdb8"),
				CreatedInOwnerSchemaUId = new Guid("140443d2-1551-411a-97e2-5d2d450a0335"),
				CreatedInPackageId = new Guid("741231e0-c6fd-4dea-b23f-a6b7a76d6de7"),
				CreatedInSchemaUId = new Guid("9b96b2c6-604e-4c43-97a9-947eba4a17cd"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ProductSaved",
				ModifiedInSchemaUId = new Guid("9b96b2c6-604e-4c43-97a9-947eba4a17cd"),
				Name = @"ProductSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(46, 118),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSetPricesScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("73a117ec-7b80-4f1d-9866-7b921e5e89e9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7e06e388-ced2-4eca-8ce1-ee29bc77fdb8"),
				CreatedInOwnerSchemaUId = new Guid("140443d2-1551-411a-97e2-5d2d450a0335"),
				CreatedInPackageId = new Guid("741231e0-c6fd-4dea-b23f-a6b7a76d6de7"),
				CreatedInSchemaUId = new Guid("9b96b2c6-604e-4c43-97a9-947eba4a17cd"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("9b96b2c6-604e-4c43-97a9-947eba4a17cd"),
				Name = @"SetPrices",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(191, 104),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,143,77,10,194,64,12,70,215,246,20,67,87,45,200,92,160,42,168,248,7,46,10,234,1,134,241,107,25,168,153,146,201,40,189,189,173,221,40,5,119,121,249,146,23,242,52,172,90,246,247,104,165,100,103,113,68,211,130,213,82,93,193,108,130,175,68,111,61,67,239,141,21,207,14,65,111,27,19,194,136,157,62,64,22,223,147,84,185,58,178,17,231,73,151,19,237,42,75,102,132,215,31,183,167,32,28,7,92,115,29,31,32,201,210,24,192,125,64,176,131,54,157,171,219,79,35,207,139,100,250,129,190,96,196,19,109,76,192,167,60,187,32,217,142,196,73,215,239,48,36,50,169,254,28,138,55,102,139,87,152,6,1,0,0 }
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
			return new Product_ProductCatalogue_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9b96b2c6-604e-4c43-97a9-947eba4a17cd"));
		}

		#endregion

	}

	#endregion

}

