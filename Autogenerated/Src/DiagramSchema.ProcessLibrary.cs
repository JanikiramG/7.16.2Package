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

	#region Class: DiagramSchema

	/// <exclude/>
	[IsVirtual]
	public class DiagramSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public DiagramSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public DiagramSchema(DiagramSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public DiagramSchema(DiagramSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("92dc123e-a3cc-4430-8c79-127fee51cee8");
			RealUId = new Guid("92dc123e-a3cc-4430-8c79-127fee51cee8");
			Name = "Diagram";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4");
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
			EventsProcessSchema = CreateDiagramEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateDiagramEventsProcessSchema() {
			var schema = new DiagramEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Diagram(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Diagram_ProcessLibraryEventsProcess(userConnection);
		}

		public override object Clone() {
			return new DiagramSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new DiagramSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("92dc123e-a3cc-4430-8c79-127fee51cee8"));
		}

		#endregion

	}

	#endregion

	#region Class: Diagram

	/// <summary>
	/// Diagram.
	/// </summary>
	public class Diagram : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public Diagram(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Diagram";
		}

		public Diagram(Diagram source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Diagram_ProcessLibraryEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("DiagramDeleted", e);
			Loaded += (s, e) => ThrowEvent("DiagramLoaded", e);
			Saved += (s, e) => ThrowEvent("DiagramSaved", e);
			Validating += (s, e) => ThrowEvent("DiagramValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Diagram(this);
		}

		#endregion

	}

	#endregion

	#region Class: Diagram_ProcessLibraryEventsProcess

	/// <exclude/>
	public partial class Diagram_ProcessLibraryEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : Diagram
	{

		public Diagram_ProcessLibraryEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Diagram_ProcessLibraryEventsProcess";
			SchemaUId = new Guid("92dc123e-a3cc-4430-8c79-127fee51cee8");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("92dc123e-a3cc-4430-8c79-127fee51cee8");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual string NodesSchemaName {
			get;
			set;
		}

		public virtual string ConnectorsSchemaName {
			get;
			set;
		}

		public virtual string DiagramStorageColumnName {
			get;
			set;
		}

		private ProcessFlowElement _diagramSavedEventSubProcess;
		public ProcessFlowElement DiagramSavedEventSubProcess {
			get {
				return _diagramSavedEventSubProcess ?? (_diagramSavedEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "DiagramSavedEventSubProcess",
					SchemaElementUId = new Guid("45900010-bdc2-43ee-bf13-3217377ca174"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _diagramSavedStartMessage;
		public ProcessFlowElement DiagramSavedStartMessage {
			get {
				return _diagramSavedStartMessage ?? (_diagramSavedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DiagramSavedStartMessage",
					SchemaElementUId = new Guid("ebfc9eac-b746-4462-9481-3c0b19be0fd8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _diagramSavedScriptTask;
		public ProcessScriptTask DiagramSavedScriptTask {
			get {
				return _diagramSavedScriptTask ?? (_diagramSavedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DiagramSavedScriptTask",
					SchemaElementUId = new Guid("78587b56-e7a3-400b-8fb5-067a82ccfc4b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DiagramSavedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _diagramLoadedEventSubProcess;
		public ProcessFlowElement DiagramLoadedEventSubProcess {
			get {
				return _diagramLoadedEventSubProcess ?? (_diagramLoadedEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "DiagramLoadedEventSubProcess",
					SchemaElementUId = new Guid("8799ad18-7516-4d10-8516-cd0df9953e92"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _diagramLoadedStartMessage;
		public ProcessFlowElement DiagramLoadedStartMessage {
			get {
				return _diagramLoadedStartMessage ?? (_diagramLoadedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DiagramLoadedStartMessage",
					SchemaElementUId = new Guid("e22c4a9c-1785-4000-8790-2fb00faef7e1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _diagramLoadedScriptTask;
		public ProcessScriptTask DiagramLoadedScriptTask {
			get {
				return _diagramLoadedScriptTask ?? (_diagramLoadedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DiagramLoadedScriptTask",
					SchemaElementUId = new Guid("0e546333-d6f8-43b8-8184-543abf5a192c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DiagramLoadedScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[DiagramSavedEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { DiagramSavedEventSubProcess };
			FlowElements[DiagramSavedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DiagramSavedStartMessage };
			FlowElements[DiagramSavedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DiagramSavedScriptTask };
			FlowElements[DiagramLoadedEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { DiagramLoadedEventSubProcess };
			FlowElements[DiagramLoadedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DiagramLoadedStartMessage };
			FlowElements[DiagramLoadedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DiagramLoadedScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "DiagramSavedEventSubProcess":
						break;
					case "DiagramSavedStartMessage":
						e.Context.QueueTasks.Enqueue("DiagramSavedScriptTask");
						break;
					case "DiagramSavedScriptTask":
						break;
					case "DiagramLoadedEventSubProcess":
						break;
					case "DiagramLoadedStartMessage":
						e.Context.QueueTasks.Enqueue("DiagramLoadedScriptTask");
						break;
					case "DiagramLoadedScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("DiagramSavedStartMessage");
			ActivatedEventElements.Add("DiagramLoadedStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "DiagramSavedEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "DiagramSavedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "DiagramSavedStartMessage";
					result = DiagramSavedStartMessage.Execute(context);
					break;
				case "DiagramSavedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DiagramSavedScriptTask";
					result = DiagramSavedScriptTask.Execute(context, DiagramSavedScriptTaskExecute);
					break;
				case "DiagramLoadedEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "DiagramLoadedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "DiagramLoadedStartMessage";
					result = DiagramLoadedStartMessage.Execute(context);
					break;
				case "DiagramLoadedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DiagramLoadedScriptTask";
					result = DiagramLoadedScriptTask.Execute(context, DiagramLoadedScriptTaskExecute);
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
				case "DiagramStorageColumnName":
					DiagramStorageColumnName = reader.GetValue<System.String>();
				break;
				case "ConnectorsSchemaName":
					ConnectorsSchemaName = reader.GetValue<System.String>();
				break;
				case "NodesSchemaName":
					NodesSchemaName = reader.GetValue<System.String>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool DiagramSavedScriptTaskExecute(ProcessExecutingContext context) {
			return DiagramSavedMethod(context);
		}

		public virtual bool DiagramLoadedScriptTaskExecute(ProcessExecutingContext context) {
			return DiagramLoadedMethod(context);
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "DiagramSaved":
							if (ActivatedEventElements.Contains("DiagramSavedStartMessage")) {
							context.QueueTasks.Enqueue("DiagramSavedStartMessage");
						}
						break;
					case "DiagramLoaded":
							if (ActivatedEventElements.Contains("DiagramLoadedStartMessage")) {
							context.QueueTasks.Enqueue("DiagramLoadedStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("DiagramStorageColumnName") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("DiagramStorageColumnName", DiagramStorageColumnName, null);
			}
			if (!HasMapping("ConnectorsSchemaName") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ConnectorsSchemaName", ConnectorsSchemaName, null);
			}
			if (!HasMapping("NodesSchemaName") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("NodesSchemaName", NodesSchemaName, null);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: Diagram_ProcessLibraryEventsProcess

	/// <exclude/>
	public class Diagram_ProcessLibraryEventsProcess : Diagram_ProcessLibraryEventsProcess<Diagram>
	{

		public Diagram_ProcessLibraryEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Diagram_ProcessLibraryEventsProcess

	public partial class Diagram_ProcessLibraryEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual bool DiagramSavedMethod(ProcessExecutingContext  context) {
			SaveDiagram();
			return true;
		}

		public virtual void SaveDiagram() {
			if (!Entity.Schema.Columns.Any(column => column.Name == DiagramStorageColumnName)) {
				return;
			}
			string json = Entity.GetTypedColumnValue<string>(DiagramStorageColumnName);
			Guid recordId = Entity.PrimaryColumnValue;
			JObject diagram = JObject.Parse(json);
			JToken nodes = diagram["nodes"];
			JToken connectors = diagram["connectors"];
			SaveNodes(recordId, nodes);
			SaveConnectors(recordId, connectors);
		}

		public virtual void SaveNodes(Guid parentId, JToken nodes) {
			DiagramElementMap nodesMap = GetNodesMap();
			List<Guid> records = SaveItems(parentId, nodes, nodesMap);
			if (records.Count > 0) {
				new Delete(UserConnection)
					.From(nodesMap.SchemaName)
					.Where("Id").Not().In(Column.Parameters(records))
					.And(nodesMap.ReferenceColumnValueName + "Id").IsEqual(Column.Parameter(parentId))
					.Execute();
			} else {
				new Delete(UserConnection)
					.From(nodesMap.SchemaName)
					.Where(nodesMap.ReferenceColumnValueName + "Id").IsEqual(Column.Parameter(parentId))
					.Execute();
			}
		}

		public virtual void SaveConnectors(Guid parentId, JToken connectors) {
			DiagramElementMap connectorsMap = GetConnectorsMap();
			DiagramElementMap nodesMap = GetNodesMap();
			List<Guid> records = SaveItems(parentId, connectors, connectorsMap);
			if (records.Count > 0) {
				new Delete(UserConnection)
					.From(connectorsMap.SchemaName)
					.Where("Id").Not().In(Column.Parameters(records))
					.And("Id").In(
						new Select(UserConnection).Column("Id").From(connectorsMap.SchemaName)
						.Where("SourceStepId").In(
							new Select(UserConnection).Column("Id").From(nodesMap.SchemaName)
							.Where(nodesMap.ReferenceColumnValueName + "Id").IsEqual(Column.Parameter(parentId))
						).UnionAll(
							new Select(UserConnection).Column("Id").From(connectorsMap.SchemaName)
							.Where("TargetStepId").In(
								new Select(UserConnection).Column("Id").From(nodesMap.SchemaName)
								.Where(nodesMap.ReferenceColumnValueName + "Id").IsEqual(Column.Parameter(parentId))
							)
						)
					).Execute();
			} else {
				new Delete(UserConnection)
					.From(connectorsMap.SchemaName)
					.Where("Id").In(
						new Select(UserConnection).Column("Id").From(connectorsMap.SchemaName)
						.Where("SourceStepId").In(
							new Select(UserConnection).Column("Id").From(nodesMap.SchemaName)
							.Where(nodesMap.ReferenceColumnValueName + "Id").IsEqual(Column.Parameter(parentId))
						).UnionAll(
							new Select(UserConnection).Column("Id").From(connectorsMap.SchemaName)
							.Where("TargetStepId").In(
								new Select(UserConnection).Column("Id").From(nodesMap.SchemaName)
								.Where(nodesMap.ReferenceColumnValueName + "Id").IsEqual(Column.Parameter(parentId))
							)
						)
					).Execute();
			}
		}

		public virtual DiagramElementMap GetConnectorsMap() {
			return new DiagramElementMap(ConnectorsSchemaName, new DiagramElementMapPointer[] {});
		}

		public virtual DiagramElementMap GetNodesMap() {
			return new DiagramElementMap(NodesSchemaName, new DiagramElementMapPointer[] {});
		}

		public virtual List<Guid> SaveItems(Guid parentId, JToken nodes, DiagramElementMap map) {
			EntitySchema schema = UserConnection.EntitySchemaManager.GetInstanceByName(map.SchemaName);
			List<Guid> records = new List<Guid>();
			foreach (JToken node in nodes) {
				string nodeName = node.Value<string>("name");
				Guid nodeId = Guid.Empty;
				if (!Guid.TryParse(nodeName, out nodeId)) {
					continue;
				}
				records.Add(nodeId);
				Entity entity = schema.CreateEntity(UserConnection);
				if (!entity.FetchFromDB(nodeId)) {
					entity.SetColumnValue("Id", nodeId);
					if (!string.IsNullOrEmpty(map.ReferenceColumnValueName)) {
						entity.SetColumnValue(map.ReferenceColumnValueName + "Id", parentId);
					}
					entity.SetDefColumnValues();
				}
				map.Apply(entity, node);
				entity.SetColumnValue("JSON", node.ToString());
				entity.Save();
			}
			return records;
		}

		public virtual EntityCollection LoadNodes(Guid recordId, DiagramElementMap map) {
			EntitySchema schema = UserConnection.EntitySchemaManager.GetInstanceByName(map.SchemaName);
			var esq = new EntitySchemaQuery(schema);
			esq.AddAllSchemaColumns();
			IEntitySchemaQueryFilterItem filter = 
				esq.CreateFilterWithParameters(FilterComparisonType.Equal, map.ReferenceColumnValueName, recordId);
			esq.Filters.Add(filter);
			return esq.GetEntityCollection(UserConnection);
		}

		public virtual EntityCollection LoadConnectors(Guid recordId, DiagramElementMap nodesMap, DiagramElementMap connectorsMap) {
			EntitySchema schema = UserConnection.EntitySchemaManager.GetInstanceByName(connectorsMap.SchemaName);
			var esq = new EntitySchemaQuery(schema);
			esq.AddAllSchemaColumns();
			var filters = new EntitySchemaQueryFilterCollection(esq, LogicalOperationStrict.Or);
			filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, 
				"[" + nodesMap.SchemaName + ":Id:SourceStep]." + nodesMap.ReferenceColumnValueName, recordId));
			filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, 
				"[" + nodesMap.SchemaName + ":Id:TargetStep]." + nodesMap.ReferenceColumnValueName, recordId));
			esq.Filters.Add(filters);
			return esq.GetEntityCollection(UserConnection);
		}

		public virtual JArray BuildConfig(EntityCollection entityCollection, DiagramElementMap map) {
			JArray jArray = new JArray();
			foreach (Entity entity in entityCollection) {
				string json = entity.GetTypedColumnValue<string>("JSON");
				JObject jObject = new JObject();
				if (!string.IsNullOrEmpty(json)) {
					jObject = JObject.Parse(json);
				}
				map.Apply(jObject, entity);
				jArray.Add(jObject);
			}
			return jArray;
		}

		public virtual void LoadDiagram() {
			if (!Entity.Schema.Columns.Any(column => column.Name == DiagramStorageColumnName)) {
				return;
			}
			Guid recordId = Entity.PrimaryColumnValue;
			DiagramElementMap nodesMap = GetNodesMap();
			DiagramElementMap connectorsMap = GetConnectorsMap();
			EntityCollection nodes = LoadNodes(recordId, nodesMap);
			EntityCollection connectors = LoadConnectors(recordId, nodesMap, connectorsMap);
			JToken nodesConfig = BuildConfig(nodes, nodesMap);
			JToken connectorsConfig = BuildConfig(connectors, connectorsMap);
			JObject config = new JObject();
			config.Add("nodes", nodesConfig);
			config.Add("connectors", connectorsConfig);
			string json = config.ToString();
			Entity.SetColumnValue(DiagramStorageColumnName, json);
			Entity.StoringState = StoringObjectState.NotChanged;
		}

		public virtual bool DiagramLoadedMethod(ProcessExecutingContext  context) {
			LoadDiagram();
			return true;
		}

		#endregion

	}

	#endregion

	#region Class: DiagramEventsProcessSchema

	/// <exclude/>
	public class DiagramEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public DiagramEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public DiagramEventsProcessSchema(DiagramEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Diagram_ProcessLibraryEventsProcess";
			UId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732");
			CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4");
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

		protected virtual ProcessSchemaParameter CreateNodesSchemaNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9e2e99a4-eca6-41a5-b676-3b61a8c5b4db"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				Name = @"NodesSchemaName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateConnectorsSchemaNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("40295c4e-ccf7-4222-8f02-4606971c67e0"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				Name = @"ConnectorsSchemaName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDiagramStorageColumnNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("947ff92c-6073-41a6-8a90-184df5ba0a8b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				Name = @"DiagramStorageColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateNodesSchemaNameParameter());
			Parameters.Add(CreateConnectorsSchemaNameParameter());
			Parameters.Add(CreateDiagramStorageColumnNameParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaMainLaneSet = CreateMainLaneSetLaneSet();
			LaneSets.Add(schemaMainLaneSet);
			ProcessSchemaLane schemaMainLane = CreateMainLaneLane();
			schemaMainLaneSet.Lanes.Add(schemaMainLane);
			ProcessSchemaEventSubProcess diagramsavedeventsubprocess = CreateDiagramSavedEventSubProcessEventSubProcess();
			FlowElements.Add(diagramsavedeventsubprocess);
			ProcessSchemaEventSubProcess diagramloadedeventsubprocess = CreateDiagramLoadedEventSubProcessEventSubProcess();
			FlowElements.Add(diagramloadedeventsubprocess);
			ProcessSchemaStartMessageEvent diagramsavedstartmessage = CreateDiagramSavedStartMessageStartMessageEvent();
			diagramsavedeventsubprocess.FlowElements.Add(diagramsavedstartmessage);
			ProcessSchemaScriptTask diagramsavedscripttask = CreateDiagramSavedScriptTaskScriptTask();
			diagramsavedeventsubprocess.FlowElements.Add(diagramsavedscripttask);
			ProcessSchemaStartMessageEvent diagramloadedstartmessage = CreateDiagramLoadedStartMessageStartMessageEvent();
			diagramloadedeventsubprocess.FlowElements.Add(diagramloadedstartmessage);
			ProcessSchemaScriptTask diagramloadedscripttask = CreateDiagramLoadedScriptTaskScriptTask();
			diagramloadedeventsubprocess.FlowElements.Add(diagramloadedscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("513cd4f7-7f5a-49b4-beba-717e87a26325"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4"),
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				CurveCenterPosition = new Point(190, 88),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ebfc9eac-b746-4462-9481-3c0b19be0fd8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("78587b56-e7a3-400b-8fb5-067a82ccfc4b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("1cb4bfcf-0076-4618-ae92-1917ee8b4c51"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4"),
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				CurveCenterPosition = new Point(412, 80),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e22c4a9c-1785-4000-8790-2fb00faef7e1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0e546333-d6f8-43b8-8184-543abf5a192c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateMainLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaMainLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("fe45a97e-b5d3-4ff5-83a0-e23a7c0ed5cf"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4"),
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				Name = @"MainLaneSet",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1226, 184),
				UseBackgroundMode = false
			};
			return schemaMainLaneSet;
		}

		protected virtual ProcessSchemaLane CreateMainLaneLane() {
			ProcessSchemaLane schemaMainLane = new ProcessSchemaLane(this) {
				UId = new Guid("c5e39fdd-5011-4c4e-b46b-bba91b76e5cc"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("fe45a97e-b5d3-4ff5-83a0-e23a7c0ed5cf"),
				CreatedInOwnerSchemaUId = new Guid("92dc123e-a3cc-4430-8c79-127fee51cee8"),
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4"),
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				Name = @"MainLane",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1197, 184),
				UseBackgroundMode = false
			};
			return schemaMainLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateDiagramSavedEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaDiagramSavedEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("45900010-bdc2-43ee-bf13-3217377ca174"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c5e39fdd-5011-4c4e-b46b-bba91b76e5cc"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4"),
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				Name = @"DiagramSavedEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(56, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(217, 119),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaDiagramSavedEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDiagramSavedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ebfc9eac-b746-4462-9481-3c0b19be0fd8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("45900010-bdc2-43ee-bf13-3217377ca174"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4"),
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DiagramSaved",
				ModifiedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				Name = @"DiagramSavedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(22, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDiagramSavedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("78587b56-e7a3-400b-8fb5-067a82ccfc4b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("45900010-bdc2-43ee-bf13-3217377ca174"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4"),
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				Name = @"DiagramSavedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(113, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,112,201,76,76,47,74,204,13,78,44,75,77,241,77,45,201,200,79,209,72,206,207,43,73,173,40,209,180,6,0,116,7,8,253,35,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateDiagramLoadedEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaDiagramLoadedEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("8799ad18-7516-4d10-8516-cd0df9953e92"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c5e39fdd-5011-4c4e-b46b-bba91b76e5cc"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4"),
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				Name = @"DiagramLoadedEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(294, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(207, 130),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaDiagramLoadedEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDiagramLoadedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e22c4a9c-1785-4000-8790-2fb00faef7e1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8799ad18-7516-4d10-8516-cd0df9953e92"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4"),
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DiagramLoaded",
				ModifiedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				Name = @"DiagramLoadedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(15, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDiagramLoadedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0e546333-d6f8-43b8-8184-543abf5a192c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8799ad18-7516-4d10-8516-cd0df9953e92"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4"),
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				Name = @"DiagramLoadedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(106, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,112,201,76,76,47,74,204,245,201,79,76,73,77,241,77,45,201,200,79,209,72,206,207,43,73,173,40,209,180,6,0,96,112,142,104,36,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateDiagramSavedMethodMethod());
			Methods.Add(CreateSaveDiagramMethod());
			Methods.Add(CreateSaveNodesMethod());
			Methods.Add(CreateSaveConnectorsMethod());
			Methods.Add(CreateGetConnectorsMapMethod());
			Methods.Add(CreateGetNodesMapMethod());
			Methods.Add(CreateSaveItemsMethod());
			Methods.Add(CreateLoadNodesMethod());
			Methods.Add(CreateLoadConnectorsMethod());
			Methods.Add(CreateBuildConfigMethod());
			Methods.Add(CreateLoadDiagramMethod());
			Methods.Add(CreateDiagramLoadedMethodMethod());
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
				UId = new Guid("27462e27-06fb-4f93-af2e-0fbabb35073a"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("63ac7a2a-6577-4a9a-957e-8dd6e14aaac9"),
				Name = "Newtonsoft.Json.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4")
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

		protected virtual SchemaMethod CreateDiagramSavedMethodMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("461b2f67-678a-431c-bc80-46d916077ed3"),
				Name = "DiagramSavedMethod",
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("dc5dc482-d5ef-41f6-ad54-041751c16ee9"),
				Name = "context",
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				ModifiedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext ",
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,44,75,117,201,76,76,47,74,204,213,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,136,176,43,163,27,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSaveDiagramMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("de7e09c3-19bb-4783-a1c1-3fafb3ace0e0"),
				Name = "SaveDiagram",
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,142,193,78,2,49,16,134,207,246,41,6,78,221,132,244,5,150,37,49,104,136,28,128,100,137,23,227,161,182,227,82,164,45,153,118,77,54,198,119,183,75,87,22,15,222,38,255,124,255,55,99,222,129,79,30,93,52,177,19,181,58,160,149,98,233,79,173,117,65,220,187,142,171,203,12,213,2,242,36,54,210,34,84,21,60,24,217,144,180,117,244,36,27,204,149,126,87,20,240,197,238,8,99,75,174,100,223,44,68,50,174,129,99,240,201,2,195,161,21,198,125,119,70,157,107,207,242,212,226,60,131,11,254,175,184,100,171,214,104,32,84,158,244,147,30,109,59,50,86,82,119,35,43,217,122,251,118,68,21,65,103,91,130,135,68,236,36,5,228,253,63,201,184,222,251,15,116,224,188,198,144,152,129,126,153,94,130,233,235,21,80,222,185,84,246,244,135,26,211,30,173,229,39,110,250,30,255,125,113,150,197,69,222,45,175,244,13,48,42,138,242,7,15,129,173,18,139,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSaveNodesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("87ffe0b1-b6bb-4fb0-a796-bd7786f8f3c4"),
				Name = "SaveNodes",
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8c11d19e-c86b-4944-acfb-d2e18e6506fb"),
				Name = "parentId",
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				ModifiedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("1e25815d-1e5a-4311-91e5-aebef99fdfc0"),
				Name = "nodes",
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				ModifiedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "JToken",
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,207,205,74,3,49,20,5,224,117,231,41,46,93,37,88,130,123,181,32,211,177,12,232,32,22,117,29,38,167,118,32,185,169,249,81,65,124,119,211,78,91,23,110,117,151,144,156,239,222,179,24,244,75,208,174,177,112,224,116,167,183,196,222,32,238,14,87,180,68,234,14,55,33,47,170,219,33,166,203,101,30,204,156,2,122,31,76,44,127,86,250,13,109,130,139,98,171,67,33,90,51,27,137,217,73,42,209,97,77,226,144,81,181,207,156,104,78,231,146,62,171,9,227,157,22,176,72,16,143,17,161,246,204,232,211,224,89,86,147,137,186,9,222,137,163,163,86,253,6,78,119,218,97,255,248,188,65,128,152,182,102,42,85,231,147,144,170,101,81,123,155,29,171,123,93,90,21,52,196,227,92,185,207,92,179,249,241,30,176,46,2,247,24,67,79,218,102,236,116,58,163,81,109,99,243,154,181,253,133,158,186,142,104,243,129,62,151,2,165,232,23,193,70,252,73,177,127,93,243,27,69,55,252,203,248,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSaveConnectorsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("65a1c0e8-6420-4fae-9f2c-1cda13da28d5"),
				Name = "SaveConnectors",
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("098cc586-afd0-43de-aaef-e35d432181c0"),
				Name = "parentId",
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				ModifiedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6db46110-3a1f-4d58-8853-10abd5bef651"),
				Name = "connectors",
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				ModifiedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "JToken",
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,82,93,75,195,48,20,125,238,96,255,33,236,41,193,17,124,87,7,163,155,163,160,67,172,211,231,144,222,109,133,124,212,124,168,32,254,119,211,53,171,155,5,69,217,222,246,82,184,233,185,231,156,156,156,73,201,86,134,201,169,0,9,202,221,178,10,113,173,20,112,167,141,173,167,43,52,3,151,238,30,97,114,209,239,77,58,107,74,23,240,181,49,143,211,6,124,83,90,119,57,243,101,49,66,6,184,54,133,13,160,156,189,64,230,64,90,92,49,19,56,178,98,184,35,61,220,183,81,179,148,75,132,227,58,77,181,87,14,141,208,57,65,239,253,94,162,224,21,77,64,128,3,188,176,96,162,221,82,43,18,126,38,244,218,104,137,247,248,104,206,215,32,217,156,73,104,32,79,107,48,128,7,89,49,32,116,174,29,38,52,83,56,213,194,75,69,239,88,184,105,224,54,118,171,79,154,165,177,42,226,74,0,215,39,27,35,121,48,194,221,119,35,180,33,139,248,223,29,181,150,114,237,13,135,220,65,181,167,244,55,169,237,227,116,84,182,50,45,224,30,150,97,86,28,26,146,71,38,60,212,112,116,134,226,85,237,244,217,51,209,9,167,125,198,38,156,132,208,133,10,110,198,66,252,199,240,207,217,180,225,60,48,179,2,215,13,231,80,233,28,47,158,36,166,84,127,9,157,190,1,247,161,189,117,207,63,16,8,11,71,232,245,169,164,167,146,30,172,164,159,220,235,110,75,56,6,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetConnectorsMapMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("cddfb0bc-248b-47c6-bde0-b1b7b0b39613"),
				Name = "GetConnectorsMap",
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4"),
				ResultValueTypeName = "DiagramElementMap"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,76,47,74,204,117,205,73,205,77,205,43,241,77,44,208,112,206,207,203,75,77,46,201,47,42,14,78,206,72,205,77,244,75,204,77,213,193,174,54,32,63,51,175,36,181,40,58,86,161,186,86,211,26,0,84,161,83,174,86,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetNodesMapMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("21bfb34d-290b-4a1c-8326-e6bbf583ac82"),
				Name = "GetNodesMap",
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4"),
				ResultValueTypeName = "DiagramElementMap"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,76,47,74,204,117,205,73,205,77,205,43,241,77,44,208,240,203,79,73,45,14,78,206,72,205,77,244,75,204,77,213,193,174,44,32,63,51,175,36,181,40,58,86,161,186,86,211,26,0,76,197,2,4,81,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSaveItemsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("536581ca-b534-45d3-b86b-bb34129b045f"),
				Name = "SaveItems",
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4"),
				ResultValueTypeName = "List<Guid>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("fb6672b0-224f-4209-adf6-fb7359748af6"),
				Name = "parentId",
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				ModifiedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ede16990-0933-4a96-8ca8-9fa0990d4179"),
				Name = "nodes",
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				ModifiedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "JToken",
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("892e1db5-8eba-4613-9e1b-3d15fb9e37af"),
				Name = "map",
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				ModifiedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DiagramElementMap",
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,82,201,110,131,48,16,61,195,87,184,156,140,26,249,7,178,72,217,69,212,38,85,73,123,183,96,72,80,97,140,108,211,10,85,249,247,122,33,10,57,164,39,99,191,101,230,205,176,70,93,234,46,205,206,80,115,162,252,49,37,31,10,228,82,32,66,166,75,129,108,61,32,189,114,228,39,144,108,11,58,65,165,57,102,176,232,246,188,6,90,243,134,121,142,189,198,227,240,165,84,122,178,109,203,124,70,36,100,66,230,202,88,35,252,144,27,64,13,173,16,18,120,118,38,116,119,20,95,128,4,69,14,164,244,167,138,201,111,24,40,45,75,60,185,7,107,109,93,204,39,251,228,85,11,19,15,206,104,132,6,138,140,95,96,157,29,35,201,13,213,222,216,186,110,116,103,160,178,32,244,201,189,28,101,247,198,165,2,122,117,29,17,209,234,94,22,187,178,65,38,76,112,108,193,8,47,97,208,103,96,243,60,167,61,205,0,126,54,4,252,49,237,103,200,150,38,147,6,15,210,251,113,198,215,62,188,134,109,64,103,231,141,20,245,106,65,239,202,247,120,10,122,41,170,182,70,151,151,70,73,30,141,200,173,1,239,229,167,192,18,181,111,171,234,32,93,94,183,145,119,40,64,130,217,210,192,195,237,199,215,120,80,228,63,37,121,38,190,135,134,27,88,247,93,92,238,26,94,65,49,80,41,187,102,203,176,182,243,166,169,58,234,169,62,135,5,31,100,221,165,135,125,159,150,29,69,234,66,210,120,40,224,223,96,221,47,161,4,221,74,188,254,105,227,63,161,249,213,8,217,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateLoadNodesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1d04dc5f-8046-48ff-aeda-3d6949839702"),
				Name = "LoadNodes",
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4"),
				ResultValueTypeName = "EntityCollection"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b07ce1d1-dab5-4562-a56c-a1fcf5ab15a4"),
				Name = "recordId",
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				ModifiedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("84fcf3c1-75de-43f3-89c6-a1fbf27d73d9"),
				Name = "map",
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				ModifiedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DiagramElementMap",
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,80,203,110,195,32,16,60,55,95,193,145,72,145,127,32,202,33,181,220,202,135,86,233,251,188,178,39,9,18,44,206,130,91,249,239,11,221,30,82,245,4,203,12,243,216,142,179,203,203,203,112,70,32,147,244,216,153,183,4,105,35,51,134,236,34,55,221,21,233,129,152,78,144,230,30,185,231,148,137,7,220,46,143,20,96,3,77,141,114,234,184,222,174,62,73,12,210,165,232,49,190,204,181,200,211,12,89,172,218,21,98,33,53,251,113,220,123,175,112,27,253,28,56,217,2,245,255,190,221,57,159,33,125,70,48,199,159,107,209,95,221,84,137,86,64,25,138,127,184,124,62,144,148,32,101,72,86,31,219,24,38,18,151,34,191,46,19,154,238,50,147,223,152,154,251,25,71,8,74,23,181,126,39,63,163,182,216,24,193,16,101,236,199,223,152,42,148,106,92,171,246,5,16,228,89,184,118,173,107,209,196,69,200,235,250,236,223,109,174,183,223,160,35,67,21,116,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateLoadConnectorsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("074e4a03-9a29-4b6e-baf9-ae01b7ce54c3"),
				Name = "LoadConnectors",
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4"),
				ResultValueTypeName = "EntityCollection"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("fe455cca-d15c-43aa-8378-5c6c7edba903"),
				Name = "recordId",
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				ModifiedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6182df3a-decd-4a97-9c3e-6757d4c3c487"),
				Name = "nodesMap",
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				ModifiedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DiagramElementMap",
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("32c26d80-635f-4d3f-961d-d01891bdffaf"),
				Name = "connectorsMap",
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				ModifiedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DiagramElementMap",
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,146,193,78,195,48,12,134,207,236,41,162,157,58,81,229,1,54,113,24,83,135,42,49,6,116,192,1,113,176,82,111,139,148,38,157,227,130,250,246,36,164,72,29,18,23,14,156,34,217,191,63,255,142,93,88,214,220,87,234,136,13,8,159,158,43,241,228,145,86,206,90,84,172,157,149,197,72,180,1,11,7,36,121,131,92,90,207,96,21,94,247,119,208,96,166,82,129,35,191,129,86,38,117,76,204,22,147,119,32,129,254,20,200,22,63,196,24,247,208,33,245,89,106,28,132,65,36,151,117,189,52,38,165,87,206,116,141,245,217,192,216,107,195,72,254,55,206,250,43,29,106,76,50,158,5,92,46,110,221,65,43,48,219,22,9,98,180,98,210,138,229,150,2,116,0,198,158,81,44,87,132,192,152,56,47,154,143,247,64,97,130,40,201,190,225,77,11,164,189,179,187,190,69,89,156,58,48,185,152,92,76,95,167,226,82,88,87,227,143,233,67,116,58,47,235,121,229,58,82,88,49,182,111,242,76,250,136,123,36,12,223,152,102,125,6,211,97,44,204,5,161,114,84,151,245,236,95,141,238,128,14,200,127,54,26,205,173,71,102,7,227,33,67,200,29,217,120,7,241,120,210,242,70,187,58,191,185,217,226,19,92,230,246,199,154,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateBuildConfigMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ca291198-d550-4150-9418-cd3ae2e0e8a2"),
				Name = "BuildConfig",
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4"),
				ResultValueTypeName = "JArray"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("82b9ded1-48e9-4786-bb6e-68834a5759f5"),
				Name = "entityCollection",
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				ModifiedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntityCollection",
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ddf85726-3394-48b3-b489-cfd32f3586a4"),
				Name = "map",
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				ModifiedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DiagramElementMap",
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,69,80,203,10,194,48,16,60,167,95,177,246,148,130,228,7,170,66,17,17,123,176,130,226,61,218,85,83,210,52,164,41,82,196,127,55,117,35,158,102,31,51,179,195,150,133,115,114,132,134,96,9,6,159,80,126,27,158,229,201,173,115,40,175,15,224,27,227,149,31,1,9,148,137,213,186,211,26,175,94,117,38,131,87,194,122,239,148,185,67,211,119,38,88,17,69,108,209,159,70,139,117,224,14,173,57,75,61,224,130,136,43,158,150,199,106,159,134,67,172,172,46,77,112,130,38,98,76,66,221,20,133,169,27,240,25,9,197,174,223,15,90,87,110,211,90,63,242,233,94,246,13,192,254,242,40,21,7,233,122,36,74,48,121,39,172,149,86,20,214,234,160,35,202,60,38,157,246,244,7,81,212,245,111,27,166,239,196,161,31,156,137,95,202,63,152,238,143,143,52,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateLoadDiagramMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("52d55313-3802-4f2b-904f-5c7e36a445a6"),
				Name = "LoadDiagram",
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,82,75,78,195,48,16,93,147,83,12,93,185,82,228,11,84,65,42,165,170,64,80,144,82,177,55,241,52,117,73,108,228,56,66,21,226,238,76,108,83,183,52,236,102,222,204,251,248,163,182,192,174,151,218,41,119,224,101,181,195,86,240,133,105,250,86,119,124,174,15,172,242,53,20,55,16,42,190,22,45,66,81,192,157,18,181,21,109,233,140,21,53,6,202,48,155,78,225,43,187,178,232,122,171,103,217,119,182,234,149,4,139,149,177,242,94,66,1,209,234,197,170,86,216,67,224,189,138,166,199,89,22,37,151,13,182,168,221,147,248,0,109,36,118,67,81,192,10,221,58,118,108,58,182,91,25,173,177,162,56,137,176,56,133,6,86,48,39,211,134,96,101,116,48,160,229,71,35,164,151,103,191,81,243,163,249,24,47,153,69,114,178,26,81,200,207,195,145,224,195,198,188,99,180,39,234,86,213,164,115,219,171,70,134,142,249,201,89,134,72,73,74,163,188,52,30,49,125,126,219,83,63,224,129,168,241,19,34,56,220,78,192,249,92,74,54,241,198,147,252,52,225,159,141,164,62,201,47,82,209,110,231,172,210,53,236,59,186,174,34,122,242,141,41,61,156,30,131,151,195,59,29,127,1,251,239,95,229,94,233,132,70,11,36,84,58,225,232,63,66,108,195,97,60,200,215,198,45,118,66,215,40,103,63,64,170,2,177,229,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateDiagramLoadedMethodMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c55ce4ee-1fe1-4e12-9f3e-182bc1cea9b4"),
				Name = "DiagramLoadedMethod",
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e03768d4-c0ab-4752-a311-2729b8f0b61a"),
				Name = "context",
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				ModifiedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext ",
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,201,79,76,113,201,76,76,47,74,204,213,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,61,197,157,144,27,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new DiagramEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"));
		}

		#endregion

	}

	#endregion


	#region Class: DiagramEventsProcess

	/// <exclude/>
	public class DiagramEventsProcess : Diagram_ProcessLibraryEventsProcess
	{

		public DiagramEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

