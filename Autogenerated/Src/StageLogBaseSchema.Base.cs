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

	#region Class: StageLogBaseSchema

	/// <exclude/>
	[IsVirtual]
	public class StageLogBaseSchema : Terrasoft.Configuration.SysSchemaPropertySchema
	{

		#region Constructors: Public

		public StageLogBaseSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public StageLogBaseSchema(StageLogBaseSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public StageLogBaseSchema(StageLogBaseSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f57bf9d0-7c37-49a9-843f-c0f5125de77e");
			RealUId = new Guid("f57bf9d0-7c37-49a9-843f-c0f5125de77e");
			Name = "StageLogBase";
			ParentSchemaUId = new Guid("477e2c73-d48b-4a5d-9a46-d1ee851f1bde");
			ExtendParent = false;
			CreatedInPackageId = new Guid("7e406f3f-0514-4d14-a20b-c3a59a45194f");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("7320f200-b563-4711-a597-53bba810bd7b")) == null) {
				Columns.Add(CreateRootEntityColumn());
			}
			if (Columns.FindByUId(new Guid("0ccb40bd-781c-410f-a2b1-8454c1c0d112")) == null) {
				Columns.Add(CreateStageColumn());
			}
			if (Columns.FindByUId(new Guid("73563dd9-6ecd-4c9e-ab15-d2029cb3852c")) == null) {
				Columns.Add(CreateStartDateColumn());
			}
			if (Columns.FindByUId(new Guid("a98f7382-4fd9-475e-8534-951eb325cd5b")) == null) {
				Columns.Add(CreateDueDateColumn());
			}
			if (Columns.FindByUId(new Guid("07570ba7-9860-40f9-9270-46d4e1b487eb")) == null) {
				Columns.Add(CreateOwnerColumn());
			}
			if (Columns.FindByUId(new Guid("18fafc11-2e6f-4874-8173-bb65967c4f90")) == null) {
				Columns.Add(CreateHistoricalColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateRootEntityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("7320f200-b563-4711-a597-53bba810bd7b"),
				Name = @"RootEntity",
				ReferenceSchemaUId = new Guid("2aecdb97-990e-4c17-96f4-240ca6531c84"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("f57bf9d0-7c37-49a9-843f-c0f5125de77e"),
				ModifiedInSchemaUId = new Guid("f57bf9d0-7c37-49a9-843f-c0f5125de77e"),
				CreatedInPackageId = new Guid("7e406f3f-0514-4d14-a20b-c3a59a45194f")
			};
		}

		protected virtual EntitySchemaColumn CreateStageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0ccb40bd-781c-410f-a2b1-8454c1c0d112"),
				Name = @"Stage",
				ReferenceSchemaUId = new Guid("2aecdb97-990e-4c17-96f4-240ca6531c84"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("f57bf9d0-7c37-49a9-843f-c0f5125de77e"),
				ModifiedInSchemaUId = new Guid("f57bf9d0-7c37-49a9-843f-c0f5125de77e"),
				CreatedInPackageId = new Guid("7e406f3f-0514-4d14-a20b-c3a59a45194f")
			};
		}

		protected virtual EntitySchemaColumn CreateStartDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("73563dd9-6ecd-4c9e-ab15-d2029cb3852c"),
				Name = @"StartDate",
				CreatedInSchemaUId = new Guid("f57bf9d0-7c37-49a9-843f-c0f5125de77e"),
				ModifiedInSchemaUId = new Guid("f57bf9d0-7c37-49a9-843f-c0f5125de77e"),
				CreatedInPackageId = new Guid("7e406f3f-0514-4d14-a20b-c3a59a45194f")
			};
		}

		protected virtual EntitySchemaColumn CreateDueDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("a98f7382-4fd9-475e-8534-951eb325cd5b"),
				Name = @"DueDate",
				CreatedInSchemaUId = new Guid("f57bf9d0-7c37-49a9-843f-c0f5125de77e"),
				ModifiedInSchemaUId = new Guid("f57bf9d0-7c37-49a9-843f-c0f5125de77e"),
				CreatedInPackageId = new Guid("7e406f3f-0514-4d14-a20b-c3a59a45194f")
			};
		}

		protected virtual EntitySchemaColumn CreateOwnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("07570ba7-9860-40f9-9270-46d4e1b487eb"),
				Name = @"Owner",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("f57bf9d0-7c37-49a9-843f-c0f5125de77e"),
				ModifiedInSchemaUId = new Guid("f57bf9d0-7c37-49a9-843f-c0f5125de77e"),
				CreatedInPackageId = new Guid("7e406f3f-0514-4d14-a20b-c3a59a45194f")
			};
		}

		protected virtual EntitySchemaColumn CreateHistoricalColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("18fafc11-2e6f-4874-8173-bb65967c4f90"),
				Name = @"Historical",
				CreatedInSchemaUId = new Guid("f57bf9d0-7c37-49a9-843f-c0f5125de77e"),
				ModifiedInSchemaUId = new Guid("f57bf9d0-7c37-49a9-843f-c0f5125de77e"),
				CreatedInPackageId = new Guid("7e406f3f-0514-4d14-a20b-c3a59a45194f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateStageLogBaseEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateStageLogBaseEventsProcessSchema() {
			var schema = new StageLogBaseEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new StageLogBase(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new StageLogBase_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new StageLogBaseSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new StageLogBaseSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f57bf9d0-7c37-49a9-843f-c0f5125de77e"));
		}

		#endregion

	}

	#endregion

	#region Class: StageLogBase

	/// <summary>
	/// Stage log base.
	/// </summary>
	public class StageLogBase : Terrasoft.Configuration.SysSchemaProperty
	{

		#region Constructors: Public

		public StageLogBase(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "StageLogBase";
		}

		public StageLogBase(StageLogBase source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid RootEntityId {
			get {
				return GetTypedColumnValue<Guid>("RootEntityId");
			}
			set {
				SetColumnValue("RootEntityId", value);
				_rootEntity = null;
			}
		}

		/// <exclude/>
		public string RootEntityName {
			get {
				return GetTypedColumnValue<string>("RootEntityName");
			}
			set {
				SetColumnValue("RootEntityName", value);
				if (_rootEntity != null) {
					_rootEntity.Name = value;
				}
			}
		}

		private Lookup _rootEntity;
		/// <summary>
		/// Logged object.
		/// </summary>
		public Lookup RootEntity {
			get {
				return _rootEntity ??
					(_rootEntity = LookupColumnEntities.GetEntity("RootEntity") as Lookup);
			}
		}

		/// <exclude/>
		public Guid StageId {
			get {
				return GetTypedColumnValue<Guid>("StageId");
			}
			set {
				SetColumnValue("StageId", value);
				_stage = null;
			}
		}

		/// <exclude/>
		public string StageName {
			get {
				return GetTypedColumnValue<string>("StageName");
			}
			set {
				SetColumnValue("StageName", value);
				if (_stage != null) {
					_stage.Name = value;
				}
			}
		}

		private Lookup _stage;
		/// <summary>
		/// Stage.
		/// </summary>
		public Lookup Stage {
			get {
				return _stage ??
					(_stage = LookupColumnEntities.GetEntity("Stage") as Lookup);
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

		/// <exclude/>
		public Guid OwnerId {
			get {
				return GetTypedColumnValue<Guid>("OwnerId");
			}
			set {
				SetColumnValue("OwnerId", value);
				_owner = null;
			}
		}

		/// <exclude/>
		public string OwnerName {
			get {
				return GetTypedColumnValue<string>("OwnerName");
			}
			set {
				SetColumnValue("OwnerName", value);
				if (_owner != null) {
					_owner.Name = value;
				}
			}
		}

		private Contact _owner;
		/// <summary>
		/// Owner.
		/// </summary>
		public Contact Owner {
			get {
				return _owner ??
					(_owner = LookupColumnEntities.GetEntity("Owner") as Contact);
			}
		}

		/// <summary>
		/// Is historical.
		/// </summary>
		public bool Historical {
			get {
				return GetTypedColumnValue<bool>("Historical");
			}
			set {
				SetColumnValue("Historical", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new StageLogBase_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("StageLogBaseDeleted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new StageLogBase(this);
		}

		#endregion

	}

	#endregion

	#region Class: StageLogBase_BaseEventsProcess

	/// <exclude/>
	public partial class StageLogBase_BaseEventsProcess<TEntity> : Terrasoft.Configuration.SysSchemaProperty_BaseEventsProcess<TEntity> where TEntity : StageLogBase
	{

		public StageLogBase_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "StageLogBase_BaseEventsProcess";
			SchemaUId = new Guid("f57bf9d0-7c37-49a9-843f-c0f5125de77e");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f57bf9d0-7c37-49a9-843f-c0f5125de77e");
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

	#region Class: StageLogBase_BaseEventsProcess

	/// <exclude/>
	public class StageLogBase_BaseEventsProcess : StageLogBase_BaseEventsProcess<StageLogBase>
	{

		public StageLogBase_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: StageLogBase_BaseEventsProcess

	public partial class StageLogBase_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: StageLogBaseEventsProcessSchema

	/// <exclude/>
	public class StageLogBaseEventsProcessSchema : Terrasoft.Configuration.SysSchemaPropertyEventsProcessSchema
	{

		#region Constructors: Public

		public StageLogBaseEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public StageLogBaseEventsProcessSchema(StageLogBaseEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "StageLogBase_BaseEventsProcess";
			UId = new Guid("a81dfafb-2f5d-4afb-a432-086133006638");
			CreatedInPackageId = new Guid("7e406f3f-0514-4d14-a20b-c3a59a45194f");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("89f42716-cb8b-402f-a5c5-d6b1f8e466eb");
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
			return new StageLogBaseEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a81dfafb-2f5d-4afb-a432-086133006638"));
		}

		#endregion

	}

	#endregion


	#region Class: StageLogBaseEventsProcess

	/// <exclude/>
	public class StageLogBaseEventsProcess : StageLogBase_BaseEventsProcess
	{

		public StageLogBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

