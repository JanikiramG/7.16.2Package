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

	#region Class: SocialLikeSchema

	/// <exclude/>
	public class SocialLikeSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SocialLikeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SocialLikeSchema(SocialLikeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SocialLikeSchema(SocialLikeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("93f0b6d7-cabb-47f4-b3eb-20b5b7bf78bb");
			RealUId = new Guid("93f0b6d7-cabb-47f4-b3eb-20b5b7bf78bb");
			Name = "SocialLike";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("ae31dfb0-03d2-4994-8630-244d517283d7")) == null) {
				Columns.Add(CreateUserColumn());
			}
			if (Columns.FindByUId(new Guid("8c66404a-3763-417b-89c6-e7d56aa89cd3")) == null) {
				Columns.Add(CreateSocialMessageColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("93f0b6d7-cabb-47f4-b3eb-20b5b7bf78bb");
			column.CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("93f0b6d7-cabb-47f4-b3eb-20b5b7bf78bb");
			column.CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("93f0b6d7-cabb-47f4-b3eb-20b5b7bf78bb");
			column.CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("93f0b6d7-cabb-47f4-b3eb-20b5b7bf78bb");
			column.CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("93f0b6d7-cabb-47f4-b3eb-20b5b7bf78bb");
			column.CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("93f0b6d7-cabb-47f4-b3eb-20b5b7bf78bb");
			column.CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6");
			return column;
		}

		protected virtual EntitySchemaColumn CreateUserColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ae31dfb0-03d2-4994-8630-244d517283d7"),
				Name = @"User",
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("93f0b6d7-cabb-47f4-b3eb-20b5b7bf78bb"),
				ModifiedInSchemaUId = new Guid("93f0b6d7-cabb-47f4-b3eb-20b5b7bf78bb"),
				CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6")
			};
		}

		protected virtual EntitySchemaColumn CreateSocialMessageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8c66404a-3763-417b-89c6-e7d56aa89cd3"),
				Name = @"SocialMessage",
				ReferenceSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("93f0b6d7-cabb-47f4-b3eb-20b5b7bf78bb"),
				ModifiedInSchemaUId = new Guid("93f0b6d7-cabb-47f4-b3eb-20b5b7bf78bb"),
				CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSocialLikeEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSocialLikeEventsProcessSchema() {
			var schema = new SocialLikeEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SocialLike(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SocialLike_ESNEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SocialLikeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SocialLikeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("93f0b6d7-cabb-47f4-b3eb-20b5b7bf78bb"));
		}

		#endregion

	}

	#endregion

	#region Class: SocialLike

	/// <summary>
	/// Social like.
	/// </summary>
	public class SocialLike : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SocialLike(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SocialLike";
		}

		public SocialLike(SocialLike source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid UserId {
			get {
				return GetTypedColumnValue<Guid>("UserId");
			}
			set {
				SetColumnValue("UserId", value);
				_user = null;
			}
		}

		/// <exclude/>
		public string UserName {
			get {
				return GetTypedColumnValue<string>("UserName");
			}
			set {
				SetColumnValue("UserName", value);
				if (_user != null) {
					_user.Name = value;
				}
			}
		}

		private SysAdminUnit _user;
		/// <summary>
		/// User.
		/// </summary>
		public SysAdminUnit User {
			get {
				return _user ??
					(_user = LookupColumnEntities.GetEntity("User") as SysAdminUnit);
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
			var process = new SocialLike_ESNEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SocialLikeDeleted", e);
			Inserted += (s, e) => ThrowEvent("SocialLikeInserted", e);
			Inserting += (s, e) => ThrowEvent("SocialLikeInserting", e);
			Validating += (s, e) => ThrowEvent("SocialLikeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SocialLike(this);
		}

		#endregion

	}

	#endregion

	#region Class: SocialLike_ESNEventsProcess

	/// <exclude/>
	public partial class SocialLike_ESNEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SocialLike
	{

		public SocialLike_ESNEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SocialLike_ESNEventsProcess";
			SchemaUId = new Guid("93f0b6d7-cabb-47f4-b3eb-20b5b7bf78bb");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("93f0b6d7-cabb-47f4-b3eb-20b5b7bf78bb");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _likeChangedSubProcess;
		public ProcessFlowElement LikeChangedSubProcess {
			get {
				return _likeChangedSubProcess ?? (_likeChangedSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "LikeChangedSubProcess",
					SchemaElementUId = new Guid("48621cac-6f15-4c88-a8df-6b1cb9fb5a90"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _socialLikeInsertedStartMessage;
		public ProcessFlowElement SocialLikeInsertedStartMessage {
			get {
				return _socialLikeInsertedStartMessage ?? (_socialLikeInsertedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SocialLikeInsertedStartMessage",
					SchemaElementUId = new Guid("d467955c-2858-4de2-894f-f9f31543c6d7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _socialLikeDeletedStartMessage;
		public ProcessFlowElement SocialLikeDeletedStartMessage {
			get {
				return _socialLikeDeletedStartMessage ?? (_socialLikeDeletedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SocialLikeDeletedStartMessage",
					SchemaElementUId = new Guid("cc95a603-938c-4a5c-be68-c1d00c730da8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _updateParentLikeCount;
		public ProcessScriptTask UpdateParentLikeCount {
			get {
				return _updateParentLikeCount ?? (_updateParentLikeCount = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "UpdateParentLikeCount",
					SchemaElementUId = new Guid("9d95139d-642f-41fa-b7f5-f4de6f48565e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = UpdateParentLikeCountExecute,
				});
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
					SchemaElementUId = new Guid("03002591-9586-470c-b024-027814138886"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _socialLikeInsertingStartMessage;
		public ProcessFlowElement SocialLikeInsertingStartMessage {
			get {
				return _socialLikeInsertingStartMessage ?? (_socialLikeInsertingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SocialLikeInsertingStartMessage",
					SchemaElementUId = new Guid("e74e8850-b3b9-4ae0-9d50-86f314a86948"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _checkUserLikes;
		public ProcessScriptTask CheckUserLikes {
			get {
				return _checkUserLikes ?? (_checkUserLikes = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CheckUserLikes",
					SchemaElementUId = new Guid("e0ff3dd8-0aa1-4a73-83d5-4b55d5a2025d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CheckUserLikesExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[LikeChangedSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { LikeChangedSubProcess };
			FlowElements[SocialLikeInsertedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SocialLikeInsertedStartMessage };
			FlowElements[SocialLikeDeletedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SocialLikeDeletedStartMessage };
			FlowElements[UpdateParentLikeCount.SchemaElementUId] = new Collection<ProcessFlowElement> { UpdateParentLikeCount };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[SocialLikeInsertingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SocialLikeInsertingStartMessage };
			FlowElements[CheckUserLikes.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckUserLikes };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "LikeChangedSubProcess":
						break;
					case "SocialLikeInsertedStartMessage":
						e.Context.QueueTasks.Enqueue("UpdateParentLikeCount");
						break;
					case "SocialLikeDeletedStartMessage":
						e.Context.QueueTasks.Enqueue("UpdateParentLikeCount");
						break;
					case "UpdateParentLikeCount":
						break;
					case "EventSubProcess1":
						break;
					case "SocialLikeInsertingStartMessage":
						e.Context.QueueTasks.Enqueue("CheckUserLikes");
						break;
					case "CheckUserLikes":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("SocialLikeInsertedStartMessage");
			ActivatedEventElements.Add("SocialLikeDeletedStartMessage");
			ActivatedEventElements.Add("SocialLikeInsertingStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "LikeChangedSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "SocialLikeInsertedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SocialLikeInsertedStartMessage";
					result = SocialLikeInsertedStartMessage.Execute(context);
					break;
				case "SocialLikeDeletedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SocialLikeDeletedStartMessage";
					result = SocialLikeDeletedStartMessage.Execute(context);
					break;
				case "UpdateParentLikeCount":
					context.QueueTasks.Dequeue();
					context.SenderName = "UpdateParentLikeCount";
					result = UpdateParentLikeCount.Execute(context, UpdateParentLikeCountExecute);
					break;
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "SocialLikeInsertingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SocialLikeInsertingStartMessage";
					result = SocialLikeInsertingStartMessage.Execute(context);
					break;
				case "CheckUserLikes":
					context.QueueTasks.Dequeue();
					context.SenderName = "CheckUserLikes";
					result = CheckUserLikes.Execute(context, CheckUserLikesExecute);
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

		public virtual bool UpdateParentLikeCountExecute(ProcessExecutingContext context) {
			var socialMessageId = Entity.GetTypedColumnValue<Guid>("SocialMessageId");
			var select =(Select)new Select(UserConnection)
				.Column(Func.Count(Column.Asterisk()))
				.From("SocialLike")
				.Where("SocialMessageId").IsEqual(Column.Parameter(socialMessageId));
			
			using (var executor = UserConnection.EnsureDBConnection()) {
				var likeCount = select.ExecuteScalar<Int32>(executor);
				DateTime localDate = DateTime.UtcNow;
				var update = (Update)new Update(UserConnection, "SocialMessage")
					.Set("LikeCount", Column.Parameter(likeCount))
					.Set("ModifiedOn", Column.Parameter(localDate))
					.Set("ModifiedById", Column.Parameter(UserConnection.CurrentUser.ContactId))
					.Where("Id").IsEqual(Column.Parameter(socialMessageId));
				update.Execute(executor);
			}
			return true;
		}

		public virtual bool CheckUserLikesExecute(ProcessExecutingContext context) {
			var socialMessageId = Entity.GetTypedColumnValue<Guid>("SocialMessageId");
			var userId = Entity.GetTypedColumnValue<Guid>("UserId");
			var select =(Select)new Select(UserConnection)
				.Column(Func.Count(Column.Asterisk()))
				.From("SocialLike")
				.Where("SocialMessageId").IsEqual(Column.Parameter(socialMessageId))
				.And("UserId").IsEqual(Column.Parameter(userId));
			
			using (var executor = UserConnection.EnsureDBConnection()) {
				var likeCount = select.ExecuteScalar<Int32>(executor);
				if (likeCount != 0) {
					((Terrasoft.Core.Entities.EntityBeforeEventArgs)(context.ThrowEventArgs)).IsCanceled = true;
				}
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "SocialLikeInserted":
							if (ActivatedEventElements.Contains("SocialLikeInsertedStartMessage")) {
							context.QueueTasks.Enqueue("SocialLikeInsertedStartMessage");
						}
						break;
					case "SocialLikeDeleted":
							if (ActivatedEventElements.Contains("SocialLikeDeletedStartMessage")) {
							context.QueueTasks.Enqueue("SocialLikeDeletedStartMessage");
						}
						break;
					case "SocialLikeInserting":
							if (ActivatedEventElements.Contains("SocialLikeInsertingStartMessage")) {
							context.QueueTasks.Enqueue("SocialLikeInsertingStartMessage");
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

	#region Class: SocialLike_ESNEventsProcess

	/// <exclude/>
	public class SocialLike_ESNEventsProcess : SocialLike_ESNEventsProcess<SocialLike>
	{

		public SocialLike_ESNEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SocialLike_ESNEventsProcess

	public partial class SocialLike_ESNEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SocialLikeEventsProcessSchema

	/// <exclude/>
	public class SocialLikeEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SocialLikeEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SocialLikeEventsProcessSchema(SocialLikeEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SocialLike_ESNEventsProcess";
			UId = new Guid("9ff97e44-9b93-489f-b4cc-c04a9122ca0b");
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
			ProcessSchemaEventSubProcess likechangedsubprocess = CreateLikeChangedSubProcessEventSubProcess();
			FlowElements.Add(likechangedsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaStartMessageEvent sociallikeinsertedstartmessage = CreateSocialLikeInsertedStartMessageStartMessageEvent();
			likechangedsubprocess.FlowElements.Add(sociallikeinsertedstartmessage);
			ProcessSchemaStartMessageEvent sociallikedeletedstartmessage = CreateSocialLikeDeletedStartMessageStartMessageEvent();
			likechangedsubprocess.FlowElements.Add(sociallikedeletedstartmessage);
			ProcessSchemaScriptTask updateparentlikecount = CreateUpdateParentLikeCountScriptTask();
			likechangedsubprocess.FlowElements.Add(updateparentlikecount);
			ProcessSchemaStartMessageEvent sociallikeinsertingstartmessage = CreateSocialLikeInsertingStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(sociallikeinsertingstartmessage);
			ProcessSchemaScriptTask checkuserlikes = CreateCheckUserLikesScriptTask();
			eventsubprocess1.FlowElements.Add(checkuserlikes);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("1fc0bcf4-b639-4153-b048-b7bf998a511d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016"),
				CreatedInSchemaUId = new Guid("9ff97e44-9b93-489f-b4cc-c04a9122ca0b"),
				CurveCenterPosition = new Point(208, 84),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("9ff97e44-9b93-489f-b4cc-c04a9122ca0b"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d467955c-2858-4de2-894f-f9f31543c6d7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9d95139d-642f-41fa-b7f5-f4de6f48565e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(329, 93));
			schemaFlow.PolylinePointPositions.Add(new Point(329, 161));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("13bfccc1-add7-4421-9219-4ddd8cf002cb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6"),
				CreatedInSchemaUId = new Guid("9ff97e44-9b93-489f-b4cc-c04a9122ca0b"),
				CurveCenterPosition = new Point(200, 186),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("9ff97e44-9b93-489f-b4cc-c04a9122ca0b"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cc95a603-938c-4a5c-be68-c1d00c730da8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9d95139d-642f-41fa-b7f5-f4de6f48565e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(329, 219));
			schemaFlow.PolylinePointPositions.Add(new Point(329, 161));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("b6d041c3-a574-4db4-8d4b-00eabc639bda"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("f720b9fd-3f82-4899-b23e-1b14c85fa8f9"),
				CreatedInSchemaUId = new Guid("9ff97e44-9b93-489f-b4cc-c04a9122ca0b"),
				CurveCenterPosition = new Point(268, 378),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("9ff97e44-9b93-489f-b4cc-c04a9122ca0b"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e74e8850-b3b9-4ae0-9d50-86f314a86948"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e0ff3dd8-0aa1-4a73-83d5-4b55d5a2025d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("f345efa2-ebc0-42bd-8b2a-2896e904a8f7"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016"),
				CreatedInSchemaUId = new Guid("9ff97e44-9b93-489f-b4cc-c04a9122ca0b"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("9ff97e44-9b93-489f-b4cc-c04a9122ca0b"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1253, 472),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("2183888b-6214-4429-9cfa-9b6417f664e6"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("f345efa2-ebc0-42bd-8b2a-2896e904a8f7"),
				CreatedInOwnerSchemaUId = new Guid("93f0b6d7-cabb-47f4-b3eb-20b5b7bf78bb"),
				CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016"),
				CreatedInSchemaUId = new Guid("9ff97e44-9b93-489f-b4cc-c04a9122ca0b"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("9ff97e44-9b93-489f-b4cc-c04a9122ca0b"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1224, 472),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateLikeChangedSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaLikeChangedSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("48621cac-6f15-4c88-a8df-6b1cb9fb5a90"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2183888b-6214-4429-9cfa-9b6417f664e6"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016"),
				CreatedInSchemaUId = new Guid("9ff97e44-9b93-489f-b4cc-c04a9122ca0b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("9ff97e44-9b93-489f-b4cc-c04a9122ca0b"),
				Name = @"LikeChangedSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(472, 263),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaLikeChangedSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSocialLikeInsertedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d467955c-2858-4de2-894f-f9f31543c6d7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("48621cac-6f15-4c88-a8df-6b1cb9fb5a90"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016"),
				CreatedInSchemaUId = new Guid("9ff97e44-9b93-489f-b4cc-c04a9122ca0b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SocialLikeInserted",
				ModifiedInSchemaUId = new Guid("9ff97e44-9b93-489f-b4cc-c04a9122ca0b"),
				Name = @"SocialLikeInsertedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(57, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSocialLikeDeletedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("cc95a603-938c-4a5c-be68-c1d00c730da8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("48621cac-6f15-4c88-a8df-6b1cb9fb5a90"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016"),
				CreatedInSchemaUId = new Guid("9ff97e44-9b93-489f-b4cc-c04a9122ca0b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SocialLikeDeleted",
				ModifiedInSchemaUId = new Guid("9ff97e44-9b93-489f-b4cc-c04a9122ca0b"),
				Name = @"SocialLikeDeletedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(57, 191),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateUpdateParentLikeCountScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9d95139d-642f-41fa-b7f5-f4de6f48565e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("48621cac-6f15-4c88-a8df-6b1cb9fb5a90"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016"),
				CreatedInSchemaUId = new Guid("9ff97e44-9b93-489f-b4cc-c04a9122ca0b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("9ff97e44-9b93-489f-b4cc-c04a9122ca0b"),
				Name = @"UpdateParentLikeCount",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(308, 119),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,82,203,110,194,48,16,60,39,82,254,193,202,201,145,144,15,237,145,135,84,32,32,36,104,43,1,237,217,74,182,212,194,177,169,31,80,84,245,223,107,59,164,109,104,46,189,141,215,158,217,217,89,31,169,66,90,22,140,242,21,104,77,119,176,40,209,16,229,194,48,115,38,115,48,155,243,1,202,137,228,182,18,79,148,91,24,204,45,43,71,56,93,183,57,105,214,79,226,163,215,2,14,133,65,67,188,14,32,19,112,66,53,196,91,13,106,34,133,112,152,73,145,37,113,68,106,97,60,179,162,112,216,10,131,235,10,185,211,6,20,211,123,156,101,225,225,76,201,170,105,186,100,123,72,67,245,249,21,20,116,120,33,11,157,191,89,202,27,181,71,170,104,5,78,17,95,141,154,121,219,73,108,53,19,59,132,189,127,120,135,194,26,169,92,8,109,191,36,23,218,42,152,142,127,74,206,28,250,112,62,60,143,59,83,97,2,71,172,51,32,121,144,130,117,65,57,85,131,133,48,183,55,35,220,232,251,198,209,148,26,216,176,10,16,151,238,145,63,57,118,83,36,91,83,220,203,83,255,210,192,30,202,250,30,111,3,10,201,214,240,42,217,30,106,39,18,178,138,200,26,12,78,151,141,205,180,135,254,132,243,61,67,246,139,177,146,37,123,97,80,62,136,78,74,99,188,139,50,62,187,101,116,144,174,130,157,88,165,64,24,95,117,159,64,24,90,24,191,153,160,119,217,240,255,151,26,213,121,53,75,104,229,254,153,196,10,140,85,2,25,101,161,255,5,127,85,159,98,3,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("03002591-9586-470c-b024-027814138886"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2183888b-6214-4429-9cfa-9b6417f664e6"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("f720b9fd-3f82-4899-b23e-1b14c85fa8f9"),
				CreatedInSchemaUId = new Guid("9ff97e44-9b93-489f-b4cc-c04a9122ca0b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("9ff97e44-9b93-489f-b4cc-c04a9122ca0b"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(35, 287),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(469, 171),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSocialLikeInsertingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e74e8850-b3b9-4ae0-9d50-86f314a86948"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("03002591-9586-470c-b024-027814138886"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("f720b9fd-3f82-4899-b23e-1b14c85fa8f9"),
				CreatedInSchemaUId = new Guid("9ff97e44-9b93-489f-b4cc-c04a9122ca0b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SocialLikeInserting",
				ModifiedInSchemaUId = new Guid("9ff97e44-9b93-489f-b4cc-c04a9122ca0b"),
				Name = @"SocialLikeInsertingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(57, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCheckUserLikesScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e0ff3dd8-0aa1-4a73-83d5-4b55d5a2025d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("03002591-9586-470c-b024-027814138886"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("f720b9fd-3f82-4899-b23e-1b14c85fa8f9"),
				CreatedInSchemaUId = new Guid("9ff97e44-9b93-489f-b4cc-c04a9122ca0b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("9ff97e44-9b93-489f-b4cc-c04a9122ca0b"),
				Name = @"CheckUserLikes",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(309, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,77,75,3,49,20,60,119,97,255,67,236,41,123,9,162,71,219,194,182,110,75,65,65,104,213,115,200,190,182,161,219,23,125,73,250,129,248,223,77,54,212,165,162,32,228,48,12,111,230,101,38,217,75,98,214,40,45,155,71,176,86,174,97,94,179,33,171,208,105,119,18,51,112,203,211,27,212,19,211,248,29,190,200,198,195,96,230,117,61,226,253,197,165,166,95,220,229,217,62,120,121,11,244,79,139,231,118,244,91,105,161,1,229,216,144,47,90,80,32,28,88,130,60,78,78,12,98,192,218,96,145,103,61,145,252,248,212,163,10,216,163,227,137,17,165,117,64,218,110,121,81,180,131,83,50,187,243,117,31,244,22,250,45,251,186,1,130,95,82,136,185,173,222,189,108,206,110,79,146,228,14,130,35,255,81,82,50,47,177,238,114,252,173,77,165,20,49,105,158,121,171,113,205,120,140,12,71,80,222,25,10,117,93,70,20,21,90,79,112,63,238,168,144,135,125,132,157,81,215,132,28,109,232,32,76,181,137,170,181,130,133,146,141,164,193,28,221,237,205,136,159,253,227,226,158,94,49,222,9,175,134,236,58,25,246,56,95,2,145,180,102,229,66,149,4,162,125,58,13,54,129,211,24,86,129,173,246,128,174,164,181,45,184,50,232,224,232,196,114,67,230,208,241,177,128,137,68,21,46,20,63,128,35,15,113,239,103,158,133,67,224,60,97,34,191,0,118,9,143,11,116,2,0,0 }
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
				CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6")
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
			return new SocialLikeEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9ff97e44-9b93-489f-b4cc-c04a9122ca0b"));
		}

		#endregion

	}

	#endregion


	#region Class: SocialLikeEventsProcess

	/// <exclude/>
	public class SocialLikeEventsProcess : SocialLike_ESNEventsProcess
	{

		public SocialLikeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

