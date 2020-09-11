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

	#region Class: RelationshipSchema

	/// <exclude/>
	public class RelationshipSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public RelationshipSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public RelationshipSchema(RelationshipSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public RelationshipSchema(RelationshipSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("533e9db5-b10c-44a9-bbef-168af653d2d5");
			RealUId = new Guid("533e9db5-b10c-44a9-bbef-168af653d2d5");
			Name = "Relationship";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("a2053f3d-ed48-45cb-abf1-054daa988f76")) == null) {
				Columns.Add(CreateRelationTypeColumn());
			}
			if (Columns.FindByUId(new Guid("02c1f1b3-301f-4888-a7a4-2b78250eb5bb")) == null) {
				Columns.Add(CreateReverseRelationTypeColumn());
			}
			if (Columns.FindByUId(new Guid("55b05a23-2493-4ed3-8427-933390c09045")) == null) {
				Columns.Add(CreateActiveColumn());
			}
			if (Columns.FindByUId(new Guid("3fbe0cad-7567-4321-83b2-b3eabda01fdc")) == null) {
				Columns.Add(CreateDescriptionColumn());
			}
			if (Columns.FindByUId(new Guid("88fb424c-9256-4164-a30f-b926f42725d3")) == null) {
				Columns.Add(CreateAccountAColumn());
			}
			if (Columns.FindByUId(new Guid("7c3362ec-7c34-431e-b28d-734922452ef0")) == null) {
				Columns.Add(CreateContactAColumn());
			}
			if (Columns.FindByUId(new Guid("404af122-1f0d-4765-bee8-2d5401fedc9e")) == null) {
				Columns.Add(CreateAccountBColumn());
			}
			if (Columns.FindByUId(new Guid("74441e5a-2ea1-4fd5-821b-d0cd5be78751")) == null) {
				Columns.Add(CreateContactBColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateRelationTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a2053f3d-ed48-45cb-abf1-054daa988f76"),
				Name = @"RelationType",
				ReferenceSchemaUId = new Guid("fd62ea78-5401-4cbc-8a6c-c87d0c097e23"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("533e9db5-b10c-44a9-bbef-168af653d2d5"),
				ModifiedInSchemaUId = new Guid("533e9db5-b10c-44a9-bbef-168af653d2d5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateReverseRelationTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("02c1f1b3-301f-4888-a7a4-2b78250eb5bb"),
				Name = @"ReverseRelationType",
				ReferenceSchemaUId = new Guid("fd62ea78-5401-4cbc-8a6c-c87d0c097e23"),
				CreatedInSchemaUId = new Guid("533e9db5-b10c-44a9-bbef-168af653d2d5"),
				ModifiedInSchemaUId = new Guid("533e9db5-b10c-44a9-bbef-168af653d2d5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateActiveColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("55b05a23-2493-4ed3-8427-933390c09045"),
				Name = @"Active",
				CreatedInSchemaUId = new Guid("533e9db5-b10c-44a9-bbef-168af653d2d5"),
				ModifiedInSchemaUId = new Guid("533e9db5-b10c-44a9-bbef-168af653d2d5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateDescriptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("3fbe0cad-7567-4321-83b2-b3eabda01fdc"),
				Name = @"Description",
				CreatedInSchemaUId = new Guid("533e9db5-b10c-44a9-bbef-168af653d2d5"),
				ModifiedInSchemaUId = new Guid("533e9db5-b10c-44a9-bbef-168af653d2d5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateAccountAColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("88fb424c-9256-4164-a30f-b926f42725d3"),
				Name = @"AccountA",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("533e9db5-b10c-44a9-bbef-168af653d2d5"),
				ModifiedInSchemaUId = new Guid("533e9db5-b10c-44a9-bbef-168af653d2d5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateContactAColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("7c3362ec-7c34-431e-b28d-734922452ef0"),
				Name = @"ContactA",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("533e9db5-b10c-44a9-bbef-168af653d2d5"),
				ModifiedInSchemaUId = new Guid("533e9db5-b10c-44a9-bbef-168af653d2d5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateAccountBColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("404af122-1f0d-4765-bee8-2d5401fedc9e"),
				Name = @"AccountB",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("533e9db5-b10c-44a9-bbef-168af653d2d5"),
				ModifiedInSchemaUId = new Guid("533e9db5-b10c-44a9-bbef-168af653d2d5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateContactBColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("74441e5a-2ea1-4fd5-821b-d0cd5be78751"),
				Name = @"ContactB",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("533e9db5-b10c-44a9-bbef-168af653d2d5"),
				ModifiedInSchemaUId = new Guid("533e9db5-b10c-44a9-bbef-168af653d2d5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateRelationshipEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateRelationshipEventsProcessSchema() {
			var schema = new RelationshipEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Relationship(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Relationship_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new RelationshipSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new RelationshipSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("533e9db5-b10c-44a9-bbef-168af653d2d5"));
		}

		#endregion

	}

	#endregion

	#region Class: Relationship

	/// <summary>
	/// Relationship.
	/// </summary>
	public class Relationship : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public Relationship(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Relationship";
		}

		public Relationship(Relationship source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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

		/// <exclude/>
		public Guid AccountAId {
			get {
				return GetTypedColumnValue<Guid>("AccountAId");
			}
			set {
				SetColumnValue("AccountAId", value);
				_accountA = null;
			}
		}

		/// <exclude/>
		public string AccountAName {
			get {
				return GetTypedColumnValue<string>("AccountAName");
			}
			set {
				SetColumnValue("AccountAName", value);
				if (_accountA != null) {
					_accountA.Name = value;
				}
			}
		}

		private Account _accountA;
		/// <summary>
		/// Account A.
		/// </summary>
		public Account AccountA {
			get {
				return _accountA ??
					(_accountA = LookupColumnEntities.GetEntity("AccountA") as Account);
			}
		}

		/// <exclude/>
		public Guid ContactAId {
			get {
				return GetTypedColumnValue<Guid>("ContactAId");
			}
			set {
				SetColumnValue("ContactAId", value);
				_contactA = null;
			}
		}

		/// <exclude/>
		public string ContactAName {
			get {
				return GetTypedColumnValue<string>("ContactAName");
			}
			set {
				SetColumnValue("ContactAName", value);
				if (_contactA != null) {
					_contactA.Name = value;
				}
			}
		}

		private Contact _contactA;
		/// <summary>
		/// Contact A.
		/// </summary>
		public Contact ContactA {
			get {
				return _contactA ??
					(_contactA = LookupColumnEntities.GetEntity("ContactA") as Contact);
			}
		}

		/// <exclude/>
		public Guid AccountBId {
			get {
				return GetTypedColumnValue<Guid>("AccountBId");
			}
			set {
				SetColumnValue("AccountBId", value);
				_accountB = null;
			}
		}

		/// <exclude/>
		public string AccountBName {
			get {
				return GetTypedColumnValue<string>("AccountBName");
			}
			set {
				SetColumnValue("AccountBName", value);
				if (_accountB != null) {
					_accountB.Name = value;
				}
			}
		}

		private Account _accountB;
		/// <summary>
		/// Account B.
		/// </summary>
		public Account AccountB {
			get {
				return _accountB ??
					(_accountB = LookupColumnEntities.GetEntity("AccountB") as Account);
			}
		}

		/// <exclude/>
		public Guid ContactBId {
			get {
				return GetTypedColumnValue<Guid>("ContactBId");
			}
			set {
				SetColumnValue("ContactBId", value);
				_contactB = null;
			}
		}

		/// <exclude/>
		public string ContactBName {
			get {
				return GetTypedColumnValue<string>("ContactBName");
			}
			set {
				SetColumnValue("ContactBName", value);
				if (_contactB != null) {
					_contactB.Name = value;
				}
			}
		}

		private Contact _contactB;
		/// <summary>
		/// Contact B.
		/// </summary>
		public Contact ContactB {
			get {
				return _contactB ??
					(_contactB = LookupColumnEntities.GetEntity("ContactB") as Contact);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Relationship_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("RelationshipDeleted", e);
			Deleting += (s, e) => ThrowEvent("RelationshipDeleting", e);
			Inserted += (s, e) => ThrowEvent("RelationshipInserted", e);
			Inserting += (s, e) => ThrowEvent("RelationshipInserting", e);
			Saved += (s, e) => ThrowEvent("RelationshipSaved", e);
			Saving += (s, e) => ThrowEvent("RelationshipSaving", e);
			Validating += (s, e) => ThrowEvent("RelationshipValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Relationship(this);
		}

		#endregion

	}

	#endregion

	#region Class: Relationship_BaseEventsProcess

	/// <exclude/>
	public partial class Relationship_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : Relationship
	{

		public Relationship_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Relationship_BaseEventsProcess";
			SchemaUId = new Guid("533e9db5-b10c-44a9-bbef-168af653d2d5");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("533e9db5-b10c-44a9-bbef-168af653d2d5");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual Guid ChildAccountId {
			get;
			set;
		}

		public virtual Guid OldChildAccountId {
			get;
			set;
		}

		public virtual Guid ParentAccountId {
			get;
			set;
		}

		public virtual Guid OldParentAccountId {
			get;
			set;
		}

		public virtual Guid RelationTypeId {
			get;
			set;
		}

		public virtual Guid OldRelationTypeId {
			get;
			set;
		}

		public virtual Guid ReverseRelationTypeId {
			get;
			set;
		}

		public virtual Guid OldReverseRelationTypeId {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess1;
		public ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("8db64475-8492-4ef2-8c07-3561a75ea878"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _relationshipInsertingStartMessage;
		public ProcessFlowElement RelationshipInsertingStartMessage {
			get {
				return _relationshipInsertingStartMessage ?? (_relationshipInsertingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "RelationshipInsertingStartMessage",
					SchemaElementUId = new Guid("c7c50777-0f61-4f22-9927-a707a6fcb028"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _checkParentAccountExistScriptTask;
		public ProcessScriptTask CheckParentAccountExistScriptTask {
			get {
				return _checkParentAccountExistScriptTask ?? (_checkParentAccountExistScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CheckParentAccountExistScriptTask",
					SchemaElementUId = new Guid("9b65e755-de5c-4faf-bdc6-211bd7fe78e8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CheckParentAccountExistScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess2;
		public ProcessFlowElement EventSubProcess2 {
			get {
				return _eventSubProcess2 ?? (_eventSubProcess2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess2",
					SchemaElementUId = new Guid("1c2c0fd5-f223-4b15-ba35-f632fe7bcf8e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _relationshipInsertedStartMessage;
		public ProcessFlowElement RelationshipInsertedStartMessage {
			get {
				return _relationshipInsertedStartMessage ?? (_relationshipInsertedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "RelationshipInsertedStartMessage",
					SchemaElementUId = new Guid("437ca897-5a90-473b-9292-f7fa2ae06d3f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _relationshipInsertedScriptTask;
		public ProcessScriptTask RelationshipInsertedScriptTask {
			get {
				return _relationshipInsertedScriptTask ?? (_relationshipInsertedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "RelationshipInsertedScriptTask",
					SchemaElementUId = new Guid("e4d8fc41-5e0e-4765-b4b5-0a32ea9fc154"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = RelationshipInsertedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess3;
		public ProcessFlowElement EventSubProcess3 {
			get {
				return _eventSubProcess3 ?? (_eventSubProcess3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3",
					SchemaElementUId = new Guid("c5e3b5b4-70f1-4b35-9dbd-f61e9f9480cb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _relationshipSavingStartMessage;
		public ProcessFlowElement RelationshipSavingStartMessage {
			get {
				return _relationshipSavingStartMessage ?? (_relationshipSavingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "RelationshipSavingStartMessage",
					SchemaElementUId = new Guid("83cc73a5-0002-42c1-b21b-50b86bc43b80"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _relationshipSavingScriptTask;
		public ProcessScriptTask RelationshipSavingScriptTask {
			get {
				return _relationshipSavingScriptTask ?? (_relationshipSavingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "RelationshipSavingScriptTask",
					SchemaElementUId = new Guid("d53e8f53-8f1d-4c63-8aa7-92b7d16c9ed1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = RelationshipSavingScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess4;
		public ProcessFlowElement EventSubProcess4 {
			get {
				return _eventSubProcess4 ?? (_eventSubProcess4 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess4",
					SchemaElementUId = new Guid("a8d95e40-b56a-49c3-a1d8-3a59ef4b59ea"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _relationshipSavedStartMessage;
		public ProcessFlowElement RelationshipSavedStartMessage {
			get {
				return _relationshipSavedStartMessage ?? (_relationshipSavedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "RelationshipSavedStartMessage",
					SchemaElementUId = new Guid("3a8fe39f-97ee-4871-9937-bf6f5eb9f7f8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _relationshipSavedScriptTask;
		public ProcessScriptTask RelationshipSavedScriptTask {
			get {
				return _relationshipSavedScriptTask ?? (_relationshipSavedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "RelationshipSavedScriptTask",
					SchemaElementUId = new Guid("4c3e46b3-9c2c-4261-8637-db8c59aa3233"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = RelationshipSavedScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[RelationshipInsertingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { RelationshipInsertingStartMessage };
			FlowElements[CheckParentAccountExistScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckParentAccountExistScriptTask };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[RelationshipInsertedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { RelationshipInsertedStartMessage };
			FlowElements[RelationshipInsertedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { RelationshipInsertedScriptTask };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[RelationshipSavingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { RelationshipSavingStartMessage };
			FlowElements[RelationshipSavingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { RelationshipSavingScriptTask };
			FlowElements[EventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4 };
			FlowElements[RelationshipSavedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { RelationshipSavedStartMessage };
			FlowElements[RelationshipSavedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { RelationshipSavedScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "RelationshipInsertingStartMessage":
						e.Context.QueueTasks.Enqueue("CheckParentAccountExistScriptTask");
						break;
					case "CheckParentAccountExistScriptTask":
						break;
					case "EventSubProcess2":
						break;
					case "RelationshipInsertedStartMessage":
						e.Context.QueueTasks.Enqueue("RelationshipInsertedScriptTask");
						break;
					case "RelationshipInsertedScriptTask":
						break;
					case "EventSubProcess3":
						break;
					case "RelationshipSavingStartMessage":
						e.Context.QueueTasks.Enqueue("RelationshipSavingScriptTask");
						break;
					case "RelationshipSavingScriptTask":
						break;
					case "EventSubProcess4":
						break;
					case "RelationshipSavedStartMessage":
						e.Context.QueueTasks.Enqueue("RelationshipSavedScriptTask");
						break;
					case "RelationshipSavedScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("RelationshipInsertingStartMessage");
			ActivatedEventElements.Add("RelationshipInsertedStartMessage");
			ActivatedEventElements.Add("RelationshipSavingStartMessage");
			ActivatedEventElements.Add("RelationshipSavedStartMessage");
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
				case "RelationshipInsertingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "RelationshipInsertingStartMessage";
					result = RelationshipInsertingStartMessage.Execute(context);
					break;
				case "CheckParentAccountExistScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CheckParentAccountExistScriptTask";
					result = CheckParentAccountExistScriptTask.Execute(context, CheckParentAccountExistScriptTaskExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "RelationshipInsertedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "RelationshipInsertedStartMessage";
					result = RelationshipInsertedStartMessage.Execute(context);
					break;
				case "RelationshipInsertedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "RelationshipInsertedScriptTask";
					result = RelationshipInsertedScriptTask.Execute(context, RelationshipInsertedScriptTaskExecute);
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "RelationshipSavingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "RelationshipSavingStartMessage";
					result = RelationshipSavingStartMessage.Execute(context);
					break;
				case "RelationshipSavingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "RelationshipSavingScriptTask";
					result = RelationshipSavingScriptTask.Execute(context, RelationshipSavingScriptTaskExecute);
					break;
				case "EventSubProcess4":
					context.QueueTasks.Dequeue();
					break;
				case "RelationshipSavedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "RelationshipSavedStartMessage";
					result = RelationshipSavedStartMessage.Execute(context);
					break;
				case "RelationshipSavedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "RelationshipSavedScriptTask";
					result = RelationshipSavedScriptTask.Execute(context, RelationshipSavedScriptTaskExecute);
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
				case "OldReverseRelationTypeId":
					OldReverseRelationTypeId = reader.GetValue<System.Guid>();
				break;
				case "ReverseRelationTypeId":
					ReverseRelationTypeId = reader.GetValue<System.Guid>();
				break;
				case "OldRelationTypeId":
					OldRelationTypeId = reader.GetValue<System.Guid>();
				break;
				case "RelationTypeId":
					RelationTypeId = reader.GetValue<System.Guid>();
				break;
				case "OldParentAccountId":
					OldParentAccountId = reader.GetValue<System.Guid>();
				break;
				case "ParentAccountId":
					ParentAccountId = reader.GetValue<System.Guid>();
				break;
				case "OldChildAccountId":
					OldChildAccountId = reader.GetValue<System.Guid>();
				break;
				case "ChildAccountId":
					ChildAccountId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool CheckParentAccountExistScriptTaskExecute(ProcessExecutingContext context) {
			if (CheckParentAccountExist()) {
				((Terrasoft.Core.Entities.EntityBeforeEventArgs)(context.ThrowEventArgs)).IsCanceled = true;
			}
			return true;
		}

		public virtual bool RelationshipInsertedScriptTaskExecute(ProcessExecutingContext context) {
			UpdateAccountAfterRelationshipInserted();
			return true;
		}

		public virtual bool RelationshipSavingScriptTaskExecute(ProcessExecutingContext context) {
			SetParametersBeforeSaving();
			return true;
		}

		public virtual bool RelationshipSavedScriptTaskExecute(ProcessExecutingContext context) {
			UpdateAccountAfterRelationshipSaved();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "RelationshipInserting":
							if (ActivatedEventElements.Contains("RelationshipInsertingStartMessage")) {
							context.QueueTasks.Enqueue("RelationshipInsertingStartMessage");
						}
						break;
					case "RelationshipInserted":
							if (ActivatedEventElements.Contains("RelationshipInsertedStartMessage")) {
							context.QueueTasks.Enqueue("RelationshipInsertedStartMessage");
						}
						break;
					case "RelationshipSaving":
							if (ActivatedEventElements.Contains("RelationshipSavingStartMessage")) {
							context.QueueTasks.Enqueue("RelationshipSavingStartMessage");
						}
						break;
					case "RelationshipSaved":
							if (ActivatedEventElements.Contains("RelationshipSavedStartMessage")) {
							context.QueueTasks.Enqueue("RelationshipSavedStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("OldReverseRelationTypeId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("OldReverseRelationTypeId", OldReverseRelationTypeId, Guid.Empty);
			}
			if (!HasMapping("ReverseRelationTypeId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ReverseRelationTypeId", ReverseRelationTypeId, Guid.Empty);
			}
			if (!HasMapping("OldRelationTypeId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("OldRelationTypeId", OldRelationTypeId, Guid.Empty);
			}
			if (!HasMapping("RelationTypeId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("RelationTypeId", RelationTypeId, Guid.Empty);
			}
			if (!HasMapping("OldParentAccountId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("OldParentAccountId", OldParentAccountId, Guid.Empty);
			}
			if (!HasMapping("ParentAccountId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ParentAccountId", ParentAccountId, Guid.Empty);
			}
			if (!HasMapping("OldChildAccountId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("OldChildAccountId", OldChildAccountId, Guid.Empty);
			}
			if (!HasMapping("ChildAccountId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ChildAccountId", ChildAccountId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: Relationship_BaseEventsProcess

	/// <exclude/>
	public class Relationship_BaseEventsProcess : Relationship_BaseEventsProcess<Relationship>
	{

		public Relationship_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Relationship_BaseEventsProcess

	public partial class Relationship_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual Guid GetParentRelationTypeId() {
			return new Guid("{FB3A75D3-5FE6-DF11-971B-001D60E938C6}");
		}

		public virtual Guid GetReverseRelationshipTypeId() {
			return new Guid("{1ED655F3-5FE6-DF11-971B-001D60E938C6}");
		}

		public virtual bool CheckParentAccountExist() {
			bool result = false;
			Guid relationTypeId = Entity.GetTypedColumnValue<Guid>("RelationTypeId");
			Guid reverseRelationTypeId = Entity.GetTypedColumnValue<Guid>("ReverseRelationTypeId");
			Guid accountId = Guid.Empty;
			if (relationTypeId == GetParentRelationTypeId()) {
				accountId = Entity.GetTypedColumnValue<Guid>("AccountAId");
			} else if (reverseRelationTypeId == GetParentRelationTypeId()) {
				accountId = Entity.GetTypedColumnValue<Guid>("AccountBId");
			}
			if (accountId != Guid.Empty) {
				var select =(Select)new Select(UserConnection)
					.Column(Func.Count(Column.Asterisk()))
					.From("VwAccountRelationship")
					.Where("AccountId").IsEqual(Column.Parameter(accountId))
					.And("RelationTypeId").IsEqual(Column.Parameter(GetParentRelationTypeId()));
				using (DBExecutor executor = UserConnection.EnsureDBConnection()) {
					int relationshipCount = select.ExecuteScalar<Int32>(executor);
					if (relationshipCount != 0) {
						result = true;
					}
				}
			}
			return result;
		}

		public virtual void UpdateAccount(Guid id, object parentId) {
			Update updateAccountQuery = new Update(UserConnection, "Account");
			if (parentId == null) {
				updateAccountQuery.Set("ParentId", Column.Const(null));
			} else if (parentId is Guid) {
				updateAccountQuery.Set("ParentId", Column.Parameter((Guid)parentId));
			}
			updateAccountQuery.Where("Id").IsEqual(Column.Parameter(id));
			updateAccountQuery.Execute();
		}

		public virtual Guid GetChildAccountId(Guid accountAId, Guid accountBId, Guid relationTypeId, Guid reverseRelationTypeId) {
			if (relationTypeId == GetParentRelationTypeId()) {
				return accountAId;
			} else if (reverseRelationTypeId == GetParentRelationTypeId()) {
				return accountBId;
			}
			return Guid.Empty;
		}

		public virtual Guid GetParentAccountId(Guid accountAId, Guid accountBId, Guid relationTypeId, Guid reverseRelationTypeId) {
			if (relationTypeId == GetParentRelationTypeId()) {
				return accountBId;
			} else if (reverseRelationTypeId == GetParentRelationTypeId()) {
				return accountAId;
			}
			return Guid.Empty;
		}

		public virtual void UpdateAccountAfterRelationshipInserted() {
			Guid relationTypeId = Entity.GetTypedColumnValue<Guid>("RelationTypeId");
			Guid reverseRelationTypeId = Entity.GetTypedColumnValue<Guid>("ReverseRelationTypeId");
			Guid childAccountId =  GetChildAccountId(
				Entity.GetTypedColumnValue<Guid>("AccountAId"),
				Entity.GetTypedColumnValue<Guid>("AccountBId"),
				relationTypeId,
				reverseRelationTypeId
			);
			Guid parentAccountId =  GetParentAccountId(
				Entity.GetTypedColumnValue<Guid>("AccountAId"),
				Entity.GetTypedColumnValue<Guid>("AccountBId"),
				relationTypeId,
				reverseRelationTypeId
			);
			if (childAccountId != Guid.Empty && parentAccountId != Guid.Empty) {
				UpdateAccount(childAccountId, parentAccountId);
			}
		}

		public virtual void UpdateAccountAfterRelationshipSaved() {
			Guid relationTypeId = RelationTypeId;
			Guid reverseRelationTypeId = ReverseRelationTypeId;
			Guid oldRelationTypeId = OldRelationTypeId;
			Guid oldReverseRelationTypeId = OldReverseRelationTypeId;
			Guid childAccountId = ChildAccountId;
			Guid oldChildAccountId = OldChildAccountId;
			Guid parentAccountId = ParentAccountId;
			Guid oldParentAccountId = OldParentAccountId;
			
			if ((childAccountId != Guid.Empty || oldChildAccountId != Guid.Empty)
				&& (parentAccountId != Guid.Empty || oldParentAccountId != Guid.Empty)) {
				bool isRelationTypeChanged = false;
			
				if ((relationTypeId != oldRelationTypeId && oldRelationTypeId != Guid.Empty)
					|| (reverseRelationTypeId != oldReverseRelationTypeId && oldReverseRelationTypeId != Guid.Empty)) {
					isRelationTypeChanged = true;
				}
				if (!isRelationTypeChanged) {
					if (oldChildAccountId != childAccountId) {
						// Изменился дочерний контрагент (или дочерний и родительский)
						UpdateAccount(oldChildAccountId, null);
						UpdateAccount(childAccountId, parentAccountId);
					} else if (oldParentAccountId != parentAccountId) {
						// Изменился родительский контрагент
						UpdateAccount(childAccountId, parentAccountId);
					}
				}
				// Изменилась взаимосвязь
				if (isRelationTypeChanged) {
					if (relationTypeId != GetParentRelationTypeId() && reverseRelationTypeId != GetParentRelationTypeId()) {
						// Головной/Дочерний -> Нехолдингообразующий
						UpdateAccount(oldChildAccountId, null);
					} if (relationTypeId == GetParentRelationTypeId() || reverseRelationTypeId == GetParentRelationTypeId()) {
						// Головной/Дочерний <-> Дочерний/Головной
						UpdateAccount(oldChildAccountId, null);
						UpdateAccount(childAccountId, parentAccountId);
					} else if (oldRelationTypeId != GetParentRelationTypeId() && oldReverseRelationTypeId != GetParentRelationTypeId()) {
						// Нехолдингообразующий -> Головной/Дочерний
						UpdateAccount(childAccountId, parentAccountId);
					}
				}
			}
		}

		public virtual void SetParametersBeforeSaving() {
			RelationTypeId = Entity.GetTypedColumnValue<Guid>("RelationTypeId");
			ReverseRelationTypeId = Entity.GetTypedColumnValue<Guid>("ReverseRelationTypeId");
			OldRelationTypeId = Entity.GetTypedOldColumnValue<Guid>("RelationTypeId");
			OldReverseRelationTypeId = Entity.GetTypedOldColumnValue<Guid>("ReverseRelationTypeId");
			ChildAccountId = GetChildAccountId(
				Entity.GetTypedColumnValue<Guid>("AccountAId"),
				Entity.GetTypedColumnValue<Guid>("AccountBId"),
				RelationTypeId,
				ReverseRelationTypeId
			);
			OldChildAccountId = GetChildAccountId(
				Entity.GetTypedOldColumnValue<Guid>("AccountAId"),
				Entity.GetTypedOldColumnValue<Guid>("AccountBId"),
				OldRelationTypeId,
				OldReverseRelationTypeId
			);
			ParentAccountId = GetParentAccountId(
				Entity.GetTypedColumnValue<Guid>("AccountAId"),
				Entity.GetTypedColumnValue<Guid>("AccountBId"),
				RelationTypeId,
				ReverseRelationTypeId
			);
			OldParentAccountId = GetParentAccountId(
				Entity.GetTypedOldColumnValue<Guid>("AccountAId"),
				Entity.GetTypedOldColumnValue<Guid>("AccountBId"),
				OldRelationTypeId,
				OldReverseRelationTypeId
			);
		}

		#endregion

	}

	#endregion

	#region Class: RelationshipEventsProcessSchema

	/// <exclude/>
	public class RelationshipEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public RelationshipEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public RelationshipEventsProcessSchema(RelationshipEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Relationship_BaseEventsProcess";
			UId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4");
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

		protected virtual ProcessSchemaParameter CreateChildAccountIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a6fbbc81-281a-42d8-a502-59823e19f354"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Name = @"ChildAccountId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateOldChildAccountIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6005d21c-43c3-44ab-866b-8c0bf2b67d78"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Name = @"OldChildAccountId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateParentAccountIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("0199b876-8b97-4e8b-b1cc-2d9d2b580024"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Name = @"ParentAccountId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateOldParentAccountIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ecc27a0d-1ae5-445c-b08a-3c390e11716c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Name = @"OldParentAccountId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateRelationTypeIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("120c1cc9-6539-4038-9eb8-7c7cd4c3b247"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Name = @"RelationTypeId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateOldRelationTypeIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7167966d-ef82-45c8-88bb-5011d45fb92e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Name = @"OldRelationTypeId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateReverseRelationTypeIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("95ccffb4-0fc9-46a5-a759-ae9d2a40c6aa"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Name = @"ReverseRelationTypeId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateOldReverseRelationTypeIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("cd881aac-b26d-41ee-9acc-24b464dbacb6"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Name = @"OldReverseRelationTypeId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateChildAccountIdParameter());
			Parameters.Add(CreateOldChildAccountIdParameter());
			Parameters.Add(CreateParentAccountIdParameter());
			Parameters.Add(CreateOldParentAccountIdParameter());
			Parameters.Add(CreateRelationTypeIdParameter());
			Parameters.Add(CreateOldRelationTypeIdParameter());
			Parameters.Add(CreateReverseRelationTypeIdParameter());
			Parameters.Add(CreateOldReverseRelationTypeIdParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaEventSubProcess eventsubprocess4 = CreateEventSubProcess4EventSubProcess();
			FlowElements.Add(eventsubprocess4);
			ProcessSchemaStartMessageEvent relationshipinsertingstartmessage = CreateRelationshipInsertingStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(relationshipinsertingstartmessage);
			ProcessSchemaScriptTask checkparentaccountexistscripttask = CreateCheckParentAccountExistScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(checkparentaccountexistscripttask);
			ProcessSchemaStartMessageEvent relationshipinsertedstartmessage = CreateRelationshipInsertedStartMessageStartMessageEvent();
			eventsubprocess2.FlowElements.Add(relationshipinsertedstartmessage);
			ProcessSchemaScriptTask relationshipinsertedscripttask = CreateRelationshipInsertedScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(relationshipinsertedscripttask);
			ProcessSchemaStartMessageEvent relationshipsavingstartmessage = CreateRelationshipSavingStartMessageStartMessageEvent();
			eventsubprocess3.FlowElements.Add(relationshipsavingstartmessage);
			ProcessSchemaScriptTask relationshipsavingscripttask = CreateRelationshipSavingScriptTaskScriptTask();
			eventsubprocess3.FlowElements.Add(relationshipsavingscripttask);
			ProcessSchemaStartMessageEvent relationshipsavedstartmessage = CreateRelationshipSavedStartMessageStartMessageEvent();
			eventsubprocess4.FlowElements.Add(relationshipsavedstartmessage);
			ProcessSchemaScriptTask relationshipsavedscripttask = CreateRelationshipSavedScriptTaskScriptTask();
			eventsubprocess4.FlowElements.Add(relationshipsavedscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("daefdb02-c515-4f3a-bf95-44267edaa1bd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669"),
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				CurveCenterPosition = new Point(214, 94),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c7c50777-0f61-4f22-9927-a707a6fcb028"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9b65e755-de5c-4faf-bdc6-211bd7fe78e8"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("faaacc6e-1c1a-4c1f-8f5f-b07d776b5916"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669"),
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				CurveCenterPosition = new Point(205, 301),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("437ca897-5a90-473b-9292-f7fa2ae06d3f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e4d8fc41-5e0e-4765-b4b5-0a32ea9fc154"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("e509b0a0-3f3d-48ed-a9a9-5cb854aac2c3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669"),
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				CurveCenterPosition = new Point(206, 479),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("83cc73a5-0002-42c1-b21b-50b86bc43b80"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d53e8f53-8f1d-4c63-8aa7-92b7d16c9ed1"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("e3121c4d-0b12-4689-b11a-3a7adb78711a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669"),
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				CurveCenterPosition = new Point(210, 648),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3a8fe39f-97ee-4871-9937-bf6f5eb9f7f8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4c3e46b3-9c2c-4261-8637-db8c59aa3233"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("dd8d38a3-3d52-4041-be6b-70a1f4be77fb"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669"),
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(639, 752),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("6b6ed949-05d3-43ed-9349-72d5b628fdc9"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("dd8d38a3-3d52-4041-be6b-70a1f4be77fb"),
				CreatedInOwnerSchemaUId = new Guid("533e9db5-b10c-44a9-bbef-168af653d2d5"),
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669"),
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(610, 752),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("8db64475-8492-4ef2-8c07-3561a75ea878"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6b6ed949-05d3-43ed-9349-72d5b628fdc9"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669"),
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(42, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(553, 218),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateRelationshipInsertingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c7c50777-0f61-4f22-9927-a707a6fcb028"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8db64475-8492-4ef2-8c07-3561a75ea878"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669"),
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"RelationshipInserting",
				ModifiedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Name = @"RelationshipInsertingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(35, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCheckParentAccountExistScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9b65e755-de5c-4faf-bdc6-211bd7fe78e8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8db64475-8492-4ef2-8c07-3561a75ea878"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669"),
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Name = @"CheckParentAccountExistScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(203, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,69,203,49,14,2,33,16,70,225,90,18,238,64,9,13,23,48,22,74,40,236,44,246,2,4,127,92,162,25,146,97,208,53,198,187,171,217,194,238,229,75,94,45,198,134,25,249,122,74,12,146,125,206,109,144,196,165,118,177,206,153,151,86,27,107,39,48,167,222,138,248,208,24,62,146,84,169,232,107,60,15,40,95,141,247,223,206,151,238,108,110,36,88,196,79,51,183,199,223,157,63,246,144,40,227,134,179,217,25,225,129,173,86,111,173,24,50,152,86,248,0,215,85,80,3,144,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1c2c0fd5-f223-4b15-ba35-f632fe7bcf8e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6b6ed949-05d3-43ed-9349-72d5b628fdc9"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669"),
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(42, 231),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(553, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateRelationshipInsertedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("437ca897-5a90-473b-9292-f7fa2ae06d3f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1c2c0fd5-f223-4b15-ba35-f632fe7bcf8e"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669"),
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"RelationshipInserted",
				ModifiedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Name = @"RelationshipInsertedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateRelationshipInsertedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e4d8fc41-5e0e-4765-b4b5-0a32ea9fc154"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1c2c0fd5-f223-4b15-ba35-f632fe7bcf8e"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669"),
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Name = @"RelationshipInsertedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(197, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,72,73,44,73,117,76,78,206,47,205,43,113,76,43,73,45,10,74,205,73,44,201,204,207,43,206,200,44,240,204,43,78,45,42,73,77,209,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,159,114,110,234,55,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c5e3b5b4-70f1-4b35-9dbd-f61e9f9480cb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6b6ed949-05d3-43ed-9349-72d5b628fdc9"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669"),
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Name = @"EventSubProcess3",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(42, 392),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(553, 164),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateRelationshipSavingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("83cc73a5-0002-42c1-b21b-50b86bc43b80"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c5e3b5b4-70f1-4b35-9dbd-f61e9f9480cb"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669"),
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"RelationshipSaving",
				ModifiedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Name = @"RelationshipSavingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateRelationshipSavingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d53e8f53-8f1d-4c63-8aa7-92b7d16c9ed1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c5e3b5b4-70f1-4b35-9dbd-f61e9f9480cb"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669"),
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Name = @"RelationshipSavingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(197, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,45,9,72,44,74,204,77,45,73,45,42,118,74,77,203,47,74,13,78,44,203,204,75,215,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,0,148,22,166,42,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a8d95e40-b56a-49c3-a1d8-3a59ef4b59ea"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6b6ed949-05d3-43ed-9349-72d5b628fdc9"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669"),
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Name = @"EventSubProcess4",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(43, 569),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(553, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess4;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateRelationshipSavedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("3a8fe39f-97ee-4871-9937-bf6f5eb9f7f8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a8d95e40-b56a-49c3-a1d8-3a59ef4b59ea"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669"),
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"RelationshipSaved",
				ModifiedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Name = @"RelationshipSavedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateRelationshipSavedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4c3e46b3-9c2c-4261-8637-db8c59aa3233"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a8d95e40-b56a-49c3-a1d8-3a59ef4b59ea"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669"),
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Name = @"RelationshipSavedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(197, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,72,73,44,73,117,76,78,206,47,205,43,113,76,43,73,45,10,74,205,73,44,201,204,207,43,206,200,44,8,78,44,75,77,209,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,186,4,1,224,52,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetParentRelationTypeIdMethod());
			Methods.Add(CreateGetReverseRelationshipTypeIdMethod());
			Methods.Add(CreateCheckParentAccountExistMethod());
			Methods.Add(CreateUpdateAccountMethod());
			Methods.Add(CreateGetChildAccountIdMethod());
			Methods.Add(CreateGetParentAccountIdMethod());
			Methods.Add(CreateUpdateAccountAfterRelationshipInsertedMethod());
			Methods.Add(CreateUpdateAccountAfterRelationshipSavedMethod());
			Methods.Add(CreateSetParametersBeforeSavingMethod());
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

		protected virtual SchemaMethod CreateGetParentRelationTypeIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("948f5f69-607c-4506-bd78-f1f0aee5a4fd"),
				Name = "GetParentRelationTypeId",
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669"),
				ResultValueTypeName = "Guid"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,47,205,76,209,80,170,118,115,50,118,52,55,117,49,214,53,117,115,53,211,117,113,51,52,212,181,52,55,116,210,53,48,48,116,49,51,112,181,52,182,112,54,171,85,210,180,6,0,223,142,120,134,58,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetReverseRelationshipTypeIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f74a4502-1769-4936-ba79-c3d27bdd216a"),
				Name = "GetReverseRelationshipTypeId",
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669"),
				ResultValueTypeName = "Guid"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,47,205,76,209,80,170,54,116,117,49,51,53,117,51,214,53,117,115,53,211,117,113,51,52,212,181,52,55,116,210,53,48,48,116,49,51,112,181,52,182,112,54,171,85,210,180,6,0,168,148,105,60,58,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCheckParentAccountExistMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a18aae96-456b-47f9-b353-b104d251114c"),
				Name = "CheckParentAccountExist",
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,83,77,79,194,64,16,61,151,132,255,176,246,180,189,52,70,143,32,73,129,66,184,25,80,60,175,237,32,27,183,187,184,31,32,49,254,119,167,221,150,130,66,76,76,76,218,100,50,59,243,222,155,55,187,207,74,9,162,193,56,97,201,29,89,49,97,160,215,237,76,29,207,49,43,152,229,74,62,236,55,48,203,241,52,149,150,219,125,60,5,91,166,242,145,18,174,144,75,38,28,244,203,134,1,13,231,39,45,97,212,66,109,65,27,152,255,5,241,76,103,11,204,178,76,57,105,43,176,50,17,167,197,198,238,241,148,175,8,253,62,0,150,128,189,103,26,164,61,197,163,81,68,62,186,157,224,24,237,119,105,137,175,78,106,61,159,4,208,60,226,137,207,142,251,63,252,195,134,223,15,221,98,92,29,91,226,9,182,76,19,3,2,50,92,54,93,84,65,36,97,71,124,72,31,13,232,145,146,18,99,212,22,97,67,16,123,98,58,113,50,195,24,145,169,207,196,137,177,160,185,121,69,241,190,114,162,85,65,195,229,174,214,213,140,104,214,124,19,250,138,167,53,104,56,8,47,117,199,51,147,190,57,38,26,80,116,135,21,128,192,237,28,53,122,34,243,159,247,235,114,251,101,167,75,175,2,103,184,124,33,116,60,76,223,33,115,86,105,2,77,112,71,78,109,136,83,105,156,134,241,176,77,53,251,10,184,180,135,103,82,206,89,25,132,8,222,227,216,131,195,34,99,130,233,254,76,218,219,155,1,109,136,42,29,193,241,61,109,17,112,117,215,53,69,112,120,156,86,59,168,122,112,211,229,143,159,6,235,180,172,223,111,239,11,189,196,33,189,204,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateAccountMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f2d75cb6-8d6c-4e9f-a52b-e78306151755"),
				Name = "UpdateAccount",
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6356e9eb-a769-48e5-bb0e-fea12c48c217"),
				Name = "id",
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				ModifiedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e27e84b6-c5f0-4418-b311-8ebf1d0a5d44"),
				Name = "parentId",
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				ModifiedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,208,189,10,194,48,16,7,240,217,66,223,225,200,148,66,233,11,148,14,82,138,116,83,164,56,135,244,196,64,154,212,124,160,34,190,187,49,173,131,180,139,211,193,221,253,127,7,215,141,61,115,8,62,150,45,231,218,43,119,240,104,30,80,129,194,27,116,113,64,59,139,166,214,74,33,119,66,171,28,200,188,74,178,50,77,196,25,232,200,12,42,215,246,80,133,156,151,50,131,103,154,108,150,108,113,68,71,201,126,222,38,57,212,90,250,65,21,1,183,142,198,228,135,124,1,74,139,240,35,11,11,59,47,250,127,229,208,97,3,58,52,148,198,248,215,155,238,164,201,138,116,186,160,65,74,130,146,21,173,109,174,158,73,186,208,196,36,172,196,155,59,114,31,158,150,149,111,237,163,221,96,94,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetChildAccountIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c6d48904-98a1-49fa-9aea-67fe2df6d2c5"),
				Name = "GetChildAccountId",
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669"),
				ResultValueTypeName = "Guid"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("381009eb-1065-41ff-b6db-8cca13accc49"),
				Name = "accountAId",
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				ModifiedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("72efdb0a-741e-4146-b911-d36b60e770ab"),
				Name = "accountBId",
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				ModifiedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9f996835-8f73-48eb-a8cf-995e950e3137"),
				Name = "relationTypeId",
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				ModifiedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f4c2d9cb-ec31-4f0b-9fd7-a12be3cf24ec"),
				Name = "reverseRelationTypeId",
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				ModifiedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,40,74,205,73,44,201,204,207,11,169,44,72,245,76,81,176,181,85,112,79,45,9,72,44,74,205,43,9,66,145,210,208,212,84,168,230,229,226,44,74,45,41,45,202,83,72,76,78,206,47,205,43,113,244,76,177,230,229,170,85,72,205,41,78,85,200,4,155,87,150,90,84,156,26,68,153,177,78,16,99,121,185,160,194,238,165,153,41,122,174,185,5,37,149,214,0,166,154,161,115,181,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetParentAccountIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0e652077-ab61-419b-b444-f52b7ddaf19c"),
				Name = "GetParentAccountId",
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669"),
				ResultValueTypeName = "Guid"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b29d4d8a-db72-45d1-a30f-7c4200227fa5"),
				Name = "accountAId",
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				ModifiedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("26146b3e-3178-4653-be19-1dc00644e59b"),
				Name = "accountBId",
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				ModifiedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("dd8c4cb4-2f74-41c5-b73f-3a8f7970f611"),
				Name = "relationTypeId",
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				ModifiedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("17c0d6f8-69b0-40a7-93b2-6b84f7cfd07f"),
				Name = "reverseRelationTypeId",
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				ModifiedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,40,74,205,73,44,201,204,207,11,169,44,72,245,76,81,176,181,85,112,79,45,9,72,44,74,205,43,9,66,145,210,208,212,84,168,230,226,44,74,45,41,45,202,83,72,76,78,206,47,205,43,113,242,76,177,230,170,85,72,205,41,78,85,200,4,155,86,150,90,84,156,26,68,145,161,142,96,67,185,160,130,238,165,153,41,122,174,185,5,37,149,214,0,233,204,234,99,176,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateAccountAfterRelationshipInsertedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("41f74512-939a-4e61-be94-7009209175bc"),
				Name = "UpdateAccountAfterRelationshipInserted",
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,47,205,76,81,40,74,205,73,44,201,204,207,11,169,44,72,245,76,81,176,85,112,205,43,201,44,169,212,115,79,45,1,9,165,56,231,231,148,230,230,133,37,230,148,166,218,184,3,53,216,105,40,5,161,104,81,210,180,230,114,135,152,84,150,90,84,156,26,68,142,129,88,116,194,205,77,206,200,204,73,113,76,78,206,47,205,43,1,27,168,0,52,202,25,69,80,131,139,147,176,45,80,213,142,32,163,117,72,208,224,4,213,128,26,82,96,1,44,206,230,130,57,187,32,177,40,21,104,27,154,187,3,80,69,7,153,195,51,211,20,52,208,130,91,209,86,1,100,170,158,107,110,65,73,165,130,154,26,134,191,80,20,104,42,84,115,113,134,22,164,36,150,164,66,85,160,153,167,131,174,31,104,107,45,0,167,4,9,131,137,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateAccountAfterRelationshipSavedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e96eeda4-a728-4ab1-958a-8a85c747ccd1"),
				Name = "UpdateAccountAfterRelationshipSaved",
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,85,203,74,195,64,20,93,39,95,113,221,72,10,106,63,160,86,144,34,197,85,69,244,3,98,51,106,32,38,165,77,5,209,130,173,136,8,69,23,186,112,227,63,212,106,105,107,53,223,112,231,143,188,121,136,205,204,196,250,194,69,33,61,115,238,205,185,231,158,105,203,77,219,130,58,115,76,223,246,220,173,163,26,91,183,160,8,155,41,160,160,151,99,214,33,171,55,216,166,76,86,224,73,141,231,88,18,191,34,98,211,92,245,43,42,25,71,73,101,117,223,118,172,213,106,213,107,186,126,196,47,165,128,143,254,37,145,88,17,177,132,91,51,235,204,245,167,153,27,105,228,163,231,134,68,173,72,96,65,215,237,93,48,12,65,232,92,17,194,46,75,107,7,53,255,8,78,78,20,18,83,148,156,174,205,207,131,33,138,83,181,17,85,165,251,228,224,88,215,118,60,207,1,187,49,237,104,105,223,116,247,88,56,195,174,233,52,24,201,214,34,221,66,64,168,153,188,88,82,38,131,162,124,141,212,25,234,32,189,55,85,157,189,247,206,168,19,39,211,178,166,242,235,77,26,74,107,197,99,205,41,105,73,7,58,87,110,35,189,194,152,172,229,243,128,119,56,196,23,28,224,43,142,112,194,219,252,26,240,9,3,126,129,3,126,26,129,99,192,103,12,240,149,119,8,232,225,99,200,229,29,48,66,62,142,20,236,17,208,115,64,248,136,119,136,60,225,93,222,166,22,116,22,58,169,109,215,44,211,103,137,20,89,236,2,184,77,199,201,21,100,106,85,224,9,121,138,74,90,192,40,0,144,216,160,72,147,88,244,153,17,89,99,40,13,249,161,222,104,171,210,235,177,71,2,186,128,125,2,123,4,188,144,199,109,236,243,107,28,242,110,156,130,25,33,144,163,95,102,126,236,71,58,136,70,46,140,105,102,182,51,171,166,156,187,33,55,38,244,233,147,248,0,199,121,188,21,34,177,184,2,120,79,223,207,35,34,57,74,248,35,61,7,248,16,89,56,228,103,252,138,95,134,220,239,37,164,5,138,89,139,159,205,74,23,57,227,15,225,143,102,93,14,135,21,192,188,88,246,207,247,224,27,107,157,249,155,245,5,143,190,184,234,40,22,179,252,252,197,181,106,189,1,157,132,1,129,37,8,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetParametersBeforeSavingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0c81cdd9-5753-4a29-9709-241ee18ec778"),
				Name = "SetParametersBeforeSaving",
				CreatedInSchemaUId = new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"),
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,74,205,73,44,201,204,207,11,169,44,72,245,76,81,176,85,112,205,43,201,44,169,212,115,79,45,1,9,165,56,231,231,148,230,230,133,37,230,148,166,218,184,151,102,166,216,105,40,5,161,104,81,210,180,230,10,74,45,75,45,42,78,13,34,199,44,44,58,65,70,250,231,164,16,50,14,168,132,40,215,129,141,34,202,129,184,76,196,225,70,231,140,204,156,20,199,228,228,252,210,188,18,176,113,64,115,80,197,52,184,56,9,135,1,84,181,35,200,80,29,18,52,56,65,53,160,58,12,44,128,197,193,92,144,144,32,199,205,216,131,5,191,179,241,234,129,185,28,35,146,97,98,56,220,31,144,88,148,10,180,17,213,245,104,130,131,47,200,201,115,245,96,9,116,0,247,10,67,13,33,4,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new RelationshipEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("55a6b3cf-9ce9-4e32-8b30-a0b7e15a29c4"));
		}

		#endregion

	}

	#endregion


	#region Class: RelationshipEventsProcess

	/// <exclude/>
	public class RelationshipEventsProcess : Relationship_BaseEventsProcess
	{

		public RelationshipEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

