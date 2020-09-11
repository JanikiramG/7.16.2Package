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

	#region Class: SysEditPageSchema

	/// <exclude/>
	public class SysEditPageSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysEditPageSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysEditPageSchema(SysEditPageSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysEditPageSchema(SysEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1eee8a5d-b51c-4a52-8143-a7f2d2df2747");
			RealUId = new Guid("1eee8a5d-b51c-4a52-8143-a7f2d2df2747");
			Name = "SysEditPage";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("680349ce-f390-4cf7-8ed2-4684d1ec37b8")) == null) {
				Columns.Add(CreateSysPageSchemaColumn());
			}
			if (Columns.FindByUId(new Guid("9f14ceb3-2455-47a4-951c-e7ace5f508ca")) == null) {
				Columns.Add(CreateSysGridPageColumn());
			}
			if (Columns.FindByUId(new Guid("ff1603fa-811e-49ae-9ce7-bf86b7ee18b5")) == null) {
				Columns.Add(CreateSysEntitySchemaColumn());
			}
			if (Columns.FindByUId(new Guid("7781829d-4468-4a88-8a06-5570c5e892a8")) == null) {
				Columns.Add(CreateTypeColumnValueColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSysPageSchemaColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("680349ce-f390-4cf7-8ed2-4684d1ec37b8"),
				Name = @"SysPageSchema",
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				CreatedInSchemaUId = new Guid("1eee8a5d-b51c-4a52-8143-a7f2d2df2747"),
				ModifiedInSchemaUId = new Guid("1eee8a5d-b51c-4a52-8143-a7f2d2df2747"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected virtual EntitySchemaColumn CreateSysGridPageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("9f14ceb3-2455-47a4-951c-e7ace5f508ca"),
				Name = @"SysGridPage",
				ReferenceSchemaUId = new Guid("d19658bd-987d-4cd5-9006-0e9d6edc9104"),
				CreatedInSchemaUId = new Guid("1eee8a5d-b51c-4a52-8143-a7f2d2df2747"),
				ModifiedInSchemaUId = new Guid("1eee8a5d-b51c-4a52-8143-a7f2d2df2747"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected virtual EntitySchemaColumn CreateSysEntitySchemaColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ff1603fa-811e-49ae-9ce7-bf86b7ee18b5"),
				Name = @"SysEntitySchema",
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				CreatedInSchemaUId = new Guid("1eee8a5d-b51c-4a52-8143-a7f2d2df2747"),
				ModifiedInSchemaUId = new Guid("1eee8a5d-b51c-4a52-8143-a7f2d2df2747"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumnValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("7781829d-4468-4a88-8a06-5570c5e892a8"),
				Name = @"TypeColumnValue",
				CreatedInSchemaUId = new Guid("1eee8a5d-b51c-4a52-8143-a7f2d2df2747"),
				ModifiedInSchemaUId = new Guid("1eee8a5d-b51c-4a52-8143-a7f2d2df2747"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysEditPageEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysEditPageEventsProcessSchema() {
			var schema = new SysEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysEditPage(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysEditPage_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysEditPageSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysEditPageSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1eee8a5d-b51c-4a52-8143-a7f2d2df2747"));
		}

		#endregion

	}

	#endregion

	#region Class: SysEditPage

	/// <summary>
	/// Edit page.
	/// </summary>
	public class SysEditPage : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysEditPage(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysEditPage";
		}

		public SysEditPage(SysEditPage source)
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
		public Guid SysGridPageId {
			get {
				return GetTypedColumnValue<Guid>("SysGridPageId");
			}
			set {
				SetColumnValue("SysGridPageId", value);
				_sysGridPage = null;
			}
		}

		private SysGridPage _sysGridPage;
		/// <summary>
		/// List page.
		/// </summary>
		public SysGridPage SysGridPage {
			get {
				return _sysGridPage ??
					(_sysGridPage = LookupColumnEntities.GetEntity("SysGridPage") as SysGridPage);
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
		/// Type.
		/// </summary>
		public Guid TypeColumnValue {
			get {
				return GetTypedColumnValue<Guid>("TypeColumnValue");
			}
			set {
				SetColumnValue("TypeColumnValue", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysEditPage_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysEditPageDeleted", e);
			Deleting += (s, e) => ThrowEvent("SysEditPageDeleting", e);
			Inserted += (s, e) => ThrowEvent("SysEditPageInserted", e);
			Inserting += (s, e) => ThrowEvent("SysEditPageInserting", e);
			Saved += (s, e) => ThrowEvent("SysEditPageSaved", e);
			Saving += (s, e) => ThrowEvent("SysEditPageSaving", e);
			Validating += (s, e) => ThrowEvent("SysEditPageValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysEditPage(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysEditPage_BaseEventsProcess

	/// <exclude/>
	public partial class SysEditPage_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysEditPage
	{

		public SysEditPage_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysEditPage_BaseEventsProcess";
			SchemaUId = new Guid("1eee8a5d-b51c-4a52-8143-a7f2d2df2747");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1eee8a5d-b51c-4a52-8143-a7f2d2df2747");
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

	#region Class: SysEditPage_BaseEventsProcess

	/// <exclude/>
	public class SysEditPage_BaseEventsProcess : SysEditPage_BaseEventsProcess<SysEditPage>
	{

		public SysEditPage_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysEditPage_BaseEventsProcess

	public partial class SysEditPage_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysEditPageEventsProcessSchema

	/// <exclude/>
	public class SysEditPageEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysEditPageEventsProcessSchema(SysEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysEditPage_BaseEventsProcess";
			UId = new Guid("ec5ecd89-8202-4ab2-8a12-e6a70182fe46");
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
			return new SysEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ec5ecd89-8202-4ab2-8a12-e6a70182fe46"));
		}

		#endregion

	}

	#endregion


	#region Class: SysEditPageEventsProcess

	/// <exclude/>
	public class SysEditPageEventsProcess : SysEditPage_BaseEventsProcess
	{

		public SysEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

