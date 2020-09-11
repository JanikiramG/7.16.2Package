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

	#region Class: VwSysProcessElementLogSchema

	/// <exclude/>
	public class VwSysProcessElementLogSchema : Terrasoft.Configuration.SysBasePrcElLogSchema
	{

		#region Constructors: Public

		public VwSysProcessElementLogSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwSysProcessElementLogSchema(VwSysProcessElementLogSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwSysProcessElementLogSchema(VwSysProcessElementLogSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5d3f02cf-a6d8-4352-ad7f-1610697d7dd4");
			RealUId = new Guid("5d3f02cf-a6d8-4352-ad7f-1610697d7dd4");
			Name = "VwSysProcessElementLog";
			ParentSchemaUId = new Guid("293f3c3a-0dfb-4677-aa00-ac2a2628eaab");
			ExtendParent = false;
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
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
			if (Columns.FindByUId(new Guid("1dfa8b22-74a5-4663-a6c1-86686ebac382")) == null) {
				Columns.Add(CreateArchivedColumn());
			}
			if (Columns.FindByUId(new Guid("c52e6f01-bc34-4072-9694-7790f58a47b2")) == null) {
				Columns.Add(CreateSysProcessColumn());
			}
			if (Columns.FindByUId(new Guid("8f641a97-3b61-45a3-8438-612e757dd014")) == null) {
				Columns.Add(CreateHasTraceDataColumn());
			}
			if (Columns.FindByUId(new Guid("ea779696-5e24-4b01-82ec-4b87c9541dc0")) == null) {
				Columns.Add(CreateDurationInSecondsColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateArchivedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("1dfa8b22-74a5-4663-a6c1-86686ebac382"),
				Name = @"Archived",
				CreatedInSchemaUId = new Guid("5d3f02cf-a6d8-4352-ad7f-1610697d7dd4"),
				ModifiedInSchemaUId = new Guid("5d3f02cf-a6d8-4352-ad7f-1610697d7dd4"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateSysProcessColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c52e6f01-bc34-4072-9694-7790f58a47b2"),
				Name = @"SysProcess",
				ReferenceSchemaUId = new Guid("9db2a9f8-c736-4323-b8de-55371bf53f6b"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5d3f02cf-a6d8-4352-ad7f-1610697d7dd4"),
				ModifiedInSchemaUId = new Guid("5d3f02cf-a6d8-4352-ad7f-1610697d7dd4"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateHasTraceDataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("8f641a97-3b61-45a3-8438-612e757dd014"),
				Name = @"HasTraceData",
				CreatedInSchemaUId = new Guid("5d3f02cf-a6d8-4352-ad7f-1610697d7dd4"),
				ModifiedInSchemaUId = new Guid("5d3f02cf-a6d8-4352-ad7f-1610697d7dd4"),
				CreatedInPackageId = new Guid("79d5e1e4-18af-4001-8dc1-26f09fca92c2")
			};
		}

		protected virtual EntitySchemaColumn CreateDurationInSecondsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float1")) {
				UId = new Guid("ea779696-5e24-4b01-82ec-4b87c9541dc0"),
				Name = @"DurationInSeconds",
				CreatedInSchemaUId = new Guid("5d3f02cf-a6d8-4352-ad7f-1610697d7dd4"),
				ModifiedInSchemaUId = new Guid("5d3f02cf-a6d8-4352-ad7f-1610697d7dd4"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwSysProcessElementLogEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwSysProcessElementLogEventsProcessSchema() {
			var schema = new VwSysProcessElementLogEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwSysProcessElementLog(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwSysProcessElementLog_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwSysProcessElementLogSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwSysProcessElementLogSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5d3f02cf-a6d8-4352-ad7f-1610697d7dd4"));
		}

		#endregion

	}

	#endregion

	#region Class: VwSysProcessElementLog

	/// <summary>
	/// Process items log.
	/// </summary>
	public class VwSysProcessElementLog : Terrasoft.Configuration.SysBasePrcElLog
	{

		#region Constructors: Public

		public VwSysProcessElementLog(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwSysProcessElementLog";
		}

		public VwSysProcessElementLog(VwSysProcessElementLog source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Archived.
		/// </summary>
		public bool Archived {
			get {
				return GetTypedColumnValue<bool>("Archived");
			}
			set {
				SetColumnValue("Archived", value);
			}
		}

		/// <exclude/>
		public Guid SysProcessId {
			get {
				return GetTypedColumnValue<Guid>("SysProcessId");
			}
			set {
				SetColumnValue("SysProcessId", value);
				_sysProcess = null;
			}
		}

		/// <exclude/>
		public string SysProcessName {
			get {
				return GetTypedColumnValue<string>("SysProcessName");
			}
			set {
				SetColumnValue("SysProcessName", value);
				if (_sysProcess != null) {
					_sysProcess.Name = value;
				}
			}
		}

		private VwSysProcessLog _sysProcess;
		/// <summary>
		/// Process instance.
		/// </summary>
		public VwSysProcessLog SysProcess {
			get {
				return _sysProcess ??
					(_sysProcess = LookupColumnEntities.GetEntity("SysProcess") as VwSysProcessLog);
			}
		}

		/// <summary>
		/// Trace data exists.
		/// </summary>
		public bool HasTraceData {
			get {
				return GetTypedColumnValue<bool>("HasTraceData");
			}
			set {
				SetColumnValue("HasTraceData", value);
			}
		}

		/// <summary>
		/// Duration, seconds.
		/// </summary>
		public Decimal DurationInSeconds {
			get {
				return GetTypedColumnValue<Decimal>("DurationInSeconds");
			}
			set {
				SetColumnValue("DurationInSeconds", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwSysProcessElementLog_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwSysProcessElementLogDeleted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwSysProcessElementLog(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwSysProcessElementLog_BaseEventsProcess

	/// <exclude/>
	public partial class VwSysProcessElementLog_BaseEventsProcess<TEntity> : Terrasoft.Configuration.SysBasePrcElLog_BaseEventsProcess<TEntity> where TEntity : VwSysProcessElementLog
	{

		public VwSysProcessElementLog_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwSysProcessElementLog_BaseEventsProcess";
			SchemaUId = new Guid("5d3f02cf-a6d8-4352-ad7f-1610697d7dd4");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5d3f02cf-a6d8-4352-ad7f-1610697d7dd4");
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

	#region Class: VwSysProcessElementLog_BaseEventsProcess

	/// <exclude/>
	public class VwSysProcessElementLog_BaseEventsProcess : VwSysProcessElementLog_BaseEventsProcess<VwSysProcessElementLog>
	{

		public VwSysProcessElementLog_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwSysProcessElementLog_BaseEventsProcess

	public partial class VwSysProcessElementLog_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: VwSysProcessElementLogEventsProcessSchema

	/// <exclude/>
	public class VwSysProcessElementLogEventsProcessSchema : Terrasoft.Configuration.SysBasePrcElLogEventsProcessSchema
	{

		#region Constructors: Public

		public VwSysProcessElementLogEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwSysProcessElementLogEventsProcessSchema(VwSysProcessElementLogEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwSysProcessElementLog_BaseEventsProcess";
			UId = new Guid("af7fd131-1a23-4287-ad1d-c6a207ee10ec");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("d92550ae-1021-476e-a142-0db24fcc48d9");
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
			return new VwSysProcessElementLogEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("af7fd131-1a23-4287-ad1d-c6a207ee10ec"));
		}

		#endregion

	}

	#endregion


	#region Class: VwSysProcessElementLogEventsProcess

	/// <exclude/>
	public class VwSysProcessElementLogEventsProcess : VwSysProcessElementLog_BaseEventsProcess
	{

		public VwSysProcessElementLogEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

