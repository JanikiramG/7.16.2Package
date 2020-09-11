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
	using Terrasoft.Core.OperationLog;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;
	using Terrasoft.Web.Common;

	#region Class: SysAdminUnit_Translation_TerrasoftSchema

	/// <exclude/>
	public class SysAdminUnit_Translation_TerrasoftSchema : Terrasoft.Configuration.SysAdminUnit_LDAP_TerrasoftSchema
	{

		#region Constructors: Public

		public SysAdminUnit_Translation_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysAdminUnit_Translation_TerrasoftSchema(SysAdminUnit_Translation_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysAdminUnit_Translation_TerrasoftSchema(SysAdminUnit_Translation_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIUSysAdminUnitNameIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = true
			};
			index.UId = new Guid("a09035f6-13ab-41d9-af1c-c095e5cf9ac1");
			index.Name = "IUSysAdminUnitName";
			index.CreatedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c");
			index.ModifiedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c");
			index.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			EntitySchemaIndexColumn nameIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("5c950219-374c-425c-8082-7e7de785ba20"),
				ColumnUId = new Guid("736c30a7-c0ec-4fa9-b034-2552b319b633"),
				CreatedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				ModifiedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(nameIndexColumn);
			EntitySchemaIndexColumn parentRoleIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("3c1b73d7-6adf-4567-88c8-8b95952dc03c"),
				ColumnUId = new Guid("fa4483b3-a2db-4651-a462-689be18351e7"),
				CreatedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				ModifiedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				CreatedInPackageId = new Guid("81adfa8e-1f43-43a3-9652-1b782e1a0cf1"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(parentRoleIdIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("d6ab5682-2462-490a-91f7-ea9344af2a2c");
			Name = "SysAdminUnit_Translation_Terrasoft";
			ParentSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c");
			ExtendParent = true;
			CreatedInPackageId = new Guid("0b3cc894-bd0d-4e1b-bb7d-87203708d013");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateSysCultureColumn() {
			EntitySchemaColumn column = base.CreateSysCultureColumn();
			column.RequirementType = EntitySchemaColumnRequirementType.None;
			column.ModifiedInSchemaUId = new Guid("d6ab5682-2462-490a-91f7-ea9344af2a2c");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIUSysAdminUnitNameIndex());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysAdminUnit_Translation_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysAdminUnit_Translation_TerrasoftEventsProcessSchema() {
			var schema = new SysAdminUnit_Translation_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysAdminUnit_Translation_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysAdminUnit_TranslationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysAdminUnit_Translation_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysAdminUnit_Translation_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d6ab5682-2462-490a-91f7-ea9344af2a2c"));
		}

		#endregion

	}

	#endregion

	#region Class: SysAdminUnit_Translation_Terrasoft

	/// <summary>
	/// System administration object.
	/// </summary>
	public class SysAdminUnit_Translation_Terrasoft : Terrasoft.Configuration.SysAdminUnit_LDAP_Terrasoft
	{

		#region Constructors: Public

		public SysAdminUnit_Translation_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysAdminUnit_Translation_Terrasoft";
		}

		public SysAdminUnit_Translation_Terrasoft(SysAdminUnit_Translation_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysAdminUnit_TranslationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserted += (s, e) => ThrowEvent("SysAdminUnit_Translation_TerrasoftInserted", e);
			Saving += (s, e) => ThrowEvent("SysAdminUnit_Translation_TerrasoftSaving", e);
			Updated += (s, e) => ThrowEvent("SysAdminUnit_Translation_TerrasoftUpdated", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysAdminUnit_Translation_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysAdminUnit_TranslationEventsProcess

	/// <exclude/>
	public partial class SysAdminUnit_TranslationEventsProcess<TEntity> : Terrasoft.Configuration.SysAdminUnit_LDAPEventsProcess<TEntity> where TEntity : SysAdminUnit_Translation_Terrasoft
	{

		public SysAdminUnit_TranslationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysAdminUnit_TranslationEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d6ab5682-2462-490a-91f7-ea9344af2a2c");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess3_55e01e3f9a55428eb509973525da177a;
		public ProcessFlowElement EventSubProcess3_55e01e3f9a55428eb509973525da177a {
			get {
				return _eventSubProcess3_55e01e3f9a55428eb509973525da177a ?? (_eventSubProcess3_55e01e3f9a55428eb509973525da177a = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3_55e01e3f9a55428eb509973525da177a",
					SchemaElementUId = new Guid("55e01e3f-9a55-428e-b509-973525da177a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _sysAdminUnitSavingStartMessage;
		public ProcessFlowElement SysAdminUnitSavingStartMessage {
			get {
				return _sysAdminUnitSavingStartMessage ?? (_sysAdminUnitSavingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SysAdminUnitSavingStartMessage",
					SchemaElementUId = new Guid("5c9aea74-8229-4335-a925-600449cf450b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _sysAdminUnitSavingScriptTask;
		public ProcessScriptTask SysAdminUnitSavingScriptTask {
			get {
				return _sysAdminUnitSavingScriptTask ?? (_sysAdminUnitSavingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SysAdminUnitSavingScriptTask",
					SchemaElementUId = new Guid("a008aee2-aea4-4146-9332-4794350a44cd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SysAdminUnitSavingScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess3_55e01e3f9a55428eb509973525da177a.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3_55e01e3f9a55428eb509973525da177a };
			FlowElements[SysAdminUnitSavingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SysAdminUnitSavingStartMessage };
			FlowElements[SysAdminUnitSavingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SysAdminUnitSavingScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess3_55e01e3f9a55428eb509973525da177a":
						break;
					case "SysAdminUnitSavingStartMessage":
						e.Context.QueueTasks.Enqueue("SysAdminUnitSavingScriptTask");
						break;
					case "SysAdminUnitSavingScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("SysAdminUnitSavingStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess3_55e01e3f9a55428eb509973525da177a":
					context.QueueTasks.Dequeue();
					break;
				case "SysAdminUnitSavingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysAdminUnitSavingStartMessage";
					result = SysAdminUnitSavingStartMessage.Execute(context);
					break;
				case "SysAdminUnitSavingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysAdminUnitSavingScriptTask";
					result = SysAdminUnitSavingScriptTask.Execute(context, SysAdminUnitSavingScriptTaskExecute);
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

		public virtual bool SysAdminUnitSavingScriptTaskExecute(ProcessExecutingContext context) {
			EntitySchemaColumn sysCultureColumn = Entity.Schema.Columns.GetByName("SysCulture");
			var sysCultureId = Entity.GetTypedColumnValue<Guid>(sysCultureColumn.ColumnValueName);
			if (sysCultureId == Guid.Empty) {
				var sysCultureUtilities = new SysCultureUtilities(UserConnection);
				Guid sysDefaultCultureId = sysCultureUtilities.GetDefaultCulture();
				Entity.SetColumnValue(sysCultureColumn.ColumnValueName, sysDefaultCultureId);
			} 
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "SysAdminUnit_Translation_TerrasoftSaving":
							if (ActivatedEventElements.Contains("SysAdminUnitSavingStartMessage")) {
							context.QueueTasks.Enqueue("SysAdminUnitSavingStartMessage");
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
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: SysAdminUnit_TranslationEventsProcess

	/// <exclude/>
	public class SysAdminUnit_TranslationEventsProcess : SysAdminUnit_TranslationEventsProcess<SysAdminUnit_Translation_Terrasoft>
	{

		public SysAdminUnit_TranslationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysAdminUnit_TranslationEventsProcess

	public partial class SysAdminUnit_TranslationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysAdminUnit_Translation_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class SysAdminUnit_Translation_TerrasoftEventsProcessSchema : Terrasoft.Configuration.SysAdminUnit_LDAP_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public SysAdminUnit_Translation_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysAdminUnit_Translation_TerrasoftEventsProcessSchema(SysAdminUnit_Translation_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysAdminUnit_TranslationEventsProcess";
			UId = new Guid("76e637b9-a019-4255-ad4b-d86c521044d5");
			CreatedInPackageId = new Guid("0b3cc894-bd0d-4e1b-bb7d-87203708d013");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet2_c54c7f562eb74ab9866a1ecbf31d4dd0 = CreateLaneSet2_c54c7f562eb74ab9866a1ecbf31d4dd0LaneSet();
			LaneSets.Add(schemaLaneSet2_c54c7f562eb74ab9866a1ecbf31d4dd0);
			ProcessSchemaLane schemaLane3_99b53862c5644ae59ff5a84741952be3 = CreateLane3_99b53862c5644ae59ff5a84741952be3Lane();
			schemaLaneSet2_c54c7f562eb74ab9866a1ecbf31d4dd0.Lanes.Add(schemaLane3_99b53862c5644ae59ff5a84741952be3);
			ProcessSchemaEventSubProcess eventsubprocess3_55e01e3f9a55428eb509973525da177a = CreateEventSubProcess3_55e01e3f9a55428eb509973525da177aEventSubProcess();
			FlowElements.Add(eventsubprocess3_55e01e3f9a55428eb509973525da177a);
			ProcessSchemaStartMessageEvent sysadminunitsavingstartmessage = CreateSysAdminUnitSavingStartMessageStartMessageEvent();
			eventsubprocess3_55e01e3f9a55428eb509973525da177a.FlowElements.Add(sysadminunitsavingstartmessage);
			ProcessSchemaScriptTask sysadminunitsavingscripttask = CreateSysAdminUnitSavingScriptTaskScriptTask();
			eventsubprocess3_55e01e3f9a55428eb509973525da177a.FlowElements.Add(sysadminunitsavingscripttask);
			FlowElements.Add(CreateSequenceFlow7_bccc150f7f7144c58c3ae7c5abee2ffbSequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7_bccc150f7f7144c58c3ae7c5abee2ffbSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7_bccc150f7f7144c58c3ae7c5abee2ffb",
				UId = new Guid("bccc150f-7f71-44c5-8c3a-e7c5abee2ffb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				CreatedInPackageId = new Guid("0b3cc894-bd0d-4e1b-bb7d-87203708d013"),
				CreatedInSchemaUId = new Guid("76e637b9-a019-4255-ad4b-d86c521044d5"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76e637b9-a019-4255-ad4b-d86c521044d5"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5c9aea74-8229-4335-a925-600449cf450b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a008aee2-aea4-4146-9332-4794350a44cd"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet2_c54c7f562eb74ab9866a1ecbf31d4dd0LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet2_c54c7f562eb74ab9866a1ecbf31d4dd0 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("c54c7f56-2eb7-4ab9-866a-1ecbf31d4dd0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				CreatedInPackageId = new Guid("0b3cc894-bd0d-4e1b-bb7d-87203708d013"),
				CreatedInSchemaUId = new Guid("76e637b9-a019-4255-ad4b-d86c521044d5"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("76e637b9-a019-4255-ad4b-d86c521044d5"),
				Name = @"LaneSet2_c54c7f562eb74ab9866a1ecbf31d4dd0",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet2_c54c7f562eb74ab9866a1ecbf31d4dd0;
		}

		protected virtual ProcessSchemaLane CreateLane3_99b53862c5644ae59ff5a84741952be3Lane() {
			ProcessSchemaLane schemaLane3_99b53862c5644ae59ff5a84741952be3 = new ProcessSchemaLane(this) {
				UId = new Guid("99b53862-c564-4ae5-9ff5-a84741952be3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c54c7f56-2eb7-4ab9-866a-1ecbf31d4dd0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("0b3cc894-bd0d-4e1b-bb7d-87203708d013"),
				CreatedInSchemaUId = new Guid("76e637b9-a019-4255-ad4b-d86c521044d5"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("76e637b9-a019-4255-ad4b-d86c521044d5"),
				Name = @"Lane3_99b53862c5644ae59ff5a84741952be3",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane3_99b53862c5644ae59ff5a84741952be3;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3_55e01e3f9a55428eb509973525da177aEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3_55e01e3f9a55428eb509973525da177a = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("55e01e3f-9a55-428e-b509-973525da177a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("99b53862-c564-4ae5-9ff5-a84741952be3"),
				CreatedInOwnerSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				CreatedInPackageId = new Guid("0b3cc894-bd0d-4e1b-bb7d-87203708d013"),
				CreatedInSchemaUId = new Guid("76e637b9-a019-4255-ad4b-d86c521044d5"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("76e637b9-a019-4255-ad4b-d86c521044d5"),
				Name = @"EventSubProcess3_55e01e3f9a55428eb509973525da177a",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(55, 32),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(485, 228),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3_55e01e3f9a55428eb509973525da177a;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSysAdminUnitSavingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5c9aea74-8229-4335-a925-600449cf450b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("55e01e3f-9a55-428e-b509-973525da177a"),
				CreatedInOwnerSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				CreatedInPackageId = new Guid("0b3cc894-bd0d-4e1b-bb7d-87203708d013"),
				CreatedInSchemaUId = new Guid("76e637b9-a019-4255-ad4b-d86c521044d5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysAdminUnitSaving",
				ModifiedInSchemaUId = new Guid("76e637b9-a019-4255-ad4b-d86c521044d5"),
				Name = @"SysAdminUnitSavingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(50, 78),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSysAdminUnitSavingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a008aee2-aea4-4146-9332-4794350a44cd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("55e01e3f-9a55-428e-b509-973525da177a"),
				CreatedInOwnerSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				CreatedInPackageId = new Guid("0b3cc894-bd0d-4e1b-bb7d-87203708d013"),
				CreatedInSchemaUId = new Guid("76e637b9-a019-4255-ad4b-d86c521044d5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("76e637b9-a019-4255-ad4b-d86c521044d5"),
				Name = @"SysAdminUnitSavingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(165, 64),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,144,205,10,194,48,16,132,207,237,83,4,79,41,72,94,192,159,131,181,20,47,94,170,222,67,187,197,64,147,150,100,163,4,241,221,77,172,63,173,10,30,119,119,230,155,76,50,133,2,93,81,30,65,242,180,109,172,84,196,56,147,218,6,173,134,199,98,65,178,187,138,245,50,214,175,13,203,1,87,110,203,37,208,73,241,242,76,146,89,124,226,122,64,217,84,111,130,183,236,92,7,85,143,56,240,198,194,60,183,162,90,210,207,84,54,144,132,12,143,21,53,161,99,236,130,4,51,203,100,135,46,33,151,56,26,39,239,81,52,2,5,24,255,0,5,103,82,124,95,232,222,128,78,91,165,160,68,209,42,159,18,5,100,128,172,161,230,94,61,108,241,3,29,42,141,149,52,64,158,63,6,56,232,241,183,228,244,87,174,199,93,73,172,193,79,138,160,182,48,187,1,185,145,144,124,181,1,0,0 }
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
				UId = new Guid("a1f8c6a6-798f-4d77-9ab8-0688bc1d077a"),
				Name = "Terrasoft.Core.OperationLog",
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
				UId = new Guid("18e14ca5-82d5-49d5-b3d8-12c73a25a787"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysAdminUnit_Translation_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("76e637b9-a019-4255-ad4b-d86c521044d5"));
		}

		#endregion

	}

	#endregion

}

