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

	#region Class: MLClassificationResultSchema

	/// <exclude/>
	public class MLClassificationResultSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public MLClassificationResultSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public MLClassificationResultSchema(MLClassificationResultSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public MLClassificationResultSchema(MLClassificationResultSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("010231dd-f848-4edf-88a4-6480c73c9038");
			RealUId = new Guid("010231dd-f848-4edf-88a4-6480c73c9038");
			Name = "MLClassificationResult";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("62fdb191-1544-4399-9d20-c308d8466eaa");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("cd67e23b-5993-4489-a1b3-4a0fad7a42f2")) == null) {
				Columns.Add(CreateKeyColumn());
			}
			if (Columns.FindByUId(new Guid("4be7ff50-ceea-441e-8ead-e3dc7be9cfd0")) == null) {
				Columns.Add(CreateValueColumn());
			}
			if (Columns.FindByUId(new Guid("f25ca1b2-d263-43ea-a678-1221f61a83e8")) == null) {
				Columns.Add(CreateProbabilityColumn());
			}
			if (Columns.FindByUId(new Guid("d388881d-4c6e-4927-8860-993ddf38d2df")) == null) {
				Columns.Add(CreateModelInstanceUIdColumn());
			}
			if (Columns.FindByUId(new Guid("252c5182-d67f-4539-ab8f-383131e7ff76")) == null) {
				Columns.Add(CreateModelColumn());
			}
			if (Columns.FindByUId(new Guid("c0f86107-b541-43a5-9443-f91c05f3bec7")) == null) {
				Columns.Add(CreateSignificanceColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateKeyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("cd67e23b-5993-4489-a1b3-4a0fad7a42f2"),
				Name = @"Key",
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("010231dd-f848-4edf-88a4-6480c73c9038"),
				ModifiedInSchemaUId = new Guid("010231dd-f848-4edf-88a4-6480c73c9038"),
				CreatedInPackageId = new Guid("62fdb191-1544-4399-9d20-c308d8466eaa")
			};
		}

		protected virtual EntitySchemaColumn CreateValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("4be7ff50-ceea-441e-8ead-e3dc7be9cfd0"),
				Name = @"Value",
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("010231dd-f848-4edf-88a4-6480c73c9038"),
				ModifiedInSchemaUId = new Guid("010231dd-f848-4edf-88a4-6480c73c9038"),
				CreatedInPackageId = new Guid("62fdb191-1544-4399-9d20-c308d8466eaa")
			};
		}

		protected virtual EntitySchemaColumn CreateProbabilityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("f25ca1b2-d263-43ea-a678-1221f61a83e8"),
				Name = @"Probability",
				CreatedInSchemaUId = new Guid("010231dd-f848-4edf-88a4-6480c73c9038"),
				ModifiedInSchemaUId = new Guid("010231dd-f848-4edf-88a4-6480c73c9038"),
				CreatedInPackageId = new Guid("62fdb191-1544-4399-9d20-c308d8466eaa")
			};
		}

		protected virtual EntitySchemaColumn CreateModelInstanceUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("d388881d-4c6e-4927-8860-993ddf38d2df"),
				Name = @"ModelInstanceUId",
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("010231dd-f848-4edf-88a4-6480c73c9038"),
				ModifiedInSchemaUId = new Guid("010231dd-f848-4edf-88a4-6480c73c9038"),
				CreatedInPackageId = new Guid("62fdb191-1544-4399-9d20-c308d8466eaa")
			};
		}

		protected virtual EntitySchemaColumn CreateModelColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("252c5182-d67f-4539-ab8f-383131e7ff76"),
				Name = @"Model",
				ReferenceSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("010231dd-f848-4edf-88a4-6480c73c9038"),
				ModifiedInSchemaUId = new Guid("010231dd-f848-4edf-88a4-6480c73c9038"),
				CreatedInPackageId = new Guid("62fdb191-1544-4399-9d20-c308d8466eaa")
			};
		}

		protected virtual EntitySchemaColumn CreateSignificanceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("c0f86107-b541-43a5-9443-f91c05f3bec7"),
				Name = @"Significance",
				CreatedInSchemaUId = new Guid("010231dd-f848-4edf-88a4-6480c73c9038"),
				ModifiedInSchemaUId = new Guid("010231dd-f848-4edf-88a4-6480c73c9038"),
				CreatedInPackageId = new Guid("62fdb191-1544-4399-9d20-c308d8466eaa")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateMLClassificationResultEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateMLClassificationResultEventsProcessSchema() {
			var schema = new MLClassificationResultEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new MLClassificationResult(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new MLClassificationResult_MLBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new MLClassificationResultSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new MLClassificationResultSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("010231dd-f848-4edf-88a4-6480c73c9038"));
		}

		#endregion

	}

	#endregion

	#region Class: MLClassificationResult

	/// <summary>
	/// ML model classification result.
	/// </summary>
	public class MLClassificationResult : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public MLClassificationResult(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "MLClassificationResult";
		}

		public MLClassificationResult(MLClassificationResult source)
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
		public Guid Value {
			get {
				return GetTypedColumnValue<Guid>("Value");
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
		/// ML service model identifier.
		/// </summary>
		/// <remarks>
		/// Model instance Id.
		/// </remarks>
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
		/// ML model.
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

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new MLClassificationResult_MLBaseEventsProcess(UserConnection);
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
			return new MLClassificationResult(this);
		}

		#endregion

	}

	#endregion

	#region Class: MLClassificationResult_MLBaseEventsProcess

	/// <exclude/>
	public partial class MLClassificationResult_MLBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : MLClassificationResult
	{

		public MLClassificationResult_MLBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "MLClassificationResult_MLBaseEventsProcess";
			SchemaUId = new Guid("010231dd-f848-4edf-88a4-6480c73c9038");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("010231dd-f848-4edf-88a4-6480c73c9038");
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

	#region Class: MLClassificationResult_MLBaseEventsProcess

	/// <exclude/>
	public class MLClassificationResult_MLBaseEventsProcess : MLClassificationResult_MLBaseEventsProcess<MLClassificationResult>
	{

		public MLClassificationResult_MLBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: MLClassificationResult_MLBaseEventsProcess

	public partial class MLClassificationResult_MLBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: MLClassificationResultEventsProcessSchema

	/// <exclude/>
	public class MLClassificationResultEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public MLClassificationResultEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public MLClassificationResultEventsProcessSchema(MLClassificationResultEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "MLClassificationResult_MLBaseEventsProcess";
			UId = new Guid("8c8e79d8-b5dd-4591-8469-748c86530d49");
			CreatedInPackageId = new Guid("62fdb191-1544-4399-9d20-c308d8466eaa");
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
			return new MLClassificationResultEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8c8e79d8-b5dd-4591-8469-748c86530d49"));
		}

		#endregion

	}

	#endregion


	#region Class: MLClassificationResultEventsProcess

	/// <exclude/>
	public class MLClassificationResultEventsProcess : MLClassificationResult_MLBaseEventsProcess
	{

		public MLClassificationResultEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

