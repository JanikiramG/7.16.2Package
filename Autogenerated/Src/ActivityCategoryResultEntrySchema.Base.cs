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

	#region Class: ActivityCategoryResultEntrySchema

	/// <exclude/>
	public class ActivityCategoryResultEntrySchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ActivityCategoryResultEntrySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ActivityCategoryResultEntrySchema(ActivityCategoryResultEntrySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ActivityCategoryResultEntrySchema(ActivityCategoryResultEntrySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bd4e2904-dfb9-460a-8fd8-1d5e20405782");
			RealUId = new Guid("bd4e2904-dfb9-460a-8fd8-1d5e20405782");
			Name = "ActivityCategoryResultEntry";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("a9b31a96-5933-4a24-9de8-e6312dbce20b")) == null) {
				Columns.Add(CreateActivityResultColumn());
			}
			if (Columns.FindByUId(new Guid("136bcedb-1f6d-4214-8815-551c71f345a8")) == null) {
				Columns.Add(CreateActivityCategoryColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateActivityResultColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a9b31a96-5933-4a24-9de8-e6312dbce20b"),
				Name = @"ActivityResult",
				ReferenceSchemaUId = new Guid("329bd06e-f95f-4824-a0fb-85edff2f2948"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("bd4e2904-dfb9-460a-8fd8-1d5e20405782"),
				ModifiedInSchemaUId = new Guid("bd4e2904-dfb9-460a-8fd8-1d5e20405782"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateActivityCategoryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("136bcedb-1f6d-4214-8815-551c71f345a8"),
				Name = @"ActivityCategory",
				ReferenceSchemaUId = new Guid("961e2086-a12b-4d27-b095-40b1e64d6cc0"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("bd4e2904-dfb9-460a-8fd8-1d5e20405782"),
				ModifiedInSchemaUId = new Guid("bd4e2904-dfb9-460a-8fd8-1d5e20405782"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateActivityCategoryResultEntryEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateActivityCategoryResultEntryEventsProcessSchema() {
			var schema = new ActivityCategoryResultEntryEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ActivityCategoryResultEntry(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ActivityCategoryResultEntry_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ActivityCategoryResultEntrySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ActivityCategoryResultEntrySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bd4e2904-dfb9-460a-8fd8-1d5e20405782"));
		}

		#endregion

	}

	#endregion

	#region Class: ActivityCategoryResultEntry

	/// <summary>
	/// Result by activity category.
	/// </summary>
	public class ActivityCategoryResultEntry : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ActivityCategoryResultEntry(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ActivityCategoryResultEntry";
		}

		public ActivityCategoryResultEntry(ActivityCategoryResultEntry source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ActivityResultId {
			get {
				return GetTypedColumnValue<Guid>("ActivityResultId");
			}
			set {
				SetColumnValue("ActivityResultId", value);
				_activityResult = null;
			}
		}

		/// <exclude/>
		public string ActivityResultName {
			get {
				return GetTypedColumnValue<string>("ActivityResultName");
			}
			set {
				SetColumnValue("ActivityResultName", value);
				if (_activityResult != null) {
					_activityResult.Name = value;
				}
			}
		}

		private ActivityResult _activityResult;
		/// <summary>
		/// Result of activity.
		/// </summary>
		public ActivityResult ActivityResult {
			get {
				return _activityResult ??
					(_activityResult = LookupColumnEntities.GetEntity("ActivityResult") as ActivityResult);
			}
		}

		/// <exclude/>
		public Guid ActivityCategoryId {
			get {
				return GetTypedColumnValue<Guid>("ActivityCategoryId");
			}
			set {
				SetColumnValue("ActivityCategoryId", value);
				_activityCategory = null;
			}
		}

		/// <exclude/>
		public string ActivityCategoryName {
			get {
				return GetTypedColumnValue<string>("ActivityCategoryName");
			}
			set {
				SetColumnValue("ActivityCategoryName", value);
				if (_activityCategory != null) {
					_activityCategory.Name = value;
				}
			}
		}

		private ActivityCategory _activityCategory;
		/// <summary>
		/// Activity category.
		/// </summary>
		public ActivityCategory ActivityCategory {
			get {
				return _activityCategory ??
					(_activityCategory = LookupColumnEntities.GetEntity("ActivityCategory") as ActivityCategory);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ActivityCategoryResultEntry_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ActivityCategoryResultEntryDeleted", e);
			Deleting += (s, e) => ThrowEvent("ActivityCategoryResultEntryDeleting", e);
			Inserted += (s, e) => ThrowEvent("ActivityCategoryResultEntryInserted", e);
			Inserting += (s, e) => ThrowEvent("ActivityCategoryResultEntryInserting", e);
			Saved += (s, e) => ThrowEvent("ActivityCategoryResultEntrySaved", e);
			Saving += (s, e) => ThrowEvent("ActivityCategoryResultEntrySaving", e);
			Validating += (s, e) => ThrowEvent("ActivityCategoryResultEntryValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ActivityCategoryResultEntry(this);
		}

		#endregion

	}

	#endregion

	#region Class: ActivityCategoryResultEntry_BaseEventsProcess

	/// <exclude/>
	public partial class ActivityCategoryResultEntry_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : ActivityCategoryResultEntry
	{

		public ActivityCategoryResultEntry_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ActivityCategoryResultEntry_BaseEventsProcess";
			SchemaUId = new Guid("bd4e2904-dfb9-460a-8fd8-1d5e20405782");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("bd4e2904-dfb9-460a-8fd8-1d5e20405782");
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

	#region Class: ActivityCategoryResultEntry_BaseEventsProcess

	/// <exclude/>
	public class ActivityCategoryResultEntry_BaseEventsProcess : ActivityCategoryResultEntry_BaseEventsProcess<ActivityCategoryResultEntry>
	{

		public ActivityCategoryResultEntry_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ActivityCategoryResultEntry_BaseEventsProcess

	public partial class ActivityCategoryResultEntry_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: ActivityCategoryResultEntryEventsProcessSchema

	/// <exclude/>
	public class ActivityCategoryResultEntryEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public ActivityCategoryResultEntryEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ActivityCategoryResultEntryEventsProcessSchema(ActivityCategoryResultEntryEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ActivityCategoryResultEntry_BaseEventsProcess";
			UId = new Guid("6d7a1007-2c56-49ff-8f9e-4858c0e43657");
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
			return new ActivityCategoryResultEntryEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6d7a1007-2c56-49ff-8f9e-4858c0e43657"));
		}

		#endregion

	}

	#endregion


	#region Class: ActivityCategoryResultEntryEventsProcess

	/// <exclude/>
	public class ActivityCategoryResultEntryEventsProcess : ActivityCategoryResultEntry_BaseEventsProcess
	{

		public ActivityCategoryResultEntryEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

