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

	#region Class: ProjectPlanHistoryItemSchema

	/// <exclude/>
	public class ProjectPlanHistoryItemSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ProjectPlanHistoryItemSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ProjectPlanHistoryItemSchema(ProjectPlanHistoryItemSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ProjectPlanHistoryItemSchema(ProjectPlanHistoryItemSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("59fbdedf-d508-41f0-b37d-8fd6c54c961f");
			RealUId = new Guid("59fbdedf-d508-41f0-b37d-8fd6c54c961f");
			Name = "ProjectPlanHistoryItem";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("a960d699-2ffa-41d4-b774-2361d46af048")) == null) {
				Columns.Add(CreateProjectColumn());
			}
			if (Columns.FindByUId(new Guid("f2ebc2a1-606d-4b84-b70f-1696f855220d")) == null) {
				Columns.Add(CreateRoleColumn());
			}
			if (Columns.FindByUId(new Guid("55be9d19-33a7-4cb5-81ed-3f91ea530970")) == null) {
				Columns.Add(CreatePlanningWorkColumn());
			}
			if (Columns.FindByUId(new Guid("c65b17a2-d3a5-4ef4-a67f-8e66e3d67be3")) == null) {
				Columns.Add(CreateStartDateColumn());
			}
			if (Columns.FindByUId(new Guid("c3a435f0-4aaa-4cb6-8c12-a456894997f7")) == null) {
				Columns.Add(CreateEndDateColumn());
			}
			if (Columns.FindByUId(new Guid("26602526-02a0-4372-83d9-618753640820")) == null) {
				Columns.Add(CreatePlanningCompletionColumn());
			}
			if (Columns.FindByUId(new Guid("2f6526c4-85b4-4f26-b52e-f44f8a822fb6")) == null) {
				Columns.Add(CreateActualCompletionColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("59fbdedf-d508-41f0-b37d-8fd6c54c961f");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("59fbdedf-d508-41f0-b37d-8fd6c54c961f");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("59fbdedf-d508-41f0-b37d-8fd6c54c961f");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("59fbdedf-d508-41f0-b37d-8fd6c54c961f");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("59fbdedf-d508-41f0-b37d-8fd6c54c961f");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("59fbdedf-d508-41f0-b37d-8fd6c54c961f");
			column.CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			return column;
		}

		protected virtual EntitySchemaColumn CreateProjectColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a960d699-2ffa-41d4-b774-2361d46af048"),
				Name = @"Project",
				ReferenceSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("59fbdedf-d508-41f0-b37d-8fd6c54c961f"),
				ModifiedInSchemaUId = new Guid("59fbdedf-d508-41f0-b37d-8fd6c54c961f"),
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f")
			};
		}

		protected virtual EntitySchemaColumn CreateRoleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f2ebc2a1-606d-4b84-b70f-1696f855220d"),
				Name = @"Role",
				ReferenceSchemaUId = new Guid("fea6a5b4-c59a-4824-9844-49b5694b53df"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("59fbdedf-d508-41f0-b37d-8fd6c54c961f"),
				ModifiedInSchemaUId = new Guid("59fbdedf-d508-41f0-b37d-8fd6c54c961f"),
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f")
			};
		}

		protected virtual EntitySchemaColumn CreatePlanningWorkColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("55be9d19-33a7-4cb5-81ed-3f91ea530970"),
				Name = @"PlanningWork",
				CreatedInSchemaUId = new Guid("59fbdedf-d508-41f0-b37d-8fd6c54c961f"),
				ModifiedInSchemaUId = new Guid("59fbdedf-d508-41f0-b37d-8fd6c54c961f"),
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f")
			};
		}

		protected virtual EntitySchemaColumn CreateStartDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("c65b17a2-d3a5-4ef4-a67f-8e66e3d67be3"),
				Name = @"StartDate",
				CreatedInSchemaUId = new Guid("59fbdedf-d508-41f0-b37d-8fd6c54c961f"),
				ModifiedInSchemaUId = new Guid("59fbdedf-d508-41f0-b37d-8fd6c54c961f"),
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f")
			};
		}

		protected virtual EntitySchemaColumn CreateEndDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("c3a435f0-4aaa-4cb6-8c12-a456894997f7"),
				Name = @"EndDate",
				CreatedInSchemaUId = new Guid("59fbdedf-d508-41f0-b37d-8fd6c54c961f"),
				ModifiedInSchemaUId = new Guid("59fbdedf-d508-41f0-b37d-8fd6c54c961f"),
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f")
			};
		}

		protected virtual EntitySchemaColumn CreatePlanningCompletionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("26602526-02a0-4372-83d9-618753640820"),
				Name = @"PlanningCompletion",
				CreatedInSchemaUId = new Guid("59fbdedf-d508-41f0-b37d-8fd6c54c961f"),
				ModifiedInSchemaUId = new Guid("59fbdedf-d508-41f0-b37d-8fd6c54c961f"),
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f")
			};
		}

		protected virtual EntitySchemaColumn CreateActualCompletionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("2f6526c4-85b4-4f26-b52e-f44f8a822fb6"),
				Name = @"ActualCompletion",
				CreatedInSchemaUId = new Guid("59fbdedf-d508-41f0-b37d-8fd6c54c961f"),
				ModifiedInSchemaUId = new Guid("59fbdedf-d508-41f0-b37d-8fd6c54c961f"),
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateProjectPlanHistoryItemEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateProjectPlanHistoryItemEventsProcessSchema() {
			var schema = new ProjectPlanHistoryItemEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ProjectPlanHistoryItem(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ProjectPlanHistoryItem_ProjectEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ProjectPlanHistoryItemSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ProjectPlanHistoryItemSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("59fbdedf-d508-41f0-b37d-8fd6c54c961f"));
		}

		#endregion

	}

	#endregion

	#region Class: ProjectPlanHistoryItem

	/// <summary>
	/// Record - Estimated working time of project.
	/// </summary>
	public class ProjectPlanHistoryItem : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ProjectPlanHistoryItem(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ProjectPlanHistoryItem";
		}

		public ProjectPlanHistoryItem(ProjectPlanHistoryItem source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ProjectId {
			get {
				return GetTypedColumnValue<Guid>("ProjectId");
			}
			set {
				SetColumnValue("ProjectId", value);
				_project = null;
			}
		}

		/// <exclude/>
		public string ProjectName {
			get {
				return GetTypedColumnValue<string>("ProjectName");
			}
			set {
				SetColumnValue("ProjectName", value);
				if (_project != null) {
					_project.Name = value;
				}
			}
		}

		private Project _project;
		/// <summary>
		/// Project.
		/// </summary>
		public Project Project {
			get {
				return _project ??
					(_project = LookupColumnEntities.GetEntity("Project") as Project);
			}
		}

		/// <exclude/>
		public Guid RoleId {
			get {
				return GetTypedColumnValue<Guid>("RoleId");
			}
			set {
				SetColumnValue("RoleId", value);
				_role = null;
			}
		}

		/// <exclude/>
		public string RoleName {
			get {
				return GetTypedColumnValue<string>("RoleName");
			}
			set {
				SetColumnValue("RoleName", value);
				if (_role != null) {
					_role.Name = value;
				}
			}
		}

		private ProjectRole _role;
		/// <summary>
		/// Role.
		/// </summary>
		public ProjectRole Role {
			get {
				return _role ??
					(_role = LookupColumnEntities.GetEntity("Role") as ProjectRole);
			}
		}

		/// <summary>
		/// Estimated working time, h.
		/// </summary>
		public Decimal PlanningWork {
			get {
				return GetTypedColumnValue<Decimal>("PlanningWork");
			}
			set {
				SetColumnValue("PlanningWork", value);
			}
		}

		/// <summary>
		/// Start.
		/// </summary>
		public DateTime StartDate {
			get {
				return GetTypedColumnValue<DateTime>("StartDate");
			}
			set {
				SetColumnValue("StartDate", value);
			}
		}

		/// <summary>
		/// End.
		/// </summary>
		public DateTime EndDate {
			get {
				return GetTypedColumnValue<DateTime>("EndDate");
			}
			set {
				SetColumnValue("EndDate", value);
			}
		}

		/// <summary>
		/// Expected completion, %.
		/// </summary>
		public Decimal PlanningCompletion {
			get {
				return GetTypedColumnValue<Decimal>("PlanningCompletion");
			}
			set {
				SetColumnValue("PlanningCompletion", value);
			}
		}

		/// <summary>
		/// Actual completion, %.
		/// </summary>
		public Decimal ActualCompletion {
			get {
				return GetTypedColumnValue<Decimal>("ActualCompletion");
			}
			set {
				SetColumnValue("ActualCompletion", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ProjectPlanHistoryItem_ProjectEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ProjectPlanHistoryItemDeleted", e);
			Inserting += (s, e) => ThrowEvent("ProjectPlanHistoryItemInserting", e);
			Validating += (s, e) => ThrowEvent("ProjectPlanHistoryItemValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ProjectPlanHistoryItem(this);
		}

		#endregion

	}

	#endregion

	#region Class: ProjectPlanHistoryItem_ProjectEventsProcess

	/// <exclude/>
	public partial class ProjectPlanHistoryItem_ProjectEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : ProjectPlanHistoryItem
	{

		public ProjectPlanHistoryItem_ProjectEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProjectPlanHistoryItem_ProjectEventsProcess";
			SchemaUId = new Guid("59fbdedf-d508-41f0-b37d-8fd6c54c961f");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("59fbdedf-d508-41f0-b37d-8fd6c54c961f");
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

	#region Class: ProjectPlanHistoryItem_ProjectEventsProcess

	/// <exclude/>
	public class ProjectPlanHistoryItem_ProjectEventsProcess : ProjectPlanHistoryItem_ProjectEventsProcess<ProjectPlanHistoryItem>
	{

		public ProjectPlanHistoryItem_ProjectEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ProjectPlanHistoryItem_ProjectEventsProcess

	public partial class ProjectPlanHistoryItem_ProjectEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: ProjectPlanHistoryItemEventsProcessSchema

	/// <exclude/>
	public class ProjectPlanHistoryItemEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public ProjectPlanHistoryItemEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ProjectPlanHistoryItemEventsProcessSchema(ProjectPlanHistoryItemEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ProjectPlanHistoryItem_ProjectEventsProcess";
			UId = new Guid("409bf541-3054-4b76-b9c9-db54f5f33531");
			CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
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
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f")
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
			return new ProjectPlanHistoryItemEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("409bf541-3054-4b76-b9c9-db54f5f33531"));
		}

		#endregion

	}

	#endregion


	#region Class: ProjectPlanHistoryItemEventsProcess

	/// <exclude/>
	public class ProjectPlanHistoryItemEventsProcess : ProjectPlanHistoryItem_ProjectEventsProcess
	{

		public ProjectPlanHistoryItemEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

