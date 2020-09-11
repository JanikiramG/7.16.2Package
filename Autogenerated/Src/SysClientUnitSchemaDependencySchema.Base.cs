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

	#region Class: SysClientUnitSchemaDependencySchema

	/// <exclude/>
	public class SysClientUnitSchemaDependencySchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysClientUnitSchemaDependencySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysClientUnitSchemaDependencySchema(SysClientUnitSchemaDependencySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysClientUnitSchemaDependencySchema(SysClientUnitSchemaDependencySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e535f9ed-74ef-4a35-9f6c-e07bacb08404");
			RealUId = new Guid("e535f9ed-74ef-4a35-9f6c-e07bacb08404");
			Name = "SysClientUnitSchemaDependency";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("6b02e0a6-3eb8-43c8-a420-e66f8d82a1d6")) == null) {
				Columns.Add(CreateUIdColumn());
			}
			if (Columns.FindByUId(new Guid("4649d729-8242-4fb3-97e2-6f0a241573cd")) == null) {
				Columns.Add(CreateCreatedInSchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("ba2b2b42-396b-432c-b2e7-e545ff56a184")) == null) {
				Columns.Add(CreateModifiedInSchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("73bc3a53-9800-4b99-bf58-6aa4ab579c6d")) == null) {
				Columns.Add(CreateNameColumn());
			}
			if (Columns.FindByUId(new Guid("ceb8ebc5-b984-4122-8121-c479ee82cac7")) == null) {
				Columns.Add(CreateSchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("ce393404-e869-422a-97d5-f18fa872e055")) == null) {
				Columns.Add(CreateManagerNameColumn());
			}
			if (Columns.FindByUId(new Guid("861cfc4b-62da-4c17-a737-c2c3e06df6b6")) == null) {
				Columns.Add(CreateSysSchemaColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("6b02e0a6-3eb8-43c8-a420-e66f8d82a1d6"),
				Name = @"UId",
				CreatedInSchemaUId = new Guid("e535f9ed-74ef-4a35-9f6c-e07bacb08404"),
				ModifiedInSchemaUId = new Guid("e535f9ed-74ef-4a35-9f6c-e07bacb08404"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateCreatedInSchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("4649d729-8242-4fb3-97e2-6f0a241573cd"),
				Name = @"CreatedInSchemaUId",
				CreatedInSchemaUId = new Guid("e535f9ed-74ef-4a35-9f6c-e07bacb08404"),
				ModifiedInSchemaUId = new Guid("e535f9ed-74ef-4a35-9f6c-e07bacb08404"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateModifiedInSchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("ba2b2b42-396b-432c-b2e7-e545ff56a184"),
				Name = @"ModifiedInSchemaUId",
				CreatedInSchemaUId = new Guid("e535f9ed-74ef-4a35-9f6c-e07bacb08404"),
				ModifiedInSchemaUId = new Guid("e535f9ed-74ef-4a35-9f6c-e07bacb08404"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("73bc3a53-9800-4b99-bf58-6aa4ab579c6d"),
				Name = @"Name",
				CreatedInSchemaUId = new Guid("e535f9ed-74ef-4a35-9f6c-e07bacb08404"),
				ModifiedInSchemaUId = new Guid("e535f9ed-74ef-4a35-9f6c-e07bacb08404"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateSchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("ceb8ebc5-b984-4122-8121-c479ee82cac7"),
				Name = @"SchemaUId",
				CreatedInSchemaUId = new Guid("e535f9ed-74ef-4a35-9f6c-e07bacb08404"),
				ModifiedInSchemaUId = new Guid("e535f9ed-74ef-4a35-9f6c-e07bacb08404"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateManagerNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("ce393404-e869-422a-97d5-f18fa872e055"),
				Name = @"ManagerName",
				CreatedInSchemaUId = new Guid("e535f9ed-74ef-4a35-9f6c-e07bacb08404"),
				ModifiedInSchemaUId = new Guid("e535f9ed-74ef-4a35-9f6c-e07bacb08404"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateSysSchemaColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("861cfc4b-62da-4c17-a737-c2c3e06df6b6"),
				Name = @"SysSchema",
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("e535f9ed-74ef-4a35-9f6c-e07bacb08404"),
				ModifiedInSchemaUId = new Guid("e535f9ed-74ef-4a35-9f6c-e07bacb08404"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysClientUnitSchemaDependencyEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysClientUnitSchemaDependencyEventsProcessSchema() {
			var schema = new SysClientUnitSchemaDependencyEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysClientUnitSchemaDependency(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysClientUnitSchemaDependency_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysClientUnitSchemaDependencySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysClientUnitSchemaDependencySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e535f9ed-74ef-4a35-9f6c-e07bacb08404"));
		}

		#endregion

	}

	#endregion

	#region Class: SysClientUnitSchemaDependency

	/// <summary>
	/// System client unit schema dependency.
	/// </summary>
	public class SysClientUnitSchemaDependency : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysClientUnitSchemaDependency(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysClientUnitSchemaDependency";
		}

		public SysClientUnitSchemaDependency(SysClientUnitSchemaDependency source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// UId.
		/// </summary>
		public Guid UId {
			get {
				return GetTypedColumnValue<Guid>("UId");
			}
			set {
				SetColumnValue("UId", value);
			}
		}

		/// <summary>
		/// CreatedInSchemaUId.
		/// </summary>
		public Guid CreatedInSchemaUId {
			get {
				return GetTypedColumnValue<Guid>("CreatedInSchemaUId");
			}
			set {
				SetColumnValue("CreatedInSchemaUId", value);
			}
		}

		/// <summary>
		/// ModifiedInSchemaUId.
		/// </summary>
		public Guid ModifiedInSchemaUId {
			get {
				return GetTypedColumnValue<Guid>("ModifiedInSchemaUId");
			}
			set {
				SetColumnValue("ModifiedInSchemaUId", value);
			}
		}

		/// <summary>
		/// Name.
		/// </summary>
		public string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

		/// <summary>
		/// SchemaUId.
		/// </summary>
		public Guid SchemaUId {
			get {
				return GetTypedColumnValue<Guid>("SchemaUId");
			}
			set {
				SetColumnValue("SchemaUId", value);
			}
		}

		/// <summary>
		/// ManagerName.
		/// </summary>
		public string ManagerName {
			get {
				return GetTypedColumnValue<string>("ManagerName");
			}
			set {
				SetColumnValue("ManagerName", value);
			}
		}

		/// <exclude/>
		public Guid SysSchemaId {
			get {
				return GetTypedColumnValue<Guid>("SysSchemaId");
			}
			set {
				SetColumnValue("SysSchemaId", value);
				_sysSchema = null;
			}
		}

		/// <exclude/>
		public string SysSchemaCaption {
			get {
				return GetTypedColumnValue<string>("SysSchemaCaption");
			}
			set {
				SetColumnValue("SysSchemaCaption", value);
				if (_sysSchema != null) {
					_sysSchema.Caption = value;
				}
			}
		}

		private SysSchema _sysSchema;
		/// <summary>
		/// SchemaId.
		/// </summary>
		public SysSchema SysSchema {
			get {
				return _sysSchema ??
					(_sysSchema = LookupColumnEntities.GetEntity("SysSchema") as SysSchema);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysClientUnitSchemaDependency_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysClientUnitSchemaDependencyDeleted", e);
			Validating += (s, e) => ThrowEvent("SysClientUnitSchemaDependencyValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysClientUnitSchemaDependency(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysClientUnitSchemaDependency_BaseEventsProcess

	/// <exclude/>
	public partial class SysClientUnitSchemaDependency_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysClientUnitSchemaDependency
	{

		public SysClientUnitSchemaDependency_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysClientUnitSchemaDependency_BaseEventsProcess";
			SchemaUId = new Guid("e535f9ed-74ef-4a35-9f6c-e07bacb08404");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e535f9ed-74ef-4a35-9f6c-e07bacb08404");
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

	#region Class: SysClientUnitSchemaDependency_BaseEventsProcess

	/// <exclude/>
	public class SysClientUnitSchemaDependency_BaseEventsProcess : SysClientUnitSchemaDependency_BaseEventsProcess<SysClientUnitSchemaDependency>
	{

		public SysClientUnitSchemaDependency_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysClientUnitSchemaDependency_BaseEventsProcess

	public partial class SysClientUnitSchemaDependency_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysClientUnitSchemaDependencyEventsProcessSchema

	/// <exclude/>
	public class SysClientUnitSchemaDependencyEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysClientUnitSchemaDependencyEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysClientUnitSchemaDependencyEventsProcessSchema(SysClientUnitSchemaDependencyEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysClientUnitSchemaDependency_BaseEventsProcess";
			UId = new Guid("8e589cc5-3928-4b6f-a23c-d21a4b0c346d");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
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
			return new SysClientUnitSchemaDependencyEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8e589cc5-3928-4b6f-a23c-d21a4b0c346d"));
		}

		#endregion

	}

	#endregion


	#region Class: SysClientUnitSchemaDependencyEventsProcess

	/// <exclude/>
	public class SysClientUnitSchemaDependencyEventsProcess : SysClientUnitSchemaDependency_BaseEventsProcess
	{

		public SysClientUnitSchemaDependencyEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

