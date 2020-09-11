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

	#region Class: SysEntitySchemaRecordRightSchema

	/// <exclude/>
	[IsVirtual]
	public class SysEntitySchemaRecordRightSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysEntitySchemaRecordRightSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysEntitySchemaRecordRightSchema(SysEntitySchemaRecordRightSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysEntitySchemaRecordRightSchema(SysEntitySchemaRecordRightSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("509cef8b-8cdf-48e4-a41c-c0159f1e0bf7");
			RealUId = new Guid("509cef8b-8cdf-48e4-a41c-c0159f1e0bf7");
			Name = "SysEntitySchemaRecordRight";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("1dc808dc-d1fb-499f-bb7f-3d5f3114e3a4")) == null) {
				Columns.Add(CreateRecordIdColumn());
			}
			if (Columns.FindByUId(new Guid("3d68cb45-def6-4b0e-9c5f-89e871d87454")) == null) {
				Columns.Add(CreateSysAdminUnitColumn());
			}
			if (Columns.FindByUId(new Guid("ea741da6-982c-4724-b77f-9dd39edaf88f")) == null) {
				Columns.Add(CreateOperationColumn());
			}
			if (Columns.FindByUId(new Guid("190b9412-9fbe-4030-874e-8b5bc3e4829e")) == null) {
				Columns.Add(CreateColumn4Column());
			}
			if (Columns.FindByUId(new Guid("d56c9154-4e56-4f2f-a365-b115dd8d4d1d")) == null) {
				Columns.Add(CreateSourceColumn());
			}
			if (Columns.FindByUId(new Guid("e46f5f2d-4622-4524-bf7d-7ea1a86e66c5")) == null) {
				Columns.Add(CreatePositionColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateRecordIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("1dc808dc-d1fb-499f-bb7f-3d5f3114e3a4"),
				Name = @"RecordId",
				CreatedInSchemaUId = new Guid("509cef8b-8cdf-48e4-a41c-c0159f1e0bf7"),
				ModifiedInSchemaUId = new Guid("509cef8b-8cdf-48e4-a41c-c0159f1e0bf7"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected virtual EntitySchemaColumn CreateSysAdminUnitColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("3d68cb45-def6-4b0e-9c5f-89e871d87454"),
				Name = @"SysAdminUnit",
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				CreatedInSchemaUId = new Guid("509cef8b-8cdf-48e4-a41c-c0159f1e0bf7"),
				ModifiedInSchemaUId = new Guid("509cef8b-8cdf-48e4-a41c-c0159f1e0bf7"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected virtual EntitySchemaColumn CreateOperationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ea741da6-982c-4724-b77f-9dd39edaf88f"),
				Name = @"Operation",
				ReferenceSchemaUId = new Guid("01618739-cd25-41bf-9cda-86594ea9f512"),
				CreatedInSchemaUId = new Guid("509cef8b-8cdf-48e4-a41c-c0159f1e0bf7"),
				ModifiedInSchemaUId = new Guid("509cef8b-8cdf-48e4-a41c-c0159f1e0bf7"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected virtual EntitySchemaColumn CreateColumn4Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("190b9412-9fbe-4030-874e-8b5bc3e4829e"),
				Name = @"Column4",
				ReferenceSchemaUId = new Guid("0305bb65-8332-47b3-8550-3d5c3e59cb3e"),
				CreatedInSchemaUId = new Guid("509cef8b-8cdf-48e4-a41c-c0159f1e0bf7"),
				ModifiedInSchemaUId = new Guid("509cef8b-8cdf-48e4-a41c-c0159f1e0bf7"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected virtual EntitySchemaColumn CreateSourceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d56c9154-4e56-4f2f-a365-b115dd8d4d1d"),
				Name = @"Source",
				ReferenceSchemaUId = new Guid("f990ac27-1b3c-4090-bea2-694e259c8c2c"),
				CreatedInSchemaUId = new Guid("509cef8b-8cdf-48e4-a41c-c0159f1e0bf7"),
				ModifiedInSchemaUId = new Guid("509cef8b-8cdf-48e4-a41c-c0159f1e0bf7"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected virtual EntitySchemaColumn CreatePositionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("e46f5f2d-4622-4524-bf7d-7ea1a86e66c5"),
				Name = @"Position",
				CreatedInSchemaUId = new Guid("509cef8b-8cdf-48e4-a41c-c0159f1e0bf7"),
				ModifiedInSchemaUId = new Guid("509cef8b-8cdf-48e4-a41c-c0159f1e0bf7"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysEntitySchemaRecordRightEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysEntitySchemaRecordRightEventsProcessSchema() {
			var schema = new SysEntitySchemaRecordRightEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysEntitySchemaRecordRight(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysEntitySchemaRecordRight_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysEntitySchemaRecordRightSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysEntitySchemaRecordRightSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("509cef8b-8cdf-48e4-a41c-c0159f1e0bf7"));
		}

		#endregion

	}

	#endregion

	#region Class: SysEntitySchemaRecordRight

	/// <summary>
	/// User access to object.
	/// </summary>
	public class SysEntitySchemaRecordRight : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysEntitySchemaRecordRight(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysEntitySchemaRecordRight";
		}

		public SysEntitySchemaRecordRight(SysEntitySchemaRecordRight source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Record Id.
		/// </summary>
		public Guid RecordId {
			get {
				return GetTypedColumnValue<Guid>("RecordId");
			}
			set {
				SetColumnValue("RecordId", value);
			}
		}

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
		/// Object.
		/// </summary>
		public SysAdminUnit SysAdminUnit {
			get {
				return _sysAdminUnit ??
					(_sysAdminUnit = LookupColumnEntities.GetEntity("SysAdminUnit") as SysAdminUnit);
			}
		}

		/// <exclude/>
		public Guid OperationId {
			get {
				return GetTypedColumnValue<Guid>("OperationId");
			}
			set {
				SetColumnValue("OperationId", value);
				_operation = null;
			}
		}

		/// <exclude/>
		public string OperationName {
			get {
				return GetTypedColumnValue<string>("OperationName");
			}
			set {
				SetColumnValue("OperationName", value);
				if (_operation != null) {
					_operation.Name = value;
				}
			}
		}

		private EntitySchemaRecRightOperation _operation;
		/// <summary>
		/// Operation.
		/// </summary>
		public EntitySchemaRecRightOperation Operation {
			get {
				return _operation ??
					(_operation = LookupColumnEntities.GetEntity("Operation") as EntitySchemaRecRightOperation);
			}
		}

		/// <exclude/>
		public Guid Column4Id {
			get {
				return GetTypedColumnValue<Guid>("Column4Id");
			}
			set {
				SetColumnValue("Column4Id", value);
				_column4 = null;
			}
		}

		/// <exclude/>
		public string Column4Name {
			get {
				return GetTypedColumnValue<string>("Column4Name");
			}
			set {
				SetColumnValue("Column4Name", value);
				if (_column4 != null) {
					_column4.Name = value;
				}
			}
		}

		private SysEntitySchemaRecOprRightLvl _column4;
		/// <summary>
		/// Access level.
		/// </summary>
		public SysEntitySchemaRecOprRightLvl Column4 {
			get {
				return _column4 ??
					(_column4 = LookupColumnEntities.GetEntity("Column4") as SysEntitySchemaRecOprRightLvl);
			}
		}

		/// <exclude/>
		public Guid SourceId {
			get {
				return GetTypedColumnValue<Guid>("SourceId");
			}
			set {
				SetColumnValue("SourceId", value);
				_source = null;
			}
		}

		/// <exclude/>
		public string SourceName {
			get {
				return GetTypedColumnValue<string>("SourceName");
			}
			set {
				SetColumnValue("SourceName", value);
				if (_source != null) {
					_source.Name = value;
				}
			}
		}

		private SysEntitySchemaRecRightSource _source;
		/// <summary>
		/// Access right source.
		/// </summary>
		public SysEntitySchemaRecRightSource Source {
			get {
				return _source ??
					(_source = LookupColumnEntities.GetEntity("Source") as SysEntitySchemaRecRightSource);
			}
		}

		/// <summary>
		/// Position.
		/// </summary>
		public int Position {
			get {
				return GetTypedColumnValue<int>("Position");
			}
			set {
				SetColumnValue("Position", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysEntitySchemaRecordRight_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysEntitySchemaRecordRightDeleted", e);
			Deleting += (s, e) => ThrowEvent("SysEntitySchemaRecordRightDeleting", e);
			Inserted += (s, e) => ThrowEvent("SysEntitySchemaRecordRightInserted", e);
			Inserting += (s, e) => ThrowEvent("SysEntitySchemaRecordRightInserting", e);
			Saved += (s, e) => ThrowEvent("SysEntitySchemaRecordRightSaved", e);
			Saving += (s, e) => ThrowEvent("SysEntitySchemaRecordRightSaving", e);
			Validating += (s, e) => ThrowEvent("SysEntitySchemaRecordRightValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysEntitySchemaRecordRight(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysEntitySchemaRecordRight_BaseEventsProcess

	/// <exclude/>
	public partial class SysEntitySchemaRecordRight_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysEntitySchemaRecordRight
	{

		public SysEntitySchemaRecordRight_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysEntitySchemaRecordRight_BaseEventsProcess";
			SchemaUId = new Guid("509cef8b-8cdf-48e4-a41c-c0159f1e0bf7");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("509cef8b-8cdf-48e4-a41c-c0159f1e0bf7");
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

	#region Class: SysEntitySchemaRecordRight_BaseEventsProcess

	/// <exclude/>
	public class SysEntitySchemaRecordRight_BaseEventsProcess : SysEntitySchemaRecordRight_BaseEventsProcess<SysEntitySchemaRecordRight>
	{

		public SysEntitySchemaRecordRight_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysEntitySchemaRecordRight_BaseEventsProcess

	public partial class SysEntitySchemaRecordRight_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysEntitySchemaRecordRightEventsProcessSchema

	/// <exclude/>
	public class SysEntitySchemaRecordRightEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysEntitySchemaRecordRightEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysEntitySchemaRecordRightEventsProcessSchema(SysEntitySchemaRecordRightEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysEntitySchemaRecordRight_BaseEventsProcess";
			UId = new Guid("07b4b0f1-eb2f-4437-b8b9-bff4fde3ee43");
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
			return new SysEntitySchemaRecordRightEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("07b4b0f1-eb2f-4437-b8b9-bff4fde3ee43"));
		}

		#endregion

	}

	#endregion


	#region Class: SysEntitySchemaRecordRightEventsProcess

	/// <exclude/>
	public class SysEntitySchemaRecordRightEventsProcess : SysEntitySchemaRecordRight_BaseEventsProcess
	{

		public SysEntitySchemaRecordRightEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

