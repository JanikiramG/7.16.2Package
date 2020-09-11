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

	#region Class: SysPrcElMILogSchema

	/// <exclude/>
	public class SysPrcElMILogSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysPrcElMILogSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysPrcElMILogSchema(SysPrcElMILogSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysPrcElMILogSchema(SysPrcElMILogSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6972f5f1-c1ae-424d-9c78-c66029e5bb1d");
			RealUId = new Guid("6972f5f1-c1ae-424d-9c78-c66029e5bb1d");
			Name = "SysPrcElMILog";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("3c624d29-361c-47f2-ac8f-7824eb3cde6f");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("b788f8e4-0aed-4f5f-b65a-7202fcaec1b6")) == null) {
				Columns.Add(CreateIteratorElementColumn());
			}
			if (Columns.FindByUId(new Guid("0ebca3d7-31cf-450c-b731-4e86ce1c81c0")) == null) {
				Columns.Add(CreateIterationNumberColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateIteratorElementColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b788f8e4-0aed-4f5f-b65a-7202fcaec1b6"),
				Name = @"IteratorElement",
				ReferenceSchemaUId = new Guid("ff6c1cb5-16bf-4f8c-adc8-64c0b7762151"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("6972f5f1-c1ae-424d-9c78-c66029e5bb1d"),
				ModifiedInSchemaUId = new Guid("6972f5f1-c1ae-424d-9c78-c66029e5bb1d"),
				CreatedInPackageId = new Guid("3c624d29-361c-47f2-ac8f-7824eb3cde6f")
			};
		}

		protected virtual EntitySchemaColumn CreateIterationNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("0ebca3d7-31cf-450c-b731-4e86ce1c81c0"),
				Name = @"IterationNumber",
				CreatedInSchemaUId = new Guid("6972f5f1-c1ae-424d-9c78-c66029e5bb1d"),
				ModifiedInSchemaUId = new Guid("6972f5f1-c1ae-424d-9c78-c66029e5bb1d"),
				CreatedInPackageId = new Guid("3c624d29-361c-47f2-ac8f-7824eb3cde6f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysPrcElMILogEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysPrcElMILogEventsProcessSchema() {
			var schema = new SysPrcElMILogEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysPrcElMILog(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysPrcElMILog_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysPrcElMILogSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysPrcElMILogSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6972f5f1-c1ae-424d-9c78-c66029e5bb1d"));
		}

		#endregion

	}

	#endregion

	#region Class: SysPrcElMILog

	/// <summary>
	/// Process multi-instance element log.
	/// </summary>
	public class SysPrcElMILog : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysPrcElMILog(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysPrcElMILog";
		}

		public SysPrcElMILog(SysPrcElMILog source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid IteratorElementId {
			get {
				return GetTypedColumnValue<Guid>("IteratorElementId");
			}
			set {
				SetColumnValue("IteratorElementId", value);
				_iteratorElement = null;
			}
		}

		/// <exclude/>
		public string IteratorElementCaption {
			get {
				return GetTypedColumnValue<string>("IteratorElementCaption");
			}
			set {
				SetColumnValue("IteratorElementCaption", value);
				if (_iteratorElement != null) {
					_iteratorElement.Caption = value;
				}
			}
		}

		private SysProcessElementLog _iteratorElement;
		/// <summary>
		/// IteratorElement.
		/// </summary>
		public SysProcessElementLog IteratorElement {
			get {
				return _iteratorElement ??
					(_iteratorElement = LookupColumnEntities.GetEntity("IteratorElement") as SysProcessElementLog);
			}
		}

		/// <summary>
		/// IterationNumber.
		/// </summary>
		public int IterationNumber {
			get {
				return GetTypedColumnValue<int>("IterationNumber");
			}
			set {
				SetColumnValue("IterationNumber", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysPrcElMILog_BaseEventsProcess(UserConnection);
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
			return new SysPrcElMILog(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysPrcElMILog_BaseEventsProcess

	/// <exclude/>
	public partial class SysPrcElMILog_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysPrcElMILog
	{

		public SysPrcElMILog_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysPrcElMILog_BaseEventsProcess";
			SchemaUId = new Guid("6972f5f1-c1ae-424d-9c78-c66029e5bb1d");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6972f5f1-c1ae-424d-9c78-c66029e5bb1d");
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

	#region Class: SysPrcElMILog_BaseEventsProcess

	/// <exclude/>
	public class SysPrcElMILog_BaseEventsProcess : SysPrcElMILog_BaseEventsProcess<SysPrcElMILog>
	{

		public SysPrcElMILog_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysPrcElMILog_BaseEventsProcess

	public partial class SysPrcElMILog_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysPrcElMILogEventsProcessSchema

	/// <exclude/>
	public class SysPrcElMILogEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysPrcElMILogEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysPrcElMILogEventsProcessSchema(SysPrcElMILogEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysPrcElMILog_BaseEventsProcess";
			UId = new Guid("7a6b384d-9b28-4cf4-8165-b82b329d80a6");
			CreatedInPackageId = new Guid("3c624d29-361c-47f2-ac8f-7824eb3cde6f");
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
			return new SysPrcElMILogEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7a6b384d-9b28-4cf4-8165-b82b329d80a6"));
		}

		#endregion

	}

	#endregion


	#region Class: SysPrcElMILogEventsProcess

	/// <exclude/>
	public class SysPrcElMILogEventsProcess : SysPrcElMILog_BaseEventsProcess
	{

		public SysPrcElMILogEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

