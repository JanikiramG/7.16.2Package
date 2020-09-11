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

	#region Class: OppStageDecouplingSchema

	/// <exclude/>
	public class OppStageDecouplingSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public OppStageDecouplingSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OppStageDecouplingSchema(OppStageDecouplingSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OppStageDecouplingSchema(OppStageDecouplingSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b1f8b03d-3260-45fc-9040-5723673e36d4");
			RealUId = new Guid("b1f8b03d-3260-45fc-9040-5723673e36d4");
			Name = "OppStageDecoupling";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("331ebe45-2152-452a-9e4b-d72e7bcbf340");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("a37c3c35-b417-42d8-8c73-63c31edbc258")) == null) {
				Columns.Add(CreateCurrentStageColumn());
			}
			if (Columns.FindByUId(new Guid("5529de49-dda4-4235-bfd4-6a31f3f6739a")) == null) {
				Columns.Add(CreateAvailableStageColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCurrentStageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a37c3c35-b417-42d8-8c73-63c31edbc258"),
				Name = @"CurrentStage",
				ReferenceSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("b1f8b03d-3260-45fc-9040-5723673e36d4"),
				ModifiedInSchemaUId = new Guid("b1f8b03d-3260-45fc-9040-5723673e36d4"),
				CreatedInPackageId = new Guid("331ebe45-2152-452a-9e4b-d72e7bcbf340")
			};
		}

		protected virtual EntitySchemaColumn CreateAvailableStageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("5529de49-dda4-4235-bfd4-6a31f3f6739a"),
				Name = @"AvailableStage",
				ReferenceSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				IsIndexed = true,
				IsWeakReference = true,
				CreatedInSchemaUId = new Guid("b1f8b03d-3260-45fc-9040-5723673e36d4"),
				ModifiedInSchemaUId = new Guid("b1f8b03d-3260-45fc-9040-5723673e36d4"),
				CreatedInPackageId = new Guid("331ebe45-2152-452a-9e4b-d72e7bcbf340")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateOppStageDecouplingEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateOppStageDecouplingEventsProcessSchema() {
			var schema = new OppStageDecouplingEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new OppStageDecoupling(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OppStageDecoupling_OpportunityEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OppStageDecouplingSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OppStageDecouplingSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b1f8b03d-3260-45fc-9040-5723673e36d4"));
		}

		#endregion

	}

	#endregion

	#region Class: OppStageDecoupling

	/// <summary>
	/// Available opportunity stage transitions.
	/// </summary>
	public class OppStageDecoupling : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public OppStageDecoupling(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OppStageDecoupling";
		}

		public OppStageDecoupling(OppStageDecoupling source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid CurrentStageId {
			get {
				return GetTypedColumnValue<Guid>("CurrentStageId");
			}
			set {
				SetColumnValue("CurrentStageId", value);
				_currentStage = null;
			}
		}

		/// <exclude/>
		public string CurrentStageName {
			get {
				return GetTypedColumnValue<string>("CurrentStageName");
			}
			set {
				SetColumnValue("CurrentStageName", value);
				if (_currentStage != null) {
					_currentStage.Name = value;
				}
			}
		}

		private OpportunityStage _currentStage;
		/// <summary>
		/// CurrentStage.
		/// </summary>
		public OpportunityStage CurrentStage {
			get {
				return _currentStage ??
					(_currentStage = LookupColumnEntities.GetEntity("CurrentStage") as OpportunityStage);
			}
		}

		/// <exclude/>
		public Guid AvailableStageId {
			get {
				return GetTypedColumnValue<Guid>("AvailableStageId");
			}
			set {
				SetColumnValue("AvailableStageId", value);
				_availableStage = null;
			}
		}

		/// <exclude/>
		public string AvailableStageName {
			get {
				return GetTypedColumnValue<string>("AvailableStageName");
			}
			set {
				SetColumnValue("AvailableStageName", value);
				if (_availableStage != null) {
					_availableStage.Name = value;
				}
			}
		}

		private OpportunityStage _availableStage;
		/// <summary>
		/// Available stage.
		/// </summary>
		public OpportunityStage AvailableStage {
			get {
				return _availableStage ??
					(_availableStage = LookupColumnEntities.GetEntity("AvailableStage") as OpportunityStage);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OppStageDecoupling_OpportunityEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("OppStageDecouplingDeleted", e);
			Validating += (s, e) => ThrowEvent("OppStageDecouplingValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OppStageDecoupling(this);
		}

		#endregion

	}

	#endregion

	#region Class: OppStageDecoupling_OpportunityEventsProcess

	/// <exclude/>
	public partial class OppStageDecoupling_OpportunityEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : OppStageDecoupling
	{

		public OppStageDecoupling_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OppStageDecoupling_OpportunityEventsProcess";
			SchemaUId = new Guid("b1f8b03d-3260-45fc-9040-5723673e36d4");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("b1f8b03d-3260-45fc-9040-5723673e36d4");
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

	#region Class: OppStageDecoupling_OpportunityEventsProcess

	/// <exclude/>
	public class OppStageDecoupling_OpportunityEventsProcess : OppStageDecoupling_OpportunityEventsProcess<OppStageDecoupling>
	{

		public OppStageDecoupling_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OppStageDecoupling_OpportunityEventsProcess

	public partial class OppStageDecoupling_OpportunityEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: OppStageDecouplingEventsProcessSchema

	/// <exclude/>
	public class OppStageDecouplingEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public OppStageDecouplingEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public OppStageDecouplingEventsProcessSchema(OppStageDecouplingEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "OppStageDecoupling_OpportunityEventsProcess";
			UId = new Guid("c60f3dee-f593-4976-9ab6-4a38f543898c");
			CreatedInPackageId = new Guid("331ebe45-2152-452a-9e4b-d72e7bcbf340");
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
			return new OppStageDecouplingEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c60f3dee-f593-4976-9ab6-4a38f543898c"));
		}

		#endregion

	}

	#endregion


	#region Class: OppStageDecouplingEventsProcess

	/// <exclude/>
	public class OppStageDecouplingEventsProcess : OppStageDecoupling_OpportunityEventsProcess
	{

		public OppStageDecouplingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

