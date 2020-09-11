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

	#region Class: VwPrcTimerScheduleSchema

	/// <exclude/>
	public class VwPrcTimerScheduleSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public VwPrcTimerScheduleSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwPrcTimerScheduleSchema(VwPrcTimerScheduleSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwPrcTimerScheduleSchema(VwPrcTimerScheduleSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("50126f2e-6974-448c-81f5-af04f890b20b");
			RealUId = new Guid("50126f2e-6974-448c-81f5-af04f890b20b");
			Name = "VwPrcTimerSchedule";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("f6d60a9d-cc0e-4590-a0d7-ea277724b939");
			IsDBView = true;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("b77e7d8b-aeb6-4796-8fc4-c305ffabd0d9")) == null) {
				Columns.Add(CreateProcessUIdColumn());
			}
			if (Columns.FindByUId(new Guid("4421c089-22be-45a4-b690-6ca4766c1e04")) == null) {
				Columns.Add(CreateElementNameColumn());
			}
			if (Columns.FindByUId(new Guid("3c589b98-25bd-449b-963e-d4423613011b")) == null) {
				Columns.Add(CreateTriggerStateColumn());
			}
			if (Columns.FindByUId(new Guid("8c2e579f-ef7d-42fd-ac88-94bbd2d46eaa")) == null) {
				Columns.Add(CreateNextFireTimeColumn());
			}
			if (Columns.FindByUId(new Guid("e07aa734-34f6-44c0-a2cb-0818eeb8958b")) == null) {
				Columns.Add(CreatePreviousFireTimeColumn());
			}
			if (Columns.FindByUId(new Guid("48c40b96-455a-4517-b7fd-89cf15512c01")) == null) {
				Columns.Add(CreateProcessElementUIdColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateProcessUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("b77e7d8b-aeb6-4796-8fc4-c305ffabd0d9"),
				Name = @"ProcessUId",
				CreatedInSchemaUId = new Guid("50126f2e-6974-448c-81f5-af04f890b20b"),
				ModifiedInSchemaUId = new Guid("50126f2e-6974-448c-81f5-af04f890b20b"),
				CreatedInPackageId = new Guid("f6d60a9d-cc0e-4590-a0d7-ea277724b939")
			};
		}

		protected virtual EntitySchemaColumn CreateElementNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("4421c089-22be-45a4-b690-6ca4766c1e04"),
				Name = @"ElementName",
				CreatedInSchemaUId = new Guid("50126f2e-6974-448c-81f5-af04f890b20b"),
				ModifiedInSchemaUId = new Guid("50126f2e-6974-448c-81f5-af04f890b20b"),
				CreatedInPackageId = new Guid("f6d60a9d-cc0e-4590-a0d7-ea277724b939")
			};
		}

		protected virtual EntitySchemaColumn CreateTriggerStateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("3c589b98-25bd-449b-963e-d4423613011b"),
				Name = @"TriggerState",
				CreatedInSchemaUId = new Guid("50126f2e-6974-448c-81f5-af04f890b20b"),
				ModifiedInSchemaUId = new Guid("50126f2e-6974-448c-81f5-af04f890b20b"),
				CreatedInPackageId = new Guid("f6d60a9d-cc0e-4590-a0d7-ea277724b939")
			};
		}

		protected virtual EntitySchemaColumn CreateNextFireTimeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("8c2e579f-ef7d-42fd-ac88-94bbd2d46eaa"),
				Name = @"NextFireTime",
				CreatedInSchemaUId = new Guid("50126f2e-6974-448c-81f5-af04f890b20b"),
				ModifiedInSchemaUId = new Guid("50126f2e-6974-448c-81f5-af04f890b20b"),
				CreatedInPackageId = new Guid("f6d60a9d-cc0e-4590-a0d7-ea277724b939")
			};
		}

		protected virtual EntitySchemaColumn CreatePreviousFireTimeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("e07aa734-34f6-44c0-a2cb-0818eeb8958b"),
				Name = @"PreviousFireTime",
				CreatedInSchemaUId = new Guid("50126f2e-6974-448c-81f5-af04f890b20b"),
				ModifiedInSchemaUId = new Guid("50126f2e-6974-448c-81f5-af04f890b20b"),
				CreatedInPackageId = new Guid("f6d60a9d-cc0e-4590-a0d7-ea277724b939")
			};
		}

		protected virtual EntitySchemaColumn CreateProcessElementUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("48c40b96-455a-4517-b7fd-89cf15512c01"),
				Name = @"ProcessElementUId",
				CreatedInSchemaUId = new Guid("50126f2e-6974-448c-81f5-af04f890b20b"),
				ModifiedInSchemaUId = new Guid("50126f2e-6974-448c-81f5-af04f890b20b"),
				CreatedInPackageId = new Guid("f6d60a9d-cc0e-4590-a0d7-ea277724b939")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwPrcTimerScheduleEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwPrcTimerScheduleEventsProcessSchema() {
			var schema = new VwPrcTimerScheduleEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwPrcTimerSchedule(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwPrcTimerSchedule_ProcessLibraryEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwPrcTimerScheduleSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwPrcTimerScheduleSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("50126f2e-6974-448c-81f5-af04f890b20b"));
		}

		#endregion

	}

	#endregion

	#region Class: VwPrcTimerSchedule

	/// <summary>
	/// VwPrcTimerSchedule.
	/// </summary>
	public class VwPrcTimerSchedule : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public VwPrcTimerSchedule(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwPrcTimerSchedule";
		}

		public VwPrcTimerSchedule(VwPrcTimerSchedule source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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

		/// <summary>
		/// Task state.
		/// </summary>
		public string TriggerState {
			get {
				return GetTypedColumnValue<string>("TriggerState");
			}
			set {
				SetColumnValue("TriggerState", value);
			}
		}

		/// <summary>
		/// Next fire time.
		/// </summary>
		public DateTime NextFireTime {
			get {
				return GetTypedColumnValue<DateTime>("NextFireTime");
			}
			set {
				SetColumnValue("NextFireTime", value);
			}
		}

		/// <summary>
		/// Previous fire time.
		/// </summary>
		public DateTime PreviousFireTime {
			get {
				return GetTypedColumnValue<DateTime>("PreviousFireTime");
			}
			set {
				SetColumnValue("PreviousFireTime", value);
			}
		}

		/// <summary>
		/// Process element.
		/// </summary>
		public Guid ProcessElementUId {
			get {
				return GetTypedColumnValue<Guid>("ProcessElementUId");
			}
			set {
				SetColumnValue("ProcessElementUId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwPrcTimerSchedule_ProcessLibraryEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwPrcTimerScheduleDeleted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwPrcTimerSchedule(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwPrcTimerSchedule_ProcessLibraryEventsProcess

	/// <exclude/>
	public partial class VwPrcTimerSchedule_ProcessLibraryEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : VwPrcTimerSchedule
	{

		public VwPrcTimerSchedule_ProcessLibraryEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwPrcTimerSchedule_ProcessLibraryEventsProcess";
			SchemaUId = new Guid("50126f2e-6974-448c-81f5-af04f890b20b");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("50126f2e-6974-448c-81f5-af04f890b20b");
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

	#region Class: VwPrcTimerSchedule_ProcessLibraryEventsProcess

	/// <exclude/>
	public class VwPrcTimerSchedule_ProcessLibraryEventsProcess : VwPrcTimerSchedule_ProcessLibraryEventsProcess<VwPrcTimerSchedule>
	{

		public VwPrcTimerSchedule_ProcessLibraryEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwPrcTimerSchedule_ProcessLibraryEventsProcess

	public partial class VwPrcTimerSchedule_ProcessLibraryEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: VwPrcTimerScheduleEventsProcessSchema

	/// <exclude/>
	public class VwPrcTimerScheduleEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public VwPrcTimerScheduleEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwPrcTimerScheduleEventsProcessSchema(VwPrcTimerScheduleEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwPrcTimerSchedule_ProcessLibraryEventsProcess";
			UId = new Guid("e776ff7a-dc2a-401d-a411-f8eb78dbb89e");
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
			return new VwPrcTimerScheduleEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e776ff7a-dc2a-401d-a411-f8eb78dbb89e"));
		}

		#endregion

	}

	#endregion


	#region Class: VwPrcTimerScheduleEventsProcess

	/// <exclude/>
	public class VwPrcTimerScheduleEventsProcess : VwPrcTimerSchedule_ProcessLibraryEventsProcess
	{

		public VwPrcTimerScheduleEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

