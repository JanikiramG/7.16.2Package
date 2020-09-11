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

	#region Class: ContactSyncSettingsSchema

	/// <exclude/>
	public class ContactSyncSettingsSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ContactSyncSettingsSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ContactSyncSettingsSchema(ContactSyncSettingsSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ContactSyncSettingsSchema(ContactSyncSettingsSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a");
			RealUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a");
			Name = "ContactSyncSettings";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("1857d6cc-4dd8-4fe7-bb6c-764e36fbd401")) == null) {
				Columns.Add(CreateImportContactsColumn());
			}
			if (Columns.FindByUId(new Guid("3f303942-6360-4c68-be30-8e4dcdcd50ab")) == null) {
				Columns.Add(CreateImportContactsAllColumn());
			}
			if (Columns.FindByUId(new Guid("fe5bb4b5-83d5-4bfa-9da3-b763d463e3f6")) == null) {
				Columns.Add(CreateImportContactsFromFoldersColumn());
			}
			if (Columns.FindByUId(new Guid("8f2584c3-7d7d-41b1-afef-7c728f86d0af")) == null) {
				Columns.Add(CreateImportContactsFromCategoriesColumn());
			}
			if (Columns.FindByUId(new Guid("0f19e212-b9f1-46ed-b867-65c019df259d")) == null) {
				Columns.Add(CreateLinkContactToAccountColumn());
			}
			if (Columns.FindByUId(new Guid("cd22b101-75d7-4647-b6cc-8dacb7487f68")) == null) {
				Columns.Add(CreateExportContactsAllColumn());
			}
			if (Columns.FindByUId(new Guid("2e26864f-596a-49bb-8d41-c927410a2e39")) == null) {
				Columns.Add(CreateExportContactsSelectedColumn());
			}
			if (Columns.FindByUId(new Guid("311dc25b-258c-47af-8aff-949acd7eaf98")) == null) {
				Columns.Add(CreateExportContactsEmployersColumn());
			}
			if (Columns.FindByUId(new Guid("0dd336e9-cad5-41b4-a02b-a605ff86c2d9")) == null) {
				Columns.Add(CreateExportContactsCustomersColumn());
			}
			if (Columns.FindByUId(new Guid("5133841f-df33-4778-affd-3a28294aa539")) == null) {
				Columns.Add(CreateExportContactsOwnerColumn());
			}
			if (Columns.FindByUId(new Guid("3c4eae93-35b3-45fb-b1e0-60f5e40d3d10")) == null) {
				Columns.Add(CreateExportContactsFromGroupsColumn());
			}
			if (Columns.FindByUId(new Guid("8ecdb25f-287e-4e55-9a71-02a4a9a448fa")) == null) {
				Columns.Add(CreateMailboxSyncSettingsColumn());
			}
			if (Columns.FindByUId(new Guid("611c2f35-57df-4470-bce4-65e53971899f")) == null) {
				Columns.Add(CreateLastSyncDateColumn());
			}
			if (Columns.FindByUId(new Guid("9f5569be-0c50-43b3-926e-8dbb620d7ff4")) == null) {
				Columns.Add(CreateLoadContactsFromDateColumn());
			}
			if (Columns.FindByUId(new Guid("9dcb834a-5305-4d3d-89e6-b3542a13c37b")) == null) {
				Columns.Add(CreateExportContactsColumn());
			}
			if (Columns.FindByUId(new Guid("be18b76d-8843-4d5d-9dfd-9f47e3219a73")) == null) {
				Columns.Add(CreateImportContactsFoldersColumn());
			}
			if (Columns.FindByUId(new Guid("706e6b49-ac4e-45f4-8fe7-fc6831bbbfcb")) == null) {
				Columns.Add(CreateImportContactsCategoriesColumn());
			}
			if (Columns.FindByUId(new Guid("a1c38f1d-7ab1-4d2d-be76-ea8113437464")) == null) {
				Columns.Add(CreateExportContactsGroupsColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a");
			column.CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a");
			column.CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a");
			column.CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a");
			column.CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a");
			column.CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a");
			column.CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73");
			return column;
		}

		protected virtual EntitySchemaColumn CreateImportContactsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("1857d6cc-4dd8-4fe7-bb6c-764e36fbd401"),
				Name = @"ImportContacts",
				CreatedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a"),
				ModifiedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			};
		}

		protected virtual EntitySchemaColumn CreateImportContactsAllColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("3f303942-6360-4c68-be30-8e4dcdcd50ab"),
				Name = @"ImportContactsAll",
				CreatedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a"),
				ModifiedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			};
		}

		protected virtual EntitySchemaColumn CreateImportContactsFromFoldersColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("fe5bb4b5-83d5-4bfa-9da3-b763d463e3f6"),
				Name = @"ImportContactsFromFolders",
				CreatedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a"),
				ModifiedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			};
		}

		protected virtual EntitySchemaColumn CreateImportContactsFromCategoriesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("8f2584c3-7d7d-41b1-afef-7c728f86d0af"),
				Name = @"ImportContactsFromCategories",
				CreatedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a"),
				ModifiedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			};
		}

		protected virtual EntitySchemaColumn CreateLinkContactToAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0f19e212-b9f1-46ed-b867-65c019df259d"),
				Name = @"LinkContactToAccount",
				ReferenceSchemaUId = new Guid("8c1021cc-4836-4355-977e-f65c332d92be"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a"),
				ModifiedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"3f59b466-3535-4bb2-b9b4-bca48b43fd38"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateExportContactsAllColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("cd22b101-75d7-4647-b6cc-8dacb7487f68"),
				Name = @"ExportContactsAll",
				CreatedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a"),
				ModifiedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			};
		}

		protected virtual EntitySchemaColumn CreateExportContactsSelectedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("2e26864f-596a-49bb-8d41-c927410a2e39"),
				Name = @"ExportContactsSelected",
				CreatedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a"),
				ModifiedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			};
		}

		protected virtual EntitySchemaColumn CreateExportContactsEmployersColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("311dc25b-258c-47af-8aff-949acd7eaf98"),
				Name = @"ExportContactsEmployers",
				CreatedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a"),
				ModifiedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			};
		}

		protected virtual EntitySchemaColumn CreateExportContactsCustomersColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("0dd336e9-cad5-41b4-a02b-a605ff86c2d9"),
				Name = @"ExportContactsCustomers",
				CreatedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a"),
				ModifiedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			};
		}

		protected virtual EntitySchemaColumn CreateExportContactsOwnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("5133841f-df33-4778-affd-3a28294aa539"),
				Name = @"ExportContactsOwner",
				CreatedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a"),
				ModifiedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			};
		}

		protected virtual EntitySchemaColumn CreateExportContactsFromGroupsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("3c4eae93-35b3-45fb-b1e0-60f5e40d3d10"),
				Name = @"ExportContactsFromGroups",
				CreatedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a"),
				ModifiedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			};
		}

		protected virtual EntitySchemaColumn CreateMailboxSyncSettingsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8ecdb25f-287e-4e55-9a71-02a4a9a448fa"),
				Name = @"MailboxSyncSettings",
				ReferenceSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a"),
				ModifiedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			};
		}

		protected virtual EntitySchemaColumn CreateLastSyncDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("611c2f35-57df-4470-bce4-65e53971899f"),
				Name = @"LastSyncDate",
				CreatedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a"),
				ModifiedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a"),
				CreatedInPackageId = new Guid("f4dad6d8-e90c-404a-81b9-255599719041")
			};
		}

		protected virtual EntitySchemaColumn CreateLoadContactsFromDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("9f5569be-0c50-43b3-926e-8dbb620d7ff4"),
				Name = @"LoadContactsFromDate",
				CreatedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a"),
				ModifiedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a"),
				CreatedInPackageId = new Guid("f4dad6d8-e90c-404a-81b9-255599719041")
			};
		}

		protected virtual EntitySchemaColumn CreateExportContactsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("9dcb834a-5305-4d3d-89e6-b3542a13c37b"),
				Name = @"ExportContacts",
				CreatedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a"),
				ModifiedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a"),
				CreatedInPackageId = new Guid("f4dad6d8-e90c-404a-81b9-255599719041")
			};
		}

		protected virtual EntitySchemaColumn CreateImportContactsFoldersColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("be18b76d-8843-4d5d-9dfd-9f47e3219a73"),
				Name = @"ImportContactsFolders",
				CreatedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a"),
				ModifiedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			};
		}

		protected virtual EntitySchemaColumn CreateImportContactsCategoriesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("706e6b49-ac4e-45f4-8fe7-fc6831bbbfcb"),
				Name = @"ImportContactsCategories",
				CreatedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a"),
				ModifiedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			};
		}

		protected virtual EntitySchemaColumn CreateExportContactsGroupsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("a1c38f1d-7ab1-4d2d-be76-ea8113437464"),
				Name = @"ExportContactsGroups",
				CreatedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a"),
				ModifiedInSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateContactSyncSettingsEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateContactSyncSettingsEventsProcessSchema() {
			var schema = new ContactSyncSettingsEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ContactSyncSettings(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ContactSyncSettings_ExchangeEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ContactSyncSettingsSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ContactSyncSettingsSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a"));
		}

		#endregion

	}

	#endregion

	#region Class: ContactSyncSettings

	/// <summary>
	/// Contact synchronization settings.
	/// </summary>
	public class ContactSyncSettings : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ContactSyncSettings(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ContactSyncSettings";
		}

		public ContactSyncSettings(ContactSyncSettings source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Import contacts.
		/// </summary>
		public bool ImportContacts {
			get {
				return GetTypedColumnValue<bool>("ImportContacts");
			}
			set {
				SetColumnValue("ImportContacts", value);
			}
		}

		/// <summary>
		/// Import all contacts.
		/// </summary>
		public bool ImportContactsAll {
			get {
				return GetTypedColumnValue<bool>("ImportContactsAll");
			}
			set {
				SetColumnValue("ImportContactsAll", value);
			}
		}

		/// <summary>
		/// Import contacts from folders.
		/// </summary>
		public bool ImportContactsFromFolders {
			get {
				return GetTypedColumnValue<bool>("ImportContactsFromFolders");
			}
			set {
				SetColumnValue("ImportContactsFromFolders", value);
			}
		}

		/// <summary>
		/// Import contacts from categories.
		/// </summary>
		public bool ImportContactsFromCategories {
			get {
				return GetTypedColumnValue<bool>("ImportContactsFromCategories");
			}
			set {
				SetColumnValue("ImportContactsFromCategories", value);
			}
		}

		/// <exclude/>
		public Guid LinkContactToAccountId {
			get {
				return GetTypedColumnValue<Guid>("LinkContactToAccountId");
			}
			set {
				SetColumnValue("LinkContactToAccountId", value);
				_linkContactToAccount = null;
			}
		}

		/// <exclude/>
		public string LinkContactToAccountName {
			get {
				return GetTypedColumnValue<string>("LinkContactToAccountName");
			}
			set {
				SetColumnValue("LinkContactToAccountName", value);
				if (_linkContactToAccount != null) {
					_linkContactToAccount.Name = value;
				}
			}
		}

		private LinkContactToAccount _linkContactToAccount;
		/// <summary>
		/// Connect contacts to accounts.
		/// </summary>
		public LinkContactToAccount LinkContactToAccount {
			get {
				return _linkContactToAccount ??
					(_linkContactToAccount = LookupColumnEntities.GetEntity("LinkContactToAccount") as LinkContactToAccount);
			}
		}

		/// <summary>
		/// Export all contacts.
		/// </summary>
		public bool ExportContactsAll {
			get {
				return GetTypedColumnValue<bool>("ExportContactsAll");
			}
			set {
				SetColumnValue("ExportContactsAll", value);
			}
		}

		/// <summary>
		/// Export selected contacts.
		/// </summary>
		public bool ExportContactsSelected {
			get {
				return GetTypedColumnValue<bool>("ExportContactsSelected");
			}
			set {
				SetColumnValue("ExportContactsSelected", value);
			}
		}

		/// <summary>
		/// Export employee contacts.
		/// </summary>
		public bool ExportContactsEmployers {
			get {
				return GetTypedColumnValue<bool>("ExportContactsEmployers");
			}
			set {
				SetColumnValue("ExportContactsEmployers", value);
			}
		}

		/// <summary>
		/// Export customer contacts.
		/// </summary>
		public bool ExportContactsCustomers {
			get {
				return GetTypedColumnValue<bool>("ExportContactsCustomers");
			}
			set {
				SetColumnValue("ExportContactsCustomers", value);
			}
		}

		/// <summary>
		/// Export my contacts.
		/// </summary>
		public bool ExportContactsOwner {
			get {
				return GetTypedColumnValue<bool>("ExportContactsOwner");
			}
			set {
				SetColumnValue("ExportContactsOwner", value);
			}
		}

		/// <summary>
		/// Export contacts from folders.
		/// </summary>
		public bool ExportContactsFromGroups {
			get {
				return GetTypedColumnValue<bool>("ExportContactsFromGroups");
			}
			set {
				SetColumnValue("ExportContactsFromGroups", value);
			}
		}

		/// <exclude/>
		public Guid MailboxSyncSettingsId {
			get {
				return GetTypedColumnValue<Guid>("MailboxSyncSettingsId");
			}
			set {
				SetColumnValue("MailboxSyncSettingsId", value);
				_mailboxSyncSettings = null;
			}
		}

		/// <exclude/>
		public string MailboxSyncSettingsUserName {
			get {
				return GetTypedColumnValue<string>("MailboxSyncSettingsUserName");
			}
			set {
				SetColumnValue("MailboxSyncSettingsUserName", value);
				if (_mailboxSyncSettings != null) {
					_mailboxSyncSettings.UserName = value;
				}
			}
		}

		private MailboxSyncSettings _mailboxSyncSettings;
		/// <summary>
		/// Mailbox synchronization settings.
		/// </summary>
		public MailboxSyncSettings MailboxSyncSettings {
			get {
				return _mailboxSyncSettings ??
					(_mailboxSyncSettings = LookupColumnEntities.GetEntity("MailboxSyncSettings") as MailboxSyncSettings);
			}
		}

		/// <summary>
		/// LastSyncDate.
		/// </summary>
		public DateTime LastSyncDate {
			get {
				return GetTypedColumnValue<DateTime>("LastSyncDate");
			}
			set {
				SetColumnValue("LastSyncDate", value);
			}
		}

		/// <summary>
		/// LoadContactsFromDate.
		/// </summary>
		public DateTime LoadContactsFromDate {
			get {
				return GetTypedColumnValue<DateTime>("LoadContactsFromDate");
			}
			set {
				SetColumnValue("LoadContactsFromDate", value);
			}
		}

		/// <summary>
		/// Export contacts.
		/// </summary>
		public bool ExportContacts {
			get {
				return GetTypedColumnValue<bool>("ExportContacts");
			}
			set {
				SetColumnValue("ExportContacts", value);
			}
		}

		/// <summary>
		/// Contact folders for import.
		/// </summary>
		public string ImportContactsFolders {
			get {
				return GetTypedColumnValue<string>("ImportContactsFolders");
			}
			set {
				SetColumnValue("ImportContactsFolders", value);
			}
		}

		/// <summary>
		/// Contact categories for import.
		/// </summary>
		public string ImportContactsCategories {
			get {
				return GetTypedColumnValue<string>("ImportContactsCategories");
			}
			set {
				SetColumnValue("ImportContactsCategories", value);
			}
		}

		/// <summary>
		/// Contact folders for export.
		/// </summary>
		public string ExportContactsGroups {
			get {
				return GetTypedColumnValue<string>("ExportContactsGroups");
			}
			set {
				SetColumnValue("ExportContactsGroups", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ContactSyncSettings_ExchangeEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ContactSyncSettingsDeleted", e);
			Inserting += (s, e) => ThrowEvent("ContactSyncSettingsInserting", e);
			Updating += (s, e) => ThrowEvent("ContactSyncSettingsUpdating", e);
			Validating += (s, e) => ThrowEvent("ContactSyncSettingsValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ContactSyncSettings(this);
		}

		#endregion

	}

	#endregion

	#region Class: ContactSyncSettings_ExchangeEventsProcess

	/// <exclude/>
	public partial class ContactSyncSettings_ExchangeEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : ContactSyncSettings
	{

		public ContactSyncSettings_ExchangeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ContactSyncSettings_ExchangeEventsProcess";
			SchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _updatingEventSubProcess;
		public ProcessFlowElement UpdatingEventSubProcess {
			get {
				return _updatingEventSubProcess ?? (_updatingEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "UpdatingEventSubProcess",
					SchemaElementUId = new Guid("2cc57a23-ff6d-40ed-ae70-2b43060f03ea"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _contactSyncSettingsUpdatingStartMessage;
		public ProcessFlowElement ContactSyncSettingsUpdatingStartMessage {
			get {
				return _contactSyncSettingsUpdatingStartMessage ?? (_contactSyncSettingsUpdatingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ContactSyncSettingsUpdatingStartMessage",
					SchemaElementUId = new Guid("c3361d18-e4e1-4450-bac6-6e1b9eb0d82c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _contactSyncSettingsUpdatingThrowMessage;
		public ProcessThrowMessageEvent ContactSyncSettingsUpdatingThrowMessage {
			get {
				return _contactSyncSettingsUpdatingThrowMessage ?? (_contactSyncSettingsUpdatingThrowMessage = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ContactSyncSettingsUpdatingThrowMessage",
					SchemaElementUId = new Guid("57e8984f-1407-42e3-9e02-f24d3d8ddc8b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "ContactSyncSettingsUpdating",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _contactSyncSettingsUpdatingScriptTask;
		public ProcessScriptTask ContactSyncSettingsUpdatingScriptTask {
			get {
				return _contactSyncSettingsUpdatingScriptTask ?? (_contactSyncSettingsUpdatingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ContactSyncSettingsUpdatingScriptTask",
					SchemaElementUId = new Guid("8dfa6675-3c34-4696-ab72-0a886cb07806"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ContactSyncSettingsUpdatingScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[UpdatingEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { UpdatingEventSubProcess };
			FlowElements[ContactSyncSettingsUpdatingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ContactSyncSettingsUpdatingStartMessage };
			FlowElements[ContactSyncSettingsUpdatingThrowMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ContactSyncSettingsUpdatingThrowMessage };
			FlowElements[ContactSyncSettingsUpdatingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ContactSyncSettingsUpdatingScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "UpdatingEventSubProcess":
						break;
					case "ContactSyncSettingsUpdatingStartMessage":
						e.Context.QueueTasks.Enqueue("ContactSyncSettingsUpdatingThrowMessage");
						break;
					case "ContactSyncSettingsUpdatingThrowMessage":
						e.Context.QueueTasks.Enqueue("ContactSyncSettingsUpdatingScriptTask");
						break;
					case "ContactSyncSettingsUpdatingScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ContactSyncSettingsUpdatingStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "UpdatingEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ContactSyncSettingsUpdatingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ContactSyncSettingsUpdatingStartMessage";
					result = ContactSyncSettingsUpdatingStartMessage.Execute(context);
					break;
				case "ContactSyncSettingsUpdatingThrowMessage":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "ContactSyncSettingsUpdating");
					result = ContactSyncSettingsUpdatingThrowMessage.Execute(context);
					break;
				case "ContactSyncSettingsUpdatingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ContactSyncSettingsUpdatingScriptTask";
					result = ContactSyncSettingsUpdatingScriptTask.Execute(context, ContactSyncSettingsUpdatingScriptTaskExecute);
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

		public virtual bool ContactSyncSettingsUpdatingScriptTaskExecute(ProcessExecutingContext context) {
			foreach (EntityColumnValue value in Entity.GetChangedColumnValues()) {
				if (!value.Value.Equals(value.OldValue)) {
					Entity.SetColumnValue("LastSyncDate", null);
					return true;
				}
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ContactSyncSettingsUpdating":
							if (ActivatedEventElements.Contains("ContactSyncSettingsUpdatingStartMessage")) {
							context.QueueTasks.Enqueue("ContactSyncSettingsUpdatingStartMessage");
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

	#region Class: ContactSyncSettings_ExchangeEventsProcess

	/// <exclude/>
	public class ContactSyncSettings_ExchangeEventsProcess : ContactSyncSettings_ExchangeEventsProcess<ContactSyncSettings>
	{

		public ContactSyncSettings_ExchangeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ContactSyncSettings_ExchangeEventsProcess

	public partial class ContactSyncSettings_ExchangeEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: ContactSyncSettingsEventsProcessSchema

	/// <exclude/>
	public class ContactSyncSettingsEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public ContactSyncSettingsEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ContactSyncSettingsEventsProcessSchema(ContactSyncSettingsEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ContactSyncSettings_ExchangeEventsProcess";
			UId = new Guid("12295283-b76b-49df-bc65-456d3edaecc6");
			CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73");
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
			ProcessSchemaLaneSet schemaUpdateLaneSet = CreateUpdateLaneSetLaneSet();
			LaneSets.Add(schemaUpdateLaneSet);
			ProcessSchemaLane schemaUpdateLane = CreateUpdateLaneLane();
			schemaUpdateLaneSet.Lanes.Add(schemaUpdateLane);
			ProcessSchemaEventSubProcess updatingeventsubprocess = CreateUpdatingEventSubProcessEventSubProcess();
			FlowElements.Add(updatingeventsubprocess);
			ProcessSchemaStartMessageEvent contactsyncsettingsupdatingstartmessage = CreateContactSyncSettingsUpdatingStartMessageStartMessageEvent();
			updatingeventsubprocess.FlowElements.Add(contactsyncsettingsupdatingstartmessage);
			ProcessSchemaIntermediateThrowMessageEvent contactsyncsettingsupdatingthrowmessage = CreateContactSyncSettingsUpdatingThrowMessageIntermediateThrowMessageEvent();
			updatingeventsubprocess.FlowElements.Add(contactsyncsettingsupdatingthrowmessage);
			ProcessSchemaScriptTask contactsyncsettingsupdatingscripttask = CreateContactSyncSettingsUpdatingScriptTaskScriptTask();
			updatingeventsubprocess.FlowElements.Add(contactsyncsettingsupdatingscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("0a1debc5-fde8-4c8e-9f50-66aea87f21ad"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("12295283-b76b-49df-bc65-456d3edaecc6"),
				CurveCenterPosition = new Point(173, 92),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("12295283-b76b-49df-bc65-456d3edaecc6"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c3361d18-e4e1-4450-bac6-6e1b9eb0d82c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("57e8984f-1407-42e3-9e02-f24d3d8ddc8b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("9c1c2ac4-6ae2-4452-a3aa-6dc52ff4bd20"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("12295283-b76b-49df-bc65-456d3edaecc6"),
				CurveCenterPosition = new Point(262, 92),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("12295283-b76b-49df-bc65-456d3edaecc6"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("57e8984f-1407-42e3-9e02-f24d3d8ddc8b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8dfa6675-3c34-4696-ab72-0a886cb07806"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateUpdateLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaUpdateLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("33ee04f7-3e1f-419c-9fd9-d2eac5410056"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("12295283-b76b-49df-bc65-456d3edaecc6"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("12295283-b76b-49df-bc65-456d3edaecc6"),
				Name = @"UpdateLaneSet",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(667, 177),
				UseBackgroundMode = false
			};
			return schemaUpdateLaneSet;
		}

		protected virtual ProcessSchemaLane CreateUpdateLaneLane() {
			ProcessSchemaLane schemaUpdateLane = new ProcessSchemaLane(this) {
				UId = new Guid("1593f7c9-1604-4e24-b422-ac514659cdc9"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("33ee04f7-3e1f-419c-9fd9-d2eac5410056"),
				CreatedInOwnerSchemaUId = new Guid("9aba4e21-c6b8-46bc-8277-61daf4beac1a"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("12295283-b76b-49df-bc65-456d3edaecc6"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("12295283-b76b-49df-bc65-456d3edaecc6"),
				Name = @"UpdateLane",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(638, 177),
				UseBackgroundMode = false
			};
			return schemaUpdateLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateUpdatingEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaUpdatingEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2cc57a23-ff6d-40ed-ae70-2b43060f03ea"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1593f7c9-1604-4e24-b422-ac514659cdc9"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("12295283-b76b-49df-bc65-456d3edaecc6"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("12295283-b76b-49df-bc65-456d3edaecc6"),
				Name = @"UpdatingEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(43, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(312, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaUpdatingEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateContactSyncSettingsUpdatingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c3361d18-e4e1-4450-bac6-6e1b9eb0d82c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2cc57a23-ff6d-40ed-ae70-2b43060f03ea"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("12295283-b76b-49df-bc65-456d3edaecc6"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ContactSyncSettingsUpdating",
				ModifiedInSchemaUId = new Guid("12295283-b76b-49df-bc65-456d3edaecc6"),
				Name = @"ContactSyncSettingsUpdatingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateContactSyncSettingsUpdatingThrowMessageIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("57e8984f-1407-42e3-9e02-f24d3d8ddc8b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2cc57a23-ff6d-40ed-ae70-2b43060f03ea"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("12295283-b76b-49df-bc65-456d3edaecc6"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"ContactSyncSettingsUpdating",
				ModifiedInSchemaUId = new Guid("12295283-b76b-49df-bc65-456d3edaecc6"),
				Name = @"ContactSyncSettingsUpdatingThrowMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(120, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateContactSyncSettingsUpdatingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8dfa6675-3c34-4696-ab72-0a886cb07806"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2cc57a23-ff6d-40ed-ae70-2b43060f03ea"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("12295283-b76b-49df-bc65-456d3edaecc6"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("12295283-b76b-49df-bc65-456d3edaecc6"),
				Name = @"ContactSyncSettingsUpdatingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(211, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,203,47,74,77,76,206,80,208,112,205,43,201,44,169,116,206,207,41,205,205,11,75,204,41,77,85,40,3,147,153,121,10,16,41,61,247,212,18,231,140,196,188,244,212,20,36,85,197,26,154,154,10,213,188,92,156,153,105,10,26,138,96,45,122,96,9,61,215,194,210,196,156,98,13,136,144,127,78,10,88,20,170,152,19,106,100,48,208,72,132,89,26,74,62,137,197,37,193,149,121,201,46,137,37,169,74,58,10,121,165,57,57,154,214,32,245,69,169,37,165,69,121,10,37,69,165,169,32,126,45,47,23,16,33,11,2,0,137,32,52,58,200,0,0,0 }
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
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
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
			return new ContactSyncSettingsEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("12295283-b76b-49df-bc65-456d3edaecc6"));
		}

		#endregion

	}

	#endregion


	#region Class: ContactSyncSettingsEventsProcess

	/// <exclude/>
	public class ContactSyncSettingsEventsProcess : ContactSyncSettings_ExchangeEventsProcess
	{

		public ContactSyncSettingsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

