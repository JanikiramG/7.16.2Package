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
	using Terrasoft.Messaging.Common;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: MailServer_Base_TerrasoftSchema

	/// <exclude/>
	public class MailServer_Base_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public MailServer_Base_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public MailServer_Base_TerrasoftSchema(MailServer_Base_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public MailServer_Base_TerrasoftSchema(MailServer_Base_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4");
			RealUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4");
			Name = "MailServer_Base_Terrasoft";
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
			if (Columns.FindByUId(new Guid("be4a6212-190c-4430-8b31-6972ac32503f")) == null) {
				Columns.Add(CreateAddressColumn());
			}
			if (Columns.FindByUId(new Guid("b9e6dfc3-cd79-4707-9f3d-9b6bedda3c5f")) == null) {
				Columns.Add(CreatePortColumn());
			}
			if (Columns.FindByUId(new Guid("773d7c26-389e-421c-a67e-9ca6a8b8a3e9")) == null) {
				Columns.Add(CreateUseSSLColumn());
			}
			if (Columns.FindByUId(new Guid("9a6b34c9-96b3-45f5-b005-dfcd12e79d6d")) == null) {
				Columns.Add(CreateEmailProtocolColumn());
			}
			if (Columns.FindByUId(new Guid("89e2b329-bf63-4d5c-a079-6cf6c5fa9430")) == null) {
				Columns.Add(CreateAllowEmailDownloadingColumn());
			}
			if (Columns.FindByUId(new Guid("411aaeae-43da-4e1c-8b1c-1655c25aac96")) == null) {
				Columns.Add(CreateAllowEmailSendingColumn());
			}
			if (Columns.FindByUId(new Guid("394009b0-7664-46b4-b052-5754522f03c3")) == null) {
				Columns.Add(CreateSMTPServerAddressColumn());
			}
			if (Columns.FindByUId(new Guid("c6d3e3b2-5552-4b06-9d5c-fe34b58ae7aa")) == null) {
				Columns.Add(CreateSMTPPortColumn());
			}
			if (Columns.FindByUId(new Guid("6094ebec-dee7-492e-8977-4e2748a9b4bb")) == null) {
				Columns.Add(CreateSMTPServerTimeoutColumn());
			}
			if (Columns.FindByUId(new Guid("33affd30-ab8b-4975-8917-9baa63d2d025")) == null) {
				Columns.Add(CreateUseSSLforSendingColumn());
			}
			if (Columns.FindByUId(new Guid("a017673a-f233-4df8-8ba8-fd299bae4e20")) == null) {
				Columns.Add(CreateIsStartTlsColumn());
			}
			if (Columns.FindByUId(new Guid("29f424ac-945a-4548-a60e-5e738cf01711")) == null) {
				Columns.Add(CreateUseLoginColumn());
			}
			if (Columns.FindByUId(new Guid("29d0de8b-d4db-45d1-b453-8241941d7b62")) == null) {
				Columns.Add(CreateLogoColumn());
			}
			if (Columns.FindByUId(new Guid("30e37f76-b60e-4975-89a0-befc3e75eeb7")) == null) {
				Columns.Add(CreateUseUserNameAsLoginColumn());
			}
			if (Columns.FindByUId(new Guid("38790f02-593c-4eb3-80be-2204877697a0")) == null) {
				Columns.Add(CreateUseEmailAddressAsLoginColumn());
			}
			if (Columns.FindByUId(new Guid("2e121c4b-83ff-40c4-9f0e-503cee9e5cae")) == null) {
				Columns.Add(CreateStrategyColumn());
			}
			if (Columns.FindByUId(new Guid("5826ac7a-d531-4540-a160-6408396cd88b")) == null) {
				Columns.Add(CreateOAuthApplicationColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("f0fec10e-c639-4ebb-b0d4-75ba7beb2b30"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4"),
				ModifiedInSchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateAddressColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("be4a6212-190c-4430-8b31-6972ac32503f"),
				Name = @"Address",
				CreatedInSchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4"),
				ModifiedInSchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreatePortColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("b9e6dfc3-cd79-4707-9f3d-9b6bedda3c5f"),
				Name = @"Port",
				CreatedInSchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4"),
				ModifiedInSchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateUseSSLColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("773d7c26-389e-421c-a67e-9ca6a8b8a3e9"),
				Name = @"UseSSL",
				CreatedInSchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4"),
				ModifiedInSchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateEmailProtocolColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("9a6b34c9-96b3-45f5-b005-dfcd12e79d6d"),
				Name = @"EmailProtocol",
				ReferenceSchemaUId = new Guid("23b9470a-2e03-472b-b609-eff6e0339dd4"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4"),
				ModifiedInSchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsSimpleLookup = true,
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"65beaf50-b599-4207-b6e2-586dfa9562a6"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateAllowEmailDownloadingColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("89e2b329-bf63-4d5c-a079-6cf6c5fa9430"),
				Name = @"AllowEmailDownloading",
				CreatedInSchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4"),
				ModifiedInSchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"True"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateAllowEmailSendingColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("411aaeae-43da-4e1c-8b1c-1655c25aac96"),
				Name = @"AllowEmailSending",
				CreatedInSchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4"),
				ModifiedInSchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"True"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateSMTPServerAddressColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("394009b0-7664-46b4-b052-5754522f03c3"),
				Name = @"SMTPServerAddress",
				CreatedInSchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4"),
				ModifiedInSchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSMTPPortColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("c6d3e3b2-5552-4b06-9d5c-fe34b58ae7aa"),
				Name = @"SMTPPort",
				CreatedInSchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4"),
				ModifiedInSchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSMTPServerTimeoutColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("6094ebec-dee7-492e-8977-4e2748a9b4bb"),
				Name = @"SMTPServerTimeout",
				CreatedInSchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4"),
				ModifiedInSchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"40"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateUseSSLforSendingColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("33affd30-ab8b-4975-8917-9baa63d2d025"),
				Name = @"UseSSLforSending",
				CreatedInSchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4"),
				ModifiedInSchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateIsStartTlsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("a017673a-f233-4df8-8ba8-fd299bae4e20"),
				Name = @"IsStartTls",
				CreatedInSchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4"),
				ModifiedInSchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4"),
				CreatedInPackageId = new Guid("d96ae870-4bfc-40ec-921c-ada84236f3fa")
			};
		}

		protected virtual EntitySchemaColumn CreateUseLoginColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("29f424ac-945a-4548-a60e-5e738cf01711"),
				Name = @"UseLogin",
				CreatedInSchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4"),
				ModifiedInSchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4"),
				CreatedInPackageId = new Guid("a6558c63-9ae0-4b9f-a2aa-711d80b4faa2")
			};
		}

		protected virtual EntitySchemaColumn CreateLogoColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ImageLookup")) {
				UId = new Guid("29d0de8b-d4db-45d1-b453-8241941d7b62"),
				Name = @"Logo",
				ReferenceSchemaUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4"),
				ModifiedInSchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4"),
				CreatedInPackageId = new Guid("fa2eb5ad-958f-4492-adde-c5914e708d28")
			};
		}

		protected virtual EntitySchemaColumn CreateUseUserNameAsLoginColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("30e37f76-b60e-4975-89a0-befc3e75eeb7"),
				Name = @"UseUserNameAsLogin",
				CreatedInSchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4"),
				ModifiedInSchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4"),
				CreatedInPackageId = new Guid("45b7d114-643d-4217-a8b2-b9950d3eddb7")
			};
		}

		protected virtual EntitySchemaColumn CreateUseEmailAddressAsLoginColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("38790f02-593c-4eb3-80be-2204877697a0"),
				Name = @"UseEmailAddressAsLogin",
				CreatedInSchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4"),
				ModifiedInSchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4"),
				CreatedInPackageId = new Guid("45b7d114-643d-4217-a8b2-b9950d3eddb7")
			};
		}

		protected virtual EntitySchemaColumn CreateStrategyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("2e121c4b-83ff-40c4-9f0e-503cee9e5cae"),
				Name = @"Strategy",
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4"),
				ModifiedInSchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateOAuthApplicationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("5826ac7a-d531-4540-a160-6408396cd88b"),
				Name = @"OAuthApplication",
				ReferenceSchemaUId = new Guid("2d30ef0a-87fb-474a-a348-a8cb46e23e6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4"),
				ModifiedInSchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4"),
				CreatedInPackageId = new Guid("50cc600a-f6aa-433b-8a0a-6a453519907c")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateMailServer_Base_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateMailServer_Base_TerrasoftEventsProcessSchema() {
			var schema = new MailServer_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new MailServer_Base_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new MailServer_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new MailServer_Base_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new MailServer_Base_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4"));
		}

		#endregion

	}

	#endregion

	#region Class: MailServer_Base_Terrasoft

	/// <summary>
	/// Email provider.
	/// </summary>
	public class MailServer_Base_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public MailServer_Base_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "MailServer_Base_Terrasoft";
		}

		public MailServer_Base_Terrasoft(MailServer_Base_Terrasoft source)
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
		/// Incoming mail server name or IP.
		/// </summary>
		public string Address {
			get {
				return GetTypedColumnValue<string>("Address");
			}
			set {
				SetColumnValue("Address", value);
			}
		}

		/// <summary>
		/// Port.
		/// </summary>
		public int Port {
			get {
				return GetTypedColumnValue<int>("Port");
			}
			set {
				SetColumnValue("Port", value);
			}
		}

		/// <summary>
		/// Use SSL.
		/// </summary>
		public bool UseSSL {
			get {
				return GetTypedColumnValue<bool>("UseSSL");
			}
			set {
				SetColumnValue("UseSSL", value);
			}
		}

		/// <exclude/>
		public Guid EmailProtocolId {
			get {
				return GetTypedColumnValue<Guid>("EmailProtocolId");
			}
			set {
				SetColumnValue("EmailProtocolId", value);
				_emailProtocol = null;
			}
		}

		/// <exclude/>
		public string EmailProtocolName {
			get {
				return GetTypedColumnValue<string>("EmailProtocolName");
			}
			set {
				SetColumnValue("EmailProtocolName", value);
				if (_emailProtocol != null) {
					_emailProtocol.Name = value;
				}
			}
		}

		private EmailProtocol _emailProtocol;
		/// <summary>
		/// Connection protocol.
		/// </summary>
		public EmailProtocol EmailProtocol {
			get {
				return _emailProtocol ??
					(_emailProtocol = LookupColumnEntities.GetEntity("EmailProtocol") as EmailProtocol);
			}
		}

		/// <summary>
		/// Allow downloading emails.
		/// </summary>
		public bool AllowEmailDownloading {
			get {
				return GetTypedColumnValue<bool>("AllowEmailDownloading");
			}
			set {
				SetColumnValue("AllowEmailDownloading", value);
			}
		}

		/// <summary>
		/// Allow sending emails.
		/// </summary>
		public bool AllowEmailSending {
			get {
				return GetTypedColumnValue<bool>("AllowEmailSending");
			}
			set {
				SetColumnValue("AllowEmailSending", value);
			}
		}

		/// <summary>
		/// Outgoing mail server name or IP (SMTP).
		/// </summary>
		public string SMTPServerAddress {
			get {
				return GetTypedColumnValue<string>("SMTPServerAddress");
			}
			set {
				SetColumnValue("SMTPServerAddress", value);
			}
		}

		/// <summary>
		/// Port.
		/// </summary>
		public int SMTPPort {
			get {
				return GetTypedColumnValue<int>("SMTPPort");
			}
			set {
				SetColumnValue("SMTPPort", value);
			}
		}

		/// <summary>
		/// Interval of waiting for server response when sending mail, seconds.
		/// </summary>
		public int SMTPServerTimeout {
			get {
				return GetTypedColumnValue<int>("SMTPServerTimeout");
			}
			set {
				SetColumnValue("SMTPServerTimeout", value);
			}
		}

		/// <summary>
		/// Use SSL.
		/// </summary>
		public bool UseSSLforSending {
			get {
				return GetTypedColumnValue<bool>("UseSSLforSending");
			}
			set {
				SetColumnValue("UseSSLforSending", value);
			}
		}

		/// <summary>
		/// Create encrypted connection (STARTTLS).
		/// </summary>
		public bool IsStartTls {
			get {
				return GetTypedColumnValue<bool>("IsStartTls");
			}
			set {
				SetColumnValue("IsStartTls", value);
			}
		}

		/// <summary>
		/// Enter login manually.
		/// </summary>
		public bool UseLogin {
			get {
				return GetTypedColumnValue<bool>("UseLogin");
			}
			set {
				SetColumnValue("UseLogin", value);
			}
		}

		/// <exclude/>
		public Guid LogoId {
			get {
				return GetTypedColumnValue<Guid>("LogoId");
			}
			set {
				SetColumnValue("LogoId", value);
				_logo = null;
			}
		}

		/// <exclude/>
		public string LogoName {
			get {
				return GetTypedColumnValue<string>("LogoName");
			}
			set {
				SetColumnValue("LogoName", value);
				if (_logo != null) {
					_logo.Name = value;
				}
			}
		}

		private SysImage _logo;
		/// <summary>
		/// Logo.
		/// </summary>
		public SysImage Logo {
			get {
				return _logo ??
					(_logo = LookupColumnEntities.GetEntity("Logo") as SysImage);
			}
		}

		/// <summary>
		/// Use user name as login.
		/// </summary>
		public bool UseUserNameAsLogin {
			get {
				return GetTypedColumnValue<bool>("UseUserNameAsLogin");
			}
			set {
				SetColumnValue("UseUserNameAsLogin", value);
			}
		}

		/// <summary>
		/// Use email address as login.
		/// </summary>
		public bool UseEmailAddressAsLogin {
			get {
				return GetTypedColumnValue<bool>("UseEmailAddressAsLogin");
			}
			set {
				SetColumnValue("UseEmailAddressAsLogin", value);
			}
		}

		/// <summary>
		/// Strategy.
		/// </summary>
		public string Strategy {
			get {
				return GetTypedColumnValue<string>("Strategy");
			}
			set {
				SetColumnValue("Strategy", value);
			}
		}

		/// <exclude/>
		public Guid OAuthApplicationId {
			get {
				return GetTypedColumnValue<Guid>("OAuthApplicationId");
			}
			set {
				SetColumnValue("OAuthApplicationId", value);
				_oAuthApplication = null;
			}
		}

		/// <exclude/>
		public string OAuthApplicationName {
			get {
				return GetTypedColumnValue<string>("OAuthApplicationName");
			}
			set {
				SetColumnValue("OAuthApplicationName", value);
				if (_oAuthApplication != null) {
					_oAuthApplication.Name = value;
				}
			}
		}

		private OAuthApplications _oAuthApplication;
		/// <summary>
		/// OAuth application identifier.
		/// </summary>
		public OAuthApplications OAuthApplication {
			get {
				return _oAuthApplication ??
					(_oAuthApplication = LookupColumnEntities.GetEntity("OAuthApplication") as OAuthApplications);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new MailServer_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("MailServer_Base_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("MailServer_Base_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("MailServer_Base_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("MailServer_Base_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("MailServer_Base_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("MailServer_Base_TerrasoftSaving", e);
			Updated += (s, e) => ThrowEvent("MailServer_Base_TerrasoftUpdated", e);
			Validating += (s, e) => ThrowEvent("MailServer_Base_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new MailServer_Base_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: MailServer_BaseEventsProcess

	/// <exclude/>
	public partial class MailServer_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : MailServer_Base_Terrasoft
	{

		public MailServer_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "MailServer_BaseEventsProcess";
			SchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _mailServerEventSubProcess;
		public ProcessFlowElement MailServerEventSubProcess {
			get {
				return _mailServerEventSubProcess ?? (_mailServerEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "MailServerEventSubProcess",
					SchemaElementUId = new Guid("dbb202ae-ead3-417b-b42f-f68b5bba50eb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _mailServerInsertingStartMessage;
		public ProcessFlowElement MailServerInsertingStartMessage {
			get {
				return _mailServerInsertingStartMessage ?? (_mailServerInsertingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "MailServerInsertingStartMessage",
					SchemaElementUId = new Guid("4735dcb2-af8e-49b1-b3e7-aa8f7a4b0b49"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _mailServerSavingStartMessage;
		public ProcessFlowElement MailServerSavingStartMessage {
			get {
				return _mailServerSavingStartMessage ?? (_mailServerSavingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "MailServerSavingStartMessage",
					SchemaElementUId = new Guid("cc824bbe-8bc7-4df6-8d66-1eb1249c5014"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _mailServerDeletingStartMessage;
		public ProcessFlowElement MailServerDeletingStartMessage {
			get {
				return _mailServerDeletingStartMessage ?? (_mailServerDeletingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "MailServerDeletingStartMessage",
					SchemaElementUId = new Guid("5299f902-4221-4a2a-9854-710fc519fddd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _mailServerInserted;
		public ProcessFlowElement MailServerInserted {
			get {
				return _mailServerInserted ?? (_mailServerInserted = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "MailServerInserted",
					SchemaElementUId = new Guid("8608b349-cede-4e47-a276-69968153feda"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _mailServerDeleted;
		public ProcessFlowElement MailServerDeleted {
			get {
				return _mailServerDeleted ?? (_mailServerDeleted = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "MailServerDeleted",
					SchemaElementUId = new Guid("5b06e3c2-dc63-4f9a-9a5b-cf8b9d6375a7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _mailServerUpdated;
		public ProcessFlowElement MailServerUpdated {
			get {
				return _mailServerUpdated ?? (_mailServerUpdated = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "MailServerUpdated",
					SchemaElementUId = new Guid("dd16bb71-0766-4318-abdc-a7628669c10d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _mailServerCheckCanExecuteOperationScriptTask;
		public ProcessScriptTask MailServerCheckCanExecuteOperationScriptTask {
			get {
				return _mailServerCheckCanExecuteOperationScriptTask ?? (_mailServerCheckCanExecuteOperationScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "MailServerCheckCanExecuteOperationScriptTask",
					SchemaElementUId = new Guid("a745f5f1-c93e-416b-a961-601357bb4db3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = MailServerCheckCanExecuteOperationScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _sendUpdate;
		public ProcessScriptTask SendUpdate {
			get {
				return _sendUpdate ?? (_sendUpdate = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SendUpdate",
					SchemaElementUId = new Guid("b82557dc-92aa-4510-ae91-4591a69f750f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SendUpdateExecute,
				});
			}
		}

		private ProcessScriptTask _sendInsert;
		public ProcessScriptTask SendInsert {
			get {
				return _sendInsert ?? (_sendInsert = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SendInsert",
					SchemaElementUId = new Guid("b540fc09-d81f-491c-b09e-af9341bf34a0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SendInsertExecute,
				});
			}
		}

		private ProcessScriptTask _sendDelete;
		public ProcessScriptTask SendDelete {
			get {
				return _sendDelete ?? (_sendDelete = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SendDelete",
					SchemaElementUId = new Guid("ccd758cd-4c94-4f2c-a833-8441b90e1e7b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SendDeleteExecute,
				});
			}
		}

		private ProcessTerminateEvent _terminateEvent1;
		public ProcessTerminateEvent TerminateEvent1 {
			get {
				return _terminateEvent1 ?? (_terminateEvent1 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateEvent1",
					SchemaElementUId = new Guid("e2ed7e63-89a4-4877-84b9-ca3a7b9cb316"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[MailServerEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { MailServerEventSubProcess };
			FlowElements[MailServerInsertingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { MailServerInsertingStartMessage };
			FlowElements[MailServerSavingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { MailServerSavingStartMessage };
			FlowElements[MailServerDeletingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { MailServerDeletingStartMessage };
			FlowElements[MailServerInserted.SchemaElementUId] = new Collection<ProcessFlowElement> { MailServerInserted };
			FlowElements[MailServerDeleted.SchemaElementUId] = new Collection<ProcessFlowElement> { MailServerDeleted };
			FlowElements[MailServerUpdated.SchemaElementUId] = new Collection<ProcessFlowElement> { MailServerUpdated };
			FlowElements[MailServerCheckCanExecuteOperationScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { MailServerCheckCanExecuteOperationScriptTask };
			FlowElements[SendUpdate.SchemaElementUId] = new Collection<ProcessFlowElement> { SendUpdate };
			FlowElements[SendInsert.SchemaElementUId] = new Collection<ProcessFlowElement> { SendInsert };
			FlowElements[SendDelete.SchemaElementUId] = new Collection<ProcessFlowElement> { SendDelete };
			FlowElements[TerminateEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateEvent1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "MailServerEventSubProcess":
						break;
					case "MailServerInsertingStartMessage":
						e.Context.QueueTasks.Enqueue("MailServerCheckCanExecuteOperationScriptTask");
						break;
					case "MailServerSavingStartMessage":
						e.Context.QueueTasks.Enqueue("MailServerCheckCanExecuteOperationScriptTask");
						break;
					case "MailServerDeletingStartMessage":
						e.Context.QueueTasks.Enqueue("MailServerCheckCanExecuteOperationScriptTask");
						break;
					case "MailServerInserted":
						e.Context.QueueTasks.Enqueue("SendInsert");
						break;
					case "MailServerDeleted":
						e.Context.QueueTasks.Enqueue("SendDelete");
						break;
					case "MailServerUpdated":
						e.Context.QueueTasks.Enqueue("SendUpdate");
						break;
					case "MailServerCheckCanExecuteOperationScriptTask":
						break;
					case "SendUpdate":
						e.Context.QueueTasks.Enqueue("TerminateEvent1");
						break;
					case "SendInsert":
						e.Context.QueueTasks.Enqueue("TerminateEvent1");
						break;
					case "SendDelete":
						e.Context.QueueTasks.Enqueue("TerminateEvent1");
						break;
					case "TerminateEvent1":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("MailServerInsertingStartMessage");
			ActivatedEventElements.Add("MailServerSavingStartMessage");
			ActivatedEventElements.Add("MailServerDeletingStartMessage");
			ActivatedEventElements.Add("MailServerInserted");
			ActivatedEventElements.Add("MailServerDeleted");
			ActivatedEventElements.Add("MailServerUpdated");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "MailServerEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "MailServerInsertingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "MailServerInsertingStartMessage";
					result = MailServerInsertingStartMessage.Execute(context);
					break;
				case "MailServerSavingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "MailServerSavingStartMessage";
					result = MailServerSavingStartMessage.Execute(context);
					break;
				case "MailServerDeletingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "MailServerDeletingStartMessage";
					result = MailServerDeletingStartMessage.Execute(context);
					break;
				case "MailServerInserted":
					context.QueueTasks.Dequeue();
					context.SenderName = "MailServerInserted";
					result = MailServerInserted.Execute(context);
					break;
				case "MailServerDeleted":
					context.QueueTasks.Dequeue();
					context.SenderName = "MailServerDeleted";
					result = MailServerDeleted.Execute(context);
					break;
				case "MailServerUpdated":
					context.QueueTasks.Dequeue();
					context.SenderName = "MailServerUpdated";
					result = MailServerUpdated.Execute(context);
					break;
				case "MailServerCheckCanExecuteOperationScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "MailServerCheckCanExecuteOperationScriptTask";
					result = MailServerCheckCanExecuteOperationScriptTask.Execute(context, MailServerCheckCanExecuteOperationScriptTaskExecute);
					break;
				case "SendUpdate":
					context.QueueTasks.Dequeue();
					context.SenderName = "SendUpdate";
					result = SendUpdate.Execute(context, SendUpdateExecute);
					break;
				case "SendInsert":
					context.QueueTasks.Dequeue();
					context.SenderName = "SendInsert";
					result = SendInsert.Execute(context, SendInsertExecute);
					break;
				case "SendDelete":
					context.QueueTasks.Dequeue();
					context.SenderName = "SendDelete";
					result = SendDelete.Execute(context, SendDeleteExecute);
					break;
				case "TerminateEvent1":
					context.QueueTasks.Dequeue();
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

		public virtual bool MailServerCheckCanExecuteOperationScriptTaskExecute(ProcessExecutingContext context) {
			UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageMailServers");
			return true;
		}

		public virtual bool SendUpdateExecute(ProcessExecutingContext context) {
			SendMessage("MailServerEdited");
			DeleteUnusedOAuthApplication(true);
			ClearMailboxSyncSettingsPasswords();
			return true;
		}

		public virtual bool SendInsertExecute(ProcessExecutingContext context) {
			SendMessage("MailServerAdded");
			return true;
		}

		public virtual bool SendDeleteExecute(ProcessExecutingContext context) {
			SendMessage("MailServerDeleted");
			DeleteUnusedOAuthApplication(false);
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "MailServer_Base_TerrasoftInserting":
							if (ActivatedEventElements.Contains("MailServerInsertingStartMessage")) {
							context.QueueTasks.Enqueue("MailServerInsertingStartMessage");
						}
						break;
					case "MailServer_Base_TerrasoftSaving":
							if (ActivatedEventElements.Contains("MailServerSavingStartMessage")) {
							context.QueueTasks.Enqueue("MailServerSavingStartMessage");
						}
						break;
					case "MailServer_Base_TerrasoftDeleting":
							if (ActivatedEventElements.Contains("MailServerDeletingStartMessage")) {
							context.QueueTasks.Enqueue("MailServerDeletingStartMessage");
						}
						break;
					case "MailServer_Base_TerrasoftInserted":
							if (ActivatedEventElements.Contains("MailServerInserted")) {
							context.QueueTasks.Enqueue("MailServerInserted");
						}
						break;
					case "MailServer_Base_TerrasoftDeleted":
							if (ActivatedEventElements.Contains("MailServerDeleted")) {
							context.QueueTasks.Enqueue("MailServerDeleted");
						}
						break;
					case "MailServer_Base_TerrasoftUpdated":
							if (ActivatedEventElements.Contains("MailServerUpdated")) {
							context.QueueTasks.Enqueue("MailServerUpdated");
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

	#region Class: MailServer_BaseEventsProcess

	/// <exclude/>
	public class MailServer_BaseEventsProcess : MailServer_BaseEventsProcess<MailServer_Base_Terrasoft>
	{

		public MailServer_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: MailServer_Base_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class MailServer_Base_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public MailServer_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public MailServer_Base_TerrasoftEventsProcessSchema(MailServer_Base_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "MailServer_BaseEventsProcess";
			UId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f");
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
			ProcessSchemaLaneSet schemaMailServerLaneSet = CreateMailServerLaneSetLaneSet();
			LaneSets.Add(schemaMailServerLaneSet);
			ProcessSchemaLane schemaMailServerLane = CreateMailServerLaneLane();
			schemaMailServerLaneSet.Lanes.Add(schemaMailServerLane);
			ProcessSchemaEventSubProcess mailservereventsubprocess = CreateMailServerEventSubProcessEventSubProcess();
			FlowElements.Add(mailservereventsubprocess);
			ProcessSchemaStartMessageEvent mailserverinsertingstartmessage = CreateMailServerInsertingStartMessageStartMessageEvent();
			mailservereventsubprocess.FlowElements.Add(mailserverinsertingstartmessage);
			ProcessSchemaStartMessageEvent mailserversavingstartmessage = CreateMailServerSavingStartMessageStartMessageEvent();
			mailservereventsubprocess.FlowElements.Add(mailserversavingstartmessage);
			ProcessSchemaStartMessageEvent mailserverdeletingstartmessage = CreateMailServerDeletingStartMessageStartMessageEvent();
			mailservereventsubprocess.FlowElements.Add(mailserverdeletingstartmessage);
			ProcessSchemaStartMessageEvent mailserverinserted = CreateMailServerInsertedStartMessageEvent();
			mailservereventsubprocess.FlowElements.Add(mailserverinserted);
			ProcessSchemaStartMessageEvent mailserverdeleted = CreateMailServerDeletedStartMessageEvent();
			mailservereventsubprocess.FlowElements.Add(mailserverdeleted);
			ProcessSchemaStartMessageEvent mailserverupdated = CreateMailServerUpdatedStartMessageEvent();
			mailservereventsubprocess.FlowElements.Add(mailserverupdated);
			ProcessSchemaScriptTask mailservercheckcanexecuteoperationscripttask = CreateMailServerCheckCanExecuteOperationScriptTaskScriptTask();
			FlowElements.Add(mailservercheckcanexecuteoperationscripttask);
			ProcessSchemaScriptTask sendupdate = CreateSendUpdateScriptTask();
			FlowElements.Add(sendupdate);
			ProcessSchemaScriptTask sendinsert = CreateSendInsertScriptTask();
			FlowElements.Add(sendinsert);
			ProcessSchemaScriptTask senddelete = CreateSendDeleteScriptTask();
			FlowElements.Add(senddelete);
			ProcessSchemaTerminateEvent terminateevent1 = CreateTerminateEvent1TerminateEvent();
			FlowElements.Add(terminateevent1);
			FlowElements.Add(CreateMailServerDeletingSequenceFlowSequenceFlow());
			FlowElements.Add(CreateMailServerSavingSequenceFlowSequenceFlow());
			FlowElements.Add(CreateMailServerInsertingSequenceFlowSequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateMailServerDeletingSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "MailServerDeletingSequenceFlow",
				UId = new Guid("b56657ff-aeb5-4807-ad08-d19fe676209f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e9b28642-acb7-4727-a3d6-6b2ec7e400a4"),
				CreatedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				CurveCenterPosition = new Point(224, 173),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5299f902-4221-4a2a-9854-710fc519fddd"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a745f5f1-c93e-416b-a961-601357bb4db3"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(183, 217));
			schemaFlow.PolylinePointPositions.Add(new Point(183, 141));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateMailServerSavingSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "MailServerSavingSequenceFlow",
				UId = new Guid("9c798f41-ce12-485e-be47-9d202bbb05c5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e9b28642-acb7-4727-a3d6-6b2ec7e400a4"),
				CreatedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				CurveCenterPosition = new Point(222, 134),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cc824bbe-8bc7-4df6-8d66-1eb1249c5014"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a745f5f1-c93e-416b-a961-601357bb4db3"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateMailServerInsertingSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "MailServerInsertingSequenceFlow",
				UId = new Guid("06a528af-a694-43ce-9d82-9581da8a6cd7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e9b28642-acb7-4727-a3d6-6b2ec7e400a4"),
				CreatedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				CurveCenterPosition = new Point(230, 96),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4735dcb2-af8e-49b1-b3e7-aa8f7a4b0b49"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a745f5f1-c93e-416b-a961-601357bb4db3"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(183, 63));
			schemaFlow.PolylinePointPositions.Add(new Point(183, 141));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("da13a0e6-bc37-416a-a39b-b050ca77d3ed"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("9dae2167-8d3b-4948-9812-c7a970f9490e"),
				CreatedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b82557dc-92aa-4510-ae91-4591a69f750f"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e2ed7e63-89a4-4877-84b9-ca3a7b9cb316"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("9966b484-0941-4f99-8974-9ef9be7f176c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("9dae2167-8d3b-4948-9812-c7a970f9490e"),
				CreatedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b540fc09-d81f-491c-b09e-af9341bf34a0"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e2ed7e63-89a4-4877-84b9-ca3a7b9cb316"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(524, 333));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("68037e31-9564-49d8-9b70-5f67e7bd48c3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("9dae2167-8d3b-4948-9812-c7a970f9490e"),
				CreatedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ccd758cd-4c94-4f2c-a833-8441b90e1e7b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e2ed7e63-89a4-4877-84b9-ca3a7b9cb316"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(524, 503));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("592c1cfd-d747-46dd-b046-4c2e2231b89a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("9dae2167-8d3b-4948-9812-c7a970f9490e"),
				CreatedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8608b349-cede-4e47-a276-69968153feda"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b540fc09-d81f-491c-b09e-af9341bf34a0"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("a3f27bcf-36a9-4e11-8f8c-f3de8c27c84b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("9dae2167-8d3b-4948-9812-c7a970f9490e"),
				CreatedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dd16bb71-0766-4318-abdc-a7628669c10d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b82557dc-92aa-4510-ae91-4591a69f750f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("6377ccc0-38a9-4509-b824-2252cc639978"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("9dae2167-8d3b-4948-9812-c7a970f9490e"),
				CreatedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5b06e3c2-dc63-4f9a-9a5b-cf8b9d6375a7"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ccd758cd-4c94-4f2c-a833-8441b90e1e7b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateMailServerLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaMailServerLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("bf818aff-88d9-4c90-af1b-9022a4bc60b6"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e9b28642-acb7-4727-a3d6-6b2ec7e400a4"),
				CreatedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				Name = @"MailServerLaneSet",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaMailServerLaneSet;
		}

		protected virtual ProcessSchemaLane CreateMailServerLaneLane() {
			ProcessSchemaLane schemaMailServerLane = new ProcessSchemaLane(this) {
				UId = new Guid("bcdbc2dc-6e4e-4c03-b7bb-7d374222b159"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("bf818aff-88d9-4c90-af1b-9022a4bc60b6"),
				CreatedInOwnerSchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4"),
				CreatedInPackageId = new Guid("e9b28642-acb7-4727-a3d6-6b2ec7e400a4"),
				CreatedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				Name = @"MailServerLane",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaMailServerLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateMailServerEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaMailServerEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("dbb202ae-ead3-417b-b42f-f68b5bba50eb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bcdbc2dc-6e4e-4c03-b7bb-7d374222b159"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e9b28642-acb7-4727-a3d6-6b2ec7e400a4"),
				CreatedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				Name = @"MailServerEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 20),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(113, 600),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaMailServerEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateMailServerInsertingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("4735dcb2-af8e-49b1-b3e7-aa8f7a4b0b49"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dbb202ae-ead3-417b-b42f-f68b5bba50eb"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e9b28642-acb7-4727-a3d6-6b2ec7e400a4"),
				CreatedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"MailServerInserting",
				ModifiedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				Name = @"MailServerInsertingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(40, 30),
				SerializeToDB = false,
				Size = new Size(31, 31),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateMailServerSavingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("cc824bbe-8bc7-4df6-8d66-1eb1249c5014"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dbb202ae-ead3-417b-b42f-f68b5bba50eb"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e9b28642-acb7-4727-a3d6-6b2ec7e400a4"),
				CreatedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"MailServerSaving",
				ModifiedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				Name = @"MailServerSavingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(40, 107),
				SerializeToDB = false,
				Size = new Size(31, 31),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateMailServerDeletingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5299f902-4221-4a2a-9854-710fc519fddd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dbb202ae-ead3-417b-b42f-f68b5bba50eb"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e9b28642-acb7-4727-a3d6-6b2ec7e400a4"),
				CreatedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"MailServerDeleting",
				ModifiedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				Name = @"MailServerDeletingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(40, 184),
				SerializeToDB = false,
				Size = new Size(31, 31),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateMailServerInsertedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8608b349-cede-4e47-a276-69968153feda"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dbb202ae-ead3-417b-b42f-f68b5bba50eb"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("9dae2167-8d3b-4948-9812-c7a970f9490e"),
				CreatedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"MailServerInserted",
				ModifiedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				Name = @"MailServerInserted",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(33, 299),
				SerializeToDB = false,
				Size = new Size(31, 31),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateMailServerDeletedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5b06e3c2-dc63-4f9a-9a5b-cf8b9d6375a7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dbb202ae-ead3-417b-b42f-f68b5bba50eb"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("9dae2167-8d3b-4948-9812-c7a970f9490e"),
				CreatedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"MailServerDeleted",
				ModifiedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				Name = @"MailServerDeleted",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(33, 469),
				SerializeToDB = false,
				Size = new Size(31, 31),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateMailServerUpdatedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("dd16bb71-0766-4318-abdc-a7628669c10d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dbb202ae-ead3-417b-b42f-f68b5bba50eb"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("9dae2167-8d3b-4948-9812-c7a970f9490e"),
				CreatedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"MailServerUpdated",
				ModifiedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				Name = @"MailServerUpdated",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(33, 385),
				SerializeToDB = false,
				Size = new Size(31, 31),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateMailServerCheckCanExecuteOperationScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a745f5f1-c93e-416b-a961-601357bb4db3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bcdbc2dc-6e4e-4c03-b7bb-7d374222b159"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e9b28642-acb7-4727-a3d6-6b2ec7e400a4"),
				CreatedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				Name = @"MailServerCheckCanExecuteOperationScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(280, 113),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,21,202,49,10,128,48,12,5,208,93,240,14,226,164,75,47,208,205,218,81,28,138,7,8,229,163,69,137,18,83,209,219,171,235,227,77,39,196,237,204,136,154,118,54,125,23,16,179,36,125,60,207,137,97,220,130,184,58,98,127,127,174,24,15,8,253,179,169,63,28,136,105,198,64,105,11,144,11,114,214,173,45,11,129,102,225,74,37,195,190,160,108,255,124,95,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateSendUpdateScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b82557dc-92aa-4510-ae91-4591a69f750f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bcdbc2dc-6e4e-4c03-b7bb-7d374222b159"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("9dae2167-8d3b-4948-9812-c7a970f9490e"),
				CreatedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				Name = @"SendUpdate",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(280, 391),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,21,203,77,14,130,64,12,6,208,189,167,48,172,198,51,176,34,226,146,104,50,241,0,149,126,193,38,147,14,105,59,254,220,30,216,191,151,161,60,193,157,22,164,110,34,41,25,246,129,221,88,2,220,93,250,211,136,130,192,83,155,131,239,67,139,247,176,174,69,102,10,169,154,194,26,118,115,45,32,59,242,171,254,242,95,231,140,8,209,197,31,228,254,173,198,158,118,100,136,102,122,62,74,191,1,2,181,54,15,118,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateSendInsertScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b540fc09-d81f-491c-b09e-af9341bf34a0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bcdbc2dc-6e4e-4c03-b7bb-7d374222b159"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("9dae2167-8d3b-4948-9812-c7a970f9490e"),
				CreatedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				Name = @"SendInsert",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(280, 305),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,205,75,241,77,45,46,78,76,79,213,80,242,77,204,204,9,78,45,42,75,45,114,76,73,73,77,81,210,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,67,82,204,128,44,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateSendDeleteScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ccd758cd-4c94-4f2c-a833-8441b90e1e7b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bcdbc2dc-6e4e-4c03-b7bb-7d374222b159"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("9dae2167-8d3b-4948-9812-c7a970f9490e"),
				CreatedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				Name = @"SendDelete",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(280, 475),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,205,75,241,77,45,46,78,76,79,213,80,242,77,204,204,9,78,45,42,75,45,114,73,205,73,45,73,77,81,210,180,230,130,48,67,243,74,139,83,83,252,29,75,75,50,28,11,10,114,50,147,19,75,50,243,243,52,210,18,115,138,83,129,138,138,82,75,74,139,242,20,74,138,74,83,173,1,18,197,174,136,83,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateEvent1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("e2ed7e63-89a4-4877-84b9-ca3a7b9cb316"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bcdbc2dc-6e4e-4c03-b7bb-7d374222b159"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("9dae2167-8d3b-4948-9812-c7a970f9490e"),
				CreatedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				Name = @"TerminateEvent1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(508, 405),
				SerializeToDB = false,
				Size = new Size(31, 31),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateSendMessageMethod());
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
			Usings.Add(new SchemaUsing() {
				UId = new Guid("80072450-3d71-495c-9a3b-4b5d23d693ca"),
				Name = "Terrasoft.Messaging.Common",
				Alias = "",
				CreatedInPackageId = new Guid("9dae2167-8d3b-4948-9812-c7a970f9490e")
			});
		}

		protected virtual SchemaMethod CreateSendMessageMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("79662bf1-24b6-4290-b622-39acac7c2dc9"),
				Name = "SendMessage",
				CreatedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				CreatedInPackageId = new Guid("9dae2167-8d3b-4948-9812-c7a970f9490e"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2048f43a-995b-4c84-8562-ac6651dbd5c6"),
				Name = "operation",
				CreatedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				ModifiedInSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("9dae2167-8d3b-4948-9812-c7a970f9490e")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,80,193,106,132,48,16,61,111,190,34,228,164,176,132,158,27,60,116,165,219,230,32,20,172,55,47,193,76,221,128,142,146,196,22,17,255,189,179,91,233,174,167,129,55,239,205,123,243,66,244,14,91,222,67,8,166,133,207,177,227,25,23,203,82,11,109,107,241,92,139,229,105,173,197,186,10,197,194,142,121,26,236,76,212,242,6,202,243,224,123,19,147,251,149,35,127,197,232,226,44,181,77,21,123,155,156,229,97,14,47,182,119,88,161,139,218,146,182,10,224,243,1,17,154,232,6,148,249,228,61,96,188,162,164,82,76,23,161,205,47,134,246,29,111,182,153,241,59,88,24,36,47,226,98,136,6,27,144,103,135,86,71,232,79,115,165,109,178,183,163,16,238,139,39,255,119,50,142,83,215,165,124,97,7,15,113,242,168,216,202,190,141,231,193,245,99,7,197,223,35,228,135,240,195,203,29,70,146,91,252,189,193,145,29,182,74,30,10,98,43,213,246,40,150,239,96,44,101,46,1,105,16,121,24,193,155,235,251,138,109,217,228,199,16,226,70,79,118,226,84,253,2,144,56,33,239,173,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new MailServer_Base_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"));
		}

		#endregion

	}

	#endregion

}

