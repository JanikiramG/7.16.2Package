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

	#region Class: SysPrcElementTraceLogSchema

	/// <exclude/>
	public class SysPrcElementTraceLogSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysPrcElementTraceLogSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysPrcElementTraceLogSchema(SysPrcElementTraceLogSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysPrcElementTraceLogSchema(SysPrcElementTraceLogSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("330bb874-aa5d-4449-887d-fe649f89f9e5");
			RealUId = new Guid("330bb874-aa5d-4449-887d-fe649f89f9e5");
			Name = "SysPrcElementTraceLog";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("6b752d82-945c-4729-b067-d3f384b1bc2d");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("2c390fe5-a97d-4685-b004-24cbfad1f54a")) == null) {
				Columns.Add(CreateTraceEventColumn());
			}
			if (Columns.FindByUId(new Guid("56bbd4ec-cb97-4d31-a065-aac2da13ee67")) == null) {
				Columns.Add(CreateElementDataColumn());
			}
			if (Columns.FindByUId(new Guid("60aefb0c-1625-4a6f-a736-dc7316e31d7e")) == null) {
				Columns.Add(CreateProcessDataColumn());
			}
			if (Columns.FindByUId(new Guid("9edc97a6-c8aa-41b3-a75c-4f027858f0d4")) == null) {
				Columns.Add(CreateSysProcessElementLogColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateTraceEventColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("2c390fe5-a97d-4685-b004-24cbfad1f54a"),
				Name = @"TraceEvent",
				IsWeakReference = true,
				CreatedInSchemaUId = new Guid("330bb874-aa5d-4449-887d-fe649f89f9e5"),
				ModifiedInSchemaUId = new Guid("330bb874-aa5d-4449-887d-fe649f89f9e5"),
				CreatedInPackageId = new Guid("6b752d82-945c-4729-b067-d3f384b1bc2d")
			};
		}

		protected virtual EntitySchemaColumn CreateElementDataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("56bbd4ec-cb97-4d31-a065-aac2da13ee67"),
				Name = @"ElementData",
				IsWeakReference = true,
				CreatedInSchemaUId = new Guid("330bb874-aa5d-4449-887d-fe649f89f9e5"),
				ModifiedInSchemaUId = new Guid("330bb874-aa5d-4449-887d-fe649f89f9e5"),
				CreatedInPackageId = new Guid("6b752d82-945c-4729-b067-d3f384b1bc2d")
			};
		}

		protected virtual EntitySchemaColumn CreateProcessDataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("60aefb0c-1625-4a6f-a736-dc7316e31d7e"),
				Name = @"ProcessData",
				IsWeakReference = true,
				CreatedInSchemaUId = new Guid("330bb874-aa5d-4449-887d-fe649f89f9e5"),
				ModifiedInSchemaUId = new Guid("330bb874-aa5d-4449-887d-fe649f89f9e5"),
				CreatedInPackageId = new Guid("6b752d82-945c-4729-b067-d3f384b1bc2d")
			};
		}

		protected virtual EntitySchemaColumn CreateSysProcessElementLogColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("9edc97a6-c8aa-41b3-a75c-4f027858f0d4"),
				Name = @"SysProcessElementLog",
				ReferenceSchemaUId = new Guid("ff6c1cb5-16bf-4f8c-adc8-64c0b7762151"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("330bb874-aa5d-4449-887d-fe649f89f9e5"),
				ModifiedInSchemaUId = new Guid("330bb874-aa5d-4449-887d-fe649f89f9e5"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysPrcElementTraceLogEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysPrcElementTraceLogEventsProcessSchema() {
			var schema = new SysPrcElementTraceLogEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysPrcElementTraceLog(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysPrcElementTraceLog_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysPrcElementTraceLogSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysPrcElementTraceLogSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("330bb874-aa5d-4449-887d-fe649f89f9e5"));
		}

		#endregion

	}

	#endregion

	#region Class: SysPrcElementTraceLog

	/// <summary>
	/// SysPrcElementTraceLog.
	/// </summary>
	public class SysPrcElementTraceLog : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysPrcElementTraceLog(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysPrcElementTraceLog";
		}

		public SysPrcElementTraceLog(SysPrcElementTraceLog source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// TraceEvent.
		/// </summary>
		public int TraceEvent {
			get {
				return GetTypedColumnValue<int>("TraceEvent");
			}
			set {
				SetColumnValue("TraceEvent", value);
			}
		}

		/// <summary>
		/// ElementData.
		/// </summary>
		public string ElementData {
			get {
				return GetTypedColumnValue<string>("ElementData");
			}
			set {
				SetColumnValue("ElementData", value);
			}
		}

		/// <summary>
		/// ProcessData.
		/// </summary>
		public string ProcessData {
			get {
				return GetTypedColumnValue<string>("ProcessData");
			}
			set {
				SetColumnValue("ProcessData", value);
			}
		}

		/// <exclude/>
		public Guid SysProcessElementLogId {
			get {
				return GetTypedColumnValue<Guid>("SysProcessElementLogId");
			}
			set {
				SetColumnValue("SysProcessElementLogId", value);
				_sysProcessElementLog = null;
			}
		}

		/// <exclude/>
		public string SysProcessElementLogCaption {
			get {
				return GetTypedColumnValue<string>("SysProcessElementLogCaption");
			}
			set {
				SetColumnValue("SysProcessElementLogCaption", value);
				if (_sysProcessElementLog != null) {
					_sysProcessElementLog.Caption = value;
				}
			}
		}

		private SysProcessElementLog _sysProcessElementLog;
		/// <summary>
		/// SysProcessElementLog.
		/// </summary>
		public SysProcessElementLog SysProcessElementLog {
			get {
				return _sysProcessElementLog ??
					(_sysProcessElementLog = LookupColumnEntities.GetEntity("SysProcessElementLog") as SysProcessElementLog);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysPrcElementTraceLog_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysPrcElementTraceLogDeleted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysPrcElementTraceLog(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysPrcElementTraceLog_BaseEventsProcess

	/// <exclude/>
	public partial class SysPrcElementTraceLog_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysPrcElementTraceLog
	{

		public SysPrcElementTraceLog_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysPrcElementTraceLog_BaseEventsProcess";
			SchemaUId = new Guid("330bb874-aa5d-4449-887d-fe649f89f9e5");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("330bb874-aa5d-4449-887d-fe649f89f9e5");
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

	#region Class: SysPrcElementTraceLog_BaseEventsProcess

	/// <exclude/>
	public class SysPrcElementTraceLog_BaseEventsProcess : SysPrcElementTraceLog_BaseEventsProcess<SysPrcElementTraceLog>
	{

		public SysPrcElementTraceLog_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysPrcElementTraceLog_BaseEventsProcess

	public partial class SysPrcElementTraceLog_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysPrcElementTraceLogEventsProcessSchema

	/// <exclude/>
	public class SysPrcElementTraceLogEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysPrcElementTraceLogEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysPrcElementTraceLogEventsProcessSchema(SysPrcElementTraceLogEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysPrcElementTraceLog_BaseEventsProcess";
			UId = new Guid("300a5b41-0816-40ea-a144-79b9826f74bb");
			CreatedInPackageId = new Guid("6b752d82-945c-4729-b067-d3f384b1bc2d");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
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
			return new SysPrcElementTraceLogEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("300a5b41-0816-40ea-a144-79b9826f74bb"));
		}

		#endregion

	}

	#endregion


	#region Class: SysPrcElementTraceLogEventsProcess

	/// <exclude/>
	public class SysPrcElementTraceLogEventsProcess : SysPrcElementTraceLog_BaseEventsProcess
	{

		public SysPrcElementTraceLogEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

