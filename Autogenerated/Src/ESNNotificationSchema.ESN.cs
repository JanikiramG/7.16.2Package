namespace Terrasoft.Configuration
{

	using Core.Store;
	using DataContract = Terrasoft.Nui.ServiceModel.DataContract;
	using Messaging.Common;
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

	#region Class: ESNNotificationSchema

	/// <exclude/>
	public class ESNNotificationSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ESNNotificationSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ESNNotificationSchema(ESNNotificationSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ESNNotificationSchema(ESNNotificationSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("104d30b1-458a-49b9-8464-aef17d78b411");
			RealUId = new Guid("104d30b1-458a-49b9-8464-aef17d78b411");
			Name = "ESNNotification";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("85692de8-da76-4104-833d-8e3ae998c1d9");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("844c5e36-7fd7-41c7-81dd-574e8b70c45f")) == null) {
				Columns.Add(CreateTypeColumn());
			}
			if (Columns.FindByUId(new Guid("d7674e34-9064-4227-bc8b-79558b834159")) == null) {
				Columns.Add(CreateIsReadColumn());
			}
			if (Columns.FindByUId(new Guid("b94951c9-bac5-42a0-9c71-66c3726225f7")) == null) {
				Columns.Add(CreateOwnerColumn());
			}
			if (Columns.FindByUId(new Guid("e11dab4a-4030-4014-be31-70700c3f11f8")) == null) {
				Columns.Add(CreateSocialMessageColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("104d30b1-458a-49b9-8464-aef17d78b411");
			column.CreatedInPackageId = new Guid("85692de8-da76-4104-833d-8e3ae998c1d9");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("104d30b1-458a-49b9-8464-aef17d78b411");
			column.CreatedInPackageId = new Guid("85692de8-da76-4104-833d-8e3ae998c1d9");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("104d30b1-458a-49b9-8464-aef17d78b411");
			column.CreatedInPackageId = new Guid("85692de8-da76-4104-833d-8e3ae998c1d9");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("104d30b1-458a-49b9-8464-aef17d78b411");
			column.CreatedInPackageId = new Guid("85692de8-da76-4104-833d-8e3ae998c1d9");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("104d30b1-458a-49b9-8464-aef17d78b411");
			column.CreatedInPackageId = new Guid("85692de8-da76-4104-833d-8e3ae998c1d9");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("104d30b1-458a-49b9-8464-aef17d78b411");
			column.CreatedInPackageId = new Guid("85692de8-da76-4104-833d-8e3ae998c1d9");
			return column;
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("844c5e36-7fd7-41c7-81dd-574e8b70c45f"),
				Name = @"Type",
				ReferenceSchemaUId = new Guid("50ccb888-a445-4deb-95d1-452c96fcd984"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("104d30b1-458a-49b9-8464-aef17d78b411"),
				ModifiedInSchemaUId = new Guid("104d30b1-458a-49b9-8464-aef17d78b411"),
				CreatedInPackageId = new Guid("85692de8-da76-4104-833d-8e3ae998c1d9")
			};
		}

		protected virtual EntitySchemaColumn CreateIsReadColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("d7674e34-9064-4227-bc8b-79558b834159"),
				Name = @"IsRead",
				CreatedInSchemaUId = new Guid("104d30b1-458a-49b9-8464-aef17d78b411"),
				ModifiedInSchemaUId = new Guid("104d30b1-458a-49b9-8464-aef17d78b411"),
				CreatedInPackageId = new Guid("85692de8-da76-4104-833d-8e3ae998c1d9"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"False"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateOwnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b94951c9-bac5-42a0-9c71-66c3726225f7"),
				Name = @"Owner",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("104d30b1-458a-49b9-8464-aef17d78b411"),
				ModifiedInSchemaUId = new Guid("104d30b1-458a-49b9-8464-aef17d78b411"),
				CreatedInPackageId = new Guid("85692de8-da76-4104-833d-8e3ae998c1d9")
			};
		}

		protected virtual EntitySchemaColumn CreateSocialMessageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e11dab4a-4030-4014-be31-70700c3f11f8"),
				Name = @"SocialMessage",
				ReferenceSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("104d30b1-458a-49b9-8464-aef17d78b411"),
				ModifiedInSchemaUId = new Guid("104d30b1-458a-49b9-8464-aef17d78b411"),
				CreatedInPackageId = new Guid("fe67a13d-f941-4162-b1b9-3bbef244841b")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateESNNotificationEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateESNNotificationEventsProcessSchema() {
			var schema = new ESNNotificationEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ESNNotification(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ESNNotification_ESNEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ESNNotificationSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ESNNotificationSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("104d30b1-458a-49b9-8464-aef17d78b411"));
		}

		#endregion

	}

	#endregion

	#region Class: ESNNotification

	/// <summary>
	/// Feed notification.
	/// </summary>
	public class ESNNotification : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ESNNotification(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ESNNotification";
		}

		public ESNNotification(ESNNotification source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid TypeId {
			get {
				return GetTypedColumnValue<Guid>("TypeId");
			}
			set {
				SetColumnValue("TypeId", value);
				_type = null;
			}
		}

		/// <exclude/>
		public string TypeAction {
			get {
				return GetTypedColumnValue<string>("TypeAction");
			}
			set {
				SetColumnValue("TypeAction", value);
				if (_type != null) {
					_type.Action = value;
				}
			}
		}

		private ESNNotificationType _type;
		/// <summary>
		/// Type.
		/// </summary>
		public ESNNotificationType Type {
			get {
				return _type ??
					(_type = LookupColumnEntities.GetEntity("Type") as ESNNotificationType);
			}
		}

		/// <summary>
		/// Read.
		/// </summary>
		public bool IsRead {
			get {
				return GetTypedColumnValue<bool>("IsRead");
			}
			set {
				SetColumnValue("IsRead", value);
			}
		}

		/// <exclude/>
		public Guid OwnerId {
			get {
				return GetTypedColumnValue<Guid>("OwnerId");
			}
			set {
				SetColumnValue("OwnerId", value);
				_owner = null;
			}
		}

		/// <exclude/>
		public string OwnerName {
			get {
				return GetTypedColumnValue<string>("OwnerName");
			}
			set {
				SetColumnValue("OwnerName", value);
				if (_owner != null) {
					_owner.Name = value;
				}
			}
		}

		private Contact _owner;
		/// <summary>
		/// Owner.
		/// </summary>
		public Contact Owner {
			get {
				return _owner ??
					(_owner = LookupColumnEntities.GetEntity("Owner") as Contact);
			}
		}

		/// <exclude/>
		public Guid SocialMessageId {
			get {
				return GetTypedColumnValue<Guid>("SocialMessageId");
			}
			set {
				SetColumnValue("SocialMessageId", value);
				_socialMessage = null;
			}
		}

		/// <exclude/>
		public string SocialMessageMessage {
			get {
				return GetTypedColumnValue<string>("SocialMessageMessage");
			}
			set {
				SetColumnValue("SocialMessageMessage", value);
				if (_socialMessage != null) {
					_socialMessage.Message = value;
				}
			}
		}

		private SocialMessage _socialMessage;
		/// <summary>
		/// Message.
		/// </summary>
		public SocialMessage SocialMessage {
			get {
				return _socialMessage ??
					(_socialMessage = LookupColumnEntities.GetEntity("SocialMessage") as SocialMessage);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ESNNotification_ESNEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ESNNotificationDeleted", e);
			Inserting += (s, e) => ThrowEvent("ESNNotificationInserting", e);
			Updated += (s, e) => ThrowEvent("ESNNotificationUpdated", e);
			Validating += (s, e) => ThrowEvent("ESNNotificationValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ESNNotification(this);
		}

		#endregion

	}

	#endregion

	#region Class: ESNNotification_ESNEventsProcess

	/// <exclude/>
	public partial class ESNNotification_ESNEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : ESNNotification
	{

		public ESNNotification_ESNEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ESNNotification_ESNEventsProcess";
			SchemaUId = new Guid("104d30b1-458a-49b9-8464-aef17d78b411");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("104d30b1-458a-49b9-8464-aef17d78b411");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eSNNotificationUpdatedEventSubProcess;
		public ProcessFlowElement ESNNotificationUpdatedEventSubProcess {
			get {
				return _eSNNotificationUpdatedEventSubProcess ?? (_eSNNotificationUpdatedEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ESNNotificationUpdatedEventSubProcess",
					SchemaElementUId = new Guid("c2b010f9-61ab-4ea2-b964-57c415c6bbf2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _eSNNotificationUpdatedStartMessage;
		public ProcessFlowElement ESNNotificationUpdatedStartMessage {
			get {
				return _eSNNotificationUpdatedStartMessage ?? (_eSNNotificationUpdatedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ESNNotificationUpdatedStartMessage",
					SchemaElementUId = new Guid("f1451171-9471-4041-a2ba-7841b823f74d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _eSNNotificationUpdatedScriptTask;
		public ProcessScriptTask ESNNotificationUpdatedScriptTask {
			get {
				return _eSNNotificationUpdatedScriptTask ?? (_eSNNotificationUpdatedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ESNNotificationUpdatedScriptTask",
					SchemaElementUId = new Guid("2d64ce2b-b2ac-40a3-b6b0-89d874594319"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ESNNotificationUpdatedScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[ESNNotificationUpdatedEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ESNNotificationUpdatedEventSubProcess };
			FlowElements[ESNNotificationUpdatedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ESNNotificationUpdatedStartMessage };
			FlowElements[ESNNotificationUpdatedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ESNNotificationUpdatedScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "ESNNotificationUpdatedEventSubProcess":
						break;
					case "ESNNotificationUpdatedStartMessage":
						e.Context.QueueTasks.Enqueue("ESNNotificationUpdatedScriptTask");
						break;
					case "ESNNotificationUpdatedScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ESNNotificationUpdatedStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "ESNNotificationUpdatedEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ESNNotificationUpdatedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ESNNotificationUpdatedStartMessage";
					result = ESNNotificationUpdatedStartMessage.Execute(context);
					break;
				case "ESNNotificationUpdatedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ESNNotificationUpdatedScriptTask";
					result = ESNNotificationUpdatedScriptTask.Execute(context, ESNNotificationUpdatedScriptTaskExecute);
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

		public virtual bool ESNNotificationUpdatedScriptTaskExecute(ProcessExecutingContext context) {
			var changedColumns = Entity.GetChangedColumnValues();
			if (changedColumns.Any(column => column.Name == "IsRead")) {
				PublishClientNotificationInfo("update");
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ESNNotificationUpdated":
							if (ActivatedEventElements.Contains("ESNNotificationUpdatedStartMessage")) {
							context.QueueTasks.Enqueue("ESNNotificationUpdatedStartMessage");
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

	#region Class: ESNNotification_ESNEventsProcess

	/// <exclude/>
	public class ESNNotification_ESNEventsProcess : ESNNotification_ESNEventsProcess<ESNNotification>
	{

		public ESNNotification_ESNEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ESNNotificationEventsProcessSchema

	/// <exclude/>
	public class ESNNotificationEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public ESNNotificationEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ESNNotificationEventsProcessSchema(ESNNotificationEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ESNNotification_ESNEventsProcess";
			UId = new Guid("27ed4124-0a09-4339-bb28-00ff00dd4169");
			CreatedInPackageId = new Guid("85692de8-da76-4104-833d-8e3ae998c1d9");
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
			ProcessSchemaLaneSet schemaLaneSet2_2401daa9465845b5a342a2adb99281f8 = CreateLaneSet2_2401daa9465845b5a342a2adb99281f8LaneSet();
			LaneSets.Add(schemaLaneSet2_2401daa9465845b5a342a2adb99281f8);
			ProcessSchemaLane schemaLane1_a944c741d9b346be893c60f424683d31 = CreateLane1_a944c741d9b346be893c60f424683d31Lane();
			schemaLaneSet2_2401daa9465845b5a342a2adb99281f8.Lanes.Add(schemaLane1_a944c741d9b346be893c60f424683d31);
			ProcessSchemaEventSubProcess esnnotificationupdatedeventsubprocess = CreateESNNotificationUpdatedEventSubProcessEventSubProcess();
			FlowElements.Add(esnnotificationupdatedeventsubprocess);
			ProcessSchemaStartMessageEvent esnnotificationupdatedstartmessage = CreateESNNotificationUpdatedStartMessageStartMessageEvent();
			esnnotificationupdatedeventsubprocess.FlowElements.Add(esnnotificationupdatedstartmessage);
			ProcessSchemaScriptTask esnnotificationupdatedscripttask = CreateESNNotificationUpdatedScriptTaskScriptTask();
			esnnotificationupdatedeventsubprocess.FlowElements.Add(esnnotificationupdatedscripttask);
			FlowElements.Add(CreateSequenceFlow4_71d585c6f74e49a58f816ba20c5ae399SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4_71d585c6f74e49a58f816ba20c5ae399SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4_71d585c6f74e49a58f816ba20c5ae399",
				UId = new Guid("71d585c6-f74e-49a5-8f81-6ba20c5ae399"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea"),
				CreatedInSchemaUId = new Guid("27ed4124-0a09-4339-bb28-00ff00dd4169"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("27ed4124-0a09-4339-bb28-00ff00dd4169"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f1451171-9471-4041-a2ba-7841b823f74d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2d64ce2b-b2ac-40a3-b6b0-89d874594319"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet2_2401daa9465845b5a342a2adb99281f8LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet2_2401daa9465845b5a342a2adb99281f8 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("2401daa9-4658-45b5-a342-a2adb99281f8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea"),
				CreatedInSchemaUId = new Guid("27ed4124-0a09-4339-bb28-00ff00dd4169"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("27ed4124-0a09-4339-bb28-00ff00dd4169"),
				Name = @"LaneSet2_2401daa9465845b5a342a2adb99281f8",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(0, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet2_2401daa9465845b5a342a2adb99281f8;
		}

		protected virtual ProcessSchemaLane CreateLane1_a944c741d9b346be893c60f424683d31Lane() {
			ProcessSchemaLane schemaLane1_a944c741d9b346be893c60f424683d31 = new ProcessSchemaLane(this) {
				UId = new Guid("a944c741-d9b3-46be-893c-60f424683d31"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2401daa9-4658-45b5-a342-a2adb99281f8"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea"),
				CreatedInSchemaUId = new Guid("27ed4124-0a09-4339-bb28-00ff00dd4169"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("27ed4124-0a09-4339-bb28-00ff00dd4169"),
				Name = @"Lane1_a944c741d9b346be893c60f424683d31",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1_a944c741d9b346be893c60f424683d31;
		}

		protected virtual ProcessSchemaEventSubProcess CreateESNNotificationUpdatedEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaESNNotificationUpdatedEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c2b010f9-61ab-4ea2-b964-57c415c6bbf2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a944c741-d9b3-46be-893c-60f424683d31"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea"),
				CreatedInSchemaUId = new Guid("27ed4124-0a09-4339-bb28-00ff00dd4169"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("27ed4124-0a09-4339-bb28-00ff00dd4169"),
				Name = @"ESNNotificationUpdatedEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 20),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(300, 300),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaESNNotificationUpdatedEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateESNNotificationUpdatedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f1451171-9471-4041-a2ba-7841b823f74d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c2b010f9-61ab-4ea2-b964-57c415c6bbf2"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea"),
				CreatedInSchemaUId = new Guid("27ed4124-0a09-4339-bb28-00ff00dd4169"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ESNNotificationUpdated",
				ModifiedInSchemaUId = new Guid("27ed4124-0a09-4339-bb28-00ff00dd4169"),
				Name = @"ESNNotificationUpdatedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(33, 119),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateESNNotificationUpdatedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2d64ce2b-b2ac-40a3-b6b0-89d874594319"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c2b010f9-61ab-4ea2-b964-57c415c6bbf2"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea"),
				CreatedInSchemaUId = new Guid("27ed4124-0a09-4339-bb28-00ff00dd4169"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("27ed4124-0a09-4339-bb28-00ff00dd4169"),
				Name = @"ESNNotificationUpdatedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(191, 105),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,141,177,10,194,48,16,64,103,11,253,135,35,83,186,244,7,74,4,41,34,93,138,56,184,159,237,213,30,164,23,73,46,66,17,255,93,212,69,183,7,143,199,187,99,132,97,70,185,210,216,6,159,23,73,224,96,47,202,186,214,7,210,246,87,157,209,103,74,182,106,202,130,39,176,255,89,189,147,213,14,31,6,183,133,47,213,61,46,4,206,129,233,210,137,112,52,85,5,143,178,216,28,243,197,115,154,91,207,36,218,7,229,137,7,84,14,210,201,20,172,201,183,17,149,204,123,244,44,139,72,154,163,128,198,76,205,11,13,111,202,240,175,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreatePublishClientNotificationInfoMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("85692de8-da76-4104-833d-8e3ae998c1d9")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("85692de8-da76-4104-833d-8e3ae998c1d9")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("85692de8-da76-4104-833d-8e3ae998c1d9")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("85692de8-da76-4104-833d-8e3ae998c1d9")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("85692de8-da76-4104-833d-8e3ae998c1d9")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("85692de8-da76-4104-833d-8e3ae998c1d9")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("85692de8-da76-4104-833d-8e3ae998c1d9")
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
				UId = new Guid("03100e72-52e2-4393-b6a4-ed9fb0b5d8af"),
				Name = "Messaging.Common",
				Alias = "",
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("8409ed9a-7924-4217-a19b-f67737a0cb49"),
				Name = "Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea")
			});
		}

		protected virtual SchemaMethod CreatePublishClientNotificationInfoMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7ee65b26-f66a-412f-a15e-d088d99abc9f"),
				Name = "PublishClientNotificationInfo",
				CreatedInSchemaUId = new Guid("27ed4124-0a09-4339-bb28-00ff00dd4169"),
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("5377e97b-c883-47fe-9c30-1269fe2e7f0e"),
				Name = "operation",
				CreatedInSchemaUId = new Guid("27ed4124-0a09-4339-bb28-00ff00dd4169"),
				ModifiedInSchemaUId = new Guid("27ed4124-0a09-4339-bb28-00ff00dd4169"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,145,221,110,194,48,12,133,175,135,196,59,116,189,64,69,66,125,1,246,35,64,140,117,18,48,81,186,251,208,120,44,91,234,84,137,1,117,211,222,125,78,41,163,189,170,122,242,217,231,216,62,10,27,228,6,73,228,148,200,224,62,152,35,41,170,226,245,9,193,38,114,220,239,29,25,112,149,155,200,66,97,134,138,152,89,25,82,239,42,23,164,12,102,164,180,34,5,46,94,0,165,45,46,145,81,230,192,206,12,34,228,158,28,93,125,134,77,95,229,54,32,228,90,183,140,185,203,182,42,193,139,51,163,15,5,190,9,125,128,187,157,49,250,33,10,147,186,32,188,212,23,224,156,216,3,87,35,156,130,159,126,239,198,66,110,172,108,79,146,200,17,235,166,4,91,231,245,63,216,202,191,176,230,80,50,29,206,211,85,123,174,208,131,133,176,95,147,218,146,137,219,107,218,193,224,191,123,173,245,123,191,151,77,169,162,212,176,236,228,74,59,154,79,57,53,178,226,199,23,103,144,247,115,4,75,113,10,86,9,173,190,97,189,251,228,125,69,205,104,67,31,163,30,167,125,131,179,95,199,43,126,230,28,96,185,15,242,199,15,148,149,82,16,108,128,107,164,194,125,120,217,153,64,198,61,177,116,251,217,135,224,243,232,229,89,139,19,116,36,48,135,6,205,207,175,140,54,69,241,19,247,74,8,138,105,149,241,125,219,145,252,73,26,254,49,126,53,142,154,92,81,39,229,112,252,7,216,140,119,141,112,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ESNNotificationEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("27ed4124-0a09-4339-bb28-00ff00dd4169"));
		}

		#endregion

	}

	#endregion


	#region Class: ESNNotificationEventsProcess

	/// <exclude/>
	public class ESNNotificationEventsProcess : ESNNotification_ESNEventsProcess
	{

		public ESNNotificationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

