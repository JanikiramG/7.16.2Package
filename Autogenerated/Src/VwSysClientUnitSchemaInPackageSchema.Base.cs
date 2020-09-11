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

	#region Class: VwSysClientUnitSchemaInPackageSchema

	/// <exclude/>
	public class VwSysClientUnitSchemaInPackageSchema : Terrasoft.Configuration.VwSysSchemaInPackageSchema
	{

		#region Constructors: Public

		public VwSysClientUnitSchemaInPackageSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwSysClientUnitSchemaInPackageSchema(VwSysClientUnitSchemaInPackageSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwSysClientUnitSchemaInPackageSchema(VwSysClientUnitSchemaInPackageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e");
			RealUId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e");
			Name = "VwSysClientUnitSchemaInPackage";
			ParentSchemaUId = new Guid("a594c3c0-91bd-400f-a209-6d38cf0d7548");
			ExtendParent = false;
			CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			IsDBView = true;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("1bcba5f4-edae-45ad-a07e-288d3e439755")) == null) {
				Columns.Add(CreateExtendParentColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e");
			column.CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e");
			column.CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e");
			column.CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e");
			column.CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e");
			column.CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e");
			column.CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			return column;
		}

		protected override EntitySchemaColumn CreateUIdColumn() {
			EntitySchemaColumn column = base.CreateUIdColumn();
			column.ModifiedInSchemaUId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e");
			column.CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e");
			column.CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			return column;
		}

		protected override EntitySchemaColumn CreateCaptionColumn() {
			EntitySchemaColumn column = base.CreateCaptionColumn();
			column.ModifiedInSchemaUId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e");
			column.CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			return column;
		}

		protected override EntitySchemaColumn CreateManagerNameColumn() {
			EntitySchemaColumn column = base.CreateManagerNameColumn();
			column.ModifiedInSchemaUId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e");
			column.CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			return column;
		}

		protected override EntitySchemaColumn CreateParentColumn() {
			EntitySchemaColumn column = base.CreateParentColumn();
			column.ModifiedInSchemaUId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e");
			column.CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			return column;
		}

		protected override EntitySchemaColumn CreateSysWorkspaceColumn() {
			EntitySchemaColumn column = base.CreateSysWorkspaceColumn();
			column.ModifiedInSchemaUId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e");
			column.CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			return column;
		}

		protected override EntitySchemaColumn CreateSysPackageColumn() {
			EntitySchemaColumn column = base.CreateSysPackageColumn();
			column.ModifiedInSchemaUId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e");
			column.CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			return column;
		}

		protected override EntitySchemaColumn CreateSysPackageUIdColumn() {
			EntitySchemaColumn column = base.CreateSysPackageUIdColumn();
			column.ModifiedInSchemaUId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e");
			column.CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			return column;
		}

		protected override EntitySchemaColumn CreateSysPackageLevelColumn() {
			EntitySchemaColumn column = base.CreateSysPackageLevelColumn();
			column.ModifiedInSchemaUId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e");
			column.CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			return column;
		}

		protected virtual EntitySchemaColumn CreateExtendParentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("1bcba5f4-edae-45ad-a07e-288d3e439755"),
				Name = @"ExtendParent",
				CreatedInSchemaUId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e"),
				ModifiedInSchemaUId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e"),
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwSysClientUnitSchemaInPackageEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwSysClientUnitSchemaInPackageEventsProcessSchema() {
			var schema = new VwSysClientUnitSchemaInPackageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwSysClientUnitSchemaInPackage(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwSysClientUnitSchemaInPackage_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwSysClientUnitSchemaInPackageSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwSysClientUnitSchemaInPackageSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e"));
		}

		#endregion

	}

	#endregion

	#region Class: VwSysClientUnitSchemaInPackage

	/// <summary>
	/// Custom workspace module in package (view).
	/// </summary>
	public class VwSysClientUnitSchemaInPackage : Terrasoft.Configuration.VwSysSchemaInPackage
	{

		#region Constructors: Public

		public VwSysClientUnitSchemaInPackage(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwSysClientUnitSchemaInPackage";
		}

		public VwSysClientUnitSchemaInPackage(VwSysClientUnitSchemaInPackage source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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
			var process = new VwSysClientUnitSchemaInPackage_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwSysClientUnitSchemaInPackageDeleted", e);
			Inserting += (s, e) => ThrowEvent("VwSysClientUnitSchemaInPackageInserting", e);
			Validating += (s, e) => ThrowEvent("VwSysClientUnitSchemaInPackageValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwSysClientUnitSchemaInPackage(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwSysClientUnitSchemaInPackage_BaseEventsProcess

	/// <exclude/>
	public partial class VwSysClientUnitSchemaInPackage_BaseEventsProcess<TEntity> : Terrasoft.Configuration.VwSysSchemaInPackage_BaseEventsProcess<TEntity> where TEntity : VwSysClientUnitSchemaInPackage
	{

		public VwSysClientUnitSchemaInPackage_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwSysClientUnitSchemaInPackage_BaseEventsProcess";
			SchemaUId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e");
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

	#region Class: VwSysClientUnitSchemaInPackage_BaseEventsProcess

	/// <exclude/>
	public class VwSysClientUnitSchemaInPackage_BaseEventsProcess : VwSysClientUnitSchemaInPackage_BaseEventsProcess<VwSysClientUnitSchemaInPackage>
	{

		public VwSysClientUnitSchemaInPackage_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwSysClientUnitSchemaInPackage_BaseEventsProcess

	public partial class VwSysClientUnitSchemaInPackage_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: VwSysClientUnitSchemaInPackageEventsProcessSchema

	/// <exclude/>
	public class VwSysClientUnitSchemaInPackageEventsProcessSchema : Terrasoft.Configuration.VwSysSchemaInPackageEventsProcessSchema
	{

		#region Constructors: Public

		public VwSysClientUnitSchemaInPackageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwSysClientUnitSchemaInPackageEventsProcessSchema(VwSysClientUnitSchemaInPackageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwSysClientUnitSchemaInPackage_BaseEventsProcess";
			UId = new Guid("1bf720c3-86d1-4c59-a863-4d4a4f0456a4");
			CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
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
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d")
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
			return new VwSysClientUnitSchemaInPackageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1bf720c3-86d1-4c59-a863-4d4a4f0456a4"));
		}

		#endregion

	}

	#endregion


	#region Class: VwSysClientUnitSchemaInPackageEventsProcess

	/// <exclude/>
	public class VwSysClientUnitSchemaInPackageEventsProcess : VwSysClientUnitSchemaInPackage_BaseEventsProcess
	{

		public VwSysClientUnitSchemaInPackageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

