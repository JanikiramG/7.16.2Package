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

	#region Class: ProductCatalogueLevelSchema

	/// <exclude/>
	public class ProductCatalogueLevelSchema : Terrasoft.Configuration.BaseEntityWithPositionSchema
	{

		#region Constructors: Public

		public ProductCatalogueLevelSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ProductCatalogueLevelSchema(ProductCatalogueLevelSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ProductCatalogueLevelSchema(ProductCatalogueLevelSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b");
			RealUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b");
			Name = "ProductCatalogueLevel";
			ParentSchemaUId = new Guid("73d33bed-4682-45cb-ad25-a29b5ab88c96");
			ExtendParent = false;
			CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
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
			PrimaryOrderColumn = CreatePositionColumn();
			if (Columns.FindByUId(PrimaryOrderColumn.UId) == null) {
				Columns.Add(PrimaryOrderColumn);
			}
		}

		protected override void InitializeOwnerColumn() {
			base.InitializeOwnerColumn();
			OwnerColumn = CreateCreatedByColumn();
			if (Columns.FindByUId(OwnerColumn.UId) == null) {
				Columns.Add(OwnerColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("11536eea-7fb7-4afe-826f-8111a5490a74")) == null) {
				Columns.Add(CreateDescriptionColumn());
			}
			if (Columns.FindByUId(new Guid("c0388918-b497-4635-a136-cd125a6474ce")) == null) {
				Columns.Add(CreateColumnCaptionColumn());
			}
			if (Columns.FindByUId(new Guid("7e2a9c23-8528-4e3c-acc0-c4ed42bd9c65")) == null) {
				Columns.Add(CreateColumnPathColumn());
			}
			if (Columns.FindByUId(new Guid("015b2058-0373-438a-86bb-e690d5164fbc")) == null) {
				Columns.Add(CreateReferenceSchemaNameColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b");
			column.CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b");
			column.CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b");
			column.CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b");
			column.CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b");
			column.CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b");
			column.CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			return column;
		}

		protected override EntitySchemaColumn CreatePositionColumn() {
			EntitySchemaColumn column = base.CreatePositionColumn();
			column.ModifiedInSchemaUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b");
			column.CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			return column;
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("06940a6e-2b82-480b-b530-8a9b838ca679"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b"),
				ModifiedInSchemaUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateDescriptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("11536eea-7fb7-4afe-826f-8111a5490a74"),
				Name = @"Description",
				CreatedInSchemaUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b"),
				ModifiedInSchemaUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			};
		}

		protected virtual EntitySchemaColumn CreateColumnCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("c0388918-b497-4635-a136-cd125a6474ce"),
				Name = @"ColumnCaption",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b"),
				ModifiedInSchemaUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateColumnPathColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("7e2a9c23-8528-4e3c-acc0-c4ed42bd9c65"),
				Name = @"ColumnPath",
				CreatedInSchemaUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b"),
				ModifiedInSchemaUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			};
		}

		protected virtual EntitySchemaColumn CreateReferenceSchemaNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("015b2058-0373-438a-86bb-e690d5164fbc"),
				Name = @"ReferenceSchemaName",
				CreatedInSchemaUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b"),
				ModifiedInSchemaUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateProductCatalogueLevelEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateProductCatalogueLevelEventsProcessSchema() {
			var schema = new ProductCatalogueLevelEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ProductCatalogueLevel(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ProductCatalogueLevel_ProductCatalogueEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ProductCatalogueLevelSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ProductCatalogueLevelSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b"));
		}

		#endregion

	}

	#endregion

	#region Class: ProductCatalogueLevel

	/// <summary>
	/// Product catalog level.
	/// </summary>
	public class ProductCatalogueLevel : Terrasoft.Configuration.BaseEntityWithPosition
	{

		#region Constructors: Public

		public ProductCatalogueLevel(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ProductCatalogueLevel";
		}

		public ProductCatalogueLevel(ProductCatalogueLevel source)
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

		/// <summary>
		/// Product field.
		/// </summary>
		public string ColumnCaption {
			get {
				return GetTypedColumnValue<string>("ColumnCaption");
			}
			set {
				SetColumnValue("ColumnCaption", value);
			}
		}

		/// <summary>
		/// Column path.
		/// </summary>
		public string ColumnPath {
			get {
				return GetTypedColumnValue<string>("ColumnPath");
			}
			set {
				SetColumnValue("ColumnPath", value);
			}
		}

		/// <summary>
		/// Schema.
		/// </summary>
		public string ReferenceSchemaName {
			get {
				return GetTypedColumnValue<string>("ReferenceSchemaName");
			}
			set {
				SetColumnValue("ReferenceSchemaName", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ProductCatalogueLevel_ProductCatalogueEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleting += (s, e) => ThrowEvent("ProductCatalogueLevelDeleting", e);
			Inserting += (s, e) => ThrowEvent("ProductCatalogueLevelInserting", e);
			Saving += (s, e) => ThrowEvent("ProductCatalogueLevelSaving", e);
			Validating += (s, e) => ThrowEvent("ProductCatalogueLevelValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ProductCatalogueLevel(this);
		}

		#endregion

	}

	#endregion

	#region Class: ProductCatalogueLevel_ProductCatalogueEventsProcess

	/// <exclude/>
	public partial class ProductCatalogueLevel_ProductCatalogueEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntityWithPosition_BaseEventsProcess<TEntity> where TEntity : ProductCatalogueLevel
	{

		public ProductCatalogueLevel_ProductCatalogueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProductCatalogueLevel_ProductCatalogueEventsProcess";
			SchemaUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _productCatalogueLevelEventSubProcess;
		public ProcessFlowElement ProductCatalogueLevelEventSubProcess {
			get {
				return _productCatalogueLevelEventSubProcess ?? (_productCatalogueLevelEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ProductCatalogueLevelEventSubProcess",
					SchemaElementUId = new Guid("87a96c21-c10c-427f-9dcb-c09d28470339"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _productCatalogueLevelInsertingStartMessage;
		public ProcessFlowElement ProductCatalogueLevelInsertingStartMessage {
			get {
				return _productCatalogueLevelInsertingStartMessage ?? (_productCatalogueLevelInsertingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ProductCatalogueLevelInsertingStartMessage",
					SchemaElementUId = new Guid("b8b62284-30e3-4e5d-acda-44dd0e66e827"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _productCatalogueLevelSavingStartMessage;
		public ProcessFlowElement ProductCatalogueLevelSavingStartMessage {
			get {
				return _productCatalogueLevelSavingStartMessage ?? (_productCatalogueLevelSavingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ProductCatalogueLevelSavingStartMessage",
					SchemaElementUId = new Guid("e6e35e08-df7a-4e9c-bcce-1f94baf92a0e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _productCatalogueLevelDeletingStartMessage;
		public ProcessFlowElement ProductCatalogueLevelDeletingStartMessage {
			get {
				return _productCatalogueLevelDeletingStartMessage ?? (_productCatalogueLevelDeletingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ProductCatalogueLevelDeletingStartMessage",
					SchemaElementUId = new Guid("77bb370c-ce35-474d-9678-da4756e2383d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _checkCanManageLookupsScriptTask;
		public ProcessScriptTask CheckCanManageLookupsScriptTask {
			get {
				return _checkCanManageLookupsScriptTask ?? (_checkCanManageLookupsScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CheckCanManageLookupsScriptTask",
					SchemaElementUId = new Guid("695aee0d-20d6-40fc-b4f9-89906aa4eeec"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CheckCanManageLookupsScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[ProductCatalogueLevelEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ProductCatalogueLevelEventSubProcess };
			FlowElements[ProductCatalogueLevelInsertingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ProductCatalogueLevelInsertingStartMessage };
			FlowElements[ProductCatalogueLevelSavingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ProductCatalogueLevelSavingStartMessage };
			FlowElements[ProductCatalogueLevelDeletingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ProductCatalogueLevelDeletingStartMessage };
			FlowElements[CheckCanManageLookupsScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckCanManageLookupsScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "ProductCatalogueLevelEventSubProcess":
						break;
					case "ProductCatalogueLevelInsertingStartMessage":
						e.Context.QueueTasks.Enqueue("CheckCanManageLookupsScriptTask");
						break;
					case "ProductCatalogueLevelSavingStartMessage":
						e.Context.QueueTasks.Enqueue("CheckCanManageLookupsScriptTask");
						break;
					case "ProductCatalogueLevelDeletingStartMessage":
						e.Context.QueueTasks.Enqueue("CheckCanManageLookupsScriptTask");
						break;
					case "CheckCanManageLookupsScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ProductCatalogueLevelInsertingStartMessage");
			ActivatedEventElements.Add("ProductCatalogueLevelSavingStartMessage");
			ActivatedEventElements.Add("ProductCatalogueLevelDeletingStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "ProductCatalogueLevelEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ProductCatalogueLevelInsertingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProductCatalogueLevelInsertingStartMessage";
					result = ProductCatalogueLevelInsertingStartMessage.Execute(context);
					break;
				case "ProductCatalogueLevelSavingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProductCatalogueLevelSavingStartMessage";
					result = ProductCatalogueLevelSavingStartMessage.Execute(context);
					break;
				case "ProductCatalogueLevelDeletingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProductCatalogueLevelDeletingStartMessage";
					result = ProductCatalogueLevelDeletingStartMessage.Execute(context);
					break;
				case "CheckCanManageLookupsScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CheckCanManageLookupsScriptTask";
					result = CheckCanManageLookupsScriptTask.Execute(context, CheckCanManageLookupsScriptTaskExecute);
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

		public virtual bool CheckCanManageLookupsScriptTaskExecute(ProcessExecutingContext context) {
			UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageLookups");
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ProductCatalogueLevelInserting":
							if (ActivatedEventElements.Contains("ProductCatalogueLevelInsertingStartMessage")) {
							context.QueueTasks.Enqueue("ProductCatalogueLevelInsertingStartMessage");
						}
						break;
					case "ProductCatalogueLevelSaving":
							if (ActivatedEventElements.Contains("ProductCatalogueLevelSavingStartMessage")) {
							context.QueueTasks.Enqueue("ProductCatalogueLevelSavingStartMessage");
						}
						break;
					case "ProductCatalogueLevelDeleting":
							if (ActivatedEventElements.Contains("ProductCatalogueLevelDeletingStartMessage")) {
							context.QueueTasks.Enqueue("ProductCatalogueLevelDeletingStartMessage");
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

	#region Class: ProductCatalogueLevel_ProductCatalogueEventsProcess

	/// <exclude/>
	public class ProductCatalogueLevel_ProductCatalogueEventsProcess : ProductCatalogueLevel_ProductCatalogueEventsProcess<ProductCatalogueLevel>
	{

		public ProductCatalogueLevel_ProductCatalogueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ProductCatalogueLevel_ProductCatalogueEventsProcess

	public partial class ProductCatalogueLevel_ProductCatalogueEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: ProductCatalogueLevelEventsProcessSchema

	/// <exclude/>
	public class ProductCatalogueLevelEventsProcessSchema : Terrasoft.Configuration.BaseEntityWithPositionEventsProcessSchema
	{

		#region Constructors: Public

		public ProductCatalogueLevelEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ProductCatalogueLevelEventsProcessSchema(ProductCatalogueLevelEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ProductCatalogueLevel_ProductCatalogueEventsProcess";
			UId = new Guid("a769df6d-3764-4f25-b590-b264af38116e");
			CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaProductCatalogueLevelLaneSet = CreateProductCatalogueLevelLaneSetLaneSet();
			LaneSets.Add(schemaProductCatalogueLevelLaneSet);
			ProcessSchemaLane schemaProductCatalogueLevelLane = CreateProductCatalogueLevelLaneLane();
			schemaProductCatalogueLevelLaneSet.Lanes.Add(schemaProductCatalogueLevelLane);
			ProcessSchemaEventSubProcess productcatalogueleveleventsubprocess = CreateProductCatalogueLevelEventSubProcessEventSubProcess();
			FlowElements.Add(productcatalogueleveleventsubprocess);
			ProcessSchemaStartMessageEvent productcataloguelevelinsertingstartmessage = CreateProductCatalogueLevelInsertingStartMessageStartMessageEvent();
			productcatalogueleveleventsubprocess.FlowElements.Add(productcataloguelevelinsertingstartmessage);
			ProcessSchemaStartMessageEvent productcataloguelevelsavingstartmessage = CreateProductCatalogueLevelSavingStartMessageStartMessageEvent();
			productcatalogueleveleventsubprocess.FlowElements.Add(productcataloguelevelsavingstartmessage);
			ProcessSchemaStartMessageEvent productcatalogueleveldeletingstartmessage = CreateProductCatalogueLevelDeletingStartMessageStartMessageEvent();
			productcatalogueleveleventsubprocess.FlowElements.Add(productcatalogueleveldeletingstartmessage);
			ProcessSchemaScriptTask checkcanmanagelookupsscripttask = CreateCheckCanManageLookupsScriptTaskScriptTask();
			FlowElements.Add(checkcanmanagelookupsscripttask);
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("cee8fac4-ef9d-4dae-b68f-ccf227609772"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				CreatedInPackageId = new Guid("e5841969-52d9-4705-bbcb-d468696db6c8"),
				CreatedInSchemaUId = new Guid("a769df6d-3764-4f25-b590-b264af38116e"),
				CurveCenterPosition = new Point(200, 68),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a769df6d-3764-4f25-b590-b264af38116e"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b8b62284-30e3-4e5d-acda-44dd0e66e827"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("695aee0d-20d6-40fc-b4f9-89906aa4eeec"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("21c1958c-ebd5-46ed-80bf-93a543c75ab9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				CreatedInPackageId = new Guid("e5841969-52d9-4705-bbcb-d468696db6c8"),
				CreatedInSchemaUId = new Guid("a769df6d-3764-4f25-b590-b264af38116e"),
				CurveCenterPosition = new Point(202, 101),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a769df6d-3764-4f25-b590-b264af38116e"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e6e35e08-df7a-4e9c-bcce-1f94baf92a0e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("695aee0d-20d6-40fc-b4f9-89906aa4eeec"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("458a65b4-a0e6-477d-9b3e-ccc94942ed70"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				CreatedInPackageId = new Guid("e5841969-52d9-4705-bbcb-d468696db6c8"),
				CreatedInSchemaUId = new Guid("a769df6d-3764-4f25-b590-b264af38116e"),
				CurveCenterPosition = new Point(205, 136),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a769df6d-3764-4f25-b590-b264af38116e"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("77bb370c-ce35-474d-9678-da4756e2383d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("695aee0d-20d6-40fc-b4f9-89906aa4eeec"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateProductCatalogueLevelLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaProductCatalogueLevelLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("6f192a27-8776-4627-ad06-dfa33e471fa2"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				CreatedInPackageId = new Guid("e5841969-52d9-4705-bbcb-d468696db6c8"),
				CreatedInSchemaUId = new Guid("a769df6d-3764-4f25-b590-b264af38116e"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("a769df6d-3764-4f25-b590-b264af38116e"),
				Name = @"ProductCatalogueLevelLaneSet",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(529, 233),
				UseBackgroundMode = false
			};
			return schemaProductCatalogueLevelLaneSet;
		}

		protected virtual ProcessSchemaLane CreateProductCatalogueLevelLaneLane() {
			ProcessSchemaLane schemaProductCatalogueLevelLane = new ProcessSchemaLane(this) {
				UId = new Guid("7740f67d-2c03-437e-8e49-3c61173848d7"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("6f192a27-8776-4627-ad06-dfa33e471fa2"),
				CreatedInOwnerSchemaUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b"),
				CreatedInPackageId = new Guid("e5841969-52d9-4705-bbcb-d468696db6c8"),
				CreatedInSchemaUId = new Guid("a769df6d-3764-4f25-b590-b264af38116e"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("a769df6d-3764-4f25-b590-b264af38116e"),
				Name = @"ProductCatalogueLevelLane",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(500, 233),
				UseBackgroundMode = false
			};
			return schemaProductCatalogueLevelLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateProductCatalogueLevelEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaProductCatalogueLevelEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("87a96c21-c10c-427f-9dcb-c09d28470339"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7740f67d-2c03-437e-8e49-3c61173848d7"),
				CreatedInOwnerSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				CreatedInPackageId = new Guid("e5841969-52d9-4705-bbcb-d468696db6c8"),
				CreatedInSchemaUId = new Guid("a769df6d-3764-4f25-b590-b264af38116e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a769df6d-3764-4f25-b590-b264af38116e"),
				Name = @"ProductCatalogueLevelEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(112, 212),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaProductCatalogueLevelEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateProductCatalogueLevelInsertingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b8b62284-30e3-4e5d-acda-44dd0e66e827"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("87a96c21-c10c-427f-9dcb-c09d28470339"),
				CreatedInOwnerSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				CreatedInPackageId = new Guid("e5841969-52d9-4705-bbcb-d468696db6c8"),
				CreatedInSchemaUId = new Guid("a769df6d-3764-4f25-b590-b264af38116e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ProductCatalogueLevelInserting",
				ModifiedInSchemaUId = new Guid("a769df6d-3764-4f25-b590-b264af38116e"),
				Name = @"ProductCatalogueLevelInsertingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(43, 16),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateProductCatalogueLevelSavingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e6e35e08-df7a-4e9c-bcce-1f94baf92a0e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("87a96c21-c10c-427f-9dcb-c09d28470339"),
				CreatedInOwnerSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				CreatedInPackageId = new Guid("e5841969-52d9-4705-bbcb-d468696db6c8"),
				CreatedInSchemaUId = new Guid("a769df6d-3764-4f25-b590-b264af38116e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ProductCatalogueLevelSaving",
				ModifiedInSchemaUId = new Guid("a769df6d-3764-4f25-b590-b264af38116e"),
				Name = @"ProductCatalogueLevelSavingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(43, 79),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateProductCatalogueLevelDeletingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("77bb370c-ce35-474d-9678-da4756e2383d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("87a96c21-c10c-427f-9dcb-c09d28470339"),
				CreatedInOwnerSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				CreatedInPackageId = new Guid("e5841969-52d9-4705-bbcb-d468696db6c8"),
				CreatedInSchemaUId = new Guid("a769df6d-3764-4f25-b590-b264af38116e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ProductCatalogueLevelDeleting",
				ModifiedInSchemaUId = new Guid("a769df6d-3764-4f25-b590-b264af38116e"),
				Name = @"ProductCatalogueLevelDeletingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(42, 140),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCheckCanManageLookupsScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("695aee0d-20d6-40fc-b4f9-89906aa4eeec"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7740f67d-2c03-437e-8e49-3c61173848d7"),
				CreatedInOwnerSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				CreatedInPackageId = new Guid("e5841969-52d9-4705-bbcb-d468696db6c8"),
				CreatedInSchemaUId = new Guid("a769df6d-3764-4f25-b590-b264af38116e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a769df6d-3764-4f25-b590-b264af38116e"),
				Name = @"CheckCanManageLookupsScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(225, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,78,45,114,206,207,203,75,77,46,201,204,207,211,115,113,10,78,77,46,45,202,44,169,116,205,75,207,204,75,213,115,206,72,77,206,118,78,204,115,173,0,138,151,164,250,23,164,22,37,130,84,106,40,1,5,125,19,243,18,211,83,125,242,243,179,75,11,138,149,52,173,121,185,138,82,75,74,139,242,20,74,138,74,83,173,1,55,130,180,236,91,0,0,0 }
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
			return new ProductCatalogueLevelEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a769df6d-3764-4f25-b590-b264af38116e"));
		}

		#endregion

	}

	#endregion


	#region Class: ProductCatalogueLevelEventsProcess

	/// <exclude/>
	public class ProductCatalogueLevelEventsProcess : ProductCatalogueLevel_ProductCatalogueEventsProcess
	{

		public ProductCatalogueLevelEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

