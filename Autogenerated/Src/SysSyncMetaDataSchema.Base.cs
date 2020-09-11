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

	#region Class: SysSyncMetaDataSchema

	/// <exclude/>
	public class SysSyncMetaDataSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysSyncMetaDataSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysSyncMetaDataSchema(SysSyncMetaDataSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysSyncMetaDataSchema(SysSyncMetaDataSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateImUyiBIkmjz8vSjziAqF9W4AEQ7QIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = true,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("9bde2ac5-873a-41a7-9b74-d7ec944808c5");
			index.Name = "ImUyiBIkmjz8vSjziAqF9W4AEQ7Q";
			index.CreatedInSchemaUId = new Guid("909da302-de10-490e-8715-5b0f973f043d");
			index.ModifiedInSchemaUId = new Guid("909da302-de10-490e-8715-5b0f973f043d");
			index.CreatedInPackageId = new Guid("e0bd8020-de17-4815-83cd-c2dac7bbc324");
			EntitySchemaIndexColumn remoteIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("0a931d7e-b4d6-4080-8efc-659552db6511"),
				ColumnUId = new Guid("bcd96886-4612-4a3b-9b74-6008dbd384b3"),
				CreatedInSchemaUId = new Guid("909da302-de10-490e-8715-5b0f973f043d"),
				ModifiedInSchemaUId = new Guid("909da302-de10-490e-8715-5b0f973f043d"),
				CreatedInPackageId = new Guid("e0bd8020-de17-4815-83cd-c2dac7bbc324"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(remoteIdIndexColumn);
			EntitySchemaIndexColumn localIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("ad7f839b-d113-4e9e-9281-ba314559fb36"),
				ColumnUId = new Guid("93e6cc9b-2a32-4f5c-9e0f-5d9a1070d34d"),
				CreatedInSchemaUId = new Guid("909da302-de10-490e-8715-5b0f973f043d"),
				ModifiedInSchemaUId = new Guid("909da302-de10-490e-8715-5b0f973f043d"),
				CreatedInPackageId = new Guid("e0bd8020-de17-4815-83cd-c2dac7bbc324"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(localIdIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("909da302-de10-490e-8715-5b0f973f043d");
			RealUId = new Guid("909da302-de10-490e-8715-5b0f973f043d");
			Name = "SysSyncMetaData";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("f3c6cf6b-5815-47a6-a48d-774343fdef83")) == null) {
				Columns.Add(CreateSyncSchemaNameColumn());
			}
			if (Columns.FindByUId(new Guid("bcd96886-4612-4a3b-9b74-6008dbd384b3")) == null) {
				Columns.Add(CreateRemoteIdColumn());
			}
			if (Columns.FindByUId(new Guid("93e6cc9b-2a32-4f5c-9e0f-5d9a1070d34d")) == null) {
				Columns.Add(CreateLocalIdColumn());
			}
			if (Columns.FindByUId(new Guid("90c3bf22-22fe-4577-8ed8-d42d2a8e56e2")) == null) {
				Columns.Add(CreateRemoteStoreIdColumn());
			}
			if (Columns.FindByUId(new Guid("f9469c93-e18b-447c-8d4b-0d896b579cc3")) == null) {
				Columns.Add(CreateIsLocalDeletedColumn());
			}
			if (Columns.FindByUId(new Guid("d98fa6a2-363d-4fbd-bb9a-027e1f387a85")) == null) {
				Columns.Add(CreateIsRemoteDeletedColumn());
			}
			if (Columns.FindByUId(new Guid("316cb2bf-e649-445c-ade6-7ce06f164f6f")) == null) {
				Columns.Add(CreateModifiedInStoreIdColumn());
			}
			if (Columns.FindByUId(new Guid("c4968e5f-1bb6-442f-b774-7c15df22dcb6")) == null) {
				Columns.Add(CreateVersionColumn());
			}
			if (Columns.FindByUId(new Guid("cf5e7e4e-5aad-4eac-844f-fda4a99f4326")) == null) {
				Columns.Add(CreateCreatedInStoreIdColumn());
			}
			if (Columns.FindByUId(new Guid("85b081ae-7f9b-4a1d-bcb1-5db026dc2ead")) == null) {
				Columns.Add(CreateRemoteItemNameColumn());
			}
			if (Columns.FindByUId(new Guid("bb14fdf8-18fd-4a5d-ac6d-96881269a559")) == null) {
				Columns.Add(CreateSchemaOrderColumn());
			}
			if (Columns.FindByUId(new Guid("7123d468-7547-4751-a390-ef476759fa6f")) == null) {
				Columns.Add(CreateExtraParametersColumn());
			}
			if (Columns.FindByUId(new Guid("4fd42846-2b13-48e7-8c13-4b71b2b87b64")) == null) {
				Columns.Add(CreateLocalStateColumn());
			}
			if (Columns.FindByUId(new Guid("b45c1f89-096e-48b0-af51-cd3d2ee0f6fe")) == null) {
				Columns.Add(CreateRemoteStateColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSyncSchemaNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("f3c6cf6b-5815-47a6-a48d-774343fdef83"),
				Name = @"SyncSchemaName",
				CreatedInSchemaUId = new Guid("909da302-de10-490e-8715-5b0f973f043d"),
				ModifiedInSchemaUId = new Guid("909da302-de10-490e-8715-5b0f973f043d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateRemoteIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("bcd96886-4612-4a3b-9b74-6008dbd384b3"),
				Name = @"RemoteId",
				CreatedInSchemaUId = new Guid("909da302-de10-490e-8715-5b0f973f043d"),
				ModifiedInSchemaUId = new Guid("909da302-de10-490e-8715-5b0f973f043d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateLocalIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("93e6cc9b-2a32-4f5c-9e0f-5d9a1070d34d"),
				Name = @"LocalId",
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("909da302-de10-490e-8715-5b0f973f043d"),
				ModifiedInSchemaUId = new Guid("909da302-de10-490e-8715-5b0f973f043d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateRemoteStoreIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("90c3bf22-22fe-4577-8ed8-d42d2a8e56e2"),
				Name = @"RemoteStoreId",
				CreatedInSchemaUId = new Guid("909da302-de10-490e-8715-5b0f973f043d"),
				ModifiedInSchemaUId = new Guid("909da302-de10-490e-8715-5b0f973f043d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateIsLocalDeletedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("f9469c93-e18b-447c-8d4b-0d896b579cc3"),
				Name = @"IsLocalDeleted",
				CreatedInSchemaUId = new Guid("909da302-de10-490e-8715-5b0f973f043d"),
				ModifiedInSchemaUId = new Guid("909da302-de10-490e-8715-5b0f973f043d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateIsRemoteDeletedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("d98fa6a2-363d-4fbd-bb9a-027e1f387a85"),
				Name = @"IsRemoteDeleted",
				CreatedInSchemaUId = new Guid("909da302-de10-490e-8715-5b0f973f043d"),
				ModifiedInSchemaUId = new Guid("909da302-de10-490e-8715-5b0f973f043d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateModifiedInStoreIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("316cb2bf-e649-445c-ade6-7ce06f164f6f"),
				Name = @"ModifiedInStoreId",
				CreatedInSchemaUId = new Guid("909da302-de10-490e-8715-5b0f973f043d"),
				ModifiedInSchemaUId = new Guid("909da302-de10-490e-8715-5b0f973f043d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateVersionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("c4968e5f-1bb6-442f-b774-7c15df22dcb6"),
				Name = @"Version",
				CreatedInSchemaUId = new Guid("909da302-de10-490e-8715-5b0f973f043d"),
				ModifiedInSchemaUId = new Guid("909da302-de10-490e-8715-5b0f973f043d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateCreatedInStoreIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("cf5e7e4e-5aad-4eac-844f-fda4a99f4326"),
				Name = @"CreatedInStoreId",
				CreatedInSchemaUId = new Guid("909da302-de10-490e-8715-5b0f973f043d"),
				ModifiedInSchemaUId = new Guid("909da302-de10-490e-8715-5b0f973f043d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateRemoteItemNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("85b081ae-7f9b-4a1d-bcb1-5db026dc2ead"),
				Name = @"RemoteItemName",
				CreatedInSchemaUId = new Guid("909da302-de10-490e-8715-5b0f973f043d"),
				ModifiedInSchemaUId = new Guid("909da302-de10-490e-8715-5b0f973f043d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSchemaOrderColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("bb14fdf8-18fd-4a5d-ac6d-96881269a559"),
				Name = @"SchemaOrder",
				CreatedInSchemaUId = new Guid("909da302-de10-490e-8715-5b0f973f043d"),
				ModifiedInSchemaUId = new Guid("909da302-de10-490e-8715-5b0f973f043d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateExtraParametersColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("7123d468-7547-4751-a390-ef476759fa6f"),
				Name = @"ExtraParameters",
				CreatedInSchemaUId = new Guid("909da302-de10-490e-8715-5b0f973f043d"),
				ModifiedInSchemaUId = new Guid("909da302-de10-490e-8715-5b0f973f043d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateLocalStateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("4fd42846-2b13-48e7-8c13-4b71b2b87b64"),
				Name = @"LocalState",
				CreatedInSchemaUId = new Guid("909da302-de10-490e-8715-5b0f973f043d"),
				ModifiedInSchemaUId = new Guid("909da302-de10-490e-8715-5b0f973f043d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"0"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateRemoteStateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("b45c1f89-096e-48b0-af51-cd3d2ee0f6fe"),
				Name = @"RemoteState",
				CreatedInSchemaUId = new Guid("909da302-de10-490e-8715-5b0f973f043d"),
				ModifiedInSchemaUId = new Guid("909da302-de10-490e-8715-5b0f973f043d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"0"
				}
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateImUyiBIkmjz8vSjziAqF9W4AEQ7QIndex());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysSyncMetaDataEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysSyncMetaDataEventsProcessSchema() {
			var schema = new SysSyncMetaDataEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysSyncMetaData(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysSyncMetaData_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysSyncMetaDataSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysSyncMetaDataSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("909da302-de10-490e-8715-5b0f973f043d"));
		}

		#endregion

	}

	#endregion

	#region Class: SysSyncMetaData

	/// <summary>
	/// Metadata of synchronization object.
	/// </summary>
	public class SysSyncMetaData : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysSyncMetaData(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysSyncMetaData";
		}

		public SysSyncMetaData(SysSyncMetaData source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// SyncSchemaName.
		/// </summary>
		public string SyncSchemaName {
			get {
				return GetTypedColumnValue<string>("SyncSchemaName");
			}
			set {
				SetColumnValue("SyncSchemaName", value);
			}
		}

		/// <summary>
		/// RemoteId.
		/// </summary>
		public string RemoteId {
			get {
				return GetTypedColumnValue<string>("RemoteId");
			}
			set {
				SetColumnValue("RemoteId", value);
			}
		}

		/// <summary>
		/// LocalId.
		/// </summary>
		public Guid LocalId {
			get {
				return GetTypedColumnValue<Guid>("LocalId");
			}
			set {
				SetColumnValue("LocalId", value);
			}
		}

		/// <summary>
		/// RemoteStoreId.
		/// </summary>
		public Guid RemoteStoreId {
			get {
				return GetTypedColumnValue<Guid>("RemoteStoreId");
			}
			set {
				SetColumnValue("RemoteStoreId", value);
			}
		}

		/// <summary>
		/// IsLocalDeleted (Delete Column).
		/// </summary>
		public bool IsLocalDeleted {
			get {
				return GetTypedColumnValue<bool>("IsLocalDeleted");
			}
			set {
				SetColumnValue("IsLocalDeleted", value);
			}
		}

		/// <summary>
		/// IsRemoteDeleted (Delete Column).
		/// </summary>
		public bool IsRemoteDeleted {
			get {
				return GetTypedColumnValue<bool>("IsRemoteDeleted");
			}
			set {
				SetColumnValue("IsRemoteDeleted", value);
			}
		}

		/// <summary>
		/// ModifiedInStoreId.
		/// </summary>
		public Guid ModifiedInStoreId {
			get {
				return GetTypedColumnValue<Guid>("ModifiedInStoreId");
			}
			set {
				SetColumnValue("ModifiedInStoreId", value);
			}
		}

		/// <summary>
		/// Version.
		/// </summary>
		public DateTime Version {
			get {
				return GetTypedColumnValue<DateTime>("Version");
			}
			set {
				SetColumnValue("Version", value);
			}
		}

		/// <summary>
		/// CreatedInStoreId.
		/// </summary>
		public Guid CreatedInStoreId {
			get {
				return GetTypedColumnValue<Guid>("CreatedInStoreId");
			}
			set {
				SetColumnValue("CreatedInStoreId", value);
			}
		}

		/// <summary>
		/// RemoteItemName.
		/// </summary>
		public string RemoteItemName {
			get {
				return GetTypedColumnValue<string>("RemoteItemName");
			}
			set {
				SetColumnValue("RemoteItemName", value);
			}
		}

		/// <summary>
		/// SchemaOrder.
		/// </summary>
		public int SchemaOrder {
			get {
				return GetTypedColumnValue<int>("SchemaOrder");
			}
			set {
				SetColumnValue("SchemaOrder", value);
			}
		}

		/// <summary>
		/// ExtraParameters.
		/// </summary>
		public string ExtraParameters {
			get {
				return GetTypedColumnValue<string>("ExtraParameters");
			}
			set {
				SetColumnValue("ExtraParameters", value);
			}
		}

		/// <summary>
		/// LocalState.
		/// </summary>
		public int LocalState {
			get {
				return GetTypedColumnValue<int>("LocalState");
			}
			set {
				SetColumnValue("LocalState", value);
			}
		}

		/// <summary>
		/// RemoteState.
		/// </summary>
		public int RemoteState {
			get {
				return GetTypedColumnValue<int>("RemoteState");
			}
			set {
				SetColumnValue("RemoteState", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysSyncMetaData_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysSyncMetaDataDeleted", e);
			Inserting += (s, e) => ThrowEvent("SysSyncMetaDataInserting", e);
			Validating += (s, e) => ThrowEvent("SysSyncMetaDataValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysSyncMetaData(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysSyncMetaData_BaseEventsProcess

	/// <exclude/>
	public partial class SysSyncMetaData_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysSyncMetaData
	{

		public SysSyncMetaData_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysSyncMetaData_BaseEventsProcess";
			SchemaUId = new Guid("909da302-de10-490e-8715-5b0f973f043d");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("909da302-de10-490e-8715-5b0f973f043d");
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

	#region Class: SysSyncMetaData_BaseEventsProcess

	/// <exclude/>
	public class SysSyncMetaData_BaseEventsProcess : SysSyncMetaData_BaseEventsProcess<SysSyncMetaData>
	{

		public SysSyncMetaData_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysSyncMetaData_BaseEventsProcess

	public partial class SysSyncMetaData_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysSyncMetaDataEventsProcessSchema

	/// <exclude/>
	public class SysSyncMetaDataEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysSyncMetaDataEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysSyncMetaDataEventsProcessSchema(SysSyncMetaDataEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysSyncMetaData_BaseEventsProcess";
			UId = new Guid("1673340d-d95a-4678-88ce-dde05f05c008");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
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
			return new SysSyncMetaDataEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1673340d-d95a-4678-88ce-dde05f05c008"));
		}

		#endregion

	}

	#endregion


	#region Class: SysSyncMetaDataEventsProcess

	/// <exclude/>
	public class SysSyncMetaDataEventsProcess : SysSyncMetaData_BaseEventsProcess
	{

		public SysSyncMetaDataEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

