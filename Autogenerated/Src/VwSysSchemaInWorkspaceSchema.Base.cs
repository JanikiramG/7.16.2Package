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

	#region Class: VwSysSchemaInWorkspaceSchema

	/// <exclude/>
	public class VwSysSchemaInWorkspaceSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public VwSysSchemaInWorkspaceSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwSysSchemaInWorkspaceSchema(VwSysSchemaInWorkspaceSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwSysSchemaInWorkspaceSchema(VwSysSchemaInWorkspaceSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868");
			RealUId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868");
			Name = "VwSysSchemaInWorkspace";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = true;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateCaptionColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("461026e1-dfef-4930-8932-3abfec366e3a")) == null) {
				Columns.Add(CreateUIdColumn());
			}
			if (Columns.FindByUId(new Guid("5480f92c-1fb9-4b5d-b746-bf7ebb287bd2")) == null) {
				Columns.Add(CreateNameColumn());
			}
			if (Columns.FindByUId(new Guid("da117639-d176-4cc9-b5a9-d7e02d010d12")) == null) {
				Columns.Add(CreateManagerNameColumn());
			}
			if (Columns.FindByUId(new Guid("2af92d75-c620-4ba9-8e4e-1313822aa857")) == null) {
				Columns.Add(CreateParentColumn());
			}
			if (Columns.FindByUId(new Guid("fa7aa79d-b5d3-4731-a0c8-e3297eb20044")) == null) {
				Columns.Add(CreateExtendParentColumn());
			}
			if (Columns.FindByUId(new Guid("3f3236b1-ee2b-4f7f-a1bb-8ae954cc9b89")) == null) {
				Columns.Add(CreateIsChangedColumn());
			}
			if (Columns.FindByUId(new Guid("9bd6738c-8e5c-4919-bc71-bc7ee7da7101")) == null) {
				Columns.Add(CreateIsLockedColumn());
			}
			if (Columns.FindByUId(new Guid("750fa50e-a1eb-4364-8543-75a84cd97d4c")) == null) {
				Columns.Add(CreateMetaDataColumn());
			}
			if (Columns.FindByUId(new Guid("214ef9e1-8cf7-4c8c-aedc-03fd21654fb2")) == null) {
				Columns.Add(CreateMetaDataModifiedOnColumn());
			}
			if (Columns.FindByUId(new Guid("6780620a-8dd4-45f4-97c7-9bf42140ead7")) == null) {
				Columns.Add(CreateSysPackageColumn());
			}
			if (Columns.FindByUId(new Guid("ee673217-e64e-4049-91ff-d3d8e10cbf27")) == null) {
				Columns.Add(CreatePackageUIdColumn());
			}
			if (Columns.FindByUId(new Guid("eba0017c-e0bb-4bb3-89e6-e71572081dd7")) == null) {
				Columns.Add(CreateSysWorkspaceColumn());
			}
			if (Columns.FindByUId(new Guid("1ae1e084-b27a-4812-acd7-500e96a84786")) == null) {
				Columns.Add(CreateDescriptionColumn());
			}
			if (Columns.FindByUId(new Guid("bd21a4d8-389f-45dd-99cf-5607e1bba2b8")) == null) {
				Columns.Add(CreateNeedUpdateSourceCodeColumn());
			}
			if (Columns.FindByUId(new Guid("23f7d4b5-c8d9-4d64-9cf9-f4215ebbb511")) == null) {
				Columns.Add(CreateNeedUpdateStructureColumn());
			}
			if (Columns.FindByUId(new Guid("3d9641c0-06f6-4c10-8f30-8ccd9dce7fbe")) == null) {
				Columns.Add(CreateNeedInstallColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("461026e1-dfef-4930-8932-3abfec366e3a"),
				Name = @"UId",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868"),
				ModifiedInSchemaUId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("5480f92c-1fb9-4b5d-b746-bf7ebb287bd2"),
				Name = @"Name",
				CreatedInSchemaUId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868"),
				ModifiedInSchemaUId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Text")) {
				UId = new Guid("c97f8e06-d4ec-418a-9a9e-819c86536812"),
				Name = @"Caption",
				CreatedInSchemaUId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868"),
				ModifiedInSchemaUId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateManagerNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("da117639-d176-4cc9-b5a9-d7e02d010d12"),
				Name = @"ManagerName",
				CreatedInSchemaUId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868"),
				ModifiedInSchemaUId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateParentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("2af92d75-c620-4ba9-8e4e-1313822aa857"),
				Name = @"Parent",
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				IsIndexed = true,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868"),
				ModifiedInSchemaUId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateExtendParentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("fa7aa79d-b5d3-4731-a0c8-e3297eb20044"),
				Name = @"ExtendParent",
				CreatedInSchemaUId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868"),
				ModifiedInSchemaUId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateIsChangedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("3f3236b1-ee2b-4f7f-a1bb-8ae954cc9b89"),
				Name = @"IsChanged",
				CreatedInSchemaUId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868"),
				ModifiedInSchemaUId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateIsLockedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("9bd6738c-8e5c-4919-bc71-bc7ee7da7101"),
				Name = @"IsLocked",
				CreatedInSchemaUId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868"),
				ModifiedInSchemaUId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateMetaDataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Binary")) {
				UId = new Guid("750fa50e-a1eb-4364-8543-75a84cd97d4c"),
				Name = @"MetaData",
				CreatedInSchemaUId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868"),
				ModifiedInSchemaUId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateMetaDataModifiedOnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("214ef9e1-8cf7-4c8c-aedc-03fd21654fb2"),
				Name = @"MetaDataModifiedOn",
				CreatedInSchemaUId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868"),
				ModifiedInSchemaUId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSysPackageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6780620a-8dd4-45f4-97c7-9bf42140ead7"),
				Name = @"SysPackage",
				ReferenceSchemaUId = new Guid("ca400a85-ec48-4b42-8e50-271929d27871"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868"),
				ModifiedInSchemaUId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreatePackageUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("ee673217-e64e-4049-91ff-d3d8e10cbf27"),
				Name = @"PackageUId",
				CreatedInSchemaUId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868"),
				ModifiedInSchemaUId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSysWorkspaceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("eba0017c-e0bb-4bb3-89e6-e71572081dd7"),
				Name = @"SysWorkspace",
				ReferenceSchemaUId = new Guid("7f9653ec-2e91-4aaa-a065-7b1d46edd292"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868"),
				ModifiedInSchemaUId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateDescriptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("1ae1e084-b27a-4812-acd7-500e96a84786"),
				Name = @"Description",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868"),
				ModifiedInSchemaUId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateNeedUpdateSourceCodeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("bd21a4d8-389f-45dd-99cf-5607e1bba2b8"),
				Name = @"NeedUpdateSourceCode",
				CreatedInSchemaUId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868"),
				ModifiedInSchemaUId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868"),
				CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7")
			};
		}

		protected virtual EntitySchemaColumn CreateNeedUpdateStructureColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("23f7d4b5-c8d9-4d64-9cf9-f4215ebbb511"),
				Name = @"NeedUpdateStructure",
				CreatedInSchemaUId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868"),
				ModifiedInSchemaUId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868"),
				CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7")
			};
		}

		protected virtual EntitySchemaColumn CreateNeedInstallColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("3d9641c0-06f6-4c10-8f30-8ccd9dce7fbe"),
				Name = @"NeedInstall",
				CreatedInSchemaUId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868"),
				ModifiedInSchemaUId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868"),
				CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwSysSchemaInWorkspaceEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwSysSchemaInWorkspaceEventsProcessSchema() {
			var schema = new VwSysSchemaInWorkspaceEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwSysSchemaInWorkspace(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwSysSchemaInWorkspace_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwSysSchemaInWorkspaceSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwSysSchemaInWorkspaceSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4fe60977-c711-48b2-8499-1cebbecf7868"));
		}

		#endregion

	}

	#endregion

	#region Class: VwSysSchemaInWorkspace

	/// <summary>
	/// Workspace item (view).
	/// </summary>
	public class VwSysSchemaInWorkspace : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public VwSysSchemaInWorkspace(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwSysSchemaInWorkspace";
		}

		public VwSysSchemaInWorkspace(VwSysSchemaInWorkspace source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// UId.
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
		/// Manager name.
		/// </summary>
		public string ManagerName {
			get {
				return GetTypedColumnValue<string>("ManagerName");
			}
			set {
				SetColumnValue("ManagerName", value);
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

		/// <summary>
		/// Modified.
		/// </summary>
		public bool IsChanged {
			get {
				return GetTypedColumnValue<bool>("IsChanged");
			}
			set {
				SetColumnValue("IsChanged", value);
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
		/// Metadata changed.
		/// </summary>
		public DateTime MetaDataModifiedOn {
			get {
				return GetTypedColumnValue<DateTime>("MetaDataModifiedOn");
			}
			set {
				SetColumnValue("MetaDataModifiedOn", value);
			}
		}

		/// <exclude/>
		public Guid SysPackageId {
			get {
				return GetTypedColumnValue<Guid>("SysPackageId");
			}
			set {
				SetColumnValue("SysPackageId", value);
				_sysPackage = null;
			}
		}

		/// <exclude/>
		public string SysPackageName {
			get {
				return GetTypedColumnValue<string>("SysPackageName");
			}
			set {
				SetColumnValue("SysPackageName", value);
				if (_sysPackage != null) {
					_sysPackage.Name = value;
				}
			}
		}

		private SysPackage _sysPackage;
		/// <summary>
		/// Package.
		/// </summary>
		public SysPackage SysPackage {
			get {
				return _sysPackage ??
					(_sysPackage = LookupColumnEntities.GetEntity("SysPackage") as SysPackage);
			}
		}

		/// <summary>
		/// Package Id.
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

		/// <summary>
		/// Source code update required.
		/// </summary>
		public bool NeedUpdateSourceCode {
			get {
				return GetTypedColumnValue<bool>("NeedUpdateSourceCode");
			}
			set {
				SetColumnValue("NeedUpdateSourceCode", value);
			}
		}

		/// <summary>
		/// Update required: Table in database.
		/// </summary>
		public bool NeedUpdateStructure {
			get {
				return GetTypedColumnValue<bool>("NeedUpdateStructure");
			}
			set {
				SetColumnValue("NeedUpdateStructure", value);
			}
		}

		/// <summary>
		/// Needs installing.
		/// </summary>
		public bool NeedInstall {
			get {
				return GetTypedColumnValue<bool>("NeedInstall");
			}
			set {
				SetColumnValue("NeedInstall", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwSysSchemaInWorkspace_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwSysSchemaInWorkspaceDeleted", e);
			Deleting += (s, e) => ThrowEvent("VwSysSchemaInWorkspaceDeleting", e);
			Inserted += (s, e) => ThrowEvent("VwSysSchemaInWorkspaceInserted", e);
			Inserting += (s, e) => ThrowEvent("VwSysSchemaInWorkspaceInserting", e);
			Saved += (s, e) => ThrowEvent("VwSysSchemaInWorkspaceSaved", e);
			Saving += (s, e) => ThrowEvent("VwSysSchemaInWorkspaceSaving", e);
			Validating += (s, e) => ThrowEvent("VwSysSchemaInWorkspaceValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwSysSchemaInWorkspace(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwSysSchemaInWorkspace_BaseEventsProcess

	/// <exclude/>
	public partial class VwSysSchemaInWorkspace_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : VwSysSchemaInWorkspace
	{

		public VwSysSchemaInWorkspace_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwSysSchemaInWorkspace_BaseEventsProcess";
			SchemaUId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("4fe60977-c711-48b2-8499-1cebbecf7868");
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

	#region Class: VwSysSchemaInWorkspace_BaseEventsProcess

	/// <exclude/>
	public class VwSysSchemaInWorkspace_BaseEventsProcess : VwSysSchemaInWorkspace_BaseEventsProcess<VwSysSchemaInWorkspace>
	{

		public VwSysSchemaInWorkspace_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwSysSchemaInWorkspace_BaseEventsProcess

	public partial class VwSysSchemaInWorkspace_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: VwSysSchemaInWorkspaceEventsProcessSchema

	/// <exclude/>
	public class VwSysSchemaInWorkspaceEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public VwSysSchemaInWorkspaceEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwSysSchemaInWorkspaceEventsProcessSchema(VwSysSchemaInWorkspaceEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwSysSchemaInWorkspace_BaseEventsProcess";
			UId = new Guid("69f4bd29-1b08-4929-8807-a7deaa2a7889");
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
			return new VwSysSchemaInWorkspaceEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("69f4bd29-1b08-4929-8807-a7deaa2a7889"));
		}

		#endregion

	}

	#endregion


	#region Class: VwSysSchemaInWorkspaceEventsProcess

	/// <exclude/>
	public class VwSysSchemaInWorkspaceEventsProcess : VwSysSchemaInWorkspace_BaseEventsProcess
	{

		public VwSysSchemaInWorkspaceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

