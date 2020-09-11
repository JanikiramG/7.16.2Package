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

	#region Class: SysWorkspaceSchema

	/// <exclude/>
	public class SysWorkspaceSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public SysWorkspaceSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysWorkspaceSchema(SysWorkspaceSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysWorkspaceSchema(SysWorkspaceSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7f9653ec-2e91-4aaa-a065-7b1d46edd292");
			RealUId = new Guid("7f9653ec-2e91-4aaa-a065-7b1d46edd292");
			Name = "SysWorkspace";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("637f91a4-3143-4f93-b60c-5006633d58d8")) == null) {
				Columns.Add(CreateIsDefaultColumn());
			}
			if (Columns.FindByUId(new Guid("03c913bc-e34d-4681-9768-7bd095fb28ab")) == null) {
				Columns.Add(CreateNumberColumn());
			}
			if (Columns.FindByUId(new Guid("0517e3b2-a4b5-47c5-971d-d885fc05b271")) == null) {
				Columns.Add(CreateVersionColumn());
			}
			if (Columns.FindByUId(new Guid("d970393a-0b3e-4eed-93e5-fdfed188ff35")) == null) {
				Columns.Add(CreateAssemblyDataColumn());
			}
			if (Columns.FindByUId(new Guid("a8c3e0db-13f1-43a1-818a-fceaa5d53767")) == null) {
				Columns.Add(CreateRepositoryUriColumn());
			}
			if (Columns.FindByUId(new Guid("398635d4-b784-422d-8eec-37078b3c268f")) == null) {
				Columns.Add(CreateWorkingCopyPathColumn());
			}
			if (Columns.FindByUId(new Guid("9ba51ca5-3a09-40c0-82e1-839d27055226")) == null) {
				Columns.Add(CreateRepositoryRevisionNumberColumn());
			}
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.IsLocalizable = false;
			column.ModifiedInSchemaUId = new Guid("7f9653ec-2e91-4aaa-a065-7b1d46edd292");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.IsLocalizable = false;
			column.ModifiedInSchemaUId = new Guid("7f9653ec-2e91-4aaa-a065-7b1d46edd292");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected virtual EntitySchemaColumn CreateIsDefaultColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("637f91a4-3143-4f93-b60c-5006633d58d8"),
				Name = @"IsDefault",
				CreatedInSchemaUId = new Guid("7f9653ec-2e91-4aaa-a065-7b1d46edd292"),
				ModifiedInSchemaUId = new Guid("7f9653ec-2e91-4aaa-a065-7b1d46edd292"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("03c913bc-e34d-4681-9768-7bd095fb28ab"),
				Name = @"Number",
				CreatedInSchemaUId = new Guid("7f9653ec-2e91-4aaa-a065-7b1d46edd292"),
				ModifiedInSchemaUId = new Guid("7f9653ec-2e91-4aaa-a065-7b1d46edd292"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateVersionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("0517e3b2-a4b5-47c5-971d-d885fc05b271"),
				Name = @"Version",
				CreatedInSchemaUId = new Guid("7f9653ec-2e91-4aaa-a065-7b1d46edd292"),
				ModifiedInSchemaUId = new Guid("7f9653ec-2e91-4aaa-a065-7b1d46edd292"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateAssemblyDataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Binary")) {
				UId = new Guid("d970393a-0b3e-4eed-93e5-fdfed188ff35"),
				Name = @"AssemblyData",
				CreatedInSchemaUId = new Guid("7f9653ec-2e91-4aaa-a065-7b1d46edd292"),
				ModifiedInSchemaUId = new Guid("7f9653ec-2e91-4aaa-a065-7b1d46edd292"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateRepositoryUriColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("a8c3e0db-13f1-43a1-818a-fceaa5d53767"),
				Name = @"RepositoryUri",
				CreatedInSchemaUId = new Guid("7f9653ec-2e91-4aaa-a065-7b1d46edd292"),
				ModifiedInSchemaUId = new Guid("7f9653ec-2e91-4aaa-a065-7b1d46edd292"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateWorkingCopyPathColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("398635d4-b784-422d-8eec-37078b3c268f"),
				Name = @"WorkingCopyPath",
				CreatedInSchemaUId = new Guid("7f9653ec-2e91-4aaa-a065-7b1d46edd292"),
				ModifiedInSchemaUId = new Guid("7f9653ec-2e91-4aaa-a065-7b1d46edd292"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateRepositoryRevisionNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("9ba51ca5-3a09-40c0-82e1-839d27055226"),
				Name = @"RepositoryRevisionNumber",
				CreatedInSchemaUId = new Guid("7f9653ec-2e91-4aaa-a065-7b1d46edd292"),
				ModifiedInSchemaUId = new Guid("7f9653ec-2e91-4aaa-a065-7b1d46edd292"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysWorkspaceEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysWorkspaceEventsProcessSchema() {
			var schema = new SysWorkspaceEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysWorkspace(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysWorkspace_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysWorkspaceSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysWorkspaceSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7f9653ec-2e91-4aaa-a065-7b1d46edd292"));
		}

		#endregion

	}

	#endregion

	#region Class: SysWorkspace

	/// <summary>
	/// User workspace.
	/// </summary>
	public class SysWorkspace : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public SysWorkspace(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysWorkspace";
		}

		public SysWorkspace(SysWorkspace source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Default.
		/// </summary>
		public bool IsDefault {
			get {
				return GetTypedColumnValue<bool>("IsDefault");
			}
			set {
				SetColumnValue("IsDefault", value);
			}
		}

		/// <summary>
		/// Number.
		/// </summary>
		public int Number {
			get {
				return GetTypedColumnValue<int>("Number");
			}
			set {
				SetColumnValue("Number", value);
			}
		}

		/// <summary>
		/// Version.
		/// </summary>
		public int Version {
			get {
				return GetTypedColumnValue<int>("Version");
			}
			set {
				SetColumnValue("Version", value);
			}
		}

		/// <summary>
		/// Repository URI.
		/// </summary>
		public string RepositoryUri {
			get {
				return GetTypedColumnValue<string>("RepositoryUri");
			}
			set {
				SetColumnValue("RepositoryUri", value);
			}
		}

		/// <summary>
		/// Working copy path.
		/// </summary>
		public string WorkingCopyPath {
			get {
				return GetTypedColumnValue<string>("WorkingCopyPath");
			}
			set {
				SetColumnValue("WorkingCopyPath", value);
			}
		}

		/// <summary>
		/// Current repository revision number.
		/// </summary>
		public int RepositoryRevisionNumber {
			get {
				return GetTypedColumnValue<int>("RepositoryRevisionNumber");
			}
			set {
				SetColumnValue("RepositoryRevisionNumber", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysWorkspace_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysWorkspaceDeleted", e);
			Inserting += (s, e) => ThrowEvent("SysWorkspaceInserting", e);
			Validating += (s, e) => ThrowEvent("SysWorkspaceValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysWorkspace(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysWorkspace_BaseEventsProcess

	/// <exclude/>
	public partial class SysWorkspace_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_BaseEventsProcess<TEntity> where TEntity : SysWorkspace
	{

		public SysWorkspace_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysWorkspace_BaseEventsProcess";
			SchemaUId = new Guid("7f9653ec-2e91-4aaa-a065-7b1d46edd292");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7f9653ec-2e91-4aaa-a065-7b1d46edd292");
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

	#region Class: SysWorkspace_BaseEventsProcess

	/// <exclude/>
	public class SysWorkspace_BaseEventsProcess : SysWorkspace_BaseEventsProcess<SysWorkspace>
	{

		public SysWorkspace_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysWorkspace_BaseEventsProcess

	public partial class SysWorkspace_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void CheckCanManageLookups() {
		}

		#endregion

	}

	#endregion

	#region Class: SysWorkspaceEventsProcessSchema

	/// <exclude/>
	public class SysWorkspaceEventsProcessSchema : Terrasoft.Configuration.BaseLookupEventsProcessSchema
	{

		#region Constructors: Public

		public SysWorkspaceEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysWorkspaceEventsProcessSchema(SysWorkspaceEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysWorkspace_BaseEventsProcess";
			UId = new Guid("a3fc40bc-2b6b-449b-ad60-0a667c2656ef");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1");
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

		protected override SchemaMethod CreateCheckCanManageLookupsMethod() {
			SchemaMethod method = base.CreateCheckCanManageLookupsMethod();
			method.IsOverride = true;
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysWorkspaceEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a3fc40bc-2b6b-449b-ad60-0a667c2656ef"));
		}

		#endregion

	}

	#endregion


	#region Class: SysWorkspaceEventsProcess

	/// <exclude/>
	public class SysWorkspaceEventsProcess : SysWorkspace_BaseEventsProcess
	{

		public SysWorkspaceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

