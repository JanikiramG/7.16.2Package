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

	#region Class: VwOpportInStageForAnalysisSchema

	/// <exclude/>
	public class VwOpportInStageForAnalysisSchema : Terrasoft.Configuration.OpportunityInStageSchema
	{

		#region Constructors: Public

		public VwOpportInStageForAnalysisSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwOpportInStageForAnalysisSchema(VwOpportInStageForAnalysisSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwOpportInStageForAnalysisSchema(VwOpportInStageForAnalysisSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cd2400bc-3cb0-448d-81ee-32d9662c9755");
			RealUId = new Guid("cd2400bc-3cb0-448d-81ee-32d9662c9755");
			Name = "VwOpportInStageForAnalysis";
			ParentSchemaUId = new Guid("670a893d-5eed-421d-b5d9-1db15b5d9ab6");
			ExtendParent = false;
			CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13");
			IsDBView = true;
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
			if (Columns.FindByUId(new Guid("ce9dbb21-fd5d-4609-8a63-70ccf20deb8c")) == null) {
				Columns.Add(CreateDaysInStageColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateDaysInStageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("ce9dbb21-fd5d-4609-8a63-70ccf20deb8c"),
				Name = @"DaysInStage",
				CreatedInSchemaUId = new Guid("cd2400bc-3cb0-448d-81ee-32d9662c9755"),
				ModifiedInSchemaUId = new Guid("cd2400bc-3cb0-448d-81ee-32d9662c9755"),
				CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13")
			};
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("10bbec0c-239b-4597-8408-d3e25205c5bf"),
				Name = @"Name",
				CreatedInSchemaUId = new Guid("cd2400bc-3cb0-448d-81ee-32d9662c9755"),
				ModifiedInSchemaUId = new Guid("cd2400bc-3cb0-448d-81ee-32d9662c9755"),
				CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwOpportInStageForAnalysisEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwOpportInStageForAnalysisEventsProcessSchema() {
			var schema = new VwOpportInStageForAnalysisEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwOpportInStageForAnalysis(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwOpportInStageForAnalysis_OpportunityEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwOpportInStageForAnalysisSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwOpportInStageForAnalysisSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cd2400bc-3cb0-448d-81ee-32d9662c9755"));
		}

		#endregion

	}

	#endregion

	#region Class: VwOpportInStageForAnalysis

	/// <summary>
	/// View for analysis of sales by stages.
	/// </summary>
	public class VwOpportInStageForAnalysis : Terrasoft.Configuration.OpportunityInStage
	{

		#region Constructors: Public

		public VwOpportInStageForAnalysis(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwOpportInStageForAnalysis";
		}

		public VwOpportInStageForAnalysis(VwOpportInStageForAnalysis source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Number of days in the stage.
		/// </summary>
		public int DaysInStage {
			get {
				return GetTypedColumnValue<int>("DaysInStage");
			}
			set {
				SetColumnValue("DaysInStage", value);
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
			var process = new VwOpportInStageForAnalysis_OpportunityEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwOpportInStageForAnalysisDeleted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwOpportInStageForAnalysis(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwOpportInStageForAnalysis_OpportunityEventsProcess

	/// <exclude/>
	public partial class VwOpportInStageForAnalysis_OpportunityEventsProcess<TEntity> : Terrasoft.Configuration.OpportunityInStage_PRMPortalEventsProcess<TEntity> where TEntity : VwOpportInStageForAnalysis
	{

		public VwOpportInStageForAnalysis_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwOpportInStageForAnalysis_OpportunityEventsProcess";
			SchemaUId = new Guid("cd2400bc-3cb0-448d-81ee-32d9662c9755");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("cd2400bc-3cb0-448d-81ee-32d9662c9755");
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

	#region Class: VwOpportInStageForAnalysis_OpportunityEventsProcess

	/// <exclude/>
	public class VwOpportInStageForAnalysis_OpportunityEventsProcess : VwOpportInStageForAnalysis_OpportunityEventsProcess<VwOpportInStageForAnalysis>
	{

		public VwOpportInStageForAnalysis_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwOpportInStageForAnalysis_OpportunityEventsProcess

	public partial class VwOpportInStageForAnalysis_OpportunityEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: VwOpportInStageForAnalysisEventsProcessSchema

	/// <exclude/>
	public class VwOpportInStageForAnalysisEventsProcessSchema : Terrasoft.Configuration.OpportunityInStageEventsProcessSchema
	{

		#region Constructors: Public

		public VwOpportInStageForAnalysisEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwOpportInStageForAnalysisEventsProcessSchema(VwOpportInStageForAnalysisEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwOpportInStageForAnalysis_OpportunityEventsProcess";
			UId = new Guid("22da6a04-e5d8-4d5c-9e60-295c97d9f94c");
			CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("cff77af8-56bc-4be4-89ec-c83540044bb9");
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
			return new VwOpportInStageForAnalysisEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("22da6a04-e5d8-4d5c-9e60-295c97d9f94c"));
		}

		#endregion

	}

	#endregion


	#region Class: VwOpportInStageForAnalysisEventsProcess

	/// <exclude/>
	public class VwOpportInStageForAnalysisEventsProcess : VwOpportInStageForAnalysis_OpportunityEventsProcess
	{

		public VwOpportInStageForAnalysisEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

