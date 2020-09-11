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

	#region Class: ForecastColumnSchema

	/// <exclude/>
	public class ForecastColumnSchema : Terrasoft.Configuration.BaseEntityWithPositionSchema
	{

		#region Constructors: Public

		public ForecastColumnSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ForecastColumnSchema(ForecastColumnSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ForecastColumnSchema(ForecastColumnSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("321d7bc3-45fe-41f8-af38-6643602b116d");
			RealUId = new Guid("321d7bc3-45fe-41f8-af38-6643602b116d");
			Name = "ForecastColumn";
			ParentSchemaUId = new Guid("73d33bed-4682-45cb-ad25-a29b5ab88c96");
			ExtendParent = false;
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateTitleColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeMasterRecordColumn() {
			base.InitializeMasterRecordColumn();
			MasterRecordColumn = CreateSheetColumn();
			if (Columns.FindByUId(MasterRecordColumn.UId) == null) {
				Columns.Add(MasterRecordColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("7e0f01d8-2a05-4f68-aaa7-5d4a31a988a2")) == null) {
				Columns.Add(CreateIndicatorColumn());
			}
			if (Columns.FindByUId(new Guid("4e1b5056-a250-45bc-baf5-743f632644cf")) == null) {
				Columns.Add(CreateSettingsColumn());
			}
			if (Columns.FindByUId(new Guid("df4002ec-7efa-4d3f-8214-b42bff6def2e")) == null) {
				Columns.Add(CreateTypeColumn());
			}
			if (Columns.FindByUId(new Guid("e28b7cde-7e8f-4ca5-8bea-b9a3bccb6bf7")) == null) {
				Columns.Add(CreateIsHideColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSheetColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("5157b14b-d02d-4b41-b7f6-7fbbfdf32b96"),
				Name = @"Sheet",
				ReferenceSchemaUId = new Guid("f97c7d7a-e614-4850-8ec4-98d8af22b3d0"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("321d7bc3-45fe-41f8-af38-6643602b116d"),
				ModifiedInSchemaUId = new Guid("321d7bc3-45fe-41f8-af38-6643602b116d"),
				CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39")
			};
		}

		protected virtual EntitySchemaColumn CreateIndicatorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("7e0f01d8-2a05-4f68-aaa7-5d4a31a988a2"),
				Name = @"Indicator",
				ReferenceSchemaUId = new Guid("e0b448d7-44a9-465c-8de0-2f79c3415fba"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("321d7bc3-45fe-41f8-af38-6643602b116d"),
				ModifiedInSchemaUId = new Guid("321d7bc3-45fe-41f8-af38-6643602b116d"),
				CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39")
			};
		}

		protected virtual EntitySchemaColumn CreateSettingsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("4e1b5056-a250-45bc-baf5-743f632644cf"),
				Name = @"Settings",
				CreatedInSchemaUId = new Guid("321d7bc3-45fe-41f8-af38-6643602b116d"),
				ModifiedInSchemaUId = new Guid("321d7bc3-45fe-41f8-af38-6643602b116d"),
				CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39")
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("df4002ec-7efa-4d3f-8214-b42bff6def2e"),
				Name = @"Type",
				ReferenceSchemaUId = new Guid("afa4fe55-a6da-4b54-b24b-ad6c53b5b173"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("321d7bc3-45fe-41f8-af38-6643602b116d"),
				ModifiedInSchemaUId = new Guid("321d7bc3-45fe-41f8-af38-6643602b116d"),
				CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39")
			};
		}

		protected virtual EntitySchemaColumn CreateTitleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("40a2ff37-c69e-4c9a-85fb-9b5e8a568706"),
				Name = @"Title",
				CreatedInSchemaUId = new Guid("321d7bc3-45fe-41f8-af38-6643602b116d"),
				ModifiedInSchemaUId = new Guid("321d7bc3-45fe-41f8-af38-6643602b116d"),
				CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateIsHideColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("e28b7cde-7e8f-4ca5-8bea-b9a3bccb6bf7"),
				Name = @"IsHide",
				CreatedInSchemaUId = new Guid("321d7bc3-45fe-41f8-af38-6643602b116d"),
				ModifiedInSchemaUId = new Guid("321d7bc3-45fe-41f8-af38-6643602b116d"),
				CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateForecastColumnEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateForecastColumnEventsProcessSchema() {
			var schema = new ForecastColumnEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ForecastColumn(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ForecastColumn_CoreForecastEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ForecastColumnSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ForecastColumnSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("321d7bc3-45fe-41f8-af38-6643602b116d"));
		}

		#endregion

	}

	#endregion

	#region Class: ForecastColumn

	/// <summary>
	/// Forecast column.
	/// </summary>
	public class ForecastColumn : Terrasoft.Configuration.BaseEntityWithPosition
	{

		#region Constructors: Public

		public ForecastColumn(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ForecastColumn";
		}

		public ForecastColumn(ForecastColumn source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid SheetId {
			get {
				return GetTypedColumnValue<Guid>("SheetId");
			}
			set {
				SetColumnValue("SheetId", value);
				_sheet = null;
			}
		}

		/// <exclude/>
		public string SheetName {
			get {
				return GetTypedColumnValue<string>("SheetName");
			}
			set {
				SetColumnValue("SheetName", value);
				if (_sheet != null) {
					_sheet.Name = value;
				}
			}
		}

		private ForecastSheet _sheet;
		/// <summary>
		/// Forecast sheet.
		/// </summary>
		public ForecastSheet Sheet {
			get {
				return _sheet ??
					(_sheet = LookupColumnEntities.GetEntity("Sheet") as ForecastSheet);
			}
		}

		/// <exclude/>
		public Guid IndicatorId {
			get {
				return GetTypedColumnValue<Guid>("IndicatorId");
			}
			set {
				SetColumnValue("IndicatorId", value);
				_indicator = null;
			}
		}

		/// <exclude/>
		public string IndicatorName {
			get {
				return GetTypedColumnValue<string>("IndicatorName");
			}
			set {
				SetColumnValue("IndicatorName", value);
				if (_indicator != null) {
					_indicator.Name = value;
				}
			}
		}

		private ForecastIndicator _indicator;
		/// <summary>
		/// Forecast indicator.
		/// </summary>
		public ForecastIndicator Indicator {
			get {
				return _indicator ??
					(_indicator = LookupColumnEntities.GetEntity("Indicator") as ForecastIndicator);
			}
		}

		/// <summary>
		/// Column settings.
		/// </summary>
		public string Settings {
			get {
				return GetTypedColumnValue<string>("Settings");
			}
			set {
				SetColumnValue("Settings", value);
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

		private ForecastColumnType _type;
		/// <summary>
		/// Column type.
		/// </summary>
		public ForecastColumnType Type {
			get {
				return _type ??
					(_type = LookupColumnEntities.GetEntity("Type") as ForecastColumnType);
			}
		}

		/// <summary>
		/// Title.
		/// </summary>
		public string Title {
			get {
				return GetTypedColumnValue<string>("Title");
			}
			set {
				SetColumnValue("Title", value);
			}
		}

		/// <summary>
		/// Hide column.
		/// </summary>
		public bool IsHide {
			get {
				return GetTypedColumnValue<bool>("IsHide");
			}
			set {
				SetColumnValue("IsHide", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ForecastColumn_CoreForecastEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ForecastColumn(this);
		}

		#endregion

	}

	#endregion

	#region Class: ForecastColumn_CoreForecastEventsProcess

	/// <exclude/>
	public partial class ForecastColumn_CoreForecastEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntityWithPosition_BaseEventsProcess<TEntity> where TEntity : ForecastColumn
	{

		public ForecastColumn_CoreForecastEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ForecastColumn_CoreForecastEventsProcess";
			SchemaUId = new Guid("321d7bc3-45fe-41f8-af38-6643602b116d");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("321d7bc3-45fe-41f8-af38-6643602b116d");
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

	#region Class: ForecastColumn_CoreForecastEventsProcess

	/// <exclude/>
	public class ForecastColumn_CoreForecastEventsProcess : ForecastColumn_CoreForecastEventsProcess<ForecastColumn>
	{

		public ForecastColumn_CoreForecastEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ForecastColumn_CoreForecastEventsProcess

	public partial class ForecastColumn_CoreForecastEventsProcess<TEntity>
	{

		#region Methods: Public

		public override EntitySchemaQueryFilterCollection GetDetailFilter(Entity entity, EntitySchemaQuery esq) {
			EntitySchemaQueryFilterCollection filtersGroup = base.GetDetailFilter(entity, esq);
			Guid sheetId = entity.GetTypedColumnValue<Guid>("SheetId");
			if (filtersGroup == null) {
				filtersGroup = new EntitySchemaQueryFilterCollection(esq);
			}
			filtersGroup.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Sheet", sheetId));
			return filtersGroup;
		}

		#endregion

	}

	#endregion

	#region Class: ForecastColumnEventsProcessSchema

	/// <exclude/>
	public class ForecastColumnEventsProcessSchema : Terrasoft.Configuration.BaseEntityWithPositionEventsProcessSchema
	{

		#region Constructors: Public

		public ForecastColumnEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ForecastColumnEventsProcessSchema(ForecastColumnEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ForecastColumn_CoreForecastEventsProcess";
			UId = new Guid("c36b31e4-55fd-467d-82a0-63ec6203b0ca");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
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
			ProcessSchemaLaneSet schemaLaneSet2_3d0d5ff21e1b452391f91c010b08d233 = CreateLaneSet2_3d0d5ff21e1b452391f91c010b08d233LaneSet();
			LaneSets.Add(schemaLaneSet2_3d0d5ff21e1b452391f91c010b08d233);
			ProcessSchemaLane schemaLane3_27cf3fe584bf4b7ca7757326731257d5 = CreateLane3_27cf3fe584bf4b7ca7757326731257d5Lane();
			schemaLaneSet2_3d0d5ff21e1b452391f91c010b08d233.Lanes.Add(schemaLane3_27cf3fe584bf4b7ca7757326731257d5);
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet2_3d0d5ff21e1b452391f91c010b08d233LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet2_3d0d5ff21e1b452391f91c010b08d233 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("3d0d5ff2-1e1b-4523-91f9-1c010b08d233"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("940268fa-de6a-4788-9a44-adceccaf737c"),
				CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39"),
				CreatedInSchemaUId = new Guid("c36b31e4-55fd-467d-82a0-63ec6203b0ca"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("c36b31e4-55fd-467d-82a0-63ec6203b0ca"),
				Name = @"LaneSet2_3d0d5ff21e1b452391f91c010b08d233",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet2_3d0d5ff21e1b452391f91c010b08d233;
		}

		protected virtual ProcessSchemaLane CreateLane3_27cf3fe584bf4b7ca7757326731257d5Lane() {
			ProcessSchemaLane schemaLane3_27cf3fe584bf4b7ca7757326731257d5 = new ProcessSchemaLane(this) {
				UId = new Guid("27cf3fe5-84bf-4b7c-a775-7326731257d5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3d0d5ff2-1e1b-4523-91f9-1c010b08d233"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39"),
				CreatedInSchemaUId = new Guid("c36b31e4-55fd-467d-82a0-63ec6203b0ca"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("c36b31e4-55fd-467d-82a0-63ec6203b0ca"),
				Name = @"Lane3_27cf3fe584bf4b7ca7757326731257d5",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane3_27cf3fe584bf4b7ca7757326731257d5;
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
				CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("ebb032c2-3bb4-4c12-8c8f-06bf89edc886")
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

		protected override SchemaMethod CreateGetDetailFilterMethod() {
			SchemaMethod method = base.CreateGetDetailFilterMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,144,65,106,195,48,16,69,215,245,41,6,175,100,48,190,64,154,64,72,93,211,93,75,74,187,158,68,63,88,32,203,142,52,162,152,210,187,215,138,8,36,221,116,171,249,239,207,27,181,78,140,204,251,99,143,129,223,34,252,252,108,172,192,239,70,107,113,20,51,58,58,93,30,66,231,199,56,209,154,14,28,208,116,144,39,8,27,155,211,10,151,150,154,16,206,213,170,232,162,209,20,122,64,94,244,66,228,97,98,222,231,9,122,169,142,131,251,96,27,241,152,146,27,85,238,115,182,92,88,115,34,117,191,113,77,46,90,91,209,119,241,240,71,197,225,139,218,255,252,85,118,250,41,110,225,102,171,117,26,52,59,15,22,100,230,211,72,255,202,158,7,164,156,186,22,13,19,123,19,70,151,228,155,246,28,217,214,148,141,203,250,122,101,181,108,240,144,232,239,191,107,245,11,86,167,111,161,94,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ForecastColumnEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c36b31e4-55fd-467d-82a0-63ec6203b0ca"));
		}

		#endregion

	}

	#endregion


	#region Class: ForecastColumnEventsProcess

	/// <exclude/>
	public class ForecastColumnEventsProcess : ForecastColumn_CoreForecastEventsProcess
	{

		public ForecastColumnEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

