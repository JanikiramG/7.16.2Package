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

	#region Class: VwProcessStartEventSchema

	/// <exclude/>
	public class VwProcessStartEventSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public VwProcessStartEventSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwProcessStartEventSchema(VwProcessStartEventSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwProcessStartEventSchema(VwProcessStartEventSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b096de9e-16fb-48f0-ab1c-537fc8c82d25");
			RealUId = new Guid("b096de9e-16fb-48f0-ab1c-537fc8c82d25");
			Name = "VwProcessStartEvent";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("f6d60a9d-cc0e-4590-a0d7-ea277724b939");
			IsDBView = true;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("a31e3bd0-f607-47c0-9711-b93c3bfb92a7")) == null) {
				Columns.Add(CreateEntitySchemaNameColumn());
			}
			if (Columns.FindByUId(new Guid("62d64411-ebbd-481b-b8b3-48f8952362e4")) == null) {
				Columns.Add(CreateRecordChangeTypeNameColumn());
			}
			if (Columns.FindByUId(new Guid("48b0b201-b27e-4791-8bd0-c667190fdeb7")) == null) {
				Columns.Add(CreateProcessElementUIdColumn());
			}
			if (Columns.FindByUId(new Guid("7554a551-2fed-4c56-89a6-87f80924f1fd")) == null) {
				Columns.Add(CreateProcessUIdColumn());
			}
			if (Columns.FindByUId(new Guid("4897c01f-6238-4d22-8ec2-230308f36869")) == null) {
				Columns.Add(CreateElementNameColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateEntitySchemaNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("a31e3bd0-f607-47c0-9711-b93c3bfb92a7"),
				Name = @"EntitySchemaName",
				CreatedInSchemaUId = new Guid("b096de9e-16fb-48f0-ab1c-537fc8c82d25"),
				ModifiedInSchemaUId = new Guid("b096de9e-16fb-48f0-ab1c-537fc8c82d25"),
				CreatedInPackageId = new Guid("f6d60a9d-cc0e-4590-a0d7-ea277724b939")
			};
		}

		protected virtual EntitySchemaColumn CreateRecordChangeTypeNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("62d64411-ebbd-481b-b8b3-48f8952362e4"),
				Name = @"RecordChangeTypeName",
				CreatedInSchemaUId = new Guid("b096de9e-16fb-48f0-ab1c-537fc8c82d25"),
				ModifiedInSchemaUId = new Guid("b096de9e-16fb-48f0-ab1c-537fc8c82d25"),
				CreatedInPackageId = new Guid("f6d60a9d-cc0e-4590-a0d7-ea277724b939")
			};
		}

		protected virtual EntitySchemaColumn CreateProcessElementUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("48b0b201-b27e-4791-8bd0-c667190fdeb7"),
				Name = @"ProcessElementUId",
				CreatedInSchemaUId = new Guid("b096de9e-16fb-48f0-ab1c-537fc8c82d25"),
				ModifiedInSchemaUId = new Guid("b096de9e-16fb-48f0-ab1c-537fc8c82d25"),
				CreatedInPackageId = new Guid("f6d60a9d-cc0e-4590-a0d7-ea277724b939")
			};
		}

		protected virtual EntitySchemaColumn CreateProcessUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("7554a551-2fed-4c56-89a6-87f80924f1fd"),
				Name = @"ProcessUId",
				CreatedInSchemaUId = new Guid("b096de9e-16fb-48f0-ab1c-537fc8c82d25"),
				ModifiedInSchemaUId = new Guid("b096de9e-16fb-48f0-ab1c-537fc8c82d25"),
				CreatedInPackageId = new Guid("f6d60a9d-cc0e-4590-a0d7-ea277724b939")
			};
		}

		protected virtual EntitySchemaColumn CreateElementNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("4897c01f-6238-4d22-8ec2-230308f36869"),
				Name = @"ElementName",
				CreatedInSchemaUId = new Guid("b096de9e-16fb-48f0-ab1c-537fc8c82d25"),
				ModifiedInSchemaUId = new Guid("b096de9e-16fb-48f0-ab1c-537fc8c82d25"),
				CreatedInPackageId = new Guid("f6d60a9d-cc0e-4590-a0d7-ea277724b939")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwProcessStartEventEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwProcessStartEventEventsProcessSchema() {
			var schema = new VwProcessStartEventEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwProcessStartEvent(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwProcessStartEvent_ProcessLibraryEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwProcessStartEventSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwProcessStartEventSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b096de9e-16fb-48f0-ab1c-537fc8c82d25"));
		}

		#endregion

	}

	#endregion

	#region Class: VwProcessStartEvent

	/// <summary>
	/// VwProcessStartEvent.
	/// </summary>
	public class VwProcessStartEvent : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public VwProcessStartEvent(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwProcessStartEvent";
		}

		public VwProcessStartEvent(VwProcessStartEvent source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Object.
		/// </summary>
		public string EntitySchemaName {
			get {
				return GetTypedColumnValue<string>("EntitySchemaName");
			}
			set {
				SetColumnValue("EntitySchemaName", value);
			}
		}

		/// <summary>
		/// Signal type.
		/// </summary>
		public string RecordChangeTypeName {
			get {
				return GetTypedColumnValue<string>("RecordChangeTypeName");
			}
			set {
				SetColumnValue("RecordChangeTypeName", value);
			}
		}

		/// <summary>
		/// ProcessElementUId.
		/// </summary>
		public Guid ProcessElementUId {
			get {
				return GetTypedColumnValue<Guid>("ProcessElementUId");
			}
			set {
				SetColumnValue("ProcessElementUId", value);
			}
		}

		/// <summary>
		/// ProcessUId.
		/// </summary>
		public Guid ProcessUId {
			get {
				return GetTypedColumnValue<Guid>("ProcessUId");
			}
			set {
				SetColumnValue("ProcessUId", value);
			}
		}

		/// <summary>
		/// Element name.
		/// </summary>
		public string ElementName {
			get {
				return GetTypedColumnValue<string>("ElementName");
			}
			set {
				SetColumnValue("ElementName", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwProcessStartEvent_ProcessLibraryEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwProcessStartEventDeleted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwProcessStartEvent(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwProcessStartEvent_ProcessLibraryEventsProcess

	/// <exclude/>
	public partial class VwProcessStartEvent_ProcessLibraryEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : VwProcessStartEvent
	{

		public VwProcessStartEvent_ProcessLibraryEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwProcessStartEvent_ProcessLibraryEventsProcess";
			SchemaUId = new Guid("b096de9e-16fb-48f0-ab1c-537fc8c82d25");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("b096de9e-16fb-48f0-ab1c-537fc8c82d25");
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

	#region Class: VwProcessStartEvent_ProcessLibraryEventsProcess

	/// <exclude/>
	public class VwProcessStartEvent_ProcessLibraryEventsProcess : VwProcessStartEvent_ProcessLibraryEventsProcess<VwProcessStartEvent>
	{

		public VwProcessStartEvent_ProcessLibraryEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwProcessStartEvent_ProcessLibraryEventsProcess

	public partial class VwProcessStartEvent_ProcessLibraryEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: VwProcessStartEventEventsProcessSchema

	/// <exclude/>
	public class VwProcessStartEventEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public VwProcessStartEventEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwProcessStartEventEventsProcessSchema(VwProcessStartEventEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwProcessStartEvent_ProcessLibraryEventsProcess";
			UId = new Guid("e48a8e74-361e-4059-9383-e4c5cbe46156");
			CreatedInPackageId = new Guid("f6d60a9d-cc0e-4590-a0d7-ea277724b939");
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
			return new VwProcessStartEventEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e48a8e74-361e-4059-9383-e4c5cbe46156"));
		}

		#endregion

	}

	#endregion


	#region Class: VwProcessStartEventEventsProcess

	/// <exclude/>
	public class VwProcessStartEventEventsProcess : VwProcessStartEvent_ProcessLibraryEventsProcess
	{

		public VwProcessStartEventEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

