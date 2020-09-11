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

	#region Class: VwPageTemplateSchema

	/// <exclude/>
	public class VwPageTemplateSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public VwPageTemplateSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwPageTemplateSchema(VwPageTemplateSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwPageTemplateSchema(VwPageTemplateSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("72bb9229-bf9b-410f-bf4b-8d4ea6902373");
			RealUId = new Guid("72bb9229-bf9b-410f-bf4b-8d4ea6902373");
			Name = "VwPageTemplate";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18");
			IsDBView = true;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateSchemaCaptionColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializePrimaryImageColumn() {
			base.InitializePrimaryImageColumn();
			PrimaryImageColumn = CreatePreviewImageColumn();
			if (Columns.FindByUId(PrimaryImageColumn.UId) == null) {
				Columns.Add(PrimaryImageColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("7972f6ee-21e8-41bf-b1f6-1ca5f4a9983a")) == null) {
				Columns.Add(CreatePageSchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("0eb8f654-d324-4e87-9268-9eab4d9bbc21")) == null) {
				Columns.Add(CreatePositionColumn());
			}
			if (Columns.FindByUId(new Guid("5f4aaeb3-79db-426a-b1d5-d66ee7117661")) == null) {
				Columns.Add(CreatePageSchemaNameColumn());
			}
			if (Columns.FindByUId(new Guid("9cc7ee54-1daa-4527-9d3b-f2f4ddba4ac3")) == null) {
				Columns.Add(CreateSchemaDescriptionColumn());
			}
			if (Columns.FindByUId(new Guid("2ed304b0-a137-45c2-965a-46c5c94930de")) == null) {
				Columns.Add(CreateSysSchemaIdColumn());
			}
		}

		protected virtual EntitySchemaColumn CreatePageSchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("7972f6ee-21e8-41bf-b1f6-1ca5f4a9983a"),
				Name = @"PageSchemaUId",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("72bb9229-bf9b-410f-bf4b-8d4ea6902373"),
				ModifiedInSchemaUId = new Guid("72bb9229-bf9b-410f-bf4b-8d4ea6902373"),
				CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18")
			};
		}

		protected virtual EntitySchemaColumn CreatePreviewImageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ImageLookup")) {
				UId = new Guid("2ae605a5-e78b-40d6-9012-7edca1fbbcb6"),
				Name = @"PreviewImage",
				ReferenceSchemaUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("72bb9229-bf9b-410f-bf4b-8d4ea6902373"),
				ModifiedInSchemaUId = new Guid("72bb9229-bf9b-410f-bf4b-8d4ea6902373"),
				CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18")
			};
		}

		protected virtual EntitySchemaColumn CreatePositionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("0eb8f654-d324-4e87-9268-9eab4d9bbc21"),
				Name = @"Position",
				CreatedInSchemaUId = new Guid("72bb9229-bf9b-410f-bf4b-8d4ea6902373"),
				ModifiedInSchemaUId = new Guid("72bb9229-bf9b-410f-bf4b-8d4ea6902373"),
				CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"0"
				}
			};
		}

		protected virtual EntitySchemaColumn CreatePageSchemaNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("5f4aaeb3-79db-426a-b1d5-d66ee7117661"),
				Name = @"PageSchemaName",
				CreatedInSchemaUId = new Guid("72bb9229-bf9b-410f-bf4b-8d4ea6902373"),
				ModifiedInSchemaUId = new Guid("72bb9229-bf9b-410f-bf4b-8d4ea6902373"),
				CreatedInPackageId = new Guid("35c77563-f7ec-4c0b-91e3-f2665bae1236")
			};
		}

		protected virtual EntitySchemaColumn CreateSchemaCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("ae552c49-b2b0-4636-9977-cf1a096c01bb"),
				Name = @"SchemaCaption",
				CreatedInSchemaUId = new Guid("72bb9229-bf9b-410f-bf4b-8d4ea6902373"),
				ModifiedInSchemaUId = new Guid("72bb9229-bf9b-410f-bf4b-8d4ea6902373"),
				CreatedInPackageId = new Guid("35c77563-f7ec-4c0b-91e3-f2665bae1236"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateSchemaDescriptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("9cc7ee54-1daa-4527-9d3b-f2f4ddba4ac3"),
				Name = @"SchemaDescription",
				CreatedInSchemaUId = new Guid("72bb9229-bf9b-410f-bf4b-8d4ea6902373"),
				ModifiedInSchemaUId = new Guid("72bb9229-bf9b-410f-bf4b-8d4ea6902373"),
				CreatedInPackageId = new Guid("35c77563-f7ec-4c0b-91e3-f2665bae1236")
			};
		}

		protected virtual EntitySchemaColumn CreateSysSchemaIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("2ed304b0-a137-45c2-965a-46c5c94930de"),
				Name = @"SysSchemaId",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("72bb9229-bf9b-410f-bf4b-8d4ea6902373"),
				ModifiedInSchemaUId = new Guid("72bb9229-bf9b-410f-bf4b-8d4ea6902373"),
				CreatedInPackageId = new Guid("74e52e89-9f33-4c12-a993-b0f067e33756")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwPageTemplateEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwPageTemplateEventsProcessSchema() {
			var schema = new VwPageTemplateEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwPageTemplate(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwPageTemplate_WizardsEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwPageTemplateSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwPageTemplateSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("72bb9229-bf9b-410f-bf4b-8d4ea6902373"));
		}

		#endregion

	}

	#endregion

	#region Class: VwPageTemplate

	/// <summary>
	/// VwPageTemplate (view).
	/// </summary>
	public class VwPageTemplate : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public VwPageTemplate(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwPageTemplate";
		}

		public VwPageTemplate(VwPageTemplate source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// PageSchemaUId.
		/// </summary>
		public Guid PageSchemaUId {
			get {
				return GetTypedColumnValue<Guid>("PageSchemaUId");
			}
			set {
				SetColumnValue("PageSchemaUId", value);
			}
		}

		/// <exclude/>
		public Guid PreviewImageId {
			get {
				return GetTypedColumnValue<Guid>("PreviewImageId");
			}
			set {
				SetColumnValue("PreviewImageId", value);
				_previewImage = null;
			}
		}

		/// <exclude/>
		public string PreviewImageName {
			get {
				return GetTypedColumnValue<string>("PreviewImageName");
			}
			set {
				SetColumnValue("PreviewImageName", value);
				if (_previewImage != null) {
					_previewImage.Name = value;
				}
			}
		}

		private SysImage _previewImage;
		/// <summary>
		/// Preview image.
		/// </summary>
		public SysImage PreviewImage {
			get {
				return _previewImage ??
					(_previewImage = LookupColumnEntities.GetEntity("PreviewImage") as SysImage);
			}
		}

		/// <summary>
		/// Position.
		/// </summary>
		public int Position {
			get {
				return GetTypedColumnValue<int>("Position");
			}
			set {
				SetColumnValue("Position", value);
			}
		}

		/// <summary>
		/// Schema name.
		/// </summary>
		public string PageSchemaName {
			get {
				return GetTypedColumnValue<string>("PageSchemaName");
			}
			set {
				SetColumnValue("PageSchemaName", value);
			}
		}

		/// <summary>
		/// Schema caption.
		/// </summary>
		public string SchemaCaption {
			get {
				return GetTypedColumnValue<string>("SchemaCaption");
			}
			set {
				SetColumnValue("SchemaCaption", value);
			}
		}

		/// <summary>
		/// Schema description.
		/// </summary>
		public string SchemaDescription {
			get {
				return GetTypedColumnValue<string>("SchemaDescription");
			}
			set {
				SetColumnValue("SchemaDescription", value);
			}
		}

		/// <summary>
		/// SysSchemaId.
		/// </summary>
		public Guid SysSchemaId {
			get {
				return GetTypedColumnValue<Guid>("SysSchemaId");
			}
			set {
				SetColumnValue("SysSchemaId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwPageTemplate_WizardsEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwPageTemplateDeleted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwPageTemplate(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwPageTemplate_WizardsEventsProcess

	/// <exclude/>
	public partial class VwPageTemplate_WizardsEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : VwPageTemplate
	{

		public VwPageTemplate_WizardsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwPageTemplate_WizardsEventsProcess";
			SchemaUId = new Guid("72bb9229-bf9b-410f-bf4b-8d4ea6902373");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("72bb9229-bf9b-410f-bf4b-8d4ea6902373");
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

	#region Class: VwPageTemplate_WizardsEventsProcess

	/// <exclude/>
	public class VwPageTemplate_WizardsEventsProcess : VwPageTemplate_WizardsEventsProcess<VwPageTemplate>
	{

		public VwPageTemplate_WizardsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwPageTemplate_WizardsEventsProcess

	public partial class VwPageTemplate_WizardsEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: VwPageTemplateEventsProcessSchema

	/// <exclude/>
	public class VwPageTemplateEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public VwPageTemplateEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwPageTemplateEventsProcessSchema(VwPageTemplateEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwPageTemplate_WizardsEventsProcess";
			UId = new Guid("7907a9b0-2ede-40cd-bce9-5d0f8ed737d7");
			CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
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
			return new VwPageTemplateEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7907a9b0-2ede-40cd-bce9-5d0f8ed737d7"));
		}

		#endregion

	}

	#endregion


	#region Class: VwPageTemplateEventsProcess

	/// <exclude/>
	public class VwPageTemplateEventsProcess : VwPageTemplate_WizardsEventsProcess
	{

		public VwPageTemplateEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

