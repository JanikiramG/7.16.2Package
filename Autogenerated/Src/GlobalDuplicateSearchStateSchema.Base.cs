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

	#region Class: GlobalDuplicateSearchStateSchema

	/// <exclude/>
	public class GlobalDuplicateSearchStateSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public GlobalDuplicateSearchStateSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public GlobalDuplicateSearchStateSchema(GlobalDuplicateSearchStateSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public GlobalDuplicateSearchStateSchema(GlobalDuplicateSearchStateSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6f223270-b27e-4a02-8b6d-0ac1efd26857");
			RealUId = new Guid("6f223270-b27e-4a02-8b6d-0ac1efd26857");
			Name = "GlobalDuplicateSearchState";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("ca2ab584-f24a-4ae3-96c1-89302f661118")) == null) {
				Columns.Add(CreateEntityRowNumberColumn());
			}
			if (Columns.FindByUId(new Guid("f6096978-27ce-4210-bbe6-d4b50a8a2eac")) == null) {
				Columns.Add(CreateSchemaToSearchIdColumn());
			}
			if (Columns.FindByUId(new Guid("5e6d4aa4-38db-4e40-8b0c-b0c9c1b44b52")) == null) {
				Columns.Add(CreateProcessedCountColumn());
			}
			if (Columns.FindByUId(new Guid("29fc039d-5b47-4fe9-926b-c6b51fdec44c")) == null) {
				Columns.Add(CreateSearchStatusColumn());
			}
			if (Columns.FindByUId(new Guid("126a0d15-0dcd-466f-b26a-33a66961dc78")) == null) {
				Columns.Add(CreateSearchStatusChangedOnColumn());
			}
			if (Columns.FindByUId(new Guid("981bb725-a262-4f84-90b5-ddec2a6ac53f")) == null) {
				Columns.Add(CreateTotalCountColumn());
			}
			if (Columns.FindByUId(new Guid("57b20215-ddfb-4868-a89a-c46d62bfb42c")) == null) {
				Columns.Add(CreateIsManuallyTriggeredColumn());
			}
			if (Columns.FindByUId(new Guid("ff006596-ff26-41f8-b8b1-9f8ce31d6e40")) == null) {
				Columns.Add(CreateSchemaToSearchNameColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateEntityRowNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("ca2ab584-f24a-4ae3-96c1-89302f661118"),
				Name = @"EntityRowNumber",
				CreatedInSchemaUId = new Guid("6f223270-b27e-4a02-8b6d-0ac1efd26857"),
				ModifiedInSchemaUId = new Guid("6f223270-b27e-4a02-8b6d-0ac1efd26857"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSchemaToSearchIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("f6096978-27ce-4210-bbe6-d4b50a8a2eac"),
				Name = @"SchemaToSearchId",
				CreatedInSchemaUId = new Guid("6f223270-b27e-4a02-8b6d-0ac1efd26857"),
				ModifiedInSchemaUId = new Guid("6f223270-b27e-4a02-8b6d-0ac1efd26857"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateProcessedCountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("5e6d4aa4-38db-4e40-8b0c-b0c9c1b44b52"),
				Name = @"ProcessedCount",
				CreatedInSchemaUId = new Guid("6f223270-b27e-4a02-8b6d-0ac1efd26857"),
				ModifiedInSchemaUId = new Guid("6f223270-b27e-4a02-8b6d-0ac1efd26857"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSearchStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("29fc039d-5b47-4fe9-926b-c6b51fdec44c"),
				Name = @"SearchStatus",
				ReferenceSchemaUId = new Guid("1792d230-c5c1-4c80-917d-857bf9681e7a"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("6f223270-b27e-4a02-8b6d-0ac1efd26857"),
				ModifiedInSchemaUId = new Guid("6f223270-b27e-4a02-8b6d-0ac1efd26857"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSearchStatusChangedOnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("126a0d15-0dcd-466f-b26a-33a66961dc78"),
				Name = @"SearchStatusChangedOn",
				CreatedInSchemaUId = new Guid("6f223270-b27e-4a02-8b6d-0ac1efd26857"),
				ModifiedInSchemaUId = new Guid("6f223270-b27e-4a02-8b6d-0ac1efd26857"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateTotalCountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("981bb725-a262-4f84-90b5-ddec2a6ac53f"),
				Name = @"TotalCount",
				CreatedInSchemaUId = new Guid("6f223270-b27e-4a02-8b6d-0ac1efd26857"),
				ModifiedInSchemaUId = new Guid("6f223270-b27e-4a02-8b6d-0ac1efd26857"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateIsManuallyTriggeredColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("57b20215-ddfb-4868-a89a-c46d62bfb42c"),
				Name = @"IsManuallyTriggered",
				CreatedInSchemaUId = new Guid("6f223270-b27e-4a02-8b6d-0ac1efd26857"),
				ModifiedInSchemaUId = new Guid("6f223270-b27e-4a02-8b6d-0ac1efd26857"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSchemaToSearchNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("ff006596-ff26-41f8-b8b1-9f8ce31d6e40"),
				Name = @"SchemaToSearchName",
				CreatedInSchemaUId = new Guid("6f223270-b27e-4a02-8b6d-0ac1efd26857"),
				ModifiedInSchemaUId = new Guid("6f223270-b27e-4a02-8b6d-0ac1efd26857"),
				CreatedInPackageId = new Guid("8bf8ae5e-52c9-44c1-a099-364797b55805")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateGlobalDuplicateSearchStateEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateGlobalDuplicateSearchStateEventsProcessSchema() {
			var schema = new GlobalDuplicateSearchStateEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new GlobalDuplicateSearchState(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new GlobalDuplicateSearchState_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new GlobalDuplicateSearchStateSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new GlobalDuplicateSearchStateSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6f223270-b27e-4a02-8b6d-0ac1efd26857"));
		}

		#endregion

	}

	#endregion

	#region Class: GlobalDuplicateSearchState

	/// <summary>
	/// Current status of global duplicates search.
	/// </summary>
	public class GlobalDuplicateSearchState : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public GlobalDuplicateSearchState(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "GlobalDuplicateSearchState";
		}

		public GlobalDuplicateSearchState(GlobalDuplicateSearchState source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Number of record.
		/// </summary>
		public int EntityRowNumber {
			get {
				return GetTypedColumnValue<int>("EntityRowNumber");
			}
			set {
				SetColumnValue("EntityRowNumber", value);
			}
		}

		/// <summary>
		/// Schema.
		/// </summary>
		public Guid SchemaToSearchId {
			get {
				return GetTypedColumnValue<Guid>("SchemaToSearchId");
			}
			set {
				SetColumnValue("SchemaToSearchId", value);
			}
		}

		/// <summary>
		/// Number of processed records.
		/// </summary>
		public int ProcessedCount {
			get {
				return GetTypedColumnValue<int>("ProcessedCount");
			}
			set {
				SetColumnValue("ProcessedCount", value);
			}
		}

		/// <exclude/>
		public Guid SearchStatusId {
			get {
				return GetTypedColumnValue<Guid>("SearchStatusId");
			}
			set {
				SetColumnValue("SearchStatusId", value);
				_searchStatus = null;
			}
		}

		/// <exclude/>
		public string SearchStatusName {
			get {
				return GetTypedColumnValue<string>("SearchStatusName");
			}
			set {
				SetColumnValue("SearchStatusName", value);
				if (_searchStatus != null) {
					_searchStatus.Name = value;
				}
			}
		}

		private GlobalDuplicateSearchStatus _searchStatus;
		/// <summary>
		/// Status.
		/// </summary>
		public GlobalDuplicateSearchStatus SearchStatus {
			get {
				return _searchStatus ??
					(_searchStatus = LookupColumnEntities.GetEntity("SearchStatus") as GlobalDuplicateSearchStatus);
			}
		}

		/// <summary>
		/// Time of status change.
		/// </summary>
		public DateTime SearchStatusChangedOn {
			get {
				return GetTypedColumnValue<DateTime>("SearchStatusChangedOn");
			}
			set {
				SetColumnValue("SearchStatusChangedOn", value);
			}
		}

		/// <summary>
		/// Number of records being processed.
		/// </summary>
		public int TotalCount {
			get {
				return GetTypedColumnValue<int>("TotalCount");
			}
			set {
				SetColumnValue("TotalCount", value);
			}
		}

		/// <summary>
		/// Run by user.
		/// </summary>
		public bool IsManuallyTriggered {
			get {
				return GetTypedColumnValue<bool>("IsManuallyTriggered");
			}
			set {
				SetColumnValue("IsManuallyTriggered", value);
			}
		}

		/// <summary>
		/// Object name.
		/// </summary>
		public string SchemaToSearchName {
			get {
				return GetTypedColumnValue<string>("SchemaToSearchName");
			}
			set {
				SetColumnValue("SchemaToSearchName", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new GlobalDuplicateSearchState_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("GlobalDuplicateSearchStateDeleted", e);
			Deleting += (s, e) => ThrowEvent("GlobalDuplicateSearchStateDeleting", e);
			Inserted += (s, e) => ThrowEvent("GlobalDuplicateSearchStateInserted", e);
			Inserting += (s, e) => ThrowEvent("GlobalDuplicateSearchStateInserting", e);
			Saved += (s, e) => ThrowEvent("GlobalDuplicateSearchStateSaved", e);
			Saving += (s, e) => ThrowEvent("GlobalDuplicateSearchStateSaving", e);
			Validating += (s, e) => ThrowEvent("GlobalDuplicateSearchStateValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new GlobalDuplicateSearchState(this);
		}

		#endregion

	}

	#endregion

	#region Class: GlobalDuplicateSearchState_BaseEventsProcess

	/// <exclude/>
	public partial class GlobalDuplicateSearchState_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : GlobalDuplicateSearchState
	{

		public GlobalDuplicateSearchState_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "GlobalDuplicateSearchState_BaseEventsProcess";
			SchemaUId = new Guid("6f223270-b27e-4a02-8b6d-0ac1efd26857");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6f223270-b27e-4a02-8b6d-0ac1efd26857");
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

	#region Class: GlobalDuplicateSearchState_BaseEventsProcess

	/// <exclude/>
	public class GlobalDuplicateSearchState_BaseEventsProcess : GlobalDuplicateSearchState_BaseEventsProcess<GlobalDuplicateSearchState>
	{

		public GlobalDuplicateSearchState_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: GlobalDuplicateSearchState_BaseEventsProcess

	public partial class GlobalDuplicateSearchState_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: GlobalDuplicateSearchStateEventsProcessSchema

	/// <exclude/>
	public class GlobalDuplicateSearchStateEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public GlobalDuplicateSearchStateEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public GlobalDuplicateSearchStateEventsProcessSchema(GlobalDuplicateSearchStateEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "GlobalDuplicateSearchState_BaseEventsProcess";
			UId = new Guid("be7d7995-9d2d-4287-abac-cacdc3dd58a2");
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
			return new GlobalDuplicateSearchStateEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("be7d7995-9d2d-4287-abac-cacdc3dd58a2"));
		}

		#endregion

	}

	#endregion


	#region Class: GlobalDuplicateSearchStateEventsProcess

	/// <exclude/>
	public class GlobalDuplicateSearchStateEventsProcess : GlobalDuplicateSearchState_BaseEventsProcess
	{

		public GlobalDuplicateSearchStateEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

