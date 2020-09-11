namespace Terrasoft.Configuration
{

	using DataContract = Terrasoft.Nui.ServiceModel.DataContract;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.Social;

	#region Class: SocialAccount_Base_TerrasoftSchema

	/// <exclude/>
	public class SocialAccount_Base_TerrasoftSchema : Terrasoft.Configuration.BaseEntityNotesSchema
	{

		#region Constructors: Public

		public SocialAccount_Base_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SocialAccount_Base_TerrasoftSchema(SocialAccount_Base_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SocialAccount_Base_TerrasoftSchema(SocialAccount_Base_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("76e3d8e8-6c6b-48b5-9f43-3b361c368bff");
			RealUId = new Guid("76e3d8e8-6c6b-48b5-9f43-3b361c368bff");
			Name = "SocialAccount_Base_Terrasoft";
			ParentSchemaUId = new Guid("a22b1e79-7fc1-4fe5-aba0-538e9df96f17");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateLoginColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("6287d2bd-93ac-4ca2-921f-3e87d81dc00b")) == null) {
				Columns.Add(CreatePublicColumn());
			}
			if (Columns.FindByUId(new Guid("14f15a6f-d70a-4c77-8f00-984f7bc1821f")) == null) {
				Columns.Add(CreateAccessTokenColumn());
			}
			if (Columns.FindByUId(new Guid("ef8d65a0-3f11-43ac-a259-a28a34494d23")) == null) {
				Columns.Add(CreateAccessSecretTokenColumn());
			}
			if (Columns.FindByUId(new Guid("eee3f2c0-52b4-4d86-95bf-bf4d7fe00f24")) == null) {
				Columns.Add(CreateConsumerKeyColumn());
			}
			if (Columns.FindByUId(new Guid("6be6d2f0-6c1c-463b-8daa-972f1687ec4f")) == null) {
				Columns.Add(CreateTypeColumn());
			}
			if (Columns.FindByUId(new Guid("f22ba771-1414-4be2-9ff8-3028ce093bcf")) == null) {
				Columns.Add(CreateUserColumn());
			}
			if (Columns.FindByUId(new Guid("72ef9eba-b06f-4bda-b9e1-4c04309aaf5e")) == null) {
				Columns.Add(CreateSocialIdColumn());
			}
			if (Columns.FindByUId(new Guid("e2a409c4-5ace-48d0-ac77-766ed29cb397")) == null) {
				Columns.Add(CreateIsExpiredColumn());
			}
			if (Columns.FindByUId(new Guid("bbaf2034-8e52-432d-849c-9ddf83e19d6f")) == null) {
				Columns.Add(CreateNameColumn());
			}
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("76e3d8e8-6c6b-48b5-9f43-3b361c368bff");
			return column;
		}

		protected override EntitySchemaColumn CreateNotesColumn() {
			EntitySchemaColumn column = base.CreateNotesColumn();
			column.ModifiedInSchemaUId = new Guid("76e3d8e8-6c6b-48b5-9f43-3b361c368bff");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected virtual EntitySchemaColumn CreateLoginColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("6a86e81d-86b2-4650-b1dc-fd775bd0a277"),
				Name = @"Login",
				UsageType = EntitySchemaColumnUsageType.Advanced,
				CreatedInSchemaUId = new Guid("76e3d8e8-6c6b-48b5-9f43-3b361c368bff"),
				ModifiedInSchemaUId = new Guid("76e3d8e8-6c6b-48b5-9f43-3b361c368bff"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreatePublicColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("6287d2bd-93ac-4ca2-921f-3e87d81dc00b"),
				Name = @"Public",
				CreatedInSchemaUId = new Guid("76e3d8e8-6c6b-48b5-9f43-3b361c368bff"),
				ModifiedInSchemaUId = new Guid("76e3d8e8-6c6b-48b5-9f43-3b361c368bff"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"True"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateAccessTokenColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("14f15a6f-d70a-4c77-8f00-984f7bc1821f"),
				Name = @"AccessToken",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("76e3d8e8-6c6b-48b5-9f43-3b361c368bff"),
				ModifiedInSchemaUId = new Guid("76e3d8e8-6c6b-48b5-9f43-3b361c368bff"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateAccessSecretTokenColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("ef8d65a0-3f11-43ac-a259-a28a34494d23"),
				Name = @"AccessSecretToken",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("76e3d8e8-6c6b-48b5-9f43-3b361c368bff"),
				ModifiedInSchemaUId = new Guid("76e3d8e8-6c6b-48b5-9f43-3b361c368bff"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateConsumerKeyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("eee3f2c0-52b4-4d86-95bf-bf4d7fe00f24"),
				Name = @"ConsumerKey",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("76e3d8e8-6c6b-48b5-9f43-3b361c368bff"),
				ModifiedInSchemaUId = new Guid("76e3d8e8-6c6b-48b5-9f43-3b361c368bff"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6be6d2f0-6c1c-463b-8daa-972f1687ec4f"),
				Name = @"Type",
				ReferenceSchemaUId = new Guid("d846cb4f-f18d-469e-83ff-e961f3fba873"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("76e3d8e8-6c6b-48b5-9f43-3b361c368bff"),
				ModifiedInSchemaUId = new Guid("76e3d8e8-6c6b-48b5-9f43-3b361c368bff"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateUserColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f22ba771-1414-4be2-9ff8-3028ce093bcf"),
				Name = @"User",
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("76e3d8e8-6c6b-48b5-9f43-3b361c368bff"),
				ModifiedInSchemaUId = new Guid("76e3d8e8-6c6b-48b5-9f43-3b361c368bff"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSocialIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("72ef9eba-b06f-4bda-b9e1-4c04309aaf5e"),
				Name = @"SocialId",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				UsageType = EntitySchemaColumnUsageType.Advanced,
				CreatedInSchemaUId = new Guid("76e3d8e8-6c6b-48b5-9f43-3b361c368bff"),
				ModifiedInSchemaUId = new Guid("76e3d8e8-6c6b-48b5-9f43-3b361c368bff"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateIsExpiredColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("e2a409c4-5ace-48d0-ac77-766ed29cb397"),
				Name = @"IsExpired",
				UsageType = EntitySchemaColumnUsageType.Advanced,
				CreatedInSchemaUId = new Guid("76e3d8e8-6c6b-48b5-9f43-3b361c368bff"),
				ModifiedInSchemaUId = new Guid("76e3d8e8-6c6b-48b5-9f43-3b361c368bff"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("bbaf2034-8e52-432d-849c-9ddf83e19d6f"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("76e3d8e8-6c6b-48b5-9f43-3b361c368bff"),
				ModifiedInSchemaUId = new Guid("76e3d8e8-6c6b-48b5-9f43-3b361c368bff"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsLocalizable = true
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSocialAccount_Base_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSocialAccount_Base_TerrasoftEventsProcessSchema() {
			var schema = new SocialAccount_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SocialAccount_Base_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SocialAccount_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SocialAccount_Base_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SocialAccount_Base_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("76e3d8e8-6c6b-48b5-9f43-3b361c368bff"));
		}

		#endregion

	}

	#endregion

	#region Class: SocialAccount_Base_Terrasoft

	/// <summary>
	/// Accounts in external resources.
	/// </summary>
	public class SocialAccount_Base_Terrasoft : Terrasoft.Configuration.BaseEntityNotes
	{

		#region Constructors: Public

		public SocialAccount_Base_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SocialAccount_Base_Terrasoft";
		}

		public SocialAccount_Base_Terrasoft(SocialAccount_Base_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// User login.
		/// </summary>
		public string Login {
			get {
				return GetTypedColumnValue<string>("Login");
			}
			set {
				SetColumnValue("Login", value);
			}
		}

		/// <summary>
		/// Public.
		/// </summary>
		public bool Public {
			get {
				return GetTypedColumnValue<bool>("Public");
			}
			set {
				SetColumnValue("Public", value);
			}
		}

		/// <summary>
		/// Access Token.
		/// </summary>
		public string AccessToken {
			get {
				return GetTypedColumnValue<string>("AccessToken");
			}
			set {
				SetColumnValue("AccessToken", value);
			}
		}

		/// <summary>
		/// Access Secret Token.
		/// </summary>
		public string AccessSecretToken {
			get {
				return GetTypedColumnValue<string>("AccessSecretToken");
			}
			set {
				SetColumnValue("AccessSecretToken", value);
			}
		}

		/// <summary>
		/// Consumer Key.
		/// </summary>
		public string ConsumerKey {
			get {
				return GetTypedColumnValue<string>("ConsumerKey");
			}
			set {
				SetColumnValue("ConsumerKey", value);
			}
		}

		/// <exclude/>
		public Guid TypeId {
			get {
				return GetTypedColumnValue<Guid>("TypeId");
			}
			set {
				SetColumnValue("TypeId", value);
				_type = null;
			}
		}

		/// <exclude/>
		public string TypeName {
			get {
				return GetTypedColumnValue<string>("TypeName");
			}
			set {
				SetColumnValue("TypeName", value);
				if (_type != null) {
					_type.Name = value;
				}
			}
		}

		private CommunicationType _type;
		/// <summary>
		/// Type.
		/// </summary>
		public CommunicationType Type {
			get {
				return _type ??
					(_type = LookupColumnEntities.GetEntity("Type") as CommunicationType);
			}
		}

		/// <exclude/>
		public Guid UserId {
			get {
				return GetTypedColumnValue<Guid>("UserId");
			}
			set {
				SetColumnValue("UserId", value);
				_user = null;
			}
		}

		/// <exclude/>
		public string UserName {
			get {
				return GetTypedColumnValue<string>("UserName");
			}
			set {
				SetColumnValue("UserName", value);
				if (_user != null) {
					_user.Name = value;
				}
			}
		}

		private SysAdminUnit _user;
		/// <summary>
		/// User.
		/// </summary>
		public SysAdminUnit User {
			get {
				return _user ??
					(_user = LookupColumnEntities.GetEntity("User") as SysAdminUnit);
			}
		}

		/// <summary>
		/// Social network user.
		/// </summary>
		public string SocialId {
			get {
				return GetTypedColumnValue<string>("SocialId");
			}
			set {
				SetColumnValue("SocialId", value);
			}
		}

		/// <summary>
		/// Expired on.
		/// </summary>
		public bool IsExpired {
			get {
				return GetTypedColumnValue<bool>("IsExpired");
			}
			set {
				SetColumnValue("IsExpired", value);
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

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SocialAccount_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SocialAccount_Base_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("SocialAccount_Base_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("SocialAccount_Base_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("SocialAccount_Base_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("SocialAccount_Base_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("SocialAccount_Base_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("SocialAccount_Base_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SocialAccount_Base_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: SocialAccount_BaseEventsProcess

	/// <exclude/>
	public partial class SocialAccount_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntityNotes_BaseEventsProcess<TEntity> where TEntity : SocialAccount_Base_Terrasoft
	{

		public SocialAccount_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SocialAccount_BaseEventsProcess";
			SchemaUId = new Guid("76e3d8e8-6c6b-48b5-9f43-3b361c368bff");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("76e3d8e8-6c6b-48b5-9f43-3b361c368bff");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _socialAccountSavedEventSubProcess1;
		public ProcessFlowElement SocialAccountSavedEventSubProcess1 {
			get {
				return _socialAccountSavedEventSubProcess1 ?? (_socialAccountSavedEventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SocialAccountSavedEventSubProcess1",
					SchemaElementUId = new Guid("51eb168e-71bb-4142-9ea3-2fe289bce25d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _socialAccountSaved;
		public ProcessFlowElement SocialAccountSaved {
			get {
				return _socialAccountSaved ?? (_socialAccountSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SocialAccountSaved",
					SchemaElementUId = new Guid("42561331-80fc-43d9-a2a5-67058765dd55"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _socialAccountSavedScriptTask1;
		public ProcessScriptTask SocialAccountSavedScriptTask1 {
			get {
				return _socialAccountSavedScriptTask1 ?? (_socialAccountSavedScriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SocialAccountSavedScriptTask1",
					SchemaElementUId = new Guid("0cf42978-6370-4f7c-aa83-9ba26a8ba6c4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SocialAccountSavedScriptTask1Execute,
				});
			}
		}

		private ProcessFlowElement _socialAccountSavingEventSubProcess2;
		public ProcessFlowElement SocialAccountSavingEventSubProcess2 {
			get {
				return _socialAccountSavingEventSubProcess2 ?? (_socialAccountSavingEventSubProcess2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SocialAccountSavingEventSubProcess2",
					SchemaElementUId = new Guid("5e4e0bc7-831c-4729-8480-28d1f840eb72"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _socialAccountSavingStartMessage;
		public ProcessFlowElement SocialAccountSavingStartMessage {
			get {
				return _socialAccountSavingStartMessage ?? (_socialAccountSavingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SocialAccountSavingStartMessage",
					SchemaElementUId = new Guid("d06130ed-2183-4942-801f-1e30eeb0861b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _socialAccountSavingScriptTask2;
		public ProcessScriptTask SocialAccountSavingScriptTask2 {
			get {
				return _socialAccountSavingScriptTask2 ?? (_socialAccountSavingScriptTask2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SocialAccountSavingScriptTask2",
					SchemaElementUId = new Guid("7103bc2e-16dc-44c0-bccd-f388aa6e1f64"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SocialAccountSavingScriptTask2Execute,
				});
			}
		}

		private LocalizableString _wrongSocialNetworkTypeLS;
		public LocalizableString WrongSocialNetworkTypeLS {
			get {
				return _wrongSocialNetworkTypeLS ?? (_wrongSocialNetworkTypeLS = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.WrongSocialNetworkTypeLS.Value"));
			}
		}

		private LocalizableString _defNameColumnValue;
		public LocalizableString DefNameColumnValue {
			get {
				return _defNameColumnValue ?? (_defNameColumnValue = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.DefNameColumnValue.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[SocialAccountSavedEventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { SocialAccountSavedEventSubProcess1 };
			FlowElements[SocialAccountSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { SocialAccountSaved };
			FlowElements[SocialAccountSavedScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { SocialAccountSavedScriptTask1 };
			FlowElements[SocialAccountSavingEventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { SocialAccountSavingEventSubProcess2 };
			FlowElements[SocialAccountSavingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SocialAccountSavingStartMessage };
			FlowElements[SocialAccountSavingScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { SocialAccountSavingScriptTask2 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SocialAccountSavedEventSubProcess1":
						break;
					case "SocialAccountSaved":
						e.Context.QueueTasks.Enqueue("SocialAccountSavedScriptTask1");
						break;
					case "SocialAccountSavedScriptTask1":
						break;
					case "SocialAccountSavingEventSubProcess2":
						break;
					case "SocialAccountSavingStartMessage":
						e.Context.QueueTasks.Enqueue("SocialAccountSavingScriptTask2");
						break;
					case "SocialAccountSavingScriptTask2":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("SocialAccountSaved");
			ActivatedEventElements.Add("SocialAccountSavingStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SocialAccountSavedEventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "SocialAccountSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "SocialAccountSaved";
					result = SocialAccountSaved.Execute(context);
					break;
				case "SocialAccountSavedScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "SocialAccountSavedScriptTask1";
					result = SocialAccountSavedScriptTask1.Execute(context, SocialAccountSavedScriptTask1Execute);
					break;
				case "SocialAccountSavingEventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "SocialAccountSavingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SocialAccountSavingStartMessage";
					result = SocialAccountSavingStartMessage.Execute(context);
					break;
				case "SocialAccountSavingScriptTask2":
					context.QueueTasks.Dequeue();
					context.SenderName = "SocialAccountSavingScriptTask2";
					result = SocialAccountSavingScriptTask2.Execute(context, SocialAccountSavingScriptTask2Execute);
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

		public virtual bool SocialAccountSavedScriptTask1Execute(ProcessExecutingContext context) {
			return OnSocialAccountSaved(context);
		}

		public virtual bool SocialAccountSavingScriptTask2Execute(ProcessExecutingContext context) {
			var socialNetwork = GetSocialNetworkType();
			
			if (string.IsNullOrEmpty(Entity.Name)) {
				Entity.Name = string.Format(DefNameColumnValue, socialNetwork.ToString());
			}
			#if !NETSTANDARD2_0 // TODO CRM-42481
			
			// HACK #125916 автоматически устанавливать в поле логин имя пользователя
			if (socialNetwork == SocialNetwork.Google) {
				try {
					Entity.Login = Terrasoft.Social.Google.GoogleConsumer.GetUserEmail(Entity.AccessToken);
				} catch (System.Net.WebException){
					Entity.Login = Entity.Name;
				}
			}
			#endif
			if (string.IsNullOrEmpty(Entity.ConsumerKey)) {
				var value = Terrasoft.Core.Configuration.SysSettings.GetValue(UserConnection, socialNetwork.ToString() + "ConsumerKey");
			 	if (value == null) {
				 	throw new ArgumentNullOrEmptyException("SystemValue." + socialNetwork.ToString() + "ConsumerKey");
				}
				Entity.ConsumerKey = value.ToString();
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "SocialAccount_Base_TerrasoftSaved":
							if (ActivatedEventElements.Contains("SocialAccountSaved")) {
							context.QueueTasks.Enqueue("SocialAccountSaved");
						}
						break;
					case "SocialAccount_Base_TerrasoftSaving":
							if (ActivatedEventElements.Contains("SocialAccountSavingStartMessage")) {
							context.QueueTasks.Enqueue("SocialAccountSavingStartMessage");
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

	#region Class: SocialAccount_BaseEventsProcess

	/// <exclude/>
	public class SocialAccount_BaseEventsProcess : SocialAccount_BaseEventsProcess<SocialAccount_Base_Terrasoft>
	{

		public SocialAccount_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SocialAccount_BaseEventsProcess

	public partial class SocialAccount_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual SocialNetwork GetSocialNetworkType() {
			/*var socialNetworkName = Entity.TypeName;
			
			SocialNetwork socialNetworkType;
			if (!SocialNetwork.TryParse(socialNetworkName, true, out socialNetworkType)) {
				throw new ArgumentException(WrongSocialNetworkTypeLS);
			}
			return socialNetworkType;*/
			/**/
			var typeId = Entity.TypeId;
			
			Guid facebook = new Guid("2795DD03-BACF-E011-92C3-00155D04C01D");
			Guid twitter = new Guid("E7139487-BAD3-E011-92C3-00155D04C01D");
			Guid google = new Guid("efe5d7a2-5f38-e111-851e-00155d04c01d");
			
			if (typeId == facebook) {
				return SocialNetwork.Facebook;
			}
			if (typeId == twitter) {
				return SocialNetwork.Twitter;
			}
			if (typeId == google) {
				return SocialNetwork.Google;
			}
			throw new ArgumentException(WrongSocialNetworkTypeLS);
			//*/
		}

		public virtual bool OnSocialAccountSaved(ProcessExecutingContext context) {
			#if !NETSTANDARD2_0 // TODO CRM-42481
			SocialNetwork socialNetwork = GetSocialNetworkType();
			BaseConsumer.TokenManagers[socialNetwork].Refresh();
			#endif
			return true;
		}

		#endregion

	}

	#endregion

	#region Class: SocialAccount_Base_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class SocialAccount_Base_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseEntityNotesEventsProcessSchema
	{

		#region Constructors: Public

		public SocialAccount_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SocialAccount_Base_TerrasoftEventsProcessSchema(SocialAccount_Base_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SocialAccount_BaseEventsProcess";
			UId = new Guid("9d54bd55-8411-48f9-98ca-bc29ef29e5db");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("58e8159b-d9c4-497b-9d9e-42548d6ffd2e");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaSocialAccountLaneSet1 = CreateSocialAccountLaneSet1LaneSet();
			LaneSets.Add(schemaSocialAccountLaneSet1);
			ProcessSchemaLane schemaSocialAccountLane1 = CreateSocialAccountLane1Lane();
			schemaSocialAccountLaneSet1.Lanes.Add(schemaSocialAccountLane1);
			ProcessSchemaEventSubProcess socialaccountsavedeventsubprocess1 = CreateSocialAccountSavedEventSubProcess1EventSubProcess();
			FlowElements.Add(socialaccountsavedeventsubprocess1);
			ProcessSchemaEventSubProcess socialaccountsavingeventsubprocess2 = CreateSocialAccountSavingEventSubProcess2EventSubProcess();
			FlowElements.Add(socialaccountsavingeventsubprocess2);
			ProcessSchemaStartMessageEvent socialaccountsaved = CreateSocialAccountSavedStartMessageEvent();
			socialaccountsavedeventsubprocess1.FlowElements.Add(socialaccountsaved);
			ProcessSchemaScriptTask socialaccountsavedscripttask1 = CreateSocialAccountSavedScriptTask1ScriptTask();
			socialaccountsavedeventsubprocess1.FlowElements.Add(socialaccountsavedscripttask1);
			ProcessSchemaStartMessageEvent socialaccountsavingstartmessage = CreateSocialAccountSavingStartMessageStartMessageEvent();
			socialaccountsavingeventsubprocess2.FlowElements.Add(socialaccountsavingstartmessage);
			ProcessSchemaScriptTask socialaccountsavingscripttask2 = CreateSocialAccountSavingScriptTask2ScriptTask();
			socialaccountsavingeventsubprocess2.FlowElements.Add(socialaccountsavingscripttask2);
			FlowElements.Add(CreateSocialAccountSavedSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSocialAccountSavingSequenceFlow2SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateWrongSocialNetworkTypeLSLocalizableString());
			LocalizableStrings.Add(CreateDefNameColumnValueLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateWrongSocialNetworkTypeLSLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b269df05-6db9-49ca-bc78-296448a9d069"),
				Name = "WrongSocialNetworkTypeLS",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("9d54bd55-8411-48f9-98ca-bc29ef29e5db"),
				ModifiedInSchemaUId = new Guid("9d54bd55-8411-48f9-98ca-bc29ef29e5db")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDefNameColumnValueLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("fef8bfb9-1f5c-4a6e-9921-f0a37cb09d5a"),
				Name = "DefNameColumnValue",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("9d54bd55-8411-48f9-98ca-bc29ef29e5db"),
				ModifiedInSchemaUId = new Guid("9d54bd55-8411-48f9-98ca-bc29ef29e5db")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSocialAccountSavedSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SocialAccountSavedSequenceFlow1",
				UId = new Guid("f7873cbf-c831-4d58-8353-74fe078206c3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("58e8159b-d9c4-497b-9d9e-42548d6ffd2e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("9d54bd55-8411-48f9-98ca-bc29ef29e5db"),
				CurveCenterPosition = new Point(240, 88),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("9d54bd55-8411-48f9-98ca-bc29ef29e5db"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("42561331-80fc-43d9-a2a5-67058765dd55"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0cf42978-6370-4f7c-aa83-9ba26a8ba6c4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSocialAccountSavingSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SocialAccountSavingSequenceFlow2",
				UId = new Guid("e2eb91dc-4e01-4fa7-a74b-8dbdf24ba09f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("58e8159b-d9c4-497b-9d9e-42548d6ffd2e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("9d54bd55-8411-48f9-98ca-bc29ef29e5db"),
				CurveCenterPosition = new Point(242, 250),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("9d54bd55-8411-48f9-98ca-bc29ef29e5db"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d06130ed-2183-4942-801f-1e30eeb0861b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7103bc2e-16dc-44c0-bccd-f388aa6e1f64"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateSocialAccountLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaSocialAccountLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("10cd0126-65b0-4540-b8f6-f3e85dad85df"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("58e8159b-d9c4-497b-9d9e-42548d6ffd2e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("9d54bd55-8411-48f9-98ca-bc29ef29e5db"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("9d54bd55-8411-48f9-98ca-bc29ef29e5db"),
				Name = @"SocialAccountLaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1373, 338),
				UseBackgroundMode = false
			};
			return schemaSocialAccountLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateSocialAccountLane1Lane() {
			ProcessSchemaLane schemaSocialAccountLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("c3497326-a5ab-42b4-8f55-e2d4e431548a"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("10cd0126-65b0-4540-b8f6-f3e85dad85df"),
				CreatedInOwnerSchemaUId = new Guid("76e3d8e8-6c6b-48b5-9f43-3b361c368bff"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("9d54bd55-8411-48f9-98ca-bc29ef29e5db"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("9d54bd55-8411-48f9-98ca-bc29ef29e5db"),
				Name = @"SocialAccountLane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1344, 338),
				UseBackgroundMode = false
			};
			return schemaSocialAccountLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSocialAccountSavedEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSocialAccountSavedEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("51eb168e-71bb-4142-9ea3-2fe289bce25d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c3497326-a5ab-42b4-8f55-e2d4e431548a"),
				CreatedInOwnerSchemaUId = new Guid("58e8159b-d9c4-497b-9d9e-42548d6ffd2e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("9d54bd55-8411-48f9-98ca-bc29ef29e5db"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("9d54bd55-8411-48f9-98ca-bc29ef29e5db"),
				Name = @"SocialAccountSavedEventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(63, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(350, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSocialAccountSavedEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSocialAccountSavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("42561331-80fc-43d9-a2a5-67058765dd55"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("51eb168e-71bb-4142-9ea3-2fe289bce25d"),
				CreatedInOwnerSchemaUId = new Guid("58e8159b-d9c4-497b-9d9e-42548d6ffd2e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("9d54bd55-8411-48f9-98ca-bc29ef29e5db"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SocialAccountSaved",
				ModifiedInSchemaUId = new Guid("9d54bd55-8411-48f9-98ca-bc29ef29e5db"),
				Name = @"SocialAccountSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(43, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSocialAccountSavedScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0cf42978-6370-4f7c-aa83-9ba26a8ba6c4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("51eb168e-71bb-4142-9ea3-2fe289bce25d"),
				CreatedInOwnerSchemaUId = new Guid("58e8159b-d9c4-497b-9d9e-42548d6ffd2e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("9d54bd55-8411-48f9-98ca-bc29ef29e5db"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("9d54bd55-8411-48f9-98ca-bc29ef29e5db"),
				Name = @"SocialAccountSavedScriptTask1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(183, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,240,207,11,206,79,206,76,204,113,76,78,206,47,205,43,9,78,44,75,77,209,72,206,207,43,73,173,40,209,180,6,0,252,162,223,27,37,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSocialAccountSavingEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSocialAccountSavingEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5e4e0bc7-831c-4729-8480-28d1f840eb72"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c3497326-a5ab-42b4-8f55-e2d4e431548a"),
				CreatedInOwnerSchemaUId = new Guid("58e8159b-d9c4-497b-9d9e-42548d6ffd2e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("9d54bd55-8411-48f9-98ca-bc29ef29e5db"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("9d54bd55-8411-48f9-98ca-bc29ef29e5db"),
				Name = @"SocialAccountSavingEventSubProcess2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(63, 168),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(346, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSocialAccountSavingEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSocialAccountSavingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d06130ed-2183-4942-801f-1e30eeb0861b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5e4e0bc7-831c-4729-8480-28d1f840eb72"),
				CreatedInOwnerSchemaUId = new Guid("58e8159b-d9c4-497b-9d9e-42548d6ffd2e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("9d54bd55-8411-48f9-98ca-bc29ef29e5db"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SocialAccountSaving",
				ModifiedInSchemaUId = new Guid("9d54bd55-8411-48f9-98ca-bc29ef29e5db"),
				Name = @"SocialAccountSavingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(43, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSocialAccountSavingScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7103bc2e-16dc-44c0-bccd-f388aa6e1f64"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5e4e0bc7-831c-4729-8480-28d1f840eb72"),
				CreatedInOwnerSchemaUId = new Guid("58e8159b-d9c4-497b-9d9e-42548d6ffd2e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("9d54bd55-8411-48f9-98ca-bc29ef29e5db"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("9d54bd55-8411-48f9-98ca-bc29ef29e5db"),
				Name = @"SocialAccountSavingScriptTask2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(183, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,82,77,111,211,64,16,61,39,82,254,195,144,94,108,1,46,137,10,2,85,57,68,78,40,168,144,72,141,129,35,50,102,226,90,181,119,163,221,117,130,133,122,40,28,184,84,234,95,137,138,34,34,250,193,95,88,255,35,102,109,7,57,2,132,184,236,104,103,231,237,123,243,102,230,190,0,201,131,200,143,71,168,22,92,156,64,15,14,80,77,234,41,47,155,161,101,239,183,154,173,102,52,5,75,42,17,177,208,121,46,71,105,28,143,197,48,153,169,204,26,50,21,169,204,25,249,9,218,54,124,108,53,27,181,12,253,89,129,158,114,145,248,202,26,224,212,228,93,30,167,9,123,237,199,41,222,219,86,225,120,124,82,32,44,219,16,159,182,154,59,68,125,103,52,244,38,94,127,52,232,31,13,186,111,31,192,238,46,120,227,193,24,220,163,151,247,247,186,123,143,59,70,34,37,159,245,221,67,216,233,116,31,62,233,60,2,189,212,151,249,39,125,171,175,245,146,226,58,255,162,87,249,153,254,174,215,144,127,206,207,40,181,212,55,166,72,95,233,53,157,84,148,159,131,190,4,253,131,64,87,122,5,116,220,234,175,244,120,3,116,92,231,23,213,83,126,174,191,81,44,32,122,69,247,139,202,160,109,63,123,176,229,166,115,192,121,24,99,105,146,18,89,17,55,110,189,224,97,196,200,46,15,133,240,37,159,42,167,196,86,160,42,184,156,201,52,65,225,208,164,94,73,164,17,248,81,188,25,65,63,8,80,74,143,159,32,51,214,53,78,33,240,85,112,12,214,36,147,10,19,135,100,56,111,240,221,240,67,128,51,21,113,102,255,137,191,54,188,226,143,114,4,200,222,71,211,127,47,193,70,222,33,102,213,46,204,105,203,230,102,204,91,173,185,92,160,41,158,70,97,42,124,163,197,33,141,19,84,138,190,150,166,185,98,53,44,211,34,149,49,12,76,205,223,55,5,238,66,187,198,221,54,237,67,195,168,173,184,123,192,72,109,41,9,26,234,88,240,5,48,92,64,95,132,132,97,170,214,203,47,123,172,118,233,91,33,197,105,19,199,255,208,27,231,26,191,219,66,54,20,146,106,232,114,203,5,170,84,48,80,34,197,253,159,42,64,174,225,155,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetSocialNetworkTypeMethod());
			Methods.Add(CreateOnSocialAccountSavedMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ad97be27-1447-4d06-97ca-6f07387e99d4"),
				Name = "Terrasoft.Social",
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

		protected virtual SchemaMethod CreateGetSocialNetworkTypeMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4b3ed9d2-e06d-45bb-ad47-6b054467a6fe"),
				Name = "GetSocialNetworkType",
				CreatedInSchemaUId = new Guid("9d54bd55-8411-48f9-98ca-bc29ef29e5db"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "SocialNetwork"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,145,81,107,194,48,20,133,159,87,232,127,200,124,170,101,181,73,107,169,50,124,112,182,138,48,100,160,176,231,174,189,237,138,218,72,76,215,201,216,127,55,105,220,88,166,56,216,75,30,46,231,124,57,231,94,215,126,75,24,218,211,180,76,54,11,224,13,101,235,69,178,5,52,66,113,197,75,126,232,173,14,59,144,147,123,211,48,141,229,79,157,238,146,58,161,41,115,100,221,106,178,222,138,29,158,18,182,7,235,236,151,59,196,89,45,94,90,243,115,88,183,139,62,76,227,134,191,50,218,160,10,26,52,102,69,189,133,138,199,239,41,236,120,73,43,235,153,209,170,88,254,54,62,46,187,34,200,167,105,48,224,53,171,46,196,180,93,211,112,109,249,202,242,92,140,230,153,222,120,158,181,125,103,117,153,161,60,73,225,133,210,181,80,200,24,114,102,117,188,112,24,68,17,246,157,135,241,100,234,196,152,16,103,232,77,124,7,99,18,4,17,238,79,48,137,58,50,71,139,224,77,201,57,48,141,16,135,196,31,246,7,161,32,68,254,159,132,130,210,98,3,26,0,114,8,178,48,241,156,32,247,7,14,16,1,24,4,4,20,32,195,253,20,147,172,5,168,171,124,213,28,125,23,82,11,62,109,73,191,217,244,36,81,139,212,237,167,50,87,220,43,165,184,100,86,61,174,120,103,173,64,89,255,123,123,215,181,221,35,236,126,48,224,217,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnSocialAccountSavedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f08b4e6e-67f6-4868-8c5b-706f38608c25"),
				Name = "OnSocialAccountSaved",
				CreatedInSchemaUId = new Guid("9d54bd55-8411-48f9-98ca-bc29ef29e5db"),
				CreatedInPackageId = new Guid("fa2eb5ad-958f-4492-adde-c5914e708d28"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d67f5f51-d6e1-427c-889a-9629faf4098e"),
				Name = "context",
				CreatedInSchemaUId = new Guid("9d54bd55-8411-48f9-98ca-bc29ef29e5db"),
				ModifiedInSchemaUId = new Guid("9d54bd55-8411-48f9-98ca-bc29ef29e5db"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext",
				CreatedInPackageId = new Guid("fa2eb5ad-958f-4492-adde-c5914e708d28")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,83,206,76,83,80,244,115,13,9,14,113,244,115,113,12,114,49,138,55,80,208,215,87,8,241,119,241,87,112,14,242,213,53,49,50,177,48,228,229,10,206,79,206,76,204,241,75,45,41,207,47,202,86,40,70,225,217,42,184,167,150,160,40,8,169,44,72,213,208,180,230,229,114,74,44,78,117,206,207,43,46,205,77,45,210,11,201,207,78,205,243,77,204,75,76,79,45,42,142,70,49,35,86,47,40,53,173,40,181,56,3,172,75,57,53,47,37,51,141,151,171,40,181,164,180,40,79,161,164,168,52,213,26,0,201,124,254,38,168,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SocialAccount_Base_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9d54bd55-8411-48f9-98ca-bc29ef29e5db"));
		}

		#endregion

	}

	#endregion

}

