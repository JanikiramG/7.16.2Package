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

	#region Class: WorkResourceElementSchema

	/// <exclude/>
	public class WorkResourceElementSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public WorkResourceElementSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public WorkResourceElementSchema(WorkResourceElementSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public WorkResourceElementSchema(WorkResourceElementSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("63e01d26-170e-4b48-bcad-6a275f2276bb");
			RealUId = new Guid("63e01d26-170e-4b48-bcad-6a275f2276bb");
			Name = "WorkResourceElement";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("ac209bd7-cd6c-436f-8880-b9f73a173b09")) == null) {
				Columns.Add(CreateProjectColumn());
			}
			if (Columns.FindByUId(new Guid("d5abdcd4-070e-4aa0-9f63-cd2461c93de6")) == null) {
				Columns.Add(CreateProjectResourceElementColumn());
			}
			if (Columns.FindByUId(new Guid("c984dfb3-7e35-4f08-8a24-f89757ad3b78")) == null) {
				Columns.Add(CreatePlanningWorkColumn());
			}
			if (Columns.FindByUId(new Guid("cc0f4ccc-ea7e-4152-9a5e-3a03ef43e0a5")) == null) {
				Columns.Add(CreateActualWorkColumn());
			}
			if (Columns.FindByUId(new Guid("883e51c0-723c-40c2-9d2b-b21b29ecc4de")) == null) {
				Columns.Add(CreateExternalRateColumn());
			}
			if (Columns.FindByUId(new Guid("42b5251c-dd69-4d44-9eb8-e6a342ab0611")) == null) {
				Columns.Add(CreateInternalRateColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("63e01d26-170e-4b48-bcad-6a275f2276bb");
			column.CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("63e01d26-170e-4b48-bcad-6a275f2276bb");
			column.CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("63e01d26-170e-4b48-bcad-6a275f2276bb");
			column.CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("63e01d26-170e-4b48-bcad-6a275f2276bb");
			column.CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("63e01d26-170e-4b48-bcad-6a275f2276bb");
			column.CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("63e01d26-170e-4b48-bcad-6a275f2276bb");
			column.CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c");
			return column;
		}

		protected virtual EntitySchemaColumn CreateProjectColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ac209bd7-cd6c-436f-8880-b9f73a173b09"),
				Name = @"Project",
				ReferenceSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("63e01d26-170e-4b48-bcad-6a275f2276bb"),
				ModifiedInSchemaUId = new Guid("63e01d26-170e-4b48-bcad-6a275f2276bb"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c")
			};
		}

		protected virtual EntitySchemaColumn CreateProjectResourceElementColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d5abdcd4-070e-4aa0-9f63-cd2461c93de6"),
				Name = @"ProjectResourceElement",
				ReferenceSchemaUId = new Guid("83e22973-7506-4bc0-88e3-9502851b6c44"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("63e01d26-170e-4b48-bcad-6a275f2276bb"),
				ModifiedInSchemaUId = new Guid("63e01d26-170e-4b48-bcad-6a275f2276bb"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c")
			};
		}

		protected virtual EntitySchemaColumn CreatePlanningWorkColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("c984dfb3-7e35-4f08-8a24-f89757ad3b78"),
				Name = @"PlanningWork",
				CreatedInSchemaUId = new Guid("63e01d26-170e-4b48-bcad-6a275f2276bb"),
				ModifiedInSchemaUId = new Guid("63e01d26-170e-4b48-bcad-6a275f2276bb"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c")
			};
		}

		protected virtual EntitySchemaColumn CreateActualWorkColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("cc0f4ccc-ea7e-4152-9a5e-3a03ef43e0a5"),
				Name = @"ActualWork",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("63e01d26-170e-4b48-bcad-6a275f2276bb"),
				ModifiedInSchemaUId = new Guid("63e01d26-170e-4b48-bcad-6a275f2276bb"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c")
			};
		}

		protected virtual EntitySchemaColumn CreateExternalRateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("883e51c0-723c-40c2-9d2b-b21b29ecc4de"),
				Name = @"ExternalRate",
				CreatedInSchemaUId = new Guid("63e01d26-170e-4b48-bcad-6a275f2276bb"),
				ModifiedInSchemaUId = new Guid("63e01d26-170e-4b48-bcad-6a275f2276bb"),
				CreatedInPackageId = new Guid("61c8641f-c044-4b81-ab30-bcda839818c3")
			};
		}

		protected virtual EntitySchemaColumn CreateInternalRateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("42b5251c-dd69-4d44-9eb8-e6a342ab0611"),
				Name = @"InternalRate",
				CreatedInSchemaUId = new Guid("63e01d26-170e-4b48-bcad-6a275f2276bb"),
				ModifiedInSchemaUId = new Guid("63e01d26-170e-4b48-bcad-6a275f2276bb"),
				CreatedInPackageId = new Guid("61c8641f-c044-4b81-ab30-bcda839818c3")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateWorkResourceElementEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateWorkResourceElementEventsProcessSchema() {
			var schema = new WorkResourceElementEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new WorkResourceElement(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new WorkResourceElement_ProjectEventsProcess(userConnection);
		}

		public override object Clone() {
			return new WorkResourceElementSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new WorkResourceElementSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("63e01d26-170e-4b48-bcad-6a275f2276bb"));
		}

		#endregion

	}

	#endregion

	#region Class: WorkResourceElement

	/// <summary>
	/// Item of project task resources.
	/// </summary>
	public class WorkResourceElement : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public WorkResourceElement(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "WorkResourceElement";
		}

		public WorkResourceElement(WorkResourceElement source)
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
		public Guid ProjectResourceElementId {
			get {
				return GetTypedColumnValue<Guid>("ProjectResourceElementId");
			}
			set {
				SetColumnValue("ProjectResourceElementId", value);
				_projectResourceElement = null;
			}
		}

		/// <exclude/>
		public string ProjectResourceElementName {
			get {
				return GetTypedColumnValue<string>("ProjectResourceElementName");
			}
			set {
				SetColumnValue("ProjectResourceElementName", value);
				if (_projectResourceElement != null) {
					_projectResourceElement.Name = value;
				}
			}
		}

		private ProjectResourceElement _projectResourceElement;
		/// <summary>
		/// Resource.
		/// </summary>
		public ProjectResourceElement ProjectResourceElement {
			get {
				return _projectResourceElement ??
					(_projectResourceElement = LookupColumnEntities.GetEntity("ProjectResourceElement") as ProjectResourceElement);
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
		/// External rate, base currency.
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
		/// Wage, base currency.
		/// </summary>
		public Decimal InternalRate {
			get {
				return GetTypedColumnValue<Decimal>("InternalRate");
			}
			set {
				SetColumnValue("InternalRate", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new WorkResourceElement_ProjectEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("WorkResourceElementDeleted", e);
			Deleting += (s, e) => ThrowEvent("WorkResourceElementDeleting", e);
			Inserting += (s, e) => ThrowEvent("WorkResourceElementInserting", e);
			Saved += (s, e) => ThrowEvent("WorkResourceElementSaved", e);
			Validating += (s, e) => ThrowEvent("WorkResourceElementValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new WorkResourceElement(this);
		}

		#endregion

	}

	#endregion

	#region Class: WorkResourceElement_ProjectEventsProcess

	/// <exclude/>
	public partial class WorkResourceElement_ProjectEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : WorkResourceElement
	{

		public WorkResourceElement_ProjectEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "WorkResourceElement_ProjectEventsProcess";
			SchemaUId = new Guid("63e01d26-170e-4b48-bcad-6a275f2276bb");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("63e01d26-170e-4b48-bcad-6a275f2276bb");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual Guid ProjectResourceElementId {
			get;
			set;
		}

		public virtual Guid ProjectId {
			get;
			set;
		}

		private bool _isWorkResourceDeleted = false;
		public bool IsWorkResourceDeleted {
			get {
				return _isWorkResourceDeleted;
			}
			set {
				_isWorkResourceDeleted = value;
			}
		}

		private ProcessFlowElement _eventSubProcess1;
		public ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("a32a90f0-9b16-46a2-8663-29c9327d1db4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _workResourceElementDeleting;
		public ProcessFlowElement WorkResourceElementDeleting {
			get {
				return _workResourceElementDeleting ?? (_workResourceElementDeleting = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "WorkResourceElementDeleting",
					SchemaElementUId = new Guid("b6be68e7-0128-40f2-b3d3-88f9b612852e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _workResourceElementDeletedScriptTask;
		public ProcessScriptTask WorkResourceElementDeletedScriptTask {
			get {
				return _workResourceElementDeletedScriptTask ?? (_workResourceElementDeletedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "WorkResourceElementDeletedScriptTask",
					SchemaElementUId = new Guid("68fe3975-6e7a-4435-bcb6-707bf26fad5b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = WorkResourceElementDeletedScriptTaskExecute,
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
					SchemaElementUId = new Guid("cf091e89-59bf-4236-870a-3f3235e3ea24"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _workResourceElementSaved;
		public ProcessFlowElement WorkResourceElementSaved {
			get {
				return _workResourceElementSaved ?? (_workResourceElementSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "WorkResourceElementSaved",
					SchemaElementUId = new Guid("6b65bbc9-8e75-4133-ab68-b85768dc8907"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _prepareWorkResourceElementSavedScriptTask;
		public ProcessScriptTask PrepareWorkResourceElementSavedScriptTask {
			get {
				return _prepareWorkResourceElementSavedScriptTask ?? (_prepareWorkResourceElementSavedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PrepareWorkResourceElementSavedScriptTask",
					SchemaElementUId = new Guid("dfca4607-3ff3-4f06-ba70-5ddcaa7d52b6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PrepareWorkResourceElementSavedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _workResourceElementDeleted;
		public ProcessFlowElement WorkResourceElementDeleted {
			get {
				return _workResourceElementDeleted ?? (_workResourceElementDeleted = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "WorkResourceElementDeleted",
					SchemaElementUId = new Guid("4c32a242-e1a7-499f-89ba-44b9ba00fec2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _workResourceElementSavedScriptTask;
		public ProcessScriptTask WorkResourceElementSavedScriptTask {
			get {
				return _workResourceElementSavedScriptTask ?? (_workResourceElementSavedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "WorkResourceElementSavedScriptTask",
					SchemaElementUId = new Guid("ed9ac42c-98a1-40f2-8710-35a8ab6292eb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = WorkResourceElementSavedScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[WorkResourceElementDeleting.SchemaElementUId] = new Collection<ProcessFlowElement> { WorkResourceElementDeleting };
			FlowElements[WorkResourceElementDeletedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { WorkResourceElementDeletedScriptTask };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[WorkResourceElementSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { WorkResourceElementSaved };
			FlowElements[PrepareWorkResourceElementSavedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PrepareWorkResourceElementSavedScriptTask };
			FlowElements[WorkResourceElementDeleted.SchemaElementUId] = new Collection<ProcessFlowElement> { WorkResourceElementDeleted };
			FlowElements[WorkResourceElementSavedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { WorkResourceElementSavedScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "WorkResourceElementDeleting":
						e.Context.QueueTasks.Enqueue("WorkResourceElementDeletedScriptTask");
						break;
					case "WorkResourceElementDeletedScriptTask":
						break;
					case "EventSubProcess2":
						break;
					case "WorkResourceElementSaved":
						e.Context.QueueTasks.Enqueue("PrepareWorkResourceElementSavedScriptTask");
						break;
					case "PrepareWorkResourceElementSavedScriptTask":
						e.Context.QueueTasks.Enqueue("WorkResourceElementSavedScriptTask");
						break;
					case "WorkResourceElementDeleted":
						e.Context.QueueTasks.Enqueue("WorkResourceElementSavedScriptTask");
						break;
					case "WorkResourceElementSavedScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("WorkResourceElementDeleting");
			ActivatedEventElements.Add("WorkResourceElementSaved");
			ActivatedEventElements.Add("WorkResourceElementDeleted");
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
				case "WorkResourceElementDeleting":
					context.QueueTasks.Dequeue();
					context.SenderName = "WorkResourceElementDeleting";
					result = WorkResourceElementDeleting.Execute(context);
					break;
				case "WorkResourceElementDeletedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "WorkResourceElementDeletedScriptTask";
					result = WorkResourceElementDeletedScriptTask.Execute(context, WorkResourceElementDeletedScriptTaskExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "WorkResourceElementSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "WorkResourceElementSaved";
					result = WorkResourceElementSaved.Execute(context);
					break;
				case "PrepareWorkResourceElementSavedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PrepareWorkResourceElementSavedScriptTask";
					result = PrepareWorkResourceElementSavedScriptTask.Execute(context, PrepareWorkResourceElementSavedScriptTaskExecute);
					break;
				case "WorkResourceElementDeleted":
					context.QueueTasks.Dequeue();
					context.SenderName = "WorkResourceElementDeleted";
					result = WorkResourceElementDeleted.Execute(context);
					break;
				case "WorkResourceElementSavedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "WorkResourceElementSavedScriptTask";
					result = WorkResourceElementSavedScriptTask.Execute(context, WorkResourceElementSavedScriptTaskExecute);
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
				case "IsWorkResourceDeleted":
					IsWorkResourceDeleted = reader.GetValue<System.Boolean>();
				break;
				case "ProjectId":
					ProjectId = reader.GetValue<System.Guid>();
				break;
				case "ProjectResourceElementId":
					ProjectResourceElementId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool WorkResourceElementDeletedScriptTaskExecute(ProcessExecutingContext context) {
			ProjectResourceElementId = Entity.GetTypedColumnValue<Guid>("ProjectResourceElementId");
			ProjectId = Entity.GetTypedColumnValue<Guid>("ProjectId");
			IsWorkResourceDeleted = true;
			return true;
		}

		public virtual bool PrepareWorkResourceElementSavedScriptTaskExecute(ProcessExecutingContext context) {
			ProjectResourceElementId = Entity.GetTypedColumnValue<Guid>("ProjectResourceElementId");
			ProjectId = Entity.GetTypedColumnValue<Guid>("ProjectId");
			return true;
		}

		public virtual bool WorkResourceElementSavedScriptTaskExecute(ProcessExecutingContext context) {
			return OnWorkResourceElementSaved(ProjectResourceElementId, ProjectId);
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "WorkResourceElementDeleting":
							if (ActivatedEventElements.Contains("WorkResourceElementDeleting")) {
							context.QueueTasks.Enqueue("WorkResourceElementDeleting");
						}
						break;
					case "WorkResourceElementSaved":
							if (ActivatedEventElements.Contains("WorkResourceElementSaved")) {
							context.QueueTasks.Enqueue("WorkResourceElementSaved");
						}
						break;
					case "WorkResourceElementDeleted":
							if (ActivatedEventElements.Contains("WorkResourceElementDeleted")) {
							context.QueueTasks.Enqueue("WorkResourceElementDeleted");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("IsWorkResourceDeleted") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsWorkResourceDeleted", IsWorkResourceDeleted, false);
			}
			if (!HasMapping("ProjectId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ProjectId", ProjectId, Guid.Empty);
			}
			if (!HasMapping("ProjectResourceElementId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ProjectResourceElementId", ProjectResourceElementId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: WorkResourceElement_ProjectEventsProcess

	/// <exclude/>
	public class WorkResourceElement_ProjectEventsProcess : WorkResourceElement_ProjectEventsProcess<WorkResourceElement>
	{

		public WorkResourceElement_ProjectEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: WorkResourceElement_ProjectEventsProcess

	public partial class WorkResourceElement_ProjectEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void LaborPlanWorkResourceElementUpdate(Guid projectId, Guid projectResourceElementId, decimal planningWork) {
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var workResourceElementSchema = entitySchemaManager.GetInstanceByName("WorkResourceElement");
			var esq = new EntitySchemaQuery(entitySchemaManager, "WorkResourceElement");
			var esqIdColumn = esq.AddColumn("Id");
			var esqPlanningWorkColumn = esq.AddColumn("PlanningWork");
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Project", projectId));
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "ProjectResourceElement", projectResourceElementId));
			var entities = esq.GetEntityCollection(UserConnection);
			if (entities.Count > 0) {
				foreach(var entity in entities) {
					var elementId = entity.GetTypedColumnValue<Guid>(esqIdColumn.Name);
					var work = entity.GetTypedColumnValue<decimal>(esqPlanningWorkColumn.Name);
					if (work < planningWork || (IsWorkResourceDeleted && projectResourceElementId == ProjectResourceElementId)) {
						var entityToSave = workResourceElementSchema.CreateEntity(UserConnection);
						if (entityToSave.FetchFromDB(workResourceElementSchema.GetPrimaryColumnName(), elementId)) {
							entityToSave.SetColumnValue("PlanningWork", planningWork);
							entityToSave.Save();
						}
					}
				}
			} else {
			//	var esqProjectRes = new EntitySchemaQuery(entitySchemaManager, "ProjectResourceElement");
			//	var esqExternalRateColumn = esqProjectRes.AddColumn("ExternalRate");
			//	var esqInternalRateColumn = esqProjectRes.AddColumn("InternalRate");
			//	var projectResourceEntity = esqProjectRes.GetEntity(UserConnection, projectResourceElementId);
			//	if (projectResourceEntity != null) {
			//		var externalRate = projectResourceEntity.GetTypedColumnValue<decimal>(esqExternalRateColumn.Name);
			//		var internalRate = projectResourceEntity.GetTypedColumnValue<decimal>(esqInternalRateColumn.Name);
					var newEntity = workResourceElementSchema.CreateEntity(UserConnection);
					newEntity.SetDefColumnValues();
					newEntity.SetColumnValue("ProjectId", projectId);
					newEntity.SetColumnValue("ProjectResourceElementId", projectResourceElementId);
			//		newEntity.SetColumnValue("ExternalRate", externalRate);
			//		newEntity.SetColumnValue("InternalRate", internalRate);
					newEntity.SetColumnValue("PlanningWork", planningWork);
					newEntity.Save(); 
			//	}
			}
		}

		public virtual bool OnWorkResourceElementSaved(Guid elementId, Guid prjctId) {
			if (elementId != null && elementId != Guid.Empty) {
				var esqProject = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "Project");
				var parentProjectIdColumn = esqProject.AddColumn("ParentProject.Id");
				var projectEntryTypeIdColumn = esqProject.AddColumn("ParentProject.ProjectEntryType.Id");
				var parentProjectId = Guid.Empty;
				var projectEntryTypeId = Guid.Empty;
				
				var project = esqProject.GetEntity(UserConnection, prjctId);
				if (project == null) {
					return true;
				}
				parentProjectId = project.GetTypedColumnValue<Guid>(parentProjectIdColumn.Name);
				projectEntryTypeId = project.GetTypedColumnValue<Guid>(projectEntryTypeIdColumn.Name);
				var planCollection = new Dictionary<Guid, decimal>();
				var esqManhour = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "WorkResourceElement");
				var planColumn = esqManhour.AddColumn("PlanningWork");
				var projectResourceColumn = esqManhour.AddColumn("ProjectResourceElement.Id");
				var projectManhourFilter = esqManhour.CreateFilterWithParameters(FilterComparisonType.Equal,
					"Project.ParentProject", parentProjectId);
				esqManhour.Filters.Add(projectManhourFilter);
				var manhourEntities = esqManhour.GetEntityCollection(UserConnection);
				if (manhourEntities.Count > 0) {
					foreach(var manhourEntity in manhourEntities) {
						var plan = manhourEntity.GetTypedColumnValue<decimal>(planColumn.Name);
						var projectResourceId = manhourEntity.GetTypedColumnValue<Guid>(projectResourceColumn.Name);
						if (planCollection.ContainsKey(projectResourceId)) {
							planCollection[projectResourceId] += plan;
						} else {
							planCollection.Add(projectResourceId, plan);
						}
					}
				}
				if (projectEntryTypeId == new Guid("6B4928D7-456A-4ACD-A863-3361D46B7649")) {
					var projectService = new Terrasoft.Configuration.ProjectService.ProjectService();
					projectService.UpdateProjectResource(parentProjectId);
				} else {
					foreach(var plan in planCollection) {
						LaborPlanWorkResourceElementUpdate(parentProjectId, plan.Key, plan.Value); 
					}
				}
			}
			return true;
		}

		#endregion

	}

	#endregion

	#region Class: WorkResourceElementEventsProcessSchema

	/// <exclude/>
	public class WorkResourceElementEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public WorkResourceElementEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public WorkResourceElementEventsProcessSchema(WorkResourceElementEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "WorkResourceElement_ProjectEventsProcess";
			UId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928");
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

		protected virtual ProcessSchemaParameter CreateProjectResourceElementIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("df511d1f-0fe8-4e35-a66b-dbda12cb4a87"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				Name = @"ProjectResourceElementId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateProjectIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("bed61346-de7b-4584-9516-9102cf263dd2"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				Name = @"ProjectId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsWorkResourceDeletedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3f486778-2a09-491a-acfc-1520e19b4e2c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				Name = @"IsWorkResourceDeleted",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"False",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateProjectResourceElementIdParameter());
			Parameters.Add(CreateProjectIdParameter());
			Parameters.Add(CreateIsWorkResourceDeletedParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaStartMessageEvent workresourceelementdeleting = CreateWorkResourceElementDeletingStartMessageEvent();
			eventsubprocess1.FlowElements.Add(workresourceelementdeleting);
			ProcessSchemaScriptTask workresourceelementdeletedscripttask = CreateWorkResourceElementDeletedScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(workresourceelementdeletedscripttask);
			ProcessSchemaStartMessageEvent workresourceelementsaved = CreateWorkResourceElementSavedStartMessageEvent();
			eventsubprocess2.FlowElements.Add(workresourceelementsaved);
			ProcessSchemaScriptTask prepareworkresourceelementsavedscripttask = CreatePrepareWorkResourceElementSavedScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(prepareworkresourceelementsavedscripttask);
			ProcessSchemaStartMessageEvent workresourceelementdeleted = CreateWorkResourceElementDeletedStartMessageEvent();
			eventsubprocess2.FlowElements.Add(workresourceelementdeleted);
			ProcessSchemaScriptTask workresourceelementsavedscripttask = CreateWorkResourceElementSavedScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(workresourceelementsavedscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("dea59b4d-0d77-4f73-b0bf-c617ee8d0769"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				CurveCenterPosition = new Point(181, 76),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b6be68e7-0128-40f2-b3d3-88f9b612852e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("68fe3975-6e7a-4435-bcb6-707bf26fad5b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("1511dfab-d009-47c8-a8d9-f207ee77bc80"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				CurveCenterPosition = new Point(436, 62),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6b65bbc9-8e75-4133-ab68-b85768dc8907"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("dfca4607-3ff3-4f06-ba70-5ddcaa7d52b6"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("932caa3e-cf5e-4398-a37b-51de2c933421"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				CurveCenterPosition = new Point(576, 88),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dfca4607-3ff3-4f06-ba70-5ddcaa7d52b6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ed9ac42c-98a1-40f2-8710-35a8ab6292eb"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(462, 115));
			schemaFlow.PolylinePointPositions.Add(new Point(588, 115));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("e45c2592-e57d-45f7-93be-a50cc482386a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				CurveCenterPosition = new Point(495, 152),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4c32a242-e1a7-499f-89ba-44b9ba00fec2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ed9ac42c-98a1-40f2-8710-35a8ab6292eb"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(455, 169));
			schemaFlow.PolylinePointPositions.Add(new Point(455, 183));
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("863c13d3-8bd9-492d-a236-36315c67415e"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1094, 270),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("55a28ff8-dbf1-4eed-b85f-beb30c8e3179"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("863c13d3-8bd9-492d-a236-36315c67415e"),
				CreatedInOwnerSchemaUId = new Guid("63e01d26-170e-4b48-bcad-6a275f2276bb"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1065, 270),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a32a90f0-9b16-46a2-8663-29c9327d1db4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("55a28ff8-dbf1-4eed-b85f-beb30c8e3179"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(245, 163),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateWorkResourceElementDeletingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b6be68e7-0128-40f2-b3d3-88f9b612852e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a32a90f0-9b16-46a2-8663-29c9327d1db4"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"WorkResourceElementDeleting",
				ModifiedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				Name = @"WorkResourceElementDeleting",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateWorkResourceElementDeletedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("68fe3975-6e7a-4435-bcb6-707bf26fad5b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a32a90f0-9b16-46a2-8663-29c9327d1db4"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				Name = @"WorkResourceElementDeletedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(106, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,40,202,207,74,77,46,9,74,45,206,47,45,74,78,117,205,73,205,77,205,43,241,76,81,176,85,112,205,43,201,44,169,212,115,79,45,9,169,44,72,77,113,206,207,41,205,205,11,75,204,41,77,181,113,47,205,76,177,211,80,10,192,161,89,73,211,154,151,11,42,73,154,81,80,189,158,197,225,249,69,217,48,115,93,82,115,82,75,82,65,230,148,20,149,166,2,165,139,82,75,74,139,242,32,60,0,134,112,116,172,193,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("cf091e89-59bf-4236-870a-3f3235e3ea24"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("55a28ff8-dbf1-4eed-b85f-beb30c8e3179"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(294, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(374, 249),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateWorkResourceElementSavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6b65bbc9-8e75-4133-ab68-b85768dc8907"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cf091e89-59bf-4236-870a-3f3235e3ea24"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"WorkResourceElementSaved",
				ModifiedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				Name = @"WorkResourceElementSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePrepareWorkResourceElementSavedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("dfca4607-3ff3-4f06-ba70-5ddcaa7d52b6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cf091e89-59bf-4236-870a-3f3235e3ea24"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				Name = @"PrepareWorkResourceElementSavedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(134, 23),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,40,202,207,74,77,46,9,74,45,206,47,45,74,78,117,205,73,205,77,205,43,241,76,81,176,85,112,205,43,201,44,169,212,115,79,45,9,169,44,72,77,113,206,207,41,205,205,11,75,204,41,77,181,113,47,205,76,177,211,80,10,192,161,89,73,211,154,151,11,42,73,154,81,80,189,69,169,37,165,69,121,10,37,69,165,169,214,0,84,193,175,49,162,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateWorkResourceElementDeletedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("4c32a242-e1a7-499f-89ba-44b9ba00fec2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cf091e89-59bf-4236-870a-3f3235e3ea24"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"WorkResourceElementDeleted",
				ModifiedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				Name = @"WorkResourceElementDeleted",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 149),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateWorkResourceElementSavedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ed9ac42c-98a1-40f2-8710-35a8ab6292eb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cf091e89-59bf-4236-870a-3f3235e3ea24"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				Name = @"WorkResourceElementSavedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(260, 149),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,240,207,11,207,47,202,14,74,45,206,47,45,74,78,117,205,73,205,77,205,43,9,78,44,75,77,209,8,40,202,207,74,77,46,65,147,243,76,209,81,128,202,120,166,104,90,3,0,204,5,166,176,71,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateLaborPlanWorkResourceElementUpdateMethod());
			Methods.Add(CreateOnWorkResourceElementSavedMethod());
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

		protected virtual SchemaMethod CreateLaborPlanWorkResourceElementUpdateMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("81e4de1d-4dd2-4312-9c3e-dadef99de30b"),
				Name = "LaborPlanWorkResourceElementUpdate",
				CreatedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("08f2ad96-5149-4d18-ae51-290e6dca455a"),
				Name = "projectId",
				CreatedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				ModifiedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f12127ec-2c54-4cc8-9d6b-f4a490d9faa6"),
				Name = "projectResourceElementId",
				CreatedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				ModifiedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ae17db6a-1a61-449f-8422-f70fbf2e5e02"),
				Name = "planningWork",
				CreatedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				ModifiedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "decimal",
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,85,77,111,219,48,12,61,187,64,255,131,150,67,161,0,134,187,251,154,2,107,62,10,31,54,100,77,183,158,5,155,105,180,201,82,34,203,233,140,181,255,125,146,101,59,242,87,178,162,221,33,66,108,145,143,228,227,35,189,39,18,1,87,84,229,171,104,3,9,249,66,56,121,4,137,38,232,123,10,114,42,56,135,72,81,193,131,121,215,232,211,249,217,94,187,63,9,249,235,14,82,145,201,8,230,12,18,13,103,205,52,72,15,116,112,11,42,228,169,34,60,130,155,252,43,73,0,143,30,186,16,163,113,9,15,233,78,3,113,120,66,110,10,223,50,144,57,238,129,247,209,41,180,48,158,10,150,37,220,164,151,238,130,207,113,249,140,71,97,236,218,45,25,225,156,242,71,3,55,228,225,218,20,190,230,126,65,153,2,153,26,59,108,158,167,18,136,2,251,246,129,170,205,146,72,93,181,49,193,246,229,84,36,91,34,105,42,248,125,190,133,96,190,203,8,211,117,44,165,248,169,217,31,249,104,107,255,133,241,248,63,197,104,211,85,135,108,93,148,25,236,43,213,80,72,75,82,116,87,109,127,52,53,204,106,6,55,37,100,28,233,26,225,202,49,152,138,140,43,116,141,62,142,209,159,243,51,111,45,116,13,209,6,215,224,57,162,188,14,99,109,188,226,178,202,165,22,152,137,110,202,42,251,242,131,176,12,174,110,51,26,95,99,167,225,129,17,155,201,194,194,24,221,30,71,136,33,162,9,97,5,72,87,13,14,156,41,171,128,187,66,91,199,14,61,63,35,28,166,174,30,103,58,121,5,49,186,184,24,100,24,77,38,168,191,45,134,125,75,131,119,32,233,94,172,200,30,116,33,131,115,88,138,195,182,167,167,41,158,45,192,133,11,22,160,162,205,66,138,100,118,131,135,129,53,105,75,169,41,146,185,165,164,152,230,177,127,232,80,157,175,215,64,95,129,114,120,110,141,145,223,224,176,76,176,229,175,15,92,222,188,152,211,28,250,247,162,35,167,96,66,94,94,122,213,24,215,84,190,114,141,12,140,134,9,123,64,159,255,214,179,197,9,187,211,4,187,75,226,224,236,174,11,215,186,5,20,242,215,0,185,214,46,80,91,83,118,140,218,64,245,172,182,196,112,100,234,109,8,35,147,254,16,31,52,183,25,99,227,146,123,91,149,83,173,206,161,215,241,228,220,117,9,174,231,174,138,67,249,59,196,233,242,223,90,23,90,58,53,157,111,24,181,26,198,12,193,12,214,78,62,41,238,49,105,206,73,245,29,104,124,19,254,205,169,211,211,99,75,190,100,119,24,180,161,100,191,209,234,211,206,13,245,250,141,254,157,44,230,212,166,112,92,237,146,64,69,54,102,57,252,5,61,98,142,180,236,8,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnWorkResourceElementSavedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4d8cb177-4991-4bf3-822a-7336ab4d7fa2"),
				Name = "OnWorkResourceElementSaved",
				CreatedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				CreatedInPackageId = new Guid("c746724b-ad7f-4327-918b-435a466c9305"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("acbabd70-0775-4fea-b10e-01756376b0ac"),
				Name = "elementId",
				CreatedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				ModifiedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("c746724b-ad7f-4327-918b-435a466c9305")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("eea5eba5-c785-4f4e-bcc9-e2fe20653586"),
				Name = "prjctId",
				CreatedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				ModifiedInSchemaUId = new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("c746724b-ad7f-4327-918b-435a466c9305")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,85,77,79,219,64,16,61,39,191,98,235,3,114,212,196,106,155,52,128,40,145,66,18,80,212,15,165,5,202,161,234,97,27,79,200,82,123,29,214,107,42,171,202,127,239,236,71,28,239,98,68,171,30,144,240,50,243,230,205,155,55,3,91,145,16,18,72,129,203,121,76,94,156,18,94,36,9,57,56,32,206,227,69,193,226,104,150,110,100,217,33,191,219,173,7,42,8,228,247,11,145,221,193,82,18,76,130,95,100,198,37,147,229,229,114,13,41,253,92,128,40,195,235,28,196,36,227,28,99,88,198,163,122,192,71,202,233,45,136,46,9,44,72,208,57,49,184,27,42,176,172,125,157,199,147,44,41,82,142,37,246,245,162,113,108,159,195,96,81,143,142,230,241,30,198,60,97,77,81,94,149,27,248,71,164,133,151,238,64,187,12,73,93,158,39,171,251,81,78,156,75,234,2,164,145,202,19,176,139,225,119,170,162,34,194,112,110,85,182,153,154,30,77,75,128,44,4,39,82,20,128,97,219,118,235,49,221,205,190,144,34,103,37,248,74,147,2,222,41,146,163,176,113,8,209,39,154,130,170,221,216,221,95,128,62,49,146,10,87,43,146,80,142,207,137,105,217,90,107,202,244,23,21,165,134,234,146,24,150,44,165,201,40,220,165,161,124,104,169,117,86,136,255,115,227,77,38,126,126,129,28,113,150,48,51,27,16,120,212,42,19,217,130,142,137,48,132,51,126,171,96,124,43,238,96,159,131,112,163,45,137,6,107,219,220,115,150,72,16,46,220,68,0,149,96,254,114,195,228,26,189,141,18,227,71,30,154,199,73,150,226,136,89,158,113,109,238,217,125,65,147,46,154,39,168,252,95,55,64,208,245,61,175,168,212,234,25,208,92,181,17,54,177,219,49,79,205,163,150,158,65,238,146,174,108,191,31,191,55,179,157,239,61,152,104,146,21,92,146,17,121,101,54,96,149,97,251,203,117,232,87,44,9,227,62,5,147,81,141,23,25,57,25,141,110,174,204,183,55,68,101,225,86,211,196,245,126,60,143,235,108,137,235,150,26,190,94,124,103,73,176,127,46,41,227,249,123,40,253,116,28,149,109,177,229,38,125,123,20,248,157,188,60,213,34,232,50,91,252,7,144,67,99,106,125,204,251,244,174,206,53,28,241,234,168,159,173,115,166,156,115,97,150,84,117,28,6,195,179,193,241,155,163,233,97,111,240,118,56,238,13,198,147,105,111,124,52,236,247,250,253,225,235,233,96,120,118,56,28,28,7,182,141,154,186,151,32,30,216,18,236,190,95,129,16,52,207,86,82,169,177,98,183,133,160,154,235,194,9,246,62,245,249,104,185,120,209,245,38,198,229,241,214,208,191,136,42,177,38,81,221,114,218,71,232,52,87,52,59,133,15,244,71,38,212,149,104,56,52,166,176,95,201,232,26,225,108,237,111,218,44,157,19,178,211,120,219,174,159,252,63,50,230,158,19,208,7,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new WorkResourceElementEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("78a7835a-8b65-4f9c-8b62-d548258b0928"));
		}

		#endregion

	}

	#endregion


	#region Class: WorkResourceElementEventsProcess

	/// <exclude/>
	public class WorkResourceElementEventsProcess : WorkResourceElement_ProjectEventsProcess
	{

		public WorkResourceElementEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

