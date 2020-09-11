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

	#region Class: BaseEntitySchema

	/// <exclude/>
	[IsVirtual]
	public class BaseEntitySchema : Terrasoft.Core.Entities.EntitySchema
	{

		#region Constructors: Public

		public BaseEntitySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BaseEntitySchema(BaseEntitySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BaseEntitySchema(BaseEntitySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			RealUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			Name = "BaseEntity";
			ParentSchemaUId = new Guid("1b56b061-4e91-4974-9038-df8340e534f2");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryColumn() {
			base.InitializePrimaryColumn();
			PrimaryColumn = CreateIdColumn();
			if (Columns.FindByUId(PrimaryColumn.UId) == null) {
				Columns.Add(PrimaryColumn);
			}
		}

		protected override void InitializeCreatedOnColumn() {
			base.InitializeCreatedOnColumn();
			CreatedOnColumn = CreateCreatedOnColumn();
			if (Columns.FindByUId(CreatedOnColumn.UId) == null) {
				Columns.Add(CreatedOnColumn);
			}
		}

		protected override void InitializeCreatedByColumn() {
			base.InitializeCreatedByColumn();
			CreatedByColumn = CreateCreatedByColumn();
			if (Columns.FindByUId(CreatedByColumn.UId) == null) {
				Columns.Add(CreatedByColumn);
			}
		}

		protected override void InitializeModifiedOnColumn() {
			base.InitializeModifiedOnColumn();
			ModifiedOnColumn = CreateModifiedOnColumn();
			if (Columns.FindByUId(ModifiedOnColumn.UId) == null) {
				Columns.Add(ModifiedOnColumn);
			}
		}

		protected override void InitializeModifiedByColumn() {
			base.InitializeModifiedByColumn();
			ModifiedByColumn = CreateModifiedByColumn();
			if (Columns.FindByUId(ModifiedByColumn.UId) == null) {
				Columns.Add(ModifiedByColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("3fabd836-6a53-4d8d-9069-6df88d9dae1e")) == null) {
				Columns.Add(CreateProcessListenersColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("ae0e45ca-c495-4fe7-a39d-3ab7278e1617"),
				Name = @"Id",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				UsageType = EntitySchemaColumnUsageType.Advanced,
				CreatedInSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0"),
				ModifiedInSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"AutoGuid")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateCreatedOnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("e80190a5-03b2-4095-90f7-a193a960adee"),
				Name = @"CreatedOn",
				IsValueCloneable = false,
				UsageType = EntitySchemaColumnUsageType.Advanced,
				CreatedInSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0"),
				ModifiedInSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentDateTime")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateCreatedByColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ebf6bb93-8aa6-4a01-900d-c6ea67affe21"),
				Name = @"CreatedBy",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsValueCloneable = false,
				IsIndexed = true,
				IsWeakReference = true,
				UsageType = EntitySchemaColumnUsageType.Advanced,
				CreatedInSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0"),
				ModifiedInSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentUserContact")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateModifiedOnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("9928edec-4272-425a-93bb-48743fee4b04"),
				Name = @"ModifiedOn",
				IsValueCloneable = false,
				IsIndexed = true,
				UsageType = EntitySchemaColumnUsageType.Advanced,
				CreatedInSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0"),
				ModifiedInSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentDateTime")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateModifiedByColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("3015559e-cbc6-406a-88af-07f7930be832"),
				Name = @"ModifiedBy",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsValueCloneable = false,
				IsIndexed = true,
				IsWeakReference = true,
				UsageType = EntitySchemaColumnUsageType.Advanced,
				CreatedInSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0"),
				ModifiedInSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentUserContact")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateProcessListenersColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("3fabd836-6a53-4d8d-9069-6df88d9dae1e"),
				Name = @"ProcessListeners",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0"),
				ModifiedInSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBaseEntityEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateBaseEntityEventsProcessSchema() {
			var schema = new BaseEntityEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BaseEntity(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BaseEntity_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BaseEntitySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BaseEntitySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0"));
		}

		#endregion

	}

	#endregion

	#region Class: BaseEntity

	/// <summary>
	/// Base object.
	/// </summary>
	public class BaseEntity : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public BaseEntity(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BaseEntity";
		}

		public BaseEntity(BaseEntity source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Id.
		/// </summary>
		public Guid Id {
			get {
				return GetTypedColumnValue<Guid>("Id");
			}
			set {
				SetColumnValue("Id", value);
			}
		}

		/// <summary>
		/// Created on.
		/// </summary>
		public DateTime CreatedOn {
			get {
				return GetTypedColumnValue<DateTime>("CreatedOn");
			}
			set {
				SetColumnValue("CreatedOn", value);
			}
		}

		/// <exclude/>
		public Guid CreatedById {
			get {
				return GetTypedColumnValue<Guid>("CreatedById");
			}
			set {
				SetColumnValue("CreatedById", value);
				_createdBy = null;
			}
		}

		/// <exclude/>
		public string CreatedByName {
			get {
				return GetTypedColumnValue<string>("CreatedByName");
			}
			set {
				SetColumnValue("CreatedByName", value);
				if (_createdBy != null) {
					_createdBy.Name = value;
				}
			}
		}

		private Contact _createdBy;
		/// <summary>
		/// Created by.
		/// </summary>
		public Contact CreatedBy {
			get {
				return _createdBy ??
					(_createdBy = LookupColumnEntities.GetEntity("CreatedBy") as Contact);
			}
		}

		/// <summary>
		/// Modified on.
		/// </summary>
		public DateTime ModifiedOn {
			get {
				return GetTypedColumnValue<DateTime>("ModifiedOn");
			}
			set {
				SetColumnValue("ModifiedOn", value);
			}
		}

		/// <exclude/>
		public Guid ModifiedById {
			get {
				return GetTypedColumnValue<Guid>("ModifiedById");
			}
			set {
				SetColumnValue("ModifiedById", value);
				_modifiedBy = null;
			}
		}

		/// <exclude/>
		public string ModifiedByName {
			get {
				return GetTypedColumnValue<string>("ModifiedByName");
			}
			set {
				SetColumnValue("ModifiedByName", value);
				if (_modifiedBy != null) {
					_modifiedBy.Name = value;
				}
			}
		}

		private Contact _modifiedBy;
		/// <summary>
		/// Modified by.
		/// </summary>
		public Contact ModifiedBy {
			get {
				return _modifiedBy ??
					(_modifiedBy = LookupColumnEntities.GetEntity("ModifiedBy") as Contact);
			}
		}

		/// <summary>
		/// Active processes.
		/// </summary>
		public int ProcessListeners {
			get {
				return GetTypedColumnValue<int>("ProcessListeners");
			}
			set {
				SetColumnValue("ProcessListeners", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BaseEntity_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("BaseEntityDeleted", e);
			Deleting += (s, e) => ThrowEvent("BaseEntityDeleting", e);
			Inserted += (s, e) => ThrowEvent("BaseEntityInserted", e);
			Inserting += (s, e) => ThrowEvent("BaseEntityInserting", e);
			Saved += (s, e) => ThrowEvent("BaseEntitySaved", e);
			Saving += (s, e) => ThrowEvent("BaseEntitySaving", e);
			Validating += (s, e) => ThrowEvent("BaseEntityValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseEntity(this);
		}

		#endregion

	}

	#endregion

	#region Class: BaseEntity_BaseEventsProcess

	/// <exclude/>
	public partial class BaseEntity_BaseEventsProcess<TEntity> : Terrasoft.Core.Process.EmbeddedProcess where TEntity : BaseEntity
	{

		private TEntity _entity;
		public TEntity Entity {
			get {
				return _entity;
			}
			set {
				_entity = value;
			}
		}

		public BaseEntity_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseEntity_BaseEventsProcess";
			SchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual Object ProcessListeners {
			get;
			set;
		}

		public virtual Object ProcessSchemaListeners {
			get;
			set;
		}

		public virtual bool NextProcessElementReady {
			get;
			set;
		}

		public virtual bool IsProcessModeSave {
			get;
			set;
		}

		public virtual bool CanUseDcm {
			get;
			set;
		}

		public virtual Object DcmEntityUtil {
			get;
			set;
		}

		private ProcessFlowElement _baseEntityDeletingEventSubProcess2;
		public ProcessFlowElement BaseEntityDeletingEventSubProcess2 {
			get {
				return _baseEntityDeletingEventSubProcess2 ?? (_baseEntityDeletingEventSubProcess2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BaseEntityDeletingEventSubProcess2",
					SchemaElementUId = new Guid("08594d74-60b0-45ce-bf17-bac1a8b127f7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseEntityDeletingStartMessage2;
		public ProcessFlowElement BaseEntityDeletingStartMessage2 {
			get {
				return _baseEntityDeletingStartMessage2 ?? (_baseEntityDeletingStartMessage2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseEntityDeletingStartMessage2",
					SchemaElementUId = new Guid("496d4a3c-b644-4a65-b0ed-2534d9236da5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _tryProcessCompleteScriptTask2;
		public ProcessScriptTask TryProcessCompleteScriptTask2 {
			get {
				return _tryProcessCompleteScriptTask2 ?? (_tryProcessCompleteScriptTask2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "TryProcessCompleteScriptTask2",
					SchemaElementUId = new Guid("441daff4-4808-48db-ac28-d9a42d61ac31"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = TryProcessCompleteScriptTask2Execute,
				});
			}
		}

		private ProcessFlowElement _baseEntityEventSubProcess1;
		public ProcessFlowElement BaseEntityEventSubProcess1 {
			get {
				return _baseEntityEventSubProcess1 ?? (_baseEntityEventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BaseEntityEventSubProcess1",
					SchemaElementUId = new Guid("90027ac8-c9c3-4d21-a4f9-da1cde752cd1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseEntityStartMessage1;
		public ProcessFlowElement BaseEntityStartMessage1 {
			get {
				return _baseEntityStartMessage1 ?? (_baseEntityStartMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseEntityStartMessage1",
					SchemaElementUId = new Guid("d8b8410f-5c8a-4ddc-8fc2-353483452aed"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _tryProcessCompleteScriptTask1;
		public ProcessScriptTask TryProcessCompleteScriptTask1 {
			get {
				return _tryProcessCompleteScriptTask1 ?? (_tryProcessCompleteScriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "TryProcessCompleteScriptTask1",
					SchemaElementUId = new Guid("9494818b-220e-4e19-a635-fdca641dde5f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = TryProcessCompleteScriptTask1Execute,
				});
			}
		}

		private ProcessScriptTask _baseEntitySavedIndexingTask;
		public ProcessScriptTask BaseEntitySavedIndexingTask {
			get {
				return _baseEntitySavedIndexingTask ?? (_baseEntitySavedIndexingTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BaseEntitySavedIndexingTask",
					SchemaElementUId = new Guid("b8ff0739-6ead-4da7-ac8d-538cfc641fcf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = BaseEntitySavedIndexingTaskExecute,
				});
			}
		}

		private ProcessFlowElement _baseInsertedEventSubProcess;
		public ProcessFlowElement BaseInsertedEventSubProcess {
			get {
				return _baseInsertedEventSubProcess ?? (_baseInsertedEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BaseInsertedEventSubProcess",
					SchemaElementUId = new Guid("5f3bfbbe-1820-44ca-92f1-6f993169b2dd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _insertedStartMessage1;
		public ProcessFlowElement InsertedStartMessage1 {
			get {
				return _insertedStartMessage1 ?? (_insertedStartMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "InsertedStartMessage1",
					SchemaElementUId = new Guid("d7c806b7-a29b-4ce5-9167-b3319472e772"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskInsertedBaseEntity;
		public ProcessScriptTask ScriptTaskInsertedBaseEntity {
			get {
				return _scriptTaskInsertedBaseEntity ?? (_scriptTaskInsertedBaseEntity = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskInsertedBaseEntity",
					SchemaElementUId = new Guid("5528724d-213b-4ae6-88d5-aa7301a1dbb0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskInsertedBaseEntityExecute,
				});
			}
		}

		private ProcessFlowElement _baseEntitySavingEventSubProcess;
		public ProcessFlowElement BaseEntitySavingEventSubProcess {
			get {
				return _baseEntitySavingEventSubProcess ?? (_baseEntitySavingEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BaseEntitySavingEventSubProcess",
					SchemaElementUId = new Guid("dbf48103-dcf6-4f53-a052-d727a95ea0b4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseEntitySavingStartMessage;
		public ProcessFlowElement BaseEntitySavingStartMessage {
			get {
				return _baseEntitySavingStartMessage ?? (_baseEntitySavingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseEntitySavingStartMessage",
					SchemaElementUId = new Guid("933bf2fc-d052-40c8-a3e0-bf60049da5d8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _baseEntitySavingScriptTask;
		public ProcessScriptTask BaseEntitySavingScriptTask {
			get {
				return _baseEntitySavingScriptTask ?? (_baseEntitySavingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BaseEntitySavingScriptTask",
					SchemaElementUId = new Guid("9b990da0-84e4-4aa1-ab8f-219ff3a429fa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = BaseEntitySavingScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _baseEnityValidatingEventSubProcess_f0646c74f291474f9a10143ee868f1c9;
		public ProcessFlowElement BaseEnityValidatingEventSubProcess_f0646c74f291474f9a10143ee868f1c9 {
			get {
				return _baseEnityValidatingEventSubProcess_f0646c74f291474f9a10143ee868f1c9 ?? (_baseEnityValidatingEventSubProcess_f0646c74f291474f9a10143ee868f1c9 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BaseEnityValidatingEventSubProcess_f0646c74f291474f9a10143ee868f1c9",
					SchemaElementUId = new Guid("f0646c74-f291-474f-9a10-143ee868f1c9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseEnityValidatingStartMessage_b3d5b61f7afe48b5a8cc40317ea9c428;
		public ProcessFlowElement BaseEnityValidatingStartMessage_b3d5b61f7afe48b5a8cc40317ea9c428 {
			get {
				return _baseEnityValidatingStartMessage_b3d5b61f7afe48b5a8cc40317ea9c428 ?? (_baseEnityValidatingStartMessage_b3d5b61f7afe48b5a8cc40317ea9c428 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseEnityValidatingStartMessage_b3d5b61f7afe48b5a8cc40317ea9c428",
					SchemaElementUId = new Guid("b3d5b61f-7afe-48b5-a8cc-40317ea9c428"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _baseEnityValidatingScriptTask_a553628ef6dc4e09bdcf27e446fdc16f;
		public ProcessScriptTask BaseEnityValidatingScriptTask_a553628ef6dc4e09bdcf27e446fdc16f {
			get {
				return _baseEnityValidatingScriptTask_a553628ef6dc4e09bdcf27e446fdc16f ?? (_baseEnityValidatingScriptTask_a553628ef6dc4e09bdcf27e446fdc16f = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BaseEnityValidatingScriptTask_a553628ef6dc4e09bdcf27e446fdc16f",
					SchemaElementUId = new Guid("a553628e-f6dc-4e09-bdcf-27e446fdc16f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = BaseEnityValidatingScriptTask_a553628ef6dc4e09bdcf27e446fdc16fExecute,
				});
			}
		}

		private ProcessFlowElement _baseEntityDeletedSubProcess;
		public ProcessFlowElement BaseEntityDeletedSubProcess {
			get {
				return _baseEntityDeletedSubProcess ?? (_baseEntityDeletedSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BaseEntityDeletedSubProcess",
					SchemaElementUId = new Guid("8140d7e7-fb91-4999-8347-543345440efb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseEntityDeletedStartMessage;
		public ProcessFlowElement BaseEntityDeletedStartMessage {
			get {
				return _baseEntityDeletedStartMessage ?? (_baseEntityDeletedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseEntityDeletedStartMessage",
					SchemaElementUId = new Guid("c803a450-c8dc-47a4-b704-7125c23db317"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _baseEntityDeletedScriptTask;
		public ProcessScriptTask BaseEntityDeletedScriptTask {
			get {
				return _baseEntityDeletedScriptTask ?? (_baseEntityDeletedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BaseEntityDeletedScriptTask",
					SchemaElementUId = new Guid("60f96d87-85be-4d31-856d-8edd6bb953c1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = BaseEntityDeletedScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[BaseEntityDeletingEventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseEntityDeletingEventSubProcess2 };
			FlowElements[BaseEntityDeletingStartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseEntityDeletingStartMessage2 };
			FlowElements[TryProcessCompleteScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { TryProcessCompleteScriptTask2 };
			FlowElements[BaseEntityEventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseEntityEventSubProcess1 };
			FlowElements[BaseEntityStartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseEntityStartMessage1 };
			FlowElements[TryProcessCompleteScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { TryProcessCompleteScriptTask1 };
			FlowElements[BaseEntitySavedIndexingTask.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseEntitySavedIndexingTask };
			FlowElements[BaseInsertedEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseInsertedEventSubProcess };
			FlowElements[InsertedStartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { InsertedStartMessage1 };
			FlowElements[ScriptTaskInsertedBaseEntity.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskInsertedBaseEntity };
			FlowElements[BaseEntitySavingEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseEntitySavingEventSubProcess };
			FlowElements[BaseEntitySavingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseEntitySavingStartMessage };
			FlowElements[BaseEntitySavingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseEntitySavingScriptTask };
			FlowElements[BaseEnityValidatingEventSubProcess_f0646c74f291474f9a10143ee868f1c9.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseEnityValidatingEventSubProcess_f0646c74f291474f9a10143ee868f1c9 };
			FlowElements[BaseEnityValidatingStartMessage_b3d5b61f7afe48b5a8cc40317ea9c428.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseEnityValidatingStartMessage_b3d5b61f7afe48b5a8cc40317ea9c428 };
			FlowElements[BaseEnityValidatingScriptTask_a553628ef6dc4e09bdcf27e446fdc16f.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseEnityValidatingScriptTask_a553628ef6dc4e09bdcf27e446fdc16f };
			FlowElements[BaseEntityDeletedSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseEntityDeletedSubProcess };
			FlowElements[BaseEntityDeletedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseEntityDeletedStartMessage };
			FlowElements[BaseEntityDeletedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseEntityDeletedScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "BaseEntityDeletingEventSubProcess2":
						break;
					case "BaseEntityDeletingStartMessage2":
						e.Context.QueueTasks.Enqueue("TryProcessCompleteScriptTask2");
						break;
					case "TryProcessCompleteScriptTask2":
						break;
					case "BaseEntityEventSubProcess1":
						break;
					case "BaseEntityStartMessage1":
						e.Context.QueueTasks.Enqueue("TryProcessCompleteScriptTask1");
						e.Context.QueueTasks.Enqueue("BaseEntitySavedIndexingTask");
						break;
					case "TryProcessCompleteScriptTask1":
						break;
					case "BaseEntitySavedIndexingTask":
						break;
					case "BaseInsertedEventSubProcess":
						break;
					case "InsertedStartMessage1":
						e.Context.QueueTasks.Enqueue("ScriptTaskInsertedBaseEntity");
						break;
					case "ScriptTaskInsertedBaseEntity":
						break;
					case "BaseEntitySavingEventSubProcess":
						break;
					case "BaseEntitySavingStartMessage":
						e.Context.QueueTasks.Enqueue("BaseEntitySavingScriptTask");
						break;
					case "BaseEntitySavingScriptTask":
						break;
					case "BaseEnityValidatingEventSubProcess_f0646c74f291474f9a10143ee868f1c9":
						break;
					case "BaseEnityValidatingStartMessage_b3d5b61f7afe48b5a8cc40317ea9c428":
						e.Context.QueueTasks.Enqueue("BaseEnityValidatingScriptTask_a553628ef6dc4e09bdcf27e446fdc16f");
						break;
					case "BaseEnityValidatingScriptTask_a553628ef6dc4e09bdcf27e446fdc16f":
						break;
					case "BaseEntityDeletedSubProcess":
						break;
					case "BaseEntityDeletedStartMessage":
						e.Context.QueueTasks.Enqueue("BaseEntityDeletedScriptTask");
						break;
					case "BaseEntityDeletedScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("BaseEntityDeletingStartMessage2");
			ActivatedEventElements.Add("BaseEntityStartMessage1");
			ActivatedEventElements.Add("InsertedStartMessage1");
			ActivatedEventElements.Add("BaseEntitySavingStartMessage");
			ActivatedEventElements.Add("BaseEnityValidatingStartMessage_b3d5b61f7afe48b5a8cc40317ea9c428");
			ActivatedEventElements.Add("BaseEntityDeletedStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "BaseEntityDeletingEventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "BaseEntityDeletingStartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseEntityDeletingStartMessage2";
					result = BaseEntityDeletingStartMessage2.Execute(context);
					break;
				case "TryProcessCompleteScriptTask2":
					context.QueueTasks.Dequeue();
					context.SenderName = "TryProcessCompleteScriptTask2";
					result = TryProcessCompleteScriptTask2.Execute(context, TryProcessCompleteScriptTask2Execute);
					break;
				case "BaseEntityEventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "BaseEntityStartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseEntityStartMessage1";
					result = BaseEntityStartMessage1.Execute(context);
					break;
				case "TryProcessCompleteScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "TryProcessCompleteScriptTask1";
					result = TryProcessCompleteScriptTask1.Execute(context, TryProcessCompleteScriptTask1Execute);
					break;
				case "BaseEntitySavedIndexingTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseEntitySavedIndexingTask";
					result = BaseEntitySavedIndexingTask.Execute(context, BaseEntitySavedIndexingTaskExecute);
					break;
				case "BaseInsertedEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "InsertedStartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "InsertedStartMessage1";
					result = InsertedStartMessage1.Execute(context);
					break;
				case "ScriptTaskInsertedBaseEntity":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskInsertedBaseEntity";
					result = ScriptTaskInsertedBaseEntity.Execute(context, ScriptTaskInsertedBaseEntityExecute);
					break;
				case "BaseEntitySavingEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "BaseEntitySavingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseEntitySavingStartMessage";
					result = BaseEntitySavingStartMessage.Execute(context);
					break;
				case "BaseEntitySavingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseEntitySavingScriptTask";
					result = BaseEntitySavingScriptTask.Execute(context, BaseEntitySavingScriptTaskExecute);
					break;
				case "BaseEnityValidatingEventSubProcess_f0646c74f291474f9a10143ee868f1c9":
					context.QueueTasks.Dequeue();
					break;
				case "BaseEnityValidatingStartMessage_b3d5b61f7afe48b5a8cc40317ea9c428":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseEnityValidatingStartMessage_b3d5b61f7afe48b5a8cc40317ea9c428";
					result = BaseEnityValidatingStartMessage_b3d5b61f7afe48b5a8cc40317ea9c428.Execute(context);
					break;
				case "BaseEnityValidatingScriptTask_a553628ef6dc4e09bdcf27e446fdc16f":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseEnityValidatingScriptTask_a553628ef6dc4e09bdcf27e446fdc16f";
					result = BaseEnityValidatingScriptTask_a553628ef6dc4e09bdcf27e446fdc16f.Execute(context, BaseEnityValidatingScriptTask_a553628ef6dc4e09bdcf27e446fdc16fExecute);
					break;
				case "BaseEntityDeletedSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "BaseEntityDeletedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseEntityDeletedStartMessage";
					result = BaseEntityDeletedStartMessage.Execute(context);
					break;
				case "BaseEntityDeletedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseEntityDeletedScriptTask";
					result = BaseEntityDeletedScriptTask.Execute(context, BaseEntityDeletedScriptTaskExecute);
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
				case "DcmEntityUtil":
					DcmEntityUtil = reader.GetSerializableObjectValue();
				break;
				case "CanUseDcm":
					CanUseDcm = reader.GetValue<System.Boolean>();
				break;
				case "IsProcessModeSave":
					IsProcessModeSave = reader.GetValue<System.Boolean>();
				break;
				case "NextProcessElementReady":
					NextProcessElementReady = reader.GetValue<System.Boolean>();
				break;
				case "ProcessListeners":
					ProcessListeners = reader.GetSerializableObjectValue();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool TryProcessCompleteScriptTask2Execute(ProcessExecutingContext context) {
			TryProcessComplete(EntityChangeType.Deleted);
			LocalMessageExecuting(EntityChangeType.Deleted);
			ProcessCompleteExecuting();
			return true;
		}

		public virtual bool TryProcessCompleteScriptTask1Execute(ProcessExecutingContext context) {
			ProcessCompleteExecuting();
			return true;
		}

		public virtual bool BaseEntitySavedIndexingTaskExecute(ProcessExecutingContext context) {
			IndexEntity(IndexingOperationType.Index, Entity.PrimaryColumnValue);
			return true;
		}

		public virtual bool ScriptTaskInsertedBaseEntityExecute(ProcessExecutingContext context) {
			TryProcessComplete(EntityChangeType.Inserted);
			LocalMessageExecuting(EntityChangeType.Inserted);
			ProcessCompleteExecuting();
			return true;
		}

		public virtual bool BaseEntitySavingScriptTaskExecute(ProcessExecutingContext context) {
			if (Entity.StoringState == StoringObjectState.New
					|| Entity.StoringState == StoringObjectState.Deleted) {
				return true;
			}
			InitDcmOnEntityChanging();
			TryProcessComplete(EntityChangeType.Updated);
			LocalMessageExecuting(EntityChangeType.Updated);
			return true;
		}

		public virtual bool BaseEnityValidatingScriptTask_a553628ef6dc4e09bdcf27e446fdc16fExecute(ProcessExecutingContext context) {
			if (CanUseDcm) {
				DcmEntityUtilities dcmEntityUtilities = GetDcmEntityUtilities();
				dcmEntityUtilities.ValidateDcmRequiredElement(Entity, (Collection<ProcessListener>)ProcessListeners);
				if (UserConnection.GetIsFeatureEnabled("DcmStagesPermissions")) {
					dcmEntityUtilities.ValidateDcmStagePermissions(Entity, (Collection<ProcessListener>)ProcessListeners);
				}
			}
			return true;
		}

		public virtual bool BaseEntityDeletedScriptTaskExecute(ProcessExecutingContext context) {
			IndexEntity(IndexingOperationType.Delete, Entity.PrimaryColumnValue);
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "BaseEntityDeleting":
							if (ActivatedEventElements.Contains("BaseEntityDeletingStartMessage2")) {
							context.QueueTasks.Enqueue("BaseEntityDeletingStartMessage2");
						}
						break;
					case "BaseEntitySaved":
							if (ActivatedEventElements.Contains("BaseEntityStartMessage1")) {
							context.QueueTasks.Enqueue("BaseEntityStartMessage1");
						}
						break;
					case "BaseEntityInserted":
							if (ActivatedEventElements.Contains("InsertedStartMessage1")) {
							context.QueueTasks.Enqueue("InsertedStartMessage1");
						}
						break;
					case "BaseEntitySaving":
							if (ActivatedEventElements.Contains("BaseEntitySavingStartMessage")) {
							context.QueueTasks.Enqueue("BaseEntitySavingStartMessage");
						}
						break;
					case "BaseEntityValidating":
							if (ActivatedEventElements.Contains("BaseEnityValidatingStartMessage_b3d5b61f7afe48b5a8cc40317ea9c428")) {
							context.QueueTasks.Enqueue("BaseEnityValidatingStartMessage_b3d5b61f7afe48b5a8cc40317ea9c428");
						}
						break;
					case "BaseEntityDeleted":
							if (ActivatedEventElements.Contains("BaseEntityDeletedStartMessage")) {
							context.QueueTasks.Enqueue("BaseEntityDeletedStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (DcmEntityUtil != null) {
				if (DcmEntityUtil.GetType().IsSerializable ||
					DcmEntityUtil.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("DcmEntityUtil", DcmEntityUtil, null);
				}
			}
			if (!HasMapping("CanUseDcm") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CanUseDcm", CanUseDcm, false);
			}
			if (!HasMapping("IsProcessModeSave") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsProcessModeSave", IsProcessModeSave, false);
			}
			if (!HasMapping("NextProcessElementReady") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("NextProcessElementReady", NextProcessElementReady, false);
			}
			if (ProcessListeners != null) {
				if (ProcessListeners.GetType().IsSerializable ||
					ProcessListeners.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ProcessListeners", ProcessListeners, null);
				}
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: BaseEntity_BaseEventsProcess

	/// <exclude/>
	public class BaseEntity_BaseEventsProcess : BaseEntity_BaseEventsProcess<BaseEntity>
	{

		public BaseEntity_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BaseEntity_BaseEventsProcess

	public partial class BaseEntity_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void TryProcessComplete(EntityChangeType changeType) {
			var processEngine = UserConnection.ProcessEngine;
			ProcessListeners = processEngine.GetProcessListeners(UserConnection, Entity, changeType);
			ProcessSchemaListeners = processEngine.GetProcessSchemaListeners(Entity, changeType);
		}

		public virtual bool IsConditionDataMatch(string conditionData) {
			if (string.IsNullOrEmpty(conditionData)) {
				return true;
			}
			var esq = new EntitySchemaQuery(Entity.Schema);
			IEntitySchemaQueryFilterItem filterCollection = null;
			try {
				var userConnectionArgument = new ConstructorArgument("userConnection", UserConnection);
				var processDataContractFilterConverter = ClassFactory
					.Get<IProcessDataContractFilterConverter>(userConnectionArgument);
				filterCollection = processDataContractFilterConverter.ConvertToEntitySchemaQueryFilterItem(esq, conditionData);
			} catch {
				var oldConditionData = ConditionData.Deserialize(conditionData);
				bool oldConditionCompleted = oldConditionData == null || oldConditionData.Count == 0;
				if (!oldConditionCompleted) {
					foreach (var condition in oldConditionData) {
						oldConditionCompleted = Entity.GetColumnValue(Entity.Schema.Columns.GetByUId(condition.Key)).Equals(condition.Value);
						if (oldConditionCompleted) {
							break;
						}
					}
				}
				return oldConditionCompleted;
			}
			if (filterCollection != null) {
				esq.AddColumn(Entity.Schema.PrimaryColumn.Name);
				esq.Filters.Add(filterCollection);
				var entity = esq.GetEntity(UserConnection, Entity.PrimaryColumnValue);
				return entity != null;
			}
			return true;
		}

		public virtual bool IsChangedColumnsMatch(string changedColumns) {
			if (string.IsNullOrEmpty(changedColumns)) {
				return true;
			}
			var changedColumnsMetaPaths = JsonConvert.DeserializeObject<Collection<string>>(changedColumns);
			foreach(var columnMetaPath in changedColumnsMetaPaths){
				var changedColumn = Entity.Schema.GetSchemaColumnByMetaPath(columnMetaPath);
				foreach (var columnValue in Entity.GetChangedColumnValues()) {
					if (Guid.Equals(columnValue.Column.UId, changedColumn.UId)) {
						return true;
					}
				}
			}
			return false;
		}

		public virtual void ProcessCompleteExecuting() {
			var processEngine = UserConnection.ProcessEngine;
			var processListeners = (Collection<ProcessListener>)ProcessListeners;
			var processSchemaListeners = (Collection<ProcessSchemaListener>)ProcessSchemaListeners;
			processEngine.ActualizeProcessSchemaListeners(Entity, processSchemaListeners);
			Collection<ProcessDescriptor> processDescriptors;
			bool nextPrcElReady = false;
			IList<ProcessListener> clonedProcessListeners = null;
			if (processListeners != null && processListeners.Count > 0) {
				clonedProcessListeners = new List<ProcessListener>(processListeners);
				processDescriptors = processEngine.ContinueExecuting(UserConnection, Entity, processListeners);
				foreach (ProcessDescriptor processDescriptor in processDescriptors) {
					nextPrcElReady = nextPrcElReady || processDescriptor.IsNextElementReady;
				}
				processListeners.Clear();
			}
			if (CanUseDcm) {
				processEngine.RunDcmProcesses(Entity, clonedProcessListeners);
			}
			bool nextPrcElReadyBySignal = false;
			if (processSchemaListeners != null && processSchemaListeners.Count > 0) {
				processDescriptors = processEngine.RunProcesses(UserConnection, Entity, processSchemaListeners);
				foreach (ProcessDescriptor processDescriptor in processDescriptors) {
					nextPrcElReadyBySignal = nextPrcElReadyBySignal || processDescriptor.IsNextElementReady;
				}
				processSchemaListeners.Clear();
			}
			if (!nextPrcElReady) {
				nextPrcElReady = nextPrcElReadyBySignal;
			}
			NextProcessElementReady = NextProcessElementReady || nextPrcElReady;
		}

		public virtual bool GetNextPrcElReadyPropertyValue(Entity entity) {
			if (entity != null && entity.Process != null) {
				object nextPrcElReady;
				if (entity.Process.TryGetPropertyValue("NextProcessElementReady", out nextPrcElReady)) {
					return (bool)nextPrcElReady;
				}
			}
			return false;
		}

		public virtual void LocalMessageExecuting(EntityChangeType changeType) {
			return;
		}

		public virtual void InitDcmOnEntityChanging() {
			if (!CanInitDcmForEntity()) {
				return;
			}
			var dcmEntityUtilities = GetDcmEntityUtilities();
			CanUseDcm = dcmEntityUtilities.GetCanEntityUseDcm(Entity.Schema.UId, Entity.GetChangedColumnValues());
			CancelNotEnabledDcmProcess();
		}

		public virtual void CancelNotEnabledDcmProcess() {
			if (CanUseDcm) {
				UserConnection.IProcessEngine.CancelNotEnabledDcmProcess(Entity.Schema.UId, Entity.PrimaryColumnValue);
			}
		}

		public virtual DcmEntityUtilities GetDcmEntityUtilities() {
			if (DcmEntityUtil == null) {
				DcmEntityUtil = new DcmEntityUtilities(UserConnection);
			}
			return (DcmEntityUtilities)DcmEntityUtil;
		}

		public virtual bool CanInitDcmForEntity() {
			var schema = Entity.Schema;
			return schema != null &&
				schema.Name != "AdminUnitFeatureState" &&
				schema.Name != "Feature";
		}

		public virtual void IndexEntity(IndexingOperationType indexingOperationType, Guid primaryColumnValue) {
		}

		#endregion

	}

	#endregion

	#region Class: BaseEntityEventsProcessSchema

	/// <exclude/>
	public class BaseEntityEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public BaseEntityEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BaseEntityEventsProcessSchema(BaseEntityEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BaseEntity_BaseEventsProcess";
			UId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateProcessListenersParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4cb2c84d-f135-405d-a831-fc8a8e337b80"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"ProcessListeners",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateProcessSchemaListenersParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b41b6ac0-51c3-464f-a4ca-1f8f7ac35eb9"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"ProcessSchemaListeners",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNextProcessElementReadyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d9e67329-fde2-4fbd-aa49-2d69ca3d2b5b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"NextProcessElementReady",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsProcessModeSaveParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4cb16350-d39b-4247-9da5-33032cf8667d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"IsProcessModeSave",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCanUseDcmParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d185837a-b568-43f2-a09a-28512af1957a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"CanUseDcm",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDcmEntityUtilParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d2be9529-efa0-4912-b579-5692b08ddd03"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"DcmEntityUtil",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateProcessListenersParameter());
			Parameters.Add(CreateProcessSchemaListenersParameter());
			Parameters.Add(CreateNextProcessElementReadyParameter());
			Parameters.Add(CreateIsProcessModeSaveParameter());
			Parameters.Add(CreateCanUseDcmParameter());
			Parameters.Add(CreateDcmEntityUtilParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaBaseEntityLaneSet1 = CreateBaseEntityLaneSet1LaneSet();
			LaneSets.Add(schemaBaseEntityLaneSet1);
			ProcessSchemaLane schemaBaseEntityLane2 = CreateBaseEntityLane2Lane();
			schemaBaseEntityLaneSet1.Lanes.Add(schemaBaseEntityLane2);
			ProcessSchemaEventSubProcess baseentitydeletingeventsubprocess2 = CreateBaseEntityDeletingEventSubProcess2EventSubProcess();
			FlowElements.Add(baseentitydeletingeventsubprocess2);
			ProcessSchemaEventSubProcess baseentityeventsubprocess1 = CreateBaseEntityEventSubProcess1EventSubProcess();
			FlowElements.Add(baseentityeventsubprocess1);
			ProcessSchemaEventSubProcess baseinsertedeventsubprocess = CreateBaseInsertedEventSubProcessEventSubProcess();
			FlowElements.Add(baseinsertedeventsubprocess);
			ProcessSchemaEventSubProcess baseentitysavingeventsubprocess = CreateBaseEntitySavingEventSubProcessEventSubProcess();
			FlowElements.Add(baseentitysavingeventsubprocess);
			ProcessSchemaEventSubProcess baseenityvalidatingeventsubprocess_f0646c74f291474f9a10143ee868f1c9 = CreateBaseEnityValidatingEventSubProcess_f0646c74f291474f9a10143ee868f1c9EventSubProcess();
			FlowElements.Add(baseenityvalidatingeventsubprocess_f0646c74f291474f9a10143ee868f1c9);
			ProcessSchemaEventSubProcess baseentitydeletedsubprocess = CreateBaseEntityDeletedSubProcessEventSubProcess();
			FlowElements.Add(baseentitydeletedsubprocess);
			ProcessSchemaStartMessageEvent baseentitydeletingstartmessage2 = CreateBaseEntityDeletingStartMessage2StartMessageEvent();
			baseentitydeletingeventsubprocess2.FlowElements.Add(baseentitydeletingstartmessage2);
			ProcessSchemaScriptTask tryprocesscompletescripttask2 = CreateTryProcessCompleteScriptTask2ScriptTask();
			baseentitydeletingeventsubprocess2.FlowElements.Add(tryprocesscompletescripttask2);
			ProcessSchemaStartMessageEvent baseentitystartmessage1 = CreateBaseEntityStartMessage1StartMessageEvent();
			baseentityeventsubprocess1.FlowElements.Add(baseentitystartmessage1);
			ProcessSchemaScriptTask tryprocesscompletescripttask1 = CreateTryProcessCompleteScriptTask1ScriptTask();
			baseentityeventsubprocess1.FlowElements.Add(tryprocesscompletescripttask1);
			ProcessSchemaScriptTask baseentitysavedindexingtask = CreateBaseEntitySavedIndexingTaskScriptTask();
			baseentityeventsubprocess1.FlowElements.Add(baseentitysavedindexingtask);
			ProcessSchemaStartMessageEvent insertedstartmessage1 = CreateInsertedStartMessage1StartMessageEvent();
			baseinsertedeventsubprocess.FlowElements.Add(insertedstartmessage1);
			ProcessSchemaScriptTask scripttaskinsertedbaseentity = CreateScriptTaskInsertedBaseEntityScriptTask();
			baseinsertedeventsubprocess.FlowElements.Add(scripttaskinsertedbaseentity);
			ProcessSchemaStartMessageEvent baseentitysavingstartmessage = CreateBaseEntitySavingStartMessageStartMessageEvent();
			baseentitysavingeventsubprocess.FlowElements.Add(baseentitysavingstartmessage);
			ProcessSchemaScriptTask baseentitysavingscripttask = CreateBaseEntitySavingScriptTaskScriptTask();
			baseentitysavingeventsubprocess.FlowElements.Add(baseentitysavingscripttask);
			ProcessSchemaStartMessageEvent baseenityvalidatingstartmessage_b3d5b61f7afe48b5a8cc40317ea9c428 = CreateBaseEnityValidatingStartMessage_b3d5b61f7afe48b5a8cc40317ea9c428StartMessageEvent();
			baseenityvalidatingeventsubprocess_f0646c74f291474f9a10143ee868f1c9.FlowElements.Add(baseenityvalidatingstartmessage_b3d5b61f7afe48b5a8cc40317ea9c428);
			ProcessSchemaScriptTask baseenityvalidatingscripttask_a553628ef6dc4e09bdcf27e446fdc16f = CreateBaseEnityValidatingScriptTask_a553628ef6dc4e09bdcf27e446fdc16fScriptTask();
			baseenityvalidatingeventsubprocess_f0646c74f291474f9a10143ee868f1c9.FlowElements.Add(baseenityvalidatingscripttask_a553628ef6dc4e09bdcf27e446fdc16f);
			ProcessSchemaStartMessageEvent baseentitydeletedstartmessage = CreateBaseEntityDeletedStartMessageStartMessageEvent();
			baseentitydeletedsubprocess.FlowElements.Add(baseentitydeletedstartmessage);
			ProcessSchemaScriptTask baseentitydeletedscripttask = CreateBaseEntityDeletedScriptTaskScriptTask();
			baseentitydeletedsubprocess.FlowElements.Add(baseentitydeletedscripttask);
			FlowElements.Add(CreateBaseEntitySavedSequenceFlowSequenceFlow());
			FlowElements.Add(CreateBaseEntityDeletingSequenceFlowSequenceFlow());
			FlowElements.Add(CreateBaseEntityInsertedSequenceFlowSequenceFlow());
			FlowElements.Add(CreateBaseEntitySavingSequenceFlowSequenceFlow());
			FlowElements.Add(CreateSequenceFlow1_8a5a0739a2a3458194762909c2e98c39SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2_a53d2c03849b47b69032066c63d26056SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3_76ca325dc9c64992b7d611b890506ae3SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateBaseEntitySavedSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "BaseEntitySavedSequenceFlow",
				UId = new Guid("db2f2393-5d29-47cf-a756-8e26392d342f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CurveCenterPosition = new Point(186, 104),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d8b8410f-5c8a-4ddc-8fc2-353483452aed"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9494818b-220e-4e19-a635-fdca641dde5f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateBaseEntityDeletingSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "BaseEntityDeletingSequenceFlow",
				UId = new Guid("60ca0a5b-c2b5-4ee3-acd8-f25e9e91ec44"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CurveCenterPosition = new Point(146, 84),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("496d4a3c-b644-4a65-b0ed-2534d9236da5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("441daff4-4808-48db-ac28-d9a42d61ac31"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateBaseEntityInsertedSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "BaseEntityInsertedSequenceFlow",
				UId = new Guid("7feb971a-3b75-486d-bb0b-92352f82a420"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CurveCenterPosition = new Point(176, 464),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d7c806b7-a29b-4ce5-9167-b3319472e772"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5528724d-213b-4ae6-88d5-aa7301a1dbb0"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateBaseEntitySavingSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "BaseEntitySavingSequenceFlow",
				UId = new Guid("2f317c63-b9de-4594-befc-1e8413c1ddfe"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CurveCenterPosition = new Point(166, 645),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("933bf2fc-d052-40c8-a3e0-bf60049da5d8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9b990da0-84e4-4aa1-ab8f-219ff3a429fa"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1_8a5a0739a2a3458194762909c2e98c39SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1_8a5a0739a2a3458194762909c2e98c39",
				UId = new Guid("8a5a0739-a2a3-4581-9476-2909c2e98c39"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66a8ee77-0273-43da-9932-09be7da9cf49"),
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b3d5b61f-7afe-48b5-a8cc-40317ea9c428"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a553628e-f6dc-4e09-bdcf-27e446fdc16f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2_a53d2c03849b47b69032066c63d26056SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2_a53d2c03849b47b69032066c63d26056",
				UId = new Guid("a53d2c03-849b-47b6-9032-066c63d26056"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c803a450-c8dc-47a4-b704-7125c23db317"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("60f96d87-85be-4d31-856d-8edd6bb953c1"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3_76ca325dc9c64992b7d611b890506ae3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3_76ca325dc9c64992b7d611b890506ae3",
				UId = new Guid("76ca325d-c9c6-4992-b7d6-11b890506ae3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d8b8410f-5c8a-4ddc-8fc2-353483452aed"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b8ff0739-6ead-4da7-ac8d-538cfc641fcf"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(130, 274));
			schemaFlow.PolylinePointPositions.Add(new Point(130, 366));
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateBaseEntityLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaBaseEntityLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("619c2403-5046-4076-b4ec-5421200d9785"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"BaseEntityLaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(970, 737),
				UseBackgroundMode = false
			};
			return schemaBaseEntityLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateBaseEntityLane2Lane() {
			ProcessSchemaLane schemaBaseEntityLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("19e7ec04-e7a3-41f0-8a85-11a18bb147c1"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("619c2403-5046-4076-b4ec-5421200d9785"),
				CreatedInOwnerSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"BaseEntityLane2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(941, 737),
				UseBackgroundMode = false
			};
			return schemaBaseEntityLane2;
		}

		protected virtual ProcessSchemaEventSubProcess CreateBaseEntityDeletingEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaBaseEntityDeletingEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("08594d74-60b0-45ce-bf17-bac1a8b127f7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("19e7ec04-e7a3-41f0-8a85-11a18bb147c1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"BaseEntityDeletingEventSubProcess2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 20),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(237, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaBaseEntityDeletingEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBaseEntityDeletingStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("496d4a3c-b644-4a65-b0ed-2534d9236da5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08594d74-60b0-45ce-bf17-bac1a8b127f7"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"BaseEntityDeleting",
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"BaseEntityDeletingStartMessage2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(35, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateTryProcessCompleteScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("441daff4-4808-48db-ac28-d9a42d61ac31"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08594d74-60b0-45ce-bf17-bac1a8b127f7"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"TryProcessCompleteScriptTask2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(126, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,41,170,12,40,202,79,78,45,46,118,206,207,45,200,73,45,73,213,112,205,43,201,44,169,116,206,72,204,75,79,13,169,44,72,213,115,73,5,137,167,104,90,115,249,228,39,39,230,248,2,21,39,166,167,186,86,164,38,151,150,100,230,165,227,211,128,102,54,66,15,80,174,40,181,164,180,40,79,161,164,168,52,213,26,0,105,12,91,59,135,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateBaseEntityEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaBaseEntityEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("90027ac8-c9c3-4d21-a4f9-da1cde752cd1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("19e7ec04-e7a3-41f0-8a85-11a18bb147c1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"BaseEntityEventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(35, 196),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(239, 261),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaBaseEntityEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBaseEntityStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d8b8410f-5c8a-4ddc-8fc2-353483452aed"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("90027ac8-c9c3-4d21-a4f9-da1cde752cd1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"BaseEntitySaved",
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"BaseEntityStartMessage1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateTryProcessCompleteScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9494818b-220e-4e19-a635-fdca641dde5f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("90027ac8-c9c3-4d21-a4f9-da1cde752cd1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"TryProcessCompleteScriptTask1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(127, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,40,202,79,78,45,46,118,206,207,45,200,73,45,73,117,173,72,77,46,45,201,204,75,215,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,160,5,238,237,40,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateBaseEntitySavedIndexingTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b8ff0739-6ead-4da7-ac8d-538cfc641fcf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("90027ac8-c9c3-4d21-a4f9-da1cde752cd1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"BaseEntitySavedIndexingTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(127, 143),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,204,75,73,173,112,205,43,201,44,169,212,240,4,177,51,243,210,253,11,82,139,18,75,50,243,243,66,42,11,82,245,192,162,58,10,16,53,122,1,69,153,185,137,69,149,206,249,57,165,185,121,97,137,57,165,169,154,214,92,69,169,37,165,69,121,10,37,69,165,169,214,0,80,189,139,115,81,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateBaseInsertedEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaBaseInsertedEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5f3bfbbe-1820-44ca-92f1-6f993169b2dd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("19e7ec04-e7a3-41f0-8a85-11a18bb147c1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"BaseInsertedEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(35, 515),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(238, 158),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaBaseInsertedEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInsertedStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d7c806b7-a29b-4ce5-9167-b3319472e772"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5f3bfbbe-1820-44ca-92f1-6f993169b2dd"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"BaseEntityInserted",
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"InsertedStartMessage1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskInsertedBaseEntityScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5528724d-213b-4ae6-88d5-aa7301a1dbb0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5f3bfbbe-1820-44ca-92f1-6f993169b2dd"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"ScriptTaskInsertedBaseEntity",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(125, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,41,170,12,40,202,79,78,45,46,118,206,207,45,200,73,45,73,213,112,205,43,201,44,169,116,206,72,204,75,79,13,169,44,72,213,243,204,43,78,45,42,73,77,209,180,230,229,242,201,79,78,204,241,5,42,79,76,79,117,173,72,77,46,45,201,204,75,199,175,5,205,124,132,46,144,100,81,106,73,105,81,158,66,73,81,105,170,53,0,159,192,153,80,140,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateBaseEntitySavingEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaBaseEntitySavingEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("dbf48103-dcf6-4f53-a052-d727a95ea0b4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("19e7ec04-e7a3-41f0-8a85-11a18bb147c1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"BaseEntitySavingEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(23, 700),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(231, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaBaseEntitySavingEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBaseEntitySavingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("933bf2fc-d052-40c8-a3e0-bf60049da5d8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dbf48103-dcf6-4f53-a052-d727a95ea0b4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"BaseEntitySaving",
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"BaseEntitySavingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(35, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateBaseEntitySavingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9b990da0-84e4-4aa1-ab8f-219ff3a429fa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dbf48103-dcf6-4f53-a052-d727a95ea0b4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"BaseEntitySavingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(124, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,142,65,14,130,48,16,69,215,52,225,14,93,194,134,11,24,86,192,194,68,193,4,60,64,45,95,172,129,150,148,33,74,196,187,91,212,5,43,227,114,102,222,123,25,117,230,65,166,73,209,20,149,100,172,210,77,73,130,192,227,152,127,231,226,116,133,164,247,54,202,113,243,153,231,205,51,255,223,73,209,130,80,135,252,225,84,11,26,173,230,100,71,108,124,246,244,217,86,43,74,101,87,232,79,48,185,8,221,184,64,16,186,115,101,167,131,53,18,195,144,152,174,95,42,193,138,66,53,245,136,142,125,45,150,186,195,119,70,138,118,239,104,209,32,187,67,142,180,132,126,25,235,111,94,145,230,24,181,9,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateBaseEnityValidatingEventSubProcess_f0646c74f291474f9a10143ee868f1c9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaBaseEnityValidatingEventSubProcess_f0646c74f291474f9a10143ee868f1c9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f0646c74-f291-474f-9a10-143ee868f1c9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("19e7ec04-e7a3-41f0-8a85-11a18bb147c1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66a8ee77-0273-43da-9932-09be7da9cf49"),
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"BaseEnityValidatingEventSubProcess_f0646c74f291474f9a10143ee868f1c9",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(401, 375),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(259, 225),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaBaseEnityValidatingEventSubProcess_f0646c74f291474f9a10143ee868f1c9;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBaseEnityValidatingStartMessage_b3d5b61f7afe48b5a8cc40317ea9c428StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b3d5b61f-7afe-48b5-a8cc-40317ea9c428"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f0646c74-f291-474f-9a10-143ee868f1c9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66a8ee77-0273-43da-9932-09be7da9cf49"),
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"BaseEntityValidating",
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"BaseEnityValidatingStartMessage_b3d5b61f7afe48b5a8cc40317ea9c428",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(43, 95),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateBaseEnityValidatingScriptTask_a553628ef6dc4e09bdcf27e446fdc16fScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a553628e-f6dc-4e09-bdcf-27e446fdc16f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f0646c74-f291-474f-9a10-143ee868f1c9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66a8ee77-0273-43da-9932-09be7da9cf49"),
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"BaseEnityValidatingScriptTask_a553628ef6dc4e09bdcf27e446fdc16f",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(146, 81),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,143,189,10,194,64,16,132,107,5,223,225,176,74,64,242,2,254,52,26,69,176,16,69,251,51,25,101,225,178,193,219,77,33,226,187,187,154,70,76,97,33,108,177,12,51,59,223,210,217,37,115,207,7,193,162,168,82,119,31,244,123,182,228,172,164,183,131,82,32,37,136,43,187,210,212,173,160,93,107,146,142,237,68,215,159,29,125,160,210,235,171,102,135,107,67,17,101,30,80,129,53,105,173,35,3,169,67,64,161,84,243,100,27,235,2,34,27,18,5,35,206,210,47,65,222,61,100,244,134,30,231,53,115,27,204,140,106,45,75,120,109,34,114,246,167,128,50,25,90,233,94,253,5,178,69,172,72,196,140,50,76,219,119,127,192,190,115,31,177,63,104,31,131,190,77,132,161,177,211,216,96,252,4,208,186,92,35,126,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateBaseEntityDeletedSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaBaseEntityDeletedSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("8140d7e7-fb91-4999-8347-543345440efb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("19e7ec04-e7a3-41f0-8a85-11a18bb147c1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"BaseEntityDeletedSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(400, 20),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(304, 300),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaBaseEntityDeletedSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBaseEntityDeletedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c803a450-c8dc-47a4-b704-7125c23db317"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8140d7e7-fb91-4999-8347-543345440efb"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"BaseEntityDeleted",
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"BaseEntityDeletedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(24, 97),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateBaseEntityDeletedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("60f96d87-85be-4d31-856d-8edd6bb953c1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8140d7e7-fb91-4999-8347-543345440efb"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"BaseEntityDeletedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(191, 83),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,204,75,73,173,112,205,43,201,44,169,212,240,4,177,51,243,210,253,11,82,139,18,75,50,243,243,66,42,11,82,245,92,82,115,82,75,82,117,20,32,138,244,2,138,50,115,19,139,42,157,243,115,74,115,243,194,18,115,74,83,53,173,185,138,82,75,74,139,242,20,74,138,74,83,173,1,234,61,31,148,82,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateTryProcessCompleteMethod());
			Methods.Add(CreateIsConditionDataMatchMethod());
			Methods.Add(CreateIsChangedColumnsMatchMethod());
			Methods.Add(CreateProcessCompleteExecutingMethod());
			Methods.Add(CreateGetNextPrcElReadyPropertyValueMethod());
			Methods.Add(CreateLocalMessageExecutingMethod());
			Methods.Add(CreateInitDcmOnEntityChangingMethod());
			Methods.Add(CreateCancelNotEnabledDcmProcessMethod());
			Methods.Add(CreateGetDcmEntityUtilitiesMethod());
			Methods.Add(CreateCanInitDcmForEntityMethod());
			Methods.Add(CreateIndexEntityMethod());
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

		protected virtual SchemaMethod CreateTryProcessCompleteMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c0d8bba4-dffd-407d-80c4-96eab1dee3b7"),
				Name = "TryProcessComplete",
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("fa0b30df-b93a-4d5d-81fa-67f03498b18a"),
				Name = "changeType",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntityChangeType",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,40,40,202,79,78,45,46,118,205,75,207,204,75,85,176,85,8,45,78,45,114,206,207,203,75,77,46,201,204,207,211,11,64,150,182,230,130,114,125,50,139,75,82,243,82,139,138,129,26,80,12,208,115,79,45,65,87,163,129,106,164,142,130,107,94,73,102,73,165,142,66,114,70,98,94,122,106,72,101,65,170,38,220,228,224,228,140,212,220,68,98,204,71,83,169,129,205,84,0,40,79,22,116,225,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateIsConditionDataMatchMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("17949479-4e70-4e31-a9f7-fa66642f5d70"),
				Name = "IsConditionDataMatch",
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2809aebd-1fa6-491b-92f0-9753f8acb2a8"),
				Name = "conditionData",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,84,193,110,219,48,12,61,59,64,254,65,233,201,6,2,97,247,174,3,218,52,25,140,2,93,135,173,189,171,54,211,10,147,165,84,162,58,120,107,254,125,164,229,38,113,157,181,23,67,17,249,30,223,35,169,232,181,200,3,122,109,31,100,25,174,163,49,223,252,178,217,96,155,87,206,214,26,181,179,151,10,85,81,136,191,211,73,230,1,163,183,2,125,132,211,233,100,59,157,60,43,47,32,60,137,51,97,225,183,88,90,212,216,254,168,30,161,81,223,35,248,54,79,55,50,93,21,132,41,71,57,43,109,16,124,137,208,136,117,119,92,56,99,160,226,202,76,75,138,8,134,190,237,4,112,189,24,56,199,218,148,115,238,31,98,3,22,123,9,20,32,55,177,66,231,95,35,249,201,16,113,50,23,183,131,11,214,213,49,111,188,171,32,4,54,76,81,244,170,194,85,47,201,62,131,167,3,85,89,24,21,194,74,113,133,150,112,153,252,10,248,185,188,249,16,250,37,63,46,188,171,126,196,249,199,98,100,127,250,233,222,105,106,78,227,153,139,225,48,121,118,162,82,88,61,238,154,234,76,189,56,204,97,163,135,191,229,37,144,122,173,140,254,3,249,136,45,187,119,206,12,56,22,174,217,24,64,168,137,104,204,157,230,42,94,94,70,49,242,20,121,152,103,226,19,243,106,218,206,217,81,222,180,144,217,218,121,80,228,35,103,19,59,93,66,219,17,115,15,200,254,167,178,95,85,154,38,141,33,54,246,78,153,8,195,5,150,41,18,56,233,162,189,45,235,125,39,228,21,180,69,33,151,79,81,153,112,112,221,177,116,45,202,58,51,239,121,201,178,123,50,243,43,37,111,249,203,159,237,254,221,29,5,167,135,200,220,163,37,154,165,62,39,122,218,3,121,94,215,201,194,27,95,55,94,55,202,183,41,38,175,85,147,36,51,36,109,82,96,232,168,192,238,225,64,199,70,77,100,4,53,39,177,231,195,103,54,127,109,241,160,218,190,65,189,201,158,107,182,123,251,228,238,240,127,231,31,124,83,241,37,177,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateIsChangedColumnsMatchMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("78f61ec9-4082-4591-8a60-4d04f119d4d0"),
				Name = "IsChangedColumnsMatch",
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("58969596-6572-4f51-85df-af7731748523"),
				Name = "changedColumns",
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,144,209,106,195,32,20,134,175,245,41,188,52,48,124,129,116,189,88,22,74,7,91,11,101,187,119,201,73,99,49,186,233,177,144,150,188,251,108,76,33,217,24,8,202,57,158,255,251,56,170,97,220,163,83,230,40,182,254,45,104,189,115,101,247,133,61,175,90,105,142,80,23,86,135,206,248,44,99,87,74,28,96,112,134,161,11,144,211,129,158,165,99,203,111,175,128,114,47,177,245,236,145,189,120,107,10,107,206,224,80,60,131,7,167,164,86,23,216,125,158,160,194,85,28,208,241,86,214,172,18,126,189,254,141,204,105,99,29,200,170,229,35,104,172,222,1,76,153,255,208,89,20,253,99,22,125,74,131,10,123,113,168,90,232,164,216,0,166,87,234,63,245,247,121,190,4,69,11,50,105,176,153,199,135,212,1,110,18,83,106,140,43,230,188,177,239,121,90,27,81,113,201,155,160,106,81,126,7,169,61,159,101,136,244,95,188,111,235,135,165,242,173,52,205,47,23,79,200,64,227,25,232,84,109,98,36,228,63,39,236,177,40,201,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateProcessCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b7ab00fa-78f2-45c8-bfbd-45c87419f931"),
				Name = "ProcessCompleteExecuting",
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,83,193,106,194,64,16,61,155,175,88,47,18,65,66,239,105,133,86,115,16,138,136,210,15,216,174,163,46,172,179,178,187,177,218,234,191,119,140,213,100,179,17,75,161,183,176,51,243,230,189,55,47,91,110,216,198,104,1,214,102,184,148,8,236,137,189,89,48,3,141,8,194,73,141,201,164,90,78,163,109,57,241,42,173,3,4,99,105,40,30,104,165,206,19,143,19,191,220,239,214,30,172,135,50,19,43,88,243,59,88,126,211,21,177,54,155,70,158,150,228,89,184,156,43,249,9,205,237,113,134,78,186,125,239,6,147,110,26,133,68,134,96,133,145,27,167,77,255,50,86,62,17,129,119,173,21,67,216,185,137,17,153,154,2,159,239,73,209,130,43,75,222,141,78,216,129,61,76,40,141,48,175,155,68,99,152,43,149,70,114,193,226,192,241,246,185,202,58,157,224,26,201,64,231,232,88,159,61,116,217,87,212,186,141,14,31,172,145,80,176,141,156,104,133,98,9,194,183,155,66,227,36,230,144,237,64,228,244,181,140,253,40,245,88,205,112,111,193,66,27,224,98,197,226,192,233,208,104,38,177,193,253,66,110,43,48,191,246,112,56,132,163,201,200,142,169,43,83,176,6,116,69,31,49,58,94,85,87,188,85,192,77,76,124,143,197,93,6,28,73,227,80,172,139,221,190,29,211,28,169,240,163,6,202,180,53,31,164,128,108,72,207,203,126,38,151,200,85,153,162,74,30,234,255,78,152,138,90,71,45,27,191,56,42,169,40,37,220,185,103,248,3,253,211,85,43,166,220,40,252,229,202,129,87,254,173,219,254,170,130,215,157,176,93,232,156,32,198,69,229,108,109,133,1,205,220,170,144,6,31,46,253,6,195,32,217,53,175,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetNextPrcElReadyPropertyValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("01ff42c7-a838-4ed1-bace-6944b39c75f5"),
				Name = "GetNextPrcElReadyPropertyValue",
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("75e66940-a0e0-4751-bec7-0f16c6039621"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6d09c3f4-0033-432e-93f6-7193713cd891"),
				Name = "entity",
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("75e66940-a0e0-4751-bec7-0f16c6039621")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,141,193,10,194,48,16,68,207,45,244,31,214,30,74,2,210,31,16,143,197,155,20,17,239,105,220,66,101,77,202,38,1,131,248,239,134,212,122,80,152,211,204,155,153,105,4,129,198,79,62,194,102,15,38,16,65,211,192,226,180,61,91,141,206,173,137,132,103,85,22,118,184,161,246,96,240,225,123,214,29,157,80,93,227,46,5,211,119,106,45,182,103,142,7,76,152,157,145,125,188,40,10,40,234,99,110,102,160,35,188,167,74,158,168,183,96,195,239,174,92,62,11,70,31,216,128,24,172,37,249,127,253,170,202,164,15,52,42,114,152,220,55,73,143,210,99,219,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateLocalMessageExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("fe742d1c-4346-4cc5-894e-217df991856c"),
				Name = "LocalMessageExecuting",
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("53c6a55b-73f6-4900-9445-a818892f6106"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("58200769-785a-41c8-8f29-80d4bb9c8db0"),
				Name = "changeType",
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntityChangeType",
				CreatedInPackageId = new Guid("53c6a55b-73f6-4900-9445-a818892f6106")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,179,6,0,7,133,17,243,7,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitDcmOnEntityChangingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("214cb6df-1a0d-41cb-9c18-868aae8d679c"),
				Name = "InitDcmOnEntityChanging",
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,142,193,10,194,48,16,68,207,230,43,226,45,5,233,15,20,79,181,74,47,34,72,188,199,100,181,129,100,3,201,86,16,241,223,77,76,79,122,220,153,55,51,107,111,92,172,123,133,35,90,218,105,191,15,113,64,178,244,20,77,195,95,108,21,129,230,136,29,123,179,135,138,220,104,95,93,73,214,89,178,144,248,150,31,160,4,127,116,209,116,44,183,202,4,217,203,208,127,178,205,185,76,44,234,151,19,245,104,207,122,2,175,90,57,154,13,95,164,2,79,10,239,96,250,224,102,143,23,229,230,178,82,103,52,184,99,160,1,213,213,129,201,69,167,24,52,164,242,196,7,84,217,64,167,223,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCancelNotEnabledDcmProcessMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("238d7cd6-4f2b-4326-8116-cce53b7df4b5"),
				Name = "CancelNotEnabledDcmProcess",
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,45,139,177,10,131,48,16,64,103,253,138,140,10,37,63,208,49,102,112,41,130,216,253,122,158,122,144,220,65,18,7,41,253,247,102,112,123,60,222,227,205,116,14,100,201,52,96,236,205,183,109,42,38,167,34,132,133,85,236,56,37,69,202,217,203,206,66,182,182,72,225,165,197,11,124,2,173,245,186,131,206,75,225,114,217,25,15,138,96,151,113,125,152,91,77,137,35,164,203,105,56,163,188,33,156,212,63,219,223,31,25,44,197,224,123,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetDcmEntityUtilitiesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("742e6cb7-e7ee-49aa-9b39-4bada7c5eb7c"),
				Name = "GetDcmEntityUtilities",
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "DcmEntityUtilities"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,112,73,206,117,205,43,201,44,169,12,45,201,204,81,176,181,85,200,43,205,201,209,84,168,230,226,68,147,81,200,75,45,87,64,17,203,44,201,76,45,214,8,45,78,45,114,206,207,203,75,77,46,201,204,207,211,180,230,170,229,42,74,45,41,45,202,67,51,27,172,90,19,69,200,26,0,52,16,170,131,129,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCanInitDcmForEntityMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6c21eae7-c982-48db-9278-fdc86adbddc8"),
				Name = "CanInitDcmForEntity",
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,40,78,206,72,205,77,84,176,85,112,205,43,201,44,169,212,11,6,243,173,185,138,82,75,74,139,242,96,210,138,182,10,121,165,57,57,10,106,106,92,156,16,33,61,191,196,220,84,144,184,146,99,74,110,102,94,104,94,102,137,91,106,34,80,79,106,112,73,98,73,170,18,86,165,80,21,74,214,0,116,115,35,28,122,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateIndexEntityMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b74defb2-0455-4137-8ae8-3cfe18ee79dc"),
				Name = "IndexEntity",
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("cfd37a73-611b-4526-9f5c-df2c71da9ced"),
				Name = "indexingOperationType",
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "IndexingOperationType",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8b4753be-7498-484a-9c09-5589f2b8f078"),
				Name = "primaryColumnValue",
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			method.ZipBody = new byte[] {  };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseEntityEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"));
		}

		#endregion

	}

	#endregion


	#region Class: BaseEntityEventsProcess

	/// <exclude/>
	public class BaseEntityEventsProcess : BaseEntity_BaseEventsProcess
	{

		public BaseEntityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

