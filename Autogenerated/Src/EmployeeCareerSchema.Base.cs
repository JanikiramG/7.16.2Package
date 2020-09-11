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
	using Terrasoft.Configuration.EntitySynchronization;
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

	#region Class: EmployeeCareerSchema

	/// <exclude/>
	public class EmployeeCareerSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public EmployeeCareerSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public EmployeeCareerSchema(EmployeeCareerSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public EmployeeCareerSchema(EmployeeCareerSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ae722ecf-3686-4a24-a3b6-0c2d798df738");
			RealUId = new Guid("ae722ecf-3686-4a24-a3b6-0c2d798df738");
			Name = "EmployeeCareer";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("10b4c663-af0f-45ba-83fb-f1357581f2c9")) == null) {
				Columns.Add(CreateEmployeeColumn());
			}
			if (Columns.FindByUId(new Guid("cfcc24ef-4b62-4d40-bdd8-2ea802b9b1ba")) == null) {
				Columns.Add(CreateAccountColumn());
			}
			if (Columns.FindByUId(new Guid("96999841-abaf-443b-9f61-bbe15a5a77d3")) == null) {
				Columns.Add(CreateOrgStructureUnitColumn());
			}
			if (Columns.FindByUId(new Guid("24e53dfb-546c-46be-89b0-e258928bb694")) == null) {
				Columns.Add(CreateEmployeeJobColumn());
			}
			if (Columns.FindByUId(new Guid("b4946cf5-1b3e-4580-a8fc-a416accd6524")) == null) {
				Columns.Add(CreateFullJobTitleColumn());
			}
			if (Columns.FindByUId(new Guid("11899472-7e69-44b8-9ef9-1242e562b269")) == null) {
				Columns.Add(CreateStartDateColumn());
			}
			if (Columns.FindByUId(new Guid("ff98adaf-5bb0-4d34-83f5-6bcb57ce8f22")) == null) {
				Columns.Add(CreateDueDateColumn());
			}
			if (Columns.FindByUId(new Guid("25543607-7543-4a60-9ca5-cba0edc1affe")) == null) {
				Columns.Add(CreateIsCurrentColumn());
			}
			if (Columns.FindByUId(new Guid("778c9d14-dfa3-4e73-9176-231545aae84a")) == null) {
				Columns.Add(CreateProbationDueDateColumn());
			}
			if (Columns.FindByUId(new Guid("e164a462-4b52-4e50-b766-16fa1912624c")) == null) {
				Columns.Add(CreateReasonForDismissalColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateEmployeeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("10b4c663-af0f-45ba-83fb-f1357581f2c9"),
				Name = @"Employee",
				ReferenceSchemaUId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("ae722ecf-3686-4a24-a3b6-0c2d798df738"),
				ModifiedInSchemaUId = new Guid("ae722ecf-3686-4a24-a3b6-0c2d798df738"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("cfcc24ef-4b62-4d40-bdd8-2ea802b9b1ba"),
				Name = @"Account",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ae722ecf-3686-4a24-a3b6-0c2d798df738"),
				ModifiedInSchemaUId = new Guid("ae722ecf-3686-4a24-a3b6-0c2d798df738"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateOrgStructureUnitColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("96999841-abaf-443b-9f61-bbe15a5a77d3"),
				Name = @"OrgStructureUnit",
				ReferenceSchemaUId = new Guid("92ac6269-362a-4cd2-9574-28f12be3ab78"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ae722ecf-3686-4a24-a3b6-0c2d798df738"),
				ModifiedInSchemaUId = new Guid("ae722ecf-3686-4a24-a3b6-0c2d798df738"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateEmployeeJobColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("24e53dfb-546c-46be-89b0-e258928bb694"),
				Name = @"EmployeeJob",
				ReferenceSchemaUId = new Guid("c3a74d81-99ee-4c40-8434-0c6eb23edf59"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ae722ecf-3686-4a24-a3b6-0c2d798df738"),
				ModifiedInSchemaUId = new Guid("ae722ecf-3686-4a24-a3b6-0c2d798df738"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateFullJobTitleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("b4946cf5-1b3e-4580-a8fc-a416accd6524"),
				Name = @"FullJobTitle",
				CreatedInSchemaUId = new Guid("ae722ecf-3686-4a24-a3b6-0c2d798df738"),
				ModifiedInSchemaUId = new Guid("ae722ecf-3686-4a24-a3b6-0c2d798df738"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateStartDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("11899472-7e69-44b8-9ef9-1242e562b269"),
				Name = @"StartDate",
				CreatedInSchemaUId = new Guid("ae722ecf-3686-4a24-a3b6-0c2d798df738"),
				ModifiedInSchemaUId = new Guid("ae722ecf-3686-4a24-a3b6-0c2d798df738"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateDueDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("ff98adaf-5bb0-4d34-83f5-6bcb57ce8f22"),
				Name = @"DueDate",
				CreatedInSchemaUId = new Guid("ae722ecf-3686-4a24-a3b6-0c2d798df738"),
				ModifiedInSchemaUId = new Guid("ae722ecf-3686-4a24-a3b6-0c2d798df738"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateIsCurrentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("25543607-7543-4a60-9ca5-cba0edc1affe"),
				Name = @"IsCurrent",
				CreatedInSchemaUId = new Guid("ae722ecf-3686-4a24-a3b6-0c2d798df738"),
				ModifiedInSchemaUId = new Guid("ae722ecf-3686-4a24-a3b6-0c2d798df738"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateProbationDueDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("778c9d14-dfa3-4e73-9176-231545aae84a"),
				Name = @"ProbationDueDate",
				CreatedInSchemaUId = new Guid("ae722ecf-3686-4a24-a3b6-0c2d798df738"),
				ModifiedInSchemaUId = new Guid("ae722ecf-3686-4a24-a3b6-0c2d798df738"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateReasonForDismissalColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e164a462-4b52-4e50-b766-16fa1912624c"),
				Name = @"ReasonForDismissal",
				ReferenceSchemaUId = new Guid("acc6f535-717d-4cda-81e1-c4a3df4bec79"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ae722ecf-3686-4a24-a3b6-0c2d798df738"),
				ModifiedInSchemaUId = new Guid("ae722ecf-3686-4a24-a3b6-0c2d798df738"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				IsSimpleLookup = true
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateEmployeeCareerEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateEmployeeCareerEventsProcessSchema() {
			var schema = new EmployeeCareerEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new EmployeeCareer(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new EmployeeCareer_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new EmployeeCareerSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new EmployeeCareerSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ae722ecf-3686-4a24-a3b6-0c2d798df738"));
		}

		#endregion

	}

	#endregion

	#region Class: EmployeeCareer

	/// <summary>
	/// Employee career in our company.
	/// </summary>
	public class EmployeeCareer : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public EmployeeCareer(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "EmployeeCareer";
		}

		public EmployeeCareer(EmployeeCareer source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid EmployeeId {
			get {
				return GetTypedColumnValue<Guid>("EmployeeId");
			}
			set {
				SetColumnValue("EmployeeId", value);
				_employee = null;
			}
		}

		/// <exclude/>
		public string EmployeeName {
			get {
				return GetTypedColumnValue<string>("EmployeeName");
			}
			set {
				SetColumnValue("EmployeeName", value);
				if (_employee != null) {
					_employee.Name = value;
				}
			}
		}

		private Employee _employee;
		/// <summary>
		/// Employee.
		/// </summary>
		public Employee Employee {
			get {
				return _employee ??
					(_employee = LookupColumnEntities.GetEntity("Employee") as Employee);
			}
		}

		/// <exclude/>
		public Guid AccountId {
			get {
				return GetTypedColumnValue<Guid>("AccountId");
			}
			set {
				SetColumnValue("AccountId", value);
				_account = null;
			}
		}

		/// <exclude/>
		public string AccountName {
			get {
				return GetTypedColumnValue<string>("AccountName");
			}
			set {
				SetColumnValue("AccountName", value);
				if (_account != null) {
					_account.Name = value;
				}
			}
		}

		private Account _account;
		/// <summary>
		/// Account.
		/// </summary>
		public Account Account {
			get {
				return _account ??
					(_account = LookupColumnEntities.GetEntity("Account") as Account);
			}
		}

		/// <exclude/>
		public Guid OrgStructureUnitId {
			get {
				return GetTypedColumnValue<Guid>("OrgStructureUnitId");
			}
			set {
				SetColumnValue("OrgStructureUnitId", value);
				_orgStructureUnit = null;
			}
		}

		/// <exclude/>
		public string OrgStructureUnitName {
			get {
				return GetTypedColumnValue<string>("OrgStructureUnitName");
			}
			set {
				SetColumnValue("OrgStructureUnitName", value);
				if (_orgStructureUnit != null) {
					_orgStructureUnit.Name = value;
				}
			}
		}

		private OrgStructureUnit _orgStructureUnit;
		/// <summary>
		/// Organization structure item.
		/// </summary>
		public OrgStructureUnit OrgStructureUnit {
			get {
				return _orgStructureUnit ??
					(_orgStructureUnit = LookupColumnEntities.GetEntity("OrgStructureUnit") as OrgStructureUnit);
			}
		}

		/// <exclude/>
		public Guid EmployeeJobId {
			get {
				return GetTypedColumnValue<Guid>("EmployeeJobId");
			}
			set {
				SetColumnValue("EmployeeJobId", value);
				_employeeJob = null;
			}
		}

		/// <exclude/>
		public string EmployeeJobName {
			get {
				return GetTypedColumnValue<string>("EmployeeJobName");
			}
			set {
				SetColumnValue("EmployeeJobName", value);
				if (_employeeJob != null) {
					_employeeJob.Name = value;
				}
			}
		}

		private EmployeeJob _employeeJob;
		/// <summary>
		/// Job title.
		/// </summary>
		public EmployeeJob EmployeeJob {
			get {
				return _employeeJob ??
					(_employeeJob = LookupColumnEntities.GetEntity("EmployeeJob") as EmployeeJob);
			}
		}

		/// <summary>
		/// Full job title.
		/// </summary>
		public string FullJobTitle {
			get {
				return GetTypedColumnValue<string>("FullJobTitle");
			}
			set {
				SetColumnValue("FullJobTitle", value);
			}
		}

		/// <summary>
		/// Start date.
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
		/// Due date.
		/// </summary>
		public DateTime DueDate {
			get {
				return GetTypedColumnValue<DateTime>("DueDate");
			}
			set {
				SetColumnValue("DueDate", value);
			}
		}

		/// <summary>
		/// Current.
		/// </summary>
		public bool IsCurrent {
			get {
				return GetTypedColumnValue<bool>("IsCurrent");
			}
			set {
				SetColumnValue("IsCurrent", value);
			}
		}

		/// <summary>
		/// Probation ends.
		/// </summary>
		public DateTime ProbationDueDate {
			get {
				return GetTypedColumnValue<DateTime>("ProbationDueDate");
			}
			set {
				SetColumnValue("ProbationDueDate", value);
			}
		}

		/// <exclude/>
		public Guid ReasonForDismissalId {
			get {
				return GetTypedColumnValue<Guid>("ReasonForDismissalId");
			}
			set {
				SetColumnValue("ReasonForDismissalId", value);
				_reasonForDismissal = null;
			}
		}

		/// <exclude/>
		public string ReasonForDismissalName {
			get {
				return GetTypedColumnValue<string>("ReasonForDismissalName");
			}
			set {
				SetColumnValue("ReasonForDismissalName", value);
				if (_reasonForDismissal != null) {
					_reasonForDismissal.Name = value;
				}
			}
		}

		private ReasonForLeaving _reasonForDismissal;
		/// <summary>
		/// Reason for job change.
		/// </summary>
		public ReasonForLeaving ReasonForDismissal {
			get {
				return _reasonForDismissal ??
					(_reasonForDismissal = LookupColumnEntities.GetEntity("ReasonForDismissal") as ReasonForLeaving);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new EmployeeCareer_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("EmployeeCareerDeleted", e);
			Saved += (s, e) => ThrowEvent("EmployeeCareerSaved", e);
			Saving += (s, e) => ThrowEvent("EmployeeCareerSaving", e);
			Validating += (s, e) => ThrowEvent("EmployeeCareerValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new EmployeeCareer(this);
		}

		#endregion

	}

	#endregion

	#region Class: EmployeeCareer_BaseEventsProcess

	/// <exclude/>
	public partial class EmployeeCareer_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : EmployeeCareer
	{

		public EmployeeCareer_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "EmployeeCareer_BaseEventsProcess";
			SchemaUId = new Guid("ae722ecf-3686-4a24-a3b6-0c2d798df738");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ae722ecf-3686-4a24-a3b6-0c2d798df738");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual bool CurrentColumnOldValue {
			get;
			set;
		}

		private ProcessFlowElement _employeeCareerSavedSubProcess;
		public ProcessFlowElement EmployeeCareerSavedSubProcess {
			get {
				return _employeeCareerSavedSubProcess ?? (_employeeCareerSavedSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EmployeeCareerSavedSubProcess",
					SchemaElementUId = new Guid("0a5283f1-f802-4f3a-b5c9-da23cbbcb437"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _employeeCareerSavedMessage;
		public ProcessFlowElement EmployeeCareerSavedMessage {
			get {
				return _employeeCareerSavedMessage ?? (_employeeCareerSavedMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "EmployeeCareerSavedMessage",
					SchemaElementUId = new Guid("d75b9d4b-919f-4059-8248-c2eaca0d02ec"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _employeeCareerSavedScriptTask;
		public ProcessScriptTask EmployeeCareerSavedScriptTask {
			get {
				return _employeeCareerSavedScriptTask ?? (_employeeCareerSavedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "EmployeeCareerSavedScriptTask",
					SchemaElementUId = new Guid("404c5511-5c03-4ab4-be43-f1e0491200a1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = EmployeeCareerSavedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _employeeCareerDeletedSubProcess;
		public ProcessFlowElement EmployeeCareerDeletedSubProcess {
			get {
				return _employeeCareerDeletedSubProcess ?? (_employeeCareerDeletedSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EmployeeCareerDeletedSubProcess",
					SchemaElementUId = new Guid("22905abb-fcd6-49f0-b865-fa64734b607b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _employeeCareerDeletedMessage;
		public ProcessFlowElement EmployeeCareerDeletedMessage {
			get {
				return _employeeCareerDeletedMessage ?? (_employeeCareerDeletedMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "EmployeeCareerDeletedMessage",
					SchemaElementUId = new Guid("9b3a3736-9c12-4f92-bd66-122b12bfc8eb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _employeeCareerDeletedScriptTask;
		public ProcessScriptTask EmployeeCareerDeletedScriptTask {
			get {
				return _employeeCareerDeletedScriptTask ?? (_employeeCareerDeletedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "EmployeeCareerDeletedScriptTask",
					SchemaElementUId = new Guid("e3a8b115-d331-42ef-b770-2a21d38d3746"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = EmployeeCareerDeletedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _employeeCareerSavingSubProcess;
		public ProcessFlowElement EmployeeCareerSavingSubProcess {
			get {
				return _employeeCareerSavingSubProcess ?? (_employeeCareerSavingSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EmployeeCareerSavingSubProcess",
					SchemaElementUId = new Guid("b5b8e3db-df14-4fdf-a6be-555b3d642589"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _employeeCareerSavingMessage;
		public ProcessFlowElement EmployeeCareerSavingMessage {
			get {
				return _employeeCareerSavingMessage ?? (_employeeCareerSavingMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "EmployeeCareerSavingMessage",
					SchemaElementUId = new Guid("f374721a-8d5a-4c22-b5c3-87c69e0d9b46"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _employeeCareerSavingScriptTask;
		public ProcessScriptTask EmployeeCareerSavingScriptTask {
			get {
				return _employeeCareerSavingScriptTask ?? (_employeeCareerSavingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "EmployeeCareerSavingScriptTask",
					SchemaElementUId = new Guid("0002caf6-310f-424b-b68c-60e3ead42a96"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = EmployeeCareerSavingScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EmployeeCareerSavedSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { EmployeeCareerSavedSubProcess };
			FlowElements[EmployeeCareerSavedMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EmployeeCareerSavedMessage };
			FlowElements[EmployeeCareerSavedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { EmployeeCareerSavedScriptTask };
			FlowElements[EmployeeCareerDeletedSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { EmployeeCareerDeletedSubProcess };
			FlowElements[EmployeeCareerDeletedMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EmployeeCareerDeletedMessage };
			FlowElements[EmployeeCareerDeletedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { EmployeeCareerDeletedScriptTask };
			FlowElements[EmployeeCareerSavingSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { EmployeeCareerSavingSubProcess };
			FlowElements[EmployeeCareerSavingMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EmployeeCareerSavingMessage };
			FlowElements[EmployeeCareerSavingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { EmployeeCareerSavingScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EmployeeCareerSavedSubProcess":
						break;
					case "EmployeeCareerSavedMessage":
						e.Context.QueueTasks.Enqueue("EmployeeCareerSavedScriptTask");
						break;
					case "EmployeeCareerSavedScriptTask":
						break;
					case "EmployeeCareerDeletedSubProcess":
						break;
					case "EmployeeCareerDeletedMessage":
						e.Context.QueueTasks.Enqueue("EmployeeCareerDeletedScriptTask");
						break;
					case "EmployeeCareerDeletedScriptTask":
						break;
					case "EmployeeCareerSavingSubProcess":
						break;
					case "EmployeeCareerSavingMessage":
						e.Context.QueueTasks.Enqueue("EmployeeCareerSavingScriptTask");
						break;
					case "EmployeeCareerSavingScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("EmployeeCareerSavedMessage");
			ActivatedEventElements.Add("EmployeeCareerDeletedMessage");
			ActivatedEventElements.Add("EmployeeCareerSavingMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EmployeeCareerSavedSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "EmployeeCareerSavedMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "EmployeeCareerSavedMessage";
					result = EmployeeCareerSavedMessage.Execute(context);
					break;
				case "EmployeeCareerSavedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "EmployeeCareerSavedScriptTask";
					result = EmployeeCareerSavedScriptTask.Execute(context, EmployeeCareerSavedScriptTaskExecute);
					break;
				case "EmployeeCareerDeletedSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "EmployeeCareerDeletedMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "EmployeeCareerDeletedMessage";
					result = EmployeeCareerDeletedMessage.Execute(context);
					break;
				case "EmployeeCareerDeletedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "EmployeeCareerDeletedScriptTask";
					result = EmployeeCareerDeletedScriptTask.Execute(context, EmployeeCareerDeletedScriptTaskExecute);
					break;
				case "EmployeeCareerSavingSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "EmployeeCareerSavingMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "EmployeeCareerSavingMessage";
					result = EmployeeCareerSavingMessage.Execute(context);
					break;
				case "EmployeeCareerSavingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "EmployeeCareerSavingScriptTask";
					result = EmployeeCareerSavingScriptTask.Execute(context, EmployeeCareerSavingScriptTaskExecute);
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
				case "CurrentColumnOldValue":
					CurrentColumnOldValue = reader.GetValue<System.Boolean>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool EmployeeCareerSavedScriptTaskExecute(ProcessExecutingContext context) {
			OnEmployeeCareerSaved();
			return true;
		}

		public virtual bool EmployeeCareerDeletedScriptTaskExecute(ProcessExecutingContext context) {
			OnEmployeeCareerDeleted();
			return true;
		}

		public virtual bool EmployeeCareerSavingScriptTaskExecute(ProcessExecutingContext context) {
			OnEmployeeCareerSaving();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "EmployeeCareerSaved":
							if (ActivatedEventElements.Contains("EmployeeCareerSavedMessage")) {
							context.QueueTasks.Enqueue("EmployeeCareerSavedMessage");
						}
						break;
					case "EmployeeCareerDeleted":
							if (ActivatedEventElements.Contains("EmployeeCareerDeletedMessage")) {
							context.QueueTasks.Enqueue("EmployeeCareerDeletedMessage");
						}
						break;
					case "EmployeeCareerSaving":
							if (ActivatedEventElements.Contains("EmployeeCareerSavingMessage")) {
							context.QueueTasks.Enqueue("EmployeeCareerSavingMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("CurrentColumnOldValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CurrentColumnOldValue", CurrentColumnOldValue, false);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: EmployeeCareer_BaseEventsProcess

	/// <exclude/>
	public class EmployeeCareer_BaseEventsProcess : EmployeeCareer_BaseEventsProcess<EmployeeCareer>
	{

		public EmployeeCareer_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: EmployeeCareer_BaseEventsProcess

	public partial class EmployeeCareer_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void OnEmployeeCareerSaved() {
			bool isCurrent = Entity.GetTypedColumnValue<bool>("IsCurrent");
			if (isCurrent) {
				ResetOldEmployment();
				SynchronizeEmployeeCareerAndEmployee();
			} else if (!isCurrent && CurrentColumnOldValue) {
				SynchronizeEmployeeCareerAndEmployee();
			}
		}

		public virtual void SynchronizeEmployeeCareerAndEmployee() {
			IEntitySynchronizationProvider provider = CreateEntitySynchronizationProvider();
			Entity employee = provider.FindEntity("Employee", new Dictionary<string, object> {
				{"Id", Entity.GetTypedColumnValue<Guid>("EmployeeId")}
			});
			if (employee != null) {
				ICollection<SynchronizationColumnMapping> columnMappings = GetSynchronizationColumnMappings();
				IColumnValuesSynchronizer synchronizer = CreateColumnValuesSynchronizer();
				synchronizer.SynchronizeEntities(Entity, employee, columnMappings);
				employee.Save();
			}
		}

		public virtual void ResetOldEmployment() {
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "EmployeeCareer");
			esq.PrimaryQueryColumn.IsAlwaysSelect = true;
			esq.AddAllSchemaColumns(true);
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.NotEqual, esq.RootSchema.PrimaryColumn.Name,
				Entity.PrimaryColumnValue));
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Employee",
				Entity.GetTypedColumnValue<Guid>("EmployeeId")));
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "IsCurrent", true));
			EntityCollection careers = esq.GetEntityCollection(UserConnection);
			careers.ForEach(ResetOldCareer);
		}

		public virtual IColumnValuesSynchronizer CreateColumnValuesSynchronizer() {
			return ClassFactory.Get<ColumnValuesSynchronizer>();
		}

		public virtual IEntitySynchronizationProvider CreateEntitySynchronizationProvider() {
			return ClassFactory.Get<EntitySynchronizationProvider>(new ConstructorArgument("userConnection", UserConnection));
		}

		public virtual ICollection<SynchronizationColumnMapping> GetSynchronizationColumnMappings() {
			IEqualComparatorProvider provider = CreateEqualComparatorProvider();
			SynchronizationColumnComparator dateEqualComparator = provider.GetDateEqualComparator();
			SynchronizationColumnComparator stringEqualComparator = provider.GetStringEqualComparator();
			return new List<SynchronizationColumnMapping> {
				new SynchronizationColumnMapping {
					SourceColumnName = "AccountId",
					DestinationColumnName = "AccountId"
				},
				new SynchronizationColumnMapping {
					SourceColumnName = "OrgStructureUnitId",
					DestinationColumnName = "OrgStructureUnitId"
				},
				new SynchronizationColumnMapping {
					SourceColumnName = "EmployeeJobId",
					DestinationColumnName = "JobId"
				},
				new SynchronizationColumnMapping {
					SourceColumnName = "FullJobTitle",
					DestinationColumnName = "FullJobTitle",
					Comparator = stringEqualComparator
				},
				new SynchronizationColumnMapping {
					SourceColumnName = "StartDate",
					DestinationColumnName = "CareerStartDate",
					Comparator = dateEqualComparator
				},
				new SynchronizationColumnMapping {
					SourceColumnName = "DueDate",
					DestinationColumnName = "CareerDueDate",
					Comparator = dateEqualComparator
				},
				new SynchronizationColumnMapping {
					SourceColumnName = "ProbationDueDate",
					DestinationColumnName = "ProbationDueDate",
					Comparator = dateEqualComparator
				},
				new SynchronizationColumnMapping {
					SourceColumnName = "ReasonForDismissalId",
					DestinationColumnName = "ReasonForDismissalId"
				}
			};
		}

		public virtual void OnEmployeeCareerDeleted() {
			if (Entity.GetTypedColumnValue<bool>("IsCurrent") || GetIsEmployeeCareerHistoryEmpty()) {
				ClearEmployeeCareerInformation();
			}
		}

		public virtual bool GetIsEmployeeCareerHistoryEmpty() {
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "EmployeeCareer");
			esq.PrimaryQueryColumn.IsAlwaysSelect = true;
			esq.PrimaryQueryColumn.SummaryType = AggregationType.Count;
			IEntitySchemaQueryFilterItem employeeFilter = esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Employee",
				Entity.GetTypedColumnValue<Guid>("EmployeeId"));
			esq.Filters.Add(employeeFilter);
			Entity summaryEntity = esq.GetSummaryEntity(UserConnection);
			return summaryEntity.GetTypedColumnValue<int>(esq.PrimaryQueryColumn.Name) <= 0;
		}

		public virtual void ClearEmployeeCareerInformation() {
			IEntitySynchronizationProvider provider = CreateEntitySynchronizationProvider();
			Entity employee = provider.FindEntity("Employee", new Dictionary<string, object> {
				{"Id", Entity.GetTypedColumnValue<Guid>("EmployeeId")}
			});
			ICollection<SynchronizationColumnMapping> columnMappings = GetSynchronizationColumnMappings();
			foreach(SynchronizationColumnMapping columnMapping in columnMappings) {
				employee.SetColumnValue(columnMapping.DestinationColumnName, null);
			}
			employee.Save();
		}

		public virtual void OnEmployeeCareerSaving() {
			CurrentColumnOldValue = Entity.GetTypedOldColumnValue<bool>("IsCurrent");
		}

		public virtual IEqualComparatorProvider CreateEqualComparatorProvider() {
			return ClassFactory.Get<EqualComparatorProvider>();
		}

		public virtual void ResetOldCareer(Entity career) {
			var isNeedToCheckRequiredFields = GetIsNeedToCheckRequiredFields();
			career.SetColumnValue("IsCurrent", false);
			career.Save(isNeedToCheckRequiredFields);
		}

		public virtual bool GetIsNeedToCheckRequiredFields() {
			return true;
		}

		#endregion

	}

	#endregion

	#region Class: EmployeeCareerEventsProcessSchema

	/// <exclude/>
	public class EmployeeCareerEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public EmployeeCareerEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public EmployeeCareerEventsProcessSchema(EmployeeCareerEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "EmployeeCareer_BaseEventsProcess";
			UId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
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

		protected virtual ProcessSchemaParameter CreateCurrentColumnOldValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c2c504e4-f770-4419-8822-a2ba6487e17b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				Name = @"CurrentColumnOldValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateCurrentColumnOldValueParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess employeecareersavedsubprocess = CreateEmployeeCareerSavedSubProcessEventSubProcess();
			FlowElements.Add(employeecareersavedsubprocess);
			ProcessSchemaEventSubProcess employeecareerdeletedsubprocess = CreateEmployeeCareerDeletedSubProcessEventSubProcess();
			FlowElements.Add(employeecareerdeletedsubprocess);
			ProcessSchemaEventSubProcess employeecareersavingsubprocess = CreateEmployeeCareerSavingSubProcessEventSubProcess();
			FlowElements.Add(employeecareersavingsubprocess);
			ProcessSchemaStartMessageEvent employeecareersavedmessage = CreateEmployeeCareerSavedMessageStartMessageEvent();
			employeecareersavedsubprocess.FlowElements.Add(employeecareersavedmessage);
			ProcessSchemaScriptTask employeecareersavedscripttask = CreateEmployeeCareerSavedScriptTaskScriptTask();
			employeecareersavedsubprocess.FlowElements.Add(employeecareersavedscripttask);
			ProcessSchemaStartMessageEvent employeecareerdeletedmessage = CreateEmployeeCareerDeletedMessageStartMessageEvent();
			employeecareerdeletedsubprocess.FlowElements.Add(employeecareerdeletedmessage);
			ProcessSchemaScriptTask employeecareerdeletedscripttask = CreateEmployeeCareerDeletedScriptTaskScriptTask();
			employeecareerdeletedsubprocess.FlowElements.Add(employeecareerdeletedscripttask);
			ProcessSchemaStartMessageEvent employeecareersavingmessage = CreateEmployeeCareerSavingMessageStartMessageEvent();
			employeecareersavingsubprocess.FlowElements.Add(employeecareersavingmessage);
			ProcessSchemaScriptTask employeecareersavingscripttask = CreateEmployeeCareerSavingScriptTaskScriptTask();
			employeecareersavingsubprocess.FlowElements.Add(employeecareersavingscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("c6126fa6-41b2-4e72-8895-d7432013e864"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d75b9d4b-919f-4059-8248-c2eaca0d02ec"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("404c5511-5c03-4ab4-be43-f1e0491200a1"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("a08cad77-8d66-4867-be42-670c08a4ba45"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9b3a3736-9c12-4f92-bd66-122b12bfc8eb"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e3a8b115-d331-42ef-b770-2a21d38d3746"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("bb6f9c62-0a9d-41d2-80c7-27c9a5261d4e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f374721a-8d5a-4c22-b5c3-87c69e0d9b46"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0002caf6-310f-424b-b68c-60e3ead42a96"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("b68943bf-070e-4872-af6a-46d9899ce3b6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				Name = @"LaneSet1",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("641a38f8-56f5-4df0-98d4-b20797c539c5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b68943bf-070e-4872-af6a-46d9899ce3b6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEmployeeCareerSavedSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEmployeeCareerSavedSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("0a5283f1-f802-4f3a-b5c9-da23cbbcb437"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("641a38f8-56f5-4df0-98d4-b20797c539c5"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				Name = @"EmployeeCareerSavedSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(40, 40),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(240, 129),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEmployeeCareerSavedSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateEmployeeCareerSavedMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d75b9d4b-919f-4059-8248-c2eaca0d02ec"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0a5283f1-f802-4f3a-b5c9-da23cbbcb437"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"EmployeeCareerSaved",
				ModifiedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				Name = @"EmployeeCareerSavedMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(33, 40),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateEmployeeCareerSavedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("404c5511-5c03-4ab4-be43-f1e0491200a1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0a5283f1-f802-4f3a-b5c9-da23cbbcb437"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				Name = @"EmployeeCareerSavedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(131, 26),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,115,205,45,200,201,175,76,77,117,78,44,74,77,45,10,78,44,75,77,209,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,105,8,192,7,37,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEmployeeCareerDeletedSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEmployeeCareerDeletedSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("22905abb-fcd6-49f0-b865-fa64734b607b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("641a38f8-56f5-4df0-98d4-b20797c539c5"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				Name = @"EmployeeCareerDeletedSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(42, 201),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(240, 139),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEmployeeCareerDeletedSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateEmployeeCareerDeletedMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("9b3a3736-9c12-4f92-bd66-122b12bfc8eb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("22905abb-fcd6-49f0-b865-fa64734b607b"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"EmployeeCareerDeleted",
				ModifiedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				Name = @"EmployeeCareerDeletedMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(37, 46),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateEmployeeCareerDeletedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e3a8b115-d331-42ef-b770-2a21d38d3746"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("22905abb-fcd6-49f0-b865-fa64734b607b"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				Name = @"EmployeeCareerDeletedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(129, 32),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,115,205,45,200,201,175,76,77,117,78,44,74,77,45,114,73,205,73,45,73,77,209,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,77,130,162,11,39,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEmployeeCareerSavingSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEmployeeCareerSavingSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b5b8e3db-df14-4fdf-a6be-555b3d642589"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("641a38f8-56f5-4df0-98d4-b20797c539c5"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				Name = @"EmployeeCareerSavingSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(42, 371),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(239, 131),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEmployeeCareerSavingSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateEmployeeCareerSavingMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f374721a-8d5a-4c22-b5c3-87c69e0d9b46"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b5b8e3db-df14-4fdf-a6be-555b3d642589"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"EmployeeCareerSaving",
				ModifiedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				Name = @"EmployeeCareerSavingMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(37, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateEmployeeCareerSavingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0002caf6-310f-424b-b68c-60e3ead42a96"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b5b8e3db-df14-4fdf-a6be-555b3d642589"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				Name = @"EmployeeCareerSavingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(128, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,115,205,45,200,201,175,76,77,117,78,44,74,77,45,10,78,44,203,204,75,215,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,109,78,167,180,38,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateOnEmployeeCareerSavedMethod());
			Methods.Add(CreateSynchronizeEmployeeCareerAndEmployeeMethod());
			Methods.Add(CreateResetOldEmploymentMethod());
			Methods.Add(CreateCreateColumnValuesSynchronizerMethod());
			Methods.Add(CreateCreateEntitySynchronizationProviderMethod());
			Methods.Add(CreateGetSynchronizationColumnMappingsMethod());
			Methods.Add(CreateOnEmployeeCareerDeletedMethod());
			Methods.Add(CreateGetIsEmployeeCareerHistoryEmptyMethod());
			Methods.Add(CreateClearEmployeeCareerInformationMethod());
			Methods.Add(CreateOnEmployeeCareerSavingMethod());
			Methods.Add(CreateCreateEqualComparatorProviderMethod());
			Methods.Add(CreateResetOldCareerMethod());
			Methods.Add(CreateGetIsNeedToCheckRequiredFieldsMethod());
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
				UId = new Guid("a6970989-c480-4079-80a7-eef0ac6a829b"),
				Name = "Terrasoft.Configuration.EntitySynchronization",
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

		protected virtual SchemaMethod CreateOnEmployeeCareerSavedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3fe26249-4b6c-485e-86a4-ad73b3410dd0"),
				Name = "OnEmployeeCareerSaved",
				CreatedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,202,207,207,81,200,44,118,46,45,42,74,205,43,81,176,85,112,205,43,201,44,169,212,115,79,45,9,169,44,72,77,113,206,207,41,205,205,11,75,204,41,77,181,73,2,170,181,211,80,242,132,169,86,210,180,230,202,76,83,208,128,107,215,84,168,230,226,12,74,45,78,45,241,207,73,113,205,45,200,201,175,204,5,10,107,0,213,113,6,87,230,37,103,20,229,231,101,86,165,66,100,82,83,157,19,139,82,83,139,28,243,82,96,2,32,133,181,10,169,57,197,169,10,32,115,21,17,238,82,83,83,128,50,33,14,2,154,15,118,19,216,70,162,141,6,0,143,253,255,132,237,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSynchronizeEmployeeCareerAndEmployeeMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9cdad163-5684-47d5-9698-ec0083d4c2cf"),
				Name = "SynchronizeEmployeeCareerAndEmployee",
				CreatedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,193,78,195,48,16,68,207,228,43,150,156,18,41,202,15,144,230,82,74,149,3,18,82,17,119,19,47,116,145,107,71,182,83,100,170,252,59,118,140,219,168,18,189,121,181,51,207,179,211,109,164,37,235,118,78,246,123,173,36,253,48,75,74,190,104,117,36,142,26,134,244,88,193,90,35,179,120,83,94,148,15,89,20,0,30,6,161,28,162,55,38,70,253,68,146,199,117,145,111,254,246,121,5,18,191,225,145,250,0,98,218,53,198,106,146,159,21,168,247,47,236,109,11,167,236,238,148,119,220,11,163,183,222,162,125,117,3,242,181,18,227,65,190,49,49,98,179,29,137,183,23,170,151,151,83,54,249,56,244,1,197,57,203,253,10,228,40,68,25,152,157,183,11,156,127,109,174,206,137,224,103,54,12,62,72,11,253,114,52,254,32,31,224,150,195,132,26,102,126,138,103,46,114,95,165,89,14,169,215,255,212,51,107,233,168,23,219,185,16,66,83,196,102,170,115,235,213,85,232,0,73,187,122,199,142,24,176,211,47,205,242,248,25,252,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateResetOldEmploymentMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("dc502df6-0a0c-4de4-878a-0cfe880562c7"),
				Name = "ResetOldEmployment",
				CreatedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,146,77,110,195,32,16,133,215,205,41,44,175,108,201,242,5,210,86,178,144,19,121,209,52,77,250,179,30,153,81,140,132,193,25,160,17,183,47,4,55,77,179,206,146,225,241,222,55,204,124,3,101,104,142,217,83,166,240,148,181,202,10,235,247,253,128,35,188,57,36,95,124,24,36,166,149,194,222,10,173,234,107,193,11,40,56,32,85,89,222,142,147,212,30,145,1,33,82,94,46,23,193,178,222,146,24,129,252,217,135,105,233,70,85,119,166,145,39,240,102,143,50,24,134,80,75,14,147,186,225,188,145,50,57,39,181,41,226,237,108,182,18,210,34,153,40,43,226,153,17,130,197,84,253,18,118,216,2,193,136,81,82,164,34,211,227,4,36,140,86,239,126,194,122,163,109,123,116,32,171,216,109,189,211,218,166,168,95,202,25,112,19,76,170,197,67,106,243,255,221,39,200,64,115,39,156,153,229,242,115,249,95,232,26,109,148,240,171,212,199,181,19,252,185,184,168,59,158,151,247,38,233,12,115,68,168,108,94,157,167,18,253,19,81,0,145,105,252,89,127,30,176,9,131,139,81,129,244,86,113,179,47,193,99,126,82,175,52,181,208,15,197,14,13,218,87,201,211,174,148,203,31,127,48,73,36,129,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateColumnValuesSynchronizerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a9fdc241-d2c1-4770-848e-8721f003a4d7"),
				Name = "CreateColumnValuesSynchronizer",
				CreatedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "IColumnValuesSynchronizer"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,112,206,73,44,46,118,75,76,46,201,47,170,212,115,79,45,177,113,206,207,41,205,205,11,75,204,41,77,45,14,174,204,75,206,40,202,207,203,172,74,45,178,211,208,180,6,0,0,87,121,214,52,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateEntitySynchronizationProviderMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("906df7a6-5ad7-433f-a7e1-0cfebaef0108"),
				Name = "CreateEntitySynchronizationProvider",
				CreatedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "IEntitySynchronizationProvider"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,112,206,73,44,46,118,75,76,46,201,47,170,212,115,79,45,177,113,205,43,201,44,169,12,174,204,75,206,40,202,207,203,172,74,44,201,204,207,11,40,202,47,203,76,73,45,178,211,200,75,45,87,112,206,207,43,46,41,42,5,233,113,44,74,47,205,77,205,43,209,80,42,45,78,45,2,74,228,165,38,131,52,40,233,40,132,162,8,104,106,90,3,0,209,45,217,69,114,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSynchronizationColumnMappingsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("95851008-a179-47d6-8c1e-750888ceafc8"),
				Name = "GetSynchronizationColumnMappings",
				CreatedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "ICollection<SynchronizationColumnMapping>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,148,237,74,195,48,20,134,127,183,87,17,246,75,97,120,3,83,65,218,77,38,126,97,245,2,206,218,195,12,164,57,245,36,81,166,236,222,77,55,134,43,141,109,161,236,95,8,207,121,223,39,112,218,229,252,195,129,74,168,172,128,193,18,63,51,125,202,2,89,84,135,195,149,72,24,193,226,63,224,217,249,44,206,54,58,127,103,210,242,27,172,36,157,144,114,165,254,67,69,209,30,247,177,135,134,139,91,180,105,155,24,18,108,44,75,189,238,142,206,66,76,29,206,104,29,107,161,241,75,220,75,99,47,131,101,15,80,85,126,252,90,252,196,81,77,118,65,53,19,101,228,56,199,253,253,35,148,232,109,38,55,121,78,78,219,101,49,153,122,34,69,99,165,62,26,111,99,113,180,157,142,232,123,226,181,127,181,203,253,251,240,77,203,222,226,0,63,210,96,94,86,138,54,136,119,180,234,43,223,35,35,251,22,78,41,31,244,42,173,194,238,186,22,217,88,156,224,66,141,116,203,44,240,110,193,187,197,18,96,68,110,194,13,183,192,87,52,210,44,117,56,212,235,24,61,177,149,255,179,172,118,248,32,189,32,125,98,195,23,4,67,122,65,156,74,83,74,99,64,245,45,121,112,194,91,196,219,217,47,61,27,66,248,130,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnEmployeeCareerDeletedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1e4aeeb4-0a22-489e-926c-4c2c35e5f001"),
				Name = "OnEmployeeCareerDeleted",
				CreatedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,202,49,10,195,48,12,0,192,185,121,133,201,100,47,253,64,75,23,19,90,239,161,187,75,21,48,200,82,144,229,65,52,253,123,178,102,61,174,44,206,79,164,69,237,250,4,157,109,133,111,100,236,149,222,25,59,220,63,204,248,240,99,106,177,139,0,233,24,220,182,185,99,166,54,213,21,217,0,98,22,0,121,149,166,44,118,160,154,15,193,253,134,75,68,200,114,94,137,22,150,154,181,48,249,112,27,254,59,8,118,146,196,126,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsEmployeeCareerHistoryEmptyMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("46f66b0c-1d8b-4c0d-bc52-7e69e6fc21e0"),
				Name = "GetIsEmployeeCareerHistoryEmpty",
				CreatedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,145,75,107,195,48,16,132,207,13,228,63,8,159,108,8,162,247,60,192,24,55,248,208,146,226,62,206,75,188,56,2,61,156,149,212,224,127,95,169,114,139,211,54,71,13,179,51,223,174,62,128,24,218,51,219,50,141,23,86,107,39,220,216,30,79,168,224,217,35,141,249,171,69,170,140,214,120,116,194,104,62,55,60,130,134,30,105,197,178,90,13,210,140,136,21,16,34,101,197,122,185,8,153,252,64,66,1,141,95,65,149,145,94,105,222,216,82,94,96,180,45,202,144,24,90,29,121,188,109,111,189,138,210,203,56,96,240,150,125,79,216,67,4,137,10,175,140,215,46,12,55,127,176,31,132,116,72,141,67,197,112,98,75,82,72,137,85,21,33,184,73,122,23,238,116,0,2,133,225,97,243,36,86,70,13,64,194,78,77,245,217,131,156,45,154,173,150,139,187,212,202,247,232,162,167,75,200,111,32,61,110,246,94,116,187,252,199,222,116,89,241,125,148,148,111,121,217,117,249,53,91,116,164,76,102,211,222,211,43,49,135,158,118,46,255,250,154,56,77,232,60,233,235,233,127,249,132,118,187,252,198,205,159,194,37,10,182,217,178,251,245,39,166,179,35,176,29,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateClearEmployeeCareerInformationMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("16639440-40a9-49e8-a840-4ab3a46f7c55"),
				Name = "ClearEmployeeCareerInformation",
				CreatedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,205,110,131,48,12,199,207,227,41,34,78,32,85,188,192,24,151,182,171,56,172,170,212,105,247,44,241,86,79,193,137,66,232,148,85,188,251,204,24,42,237,129,91,34,255,254,31,118,189,165,128,33,30,35,169,147,183,132,63,50,160,165,131,183,103,212,224,133,155,30,79,98,237,65,6,88,196,179,252,49,25,1,1,141,51,54,2,176,112,242,40,158,145,244,56,206,210,237,255,60,93,9,130,111,177,65,53,24,73,31,203,54,120,164,207,149,176,239,95,160,66,37,46,201,195,37,173,53,131,163,182,216,65,120,141,14,244,218,154,174,161,55,105,58,40,119,29,234,234,234,202,120,222,39,61,215,169,153,50,240,103,94,222,181,30,245,47,210,57,206,171,132,154,127,91,238,205,57,75,138,118,216,246,195,242,85,212,41,91,2,111,157,5,210,93,84,62,172,56,221,171,56,66,152,45,150,221,160,197,6,218,128,52,139,216,203,6,248,130,157,49,92,166,79,174,46,242,12,220,239,23,62,166,89,26,222,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnEmployeeCareerSavingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("290b2bb3-0512-4544-aba6-6e9723f403e9"),
				Name = "OnEmployeeCareerSaving",
				CreatedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,46,45,42,74,205,43,113,206,207,41,205,205,243,207,73,9,75,204,41,77,85,176,85,112,205,43,201,44,169,212,115,79,45,9,169,44,72,77,1,202,64,148,128,229,109,146,242,243,115,236,52,148,60,139,157,33,218,149,52,173,1,230,179,220,190,73,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateEqualComparatorProviderMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f1dd2626-db4b-4251-bf68-5220015a759e"),
				Name = "CreateEqualComparatorProvider",
				CreatedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "IEqualComparatorProvider"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,112,206,73,44,46,118,75,76,46,201,47,170,212,115,79,45,177,113,45,44,77,204,113,206,207,45,72,44,74,4,10,6,20,229,151,101,166,164,22,217,105,104,90,3,0,31,232,5,249,51,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateResetOldCareerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6eb3407e-883e-469f-81ab-dc84dc0b9eae"),
				Name = "ResetOldCareer",
				CreatedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				CreatedInPackageId = new Guid("7e406f3f-0514-4d14-a20b-c3a59a45194f"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9a11efbf-e856-422d-b5ac-0fbd8c0a79d5"),
				Name = "career",
				CreatedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				ModifiedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("7e406f3f-0514-4d14-a20b-c3a59a45194f")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,200,44,246,75,77,77,9,201,119,206,72,77,206,14,74,45,44,205,44,74,77,113,203,76,205,73,41,86,176,85,112,79,45,241,196,173,64,67,211,154,43,57,177,40,53,181,72,47,56,181,196,57,63,167,52,55,47,44,49,167,52,85,67,201,179,216,185,180,168,40,53,175,68,73,71,33,45,49,167,56,21,73,105,98,89,170,6,30,107,53,173,1,75,252,126,47,152,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsNeedToCheckRequiredFieldsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8982380c-da86-41ad-8d34-94f2841aee56"),
				Name = "GetIsNeedToCheckRequiredFields",
				CreatedInSchemaUId = new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"),
				CreatedInPackageId = new Guid("7e406f3f-0514-4d14-a20b-c3a59a45194f"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new EmployeeCareerEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("77d3ed6f-6f4e-4a47-8e67-9090e3aed00b"));
		}

		#endregion

	}

	#endregion


	#region Class: EmployeeCareerEventsProcess

	/// <exclude/>
	public class EmployeeCareerEventsProcess : EmployeeCareer_BaseEventsProcess
	{

		public EmployeeCareerEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

