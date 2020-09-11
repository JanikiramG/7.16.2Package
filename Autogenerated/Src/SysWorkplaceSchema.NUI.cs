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

	#region Class: SysWorkplaceSchema

	/// <exclude/>
	public class SysWorkplaceSchema : Terrasoft.Configuration.BaseEntityWithPositionSchema
	{

		#region Constructors: Public

		public SysWorkplaceSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysWorkplaceSchema(SysWorkplaceSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysWorkplaceSchema(SysWorkplaceSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f54121e1-d75d-42e0-b790-bc8aa0bb216c");
			RealUId = new Guid("f54121e1-d75d-42e0-b790-bc8aa0bb216c");
			Name = "SysWorkplace";
			ParentSchemaUId = new Guid("73d33bed-4682-45cb-ad25-a29b5ab88c96");
			ExtendParent = false;
			CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb");
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
			if (Columns.FindByUId(new Guid("cd8bcb82-b061-468d-bcce-a5a9312866e4")) == null) {
				Columns.Add(CreateIsPersonalColumn());
			}
			if (Columns.FindByUId(new Guid("8fe2b261-a69f-4846-bf82-f36e564d0aa4")) == null) {
				Columns.Add(CreateLoaderIdColumn());
			}
			if (Columns.FindByUId(new Guid("445c4583-2f21-4d2b-a6ba-c33108797ae0")) == null) {
				Columns.Add(CreateSysApplicationClientTypeColumn());
			}
			if (Columns.FindByUId(new Guid("dae36990-bfb4-4f13-ae18-1b18b6081983")) == null) {
				Columns.Add(CreateTypeColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("f54121e1-d75d-42e0-b790-bc8aa0bb216c");
			column.CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("f54121e1-d75d-42e0-b790-bc8aa0bb216c");
			column.CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("f54121e1-d75d-42e0-b790-bc8aa0bb216c");
			column.CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("f54121e1-d75d-42e0-b790-bc8aa0bb216c");
			column.CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("f54121e1-d75d-42e0-b790-bc8aa0bb216c");
			column.CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("f54121e1-d75d-42e0-b790-bc8aa0bb216c");
			column.CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb");
			return column;
		}

		protected override EntitySchemaColumn CreatePositionColumn() {
			EntitySchemaColumn column = base.CreatePositionColumn();
			column.ModifiedInSchemaUId = new Guid("f54121e1-d75d-42e0-b790-bc8aa0bb216c");
			column.CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb");
			return column;
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("215e82ee-20b0-4aa2-af3b-ff06cbc6da52"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("f54121e1-d75d-42e0-b790-bc8aa0bb216c"),
				ModifiedInSchemaUId = new Guid("f54121e1-d75d-42e0-b790-bc8aa0bb216c"),
				CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateIsPersonalColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("cd8bcb82-b061-468d-bcce-a5a9312866e4"),
				Name = @"IsPersonal",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("f54121e1-d75d-42e0-b790-bc8aa0bb216c"),
				ModifiedInSchemaUId = new Guid("f54121e1-d75d-42e0-b790-bc8aa0bb216c"),
				CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb")
			};
		}

		protected virtual EntitySchemaColumn CreateLoaderIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("8fe2b261-a69f-4846-bf82-f36e564d0aa4"),
				Name = @"LoaderId",
				CreatedInSchemaUId = new Guid("f54121e1-d75d-42e0-b790-bc8aa0bb216c"),
				ModifiedInSchemaUId = new Guid("f54121e1-d75d-42e0-b790-bc8aa0bb216c"),
				CreatedInPackageId = new Guid("2c390582-306b-458b-afe1-2a3764ac60ce"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"3707a058-e6a8-4d2c-99cc-d01d9e6b70c6"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateSysApplicationClientTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("445c4583-2f21-4d2b-a6ba-c33108797ae0"),
				Name = @"SysApplicationClientType",
				ReferenceSchemaUId = new Guid("7d37b67c-f2b0-47d1-a0c5-6215d21984ba"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("f54121e1-d75d-42e0-b790-bc8aa0bb216c"),
				ModifiedInSchemaUId = new Guid("f54121e1-d75d-42e0-b790-bc8aa0bb216c"),
				CreatedInPackageId = new Guid("4f457753-d1f1-4b18-9761-0022b465f28b"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"195785b4-f55a-4e72-ace3-6480b54c8fa5"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("dae36990-bfb4-4f13-ae18-1b18b6081983"),
				Name = @"Type",
				ReferenceSchemaUId = new Guid("fa47b7e0-90e2-4763-93c7-ca0b6ea935c5"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("f54121e1-d75d-42e0-b790-bc8aa0bb216c"),
				ModifiedInSchemaUId = new Guid("f54121e1-d75d-42e0-b790-bc8aa0bb216c"),
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"000a9225-728b-4778-a951-c42439ffe024"
				}
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysWorkplaceEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysWorkplaceEventsProcessSchema() {
			var schema = new SysWorkplaceEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysWorkplace(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysWorkplace_NUIEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysWorkplaceSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysWorkplaceSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f54121e1-d75d-42e0-b790-bc8aa0bb216c"));
		}

		#endregion

	}

	#endregion

	#region Class: SysWorkplace

	/// <summary>
	/// User's workplace.
	/// </summary>
	public class SysWorkplace : Terrasoft.Configuration.BaseEntityWithPosition
	{

		#region Constructors: Public

		public SysWorkplace(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysWorkplace";
		}

		public SysWorkplace(SysWorkplace source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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
		/// Personal.
		/// </summary>
		public bool IsPersonal {
			get {
				return GetTypedColumnValue<bool>("IsPersonal");
			}
			set {
				SetColumnValue("IsPersonal", value);
			}
		}

		/// <summary>
		/// Workplace loader schema.
		/// </summary>
		public Guid LoaderId {
			get {
				return GetTypedColumnValue<Guid>("LoaderId");
			}
			set {
				SetColumnValue("LoaderId", value);
			}
		}

		/// <exclude/>
		public Guid SysApplicationClientTypeId {
			get {
				return GetTypedColumnValue<Guid>("SysApplicationClientTypeId");
			}
			set {
				SetColumnValue("SysApplicationClientTypeId", value);
				_sysApplicationClientType = null;
			}
		}

		/// <exclude/>
		public string SysApplicationClientTypeName {
			get {
				return GetTypedColumnValue<string>("SysApplicationClientTypeName");
			}
			set {
				SetColumnValue("SysApplicationClientTypeName", value);
				if (_sysApplicationClientType != null) {
					_sysApplicationClientType.Name = value;
				}
			}
		}

		private SysApplicationClientType _sysApplicationClientType;
		/// <summary>
		/// Application type.
		/// </summary>
		public SysApplicationClientType SysApplicationClientType {
			get {
				return _sysApplicationClientType ??
					(_sysApplicationClientType = LookupColumnEntities.GetEntity("SysApplicationClientType") as SysApplicationClientType);
			}
		}

		/// <exclude/>
		public Guid TypeId {
			get {
				return GetTypedColumnValue<Guid>("TypeId");
			}
			set {
				SetColumnValue("TypeId", value);
				_type = null;
			}
		}

		/// <exclude/>
		public string TypeName {
			get {
				return GetTypedColumnValue<string>("TypeName");
			}
			set {
				SetColumnValue("TypeName", value);
				if (_type != null) {
					_type.Name = value;
				}
			}
		}

		private SysWorkplaceType _type;
		/// <summary>
		/// Type.
		/// </summary>
		public SysWorkplaceType Type {
			get {
				return _type ??
					(_type = LookupColumnEntities.GetEntity("Type") as SysWorkplaceType);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysWorkplace_NUIEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Validating += (s, e) => ThrowEvent("SysWorkplaceValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysWorkplace(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysWorkplace_NUIEventsProcess

	/// <exclude/>
	public partial class SysWorkplace_NUIEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntityWithPosition_BaseEventsProcess<TEntity> where TEntity : SysWorkplace
	{

		public SysWorkplace_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysWorkplace_NUIEventsProcess";
			SchemaUId = new Guid("f54121e1-d75d-42e0-b790-bc8aa0bb216c");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f54121e1-d75d-42e0-b790-bc8aa0bb216c");
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

	#region Class: SysWorkplace_NUIEventsProcess

	/// <exclude/>
	public class SysWorkplace_NUIEventsProcess : SysWorkplace_NUIEventsProcess<SysWorkplace>
	{

		public SysWorkplace_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysWorkplace_NUIEventsProcess

	public partial class SysWorkplace_NUIEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void BaseEntityWithPositionInserting() {
			if (UserConnection.GetIsFeatureEnabled("NewWorkplaceUI")) {
				return;
			}
			base.BaseEntityWithPositionInserting();
		}

		public override void BaseEntityWithPositionDeleted() {
			if (UserConnection.GetIsFeatureEnabled("NewWorkplaceUI")) {
				return;
			}
			base.BaseEntityWithPositionDeleted();
		}

		#endregion

	}

	#endregion

	#region Class: SysWorkplaceEventsProcessSchema

	/// <exclude/>
	public class SysWorkplaceEventsProcessSchema : Terrasoft.Configuration.BaseEntityWithPositionEventsProcessSchema
	{

		#region Constructors: Public

		public SysWorkplaceEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysWorkplaceEventsProcessSchema(SysWorkplaceEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysWorkplace_NUIEventsProcess";
			UId = new Guid("03473a2c-927f-4fb9-8f98-6a87861bf487");
			CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet2_f0d9145ecd0846619d4105bb20aaa7ff = CreateLaneSet2_f0d9145ecd0846619d4105bb20aaa7ffLaneSet();
			LaneSets.Add(schemaLaneSet2_f0d9145ecd0846619d4105bb20aaa7ff);
			ProcessSchemaLane schemaLane3_17b0e8a009614257a5975edb6c76b8a0 = CreateLane3_17b0e8a009614257a5975edb6c76b8a0Lane();
			schemaLaneSet2_f0d9145ecd0846619d4105bb20aaa7ff.Lanes.Add(schemaLane3_17b0e8a009614257a5975edb6c76b8a0);
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet2_f0d9145ecd0846619d4105bb20aaa7ffLaneSet() {
			ProcessSchemaLaneSet schemaLaneSet2_f0d9145ecd0846619d4105bb20aaa7ff = new ProcessSchemaLaneSet(this) {
				UId = new Guid("f0d9145e-cd08-4661-9d41-05bb20aaa7ff"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				CreatedInPackageId = new Guid("9735f166-4b01-4c20-b58c-0bd002ae38b1"),
				CreatedInSchemaUId = new Guid("03473a2c-927f-4fb9-8f98-6a87861bf487"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("03473a2c-927f-4fb9-8f98-6a87861bf487"),
				Name = @"LaneSet2_f0d9145ecd0846619d4105bb20aaa7ff",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet2_f0d9145ecd0846619d4105bb20aaa7ff;
		}

		protected virtual ProcessSchemaLane CreateLane3_17b0e8a009614257a5975edb6c76b8a0Lane() {
			ProcessSchemaLane schemaLane3_17b0e8a009614257a5975edb6c76b8a0 = new ProcessSchemaLane(this) {
				UId = new Guid("17b0e8a0-0961-4257-a597-5edb6c76b8a0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f0d9145e-cd08-4661-9d41-05bb20aaa7ff"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("9735f166-4b01-4c20-b58c-0bd002ae38b1"),
				CreatedInSchemaUId = new Guid("03473a2c-927f-4fb9-8f98-6a87861bf487"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("03473a2c-927f-4fb9-8f98-6a87861bf487"),
				Name = @"Lane3_17b0e8a009614257a5975edb6c76b8a0",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane3_17b0e8a009614257a5975edb6c76b8a0;
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
				CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb")
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

		protected override SchemaMethod CreateBaseEntityWithPositionInsertingMethod() {
			SchemaMethod method = base.CreateBaseEntityWithPositionInsertingMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,8,45,78,45,114,206,207,203,75,77,46,201,204,207,211,115,79,45,241,44,118,75,77,44,41,45,74,117,205,75,76,202,73,77,209,80,242,75,45,15,207,47,202,46,200,73,76,78,13,245,84,210,212,84,168,230,226,44,74,5,170,201,179,230,170,229,74,74,44,78,213,115,2,18,174,121,37,153,37,149,225,153,37,25,1,249,197,153,32,243,60,243,128,198,151,100,230,165,107,104,90,3,0,243,231,123,154,110,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateBaseEntityWithPositionDeletedMethod() {
			SchemaMethod method = base.CreateBaseEntityWithPositionDeletedMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,8,45,78,45,114,206,207,203,75,77,46,201,204,207,211,115,79,45,241,44,118,75,77,44,41,45,74,117,205,75,76,202,73,77,209,80,242,75,45,15,207,47,202,46,200,73,76,78,13,245,84,210,212,84,168,230,226,44,74,5,170,201,179,230,170,229,74,74,44,78,213,115,2,18,174,121,37,153,37,149,225,153,37,25,1,249,197,153,32,243,92,82,115,82,75,128,70,104,90,3,0,128,1,60,101,108,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysWorkplaceEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("03473a2c-927f-4fb9-8f98-6a87861bf487"));
		}

		#endregion

	}

	#endregion


	#region Class: SysWorkplaceEventsProcess

	/// <exclude/>
	public class SysWorkplaceEventsProcess : SysWorkplace_NUIEventsProcess
	{

		public SysWorkplaceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

