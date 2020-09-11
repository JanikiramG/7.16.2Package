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

	#region Class: BaseEntityWithPositionSchema

	/// <exclude/>
	public class BaseEntityWithPositionSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public BaseEntityWithPositionSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BaseEntityWithPositionSchema(BaseEntityWithPositionSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BaseEntityWithPositionSchema(BaseEntityWithPositionSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("73d33bed-4682-45cb-ad25-a29b5ab88c96");
			RealUId = new Guid("73d33bed-4682-45cb-ad25-a29b5ab88c96");
			Name = "BaseEntityWithPosition";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("bd12ea8e-2bc2-42bf-925a-3ab766cc0b9f")) == null) {
				Columns.Add(CreatePositionColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("73d33bed-4682-45cb-ad25-a29b5ab88c96");
			column.CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("73d33bed-4682-45cb-ad25-a29b5ab88c96");
			column.CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("73d33bed-4682-45cb-ad25-a29b5ab88c96");
			column.CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("73d33bed-4682-45cb-ad25-a29b5ab88c96");
			column.CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("73d33bed-4682-45cb-ad25-a29b5ab88c96");
			column.CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("73d33bed-4682-45cb-ad25-a29b5ab88c96");
			column.CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886");
			return column;
		}

		protected virtual EntitySchemaColumn CreatePositionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("bd12ea8e-2bc2-42bf-925a-3ab766cc0b9f"),
				Name = @"Position",
				CreatedInSchemaUId = new Guid("73d33bed-4682-45cb-ad25-a29b5ab88c96"),
				ModifiedInSchemaUId = new Guid("73d33bed-4682-45cb-ad25-a29b5ab88c96"),
				CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBaseEntityWithPositionEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateBaseEntityWithPositionEventsProcessSchema() {
			var schema = new BaseEntityWithPositionEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BaseEntityWithPosition(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BaseEntityWithPosition_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BaseEntityWithPositionSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BaseEntityWithPositionSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("73d33bed-4682-45cb-ad25-a29b5ab88c96"));
		}

		#endregion

	}

	#endregion

	#region Class: BaseEntityWithPosition

	/// <summary>
	/// Base object with position.
	/// </summary>
	public class BaseEntityWithPosition : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public BaseEntityWithPosition(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BaseEntityWithPosition";
		}

		public BaseEntityWithPosition(BaseEntityWithPosition source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Position.
		/// </summary>
		public int Position {
			get {
				return GetTypedColumnValue<int>("Position");
			}
			set {
				SetColumnValue("Position", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BaseEntityWithPosition_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("BaseEntityWithPositionDeleted", e);
			Inserting += (s, e) => ThrowEvent("BaseEntityWithPositionInserting", e);
			Validating += (s, e) => ThrowEvent("BaseEntityWithPositionValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseEntityWithPosition(this);
		}

		#endregion

	}

	#endregion

	#region Class: BaseEntityWithPosition_BaseEventsProcess

	/// <exclude/>
	public partial class BaseEntityWithPosition_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : BaseEntityWithPosition
	{

		public BaseEntityWithPosition_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseEntityWithPosition_BaseEventsProcess";
			SchemaUId = new Guid("73d33bed-4682-45cb-ad25-a29b5ab88c96");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("73d33bed-4682-45cb-ad25-a29b5ab88c96");
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
					SchemaElementUId = new Guid("a5c75974-954a-44a7-b7b1-b7037b7a51bb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseEntityWithPositionInsertingMessage;
		public ProcessFlowElement BaseEntityWithPositionInsertingMessage {
			get {
				return _baseEntityWithPositionInsertingMessage ?? (_baseEntityWithPositionInsertingMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseEntityWithPositionInsertingMessage",
					SchemaElementUId = new Guid("41cb22eb-a906-41e3-9eb0-669bde29d29a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseEntityWithPositionDeletedMessage;
		public ProcessFlowElement BaseEntityWithPositionDeletedMessage {
			get {
				return _baseEntityWithPositionDeletedMessage ?? (_baseEntityWithPositionDeletedMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseEntityWithPositionDeletedMessage",
					SchemaElementUId = new Guid("9996a79b-d08b-46a0-9f67-2762996b1184"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _baseEntityWithPositionInsertingScript;
		public ProcessScriptTask BaseEntityWithPositionInsertingScript {
			get {
				return _baseEntityWithPositionInsertingScript ?? (_baseEntityWithPositionInsertingScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BaseEntityWithPositionInsertingScript",
					SchemaElementUId = new Guid("12409027-1538-4f00-ae12-1b71898a4401"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = BaseEntityWithPositionInsertingScriptExecute,
				});
			}
		}

		private ProcessScriptTask _baseEntityWithPositionDeletedScript;
		public ProcessScriptTask BaseEntityWithPositionDeletedScript {
			get {
				return _baseEntityWithPositionDeletedScript ?? (_baseEntityWithPositionDeletedScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BaseEntityWithPositionDeletedScript",
					SchemaElementUId = new Guid("ca7b49f2-04eb-4e9b-af9e-4f1a62d61fa5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = BaseEntityWithPositionDeletedScriptExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[BaseEntityWithPositionInsertingMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseEntityWithPositionInsertingMessage };
			FlowElements[BaseEntityWithPositionDeletedMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseEntityWithPositionDeletedMessage };
			FlowElements[BaseEntityWithPositionInsertingScript.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseEntityWithPositionInsertingScript };
			FlowElements[BaseEntityWithPositionDeletedScript.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseEntityWithPositionDeletedScript };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "BaseEntityWithPositionInsertingMessage":
						e.Context.QueueTasks.Enqueue("BaseEntityWithPositionInsertingScript");
						break;
					case "BaseEntityWithPositionDeletedMessage":
						e.Context.QueueTasks.Enqueue("BaseEntityWithPositionDeletedScript");
						break;
					case "BaseEntityWithPositionInsertingScript":
						break;
					case "BaseEntityWithPositionDeletedScript":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("BaseEntityWithPositionInsertingMessage");
			ActivatedEventElements.Add("BaseEntityWithPositionDeletedMessage");
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
				case "BaseEntityWithPositionInsertingMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseEntityWithPositionInsertingMessage";
					result = BaseEntityWithPositionInsertingMessage.Execute(context);
					break;
				case "BaseEntityWithPositionDeletedMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseEntityWithPositionDeletedMessage";
					result = BaseEntityWithPositionDeletedMessage.Execute(context);
					break;
				case "BaseEntityWithPositionInsertingScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseEntityWithPositionInsertingScript";
					result = BaseEntityWithPositionInsertingScript.Execute(context, BaseEntityWithPositionInsertingScriptExecute);
					break;
				case "BaseEntityWithPositionDeletedScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseEntityWithPositionDeletedScript";
					result = BaseEntityWithPositionDeletedScript.Execute(context, BaseEntityWithPositionDeletedScriptExecute);
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

		public virtual bool BaseEntityWithPositionInsertingScriptExecute(ProcessExecutingContext context) {
			BaseEntityWithPositionInserting();
			return true;
		}

		public virtual bool BaseEntityWithPositionDeletedScriptExecute(ProcessExecutingContext context) {
			BaseEntityWithPositionDeleted();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "BaseEntityWithPositionInserting":
							if (ActivatedEventElements.Contains("BaseEntityWithPositionInsertingMessage")) {
							context.QueueTasks.Enqueue("BaseEntityWithPositionInsertingMessage");
						}
						break;
					case "BaseEntityWithPositionDeleted":
							if (ActivatedEventElements.Contains("BaseEntityWithPositionDeletedMessage")) {
							context.QueueTasks.Enqueue("BaseEntityWithPositionDeletedMessage");
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

	#region Class: BaseEntityWithPosition_BaseEventsProcess

	/// <exclude/>
	public class BaseEntityWithPosition_BaseEventsProcess : BaseEntityWithPosition_BaseEventsProcess<BaseEntityWithPosition>
	{

		public BaseEntityWithPosition_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BaseEntityWithPosition_BaseEventsProcess

	public partial class BaseEntityWithPosition_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void BaseEntityWithPositionInserting() {
			Entity.SetColumnValue("Position", GetMaxPosition(Entity));
		}

		public virtual void BaseEntityWithPositionDeleted() {
			Guid primaryColumnvalue = GetFirstEntityPrimaryColumnValue(Entity);
			if (!primaryColumnvalue.Equals(Guid.Empty)) {
				var setRecordPositionProcedure =
					(StoredProcedure)new StoredProcedure(UserConnection, "tsp_SetRecordPosition")
					.WithParameter("TableName", Entity.Schema.Name)
					.WithParameter("PrimaryColumnName", Entity.Schema.GetDBPrimaryColumnName())
					.WithParameter("PrimaryColumnValue", primaryColumnvalue)
					.WithParameter("GrouppingColumnNames", GetGrouppingColumnNames())
					.WithParameter("Position", 0);
				setRecordPositionProcedure.PackageName = UserConnection.DBEngine.SystemPackageName;
				setRecordPositionProcedure.Execute();
			}
		}

		public virtual EntitySchemaQueryFilterCollection GetDetailFilter(Entity entity, EntitySchemaQuery esq) {
			return null;
		}

		public virtual Guid GetFirstEntityPrimaryColumnValue(Entity entity) {
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, entity.Schema.Name);
			esq.RowCount = 1;
			esq.PrimaryQueryColumn.IsAlwaysSelect  = true;
			esq.AddColumn("Position").OrderByAsc();
			
			var groupFilter = GetDetailFilter(entity, esq);
			if (groupFilter != null) {
				esq.Filters.Add(groupFilter);
			}
			
			var entities = esq.GetEntityCollection(UserConnection);
			if (entities.Count > 0) {
				return entities[0].GetTypedColumnValue<Guid>(entity.Schema.GetDBPrimaryColumnName());
			}
			return Guid.Empty;
		}

		public virtual string GetGrouppingColumnNames() {
			// Format of string: "column1,column2"
			return string.Empty;
		}

		public virtual int GetMaxPosition(Entity entity) {
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, entity.Schema.Name);
			esq.RowCount = 1;
			var positionColumn = esq.AddColumn(esq.CreateAggregationFunction(AggregationTypeStrict.Max, "Position"));
			var countColumn = esq.AddColumn(esq.CreateAggregationFunction(AggregationTypeStrict.Count, entity.Schema.GetDBPrimaryColumnName()));
			var groupFilter = GetDetailFilter(entity, esq);
			if (groupFilter != null) {
				esq.Filters.Add(groupFilter);
			}
			
			var entities = esq.GetEntityCollection(UserConnection);
			int count = entities[0].GetTypedColumnValue<int>(countColumn.Name);
			if (count > 0) {
				return entities[0].GetTypedColumnValue<int>(positionColumn.Name) + 1;
			}
			return count;
		}

		#endregion

	}

	#endregion

	#region Class: BaseEntityWithPositionEventsProcessSchema

	/// <exclude/>
	public class BaseEntityWithPositionEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public BaseEntityWithPositionEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BaseEntityWithPositionEventsProcessSchema(BaseEntityWithPositionEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BaseEntityWithPosition_BaseEventsProcess";
			UId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c");
			CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886");
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
			ProcessSchemaStartMessageEvent baseentitywithpositioninsertingmessage = CreateBaseEntityWithPositionInsertingMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(baseentitywithpositioninsertingmessage);
			ProcessSchemaStartMessageEvent baseentitywithpositiondeletedmessage = CreateBaseEntityWithPositionDeletedMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(baseentitywithpositiondeletedmessage);
			ProcessSchemaScriptTask baseentitywithpositioninsertingscript = CreateBaseEntityWithPositionInsertingScriptScriptTask();
			eventsubprocess1.FlowElements.Add(baseentitywithpositioninsertingscript);
			ProcessSchemaScriptTask baseentitywithpositiondeletedscript = CreateBaseEntityWithPositionDeletedScriptScriptTask();
			eventsubprocess1.FlowElements.Add(baseentitywithpositiondeletedscript);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("48144901-9911-44ac-a60a-41b9a18652b4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886"),
				CreatedInSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				CurveCenterPosition = new Point(181, 94),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("41cb22eb-a906-41e3-9eb0-669bde29d29a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("12409027-1538-4f00-ae12-1b71898a4401"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("1e5a2af6-a077-482b-a080-71d638248070"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886"),
				CreatedInSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				CurveCenterPosition = new Point(508, 92),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9996a79b-d08b-46a0-9f67-2762996b1184"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ca7b49f2-04eb-4e9b-af9e-4f1a62d61fa5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("039f3e3a-0c6e-482b-b87b-3ca22d8092aa"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886"),
				CreatedInSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(735, 177),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("15f3d965-cfa6-4f19-be6d-991637405876"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("039f3e3a-0c6e-482b-b87b-3ca22d8092aa"),
				CreatedInOwnerSchemaUId = new Guid("73d33bed-4682-45cb-ad25-a29b5ab88c96"),
				CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886"),
				CreatedInSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(706, 177),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a5c75974-954a-44a7-b7b1-b7037b7a51bb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("15f3d965-cfa6-4f19-be6d-991637405876"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886"),
				CreatedInSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(623, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBaseEntityWithPositionInsertingMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("41cb22eb-a906-41e3-9eb0-669bde29d29a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a5c75974-954a-44a7-b7b1-b7037b7a51bb"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886"),
				CreatedInSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"BaseEntityWithPositionInserting",
				ModifiedInSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				Name = @"BaseEntityWithPositionInsertingMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBaseEntityWithPositionDeletedMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("9996a79b-d08b-46a0-9f67-2762996b1184"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a5c75974-954a-44a7-b7b1-b7037b7a51bb"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886"),
				CreatedInSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"BaseEntityWithPositionDeleted",
				ModifiedInSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				Name = @"BaseEntityWithPositionDeletedMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(365, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateBaseEntityWithPositionInsertingScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("12409027-1538-4f00-ae12-1b71898a4401"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a5c75974-954a-44a7-b7b1-b7037b7a51bb"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886"),
				CreatedInSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				Name = @"BaseEntityWithPositionInsertingScript",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(120, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,74,44,78,117,205,43,201,44,169,12,207,44,201,8,200,47,206,44,201,204,207,243,204,43,78,45,42,201,204,75,215,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,249,196,126,233,48,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateBaseEntityWithPositionDeletedScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ca7b49f2-04eb-4e9b-af9e-4f1a62d61fa5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a5c75974-954a-44a7-b7b1-b7037b7a51bb"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886"),
				CreatedInSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				Name = @"BaseEntityWithPositionDeletedScript",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(449, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,74,44,78,117,205,43,201,44,169,12,207,44,201,8,200,47,206,44,201,204,207,115,73,205,73,45,73,77,209,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,102,53,19,158,46,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateBaseEntityWithPositionInsertingMethod());
			Methods.Add(CreateBaseEntityWithPositionDeletedMethod());
			Methods.Add(CreateGetDetailFilterMethod());
			Methods.Add(CreateGetFirstEntityPrimaryColumnValueMethod());
			Methods.Add(CreateGetGrouppingColumnNamesMethod());
			Methods.Add(CreateGetMaxPositionMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886")
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

		protected virtual SchemaMethod CreateBaseEntityWithPositionInsertingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("41c9daaf-4143-46f4-b720-ec5606b07d55"),
				Name = "BaseEntityWithPositionInserting",
				CreatedInSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,205,43,201,44,169,212,11,78,45,113,206,207,41,205,205,11,75,204,41,77,213,80,10,200,47,206,44,201,204,207,83,210,81,112,79,45,241,77,172,128,9,104,184,130,53,104,106,90,3,0,54,168,26,124,58,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateBaseEntityWithPositionDeletedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ca961c71-edb1-492a-b1c7-489e32230f75"),
				Name = "BaseEntityWithPositionDeleted",
				CreatedInSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,146,205,78,195,48,16,132,207,169,212,119,48,57,57,82,100,113,71,92,218,134,220,80,68,248,57,34,147,44,169,69,108,135,245,186,16,33,222,29,167,21,208,54,169,122,244,238,204,172,253,173,115,175,106,214,161,210,18,251,165,109,189,54,27,217,122,96,215,44,7,186,81,232,40,51,164,168,47,246,37,143,131,132,239,26,201,213,124,166,94,25,191,24,135,136,236,221,203,214,241,60,204,16,153,238,130,56,97,95,243,89,180,145,200,28,208,29,84,22,235,194,58,69,202,154,2,109,5,181,199,48,59,72,34,94,146,69,168,255,170,137,129,15,118,84,227,15,14,112,105,141,129,106,72,72,89,76,174,123,46,143,147,227,100,8,20,79,138,214,133,68,169,129,0,121,124,47,95,90,184,13,167,56,101,187,167,136,178,90,131,150,98,40,78,90,14,32,76,90,3,180,213,98,36,227,201,249,184,45,211,144,55,198,56,233,205,209,250,174,83,166,249,159,226,130,59,204,159,234,156,186,192,47,160,148,93,14,123,140,78,47,69,20,178,122,147,205,22,88,248,28,135,224,197,106,145,153,70,25,16,101,239,8,244,158,246,76,106,246,9,149,167,0,40,232,190,127,0,35,37,151,121,140,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetDetailFilterMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8d29453a-da06-44b6-bc7b-96507cd21d74"),
				Name = "GetDetailFilter",
				CreatedInSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886"),
				ResultValueTypeName = "EntitySchemaQueryFilterCollection"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("072a17a9-478e-4bd1-aa01-8035645b2689"),
				Name = "entity",
				CreatedInSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				ModifiedInSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f98626ba-1e0e-42f7-bfd5-16876639a50b"),
				Name = "esq",
				CreatedInSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				ModifiedInSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntitySchemaQuery",
				CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,43,205,201,177,6,0,44,130,140,166,12,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetFirstEntityPrimaryColumnValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1c79fb6d-81a1-4d8b-9d75-0dde940ffdd4"),
				Name = "GetFirstEntityPrimaryColumnValue",
				CreatedInSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886"),
				ResultValueTypeName = "Guid"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ba83c598-33b6-43e6-ad4b-ceacb203b77e"),
				Name = "entity",
				CreatedInSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				ModifiedInSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,81,77,79,2,49,16,61,187,9,255,161,114,234,38,164,193,51,74,2,43,18,15,42,10,122,49,30,154,221,17,155,116,219,117,218,66,26,227,127,183,67,23,131,94,95,222,215,188,217,73,100,224,62,217,21,51,176,103,11,227,149,143,235,250,3,90,249,24,0,35,127,118,128,149,53,6,106,175,172,17,167,132,59,105,228,22,112,196,224,0,138,140,138,123,217,66,57,25,20,201,85,60,217,125,101,131,241,201,254,162,135,86,168,90,137,241,224,94,89,29,90,35,110,221,76,239,101,116,107,208,41,134,37,178,199,0,61,127,214,52,153,198,135,43,235,20,181,24,150,226,1,27,192,121,156,185,154,83,214,160,216,165,59,182,104,67,119,163,180,7,76,30,75,240,215,224,165,210,25,225,185,229,136,174,37,137,122,103,252,84,112,158,22,8,90,151,236,107,80,156,81,112,198,29,21,56,37,146,246,251,152,120,240,84,224,82,28,73,82,100,30,40,53,214,121,177,127,3,30,147,143,66,145,231,153,178,113,14,70,240,1,205,175,239,235,248,141,76,55,177,131,126,133,23,169,3,92,46,131,106,166,252,239,238,116,239,188,95,55,115,233,19,188,236,11,247,206,164,20,139,182,243,113,242,3,193,117,36,159,251,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetGrouppingColumnNamesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("12905d12-4a46-4c8b-bf5e-f1f702180c61"),
				Name = "GetGrouppingColumnNames",
				CreatedInSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,215,87,112,203,47,202,77,44,81,200,79,83,40,46,41,202,204,75,183,82,80,74,206,207,41,205,205,51,212,129,208,70,74,188,92,69,169,37,165,69,121,80,21,122,174,185,5,37,149,214,0,239,177,120,95,60,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetMaxPositionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7cdb3391-868d-419a-9789-9c92db48f239"),
				Name = "GetMaxPosition",
				CreatedInSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886"),
				ResultValueTypeName = "int"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("40e3bce9-edfa-4da7-92b1-8695c31f663e"),
				Name = "entity",
				CreatedInSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				ModifiedInSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,146,49,79,195,48,16,133,103,34,245,63,152,78,142,136,162,50,23,42,149,64,153,138,10,165,44,136,193,74,143,96,201,177,195,197,110,137,16,255,29,159,29,170,208,137,129,49,151,187,239,189,187,231,157,64,6,237,59,187,100,26,246,236,70,91,105,187,117,249,6,181,184,119,128,29,223,180,128,133,209,26,74,43,141,206,135,13,75,161,69,5,152,49,8,197,60,86,243,59,81,67,58,29,37,158,154,63,152,125,97,156,182,30,127,238,75,59,47,214,152,86,18,170,48,202,213,218,255,160,190,249,118,27,191,57,125,21,8,194,194,188,170,16,42,65,189,11,167,131,60,31,212,30,187,6,214,22,101,105,243,165,248,200,216,120,213,131,199,105,218,75,149,36,253,143,58,97,149,227,117,111,193,94,95,173,80,214,2,187,200,166,3,240,244,224,162,66,227,154,133,84,22,208,187,160,118,176,66,170,88,225,17,150,145,59,26,144,175,140,15,7,78,125,46,78,169,148,125,142,146,19,242,28,235,45,109,50,108,164,217,175,81,18,21,3,83,66,219,47,237,37,99,108,222,158,138,57,30,197,26,148,125,74,101,159,213,15,224,121,242,66,211,116,130,254,110,79,66,57,184,240,189,51,62,184,238,33,115,178,31,33,51,54,137,166,17,172,67,253,55,228,239,183,17,169,236,44,60,29,191,92,79,10,252,233,55,57,190,208,114,184,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseEntityWithPositionEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("940268fa-de6a-4788-9a44-adceccaf737c"));
		}

		#endregion

	}

	#endregion


	#region Class: BaseEntityWithPositionEventsProcess

	/// <exclude/>
	public class BaseEntityWithPositionEventsProcess : BaseEntityWithPosition_BaseEventsProcess
	{

		public BaseEntityWithPositionEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

