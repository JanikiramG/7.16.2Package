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

	#region Class: QualifyStatusDecouplingSchema

	/// <exclude/>
	public class QualifyStatusDecouplingSchema : Terrasoft.Core.Entities.EntitySchema
	{

		#region Constructors: Public

		public QualifyStatusDecouplingSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public QualifyStatusDecouplingSchema(QualifyStatusDecouplingSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public QualifyStatusDecouplingSchema(QualifyStatusDecouplingSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("496464c1-5536-4ad6-8f76-3fbfd5afcf14");
			RealUId = new Guid("496464c1-5536-4ad6-8f76-3fbfd5afcf14");
			Name = "QualifyStatusDecoupling";
			ParentSchemaUId = new Guid("1b56b061-4e91-4974-9038-df8340e534f2");
			ExtendParent = false;
			CreatedInPackageId = new Guid("720d23f3-8251-42b3-a7b6-da9abd6ef059");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryColumn() {
			base.InitializePrimaryColumn();
			PrimaryColumn = CreateIdColumn();
			if (Columns.FindByUId(PrimaryColumn.UId) == null) {
				Columns.Add(PrimaryColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("5c371f91-9b0b-40d8-a00c-19f97f5e1907")) == null) {
				Columns.Add(CreateCurrentStatusColumn());
			}
			if (Columns.FindByUId(new Guid("2ab8861e-dd23-476c-ba05-a46b1c174bcb")) == null) {
				Columns.Add(CreateAvailableStatusColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("ebfd6fcb-7e83-4ad2-a143-3a6a744514f6"),
				Name = @"Id",
				CreatedInSchemaUId = new Guid("496464c1-5536-4ad6-8f76-3fbfd5afcf14"),
				ModifiedInSchemaUId = new Guid("496464c1-5536-4ad6-8f76-3fbfd5afcf14"),
				CreatedInPackageId = new Guid("720d23f3-8251-42b3-a7b6-da9abd6ef059"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"AutoGuid")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateCurrentStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("5c371f91-9b0b-40d8-a00c-19f97f5e1907"),
				Name = @"CurrentStatus",
				ReferenceSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("496464c1-5536-4ad6-8f76-3fbfd5afcf14"),
				ModifiedInSchemaUId = new Guid("496464c1-5536-4ad6-8f76-3fbfd5afcf14"),
				CreatedInPackageId = new Guid("720d23f3-8251-42b3-a7b6-da9abd6ef059")
			};
		}

		protected virtual EntitySchemaColumn CreateAvailableStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("2ab8861e-dd23-476c-ba05-a46b1c174bcb"),
				Name = @"AvailableStatus",
				ReferenceSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("496464c1-5536-4ad6-8f76-3fbfd5afcf14"),
				ModifiedInSchemaUId = new Guid("496464c1-5536-4ad6-8f76-3fbfd5afcf14"),
				CreatedInPackageId = new Guid("720d23f3-8251-42b3-a7b6-da9abd6ef059")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateQualifyStatusDecouplingEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateQualifyStatusDecouplingEventsProcessSchema() {
			var schema = new QualifyStatusDecouplingEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new QualifyStatusDecoupling(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new QualifyStatusDecoupling_CoreLeadEventsProcess(userConnection);
		}

		public override object Clone() {
			return new QualifyStatusDecouplingSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new QualifyStatusDecouplingSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("496464c1-5536-4ad6-8f76-3fbfd5afcf14"));
		}

		#endregion

	}

	#endregion

	#region Class: QualifyStatusDecoupling

	/// <summary>
	/// Allowed lead stage transitions.
	/// </summary>
	public class QualifyStatusDecoupling : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public QualifyStatusDecoupling(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "QualifyStatusDecoupling";
		}

		public QualifyStatusDecoupling(QualifyStatusDecoupling source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Id.
		/// </summary>
		public Guid Id {
			get {
				return GetTypedColumnValue<Guid>("Id");
			}
			set {
				SetColumnValue("Id", value);
			}
		}

		/// <exclude/>
		public Guid CurrentStatusId {
			get {
				return GetTypedColumnValue<Guid>("CurrentStatusId");
			}
			set {
				SetColumnValue("CurrentStatusId", value);
				_currentStatus = null;
			}
		}

		/// <exclude/>
		public string CurrentStatusName {
			get {
				return GetTypedColumnValue<string>("CurrentStatusName");
			}
			set {
				SetColumnValue("CurrentStatusName", value);
				if (_currentStatus != null) {
					_currentStatus.Name = value;
				}
			}
		}

		private QualifyStatus _currentStatus;
		/// <summary>
		/// Transition from.
		/// </summary>
		public QualifyStatus CurrentStatus {
			get {
				return _currentStatus ??
					(_currentStatus = LookupColumnEntities.GetEntity("CurrentStatus") as QualifyStatus);
			}
		}

		/// <exclude/>
		public Guid AvailableStatusId {
			get {
				return GetTypedColumnValue<Guid>("AvailableStatusId");
			}
			set {
				SetColumnValue("AvailableStatusId", value);
				_availableStatus = null;
			}
		}

		/// <exclude/>
		public string AvailableStatusName {
			get {
				return GetTypedColumnValue<string>("AvailableStatusName");
			}
			set {
				SetColumnValue("AvailableStatusName", value);
				if (_availableStatus != null) {
					_availableStatus.Name = value;
				}
			}
		}

		private QualifyStatus _availableStatus;
		/// <summary>
		/// Transition to.
		/// </summary>
		public QualifyStatus AvailableStatus {
			get {
				return _availableStatus ??
					(_availableStatus = LookupColumnEntities.GetEntity("AvailableStatus") as QualifyStatus);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new QualifyStatusDecoupling_CoreLeadEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new QualifyStatusDecoupling(this);
		}

		#endregion

	}

	#endregion

	#region Class: QualifyStatusDecoupling_CoreLeadEventsProcess

	/// <exclude/>
	public partial class QualifyStatusDecoupling_CoreLeadEventsProcess<TEntity> : Terrasoft.Core.Process.EmbeddedProcess where TEntity : QualifyStatusDecoupling
	{

		private TEntity _entity;
		public TEntity Entity {
			get {
				return _entity;
			}
			set {
				_entity = value;
			}
		}

		public QualifyStatusDecoupling_CoreLeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "QualifyStatusDecoupling_CoreLeadEventsProcess";
			SchemaUId = new Guid("496464c1-5536-4ad6-8f76-3fbfd5afcf14");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("496464c1-5536-4ad6-8f76-3fbfd5afcf14");
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

	#region Class: QualifyStatusDecoupling_CoreLeadEventsProcess

	/// <exclude/>
	public class QualifyStatusDecoupling_CoreLeadEventsProcess : QualifyStatusDecoupling_CoreLeadEventsProcess<QualifyStatusDecoupling>
	{

		public QualifyStatusDecoupling_CoreLeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: QualifyStatusDecoupling_CoreLeadEventsProcess

	public partial class QualifyStatusDecoupling_CoreLeadEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: QualifyStatusDecouplingEventsProcessSchema

	/// <exclude/>
	public class QualifyStatusDecouplingEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public QualifyStatusDecouplingEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public QualifyStatusDecouplingEventsProcessSchema(QualifyStatusDecouplingEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "QualifyStatusDecoupling_CoreLeadEventsProcess";
			UId = new Guid("2cc6d7ba-d3a1-45b9-b8ad-9d731658e261");
			CreatedInPackageId = new Guid("720d23f3-8251-42b3-a7b6-da9abd6ef059");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
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
			return new QualifyStatusDecouplingEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2cc6d7ba-d3a1-45b9-b8ad-9d731658e261"));
		}

		#endregion

	}

	#endregion


	#region Class: QualifyStatusDecouplingEventsProcess

	/// <exclude/>
	public class QualifyStatusDecouplingEventsProcess : QualifyStatusDecoupling_CoreLeadEventsProcess
	{

		public QualifyStatusDecouplingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

