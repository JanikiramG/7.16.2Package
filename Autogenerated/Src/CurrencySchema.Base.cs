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

	#region Class: Currency_Base_TerrasoftSchema

	/// <exclude/>
	public class Currency_Base_TerrasoftSchema : Terrasoft.Configuration.BaseCodeLookupSchema
	{

		#region Constructors: Public

		public Currency_Base_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Currency_Base_TerrasoftSchema(Currency_Base_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Currency_Base_TerrasoftSchema(Currency_Base_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d");
			RealUId = new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d");
			Name = "Currency_Base_Terrasoft";
			ParentSchemaUId = new Guid("2681062b-df59-4e52-89ed-f9b7dc909ab2");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("81913c21-afcb-4a38-9164-af361a45d80f")) == null) {
				Columns.Add(CreateShortNameColumn());
			}
			if (Columns.FindByUId(new Guid("1468ee69-0ffb-496f-9d4d-e91c1656d474")) == null) {
				Columns.Add(CreateSymbolColumn());
			}
			if (Columns.FindByUId(new Guid("aa202f22-3aa0-441e-b192-5e03e7e8090d")) == null) {
				Columns.Add(CreateRecalcDirectionColumn());
			}
			if (Columns.FindByUId(new Guid("e8667452-cecb-4735-acf7-428ea8d62e50")) == null) {
				Columns.Add(CreateDivisionColumn());
			}
			if (Columns.FindByUId(new Guid("df51504c-ae63-42e8-964d-8a30ceff0a7c")) == null) {
				Columns.Add(CreateCurrecySymbolPositionColumn());
			}
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected override EntitySchemaColumn CreateCodeColumn() {
			EntitySchemaColumn column = base.CreateCodeColumn();
			column.ModifiedInSchemaUId = new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected virtual EntitySchemaColumn CreateShortNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("81913c21-afcb-4a38-9164-af361a45d80f"),
				Name = @"ShortName",
				CreatedInSchemaUId = new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d"),
				ModifiedInSchemaUId = new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSymbolColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("1468ee69-0ffb-496f-9d4d-e91c1656d474"),
				Name = @"Symbol",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d"),
				ModifiedInSchemaUId = new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateRecalcDirectionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("aa202f22-3aa0-441e-b192-5e03e7e8090d"),
				Name = @"RecalcDirection",
				CreatedInSchemaUId = new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d"),
				ModifiedInSchemaUId = new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateDivisionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("e8667452-cecb-4735-acf7-428ea8d62e50"),
				Name = @"Division",
				CreatedInSchemaUId = new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d"),
				ModifiedInSchemaUId = new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"1"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateCurrecySymbolPositionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("df51504c-ae63-42e8-964d-8a30ceff0a7c"),
				Name = @"CurrecySymbolPosition",
				UsageType = EntitySchemaColumnUsageType.Advanced,
				CreatedInSchemaUId = new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d"),
				ModifiedInSchemaUId = new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"0"
				}
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCurrency_Base_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateCurrency_Base_TerrasoftEventsProcessSchema() {
			var schema = new Currency_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Currency_Base_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Currency_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Currency_Base_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Currency_Base_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d"));
		}

		#endregion

	}

	#endregion

	#region Class: Currency_Base_Terrasoft

	/// <summary>
	/// Currency.
	/// </summary>
	public class Currency_Base_Terrasoft : Terrasoft.Configuration.BaseCodeLookup
	{

		#region Constructors: Public

		public Currency_Base_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Currency_Base_Terrasoft";
		}

		public Currency_Base_Terrasoft(Currency_Base_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Short name.
		/// </summary>
		public string ShortName {
			get {
				return GetTypedColumnValue<string>("ShortName");
			}
			set {
				SetColumnValue("ShortName", value);
			}
		}

		/// <summary>
		/// Symbol.
		/// </summary>
		public string Symbol {
			get {
				return GetTypedColumnValue<string>("Symbol");
			}
			set {
				SetColumnValue("Symbol", value);
			}
		}

		/// <summary>
		/// Exchange rate format.
		/// </summary>
		public int RecalcDirection {
			get {
				return GetTypedColumnValue<int>("RecalcDirection");
			}
			set {
				SetColumnValue("RecalcDirection", value);
			}
		}

		/// <summary>
		/// Ratio.
		/// </summary>
		public int Division {
			get {
				return GetTypedColumnValue<int>("Division");
			}
			set {
				SetColumnValue("Division", value);
			}
		}

		/// <summary>
		/// Position of currency sign.
		/// </summary>
		public int CurrecySymbolPosition {
			get {
				return GetTypedColumnValue<int>("CurrecySymbolPosition");
			}
			set {
				SetColumnValue("CurrecySymbolPosition", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Currency_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Currency_Base_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("Currency_Base_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("Currency_Base_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("Currency_Base_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("Currency_Base_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Currency_Base_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Currency_Base_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Currency_Base_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Currency_BaseEventsProcess

	/// <exclude/>
	public partial class Currency_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseCodeLookup_BaseEventsProcess<TEntity> where TEntity : Currency_Base_Terrasoft
	{

		public Currency_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Currency_BaseEventsProcess";
			SchemaUId = new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _currencySavingEventSubProcess;
		public ProcessFlowElement CurrencySavingEventSubProcess {
			get {
				return _currencySavingEventSubProcess ?? (_currencySavingEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "CurrencySavingEventSubProcess",
					SchemaElementUId = new Guid("d7405b28-4dd8-44bf-ae25-c0cc5c2dcf64"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _currencySaved;
		public ProcessFlowElement CurrencySaved {
			get {
				return _currencySaved ?? (_currencySaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CurrencySaved",
					SchemaElementUId = new Guid("51c97a53-807d-4adf-aa96-5cf39648a605"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _currencySavingScriptTask;
		public ProcessScriptTask CurrencySavingScriptTask {
			get {
				return _currencySavingScriptTask ?? (_currencySavingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CurrencySavingScriptTask",
					SchemaElementUId = new Guid("29c3e3d3-a9c9-46b9-80ff-d849ae891091"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CurrencySavingScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _currencyDeletedEventSubProcess;
		public ProcessFlowElement CurrencyDeletedEventSubProcess {
			get {
				return _currencyDeletedEventSubProcess ?? (_currencyDeletedEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "CurrencyDeletedEventSubProcess",
					SchemaElementUId = new Guid("84ba92f4-eb44-4c72-8628-ae123b9ed515"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _currencyDeleted;
		public ProcessFlowElement CurrencyDeleted {
			get {
				return _currencyDeleted ?? (_currencyDeleted = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CurrencyDeleted",
					SchemaElementUId = new Guid("1ee26a11-bba1-4f28-bc80-a4e392f9c495"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _currencyDeletedScriptTask;
		public ProcessScriptTask CurrencyDeletedScriptTask {
			get {
				return _currencyDeletedScriptTask ?? (_currencyDeletedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CurrencyDeletedScriptTask",
					SchemaElementUId = new Guid("bb4be2b3-ed2e-4cce-8aff-007db2e53dc4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CurrencyDeletedScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[CurrencySavingEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { CurrencySavingEventSubProcess };
			FlowElements[CurrencySaved.SchemaElementUId] = new Collection<ProcessFlowElement> { CurrencySaved };
			FlowElements[CurrencySavingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CurrencySavingScriptTask };
			FlowElements[CurrencyDeletedEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { CurrencyDeletedEventSubProcess };
			FlowElements[CurrencyDeleted.SchemaElementUId] = new Collection<ProcessFlowElement> { CurrencyDeleted };
			FlowElements[CurrencyDeletedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CurrencyDeletedScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "CurrencySavingEventSubProcess":
						break;
					case "CurrencySaved":
						e.Context.QueueTasks.Enqueue("CurrencySavingScriptTask");
						break;
					case "CurrencySavingScriptTask":
						break;
					case "CurrencyDeletedEventSubProcess":
						break;
					case "CurrencyDeleted":
						e.Context.QueueTasks.Enqueue("CurrencyDeletedScriptTask");
						break;
					case "CurrencyDeletedScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("CurrencySaved");
			ActivatedEventElements.Add("CurrencyDeleted");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "CurrencySavingEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "CurrencySaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "CurrencySaved";
					result = CurrencySaved.Execute(context);
					break;
				case "CurrencySavingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CurrencySavingScriptTask";
					result = CurrencySavingScriptTask.Execute(context, CurrencySavingScriptTaskExecute);
					break;
				case "CurrencyDeletedEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "CurrencyDeleted":
					context.QueueTasks.Dequeue();
					context.SenderName = "CurrencyDeleted";
					result = CurrencyDeleted.Execute(context);
					break;
				case "CurrencyDeletedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CurrencyDeletedScriptTask";
					result = CurrencyDeletedScriptTask.Execute(context, CurrencyDeletedScriptTaskExecute);
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

		public virtual bool CurrencySavingScriptTaskExecute(ProcessExecutingContext context) {
			ExpireCache();
			return true;
		}

		public virtual bool CurrencyDeletedScriptTaskExecute(ProcessExecutingContext context) {
			ExpireCache();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Currency_Base_TerrasoftSaved":
							if (ActivatedEventElements.Contains("CurrencySaved")) {
							context.QueueTasks.Enqueue("CurrencySaved");
						}
						break;
					case "Currency_Base_TerrasoftDeleted":
							if (ActivatedEventElements.Contains("CurrencyDeleted")) {
							context.QueueTasks.Enqueue("CurrencyDeleted");
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

	#region Class: Currency_BaseEventsProcess

	/// <exclude/>
	public class Currency_BaseEventsProcess : Currency_BaseEventsProcess<Currency_Base_Terrasoft>
	{

		public Currency_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Currency_BaseEventsProcess

	public partial class Currency_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void ExpireCache() {
			Store.Cache[CacheLevel.Application].ExpireGroup("Currency");
		}

		#endregion

	}

	#endregion

	#region Class: Currency_Base_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Currency_Base_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseCodeLookupEventsProcessSchema
	{

		#region Constructors: Public

		public Currency_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Currency_Base_TerrasoftEventsProcessSchema(Currency_Base_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Currency_BaseEventsProcess";
			UId = new Guid("98df6470-0049-425f-9331-3349d7ea5773");
			CreatedInPackageId = new Guid("b466acb1-8049-4776-835c-a1e006a6057c");
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
			ProcessSchemaLaneSet schemaCurrencyLaneSet1 = CreateCurrencyLaneSet1LaneSet();
			LaneSets.Add(schemaCurrencyLaneSet1);
			ProcessSchemaLane schemaCurrencyLane1 = CreateCurrencyLane1Lane();
			schemaCurrencyLaneSet1.Lanes.Add(schemaCurrencyLane1);
			ProcessSchemaEventSubProcess currencysavingeventsubprocess = CreateCurrencySavingEventSubProcessEventSubProcess();
			FlowElements.Add(currencysavingeventsubprocess);
			ProcessSchemaEventSubProcess currencydeletedeventsubprocess = CreateCurrencyDeletedEventSubProcessEventSubProcess();
			FlowElements.Add(currencydeletedeventsubprocess);
			ProcessSchemaStartMessageEvent currencysaved = CreateCurrencySavedStartMessageEvent();
			currencysavingeventsubprocess.FlowElements.Add(currencysaved);
			ProcessSchemaScriptTask currencysavingscripttask = CreateCurrencySavingScriptTaskScriptTask();
			currencysavingeventsubprocess.FlowElements.Add(currencysavingscripttask);
			ProcessSchemaStartMessageEvent currencydeleted = CreateCurrencyDeletedStartMessageEvent();
			currencydeletedeventsubprocess.FlowElements.Add(currencydeleted);
			ProcessSchemaScriptTask currencydeletedscripttask = CreateCurrencyDeletedScriptTaskScriptTask();
			currencydeletedeventsubprocess.FlowElements.Add(currencydeletedscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("d62cef9f-3e6b-416a-80d6-fe2e1374fc7e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("ac8d0498-3a35-4ee5-ba97-2bf896fcc5e2"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("98df6470-0049-425f-9331-3349d7ea5773"),
				CurveCenterPosition = new Point(238, 73),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("98df6470-0049-425f-9331-3349d7ea5773"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("51c97a53-807d-4adf-aa96-5cf39648a605"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("29c3e3d3-a9c9-46b9-80ff-d849ae891091"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("736a7523-9556-46ab-8f7e-48a341056764"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("ac8d0498-3a35-4ee5-ba97-2bf896fcc5e2"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("98df6470-0049-425f-9331-3349d7ea5773"),
				CurveCenterPosition = new Point(238, 228),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("98df6470-0049-425f-9331-3349d7ea5773"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1ee26a11-bba1-4f28-bc80-a4e392f9c495"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bb4be2b3-ed2e-4cce-8aff-007db2e53dc4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateCurrencyLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaCurrencyLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("300767cb-4956-4a42-85eb-bc0643f7ec5b"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("ac8d0498-3a35-4ee5-ba97-2bf896fcc5e2"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("98df6470-0049-425f-9331-3349d7ea5773"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("98df6470-0049-425f-9331-3349d7ea5773"),
				Name = @"CurrencyLaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(646, 717),
				UseBackgroundMode = false
			};
			return schemaCurrencyLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateCurrencyLane1Lane() {
			ProcessSchemaLane schemaCurrencyLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("4bd81063-d148-47a3-a77a-04e4e297af2e"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("300767cb-4956-4a42-85eb-bc0643f7ec5b"),
				CreatedInOwnerSchemaUId = new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("98df6470-0049-425f-9331-3349d7ea5773"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("98df6470-0049-425f-9331-3349d7ea5773"),
				Name = @"CurrencyLane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(617, 312),
				UseBackgroundMode = false
			};
			return schemaCurrencyLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateCurrencySavingEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaCurrencySavingEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("d7405b28-4dd8-44bf-ae25-c0cc5c2dcf64"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4bd81063-d148-47a3-a77a-04e4e297af2e"),
				CreatedInOwnerSchemaUId = new Guid("ac8d0498-3a35-4ee5-ba97-2bf896fcc5e2"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("98df6470-0049-425f-9331-3349d7ea5773"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("98df6470-0049-425f-9331-3349d7ea5773"),
				Name = @"CurrencySavingEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(90, 20),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(332, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaCurrencySavingEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCurrencySavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("51c97a53-807d-4adf-aa96-5cf39648a605"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d7405b28-4dd8-44bf-ae25-c0cc5c2dcf64"),
				CreatedInOwnerSchemaUId = new Guid("ac8d0498-3a35-4ee5-ba97-2bf896fcc5e2"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("98df6470-0049-425f-9331-3349d7ea5773"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CurrencySaved",
				ModifiedInSchemaUId = new Guid("98df6470-0049-425f-9331-3349d7ea5773"),
				Name = @"CurrencySaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCurrencySavingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("29c3e3d3-a9c9-46b9-80ff-d849ae891091"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d7405b28-4dd8-44bf-ae25-c0cc5c2dcf64"),
				CreatedInOwnerSchemaUId = new Guid("ac8d0498-3a35-4ee5-ba97-2bf896fcc5e2"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("98df6470-0049-425f-9331-3349d7ea5773"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("98df6470-0049-425f-9331-3349d7ea5773"),
				Name = @"CurrencySavingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(150, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,173,40,200,44,74,117,78,76,206,72,213,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,215,53,203,50,28,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateCurrencyDeletedEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaCurrencyDeletedEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("84ba92f4-eb44-4c72-8628-ae123b9ed515"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4bd81063-d148-47a3-a77a-04e4e297af2e"),
				CreatedInOwnerSchemaUId = new Guid("ac8d0498-3a35-4ee5-ba97-2bf896fcc5e2"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("98df6470-0049-425f-9331-3349d7ea5773"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("98df6470-0049-425f-9331-3349d7ea5773"),
				Name = @"CurrencyDeletedEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(87, 232),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(328, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaCurrencyDeletedEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCurrencyDeletedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("1ee26a11-bba1-4f28-bc80-a4e392f9c495"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("84ba92f4-eb44-4c72-8628-ae123b9ed515"),
				CreatedInOwnerSchemaUId = new Guid("ac8d0498-3a35-4ee5-ba97-2bf896fcc5e2"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("98df6470-0049-425f-9331-3349d7ea5773"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CurrencyDeleted",
				ModifiedInSchemaUId = new Guid("98df6470-0049-425f-9331-3349d7ea5773"),
				Name = @"CurrencyDeleted",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCurrencyDeletedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("bb4be2b3-ed2e-4cce-8aff-007db2e53dc4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("84ba92f4-eb44-4c72-8628-ae123b9ed515"),
				CreatedInOwnerSchemaUId = new Guid("ac8d0498-3a35-4ee5-ba97-2bf896fcc5e2"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("98df6470-0049-425f-9331-3349d7ea5773"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("98df6470-0049-425f-9331-3349d7ea5773"),
				Name = @"CurrencyDeletedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(158, 37),
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
				UId = new Guid("6680c277-0f96-4c77-8a69-c03d237b4c4f"),
				Name = "Terrasoft.Core.Store",
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
				UId = new Guid("3d8ac0c7-baf1-4783-b227-5023e1b673f7"),
				Name = "ExpireCache",
				CreatedInSchemaUId = new Guid("98df6470-0049-425f-9331-3349d7ea5773"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,46,201,47,74,213,115,78,76,206,72,141,6,147,62,169,101,169,57,122,142,5,5,57,153,201,137,37,153,249,121,177,122,174,21,5,153,69,169,238,69,249,165,5,26,74,206,165,69,69,169,121,201,149,74,154,214,0,3,3,31,141,60,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Currency_Base_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("98df6470-0049-425f-9331-3349d7ea5773"));
		}

		#endregion

	}

	#endregion

}

