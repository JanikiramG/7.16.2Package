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

	#region Class: BaseLookupSchema

	/// <exclude/>
	[IsVirtual]
	public class BaseLookupSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public BaseLookupSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BaseLookupSchema(BaseLookupSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BaseLookupSchema(BaseLookupSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			RealUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			Name = "BaseLookup";
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
			if (Columns.FindByUId(new Guid("9e53fd7c-dde4-4502-a64c-b9e34148108b")) == null) {
				Columns.Add(CreateDescriptionColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("736c30a7-c0ec-4fa9-b034-2552b319b633"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75"),
				ModifiedInSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateDescriptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("9e53fd7c-dde4-4502-a64c-b9e34148108b"),
				Name = @"Description",
				CreatedInSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75"),
				ModifiedInSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f"),
				IsLocalizable = true
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBaseLookupEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateBaseLookupEventsProcessSchema() {
			var schema = new BaseLookupEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BaseLookup(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BaseLookup_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BaseLookupSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BaseLookupSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75"));
		}

		#endregion

	}

	#endregion

	#region Class: BaseLookup

	/// <summary>
	/// Base lookup.
	/// </summary>
	public class BaseLookup : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public BaseLookup(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BaseLookup";
		}

		public BaseLookup(BaseLookup source)
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

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BaseLookup_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("BaseLookupDeleted", e);
			Deleting += (s, e) => ThrowEvent("BaseLookupDeleting", e);
			Inserted += (s, e) => ThrowEvent("BaseLookupInserted", e);
			Inserting += (s, e) => ThrowEvent("BaseLookupInserting", e);
			Saved += (s, e) => ThrowEvent("BaseLookupSaved", e);
			Saving += (s, e) => ThrowEvent("BaseLookupSaving", e);
			Validating += (s, e) => ThrowEvent("BaseLookupValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseLookup(this);
		}

		#endregion

	}

	#endregion

	#region Class: BaseLookup_BaseEventsProcess

	/// <exclude/>
	public partial class BaseLookup_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : BaseLookup
	{

		public BaseLookup_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseLookup_BaseEventsProcess";
			SchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _baseLookupEventSubProcess;
		public ProcessFlowElement BaseLookupEventSubProcess {
			get {
				return _baseLookupEventSubProcess ?? (_baseLookupEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BaseLookupEventSubProcess",
					SchemaElementUId = new Guid("e57d317f-6f21-48a8-9999-5ecf05719145"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseLookupInsertingStartMessage;
		public ProcessFlowElement BaseLookupInsertingStartMessage {
			get {
				return _baseLookupInsertingStartMessage ?? (_baseLookupInsertingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseLookupInsertingStartMessage",
					SchemaElementUId = new Guid("9f186c66-1b04-4f3f-a712-2aadefc904c7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseLookupSavingStartMessage;
		public ProcessFlowElement BaseLookupSavingStartMessage {
			get {
				return _baseLookupSavingStartMessage ?? (_baseLookupSavingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseLookupSavingStartMessage",
					SchemaElementUId = new Guid("48ed15e5-1285-49c5-8946-0344c7a15bbe"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseLookupDeletingStartMessage;
		public ProcessFlowElement BaseLookupDeletingStartMessage {
			get {
				return _baseLookupDeletingStartMessage ?? (_baseLookupDeletingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseLookupDeletingStartMessage",
					SchemaElementUId = new Guid("e0bb263d-5a8e-4ea3-a9e2-c824eb9ec5aa"),
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
					SchemaElementUId = new Guid("bdca0c6b-eb97-4d14-83df-aa53b214c463"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CheckCanManageLookupsScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[BaseLookupEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseLookupEventSubProcess };
			FlowElements[BaseLookupInsertingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseLookupInsertingStartMessage };
			FlowElements[BaseLookupSavingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseLookupSavingStartMessage };
			FlowElements[BaseLookupDeletingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseLookupDeletingStartMessage };
			FlowElements[CheckCanManageLookupsScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckCanManageLookupsScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "BaseLookupEventSubProcess":
						break;
					case "BaseLookupInsertingStartMessage":
						e.Context.QueueTasks.Enqueue("CheckCanManageLookupsScriptTask");
						break;
					case "BaseLookupSavingStartMessage":
						e.Context.QueueTasks.Enqueue("CheckCanManageLookupsScriptTask");
						break;
					case "BaseLookupDeletingStartMessage":
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
			ActivatedEventElements.Add("BaseLookupInsertingStartMessage");
			ActivatedEventElements.Add("BaseLookupSavingStartMessage");
			ActivatedEventElements.Add("BaseLookupDeletingStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "BaseLookupEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "BaseLookupInsertingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseLookupInsertingStartMessage";
					result = BaseLookupInsertingStartMessage.Execute(context);
					break;
				case "BaseLookupSavingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseLookupSavingStartMessage";
					result = BaseLookupSavingStartMessage.Execute(context);
					break;
				case "BaseLookupDeletingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseLookupDeletingStartMessage";
					result = BaseLookupDeletingStartMessage.Execute(context);
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
			CheckCanManageLookups();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "BaseLookupInserting":
							if (ActivatedEventElements.Contains("BaseLookupInsertingStartMessage")) {
							context.QueueTasks.Enqueue("BaseLookupInsertingStartMessage");
						}
						break;
					case "BaseLookupSaving":
							if (ActivatedEventElements.Contains("BaseLookupSavingStartMessage")) {
							context.QueueTasks.Enqueue("BaseLookupSavingStartMessage");
						}
						break;
					case "BaseLookupDeleting":
							if (ActivatedEventElements.Contains("BaseLookupDeletingStartMessage")) {
							context.QueueTasks.Enqueue("BaseLookupDeletingStartMessage");
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

	#region Class: BaseLookup_BaseEventsProcess

	/// <exclude/>
	public class BaseLookup_BaseEventsProcess : BaseLookup_BaseEventsProcess<BaseLookup>
	{

		public BaseLookup_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BaseLookup_BaseEventsProcess

	public partial class BaseLookup_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void CheckCanManageLookups() {
			UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageLookups");
		}

		#endregion

	}

	#endregion

	#region Class: BaseLookupEventsProcessSchema

	/// <exclude/>
	public class BaseLookupEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public BaseLookupEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BaseLookupEventsProcessSchema(BaseLookupEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BaseLookup_BaseEventsProcess";
			UId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1");
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
			ProcessSchemaLaneSet schemaBaseLookupLaneSet = CreateBaseLookupLaneSetLaneSet();
			LaneSets.Add(schemaBaseLookupLaneSet);
			ProcessSchemaLane schemaBaseLookupLane = CreateBaseLookupLaneLane();
			schemaBaseLookupLaneSet.Lanes.Add(schemaBaseLookupLane);
			ProcessSchemaEventSubProcess baselookupeventsubprocess = CreateBaseLookupEventSubProcessEventSubProcess();
			FlowElements.Add(baselookupeventsubprocess);
			ProcessSchemaStartMessageEvent baselookupinsertingstartmessage = CreateBaseLookupInsertingStartMessageStartMessageEvent();
			baselookupeventsubprocess.FlowElements.Add(baselookupinsertingstartmessage);
			ProcessSchemaStartMessageEvent baselookupsavingstartmessage = CreateBaseLookupSavingStartMessageStartMessageEvent();
			baselookupeventsubprocess.FlowElements.Add(baselookupsavingstartmessage);
			ProcessSchemaStartMessageEvent baselookupdeletingstartmessage = CreateBaseLookupDeletingStartMessageStartMessageEvent();
			baselookupeventsubprocess.FlowElements.Add(baselookupdeletingstartmessage);
			ProcessSchemaScriptTask checkcanmanagelookupsscripttask = CreateCheckCanManageLookupsScriptTaskScriptTask();
			FlowElements.Add(checkcanmanagelookupsscripttask);
			FlowElements.Add(CreateBaseLookupSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateBaseLookupSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateBaseLookupSequenceFlow3SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateBaseLookupSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "BaseLookupSequenceFlow1",
				UId = new Guid("453da06c-6118-43bb-88cf-7a8f547090e7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("405a3e7e-e05d-42ab-853f-d735e8887459"),
				CreatedInSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CurveCenterPosition = new Point(205, 94),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9f186c66-1b04-4f3f-a712-2aadefc904c7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bdca0c6b-eb97-4d14-83df-aa53b214c463"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateBaseLookupSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "BaseLookupSequenceFlow2",
				UId = new Guid("17b638b4-f653-4bd5-9af3-e81689b5f42d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("405a3e7e-e05d-42ab-853f-d735e8887459"),
				CreatedInSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CurveCenterPosition = new Point(208, 117),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("48ed15e5-1285-49c5-8946-0344c7a15bbe"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bdca0c6b-eb97-4d14-83df-aa53b214c463"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateBaseLookupSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "BaseLookupSequenceFlow3",
				UId = new Guid("4dd835fd-20a9-40e3-9aa0-899ae48ad9d9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("405a3e7e-e05d-42ab-853f-d735e8887459"),
				CreatedInSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CurveCenterPosition = new Point(193, 146),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e0bb263d-5a8e-4ea3-a9e2-c824eb9ec5aa"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bdca0c6b-eb97-4d14-83df-aa53b214c463"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateBaseLookupLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaBaseLookupLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("9cd4075e-513a-484b-bfb4-ddcddddf7c6d"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("405a3e7e-e05d-42ab-853f-d735e8887459"),
				CreatedInSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				Name = @"BaseLookupLaneSet",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(675, 249),
				UseBackgroundMode = false
			};
			return schemaBaseLookupLaneSet;
		}

		protected virtual ProcessSchemaLane CreateBaseLookupLaneLane() {
			ProcessSchemaLane schemaBaseLookupLane = new ProcessSchemaLane(this) {
				UId = new Guid("c5e99e67-4d96-4930-951e-64963b3c98d8"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("9cd4075e-513a-484b-bfb4-ddcddddf7c6d"),
				CreatedInOwnerSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75"),
				CreatedInPackageId = new Guid("405a3e7e-e05d-42ab-853f-d735e8887459"),
				CreatedInSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				Name = @"BaseLookupLane",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(646, 249),
				UseBackgroundMode = false
			};
			return schemaBaseLookupLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateBaseLookupEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaBaseLookupEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e57d317f-6f21-48a8-9999-5ecf05719145"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c5e99e67-4d96-4930-951e-64963b3c98d8"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("405a3e7e-e05d-42ab-853f-d735e8887459"),
				CreatedInSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				Name = @"BaseLookupEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(35, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(106, 221),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaBaseLookupEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBaseLookupInsertingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("9f186c66-1b04-4f3f-a712-2aadefc904c7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e57d317f-6f21-48a8-9999-5ecf05719145"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("405a3e7e-e05d-42ab-853f-d735e8887459"),
				CreatedInSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"BaseLookupInserting",
				ModifiedInSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				Name = @"BaseLookupInsertingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(35, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBaseLookupSavingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("48ed15e5-1285-49c5-8946-0344c7a15bbe"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e57d317f-6f21-48a8-9999-5ecf05719145"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("405a3e7e-e05d-42ab-853f-d735e8887459"),
				CreatedInSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"BaseLookupSaving",
				ModifiedInSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				Name = @"BaseLookupSavingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 86),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBaseLookupDeletingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e0bb263d-5a8e-4ea3-a9e2-c824eb9ec5aa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e57d317f-6f21-48a8-9999-5ecf05719145"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("405a3e7e-e05d-42ab-853f-d735e8887459"),
				CreatedInSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"BaseLookupDeleting",
				ModifiedInSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				Name = @"BaseLookupDeletingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 149),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCheckCanManageLookupsScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("bdca0c6b-eb97-4d14-83df-aa53b214c463"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c5e99e67-4d96-4930-951e-64963b3c98d8"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("405a3e7e-e05d-42ab-853f-d735e8887459"),
				CreatedInSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				Name = @"CheckCanManageLookupsScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(218, 86),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,206,72,77,206,118,78,204,243,77,204,75,76,79,245,201,207,207,46,45,40,214,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,159,242,248,126,38,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateCheckCanManageLookupsMethod());
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

		protected virtual SchemaMethod CreateCheckCanManageLookupsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3b02fc11-56d6-4ccc-a172-6c8382c75d9c"),
				Name = "CheckCanManageLookups",
				CreatedInSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("405a3e7e-e05d-42ab-853f-d735e8887459"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,78,45,114,206,207,203,75,77,46,201,204,207,211,115,113,10,78,77,46,45,202,44,169,116,205,75,207,204,75,213,115,206,72,77,206,118,78,204,115,173,0,138,151,164,250,23,164,22,37,130,84,106,40,1,5,125,19,243,18,211,83,125,242,243,179,75,11,138,149,52,173,1,53,253,211,164,77,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseLookupEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e20c0489-122a-4242-999c-169e8e866fc1"));
		}

		#endregion

	}

	#endregion


	#region Class: BaseLookupEventsProcess

	/// <exclude/>
	public class BaseLookupEventsProcess : BaseLookup_BaseEventsProcess
	{

		public BaseLookupEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

