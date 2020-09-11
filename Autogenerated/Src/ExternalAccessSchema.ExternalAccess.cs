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
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: ExternalAccessSchema

	/// <exclude/>
	public class ExternalAccessSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ExternalAccessSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ExternalAccessSchema(ExternalAccessSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ExternalAccessSchema(ExternalAccessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f3858e46-ea38-412e-af4a-2011f08718ae");
			RealUId = new Guid("f3858e46-ea38-412e-af4a-2011f08718ae");
			Name = "ExternalAccess";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("386ac9f6-07c1-4d11-8d16-e4e9424ba4e8");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateAccessReasonColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("6e370efc-02d9-438c-955a-9a378a4276c6")) == null) {
				Columns.Add(CreateNotesColumn());
			}
			if (Columns.FindByUId(new Guid("99e489ab-e1c1-4faa-80d0-6e7d221bd288")) == null) {
				Columns.Add(CreateStartDateColumn());
			}
			if (Columns.FindByUId(new Guid("fc7c6551-254a-43a5-b4a7-9652c2ca581f")) == null) {
				Columns.Add(CreateDueDateColumn());
			}
			if (Columns.FindByUId(new Guid("d86135cf-02de-4c27-8f63-e91bd6ddb503")) == null) {
				Columns.Add(CreateGrantorColumn());
			}
			if (Columns.FindByUId(new Guid("80813c55-e790-4bf7-ba2c-ba64101eceaf")) == null) {
				Columns.Add(CreateIsActiveColumn());
			}
			if (Columns.FindByUId(new Guid("6f0fcac4-8b55-4c44-bd43-667c14417da9")) == null) {
				Columns.Add(CreateIsDataIsolationEnabledColumn());
			}
			if (Columns.FindByUId(new Guid("eadcbeaf-10ef-4e87-8d57-b5be5a989cbf")) == null) {
				Columns.Add(CreateIsSystemOperationsRestrictedColumn());
			}
			if (Columns.FindByUId(new Guid("b159648d-1234-4c53-a976-b6cab3dfce60")) == null) {
				Columns.Add(CreateExternalAccessClientColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("f3858e46-ea38-412e-af4a-2011f08718ae");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("f3858e46-ea38-412e-af4a-2011f08718ae");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("f3858e46-ea38-412e-af4a-2011f08718ae");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("f3858e46-ea38-412e-af4a-2011f08718ae");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("f3858e46-ea38-412e-af4a-2011f08718ae");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("f3858e46-ea38-412e-af4a-2011f08718ae");
			return column;
		}

		protected virtual EntitySchemaColumn CreateAccessReasonColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Text")) {
				UId = new Guid("4a9dd5e9-40a0-4818-a299-cd2173229d01"),
				Name = @"AccessReason",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("f3858e46-ea38-412e-af4a-2011f08718ae"),
				ModifiedInSchemaUId = new Guid("f3858e46-ea38-412e-af4a-2011f08718ae"),
				CreatedInPackageId = new Guid("386ac9f6-07c1-4d11-8d16-e4e9424ba4e8")
			};
		}

		protected virtual EntitySchemaColumn CreateNotesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("6e370efc-02d9-438c-955a-9a378a4276c6"),
				Name = @"Notes",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("f3858e46-ea38-412e-af4a-2011f08718ae"),
				ModifiedInSchemaUId = new Guid("f3858e46-ea38-412e-af4a-2011f08718ae"),
				CreatedInPackageId = new Guid("386ac9f6-07c1-4d11-8d16-e4e9424ba4e8")
			};
		}

		protected virtual EntitySchemaColumn CreateStartDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("99e489ab-e1c1-4faa-80d0-6e7d221bd288"),
				Name = @"StartDate",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("f3858e46-ea38-412e-af4a-2011f08718ae"),
				ModifiedInSchemaUId = new Guid("f3858e46-ea38-412e-af4a-2011f08718ae"),
				CreatedInPackageId = new Guid("386ac9f6-07c1-4d11-8d16-e4e9424ba4e8"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentDateTime")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateDueDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("fc7c6551-254a-43a5-b4a7-9652c2ca581f"),
				Name = @"DueDate",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("f3858e46-ea38-412e-af4a-2011f08718ae"),
				ModifiedInSchemaUId = new Guid("f3858e46-ea38-412e-af4a-2011f08718ae"),
				CreatedInPackageId = new Guid("386ac9f6-07c1-4d11-8d16-e4e9424ba4e8")
			};
		}

		protected virtual EntitySchemaColumn CreateGrantorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d86135cf-02de-4c27-8f63-e91bd6ddb503"),
				Name = @"Grantor",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("f3858e46-ea38-412e-af4a-2011f08718ae"),
				ModifiedInSchemaUId = new Guid("f3858e46-ea38-412e-af4a-2011f08718ae"),
				CreatedInPackageId = new Guid("386ac9f6-07c1-4d11-8d16-e4e9424ba4e8"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentUserContact")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateIsActiveColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("80813c55-e790-4bf7-ba2c-ba64101eceaf"),
				Name = @"IsActive",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("f3858e46-ea38-412e-af4a-2011f08718ae"),
				ModifiedInSchemaUId = new Guid("f3858e46-ea38-412e-af4a-2011f08718ae"),
				CreatedInPackageId = new Guid("386ac9f6-07c1-4d11-8d16-e4e9424ba4e8"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"True"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateIsDataIsolationEnabledColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("6f0fcac4-8b55-4c44-bd43-667c14417da9"),
				Name = @"IsDataIsolationEnabled",
				CreatedInSchemaUId = new Guid("f3858e46-ea38-412e-af4a-2011f08718ae"),
				ModifiedInSchemaUId = new Guid("f3858e46-ea38-412e-af4a-2011f08718ae"),
				CreatedInPackageId = new Guid("edb637f8-a36b-404a-83af-5c35db85ff97"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"True"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateIsSystemOperationsRestrictedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("eadcbeaf-10ef-4e87-8d57-b5be5a989cbf"),
				Name = @"IsSystemOperationsRestricted",
				CreatedInSchemaUId = new Guid("f3858e46-ea38-412e-af4a-2011f08718ae"),
				ModifiedInSchemaUId = new Guid("f3858e46-ea38-412e-af4a-2011f08718ae"),
				CreatedInPackageId = new Guid("edb637f8-a36b-404a-83af-5c35db85ff97"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"True"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateExternalAccessClientColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b159648d-1234-4c53-a976-b6cab3dfce60"),
				Name = @"ExternalAccessClient",
				ReferenceSchemaUId = new Guid("1d2bb308-dffb-4dd5-8518-f94ff54ea7cf"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("f3858e46-ea38-412e-af4a-2011f08718ae"),
				ModifiedInSchemaUId = new Guid("f3858e46-ea38-412e-af4a-2011f08718ae"),
				CreatedInPackageId = new Guid("c3c7809d-fee0-4b66-8bb6-9b3983c2cffd"),
				IsSimpleLookup = true,
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Settings,
					ValueSource = @"DefaultExternalAccessClient"
				}
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateExternalAccessEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateExternalAccessEventsProcessSchema() {
			var schema = new ExternalAccessEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ExternalAccess(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ExternalAccess_ExternalAccessEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ExternalAccessSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ExternalAccessSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f3858e46-ea38-412e-af4a-2011f08718ae"));
		}

		#endregion

	}

	#endregion

	#region Class: ExternalAccess

	/// <summary>
	/// External access.
	/// </summary>
	public class ExternalAccess : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ExternalAccess(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ExternalAccess";
		}

		public ExternalAccess(ExternalAccess source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Reason to grant access.
		/// </summary>
		public string AccessReason {
			get {
				return GetTypedColumnValue<string>("AccessReason");
			}
			set {
				SetColumnValue("AccessReason", value);
			}
		}

		/// <summary>
		/// Notes.
		/// </summary>
		public string Notes {
			get {
				return GetTypedColumnValue<string>("Notes");
			}
			set {
				SetColumnValue("Notes", value);
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
		/// Access close date.
		/// </summary>
		public DateTime DueDate {
			get {
				return GetTypedColumnValue<DateTime>("DueDate");
			}
			set {
				SetColumnValue("DueDate", value);
			}
		}

		/// <exclude/>
		public Guid GrantorId {
			get {
				return GetTypedColumnValue<Guid>("GrantorId");
			}
			set {
				SetColumnValue("GrantorId", value);
				_grantor = null;
			}
		}

		/// <exclude/>
		public string GrantorName {
			get {
				return GetTypedColumnValue<string>("GrantorName");
			}
			set {
				SetColumnValue("GrantorName", value);
				if (_grantor != null) {
					_grantor.Name = value;
				}
			}
		}

		private Contact _grantor;
		/// <summary>
		/// Grantor.
		/// </summary>
		public Contact Grantor {
			get {
				return _grantor ??
					(_grantor = LookupColumnEntities.GetEntity("Grantor") as Contact);
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
		/// Deny access to data.
		/// </summary>
		public bool IsDataIsolationEnabled {
			get {
				return GetTypedColumnValue<bool>("IsDataIsolationEnabled");
			}
			set {
				SetColumnValue("IsDataIsolationEnabled", value);
			}
		}

		/// <summary>
		/// Deny configuration.
		/// </summary>
		public bool IsSystemOperationsRestricted {
			get {
				return GetTypedColumnValue<bool>("IsSystemOperationsRestricted");
			}
			set {
				SetColumnValue("IsSystemOperationsRestricted", value);
			}
		}

		/// <exclude/>
		public Guid ExternalAccessClientId {
			get {
				return GetTypedColumnValue<Guid>("ExternalAccessClientId");
			}
			set {
				SetColumnValue("ExternalAccessClientId", value);
				_externalAccessClient = null;
			}
		}

		/// <exclude/>
		public string ExternalAccessClientClientId {
			get {
				return GetTypedColumnValue<string>("ExternalAccessClientClientId");
			}
			set {
				SetColumnValue("ExternalAccessClientClientId", value);
				if (_externalAccessClient != null) {
					_externalAccessClient.ClientId = value;
				}
			}
		}

		private ExternalAccessClient _externalAccessClient;
		/// <summary>
		/// Access client.
		/// </summary>
		public ExternalAccessClient ExternalAccessClient {
			get {
				return _externalAccessClient ??
					(_externalAccessClient = LookupColumnEntities.GetEntity("ExternalAccessClient") as ExternalAccessClient);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ExternalAccess_ExternalAccessEventsProcess(UserConnection);
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
			return new ExternalAccess(this);
		}

		#endregion

	}

	#endregion

	#region Class: ExternalAccess_ExternalAccessEventsProcess

	/// <exclude/>
	public partial class ExternalAccess_ExternalAccessEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : ExternalAccess
	{

		public ExternalAccess_ExternalAccessEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ExternalAccess_ExternalAccessEventsProcess";
			SchemaUId = new Guid("f3858e46-ea38-412e-af4a-2011f08718ae");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f3858e46-ea38-412e-af4a-2011f08718ae");
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

	#region Class: ExternalAccess_ExternalAccessEventsProcess

	/// <exclude/>
	public class ExternalAccess_ExternalAccessEventsProcess : ExternalAccess_ExternalAccessEventsProcess<ExternalAccess>
	{

		public ExternalAccess_ExternalAccessEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ExternalAccess_ExternalAccessEventsProcess

	public partial class ExternalAccess_ExternalAccessEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: ExternalAccessEventsProcessSchema

	/// <exclude/>
	public class ExternalAccessEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public ExternalAccessEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ExternalAccessEventsProcessSchema(ExternalAccessEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ExternalAccess_ExternalAccessEventsProcess";
			UId = new Guid("c307e43b-8c21-4e78-8de9-4efeaca02cc8");
			CreatedInPackageId = new Guid("386ac9f6-07c1-4d11-8d16-e4e9424ba4e8");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override ProcessSchemaParameter CreateNextProcessElementReadyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d9e67329-fde2-4fbd-aa49-2d69ca3d2b5b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"NextProcessElementReady",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override ProcessSchemaParameter CreateIsProcessModeSaveParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4cb16350-d39b-4247-9da5-33032cf8667d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"IsProcessModeSave",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override ProcessSchemaParameter CreateCanUseDcmParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d185837a-b568-43f2-a09a-28512af1957a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"CanUseDcm",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
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
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ExternalAccessEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c307e43b-8c21-4e78-8de9-4efeaca02cc8"));
		}

		#endregion

	}

	#endregion


	#region Class: ExternalAccessEventsProcess

	/// <exclude/>
	public class ExternalAccessEventsProcess : ExternalAccess_ExternalAccessEventsProcess
	{

		public ExternalAccessEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

