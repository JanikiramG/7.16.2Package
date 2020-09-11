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

	#region Class: VwSysProcessLogSchema

	/// <exclude/>
	public class VwSysProcessLogSchema : Terrasoft.Configuration.SysProcessLogSchema
	{

		#region Constructors: Public

		public VwSysProcessLogSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwSysProcessLogSchema(VwSysProcessLogSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwSysProcessLogSchema(VwSysProcessLogSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9db2a9f8-c736-4323-b8de-55371bf53f6b");
			RealUId = new Guid("9db2a9f8-c736-4323-b8de-55371bf53f6b");
			Name = "VwSysProcessLog";
			ParentSchemaUId = new Guid("ac2d8e0f-a926-4f76-a1fa-604d5eaaa1d2");
			ExtendParent = false;
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			IsDBView = true;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("8756e5fb-6161-4877-8b62-5a2786bca3ff")) == null) {
				Columns.Add(CreateArchivedColumn());
			}
			if (Columns.FindByUId(new Guid("a1918e8a-f2e6-4394-921a-17adb901e8aa")) == null) {
				Columns.Add(CreateDurationInSecondsColumn());
			}
			if (Columns.FindByUId(new Guid("2db6540c-a7ae-4091-9abb-2e0969442fd6")) == null) {
				Columns.Add(CreateHasTraceDataColumn());
			}
		}

		protected override EntitySchemaColumn CreateParentColumn() {
			EntitySchemaColumn column = base.CreateParentColumn();
			column.ReferenceSchemaUId = new Guid("9db2a9f8-c736-4323-b8de-55371bf53f6b");
			column.ColumnValueName = @"ParentId";
			column.DisplayColumnValueName = @"ParentName";
			column.ModifiedInSchemaUId = new Guid("9db2a9f8-c736-4323-b8de-55371bf53f6b");
			return column;
		}

		protected virtual EntitySchemaColumn CreateArchivedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("8756e5fb-6161-4877-8b62-5a2786bca3ff"),
				Name = @"Archived",
				CreatedInSchemaUId = new Guid("9db2a9f8-c736-4323-b8de-55371bf53f6b"),
				ModifiedInSchemaUId = new Guid("9db2a9f8-c736-4323-b8de-55371bf53f6b"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateDurationInSecondsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float1")) {
				UId = new Guid("a1918e8a-f2e6-4394-921a-17adb901e8aa"),
				Name = @"DurationInSeconds",
				CreatedInSchemaUId = new Guid("9db2a9f8-c736-4323-b8de-55371bf53f6b"),
				ModifiedInSchemaUId = new Guid("9db2a9f8-c736-4323-b8de-55371bf53f6b"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateHasTraceDataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("2db6540c-a7ae-4091-9abb-2e0969442fd6"),
				Name = @"HasTraceData",
				CreatedInSchemaUId = new Guid("9db2a9f8-c736-4323-b8de-55371bf53f6b"),
				ModifiedInSchemaUId = new Guid("9db2a9f8-c736-4323-b8de-55371bf53f6b"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwSysProcessLogEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwSysProcessLogEventsProcessSchema() {
			var schema = new VwSysProcessLogEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwSysProcessLog(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwSysProcessLog_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwSysProcessLogSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwSysProcessLogSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9db2a9f8-c736-4323-b8de-55371bf53f6b"));
		}

		#endregion

	}

	#endregion

	#region Class: VwSysProcessLog

	/// <summary>
	/// Process log.
	/// </summary>
	public class VwSysProcessLog : Terrasoft.Configuration.SysProcessLog
	{

		#region Constructors: Public

		public VwSysProcessLog(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwSysProcessLog";
		}

		public VwSysProcessLog(VwSysProcessLog source)
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

		/// <summary>
		/// Trace data available.
		/// </summary>
		public bool HasTraceData {
			get {
				return GetTypedColumnValue<bool>("HasTraceData");
			}
			set {
				SetColumnValue("HasTraceData", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwSysProcessLog_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwSysProcessLogDeleted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwSysProcessLog(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwSysProcessLog_BaseEventsProcess

	/// <exclude/>
	public partial class VwSysProcessLog_BaseEventsProcess<TEntity> : Terrasoft.Configuration.SysProcessLog_PRMPortalEventsProcess<TEntity> where TEntity : VwSysProcessLog
	{

		public VwSysProcessLog_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwSysProcessLog_BaseEventsProcess";
			SchemaUId = new Guid("9db2a9f8-c736-4323-b8de-55371bf53f6b");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("9db2a9f8-c736-4323-b8de-55371bf53f6b");
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

	#region Class: VwSysProcessLog_BaseEventsProcess

	/// <exclude/>
	public class VwSysProcessLog_BaseEventsProcess : VwSysProcessLog_BaseEventsProcess<VwSysProcessLog>
	{

		public VwSysProcessLog_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwSysProcessLog_BaseEventsProcess

	public partial class VwSysProcessLog_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: VwSysProcessLogEventsProcessSchema

	/// <exclude/>
	public class VwSysProcessLogEventsProcessSchema : Terrasoft.Configuration.SysProcessLogEventsProcessSchema
	{

		#region Constructors: Public

		public VwSysProcessLogEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwSysProcessLogEventsProcessSchema(VwSysProcessLogEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwSysProcessLog_BaseEventsProcess";
			UId = new Guid("9b9f1b7b-d121-4ac2-aa4d-f6b49086ba8b");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("f685f4de-9734-4c81-beed-7dd6ccbdac60");
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
			return new VwSysProcessLogEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9b9f1b7b-d121-4ac2-aa4d-f6b49086ba8b"));
		}

		#endregion

	}

	#endregion


	#region Class: VwSysProcessLogEventsProcess

	/// <exclude/>
	public class VwSysProcessLogEventsProcess : VwSysProcessLog_BaseEventsProcess
	{

		public VwSysProcessLogEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

