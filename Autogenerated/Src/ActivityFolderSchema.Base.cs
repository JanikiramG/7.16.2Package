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
	using Terrasoft.Configuration;
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

	#region Class: ActivityFolderSchema

	/// <exclude/>
	public class ActivityFolderSchema : Terrasoft.Configuration.BaseFolderSchema
	{

		#region Constructors: Public

		public ActivityFolderSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ActivityFolderSchema(ActivityFolderSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ActivityFolderSchema(ActivityFolderSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("31464792-6754-447f-83ae-90a1b468c29f");
			RealUId = new Guid("31464792-6754-447f-83ae-90a1b468c29f");
			Name = "ActivityFolder";
			ParentSchemaUId = new Guid("d602bf96-d029-4b07-9755-63c8f5cb5ed5");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("6734071f-f02c-44b2-9b41-25d75036b663")) == null) {
				Columns.Add(CreateFolderEmbeddedProcessIdColumn());
			}
			if (Columns.FindByUId(new Guid("32fe519c-cd89-4c16-bb81-a8e67e86d0cb")) == null) {
				Columns.Add(CreateSynchronizeColumn());
			}
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("31464792-6754-447f-83ae-90a1b468c29f");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("31464792-6754-447f-83ae-90a1b468c29f");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected override EntitySchemaColumn CreateParentColumn() {
			EntitySchemaColumn column = base.CreateParentColumn();
			column.ReferenceSchemaUId = new Guid("31464792-6754-447f-83ae-90a1b468c29f");
			column.ColumnValueName = @"ParentId";
			column.DisplayColumnValueName = @"ParentName";
			column.ModifiedInSchemaUId = new Guid("31464792-6754-447f-83ae-90a1b468c29f");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected override EntitySchemaColumn CreateFolderTypeColumn() {
			EntitySchemaColumn column = base.CreateFolderTypeColumn();
			column.ModifiedInSchemaUId = new Guid("31464792-6754-447f-83ae-90a1b468c29f");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected override EntitySchemaColumn CreateSearchDataColumn() {
			EntitySchemaColumn column = base.CreateSearchDataColumn();
			column.ModifiedInSchemaUId = new Guid("31464792-6754-447f-83ae-90a1b468c29f");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected virtual EntitySchemaColumn CreateFolderEmbeddedProcessIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("6734071f-f02c-44b2-9b41-25d75036b663"),
				Name = @"FolderEmbeddedProcessId",
				CreatedInSchemaUId = new Guid("31464792-6754-447f-83ae-90a1b468c29f"),
				ModifiedInSchemaUId = new Guid("31464792-6754-447f-83ae-90a1b468c29f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSynchronizeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("32fe519c-cd89-4c16-bb81-a8e67e86d0cb"),
				Name = @"Synchronize",
				CreatedInSchemaUId = new Guid("31464792-6754-447f-83ae-90a1b468c29f"),
				ModifiedInSchemaUId = new Guid("31464792-6754-447f-83ae-90a1b468c29f"),
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
			EventsProcessSchema = CreateActivityFolderEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateActivityFolderEventsProcessSchema() {
			var schema = new ActivityFolderEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ActivityFolder(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ActivityFolder_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ActivityFolderSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ActivityFolderSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("31464792-6754-447f-83ae-90a1b468c29f"));
		}

		#endregion

	}

	#endregion

	#region Class: ActivityFolder

	/// <summary>
	/// Activity folder.
	/// </summary>
	public class ActivityFolder : Terrasoft.Configuration.BaseFolder
	{

		#region Constructors: Public

		public ActivityFolder(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ActivityFolder";
		}

		public ActivityFolder(ActivityFolder source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ParentId {
			get {
				return GetTypedColumnValue<Guid>("ParentId");
			}
			set {
				SetColumnValue("ParentId", value);
				_parent = null;
			}
		}

		/// <exclude/>
		public string ParentName {
			get {
				return GetTypedColumnValue<string>("ParentName");
			}
			set {
				SetColumnValue("ParentName", value);
				if (_parent != null) {
					_parent.Name = value;
				}
			}
		}

		private ActivityFolder _parent;
		/// <summary>
		/// Parent.
		/// </summary>
		public ActivityFolder Parent {
			get {
				return _parent ??
					(_parent = LookupColumnEntities.GetEntity("Parent") as ActivityFolder);
			}
		}

		/// <summary>
		/// Folder process.
		/// </summary>
		public Guid FolderEmbeddedProcessId {
			get {
				return GetTypedColumnValue<Guid>("FolderEmbeddedProcessId");
			}
			set {
				SetColumnValue("FolderEmbeddedProcessId", value);
			}
		}

		/// <summary>
		/// Synchronize.
		/// </summary>
		public bool Synchronize {
			get {
				return GetTypedColumnValue<bool>("Synchronize");
			}
			set {
				SetColumnValue("Synchronize", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ActivityFolder_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ActivityFolderDeleted", e);
			Deleting += (s, e) => ThrowEvent("ActivityFolderDeleting", e);
			Inserting += (s, e) => ThrowEvent("ActivityFolderInserting", e);
			Validating += (s, e) => ThrowEvent("ActivityFolderValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ActivityFolder(this);
		}

		#endregion

	}

	#endregion

	#region Class: ActivityFolder_BaseEventsProcess

	/// <exclude/>
	public partial class ActivityFolder_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseFolder_BaseEventsProcess<TEntity> where TEntity : ActivityFolder
	{

		public ActivityFolder_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ActivityFolder_BaseEventsProcess";
			SchemaUId = new Guid("31464792-6754-447f-83ae-90a1b468c29f");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("31464792-6754-447f-83ae-90a1b468c29f");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual int EntityStoringStateBeforeSave {
			get;
			set;
		}

		public virtual string ActivityFolderOldNameBeforeSave {
			get;
			set;
		}

		private ProcessFlowElement _deleteEventSubProcess;
		public ProcessFlowElement DeleteEventSubProcess {
			get {
				return _deleteEventSubProcess ?? (_deleteEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "DeleteEventSubProcess",
					SchemaElementUId = new Guid("2110d011-28c4-4993-9aa0-c3ead6a4b0bb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _activityFolderDeleting;
		public ProcessFlowElement ActivityFolderDeleting {
			get {
				return _activityFolderDeleting ?? (_activityFolderDeleting = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ActivityFolderDeleting",
					SchemaElementUId = new Guid("ad478654-bb12-40b3-9e8f-a1091ff2be78"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _activityFolderDeletingScriptTask;
		public ProcessScriptTask ActivityFolderDeletingScriptTask {
			get {
				return _activityFolderDeletingScriptTask ?? (_activityFolderDeletingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ActivityFolderDeletingScriptTask",
					SchemaElementUId = new Guid("6c73982b-a75e-4e03-ab6f-0fe5474db902"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ActivityFolderDeletingScriptTaskExecute,
				});
			}
		}

		private LocalizableString _sameFolderAlreadyExistLS;
		public LocalizableString SameFolderAlreadyExistLS {
			get {
				return _sameFolderAlreadyExistLS ?? (_sameFolderAlreadyExistLS = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.SameFolderAlreadyExistLS.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[DeleteEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteEventSubProcess };
			FlowElements[ActivityFolderDeleting.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityFolderDeleting };
			FlowElements[ActivityFolderDeletingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityFolderDeletingScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "DeleteEventSubProcess":
						break;
					case "ActivityFolderDeleting":
						e.Context.QueueTasks.Enqueue("ActivityFolderDeletingScriptTask");
						break;
					case "ActivityFolderDeletingScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ActivityFolderDeleting");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "DeleteEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ActivityFolderDeleting":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActivityFolderDeleting";
					result = ActivityFolderDeleting.Execute(context);
					break;
				case "ActivityFolderDeletingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActivityFolderDeletingScriptTask";
					result = ActivityFolderDeletingScriptTask.Execute(context, ActivityFolderDeletingScriptTaskExecute);
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
				case "ActivityFolderOldNameBeforeSave":
					ActivityFolderOldNameBeforeSave = reader.GetValue<System.String>();
				break;
				case "EntityStoringStateBeforeSave":
					EntityStoringStateBeforeSave = reader.GetValue<System.Int32>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ActivityFolderDeletingScriptTaskExecute(ProcessExecutingContext context) {
			if (Entity.FolderTypeId == FolderConsts.MailboxFolderTypeId) {
				var parameters = new Dictionary<string, object> {
							{ "SenderEmailAddress", Entity.Name },
							{ "CurrentUserId", UserConnection.CurrentUser.Id }
						};
				var scheduler = ClassFactory.Get<Terrasoft.Mail.IImapSyncJobScheduler>();
				scheduler.RemoveSyncJob(UserConnection, parameters);
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ActivityFolderDeleting":
							if (ActivatedEventElements.Contains("ActivityFolderDeleting")) {
							context.QueueTasks.Enqueue("ActivityFolderDeleting");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("ActivityFolderOldNameBeforeSave") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ActivityFolderOldNameBeforeSave", ActivityFolderOldNameBeforeSave, null);
			}
			if (!HasMapping("EntityStoringStateBeforeSave") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EntityStoringStateBeforeSave", EntityStoringStateBeforeSave, 0);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: ActivityFolder_BaseEventsProcess

	/// <exclude/>
	public class ActivityFolder_BaseEventsProcess : ActivityFolder_BaseEventsProcess<ActivityFolder>
	{

		public ActivityFolder_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ActivityFolderEventsProcessSchema

	/// <exclude/>
	public class ActivityFolderEventsProcessSchema : Terrasoft.Configuration.BaseFolderEventsProcessSchema
	{

		#region Constructors: Public

		public ActivityFolderEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ActivityFolderEventsProcessSchema(ActivityFolderEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ActivityFolder_BaseEventsProcess";
			UId = new Guid("7221cfd7-6dcc-48dd-bc84-c7f04215dde0");
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

		protected virtual ProcessSchemaParameter CreateEntityStoringStateBeforeSaveParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("960463d3-a1ba-437f-a8e6-a9dfe5a5061a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7221cfd7-6dcc-48dd-bc84-c7f04215dde0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7221cfd7-6dcc-48dd-bc84-c7f04215dde0"),
				Name = @"EntityStoringStateBeforeSave",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected virtual ProcessSchemaParameter CreateActivityFolderOldNameBeforeSaveParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("87ec657e-265e-4aeb-a8cc-b341792555c4"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7221cfd7-6dcc-48dd-bc84-c7f04215dde0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7221cfd7-6dcc-48dd-bc84-c7f04215dde0"),
				Name = @"ActivityFolderOldNameBeforeSave",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateEntityStoringStateBeforeSaveParameter());
			Parameters.Add(CreateActivityFolderOldNameBeforeSaveParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess deleteeventsubprocess = CreateDeleteEventSubProcessEventSubProcess();
			FlowElements.Add(deleteeventsubprocess);
			ProcessSchemaStartMessageEvent activityfolderdeleting = CreateActivityFolderDeletingStartMessageEvent();
			deleteeventsubprocess.FlowElements.Add(activityfolderdeleting);
			ProcessSchemaScriptTask activityfolderdeletingscripttask = CreateActivityFolderDeletingScriptTaskScriptTask();
			deleteeventsubprocess.FlowElements.Add(activityfolderdeletingscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateSameFolderAlreadyExistLSLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateSameFolderAlreadyExistLSLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("85596a7d-606c-4e75-a60b-82cf8c9caa1d"),
				Name = "SameFolderAlreadyExistLS",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7221cfd7-6dcc-48dd-bc84-c7f04215dde0"),
				ModifiedInSchemaUId = new Guid("7221cfd7-6dcc-48dd-bc84-c7f04215dde0")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("c0c34ac0-b6bc-4cb2-b509-9c10433f19b5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("cfd53d66-8891-4a3e-9c4f-4b8970e3e405"),
				CreatedInPackageId = new Guid("02c41552-6138-41c7-b1d8-208f324fe99a"),
				CreatedInSchemaUId = new Guid("7221cfd7-6dcc-48dd-bc84-c7f04215dde0"),
				CurveCenterPosition = new Point(156, 100),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7221cfd7-6dcc-48dd-bc84-c7f04215dde0"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ad478654-bb12-40b3-9e8f-a1091ff2be78"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6c73982b-a75e-4e03-ab6f-0fe5474db902"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("538279a0-798e-44dc-9b21-7f7eaef3adc1"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("cfd53d66-8891-4a3e-9c4f-4b8970e3e405"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7221cfd7-6dcc-48dd-bc84-c7f04215dde0"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("7221cfd7-6dcc-48dd-bc84-c7f04215dde0"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("cd960e0b-2820-4d5e-8de0-6be95130445d"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("538279a0-798e-44dc-9b21-7f7eaef3adc1"),
				CreatedInOwnerSchemaUId = new Guid("31464792-6754-447f-83ae-90a1b468c29f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7221cfd7-6dcc-48dd-bc84-c7f04215dde0"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("7221cfd7-6dcc-48dd-bc84-c7f04215dde0"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateDeleteEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaDeleteEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2110d011-28c4-4993-9aa0-c3ead6a4b0bb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cd960e0b-2820-4d5e-8de0-6be95130445d"),
				CreatedInOwnerSchemaUId = new Guid("cfd53d66-8891-4a3e-9c4f-4b8970e3e405"),
				CreatedInPackageId = new Guid("02c41552-6138-41c7-b1d8-208f324fe99a"),
				CreatedInSchemaUId = new Guid("7221cfd7-6dcc-48dd-bc84-c7f04215dde0"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("7221cfd7-6dcc-48dd-bc84-c7f04215dde0"),
				Name = @"DeleteEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(231, 196),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaDeleteEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateActivityFolderDeletingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ad478654-bb12-40b3-9e8f-a1091ff2be78"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2110d011-28c4-4993-9aa0-c3ead6a4b0bb"),
				CreatedInOwnerSchemaUId = new Guid("cfd53d66-8891-4a3e-9c4f-4b8970e3e405"),
				CreatedInPackageId = new Guid("02c41552-6138-41c7-b1d8-208f324fe99a"),
				CreatedInSchemaUId = new Guid("7221cfd7-6dcc-48dd-bc84-c7f04215dde0"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ActivityFolderDeleting",
				ModifiedInSchemaUId = new Guid("7221cfd7-6dcc-48dd-bc84-c7f04215dde0"),
				Name = @"ActivityFolderDeleting",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(22, 72),
				SerializeToDB = false,
				Size = new Size(31, 31),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateActivityFolderDeletingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6c73982b-a75e-4e03-ab6f-0fe5474db902"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2110d011-28c4-4993-9aa0-c3ead6a4b0bb"),
				CreatedInOwnerSchemaUId = new Guid("cfd53d66-8891-4a3e-9c4f-4b8970e3e405"),
				CreatedInPackageId = new Guid("02c41552-6138-41c7-b1d8-208f324fe99a"),
				CreatedInSchemaUId = new Guid("7221cfd7-6dcc-48dd-bc84-c7f04215dde0"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("7221cfd7-6dcc-48dd-bc84-c7f04215dde0"),
				Name = @"ActivityFolderDeletingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(120, 58),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,144,65,78,195,48,16,69,215,32,113,135,81,87,169,20,249,2,109,42,161,208,162,32,193,130,148,3,56,246,20,140,18,59,154,153,20,162,42,119,199,9,161,10,94,217,242,255,111,158,237,78,144,236,189,56,233,213,33,212,22,233,216,183,88,88,200,50,248,61,231,193,179,176,122,214,174,174,194,247,50,179,134,203,221,237,205,89,19,180,154,116,131,130,196,144,129,199,47,120,112,70,92,240,154,250,45,11,57,255,158,66,168,62,209,200,110,234,196,117,129,85,137,62,178,246,77,36,223,91,75,200,188,74,97,118,121,137,60,24,210,107,54,239,136,208,203,27,35,21,54,198,198,77,52,243,56,205,81,139,107,21,229,135,169,55,108,102,61,54,31,104,187,26,41,218,229,181,102,62,104,35,129,122,245,136,178,61,34,145,230,112,146,233,137,170,40,26,221,150,189,55,79,161,42,255,122,187,100,61,178,174,28,245,138,77,56,227,28,75,254,203,164,139,239,24,107,81,134,80,58,242,32,212,225,230,7,45,171,105,19,113,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateDeleteImapFolderByEmailSubFolderMethod());
			Methods.Add(CreateGetInitializedImapClientMethod());
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
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ebed6c5d-62fb-40bb-b645-f0328fab09ae"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected override SchemaMethod CreateCheckCanManageLookupsMethod() {
			SchemaMethod method = base.CreateCheckCanManageLookupsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,179,6,0,7,133,17,243,7,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateDeleteImapFolderByEmailSubFolderMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("da778c59-212c-4481-afcf-564e4bd4fca4"),
				Name = "DeleteImapFolderByEmailSubFolder",
				CreatedInSchemaUId = new Guid("7221cfd7-6dcc-48dd-bc84-c7f04215dde0"),
				CreatedInPackageId = new Guid("02c41552-6138-41c7-b1d8-208f324fe99a"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,69,142,49,111,194,48,20,132,103,252,43,30,100,73,6,146,10,209,46,180,72,40,78,43,134,6,9,172,118,68,86,252,66,158,228,216,145,251,40,77,17,255,157,148,129,78,55,220,125,119,23,81,13,227,178,80,59,181,42,229,106,43,103,251,7,200,50,80,27,185,129,124,251,62,157,207,30,231,79,130,67,15,103,49,250,214,1,168,213,93,110,9,29,195,11,188,33,175,29,49,105,75,191,104,214,119,43,78,22,98,244,159,76,85,232,37,90,100,124,245,214,96,136,11,199,196,125,58,224,170,239,208,228,222,30,91,247,161,237,17,159,191,56,144,59,44,227,73,169,91,156,36,67,209,5,42,205,85,3,113,241,83,97,199,228,93,242,119,38,203,148,151,30,62,27,205,112,66,56,145,181,96,252,160,220,64,125,155,17,23,17,161,51,84,95,1,18,24,253,13,229,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetInitializedImapClientMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("39b01ebc-7738-4e30-afd1-3889bde6db8f"),
				Name = "GetInitializedImapClient",
				CreatedInSchemaUId = new Guid("7221cfd7-6dcc-48dd-bc84-c7f04215dde0"),
				CreatedInPackageId = new Guid("02c41552-6138-41c7-b1d8-208f324fe99a"),
				ResultValueTypeName = "Terrasoft.Mail.ImapClient"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,84,203,110,155,64,20,93,195,87,76,201,6,36,151,164,174,219,77,218,74,196,198,41,81,252,144,113,219,69,21,85,99,115,157,32,193,140,123,103,240,67,149,255,189,119,192,54,126,37,94,96,152,123,206,185,175,3,87,233,140,189,235,135,227,120,28,244,59,193,168,211,252,115,195,174,175,217,120,208,25,176,246,168,247,190,213,252,212,250,108,47,56,50,5,25,76,53,251,202,4,44,89,92,62,184,63,20,96,91,10,65,247,169,20,158,109,89,126,91,102,69,46,92,167,23,59,13,230,4,73,130,160,148,227,157,156,15,37,234,179,67,82,139,227,71,231,68,102,23,194,62,207,225,136,179,143,12,185,82,75,137,73,69,237,162,204,41,204,211,44,6,92,0,18,39,80,101,142,50,28,81,185,248,32,83,81,97,38,114,21,175,197,52,6,173,83,241,172,246,96,66,251,131,58,77,45,23,81,26,63,82,225,223,130,103,187,202,163,228,76,59,160,145,44,82,189,238,202,44,217,215,16,116,183,170,116,67,180,109,71,7,98,39,205,26,205,95,47,128,176,99,28,37,175,38,225,15,57,18,88,3,186,161,208,148,209,191,7,61,94,207,33,169,226,63,121,86,192,151,251,34,77,190,185,14,97,65,104,163,226,121,140,171,237,30,111,109,107,187,98,211,96,27,33,33,80,202,51,181,221,246,24,16,185,146,51,237,155,49,148,151,3,144,235,221,218,133,162,225,49,215,136,36,147,112,5,211,66,75,36,246,177,65,252,80,168,2,161,115,87,31,185,84,199,63,219,98,135,2,92,243,17,112,154,26,9,84,174,243,43,73,168,142,221,58,69,197,182,200,196,110,77,243,205,95,41,204,72,153,126,214,89,99,254,119,169,140,151,93,165,145,18,123,53,249,247,205,19,141,195,186,64,49,158,53,148,84,232,67,252,135,215,240,198,206,42,51,140,137,148,217,33,165,249,6,165,220,252,229,202,62,190,69,219,189,3,7,212,147,225,119,72,169,52,131,49,71,143,11,254,12,104,244,44,99,152,72,40,205,197,20,238,214,38,191,235,196,52,95,132,49,172,204,107,74,241,146,216,149,248,40,105,180,199,194,141,75,181,182,158,60,83,236,134,22,176,177,55,54,130,46,80,92,50,83,148,243,121,59,75,169,21,247,172,177,198,107,132,16,81,98,143,62,44,212,3,249,175,113,226,51,74,125,5,153,2,91,191,160,92,150,34,125,169,163,124,158,65,78,210,144,132,171,41,204,43,251,25,168,72,210,217,127,54,102,74,69,9,5,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ActivityFolderEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7221cfd7-6dcc-48dd-bc84-c7f04215dde0"));
		}

		#endregion

	}

	#endregion


	#region Class: ActivityFolderEventsProcess

	/// <exclude/>
	public class ActivityFolderEventsProcess : ActivityFolder_BaseEventsProcess
	{

		public ActivityFolderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

