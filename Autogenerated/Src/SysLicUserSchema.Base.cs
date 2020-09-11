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

	#region Class: SysLicUserSchema

	/// <exclude/>
	public class SysLicUserSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysLicUserSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysLicUserSchema(SysLicUserSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysLicUserSchema(SysLicUserSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("75ac6ca6-1ee2-434f-be99-524b8dabc99f");
			RealUId = new Guid("75ac6ca6-1ee2-434f-be99-524b8dabc99f");
			Name = "SysLicUser";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("70baaf33-7ef6-430f-aa11-772b12f96cae")) == null) {
				Columns.Add(CreateSysLicPackageColumn());
			}
			if (Columns.FindByUId(new Guid("8e86eec6-d855-4730-a3c1-17ba27026f92")) == null) {
				Columns.Add(CreateSysUserColumn());
			}
			if (Columns.FindByUId(new Guid("5cb31d3d-5d2b-4e2f-a6c3-b7d55a6e0c03")) == null) {
				Columns.Add(CreateActiveColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSysLicPackageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("70baaf33-7ef6-430f-aa11-772b12f96cae"),
				Name = @"SysLicPackage",
				ReferenceSchemaUId = new Guid("bba64ad2-ff65-46f4-911d-4068aa0af48a"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("75ac6ca6-1ee2-434f-be99-524b8dabc99f"),
				ModifiedInSchemaUId = new Guid("75ac6ca6-1ee2-434f-be99-524b8dabc99f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSysUserColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8e86eec6-d855-4730-a3c1-17ba27026f92"),
				Name = @"SysUser",
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("75ac6ca6-1ee2-434f-be99-524b8dabc99f"),
				ModifiedInSchemaUId = new Guid("75ac6ca6-1ee2-434f-be99-524b8dabc99f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateActiveColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("5cb31d3d-5d2b-4e2f-a6c3-b7d55a6e0c03"),
				Name = @"Active",
				CreatedInSchemaUId = new Guid("75ac6ca6-1ee2-434f-be99-524b8dabc99f"),
				ModifiedInSchemaUId = new Guid("75ac6ca6-1ee2-434f-be99-524b8dabc99f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
			EventsProcessSchema = CreateSysLicUserEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysLicUserEventsProcessSchema() {
			var schema = new SysLicUserEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysLicUser(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysLicUser_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysLicUserSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysLicUserSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("75ac6ca6-1ee2-434f-be99-524b8dabc99f"));
		}

		#endregion

	}

	#endregion

	#region Class: SysLicUser

	/// <summary>
	/// User licenses.
	/// </summary>
	public class SysLicUser : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysLicUser(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysLicUser";
		}

		public SysLicUser(SysLicUser source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid SysLicPackageId {
			get {
				return GetTypedColumnValue<Guid>("SysLicPackageId");
			}
			set {
				SetColumnValue("SysLicPackageId", value);
				_sysLicPackage = null;
			}
		}

		/// <exclude/>
		public string SysLicPackageName {
			get {
				return GetTypedColumnValue<string>("SysLicPackageName");
			}
			set {
				SetColumnValue("SysLicPackageName", value);
				if (_sysLicPackage != null) {
					_sysLicPackage.Name = value;
				}
			}
		}

		private SysLicPackage _sysLicPackage;
		/// <summary>
		/// Product.
		/// </summary>
		public SysLicPackage SysLicPackage {
			get {
				return _sysLicPackage ??
					(_sysLicPackage = LookupColumnEntities.GetEntity("SysLicPackage") as SysLicPackage);
			}
		}

		/// <exclude/>
		public Guid SysUserId {
			get {
				return GetTypedColumnValue<Guid>("SysUserId");
			}
			set {
				SetColumnValue("SysUserId", value);
				_sysUser = null;
			}
		}

		/// <exclude/>
		public string SysUserName {
			get {
				return GetTypedColumnValue<string>("SysUserName");
			}
			set {
				SetColumnValue("SysUserName", value);
				if (_sysUser != null) {
					_sysUser.Name = value;
				}
			}
		}

		private SysAdminUnit _sysUser;
		/// <summary>
		/// User.
		/// </summary>
		public SysAdminUnit SysUser {
			get {
				return _sysUser ??
					(_sysUser = LookupColumnEntities.GetEntity("SysUser") as SysAdminUnit);
			}
		}

		/// <summary>
		/// License active.
		/// </summary>
		public bool Active {
			get {
				return GetTypedColumnValue<bool>("Active");
			}
			set {
				SetColumnValue("Active", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysLicUser_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysLicUserDeleted", e);
			Deleting += (s, e) => ThrowEvent("SysLicUserDeleting", e);
			Inserted += (s, e) => ThrowEvent("SysLicUserInserted", e);
			Inserting += (s, e) => ThrowEvent("SysLicUserInserting", e);
			Saved += (s, e) => ThrowEvent("SysLicUserSaved", e);
			Saving += (s, e) => ThrowEvent("SysLicUserSaving", e);
			Validating += (s, e) => ThrowEvent("SysLicUserValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysLicUser(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysLicUser_BaseEventsProcess

	/// <exclude/>
	public partial class SysLicUser_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysLicUser
	{

		public SysLicUser_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysLicUser_BaseEventsProcess";
			SchemaUId = new Guid("75ac6ca6-1ee2-434f-be99-524b8dabc99f");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("75ac6ca6-1ee2-434f-be99-524b8dabc99f");
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
					SchemaElementUId = new Guid("b968f1f6-6ba4-480c-aae0-5f273aed6ea6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _sysLicUserInserting;
		public ProcessFlowElement SysLicUserInserting {
			get {
				return _sysLicUserInserting ?? (_sysLicUserInserting = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SysLicUserInserting",
					SchemaElementUId = new Guid("007886e7-91b1-4583-85e4-8232f66362af"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _sysLicUserSaving;
		public ProcessFlowElement SysLicUserSaving {
			get {
				return _sysLicUserSaving ?? (_sysLicUserSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SysLicUserSaving",
					SchemaElementUId = new Guid("abb443af-233d-43ec-b1e7-92b008d4ac16"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _sysLicUserDeleting;
		public ProcessFlowElement SysLicUserDeleting {
			get {
				return _sysLicUserDeleting ?? (_sysLicUserDeleting = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SysLicUserDeleting",
					SchemaElementUId = new Guid("4e765c9b-cfb2-4a20-9577-fe9b513ab762"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _validateCanChangeRecord;
		public ProcessScriptTask ValidateCanChangeRecord {
			get {
				return _validateCanChangeRecord ?? (_validateCanChangeRecord = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ValidateCanChangeRecord",
					SchemaElementUId = new Guid("06820a37-929f-4115-aa33-0e2a1b80f636"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ValidateCanChangeRecordExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[SysLicUserInserting.SchemaElementUId] = new Collection<ProcessFlowElement> { SysLicUserInserting };
			FlowElements[SysLicUserSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { SysLicUserSaving };
			FlowElements[SysLicUserDeleting.SchemaElementUId] = new Collection<ProcessFlowElement> { SysLicUserDeleting };
			FlowElements[ValidateCanChangeRecord.SchemaElementUId] = new Collection<ProcessFlowElement> { ValidateCanChangeRecord };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "SysLicUserInserting":
						e.Context.QueueTasks.Enqueue("ValidateCanChangeRecord");
						break;
					case "SysLicUserSaving":
						e.Context.QueueTasks.Enqueue("ValidateCanChangeRecord");
						break;
					case "SysLicUserDeleting":
						e.Context.QueueTasks.Enqueue("ValidateCanChangeRecord");
						break;
					case "ValidateCanChangeRecord":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("SysLicUserInserting");
			ActivatedEventElements.Add("SysLicUserSaving");
			ActivatedEventElements.Add("SysLicUserDeleting");
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
				case "SysLicUserInserting":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysLicUserInserting";
					result = SysLicUserInserting.Execute(context);
					break;
				case "SysLicUserSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysLicUserSaving";
					result = SysLicUserSaving.Execute(context);
					break;
				case "SysLicUserDeleting":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysLicUserDeleting";
					result = SysLicUserDeleting.Execute(context);
					break;
				case "ValidateCanChangeRecord":
					context.QueueTasks.Dequeue();
					context.SenderName = "ValidateCanChangeRecord";
					result = ValidateCanChangeRecord.Execute(context, ValidateCanChangeRecordExecute);
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

		public virtual bool ValidateCanChangeRecordExecute(ProcessExecutingContext context) {
			UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageLicUsers");
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "SysLicUserInserting":
							if (ActivatedEventElements.Contains("SysLicUserInserting")) {
							context.QueueTasks.Enqueue("SysLicUserInserting");
						}
						break;
					case "SysLicUserSaving":
							if (ActivatedEventElements.Contains("SysLicUserSaving")) {
							context.QueueTasks.Enqueue("SysLicUserSaving");
						}
						break;
					case "SysLicUserDeleting":
							if (ActivatedEventElements.Contains("SysLicUserDeleting")) {
							context.QueueTasks.Enqueue("SysLicUserDeleting");
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

	#region Class: SysLicUser_BaseEventsProcess

	/// <exclude/>
	public class SysLicUser_BaseEventsProcess : SysLicUser_BaseEventsProcess<SysLicUser>
	{

		public SysLicUser_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysLicUser_BaseEventsProcess

	public partial class SysLicUser_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysLicUserEventsProcessSchema

	/// <exclude/>
	public class SysLicUserEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysLicUserEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysLicUserEventsProcessSchema(SysLicUserEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysLicUser_BaseEventsProcess";
			UId = new Guid("453f68b1-879a-4526-a167-f1492e41cc08");
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
			ProcessSchemaStartMessageEvent syslicuserinserting = CreateSysLicUserInsertingStartMessageEvent();
			eventsubprocess1.FlowElements.Add(syslicuserinserting);
			ProcessSchemaStartMessageEvent syslicusersaving = CreateSysLicUserSavingStartMessageEvent();
			eventsubprocess1.FlowElements.Add(syslicusersaving);
			ProcessSchemaStartMessageEvent syslicuserdeleting = CreateSysLicUserDeletingStartMessageEvent();
			eventsubprocess1.FlowElements.Add(syslicuserdeleting);
			ProcessSchemaScriptTask validatecanchangerecord = CreateValidateCanChangeRecordScriptTask();
			eventsubprocess1.FlowElements.Add(validatecanchangerecord);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("4be8f1f1-df8e-45b0-a3cc-c019952cdd11"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ff020f5-e34d-4da9-8c0d-3678e6f20dbf"),
				CreatedInSchemaUId = new Guid("453f68b1-879a-4526-a167-f1492e41cc08"),
				CurveCenterPosition = new Point(188, 82),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("453f68b1-879a-4526-a167-f1492e41cc08"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("007886e7-91b1-4583-85e4-8232f66362af"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("06820a37-929f-4115-aa33-0e2a1b80f636"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("b4cbcf87-7d38-4c51-9685-aea7dfa8c69d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ff020f5-e34d-4da9-8c0d-3678e6f20dbf"),
				CreatedInSchemaUId = new Guid("453f68b1-879a-4526-a167-f1492e41cc08"),
				CurveCenterPosition = new Point(188, 112),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("453f68b1-879a-4526-a167-f1492e41cc08"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("abb443af-233d-43ec-b1e7-92b008d4ac16"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("06820a37-929f-4115-aa33-0e2a1b80f636"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("23dd64e7-309a-4c72-b3ae-966a8ad0fbb5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ff020f5-e34d-4da9-8c0d-3678e6f20dbf"),
				CreatedInSchemaUId = new Guid("453f68b1-879a-4526-a167-f1492e41cc08"),
				CurveCenterPosition = new Point(187, 143),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("453f68b1-879a-4526-a167-f1492e41cc08"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4e765c9b-cfb2-4a20-9577-fe9b513ab762"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("06820a37-929f-4115-aa33-0e2a1b80f636"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("641aca6c-aa53-4c2d-aa2d-fa6c9d186687"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ff020f5-e34d-4da9-8c0d-3678e6f20dbf"),
				CreatedInSchemaUId = new Guid("453f68b1-879a-4526-a167-f1492e41cc08"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("453f68b1-879a-4526-a167-f1492e41cc08"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1193, 242),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("d4231c5a-f7ff-4cb7-aac6-ef5658a202c6"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("641aca6c-aa53-4c2d-aa2d-fa6c9d186687"),
				CreatedInOwnerSchemaUId = new Guid("75ac6ca6-1ee2-434f-be99-524b8dabc99f"),
				CreatedInPackageId = new Guid("6ff020f5-e34d-4da9-8c0d-3678e6f20dbf"),
				CreatedInSchemaUId = new Guid("453f68b1-879a-4526-a167-f1492e41cc08"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("453f68b1-879a-4526-a167-f1492e41cc08"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1164, 242),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b968f1f6-6ba4-480c-aae0-5f273aed6ea6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d4231c5a-f7ff-4cb7-aac6-ef5658a202c6"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ff020f5-e34d-4da9-8c0d-3678e6f20dbf"),
				CreatedInSchemaUId = new Guid("453f68b1-879a-4526-a167-f1492e41cc08"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("453f68b1-879a-4526-a167-f1492e41cc08"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(28, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(350, 221),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSysLicUserInsertingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("007886e7-91b1-4583-85e4-8232f66362af"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b968f1f6-6ba4-480c-aae0-5f273aed6ea6"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ff020f5-e34d-4da9-8c0d-3678e6f20dbf"),
				CreatedInSchemaUId = new Guid("453f68b1-879a-4526-a167-f1492e41cc08"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysLicUserInserting",
				ModifiedInSchemaUId = new Guid("453f68b1-879a-4526-a167-f1492e41cc08"),
				Name = @"SysLicUserInserting",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 23),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSysLicUserSavingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("abb443af-233d-43ec-b1e7-92b008d4ac16"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b968f1f6-6ba4-480c-aae0-5f273aed6ea6"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ff020f5-e34d-4da9-8c0d-3678e6f20dbf"),
				CreatedInSchemaUId = new Guid("453f68b1-879a-4526-a167-f1492e41cc08"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysLicUserSaving",
				ModifiedInSchemaUId = new Guid("453f68b1-879a-4526-a167-f1492e41cc08"),
				Name = @"SysLicUserSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 86),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSysLicUserDeletingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("4e765c9b-cfb2-4a20-9577-fe9b513ab762"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b968f1f6-6ba4-480c-aae0-5f273aed6ea6"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ff020f5-e34d-4da9-8c0d-3678e6f20dbf"),
				CreatedInSchemaUId = new Guid("453f68b1-879a-4526-a167-f1492e41cc08"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysLicUserDeleting",
				ModifiedInSchemaUId = new Guid("453f68b1-879a-4526-a167-f1492e41cc08"),
				Name = @"SysLicUserDeleting",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 149),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateValidateCanChangeRecordScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("06820a37-929f-4115-aa33-0e2a1b80f636"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b968f1f6-6ba4-480c-aae0-5f273aed6ea6"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ff020f5-e34d-4da9-8c0d-3678e6f20dbf"),
				CreatedInSchemaUId = new Guid("453f68b1-879a-4526-a167-f1492e41cc08"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("453f68b1-879a-4526-a167-f1492e41cc08"),
				Name = @"ValidateCanChangeRecord",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(183, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,78,45,114,206,207,203,75,77,46,201,204,207,211,115,113,10,78,77,46,45,202,44,169,116,205,75,207,204,75,213,115,206,72,77,206,118,78,204,115,173,0,138,151,164,250,23,164,22,37,130,84,106,40,1,5,125,19,243,18,211,83,125,50,147,67,129,166,20,43,105,90,243,114,21,165,150,148,22,229,41,148,20,149,166,90,3,0,142,127,50,177,92,0,0,0 }
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
			return new SysLicUserEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("453f68b1-879a-4526-a167-f1492e41cc08"));
		}

		#endregion

	}

	#endregion


	#region Class: SysLicUserEventsProcess

	/// <exclude/>
	public class SysLicUserEventsProcess : SysLicUser_BaseEventsProcess
	{

		public SysLicUserEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

