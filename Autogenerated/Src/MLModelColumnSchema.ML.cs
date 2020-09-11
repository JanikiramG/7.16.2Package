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

	#region Class: MLModelColumnSchema

	/// <exclude/>
	public class MLModelColumnSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public MLModelColumnSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public MLModelColumnSchema(MLModelColumnSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public MLModelColumnSchema(MLModelColumnSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("209a40fb-5688-4207-a88e-dc4a1042117f");
			RealUId = new Guid("209a40fb-5688-4207-a88e-dc4a1042117f");
			Name = "MLModelColumn";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("dcca97db-652a-4afb-840e-08623a93f005")) == null) {
				Columns.Add(CreateMLModelColumn());
			}
			if (Columns.FindByUId(new Guid("388723d0-246c-41de-a78e-9fb562da862b")) == null) {
				Columns.Add(CreateColumnUIdColumn());
			}
			if (Columns.FindByUId(new Guid("9b8345bc-323d-451b-b55f-2ba299f61621")) == null) {
				Columns.Add(CreateCaptionColumn());
			}
			if (Columns.FindByUId(new Guid("6a613ade-2bb3-4592-bf0c-898357e3da9d")) == null) {
				Columns.Add(CreateColumnPathColumn());
			}
			if (Columns.FindByUId(new Guid("c59af29a-aa17-4c70-bf89-545b80c954de")) == null) {
				Columns.Add(CreateAggregationTypeColumn());
			}
			if (Columns.FindByUId(new Guid("271f9f4a-8199-4727-939b-736399e8fc1a")) == null) {
				Columns.Add(CreateSubFiltersColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateMLModelColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("dcca97db-652a-4afb-840e-08623a93f005"),
				Name = @"MLModel",
				ReferenceSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("209a40fb-5688-4207-a88e-dc4a1042117f"),
				ModifiedInSchemaUId = new Guid("209a40fb-5688-4207-a88e-dc4a1042117f"),
				CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f")
			};
		}

		protected virtual EntitySchemaColumn CreateColumnUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("388723d0-246c-41de-a78e-9fb562da862b"),
				Name = @"ColumnUId",
				CreatedInSchemaUId = new Guid("209a40fb-5688-4207-a88e-dc4a1042117f"),
				ModifiedInSchemaUId = new Guid("209a40fb-5688-4207-a88e-dc4a1042117f"),
				CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f")
			};
		}

		protected virtual EntitySchemaColumn CreateCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("9b8345bc-323d-451b-b55f-2ba299f61621"),
				Name = @"Caption",
				CreatedInSchemaUId = new Guid("209a40fb-5688-4207-a88e-dc4a1042117f"),
				ModifiedInSchemaUId = new Guid("209a40fb-5688-4207-a88e-dc4a1042117f"),
				CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateColumnPathColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("6a613ade-2bb3-4592-bf0c-898357e3da9d"),
				Name = @"ColumnPath",
				CreatedInSchemaUId = new Guid("209a40fb-5688-4207-a88e-dc4a1042117f"),
				ModifiedInSchemaUId = new Guid("209a40fb-5688-4207-a88e-dc4a1042117f"),
				CreatedInPackageId = new Guid("cad98641-0ee5-4173-9c03-6ef86b0857c5")
			};
		}

		protected virtual EntitySchemaColumn CreateAggregationTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("c59af29a-aa17-4c70-bf89-545b80c954de"),
				Name = @"AggregationType",
				CreatedInSchemaUId = new Guid("209a40fb-5688-4207-a88e-dc4a1042117f"),
				ModifiedInSchemaUId = new Guid("209a40fb-5688-4207-a88e-dc4a1042117f"),
				CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f")
			};
		}

		protected virtual EntitySchemaColumn CreateSubFiltersColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("271f9f4a-8199-4727-939b-736399e8fc1a"),
				Name = @"SubFilters",
				CreatedInSchemaUId = new Guid("209a40fb-5688-4207-a88e-dc4a1042117f"),
				ModifiedInSchemaUId = new Guid("209a40fb-5688-4207-a88e-dc4a1042117f"),
				CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateMLModelColumnEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateMLModelColumnEventsProcessSchema() {
			var schema = new MLModelColumnEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new MLModelColumn(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new MLModelColumn_MLEventsProcess(userConnection);
		}

		public override object Clone() {
			return new MLModelColumnSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new MLModelColumnSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("209a40fb-5688-4207-a88e-dc4a1042117f"));
		}

		#endregion

	}

	#endregion

	#region Class: MLModelColumn

	/// <summary>
	/// ML model column.
	/// </summary>
	public class MLModelColumn : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public MLModelColumn(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "MLModelColumn";
		}

		public MLModelColumn(MLModelColumn source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid MLModelId {
			get {
				return GetTypedColumnValue<Guid>("MLModelId");
			}
			set {
				SetColumnValue("MLModelId", value);
				_mLModel = null;
			}
		}

		/// <exclude/>
		public string MLModelName {
			get {
				return GetTypedColumnValue<string>("MLModelName");
			}
			set {
				SetColumnValue("MLModelName", value);
				if (_mLModel != null) {
					_mLModel.Name = value;
				}
			}
		}

		private MLModel _mLModel;
		/// <summary>
		/// Model.
		/// </summary>
		public MLModel MLModel {
			get {
				return _mLModel ??
					(_mLModel = LookupColumnEntities.GetEntity("MLModel") as MLModel);
			}
		}

		/// <summary>
		/// Column identifier.
		/// </summary>
		public Guid ColumnUId {
			get {
				return GetTypedColumnValue<Guid>("ColumnUId");
			}
			set {
				SetColumnValue("ColumnUId", value);
			}
		}

		/// <summary>
		/// Caption.
		/// </summary>
		public string Caption {
			get {
				return GetTypedColumnValue<string>("Caption");
			}
			set {
				SetColumnValue("Caption", value);
			}
		}

		/// <summary>
		/// Column path.
		/// </summary>
		public string ColumnPath {
			get {
				return GetTypedColumnValue<string>("ColumnPath");
			}
			set {
				SetColumnValue("ColumnPath", value);
			}
		}

		/// <summary>
		/// AggregationType.
		/// </summary>
		public int AggregationType {
			get {
				return GetTypedColumnValue<int>("AggregationType");
			}
			set {
				SetColumnValue("AggregationType", value);
			}
		}

		/// <summary>
		/// Sub-filters.
		/// </summary>
		public string SubFilters {
			get {
				return GetTypedColumnValue<string>("SubFilters");
			}
			set {
				SetColumnValue("SubFilters", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new MLModelColumn_MLEventsProcess(UserConnection);
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
			return new MLModelColumn(this);
		}

		#endregion

	}

	#endregion

	#region Class: MLModelColumn_MLEventsProcess

	/// <exclude/>
	public partial class MLModelColumn_MLEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : MLModelColumn
	{

		public MLModelColumn_MLEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "MLModelColumn_MLEventsProcess";
			SchemaUId = new Guid("209a40fb-5688-4207-a88e-dc4a1042117f");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("209a40fb-5688-4207-a88e-dc4a1042117f");
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

	#region Class: MLModelColumn_MLEventsProcess

	/// <exclude/>
	public class MLModelColumn_MLEventsProcess : MLModelColumn_MLEventsProcess<MLModelColumn>
	{

		public MLModelColumn_MLEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: MLModelColumn_MLEventsProcess

	public partial class MLModelColumn_MLEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: MLModelColumnEventsProcessSchema

	/// <exclude/>
	public class MLModelColumnEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public MLModelColumnEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public MLModelColumnEventsProcessSchema(MLModelColumnEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "MLModelColumn_MLEventsProcess";
			UId = new Guid("b71abd4e-91ba-4226-adb7-311275cfe05f");
			CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f");
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
			return new MLModelColumnEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b71abd4e-91ba-4226-adb7-311275cfe05f"));
		}

		#endregion

	}

	#endregion


	#region Class: MLModelColumnEventsProcess

	/// <exclude/>
	public class MLModelColumnEventsProcess : MLModelColumn_MLEventsProcess
	{

		public MLModelColumnEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

