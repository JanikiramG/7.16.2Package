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

	#region Class: SysLookupFolderSchema

	/// <exclude/>
	public class SysLookupFolderSchema : Terrasoft.Configuration.BaseFolderSchema
	{

		#region Constructors: Public

		public SysLookupFolderSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysLookupFolderSchema(SysLookupFolderSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysLookupFolderSchema(SysLookupFolderSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5403f977-1005-41a3-99a1-5ff37806bbbf");
			RealUId = new Guid("5403f977-1005-41a3-99a1-5ff37806bbbf");
			Name = "SysLookupFolder";
			ParentSchemaUId = new Guid("d602bf96-d029-4b07-9755-63c8f5cb5ed5");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.IsLocalizable = false;
			column.ModifiedInSchemaUId = new Guid("5403f977-1005-41a3-99a1-5ff37806bbbf");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.IsLocalizable = false;
			column.ModifiedInSchemaUId = new Guid("5403f977-1005-41a3-99a1-5ff37806bbbf");
			return column;
		}

		protected override EntitySchemaColumn CreateParentColumn() {
			EntitySchemaColumn column = base.CreateParentColumn();
			column.ReferenceSchemaUId = new Guid("5403f977-1005-41a3-99a1-5ff37806bbbf");
			column.ColumnValueName = @"ParentId";
			column.DisplayColumnValueName = @"ParentName";
			column.ModifiedInSchemaUId = new Guid("5403f977-1005-41a3-99a1-5ff37806bbbf");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysLookupFolderEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysLookupFolderEventsProcessSchema() {
			var schema = new SysLookupFolderEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysLookupFolder(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysLookupFolder_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysLookupFolderSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysLookupFolderSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5403f977-1005-41a3-99a1-5ff37806bbbf"));
		}

		#endregion

	}

	#endregion

	#region Class: SysLookupFolder

	/// <summary>
	/// Lookup folder.
	/// </summary>
	public class SysLookupFolder : Terrasoft.Configuration.BaseFolder
	{

		#region Constructors: Public

		public SysLookupFolder(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysLookupFolder";
		}

		public SysLookupFolder(SysLookupFolder source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ParentId {
			get {
				return GetTypedColumnValue<Guid>("ParentId");
			}
			set {
				SetColumnValue("ParentId", value);
				_parent = null;
			}
		}

		/// <exclude/>
		public string ParentName {
			get {
				return GetTypedColumnValue<string>("ParentName");
			}
			set {
				SetColumnValue("ParentName", value);
				if (_parent != null) {
					_parent.Name = value;
				}
			}
		}

		private SysLookupFolder _parent;
		/// <summary>
		/// Parent.
		/// </summary>
		public SysLookupFolder Parent {
			get {
				return _parent ??
					(_parent = LookupColumnEntities.GetEntity("Parent") as SysLookupFolder);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysLookupFolder_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysLookupFolderDeleted", e);
			Deleting += (s, e) => ThrowEvent("SysLookupFolderDeleting", e);
			Inserted += (s, e) => ThrowEvent("SysLookupFolderInserted", e);
			Inserting += (s, e) => ThrowEvent("SysLookupFolderInserting", e);
			Saved += (s, e) => ThrowEvent("SysLookupFolderSaved", e);
			Saving += (s, e) => ThrowEvent("SysLookupFolderSaving", e);
			Validating += (s, e) => ThrowEvent("SysLookupFolderValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysLookupFolder(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysLookupFolder_BaseEventsProcess

	/// <exclude/>
	public partial class SysLookupFolder_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseFolder_BaseEventsProcess<TEntity> where TEntity : SysLookupFolder
	{

		public SysLookupFolder_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysLookupFolder_BaseEventsProcess";
			SchemaUId = new Guid("5403f977-1005-41a3-99a1-5ff37806bbbf");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5403f977-1005-41a3-99a1-5ff37806bbbf");
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
					SchemaElementUId = new Guid("241555e6-79e5-4bdb-8247-ef39e2b4f856"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _sysLookupFolderInserted;
		public ProcessFlowElement SysLookupFolderInserted {
			get {
				return _sysLookupFolderInserted ?? (_sysLookupFolderInserted = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SysLookupFolderInserted",
					SchemaElementUId = new Guid("5ddc7db3-6983-45f4-9cf7-2a33779222c8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask1;
		public ProcessScriptTask ScriptTask1 {
			get {
				return _scriptTask1 ?? (_scriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask1",
					SchemaElementUId = new Guid("1f46d8c6-963a-4921-8dc6-c111a0717ab6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
				});
			}
		}

		private ProcessThrowMessageEvent _baseSysLookupFolderInserted;
		public ProcessThrowMessageEvent BaseSysLookupFolderInserted {
			get {
				return _baseSysLookupFolderInserted ?? (_baseSysLookupFolderInserted = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "BaseSysLookupFolderInserted",
					SchemaElementUId = new Guid("91872619-0514-4b0f-9ba5-20278b866b6b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "SysLookupFolderInserted",
						ThrowToBase = true,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[SysLookupFolderInserted.SchemaElementUId] = new Collection<ProcessFlowElement> { SysLookupFolderInserted };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[BaseSysLookupFolderInserted.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseSysLookupFolderInserted };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "SysLookupFolderInserted":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "ScriptTask1":
						e.Context.QueueTasks.Enqueue("BaseSysLookupFolderInserted");
						break;
					case "BaseSysLookupFolderInserted":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("SysLookupFolderInserted");
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
				case "SysLookupFolderInserted":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysLookupFolderInserted";
					result = SysLookupFolderInserted.Execute(context);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
					break;
				case "BaseSysLookupFolderInserted":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "SysLookupFolderInserted");
					result = BaseSysLookupFolderInserted.Execute(context);
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

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			Guid adminGroupId = new Guid("A29A3BA5-4B0D-DE11-9A51-005056C00008");
			var dbSecurityEngine = UserConnection.DBSecurityEngine;
			var rightLevel = dbSecurityEngine.GetEntitySchemaRecordRightLevel(Entity.Schema.Name, Entity.Id);
			if (rightLevel.HasFlag(SchemaRecordRightLevels.CanRead) &&
				rightLevel.HasFlag(SchemaRecordRightLevels.CanChangeReadRight)) {
				dbSecurityEngine.SetEntitySchemaRecordOperationRightLevel(adminGroupId, Entity.Schema.Name,
					Entity.Id, EntitySchemaRecordRightOperation.Read, EntitySchemaRecordRightLevel.Allow);
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "SysLookupFolderInserted":
							if (ActivatedEventElements.Contains("SysLookupFolderInserted")) {
							context.QueueTasks.Enqueue("SysLookupFolderInserted");
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

	#region Class: SysLookupFolder_BaseEventsProcess

	/// <exclude/>
	public class SysLookupFolder_BaseEventsProcess : SysLookupFolder_BaseEventsProcess<SysLookupFolder>
	{

		public SysLookupFolder_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysLookupFolder_BaseEventsProcess

	public partial class SysLookupFolder_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void CheckCanManageLookups() {
			return;
		}

		#endregion

	}

	#endregion

	#region Class: SysLookupFolderEventsProcessSchema

	/// <exclude/>
	public class SysLookupFolderEventsProcessSchema : Terrasoft.Configuration.BaseFolderEventsProcessSchema
	{

		#region Constructors: Public

		public SysLookupFolderEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysLookupFolderEventsProcessSchema(SysLookupFolderEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysLookupFolder_BaseEventsProcess";
			UId = new Guid("2d3e82e0-74a8-4703-888b-2b21b0057804");
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
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaStartMessageEvent syslookupfolderinserted = CreateSysLookupFolderInsertedStartMessageEvent();
			eventsubprocess1.FlowElements.Add(syslookupfolderinserted);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			eventsubprocess1.FlowElements.Add(scripttask1);
			ProcessSchemaIntermediateThrowMessageEvent basesyslookupfolderinserted = CreateBaseSysLookupFolderInsertedIntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(basesyslookupfolderinserted);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("223b8971-31fb-4d44-8f89-c5eed6a62826"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("cfd53d66-8891-4a3e-9c4f-4b8970e3e405"),
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6"),
				CreatedInSchemaUId = new Guid("2d3e82e0-74a8-4703-888b-2b21b0057804"),
				CurveCenterPosition = new Point(170, 97),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2d3e82e0-74a8-4703-888b-2b21b0057804"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5ddc7db3-6983-45f4-9cf7-2a33779222c8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1f46d8c6-963a-4921-8dc6-c111a0717ab6"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("e7f1b8c2-e10c-49c7-9be7-99d0dd9a7917"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("cfd53d66-8891-4a3e-9c4f-4b8970e3e405"),
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6"),
				CreatedInSchemaUId = new Guid("2d3e82e0-74a8-4703-888b-2b21b0057804"),
				CurveCenterPosition = new Point(334, 100),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2d3e82e0-74a8-4703-888b-2b21b0057804"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1f46d8c6-963a-4921-8dc6-c111a0717ab6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("91872619-0514-4b0f-9ba5-20278b866b6b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("91c50aa2-19b9-4e21-a2a0-168efd2cdf03"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("cfd53d66-8891-4a3e-9c4f-4b8970e3e405"),
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6"),
				CreatedInSchemaUId = new Guid("2d3e82e0-74a8-4703-888b-2b21b0057804"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("2d3e82e0-74a8-4703-888b-2b21b0057804"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1196, 192),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("111addd4-d658-47bc-b5bc-bd189ccac883"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("91c50aa2-19b9-4e21-a2a0-168efd2cdf03"),
				CreatedInOwnerSchemaUId = new Guid("5403f977-1005-41a3-99a1-5ff37806bbbf"),
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6"),
				CreatedInSchemaUId = new Guid("2d3e82e0-74a8-4703-888b-2b21b0057804"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("2d3e82e0-74a8-4703-888b-2b21b0057804"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1167, 192),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("241555e6-79e5-4bdb-8247-ef39e2b4f856"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("111addd4-d658-47bc-b5bc-bd189ccac883"),
				CreatedInOwnerSchemaUId = new Guid("cfd53d66-8891-4a3e-9c4f-4b8970e3e405"),
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6"),
				CreatedInSchemaUId = new Guid("2d3e82e0-74a8-4703-888b-2b21b0057804"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("2d3e82e0-74a8-4703-888b-2b21b0057804"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(35, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(377, 164),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSysLookupFolderInsertedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5ddc7db3-6983-45f4-9cf7-2a33779222c8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("241555e6-79e5-4bdb-8247-ef39e2b4f856"),
				CreatedInOwnerSchemaUId = new Guid("cfd53d66-8891-4a3e-9c4f-4b8970e3e405"),
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6"),
				CreatedInSchemaUId = new Guid("2d3e82e0-74a8-4703-888b-2b21b0057804"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysLookupFolderInserted",
				ModifiedInSchemaUId = new Guid("2d3e82e0-74a8-4703-888b-2b21b0057804"),
				Name = @"SysLookupFolderInserted",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1f46d8c6-963a-4921-8dc6-c111a0717ab6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("241555e6-79e5-4bdb-8247-ef39e2b4f856"),
				CreatedInOwnerSchemaUId = new Guid("cfd53d66-8891-4a3e-9c4f-4b8970e3e405"),
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6"),
				CreatedInSchemaUId = new Guid("2d3e82e0-74a8-4703-888b-2b21b0057804"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2d3e82e0-74a8-4703-888b-2b21b0057804"),
				Name = @"ScriptTask1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(141, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,145,223,78,131,48,20,198,175,71,178,119,104,118,177,64,34,13,168,24,151,197,11,254,137,75,140,38,16,31,160,210,35,52,129,195,82,202,22,99,124,119,139,76,68,55,47,236,93,207,119,190,175,231,119,154,116,130,19,198,107,129,137,108,186,237,134,147,27,130,176,39,137,174,155,11,255,124,229,95,4,190,103,95,6,78,100,71,177,235,218,43,223,115,109,199,241,28,239,42,116,244,185,94,88,235,185,177,99,146,240,231,12,242,78,10,245,26,99,33,16,116,210,83,11,50,108,16,33,87,162,65,26,5,63,59,14,70,41,138,82,221,195,14,42,109,249,157,66,19,80,49,42,125,207,242,18,106,150,66,222,72,158,142,22,115,16,233,160,210,7,86,195,25,57,212,54,188,159,77,188,16,243,251,9,122,199,218,219,138,21,230,233,184,150,134,12,83,96,220,34,203,229,220,152,253,207,24,150,12,11,232,237,159,130,101,145,55,157,113,132,148,157,66,122,220,130,100,253,154,38,108,211,143,25,169,166,164,58,125,54,194,126,117,28,13,56,70,211,126,180,63,219,6,76,191,170,154,125,191,183,247,185,33,65,117,18,137,146,29,172,63,0,196,28,242,201,42,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateBaseSysLookupFolderInsertedIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("91872619-0514-4b0f-9ba5-20278b866b6b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("241555e6-79e5-4bdb-8247-ef39e2b4f856"),
				CreatedInOwnerSchemaUId = new Guid("cfd53d66-8891-4a3e-9c4f-4b8970e3e405"),
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6"),
				CreatedInSchemaUId = new Guid("2d3e82e0-74a8-4703-888b-2b21b0057804"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"SysLookupFolderInserted",
				ModifiedInSchemaUId = new Guid("2d3e82e0-74a8-4703-888b-2b21b0057804"),
				Name = @"BaseSysLookupFolderInserted",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(309, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
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

		protected override SchemaMethod CreateCheckCanManageLookupsMethod() {
			SchemaMethod method = base.CreateCheckCanManageLookupsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,179,6,0,7,133,17,243,7,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysLookupFolderEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2d3e82e0-74a8-4703-888b-2b21b0057804"));
		}

		#endregion

	}

	#endregion


	#region Class: SysLookupFolderEventsProcess

	/// <exclude/>
	public class SysLookupFolderEventsProcess : SysLookupFolder_BaseEventsProcess
	{

		public SysLookupFolderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

