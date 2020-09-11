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

	#region Class: VwSysEntitySchemaInPackageSchema

	/// <exclude/>
	public class VwSysEntitySchemaInPackageSchema : Terrasoft.Configuration.VwSysSchemaInPackageSchema
	{

		#region Constructors: Public

		public VwSysEntitySchemaInPackageSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwSysEntitySchemaInPackageSchema(VwSysEntitySchemaInPackageSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwSysEntitySchemaInPackageSchema(VwSysEntitySchemaInPackageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("36541fe9-c378-4338-915c-ed29d994be05");
			RealUId = new Guid("36541fe9-c378-4338-915c-ed29d994be05");
			Name = "VwSysEntitySchemaInPackage";
			ParentSchemaUId = new Guid("a594c3c0-91bd-400f-a209-6d38cf0d7548");
			ExtendParent = false;
			CreatedInPackageId = new Guid("ef267576-b651-4b27-a127-87502a98d2e8");
			IsDBView = true;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("8706c716-59eb-4773-a426-249dd8b8566f")) == null) {
				Columns.Add(CreateIsVirtualColumn());
			}
			if (Columns.FindByUId(new Guid("f47fba3e-2467-4684-8892-d2ce18471d0c")) == null) {
				Columns.Add(CreateExtendParentColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("36541fe9-c378-4338-915c-ed29d994be05");
			column.CreatedInPackageId = new Guid("ef267576-b651-4b27-a127-87502a98d2e8");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("36541fe9-c378-4338-915c-ed29d994be05");
			column.CreatedInPackageId = new Guid("ef267576-b651-4b27-a127-87502a98d2e8");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("36541fe9-c378-4338-915c-ed29d994be05");
			column.CreatedInPackageId = new Guid("ef267576-b651-4b27-a127-87502a98d2e8");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("36541fe9-c378-4338-915c-ed29d994be05");
			column.CreatedInPackageId = new Guid("ef267576-b651-4b27-a127-87502a98d2e8");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("36541fe9-c378-4338-915c-ed29d994be05");
			column.CreatedInPackageId = new Guid("ef267576-b651-4b27-a127-87502a98d2e8");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("36541fe9-c378-4338-915c-ed29d994be05");
			column.CreatedInPackageId = new Guid("ef267576-b651-4b27-a127-87502a98d2e8");
			return column;
		}

		protected override EntitySchemaColumn CreateUIdColumn() {
			EntitySchemaColumn column = base.CreateUIdColumn();
			column.ModifiedInSchemaUId = new Guid("36541fe9-c378-4338-915c-ed29d994be05");
			column.CreatedInPackageId = new Guid("ef267576-b651-4b27-a127-87502a98d2e8");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("36541fe9-c378-4338-915c-ed29d994be05");
			column.CreatedInPackageId = new Guid("ef267576-b651-4b27-a127-87502a98d2e8");
			return column;
		}

		protected override EntitySchemaColumn CreateCaptionColumn() {
			EntitySchemaColumn column = base.CreateCaptionColumn();
			column.ModifiedInSchemaUId = new Guid("36541fe9-c378-4338-915c-ed29d994be05");
			column.CreatedInPackageId = new Guid("ef267576-b651-4b27-a127-87502a98d2e8");
			return column;
		}

		protected override EntitySchemaColumn CreateManagerNameColumn() {
			EntitySchemaColumn column = base.CreateManagerNameColumn();
			column.ModifiedInSchemaUId = new Guid("36541fe9-c378-4338-915c-ed29d994be05");
			column.CreatedInPackageId = new Guid("ef267576-b651-4b27-a127-87502a98d2e8");
			return column;
		}

		protected override EntitySchemaColumn CreateParentColumn() {
			EntitySchemaColumn column = base.CreateParentColumn();
			column.ModifiedInSchemaUId = new Guid("36541fe9-c378-4338-915c-ed29d994be05");
			column.CreatedInPackageId = new Guid("ef267576-b651-4b27-a127-87502a98d2e8");
			return column;
		}

		protected override EntitySchemaColumn CreateSysWorkspaceColumn() {
			EntitySchemaColumn column = base.CreateSysWorkspaceColumn();
			column.ModifiedInSchemaUId = new Guid("36541fe9-c378-4338-915c-ed29d994be05");
			column.CreatedInPackageId = new Guid("ef267576-b651-4b27-a127-87502a98d2e8");
			return column;
		}

		protected override EntitySchemaColumn CreateSysPackageColumn() {
			EntitySchemaColumn column = base.CreateSysPackageColumn();
			column.ModifiedInSchemaUId = new Guid("36541fe9-c378-4338-915c-ed29d994be05");
			column.CreatedInPackageId = new Guid("ef267576-b651-4b27-a127-87502a98d2e8");
			return column;
		}

		protected override EntitySchemaColumn CreateSysPackageUIdColumn() {
			EntitySchemaColumn column = base.CreateSysPackageUIdColumn();
			column.ModifiedInSchemaUId = new Guid("36541fe9-c378-4338-915c-ed29d994be05");
			column.CreatedInPackageId = new Guid("ef267576-b651-4b27-a127-87502a98d2e8");
			return column;
		}

		protected override EntitySchemaColumn CreateSysPackageLevelColumn() {
			EntitySchemaColumn column = base.CreateSysPackageLevelColumn();
			column.ModifiedInSchemaUId = new Guid("36541fe9-c378-4338-915c-ed29d994be05");
			column.CreatedInPackageId = new Guid("ef267576-b651-4b27-a127-87502a98d2e8");
			return column;
		}

		protected virtual EntitySchemaColumn CreateIsVirtualColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("8706c716-59eb-4773-a426-249dd8b8566f"),
				Name = @"IsVirtual",
				CreatedInSchemaUId = new Guid("36541fe9-c378-4338-915c-ed29d994be05"),
				ModifiedInSchemaUId = new Guid("36541fe9-c378-4338-915c-ed29d994be05"),
				CreatedInPackageId = new Guid("fa21f890-95ea-4fc0-8579-3e5e9eeaa73f")
			};
		}

		protected virtual EntitySchemaColumn CreateExtendParentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("f47fba3e-2467-4684-8892-d2ce18471d0c"),
				Name = @"ExtendParent",
				CreatedInSchemaUId = new Guid("36541fe9-c378-4338-915c-ed29d994be05"),
				ModifiedInSchemaUId = new Guid("36541fe9-c378-4338-915c-ed29d994be05"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwSysEntitySchemaInPackageEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwSysEntitySchemaInPackageEventsProcessSchema() {
			var schema = new VwSysEntitySchemaInPackageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwSysEntitySchemaInPackage(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwSysEntitySchemaInPackage_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwSysEntitySchemaInPackageSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwSysEntitySchemaInPackageSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("36541fe9-c378-4338-915c-ed29d994be05"));
		}

		#endregion

	}

	#endregion

	#region Class: VwSysEntitySchemaInPackage

	/// <summary>
	/// Workspace object in package (view).
	/// </summary>
	public class VwSysEntitySchemaInPackage : Terrasoft.Configuration.VwSysSchemaInPackage
	{

		#region Constructors: Public

		public VwSysEntitySchemaInPackage(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwSysEntitySchemaInPackage";
		}

		public VwSysEntitySchemaInPackage(VwSysEntitySchemaInPackage source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// IsVirtual.
		/// </summary>
		public bool IsVirtual {
			get {
				return GetTypedColumnValue<bool>("IsVirtual");
			}
			set {
				SetColumnValue("IsVirtual", value);
			}
		}

		/// <summary>
		/// ExtendParent.
		/// </summary>
		public bool ExtendParent {
			get {
				return GetTypedColumnValue<bool>("ExtendParent");
			}
			set {
				SetColumnValue("ExtendParent", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwSysEntitySchemaInPackage_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwSysEntitySchemaInPackageDeleted", e);
			Inserting += (s, e) => ThrowEvent("VwSysEntitySchemaInPackageInserting", e);
			Validating += (s, e) => ThrowEvent("VwSysEntitySchemaInPackageValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwSysEntitySchemaInPackage(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwSysEntitySchemaInPackage_BaseEventsProcess

	/// <exclude/>
	public partial class VwSysEntitySchemaInPackage_BaseEventsProcess<TEntity> : Terrasoft.Configuration.VwSysSchemaInPackage_BaseEventsProcess<TEntity> where TEntity : VwSysEntitySchemaInPackage
	{

		public VwSysEntitySchemaInPackage_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwSysEntitySchemaInPackage_BaseEventsProcess";
			SchemaUId = new Guid("36541fe9-c378-4338-915c-ed29d994be05");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("36541fe9-c378-4338-915c-ed29d994be05");
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

	#region Class: VwSysEntitySchemaInPackage_BaseEventsProcess

	/// <exclude/>
	public class VwSysEntitySchemaInPackage_BaseEventsProcess : VwSysEntitySchemaInPackage_BaseEventsProcess<VwSysEntitySchemaInPackage>
	{

		public VwSysEntitySchemaInPackage_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwSysEntitySchemaInPackage_BaseEventsProcess

	public partial class VwSysEntitySchemaInPackage_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: VwSysEntitySchemaInPackageEventsProcessSchema

	/// <exclude/>
	public class VwSysEntitySchemaInPackageEventsProcessSchema : Terrasoft.Configuration.VwSysSchemaInPackageEventsProcessSchema
	{

		#region Constructors: Public

		public VwSysEntitySchemaInPackageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwSysEntitySchemaInPackageEventsProcessSchema(VwSysEntitySchemaInPackageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwSysEntitySchemaInPackage_BaseEventsProcess";
			UId = new Guid("bd939695-b33c-4de3-acfe-9724b62db863");
			CreatedInPackageId = new Guid("ef267576-b651-4b27-a127-87502a98d2e8");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("3e796c88-c26a-4df8-9561-4fb3a8cfafc6");
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
				CreatedInPackageId = new Guid("ef267576-b651-4b27-a127-87502a98d2e8")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("ef267576-b651-4b27-a127-87502a98d2e8")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("ef267576-b651-4b27-a127-87502a98d2e8")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("ef267576-b651-4b27-a127-87502a98d2e8")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("ef267576-b651-4b27-a127-87502a98d2e8")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("ef267576-b651-4b27-a127-87502a98d2e8")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("ef267576-b651-4b27-a127-87502a98d2e8")
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
			return new VwSysEntitySchemaInPackageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bd939695-b33c-4de3-acfe-9724b62db863"));
		}

		#endregion

	}

	#endregion


	#region Class: VwSysEntitySchemaInPackageEventsProcess

	/// <exclude/>
	public class VwSysEntitySchemaInPackageEventsProcess : VwSysEntitySchemaInPackage_BaseEventsProcess
	{

		public VwSysEntitySchemaInPackageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

