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

	#region Class: CurrencyRate_UIv2_TerrasoftSchema

	/// <exclude/>
	public class CurrencyRate_UIv2_TerrasoftSchema : Terrasoft.Configuration.CurrencyRate_Base_TerrasoftSchema
	{

		#region Constructors: Public

		public CurrencyRate_UIv2_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CurrencyRate_UIv2_TerrasoftSchema(CurrencyRate_UIv2_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CurrencyRate_UIv2_TerrasoftSchema(CurrencyRate_UIv2_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("cc08a45a-98c8-476e-bd71-daf623698665");
			Name = "CurrencyRate_UIv2_Terrasoft";
			ParentSchemaUId = new Guid("e14c6037-56bb-4724-95b6-3dc29d7f6b4f");
			ExtendParent = true;
			CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("6c9f3250-8758-4e5a-9a49-c8aa0726fe30")) == null) {
				Columns.Add(CreateRateMantissaColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateRateMantissaColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("6c9f3250-8758-4e5a-9a49-c8aa0726fe30"),
				Name = @"RateMantissa",
				CreatedInSchemaUId = new Guid("cc08a45a-98c8-476e-bd71-daf623698665"),
				ModifiedInSchemaUId = new Guid("cc08a45a-98c8-476e-bd71-daf623698665"),
				CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCurrencyRate_UIv2_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateCurrencyRate_UIv2_TerrasoftEventsProcessSchema() {
			var schema = new CurrencyRate_UIv2_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new CurrencyRate_UIv2_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new CurrencyRate_UIv2EventsProcess(userConnection);
		}

		public override object Clone() {
			return new CurrencyRate_UIv2_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CurrencyRate_UIv2_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cc08a45a-98c8-476e-bd71-daf623698665"));
		}

		#endregion

	}

	#endregion

	#region Class: CurrencyRate_UIv2_Terrasoft

	/// <summary>
	/// Exchange rate.
	/// </summary>
	public class CurrencyRate_UIv2_Terrasoft : Terrasoft.Configuration.CurrencyRate_Base_Terrasoft
	{

		#region Constructors: Public

		public CurrencyRate_UIv2_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CurrencyRate_UIv2_Terrasoft";
		}

		public CurrencyRate_UIv2_Terrasoft(CurrencyRate_UIv2_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		public string RateMantissa {
			get {
				return GetTypedColumnValue<string>("RateMantissa");
			}
			set {
				SetColumnValue("RateMantissa", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CurrencyRate_UIv2EventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Saving += (s, e) => ThrowEvent("CurrencyRate_UIv2_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("CurrencyRate_UIv2_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CurrencyRate_UIv2_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: CurrencyRate_UIv2EventsProcess

	/// <exclude/>
	public partial class CurrencyRate_UIv2EventsProcess<TEntity> : Terrasoft.Configuration.CurrencyRate_BaseEventsProcess<TEntity> where TEntity : CurrencyRate_UIv2_Terrasoft
	{

		public CurrencyRate_UIv2EventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CurrencyRate_UIv2EventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("cc08a45a-98c8-476e-bd71-daf623698665");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess3;
		public ProcessFlowElement EventSubProcess3 {
			get {
				return _eventSubProcess3 ?? (_eventSubProcess3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3",
					SchemaElementUId = new Guid("df11dc2b-a610-4c9f-9e38-90b65bea4c19"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _currencyRateSavingMessage;
		public ProcessFlowElement CurrencyRateSavingMessage {
			get {
				return _currencyRateSavingMessage ?? (_currencyRateSavingMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CurrencyRateSavingMessage",
					SchemaElementUId = new Guid("5c0e8c0b-adf0-46e1-9ca6-6fd52b39f541"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _currencyRateSavingTask;
		public ProcessScriptTask CurrencyRateSavingTask {
			get {
				return _currencyRateSavingTask ?? (_currencyRateSavingTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CurrencyRateSavingTask",
					SchemaElementUId = new Guid("d4c169eb-978c-4536-aec2-dd7ce24e3dad"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CurrencyRateSavingTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[CurrencyRateSavingMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { CurrencyRateSavingMessage };
			FlowElements[CurrencyRateSavingTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CurrencyRateSavingTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess3":
						break;
					case "CurrencyRateSavingMessage":
						e.Context.QueueTasks.Enqueue("CurrencyRateSavingTask");
						break;
					case "CurrencyRateSavingTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("CurrencyRateSavingMessage");
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
				case "CurrencyRateSavingMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "CurrencyRateSavingMessage";
					result = CurrencyRateSavingMessage.Execute(context);
					break;
				case "CurrencyRateSavingTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CurrencyRateSavingTask";
					result = CurrencyRateSavingTask.Execute(context, CurrencyRateSavingTaskExecute);
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

		public virtual bool CurrencyRateSavingTaskExecute(ProcessExecutingContext context) {
			var changedColumns = Entity.GetChangedColumnValues();
			if (changedColumns.Any(c => c.Name == "Rate")) {
				EntitySchemaColumn rateColumn = Entity.Schema.Columns.FindByName("Rate");
				FloatDataValueType dataValueType = rateColumn.DataValueType as FloatDataValueType;
				decimal currencyRate = Entity.GetTypedColumnValue<decimal>("Rate");
				string mantissa = CurrencyRateHelper.GetRateMantissa(currencyRate);
				Entity.SetColumnValue("RateMantissa", mantissa);
				Entity.SetColumnValue("Rate", Math.Round(currencyRate, dataValueType.DBPrecision,
					MidpointRounding.AwayFromZero));
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "CurrencyRate_UIv2_TerrasoftSaving":
							if (ActivatedEventElements.Contains("CurrencyRateSavingMessage")) {
							context.QueueTasks.Enqueue("CurrencyRateSavingMessage");
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

	#region Class: CurrencyRate_UIv2EventsProcess

	/// <exclude/>
	public class CurrencyRate_UIv2EventsProcess : CurrencyRate_UIv2EventsProcess<CurrencyRate_UIv2_Terrasoft>
	{

		public CurrencyRate_UIv2EventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CurrencyRate_UIv2EventsProcess

	public partial class CurrencyRate_UIv2EventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: CurrencyRate_UIv2_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class CurrencyRate_UIv2_TerrasoftEventsProcessSchema : Terrasoft.Configuration.CurrencyRate_Base_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public CurrencyRate_UIv2_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CurrencyRate_UIv2_TerrasoftEventsProcessSchema(CurrencyRate_UIv2_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CurrencyRate_UIv2EventsProcess";
			UId = new Guid("dfc4ec5d-25ce-427f-a1fe-3fd3d7020fe1");
			CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bc4c7a1c-1266-4ea9-ac6c-3f0d6920d012");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet2 = CreateLaneSet2LaneSet();
			LaneSets.Add(schemaLaneSet2);
			ProcessSchemaLane schemaLane2 = CreateLane2Lane();
			schemaLaneSet2.Lanes.Add(schemaLane2);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaStartMessageEvent currencyratesavingmessage = CreateCurrencyRateSavingMessageStartMessageEvent();
			eventsubprocess3.FlowElements.Add(currencyratesavingmessage);
			ProcessSchemaScriptTask currencyratesavingtask = CreateCurrencyRateSavingTaskScriptTask();
			eventsubprocess3.FlowElements.Add(currencyratesavingtask);
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("e6538979-0817-4b8b-8b08-01feff86365b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bc4c7a1c-1266-4ea9-ac6c-3f0d6920d012"),
				CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18"),
				CreatedInSchemaUId = new Guid("dfc4ec5d-25ce-427f-a1fe-3fd3d7020fe1"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("dfc4ec5d-25ce-427f-a1fe-3fd3d7020fe1"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5c0e8c0b-adf0-46e1-9ca6-6fd52b39f541"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d4c169eb-978c-4536-aec2-dd7ce24e3dad"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet2LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet2 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("ba683244-0275-4acc-8245-c92ee807b62c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bc4c7a1c-1266-4ea9-ac6c-3f0d6920d012"),
				CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18"),
				CreatedInSchemaUId = new Guid("dfc4ec5d-25ce-427f-a1fe-3fd3d7020fe1"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("dfc4ec5d-25ce-427f-a1fe-3fd3d7020fe1"),
				Name = @"LaneSet2",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet2;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("b2ca37d7-4866-4d58-b6d4-8391c7201d0e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba683244-0275-4acc-8245-c92ee807b62c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18"),
				CreatedInSchemaUId = new Guid("dfc4ec5d-25ce-427f-a1fe-3fd3d7020fe1"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("dfc4ec5d-25ce-427f-a1fe-3fd3d7020fe1"),
				Name = @"Lane2",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("df11dc2b-a610-4c9f-9e38-90b65bea4c19"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b2ca37d7-4866-4d58-b6d4-8391c7201d0e"),
				CreatedInOwnerSchemaUId = new Guid("bc4c7a1c-1266-4ea9-ac6c-3f0d6920d012"),
				CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18"),
				CreatedInSchemaUId = new Guid("dfc4ec5d-25ce-427f-a1fe-3fd3d7020fe1"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("dfc4ec5d-25ce-427f-a1fe-3fd3d7020fe1"),
				Name = @"EventSubProcess3",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(225, 127),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(300, 300),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCurrencyRateSavingMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5c0e8c0b-adf0-46e1-9ca6-6fd52b39f541"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("df11dc2b-a610-4c9f-9e38-90b65bea4c19"),
				CreatedInOwnerSchemaUId = new Guid("bc4c7a1c-1266-4ea9-ac6c-3f0d6920d012"),
				CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18"),
				CreatedInSchemaUId = new Guid("dfc4ec5d-25ce-427f-a1fe-3fd3d7020fe1"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CurrencyRateSaving",
				ModifiedInSchemaUId = new Guid("dfc4ec5d-25ce-427f-a1fe-3fd3d7020fe1"),
				Name = @"CurrencyRateSavingMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(51, 145),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCurrencyRateSavingTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d4c169eb-978c-4536-aec2-dd7ce24e3dad"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("df11dc2b-a610-4c9f-9e38-90b65bea4c19"),
				CreatedInOwnerSchemaUId = new Guid("bc4c7a1c-1266-4ea9-ac6c-3f0d6920d012"),
				CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18"),
				CreatedInSchemaUId = new Guid("dfc4ec5d-25ce-427f-a1fe-3fd3d7020fe1"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("dfc4ec5d-25ce-427f-a1fe-3fd3d7020fe1"),
				Name = @"CurrencyRateSavingTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(182, 131),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,145,203,106,195,48,16,69,215,49,228,31,134,172,108,8,250,129,212,129,60,234,118,147,82,210,210,69,119,131,52,141,5,182,100,36,185,197,148,254,123,37,63,82,153,46,178,147,208,189,231,72,163,79,52,192,75,84,23,18,7,93,181,181,178,144,195,189,114,210,117,236,129,220,33,62,122,195,170,37,155,102,155,101,34,63,32,157,215,216,78,117,41,135,124,11,156,61,97,77,144,231,176,58,163,163,85,150,193,247,50,89,12,208,23,94,82,141,67,7,140,63,30,151,87,233,16,96,19,181,144,74,236,187,0,76,71,154,183,47,138,74,163,59,162,195,254,74,175,93,67,32,102,187,60,98,179,121,16,45,252,175,7,168,32,46,107,172,128,183,198,144,226,93,208,205,134,17,130,241,40,238,198,198,54,190,154,117,70,170,11,212,232,107,214,162,7,28,34,222,35,85,13,153,0,11,187,211,24,74,99,101,79,153,134,225,127,224,207,55,104,166,210,106,125,149,220,170,248,232,9,93,201,206,186,85,98,38,91,207,231,198,142,251,103,227,31,101,165,86,107,207,92,156,164,104,180,84,174,111,250,119,177,221,23,118,133,209,245,59,25,157,5,239,207,50,49,228,90,163,192,153,150,54,191,130,209,70,231,80,2,0,0 }
			};
			
			return ScriptTask;
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
				UId = new Guid("02311acd-ed09-4008-bee9-37828afca6f1"),
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

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CurrencyRate_UIv2_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dfc4ec5d-25ce-427f-a1fe-3fd3d7020fe1"));
		}

		#endregion

	}

	#endregion

}

