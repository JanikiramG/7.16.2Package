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

	#region Class: ActivityTypeStatusEntrySchema

	/// <exclude/>
	public class ActivityTypeStatusEntrySchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ActivityTypeStatusEntrySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ActivityTypeStatusEntrySchema(ActivityTypeStatusEntrySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ActivityTypeStatusEntrySchema(ActivityTypeStatusEntrySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d617331d-0076-472f-9db7-8cb3271de803");
			RealUId = new Guid("d617331d-0076-472f-9db7-8cb3271de803");
			Name = "ActivityTypeStatusEntry";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("8e73d2b9-3991-4244-abb2-da5056c33197")) == null) {
				Columns.Add(CreateActivityTypeColumn());
			}
			if (Columns.FindByUId(new Guid("334f18d3-ac4d-4ca3-8c35-93b96b07916d")) == null) {
				Columns.Add(CreateActivityStatusColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateActivityTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8e73d2b9-3991-4244-abb2-da5056c33197"),
				Name = @"ActivityType",
				ReferenceSchemaUId = new Guid("75b4d39b-55dc-4bd6-8d10-3f49a58d96c7"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d617331d-0076-472f-9db7-8cb3271de803"),
				ModifiedInSchemaUId = new Guid("d617331d-0076-472f-9db7-8cb3271de803"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateActivityStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("334f18d3-ac4d-4ca3-8c35-93b96b07916d"),
				Name = @"ActivityStatus",
				ReferenceSchemaUId = new Guid("805aace4-8604-40e7-a9eb-0f54174593c0"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d617331d-0076-472f-9db7-8cb3271de803"),
				ModifiedInSchemaUId = new Guid("d617331d-0076-472f-9db7-8cb3271de803"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateActivityTypeStatusEntryEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateActivityTypeStatusEntryEventsProcessSchema() {
			var schema = new ActivityTypeStatusEntryEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ActivityTypeStatusEntry(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ActivityTypeStatusEntry_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ActivityTypeStatusEntrySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ActivityTypeStatusEntrySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d617331d-0076-472f-9db7-8cb3271de803"));
		}

		#endregion

	}

	#endregion

	#region Class: ActivityTypeStatusEntry

	/// <summary>
	/// Activity status by type.
	/// </summary>
	public class ActivityTypeStatusEntry : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ActivityTypeStatusEntry(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ActivityTypeStatusEntry";
		}

		public ActivityTypeStatusEntry(ActivityTypeStatusEntry source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ActivityTypeId {
			get {
				return GetTypedColumnValue<Guid>("ActivityTypeId");
			}
			set {
				SetColumnValue("ActivityTypeId", value);
				_activityType = null;
			}
		}

		/// <exclude/>
		public string ActivityTypeName {
			get {
				return GetTypedColumnValue<string>("ActivityTypeName");
			}
			set {
				SetColumnValue("ActivityTypeName", value);
				if (_activityType != null) {
					_activityType.Name = value;
				}
			}
		}

		private ActivityType _activityType;
		/// <summary>
		/// Activity type.
		/// </summary>
		public ActivityType ActivityType {
			get {
				return _activityType ??
					(_activityType = LookupColumnEntities.GetEntity("ActivityType") as ActivityType);
			}
		}

		/// <exclude/>
		public Guid ActivityStatusId {
			get {
				return GetTypedColumnValue<Guid>("ActivityStatusId");
			}
			set {
				SetColumnValue("ActivityStatusId", value);
				_activityStatus = null;
			}
		}

		/// <exclude/>
		public string ActivityStatusName {
			get {
				return GetTypedColumnValue<string>("ActivityStatusName");
			}
			set {
				SetColumnValue("ActivityStatusName", value);
				if (_activityStatus != null) {
					_activityStatus.Name = value;
				}
			}
		}

		private ActivityStatus _activityStatus;
		/// <summary>
		/// Activity status.
		/// </summary>
		public ActivityStatus ActivityStatus {
			get {
				return _activityStatus ??
					(_activityStatus = LookupColumnEntities.GetEntity("ActivityStatus") as ActivityStatus);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ActivityTypeStatusEntry_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ActivityTypeStatusEntryDeleted", e);
			Deleting += (s, e) => ThrowEvent("ActivityTypeStatusEntryDeleting", e);
			Inserted += (s, e) => ThrowEvent("ActivityTypeStatusEntryInserted", e);
			Inserting += (s, e) => ThrowEvent("ActivityTypeStatusEntryInserting", e);
			Saved += (s, e) => ThrowEvent("ActivityTypeStatusEntrySaved", e);
			Saving += (s, e) => ThrowEvent("ActivityTypeStatusEntrySaving", e);
			Validating += (s, e) => ThrowEvent("ActivityTypeStatusEntryValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ActivityTypeStatusEntry(this);
		}

		#endregion

	}

	#endregion

	#region Class: ActivityTypeStatusEntry_BaseEventsProcess

	/// <exclude/>
	public partial class ActivityTypeStatusEntry_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : ActivityTypeStatusEntry
	{

		public ActivityTypeStatusEntry_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ActivityTypeStatusEntry_BaseEventsProcess";
			SchemaUId = new Guid("d617331d-0076-472f-9db7-8cb3271de803");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d617331d-0076-472f-9db7-8cb3271de803");
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

	#region Class: ActivityTypeStatusEntry_BaseEventsProcess

	/// <exclude/>
	public class ActivityTypeStatusEntry_BaseEventsProcess : ActivityTypeStatusEntry_BaseEventsProcess<ActivityTypeStatusEntry>
	{

		public ActivityTypeStatusEntry_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ActivityTypeStatusEntry_BaseEventsProcess

	public partial class ActivityTypeStatusEntry_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: ActivityTypeStatusEntryEventsProcessSchema

	/// <exclude/>
	public class ActivityTypeStatusEntryEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public ActivityTypeStatusEntryEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ActivityTypeStatusEntryEventsProcessSchema(ActivityTypeStatusEntryEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ActivityTypeStatusEntry_BaseEventsProcess";
			UId = new Guid("7ffed053-a746-4ac0-b86b-f2533d256796");
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
			return new ActivityTypeStatusEntryEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7ffed053-a746-4ac0-b86b-f2533d256796"));
		}

		#endregion

	}

	#endregion


	#region Class: ActivityTypeStatusEntryEventsProcess

	/// <exclude/>
	public class ActivityTypeStatusEntryEventsProcess : ActivityTypeStatusEntry_BaseEventsProcess
	{

		public ActivityTypeStatusEntryEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

