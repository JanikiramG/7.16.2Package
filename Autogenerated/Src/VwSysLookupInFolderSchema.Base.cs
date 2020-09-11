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

	#region Class: VwSysLookupInFolderSchema

	/// <exclude/>
	public class VwSysLookupInFolderSchema : Terrasoft.Configuration.BaseItemInFolderSchema
	{

		#region Constructors: Public

		public VwSysLookupInFolderSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwSysLookupInFolderSchema(VwSysLookupInFolderSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwSysLookupInFolderSchema(VwSysLookupInFolderSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f7029804-00f9-4f74-aaca-0d9a93921533");
			RealUId = new Guid("f7029804-00f9-4f74-aaca-0d9a93921533");
			Name = "VwSysLookupInFolder";
			ParentSchemaUId = new Guid("4f63bafb-e9e7-4082-b92e-66b97c14017c");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("b8e82469-336b-4300-8a0a-13bf9799d39d")) == null) {
				Columns.Add(CreateVwSysLookupColumn());
			}
		}

		protected override EntitySchemaColumn CreateFolderColumn() {
			EntitySchemaColumn column = base.CreateFolderColumn();
			column.ReferenceSchemaUId = new Guid("5403f977-1005-41a3-99a1-5ff37806bbbf");
			column.ColumnValueName = @"FolderId";
			column.DisplayColumnValueName = @"FolderName";
			column.ModifiedInSchemaUId = new Guid("f7029804-00f9-4f74-aaca-0d9a93921533");
			return column;
		}

		protected virtual EntitySchemaColumn CreateVwSysLookupColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b8e82469-336b-4300-8a0a-13bf9799d39d"),
				Name = @"VwSysLookup",
				ReferenceSchemaUId = new Guid("aa3cc352-3095-43c9-ace8-6301f50a0a80"),
				CreatedInSchemaUId = new Guid("f7029804-00f9-4f74-aaca-0d9a93921533"),
				ModifiedInSchemaUId = new Guid("f7029804-00f9-4f74-aaca-0d9a93921533"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwSysLookupInFolderEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwSysLookupInFolderEventsProcessSchema() {
			var schema = new VwSysLookupInFolderEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwSysLookupInFolder(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwSysLookupInFolder_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwSysLookupInFolderSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwSysLookupInFolderSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f7029804-00f9-4f74-aaca-0d9a93921533"));
		}

		#endregion

	}

	#endregion

	#region Class: VwSysLookupInFolder

	/// <summary>
	/// Lookup in folder (view).
	/// </summary>
	public class VwSysLookupInFolder : Terrasoft.Configuration.BaseItemInFolder
	{

		#region Constructors: Public

		public VwSysLookupInFolder(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwSysLookupInFolder";
		}

		public VwSysLookupInFolder(VwSysLookupInFolder source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid VwSysLookupId {
			get {
				return GetTypedColumnValue<Guid>("VwSysLookupId");
			}
			set {
				SetColumnValue("VwSysLookupId", value);
				_vwSysLookup = null;
			}
		}

		/// <exclude/>
		public string VwSysLookupName {
			get {
				return GetTypedColumnValue<string>("VwSysLookupName");
			}
			set {
				SetColumnValue("VwSysLookupName", value);
				if (_vwSysLookup != null) {
					_vwSysLookup.Name = value;
				}
			}
		}

		private SysLookup _vwSysLookup;
		/// <summary>
		/// Lookup.
		/// </summary>
		public SysLookup VwSysLookup {
			get {
				return _vwSysLookup ??
					(_vwSysLookup = LookupColumnEntities.GetEntity("VwSysLookup") as SysLookup);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwSysLookupInFolder_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwSysLookupInFolderDeleted", e);
			Deleting += (s, e) => ThrowEvent("VwSysLookupInFolderDeleting", e);
			Inserted += (s, e) => ThrowEvent("VwSysLookupInFolderInserted", e);
			Inserting += (s, e) => ThrowEvent("VwSysLookupInFolderInserting", e);
			Saved += (s, e) => ThrowEvent("VwSysLookupInFolderSaved", e);
			Saving += (s, e) => ThrowEvent("VwSysLookupInFolderSaving", e);
			Validating += (s, e) => ThrowEvent("VwSysLookupInFolderValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwSysLookupInFolder(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwSysLookupInFolder_BaseEventsProcess

	/// <exclude/>
	public partial class VwSysLookupInFolder_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseItemInFolder_BaseEventsProcess<TEntity> where TEntity : VwSysLookupInFolder
	{

		public VwSysLookupInFolder_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwSysLookupInFolder_BaseEventsProcess";
			SchemaUId = new Guid("f7029804-00f9-4f74-aaca-0d9a93921533");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f7029804-00f9-4f74-aaca-0d9a93921533");
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

	#region Class: VwSysLookupInFolder_BaseEventsProcess

	/// <exclude/>
	public class VwSysLookupInFolder_BaseEventsProcess : VwSysLookupInFolder_BaseEventsProcess<VwSysLookupInFolder>
	{

		public VwSysLookupInFolder_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwSysLookupInFolder_BaseEventsProcess

	public partial class VwSysLookupInFolder_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: VwSysLookupInFolderEventsProcessSchema

	/// <exclude/>
	public class VwSysLookupInFolderEventsProcessSchema : Terrasoft.Configuration.BaseItemInFolderEventsProcessSchema
	{

		#region Constructors: Public

		public VwSysLookupInFolderEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwSysLookupInFolderEventsProcessSchema(VwSysLookupInFolderEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwSysLookupInFolder_BaseEventsProcess";
			UId = new Guid("7a6a2099-6cb8-496c-a6bd-749dc424039c");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = Guid.Empty;
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
			return new VwSysLookupInFolderEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7a6a2099-6cb8-496c-a6bd-749dc424039c"));
		}

		#endregion

	}

	#endregion


	#region Class: VwSysLookupInFolderEventsProcess

	/// <exclude/>
	public class VwSysLookupInFolderEventsProcess : VwSysLookupInFolder_BaseEventsProcess
	{

		public VwSysLookupInFolderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

