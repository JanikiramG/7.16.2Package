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

	#region Class: SysProcessUserTaskFolderSchema

	/// <exclude/>
	public class SysProcessUserTaskFolderSchema : Terrasoft.Configuration.BaseFolderSchema
	{

		#region Constructors: Public

		public SysProcessUserTaskFolderSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysProcessUserTaskFolderSchema(SysProcessUserTaskFolderSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysProcessUserTaskFolderSchema(SysProcessUserTaskFolderSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4c0db497-99a8-4b79-a43e-ba17a2abf951");
			RealUId = new Guid("4c0db497-99a8-4b79-a43e-ba17a2abf951");
			Name = "SysProcessUserTaskFolder";
			ParentSchemaUId = new Guid("d602bf96-d029-4b07-9755-63c8f5cb5ed5");
			ExtendParent = false;
			CreatedInPackageId = new Guid("cf6dd8ea-641b-43ea-a946-34fe63d8f0dd");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("4c0db497-99a8-4b79-a43e-ba17a2abf951");
			column.CreatedInPackageId = new Guid("cf6dd8ea-641b-43ea-a946-34fe63d8f0dd");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("4c0db497-99a8-4b79-a43e-ba17a2abf951");
			column.CreatedInPackageId = new Guid("cf6dd8ea-641b-43ea-a946-34fe63d8f0dd");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("4c0db497-99a8-4b79-a43e-ba17a2abf951");
			column.CreatedInPackageId = new Guid("cf6dd8ea-641b-43ea-a946-34fe63d8f0dd");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("4c0db497-99a8-4b79-a43e-ba17a2abf951");
			column.CreatedInPackageId = new Guid("cf6dd8ea-641b-43ea-a946-34fe63d8f0dd");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("4c0db497-99a8-4b79-a43e-ba17a2abf951");
			column.CreatedInPackageId = new Guid("cf6dd8ea-641b-43ea-a946-34fe63d8f0dd");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("4c0db497-99a8-4b79-a43e-ba17a2abf951");
			column.CreatedInPackageId = new Guid("cf6dd8ea-641b-43ea-a946-34fe63d8f0dd");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("4c0db497-99a8-4b79-a43e-ba17a2abf951");
			column.CreatedInPackageId = new Guid("cf6dd8ea-641b-43ea-a946-34fe63d8f0dd");
			return column;
		}

		protected override EntitySchemaColumn CreateParentColumn() {
			EntitySchemaColumn column = base.CreateParentColumn();
			column.ReferenceSchemaUId = new Guid("4c0db497-99a8-4b79-a43e-ba17a2abf951");
			column.ColumnValueName = @"ParentId";
			column.DisplayColumnValueName = @"ParentName";
			column.ModifiedInSchemaUId = new Guid("4c0db497-99a8-4b79-a43e-ba17a2abf951");
			column.CreatedInPackageId = new Guid("cf6dd8ea-641b-43ea-a946-34fe63d8f0dd");
			return column;
		}

		protected override EntitySchemaColumn CreateFolderTypeColumn() {
			EntitySchemaColumn column = base.CreateFolderTypeColumn();
			column.ModifiedInSchemaUId = new Guid("4c0db497-99a8-4b79-a43e-ba17a2abf951");
			column.CreatedInPackageId = new Guid("cf6dd8ea-641b-43ea-a946-34fe63d8f0dd");
			return column;
		}

		protected override EntitySchemaColumn CreateSearchDataColumn() {
			EntitySchemaColumn column = base.CreateSearchDataColumn();
			column.ModifiedInSchemaUId = new Guid("4c0db497-99a8-4b79-a43e-ba17a2abf951");
			column.CreatedInPackageId = new Guid("cf6dd8ea-641b-43ea-a946-34fe63d8f0dd");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("4c0db497-99a8-4b79-a43e-ba17a2abf951");
			column.CreatedInPackageId = new Guid("cf6dd8ea-641b-43ea-a946-34fe63d8f0dd");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysProcessUserTaskFolderEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysProcessUserTaskFolderEventsProcessSchema() {
			var schema = new SysProcessUserTaskFolderEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysProcessUserTaskFolder(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysProcessUserTaskFolder_ProcessLibraryEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysProcessUserTaskFolderSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysProcessUserTaskFolderSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4c0db497-99a8-4b79-a43e-ba17a2abf951"));
		}

		#endregion

	}

	#endregion

	#region Class: SysProcessUserTaskFolder

	/// <summary>
	/// Section folder - "Process user tasks".
	/// </summary>
	public class SysProcessUserTaskFolder : Terrasoft.Configuration.BaseFolder
	{

		#region Constructors: Public

		public SysProcessUserTaskFolder(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysProcessUserTaskFolder";
		}

		public SysProcessUserTaskFolder(SysProcessUserTaskFolder source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ParentId {
			get {
				return GetTypedColumnValue<Guid>("ParentId");
			}
			set {
				SetColumnValue("ParentId", value);
				_parent = null;
			}
		}

		/// <exclude/>
		public string ParentName {
			get {
				return GetTypedColumnValue<string>("ParentName");
			}
			set {
				SetColumnValue("ParentName", value);
				if (_parent != null) {
					_parent.Name = value;
				}
			}
		}

		private SysProcessUserTaskFolder _parent;
		/// <summary>
		/// Parent.
		/// </summary>
		public SysProcessUserTaskFolder Parent {
			get {
				return _parent ??
					(_parent = LookupColumnEntities.GetEntity("Parent") as SysProcessUserTaskFolder);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysProcessUserTaskFolder_ProcessLibraryEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysProcessUserTaskFolderDeleted", e);
			Validating += (s, e) => ThrowEvent("SysProcessUserTaskFolderValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysProcessUserTaskFolder(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysProcessUserTaskFolder_ProcessLibraryEventsProcess

	/// <exclude/>
	public partial class SysProcessUserTaskFolder_ProcessLibraryEventsProcess<TEntity> : Terrasoft.Configuration.BaseFolder_BaseEventsProcess<TEntity> where TEntity : SysProcessUserTaskFolder
	{

		public SysProcessUserTaskFolder_ProcessLibraryEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysProcessUserTaskFolder_ProcessLibraryEventsProcess";
			SchemaUId = new Guid("4c0db497-99a8-4b79-a43e-ba17a2abf951");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("4c0db497-99a8-4b79-a43e-ba17a2abf951");
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

	#region Class: SysProcessUserTaskFolder_ProcessLibraryEventsProcess

	/// <exclude/>
	public class SysProcessUserTaskFolder_ProcessLibraryEventsProcess : SysProcessUserTaskFolder_ProcessLibraryEventsProcess<SysProcessUserTaskFolder>
	{

		public SysProcessUserTaskFolder_ProcessLibraryEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysProcessUserTaskFolder_ProcessLibraryEventsProcess

	public partial class SysProcessUserTaskFolder_ProcessLibraryEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void CheckCanManageLookups() {
			return;
		}

		#endregion

	}

	#endregion

	#region Class: SysProcessUserTaskFolderEventsProcessSchema

	/// <exclude/>
	public class SysProcessUserTaskFolderEventsProcessSchema : Terrasoft.Configuration.BaseFolderEventsProcessSchema
	{

		#region Constructors: Public

		public SysProcessUserTaskFolderEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysProcessUserTaskFolderEventsProcessSchema(SysProcessUserTaskFolderEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysProcessUserTaskFolder_ProcessLibraryEventsProcess";
			UId = new Guid("db9c9b26-ebb6-48db-b5a8-b0fb555fff20");
			CreatedInPackageId = new Guid("cf6dd8ea-641b-43ea-a946-34fe63d8f0dd");
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
				CreatedInPackageId = new Guid("cf6dd8ea-641b-43ea-a946-34fe63d8f0dd")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("cf6dd8ea-641b-43ea-a946-34fe63d8f0dd")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("cf6dd8ea-641b-43ea-a946-34fe63d8f0dd")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("cf6dd8ea-641b-43ea-a946-34fe63d8f0dd")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("cf6dd8ea-641b-43ea-a946-34fe63d8f0dd")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("cf6dd8ea-641b-43ea-a946-34fe63d8f0dd")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("cf6dd8ea-641b-43ea-a946-34fe63d8f0dd")
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
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,179,6,0,7,133,17,243,7,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysProcessUserTaskFolderEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("db9c9b26-ebb6-48db-b5a8-b0fb555fff20"));
		}

		#endregion

	}

	#endregion


	#region Class: SysProcessUserTaskFolderEventsProcess

	/// <exclude/>
	public class SysProcessUserTaskFolderEventsProcess : SysProcessUserTaskFolder_ProcessLibraryEventsProcess
	{

		public SysProcessUserTaskFolderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

