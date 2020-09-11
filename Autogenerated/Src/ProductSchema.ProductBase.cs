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

	#region Class: Product_ProductBase_TerrasoftSchema

	/// <exclude/>
	public class Product_ProductBase_TerrasoftSchema : Terrasoft.Configuration.Product_Base_TerrasoftSchema
	{

		#region Constructors: Public

		public Product_ProductBase_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Product_ProductBase_TerrasoftSchema(Product_ProductBase_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Product_ProductBase_TerrasoftSchema(Product_ProductBase_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("8f3e9f02-7d38-42e3-9363-21bb922a4893");
			Name = "Product_ProductBase_Terrasoft";
			ParentSchemaUId = new Guid("4c7a6ead-4eb8-4fc0-863e-98a664569fed");
			ExtendParent = true;
			CreatedInPackageId = new Guid("a08eefe5-e3d9-4a0c-8558-f93b596572d7");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryImageColumn() {
			base.InitializePrimaryImageColumn();
			PrimaryImageColumn = CreatePictureColumn();
			if (Columns.FindByUId(PrimaryImageColumn.UId) == null) {
				Columns.Add(PrimaryImageColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("3f6a282b-4d25-4f87-b63a-4a192abd19f6")) == null) {
				Columns.Add(CreateIsArchiveColumn());
			}
		}

		protected override EntitySchemaColumn CreateUnitColumn() {
			EntitySchemaColumn column = base.CreateUnitColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Settings,
				ValueSource = @"DefaultUnit"
			};
			column.ModifiedInSchemaUId = new Guid("8f3e9f02-7d38-42e3-9363-21bb922a4893");
			column.CreatedInPackageId = new Guid("a08eefe5-e3d9-4a0c-8558-f93b596572d7");
			return column;
		}

		protected override EntitySchemaColumn CreateTaxColumn() {
			EntitySchemaColumn column = base.CreateTaxColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Settings,
				ValueSource = @"DefaultTax"
			};
			column.ModifiedInSchemaUId = new Guid("8f3e9f02-7d38-42e3-9363-21bb922a4893");
			column.CreatedInPackageId = new Guid("a08eefe5-e3d9-4a0c-8558-f93b596572d7");
			return column;
		}

		protected override EntitySchemaColumn CreateActiveColumn() {
			EntitySchemaColumn column = base.CreateActiveColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("8f3e9f02-7d38-42e3-9363-21bb922a4893");
			column.CreatedInPackageId = new Guid("a08eefe5-e3d9-4a0c-8558-f93b596572d7");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("8f3e9f02-7d38-42e3-9363-21bb922a4893");
			column.CreatedInPackageId = new Guid("a08eefe5-e3d9-4a0c-8558-f93b596572d7");
			return column;
		}

		protected override EntitySchemaColumn CreateProductSourceColumn() {
			EntitySchemaColumn column = base.CreateProductSourceColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("8f3e9f02-7d38-42e3-9363-21bb922a4893");
			column.CreatedInPackageId = new Guid("a08eefe5-e3d9-4a0c-8558-f93b596572d7");
			return column;
		}

		protected virtual EntitySchemaColumn CreatePictureColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ImageLookup")) {
				UId = new Guid("3da5d5e7-908f-4cb2-81af-aa137eabb041"),
				Name = @"Picture",
				ReferenceSchemaUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8f3e9f02-7d38-42e3-9363-21bb922a4893"),
				ModifiedInSchemaUId = new Guid("8f3e9f02-7d38-42e3-9363-21bb922a4893"),
				CreatedInPackageId = new Guid("a08eefe5-e3d9-4a0c-8558-f93b596572d7")
			};
		}

		protected virtual EntitySchemaColumn CreateIsArchiveColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("3f6a282b-4d25-4f87-b63a-4a192abd19f6"),
				Name = @"IsArchive",
				CreatedInSchemaUId = new Guid("8f3e9f02-7d38-42e3-9363-21bb922a4893"),
				ModifiedInSchemaUId = new Guid("8f3e9f02-7d38-42e3-9363-21bb922a4893"),
				CreatedInPackageId = new Guid("a08eefe5-e3d9-4a0c-8558-f93b596572d7")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateProduct_ProductBase_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateProduct_ProductBase_TerrasoftEventsProcessSchema() {
			var schema = new Product_ProductBase_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Product_ProductBase_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Product_ProductBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Product_ProductBase_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Product_ProductBase_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8f3e9f02-7d38-42e3-9363-21bb922a4893"));
		}

		#endregion

	}

	#endregion

	#region Class: Product_ProductBase_Terrasoft

	/// <summary>
	/// Product.
	/// </summary>
	public class Product_ProductBase_Terrasoft : Terrasoft.Configuration.Product_Base_Terrasoft
	{

		#region Constructors: Public

		public Product_ProductBase_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Product_ProductBase_Terrasoft";
		}

		public Product_ProductBase_Terrasoft(Product_ProductBase_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid PictureId {
			get {
				return GetTypedColumnValue<Guid>("PictureId");
			}
			set {
				SetColumnValue("PictureId", value);
				_picture = null;
			}
		}

		/// <exclude/>
		public string PictureName {
			get {
				return GetTypedColumnValue<string>("PictureName");
			}
			set {
				SetColumnValue("PictureName", value);
				if (_picture != null) {
					_picture.Name = value;
				}
			}
		}

		private SysImage _picture;
		/// <summary>
		/// Image.
		/// </summary>
		public SysImage Picture {
			get {
				return _picture ??
					(_picture = LookupColumnEntities.GetEntity("Picture") as SysImage);
			}
		}

		/// <summary>
		/// Inactive.
		/// </summary>
		public bool IsArchive {
			get {
				return GetTypedColumnValue<bool>("IsArchive");
			}
			set {
				SetColumnValue("IsArchive", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Product_ProductBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Product_ProductBase_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("Product_ProductBase_TerrasoftInserting", e);
			Saving += (s, e) => ThrowEvent("Product_ProductBase_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Product_ProductBase_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Product_ProductBase_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Product_ProductBaseEventsProcess

	/// <exclude/>
	public partial class Product_ProductBaseEventsProcess<TEntity> : Terrasoft.Configuration.Product_BaseEventsProcess<TEntity> where TEntity : Product_ProductBase_Terrasoft
	{

		public Product_ProductBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Product_ProductBaseEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8f3e9f02-7d38-42e3-9363-21bb922a4893");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _productSaveEventSubProcess;
		public ProcessFlowElement ProductSaveEventSubProcess {
			get {
				return _productSaveEventSubProcess ?? (_productSaveEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ProductSaveEventSubProcess",
					SchemaElementUId = new Guid("5d23c651-dbbc-4da8-89f4-a86b3ec21240"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage1ProductSaving;
		public ProcessFlowElement StartMessage1ProductSaving {
			get {
				return _startMessage1ProductSaving ?? (_startMessage1ProductSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage1ProductSaving",
					SchemaElementUId = new Guid("7b63df84-d087-49cc-9010-5d592eae87f0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent1ProductSaving;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent1ProductSaving {
			get {
				return _intermediateThrowMessageEvent1ProductSaving ?? (_intermediateThrowMessageEvent1ProductSaving = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent1ProductSaving",
					SchemaElementUId = new Guid("f12e0710-110a-4e20-b352-9cdcc62cc8c3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "ProductInserting",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptTask1ProductSaving;
		public ProcessScriptTask ScriptTask1ProductSaving {
			get {
				return _scriptTask1ProductSaving ?? (_scriptTask1ProductSaving = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask1ProductSaving",
					SchemaElementUId = new Guid("6a4e3dc4-08e4-463f-80ef-bac86bbc777c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1ProductSavingExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[ProductSaveEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ProductSaveEventSubProcess };
			FlowElements[StartMessage1ProductSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1ProductSaving };
			FlowElements[IntermediateThrowMessageEvent1ProductSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1ProductSaving };
			FlowElements[ScriptTask1ProductSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1ProductSaving };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "ProductSaveEventSubProcess":
						break;
					case "StartMessage1ProductSaving":
						e.Context.QueueTasks.Enqueue("ScriptTask1ProductSaving");
						break;
					case "IntermediateThrowMessageEvent1ProductSaving":
						break;
					case "ScriptTask1ProductSaving":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1ProductSaving");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage1ProductSaving");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "ProductSaveEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage1ProductSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1ProductSaving";
					result = StartMessage1ProductSaving.Execute(context);
					break;
				case "IntermediateThrowMessageEvent1ProductSaving":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "ProductInserting");
					result = IntermediateThrowMessageEvent1ProductSaving.Execute(context);
					break;
				case "ScriptTask1ProductSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1ProductSaving";
					result = ScriptTask1ProductSaving.Execute(context, ScriptTask1ProductSavingExecute);
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

		public virtual bool ScriptTask1ProductSavingExecute(ProcessExecutingContext context) {
			var pictureId = Entity.GetColumnValue("PictureId");
			if (pictureId == null) { 
				return true;
			}
			var entitySchemaQuery = new EntitySchemaQuery(UserConnection.EntitySchemaManager, Entity.Schema.Name);
			entitySchemaQuery.PrimaryQueryColumn.IsAlwaysSelect = true;
			entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
				"Picture.Id", pictureId));
			var entities = entitySchemaQuery.GetEntityCollection(UserConnection);
			if (entities.Count > 0) {
				var pictureESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "SysImage");
				pictureESQ.AddAllSchemaColumns();
				var picture = pictureESQ.GetEntity(UserConnection, pictureId);
				if (picture != null) {
					Guid pictureNewGuid = Guid.NewGuid();
					var sysImageSchema = UserConnection.EntitySchemaManager.GetInstanceByName("SysImage");
					var sysImage = sysImageSchema.CreateEntity(UserConnection);
					sysImage.SetDefColumnValues();
					sysImage.SetColumnValue("Id", pictureNewGuid);
					sysImage.SetColumnValue("Name", picture.GetTypedColumnValue<string>("Name"));
					sysImage.SetColumnValue("Data", picture.GetColumnValue("Data"));
					sysImage.SetColumnValue("MimeType", picture.GetTypedColumnValue<string>("MimeType"));
					sysImage.SetColumnValue("HasRef", picture.GetTypedColumnValue<bool>("HasRef"));
					sysImage.SetColumnValue("PreviewData", picture.GetColumnValue("PreviewData"));
					sysImage.Save();
					Entity.SetColumnValue("PictureId", pictureNewGuid);
				}
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Product_ProductBase_TerrasoftInserting":
							if (ActivatedEventElements.Contains("StartMessage1ProductSaving")) {
							context.QueueTasks.Enqueue("StartMessage1ProductSaving");
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

	#region Class: Product_ProductBaseEventsProcess

	/// <exclude/>
	public class Product_ProductBaseEventsProcess : Product_ProductBaseEventsProcess<Product_ProductBase_Terrasoft>
	{

		public Product_ProductBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Product_ProductBaseEventsProcess

	public partial class Product_ProductBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: Product_ProductBase_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Product_ProductBase_TerrasoftEventsProcessSchema : Terrasoft.Configuration.Product_Base_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public Product_ProductBase_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Product_ProductBase_TerrasoftEventsProcessSchema(Product_ProductBase_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Product_ProductBaseEventsProcess";
			UId = new Guid("140443d2-1551-411a-97e2-5d2d450a0335");
			CreatedInPackageId = new Guid("a08eefe5-e3d9-4a0c-8558-f93b596572d7");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("0f71e524-927e-4d3c-af6f-6f36b3474b7f");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaProductLaneSet = CreateProductLaneSetLaneSet();
			LaneSets.Add(schemaProductLaneSet);
			ProcessSchemaLane schemaProductSaveLane = CreateProductSaveLaneLane();
			schemaProductLaneSet.Lanes.Add(schemaProductSaveLane);
			ProcessSchemaEventSubProcess productsaveeventsubprocess = CreateProductSaveEventSubProcessEventSubProcess();
			FlowElements.Add(productsaveeventsubprocess);
			ProcessSchemaStartMessageEvent startmessage1productsaving = CreateStartMessage1ProductSavingStartMessageEvent();
			productsaveeventsubprocess.FlowElements.Add(startmessage1productsaving);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1productsaving = CreateIntermediateThrowMessageEvent1ProductSavingIntermediateThrowMessageEvent();
			productsaveeventsubprocess.FlowElements.Add(intermediatethrowmessageevent1productsaving);
			ProcessSchemaScriptTask scripttask1productsaving = CreateScriptTask1ProductSavingScriptTask();
			productsaveeventsubprocess.FlowElements.Add(scripttask1productsaving);
			FlowElements.Add(CreateSequenceFlow1ProductSavingSequenceFlow());
			FlowElements.Add(CreateSequenceFlow2ProductSavingSequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1ProductSavingSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1ProductSaving",
				UId = new Guid("18bca8cd-23b9-4684-82ce-9cf8234b4f15"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("0f71e524-927e-4d3c-af6f-6f36b3474b7f"),
				CreatedInPackageId = new Guid("1eb9138a-f179-4185-b9bd-8d61ab83dbd7"),
				CreatedInSchemaUId = new Guid("140443d2-1551-411a-97e2-5d2d450a0335"),
				CurveCenterPosition = new Point(210, 92),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("140443d2-1551-411a-97e2-5d2d450a0335"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7b63df84-d087-49cc-9010-5d592eae87f0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6a4e3dc4-08e4-463f-80ef-bac86bbc777c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2ProductSavingSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2ProductSaving",
				UId = new Guid("b100b9d5-a035-4562-a3cf-5b1cd89e75df"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("0f71e524-927e-4d3c-af6f-6f36b3474b7f"),
				CreatedInPackageId = new Guid("1eb9138a-f179-4185-b9bd-8d61ab83dbd7"),
				CreatedInSchemaUId = new Guid("140443d2-1551-411a-97e2-5d2d450a0335"),
				CurveCenterPosition = new Point(404, 101),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("140443d2-1551-411a-97e2-5d2d450a0335"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6a4e3dc4-08e4-463f-80ef-bac86bbc777c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f12e0710-110a-4e20-b352-9cdcc62cc8c3"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateProductLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaProductLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("9269b90f-3972-4ae2-8ffe-ca9aea3030d9"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("0f71e524-927e-4d3c-af6f-6f36b3474b7f"),
				CreatedInPackageId = new Guid("1eb9138a-f179-4185-b9bd-8d61ab83dbd7"),
				CreatedInSchemaUId = new Guid("140443d2-1551-411a-97e2-5d2d450a0335"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("140443d2-1551-411a-97e2-5d2d450a0335"),
				Name = @"ProductLaneSet",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1032, 192),
				UseBackgroundMode = false
			};
			return schemaProductLaneSet;
		}

		protected virtual ProcessSchemaLane CreateProductSaveLaneLane() {
			ProcessSchemaLane schemaProductSaveLane = new ProcessSchemaLane(this) {
				UId = new Guid("eaac08b0-4acf-417f-aa1f-65af5afc94fd"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("9269b90f-3972-4ae2-8ffe-ca9aea3030d9"),
				CreatedInOwnerSchemaUId = new Guid("8f3e9f02-7d38-42e3-9363-21bb922a4893"),
				CreatedInPackageId = new Guid("1eb9138a-f179-4185-b9bd-8d61ab83dbd7"),
				CreatedInSchemaUId = new Guid("140443d2-1551-411a-97e2-5d2d450a0335"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("140443d2-1551-411a-97e2-5d2d450a0335"),
				Name = @"ProductSaveLane",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1003, 192),
				UseBackgroundMode = false
			};
			return schemaProductSaveLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateProductSaveEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaProductSaveEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5d23c651-dbbc-4da8-89f4-a86b3ec21240"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("eaac08b0-4acf-417f-aa1f-65af5afc94fd"),
				CreatedInOwnerSchemaUId = new Guid("0f71e524-927e-4d3c-af6f-6f36b3474b7f"),
				CreatedInPackageId = new Guid("1eb9138a-f179-4185-b9bd-8d61ab83dbd7"),
				CreatedInSchemaUId = new Guid("140443d2-1551-411a-97e2-5d2d450a0335"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("140443d2-1551-411a-97e2-5d2d450a0335"),
				Name = @"ProductSaveEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(56, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(435, 164),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaProductSaveEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1ProductSavingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7b63df84-d087-49cc-9010-5d592eae87f0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5d23c651-dbbc-4da8-89f4-a86b3ec21240"),
				CreatedInOwnerSchemaUId = new Guid("0f71e524-927e-4d3c-af6f-6f36b3474b7f"),
				CreatedInPackageId = new Guid("1eb9138a-f179-4185-b9bd-8d61ab83dbd7"),
				CreatedInSchemaUId = new Guid("140443d2-1551-411a-97e2-5d2d450a0335"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ProductInserting",
				ModifiedInSchemaUId = new Guid("140443d2-1551-411a-97e2-5d2d450a0335"),
				Name = @"StartMessage1ProductSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(22, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1ProductSavingIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("f12e0710-110a-4e20-b352-9cdcc62cc8c3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5d23c651-dbbc-4da8-89f4-a86b3ec21240"),
				CreatedInOwnerSchemaUId = new Guid("0f71e524-927e-4d3c-af6f-6f36b3474b7f"),
				CreatedInPackageId = new Guid("1eb9138a-f179-4185-b9bd-8d61ab83dbd7"),
				CreatedInSchemaUId = new Guid("140443d2-1551-411a-97e2-5d2d450a0335"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"ProductInserting",
				ModifiedInSchemaUId = new Guid("140443d2-1551-411a-97e2-5d2d450a0335"),
				Name = @"IntermediateThrowMessageEvent1ProductSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(372, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ProductSavingScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6a4e3dc4-08e4-463f-80ef-bac86bbc777c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5d23c651-dbbc-4da8-89f4-a86b3ec21240"),
				CreatedInOwnerSchemaUId = new Guid("0f71e524-927e-4d3c-af6f-6f36b3474b7f"),
				CreatedInPackageId = new Guid("1eb9138a-f179-4185-b9bd-8d61ab83dbd7"),
				CreatedInSchemaUId = new Guid("140443d2-1551-411a-97e2-5d2d450a0335"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("140443d2-1551-411a-97e2-5d2d450a0335"),
				Name = @"ScriptTask1ProductSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(169, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,84,203,110,219,48,16,60,219,128,255,129,245,73,6,12,162,247,214,6,92,197,77,125,72,224,84,77,123,102,172,117,66,128,162,92,62,100,8,69,254,189,75,145,146,41,43,133,2,244,100,139,154,157,153,157,93,177,98,138,156,248,193,88,5,187,156,172,200,86,26,110,106,122,11,38,45,133,45,228,79,38,44,36,243,125,11,153,47,62,205,166,252,72,146,168,104,69,164,21,98,65,254,144,217,116,162,0,143,37,49,202,2,34,95,103,211,10,21,160,97,205,14,47,80,176,7,11,170,70,37,9,231,160,22,157,39,143,26,84,90,74,9,7,195,75,73,99,192,29,147,236,25,212,178,245,232,79,233,61,43,192,153,26,104,208,189,226,5,83,117,243,224,187,161,59,189,17,103,86,235,12,4,42,160,139,224,115,88,252,149,11,3,74,211,77,158,39,195,183,169,2,102,192,99,126,113,243,178,103,10,109,184,130,196,31,166,101,113,98,138,235,82,254,168,79,64,183,191,45,19,75,151,79,27,37,197,44,151,151,232,23,174,133,46,42,14,26,189,13,101,113,44,190,121,108,71,248,136,174,18,107,199,211,210,208,180,180,210,144,53,249,136,243,65,249,234,50,239,109,246,240,95,99,152,103,181,222,21,248,191,217,137,201,133,213,101,182,17,194,195,125,240,58,105,48,145,58,74,71,21,93,99,87,202,113,66,142,32,218,60,242,161,219,59,124,49,185,181,60,111,193,247,112,110,30,87,196,253,208,240,232,45,52,30,116,112,238,45,34,110,188,95,103,113,39,181,97,242,0,95,106,183,116,201,85,0,61,102,228,236,139,132,149,121,179,75,95,222,226,105,6,230,6,142,209,247,23,210,235,33,122,159,103,188,75,161,219,145,10,215,192,165,198,53,231,246,52,143,48,159,181,81,92,62,175,3,118,49,66,120,195,12,235,19,14,95,143,113,220,241,2,156,141,247,26,235,240,99,196,223,152,254,14,199,17,218,167,178,20,235,14,59,70,185,87,80,113,56,143,180,29,163,6,140,172,130,48,216,246,70,251,231,173,251,230,116,95,155,251,53,190,112,255,2,29,4,119,35,206,5,0,0 }
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
				CreatedInPackageId = new Guid("a08eefe5-e3d9-4a0c-8558-f93b596572d7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("a08eefe5-e3d9-4a0c-8558-f93b596572d7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("a08eefe5-e3d9-4a0c-8558-f93b596572d7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("a08eefe5-e3d9-4a0c-8558-f93b596572d7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("a08eefe5-e3d9-4a0c-8558-f93b596572d7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("a08eefe5-e3d9-4a0c-8558-f93b596572d7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("a08eefe5-e3d9-4a0c-8558-f93b596572d7")
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
			return new Product_ProductBase_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("140443d2-1551-411a-97e2-5d2d450a0335"));
		}

		#endregion

	}

	#endregion

}

