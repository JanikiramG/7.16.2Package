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

	#region Class: EmailTemplateSchema

	/// <exclude/>
	public class EmailTemplateSchema : Terrasoft.Configuration.EmailTemplate_Base_TerrasoftSchema
	{

		#region Constructors: Public

		public EmailTemplateSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public EmailTemplateSchema(EmailTemplateSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public EmailTemplateSchema(EmailTemplateSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("40f5736d-c37a-458a-8281-9ad1a30a2626");
			Name = "EmailTemplate";
			ParentSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63");
			ExtendParent = true;
			CreatedInPackageId = new Guid("1e4ad1e5-2250-4ed2-b7a6-c8515fbf7a50");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("f73ea119-e10f-4db3-a89f-02b338f69444")) == null) {
				Columns.Add(CreateConfigTypeColumn());
			}
			if (Columns.FindByUId(new Guid("1fea7f02-7faa-4a8b-a1f9-ee4e05fef97d")) == null) {
				Columns.Add(CreatePreviewImageColumn());
			}
		}

		protected override EntitySchemaColumn CreateObjectColumn() {
			EntitySchemaColumn column = base.CreateObjectColumn();
			column.ModifiedInSchemaUId = new Guid("40f5736d-c37a-458a-8281-9ad1a30a2626");
			return column;
		}

		protected override EntitySchemaColumn CreateTemplateConfigColumn() {
			EntitySchemaColumn column = base.CreateTemplateConfigColumn();
			column.IsLocalizable = false;
			column.ModifiedInSchemaUId = new Guid("40f5736d-c37a-458a-8281-9ad1a30a2626");
			return column;
		}

		protected virtual EntitySchemaColumn CreateConfigTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("f73ea119-e10f-4db3-a89f-02b338f69444"),
				Name = @"ConfigType",
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("40f5736d-c37a-458a-8281-9ad1a30a2626"),
				ModifiedInSchemaUId = new Guid("40f5736d-c37a-458a-8281-9ad1a30a2626"),
				CreatedInPackageId = new Guid("575d1c0e-f3b6-4688-ab25-9f9b4dae2d69"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"0"
				}
			};
		}

		protected virtual EntitySchemaColumn CreatePreviewImageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("1fea7f02-7faa-4a8b-a1f9-ee4e05fef97d"),
				Name = @"PreviewImage",
				ReferenceSchemaUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("40f5736d-c37a-458a-8281-9ad1a30a2626"),
				ModifiedInSchemaUId = new Guid("40f5736d-c37a-458a-8281-9ad1a30a2626"),
				CreatedInPackageId = new Guid("575d1c0e-f3b6-4688-ab25-9f9b4dae2d69")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateEmailTemplateEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateEmailTemplateEventsProcessSchema() {
			var schema = new EmailTemplateEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new EmailTemplate(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new EmailTemplate_EmailTemplateEventsProcess(userConnection);
		}

		public override object Clone() {
			return new EmailTemplateSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new EmailTemplateSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("40f5736d-c37a-458a-8281-9ad1a30a2626"));
		}

		#endregion

	}

	#endregion

	#region Class: EmailTemplate

	/// <summary>
	/// Email message template.
	/// </summary>
	public class EmailTemplate : Terrasoft.Configuration.EmailTemplate_Base_Terrasoft
	{

		#region Constructors: Public

		public EmailTemplate(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "EmailTemplate";
		}

		public EmailTemplate(EmailTemplate source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Config type.
		/// </summary>
		public int ConfigType {
			get {
				return GetTypedColumnValue<int>("ConfigType");
			}
			set {
				SetColumnValue("ConfigType", value);
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

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new EmailTemplate_EmailTemplateEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("EmailTemplateDeleted", e);
			Validating += (s, e) => ThrowEvent("EmailTemplateValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new EmailTemplate(this);
		}

		#endregion

	}

	#endregion

	#region Class: EmailTemplate_EmailTemplateEventsProcess

	/// <exclude/>
	public partial class EmailTemplate_EmailTemplateEventsProcess<TEntity> : Terrasoft.Configuration.EmailTemplate_BaseEventsProcess<TEntity> where TEntity : EmailTemplate
	{

		public EmailTemplate_EmailTemplateEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "EmailTemplate_EmailTemplateEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("40f5736d-c37a-458a-8281-9ad1a30a2626");
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

	#region Class: EmailTemplate_EmailTemplateEventsProcess

	/// <exclude/>
	public class EmailTemplate_EmailTemplateEventsProcess : EmailTemplate_EmailTemplateEventsProcess<EmailTemplate>
	{

		public EmailTemplate_EmailTemplateEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: EmailTemplate_EmailTemplateEventsProcess

	public partial class EmailTemplate_EmailTemplateEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: EmailTemplateEventsProcessSchema

	/// <exclude/>
	public class EmailTemplateEventsProcessSchema : Terrasoft.Configuration.EmailTemplate_Base_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public EmailTemplateEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public EmailTemplateEventsProcessSchema(EmailTemplateEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "EmailTemplate_EmailTemplateEventsProcess";
			UId = new Guid("55a6b689-14c2-45a3-b413-129c15c066c9");
			CreatedInPackageId = new Guid("1e4ad1e5-2250-4ed2-b7a6-c8515fbf7a50");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("efc63865-6d60-4074-83b9-f5ff2ec419fc");
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
			return new EmailTemplateEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("55a6b689-14c2-45a3-b413-129c15c066c9"));
		}

		#endregion

	}

	#endregion


	#region Class: EmailTemplateEventsProcess

	/// <exclude/>
	public class EmailTemplateEventsProcess : EmailTemplate_EmailTemplateEventsProcess
	{

		public EmailTemplateEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

