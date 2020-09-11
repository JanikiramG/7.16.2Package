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

	#region Class: VwAccountRelationshipSchema

	/// <exclude/>
	public class VwAccountRelationshipSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public VwAccountRelationshipSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwAccountRelationshipSchema(VwAccountRelationshipSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwAccountRelationshipSchema(VwAccountRelationshipSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6a2487dd-c803-4bcf-903a-30355df9866b");
			RealUId = new Guid("6a2487dd-c803-4bcf-903a-30355df9866b");
			Name = "VwAccountRelationship";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3");
			IsDBView = true;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("1437e774-afb9-4331-9cdb-e1be2d7987cc")) == null) {
				Columns.Add(CreateAccountColumn());
			}
			if (Columns.FindByUId(new Guid("010495ab-710f-4d8c-8502-39518c16458d")) == null) {
				Columns.Add(CreateRelatedAccountColumn());
			}
			if (Columns.FindByUId(new Guid("32d2149b-3624-4f40-b59e-946eeb527e15")) == null) {
				Columns.Add(CreateRelatedContactColumn());
			}
			if (Columns.FindByUId(new Guid("4ebcae2d-6185-458d-8d08-af63fa136cfe")) == null) {
				Columns.Add(CreateRelationTypeColumn());
			}
			if (Columns.FindByUId(new Guid("65f16185-47e9-4fc2-abe3-65f2aa5b5b99")) == null) {
				Columns.Add(CreateReverseRelationTypeColumn());
			}
			if (Columns.FindByUId(new Guid("ab47c488-344e-425d-a34c-3dec611f3dff")) == null) {
				Columns.Add(CreateActiveColumn());
			}
			if (Columns.FindByUId(new Guid("3d2d7c5b-613d-4aec-a9c1-49829503c027")) == null) {
				Columns.Add(CreateDescriptionColumn());
			}
			if (Columns.FindByUId(new Guid("28503d1b-16da-4ff0-a632-82255760ecde")) == null) {
				Columns.Add(CreateRelatedObjectNameColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("6a2487dd-c803-4bcf-903a-30355df9866b");
			column.CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("6a2487dd-c803-4bcf-903a-30355df9866b");
			column.CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("6a2487dd-c803-4bcf-903a-30355df9866b");
			column.CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("6a2487dd-c803-4bcf-903a-30355df9866b");
			column.CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("6a2487dd-c803-4bcf-903a-30355df9866b");
			column.CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("6a2487dd-c803-4bcf-903a-30355df9866b");
			column.CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3");
			return column;
		}

		protected virtual EntitySchemaColumn CreateAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("1437e774-afb9-4331-9cdb-e1be2d7987cc"),
				Name = @"Account",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("6a2487dd-c803-4bcf-903a-30355df9866b"),
				ModifiedInSchemaUId = new Guid("6a2487dd-c803-4bcf-903a-30355df9866b"),
				CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3")
			};
		}

		protected virtual EntitySchemaColumn CreateRelatedAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("010495ab-710f-4d8c-8502-39518c16458d"),
				Name = @"RelatedAccount",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("6a2487dd-c803-4bcf-903a-30355df9866b"),
				ModifiedInSchemaUId = new Guid("6a2487dd-c803-4bcf-903a-30355df9866b"),
				CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3")
			};
		}

		protected virtual EntitySchemaColumn CreateRelatedContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("32d2149b-3624-4f40-b59e-946eeb527e15"),
				Name = @"RelatedContact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("6a2487dd-c803-4bcf-903a-30355df9866b"),
				ModifiedInSchemaUId = new Guid("6a2487dd-c803-4bcf-903a-30355df9866b"),
				CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3")
			};
		}

		protected virtual EntitySchemaColumn CreateRelationTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("4ebcae2d-6185-458d-8d08-af63fa136cfe"),
				Name = @"RelationType",
				ReferenceSchemaUId = new Guid("fd62ea78-5401-4cbc-8a6c-c87d0c097e23"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("6a2487dd-c803-4bcf-903a-30355df9866b"),
				ModifiedInSchemaUId = new Guid("6a2487dd-c803-4bcf-903a-30355df9866b"),
				CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3")
			};
		}

		protected virtual EntitySchemaColumn CreateReverseRelationTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("65f16185-47e9-4fc2-abe3-65f2aa5b5b99"),
				Name = @"ReverseRelationType",
				ReferenceSchemaUId = new Guid("fd62ea78-5401-4cbc-8a6c-c87d0c097e23"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("6a2487dd-c803-4bcf-903a-30355df9866b"),
				ModifiedInSchemaUId = new Guid("6a2487dd-c803-4bcf-903a-30355df9866b"),
				CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3")
			};
		}

		protected virtual EntitySchemaColumn CreateActiveColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("ab47c488-344e-425d-a34c-3dec611f3dff"),
				Name = @"Active",
				CreatedInSchemaUId = new Guid("6a2487dd-c803-4bcf-903a-30355df9866b"),
				ModifiedInSchemaUId = new Guid("6a2487dd-c803-4bcf-903a-30355df9866b"),
				CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3")
			};
		}

		protected virtual EntitySchemaColumn CreateDescriptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("3d2d7c5b-613d-4aec-a9c1-49829503c027"),
				Name = @"Description",
				CreatedInSchemaUId = new Guid("6a2487dd-c803-4bcf-903a-30355df9866b"),
				ModifiedInSchemaUId = new Guid("6a2487dd-c803-4bcf-903a-30355df9866b"),
				CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3")
			};
		}

		protected virtual EntitySchemaColumn CreateRelatedObjectNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("28503d1b-16da-4ff0-a632-82255760ecde"),
				Name = @"RelatedObjectName",
				CreatedInSchemaUId = new Guid("6a2487dd-c803-4bcf-903a-30355df9866b"),
				ModifiedInSchemaUId = new Guid("6a2487dd-c803-4bcf-903a-30355df9866b"),
				CreatedInPackageId = new Guid("6919e88d-10ea-487b-a245-20d0cd99bafd")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwAccountRelationshipEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwAccountRelationshipEventsProcessSchema() {
			var schema = new VwAccountRelationshipEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwAccountRelationship(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwAccountRelationship_NUIEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwAccountRelationshipSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwAccountRelationshipSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6a2487dd-c803-4bcf-903a-30355df9866b"));
		}

		#endregion

	}

	#endregion

	#region Class: VwAccountRelationship

	/// <summary>
	/// Relationship of account (view).
	/// </summary>
	public class VwAccountRelationship : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public VwAccountRelationship(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwAccountRelationship";
		}

		public VwAccountRelationship(VwAccountRelationship source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid AccountId {
			get {
				return GetTypedColumnValue<Guid>("AccountId");
			}
			set {
				SetColumnValue("AccountId", value);
				_account = null;
			}
		}

		/// <exclude/>
		public string AccountName {
			get {
				return GetTypedColumnValue<string>("AccountName");
			}
			set {
				SetColumnValue("AccountName", value);
				if (_account != null) {
					_account.Name = value;
				}
			}
		}

		private Account _account;
		/// <summary>
		/// Account.
		/// </summary>
		public Account Account {
			get {
				return _account ??
					(_account = LookupColumnEntities.GetEntity("Account") as Account);
			}
		}

		/// <exclude/>
		public Guid RelatedAccountId {
			get {
				return GetTypedColumnValue<Guid>("RelatedAccountId");
			}
			set {
				SetColumnValue("RelatedAccountId", value);
				_relatedAccount = null;
			}
		}

		/// <exclude/>
		public string RelatedAccountName {
			get {
				return GetTypedColumnValue<string>("RelatedAccountName");
			}
			set {
				SetColumnValue("RelatedAccountName", value);
				if (_relatedAccount != null) {
					_relatedAccount.Name = value;
				}
			}
		}

		private Account _relatedAccount;
		/// <summary>
		/// Connected account.
		/// </summary>
		public Account RelatedAccount {
			get {
				return _relatedAccount ??
					(_relatedAccount = LookupColumnEntities.GetEntity("RelatedAccount") as Account);
			}
		}

		/// <exclude/>
		public Guid RelatedContactId {
			get {
				return GetTypedColumnValue<Guid>("RelatedContactId");
			}
			set {
				SetColumnValue("RelatedContactId", value);
				_relatedContact = null;
			}
		}

		/// <exclude/>
		public string RelatedContactName {
			get {
				return GetTypedColumnValue<string>("RelatedContactName");
			}
			set {
				SetColumnValue("RelatedContactName", value);
				if (_relatedContact != null) {
					_relatedContact.Name = value;
				}
			}
		}

		private Contact _relatedContact;
		/// <summary>
		/// Connected contact.
		/// </summary>
		public Contact RelatedContact {
			get {
				return _relatedContact ??
					(_relatedContact = LookupColumnEntities.GetEntity("RelatedContact") as Contact);
			}
		}

		/// <exclude/>
		public Guid RelationTypeId {
			get {
				return GetTypedColumnValue<Guid>("RelationTypeId");
			}
			set {
				SetColumnValue("RelationTypeId", value);
				_relationType = null;
			}
		}

		/// <exclude/>
		public string RelationTypeName {
			get {
				return GetTypedColumnValue<string>("RelationTypeName");
			}
			set {
				SetColumnValue("RelationTypeName", value);
				if (_relationType != null) {
					_relationType.Name = value;
				}
			}
		}

		private RelationType _relationType;
		/// <summary>
		/// Relationship type.
		/// </summary>
		public RelationType RelationType {
			get {
				return _relationType ??
					(_relationType = LookupColumnEntities.GetEntity("RelationType") as RelationType);
			}
		}

		/// <exclude/>
		public Guid ReverseRelationTypeId {
			get {
				return GetTypedColumnValue<Guid>("ReverseRelationTypeId");
			}
			set {
				SetColumnValue("ReverseRelationTypeId", value);
				_reverseRelationType = null;
			}
		}

		/// <exclude/>
		public string ReverseRelationTypeName {
			get {
				return GetTypedColumnValue<string>("ReverseRelationTypeName");
			}
			set {
				SetColumnValue("ReverseRelationTypeName", value);
				if (_reverseRelationType != null) {
					_reverseRelationType.Name = value;
				}
			}
		}

		private RelationType _reverseRelationType;
		/// <summary>
		/// Inverse relationship type.
		/// </summary>
		public RelationType ReverseRelationType {
			get {
				return _reverseRelationType ??
					(_reverseRelationType = LookupColumnEntities.GetEntity("ReverseRelationType") as RelationType);
			}
		}

		/// <summary>
		/// Actual.
		/// </summary>
		public bool Active {
			get {
				return GetTypedColumnValue<bool>("Active");
			}
			set {
				SetColumnValue("Active", value);
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

		/// <summary>
		/// Connected object.
		/// </summary>
		public string RelatedObjectName {
			get {
				return GetTypedColumnValue<string>("RelatedObjectName");
			}
			set {
				SetColumnValue("RelatedObjectName", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwAccountRelationship_NUIEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwAccountRelationshipDeleted", e);
			Inserting += (s, e) => ThrowEvent("VwAccountRelationshipInserting", e);
			Validating += (s, e) => ThrowEvent("VwAccountRelationshipValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwAccountRelationship(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwAccountRelationship_NUIEventsProcess

	/// <exclude/>
	public partial class VwAccountRelationship_NUIEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : VwAccountRelationship
	{

		public VwAccountRelationship_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwAccountRelationship_NUIEventsProcess";
			SchemaUId = new Guid("6a2487dd-c803-4bcf-903a-30355df9866b");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6a2487dd-c803-4bcf-903a-30355df9866b");
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
					SchemaElementUId = new Guid("b74adec4-71be-4778-af83-ac5037669624"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _vwAccountRelationshipDeletedStartMessage;
		public ProcessFlowElement VwAccountRelationshipDeletedStartMessage {
			get {
				return _vwAccountRelationshipDeletedStartMessage ?? (_vwAccountRelationshipDeletedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "VwAccountRelationshipDeletedStartMessage",
					SchemaElementUId = new Guid("ec581509-4ca5-47e6-bea9-b0b6db2b95c3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _vwAccountRelationshipDeletedScriptTask;
		public ProcessScriptTask VwAccountRelationshipDeletedScriptTask {
			get {
				return _vwAccountRelationshipDeletedScriptTask ?? (_vwAccountRelationshipDeletedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "VwAccountRelationshipDeletedScriptTask",
					SchemaElementUId = new Guid("c3e65b35-4793-4f69-8685-fb129e76b307"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = VwAccountRelationshipDeletedScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[VwAccountRelationshipDeletedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { VwAccountRelationshipDeletedStartMessage };
			FlowElements[VwAccountRelationshipDeletedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { VwAccountRelationshipDeletedScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "VwAccountRelationshipDeletedStartMessage":
						e.Context.QueueTasks.Enqueue("VwAccountRelationshipDeletedScriptTask");
						break;
					case "VwAccountRelationshipDeletedScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("VwAccountRelationshipDeletedStartMessage");
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
				case "VwAccountRelationshipDeletedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "VwAccountRelationshipDeletedStartMessage";
					result = VwAccountRelationshipDeletedStartMessage.Execute(context);
					break;
				case "VwAccountRelationshipDeletedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "VwAccountRelationshipDeletedScriptTask";
					result = VwAccountRelationshipDeletedScriptTask.Execute(context, VwAccountRelationshipDeletedScriptTaskExecute);
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

		public virtual bool VwAccountRelationshipDeletedScriptTaskExecute(ProcessExecutingContext context) {
			ClearAccountParentId();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "VwAccountRelationshipDeleted":
							if (ActivatedEventElements.Contains("VwAccountRelationshipDeletedStartMessage")) {
							context.QueueTasks.Enqueue("VwAccountRelationshipDeletedStartMessage");
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

	#region Class: VwAccountRelationship_NUIEventsProcess

	/// <exclude/>
	public class VwAccountRelationship_NUIEventsProcess : VwAccountRelationship_NUIEventsProcess<VwAccountRelationship>
	{

		public VwAccountRelationship_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwAccountRelationship_NUIEventsProcess

	public partial class VwAccountRelationship_NUIEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual Guid GetParentRelationTypeId() {
			return (Guid)Terrasoft.Core.Configuration.SysSettings.GetValue(UserConnection, "ParentAccountRelationType");
		}

		public virtual void ClearAccountParentId() {
			var relationTypeId = Entity.GetTypedColumnValue<Guid>("RelationTypeId");
			var reverseRelationTypeId = Entity.GetTypedColumnValue<Guid>("ReverseRelationTypeId");
			var accountId = Entity.GetTypedColumnValue<Guid>("AccountId");
			var relatedAccountId = Entity.GetTypedColumnValue<Guid>("RelatedAccountId");
			Guid childAccountId = Guid.Empty;
			
			if (accountId != Guid.Empty && relatedAccountId != Guid.Empty) {
				if (relationTypeId == GetParentRelationTypeId()) {
					childAccountId = relatedAccountId;
				} else if (reverseRelationTypeId == GetParentRelationTypeId()) {
					childAccountId = accountId;
				}
				if (childAccountId != Guid.Empty) {
					Update updateAccountQuery = new Update(UserConnection, "Account");
					updateAccountQuery.Set("ParentId", Column.Const(null));
					updateAccountQuery.Where("Id").IsEqual(Column.Parameter(childAccountId));
					updateAccountQuery.Execute();
				}
			}
		}

		#endregion

	}

	#endregion

	#region Class: VwAccountRelationshipEventsProcessSchema

	/// <exclude/>
	public class VwAccountRelationshipEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public VwAccountRelationshipEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwAccountRelationshipEventsProcessSchema(VwAccountRelationshipEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwAccountRelationship_NUIEventsProcess";
			UId = new Guid("ee0e3448-ae60-4069-b450-81fe613683bf");
			CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3");
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
			ProcessSchemaStartMessageEvent vwaccountrelationshipdeletedstartmessage = CreateVwAccountRelationshipDeletedStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(vwaccountrelationshipdeletedstartmessage);
			ProcessSchemaScriptTask vwaccountrelationshipdeletedscripttask = CreateVwAccountRelationshipDeletedScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(vwaccountrelationshipdeletedscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("d0b64ca8-1a73-482b-bdc4-87a66f382465"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("78a9f3f2-8123-4786-999c-8bf3dee2454f"),
				CreatedInSchemaUId = new Guid("ee0e3448-ae60-4069-b450-81fe613683bf"),
				CurveCenterPosition = new Point(212, 94),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ee0e3448-ae60-4069-b450-81fe613683bf"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ec581509-4ca5-47e6-bea9-b0b6db2b95c3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c3e65b35-4793-4f69-8685-fb129e76b307"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("0210cdd8-98da-4a23-bf80-3c4d30d36dbe"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("78a9f3f2-8123-4786-999c-8bf3dee2454f"),
				CreatedInSchemaUId = new Guid("ee0e3448-ae60-4069-b450-81fe613683bf"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("ee0e3448-ae60-4069-b450-81fe613683bf"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(792, 177),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("cf103782-c044-4104-8395-4958a43bcb68"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("0210cdd8-98da-4a23-bf80-3c4d30d36dbe"),
				CreatedInOwnerSchemaUId = new Guid("6a2487dd-c803-4bcf-903a-30355df9866b"),
				CreatedInPackageId = new Guid("78a9f3f2-8123-4786-999c-8bf3dee2454f"),
				CreatedInSchemaUId = new Guid("ee0e3448-ae60-4069-b450-81fe613683bf"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("ee0e3448-ae60-4069-b450-81fe613683bf"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(763, 177),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b74adec4-71be-4778-af83-ac5037669624"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cf103782-c044-4104-8395-4958a43bcb68"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("78a9f3f2-8123-4786-999c-8bf3dee2454f"),
				CreatedInSchemaUId = new Guid("ee0e3448-ae60-4069-b450-81fe613683bf"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ee0e3448-ae60-4069-b450-81fe613683bf"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(43, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(518, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateVwAccountRelationshipDeletedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ec581509-4ca5-47e6-bea9-b0b6db2b95c3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b74adec4-71be-4778-af83-ac5037669624"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("78a9f3f2-8123-4786-999c-8bf3dee2454f"),
				CreatedInSchemaUId = new Guid("ee0e3448-ae60-4069-b450-81fe613683bf"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"VwAccountRelationshipDeleted",
				ModifiedInSchemaUId = new Guid("ee0e3448-ae60-4069-b450-81fe613683bf"),
				Name = @"VwAccountRelationshipDeletedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(35, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateVwAccountRelationshipDeletedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c3e65b35-4793-4f69-8685-fb129e76b307"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b74adec4-71be-4778-af83-ac5037669624"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("78a9f3f2-8123-4786-999c-8bf3dee2454f"),
				CreatedInSchemaUId = new Guid("ee0e3448-ae60-4069-b450-81fe613683bf"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ee0e3448-ae60-4069-b450-81fe613683bf"),
				Name = @"VwAccountRelationshipDeletedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(196, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,206,73,77,44,114,76,78,206,47,205,43,9,72,44,74,205,43,241,76,209,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,213,122,245,150,37,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetParentRelationTypeIdMethod());
			Methods.Add(CreateClearAccountParentIdMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3")
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

		protected virtual SchemaMethod CreateGetParentRelationTypeIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d924551d-76e3-4140-aecf-91b03a2a5aee"),
				Name = "GetParentRelationTypeId",
				CreatedInSchemaUId = new Guid("ee0e3448-ae60-4069-b450-81fe613683bf"),
				CreatedInPackageId = new Guid("78a9f3f2-8123-4786-999c-8bf3dee2454f"),
				ResultValueTypeName = "Guid"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,29,203,59,10,128,48,16,69,209,173,136,149,130,100,3,86,98,145,86,252,245,33,190,72,64,38,50,153,41,178,123,63,205,173,206,101,136,50,85,141,213,120,180,43,152,93,78,65,204,152,24,111,40,196,83,217,73,76,100,150,146,23,136,68,58,179,177,144,221,93,138,102,203,224,151,17,252,103,186,170,158,28,131,100,240,62,41,201,140,235,127,215,114,163,110,251,7,229,186,181,252,108,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateClearAccountParentIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f6bfe059-9f8b-427d-8643-f3471c28f3e5"),
				Name = "ClearAccountParentId",
				CreatedInSchemaUId = new Guid("ee0e3448-ae60-4069-b450-81fe613683bf"),
				CreatedInPackageId = new Guid("78a9f3f2-8123-4786-999c-8bf3dee2454f"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,145,81,107,131,48,20,133,159,227,175,184,243,161,68,40,254,1,183,65,41,82,250,182,185,117,123,14,122,71,133,24,93,188,113,147,209,255,190,68,43,173,218,194,186,167,64,238,57,95,206,205,105,132,6,141,82,80,94,170,215,182,194,109,6,15,16,43,202,169,13,55,72,238,42,91,151,210,20,234,77,72,131,247,27,147,103,143,220,79,70,22,63,136,188,166,3,53,168,107,76,254,195,187,224,28,176,34,77,75,163,232,143,168,213,160,62,165,178,80,204,86,55,81,146,137,201,193,220,8,210,125,46,71,44,119,27,198,69,69,109,228,121,249,7,240,83,220,187,243,41,44,22,243,40,35,69,0,63,30,115,132,105,33,86,132,244,36,52,42,26,255,16,15,58,15,155,133,154,62,20,121,236,0,40,107,132,158,127,177,167,219,159,17,231,252,62,251,68,51,95,144,237,170,204,102,3,211,29,71,229,179,65,221,90,160,194,47,232,231,124,87,163,94,151,74,97,234,130,44,97,40,214,53,193,216,220,29,190,32,113,191,143,111,251,90,66,223,106,104,25,53,113,101,164,12,174,57,223,247,168,145,251,174,229,112,91,199,159,70,72,126,116,91,158,40,144,80,79,22,187,202,138,191,49,53,54,126,208,125,201,225,23,138,20,50,4,96,3,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwAccountRelationshipEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ee0e3448-ae60-4069-b450-81fe613683bf"));
		}

		#endregion

	}

	#endregion


	#region Class: VwAccountRelationshipEventsProcess

	/// <exclude/>
	public class VwAccountRelationshipEventsProcess : VwAccountRelationship_NUIEventsProcess
	{

		public VwAccountRelationshipEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

