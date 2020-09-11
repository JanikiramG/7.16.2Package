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

	#region Class: PushNotificationTokenSchema

	/// <exclude/>
	public class PushNotificationTokenSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public PushNotificationTokenSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public PushNotificationTokenSchema(PushNotificationTokenSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public PushNotificationTokenSchema(PushNotificationTokenSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fedf93e5-48af-4c6c-a612-53b86dd7cf69");
			RealUId = new Guid("fedf93e5-48af-4c6c-a612-53b86dd7cf69");
			Name = "PushNotificationToken";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("62eca4a1-acc6-4a36-b0ab-f43c90a8a369");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("d816bac6-25a3-4f80-8c30-d1f92b0c8d1a")) == null) {
				Columns.Add(CreateTokenColumn());
			}
			if (Columns.FindByUId(new Guid("09c047d0-45f6-4b9f-b086-021c540ebf2a")) == null) {
				Columns.Add(CreateServiceColumn());
			}
			if (Columns.FindByUId(new Guid("1b9fa52b-76b3-4822-87fb-4591cf585268")) == null) {
				Columns.Add(CreateSysAdminUnitColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateTokenColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("d816bac6-25a3-4f80-8c30-d1f92b0c8d1a"),
				Name = @"Token",
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("fedf93e5-48af-4c6c-a612-53b86dd7cf69"),
				ModifiedInSchemaUId = new Guid("fedf93e5-48af-4c6c-a612-53b86dd7cf69"),
				CreatedInPackageId = new Guid("62eca4a1-acc6-4a36-b0ab-f43c90a8a369")
			};
		}

		protected virtual EntitySchemaColumn CreateServiceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("09c047d0-45f6-4b9f-b086-021c540ebf2a"),
				Name = @"Service",
				ReferenceSchemaUId = new Guid("823395a1-42be-4826-ad71-0ab38f575d57"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("fedf93e5-48af-4c6c-a612-53b86dd7cf69"),
				ModifiedInSchemaUId = new Guid("fedf93e5-48af-4c6c-a612-53b86dd7cf69"),
				CreatedInPackageId = new Guid("62eca4a1-acc6-4a36-b0ab-f43c90a8a369")
			};
		}

		protected virtual EntitySchemaColumn CreateSysAdminUnitColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("1b9fa52b-76b3-4822-87fb-4591cf585268"),
				Name = @"SysAdminUnit",
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("fedf93e5-48af-4c6c-a612-53b86dd7cf69"),
				ModifiedInSchemaUId = new Guid("fedf93e5-48af-4c6c-a612-53b86dd7cf69"),
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreatePushNotificationTokenEventsProcessSchema();
		}

		protected virtual ProcessSchema CreatePushNotificationTokenEventsProcessSchema() {
			var schema = new PushNotificationTokenEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new PushNotificationToken(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new PushNotificationToken_NUIEventsProcess(userConnection);
		}

		public override object Clone() {
			return new PushNotificationTokenSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new PushNotificationTokenSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fedf93e5-48af-4c6c-a612-53b86dd7cf69"));
		}

		#endregion

	}

	#endregion

	#region Class: PushNotificationToken

	/// <summary>
	/// Push notification token.
	/// </summary>
	public class PushNotificationToken : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public PushNotificationToken(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "PushNotificationToken";
		}

		public PushNotificationToken(PushNotificationToken source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Token.
		/// </summary>
		public string Token {
			get {
				return GetTypedColumnValue<string>("Token");
			}
			set {
				SetColumnValue("Token", value);
			}
		}

		/// <exclude/>
		public Guid ServiceId {
			get {
				return GetTypedColumnValue<Guid>("ServiceId");
			}
			set {
				SetColumnValue("ServiceId", value);
				_service = null;
			}
		}

		private PushNotificationService _service;
		/// <summary>
		/// Service.
		/// </summary>
		public PushNotificationService Service {
			get {
				return _service ??
					(_service = LookupColumnEntities.GetEntity("Service") as PushNotificationService);
			}
		}

		/// <exclude/>
		public Guid SysAdminUnitId {
			get {
				return GetTypedColumnValue<Guid>("SysAdminUnitId");
			}
			set {
				SetColumnValue("SysAdminUnitId", value);
				_sysAdminUnit = null;
			}
		}

		/// <exclude/>
		public string SysAdminUnitName {
			get {
				return GetTypedColumnValue<string>("SysAdminUnitName");
			}
			set {
				SetColumnValue("SysAdminUnitName", value);
				if (_sysAdminUnit != null) {
					_sysAdminUnit.Name = value;
				}
			}
		}

		private SysAdminUnit _sysAdminUnit;
		/// <summary>
		/// SysAdminUnit.
		/// </summary>
		public SysAdminUnit SysAdminUnit {
			get {
				return _sysAdminUnit ??
					(_sysAdminUnit = LookupColumnEntities.GetEntity("SysAdminUnit") as SysAdminUnit);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new PushNotificationToken_NUIEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("PushNotificationTokenDeleted", e);
			Validating += (s, e) => ThrowEvent("PushNotificationTokenValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new PushNotificationToken(this);
		}

		#endregion

	}

	#endregion

	#region Class: PushNotificationToken_NUIEventsProcess

	/// <exclude/>
	public partial class PushNotificationToken_NUIEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : PushNotificationToken
	{

		public PushNotificationToken_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "PushNotificationToken_NUIEventsProcess";
			SchemaUId = new Guid("fedf93e5-48af-4c6c-a612-53b86dd7cf69");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("fedf93e5-48af-4c6c-a612-53b86dd7cf69");
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

	#region Class: PushNotificationToken_NUIEventsProcess

	/// <exclude/>
	public class PushNotificationToken_NUIEventsProcess : PushNotificationToken_NUIEventsProcess<PushNotificationToken>
	{

		public PushNotificationToken_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: PushNotificationToken_NUIEventsProcess

	public partial class PushNotificationToken_NUIEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: PushNotificationTokenEventsProcessSchema

	/// <exclude/>
	public class PushNotificationTokenEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public PushNotificationTokenEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public PushNotificationTokenEventsProcessSchema(PushNotificationTokenEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "PushNotificationToken_NUIEventsProcess";
			UId = new Guid("eb5eb206-3c61-412d-825b-168b2774aaa2");
			CreatedInPackageId = new Guid("62eca4a1-acc6-4a36-b0ab-f43c90a8a369");
			CreatedInSchemaUId = Guid.Empty;
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
			return new PushNotificationTokenEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("eb5eb206-3c61-412d-825b-168b2774aaa2"));
		}

		#endregion

	}

	#endregion


	#region Class: PushNotificationTokenEventsProcess

	/// <exclude/>
	public class PushNotificationTokenEventsProcess : PushNotificationToken_NUIEventsProcess
	{

		public PushNotificationTokenEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

