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

	#region Class: EmailTemplate_Base_TerrasoftSchema

	/// <exclude/>
	public class EmailTemplate_Base_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public EmailTemplate_Base_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public EmailTemplate_Base_TerrasoftSchema(EmailTemplate_Base_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public EmailTemplate_Base_TerrasoftSchema(EmailTemplate_Base_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("93030575-f70f-4041-902e-c4badaf62c63");
			RealUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63");
			Name = "EmailTemplate_Base_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
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
			if (Columns.FindByUId(new Guid("26bd9f25-0d50-4c47-829f-8b286576317c")) == null) {
				Columns.Add(CreateObjectColumn());
			}
			if (Columns.FindByUId(new Guid("382c1794-3e8d-4895-91ce-02c9f5e3553e")) == null) {
				Columns.Add(CreateRecipientColumn());
			}
			if (Columns.FindByUId(new Guid("085d7c7c-fdbc-443a-ad06-1f04ace34173")) == null) {
				Columns.Add(CreateCopyRecipientColumn());
			}
			if (Columns.FindByUId(new Guid("47e72ecd-b21c-4b09-933e-6c1263381425")) == null) {
				Columns.Add(CreateBlindCopyRecipientColumn());
			}
			if (Columns.FindByUId(new Guid("2e7c35e3-0774-4a4a-bea5-6ce4c8de1465")) == null) {
				Columns.Add(CreateSubjectColumn());
			}
			if (Columns.FindByUId(new Guid("feab52f3-9df5-4499-8425-855973838905")) == null) {
				Columns.Add(CreatePriorityColumn());
			}
			if (Columns.FindByUId(new Guid("54425b16-8b5b-40a1-baf1-3997560a6b0e")) == null) {
				Columns.Add(CreateBodyColumn());
			}
			if (Columns.FindByUId(new Guid("698c2960-3832-4ba4-ad56-8a6489b32ad4")) == null) {
				Columns.Add(CreateIsHtmlBodyColumn());
			}
			if (Columns.FindByUId(new Guid("e6618002-83f7-419a-a866-63ea7599b123")) == null) {
				Columns.Add(CreateMacrosColumn());
			}
			if (Columns.FindByUId(new Guid("cf75d513-0d42-439c-b19f-8c7fe4234460")) == null) {
				Columns.Add(CreateSendIndividualEmailColumn());
			}
			if (Columns.FindByUId(new Guid("613d189f-c6a0-4ec4-b2b0-a43199cacef4")) == null) {
				Columns.Add(CreateSaveAsActivityColumn());
			}
			if (Columns.FindByUId(new Guid("b1b8aa8c-787f-42e0-8af1-603d1761f75a")) == null) {
				Columns.Add(CreateObjectFieldInActivityColumn());
			}
			if (Columns.FindByUId(new Guid("aa4c5784-7f68-47d8-b7bb-ee3f89221ac8")) == null) {
				Columns.Add(CreateShowBeforeSendingColumn());
			}
			if (Columns.FindByUId(new Guid("b4972436-c042-4a3b-a025-f04575f10532")) == null) {
				Columns.Add(CreateTemplateConfigColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63");
			return column;
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("ca53e2c8-0767-4f2c-8a18-2ee5821f134e"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63"),
				ModifiedInSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateObjectColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("26bd9f25-0d50-4c47-829f-8b286576317c"),
				Name = @"Object",
				ReferenceSchemaUId = new Guid("90fa6d02-3e93-45d6-a72b-58dcffa411ae"),
				IsIndexed = true,
				IsWeakReference = true,
				CreatedInSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63"),
				ModifiedInSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateRecipientColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Binary")) {
				UId = new Guid("382c1794-3e8d-4895-91ce-02c9f5e3553e"),
				Name = @"Recipient",
				CreatedInSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63"),
				ModifiedInSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateCopyRecipientColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Binary")) {
				UId = new Guid("085d7c7c-fdbc-443a-ad06-1f04ace34173"),
				Name = @"CopyRecipient",
				CreatedInSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63"),
				ModifiedInSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateBlindCopyRecipientColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Binary")) {
				UId = new Guid("47e72ecd-b21c-4b09-933e-6c1263381425"),
				Name = @"BlindCopyRecipient",
				CreatedInSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63"),
				ModifiedInSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSubjectColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("2e7c35e3-0774-4a4a-bea5-6ce4c8de1465"),
				Name = @"Subject",
				CreatedInSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63"),
				ModifiedInSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreatePriorityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("feab52f3-9df5-4499-8425-855973838905"),
				Name = @"Priority",
				ReferenceSchemaUId = new Guid("b934f48c-5dea-49b9-bde3-697cb4be5d8b"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63"),
				ModifiedInSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateBodyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("54425b16-8b5b-40a1-baf1-3997560a6b0e"),
				Name = @"Body",
				CreatedInSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63"),
				ModifiedInSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateIsHtmlBodyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("698c2960-3832-4ba4-ad56-8a6489b32ad4"),
				Name = @"IsHtmlBody",
				CreatedInSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63"),
				ModifiedInSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateMacrosColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Binary")) {
				UId = new Guid("e6618002-83f7-419a-a866-63ea7599b123"),
				Name = @"Macros",
				CreatedInSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63"),
				ModifiedInSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSendIndividualEmailColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("cf75d513-0d42-439c-b19f-8c7fe4234460"),
				Name = @"SendIndividualEmail",
				ReferenceSchemaUId = new Guid("4faa5635-4485-41d9-bd19-6692a41c4e19"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63"),
				ModifiedInSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"e75ac3fe-be9b-4a01-87db-c7dffd354f8c"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateSaveAsActivityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("613d189f-c6a0-4ec4-b2b0-a43199cacef4"),
				Name = @"SaveAsActivity",
				CreatedInSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63"),
				ModifiedInSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateObjectFieldInActivityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("b1b8aa8c-787f-42e0-8af1-603d1761f75a"),
				Name = @"ObjectFieldInActivity",
				CreatedInSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63"),
				ModifiedInSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateShowBeforeSendingColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("aa4c5784-7f68-47d8-b7bb-ee3f89221ac8"),
				Name = @"ShowBeforeSending",
				CreatedInSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63"),
				ModifiedInSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateTemplateConfigColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("b4972436-c042-4a3b-a025-f04575f10532"),
				Name = @"TemplateConfig",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63"),
				ModifiedInSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63"),
				CreatedInPackageId = new Guid("c7ae8823-851f-4a36-b6d4-2ab23c1078fe"),
				IsLocalizable = true
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateEmailTemplate_Base_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateEmailTemplate_Base_TerrasoftEventsProcessSchema() {
			var schema = new EmailTemplate_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new EmailTemplate_Base_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new EmailTemplate_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new EmailTemplate_Base_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new EmailTemplate_Base_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("93030575-f70f-4041-902e-c4badaf62c63"));
		}

		#endregion

	}

	#endregion

	#region Class: EmailTemplate_Base_Terrasoft

	/// <summary>
	/// Email message template.
	/// </summary>
	public class EmailTemplate_Base_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public EmailTemplate_Base_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "EmailTemplate_Base_Terrasoft";
		}

		public EmailTemplate_Base_Terrasoft(EmailTemplate_Base_Terrasoft source)
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
		public Guid ObjectId {
			get {
				return GetTypedColumnValue<Guid>("ObjectId");
			}
			set {
				SetColumnValue("ObjectId", value);
				_object = null;
			}
		}

		/// <exclude/>
		public string ObjectCaption {
			get {
				return GetTypedColumnValue<string>("ObjectCaption");
			}
			set {
				SetColumnValue("ObjectCaption", value);
				if (_object != null) {
					_object.Caption = value;
				}
			}
		}

		private VwSysSchemaInfo _object;
		/// <summary>
		/// Object.
		/// </summary>
		public VwSysSchemaInfo Object {
			get {
				return _object ??
					(_object = LookupColumnEntities.GetEntity("Object") as VwSysSchemaInfo);
			}
		}

		/// <summary>
		/// Subject.
		/// </summary>
		public string Subject {
			get {
				return GetTypedColumnValue<string>("Subject");
			}
			set {
				SetColumnValue("Subject", value);
			}
		}

		/// <exclude/>
		public Guid PriorityId {
			get {
				return GetTypedColumnValue<Guid>("PriorityId");
			}
			set {
				SetColumnValue("PriorityId", value);
				_priority = null;
			}
		}

		/// <exclude/>
		public string PriorityName {
			get {
				return GetTypedColumnValue<string>("PriorityName");
			}
			set {
				SetColumnValue("PriorityName", value);
				if (_priority != null) {
					_priority.Name = value;
				}
			}
		}

		private ActivityPriority _priority;
		/// <summary>
		/// Priority.
		/// </summary>
		public ActivityPriority Priority {
			get {
				return _priority ??
					(_priority = LookupColumnEntities.GetEntity("Priority") as ActivityPriority);
			}
		}

		/// <summary>
		/// Body.
		/// </summary>
		public string Body {
			get {
				return GetTypedColumnValue<string>("Body");
			}
			set {
				SetColumnValue("Body", value);
			}
		}

		/// <summary>
		/// HTML-formatted body.
		/// </summary>
		public bool IsHtmlBody {
			get {
				return GetTypedColumnValue<bool>("IsHtmlBody");
			}
			set {
				SetColumnValue("IsHtmlBody", value);
			}
		}

		/// <exclude/>
		public Guid SendIndividualEmailId {
			get {
				return GetTypedColumnValue<Guid>("SendIndividualEmailId");
			}
			set {
				SetColumnValue("SendIndividualEmailId", value);
				_sendIndividualEmail = null;
			}
		}

		/// <exclude/>
		public string SendIndividualEmailName {
			get {
				return GetTypedColumnValue<string>("SendIndividualEmailName");
			}
			set {
				SetColumnValue("SendIndividualEmailName", value);
				if (_sendIndividualEmail != null) {
					_sendIndividualEmail.Name = value;
				}
			}
		}

		private EmailTemplateSendFlag _sendIndividualEmail;
		/// <summary>
		/// Send personal email message to each recipient.
		/// </summary>
		public EmailTemplateSendFlag SendIndividualEmail {
			get {
				return _sendIndividualEmail ??
					(_sendIndividualEmail = LookupColumnEntities.GetEntity("SendIndividualEmail") as EmailTemplateSendFlag);
			}
		}

		/// <summary>
		/// Save as activity.
		/// </summary>
		public bool SaveAsActivity {
			get {
				return GetTypedColumnValue<bool>("SaveAsActivity");
			}
			set {
				SetColumnValue("SaveAsActivity", value);
			}
		}

		/// <summary>
		/// Object connection field.
		/// </summary>
		public Guid ObjectFieldInActivity {
			get {
				return GetTypedColumnValue<Guid>("ObjectFieldInActivity");
			}
			set {
				SetColumnValue("ObjectFieldInActivity", value);
			}
		}

		/// <summary>
		/// Open activity card before sending.
		/// </summary>
		public bool ShowBeforeSending {
			get {
				return GetTypedColumnValue<bool>("ShowBeforeSending");
			}
			set {
				SetColumnValue("ShowBeforeSending", value);
			}
		}

		/// <summary>
		/// TemplateConfig.
		/// </summary>
		public string TemplateConfig {
			get {
				return GetTypedColumnValue<string>("TemplateConfig");
			}
			set {
				SetColumnValue("TemplateConfig", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new EmailTemplate_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("EmailTemplate_Base_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("EmailTemplate_Base_TerrasoftDeleting", e);
			Inserting += (s, e) => ThrowEvent("EmailTemplate_Base_TerrasoftInserting", e);
			Saving += (s, e) => ThrowEvent("EmailTemplate_Base_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("EmailTemplate_Base_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new EmailTemplate_Base_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: EmailTemplate_BaseEventsProcess

	/// <exclude/>
	public partial class EmailTemplate_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : EmailTemplate_Base_Terrasoft
	{

		public EmailTemplate_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "EmailTemplate_BaseEventsProcess";
			SchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("93030575-f70f-4041-902e-c4badaf62c63");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _emailTemplateEventSubProcess;
		public ProcessFlowElement EmailTemplateEventSubProcess {
			get {
				return _emailTemplateEventSubProcess ?? (_emailTemplateEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EmailTemplateEventSubProcess",
					SchemaElementUId = new Guid("9a4fbdfc-4eb0-4dc1-825b-f0a88f58836d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _emailTemplateInsertingStartMessage;
		public ProcessFlowElement EmailTemplateInsertingStartMessage {
			get {
				return _emailTemplateInsertingStartMessage ?? (_emailTemplateInsertingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "EmailTemplateInsertingStartMessage",
					SchemaElementUId = new Guid("1f309623-69c1-4cbb-b9f0-77c0fee4a88d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _emailTemplateSavingStartMessage;
		public ProcessFlowElement EmailTemplateSavingStartMessage {
			get {
				return _emailTemplateSavingStartMessage ?? (_emailTemplateSavingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "EmailTemplateSavingStartMessage",
					SchemaElementUId = new Guid("3bda745f-4adc-4074-a069-5e99c9f16b69"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _emailTemplateDeletingStartMessage;
		public ProcessFlowElement EmailTemplateDeletingStartMessage {
			get {
				return _emailTemplateDeletingStartMessage ?? (_emailTemplateDeletingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "EmailTemplateDeletingStartMessage",
					SchemaElementUId = new Guid("f3dbfad1-9404-4556-842a-9f600c540c35"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _checkCanManageLookupsScriptTask;
		public ProcessScriptTask CheckCanManageLookupsScriptTask {
			get {
				return _checkCanManageLookupsScriptTask ?? (_checkCanManageLookupsScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CheckCanManageLookupsScriptTask",
					SchemaElementUId = new Guid("ca153e72-b0ee-4c6b-91b6-6ca9753799aa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CheckCanManageLookupsScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EmailTemplateEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { EmailTemplateEventSubProcess };
			FlowElements[EmailTemplateInsertingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EmailTemplateInsertingStartMessage };
			FlowElements[EmailTemplateSavingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EmailTemplateSavingStartMessage };
			FlowElements[EmailTemplateDeletingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EmailTemplateDeletingStartMessage };
			FlowElements[CheckCanManageLookupsScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckCanManageLookupsScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EmailTemplateEventSubProcess":
						break;
					case "EmailTemplateInsertingStartMessage":
						e.Context.QueueTasks.Enqueue("CheckCanManageLookupsScriptTask");
						break;
					case "EmailTemplateSavingStartMessage":
						e.Context.QueueTasks.Enqueue("CheckCanManageLookupsScriptTask");
						break;
					case "EmailTemplateDeletingStartMessage":
						e.Context.QueueTasks.Enqueue("CheckCanManageLookupsScriptTask");
						break;
					case "CheckCanManageLookupsScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("EmailTemplateInsertingStartMessage");
			ActivatedEventElements.Add("EmailTemplateSavingStartMessage");
			ActivatedEventElements.Add("EmailTemplateDeletingStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EmailTemplateEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "EmailTemplateInsertingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "EmailTemplateInsertingStartMessage";
					result = EmailTemplateInsertingStartMessage.Execute(context);
					break;
				case "EmailTemplateSavingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "EmailTemplateSavingStartMessage";
					result = EmailTemplateSavingStartMessage.Execute(context);
					break;
				case "EmailTemplateDeletingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "EmailTemplateDeletingStartMessage";
					result = EmailTemplateDeletingStartMessage.Execute(context);
					break;
				case "CheckCanManageLookupsScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CheckCanManageLookupsScriptTask";
					result = CheckCanManageLookupsScriptTask.Execute(context, CheckCanManageLookupsScriptTaskExecute);
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

		public virtual bool CheckCanManageLookupsScriptTaskExecute(ProcessExecutingContext context) {
			UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageLookups");
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "EmailTemplate_Base_TerrasoftInserting":
							if (ActivatedEventElements.Contains("EmailTemplateInsertingStartMessage")) {
							context.QueueTasks.Enqueue("EmailTemplateInsertingStartMessage");
						}
						break;
					case "EmailTemplate_Base_TerrasoftSaving":
							if (ActivatedEventElements.Contains("EmailTemplateSavingStartMessage")) {
							context.QueueTasks.Enqueue("EmailTemplateSavingStartMessage");
						}
						break;
					case "EmailTemplate_Base_TerrasoftDeleting":
							if (ActivatedEventElements.Contains("EmailTemplateDeletingStartMessage")) {
							context.QueueTasks.Enqueue("EmailTemplateDeletingStartMessage");
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

	#region Class: EmailTemplate_BaseEventsProcess

	/// <exclude/>
	public class EmailTemplate_BaseEventsProcess : EmailTemplate_BaseEventsProcess<EmailTemplate_Base_Terrasoft>
	{

		public EmailTemplate_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: EmailTemplate_BaseEventsProcess

	public partial class EmailTemplate_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: EmailTemplate_Base_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class EmailTemplate_Base_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public EmailTemplate_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public EmailTemplate_Base_TerrasoftEventsProcessSchema(EmailTemplate_Base_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "EmailTemplate_BaseEventsProcess";
			UId = new Guid("efc63865-6d60-4074-83b9-f5ff2ec419fc");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
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
			ProcessSchemaLaneSet schemaEmailTemplateLaneSet = CreateEmailTemplateLaneSetLaneSet();
			LaneSets.Add(schemaEmailTemplateLaneSet);
			ProcessSchemaLane schemaEmailTemplateLane = CreateEmailTemplateLaneLane();
			schemaEmailTemplateLaneSet.Lanes.Add(schemaEmailTemplateLane);
			ProcessSchemaEventSubProcess emailtemplateeventsubprocess = CreateEmailTemplateEventSubProcessEventSubProcess();
			FlowElements.Add(emailtemplateeventsubprocess);
			ProcessSchemaStartMessageEvent emailtemplateinsertingstartmessage = CreateEmailTemplateInsertingStartMessageStartMessageEvent();
			emailtemplateeventsubprocess.FlowElements.Add(emailtemplateinsertingstartmessage);
			ProcessSchemaStartMessageEvent emailtemplatesavingstartmessage = CreateEmailTemplateSavingStartMessageStartMessageEvent();
			emailtemplateeventsubprocess.FlowElements.Add(emailtemplatesavingstartmessage);
			ProcessSchemaStartMessageEvent emailtemplatedeletingstartmessage = CreateEmailTemplateDeletingStartMessageStartMessageEvent();
			emailtemplateeventsubprocess.FlowElements.Add(emailtemplatedeletingstartmessage);
			ProcessSchemaScriptTask checkcanmanagelookupsscripttask = CreateCheckCanManageLookupsScriptTaskScriptTask();
			FlowElements.Add(checkcanmanagelookupsscripttask);
			FlowElements.Add(CreateEmailTemplateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateEmailTemplateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateEmailTemplateSequenceFlow3SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateEmailTemplateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "EmailTemplateSequenceFlow1",
				UId = new Guid("1fb7e43b-4936-4ebc-ba34-b5692f16068b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("405a3e7e-e05d-42ab-853f-d735e8887459"),
				CreatedInSchemaUId = new Guid("efc63865-6d60-4074-83b9-f5ff2ec419fc"),
				CurveCenterPosition = new Point(248, 73),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("efc63865-6d60-4074-83b9-f5ff2ec419fc"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1f309623-69c1-4cbb-b9f0-77c0fee4a88d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ca153e72-b0ee-4c6b-91b6-6ca9753799aa"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateEmailTemplateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "EmailTemplateSequenceFlow2",
				UId = new Guid("c3c49056-57d2-4a34-8a61-a534b86b4fc4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("405a3e7e-e05d-42ab-853f-d735e8887459"),
				CreatedInSchemaUId = new Guid("efc63865-6d60-4074-83b9-f5ff2ec419fc"),
				CurveCenterPosition = new Point(239, 101),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("efc63865-6d60-4074-83b9-f5ff2ec419fc"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3bda745f-4adc-4074-a069-5e99c9f16b69"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ca153e72-b0ee-4c6b-91b6-6ca9753799aa"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateEmailTemplateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "EmailTemplateSequenceFlow3",
				UId = new Guid("852c771b-3546-4009-a90a-31582faa409b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("405a3e7e-e05d-42ab-853f-d735e8887459"),
				CreatedInSchemaUId = new Guid("efc63865-6d60-4074-83b9-f5ff2ec419fc"),
				CurveCenterPosition = new Point(226, 135),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("efc63865-6d60-4074-83b9-f5ff2ec419fc"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f3dbfad1-9404-4556-842a-9f600c540c35"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ca153e72-b0ee-4c6b-91b6-6ca9753799aa"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateEmailTemplateLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaEmailTemplateLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("6448ed76-46c9-4801-9ed0-176538f17fda"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("405a3e7e-e05d-42ab-853f-d735e8887459"),
				CreatedInSchemaUId = new Guid("efc63865-6d60-4074-83b9-f5ff2ec419fc"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("efc63865-6d60-4074-83b9-f5ff2ec419fc"),
				Name = @"EmailTemplateLaneSet",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(560, 228),
				UseBackgroundMode = false
			};
			return schemaEmailTemplateLaneSet;
		}

		protected virtual ProcessSchemaLane CreateEmailTemplateLaneLane() {
			ProcessSchemaLane schemaEmailTemplateLane = new ProcessSchemaLane(this) {
				UId = new Guid("5ef5253f-4fed-4160-a638-95e4f9fdf7e6"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("6448ed76-46c9-4801-9ed0-176538f17fda"),
				CreatedInOwnerSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63"),
				CreatedInPackageId = new Guid("405a3e7e-e05d-42ab-853f-d735e8887459"),
				CreatedInSchemaUId = new Guid("efc63865-6d60-4074-83b9-f5ff2ec419fc"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("efc63865-6d60-4074-83b9-f5ff2ec419fc"),
				Name = @"EmailTemplateLane",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(531, 228),
				UseBackgroundMode = false
			};
			return schemaEmailTemplateLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEmailTemplateEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEmailTemplateEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("9a4fbdfc-4eb0-4dc1-825b-f0a88f58836d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5ef5253f-4fed-4160-a638-95e4f9fdf7e6"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("405a3e7e-e05d-42ab-853f-d735e8887459"),
				CreatedInSchemaUId = new Guid("efc63865-6d60-4074-83b9-f5ff2ec419fc"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("efc63865-6d60-4074-83b9-f5ff2ec419fc"),
				Name = @"EmailTemplateEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(50, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(154, 205),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEmailTemplateEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateEmailTemplateInsertingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("1f309623-69c1-4cbb-b9f0-77c0fee4a88d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9a4fbdfc-4eb0-4dc1-825b-f0a88f58836d"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("405a3e7e-e05d-42ab-853f-d735e8887459"),
				CreatedInSchemaUId = new Guid("efc63865-6d60-4074-83b9-f5ff2ec419fc"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"EmailTemplateInserting",
				ModifiedInSchemaUId = new Guid("efc63865-6d60-4074-83b9-f5ff2ec419fc"),
				Name = @"EmailTemplateInsertingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(49, 14),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateEmailTemplateSavingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("3bda745f-4adc-4074-a069-5e99c9f16b69"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9a4fbdfc-4eb0-4dc1-825b-f0a88f58836d"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("405a3e7e-e05d-42ab-853f-d735e8887459"),
				CreatedInSchemaUId = new Guid("efc63865-6d60-4074-83b9-f5ff2ec419fc"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"EmailTemplateSaving",
				ModifiedInSchemaUId = new Guid("efc63865-6d60-4074-83b9-f5ff2ec419fc"),
				Name = @"EmailTemplateSavingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(49, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateEmailTemplateDeletingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f3dbfad1-9404-4556-842a-9f600c540c35"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9a4fbdfc-4eb0-4dc1-825b-f0a88f58836d"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("405a3e7e-e05d-42ab-853f-d735e8887459"),
				CreatedInSchemaUId = new Guid("efc63865-6d60-4074-83b9-f5ff2ec419fc"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"EmailTemplateDeleting",
				ModifiedInSchemaUId = new Guid("efc63865-6d60-4074-83b9-f5ff2ec419fc"),
				Name = @"EmailTemplateDeletingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(49, 133),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCheckCanManageLookupsScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ca153e72-b0ee-4c6b-91b6-6ca9753799aa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5ef5253f-4fed-4160-a638-95e4f9fdf7e6"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("405a3e7e-e05d-42ab-853f-d735e8887459"),
				CreatedInSchemaUId = new Guid("efc63865-6d60-4074-83b9-f5ff2ec419fc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("efc63865-6d60-4074-83b9-f5ff2ec419fc"),
				Name = @"CheckCanManageLookupsScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(253, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,78,45,114,206,207,203,75,77,46,201,204,207,211,115,113,10,78,77,46,45,202,44,169,116,205,75,207,204,75,213,115,206,72,77,206,118,78,204,115,173,0,138,151,164,250,23,164,22,37,130,84,106,40,1,5,125,19,243,18,211,83,125,242,243,179,75,11,138,149,52,173,121,185,138,82,75,74,139,242,20,74,138,74,83,173,1,55,130,180,236,91,0,0,0 }
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

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new EmailTemplate_Base_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("efc63865-6d60-4074-83b9-f5ff2ec419fc"));
		}

		#endregion

	}

	#endregion

}

