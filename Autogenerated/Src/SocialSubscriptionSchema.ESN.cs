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

	#region Class: SocialSubscriptionSchema

	/// <exclude/>
	public class SocialSubscriptionSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SocialSubscriptionSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SocialSubscriptionSchema(SocialSubscriptionSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SocialSubscriptionSchema(SocialSubscriptionSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7ba1a2a3-2c59-4260-b4a7-6b89cf30803b");
			RealUId = new Guid("7ba1a2a3-2c59-4260-b4a7-6b89cf30803b");
			Name = "SocialSubscription";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("633449ea-c77c-48d9-a9c8-87ebb34469b1")) == null) {
				Columns.Add(CreateSysAdminUnitColumn());
			}
			if (Columns.FindByUId(new Guid("104d73ab-c727-474b-9cf4-af0147a1219d")) == null) {
				Columns.Add(CreateEntitySchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("abc6403d-21f8-4f7b-8170-c4ba56d0a987")) == null) {
				Columns.Add(CreateEntityIdColumn());
			}
			if (Columns.FindByUId(new Guid("affa939d-fce9-440d-9fc6-63f414e72b1b")) == null) {
				Columns.Add(CreateCanUnsubscribeColumn());
			}
			if (Columns.FindByUId(new Guid("db0b24a8-df76-46fc-a1de-45da92921c8a")) == null) {
				Columns.Add(CreateRightsChangedOnColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("7ba1a2a3-2c59-4260-b4a7-6b89cf30803b");
			column.CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("7ba1a2a3-2c59-4260-b4a7-6b89cf30803b");
			column.CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("7ba1a2a3-2c59-4260-b4a7-6b89cf30803b");
			column.CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("7ba1a2a3-2c59-4260-b4a7-6b89cf30803b");
			column.CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("7ba1a2a3-2c59-4260-b4a7-6b89cf30803b");
			column.CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("7ba1a2a3-2c59-4260-b4a7-6b89cf30803b");
			column.CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016");
			return column;
		}

		protected virtual EntitySchemaColumn CreateSysAdminUnitColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("633449ea-c77c-48d9-a9c8-87ebb34469b1"),
				Name = @"SysAdminUnit",
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("7ba1a2a3-2c59-4260-b4a7-6b89cf30803b"),
				ModifiedInSchemaUId = new Guid("7ba1a2a3-2c59-4260-b4a7-6b89cf30803b"),
				CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6")
			};
		}

		protected virtual EntitySchemaColumn CreateEntitySchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("104d73ab-c727-474b-9cf4-af0147a1219d"),
				Name = @"EntitySchemaUId",
				CreatedInSchemaUId = new Guid("7ba1a2a3-2c59-4260-b4a7-6b89cf30803b"),
				ModifiedInSchemaUId = new Guid("7ba1a2a3-2c59-4260-b4a7-6b89cf30803b"),
				CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6")
			};
		}

		protected virtual EntitySchemaColumn CreateEntityIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("abc6403d-21f8-4f7b-8170-c4ba56d0a987"),
				Name = @"EntityId",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("7ba1a2a3-2c59-4260-b4a7-6b89cf30803b"),
				ModifiedInSchemaUId = new Guid("7ba1a2a3-2c59-4260-b4a7-6b89cf30803b"),
				CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6")
			};
		}

		protected virtual EntitySchemaColumn CreateCanUnsubscribeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("affa939d-fce9-440d-9fc6-63f414e72b1b"),
				Name = @"CanUnsubscribe",
				CreatedInSchemaUId = new Guid("7ba1a2a3-2c59-4260-b4a7-6b89cf30803b"),
				ModifiedInSchemaUId = new Guid("7ba1a2a3-2c59-4260-b4a7-6b89cf30803b"),
				CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6")
			};
		}

		protected virtual EntitySchemaColumn CreateRightsChangedOnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("db0b24a8-df76-46fc-a1de-45da92921c8a"),
				Name = @"RightsChangedOn",
				CreatedInSchemaUId = new Guid("7ba1a2a3-2c59-4260-b4a7-6b89cf30803b"),
				ModifiedInSchemaUId = new Guid("7ba1a2a3-2c59-4260-b4a7-6b89cf30803b"),
				CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSocialSubscriptionEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSocialSubscriptionEventsProcessSchema() {
			var schema = new SocialSubscriptionEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SocialSubscription(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SocialSubscription_ESNEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SocialSubscriptionSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SocialSubscriptionSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7ba1a2a3-2c59-4260-b4a7-6b89cf30803b"));
		}

		#endregion

	}

	#endregion

	#region Class: SocialSubscription

	/// <summary>
	/// Follow.
	/// </summary>
	public class SocialSubscription : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SocialSubscription(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SocialSubscription";
		}

		public SocialSubscription(SocialSubscription source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid SysAdminUnitId {
			get {
				return GetTypedColumnValue<Guid>("SysAdminUnitId");
			}
			set {
				SetColumnValue("SysAdminUnitId", value);
				_sysAdminUnit = null;
			}
		}

		/// <exclude/>
		public string SysAdminUnitName {
			get {
				return GetTypedColumnValue<string>("SysAdminUnitName");
			}
			set {
				SetColumnValue("SysAdminUnitName", value);
				if (_sysAdminUnit != null) {
					_sysAdminUnit.Name = value;
				}
			}
		}

		private SysAdminUnit _sysAdminUnit;
		/// <summary>
		/// User/Group.
		/// </summary>
		public SysAdminUnit SysAdminUnit {
			get {
				return _sysAdminUnit ??
					(_sysAdminUnit = LookupColumnEntities.GetEntity("SysAdminUnit") as SysAdminUnit);
			}
		}

		/// <summary>
		/// Schema.
		/// </summary>
		public Guid EntitySchemaUId {
			get {
				return GetTypedColumnValue<Guid>("EntitySchemaUId");
			}
			set {
				SetColumnValue("EntitySchemaUId", value);
			}
		}

		/// <summary>
		/// Object instance.
		/// </summary>
		public Guid EntityId {
			get {
				return GetTypedColumnValue<Guid>("EntityId");
			}
			set {
				SetColumnValue("EntityId", value);
			}
		}

		/// <summary>
		/// Can unfollow.
		/// </summary>
		public bool CanUnsubscribe {
			get {
				return GetTypedColumnValue<bool>("CanUnsubscribe");
			}
			set {
				SetColumnValue("CanUnsubscribe", value);
			}
		}

		/// <summary>
		/// User permissions last updated on.
		/// </summary>
		public DateTime RightsChangedOn {
			get {
				return GetTypedColumnValue<DateTime>("RightsChangedOn");
			}
			set {
				SetColumnValue("RightsChangedOn", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SocialSubscription_ESNEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SocialSubscriptionDeleted", e);
			Deleting += (s, e) => ThrowEvent("SocialSubscriptionDeleting", e);
			Inserting += (s, e) => ThrowEvent("SocialSubscriptionInserting", e);
			Saved += (s, e) => ThrowEvent("SocialSubscriptionSaved", e);
			Validating += (s, e) => ThrowEvent("SocialSubscriptionValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SocialSubscription(this);
		}

		#endregion

	}

	#endregion

	#region Class: SocialSubscription_ESNEventsProcess

	/// <exclude/>
	public partial class SocialSubscription_ESNEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SocialSubscription
	{

		public SocialSubscription_ESNEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SocialSubscription_ESNEventsProcess";
			SchemaUId = new Guid("7ba1a2a3-2c59-4260-b4a7-6b89cf30803b");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7ba1a2a3-2c59-4260-b4a7-6b89cf30803b");
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
					SchemaElementUId = new Guid("697d4079-0935-4a0d-981f-d8c9aa1bf692"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _socialSubscriptionDeleting;
		public ProcessFlowElement SocialSubscriptionDeleting {
			get {
				return _socialSubscriptionDeleting ?? (_socialSubscriptionDeleting = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SocialSubscriptionDeleting",
					SchemaElementUId = new Guid("386e7f1b-d24b-40fe-96b0-1e29cd147983"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _removeSubscription;
		public ProcessScriptTask RemoveSubscription {
			get {
				return _removeSubscription ?? (_removeSubscription = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "RemoveSubscription",
					SchemaElementUId = new Guid("0251fa70-850c-497d-a3a2-a6e36b9c8e2a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = RemoveSubscriptionExecute,
				});
			}
		}

		private ProcessFlowElement _socialSubscriptionSaved;
		public ProcessFlowElement SocialSubscriptionSaved {
			get {
				return _socialSubscriptionSaved ?? (_socialSubscriptionSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SocialSubscriptionSaved",
					SchemaElementUId = new Guid("42fd8612-4082-4d26-86e2-2698cbf0a8c9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _removeUnsubscription;
		public ProcessScriptTask RemoveUnsubscription {
			get {
				return _removeUnsubscription ?? (_removeUnsubscription = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "RemoveUnsubscription",
					SchemaElementUId = new Guid("77c926dd-359a-4b80-a880-874c98b73cbd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = RemoveUnsubscriptionExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[SocialSubscriptionDeleting.SchemaElementUId] = new Collection<ProcessFlowElement> { SocialSubscriptionDeleting };
			FlowElements[RemoveSubscription.SchemaElementUId] = new Collection<ProcessFlowElement> { RemoveSubscription };
			FlowElements[SocialSubscriptionSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { SocialSubscriptionSaved };
			FlowElements[RemoveUnsubscription.SchemaElementUId] = new Collection<ProcessFlowElement> { RemoveUnsubscription };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "SocialSubscriptionDeleting":
						e.Context.QueueTasks.Enqueue("RemoveSubscription");
						break;
					case "RemoveSubscription":
						break;
					case "SocialSubscriptionSaved":
						e.Context.QueueTasks.Enqueue("RemoveUnsubscription");
						break;
					case "RemoveUnsubscription":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("SocialSubscriptionDeleting");
			ActivatedEventElements.Add("SocialSubscriptionSaved");
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
				case "SocialSubscriptionDeleting":
					context.QueueTasks.Dequeue();
					context.SenderName = "SocialSubscriptionDeleting";
					result = SocialSubscriptionDeleting.Execute(context);
					break;
				case "RemoveSubscription":
					context.QueueTasks.Dequeue();
					context.SenderName = "RemoveSubscription";
					result = RemoveSubscription.Execute(context, RemoveSubscriptionExecute);
					break;
				case "SocialSubscriptionSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "SocialSubscriptionSaved";
					result = SocialSubscriptionSaved.Execute(context);
					break;
				case "RemoveUnsubscription":
					context.QueueTasks.Dequeue();
					context.SenderName = "RemoveUnsubscription";
					result = RemoveUnsubscription.Execute(context, RemoveUnsubscriptionExecute);
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

		public virtual bool RemoveSubscriptionExecute(ProcessExecutingContext context) {
			var entityId = Entity.GetTypedColumnValue<Guid>("EntityId");
			var userId = Entity.GetTypedColumnValue<Guid>("SysAdminUnitId");
			
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "SysAdminUnitInRole");
			var sysAdminUnitColumn = esq.AddColumn("SysAdminUnitRoleId");
			var userFilter = esq.CreateFilterWithParameters(FilterComparisonType.Equal, "SysAdminUnit", userId);
			esq.Filters.Add(userFilter); 
			var groups = esq.GetEntityCollection(UserConnection);
			if (groups.Count > 0) {
				var groupIds = new List<object>(groups.Count);
				foreach (var userGroup in groups) {
					var groupId = (object)userGroup.GetColumnValue("SysAdminUnitRoleId");
					groupIds.Add(groupId);
				}
				esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "SocialSubscription");
				var userColumn = esq.AddColumn("SysAdminUnit");
				var channelFilter = esq.CreateFilterWithParameters(FilterComparisonType.Equal, "EntityId", entityId);
				esq.Filters.Add(channelFilter);
				var groupsFilter = esq.CreateFilterWithParameters(FilterComparisonType.Equal, "SysAdminUnit", groupIds);
				esq.Filters.Add(groupsFilter);
				var subscribers = esq.GetEntityCollection(UserConnection);
				if (subscribers.Count > 1) {
					var insert = new Insert(UserConnection).Into("SocialUnsubscription")
						.Set("SysAdminUnitId", Column.Parameter(userId))
						.Set("EntityId", Column.Parameter(entityId));
					insert.Execute();
				}
			}
			
			return true;
		}

		public virtual bool RemoveUnsubscriptionExecute(ProcessExecutingContext context) {
			var entityId = Entity.GetTypedColumnValue<Guid>("EntityId");
			var userId = Entity.GetTypedColumnValue<Guid>("SysAdminUnitId");
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "SocialUnsubscription") {
				UseAdminRights = false
			};
			esq.AddAllSchemaColumns();
			var userFilter = esq.CreateFilterWithParameters(FilterComparisonType.Equal, "SysAdminUnit", userId);
			esq.Filters.Add(userFilter); 
			var channelFilter = esq.CreateFilterWithParameters(FilterComparisonType.Equal, "EntityId", entityId);
			esq.Filters.Add(channelFilter);
			var records = esq.GetEntityCollection(UserConnection);
			if (records.Count > 0) {
				var record = records[0];
				record.UseAdminRights = GlobalAppSettings.FeatureUseAdminRightsInEmbeddedLogic;
				record.Delete();
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "SocialSubscriptionDeleting":
							if (ActivatedEventElements.Contains("SocialSubscriptionDeleting")) {
							context.QueueTasks.Enqueue("SocialSubscriptionDeleting");
						}
						break;
					case "SocialSubscriptionSaved":
							if (ActivatedEventElements.Contains("SocialSubscriptionSaved")) {
							context.QueueTasks.Enqueue("SocialSubscriptionSaved");
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

	#region Class: SocialSubscription_ESNEventsProcess

	/// <exclude/>
	public class SocialSubscription_ESNEventsProcess : SocialSubscription_ESNEventsProcess<SocialSubscription>
	{

		public SocialSubscription_ESNEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SocialSubscription_ESNEventsProcess

	public partial class SocialSubscription_ESNEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SocialSubscriptionEventsProcessSchema

	/// <exclude/>
	public class SocialSubscriptionEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SocialSubscriptionEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SocialSubscriptionEventsProcessSchema(SocialSubscriptionEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SocialSubscription_ESNEventsProcess";
			UId = new Guid("15c6b686-4a6b-4647-9a31-f763bbdbcdf4");
			CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6");
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
			ProcessSchemaStartMessageEvent socialsubscriptiondeleting = CreateSocialSubscriptionDeletingStartMessageEvent();
			eventsubprocess1.FlowElements.Add(socialsubscriptiondeleting);
			ProcessSchemaScriptTask removesubscription = CreateRemoveSubscriptionScriptTask();
			eventsubprocess1.FlowElements.Add(removesubscription);
			ProcessSchemaStartMessageEvent socialsubscriptionsaved = CreateSocialSubscriptionSavedStartMessageEvent();
			eventsubprocess1.FlowElements.Add(socialsubscriptionsaved);
			ProcessSchemaScriptTask removeunsubscription = CreateRemoveUnsubscriptionScriptTask();
			eventsubprocess1.FlowElements.Add(removeunsubscription);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("8749a73d-6a62-4a0f-95ec-87372b61f5f3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016"),
				CreatedInSchemaUId = new Guid("15c6b686-4a6b-4647-9a31-f763bbdbcdf4"),
				CurveCenterPosition = new Point(178, 138),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("15c6b686-4a6b-4647-9a31-f763bbdbcdf4"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("386e7f1b-d24b-40fe-96b0-1e29cd147983"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0251fa70-850c-497d-a3a2-a6e36b9c8e2a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("d37d1335-ebf7-4ee5-8832-c4d5117b45a9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016"),
				CreatedInSchemaUId = new Guid("15c6b686-4a6b-4647-9a31-f763bbdbcdf4"),
				CurveCenterPosition = new Point(182, 240),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("15c6b686-4a6b-4647-9a31-f763bbdbcdf4"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("42fd8612-4082-4d26-86e2-2698cbf0a8c9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("77c926dd-359a-4b80-a880-874c98b73cbd"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("42fa04f8-ade5-4f63-b1ab-c1984fdefb31"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016"),
				CreatedInSchemaUId = new Guid("15c6b686-4a6b-4647-9a31-f763bbdbcdf4"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("15c6b686-4a6b-4647-9a31-f763bbdbcdf4"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(758, 408),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("ab68e590-6210-4bf5-97ed-2f8f8edf4c51"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("42fa04f8-ade5-4f63-b1ab-c1984fdefb31"),
				CreatedInOwnerSchemaUId = new Guid("7ba1a2a3-2c59-4260-b4a7-6b89cf30803b"),
				CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016"),
				CreatedInSchemaUId = new Guid("15c6b686-4a6b-4647-9a31-f763bbdbcdf4"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("15c6b686-4a6b-4647-9a31-f763bbdbcdf4"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(729, 408),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("697d4079-0935-4a0d-981f-d8c9aa1bf692"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab68e590-6210-4bf5-97ed-2f8f8edf4c51"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016"),
				CreatedInSchemaUId = new Guid("15c6b686-4a6b-4647-9a31-f763bbdbcdf4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("15c6b686-4a6b-4647-9a31-f763bbdbcdf4"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(28, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(455, 385),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSocialSubscriptionDeletingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("386e7f1b-d24b-40fe-96b0-1e29cd147983"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("697d4079-0935-4a0d-981f-d8c9aa1bf692"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016"),
				CreatedInSchemaUId = new Guid("15c6b686-4a6b-4647-9a31-f763bbdbcdf4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SocialSubscriptionDeleting",
				ModifiedInSchemaUId = new Guid("15c6b686-4a6b-4647-9a31-f763bbdbcdf4"),
				Name = @"SocialSubscriptionDeleting",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(28, 105),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateRemoveSubscriptionScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0251fa70-850c-497d-a3a2-a6e36b9c8e2a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("697d4079-0935-4a0d-981f-d8c9aa1bf692"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016"),
				CreatedInSchemaUId = new Guid("15c6b686-4a6b-4647-9a31-f763bbdbcdf4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("15c6b686-4a6b-4647-9a31-f763bbdbcdf4"),
				Name = @"RemoveSubscription",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(232, 91),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,84,93,107,219,48,20,125,118,161,255,65,228,73,129,32,214,231,116,129,98,210,16,104,161,91,150,237,89,177,111,27,13,91,74,245,209,45,140,254,247,73,190,178,42,187,45,180,108,125,48,88,246,61,231,30,157,123,164,7,174,9,72,43,236,113,93,147,207,100,217,189,178,21,216,111,199,3,212,165,106,92,43,191,243,198,193,249,202,137,122,65,39,203,88,60,153,206,79,79,30,60,218,25,208,111,196,110,142,230,162,110,133,220,74,97,35,3,114,128,185,247,4,18,126,69,146,77,181,135,150,127,113,160,143,116,235,249,75,37,37,84,86,40,201,242,130,107,46,249,29,232,25,25,50,203,175,170,129,164,207,100,191,80,147,111,229,27,178,139,58,106,28,10,11,224,209,246,46,69,99,65,71,88,169,129,91,192,79,63,132,221,223,112,205,91,240,11,67,241,99,169,218,3,215,194,40,25,124,96,203,123,199,155,145,196,201,44,218,22,186,4,82,68,154,160,137,62,117,156,206,9,138,184,211,202,29,76,20,224,13,70,19,188,250,6,93,25,153,20,88,197,45,161,8,99,165,114,210,146,5,249,52,37,127,78,79,138,68,184,174,77,116,253,74,24,123,174,118,63,61,124,49,64,5,166,226,86,249,45,87,123,66,123,63,86,161,130,8,25,117,33,109,206,235,105,41,210,77,83,125,208,157,101,226,85,211,139,162,23,215,185,17,23,221,159,71,255,252,123,84,84,37,120,179,113,59,83,105,113,8,133,216,182,223,220,91,50,242,132,168,246,220,247,107,254,75,66,210,209,154,165,35,217,245,25,7,100,208,51,41,193,89,124,68,84,251,121,188,40,38,111,155,180,24,116,119,231,139,222,21,218,34,164,54,3,167,232,158,101,25,19,210,227,108,12,193,186,91,140,169,216,90,90,69,227,168,183,210,12,134,29,120,10,182,1,251,236,66,154,17,28,54,75,70,209,120,76,115,80,54,166,103,229,105,110,152,100,148,202,150,191,161,114,22,104,31,226,199,112,239,105,176,78,75,98,181,131,249,95,180,208,162,87,134,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSocialSubscriptionSavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("42fd8612-4082-4d26-86e2-2698cbf0a8c9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("697d4079-0935-4a0d-981f-d8c9aa1bf692"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016"),
				CreatedInSchemaUId = new Guid("15c6b686-4a6b-4647-9a31-f763bbdbcdf4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SocialSubscriptionSaved",
				ModifiedInSchemaUId = new Guid("15c6b686-4a6b-4647-9a31-f763bbdbcdf4"),
				Name = @"SocialSubscriptionSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 212),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateRemoveUnsubscriptionScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("77c926dd-359a-4b80-a880-874c98b73cbd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("697d4079-0935-4a0d-981f-d8c9aa1bf692"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016"),
				CreatedInSchemaUId = new Guid("15c6b686-4a6b-4647-9a31-f763bbdbcdf4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("15c6b686-4a6b-4647-9a31-f763bbdbcdf4"),
				Name = @"RemoveUnsubscription",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(232, 198),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,81,77,75,195,48,24,62,175,208,255,16,122,106,97,148,221,167,131,81,183,49,80,80,235,244,32,30,178,230,221,26,72,147,46,31,147,34,251,239,190,93,234,214,169,7,15,222,146,240,124,229,121,246,84,19,144,150,219,102,201,200,53,153,29,143,233,2,236,83,83,3,203,148,112,149,124,166,194,193,213,194,113,54,137,163,89,7,142,146,113,24,236,145,237,12,232,63,114,243,198,76,89,197,229,74,114,219,83,0,179,67,186,132,247,78,34,47,74,168,232,131,3,221,196,43,84,207,148,148,80,88,174,100,218,7,220,81,73,183,160,135,36,202,85,193,169,88,73,227,214,166,208,188,110,161,81,66,62,194,96,128,252,163,229,35,223,150,214,160,205,134,10,3,97,112,64,111,244,77,167,140,77,133,240,130,62,177,137,251,63,155,115,97,65,35,175,5,103,26,168,5,255,244,194,109,121,79,53,173,0,47,38,246,143,153,170,106,170,185,81,178,173,32,157,237,28,21,109,190,222,191,163,97,215,88,210,37,240,76,211,38,137,207,142,201,152,248,16,69,73,241,247,226,95,114,156,182,27,158,54,255,45,197,133,229,87,25,26,10,165,153,233,18,224,200,94,12,59,19,126,155,111,83,181,60,190,33,113,199,75,51,229,164,37,19,50,242,187,156,37,81,177,195,188,142,222,144,52,240,183,244,199,114,11,161,214,84,76,235,58,7,107,185,220,154,116,142,53,56,13,151,200,165,156,85,107,96,12,216,173,218,242,162,167,120,3,2,75,58,206,123,8,3,13,200,149,196,106,7,227,79,226,182,246,250,6,3,0,0 }
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
				CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016")
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
			return new SocialSubscriptionEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("15c6b686-4a6b-4647-9a31-f763bbdbcdf4"));
		}

		#endregion

	}

	#endregion


	#region Class: SocialSubscriptionEventsProcess

	/// <exclude/>
	public class SocialSubscriptionEventsProcess : SocialSubscription_ESNEventsProcess
	{

		public SocialSubscriptionEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

