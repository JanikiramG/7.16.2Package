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
	using System.Security;
	using System.Text.RegularExpressions;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration;
	using Terrasoft.Configuration.RightsService;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.Messaging.Common;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: SocialMessageSchema

	/// <exclude/>
	public class SocialMessageSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SocialMessageSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SocialMessageSchema(SocialMessageSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SocialMessageSchema(SocialMessageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b");
			RealUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b");
			Name = "SocialMessage";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateMessageColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeHierarchyColumn() {
			base.InitializeHierarchyColumn();
			HierarchyColumn = CreateParentColumn();
			if (Columns.FindByUId(HierarchyColumn.UId) == null) {
				Columns.Add(HierarchyColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("a7a910aa-80d0-4e1a-95cc-79d9f2d291f9")) == null) {
				Columns.Add(CreateEntitySchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("b076a792-429d-47db-891d-6621341a0bde")) == null) {
				Columns.Add(CreateEntityIdColumn());
			}
			if (Columns.FindByUId(new Guid("bee7652b-3271-4ef4-ae9b-2d52545b33d5")) == null) {
				Columns.Add(CreateLikeCountColumn());
			}
			if (Columns.FindByUId(new Guid("f7957826-183c-4351-9c96-9e68ac436451")) == null) {
				Columns.Add(CreateCommentCountColumn());
			}
			if (Columns.FindByUId(new Guid("8f678ac8-8a72-46e0-929f-bde1a8411997")) == null) {
				Columns.Add(CreateLastActionOnColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b");
			column.CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.IsIndexed = true;
			column.ModifiedInSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b");
			column.CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b");
			column.CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b");
			column.CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b");
			column.CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b");
			column.CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6");
			return column;
		}

		protected virtual EntitySchemaColumn CreateEntitySchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("a7a910aa-80d0-4e1a-95cc-79d9f2d291f9"),
				Name = @"EntitySchemaUId",
				CreatedInSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"),
				ModifiedInSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"),
				CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6")
			};
		}

		protected virtual EntitySchemaColumn CreateEntityIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("b076a792-429d-47db-891d-6621341a0bde"),
				Name = @"EntityId",
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"),
				ModifiedInSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"),
				CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6")
			};
		}

		protected virtual EntitySchemaColumn CreateMessageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("fb47c81f-a125-488b-b2fb-05415b8da84c"),
				Name = @"Message",
				CreatedInSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"),
				ModifiedInSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"),
				CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateParentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("de240686-3bf2-4759-b6fc-8e859b0b25cc"),
				Name = @"Parent",
				ReferenceSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"),
				ModifiedInSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"),
				CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6")
			};
		}

		protected virtual EntitySchemaColumn CreateLikeCountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("bee7652b-3271-4ef4-ae9b-2d52545b33d5"),
				Name = @"LikeCount",
				CreatedInSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"),
				ModifiedInSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"),
				CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"0"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateCommentCountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("f7957826-183c-4351-9c96-9e68ac436451"),
				Name = @"CommentCount",
				CreatedInSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"),
				ModifiedInSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"),
				CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"0"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateLastActionOnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("8f678ac8-8a72-46e0-929f-bde1a8411997"),
				Name = @"LastActionOn",
				CreatedInSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"),
				ModifiedInSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"),
				CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentDateTime")
				}
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSocialMessageEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSocialMessageEventsProcessSchema() {
			var schema = new SocialMessageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SocialMessage(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SocialMessage_ESNEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SocialMessageSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SocialMessageSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"));
		}

		#endregion

	}

	#endregion

	#region Class: SocialMessage

	/// <summary>
	/// Message/comment.
	/// </summary>
	public class SocialMessage : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SocialMessage(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SocialMessage";
		}

		public SocialMessage(SocialMessage source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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
		/// Message/comment.
		/// </summary>
		public string Message {
			get {
				return GetTypedColumnValue<string>("Message");
			}
			set {
				SetColumnValue("Message", value);
			}
		}

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
		public string ParentMessage {
			get {
				return GetTypedColumnValue<string>("ParentMessage");
			}
			set {
				SetColumnValue("ParentMessage", value);
				if (_parent != null) {
					_parent.Message = value;
				}
			}
		}

		private SocialMessage _parent;
		/// <summary>
		/// Parent message.
		/// </summary>
		public SocialMessage Parent {
			get {
				return _parent ??
					(_parent = LookupColumnEntities.GetEntity("Parent") as SocialMessage);
			}
		}

		/// <summary>
		/// Number of likes.
		/// </summary>
		public int LikeCount {
			get {
				return GetTypedColumnValue<int>("LikeCount");
			}
			set {
				SetColumnValue("LikeCount", value);
			}
		}

		/// <summary>
		/// Number of comments.
		/// </summary>
		public int CommentCount {
			get {
				return GetTypedColumnValue<int>("CommentCount");
			}
			set {
				SetColumnValue("CommentCount", value);
			}
		}

		/// <summary>
		/// Last action.
		/// </summary>
		public DateTime LastActionOn {
			get {
				return GetTypedColumnValue<DateTime>("LastActionOn");
			}
			set {
				SetColumnValue("LastActionOn", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SocialMessage_ESNEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SocialMessageDeleted", e);
			Deleting += (s, e) => ThrowEvent("SocialMessageDeleting", e);
			Inserted += (s, e) => ThrowEvent("SocialMessageInserted", e);
			Inserting += (s, e) => ThrowEvent("SocialMessageInserting", e);
			Saved += (s, e) => ThrowEvent("SocialMessageSaved", e);
			Updated += (s, e) => ThrowEvent("SocialMessageUpdated", e);
			Updating += (s, e) => ThrowEvent("SocialMessageUpdating", e);
			Validating += (s, e) => ThrowEvent("SocialMessageValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SocialMessage(this);
		}

		#endregion

	}

	#endregion

	#region Class: SocialMessage_ESNEventsProcess

	/// <exclude/>
	public partial class SocialMessage_ESNEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SocialMessage
	{

		public SocialMessage_ESNEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SocialMessage_ESNEventsProcess";
			SchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _socialMessageCahngeSubProcess;
		public ProcessFlowElement SocialMessageCahngeSubProcess {
			get {
				return _socialMessageCahngeSubProcess ?? (_socialMessageCahngeSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SocialMessageCahngeSubProcess",
					SchemaElementUId = new Guid("ab847359-b95e-4aa0-afaf-0ae9ad8943b3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _socialMessageInsertedStartMessage;
		public ProcessFlowElement SocialMessageInsertedStartMessage {
			get {
				return _socialMessageInsertedStartMessage ?? (_socialMessageInsertedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SocialMessageInsertedStartMessage",
					SchemaElementUId = new Guid("2271869d-efb9-445c-b054-c0fc0aed56b0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _socialMessageDeletedStartMessage;
		public ProcessFlowElement SocialMessageDeletedStartMessage {
			get {
				return _socialMessageDeletedStartMessage ?? (_socialMessageDeletedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SocialMessageDeletedStartMessage",
					SchemaElementUId = new Guid("5262f53d-a9d8-432f-b36e-9ae9c7f85cd6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _updateParentCommentCount;
		public ProcessScriptTask UpdateParentCommentCount {
			get {
				return _updateParentCommentCount ?? (_updateParentCommentCount = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "UpdateParentCommentCount",
					SchemaElementUId = new Guid("1ee35785-a433-4e93-9211-3e1049fc1a84"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = UpdateParentCommentCountExecute,
				});
			}
		}

		private ProcessFlowElement _socialMessageUpdating;
		public ProcessFlowElement SocialMessageUpdating {
			get {
				return _socialMessageUpdating ?? (_socialMessageUpdating = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SocialMessageUpdating",
					SchemaElementUId = new Guid("a6e1fc59-4314-4bbc-8d03-6c2fb5aff1bc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _updateParentLastActionOn;
		public ProcessScriptTask UpdateParentLastActionOn {
			get {
				return _updateParentLastActionOn ?? (_updateParentLastActionOn = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "UpdateParentLastActionOn",
					SchemaElementUId = new Guid("4cf3bd6a-337a-4f70-b7a7-ce0d06c6c9b8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = UpdateParentLastActionOnExecute,
				});
			}
		}

		private ProcessScriptTask _sendSocialMessage;
		public ProcessScriptTask SendSocialMessage {
			get {
				return _sendSocialMessage ?? (_sendSocialMessage = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SendSocialMessage",
					SchemaElementUId = new Guid("8162e0b0-c9b6-4a60-8b0c-8992a1480435"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SendSocialMessageExecute,
				});
			}
		}

		private ProcessScriptTask _subscribeUser;
		public ProcessScriptTask SubscribeUser {
			get {
				return _subscribeUser ?? (_subscribeUser = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SubscribeUser",
					SchemaElementUId = new Guid("83d25c93-9688-4bb8-bce9-9c89186c69bf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SubscribeUserExecute,
				});
			}
		}

		private ProcessScriptTask _sendUpdateMessage;
		public ProcessScriptTask SendUpdateMessage {
			get {
				return _sendUpdateMessage ?? (_sendUpdateMessage = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SendUpdateMessage",
					SchemaElementUId = new Guid("2cbc96bf-9efc-4335-8572-6b8c9087b2b4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SendUpdateMessageExecute,
				});
			}
		}

		private ProcessFlowElement _socialMessageUpdated;
		public ProcessFlowElement SocialMessageUpdated {
			get {
				return _socialMessageUpdated ?? (_socialMessageUpdated = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SocialMessageUpdated",
					SchemaElementUId = new Guid("1dd10180-c2b1-49c8-ace9-4d4c445ac45d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _sendDeleteSocialMessage;
		public ProcessScriptTask SendDeleteSocialMessage {
			get {
				return _sendDeleteSocialMessage ?? (_sendDeleteSocialMessage = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SendDeleteSocialMessage",
					SchemaElementUId = new Guid("d3d46d69-9bf0-4afe-934a-be0ec174426e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SendDeleteSocialMessageExecute,
				});
			}
		}

		private ProcessFlowElement _socialMessageDeleting;
		public ProcessFlowElement SocialMessageDeleting {
			get {
				return _socialMessageDeleting ?? (_socialMessageDeleting = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SocialMessageDeleting",
					SchemaElementUId = new Guid("cd83857b-fd76-4bfa-b9d9-3c77d8c576bc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _checkInsertRightsScriptTask;
		public ProcessScriptTask CheckInsertRightsScriptTask {
			get {
				return _checkInsertRightsScriptTask ?? (_checkInsertRightsScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CheckInsertRightsScriptTask",
					SchemaElementUId = new Guid("a5a05e18-c40a-4544-8cf5-040e66935e32"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CheckInsertRightsScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _socialMessageInserting;
		public ProcessFlowElement SocialMessageInserting {
			get {
				return _socialMessageInserting ?? (_socialMessageInserting = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SocialMessageInserting",
					SchemaElementUId = new Guid("7f9ab86b-e8d8-405e-9adf-b2320d788a6d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _deleteLinkPreviewInfoScriptTask;
		public ProcessScriptTask DeleteLinkPreviewInfoScriptTask {
			get {
				return _deleteLinkPreviewInfoScriptTask ?? (_deleteLinkPreviewInfoScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DeleteLinkPreviewInfoScriptTask",
					SchemaElementUId = new Guid("7dd0f3b8-8281-40ef-9cbd-61513be24f03"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DeleteLinkPreviewInfoScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _addLinkPreviewInfoScriptTask;
		public ProcessScriptTask AddLinkPreviewInfoScriptTask {
			get {
				return _addLinkPreviewInfoScriptTask ?? (_addLinkPreviewInfoScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "AddLinkPreviewInfoScriptTask",
					SchemaElementUId = new Guid("4c8627ed-2007-4e3f-b713-a5eb66417e13"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = AddLinkPreviewInfoScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _socialMessageSavedStartMessage;
		public ProcessFlowElement SocialMessageSavedStartMessage {
			get {
				return _socialMessageSavedStartMessage ?? (_socialMessageSavedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SocialMessageSavedStartMessage",
					SchemaElementUId = new Guid("716269d4-dc7e-4211-a19b-41b3e4c4f9af"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _deleteLinkPreviewInfoIfUpdatedScriptTask;
		public ProcessScriptTask DeleteLinkPreviewInfoIfUpdatedScriptTask {
			get {
				return _deleteLinkPreviewInfoIfUpdatedScriptTask ?? (_deleteLinkPreviewInfoIfUpdatedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DeleteLinkPreviewInfoIfUpdatedScriptTask",
					SchemaElementUId = new Guid("3c6ac282-094d-4c64-a738-0da1926afd18"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DeleteLinkPreviewInfoIfUpdatedScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[SocialMessageCahngeSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { SocialMessageCahngeSubProcess };
			FlowElements[SocialMessageInsertedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SocialMessageInsertedStartMessage };
			FlowElements[SocialMessageDeletedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SocialMessageDeletedStartMessage };
			FlowElements[UpdateParentCommentCount.SchemaElementUId] = new Collection<ProcessFlowElement> { UpdateParentCommentCount };
			FlowElements[SocialMessageUpdating.SchemaElementUId] = new Collection<ProcessFlowElement> { SocialMessageUpdating };
			FlowElements[UpdateParentLastActionOn.SchemaElementUId] = new Collection<ProcessFlowElement> { UpdateParentLastActionOn };
			FlowElements[SendSocialMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SendSocialMessage };
			FlowElements[SubscribeUser.SchemaElementUId] = new Collection<ProcessFlowElement> { SubscribeUser };
			FlowElements[SendUpdateMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SendUpdateMessage };
			FlowElements[SocialMessageUpdated.SchemaElementUId] = new Collection<ProcessFlowElement> { SocialMessageUpdated };
			FlowElements[SendDeleteSocialMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SendDeleteSocialMessage };
			FlowElements[SocialMessageDeleting.SchemaElementUId] = new Collection<ProcessFlowElement> { SocialMessageDeleting };
			FlowElements[CheckInsertRightsScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckInsertRightsScriptTask };
			FlowElements[SocialMessageInserting.SchemaElementUId] = new Collection<ProcessFlowElement> { SocialMessageInserting };
			FlowElements[DeleteLinkPreviewInfoScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteLinkPreviewInfoScriptTask };
			FlowElements[AddLinkPreviewInfoScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AddLinkPreviewInfoScriptTask };
			FlowElements[SocialMessageSavedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SocialMessageSavedStartMessage };
			FlowElements[DeleteLinkPreviewInfoIfUpdatedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteLinkPreviewInfoIfUpdatedScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SocialMessageCahngeSubProcess":
						break;
					case "SocialMessageInsertedStartMessage":
						e.Context.QueueTasks.Enqueue("UpdateParentCommentCount");
						e.Context.QueueTasks.Enqueue("UpdateParentLastActionOn");
						e.Context.QueueTasks.Enqueue("SendSocialMessage");
						e.Context.QueueTasks.Enqueue("SubscribeUser");
						break;
					case "SocialMessageDeletedStartMessage":
						e.Context.QueueTasks.Enqueue("DeleteLinkPreviewInfoScriptTask");
						break;
					case "UpdateParentCommentCount":
						break;
					case "SocialMessageUpdating":
						e.Context.QueueTasks.Enqueue("UpdateParentLastActionOn");
						break;
					case "UpdateParentLastActionOn":
						break;
					case "SendSocialMessage":
						break;
					case "SubscribeUser":
						break;
					case "SendUpdateMessage":
						e.Context.QueueTasks.Enqueue("DeleteLinkPreviewInfoIfUpdatedScriptTask");
						break;
					case "SocialMessageUpdated":
						e.Context.QueueTasks.Enqueue("SendUpdateMessage");
						break;
					case "SendDeleteSocialMessage":
						break;
					case "SocialMessageDeleting":
						e.Context.QueueTasks.Enqueue("SendDeleteSocialMessage");
						break;
					case "CheckInsertRightsScriptTask":
						break;
					case "SocialMessageInserting":
						e.Context.QueueTasks.Enqueue("CheckInsertRightsScriptTask");
						break;
					case "DeleteLinkPreviewInfoScriptTask":
						e.Context.QueueTasks.Enqueue("UpdateParentCommentCount");
						break;
					case "AddLinkPreviewInfoScriptTask":
						break;
					case "SocialMessageSavedStartMessage":
						e.Context.QueueTasks.Enqueue("AddLinkPreviewInfoScriptTask");
						break;
					case "DeleteLinkPreviewInfoIfUpdatedScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("SocialMessageInsertedStartMessage");
			ActivatedEventElements.Add("SocialMessageDeletedStartMessage");
			ActivatedEventElements.Add("SocialMessageUpdating");
			ActivatedEventElements.Add("SocialMessageUpdated");
			ActivatedEventElements.Add("SocialMessageDeleting");
			ActivatedEventElements.Add("SocialMessageInserting");
			ActivatedEventElements.Add("SocialMessageSavedStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SocialMessageCahngeSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "SocialMessageInsertedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SocialMessageInsertedStartMessage";
					result = SocialMessageInsertedStartMessage.Execute(context);
					break;
				case "SocialMessageDeletedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SocialMessageDeletedStartMessage";
					result = SocialMessageDeletedStartMessage.Execute(context);
					break;
				case "UpdateParentCommentCount":
					context.QueueTasks.Dequeue();
					context.SenderName = "UpdateParentCommentCount";
					result = UpdateParentCommentCount.Execute(context, UpdateParentCommentCountExecute);
					break;
				case "SocialMessageUpdating":
					context.QueueTasks.Dequeue();
					context.SenderName = "SocialMessageUpdating";
					result = SocialMessageUpdating.Execute(context);
					break;
				case "UpdateParentLastActionOn":
					context.QueueTasks.Dequeue();
					context.SenderName = "UpdateParentLastActionOn";
					result = UpdateParentLastActionOn.Execute(context, UpdateParentLastActionOnExecute);
					break;
				case "SendSocialMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SendSocialMessage";
					result = SendSocialMessage.Execute(context, SendSocialMessageExecute);
					break;
				case "SubscribeUser":
					context.QueueTasks.Dequeue();
					context.SenderName = "SubscribeUser";
					result = SubscribeUser.Execute(context, SubscribeUserExecute);
					break;
				case "SendUpdateMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SendUpdateMessage";
					result = SendUpdateMessage.Execute(context, SendUpdateMessageExecute);
					break;
				case "SocialMessageUpdated":
					context.QueueTasks.Dequeue();
					context.SenderName = "SocialMessageUpdated";
					result = SocialMessageUpdated.Execute(context);
					break;
				case "SendDeleteSocialMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SendDeleteSocialMessage";
					result = SendDeleteSocialMessage.Execute(context, SendDeleteSocialMessageExecute);
					break;
				case "SocialMessageDeleting":
					context.QueueTasks.Dequeue();
					context.SenderName = "SocialMessageDeleting";
					result = SocialMessageDeleting.Execute(context);
					break;
				case "CheckInsertRightsScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CheckInsertRightsScriptTask";
					result = CheckInsertRightsScriptTask.Execute(context, CheckInsertRightsScriptTaskExecute);
					break;
				case "SocialMessageInserting":
					context.QueueTasks.Dequeue();
					context.SenderName = "SocialMessageInserting";
					result = SocialMessageInserting.Execute(context);
					break;
				case "DeleteLinkPreviewInfoScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteLinkPreviewInfoScriptTask";
					result = DeleteLinkPreviewInfoScriptTask.Execute(context, DeleteLinkPreviewInfoScriptTaskExecute);
					break;
				case "AddLinkPreviewInfoScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddLinkPreviewInfoScriptTask";
					result = AddLinkPreviewInfoScriptTask.Execute(context, AddLinkPreviewInfoScriptTaskExecute);
					break;
				case "SocialMessageSavedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SocialMessageSavedStartMessage";
					result = SocialMessageSavedStartMessage.Execute(context);
					break;
				case "DeleteLinkPreviewInfoIfUpdatedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteLinkPreviewInfoIfUpdatedScriptTask";
					result = DeleteLinkPreviewInfoIfUpdatedScriptTask.Execute(context, DeleteLinkPreviewInfoIfUpdatedScriptTaskExecute);
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

		public virtual bool UpdateParentCommentCountExecute(ProcessExecutingContext context) {
			var parentId = Entity.GetTypedColumnValue<Guid>("ParentId");
			if (parentId != Guid.Empty) {
				var select =(Select)new Select(UserConnection)
					.Column(Func.Count(Column.Asterisk()))
					.From("SocialMessage")
					.Where("ParentId").IsEqual(Column.Parameter(parentId));
			
				using (var executor = UserConnection.EnsureDBConnection()) {
					var commentCount = select.ExecuteScalar<Int32>(executor);
					DateTime localDate = DateTime.UtcNow;
					var update = (Update)new Update(UserConnection, "SocialMessage")
						.Set("CommentCount", Column.Parameter(commentCount))
						.Set("ModifiedOn", Column.Parameter(localDate))
						.Set("ModifiedById", Column.Parameter(UserConnection.CurrentUser.ContactId))
						.Where("Id").IsEqual(Column.Const(parentId));
					update.Execute(executor);
			
					//SendUpdateDeleteSocialMessage(false, commentCount);
				}
			}
			return true;
		}

		public virtual bool UpdateParentLastActionOnExecute(ProcessExecutingContext context) {
			var parentId = Entity.GetTypedColumnValue<Guid>("ParentId");
			if (parentId != Guid.Empty) {
				using (var executor = UserConnection.EnsureDBConnection()) {
					var update = (Update)new Update(UserConnection, "SocialMessage")
						.Set("LastActionOn", Column.Parameter(DateTime.UtcNow))
						.Where("Id").IsEqual(Column.Parameter(parentId));
					update.Execute(executor);
				}
			}
			return true;
		}

		public virtual bool SendSocialMessageExecute(ProcessExecutingContext context) {
			SendUpdateDeleteSocialMessage("insert");
			return true;
		}

		public virtual bool SubscribeUserExecute(ProcessExecutingContext context) {
			var sysAdminUnitId = UserConnection.CurrentUser.Id;
			var entityId = Entity.GetTypedColumnValue<Guid>("EntityId");
			var parentId = Entity.GetTypedColumnValue<Guid>("ParentId");
			var entitySchemaId = Entity.GetTypedColumnValue<Guid>("EntitySchemaUId");
			if (entityId == Guid.Empty && parentId != Guid.Empty) {
				var select = (Select)new Select(UserConnection)
					.Column("EntityId")
					.From("SocialMessage")
					.Where("Id").IsEqual(Column.Parameter(parentId));
				entityId = select.ExecuteScalar<Guid>();
			}
			var selectPostSubscribers = (Select)new Select(UserConnection)
				.Column("Id")
				.From("SocialSubscription")
				.Where("SysAdminUnitId").IsEqual(Column.Parameter(sysAdminUnitId))
					.And("EntityId").IsEqual(Column.Parameter(entityId));
			var socialSubscriptionId = selectPostSubscribers.ExecuteScalar<Guid>();
			if (socialSubscriptionId == Guid.Empty) {
				var schemaManager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
				var subscriptionSchema = schemaManager.GetInstanceByName("SocialSubscription");
				var subscription = subscriptionSchema.CreateEntity(UserConnection) as SocialSubscription;
				subscription.SetDefColumnValues();
				subscription.SysAdminUnitId = sysAdminUnitId;
				subscription.EntityId = entityId;
				subscription.CanUnsubscribe = true;
				subscription.EntitySchemaUId = entitySchemaId;
				subscription.UseAdminRights = GlobalAppSettings.FeatureUseAdminRightsInEmbeddedLogic;
				subscription.Save();
			}
			return true;
		}

		public virtual bool SendUpdateMessageExecute(ProcessExecutingContext context) {
			SendUpdateDeleteSocialMessage("update");
			return true;
		}

		public virtual bool SendDeleteSocialMessageExecute(ProcessExecutingContext context) {
			SendUpdateDeleteSocialMessage("delete");
			PublishDeleteNotificationsMessage();
			return true;
		}

		public virtual bool CheckInsertRightsScriptTaskExecute(ProcessExecutingContext context) {
			CheckInsertRights();
			return true;
		}

		public virtual bool DeleteLinkPreviewInfoScriptTaskExecute(ProcessExecutingContext context) {
			DeleteLinkPreviewInfo();
			return true;
		}

		public virtual bool AddLinkPreviewInfoScriptTaskExecute(ProcessExecutingContext context) {
			AddLinkPreviewInfo();
			return true;
		}

		public virtual bool DeleteLinkPreviewInfoIfUpdatedScriptTaskExecute(ProcessExecutingContext context) {
			DeleteLinkPreviewInfoIfUpdated();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "SocialMessageInserted":
							if (ActivatedEventElements.Contains("SocialMessageInsertedStartMessage")) {
							context.QueueTasks.Enqueue("SocialMessageInsertedStartMessage");
						}
						break;
					case "SocialMessageDeleted":
							if (ActivatedEventElements.Contains("SocialMessageDeletedStartMessage")) {
							context.QueueTasks.Enqueue("SocialMessageDeletedStartMessage");
						}
						break;
					case "SocialMessageUpdating":
							if (ActivatedEventElements.Contains("SocialMessageUpdating")) {
							context.QueueTasks.Enqueue("SocialMessageUpdating");
						}
						break;
					case "SocialMessageUpdated":
							if (ActivatedEventElements.Contains("SocialMessageUpdated")) {
							context.QueueTasks.Enqueue("SocialMessageUpdated");
						}
						break;
					case "SocialMessageDeleting":
							if (ActivatedEventElements.Contains("SocialMessageDeleting")) {
							context.QueueTasks.Enqueue("SocialMessageDeleting");
						}
						break;
					case "SocialMessageInserting":
							if (ActivatedEventElements.Contains("SocialMessageInserting")) {
							context.QueueTasks.Enqueue("SocialMessageInserting");
						}
						break;
					case "SocialMessageSaved":
							if (ActivatedEventElements.Contains("SocialMessageSavedStartMessage")) {
							context.QueueTasks.Enqueue("SocialMessageSavedStartMessage");
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

	#region Class: SocialMessage_ESNEventsProcess

	/// <exclude/>
	public class SocialMessage_ESNEventsProcess : SocialMessage_ESNEventsProcess<SocialMessage>
	{

		public SocialMessage_ESNEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SocialMessage_ESNEventsProcess

	public partial class SocialMessage_ESNEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void SendUpdateDeleteSocialMessage(string operation) {
			if (GetIsComment()) {
				return;
			}
			SimpleMessage simpleMessage = CreateSimpleMessage(operation);
			List<Guid> subscriptors = GetSubscriptors();
			MsgChannelManager manager = MsgChannelManager.Instance;
			manager.Post(subscriptors, simpleMessage);
		}

		public virtual SimpleMessage CreateSimpleMessage(string operation) {
			var socialMessageId = Entity.GetTypedColumnValue<Guid>("Id");
			var sysAdminUnitId = UserConnection.CurrentUser.Id;
			var entityId = Entity.GetTypedColumnValue<Guid>("EntityId");
			return new SimpleMessage {
				Id = socialMessageId,
				Header = {
					Sender = "UpdateSocialMessage"
				},
				Body = string.Format("{{ \"sysAdminUnitId\": \"{0}\", \"channelId\": \"{1}\", \"operation\": \"{2}\"}}",
					sysAdminUnitId, entityId, operation)
			};
		}

		public virtual bool GetIsComment() {
			var parentId = Entity.GetTypedColumnValue<Guid>("ParentId");
			return parentId.IsNotEmpty();
		}

		public virtual List<Guid> GetSubscriptors() {
			var channelId = Entity.GetTypedColumnValue<Guid>("EntityId");
			List<Guid> channelSubscriptors = new List<Guid>();
			string roleSubscriptionTable = "SocialSubscription";
			string roleSubscriptionColumnPath = "=[SysUserInRole:SysRole:SysAdminUnit].SysUser.Id";
			List<Guid> roleSubscriptors = GetChannelSubscriptors(channelId, roleSubscriptionTable, roleSubscriptionColumnPath);
			string userSubscriptionTable = "SocialSubscription";
			string userSubscriptionColumnPath = "=[SysUserInRole:SysUser:SysAdminUnit].SysUser.Id";
			List<Guid> userSubscriptors = GetChannelSubscriptors(channelId, userSubscriptionTable, userSubscriptionColumnPath);
			string userUnsubscriptionTable = "SocialUnsubscription";
			string userUnsubscriptionColumnPath = "=[SysUserInRole:SysUser:SysAdminUnit].SysUser.Id";
			List<Guid> userUnsubscriptors = GetChannelSubscriptors(channelId, userUnsubscriptionTable, userUnsubscriptionColumnPath);
			channelSubscriptors.AddRange(roleSubscriptors);
			channelSubscriptors.AddRange(userSubscriptors);
			channelSubscriptors.RemoveAll(subscriptor => userUnsubscriptors.Contains(subscriptor));
			return channelSubscriptors;
		}

		public virtual List<Guid> GetChannelSubscriptors(Guid channelId, string subscriptionTable, string columnPath) {
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, subscriptionTable) {
				UseAdminRights = false
			};
			var column = esq.AddColumn(columnPath);
			var currentChannelFilter = esq.CreateFilterWithParameters(FilterComparisonType.Equal, "EntityId", channelId);
			esq.Filters.Add(currentChannelFilter);
			EntityCollection channelSubscriptors = esq.GetEntityCollection(UserConnection);
			var list = new List<Guid>();
			foreach (var subscriptor in channelSubscriptors) {
				list.Add(subscriptor.GetTypedColumnValue<Guid>(column.Name));
			}
			return list;
		}

		public virtual bool IsAllAllowedChannelPost(Guid channelId) {
			Select select = new Select(UserConnection)
				.Column("PublisherRightKind")
				.From("SocialChannel")
				.Where("Id").IsEqual(Column.Parameter(channelId)) as Select;
			return select.ExecuteScalar<bool>();
		}

		public virtual Guid GetParentEntitySchemaUId(Guid parentId) {
			Select select = new Select(UserConnection)
					.Column("EntitySchemaUId")
					.From("SocialMessage")
					.Where("Id").IsEqual(Column.Parameter(parentId)) as Select;
			return select.ExecuteScalar<Guid>();
		}

		public virtual Guid GetEntitySchemaUId() {
			Guid entitySchemaUId = Entity.GetTypedColumnValue<Guid>("EntitySchemaUId");
			if (entitySchemaUId.IsEmpty()) {
				entitySchemaUId = GetParentEntitySchemaUId(Entity.GetTypedColumnValue<Guid>("ParentId"));
			}
			return entitySchemaUId;
		}

		public virtual string GetTargetSchemaName() {
			Guid entitySchemaUId = GetEntitySchemaUId();
			EntitySchema currentEntitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(entitySchemaUId);
			string targetSchemaName = currentEntitySchema.Name;
			return targetSchemaName;
		}

		public virtual void CheckSchemaRecordRightLevels(string targetSchemaName, Guid recordId) {
			SchemaRecordRightLevels canEditRight = SchemaRecordRightLevels.CanEdit;
			SchemaRecordRightLevels schemaRightLevel = UserConnection.DBSecurityEngine.GetEntitySchemaRecordRightLevel(targetSchemaName, recordId);
			if ((schemaRightLevel & canEditRight) != canEditRight) {
				throw new SecurityException(string.Format(new LocalizableString("Terrasoft.Core",
						"DBSecurityEngine.Exception.CurrentUserHasNotRightsForObject"), targetSchemaName));
			}
		}

		public virtual void CheckInsertRights() {
			Guid recordId = Entity.GetTypedColumnValue<Guid>("EntityId");
			string targetSchemaName = GetTargetSchemaName();
			if (recordId.IsNotEmpty() && targetSchemaName == "SocialChannel") {
				if (IsAllAllowedChannelPost(recordId)) {
					return;
				}
				else {
					CheckSchemaRecordRightLevels(targetSchemaName, recordId);
				}
			}
		}

		public virtual Dictionary<Guid,Guid> GetConnectedNotifications(Guid socialMessageId) {
			EntitySchemaQuery esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "ESNNotification");
			esq.PrimaryQueryColumn.IsAlwaysSelect = true;
			var sysAdminUnitIdColumn = esq.AddColumn("[SysAdminUnit:Contact:Owner].Id");
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "SocialMessage", socialMessageId));
			return esq.GetEntityCollection(UserConnection).ToDictionary(e=>e.PrimaryColumnValue, 
				e=>e.GetTypedColumnValue<Guid>(sysAdminUnitIdColumn.Name));
		}

		public virtual void PublishDeleteNotificationsMessage() {
			var manager = MsgChannelManager.Instance;
			Dictionary<Guid, Guid> notificationsByOwner = GetConnectedNotifications(Entity.PrimaryColumnValue);
			foreach (var notification in notificationsByOwner) {
				Guid recordId = notification.Key;
				Guid recordOwnerSysAdminUnitId = notification.Value;
				var channel = manager.FindItemByUId(recordOwnerSysAdminUnitId);
				if (channel == null) {
					continue;
				}
				var message = new {
					recordId = recordId,
					notificationGroup = NotificationGroupConst.ESNNotification,
					operation = "delete",
				};
				var simpleMessage = new SimpleMessage {
					Body = JsonConvert.SerializeObject(message),
					Id = recordOwnerSysAdminUnitId,
					Header = {
						Sender = "UpdateReminding"
					}
				};
				channel.PostMessage(simpleMessage);
			}
		}

		public virtual bool IsURLValid(string url) {
			Uri uriResult;
			return Uri.TryCreate(url, UriKind.Absolute, out uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
		}

		public virtual string StripHtmlTags(string text) {
			return Regex.Replace(text, "\\<[^\\>]*\\>", String.Empty);
		}

		public virtual void DeleteLinkPreviewInfo() {
			if (!UserConnection.GetIsFeatureEnabled("LinkPreview")) {
				return;
			}
			LinkPreviewProvider linkPreviewProvider = new LinkPreviewProvider(UserConnection);
			linkPreviewProvider.DeleteLinkPreviewInfo(Entity.PrimaryColumnValue);
		}

		public virtual void DeleteLinkPreviewInfoIfUpdated() {
			if (!UserConnection.GetIsFeatureEnabled("LinkPreview")) {
				return;
			}
			string oldMessage = (string)Entity.GetColumnOldValue("Message");
			oldMessage = StripHtmlTags(oldMessage).Trim();
			if (IsURLValid(oldMessage)) {
				LinkPreviewProvider linkPreviewProvider = new LinkPreviewProvider(UserConnection);
				linkPreviewProvider.DeleteLinkPreviewInfo(Entity.PrimaryColumnValue);
			}
		}

		public virtual void AddLinkPreviewInfo() {
			if (!UserConnection.GetIsFeatureEnabled("LinkPreview")) {
				return;
			}
			var message = Entity.GetTypedColumnValue<string>("Message");
			message = StripHtmlTags(message).Trim();
			if (IsURLValid(message)) {
				LinkPreview linkPreview = new LinkPreview();
				LinkPreviewInfo linkPreviewInfo = linkPreview.GetWebPageLinkPreview(message);
				if (linkPreviewInfo != null) {
					LinkPreviewProvider linkPreviewProvider = new LinkPreviewProvider(UserConnection);
					linkPreviewProvider.SaveLinkPreviewInfo(linkPreviewInfo, Entity.PrimaryColumnValue);
				}
			}
		}

		#endregion

	}

	#endregion

	#region Class: SocialMessageEventsProcessSchema

	/// <exclude/>
	public class SocialMessageEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SocialMessageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SocialMessageEventsProcessSchema(SocialMessageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SocialMessage_ESNEventsProcess";
			UId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892");
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
			ProcessSchemaEventSubProcess socialmessagecahngesubprocess = CreateSocialMessageCahngeSubProcessEventSubProcess();
			FlowElements.Add(socialmessagecahngesubprocess);
			ProcessSchemaStartMessageEvent socialmessageinsertedstartmessage = CreateSocialMessageInsertedStartMessageStartMessageEvent();
			socialmessagecahngesubprocess.FlowElements.Add(socialmessageinsertedstartmessage);
			ProcessSchemaStartMessageEvent socialmessagedeletedstartmessage = CreateSocialMessageDeletedStartMessageStartMessageEvent();
			socialmessagecahngesubprocess.FlowElements.Add(socialmessagedeletedstartmessage);
			ProcessSchemaScriptTask updateparentcommentcount = CreateUpdateParentCommentCountScriptTask();
			socialmessagecahngesubprocess.FlowElements.Add(updateparentcommentcount);
			ProcessSchemaStartMessageEvent socialmessageupdating = CreateSocialMessageUpdatingStartMessageEvent();
			socialmessagecahngesubprocess.FlowElements.Add(socialmessageupdating);
			ProcessSchemaScriptTask updateparentlastactionon = CreateUpdateParentLastActionOnScriptTask();
			socialmessagecahngesubprocess.FlowElements.Add(updateparentlastactionon);
			ProcessSchemaScriptTask sendsocialmessage = CreateSendSocialMessageScriptTask();
			socialmessagecahngesubprocess.FlowElements.Add(sendsocialmessage);
			ProcessSchemaScriptTask subscribeuser = CreateSubscribeUserScriptTask();
			socialmessagecahngesubprocess.FlowElements.Add(subscribeuser);
			ProcessSchemaScriptTask sendupdatemessage = CreateSendUpdateMessageScriptTask();
			socialmessagecahngesubprocess.FlowElements.Add(sendupdatemessage);
			ProcessSchemaStartMessageEvent socialmessageupdated = CreateSocialMessageUpdatedStartMessageEvent();
			socialmessagecahngesubprocess.FlowElements.Add(socialmessageupdated);
			ProcessSchemaScriptTask senddeletesocialmessage = CreateSendDeleteSocialMessageScriptTask();
			socialmessagecahngesubprocess.FlowElements.Add(senddeletesocialmessage);
			ProcessSchemaStartMessageEvent socialmessagedeleting = CreateSocialMessageDeletingStartMessageEvent();
			socialmessagecahngesubprocess.FlowElements.Add(socialmessagedeleting);
			ProcessSchemaScriptTask checkinsertrightsscripttask = CreateCheckInsertRightsScriptTaskScriptTask();
			socialmessagecahngesubprocess.FlowElements.Add(checkinsertrightsscripttask);
			ProcessSchemaStartMessageEvent socialmessageinserting = CreateSocialMessageInsertingStartMessageEvent();
			socialmessagecahngesubprocess.FlowElements.Add(socialmessageinserting);
			ProcessSchemaScriptTask deletelinkpreviewinfoscripttask = CreateDeleteLinkPreviewInfoScriptTaskScriptTask();
			socialmessagecahngesubprocess.FlowElements.Add(deletelinkpreviewinfoscripttask);
			ProcessSchemaScriptTask addlinkpreviewinfoscripttask = CreateAddLinkPreviewInfoScriptTaskScriptTask();
			socialmessagecahngesubprocess.FlowElements.Add(addlinkpreviewinfoscripttask);
			ProcessSchemaStartMessageEvent socialmessagesavedstartmessage = CreateSocialMessageSavedStartMessageStartMessageEvent();
			socialmessagecahngesubprocess.FlowElements.Add(socialmessagesavedstartmessage);
			ProcessSchemaScriptTask deletelinkpreviewinfoifupdatedscripttask = CreateDeleteLinkPreviewInfoIfUpdatedScriptTaskScriptTask();
			socialmessagecahngesubprocess.FlowElements.Add(deletelinkpreviewinfoifupdatedscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9_7f1854ead09346e3a8bb795ca766c12cSequenceFlow());
			FlowElements.Add(CreateSequenceFlow10_fb18183802eb4259946f73f7558b0f4fSequenceFlow());
			FlowElements.Add(CreateSequenceFlow11_37bf8028bc2a4674b67ca0239ea1aee9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12_cf7b47da19e645979cadbcc5fdc39b79SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("614116d1-e457-48ff-bb37-0faef6fbbfd7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6"),
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CurveCenterPosition = new Point(170, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2271869d-efb9-445c-b054-c0fc0aed56b0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1ee35785-a433-4e93-9211-3e1049fc1a84"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(531, 205));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("7f821209-58a6-4c2a-8af7-369159ff139a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6"),
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CurveCenterPosition = new Point(165, 122),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5262f53d-a9d8-432f-b36e-9ae9c7f85cd6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7dd0f3b8-8281-40ef-9cbd-61513be24f03"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("f0efcfd2-a628-4146-964e-bb8617711bc3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6"),
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CurveCenterPosition = new Point(182, 184),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a6e1fc59-4314-4bbc-8d03-6c2fb5aff1bc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4cf3bd6a-337a-4f70-b7a7-ce0d06c6c9b8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("18b07fa3-7971-4418-a3f7-cf6987a690a5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6"),
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CurveCenterPosition = new Point(184, 83),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2271869d-efb9-445c-b054-c0fc0aed56b0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4cf3bd6a-337a-4f70-b7a7-ce0d06c6c9b8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(272, 205));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("979d8f6c-3204-4194-8a79-4e616993e9ac"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016"),
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CurveCenterPosition = new Point(252, 204),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2271869d-efb9-445c-b054-c0fc0aed56b0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8162e0b0-c9b6-4a60-8b0c-8992a1480435"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("80b06de2-cecb-427b-81f6-9d5a8acaa093"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016"),
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CurveCenterPosition = new Point(250, 130),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2271869d-efb9-445c-b054-c0fc0aed56b0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("83d25c93-9688-4bb8-bce9-9c89186c69bf"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("6bbe8893-1053-4784-9807-a877cd4a4958"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016"),
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CurveCenterPosition = new Point(260, 547),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1dd10180-c2b1-49c8-ace9-4d4c445ac45d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2cbc96bf-9efc-4335-8572-6b8c9087b2b4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("c835c989-26bd-4c8b-8073-351458fa7d5d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016"),
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CurveCenterPosition = new Point(525, 238),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cd83857b-fd76-4bfa-b9d9-3c77d8c576bc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d3d46d69-9bf0-4afe-934a-be0ec174426e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9_7f1854ead09346e3a8bb795ca766c12cSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9_7f1854ead09346e3a8bb795ca766c12c",
				UId = new Guid("7f1854ea-d093-46e3-a8bb-795ca766c12c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea"),
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7f9ab86b-e8d8-405e-9adf-b2320d788a6d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a5a05e18-c40a-4544-8cf5-040e66935e32"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10_fb18183802eb4259946f73f7558b0f4fSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10_fb18183802eb4259946f73f7558b0f4f",
				UId = new Guid("fb181838-02eb-4259-946f-73f7558b0f4f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("f8040510-1587-4652-9d4f-4809f5f9b2d7"),
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7dd0f3b8-8281-40ef-9cbd-61513be24f03"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1ee35785-a433-4e93-9211-3e1049fc1a84"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11_37bf8028bc2a4674b67ca0239ea1aee9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11_37bf8028bc2a4674b67ca0239ea1aee9",
				UId = new Guid("37bf8028-bc2a-4674-b67c-a0239ea1aee9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("f8040510-1587-4652-9d4f-4809f5f9b2d7"),
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("716269d4-dc7e-4211-a19b-41b3e4c4f9af"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4c8627ed-2007-4e3f-b713-a5eb66417e13"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12_cf7b47da19e645979cadbcc5fdc39b79SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12_cf7b47da19e645979cadbcc5fdc39b79",
				UId = new Guid("cf7b47da-19e6-4597-9cad-bcc5fdc39b79"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("f8040510-1587-4652-9d4f-4809f5f9b2d7"),
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2cbc96bf-9efc-4335-8572-6b8c9087b2b4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3c6ac282-094d-4c64-a738-0da1926afd18"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("bb50fac8-4130-4834-ac21-ceec5829f61e"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6"),
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1566, 690),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("8d72d3ab-4b21-4a69-97d0-0db6c36975e7"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("bb50fac8-4130-4834-ac21-ceec5829f61e"),
				CreatedInOwnerSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"),
				CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6"),
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1537, 690),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSocialMessageCahngeSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSocialMessageCahngeSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ab847359-b95e-4aa0-afaf-0ae9ad8943b3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8d72d3ab-4b21-4a69-97d0-0db6c36975e7"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6"),
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				Name = @"SocialMessageCahngeSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(210, 31),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(910, 729),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSocialMessageCahngeSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSocialMessageInsertedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2271869d-efb9-445c-b054-c0fc0aed56b0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab847359-b95e-4aa0-afaf-0ae9ad8943b3"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6"),
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SocialMessageInserted",
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				Name = @"SocialMessageInsertedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(175, 161),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSocialMessageDeletedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5262f53d-a9d8-432f-b36e-9ae9c7f85cd6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab847359-b95e-4aa0-afaf-0ae9ad8943b3"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6"),
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SocialMessageDeleted",
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				Name = @"SocialMessageDeletedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(308, 483),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateUpdateParentCommentCountScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1ee35785-a433-4e93-9211-3e1049fc1a84"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab847359-b95e-4aa0-afaf-0ae9ad8943b3"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6"),
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				Name = @"UpdateParentCommentCount",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(287, 203),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,82,203,78,195,48,16,60,167,82,255,193,228,228,72,149,145,224,88,138,4,109,64,61,240,144,66,225,108,37,91,176,72,236,98,175,129,10,241,239,108,236,166,164,16,169,135,237,122,103,118,118,38,239,210,178,141,180,160,113,89,177,25,203,53,42,220,138,107,192,135,237,6,170,185,169,125,163,31,101,237,225,236,218,171,234,156,167,247,187,225,52,155,142,71,106,205,248,30,125,52,99,237,140,200,155,13,110,51,246,53,30,37,239,196,238,160,134,18,217,140,23,161,200,52,124,176,88,242,149,3,59,55,90,83,173,140,206,8,144,136,184,146,95,121,93,82,237,53,242,216,17,23,14,193,42,247,202,179,44,78,94,89,211,240,180,48,165,146,245,13,56,39,159,33,141,47,79,47,96,161,47,85,44,93,254,230,101,221,113,209,139,108,128,248,246,234,179,246,28,2,123,167,244,51,227,173,112,248,132,210,163,177,100,203,161,80,145,107,231,45,44,46,127,91,36,42,28,28,46,46,77,211,16,105,80,79,224,104,128,200,3,29,20,165,172,165,61,91,106,60,61,57,231,221,142,118,123,146,44,36,194,131,106,128,213,134,166,218,127,4,239,154,98,133,229,173,249,152,118,91,252,166,138,3,124,21,170,96,108,44,255,24,59,97,67,46,37,162,0,228,233,188,39,54,157,176,127,6,245,143,201,250,192,27,83,169,181,130,234,78,15,193,246,23,12,98,46,183,148,202,0,234,143,207,115,111,219,116,218,46,125,11,26,101,25,146,138,132,187,144,135,226,165,89,135,135,209,38,73,244,171,139,225,192,249,246,249,248,184,0,93,69,255,22,148,24,37,213,247,140,175,101,237,96,114,144,109,224,253,30,143,232,103,1,189,213,12,173,135,233,15,181,98,53,103,83,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSocialMessageUpdatingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a6e1fc59-4314-4bbc-8d03-6c2fb5aff1bc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab847359-b95e-4aa0-afaf-0ae9ad8943b3"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6"),
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SocialMessageUpdating",
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				Name = @"SocialMessageUpdating",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(49, 378),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateUpdateParentLastActionOnScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4cf3bd6a-337a-4f70-b7a7-ce0d06c6c9b8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab847359-b95e-4aa0-afaf-0ae9ad8943b3"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6"),
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				Name = @"UpdateParentLastActionOn",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(28, 209),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,144,203,106,195,48,16,69,215,246,87,76,181,146,32,232,7,210,20,218,196,132,64,95,144,184,93,11,123,154,10,236,145,43,141,146,154,146,127,175,108,55,45,161,187,65,186,231,142,142,14,198,67,103,60,18,111,106,88,64,65,108,185,215,107,228,93,223,97,189,116,77,108,233,197,52,17,175,215,209,214,55,82,60,255,132,133,154,231,246,13,228,47,124,181,128,33,162,139,182,227,94,193,87,158,197,96,105,15,242,144,86,224,39,86,145,157,79,43,202,128,126,233,136,176,98,235,72,23,20,162,199,213,221,223,145,84,35,157,13,92,236,106,195,152,40,89,142,147,34,60,194,52,202,203,162,25,136,173,171,172,105,30,48,4,179,71,161,82,69,166,183,200,82,220,155,192,183,99,234,137,196,12,38,43,157,76,76,139,140,94,174,82,221,206,182,168,75,174,30,221,81,77,232,235,59,122,148,98,80,213,155,80,124,68,211,200,127,232,89,95,165,239,200,178,233,185,186,24,109,81,158,173,135,187,83,126,202,61,114,244,4,236,35,206,191,1,200,159,173,80,121,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateSendSocialMessageScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8162e0b0-c9b6-4a60-8b0c-8992a1480435"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab847359-b95e-4aa0-afaf-0ae9ad8943b3"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016"),
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				Name = @"SendSocialMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(154, 329),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,205,75,9,45,72,73,44,73,117,73,205,73,45,73,13,206,79,206,76,204,241,77,45,46,78,76,79,213,80,202,204,43,78,45,42,81,210,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,195,224,156,251,54,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateSubscribeUserScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("83d25c93-9688-4bb8-bce9-9c89186c69bf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab847359-b95e-4aa0-afaf-0ae9ad8943b3"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016"),
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				Name = @"SubscribeUser",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(154, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,219,78,227,48,20,124,46,18,255,96,242,128,146,23,255,0,23,169,100,67,21,105,65,136,108,225,217,141,15,173,165,196,201,250,82,136,16,255,190,118,236,180,78,211,34,246,205,178,231,140,231,140,231,120,75,4,146,157,156,211,154,241,37,103,42,167,232,6,45,37,136,180,225,28,74,197,26,142,83,45,4,112,101,119,113,78,175,206,207,182,166,200,108,48,213,245,240,172,95,226,5,168,63,93,11,52,109,42,93,243,23,82,105,184,94,104,70,111,227,40,243,224,40,241,213,45,177,140,63,172,126,242,224,93,181,187,187,40,55,80,147,255,82,224,74,150,158,138,189,161,120,223,198,13,178,80,156,213,173,234,208,229,229,94,226,69,120,146,160,207,243,179,153,21,33,161,50,254,152,203,227,162,95,37,28,222,145,91,198,99,3,19,83,49,195,78,84,232,69,191,125,47,154,58,142,138,166,100,164,122,0,41,201,26,252,201,235,6,4,196,145,69,226,92,102,127,53,169,98,71,130,141,35,164,6,5,34,30,84,38,182,161,89,240,40,78,30,206,62,160,212,10,138,146,84,68,120,51,44,244,203,57,233,80,79,141,84,133,94,201,82,176,21,8,249,211,158,118,45,249,102,70,189,120,190,214,130,221,169,239,167,24,165,237,187,222,198,185,76,156,43,115,78,67,15,79,87,15,94,36,67,106,228,68,87,96,212,129,5,39,125,179,153,57,78,116,34,37,125,226,30,8,55,239,42,166,163,101,18,91,132,136,113,80,253,102,148,32,34,209,145,131,171,225,146,64,138,3,216,190,66,164,189,40,231,82,17,94,194,93,247,104,44,58,254,78,199,24,45,215,228,2,156,10,32,10,156,168,195,108,88,185,83,118,203,29,18,225,2,212,47,120,11,134,85,246,22,31,128,14,63,167,113,42,38,248,108,63,2,67,2,38,152,148,152,106,57,188,182,65,42,161,225,4,211,238,203,216,17,14,255,206,164,192,184,208,43,123,102,235,141,178,83,180,168,154,21,169,230,109,107,58,85,140,175,37,190,55,166,105,1,99,100,206,179,122,5,148,2,253,221,172,89,57,181,128,108,97,24,90,1,166,158,59,193,255,0,252,166,175,147,188,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateSendUpdateMessageScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2cbc96bf-9efc-4335-8572-6b8c9087b2b4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab847359-b95e-4aa0-afaf-0ae9ad8943b3"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016"),
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				Name = @"SendUpdateMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(427, 483),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,205,75,9,45,72,73,44,73,117,73,205,73,45,73,13,206,79,206,76,204,241,77,45,46,78,76,79,213,80,42,5,75,41,105,90,243,114,21,165,150,148,22,229,41,148,20,149,166,90,3,0,252,44,141,168,54,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSocialMessageUpdatedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("1dd10180-c2b1-49c8-ace9-4d4c445ac45d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab847359-b95e-4aa0-afaf-0ae9ad8943b3"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016"),
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SocialMessageUpdated",
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				Name = @"SocialMessageUpdated",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(448, 378),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSendDeleteSocialMessageScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d3d46d69-9bf0-4afe-934a-be0ec174426e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab847359-b95e-4aa0-afaf-0ae9ad8943b3"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016"),
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				Name = @"SendDeleteSocialMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(427, 203),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,205,75,9,45,72,73,44,73,117,73,205,73,45,73,13,206,79,206,76,204,241,77,45,46,78,76,79,213,80,74,1,11,42,105,90,243,114,5,148,38,229,100,22,103,64,148,249,229,151,100,166,101,38,39,150,100,230,231,21,195,84,131,84,21,165,150,148,22,229,41,148,20,149,166,90,3,0,172,8,255,102,92,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSocialMessageDeletingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("cd83857b-fd76-4bfa-b9d9-3c77d8c576bc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab847359-b95e-4aa0-afaf-0ae9ad8943b3"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016"),
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SocialMessageDeleting",
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				Name = @"SocialMessageDeleting",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(448, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCheckInsertRightsScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a5a05e18-c40a-4544-8cf5-040e66935e32"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab847359-b95e-4aa0-afaf-0ae9ad8943b3"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea"),
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				Name = @"CheckInsertRightsScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(175, 477),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,206,72,77,206,246,204,43,78,45,42,9,202,76,207,40,41,214,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,84,29,141,105,33,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSocialMessageInsertingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7f9ab86b-e8d8-405e-9adf-b2320d788a6d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab847359-b95e-4aa0-afaf-0ae9ad8943b3"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea"),
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SocialMessageInserting",
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				Name = @"SocialMessageInserting",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(63, 491),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDeleteLinkPreviewInfoScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7dd0f3b8-8281-40ef-9cbd-61513be24f03"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab847359-b95e-4aa0-afaf-0ae9ad8943b3"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("f8040510-1587-4652-9d4f-4809f5f9b2d7"),
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				Name = @"DeleteLinkPreviewInfoScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(287, 329),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,73,205,73,45,73,245,201,204,203,14,40,74,45,203,76,45,247,204,75,203,215,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,27,33,101,209,37,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateAddLinkPreviewInfoScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4c8627ed-2007-4e3f-b713-a5eb66417e13"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab847359-b95e-4aa0-afaf-0ae9ad8943b3"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("f8040510-1587-4652-9d4f-4809f5f9b2d7"),
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				Name = @"AddLinkPreviewInfoScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(590, 203),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,76,73,241,201,204,203,14,40,74,45,203,76,45,247,204,75,203,215,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,140,199,229,198,34,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSocialMessageSavedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("716269d4-dc7e-4211-a19b-41b3e4c4f9af"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab847359-b95e-4aa0-afaf-0ae9ad8943b3"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("f8040510-1587-4652-9d4f-4809f5f9b2d7"),
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SocialMessageSaved",
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				Name = @"SocialMessageSavedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(611, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDeleteLinkPreviewInfoIfUpdatedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3c6ac282-094d-4c64-a738-0da1926afd18"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab847359-b95e-4aa0-afaf-0ae9ad8943b3"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("f8040510-1587-4652-9d4f-4809f5f9b2d7"),
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				Name = @"DeleteLinkPreviewInfoIfUpdatedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(427, 597),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,73,205,73,45,73,245,201,204,203,14,40,74,45,203,76,45,247,204,75,203,247,76,11,45,72,73,44,73,77,209,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,219,13,163,52,46,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateSendUpdateDeleteSocialMessageMethod());
			Methods.Add(CreateCreateSimpleMessageMethod());
			Methods.Add(CreateGetIsCommentMethod());
			Methods.Add(CreateGetSubscriptorsMethod());
			Methods.Add(CreateGetChannelSubscriptorsMethod());
			Methods.Add(CreateIsAllAllowedChannelPostMethod());
			Methods.Add(CreateGetParentEntitySchemaUIdMethod());
			Methods.Add(CreateGetEntitySchemaUIdMethod());
			Methods.Add(CreateGetTargetSchemaNameMethod());
			Methods.Add(CreateCheckSchemaRecordRightLevelsMethod());
			Methods.Add(CreateCheckInsertRightsMethod());
			Methods.Add(CreateGetConnectedNotificationsMethod());
			Methods.Add(CreatePublishDeleteNotificationsMessageMethod());
			Methods.Add(CreateIsURLValidMethod());
			Methods.Add(CreateStripHtmlTagsMethod());
			Methods.Add(CreateDeleteLinkPreviewInfoMethod());
			Methods.Add(CreateDeleteLinkPreviewInfoIfUpdatedMethod());
			Methods.Add(CreateAddLinkPreviewInfoMethod());
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
				UId = new Guid("fb9a2a2d-ea99-4726-bdea-d9500c7ff98e"),
				Name = "Terrasoft.Messaging.Common",
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
				UId = new Guid("216a3027-4a2a-4c34-8301-167ccd647bf0"),
				Name = "Terrasoft.Configuration.RightsService",
				Alias = "",
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0f6d4c57-eb66-4a65-9ddb-3842d2bc8cfb"),
				Name = "System.Security",
				Alias = "",
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("47d7770f-b6e1-44b3-bf73-bc94d4eb7edb"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("269ca102-d8fc-45d6-a6cd-8a6462201b91"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5f9277d7-1bb2-45d3-824d-b50bc30b217b"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("41662933-bfb2-40e1-b444-afca760c7a83"),
				Name = "System.Text.RegularExpressions",
				Alias = "",
				CreatedInPackageId = new Guid("f8040510-1587-4652-9d4f-4809f5f9b2d7")
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

		protected virtual SchemaMethod CreateSendUpdateDeleteSocialMessageMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("dadb1d3b-2856-4ed7-8830-e71c1ca86bf5"),
				Name = "SendUpdateDeleteSocialMessage",
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9fcf99bc-6d8d-4182-afb4-a13c8b5d5990"),
				Name = "operation",
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,142,65,10,131,64,12,69,215,21,188,67,150,51,80,188,128,181,27,23,34,40,20,60,193,212,166,118,192,201,72,18,87,165,119,239,20,92,40,93,133,228,191,255,127,252,19,76,131,218,74,29,67,64,82,99,45,188,243,236,196,168,43,83,153,103,159,60,27,124,88,102,236,81,196,77,8,114,216,42,168,25,157,226,129,49,113,65,118,234,35,217,148,208,121,209,75,179,250,199,21,100,189,203,200,126,209,200,146,172,169,120,216,93,204,143,238,101,170,95,142,8,231,222,81,202,98,8,219,172,224,79,43,90,18,117,52,98,50,110,88,113,139,162,102,95,116,62,190,108,203,47,41,66,205,226,244,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateSimpleMessageMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("aac29b87-5acf-4e81-b22d-eefeb98250c3"),
				Name = "CreateSimpleMessage",
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea"),
				ResultValueTypeName = "SimpleMessage"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9c436db8-ad4a-4d46-9a99-3c37c4240f39"),
				Name = "operation",
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,189,106,195,48,20,133,103,249,41,132,166,4,140,73,59,54,109,161,53,73,234,161,147,235,78,94,132,117,73,5,242,149,209,79,138,49,122,247,74,142,49,77,167,110,210,167,115,206,213,185,23,110,168,213,157,228,234,29,172,229,103,168,4,125,162,7,116,210,141,197,9,220,199,56,128,40,181,242,61,126,114,229,225,241,228,165,120,222,176,74,176,237,62,187,36,247,104,95,68,47,177,65,233,102,115,99,193,148,26,17,58,39,53,22,165,55,6,208,37,90,84,226,234,129,57,255,159,163,14,139,56,13,52,224,188,65,138,240,77,107,217,15,10,150,95,211,41,35,115,220,159,46,121,70,222,128,11,48,241,41,74,72,13,120,189,176,102,16,220,65,253,91,206,50,18,162,225,85,139,49,37,57,35,241,92,28,181,233,185,219,176,105,162,45,187,237,218,178,135,200,166,93,104,89,30,15,221,23,143,165,213,202,239,22,174,7,48,60,173,98,225,247,145,135,192,226,36,114,155,151,175,123,201,233,106,218,102,97,255,3,30,72,100,164,165,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsCommentMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d9c8d7d8-7323-4898-ae41-277835781e88"),
				Name = "GetIsComment",
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,40,72,44,74,205,43,241,76,81,176,85,112,205,43,201,44,169,212,115,79,45,9,169,44,72,77,113,206,207,41,205,205,11,75,204,41,77,181,113,47,205,76,177,211,80,10,128,42,86,210,180,230,229,42,74,45,41,45,202,131,27,160,231,89,236,151,95,226,154,91,80,82,169,161,105,13,0,244,159,93,200,91,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSubscriptorsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ddf88091-91d7-4a0d-be75-d87193fcaa08"),
				Name = "GetSubscriptors",
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea"),
				ResultValueTypeName = "List<Guid>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,148,75,107,131,64,20,133,247,133,254,135,193,149,129,226,15,104,106,65,164,4,161,139,162,177,155,210,197,196,185,36,3,227,157,48,143,20,255,125,71,108,18,31,99,147,64,86,50,222,115,14,247,124,62,14,84,145,106,71,17,65,100,140,196,228,13,13,55,77,180,2,179,110,246,192,82,41,108,141,159,84,88,120,89,89,206,94,195,160,83,100,44,88,44,31,31,222,185,54,221,224,152,82,216,141,174,20,223,27,169,180,203,67,248,33,103,81,216,122,180,81,28,183,68,73,1,39,49,151,184,166,27,1,206,17,20,178,226,84,244,71,193,188,171,91,240,131,154,93,107,141,191,138,70,151,26,84,134,185,19,62,187,211,241,154,176,154,99,137,220,124,71,127,154,200,117,24,86,24,132,119,251,59,16,233,180,88,120,66,246,228,239,49,189,125,94,180,199,192,186,53,110,103,48,118,93,100,208,158,174,101,48,8,191,150,129,183,199,244,246,44,131,18,245,60,133,225,48,248,207,121,119,18,189,248,91,88,120,250,248,6,67,30,158,15,40,74,24,203,41,110,33,28,191,154,23,13,227,231,56,103,200,161,150,7,72,132,8,123,77,73,236,171,31,165,18,13,229,168,251,210,69,27,172,192,88,133,190,95,192,242,23,81,129,192,5,97,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetChannelSubscriptorsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("27194979-b8a0-487d-8fc0-b3e5588760e6"),
				Name = "GetChannelSubscriptors",
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea"),
				ResultValueTypeName = "List<Guid>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b40ce170-95dc-4f40-9bc9-d5520a88e672"),
				Name = "channelId",
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9dda0d8a-f91f-45b8-8244-ea7442e02305"),
				Name = "subscriptionTable",
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("67b20538-d9e6-4214-b9d2-f587e0865f00"),
				Name = "columnPath",
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,145,221,106,195,48,12,133,175,151,167,48,189,74,160,228,5,186,13,74,232,74,97,27,221,186,159,107,53,86,27,131,227,164,178,221,17,70,223,125,114,236,178,82,122,103,203,71,250,142,142,143,64,2,237,65,60,8,131,63,98,97,156,114,195,166,110,176,133,55,143,52,228,159,22,169,234,140,193,218,169,206,148,151,130,23,48,176,71,154,10,235,183,182,38,213,7,197,7,108,53,22,226,55,187,227,206,185,108,149,121,87,251,198,89,6,236,64,91,204,78,179,236,200,204,186,211,190,53,92,101,120,57,151,178,26,239,121,44,175,193,53,69,210,121,34,52,174,106,128,61,232,39,165,29,82,234,170,8,193,97,44,125,43,215,172,129,160,69,190,216,60,22,171,174,237,129,148,101,87,67,143,229,226,224,65,79,197,36,238,176,146,147,169,168,227,216,149,100,90,24,25,251,108,48,148,223,34,179,44,118,179,93,29,35,57,207,216,156,67,232,200,38,131,75,116,215,234,171,60,211,146,90,89,151,126,224,153,143,247,75,175,228,99,206,143,187,142,119,172,27,145,7,149,253,39,8,117,147,59,230,30,134,141,11,92,232,131,149,144,65,138,249,11,180,199,68,137,137,151,175,28,93,193,196,83,70,232,60,153,209,211,236,15,167,228,230,254,30,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateIsAllAllowedChannelPostMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("357ce572-9071-461b-9e7b-e0b300db4740"),
				Name = "IsAllAllowedChannelPost",
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("94c96265-4226-4f7b-936b-5c74e15b05d0"),
				Name = "channelId",
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,45,78,75,10,195,32,20,92,55,144,59,136,43,221,120,129,180,221,132,20,66,55,161,82,186,126,49,143,70,48,74,159,74,123,252,74,204,106,102,152,15,163,209,161,73,44,86,184,48,143,95,166,119,33,158,17,169,15,222,23,110,131,151,109,115,82,125,112,121,243,130,79,121,118,54,174,72,15,251,94,211,221,250,133,239,254,141,194,38,184,14,198,130,235,87,40,93,87,141,87,201,162,224,99,201,169,49,14,159,12,78,212,49,53,1,193,134,9,73,152,218,24,23,41,25,196,227,70,215,54,132,41,147,63,62,170,225,135,38,39,212,6,28,208,121,14,193,93,133,236,254,70,202,183,106,200,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetParentEntitySchemaUIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("042e2836-75be-41bd-a403-5d7a2f22c8bd"),
				Name = "GetParentEntitySchemaUId",
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea"),
				ResultValueTypeName = "Guid"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("447bd290-2cf0-4b96-954f-430be11674cf"),
				Name = "parentId",
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,45,142,193,10,194,48,16,68,207,246,43,66,78,201,37,63,80,245,82,170,244,32,8,161,120,94,210,197,6,146,141,110,18,212,191,87,219,158,102,134,55,12,99,49,160,43,34,175,114,16,132,47,97,151,160,198,140,220,37,162,159,247,137,116,179,219,153,46,133,26,73,201,158,138,47,31,235,102,140,48,14,147,92,224,137,83,84,210,38,231,33,92,48,103,184,227,10,110,51,50,42,249,239,153,33,247,207,10,65,173,75,230,10,12,17,11,178,122,0,35,149,97,210,90,64,222,46,180,13,99,169,76,219,61,211,191,209,213,130,214,65,0,222,159,171,159,142,74,183,95,165,37,36,253,195,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetEntitySchemaUIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("aa7e83bf-b208-49bb-be6c-bfcada016711"),
				Name = "GetEntitySchemaUId",
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea"),
				ResultValueTypeName = "Guid"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,47,205,76,81,72,205,43,201,44,169,12,78,206,72,205,77,12,245,76,81,176,85,112,5,139,232,185,167,150,132,84,22,164,166,56,231,231,148,230,230,133,37,230,148,166,218,184,3,117,216,105,40,185,162,234,81,210,180,230,202,76,83,208,64,51,74,207,179,216,53,183,160,164,82,67,83,83,161,154,139,19,211,34,160,13,1,137,69,64,113,52,243,52,8,187,0,162,15,100,53,208,238,90,174,162,212,146,210,162,60,116,191,88,3,0,23,211,203,139,225,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetTargetSchemaNameMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("82b1b5b7-6075-4595-8c56-fa817b886fc8"),
				Name = "GetTargetSchemaName",
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,141,49,14,131,48,16,4,123,94,113,101,210,248,3,22,77,34,132,40,146,38,226,1,39,179,114,92,112,72,231,115,193,239,99,148,6,18,218,25,237,108,95,210,68,16,75,182,190,194,27,51,143,195,68,45,245,176,238,8,47,87,223,236,17,133,162,90,135,7,214,210,152,161,247,69,4,193,210,34,110,111,31,44,28,161,174,182,7,201,198,18,112,91,183,242,207,125,61,202,166,73,34,25,107,132,125,197,147,103,212,254,201,171,219,148,111,20,86,84,254,54,254,3,104,82,111,45,226,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCheckSchemaRecordRightLevelsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8cbfc586-a80e-42db-bbc4-21f65880b477"),
				Name = "CheckSchemaRecordRightLevels",
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("78ff9498-ed1e-4dd1-8f55-810695214154"),
				Name = "targetSchemaName",
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2ca07222-6ef3-4b86-8592-e3b640a64a40"),
				Name = "recordId",
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,144,77,106,195,64,12,133,215,246,41,20,47,202,24,204,92,32,100,83,215,109,10,33,133,184,61,192,100,172,216,83,108,77,209,40,77,127,232,221,235,31,48,52,73,151,122,250,120,122,79,165,109,176,51,59,180,158,171,157,171,27,217,224,59,182,1,172,161,162,114,50,74,176,130,242,58,166,243,9,91,198,255,0,16,38,125,86,122,175,151,128,156,123,34,180,226,60,233,187,219,18,237,145,157,124,22,84,59,66,253,128,82,144,244,243,117,79,37,134,107,148,105,185,53,29,102,192,35,242,88,165,203,216,29,64,169,139,163,55,127,250,164,176,88,157,9,223,113,36,13,251,19,16,158,96,206,243,97,241,109,200,168,130,176,163,90,223,123,238,140,168,129,217,120,107,90,247,101,246,45,150,227,82,37,207,200,108,130,63,136,206,61,99,146,197,81,20,37,23,237,102,83,157,31,153,145,100,120,199,218,132,173,159,178,132,254,200,211,254,181,127,78,146,102,112,222,53,237,43,254,252,2,172,100,246,140,180,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCheckInsertRightsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("59e6b930-2865-40fc-ae29-a13fa5bb2796"),
				Name = "CheckInsertRights",
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,144,81,11,130,48,16,199,159,245,83,12,31,98,131,240,11,88,65,136,136,16,18,21,189,15,119,233,104,110,178,157,133,68,223,189,165,228,131,4,247,116,247,187,223,253,185,188,151,130,88,168,140,21,133,32,91,146,105,148,56,196,57,224,101,232,64,164,70,245,173,190,114,213,195,38,247,232,142,70,19,81,136,136,37,161,67,43,117,77,144,219,26,240,92,53,208,242,146,183,224,61,95,193,162,75,253,130,188,17,250,187,22,23,174,52,152,181,29,14,148,145,213,234,143,102,75,162,179,169,36,87,105,195,181,6,21,49,242,10,131,175,164,112,123,165,124,153,167,15,57,13,143,198,225,44,103,35,25,88,192,222,234,36,12,222,97,0,202,193,216,76,27,168,238,211,153,211,136,159,100,221,224,1,30,158,160,203,16,235,249,59,108,212,188,63,221,5,87,204,50,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetConnectedNotificationsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b11fa2ad-7ccb-438b-b340-e607081f0805"),
				Name = "GetConnectedNotifications",
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea"),
				ResultValueTypeName = "Dictionary<Guid,Guid>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("07bed6a3-0d4d-40bf-b0d9-5c0a675a9028"),
				Name = "socialMessageId",
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,80,205,106,195,48,12,62,47,79,97,114,74,161,248,1,218,181,80,178,172,228,208,174,35,237,118,24,59,136,88,91,13,142,221,202,246,66,222,126,74,178,66,40,187,89,210,231,239,175,176,65,135,174,170,207,216,192,107,68,234,4,250,171,88,9,139,173,40,238,111,217,201,35,229,206,90,172,131,118,86,78,1,59,176,240,141,52,23,105,81,237,247,46,232,47,93,67,143,74,103,203,132,57,229,129,116,3,212,13,68,185,51,177,177,178,244,27,211,66,231,43,52,204,200,170,129,34,46,147,31,32,225,59,191,81,141,182,39,171,67,169,70,60,3,122,162,141,250,155,179,244,163,154,192,22,236,44,64,29,22,47,173,69,250,148,165,186,73,63,107,19,144,124,255,51,235,231,156,16,2,142,219,119,29,206,7,32,104,176,135,100,227,50,119,205,5,72,123,103,143,221,5,101,113,141,96,56,89,229,106,13,102,135,222,115,212,116,46,252,116,46,213,140,229,8,67,36,59,248,220,98,24,11,98,183,102,108,236,174,192,153,60,186,39,61,60,185,153,12,87,107,188,213,52,38,124,3,19,113,46,146,135,225,196,132,189,29,53,185,61,110,163,86,235,236,191,182,228,158,51,177,165,95,49,89,177,176,226,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreatePublishDeleteNotificationsMessageMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e14dbb20-b3cd-4ca9-ac9e-096b39a37375"),
				Name = "PublishDeleteNotificationsMessage",
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,82,203,78,195,48,16,60,167,18,255,96,229,148,74,85,126,160,20,137,150,82,2,234,67,68,229,110,236,109,107,228,172,35,219,105,21,80,255,29,219,73,81,2,229,18,57,187,179,51,179,99,31,169,38,5,69,186,7,77,38,100,105,246,179,3,69,4,185,108,106,105,134,198,82,100,48,190,25,60,8,102,133,66,170,235,219,69,37,248,136,248,239,29,65,101,197,78,48,234,123,102,90,175,79,24,168,22,96,103,202,49,49,11,124,213,133,36,115,180,194,214,233,70,139,194,113,205,148,172,10,124,163,178,130,161,19,217,41,13,148,29,72,114,116,198,186,212,68,224,85,169,33,249,186,25,68,222,10,209,192,148,230,25,119,234,93,100,250,2,245,184,143,9,147,121,109,238,121,33,112,139,194,254,29,10,142,252,152,55,194,154,80,28,166,205,42,125,20,200,51,11,197,180,222,102,60,249,151,213,175,20,137,29,73,126,24,156,76,37,101,227,58,98,202,101,129,141,206,185,213,42,192,24,39,225,253,192,169,129,117,22,187,28,71,190,222,53,188,208,170,42,29,96,245,187,230,110,193,216,116,158,175,186,157,48,174,74,208,77,182,19,18,115,144,96,33,246,141,243,101,109,35,138,82,194,178,103,40,239,213,130,189,169,226,181,235,62,27,133,78,236,8,218,166,57,104,65,165,248,132,245,251,135,123,2,73,187,212,48,232,118,22,185,18,89,128,60,1,229,225,25,5,129,40,7,108,126,227,109,201,169,133,87,112,112,46,112,31,251,246,249,226,185,13,57,221,40,99,91,135,73,111,7,127,29,231,111,193,155,253,38,243,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateIsURLValidMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2f1ef60f-d832-4d81-b3c8-68969867d7f8"),
				Name = "IsURLValid",
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CreatedInPackageId = new Guid("f8040510-1587-4652-9d4f-4809f5f9b2d7"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f0942580-3ec5-4531-9db0-76b7578bba09"),
				Name = "url",
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("f8040510-1587-4652-9d4f-4809f5f9b2d7")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,202,84,40,45,202,12,74,45,46,205,41,177,230,229,42,74,45,41,45,202,83,8,45,202,212,11,41,170,116,46,74,77,44,73,213,40,45,202,209,1,9,121,103,230,165,232,57,38,21,231,231,148,150,164,234,40,228,151,150,32,244,106,42,168,169,41,104,192,185,122,193,201,25,169,185,169,10,182,182,96,179,128,24,34,224,81,82,82,160,80,83,163,64,148,194,98,77,107,0,248,66,180,230,160,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateStripHtmlTagsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1d76e917-677c-4ce3-a864-8d5703682caa"),
				Name = "StripHtmlTags",
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CreatedInPackageId = new Guid("f8040510-1587-4652-9d4f-4809f5f9b2d7"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("59e7e9b3-ef08-4ec5-86db-eaf361374230"),
				Name = "text",
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				ModifiedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("f8040510-1587-4652-9d4f-4809f5f9b2d7")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,8,74,77,79,173,208,11,74,45,200,73,76,78,213,40,73,173,40,209,81,80,138,137,177,137,142,139,137,177,139,213,2,18,74,58,10,193,37,69,153,121,233,122,174,185,5,37,149,154,214,0,187,157,4,26,58,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateDeleteLinkPreviewInfoMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0b4951ce-2401-4af0-8a6d-4179dddc0188"),
				Name = "DeleteLinkPreviewInfo",
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CreatedInPackageId = new Guid("f8040510-1587-4652-9d4f-4809f5f9b2d7"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,142,177,14,130,48,20,69,103,251,21,149,169,93,248,1,226,132,104,72,24,186,232,94,229,146,188,88,94,147,71,11,33,198,127,215,17,19,214,123,206,73,46,13,218,28,111,19,164,142,204,120,38,138,92,94,145,218,233,2,159,178,160,97,255,8,232,77,209,17,191,156,96,38,44,133,181,250,173,14,130,159,192,149,250,168,13,115,18,103,234,33,58,236,108,39,205,88,244,142,109,254,31,216,74,237,228,229,25,1,9,155,188,229,33,154,134,19,165,181,116,66,163,151,181,142,33,143,124,247,33,195,86,95,250,150,16,236,221,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateDeleteLinkPreviewInfoIfUpdatedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("06839984-c826-4605-a698-20e9ebf935ad"),
				Name = "DeleteLinkPreviewInfoIfUpdated",
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CreatedInPackageId = new Guid("f8040510-1587-4652-9d4f-4809f5f9b2d7"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,144,193,110,194,48,16,68,207,228,43,220,156,236,75,126,0,113,162,180,141,68,213,168,133,222,13,30,162,85,157,117,181,118,64,8,241,239,184,128,212,32,229,186,251,102,118,102,105,167,244,211,58,66,230,129,25,219,68,129,171,87,164,58,190,192,166,94,176,96,187,241,112,186,92,18,255,52,130,61,225,80,26,163,78,197,68,144,1,158,22,231,34,38,33,110,85,240,238,29,49,218,22,106,166,244,109,104,22,156,40,29,255,60,231,193,247,29,127,120,247,109,125,15,93,222,217,210,76,139,7,229,87,22,254,190,165,206,175,108,27,245,255,202,84,43,161,78,103,156,114,232,58,174,63,151,217,137,220,16,185,6,27,68,109,36,236,201,65,148,31,153,205,20,227,160,70,104,253,248,144,124,113,50,162,175,158,225,145,48,208,215,188,11,250,94,184,201,89,173,28,111,165,175,141,179,205,249,2,197,236,221,204,111,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateAddLinkPreviewInfoMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("75b7c0e2-e52c-41de-b2a4-df0ce8a61673"),
				Name = "AddLinkPreviewInfo",
				CreatedInSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CreatedInPackageId = new Guid("f8040510-1587-4652-9d4f-4809f5f9b2d7"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,81,65,78,195,48,16,60,55,175,112,115,114,36,148,15,148,112,169,10,141,212,74,17,77,225,236,146,109,100,225,172,43,219,9,138,80,254,206,58,144,98,66,47,150,189,51,59,51,235,149,103,198,151,71,11,102,173,17,225,205,73,141,233,19,184,220,62,130,112,173,129,13,138,147,130,138,199,59,137,239,133,129,78,194,71,156,36,236,51,90,24,32,2,174,162,33,234,132,97,13,88,43,106,96,25,219,160,147,174,247,42,101,127,129,106,173,85,219,224,139,80,45,220,91,103,36,214,15,60,222,127,179,227,100,21,253,54,30,8,189,108,93,163,74,81,91,254,83,79,210,210,200,134,19,81,82,212,220,30,159,119,164,37,171,43,62,102,9,210,49,21,220,51,134,116,6,168,23,10,217,57,158,117,216,49,190,179,176,226,7,121,133,83,65,94,161,206,100,79,114,62,216,92,98,73,206,173,82,99,184,208,175,48,186,147,21,152,208,225,90,251,151,118,66,248,223,13,121,211,197,13,129,244,32,58,152,13,55,79,118,55,237,167,160,111,21,166,15,214,227,101,135,104,248,2,207,233,231,123,19,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SocialMessageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"));
		}

		#endregion

	}

	#endregion


	#region Class: SocialMessageEventsProcess

	/// <exclude/>
	public class SocialMessageEventsProcess : SocialMessage_ESNEventsProcess
	{

		public SocialMessageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

