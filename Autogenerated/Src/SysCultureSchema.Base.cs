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

	#region Class: SysCulture_Base_TerrasoftSchema

	/// <exclude/>
	public class SysCulture_Base_TerrasoftSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public SysCulture_Base_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysCulture_Base_TerrasoftSchema(SysCulture_Base_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysCulture_Base_TerrasoftSchema(SysCulture_Base_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ffc193e1-04bc-472b-bdc0-3333d1df84e4");
			RealUId = new Guid("ffc193e1-04bc-472b-bdc0-3333d1df84e4");
			Name = "SysCulture_Base_Terrasoft";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("3902b321-877b-464f-a0a9-563b9eec78ed")) == null) {
				Columns.Add(CreateDefaultColumn());
			}
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.IsLocalizable = false;
			column.ModifiedInSchemaUId = new Guid("ffc193e1-04bc-472b-bdc0-3333d1df84e4");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.IsLocalizable = false;
			column.ModifiedInSchemaUId = new Guid("ffc193e1-04bc-472b-bdc0-3333d1df84e4");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected virtual EntitySchemaColumn CreateDefaultColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("3902b321-877b-464f-a0a9-563b9eec78ed"),
				Name = @"Default",
				CreatedInSchemaUId = new Guid("ffc193e1-04bc-472b-bdc0-3333d1df84e4"),
				ModifiedInSchemaUId = new Guid("ffc193e1-04bc-472b-bdc0-3333d1df84e4"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysCulture_Base_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysCulture_Base_TerrasoftEventsProcessSchema() {
			var schema = new SysCulture_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysCulture_Base_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysCulture_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysCulture_Base_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysCulture_Base_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ffc193e1-04bc-472b-bdc0-3333d1df84e4"));
		}

		#endregion

	}

	#endregion

	#region Class: SysCulture_Base_Terrasoft

	/// <summary>
	/// Culture.
	/// </summary>
	public class SysCulture_Base_Terrasoft : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public SysCulture_Base_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysCulture_Base_Terrasoft";
		}

		public SysCulture_Base_Terrasoft(SysCulture_Base_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Use by default.
		/// </summary>
		public bool Default {
			get {
				return GetTypedColumnValue<bool>("Default");
			}
			set {
				SetColumnValue("Default", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysCulture_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysCulture_Base_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("SysCulture_Base_TerrasoftInserting", e);
			Validating += (s, e) => ThrowEvent("SysCulture_Base_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysCulture_Base_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysCulture_BaseEventsProcess

	/// <exclude/>
	public partial class SysCulture_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_BaseEventsProcess<TEntity> where TEntity : SysCulture_Base_Terrasoft
	{

		public SysCulture_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysCulture_BaseEventsProcess";
			SchemaUId = new Guid("ffc193e1-04bc-472b-bdc0-3333d1df84e4");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ffc193e1-04bc-472b-bdc0-3333d1df84e4");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _baseSysCultureInsertedEventSubProcess;
		public ProcessFlowElement BaseSysCultureInsertedEventSubProcess {
			get {
				return _baseSysCultureInsertedEventSubProcess ?? (_baseSysCultureInsertedEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BaseSysCultureInsertedEventSubProcess",
					SchemaElementUId = new Guid("824b56ec-d7d4-4885-8918-51ecb733ede4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseSysCultureInsertedStartMessage;
		public ProcessFlowElement BaseSysCultureInsertedStartMessage {
			get {
				return _baseSysCultureInsertedStartMessage ?? (_baseSysCultureInsertedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseSysCultureInsertedStartMessage",
					SchemaElementUId = new Guid("abcdcb87-f12c-4a61-af41-d9f4e3a2f5f8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _baseSysCultureInsertedScriptTask;
		public ProcessScriptTask BaseSysCultureInsertedScriptTask {
			get {
				return _baseSysCultureInsertedScriptTask ?? (_baseSysCultureInsertedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BaseSysCultureInsertedScriptTask",
					SchemaElementUId = new Guid("daac240d-f629-426b-b93e-f5c627460a2a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = BaseSysCultureInsertedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _baseSysCultureDeletedEventSubProcess;
		public ProcessFlowElement BaseSysCultureDeletedEventSubProcess {
			get {
				return _baseSysCultureDeletedEventSubProcess ?? (_baseSysCultureDeletedEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BaseSysCultureDeletedEventSubProcess",
					SchemaElementUId = new Guid("c0be634c-baec-4865-b04e-d686ca12e984"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseSysCultureDeletedStartMessage;
		public ProcessFlowElement BaseSysCultureDeletedStartMessage {
			get {
				return _baseSysCultureDeletedStartMessage ?? (_baseSysCultureDeletedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseSysCultureDeletedStartMessage",
					SchemaElementUId = new Guid("5a6585ef-3c5c-4947-9572-9c3806722ef0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _baseSysCultureDeletedScriptTask;
		public ProcessScriptTask BaseSysCultureDeletedScriptTask {
			get {
				return _baseSysCultureDeletedScriptTask ?? (_baseSysCultureDeletedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BaseSysCultureDeletedScriptTask",
					SchemaElementUId = new Guid("26b7ec2e-1de7-4c86-84d4-9f3ca3defde5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = BaseSysCultureDeletedScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[BaseSysCultureInsertedEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseSysCultureInsertedEventSubProcess };
			FlowElements[BaseSysCultureInsertedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseSysCultureInsertedStartMessage };
			FlowElements[BaseSysCultureInsertedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseSysCultureInsertedScriptTask };
			FlowElements[BaseSysCultureDeletedEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseSysCultureDeletedEventSubProcess };
			FlowElements[BaseSysCultureDeletedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseSysCultureDeletedStartMessage };
			FlowElements[BaseSysCultureDeletedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseSysCultureDeletedScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "BaseSysCultureInsertedEventSubProcess":
						break;
					case "BaseSysCultureInsertedStartMessage":
						e.Context.QueueTasks.Enqueue("BaseSysCultureInsertedScriptTask");
						break;
					case "BaseSysCultureInsertedScriptTask":
						break;
					case "BaseSysCultureDeletedEventSubProcess":
						break;
					case "BaseSysCultureDeletedStartMessage":
						e.Context.QueueTasks.Enqueue("BaseSysCultureDeletedScriptTask");
						break;
					case "BaseSysCultureDeletedScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("BaseSysCultureInsertedStartMessage");
			ActivatedEventElements.Add("BaseSysCultureDeletedStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "BaseSysCultureInsertedEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "BaseSysCultureInsertedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseSysCultureInsertedStartMessage";
					result = BaseSysCultureInsertedStartMessage.Execute(context);
					break;
				case "BaseSysCultureInsertedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseSysCultureInsertedScriptTask";
					result = BaseSysCultureInsertedScriptTask.Execute(context, BaseSysCultureInsertedScriptTaskExecute);
					break;
				case "BaseSysCultureDeletedEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "BaseSysCultureDeletedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseSysCultureDeletedStartMessage";
					result = BaseSysCultureDeletedStartMessage.Execute(context);
					break;
				case "BaseSysCultureDeletedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseSysCultureDeletedScriptTask";
					result = BaseSysCultureDeletedScriptTask.Execute(context, BaseSysCultureDeletedScriptTaskExecute);
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

		public virtual bool BaseSysCultureInsertedScriptTaskExecute(ProcessExecutingContext context) {
			return OnBaseSysCultureInserted();
		}

		public virtual bool BaseSysCultureDeletedScriptTaskExecute(ProcessExecutingContext context) {
			return OnBaseSysCultureDeleted();
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "SysCultureInserted":
							if (ActivatedEventElements.Contains("BaseSysCultureInsertedStartMessage")) {
							context.QueueTasks.Enqueue("BaseSysCultureInsertedStartMessage");
						}
						break;
					case "SysCulture_Base_TerrasoftDeleted":
							if (ActivatedEventElements.Contains("BaseSysCultureDeletedStartMessage")) {
							context.QueueTasks.Enqueue("BaseSysCultureDeletedStartMessage");
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

	#region Class: SysCulture_BaseEventsProcess

	/// <exclude/>
	public class SysCulture_BaseEventsProcess : SysCulture_BaseEventsProcess<SysCulture_Base_Terrasoft>
	{

		public SysCulture_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysCulture_BaseEventsProcess

	public partial class SysCulture_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual bool OnBaseSysCultureInserted() {
			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(Entity.Name);
			GeneralResourceStorage.AddCultureInfo(cultureInfo);
			return true;
		}

		public virtual bool OnBaseSysCultureDeleted() {
			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(Entity.Name);
			GeneralResourceStorage.RemoveCultureInfo(cultureInfo);
			return true;
		}

		#endregion

	}

	#endregion

	#region Class: SysCulture_Base_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class SysCulture_Base_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseLookupEventsProcessSchema
	{

		#region Constructors: Public

		public SysCulture_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysCulture_Base_TerrasoftEventsProcessSchema(SysCulture_Base_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysCulture_BaseEventsProcess";
			UId = new Guid("9120874f-9119-46bd-a369-7cdc81389313");
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
			ProcessSchemaLaneSet schemaBaseSysCultureLaneSet = CreateBaseSysCultureLaneSetLaneSet();
			LaneSets.Add(schemaBaseSysCultureLaneSet);
			ProcessSchemaLane schemaBaseSysCultureLane = CreateBaseSysCultureLaneLane();
			schemaBaseSysCultureLaneSet.Lanes.Add(schemaBaseSysCultureLane);
			ProcessSchemaEventSubProcess basesyscultureinsertedeventsubprocess = CreateBaseSysCultureInsertedEventSubProcessEventSubProcess();
			FlowElements.Add(basesyscultureinsertedeventsubprocess);
			ProcessSchemaEventSubProcess basesysculturedeletedeventsubprocess = CreateBaseSysCultureDeletedEventSubProcessEventSubProcess();
			FlowElements.Add(basesysculturedeletedeventsubprocess);
			ProcessSchemaStartMessageEvent basesyscultureinsertedstartmessage = CreateBaseSysCultureInsertedStartMessageStartMessageEvent();
			basesyscultureinsertedeventsubprocess.FlowElements.Add(basesyscultureinsertedstartmessage);
			ProcessSchemaScriptTask basesyscultureinsertedscripttask = CreateBaseSysCultureInsertedScriptTaskScriptTask();
			basesyscultureinsertedeventsubprocess.FlowElements.Add(basesyscultureinsertedscripttask);
			ProcessSchemaStartMessageEvent basesysculturedeletedstartmessage = CreateBaseSysCultureDeletedStartMessageStartMessageEvent();
			basesysculturedeletedeventsubprocess.FlowElements.Add(basesysculturedeletedstartmessage);
			ProcessSchemaScriptTask basesysculturedeletedscripttask = CreateBaseSysCultureDeletedScriptTaskScriptTask();
			basesysculturedeletedeventsubprocess.FlowElements.Add(basesysculturedeletedscripttask);
			FlowElements.Add(CreateInsertEventSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateDeleteEventSequenceFlow1SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateInsertEventSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "InsertEventSequenceFlow1",
				UId = new Guid("eeec1bc7-849b-4b72-9b79-9564c9833865"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("abcdcb87-f12c-4a61-af41-d9f4e3a2f5f8"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("daac240d-f629-426b-b93e-f5c627460a2a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDeleteEventSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "DeleteEventSequenceFlow1",
				UId = new Guid("e719c2ed-6b2e-449d-bc12-747947825948"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5a6585ef-3c5c-4947-9572-9c3806722ef0"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("26b7ec2e-1de7-4c86-84d4-9f3ca3defde5"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateBaseSysCultureLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaBaseSysCultureLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("07c34ca5-b1a2-46c5-a792-69c6bb735449"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				Name = @"BaseSysCultureLaneSet",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaBaseSysCultureLaneSet;
		}

		protected virtual ProcessSchemaLane CreateBaseSysCultureLaneLane() {
			ProcessSchemaLane schemaBaseSysCultureLane = new ProcessSchemaLane(this) {
				UId = new Guid("ef400e73-6211-4c28-8ca3-4ea13fdc8997"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("07c34ca5-b1a2-46c5-a792-69c6bb735449"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				Name = @"BaseSysCultureLane",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaBaseSysCultureLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateBaseSysCultureInsertedEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaBaseSysCultureInsertedEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("824b56ec-d7d4-4885-8918-51ecb733ede4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ef400e73-6211-4c28-8ca3-4ea13fdc8997"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				Name = @"BaseSysCultureInsertedEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(80, 160),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(260, 120),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaBaseSysCultureInsertedEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBaseSysCultureInsertedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("abcdcb87-f12c-4a61-af41-d9f4e3a2f5f8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("824b56ec-d7d4-4885-8918-51ecb733ede4"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysCultureInserted",
				ModifiedInSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				Name = @"BaseSysCultureInsertedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(33, 40),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateBaseSysCultureInsertedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("daac240d-f629-426b-b93e-f5c627460a2a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("824b56ec-d7d4-4885-8918-51ecb733ede4"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				Name = @"BaseSysCultureInsertedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(140, 26),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,240,207,115,74,44,78,13,174,44,118,46,205,1,10,164,122,230,21,167,22,149,164,166,104,104,90,3,0,1,118,234,148,34,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateBaseSysCultureDeletedEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaBaseSysCultureDeletedEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c0be634c-baec-4865-b04e-d686ca12e984"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ef400e73-6211-4c28-8ca3-4ea13fdc8997"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				Name = @"BaseSysCultureDeletedEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(79, 321),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(261, 122),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaBaseSysCultureDeletedEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBaseSysCultureDeletedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5a6585ef-3c5c-4947-9572-9c3806722ef0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c0be634c-baec-4865-b04e-d686ca12e984"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysCultureDeleted",
				ModifiedInSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				Name = @"BaseSysCultureDeletedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(34, 46),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateBaseSysCultureDeletedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("26b7ec2e-1de7-4c86-84d4-9f3ca3defde5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c0be634c-baec-4865-b04e-d686ca12e984"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				Name = @"BaseSysCultureDeletedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(141, 32),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,240,207,115,74,44,78,13,174,44,118,46,205,1,10,164,186,164,230,164,150,164,166,104,104,90,3,0,153,205,80,243,33,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateOnBaseSysCultureInsertedMethod());
			Methods.Add(CreateOnBaseSysCultureDeletedMethod());
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

		protected virtual SchemaMethod CreateOnBaseSysCultureInsertedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("aa17ca36-3553-4224-88ec-f5bbce6ca720"),
				Name = "OnBaseSysCultureInserted",
				CreatedInSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,46,205,41,41,45,74,245,204,75,203,87,72,70,98,219,42,56,35,120,122,238,169,37,72,92,13,215,188,146,204,146,74,61,191,196,220,84,77,107,46,247,212,188,212,162,196,156,160,212,226,252,210,162,228,212,224,146,252,162,196,244,84,61,199,148,20,100,61,72,134,3,245,20,165,2,57,121,10,37,69,165,169,214,0,25,38,227,107,131,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnBaseSysCultureDeletedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3610a625-0e2a-43da-955f-0b2f1df00d13"),
				Name = "OnBaseSysCultureDeleted",
				CreatedInSchemaUId = new Guid("9120874f-9119-46bd-a369-7cdc81389313"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,46,205,41,41,45,74,245,204,75,203,87,72,70,98,219,42,56,35,120,122,238,169,37,72,92,13,215,188,146,204,146,74,61,191,196,220,84,77,107,46,247,212,188,212,162,196,156,160,212,226,252,210,162,228,212,224,146,252,162,196,244,84,189,160,212,220,252,178,84,100,109,72,230,3,181,21,165,2,57,121,10,37,69,165,169,214,0,131,158,14,226,134,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysCulture_Base_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9120874f-9119-46bd-a369-7cdc81389313"));
		}

		#endregion

	}

	#endregion

}

