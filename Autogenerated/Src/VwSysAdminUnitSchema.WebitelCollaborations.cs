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
	using Terrasoft.Core.OperationLog;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;
	using Terrasoft.Web.Common;

	#region Class: VwSysAdminUnit_WebitelCollaborations_TerrasoftSchema

	/// <exclude/>
	public class VwSysAdminUnit_WebitelCollaborations_TerrasoftSchema : Terrasoft.Configuration.VwSysAdminUnit_LDAP_TerrasoftSchema
	{

		#region Constructors: Public

		public VwSysAdminUnit_WebitelCollaborations_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwSysAdminUnit_WebitelCollaborations_TerrasoftSchema(VwSysAdminUnit_WebitelCollaborations_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwSysAdminUnit_WebitelCollaborations_TerrasoftSchema(VwSysAdminUnit_WebitelCollaborations_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("8b7a054d-e633-4373-8d37-249a9920694e");
			Name = "VwSysAdminUnit_WebitelCollaborations_Terrasoft";
			ParentSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364");
			ExtendParent = true;
			CreatedInPackageId = new Guid("b7fb6e74-77cf-499f-8e71-7072f74ac64a");
			IsDBView = true;
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
			EventsProcessSchema = CreateVwSysAdminUnit_WebitelCollaborations_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwSysAdminUnit_WebitelCollaborations_TerrasoftEventsProcessSchema() {
			var schema = new VwSysAdminUnit_WebitelCollaborations_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwSysAdminUnit_WebitelCollaborations_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwSysAdminUnit_WebitelCollaborationsEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwSysAdminUnit_WebitelCollaborations_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwSysAdminUnit_WebitelCollaborations_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8b7a054d-e633-4373-8d37-249a9920694e"));
		}

		#endregion

	}

	#endregion

	#region Class: VwSysAdminUnit_WebitelCollaborations_Terrasoft

	/// <summary>
	/// Users/roles (view).
	/// </summary>
	public class VwSysAdminUnit_WebitelCollaborations_Terrasoft : Terrasoft.Configuration.VwSysAdminUnit_LDAP_Terrasoft
	{

		#region Constructors: Public

		public VwSysAdminUnit_WebitelCollaborations_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwSysAdminUnit_WebitelCollaborations_Terrasoft";
		}

		public VwSysAdminUnit_WebitelCollaborations_Terrasoft(VwSysAdminUnit_WebitelCollaborations_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwSysAdminUnit_WebitelCollaborationsEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserted += (s, e) => ThrowEvent("VwSysAdminUnit_WebitelCollaborations_TerrasoftInserted", e);
			Validating += (s, e) => ThrowEvent("VwSysAdminUnit_WebitelCollaborations_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwSysAdminUnit_WebitelCollaborations_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwSysAdminUnit_WebitelCollaborationsEventsProcess

	/// <exclude/>
	public partial class VwSysAdminUnit_WebitelCollaborationsEventsProcess<TEntity> : Terrasoft.Configuration.VwSysAdminUnit_LDAPEventsProcess<TEntity> where TEntity : VwSysAdminUnit_WebitelCollaborations_Terrasoft
	{

		public VwSysAdminUnit_WebitelCollaborationsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwSysAdminUnit_WebitelCollaborationsEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			_webitelSymMsgLibId = () => {{ return new Guid("DDA88D7D-19D0-4009-A3EE-192069FD7E64"); }};
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8b7a054d-e633-4373-8d37-249a9920694e");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private Func<Guid> _webitelSymMsgLibId;
		public virtual Guid WebitelSymMsgLibId {
			get {
				return (_webitelSymMsgLibId ?? (_webitelSymMsgLibId = () => Guid.Empty)).Invoke();
			}
			set {
				_webitelSymMsgLibId = () => { return value; };
			}
		}

		private ProcessFlowElement _childVwSysAdminUnitInsertedEventSubProcess;
		public ProcessFlowElement ChildVwSysAdminUnitInsertedEventSubProcess {
			get {
				return _childVwSysAdminUnitInsertedEventSubProcess ?? (_childVwSysAdminUnitInsertedEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ChildVwSysAdminUnitInsertedEventSubProcess",
					SchemaElementUId = new Guid("c45333cd-0ad0-42fd-a61c-aef8b5208ac5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _childVwSysAdminUnitInsertedStartMessage;
		public ProcessFlowElement ChildVwSysAdminUnitInsertedStartMessage {
			get {
				return _childVwSysAdminUnitInsertedStartMessage ?? (_childVwSysAdminUnitInsertedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChildVwSysAdminUnitInsertedStartMessage",
					SchemaElementUId = new Guid("d9ceba15-ad97-4418-bec7-aa8d137fbe3e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _childVwSysAdminUnitInsertedIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent ChildVwSysAdminUnitInsertedIntermediateThrowMessageEvent {
			get {
				return _childVwSysAdminUnitInsertedIntermediateThrowMessageEvent ?? (_childVwSysAdminUnitInsertedIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ChildVwSysAdminUnitInsertedIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("7ac28609-190e-42e4-9dfc-096cbd3cec33"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "VwSysAdminUnitInserted",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _childVwSysAdminUnitScriptTask;
		public ProcessScriptTask ChildVwSysAdminUnitScriptTask {
			get {
				return _childVwSysAdminUnitScriptTask ?? (_childVwSysAdminUnitScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChildVwSysAdminUnitScriptTask",
					SchemaElementUId = new Guid("9fb32ee2-1575-4a71-aff2-1846987cd7ec"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChildVwSysAdminUnitScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[ChildVwSysAdminUnitInsertedEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildVwSysAdminUnitInsertedEventSubProcess };
			FlowElements[ChildVwSysAdminUnitInsertedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildVwSysAdminUnitInsertedStartMessage };
			FlowElements[ChildVwSysAdminUnitInsertedIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildVwSysAdminUnitInsertedIntermediateThrowMessageEvent };
			FlowElements[ChildVwSysAdminUnitScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildVwSysAdminUnitScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "ChildVwSysAdminUnitInsertedEventSubProcess":
						break;
					case "ChildVwSysAdminUnitInsertedStartMessage":
						e.Context.QueueTasks.Enqueue("ChildVwSysAdminUnitScriptTask");
						break;
					case "ChildVwSysAdminUnitInsertedIntermediateThrowMessageEvent":
						break;
					case "ChildVwSysAdminUnitScriptTask":
						e.Context.QueueTasks.Enqueue("ChildVwSysAdminUnitInsertedIntermediateThrowMessageEvent");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ChildVwSysAdminUnitInsertedStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "ChildVwSysAdminUnitInsertedEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ChildVwSysAdminUnitInsertedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildVwSysAdminUnitInsertedStartMessage";
					result = ChildVwSysAdminUnitInsertedStartMessage.Execute(context);
					break;
				case "ChildVwSysAdminUnitInsertedIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "VwSysAdminUnitInserted");
					result = ChildVwSysAdminUnitInsertedIntermediateThrowMessageEvent.Execute(context);
					break;
				case "ChildVwSysAdminUnitScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildVwSysAdminUnitScriptTask";
					result = ChildVwSysAdminUnitScriptTask.Execute(context, ChildVwSysAdminUnitScriptTaskExecute);
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

		public virtual bool ChildVwSysAdminUnitScriptTaskExecute(ProcessExecutingContext context) {
			const int allEmployeesConnectionType = 0;
			if (Entity.ConnectionType != allEmployeesConnectionType) {
				return true;
			}
			SetDefaultSysMsgUserSettings();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "VwSysAdminUnit_WebitelCollaborations_TerrasoftInserted":
							if (ActivatedEventElements.Contains("ChildVwSysAdminUnitInsertedStartMessage")) {
							context.QueueTasks.Enqueue("ChildVwSysAdminUnitInsertedStartMessage");
							ProcessQueue(context);
							return;
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

	#region Class: VwSysAdminUnit_WebitelCollaborationsEventsProcess

	/// <exclude/>
	public class VwSysAdminUnit_WebitelCollaborationsEventsProcess : VwSysAdminUnit_WebitelCollaborationsEventsProcess<VwSysAdminUnit_WebitelCollaborations_Terrasoft>
	{

		public VwSysAdminUnit_WebitelCollaborationsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwSysAdminUnit_WebitelCollaborationsEventsProcess

	public partial class VwSysAdminUnit_WebitelCollaborationsEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void SetDefaultSysMsgUserSettings() {
			var entitySchemaManager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
			EntitySchema wSysAccountSchema = entitySchemaManager.GetInstanceByName("WSysAccount");
			Entity wSysAccountEntity = wSysAccountSchema.CreateEntity(UserConnection);
			EntitySchema sysMsgUserSettingsSchema = entitySchemaManager.GetInstanceByName("SysMsgUserSettings");
			Entity sysMsgUserSettingsEntity = sysMsgUserSettingsSchema.CreateEntity(UserConnection);
			sysMsgUserSettingsEntity.SetDefColumnValues();
			sysMsgUserSettingsEntity.SetColumnValue("UserId", Entity.PrimaryColumnValue);
			sysMsgUserSettingsEntity.SetColumnValue("SysMsgLibId", WebitelSymMsgLibId);
			Dictionary<string, object> connectionParamsDictionary = new Dictionary<string, object>() {
				{ "isWrapUpDisabled", false }, 
				{ "debugMode", false },
				{ "disableCallCentre", false },
				{ "isAutoLogin", true },
				{ "useWebitelCti", false },
				{ "useWebPhone", true },
				{ "useVideo", false }
			};
			string connectionParams = ServiceStackTextHelper.Serialize(connectionParamsDictionary);
			sysMsgUserSettingsEntity.SetColumnValue("ConnectionParams", connectionParams);
			sysMsgUserSettingsEntity.Save();
		}

		public override void CheckCanManageLookups() {
		}

		#endregion

	}

	#endregion

	#region Class: VwSysAdminUnit_WebitelCollaborations_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class VwSysAdminUnit_WebitelCollaborations_TerrasoftEventsProcessSchema : Terrasoft.Configuration.VwSysAdminUnit_LDAP_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public VwSysAdminUnit_WebitelCollaborations_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwSysAdminUnit_WebitelCollaborations_TerrasoftEventsProcessSchema(VwSysAdminUnit_WebitelCollaborations_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwSysAdminUnit_WebitelCollaborationsEventsProcess";
			UId = new Guid("ee8032b7-a2c9-41da-bbfd-f2ea07545b2b");
			CreatedInPackageId = new Guid("b7fb6e74-77cf-499f-8e71-7072f74ac64a");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateWebitelSymMsgLibIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("dac43790-71c9-4cbb-918d-fd5043485572"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ee8032b7-a2c9-41da-bbfd-f2ea07545b2b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ee8032b7-a2c9-41da-bbfd-f2ea07545b2b"),
				Name = @"WebitelSymMsgLibId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"new Guid(""DDA88D7D-19D0-4009-A3EE-192069FD7E64"")",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("ee8032b7-a2c9-41da-bbfd-f2ea07545b2b"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateWebitelSymMsgLibIdParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaChildVwSysAdminUnitLaneSet = CreateChildVwSysAdminUnitLaneSetLaneSet();
			LaneSets.Add(schemaChildVwSysAdminUnitLaneSet);
			ProcessSchemaLane schemaVwSysAdminUnitLane = CreateVwSysAdminUnitLaneLane();
			schemaChildVwSysAdminUnitLaneSet.Lanes.Add(schemaVwSysAdminUnitLane);
			ProcessSchemaEventSubProcess childvwsysadminunitinsertedeventsubprocess = CreateChildVwSysAdminUnitInsertedEventSubProcessEventSubProcess();
			FlowElements.Add(childvwsysadminunitinsertedeventsubprocess);
			ProcessSchemaStartMessageEvent childvwsysadminunitinsertedstartmessage = CreateChildVwSysAdminUnitInsertedStartMessageStartMessageEvent();
			childvwsysadminunitinsertedeventsubprocess.FlowElements.Add(childvwsysadminunitinsertedstartmessage);
			ProcessSchemaIntermediateThrowMessageEvent childvwsysadminunitinsertedintermediatethrowmessageevent = CreateChildVwSysAdminUnitInsertedIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			childvwsysadminunitinsertedeventsubprocess.FlowElements.Add(childvwsysadminunitinsertedintermediatethrowmessageevent);
			ProcessSchemaScriptTask childvwsysadminunitscripttask = CreateChildVwSysAdminUnitScriptTaskScriptTask();
			childvwsysadminunitinsertedeventsubprocess.FlowElements.Add(childvwsysadminunitscripttask);
			FlowElements.Add(CreateSequenceFlow1345345345345SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7345354345SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1345345345345SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1345345345345",
				UId = new Guid("bc2f08ab-d7ea-441f-a66d-fe16130047ec"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				CreatedInPackageId = new Guid("b7fb6e74-77cf-499f-8e71-7072f74ac64a"),
				CreatedInSchemaUId = new Guid("ee8032b7-a2c9-41da-bbfd-f2ea07545b2b"),
				CurveCenterPosition = new Point(226, 110),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ee8032b7-a2c9-41da-bbfd-f2ea07545b2b"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d9ceba15-ad97-4418-bec7-aa8d137fbe3e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9fb32ee2-1575-4a71-aff2-1846987cd7ec"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7345354345SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7345354345",
				UId = new Guid("efeeba98-ae22-4c75-af04-05fbe0468750"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				CreatedInPackageId = new Guid("b7fb6e74-77cf-499f-8e71-7072f74ac64a"),
				CreatedInSchemaUId = new Guid("ee8032b7-a2c9-41da-bbfd-f2ea07545b2b"),
				CurveCenterPosition = new Point(406, 113),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ee8032b7-a2c9-41da-bbfd-f2ea07545b2b"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9fb32ee2-1575-4a71-aff2-1846987cd7ec"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7ac28609-190e-42e4-9dfc-096cbd3cec33"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateChildVwSysAdminUnitLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaChildVwSysAdminUnitLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("acf74876-bcbd-494c-a651-b4dca5069a3f"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				CreatedInPackageId = new Guid("b7fb6e74-77cf-499f-8e71-7072f74ac64a"),
				CreatedInSchemaUId = new Guid("ee8032b7-a2c9-41da-bbfd-f2ea07545b2b"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("ee8032b7-a2c9-41da-bbfd-f2ea07545b2b"),
				Name = @"ChildVwSysAdminUnitLaneSet",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(803, 218),
				UseBackgroundMode = false
			};
			return schemaChildVwSysAdminUnitLaneSet;
		}

		protected virtual ProcessSchemaLane CreateVwSysAdminUnitLaneLane() {
			ProcessSchemaLane schemaVwSysAdminUnitLane = new ProcessSchemaLane(this) {
				UId = new Guid("52c145ed-d656-4c90-8d0d-e8bce316f4e4"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("acf74876-bcbd-494c-a651-b4dca5069a3f"),
				CreatedInOwnerSchemaUId = new Guid("8b7a054d-e633-4373-8d37-249a9920694e"),
				CreatedInPackageId = new Guid("b7fb6e74-77cf-499f-8e71-7072f74ac64a"),
				CreatedInSchemaUId = new Guid("ee8032b7-a2c9-41da-bbfd-f2ea07545b2b"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("ee8032b7-a2c9-41da-bbfd-f2ea07545b2b"),
				Name = @"VwSysAdminUnitLane",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(774, 218),
				UseBackgroundMode = false
			};
			return schemaVwSysAdminUnitLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateChildVwSysAdminUnitInsertedEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaChildVwSysAdminUnitInsertedEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c45333cd-0ad0-42fd-a61c-aef8b5208ac5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("52c145ed-d656-4c90-8d0d-e8bce316f4e4"),
				CreatedInOwnerSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				CreatedInPackageId = new Guid("b7fb6e74-77cf-499f-8e71-7072f74ac64a"),
				CreatedInSchemaUId = new Guid("ee8032b7-a2c9-41da-bbfd-f2ea07545b2b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ee8032b7-a2c9-41da-bbfd-f2ea07545b2b"),
				Name = @"ChildVwSysAdminUnitInsertedEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(63, 28),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(420, 176),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaChildVwSysAdminUnitInsertedEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChildVwSysAdminUnitInsertedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d9ceba15-ad97-4418-bec7-aa8d137fbe3e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c45333cd-0ad0-42fd-a61c-aef8b5208ac5"),
				CreatedInOwnerSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				CreatedInPackageId = new Guid("b7fb6e74-77cf-499f-8e71-7072f74ac64a"),
				CreatedInSchemaUId = new Guid("ee8032b7-a2c9-41da-bbfd-f2ea07545b2b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"VwSysAdminUnitInserted",
				ModifiedInSchemaUId = new Guid("ee8032b7-a2c9-41da-bbfd-f2ea07545b2b"),
				Name = @"ChildVwSysAdminUnitInsertedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(50, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateChildVwSysAdminUnitInsertedIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("7ac28609-190e-42e4-9dfc-096cbd3cec33"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c45333cd-0ad0-42fd-a61c-aef8b5208ac5"),
				CreatedInOwnerSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				CreatedInPackageId = new Guid("b7fb6e74-77cf-499f-8e71-7072f74ac64a"),
				CreatedInSchemaUId = new Guid("ee8032b7-a2c9-41da-bbfd-f2ea07545b2b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"VwSysAdminUnitInserted",
				ModifiedInSchemaUId = new Guid("ee8032b7-a2c9-41da-bbfd-f2ea07545b2b"),
				Name = @"ChildVwSysAdminUnitInsertedIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(351, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChildVwSysAdminUnitScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9fb32ee2-1575-4a71-aff2-1846987cd7ec"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c45333cd-0ad0-42fd-a61c-aef8b5208ac5"),
				CreatedInOwnerSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				CreatedInPackageId = new Guid("b7fb6e74-77cf-499f-8e71-7072f74ac64a"),
				CreatedInSchemaUId = new Guid("ee8032b7-a2c9-41da-bbfd-f2ea07545b2b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ee8032b7-a2c9-41da-bbfd-f2ea07545b2b"),
				Name = @"ChildVwSysAdminUnitScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(176, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,140,49,14,194,48,16,4,107,44,249,15,71,151,52,136,30,165,130,148,84,129,7,68,209,37,58,201,156,35,223,186,176,162,252,61,46,17,5,237,206,204,78,81,13,36,10,26,67,232,63,107,136,133,217,238,81,149,39,72,212,87,89,153,58,186,222,188,147,153,154,94,33,40,151,31,126,238,254,212,45,109,222,157,18,35,39,37,164,204,245,106,247,110,96,60,120,30,115,192,80,236,105,203,219,56,213,13,162,139,53,109,117,190,139,3,83,65,206,20,166,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateSetDefaultSysMsgUserSettingsMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("b7fb6e74-77cf-499f-8e71-7072f74ac64a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("b7fb6e74-77cf-499f-8e71-7072f74ac64a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("b7fb6e74-77cf-499f-8e71-7072f74ac64a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("b7fb6e74-77cf-499f-8e71-7072f74ac64a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("b7fb6e74-77cf-499f-8e71-7072f74ac64a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("b7fb6e74-77cf-499f-8e71-7072f74ac64a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("b7fb6e74-77cf-499f-8e71-7072f74ac64a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("95aee64a-275c-41cb-bd10-56c1b25c6635"),
				Name = "Terrasoft.Core.OperationLog",
				Alias = "",
				CreatedInPackageId = new Guid("b7fb6e74-77cf-499f-8e71-7072f74ac64a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("097b2e1f-2827-4107-9958-89dc67979364"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("b7fb6e74-77cf-499f-8e71-7072f74ac64a")
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
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ad63647f-80ed-400c-82b0-79cd39694ed1"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
		}

		protected override SchemaMethod CreateCheckCanManageLookupsMethod() {
			SchemaMethod method = base.CreateCheckCanManageLookupsMethod();
			method.IsOverride = true;
			return method;
		}

		protected virtual SchemaMethod CreateSetDefaultSysMsgUserSettingsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("cb37a5fc-99cf-4fdf-aef8-462ee862df6f"),
				Name = "SetDefaultSysMsgUserSettings",
				CreatedInSchemaUId = new Guid("ee8032b7-a2c9-41da-bbfd-f2ea07545b2b"),
				CreatedInPackageId = new Guid("b7fb6e74-77cf-499f-8e71-7072f74ac64a"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,209,110,130,64,16,69,159,107,226,63,108,120,194,196,240,3,173,77,90,108,90,19,109,76,168,250,60,44,35,110,187,236,154,221,69,75,141,255,222,69,168,160,72,141,143,204,220,123,230,206,176,27,80,4,133,97,38,11,232,10,19,152,128,128,24,21,25,144,153,70,229,75,33,144,26,38,133,247,138,230,68,225,58,47,77,155,211,35,160,201,133,198,125,183,83,175,146,109,144,233,39,74,101,42,74,170,29,120,33,70,62,117,36,180,1,65,241,57,123,135,4,93,103,81,89,157,222,145,91,39,150,149,65,115,138,231,43,4,131,133,192,61,221,176,119,158,81,103,122,162,227,92,20,160,49,76,196,250,214,168,65,131,80,79,220,228,31,131,183,141,190,150,191,13,233,217,207,33,46,125,201,211,68,204,129,167,168,221,107,250,154,216,117,114,201,40,114,250,229,191,245,166,138,37,160,178,154,230,38,92,113,152,49,11,15,204,5,134,204,32,15,178,228,175,152,195,134,236,176,150,157,242,160,141,178,176,62,145,225,167,221,245,145,208,227,210,83,80,144,232,74,106,111,39,112,75,218,189,110,143,236,186,157,187,29,113,152,94,40,88,207,214,67,166,33,228,152,7,89,2,215,72,246,125,82,40,34,12,211,120,34,35,172,181,202,78,225,241,129,115,223,190,5,213,84,48,253,148,26,57,150,49,19,182,103,84,90,181,82,141,229,198,190,97,13,99,209,157,174,164,192,11,198,57,139,80,86,158,110,103,159,159,253,176,98,227,42,246,22,1,170,13,163,24,24,160,95,31,248,109,222,144,175,237,83,181,101,6,156,253,160,219,126,201,155,254,167,127,134,177,9,207,201,255,243,96,131,246,65,254,2,183,204,94,149,141,4,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwSysAdminUnit_WebitelCollaborations_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ee8032b7-a2c9-41da-bbfd-f2ea07545b2b"));
		}

		#endregion

	}

	#endregion

}

