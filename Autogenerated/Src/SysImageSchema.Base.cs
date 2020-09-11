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

	#region Class: SysImageSchema

	/// <exclude/>
	public class SysImageSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysImageSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysImageSchema(SysImageSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysImageSchema(SysImageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8");
			RealUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8");
			Name = "SysImage";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("e2771718-9ef5-4118-8671-7ba5d8df475d");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("08ccfffd-cb3e-47c3-9729-1d043a5812e4")) == null) {
				Columns.Add(CreateUploadedOnColumn());
			}
			if (Columns.FindByUId(new Guid("1e236958-f206-4fde-8a0e-6783fc223424")) == null) {
				Columns.Add(CreateDataColumn());
			}
			if (Columns.FindByUId(new Guid("be95e737-14e9-4253-b0c4-e280da05434d")) == null) {
				Columns.Add(CreateMimeTypeColumn());
			}
			if (Columns.FindByUId(new Guid("b3cd8485-7bd8-4b70-b2dd-bc41e45e9992")) == null) {
				Columns.Add(CreateHasRefColumn());
			}
			if (Columns.FindByUId(new Guid("90801d7c-a189-4afe-9c3a-a202fbf242d8")) == null) {
				Columns.Add(CreatePreviewDataColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8");
			column.CreatedInPackageId = new Guid("e2771718-9ef5-4118-8671-7ba5d8df475d");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8");
			column.CreatedInPackageId = new Guid("e2771718-9ef5-4118-8671-7ba5d8df475d");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8");
			column.CreatedInPackageId = new Guid("e2771718-9ef5-4118-8671-7ba5d8df475d");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8");
			column.CreatedInPackageId = new Guid("e2771718-9ef5-4118-8671-7ba5d8df475d");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8");
			column.CreatedInPackageId = new Guid("e2771718-9ef5-4118-8671-7ba5d8df475d");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8");
			column.CreatedInPackageId = new Guid("e2771718-9ef5-4118-8671-7ba5d8df475d");
			return column;
		}

		protected virtual EntitySchemaColumn CreateUploadedOnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("08ccfffd-cb3e-47c3-9729-1d043a5812e4"),
				Name = @"UploadedOn",
				CreatedInSchemaUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8"),
				ModifiedInSchemaUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8"),
				CreatedInPackageId = new Guid("e2771718-9ef5-4118-8671-7ba5d8df475d")
			};
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("d245dcaf-23bd-4b73-8718-26fdf38b443b"),
				Name = @"Name",
				CreatedInSchemaUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8"),
				ModifiedInSchemaUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8"),
				CreatedInPackageId = new Guid("e2771718-9ef5-4118-8671-7ba5d8df475d")
			};
		}

		protected virtual EntitySchemaColumn CreateDataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Image")) {
				UId = new Guid("1e236958-f206-4fde-8a0e-6783fc223424"),
				Name = @"Data",
				CreatedInSchemaUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8"),
				ModifiedInSchemaUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8"),
				CreatedInPackageId = new Guid("e2771718-9ef5-4118-8671-7ba5d8df475d")
			};
		}

		protected virtual EntitySchemaColumn CreateMimeTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("be95e737-14e9-4253-b0c4-e280da05434d"),
				Name = @"MimeType",
				CreatedInSchemaUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8"),
				ModifiedInSchemaUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8"),
				CreatedInPackageId = new Guid("e2771718-9ef5-4118-8671-7ba5d8df475d")
			};
		}

		protected virtual EntitySchemaColumn CreateHasRefColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("b3cd8485-7bd8-4b70-b2dd-bc41e45e9992"),
				Name = @"HasRef",
				CreatedInSchemaUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8"),
				ModifiedInSchemaUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8"),
				CreatedInPackageId = new Guid("e2771718-9ef5-4118-8671-7ba5d8df475d")
			};
		}

		protected virtual EntitySchemaColumn CreatePreviewDataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Image")) {
				UId = new Guid("90801d7c-a189-4afe-9c3a-a202fbf242d8"),
				Name = @"PreviewData",
				CreatedInSchemaUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8"),
				ModifiedInSchemaUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8"),
				CreatedInPackageId = new Guid("29183b93-e7fb-42b1-9a18-ddad7f18075a")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysImageEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysImageEventsProcessSchema() {
			var schema = new SysImageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysImage(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysImage_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysImageSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysImageSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8"));
		}

		#endregion

	}

	#endregion

	#region Class: SysImage

	/// <summary>
	/// Image.
	/// </summary>
	public class SysImage : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysImage(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysImage";
		}

		public SysImage(SysImage source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Uploaded on.
		/// </summary>
		public DateTime UploadedOn {
			get {
				return GetTypedColumnValue<DateTime>("UploadedOn");
			}
			set {
				SetColumnValue("UploadedOn", value);
			}
		}

		/// <summary>
		/// Name.
		/// </summary>
		public string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

		/// <summary>
		/// MimeType.
		/// </summary>
		public string MimeType {
			get {
				return GetTypedColumnValue<string>("MimeType");
			}
			set {
				SetColumnValue("MimeType", value);
			}
		}

		/// <summary>
		/// Reference saved.
		/// </summary>
		public bool HasRef {
			get {
				return GetTypedColumnValue<bool>("HasRef");
			}
			set {
				SetColumnValue("HasRef", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysImage_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysImageDeleted", e);
			Inserting += (s, e) => ThrowEvent("SysImageInserting", e);
			Validating += (s, e) => ThrowEvent("SysImageValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysImage(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysImage_BaseEventsProcess

	/// <exclude/>
	public partial class SysImage_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysImage
	{

		public SysImage_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysImage_BaseEventsProcess";
			SchemaUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8");
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

	#region Class: SysImage_BaseEventsProcess

	/// <exclude/>
	public class SysImage_BaseEventsProcess : SysImage_BaseEventsProcess<SysImage>
	{

		public SysImage_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysImage_BaseEventsProcess

	public partial class SysImage_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysImageEventsProcessSchema

	/// <exclude/>
	public class SysImageEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysImageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysImageEventsProcessSchema(SysImageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysImage_BaseEventsProcess";
			UId = new Guid("e8ef4aa3-1384-48f2-97f5-4b31bbf7faf3");
			CreatedInPackageId = new Guid("e2771718-9ef5-4118-8671-7ba5d8df475d");
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
				CreatedInPackageId = new Guid("e2771718-9ef5-4118-8671-7ba5d8df475d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("e2771718-9ef5-4118-8671-7ba5d8df475d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("e2771718-9ef5-4118-8671-7ba5d8df475d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("e2771718-9ef5-4118-8671-7ba5d8df475d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("e2771718-9ef5-4118-8671-7ba5d8df475d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("e2771718-9ef5-4118-8671-7ba5d8df475d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("e2771718-9ef5-4118-8671-7ba5d8df475d")
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
			return new SysImageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e8ef4aa3-1384-48f2-97f5-4b31bbf7faf3"));
		}

		#endregion

	}

	#endregion


	#region Class: SysImageEventsProcess

	/// <exclude/>
	public class SysImageEventsProcess : SysImage_BaseEventsProcess
	{

		public SysImageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

