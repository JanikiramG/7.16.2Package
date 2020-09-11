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

	#region Class: IntroPageLookupSchema

	/// <exclude/>
	public class IntroPageLookupSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public IntroPageLookupSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public IntroPageLookupSchema(IntroPageLookupSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public IntroPageLookupSchema(IntroPageLookupSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5bf5c87a-6fe3-4d5e-9432-14f7fcc7b1c8");
			RealUId = new Guid("5bf5c87a-6fe3-4d5e-9432-14f7fcc7b1c8");
			Name = "IntroPageLookup";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("d717c1d0-1754-415d-a9f4-50065152a939");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateCodePageColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("63367d45-a96a-40b5-9d3d-3acbbedeff62")) == null) {
				Columns.Add(CreateAcademyUrlColumn());
			}
			if (Columns.FindByUId(new Guid("9001f045-69f7-482c-8e32-a9737674f261")) == null) {
				Columns.Add(CreateVideoUrlColumn());
			}
			if (Columns.FindByUId(new Guid("0cf82306-7f75-4096-965d-9f7cf3e55b19")) == null) {
				Columns.Add(CreateVideoCaptionColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCodePageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("e616bf14-23f4-4f6f-bff6-08540d790290"),
				Name = @"CodePage",
				CreatedInSchemaUId = new Guid("5bf5c87a-6fe3-4d5e-9432-14f7fcc7b1c8"),
				ModifiedInSchemaUId = new Guid("5bf5c87a-6fe3-4d5e-9432-14f7fcc7b1c8"),
				CreatedInPackageId = new Guid("d717c1d0-1754-415d-a9f4-50065152a939")
			};
		}

		protected virtual EntitySchemaColumn CreateAcademyUrlColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("63367d45-a96a-40b5-9d3d-3acbbedeff62"),
				Name = @"AcademyUrl",
				CreatedInSchemaUId = new Guid("5bf5c87a-6fe3-4d5e-9432-14f7fcc7b1c8"),
				ModifiedInSchemaUId = new Guid("5bf5c87a-6fe3-4d5e-9432-14f7fcc7b1c8"),
				CreatedInPackageId = new Guid("d717c1d0-1754-415d-a9f4-50065152a939"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateVideoUrlColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("9001f045-69f7-482c-8e32-a9737674f261"),
				Name = @"VideoUrl",
				CreatedInSchemaUId = new Guid("5bf5c87a-6fe3-4d5e-9432-14f7fcc7b1c8"),
				ModifiedInSchemaUId = new Guid("5bf5c87a-6fe3-4d5e-9432-14f7fcc7b1c8"),
				CreatedInPackageId = new Guid("d717c1d0-1754-415d-a9f4-50065152a939"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateVideoCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("0cf82306-7f75-4096-965d-9f7cf3e55b19"),
				Name = @"VideoCaption",
				CreatedInSchemaUId = new Guid("5bf5c87a-6fe3-4d5e-9432-14f7fcc7b1c8"),
				ModifiedInSchemaUId = new Guid("5bf5c87a-6fe3-4d5e-9432-14f7fcc7b1c8"),
				CreatedInPackageId = new Guid("d717c1d0-1754-415d-a9f4-50065152a939"),
				IsLocalizable = true
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateIntroPageLookupEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateIntroPageLookupEventsProcessSchema() {
			var schema = new IntroPageLookupEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new IntroPageLookup(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new IntroPageLookup_UIv2EventsProcess(userConnection);
		}

		public override object Clone() {
			return new IntroPageLookupSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new IntroPageLookupSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5bf5c87a-6fe3-4d5e-9432-14f7fcc7b1c8"));
		}

		#endregion

	}

	#endregion

	#region Class: IntroPageLookup

	/// <summary>
	/// Main page lookup.
	/// </summary>
	public class IntroPageLookup : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public IntroPageLookup(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "IntroPageLookup";
		}

		public IntroPageLookup(IntroPageLookup source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Page code.
		/// </summary>
		public string CodePage {
			get {
				return GetTypedColumnValue<string>("CodePage");
			}
			set {
				SetColumnValue("CodePage", value);
			}
		}

		/// <summary>
		/// Academy URL.
		/// </summary>
		public string AcademyUrl {
			get {
				return GetTypedColumnValue<string>("AcademyUrl");
			}
			set {
				SetColumnValue("AcademyUrl", value);
			}
		}

		/// <summary>
		/// Video URL.
		/// </summary>
		public string VideoUrl {
			get {
				return GetTypedColumnValue<string>("VideoUrl");
			}
			set {
				SetColumnValue("VideoUrl", value);
			}
		}

		/// <summary>
		/// Video caption.
		/// </summary>
		public string VideoCaption {
			get {
				return GetTypedColumnValue<string>("VideoCaption");
			}
			set {
				SetColumnValue("VideoCaption", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new IntroPageLookup_UIv2EventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("IntroPageLookupDeleted", e);
			Validating += (s, e) => ThrowEvent("IntroPageLookupValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new IntroPageLookup(this);
		}

		#endregion

	}

	#endregion

	#region Class: IntroPageLookup_UIv2EventsProcess

	/// <exclude/>
	public partial class IntroPageLookup_UIv2EventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : IntroPageLookup
	{

		public IntroPageLookup_UIv2EventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "IntroPageLookup_UIv2EventsProcess";
			SchemaUId = new Guid("5bf5c87a-6fe3-4d5e-9432-14f7fcc7b1c8");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5bf5c87a-6fe3-4d5e-9432-14f7fcc7b1c8");
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

	#region Class: IntroPageLookup_UIv2EventsProcess

	/// <exclude/>
	public class IntroPageLookup_UIv2EventsProcess : IntroPageLookup_UIv2EventsProcess<IntroPageLookup>
	{

		public IntroPageLookup_UIv2EventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: IntroPageLookup_UIv2EventsProcess

	public partial class IntroPageLookup_UIv2EventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: IntroPageLookupEventsProcessSchema

	/// <exclude/>
	public class IntroPageLookupEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public IntroPageLookupEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public IntroPageLookupEventsProcessSchema(IntroPageLookupEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "IntroPageLookup_UIv2EventsProcess";
			UId = new Guid("22bf3fee-fb91-4928-871c-80ff714a578b");
			CreatedInPackageId = new Guid("d717c1d0-1754-415d-a9f4-50065152a939");
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
			return new IntroPageLookupEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("22bf3fee-fb91-4928-871c-80ff714a578b"));
		}

		#endregion

	}

	#endregion


	#region Class: IntroPageLookupEventsProcess

	/// <exclude/>
	public class IntroPageLookupEventsProcess : IntroPageLookup_UIv2EventsProcess
	{

		public IntroPageLookupEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

