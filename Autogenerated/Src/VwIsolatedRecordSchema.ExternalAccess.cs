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

	#region Class: VwIsolatedRecordSchema

	/// <exclude/>
	public class VwIsolatedRecordSchema : Terrasoft.Configuration.SysIsolatedRecordSchema
	{

		#region Constructors: Public

		public VwIsolatedRecordSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwIsolatedRecordSchema(VwIsolatedRecordSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwIsolatedRecordSchema(VwIsolatedRecordSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4a1e15a3-a526-4b0f-b362-077730219ad1");
			RealUId = new Guid("4a1e15a3-a526-4b0f-b362-077730219ad1");
			Name = "VwIsolatedRecord";
			ParentSchemaUId = new Guid("d0dba5bf-0248-4a93-9396-583751d97281");
			ExtendParent = false;
			CreatedInPackageId = new Guid("5e504a85-b356-4f9f-8a4b-82ad398dd0cf");
			IsDBView = true;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("c79ffbbb-d551-47e9-8e88-a65607f60c87")) == null) {
				Columns.Add(CreateEntitySchemaColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("da515b5b-3f53-4be6-a2bb-e8eab0fdae7f"),
				Name = @"Name",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("4a1e15a3-a526-4b0f-b362-077730219ad1"),
				ModifiedInSchemaUId = new Guid("4a1e15a3-a526-4b0f-b362-077730219ad1"),
				CreatedInPackageId = new Guid("5e504a85-b356-4f9f-8a4b-82ad398dd0cf")
			};
		}

		protected virtual EntitySchemaColumn CreateEntitySchemaColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c79ffbbb-d551-47e9-8e88-a65607f60c87"),
				Name = @"EntitySchema",
				ReferenceSchemaUId = new Guid("90fa6d02-3e93-45d6-a72b-58dcffa411ae"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("4a1e15a3-a526-4b0f-b362-077730219ad1"),
				ModifiedInSchemaUId = new Guid("4a1e15a3-a526-4b0f-b362-077730219ad1"),
				CreatedInPackageId = new Guid("5e504a85-b356-4f9f-8a4b-82ad398dd0cf")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwIsolatedRecordEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwIsolatedRecordEventsProcessSchema() {
			var schema = new VwIsolatedRecordEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwIsolatedRecord(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwIsolatedRecord_ExternalAccessEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwIsolatedRecordSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwIsolatedRecordSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4a1e15a3-a526-4b0f-b362-077730219ad1"));
		}

		#endregion

	}

	#endregion

	#region Class: VwIsolatedRecord

	/// <summary>
	/// VwIsolatedRecord.
	/// </summary>
	public class VwIsolatedRecord : Terrasoft.Configuration.SysIsolatedRecord
	{

		#region Constructors: Public

		public VwIsolatedRecord(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwIsolatedRecord";
		}

		public VwIsolatedRecord(VwIsolatedRecord source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Display value.
		/// </summary>
		public string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

		/// <exclude/>
		public Guid EntitySchemaId {
			get {
				return GetTypedColumnValue<Guid>("EntitySchemaId");
			}
			set {
				SetColumnValue("EntitySchemaId", value);
				_entitySchema = null;
			}
		}

		/// <exclude/>
		public string EntitySchemaCaption {
			get {
				return GetTypedColumnValue<string>("EntitySchemaCaption");
			}
			set {
				SetColumnValue("EntitySchemaCaption", value);
				if (_entitySchema != null) {
					_entitySchema.Caption = value;
				}
			}
		}

		private VwSysSchemaInfo _entitySchema;
		/// <summary>
		/// Entity schema.
		/// </summary>
		public VwSysSchemaInfo EntitySchema {
			get {
				return _entitySchema ??
					(_entitySchema = LookupColumnEntities.GetEntity("EntitySchema") as VwSysSchemaInfo);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwIsolatedRecord_ExternalAccessEventsProcess(UserConnection);
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
			return new VwIsolatedRecord(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwIsolatedRecord_ExternalAccessEventsProcess

	/// <exclude/>
	public partial class VwIsolatedRecord_ExternalAccessEventsProcess<TEntity> : Terrasoft.Configuration.SysIsolatedRecord_ExternalAccessEventsProcess<TEntity> where TEntity : VwIsolatedRecord
	{

		public VwIsolatedRecord_ExternalAccessEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwIsolatedRecord_ExternalAccessEventsProcess";
			SchemaUId = new Guid("4a1e15a3-a526-4b0f-b362-077730219ad1");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("4a1e15a3-a526-4b0f-b362-077730219ad1");
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

	#region Class: VwIsolatedRecord_ExternalAccessEventsProcess

	/// <exclude/>
	public class VwIsolatedRecord_ExternalAccessEventsProcess : VwIsolatedRecord_ExternalAccessEventsProcess<VwIsolatedRecord>
	{

		public VwIsolatedRecord_ExternalAccessEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwIsolatedRecord_ExternalAccessEventsProcess

	public partial class VwIsolatedRecord_ExternalAccessEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: VwIsolatedRecordEventsProcessSchema

	/// <exclude/>
	public class VwIsolatedRecordEventsProcessSchema : Terrasoft.Configuration.SysIsolatedRecordEventsProcessSchema
	{

		#region Constructors: Public

		public VwIsolatedRecordEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwIsolatedRecordEventsProcessSchema(VwIsolatedRecordEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwIsolatedRecord_ExternalAccessEventsProcess";
			UId = new Guid("ce3d5a13-f367-45a6-a2a0-90c34e671102");
			CreatedInPackageId = new Guid("5e504a85-b356-4f9f-8a4b-82ad398dd0cf");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("f498d043-0b86-4857-a196-338242b1f3a1");
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
			return new VwIsolatedRecordEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ce3d5a13-f367-45a6-a2a0-90c34e671102"));
		}

		#endregion

	}

	#endregion


	#region Class: VwIsolatedRecordEventsProcess

	/// <exclude/>
	public class VwIsolatedRecordEventsProcess : VwIsolatedRecord_ExternalAccessEventsProcess
	{

		public VwIsolatedRecordEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

