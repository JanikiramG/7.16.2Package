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
	using Terrasoft.Configuration.PRM;
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

	#region Class: FundSchema

	/// <exclude/>
	public class FundSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public FundSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public FundSchema(FundSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public FundSchema(FundSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9a734110-378e-4108-9383-726930984f2e");
			RealUId = new Guid("9a734110-378e-4108-9383-726930984f2e");
			Name = "Fund";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63");
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

		protected override void InitializeMasterRecordColumn() {
			base.InitializeMasterRecordColumn();
			MasterRecordColumn = CreatePartnershipColumn();
			if (Columns.FindByUId(MasterRecordColumn.UId) == null) {
				Columns.Add(MasterRecordColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("28c96aef-b95f-4da8-9621-0feb2a61ed83")) == null) {
				Columns.Add(CreateFundTypeColumn());
			}
			if (Columns.FindByUId(new Guid("39ce4498-d254-4474-af20-0caaacbdcbb5")) == null) {
				Columns.Add(CreateAmountColumn());
			}
			if (Columns.FindByUId(new Guid("30078a2c-c5e2-49a6-8021-a1dfd8d88654")) == null) {
				Columns.Add(CreateStartDateColumn());
			}
			if (Columns.FindByUId(new Guid("eb78c0d3-7890-45af-91ba-0058c0bd2106")) == null) {
				Columns.Add(CreateDueDateColumn());
			}
			if (Columns.FindByUId(new Guid("fb2c5d4f-1efc-4190-a62f-900e396966e7")) == null) {
				Columns.Add(CreateIsActiveColumn());
			}
			if (Columns.FindByUId(new Guid("76bc22c3-dd5e-49d4-9006-c132e499e915")) == null) {
				Columns.Add(CreateDescriptionColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateFundTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("28c96aef-b95f-4da8-9621-0feb2a61ed83"),
				Name = @"FundType",
				ReferenceSchemaUId = new Guid("b0f52d2c-d309-4fd7-8268-fc08a18244ae"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("9a734110-378e-4108-9383-726930984f2e"),
				ModifiedInSchemaUId = new Guid("9a734110-378e-4108-9383-726930984f2e"),
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63")
			};
		}

		protected virtual EntitySchemaColumn CreatePartnershipColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("7886b405-c0cf-4555-baa4-a21197de63a0"),
				Name = @"Partnership",
				ReferenceSchemaUId = new Guid("f247949a-7c07-4fc7-9a6a-31940b457e5d"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("9a734110-378e-4108-9383-726930984f2e"),
				ModifiedInSchemaUId = new Guid("9a734110-378e-4108-9383-726930984f2e"),
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63")
			};
		}

		protected virtual EntitySchemaColumn CreateAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("39ce4498-d254-4474-af20-0caaacbdcbb5"),
				Name = @"Amount",
				CreatedInSchemaUId = new Guid("9a734110-378e-4108-9383-726930984f2e"),
				ModifiedInSchemaUId = new Guid("9a734110-378e-4108-9383-726930984f2e"),
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63")
			};
		}

		protected virtual EntitySchemaColumn CreateStartDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("30078a2c-c5e2-49a6-8021-a1dfd8d88654"),
				Name = @"StartDate",
				CreatedInSchemaUId = new Guid("9a734110-378e-4108-9383-726930984f2e"),
				ModifiedInSchemaUId = new Guid("9a734110-378e-4108-9383-726930984f2e"),
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63")
			};
		}

		protected virtual EntitySchemaColumn CreateDueDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("eb78c0d3-7890-45af-91ba-0058c0bd2106"),
				Name = @"DueDate",
				CreatedInSchemaUId = new Guid("9a734110-378e-4108-9383-726930984f2e"),
				ModifiedInSchemaUId = new Guid("9a734110-378e-4108-9383-726930984f2e"),
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63")
			};
		}

		protected virtual EntitySchemaColumn CreateIsActiveColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("fb2c5d4f-1efc-4190-a62f-900e396966e7"),
				Name = @"IsActive",
				CreatedInSchemaUId = new Guid("9a734110-378e-4108-9383-726930984f2e"),
				ModifiedInSchemaUId = new Guid("9a734110-378e-4108-9383-726930984f2e"),
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63")
			};
		}

		protected virtual EntitySchemaColumn CreateDescriptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("76bc22c3-dd5e-49d4-9006-c132e499e915"),
				Name = @"Description",
				CreatedInSchemaUId = new Guid("9a734110-378e-4108-9383-726930984f2e"),
				ModifiedInSchemaUId = new Guid("9a734110-378e-4108-9383-726930984f2e"),
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63")
			};
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("05891835-e36d-412b-b0c5-d500d04627aa"),
				Name = @"Name",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("9a734110-378e-4108-9383-726930984f2e"),
				ModifiedInSchemaUId = new Guid("9a734110-378e-4108-9383-726930984f2e"),
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateFundEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateFundEventsProcessSchema() {
			var schema = new FundEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Fund(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Fund_PRMBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new FundSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new FundSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9a734110-378e-4108-9383-726930984f2e"));
		}

		#endregion

	}

	#endregion

	#region Class: Fund

	/// <summary>
	/// Fund.
	/// </summary>
	public class Fund : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public Fund(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Fund";
		}

		public Fund(Fund source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid FundTypeId {
			get {
				return GetTypedColumnValue<Guid>("FundTypeId");
			}
			set {
				SetColumnValue("FundTypeId", value);
				_fundType = null;
			}
		}

		/// <exclude/>
		public string FundTypeName {
			get {
				return GetTypedColumnValue<string>("FundTypeName");
			}
			set {
				SetColumnValue("FundTypeName", value);
				if (_fundType != null) {
					_fundType.Name = value;
				}
			}
		}

		private FundType _fundType;
		/// <summary>
		/// Name.
		/// </summary>
		public FundType FundType {
			get {
				return _fundType ??
					(_fundType = LookupColumnEntities.GetEntity("FundType") as FundType);
			}
		}

		/// <exclude/>
		public Guid PartnershipId {
			get {
				return GetTypedColumnValue<Guid>("PartnershipId");
			}
			set {
				SetColumnValue("PartnershipId", value);
				_partnership = null;
			}
		}

		/// <exclude/>
		public string PartnershipName {
			get {
				return GetTypedColumnValue<string>("PartnershipName");
			}
			set {
				SetColumnValue("PartnershipName", value);
				if (_partnership != null) {
					_partnership.Name = value;
				}
			}
		}

		private Partnership _partnership;
		/// <summary>
		/// Partnership.
		/// </summary>
		public Partnership Partnership {
			get {
				return _partnership ??
					(_partnership = LookupColumnEntities.GetEntity("Partnership") as Partnership);
			}
		}

		/// <summary>
		/// Amount.
		/// </summary>
		public Decimal Amount {
			get {
				return GetTypedColumnValue<Decimal>("Amount");
			}
			set {
				SetColumnValue("Amount", value);
			}
		}

		/// <summary>
		/// Start date.
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
		/// End.
		/// </summary>
		public DateTime DueDate {
			get {
				return GetTypedColumnValue<DateTime>("DueDate");
			}
			set {
				SetColumnValue("DueDate", value);
			}
		}

		/// <summary>
		/// Active.
		/// </summary>
		public bool IsActive {
			get {
				return GetTypedColumnValue<bool>("IsActive");
			}
			set {
				SetColumnValue("IsActive", value);
			}
		}

		/// <summary>
		/// Notes.
		/// </summary>
		public string Description {
			get {
				return GetTypedColumnValue<string>("Description");
			}
			set {
				SetColumnValue("Description", value);
			}
		}

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

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Fund_PRMBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("FundDeleted", e);
			Saving += (s, e) => ThrowEvent("FundSaving", e);
			Validating += (s, e) => ThrowEvent("FundValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Fund(this);
		}

		#endregion

	}

	#endregion

	#region Class: Fund_PRMBaseEventsProcess

	/// <exclude/>
	public partial class Fund_PRMBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : Fund
	{

		public Fund_PRMBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Fund_PRMBaseEventsProcess";
			SchemaUId = new Guid("9a734110-378e-4108-9383-726930984f2e");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("9a734110-378e-4108-9383-726930984f2e");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _onFundSaving;
		public ProcessFlowElement OnFundSaving {
			get {
				return _onFundSaving ?? (_onFundSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "OnFundSaving",
					SchemaElementUId = new Guid("70a0a1f5-ff4f-42fb-992c-c25e4d181463"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _fundSaving;
		public ProcessFlowElement FundSaving {
			get {
				return _fundSaving ?? (_fundSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "FundSaving",
					SchemaElementUId = new Guid("36a351d1-a8ab-410a-9544-45dfaa8ee242"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _fillNameFromFundType;
		public ProcessScriptTask FillNameFromFundType {
			get {
				return _fillNameFromFundType ?? (_fillNameFromFundType = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "FillNameFromFundType",
					SchemaElementUId = new Guid("3989db05-2b80-43b2-9cb0-f7983e6eb0b5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = FillNameFromFundTypeExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[OnFundSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { OnFundSaving };
			FlowElements[FundSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { FundSaving };
			FlowElements[FillNameFromFundType.SchemaElementUId] = new Collection<ProcessFlowElement> { FillNameFromFundType };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "OnFundSaving":
						break;
					case "FundSaving":
						e.Context.QueueTasks.Enqueue("FillNameFromFundType");
						break;
					case "FillNameFromFundType":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("FundSaving");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "OnFundSaving":
					context.QueueTasks.Dequeue();
					break;
				case "FundSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "FundSaving";
					result = FundSaving.Execute(context);
					break;
				case "FillNameFromFundType":
					context.QueueTasks.Dequeue();
					context.SenderName = "FillNameFromFundType";
					result = FillNameFromFundType.Execute(context, FillNameFromFundTypeExecute);
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

		public virtual bool FillNameFromFundTypeExecute(ProcessExecutingContext context) {
			CheckFundTypeDuplicate();
			FillName(); 
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "FundSaving":
							if (ActivatedEventElements.Contains("FundSaving")) {
							context.QueueTasks.Enqueue("FundSaving");
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

	#region Class: Fund_PRMBaseEventsProcess

	/// <exclude/>
	public class Fund_PRMBaseEventsProcess : Fund_PRMBaseEventsProcess<Fund>
	{

		public Fund_PRMBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Fund_PRMBaseEventsProcess

	public partial class Fund_PRMBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void FillName() {
			object fundTypeId = Entity.GetColumnValue("FundTypeId");
			if (fundTypeId == null) {
				return;
			}
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "FundType");
			esq.AddColumn("Id");
			esq.AddColumn("Name");
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", fundTypeId));
			EntityCollection collection = esq.GetEntityCollection(UserConnection);
			if (collection.Count == 0) {
				return;
			}
			Entity.SetColumnValue("Name", collection[0].GetColumnValue("Name"));
		}

		public virtual void CheckFundTypeDuplicate() {
			object id = Entity.GetColumnValue("Id");
			object fundTypeId = Entity.GetColumnValue("FundTypeId");
			object partnershipId = Entity.GetColumnValue("PartnershipId");
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "Fund");
			esq.AddColumn("Id");
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "FundType", fundTypeId));
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Partnership", partnershipId));
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.NotEqual, "Id", id));
			EntityCollection collection = esq.GetEntityCollection(UserConnection);
			if (collection.Count > 0) {
				throw new FundTypeDuplicateException(UserConnection.Workspace.ResourceStorage);
			}
		}

		#endregion

	}

	#endregion

	#region Class: FundEventsProcessSchema

	/// <exclude/>
	public class FundEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public FundEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public FundEventsProcessSchema(FundEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Fund_PRMBaseEventsProcess";
			UId = new Guid("79f24261-38bb-4413-a17a-a47f3ba9dc01");
			CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63");
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
			UseForceCompile = true;
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
			ProcessSchemaEventSubProcess onfundsaving = CreateOnFundSavingEventSubProcess();
			FlowElements.Add(onfundsaving);
			ProcessSchemaStartMessageEvent fundsaving = CreateFundSavingStartMessageEvent();
			onfundsaving.FlowElements.Add(fundsaving);
			ProcessSchemaScriptTask fillnamefromfundtype = CreateFillNameFromFundTypeScriptTask();
			onfundsaving.FlowElements.Add(fillnamefromfundtype);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("cda1189d-7431-4676-af11-f342f5925015"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63"),
				CreatedInSchemaUId = new Guid("79f24261-38bb-4413-a17a-a47f3ba9dc01"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("79f24261-38bb-4413-a17a-a47f3ba9dc01"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("36a351d1-a8ab-410a-9544-45dfaa8ee242"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3989db05-2b80-43b2-9cb0-f7983e6eb0b5"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("c81d1742-fb5f-4cca-81bb-688fda0df029"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63"),
				CreatedInSchemaUId = new Guid("79f24261-38bb-4413-a17a-a47f3ba9dc01"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("79f24261-38bb-4413-a17a-a47f3ba9dc01"),
				Name = @"LaneSet1",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("f580b4f1-a81c-47e4-9478-f4e948c148b9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c81d1742-fb5f-4cca-81bb-688fda0df029"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63"),
				CreatedInSchemaUId = new Guid("79f24261-38bb-4413-a17a-a47f3ba9dc01"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("79f24261-38bb-4413-a17a-a47f3ba9dc01"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateOnFundSavingEventSubProcess() {
			ProcessSchemaEventSubProcess schemaOnFundSaving = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("70a0a1f5-ff4f-42fb-992c-c25e4d181463"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f580b4f1-a81c-47e4-9478-f4e948c148b9"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63"),
				CreatedInSchemaUId = new Guid("79f24261-38bb-4413-a17a-a47f3ba9dc01"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("79f24261-38bb-4413-a17a-a47f3ba9dc01"),
				Name = @"OnFundSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(40, 58),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(300, 144),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaOnFundSaving;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateFundSavingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("36a351d1-a8ab-410a-9544-45dfaa8ee242"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("70a0a1f5-ff4f-42fb-992c-c25e4d181463"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63"),
				CreatedInSchemaUId = new Guid("79f24261-38bb-4413-a17a-a47f3ba9dc01"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"FundSaving",
				ModifiedInSchemaUId = new Guid("79f24261-38bb-4413-a17a-a47f3ba9dc01"),
				Name = @"FundSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(33, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateFillNameFromFundTypeScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3989db05-2b80-43b2-9cb0-f7983e6eb0b5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("70a0a1f5-ff4f-42fb-992c-c25e4d181463"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63"),
				CreatedInSchemaUId = new Guid("79f24261-38bb-4413-a17a-a47f3ba9dc01"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("79f24261-38bb-4413-a17a-a47f3ba9dc01"),
				Name = @"FillNameFromFundType",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(155, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,206,72,77,206,118,43,205,75,9,169,44,72,117,41,45,200,201,76,78,44,73,213,208,180,230,114,203,204,201,241,75,204,5,177,21,184,138,82,75,74,139,242,20,74,138,74,83,173,1,32,254,100,161,51,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateFillNameMethod());
			Methods.Add(CreateCheckFundTypeDuplicateMethod());
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
				UId = new Guid("17e3b7fe-0fe3-426a-849b-44aac3e32044"),
				Name = "Terrasoft.Configuration.PRM",
				Alias = "",
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63")
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

		protected virtual SchemaMethod CreateFillNameMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("fa5c803f-1ce9-4f2d-8ccf-c6d2015bd83f"),
				Name = "FillName",
				CreatedInSchemaUId = new Guid("79f24261-38bb-4413-a17a-a47f3ba9dc01"),
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,81,203,78,195,48,16,60,147,175,176,114,114,164,200,234,61,202,1,89,45,226,80,4,42,143,3,226,176,36,91,234,202,89,183,142,13,138,16,255,142,141,163,52,10,55,123,119,118,102,118,214,188,31,177,113,108,239,169,125,28,78,120,219,178,154,173,201,41,55,136,27,116,210,104,223,209,51,104,143,60,223,76,152,188,168,50,181,103,124,62,85,51,242,90,23,236,59,187,178,232,188,165,42,251,201,62,193,50,236,207,129,147,240,107,228,221,53,7,236,224,193,163,29,248,83,143,86,26,162,96,65,25,18,115,192,22,8,62,208,150,108,210,141,170,129,76,92,183,109,242,197,243,100,101,81,188,131,110,194,110,148,118,104,251,216,230,241,47,45,130,195,84,125,81,238,112,15,54,160,35,132,167,162,52,221,9,172,234,13,69,73,177,62,123,208,193,67,16,42,103,33,21,129,62,153,13,162,58,185,103,205,229,89,199,173,99,128,75,208,98,227,49,199,203,164,144,198,147,139,105,174,22,81,142,71,217,45,142,242,183,108,57,211,126,93,189,253,187,92,74,164,168,126,1,255,29,147,158,237,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCheckFundTypeDuplicateMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d5a8447a-f60a-43d3-ac62-e687eb858300"),
				Name = "CheckFundTypeDuplicate",
				CreatedInSchemaUId = new Guid("79f24261-38bb-4413-a17a-a47f3ba9dc01"),
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,82,59,79,195,48,16,158,169,212,255,96,101,74,164,200,98,71,69,66,33,69,29,64,64,129,206,198,185,18,131,227,115,29,155,18,33,254,59,118,220,71,168,80,167,110,246,249,123,220,125,103,124,125,7,110,137,168,200,132,148,202,10,219,209,27,176,5,74,215,168,23,38,29,164,201,172,74,178,139,241,8,35,114,233,84,245,212,105,152,29,97,76,119,152,33,83,51,99,21,152,182,22,250,24,249,126,8,235,249,159,204,16,104,87,158,162,96,189,161,205,121,13,13,123,112,96,186,244,185,5,83,160,82,222,68,160,162,67,192,45,83,236,13,76,78,250,158,122,53,175,68,175,170,42,122,238,166,11,213,169,144,214,27,135,215,52,220,11,3,204,66,172,46,132,173,125,103,172,129,0,73,99,177,192,198,15,37,90,84,97,90,90,174,28,147,27,171,80,72,242,65,90,217,169,93,6,57,121,163,63,225,158,204,235,14,237,214,206,231,148,251,111,210,75,199,132,125,130,50,70,78,248,254,56,9,171,10,75,61,4,29,172,41,232,136,37,73,247,84,90,160,83,150,92,146,243,140,124,143,71,103,182,54,184,238,87,190,13,244,218,105,41,184,159,160,252,226,160,255,17,165,11,52,31,173,102,28,232,35,180,232,12,135,185,69,227,191,64,176,251,249,5,4,75,28,39,237,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new FundEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("79f24261-38bb-4413-a17a-a47f3ba9dc01"));
		}

		#endregion

	}

	#endregion


	#region Class: FundEventsProcess

	/// <exclude/>
	public class FundEventsProcess : Fund_PRMBaseEventsProcess
	{

		public FundEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

