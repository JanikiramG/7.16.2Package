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

	#region Class: DocumentProductSchema

	/// <exclude/>
	public class DocumentProductSchema : Terrasoft.Configuration.BaseProductEntrySchema
	{

		#region Constructors: Public

		public DocumentProductSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public DocumentProductSchema(DocumentProductSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public DocumentProductSchema(DocumentProductSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5bab82ce-a828-4259-8ed9-5416ea3a0113");
			RealUId = new Guid("5bab82ce-a828-4259-8ed9-5416ea3a0113");
			Name = "DocumentProduct";
			ParentSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateDocumentProductEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateDocumentProductEventsProcessSchema() {
			var schema = new DocumentProductEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new DocumentProduct(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new DocumentProduct_DocumentEventsProcess(userConnection);
		}

		public override object Clone() {
			return new DocumentProductSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new DocumentProductSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5bab82ce-a828-4259-8ed9-5416ea3a0113"));
		}

		#endregion

	}

	#endregion

	#region Class: DocumentProduct

	/// <summary>
	/// Product in document.
	/// </summary>
	public class DocumentProduct : Terrasoft.Configuration.BaseProductEntry
	{

		#region Constructors: Public

		public DocumentProduct(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "DocumentProduct";
		}

		public DocumentProduct(DocumentProduct source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new DocumentProduct_DocumentEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("DocumentProductDeleted", e);
			Deleting += (s, e) => ThrowEvent("DocumentProductDeleting", e);
			Inserted += (s, e) => ThrowEvent("DocumentProductInserted", e);
			Inserting += (s, e) => ThrowEvent("DocumentProductInserting", e);
			Saved += (s, e) => ThrowEvent("DocumentProductSaved", e);
			Saving += (s, e) => ThrowEvent("DocumentProductSaving", e);
			Validating += (s, e) => ThrowEvent("DocumentProductValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new DocumentProduct(this);
		}

		#endregion

	}

	#endregion

	#region Class: DocumentProduct_DocumentEventsProcess

	/// <exclude/>
	public partial class DocumentProduct_DocumentEventsProcess<TEntity> : Terrasoft.Configuration.BaseProductEntry_ProductCatalogueEventsProcess<TEntity> where TEntity : DocumentProduct
	{

		public DocumentProduct_DocumentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DocumentProduct_DocumentEventsProcess";
			SchemaUId = new Guid("5bab82ce-a828-4259-8ed9-5416ea3a0113");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5bab82ce-a828-4259-8ed9-5416ea3a0113");
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
					SchemaElementUId = new Guid("d5e8925e-16d4-40b1-813e-9e93a51896ae"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _documentProductSaved;
		public ProcessFlowElement DocumentProductSaved {
			get {
				return _documentProductSaved ?? (_documentProductSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DocumentProductSaved",
					SchemaElementUId = new Guid("2a8d994e-20cc-47bc-a63d-2b4e0bd2f102"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _documentProductDeleted;
		public ProcessFlowElement DocumentProductDeleted {
			get {
				return _documentProductDeleted ?? (_documentProductDeleted = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DocumentProductDeleted",
					SchemaElementUId = new Guid("74f1e84a-5397-4665-8de8-8cc927da6aba"),
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
					SchemaElementUId = new Guid("05bcf640-754e-4158-a7c4-2018d556e4cd"),
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

		private ProcessScriptTask _scriptAmountChange;
		public ProcessScriptTask ScriptAmountChange {
			get {
				return _scriptAmountChange ?? (_scriptAmountChange = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptAmountChange",
					SchemaElementUId = new Guid("eaada027-d022-4dc2-942e-4461de651d34"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptAmountChangeExecute,
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
					SchemaElementUId = new Guid("b3e19716-0b9a-49d2-a7f0-ae66b4e33ba5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _documentProductSaving;
		public ProcessFlowElement DocumentProductSaving {
			get {
				return _documentProductSaving ?? (_documentProductSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DocumentProductSaving",
					SchemaElementUId = new Guid("5e58d946-8a6b-4aee-a4b2-f19f2f5054a5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _documentProductSavingScriptTask;
		public ProcessScriptTask DocumentProductSavingScriptTask {
			get {
				return _documentProductSavingScriptTask ?? (_documentProductSavingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DocumentProductSavingScriptTask",
					SchemaElementUId = new Guid("defc0132-948f-4f10-b7c0-68fdf239474d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DocumentProductSavingScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[DocumentProductSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { DocumentProductSaved };
			FlowElements[DocumentProductDeleted.SchemaElementUId] = new Collection<ProcessFlowElement> { DocumentProductDeleted };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[ScriptAmountChange.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptAmountChange };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[DocumentProductSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { DocumentProductSaving };
			FlowElements[DocumentProductSavingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DocumentProductSavingScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "DocumentProductSaved":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway1");
						break;
					case "DocumentProductDeleted":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway1");
						break;
					case "ExclusiveGateway1":
							e.Context.QueueTasks.Enqueue("ScriptAmountChange");
						break;
					case "ScriptAmountChange":
						break;
					case "EventSubProcess2":
						break;
					case "DocumentProductSaving":
						e.Context.QueueTasks.Enqueue("DocumentProductSavingScriptTask");
						break;
					case "DocumentProductSavingScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("DocumentProductSaved");
			ActivatedEventElements.Add("DocumentProductDeleted");
			ActivatedEventElements.Add("DocumentProductSaving");
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
				case "DocumentProductSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "DocumentProductSaved";
					result = DocumentProductSaved.Execute(context);
					break;
				case "DocumentProductDeleted":
					context.QueueTasks.Dequeue();
					context.SenderName = "DocumentProductDeleted";
					result = DocumentProductDeleted.Execute(context);
					break;
				case "ExclusiveGateway1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway1";
					result = ExclusiveGateway1.Execute(context);
					break;
				case "ScriptAmountChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptAmountChange";
					result = ScriptAmountChange.Execute(context, ScriptAmountChangeExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "DocumentProductSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "DocumentProductSaving";
					result = DocumentProductSaving.Execute(context);
					break;
				case "DocumentProductSavingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DocumentProductSavingScriptTask";
					result = DocumentProductSavingScriptTask.Execute(context, DocumentProductSavingScriptTaskExecute);
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
			UpdateTotalAmmount(context);
			return true;
		}

		public virtual bool DocumentProductSavingScriptTaskExecute(ProcessExecutingContext context) {
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "DocumentProductSaved":
							if (ActivatedEventElements.Contains("DocumentProductSaved")) {
							context.QueueTasks.Enqueue("DocumentProductSaved");
						}
						break;
					case "DocumentProductDeleted":
							if (ActivatedEventElements.Contains("DocumentProductDeleted")) {
							context.QueueTasks.Enqueue("DocumentProductDeleted");
						}
						break;
					case "DocumentProductSaving":
							if (ActivatedEventElements.Contains("DocumentProductSaving")) {
							context.QueueTasks.Enqueue("DocumentProductSaving");
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

	#region Class: DocumentProduct_DocumentEventsProcess

	/// <exclude/>
	public class DocumentProduct_DocumentEventsProcess : DocumentProduct_DocumentEventsProcess<DocumentProduct>
	{

		public DocumentProduct_DocumentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: DocumentProduct_DocumentEventsProcess

	public partial class DocumentProduct_DocumentEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void UpdateTotalAmmount(ProcessExecutingContext context) {
		}

		#endregion

	}

	#endregion

	#region Class: DocumentProductEventsProcessSchema

	/// <exclude/>
	public class DocumentProductEventsProcessSchema : Terrasoft.Configuration.BaseProductEntryEventsProcessSchema
	{

		#region Constructors: Public

		public DocumentProductEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public DocumentProductEventsProcessSchema(DocumentProductEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "DocumentProduct_DocumentEventsProcess";
			UId = new Guid("cb2f3647-e12d-4ab4-8b9d-62055d9b5f0a");
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

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet676 = CreateLaneSet676LaneSet();
			LaneSets.Add(schemaLaneSet676);
			ProcessSchemaLane schemaLane2439 = CreateLane2439Lane();
			schemaLaneSet676.Lanes.Add(schemaLane2439);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaStartMessageEvent documentproductsaved = CreateDocumentProductSavedStartMessageEvent();
			eventsubprocess1.FlowElements.Add(documentproductsaved);
			ProcessSchemaStartMessageEvent documentproductdeleted = CreateDocumentProductDeletedStartMessageEvent();
			eventsubprocess1.FlowElements.Add(documentproductdeleted);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			eventsubprocess1.FlowElements.Add(exclusivegateway1);
			ProcessSchemaScriptTask scriptamountchange = CreateScriptAmountChangeScriptTask();
			eventsubprocess1.FlowElements.Add(scriptamountchange);
			ProcessSchemaStartMessageEvent documentproductsaving = CreateDocumentProductSavingStartMessageEvent();
			eventsubprocess2.FlowElements.Add(documentproductsaving);
			ProcessSchemaScriptTask documentproductsavingscripttask = CreateDocumentProductSavingScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(documentproductsavingscripttask);
			FlowElements.Add(CreateSequenceFlow14585SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14586SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14587SequenceFlow());
			FlowElements.Add(CreateFromDocumentProductSavingSequenceFlowSequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14585SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14585",
				UId = new Guid("5e06ceae-e9cc-4715-b928-4c2cd37c65fd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cb2f3647-e12d-4ab4-8b9d-62055d9b5f0a"),
				CurveCenterPosition = new Point(146, 72),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cb2f3647-e12d-4ab4-8b9d-62055d9b5f0a"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2a8d994e-20cc-47bc-a63d-2b4e0bd2f102"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("05bcf640-754e-4158-a7c4-2018d556e4cd"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14586SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14586",
				UId = new Guid("8c1fe4e7-a162-4cfa-af0d-85afe7da8ee9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cb2f3647-e12d-4ab4-8b9d-62055d9b5f0a"),
				CurveCenterPosition = new Point(146, 135),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cb2f3647-e12d-4ab4-8b9d-62055d9b5f0a"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("74f1e84a-5397-4665-8de8-8cc927da6aba"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("05bcf640-754e-4158-a7c4-2018d556e4cd"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14587SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14587",
				UId = new Guid("36de8a69-9a7e-4447-b17e-3d385acc2cc9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cb2f3647-e12d-4ab4-8b9d-62055d9b5f0a"),
				CurveCenterPosition = new Point(272, 113),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cb2f3647-e12d-4ab4-8b9d-62055d9b5f0a"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("05bcf640-754e-4158-a7c4-2018d556e4cd"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("eaada027-d022-4dc2-942e-4461de651d34"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateFromDocumentProductSavingSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "FromDocumentProductSavingSequenceFlow",
				UId = new Guid("670d77ff-fd60-4236-86d7-0009621622e3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6"),
				CreatedInSchemaUId = new Guid("cb2f3647-e12d-4ab4-8b9d-62055d9b5f0a"),
				CurveCenterPosition = new Point(153, 282),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cb2f3647-e12d-4ab4-8b9d-62055d9b5f0a"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5e58d946-8a6b-4aee-a4b2-f19f2f5054a5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("defc0132-948f-4f10-b7c0-68fdf239474d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet676LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet676 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("89ab192f-1fe0-4d35-bea1-3a9467628a23"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cb2f3647-e12d-4ab4-8b9d-62055d9b5f0a"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("cb2f3647-e12d-4ab4-8b9d-62055d9b5f0a"),
				Name = @"LaneSet676",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1566, 366),
				UseBackgroundMode = false
			};
			return schemaLaneSet676;
		}

		protected virtual ProcessSchemaLane CreateLane2439Lane() {
			ProcessSchemaLane schemaLane2439 = new ProcessSchemaLane(this) {
				UId = new Guid("9d908c62-38aa-4c60-bd69-15bd62cf8e2e"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("89ab192f-1fe0-4d35-bea1-3a9467628a23"),
				CreatedInOwnerSchemaUId = new Guid("5bab82ce-a828-4259-8ed9-5416ea3a0113"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cb2f3647-e12d-4ab4-8b9d-62055d9b5f0a"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("cb2f3647-e12d-4ab4-8b9d-62055d9b5f0a"),
				Name = @"Lane2439",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1537, 366),
				UseBackgroundMode = false
			};
			return schemaLane2439;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("d5e8925e-16d4-40b1-813e-9e93a51896ae"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9d908c62-38aa-4c60-bd69-15bd62cf8e2e"),
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cb2f3647-e12d-4ab4-8b9d-62055d9b5f0a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("cb2f3647-e12d-4ab4-8b9d-62055d9b5f0a"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(332, 184),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDocumentProductSavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2a8d994e-20cc-47bc-a63d-2b4e0bd2f102"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d5e8925e-16d4-40b1-813e-9e93a51896ae"),
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cb2f3647-e12d-4ab4-8b9d-62055d9b5f0a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DocumentProductSaved",
				ModifiedInSchemaUId = new Guid("cb2f3647-e12d-4ab4-8b9d-62055d9b5f0a"),
				Name = @"DocumentProductSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(14, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDocumentProductDeletedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("74f1e84a-5397-4665-8de8-8cc927da6aba"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d5e8925e-16d4-40b1-813e-9e93a51896ae"),
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cb2f3647-e12d-4ab4-8b9d-62055d9b5f0a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DocumentProductDeleted",
				ModifiedInSchemaUId = new Guid("cb2f3647-e12d-4ab4-8b9d-62055d9b5f0a"),
				Name = @"DocumentProductDeleted",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(14, 112),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("05bcf640-754e-4158-a7c4-2018d556e4cd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d5e8925e-16d4-40b1-813e-9e93a51896ae"),
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cb2f3647-e12d-4ab4-8b9d-62055d9b5f0a"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("cb2f3647-e12d-4ab4-8b9d-62055d9b5f0a"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(85, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptAmountChangeScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("eaada027-d022-4dc2-942e-4461de651d34"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d5e8925e-16d4-40b1-813e-9e93a51896ae"),
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cb2f3647-e12d-4ab4-8b9d-62055d9b5f0a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("cb2f3647-e12d-4ab4-8b9d-62055d9b5f0a"),
				Name = @"ScriptAmountChange",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(184, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,72,73,44,73,13,201,47,73,204,113,204,205,205,47,205,43,209,72,206,207,43,73,173,40,209,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,163,51,20,0,42,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b3e19716-0b9a-49d2-a7f0-ae66b4e33ba5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9d908c62-38aa-4c60-bd69-15bd62cf8e2e"),
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6"),
				CreatedInSchemaUId = new Guid("cb2f3647-e12d-4ab4-8b9d-62055d9b5f0a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("cb2f3647-e12d-4ab4-8b9d-62055d9b5f0a"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(28, 196),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(287, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDocumentProductSavingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5e58d946-8a6b-4aee-a4b2-f19f2f5054a5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b3e19716-0b9a-49d2-a7f0-ae66b4e33ba5"),
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6"),
				CreatedInSchemaUId = new Guid("cb2f3647-e12d-4ab4-8b9d-62055d9b5f0a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DocumentProductSaving",
				ModifiedInSchemaUId = new Guid("cb2f3647-e12d-4ab4-8b9d-62055d9b5f0a"),
				Name = @"DocumentProductSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(22, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDocumentProductSavingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("defc0132-948f-4f10-b7c0-68fdf239474d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b3e19716-0b9a-49d2-a7f0-ae66b4e33ba5"),
				CreatedInOwnerSchemaUId = new Guid("59da4081-3496-4397-a03c-e312f6d2ef8b"),
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6"),
				CreatedInSchemaUId = new Guid("cb2f3647-e12d-4ab4-8b9d-62055d9b5f0a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("cb2f3647-e12d-4ab4-8b9d-62055d9b5f0a"),
				Name = @"DocumentProductSavingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(92, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateUpdateTotalAmmountMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("79429dbf-ff17-43c9-9bb0-2d3efacc0a39"),
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

		protected virtual SchemaMethod CreateUpdateTotalAmmountMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1579de00-0c04-40e4-9904-eb53941aa337"),
				Name = "UpdateTotalAmmount",
				CreatedInSchemaUId = new Guid("cb2f3647-e12d-4ab4-8b9d-62055d9b5f0a"),
				CreatedInPackageId = new Guid("28d2d89d-6ad5-4902-8cd7-83b80d442232"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("362d20c0-8676-45f1-abe2-354dd5fdc5d0"),
				Name = "context",
				CreatedInSchemaUId = new Guid("cb2f3647-e12d-4ab4-8b9d-62055d9b5f0a"),
				ModifiedInSchemaUId = new Guid("cb2f3647-e12d-4ab4-8b9d-62055d9b5f0a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext",
				CreatedInPackageId = new Guid("28d2d89d-6ad5-4902-8cd7-83b80d442232")
			});
			method.ZipBody = new byte[] {  };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new DocumentProductEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cb2f3647-e12d-4ab4-8b9d-62055d9b5f0a"));
		}

		#endregion

	}

	#endregion


	#region Class: DocumentProductEventsProcess

	/// <exclude/>
	public class DocumentProductEventsProcess : DocumentProduct_DocumentEventsProcess
	{

		public DocumentProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

