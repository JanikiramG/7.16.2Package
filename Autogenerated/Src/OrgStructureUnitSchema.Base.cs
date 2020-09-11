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

	#region Class: OrgStructureUnitSchema

	/// <exclude/>
	public class OrgStructureUnitSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public OrgStructureUnitSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OrgStructureUnitSchema(OrgStructureUnitSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OrgStructureUnitSchema(OrgStructureUnitSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("92ac6269-362a-4cd2-9574-28f12be3ab78");
			RealUId = new Guid("92ac6269-362a-4cd2-9574-28f12be3ab78");
			Name = "OrgStructureUnit";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeHierarchyColumn() {
			base.InitializeHierarchyColumn();
			HierarchyColumn = CreateParentColumn();
			if (Columns.FindByUId(HierarchyColumn.UId) == null) {
				Columns.Add(HierarchyColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("3ca63a6c-408e-4eda-8709-b90f6e53b100")) == null) {
				Columns.Add(CreateHeadColumn());
			}
			if (Columns.FindByUId(new Guid("df2a3551-db10-4978-b899-7a39b12d8cba")) == null) {
				Columns.Add(CreateFullNameColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("8858643f-8a0c-4296-9a67-5554a18ca191"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("92ac6269-362a-4cd2-9574-28f12be3ab78"),
				ModifiedInSchemaUId = new Guid("92ac6269-362a-4cd2-9574-28f12be3ab78"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateHeadColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("3ca63a6c-408e-4eda-8709-b90f6e53b100"),
				Name = @"Head",
				ReferenceSchemaUId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("92ac6269-362a-4cd2-9574-28f12be3ab78"),
				ModifiedInSchemaUId = new Guid("92ac6269-362a-4cd2-9574-28f12be3ab78"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateParentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("862f87f3-a9a3-43a5-9757-e02462c4af43"),
				Name = @"Parent",
				ReferenceSchemaUId = new Guid("92ac6269-362a-4cd2-9574-28f12be3ab78"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("92ac6269-362a-4cd2-9574-28f12be3ab78"),
				ModifiedInSchemaUId = new Guid("92ac6269-362a-4cd2-9574-28f12be3ab78"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateFullNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("df2a3551-db10-4978-b899-7a39b12d8cba"),
				Name = @"FullName",
				CreatedInSchemaUId = new Guid("92ac6269-362a-4cd2-9574-28f12be3ab78"),
				ModifiedInSchemaUId = new Guid("92ac6269-362a-4cd2-9574-28f12be3ab78"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				IsLocalizable = true
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateOrgStructureUnitEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateOrgStructureUnitEventsProcessSchema() {
			var schema = new OrgStructureUnitEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new OrgStructureUnit(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OrgStructureUnit_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OrgStructureUnitSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OrgStructureUnitSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("92ac6269-362a-4cd2-9574-28f12be3ab78"));
		}

		#endregion

	}

	#endregion

	#region Class: OrgStructureUnit

	/// <summary>
	/// Organization structure item.
	/// </summary>
	public class OrgStructureUnit : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public OrgStructureUnit(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OrgStructureUnit";
		}

		public OrgStructureUnit(OrgStructureUnit source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Name.
		/// </summary>
		public string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

		/// <exclude/>
		public Guid HeadId {
			get {
				return GetTypedColumnValue<Guid>("HeadId");
			}
			set {
				SetColumnValue("HeadId", value);
				_head = null;
			}
		}

		/// <exclude/>
		public string HeadName {
			get {
				return GetTypedColumnValue<string>("HeadName");
			}
			set {
				SetColumnValue("HeadName", value);
				if (_head != null) {
					_head.Name = value;
				}
			}
		}

		private Employee _head;
		/// <summary>
		/// Head.
		/// </summary>
		public Employee Head {
			get {
				return _head ??
					(_head = LookupColumnEntities.GetEntity("Head") as Employee);
			}
		}

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

		private OrgStructureUnit _parent;
		/// <summary>
		/// Parent department.
		/// </summary>
		public OrgStructureUnit Parent {
			get {
				return _parent ??
					(_parent = LookupColumnEntities.GetEntity("Parent") as OrgStructureUnit);
			}
		}

		/// <summary>
		/// Full name.
		/// </summary>
		public string FullName {
			get {
				return GetTypedColumnValue<string>("FullName");
			}
			set {
				SetColumnValue("FullName", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OrgStructureUnit_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("OrgStructureUnitDeleted", e);
			Saved += (s, e) => ThrowEvent("OrgStructureUnitSaved", e);
			Saving += (s, e) => ThrowEvent("OrgStructureUnitSaving", e);
			Validating += (s, e) => ThrowEvent("OrgStructureUnitValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OrgStructureUnit(this);
		}

		#endregion

	}

	#endregion

	#region Class: OrgStructureUnit_BaseEventsProcess

	/// <exclude/>
	public partial class OrgStructureUnit_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : OrgStructureUnit
	{

		public OrgStructureUnit_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OrgStructureUnit_BaseEventsProcess";
			SchemaUId = new Guid("92ac6269-362a-4cd2-9574-28f12be3ab78");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("92ac6269-362a-4cd2-9574-28f12be3ab78");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _saving;
		public ProcessFlowElement Saving {
			get {
				return _saving ?? (_saving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "Saving",
					SchemaElementUId = new Guid("048a5ac7-1dcb-4a4d-ba2f-0626a2b6489f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _orgStructureUnitSaving;
		public ProcessFlowElement OrgStructureUnitSaving {
			get {
				return _orgStructureUnitSaving ?? (_orgStructureUnitSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OrgStructureUnitSaving",
					SchemaElementUId = new Guid("0fba99de-2a87-4039-a504-d681b523d964"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _updateFullName;
		public ProcessScriptTask UpdateFullName {
			get {
				return _updateFullName ?? (_updateFullName = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "UpdateFullName",
					SchemaElementUId = new Guid("7011afe9-1b23-4e29-9d31-aff6b12bfaae"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = UpdateFullNameExecute,
				});
			}
		}

		private ProcessFlowElement _saved;
		public ProcessFlowElement Saved {
			get {
				return _saved ?? (_saved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "Saved",
					SchemaElementUId = new Guid("72f5e463-789a-4e91-a155-d20b4c7d53d0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _orgStructureUnitSaved;
		public ProcessFlowElement OrgStructureUnitSaved {
			get {
				return _orgStructureUnitSaved ?? (_orgStructureUnitSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OrgStructureUnitSaved",
					SchemaElementUId = new Guid("588d1821-3d16-4313-bd01-e2f0b675e2ec"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _updateFullNameChild;
		public ProcessScriptTask UpdateFullNameChild {
			get {
				return _updateFullNameChild ?? (_updateFullNameChild = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "UpdateFullNameChild",
					SchemaElementUId = new Guid("bd06ab1d-0fe7-4c45-8f65-37a50b0a5806"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = UpdateFullNameChildExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Saving.SchemaElementUId] = new Collection<ProcessFlowElement> { Saving };
			FlowElements[OrgStructureUnitSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { OrgStructureUnitSaving };
			FlowElements[UpdateFullName.SchemaElementUId] = new Collection<ProcessFlowElement> { UpdateFullName };
			FlowElements[Saved.SchemaElementUId] = new Collection<ProcessFlowElement> { Saved };
			FlowElements[OrgStructureUnitSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { OrgStructureUnitSaved };
			FlowElements[UpdateFullNameChild.SchemaElementUId] = new Collection<ProcessFlowElement> { UpdateFullNameChild };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Saving":
						break;
					case "OrgStructureUnitSaving":
						e.Context.QueueTasks.Enqueue("UpdateFullName");
						break;
					case "UpdateFullName":
						break;
					case "Saved":
						break;
					case "OrgStructureUnitSaved":
						e.Context.QueueTasks.Enqueue("UpdateFullNameChild");
						break;
					case "UpdateFullNameChild":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("OrgStructureUnitSaving");
			ActivatedEventElements.Add("OrgStructureUnitSaved");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "Saving":
					context.QueueTasks.Dequeue();
					break;
				case "OrgStructureUnitSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "OrgStructureUnitSaving";
					result = OrgStructureUnitSaving.Execute(context);
					break;
				case "UpdateFullName":
					context.QueueTasks.Dequeue();
					context.SenderName = "UpdateFullName";
					result = UpdateFullName.Execute(context, UpdateFullNameExecute);
					break;
				case "Saved":
					context.QueueTasks.Dequeue();
					break;
				case "OrgStructureUnitSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "OrgStructureUnitSaved";
					result = OrgStructureUnitSaved.Execute(context);
					break;
				case "UpdateFullNameChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "UpdateFullNameChild";
					result = UpdateFullNameChild.Execute(context, UpdateFullNameChildExecute);
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

		public virtual bool UpdateFullNameExecute(ProcessExecutingContext context) {
			UpdateFullNameColumn();
			return true;
		}

		public virtual bool UpdateFullNameChildExecute(ProcessExecutingContext context) {
			UpdateFullNameColumnChild(Entity);
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "OrgStructureUnitSaving":
							if (ActivatedEventElements.Contains("OrgStructureUnitSaving")) {
							context.QueueTasks.Enqueue("OrgStructureUnitSaving");
						}
						break;
					case "OrgStructureUnitSaved":
							if (ActivatedEventElements.Contains("OrgStructureUnitSaved")) {
							context.QueueTasks.Enqueue("OrgStructureUnitSaved");
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

	#region Class: OrgStructureUnit_BaseEventsProcess

	/// <exclude/>
	public class OrgStructureUnit_BaseEventsProcess : OrgStructureUnit_BaseEventsProcess<OrgStructureUnit>
	{

		public OrgStructureUnit_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OrgStructureUnit_BaseEventsProcess

	public partial class OrgStructureUnit_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void UpdateFullNameColumn() {
			string fullName = Entity.PrimaryDisplayColumnValue;
						Guid parentId = Entity.HierarchyColumnValue;
						if (parentId.IsNotEmpty()) {
							EntitySchema parentSchema = UserConnection.EntitySchemaManager.GetInstanceByName("OrgStructureUnit");
							Entity parentEntity = parentSchema.CreateEntity(UserConnection);
							if (parentEntity.FetchFromDB(parentSchema.PrimaryColumn.Name, parentId)) {
								string parentFullName = parentEntity.GetTypedColumnValue<string>("FullName");
								fullName = string.Concat(fullName, "/", parentFullName);
							}
						}
						Entity.SetColumnValue("FullName", fullName);
		}

		public virtual void UpdateFullNameColumnChild(Entity parentEntity) {
			Guid parentId = parentEntity.PrimaryColumnValue;
			string fullName = parentEntity.GetTypedColumnValue<string>("FullName");
			EntityCollection children = GetChildOrgStructureUnit(parentId);
			foreach (Entity child in children) {
				string childName = child.PrimaryDisplayColumnValue;
				string childFullName = string.Concat(childName, '/', fullName);
				child.SetColumnValue("FullName", childFullName);
				child.Save();
			}
		}

		public virtual EntityCollection GetChildOrgStructureUnit(Guid parentId) {
			EntitySchemaQuery esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "OrgStructureUnit");
						esq.AddAllSchemaColumns();
						IEntitySchemaQueryFilterItem filter = esq.CreateFilterWithParameters(
						FilterComparisonType.Equal, esq.RootSchema.HierarchyColumn.Name, parentId);
						esq.Filters.Add(filter);
						return esq.GetEntityCollection(UserConnection);
		}

		#endregion

	}

	#endregion

	#region Class: OrgStructureUnitEventsProcessSchema

	/// <exclude/>
	public class OrgStructureUnitEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public OrgStructureUnitEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public OrgStructureUnitEventsProcessSchema(OrgStructureUnitEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "OrgStructureUnit_BaseEventsProcess";
			UId = new Guid("0eaa4593-2425-483e-9cb1-2a302ace995d");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			CreatedInSchemaUId = Guid.Empty;
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
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess saving = CreateSavingEventSubProcess();
			FlowElements.Add(saving);
			ProcessSchemaEventSubProcess saved = CreateSavedEventSubProcess();
			FlowElements.Add(saved);
			ProcessSchemaStartMessageEvent orgstructureunitsaving = CreateOrgStructureUnitSavingStartMessageEvent();
			saving.FlowElements.Add(orgstructureunitsaving);
			ProcessSchemaScriptTask updatefullname = CreateUpdateFullNameScriptTask();
			saving.FlowElements.Add(updatefullname);
			ProcessSchemaStartMessageEvent orgstructureunitsaved = CreateOrgStructureUnitSavedStartMessageEvent();
			saved.FlowElements.Add(orgstructureunitsaved);
			ProcessSchemaScriptTask updatefullnamechild = CreateUpdateFullNameChildScriptTask();
			saved.FlowElements.Add(updatefullnamechild);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("57faaed1-27a6-43f2-a958-2aa16c35b2ad"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("0eaa4593-2425-483e-9cb1-2a302ace995d"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0eaa4593-2425-483e-9cb1-2a302ace995d"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0fba99de-2a87-4039-a504-d681b523d964"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7011afe9-1b23-4e29-9d31-aff6b12bfaae"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("35f732e6-db03-41fb-9d7f-c56e25428b2a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("0eaa4593-2425-483e-9cb1-2a302ace995d"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0eaa4593-2425-483e-9cb1-2a302ace995d"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("588d1821-3d16-4313-bd01-e2f0b675e2ec"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bd06ab1d-0fe7-4c45-8f65-37a50b0a5806"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("32508f70-b2de-4602-b5f4-73080b15b57f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("0eaa4593-2425-483e-9cb1-2a302ace995d"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("0eaa4593-2425-483e-9cb1-2a302ace995d"),
				Name = @"LaneSet1",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("e56a2118-cb6c-436a-97f0-dee5c4cd18fc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("32508f70-b2de-4602-b5f4-73080b15b57f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("0eaa4593-2425-483e-9cb1-2a302ace995d"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("0eaa4593-2425-483e-9cb1-2a302ace995d"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSavingEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSaving = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("048a5ac7-1dcb-4a4d-ba2f-0626a2b6489f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e56a2118-cb6c-436a-97f0-dee5c4cd18fc"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("0eaa4593-2425-483e-9cb1-2a302ace995d"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0eaa4593-2425-483e-9cb1-2a302ace995d"),
				Name = @"Saving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(60, 158),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(300, 161),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSaving;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOrgStructureUnitSavingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("0fba99de-2a87-4039-a504-d681b523d964"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("048a5ac7-1dcb-4a4d-ba2f-0626a2b6489f"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("0eaa4593-2425-483e-9cb1-2a302ace995d"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OrgStructureUnitSaving",
				ModifiedInSchemaUId = new Guid("0eaa4593-2425-483e-9cb1-2a302ace995d"),
				Name = @"OrgStructureUnitSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(39, 67),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateUpdateFullNameScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7011afe9-1b23-4e29-9d31-aff6b12bfaae"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("048a5ac7-1dcb-4a4d-ba2f-0626a2b6489f"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("0eaa4593-2425-483e-9cb1-2a302ace995d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0eaa4593-2425-483e-9cb1-2a302ace995d"),
				Name = @"UpdateFullName",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(196, 53),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,72,73,44,73,117,43,205,201,241,75,204,77,117,206,207,41,205,205,211,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,52,134,247,67,36,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSavedEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSaved = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("72f5e463-789a-4e91-a155-d20b4c7d53d0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e56a2118-cb6c-436a-97f0-dee5c4cd18fc"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("0eaa4593-2425-483e-9cb1-2a302ace995d"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0eaa4593-2425-483e-9cb1-2a302ace995d"),
				Name = @"Saved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(80, 368),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(300, 160),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSaved;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOrgStructureUnitSavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("588d1821-3d16-4313-bd01-e2f0b675e2ec"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("72f5e463-789a-4e91-a155-d20b4c7d53d0"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("0eaa4593-2425-483e-9cb1-2a302ace995d"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OrgStructureUnitSaved",
				ModifiedInSchemaUId = new Guid("0eaa4593-2425-483e-9cb1-2a302ace995d"),
				Name = @"OrgStructureUnitSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(74, 60),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateUpdateFullNameChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("bd06ab1d-0fe7-4c45-8f65-37a50b0a5806"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("72f5e463-789a-4e91-a155-d20b4c7d53d0"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("0eaa4593-2425-483e-9cb1-2a302ace995d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0eaa4593-2425-483e-9cb1-2a302ace995d"),
				Name = @"UpdateFullNameChild",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(186, 46),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,72,73,44,73,117,43,205,201,241,75,204,77,117,206,207,41,205,205,115,206,200,204,73,209,112,205,43,201,44,169,212,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,99,39,31,45,47,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateUpdateFullNameColumnMethod());
			Methods.Add(CreateUpdateFullNameColumnChildMethod());
			Methods.Add(CreateGetChildOrgStructureUnitMethod());
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

		protected virtual SchemaMethod CreateUpdateFullNameColumnMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3e15873e-7361-422c-b7c0-ad3c5db2a302"),
				Name = "UpdateFullNameColumn",
				CreatedInSchemaUId = new Guid("0eaa4593-2425-483e-9cb1-2a302ace995d"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,146,77,110,131,48,16,133,215,228,20,22,43,35,33,247,0,148,46,66,66,202,162,105,37,154,238,45,51,1,75,96,208,48,44,80,213,187,55,200,230,175,221,88,178,222,155,249,252,102,220,19,106,83,178,251,80,215,87,217,0,139,217,217,144,166,81,124,160,110,36,142,39,221,119,181,28,147,182,30,26,243,37,235,1,162,131,231,121,151,65,23,172,147,8,134,178,98,45,122,213,128,18,85,245,207,175,239,140,207,118,145,245,215,150,206,77,71,35,15,2,246,61,233,158,109,144,171,10,26,233,26,187,75,204,110,61,96,210,26,3,138,116,107,196,214,250,38,141,44,1,197,5,40,51,61,73,163,224,56,78,65,184,255,142,101,78,56,40,26,16,110,70,147,31,68,27,146,99,184,75,188,67,138,4,65,18,88,141,239,233,174,201,154,199,37,79,129,84,149,98,219,156,142,124,215,203,205,209,14,68,76,79,11,151,193,45,233,189,222,174,193,10,233,186,140,29,227,17,242,115,236,160,216,12,247,217,22,190,112,127,46,154,99,122,155,149,90,147,120,164,80,146,248,44,132,204,127,242,195,63,76,87,253,115,152,15,199,206,129,54,216,13,46,92,254,78,16,253,2,165,212,238,179,77,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateFullNameColumnChildMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d8d1cdf6-b963-4f3b-bbf8-f800dd0ad47b"),
				Name = "UpdateFullNameColumnChild",
				CreatedInSchemaUId = new Guid("0eaa4593-2425-483e-9cb1-2a302ace995d"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("06034462-bd78-4f36-a8e1-10b95a6262d3"),
				Name = "parentEntity",
				CreatedInSchemaUId = new Guid("0eaa4593-2425-483e-9cb1-2a302ace995d"),
				ModifiedInSchemaUId = new Guid("0eaa4593-2425-483e-9cb1-2a302ace995d"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,144,201,10,194,48,16,134,207,246,41,130,23,83,40,250,0,46,151,186,224,69,5,151,123,72,167,58,144,166,37,78,132,34,190,187,177,233,234,109,102,152,239,203,252,217,89,76,88,33,12,104,218,39,108,89,151,27,77,72,229,244,100,48,19,166,140,115,101,51,125,19,202,194,60,120,146,65,125,103,169,85,234,32,50,248,71,118,64,151,178,128,164,199,44,60,178,226,227,109,13,141,195,121,224,247,221,154,2,73,152,107,38,31,168,18,103,114,70,39,137,127,221,209,220,207,100,172,36,107,224,170,145,120,115,168,227,211,220,128,144,15,198,189,200,227,12,59,79,200,222,193,168,190,182,154,213,231,86,117,19,109,141,207,66,137,97,194,1,180,237,114,250,241,52,206,181,20,196,91,101,196,38,179,73,212,126,136,59,109,228,159,56,187,20,157,183,151,62,26,170,123,132,120,1,119,237,231,11,218,52,190,166,150,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetChildOrgStructureUnitMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f751f69b-a14f-47aa-9f52-fb1784c6cc3e"),
				Name = "GetChildOrgStructureUnit",
				CreatedInSchemaUId = new Guid("0eaa4593-2425-483e-9cb1-2a302ace995d"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "EntityCollection"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2964e3da-d042-42ec-95c5-ee68ce6260c7"),
				Name = "parentId",
				CreatedInSchemaUId = new Guid("0eaa4593-2425-483e-9cb1-2a302ace995d"),
				ModifiedInSchemaUId = new Guid("0eaa4593-2425-483e-9cb1-2a302ace995d"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,144,61,110,195,48,12,133,103,247,20,66,38,7,48,116,129,160,67,96,184,173,135,254,166,65,103,194,102,98,1,18,149,80,20,10,223,190,178,57,180,72,55,18,143,239,227,35,59,18,39,243,97,152,48,192,123,70,158,13,166,171,185,55,132,223,166,187,213,234,99,66,110,35,17,14,226,34,217,191,3,207,64,112,70,110,204,230,149,207,7,225,60,72,102,60,146,147,205,118,119,87,85,85,225,218,253,56,238,189,87,67,27,125,14,148,106,85,251,127,203,30,156,23,228,94,48,152,211,90,150,84,11,163,101,4,65,85,191,156,76,111,192,16,176,52,169,94,64,42,180,49,92,128,93,138,244,57,95,208,118,215,12,190,89,237,31,49,138,110,177,79,14,25,120,152,102,141,98,95,10,167,49,197,135,36,253,248,155,90,145,105,73,95,107,20,213,24,203,137,180,82,31,81,244,128,130,242,250,157,155,103,109,119,63,28,53,124,66,107,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OrgStructureUnitEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0eaa4593-2425-483e-9cb1-2a302ace995d"));
		}

		#endregion

	}

	#endregion


	#region Class: OrgStructureUnitEventsProcess

	/// <exclude/>
	public class OrgStructureUnitEventsProcess : OrgStructureUnit_BaseEventsProcess
	{

		public OrgStructureUnitEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

