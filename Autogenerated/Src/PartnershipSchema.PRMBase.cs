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

	#region Class: Partnership_PRMBase_TerrasoftSchema

	/// <exclude/>
	public class Partnership_PRMBase_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public Partnership_PRMBase_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Partnership_PRMBase_TerrasoftSchema(Partnership_PRMBase_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Partnership_PRMBase_TerrasoftSchema(Partnership_PRMBase_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f247949a-7c07-4fc7-9a6a-31940b457e5d");
			RealUId = new Guid("f247949a-7c07-4fc7-9a6a-31940b457e5d");
			Name = "Partnership_PRMBase_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("3644c994-8f85-41ec-8125-47013bac161f");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("72a684b2-baa7-4389-8ed2-84d1b6b9ab9f")) == null) {
				Columns.Add(CreateAccountColumn());
			}
			if (Columns.FindByUId(new Guid("bc5fdb3b-b6ee-4f31-9a56-5c713cd82b40")) == null) {
				Columns.Add(CreatePartnerLevelColumn());
			}
			if (Columns.FindByUId(new Guid("9b465ac9-cb0e-4418-bfcf-eeb3b79ed51d")) == null) {
				Columns.Add(CreateStartDateColumn());
			}
			if (Columns.FindByUId(new Guid("17e2fac9-f01b-4392-a9d6-be80c85d5ab1")) == null) {
				Columns.Add(CreateDueDateColumn());
			}
			if (Columns.FindByUId(new Guid("2a6447d4-3c79-4ceb-8b02-aa3eeb1ba11e")) == null) {
				Columns.Add(CreateIsActiveColumn());
			}
			if (Columns.FindByUId(new Guid("52f0ff51-ba26-4402-83bd-056065ca393f")) == null) {
				Columns.Add(CreatePartnerTypeColumn());
			}
			if (Columns.FindByUId(new Guid("05340663-5114-422d-a4dc-3fc6074a5fbd")) == null) {
				Columns.Add(CreateScoreLeftColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("f247949a-7c07-4fc7-9a6a-31940b457e5d");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("f247949a-7c07-4fc7-9a6a-31940b457e5d");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("f247949a-7c07-4fc7-9a6a-31940b457e5d");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("f247949a-7c07-4fc7-9a6a-31940b457e5d");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("f247949a-7c07-4fc7-9a6a-31940b457e5d");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("f247949a-7c07-4fc7-9a6a-31940b457e5d");
			return column;
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Text")) {
				UId = new Guid("5525b0a8-acba-4838-90d7-e48b01f1db54"),
				Name = @"Name",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("f247949a-7c07-4fc7-9a6a-31940b457e5d"),
				ModifiedInSchemaUId = new Guid("f247949a-7c07-4fc7-9a6a-31940b457e5d"),
				CreatedInPackageId = new Guid("047f00c4-7c65-4fe2-bb2b-f56703cb1187")
			};
		}

		protected virtual EntitySchemaColumn CreateAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("72a684b2-baa7-4389-8ed2-84d1b6b9ab9f"),
				Name = @"Account",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("f247949a-7c07-4fc7-9a6a-31940b457e5d"),
				ModifiedInSchemaUId = new Guid("f247949a-7c07-4fc7-9a6a-31940b457e5d"),
				CreatedInPackageId = new Guid("047f00c4-7c65-4fe2-bb2b-f56703cb1187")
			};
		}

		protected virtual EntitySchemaColumn CreatePartnerLevelColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("bc5fdb3b-b6ee-4f31-9a56-5c713cd82b40"),
				Name = @"PartnerLevel",
				ReferenceSchemaUId = new Guid("0e098241-437e-4443-b864-0c5cc0cd1a80"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("f247949a-7c07-4fc7-9a6a-31940b457e5d"),
				ModifiedInSchemaUId = new Guid("f247949a-7c07-4fc7-9a6a-31940b457e5d"),
				CreatedInPackageId = new Guid("047f00c4-7c65-4fe2-bb2b-f56703cb1187"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"0ca08806-1b48-4954-9fa7-d8ebd71545ab"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateStartDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("9b465ac9-cb0e-4418-bfcf-eeb3b79ed51d"),
				Name = @"StartDate",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("f247949a-7c07-4fc7-9a6a-31940b457e5d"),
				ModifiedInSchemaUId = new Guid("f247949a-7c07-4fc7-9a6a-31940b457e5d"),
				CreatedInPackageId = new Guid("047f00c4-7c65-4fe2-bb2b-f56703cb1187")
			};
		}

		protected virtual EntitySchemaColumn CreateDueDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("17e2fac9-f01b-4392-a9d6-be80c85d5ab1"),
				Name = @"DueDate",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("f247949a-7c07-4fc7-9a6a-31940b457e5d"),
				ModifiedInSchemaUId = new Guid("f247949a-7c07-4fc7-9a6a-31940b457e5d"),
				CreatedInPackageId = new Guid("047f00c4-7c65-4fe2-bb2b-f56703cb1187")
			};
		}

		protected virtual EntitySchemaColumn CreateIsActiveColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("2a6447d4-3c79-4ceb-8b02-aa3eeb1ba11e"),
				Name = @"IsActive",
				CreatedInSchemaUId = new Guid("f247949a-7c07-4fc7-9a6a-31940b457e5d"),
				ModifiedInSchemaUId = new Guid("f247949a-7c07-4fc7-9a6a-31940b457e5d"),
				CreatedInPackageId = new Guid("047f00c4-7c65-4fe2-bb2b-f56703cb1187")
			};
		}

		protected virtual EntitySchemaColumn CreatePartnerTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("52f0ff51-ba26-4402-83bd-056065ca393f"),
				Name = @"PartnerType",
				ReferenceSchemaUId = new Guid("43cadf79-8d33-4697-8344-ec24fa905332"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("f247949a-7c07-4fc7-9a6a-31940b457e5d"),
				ModifiedInSchemaUId = new Guid("f247949a-7c07-4fc7-9a6a-31940b457e5d"),
				CreatedInPackageId = new Guid("047f00c4-7c65-4fe2-bb2b-f56703cb1187"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"d6d8342c-bad2-4161-8aa8-547394b98b49"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateScoreLeftColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("05340663-5114-422d-a4dc-3fc6074a5fbd"),
				Name = @"ScoreLeft",
				CreatedInSchemaUId = new Guid("f247949a-7c07-4fc7-9a6a-31940b457e5d"),
				ModifiedInSchemaUId = new Guid("f247949a-7c07-4fc7-9a6a-31940b457e5d"),
				CreatedInPackageId = new Guid("ad40b837-06de-4802-b0a3-084f3cf30f81")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreatePartnership_PRMBase_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreatePartnership_PRMBase_TerrasoftEventsProcessSchema() {
			var schema = new Partnership_PRMBase_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Partnership_PRMBase_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Partnership_PRMBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Partnership_PRMBase_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Partnership_PRMBase_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f247949a-7c07-4fc7-9a6a-31940b457e5d"));
		}

		#endregion

	}

	#endregion

	#region Class: Partnership_PRMBase_Terrasoft

	/// <summary>
	/// Partnership.
	/// </summary>
	public class Partnership_PRMBase_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public Partnership_PRMBase_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Partnership_PRMBase_Terrasoft";
		}

		public Partnership_PRMBase_Terrasoft(Partnership_PRMBase_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Name.
		/// </summary>
		public string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

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
		public Guid PartnerLevelId {
			get {
				return GetTypedColumnValue<Guid>("PartnerLevelId");
			}
			set {
				SetColumnValue("PartnerLevelId", value);
				_partnerLevel = null;
			}
		}

		/// <exclude/>
		public string PartnerLevelName {
			get {
				return GetTypedColumnValue<string>("PartnerLevelName");
			}
			set {
				SetColumnValue("PartnerLevelName", value);
				if (_partnerLevel != null) {
					_partnerLevel.Name = value;
				}
			}
		}

		private PartnerLevel _partnerLevel;
		/// <summary>
		/// Level of partner.
		/// </summary>
		public PartnerLevel PartnerLevel {
			get {
				return _partnerLevel ??
					(_partnerLevel = LookupColumnEntities.GetEntity("PartnerLevel") as PartnerLevel);
			}
		}

		/// <summary>
		/// Start date.
		/// </summary>
		public DateTime StartDate {
			get {
				return GetTypedColumnValue<DateTime>("StartDate");
			}
			set {
				SetColumnValue("StartDate", value);
			}
		}

		/// <summary>
		/// Due date.
		/// </summary>
		public DateTime DueDate {
			get {
				return GetTypedColumnValue<DateTime>("DueDate");
			}
			set {
				SetColumnValue("DueDate", value);
			}
		}

		/// <summary>
		/// Active.
		/// </summary>
		public bool IsActive {
			get {
				return GetTypedColumnValue<bool>("IsActive");
			}
			set {
				SetColumnValue("IsActive", value);
			}
		}

		/// <exclude/>
		public Guid PartnerTypeId {
			get {
				return GetTypedColumnValue<Guid>("PartnerTypeId");
			}
			set {
				SetColumnValue("PartnerTypeId", value);
				_partnerType = null;
			}
		}

		/// <exclude/>
		public string PartnerTypeName {
			get {
				return GetTypedColumnValue<string>("PartnerTypeName");
			}
			set {
				SetColumnValue("PartnerTypeName", value);
				if (_partnerType != null) {
					_partnerType.Name = value;
				}
			}
		}

		private PartnerType _partnerType;
		/// <summary>
		/// Partner type.
		/// </summary>
		public PartnerType PartnerType {
			get {
				return _partnerType ??
					(_partnerType = LookupColumnEntities.GetEntity("PartnerType") as PartnerType);
			}
		}

		/// <summary>
		/// ScoreLeft.
		/// </summary>
		public int ScoreLeft {
			get {
				return GetTypedColumnValue<int>("ScoreLeft");
			}
			set {
				SetColumnValue("ScoreLeft", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Partnership_PRMBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Partnership_PRMBase_TerrasoftDeleted", e);
			Inserted += (s, e) => ThrowEvent("Partnership_PRMBase_TerrasoftInserted", e);
			Saved += (s, e) => ThrowEvent("Partnership_PRMBase_TerrasoftSaved", e);
			Updated += (s, e) => ThrowEvent("Partnership_PRMBase_TerrasoftUpdated", e);
			Updating += (s, e) => ThrowEvent("Partnership_PRMBase_TerrasoftUpdating", e);
			Validating += (s, e) => ThrowEvent("Partnership_PRMBase_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Partnership_PRMBase_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Partnership_PRMBaseEventsProcess

	/// <exclude/>
	public partial class Partnership_PRMBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : Partnership_PRMBase_Terrasoft
	{

		public Partnership_PRMBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Partnership_PRMBaseEventsProcess";
			SchemaUId = new Guid("f247949a-7c07-4fc7-9a6a-31940b457e5d");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f247949a-7c07-4fc7-9a6a-31940b457e5d");
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
					SchemaElementUId = new Guid("38ffbefa-60e7-4a6b-bd17-cd1c11ba4fd0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage1;
		public ProcessFlowElement StartMessage1 {
			get {
				return _startMessage1 ?? (_startMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage1",
					SchemaElementUId = new Guid("5b50c550-a8d2-4b5a-90d6-522a9cef0ceb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _onPartnershipSaved;
		public ProcessScriptTask OnPartnershipSaved {
			get {
				return _onPartnershipSaved ?? (_onPartnershipSaved = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OnPartnershipSaved",
					SchemaElementUId = new Guid("4eac8c13-d02c-4d07-a637-dbc2c4c98774"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OnPartnershipSavedExecute,
				});
			}
		}

		private ProcessFlowElement _partnershipInsertedEventSubProcess;
		public ProcessFlowElement PartnershipInsertedEventSubProcess {
			get {
				return _partnershipInsertedEventSubProcess ?? (_partnershipInsertedEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "PartnershipInsertedEventSubProcess",
					SchemaElementUId = new Guid("71c80eec-a5c6-462c-b9c2-c043d762f664"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage2;
		public ProcessFlowElement StartMessage2 {
			get {
				return _startMessage2 ?? (_startMessage2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage2",
					SchemaElementUId = new Guid("1e8d081b-e402-45b9-9545-edf5e1c82e01"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _onPartnershipInsertedScriptTask;
		public ProcessScriptTask OnPartnershipInsertedScriptTask {
			get {
				return _onPartnershipInsertedScriptTask ?? (_onPartnershipInsertedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OnPartnershipInsertedScriptTask",
					SchemaElementUId = new Guid("914c0a70-48c4-43b0-9792-f4431c7c7cf9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OnPartnershipInsertedScriptTaskExecute,
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
					SchemaElementUId = new Guid("3996b812-de69-4433-96cc-ae7ea2d2eedf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _partnershipUpdated;
		public ProcessFlowElement PartnershipUpdated {
			get {
				return _partnershipUpdated ?? (_partnershipUpdated = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PartnershipUpdated",
					SchemaElementUId = new Guid("94fc97e5-ecec-4b31-8393-2bec88bfba9c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _onPartnershipUpdatedScriptTask;
		public ProcessScriptTask OnPartnershipUpdatedScriptTask {
			get {
				return _onPartnershipUpdatedScriptTask ?? (_onPartnershipUpdatedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OnPartnershipUpdatedScriptTask",
					SchemaElementUId = new Guid("9546c9d0-5f23-4828-815c-3ca993d079a8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OnPartnershipUpdatedScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[OnPartnershipSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { OnPartnershipSaved };
			FlowElements[PartnershipInsertedEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { PartnershipInsertedEventSubProcess };
			FlowElements[StartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2 };
			FlowElements[OnPartnershipInsertedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OnPartnershipInsertedScriptTask };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[PartnershipUpdated.SchemaElementUId] = new Collection<ProcessFlowElement> { PartnershipUpdated };
			FlowElements[OnPartnershipUpdatedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OnPartnershipUpdatedScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("OnPartnershipSaved");
						break;
					case "OnPartnershipSaved":
						break;
					case "PartnershipInsertedEventSubProcess":
						break;
					case "StartMessage2":
						e.Context.QueueTasks.Enqueue("OnPartnershipInsertedScriptTask");
						break;
					case "OnPartnershipInsertedScriptTask":
						break;
					case "EventSubProcess3":
						break;
					case "PartnershipUpdated":
						e.Context.QueueTasks.Enqueue("OnPartnershipUpdatedScriptTask");
						break;
					case "OnPartnershipUpdatedScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage1");
			ActivatedEventElements.Add("StartMessage2");
			ActivatedEventElements.Add("PartnershipUpdated");
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
				case "StartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1";
					result = StartMessage1.Execute(context);
					break;
				case "OnPartnershipSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "OnPartnershipSaved";
					result = OnPartnershipSaved.Execute(context, OnPartnershipSavedExecute);
					break;
				case "PartnershipInsertedEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage2";
					result = StartMessage2.Execute(context);
					break;
				case "OnPartnershipInsertedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OnPartnershipInsertedScriptTask";
					result = OnPartnershipInsertedScriptTask.Execute(context, OnPartnershipInsertedScriptTaskExecute);
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "PartnershipUpdated":
					context.QueueTasks.Dequeue();
					context.SenderName = "PartnershipUpdated";
					result = PartnershipUpdated.Execute(context);
					break;
				case "OnPartnershipUpdatedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OnPartnershipUpdatedScriptTask";
					result = OnPartnershipUpdatedScriptTask.Execute(context, OnPartnershipUpdatedScriptTaskExecute);
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

		public virtual bool OnPartnershipSavedExecute(ProcessExecutingContext context) {
			if (UserConnection.GetIsFeatureEnabled("EnableOldPartnershipLogic")) {
				UpdateActivePartnerships(context);
			}
			return true;
		}

		public virtual bool OnPartnershipInsertedScriptTaskExecute(ProcessExecutingContext context) {
			if (UserConnection.GetIsFeatureEnabled("EnableOldPartnershipLogic")) {
				OnPartnershipInserted(context);
			}
			return true;
		}

		public virtual bool OnPartnershipUpdatedScriptTaskExecute(ProcessExecutingContext context) {
			if (UserConnection.GetIsFeatureEnabled("EnableOldPartnershipLogic")) {
				OnPartnershipUpdated(context);
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Partnership_PRMBase_TerrasoftSaved":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
						}
						break;
					case "Partnership_PRMBase_TerrasoftInserted":
							if (ActivatedEventElements.Contains("StartMessage2")) {
							context.QueueTasks.Enqueue("StartMessage2");
						}
						break;
					case "Partnership_PRMBase_TerrasoftUpdated":
							if (ActivatedEventElements.Contains("PartnershipUpdated")) {
							context.QueueTasks.Enqueue("PartnershipUpdated");
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

	#region Class: Partnership_PRMBaseEventsProcess

	/// <exclude/>
	public class Partnership_PRMBaseEventsProcess : Partnership_PRMBaseEventsProcess<Partnership_PRMBase_Terrasoft>
	{

		public Partnership_PRMBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Partnership_PRMBaseEventsProcess

	public partial class Partnership_PRMBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void UpdateActivePartnerships(ProcessExecutingContext context) {
			var isActive = Entity.GetTypedColumnValue<bool>("IsActive");
			if (isActive) {
				Update update = new Update(UserConnection, "Partnership")
					.Set("IsActive", Column.Parameter(false))
					.Where("Id").IsNotEqual(Column.Parameter(Entity.PrimaryColumnValue))
					.And("AccountId").IsEqual(Column.Parameter(Entity.GetTypedColumnValue<Guid>("AccountId"))) as Update;
				update.Execute();
			}
		}

		public virtual void OnPartnershipInserted(ProcessExecutingContext context) {
			var currentId = PRMBaseConstants.CurrentPartnershipParamTypeId;
			var targetId = PRMBaseConstants.TargetPartnershipParamTypeId;
			var obligationTypeId = PRMBaseConstants.ObligationParameterTypeId;
			var benefitTypeId = PRMBaseConstants.BenefitParameterTypeId;
			
			var partnershipId = Entity.PrimaryColumnValue;
			var partnerLevelId = Entity.GetTypedColumnValue<Guid>("PartnerLevelId");
			
			EntitySchemaManager entitySchemaManager = UserConnection.EntitySchemaManager;
			var benefitEsq = GetLevelPartnershipParamEsq(benefitTypeId, partnerLevelId);
			var benefitCollection = benefitEsq.GetEntityCollection(UserConnection);
			var partnershipParameterSchema = entitySchemaManager.GetInstanceByName("PartnershipParameter");
			foreach (var levelPartnershipParam in benefitCollection) {
				var benefitPartnershipParameter = partnershipParameterSchema.CreateEntity(UserConnection);
				CopyLevelPartnershipParameterValues(benefitPartnershipParameter, levelPartnershipParam);
				benefitPartnershipParameter.SetColumnValue("ParameterTypeId", benefitTypeId);
				benefitPartnershipParameter.SetColumnValue("PartnershipParameterTypeId", currentId);
				benefitPartnershipParameter.SetColumnValue("PartnershipId", partnershipId);
				benefitPartnershipParameter.SetColumnValue("PartnerLevelId", partnerLevelId);
				benefitPartnershipParameter.Save();
			}
			var obligationEsq = GetLevelPartnershipParamEsq(obligationTypeId, partnerLevelId);
			var obligationCollection = obligationEsq.GetEntityCollection(UserConnection);
			foreach (var levelPartnershipParam in obligationCollection) {
				var currentPartnershipParameter = partnershipParameterSchema.CreateEntity(UserConnection);
				var partnerParamCategoryId = levelPartnershipParam.GetTypedColumnValue<Guid>("PartnerParamCategoryId");
				var parameterValueTypeId = levelPartnershipParam.GetTypedColumnValue<Guid>("ParameterValueTypeId");
				currentPartnershipParameter.SetDefColumnValues();
				currentPartnershipParameter.SetColumnValue("ParameterTypeId", obligationTypeId);
				currentPartnershipParameter.SetColumnValue("PartnershipParameterTypeId", currentId);
				currentPartnershipParameter.SetColumnValue("PartnershipId", partnershipId);
				currentPartnershipParameter.SetColumnValue("PartnerParamCategoryId", partnerParamCategoryId);
				currentPartnershipParameter.SetColumnValue("ParameterValueTypeId", parameterValueTypeId);
				currentPartnershipParameter.SetColumnValue("PartnerLevelId", partnerLevelId);
				currentPartnershipParameter.Save();
			}
			foreach (var levelPartnershipParam in obligationCollection) {
				var targetPartnershipParameter = partnershipParameterSchema.CreateEntity(UserConnection);
				CopyLevelPartnershipParameterValues(targetPartnershipParameter, levelPartnershipParam);
				targetPartnershipParameter.SetColumnValue("ParameterTypeId", obligationTypeId);
				targetPartnershipParameter.SetColumnValue("PartnershipParameterTypeId", targetId);
				targetPartnershipParameter.SetColumnValue("PartnershipId", partnershipId);
				targetPartnershipParameter.SetColumnValue("PartnerLevelId", partnerLevelId);
				targetPartnershipParameter.Save();
			}
			PartnershipHelper partnershipHelper
					= ClassFactory.Get<PartnershipHelper>(new ConstructorArgument("userConnection", UserConnection));
			partnershipHelper.SetPartnershipScoreLeft(partnershipId);
		}

		public virtual void OnPartnershipUpdated(ProcessExecutingContext context) {
			var partnerLevel = Entity.GetTypedColumnValue<Guid>("PartnerLevelId");
			var oldPartnerLevel = Entity.GetTypedOldColumnValue<Guid>("PartnerLevelId");
			if (partnerLevel == oldPartnerLevel) {
				return;
			}
			PartnershipHelper partnershipHelper
					= ClassFactory.Get<PartnershipHelper>(new ConstructorArgument("userConnection", UserConnection));
			var partnershipId = Entity.GetTypedColumnValue<Guid>("Id");
			EntityCollection levelPartnershipParameters = partnershipHelper.GetLevelPartnershipParameters(partnerLevel);
			partnershipHelper.DeleteOldBenefits(partnershipId);
			partnershipHelper.DeleteOldTarget(partnershipId);
			List<Guid> listOfNotDeletedCategoryId = levelPartnershipParameters.Select(x => x.GetTypedColumnValue<Guid>("PartnerParamCategoryId")).ToList();
			List<object> list = listOfNotDeletedCategoryId.ConvertAll<object>(new Converter<Guid, object>(g => (object)g));
			partnershipHelper.DeleteCurrentCategory(partnershipId, list.ToArray());
			partnershipHelper.CopyBenefitParameters(partnershipId, partnerLevel, levelPartnershipParameters);
			EntityCollection currentObligations = partnershipHelper.GetCurrentObligations(partnershipId);
			foreach (var partnershipParam in currentObligations) {
				partnershipParam.SetColumnValue("PartnerLevelId", partnerLevel);
				partnershipParam.Save();
			}
			partnershipHelper.AddNewCurrentObligations(partnershipId, partnerLevel, currentObligations, levelPartnershipParameters);
			partnershipHelper.AddNewTargetObligations(partnershipId, partnerLevel, levelPartnershipParameters);
			partnershipHelper.RecalculateAllScore(partnershipId);
			partnershipHelper.ChangePartnershipLevel(partnershipId);
		}

		public virtual EntitySchemaQuery GetLevelPartnershipParamEsq(Guid parameterTypeId, Guid partnerLevelId) {
			EntitySchemaManager entitySchemaManager = UserConnection.EntitySchemaManager;
			EntitySchema entitySchema = entitySchemaManager.GetInstanceByName("LevelPartnershipParam");
			var esq = new EntitySchemaQuery(entitySchema);
			esq.AddColumn("PartnerParamCategory");
			esq.AddColumn("ParameterValueType");
			esq.AddColumn("IntValue");
			esq.AddColumn("StringValue");
			esq.AddColumn("FloatValue");
			esq.AddColumn("BooleanValue");
			esq.AddColumn("Score");
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "PartnerLevel", partnerLevelId));
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "ParameterType", parameterTypeId));
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.LessOrEqual, "StartDate", DateTime.UtcNow));
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.GreaterOrEqual, "DueDate", DateTime.UtcNow));
			return esq;
		}

		public virtual void CopyLevelPartnershipParameterValues(Entity partnershipParameter, Entity levelPartnershipParam) {
			var partnerParamCategoryId = levelPartnershipParam.GetTypedColumnValue<Guid>("PartnerParamCategoryId");
			var parameterValueTypeId = levelPartnershipParam.GetTypedColumnValue<Guid>("ParameterValueTypeId");
			var stringValue = levelPartnershipParam.GetTypedColumnValue<string>("StringValue");
			var intValue = levelPartnershipParam.GetTypedColumnValue<int>("IntValue");
			var floatValue = levelPartnershipParam.GetTypedColumnValue<double>("FloatValue");
			var booleanValue = levelPartnershipParam.GetTypedColumnValue<bool>("BooleanValue");
			var score = levelPartnershipParam.GetTypedColumnValue<int>("Score");
			partnershipParameter.SetDefColumnValues();
			partnershipParameter.SetColumnValue("StringValue", stringValue);
			partnershipParameter.SetColumnValue("IntValue", intValue);
			partnershipParameter.SetColumnValue("FloatValue", floatValue);
			partnershipParameter.SetColumnValue("BooleanValue", booleanValue);
			partnershipParameter.SetColumnValue("Score", score);
			partnershipParameter.SetColumnValue("PartnerParamCategoryId", partnerParamCategoryId);
			partnershipParameter.SetColumnValue("ParameterValueTypeId", parameterValueTypeId);
		}

		#endregion

	}

	#endregion

	#region Class: Partnership_PRMBase_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Partnership_PRMBase_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public Partnership_PRMBase_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Partnership_PRMBase_TerrasoftEventsProcessSchema(Partnership_PRMBase_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Partnership_PRMBaseEventsProcess";
			UId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e");
			CreatedInPackageId = new Guid("3644c994-8f85-41ec-8125-47013bac161f");
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

		protected override ProcessSchemaParameter CreateNextProcessElementReadyParameter() {
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

		protected override ProcessSchemaParameter CreateIsProcessModeSaveParameter() {
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

		protected override ProcessSchemaParameter CreateCanUseDcmParameter() {
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
			ProcessSchemaEventSubProcess partnershipinsertedeventsubprocess = CreatePartnershipInsertedEventSubProcessEventSubProcess();
			FlowElements.Add(partnershipinsertedeventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			eventsubprocess1.FlowElements.Add(startmessage1);
			ProcessSchemaScriptTask onpartnershipsaved = CreateOnPartnershipSavedScriptTask();
			eventsubprocess1.FlowElements.Add(onpartnershipsaved);
			ProcessSchemaStartMessageEvent startmessage2 = CreateStartMessage2StartMessageEvent();
			partnershipinsertedeventsubprocess.FlowElements.Add(startmessage2);
			ProcessSchemaScriptTask onpartnershipinsertedscripttask = CreateOnPartnershipInsertedScriptTaskScriptTask();
			partnershipinsertedeventsubprocess.FlowElements.Add(onpartnershipinsertedscripttask);
			ProcessSchemaStartMessageEvent partnershipupdated = CreatePartnershipUpdatedStartMessageEvent();
			eventsubprocess3.FlowElements.Add(partnershipupdated);
			ProcessSchemaScriptTask onpartnershipupdatedscripttask = CreateOnPartnershipUpdatedScriptTaskScriptTask();
			eventsubprocess3.FlowElements.Add(onpartnershipupdatedscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("94d5f4c3-c617-4f07-ac38-c8c9928e926f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb"),
				CreatedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5b50c550-a8d2-4b5a-90d6-522a9cef0ceb"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4eac8c13-d02c-4d07-a637-dbc2c4c98774"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("afd99f35-522f-41aa-a1a4-be9077554a7c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e6694e82-2be4-4388-8c1e-f340344f5039"),
				CreatedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1e8d081b-e402-45b9-9545-edf5e1c82e01"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("914c0a70-48c4-43b0-9792-f4431c7c7cf9"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("556317c9-4769-46bf-94d9-3523ca9b8772"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e6694e82-2be4-4388-8c1e-f340344f5039"),
				CreatedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("94fc97e5-ecec-4b31-8393-2bec88bfba9c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9546c9d0-5f23-4828-815c-3ca993d079a8"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("e011f5ca-9b03-4661-8238-c184b3f61c1d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb"),
				CreatedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				Name = @"LaneSet1",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("b23c2f4e-571f-43de-bc55-2978e2e4ac5e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e011f5ca-9b03-4661-8238-c184b3f61c1d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb"),
				CreatedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("38ffbefa-60e7-4a6b-bd17-cd1c11ba4fd0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b23c2f4e-571f-43de-bc55-2978e2e4ac5e"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb"),
				CreatedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(120, 37),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(400, 243),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5b50c550-a8d2-4b5a-90d6-522a9cef0ceb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("38ffbefa-60e7-4a6b-bd17-cd1c11ba4fd0"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb"),
				CreatedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PartnershipSaved",
				ModifiedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				Name = @"StartMessage1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(51, 150),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOnPartnershipSavedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4eac8c13-d02c-4d07-a637-dbc2c4c98774"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("38ffbefa-60e7-4a6b-bd17-cd1c11ba4fd0"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb"),
				CreatedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				Name = @"OnPartnershipSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(284, 136),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,8,45,78,45,114,206,207,203,75,77,46,201,204,207,211,115,79,45,241,44,118,75,77,44,41,45,74,117,205,75,76,202,73,77,209,80,130,48,252,115,82,2,18,139,74,242,82,139,138,51,50,11,124,242,211,51,147,149,52,53,21,170,185,56,67,11,82,18,75,82,29,129,38,148,165,34,41,41,214,72,206,207,43,73,173,40,209,180,230,170,229,42,74,5,154,153,167,80,82,84,154,106,13,0,96,38,240,217,121,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreatePartnershipInsertedEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaPartnershipInsertedEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("71c80eec-a5c6-462c-b9c2-c043d762f664"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b23c2f4e-571f-43de-bc55-2978e2e4ac5e"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e6694e82-2be4-4388-8c1e-f340344f5039"),
				CreatedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				Name = @"PartnershipInsertedEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(115, 340),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(509, 186),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaPartnershipInsertedEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("1e8d081b-e402-45b9-9545-edf5e1c82e01"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("71c80eec-a5c6-462c-b9c2-c043d762f664"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e6694e82-2be4-4388-8c1e-f340344f5039"),
				CreatedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PartnershipInserted",
				ModifiedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				Name = @"StartMessage2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(33, 60),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOnPartnershipInsertedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("914c0a70-48c4-43b0-9792-f4431c7c7cf9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("71c80eec-a5c6-462c-b9c2-c043d762f664"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e6694e82-2be4-4388-8c1e-f340344f5039"),
				CreatedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				Name = @"OnPartnershipInsertedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(269, 46),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,8,45,78,45,114,206,207,203,75,77,46,201,204,207,211,115,79,45,241,44,118,75,77,44,41,45,74,117,205,75,76,202,73,77,209,80,130,48,252,115,82,2,18,139,74,242,82,139,138,51,50,11,124,242,211,51,147,149,52,53,21,170,185,56,253,243,144,36,60,243,128,38,150,0,181,37,231,231,149,164,86,148,104,90,115,213,114,21,165,2,13,204,83,40,41,42,77,181,6,0,87,207,179,94,118,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("3996b812-de69-4433-96cc-ae7ea2d2eedf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b23c2f4e-571f-43de-bc55-2978e2e4ac5e"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e6694e82-2be4-4388-8c1e-f340344f5039"),
				CreatedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				Name = @"EventSubProcess3",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(79, 560),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(580, 180),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePartnershipUpdatedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("94fc97e5-ecec-4b31-8393-2bec88bfba9c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3996b812-de69-4433-96cc-ae7ea2d2eedf"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e6694e82-2be4-4388-8c1e-f340344f5039"),
				CreatedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PartnershipUpdated",
				ModifiedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				Name = @"PartnershipUpdated",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(51, 61),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOnPartnershipUpdatedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9546c9d0-5f23-4828-815c-3ca993d079a8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3996b812-de69-4433-96cc-ae7ea2d2eedf"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e6694e82-2be4-4388-8c1e-f340344f5039"),
				CreatedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				Name = @"OnPartnershipUpdatedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(246, 47),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,8,45,78,45,114,206,207,203,75,77,46,201,204,207,211,115,79,45,241,44,118,75,77,44,41,45,74,117,205,75,76,202,73,77,209,80,130,48,252,115,82,2,18,139,74,242,82,139,138,51,50,11,124,242,211,51,147,149,52,53,21,170,185,56,253,243,144,36,66,11,82,18,75,128,186,146,243,243,74,82,43,74,52,173,185,106,185,138,82,129,230,229,41,148,20,149,166,90,3,0,108,147,141,56,117,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateUpdateActivePartnershipsMethod());
			Methods.Add(CreateOnPartnershipInsertedMethod());
			Methods.Add(CreateOnPartnershipUpdatedMethod());
			Methods.Add(CreateGetLevelPartnershipParamEsqMethod());
			Methods.Add(CreateCopyLevelPartnershipParameterValuesMethod());
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
				UId = new Guid("4ea8b73f-dd34-414f-82f7-2265e0b284ca"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("e6694e82-2be4-4388-8c1e-f340344f5039")
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

		protected virtual SchemaMethod CreateUpdateActivePartnershipsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d293d1a5-44cd-47c0-80f5-117d980443d3"),
				Name = "UpdateActivePartnerships",
				CreatedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("90f29e21-9c79-4704-af6f-834953a9b997"),
				Name = "context",
				CreatedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				ModifiedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext",
				CreatedInPackageId = new Guid("337d09f6-8036-46e0-94d3-30466e8b57bb")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,203,106,195,48,16,69,215,246,87,12,90,73,16,244,3,121,128,9,38,100,19,2,77,154,181,98,77,136,64,150,92,105,148,214,148,254,123,69,228,64,74,75,87,3,195,153,51,220,123,83,1,76,108,58,50,55,132,37,180,142,12,141,114,131,116,24,7,212,107,111,83,239,94,149,77,184,56,123,111,87,156,109,39,152,137,121,109,46,192,31,199,2,62,235,234,56,104,69,8,169,140,37,56,124,135,178,227,199,136,97,237,157,195,76,123,55,3,182,87,129,28,134,120,53,3,19,117,85,201,23,164,39,253,12,202,115,153,57,213,35,97,224,23,101,35,138,59,123,186,98,192,76,107,38,228,54,238,60,181,111,73,89,254,235,100,202,179,15,166,87,97,124,138,83,52,141,211,156,53,93,231,147,163,201,245,191,232,175,98,54,201,232,213,15,141,16,160,226,20,124,94,87,165,14,217,126,96,151,114,19,185,184,175,111,205,25,79,218,119,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnPartnershipInsertedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2a84576c-b272-449f-8974-328bb1876aa3"),
				Name = "OnPartnershipInserted",
				CreatedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				CreatedInPackageId = new Guid("e6694e82-2be4-4388-8c1e-f340344f5039"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4e454ad5-7ad2-4877-b84c-7224932fe3af"),
				Name = "context",
				CreatedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				ModifiedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext",
				CreatedInPackageId = new Guid("e6694e82-2be4-4388-8c1e-f340344f5039")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,86,219,142,155,48,16,125,206,74,251,15,22,79,68,66,252,64,54,43,53,116,47,145,118,219,168,217,246,221,75,38,4,9,12,53,38,21,170,250,239,245,69,11,54,216,44,75,170,190,33,152,115,206,204,120,206,224,51,166,40,174,41,5,194,182,7,180,70,187,111,207,27,92,65,84,144,138,97,194,170,48,82,31,119,152,50,2,180,58,165,37,127,196,249,75,83,194,246,176,186,190,58,115,2,134,105,2,14,252,139,252,54,10,47,94,179,52,193,44,45,136,122,109,163,249,218,198,72,60,48,160,6,199,43,16,56,166,204,77,176,81,1,67,180,194,151,93,130,18,127,71,88,202,154,112,71,211,28,211,38,42,178,58,39,63,112,86,195,202,136,127,130,51,100,58,224,1,100,14,7,13,113,243,80,167,135,91,223,219,25,16,111,41,181,21,108,31,159,32,199,207,152,224,4,40,2,203,187,53,250,94,1,229,229,16,136,69,23,66,11,208,108,197,93,245,147,163,120,62,82,176,127,0,252,171,111,244,44,232,149,180,52,217,120,61,153,82,230,164,157,130,168,87,101,210,5,248,102,166,203,213,160,195,237,33,168,244,57,163,165,100,65,189,149,167,23,195,166,249,194,1,109,11,13,14,217,200,99,65,1,199,39,228,11,165,204,86,48,74,201,176,150,37,250,125,125,181,208,202,180,9,240,244,220,185,135,17,23,102,160,122,96,169,124,17,21,101,99,61,1,193,33,231,163,242,71,196,3,123,53,146,122,4,22,238,129,105,35,40,59,167,207,189,23,152,142,153,195,55,8,106,169,219,133,114,9,173,100,50,108,57,151,237,205,113,182,17,31,231,195,103,240,69,212,159,254,162,122,223,92,253,165,230,242,87,23,103,88,204,144,154,232,178,105,38,176,9,118,62,136,237,235,254,114,31,104,43,64,66,35,30,157,20,180,145,203,211,154,236,132,93,218,99,242,116,37,205,97,237,95,97,142,206,128,71,169,140,52,74,204,225,103,56,106,116,149,63,5,243,142,97,251,19,53,135,114,170,103,103,210,58,60,59,131,173,127,178,129,99,120,230,247,85,63,209,192,58,48,115,115,31,221,55,163,124,218,190,249,23,102,102,214,187,215,255,249,167,185,181,199,126,105,110,212,92,131,124,140,209,237,143,183,59,238,5,164,14,119,124,156,108,116,192,198,232,180,249,210,2,30,33,43,193,184,160,169,55,156,108,177,70,81,134,171,234,30,199,140,251,77,172,202,155,1,242,214,39,240,11,201,171,54,173,69,220,39,154,212,57,31,114,223,171,141,225,225,9,247,166,73,36,51,208,21,101,107,34,251,152,91,225,9,142,204,239,245,238,47,139,204,29,33,188,12,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnPartnershipUpdatedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2515fffe-ca14-435f-bf08-10cdadec22f1"),
				Name = "OnPartnershipUpdated",
				CreatedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				CreatedInPackageId = new Guid("e6694e82-2be4-4388-8c1e-f340344f5039"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("528d2c7f-3db1-4bb7-a1e5-78ba21fddee7"),
				Name = "context",
				CreatedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				ModifiedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext",
				CreatedInPackageId = new Guid("e6694e82-2be4-4388-8c1e-f340344f5039")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,219,110,226,48,16,125,46,18,255,96,229,201,145,16,63,176,5,137,77,47,91,9,149,106,75,247,221,77,134,224,202,216,145,99,167,69,171,254,123,199,49,161,185,16,72,223,226,203,185,204,153,113,10,166,73,198,180,145,160,151,80,128,32,51,114,43,13,55,251,233,61,152,245,62,131,36,82,194,238,228,63,38,44,92,223,91,158,204,105,240,84,3,60,36,65,248,107,60,42,144,71,137,228,233,44,213,74,12,100,227,27,66,155,174,102,109,246,144,252,31,143,174,52,24,171,37,34,62,199,163,195,105,190,229,217,31,16,25,28,11,251,222,65,196,213,140,68,130,229,249,29,139,141,210,165,183,235,14,114,78,37,188,147,72,201,220,104,235,238,45,116,106,119,32,13,13,108,14,26,15,36,196,134,43,25,76,200,75,99,35,172,194,168,105,63,36,131,82,61,212,238,47,226,185,240,140,68,184,114,107,22,241,147,237,192,224,2,105,59,37,58,133,101,47,162,145,170,83,235,226,111,64,224,85,108,213,111,144,176,225,230,136,241,165,92,0,173,153,78,193,116,33,75,158,27,95,40,17,248,185,218,60,42,227,65,73,196,12,164,216,138,50,166,254,98,167,207,224,18,161,31,100,54,39,31,3,198,179,132,126,147,7,97,56,93,43,231,131,30,13,169,215,55,164,244,150,156,120,175,179,41,118,184,0,109,22,66,84,160,106,68,220,54,232,82,123,66,170,179,212,153,164,126,21,166,225,185,208,34,171,53,78,86,165,213,140,110,82,122,66,223,11,173,217,158,246,16,69,42,219,31,186,213,109,117,69,84,239,252,228,76,206,39,103,48,246,38,87,175,130,167,204,237,244,206,94,212,185,217,29,134,141,210,192,226,45,161,173,135,82,154,32,252,148,156,127,238,237,187,56,19,166,54,0,157,127,73,179,106,39,125,130,130,21,80,78,196,231,169,104,23,73,242,8,239,151,138,106,167,219,245,127,41,241,62,101,255,158,6,11,255,84,228,47,196,76,196,86,224,240,225,104,63,199,216,152,33,207,61,218,50,153,66,77,167,148,111,35,191,0,64,106,146,159,92,6,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetLevelPartnershipParamEsqMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b29b9ddc-380f-4d9e-a5e3-1c0f6cf66e4f"),
				Name = "GetLevelPartnershipParamEsq",
				CreatedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				CreatedInPackageId = new Guid("e6694e82-2be4-4388-8c1e-f340344f5039"),
				ResultValueTypeName = "EntitySchemaQuery"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("dc267525-6863-4a59-a51c-2a73a1ae1084"),
				Name = "parameterTypeId",
				CreatedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				ModifiedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("e6694e82-2be4-4388-8c1e-f340344f5039")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("cd1818ba-261f-4c43-90a7-3759839badef"),
				Name = "partnerLevelId",
				CreatedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				ModifiedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("e6694e82-2be4-4388-8c1e-f340344f5039")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,82,193,110,130,64,16,189,251,21,132,19,38,134,31,48,61,84,68,67,98,109,27,180,61,79,96,34,155,44,179,56,59,104,248,251,46,80,149,166,112,243,180,59,239,189,125,111,102,178,49,137,146,38,205,10,44,225,13,8,78,200,30,142,96,47,222,209,34,71,134,8,51,81,134,194,248,191,104,57,27,130,127,108,220,251,17,215,112,139,146,144,21,160,12,87,205,30,74,12,252,29,94,80,127,0,11,33,219,66,85,238,10,165,63,95,206,46,224,58,179,103,231,68,120,245,134,73,159,53,114,19,12,253,157,220,73,195,215,60,143,140,174,75,10,252,95,199,206,45,2,193,147,225,198,31,149,185,46,4,249,11,116,141,135,166,194,17,81,66,210,209,35,84,42,172,232,52,197,110,180,129,201,167,43,99,52,2,77,58,103,134,239,248,70,105,215,163,109,249,160,173,35,70,55,83,143,126,43,41,238,99,216,160,7,35,83,86,192,202,26,106,103,10,227,115,13,122,225,221,182,210,237,220,95,120,213,160,76,242,249,243,195,122,93,183,214,46,237,81,63,47,110,135,214,190,243,45,52,21,55,211,218,25,184,192,246,56,168,18,195,163,100,123,115,125,86,224,182,211,243,35,115,93,227,116,34,163,212,76,237,79,94,254,0,163,117,9,87,124,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCopyLevelPartnershipParameterValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d740210e-8010-4ab5-8593-9802ceb00c33"),
				Name = "CopyLevelPartnershipParameterValues",
				CreatedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				CreatedInPackageId = new Guid("e6694e82-2be4-4388-8c1e-f340344f5039"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("1ce8ecf9-15b0-41c4-952d-f4a7b103b246"),
				Name = "partnershipParameter",
				CreatedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				ModifiedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("e6694e82-2be4-4388-8c1e-f340344f5039")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("776475af-596b-4bab-98f3-4150b4a92022"),
				Name = "levelPartnershipParam",
				CreatedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				ModifiedInSchemaUId = new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("e6694e82-2be4-4388-8c1e-f340344f5039")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,147,209,10,130,48,20,134,239,131,222,65,186,42,24,190,128,213,69,69,210,157,96,116,127,202,83,9,115,147,57,5,223,190,57,99,205,180,152,94,239,124,223,97,255,207,169,64,120,57,8,201,80,68,32,32,219,131,196,7,23,245,41,241,54,30,197,10,105,212,190,22,207,52,215,19,126,136,242,92,231,152,236,57,45,51,118,1,90,226,58,44,211,100,187,92,68,131,166,197,42,152,207,170,118,17,100,40,81,104,168,145,76,94,211,243,152,37,133,20,41,123,232,151,81,238,150,83,246,248,35,48,210,148,201,241,70,5,41,221,233,141,26,215,157,114,152,96,75,120,121,165,168,132,71,195,27,229,149,115,138,192,198,75,27,80,41,119,22,255,9,242,198,197,148,15,199,13,167,45,249,23,212,84,230,199,40,15,120,183,176,98,249,111,214,26,236,86,67,236,166,157,13,166,13,98,58,117,102,173,224,137,213,162,51,223,73,153,116,74,115,79,64,135,75,218,114,156,169,31,119,73,126,156,254,24,111,255,16,201,224,157,175,130,23,4,206,162,240,107,4,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Partnership_PRMBase_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0ec593ca-f05b-4c40-82b8-f61980deb94e"));
		}

		#endregion

	}

	#endregion

}

