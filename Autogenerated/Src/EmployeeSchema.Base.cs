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
	using Terrasoft.Configuration.EntitySynchronization;
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

	#region Class: EmployeeSchema

	/// <exclude/>
	public class EmployeeSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public EmployeeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public EmployeeSchema(EmployeeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public EmployeeSchema(EmployeeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008");
			RealUId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008");
			Name = "Employee";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("aa5bcb67-9cba-4df2-8ba6-da13bd4b56f0");
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
			if (Columns.FindByUId(new Guid("9b5d9ac5-c444-49fc-9249-fb8c2e542256")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("50fc7e29-dbfa-461e-8d12-fb7c04e3de23")) == null) {
				Columns.Add(CreateOrgStructureUnitColumn());
			}
			if (Columns.FindByUId(new Guid("a074483e-df7c-46eb-85c3-64aa4e13384e")) == null) {
				Columns.Add(CreateNotesColumn());
			}
			if (Columns.FindByUId(new Guid("f0ed710c-9196-41dc-93a2-2fcff481f430")) == null) {
				Columns.Add(CreateJobColumn());
			}
			if (Columns.FindByUId(new Guid("8ddae296-75c2-4304-9e81-6cbb5304f410")) == null) {
				Columns.Add(CreateFullJobTitleColumn());
			}
			if (Columns.FindByUId(new Guid("b211cbf0-f482-48f8-a34e-45010daefb3b")) == null) {
				Columns.Add(CreateOwnerColumn());
			}
			if (Columns.FindByUId(new Guid("b168bc60-e4bf-4b5d-bdf6-6866f9bfa495")) == null) {
				Columns.Add(CreateCareerStartDateColumn());
			}
			if (Columns.FindByUId(new Guid("35a0ed43-aeb6-4348-8fa2-cfdeee78aa30")) == null) {
				Columns.Add(CreateCareerDueDateColumn());
			}
			if (Columns.FindByUId(new Guid("c9a68a88-aeb9-4597-a7a1-f4540ff4a15e")) == null) {
				Columns.Add(CreateProbationDueDateColumn());
			}
			if (Columns.FindByUId(new Guid("af4c903a-ecd9-48f1-b3ed-a58f51cc39df")) == null) {
				Columns.Add(CreateReasonForDismissalColumn());
			}
			if (Columns.FindByUId(new Guid("9ed825a5-7740-4313-8a8a-cae3a08ed417")) == null) {
				Columns.Add(CreateAccountColumn());
			}
			if (Columns.FindByUId(new Guid("a18466a9-f823-4cb9-bf9c-31d8a6d3c18b")) == null) {
				Columns.Add(CreateManagerColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008");
			column.CreatedInPackageId = new Guid("aa5bcb67-9cba-4df2-8ba6-da13bd4b56f0");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008");
			column.CreatedInPackageId = new Guid("aa5bcb67-9cba-4df2-8ba6-da13bd4b56f0");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008");
			column.CreatedInPackageId = new Guid("aa5bcb67-9cba-4df2-8ba6-da13bd4b56f0");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008");
			column.CreatedInPackageId = new Guid("aa5bcb67-9cba-4df2-8ba6-da13bd4b56f0");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008");
			column.CreatedInPackageId = new Guid("aa5bcb67-9cba-4df2-8ba6-da13bd4b56f0");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008");
			column.CreatedInPackageId = new Guid("aa5bcb67-9cba-4df2-8ba6-da13bd4b56f0");
			return column;
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("9b5d9ac5-c444-49fc-9249-fb8c2e542256"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008"),
				ModifiedInSchemaUId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008"),
				CreatedInPackageId = new Guid("aa5bcb67-9cba-4df2-8ba6-da13bd4b56f0"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("d19b709f-9a3e-49b6-9fb7-1cdd5082876e"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008"),
				ModifiedInSchemaUId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008"),
				CreatedInPackageId = new Guid("aa5bcb67-9cba-4df2-8ba6-da13bd4b56f0"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateOrgStructureUnitColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("50fc7e29-dbfa-461e-8d12-fb7c04e3de23"),
				Name = @"OrgStructureUnit",
				ReferenceSchemaUId = new Guid("92ac6269-362a-4cd2-9574-28f12be3ab78"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008"),
				ModifiedInSchemaUId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateNotesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("a074483e-df7c-46eb-85c3-64aa4e13384e"),
				Name = @"Notes",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008"),
				ModifiedInSchemaUId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateJobColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f0ed710c-9196-41dc-93a2-2fcff481f430"),
				Name = @"Job",
				ReferenceSchemaUId = new Guid("c3a74d81-99ee-4c40-8434-0c6eb23edf59"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008"),
				ModifiedInSchemaUId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateFullJobTitleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("8ddae296-75c2-4304-9e81-6cbb5304f410"),
				Name = @"FullJobTitle",
				CreatedInSchemaUId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008"),
				ModifiedInSchemaUId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateOwnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b211cbf0-f482-48f8-a34e-45010daefb3b"),
				Name = @"Owner",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008"),
				ModifiedInSchemaUId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentUserContact")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateCareerStartDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("b168bc60-e4bf-4b5d-bdf6-6866f9bfa495"),
				Name = @"CareerStartDate",
				CreatedInSchemaUId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008"),
				ModifiedInSchemaUId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentDate")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateCareerDueDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("35a0ed43-aeb6-4348-8fa2-cfdeee78aa30"),
				Name = @"CareerDueDate",
				CreatedInSchemaUId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008"),
				ModifiedInSchemaUId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateProbationDueDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("c9a68a88-aeb9-4597-a7a1-f4540ff4a15e"),
				Name = @"ProbationDueDate",
				CreatedInSchemaUId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008"),
				ModifiedInSchemaUId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateReasonForDismissalColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("af4c903a-ecd9-48f1-b3ed-a58f51cc39df"),
				Name = @"ReasonForDismissal",
				ReferenceSchemaUId = new Guid("acc6f535-717d-4cda-81e1-c4a3df4bec79"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008"),
				ModifiedInSchemaUId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("9ed825a5-7740-4313-8a8a-cae3a08ed417"),
				Name = @"Account",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008"),
				ModifiedInSchemaUId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateManagerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a18466a9-f823-4cb9-bf9c-31d8a6d3c18b"),
				Name = @"Manager",
				ReferenceSchemaUId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008"),
				ModifiedInSchemaUId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateEmployeeEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateEmployeeEventsProcessSchema() {
			var schema = new EmployeeEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Employee(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Employee_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new EmployeeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new EmployeeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008"));
		}

		#endregion

	}

	#endregion

	#region Class: Employee

	/// <summary>
	/// Employee.
	/// </summary>
	public class Employee : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public Employee(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Employee";
		}

		public Employee(Employee source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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
		public Guid OrgStructureUnitId {
			get {
				return GetTypedColumnValue<Guid>("OrgStructureUnitId");
			}
			set {
				SetColumnValue("OrgStructureUnitId", value);
				_orgStructureUnit = null;
			}
		}

		/// <exclude/>
		public string OrgStructureUnitName {
			get {
				return GetTypedColumnValue<string>("OrgStructureUnitName");
			}
			set {
				SetColumnValue("OrgStructureUnitName", value);
				if (_orgStructureUnit != null) {
					_orgStructureUnit.Name = value;
				}
			}
		}

		private OrgStructureUnit _orgStructureUnit;
		/// <summary>
		/// Organizational unit.
		/// </summary>
		public OrgStructureUnit OrgStructureUnit {
			get {
				return _orgStructureUnit ??
					(_orgStructureUnit = LookupColumnEntities.GetEntity("OrgStructureUnit") as OrgStructureUnit);
			}
		}

		/// <summary>
		/// Notes.
		/// </summary>
		public string Notes {
			get {
				return GetTypedColumnValue<string>("Notes");
			}
			set {
				SetColumnValue("Notes", value);
			}
		}

		/// <exclude/>
		public Guid JobId {
			get {
				return GetTypedColumnValue<Guid>("JobId");
			}
			set {
				SetColumnValue("JobId", value);
				_job = null;
			}
		}

		/// <exclude/>
		public string JobName {
			get {
				return GetTypedColumnValue<string>("JobName");
			}
			set {
				SetColumnValue("JobName", value);
				if (_job != null) {
					_job.Name = value;
				}
			}
		}

		private EmployeeJob _job;
		/// <summary>
		/// Job.
		/// </summary>
		public EmployeeJob Job {
			get {
				return _job ??
					(_job = LookupColumnEntities.GetEntity("Job") as EmployeeJob);
			}
		}

		/// <summary>
		/// Full job title.
		/// </summary>
		public string FullJobTitle {
			get {
				return GetTypedColumnValue<string>("FullJobTitle");
			}
			set {
				SetColumnValue("FullJobTitle", value);
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

		/// <summary>
		/// Start date.
		/// </summary>
		public DateTime CareerStartDate {
			get {
				return GetTypedColumnValue<DateTime>("CareerStartDate");
			}
			set {
				SetColumnValue("CareerStartDate", value);
			}
		}

		/// <summary>
		/// Due date.
		/// </summary>
		public DateTime CareerDueDate {
			get {
				return GetTypedColumnValue<DateTime>("CareerDueDate");
			}
			set {
				SetColumnValue("CareerDueDate", value);
			}
		}

		/// <summary>
		/// Probation ends.
		/// </summary>
		public DateTime ProbationDueDate {
			get {
				return GetTypedColumnValue<DateTime>("ProbationDueDate");
			}
			set {
				SetColumnValue("ProbationDueDate", value);
			}
		}

		/// <exclude/>
		public Guid ReasonForDismissalId {
			get {
				return GetTypedColumnValue<Guid>("ReasonForDismissalId");
			}
			set {
				SetColumnValue("ReasonForDismissalId", value);
				_reasonForDismissal = null;
			}
		}

		/// <exclude/>
		public string ReasonForDismissalName {
			get {
				return GetTypedColumnValue<string>("ReasonForDismissalName");
			}
			set {
				SetColumnValue("ReasonForDismissalName", value);
				if (_reasonForDismissal != null) {
					_reasonForDismissal.Name = value;
				}
			}
		}

		private ReasonForLeaving _reasonForDismissal;
		/// <summary>
		/// Reason for job change.
		/// </summary>
		public ReasonForLeaving ReasonForDismissal {
			get {
				return _reasonForDismissal ??
					(_reasonForDismissal = LookupColumnEntities.GetEntity("ReasonForDismissal") as ReasonForLeaving);
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
		public Guid ManagerId {
			get {
				return GetTypedColumnValue<Guid>("ManagerId");
			}
			set {
				SetColumnValue("ManagerId", value);
				_manager = null;
			}
		}

		/// <exclude/>
		public string ManagerName {
			get {
				return GetTypedColumnValue<string>("ManagerName");
			}
			set {
				SetColumnValue("ManagerName", value);
				if (_manager != null) {
					_manager.Name = value;
				}
			}
		}

		private Employee _manager;
		/// <summary>
		/// Manager.
		/// </summary>
		public Employee Manager {
			get {
				return _manager ??
					(_manager = LookupColumnEntities.GetEntity("Manager") as Employee);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Employee_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("EmployeeDeleted", e);
			Inserted += (s, e) => ThrowEvent("EmployeeInserted", e);
			Inserting += (s, e) => ThrowEvent("EmployeeInserting", e);
			Saved += (s, e) => ThrowEvent("EmployeeSaved", e);
			Saving += (s, e) => ThrowEvent("EmployeeSaving", e);
			Updated += (s, e) => ThrowEvent("EmployeeUpdated", e);
			Validating += (s, e) => ThrowEvent("EmployeeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Employee(this);
		}

		#endregion

	}

	#endregion

	#region Class: Employee_BaseEventsProcess

	/// <exclude/>
	public partial class Employee_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : Employee
	{

		public Employee_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Employee_BaseEventsProcess";
			SchemaUId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual bool IsAccountChanged {
			get;
			set;
		}

		public virtual bool IsCareerDueDateChanged {
			get;
			set;
		}

		public virtual bool IsEmployeeNameChanged {
			get;
			set;
		}

		public virtual bool IsCareerStartDateChanged {
			get;
			set;
		}

		private ProcessFlowElement _employeeUpdatedSubProcess;
		public ProcessFlowElement EmployeeUpdatedSubProcess {
			get {
				return _employeeUpdatedSubProcess ?? (_employeeUpdatedSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EmployeeUpdatedSubProcess",
					SchemaElementUId = new Guid("24042ed9-1a98-4d41-9e72-8b47609b1dcf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _employeeUpdatedMessage;
		public ProcessFlowElement EmployeeUpdatedMessage {
			get {
				return _employeeUpdatedMessage ?? (_employeeUpdatedMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "EmployeeUpdatedMessage",
					SchemaElementUId = new Guid("b4db5728-ee6d-4c2b-9759-1736f738affe"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _employeeUpdatedScriptTask;
		public ProcessScriptTask EmployeeUpdatedScriptTask {
			get {
				return _employeeUpdatedScriptTask ?? (_employeeUpdatedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "EmployeeUpdatedScriptTask",
					SchemaElementUId = new Guid("59770401-a81c-41f6-9f11-1b72bfaec601"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = EmployeeUpdatedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _employeeInsertedSubProcess;
		public ProcessFlowElement EmployeeInsertedSubProcess {
			get {
				return _employeeInsertedSubProcess ?? (_employeeInsertedSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EmployeeInsertedSubProcess",
					SchemaElementUId = new Guid("77b58dff-b49d-492f-ada9-0db6964c7ce9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _insertedMessage;
		public ProcessFlowElement InsertedMessage {
			get {
				return _insertedMessage ?? (_insertedMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "InsertedMessage",
					SchemaElementUId = new Guid("86080eb7-fb0f-461f-b472-9ae97da2589e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _employeeInsertedScriptTask;
		public ProcessScriptTask EmployeeInsertedScriptTask {
			get {
				return _employeeInsertedScriptTask ?? (_employeeInsertedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "EmployeeInsertedScriptTask",
					SchemaElementUId = new Guid("b8d81135-ee09-41a5-886d-48996bee9547"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = EmployeeInsertedScriptTaskExecute,
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
					SchemaElementUId = new Guid("12f21f67-ecda-43eb-bd29-888121ec565f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _employeeSavedScriptTask;
		public ProcessScriptTask EmployeeSavedScriptTask {
			get {
				return _employeeSavedScriptTask ?? (_employeeSavedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "EmployeeSavedScriptTask",
					SchemaElementUId = new Guid("5d739ea1-5f61-4558-aabb-f74d4facd4bf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = EmployeeSavedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _savedMessage;
		public ProcessFlowElement SavedMessage {
			get {
				return _savedMessage ?? (_savedMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SavedMessage",
					SchemaElementUId = new Guid("e7fa5bf7-a717-4805-86bd-9b31b885c515"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("462b12fa-e94c-4a14-acc7-04473ebe21f5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _savingMessage;
		public ProcessFlowElement SavingMessage {
			get {
				return _savingMessage ?? (_savingMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SavingMessage",
					SchemaElementUId = new Guid("a4f9de50-1b04-4fc6-8cd9-c63717912a2f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _savingScriptTask;
		public ProcessScriptTask SavingScriptTask {
			get {
				return _savingScriptTask ?? (_savingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SavingScriptTask",
					SchemaElementUId = new Guid("4a800588-65bf-4f22-991f-5214ce4a27b7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SavingScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EmployeeUpdatedSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { EmployeeUpdatedSubProcess };
			FlowElements[EmployeeUpdatedMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EmployeeUpdatedMessage };
			FlowElements[EmployeeUpdatedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { EmployeeUpdatedScriptTask };
			FlowElements[EmployeeInsertedSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { EmployeeInsertedSubProcess };
			FlowElements[InsertedMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { InsertedMessage };
			FlowElements[EmployeeInsertedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { EmployeeInsertedScriptTask };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[EmployeeSavedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { EmployeeSavedScriptTask };
			FlowElements[SavedMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SavedMessage };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[SavingMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SavingMessage };
			FlowElements[SavingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SavingScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EmployeeUpdatedSubProcess":
						break;
					case "EmployeeUpdatedMessage":
						e.Context.QueueTasks.Enqueue("EmployeeUpdatedScriptTask");
						break;
					case "EmployeeUpdatedScriptTask":
						break;
					case "EmployeeInsertedSubProcess":
						break;
					case "InsertedMessage":
						e.Context.QueueTasks.Enqueue("EmployeeInsertedScriptTask");
						break;
					case "EmployeeInsertedScriptTask":
						break;
					case "EventSubProcess1":
						break;
					case "EmployeeSavedScriptTask":
						break;
					case "SavedMessage":
						e.Context.QueueTasks.Enqueue("EmployeeSavedScriptTask");
						break;
					case "EventSubProcess2":
						break;
					case "SavingMessage":
						e.Context.QueueTasks.Enqueue("SavingScriptTask");
						break;
					case "SavingScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("EmployeeUpdatedMessage");
			ActivatedEventElements.Add("InsertedMessage");
			ActivatedEventElements.Add("SavedMessage");
			ActivatedEventElements.Add("SavingMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EmployeeUpdatedSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "EmployeeUpdatedMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "EmployeeUpdatedMessage";
					result = EmployeeUpdatedMessage.Execute(context);
					break;
				case "EmployeeUpdatedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "EmployeeUpdatedScriptTask";
					result = EmployeeUpdatedScriptTask.Execute(context, EmployeeUpdatedScriptTaskExecute);
					break;
				case "EmployeeInsertedSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "InsertedMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "InsertedMessage";
					result = InsertedMessage.Execute(context);
					break;
				case "EmployeeInsertedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "EmployeeInsertedScriptTask";
					result = EmployeeInsertedScriptTask.Execute(context, EmployeeInsertedScriptTaskExecute);
					break;
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "EmployeeSavedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "EmployeeSavedScriptTask";
					result = EmployeeSavedScriptTask.Execute(context, EmployeeSavedScriptTaskExecute);
					break;
				case "SavedMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SavedMessage";
					result = SavedMessage.Execute(context);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "SavingMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SavingMessage";
					result = SavingMessage.Execute(context);
					break;
				case "SavingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SavingScriptTask";
					result = SavingScriptTask.Execute(context, SavingScriptTaskExecute);
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
				case "IsCareerStartDateChanged":
					IsCareerStartDateChanged = reader.GetValue<System.Boolean>();
				break;
				case "IsEmployeeNameChanged":
					IsEmployeeNameChanged = reader.GetValue<System.Boolean>();
				break;
				case "IsCareerDueDateChanged":
					IsCareerDueDateChanged = reader.GetValue<System.Boolean>();
				break;
				case "IsAccountChanged":
					IsAccountChanged = reader.GetValue<System.Boolean>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool EmployeeUpdatedScriptTaskExecute(ProcessExecutingContext context) {
			OnEmployeeUpdated();
			return true;
		}

		public virtual bool EmployeeInsertedScriptTaskExecute(ProcessExecutingContext context) {
			OnEmployeeInserted();
			return true;
		}

		public virtual bool EmployeeSavedScriptTaskExecute(ProcessExecutingContext context) {
			OnEmployeeSaved();
			return true;
		}

		public virtual bool SavingScriptTaskExecute(ProcessExecutingContext context) {
			OnEmployeeSaving();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "EmployeeUpdated":
							if (ActivatedEventElements.Contains("EmployeeUpdatedMessage")) {
							context.QueueTasks.Enqueue("EmployeeUpdatedMessage");
						}
						break;
					case "EmployeeInserted":
							if (ActivatedEventElements.Contains("InsertedMessage")) {
							context.QueueTasks.Enqueue("InsertedMessage");
						}
						break;
					case "EmployeeSaved":
							if (ActivatedEventElements.Contains("SavedMessage")) {
							context.QueueTasks.Enqueue("SavedMessage");
						}
						break;
					case "EmployeeSaving":
							if (ActivatedEventElements.Contains("SavingMessage")) {
							context.QueueTasks.Enqueue("SavingMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("IsCareerStartDateChanged") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsCareerStartDateChanged", IsCareerStartDateChanged, false);
			}
			if (!HasMapping("IsEmployeeNameChanged") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsEmployeeNameChanged", IsEmployeeNameChanged, false);
			}
			if (!HasMapping("IsCareerDueDateChanged") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsCareerDueDateChanged", IsCareerDueDateChanged, false);
			}
			if (!HasMapping("IsAccountChanged") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsAccountChanged", IsAccountChanged, false);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: Employee_BaseEventsProcess

	/// <exclude/>
	public class Employee_BaseEventsProcess : Employee_BaseEventsProcess<Employee>
	{

		public Employee_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Employee_BaseEventsProcess

	public partial class Employee_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void OnEmployeeUpdated() {
			if (!GetIsCareerInformationEmpty()) {
				if (GetIsCareerColumnsChanged()) {
					SynchronizeEmployeeAndEmployeeCareer();
				}
			}
		}

		public virtual void OnEmployeeInserted() {
			if (!GetIsCareerInformationEmpty()) {
				IEntitySynchronizationProvider provider = CreateEntitySynchronizationProvider();
				Entity employeeCareer = provider.CreateEntity("EmployeeCareer");
				IColumnValuesSynchronizer synchronizer = CreateColumnValuesSynchronizer();
				ICollection<SynchronizationColumnMapping> columnMappings = GetSynchronizationColumnMappings();
				synchronizer.FillDestinationEntity(Entity, employeeCareer, columnMappings);
				employeeCareer.SetColumnValue("IsCurrent", GetEmployeeIsCurrent());
				employeeCareer.SetColumnValue("EmployeeId", Entity.PrimaryColumnValue);
			        var isNeedToCheckRequiredFields = GetIsNeedToCheckRequiredFields();
				employeeCareer.Save(isNeedToCheckRequiredFields);
			}
		}

		public virtual IEntitySynchronizationProvider CreateEntitySynchronizationProvider() {
			return ClassFactory.Get<EntitySynchronizationProvider>(new ConstructorArgument("userConnection", UserConnection));
		}

		public virtual IColumnValuesSynchronizer CreateColumnValuesSynchronizer() {
			return ClassFactory.Get<ColumnValuesSynchronizer>();
		}

		public virtual ICollection<SynchronizationColumnMapping> GetSynchronizationColumnMappings() {
			IEqualComparatorProvider provider = CreateEqualComparatorProvider();
			SynchronizationColumnComparator dateEqualComparator = provider.GetDateEqualComparator();
			SynchronizationColumnComparator stringEqualComparator = provider.GetStringEqualComparator();
			return new List<SynchronizationColumnMapping> {
				new SynchronizationColumnMapping {
					SourceColumnName = "AccountId",
					DestinationColumnName = "AccountId"
				},
				new SynchronizationColumnMapping {
					SourceColumnName = "OrgStructureUnitId",
					DestinationColumnName = "OrgStructureUnitId"
				},
				new SynchronizationColumnMapping {
					SourceColumnName = "JobId",
					DestinationColumnName = "EmployeeJobId"
				},
				new SynchronizationColumnMapping {
					SourceColumnName = "FullJobTitle",
					DestinationColumnName = "FullJobTitle",
					Comparator = stringEqualComparator
				},
				new SynchronizationColumnMapping {
					SourceColumnName = "CareerStartDate",
					DestinationColumnName = "StartDate",
					Comparator = dateEqualComparator
				},
				new SynchronizationColumnMapping {
					SourceColumnName = "CareerDueDate",
					DestinationColumnName = "DueDate",
					Comparator = dateEqualComparator
				},
				new SynchronizationColumnMapping {
					SourceColumnName = "ProbationDueDate",
					DestinationColumnName = "ProbationDueDate",
					Comparator = dateEqualComparator
				},
				new SynchronizationColumnMapping {
					SourceColumnName = "ReasonForDismissalId",
					DestinationColumnName = "ReasonForDismissalId"
				}
			};
		}

		public virtual void SynchronizeEmployeeAndEmployeeCareer() {
			IEntitySynchronizationProvider provider = CreateEntitySynchronizationProvider();
			IColumnValuesSynchronizer synchronizer = CreateColumnValuesSynchronizer();
			ICollection<SynchronizationColumnMapping> columnMappings = GetSynchronizationColumnMappings();
			Entity employeeCareer = provider.FindEntity("EmployeeCareer", new Dictionary<string, object> {
				{"Employee", Entity.PrimaryColumnValue},
				{"IsCurrent", true}
			});
			if (employeeCareer == null) {
				employeeCareer = GetLastModifiedCareer();
				if (employeeCareer == null) {
					employeeCareer = provider.CreateEntity("EmployeeCareer");
					employeeCareer.SetColumnValue("EmployeeId", Entity.PrimaryColumnValue);
				}
				synchronizer.FillDestinationEntity(Entity, employeeCareer, columnMappings);
			} else {
				synchronizer.SynchronizeEntities(Entity, employeeCareer, columnMappings);
			}
			employeeCareer.SetColumnValue("IsCurrent", GetEmployeeIsCurrent());
			var isNeedToCheckRequiredFields = GetIsNeedToCheckRequiredFields();
			employeeCareer.Save(isNeedToCheckRequiredFields);
		}

		public virtual Entity GetLastModifiedCareer() {
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "EmployeeCareer");
			esq.PrimaryQueryColumn.IsAlwaysSelect = true;
			esq.AddAllSchemaColumns(true);
			esq.AddColumn("ModifiedOn").OrderByDesc();
			IEntitySchemaQueryFilterItem employeeFilter = esq.CreateFilterWithParameters(FilterComparisonType.Equal,
				"Employee", Entity.PrimaryColumnValue);
			esq.Filters.Add(employeeFilter);
			EntityCollection careers = esq.GetEntityCollection(UserConnection);
			return careers.FirstOrDefault();
		}

		public virtual bool GetIsCareerInformationEmpty() {
			string[] observalColumns = GetSynchronizationColumnMappings().Select(cm => cm.SourceColumnName).ToArray();
			var nullable = observalColumns.Where(s => Entity.GetColumnValue(s) == null);
			return nullable.Count() == observalColumns.Length;
		}

		public virtual bool GetIsCareerColumnsChanged() {
			string[] observalColumns = GetSynchronizationColumnMappings().Select(cm => cm.SourceColumnName).ToArray();
			return Entity.GetChangedColumnValues().Select(c => c.Name).Intersect(observalColumns).Any();
		}

		public virtual bool GetIsCareerDueDateFilled() {
			return Entity.GetColumnValue("CareerDueDate") != null;
		}

		public virtual IEqualComparatorProvider CreateEqualComparatorProvider() {
			return ClassFactory.Get<EqualComparatorProvider>();
		}

		public virtual void OnEmployeeSaved() {
			SynchronizeContactAndEmployeeName();
			SynchronizeContactCareer();
		}

		public virtual bool GetIsAccountChanged() {
			return Entity.GetChangedColumnValues().Any(cv => cv.Name == "AccountId");
		}

		public virtual void OnEmployeeSaving() {
			IsAccountChanged = GetIsAccountChanged();
			IsCareerDueDateChanged = GetIsCareerDueDateChanged();
			IsEmployeeNameChanged = GetIsEmployeeNameChanged();
			IsCareerStartDateChanged = GetIsCareerStartDateChanged();
			var careerStartDate = Entity.GetColumnValue("CareerStartDate");
			if ((IsAccountChanged || IsCareerDueDateChanged) && careerStartDate == null && !IsCareerStartDateChanged) {
				Entity.SetColumnValue("CareerStartDate", UserConnection.CurrentUser.GetCurrentDateTime());
			}
		}

		public virtual bool GetIsCareerDueDateChanged() {
			return Entity.GetChangedColumnValues().Any(cv => cv.Name == "CareerDueDate");
		}

		public virtual void SynchronizeContactAndEmployeeName() {
			var contactId = Entity.GetColumnValue("ContactId");
			if (IsEmployeeNameChanged && contactId != null) {
				IColumnValuesSynchronizer synchronizer = CreateColumnValuesSynchronizer();
				ICollection<SynchronizationColumnMapping> columnMappings = new List<SynchronizationColumnMapping> {
					new SynchronizationColumnMapping {
						SourceColumnName = "Name",
						DestinationColumnName = "Name"
					}
				};
				IEntitySynchronizationProvider provider = CreateEntitySynchronizationProvider();
				Entity contact = provider.FindEntity("Contact", new Dictionary<string, object> {
					{"Id", contactId}
				});
				synchronizer.SynchronizeEntities(Entity, contact, columnMappings);
				contact.Save();
			}
		}

		public virtual bool GetIsEmployeeNameChanged() {
			return Entity.GetChangedColumnValues().Any(cv => cv.Name == "Name");
		}

		public virtual void SynchronizeContactCareer() {
			if (IsAccountChanged || IsCareerDueDateChanged) {
				var careerDueDate = Entity.GetColumnValue("CareerDueDate");
				var employeeAccountId = Entity.GetColumnValue("AccountId");
				Guid employeeAccountOldId = Entity.GetTypedOldColumnValue<Guid>("AccountId");
				IEntitySynchronizationProvider provider = CreateEntitySynchronizationProvider();
				Entity contact = provider.FindEntity("Contact", new Dictionary<string, object> {
					{"Id", Entity.GetColumnValue("ContactId")}
				});
				Guid contactAccountId = contact.GetTypedColumnValue<Guid>("AccountId");
				if (careerDueDate != null) {
					contact.SetColumnValue("AccountId", null);
					contact.Save();
				}
				if (!contactAccountId.Equals(employeeAccountId)) {
					contact.SetColumnValue("AccountId", employeeAccountId);
					contact.Save();
				}
				Guid contactCareerAccountId = (employeeAccountId != null)
					? (Guid)employeeAccountId
					: employeeAccountOldId;
				Entity contactCareer = provider.FindEntity("ContactCareer", new Dictionary<string, object> {
					{"Contact", contact.PrimaryColumnValue},
					{"Account", contactCareerAccountId}
				}, new Dictionary<string, OrderDirection> {
					{"ModifiedOn", OrderDirection.Descending}
				});
				if (contactCareer != null) {
					var careerStartDate = Entity.GetColumnValue("CareerStartDate");
					contactCareer.SetColumnValue("StartDate", careerStartDate);
					contactCareer.SetColumnValue("DueDate", careerDueDate);
					contactCareer.Save();
				}
			}
		}

		public virtual bool GetIsCareerStartDateChanged() {
			return Entity.GetChangedColumnValues().Any(cv => cv.Name == "CareerStartDate");
		}

		public virtual bool GetEmployeeIsCurrent() {
			return !GetIsCareerDueDateFilled();
		}

		public virtual bool GetIsNeedToCheckRequiredFields() {
			return true;
		}

		#endregion

	}

	#endregion

	#region Class: EmployeeEventsProcessSchema

	/// <exclude/>
	public class EmployeeEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public EmployeeEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public EmployeeEventsProcessSchema(EmployeeEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Employee_BaseEventsProcess";
			UId = new Guid("14215786-3385-4b99-ab88-9d477456b594");
			CreatedInPackageId = new Guid("aa5bcb67-9cba-4df2-8ba6-da13bd4b56f0");
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

		protected virtual ProcessSchemaParameter CreateIsAccountChangedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("df207ceb-8110-4392-8555-b55a4cd09374"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				Name = @"IsAccountChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsCareerDueDateChangedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("8a4ac32a-092c-4ff2-b65a-ee651ec5d083"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				Name = @"IsCareerDueDateChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsEmployeeNameChangedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("8a3fbcda-9dd8-4854-bdd8-190d9d39d2e9"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				Name = @"IsEmployeeNameChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsCareerStartDateChangedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b516f9db-14f0-419e-8710-fca87a5a919e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				Name = @"IsCareerStartDateChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateIsAccountChangedParameter());
			Parameters.Add(CreateIsCareerDueDateChangedParameter());
			Parameters.Add(CreateIsEmployeeNameChangedParameter());
			Parameters.Add(CreateIsCareerStartDateChangedParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess employeeupdatedsubprocess = CreateEmployeeUpdatedSubProcessEventSubProcess();
			FlowElements.Add(employeeupdatedsubprocess);
			ProcessSchemaEventSubProcess employeeinsertedsubprocess = CreateEmployeeInsertedSubProcessEventSubProcess();
			FlowElements.Add(employeeinsertedsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaStartMessageEvent employeeupdatedmessage = CreateEmployeeUpdatedMessageStartMessageEvent();
			employeeupdatedsubprocess.FlowElements.Add(employeeupdatedmessage);
			ProcessSchemaScriptTask employeeupdatedscripttask = CreateEmployeeUpdatedScriptTaskScriptTask();
			employeeupdatedsubprocess.FlowElements.Add(employeeupdatedscripttask);
			ProcessSchemaStartMessageEvent insertedmessage = CreateInsertedMessageStartMessageEvent();
			employeeinsertedsubprocess.FlowElements.Add(insertedmessage);
			ProcessSchemaScriptTask employeeinsertedscripttask = CreateEmployeeInsertedScriptTaskScriptTask();
			employeeinsertedsubprocess.FlowElements.Add(employeeinsertedscripttask);
			ProcessSchemaScriptTask employeesavedscripttask = CreateEmployeeSavedScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(employeesavedscripttask);
			ProcessSchemaStartMessageEvent savedmessage = CreateSavedMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(savedmessage);
			ProcessSchemaStartMessageEvent savingmessage = CreateSavingMessageStartMessageEvent();
			eventsubprocess2.FlowElements.Add(savingmessage);
			ProcessSchemaScriptTask savingscripttask = CreateSavingScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(savingscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("d3639e24-a3c3-4455-93e8-a4cbe264f08d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b4db5728-ee6d-4c2b-9759-1736f738affe"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("59770401-a81c-41f6-9f11-1b72bfaec601"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("13b744a0-3d99-4284-afcd-b35befc5591c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("86080eb7-fb0f-461f-b472-9ae97da2589e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b8d81135-ee09-41a5-886d-48996bee9547"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("1a5f9b0d-240a-4541-b96e-fbe34d25cf2c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e7fa5bf7-a717-4805-86bd-9b31b885c515"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5d739ea1-5f61-4558-aabb-f74d4facd4bf"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("561acb20-9bfe-46d4-aa43-e24d201eb097"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a4f9de50-1b04-4fc6-8cd9-c63717912a2f"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4a800588-65bf-4f22-991f-5214ce4a27b7"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("aea72f02-acc1-43d2-bab0-df55b49eff51"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				Name = @"LaneSet1",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("e2470369-b6e6-49b1-9417-374cbf06b2b5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("aea72f02-acc1-43d2-bab0-df55b49eff51"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEmployeeUpdatedSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEmployeeUpdatedSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("24042ed9-1a98-4d41-9e72-8b47609b1dcf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e2470369-b6e6-49b1-9417-374cbf06b2b5"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				Name = @"EmployeeUpdatedSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(41, 40),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(279, 123),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEmployeeUpdatedSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateEmployeeUpdatedMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b4db5728-ee6d-4c2b-9759-1736f738affe"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("24042ed9-1a98-4d41-9e72-8b47609b1dcf"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"EmployeeUpdated",
				ModifiedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				Name = @"EmployeeUpdatedMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(39, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateEmployeeUpdatedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("59770401-a81c-41f6-9f11-1b72bfaec601"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("24042ed9-1a98-4d41-9e72-8b47609b1dcf"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				Name = @"EmployeeUpdatedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(150, 20),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,115,205,45,200,201,175,76,77,13,45,72,73,44,73,77,209,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,223,182,26,235,33,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEmployeeInsertedSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEmployeeInsertedSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("77b58dff-b49d-492f-ada9-0db6964c7ce9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e2470369-b6e6-49b1-9417-374cbf06b2b5"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				Name = @"EmployeeInsertedSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(38, 203),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(282, 157),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEmployeeInsertedSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInsertedMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("86080eb7-fb0f-461f-b472-9ae97da2589e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("77b58dff-b49d-492f-ada9-0db6964c7ce9"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"EmployeeInserted",
				ModifiedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				Name = @"InsertedMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(40, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateEmployeeInsertedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b8d81135-ee09-41a5-886d-48996bee9547"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("77b58dff-b49d-492f-ada9-0db6964c7ce9"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				Name = @"EmployeeInsertedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(153, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,115,205,45,200,201,175,76,77,245,204,43,78,45,42,73,77,209,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,22,134,248,110,34,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("12f21f67-ecda-43eb-bd29-888121ec565f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e2470369-b6e6-49b1-9417-374cbf06b2b5"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(45, 400),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(283, 145),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaScriptTask CreateEmployeeSavedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5d739ea1-5f61-4558-aabb-f74d4facd4bf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("12f21f67-ecda-43eb-bd29-888121ec565f"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				Name = @"EmployeeSavedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(154, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,115,205,45,200,201,175,76,77,13,78,44,75,77,209,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,183,201,211,26,31,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSavedMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e7fa5bf7-a717-4805-86bd-9b31b885c515"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("12f21f67-ecda-43eb-bd29-888121ec565f"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"EmployeeSaved",
				ModifiedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				Name = @"SavedMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(43, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("462b12fa-e94c-4a14-acc7-04473ebe21f5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e2470369-b6e6-49b1-9417-374cbf06b2b5"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(346, 38),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(274, 138),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSavingMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a4f9de50-1b04-4fc6-8cd9-c63717912a2f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("462b12fa-e94c-4a14-acc7-04473ebe21f5"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"EmployeeSaving",
				ModifiedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				Name = @"SavingMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(38, 40),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSavingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4a800588-65bf-4f22-991f-5214ce4a27b7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("462b12fa-e94c-4a14-acc7-04473ebe21f5"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				Name = @"SavingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(154, 26),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,115,205,45,200,201,175,76,77,13,78,44,203,204,75,215,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,127,162,209,213,32,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateOnEmployeeUpdatedMethod());
			Methods.Add(CreateOnEmployeeInsertedMethod());
			Methods.Add(CreateCreateEntitySynchronizationProviderMethod());
			Methods.Add(CreateCreateColumnValuesSynchronizerMethod());
			Methods.Add(CreateGetSynchronizationColumnMappingsMethod());
			Methods.Add(CreateSynchronizeEmployeeAndEmployeeCareerMethod());
			Methods.Add(CreateGetLastModifiedCareerMethod());
			Methods.Add(CreateGetIsCareerInformationEmptyMethod());
			Methods.Add(CreateGetIsCareerColumnsChangedMethod());
			Methods.Add(CreateGetIsCareerDueDateFilledMethod());
			Methods.Add(CreateCreateEqualComparatorProviderMethod());
			Methods.Add(CreateOnEmployeeSavedMethod());
			Methods.Add(CreateGetIsAccountChangedMethod());
			Methods.Add(CreateOnEmployeeSavingMethod());
			Methods.Add(CreateGetIsCareerDueDateChangedMethod());
			Methods.Add(CreateSynchronizeContactAndEmployeeNameMethod());
			Methods.Add(CreateGetIsEmployeeNameChangedMethod());
			Methods.Add(CreateSynchronizeContactCareerMethod());
			Methods.Add(CreateGetIsCareerStartDateChangedMethod());
			Methods.Add(CreateGetEmployeeIsCurrentMethod());
			Methods.Add(CreateGetIsNeedToCheckRequiredFieldsMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("aa5bcb67-9cba-4df2-8ba6-da13bd4b56f0")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("aa5bcb67-9cba-4df2-8ba6-da13bd4b56f0")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("aa5bcb67-9cba-4df2-8ba6-da13bd4b56f0")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("aa5bcb67-9cba-4df2-8ba6-da13bd4b56f0")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("aa5bcb67-9cba-4df2-8ba6-da13bd4b56f0")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("aa5bcb67-9cba-4df2-8ba6-da13bd4b56f0")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("aa5bcb67-9cba-4df2-8ba6-da13bd4b56f0")
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
				UId = new Guid("c7b0a66c-8e94-47ea-b57f-07ee70d2b21a"),
				Name = "Terrasoft.Configuration.EntitySynchronization",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("747eec02-c4f9-436c-985e-ed39d2c5bb01"),
				Name = "System.Linq",
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

		protected virtual SchemaMethod CreateOnEmployeeUpdatedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a5e51d5f-da20-4edd-9fd5-d5ddfd391d6c"),
				Name = "OnEmployeeUpdated",
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,80,116,79,45,241,44,118,78,44,74,77,45,242,204,75,203,47,202,77,44,201,204,207,115,205,45,40,169,212,208,212,84,168,230,226,204,4,42,67,82,229,156,159,83,154,155,87,236,156,145,152,151,158,154,2,85,195,25,92,153,151,156,81,148,159,151,89,149,10,212,155,147,95,153,154,234,152,151,2,99,66,116,106,104,90,115,113,214,114,213,2,0,66,128,182,162,120,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnEmployeeInsertedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1d7697ff-6219-4d78-bf97-78f10caea66d"),
				Name = "OnEmployeeInserted",
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,145,205,110,131,48,16,132,207,201,83,56,156,140,132,120,129,254,92,40,169,56,180,138,154,170,119,11,54,205,170,198,38,107,131,68,171,190,123,77,28,82,7,53,212,23,108,52,243,237,120,140,59,198,87,143,96,11,147,9,2,160,66,237,52,213,194,162,86,121,221,216,158,199,49,251,90,46,138,92,89,180,253,182,87,229,158,180,194,207,163,98,67,186,195,10,136,53,227,230,142,101,4,194,194,172,156,199,55,203,133,87,48,168,27,169,123,0,63,221,249,71,84,26,130,120,148,95,232,162,129,80,100,90,182,181,122,19,178,5,243,59,202,81,76,120,24,35,93,83,243,145,37,161,28,82,222,78,82,123,223,147,104,26,84,239,247,172,12,143,198,209,93,121,115,14,115,228,135,137,210,53,74,249,0,198,162,242,61,251,43,250,79,50,105,36,153,12,28,96,151,138,116,11,54,184,27,143,220,83,182,68,160,108,148,12,225,198,230,206,191,221,147,254,15,57,187,42,71,241,209,210,13,97,45,168,15,116,14,196,78,171,19,196,208,60,3,84,175,58,219,67,249,241,2,135,22,9,170,53,130,172,78,69,21,215,5,252,175,80,162,3,62,3,117,150,239,31,54,73,164,176,193,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateEntitySynchronizationProviderMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("cdc0c0af-b042-44dd-a29e-dd55c451fa59"),
				Name = "CreateEntitySynchronizationProvider",
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "IEntitySynchronizationProvider"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,112,206,73,44,46,118,75,76,46,201,47,170,212,115,79,45,177,113,205,43,201,44,169,12,174,204,75,206,40,202,207,203,172,74,44,201,204,207,11,40,202,47,203,76,73,45,178,211,200,75,45,87,112,206,207,43,46,41,42,5,233,113,44,74,47,205,77,205,43,209,80,42,45,78,45,2,74,228,165,38,131,52,40,233,40,132,162,8,104,106,90,3,0,209,45,217,69,114,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateColumnValuesSynchronizerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("84e67852-3cc5-4943-8b8d-cae939b92026"),
				Name = "CreateColumnValuesSynchronizer",
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "IColumnValuesSynchronizer"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,112,206,73,44,46,118,75,76,46,201,47,170,212,115,79,45,177,113,206,207,41,205,205,11,75,204,41,77,45,14,174,204,75,206,40,202,207,203,172,74,45,178,211,208,180,6,0,0,87,121,214,52,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSynchronizationColumnMappingsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e589e35f-bfc8-440f-9dda-d2424cff3dae"),
				Name = "GetSynchronizationColumnMappings",
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "ICollection<SynchronizationColumnMapping>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,148,237,74,195,48,20,134,127,183,87,17,246,75,97,120,3,83,65,218,77,38,126,97,245,2,178,246,48,3,233,57,245,36,81,166,236,222,77,55,134,43,205,218,65,221,191,16,158,243,190,79,224,180,243,233,135,147,58,161,178,146,44,45,241,51,211,167,42,128,69,181,59,92,137,132,65,90,56,0,158,157,79,226,108,133,249,59,19,170,111,105,21,97,66,218,149,248,135,138,162,61,238,99,119,13,23,183,96,211,54,113,76,176,177,172,112,217,29,157,133,152,58,156,193,58,70,129,240,37,238,149,177,151,193,178,7,89,85,126,252,90,252,196,81,77,118,65,53,19,101,228,56,135,237,253,163,44,193,219,140,110,242,156,28,218,121,49,26,123,34,5,99,21,238,141,183,177,56,90,143,7,244,61,241,210,191,218,229,254,125,240,134,170,183,56,192,15,52,184,163,69,95,233,180,172,52,173,0,182,232,192,190,153,211,218,7,189,42,171,161,187,182,69,54,22,39,184,80,3,221,18,201,0,156,89,201,155,53,239,214,107,98,13,183,192,87,244,47,102,169,131,126,175,125,232,196,86,254,207,178,216,224,71,137,5,233,19,27,190,128,52,132,51,226,84,153,82,25,35,117,223,178,7,39,188,69,188,158,252,2,98,83,188,146,130,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSynchronizeEmployeeAndEmployeeCareerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("05ce080a-0b25-4af5-b82e-cf4b6ea18c8e"),
				Name = "SynchronizeEmployeeAndEmployeeCareer",
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,77,110,194,48,16,133,215,228,20,22,171,68,138,184,0,63,155,80,170,72,165,66,165,234,222,141,135,50,173,177,83,219,161,74,81,238,94,59,33,96,130,8,234,42,177,245,230,243,123,51,147,62,8,131,166,92,151,34,219,42,41,240,151,26,148,98,165,228,30,25,40,146,183,63,83,146,40,160,6,122,229,97,52,14,210,68,242,98,39,222,40,47,64,159,117,22,161,253,67,203,187,165,110,81,28,50,247,194,164,243,98,83,182,164,121,142,226,99,70,50,255,168,45,252,17,76,95,133,118,248,38,10,129,93,206,101,9,144,80,5,181,177,54,243,104,129,130,53,162,112,248,112,161,26,198,68,192,15,153,99,109,142,170,114,162,141,178,220,152,200,247,79,235,120,70,14,193,224,112,42,178,242,134,51,90,41,220,89,185,151,186,138,157,50,213,73,161,20,8,99,165,70,217,219,160,178,14,113,67,194,174,189,41,17,5,231,145,123,224,202,185,77,253,68,181,89,74,134,27,4,214,220,187,168,131,59,164,107,212,169,9,254,216,175,218,224,208,157,218,209,26,140,23,239,92,146,178,190,54,56,82,21,12,252,29,177,253,231,124,14,218,160,168,39,120,244,208,124,226,206,220,226,206,14,88,94,69,128,107,112,241,46,168,222,150,213,40,4,253,15,102,112,39,173,63,72,59,142,83,248,246,58,140,44,101,79,21,65,253,12,192,94,101,178,133,236,235,5,190,11,84,192,22,8,156,29,247,55,189,45,112,35,237,250,160,123,8,123,152,209,248,15,14,201,44,41,234,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetLastModifiedCareerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a028e306-d3a3-49da-a4e8-731e545da4e1"),
				Name = "GetLastModifiedCareer",
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "Entity"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,81,203,110,194,48,16,60,23,137,127,176,114,50,82,148,31,168,122,160,33,173,56,32,168,232,227,188,74,134,98,201,15,88,59,69,254,251,58,56,133,150,30,61,59,59,59,51,254,34,22,240,71,241,32,44,78,162,177,65,133,184,109,247,48,244,210,131,163,124,243,224,218,89,139,54,40,103,171,223,132,21,89,250,4,151,162,104,204,65,187,8,212,196,0,23,179,251,233,36,105,86,27,86,134,56,158,133,106,167,123,99,171,165,159,235,19,69,191,133,78,138,233,106,224,30,35,125,222,117,115,173,179,118,166,123,57,140,103,215,121,134,101,177,114,157,218,41,116,107,91,204,170,53,119,224,199,184,128,111,229,192,93,254,75,241,164,116,0,47,3,140,192,104,53,67,201,192,160,92,51,40,140,208,135,10,251,13,49,25,164,135,151,25,172,157,57,16,43,239,236,107,60,160,106,142,61,233,114,58,185,187,36,47,202,177,187,159,208,217,233,59,233,171,255,44,229,135,28,242,175,141,129,145,215,211,154,206,85,139,246,92,166,31,45,62,35,220,50,110,254,102,16,97,132,158,47,171,233,34,251,176,230,5,118,212,235,144,202,249,6,24,3,95,57,238,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsCareerInformationEmptyMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("02226ec3-da2f-48f0-ba4d-474ff6a2fdab"),
				Name = "GetIsCareerInformationEmpty",
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,206,177,10,194,48,16,6,224,93,240,29,50,38,75,94,160,68,144,34,46,234,82,209,65,28,210,112,180,129,244,82,46,151,66,125,122,211,22,28,156,255,255,190,255,18,147,199,238,245,22,177,77,64,147,13,117,12,121,192,36,140,56,3,55,51,186,158,34,250,143,101,31,113,203,174,118,28,203,77,146,74,55,16,192,177,116,131,48,7,225,6,221,196,76,14,182,218,205,14,160,244,61,30,137,236,44,85,181,223,77,150,4,230,16,108,27,160,248,127,139,250,217,3,129,76,11,117,66,246,60,235,242,193,22,62,108,200,37,82,194,152,85,88,52,2,206,132,63,80,215,49,35,203,181,242,47,95,0,59,238,171,47,221,171,242,77,236,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsCareerColumnsChangedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b7671027-331e-496e-a821-00888b7517d5"),
				Name = "GetIsCareerColumnsChanged",
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,206,177,10,194,48,16,6,224,221,167,200,216,44,121,1,169,80,138,136,131,46,21,23,113,56,227,209,6,146,75,185,92,132,248,244,182,102,17,215,255,254,251,248,147,176,163,241,118,87,241,145,144,95,224,251,232,115,160,164,90,117,64,25,10,217,137,35,185,55,136,139,84,111,39,152,231,229,39,53,218,12,232,209,74,99,131,106,119,202,6,51,196,204,22,107,237,12,1,181,185,196,142,25,74,163,183,27,70,201,76,106,79,226,164,152,69,239,39,160,17,159,181,126,5,159,241,215,252,146,166,42,71,18,228,180,198,127,51,181,233,104,197,63,4,69,94,143,199,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsCareerDueDateFilledMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0b940b99-7a86-4faf-a010-0b624c60311b"),
				Name = "GetIsCareerDueDateFilled",
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,112,205,43,201,44,169,212,115,79,45,113,206,207,41,205,205,11,75,204,41,77,213,80,114,78,44,74,77,45,114,41,77,117,73,44,73,85,210,84,80,180,85,200,43,205,201,177,6,0,245,118,154,223,54,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateEqualComparatorProviderMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("bdeab3e1-c5f3-41a7-9e06-9320b0bad9b6"),
				Name = "CreateEqualComparatorProvider",
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "IEqualComparatorProvider"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,112,206,73,44,46,118,75,76,46,201,47,170,212,115,79,45,177,113,45,44,77,204,113,206,207,45,72,44,74,4,10,6,20,229,151,101,166,164,22,217,105,104,90,3,0,31,232,5,249,51,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnEmployeeSavedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("65a174c0-631d-4143-b9c8-4e629d4dd197"),
				Name = "OnEmployeeSaved",
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,174,204,75,206,40,202,207,203,172,74,117,206,207,43,73,76,46,113,204,75,113,205,45,200,201,175,76,77,245,75,204,77,213,208,180,230,229,10,198,80,229,156,88,148,154,90,4,148,4,0,240,77,64,197,65,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsAccountChangedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("efa7b570-11b2-40ef-a916-23ce3c078148"),
				Name = "GetIsAccountChanged",
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,112,205,43,201,44,169,212,115,79,45,113,206,72,204,75,79,77,113,206,207,41,205,205,11,75,204,41,77,45,214,208,212,115,204,171,212,72,46,83,176,181,83,72,46,211,243,75,204,77,85,176,181,85,80,114,76,78,206,47,205,43,241,76,81,210,180,6,0,51,247,230,60,73,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnEmployeeSavingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("83c963e4-9d2b-4ded-a0f2-7b81afe49f4a"),
				Name = "OnEmployeeSaving",
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,143,177,14,194,48,12,68,103,248,10,195,128,82,9,241,3,168,3,10,21,234,194,82,96,143,130,129,74,169,131,82,7,169,2,254,157,134,50,64,40,98,180,207,207,119,151,215,11,173,173,39,150,39,69,71,220,67,10,43,228,60,218,138,100,62,204,107,169,28,162,91,122,92,42,198,232,190,79,235,168,172,58,27,219,32,174,85,21,67,61,210,187,83,193,202,241,79,175,88,13,228,69,57,208,159,106,11,101,196,37,55,179,150,149,214,248,138,118,202,120,20,227,232,205,184,229,203,3,8,17,151,135,219,13,250,11,38,48,153,124,251,165,64,222,152,32,141,126,101,77,224,58,28,188,98,21,127,98,77,97,91,163,147,150,8,53,151,150,102,210,59,135,196,97,251,236,212,141,225,118,83,86,40,146,182,199,253,1,159,131,243,47,215,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsCareerDueDateChangedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("04548f1e-3467-43d3-857a-e4281f7d55a8"),
				Name = "GetIsCareerDueDateChanged",
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,5,193,65,10,128,32,16,5,208,171,12,173,108,227,5,194,32,52,218,181,108,63,216,167,2,157,192,70,193,219,247,94,129,214,34,180,138,62,218,237,6,245,55,203,133,211,191,169,102,57,56,85,124,102,180,139,116,19,27,185,153,98,179,59,103,144,115,52,120,46,64,9,21,129,21,195,56,253,131,61,196,109,77,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSynchronizeContactAndEmployeeNameMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ff6be522-55a1-411b-b95d-75df17a48223"),
				Name = "SynchronizeContactAndEmployeeName",
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,82,93,107,131,48,20,125,182,208,255,144,229,161,88,16,255,192,234,94,108,55,132,109,12,132,189,103,122,215,102,196,68,146,232,112,197,255,190,124,104,155,21,218,189,168,151,123,238,57,247,158,99,79,36,170,4,215,164,210,69,141,50,180,227,154,234,33,125,2,157,11,214,53,252,157,176,14,98,156,207,16,188,190,95,46,232,39,138,11,181,107,90,38,6,128,87,210,64,126,32,124,15,53,90,173,2,182,187,12,241,142,177,53,58,46,23,81,17,240,169,114,224,213,65,10,78,127,64,34,21,22,25,202,37,16,13,215,208,177,213,119,100,12,42,77,5,223,156,187,196,214,126,240,133,180,45,229,251,7,179,77,80,42,67,207,225,27,61,83,165,255,153,179,43,71,22,123,11,230,81,81,41,58,89,77,27,91,51,140,10,182,111,156,184,246,22,148,166,60,152,254,131,177,144,209,60,70,119,151,183,255,66,243,77,138,158,214,198,156,118,254,152,93,186,9,247,86,121,200,156,138,153,156,73,210,71,202,107,223,61,229,139,19,231,207,150,58,107,137,28,54,74,75,115,104,130,196,199,151,241,123,242,229,136,205,143,144,156,147,118,251,59,181,48,203,52,200,205,233,80,80,177,23,60,205,38,23,1,57,146,169,151,150,164,7,119,196,248,11,54,81,243,177,166,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsEmployeeNameChangedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("195e3877-9fd4-49a0-a592-f9c16cd7d7e9"),
				Name = "GetIsEmployeeNameChanged",
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,112,205,43,201,44,169,212,115,79,45,113,206,72,204,75,79,77,113,206,207,41,205,205,11,75,204,41,77,45,214,208,212,115,204,171,212,72,46,83,176,181,83,72,46,211,243,75,204,77,85,176,181,85,80,2,49,148,52,173,1,28,191,225,22,68,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSynchronizeContactCareerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2a85a9bd-d139-446c-8ed4-c3e3295da34f"),
				Name = "SynchronizeContactCareer",
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,203,110,194,48,16,60,83,169,255,96,114,10,82,148,15,40,143,170,34,20,229,80,129,68,213,187,107,47,224,42,216,212,113,168,82,200,191,215,137,243,14,175,222,34,239,204,236,122,60,89,182,70,182,31,190,16,34,34,174,166,91,204,55,64,209,233,132,252,112,138,37,128,244,34,240,176,130,188,50,64,199,199,135,222,1,75,68,234,85,52,70,51,174,152,138,221,57,168,169,8,162,29,255,192,65,4,182,213,16,177,6,195,156,13,187,125,32,98,128,188,175,79,47,43,148,16,195,158,71,140,182,233,139,128,182,20,222,227,61,80,125,92,83,26,165,204,73,71,207,55,164,85,204,201,86,10,206,126,177,98,130,47,165,56,48,10,18,237,139,143,49,154,74,208,119,184,10,183,51,73,3,65,68,112,133,137,210,204,66,196,125,101,156,154,170,118,198,148,45,7,113,248,65,30,35,169,16,150,241,40,84,146,241,141,131,196,231,23,16,53,201,28,239,29,45,61,176,115,209,101,163,149,222,41,209,232,164,114,42,31,162,238,115,126,84,218,116,219,35,166,51,210,124,239,254,24,241,40,8,76,28,122,133,226,234,226,211,57,6,62,108,160,241,1,140,97,73,222,163,223,158,214,157,125,71,56,8,237,78,92,6,255,232,220,37,95,25,163,110,154,201,110,221,186,238,32,165,19,169,228,51,178,83,254,160,131,74,139,79,103,83,219,205,139,233,122,35,53,6,116,119,118,170,172,21,183,94,74,182,211,132,154,105,137,99,176,249,116,21,182,101,67,22,176,139,141,23,82,79,236,49,9,89,165,28,224,77,80,182,102,250,151,228,86,27,227,122,16,18,224,84,211,171,236,102,137,107,248,209,76,92,181,129,86,10,75,117,207,14,42,129,86,227,253,77,177,19,160,10,237,180,27,221,67,47,22,158,211,220,147,103,169,245,252,37,127,197,245,84,223,143,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsCareerStartDateChangedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c43ac740-fb33-400b-8afd-87294a72b82b"),
				Name = "GetIsCareerStartDateChanged",
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,5,193,193,10,128,32,12,0,208,95,25,158,244,226,15,132,65,88,116,235,18,116,31,54,42,208,5,107,10,254,125,239,9,105,21,134,133,245,209,238,87,210,120,35,95,116,198,55,215,194,7,230,74,159,117,126,226,110,83,131,48,66,106,126,195,66,16,2,152,136,66,36,187,162,232,140,74,198,13,63,230,209,83,99,79,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetEmployeeIsCurrentMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c74e8e56-9867-4f6a-84aa-1b915eb9385c"),
				Name = "GetEmployeeIsCurrent",
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				CreatedInPackageId = new Guid("7e406f3f-0514-4d14-a20b-c3a59a45194f"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,80,116,79,45,241,44,118,78,44,74,77,45,114,41,77,117,73,44,73,117,203,204,201,73,77,209,208,180,6,0,185,153,254,153,35,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsNeedToCheckRequiredFieldsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8518bef7-1727-4646-abf3-40af56dd5a38"),
				Name = "GetIsNeedToCheckRequiredFields",
				CreatedInSchemaUId = new Guid("14215786-3385-4b99-ab88-9d477456b594"),
				CreatedInPackageId = new Guid("7e406f3f-0514-4d14-a20b-c3a59a45194f"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new EmployeeEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("14215786-3385-4b99-ab88-9d477456b594"));
		}

		#endregion

	}

	#endregion


	#region Class: EmployeeEventsProcess

	/// <exclude/>
	public class EmployeeEventsProcess : Employee_BaseEventsProcess
	{

		public EmployeeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

