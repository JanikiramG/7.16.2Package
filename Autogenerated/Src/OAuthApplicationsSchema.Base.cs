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

	#region Class: OAuthApplicationsSchema

	/// <exclude/>
	public class OAuthApplicationsSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public OAuthApplicationsSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OAuthApplicationsSchema(OAuthApplicationsSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OAuthApplicationsSchema(OAuthApplicationsSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2d30ef0a-87fb-474a-a348-a8cb46e23e6e");
			RealUId = new Guid("2d30ef0a-87fb-474a-a348-a8cb46e23e6e");
			Name = "OAuthApplications";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("50cc600a-f6aa-433b-8a0a-6a453519907c");
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

		protected override void InitializePrimaryImageColumn() {
			base.InitializePrimaryImageColumn();
			PrimaryImageColumn = CreateImageColumn();
			if (Columns.FindByUId(PrimaryImageColumn.UId) == null) {
				Columns.Add(PrimaryImageColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("ff56ff05-b1c4-4cca-bb1c-b1e88ce1fb36")) == null) {
				Columns.Add(CreateAppClassNameColumn());
			}
			if (Columns.FindByUId(new Guid("25b81a92-15d8-43b3-a986-18007b5a2b9f")) == null) {
				Columns.Add(CreateClientIdColumn());
			}
			if (Columns.FindByUId(new Guid("54753aca-e9e6-4efc-b67f-163fcedefdcb")) == null) {
				Columns.Add(CreateSecretKeyColumn());
			}
			if (Columns.FindByUId(new Guid("636dcd5b-1bab-49e8-8f58-f1a3c9751525")) == null) {
				Columns.Add(CreateClientClassNameColumn());
			}
			if (Columns.FindByUId(new Guid("114f5ac1-7326-48e5-a92f-c7cdccc873c1")) == null) {
				Columns.Add(CreateAuthorizeUrlColumn());
			}
			if (Columns.FindByUId(new Guid("32329b4a-92b9-4af5-9b45-d2813b24528f")) == null) {
				Columns.Add(CreateTokenUrlColumn());
			}
			if (Columns.FindByUId(new Guid("42911b99-fe17-40a7-a9a2-c3e3331c76cf")) == null) {
				Columns.Add(CreateRevokeTokenUrlColumn());
			}
			if (Columns.FindByUId(new Guid("d849f752-56b3-483b-bc33-f51789c20a4c")) == null) {
				Columns.Add(CreateUseSharedUserColumn());
			}
			if (Columns.FindByUId(new Guid("bc1a953f-394c-4cda-9149-4c568c4143b4")) == null) {
				Columns.Add(CreateSharedUserColumn());
			}
			if (Columns.FindByUId(new Guid("3724e6cd-8fb6-42bb-b0f6-e77ebc33c7de")) == null) {
				Columns.Add(CreateCredentialsLocationInRequestColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateAppClassNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("ff56ff05-b1c4-4cca-bb1c-b1e88ce1fb36"),
				Name = @"AppClassName",
				CreatedInSchemaUId = new Guid("2d30ef0a-87fb-474a-a348-a8cb46e23e6e"),
				ModifiedInSchemaUId = new Guid("2d30ef0a-87fb-474a-a348-a8cb46e23e6e"),
				CreatedInPackageId = new Guid("50cc600a-f6aa-433b-8a0a-6a453519907c")
			};
		}

		protected virtual EntitySchemaColumn CreateClientIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("25b81a92-15d8-43b3-a986-18007b5a2b9f"),
				Name = @"ClientId",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("2d30ef0a-87fb-474a-a348-a8cb46e23e6e"),
				ModifiedInSchemaUId = new Guid("2d30ef0a-87fb-474a-a348-a8cb46e23e6e"),
				CreatedInPackageId = new Guid("50cc600a-f6aa-433b-8a0a-6a453519907c")
			};
		}

		protected virtual EntitySchemaColumn CreateSecretKeyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("SecureText")) {
				UId = new Guid("54753aca-e9e6-4efc-b67f-163fcedefdcb"),
				Name = @"SecretKey",
				CreatedInSchemaUId = new Guid("2d30ef0a-87fb-474a-a348-a8cb46e23e6e"),
				ModifiedInSchemaUId = new Guid("2d30ef0a-87fb-474a-a348-a8cb46e23e6e"),
				CreatedInPackageId = new Guid("50cc600a-f6aa-433b-8a0a-6a453519907c")
			};
		}

		protected virtual EntitySchemaColumn CreateClientClassNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("636dcd5b-1bab-49e8-8f58-f1a3c9751525"),
				Name = @"ClientClassName",
				CreatedInSchemaUId = new Guid("2d30ef0a-87fb-474a-a348-a8cb46e23e6e"),
				ModifiedInSchemaUId = new Guid("2d30ef0a-87fb-474a-a348-a8cb46e23e6e"),
				CreatedInPackageId = new Guid("50cc600a-f6aa-433b-8a0a-6a453519907c")
			};
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("f7effb5b-0eb5-48c2-8357-7c0f833fbbbe"),
				Name = @"Name",
				CreatedInSchemaUId = new Guid("2d30ef0a-87fb-474a-a348-a8cb46e23e6e"),
				ModifiedInSchemaUId = new Guid("2d30ef0a-87fb-474a-a348-a8cb46e23e6e"),
				CreatedInPackageId = new Guid("c02eddad-e397-4b12-a902-1e0c1f106f02")
			};
		}

		protected virtual EntitySchemaColumn CreateAuthorizeUrlColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("114f5ac1-7326-48e5-a92f-c7cdccc873c1"),
				Name = @"AuthorizeUrl",
				CreatedInSchemaUId = new Guid("2d30ef0a-87fb-474a-a348-a8cb46e23e6e"),
				ModifiedInSchemaUId = new Guid("2d30ef0a-87fb-474a-a348-a8cb46e23e6e"),
				CreatedInPackageId = new Guid("79d5e1e4-18af-4001-8dc1-26f09fca92c2")
			};
		}

		protected virtual EntitySchemaColumn CreateTokenUrlColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("32329b4a-92b9-4af5-9b45-d2813b24528f"),
				Name = @"TokenUrl",
				CreatedInSchemaUId = new Guid("2d30ef0a-87fb-474a-a348-a8cb46e23e6e"),
				ModifiedInSchemaUId = new Guid("2d30ef0a-87fb-474a-a348-a8cb46e23e6e"),
				CreatedInPackageId = new Guid("79d5e1e4-18af-4001-8dc1-26f09fca92c2")
			};
		}

		protected virtual EntitySchemaColumn CreateRevokeTokenUrlColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("42911b99-fe17-40a7-a9a2-c3e3331c76cf"),
				Name = @"RevokeTokenUrl",
				CreatedInSchemaUId = new Guid("2d30ef0a-87fb-474a-a348-a8cb46e23e6e"),
				ModifiedInSchemaUId = new Guid("2d30ef0a-87fb-474a-a348-a8cb46e23e6e"),
				CreatedInPackageId = new Guid("79d5e1e4-18af-4001-8dc1-26f09fca92c2")
			};
		}

		protected virtual EntitySchemaColumn CreateUseSharedUserColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("d849f752-56b3-483b-bc33-f51789c20a4c"),
				Name = @"UseSharedUser",
				CreatedInSchemaUId = new Guid("2d30ef0a-87fb-474a-a348-a8cb46e23e6e"),
				ModifiedInSchemaUId = new Guid("2d30ef0a-87fb-474a-a348-a8cb46e23e6e"),
				CreatedInPackageId = new Guid("79d5e1e4-18af-4001-8dc1-26f09fca92c2")
			};
		}

		protected virtual EntitySchemaColumn CreateSharedUserColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("bc1a953f-394c-4cda-9149-4c568c4143b4"),
				Name = @"SharedUser",
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("2d30ef0a-87fb-474a-a348-a8cb46e23e6e"),
				ModifiedInSchemaUId = new Guid("2d30ef0a-87fb-474a-a348-a8cb46e23e6e"),
				CreatedInPackageId = new Guid("79d5e1e4-18af-4001-8dc1-26f09fca92c2")
			};
		}

		protected virtual EntitySchemaColumn CreateImageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ImageLookup")) {
				UId = new Guid("7765873b-eeb6-4764-833e-75aa88f9dfd5"),
				Name = @"Image",
				ReferenceSchemaUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8"),
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("2d30ef0a-87fb-474a-a348-a8cb46e23e6e"),
				ModifiedInSchemaUId = new Guid("2d30ef0a-87fb-474a-a348-a8cb46e23e6e"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateCredentialsLocationInRequestColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("3724e6cd-8fb6-42bb-b0f6-e77ebc33c7de"),
				Name = @"CredentialsLocationInRequest",
				CreatedInSchemaUId = new Guid("2d30ef0a-87fb-474a-a348-a8cb46e23e6e"),
				ModifiedInSchemaUId = new Guid("2d30ef0a-87fb-474a-a348-a8cb46e23e6e"),
				CreatedInPackageId = new Guid("be866e7e-6f1f-4a76-b963-c31de8aa05fe")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateOAuthApplicationsEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateOAuthApplicationsEventsProcessSchema() {
			var schema = new OAuthApplicationsEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new OAuthApplications(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OAuthApplications_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OAuthApplicationsSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OAuthApplicationsSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2d30ef0a-87fb-474a-a348-a8cb46e23e6e"));
		}

		#endregion

	}

	#endregion

	#region Class: OAuthApplications

	/// <summary>
	/// OAuth applications settings.
	/// </summary>
	public class OAuthApplications : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public OAuthApplications(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OAuthApplications";
		}

		public OAuthApplications(OAuthApplications source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Application class name.
		/// </summary>
		public string AppClassName {
			get {
				return GetTypedColumnValue<string>("AppClassName");
			}
			set {
				SetColumnValue("AppClassName", value);
			}
		}

		/// <summary>
		/// Application client identifier.
		/// </summary>
		public string ClientId {
			get {
				return GetTypedColumnValue<string>("ClientId");
			}
			set {
				SetColumnValue("ClientId", value);
			}
		}

		/// <summary>
		/// Application secret key.
		/// </summary>
		public string SecretKey {
			get {
				return GetTypedColumnValue<string>("SecretKey");
			}
			set {
				SetColumnValue("SecretKey", value);
			}
		}

		/// <summary>
		/// OAuth client class name.
		/// </summary>
		public string ClientClassName {
			get {
				return GetTypedColumnValue<string>("ClientClassName");
			}
			set {
				SetColumnValue("ClientClassName", value);
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

		/// <summary>
		/// Auth code request URL.
		/// </summary>
		public string AuthorizeUrl {
			get {
				return GetTypedColumnValue<string>("AuthorizeUrl");
			}
			set {
				SetColumnValue("AuthorizeUrl", value);
			}
		}

		/// <summary>
		/// Access token request URL.
		/// </summary>
		public string TokenUrl {
			get {
				return GetTypedColumnValue<string>("TokenUrl");
			}
			set {
				SetColumnValue("TokenUrl", value);
			}
		}

		/// <summary>
		/// Revoke token URL.
		/// </summary>
		public string RevokeTokenUrl {
			get {
				return GetTypedColumnValue<string>("RevokeTokenUrl");
			}
			set {
				SetColumnValue("RevokeTokenUrl", value);
			}
		}

		/// <summary>
		/// Use shared user.
		/// </summary>
		public bool UseSharedUser {
			get {
				return GetTypedColumnValue<bool>("UseSharedUser");
			}
			set {
				SetColumnValue("UseSharedUser", value);
			}
		}

		/// <exclude/>
		public Guid SharedUserId {
			get {
				return GetTypedColumnValue<Guid>("SharedUserId");
			}
			set {
				SetColumnValue("SharedUserId", value);
				_sharedUser = null;
			}
		}

		/// <exclude/>
		public string SharedUserName {
			get {
				return GetTypedColumnValue<string>("SharedUserName");
			}
			set {
				SetColumnValue("SharedUserName", value);
				if (_sharedUser != null) {
					_sharedUser.Name = value;
				}
			}
		}

		private SysAdminUnit _sharedUser;
		/// <summary>
		/// Shared user.
		/// </summary>
		public SysAdminUnit SharedUser {
			get {
				return _sharedUser ??
					(_sharedUser = LookupColumnEntities.GetEntity("SharedUser") as SysAdminUnit);
			}
		}

		/// <exclude/>
		public Guid ImageId {
			get {
				return GetTypedColumnValue<Guid>("ImageId");
			}
			set {
				SetColumnValue("ImageId", value);
				_image = null;
			}
		}

		/// <exclude/>
		public string ImageName {
			get {
				return GetTypedColumnValue<string>("ImageName");
			}
			set {
				SetColumnValue("ImageName", value);
				if (_image != null) {
					_image.Name = value;
				}
			}
		}

		private SysImage _image;
		/// <summary>
		/// Image.
		/// </summary>
		/// <remarks>
		/// Image.
		/// </remarks>
		public SysImage Image {
			get {
				return _image ??
					(_image = LookupColumnEntities.GetEntity("Image") as SysImage);
			}
		}

		/// <summary>
		/// Send client credentials as.
		/// </summary>
		public int CredentialsLocationInRequest {
			get {
				return GetTypedColumnValue<int>("CredentialsLocationInRequest");
			}
			set {
				SetColumnValue("CredentialsLocationInRequest", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OAuthApplications_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("OAuthApplicationsDeleted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OAuthApplications(this);
		}

		#endregion

	}

	#endregion

	#region Class: OAuthApplications_BaseEventsProcess

	/// <exclude/>
	public partial class OAuthApplications_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : OAuthApplications
	{

		public OAuthApplications_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OAuthApplications_BaseEventsProcess";
			SchemaUId = new Guid("2d30ef0a-87fb-474a-a348-a8cb46e23e6e");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("2d30ef0a-87fb-474a-a348-a8cb46e23e6e");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
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

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
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

	#region Class: OAuthApplications_BaseEventsProcess

	/// <exclude/>
	public class OAuthApplications_BaseEventsProcess : OAuthApplications_BaseEventsProcess<OAuthApplications>
	{

		public OAuthApplications_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OAuthApplications_BaseEventsProcess

	public partial class OAuthApplications_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: OAuthApplicationsEventsProcessSchema

	/// <exclude/>
	public class OAuthApplicationsEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public OAuthApplicationsEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public OAuthApplicationsEventsProcessSchema(OAuthApplicationsEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "OAuthApplications_BaseEventsProcess";
			UId = new Guid("1838f774-e195-4101-927b-c1da7236f6f5");
			CreatedInPackageId = new Guid("50cc600a-f6aa-433b-8a0a-6a453519907c");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
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
			return new OAuthApplicationsEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1838f774-e195-4101-927b-c1da7236f6f5"));
		}

		#endregion

	}

	#endregion


	#region Class: OAuthApplicationsEventsProcess

	/// <exclude/>
	public class OAuthApplicationsEventsProcess : OAuthApplications_BaseEventsProcess
	{

		public OAuthApplicationsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

