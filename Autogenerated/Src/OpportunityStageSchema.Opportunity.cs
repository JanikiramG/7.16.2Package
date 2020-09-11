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
	using Terrasoft.Core.Store;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: OpportunityStage_Opportunity_TerrasoftSchema

	/// <exclude/>
	public class OpportunityStage_Opportunity_TerrasoftSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public OpportunityStage_Opportunity_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OpportunityStage_Opportunity_TerrasoftSchema(OpportunityStage_Opportunity_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OpportunityStage_Opportunity_TerrasoftSchema(OpportunityStage_Opportunity_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f");
			RealUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f");
			Name = "OpportunityStage_Opportunity_Terrasoft";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("146e7f2e-a20d-4cc2-9c5c-bcc8dde6ed63")) == null) {
				Columns.Add(CreateEndColumn());
			}
			if (Columns.FindByUId(new Guid("9d36f697-56db-4539-9809-b07f01dfe9a0")) == null) {
				Columns.Add(CreateSuccessfulColumn());
			}
			if (Columns.FindByUId(new Guid("5cff1d37-c039-46ce-ac3e-a4d7abe49c5f")) == null) {
				Columns.Add(CreateNumberColumn());
			}
			if (Columns.FindByUId(new Guid("388070cb-b942-4af8-a6fb-4b722d30847e")) == null) {
				Columns.Add(CreateMaxProbabilityColumn());
			}
			if (Columns.FindByUId(new Guid("5112d458-569f-445a-90a9-a4c8e0041b28")) == null) {
				Columns.Add(CreateNextStepTermColumn());
			}
			if (Columns.FindByUId(new Guid("875d786d-74b6-4f1c-b885-5fb7da04453b")) == null) {
				Columns.Add(CreateShowInFunnelColumn());
			}
			if (Columns.FindByUId(new Guid("d463f315-b9c9-41ee-a625-60669d205559")) == null) {
				Columns.Add(CreateColorColumn());
			}
			if (Columns.FindByUId(new Guid("ce321ce4-c2fd-43e9-b4ca-26a3aca754c4")) == null) {
				Columns.Add(CreateShowInProgressBarColumn());
			}
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f");
			column.CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f");
			column.CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			return column;
		}

		protected virtual EntitySchemaColumn CreateEndColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("146e7f2e-a20d-4cc2-9c5c-bcc8dde6ed63"),
				Name = @"End",
				CreatedInSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				ModifiedInSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected virtual EntitySchemaColumn CreateSuccessfulColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("9d36f697-56db-4539-9809-b07f01dfe9a0"),
				Name = @"Successful",
				CreatedInSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				ModifiedInSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected virtual EntitySchemaColumn CreateNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("5cff1d37-c039-46ce-ac3e-a4d7abe49c5f"),
				Name = @"Number",
				CreatedInSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				ModifiedInSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected virtual EntitySchemaColumn CreateMaxProbabilityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("388070cb-b942-4af8-a6fb-4b722d30847e"),
				Name = @"MaxProbability",
				CreatedInSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				ModifiedInSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected virtual EntitySchemaColumn CreateNextStepTermColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("5112d458-569f-445a-90a9-a4c8e0041b28"),
				Name = @"NextStepTerm",
				CreatedInSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				ModifiedInSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected virtual EntitySchemaColumn CreateShowInFunnelColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("875d786d-74b6-4f1c-b885-5fb7da04453b"),
				Name = @"ShowInFunnel",
				CreatedInSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				ModifiedInSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				CreatedInPackageId = new Guid("331ebe45-2152-452a-9e4b-d72e7bcbf340")
			};
		}

		protected virtual EntitySchemaColumn CreateColorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("d463f315-b9c9-41ee-a625-60669d205559"),
				Name = @"Color",
				CreatedInSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				ModifiedInSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				CreatedInPackageId = new Guid("331ebe45-2152-452a-9e4b-d72e7bcbf340")
			};
		}

		protected virtual EntitySchemaColumn CreateShowInProgressBarColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("ce321ce4-c2fd-43e9-b4ca-26a3aca754c4"),
				Name = @"ShowInProgressBar",
				CreatedInSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				ModifiedInSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				CreatedInPackageId = new Guid("331ebe45-2152-452a-9e4b-d72e7bcbf340"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"True"
				}
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateOpportunityStage_Opportunity_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateOpportunityStage_Opportunity_TerrasoftEventsProcessSchema() {
			var schema = new OpportunityStage_Opportunity_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new OpportunityStage_Opportunity_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OpportunityStage_OpportunityEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OpportunityStage_Opportunity_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OpportunityStage_Opportunity_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"));
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityStage_Opportunity_Terrasoft

	/// <summary>
	/// Opportunity stage.
	/// </summary>
	public class OpportunityStage_Opportunity_Terrasoft : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public OpportunityStage_Opportunity_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OpportunityStage_Opportunity_Terrasoft";
		}

		public OpportunityStage_Opportunity_Terrasoft(OpportunityStage_Opportunity_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Final.
		/// </summary>
		public bool End {
			get {
				return GetTypedColumnValue<bool>("End");
			}
			set {
				SetColumnValue("End", value);
			}
		}

		/// <summary>
		/// Successful.
		/// </summary>
		public bool Successful {
			get {
				return GetTypedColumnValue<bool>("Successful");
			}
			set {
				SetColumnValue("Successful", value);
			}
		}

		/// <summary>
		/// Number.
		/// </summary>
		public int Number {
			get {
				return GetTypedColumnValue<int>("Number");
			}
			set {
				SetColumnValue("Number", value);
			}
		}

		/// <summary>
		/// Maximum probability.
		/// </summary>
		public int MaxProbability {
			get {
				return GetTypedColumnValue<int>("MaxProbability");
			}
			set {
				SetColumnValue("MaxProbability", value);
			}
		}

		/// <summary>
		/// Period for planning the next step, days.
		/// </summary>
		public int NextStepTerm {
			get {
				return GetTypedColumnValue<int>("NextStepTerm");
			}
			set {
				SetColumnValue("NextStepTerm", value);
			}
		}

		/// <summary>
		/// Show in funnel.
		/// </summary>
		public bool ShowInFunnel {
			get {
				return GetTypedColumnValue<bool>("ShowInFunnel");
			}
			set {
				SetColumnValue("ShowInFunnel", value);
			}
		}

		/// <summary>
		/// Color.
		/// </summary>
		public string Color {
			get {
				return GetTypedColumnValue<string>("Color");
			}
			set {
				SetColumnValue("Color", value);
			}
		}

		/// <summary>
		/// Show in progress bar.
		/// </summary>
		public bool ShowInProgressBar {
			get {
				return GetTypedColumnValue<bool>("ShowInProgressBar");
			}
			set {
				SetColumnValue("ShowInProgressBar", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OpportunityStage_OpportunityEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("OpportunityStage_Opportunity_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("OpportunityStage_Opportunity_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("OpportunityStage_Opportunity_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("OpportunityStage_Opportunity_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("OpportunityStage_Opportunity_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("OpportunityStage_Opportunity_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("OpportunityStage_Opportunity_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OpportunityStage_Opportunity_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityStage_OpportunityEventsProcess

	/// <exclude/>
	public partial class OpportunityStage_OpportunityEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_BaseEventsProcess<TEntity> where TEntity : OpportunityStage_Opportunity_Terrasoft
	{

		public OpportunityStage_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpportunityStage_OpportunityEventsProcess";
			SchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _opportunityStageSaving_Process;
		public ProcessFlowElement OpportunityStageSaving_Process {
			get {
				return _opportunityStageSaving_Process ?? (_opportunityStageSaving_Process = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "OpportunityStageSaving_Process",
					SchemaElementUId = new Guid("b3564746-ed13-4b1b-9fbf-6fec4872bcd8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _opportunityStageSaving_message;
		public ProcessFlowElement OpportunityStageSaving_message {
			get {
				return _opportunityStageSaving_message ?? (_opportunityStageSaving_message = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OpportunityStageSaving_message",
					SchemaElementUId = new Guid("f390aafc-20b0-4248-89e6-6816c4af3e1a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _opportunityStageSaving_ScriptTask;
		public ProcessScriptTask OpportunityStageSaving_ScriptTask {
			get {
				return _opportunityStageSaving_ScriptTask ?? (_opportunityStageSaving_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OpportunityStageSaving_ScriptTask",
					SchemaElementUId = new Guid("6d3eb545-a705-4111-be95-a19d32192fcc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OpportunityStageSaving_ScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _opportunityStageDeleting_message;
		public ProcessFlowElement OpportunityStageDeleting_message {
			get {
				return _opportunityStageDeleting_message ?? (_opportunityStageDeleting_message = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OpportunityStageDeleting_message",
					SchemaElementUId = new Guid("f4986217-c34a-4a4f-9981-2495237022c9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _opportunityStageInserting_m;
		public ProcessFlowElement OpportunityStageInserting_m {
			get {
				return _opportunityStageInserting_m ?? (_opportunityStageInserting_m = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OpportunityStageInserting_m",
					SchemaElementUId = new Guid("e295c678-c68c-40f7-97ba-225311d1b063"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[OpportunityStageSaving_Process.SchemaElementUId] = new Collection<ProcessFlowElement> { OpportunityStageSaving_Process };
			FlowElements[OpportunityStageSaving_message.SchemaElementUId] = new Collection<ProcessFlowElement> { OpportunityStageSaving_message };
			FlowElements[OpportunityStageSaving_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpportunityStageSaving_ScriptTask };
			FlowElements[OpportunityStageDeleting_message.SchemaElementUId] = new Collection<ProcessFlowElement> { OpportunityStageDeleting_message };
			FlowElements[OpportunityStageInserting_m.SchemaElementUId] = new Collection<ProcessFlowElement> { OpportunityStageInserting_m };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "OpportunityStageSaving_Process":
						break;
					case "OpportunityStageSaving_message":
						e.Context.QueueTasks.Enqueue("OpportunityStageSaving_ScriptTask");
						break;
					case "OpportunityStageSaving_ScriptTask":
						break;
					case "OpportunityStageDeleting_message":
						e.Context.QueueTasks.Enqueue("OpportunityStageSaving_ScriptTask");
						break;
					case "OpportunityStageInserting_m":
						e.Context.QueueTasks.Enqueue("OpportunityStageSaving_ScriptTask");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("OpportunityStageSaving_message");
			ActivatedEventElements.Add("OpportunityStageDeleting_message");
			ActivatedEventElements.Add("OpportunityStageInserting_m");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "OpportunityStageSaving_Process":
					context.QueueTasks.Dequeue();
					break;
				case "OpportunityStageSaving_message":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpportunityStageSaving_message";
					result = OpportunityStageSaving_message.Execute(context);
					break;
				case "OpportunityStageSaving_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpportunityStageSaving_ScriptTask";
					result = OpportunityStageSaving_ScriptTask.Execute(context, OpportunityStageSaving_ScriptTaskExecute);
					break;
				case "OpportunityStageDeleting_message":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpportunityStageDeleting_message";
					result = OpportunityStageDeleting_message.Execute(context);
					break;
				case "OpportunityStageInserting_m":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpportunityStageInserting_m";
					result = OpportunityStageInserting_m.Execute(context);
					break;
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

		public virtual bool OpportunityStageSaving_ScriptTaskExecute(ProcessExecutingContext context) {
			ClearCache();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "OpportunityStage_Opportunity_TerrasoftSaving":
							if (ActivatedEventElements.Contains("OpportunityStageSaving_message")) {
							context.QueueTasks.Enqueue("OpportunityStageSaving_message");
						}
						break;
					case "OpportunityStage_Opportunity_TerrasoftDeleting":
							if (ActivatedEventElements.Contains("OpportunityStageDeleting_message")) {
							context.QueueTasks.Enqueue("OpportunityStageDeleting_message");
						}
						break;
					case "OpportunityStage_Opportunity_TerrasoftInserting":
							if (ActivatedEventElements.Contains("OpportunityStageInserting_m")) {
							context.QueueTasks.Enqueue("OpportunityStageInserting_m");
						}
						break;
			}
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

	#region Class: OpportunityStage_OpportunityEventsProcess

	/// <exclude/>
	public class OpportunityStage_OpportunityEventsProcess : OpportunityStage_OpportunityEventsProcess<OpportunityStage_Opportunity_Terrasoft>
	{

		public OpportunityStage_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OpportunityStage_OpportunityEventsProcess

	public partial class OpportunityStage_OpportunityEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void ClearCache() {
			Store.Cache[CacheLevel.Application]
				.ExpireGroup(UserConnection.GetIsFeatureEnabled("NewOpportunityStageManager")
					? Terrasoft.Configuration.OpportunityStageRepository.OpportunityCacheGroupName
					: Terrasoft.Configuration.OpportunityStageHelper.OppInStageCacheGroupName);
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityStage_Opportunity_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class OpportunityStage_Opportunity_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseLookupEventsProcessSchema
	{

		#region Constructors: Public

		public OpportunityStage_Opportunity_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public OpportunityStage_Opportunity_TerrasoftEventsProcessSchema(OpportunityStage_Opportunity_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "OpportunityStage_OpportunityEventsProcess";
			UId = new Guid("1a1f450b-d72b-4659-aafb-d94bd78c6661");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
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
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess opportunitystagesaving_process = CreateOpportunityStageSaving_ProcessEventSubProcess();
			FlowElements.Add(opportunitystagesaving_process);
			ProcessSchemaStartMessageEvent opportunitystagesaving_message = CreateOpportunityStageSaving_messageStartMessageEvent();
			opportunitystagesaving_process.FlowElements.Add(opportunitystagesaving_message);
			ProcessSchemaScriptTask opportunitystagesaving_scripttask = CreateOpportunityStageSaving_ScriptTaskScriptTask();
			opportunitystagesaving_process.FlowElements.Add(opportunitystagesaving_scripttask);
			ProcessSchemaStartMessageEvent opportunitystagedeleting_message = CreateOpportunityStageDeleting_messageStartMessageEvent();
			opportunitystagesaving_process.FlowElements.Add(opportunitystagedeleting_message);
			ProcessSchemaStartMessageEvent opportunitystageinserting_m = CreateOpportunityStageInserting_mStartMessageEvent();
			opportunitystagesaving_process.FlowElements.Add(opportunitystageinserting_m);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("52c8392b-ea65-4709-8fd4-a9ad67677cea"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("331ebe45-2152-452a-9e4b-d72e7bcbf340"),
				CreatedInSchemaUId = new Guid("1a1f450b-d72b-4659-aafb-d94bd78c6661"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1a1f450b-d72b-4659-aafb-d94bd78c6661"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f390aafc-20b0-4248-89e6-6816c4af3e1a"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6d3eb545-a705-4111-be95-a19d32192fcc"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("731f931f-a51d-4fc9-b00d-bd535b1d23b6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("331ebe45-2152-452a-9e4b-d72e7bcbf340"),
				CreatedInSchemaUId = new Guid("1a1f450b-d72b-4659-aafb-d94bd78c6661"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1a1f450b-d72b-4659-aafb-d94bd78c6661"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f4986217-c34a-4a4f-9981-2495237022c9"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6d3eb545-a705-4111-be95-a19d32192fcc"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(125, 262));
			schemaFlow.PolylinePointPositions.Add(new Point(125, 164));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("c7e1968c-3a6f-4120-8670-963e675cf274"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("331ebe45-2152-452a-9e4b-d72e7bcbf340"),
				CreatedInSchemaUId = new Guid("1a1f450b-d72b-4659-aafb-d94bd78c6661"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1a1f450b-d72b-4659-aafb-d94bd78c6661"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e295c678-c68c-40f7-97ba-225311d1b063"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6d3eb545-a705-4111-be95-a19d32192fcc"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(179, 293));
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("bbe9eadd-1489-4de4-9362-5a593556582a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("331ebe45-2152-452a-9e4b-d72e7bcbf340"),
				CreatedInSchemaUId = new Guid("1a1f450b-d72b-4659-aafb-d94bd78c6661"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("1a1f450b-d72b-4659-aafb-d94bd78c6661"),
				Name = @"LaneSet1",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("8101a16a-51f2-4743-9477-84f5c412b098"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bbe9eadd-1489-4de4-9362-5a593556582a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("331ebe45-2152-452a-9e4b-d72e7bcbf340"),
				CreatedInSchemaUId = new Guid("1a1f450b-d72b-4659-aafb-d94bd78c6661"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("1a1f450b-d72b-4659-aafb-d94bd78c6661"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateOpportunityStageSaving_ProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaOpportunityStageSaving_Process = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b3564746-ed13-4b1b-9fbf-6fec4872bcd8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8101a16a-51f2-4743-9477-84f5c412b098"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("331ebe45-2152-452a-9e4b-d72e7bcbf340"),
				CreatedInSchemaUId = new Guid("1a1f450b-d72b-4659-aafb-d94bd78c6661"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("1a1f450b-d72b-4659-aafb-d94bd78c6661"),
				Name = @"OpportunityStageSaving_Process",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(23, 20),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(300, 317),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaOpportunityStageSaving_Process;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOpportunityStageSaving_messageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f390aafc-20b0-4248-89e6-6816c4af3e1a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b3564746-ed13-4b1b-9fbf-6fec4872bcd8"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("331ebe45-2152-452a-9e4b-d72e7bcbf340"),
				CreatedInSchemaUId = new Guid("1a1f450b-d72b-4659-aafb-d94bd78c6661"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OpportunityStageSaving",
				ModifiedInSchemaUId = new Guid("1a1f450b-d72b-4659-aafb-d94bd78c6661"),
				Name = @"OpportunityStageSaving_message",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(26, 131),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOpportunityStageSaving_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6d3eb545-a705-4111-be95-a19d32192fcc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b3564746-ed13-4b1b-9fbf-6fec4872bcd8"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("331ebe45-2152-452a-9e4b-d72e7bcbf340"),
				CreatedInSchemaUId = new Guid("1a1f450b-d72b-4659-aafb-d94bd78c6661"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("1a1f450b-d72b-4659-aafb-d94bd78c6661"),
				Name = @"OpportunityStageSaving_ScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(156, 117),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,206,73,77,44,114,78,76,206,72,213,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,95,203,129,186,26,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOpportunityStageDeleting_messageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f4986217-c34a-4a4f-9981-2495237022c9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b3564746-ed13-4b1b-9fbf-6fec4872bcd8"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("331ebe45-2152-452a-9e4b-d72e7bcbf340"),
				CreatedInSchemaUId = new Guid("1a1f450b-d72b-4659-aafb-d94bd78c6661"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OpportunityStageDeleting",
				ModifiedInSchemaUId = new Guid("1a1f450b-d72b-4659-aafb-d94bd78c6661"),
				Name = @"OpportunityStageDeleting_message",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(22, 228),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOpportunityStageInserting_mStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e295c678-c68c-40f7-97ba-225311d1b063"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b3564746-ed13-4b1b-9fbf-6fec4872bcd8"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("331ebe45-2152-452a-9e4b-d72e7bcbf340"),
				CreatedInSchemaUId = new Guid("1a1f450b-d72b-4659-aafb-d94bd78c6661"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OpportunityStageInserting",
				ModifiedInSchemaUId = new Guid("1a1f450b-d72b-4659-aafb-d94bd78c6661"),
				Name = @"OpportunityStageInserting_m",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(97, 259),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateClearCacheMethod());
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
				UId = new Guid("54b142e6-b8a6-47d9-85a6-6d24d0e2d7d1"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("331ebe45-2152-452a-9e4b-d72e7bcbf340")
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

		protected virtual SchemaMethod CreateClearCacheMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b48342e9-dcca-4bd2-8d17-adb2e178fa14"),
				Name = "ClearCache",
				CreatedInSchemaUId = new Guid("1a1f450b-d72b-4659-aafb-d94bd78c6661"),
				CreatedInPackageId = new Guid("331ebe45-2152-452a-9e4b-d72e7bcbf340"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,142,177,14,130,48,20,69,103,77,252,7,195,4,75,63,64,7,99,8,34,137,98,34,58,25,135,138,23,108,82,219,230,209,170,252,189,165,147,58,185,220,225,222,188,243,78,101,53,129,165,188,190,225,20,114,131,7,36,91,26,35,69,205,173,208,234,60,25,143,88,246,50,130,144,147,118,38,62,118,160,84,43,133,122,152,89,14,91,116,43,112,235,8,153,226,23,137,107,28,149,120,238,140,209,100,157,18,182,175,44,111,177,229,202,39,69,137,231,141,22,211,3,136,120,167,27,203,60,171,17,173,163,240,141,253,158,237,97,116,39,188,101,255,57,5,213,160,83,242,59,6,226,236,111,226,26,210,128,134,186,80,161,248,134,37,243,55,55,71,62,99,20,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OpportunityStage_Opportunity_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1a1f450b-d72b-4659-aafb-d94bd78c6661"));
		}

		#endregion

	}

	#endregion

}

