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

	#region Class: Lead_CoreLead_TerrasoftSchema

	/// <exclude/>
	public class Lead_CoreLead_TerrasoftSchema : Terrasoft.Configuration.Lead_MLLeadScoring_TerrasoftSchema
	{

		#region Constructors: Public

		public Lead_CoreLead_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Lead_CoreLead_TerrasoftSchema(Lead_CoreLead_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Lead_CoreLead_TerrasoftSchema(Lead_CoreLead_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIMLLeadModifiedOnIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("e0ee791a-7d9e-4ef7-8653-eb995a3f6d74");
			index.Name = "IMLLeadModifiedOn";
			index.CreatedInSchemaUId = new Guid("d9947110-c8c4-49c9-8bc1-344ec81a0258");
			index.ModifiedInSchemaUId = new Guid("d9947110-c8c4-49c9-8bc1-344ec81a0258");
			index.CreatedInPackageId = new Guid("296a0a1e-e6de-4406-bbd8-86a62e047ff0");
			EntitySchemaIndexColumn modifiedOnIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("aaa8ad09-ce33-4f85-9c6f-46d679ad61ee"),
				ColumnUId = new Guid("9928edec-4272-425a-93bb-48743fee4b04"),
				CreatedInSchemaUId = new Guid("d9947110-c8c4-49c9-8bc1-344ec81a0258"),
				ModifiedInSchemaUId = new Guid("d9947110-c8c4-49c9-8bc1-344ec81a0258"),
				CreatedInPackageId = new Guid("296a0a1e-e6de-4406-bbd8-86a62e047ff0"),
				OrderDirection = OrderDirectionStrict.Descending
			};
			index.Columns.Add(modifiedOnIndexColumn);
			return index;
		}

		private EntitySchemaIndex CreateIDX_LeadNameIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("bf3f62f3-5d38-4031-a648-58b036f8f19d");
			index.Name = "IDX_LeadName";
			index.CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			index.ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			index.CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06");
			EntitySchemaIndexColumn leadNameIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("2c3ed9bd-ff44-447d-b4af-c6a4e4090a5a"),
				ColumnUId = new Guid("d06ba9af-faf5-4741-a672-e154ae561a94"),
				CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(leadNameIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("94590c6d-2e61-422b-ab3b-033c95aa663b");
			Name = "Lead_CoreLead_Terrasoft";
			ParentSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			ExtendParent = true;
			CreatedInPackageId = new Guid("bd9461a8-7d2e-4f51-8bb4-ed05869380df");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("a40a64fa-a0ea-40e6-9476-a59c1dfbb93f")) == null) {
				Columns.Add(CreateOpportunityDepartmentColumn());
			}
			if (Columns.FindByUId(new Guid("7dc3ed3f-ce06-4a75-8d38-9e0badcece6e")) == null) {
				Columns.Add(CreateIdentificationPassedColumn());
			}
			if (Columns.FindByUId(new Guid("ad34e929-02a6-4baf-88b5-4efbf982c577")) == null) {
				Columns.Add(CreateStartLeadManagementProcessColumn());
			}
			if (Columns.FindByUId(new Guid("bca817e3-756d-4098-8804-859940310d68")) == null) {
				Columns.Add(CreateSaleTypeColumn());
			}
			if (Columns.FindByUId(new Guid("7c4d10e3-5ace-4362-8b9c-73b858ba9fec")) == null) {
				Columns.Add(CreateScoreColumn());
			}
			if (Columns.FindByUId(new Guid("d46a1b66-17a7-4603-b1ce-49313701da31")) == null) {
				Columns.Add(CreateQualificationPassedColumn());
			}
		}

		protected override EntitySchemaColumn CreateStatusColumn() {
			EntitySchemaColumn column = base.CreateStatusColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("94590c6d-2e61-422b-ab3b-033c95aa663b");
			column.CreatedInPackageId = new Guid("bd9461a8-7d2e-4f51-8bb4-ed05869380df");
			return column;
		}

		protected override EntitySchemaColumn CreateRemindToOwnerColumn() {
			EntitySchemaColumn column = base.CreateRemindToOwnerColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("94590c6d-2e61-422b-ab3b-033c95aa663b");
			column.CreatedInPackageId = new Guid("bd9461a8-7d2e-4f51-8bb4-ed05869380df");
			return column;
		}

		protected virtual EntitySchemaColumn CreateOpportunityDepartmentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a40a64fa-a0ea-40e6-9476-a59c1dfbb93f"),
				Name = @"OpportunityDepartment",
				ReferenceSchemaUId = new Guid("5d8456b4-15e0-4de5-b0e5-afb10f6795c0"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("94590c6d-2e61-422b-ab3b-033c95aa663b"),
				ModifiedInSchemaUId = new Guid("94590c6d-2e61-422b-ab3b-033c95aa663b"),
				CreatedInPackageId = new Guid("bd9461a8-7d2e-4f51-8bb4-ed05869380df")
			};
		}

		protected virtual EntitySchemaColumn CreateIdentificationPassedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("7dc3ed3f-ce06-4a75-8d38-9e0badcece6e"),
				Name = @"IdentificationPassed",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("94590c6d-2e61-422b-ab3b-033c95aa663b"),
				ModifiedInSchemaUId = new Guid("94590c6d-2e61-422b-ab3b-033c95aa663b"),
				CreatedInPackageId = new Guid("04f45b48-2ba7-4a99-b9aa-9685581b63b8")
			};
		}

		protected virtual EntitySchemaColumn CreateStartLeadManagementProcessColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("ad34e929-02a6-4baf-88b5-4efbf982c577"),
				Name = @"StartLeadManagementProcess",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("94590c6d-2e61-422b-ab3b-033c95aa663b"),
				ModifiedInSchemaUId = new Guid("94590c6d-2e61-422b-ab3b-033c95aa663b"),
				CreatedInPackageId = new Guid("72a81799-379a-47fd-98a2-863474ed2379"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"False"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateSaleTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("bca817e3-756d-4098-8804-859940310d68"),
				Name = @"SaleType",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("94590c6d-2e61-422b-ab3b-033c95aa663b"),
				ModifiedInSchemaUId = new Guid("94590c6d-2e61-422b-ab3b-033c95aa663b"),
				CreatedInPackageId = new Guid("00276668-9718-4e94-8d54-1a9582a96ad4")
			};
		}

		protected virtual EntitySchemaColumn CreateScoreColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("7c4d10e3-5ace-4362-8b9c-73b858ba9fec"),
				Name = @"Score",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("94590c6d-2e61-422b-ab3b-033c95aa663b"),
				ModifiedInSchemaUId = new Guid("94590c6d-2e61-422b-ab3b-033c95aa663b"),
				CreatedInPackageId = new Guid("4e68d131-e539-48a2-90eb-6b4a80171550")
			};
		}

		protected virtual EntitySchemaColumn CreateQualificationPassedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("d46a1b66-17a7-4603-b1ce-49313701da31"),
				Name = @"QualificationPassed",
				CreatedInSchemaUId = new Guid("94590c6d-2e61-422b-ab3b-033c95aa663b"),
				ModifiedInSchemaUId = new Guid("94590c6d-2e61-422b-ab3b-033c95aa663b"),
				CreatedInPackageId = new Guid("720d23f3-8251-42b3-a7b6-da9abd6ef059")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIMLLeadModifiedOnIndex());
			Indexes.Add(CreateIDX_LeadNameIndex());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateLead_CoreLead_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateLead_CoreLead_TerrasoftEventsProcessSchema() {
			var schema = new Lead_CoreLead_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Lead_CoreLead_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Lead_CoreLeadEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Lead_CoreLead_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Lead_CoreLead_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("94590c6d-2e61-422b-ab3b-033c95aa663b"));
		}

		#endregion

	}

	#endregion

	#region Class: Lead_CoreLead_Terrasoft

	/// <summary>
	/// Lead.
	/// </summary>
	public class Lead_CoreLead_Terrasoft : Terrasoft.Configuration.Lead_MLLeadScoring_Terrasoft
	{

		#region Constructors: Public

		public Lead_CoreLead_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Lead_CoreLead_Terrasoft";
		}

		public Lead_CoreLead_Terrasoft(Lead_CoreLead_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid OpportunityDepartmentId {
			get {
				return GetTypedColumnValue<Guid>("OpportunityDepartmentId");
			}
			set {
				SetColumnValue("OpportunityDepartmentId", value);
				_opportunityDepartment = null;
			}
		}

		/// <exclude/>
		public string OpportunityDepartmentName {
			get {
				return GetTypedColumnValue<string>("OpportunityDepartmentName");
			}
			set {
				SetColumnValue("OpportunityDepartmentName", value);
				if (_opportunityDepartment != null) {
					_opportunityDepartment.Name = value;
				}
			}
		}

		private OpportunityDepartment _opportunityDepartment;
		/// <summary>
		/// Sales division.
		/// </summary>
		public OpportunityDepartment OpportunityDepartment {
			get {
				return _opportunityDepartment ??
					(_opportunityDepartment = LookupColumnEntities.GetEntity("OpportunityDepartment") as OpportunityDepartment);
			}
		}

		/// <summary>
		/// Identification passed.
		/// </summary>
		public bool IdentificationPassed {
			get {
				return GetTypedColumnValue<bool>("IdentificationPassed");
			}
			set {
				SetColumnValue("IdentificationPassed", value);
			}
		}

		/// <summary>
		/// Run process while lead generation.
		/// </summary>
		public bool StartLeadManagementProcess {
			get {
				return GetTypedColumnValue<bool>("StartLeadManagementProcess");
			}
			set {
				SetColumnValue("StartLeadManagementProcess", value);
			}
		}

		/// <summary>
		/// Type of sale.
		/// </summary>
		public string SaleType {
			get {
				return GetTypedColumnValue<string>("SaleType");
			}
			set {
				SetColumnValue("SaleType", value);
			}
		}

		/// <summary>
		/// Score.
		/// </summary>
		public Decimal Score {
			get {
				return GetTypedColumnValue<Decimal>("Score");
			}
			set {
				SetColumnValue("Score", value);
			}
		}

		/// <summary>
		/// Qualification passed.
		/// </summary>
		public bool QualificationPassed {
			get {
				return GetTypedColumnValue<bool>("QualificationPassed");
			}
			set {
				SetColumnValue("QualificationPassed", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Lead_CoreLeadEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Lead_CoreLead_TerrasoftDeleted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Lead_CoreLead_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Lead_CoreLeadEventsProcess

	/// <exclude/>
	public partial class Lead_CoreLeadEventsProcess<TEntity> : Terrasoft.Configuration.Lead_MLLeadScoringEventsProcess<TEntity> where TEntity : Lead_CoreLead_Terrasoft
	{

		public Lead_CoreLeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Lead_CoreLeadEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("94590c6d-2e61-422b-ab3b-033c95aa663b");
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

	#region Class: Lead_CoreLeadEventsProcess

	/// <exclude/>
	public class Lead_CoreLeadEventsProcess : Lead_CoreLeadEventsProcess<Lead_CoreLead_Terrasoft>
	{

		public Lead_CoreLeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Lead_CoreLeadEventsProcess

	public partial class Lead_CoreLeadEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void LeadInserted() {
			base.LeadInserted();
			if (CanStartQualificationProcess()) {
				StartQualificationProcess();
			}
		}

		public override void LeadSavingMethod() {
			base.LeadSavingMethod();
			DisqualifyLeadOnFinalStage();
		}

		public virtual void StartQualificationProcess() {
			Guid leadManagementProcessUId = (Guid)Terrasoft.Core.Configuration.SysSettings.GetValue(
				UserConnection, "LeadManagementProcess");
			ProcessSchema schema;
			if (leadManagementProcessUId.IsEmpty()) {
				schema = UserConnection.ProcessSchemaManager.GetInstanceByName("LeadManagement");
			} else {
				schema = UserConnection.ProcessSchemaManager.GetInstanceByUId(leadManagementProcessUId);
			}
			bool canUseFlowEngine = ProcessSchemaManager.GetCanUseFlowEngine(UserConnection, schema);
			if(canUseFlowEngine) {
				var flowEngine = new FlowEngine(UserConnection);
				var param = new Dictionary<string, string>();
				param["LeadId"] = Entity.Id.ToString();
				flowEngine.RunProcess(schema, param);
			} else {
				Process process = schema.CreateProcess(UserConnection);
				process.SetPropertyValue("LeadId", Entity.Id);
				process.Execute(UserConnection);
			}
		}

		public virtual void DisqualifyLeadOnFinalStage() {
			if (!Entity.GetIsColumnValueLoaded("QualifyStatusId")) {
				return;
			}
			Guid qualifyStatusId = Entity.GetTypedColumnValue<Guid>("QualifyStatusId");
			Select isStatusFinalSelect = new Select(UserConnection)
				.Column("IsFinal")
				.From("QualifyStatus")
				.Where("Id")
				.IsEqual(Column.Parameter(qualifyStatusId)) as Select;
			bool isStatusFinal = isStatusFinalSelect.ExecuteScalar<bool>();
			if (!isStatusFinal) {
				return;
			}
			Guid qualificationProcessId = Entity.GetTypedColumnValue<Guid>("QualificationProcessId");
			if (qualificationProcessId.IsEmpty()) {
				return;
			}
			Process process = UserConnection.ProcessEngine.FindProcessByUId(qualificationProcessId.ToString(), true);
			if (process == null) {
				return;
			}
			if (process.Status == ProcessStatus.Running) {
				process.CancelExecution();
				Entity.SetColumnValue("QualificationProcessId", null);
			};
		}

		public virtual bool CanStartQualificationProcess() {
			if (Entity.GetIsColumnValueLoaded("QualifyStatusId")) {
				Guid qualifyStatusId = Entity.GetTypedColumnValue<Guid>("QualifyStatusId");
				if (qualifyStatusId == LeadConsts.QualificationUId) {
					return false;
				}
			}
			bool startLeadManagementProcess = true;
			if (Entity.IsColumnValueLoaded("StartLeadManagementProcess")) {
				startLeadManagementProcess = Entity.GetTypedColumnValue<bool>("StartLeadManagementProcess");
			}
			bool useLeadManagementProcess = (bool)Terrasoft.Core.Configuration.SysSettings.GetValue(
				UserConnection, "UseProcessLeadManagement");
			if (!useLeadManagementProcess || !startLeadManagementProcess) {
				return false;
			}
			return true;
		}

		#endregion

	}

	#endregion

	#region Class: Lead_CoreLead_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Lead_CoreLead_TerrasoftEventsProcessSchema : Terrasoft.Configuration.Lead_MLLeadScoring_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public Lead_CoreLead_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Lead_CoreLead_TerrasoftEventsProcessSchema(Lead_CoreLead_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Lead_CoreLeadEventsProcess";
			UId = new Guid("065de26f-5ffd-4bc4-b862-ab37d85ac483");
			CreatedInPackageId = new Guid("bd9461a8-7d2e-4f51-8bb4-ed05869380df");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("60550bfb-e424-448d-bc5b-ccf6184f7414");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaCoreLeadLaneSet2 = CreateCoreLeadLaneSet2LaneSet();
			LaneSets.Add(schemaCoreLeadLaneSet2);
			ProcessSchemaLane schemaCoreLeadLane1 = CreateCoreLeadLane1Lane();
			schemaCoreLeadLaneSet2.Lanes.Add(schemaCoreLeadLane1);
		}

		protected virtual ProcessSchemaLaneSet CreateCoreLeadLaneSet2LaneSet() {
			ProcessSchemaLaneSet schemaCoreLeadLaneSet2 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("69efa3f7-0184-4988-8d0c-806588c85789"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("38bd35a8-0658-4dc3-a7c6-33f62f27b0ce"),
				CreatedInPackageId = new Guid("92323026-06de-4fcc-b310-6de28b5b7964"),
				CreatedInSchemaUId = new Guid("065de26f-5ffd-4bc4-b862-ab37d85ac483"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("065de26f-5ffd-4bc4-b862-ab37d85ac483"),
				Name = @"CoreLeadLaneSet2",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaCoreLeadLaneSet2;
		}

		protected virtual ProcessSchemaLane CreateCoreLeadLane1Lane() {
			ProcessSchemaLane schemaCoreLeadLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("41d4c7f8-f970-494c-b97d-cd59aeba5d2f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("69efa3f7-0184-4988-8d0c-806588c85789"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("92323026-06de-4fcc-b310-6de28b5b7964"),
				CreatedInSchemaUId = new Guid("065de26f-5ffd-4bc4-b862-ab37d85ac483"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("065de26f-5ffd-4bc4-b862-ab37d85ac483"),
				Name = @"CoreLeadLane1",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaCoreLeadLane1;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateStartQualificationProcessMethod());
			Methods.Add(CreateDisqualifyLeadOnFinalStageMethod());
			Methods.Add(CreateCanStartQualificationProcessMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("bd9461a8-7d2e-4f51-8bb4-ed05869380df")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("bd9461a8-7d2e-4f51-8bb4-ed05869380df")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("bd9461a8-7d2e-4f51-8bb4-ed05869380df")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("bd9461a8-7d2e-4f51-8bb4-ed05869380df")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("bd9461a8-7d2e-4f51-8bb4-ed05869380df")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("bd9461a8-7d2e-4f51-8bb4-ed05869380df")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("bd9461a8-7d2e-4f51-8bb4-ed05869380df")
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

		protected override SchemaMethod CreateLeadInsertedMethod() {
			SchemaMethod method = base.CreateLeadInsertedMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,243,73,77,76,241,204,43,78,45,42,73,77,209,208,180,230,202,76,83,208,112,78,204,11,46,73,44,42,9,44,77,204,201,76,203,76,78,44,201,204,207,11,40,202,79,78,45,46,214,208,212,84,168,230,226,196,35,111,205,85,11,0,67,18,27,40,90,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateLeadSavingMethodMethod() {
			SchemaMethod method = base.CreateLeadSavingMethodMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,243,73,77,76,9,78,44,203,204,75,247,77,45,201,200,79,209,208,180,230,114,201,44,46,44,77,204,201,76,171,4,201,250,231,185,101,230,37,230,4,151,36,166,167,2,101,1,195,81,12,130,54,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateStartQualificationProcessMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ffde5f09-7152-416c-8b3a-4eabcf812fb0"),
				Name = "StartQualificationProcess",
				CreatedInSchemaUId = new Guid("065de26f-5ffd-4bc4-b862-ab37d85ac483"),
				CreatedInPackageId = new Guid("fc539133-b8d9-4984-b7be-a58958c7add2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,146,193,78,131,64,16,134,207,229,41,54,61,45,73,179,47,80,235,193,138,13,137,26,35,173,23,227,97,132,1,55,129,89,178,187,88,137,233,187,187,44,52,181,88,78,94,24,146,253,230,255,255,153,221,77,35,51,86,34,100,15,64,80,96,133,100,159,180,74,209,152,93,156,177,21,227,27,7,132,91,212,26,140,202,173,88,43,141,238,67,185,44,26,13,86,42,18,73,107,18,180,86,82,97,196,6,237,11,148,13,242,96,182,51,168,29,72,152,118,212,130,205,239,47,185,204,195,101,48,252,38,233,7,86,192,140,47,203,64,230,140,79,5,19,177,137,170,218,182,60,12,217,119,48,235,91,92,218,115,79,113,38,220,235,232,46,98,76,198,2,165,120,211,62,66,133,124,148,172,139,116,96,88,26,252,159,182,203,57,57,64,103,17,188,43,85,178,20,200,41,223,149,106,31,81,33,9,157,211,148,244,122,132,242,241,138,251,172,97,183,59,62,214,245,139,250,4,205,242,223,86,132,123,54,41,232,132,124,71,13,26,170,1,190,149,254,8,116,123,101,172,118,119,238,92,125,189,230,29,238,209,87,191,208,56,155,191,185,166,136,172,180,173,112,119,182,85,137,39,61,120,74,33,158,27,26,38,230,253,0,139,222,241,236,26,6,130,213,67,93,13,195,138,181,70,176,120,20,248,59,192,208,32,220,19,117,80,141,218,182,253,11,61,134,92,156,34,254,230,163,47,76,27,123,97,37,135,31,215,134,216,119,51,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateDisqualifyLeadOnFinalStageMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("37076b38-3b2b-48af-9a7e-e29c575228e9"),
				Name = "DisqualifyLeadOnFinalStage",
				CreatedInSchemaUId = new Guid("065de26f-5ffd-4bc4-b862-ab37d85ac483"),
				CreatedInPackageId = new Guid("fc539133-b8d9-4984-b7be-a58958c7add2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,81,203,110,194,48,16,60,147,175,112,115,114,36,228,31,8,112,40,10,40,82,15,180,129,246,236,198,11,181,228,216,212,15,181,81,213,127,175,141,221,150,68,112,224,148,120,52,59,59,59,195,247,8,223,85,210,114,219,147,53,216,218,44,149,112,157,124,166,194,193,131,162,12,24,206,31,29,21,124,223,55,150,90,103,106,150,23,5,250,202,38,26,172,211,178,204,190,179,181,227,12,189,15,73,104,142,254,85,183,253,17,216,153,240,44,76,44,46,8,151,89,3,2,90,139,184,137,224,138,75,42,18,54,71,18,62,80,124,224,157,1,189,84,82,250,127,174,100,145,77,72,212,199,121,29,135,242,128,173,180,234,70,107,78,248,203,27,104,240,84,118,122,213,166,10,238,113,84,32,27,170,105,7,22,52,30,221,228,239,166,38,25,40,179,87,165,196,208,167,119,120,193,55,169,62,161,117,22,154,150,10,170,103,97,108,129,253,165,60,36,63,224,95,143,149,183,52,156,185,209,170,5,115,91,186,227,209,60,173,190,44,28,178,232,142,182,199,227,142,19,3,29,211,119,142,134,13,144,68,168,228,129,75,32,254,30,150,144,251,126,87,179,107,235,182,170,177,154,203,3,46,166,200,106,7,201,220,223,22,223,185,19,227,96,206,24,36,198,23,136,73,52,2,228,201,73,233,117,79,147,191,220,37,149,45,136,88,135,119,17,74,152,164,24,27,176,103,9,94,205,110,26,237,120,19,101,246,3,210,22,99,51,58,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCanStartQualificationProcessMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e0fa3ea7-74e5-4e5c-8073-aab93d7fffb7"),
				Name = "CanStartQualificationProcess",
				CreatedInSchemaUId = new Guid("065de26f-5ffd-4bc4-b862-ab37d85ac483"),
				CreatedInPackageId = new Guid("fc539133-b8d9-4984-b7be-a58958c7add2"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,145,193,106,195,48,12,134,207,241,83,184,57,165,48,242,2,93,123,41,163,4,58,216,72,187,187,22,43,193,144,218,155,37,31,194,154,119,159,157,101,116,97,77,46,6,219,210,247,255,250,165,107,153,61,25,214,220,229,7,228,130,246,182,245,23,243,6,173,199,163,5,133,42,75,95,61,180,186,238,74,6,246,84,168,116,189,150,95,34,57,120,173,228,231,244,75,110,229,141,117,234,62,80,253,193,61,198,142,221,29,220,70,36,58,184,248,199,218,202,35,66,32,24,98,202,127,186,116,5,172,173,57,23,106,240,144,56,100,239,140,172,161,37,12,152,94,244,226,221,218,86,18,131,227,216,253,12,6,26,188,160,225,23,103,43,36,10,22,217,249,80,172,111,131,223,157,186,156,69,140,1,44,106,44,196,16,13,238,150,249,155,223,57,60,225,156,66,22,11,214,39,116,14,200,214,156,239,173,195,112,152,90,55,222,13,41,229,101,71,37,50,107,211,80,116,50,200,103,34,57,19,186,80,104,176,138,85,15,50,13,15,35,119,42,22,141,196,152,86,179,54,174,87,185,154,207,97,136,105,186,162,94,140,247,97,9,223,173,26,204,251,125,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Lead_CoreLead_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("065de26f-5ffd-4bc4-b862-ab37d85ac483"));
		}

		#endregion

	}

	#endregion

}

