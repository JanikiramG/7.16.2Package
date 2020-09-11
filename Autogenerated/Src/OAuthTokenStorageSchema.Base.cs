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

	#region Class: OAuthTokenStorageSchema

	/// <exclude/>
	public class OAuthTokenStorageSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public OAuthTokenStorageSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OAuthTokenStorageSchema(OAuthTokenStorageSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OAuthTokenStorageSchema(OAuthTokenStorageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("44bea56e-8a8f-4e29-9494-83253eff2594");
			RealUId = new Guid("44bea56e-8a8f-4e29-9494-83253eff2594");
			Name = "OAuthTokenStorage";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("50cc600a-f6aa-433b-8a0a-6a453519907c");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateUserAppLoginColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("3a37740a-7e7e-45ed-b2a2-f6482dafefe9")) == null) {
				Columns.Add(CreateSysUserColumn());
			}
			if (Columns.FindByUId(new Guid("35673cfd-354a-416c-a824-6fa612a876a2")) == null) {
				Columns.Add(CreateOAuthAppColumn());
			}
			if (Columns.FindByUId(new Guid("f1dabb64-da9f-4306-9d38-ae52b6c1b925")) == null) {
				Columns.Add(CreateAccessTokenColumn());
			}
			if (Columns.FindByUId(new Guid("774d7660-da12-4f13-a088-de743505261e")) == null) {
				Columns.Add(CreateExpiresOnColumn());
			}
			if (Columns.FindByUId(new Guid("220e66ae-dec6-4fec-b6cd-819ae1615d3f")) == null) {
				Columns.Add(CreateRefreshTokenColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSysUserColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("3a37740a-7e7e-45ed-b2a2-f6482dafefe9"),
				Name = @"SysUser",
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("44bea56e-8a8f-4e29-9494-83253eff2594"),
				ModifiedInSchemaUId = new Guid("44bea56e-8a8f-4e29-9494-83253eff2594"),
				CreatedInPackageId = new Guid("50cc600a-f6aa-433b-8a0a-6a453519907c")
			};
		}

		protected virtual EntitySchemaColumn CreateOAuthAppColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("35673cfd-354a-416c-a824-6fa612a876a2"),
				Name = @"OAuthApp",
				ReferenceSchemaUId = new Guid("2d30ef0a-87fb-474a-a348-a8cb46e23e6e"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("44bea56e-8a8f-4e29-9494-83253eff2594"),
				ModifiedInSchemaUId = new Guid("44bea56e-8a8f-4e29-9494-83253eff2594"),
				CreatedInPackageId = new Guid("50cc600a-f6aa-433b-8a0a-6a453519907c")
			};
		}

		protected virtual EntitySchemaColumn CreateUserAppLoginColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("aa664285-bd27-4cbc-a929-0dab4c3ef45e"),
				Name = @"UserAppLogin",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("44bea56e-8a8f-4e29-9494-83253eff2594"),
				ModifiedInSchemaUId = new Guid("44bea56e-8a8f-4e29-9494-83253eff2594"),
				CreatedInPackageId = new Guid("50cc600a-f6aa-433b-8a0a-6a453519907c")
			};
		}

		protected virtual EntitySchemaColumn CreateAccessTokenColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("f1dabb64-da9f-4306-9d38-ae52b6c1b925"),
				Name = @"AccessToken",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("44bea56e-8a8f-4e29-9494-83253eff2594"),
				ModifiedInSchemaUId = new Guid("44bea56e-8a8f-4e29-9494-83253eff2594"),
				CreatedInPackageId = new Guid("50cc600a-f6aa-433b-8a0a-6a453519907c")
			};
		}

		protected virtual EntitySchemaColumn CreateExpiresOnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("774d7660-da12-4f13-a088-de743505261e"),
				Name = @"ExpiresOn",
				CreatedInSchemaUId = new Guid("44bea56e-8a8f-4e29-9494-83253eff2594"),
				ModifiedInSchemaUId = new Guid("44bea56e-8a8f-4e29-9494-83253eff2594"),
				CreatedInPackageId = new Guid("50cc600a-f6aa-433b-8a0a-6a453519907c")
			};
		}

		protected virtual EntitySchemaColumn CreateRefreshTokenColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("220e66ae-dec6-4fec-b6cd-819ae1615d3f"),
				Name = @"RefreshToken",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("44bea56e-8a8f-4e29-9494-83253eff2594"),
				ModifiedInSchemaUId = new Guid("44bea56e-8a8f-4e29-9494-83253eff2594"),
				CreatedInPackageId = new Guid("50cc600a-f6aa-433b-8a0a-6a453519907c")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateOAuthTokenStorageEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateOAuthTokenStorageEventsProcessSchema() {
			var schema = new OAuthTokenStorageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new OAuthTokenStorage(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OAuthTokenStorage_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OAuthTokenStorageSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OAuthTokenStorageSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("44bea56e-8a8f-4e29-9494-83253eff2594"));
		}

		#endregion

	}

	#endregion

	#region Class: OAuthTokenStorage

	/// <summary>
	/// Store of authorization tokens.
	/// </summary>
	public class OAuthTokenStorage : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public OAuthTokenStorage(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OAuthTokenStorage";
		}

		public OAuthTokenStorage(OAuthTokenStorage source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid SysUserId {
			get {
				return GetTypedColumnValue<Guid>("SysUserId");
			}
			set {
				SetColumnValue("SysUserId", value);
				_sysUser = null;
			}
		}

		/// <exclude/>
		public string SysUserName {
			get {
				return GetTypedColumnValue<string>("SysUserName");
			}
			set {
				SetColumnValue("SysUserName", value);
				if (_sysUser != null) {
					_sysUser.Name = value;
				}
			}
		}

		private SysAdminUnit _sysUser;
		/// <summary>
		/// System administrative unit identifier.
		/// </summary>
		public SysAdminUnit SysUser {
			get {
				return _sysUser ??
					(_sysUser = LookupColumnEntities.GetEntity("SysUser") as SysAdminUnit);
			}
		}

		/// <exclude/>
		public Guid OAuthAppId {
			get {
				return GetTypedColumnValue<Guid>("OAuthAppId");
			}
			set {
				SetColumnValue("OAuthAppId", value);
				_oAuthApp = null;
			}
		}

		/// <exclude/>
		public string OAuthAppName {
			get {
				return GetTypedColumnValue<string>("OAuthAppName");
			}
			set {
				SetColumnValue("OAuthAppName", value);
				if (_oAuthApp != null) {
					_oAuthApp.Name = value;
				}
			}
		}

		private OAuthApplications _oAuthApp;
		/// <summary>
		/// OAuth application identifier.
		/// </summary>
		public OAuthApplications OAuthApp {
			get {
				return _oAuthApp ??
					(_oAuthApp = LookupColumnEntities.GetEntity("OAuthApp") as OAuthApplications);
			}
		}

		/// <summary>
		/// User login to the application.
		/// </summary>
		public string UserAppLogin {
			get {
				return GetTypedColumnValue<string>("UserAppLogin");
			}
			set {
				SetColumnValue("UserAppLogin", value);
			}
		}

		/// <summary>
		/// OAuth access token.
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
		/// Time in seconds since 1970.01.01 after which the token expires.
		/// </summary>
		public int ExpiresOn {
			get {
				return GetTypedColumnValue<int>("ExpiresOn");
			}
			set {
				SetColumnValue("ExpiresOn", value);
			}
		}

		/// <summary>
		/// OAuth refresh token.
		/// </summary>
		public string RefreshToken {
			get {
				return GetTypedColumnValue<string>("RefreshToken");
			}
			set {
				SetColumnValue("RefreshToken", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OAuthTokenStorage_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("OAuthTokenStorageDeleted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OAuthTokenStorage(this);
		}

		#endregion

	}

	#endregion

	#region Class: OAuthTokenStorage_BaseEventsProcess

	/// <exclude/>
	public partial class OAuthTokenStorage_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : OAuthTokenStorage
	{

		public OAuthTokenStorage_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OAuthTokenStorage_BaseEventsProcess";
			SchemaUId = new Guid("44bea56e-8a8f-4e29-9494-83253eff2594");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("44bea56e-8a8f-4e29-9494-83253eff2594");
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

	#region Class: OAuthTokenStorage_BaseEventsProcess

	/// <exclude/>
	public class OAuthTokenStorage_BaseEventsProcess : OAuthTokenStorage_BaseEventsProcess<OAuthTokenStorage>
	{

		public OAuthTokenStorage_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OAuthTokenStorage_BaseEventsProcess

	public partial class OAuthTokenStorage_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: OAuthTokenStorageEventsProcessSchema

	/// <exclude/>
	public class OAuthTokenStorageEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public OAuthTokenStorageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public OAuthTokenStorageEventsProcessSchema(OAuthTokenStorageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "OAuthTokenStorage_BaseEventsProcess";
			UId = new Guid("6c2d0481-4e35-42c5-b276-15895ed56ce6");
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
			return new OAuthTokenStorageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6c2d0481-4e35-42c5-b276-15895ed56ce6"));
		}

		#endregion

	}

	#endregion


	#region Class: OAuthTokenStorageEventsProcess

	/// <exclude/>
	public class OAuthTokenStorageEventsProcess : OAuthTokenStorage_BaseEventsProcess
	{

		public OAuthTokenStorageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

