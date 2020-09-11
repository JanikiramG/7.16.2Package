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

	#region Class: SysDcmSettings_Base_TerrasoftSchema

	/// <exclude/>
	public class SysDcmSettings_Base_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysDcmSettings_Base_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysDcmSettings_Base_TerrasoftSchema(SysDcmSettings_Base_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysDcmSettings_Base_TerrasoftSchema(SysDcmSettings_Base_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ee9f7e0e-eab3-45ba-ae0d-67ab41858d5c");
			RealUId = new Guid("ee9f7e0e-eab3-45ba-ae0d-67ab41858d5c");
			Name = "SysDcmSettings_Base_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("c9089cd6-c7fc-4c89-ae0d-da891132232d");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("fa51db91-37a6-4df4-bbcd-8481740c5d8c")) == null) {
				Columns.Add(CreateSysModuleEntityColumn());
			}
			if (Columns.FindByUId(new Guid("beb7f6b2-f338-45ac-80a8-7177238b52a9")) == null) {
				Columns.Add(CreateStageColumnUIdColumn());
			}
			if (Columns.FindByUId(new Guid("42ed2383-1455-49ec-82df-1a184c12a398")) == null) {
				Columns.Add(CreateFiltersColumn());
			}
			if (Columns.FindByUId(new Guid("2bf9d686-2f7e-464b-a049-041c3225dc51")) == null) {
				Columns.Add(CreateDefaultSchemaUIdColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSysModuleEntityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("fa51db91-37a6-4df4-bbcd-8481740c5d8c"),
				Name = @"SysModuleEntity",
				ReferenceSchemaUId = new Guid("9c762665-90ad-497b-ac4b-45bb729630a1"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("ee9f7e0e-eab3-45ba-ae0d-67ab41858d5c"),
				ModifiedInSchemaUId = new Guid("ee9f7e0e-eab3-45ba-ae0d-67ab41858d5c"),
				CreatedInPackageId = new Guid("c9089cd6-c7fc-4c89-ae0d-da891132232d")
			};
		}

		protected virtual EntitySchemaColumn CreateStageColumnUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("beb7f6b2-f338-45ac-80a8-7177238b52a9"),
				Name = @"StageColumnUId",
				CreatedInSchemaUId = new Guid("ee9f7e0e-eab3-45ba-ae0d-67ab41858d5c"),
				ModifiedInSchemaUId = new Guid("ee9f7e0e-eab3-45ba-ae0d-67ab41858d5c"),
				CreatedInPackageId = new Guid("c9089cd6-c7fc-4c89-ae0d-da891132232d")
			};
		}

		protected virtual EntitySchemaColumn CreateFiltersColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("42ed2383-1455-49ec-82df-1a184c12a398"),
				Name = @"Filters",
				CreatedInSchemaUId = new Guid("ee9f7e0e-eab3-45ba-ae0d-67ab41858d5c"),
				ModifiedInSchemaUId = new Guid("ee9f7e0e-eab3-45ba-ae0d-67ab41858d5c"),
				CreatedInPackageId = new Guid("c9089cd6-c7fc-4c89-ae0d-da891132232d")
			};
		}

		protected virtual EntitySchemaColumn CreateDefaultSchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("2bf9d686-2f7e-464b-a049-041c3225dc51"),
				Name = @"DefaultSchemaUId",
				CreatedInSchemaUId = new Guid("ee9f7e0e-eab3-45ba-ae0d-67ab41858d5c"),
				ModifiedInSchemaUId = new Guid("ee9f7e0e-eab3-45ba-ae0d-67ab41858d5c"),
				CreatedInPackageId = new Guid("c9089cd6-c7fc-4c89-ae0d-da891132232d")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysDcmSettings_Base_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysDcmSettings_Base_TerrasoftEventsProcessSchema() {
			var schema = new SysDcmSettings_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysDcmSettings_Base_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysDcmSettings_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysDcmSettings_Base_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysDcmSettings_Base_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ee9f7e0e-eab3-45ba-ae0d-67ab41858d5c"));
		}

		#endregion

	}

	#endregion

	#region Class: SysDcmSettings_Base_Terrasoft

	/// <summary>
	/// SysDcmSettings.
	/// </summary>
	public class SysDcmSettings_Base_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysDcmSettings_Base_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysDcmSettings_Base_Terrasoft";
		}

		public SysDcmSettings_Base_Terrasoft(SysDcmSettings_Base_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid SysModuleEntityId {
			get {
				return GetTypedColumnValue<Guid>("SysModuleEntityId");
			}
			set {
				SetColumnValue("SysModuleEntityId", value);
				_sysModuleEntity = null;
			}
		}

		private SysModuleEntity _sysModuleEntity;
		/// <summary>
		/// Section object.
		/// </summary>
		public SysModuleEntity SysModuleEntity {
			get {
				return _sysModuleEntity ??
					(_sysModuleEntity = LookupColumnEntities.GetEntity("SysModuleEntity") as SysModuleEntity);
			}
		}

		/// <summary>
		/// Identifier of stage column.
		/// </summary>
		public Guid StageColumnUId {
			get {
				return GetTypedColumnValue<Guid>("StageColumnUId");
			}
			set {
				SetColumnValue("StageColumnUId", value);
			}
		}

		/// <summary>
		/// Filters.
		/// </summary>
		public string Filters {
			get {
				return GetTypedColumnValue<string>("Filters");
			}
			set {
				SetColumnValue("Filters", value);
			}
		}

		/// <summary>
		/// Default case schema.
		/// </summary>
		public Guid DefaultSchemaUId {
			get {
				return GetTypedColumnValue<Guid>("DefaultSchemaUId");
			}
			set {
				SetColumnValue("DefaultSchemaUId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysDcmSettings_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysDcmSettings_Base_TerrasoftDeleted", e);
			Validating += (s, e) => ThrowEvent("SysDcmSettings_Base_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysDcmSettings_Base_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysDcmSettings_BaseEventsProcess

	/// <exclude/>
	public partial class SysDcmSettings_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysDcmSettings_Base_Terrasoft
	{

		public SysDcmSettings_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysDcmSettings_BaseEventsProcess";
			SchemaUId = new Guid("ee9f7e0e-eab3-45ba-ae0d-67ab41858d5c");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ee9f7e0e-eab3-45ba-ae0d-67ab41858d5c");
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

	#region Class: SysDcmSettings_BaseEventsProcess

	/// <exclude/>
	public class SysDcmSettings_BaseEventsProcess : SysDcmSettings_BaseEventsProcess<SysDcmSettings_Base_Terrasoft>
	{

		public SysDcmSettings_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysDcmSettings_BaseEventsProcess

	public partial class SysDcmSettings_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysDcmSettings_Base_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class SysDcmSettings_Base_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysDcmSettings_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysDcmSettings_Base_TerrasoftEventsProcessSchema(SysDcmSettings_Base_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysDcmSettings_BaseEventsProcess";
			UId = new Guid("a466fceb-f98e-4d5f-aa14-cda038b558f9");
			CreatedInPackageId = new Guid("c9089cd6-c7fc-4c89-ae0d-da891132232d");
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
			return new SysDcmSettings_Base_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a466fceb-f98e-4d5f-aa14-cda038b558f9"));
		}

		#endregion

	}

	#endregion

}

