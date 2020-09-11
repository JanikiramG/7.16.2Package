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

	#region Class: SysGridPageSchema

	/// <exclude/>
	public class SysGridPageSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysGridPageSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysGridPageSchema(SysGridPageSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysGridPageSchema(SysGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d19658bd-987d-4cd5-9006-0e9d6edc9104");
			RealUId = new Guid("d19658bd-987d-4cd5-9006-0e9d6edc9104");
			Name = "SysGridPage";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("16d28ad3-07f7-422e-9800-81b4c697e499")) == null) {
				Columns.Add(CreateSysPageSchemaColumn());
			}
			if (Columns.FindByUId(new Guid("d7f3729f-ed7e-4ef4-b05b-b599cc2889a7")) == null) {
				Columns.Add(CreateSysEntitySchemaColumn());
			}
			if (Columns.FindByUId(new Guid("d91ae947-7565-40fa-ac19-78f6f4d33760")) == null) {
				Columns.Add(CreateTypeColumnUIdColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSysPageSchemaColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("16d28ad3-07f7-422e-9800-81b4c697e499"),
				Name = @"SysPageSchema",
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				CreatedInSchemaUId = new Guid("d19658bd-987d-4cd5-9006-0e9d6edc9104"),
				ModifiedInSchemaUId = new Guid("d19658bd-987d-4cd5-9006-0e9d6edc9104"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected virtual EntitySchemaColumn CreateSysEntitySchemaColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d7f3729f-ed7e-4ef4-b05b-b599cc2889a7"),
				Name = @"SysEntitySchema",
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				CreatedInSchemaUId = new Guid("d19658bd-987d-4cd5-9006-0e9d6edc9104"),
				ModifiedInSchemaUId = new Guid("d19658bd-987d-4cd5-9006-0e9d6edc9104"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumnUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("d91ae947-7565-40fa-ac19-78f6f4d33760"),
				Name = @"TypeColumnUId",
				CreatedInSchemaUId = new Guid("d19658bd-987d-4cd5-9006-0e9d6edc9104"),
				ModifiedInSchemaUId = new Guid("d19658bd-987d-4cd5-9006-0e9d6edc9104"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysGridPageEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysGridPageEventsProcessSchema() {
			var schema = new SysGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysGridPage(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysGridPage_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysGridPageSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysGridPageSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d19658bd-987d-4cd5-9006-0e9d6edc9104"));
		}

		#endregion

	}

	#endregion

	#region Class: SysGridPage

	/// <summary>
	/// List page.
	/// </summary>
	public class SysGridPage : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysGridPage(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysGridPage";
		}

		public SysGridPage(SysGridPage source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid SysPageSchemaId {
			get {
				return GetTypedColumnValue<Guid>("SysPageSchemaId");
			}
			set {
				SetColumnValue("SysPageSchemaId", value);
				_sysPageSchema = null;
			}
		}

		/// <exclude/>
		public string SysPageSchemaCaption {
			get {
				return GetTypedColumnValue<string>("SysPageSchemaCaption");
			}
			set {
				SetColumnValue("SysPageSchemaCaption", value);
				if (_sysPageSchema != null) {
					_sysPageSchema.Caption = value;
				}
			}
		}

		private SysSchema _sysPageSchema;
		/// <summary>
		/// Page.
		/// </summary>
		public SysSchema SysPageSchema {
			get {
				return _sysPageSchema ??
					(_sysPageSchema = LookupColumnEntities.GetEntity("SysPageSchema") as SysSchema);
			}
		}

		/// <exclude/>
		public Guid SysEntitySchemaId {
			get {
				return GetTypedColumnValue<Guid>("SysEntitySchemaId");
			}
			set {
				SetColumnValue("SysEntitySchemaId", value);
				_sysEntitySchema = null;
			}
		}

		/// <exclude/>
		public string SysEntitySchemaCaption {
			get {
				return GetTypedColumnValue<string>("SysEntitySchemaCaption");
			}
			set {
				SetColumnValue("SysEntitySchemaCaption", value);
				if (_sysEntitySchema != null) {
					_sysEntitySchema.Caption = value;
				}
			}
		}

		private SysSchema _sysEntitySchema;
		/// <summary>
		/// Object.
		/// </summary>
		public SysSchema SysEntitySchema {
			get {
				return _sysEntitySchema ??
					(_sysEntitySchema = LookupColumnEntities.GetEntity("SysEntitySchema") as SysSchema);
			}
		}

		/// <summary>
		/// Type column.
		/// </summary>
		public Guid TypeColumnUId {
			get {
				return GetTypedColumnValue<Guid>("TypeColumnUId");
			}
			set {
				SetColumnValue("TypeColumnUId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysGridPage_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysGridPageDeleted", e);
			Deleting += (s, e) => ThrowEvent("SysGridPageDeleting", e);
			Inserted += (s, e) => ThrowEvent("SysGridPageInserted", e);
			Inserting += (s, e) => ThrowEvent("SysGridPageInserting", e);
			Saved += (s, e) => ThrowEvent("SysGridPageSaved", e);
			Saving += (s, e) => ThrowEvent("SysGridPageSaving", e);
			Validating += (s, e) => ThrowEvent("SysGridPageValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysGridPage(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysGridPage_BaseEventsProcess

	/// <exclude/>
	public partial class SysGridPage_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysGridPage
	{

		public SysGridPage_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysGridPage_BaseEventsProcess";
			SchemaUId = new Guid("d19658bd-987d-4cd5-9006-0e9d6edc9104");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d19658bd-987d-4cd5-9006-0e9d6edc9104");
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

	#region Class: SysGridPage_BaseEventsProcess

	/// <exclude/>
	public class SysGridPage_BaseEventsProcess : SysGridPage_BaseEventsProcess<SysGridPage>
	{

		public SysGridPage_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysGridPage_BaseEventsProcess

	public partial class SysGridPage_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysGridPageEventsProcessSchema

	/// <exclude/>
	public class SysGridPageEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysGridPageEventsProcessSchema(SysGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysGridPage_BaseEventsProcess";
			UId = new Guid("f6e156e9-dff6-44fa-9234-4d9a008e87da");
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
			return new SysGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f6e156e9-dff6-44fa-9234-4d9a008e87da"));
		}

		#endregion

	}

	#endregion


	#region Class: SysGridPageEventsProcess

	/// <exclude/>
	public class SysGridPageEventsProcess : SysGridPage_BaseEventsProcess
	{

		public SysGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

