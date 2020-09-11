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

	#region Class: SysPackageReferenceAssemblySchema

	/// <exclude/>
	public class SysPackageReferenceAssemblySchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysPackageReferenceAssemblySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysPackageReferenceAssemblySchema(SysPackageReferenceAssemblySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysPackageReferenceAssemblySchema(SysPackageReferenceAssemblySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5ace0879-2978-4c92-9589-3feccd2ec9f8");
			RealUId = new Guid("5ace0879-2978-4c92-9589-3feccd2ec9f8");
			Name = "SysPackageReferenceAssembly";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("35032b37-1853-4f03-b095-ab0b571fc943")) == null) {
				Columns.Add(CreateUIdColumn());
			}
			if (Columns.FindByUId(new Guid("2705c026-08b6-4eab-b7f8-245c4625dfd6")) == null) {
				Columns.Add(CreateNameColumn());
			}
			if (Columns.FindByUId(new Guid("2c634e49-c002-4fa2-bab0-f72869d5cb63")) == null) {
				Columns.Add(CreateDataColumn());
			}
			if (Columns.FindByUId(new Guid("a69a40f5-dc79-400f-ae6b-7b6afded773a")) == null) {
				Columns.Add(CreateSysPackageColumn());
			}
			if (Columns.FindByUId(new Guid("fb2b546f-23f3-44a7-9223-9c2cd6758c90")) == null) {
				Columns.Add(CreateFullNameColumn());
			}
			if (Columns.FindByUId(new Guid("3a334b24-c670-4f56-a056-55f0ff690565")) == null) {
				Columns.Add(CreateLoadOnAppStartColumn());
			}
			if (Columns.FindByUId(new Guid("2b19941c-8b36-4963-8fb8-87f4ec57078f")) == null) {
				Columns.Add(CreateIsNetStandardColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("35032b37-1853-4f03-b095-ab0b571fc943"),
				Name = @"UId",
				CreatedInSchemaUId = new Guid("5ace0879-2978-4c92-9589-3feccd2ec9f8"),
				ModifiedInSchemaUId = new Guid("5ace0879-2978-4c92-9589-3feccd2ec9f8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("2705c026-08b6-4eab-b7f8-245c4625dfd6"),
				Name = @"Name",
				CreatedInSchemaUId = new Guid("5ace0879-2978-4c92-9589-3feccd2ec9f8"),
				ModifiedInSchemaUId = new Guid("5ace0879-2978-4c92-9589-3feccd2ec9f8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateDataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Binary")) {
				UId = new Guid("2c634e49-c002-4fa2-bab0-f72869d5cb63"),
				Name = @"Data",
				CreatedInSchemaUId = new Guid("5ace0879-2978-4c92-9589-3feccd2ec9f8"),
				ModifiedInSchemaUId = new Guid("5ace0879-2978-4c92-9589-3feccd2ec9f8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSysPackageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a69a40f5-dc79-400f-ae6b-7b6afded773a"),
				Name = @"SysPackage",
				ReferenceSchemaUId = new Guid("ca400a85-ec48-4b42-8e50-271929d27871"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("5ace0879-2978-4c92-9589-3feccd2ec9f8"),
				ModifiedInSchemaUId = new Guid("5ace0879-2978-4c92-9589-3feccd2ec9f8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateFullNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("fb2b546f-23f3-44a7-9223-9c2cd6758c90"),
				Name = @"FullName",
				CreatedInSchemaUId = new Guid("5ace0879-2978-4c92-9589-3feccd2ec9f8"),
				ModifiedInSchemaUId = new Guid("5ace0879-2978-4c92-9589-3feccd2ec9f8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateLoadOnAppStartColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("3a334b24-c670-4f56-a056-55f0ff690565"),
				Name = @"LoadOnAppStart",
				CreatedInSchemaUId = new Guid("5ace0879-2978-4c92-9589-3feccd2ec9f8"),
				ModifiedInSchemaUId = new Guid("5ace0879-2978-4c92-9589-3feccd2ec9f8"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateIsNetStandardColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("2b19941c-8b36-4963-8fb8-87f4ec57078f"),
				Name = @"IsNetStandard",
				CreatedInSchemaUId = new Guid("5ace0879-2978-4c92-9589-3feccd2ec9f8"),
				ModifiedInSchemaUId = new Guid("5ace0879-2978-4c92-9589-3feccd2ec9f8"),
				CreatedInPackageId = new Guid("cf097749-3e35-4668-a7a8-6c36baac79a9")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysPackageReferenceAssemblyEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysPackageReferenceAssemblyEventsProcessSchema() {
			var schema = new SysPackageReferenceAssemblyEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysPackageReferenceAssembly(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysPackageReferenceAssembly_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysPackageReferenceAssemblySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysPackageReferenceAssemblySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5ace0879-2978-4c92-9589-3feccd2ec9f8"));
		}

		#endregion

	}

	#endregion

	#region Class: SysPackageReferenceAssembly

	/// <summary>
	/// Package builds.
	/// </summary>
	public class SysPackageReferenceAssembly : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysPackageReferenceAssembly(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysPackageReferenceAssembly";
		}

		public SysPackageReferenceAssembly(SysPackageReferenceAssembly source)
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

		/// <exclude/>
		public Guid SysPackageId {
			get {
				return GetTypedColumnValue<Guid>("SysPackageId");
			}
			set {
				SetColumnValue("SysPackageId", value);
				_sysPackage = null;
			}
		}

		/// <exclude/>
		public string SysPackageName {
			get {
				return GetTypedColumnValue<string>("SysPackageName");
			}
			set {
				SetColumnValue("SysPackageName", value);
				if (_sysPackage != null) {
					_sysPackage.Name = value;
				}
			}
		}

		private SysPackage _sysPackage;
		/// <summary>
		/// Package.
		/// </summary>
		public SysPackage SysPackage {
			get {
				return _sysPackage ??
					(_sysPackage = LookupColumnEntities.GetEntity("SysPackage") as SysPackage);
			}
		}

		/// <summary>
		/// Full name.
		/// </summary>
		public string FullName {
			get {
				return GetTypedColumnValue<string>("FullName");
			}
			set {
				SetColumnValue("FullName", value);
			}
		}

		/// <summary>
		/// Load Assembly to AppDomain On Application Start.
		/// </summary>
		public bool LoadOnAppStart {
			get {
				return GetTypedColumnValue<bool>("LoadOnAppStart");
			}
			set {
				SetColumnValue("LoadOnAppStart", value);
			}
		}

		/// <summary>
		/// .Net Standard Compatible.
		/// </summary>
		public bool IsNetStandard {
			get {
				return GetTypedColumnValue<bool>("IsNetStandard");
			}
			set {
				SetColumnValue("IsNetStandard", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysPackageReferenceAssembly_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysPackageReferenceAssemblyDeleted", e);
			Inserting += (s, e) => ThrowEvent("SysPackageReferenceAssemblyInserting", e);
			Validating += (s, e) => ThrowEvent("SysPackageReferenceAssemblyValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysPackageReferenceAssembly(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysPackageReferenceAssembly_BaseEventsProcess

	/// <exclude/>
	public partial class SysPackageReferenceAssembly_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysPackageReferenceAssembly
	{

		public SysPackageReferenceAssembly_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysPackageReferenceAssembly_BaseEventsProcess";
			SchemaUId = new Guid("5ace0879-2978-4c92-9589-3feccd2ec9f8");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5ace0879-2978-4c92-9589-3feccd2ec9f8");
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

	#region Class: SysPackageReferenceAssembly_BaseEventsProcess

	/// <exclude/>
	public class SysPackageReferenceAssembly_BaseEventsProcess : SysPackageReferenceAssembly_BaseEventsProcess<SysPackageReferenceAssembly>
	{

		public SysPackageReferenceAssembly_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysPackageReferenceAssembly_BaseEventsProcess

	public partial class SysPackageReferenceAssembly_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysPackageReferenceAssemblyEventsProcessSchema

	/// <exclude/>
	public class SysPackageReferenceAssemblyEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysPackageReferenceAssemblyEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysPackageReferenceAssemblyEventsProcessSchema(SysPackageReferenceAssemblyEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysPackageReferenceAssembly_BaseEventsProcess";
			UId = new Guid("5b801069-b934-4fc7-9833-6dda854f029d");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
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
			return new SysPackageReferenceAssemblyEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5b801069-b934-4fc7-9833-6dda854f029d"));
		}

		#endregion

	}

	#endregion


	#region Class: SysPackageReferenceAssemblyEventsProcess

	/// <exclude/>
	public class SysPackageReferenceAssemblyEventsProcess : SysPackageReferenceAssembly_BaseEventsProcess
	{

		public SysPackageReferenceAssemblyEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

