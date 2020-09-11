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

	#region Class: ForecastItemSchema

	/// <exclude/>
	public class ForecastItemSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ForecastItemSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ForecastItemSchema(ForecastItemSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ForecastItemSchema(ForecastItemSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("03d3b337-cda2-4993-ab53-d0bdf2c4bd43");
			RealUId = new Guid("03d3b337-cda2-4993-ab53-d0bdf2c4bd43");
			Name = "ForecastItem";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("7c408f6d-0911-41c7-b495-80ace275c6f2");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeHierarchyColumn() {
			base.InitializeHierarchyColumn();
			HierarchyColumn = CreateParentColumn();
			if (Columns.FindByUId(HierarchyColumn.UId) == null) {
				Columns.Add(HierarchyColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("0c62cbfb-4c07-460c-ba26-67ea6a41f63f")) == null) {
				Columns.Add(CreateForecastColumn());
			}
			if (Columns.FindByUId(new Guid("c26ea7e2-0bdc-4886-b935-dc2082ddda7b")) == null) {
				Columns.Add(CreateForecastDimensionColumn());
			}
			if (Columns.FindByUId(new Guid("47ecc95a-0f87-4f4d-a872-22bd71593fa2")) == null) {
				Columns.Add(CreateDimensionValueIdColumn());
			}
			if (Columns.FindByUId(new Guid("2e7ac2a0-e614-4bef-a4ba-0254a3399dc4")) == null) {
				Columns.Add(CreateIsDeletedColumn());
			}
			if (Columns.FindByUId(new Guid("dfc4f2d2-ee03-479e-85ad-a86b5c67078e")) == null) {
				Columns.Add(CreateNameColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateForecastColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0c62cbfb-4c07-460c-ba26-67ea6a41f63f"),
				Name = @"Forecast",
				ReferenceSchemaUId = new Guid("ba399098-a520-4a1b-9ab2-2ec7ea8d97c9"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("03d3b337-cda2-4993-ab53-d0bdf2c4bd43"),
				ModifiedInSchemaUId = new Guid("03d3b337-cda2-4993-ab53-d0bdf2c4bd43"),
				CreatedInPackageId = new Guid("7c408f6d-0911-41c7-b495-80ace275c6f2")
			};
		}

		protected virtual EntitySchemaColumn CreateForecastDimensionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c26ea7e2-0bdc-4886-b935-dc2082ddda7b"),
				Name = @"ForecastDimension",
				ReferenceSchemaUId = new Guid("c83de6c5-e072-4faf-9401-3092055fe96d"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("03d3b337-cda2-4993-ab53-d0bdf2c4bd43"),
				ModifiedInSchemaUId = new Guid("03d3b337-cda2-4993-ab53-d0bdf2c4bd43"),
				CreatedInPackageId = new Guid("7c408f6d-0911-41c7-b495-80ace275c6f2")
			};
		}

		protected virtual EntitySchemaColumn CreateDimensionValueIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("47ecc95a-0f87-4f4d-a872-22bd71593fa2"),
				Name = @"DimensionValueId",
				CreatedInSchemaUId = new Guid("03d3b337-cda2-4993-ab53-d0bdf2c4bd43"),
				ModifiedInSchemaUId = new Guid("03d3b337-cda2-4993-ab53-d0bdf2c4bd43"),
				CreatedInPackageId = new Guid("7c408f6d-0911-41c7-b495-80ace275c6f2")
			};
		}

		protected virtual EntitySchemaColumn CreateIsDeletedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("2e7ac2a0-e614-4bef-a4ba-0254a3399dc4"),
				Name = @"IsDeleted",
				CreatedInSchemaUId = new Guid("03d3b337-cda2-4993-ab53-d0bdf2c4bd43"),
				ModifiedInSchemaUId = new Guid("03d3b337-cda2-4993-ab53-d0bdf2c4bd43"),
				CreatedInPackageId = new Guid("7c408f6d-0911-41c7-b495-80ace275c6f2")
			};
		}

		protected virtual EntitySchemaColumn CreateParentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("56da6b7d-f028-4107-ba85-7c60db4f85ec"),
				Name = @"Parent",
				ReferenceSchemaUId = new Guid("03d3b337-cda2-4993-ab53-d0bdf2c4bd43"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("03d3b337-cda2-4993-ab53-d0bdf2c4bd43"),
				ModifiedInSchemaUId = new Guid("03d3b337-cda2-4993-ab53-d0bdf2c4bd43"),
				CreatedInPackageId = new Guid("7c408f6d-0911-41c7-b495-80ace275c6f2")
			};
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("dfc4f2d2-ee03-479e-85ad-a86b5c67078e"),
				Name = @"Name",
				CreatedInSchemaUId = new Guid("03d3b337-cda2-4993-ab53-d0bdf2c4bd43"),
				ModifiedInSchemaUId = new Guid("03d3b337-cda2-4993-ab53-d0bdf2c4bd43"),
				CreatedInPackageId = new Guid("e361335e-8405-403c-ae87-309c09fd3acb"),
				IsLocalizable = true
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateForecastItemEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateForecastItemEventsProcessSchema() {
			var schema = new ForecastItemEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ForecastItem(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ForecastItem_CoreForecastEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ForecastItemSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ForecastItemSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("03d3b337-cda2-4993-ab53-d0bdf2c4bd43"));
		}

		#endregion

	}

	#endregion

	#region Class: ForecastItem

	/// <summary>
	/// Forecast item (obsolete since 7.13.1).
	/// </summary>
	public class ForecastItem : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ForecastItem(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ForecastItem";
		}

		public ForecastItem(ForecastItem source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ForecastId {
			get {
				return GetTypedColumnValue<Guid>("ForecastId");
			}
			set {
				SetColumnValue("ForecastId", value);
				_forecast = null;
			}
		}

		/// <exclude/>
		public string ForecastName {
			get {
				return GetTypedColumnValue<string>("ForecastName");
			}
			set {
				SetColumnValue("ForecastName", value);
				if (_forecast != null) {
					_forecast.Name = value;
				}
			}
		}

		private Forecast _forecast;
		/// <summary>
		/// Forecasts.
		/// </summary>
		public Forecast Forecast {
			get {
				return _forecast ??
					(_forecast = LookupColumnEntities.GetEntity("Forecast") as Forecast);
			}
		}

		/// <exclude/>
		public Guid ForecastDimensionId {
			get {
				return GetTypedColumnValue<Guid>("ForecastDimensionId");
			}
			set {
				SetColumnValue("ForecastDimensionId", value);
				_forecastDimension = null;
			}
		}

		private ForecastDimension _forecastDimension;
		/// <summary>
		/// Forecast object.
		/// </summary>
		public ForecastDimension ForecastDimension {
			get {
				return _forecastDimension ??
					(_forecastDimension = LookupColumnEntities.GetEntity("ForecastDimension") as ForecastDimension);
			}
		}

		/// <summary>
		/// Forecast item value.
		/// </summary>
		public Guid DimensionValueId {
			get {
				return GetTypedColumnValue<Guid>("DimensionValueId");
			}
			set {
				SetColumnValue("DimensionValueId", value);
			}
		}

		/// <summary>
		/// Deleted.
		/// </summary>
		public bool IsDeleted {
			get {
				return GetTypedColumnValue<bool>("IsDeleted");
			}
			set {
				SetColumnValue("IsDeleted", value);
			}
		}

		/// <exclude/>
		public Guid ParentId {
			get {
				return GetTypedColumnValue<Guid>("ParentId");
			}
			set {
				SetColumnValue("ParentId", value);
				_parent = null;
			}
		}

		private ForecastItem _parent;
		/// <summary>
		/// Forecast parent item.
		/// </summary>
		public ForecastItem Parent {
			get {
				return _parent ??
					(_parent = LookupColumnEntities.GetEntity("Parent") as ForecastItem);
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

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ForecastItem_CoreForecastEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ForecastItemDeleted", e);
			Validating += (s, e) => ThrowEvent("ForecastItemValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ForecastItem(this);
		}

		#endregion

	}

	#endregion

	#region Class: ForecastItem_CoreForecastEventsProcess

	/// <exclude/>
	public partial class ForecastItem_CoreForecastEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : ForecastItem
	{

		public ForecastItem_CoreForecastEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ForecastItem_CoreForecastEventsProcess";
			SchemaUId = new Guid("03d3b337-cda2-4993-ab53-d0bdf2c4bd43");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("03d3b337-cda2-4993-ab53-d0bdf2c4bd43");
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

	#region Class: ForecastItem_CoreForecastEventsProcess

	/// <exclude/>
	public class ForecastItem_CoreForecastEventsProcess : ForecastItem_CoreForecastEventsProcess<ForecastItem>
	{

		public ForecastItem_CoreForecastEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ForecastItem_CoreForecastEventsProcess

	public partial class ForecastItem_CoreForecastEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: ForecastItemEventsProcessSchema

	/// <exclude/>
	public class ForecastItemEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public ForecastItemEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ForecastItemEventsProcessSchema(ForecastItemEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ForecastItem_CoreForecastEventsProcess";
			UId = new Guid("90354997-0e86-420b-b974-05d849976049");
			CreatedInPackageId = new Guid("7c408f6d-0911-41c7-b495-80ace275c6f2");
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
			return new ForecastItemEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("90354997-0e86-420b-b974-05d849976049"));
		}

		#endregion

	}

	#endregion


	#region Class: ForecastItemEventsProcess

	/// <exclude/>
	public class ForecastItemEventsProcess : ForecastItem_CoreForecastEventsProcess
	{

		public ForecastItemEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

