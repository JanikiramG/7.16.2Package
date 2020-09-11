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

	#region Class: AdminUnitFeatureStateSchema

	/// <exclude/>
	public class AdminUnitFeatureStateSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public AdminUnitFeatureStateSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AdminUnitFeatureStateSchema(AdminUnitFeatureStateSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AdminUnitFeatureStateSchema(AdminUnitFeatureStateSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e7bf0241-29e5-48e6-a09a-8102ae016205");
			RealUId = new Guid("e7bf0241-29e5-48e6-a09a-8102ae016205");
			Name = "AdminUnitFeatureState";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("2e3e95a4-2024-4552-b820-30e9633c8933");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("9ba728be-e5cd-451d-a74a-c4a047c374b3")) == null) {
				Columns.Add(CreateSysAdminUnitColumn());
			}
			if (Columns.FindByUId(new Guid("82b72e0d-42a3-4857-8445-0279b66e7e2c")) == null) {
				Columns.Add(CreateFeatureStateColumn());
			}
			if (Columns.FindByUId(new Guid("631177f9-f983-4787-a7aa-ced1b24ba918")) == null) {
				Columns.Add(CreateFeatureColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSysAdminUnitColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("9ba728be-e5cd-451d-a74a-c4a047c374b3"),
				Name = @"SysAdminUnit",
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("e7bf0241-29e5-48e6-a09a-8102ae016205"),
				ModifiedInSchemaUId = new Guid("e7bf0241-29e5-48e6-a09a-8102ae016205"),
				CreatedInPackageId = new Guid("2e3e95a4-2024-4552-b820-30e9633c8933")
			};
		}

		protected virtual EntitySchemaColumn CreateFeatureStateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("82b72e0d-42a3-4857-8445-0279b66e7e2c"),
				Name = @"FeatureState",
				CreatedInSchemaUId = new Guid("e7bf0241-29e5-48e6-a09a-8102ae016205"),
				ModifiedInSchemaUId = new Guid("e7bf0241-29e5-48e6-a09a-8102ae016205"),
				CreatedInPackageId = new Guid("2e3e95a4-2024-4552-b820-30e9633c8933")
			};
		}

		protected virtual EntitySchemaColumn CreateFeatureColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("631177f9-f983-4787-a7aa-ced1b24ba918"),
				Name = @"Feature",
				ReferenceSchemaUId = new Guid("28f8de6e-0c1e-4100-a868-11c6b934575f"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("e7bf0241-29e5-48e6-a09a-8102ae016205"),
				ModifiedInSchemaUId = new Guid("e7bf0241-29e5-48e6-a09a-8102ae016205"),
				CreatedInPackageId = new Guid("2e3e95a4-2024-4552-b820-30e9633c8933")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAdminUnitFeatureStateEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateAdminUnitFeatureStateEventsProcessSchema() {
			var schema = new AdminUnitFeatureStateEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new AdminUnitFeatureState(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AdminUnitFeatureState_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AdminUnitFeatureStateSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AdminUnitFeatureStateSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e7bf0241-29e5-48e6-a09a-8102ae016205"));
		}

		#endregion

	}

	#endregion

	#region Class: AdminUnitFeatureState

	/// <summary>
	/// State of feature.
	/// </summary>
	public class AdminUnitFeatureState : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public AdminUnitFeatureState(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AdminUnitFeatureState";
		}

		public AdminUnitFeatureState(AdminUnitFeatureState source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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
		/// User.
		/// </summary>
		public SysAdminUnit SysAdminUnit {
			get {
				return _sysAdminUnit ??
					(_sysAdminUnit = LookupColumnEntities.GetEntity("SysAdminUnit") as SysAdminUnit);
			}
		}

		/// <summary>
		/// State of feature.
		/// </summary>
		public int FeatureState {
			get {
				return GetTypedColumnValue<int>("FeatureState");
			}
			set {
				SetColumnValue("FeatureState", value);
			}
		}

		/// <exclude/>
		public Guid FeatureId {
			get {
				return GetTypedColumnValue<Guid>("FeatureId");
			}
			set {
				SetColumnValue("FeatureId", value);
				_feature = null;
			}
		}

		/// <exclude/>
		public string FeatureName {
			get {
				return GetTypedColumnValue<string>("FeatureName");
			}
			set {
				SetColumnValue("FeatureName", value);
				if (_feature != null) {
					_feature.Name = value;
				}
			}
		}

		private Feature _feature;
		/// <summary>
		/// Feature.
		/// </summary>
		public Feature Feature {
			get {
				return _feature ??
					(_feature = LookupColumnEntities.GetEntity("Feature") as Feature);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AdminUnitFeatureState_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AdminUnitFeatureStateDeleted", e);
			Validating += (s, e) => ThrowEvent("AdminUnitFeatureStateValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AdminUnitFeatureState(this);
		}

		#endregion

	}

	#endregion

	#region Class: AdminUnitFeatureState_BaseEventsProcess

	/// <exclude/>
	public partial class AdminUnitFeatureState_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : AdminUnitFeatureState
	{

		public AdminUnitFeatureState_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AdminUnitFeatureState_BaseEventsProcess";
			SchemaUId = new Guid("e7bf0241-29e5-48e6-a09a-8102ae016205");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e7bf0241-29e5-48e6-a09a-8102ae016205");
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

	#region Class: AdminUnitFeatureState_BaseEventsProcess

	/// <exclude/>
	public class AdminUnitFeatureState_BaseEventsProcess : AdminUnitFeatureState_BaseEventsProcess<AdminUnitFeatureState>
	{

		public AdminUnitFeatureState_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AdminUnitFeatureState_BaseEventsProcess

	public partial class AdminUnitFeatureState_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: AdminUnitFeatureStateEventsProcessSchema

	/// <exclude/>
	public class AdminUnitFeatureStateEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public AdminUnitFeatureStateEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AdminUnitFeatureStateEventsProcessSchema(AdminUnitFeatureStateEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AdminUnitFeatureState_BaseEventsProcess";
			UId = new Guid("3ab1a1a2-993c-458e-bfb7-b6053bbf38cf");
			CreatedInPackageId = new Guid("2e3e95a4-2024-4552-b820-30e9633c8933");
			CreatedInSchemaUId = Guid.Empty;
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
			return new AdminUnitFeatureStateEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3ab1a1a2-993c-458e-bfb7-b6053bbf38cf"));
		}

		#endregion

	}

	#endregion


	#region Class: AdminUnitFeatureStateEventsProcess

	/// <exclude/>
	public class AdminUnitFeatureStateEventsProcess : AdminUnitFeatureState_BaseEventsProcess
	{

		public AdminUnitFeatureStateEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

