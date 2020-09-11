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
	using Terrasoft.Core.Store;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: SysModuleVisaSchema

	/// <exclude/>
	public class SysModuleVisaSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysModuleVisaSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysModuleVisaSchema(SysModuleVisaSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysModuleVisaSchema(SysModuleVisaSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1980906b-3a10-489c-b67c-30d74100b8cb");
			RealUId = new Guid("1980906b-3a10-489c-b67c-30d74100b8cb");
			Name = "SysModuleVisa";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("f06e2eda-824e-415b-8e16-bcd4bd1cec90")) == null) {
				Columns.Add(CreateUseCustomNotificationProviderColumn());
			}
			if (Columns.FindByUId(new Guid("dc6037ae-6e25-4920-ab27-10d3dd9e2e1e")) == null) {
				Columns.Add(CreateVisaSchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("5868314d-f071-4b55-9ccc-a5557609f72c")) == null) {
				Columns.Add(CreateMasterColumnUIdColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateUseCustomNotificationProviderColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("f06e2eda-824e-415b-8e16-bcd4bd1cec90"),
				Name = @"UseCustomNotificationProvider",
				CreatedInSchemaUId = new Guid("1980906b-3a10-489c-b67c-30d74100b8cb"),
				ModifiedInSchemaUId = new Guid("1980906b-3a10-489c-b67c-30d74100b8cb"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateVisaSchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("dc6037ae-6e25-4920-ab27-10d3dd9e2e1e"),
				Name = @"VisaSchemaUId",
				CreatedInSchemaUId = new Guid("1980906b-3a10-489c-b67c-30d74100b8cb"),
				ModifiedInSchemaUId = new Guid("1980906b-3a10-489c-b67c-30d74100b8cb"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateMasterColumnUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("5868314d-f071-4b55-9ccc-a5557609f72c"),
				Name = @"MasterColumnUId",
				CreatedInSchemaUId = new Guid("1980906b-3a10-489c-b67c-30d74100b8cb"),
				ModifiedInSchemaUId = new Guid("1980906b-3a10-489c-b67c-30d74100b8cb"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysModuleVisaEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysModuleVisaEventsProcessSchema() {
			var schema = new SysModuleVisaEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysModuleVisa(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysModuleVisa_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysModuleVisaSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysModuleVisaSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1980906b-3a10-489c-b67c-30d74100b8cb"));
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleVisa

	/// <summary>
	/// Section approval settings.
	/// </summary>
	public class SysModuleVisa : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysModuleVisa(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysModuleVisa";
		}

		public SysModuleVisa(SysModuleVisa source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// UseCustomNotificationProvider.
		/// </summary>
		public bool UseCustomNotificationProvider {
			get {
				return GetTypedColumnValue<bool>("UseCustomNotificationProvider");
			}
			set {
				SetColumnValue("UseCustomNotificationProvider", value);
			}
		}

		/// <summary>
		/// Visa schema identifier.
		/// </summary>
		public Guid VisaSchemaUId {
			get {
				return GetTypedColumnValue<Guid>("VisaSchemaUId");
			}
			set {
				SetColumnValue("VisaSchemaUId", value);
			}
		}

		/// <summary>
		/// Section entity column identifier.
		/// </summary>
		public Guid MasterColumnUId {
			get {
				return GetTypedColumnValue<Guid>("MasterColumnUId");
			}
			set {
				SetColumnValue("MasterColumnUId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysModuleVisa_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysModuleVisaDeleted", e);
			Saving += (s, e) => ThrowEvent("SysModuleVisaSaving", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysModuleVisa(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleVisa_BaseEventsProcess

	/// <exclude/>
	public partial class SysModuleVisa_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysModuleVisa
	{

		public SysModuleVisa_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysModuleVisa_BaseEventsProcess";
			SchemaUId = new Guid("1980906b-3a10-489c-b67c-30d74100b8cb");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1980906b-3a10-489c-b67c-30d74100b8cb");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess3_8f17dbbf2a9a4ceb976aea813b51feaf;
		public ProcessFlowElement EventSubProcess3_8f17dbbf2a9a4ceb976aea813b51feaf {
			get {
				return _eventSubProcess3_8f17dbbf2a9a4ceb976aea813b51feaf ?? (_eventSubProcess3_8f17dbbf2a9a4ceb976aea813b51feaf = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3_8f17dbbf2a9a4ceb976aea813b51feaf",
					SchemaElementUId = new Guid("8f17dbbf-2a9a-4ceb-976a-ea813b51feaf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3_7adbd29fbe7f44bfbb742ab4fcae87c4;
		public ProcessFlowElement StartMessage3_7adbd29fbe7f44bfbb742ab4fcae87c4 {
			get {
				return _startMessage3_7adbd29fbe7f44bfbb742ab4fcae87c4 ?? (_startMessage3_7adbd29fbe7f44bfbb742ab4fcae87c4 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3_7adbd29fbe7f44bfbb742ab4fcae87c4",
					SchemaElementUId = new Guid("7adbd29f-be7f-44bf-bb74-2ab4fcae87c4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask3_6cf309493e44498f94d2b735636ea708;
		public ProcessScriptTask ScriptTask3_6cf309493e44498f94d2b735636ea708 {
			get {
				return _scriptTask3_6cf309493e44498f94d2b735636ea708 ?? (_scriptTask3_6cf309493e44498f94d2b735636ea708 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3_6cf309493e44498f94d2b735636ea708",
					SchemaElementUId = new Guid("6cf30949-3e44-498f-94d2-b735636ea708"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3_6cf309493e44498f94d2b735636ea708Execute,
				});
			}
		}

		private ProcessTerminateEvent _terminateEvent1_dff9ba1b625243819b89d3500370d8e9;
		public ProcessTerminateEvent TerminateEvent1_dff9ba1b625243819b89d3500370d8e9 {
			get {
				return _terminateEvent1_dff9ba1b625243819b89d3500370d8e9 ?? (_terminateEvent1_dff9ba1b625243819b89d3500370d8e9 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateEvent1_dff9ba1b625243819b89d3500370d8e9",
					SchemaElementUId = new Guid("dff9ba1b-6252-4381-9b89-d3500370d8e9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess3_8f17dbbf2a9a4ceb976aea813b51feaf.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3_8f17dbbf2a9a4ceb976aea813b51feaf };
			FlowElements[StartMessage3_7adbd29fbe7f44bfbb742ab4fcae87c4.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3_7adbd29fbe7f44bfbb742ab4fcae87c4 };
			FlowElements[ScriptTask3_6cf309493e44498f94d2b735636ea708.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3_6cf309493e44498f94d2b735636ea708 };
			FlowElements[TerminateEvent1_dff9ba1b625243819b89d3500370d8e9.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateEvent1_dff9ba1b625243819b89d3500370d8e9 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess3_8f17dbbf2a9a4ceb976aea813b51feaf":
						break;
					case "StartMessage3_7adbd29fbe7f44bfbb742ab4fcae87c4":
						e.Context.QueueTasks.Enqueue("ScriptTask3_6cf309493e44498f94d2b735636ea708");
						break;
					case "ScriptTask3_6cf309493e44498f94d2b735636ea708":
						e.Context.QueueTasks.Enqueue("TerminateEvent1_dff9ba1b625243819b89d3500370d8e9");
						break;
					case "TerminateEvent1_dff9ba1b625243819b89d3500370d8e9":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage3_7adbd29fbe7f44bfbb742ab4fcae87c4");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess3_8f17dbbf2a9a4ceb976aea813b51feaf":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3_7adbd29fbe7f44bfbb742ab4fcae87c4":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3_7adbd29fbe7f44bfbb742ab4fcae87c4";
					result = StartMessage3_7adbd29fbe7f44bfbb742ab4fcae87c4.Execute(context);
					break;
				case "ScriptTask3_6cf309493e44498f94d2b735636ea708":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3_6cf309493e44498f94d2b735636ea708";
					result = ScriptTask3_6cf309493e44498f94d2b735636ea708.Execute(context, ScriptTask3_6cf309493e44498f94d2b735636ea708Execute);
					break;
				case "TerminateEvent1_dff9ba1b625243819b89d3500370d8e9":
					context.QueueTasks.Dequeue();
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

		public virtual bool ScriptTask3_6cf309493e44498f94d2b735636ea708Execute(ProcessExecutingContext context) {
			ClearCache();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "SysModuleVisaSaving":
							if (ActivatedEventElements.Contains("StartMessage3_7adbd29fbe7f44bfbb742ab4fcae87c4")) {
							context.QueueTasks.Enqueue("StartMessage3_7adbd29fbe7f44bfbb742ab4fcae87c4");
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

	#region Class: SysModuleVisa_BaseEventsProcess

	/// <exclude/>
	public class SysModuleVisa_BaseEventsProcess : SysModuleVisa_BaseEventsProcess<SysModuleVisa>
	{

		public SysModuleVisa_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysModuleVisa_BaseEventsProcess

	public partial class SysModuleVisa_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void ClearCache() {
			Store.Cache[CacheLevel.Application].ExpireGroup(CachedSysModuleVisaRepository.SysModuleVisaCacheGroupName);
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleVisaEventsProcessSchema

	/// <exclude/>
	public class SysModuleVisaEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysModuleVisaEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysModuleVisaEventsProcessSchema(SysModuleVisaEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysModuleVisa_BaseEventsProcess";
			UId = new Guid("19346f76-acab-46e9-a60a-da43cdc7e149");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
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
			ProcessSchemaLaneSet schemaLaneSet2_1bdd39226f6f480682afe7a765ba82f0 = CreateLaneSet2_1bdd39226f6f480682afe7a765ba82f0LaneSet();
			LaneSets.Add(schemaLaneSet2_1bdd39226f6f480682afe7a765ba82f0);
			ProcessSchemaLane schemaLane1_53bc996cd1c04593ab86bef187c504de = CreateLane1_53bc996cd1c04593ab86bef187c504deLane();
			schemaLaneSet2_1bdd39226f6f480682afe7a765ba82f0.Lanes.Add(schemaLane1_53bc996cd1c04593ab86bef187c504de);
			ProcessSchemaEventSubProcess eventsubprocess3_8f17dbbf2a9a4ceb976aea813b51feaf = CreateEventSubProcess3_8f17dbbf2a9a4ceb976aea813b51feafEventSubProcess();
			FlowElements.Add(eventsubprocess3_8f17dbbf2a9a4ceb976aea813b51feaf);
			ProcessSchemaStartMessageEvent startmessage3_7adbd29fbe7f44bfbb742ab4fcae87c4 = CreateStartMessage3_7adbd29fbe7f44bfbb742ab4fcae87c4StartMessageEvent();
			eventsubprocess3_8f17dbbf2a9a4ceb976aea813b51feaf.FlowElements.Add(startmessage3_7adbd29fbe7f44bfbb742ab4fcae87c4);
			ProcessSchemaScriptTask scripttask3_6cf309493e44498f94d2b735636ea708 = CreateScriptTask3_6cf309493e44498f94d2b735636ea708ScriptTask();
			eventsubprocess3_8f17dbbf2a9a4ceb976aea813b51feaf.FlowElements.Add(scripttask3_6cf309493e44498f94d2b735636ea708);
			ProcessSchemaTerminateEvent terminateevent1_dff9ba1b625243819b89d3500370d8e9 = CreateTerminateEvent1_dff9ba1b625243819b89d3500370d8e9TerminateEvent();
			eventsubprocess3_8f17dbbf2a9a4ceb976aea813b51feaf.FlowElements.Add(terminateevent1_dff9ba1b625243819b89d3500370d8e9);
			FlowElements.Add(CreateSequenceFlow2_1473b32b923a46aaa74a91442683fe16SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3_ea6860c73fcd432ab85f7f7f2ef91811SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2_1473b32b923a46aaa74a91442683fe16SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2_1473b32b923a46aaa74a91442683fe16",
				UId = new Guid("1473b32b-923a-46aa-a74a-91442683fe16"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("19346f76-acab-46e9-a60a-da43cdc7e149"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("19346f76-acab-46e9-a60a-da43cdc7e149"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7adbd29f-be7f-44bf-bb74-2ab4fcae87c4"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6cf30949-3e44-498f-94d2-b735636ea708"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3_ea6860c73fcd432ab85f7f7f2ef91811SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3_ea6860c73fcd432ab85f7f7f2ef91811",
				UId = new Guid("ea6860c7-3fcd-432a-b85f-7f7f2ef91811"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("19346f76-acab-46e9-a60a-da43cdc7e149"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("19346f76-acab-46e9-a60a-da43cdc7e149"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6cf30949-3e44-498f-94d2-b735636ea708"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("dff9ba1b-6252-4381-9b89-d3500370d8e9"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet2_1bdd39226f6f480682afe7a765ba82f0LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet2_1bdd39226f6f480682afe7a765ba82f0 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("1bdd3922-6f6f-4806-82af-e7a765ba82f0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("19346f76-acab-46e9-a60a-da43cdc7e149"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("19346f76-acab-46e9-a60a-da43cdc7e149"),
				Name = @"LaneSet2_1bdd39226f6f480682afe7a765ba82f0",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet2_1bdd39226f6f480682afe7a765ba82f0;
		}

		protected virtual ProcessSchemaLane CreateLane1_53bc996cd1c04593ab86bef187c504deLane() {
			ProcessSchemaLane schemaLane1_53bc996cd1c04593ab86bef187c504de = new ProcessSchemaLane(this) {
				UId = new Guid("53bc996c-d1c0-4593-ab86-bef187c504de"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1bdd3922-6f6f-4806-82af-e7a765ba82f0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("19346f76-acab-46e9-a60a-da43cdc7e149"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("19346f76-acab-46e9-a60a-da43cdc7e149"),
				Name = @"Lane1_53bc996cd1c04593ab86bef187c504de",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1_53bc996cd1c04593ab86bef187c504de;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3_8f17dbbf2a9a4ceb976aea813b51feafEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3_8f17dbbf2a9a4ceb976aea813b51feaf = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("8f17dbbf-2a9a-4ceb-976a-ea813b51feaf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("53bc996c-d1c0-4593-ab86-bef187c504de"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("19346f76-acab-46e9-a60a-da43cdc7e149"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("19346f76-acab-46e9-a60a-da43cdc7e149"),
				Name = @"EventSubProcess3_8f17dbbf2a9a4ceb976aea813b51feaf",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(34, 28),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(300, 300),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3_8f17dbbf2a9a4ceb976aea813b51feaf;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage3_7adbd29fbe7f44bfbb742ab4fcae87c4StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7adbd29f-be7f-44bf-bb74-2ab4fcae87c4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8f17dbbf-2a9a-4ceb-976a-ea813b51feaf"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("19346f76-acab-46e9-a60a-da43cdc7e149"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysModuleVisaSaving",
				ModifiedInSchemaUId = new Guid("19346f76-acab-46e9-a60a-da43cdc7e149"),
				Name = @"StartMessage3_7adbd29fbe7f44bfbb742ab4fcae87c4",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(28, 136),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask3_6cf309493e44498f94d2b735636ea708ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6cf30949-3e44-498f-94d2-b735636ea708"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8f17dbbf-2a9a-4ceb-976a-ea813b51feaf"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("19346f76-acab-46e9-a60a-da43cdc7e149"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("19346f76-acab-46e9-a60a-da43cdc7e149"),
				Name = @"ScriptTask3_6cf309493e44498f94d2b735636ea708",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(122, 122),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,206,73,77,44,114,78,76,206,72,213,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,95,203,129,186,26,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateEvent1_dff9ba1b625243819b89d3500370d8e9TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("dff9ba1b-6252-4381-9b89-d3500370d8e9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8f17dbbf-2a9a-4ceb-976a-ea813b51feaf"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("19346f76-acab-46e9-a60a-da43cdc7e149"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("19346f76-acab-46e9-a60a-da43cdc7e149"),
				Name = @"TerminateEvent1_dff9ba1b625243819b89d3500370d8e9",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(246, 136),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateClearCacheMethod());
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
				UId = new Guid("8ee480d2-f23f-4965-b2db-6d20b718932f"),
				Name = "Terrasoft.Core.Store",
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

		protected virtual SchemaMethod CreateClearCacheMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("dc06e70f-6d3c-4bcb-9e27-8860b7777ac6"),
				Name = "ClearCache",
				CreatedInSchemaUId = new Guid("19346f76-acab-46e9-a60a-da43cdc7e149"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,46,201,47,74,213,115,78,76,206,72,141,6,147,62,169,101,169,57,122,142,5,5,57,153,201,137,37,153,249,121,177,122,174,21,5,153,69,169,238,69,249,165,5,26,96,53,41,193,149,197,190,249,41,165,57,169,97,153,197,137,65,169,5,249,197,153,64,115,42,245,80,196,193,74,193,186,252,18,115,83,53,173,1,92,104,138,70,107,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysModuleVisaEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("19346f76-acab-46e9-a60a-da43cdc7e149"));
		}

		#endregion

	}

	#endregion


	#region Class: SysModuleVisaEventsProcess

	/// <exclude/>
	public class SysModuleVisaEventsProcess : SysModuleVisa_BaseEventsProcess
	{

		public SysModuleVisaEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

