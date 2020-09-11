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

	#region Class: SysModuleStageHistorySchema

	/// <exclude/>
	public class SysModuleStageHistorySchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysModuleStageHistorySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysModuleStageHistorySchema(SysModuleStageHistorySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysModuleStageHistorySchema(SysModuleStageHistorySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("493242eb-5334-46ee-a3f7-c608a885a80f");
			RealUId = new Guid("493242eb-5334-46ee-a3f7-c608a885a80f");
			Name = "SysModuleStageHistory";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("a83ae89b-1206-453d-b626-f37ab41fffbf");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("df4e6f49-6917-4048-aa0a-035740953c15")) == null) {
				Columns.Add(CreateEntitySchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("272c4c88-f1ad-4480-b65d-341c488a37da")) == null) {
				Columns.Add(CreateStageSchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("732eb4fb-42b5-4864-8e47-3c28ec5d7c1b")) == null) {
				Columns.Add(CreateStageHistorySchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("666989c9-b65b-4360-b148-3dc4b06f2559")) == null) {
				Columns.Add(CreateStageColUIdColumn());
			}
			if (Columns.FindByUId(new Guid("31026a13-dfeb-4e04-8b54-60af3b63b785")) == null) {
				Columns.Add(CreateOwnerColUIdColumn());
			}
			if (Columns.FindByUId(new Guid("c7b00ac4-b62b-43fa-afcc-a3dcceddd1cf")) == null) {
				Columns.Add(CreateStageIsFinalColUIdColumn());
			}
			if (Columns.FindByUId(new Guid("26052881-9515-4347-980f-780982950ea5")) == null) {
				Columns.Add(CreateStageIsSuccessfulColUIdColumn());
			}
			if (Columns.FindByUId(new Guid("39c0a45f-b9d9-4c1f-8bb9-cc15923df224")) == null) {
				Columns.Add(CreateStageOrderColUIdColumn());
			}
			if (Columns.FindByUId(new Guid("bd40b5ee-8a97-4859-bbc6-22849c7f7a5b")) == null) {
				Columns.Add(CreateStageHistoryStartDateColUIdColumn());
			}
			if (Columns.FindByUId(new Guid("6ea10b77-29bb-481a-a87c-bbdb8f79185b")) == null) {
				Columns.Add(CreateStageHistoryDueDateColUIdColumn());
			}
			if (Columns.FindByUId(new Guid("711853bd-3110-4b7d-b2a4-049b3ee8ea8e")) == null) {
				Columns.Add(CreateStageHistoryOwnerColUIdColumn());
			}
			if (Columns.FindByUId(new Guid("01a6e3e6-e277-4450-b745-ce814f976650")) == null) {
				Columns.Add(CreateStageHistoryHistoricalColUIdColumn());
			}
			if (Columns.FindByUId(new Guid("85a91fc1-d508-468e-872b-37be7defadb6")) == null) {
				Columns.Add(CreateStageHistoryMainEntityColUIdColumn());
			}
			if (Columns.FindByUId(new Guid("70be97e5-1595-42a7-9d6b-f7596e23f4aa")) == null) {
				Columns.Add(CreateStageHistoryStageColUIdColumn());
			}
			if (Columns.FindByUId(new Guid("c23b55f9-8218-44ff-9c17-d8851dcc75c2")) == null) {
				Columns.Add(CreateActiveColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateEntitySchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("df4e6f49-6917-4048-aa0a-035740953c15"),
				Name = @"EntitySchemaUId",
				CreatedInSchemaUId = new Guid("493242eb-5334-46ee-a3f7-c608a885a80f"),
				ModifiedInSchemaUId = new Guid("493242eb-5334-46ee-a3f7-c608a885a80f"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateStageSchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("272c4c88-f1ad-4480-b65d-341c488a37da"),
				Name = @"StageSchemaUId",
				CreatedInSchemaUId = new Guid("493242eb-5334-46ee-a3f7-c608a885a80f"),
				ModifiedInSchemaUId = new Guid("493242eb-5334-46ee-a3f7-c608a885a80f"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateStageHistorySchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("732eb4fb-42b5-4864-8e47-3c28ec5d7c1b"),
				Name = @"StageHistorySchemaUId",
				CreatedInSchemaUId = new Guid("493242eb-5334-46ee-a3f7-c608a885a80f"),
				ModifiedInSchemaUId = new Guid("493242eb-5334-46ee-a3f7-c608a885a80f"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateStageColUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("666989c9-b65b-4360-b148-3dc4b06f2559"),
				Name = @"StageColUId",
				CreatedInSchemaUId = new Guid("493242eb-5334-46ee-a3f7-c608a885a80f"),
				ModifiedInSchemaUId = new Guid("493242eb-5334-46ee-a3f7-c608a885a80f"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateOwnerColUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("31026a13-dfeb-4e04-8b54-60af3b63b785"),
				Name = @"OwnerColUId",
				CreatedInSchemaUId = new Guid("493242eb-5334-46ee-a3f7-c608a885a80f"),
				ModifiedInSchemaUId = new Guid("493242eb-5334-46ee-a3f7-c608a885a80f"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateStageIsFinalColUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("c7b00ac4-b62b-43fa-afcc-a3dcceddd1cf"),
				Name = @"StageIsFinalColUId",
				CreatedInSchemaUId = new Guid("493242eb-5334-46ee-a3f7-c608a885a80f"),
				ModifiedInSchemaUId = new Guid("493242eb-5334-46ee-a3f7-c608a885a80f"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateStageIsSuccessfulColUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("26052881-9515-4347-980f-780982950ea5"),
				Name = @"StageIsSuccessfulColUId",
				CreatedInSchemaUId = new Guid("493242eb-5334-46ee-a3f7-c608a885a80f"),
				ModifiedInSchemaUId = new Guid("493242eb-5334-46ee-a3f7-c608a885a80f"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateStageOrderColUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("39c0a45f-b9d9-4c1f-8bb9-cc15923df224"),
				Name = @"StageOrderColUId",
				CreatedInSchemaUId = new Guid("493242eb-5334-46ee-a3f7-c608a885a80f"),
				ModifiedInSchemaUId = new Guid("493242eb-5334-46ee-a3f7-c608a885a80f"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateStageHistoryStartDateColUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("bd40b5ee-8a97-4859-bbc6-22849c7f7a5b"),
				Name = @"StageHistoryStartDateColUId",
				CreatedInSchemaUId = new Guid("493242eb-5334-46ee-a3f7-c608a885a80f"),
				ModifiedInSchemaUId = new Guid("493242eb-5334-46ee-a3f7-c608a885a80f"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateStageHistoryDueDateColUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("6ea10b77-29bb-481a-a87c-bbdb8f79185b"),
				Name = @"StageHistoryDueDateColUId",
				CreatedInSchemaUId = new Guid("493242eb-5334-46ee-a3f7-c608a885a80f"),
				ModifiedInSchemaUId = new Guid("493242eb-5334-46ee-a3f7-c608a885a80f"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateStageHistoryOwnerColUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("711853bd-3110-4b7d-b2a4-049b3ee8ea8e"),
				Name = @"StageHistoryOwnerColUId",
				CreatedInSchemaUId = new Guid("493242eb-5334-46ee-a3f7-c608a885a80f"),
				ModifiedInSchemaUId = new Guid("493242eb-5334-46ee-a3f7-c608a885a80f"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateStageHistoryHistoricalColUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("01a6e3e6-e277-4450-b745-ce814f976650"),
				Name = @"StageHistoryHistoricalColUId",
				CreatedInSchemaUId = new Guid("493242eb-5334-46ee-a3f7-c608a885a80f"),
				ModifiedInSchemaUId = new Guid("493242eb-5334-46ee-a3f7-c608a885a80f"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateStageHistoryMainEntityColUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("85a91fc1-d508-468e-872b-37be7defadb6"),
				Name = @"StageHistoryMainEntityColUId",
				CreatedInSchemaUId = new Guid("493242eb-5334-46ee-a3f7-c608a885a80f"),
				ModifiedInSchemaUId = new Guid("493242eb-5334-46ee-a3f7-c608a885a80f"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateStageHistoryStageColUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("70be97e5-1595-42a7-9d6b-f7596e23f4aa"),
				Name = @"StageHistoryStageColUId",
				CreatedInSchemaUId = new Guid("493242eb-5334-46ee-a3f7-c608a885a80f"),
				ModifiedInSchemaUId = new Guid("493242eb-5334-46ee-a3f7-c608a885a80f"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateActiveColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("c23b55f9-8218-44ff-9c17-d8851dcc75c2"),
				Name = @"Active",
				CreatedInSchemaUId = new Guid("493242eb-5334-46ee-a3f7-c608a885a80f"),
				ModifiedInSchemaUId = new Guid("493242eb-5334-46ee-a3f7-c608a885a80f"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysModuleStageHistoryEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysModuleStageHistoryEventsProcessSchema() {
			var schema = new SysModuleStageHistoryEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysModuleStageHistory(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysModuleStageHistory_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysModuleStageHistorySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysModuleStageHistorySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("493242eb-5334-46ee-a3f7-c608a885a80f"));
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleStageHistory

	/// <summary>
	/// Section storage stage settings.
	/// </summary>
	public class SysModuleStageHistory : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysModuleStageHistory(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysModuleStageHistory";
		}

		public SysModuleStageHistory(SysModuleStageHistory source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Entity schema identifier.
		/// </summary>
		public Guid EntitySchemaUId {
			get {
				return GetTypedColumnValue<Guid>("EntitySchemaUId");
			}
			set {
				SetColumnValue("EntitySchemaUId", value);
			}
		}

		/// <summary>
		/// Stage schema identifier.
		/// </summary>
		public Guid StageSchemaUId {
			get {
				return GetTypedColumnValue<Guid>("StageSchemaUId");
			}
			set {
				SetColumnValue("StageSchemaUId", value);
			}
		}

		/// <summary>
		/// History stages schema identifier.
		/// </summary>
		public Guid StageHistorySchemaUId {
			get {
				return GetTypedColumnValue<Guid>("StageHistorySchemaUId");
			}
			set {
				SetColumnValue("StageHistorySchemaUId", value);
			}
		}

		/// <summary>
		/// Stage column identifier.
		/// </summary>
		public Guid StageColUId {
			get {
				return GetTypedColumnValue<Guid>("StageColUId");
			}
			set {
				SetColumnValue("StageColUId", value);
			}
		}

		/// <summary>
		/// Owner column identifier.
		/// </summary>
		public Guid OwnerColUId {
			get {
				return GetTypedColumnValue<Guid>("OwnerColUId");
			}
			set {
				SetColumnValue("OwnerColUId", value);
			}
		}

		/// <summary>
		/// Final stage column identifier.
		/// </summary>
		public Guid StageIsFinalColUId {
			get {
				return GetTypedColumnValue<Guid>("StageIsFinalColUId");
			}
			set {
				SetColumnValue("StageIsFinalColUId", value);
			}
		}

		/// <summary>
		/// Successful column identifier.
		/// </summary>
		public Guid StageIsSuccessfulColUId {
			get {
				return GetTypedColumnValue<Guid>("StageIsSuccessfulColUId");
			}
			set {
				SetColumnValue("StageIsSuccessfulColUId", value);
			}
		}

		/// <summary>
		/// Order column identifier.
		/// </summary>
		public Guid StageOrderColUId {
			get {
				return GetTypedColumnValue<Guid>("StageOrderColUId");
			}
			set {
				SetColumnValue("StageOrderColUId", value);
			}
		}

		/// <summary>
		/// Column identifier of transition start to the stage .
		/// </summary>
		public Guid StageHistoryStartDateColUId {
			get {
				return GetTypedColumnValue<Guid>("StageHistoryStartDateColUId");
			}
			set {
				SetColumnValue("StageHistoryStartDateColUId", value);
			}
		}

		/// <summary>
		/// Column identifier of transition end to the stage .
		/// </summary>
		public Guid StageHistoryDueDateColUId {
			get {
				return GetTypedColumnValue<Guid>("StageHistoryDueDateColUId");
			}
			set {
				SetColumnValue("StageHistoryDueDateColUId", value);
			}
		}

		/// <summary>
		/// Column identifier of transition owner to the stage .
		/// </summary>
		public Guid StageHistoryOwnerColUId {
			get {
				return GetTypedColumnValue<Guid>("StageHistoryOwnerColUId");
			}
			set {
				SetColumnValue("StageHistoryOwnerColUId", value);
			}
		}

		/// <summary>
		/// Column identifier of sign historical stage .
		/// </summary>
		public Guid StageHistoryHistoricalColUId {
			get {
				return GetTypedColumnValue<Guid>("StageHistoryHistoricalColUId");
			}
			set {
				SetColumnValue("StageHistoryHistoricalColUId", value);
			}
		}

		/// <summary>
		/// Column identifier of main entity.
		/// </summary>
		public Guid StageHistoryMainEntityColUId {
			get {
				return GetTypedColumnValue<Guid>("StageHistoryMainEntityColUId");
			}
			set {
				SetColumnValue("StageHistoryMainEntityColUId", value);
			}
		}

		/// <summary>
		/// Column identifier of stage.
		/// </summary>
		public Guid StageHistoryStageColUId {
			get {
				return GetTypedColumnValue<Guid>("StageHistoryStageColUId");
			}
			set {
				SetColumnValue("StageHistoryStageColUId", value);
			}
		}

		/// <summary>
		/// Active.
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
			var process = new SysModuleStageHistory_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysModuleStageHistory(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleStageHistory_BaseEventsProcess

	/// <exclude/>
	public partial class SysModuleStageHistory_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysModuleStageHistory
	{

		public SysModuleStageHistory_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysModuleStageHistory_BaseEventsProcess";
			SchemaUId = new Guid("493242eb-5334-46ee-a3f7-c608a885a80f");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("493242eb-5334-46ee-a3f7-c608a885a80f");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
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

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
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

	#region Class: SysModuleStageHistory_BaseEventsProcess

	/// <exclude/>
	public class SysModuleStageHistory_BaseEventsProcess : SysModuleStageHistory_BaseEventsProcess<SysModuleStageHistory>
	{

		public SysModuleStageHistory_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysModuleStageHistory_BaseEventsProcess

	public partial class SysModuleStageHistory_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysModuleStageHistoryEventsProcessSchema

	/// <exclude/>
	public class SysModuleStageHistoryEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysModuleStageHistoryEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysModuleStageHistoryEventsProcessSchema(SysModuleStageHistoryEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysModuleStageHistory_BaseEventsProcess";
			UId = new Guid("460c59c8-6231-489d-9b9a-25d3d978d758");
			CreatedInPackageId = new Guid("a83ae89b-1206-453d-b626-f37ab41fffbf");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
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
			return new SysModuleStageHistoryEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("460c59c8-6231-489d-9b9a-25d3d978d758"));
		}

		#endregion

	}

	#endregion


	#region Class: SysModuleStageHistoryEventsProcess

	/// <exclude/>
	public class SysModuleStageHistoryEventsProcess : SysModuleStageHistory_BaseEventsProcess
	{

		public SysModuleStageHistoryEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

