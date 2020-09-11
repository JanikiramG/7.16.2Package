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

	#region Class: SysInstalledAppSchema

	/// <exclude/>
	public class SysInstalledAppSchema : Terrasoft.Configuration.BaseCodeLookupSchema
	{

		#region Constructors: Public

		public SysInstalledAppSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysInstalledAppSchema(SysInstalledAppSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysInstalledAppSchema(SysInstalledAppSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateSysInstalledApp_CodeIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = true
			};
			index.UId = new Guid("adbee7d0-8b5a-421c-9b2e-2cbc3a14f50e");
			index.Name = "SysInstalledApp_Code";
			index.CreatedInSchemaUId = new Guid("91d3eeb0-086c-4143-b671-dd2b77634d39");
			index.ModifiedInSchemaUId = new Guid("91d3eeb0-086c-4143-b671-dd2b77634d39");
			index.CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			EntitySchemaIndexColumn codeIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("24b02828-3f5f-41e4-b49b-ac9d9454e18b"),
				ColumnUId = new Guid("13aad544-ec30-4e76-a373-f0cff3202e24"),
				CreatedInSchemaUId = new Guid("91d3eeb0-086c-4143-b671-dd2b77634d39"),
				ModifiedInSchemaUId = new Guid("91d3eeb0-086c-4143-b671-dd2b77634d39"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(codeIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("91d3eeb0-086c-4143-b671-dd2b77634d39");
			RealUId = new Guid("91d3eeb0-086c-4143-b671-dd2b77634d39");
			Name = "SysInstalledApp";
			ParentSchemaUId = new Guid("2681062b-df59-4e52-89ed-f9b7dc909ab2");
			ExtendParent = false;
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("5420bb26-d1bc-4732-8c82-372e1e870cdc")) == null) {
				Columns.Add(CreateMaintainerColumn());
			}
			if (Columns.FindByUId(new Guid("aad2b3b4-a300-4468-bca3-ce64c6308a76")) == null) {
				Columns.Add(CreateInstallDateColumn());
			}
			if (Columns.FindByUId(new Guid("934b7730-1761-4b06-9429-dcf70712663c")) == null) {
				Columns.Add(CreateLastUpdateColumn());
			}
			if (Columns.FindByUId(new Guid("9b0af75c-6cb3-4826-9244-ce4f82f760d7")) == null) {
				Columns.Add(CreateMarketplaceLinkColumn());
			}
			if (Columns.FindByUId(new Guid("b4fcdf44-2fd7-4144-a7ac-f0499af1f29c")) == null) {
				Columns.Add(CreateHelpLinkColumn());
			}
			if (Columns.FindByUId(new Guid("9b1eb4c0-e32e-4a5d-8345-a4cd2eb79ea6")) == null) {
				Columns.Add(CreateFileLinkColumn());
			}
			if (Columns.FindByUId(new Guid("95b9bde0-84ef-4a32-93d7-a18b08cb93f9")) == null) {
				Columns.Add(CreateSupportEmailColumn());
			}
			if (Columns.FindByUId(new Guid("2b224027-2933-49e7-b508-3adbeac9f399")) == null) {
				Columns.Add(CreateOrderLinkColumn());
			}
			if (Columns.FindByUId(new Guid("9c9e5d69-f096-4e6c-833c-5296db9d68b4")) == null) {
				Columns.Add(CreateSysInstalledAppStatusColumn());
			}
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.IsLocalizable = false;
			column.ModifiedInSchemaUId = new Guid("91d3eeb0-086c-4143-b671-dd2b77634d39");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.IsLocalizable = false;
			column.ModifiedInSchemaUId = new Guid("91d3eeb0-086c-4143-b671-dd2b77634d39");
			return column;
		}

		protected override EntitySchemaColumn CreateCodeColumn() {
			EntitySchemaColumn column = base.CreateCodeColumn();
			column.DataValueType = DataValueTypeManager.GetInstanceByName("MediumText");
			column.ModifiedInSchemaUId = new Guid("91d3eeb0-086c-4143-b671-dd2b77634d39");
			return column;
		}

		protected virtual EntitySchemaColumn CreateMaintainerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("5420bb26-d1bc-4732-8c82-372e1e870cdc"),
				Name = @"Maintainer",
				CreatedInSchemaUId = new Guid("91d3eeb0-086c-4143-b671-dd2b77634d39"),
				ModifiedInSchemaUId = new Guid("91d3eeb0-086c-4143-b671-dd2b77634d39"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateInstallDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("aad2b3b4-a300-4468-bca3-ce64c6308a76"),
				Name = @"InstallDate",
				CreatedInSchemaUId = new Guid("91d3eeb0-086c-4143-b671-dd2b77634d39"),
				ModifiedInSchemaUId = new Guid("91d3eeb0-086c-4143-b671-dd2b77634d39"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateLastUpdateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("934b7730-1761-4b06-9429-dcf70712663c"),
				Name = @"LastUpdate",
				CreatedInSchemaUId = new Guid("91d3eeb0-086c-4143-b671-dd2b77634d39"),
				ModifiedInSchemaUId = new Guid("91d3eeb0-086c-4143-b671-dd2b77634d39"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateMarketplaceLinkColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("9b0af75c-6cb3-4826-9244-ce4f82f760d7"),
				Name = @"MarketplaceLink",
				CreatedInSchemaUId = new Guid("91d3eeb0-086c-4143-b671-dd2b77634d39"),
				ModifiedInSchemaUId = new Guid("91d3eeb0-086c-4143-b671-dd2b77634d39"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateHelpLinkColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("b4fcdf44-2fd7-4144-a7ac-f0499af1f29c"),
				Name = @"HelpLink",
				CreatedInSchemaUId = new Guid("91d3eeb0-086c-4143-b671-dd2b77634d39"),
				ModifiedInSchemaUId = new Guid("91d3eeb0-086c-4143-b671-dd2b77634d39"),
				CreatedInPackageId = new Guid("1f1bea1e-5005-484f-a57c-44d5e8e89d17")
			};
		}

		protected virtual EntitySchemaColumn CreateFileLinkColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("9b1eb4c0-e32e-4a5d-8345-a4cd2eb79ea6"),
				Name = @"FileLink",
				CreatedInSchemaUId = new Guid("91d3eeb0-086c-4143-b671-dd2b77634d39"),
				ModifiedInSchemaUId = new Guid("91d3eeb0-086c-4143-b671-dd2b77634d39"),
				CreatedInPackageId = new Guid("1f1bea1e-5005-484f-a57c-44d5e8e89d17")
			};
		}

		protected virtual EntitySchemaColumn CreateSupportEmailColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("95b9bde0-84ef-4a32-93d7-a18b08cb93f9"),
				Name = @"SupportEmail",
				CreatedInSchemaUId = new Guid("91d3eeb0-086c-4143-b671-dd2b77634d39"),
				ModifiedInSchemaUId = new Guid("91d3eeb0-086c-4143-b671-dd2b77634d39"),
				CreatedInPackageId = new Guid("1f1bea1e-5005-484f-a57c-44d5e8e89d17")
			};
		}

		protected virtual EntitySchemaColumn CreateOrderLinkColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("2b224027-2933-49e7-b508-3adbeac9f399"),
				Name = @"OrderLink",
				CreatedInSchemaUId = new Guid("91d3eeb0-086c-4143-b671-dd2b77634d39"),
				ModifiedInSchemaUId = new Guid("91d3eeb0-086c-4143-b671-dd2b77634d39"),
				CreatedInPackageId = new Guid("1f1bea1e-5005-484f-a57c-44d5e8e89d17")
			};
		}

		protected virtual EntitySchemaColumn CreateSysInstalledAppStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("9c9e5d69-f096-4e6c-833c-5296db9d68b4"),
				Name = @"SysInstalledAppStatus",
				ReferenceSchemaUId = new Guid("7f5115ca-22b4-42ee-b01d-c8846c1a6fa9"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("91d3eeb0-086c-4143-b671-dd2b77634d39"),
				ModifiedInSchemaUId = new Guid("91d3eeb0-086c-4143-b671-dd2b77634d39"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateSysInstalledApp_CodeIndex());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysInstalledAppEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysInstalledAppEventsProcessSchema() {
			var schema = new SysInstalledAppEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysInstalledApp(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysInstalledApp_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysInstalledAppSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysInstalledAppSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("91d3eeb0-086c-4143-b671-dd2b77634d39"));
		}

		#endregion

	}

	#endregion

	#region Class: SysInstalledApp

	/// <summary>
	/// Installed application.
	/// </summary>
	public class SysInstalledApp : Terrasoft.Configuration.BaseCodeLookup
	{

		#region Constructors: Public

		public SysInstalledApp(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysInstalledApp";
		}

		public SysInstalledApp(SysInstalledApp source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Maintainer.
		/// </summary>
		public string Maintainer {
			get {
				return GetTypedColumnValue<string>("Maintainer");
			}
			set {
				SetColumnValue("Maintainer", value);
			}
		}

		/// <summary>
		/// Install date.
		/// </summary>
		public DateTime InstallDate {
			get {
				return GetTypedColumnValue<DateTime>("InstallDate");
			}
			set {
				SetColumnValue("InstallDate", value);
			}
		}

		/// <summary>
		/// Date last updated.
		/// </summary>
		public DateTime LastUpdate {
			get {
				return GetTypedColumnValue<DateTime>("LastUpdate");
			}
			set {
				SetColumnValue("LastUpdate", value);
			}
		}

		/// <summary>
		/// Marketplace link.
		/// </summary>
		public string MarketplaceLink {
			get {
				return GetTypedColumnValue<string>("MarketplaceLink");
			}
			set {
				SetColumnValue("MarketplaceLink", value);
			}
		}

		/// <summary>
		/// Help link.
		/// </summary>
		public string HelpLink {
			get {
				return GetTypedColumnValue<string>("HelpLink");
			}
			set {
				SetColumnValue("HelpLink", value);
			}
		}

		/// <summary>
		/// File link.
		/// </summary>
		public string FileLink {
			get {
				return GetTypedColumnValue<string>("FileLink");
			}
			set {
				SetColumnValue("FileLink", value);
			}
		}

		/// <summary>
		/// Support email.
		/// </summary>
		public string SupportEmail {
			get {
				return GetTypedColumnValue<string>("SupportEmail");
			}
			set {
				SetColumnValue("SupportEmail", value);
			}
		}

		/// <summary>
		/// Order link.
		/// </summary>
		public string OrderLink {
			get {
				return GetTypedColumnValue<string>("OrderLink");
			}
			set {
				SetColumnValue("OrderLink", value);
			}
		}

		/// <exclude/>
		public Guid SysInstalledAppStatusId {
			get {
				return GetTypedColumnValue<Guid>("SysInstalledAppStatusId");
			}
			set {
				SetColumnValue("SysInstalledAppStatusId", value);
				_sysInstalledAppStatus = null;
			}
		}

		/// <exclude/>
		public string SysInstalledAppStatusName {
			get {
				return GetTypedColumnValue<string>("SysInstalledAppStatusName");
			}
			set {
				SetColumnValue("SysInstalledAppStatusName", value);
				if (_sysInstalledAppStatus != null) {
					_sysInstalledAppStatus.Name = value;
				}
			}
		}

		private SysInstalledAppStatus _sysInstalledAppStatus;
		/// <summary>
		/// Application status.
		/// </summary>
		public SysInstalledAppStatus SysInstalledAppStatus {
			get {
				return _sysInstalledAppStatus ??
					(_sysInstalledAppStatus = LookupColumnEntities.GetEntity("SysInstalledAppStatus") as SysInstalledAppStatus);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysInstalledApp_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysInstalledAppDeleted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysInstalledApp(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysInstalledApp_BaseEventsProcess

	/// <exclude/>
	public partial class SysInstalledApp_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseCodeLookup_BaseEventsProcess<TEntity> where TEntity : SysInstalledApp
	{

		public SysInstalledApp_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysInstalledApp_BaseEventsProcess";
			SchemaUId = new Guid("91d3eeb0-086c-4143-b671-dd2b77634d39");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("91d3eeb0-086c-4143-b671-dd2b77634d39");
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

	#region Class: SysInstalledApp_BaseEventsProcess

	/// <exclude/>
	public class SysInstalledApp_BaseEventsProcess : SysInstalledApp_BaseEventsProcess<SysInstalledApp>
	{

		public SysInstalledApp_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysInstalledApp_BaseEventsProcess

	public partial class SysInstalledApp_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysInstalledAppEventsProcessSchema

	/// <exclude/>
	public class SysInstalledAppEventsProcessSchema : Terrasoft.Configuration.BaseCodeLookupEventsProcessSchema
	{

		#region Constructors: Public

		public SysInstalledAppEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysInstalledAppEventsProcessSchema(SysInstalledAppEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysInstalledApp_BaseEventsProcess";
			UId = new Guid("41aaa73f-de6a-4cc2-a5e6-81afb3066c64");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("ac8d0498-3a35-4ee5-ba97-2bf896fcc5e2");
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
			return new SysInstalledAppEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("41aaa73f-de6a-4cc2-a5e6-81afb3066c64"));
		}

		#endregion

	}

	#endregion


	#region Class: SysInstalledAppEventsProcess

	/// <exclude/>
	public class SysInstalledAppEventsProcess : SysInstalledApp_BaseEventsProcess
	{

		public SysInstalledAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

