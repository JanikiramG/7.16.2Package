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

	#region Class: NotificationsSettingsSchema

	/// <exclude/>
	public class NotificationsSettingsSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public NotificationsSettingsSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public NotificationsSettingsSchema(NotificationsSettingsSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public NotificationsSettingsSchema(NotificationsSettingsSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0c7a653b-33bc-471e-abca-aa4e330cc323");
			RealUId = new Guid("0c7a653b-33bc-471e-abca-aa4e330cc323");
			Name = "NotificationsSettings";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("271744d8-d0f2-48d8-a4d0-e376f30523b7");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("3baa7dcf-3db9-4542-acfe-9a50a538032a")) == null) {
				Columns.Add(CreateSysImageColumn());
			}
			if (Columns.FindByUId(new Guid("5ea1329f-117e-4f0c-87c0-5125f293f117")) == null) {
				Columns.Add(CreateNotificationTypeColumn());
			}
			if (Columns.FindByUId(new Guid("d44b61a5-0338-45f8-a890-0f1ea2190d90")) == null) {
				Columns.Add(CreateSysEntitySchemaUIdColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSysImageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("3baa7dcf-3db9-4542-acfe-9a50a538032a"),
				Name = @"SysImage",
				ReferenceSchemaUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("0c7a653b-33bc-471e-abca-aa4e330cc323"),
				ModifiedInSchemaUId = new Guid("0c7a653b-33bc-471e-abca-aa4e330cc323"),
				CreatedInPackageId = new Guid("271744d8-d0f2-48d8-a4d0-e376f30523b7")
			};
		}

		protected virtual EntitySchemaColumn CreateNotificationTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("5ea1329f-117e-4f0c-87c0-5125f293f117"),
				Name = @"NotificationType",
				ReferenceSchemaUId = new Guid("ef45b183-3adb-4b37-a099-8d28e9ee9b3a"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("0c7a653b-33bc-471e-abca-aa4e330cc323"),
				ModifiedInSchemaUId = new Guid("0c7a653b-33bc-471e-abca-aa4e330cc323"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateSysEntitySchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("d44b61a5-0338-45f8-a890-0f1ea2190d90"),
				Name = @"SysEntitySchemaUId",
				CreatedInSchemaUId = new Guid("0c7a653b-33bc-471e-abca-aa4e330cc323"),
				ModifiedInSchemaUId = new Guid("0c7a653b-33bc-471e-abca-aa4e330cc323"),
				CreatedInPackageId = new Guid("271744d8-d0f2-48d8-a4d0-e376f30523b7")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateNotificationsSettingsEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateNotificationsSettingsEventsProcessSchema() {
			var schema = new NotificationsSettingsEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new NotificationsSettings(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new NotificationsSettings_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new NotificationsSettingsSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new NotificationsSettingsSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0c7a653b-33bc-471e-abca-aa4e330cc323"));
		}

		#endregion

	}

	#endregion

	#region Class: NotificationsSettings

	/// <summary>
	/// Settings of notifications.
	/// </summary>
	public class NotificationsSettings : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public NotificationsSettings(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "NotificationsSettings";
		}

		public NotificationsSettings(NotificationsSettings source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid SysImageId {
			get {
				return GetTypedColumnValue<Guid>("SysImageId");
			}
			set {
				SetColumnValue("SysImageId", value);
				_sysImage = null;
			}
		}

		/// <exclude/>
		public string SysImageName {
			get {
				return GetTypedColumnValue<string>("SysImageName");
			}
			set {
				SetColumnValue("SysImageName", value);
				if (_sysImage != null) {
					_sysImage.Name = value;
				}
			}
		}

		private SysImage _sysImage;
		/// <summary>
		/// Image of notifications.
		/// </summary>
		public SysImage SysImage {
			get {
				return _sysImage ??
					(_sysImage = LookupColumnEntities.GetEntity("SysImage") as SysImage);
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
		/// Notification type.
		/// </summary>
		public NotificationType NotificationType {
			get {
				return _notificationType ??
					(_notificationType = LookupColumnEntities.GetEntity("NotificationType") as NotificationType);
			}
		}

		/// <summary>
		/// Entity of notifications.
		/// </summary>
		public Guid SysEntitySchemaUId {
			get {
				return GetTypedColumnValue<Guid>("SysEntitySchemaUId");
			}
			set {
				SetColumnValue("SysEntitySchemaUId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new NotificationsSettings_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("NotificationsSettingsDeleted", e);
			Validating += (s, e) => ThrowEvent("NotificationsSettingsValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new NotificationsSettings(this);
		}

		#endregion

	}

	#endregion

	#region Class: NotificationsSettings_BaseEventsProcess

	/// <exclude/>
	public partial class NotificationsSettings_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : NotificationsSettings
	{

		public NotificationsSettings_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "NotificationsSettings_BaseEventsProcess";
			SchemaUId = new Guid("0c7a653b-33bc-471e-abca-aa4e330cc323");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("0c7a653b-33bc-471e-abca-aa4e330cc323");
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

	#region Class: NotificationsSettings_BaseEventsProcess

	/// <exclude/>
	public class NotificationsSettings_BaseEventsProcess : NotificationsSettings_BaseEventsProcess<NotificationsSettings>
	{

		public NotificationsSettings_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: NotificationsSettings_BaseEventsProcess

	public partial class NotificationsSettings_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: NotificationsSettingsEventsProcessSchema

	/// <exclude/>
	public class NotificationsSettingsEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public NotificationsSettingsEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public NotificationsSettingsEventsProcessSchema(NotificationsSettingsEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "NotificationsSettings_BaseEventsProcess";
			UId = new Guid("52b38d59-68d1-4161-b243-a6b232596a8a");
			CreatedInPackageId = new Guid("271744d8-d0f2-48d8-a4d0-e376f30523b7");
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
			return new NotificationsSettingsEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("52b38d59-68d1-4161-b243-a6b232596a8a"));
		}

		#endregion

	}

	#endregion


	#region Class: NotificationsSettingsEventsProcess

	/// <exclude/>
	public class NotificationsSettingsEventsProcess : NotificationsSettings_BaseEventsProcess
	{

		public NotificationsSettingsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

