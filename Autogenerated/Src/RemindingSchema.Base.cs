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
	using Terrasoft.Core.Store;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.Messaging.Common;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: Reminding_Base_TerrasoftSchema

	/// <exclude/>
	public class Reminding_Base_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public Reminding_Base_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Reminding_Base_TerrasoftSchema(Reminding_Base_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Reminding_Base_TerrasoftSchema(Reminding_Base_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37");
			RealUId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37");
			Name = "Reminding_Base_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateSubjectCaptionColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("29447fd8-0545-41f3-a9cb-e8d0a36f2a8f")) == null) {
				Columns.Add(CreateAuthorColumn());
			}
			if (Columns.FindByUId(new Guid("401431cd-1d52-4419-a1f1-7667a3544d2c")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("afe1fb47-e911-4236-b7d7-54bd55871983")) == null) {
				Columns.Add(CreateSourceColumn());
			}
			if (Columns.FindByUId(new Guid("ce7f9708-5cbd-4316-ba39-496e33195324")) == null) {
				Columns.Add(CreateRemindTimeColumn());
			}
			if (Columns.FindByUId(new Guid("7f4c5e97-b69b-4a81-ac70-5f73d2633b13")) == null) {
				Columns.Add(CreateDescriptionColumn());
			}
			if (Columns.FindByUId(new Guid("051943fd-8798-43e2-bc43-cfb70fb42804")) == null) {
				Columns.Add(CreateSubjectIdColumn());
			}
			if (Columns.FindByUId(new Guid("e6fef746-fa59-400e-8769-444734b1a203")) == null) {
				Columns.Add(CreateSysEntitySchemaColumn());
			}
			if (Columns.FindByUId(new Guid("ee738b36-5182-42c7-9ffe-937b371f40fd")) == null) {
				Columns.Add(CreateTypeCaptionColumn());
			}
			if (Columns.FindByUId(new Guid("a6f05909-7c06-47e6-b75e-27a23dc94154")) == null) {
				Columns.Add(CreatePopupTitleColumn());
			}
			if (Columns.FindByUId(new Guid("86f8371c-ea23-4e99-9505-d424d8b6abd3")) == null) {
				Columns.Add(CreateHashColumn());
			}
			if (Columns.FindByUId(new Guid("57a5c5da-e5bd-4e78-a212-459ecb9a3356")) == null) {
				Columns.Add(CreateIsReadColumn());
			}
			if (Columns.FindByUId(new Guid("04821e69-0db1-4ef8-a967-22239620a1e1")) == null) {
				Columns.Add(CreateNotificationTypeColumn());
			}
			if (Columns.FindByUId(new Guid("97932595-fb5b-4eac-8639-8b1a0e523827")) == null) {
				Columns.Add(CreateLoaderColumn());
			}
			if (Columns.FindByUId(new Guid("c01085ea-f81e-461c-962b-d5df12f47e69")) == null) {
				Columns.Add(CreateSenderIdColumn());
			}
			if (Columns.FindByUId(new Guid("33e7d87a-b17f-4590-8ee4-69e19f2e82ba")) == null) {
				Columns.Add(CreateIsNeedToSendColumn());
			}
			if (Columns.FindByUId(new Guid("e09a2804-1d9d-4eae-8eb4-2a53134f337f")) == null) {
				Columns.Add(CreateAnniversaryDateColumn());
			}
			if (Columns.FindByUId(new Guid("a1f17207-ceb7-4b10-bcb8-078494f05b21")) == null) {
				Columns.Add(CreateConfigColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateAuthorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("29447fd8-0545-41f3-a9cb-e8d0a36f2a8f"),
				Name = @"Author",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInSchemaUId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37"),
				ModifiedInSchemaUId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("401431cd-1d52-4419-a1f1-7667a3544d2c"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInSchemaUId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37"),
				ModifiedInSchemaUId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSourceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("afe1fb47-e911-4236-b7d7-54bd55871983"),
				Name = @"Source",
				ReferenceSchemaUId = new Guid("dccbeb85-5abb-489e-9ffe-1daaacba1ad5"),
				CreatedInSchemaUId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37"),
				ModifiedInSchemaUId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateRemindTimeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("ce7f9708-5cbd-4316-ba39-496e33195324"),
				Name = @"RemindTime",
				CreatedInSchemaUId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37"),
				ModifiedInSchemaUId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateDescriptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("7f4c5e97-b69b-4a81-ac70-5f73d2633b13"),
				Name = @"Description",
				CreatedInSchemaUId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37"),
				ModifiedInSchemaUId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSubjectIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("051943fd-8798-43e2-bc43-cfb70fb42804"),
				Name = @"SubjectId",
				CreatedInSchemaUId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37"),
				ModifiedInSchemaUId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSysEntitySchemaColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e6fef746-fa59-400e-8769-444734b1a203"),
				Name = @"SysEntitySchema",
				ReferenceSchemaUId = new Guid("a2d407a1-cda4-4344-ac71-88a4e2bf9c28"),
				IsWeakReference = true,
				CreatedInSchemaUId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37"),
				ModifiedInSchemaUId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSubjectCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("f80d917a-4f9a-4617-b6d7-afffab1b9d57"),
				Name = @"SubjectCaption",
				CreatedInSchemaUId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37"),
				ModifiedInSchemaUId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateTypeCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("ee738b36-5182-42c7-9ffe-937b371f40fd"),
				Name = @"TypeCaption",
				CreatedInSchemaUId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37"),
				ModifiedInSchemaUId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37"),
				CreatedInPackageId = new Guid("2225ee40-8de9-4302-9125-1477122665f5")
			};
		}

		protected virtual EntitySchemaColumn CreatePopupTitleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("a6f05909-7c06-47e6-b75e-27a23dc94154"),
				Name = @"PopupTitle",
				CreatedInSchemaUId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37"),
				ModifiedInSchemaUId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateHashColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("86f8371c-ea23-4e99-9505-d424d8b6abd3"),
				Name = @"Hash",
				CreatedInSchemaUId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37"),
				ModifiedInSchemaUId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37"),
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847")
			};
		}

		protected virtual EntitySchemaColumn CreateIsReadColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("57a5c5da-e5bd-4e78-a212-459ecb9a3356"),
				Name = @"IsRead",
				CreatedInSchemaUId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37"),
				ModifiedInSchemaUId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37"),
				CreatedInPackageId = new Guid("271744d8-d0f2-48d8-a4d0-e376f30523b7")
			};
		}

		protected virtual EntitySchemaColumn CreateNotificationTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("04821e69-0db1-4ef8-a967-22239620a1e1"),
				Name = @"NotificationType",
				ReferenceSchemaUId = new Guid("ef45b183-3adb-4b37-a099-8d28e9ee9b3a"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37"),
				ModifiedInSchemaUId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37"),
				CreatedInPackageId = new Guid("271744d8-d0f2-48d8-a4d0-e376f30523b7"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"685e7149-c015-4a4d-b4a6-2e5625a6314c"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateLoaderColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("97932595-fb5b-4eac-8639-8b1a0e523827"),
				Name = @"Loader",
				ReferenceSchemaUId = new Guid("a2d407a1-cda4-4344-ac71-88a4e2bf9c28"),
				IsWeakReference = true,
				CreatedInSchemaUId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37"),
				ModifiedInSchemaUId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37"),
				CreatedInPackageId = new Guid("1b79a4cf-ffd7-42a6-b882-ae3859f2ab39")
			};
		}

		protected virtual EntitySchemaColumn CreateSenderIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("c01085ea-f81e-461c-962b-d5df12f47e69"),
				Name = @"SenderId",
				CreatedInSchemaUId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37"),
				ModifiedInSchemaUId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37"),
				CreatedInPackageId = new Guid("7094e60e-83c9-4747-8d9c-40b7b1b1c58b")
			};
		}

		protected virtual EntitySchemaColumn CreateIsNeedToSendColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("33e7d87a-b17f-4590-8ee4-69e19f2e82ba"),
				Name = @"IsNeedToSend",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37"),
				ModifiedInSchemaUId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateAnniversaryDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("e09a2804-1d9d-4eae-8eb4-2a53134f337f"),
				Name = @"AnniversaryDate",
				CreatedInSchemaUId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37"),
				ModifiedInSchemaUId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateConfigColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("a1f17207-ceb7-4b10-bcb8-078494f05b21"),
				Name = @"Config",
				CreatedInSchemaUId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37"),
				ModifiedInSchemaUId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateReminding_Base_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateReminding_Base_TerrasoftEventsProcessSchema() {
			var schema = new Reminding_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Reminding_Base_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Reminding_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Reminding_Base_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Reminding_Base_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37"));
		}

		#endregion

	}

	#endregion

	#region Class: Reminding_Base_Terrasoft

	/// <summary>
	/// Notification.
	/// </summary>
	public class Reminding_Base_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public Reminding_Base_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Reminding_Base_Terrasoft";
		}

		public Reminding_Base_Terrasoft(Reminding_Base_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid AuthorId {
			get {
				return GetTypedColumnValue<Guid>("AuthorId");
			}
			set {
				SetColumnValue("AuthorId", value);
				_author = null;
			}
		}

		/// <exclude/>
		public string AuthorName {
			get {
				return GetTypedColumnValue<string>("AuthorName");
			}
			set {
				SetColumnValue("AuthorName", value);
				if (_author != null) {
					_author.Name = value;
				}
			}
		}

		private Contact _author;
		/// <summary>
		/// Created by.
		/// </summary>
		public Contact Author {
			get {
				return _author ??
					(_author = LookupColumnEntities.GetEntity("Author") as Contact);
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
		/// To.
		/// </summary>
		public Contact Contact {
			get {
				return _contact ??
					(_contact = LookupColumnEntities.GetEntity("Contact") as Contact);
			}
		}

		/// <exclude/>
		public Guid SourceId {
			get {
				return GetTypedColumnValue<Guid>("SourceId");
			}
			set {
				SetColumnValue("SourceId", value);
				_source = null;
			}
		}

		/// <exclude/>
		public string SourceName {
			get {
				return GetTypedColumnValue<string>("SourceName");
			}
			set {
				SetColumnValue("SourceName", value);
				if (_source != null) {
					_source.Name = value;
				}
			}
		}

		private RemindingSource _source;
		/// <summary>
		/// Source.
		/// </summary>
		public RemindingSource Source {
			get {
				return _source ??
					(_source = LookupColumnEntities.GetEntity("Source") as RemindingSource);
			}
		}

		/// <summary>
		/// Time.
		/// </summary>
		public DateTime RemindTime {
			get {
				return GetTypedColumnValue<DateTime>("RemindTime");
			}
			set {
				SetColumnValue("RemindTime", value);
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
		/// Unique caption Id.
		/// </summary>
		public Guid SubjectId {
			get {
				return GetTypedColumnValue<Guid>("SubjectId");
			}
			set {
				SetColumnValue("SubjectId", value);
			}
		}

		/// <exclude/>
		public Guid SysEntitySchemaId {
			get {
				return GetTypedColumnValue<Guid>("SysEntitySchemaId");
			}
			set {
				SetColumnValue("SysEntitySchemaId", value);
				_sysEntitySchema = null;
			}
		}

		/// <exclude/>
		public string SysEntitySchemaName {
			get {
				return GetTypedColumnValue<string>("SysEntitySchemaName");
			}
			set {
				SetColumnValue("SysEntitySchemaName", value);
				if (_sysEntitySchema != null) {
					_sysEntitySchema.Name = value;
				}
			}
		}

		private VwSysModuleEntity _sysEntitySchema;
		/// <summary>
		/// Object.
		/// </summary>
		public VwSysModuleEntity SysEntitySchema {
			get {
				return _sysEntitySchema ??
					(_sysEntitySchema = LookupColumnEntities.GetEntity("SysEntitySchema") as VwSysModuleEntity);
			}
		}

		/// <summary>
		/// Title.
		/// </summary>
		public string SubjectCaption {
			get {
				return GetTypedColumnValue<string>("SubjectCaption");
			}
			set {
				SetColumnValue("SubjectCaption", value);
			}
		}

		/// <summary>
		/// Type name.
		/// </summary>
		public string TypeCaption {
			get {
				return GetTypedColumnValue<string>("TypeCaption");
			}
			set {
				SetColumnValue("TypeCaption", value);
			}
		}

		/// <summary>
		/// Popup title.
		/// </summary>
		public string PopupTitle {
			get {
				return GetTypedColumnValue<string>("PopupTitle");
			}
			set {
				SetColumnValue("PopupTitle", value);
			}
		}

		/// <summary>
		/// Hash code.
		/// </summary>
		public string Hash {
			get {
				return GetTypedColumnValue<string>("Hash");
			}
			set {
				SetColumnValue("Hash", value);
			}
		}

		/// <summary>
		/// IsRead.
		/// </summary>
		public bool IsRead {
			get {
				return GetTypedColumnValue<bool>("IsRead");
			}
			set {
				SetColumnValue("IsRead", value);
			}
		}

		/// <exclude/>
		public Guid NotificationTypeId {
			get {
				return GetTypedColumnValue<Guid>("NotificationTypeId");
			}
			set {
				SetColumnValue("NotificationTypeId", value);
				_notificationType = null;
			}
		}

		/// <exclude/>
		public string NotificationTypeName {
			get {
				return GetTypedColumnValue<string>("NotificationTypeName");
			}
			set {
				SetColumnValue("NotificationTypeName", value);
				if (_notificationType != null) {
					_notificationType.Name = value;
				}
			}
		}

		private NotificationType _notificationType;
		/// <summary>
		/// NotificationType.
		/// </summary>
		public NotificationType NotificationType {
			get {
				return _notificationType ??
					(_notificationType = LookupColumnEntities.GetEntity("NotificationType") as NotificationType);
			}
		}

		/// <exclude/>
		public Guid LoaderId {
			get {
				return GetTypedColumnValue<Guid>("LoaderId");
			}
			set {
				SetColumnValue("LoaderId", value);
				_loader = null;
			}
		}

		/// <exclude/>
		public string LoaderName {
			get {
				return GetTypedColumnValue<string>("LoaderName");
			}
			set {
				SetColumnValue("LoaderName", value);
				if (_loader != null) {
					_loader.Name = value;
				}
			}
		}

		private VwSysModuleEntity _loader;
		/// <summary>
		/// Notification loader.
		/// </summary>
		public VwSysModuleEntity Loader {
			get {
				return _loader ??
					(_loader = LookupColumnEntities.GetEntity("Loader") as VwSysModuleEntity);
			}
		}

		/// <summary>
		/// Parent entity ID.
		/// </summary>
		public Guid SenderId {
			get {
				return GetTypedColumnValue<Guid>("SenderId");
			}
			set {
				SetColumnValue("SenderId", value);
			}
		}

		/// <summary>
		/// Message is need to send.
		/// </summary>
		public bool IsNeedToSend {
			get {
				return GetTypedColumnValue<bool>("IsNeedToSend");
			}
			set {
				SetColumnValue("IsNeedToSend", value);
			}
		}

		/// <summary>
		/// Date of anninersary.
		/// </summary>
		public DateTime AnniversaryDate {
			get {
				return GetTypedColumnValue<DateTime>("AnniversaryDate");
			}
			set {
				SetColumnValue("AnniversaryDate", value);
			}
		}

		/// <summary>
		/// Config.
		/// </summary>
		public string Config {
			get {
				return GetTypedColumnValue<string>("Config");
			}
			set {
				SetColumnValue("Config", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Reminding_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Reminding_Base_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("Reminding_Base_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("Reminding_Base_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("Reminding_Base_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("Reminding_Base_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Reminding_Base_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Reminding_Base_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Reminding_Base_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Reminding_BaseEventsProcess

	/// <exclude/>
	public partial class Reminding_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : Reminding_Base_Terrasoft
	{

		public Reminding_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Reminding_BaseEventsProcess";
			SchemaUId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual bool IsNew {
			get;
			set;
		}

		public virtual bool IsRemindingForImmediateSend {
			get;
			set;
		}

		public virtual bool IsRemindingPostponed {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess;
		public ProcessFlowElement EventSubProcess {
			get {
				return _eventSubProcess ?? (_eventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess",
					SchemaElementUId = new Guid("38f6f9be-5d9c-477e-901e-68eb4f2c5ab8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _remindingSavedStartMessage;
		public ProcessFlowElement RemindingSavedStartMessage {
			get {
				return _remindingSavedStartMessage ?? (_remindingSavedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "RemindingSavedStartMessage",
					SchemaElementUId = new Guid("7bbd26e9-038c-4382-9ee6-93fb46a5f7f1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _remindingDeletedStartMessage;
		public ProcessFlowElement RemindingDeletedStartMessage {
			get {
				return _remindingDeletedStartMessage ?? (_remindingDeletedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "RemindingDeletedStartMessage",
					SchemaElementUId = new Guid("173f83e0-ef4f-4f09-a917-61f3b3683b81"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _remindingSavedScriptTask;
		public ProcessScriptTask RemindingSavedScriptTask {
			get {
				return _remindingSavedScriptTask ?? (_remindingSavedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "RemindingSavedScriptTask",
					SchemaElementUId = new Guid("77e54843-52d8-423e-bf43-fdef747add27"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = RemindingSavedScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _remindingDeletedScriptTask;
		public ProcessScriptTask RemindingDeletedScriptTask {
			get {
				return _remindingDeletedScriptTask ?? (_remindingDeletedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "RemindingDeletedScriptTask",
					SchemaElementUId = new Guid("828d3cfa-ce4a-4b39-997a-d7f7ae1afaa8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = RemindingDeletedScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _remindingInsertedScriptTask;
		public ProcessScriptTask RemindingInsertedScriptTask {
			get {
				return _remindingInsertedScriptTask ?? (_remindingInsertedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "RemindingInsertedScriptTask",
					SchemaElementUId = new Guid("9cb08072-9b2c-4cfe-bbbc-ae52b90bb4f7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = RemindingInsertedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _remindingInsertedStartMessage;
		public ProcessFlowElement RemindingInsertedStartMessage {
			get {
				return _remindingInsertedStartMessage ?? (_remindingInsertedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "RemindingInsertedStartMessage",
					SchemaElementUId = new Guid("fc7a3594-a563-41fa-8acd-b945708aac81"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _remindingInsertingStartMessage;
		public ProcessFlowElement RemindingInsertingStartMessage {
			get {
				return _remindingInsertingStartMessage ?? (_remindingInsertingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "RemindingInsertingStartMessage",
					SchemaElementUId = new Guid("79648fc8-fb36-456c-9fb8-55aac88b4cd8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _remindingInsertingScriptTask;
		public ProcessScriptTask RemindingInsertingScriptTask {
			get {
				return _remindingInsertingScriptTask ?? (_remindingInsertingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "RemindingInsertingScriptTask",
					SchemaElementUId = new Guid("39626b64-4c4c-4544-bb4c-50dbe21ff51d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = RemindingInsertingScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _remindingSavingStartMessage;
		public ProcessFlowElement RemindingSavingStartMessage {
			get {
				return _remindingSavingStartMessage ?? (_remindingSavingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "RemindingSavingStartMessage",
					SchemaElementUId = new Guid("ec01b1b6-430f-47b0-b160-192b55711db6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _remindingSavingScriptTask;
		public ProcessScriptTask RemindingSavingScriptTask {
			get {
				return _remindingSavingScriptTask ?? (_remindingSavingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "RemindingSavingScriptTask",
					SchemaElementUId = new Guid("afa34365-4752-4771-918b-bd18de0d6a41"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = RemindingSavingScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess };
			FlowElements[RemindingSavedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { RemindingSavedStartMessage };
			FlowElements[RemindingDeletedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { RemindingDeletedStartMessage };
			FlowElements[RemindingSavedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { RemindingSavedScriptTask };
			FlowElements[RemindingDeletedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { RemindingDeletedScriptTask };
			FlowElements[RemindingInsertedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { RemindingInsertedScriptTask };
			FlowElements[RemindingInsertedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { RemindingInsertedStartMessage };
			FlowElements[RemindingInsertingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { RemindingInsertingStartMessage };
			FlowElements[RemindingInsertingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { RemindingInsertingScriptTask };
			FlowElements[RemindingSavingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { RemindingSavingStartMessage };
			FlowElements[RemindingSavingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { RemindingSavingScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess":
						break;
					case "RemindingSavedStartMessage":
						e.Context.QueueTasks.Enqueue("RemindingSavedScriptTask");
						break;
					case "RemindingDeletedStartMessage":
						e.Context.QueueTasks.Enqueue("RemindingDeletedScriptTask");
						break;
					case "RemindingSavedScriptTask":
						break;
					case "RemindingDeletedScriptTask":
						break;
					case "RemindingInsertedScriptTask":
						break;
					case "RemindingInsertedStartMessage":
						e.Context.QueueTasks.Enqueue("RemindingInsertedScriptTask");
						break;
					case "RemindingInsertingStartMessage":
						e.Context.QueueTasks.Enqueue("RemindingInsertingScriptTask");
						break;
					case "RemindingInsertingScriptTask":
						break;
					case "RemindingSavingStartMessage":
						e.Context.QueueTasks.Enqueue("RemindingSavingScriptTask");
						break;
					case "RemindingSavingScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("RemindingSavedStartMessage");
			ActivatedEventElements.Add("RemindingDeletedStartMessage");
			ActivatedEventElements.Add("RemindingInsertedStartMessage");
			ActivatedEventElements.Add("RemindingInsertingStartMessage");
			ActivatedEventElements.Add("RemindingSavingStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "RemindingSavedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "RemindingSavedStartMessage";
					result = RemindingSavedStartMessage.Execute(context);
					break;
				case "RemindingDeletedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "RemindingDeletedStartMessage";
					result = RemindingDeletedStartMessage.Execute(context);
					break;
				case "RemindingSavedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "RemindingSavedScriptTask";
					result = RemindingSavedScriptTask.Execute(context, RemindingSavedScriptTaskExecute);
					break;
				case "RemindingDeletedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "RemindingDeletedScriptTask";
					result = RemindingDeletedScriptTask.Execute(context, RemindingDeletedScriptTaskExecute);
					break;
				case "RemindingInsertedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "RemindingInsertedScriptTask";
					result = RemindingInsertedScriptTask.Execute(context, RemindingInsertedScriptTaskExecute);
					break;
				case "RemindingInsertedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "RemindingInsertedStartMessage";
					result = RemindingInsertedStartMessage.Execute(context);
					break;
				case "RemindingInsertingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "RemindingInsertingStartMessage";
					result = RemindingInsertingStartMessage.Execute(context);
					break;
				case "RemindingInsertingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "RemindingInsertingScriptTask";
					result = RemindingInsertingScriptTask.Execute(context, RemindingInsertingScriptTaskExecute);
					break;
				case "RemindingSavingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "RemindingSavingStartMessage";
					result = RemindingSavingStartMessage.Execute(context);
					break;
				case "RemindingSavingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "RemindingSavingScriptTask";
					result = RemindingSavingScriptTask.Execute(context, RemindingSavingScriptTaskExecute);
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
				case "IsRemindingPostponed":
					IsRemindingPostponed = reader.GetValue<System.Boolean>();
				break;
				case "IsRemindingForImmediateSend":
					IsRemindingForImmediateSend = reader.GetValue<System.Boolean>();
				break;
				case "IsNew":
					IsNew = reader.GetValue<System.Boolean>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool RemindingSavedScriptTaskExecute(ProcessExecutingContext context) {
			OnSavedHandler();
			return true;
		}

		public virtual bool RemindingDeletedScriptTaskExecute(ProcessExecutingContext context) {
			if (!Entity.IsRead) {
				PublishClientRemindingInfo("delete");
			}
			return true;
		}

		public virtual bool RemindingInsertedScriptTaskExecute(ProcessExecutingContext context) {
			OnInsertedHandle();
			return true;
		}

		public virtual bool RemindingInsertingScriptTaskExecute(ProcessExecutingContext context) {
			OnInsertingHandle();
			return true;
		}

		public virtual bool RemindingSavingScriptTaskExecute(ProcessExecutingContext context) {
			OnSavingHandler();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Reminding_Base_TerrasoftSaved":
							if (ActivatedEventElements.Contains("RemindingSavedStartMessage")) {
							context.QueueTasks.Enqueue("RemindingSavedStartMessage");
						}
						break;
					case "Reminding_Base_TerrasoftDeleted":
							if (ActivatedEventElements.Contains("RemindingDeletedStartMessage")) {
							context.QueueTasks.Enqueue("RemindingDeletedStartMessage");
						}
						break;
					case "Reminding_Base_TerrasoftInserted":
							if (ActivatedEventElements.Contains("RemindingInsertedStartMessage")) {
							context.QueueTasks.Enqueue("RemindingInsertedStartMessage");
						}
						break;
					case "Reminding_Base_TerrasoftInserting":
							if (ActivatedEventElements.Contains("RemindingInsertingStartMessage")) {
							context.QueueTasks.Enqueue("RemindingInsertingStartMessage");
						}
						break;
					case "Reminding_Base_TerrasoftSaving":
							if (ActivatedEventElements.Contains("RemindingSavingStartMessage")) {
							context.QueueTasks.Enqueue("RemindingSavingStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("IsRemindingPostponed") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsRemindingPostponed", IsRemindingPostponed, false);
			}
			if (!HasMapping("IsRemindingForImmediateSend") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsRemindingForImmediateSend", IsRemindingForImmediateSend, false);
			}
			if (!HasMapping("IsNew") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsNew", IsNew, false);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: Reminding_BaseEventsProcess

	/// <exclude/>
	public class Reminding_BaseEventsProcess : Reminding_BaseEventsProcess<Reminding_Base_Terrasoft>
	{

		public Reminding_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Reminding_BaseEventsProcess

	public partial class Reminding_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void PublishClientRemindingInfo(string operation) {
			string notificationGroup = TryGeNotificationTypeName();
			var remindTime = Entity.GetTypedColumnValue<DateTime>("RemindTime");
			if (remindTime > UserConnection.CurrentUser.GetCurrentDateTime() && !IsRemindingPostponed) {
				return;
			}
			var contactId = Entity.GetTypedColumnValue<Guid>("ContactId");
			var sysAdminUnit = GetSysAdminUnitIdByContactId(contactId);
			var isReadOld = Entity.GetTypedOldColumnValue<bool>("IsRead");
			var message = new {
				recordId = Entity.Id,
				operation,
				notificationGroup,
				markAsRead = !isReadOld && Entity.IsRead
			};
			var simpleMessage = new SimpleMessage {
				Body = JsonConvert.SerializeObject(message),
				Id = sysAdminUnit
			};
			simpleMessage.Header.Sender = "UpdateReminding";
			var manager = MsgChannelManager.Instance;
			var channel = manager.FindItemByUId(sysAdminUnit);
			channel?.PostMessage(simpleMessage);
		}

		public virtual Guid GetSysAdminUnitIdByContactId(Guid contactId) {
			var currentUser = UserConnection.CurrentUser;
			if (currentUser.ContactId == contactId) {
				return currentUser.Id;
			}
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var esq = new EntitySchemaQuery(entitySchemaManager, "SysAdminUnit") {
				UseAdminRights = false,
				IgnoreDisplayValues = true,
				CanReadUncommitedData = true,
				Cache = UserConnection.ApplicationCache.WithLocalCaching("NotificationUsers"),
				CacheItemName = contactId.ToString()
			};
			esq.PrimaryQueryColumn.IsAlwaysSelect = true;
			var queryFilterItem = esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Contact", contactId);
			esq.Filters.Add(queryFilterItem);
			var entities = esq.GetEntityCollection(UserConnection);
			if (entities.IsEmpty()) {
				return Guid.Empty;
			}
			var entity = entities.First.Value;
			return entity.GetTypedColumnValue<Guid>(esq.PrimaryQueryColumn.Name);
		}

		public virtual string GetSchemaName(ISchemaManager schemaManager, Guid entitySchemaId) {
			var schemaManagerItem = schemaManager.FindItemByUId(entitySchemaId);
			return schemaManagerItem != null ? schemaManagerItem.Name : string.Empty;
		}

		public virtual void OnInsertedHandle() {
			if (Entity.NotificationTypeId != RemindingConsts.NotificationTypeRemindingId ||
					IsRemindingForImmediateSend) {
				SendNotification();
				IsRemindingForImmediateSend = false;
			}
		}

		public virtual void OnInsertingHandle() {
			IsNew = true;
		}

		public virtual void OnSavingHandler() {
			if (Entity.NotificationTypeId == RemindingConsts.NotificationTypeRemindingId) {
				IsRemindingPostponed = GetIsRemindingPostponed();
				if (IsChangedTargetColumns()) {
					Entity.IsNeedToSend = true;
				}
				if (!IsCorrectRemindTime()) {
					Entity.IsNeedToSend = false;
					IsRemindingForImmediateSend = true;
				}
			} else if (Entity.StoringState == StoringObjectState.Changed) {
				var changedColumns = Entity.GetChangedColumnValues();
				if (changedColumns.Any(column => column.Name == "IsRead")) {
					PublishClientRemindingInfo("update");
				}
				if (IsChangedTargetColumns()) {
					IsRemindingForImmediateSend = true;
				}
			}
		}

		public virtual bool IsChangedTargetColumns() {
			IEnumerable<string> targetColumns = GetTargetColumnsForChange();
			var changedColumns = Entity.GetChangedColumnValues();
			return changedColumns.Any(column => targetColumns.Contains(column.Name));
		}

		public virtual IEnumerable<string>  GetTargetColumnsForChange() {
			return new[] {"RemindTime", "ContactId", "Description", "SubjectCaption"};
		}

		public virtual void OnSavedHandler() {
			if (IsRemindingForImmediateSend) {
				if (!Entity.IsRead) {
					PublishClientRemindingInfo("delete");
				}
				SendNotification();
				return;
			}
			if (Entity.NotificationTypeId == RemindingConsts.NotificationTypeRemindingId || !Entity.IsRead) {
				var operation = !IsCorrectRemindTime() ? "update" : "delete";
				if (UserConnection.GetIsFeatureEnabled("NotificationV2")) {
					if (IsNew) {
						return;
					}
				}
				PublishClientRemindingInfo(operation);
			}
		}

		public virtual bool IsCorrectRemindTime() {
			var currentDateTime = UserConnection.CurrentUser.GetCurrentDateTime();
			if (Entity.RemindTime <= currentDateTime) {
				return false;
			}
			return true;
		}

		public virtual void SendNotification() {
		}

		public virtual string TryGeNotificationTypeName() {
			var entitySchema = UserConnection.EntitySchemaManager.FindInstanceByName("NotificationType");
			var entity = entitySchema.CreateEntity(UserConnection);
			entity.FetchFromDB(entitySchema.PrimaryColumn.Name, Entity.NotificationTypeId,
				new[] {entitySchema.PrimaryDisplayColumn.Name});
			return entity.PrimaryDisplayColumnValue;
		}

		public virtual bool GetIsRemindingPostponed() {
			DateTime currentDateTime = UserConnection.CurrentUser.GetCurrentDateTime();
			bool oldNeedToSend = Entity.GetTypedOldColumnValue<bool>("IsNeedToSend");
			DateTime oldRemindTime = Entity.GetTypedOldColumnValue<DateTime>("RemindTime");
			DateTime newRemindTime = Entity.GetTypedColumnValue<DateTime>("RemindTime");
			bool oldRemindTimePassed = currentDateTime >= oldRemindTime && oldRemindTime != default(DateTime);
			bool remindTimeChanged = oldRemindTime != newRemindTime;
			return oldRemindTimePassed && remindTimeChanged && !oldNeedToSend;
		}

		#endregion

	}

	#endregion

	#region Class: Reminding_Base_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Reminding_Base_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public Reminding_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Reminding_Base_TerrasoftEventsProcessSchema(Reminding_Base_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Reminding_BaseEventsProcess";
			UId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9");
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

		protected virtual ProcessSchemaParameter CreateIsNewParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("65aa474d-1250-4069-b81e-f33e3d443aa6"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				Name = @"IsNew",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsRemindingForImmediateSendParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("eb0e950a-a64d-4f55-954e-5998efd076cb"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				Name = @"IsRemindingForImmediateSend",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsRemindingPostponedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c19c2eb0-c8ca-41c0-8206-083f63379de4"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				Name = @"IsRemindingPostponed",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateIsNewParameter());
			Parameters.Add(CreateIsRemindingForImmediateSendParameter());
			Parameters.Add(CreateIsRemindingPostponedParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet = CreateLaneSetLaneSet();
			LaneSets.Add(schemaLaneSet);
			ProcessSchemaLane schemaLane = CreateLaneLane();
			schemaLaneSet.Lanes.Add(schemaLane);
			ProcessSchemaEventSubProcess eventsubprocess = CreateEventSubProcessEventSubProcess();
			FlowElements.Add(eventsubprocess);
			ProcessSchemaStartMessageEvent remindingsavedstartmessage = CreateRemindingSavedStartMessageStartMessageEvent();
			eventsubprocess.FlowElements.Add(remindingsavedstartmessage);
			ProcessSchemaStartMessageEvent remindingdeletedstartmessage = CreateRemindingDeletedStartMessageStartMessageEvent();
			eventsubprocess.FlowElements.Add(remindingdeletedstartmessage);
			ProcessSchemaScriptTask remindingsavedscripttask = CreateRemindingSavedScriptTaskScriptTask();
			eventsubprocess.FlowElements.Add(remindingsavedscripttask);
			ProcessSchemaScriptTask remindingdeletedscripttask = CreateRemindingDeletedScriptTaskScriptTask();
			eventsubprocess.FlowElements.Add(remindingdeletedscripttask);
			ProcessSchemaScriptTask remindinginsertedscripttask = CreateRemindingInsertedScriptTaskScriptTask();
			eventsubprocess.FlowElements.Add(remindinginsertedscripttask);
			ProcessSchemaStartMessageEvent remindinginsertedstartmessage = CreateRemindingInsertedStartMessageStartMessageEvent();
			eventsubprocess.FlowElements.Add(remindinginsertedstartmessage);
			ProcessSchemaStartMessageEvent remindinginsertingstartmessage = CreateRemindingInsertingStartMessageStartMessageEvent();
			eventsubprocess.FlowElements.Add(remindinginsertingstartmessage);
			ProcessSchemaScriptTask remindinginsertingscripttask = CreateRemindingInsertingScriptTaskScriptTask();
			eventsubprocess.FlowElements.Add(remindinginsertingscripttask);
			ProcessSchemaStartMessageEvent remindingsavingstartmessage = CreateRemindingSavingStartMessageStartMessageEvent();
			eventsubprocess.FlowElements.Add(remindingsavingstartmessage);
			ProcessSchemaScriptTask remindingsavingscripttask = CreateRemindingSavingScriptTaskScriptTask();
			eventsubprocess.FlowElements.Add(remindingsavingscripttask);
			FlowElements.Add(CreateRemindingDeletedSequenceFlowSequenceFlow());
			FlowElements.Add(CreateRemindingSavedSequenceFlowSequenceFlow());
			FlowElements.Add(CreateSequenceFlow2_48f28fb0bedc43a9b11eb2aa2fc141ccSequenceFlow());
			FlowElements.Add(CreateSequenceFlow3_bc783b3f80b54809a81229868c3bac75SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4_0ab7fc2c67294102b70ecb7ca5297af1SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateRemindingDeletedSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "RemindingDeletedSequenceFlow",
				UId = new Guid("7df31ae1-dea3-4870-bc45-c9358037eead"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8a3e6264-0c74-497d-8a11-cebe83e81070"),
				CreatedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				CurveCenterPosition = new Point(169, 178),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("173f83e0-ef4f-4f09-a917-61f3b3683b81"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("828d3cfa-ce4a-4b39-997a-d7f7ae1afaa8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateRemindingSavedSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "RemindingSavedSequenceFlow",
				UId = new Guid("e099d7d7-3b4e-43a5-a124-e1b59328f8e9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8a3e6264-0c74-497d-8a11-cebe83e81070"),
				CreatedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				CurveCenterPosition = new Point(162, 74),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7bbd26e9-038c-4382-9ee6-93fb46a5f7f1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("77e54843-52d8-423e-bf43-fdef747add27"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2_48f28fb0bedc43a9b11eb2aa2fc141ccSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2_48f28fb0bedc43a9b11eb2aa2fc141cc",
				UId = new Guid("48f28fb0-bedc-43a9-b11e-b2aa2fc141cc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fc7a3594-a563-41fa-8acd-b945708aac81"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9cb08072-9b2c-4cfe-bbbc-ae52b90bb4f7"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3_bc783b3f80b54809a81229868c3bac75SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3_bc783b3f80b54809a81229868c3bac75",
				UId = new Guid("bc783b3f-80b5-4809-a812-29868c3bac75"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("79648fc8-fb36-456c-9fb8-55aac88b4cd8"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("39626b64-4c4c-4544-bb4c-50dbe21ff51d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4_0ab7fc2c67294102b70ecb7ca5297af1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4_0ab7fc2c67294102b70ecb7ca5297af1",
				UId = new Guid("0ab7fc2c-6729-4102-b70e-cb7ca5297af1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ec01b1b6-430f-47b0-b160-192b55711db6"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("afa34365-4752-4771-918b-bd18de0d6a41"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("51225c34-6386-4571-abee-1d6a6fc78c26"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8a3e6264-0c74-497d-8a11-cebe83e81070"),
				CreatedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				Name = @"LaneSet",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1057, 258),
				UseBackgroundMode = false
			};
			return schemaLaneSet;
		}

		protected virtual ProcessSchemaLane CreateLaneLane() {
			ProcessSchemaLane schemaLane = new ProcessSchemaLane(this) {
				UId = new Guid("431a6988-ee8d-4a57-adaa-5f709726b2b3"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("51225c34-6386-4571-abee-1d6a6fc78c26"),
				CreatedInOwnerSchemaUId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37"),
				CreatedInPackageId = new Guid("8a3e6264-0c74-497d-8a11-cebe83e81070"),
				CreatedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				Name = @"Lane",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1028, 258),
				UseBackgroundMode = false
			};
			return schemaLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("38f6f9be-5d9c-477e-901e-68eb4f2c5ab8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("431a6988-ee8d-4a57-adaa-5f709726b2b3"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8a3e6264-0c74-497d-8a11-cebe83e81070"),
				CreatedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				Name = @"EventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(140, 157),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(380, 472),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateRemindingSavedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7bbd26e9-038c-4382-9ee6-93fb46a5f7f1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("38f6f9be-5d9c-477e-901e-68eb4f2c5ab8"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8a3e6264-0c74-497d-8a11-cebe83e81070"),
				CreatedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"RemindingSaved",
				ModifiedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				Name = @"RemindingSavedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(22, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateRemindingDeletedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("173f83e0-ef4f-4f09-a917-61f3b3683b81"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("38f6f9be-5d9c-477e-901e-68eb4f2c5ab8"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8a3e6264-0c74-497d-8a11-cebe83e81070"),
				CreatedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"RemindingDeleted",
				ModifiedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				Name = @"RemindingDeletedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(22, 149),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateRemindingSavedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("77e54843-52d8-423e-bf43-fdef747add27"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("38f6f9be-5d9c-477e-901e-68eb4f2c5ab8"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8a3e6264-0c74-497d-8a11-cebe83e81070"),
				CreatedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				Name = @"RemindingSavedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(113, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,11,78,44,75,77,241,72,204,75,201,73,45,210,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,250,84,179,52,31,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateRemindingDeletedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("828d3cfa-ce4a-4b39-997a-d7f7ae1afaa8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("38f6f9be-5d9c-477e-901e-68eb4f2c5ab8"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8a3e6264-0c74-497d-8a11-cebe83e81070"),
				CreatedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				Name = @"RemindingDeletedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(113, 135),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,80,116,205,43,201,44,169,212,243,44,14,74,77,76,209,84,168,230,229,226,12,40,77,202,201,44,206,112,206,201,76,205,43,9,74,205,205,204,75,201,204,75,247,204,75,203,215,80,74,73,205,73,45,73,85,210,180,230,229,170,229,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,90,141,65,42,78,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateRemindingInsertedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9cb08072-9b2c-4cfe-bbbc-ae52b90bb4f7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("38f6f9be-5d9c-477e-901e-68eb4f2c5ab8"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				Name = @"RemindingInsertedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(113, 217),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,243,204,43,78,45,42,73,77,241,72,204,75,201,73,213,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,40,163,82,126,32,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateRemindingInsertedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("fc7a3594-a563-41fa-8acd-b945708aac81"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("38f6f9be-5d9c-477e-901e-68eb4f2c5ab8"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"RemindingInserted",
				ModifiedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				Name = @"RemindingInsertedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(33, 231),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateRemindingInsertingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("79648fc8-fb36-456c-9fb8-55aac88b4cd8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("38f6f9be-5d9c-477e-901e-68eb4f2c5ab8"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"RemindingInserting",
				ModifiedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				Name = @"RemindingInsertingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(33, 320),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateRemindingInsertingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("39626b64-4c4c-4544-bb4c-50dbe21ff51d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("38f6f9be-5d9c-477e-901e-68eb4f2c5ab8"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				Name = @"RemindingInsertingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(113, 306),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,243,204,43,78,45,42,201,204,75,247,72,204,75,201,73,213,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,121,236,70,247,33,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateRemindingSavingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ec01b1b6-430f-47b0-b160-192b55711db6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("38f6f9be-5d9c-477e-901e-68eb4f2c5ab8"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"RemindingSaving",
				ModifiedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				Name = @"RemindingSavingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(33, 396),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateRemindingSavingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("afa34365-4752-4771-918b-bd18de0d6a41"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("38f6f9be-5d9c-477e-901e-68eb4f2c5ab8"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				Name = @"RemindingSavingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(113, 382),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,11,78,44,203,204,75,247,72,204,75,201,73,45,210,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,110,148,149,139,31,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreatePublishClientRemindingInfoMethod());
			Methods.Add(CreateGetSysAdminUnitIdByContactIdMethod());
			Methods.Add(CreateGetSchemaNameMethod());
			Methods.Add(CreateOnInsertedHandleMethod());
			Methods.Add(CreateOnInsertingHandleMethod());
			Methods.Add(CreateOnSavingHandlerMethod());
			Methods.Add(CreateIsChangedTargetColumnsMethod());
			Methods.Add(CreateGetTargetColumnsForChangeMethod());
			Methods.Add(CreateOnSavedHandlerMethod());
			Methods.Add(CreateIsCorrectRemindTimeMethod());
			Methods.Add(CreateSendNotificationMethod());
			Methods.Add(CreateTryGeNotificationTypeNameMethod());
			Methods.Add(CreateGetIsRemindingPostponedMethod());
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
				UId = new Guid("e9f2af36-5bd4-4011-bdf7-7a9a1a840361"),
				Name = "Terrasoft.Messaging.Common",
				Alias = "",
				CreatedInPackageId = new Guid("8a3e6264-0c74-497d-8a11-cebe83e81070")
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
				UId = new Guid("9cde8651-42c6-49d7-b787-c753a3038298"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b8e6bd6a-2d7c-4f2e-a093-60e828990868"),
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

		protected virtual SchemaMethod CreatePublishClientRemindingInfoMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("90c32ad8-b1cc-4e43-abfc-cdfdfaf313d1"),
				Name = "PublishClientRemindingInfo",
				CreatedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				CreatedInPackageId = new Guid("8a3e6264-0c74-497d-8a11-cebe83e81070"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("140a7c22-ab94-42d3-8e98-e41747b208fc"),
				Name = "operation",
				CreatedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				ModifiedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("8a3e6264-0c74-497d-8a11-cebe83e81070")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,82,203,78,195,48,16,60,83,169,255,224,230,128,18,9,229,7,10,69,109,128,18,164,182,136,182,220,221,120,91,12,201,58,178,157,162,128,248,119,214,121,145,10,196,201,242,120,118,102,118,215,198,106,137,7,134,202,202,189,76,184,149,10,231,90,21,57,187,98,27,93,206,97,217,123,216,148,57,44,121,6,126,48,30,14,142,92,51,13,153,68,177,145,25,16,253,22,173,180,101,56,7,235,120,34,82,105,145,225,51,79,11,184,188,225,22,28,107,226,123,79,93,137,231,84,228,158,249,61,149,9,219,26,208,145,66,132,196,57,134,81,161,53,160,117,168,83,110,174,173,158,31,176,243,115,54,138,77,173,74,141,60,42,99,115,133,32,2,246,57,28,156,105,176,133,70,242,249,170,3,39,10,45,79,108,44,254,207,59,47,164,160,172,81,203,246,218,134,77,105,166,130,172,182,40,45,73,80,237,186,135,196,98,86,118,53,126,231,213,22,75,138,201,197,42,253,195,156,192,190,255,78,169,148,252,227,170,160,51,207,192,24,126,112,163,70,120,111,218,75,148,22,253,110,98,113,65,184,202,65,87,27,115,151,95,171,117,96,198,245,219,180,146,167,218,209,79,50,26,103,171,84,97,52,185,182,117,153,229,41,44,78,50,172,79,48,151,104,166,68,73,143,15,70,33,77,226,8,218,134,107,208,146,167,242,3,86,187,87,218,170,223,180,17,184,24,85,244,254,80,107,191,19,175,240,158,114,208,250,215,128,116,16,223,219,230,130,62,64,183,115,175,157,15,71,162,59,198,194,28,162,23,78,159,40,93,212,88,24,163,177,28,19,104,168,73,253,74,212,166,40,188,35,173,216,66,54,43,183,180,187,126,36,55,254,134,127,29,186,255,213,228,242,79,82,6,227,111,236,218,4,106,74,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSysAdminUnitIdByContactIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f786ab55-ce6c-47b5-b675-b715c85bab38"),
				Name = "GetSysAdminUnitIdByContactId",
				CreatedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				CreatedInPackageId = new Guid("8a3e6264-0c74-497d-8a11-cebe83e81070"),
				ResultValueTypeName = "Guid"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ad656689-3370-44a7-a049-50eb142f09c4"),
				Name = "contactId",
				CreatedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				ModifiedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("8a3e6264-0c74-497d-8a11-cebe83e81070")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,82,219,106,227,48,16,125,222,64,254,65,248,201,134,160,31,200,166,16,220,180,24,118,75,183,105,186,207,131,53,73,4,186,56,210,184,197,44,251,239,29,217,78,235,244,242,100,107,230,92,70,71,243,12,65,212,109,8,232,104,23,49,136,149,72,159,210,59,135,53,105,239,100,249,222,92,206,103,122,47,242,9,92,50,144,160,166,74,137,213,74,212,231,67,33,254,205,103,63,2,82,27,220,84,93,86,138,53,254,207,103,207,236,202,53,77,221,182,62,162,133,223,224,224,240,149,251,230,51,104,57,210,227,137,225,14,95,196,20,243,167,197,208,229,95,72,47,68,182,237,226,90,89,237,118,78,83,54,140,200,110,125,233,65,31,142,20,89,111,15,38,226,130,59,213,193,249,128,215,58,54,6,186,39,48,45,166,54,133,182,239,150,224,30,16,212,206,213,222,90,77,168,174,129,224,162,207,222,159,111,179,110,26,163,107,72,255,61,66,254,213,116,252,229,107,48,233,168,221,33,207,238,60,233,253,136,73,236,152,21,111,130,21,161,189,3,155,132,223,162,150,143,126,75,33,81,11,78,150,179,225,92,228,125,208,22,66,215,135,81,122,211,90,39,171,184,54,47,208,197,45,26,30,102,28,117,140,242,148,112,55,218,16,134,100,193,205,36,82,6,4,194,161,156,230,188,135,192,222,124,136,249,80,44,189,109,32,232,232,221,99,215,160,220,156,90,48,28,243,184,18,217,98,178,15,227,92,3,47,202,181,82,249,7,211,98,57,217,10,221,135,157,24,183,72,195,243,242,53,204,144,98,126,25,106,49,110,229,153,200,55,221,216,134,186,188,184,216,194,219,86,43,217,55,62,110,96,114,58,115,111,116,136,36,251,231,102,216,72,29,96,105,148,116,79,53,4,218,99,126,38,213,171,252,155,200,211,83,21,203,87,26,133,201,55,97,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSchemaNameMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("211075a0-c7b7-47a6-930c-1fc306da2fbf"),
				Name = "GetSchemaName",
				CreatedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9c67d504-b8af-48ba-81a1-8d8d5aa8ff07"),
				Name = "schemaManager",
				CreatedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				ModifiedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ISchemaManager",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("747c000c-b6c1-455c-aac1-a065f6917622"),
				Name = "entitySchemaId",
				CreatedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				ModifiedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,40,78,206,72,205,77,244,77,204,75,76,79,45,242,44,73,205,85,176,69,21,211,115,203,204,75,1,73,56,85,134,122,166,104,164,230,149,100,150,84,6,131,85,120,166,104,90,243,114,21,165,150,148,22,229,97,49,72,209,86,33,175,52,39,71,193,30,83,78,207,47,49,55,85,193,74,161,184,164,40,51,47,93,207,53,183,160,164,210,26,0,193,89,90,35,143,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnInsertedHandleMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7f5e7908-1e3e-4e28-a57a-0f4386a3eefe"),
				Name = "OnInsertedHandle",
				CreatedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,112,205,43,201,44,169,212,243,203,47,201,76,203,76,78,44,201,204,207,11,169,44,72,245,76,81,80,180,85,8,74,205,205,204,75,201,204,75,119,206,207,43,46,41,198,80,5,151,7,42,175,169,225,226,228,244,44,134,11,185,229,23,121,230,230,166,166,100,38,150,164,6,167,230,165,104,42,84,115,113,130,24,200,134,104,104,90,115,225,211,164,96,171,144,150,152,83,156,106,205,85,11,0,161,26,13,3,173,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnInsertingHandleMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("09aaef59-96fe-4d2b-a2ff-5457383d4ec4"),
				Name = "OnInsertingHandle",
				CreatedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,44,246,75,45,87,176,85,40,41,42,77,181,6,0,147,140,59,64,13,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnSavingHandlerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a21435fb-010f-4148-80bf-634ea46b9629"),
				Name = "OnSavingHandler",
				CreatedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,81,203,110,131,48,16,60,147,175,112,57,193,133,31,168,168,84,161,54,242,133,70,5,245,238,224,37,217,10,219,200,94,42,161,42,255,94,3,22,164,15,69,189,237,107,102,103,103,177,101,201,147,38,164,49,43,13,97,139,141,32,52,186,30,123,224,146,229,57,123,5,133,90,162,62,21,70,59,114,191,166,214,62,151,41,251,220,69,220,173,149,131,113,212,27,13,158,135,237,129,254,234,36,233,253,46,66,175,129,187,226,44,244,9,100,45,236,9,168,48,221,160,180,75,210,153,51,10,10,185,43,193,79,152,10,244,196,73,118,0,15,191,44,12,119,158,194,88,11,13,45,107,106,84,112,27,223,138,206,77,4,215,154,159,141,229,74,129,68,65,240,115,205,133,129,7,48,220,44,171,200,88,15,170,200,79,79,102,133,252,229,248,238,101,204,213,44,156,53,235,248,16,150,53,75,30,14,244,244,129,202,27,84,92,183,222,68,55,128,91,253,249,14,203,30,245,152,52,115,204,242,7,182,68,89,41,212,172,34,158,238,17,50,14,199,31,134,99,135,238,92,116,8,154,182,119,233,214,36,241,208,75,47,50,78,55,27,111,63,226,191,78,125,1,33,215,125,182,87,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateIsChangedTargetColumnsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("261ab6a7-dad8-4cc3-9896-03c3284a47e8"),
				Name = "IsChangedTargetColumns",
				CreatedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,142,77,10,194,48,16,133,247,158,98,150,205,38,23,168,21,36,84,113,211,149,116,63,214,33,6,146,9,76,38,66,111,95,45,130,165,187,247,247,193,187,245,92,19,9,62,34,29,139,74,96,127,2,69,241,164,46,199,154,184,64,7,87,210,251,54,186,100,113,47,100,79,141,105,15,111,20,152,86,247,252,19,61,107,208,217,126,64,183,173,70,140,149,202,151,18,210,42,188,3,237,153,231,102,90,53,116,187,27,214,101,86,12,92,126,3,59,96,34,99,218,5,102,100,177,203,192,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetTargetColumnsForChangeMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9a3bf7f4-dc3e-4d70-9344-e7b8fbfc67e8"),
				Name = "GetTargetColumnsForChange",
				CreatedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "IEnumerable<string> "
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,143,142,85,168,86,10,74,205,205,204,75,9,201,204,77,85,210,81,80,114,206,207,43,73,76,46,241,76,1,113,92,82,139,147,139,50,11,74,50,243,243,64,220,224,210,164,172,212,228,18,231,68,136,72,173,53,0,231,13,208,179,74,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnSavedHandlerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("347fe102-586d-4a4e-a8fd-5f2569a47081"),
				Name = "OnSavedHandler",
				CreatedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,49,79,195,48,16,133,103,231,87,92,61,57,75,7,70,162,136,33,106,145,151,170,42,133,221,173,47,112,82,114,142,108,7,84,209,252,119,156,166,132,74,32,36,47,62,189,123,247,222,71,53,40,29,118,216,18,91,226,215,181,243,186,109,209,146,137,248,132,108,115,248,204,4,37,205,98,197,145,226,105,57,106,205,52,22,219,254,208,80,120,171,26,66,142,179,133,230,218,41,105,177,193,136,50,47,50,49,100,98,180,218,184,72,53,29,77,36,199,106,156,123,140,189,231,34,27,178,241,192,213,255,86,181,63,117,168,45,148,37,204,230,149,227,16,195,47,213,207,113,11,231,51,252,17,246,221,120,112,29,250,203,10,148,176,208,161,114,222,227,241,26,124,79,45,170,28,30,64,246,157,77,229,37,220,195,119,137,98,66,240,28,208,167,251,156,118,146,199,242,17,163,14,107,52,169,4,174,216,28,26,180,74,222,6,123,185,147,249,4,138,46,144,55,248,49,125,231,230,98,100,147,222,63,32,231,204,137,216,240,5,166,128,192,144,173,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateIsCorrectRemindTimeMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("fea5d283-a873-4ba9-b3ea-233705d8c161"),
				Name = "IsCorrectRemindTime",
				CreatedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,46,45,42,74,205,43,113,73,44,73,13,201,204,77,85,176,85,8,45,78,45,114,206,207,203,75,77,46,201,204,207,211,115,134,40,0,137,234,185,167,150,56,163,170,215,208,180,230,202,76,83,208,112,205,43,201,44,169,212,11,74,205,205,204,75,1,27,100,99,139,110,182,166,66,53,23,103,81,106,73,105,81,158,66,90,98,78,113,170,53,87,45,23,148,95,82,84,154,106,13,0,225,238,239,154,144,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSendNotificationMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d09f7210-80e3-4ac0-92f8-769869a2496b"),
				Name = "SendNotification",
				CreatedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] {  };
			return method;
		}

		protected virtual SchemaMethod CreateTryGeNotificationTypeNameMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d08c7b92-7d8c-4481-a1c2-25512f352e8a"),
				Name = "TryGeNotificationTypeName",
				CreatedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,142,205,10,194,48,16,132,207,10,190,67,240,84,161,228,5,138,23,171,133,30,44,130,63,23,241,176,196,213,6,154,77,217,166,149,32,190,187,134,138,84,241,60,51,223,124,29,176,64,114,218,249,173,42,209,128,152,139,125,131,156,90,34,84,78,91,146,171,65,186,6,130,43,178,204,52,157,115,106,28,144,194,133,47,192,96,52,45,172,211,23,173,32,140,118,190,198,233,44,153,140,187,15,254,5,30,254,200,148,17,28,246,240,232,251,50,12,251,174,204,208,169,50,99,107,150,139,232,107,190,97,109,128,125,106,171,214,144,12,6,177,232,97,242,87,36,63,199,147,241,136,240,118,60,137,251,63,200,82,55,117,5,67,214,35,40,48,186,150,233,109,253,183,123,128,170,197,228,9,234,255,38,179,67,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsRemindingPostponedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("bdda464b-be6d-4e17-b192-6d96167c2d60"),
				Name = "GetIsRemindingPostponed",
				CreatedInSchemaUId = new Guid("529fada2-7561-4905-904c-325ef47bb6e9"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,145,65,14,130,48,16,69,247,38,222,1,88,16,220,112,1,133,77,53,198,141,26,69,247,149,142,218,164,76,77,105,99,184,189,173,10,4,48,196,37,63,243,222,204,47,75,170,33,227,5,120,185,81,10,80,47,235,239,196,59,149,160,136,68,132,92,115,137,49,249,12,184,52,94,131,38,221,249,104,54,159,78,46,82,10,79,10,182,5,96,153,60,2,50,171,89,161,230,186,114,72,86,61,128,237,4,35,82,152,2,207,84,24,88,56,36,141,130,77,217,50,129,83,53,119,88,221,1,10,142,236,123,213,184,174,198,172,178,165,186,66,132,231,152,240,63,91,221,180,141,247,180,44,193,245,237,63,100,154,244,58,132,97,47,240,19,143,193,149,26,161,163,154,106,118,168,102,140,220,41,222,222,27,6,116,167,146,37,21,104,163,240,231,125,118,249,80,105,67,191,243,219,172,227,5,154,238,103,240,25,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Reminding_Base_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("529fada2-7561-4905-904c-325ef47bb6e9"));
		}

		#endregion

	}

	#endregion

}

