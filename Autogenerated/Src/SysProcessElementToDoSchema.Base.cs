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
	using Terrasoft.Messaging.Common;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: SysProcessElementToDo_Base_TerrasoftSchema

	/// <exclude/>
	public class SysProcessElementToDo_Base_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysProcessElementToDo_Base_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysProcessElementToDo_Base_TerrasoftSchema(SysProcessElementToDo_Base_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysProcessElementToDo_Base_TerrasoftSchema(SysProcessElementToDo_Base_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f5db809d-0f72-40a7-8da9-be06543b7f7f");
			RealUId = new Guid("f5db809d-0f72-40a7-8da9-be06543b7f7f");
			Name = "SysProcessElementToDo_Base_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateTitleColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("08acb43d-deb4-44d4-9714-40fc991d49dc")) == null) {
				Columns.Add(CreateStartDateColumn());
			}
			if (Columns.FindByUId(new Guid("aecb7163-c838-411e-9579-455d3812e272")) == null) {
				Columns.Add(CreateSubjectColumn());
			}
			if (Columns.FindByUId(new Guid("6e1028c8-0dc6-4010-b031-ff443b851647")) == null) {
				Columns.Add(CreateContactIdColumn());
			}
			if (Columns.FindByUId(new Guid("a517ac73-8690-47d1-b71c-e8be90cb8718")) == null) {
				Columns.Add(CreateSysProcessDataIdColumn());
			}
			if (Columns.FindByUId(new Guid("6c8eb8fe-74ad-4068-b11a-1722514c567e")) == null) {
				Columns.Add(CreateManagerNameColumn());
			}
			if (Columns.FindByUId(new Guid("626da9c9-8a55-455f-bfa7-34f89b9a01ed")) == null) {
				Columns.Add(CreateProcessSchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("eeb021c6-6754-4dbd-81a3-385b510282dd")) == null) {
				Columns.Add(CreateElementSchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("8c5caca1-d0a5-4af4-b6d3-a827d758fb7e")) == null) {
				Columns.Add(CreateExecutionDataColumn());
			}
			if (Columns.FindByUId(new Guid("d6a90766-6ed8-4474-b36e-9b2b0ad80a67")) == null) {
				Columns.Add(CreateExtraDataColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateStartDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("08acb43d-deb4-44d4-9714-40fc991d49dc"),
				Name = @"StartDate",
				CreatedInSchemaUId = new Guid("f5db809d-0f72-40a7-8da9-be06543b7f7f"),
				ModifiedInSchemaUId = new Guid("f5db809d-0f72-40a7-8da9-be06543b7f7f"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateTitleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("871be83f-6efe-49c0-92a6-06133069a602"),
				Name = @"Title",
				CreatedInSchemaUId = new Guid("f5db809d-0f72-40a7-8da9-be06543b7f7f"),
				ModifiedInSchemaUId = new Guid("f5db809d-0f72-40a7-8da9-be06543b7f7f"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateSubjectColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("aecb7163-c838-411e-9579-455d3812e272"),
				Name = @"Subject",
				CreatedInSchemaUId = new Guid("f5db809d-0f72-40a7-8da9-be06543b7f7f"),
				ModifiedInSchemaUId = new Guid("f5db809d-0f72-40a7-8da9-be06543b7f7f"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateContactIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("6e1028c8-0dc6-4010-b031-ff443b851647"),
				Name = @"ContactId",
				IsWeakReference = true,
				CreatedInSchemaUId = new Guid("f5db809d-0f72-40a7-8da9-be06543b7f7f"),
				ModifiedInSchemaUId = new Guid("f5db809d-0f72-40a7-8da9-be06543b7f7f"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateSysProcessDataIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("a517ac73-8690-47d1-b71c-e8be90cb8718"),
				Name = @"SysProcessDataId",
				IsIndexed = true,
				IsWeakReference = true,
				CreatedInSchemaUId = new Guid("f5db809d-0f72-40a7-8da9-be06543b7f7f"),
				ModifiedInSchemaUId = new Guid("f5db809d-0f72-40a7-8da9-be06543b7f7f"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateManagerNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("6c8eb8fe-74ad-4068-b11a-1722514c567e"),
				Name = @"ManagerName",
				CreatedInSchemaUId = new Guid("f5db809d-0f72-40a7-8da9-be06543b7f7f"),
				ModifiedInSchemaUId = new Guid("f5db809d-0f72-40a7-8da9-be06543b7f7f"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateProcessSchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("626da9c9-8a55-455f-bfa7-34f89b9a01ed"),
				Name = @"ProcessSchemaUId",
				CreatedInSchemaUId = new Guid("f5db809d-0f72-40a7-8da9-be06543b7f7f"),
				ModifiedInSchemaUId = new Guid("f5db809d-0f72-40a7-8da9-be06543b7f7f"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateElementSchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("eeb021c6-6754-4dbd-81a3-385b510282dd"),
				Name = @"ElementSchemaUId",
				CreatedInSchemaUId = new Guid("f5db809d-0f72-40a7-8da9-be06543b7f7f"),
				ModifiedInSchemaUId = new Guid("f5db809d-0f72-40a7-8da9-be06543b7f7f"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateExecutionDataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Binary")) {
				UId = new Guid("8c5caca1-d0a5-4af4-b6d3-a827d758fb7e"),
				Name = @"ExecutionData",
				CreatedInSchemaUId = new Guid("f5db809d-0f72-40a7-8da9-be06543b7f7f"),
				ModifiedInSchemaUId = new Guid("f5db809d-0f72-40a7-8da9-be06543b7f7f"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateExtraDataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Binary")) {
				UId = new Guid("d6a90766-6ed8-4474-b36e-9b2b0ad80a67"),
				Name = @"ExtraData",
				CreatedInSchemaUId = new Guid("f5db809d-0f72-40a7-8da9-be06543b7f7f"),
				ModifiedInSchemaUId = new Guid("f5db809d-0f72-40a7-8da9-be06543b7f7f"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysProcessElementToDo_Base_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysProcessElementToDo_Base_TerrasoftEventsProcessSchema() {
			var schema = new SysProcessElementToDo_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysProcessElementToDo_Base_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysProcessElementToDo_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysProcessElementToDo_Base_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysProcessElementToDo_Base_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f5db809d-0f72-40a7-8da9-be06543b7f7f"));
		}

		#endregion

	}

	#endregion

	#region Class: SysProcessElementToDo_Base_Terrasoft

	/// <summary>
	/// Process element to do list.
	/// </summary>
	public class SysProcessElementToDo_Base_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysProcessElementToDo_Base_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysProcessElementToDo_Base_Terrasoft";
		}

		public SysProcessElementToDo_Base_Terrasoft(SysProcessElementToDo_Base_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Start date time.
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
		/// Title.
		/// </summary>
		public string Title {
			get {
				return GetTypedColumnValue<string>("Title");
			}
			set {
				SetColumnValue("Title", value);
			}
		}

		/// <summary>
		/// Subject.
		/// </summary>
		public string Subject {
			get {
				return GetTypedColumnValue<string>("Subject");
			}
			set {
				SetColumnValue("Subject", value);
			}
		}

		/// <summary>
		/// Owner.
		/// </summary>
		public Guid ContactId {
			get {
				return GetTypedColumnValue<Guid>("ContactId");
			}
			set {
				SetColumnValue("ContactId", value);
			}
		}

		/// <summary>
		/// Process identifier.
		/// </summary>
		public Guid SysProcessDataId {
			get {
				return GetTypedColumnValue<Guid>("SysProcessDataId");
			}
			set {
				SetColumnValue("SysProcessDataId", value);
			}
		}

		/// <summary>
		/// Name of the process schema manager.
		/// </summary>
		public string ManagerName {
			get {
				return GetTypedColumnValue<string>("ManagerName");
			}
			set {
				SetColumnValue("ManagerName", value);
			}
		}

		/// <summary>
		/// Process schema identifier.
		/// </summary>
		public Guid ProcessSchemaUId {
			get {
				return GetTypedColumnValue<Guid>("ProcessSchemaUId");
			}
			set {
				SetColumnValue("ProcessSchemaUId", value);
			}
		}

		/// <summary>
		/// Schema element identifier.
		/// </summary>
		public Guid ElementSchemaUId {
			get {
				return GetTypedColumnValue<Guid>("ElementSchemaUId");
			}
			set {
				SetColumnValue("ElementSchemaUId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysProcessElementToDo_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysProcessElementToDo_Base_TerrasoftDeleted", e);
			Saved += (s, e) => ThrowEvent("SysProcessElementToDo_Base_TerrasoftSaved", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysProcessElementToDo_Base_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysProcessElementToDo_BaseEventsProcess

	/// <exclude/>
	public partial class SysProcessElementToDo_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysProcessElementToDo_Base_Terrasoft
	{

		public SysProcessElementToDo_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysProcessElementToDo_BaseEventsProcess";
			SchemaUId = new Guid("f5db809d-0f72-40a7-8da9-be06543b7f7f");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f5db809d-0f72-40a7-8da9-be06543b7f7f");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess3_cee56a73788d4eb68d264de83705130c;
		public ProcessFlowElement EventSubProcess3_cee56a73788d4eb68d264de83705130c {
			get {
				return _eventSubProcess3_cee56a73788d4eb68d264de83705130c ?? (_eventSubProcess3_cee56a73788d4eb68d264de83705130c = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3_cee56a73788d4eb68d264de83705130c",
					SchemaElementUId = new Guid("cee56a73-788d-4eb6-8d26-4de83705130c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3_782069d78f1e403c8a7b8c25068580d7;
		public ProcessFlowElement StartMessage3_782069d78f1e403c8a7b8c25068580d7 {
			get {
				return _startMessage3_782069d78f1e403c8a7b8c25068580d7 ?? (_startMessage3_782069d78f1e403c8a7b8c25068580d7 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3_782069d78f1e403c8a7b8c25068580d7",
					SchemaElementUId = new Guid("782069d7-8f1e-403c-8a7b-8c25068580d7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage4_b3d71a46a5ac4a288dc63cbf63c8ab81;
		public ProcessFlowElement StartMessage4_b3d71a46a5ac4a288dc63cbf63c8ab81 {
			get {
				return _startMessage4_b3d71a46a5ac4a288dc63cbf63c8ab81 ?? (_startMessage4_b3d71a46a5ac4a288dc63cbf63c8ab81 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage4_b3d71a46a5ac4a288dc63cbf63c8ab81",
					SchemaElementUId = new Guid("b3d71a46-a5ac-4a28-8dc6-3cbf63c8ab81"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask4_48e990ae7714474191aa80d7e28c106e;
		public ProcessScriptTask ScriptTask4_48e990ae7714474191aa80d7e28c106e {
			get {
				return _scriptTask4_48e990ae7714474191aa80d7e28c106e ?? (_scriptTask4_48e990ae7714474191aa80d7e28c106e = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask4_48e990ae7714474191aa80d7e28c106e",
					SchemaElementUId = new Guid("48e990ae-7714-4741-91aa-80d7e28c106e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask4_48e990ae7714474191aa80d7e28c106eExecute,
				});
			}
		}

		private ProcessScriptTask _scriptTask3_a03b8f8d03804e34a25db612dd08a835;
		public ProcessScriptTask ScriptTask3_a03b8f8d03804e34a25db612dd08a835 {
			get {
				return _scriptTask3_a03b8f8d03804e34a25db612dd08a835 ?? (_scriptTask3_a03b8f8d03804e34a25db612dd08a835 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3_a03b8f8d03804e34a25db612dd08a835",
					SchemaElementUId = new Guid("a03b8f8d-0380-4e34-a25d-b612dd08a835"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3_a03b8f8d03804e34a25db612dd08a835Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess3_cee56a73788d4eb68d264de83705130c.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3_cee56a73788d4eb68d264de83705130c };
			FlowElements[StartMessage3_782069d78f1e403c8a7b8c25068580d7.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3_782069d78f1e403c8a7b8c25068580d7 };
			FlowElements[StartMessage4_b3d71a46a5ac4a288dc63cbf63c8ab81.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage4_b3d71a46a5ac4a288dc63cbf63c8ab81 };
			FlowElements[ScriptTask4_48e990ae7714474191aa80d7e28c106e.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask4_48e990ae7714474191aa80d7e28c106e };
			FlowElements[ScriptTask3_a03b8f8d03804e34a25db612dd08a835.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3_a03b8f8d03804e34a25db612dd08a835 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess3_cee56a73788d4eb68d264de83705130c":
						break;
					case "StartMessage3_782069d78f1e403c8a7b8c25068580d7":
						e.Context.QueueTasks.Enqueue("ScriptTask3_a03b8f8d03804e34a25db612dd08a835");
						break;
					case "StartMessage4_b3d71a46a5ac4a288dc63cbf63c8ab81":
						e.Context.QueueTasks.Enqueue("ScriptTask4_48e990ae7714474191aa80d7e28c106e");
						break;
					case "ScriptTask4_48e990ae7714474191aa80d7e28c106e":
						break;
					case "ScriptTask3_a03b8f8d03804e34a25db612dd08a835":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage3_782069d78f1e403c8a7b8c25068580d7");
			ActivatedEventElements.Add("StartMessage4_b3d71a46a5ac4a288dc63cbf63c8ab81");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess3_cee56a73788d4eb68d264de83705130c":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3_782069d78f1e403c8a7b8c25068580d7":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3_782069d78f1e403c8a7b8c25068580d7";
					result = StartMessage3_782069d78f1e403c8a7b8c25068580d7.Execute(context);
					break;
				case "StartMessage4_b3d71a46a5ac4a288dc63cbf63c8ab81":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage4_b3d71a46a5ac4a288dc63cbf63c8ab81";
					result = StartMessage4_b3d71a46a5ac4a288dc63cbf63c8ab81.Execute(context);
					break;
				case "ScriptTask4_48e990ae7714474191aa80d7e28c106e":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask4_48e990ae7714474191aa80d7e28c106e";
					result = ScriptTask4_48e990ae7714474191aa80d7e28c106e.Execute(context, ScriptTask4_48e990ae7714474191aa80d7e28c106eExecute);
					break;
				case "ScriptTask3_a03b8f8d03804e34a25db612dd08a835":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3_a03b8f8d03804e34a25db612dd08a835";
					result = ScriptTask3_a03b8f8d03804e34a25db612dd08a835.Execute(context, ScriptTask3_a03b8f8d03804e34a25db612dd08a835Execute);
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

		public virtual bool ScriptTask4_48e990ae7714474191aa80d7e28c106eExecute(ProcessExecutingContext context) {
			PostMessage("delete");
			return true;
		}

		public virtual bool ScriptTask3_a03b8f8d03804e34a25db612dd08a835Execute(ProcessExecutingContext context) {
			PostMessage("update");
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "SysProcessElementToDo_Base_TerrasoftSaved":
							if (ActivatedEventElements.Contains("StartMessage3_782069d78f1e403c8a7b8c25068580d7")) {
							context.QueueTasks.Enqueue("StartMessage3_782069d78f1e403c8a7b8c25068580d7");
						}
						break;
					case "SysProcessElementToDo_Base_TerrasoftDeleted":
							if (ActivatedEventElements.Contains("StartMessage4_b3d71a46a5ac4a288dc63cbf63c8ab81")) {
							context.QueueTasks.Enqueue("StartMessage4_b3d71a46a5ac4a288dc63cbf63c8ab81");
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

	#region Class: SysProcessElementToDo_BaseEventsProcess

	/// <exclude/>
	public class SysProcessElementToDo_BaseEventsProcess : SysProcessElementToDo_BaseEventsProcess<SysProcessElementToDo_Base_Terrasoft>
	{

		public SysProcessElementToDo_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysProcessElementToDo_BaseEventsProcess

	public partial class SysProcessElementToDo_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void PostMessage(string operation) {
			INotificationMessageBuilder messageBuilder = new SimpleNotificationMessageBuilder {
				Id = Entity.Id,
				Sender = "ProcessDashboard",
				Operation = operation
			};
			var messageChannel = new NotificationMessageChannel(UserConnection, MsgChannelManager.Instance);
			messageChannel.PostMessage(Entity.ContactId, messageBuilder);
		}

		#endregion

	}

	#endregion

	#region Class: SysProcessElementToDo_Base_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class SysProcessElementToDo_Base_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysProcessElementToDo_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysProcessElementToDo_Base_TerrasoftEventsProcessSchema(SysProcessElementToDo_Base_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysProcessElementToDo_BaseEventsProcess";
			UId = new Guid("23503df0-7518-4411-8dd1-a95283df1158");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
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
			ProcessSchemaLaneSet schemaLaneSet2_65f9df726df54a8ea4533a380d4bbc3e = CreateLaneSet2_65f9df726df54a8ea4533a380d4bbc3eLaneSet();
			LaneSets.Add(schemaLaneSet2_65f9df726df54a8ea4533a380d4bbc3e);
			ProcessSchemaLane schemaLane1_7620e97670e44e1f8840fd5e324d08aa = CreateLane1_7620e97670e44e1f8840fd5e324d08aaLane();
			schemaLaneSet2_65f9df726df54a8ea4533a380d4bbc3e.Lanes.Add(schemaLane1_7620e97670e44e1f8840fd5e324d08aa);
			ProcessSchemaEventSubProcess eventsubprocess3_cee56a73788d4eb68d264de83705130c = CreateEventSubProcess3_cee56a73788d4eb68d264de83705130cEventSubProcess();
			FlowElements.Add(eventsubprocess3_cee56a73788d4eb68d264de83705130c);
			ProcessSchemaStartMessageEvent startmessage3_782069d78f1e403c8a7b8c25068580d7 = CreateStartMessage3_782069d78f1e403c8a7b8c25068580d7StartMessageEvent();
			eventsubprocess3_cee56a73788d4eb68d264de83705130c.FlowElements.Add(startmessage3_782069d78f1e403c8a7b8c25068580d7);
			ProcessSchemaStartMessageEvent startmessage4_b3d71a46a5ac4a288dc63cbf63c8ab81 = CreateStartMessage4_b3d71a46a5ac4a288dc63cbf63c8ab81StartMessageEvent();
			eventsubprocess3_cee56a73788d4eb68d264de83705130c.FlowElements.Add(startmessage4_b3d71a46a5ac4a288dc63cbf63c8ab81);
			ProcessSchemaScriptTask scripttask4_48e990ae7714474191aa80d7e28c106e = CreateScriptTask4_48e990ae7714474191aa80d7e28c106eScriptTask();
			eventsubprocess3_cee56a73788d4eb68d264de83705130c.FlowElements.Add(scripttask4_48e990ae7714474191aa80d7e28c106e);
			ProcessSchemaScriptTask scripttask3_a03b8f8d03804e34a25db612dd08a835 = CreateScriptTask3_a03b8f8d03804e34a25db612dd08a835ScriptTask();
			eventsubprocess3_cee56a73788d4eb68d264de83705130c.FlowElements.Add(scripttask3_a03b8f8d03804e34a25db612dd08a835);
			FlowElements.Add(CreateSequenceFlow2_5d9fc37a0e5e4a799221bf7d1e332d2fSequenceFlow());
			FlowElements.Add(CreateSequenceFlow3_48d6de8e316a4037a7aa9c05105d0599SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2_5d9fc37a0e5e4a799221bf7d1e332d2fSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2_5d9fc37a0e5e4a799221bf7d1e332d2f",
				UId = new Guid("5d9fc37a-0e5e-4a79-9221-bf7d1e332d2f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("23503df0-7518-4411-8dd1-a95283df1158"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("23503df0-7518-4411-8dd1-a95283df1158"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b3d71a46-a5ac-4a28-8dc6-3cbf63c8ab81"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("48e990ae-7714-4741-91aa-80d7e28c106e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3_48d6de8e316a4037a7aa9c05105d0599SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3_48d6de8e316a4037a7aa9c05105d0599",
				UId = new Guid("48d6de8e-316a-4037-a7aa-9c05105d0599"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("23503df0-7518-4411-8dd1-a95283df1158"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("23503df0-7518-4411-8dd1-a95283df1158"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("782069d7-8f1e-403c-8a7b-8c25068580d7"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a03b8f8d-0380-4e34-a25d-b612dd08a835"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet2_65f9df726df54a8ea4533a380d4bbc3eLaneSet() {
			ProcessSchemaLaneSet schemaLaneSet2_65f9df726df54a8ea4533a380d4bbc3e = new ProcessSchemaLaneSet(this) {
				UId = new Guid("65f9df72-6df5-4a8e-a453-3a380d4bbc3e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("23503df0-7518-4411-8dd1-a95283df1158"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("23503df0-7518-4411-8dd1-a95283df1158"),
				Name = @"LaneSet2_65f9df726df54a8ea4533a380d4bbc3e",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet2_65f9df726df54a8ea4533a380d4bbc3e;
		}

		protected virtual ProcessSchemaLane CreateLane1_7620e97670e44e1f8840fd5e324d08aaLane() {
			ProcessSchemaLane schemaLane1_7620e97670e44e1f8840fd5e324d08aa = new ProcessSchemaLane(this) {
				UId = new Guid("7620e976-70e4-4e1f-8840-fd5e324d08aa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65f9df72-6df5-4a8e-a453-3a380d4bbc3e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("23503df0-7518-4411-8dd1-a95283df1158"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("23503df0-7518-4411-8dd1-a95283df1158"),
				Name = @"Lane1_7620e97670e44e1f8840fd5e324d08aa",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1_7620e97670e44e1f8840fd5e324d08aa;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3_cee56a73788d4eb68d264de83705130cEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3_cee56a73788d4eb68d264de83705130c = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("cee56a73-788d-4eb6-8d26-4de83705130c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7620e976-70e4-4e1f-8840-fd5e324d08aa"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("23503df0-7518-4411-8dd1-a95283df1158"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("23503df0-7518-4411-8dd1-a95283df1158"),
				Name = @"EventSubProcess3_cee56a73788d4eb68d264de83705130c",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 20),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(340, 300),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3_cee56a73788d4eb68d264de83705130c;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage3_782069d78f1e403c8a7b8c25068580d7StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("782069d7-8f1e-403c-8a7b-8c25068580d7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cee56a73-788d-4eb6-8d26-4de83705130c"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("23503df0-7518-4411-8dd1-a95283df1158"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysProcessElementToDoSaved",
				ModifiedInSchemaUId = new Guid("23503df0-7518-4411-8dd1-a95283df1158"),
				Name = @"StartMessage3_782069d78f1e403c8a7b8c25068580d7",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(60, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage4_b3d71a46a5ac4a288dc63cbf63c8ab81StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b3d71a46-a5ac-4a28-8dc6-3cbf63c8ab81"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cee56a73-788d-4eb6-8d26-4de83705130c"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("23503df0-7518-4411-8dd1-a95283df1158"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysProcessElementToDoDeleted",
				ModifiedInSchemaUId = new Guid("23503df0-7518-4411-8dd1-a95283df1158"),
				Name = @"StartMessage4_b3d71a46a5ac4a288dc63cbf63c8ab81",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(60, 197),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask4_48e990ae7714474191aa80d7e28c106eScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("48e990ae-7714-4741-91aa-80d7e28c106e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cee56a73-788d-4eb6-8d26-4de83705130c"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("23503df0-7518-4411-8dd1-a95283df1158"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("23503df0-7518-4411-8dd1-a95283df1158"),
				Name = @"ScriptTask4_48e990ae7714474191aa80d7e28c106e",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(176, 183),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,200,47,46,241,77,45,46,78,76,79,213,80,74,73,205,73,45,73,85,210,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,32,88,166,33,36,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask3_a03b8f8d03804e34a25db612dd08a835ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a03b8f8d-0380-4e34-a25d-b612dd08a835"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cee56a73-788d-4eb6-8d26-4de83705130c"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("23503df0-7518-4411-8dd1-a95283df1158"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("23503df0-7518-4411-8dd1-a95283df1158"),
				Name = @"ScriptTask3_a03b8f8d03804e34a25db612dd08a835",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(176, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,200,47,46,241,77,45,46,78,76,79,213,80,42,45,72,73,44,73,85,210,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,22,107,198,50,36,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreatePostMessageMethod());
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
				UId = new Guid("bf01f4b3-f3cb-412c-ac8c-035bfe67aef7"),
				Name = "Terrasoft.Messaging.Common",
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

		protected virtual SchemaMethod CreatePostMessageMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("995a8f79-644b-4e8f-aabb-986629226373"),
				Name = "PostMessage",
				CreatedInSchemaUId = new Guid("23503df0-7518-4411-8dd1-a95283df1158"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a418e953-92d7-4b21-a8be-cd7639ea314a"),
				Name = "operation",
				CreatedInSchemaUId = new Guid("23503df0-7518-4411-8dd1-a95283df1158"),
				ModifiedInSchemaUId = new Guid("23503df0-7518-4411-8dd1-a95283df1158"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,65,10,194,48,16,69,215,205,41,66,87,45,148,94,160,184,177,186,232,162,90,40,30,96,76,198,54,208,78,74,18,21,17,239,110,212,40,84,196,221,132,255,242,242,39,213,70,59,117,80,2,156,210,84,163,181,208,225,242,168,6,137,134,143,243,227,130,19,158,121,171,198,105,192,63,183,174,44,170,164,135,215,228,148,187,228,149,204,88,212,34,189,12,113,99,180,240,252,10,108,191,215,96,100,236,211,237,132,230,105,242,128,126,207,236,86,176,19,124,74,148,61,16,225,16,74,252,120,62,0,201,206,162,41,181,31,197,35,204,120,109,187,16,213,64,158,51,121,69,214,1,9,76,11,54,151,231,141,182,46,232,146,80,223,171,28,8,231,183,248,250,142,180,184,3,67,13,204,163,59,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysProcessElementToDo_Base_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("23503df0-7518-4411-8dd1-a95283df1158"));
		}

		#endregion

	}

	#endregion

}

