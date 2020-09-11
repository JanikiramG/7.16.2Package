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

	#region Class: SysProcessUserTaskSchema

	/// <exclude/>
	public class SysProcessUserTaskSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysProcessUserTaskSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysProcessUserTaskSchema(SysProcessUserTaskSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysProcessUserTaskSchema(SysProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("48f06023-1771-45a8-9963-ba4cbb5fb5c4");
			RealUId = new Guid("48f06023-1771-45a8-9963-ba4cbb5fb5c4");
			Name = "SysProcessUserTask";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateCaptionColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializePrimaryImageColumn() {
			base.InitializePrimaryImageColumn();
			PrimaryImageColumn = CreateSysImageColumn();
			if (Columns.FindByUId(PrimaryImageColumn.UId) == null) {
				Columns.Add(PrimaryImageColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("dca9757d-d70d-48d2-b9bc-a85adc98a857")) == null) {
				Columns.Add(CreateSysUserTaskSchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("665448a6-ddbc-4be1-a35d-591d24d89c8b")) == null) {
				Columns.Add(CreatePositionColumn());
			}
			if (Columns.FindByUId(new Guid("cba9c2d9-7f00-4e13-8d4b-9e7600756311")) == null) {
				Columns.Add(CreateQuickModelEditPageSchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("1197f3f5-40f7-4e19-b756-c5c98a7d0611")) == null) {
				Columns.Add(CreateIsQuickModelColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSysUserTaskSchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("dca9757d-d70d-48d2-b9bc-a85adc98a857"),
				Name = @"SysUserTaskSchemaUId",
				CreatedInSchemaUId = new Guid("48f06023-1771-45a8-9963-ba4cbb5fb5c4"),
				ModifiedInSchemaUId = new Guid("48f06023-1771-45a8-9963-ba4cbb5fb5c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreatePositionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("665448a6-ddbc-4be1-a35d-591d24d89c8b"),
				Name = @"Position",
				CreatedInSchemaUId = new Guid("48f06023-1771-45a8-9963-ba4cbb5fb5c4"),
				ModifiedInSchemaUId = new Guid("48f06023-1771-45a8-9963-ba4cbb5fb5c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateQuickModelEditPageSchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("cba9c2d9-7f00-4e13-8d4b-9e7600756311"),
				Name = @"QuickModelEditPageSchemaUId",
				CreatedInSchemaUId = new Guid("48f06023-1771-45a8-9963-ba4cbb5fb5c4"),
				ModifiedInSchemaUId = new Guid("48f06023-1771-45a8-9963-ba4cbb5fb5c4"),
				CreatedInPackageId = new Guid("30e6d260-e2d2-4b16-8917-37c7da363d32")
			};
		}

		protected virtual EntitySchemaColumn CreateIsQuickModelColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("1197f3f5-40f7-4e19-b756-c5c98a7d0611"),
				Name = @"IsQuickModel",
				CreatedInSchemaUId = new Guid("48f06023-1771-45a8-9963-ba4cbb5fb5c4"),
				ModifiedInSchemaUId = new Guid("48f06023-1771-45a8-9963-ba4cbb5fb5c4"),
				CreatedInPackageId = new Guid("30e6d260-e2d2-4b16-8917-37c7da363d32")
			};
		}

		protected virtual EntitySchemaColumn CreateCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("9ed509d4-808b-42dd-904d-10a3df4408fb"),
				Name = @"Caption",
				CreatedInSchemaUId = new Guid("48f06023-1771-45a8-9963-ba4cbb5fb5c4"),
				ModifiedInSchemaUId = new Guid("48f06023-1771-45a8-9963-ba4cbb5fb5c4"),
				CreatedInPackageId = new Guid("30e6d260-e2d2-4b16-8917-37c7da363d32")
			};
		}

		protected virtual EntitySchemaColumn CreateSysImageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ImageLookup")) {
				UId = new Guid("d357532d-5b37-4c1f-86ff-40beec3a4d12"),
				Name = @"SysImage",
				ReferenceSchemaUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("48f06023-1771-45a8-9963-ba4cbb5fb5c4"),
				ModifiedInSchemaUId = new Guid("48f06023-1771-45a8-9963-ba4cbb5fb5c4"),
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysProcessUserTaskEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysProcessUserTaskEventsProcessSchema() {
			var schema = new SysProcessUserTaskEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysProcessUserTask(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysProcessUserTask_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysProcessUserTaskSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysProcessUserTaskSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("48f06023-1771-45a8-9963-ba4cbb5fb5c4"));
		}

		#endregion

	}

	#endregion

	#region Class: SysProcessUserTask

	/// <summary>
	/// Process user task.
	/// </summary>
	public class SysProcessUserTask : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysProcessUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysProcessUserTask";
		}

		public SysProcessUserTask(SysProcessUserTask source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Identifier of user task.
		/// </summary>
		public Guid SysUserTaskSchemaUId {
			get {
				return GetTypedColumnValue<Guid>("SysUserTaskSchemaUId");
			}
			set {
				SetColumnValue("SysUserTaskSchemaUId", value);
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
		/// UserTask page schema for QuickModel.
		/// </summary>
		public Guid QuickModelEditPageSchemaUId {
			get {
				return GetTypedColumnValue<Guid>("QuickModelEditPageSchemaUId");
			}
			set {
				SetColumnValue("QuickModelEditPageSchemaUId", value);
			}
		}

		/// <summary>
		/// QuickModel-compatible.
		/// </summary>
		public bool IsQuickModel {
			get {
				return GetTypedColumnValue<bool>("IsQuickModel");
			}
			set {
				SetColumnValue("IsQuickModel", value);
			}
		}

		/// <summary>
		/// Name.
		/// </summary>
		public string Caption {
			get {
				return GetTypedColumnValue<string>("Caption");
			}
			set {
				SetColumnValue("Caption", value);
			}
		}

		/// <exclude/>
		public Guid SysImageId {
			get {
				return GetTypedColumnValue<Guid>("SysImageId");
			}
			set {
				SetColumnValue("SysImageId", value);
				_sysImage = null;
			}
		}

		/// <exclude/>
		public string SysImageName {
			get {
				return GetTypedColumnValue<string>("SysImageName");
			}
			set {
				SetColumnValue("SysImageName", value);
				if (_sysImage != null) {
					_sysImage.Name = value;
				}
			}
		}

		private SysImage _sysImage;
		/// <summary>
		/// Image.
		/// </summary>
		public SysImage SysImage {
			get {
				return _sysImage ??
					(_sysImage = LookupColumnEntities.GetEntity("SysImage") as SysImage);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysProcessUserTask_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysProcessUserTaskDeleted", e);
			Inserting += (s, e) => ThrowEvent("SysProcessUserTaskInserting", e);
			Validating += (s, e) => ThrowEvent("SysProcessUserTaskValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysProcessUserTask(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysProcessUserTask_BaseEventsProcess

	/// <exclude/>
	public partial class SysProcessUserTask_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysProcessUserTask
	{

		public SysProcessUserTask_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysProcessUserTask_BaseEventsProcess";
			SchemaUId = new Guid("48f06023-1771-45a8-9963-ba4cbb5fb5c4");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("48f06023-1771-45a8-9963-ba4cbb5fb5c4");
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

	#region Class: SysProcessUserTask_BaseEventsProcess

	/// <exclude/>
	public class SysProcessUserTask_BaseEventsProcess : SysProcessUserTask_BaseEventsProcess<SysProcessUserTask>
	{

		public SysProcessUserTask_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysProcessUserTask_BaseEventsProcess

	public partial class SysProcessUserTask_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysProcessUserTaskEventsProcessSchema

	/// <exclude/>
	public class SysProcessUserTaskEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysProcessUserTaskEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysProcessUserTaskEventsProcessSchema(SysProcessUserTaskEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysProcessUserTask_BaseEventsProcess";
			UId = new Guid("f0ef44a8-1e0b-4a41-813a-9fcb19f3d839");
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
			return new SysProcessUserTaskEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f0ef44a8-1e0b-4a41-813a-9fcb19f3d839"));
		}

		#endregion

	}

	#endregion


	#region Class: SysProcessUserTaskEventsProcess

	/// <exclude/>
	public class SysProcessUserTaskEventsProcess : SysProcessUserTask_BaseEventsProcess
	{

		public SysProcessUserTaskEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

