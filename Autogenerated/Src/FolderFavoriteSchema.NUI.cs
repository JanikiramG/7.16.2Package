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

	#region Class: FolderFavoriteSchema

	/// <exclude/>
	public class FolderFavoriteSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public FolderFavoriteSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public FolderFavoriteSchema(FolderFavoriteSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public FolderFavoriteSchema(FolderFavoriteSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0ecb85d4-228f-4ccb-9ba5-716b6a4335bf");
			RealUId = new Guid("0ecb85d4-228f-4ccb-9ba5-716b6a4335bf");
			Name = "FolderFavorite";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("43f796d0-2535-4ae5-88b4-0c05eb1809e5");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("10e0123a-4cfa-41fc-82be-81c4bd5b8dc6")) == null) {
				Columns.Add(CreateSysAdminUnitColumn());
			}
			if (Columns.FindByUId(new Guid("4d24b8ff-9dda-4d8b-8c05-4b74b36ec731")) == null) {
				Columns.Add(CreateFolderIdColumn());
			}
			if (Columns.FindByUId(new Guid("b4acab41-c8b0-4e52-a535-93985f9d9af2")) == null) {
				Columns.Add(CreateFolderEntitySchemaUIdColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("0ecb85d4-228f-4ccb-9ba5-716b6a4335bf");
			column.CreatedInPackageId = new Guid("43f796d0-2535-4ae5-88b4-0c05eb1809e5");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("0ecb85d4-228f-4ccb-9ba5-716b6a4335bf");
			column.CreatedInPackageId = new Guid("43f796d0-2535-4ae5-88b4-0c05eb1809e5");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("0ecb85d4-228f-4ccb-9ba5-716b6a4335bf");
			column.CreatedInPackageId = new Guid("43f796d0-2535-4ae5-88b4-0c05eb1809e5");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("0ecb85d4-228f-4ccb-9ba5-716b6a4335bf");
			column.CreatedInPackageId = new Guid("43f796d0-2535-4ae5-88b4-0c05eb1809e5");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("0ecb85d4-228f-4ccb-9ba5-716b6a4335bf");
			column.CreatedInPackageId = new Guid("43f796d0-2535-4ae5-88b4-0c05eb1809e5");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("0ecb85d4-228f-4ccb-9ba5-716b6a4335bf");
			column.CreatedInPackageId = new Guid("43f796d0-2535-4ae5-88b4-0c05eb1809e5");
			return column;
		}

		protected virtual EntitySchemaColumn CreateSysAdminUnitColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("10e0123a-4cfa-41fc-82be-81c4bd5b8dc6"),
				Name = @"SysAdminUnit",
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("0ecb85d4-228f-4ccb-9ba5-716b6a4335bf"),
				ModifiedInSchemaUId = new Guid("0ecb85d4-228f-4ccb-9ba5-716b6a4335bf"),
				CreatedInPackageId = new Guid("43f796d0-2535-4ae5-88b4-0c05eb1809e5"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentUser")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateFolderIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("4d24b8ff-9dda-4d8b-8c05-4b74b36ec731"),
				Name = @"FolderId",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("0ecb85d4-228f-4ccb-9ba5-716b6a4335bf"),
				ModifiedInSchemaUId = new Guid("0ecb85d4-228f-4ccb-9ba5-716b6a4335bf"),
				CreatedInPackageId = new Guid("43f796d0-2535-4ae5-88b4-0c05eb1809e5")
			};
		}

		protected virtual EntitySchemaColumn CreateFolderEntitySchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("b4acab41-c8b0-4e52-a535-93985f9d9af2"),
				Name = @"FolderEntitySchemaUId",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("0ecb85d4-228f-4ccb-9ba5-716b6a4335bf"),
				ModifiedInSchemaUId = new Guid("0ecb85d4-228f-4ccb-9ba5-716b6a4335bf"),
				CreatedInPackageId = new Guid("43f796d0-2535-4ae5-88b4-0c05eb1809e5")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateFolderFavoriteEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateFolderFavoriteEventsProcessSchema() {
			var schema = new FolderFavoriteEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new FolderFavorite(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new FolderFavorite_NUIEventsProcess(userConnection);
		}

		public override object Clone() {
			return new FolderFavoriteSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new FolderFavoriteSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0ecb85d4-228f-4ccb-9ba5-716b6a4335bf"));
		}

		#endregion

	}

	#endregion

	#region Class: FolderFavorite

	/// <summary>
	/// Favorite folder.
	/// </summary>
	public class FolderFavorite : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public FolderFavorite(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "FolderFavorite";
		}

		public FolderFavorite(FolderFavorite source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid SysAdminUnitId {
			get {
				return GetTypedColumnValue<Guid>("SysAdminUnitId");
			}
			set {
				SetColumnValue("SysAdminUnitId", value);
				_sysAdminUnit = null;
			}
		}

		/// <exclude/>
		public string SysAdminUnitName {
			get {
				return GetTypedColumnValue<string>("SysAdminUnitName");
			}
			set {
				SetColumnValue("SysAdminUnitName", value);
				if (_sysAdminUnit != null) {
					_sysAdminUnit.Name = value;
				}
			}
		}

		private SysAdminUnit _sysAdminUnit;
		/// <summary>
		/// User.
		/// </summary>
		public SysAdminUnit SysAdminUnit {
			get {
				return _sysAdminUnit ??
					(_sysAdminUnit = LookupColumnEntities.GetEntity("SysAdminUnit") as SysAdminUnit);
			}
		}

		/// <summary>
		/// Folder.
		/// </summary>
		public Guid FolderId {
			get {
				return GetTypedColumnValue<Guid>("FolderId");
			}
			set {
				SetColumnValue("FolderId", value);
			}
		}

		/// <summary>
		/// Folder schema.
		/// </summary>
		public Guid FolderEntitySchemaUId {
			get {
				return GetTypedColumnValue<Guid>("FolderEntitySchemaUId");
			}
			set {
				SetColumnValue("FolderEntitySchemaUId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new FolderFavorite_NUIEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("FolderFavoriteDeleted", e);
			Inserting += (s, e) => ThrowEvent("FolderFavoriteInserting", e);
			Validating += (s, e) => ThrowEvent("FolderFavoriteValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new FolderFavorite(this);
		}

		#endregion

	}

	#endregion

	#region Class: FolderFavorite_NUIEventsProcess

	/// <exclude/>
	public partial class FolderFavorite_NUIEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : FolderFavorite
	{

		public FolderFavorite_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FolderFavorite_NUIEventsProcess";
			SchemaUId = new Guid("0ecb85d4-228f-4ccb-9ba5-716b6a4335bf");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("0ecb85d4-228f-4ccb-9ba5-716b6a4335bf");
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

	#region Class: FolderFavorite_NUIEventsProcess

	/// <exclude/>
	public class FolderFavorite_NUIEventsProcess : FolderFavorite_NUIEventsProcess<FolderFavorite>
	{

		public FolderFavorite_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: FolderFavorite_NUIEventsProcess

	public partial class FolderFavorite_NUIEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: FolderFavoriteEventsProcessSchema

	/// <exclude/>
	public class FolderFavoriteEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public FolderFavoriteEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public FolderFavoriteEventsProcessSchema(FolderFavoriteEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "FolderFavorite_NUIEventsProcess";
			UId = new Guid("f6f1d5fc-0a1a-4386-90ca-56826da3b68d");
			CreatedInPackageId = new Guid("43f796d0-2535-4ae5-88b4-0c05eb1809e5");
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
				CreatedInPackageId = new Guid("43f796d0-2535-4ae5-88b4-0c05eb1809e5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("43f796d0-2535-4ae5-88b4-0c05eb1809e5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("43f796d0-2535-4ae5-88b4-0c05eb1809e5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("43f796d0-2535-4ae5-88b4-0c05eb1809e5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("43f796d0-2535-4ae5-88b4-0c05eb1809e5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("43f796d0-2535-4ae5-88b4-0c05eb1809e5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("43f796d0-2535-4ae5-88b4-0c05eb1809e5")
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
			return new FolderFavoriteEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f6f1d5fc-0a1a-4386-90ca-56826da3b68d"));
		}

		#endregion

	}

	#endregion


	#region Class: FolderFavoriteEventsProcess

	/// <exclude/>
	public class FolderFavoriteEventsProcess : FolderFavorite_NUIEventsProcess
	{

		public FolderFavoriteEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

