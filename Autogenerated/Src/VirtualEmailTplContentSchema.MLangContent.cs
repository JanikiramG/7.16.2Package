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

	#region Class: VirtualEmailTplContentSchema

	/// <exclude/>
	[IsVirtual]
	public class VirtualEmailTplContentSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public VirtualEmailTplContentSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VirtualEmailTplContentSchema(VirtualEmailTplContentSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VirtualEmailTplContentSchema(VirtualEmailTplContentSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f686b19c-d72a-43be-8299-43399e2e2b77");
			RealUId = new Guid("f686b19c-d72a-43be-8299-43399e2e2b77");
			Name = "VirtualEmailTplContent";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("d5fe5418-b108-401a-ba83-ff1213a966db");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("02d0342a-ac04-4f31-973e-c0a23eaf2126")) == null) {
				Columns.Add(CreateSubjectColumn());
			}
			if (Columns.FindByUId(new Guid("628b0ab8-226d-4671-b0fb-12643e84285e")) == null) {
				Columns.Add(CreateBodyColumn());
			}
			if (Columns.FindByUId(new Guid("4602655d-da79-4105-915a-1ceeefdc7ba2")) == null) {
				Columns.Add(CreateLanguageColumn());
			}
			if (Columns.FindByUId(new Guid("1033d91f-ac7f-4eb6-8c45-9b82b11ea665")) == null) {
				Columns.Add(CreateLanguageCodeColumn());
			}
			if (Columns.FindByUId(new Guid("d0a7f111-2770-4463-835c-02a979f8d6c5")) == null) {
				Columns.Add(CreateMacrosColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSubjectColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("02d0342a-ac04-4f31-973e-c0a23eaf2126"),
				Name = @"Subject",
				CreatedInSchemaUId = new Guid("f686b19c-d72a-43be-8299-43399e2e2b77"),
				ModifiedInSchemaUId = new Guid("f686b19c-d72a-43be-8299-43399e2e2b77"),
				CreatedInPackageId = new Guid("d5fe5418-b108-401a-ba83-ff1213a966db")
			};
		}

		protected virtual EntitySchemaColumn CreateBodyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("628b0ab8-226d-4671-b0fb-12643e84285e"),
				Name = @"Body",
				CreatedInSchemaUId = new Guid("f686b19c-d72a-43be-8299-43399e2e2b77"),
				ModifiedInSchemaUId = new Guid("f686b19c-d72a-43be-8299-43399e2e2b77"),
				CreatedInPackageId = new Guid("d5fe5418-b108-401a-ba83-ff1213a966db")
			};
		}

		protected virtual EntitySchemaColumn CreateLanguageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("4602655d-da79-4105-915a-1ceeefdc7ba2"),
				Name = @"Language",
				ReferenceSchemaUId = new Guid("2f96cb61-7e14-41e5-980a-bcb856edab51"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("f686b19c-d72a-43be-8299-43399e2e2b77"),
				ModifiedInSchemaUId = new Guid("f686b19c-d72a-43be-8299-43399e2e2b77"),
				CreatedInPackageId = new Guid("d5fe5418-b108-401a-ba83-ff1213a966db")
			};
		}

		protected virtual EntitySchemaColumn CreateLanguageCodeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("1033d91f-ac7f-4eb6-8c45-9b82b11ea665"),
				Name = @"LanguageCode",
				CreatedInSchemaUId = new Guid("f686b19c-d72a-43be-8299-43399e2e2b77"),
				ModifiedInSchemaUId = new Guid("f686b19c-d72a-43be-8299-43399e2e2b77"),
				CreatedInPackageId = new Guid("f767c979-312c-4d92-9d28-97b2835309c5")
			};
		}

		protected virtual EntitySchemaColumn CreateMacrosColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Binary")) {
				UId = new Guid("d0a7f111-2770-4463-835c-02a979f8d6c5"),
				Name = @"Macros",
				CreatedInSchemaUId = new Guid("f686b19c-d72a-43be-8299-43399e2e2b77"),
				ModifiedInSchemaUId = new Guid("f686b19c-d72a-43be-8299-43399e2e2b77"),
				CreatedInPackageId = new Guid("f767c979-312c-4d92-9d28-97b2835309c5")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVirtualEmailTplContentEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVirtualEmailTplContentEventsProcessSchema() {
			var schema = new VirtualEmailTplContentEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VirtualEmailTplContent(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VirtualEmailTplContent_MLangContentEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VirtualEmailTplContentSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VirtualEmailTplContentSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f686b19c-d72a-43be-8299-43399e2e2b77"));
		}

		#endregion

	}

	#endregion

	#region Class: VirtualEmailTplContent

	/// <summary>
	/// VirtualEmailTplContent.
	/// </summary>
	public class VirtualEmailTplContent : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public VirtualEmailTplContent(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VirtualEmailTplContent";
		}

		public VirtualEmailTplContent(VirtualEmailTplContent source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Email subject.
		/// </summary>
		public string Subject {
			get {
				return GetTypedColumnValue<string>("Subject");
			}
			set {
				SetColumnValue("Subject", value);
			}
		}

		/// <summary>
		/// Body.
		/// </summary>
		public string Body {
			get {
				return GetTypedColumnValue<string>("Body");
			}
			set {
				SetColumnValue("Body", value);
			}
		}

		/// <exclude/>
		public Guid LanguageId {
			get {
				return GetTypedColumnValue<Guid>("LanguageId");
			}
			set {
				SetColumnValue("LanguageId", value);
				_language = null;
			}
		}

		/// <exclude/>
		public string LanguageName {
			get {
				return GetTypedColumnValue<string>("LanguageName");
			}
			set {
				SetColumnValue("LanguageName", value);
				if (_language != null) {
					_language.Name = value;
				}
			}
		}

		private SysLanguage _language;
		/// <summary>
		/// Template language.
		/// </summary>
		public SysLanguage Language {
			get {
				return _language ??
					(_language = LookupColumnEntities.GetEntity("Language") as SysLanguage);
			}
		}

		/// <summary>
		/// Language code.
		/// </summary>
		public string LanguageCode {
			get {
				return GetTypedColumnValue<string>("LanguageCode");
			}
			set {
				SetColumnValue("LanguageCode", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VirtualEmailTplContent_MLangContentEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VirtualEmailTplContentDeleted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VirtualEmailTplContent(this);
		}

		#endregion

	}

	#endregion

	#region Class: VirtualEmailTplContent_MLangContentEventsProcess

	/// <exclude/>
	public partial class VirtualEmailTplContent_MLangContentEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : VirtualEmailTplContent
	{

		public VirtualEmailTplContent_MLangContentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VirtualEmailTplContent_MLangContentEventsProcess";
			SchemaUId = new Guid("f686b19c-d72a-43be-8299-43399e2e2b77");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f686b19c-d72a-43be-8299-43399e2e2b77");
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

	#region Class: VirtualEmailTplContent_MLangContentEventsProcess

	/// <exclude/>
	public class VirtualEmailTplContent_MLangContentEventsProcess : VirtualEmailTplContent_MLangContentEventsProcess<VirtualEmailTplContent>
	{

		public VirtualEmailTplContent_MLangContentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VirtualEmailTplContent_MLangContentEventsProcess

	public partial class VirtualEmailTplContent_MLangContentEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: VirtualEmailTplContentEventsProcessSchema

	/// <exclude/>
	public class VirtualEmailTplContentEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public VirtualEmailTplContentEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VirtualEmailTplContentEventsProcessSchema(VirtualEmailTplContentEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VirtualEmailTplContent_MLangContentEventsProcess";
			UId = new Guid("1d63b3eb-ed3e-431c-a44c-dd3924293b85");
			CreatedInPackageId = new Guid("d5fe5418-b108-401a-ba83-ff1213a966db");
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
			return new VirtualEmailTplContentEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1d63b3eb-ed3e-431c-a44c-dd3924293b85"));
		}

		#endregion

	}

	#endregion


	#region Class: VirtualEmailTplContentEventsProcess

	/// <exclude/>
	public class VirtualEmailTplContentEventsProcess : VirtualEmailTplContent_MLangContentEventsProcess
	{

		public VirtualEmailTplContentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

