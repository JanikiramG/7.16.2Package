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

	#region Class: SysAdminUnitGrantedRightSchema

	/// <exclude/>
	public class SysAdminUnitGrantedRightSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysAdminUnitGrantedRightSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysAdminUnitGrantedRightSchema(SysAdminUnitGrantedRightSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysAdminUnitGrantedRightSchema(SysAdminUnitGrantedRightSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7273d66e-49ea-43e9-92ea-20f3d542407c");
			RealUId = new Guid("7273d66e-49ea-43e9-92ea-20f3d542407c");
			Name = "SysAdminUnitGrantedRight";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("8a2e796c-7ed7-4544-a9bc-4a3149183f3e")) == null) {
				Columns.Add(CreateGrantorSysAdminUnitColumn());
			}
			if (Columns.FindByUId(new Guid("5290e2da-05d6-49e7-b839-9b098bf6b15e")) == null) {
				Columns.Add(CreateGranteeSysAdminUnitColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateGrantorSysAdminUnitColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8a2e796c-7ed7-4544-a9bc-4a3149183f3e"),
				Name = @"GrantorSysAdminUnit",
				ReferenceSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsWeakReference = true,
				CreatedInSchemaUId = new Guid("7273d66e-49ea-43e9-92ea-20f3d542407c"),
				ModifiedInSchemaUId = new Guid("7273d66e-49ea-43e9-92ea-20f3d542407c"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected virtual EntitySchemaColumn CreateGranteeSysAdminUnitColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("5290e2da-05d6-49e7-b839-9b098bf6b15e"),
				Name = @"GranteeSysAdminUnit",
				ReferenceSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsWeakReference = true,
				CreatedInSchemaUId = new Guid("7273d66e-49ea-43e9-92ea-20f3d542407c"),
				ModifiedInSchemaUId = new Guid("7273d66e-49ea-43e9-92ea-20f3d542407c"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysAdminUnitGrantedRightEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysAdminUnitGrantedRightEventsProcessSchema() {
			var schema = new SysAdminUnitGrantedRightEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysAdminUnitGrantedRight(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysAdminUnitGrantedRight_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysAdminUnitGrantedRightSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysAdminUnitGrantedRightSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7273d66e-49ea-43e9-92ea-20f3d542407c"));
		}

		#endregion

	}

	#endregion

	#region Class: SysAdminUnitGrantedRight

	/// <summary>
	/// Additionally inherited permissions.
	/// </summary>
	public class SysAdminUnitGrantedRight : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysAdminUnitGrantedRight(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysAdminUnitGrantedRight";
		}

		public SysAdminUnitGrantedRight(SysAdminUnitGrantedRight source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid GrantorSysAdminUnitId {
			get {
				return GetTypedColumnValue<Guid>("GrantorSysAdminUnitId");
			}
			set {
				SetColumnValue("GrantorSysAdminUnitId", value);
				_grantorSysAdminUnit = null;
			}
		}

		/// <exclude/>
		public string GrantorSysAdminUnitName {
			get {
				return GetTypedColumnValue<string>("GrantorSysAdminUnitName");
			}
			set {
				SetColumnValue("GrantorSysAdminUnitName", value);
				if (_grantorSysAdminUnit != null) {
					_grantorSysAdminUnit.Name = value;
				}
			}
		}

		private VwSysAdminUnit _grantorSysAdminUnit;
		/// <summary>
		/// Who grants permissions.
		/// </summary>
		public VwSysAdminUnit GrantorSysAdminUnit {
			get {
				return _grantorSysAdminUnit ??
					(_grantorSysAdminUnit = LookupColumnEntities.GetEntity("GrantorSysAdminUnit") as VwSysAdminUnit);
			}
		}

		/// <exclude/>
		public Guid GranteeSysAdminUnitId {
			get {
				return GetTypedColumnValue<Guid>("GranteeSysAdminUnitId");
			}
			set {
				SetColumnValue("GranteeSysAdminUnitId", value);
				_granteeSysAdminUnit = null;
			}
		}

		/// <exclude/>
		public string GranteeSysAdminUnitName {
			get {
				return GetTypedColumnValue<string>("GranteeSysAdminUnitName");
			}
			set {
				SetColumnValue("GranteeSysAdminUnitName", value);
				if (_granteeSysAdminUnit != null) {
					_granteeSysAdminUnit.Name = value;
				}
			}
		}

		private VwSysAdminUnit _granteeSysAdminUnit;
		/// <summary>
		/// Who receives permissions.
		/// </summary>
		public VwSysAdminUnit GranteeSysAdminUnit {
			get {
				return _granteeSysAdminUnit ??
					(_granteeSysAdminUnit = LookupColumnEntities.GetEntity("GranteeSysAdminUnit") as VwSysAdminUnit);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysAdminUnitGrantedRight_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysAdminUnitGrantedRightDeleted", e);
			Deleting += (s, e) => ThrowEvent("SysAdminUnitGrantedRightDeleting", e);
			Inserted += (s, e) => ThrowEvent("SysAdminUnitGrantedRightInserted", e);
			Inserting += (s, e) => ThrowEvent("SysAdminUnitGrantedRightInserting", e);
			Saved += (s, e) => ThrowEvent("SysAdminUnitGrantedRightSaved", e);
			Saving += (s, e) => ThrowEvent("SysAdminUnitGrantedRightSaving", e);
			Validating += (s, e) => ThrowEvent("SysAdminUnitGrantedRightValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysAdminUnitGrantedRight(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysAdminUnitGrantedRight_BaseEventsProcess

	/// <exclude/>
	public partial class SysAdminUnitGrantedRight_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysAdminUnitGrantedRight
	{

		public SysAdminUnitGrantedRight_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysAdminUnitGrantedRight_BaseEventsProcess";
			SchemaUId = new Guid("7273d66e-49ea-43e9-92ea-20f3d542407c");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7273d66e-49ea-43e9-92ea-20f3d542407c");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _sysAdminUnitGrantedRightSavedEventSubProcess;
		public ProcessFlowElement SysAdminUnitGrantedRightSavedEventSubProcess {
			get {
				return _sysAdminUnitGrantedRightSavedEventSubProcess ?? (_sysAdminUnitGrantedRightSavedEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SysAdminUnitGrantedRightSavedEventSubProcess",
					SchemaElementUId = new Guid("12110a24-27eb-4cec-a603-790f3e34997a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _sysAdminUnitGrantedRightSaved;
		public ProcessFlowElement SysAdminUnitGrantedRightSaved {
			get {
				return _sysAdminUnitGrantedRightSaved ?? (_sysAdminUnitGrantedRightSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SysAdminUnitGrantedRightSaved",
					SchemaElementUId = new Guid("371d4f8f-306e-4145-aad2-ecff6a386ff0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _sysAdminUnitGrantedRightDeleted;
		public ProcessFlowElement SysAdminUnitGrantedRightDeleted {
			get {
				return _sysAdminUnitGrantedRightDeleted ?? (_sysAdminUnitGrantedRightDeleted = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SysAdminUnitGrantedRightDeleted",
					SchemaElementUId = new Guid("00242600-9c4b-44e0-b1d0-9658f0e0fcaa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _sysAdminUnitGrantedRightSavedScriptTask;
		public ProcessScriptTask SysAdminUnitGrantedRightSavedScriptTask {
			get {
				return _sysAdminUnitGrantedRightSavedScriptTask ?? (_sysAdminUnitGrantedRightSavedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SysAdminUnitGrantedRightSavedScriptTask",
					SchemaElementUId = new Guid("7b097eee-81e3-434f-a770-e8fdd079e923"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SysAdminUnitGrantedRightSavedScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[SysAdminUnitGrantedRightSavedEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { SysAdminUnitGrantedRightSavedEventSubProcess };
			FlowElements[SysAdminUnitGrantedRightSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { SysAdminUnitGrantedRightSaved };
			FlowElements[SysAdminUnitGrantedRightDeleted.SchemaElementUId] = new Collection<ProcessFlowElement> { SysAdminUnitGrantedRightDeleted };
			FlowElements[SysAdminUnitGrantedRightSavedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SysAdminUnitGrantedRightSavedScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SysAdminUnitGrantedRightSavedEventSubProcess":
						break;
					case "SysAdminUnitGrantedRightSaved":
						e.Context.QueueTasks.Enqueue("SysAdminUnitGrantedRightSavedScriptTask");
						break;
					case "SysAdminUnitGrantedRightDeleted":
						e.Context.QueueTasks.Enqueue("SysAdminUnitGrantedRightSavedScriptTask");
						break;
					case "SysAdminUnitGrantedRightSavedScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("SysAdminUnitGrantedRightSaved");
			ActivatedEventElements.Add("SysAdminUnitGrantedRightDeleted");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SysAdminUnitGrantedRightSavedEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "SysAdminUnitGrantedRightSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysAdminUnitGrantedRightSaved";
					result = SysAdminUnitGrantedRightSaved.Execute(context);
					break;
				case "SysAdminUnitGrantedRightDeleted":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysAdminUnitGrantedRightDeleted";
					result = SysAdminUnitGrantedRightDeleted.Execute(context);
					break;
				case "SysAdminUnitGrantedRightSavedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysAdminUnitGrantedRightSavedScriptTask";
					result = SysAdminUnitGrantedRightSavedScriptTask.Execute(context, SysAdminUnitGrantedRightSavedScriptTaskExecute);
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

		public virtual bool SysAdminUnitGrantedRightSavedScriptTaskExecute(ProcessExecutingContext context) {
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "SysAdminUnitGrantedRightSaved":
							if (ActivatedEventElements.Contains("SysAdminUnitGrantedRightSaved")) {
							context.QueueTasks.Enqueue("SysAdminUnitGrantedRightSaved");
						}
						break;
					case "SysAdminUnitGrantedRightDeleted":
							if (ActivatedEventElements.Contains("SysAdminUnitGrantedRightDeleted")) {
							context.QueueTasks.Enqueue("SysAdminUnitGrantedRightDeleted");
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

	#region Class: SysAdminUnitGrantedRight_BaseEventsProcess

	/// <exclude/>
	public class SysAdminUnitGrantedRight_BaseEventsProcess : SysAdminUnitGrantedRight_BaseEventsProcess<SysAdminUnitGrantedRight>
	{

		public SysAdminUnitGrantedRight_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysAdminUnitGrantedRight_BaseEventsProcess

	public partial class SysAdminUnitGrantedRight_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysAdminUnitGrantedRightEventsProcessSchema

	/// <exclude/>
	public class SysAdminUnitGrantedRightEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysAdminUnitGrantedRightEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysAdminUnitGrantedRightEventsProcessSchema(SysAdminUnitGrantedRightEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysAdminUnitGrantedRight_BaseEventsProcess";
			UId = new Guid("5def2c86-4bd5-4ca6-b09a-d46e46c9cb3b");
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
			ProcessSchemaLaneSet schemaSysAdminUnitGrantedRightSavedLaneSet = CreateSysAdminUnitGrantedRightSavedLaneSetLaneSet();
			LaneSets.Add(schemaSysAdminUnitGrantedRightSavedLaneSet);
			ProcessSchemaLane schemaSysAdminUnitGrantedRightSavedLane = CreateSysAdminUnitGrantedRightSavedLaneLane();
			schemaSysAdminUnitGrantedRightSavedLaneSet.Lanes.Add(schemaSysAdminUnitGrantedRightSavedLane);
			ProcessSchemaEventSubProcess sysadminunitgrantedrightsavedeventsubprocess = CreateSysAdminUnitGrantedRightSavedEventSubProcessEventSubProcess();
			FlowElements.Add(sysadminunitgrantedrightsavedeventsubprocess);
			ProcessSchemaStartMessageEvent sysadminunitgrantedrightsaved = CreateSysAdminUnitGrantedRightSavedStartMessageEvent();
			sysadminunitgrantedrightsavedeventsubprocess.FlowElements.Add(sysadminunitgrantedrightsaved);
			ProcessSchemaStartMessageEvent sysadminunitgrantedrightdeleted = CreateSysAdminUnitGrantedRightDeletedStartMessageEvent();
			sysadminunitgrantedrightsavedeventsubprocess.FlowElements.Add(sysadminunitgrantedrightdeleted);
			ProcessSchemaScriptTask sysadminunitgrantedrightsavedscripttask = CreateSysAdminUnitGrantedRightSavedScriptTaskScriptTask();
			sysadminunitgrantedrightsavedeventsubprocess.FlowElements.Add(sysadminunitgrantedrightsavedscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("fba00ca2-5a6a-46d8-83e6-2239210a4f14"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81"),
				CreatedInSchemaUId = new Guid("5def2c86-4bd5-4ca6-b09a-d46e46c9cb3b"),
				CurveCenterPosition = new Point(227, 104),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5def2c86-4bd5-4ca6-b09a-d46e46c9cb3b"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("371d4f8f-306e-4145-aad2-ecff6a386ff0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7b097eee-81e3-434f-a770-e8fdd079e923"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("df584a94-bbbb-4369-8f2c-18b79bef79a2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81"),
				CreatedInSchemaUId = new Guid("5def2c86-4bd5-4ca6-b09a-d46e46c9cb3b"),
				CurveCenterPosition = new Point(224, 155),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5def2c86-4bd5-4ca6-b09a-d46e46c9cb3b"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("00242600-9c4b-44e0-b1d0-9658f0e0fcaa"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7b097eee-81e3-434f-a770-e8fdd079e923"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateSysAdminUnitGrantedRightSavedLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaSysAdminUnitGrantedRightSavedLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("bb123da1-7d7b-426d-b687-ad894005aa99"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81"),
				CreatedInSchemaUId = new Guid("5def2c86-4bd5-4ca6-b09a-d46e46c9cb3b"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("5def2c86-4bd5-4ca6-b09a-d46e46c9cb3b"),
				Name = @"SysAdminUnitGrantedRightSavedLaneSet",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(854, 255),
				UseBackgroundMode = false
			};
			return schemaSysAdminUnitGrantedRightSavedLaneSet;
		}

		protected virtual ProcessSchemaLane CreateSysAdminUnitGrantedRightSavedLaneLane() {
			ProcessSchemaLane schemaSysAdminUnitGrantedRightSavedLane = new ProcessSchemaLane(this) {
				UId = new Guid("bf033116-93a2-4fe4-92b7-8a549b9e3eb0"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("bb123da1-7d7b-426d-b687-ad894005aa99"),
				CreatedInOwnerSchemaUId = new Guid("7273d66e-49ea-43e9-92ea-20f3d542407c"),
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81"),
				CreatedInSchemaUId = new Guid("5def2c86-4bd5-4ca6-b09a-d46e46c9cb3b"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("5def2c86-4bd5-4ca6-b09a-d46e46c9cb3b"),
				Name = @"SysAdminUnitGrantedRightSavedLane",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(825, 255),
				UseBackgroundMode = false
			};
			return schemaSysAdminUnitGrantedRightSavedLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSysAdminUnitGrantedRightSavedEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSysAdminUnitGrantedRightSavedEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("12110a24-27eb-4cec-a603-790f3e34997a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bf033116-93a2-4fe4-92b7-8a549b9e3eb0"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81"),
				CreatedInSchemaUId = new Guid("5def2c86-4bd5-4ca6-b09a-d46e46c9cb3b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("5def2c86-4bd5-4ca6-b09a-d46e46c9cb3b"),
				Name = @"SysAdminUnitGrantedRightSavedEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(336, 234),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSysAdminUnitGrantedRightSavedEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSysAdminUnitGrantedRightSavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("371d4f8f-306e-4145-aad2-ecff6a386ff0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("12110a24-27eb-4cec-a603-790f3e34997a"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81"),
				CreatedInSchemaUId = new Guid("5def2c86-4bd5-4ca6-b09a-d46e46c9cb3b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysAdminUnitGrantedRightSaved",
				ModifiedInSchemaUId = new Guid("5def2c86-4bd5-4ca6-b09a-d46e46c9cb3b"),
				Name = @"SysAdminUnitGrantedRightSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(43, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSysAdminUnitGrantedRightDeletedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("00242600-9c4b-44e0-b1d0-9658f0e0fcaa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("12110a24-27eb-4cec-a603-790f3e34997a"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81"),
				CreatedInSchemaUId = new Guid("5def2c86-4bd5-4ca6-b09a-d46e46c9cb3b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysAdminUnitGrantedRightDeleted",
				ModifiedInSchemaUId = new Guid("5def2c86-4bd5-4ca6-b09a-d46e46c9cb3b"),
				Name = @"SysAdminUnitGrantedRightDeleted",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(43, 149),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSysAdminUnitGrantedRightSavedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7b097eee-81e3-434f-a770-e8fdd079e923"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("12110a24-27eb-4cec-a603-790f3e34997a"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81"),
				CreatedInSchemaUId = new Guid("5def2c86-4bd5-4ca6-b09a-d46e46c9cb3b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5def2c86-4bd5-4ca6-b09a-d46e46c9cb3b"),
				Name = @"SysAdminUnitGrantedRightSavedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(204, 93),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
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
			return new SysAdminUnitGrantedRightEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5def2c86-4bd5-4ca6-b09a-d46e46c9cb3b"));
		}

		#endregion

	}

	#endregion


	#region Class: SysAdminUnitGrantedRightEventsProcess

	/// <exclude/>
	public class SysAdminUnitGrantedRightEventsProcess : SysAdminUnitGrantedRight_BaseEventsProcess
	{

		public SysAdminUnitGrantedRightEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

