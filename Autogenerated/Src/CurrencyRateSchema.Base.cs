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

	#region Class: CurrencyRate_Base_TerrasoftSchema

	/// <exclude/>
	public class CurrencyRate_Base_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public CurrencyRate_Base_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CurrencyRate_Base_TerrasoftSchema(CurrencyRate_Base_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CurrencyRate_Base_TerrasoftSchema(CurrencyRate_Base_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e14c6037-56bb-4724-95b6-3dc29d7f6b4f");
			RealUId = new Guid("e14c6037-56bb-4724-95b6-3dc29d7f6b4f");
			Name = "CurrencyRate_Base_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("fffa677c-647e-4b47-9a24-8fb2639fe3a4")) == null) {
				Columns.Add(CreateStartDateColumn());
			}
			if (Columns.FindByUId(new Guid("b4b497ac-79b3-4db1-a75a-f80d9039f3ea")) == null) {
				Columns.Add(CreateEndDateColumn());
			}
			if (Columns.FindByUId(new Guid("84ce4c1c-f001-4109-86fa-c9b36e8fd5d7")) == null) {
				Columns.Add(CreateCurrencyColumn());
			}
			if (Columns.FindByUId(new Guid("8484fcf9-f40d-48a1-a787-aba9e26c1fb0")) == null) {
				Columns.Add(CreateRateColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateStartDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("fffa677c-647e-4b47-9a24-8fb2639fe3a4"),
				Name = @"StartDate",
				CreatedInSchemaUId = new Guid("e14c6037-56bb-4724-95b6-3dc29d7f6b4f"),
				ModifiedInSchemaUId = new Guid("e14c6037-56bb-4724-95b6-3dc29d7f6b4f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateEndDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("b4b497ac-79b3-4db1-a75a-f80d9039f3ea"),
				Name = @"EndDate",
				CreatedInSchemaUId = new Guid("e14c6037-56bb-4724-95b6-3dc29d7f6b4f"),
				ModifiedInSchemaUId = new Guid("e14c6037-56bb-4724-95b6-3dc29d7f6b4f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateCurrencyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("84ce4c1c-f001-4109-86fa-c9b36e8fd5d7"),
				Name = @"Currency",
				ReferenceSchemaUId = new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d"),
				IsCascade = true,
				CreatedInSchemaUId = new Guid("e14c6037-56bb-4724-95b6-3dc29d7f6b4f"),
				ModifiedInSchemaUId = new Guid("e14c6037-56bb-4724-95b6-3dc29d7f6b4f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateRateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float8")) {
				UId = new Guid("8484fcf9-f40d-48a1-a787-aba9e26c1fb0"),
				Name = @"Rate",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("e14c6037-56bb-4724-95b6-3dc29d7f6b4f"),
				ModifiedInSchemaUId = new Guid("e14c6037-56bb-4724-95b6-3dc29d7f6b4f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCurrencyRate_Base_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateCurrencyRate_Base_TerrasoftEventsProcessSchema() {
			var schema = new CurrencyRate_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new CurrencyRate_Base_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new CurrencyRate_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CurrencyRate_Base_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CurrencyRate_Base_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e14c6037-56bb-4724-95b6-3dc29d7f6b4f"));
		}

		#endregion

	}

	#endregion

	#region Class: CurrencyRate_Base_Terrasoft

	/// <summary>
	/// Exchange rate.
	/// </summary>
	public class CurrencyRate_Base_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public CurrencyRate_Base_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CurrencyRate_Base_Terrasoft";
		}

		public CurrencyRate_Base_Terrasoft(CurrencyRate_Base_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Start.
		/// </summary>
		public DateTime StartDate {
			get {
				return GetTypedColumnValue<DateTime>("StartDate");
			}
			set {
				SetColumnValue("StartDate", value);
			}
		}

		/// <summary>
		/// End.
		/// </summary>
		public DateTime EndDate {
			get {
				return GetTypedColumnValue<DateTime>("EndDate");
			}
			set {
				SetColumnValue("EndDate", value);
			}
		}

		/// <exclude/>
		public Guid CurrencyId {
			get {
				return GetTypedColumnValue<Guid>("CurrencyId");
			}
			set {
				SetColumnValue("CurrencyId", value);
				_currency = null;
			}
		}

		/// <exclude/>
		public string CurrencyName {
			get {
				return GetTypedColumnValue<string>("CurrencyName");
			}
			set {
				SetColumnValue("CurrencyName", value);
				if (_currency != null) {
					_currency.Name = value;
				}
			}
		}

		private Currency _currency;
		/// <summary>
		/// Currency.
		/// </summary>
		public Currency Currency {
			get {
				return _currency ??
					(_currency = LookupColumnEntities.GetEntity("Currency") as Currency);
			}
		}

		/// <summary>
		/// Exchange rate.
		/// </summary>
		public Decimal Rate {
			get {
				return GetTypedColumnValue<Decimal>("Rate");
			}
			set {
				SetColumnValue("Rate", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CurrencyRate_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("CurrencyRate_Base_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("CurrencyRate_Base_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("CurrencyRate_Base_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("CurrencyRate_Base_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("CurrencyRate_Base_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("CurrencyRate_Base_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("CurrencyRate_Base_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CurrencyRate_Base_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: CurrencyRate_BaseEventsProcess

	/// <exclude/>
	public partial class CurrencyRate_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : CurrencyRate_Base_Terrasoft
	{

		public CurrencyRate_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CurrencyRate_BaseEventsProcess";
			SchemaUId = new Guid("e14c6037-56bb-4724-95b6-3dc29d7f6b4f");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e14c6037-56bb-4724-95b6-3dc29d7f6b4f");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess1;
		public ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("97f9a6e8-9ab1-4669-baf5-c2cfdb784af9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _currencyRateSaved;
		public ProcessFlowElement CurrencyRateSaved {
			get {
				return _currencyRateSaved ?? (_currencyRateSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CurrencyRateSaved",
					SchemaElementUId = new Guid("c9d96d44-f6bd-43fa-805f-a0592a93702d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask1;
		public ProcessScriptTask ScriptTask1 {
			get {
				return _scriptTask1 ?? (_scriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask1",
					SchemaElementUId = new Guid("cf4c07cc-737d-4e5f-b456-8a7dc2b2e7ff"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess2;
		public ProcessFlowElement EventSubProcess2 {
			get {
				return _eventSubProcess2 ?? (_eventSubProcess2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess2",
					SchemaElementUId = new Guid("7a5096cb-4a71-447f-bbf1-fa4475ae3626"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _currencyRateDeleted;
		public ProcessFlowElement CurrencyRateDeleted {
			get {
				return _currencyRateDeleted ?? (_currencyRateDeleted = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CurrencyRateDeleted",
					SchemaElementUId = new Guid("498889f7-49b9-4a11-b6be-1e3949d2fa4c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask2;
		public ProcessScriptTask ScriptTask2 {
			get {
				return _scriptTask2 ?? (_scriptTask2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask2",
					SchemaElementUId = new Guid("d08a5c93-c77c-4a1d-9e6e-ac3fad4405c5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask2Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[CurrencyRateSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { CurrencyRateSaved };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[CurrencyRateDeleted.SchemaElementUId] = new Collection<ProcessFlowElement> { CurrencyRateDeleted };
			FlowElements[ScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask2 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "CurrencyRateSaved":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "ScriptTask1":
						break;
					case "EventSubProcess2":
						break;
					case "CurrencyRateDeleted":
						e.Context.QueueTasks.Enqueue("ScriptTask2");
						break;
					case "ScriptTask2":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("CurrencyRateSaved");
			ActivatedEventElements.Add("CurrencyRateDeleted");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "CurrencyRateSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "CurrencyRateSaved";
					result = CurrencyRateSaved.Execute(context);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "CurrencyRateDeleted":
					context.QueueTasks.Dequeue();
					context.SenderName = "CurrencyRateDeleted";
					result = CurrencyRateDeleted.Execute(context);
					break;
				case "ScriptTask2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask2";
					result = ScriptTask2.Execute(context, ScriptTask2Execute);
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

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			ExpireCache();
			return true;
		}

		public virtual bool ScriptTask2Execute(ProcessExecutingContext context) {
			ExpireCache();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "CurrencyRate_Base_TerrasoftSaved":
							if (ActivatedEventElements.Contains("CurrencyRateSaved")) {
							context.QueueTasks.Enqueue("CurrencyRateSaved");
						}
						break;
					case "CurrencyRate_Base_TerrasoftDeleted":
							if (ActivatedEventElements.Contains("CurrencyRateDeleted")) {
							context.QueueTasks.Enqueue("CurrencyRateDeleted");
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

	#region Class: CurrencyRate_BaseEventsProcess

	/// <exclude/>
	public class CurrencyRate_BaseEventsProcess : CurrencyRate_BaseEventsProcess<CurrencyRate_Base_Terrasoft>
	{

		public CurrencyRate_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CurrencyRate_BaseEventsProcess

	public partial class CurrencyRate_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void ExpireCache() {
			Store.Cache[CacheLevel.Application].ExpireGroup("Currency");
		}

		#endregion

	}

	#endregion

	#region Class: CurrencyRate_Base_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class CurrencyRate_Base_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public CurrencyRate_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CurrencyRate_Base_TerrasoftEventsProcessSchema(CurrencyRate_Base_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CurrencyRate_BaseEventsProcess";
			UId = new Guid("bc4c7a1c-1266-4ea9-ac6c-3f0d6920d012");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = Guid.Empty;
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
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaStartMessageEvent currencyratesaved = CreateCurrencyRateSavedStartMessageEvent();
			eventsubprocess1.FlowElements.Add(currencyratesaved);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			eventsubprocess1.FlowElements.Add(scripttask1);
			ProcessSchemaStartMessageEvent currencyratedeleted = CreateCurrencyRateDeletedStartMessageEvent();
			eventsubprocess2.FlowElements.Add(currencyratedeleted);
			ProcessSchemaScriptTask scripttask2 = CreateScriptTask2ScriptTask();
			eventsubprocess2.FlowElements.Add(scripttask2);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("6d6345fa-6ae9-453a-ba44-dfde3181aab0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bc4c7a1c-1266-4ea9-ac6c-3f0d6920d012"),
				CurveCenterPosition = new Point(236, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bc4c7a1c-1266-4ea9-ac6c-3f0d6920d012"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c9d96d44-f6bd-43fa-805f-a0592a93702d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cf4c07cc-737d-4e5f-b456-8a7dc2b2e7ff"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("91053199-815f-477d-8e1c-78e2e6a6f056"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bc4c7a1c-1266-4ea9-ac6c-3f0d6920d012"),
				CurveCenterPosition = new Point(242, 245),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bc4c7a1c-1266-4ea9-ac6c-3f0d6920d012"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("498889f7-49b9-4a11-b6be-1e3949d2fa4c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d08a5c93-c77c-4a1d-9e6e-ac3fad4405c5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("343a2212-cf21-40a3-839d-06e2619bb148"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bc4c7a1c-1266-4ea9-ac6c-3f0d6920d012"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("bc4c7a1c-1266-4ea9-ac6c-3f0d6920d012"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(665, 331),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("adc4214c-0c47-4c0a-b8a6-097854eda6fb"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("343a2212-cf21-40a3-839d-06e2619bb148"),
				CreatedInOwnerSchemaUId = new Guid("e14c6037-56bb-4724-95b6-3dc29d7f6b4f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bc4c7a1c-1266-4ea9-ac6c-3f0d6920d012"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("bc4c7a1c-1266-4ea9-ac6c-3f0d6920d012"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(636, 331),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("97f9a6e8-9ab1-4669-baf5-c2cfdb784af9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("adc4214c-0c47-4c0a-b8a6-097854eda6fb"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bc4c7a1c-1266-4ea9-ac6c-3f0d6920d012"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("bc4c7a1c-1266-4ea9-ac6c-3f0d6920d012"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(77, 0),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(294, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCurrencyRateSavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c9d96d44-f6bd-43fa-805f-a0592a93702d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("97f9a6e8-9ab1-4669-baf5-c2cfdb784af9"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bc4c7a1c-1266-4ea9-ac6c-3f0d6920d012"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CurrencyRateSaved",
				ModifiedInSchemaUId = new Guid("bc4c7a1c-1266-4ea9-ac6c-3f0d6920d012"),
				Name = @"CurrencyRateSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(22, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("cf4c07cc-737d-4e5f-b456-8a7dc2b2e7ff"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("97f9a6e8-9ab1-4669-baf5-c2cfdb784af9"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bc4c7a1c-1266-4ea9-ac6c-3f0d6920d012"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("bc4c7a1c-1266-4ea9-ac6c-3f0d6920d012"),
				Name = @"ScriptTask1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(169, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,173,40,200,44,74,117,78,76,206,72,213,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,215,53,203,50,28,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7a5096cb-4a71-447f-bbf1-fa4475ae3626"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("adc4214c-0c47-4c0a-b8a6-097854eda6fb"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bc4c7a1c-1266-4ea9-ac6c-3f0d6920d012"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("bc4c7a1c-1266-4ea9-ac6c-3f0d6920d012"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(77, 161),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(294, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCurrencyRateDeletedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("498889f7-49b9-4a11-b6be-1e3949d2fa4c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7a5096cb-4a71-447f-bbf1-fa4475ae3626"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bc4c7a1c-1266-4ea9-ac6c-3f0d6920d012"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CurrencyRateDeleted",
				ModifiedInSchemaUId = new Guid("bc4c7a1c-1266-4ea9-ac6c-3f0d6920d012"),
				Name = @"CurrencyRateDeleted",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(22, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d08a5c93-c77c-4a1d-9e6e-ac3fad4405c5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7a5096cb-4a71-447f-bbf1-fa4475ae3626"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bc4c7a1c-1266-4ea9-ac6c-3f0d6920d012"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("bc4c7a1c-1266-4ea9-ac6c-3f0d6920d012"),
				Name = @"ScriptTask2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(176, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,173,40,200,44,74,117,78,76,206,72,213,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,215,53,203,50,28,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateExpireCacheMethod());
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
				UId = new Guid("3103cbe1-089f-4eb9-ae5f-775c3259702d"),
				Name = "Terrasoft.Core.Store",
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

		protected virtual SchemaMethod CreateExpireCacheMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("38ae260c-d434-4975-8562-efb54d2d4baa"),
				Name = "ExpireCache",
				CreatedInSchemaUId = new Guid("bc4c7a1c-1266-4ea9-ac6c-3f0d6920d012"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,46,201,47,74,213,115,78,76,206,72,141,6,147,62,169,101,169,57,122,142,5,5,57,153,201,137,37,153,249,121,177,122,174,21,5,153,69,169,238,69,249,165,5,26,74,206,165,69,69,169,121,201,149,74,154,214,0,3,3,31,141,60,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CurrencyRate_Base_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bc4c7a1c-1266-4ea9-ac6c-3f0d6920d012"));
		}

		#endregion

	}

	#endregion

}

