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

	#region Class: AccountOrganizationChartSchema

	/// <exclude/>
	public class AccountOrganizationChartSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public AccountOrganizationChartSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AccountOrganizationChartSchema(AccountOrganizationChartSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AccountOrganizationChartSchema(AccountOrganizationChartSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fa59be08-4036-420d-87ab-288d21ae2ed4");
			RealUId = new Guid("fa59be08-4036-420d-87ab-288d21ae2ed4");
			Name = "AccountOrganizationChart";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
			RightSchemaName = @"SysAccountOrgChartRight";
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateCustomDepartmentNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeHierarchyColumn() {
			base.InitializeHierarchyColumn();
			HierarchyColumn = CreateParentColumn();
			if (Columns.FindByUId(HierarchyColumn.UId) == null) {
				Columns.Add(HierarchyColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("ad047738-5932-4583-a0cf-20fac6df579a")) == null) {
				Columns.Add(CreateAccountColumn());
			}
			if (Columns.FindByUId(new Guid("22add15e-3272-43bd-8e2d-9c2bca1724dc")) == null) {
				Columns.Add(CreateDepartmentColumn());
			}
			if (Columns.FindByUId(new Guid("d0c2ab3b-4608-4e73-9912-28836d2546af")) == null) {
				Columns.Add(CreateManagerColumn());
			}
			if (Columns.FindByUId(new Guid("c9b351ce-90b8-407f-985c-aa416f25df04")) == null) {
				Columns.Add(CreateDescriptionColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ad047738-5932-4583-a0cf-20fac6df579a"),
				Name = @"Account",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsCascade = true,
				CreatedInSchemaUId = new Guid("fa59be08-4036-420d-87ab-288d21ae2ed4"),
				ModifiedInSchemaUId = new Guid("fa59be08-4036-420d-87ab-288d21ae2ed4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateCustomDepartmentNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("5964887b-fe21-4176-ac49-0a7eac8aeb71"),
				Name = @"CustomDepartmentName",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("fa59be08-4036-420d-87ab-288d21ae2ed4"),
				ModifiedInSchemaUId = new Guid("fa59be08-4036-420d-87ab-288d21ae2ed4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateDepartmentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("22add15e-3272-43bd-8e2d-9c2bca1724dc"),
				Name = @"Department",
				ReferenceSchemaUId = new Guid("7a269220-a657-4b5f-bfb4-ebe596e419d8"),
				CreatedInSchemaUId = new Guid("fa59be08-4036-420d-87ab-288d21ae2ed4"),
				ModifiedInSchemaUId = new Guid("fa59be08-4036-420d-87ab-288d21ae2ed4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateManagerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d0c2ab3b-4608-4e73-9912-28836d2546af"),
				Name = @"Manager",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInSchemaUId = new Guid("fa59be08-4036-420d-87ab-288d21ae2ed4"),
				ModifiedInSchemaUId = new Guid("fa59be08-4036-420d-87ab-288d21ae2ed4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateDescriptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("c9b351ce-90b8-407f-985c-aa416f25df04"),
				Name = @"Description",
				CreatedInSchemaUId = new Guid("fa59be08-4036-420d-87ab-288d21ae2ed4"),
				ModifiedInSchemaUId = new Guid("fa59be08-4036-420d-87ab-288d21ae2ed4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateParentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d5a9b3b4-04ef-46b7-b58e-3922daada1ec"),
				Name = @"Parent",
				ReferenceSchemaUId = new Guid("fa59be08-4036-420d-87ab-288d21ae2ed4"),
				CreatedInSchemaUId = new Guid("fa59be08-4036-420d-87ab-288d21ae2ed4"),
				ModifiedInSchemaUId = new Guid("fa59be08-4036-420d-87ab-288d21ae2ed4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAccountOrganizationChartEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateAccountOrganizationChartEventsProcessSchema() {
			var schema = new AccountOrganizationChartEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new AccountOrganizationChart(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AccountOrganizationChart_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AccountOrganizationChartSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AccountOrganizationChartSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fa59be08-4036-420d-87ab-288d21ae2ed4"));
		}

		#endregion

	}

	#endregion

	#region Class: AccountOrganizationChart

	/// <summary>
	/// Account organizational structure.
	/// </summary>
	public class AccountOrganizationChart : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public AccountOrganizationChart(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AccountOrganizationChart";
		}

		public AccountOrganizationChart(AccountOrganizationChart source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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

		/// <summary>
		/// Division.
		/// </summary>
		public string CustomDepartmentName {
			get {
				return GetTypedColumnValue<string>("CustomDepartmentName");
			}
			set {
				SetColumnValue("CustomDepartmentName", value);
			}
		}

		/// <exclude/>
		public Guid DepartmentId {
			get {
				return GetTypedColumnValue<Guid>("DepartmentId");
			}
			set {
				SetColumnValue("DepartmentId", value);
				_department = null;
			}
		}

		/// <exclude/>
		public string DepartmentName {
			get {
				return GetTypedColumnValue<string>("DepartmentName");
			}
			set {
				SetColumnValue("DepartmentName", value);
				if (_department != null) {
					_department.Name = value;
				}
			}
		}

		private Department _department;
		/// <summary>
		/// Department.
		/// </summary>
		public Department Department {
			get {
				return _department ??
					(_department = LookupColumnEntities.GetEntity("Department") as Department);
			}
		}

		/// <exclude/>
		public Guid ManagerId {
			get {
				return GetTypedColumnValue<Guid>("ManagerId");
			}
			set {
				SetColumnValue("ManagerId", value);
				_manager = null;
			}
		}

		/// <exclude/>
		public string ManagerName {
			get {
				return GetTypedColumnValue<string>("ManagerName");
			}
			set {
				SetColumnValue("ManagerName", value);
				if (_manager != null) {
					_manager.Name = value;
				}
			}
		}

		private Contact _manager;
		/// <summary>
		/// Manager.
		/// </summary>
		public Contact Manager {
			get {
				return _manager ??
					(_manager = LookupColumnEntities.GetEntity("Manager") as Contact);
			}
		}

		/// <summary>
		/// Description.
		/// </summary>
		public string Description {
			get {
				return GetTypedColumnValue<string>("Description");
			}
			set {
				SetColumnValue("Description", value);
			}
		}

		/// <exclude/>
		public Guid ParentId {
			get {
				return GetTypedColumnValue<Guid>("ParentId");
			}
			set {
				SetColumnValue("ParentId", value);
				_parent = null;
			}
		}

		/// <exclude/>
		public string ParentCustomDepartmentName {
			get {
				return GetTypedColumnValue<string>("ParentCustomDepartmentName");
			}
			set {
				SetColumnValue("ParentCustomDepartmentName", value);
				if (_parent != null) {
					_parent.CustomDepartmentName = value;
				}
			}
		}

		private AccountOrganizationChart _parent;
		/// <summary>
		/// Part of.
		/// </summary>
		public AccountOrganizationChart Parent {
			get {
				return _parent ??
					(_parent = LookupColumnEntities.GetEntity("Parent") as AccountOrganizationChart);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AccountOrganizationChart_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AccountOrganizationChartDeleted", e);
			Deleting += (s, e) => ThrowEvent("AccountOrganizationChartDeleting", e);
			Inserted += (s, e) => ThrowEvent("AccountOrganizationChartInserted", e);
			Inserting += (s, e) => ThrowEvent("AccountOrganizationChartInserting", e);
			Saved += (s, e) => ThrowEvent("AccountOrganizationChartSaved", e);
			Saving += (s, e) => ThrowEvent("AccountOrganizationChartSaving", e);
			Validating += (s, e) => ThrowEvent("AccountOrganizationChartValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AccountOrganizationChart(this);
		}

		#endregion

	}

	#endregion

	#region Class: AccountOrganizationChart_BaseEventsProcess

	/// <exclude/>
	public partial class AccountOrganizationChart_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : AccountOrganizationChart
	{

		public AccountOrganizationChart_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AccountOrganizationChart_BaseEventsProcess";
			SchemaUId = new Guid("fa59be08-4036-420d-87ab-288d21ae2ed4");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("fa59be08-4036-420d-87ab-288d21ae2ed4");
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

	#region Class: AccountOrganizationChart_BaseEventsProcess

	/// <exclude/>
	public class AccountOrganizationChart_BaseEventsProcess : AccountOrganizationChart_BaseEventsProcess<AccountOrganizationChart>
	{

		public AccountOrganizationChart_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AccountOrganizationChart_BaseEventsProcess

	public partial class AccountOrganizationChart_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: AccountOrganizationChartEventsProcessSchema

	/// <exclude/>
	public class AccountOrganizationChartEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public AccountOrganizationChartEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AccountOrganizationChartEventsProcessSchema(AccountOrganizationChartEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AccountOrganizationChart_BaseEventsProcess";
			UId = new Guid("1b0c843a-6084-4d2e-9077-b8d56f11c67d");
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
			ProcessSchemaLaneSet schemaLaneSet389 = CreateLaneSet389LaneSet();
			LaneSets.Add(schemaLaneSet389);
			ProcessSchemaLane schemaLane1187 = CreateLane1187Lane();
			schemaLaneSet389.Lanes.Add(schemaLane1187);
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet389LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet389 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("2bcad560-b357-4663-a3cc-bcccc3067e2a"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1b0c843a-6084-4d2e-9077-b8d56f11c67d"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("1b0c843a-6084-4d2e-9077-b8d56f11c67d"),
				Name = @"LaneSet389",
				Position = new Point(5, 5),
				Size = new Size(520, 465),
				UseBackgroundMode = false
			};
			return schemaLaneSet389;
		}

		protected virtual ProcessSchemaLane CreateLane1187Lane() {
			ProcessSchemaLane schemaLane1187 = new ProcessSchemaLane(this) {
				UId = new Guid("2a177b89-8183-4f5f-9246-db3f0f9caa8d"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("2bcad560-b357-4663-a3cc-bcccc3067e2a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("1b0c843a-6084-4d2e-9077-b8d56f11c67d"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("1b0c843a-6084-4d2e-9077-b8d56f11c67d"),
				Name = @"Lane1187",
				Position = new Point(29, 0),
				Size = new Size(491, 465),
				UseBackgroundMode = false
			};
			return schemaLane1187;
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
			return new AccountOrganizationChartEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1b0c843a-6084-4d2e-9077-b8d56f11c67d"));
		}

		#endregion

	}

	#endregion


	#region Class: AccountOrganizationChartEventsProcess

	/// <exclude/>
	public class AccountOrganizationChartEventsProcess : AccountOrganizationChart_BaseEventsProcess
	{

		public AccountOrganizationChartEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

