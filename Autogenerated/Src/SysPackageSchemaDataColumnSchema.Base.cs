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

	#region Class: SysPackageSchemaDataColumnSchema

	/// <exclude/>
	public class SysPackageSchemaDataColumnSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysPackageSchemaDataColumnSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysPackageSchemaDataColumnSchema(SysPackageSchemaDataColumnSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysPackageSchemaDataColumnSchema(SysPackageSchemaDataColumnSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f40856c3-7dc4-4976-b674-e7f186b14b00");
			RealUId = new Guid("f40856c3-7dc4-4976-b674-e7f186b14b00");
			Name = "SysPackageSchemaDataColumn";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("56258f1c-ce30-4624-a266-79672fbdeab1")) == null) {
				Columns.Add(CreateSysPackageSchemaDataColumn());
			}
			if (Columns.FindByUId(new Guid("041e1631-7ef2-40bd-ab9b-736d2265060f")) == null) {
				Columns.Add(CreatePackageSchemaColumnUIdColumn());
			}
			if (Columns.FindByUId(new Guid("5259213e-18d0-4855-8126-94d0d6384c2e")) == null) {
				Columns.Add(CreateIsForceUpdateColumn());
			}
			if (Columns.FindByUId(new Guid("b92f1b4e-319d-4d63-b4fd-bb2f326dd17d")) == null) {
				Columns.Add(CreateIsKeyColumn());
			}
			if (Columns.FindByUId(new Guid("e387a65e-7daf-434d-ad66-c23712a1aa6e")) == null) {
				Columns.Add(CreateColumnNameColumn());
			}
			if (Columns.FindByUId(new Guid("2e31d2fa-cf72-4f3b-9ecb-a2538c992a00")) == null) {
				Columns.Add(CreateDataValueTypeUIdColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSysPackageSchemaDataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("56258f1c-ce30-4624-a266-79672fbdeab1"),
				Name = @"SysPackageSchemaData",
				ReferenceSchemaUId = new Guid("4cec7385-4a1c-47df-89f4-97cde394e167"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("f40856c3-7dc4-4976-b674-e7f186b14b00"),
				ModifiedInSchemaUId = new Guid("f40856c3-7dc4-4976-b674-e7f186b14b00"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreatePackageSchemaColumnUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("041e1631-7ef2-40bd-ab9b-736d2265060f"),
				Name = @"PackageSchemaColumnUId",
				CreatedInSchemaUId = new Guid("f40856c3-7dc4-4976-b674-e7f186b14b00"),
				ModifiedInSchemaUId = new Guid("f40856c3-7dc4-4976-b674-e7f186b14b00"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateIsForceUpdateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("5259213e-18d0-4855-8126-94d0d6384c2e"),
				Name = @"IsForceUpdate",
				CreatedInSchemaUId = new Guid("f40856c3-7dc4-4976-b674-e7f186b14b00"),
				ModifiedInSchemaUId = new Guid("f40856c3-7dc4-4976-b674-e7f186b14b00"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateIsKeyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("b92f1b4e-319d-4d63-b4fd-bb2f326dd17d"),
				Name = @"IsKey",
				CreatedInSchemaUId = new Guid("f40856c3-7dc4-4976-b674-e7f186b14b00"),
				ModifiedInSchemaUId = new Guid("f40856c3-7dc4-4976-b674-e7f186b14b00"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"False"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateColumnNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("e387a65e-7daf-434d-ad66-c23712a1aa6e"),
				Name = @"ColumnName",
				CreatedInSchemaUId = new Guid("f40856c3-7dc4-4976-b674-e7f186b14b00"),
				ModifiedInSchemaUId = new Guid("f40856c3-7dc4-4976-b674-e7f186b14b00"),
				CreatedInPackageId = new Guid("753cbfc2-77bc-467c-9a08-8cf692de862c")
			};
		}

		protected virtual EntitySchemaColumn CreateDataValueTypeUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("2e31d2fa-cf72-4f3b-9ecb-a2538c992a00"),
				Name = @"DataValueTypeUId",
				CreatedInSchemaUId = new Guid("f40856c3-7dc4-4976-b674-e7f186b14b00"),
				ModifiedInSchemaUId = new Guid("f40856c3-7dc4-4976-b674-e7f186b14b00"),
				CreatedInPackageId = new Guid("753cbfc2-77bc-467c-9a08-8cf692de862c")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysPackageSchemaDataColumnEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysPackageSchemaDataColumnEventsProcessSchema() {
			var schema = new SysPackageSchemaDataColumnEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysPackageSchemaDataColumn(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysPackageSchemaDataColumn_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysPackageSchemaDataColumnSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysPackageSchemaDataColumnSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f40856c3-7dc4-4976-b674-e7f186b14b00"));
		}

		#endregion

	}

	#endregion

	#region Class: SysPackageSchemaDataColumn

	/// <summary>
	/// Schema column.
	/// </summary>
	public class SysPackageSchemaDataColumn : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysPackageSchemaDataColumn(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysPackageSchemaDataColumn";
		}

		public SysPackageSchemaDataColumn(SysPackageSchemaDataColumn source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid SysPackageSchemaDataId {
			get {
				return GetTypedColumnValue<Guid>("SysPackageSchemaDataId");
			}
			set {
				SetColumnValue("SysPackageSchemaDataId", value);
				_sysPackageSchemaData = null;
			}
		}

		private SysPackageSchemaData _sysPackageSchemaData;
		/// <summary>
		/// Package schema data.
		/// </summary>
		public SysPackageSchemaData SysPackageSchemaData {
			get {
				return _sysPackageSchemaData ??
					(_sysPackageSchemaData = LookupColumnEntities.GetEntity("SysPackageSchemaData") as SysPackageSchemaData);
			}
		}

		/// <summary>
		/// Column Id.
		/// </summary>
		public Guid PackageSchemaColumnUId {
			get {
				return GetTypedColumnValue<Guid>("PackageSchemaColumnUId");
			}
			set {
				SetColumnValue("PackageSchemaColumnUId", value);
			}
		}

		/// <summary>
		/// Forced update.
		/// </summary>
		public bool IsForceUpdate {
			get {
				return GetTypedColumnValue<bool>("IsForceUpdate");
			}
			set {
				SetColumnValue("IsForceUpdate", value);
			}
		}

		/// <summary>
		/// Key.
		/// </summary>
		public bool IsKey {
			get {
				return GetTypedColumnValue<bool>("IsKey");
			}
			set {
				SetColumnValue("IsKey", value);
			}
		}

		/// <summary>
		/// Column name.
		/// </summary>
		public string ColumnName {
			get {
				return GetTypedColumnValue<string>("ColumnName");
			}
			set {
				SetColumnValue("ColumnName", value);
			}
		}

		/// <summary>
		/// Data type Id.
		/// </summary>
		public Guid DataValueTypeUId {
			get {
				return GetTypedColumnValue<Guid>("DataValueTypeUId");
			}
			set {
				SetColumnValue("DataValueTypeUId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysPackageSchemaDataColumn_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysPackageSchemaDataColumnDeleted", e);
			Inserting += (s, e) => ThrowEvent("SysPackageSchemaDataColumnInserting", e);
			Validating += (s, e) => ThrowEvent("SysPackageSchemaDataColumnValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysPackageSchemaDataColumn(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysPackageSchemaDataColumn_BaseEventsProcess

	/// <exclude/>
	public partial class SysPackageSchemaDataColumn_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysPackageSchemaDataColumn
	{

		public SysPackageSchemaDataColumn_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysPackageSchemaDataColumn_BaseEventsProcess";
			SchemaUId = new Guid("f40856c3-7dc4-4976-b674-e7f186b14b00");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f40856c3-7dc4-4976-b674-e7f186b14b00");
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

	#region Class: SysPackageSchemaDataColumn_BaseEventsProcess

	/// <exclude/>
	public class SysPackageSchemaDataColumn_BaseEventsProcess : SysPackageSchemaDataColumn_BaseEventsProcess<SysPackageSchemaDataColumn>
	{

		public SysPackageSchemaDataColumn_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysPackageSchemaDataColumn_BaseEventsProcess

	public partial class SysPackageSchemaDataColumn_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysPackageSchemaDataColumnEventsProcessSchema

	/// <exclude/>
	public class SysPackageSchemaDataColumnEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysPackageSchemaDataColumnEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysPackageSchemaDataColumnEventsProcessSchema(SysPackageSchemaDataColumnEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysPackageSchemaDataColumn_BaseEventsProcess";
			UId = new Guid("fd52c98d-d490-4374-98a1-c475a9a9c1dc");
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
			return new SysPackageSchemaDataColumnEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fd52c98d-d490-4374-98a1-c475a9a9c1dc"));
		}

		#endregion

	}

	#endregion


	#region Class: SysPackageSchemaDataColumnEventsProcess

	/// <exclude/>
	public class SysPackageSchemaDataColumnEventsProcess : SysPackageSchemaDataColumn_BaseEventsProcess
	{

		public SysPackageSchemaDataColumnEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

