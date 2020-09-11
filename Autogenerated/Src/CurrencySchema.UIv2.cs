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

	#region Class: Currency_UIv2_TerrasoftSchema

	/// <exclude/>
	public class Currency_UIv2_TerrasoftSchema : Terrasoft.Configuration.Currency_Base_TerrasoftSchema
	{

		#region Constructors: Public

		public Currency_UIv2_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Currency_UIv2_TerrasoftSchema(Currency_UIv2_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Currency_UIv2_TerrasoftSchema(Currency_UIv2_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("e9ccd05c-37ff-4981-b149-cde79e14441e");
			Name = "Currency_UIv2_Terrasoft";
			ParentSchemaUId = new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d");
			ExtendParent = true;
			CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("b13238af-3645-4799-8cf7-063a08194804")) == null) {
				Columns.Add(CreateRateColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateRateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float8")) {
				UId = new Guid("b13238af-3645-4799-8cf7-063a08194804"),
				Name = @"Rate",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("e9ccd05c-37ff-4981-b149-cde79e14441e"),
				ModifiedInSchemaUId = new Guid("e9ccd05c-37ff-4981-b149-cde79e14441e"),
				CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCurrency_UIv2_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateCurrency_UIv2_TerrasoftEventsProcessSchema() {
			var schema = new Currency_UIv2_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Currency_UIv2_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Currency_UIv2EventsProcess(userConnection);
		}

		public override object Clone() {
			return new Currency_UIv2_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Currency_UIv2_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e9ccd05c-37ff-4981-b149-cde79e14441e"));
		}

		#endregion

	}

	#endregion

	#region Class: Currency_UIv2_Terrasoft

	/// <summary>
	/// Currency.
	/// </summary>
	public class Currency_UIv2_Terrasoft : Terrasoft.Configuration.Currency_Base_Terrasoft
	{

		#region Constructors: Public

		public Currency_UIv2_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Currency_UIv2_Terrasoft";
		}

		public Currency_UIv2_Terrasoft(Currency_UIv2_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Rate.
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
			var process = new Currency_UIv2EventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Saved += (s, e) => ThrowEvent("Currency_UIv2_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Currency_UIv2_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Currency_UIv2_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Currency_UIv2_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Currency_UIv2EventsProcess

	/// <exclude/>
	public partial class Currency_UIv2EventsProcess<TEntity> : Terrasoft.Configuration.Currency_BaseEventsProcess<TEntity> where TEntity : Currency_UIv2_Terrasoft
	{

		public Currency_UIv2EventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Currency_UIv2EventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e9ccd05c-37ff-4981-b149-cde79e14441e");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual Decimal CurrencyRate {
			get;
			set;
		}

		public virtual Decimal OldCurrencyRate {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess3;
		public ProcessFlowElement EventSubProcess3 {
			get {
				return _eventSubProcess3 ?? (_eventSubProcess3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3",
					SchemaElementUId = new Guid("2910f140-1474-45b0-978e-b68a53f64864"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _currencySaving;
		public ProcessFlowElement CurrencySaving {
			get {
				return _currencySaving ?? (_currencySaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CurrencySaving",
					SchemaElementUId = new Guid("bc2abbd2-8988-42b1-b3d5-d237ff445474"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask3;
		public ProcessScriptTask ScriptTask3 {
			get {
				return _scriptTask3 ?? (_scriptTask3 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3",
					SchemaElementUId = new Guid("33c212dd-d323-42ad-8c08-0f7e7408d894"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3Execute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess4;
		public ProcessFlowElement EventSubProcess4 {
			get {
				return _eventSubProcess4 ?? (_eventSubProcess4 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess4",
					SchemaElementUId = new Guid("3226b250-eb4b-436a-801d-980c0ffdf7d6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage2;
		public ProcessFlowElement StartMessage2 {
			get {
				return _startMessage2 ?? (_startMessage2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage2",
					SchemaElementUId = new Guid("14ffda80-4f0e-4421-88b2-5ce78d68260c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask4;
		public ProcessScriptTask ScriptTask4 {
			get {
				return _scriptTask4 ?? (_scriptTask4 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask4",
					SchemaElementUId = new Guid("0887721e-8742-4ce5-b693-1229d45bc238"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask4Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[CurrencySaving.SchemaElementUId] = new Collection<ProcessFlowElement> { CurrencySaving };
			FlowElements[ScriptTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3 };
			FlowElements[EventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4 };
			FlowElements[StartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2 };
			FlowElements[ScriptTask4.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask4 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess3":
						break;
					case "CurrencySaving":
						e.Context.QueueTasks.Enqueue("ScriptTask3");
						break;
					case "ScriptTask3":
						break;
					case "EventSubProcess4":
						break;
					case "StartMessage2":
						e.Context.QueueTasks.Enqueue("ScriptTask4");
						break;
					case "ScriptTask4":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("CurrencySaving");
			ActivatedEventElements.Add("StartMessage2");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "CurrencySaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "CurrencySaving";
					result = CurrencySaving.Execute(context);
					break;
				case "ScriptTask3":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3";
					result = ScriptTask3.Execute(context, ScriptTask3Execute);
					break;
				case "EventSubProcess4":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage2";
					result = StartMessage2.Execute(context);
					break;
				case "ScriptTask4":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask4";
					result = ScriptTask4.Execute(context, ScriptTask4Execute);
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

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "OldCurrencyRate":
					OldCurrencyRate = reader.GetValue<System.Decimal>();
				break;
				case "CurrencyRate":
					CurrencyRate = reader.GetValue<System.Decimal>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask3Execute(ProcessExecutingContext context) {
			OnCurrencySavingHandler();
			return true;
		}

		public virtual bool ScriptTask4Execute(ProcessExecutingContext context) {
			OnCurrencySavedHandler();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Currency_UIv2_TerrasoftSaving":
							if (ActivatedEventElements.Contains("CurrencySaving")) {
							context.QueueTasks.Enqueue("CurrencySaving");
						}
						break;
					case "Currency_UIv2_TerrasoftSaved":
							if (ActivatedEventElements.Contains("StartMessage2")) {
							context.QueueTasks.Enqueue("StartMessage2");
							ProcessQueue(context);
							return;
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("OldCurrencyRate") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("OldCurrencyRate", OldCurrencyRate, 0m);
			}
			if (!HasMapping("CurrencyRate") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CurrencyRate", CurrencyRate, 0m);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: Currency_UIv2EventsProcess

	/// <exclude/>
	public class Currency_UIv2EventsProcess : Currency_UIv2EventsProcess<Currency_UIv2_Terrasoft>
	{

		public Currency_UIv2EventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Currency_UIv2EventsProcess

	public partial class Currency_UIv2EventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void OnCurrencySavedHandler() {
			Store.Cache[CacheLevel.Application].ExpireGroup("Currency");
			var currRateSchema = UserConnection.EntitySchemaManager.GetInstanceByName("CurrencyRate");
			var currencyRateStorage = Terrasoft.Core.Factories.ClassFactory.Get<Terrasoft.Configuration.CurrencyRateStorage>(
				new Terrasoft.Core.Factories.ConstructorArgument("userConnection", UserConnection),
				new Terrasoft.Core.Factories.ConstructorArgument("schema", currRateSchema));
			List<CurrencyRateInfo> rates = currencyRateStorage.GetActualCurrencyRates(Entity.PrimaryColumnValue);
			CurrencyRateInfo currentCurrenyRate = rates.FirstOrDefault();
			if (currentCurrenyRate != null) {
				OldCurrencyRate = CurrencyRateHelper.SetMantissaToRate(currentCurrenyRate.Rate, currentCurrenyRate.RateMantissa);
			}
			if (CurrencyRate > 0.00m && OldCurrencyRate != CurrencyRate) {
				currencyRateStorage.SaveRates(new CurrencyRateInfo() {
					CurrencyId = Entity.PrimaryColumnValue, 
					Rate = CurrencyRate
				});
			}
		}

		public virtual void OnCurrencySavingHandler() {
			var columns = Entity.GetChangedColumnValues();
			var rateColumnName = Entity.Schema.Columns.GetByName("Rate").ColumnValueName;
			CurrencyRate = Entity.GetTypedColumnValue<decimal>(rateColumnName);
			Entity.SetColumnValue("Rate", 0.00m);
		}

		#endregion

	}

	#endregion

	#region Class: Currency_UIv2_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Currency_UIv2_TerrasoftEventsProcessSchema : Terrasoft.Configuration.Currency_Base_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public Currency_UIv2_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Currency_UIv2_TerrasoftEventsProcessSchema(Currency_UIv2_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Currency_UIv2EventsProcess";
			UId = new Guid("fe9d77df-4e59-4950-b89b-0eae5182a9a9");
			CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("98df6470-0049-425f-9331-3349d7ea5773");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateCurrencyRateParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("27697147-7d2b-4709-bbdb-1e51f6d4729d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe9d77df-4e59-4950-b89b-0eae5182a9a9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe9d77df-4e59-4950-b89b-0eae5182a9a9"),
				Name = @"CurrencyRate",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Money"),
			};
		}

		protected virtual ProcessSchemaParameter CreateOldCurrencyRateParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("04de266d-75fd-44f5-9107-9a7eb406a0d5"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe9d77df-4e59-4950-b89b-0eae5182a9a9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe9d77df-4e59-4950-b89b-0eae5182a9a9"),
				Name = @"OldCurrencyRate",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Money"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateCurrencyRateParameter());
			Parameters.Add(CreateOldCurrencyRateParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet2 = CreateLaneSet2LaneSet();
			LaneSets.Add(schemaLaneSet2);
			ProcessSchemaLane schemaLane2 = CreateLane2Lane();
			schemaLaneSet2.Lanes.Add(schemaLane2);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaEventSubProcess eventsubprocess4 = CreateEventSubProcess4EventSubProcess();
			FlowElements.Add(eventsubprocess4);
			ProcessSchemaStartMessageEvent currencysaving = CreateCurrencySavingStartMessageEvent();
			eventsubprocess3.FlowElements.Add(currencysaving);
			ProcessSchemaScriptTask scripttask3 = CreateScriptTask3ScriptTask();
			eventsubprocess3.FlowElements.Add(scripttask3);
			ProcessSchemaStartMessageEvent startmessage2 = CreateStartMessage2StartMessageEvent();
			eventsubprocess4.FlowElements.Add(startmessage2);
			ProcessSchemaScriptTask scripttask4 = CreateScriptTask4ScriptTask();
			eventsubprocess4.FlowElements.Add(scripttask4);
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("90cd025d-cea4-47eb-9e86-32b37bc994bd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("98df6470-0049-425f-9331-3349d7ea5773"),
				CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18"),
				CreatedInSchemaUId = new Guid("fe9d77df-4e59-4950-b89b-0eae5182a9a9"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fe9d77df-4e59-4950-b89b-0eae5182a9a9"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bc2abbd2-8988-42b1-b3d5-d237ff445474"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("33c212dd-d323-42ad-8c08-0f7e7408d894"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("37926ecc-d5f1-4250-aabb-a07fccb7e6ce"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("98df6470-0049-425f-9331-3349d7ea5773"),
				CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18"),
				CreatedInSchemaUId = new Guid("fe9d77df-4e59-4950-b89b-0eae5182a9a9"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fe9d77df-4e59-4950-b89b-0eae5182a9a9"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("14ffda80-4f0e-4421-88b2-5ce78d68260c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0887721e-8742-4ce5-b693-1229d45bc238"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet2LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet2 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("976f14e5-89f3-4d82-beb7-ed1dd913eb6e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("98df6470-0049-425f-9331-3349d7ea5773"),
				CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18"),
				CreatedInSchemaUId = new Guid("fe9d77df-4e59-4950-b89b-0eae5182a9a9"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("fe9d77df-4e59-4950-b89b-0eae5182a9a9"),
				Name = @"LaneSet2",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet2;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("d624d672-a28a-4629-9730-9292202f9a4f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("976f14e5-89f3-4d82-beb7-ed1dd913eb6e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18"),
				CreatedInSchemaUId = new Guid("fe9d77df-4e59-4950-b89b-0eae5182a9a9"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("fe9d77df-4e59-4950-b89b-0eae5182a9a9"),
				Name = @"Lane2",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2910f140-1474-45b0-978e-b68a53f64864"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d624d672-a28a-4629-9730-9292202f9a4f"),
				CreatedInOwnerSchemaUId = new Guid("98df6470-0049-425f-9331-3349d7ea5773"),
				CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18"),
				CreatedInSchemaUId = new Guid("fe9d77df-4e59-4950-b89b-0eae5182a9a9"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fe9d77df-4e59-4950-b89b-0eae5182a9a9"),
				Name = @"EventSubProcess3",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 165),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(300, 300),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCurrencySavingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("bc2abbd2-8988-42b1-b3d5-d237ff445474"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2910f140-1474-45b0-978e-b68a53f64864"),
				CreatedInOwnerSchemaUId = new Guid("98df6470-0049-425f-9331-3349d7ea5773"),
				CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18"),
				CreatedInSchemaUId = new Guid("fe9d77df-4e59-4950-b89b-0eae5182a9a9"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CurrencySaving",
				ModifiedInSchemaUId = new Guid("fe9d77df-4e59-4950-b89b-0eae5182a9a9"),
				Name = @"CurrencySaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(38, 126),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask3ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("33c212dd-d323-42ad-8c08-0f7e7408d894"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2910f140-1474-45b0-978e-b68a53f64864"),
				CreatedInOwnerSchemaUId = new Guid("98df6470-0049-425f-9331-3349d7ea5773"),
				CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18"),
				CreatedInSchemaUId = new Guid("fe9d77df-4e59-4950-b89b-0eae5182a9a9"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fe9d77df-4e59-4950-b89b-0eae5182a9a9"),
				Name = @"ScriptTask3",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(178, 112),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,115,46,45,42,74,205,75,174,12,78,44,203,204,75,247,72,204,75,201,73,45,210,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,252,5,82,74,40,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("3226b250-eb4b-436a-801d-980c0ffdf7d6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d624d672-a28a-4629-9730-9292202f9a4f"),
				CreatedInOwnerSchemaUId = new Guid("98df6470-0049-425f-9331-3349d7ea5773"),
				CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18"),
				CreatedInSchemaUId = new Guid("fe9d77df-4e59-4950-b89b-0eae5182a9a9"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fe9d77df-4e59-4950-b89b-0eae5182a9a9"),
				Name = @"EventSubProcess4",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(380, 164),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(300, 300),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess4;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("14ffda80-4f0e-4421-88b2-5ce78d68260c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3226b250-eb4b-436a-801d-980c0ffdf7d6"),
				CreatedInOwnerSchemaUId = new Guid("98df6470-0049-425f-9331-3349d7ea5773"),
				CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18"),
				CreatedInSchemaUId = new Guid("fe9d77df-4e59-4950-b89b-0eae5182a9a9"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CurrencySaved",
				ModifiedInSchemaUId = new Guid("fe9d77df-4e59-4950-b89b-0eae5182a9a9"),
				Name = @"StartMessage2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(39, 143),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask4ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0887721e-8742-4ce5-b693-1229d45bc238"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3226b250-eb4b-436a-801d-980c0ffdf7d6"),
				CreatedInOwnerSchemaUId = new Guid("98df6470-0049-425f-9331-3349d7ea5773"),
				CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18"),
				CreatedInSchemaUId = new Guid("fe9d77df-4e59-4950-b89b-0eae5182a9a9"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fe9d77df-4e59-4950-b89b-0eae5182a9a9"),
				Name = @"ScriptTask4",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(188, 129),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,115,46,45,42,74,205,75,174,12,78,44,75,77,241,72,204,75,201,73,45,210,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,45,9,76,142,39,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateOnCurrencySavedHandlerMethod());
			Methods.Add(CreateOnCurrencySavingHandlerMethod());
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
				UId = new Guid("2c48fab4-7b1e-42e2-8514-410996e6a4aa"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18")
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

		protected virtual SchemaMethod CreateOnCurrencySavedHandlerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0d917bd7-6823-4fe0-b88f-fb09b1d7056c"),
				Name = "OnCurrencySavedHandler",
				CreatedInSchemaUId = new Guid("fe9d77df-4e59-4950-b89b-0eae5182a9a9"),
				CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,82,77,107,27,49,16,61,219,191,66,241,33,172,193,8,223,27,27,220,109,226,26,220,184,100,221,94,74,15,195,102,214,21,104,165,101,36,57,89,74,254,123,70,218,152,174,221,77,15,189,8,102,70,239,99,158,84,120,75,40,115,40,127,225,143,116,110,241,136,90,174,154,70,171,18,188,178,230,167,188,125,110,20,225,154,108,104,178,73,30,136,208,148,237,100,250,97,124,4,18,37,215,15,224,177,96,108,13,98,33,190,57,164,220,26,131,101,68,203,91,227,149,111,187,233,23,48,112,64,146,107,244,27,227,60,152,18,63,182,247,80,227,31,218,72,213,167,62,245,10,246,201,88,230,223,35,17,56,91,121,153,71,235,119,80,242,72,161,147,185,6,231,186,178,141,18,55,253,155,166,82,135,64,105,33,153,255,205,187,204,198,35,131,79,255,32,183,108,152,66,44,87,116,8,53,26,159,77,194,217,170,147,217,197,238,211,217,255,144,186,20,21,147,157,39,59,229,80,182,202,249,155,190,251,141,169,236,82,240,90,232,56,153,129,188,98,14,171,210,7,208,125,152,203,186,87,145,95,73,213,64,109,110,117,168,205,119,208,1,89,229,82,224,141,215,119,253,212,102,177,36,42,239,20,57,191,163,79,88,65,208,62,99,180,170,68,54,0,184,90,8,19,180,158,138,223,227,209,78,63,246,53,152,172,95,126,70,221,240,31,41,208,243,119,241,202,57,216,219,216,31,96,149,241,152,13,248,75,131,19,156,77,189,36,91,103,162,75,49,151,243,121,45,174,175,197,165,159,171,115,67,201,243,80,182,5,28,177,139,51,190,242,101,108,89,194,141,78,237,205,35,239,249,110,236,51,193,87,7,194,24,143,94,162,253,87,161,50,72,132,166,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnCurrencySavingHandlerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("768172cb-ddb3-4f9f-844c-73ea55efa717"),
				Name = "OnCurrencySavingHandler",
				CreatedInSchemaUId = new Guid("fe9d77df-4e59-4950-b89b-0eae5182a9a9"),
				CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,142,187,14,194,32,20,134,247,62,5,233,4,137,33,236,168,131,196,184,57,168,113,63,161,39,182,9,160,225,210,132,183,23,172,166,178,254,183,239,159,193,19,253,52,201,186,64,118,228,232,226,20,51,63,97,84,35,184,7,14,234,99,221,193,36,12,148,201,110,46,113,15,17,23,253,12,22,215,214,85,143,104,129,47,86,168,35,135,92,19,180,191,148,70,207,248,223,88,213,101,167,146,247,232,116,174,126,67,191,229,87,195,222,14,168,39,11,102,79,91,120,121,244,131,151,203,107,254,139,220,16,193,133,176,76,190,1,200,5,206,23,230,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Currency_UIv2_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fe9d77df-4e59-4950-b89b-0eae5182a9a9"));
		}

		#endregion

	}

	#endregion

}

