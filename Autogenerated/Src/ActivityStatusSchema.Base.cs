namespace Terrasoft.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: ActivityStatusSchema

	/// <exclude/>
	public class ActivityStatusSchema : Terrasoft.Configuration.BaseCodeLookupSchema
	{

		#region Constructors: Public

		public ActivityStatusSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ActivityStatusSchema(ActivityStatusSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ActivityStatusSchema(ActivityStatusSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("805aace4-8604-40e7-a9eb-0f54174593c0");
			RealUId = new Guid("805aace4-8604-40e7-a9eb-0f54174593c0");
			Name = "ActivityStatus";
			ParentSchemaUId = new Guid("2681062b-df59-4e52-89ed-f9b7dc909ab2");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("b618e983-400b-4eee-8645-f6a53fd325ec")) == null) {
				Columns.Add(CreateFinishColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.SystemValue,
				ValueSource = SystemValueManager.GetInstanceByName(@"SequentialGuid")
			};
			column.ModifiedInSchemaUId = new Guid("805aace4-8604-40e7-a9eb-0f54174593c0");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("805aace4-8604-40e7-a9eb-0f54174593c0");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("805aace4-8604-40e7-a9eb-0f54174593c0");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected override EntitySchemaColumn CreateCodeColumn() {
			EntitySchemaColumn column = base.CreateCodeColumn();
			column.ModifiedInSchemaUId = new Guid("805aace4-8604-40e7-a9eb-0f54174593c0");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected virtual EntitySchemaColumn CreateFinishColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("b618e983-400b-4eee-8645-f6a53fd325ec"),
				Name = @"Finish",
				CreatedInSchemaUId = new Guid("805aace4-8604-40e7-a9eb-0f54174593c0"),
				ModifiedInSchemaUId = new Guid("805aace4-8604-40e7-a9eb-0f54174593c0"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateActivityStatusEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateActivityStatusEventsProcessSchema() {
			var schema = new ActivityStatusEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ActivityStatus(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ActivityStatus_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ActivityStatusSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ActivityStatusSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("805aace4-8604-40e7-a9eb-0f54174593c0"));
		}

		#endregion

	}

	#endregion

	#region Class: ActivityStatus

	/// <summary>
	/// Activity status.
	/// </summary>
	public class ActivityStatus : Terrasoft.Configuration.BaseCodeLookup
	{

		#region Constructors: Public

		public ActivityStatus(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ActivityStatus";
		}

		public ActivityStatus(ActivityStatus source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Status is final.
		/// </summary>
		public bool Finish {
			get {
				return GetTypedColumnValue<bool>("Finish");
			}
			set {
				SetColumnValue("Finish", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ActivityStatus_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ActivityStatusDeleted", e);
			Deleting += (s, e) => ThrowEvent("ActivityStatusDeleting", e);
			Inserted += (s, e) => ThrowEvent("ActivityStatusInserted", e);
			Inserting += (s, e) => ThrowEvent("ActivityStatusInserting", e);
			Saved += (s, e) => ThrowEvent("ActivityStatusSaved", e);
			Saving += (s, e) => ThrowEvent("ActivityStatusSaving", e);
			Validating += (s, e) => ThrowEvent("ActivityStatusValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ActivityStatus(this);
		}

		#endregion

	}

	#endregion

	#region Class: ActivityStatus_BaseEventsProcess

	/// <exclude/>
	public partial class ActivityStatus_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseCodeLookup_BaseEventsProcess<TEntity> where TEntity : ActivityStatus
	{

		public ActivityStatus_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ActivityStatus_BaseEventsProcess";
			SchemaUId = new Guid("805aace4-8604-40e7-a9eb-0f54174593c0");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("805aace4-8604-40e7-a9eb-0f54174593c0");
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

	#region Class: ActivityStatus_BaseEventsProcess

	/// <exclude/>
	public class ActivityStatus_BaseEventsProcess : ActivityStatus_BaseEventsProcess<ActivityStatus>
	{

		public ActivityStatus_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ActivityStatus_BaseEventsProcess

	public partial class ActivityStatus_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: ActivityStatusEventsProcessSchema

	/// <exclude/>
	public class ActivityStatusEventsProcessSchema : Terrasoft.Configuration.BaseCodeLookupEventsProcessSchema
	{

		#region Constructors: Public

		public ActivityStatusEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ActivityStatusEventsProcessSchema(ActivityStatusEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ActivityStatus_BaseEventsProcess";
			UId = new Guid("ac8d0498-3a35-4ee5-ba97-2bf896fcc5e2");
			CreatedInPackageId = new Guid("f25ac8e1-73cc-488f-8dc8-76a50a94117e");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1");
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

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ActivityStatusEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ac8d0498-3a35-4ee5-ba97-2bf896fcc5e2"));
		}

		#endregion

	}

	#endregion


	#region Class: ActivityStatusEventsProcess

	/// <exclude/>
	public class ActivityStatusEventsProcess : ActivityStatus_BaseEventsProcess
	{

		public ActivityStatusEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

