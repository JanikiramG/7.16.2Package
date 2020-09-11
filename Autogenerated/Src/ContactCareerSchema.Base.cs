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

	#region Class: ContactCareer_Base_TerrasoftSchema

	/// <exclude/>
	public class ContactCareer_Base_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ContactCareer_Base_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ContactCareer_Base_TerrasoftSchema(ContactCareer_Base_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ContactCareer_Base_TerrasoftSchema(ContactCareer_Base_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateI74adXnmFiCFKGusIbN0Dbj6qLecIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = true,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("17cb5432-9f78-4115-a8c8-643ca03dac9c");
			index.Name = "I74adXnmFiCFKGusIbN0Dbj6qLec";
			index.CreatedInSchemaUId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce");
			index.ModifiedInSchemaUId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce");
			index.CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			EntitySchemaIndexColumn contactIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("05f34390-f7ed-41ff-87b8-8ebf2e779d42"),
				ColumnUId = new Guid("d6628cf3-ba29-472e-b0f2-9b51f693ef2a"),
				CreatedInSchemaUId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce"),
				ModifiedInSchemaUId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(contactIdIndexColumn);
			EntitySchemaIndexColumn accountIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("a9d46f67-ad38-46bc-b369-368490bc8e24"),
				ColumnUId = new Guid("8996b0d8-c0d9-4da7-b130-7917fa48b854"),
				CreatedInSchemaUId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce"),
				ModifiedInSchemaUId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(accountIdIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce");
			RealUId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce");
			Name = "ContactCareer_Base_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("d6628cf3-ba29-472e-b0f2-9b51f693ef2a")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("8996b0d8-c0d9-4da7-b130-7917fa48b854")) == null) {
				Columns.Add(CreateAccountColumn());
			}
			if (Columns.FindByUId(new Guid("96d86ec7-b8fd-4288-8cc4-c5d6ca4fe46d")) == null) {
				Columns.Add(CreateDepartmentColumn());
			}
			if (Columns.FindByUId(new Guid("bf823e82-f89d-4345-b839-c429dcb2baac")) == null) {
				Columns.Add(CreateJobColumn());
			}
			if (Columns.FindByUId(new Guid("5439cefd-5021-4446-957b-f35eebe76b40")) == null) {
				Columns.Add(CreateJobTitleColumn());
			}
			if (Columns.FindByUId(new Guid("131fa275-a32c-4af9-92f0-cfedcad3679c")) == null) {
				Columns.Add(CreatePrimaryColumn());
			}
			if (Columns.FindByUId(new Guid("e370b11e-e44a-4ccb-90ed-9f0f2a455adb")) == null) {
				Columns.Add(CreateCurrentColumn());
			}
			if (Columns.FindByUId(new Guid("9e1f23da-a77e-4798-99a1-413a7a4b8aa6")) == null) {
				Columns.Add(CreateStartDateColumn());
			}
			if (Columns.FindByUId(new Guid("84b66f84-08ea-4059-b18f-d5132df7df06")) == null) {
				Columns.Add(CreateDueDateColumn());
			}
			if (Columns.FindByUId(new Guid("655e9fb9-fb88-42b7-b437-ef7bf7ef4766")) == null) {
				Columns.Add(CreateJobChangeReasonColumn());
			}
			if (Columns.FindByUId(new Guid("4e537940-3c92-48ee-a935-570176f0abde")) == null) {
				Columns.Add(CreateDescriptionColumn());
			}
			if (Columns.FindByUId(new Guid("6324d7f3-fd46-4046-b9c3-76844a3e88a6")) == null) {
				Columns.Add(CreateDecisionRoleColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d6628cf3-ba29-472e-b0f2-9b51f693ef2a"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce"),
				ModifiedInSchemaUId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected virtual EntitySchemaColumn CreateAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8996b0d8-c0d9-4da7-b130-7917fa48b854"),
				Name = @"Account",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce"),
				ModifiedInSchemaUId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected virtual EntitySchemaColumn CreateDepartmentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("96d86ec7-b8fd-4288-8cc4-c5d6ca4fe46d"),
				Name = @"Department",
				ReferenceSchemaUId = new Guid("7a269220-a657-4b5f-bfb4-ebe596e419d8"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce"),
				ModifiedInSchemaUId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected virtual EntitySchemaColumn CreateJobColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("bf823e82-f89d-4345-b839-c429dcb2baac"),
				Name = @"Job",
				ReferenceSchemaUId = new Guid("c82ab6f0-0e36-4376-9ab3-c583d714b7b6"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce"),
				ModifiedInSchemaUId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected virtual EntitySchemaColumn CreateJobTitleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("5439cefd-5021-4446-957b-f35eebe76b40"),
				Name = @"JobTitle",
				CreatedInSchemaUId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce"),
				ModifiedInSchemaUId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected virtual EntitySchemaColumn CreatePrimaryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("131fa275-a32c-4af9-92f0-cfedcad3679c"),
				Name = @"Primary",
				CreatedInSchemaUId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce"),
				ModifiedInSchemaUId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"True"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateCurrentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("e370b11e-e44a-4ccb-90ed-9f0f2a455adb"),
				Name = @"Current",
				CreatedInSchemaUId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce"),
				ModifiedInSchemaUId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"True"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateStartDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("9e1f23da-a77e-4798-99a1-413a7a4b8aa6"),
				Name = @"StartDate",
				CreatedInSchemaUId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce"),
				ModifiedInSchemaUId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentDate")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateDueDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("84b66f84-08ea-4059-b18f-d5132df7df06"),
				Name = @"DueDate",
				CreatedInSchemaUId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce"),
				ModifiedInSchemaUId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected virtual EntitySchemaColumn CreateJobChangeReasonColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("655e9fb9-fb88-42b7-b437-ef7bf7ef4766"),
				Name = @"JobChangeReason",
				ReferenceSchemaUId = new Guid("91d12da5-4a3b-4a57-ac8c-17abda1d115e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce"),
				ModifiedInSchemaUId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected virtual EntitySchemaColumn CreateDescriptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("4e537940-3c92-48ee-a935-570176f0abde"),
				Name = @"Description",
				CreatedInSchemaUId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce"),
				ModifiedInSchemaUId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected virtual EntitySchemaColumn CreateDecisionRoleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6324d7f3-fd46-4046-b9c3-76844a3e88a6"),
				Name = @"DecisionRole",
				ReferenceSchemaUId = new Guid("54aa771f-fba6-4d76-9239-bff3f00ee3e5"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce"),
				ModifiedInSchemaUId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce"),
				CreatedInPackageId = new Guid("ec420ba8-5f6d-485d-8dc2-eb22e0b326a8")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateI74adXnmFiCFKGusIbN0Dbj6qLecIndex());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateContactCareer_Base_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateContactCareer_Base_TerrasoftEventsProcessSchema() {
			var schema = new ContactCareer_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ContactCareer_Base_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ContactCareer_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ContactCareer_Base_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ContactCareer_Base_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce"));
		}

		#endregion

	}

	#endregion

	#region Class: ContactCareer_Base_Terrasoft

	/// <summary>
	/// Job experience of contact.
	/// </summary>
	public class ContactCareer_Base_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ContactCareer_Base_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ContactCareer_Base_Terrasoft";
		}

		public ContactCareer_Base_Terrasoft(ContactCareer_Base_Terrasoft source)
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
		public Guid DepartmentId {
			get {
				return GetTypedColumnValue<Guid>("DepartmentId");
			}
			set {
				SetColumnValue("DepartmentId", value);
				_department = null;
			}
		}

		/// <exclude/>
		public string DepartmentName {
			get {
				return GetTypedColumnValue<string>("DepartmentName");
			}
			set {
				SetColumnValue("DepartmentName", value);
				if (_department != null) {
					_department.Name = value;
				}
			}
		}

		private Department _department;
		/// <summary>
		/// Department.
		/// </summary>
		public Department Department {
			get {
				return _department ??
					(_department = LookupColumnEntities.GetEntity("Department") as Department);
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

		private Job _job;
		/// <summary>
		/// Job title.
		/// </summary>
		public Job Job {
			get {
				return _job ??
					(_job = LookupColumnEntities.GetEntity("Job") as Job);
			}
		}

		/// <summary>
		/// Full job title.
		/// </summary>
		public string JobTitle {
			get {
				return GetTypedColumnValue<string>("JobTitle");
			}
			set {
				SetColumnValue("JobTitle", value);
			}
		}

		/// <summary>
		/// Primary.
		/// </summary>
		public bool Primary {
			get {
				return GetTypedColumnValue<bool>("Primary");
			}
			set {
				SetColumnValue("Primary", value);
			}
		}

		/// <summary>
		/// Current.
		/// </summary>
		public bool Current {
			get {
				return GetTypedColumnValue<bool>("Current");
			}
			set {
				SetColumnValue("Current", value);
			}
		}

		/// <summary>
		/// Start.
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
		/// End.
		/// </summary>
		public DateTime DueDate {
			get {
				return GetTypedColumnValue<DateTime>("DueDate");
			}
			set {
				SetColumnValue("DueDate", value);
			}
		}

		/// <exclude/>
		public Guid JobChangeReasonId {
			get {
				return GetTypedColumnValue<Guid>("JobChangeReasonId");
			}
			set {
				SetColumnValue("JobChangeReasonId", value);
				_jobChangeReason = null;
			}
		}

		/// <exclude/>
		public string JobChangeReasonName {
			get {
				return GetTypedColumnValue<string>("JobChangeReasonName");
			}
			set {
				SetColumnValue("JobChangeReasonName", value);
				if (_jobChangeReason != null) {
					_jobChangeReason.Name = value;
				}
			}
		}

		private JobChangeReason _jobChangeReason;
		/// <summary>
		/// Reason for job change.
		/// </summary>
		public JobChangeReason JobChangeReason {
			get {
				return _jobChangeReason ??
					(_jobChangeReason = LookupColumnEntities.GetEntity("JobChangeReason") as JobChangeReason);
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
		public Guid DecisionRoleId {
			get {
				return GetTypedColumnValue<Guid>("DecisionRoleId");
			}
			set {
				SetColumnValue("DecisionRoleId", value);
				_decisionRole = null;
			}
		}

		/// <exclude/>
		public string DecisionRoleName {
			get {
				return GetTypedColumnValue<string>("DecisionRoleName");
			}
			set {
				SetColumnValue("DecisionRoleName", value);
				if (_decisionRole != null) {
					_decisionRole.Name = value;
				}
			}
		}

		private ContactDecisionRole _decisionRole;
		/// <summary>
		/// Role.
		/// </summary>
		public ContactDecisionRole DecisionRole {
			get {
				return _decisionRole ??
					(_decisionRole = LookupColumnEntities.GetEntity("DecisionRole") as ContactDecisionRole);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ContactCareer_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ContactCareer_Base_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("ContactCareer_Base_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("ContactCareer_Base_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("ContactCareer_Base_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("ContactCareer_Base_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("ContactCareer_Base_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("ContactCareer_Base_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ContactCareer_Base_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: ContactCareer_BaseEventsProcess

	/// <exclude/>
	public partial class ContactCareer_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : ContactCareer_Base_Terrasoft
	{

		#region Class: SynchronizeContactDataFlowElement

		/// <exclude/>
		public class SynchronizeContactDataFlowElement : SynchronizeParentEntityData
		{

			public SynchronizeContactDataFlowElement(UserConnection userConnection, ContactCareer_BaseEventsProcess<TEntity> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "SynchronizeContactData";
				IsLogging = false;
				SchemaElementUId = new Guid("a935bfc0-7d92-4b95-8a47-d894250b4598");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public ContactCareer_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ContactCareer_BaseEventsProcess";
			SchemaUId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcessContactCareerSaving;
		public ProcessFlowElement EventSubProcessContactCareerSaving {
			get {
				return _eventSubProcessContactCareerSaving ?? (_eventSubProcessContactCareerSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessContactCareerSaving",
					SchemaElementUId = new Guid("e24dec1b-8de7-4b53-a9a5-2ebfdf164d2d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageContactCareerSaving;
		public ProcessFlowElement StartMessageContactCareerSaving {
			get {
				return _startMessageContactCareerSaving ?? (_startMessageContactCareerSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageContactCareerSaving",
					SchemaElementUId = new Guid("87f5f51d-038f-464f-9f17-7e144c04ede6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptContactCareerSaving;
		public ProcessScriptTask ScriptContactCareerSaving {
			get {
				return _scriptContactCareerSaving ?? (_scriptContactCareerSaving = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptContactCareerSaving",
					SchemaElementUId = new Guid("f078ad86-fbef-46f2-b198-278c92af6e41"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptContactCareerSavingExecute,
				});
			}
		}

		private ProcessFlowElement _subProcess1;
		public ProcessFlowElement SubProcess1 {
			get {
				return _subProcess1 ?? (_subProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess1",
					SchemaElementUId = new Guid("2d0defc1-0e17-42c6-acb8-057ae0ab5774"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _contactCareerSaved;
		public ProcessFlowElement ContactCareerSaved {
			get {
				return _contactCareerSaved ?? (_contactCareerSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ContactCareerSaved",
					SchemaElementUId = new Guid("b5183f56-5771-4c53-b315-803b1645eda8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptCheckPrimary;
		public ProcessScriptTask ScriptCheckPrimary {
			get {
				return _scriptCheckPrimary ?? (_scriptCheckPrimary = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptCheckPrimary",
					SchemaElementUId = new Guid("7e64b40e-8db8-4a07-ace1-4ed900f000c0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptCheckPrimaryExecute,
				});
			}
		}

		private ProcessScriptTask _updateContactEntityScriptTask;
		public ProcessScriptTask UpdateContactEntityScriptTask {
			get {
				return _updateContactEntityScriptTask ?? (_updateContactEntityScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "UpdateContactEntityScriptTask",
					SchemaElementUId = new Guid("6c21bc07-c7bc-463c-96cb-d08c7a8eebae"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = UpdateContactEntityScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _subProcess2;
		public ProcessFlowElement SubProcess2 {
			get {
				return _subProcess2 ?? (_subProcess2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess2",
					SchemaElementUId = new Guid("d8295abf-dbd6-421a-b908-2c3caec95c07"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _contactCareerDeleted;
		public ProcessFlowElement ContactCareerDeleted {
			get {
				return _contactCareerDeleted ?? (_contactCareerDeleted = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ContactCareerDeleted",
					SchemaElementUId = new Guid("722c3d50-bb5a-42bd-9b93-540d050f81da"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _deprecatedProcessSaved;
		public ProcessFlowElement DeprecatedProcessSaved {
			get {
				return _deprecatedProcessSaved ?? (_deprecatedProcessSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "DeprecatedProcessSaved",
					SchemaElementUId = new Guid("4a666b7d-46f7-419c-bfa8-69b85a812bda"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _fakeContactCareerSaved;
		public ProcessFlowElement FakeContactCareerSaved {
			get {
				return _fakeContactCareerSaved ?? (_fakeContactCareerSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "FakeContactCareerSaved",
					SchemaElementUId = new Guid("f2536460-9fad-4756-b799-edbaaf62d8f0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptContactCareerSaved;
		public ProcessScriptTask ScriptContactCareerSaved {
			get {
				return _scriptContactCareerSaved ?? (_scriptContactCareerSaved = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptContactCareerSaved",
					SchemaElementUId = new Guid("bf2561cc-4239-42b0-bba0-ce5b94eb95ff"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptContactCareerSavedExecute,
				});
			}
		}

		private SynchronizeContactDataFlowElement _synchronizeContactData;
		public SynchronizeContactDataFlowElement SynchronizeContactData {
			get {
				return _synchronizeContactData ?? (_synchronizeContactData = new SynchronizeContactDataFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _deprecatedProcessDeleted;
		public ProcessFlowElement DeprecatedProcessDeleted {
			get {
				return _deprecatedProcessDeleted ?? (_deprecatedProcessDeleted = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "DeprecatedProcessDeleted",
					SchemaElementUId = new Guid("1d8ffbda-d43a-428a-af12-28994c07d8f0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _fakeContactCareerDeleted;
		public ProcessFlowElement FakeContactCareerDeleted {
			get {
				return _fakeContactCareerDeleted ?? (_fakeContactCareerDeleted = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "FakeContactCareerDeleted",
					SchemaElementUId = new Guid("94a628f6-1514-47cc-a31f-3d50236922fa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptContactCareerDeleted;
		public ProcessScriptTask ScriptContactCareerDeleted {
			get {
				return _scriptContactCareerDeleted ?? (_scriptContactCareerDeleted = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptContactCareerDeleted",
					SchemaElementUId = new Guid("9e24e4ea-7a4f-4f26-85e2-fe863c20c81f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptContactCareerDeletedExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcessContactCareerSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessContactCareerSaving };
			FlowElements[StartMessageContactCareerSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageContactCareerSaving };
			FlowElements[ScriptContactCareerSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptContactCareerSaving };
			FlowElements[SubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess1 };
			FlowElements[ContactCareerSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { ContactCareerSaved };
			FlowElements[ScriptCheckPrimary.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptCheckPrimary };
			FlowElements[UpdateContactEntityScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { UpdateContactEntityScriptTask };
			FlowElements[SubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess2 };
			FlowElements[ContactCareerDeleted.SchemaElementUId] = new Collection<ProcessFlowElement> { ContactCareerDeleted };
			FlowElements[DeprecatedProcessSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { DeprecatedProcessSaved };
			FlowElements[FakeContactCareerSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { FakeContactCareerSaved };
			FlowElements[ScriptContactCareerSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptContactCareerSaved };
			FlowElements[SynchronizeContactData.SchemaElementUId] = new Collection<ProcessFlowElement> { SynchronizeContactData };
			FlowElements[DeprecatedProcessDeleted.SchemaElementUId] = new Collection<ProcessFlowElement> { DeprecatedProcessDeleted };
			FlowElements[FakeContactCareerDeleted.SchemaElementUId] = new Collection<ProcessFlowElement> { FakeContactCareerDeleted };
			FlowElements[ScriptContactCareerDeleted.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptContactCareerDeleted };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcessContactCareerSaving":
						break;
					case "StartMessageContactCareerSaving":
						e.Context.QueueTasks.Enqueue("ScriptContactCareerSaving");
						break;
					case "ScriptContactCareerSaving":
						break;
					case "SubProcess1":
						break;
					case "ContactCareerSaved":
						e.Context.QueueTasks.Enqueue("ScriptCheckPrimary");
						break;
					case "ScriptCheckPrimary":
						e.Context.QueueTasks.Enqueue("UpdateContactEntityScriptTask");
						break;
					case "UpdateContactEntityScriptTask":
						break;
					case "SubProcess2":
						break;
					case "ContactCareerDeleted":
						e.Context.QueueTasks.Enqueue("UpdateContactEntityScriptTask");
						break;
					case "DeprecatedProcessSaved":
						break;
					case "FakeContactCareerSaved":
						e.Context.QueueTasks.Enqueue("ScriptContactCareerSaved");
						break;
					case "ScriptContactCareerSaved":
						e.Context.QueueTasks.Enqueue("SynchronizeContactData");
						break;
					case "SynchronizeContactData":
						break;
					case "DeprecatedProcessDeleted":
						break;
					case "FakeContactCareerDeleted":
						e.Context.QueueTasks.Enqueue("ScriptContactCareerDeleted");
						break;
					case "ScriptContactCareerDeleted":
						e.Context.QueueTasks.Enqueue("SynchronizeContactData");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessageContactCareerSaving");
			ActivatedEventElements.Add("ContactCareerSaved");
			ActivatedEventElements.Add("ContactCareerDeleted");
			ActivatedEventElements.Add("FakeContactCareerSaved");
			ActivatedEventElements.Add("FakeContactCareerDeleted");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcessContactCareerSaving":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageContactCareerSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageContactCareerSaving";
					result = StartMessageContactCareerSaving.Execute(context);
					break;
				case "ScriptContactCareerSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptContactCareerSaving";
					result = ScriptContactCareerSaving.Execute(context, ScriptContactCareerSavingExecute);
					break;
				case "SubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "ContactCareerSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "ContactCareerSaved";
					result = ContactCareerSaved.Execute(context);
					break;
				case "ScriptCheckPrimary":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptCheckPrimary";
					result = ScriptCheckPrimary.Execute(context, ScriptCheckPrimaryExecute);
					break;
				case "UpdateContactEntityScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "UpdateContactEntityScriptTask";
					result = UpdateContactEntityScriptTask.Execute(context, UpdateContactEntityScriptTaskExecute);
					break;
				case "SubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "ContactCareerDeleted":
					context.QueueTasks.Dequeue();
					context.SenderName = "ContactCareerDeleted";
					result = ContactCareerDeleted.Execute(context);
					break;
				case "DeprecatedProcessSaved":
					context.QueueTasks.Dequeue();
					break;
				case "FakeContactCareerSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "FakeContactCareerSaved";
					result = FakeContactCareerSaved.Execute(context);
					break;
				case "ScriptContactCareerSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptContactCareerSaved";
					result = ScriptContactCareerSaved.Execute(context, ScriptContactCareerSavedExecute);
					break;
				case "SynchronizeContactData":
					context.QueueTasks.Dequeue();
					context.SenderName = "SynchronizeContactData";
					result = SynchronizeContactData.Execute(context);
					break;
				case "DeprecatedProcessDeleted":
					context.QueueTasks.Dequeue();
					break;
				case "FakeContactCareerDeleted":
					context.QueueTasks.Dequeue();
					context.SenderName = "FakeContactCareerDeleted";
					result = FakeContactCareerDeleted.Execute(context);
					break;
				case "ScriptContactCareerDeleted":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptContactCareerDeleted";
					result = ScriptContactCareerDeleted.Execute(context, ScriptContactCareerDeletedExecute);
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

		public virtual bool ScriptContactCareerSavingExecute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool ScriptCheckPrimaryExecute(ProcessExecutingContext context) {
			CheckPrimary(context);
			return true;
		}

		public virtual bool UpdateContactEntityScriptTaskExecute(ProcessExecutingContext context) {
			UpdateContactEntity(context);
			return true;
		}

		public virtual bool ScriptContactCareerSavedExecute(ProcessExecutingContext context) {
			OnContactCareerSaved(context);
			return true;
		}

		public virtual bool ScriptContactCareerDeletedExecute(ProcessExecutingContext context) {
			OnContactCareerDeleted(context);
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ContactCareer_Base_TerrasoftSaving":
							if (ActivatedEventElements.Contains("StartMessageContactCareerSaving")) {
							context.QueueTasks.Enqueue("StartMessageContactCareerSaving");
						}
						break;
					case "ContactCareer_Base_TerrasoftSaved":
							if (ActivatedEventElements.Contains("ContactCareerSaved")) {
							context.QueueTasks.Enqueue("ContactCareerSaved");
						}
						break;
					case "ContactCareer_Base_TerrasoftDeleted":
							if (ActivatedEventElements.Contains("ContactCareerDeleted")) {
							context.QueueTasks.Enqueue("ContactCareerDeleted");
						}
						break;
					case "FakeContactCareerSaved":
							if (ActivatedEventElements.Contains("FakeContactCareerSaved")) {
							context.QueueTasks.Enqueue("FakeContactCareerSaved");
						}
						break;
					case "FakeContactCareerDeleted":
							if (ActivatedEventElements.Contains("FakeContactCareerDeleted")) {
							context.QueueTasks.Enqueue("FakeContactCareerDeleted");
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

	#region Class: ContactCareer_BaseEventsProcess

	/// <exclude/>
	public class ContactCareer_BaseEventsProcess : ContactCareer_BaseEventsProcess<ContactCareer_Base_Terrasoft>
	{

		public ContactCareer_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ContactCareer_BaseEventsProcess

	public partial class ContactCareer_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void CheckPrimary(ProcessExecutingContext context) {
			if (Entity.Primary) {
				var update = new Update(UserConnection, "ContactCareer")
					.Set("Primary", Column.Parameter(false))
					.Where("ContactId").IsEqual(Column.Parameter(Entity.GetTypedColumnValue<Guid>("ContactId")))
					.And("Id").IsNotEqual(Column.Parameter(Entity.PrimaryColumnValue)) as Update;
				update.Execute();
			}
			if (Entity.Primary && Entity.Current) {
				return;
			}
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, "ContactCareer");
			var contactPrimaryColumnValueName = entitySchemaQuery.AddColumn("Contact.Id").Name;
			entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "Contact",
				Entity.GetTypedColumnValue<Guid>("ContactId")));
			entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "Primary", true));
			var entities = entitySchemaQuery.GetEntityCollection(UserConnection);
			if (entities.Count == 0) {
				var contactSchema = entitySchemaManager.GetInstanceByName("Contact");
				var contactEntity = contactSchema.CreateEntity(UserConnection);
				if (contactEntity.FetchFromDB(Entity.GetTypedColumnValue<Guid>("ContactId"))){
					contactEntity.SetColumnValue("AccountId", null);
					contactEntity.SetColumnValue("DepartmentId", null);
					contactEntity.SetColumnValue("JobId", null);
					contactEntity.SetColumnValue("JobTitle", String.Empty);
					contactEntity.SetColumnValue("DecisionRoleId", null);
					contactEntity.Save();
				}
			}
			return;
		}

		public virtual void OnContactCareerSaved(ProcessExecutingContext context) {
			var conditionMappingColumns = new System.Collections.Generic.Dictionary<
			Guid, System.Collections.Generic.Dictionary<
			Guid, object>>();
			var mappingColumns = new System.Collections.Generic.Dictionary<
			Guid, Guid>();
			var defaultValues = new System.Collections.Generic.Dictionary<
			Guid, object>();
			
			//--------------- Entity Schema Columns UId -------------------------------
			var contactCareerJobColumnUId = new Guid("bf823e82-f89d-4345-b839-c429dcb2baac");
			var contactCareerJobTitleColumnUId = new Guid("5439cefd-5021-4446-957b-f35eebe76b40");
			var contactCareerDepartmentColumnUId = new Guid("96d86ec7-b8fd-4288-8cc4-c5d6ca4fe46d");
			var contactCareerAccountColumnUId = new Guid("8996b0d8-c0d9-4da7-b130-7917fa48b854");
			var contactCareerPrimaryColumnUId = new Guid("131fa275-a32c-4af9-92f0-cfedcad3679c");
			var contactCareerCurrentColumnUId = new Guid("e370b11e-e44a-4ccb-90ed-9f0f2a455adb");
			var contactCareerDecisionRoleColumnUId = new Guid("6324d7f3-fd46-4046-b9c3-76844a3e88a6");
			
			var contactJobColumnUId = new Guid("344436e4-9d6b-4a30-936f-f8ea45f2adb4");
			var contactJobTitleColumnUId = new Guid("8b680ac7-e46c-466c-b630-e5cb4da13a55");
			var contactDepartmentColumnUId = new Guid("94cb8750-ad6f-4e80-b553-7d9e194a856e");
			var contactAccountColumnUId = new Guid("5c6ca10e-1180-4c1e-8a50-55a72ff9bdd4");
			var contactDecisionRoleColumnUId = new Guid("f70c762a-1038-49a7-a3e8-f24fb8cfdeef");
			
			//--------------- Condition Mapping Columns ----------------
			var primaryJobCondition = new System.Collections.Generic.Dictionary<
			Guid, object>();
			primaryJobCondition.Add(contactCareerPrimaryColumnUId, true);
			primaryJobCondition.Add(contactCareerCurrentColumnUId, true);
			conditionMappingColumns.Add(contactJobColumnUId, primaryJobCondition);
			conditionMappingColumns.Add(contactJobTitleColumnUId, primaryJobCondition);
			conditionMappingColumns.Add(contactDepartmentColumnUId, primaryJobCondition);
			conditionMappingColumns.Add(contactAccountColumnUId, primaryJobCondition);
			conditionMappingColumns.Add(contactDecisionRoleColumnUId, primaryJobCondition);
			
			//--------------- Mapping Columns ----------------
			mappingColumns.Add(contactJobColumnUId, contactCareerJobColumnUId);
			mappingColumns.Add(contactJobTitleColumnUId, contactCareerJobTitleColumnUId);
			mappingColumns.Add(contactDepartmentColumnUId, contactCareerDepartmentColumnUId);
			mappingColumns.Add(contactAccountColumnUId, contactCareerAccountColumnUId);
			mappingColumns.Add(contactDecisionRoleColumnUId, contactCareerDecisionRoleColumnUId);
			
			var entity = context.Process.GetPropertyValue("Entity") as Terrasoft.Core.Entities.Entity;
			var entitySchema = entity.Schema;
			SynchronizeContactData.ParentEntityColumnUId = entitySchema.Columns.GetByName("Contact").UId;
			SynchronizeContactData.ConditionMappingColumns = conditionMappingColumns;
			SynchronizeContactData.MappingColumns = mappingColumns;
			SynchronizeContactData.DefaultValues = defaultValues;
			SynchronizeContactData.DeleteChild = false;
			
			return;
		}

		public virtual void OnContactCareerDeleted(ProcessExecutingContext context) {
			var conditionMappingColumns = new System.Collections.Generic.Dictionary<
			Guid, System.Collections.Generic.Dictionary<
			Guid, object>>();
			var mappingColumns = new System.Collections.Generic.Dictionary<
			Guid, Guid>();
			var defaultValues = new System.Collections.Generic.Dictionary<
			Guid, object>();
			
			//--------------- Entity Schema Columns UId -------------------------------
			var contactCareerJobColumnUId = new Guid("bf823e82-f89d-4345-b839-c429dcb2baac");
			var contactCareerJobTitleColumnUId = new Guid("5439cefd-5021-4446-957b-f35eebe76b40");
			var contactCareerDepartmentColumnUId = new Guid("96d86ec7-b8fd-4288-8cc4-c5d6ca4fe46d");
			var contactCareerAccountColumnUId = new Guid("8996b0d8-c0d9-4da7-b130-7917fa48b854");
			var contactCareerPrimaryColumnUId = new Guid("131fa275-a32c-4af9-92f0-cfedcad3679c");
			var contactCareerCurrentColumnUId = new Guid("e370b11e-e44a-4ccb-90ed-9f0f2a455adb");
			
			var contactJobColumnUId = new Guid("344436e4-9d6b-4a30-936f-f8ea45f2adb4");
			var contactJobTitleColumnUId = new Guid("8b680ac7-e46c-466c-b630-e5cb4da13a55");
			var contactDepartmentColumnUId = new Guid("94cb8750-ad6f-4e80-b553-7d9e194a856e");
			var contactAccountColumnUId = new Guid("5c6ca10e-1180-4c1e-8a50-55a72ff9bdd4");
			var decisionRoleColumnUId = new Guid("f70c762a-1038-49a7-a3e8-f24fb8cfdeef");
			
			//--------------- Condition Mapping Columns ----------------
			var primaryAddressCondition = new System.Collections.Generic.Dictionary<
			Guid, object>();
			primaryAddressCondition.Add(contactCareerPrimaryColumnUId, true);
			primaryAddressCondition.Add(contactCareerCurrentColumnUId, true);
			conditionMappingColumns.Add(contactJobColumnUId, primaryAddressCondition);
			conditionMappingColumns.Add(contactJobTitleColumnUId, primaryAddressCondition);
			conditionMappingColumns.Add(contactDepartmentColumnUId, primaryAddressCondition);
			conditionMappingColumns.Add(contactAccountColumnUId, primaryAddressCondition);
			conditionMappingColumns.Add(decisionRoleColumnUId, primaryAddressCondition);
			
			//--------------- Mapping Columns ----------------
			mappingColumns.Add(contactJobColumnUId, contactCareerJobColumnUId);
			mappingColumns.Add(contactJobTitleColumnUId, contactCareerJobTitleColumnUId);
			mappingColumns.Add(contactDepartmentColumnUId, contactCareerDepartmentColumnUId);
			mappingColumns.Add(contactAccountColumnUId, contactCareerAccountColumnUId);
			mappingColumns.Add(decisionRoleColumnUId, Guid.Empty);
			
			var entity = context.Process.GetPropertyValue("Entity") as Terrasoft.Core.Entities.Entity;
			var entitySchema = entity.Schema;
			SynchronizeContactData.ParentEntityColumnUId = new Guid("d6628cf3-ba29-472e-b0f2-9b51f693ef2a");
			SynchronizeContactData.ConditionMappingColumns = conditionMappingColumns;
			SynchronizeContactData.MappingColumns = mappingColumns;
			SynchronizeContactData.DefaultValues = defaultValues;
			SynchronizeContactData.DeleteChild = true;
			
			return;
		}

		public virtual void UpdateContactEntity(ProcessExecutingContext context) {
			var isPrimary = Entity.GetTypedColumnValue<bool>("Primary");
			if (isPrimary) {
				var contactId = Entity.GetTypedColumnValue<Guid>("ContactId");
				var contactSchema = UserConnection.EntitySchemaManager.GetInstanceByName("Contact");
				var contactEntity = contactSchema.CreateEntity(UserConnection);
				if (contactEntity.FetchFromDB(contactId)) {
					var jobId = Entity.GetTypedColumnValue<Guid>("JobId");
					var jobTitle = Entity.GetTypedColumnValue<string>("JobTitle");
					var departmentId = Entity.GetTypedColumnValue<Guid>("DepartmentId");
					var accountId = Entity.GetTypedColumnValue<Guid>("AccountId");
					var decisionRoleId = Entity.GetTypedColumnValue<Guid>("DecisionRoleId");
					var contactJobId = contactEntity.GetTypedColumnValue<Guid>("JobId");
					var contactJobTitle = contactEntity.GetTypedColumnValue<string>("JobTitle");
					var contactDepartmentId = contactEntity.GetTypedColumnValue<Guid>("DepartmentId");
					var contactAccountId = contactEntity.GetTypedColumnValue<Guid>("AccountId");
					var contactDecisionRoleId = contactEntity.GetTypedColumnValue<Guid>("DecisionRoleId");
					if (!Entity.IsInDeleted && jobId == contactJobId && jobTitle == contactJobTitle && 
						departmentId == contactDepartmentId && accountId == contactAccountId &&
						decisionRoleId == contactDecisionRoleId ) {
						return;
					}
					if (jobId.IsEmpty() || Entity.IsInDeleted) {
						contactEntity.SetColumnValue("JobId", null);
					} else {
						contactEntity.SetColumnValue("JobId", jobId);
					}
					if (Entity.IsInDeleted) {
						contactEntity.SetColumnValue("JobTitle", string.Empty);
					} else {
						contactEntity.SetColumnValue("JobTitle", jobTitle);
					}
					if (departmentId.IsEmpty() || Entity.IsInDeleted) {
						contactEntity.SetColumnValue("DepartmentId", null);
					} else {
						contactEntity.SetColumnValue("DepartmentId", departmentId);
					}
					if (accountId.IsEmpty() || Entity.IsInDeleted) {
						contactEntity.SetColumnValue("AccountId", null);
					} else {
						contactEntity.SetColumnValue("AccountId", accountId);
					}
					if (decisionRoleId.IsEmpty() || Entity.IsInDeleted) {
						contactEntity.SetColumnValue("DecisionRoleId", null);
					} else {
						contactEntity.SetColumnValue("DecisionRoleId", decisionRoleId);
					}
					contactEntity.Save();
				}
			}
		}

		#endregion

	}

	#endregion

	#region Class: ContactCareer_Base_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class ContactCareer_Base_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public ContactCareer_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ContactCareer_Base_TerrasoftEventsProcessSchema(ContactCareer_Base_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ContactCareer_BaseEventsProcess";
			UId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270");
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

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected virtual void InitializeSynchronizeContactDataParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("14b5c6eb-0f44-4911-8f63-0ae05934f1a7"),
				ContainerUId = new Guid("a935bfc0-7d92-4b95-8a47-d894250b4598"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3e6374da-0124-4817-bb7c-34b2b4ba4816"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3e6374da-0124-4817-bb7c-34b2b4ba4816"),
				Name = @"ParentEntityColumnUId",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("21d6a315-2966-4dd3-bae6-904671f28ae1"),
				ContainerUId = new Guid("a935bfc0-7d92-4b95-8a47-d894250b4598"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3e6374da-0124-4817-bb7c-34b2b4ba4816"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3e6374da-0124-4817-bb7c-34b2b4ba4816"),
				Name = @"ConditionMappingColumns",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("187541b2-c725-4e24-ac38-14f5ace7c8f0"),
				ContainerUId = new Guid("a935bfc0-7d92-4b95-8a47-d894250b4598"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3e6374da-0124-4817-bb7c-34b2b4ba4816"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3e6374da-0124-4817-bb7c-34b2b4ba4816"),
				Name = @"MappingColumns",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("742c77fb-cc7a-438d-bacb-982b29575fd5"),
				ContainerUId = new Guid("a935bfc0-7d92-4b95-8a47-d894250b4598"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3e6374da-0124-4817-bb7c-34b2b4ba4816"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3e6374da-0124-4817-bb7c-34b2b4ba4816"),
				Name = @"DefaultValues",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("e9cb1f44-afeb-45c7-9788-44b05660fbac"),
				ContainerUId = new Guid("a935bfc0-7d92-4b95-8a47-d894250b4598"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3e6374da-0124-4817-bb7c-34b2b4ba4816"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3e6374da-0124-4817-bb7c-34b2b4ba4816"),
				Name = @"DeleteChild",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet395 = CreateLaneSet395LaneSet();
			LaneSets.Add(schemaLaneSet395);
			ProcessSchemaLane schemaLane1194 = CreateLane1194Lane();
			schemaLaneSet395.Lanes.Add(schemaLane1194);
			ProcessSchemaEventSubProcess eventsubprocesscontactcareersaving = CreateEventSubProcessContactCareerSavingEventSubProcess();
			FlowElements.Add(eventsubprocesscontactcareersaving);
			ProcessSchemaEventSubProcess subprocess1 = CreateSubProcess1EventSubProcess();
			FlowElements.Add(subprocess1);
			ProcessSchemaEventSubProcess subprocess2 = CreateSubProcess2EventSubProcess();
			FlowElements.Add(subprocess2);
			ProcessSchemaEventSubProcess deprecatedprocesssaved = CreateDeprecatedProcessSavedEventSubProcess();
			FlowElements.Add(deprecatedprocesssaved);
			ProcessSchemaEventSubProcess deprecatedprocessdeleted = CreateDeprecatedProcessDeletedEventSubProcess();
			FlowElements.Add(deprecatedprocessdeleted);
			ProcessSchemaStartMessageEvent startmessagecontactcareersaving = CreateStartMessageContactCareerSavingStartMessageEvent();
			eventsubprocesscontactcareersaving.FlowElements.Add(startmessagecontactcareersaving);
			ProcessSchemaScriptTask scriptcontactcareersaving = CreateScriptContactCareerSavingScriptTask();
			eventsubprocesscontactcareersaving.FlowElements.Add(scriptcontactcareersaving);
			ProcessSchemaStartMessageEvent contactcareersaved = CreateContactCareerSavedStartMessageEvent();
			subprocess1.FlowElements.Add(contactcareersaved);
			ProcessSchemaScriptTask scriptcheckprimary = CreateScriptCheckPrimaryScriptTask();
			subprocess1.FlowElements.Add(scriptcheckprimary);
			ProcessSchemaScriptTask updatecontactentityscripttask = CreateUpdateContactEntityScriptTaskScriptTask();
			subprocess1.FlowElements.Add(updatecontactentityscripttask);
			ProcessSchemaStartMessageEvent contactcareerdeleted = CreateContactCareerDeletedStartMessageEvent();
			subprocess2.FlowElements.Add(contactcareerdeleted);
			ProcessSchemaStartMessageEvent fakecontactcareersaved = CreateFakeContactCareerSavedStartMessageEvent();
			deprecatedprocesssaved.FlowElements.Add(fakecontactcareersaved);
			ProcessSchemaScriptTask scriptcontactcareersaved = CreateScriptContactCareerSavedScriptTask();
			deprecatedprocesssaved.FlowElements.Add(scriptcontactcareersaved);
			ProcessSchemaUserTask synchronizecontactdata = CreateSynchronizeContactDataUserTask();
			deprecatedprocesssaved.FlowElements.Add(synchronizecontactdata);
			ProcessSchemaStartMessageEvent fakecontactcareerdeleted = CreateFakeContactCareerDeletedStartMessageEvent();
			deprecatedprocessdeleted.FlowElements.Add(fakecontactcareerdeleted);
			ProcessSchemaScriptTask scriptcontactcareerdeleted = CreateScriptContactCareerDeletedScriptTask();
			deprecatedprocessdeleted.FlowElements.Add(scriptcontactcareerdeleted);
			FlowElements.Add(CreateSequenceFlow6812SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6815SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6816SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6812SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6812",
				UId = new Guid("e3596de5-f3a1-4e8d-9043-8af4247f8ba6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				CurveCenterPosition = new Point(363, 128),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bf2561cc-4239-42b0-bba0-ce5b94eb95ff"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a935bfc0-7d92-4b95-8a47-d894250b4598"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6815SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6815",
				UId = new Guid("0be34804-91a2-43c3-b871-d3b29b03fd69"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				CurveCenterPosition = new Point(196, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("87f5f51d-038f-464f-9f17-7e144c04ede6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f078ad86-fbef-46f2-b198-278c92af6e41"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(155, 84));
			schemaFlow.PolylinePointPositions.Add(new Point(155, 85));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6816SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6816",
				UId = new Guid("14ba6ecc-397c-42d8-b230-6be41e9d9dd1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				CurveCenterPosition = new Point(252, 126),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b5183f56-5771-4c53-b315-803b1645eda8"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7e64b40e-8db8-4a07-ace1-4ed900f000c0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("56fb6e20-c79e-4e33-9639-693a4369ec11"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("94a628f6-1514-47cc-a31f-3d50236922fa"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9e24e4ea-7a4f-4f26-85e2-fe863c20c81f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(965, 391));
			schemaFlow.PolylinePointPositions.Add(new Point(965, 327));
			schemaFlow.PolylinePointPositions.Add(new Point(914, 327));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("d4f1b28a-3dc6-4fdb-b3e7-0a9509b98172"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f2536460-9fad-4756-b799-edbaaf62d8f0"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bf2561cc-4239-42b0-bba0-ce5b94eb95ff"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("58ba8118-cadc-4960-bd2e-ad21c366b433"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9e24e4ea-7a4f-4f26-85e2-fe863c20c81f"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a935bfc0-7d92-4b95-8a47-d894250b4598"),
				TargetSequenceFlowPointLocalPosition = new Point(1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(979, 269));
			schemaFlow.PolylinePointPositions.Add(new Point(979, 92));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("4dcdb828-72ee-4cf0-af18-ece370e00691"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7e64b40e-8db8-4a07-ace1-4ed900f000c0"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6c21bc07-c7bc-463c-96cb-d08c7a8eebae"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("e28fab7b-af1e-4a8e-a76e-3e9d20271bac"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("722c3d50-bb5a-42bd-9b93-540d050f81da"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6c21bc07-c7bc-463c-96cb-d08c7a8eebae"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(384, 516));
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet395LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet395 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("27b0e5fa-c306-47d9-8670-86a3426a0161"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				Name = @"LaneSet395",
				Position = new Point(5, 5),
				Size = new Size(746, 177),
				UseBackgroundMode = false
			};
			return schemaLaneSet395;
		}

		protected virtual ProcessSchemaLane CreateLane1194Lane() {
			ProcessSchemaLane schemaLane1194 = new ProcessSchemaLane(this) {
				UId = new Guid("6773ab30-e1ce-4ac3-8a12-2edbe73864d2"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("27b0e5fa-c306-47d9-8670-86a3426a0161"),
				CreatedInOwnerSchemaUId = new Guid("a0a1d0c3-6267-4584-acbd-fd53660798ce"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				Name = @"Lane1194",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(717, 177),
				UseBackgroundMode = false
			};
			return schemaLane1194;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessContactCareerSavingEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessContactCareerSaving = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e24dec1b-8de7-4b53-a9a5-2ebfdf164d2d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6773ab30-e1ce-4ac3-8a12-2edbe73864d2"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				Name = @"EventSubProcessContactCareerSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(42, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(287, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessContactCareerSaving;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageContactCareerSavingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("87f5f51d-038f-464f-9f17-7e144c04ede6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e24dec1b-8de7-4b53-a9a5-2ebfdf164d2d"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ContactCareerSaving",
				ModifiedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				Name = @"StartMessageContactCareerSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(37, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptContactCareerSavingScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f078ad86-fbef-46f2-b198-278c92af6e41"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e24dec1b-8de7-4b53-a9a5-2ebfdf164d2d"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				Name = @"ScriptContactCareerSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(162, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2d0defc1-0e17-42c6-acb8-057ae0ab5774"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6773ab30-e1ce-4ac3-8a12-2edbe73864d2"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				Name = @"SubProcess1",
				Position = new Point(106, 212),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(557, 203),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateContactCareerSavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b5183f56-5771-4c53-b315-803b1645eda8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2d0defc1-0e17-42c6-acb8-057ae0ab5774"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ContactCareerSaved",
				ModifiedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				Name = @"ContactCareerSaved",
				Position = new Point(22, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptCheckPrimaryScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7e64b40e-8db8-4a07-ace1-4ed900f000c0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2d0defc1-0e17-42c6-acb8-057ae0ab5774"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				Name = @"ScriptCheckPrimary",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(92, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,206,72,77,206,14,40,202,204,77,44,170,212,72,206,207,43,73,173,40,209,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,150,19,156,129,36,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateUpdateContactEntityScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6c21bc07-c7bc-463c-96cb-d08c7a8eebae"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2d0defc1-0e17-42c6-acb8-057ae0ab5774"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				Name = @"UpdateContactEntityScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(244, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,72,73,44,73,117,206,207,43,73,76,46,113,205,43,201,44,169,212,72,6,242,82,43,74,52,173,185,138,82,75,74,139,242,20,74,138,74,83,173,1,186,160,64,76,42,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("d8295abf-dbd6-421a-b908-2c3caec95c07"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6773ab30-e1ce-4ac3-8a12-2edbe73864d2"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				Name = @"SubProcess2",
				Position = new Point(106, 439),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(364, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateContactCareerDeletedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("722c3d50-bb5a-42bd-9b93-540d050f81da"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d8295abf-dbd6-421a-b908-2c3caec95c07"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ContactCareerDeleted",
				ModifiedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				Name = @"ContactCareerDeleted",
				Position = new Point(22, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateDeprecatedProcessSavedEventSubProcess() {
			ProcessSchemaEventSubProcess schemaDeprecatedProcessSaved = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("4a666b7d-46f7-419c-bfa8-69b85a812bda"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6773ab30-e1ce-4ac3-8a12-2edbe73864d2"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				Name = @"DeprecatedProcessSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(398, 20),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(722, 141),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaDeprecatedProcessSaved;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateFakeContactCareerSavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f2536460-9fad-4756-b799-edbaaf62d8f0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4a666b7d-46f7-419c-bfa8-69b85a812bda"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"FakeContactCareerSaved",
				ModifiedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				Name = @"FakeContactCareerSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(33, 59),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptContactCareerSavedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("bf2561cc-4239-42b0-bba0-ce5b94eb95ff"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4a666b7d-46f7-419c-bfa8-69b85a812bda"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				Name = @"ScriptContactCareerSaved",
				Position = new Point(162, 45),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,115,206,207,43,73,76,46,113,78,44,74,77,45,10,78,44,75,77,209,72,6,10,165,86,148,104,90,115,21,165,150,148,22,229,41,148,20,149,166,90,3,0,155,60,182,7,43,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateSynchronizeContactDataUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("a935bfc0-7d92-4b95-8a47-d894250b4598"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4a666b7d-46f7-419c-bfa8-69b85a812bda"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("3e6374da-0124-4817-bb7c-34b2b4ba4816"),
				ModifiedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				Name = @"SynchronizeContactData",
				Position = new Point(473, 45),
				SchemaUId = new Guid("3e6374da-0124-4817-bb7c-34b2b4ba4816"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeSynchronizeContactDataParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateDeprecatedProcessDeletedEventSubProcess() {
			ProcessSchemaEventSubProcess schemaDeprecatedProcessDeleted = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1d8ffbda-d43a-428a-af12-28994c07d8f0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6773ab30-e1ce-4ac3-8a12-2edbe73864d2"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				Name = @"DeprecatedProcessDeleted",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(724, 212),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(396, 228),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaDeprecatedProcessDeleted;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateFakeContactCareerDeletedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("94a628f6-1514-47cc-a31f-3d50236922fa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1d8ffbda-d43a-428a-af12-28994c07d8f0"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"FakeContactCareerDeleted",
				ModifiedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				Name = @"FakeContactCareerDeleted",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(184, 166),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptContactCareerDeletedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9e24e4ea-7a4f-4f26-85e2-fe863c20c81f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1d8ffbda-d43a-428a-af12-28994c07d8f0"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				Name = @"ScriptContactCareerDeleted",
				Position = new Point(156, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,115,206,207,43,73,76,46,113,78,44,74,77,45,114,73,205,73,45,73,77,209,72,6,10,166,86,148,104,90,115,21,165,150,148,22,229,41,148,20,149,166,90,3,0,41,46,232,72,45,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateCheckPrimaryMethod());
			Methods.Add(CreateOnContactCareerSavedMethod());
			Methods.Add(CreateOnContactCareerDeletedMethod());
			Methods.Add(CreateUpdateContactEntityMethod());
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

		protected virtual SchemaMethod CreateCheckPrimaryMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("07b60ef0-6ed7-4cc3-b078-4281bc3c254a"),
				Name = "CheckPrimary",
				CreatedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c7efde9b-dd65-4cc8-81c6-e07d3053c0b0"),
				Name = "context",
				CreatedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				ModifiedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,84,77,111,219,48,12,61,187,64,255,131,224,67,33,3,129,176,123,151,1,169,235,20,25,176,162,91,250,113,214,108,182,17,32,203,153,76,117,51,134,254,247,81,150,154,196,113,208,53,151,30,69,241,61,146,239,81,82,143,140,23,6,21,118,226,198,170,90,218,46,99,127,79,79,146,103,105,153,91,87,18,129,77,153,129,223,236,174,63,240,187,22,108,222,24,3,37,170,198,76,88,74,7,148,37,230,210,2,216,52,35,104,34,150,128,60,141,116,233,132,229,141,118,181,17,55,210,202,26,16,44,127,148,186,133,44,228,62,172,192,2,127,165,89,84,105,38,22,109,241,203,73,205,71,184,216,232,21,224,109,183,134,42,220,223,75,237,224,243,149,83,213,151,1,77,228,159,153,138,167,145,246,186,193,183,153,99,207,59,196,89,198,100,27,135,63,39,194,160,137,40,254,64,233,72,142,140,98,47,167,39,106,164,34,59,59,99,49,146,59,107,193,96,208,213,2,58,107,2,202,107,12,125,206,178,92,65,45,191,73,35,159,192,146,224,67,149,69,49,78,58,31,195,191,59,160,186,193,173,98,63,206,15,20,26,187,23,89,203,16,29,171,113,77,114,81,133,81,85,49,171,162,27,27,11,68,175,185,7,16,233,24,48,87,154,116,111,61,144,143,111,115,11,164,114,200,121,80,184,218,24,213,242,16,204,155,122,45,173,106,27,227,55,65,244,174,110,199,73,39,164,244,145,203,242,129,93,110,95,6,90,191,97,187,94,42,104,15,10,76,99,132,129,104,14,29,214,98,239,45,122,26,191,135,175,52,34,111,156,65,54,157,178,79,219,39,29,157,13,204,123,133,226,86,248,82,11,211,162,52,37,92,116,222,192,141,82,253,130,236,242,132,150,136,103,192,27,133,9,151,7,186,76,124,155,3,6,49,7,44,87,115,219,212,151,23,199,190,114,63,90,50,100,163,255,103,7,197,211,89,89,122,45,40,127,194,140,211,186,111,226,63,152,75,32,235,176,134,35,97,95,155,159,199,230,223,42,212,64,144,37,90,101,158,68,81,175,177,123,95,135,165,106,73,210,31,141,134,183,107,202,231,240,83,37,47,253,191,19,255,160,127,109,101,255,22,251,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnContactCareerSavedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9843bb7e-8b8a-4834-9d5b-87ccc4812f5c"),
				Name = "OnContactCareerSaved",
				CreatedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d185c734-59be-4a03-b071-9895529ea6b1"),
				Name = "context",
				CreatedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				ModifiedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,150,93,111,219,54,20,134,239,243,43,4,95,37,64,168,74,226,135,72,164,41,208,57,69,177,1,27,130,165,219,61,63,14,27,13,150,100,208,116,59,239,215,239,200,178,3,71,149,228,108,246,133,32,201,60,143,14,207,251,242,144,223,116,72,108,219,184,42,86,109,243,171,94,175,171,230,235,178,93,109,235,102,147,220,39,13,124,79,158,118,155,8,117,138,47,87,96,187,81,155,244,51,52,16,42,155,62,84,251,23,58,236,222,95,125,222,86,238,246,191,13,110,205,95,56,232,195,135,235,155,187,171,111,152,71,125,241,231,187,235,11,206,129,215,219,85,252,83,175,182,240,191,104,135,252,58,222,213,187,119,228,245,47,249,212,196,42,238,146,39,251,12,181,78,142,73,255,241,179,75,200,252,111,159,28,214,60,106,27,151,58,0,132,95,90,211,199,119,209,125,162,93,6,215,11,227,101,65,65,22,196,75,229,8,163,140,19,35,169,34,150,21,202,89,83,24,173,237,226,48,221,33,241,75,21,87,48,142,229,140,42,11,222,17,158,21,57,97,140,9,162,120,105,136,167,28,192,64,41,12,203,70,177,15,176,214,33,214,208,196,113,176,18,78,10,176,37,102,137,116,86,72,73,164,181,140,88,238,132,213,204,3,19,110,20,252,209,218,118,59,69,149,74,9,147,57,73,108,230,20,97,78,35,63,167,25,41,85,94,122,205,164,145,156,141,82,31,67,85,163,158,227,212,156,230,94,23,37,39,154,22,150,48,237,21,81,133,207,136,245,224,172,118,84,148,106,188,182,203,109,8,147,21,0,90,102,38,207,129,0,99,154,48,107,13,81,25,56,162,124,230,11,205,56,215,206,76,148,214,86,27,244,223,239,237,148,106,130,22,204,149,158,18,239,80,48,150,225,197,40,75,73,41,36,126,11,109,34,181,232,208,167,236,73,103,81,84,157,10,96,68,57,97,112,246,88,78,69,133,71,163,1,102,137,169,58,51,172,233,188,167,164,17,50,211,40,61,106,140,229,20,120,49,2,169,192,173,65,201,114,170,57,31,0,207,186,137,89,35,75,158,17,237,48,51,6,50,35,134,115,156,176,83,144,43,166,37,23,48,64,206,250,136,91,52,97,158,1,201,115,68,49,139,42,73,141,120,20,165,44,188,87,198,185,225,156,207,171,226,203,204,150,162,208,36,207,168,36,76,161,57,59,45,136,47,152,55,210,122,7,224,23,227,29,100,121,236,187,201,161,241,190,116,145,209,150,177,238,221,188,151,244,24,120,89,87,27,33,166,31,157,187,158,93,68,183,73,12,91,120,107,244,112,177,188,68,79,108,58,167,132,83,243,222,142,77,255,205,152,215,190,189,128,53,98,217,11,104,67,183,94,148,216,136,81,167,120,35,94,60,235,192,250,141,50,77,110,108,248,221,89,198,80,163,249,253,108,150,54,170,210,185,141,108,150,248,163,82,179,219,215,153,236,70,165,58,191,27,28,123,59,244,39,143,251,125,8,252,29,211,199,208,90,216,116,139,62,226,237,26,66,220,237,79,61,215,139,254,144,178,184,73,244,38,249,2,33,232,77,235,35,54,138,0,233,254,175,10,54,253,205,238,238,4,125,56,211,220,31,30,211,254,249,238,234,105,215,216,231,208,54,213,63,152,84,63,23,29,117,250,168,187,37,222,99,78,155,228,41,44,61,22,2,115,252,105,247,155,174,49,185,3,99,113,147,226,248,73,250,114,242,116,58,177,44,38,73,63,0,234,183,197,61,12,14,146,175,14,150,51,81,43,136,176,124,174,86,93,45,188,94,109,0,245,11,16,183,161,185,251,23,210,173,58,11,119,11,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnContactCareerDeletedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f51239b7-f00d-4edc-b081-7c62b9af0621"),
				Name = "OnContactCareerDeleted",
				CreatedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4fa156d5-6aef-403d-a6e9-bc548d5b015e"),
				Name = "context",
				CreatedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				ModifiedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,150,91,111,211,48,20,199,223,247,41,162,62,13,105,14,73,124,137,173,49,36,212,33,4,18,210,196,6,239,190,28,179,160,38,169,28,23,40,159,158,147,166,27,91,73,178,91,31,162,36,141,127,62,62,255,115,251,169,67,98,219,198,85,177,106,155,207,122,189,174,154,239,203,118,181,169,155,46,57,75,26,248,149,92,110,187,8,117,138,47,87,96,251,175,186,244,3,52,16,42,155,158,87,187,23,58,108,223,28,125,216,84,238,228,105,31,183,230,7,126,244,246,237,241,171,211,163,159,104,71,253,226,237,251,235,45,206,129,215,155,85,252,166,87,27,120,22,109,111,95,207,59,122,253,154,220,255,37,239,155,88,197,109,114,105,175,161,214,201,141,209,95,63,186,132,204,255,118,198,161,207,163,182,113,169,3,64,248,212,154,97,125,191,122,48,180,183,224,120,97,188,44,40,200,130,120,169,28,97,148,113,98,36,85,196,178,66,57,107,10,163,181,93,236,143,123,72,188,170,226,10,198,177,156,81,101,193,59,194,179,34,39,140,49,65,20,47,13,241,148,3,24,40,133,97,217,40,246,28,214,58,196,26,154,56,14,86,194,73,1,182,68,43,145,206,10,41,137,180,150,17,203,157,176,154,121,96,194,141,130,223,89,219,110,166,168,82,41,97,50,39,137,205,156,34,204,105,228,231,52,35,165,202,75,175,153,52,146,179,81,234,69,168,106,212,115,156,154,211,220,235,162,228,68,211,194,18,166,189,34,170,240,25,177,30,156,213,142,138,82,141,251,118,185,9,97,210,3,64,203,204,228,57,16,96,76,19,102,173,33,42,3,71,148,207,124,161,25,231,218,153,158,122,23,59,41,63,69,105,168,0,70,148,19,6,77,196,51,43,42,60,70,3,32,10,121,206,28,30,124,94,120,105,132,204,52,234,131,66,224,153,5,94,140,64,42,112,107,208,175,57,213,156,31,0,31,148,156,89,35,75,158,17,237,208,50,6,50,35,134,115,74,74,167,32,87,76,75,46,224,0,57,43,54,183,24,41,121,6,36,207,17,197,44,186,82,106,196,163,231,202,194,123,101,156,187,61,179,3,91,117,152,179,95,218,169,3,251,50,179,165,40,52,201,51,42,9,83,24,58,26,19,138,248,130,121,35,173,119,0,126,49,158,223,203,155,170,152,236,203,226,109,142,143,38,244,122,136,181,119,206,5,232,186,127,139,95,86,119,38,168,41,190,56,158,13,245,147,36,134,13,60,133,112,24,214,183,132,137,246,112,151,112,55,130,79,166,92,241,104,212,253,0,126,33,111,36,126,95,72,60,12,223,231,226,70,163,119,14,54,18,164,15,134,102,253,72,205,38,251,17,238,59,203,56,20,107,190,13,205,210,70,165,122,168,255,204,18,255,151,106,182,235,140,179,38,116,234,115,53,125,95,175,227,246,166,156,195,48,17,156,237,54,129,223,49,189,8,173,69,13,49,213,35,222,174,33,196,237,110,26,57,94,12,195,195,226,85,162,187,228,10,66,208,93,235,35,150,135,0,233,238,175,10,186,225,102,123,122,7,189,159,53,206,246,143,233,240,124,122,116,185,109,236,117,104,155,234,15,26,56,184,82,71,157,94,232,62,161,7,204,120,121,116,66,20,88,5,41,49,186,192,206,90,22,64,12,246,41,162,12,207,189,80,20,176,199,244,229,113,98,131,229,228,224,56,17,247,147,164,255,0,245,227,214,157,31,204,120,247,102,190,153,85,43,136,176,188,174,86,189,59,250,50,135,10,6,136,155,208,156,254,5,243,84,123,222,17,11,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateContactEntityMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("753d6895-83db-4c95-98ce-6d6b706d6620"),
				Name = "UpdateContactEntity",
				CreatedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("0ea8f226-cb63-4d76-82eb-e583e1edb3da"),
				Name = "context",
				CreatedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				ModifiedInSchemaUId = new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,148,209,78,194,48,20,134,175,225,41,42,23,100,75,204,94,64,103,162,128,6,18,141,17,245,190,118,71,169,233,90,210,117,36,68,120,119,187,181,219,218,129,56,8,215,61,255,183,255,252,231,156,173,176,68,52,123,150,52,197,114,141,98,52,225,138,170,117,244,0,234,117,189,132,100,36,88,158,242,119,204,114,184,254,16,130,221,4,3,91,59,8,175,250,244,19,5,181,56,68,63,253,222,74,227,136,224,10,19,53,77,14,227,30,114,154,104,220,168,170,46,128,174,126,78,22,144,98,205,120,203,64,234,42,14,68,81,193,35,131,52,175,143,152,227,47,144,5,127,202,51,133,57,129,187,245,19,78,161,230,182,169,70,173,169,222,87,162,145,4,172,192,60,6,254,7,11,64,209,168,7,136,238,65,145,197,189,20,233,248,46,168,27,14,203,12,202,207,125,139,143,142,1,204,138,202,210,102,37,124,165,138,193,97,109,166,36,229,95,70,93,150,55,128,4,150,88,170,20,120,215,9,140,29,65,131,193,132,136,188,51,227,182,170,118,125,16,154,233,252,94,4,131,206,78,92,73,131,178,1,207,108,166,254,36,186,71,219,96,170,132,255,39,29,8,218,138,199,126,222,157,205,237,143,221,202,111,157,244,59,19,247,12,161,246,216,154,197,17,46,119,71,82,92,195,133,149,78,179,41,31,3,3,5,9,26,14,171,181,143,253,145,153,7,27,122,188,51,7,253,172,169,61,127,113,227,189,249,234,82,103,49,227,221,184,134,67,131,242,251,141,255,8,194,220,107,79,130,202,37,47,90,219,218,246,202,62,116,115,147,116,169,127,8,33,218,108,208,110,195,86,237,103,57,7,229,196,88,237,224,37,226,57,99,101,122,91,4,44,131,99,164,165,153,208,181,119,186,23,179,195,151,200,236,117,84,246,119,188,173,138,82,77,213,51,231,206,241,44,17,122,151,114,82,146,45,130,235,208,179,94,239,214,89,124,55,247,120,146,105,87,94,27,107,37,237,110,243,153,178,246,238,253,196,180,91,12,223,103,221,66,139,130,87,16,20,111,219,254,246,23,150,227,129,60,150,8,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ContactCareer_Base_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("03d50b4c-d0a3-4ec4-8f60-a33d72930270"));
		}

		#endregion

	}

	#endregion

}

