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

	#region Class: ScoringModelSchema

	/// <exclude/>
	public class ScoringModelSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ScoringModelSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ScoringModelSchema(ScoringModelSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ScoringModelSchema(ScoringModelSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3dfc230a-58bc-4ab3-9dbe-7eb8225edfa0");
			RealUId = new Guid("3dfc230a-58bc-4ab3-9dbe-7eb8225edfa0");
			Name = "ScoringModel";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("2172ffdc-40f1-4f25-9efc-3451f9e465a1");
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
			if (Columns.FindByUId(new Guid("04e671fb-4cf2-478f-a837-2190a6cc61a7")) == null) {
				Columns.Add(CreateIsActiveColumn());
			}
			if (Columns.FindByUId(new Guid("b5d2dfb5-8c24-4ae9-9c15-abbe00698f79")) == null) {
				Columns.Add(CreateSourceModelColumn());
			}
			if (Columns.FindByUId(new Guid("ca5b9620-32cf-4d8f-a792-d79accf4ea2b")) == null) {
				Columns.Add(CreateScoringObjectColumn());
			}
			if (Columns.FindByUId(new Guid("4bc379a1-d441-402f-98e7-37dedcec5dd5")) == null) {
				Columns.Add(CreateColumnUIdColumn());
			}
			if (Columns.FindByUId(new Guid("cf62f13d-11ec-46aa-a547-3994ceb74c13")) == null) {
				Columns.Add(CreateColumnCaptionColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("329f12fa-b2e8-4aad-9361-eed8935548ac"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("3dfc230a-58bc-4ab3-9dbe-7eb8225edfa0"),
				ModifiedInSchemaUId = new Guid("3dfc230a-58bc-4ab3-9dbe-7eb8225edfa0"),
				CreatedInPackageId = new Guid("2172ffdc-40f1-4f25-9efc-3451f9e465a1")
			};
		}

		protected virtual EntitySchemaColumn CreateIsActiveColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("04e671fb-4cf2-478f-a837-2190a6cc61a7"),
				Name = @"IsActive",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("3dfc230a-58bc-4ab3-9dbe-7eb8225edfa0"),
				ModifiedInSchemaUId = new Guid("3dfc230a-58bc-4ab3-9dbe-7eb8225edfa0"),
				CreatedInPackageId = new Guid("2172ffdc-40f1-4f25-9efc-3451f9e465a1")
			};
		}

		protected virtual EntitySchemaColumn CreateSourceModelColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b5d2dfb5-8c24-4ae9-9c15-abbe00698f79"),
				Name = @"SourceModel",
				ReferenceSchemaUId = new Guid("3dfc230a-58bc-4ab3-9dbe-7eb8225edfa0"),
				IsValueCloneable = false,
				IsIndexed = true,
				IsWeakReference = true,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("3dfc230a-58bc-4ab3-9dbe-7eb8225edfa0"),
				ModifiedInSchemaUId = new Guid("3dfc230a-58bc-4ab3-9dbe-7eb8225edfa0"),
				CreatedInPackageId = new Guid("3d7df93a-399a-4bbe-9b09-fe2c0e15eb28")
			};
		}

		protected virtual EntitySchemaColumn CreateScoringObjectColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ca5b9620-32cf-4d8f-a792-d79accf4ea2b"),
				Name = @"ScoringObject",
				ReferenceSchemaUId = new Guid("a2d407a1-cda4-4344-ac71-88a4e2bf9c28"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsWeakReference = true,
				CreatedInSchemaUId = new Guid("3dfc230a-58bc-4ab3-9dbe-7eb8225edfa0"),
				ModifiedInSchemaUId = new Guid("3dfc230a-58bc-4ab3-9dbe-7eb8225edfa0"),
				CreatedInPackageId = new Guid("2172ffdc-40f1-4f25-9efc-3451f9e465a1")
			};
		}

		protected virtual EntitySchemaColumn CreateColumnUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("4bc379a1-d441-402f-98e7-37dedcec5dd5"),
				Name = @"ColumnUId",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("3dfc230a-58bc-4ab3-9dbe-7eb8225edfa0"),
				ModifiedInSchemaUId = new Guid("3dfc230a-58bc-4ab3-9dbe-7eb8225edfa0"),
				CreatedInPackageId = new Guid("2172ffdc-40f1-4f25-9efc-3451f9e465a1")
			};
		}

		protected virtual EntitySchemaColumn CreateColumnCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("cf62f13d-11ec-46aa-a547-3994ceb74c13"),
				Name = @"ColumnCaption",
				CreatedInSchemaUId = new Guid("3dfc230a-58bc-4ab3-9dbe-7eb8225edfa0"),
				ModifiedInSchemaUId = new Guid("3dfc230a-58bc-4ab3-9dbe-7eb8225edfa0"),
				CreatedInPackageId = new Guid("2172ffdc-40f1-4f25-9efc-3451f9e465a1")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateScoringModelEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateScoringModelEventsProcessSchema() {
			var schema = new ScoringModelEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ScoringModel(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ScoringModel_BaseScoringEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ScoringModelSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ScoringModelSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3dfc230a-58bc-4ab3-9dbe-7eb8225edfa0"));
		}

		#endregion

	}

	#endregion

	#region Class: ScoringModel

	/// <summary>
	/// Scoring model.
	/// </summary>
	public class ScoringModel : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ScoringModel(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ScoringModel";
		}

		public ScoringModel(ScoringModel source)
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
		/// Active.
		/// </summary>
		public bool IsActive {
			get {
				return GetTypedColumnValue<bool>("IsActive");
			}
			set {
				SetColumnValue("IsActive", value);
			}
		}

		/// <exclude/>
		public Guid SourceModelId {
			get {
				return GetTypedColumnValue<Guid>("SourceModelId");
			}
			set {
				SetColumnValue("SourceModelId", value);
				_sourceModel = null;
			}
		}

		/// <exclude/>
		public string SourceModelName {
			get {
				return GetTypedColumnValue<string>("SourceModelName");
			}
			set {
				SetColumnValue("SourceModelName", value);
				if (_sourceModel != null) {
					_sourceModel.Name = value;
				}
			}
		}

		private ScoringModel _sourceModel;
		/// <summary>
		/// Source model.
		/// </summary>
		public ScoringModel SourceModel {
			get {
				return _sourceModel ??
					(_sourceModel = LookupColumnEntities.GetEntity("SourceModel") as ScoringModel);
			}
		}

		/// <exclude/>
		public Guid ScoringObjectId {
			get {
				return GetTypedColumnValue<Guid>("ScoringObjectId");
			}
			set {
				SetColumnValue("ScoringObjectId", value);
				_scoringObject = null;
			}
		}

		/// <exclude/>
		public string ScoringObjectName {
			get {
				return GetTypedColumnValue<string>("ScoringObjectName");
			}
			set {
				SetColumnValue("ScoringObjectName", value);
				if (_scoringObject != null) {
					_scoringObject.Name = value;
				}
			}
		}

		private VwSysModuleEntity _scoringObject;
		/// <summary>
		/// Scoring object.
		/// </summary>
		public VwSysModuleEntity ScoringObject {
			get {
				return _scoringObject ??
					(_scoringObject = LookupColumnEntities.GetEntity("ScoringObject") as VwSysModuleEntity);
			}
		}

		/// <summary>
		/// Scoring parameter UId.
		/// </summary>
		public Guid ColumnUId {
			get {
				return GetTypedColumnValue<Guid>("ColumnUId");
			}
			set {
				SetColumnValue("ColumnUId", value);
			}
		}

		/// <summary>
		/// Scoring parameter.
		/// </summary>
		public string ColumnCaption {
			get {
				return GetTypedColumnValue<string>("ColumnCaption");
			}
			set {
				SetColumnValue("ColumnCaption", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ScoringModel_BaseScoringEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ScoringModelDeleted", e);
			Inserted += (s, e) => ThrowEvent("ScoringModelInserted", e);
			Validating += (s, e) => ThrowEvent("ScoringModelValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ScoringModel(this);
		}

		#endregion

	}

	#endregion

	#region Class: ScoringModel_BaseScoringEventsProcess

	/// <exclude/>
	public partial class ScoringModel_BaseScoringEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : ScoringModel
	{

		public ScoringModel_BaseScoringEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ScoringModel_BaseScoringEventsProcess";
			SchemaUId = new Guid("3dfc230a-58bc-4ab3-9dbe-7eb8225edfa0");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("3dfc230a-58bc-4ab3-9dbe-7eb8225edfa0");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _insertedEventSubProcess;
		public ProcessFlowElement InsertedEventSubProcess {
			get {
				return _insertedEventSubProcess ?? (_insertedEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "InsertedEventSubProcess",
					SchemaElementUId = new Guid("a82fc2d3-b203-4930-a0c0-2018326e07e4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _scoringModelInsertedStartMessage;
		public ProcessFlowElement ScoringModelInsertedStartMessage {
			get {
				return _scoringModelInsertedStartMessage ?? (_scoringModelInsertedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ScoringModelInsertedStartMessage",
					SchemaElementUId = new Guid("106a82ea-2148-44e6-9cae-e5e4d0191489"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _insertedScriptTask;
		public ProcessScriptTask InsertedScriptTask {
			get {
				return _insertedScriptTask ?? (_insertedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InsertedScriptTask",
					SchemaElementUId = new Guid("620d1517-541c-476f-b536-bacb7d1650b6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InsertedScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[InsertedEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { InsertedEventSubProcess };
			FlowElements[ScoringModelInsertedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ScoringModelInsertedStartMessage };
			FlowElements[InsertedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InsertedScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "InsertedEventSubProcess":
						break;
					case "ScoringModelInsertedStartMessage":
						e.Context.QueueTasks.Enqueue("InsertedScriptTask");
						break;
					case "InsertedScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ScoringModelInsertedStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "InsertedEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ScoringModelInsertedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScoringModelInsertedStartMessage";
					result = ScoringModelInsertedStartMessage.Execute(context);
					break;
				case "InsertedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "InsertedScriptTask";
					result = InsertedScriptTask.Execute(context, InsertedScriptTaskExecute);
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

		public virtual bool InsertedScriptTaskExecute(ProcessExecutingContext context) {
			return OnInserted(context);
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ScoringModelInserted":
							if (ActivatedEventElements.Contains("ScoringModelInsertedStartMessage")) {
							context.QueueTasks.Enqueue("ScoringModelInsertedStartMessage");
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

	#region Class: ScoringModel_BaseScoringEventsProcess

	/// <exclude/>
	public class ScoringModel_BaseScoringEventsProcess : ScoringModel_BaseScoringEventsProcess<ScoringModel>
	{

		public ScoringModel_BaseScoringEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ScoringModel_BaseScoringEventsProcess

	public partial class ScoringModel_BaseScoringEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual bool OnInserted(ProcessExecutingContext context) {
			CopyRules();
			return true;
		}

		public virtual void CopyRules() {
			if (!Entity.GetIsColumnValueLoaded("SourceModelId")) {
				return;
			}
			Guid sourceModelId = Entity.GetTypedColumnValue<Guid>("SourceModelId");
			if (sourceModelId.IsEmpty()) {
				return;
			}
			Guid recordId = Entity.GetTypedColumnValue<Guid>("Id");
			EntitySchema schema = UserConnection.EntitySchemaManager.GetInstanceByName("ScoringRule");
			var esq = new EntitySchemaQuery(schema);
			esq.AddAllSchemaColumns();
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal,
				false, "ScoringModel", sourceModelId));
			EntityCollection entities = esq.GetEntityCollection(UserConnection);
			foreach(Entity scoringRule in entities) {
				var scoringRuleCopy = (Terrasoft.Configuration.ScoringRule)scoringRule.Clone();
				scoringRuleCopy.SetColumnValue("Id", Guid.NewGuid());
				scoringRuleCopy.SetColumnValue("ScoringModelId", recordId);
				scoringRuleCopy.Save();
			}
		}

		#endregion

	}

	#endregion

	#region Class: ScoringModelEventsProcessSchema

	/// <exclude/>
	public class ScoringModelEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public ScoringModelEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ScoringModelEventsProcessSchema(ScoringModelEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ScoringModel_BaseScoringEventsProcess";
			UId = new Guid("0e00cf68-8f28-4882-ad48-8de0c390af30");
			CreatedInPackageId = new Guid("2172ffdc-40f1-4f25-9efc-3451f9e465a1");
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
			ProcessSchemaEventSubProcess insertedeventsubprocess = CreateInsertedEventSubProcessEventSubProcess();
			FlowElements.Add(insertedeventsubprocess);
			ProcessSchemaStartMessageEvent scoringmodelinsertedstartmessage = CreateScoringModelInsertedStartMessageStartMessageEvent();
			insertedeventsubprocess.FlowElements.Add(scoringmodelinsertedstartmessage);
			ProcessSchemaScriptTask insertedscripttask = CreateInsertedScriptTaskScriptTask();
			insertedeventsubprocess.FlowElements.Add(insertedscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("6fba82e0-e60c-4c2f-b08e-c6c0e18b678e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("3d7df93a-399a-4bbe-9b09-fe2c0e15eb28"),
				CreatedInSchemaUId = new Guid("0e00cf68-8f28-4882-ad48-8de0c390af30"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0e00cf68-8f28-4882-ad48-8de0c390af30"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("106a82ea-2148-44e6-9cae-e5e4d0191489"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("620d1517-541c-476f-b536-bacb7d1650b6"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("4a4c388d-aff0-4d1d-8d8a-4fbaedcbdaeb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("3d7df93a-399a-4bbe-9b09-fe2c0e15eb28"),
				CreatedInSchemaUId = new Guid("0e00cf68-8f28-4882-ad48-8de0c390af30"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("0e00cf68-8f28-4882-ad48-8de0c390af30"),
				Name = @"LaneSet1",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("57a2d42c-22f0-4176-983d-d7f4b070b4d6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4a4c388d-aff0-4d1d-8d8a-4fbaedcbdaeb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("3d7df93a-399a-4bbe-9b09-fe2c0e15eb28"),
				CreatedInSchemaUId = new Guid("0e00cf68-8f28-4882-ad48-8de0c390af30"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("0e00cf68-8f28-4882-ad48-8de0c390af30"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateInsertedEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaInsertedEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a82fc2d3-b203-4930-a0c0-2018326e07e4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("57a2d42c-22f0-4176-983d-d7f4b070b4d6"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("3d7df93a-399a-4bbe-9b09-fe2c0e15eb28"),
				CreatedInSchemaUId = new Guid("0e00cf68-8f28-4882-ad48-8de0c390af30"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0e00cf68-8f28-4882-ad48-8de0c390af30"),
				Name = @"InsertedEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 20),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(300, 144),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaInsertedEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateScoringModelInsertedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("106a82ea-2148-44e6-9cae-e5e4d0191489"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a82fc2d3-b203-4930-a0c0-2018326e07e4"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("3d7df93a-399a-4bbe-9b09-fe2c0e15eb28"),
				CreatedInSchemaUId = new Guid("0e00cf68-8f28-4882-ad48-8de0c390af30"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ScoringModelInserted",
				ModifiedInSchemaUId = new Guid("0e00cf68-8f28-4882-ad48-8de0c390af30"),
				Name = @"ScoringModelInsertedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInsertedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("620d1517-541c-476f-b536-bacb7d1650b6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a82fc2d3-b203-4930-a0c0-2018326e07e4"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("3d7df93a-399a-4bbe-9b09-fe2c0e15eb28"),
				CreatedInSchemaUId = new Guid("0e00cf68-8f28-4882-ad48-8de0c390af30"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0e00cf68-8f28-4882-ad48-8de0c390af30"),
				Name = @"InsertedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(191, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,240,207,243,204,43,78,45,42,73,77,209,72,206,207,43,73,173,40,209,180,6,0,8,79,86,81,27,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateOnInsertedMethod());
			Methods.Add(CreateCopyRulesMethod());
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

		protected virtual SchemaMethod CreateOnInsertedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1c719022-0c22-42bc-8163-bdd4e81baa30"),
				Name = "OnInserted",
				CreatedInSchemaUId = new Guid("0e00cf68-8f28-4882-ad48-8de0c390af30"),
				CreatedInPackageId = new Guid("3d7df93a-399a-4bbe-9b09-fe2c0e15eb28"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b5bb5eeb-a4e9-4da7-ab8e-775849fdb48f"),
				Name = "context",
				CreatedInSchemaUId = new Guid("0e00cf68-8f28-4882-ad48-8de0c390af30"),
				ModifiedInSchemaUId = new Guid("0e00cf68-8f28-4882-ad48-8de0c390af30"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext",
				CreatedInPackageId = new Guid("3d7df93a-399a-4bbe-9b09-fe2c0e15eb28")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,206,47,168,12,42,205,73,45,214,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,205,97,18,243,25,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCopyRulesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7839a139-9159-45cc-8902-a8a00159c627"),
				Name = "CopyRules",
				CreatedInSchemaUId = new Guid("0e00cf68-8f28-4882-ad48-8de0c390af30"),
				CreatedInPackageId = new Guid("3d7df93a-399a-4bbe-9b09-fe2c0e15eb28"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,203,110,194,48,16,60,147,175,112,57,57,82,228,31,160,84,162,17,69,72,5,181,133,182,103,43,222,128,37,199,6,63,64,81,197,191,215,142,11,24,202,129,147,229,221,241,204,236,172,121,141,240,195,88,90,110,91,50,1,59,53,165,18,174,145,95,84,56,120,85,148,1,195,253,133,114,186,130,153,98,32,166,172,159,231,232,39,235,105,176,78,203,65,118,200,38,142,51,100,82,8,26,162,51,227,178,221,0,75,72,31,3,254,233,31,233,32,227,222,201,5,13,153,154,113,179,177,45,190,169,168,161,82,154,221,41,22,21,34,110,81,173,161,161,200,196,99,136,62,13,232,82,73,9,149,229,74,146,20,52,163,146,174,64,119,193,72,99,169,172,224,185,157,211,6,188,125,175,206,229,234,195,9,8,212,59,170,17,152,173,167,147,176,71,41,199,187,3,221,226,168,230,129,30,68,70,140,141,132,136,237,104,214,224,191,214,11,23,22,180,9,16,28,238,165,6,106,33,86,191,185,93,191,81,237,229,3,4,199,98,169,154,13,213,220,40,25,102,39,227,173,163,162,200,122,53,21,6,10,116,180,217,37,218,47,46,215,148,159,34,241,38,68,28,31,65,40,112,48,126,146,160,239,39,191,134,224,203,192,60,73,173,188,203,106,141,35,210,39,123,138,6,241,51,99,183,196,144,83,210,47,213,166,245,74,120,9,90,83,163,106,75,60,113,205,87,78,211,110,25,73,202,121,242,140,148,66,73,8,153,245,174,200,200,2,108,178,255,110,243,5,10,191,128,204,97,31,78,156,223,243,44,205,173,163,56,126,183,155,143,233,174,51,115,248,5,114,91,62,178,77,3,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ScoringModelEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0e00cf68-8f28-4882-ad48-8de0c390af30"));
		}

		#endregion

	}

	#endregion


	#region Class: ScoringModelEventsProcess

	/// <exclude/>
	public class ScoringModelEventsProcess : ScoringModel_BaseScoringEventsProcess
	{

		public ScoringModelEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

