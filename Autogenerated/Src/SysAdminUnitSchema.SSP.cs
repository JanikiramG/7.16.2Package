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
	using Terrasoft.Core.OperationLog;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;
	using Terrasoft.Web.Common;

	#region Class: SysAdminUnitSchema

	/// <exclude/>
	public class SysAdminUnitSchema : Terrasoft.Configuration.SysAdminUnit_Translation_TerrasoftSchema
	{

		#region Constructors: Public

		public SysAdminUnitSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysAdminUnitSchema(SysAdminUnitSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysAdminUnitSchema(SysAdminUnitSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIUSysAdminUnitNameIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = true
			};
			index.UId = new Guid("a09035f6-13ab-41d9-af1c-c095e5cf9ac1");
			index.Name = "IUSysAdminUnitName";
			index.CreatedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c");
			index.ModifiedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c");
			index.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			EntitySchemaIndexColumn nameIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("5c950219-374c-425c-8082-7e7de785ba20"),
				ColumnUId = new Guid("736c30a7-c0ec-4fa9-b034-2552b319b633"),
				CreatedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				ModifiedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(nameIndexColumn);
			EntitySchemaIndexColumn parentRoleIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("3c1b73d7-6adf-4567-88c8-8b95952dc03c"),
				ColumnUId = new Guid("fa4483b3-a2db-4651-a462-689be18351e7"),
				CreatedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				ModifiedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				CreatedInPackageId = new Guid("81adfa8e-1f43-43a3-9652-1b782e1a0cf1"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(parentRoleIdIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("6134f6db-e1d3-499e-8f36-1b5d3c658010");
			Name = "SysAdminUnit";
			ParentSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c");
			ExtendParent = true;
			CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("192720c7-fff1-4244-a991-4c0bef609174")) == null) {
				Columns.Add(CreatePortalAccountColumn());
			}
		}

		protected virtual EntitySchemaColumn CreatePortalAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("192720c7-fff1-4244-a991-4c0bef609174"),
				Name = @"PortalAccount",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("6134f6db-e1d3-499e-8f36-1b5d3c658010"),
				ModifiedInSchemaUId = new Guid("6134f6db-e1d3-499e-8f36-1b5d3c658010"),
				CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIUSysAdminUnitNameIndex());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysAdminUnitEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysAdminUnitEventsProcessSchema() {
			var schema = new SysAdminUnitEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysAdminUnit(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysAdminUnit_SSPEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysAdminUnitSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysAdminUnitSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6134f6db-e1d3-499e-8f36-1b5d3c658010"));
		}

		#endregion

	}

	#endregion

	#region Class: SysAdminUnit

	/// <summary>
	/// System administration object.
	/// </summary>
	public class SysAdminUnit : Terrasoft.Configuration.SysAdminUnit_Translation_Terrasoft
	{

		#region Constructors: Public

		public SysAdminUnit(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysAdminUnit";
		}

		public SysAdminUnit(SysAdminUnit source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid PortalAccountId {
			get {
				return GetTypedColumnValue<Guid>("PortalAccountId");
			}
			set {
				SetColumnValue("PortalAccountId", value);
				_portalAccount = null;
			}
		}

		/// <exclude/>
		public string PortalAccountName {
			get {
				return GetTypedColumnValue<string>("PortalAccountName");
			}
			set {
				SetColumnValue("PortalAccountName", value);
				if (_portalAccount != null) {
					_portalAccount.Name = value;
				}
			}
		}

		private Account _portalAccount;
		/// <summary>
		/// PortalAccount.
		/// </summary>
		public Account PortalAccount {
			get {
				return _portalAccount ??
					(_portalAccount = LookupColumnEntities.GetEntity("PortalAccount") as Account);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysAdminUnit_SSPEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysAdminUnit(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysAdminUnit_SSPEventsProcess

	/// <exclude/>
	public partial class SysAdminUnit_SSPEventsProcess<TEntity> : Terrasoft.Configuration.SysAdminUnit_TranslationEventsProcess<TEntity> where TEntity : SysAdminUnit
	{

		public SysAdminUnit_SSPEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysAdminUnit_SSPEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6134f6db-e1d3-499e-8f36-1b5d3c658010");
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

	#region Class: SysAdminUnit_SSPEventsProcess

	/// <exclude/>
	public class SysAdminUnit_SSPEventsProcess : SysAdminUnit_SSPEventsProcess<SysAdminUnit>
	{

		public SysAdminUnit_SSPEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysAdminUnit_SSPEventsProcess

	public partial class SysAdminUnit_SSPEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysAdminUnitEventsProcessSchema

	/// <exclude/>
	public class SysAdminUnitEventsProcessSchema : Terrasoft.Configuration.SysAdminUnit_Translation_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public SysAdminUnitEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysAdminUnitEventsProcessSchema(SysAdminUnitEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysAdminUnit_SSPEventsProcess";
			UId = new Guid("300e278f-9998-4dbc-9bf7-413dcd2503e0");
			CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c");
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
				UId = new Guid("a1f8c6a6-798f-4d77-9ab8-0688bc1d077a"),
				Name = "Terrasoft.Core.OperationLog",
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
			Usings.Add(new SchemaUsing() {
				UId = new Guid("18e14ca5-82d5-49d5-b3d8-12c73a25a787"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysAdminUnitEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("300e278f-9998-4dbc-9bf7-413dcd2503e0"));
		}

		#endregion

	}

	#endregion


	#region Class: SysAdminUnitEventsProcess

	/// <exclude/>
	public class SysAdminUnitEventsProcess : SysAdminUnit_SSPEventsProcess
	{

		public SysAdminUnitEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

