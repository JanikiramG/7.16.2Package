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

	#region Class: EducationActivitySchema

	/// <exclude/>
	public class EducationActivitySchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public EducationActivitySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public EducationActivitySchema(EducationActivitySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public EducationActivitySchema(EducationActivitySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("48a0ddfd-a99e-4bf5-8b5a-e56dfec31e0c");
			RealUId = new Guid("48a0ddfd-a99e-4bf5-8b5a-e56dfec31e0c");
			Name = "EducationActivity";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("867b9a25-86bf-4a3e-8ecd-b6e40f57be82");
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

		protected override void InitializeMasterRecordColumn() {
			base.InitializeMasterRecordColumn();
			MasterRecordColumn = CreateContactColumn();
			if (Columns.FindByUId(MasterRecordColumn.UId) == null) {
				Columns.Add(MasterRecordColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("3189b16f-1429-4a35-8cf0-f2d84b8d46ff")) == null) {
				Columns.Add(CreateDescriptionColumn());
			}
			if (Columns.FindByUId(new Guid("61441dc1-db2b-4cdb-9665-7313f5d9c6f6")) == null) {
				Columns.Add(CreateEducationActivityTypeColumn());
			}
			if (Columns.FindByUId(new Guid("b7a51817-1fc4-47e4-9303-07c70afe220f")) == null) {
				Columns.Add(CreateCostColumn());
			}
			if (Columns.FindByUId(new Guid("fe2ad4a5-3093-4f6e-98b0-634df92a38de")) == null) {
				Columns.Add(CreateDateColumn());
			}
			if (Columns.FindByUId(new Guid("d68d57dc-6b91-43e2-a7d5-2dd80c9728b7")) == null) {
				Columns.Add(CreateEducationActivityResultColumn());
			}
			if (Columns.FindByUId(new Guid("f77e86cb-765a-46c3-a948-a2117e503315")) == null) {
				Columns.Add(CreateStatusOfActivityColumn());
			}
			if (Columns.FindByUId(new Guid("26775669-f3bb-4436-839c-b4bb0c815a35")) == null) {
				Columns.Add(CreatePaymentMethodColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("d3088fdf-038f-4113-9cd3-dfd76e66deb5"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("48a0ddfd-a99e-4bf5-8b5a-e56dfec31e0c"),
				ModifiedInSchemaUId = new Guid("48a0ddfd-a99e-4bf5-8b5a-e56dfec31e0c"),
				CreatedInPackageId = new Guid("867b9a25-86bf-4a3e-8ecd-b6e40f57be82")
			};
		}

		protected virtual EntitySchemaColumn CreateDescriptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("3189b16f-1429-4a35-8cf0-f2d84b8d46ff"),
				Name = @"Description",
				CreatedInSchemaUId = new Guid("48a0ddfd-a99e-4bf5-8b5a-e56dfec31e0c"),
				ModifiedInSchemaUId = new Guid("48a0ddfd-a99e-4bf5-8b5a-e56dfec31e0c"),
				CreatedInPackageId = new Guid("867b9a25-86bf-4a3e-8ecd-b6e40f57be82")
			};
		}

		protected virtual EntitySchemaColumn CreateEducationActivityTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("61441dc1-db2b-4cdb-9665-7313f5d9c6f6"),
				Name = @"EducationActivityType",
				ReferenceSchemaUId = new Guid("ca986710-7248-4a41-bd3d-5dbd5936ad5c"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("48a0ddfd-a99e-4bf5-8b5a-e56dfec31e0c"),
				ModifiedInSchemaUId = new Guid("48a0ddfd-a99e-4bf5-8b5a-e56dfec31e0c"),
				CreatedInPackageId = new Guid("867b9a25-86bf-4a3e-8ecd-b6e40f57be82")
			};
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("bda7ea8d-b646-474f-b55b-1f1c051a7c36"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("48a0ddfd-a99e-4bf5-8b5a-e56dfec31e0c"),
				ModifiedInSchemaUId = new Guid("48a0ddfd-a99e-4bf5-8b5a-e56dfec31e0c"),
				CreatedInPackageId = new Guid("867b9a25-86bf-4a3e-8ecd-b6e40f57be82")
			};
		}

		protected virtual EntitySchemaColumn CreateCostColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("b7a51817-1fc4-47e4-9303-07c70afe220f"),
				Name = @"Cost",
				CreatedInSchemaUId = new Guid("48a0ddfd-a99e-4bf5-8b5a-e56dfec31e0c"),
				ModifiedInSchemaUId = new Guid("48a0ddfd-a99e-4bf5-8b5a-e56dfec31e0c"),
				CreatedInPackageId = new Guid("867b9a25-86bf-4a3e-8ecd-b6e40f57be82")
			};
		}

		protected virtual EntitySchemaColumn CreateDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("fe2ad4a5-3093-4f6e-98b0-634df92a38de"),
				Name = @"Date",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("48a0ddfd-a99e-4bf5-8b5a-e56dfec31e0c"),
				ModifiedInSchemaUId = new Guid("48a0ddfd-a99e-4bf5-8b5a-e56dfec31e0c"),
				CreatedInPackageId = new Guid("867b9a25-86bf-4a3e-8ecd-b6e40f57be82")
			};
		}

		protected virtual EntitySchemaColumn CreateEducationActivityResultColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d68d57dc-6b91-43e2-a7d5-2dd80c9728b7"),
				Name = @"EducationActivityResult",
				ReferenceSchemaUId = new Guid("1df945e2-2a19-463e-bb71-c589093d3ff0"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("48a0ddfd-a99e-4bf5-8b5a-e56dfec31e0c"),
				ModifiedInSchemaUId = new Guid("48a0ddfd-a99e-4bf5-8b5a-e56dfec31e0c"),
				CreatedInPackageId = new Guid("867b9a25-86bf-4a3e-8ecd-b6e40f57be82")
			};
		}

		protected virtual EntitySchemaColumn CreateStatusOfActivityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f77e86cb-765a-46c3-a948-a2117e503315"),
				Name = @"StatusOfActivity",
				ReferenceSchemaUId = new Guid("5c102754-283e-43e1-8529-fb0c1a7facbb"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("48a0ddfd-a99e-4bf5-8b5a-e56dfec31e0c"),
				ModifiedInSchemaUId = new Guid("48a0ddfd-a99e-4bf5-8b5a-e56dfec31e0c"),
				CreatedInPackageId = new Guid("867b9a25-86bf-4a3e-8ecd-b6e40f57be82")
			};
		}

		protected virtual EntitySchemaColumn CreatePaymentMethodColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("26775669-f3bb-4436-839c-b4bb0c815a35"),
				Name = @"PaymentMethod",
				ReferenceSchemaUId = new Guid("5da543c5-8aae-4ce0-9116-972d27a7307a"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("48a0ddfd-a99e-4bf5-8b5a-e56dfec31e0c"),
				ModifiedInSchemaUId = new Guid("48a0ddfd-a99e-4bf5-8b5a-e56dfec31e0c"),
				CreatedInPackageId = new Guid("e6694e82-2be4-4388-8c1e-f340344f5039")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateEducationActivityEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateEducationActivityEventsProcessSchema() {
			var schema = new EducationActivityEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new EducationActivity(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new EducationActivity_PRMBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new EducationActivitySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new EducationActivitySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("48a0ddfd-a99e-4bf5-8b5a-e56dfec31e0c"));
		}

		#endregion

	}

	#endregion

	#region Class: EducationActivity

	/// <summary>
	/// Education activity.
	/// </summary>
	public class EducationActivity : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public EducationActivity(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "EducationActivity";
		}

		public EducationActivity(EducationActivity source)
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
		public Guid EducationActivityTypeId {
			get {
				return GetTypedColumnValue<Guid>("EducationActivityTypeId");
			}
			set {
				SetColumnValue("EducationActivityTypeId", value);
				_educationActivityType = null;
			}
		}

		/// <exclude/>
		public string EducationActivityTypeName {
			get {
				return GetTypedColumnValue<string>("EducationActivityTypeName");
			}
			set {
				SetColumnValue("EducationActivityTypeName", value);
				if (_educationActivityType != null) {
					_educationActivityType.Name = value;
				}
			}
		}

		private EduActivityType _educationActivityType;
		/// <summary>
		/// Type.
		/// </summary>
		public EduActivityType EducationActivityType {
			get {
				return _educationActivityType ??
					(_educationActivityType = LookupColumnEntities.GetEntity("EducationActivityType") as EduActivityType);
			}
		}

		/// <exclude/>
		public Guid ContactId {
			get {
				return GetTypedColumnValue<Guid>("ContactId");
			}
			set {
				SetColumnValue("ContactId", value);
				_contact = null;
			}
		}

		/// <exclude/>
		public string ContactName {
			get {
				return GetTypedColumnValue<string>("ContactName");
			}
			set {
				SetColumnValue("ContactName", value);
				if (_contact != null) {
					_contact.Name = value;
				}
			}
		}

		private Contact _contact;
		/// <summary>
		/// Contact.
		/// </summary>
		public Contact Contact {
			get {
				return _contact ??
					(_contact = LookupColumnEntities.GetEntity("Contact") as Contact);
			}
		}

		/// <summary>
		/// Cost.
		/// </summary>
		public Decimal Cost {
			get {
				return GetTypedColumnValue<Decimal>("Cost");
			}
			set {
				SetColumnValue("Cost", value);
			}
		}

		/// <summary>
		/// Event date.
		/// </summary>
		public DateTime Date {
			get {
				return GetTypedColumnValue<DateTime>("Date");
			}
			set {
				SetColumnValue("Date", value);
			}
		}

		/// <exclude/>
		public Guid EducationActivityResultId {
			get {
				return GetTypedColumnValue<Guid>("EducationActivityResultId");
			}
			set {
				SetColumnValue("EducationActivityResultId", value);
				_educationActivityResult = null;
			}
		}

		/// <exclude/>
		public string EducationActivityResultName {
			get {
				return GetTypedColumnValue<string>("EducationActivityResultName");
			}
			set {
				SetColumnValue("EducationActivityResultName", value);
				if (_educationActivityResult != null) {
					_educationActivityResult.Name = value;
				}
			}
		}

		private EduActivityResult _educationActivityResult;
		/// <summary>
		/// Result .
		/// </summary>
		public EduActivityResult EducationActivityResult {
			get {
				return _educationActivityResult ??
					(_educationActivityResult = LookupColumnEntities.GetEntity("EducationActivityResult") as EduActivityResult);
			}
		}

		/// <exclude/>
		public Guid StatusOfActivityId {
			get {
				return GetTypedColumnValue<Guid>("StatusOfActivityId");
			}
			set {
				SetColumnValue("StatusOfActivityId", value);
				_statusOfActivity = null;
			}
		}

		/// <exclude/>
		public string StatusOfActivityName {
			get {
				return GetTypedColumnValue<string>("StatusOfActivityName");
			}
			set {
				SetColumnValue("StatusOfActivityName", value);
				if (_statusOfActivity != null) {
					_statusOfActivity.Name = value;
				}
			}
		}

		private EduActivityStatus _statusOfActivity;
		/// <summary>
		/// Status.
		/// </summary>
		public EduActivityStatus StatusOfActivity {
			get {
				return _statusOfActivity ??
					(_statusOfActivity = LookupColumnEntities.GetEntity("StatusOfActivity") as EduActivityStatus);
			}
		}

		/// <exclude/>
		public Guid PaymentMethodId {
			get {
				return GetTypedColumnValue<Guid>("PaymentMethodId");
			}
			set {
				SetColumnValue("PaymentMethodId", value);
				_paymentMethod = null;
			}
		}

		/// <exclude/>
		public string PaymentMethodName {
			get {
				return GetTypedColumnValue<string>("PaymentMethodName");
			}
			set {
				SetColumnValue("PaymentMethodName", value);
				if (_paymentMethod != null) {
					_paymentMethod.Name = value;
				}
			}
		}

		private PaymentMethod _paymentMethod;
		/// <summary>
		/// Payment method.
		/// </summary>
		public PaymentMethod PaymentMethod {
			get {
				return _paymentMethod ??
					(_paymentMethod = LookupColumnEntities.GetEntity("PaymentMethod") as PaymentMethod);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new EducationActivity_PRMBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("EducationActivityDeleted", e);
			Inserted += (s, e) => ThrowEvent("EducationActivityInserted", e);
			Saved += (s, e) => ThrowEvent("EducationActivitySaved", e);
			Updated += (s, e) => ThrowEvent("EducationActivityUpdated", e);
			Validating += (s, e) => ThrowEvent("EducationActivityValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new EducationActivity(this);
		}

		#endregion

	}

	#endregion

	#region Class: EducationActivity_PRMBaseEventsProcess

	/// <exclude/>
	public partial class EducationActivity_PRMBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : EducationActivity
	{

		public EducationActivity_PRMBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "EducationActivity_PRMBaseEventsProcess";
			SchemaUId = new Guid("48a0ddfd-a99e-4bf5-8b5a-e56dfec31e0c");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("48a0ddfd-a99e-4bf5-8b5a-e56dfec31e0c");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _onEducationActivityAddedSubProcess;
		public ProcessFlowElement OnEducationActivityAddedSubProcess {
			get {
				return _onEducationActivityAddedSubProcess ?? (_onEducationActivityAddedSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "OnEducationActivityAddedSubProcess",
					SchemaElementUId = new Guid("5d1c8f20-a24f-4a6a-9619-3b8c52e3bded"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _educationActivityInserted;
		public ProcessFlowElement EducationActivityInserted {
			get {
				return _educationActivityInserted ?? (_educationActivityInserted = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "EducationActivityInserted",
					SchemaElementUId = new Guid("f2f7dc3c-732a-4bf7-b7d2-fdf8f73d444b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _onEducationActivityAddedScriptTask;
		public ProcessScriptTask OnEducationActivityAddedScriptTask {
			get {
				return _onEducationActivityAddedScriptTask ?? (_onEducationActivityAddedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OnEducationActivityAddedScriptTask",
					SchemaElementUId = new Guid("0d850dcf-d2fd-4839-9368-7ccc7d0b43db"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OnEducationActivityAddedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _onEducationActivityUpdatedSubProcess;
		public ProcessFlowElement onEducationActivityUpdatedSubProcess {
			get {
				return _onEducationActivityUpdatedSubProcess ?? (_onEducationActivityUpdatedSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "onEducationActivityUpdatedSubProcess",
					SchemaElementUId = new Guid("6d01459d-3798-4741-8b67-3881d23620f1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _educationActivityUpdated;
		public ProcessFlowElement EducationActivityUpdated {
			get {
				return _educationActivityUpdated ?? (_educationActivityUpdated = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "EducationActivityUpdated",
					SchemaElementUId = new Guid("342057e1-b6da-46bc-a9b1-02cbdf627115"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _onEducationActivityUpdatedScriptTask;
		public ProcessScriptTask OnEducationActivityUpdatedScriptTask {
			get {
				return _onEducationActivityUpdatedScriptTask ?? (_onEducationActivityUpdatedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OnEducationActivityUpdatedScriptTask",
					SchemaElementUId = new Guid("1d775339-305e-4d30-9d64-59c1d99518e4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OnEducationActivityUpdatedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _onEducationActivityDeletedSubProcess;
		public ProcessFlowElement OnEducationActivityDeletedSubProcess {
			get {
				return _onEducationActivityDeletedSubProcess ?? (_onEducationActivityDeletedSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "OnEducationActivityDeletedSubProcess",
					SchemaElementUId = new Guid("ed700a2a-bb1b-4fbf-ab4f-4b3636126ff7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _educationActivityDeleted;
		public ProcessFlowElement EducationActivityDeleted {
			get {
				return _educationActivityDeleted ?? (_educationActivityDeleted = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "EducationActivityDeleted",
					SchemaElementUId = new Guid("fbc75d42-cf3b-4285-b287-002e5db6b910"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _onEducationActivityDeletedScriptTask;
		public ProcessScriptTask OnEducationActivityDeletedScriptTask {
			get {
				return _onEducationActivityDeletedScriptTask ?? (_onEducationActivityDeletedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OnEducationActivityDeletedScriptTask",
					SchemaElementUId = new Guid("36fab8e4-6e61-48d4-a958-adbee64032aa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OnEducationActivityDeletedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _onSavedSubProcess;
		public ProcessFlowElement OnSavedSubProcess {
			get {
				return _onSavedSubProcess ?? (_onSavedSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "OnSavedSubProcess",
					SchemaElementUId = new Guid("698b52dc-9d95-45f9-9bf9-945421844b2d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _onSaved;
		public ProcessFlowElement OnSaved {
			get {
				return _onSaved ?? (_onSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OnSaved",
					SchemaElementUId = new Guid("63acfcdc-3234-4f13-8644-11a1a0e73e6a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _onEducationActivitySavedScriptTask;
		public ProcessScriptTask OnEducationActivitySavedScriptTask {
			get {
				return _onEducationActivitySavedScriptTask ?? (_onEducationActivitySavedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OnEducationActivitySavedScriptTask",
					SchemaElementUId = new Guid("4f06721a-8536-4ee1-9194-4a110ac09abf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OnEducationActivitySavedScriptTaskExecute,
				});
			}
		}

		private LocalizableString _transactionMessageTemplate;
		public LocalizableString TransactionMessageTemplate {
			get {
				return _transactionMessageTemplate ?? (_transactionMessageTemplate = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.TransactionMessageTemplate.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[OnEducationActivityAddedSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { OnEducationActivityAddedSubProcess };
			FlowElements[EducationActivityInserted.SchemaElementUId] = new Collection<ProcessFlowElement> { EducationActivityInserted };
			FlowElements[OnEducationActivityAddedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OnEducationActivityAddedScriptTask };
			FlowElements[onEducationActivityUpdatedSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { onEducationActivityUpdatedSubProcess };
			FlowElements[EducationActivityUpdated.SchemaElementUId] = new Collection<ProcessFlowElement> { EducationActivityUpdated };
			FlowElements[OnEducationActivityUpdatedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OnEducationActivityUpdatedScriptTask };
			FlowElements[OnEducationActivityDeletedSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { OnEducationActivityDeletedSubProcess };
			FlowElements[EducationActivityDeleted.SchemaElementUId] = new Collection<ProcessFlowElement> { EducationActivityDeleted };
			FlowElements[OnEducationActivityDeletedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OnEducationActivityDeletedScriptTask };
			FlowElements[OnSavedSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { OnSavedSubProcess };
			FlowElements[OnSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { OnSaved };
			FlowElements[OnEducationActivitySavedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OnEducationActivitySavedScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "OnEducationActivityAddedSubProcess":
						break;
					case "EducationActivityInserted":
						e.Context.QueueTasks.Enqueue("OnEducationActivityAddedScriptTask");
						break;
					case "OnEducationActivityAddedScriptTask":
						break;
					case "onEducationActivityUpdatedSubProcess":
						break;
					case "EducationActivityUpdated":
						e.Context.QueueTasks.Enqueue("OnEducationActivityUpdatedScriptTask");
						break;
					case "OnEducationActivityUpdatedScriptTask":
						break;
					case "OnEducationActivityDeletedSubProcess":
						break;
					case "EducationActivityDeleted":
						e.Context.QueueTasks.Enqueue("OnEducationActivityDeletedScriptTask");
						break;
					case "OnEducationActivityDeletedScriptTask":
						break;
					case "OnSavedSubProcess":
						break;
					case "OnSaved":
						e.Context.QueueTasks.Enqueue("OnEducationActivitySavedScriptTask");
						break;
					case "OnEducationActivitySavedScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("EducationActivityInserted");
			ActivatedEventElements.Add("EducationActivityUpdated");
			ActivatedEventElements.Add("EducationActivityDeleted");
			ActivatedEventElements.Add("OnSaved");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "OnEducationActivityAddedSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "EducationActivityInserted":
					context.QueueTasks.Dequeue();
					context.SenderName = "EducationActivityInserted";
					result = EducationActivityInserted.Execute(context);
					break;
				case "OnEducationActivityAddedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OnEducationActivityAddedScriptTask";
					result = OnEducationActivityAddedScriptTask.Execute(context, OnEducationActivityAddedScriptTaskExecute);
					break;
				case "onEducationActivityUpdatedSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "EducationActivityUpdated":
					context.QueueTasks.Dequeue();
					context.SenderName = "EducationActivityUpdated";
					result = EducationActivityUpdated.Execute(context);
					break;
				case "OnEducationActivityUpdatedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OnEducationActivityUpdatedScriptTask";
					result = OnEducationActivityUpdatedScriptTask.Execute(context, OnEducationActivityUpdatedScriptTaskExecute);
					break;
				case "OnEducationActivityDeletedSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "EducationActivityDeleted":
					context.QueueTasks.Dequeue();
					context.SenderName = "EducationActivityDeleted";
					result = EducationActivityDeleted.Execute(context);
					break;
				case "OnEducationActivityDeletedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OnEducationActivityDeletedScriptTask";
					result = OnEducationActivityDeletedScriptTask.Execute(context, OnEducationActivityDeletedScriptTaskExecute);
					break;
				case "OnSavedSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "OnSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "OnSaved";
					result = OnSaved.Execute(context);
					break;
				case "OnEducationActivitySavedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OnEducationActivitySavedScriptTask";
					result = OnEducationActivitySavedScriptTask.Execute(context, OnEducationActivitySavedScriptTaskExecute);
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

		public virtual bool OnEducationActivityAddedScriptTaskExecute(ProcessExecutingContext context) {
			OnEducationActivityAdded();
			return true;
		}

		public virtual bool OnEducationActivityUpdatedScriptTaskExecute(ProcessExecutingContext context) {
			OnEducationActivityUpdated();
			return true;
		}

		public virtual bool OnEducationActivityDeletedScriptTaskExecute(ProcessExecutingContext context) {
			OnEducationActivityDeleted();
			return true;
		}

		public virtual bool OnEducationActivitySavedScriptTaskExecute(ProcessExecutingContext context) {
			/*var contactId = Entity.GetTypedColumnValue<Guid>("ContactId");
			if (contactId == null) {
				return true;
			}
			var storedProcedure = new StoredProcedure(UserConnection, "tsp_ActualizePartnerCertificatesCount");
			storedProcedure.WithParameter(new QueryParameter("ActualizationDate", DateTime.UtcNow, "DateTime"));
			storedProcedure.WithParameter(Column.Const(contactId));
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
				dbExecutor.StartTransaction(System.Data.IsolationLevel.ReadUncommitted);
				storedProcedure.Execute(dbExecutor);
				dbExecutor.CommitTransaction();
			}*/
			ActualizePartnerCertificatesCount();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "EducationActivityInserted":
							if (ActivatedEventElements.Contains("EducationActivityInserted")) {
							context.QueueTasks.Enqueue("EducationActivityInserted");
						}
						break;
					case "EducationActivityUpdated":
							if (ActivatedEventElements.Contains("EducationActivityUpdated")) {
							context.QueueTasks.Enqueue("EducationActivityUpdated");
						}
						break;
					case "EducationActivityDeleted":
							if (ActivatedEventElements.Contains("EducationActivityDeleted")) {
							context.QueueTasks.Enqueue("EducationActivityDeleted");
						}
						break;
					case "EducationActivitySaved":
							if (ActivatedEventElements.Contains("OnSaved")) {
							context.QueueTasks.Enqueue("OnSaved");
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

	#region Class: EducationActivity_PRMBaseEventsProcess

	/// <exclude/>
	public class EducationActivity_PRMBaseEventsProcess : EducationActivity_PRMBaseEventsProcess<EducationActivity>
	{

		public EducationActivity_PRMBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: EducationActivity_PRMBaseEventsProcess

	public partial class EducationActivity_PRMBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void AddTransaction() {
			Entity contact = FindContact(Entity.GetTypedColumnValue<Guid>("ContactId"));
			if (contact == null || contact.GetColumnValue("AccountId") == null) {
				return;
			}
			Entity partnership = FindActivePartnership(contact.GetTypedColumnValue<Guid>("AccountId"));
			if (partnership == null) {
				return;
			}
			Entity certificationFund = GetFund(partnership, PRMBaseConstants.CertificationFundType);
			Entity prmTransaction = GetPRMTransactionEntity();
			prmTransaction.SetDefColumnValues();
			prmTransaction.SetColumnValue("TransactionTypeId", PRMBaseConstants.DebitTransactionType);
			prmTransaction.SetColumnValue("FundId", certificationFund.PrimaryColumnValue);
			prmTransaction.SetColumnValue("Amount", 1);
			prmTransaction.SetColumnValue("EntityId", PRMBaseConstants.EducationActivitySchemaUId);
			prmTransaction.SetColumnValue("RecordId", Entity.PrimaryColumnValue);
			string description = string.Format(TransactionMessageTemplate, contact.PrimaryDisplayColumnValue);
			prmTransaction.SetColumnValue("Description", description);
			prmTransaction.Save();
		}

		public virtual Entity FindActivePartnership(Guid accountId) {
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "Partnership");
			esq.PrimaryQueryColumn.IsAlwaysSelect = true;
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Account", accountId));
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "IsActive", true));
			EntityCollection collection = esq.GetEntityCollection(UserConnection);
			return collection.FirstOrDefault();
		}

		public virtual Entity FindFund(Entity partnership, Guid fundTypeId) {
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "Fund");
			esq.PrimaryQueryColumn.IsAlwaysSelect = true;
			esq.Filters.Add(esq.CreateFilterWithParameters(
				FilterComparisonType.Equal,"Partnership", partnership.PrimaryColumnValue));
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "FundType", fundTypeId));
			EntityCollection collection = esq.GetEntityCollection(UserConnection);
			return collection.FirstOrDefault();
		}

		public virtual Entity FindContact(Guid contactId) {
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "Contact");
			esq.PrimaryQueryColumn.IsAlwaysSelect = true;
			esq.AddColumn("Name");
			esq.AddColumn("Account");
			return esq.GetEntity(UserConnection, contactId);
		}

		public virtual void OnEducationActivityAdded() {
			if (IsTransactionNeeded()) {
				AddTransaction();
			}
		}

		public virtual void OnEducationActivityUpdated() {
			if (IsTransactionNeeded()) {
				AddTransaction();
			} else if (Entity.GetColumnOldValue("EducationActivityResultId") != null
					&& Entity.GetColumnValue("EducationActivityResultId") == null) {
				DeleteTransaction();
			}
		}

		public virtual Entity CreateCertificationFund(Entity partnership) {
			EntitySchema fundSchema = UserConnection.EntitySchemaManager.GetInstanceByName("Fund");
			Entity fund = fundSchema.CreateEntity(UserConnection);
			fund.SetDefColumnValues();
			fund.SetColumnValue("PartnershipId", partnership.PrimaryColumnValue);
			fund.SetColumnValue("FundTypeId", PRMBaseConstants.CertificationFundType);
			fund.SetColumnValue("Amount", 0);
			fund.Save();
			return fund;
		}

		public virtual bool IsTransactionNeeded() {
			return (Entity.GetColumnOldValue("EducationActivityResultId") == null
					&& Entity.GetColumnValue("EducationActivityResultId") != null &&
					Entity.GetTypedColumnValue<Guid>("PaymentMethodId") == PRMBaseConstants.NotPaidPaymentMethod);
		}

		public virtual Entity GetFund(Entity partnership, Guid fundTypeId) {
			Entity certificationFund = FindFund(partnership, PRMBaseConstants.CertificationFundType);
			if (certificationFund == null) {
				certificationFund = CreateCertificationFund(partnership);
			}
			return certificationFund;
		}

		public virtual void OnEducationActivityDeleted() {
			DeleteTransaction();
		}

		public virtual void DeleteTransaction() {
			Entity prmTransaction = GetPRMTransactionEntity();
			var fetchConditions = new Dictionary<string, object> {
				{"RecordId", Entity.PrimaryColumnValue}
			};
			if (prmTransaction.FetchFromDB(fetchConditions)) {
				prmTransaction.Delete();
			}
		}

		public virtual Entity GetPRMTransactionEntity() {
			EntitySchema prmTransactionSchema = UserConnection.EntitySchemaManager.GetInstanceByName("PRMTransaction");
			return prmTransactionSchema.CreateEntity(UserConnection);
		}

		public virtual void ActualizePartnerCertificatesCount() {
			Entity contact = FindContact(Entity.GetTypedColumnValue<Guid>("ContactId"));
			var accountId = contact.GetTypedColumnValue<Guid>("AccountId");
			if (accountId == null) {
				return;
			}
			var activePartnership = FindActivePartnership(accountId);
			if (activePartnership == null) {
				return;
			}
			
			CertificateUtils.Actualize(UserConnection, activePartnership.GetTypedColumnValue<Guid>("Id"));
		}

		public virtual EntityCollection GetCertificationPartnershipParameters(Guid PartnershipId) {
			var certificationPartnershipParameterEsq = new EntitySchemaQuery(UserConnection.EntitySchemaManager,
				"PartnershipParameter");
			certificationPartnershipParameterEsq.AddAllSchemaColumns();
			certificationPartnershipParameterEsq.Filters.Add(
				certificationPartnershipParameterEsq.CreateFilterWithParameters(FilterComparisonType.Equal, "Partnership",
				PartnershipId));
				
			certificationPartnershipParameterEsq.Filters.Add(
				certificationPartnershipParameterEsq.CreateFilterWithParameters(FilterComparisonType.Equal, "ParameterType",
				PRMBaseConstants.ObligationParameterTypeId));
				
			certificationPartnershipParameterEsq.Filters.Add(
				certificationPartnershipParameterEsq.CreateFilterWithParameters(FilterComparisonType.Equal,
				"PartnershipParameterType",	PRMBaseConstants.CurrentPartnershipParamTypeId));
				
			certificationPartnershipParameterEsq.Filters.Add(
				certificationPartnershipParameterEsq.CreateFilterWithParameters(FilterComparisonType.Equal,
				"PartnerParamCategory",	PRMBaseConstants.NumberOfCertifiedExpertsCategory));
			return certificationPartnershipParameterEsq.GetEntityCollection(UserConnection);
		}

		public virtual int GetCertifiedContactsCount(Guid AccountId) {
			Select countSelect = new Select(UserConnection).Column(Func.Count(Column.Const(1)))
					.From("Contact").As("C")
					.Where("AccountId").IsEqual(Column.Parameter(AccountId))
					.And().Exists(
						new Select(UserConnection).Column(Column.Const(1)).From("Certificate").Where("ContactId").IsEqual("C", "Id")
						.And("IssueDate").IsLessOrEqual(Column.Parameter(DateTime.UtcNow))
						.And("ExpireDate").IsGreaterOrEqual(Column.Parameter(DateTime.UtcNow)) as Select
					) as Select;
			using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				return countSelect.ExecuteScalar<int>();
			}
		}

		#endregion

	}

	#endregion

	#region Class: EducationActivityEventsProcessSchema

	/// <exclude/>
	public class EducationActivityEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public EducationActivityEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public EducationActivityEventsProcessSchema(EducationActivityEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "EducationActivity_PRMBaseEventsProcess";
			UId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56");
			CreatedInPackageId = new Guid("867b9a25-86bf-4a3e-8ecd-b6e40f57be82");
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
			ProcessSchemaEventSubProcess oneducationactivityaddedsubprocess = CreateOnEducationActivityAddedSubProcessEventSubProcess();
			FlowElements.Add(oneducationactivityaddedsubprocess);
			ProcessSchemaEventSubProcess oneducationactivityupdatedsubprocess = CreateonEducationActivityUpdatedSubProcessEventSubProcess();
			FlowElements.Add(oneducationactivityupdatedsubprocess);
			ProcessSchemaEventSubProcess oneducationactivitydeletedsubprocess = CreateOnEducationActivityDeletedSubProcessEventSubProcess();
			FlowElements.Add(oneducationactivitydeletedsubprocess);
			ProcessSchemaEventSubProcess onsavedsubprocess = CreateOnSavedSubProcessEventSubProcess();
			FlowElements.Add(onsavedsubprocess);
			ProcessSchemaStartMessageEvent educationactivityinserted = CreateEducationActivityInsertedStartMessageEvent();
			oneducationactivityaddedsubprocess.FlowElements.Add(educationactivityinserted);
			ProcessSchemaScriptTask oneducationactivityaddedscripttask = CreateOnEducationActivityAddedScriptTaskScriptTask();
			oneducationactivityaddedsubprocess.FlowElements.Add(oneducationactivityaddedscripttask);
			ProcessSchemaStartMessageEvent educationactivityupdated = CreateEducationActivityUpdatedStartMessageEvent();
			oneducationactivityupdatedsubprocess.FlowElements.Add(educationactivityupdated);
			ProcessSchemaScriptTask oneducationactivityupdatedscripttask = CreateOnEducationActivityUpdatedScriptTaskScriptTask();
			oneducationactivityupdatedsubprocess.FlowElements.Add(oneducationactivityupdatedscripttask);
			ProcessSchemaStartMessageEvent educationactivitydeleted = CreateEducationActivityDeletedStartMessageEvent();
			oneducationactivitydeletedsubprocess.FlowElements.Add(educationactivitydeleted);
			ProcessSchemaScriptTask oneducationactivitydeletedscripttask = CreateOnEducationActivityDeletedScriptTaskScriptTask();
			oneducationactivitydeletedsubprocess.FlowElements.Add(oneducationactivitydeletedscripttask);
			ProcessSchemaStartMessageEvent onsaved = CreateOnSavedStartMessageEvent();
			onsavedsubprocess.FlowElements.Add(onsaved);
			ProcessSchemaScriptTask oneducationactivitysavedscripttask = CreateOnEducationActivitySavedScriptTaskScriptTask();
			onsavedsubprocess.FlowElements.Add(oneducationactivitysavedscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateTransactionMessageTemplateLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateTransactionMessageTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("1da50df0-1cfc-4c2d-be21-20090db71a5e"),
				Name = "TransactionMessageTemplate",
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63"),
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				ModifiedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("af956c94-4eeb-4a65-a362-6cb6206ebb07"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63"),
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f2f7dc3c-732a-4bf7-b7d2-fdf8f73d444b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0d850dcf-d2fd-4839-9368-7ccc7d0b43db"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("577dc13a-308c-4b08-b95e-0e4951df8f98"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63"),
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("342057e1-b6da-46bc-a9b1-02cbdf627115"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1d775339-305e-4d30-9d64-59c1d99518e4"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("fbdc79e0-d8eb-48d5-9ebb-0877fe4b06e1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63"),
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fbc75d42-cf3b-4285-b287-002e5db6b910"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("36fab8e4-6e61-48d4-a958-adbee64032aa"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("985fa6dd-1aab-477a-9083-f6f9509d24e5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("867b9a25-86bf-4a3e-8ecd-b6e40f57be82"),
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("63acfcdc-3234-4f13-8644-11a1a0e73e6a"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4f06721a-8536-4ee1-9194-4a110ac09abf"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("07c3c1ee-90f2-4e5c-b443-2df3c715613c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63"),
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				Name = @"LaneSet1",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("ec73ec34-a256-4185-ae96-bef65349aa7e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("07c3c1ee-90f2-4e5c-b443-2df3c715613c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63"),
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateOnEducationActivityAddedSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaOnEducationActivityAddedSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5d1c8f20-a24f-4a6a-9619-3b8c52e3bded"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ec73ec34-a256-4185-ae96-bef65349aa7e"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63"),
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				Name = @"OnEducationActivityAddedSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 20),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(294, 123),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaOnEducationActivityAddedSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateEducationActivityInsertedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f2f7dc3c-732a-4bf7-b7d2-fdf8f73d444b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5d1c8f20-a24f-4a6a-9619-3b8c52e3bded"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63"),
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"EducationActivityInserted",
				ModifiedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				Name = @"EducationActivityInserted",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOnEducationActivityAddedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0d850dcf-d2fd-4839-9368-7ccc7d0b43db"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5d1c8f20-a24f-4a6a-9619-3b8c52e3bded"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63"),
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				Name = @"OnEducationActivityAddedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(180, 20),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,115,77,41,77,78,44,201,204,207,115,76,46,201,44,203,44,169,116,76,73,73,77,209,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,12,18,166,193,40,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateonEducationActivityUpdatedSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaonEducationActivityUpdatedSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("6d01459d-3798-4741-8b67-3881d23620f1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ec73ec34-a256-4185-ae96-bef65349aa7e"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63"),
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				Name = @"onEducationActivityUpdatedSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 180),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(300, 128),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaonEducationActivityUpdatedSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateEducationActivityUpdatedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("342057e1-b6da-46bc-a9b1-02cbdf627115"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6d01459d-3798-4741-8b67-3881d23620f1"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63"),
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"EducationActivityUpdated",
				ModifiedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				Name = @"EducationActivityUpdated",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 39),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOnEducationActivityUpdatedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1d775339-305e-4d30-9d64-59c1d99518e4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6d01459d-3798-4741-8b67-3881d23620f1"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63"),
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				Name = @"OnEducationActivityUpdatedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(180, 25),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,115,77,41,77,78,44,201,204,207,115,76,46,201,44,203,44,169,12,45,72,73,44,73,77,209,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,113,160,103,245,42,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateOnEducationActivityDeletedSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaOnEducationActivityDeletedSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ed700a2a-bb1b-4fbf-ab4f-4b3636126ff7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ec73ec34-a256-4185-ae96-bef65349aa7e"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63"),
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				Name = @"OnEducationActivityDeletedSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 340),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(300, 128),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaOnEducationActivityDeletedSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateEducationActivityDeletedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("fbc75d42-cf3b-4285-b287-002e5db6b910"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ed700a2a-bb1b-4fbf-ab4f-4b3636126ff7"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63"),
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"EducationActivityDeleted",
				ModifiedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				Name = @"EducationActivityDeleted",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 36),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOnEducationActivityDeletedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("36fab8e4-6e61-48d4-a958-adbee64032aa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ed700a2a-bb1b-4fbf-ab4f-4b3636126ff7"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63"),
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				Name = @"OnEducationActivityDeletedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(180, 22),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,115,77,41,77,78,44,201,204,207,115,76,46,201,44,203,44,169,116,73,205,73,45,73,77,209,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,71,147,7,230,42,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateOnSavedSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaOnSavedSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("698b52dc-9d95-45f9-9bf9-945421844b2d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ec73ec34-a256-4185-ae96-bef65349aa7e"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("867b9a25-86bf-4a3e-8ecd-b6e40f57be82"),
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				Name = @"OnSavedSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 516),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(300, 144),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaOnSavedSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOnSavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("63acfcdc-3234-4f13-8644-11a1a0e73e6a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("698b52dc-9d95-45f9-9bf9-945421844b2d"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("867b9a25-86bf-4a3e-8ecd-b6e40f57be82"),
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"EducationActivitySaved",
				ModifiedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				Name = @"OnSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOnEducationActivitySavedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4f06721a-8536-4ee1-9194-4a110ac09abf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("698b52dc-9d95-45f9-9bf9-945421844b2d"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("867b9a25-86bf-4a3e-8ecd-b6e40f57be82"),
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				Name = @"OnEducationActivitySavedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(180, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,146,193,106,2,49,16,134,207,238,83,132,61,101,69,226,3,88,11,117,21,17,74,177,85,219,99,73,147,177,13,100,19,73,38,218,109,241,221,155,40,219,93,189,120,74,24,254,249,191,127,38,25,246,247,220,17,97,13,114,129,11,73,198,100,102,80,97,205,230,128,235,122,7,178,180,58,84,230,149,235,0,119,243,160,228,61,205,203,70,157,23,163,76,109,9,237,180,143,137,9,90,23,228,55,235,57,192,224,12,65,23,96,148,29,179,196,241,104,29,200,165,179,2,100,112,16,105,6,14,100,117,89,165,27,15,46,50,12,8,84,214,12,72,142,126,247,254,32,48,112,173,126,96,201,29,154,40,0,135,106,171,4,71,240,165,13,6,83,152,43,127,246,166,240,43,234,121,5,8,142,38,214,115,0,87,183,165,188,177,229,9,53,141,102,249,128,164,99,173,42,96,27,20,79,246,16,3,52,149,188,184,9,57,239,139,197,252,30,219,197,164,190,224,149,249,36,116,58,153,125,131,8,209,132,200,143,255,235,152,92,78,205,102,198,71,243,233,164,45,209,226,180,214,182,137,173,48,238,98,237,184,241,252,172,88,213,30,161,98,49,46,103,11,111,245,105,170,71,216,131,102,47,192,229,198,8,91,85,10,17,100,204,211,187,30,228,236,11,180,37,36,85,135,87,158,186,187,192,40,56,246,135,217,205,199,73,194,238,127,248,3,254,149,11,58,119,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateAddTransactionMethod());
			Methods.Add(CreateFindActivePartnershipMethod());
			Methods.Add(CreateFindFundMethod());
			Methods.Add(CreateFindContactMethod());
			Methods.Add(CreateOnEducationActivityAddedMethod());
			Methods.Add(CreateOnEducationActivityUpdatedMethod());
			Methods.Add(CreateCreateCertificationFundMethod());
			Methods.Add(CreateIsTransactionNeededMethod());
			Methods.Add(CreateGetFundMethod());
			Methods.Add(CreateOnEducationActivityDeletedMethod());
			Methods.Add(CreateDeleteTransactionMethod());
			Methods.Add(CreateGetPRMTransactionEntityMethod());
			Methods.Add(CreateActualizePartnerCertificatesCountMethod());
			Methods.Add(CreateGetCertificationPartnershipParametersMethod());
			Methods.Add(CreateGetCertifiedContactsCountMethod());
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
				UId = new Guid("d89152d7-f5b7-47ab-91b9-2a38b137912c"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63")
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

		protected virtual SchemaMethod CreateAddTransactionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6ae39a62-c49b-452f-9703-ecefd06121d4"),
				Name = "AddTransaction",
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,147,81,107,194,48,16,199,159,39,248,29,130,79,21,164,176,231,205,129,179,42,62,8,162,110,239,89,122,106,160,73,75,114,17,100,238,187,47,105,90,141,90,89,247,214,222,253,239,119,255,187,36,19,137,28,143,132,229,18,41,67,50,36,83,46,211,177,255,139,38,101,50,158,1,110,142,5,216,112,102,132,252,164,153,129,215,153,225,233,91,212,171,148,243,180,215,239,191,116,59,124,75,162,51,106,72,164,201,50,114,58,213,116,7,10,24,81,111,196,88,110,100,89,93,203,251,228,187,219,121,82,128,70,73,11,252,233,118,188,9,82,80,133,18,148,222,243,162,114,57,98,200,15,176,188,196,163,160,207,35,195,65,203,218,240,21,249,15,23,12,20,242,45,103,20,121,46,167,70,166,214,139,237,230,190,66,206,128,44,87,139,119,170,193,238,71,35,149,168,227,241,109,165,115,232,44,212,243,41,177,81,84,106,235,223,10,60,214,66,130,152,23,70,174,230,90,28,175,1,19,216,6,211,234,7,170,171,237,7,57,231,197,174,164,193,118,2,95,28,111,148,45,216,110,192,18,120,183,176,120,169,184,160,234,24,200,91,240,70,194,157,154,229,61,183,16,251,69,53,207,51,73,141,247,82,222,30,43,91,179,61,8,250,49,79,91,128,87,192,114,229,231,170,158,70,243,48,26,21,151,59,146,130,102,138,23,213,121,250,96,60,205,149,160,24,5,109,22,160,53,221,193,6,68,145,81,132,193,249,185,84,240,132,107,155,248,231,194,146,75,111,235,54,112,210,84,75,15,96,47,204,47,17,127,39,175,11,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFindActivePartnershipMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("61133b1a-4a90-443f-b621-2a68ca76de1c"),
				Name = "FindActivePartnership",
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63"),
				ResultValueTypeName = "Entity"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8407f87b-6210-45f2-b439-1ff45e51e6df"),
				Name = "accountId",
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				ModifiedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,80,189,106,3,49,12,222,251,20,230,166,59,8,126,129,144,225,184,166,37,67,105,74,90,58,11,159,218,51,248,231,34,203,9,126,251,202,245,208,144,185,155,36,62,125,127,23,32,133,233,172,118,42,224,85,237,3,91,46,39,179,160,135,183,140,84,250,143,132,52,197,16,208,176,141,65,223,2,94,32,192,55,210,70,117,71,32,14,72,105,177,107,55,108,31,132,79,31,201,122,160,242,75,50,69,151,125,208,135,52,186,43,148,116,66,39,108,162,200,148,177,161,159,172,99,249,215,227,60,247,117,159,8,129,177,93,63,45,47,34,0,30,43,164,111,199,41,250,21,200,166,24,222,203,138,122,127,206,224,196,200,104,76,204,129,187,141,130,54,29,230,97,248,95,9,73,33,85,92,80,52,170,255,74,223,74,145,148,174,181,164,204,223,184,171,237,234,103,228,123,208,93,179,66,67,200,153,110,159,197,51,37,126,165,71,252,130,236,184,31,182,63,197,182,63,210,174,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFindFundMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9ce91be8-788b-45bb-a4c7-457b6c495fbc"),
				Name = "FindFund",
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63"),
				ResultValueTypeName = "Entity"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("7da81b02-b182-4d31-b63b-cb2d439065ed"),
				Name = "partnership",
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				ModifiedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("7306295c-208d-467f-afb4-f3b1d3bdf379"),
				Name = "fundTypeId",
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				ModifiedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,80,203,106,195,48,16,60,55,95,33,124,178,193,232,7,66,14,193,77,74,14,165,41,233,227,188,216,155,90,32,173,156,213,170,65,127,95,185,106,73,200,161,208,219,238,48,59,51,59,159,192,10,195,73,173,20,225,89,109,72,140,164,67,63,162,131,231,136,156,234,215,128,220,121,34,236,197,120,210,215,132,71,32,248,64,110,85,181,141,52,84,205,114,145,133,244,158,141,3,78,223,215,157,183,209,145,222,133,181,61,67,10,7,180,89,38,91,9,71,44,236,173,177,130,28,244,122,24,234,121,239,24,65,176,160,239,70,198,61,48,56,156,41,245,226,174,192,157,119,19,176,9,158,94,210,132,122,115,138,96,219,42,19,133,50,109,52,83,213,170,233,178,253,6,42,89,222,192,70,108,154,127,155,255,97,93,222,159,129,108,124,252,25,119,195,108,82,218,202,206,182,212,167,250,203,184,154,107,215,15,40,183,164,155,202,179,12,163,68,190,62,206,201,57,200,19,223,227,17,162,149,186,89,126,1,129,64,106,114,199,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFindContactMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6baa2ccf-9956-43c1-9674-25488932152e"),
				Name = "FindContact",
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63"),
				ResultValueTypeName = "Entity"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8d24b117-1a12-4377-b842-dfb10f8eb9fe"),
				Name = "contactId",
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				ModifiedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,142,65,10,131,48,16,69,247,61,69,112,165,32,185,128,116,33,82,138,139,150,22,233,1,134,56,180,130,153,224,100,82,201,237,155,26,10,210,237,231,241,254,123,3,43,244,139,58,42,194,85,157,72,38,137,131,121,161,133,123,64,142,229,195,35,119,142,8,141,76,142,244,30,184,0,193,19,185,86,69,2,4,140,20,85,115,72,46,125,227,201,2,199,77,208,185,57,88,210,189,111,231,21,162,31,112,78,166,244,38,28,48,211,237,56,102,168,44,174,96,241,39,217,205,173,49,46,208,166,103,148,192,244,45,214,103,148,92,243,215,88,43,147,115,250,177,106,62,1,102,20,95,223,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnEducationActivityAddedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ac13e11b-9dde-49e1-9415-0e30ebc44c06"),
				Name = "OnEducationActivityAdded",
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,240,44,14,41,74,204,43,78,76,46,201,204,207,243,75,77,77,73,77,209,208,212,84,168,230,226,116,76,73,65,146,210,208,180,230,170,5,0,59,138,93,162,49,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnEducationActivityUpdatedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d738ff48-0025-4e51-a9f0-31af08cc2134"),
				Name = "OnEducationActivityUpdated",
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,206,49,11,194,48,20,4,224,185,249,21,207,14,37,89,252,3,210,161,104,145,46,10,34,238,161,239,132,192,51,5,243,34,136,248,223,141,186,72,39,231,187,239,184,112,38,59,164,227,213,199,228,71,13,83,220,1,12,182,206,209,195,84,29,243,79,100,221,202,60,9,146,64,161,176,62,106,208,251,114,11,93,79,146,47,113,47,124,242,146,97,235,158,243,232,223,162,43,238,86,74,7,164,44,58,112,237,104,209,82,204,34,166,170,154,134,230,19,127,248,246,235,63,247,54,16,40,230,15,95,125,84,31,40,211,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateCertificationFundMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b9b9ea30-4b82-4557-9c63-2890b4d24ba8"),
				Name = "CreateCertificationFund",
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63"),
				ResultValueTypeName = "Entity"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("135672de-b819-4e54-b13a-877442e5424a"),
				Name = "partnership",
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				ModifiedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,144,77,139,194,48,16,134,239,130,255,161,244,212,5,9,123,23,15,218,85,241,224,82,252,216,251,80,223,106,192,76,203,100,178,208,127,191,77,85,218,61,120,75,120,159,121,242,78,214,172,86,219,99,121,131,163,164,10,124,121,30,23,201,217,67,242,154,25,165,218,154,205,122,4,238,137,233,10,49,91,232,142,189,18,151,88,181,223,228,144,165,155,78,145,126,204,167,147,7,223,43,59,217,96,54,185,128,20,143,56,251,255,72,156,139,164,57,66,191,80,229,245,61,56,254,161,123,128,207,198,217,40,200,210,130,68,25,226,111,182,217,93,210,89,210,12,119,83,136,117,36,237,136,127,171,137,197,79,109,131,222,81,28,246,43,242,232,154,197,237,212,155,28,162,182,178,37,197,154,47,244,173,107,233,234,192,218,121,62,7,132,126,209,239,32,208,32,220,127,200,252,15,29,120,61,3,125,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateIsTransactionNeededMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("28b827ce-ec93-4f53-b2a9-744d97e10c06"),
				Name = "IsTransactionNeeded",
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,142,77,11,130,64,16,64,207,246,43,54,15,139,94,252,3,101,80,34,210,193,18,137,238,139,51,208,194,58,43,238,76,176,255,62,33,162,143,83,247,247,30,111,70,150,153,84,86,19,91,142,69,131,92,121,39,35,157,29,92,141,19,204,210,26,100,48,108,61,237,7,182,247,5,234,49,136,227,35,164,185,42,75,69,226,220,42,73,180,86,191,137,63,252,245,211,87,90,47,137,183,127,137,19,194,71,100,219,136,133,93,150,118,38,142,72,220,34,223,60,188,6,186,190,61,152,128,149,167,192,134,56,20,39,207,157,177,240,5,231,155,7,216,134,170,134,233,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetFundMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c0d3a462-aa21-40f4-895a-9add571e0023"),
				Name = "GetFund",
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63"),
				ResultValueTypeName = "Entity"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("7f222d6b-71df-459d-a209-2508dfe24558"),
				Name = "partnership",
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				ModifiedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("abca78cf-96ad-449e-899d-222f6d0532de"),
				Name = "fundTypeId",
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				ModifiedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,205,43,201,44,169,84,72,78,45,42,201,76,203,76,78,44,201,204,207,115,43,205,75,81,176,85,112,203,204,75,1,49,53,10,18,139,74,242,82,139,138,51,50,11,116,20,2,130,124,157,18,139,83,157,243,243,138,75,18,243,74,138,245,156,209,181,134,84,22,164,106,90,115,101,166,41,104,96,49,214,86,33,175,52,39,71,83,161,154,139,19,155,165,206,69,169,137,37,169,24,102,34,187,1,104,118,45,87,81,106,73,105,81,30,166,187,173,1,97,206,227,143,209,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnEducationActivityDeletedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1d200da3-bbfc-4fc7-a0df-2446f39cbc6a"),
				Name = "OnEducationActivityDeleted",
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,73,205,73,45,73,13,41,74,204,43,78,76,46,201,204,207,211,208,180,6,0,207,126,93,78,20,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateDeleteTransactionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("17c67ae0-3601-4ebd-9456-f4cde962604c"),
				Name = "DeleteTransaction",
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,142,187,14,130,64,16,69,107,73,248,135,9,21,36,132,31,240,81,200,195,88,152,16,98,236,215,101,208,53,176,107,134,65,67,8,255,46,172,141,210,206,220,123,207,73,53,43,238,225,73,205,153,132,110,133,100,101,52,108,225,128,156,23,167,159,91,106,131,126,176,118,157,151,32,168,144,229,61,54,186,84,243,179,157,26,26,223,144,40,155,21,212,111,90,38,165,111,33,152,235,3,37,239,96,112,157,213,224,21,40,13,149,199,210,11,225,59,24,229,164,154,41,31,155,186,107,244,69,212,29,142,174,51,78,20,85,129,255,175,21,101,51,52,35,211,36,123,127,33,16,4,150,176,40,36,88,35,163,149,30,63,163,118,41,77,234,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetPRMTransactionEntityMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d2ffda19-b398-4602-aef0-c39c1cbf51f5"),
				Name = "GetPRMTransactionEntity",
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63"),
				ResultValueTypeName = "Entity"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,205,43,201,44,169,12,78,206,72,205,77,84,40,40,202,13,41,74,204,43,78,76,46,201,204,207,131,10,218,42,132,22,167,22,57,231,231,229,165,130,133,245,92,145,180,248,38,230,37,166,167,22,233,185,167,150,120,230,21,151,36,230,37,167,58,85,250,37,230,166,106,40,5,4,249,34,25,166,164,105,205,203,85,148,90,82,90,148,135,213,26,61,231,162,212,196,146,84,136,217,26,168,54,106,90,3,0,30,156,42,37,166,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateActualizePartnerCertificatesCountMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6dae51d7-9986-4077-9b3d-1cde942b9584"),
				Name = "ActualizePartnerCertificatesCount",
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				CreatedInPackageId = new Guid("867b9a25-86bf-4a3e-8ecd-b6e40f57be82"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,207,10,130,64,16,198,207,249,20,139,39,133,240,5,204,64,196,164,91,135,236,190,172,35,13,108,163,172,179,130,69,239,222,146,246,135,12,143,243,205,124,191,249,102,114,98,228,65,168,134,88,42,22,137,216,33,85,217,88,5,249,179,25,21,192,199,161,5,39,107,123,161,147,212,22,54,133,197,106,27,248,211,228,190,242,195,48,246,122,105,132,84,170,177,228,20,199,154,168,75,128,244,53,238,59,63,214,34,248,242,39,130,172,214,161,184,121,43,3,108,13,197,222,125,218,193,216,195,65,26,38,48,221,25,219,41,119,250,171,127,104,111,250,204,249,119,139,151,129,97,172,81,73,134,146,81,119,145,99,91,169,241,10,65,217,129,113,119,19,56,86,67,235,121,154,165,123,199,79,61,0,17,112,193,62,118,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetCertificationPartnershipParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("52a47887-4ca4-49e7-9dac-8f0a9b9040fe"),
				Name = "GetCertificationPartnershipParameters",
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				CreatedInPackageId = new Guid("867b9a25-86bf-4a3e-8ecd-b6e40f57be82"),
				ResultValueTypeName = "EntityCollection"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f00b6481-4fc6-4fa2-9ce5-bc35a96d34c9"),
				Name = "PartnershipId",
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				ModifiedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("867b9a25-86bf-4a3e-8ecd-b6e40f57be82")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,203,110,131,48,16,60,195,87,32,78,32,69,252,64,212,67,106,209,170,135,52,125,170,231,13,108,192,146,177,201,122,221,150,191,175,137,149,22,165,169,196,49,189,173,215,51,187,51,178,231,29,40,169,144,88,238,100,5,44,141,126,0,98,141,100,91,217,251,18,58,100,164,210,238,147,171,68,227,71,82,106,150,60,60,87,45,118,240,232,144,134,236,213,34,9,163,53,86,35,187,152,2,214,160,161,65,90,196,81,122,110,106,154,47,227,57,171,139,85,93,175,148,10,51,133,81,174,211,54,155,203,189,145,202,87,118,156,145,197,209,44,138,32,4,198,64,124,147,220,126,95,218,44,52,133,233,122,32,105,141,126,25,122,44,202,189,3,181,72,166,30,83,239,121,114,188,171,115,175,55,186,68,197,1,55,118,15,154,159,214,215,96,209,191,167,101,208,108,139,205,86,201,230,184,251,7,123,153,134,254,248,103,193,220,111,111,194,17,161,230,83,202,127,240,119,192,11,63,162,49,52,156,243,118,239,186,45,210,102,39,130,26,172,203,207,222,151,246,200,25,237,17,178,35,61,43,253,197,45,114,72,182,207,159,10,81,63,73,126,190,252,2,10,92,36,26,75,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetCertifiedContactsCountMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("011091f9-71d1-4361-adb4-f6a45318c44c"),
				Name = "GetCertifiedContactsCount",
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				CreatedInPackageId = new Guid("867b9a25-86bf-4a3e-8ecd-b6e40f57be82"),
				ResultValueTypeName = "int"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f3a742b2-5441-4466-8d73-b8bc7707a5f8"),
				Name = "AccountId",
				CreatedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				ModifiedInSchemaUId = new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("867b9a25-86bf-4a3e-8ecd-b6e40f57be82")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,77,75,3,49,16,134,207,45,244,63,132,61,37,32,1,207,126,64,173,91,89,16,21,106,241,28,211,81,3,187,19,157,73,108,65,252,239,206,126,212,182,130,232,109,230,77,242,204,147,236,46,160,6,159,148,143,25,211,162,175,207,20,194,90,245,141,94,50,208,44,34,74,29,34,26,59,139,117,110,80,207,51,122,169,229,144,238,19,105,144,147,62,54,198,76,198,163,145,157,83,108,116,33,97,114,62,21,198,78,89,186,162,95,123,120,1,2,93,76,125,55,181,90,201,114,197,229,91,118,245,22,118,231,200,53,144,128,244,247,166,129,59,197,149,54,182,220,4,78,172,219,100,244,183,236,79,195,173,28,80,10,79,193,187,4,98,48,72,13,198,7,82,34,126,164,138,54,234,6,118,14,69,197,156,225,178,63,91,241,53,48,223,210,47,119,104,119,221,135,6,236,50,249,155,184,54,251,152,114,243,26,104,199,185,34,144,146,254,143,82,142,135,219,183,208,189,246,100,50,206,28,240,89,233,119,71,106,245,88,110,192,231,20,73,62,239,225,51,217,18,57,139,194,197,46,210,194,253,16,30,65,202,132,251,63,135,237,49,176,240,174,118,116,26,48,157,107,35,163,62,191,0,169,17,145,16,72,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new EducationActivityEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7660d2f3-819a-41bd-a489-6bfa5ecd6c56"));
		}

		#endregion

	}

	#endregion


	#region Class: EducationActivityEventsProcess

	/// <exclude/>
	public class EducationActivityEventsProcess : EducationActivity_PRMBaseEventsProcess
	{

		public EducationActivityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

