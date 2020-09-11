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

	#region Class: ProjectResourceElementSchema

	/// <exclude/>
	public class ProjectResourceElementSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ProjectResourceElementSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ProjectResourceElementSchema(ProjectResourceElementSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ProjectResourceElementSchema(ProjectResourceElementSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("83e22973-7506-4bc0-88e3-9502851b6c44");
			RealUId = new Guid("83e22973-7506-4bc0-88e3-9502851b6c44");
			Name = "ProjectResourceElement";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c");
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
			if (Columns.FindByUId(new Guid("cad634f0-58b6-4367-8e5f-a88471349fe6")) == null) {
				Columns.Add(CreateProjectColumn());
			}
			if (Columns.FindByUId(new Guid("4ef6d535-6900-4bed-b25e-bc9f21ec8f51")) == null) {
				Columns.Add(CreateExternalRateColumn());
			}
			if (Columns.FindByUId(new Guid("5a690e50-642f-4e2d-a470-440cf68bc757")) == null) {
				Columns.Add(CreateInternalRateColumn());
			}
			if (Columns.FindByUId(new Guid("5f332a4c-0975-4882-93ea-5941eafe2c7d")) == null) {
				Columns.Add(CreatePlanningWorkColumn());
			}
			if (Columns.FindByUId(new Guid("83e9a961-08bf-4d01-a795-997c4fb54686")) == null) {
				Columns.Add(CreateActualWorkColumn());
			}
			if (Columns.FindByUId(new Guid("d5714d9b-0bd1-468b-92eb-577322bad83a")) == null) {
				Columns.Add(CreateContactColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("83e22973-7506-4bc0-88e3-9502851b6c44");
			column.CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("83e22973-7506-4bc0-88e3-9502851b6c44");
			column.CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("83e22973-7506-4bc0-88e3-9502851b6c44");
			column.CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("83e22973-7506-4bc0-88e3-9502851b6c44");
			column.CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("83e22973-7506-4bc0-88e3-9502851b6c44");
			column.CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("83e22973-7506-4bc0-88e3-9502851b6c44");
			column.CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c");
			return column;
		}

		protected virtual EntitySchemaColumn CreateProjectColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("cad634f0-58b6-4367-8e5f-a88471349fe6"),
				Name = @"Project",
				ReferenceSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("83e22973-7506-4bc0-88e3-9502851b6c44"),
				ModifiedInSchemaUId = new Guid("83e22973-7506-4bc0-88e3-9502851b6c44"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c")
			};
		}

		protected virtual EntitySchemaColumn CreateExternalRateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("4ef6d535-6900-4bed-b25e-bc9f21ec8f51"),
				Name = @"ExternalRate",
				CreatedInSchemaUId = new Guid("83e22973-7506-4bc0-88e3-9502851b6c44"),
				ModifiedInSchemaUId = new Guid("83e22973-7506-4bc0-88e3-9502851b6c44"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c")
			};
		}

		protected virtual EntitySchemaColumn CreateInternalRateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("5a690e50-642f-4e2d-a470-440cf68bc757"),
				Name = @"InternalRate",
				CreatedInSchemaUId = new Guid("83e22973-7506-4bc0-88e3-9502851b6c44"),
				ModifiedInSchemaUId = new Guid("83e22973-7506-4bc0-88e3-9502851b6c44"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c")
			};
		}

		protected virtual EntitySchemaColumn CreatePlanningWorkColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("5f332a4c-0975-4882-93ea-5941eafe2c7d"),
				Name = @"PlanningWork",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("83e22973-7506-4bc0-88e3-9502851b6c44"),
				ModifiedInSchemaUId = new Guid("83e22973-7506-4bc0-88e3-9502851b6c44"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c")
			};
		}

		protected virtual EntitySchemaColumn CreateActualWorkColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("83e9a961-08bf-4d01-a795-997c4fb54686"),
				Name = @"ActualWork",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("83e22973-7506-4bc0-88e3-9502851b6c44"),
				ModifiedInSchemaUId = new Guid("83e22973-7506-4bc0-88e3-9502851b6c44"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c")
			};
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("32e3c36d-ba76-48bb-ae00-813c61567e97"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("83e22973-7506-4bc0-88e3-9502851b6c44"),
				ModifiedInSchemaUId = new Guid("83e22973-7506-4bc0-88e3-9502851b6c44"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c")
			};
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d5714d9b-0bd1-468b-92eb-577322bad83a"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("83e22973-7506-4bc0-88e3-9502851b6c44"),
				ModifiedInSchemaUId = new Guid("83e22973-7506-4bc0-88e3-9502851b6c44"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateProjectResourceElementEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateProjectResourceElementEventsProcessSchema() {
			var schema = new ProjectResourceElementEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ProjectResourceElement(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ProjectResourceElement_ProjectEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ProjectResourceElementSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ProjectResourceElementSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("83e22973-7506-4bc0-88e3-9502851b6c44"));
		}

		#endregion

	}

	#endregion

	#region Class: ProjectResourceElement

	/// <summary>
	/// Item of project resources.
	/// </summary>
	public class ProjectResourceElement : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ProjectResourceElement(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ProjectResourceElement";
		}

		public ProjectResourceElement(ProjectResourceElement source)
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

		/// <summary>
		/// External fee.
		/// </summary>
		public Decimal ExternalRate {
			get {
				return GetTypedColumnValue<Decimal>("ExternalRate");
			}
			set {
				SetColumnValue("ExternalRate", value);
			}
		}

		/// <summary>
		/// Wage.
		/// </summary>
		public Decimal InternalRate {
			get {
				return GetTypedColumnValue<Decimal>("InternalRate");
			}
			set {
				SetColumnValue("InternalRate", value);
			}
		}

		/// <summary>
		/// Expected working time, h.
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
		/// Actual working time, h.
		/// </summary>
		public Decimal ActualWork {
			get {
				return GetTypedColumnValue<Decimal>("ActualWork");
			}
			set {
				SetColumnValue("ActualWork", value);
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

		/// <exclude/>
		public Guid ContactId {
			get {
				return GetTypedColumnValue<Guid>("ContactId");
			}
			set {
				SetColumnValue("ContactId", value);
				_contact = null;
			}
		}

		/// <exclude/>
		public string ContactName {
			get {
				return GetTypedColumnValue<string>("ContactName");
			}
			set {
				SetColumnValue("ContactName", value);
				if (_contact != null) {
					_contact.Name = value;
				}
			}
		}

		private Contact _contact;
		/// <summary>
		/// Contact.
		/// </summary>
		public Contact Contact {
			get {
				return _contact ??
					(_contact = LookupColumnEntities.GetEntity("Contact") as Contact);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ProjectResourceElement_ProjectEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ProjectResourceElementDeleted", e);
			Deleting += (s, e) => ThrowEvent("ProjectResourceElementDeleting", e);
			Inserting += (s, e) => ThrowEvent("ProjectResourceElementInserting", e);
			Saved += (s, e) => ThrowEvent("ProjectResourceElementSaved", e);
			Validating += (s, e) => ThrowEvent("ProjectResourceElementValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ProjectResourceElement(this);
		}

		#endregion

	}

	#endregion

	#region Class: ProjectResourceElement_ProjectEventsProcess

	/// <exclude/>
	public partial class ProjectResourceElement_ProjectEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : ProjectResourceElement
	{

		public ProjectResourceElement_ProjectEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProjectResourceElement_ProjectEventsProcess";
			SchemaUId = new Guid("83e22973-7506-4bc0-88e3-9502851b6c44");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("83e22973-7506-4bc0-88e3-9502851b6c44");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual Guid ProjectId {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess1;
		public ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("e494b425-16df-4a2b-a83b-f0f4c8f3b4b2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _projectManhourDeleting;
		public ProcessFlowElement ProjectManhourDeleting {
			get {
				return _projectManhourDeleting ?? (_projectManhourDeleting = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ProjectManhourDeleting",
					SchemaElementUId = new Guid("f652f2c0-ffed-4072-8479-ed052fa1a36c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _projectManhourDeletingScriptTask;
		public ProcessScriptTask ProjectManhourDeletingScriptTask {
			get {
				return _projectManhourDeletingScriptTask ?? (_projectManhourDeletingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ProjectManhourDeletingScriptTask",
					SchemaElementUId = new Guid("77fbed06-9a68-4d36-9d9c-91d011c06cb1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ProjectManhourDeletingScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess2;
		public ProcessFlowElement EventSubProcess2 {
			get {
				return _eventSubProcess2 ?? (_eventSubProcess2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess2",
					SchemaElementUId = new Guid("26f0f89a-c98f-433c-b488-d4b7a532a6b1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _projectManhourSaved;
		public ProcessFlowElement ProjectManhourSaved {
			get {
				return _projectManhourSaved ?? (_projectManhourSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ProjectManhourSaved",
					SchemaElementUId = new Guid("dea16d2d-8a39-451c-a2b4-5f0ac9267f69"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _projectManhourSavedScriptTask;
		public ProcessScriptTask ProjectManhourSavedScriptTask {
			get {
				return _projectManhourSavedScriptTask ?? (_projectManhourSavedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ProjectManhourSavedScriptTask",
					SchemaElementUId = new Guid("3b6ed6c2-bd1d-48f8-a84d-fc6b4fe8fbc4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ProjectManhourSavedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _projectManhourDeleted;
		public ProcessFlowElement ProjectManhourDeleted {
			get {
				return _projectManhourDeleted ?? (_projectManhourDeleted = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ProjectManhourDeleted",
					SchemaElementUId = new Guid("445cde7e-1b49-4474-8713-8e2819903e06"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _projectRecalcScriptTask;
		public ProcessScriptTask ProjectRecalcScriptTask {
			get {
				return _projectRecalcScriptTask ?? (_projectRecalcScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ProjectRecalcScriptTask",
					SchemaElementUId = new Guid("c7096a1a-82f2-4fba-8119-83bd90935b0a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ProjectRecalcScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[ProjectManhourDeleting.SchemaElementUId] = new Collection<ProcessFlowElement> { ProjectManhourDeleting };
			FlowElements[ProjectManhourDeletingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ProjectManhourDeletingScriptTask };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[ProjectManhourSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { ProjectManhourSaved };
			FlowElements[ProjectManhourSavedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ProjectManhourSavedScriptTask };
			FlowElements[ProjectManhourDeleted.SchemaElementUId] = new Collection<ProcessFlowElement> { ProjectManhourDeleted };
			FlowElements[ProjectRecalcScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ProjectRecalcScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "ProjectManhourDeleting":
						e.Context.QueueTasks.Enqueue("ProjectManhourDeletingScriptTask");
						break;
					case "ProjectManhourDeletingScriptTask":
						break;
					case "EventSubProcess2":
						break;
					case "ProjectManhourSaved":
						e.Context.QueueTasks.Enqueue("ProjectManhourSavedScriptTask");
						break;
					case "ProjectManhourSavedScriptTask":
						e.Context.QueueTasks.Enqueue("ProjectRecalcScriptTask");
						break;
					case "ProjectManhourDeleted":
						e.Context.QueueTasks.Enqueue("ProjectRecalcScriptTask");
						break;
					case "ProjectRecalcScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ProjectManhourDeleting");
			ActivatedEventElements.Add("ProjectManhourSaved");
			ActivatedEventElements.Add("ProjectManhourDeleted");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "ProjectManhourDeleting":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProjectManhourDeleting";
					result = ProjectManhourDeleting.Execute(context);
					break;
				case "ProjectManhourDeletingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProjectManhourDeletingScriptTask";
					result = ProjectManhourDeletingScriptTask.Execute(context, ProjectManhourDeletingScriptTaskExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "ProjectManhourSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProjectManhourSaved";
					result = ProjectManhourSaved.Execute(context);
					break;
				case "ProjectManhourSavedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProjectManhourSavedScriptTask";
					result = ProjectManhourSavedScriptTask.Execute(context, ProjectManhourSavedScriptTaskExecute);
					break;
				case "ProjectManhourDeleted":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProjectManhourDeleted";
					result = ProjectManhourDeleted.Execute(context);
					break;
				case "ProjectRecalcScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProjectRecalcScriptTask";
					result = ProjectRecalcScriptTask.Execute(context, ProjectRecalcScriptTaskExecute);
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

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "ProjectId":
					ProjectId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ProjectManhourDeletingScriptTaskExecute(ProcessExecutingContext context) {
			ProjectId = Entity.GetTypedColumnValue<Guid>("ProjectId");
			return true;
		}

		public virtual bool ProjectManhourSavedScriptTaskExecute(ProcessExecutingContext context) {
			ProjectId = Entity.GetTypedColumnValue<Guid>("ProjectId");
			return true;
		}

		public virtual bool ProjectRecalcScriptTaskExecute(ProcessExecutingContext context) {
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ProjectManhourDeleting":
							if (ActivatedEventElements.Contains("ProjectManhourDeleting")) {
							context.QueueTasks.Enqueue("ProjectManhourDeleting");
						}
						break;
					case "ProjectManhourSaved":
							if (ActivatedEventElements.Contains("ProjectManhourSaved")) {
							context.QueueTasks.Enqueue("ProjectManhourSaved");
						}
						break;
					case "ProjectManhourDeleted":
							if (ActivatedEventElements.Contains("ProjectManhourDeleted")) {
							context.QueueTasks.Enqueue("ProjectManhourDeleted");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("ProjectId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ProjectId", ProjectId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: ProjectResourceElement_ProjectEventsProcess

	/// <exclude/>
	public class ProjectResourceElement_ProjectEventsProcess : ProjectResourceElement_ProjectEventsProcess<ProjectResourceElement>
	{

		public ProjectResourceElement_ProjectEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ProjectResourceElement_ProjectEventsProcess

	public partial class ProjectResourceElement_ProjectEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual decimal Division(decimal arg1, decimal arg2) {
			decimal result = 0;
			if (arg2 > 0) {
				result = Math.Round(arg1 / arg2, 2);
			}
			return result;
		}

		#endregion

	}

	#endregion

	#region Class: ProjectResourceElementEventsProcessSchema

	/// <exclude/>
	public class ProjectResourceElementEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public ProjectResourceElementEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ProjectResourceElementEventsProcessSchema(ProjectResourceElementEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ProjectResourceElement_ProjectEventsProcess";
			UId = new Guid("61c6dd62-f80b-40df-b632-714928f6a3a6");
			CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c");
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

		protected virtual ProcessSchemaParameter CreateProjectIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3129548e-5d1b-4781-913d-395da5a47d39"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("61c6dd62-f80b-40df-b632-714928f6a3a6"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("61c6dd62-f80b-40df-b632-714928f6a3a6"),
				Name = @"ProjectId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateProjectIdParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaRecalcLaneSet = CreateRecalcLaneSetLaneSet();
			LaneSets.Add(schemaRecalcLaneSet);
			ProcessSchemaLane schemaLane = CreateLaneLane();
			schemaRecalcLaneSet.Lanes.Add(schemaLane);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaStartMessageEvent projectmanhourdeleting = CreateProjectManhourDeletingStartMessageEvent();
			eventsubprocess1.FlowElements.Add(projectmanhourdeleting);
			ProcessSchemaScriptTask projectmanhourdeletingscripttask = CreateProjectManhourDeletingScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(projectmanhourdeletingscripttask);
			ProcessSchemaStartMessageEvent projectmanhoursaved = CreateProjectManhourSavedStartMessageEvent();
			eventsubprocess2.FlowElements.Add(projectmanhoursaved);
			ProcessSchemaScriptTask projectmanhoursavedscripttask = CreateProjectManhourSavedScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(projectmanhoursavedscripttask);
			ProcessSchemaStartMessageEvent projectmanhourdeleted = CreateProjectManhourDeletedStartMessageEvent();
			eventsubprocess2.FlowElements.Add(projectmanhourdeleted);
			ProcessSchemaScriptTask projectrecalcscripttask = CreateProjectRecalcScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(projectrecalcscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("40fb279b-f1c5-41bf-a889-94b97774d1d5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("61c6dd62-f80b-40df-b632-714928f6a3a6"),
				CurveCenterPosition = new Point(176, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("61c6dd62-f80b-40df-b632-714928f6a3a6"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f652f2c0-ffed-4072-8479-ed052fa1a36c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("77fbed06-9a68-4d36-9d9c-91d011c06cb1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("ca0cf538-8f6a-4930-bc07-355b8c80590a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("61c6dd62-f80b-40df-b632-714928f6a3a6"),
				CurveCenterPosition = new Point(432, 92),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("61c6dd62-f80b-40df-b632-714928f6a3a6"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dea16d2d-8a39-451c-a2b4-5f0ac9267f69"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3b6ed6c2-bd1d-48f8-a84d-fc6b4fe8fbc4"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("60a9d754-b4f5-45b7-af42-f820208c4cf7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("61c6dd62-f80b-40df-b632-714928f6a3a6"),
				CurveCenterPosition = new Point(562, 128),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("61c6dd62-f80b-40df-b632-714928f6a3a6"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3b6ed6c2-bd1d-48f8-a84d-fc6b4fe8fbc4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c7096a1a-82f2-4fba-8119-83bd90935b0a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("9795d781-4b6e-4e06-aed8-bf37f68b7341"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("61c6dd62-f80b-40df-b632-714928f6a3a6"),
				CurveCenterPosition = new Point(492, 208),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("61c6dd62-f80b-40df-b632-714928f6a3a6"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("445cde7e-1b49-4474-8713-8e2819903e06"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c7096a1a-82f2-4fba-8119-83bd90935b0a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateRecalcLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaRecalcLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("b23b16d1-eb60-4524-bb92-3992f58547d5"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("61c6dd62-f80b-40df-b632-714928f6a3a6"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("61c6dd62-f80b-40df-b632-714928f6a3a6"),
				Name = @"RecalcLaneSet",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(843, 366),
				UseBackgroundMode = false
			};
			return schemaRecalcLaneSet;
		}

		protected virtual ProcessSchemaLane CreateLaneLane() {
			ProcessSchemaLane schemaLane = new ProcessSchemaLane(this) {
				UId = new Guid("0e98353e-bd90-4bcf-a4ca-d40bdda0dbc2"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("b23b16d1-eb60-4524-bb92-3992f58547d5"),
				CreatedInOwnerSchemaUId = new Guid("83e22973-7506-4bc0-88e3-9502851b6c44"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("61c6dd62-f80b-40df-b632-714928f6a3a6"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("61c6dd62-f80b-40df-b632-714928f6a3a6"),
				Name = @"Lane",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(814, 366),
				UseBackgroundMode = false
			};
			return schemaLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e494b425-16df-4a2b-a83b-f0f4c8f3b4b2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0e98353e-bd90-4bcf-a4ca-d40bdda0dbc2"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("61c6dd62-f80b-40df-b632-714928f6a3a6"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("61c6dd62-f80b-40df-b632-714928f6a3a6"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(43, 16),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(219, 155),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateProjectManhourDeletingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f652f2c0-ffed-4072-8479-ed052fa1a36c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e494b425-16df-4a2b-a83b-f0f4c8f3b4b2"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("61c6dd62-f80b-40df-b632-714928f6a3a6"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ProjectManhourDeleting",
				ModifiedInSchemaUId = new Guid("61c6dd62-f80b-40df-b632-714928f6a3a6"),
				Name = @"ProjectManhourDeleting",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(28, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateProjectManhourDeletingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("77fbed06-9a68-4d36-9d9c-91d011c06cb1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e494b425-16df-4a2b-a83b-f0f4c8f3b4b2"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("61c6dd62-f80b-40df-b632-714928f6a3a6"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("61c6dd62-f80b-40df-b632-714928f6a3a6"),
				Name = @"ProjectManhourDeletingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(112, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,40,202,207,74,77,46,241,76,81,176,85,112,205,43,201,44,169,212,115,79,45,9,169,44,72,77,113,206,207,41,205,205,11,75,204,41,77,181,113,47,205,76,177,211,80,10,128,169,86,210,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,14,157,94,77,72,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("26f0f89a-c98f-433c-b488-d4b7a532a6b1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0e98353e-bd90-4bcf-a4ca-d40bdda0dbc2"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("61c6dd62-f80b-40df-b632-714928f6a3a6"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("61c6dd62-f80b-40df-b632-714928f6a3a6"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(301, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(371, 277),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateProjectManhourSavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("dea16d2d-8a39-451c-a2b4-5f0ac9267f69"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("26f0f89a-c98f-433c-b488-d4b7a532a6b1"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("61c6dd62-f80b-40df-b632-714928f6a3a6"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ProjectManhourSaved",
				ModifiedInSchemaUId = new Guid("61c6dd62-f80b-40df-b632-714928f6a3a6"),
				Name = @"ProjectManhourSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateProjectManhourSavedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3b6ed6c2-bd1d-48f8-a84d-fc6b4fe8fbc4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("26f0f89a-c98f-433c-b488-d4b7a532a6b1"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("61c6dd62-f80b-40df-b632-714928f6a3a6"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("61c6dd62-f80b-40df-b632-714928f6a3a6"),
				Name = @"ProjectManhourSavedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(120, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,40,202,207,74,77,46,241,76,81,176,85,112,205,43,201,44,169,212,115,79,45,9,169,44,72,77,113,206,207,41,205,205,11,75,204,41,77,181,113,47,205,76,177,211,80,10,128,169,86,210,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,14,157,94,77,72,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateProjectManhourDeletedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("445cde7e-1b49-4474-8713-8e2819903e06"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("26f0f89a-c98f-433c-b488-d4b7a532a6b1"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("61c6dd62-f80b-40df-b632-714928f6a3a6"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ProjectManhourDeleted",
				ModifiedInSchemaUId = new Guid("61c6dd62-f80b-40df-b632-714928f6a3a6"),
				Name = @"ProjectManhourDeleted",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 177),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateProjectRecalcScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c7096a1a-82f2-4fba-8119-83bd90935b0a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("26f0f89a-c98f-433c-b488-d4b7a532a6b1"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("61c6dd62-f80b-40df-b632-714928f6a3a6"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("61c6dd62-f80b-40df-b632-714928f6a3a6"),
				Name = @"ProjectRecalcScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(246, 121),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateDivisionMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c")
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

		protected virtual SchemaMethod CreateDivisionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7b3c1cf9-51a7-4543-b86c-15938d8373ea"),
				Name = "Division",
				CreatedInSchemaUId = new Guid("61c6dd62-f80b-40df-b632-714928f6a3a6"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				ResultValueTypeName = "decimal"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("aa101803-c92b-419b-81c2-e2cb659ab9cb"),
				Name = "arg1",
				CreatedInSchemaUId = new Guid("61c6dd62-f80b-40df-b632-714928f6a3a6"),
				ModifiedInSchemaUId = new Guid("61c6dd62-f80b-40df-b632-714928f6a3a6"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "decimal",
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c1414a7c-fa50-4b7a-bab7-1f53afcf6f29"),
				Name = "arg2",
				CreatedInSchemaUId = new Guid("61c6dd62-f80b-40df-b632-714928f6a3a6"),
				ModifiedInSchemaUId = new Guid("61c6dd62-f80b-40df-b632-714928f6a3a6"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "decimal",
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,73,77,206,204,77,204,81,40,74,45,46,205,41,81,176,85,48,176,230,202,76,83,208,72,44,74,55,82,176,83,48,208,84,168,230,226,132,75,250,38,150,100,232,5,229,151,230,165,128,20,24,42,232,43,128,212,233,40,24,105,90,115,213,114,21,165,150,148,22,229,65,141,178,6,0,111,100,162,39,90,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ProjectResourceElementEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("61c6dd62-f80b-40df-b632-714928f6a3a6"));
		}

		#endregion

	}

	#endregion


	#region Class: ProjectResourceElementEventsProcess

	/// <exclude/>
	public class ProjectResourceElementEventsProcess : ProjectResourceElement_ProjectEventsProcess
	{

		public ProjectResourceElementEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

