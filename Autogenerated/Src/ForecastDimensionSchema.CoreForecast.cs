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

	#region Class: ForecastDimensionSchema

	/// <exclude/>
	public class ForecastDimensionSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ForecastDimensionSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ForecastDimensionSchema(ForecastDimensionSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ForecastDimensionSchema(ForecastDimensionSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c83de6c5-e072-4faf-9401-3092055fe96d");
			RealUId = new Guid("c83de6c5-e072-4faf-9401-3092055fe96d");
			Name = "ForecastDimension";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("7c408f6d-0911-41c7-b495-80ace275c6f2");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("e8663296-266f-43ab-99ca-500dc0f4df99")) == null) {
				Columns.Add(CreateLevelColumn());
			}
			if (Columns.FindByUId(new Guid("686e5fcf-d4d5-498e-864a-6dabd5e62e29")) == null) {
				Columns.Add(CreateDimensionColumn());
			}
			if (Columns.FindByUId(new Guid("f000aea4-ef77-4981-833c-07d409872721")) == null) {
				Columns.Add(CreateForecastColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateLevelColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("e8663296-266f-43ab-99ca-500dc0f4df99"),
				Name = @"Level",
				CreatedInSchemaUId = new Guid("c83de6c5-e072-4faf-9401-3092055fe96d"),
				ModifiedInSchemaUId = new Guid("c83de6c5-e072-4faf-9401-3092055fe96d"),
				CreatedInPackageId = new Guid("7c408f6d-0911-41c7-b495-80ace275c6f2")
			};
		}

		protected virtual EntitySchemaColumn CreateDimensionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("686e5fcf-d4d5-498e-864a-6dabd5e62e29"),
				Name = @"Dimension",
				ReferenceSchemaUId = new Guid("488f25fa-5d1c-49d4-b2f0-8d6c2a5eab19"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("c83de6c5-e072-4faf-9401-3092055fe96d"),
				ModifiedInSchemaUId = new Guid("c83de6c5-e072-4faf-9401-3092055fe96d"),
				CreatedInPackageId = new Guid("7c408f6d-0911-41c7-b495-80ace275c6f2")
			};
		}

		protected virtual EntitySchemaColumn CreateForecastColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f000aea4-ef77-4981-833c-07d409872721"),
				Name = @"Forecast",
				ReferenceSchemaUId = new Guid("ba399098-a520-4a1b-9ab2-2ec7ea8d97c9"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("c83de6c5-e072-4faf-9401-3092055fe96d"),
				ModifiedInSchemaUId = new Guid("c83de6c5-e072-4faf-9401-3092055fe96d"),
				CreatedInPackageId = new Guid("7c408f6d-0911-41c7-b495-80ace275c6f2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateForecastDimensionEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateForecastDimensionEventsProcessSchema() {
			var schema = new ForecastDimensionEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ForecastDimension(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ForecastDimension_CoreForecastEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ForecastDimensionSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ForecastDimensionSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c83de6c5-e072-4faf-9401-3092055fe96d"));
		}

		#endregion

	}

	#endregion

	#region Class: ForecastDimension

	/// <summary>
	/// Forecast object.
	/// </summary>
	public class ForecastDimension : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ForecastDimension(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ForecastDimension";
		}

		public ForecastDimension(ForecastDimension source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Level.
		/// </summary>
		public int Level {
			get {
				return GetTypedColumnValue<int>("Level");
			}
			set {
				SetColumnValue("Level", value);
			}
		}

		/// <exclude/>
		public Guid DimensionId {
			get {
				return GetTypedColumnValue<Guid>("DimensionId");
			}
			set {
				SetColumnValue("DimensionId", value);
				_dimension = null;
			}
		}

		/// <exclude/>
		public string DimensionName {
			get {
				return GetTypedColumnValue<string>("DimensionName");
			}
			set {
				SetColumnValue("DimensionName", value);
				if (_dimension != null) {
					_dimension.Name = value;
				}
			}
		}

		private Dimension _dimension;
		/// <summary>
		/// Unit of measure.
		/// </summary>
		public Dimension Dimension {
			get {
				return _dimension ??
					(_dimension = LookupColumnEntities.GetEntity("Dimension") as Dimension);
			}
		}

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

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ForecastDimension_CoreForecastEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ForecastDimensionDeleted", e);
			Validating += (s, e) => ThrowEvent("ForecastDimensionValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ForecastDimension(this);
		}

		#endregion

	}

	#endregion

	#region Class: ForecastDimension_CoreForecastEventsProcess

	/// <exclude/>
	public partial class ForecastDimension_CoreForecastEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : ForecastDimension
	{

		public ForecastDimension_CoreForecastEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ForecastDimension_CoreForecastEventsProcess";
			SchemaUId = new Guid("c83de6c5-e072-4faf-9401-3092055fe96d");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c83de6c5-e072-4faf-9401-3092055fe96d");
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

	#region Class: ForecastDimension_CoreForecastEventsProcess

	/// <exclude/>
	public class ForecastDimension_CoreForecastEventsProcess : ForecastDimension_CoreForecastEventsProcess<ForecastDimension>
	{

		public ForecastDimension_CoreForecastEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ForecastDimension_CoreForecastEventsProcess

	public partial class ForecastDimension_CoreForecastEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: ForecastDimensionEventsProcessSchema

	/// <exclude/>
	public class ForecastDimensionEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public ForecastDimensionEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ForecastDimensionEventsProcessSchema(ForecastDimensionEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ForecastDimension_CoreForecastEventsProcess";
			UId = new Guid("1b9b9f6e-8839-490a-971a-78c9e5e002e8");
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
			return new ForecastDimensionEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1b9b9f6e-8839-490a-971a-78c9e5e002e8"));
		}

		#endregion

	}

	#endregion


	#region Class: ForecastDimensionEventsProcess

	/// <exclude/>
	public class ForecastDimensionEventsProcess : ForecastDimension_CoreForecastEventsProcess
	{

		public ForecastDimensionEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

