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

	#region Class: MLProblemTypeSchema

	/// <exclude/>
	public class MLProblemTypeSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public MLProblemTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public MLProblemTypeSchema(MLProblemTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public MLProblemTypeSchema(MLProblemTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cb5f6c84-15e9-4a53-b3cd-f42c0d364b03");
			RealUId = new Guid("cb5f6c84-15e9-4a53-b3cd-f42c0d364b03");
			Name = "MLProblemType";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("3e9edcdb-49d1-42f1-a12e-8a785812a474");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("5e87c380-8c1d-4af8-88a3-326d58e4d7a7")) == null) {
				Columns.Add(CreateServiceUrlColumn());
			}
			if (Columns.FindByUId(new Guid("d4f51f31-d76c-4ed8-a4f1-5f7ba2ef6530")) == null) {
				Columns.Add(CreateTrainingEndpointColumn());
			}
			if (Columns.FindByUId(new Guid("a6705175-f308-4c94-8209-9dc62e54ef9b")) == null) {
				Columns.Add(CreatePredictionEndpointColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateServiceUrlColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("5e87c380-8c1d-4af8-88a3-326d58e4d7a7"),
				Name = @"ServiceUrl",
				CreatedInSchemaUId = new Guid("cb5f6c84-15e9-4a53-b3cd-f42c0d364b03"),
				ModifiedInSchemaUId = new Guid("cb5f6c84-15e9-4a53-b3cd-f42c0d364b03"),
				CreatedInPackageId = new Guid("3e9edcdb-49d1-42f1-a12e-8a785812a474")
			};
		}

		protected virtual EntitySchemaColumn CreateTrainingEndpointColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("d4f51f31-d76c-4ed8-a4f1-5f7ba2ef6530"),
				Name = @"TrainingEndpoint",
				CreatedInSchemaUId = new Guid("cb5f6c84-15e9-4a53-b3cd-f42c0d364b03"),
				ModifiedInSchemaUId = new Guid("cb5f6c84-15e9-4a53-b3cd-f42c0d364b03"),
				CreatedInPackageId = new Guid("3e9edcdb-49d1-42f1-a12e-8a785812a474")
			};
		}

		protected virtual EntitySchemaColumn CreatePredictionEndpointColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("a6705175-f308-4c94-8209-9dc62e54ef9b"),
				Name = @"PredictionEndpoint",
				CreatedInSchemaUId = new Guid("cb5f6c84-15e9-4a53-b3cd-f42c0d364b03"),
				ModifiedInSchemaUId = new Guid("cb5f6c84-15e9-4a53-b3cd-f42c0d364b03"),
				CreatedInPackageId = new Guid("3e9edcdb-49d1-42f1-a12e-8a785812a474")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateMLProblemTypeEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateMLProblemTypeEventsProcessSchema() {
			var schema = new MLProblemTypeEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new MLProblemType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new MLProblemType_MLBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new MLProblemTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new MLProblemTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cb5f6c84-15e9-4a53-b3cd-f42c0d364b03"));
		}

		#endregion

	}

	#endregion

	#region Class: MLProblemType

	/// <summary>
	/// ML problem type.
	/// </summary>
	public class MLProblemType : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public MLProblemType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "MLProblemType";
		}

		public MLProblemType(MLProblemType source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Service endpoint Url.
		/// </summary>
		public string ServiceUrl {
			get {
				return GetTypedColumnValue<string>("ServiceUrl");
			}
			set {
				SetColumnValue("ServiceUrl", value);
			}
		}

		/// <summary>
		/// Training endpoint.
		/// </summary>
		public string TrainingEndpoint {
			get {
				return GetTypedColumnValue<string>("TrainingEndpoint");
			}
			set {
				SetColumnValue("TrainingEndpoint", value);
			}
		}

		/// <summary>
		/// Prediction endpoint.
		/// </summary>
		public string PredictionEndpoint {
			get {
				return GetTypedColumnValue<string>("PredictionEndpoint");
			}
			set {
				SetColumnValue("PredictionEndpoint", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new MLProblemType_MLBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("MLProblemTypeDeleted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new MLProblemType(this);
		}

		#endregion

	}

	#endregion

	#region Class: MLProblemType_MLBaseEventsProcess

	/// <exclude/>
	public partial class MLProblemType_MLBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_BaseEventsProcess<TEntity> where TEntity : MLProblemType
	{

		public MLProblemType_MLBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "MLProblemType_MLBaseEventsProcess";
			SchemaUId = new Guid("cb5f6c84-15e9-4a53-b3cd-f42c0d364b03");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("cb5f6c84-15e9-4a53-b3cd-f42c0d364b03");
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

	#region Class: MLProblemType_MLBaseEventsProcess

	/// <exclude/>
	public class MLProblemType_MLBaseEventsProcess : MLProblemType_MLBaseEventsProcess<MLProblemType>
	{

		public MLProblemType_MLBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: MLProblemType_MLBaseEventsProcess

	public partial class MLProblemType_MLBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: MLProblemTypeEventsProcessSchema

	/// <exclude/>
	public class MLProblemTypeEventsProcessSchema : Terrasoft.Configuration.BaseLookupEventsProcessSchema
	{

		#region Constructors: Public

		public MLProblemTypeEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public MLProblemTypeEventsProcessSchema(MLProblemTypeEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "MLProblemType_MLBaseEventsProcess";
			UId = new Guid("1755df60-9718-48c4-98c7-2cc376cf9891");
			CreatedInPackageId = new Guid("3e9edcdb-49d1-42f1-a12e-8a785812a474");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1");
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
			return new MLProblemTypeEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1755df60-9718-48c4-98c7-2cc376cf9891"));
		}

		#endregion

	}

	#endregion


	#region Class: MLProblemTypeEventsProcess

	/// <exclude/>
	public class MLProblemTypeEventsProcess : MLProblemType_MLBaseEventsProcess
	{

		public MLProblemTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

