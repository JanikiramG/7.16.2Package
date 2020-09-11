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

	#region Class: MLPredictionSchema

	/// <exclude/>
	public class MLPredictionSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public MLPredictionSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public MLPredictionSchema(MLPredictionSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public MLPredictionSchema(MLPredictionSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("224ad954-5350-45b9-8dfd-8dcfa8ad8e06");
			RealUId = new Guid("224ad954-5350-45b9-8dfd-8dcfa8ad8e06");
			Name = "MLPrediction";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("10e294ac-851a-4b19-b311-15fba1867b12");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("686a618b-d912-4657-aaee-25a80d9dc262")) == null) {
				Columns.Add(CreateKeyColumn());
			}
			if (Columns.FindByUId(new Guid("e5bdbbdb-3a9f-4c69-b5ad-42421d2e4abd")) == null) {
				Columns.Add(CreateValueColumn());
			}
			if (Columns.FindByUId(new Guid("4d5ab0b0-27a6-4f0d-a44f-3f0e676301d6")) == null) {
				Columns.Add(CreateProbabilityColumn());
			}
			if (Columns.FindByUId(new Guid("4c453313-56de-4548-b921-071657efca4f")) == null) {
				Columns.Add(CreateModelInstanceUIdColumn());
			}
			if (Columns.FindByUId(new Guid("0f46eb66-f538-454d-91e2-82751422e1f7")) == null) {
				Columns.Add(CreateModelColumn());
			}
			if (Columns.FindByUId(new Guid("7ca696a0-ff40-4586-9c4f-676b2a8d463f")) == null) {
				Columns.Add(CreateSignificanceColumn());
			}
			if (Columns.FindByUId(new Guid("5e98f787-96e9-4883-896f-4e94f1d8b18f")) == null) {
				Columns.Add(CreateFeatureContributionsColumn());
			}
			if (Columns.FindByUId(new Guid("84e52fc1-575a-4f52-bc86-2769b4ff761f")) == null) {
				Columns.Add(CreateBiasColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateKeyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("686a618b-d912-4657-aaee-25a80d9dc262"),
				Name = @"Key",
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("224ad954-5350-45b9-8dfd-8dcfa8ad8e06"),
				ModifiedInSchemaUId = new Guid("224ad954-5350-45b9-8dfd-8dcfa8ad8e06"),
				CreatedInPackageId = new Guid("10e294ac-851a-4b19-b311-15fba1867b12")
			};
		}

		protected virtual EntitySchemaColumn CreateValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("e5bdbbdb-3a9f-4c69-b5ad-42421d2e4abd"),
				Name = @"Value",
				CreatedInSchemaUId = new Guid("224ad954-5350-45b9-8dfd-8dcfa8ad8e06"),
				ModifiedInSchemaUId = new Guid("224ad954-5350-45b9-8dfd-8dcfa8ad8e06"),
				CreatedInPackageId = new Guid("10e294ac-851a-4b19-b311-15fba1867b12")
			};
		}

		protected virtual EntitySchemaColumn CreateProbabilityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("4d5ab0b0-27a6-4f0d-a44f-3f0e676301d6"),
				Name = @"Probability",
				CreatedInSchemaUId = new Guid("224ad954-5350-45b9-8dfd-8dcfa8ad8e06"),
				ModifiedInSchemaUId = new Guid("224ad954-5350-45b9-8dfd-8dcfa8ad8e06"),
				CreatedInPackageId = new Guid("10e294ac-851a-4b19-b311-15fba1867b12")
			};
		}

		protected virtual EntitySchemaColumn CreateModelInstanceUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("4c453313-56de-4548-b921-071657efca4f"),
				Name = @"ModelInstanceUId",
				CreatedInSchemaUId = new Guid("224ad954-5350-45b9-8dfd-8dcfa8ad8e06"),
				ModifiedInSchemaUId = new Guid("224ad954-5350-45b9-8dfd-8dcfa8ad8e06"),
				CreatedInPackageId = new Guid("10e294ac-851a-4b19-b311-15fba1867b12")
			};
		}

		protected virtual EntitySchemaColumn CreateModelColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0f46eb66-f538-454d-91e2-82751422e1f7"),
				Name = @"Model",
				ReferenceSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("224ad954-5350-45b9-8dfd-8dcfa8ad8e06"),
				ModifiedInSchemaUId = new Guid("224ad954-5350-45b9-8dfd-8dcfa8ad8e06"),
				CreatedInPackageId = new Guid("10e294ac-851a-4b19-b311-15fba1867b12")
			};
		}

		protected virtual EntitySchemaColumn CreateSignificanceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("7ca696a0-ff40-4586-9c4f-676b2a8d463f"),
				Name = @"Significance",
				CreatedInSchemaUId = new Guid("224ad954-5350-45b9-8dfd-8dcfa8ad8e06"),
				ModifiedInSchemaUId = new Guid("224ad954-5350-45b9-8dfd-8dcfa8ad8e06"),
				CreatedInPackageId = new Guid("10e294ac-851a-4b19-b311-15fba1867b12")
			};
		}

		protected virtual EntitySchemaColumn CreateFeatureContributionsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("5e98f787-96e9-4883-896f-4e94f1d8b18f"),
				Name = @"FeatureContributions",
				CreatedInSchemaUId = new Guid("224ad954-5350-45b9-8dfd-8dcfa8ad8e06"),
				ModifiedInSchemaUId = new Guid("224ad954-5350-45b9-8dfd-8dcfa8ad8e06"),
				CreatedInPackageId = new Guid("62fdb191-1544-4399-9d20-c308d8466eaa"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateBiasColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float4")) {
				UId = new Guid("84e52fc1-575a-4f52-bc86-2769b4ff761f"),
				Name = @"Bias",
				CreatedInSchemaUId = new Guid("224ad954-5350-45b9-8dfd-8dcfa8ad8e06"),
				ModifiedInSchemaUId = new Guid("224ad954-5350-45b9-8dfd-8dcfa8ad8e06"),
				CreatedInPackageId = new Guid("62fdb191-1544-4399-9d20-c308d8466eaa")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateMLPredictionEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateMLPredictionEventsProcessSchema() {
			var schema = new MLPredictionEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new MLPrediction(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new MLPrediction_MLBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new MLPredictionSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new MLPredictionSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("224ad954-5350-45b9-8dfd-8dcfa8ad8e06"));
		}

		#endregion

	}

	#endregion

	#region Class: MLPrediction

	/// <summary>
	/// ML model prediction result.
	/// </summary>
	public class MLPrediction : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public MLPrediction(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "MLPrediction";
		}

		public MLPrediction(MLPrediction source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Predicted entity Id.
		/// </summary>
		public Guid Key {
			get {
				return GetTypedColumnValue<Guid>("Key");
			}
			set {
				SetColumnValue("Key", value);
			}
		}

		/// <summary>
		/// Predicted value.
		/// </summary>
		public string Value {
			get {
				return GetTypedColumnValue<string>("Value");
			}
			set {
				SetColumnValue("Value", value);
			}
		}

		/// <summary>
		/// Predicted value probability.
		/// </summary>
		public Decimal Probability {
			get {
				return GetTypedColumnValue<Decimal>("Probability");
			}
			set {
				SetColumnValue("Probability", value);
			}
		}

		/// <summary>
		/// Model instance Id.
		/// </summary>
		public Guid ModelInstanceUId {
			get {
				return GetTypedColumnValue<Guid>("ModelInstanceUId");
			}
			set {
				SetColumnValue("ModelInstanceUId", value);
			}
		}

		/// <exclude/>
		public Guid ModelId {
			get {
				return GetTypedColumnValue<Guid>("ModelId");
			}
			set {
				SetColumnValue("ModelId", value);
				_model = null;
			}
		}

		/// <exclude/>
		public string ModelName {
			get {
				return GetTypedColumnValue<string>("ModelName");
			}
			set {
				SetColumnValue("ModelName", value);
				if (_model != null) {
					_model.Name = value;
				}
			}
		}

		private MLModel _model;
		/// <summary>
		/// Model class.
		/// </summary>
		public MLModel Model {
			get {
				return _model ??
					(_model = LookupColumnEntities.GetEntity("Model") as MLModel);
			}
		}

		/// <summary>
		/// Prediction significance.
		/// </summary>
		public string Significance {
			get {
				return GetTypedColumnValue<string>("Significance");
			}
			set {
				SetColumnValue("Significance", value);
			}
		}

		/// <summary>
		/// FeatureContributions.
		/// </summary>
		public string FeatureContributions {
			get {
				return GetTypedColumnValue<string>("FeatureContributions");
			}
			set {
				SetColumnValue("FeatureContributions", value);
			}
		}

		/// <summary>
		/// Bias.
		/// </summary>
		public Decimal Bias {
			get {
				return GetTypedColumnValue<Decimal>("Bias");
			}
			set {
				SetColumnValue("Bias", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new MLPrediction_MLBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("MLPredictionDeleted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new MLPrediction(this);
		}

		#endregion

	}

	#endregion

	#region Class: MLPrediction_MLBaseEventsProcess

	/// <exclude/>
	public partial class MLPrediction_MLBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : MLPrediction
	{

		public MLPrediction_MLBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "MLPrediction_MLBaseEventsProcess";
			SchemaUId = new Guid("224ad954-5350-45b9-8dfd-8dcfa8ad8e06");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("224ad954-5350-45b9-8dfd-8dcfa8ad8e06");
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

	#region Class: MLPrediction_MLBaseEventsProcess

	/// <exclude/>
	public class MLPrediction_MLBaseEventsProcess : MLPrediction_MLBaseEventsProcess<MLPrediction>
	{

		public MLPrediction_MLBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: MLPrediction_MLBaseEventsProcess

	public partial class MLPrediction_MLBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: MLPredictionEventsProcessSchema

	/// <exclude/>
	public class MLPredictionEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public MLPredictionEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public MLPredictionEventsProcessSchema(MLPredictionEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "MLPrediction_MLBaseEventsProcess";
			UId = new Guid("c97e431a-0ed0-4748-b54f-ed13849d9728");
			CreatedInPackageId = new Guid("10e294ac-851a-4b19-b311-15fba1867b12");
			CreatedInSchemaUId = Guid.Empty;
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
			return new MLPredictionEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c97e431a-0ed0-4748-b54f-ed13849d9728"));
		}

		#endregion

	}

	#endregion


	#region Class: MLPredictionEventsProcess

	/// <exclude/>
	public class MLPredictionEventsProcess : MLPrediction_MLBaseEventsProcess
	{

		public MLPredictionEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

