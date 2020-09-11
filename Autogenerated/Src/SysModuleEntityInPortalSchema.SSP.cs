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

	#region Class: SysModuleEntityInPortalSchema

	/// <exclude/>
	public class SysModuleEntityInPortalSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysModuleEntityInPortalSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysModuleEntityInPortalSchema(SysModuleEntityInPortalSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysModuleEntityInPortalSchema(SysModuleEntityInPortalSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0933e2c4-342c-41e0-adce-7dbc2c8860bf");
			RealUId = new Guid("0933e2c4-342c-41e0-adce-7dbc2c8860bf");
			Name = "SysModuleEntityInPortal";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("fc741efe-5ee7-42c9-8935-9d298f1913b5");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("c86fd533-a630-42fa-8042-c604384abe1f")) == null) {
				Columns.Add(CreateSysPortalColumn());
			}
			if (Columns.FindByUId(new Guid("a9afe7de-15cf-48a6-b6fb-249b1883c032")) == null) {
				Columns.Add(CreateSysModuleEntityColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("0933e2c4-342c-41e0-adce-7dbc2c8860bf");
			column.CreatedInPackageId = new Guid("fc741efe-5ee7-42c9-8935-9d298f1913b5");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("0933e2c4-342c-41e0-adce-7dbc2c8860bf");
			column.CreatedInPackageId = new Guid("fc741efe-5ee7-42c9-8935-9d298f1913b5");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("0933e2c4-342c-41e0-adce-7dbc2c8860bf");
			column.CreatedInPackageId = new Guid("fc741efe-5ee7-42c9-8935-9d298f1913b5");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("0933e2c4-342c-41e0-adce-7dbc2c8860bf");
			column.CreatedInPackageId = new Guid("fc741efe-5ee7-42c9-8935-9d298f1913b5");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("0933e2c4-342c-41e0-adce-7dbc2c8860bf");
			column.CreatedInPackageId = new Guid("fc741efe-5ee7-42c9-8935-9d298f1913b5");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("0933e2c4-342c-41e0-adce-7dbc2c8860bf");
			column.CreatedInPackageId = new Guid("fc741efe-5ee7-42c9-8935-9d298f1913b5");
			return column;
		}

		protected virtual EntitySchemaColumn CreateSysPortalColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c86fd533-a630-42fa-8042-c604384abe1f"),
				Name = @"SysPortal",
				ReferenceSchemaUId = new Guid("ebe236ab-e6c0-4155-981e-59a2c6800c8c"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("0933e2c4-342c-41e0-adce-7dbc2c8860bf"),
				ModifiedInSchemaUId = new Guid("0933e2c4-342c-41e0-adce-7dbc2c8860bf"),
				CreatedInPackageId = new Guid("fc741efe-5ee7-42c9-8935-9d298f1913b5")
			};
		}

		protected virtual EntitySchemaColumn CreateSysModuleEntityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a9afe7de-15cf-48a6-b6fb-249b1883c032"),
				Name = @"SysModuleEntity",
				ReferenceSchemaUId = new Guid("9c762665-90ad-497b-ac4b-45bb729630a1"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("0933e2c4-342c-41e0-adce-7dbc2c8860bf"),
				ModifiedInSchemaUId = new Guid("0933e2c4-342c-41e0-adce-7dbc2c8860bf"),
				CreatedInPackageId = new Guid("fc741efe-5ee7-42c9-8935-9d298f1913b5")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysModuleEntityInPortalEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysModuleEntityInPortalEventsProcessSchema() {
			var schema = new SysModuleEntityInPortalEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysModuleEntityInPortal(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysModuleEntityInPortal_SSPEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysModuleEntityInPortalSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysModuleEntityInPortalSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0933e2c4-342c-41e0-adce-7dbc2c8860bf"));
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleEntityInPortal

	/// <summary>
	/// Portal section object.
	/// </summary>
	public class SysModuleEntityInPortal : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysModuleEntityInPortal(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysModuleEntityInPortal";
		}

		public SysModuleEntityInPortal(SysModuleEntityInPortal source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid SysPortalId {
			get {
				return GetTypedColumnValue<Guid>("SysPortalId");
			}
			set {
				SetColumnValue("SysPortalId", value);
				_sysPortal = null;
			}
		}

		/// <exclude/>
		public string SysPortalName {
			get {
				return GetTypedColumnValue<string>("SysPortalName");
			}
			set {
				SetColumnValue("SysPortalName", value);
				if (_sysPortal != null) {
					_sysPortal.Name = value;
				}
			}
		}

		private SysPortal _sysPortal;
		/// <summary>
		/// Portal.
		/// </summary>
		public SysPortal SysPortal {
			get {
				return _sysPortal ??
					(_sysPortal = LookupColumnEntities.GetEntity("SysPortal") as SysPortal);
			}
		}

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
		/// SysModuleEntity.
		/// </summary>
		public SysModuleEntity SysModuleEntity {
			get {
				return _sysModuleEntity ??
					(_sysModuleEntity = LookupColumnEntities.GetEntity("SysModuleEntity") as SysModuleEntity);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysModuleEntityInPortal_SSPEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysModuleEntityInPortalDeleted", e);
			Validating += (s, e) => ThrowEvent("SysModuleEntityInPortalValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysModuleEntityInPortal(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleEntityInPortal_SSPEventsProcess

	/// <exclude/>
	public partial class SysModuleEntityInPortal_SSPEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysModuleEntityInPortal
	{

		public SysModuleEntityInPortal_SSPEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysModuleEntityInPortal_SSPEventsProcess";
			SchemaUId = new Guid("0933e2c4-342c-41e0-adce-7dbc2c8860bf");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("0933e2c4-342c-41e0-adce-7dbc2c8860bf");
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

	#region Class: SysModuleEntityInPortal_SSPEventsProcess

	/// <exclude/>
	public class SysModuleEntityInPortal_SSPEventsProcess : SysModuleEntityInPortal_SSPEventsProcess<SysModuleEntityInPortal>
	{

		public SysModuleEntityInPortal_SSPEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysModuleEntityInPortal_SSPEventsProcess

	public partial class SysModuleEntityInPortal_SSPEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysModuleEntityInPortalEventsProcessSchema

	/// <exclude/>
	public class SysModuleEntityInPortalEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysModuleEntityInPortalEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysModuleEntityInPortalEventsProcessSchema(SysModuleEntityInPortalEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysModuleEntityInPortal_SSPEventsProcess";
			UId = new Guid("060452e6-dcaf-4364-a280-f4685deb96d3");
			CreatedInPackageId = new Guid("fc741efe-5ee7-42c9-8935-9d298f1913b5");
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
				CreatedInPackageId = new Guid("fc741efe-5ee7-42c9-8935-9d298f1913b5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("fc741efe-5ee7-42c9-8935-9d298f1913b5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("fc741efe-5ee7-42c9-8935-9d298f1913b5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("fc741efe-5ee7-42c9-8935-9d298f1913b5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("fc741efe-5ee7-42c9-8935-9d298f1913b5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("fc741efe-5ee7-42c9-8935-9d298f1913b5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("fc741efe-5ee7-42c9-8935-9d298f1913b5")
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
			return new SysModuleEntityInPortalEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("060452e6-dcaf-4364-a280-f4685deb96d3"));
		}

		#endregion

	}

	#endregion


	#region Class: SysModuleEntityInPortalEventsProcess

	/// <exclude/>
	public class SysModuleEntityInPortalEventsProcess : SysModuleEntityInPortal_SSPEventsProcess
	{

		public SysModuleEntityInPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

