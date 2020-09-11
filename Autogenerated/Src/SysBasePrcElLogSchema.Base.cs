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

	#region Class: SysBasePrcElLogSchema

	/// <exclude/>
	[IsVirtual]
	public class SysBasePrcElLogSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysBasePrcElLogSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysBasePrcElLogSchema(SysBasePrcElLogSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysBasePrcElLogSchema(SysBasePrcElLogSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("293f3c3a-0dfb-4677-aa00-ac2a2628eaab");
			RealUId = new Guid("293f3c3a-0dfb-4677-aa00-ac2a2628eaab");
			Name = "SysBasePrcElLog";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("7472633c-2503-4be4-a591-2f327fb1557d")) == null) {
				Columns.Add(CreateStartDateColumn());
			}
			if (Columns.FindByUId(new Guid("66d0971c-b74a-4ebe-94ee-401045e30b39")) == null) {
				Columns.Add(CreateCompleteDateColumn());
			}
			if (Columns.FindByUId(new Guid("3a6983b4-5bc5-43b9-874e-fbc481508766")) == null) {
				Columns.Add(CreateStatusColumn());
			}
			if (Columns.FindByUId(new Guid("881806ee-3862-43db-9565-0b892626309e")) == null) {
				Columns.Add(CreateTypeColumn());
			}
			if (Columns.FindByUId(new Guid("4d75680c-5d85-487d-b139-55662984a1a7")) == null) {
				Columns.Add(CreateCaptionColumn());
			}
			if (Columns.FindByUId(new Guid("6584189d-2dfc-41f8-8d17-c87333a8a942")) == null) {
				Columns.Add(CreateOwnerColumn());
			}
			if (Columns.FindByUId(new Guid("5829e56c-13c3-4b6e-af7f-a65b35234078")) == null) {
				Columns.Add(CreateErrorDescriptionColumn());
			}
			if (Columns.FindByUId(new Guid("49d53787-ba75-498b-9f33-0b76024b1837")) == null) {
				Columns.Add(CreateDurationInMinutesColumn());
			}
			if (Columns.FindByUId(new Guid("c767ce04-54ef-4b9c-9bb4-4ace46c75bde")) == null) {
				Columns.Add(CreateDurationInDaysColumn());
			}
			if (Columns.FindByUId(new Guid("5a62ac33-6d83-4f1f-9d89-3e8a4dcd0652")) == null) {
				Columns.Add(CreateDurationInHoursColumn());
			}
			if (Columns.FindByUId(new Guid("23c0a56c-ad99-454a-b521-0b943cef4fd2")) == null) {
				Columns.Add(CreateSchemaElementUIdColumn());
			}
			if (Columns.FindByUId(new Guid("db2066ef-6e51-4c73-a626-f448251d9394")) == null) {
				Columns.Add(CreateDurationInMillisecondsColumn());
			}
			if (Columns.FindByUId(new Guid("0e312911-0169-4700-8f07-9a9a88b62f48")) == null) {
				Columns.Add(CreateNodeIdColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateStartDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("7472633c-2503-4be4-a591-2f327fb1557d"),
				Name = @"StartDate",
				CreatedInSchemaUId = new Guid("293f3c3a-0dfb-4677-aa00-ac2a2628eaab"),
				ModifiedInSchemaUId = new Guid("293f3c3a-0dfb-4677-aa00-ac2a2628eaab"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateCompleteDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("66d0971c-b74a-4ebe-94ee-401045e30b39"),
				Name = @"CompleteDate",
				CreatedInSchemaUId = new Guid("293f3c3a-0dfb-4677-aa00-ac2a2628eaab"),
				ModifiedInSchemaUId = new Guid("293f3c3a-0dfb-4677-aa00-ac2a2628eaab"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("3a6983b4-5bc5-43b9-874e-fbc481508766"),
				Name = @"Status",
				ReferenceSchemaUId = new Guid("dc1e2217-9af0-4216-935b-ace805adc929"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("293f3c3a-0dfb-4677-aa00-ac2a2628eaab"),
				ModifiedInSchemaUId = new Guid("293f3c3a-0dfb-4677-aa00-ac2a2628eaab"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("881806ee-3862-43db-9565-0b892626309e"),
				Name = @"Type",
				CreatedInSchemaUId = new Guid("293f3c3a-0dfb-4677-aa00-ac2a2628eaab"),
				ModifiedInSchemaUId = new Guid("293f3c3a-0dfb-4677-aa00-ac2a2628eaab"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("4d75680c-5d85-487d-b139-55662984a1a7"),
				Name = @"Caption",
				CreatedInSchemaUId = new Guid("293f3c3a-0dfb-4677-aa00-ac2a2628eaab"),
				ModifiedInSchemaUId = new Guid("293f3c3a-0dfb-4677-aa00-ac2a2628eaab"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateOwnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6584189d-2dfc-41f8-8d17-c87333a8a942"),
				Name = @"Owner",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				IsWeakReference = true,
				CreatedInSchemaUId = new Guid("293f3c3a-0dfb-4677-aa00-ac2a2628eaab"),
				ModifiedInSchemaUId = new Guid("293f3c3a-0dfb-4677-aa00-ac2a2628eaab"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateErrorDescriptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("5829e56c-13c3-4b6e-af7f-a65b35234078"),
				Name = @"ErrorDescription",
				CreatedInSchemaUId = new Guid("293f3c3a-0dfb-4677-aa00-ac2a2628eaab"),
				ModifiedInSchemaUId = new Guid("293f3c3a-0dfb-4677-aa00-ac2a2628eaab"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateDurationInMinutesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float1")) {
				UId = new Guid("49d53787-ba75-498b-9f33-0b76024b1837"),
				Name = @"DurationInMinutes",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("293f3c3a-0dfb-4677-aa00-ac2a2628eaab"),
				ModifiedInSchemaUId = new Guid("293f3c3a-0dfb-4677-aa00-ac2a2628eaab"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateDurationInDaysColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float1")) {
				UId = new Guid("c767ce04-54ef-4b9c-9bb4-4ace46c75bde"),
				Name = @"DurationInDays",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("293f3c3a-0dfb-4677-aa00-ac2a2628eaab"),
				ModifiedInSchemaUId = new Guid("293f3c3a-0dfb-4677-aa00-ac2a2628eaab"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateDurationInHoursColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float1")) {
				UId = new Guid("5a62ac33-6d83-4f1f-9d89-3e8a4dcd0652"),
				Name = @"DurationInHours",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("293f3c3a-0dfb-4677-aa00-ac2a2628eaab"),
				ModifiedInSchemaUId = new Guid("293f3c3a-0dfb-4677-aa00-ac2a2628eaab"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateSchemaElementUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("23c0a56c-ad99-454a-b521-0b943cef4fd2"),
				Name = @"SchemaElementUId",
				CreatedInSchemaUId = new Guid("293f3c3a-0dfb-4677-aa00-ac2a2628eaab"),
				ModifiedInSchemaUId = new Guid("293f3c3a-0dfb-4677-aa00-ac2a2628eaab"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateDurationInMillisecondsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float1")) {
				UId = new Guid("db2066ef-6e51-4c73-a626-f448251d9394"),
				Name = @"DurationInMilliseconds",
				CreatedInSchemaUId = new Guid("293f3c3a-0dfb-4677-aa00-ac2a2628eaab"),
				ModifiedInSchemaUId = new Guid("293f3c3a-0dfb-4677-aa00-ac2a2628eaab"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateNodeIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("0e312911-0169-4700-8f07-9a9a88b62f48"),
				Name = @"NodeId",
				CreatedInSchemaUId = new Guid("293f3c3a-0dfb-4677-aa00-ac2a2628eaab"),
				ModifiedInSchemaUId = new Guid("293f3c3a-0dfb-4677-aa00-ac2a2628eaab"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysBasePrcElLogEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysBasePrcElLogEventsProcessSchema() {
			var schema = new SysBasePrcElLogEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysBasePrcElLog(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysBasePrcElLog_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysBasePrcElLogSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysBasePrcElLogSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("293f3c3a-0dfb-4677-aa00-ac2a2628eaab"));
		}

		#endregion

	}

	#endregion

	#region Class: SysBasePrcElLog

	/// <summary>
	/// Base process items log.
	/// </summary>
	public class SysBasePrcElLog : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysBasePrcElLog(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysBasePrcElLog";
		}

		public SysBasePrcElLog(SysBasePrcElLog source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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
		/// End date.
		/// </summary>
		public DateTime CompleteDate {
			get {
				return GetTypedColumnValue<DateTime>("CompleteDate");
			}
			set {
				SetColumnValue("CompleteDate", value);
			}
		}

		/// <exclude/>
		public Guid StatusId {
			get {
				return GetTypedColumnValue<Guid>("StatusId");
			}
			set {
				SetColumnValue("StatusId", value);
				_status = null;
			}
		}

		/// <exclude/>
		public string StatusName {
			get {
				return GetTypedColumnValue<string>("StatusName");
			}
			set {
				SetColumnValue("StatusName", value);
				if (_status != null) {
					_status.Name = value;
				}
			}
		}

		private SysProcessStatus _status;
		/// <summary>
		/// Status.
		/// </summary>
		public SysProcessStatus Status {
			get {
				return _status ??
					(_status = LookupColumnEntities.GetEntity("Status") as SysProcessStatus);
			}
		}

		/// <summary>
		/// Type.
		/// </summary>
		public string Type {
			get {
				return GetTypedColumnValue<string>("Type");
			}
			set {
				SetColumnValue("Type", value);
			}
		}

		/// <summary>
		/// Caption.
		/// </summary>
		public string Caption {
			get {
				return GetTypedColumnValue<string>("Caption");
			}
			set {
				SetColumnValue("Caption", value);
			}
		}

		/// <exclude/>
		public Guid OwnerId {
			get {
				return GetTypedColumnValue<Guid>("OwnerId");
			}
			set {
				SetColumnValue("OwnerId", value);
				_owner = null;
			}
		}

		/// <exclude/>
		public string OwnerName {
			get {
				return GetTypedColumnValue<string>("OwnerName");
			}
			set {
				SetColumnValue("OwnerName", value);
				if (_owner != null) {
					_owner.Name = value;
				}
			}
		}

		private Contact _owner;
		/// <summary>
		/// Owner.
		/// </summary>
		public Contact Owner {
			get {
				return _owner ??
					(_owner = LookupColumnEntities.GetEntity("Owner") as Contact);
			}
		}

		/// <summary>
		/// Error details.
		/// </summary>
		public string ErrorDescription {
			get {
				return GetTypedColumnValue<string>("ErrorDescription");
			}
			set {
				SetColumnValue("ErrorDescription", value);
			}
		}

		/// <summary>
		/// Duration, minutes.
		/// </summary>
		public Decimal DurationInMinutes {
			get {
				return GetTypedColumnValue<Decimal>("DurationInMinutes");
			}
			set {
				SetColumnValue("DurationInMinutes", value);
			}
		}

		/// <summary>
		/// Duration, days.
		/// </summary>
		public Decimal DurationInDays {
			get {
				return GetTypedColumnValue<Decimal>("DurationInDays");
			}
			set {
				SetColumnValue("DurationInDays", value);
			}
		}

		/// <summary>
		/// Duration, hours.
		/// </summary>
		public Decimal DurationInHours {
			get {
				return GetTypedColumnValue<Decimal>("DurationInHours");
			}
			set {
				SetColumnValue("DurationInHours", value);
			}
		}

		/// <summary>
		/// Diagram item.
		/// </summary>
		public Guid SchemaElementUId {
			get {
				return GetTypedColumnValue<Guid>("SchemaElementUId");
			}
			set {
				SetColumnValue("SchemaElementUId", value);
			}
		}

		/// <summary>
		/// Duration, milliseconds.
		/// </summary>
		public Decimal DurationInMilliseconds {
			get {
				return GetTypedColumnValue<Decimal>("DurationInMilliseconds");
			}
			set {
				SetColumnValue("DurationInMilliseconds", value);
			}
		}

		/// <summary>
		/// Node Identifier.
		/// </summary>
		/// <remarks>
		/// Identifies current execution node.
		/// </remarks>
		public string NodeId {
			get {
				return GetTypedColumnValue<string>("NodeId");
			}
			set {
				SetColumnValue("NodeId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysBasePrcElLog_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysBasePrcElLogDeleted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysBasePrcElLog(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysBasePrcElLog_BaseEventsProcess

	/// <exclude/>
	public partial class SysBasePrcElLog_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysBasePrcElLog
	{

		public SysBasePrcElLog_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysBasePrcElLog_BaseEventsProcess";
			SchemaUId = new Guid("293f3c3a-0dfb-4677-aa00-ac2a2628eaab");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("293f3c3a-0dfb-4677-aa00-ac2a2628eaab");
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

	#region Class: SysBasePrcElLog_BaseEventsProcess

	/// <exclude/>
	public class SysBasePrcElLog_BaseEventsProcess : SysBasePrcElLog_BaseEventsProcess<SysBasePrcElLog>
	{

		public SysBasePrcElLog_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysBasePrcElLog_BaseEventsProcess

	public partial class SysBasePrcElLog_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysBasePrcElLogEventsProcessSchema

	/// <exclude/>
	public class SysBasePrcElLogEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysBasePrcElLogEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysBasePrcElLogEventsProcessSchema(SysBasePrcElLogEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysBasePrcElLog_BaseEventsProcess";
			UId = new Guid("d92550ae-1021-476e-a142-0db24fcc48d9");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			CreatedInSchemaUId = Guid.Empty;
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
			return new SysBasePrcElLogEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d92550ae-1021-476e-a142-0db24fcc48d9"));
		}

		#endregion

	}

	#endregion


	#region Class: SysBasePrcElLogEventsProcess

	/// <exclude/>
	public class SysBasePrcElLogEventsProcess : SysBasePrcElLog_BaseEventsProcess
	{

		public SysBasePrcElLogEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

