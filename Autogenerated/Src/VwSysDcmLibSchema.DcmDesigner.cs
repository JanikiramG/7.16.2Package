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

	#region Class: VwSysDcmLib_DcmDesigner_TerrasoftSchema

	/// <exclude/>
	public class VwSysDcmLib_DcmDesigner_TerrasoftSchema : Terrasoft.Core.Entities.EntitySchema
	{

		#region Constructors: Public

		public VwSysDcmLib_DcmDesigner_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwSysDcmLib_DcmDesigner_TerrasoftSchema(VwSysDcmLib_DcmDesigner_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwSysDcmLib_DcmDesigner_TerrasoftSchema(VwSysDcmLib_DcmDesigner_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a");
			RealUId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a");
			Name = "VwSysDcmLib_DcmDesigner_Terrasoft";
			ParentSchemaUId = new Guid("1b56b061-4e91-4974-9038-df8340e534f2");
			ExtendParent = false;
			CreatedInPackageId = new Guid("ef448226-2103-49b1-9f99-b8b1a4265794");
			IsDBView = true;
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

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateCaptionColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeCreatedOnColumn() {
			base.InitializeCreatedOnColumn();
			CreatedOnColumn = CreateCreatedOnColumn();
			if (Columns.FindByUId(CreatedOnColumn.UId) == null) {
				Columns.Add(CreatedOnColumn);
			}
		}

		protected override void InitializeCreatedByColumn() {
			base.InitializeCreatedByColumn();
			CreatedByColumn = CreateCreatedByColumn();
			if (Columns.FindByUId(CreatedByColumn.UId) == null) {
				Columns.Add(CreatedByColumn);
			}
		}

		protected override void InitializeModifiedOnColumn() {
			base.InitializeModifiedOnColumn();
			ModifiedOnColumn = CreateModifiedOnColumn();
			if (Columns.FindByUId(ModifiedOnColumn.UId) == null) {
				Columns.Add(ModifiedOnColumn);
			}
		}

		protected override void InitializeModifiedByColumn() {
			base.InitializeModifiedByColumn();
			ModifiedByColumn = CreateModifiedByColumn();
			if (Columns.FindByUId(ModifiedByColumn.UId) == null) {
				Columns.Add(ModifiedByColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("2eab78fa-7ebd-4ac7-9b2d-e96d92503851")) == null) {
				Columns.Add(CreateNameColumn());
			}
			if (Columns.FindByUId(new Guid("938c231c-de1c-447c-95bf-5c135976a55b")) == null) {
				Columns.Add(CreatePackageUIdColumn());
			}
			if (Columns.FindByUId(new Guid("e2292273-d7a1-4e76-8afb-46467e8942d1")) == null) {
				Columns.Add(CreateSysWorkspaceColumn());
			}
			if (Columns.FindByUId(new Guid("b52da5b4-8de9-442c-b55b-9db6504c0ade")) == null) {
				Columns.Add(CreateStageColumnUIdColumn());
			}
			if (Columns.FindByUId(new Guid("c613316d-3d42-4f0d-b7d8-719da3b6f92b")) == null) {
				Columns.Add(CreateEntitySchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("5d7148b1-326c-4b54-bda3-f287d6ce2b23")) == null) {
				Columns.Add(CreateIsActiveColumn());
			}
			if (Columns.FindByUId(new Guid("f0a960e9-6853-4e63-b137-40afbc665f2c")) == null) {
				Columns.Add(CreateUIdColumn());
			}
			if (Columns.FindByUId(new Guid("482fd914-b97f-4310-9a19-fb81d82fd581")) == null) {
				Columns.Add(CreateFiltersColumn());
			}
			if (Columns.FindByUId(new Guid("40084b18-2ec4-4192-8f7c-d79c8cc2f07e")) == null) {
				Columns.Add(CreateParentColumn());
			}
			if (Columns.FindByUId(new Guid("fe987912-1849-4c69-b2ab-0333c8af8524")) == null) {
				Columns.Add(CreateIsLockedColumn());
			}
			if (Columns.FindByUId(new Guid("47ae9c04-c735-4cb0-bb3b-e6bb66b46163")) == null) {
				Columns.Add(CreateExtendParentColumn());
			}
			if (Columns.FindByUId(new Guid("20534757-35e6-4d40-9974-279ffe36668f")) == null) {
				Columns.Add(CreatePackageColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("f24251f7-35a6-420b-9b87-5a17bb96ba31"),
				Name = @"Id",
				CreatedInSchemaUId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a"),
				ModifiedInSchemaUId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a"),
				CreatedInPackageId = new Guid("ef448226-2103-49b1-9f99-b8b1a4265794")
			};
		}

		protected virtual EntitySchemaColumn CreateCreatedOnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("89505988-362b-49bd-9952-526a02ad2157"),
				Name = @"CreatedOn",
				CreatedInSchemaUId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a"),
				ModifiedInSchemaUId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a"),
				CreatedInPackageId = new Guid("ef448226-2103-49b1-9f99-b8b1a4265794")
			};
		}

		protected virtual EntitySchemaColumn CreateCreatedByColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("5240a6f9-3c2b-4c9d-8d8d-50689743d3ab"),
				Name = @"CreatedBy",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a"),
				ModifiedInSchemaUId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a"),
				CreatedInPackageId = new Guid("ef448226-2103-49b1-9f99-b8b1a4265794")
			};
		}

		protected virtual EntitySchemaColumn CreateModifiedOnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("465e6579-2f28-4741-a3d6-8d8161f63c7d"),
				Name = @"ModifiedOn",
				CreatedInSchemaUId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a"),
				ModifiedInSchemaUId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a"),
				CreatedInPackageId = new Guid("ef448226-2103-49b1-9f99-b8b1a4265794")
			};
		}

		protected virtual EntitySchemaColumn CreateModifiedByColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("74a3f96e-a94e-4149-87aa-73273168bc02"),
				Name = @"ModifiedBy",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a"),
				ModifiedInSchemaUId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a"),
				CreatedInPackageId = new Guid("ef448226-2103-49b1-9f99-b8b1a4265794")
			};
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("2eab78fa-7ebd-4ac7-9b2d-e96d92503851"),
				Name = @"Name",
				CreatedInSchemaUId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a"),
				ModifiedInSchemaUId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a"),
				CreatedInPackageId = new Guid("ef448226-2103-49b1-9f99-b8b1a4265794")
			};
		}

		protected virtual EntitySchemaColumn CreateCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("e8054d3e-0a4c-47e8-bf03-b42abc17088b"),
				Name = @"Caption",
				CreatedInSchemaUId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a"),
				ModifiedInSchemaUId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a"),
				CreatedInPackageId = new Guid("ef448226-2103-49b1-9f99-b8b1a4265794"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreatePackageUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("938c231c-de1c-447c-95bf-5c135976a55b"),
				Name = @"PackageUId",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a"),
				ModifiedInSchemaUId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a"),
				CreatedInPackageId = new Guid("ef448226-2103-49b1-9f99-b8b1a4265794")
			};
		}

		protected virtual EntitySchemaColumn CreateSysWorkspaceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e2292273-d7a1-4e76-8afb-46467e8942d1"),
				Name = @"SysWorkspace",
				ReferenceSchemaUId = new Guid("7f9653ec-2e91-4aaa-a065-7b1d46edd292"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a"),
				ModifiedInSchemaUId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a"),
				CreatedInPackageId = new Guid("ef448226-2103-49b1-9f99-b8b1a4265794")
			};
		}

		protected virtual EntitySchemaColumn CreateStageColumnUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("b52da5b4-8de9-442c-b55b-9db6504c0ade"),
				Name = @"StageColumnUId",
				CreatedInSchemaUId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a"),
				ModifiedInSchemaUId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a"),
				CreatedInPackageId = new Guid("ef448226-2103-49b1-9f99-b8b1a4265794")
			};
		}

		protected virtual EntitySchemaColumn CreateEntitySchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("c613316d-3d42-4f0d-b7d8-719da3b6f92b"),
				Name = @"EntitySchemaUId",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a"),
				ModifiedInSchemaUId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a"),
				CreatedInPackageId = new Guid("ef448226-2103-49b1-9f99-b8b1a4265794")
			};
		}

		protected virtual EntitySchemaColumn CreateIsActiveColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("5d7148b1-326c-4b54-bda3-f287d6ce2b23"),
				Name = @"IsActive",
				CreatedInSchemaUId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a"),
				ModifiedInSchemaUId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a"),
				CreatedInPackageId = new Guid("ef448226-2103-49b1-9f99-b8b1a4265794")
			};
		}

		protected virtual EntitySchemaColumn CreateUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("f0a960e9-6853-4e63-b137-40afbc665f2c"),
				Name = @"UId",
				CreatedInSchemaUId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a"),
				ModifiedInSchemaUId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a"),
				CreatedInPackageId = new Guid("ef448226-2103-49b1-9f99-b8b1a4265794")
			};
		}

		protected virtual EntitySchemaColumn CreateFiltersColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("482fd914-b97f-4310-9a19-fb81d82fd581"),
				Name = @"Filters",
				CreatedInSchemaUId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a"),
				ModifiedInSchemaUId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a"),
				CreatedInPackageId = new Guid("60220118-8883-44e1-afa4-8845f944d697")
			};
		}

		protected virtual EntitySchemaColumn CreateParentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("40084b18-2ec4-4192-8f7c-d79c8cc2f07e"),
				Name = @"Parent",
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				IsIndexed = true,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a"),
				ModifiedInSchemaUId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a"),
				CreatedInPackageId = new Guid("60220118-8883-44e1-afa4-8845f944d697")
			};
		}

		protected virtual EntitySchemaColumn CreateIsLockedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("fe987912-1849-4c69-b2ab-0333c8af8524"),
				Name = @"IsLocked",
				CreatedInSchemaUId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a"),
				ModifiedInSchemaUId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a"),
				CreatedInPackageId = new Guid("60220118-8883-44e1-afa4-8845f944d697")
			};
		}

		protected virtual EntitySchemaColumn CreateExtendParentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("47ae9c04-c735-4cb0-bb3b-e6bb66b46163"),
				Name = @"ExtendParent",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a"),
				ModifiedInSchemaUId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a"),
				CreatedInPackageId = new Guid("60220118-8883-44e1-afa4-8845f944d697")
			};
		}

		protected virtual EntitySchemaColumn CreatePackageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("20534757-35e6-4d40-9974-279ffe36668f"),
				Name = @"Package",
				ReferenceSchemaUId = new Guid("ca400a85-ec48-4b42-8e50-271929d27871"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a"),
				ModifiedInSchemaUId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a"),
				CreatedInPackageId = new Guid("7533f56f-3117-4576-81a1-adfb1d3a9acf")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwSysDcmLib_DcmDesigner_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwSysDcmLib_DcmDesigner_TerrasoftEventsProcessSchema() {
			var schema = new VwSysDcmLib_DcmDesigner_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwSysDcmLib_DcmDesigner_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwSysDcmLib_DcmDesignerEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwSysDcmLib_DcmDesigner_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwSysDcmLib_DcmDesigner_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a"));
		}

		#endregion

	}

	#endregion

	#region Class: VwSysDcmLib_DcmDesigner_Terrasoft

	/// <summary>
	/// Dcm library (view).
	/// </summary>
	public class VwSysDcmLib_DcmDesigner_Terrasoft : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public VwSysDcmLib_DcmDesigner_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwSysDcmLib_DcmDesigner_Terrasoft";
		}

		public VwSysDcmLib_DcmDesigner_Terrasoft(VwSysDcmLib_DcmDesigner_Terrasoft source)
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

		/// <summary>
		/// Created on.
		/// </summary>
		public DateTime CreatedOn {
			get {
				return GetTypedColumnValue<DateTime>("CreatedOn");
			}
			set {
				SetColumnValue("CreatedOn", value);
			}
		}

		/// <exclude/>
		public Guid CreatedById {
			get {
				return GetTypedColumnValue<Guid>("CreatedById");
			}
			set {
				SetColumnValue("CreatedById", value);
				_createdBy = null;
			}
		}

		/// <exclude/>
		public string CreatedByName {
			get {
				return GetTypedColumnValue<string>("CreatedByName");
			}
			set {
				SetColumnValue("CreatedByName", value);
				if (_createdBy != null) {
					_createdBy.Name = value;
				}
			}
		}

		private Contact _createdBy;
		/// <summary>
		/// Created by.
		/// </summary>
		public Contact CreatedBy {
			get {
				return _createdBy ??
					(_createdBy = LookupColumnEntities.GetEntity("CreatedBy") as Contact);
			}
		}

		/// <summary>
		/// Modified on.
		/// </summary>
		public DateTime ModifiedOn {
			get {
				return GetTypedColumnValue<DateTime>("ModifiedOn");
			}
			set {
				SetColumnValue("ModifiedOn", value);
			}
		}

		/// <exclude/>
		public Guid ModifiedById {
			get {
				return GetTypedColumnValue<Guid>("ModifiedById");
			}
			set {
				SetColumnValue("ModifiedById", value);
				_modifiedBy = null;
			}
		}

		/// <exclude/>
		public string ModifiedByName {
			get {
				return GetTypedColumnValue<string>("ModifiedByName");
			}
			set {
				SetColumnValue("ModifiedByName", value);
				if (_modifiedBy != null) {
					_modifiedBy.Name = value;
				}
			}
		}

		private Contact _modifiedBy;
		/// <summary>
		/// Modified by.
		/// </summary>
		public Contact ModifiedBy {
			get {
				return _modifiedBy ??
					(_modifiedBy = LookupColumnEntities.GetEntity("ModifiedBy") as Contact);
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

		/// <summary>
		/// Title.
		/// </summary>
		public string Caption {
			get {
				return GetTypedColumnValue<string>("Caption");
			}
			set {
				SetColumnValue("Caption", value);
			}
		}

		/// <summary>
		/// Package identifier.
		/// </summary>
		public Guid PackageUId {
			get {
				return GetTypedColumnValue<Guid>("PackageUId");
			}
			set {
				SetColumnValue("PackageUId", value);
			}
		}

		/// <exclude/>
		public Guid SysWorkspaceId {
			get {
				return GetTypedColumnValue<Guid>("SysWorkspaceId");
			}
			set {
				SetColumnValue("SysWorkspaceId", value);
				_sysWorkspace = null;
			}
		}

		/// <exclude/>
		public string SysWorkspaceName {
			get {
				return GetTypedColumnValue<string>("SysWorkspaceName");
			}
			set {
				SetColumnValue("SysWorkspaceName", value);
				if (_sysWorkspace != null) {
					_sysWorkspace.Name = value;
				}
			}
		}

		private SysWorkspace _sysWorkspace;
		/// <summary>
		/// Workspace.
		/// </summary>
		public SysWorkspace SysWorkspace {
			get {
				return _sysWorkspace ??
					(_sysWorkspace = LookupColumnEntities.GetEntity("SysWorkspace") as SysWorkspace);
			}
		}

		/// <summary>
		/// Stage column.
		/// </summary>
		public Guid StageColumnUId {
			get {
				return GetTypedColumnValue<Guid>("StageColumnUId");
			}
			set {
				SetColumnValue("StageColumnUId", value);
			}
		}

		/// <summary>
		/// Entity schema.
		/// </summary>
		public Guid EntitySchemaUId {
			get {
				return GetTypedColumnValue<Guid>("EntitySchemaUId");
			}
			set {
				SetColumnValue("EntitySchemaUId", value);
			}
		}

		/// <summary>
		/// Active.
		/// </summary>
		/// <remarks>
		/// Is Case Active.
		/// </remarks>
		public bool IsActive {
			get {
				return GetTypedColumnValue<bool>("IsActive");
			}
			set {
				SetColumnValue("IsActive", value);
			}
		}

		/// <summary>
		/// Dcm schema unique identifier.
		/// </summary>
		public Guid UId {
			get {
				return GetTypedColumnValue<Guid>("UId");
			}
			set {
				SetColumnValue("UId", value);
			}
		}

		/// <summary>
		/// Filters.
		/// </summary>
		public string Filters {
			get {
				return GetTypedColumnValue<string>("Filters");
			}
			set {
				SetColumnValue("Filters", value);
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
		public string ParentCaption {
			get {
				return GetTypedColumnValue<string>("ParentCaption");
			}
			set {
				SetColumnValue("ParentCaption", value);
				if (_parent != null) {
					_parent.Caption = value;
				}
			}
		}

		private SysSchema _parent;
		/// <summary>
		/// Parent.
		/// </summary>
		public SysSchema Parent {
			get {
				return _parent ??
					(_parent = LookupColumnEntities.GetEntity("Parent") as SysSchema);
			}
		}

		/// <summary>
		/// Locked.
		/// </summary>
		public bool IsLocked {
			get {
				return GetTypedColumnValue<bool>("IsLocked");
			}
			set {
				SetColumnValue("IsLocked", value);
			}
		}

		/// <summary>
		/// Extends parent.
		/// </summary>
		public bool ExtendParent {
			get {
				return GetTypedColumnValue<bool>("ExtendParent");
			}
			set {
				SetColumnValue("ExtendParent", value);
			}
		}

		/// <exclude/>
		public Guid PackageId {
			get {
				return GetTypedColumnValue<Guid>("PackageId");
			}
			set {
				SetColumnValue("PackageId", value);
				_package = null;
			}
		}

		/// <exclude/>
		public string PackageName {
			get {
				return GetTypedColumnValue<string>("PackageName");
			}
			set {
				SetColumnValue("PackageName", value);
				if (_package != null) {
					_package.Name = value;
				}
			}
		}

		private SysPackage _package;
		/// <summary>
		/// Package.
		/// </summary>
		public SysPackage Package {
			get {
				return _package ??
					(_package = LookupColumnEntities.GetEntity("Package") as SysPackage);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwSysDcmLib_DcmDesignerEventsProcess(UserConnection);
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
			return new VwSysDcmLib_DcmDesigner_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwSysDcmLib_DcmDesignerEventsProcess

	/// <exclude/>
	public partial class VwSysDcmLib_DcmDesignerEventsProcess<TEntity> : Terrasoft.Core.Process.EmbeddedProcess where TEntity : VwSysDcmLib_DcmDesigner_Terrasoft
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

		public VwSysDcmLib_DcmDesignerEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwSysDcmLib_DcmDesignerEventsProcess";
			SchemaUId = new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ab972a77-ca14-4dd4-9d90-eaaae8b1197a");
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

	#region Class: VwSysDcmLib_DcmDesignerEventsProcess

	/// <exclude/>
	public class VwSysDcmLib_DcmDesignerEventsProcess : VwSysDcmLib_DcmDesignerEventsProcess<VwSysDcmLib_DcmDesigner_Terrasoft>
	{

		public VwSysDcmLib_DcmDesignerEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwSysDcmLib_DcmDesignerEventsProcess

	public partial class VwSysDcmLib_DcmDesignerEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: VwSysDcmLib_DcmDesigner_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class VwSysDcmLib_DcmDesigner_TerrasoftEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public VwSysDcmLib_DcmDesigner_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwSysDcmLib_DcmDesigner_TerrasoftEventsProcessSchema(VwSysDcmLib_DcmDesigner_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwSysDcmLib_DcmDesignerEventsProcess";
			UId = new Guid("01a84b9b-c7ff-4516-a610-03115274662f");
			CreatedInPackageId = new Guid("ef448226-2103-49b1-9f99-b8b1a4265794");
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
			return new VwSysDcmLib_DcmDesigner_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("01a84b9b-c7ff-4516-a610-03115274662f"));
		}

		#endregion

	}

	#endregion

}

