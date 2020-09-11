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

	#region Class: CashflowSchema

	/// <exclude/>
	public class CashflowSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public CashflowSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CashflowSchema(CashflowSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CashflowSchema(CashflowSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e8e2a77e-01df-4f4b-ae62-12e67d8b0435");
			RealUId = new Guid("e8e2a77e-01df-4f4b-ae62-12e67d8b0435");
			Name = "Cashflow";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNumberColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("860e109f-7bf8-41bb-850d-72a6fda9836a")) == null) {
				Columns.Add(CreateProjectColumn());
			}
			if (Columns.FindByUId(new Guid("0f14f613-0182-46cd-bb35-ea59f7db50b4")) == null) {
				Columns.Add(CreateTypeColumn());
			}
			if (Columns.FindByUId(new Guid("eac36361-c116-4747-9e46-65bb95a6d2d6")) == null) {
				Columns.Add(CreateDetailsColumn());
			}
			if (Columns.FindByUId(new Guid("114e09c8-70b0-46e9-a81e-27988e71316a")) == null) {
				Columns.Add(CreateCategoryColumn());
			}
			if (Columns.FindByUId(new Guid("b0ae3cfe-6600-4747-8b05-683a5d93dd93")) == null) {
				Columns.Add(CreateStatusColumn());
			}
			if (Columns.FindByUId(new Guid("4703b016-cec8-4dc1-aa5d-174916a65adb")) == null) {
				Columns.Add(CreateDateColumn());
			}
			if (Columns.FindByUId(new Guid("e4ada506-1bcf-4ce3-8a52-f94ee17faa7b")) == null) {
				Columns.Add(CreateCurrencyColumn());
			}
			if (Columns.FindByUId(new Guid("e2d8a9ca-9404-42fa-b6a1-6b3f00e8ab31")) == null) {
				Columns.Add(CreateCurrencyRateColumn());
			}
			if (Columns.FindByUId(new Guid("60d967e1-98f8-44b2-8770-1d6f3d620196")) == null) {
				Columns.Add(CreateAmountColumn());
			}
			if (Columns.FindByUId(new Guid("c58a5a82-67ab-43e0-b7c8-31380946a514")) == null) {
				Columns.Add(CreatePrimaryAmountColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("e8e2a77e-01df-4f4b-ae62-12e67d8b0435");
			column.CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("e8e2a77e-01df-4f4b-ae62-12e67d8b0435");
			column.CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("e8e2a77e-01df-4f4b-ae62-12e67d8b0435");
			column.CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("e8e2a77e-01df-4f4b-ae62-12e67d8b0435");
			column.CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("e8e2a77e-01df-4f4b-ae62-12e67d8b0435");
			column.CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("e8e2a77e-01df-4f4b-ae62-12e67d8b0435");
			column.CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c");
			return column;
		}

		protected virtual EntitySchemaColumn CreateProjectColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("860e109f-7bf8-41bb-850d-72a6fda9836a"),
				Name = @"Project",
				ReferenceSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("e8e2a77e-01df-4f4b-ae62-12e67d8b0435"),
				ModifiedInSchemaUId = new Guid("e8e2a77e-01df-4f4b-ae62-12e67d8b0435"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("7fc005d5-e9ca-439d-aeb5-ecdeb6587781"),
				Name = @"Number",
				CreatedInSchemaUId = new Guid("e8e2a77e-01df-4f4b-ae62-12e67d8b0435"),
				ModifiedInSchemaUId = new Guid("e8e2a77e-01df-4f4b-ae62-12e67d8b0435"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c")
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0f14f613-0182-46cd-bb35-ea59f7db50b4"),
				Name = @"Type",
				ReferenceSchemaUId = new Guid("22a9cf97-97de-4d60-9d09-9922849cfeb0"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("e8e2a77e-01df-4f4b-ae62-12e67d8b0435"),
				ModifiedInSchemaUId = new Guid("e8e2a77e-01df-4f4b-ae62-12e67d8b0435"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c")
			};
		}

		protected virtual EntitySchemaColumn CreateDetailsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("eac36361-c116-4747-9e46-65bb95a6d2d6"),
				Name = @"Details",
				CreatedInSchemaUId = new Guid("e8e2a77e-01df-4f4b-ae62-12e67d8b0435"),
				ModifiedInSchemaUId = new Guid("e8e2a77e-01df-4f4b-ae62-12e67d8b0435"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c")
			};
		}

		protected virtual EntitySchemaColumn CreateCategoryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("114e09c8-70b0-46e9-a81e-27988e71316a"),
				Name = @"Category",
				ReferenceSchemaUId = new Guid("31bad651-347e-4d44-90c6-70b79b83dbac"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("e8e2a77e-01df-4f4b-ae62-12e67d8b0435"),
				ModifiedInSchemaUId = new Guid("e8e2a77e-01df-4f4b-ae62-12e67d8b0435"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c")
			};
		}

		protected virtual EntitySchemaColumn CreateStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b0ae3cfe-6600-4747-8b05-683a5d93dd93"),
				Name = @"Status",
				ReferenceSchemaUId = new Guid("7178b348-b19f-49dd-897b-104873aebc12"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("e8e2a77e-01df-4f4b-ae62-12e67d8b0435"),
				ModifiedInSchemaUId = new Guid("e8e2a77e-01df-4f4b-ae62-12e67d8b0435"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"7526510f-dedb-42f0-bcdc-331955b0c91d"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("4703b016-cec8-4dc1-aa5d-174916a65adb"),
				Name = @"Date",
				CreatedInSchemaUId = new Guid("e8e2a77e-01df-4f4b-ae62-12e67d8b0435"),
				ModifiedInSchemaUId = new Guid("e8e2a77e-01df-4f4b-ae62-12e67d8b0435"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentDate")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateCurrencyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e4ada506-1bcf-4ce3-8a52-f94ee17faa7b"),
				Name = @"Currency",
				ReferenceSchemaUId = new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("e8e2a77e-01df-4f4b-ae62-12e67d8b0435"),
				ModifiedInSchemaUId = new Guid("e8e2a77e-01df-4f4b-ae62-12e67d8b0435"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Settings,
					ValueSource = @"PrimaryCurrency"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateCurrencyRateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float4")) {
				UId = new Guid("e2d8a9ca-9404-42fa-b6a1-6b3f00e8ab31"),
				Name = @"CurrencyRate",
				CreatedInSchemaUId = new Guid("e8e2a77e-01df-4f4b-ae62-12e67d8b0435"),
				ModifiedInSchemaUId = new Guid("e8e2a77e-01df-4f4b-ae62-12e67d8b0435"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"1"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("60d967e1-98f8-44b2-8770-1d6f3d620196"),
				Name = @"Amount",
				CreatedInSchemaUId = new Guid("e8e2a77e-01df-4f4b-ae62-12e67d8b0435"),
				ModifiedInSchemaUId = new Guid("e8e2a77e-01df-4f4b-ae62-12e67d8b0435"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c")
			};
		}

		protected virtual EntitySchemaColumn CreatePrimaryAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("c58a5a82-67ab-43e0-b7c8-31380946a514"),
				Name = @"PrimaryAmount",
				CreatedInSchemaUId = new Guid("e8e2a77e-01df-4f4b-ae62-12e67d8b0435"),
				ModifiedInSchemaUId = new Guid("e8e2a77e-01df-4f4b-ae62-12e67d8b0435"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCashflowEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateCashflowEventsProcessSchema() {
			var schema = new CashflowEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Cashflow(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Cashflow_ProjectEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CashflowSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CashflowSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e8e2a77e-01df-4f4b-ae62-12e67d8b0435"));
		}

		#endregion

	}

	#endregion

	#region Class: Cashflow

	/// <summary>
	/// Cash flow.
	/// </summary>
	public class Cashflow : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public Cashflow(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Cashflow";
		}

		public Cashflow(Cashflow source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ProjectId {
			get {
				return GetTypedColumnValue<Guid>("ProjectId");
			}
			set {
				SetColumnValue("ProjectId", value);
				_project = null;
			}
		}

		/// <exclude/>
		public string ProjectName {
			get {
				return GetTypedColumnValue<string>("ProjectName");
			}
			set {
				SetColumnValue("ProjectName", value);
				if (_project != null) {
					_project.Name = value;
				}
			}
		}

		private Project _project;
		/// <summary>
		/// Project.
		/// </summary>
		public Project Project {
			get {
				return _project ??
					(_project = LookupColumnEntities.GetEntity("Project") as Project);
			}
		}

		/// <summary>
		/// Number.
		/// </summary>
		public string Number {
			get {
				return GetTypedColumnValue<string>("Number");
			}
			set {
				SetColumnValue("Number", value);
			}
		}

		/// <exclude/>
		public Guid TypeId {
			get {
				return GetTypedColumnValue<Guid>("TypeId");
			}
			set {
				SetColumnValue("TypeId", value);
				_type = null;
			}
		}

		/// <exclude/>
		public string TypeName {
			get {
				return GetTypedColumnValue<string>("TypeName");
			}
			set {
				SetColumnValue("TypeName", value);
				if (_type != null) {
					_type.Name = value;
				}
			}
		}

		private CashflowType _type;
		/// <summary>
		/// Type.
		/// </summary>
		public CashflowType Type {
			get {
				return _type ??
					(_type = LookupColumnEntities.GetEntity("Type") as CashflowType);
			}
		}

		/// <summary>
		/// Purpose.
		/// </summary>
		public string Details {
			get {
				return GetTypedColumnValue<string>("Details");
			}
			set {
				SetColumnValue("Details", value);
			}
		}

		/// <exclude/>
		public Guid CategoryId {
			get {
				return GetTypedColumnValue<Guid>("CategoryId");
			}
			set {
				SetColumnValue("CategoryId", value);
				_category = null;
			}
		}

		/// <exclude/>
		public string CategoryName {
			get {
				return GetTypedColumnValue<string>("CategoryName");
			}
			set {
				SetColumnValue("CategoryName", value);
				if (_category != null) {
					_category.Name = value;
				}
			}
		}

		private CashflowCategory _category;
		/// <summary>
		/// Category.
		/// </summary>
		public CashflowCategory Category {
			get {
				return _category ??
					(_category = LookupColumnEntities.GetEntity("Category") as CashflowCategory);
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

		private CashflowStatus _status;
		/// <summary>
		/// Status.
		/// </summary>
		public CashflowStatus Status {
			get {
				return _status ??
					(_status = LookupColumnEntities.GetEntity("Status") as CashflowStatus);
			}
		}

		/// <summary>
		/// Date.
		/// </summary>
		public DateTime Date {
			get {
				return GetTypedColumnValue<DateTime>("Date");
			}
			set {
				SetColumnValue("Date", value);
			}
		}

		/// <exclude/>
		public Guid CurrencyId {
			get {
				return GetTypedColumnValue<Guid>("CurrencyId");
			}
			set {
				SetColumnValue("CurrencyId", value);
				_currency = null;
			}
		}

		/// <exclude/>
		public string CurrencyName {
			get {
				return GetTypedColumnValue<string>("CurrencyName");
			}
			set {
				SetColumnValue("CurrencyName", value);
				if (_currency != null) {
					_currency.Name = value;
				}
			}
		}

		private Currency _currency;
		/// <summary>
		/// Currency.
		/// </summary>
		public Currency Currency {
			get {
				return _currency ??
					(_currency = LookupColumnEntities.GetEntity("Currency") as Currency);
			}
		}

		/// <summary>
		/// Exchange rate.
		/// </summary>
		public Decimal CurrencyRate {
			get {
				return GetTypedColumnValue<Decimal>("CurrencyRate");
			}
			set {
				SetColumnValue("CurrencyRate", value);
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
		/// Amount, base currency.
		/// </summary>
		public Decimal PrimaryAmount {
			get {
				return GetTypedColumnValue<Decimal>("PrimaryAmount");
			}
			set {
				SetColumnValue("PrimaryAmount", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Cashflow_ProjectEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("CashflowDeleted", e);
			Inserting += (s, e) => ThrowEvent("CashflowInserting", e);
			Saved += (s, e) => ThrowEvent("CashflowSaved", e);
			Validating += (s, e) => ThrowEvent("CashflowValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Cashflow(this);
		}

		#endregion

	}

	#endregion

	#region Class: Cashflow_ProjectEventsProcess

	/// <exclude/>
	public partial class Cashflow_ProjectEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : Cashflow
	{

		#region Class: GenerateNumberUserTaskFlowElement

		/// <exclude/>
		public class GenerateNumberUserTaskFlowElement : GenerateSequenseNumberUserTask
		{

			public GenerateNumberUserTaskFlowElement(UserConnection userConnection, Cashflow_ProjectEventsProcess<TEntity> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "GenerateNumberUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("6cf2afd6-e92e-46dc-9746-efa152a8304e");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public Cashflow_ProjectEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Cashflow_ProjectEventsProcess";
			SchemaUId = new Guid("e8e2a77e-01df-4f4b-ae62-12e67d8b0435");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e8e2a77e-01df-4f4b-ae62-12e67d8b0435");
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
					SchemaElementUId = new Guid("6a91956c-f304-4c1b-aa4a-3eadcd22194e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _cashflowSaved;
		public ProcessFlowElement CashflowSaved {
			get {
				return _cashflowSaved ?? (_cashflowSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CashflowSaved",
					SchemaElementUId = new Guid("21887e77-b9c4-47ff-8c2a-204b055efd40"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _setGenerateParamScript;
		public ProcessScriptTask SetGenerateParamScript {
			get {
				return _setGenerateParamScript ?? (_setGenerateParamScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SetGenerateParamScript",
					SchemaElementUId = new Guid("89160baa-9d0e-4f12-86b8-0e2939dd0620"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SetGenerateParamScriptExecute,
				});
			}
		}

		private ProcessTerminateEvent _terminate1;
		public ProcessTerminateEvent Terminate1 {
			get {
				return _terminate1 ?? (_terminate1 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "Terminate1",
					SchemaElementUId = new Guid("1c976ec0-27c0-4103-ad83-77b73c6066cc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway1;
		public ProcessExclusiveGateway ExclusiveGateway1 {
			get {
				return _exclusiveGateway1 ?? (_exclusiveGateway1 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway1",
					SchemaElementUId = new Guid("156294f2-f76f-4fc8-8d88-5b4ce378d6fa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway1.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessScriptTask _setGeneratedNumberScript;
		public ProcessScriptTask SetGeneratedNumberScript {
			get {
				return _setGeneratedNumberScript ?? (_setGeneratedNumberScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SetGeneratedNumberScript",
					SchemaElementUId = new Guid("ed95b7b8-319a-4496-8a53-a0c5d3c09824"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SetGeneratedNumberScriptExecute,
				});
			}
		}

		private GenerateNumberUserTaskFlowElement _generateNumberUserTask;
		public GenerateNumberUserTaskFlowElement GenerateNumberUserTask {
			get {
				return _generateNumberUserTask ?? (_generateNumberUserTask = new GenerateNumberUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessConditionalFlow _conditionalFlow1;
		public ProcessConditionalFlow ConditionalFlow1 {
			get {
				return _conditionalFlow1 ?? (_conditionalFlow1 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow1",
					SchemaElementUId = new Guid("f1b930c9-8b79-4235-821e-7773bafea8c9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[CashflowSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { CashflowSaved };
			FlowElements[SetGenerateParamScript.SchemaElementUId] = new Collection<ProcessFlowElement> { SetGenerateParamScript };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[SetGeneratedNumberScript.SchemaElementUId] = new Collection<ProcessFlowElement> { SetGeneratedNumberScript };
			FlowElements[GenerateNumberUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { GenerateNumberUserTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "CashflowSaved":
						e.Context.QueueTasks.Enqueue("SetGenerateParamScript");
						break;
					case "SetGenerateParamScript":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway1");
						break;
					case "Terminate1":
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("GenerateNumberUserTask");
							break;
						}
						e.Context.QueueTasks.Enqueue("Terminate1");
						break;
					case "SetGeneratedNumberScript":
						break;
					case "GenerateNumberUserTask":
							e.Context.QueueTasks.Enqueue("SetGeneratedNumberScript");
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalFlow1ExpressionExecute() {
			return Convert.ToBoolean(string.IsNullOrEmpty(Entity.GetTypedColumnValue<string>("Number")));
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("CashflowSaved");
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
				case "CashflowSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "CashflowSaved";
					result = CashflowSaved.Execute(context);
					break;
				case "SetGenerateParamScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetGenerateParamScript";
					result = SetGenerateParamScript.Execute(context, SetGenerateParamScriptExecute);
					break;
				case "Terminate1":
					context.QueueTasks.Dequeue();
					break;
				case "ExclusiveGateway1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway1";
					result = ExclusiveGateway1.Execute(context);
					break;
				case "SetGeneratedNumberScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetGeneratedNumberScript";
					result = SetGeneratedNumberScript.Execute(context, SetGeneratedNumberScriptExecute);
					break;
				case "GenerateNumberUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "GenerateNumberUserTask";
					result = GenerateNumberUserTask.Execute(context);
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

		public virtual bool SetGenerateParamScriptExecute(ProcessExecutingContext context) {
			GenerateNumberUserTask.EntitySchema = Entity.Schema;
			return true;
		}

		public virtual bool SetGeneratedNumberScriptExecute(ProcessExecutingContext context) {
			string code = GenerateNumberUserTask.ResultCode;
			var update = new Update(UserConnection, Entity.Schema.Name)
				.Set("Number", Column.Parameter(code))
				.Where("Id").IsEqual(Column.Parameter(Entity.PrimaryColumnValue));
			update.Execute();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "CashflowSaved":
							if (ActivatedEventElements.Contains("CashflowSaved")) {
							context.QueueTasks.Enqueue("CashflowSaved");
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

	#region Class: Cashflow_ProjectEventsProcess

	/// <exclude/>
	public class Cashflow_ProjectEventsProcess : Cashflow_ProjectEventsProcess<Cashflow>
	{

		public Cashflow_ProjectEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Cashflow_ProjectEventsProcess

	public partial class Cashflow_ProjectEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: CashflowEventsProcessSchema

	/// <exclude/>
	public class CashflowEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public CashflowEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CashflowEventsProcessSchema(CashflowEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Cashflow_ProjectEventsProcess";
			UId = new Guid("97d3892e-2f06-495c-9e03-0de6fae043a5");
			CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c");
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

		protected virtual void InitializeGenerateNumberUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("2af8ca6e-4acb-4d3a-830c-9c128260f74f"),
				ContainerUId = new Guid("6cf2afd6-e92e-46dc-9746-efa152a8304e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b9b23348-b89c-4836-8c5b-283ef5ed8666"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b9b23348-b89c-4836-8c5b-283ef5ed8666"),
				Name = @"ResultCode",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("73851f34-9c66-462f-8f81-ee708a53e2eb"),
				ContainerUId = new Guid("6cf2afd6-e92e-46dc-9746-efa152a8304e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b9b23348-b89c-4836-8c5b-283ef5ed8666"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b9b23348-b89c-4836-8c5b-283ef5ed8666"),
				Name = @"EntitySchema",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			});
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSetCashflowSaved = CreateLaneSetCashflowSavedLaneSet();
			LaneSets.Add(schemaLaneSetCashflowSaved);
			ProcessSchemaLane schemaLaneCashflowSaved = CreateLaneCashflowSavedLane();
			schemaLaneSetCashflowSaved.Lanes.Add(schemaLaneCashflowSaved);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaStartMessageEvent cashflowsaved = CreateCashflowSavedStartMessageEvent();
			eventsubprocess1.FlowElements.Add(cashflowsaved);
			ProcessSchemaScriptTask setgenerateparamscript = CreateSetGenerateParamScriptScriptTask();
			eventsubprocess1.FlowElements.Add(setgenerateparamscript);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			eventsubprocess1.FlowElements.Add(terminate1);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			eventsubprocess1.FlowElements.Add(exclusivegateway1);
			ProcessSchemaScriptTask setgeneratednumberscript = CreateSetGeneratedNumberScriptScriptTask();
			eventsubprocess1.FlowElements.Add(setgeneratednumberscript);
			ProcessSchemaUserTask generatenumberusertask = CreateGenerateNumberUserTaskUserTask();
			eventsubprocess1.FlowElements.Add(generatenumberusertask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("9e9e5ad6-6cd4-47e8-ba20-2424399201ea"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("97d3892e-2f06-495c-9e03-0de6fae043a5"),
				CurveCenterPosition = new Point(166, 96),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("97d3892e-2f06-495c-9e03-0de6fae043a5"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("21887e77-b9c4-47ff-8c2a-204b055efd40"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("89160baa-9d0e-4f12-86b8-0e2939dd0620"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("f8595779-fd7f-4874-b4cc-45c95c894608"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("97d3892e-2f06-495c-9e03-0de6fae043a5"),
				CurveCenterPosition = new Point(274, 96),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("97d3892e-2f06-495c-9e03-0de6fae043a5"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("89160baa-9d0e-4f12-86b8-0e2939dd0620"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("156294f2-f76f-4fc8-8d88-5b4ce378d6fa"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow3",
				UId = new Guid("458ce5a5-1db8-4b96-a47e-6c4609ef6dc0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("97d3892e-2f06-495c-9e03-0de6fae043a5"),
				CurveCenterPosition = new Point(316, 162),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("97d3892e-2f06-495c-9e03-0de6fae043a5"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("156294f2-f76f-4fc8-8d88-5b4ce378d6fa"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1c976ec0-27c0-4103-ad83-77b73c6066cc"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("f1b930c9-8b79-4235-821e-7773bafea8c9"),
				ConditionExpression = @"string.IsNullOrEmpty(Entity.GetTypedColumnValue<string>(""Number""))",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("97d3892e-2f06-495c-9e03-0de6fae043a5"),
				CurveCenterPosition = new Point(365, 100),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("97d3892e-2f06-495c-9e03-0de6fae043a5"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("156294f2-f76f-4fc8-8d88-5b4ce378d6fa"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6cf2afd6-e92e-46dc-9746-efa152a8304e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("458c51f4-c845-4ed2-838c-ebe6721c15a0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("97d3892e-2f06-495c-9e03-0de6fae043a5"),
				CurveCenterPosition = new Point(488, 101),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("97d3892e-2f06-495c-9e03-0de6fae043a5"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6cf2afd6-e92e-46dc-9746-efa152a8304e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ed95b7b8-319a-4496-8a53-a0c5d3c09824"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSetCashflowSavedLaneSet() {
			ProcessSchemaLaneSet schemaLaneSetCashflowSaved = new ProcessSchemaLaneSet(this) {
				UId = new Guid("f356e210-67cb-44de-880f-36e3af5b9083"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("97d3892e-2f06-495c-9e03-0de6fae043a5"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("97d3892e-2f06-495c-9e03-0de6fae043a5"),
				Name = @"LaneSetCashflowSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1024, 273),
				UseBackgroundMode = false
			};
			return schemaLaneSetCashflowSaved;
		}

		protected virtual ProcessSchemaLane CreateLaneCashflowSavedLane() {
			ProcessSchemaLane schemaLaneCashflowSaved = new ProcessSchemaLane(this) {
				UId = new Guid("afece26f-83c8-4cff-aaa8-f8b6e2a5a8b5"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("f356e210-67cb-44de-880f-36e3af5b9083"),
				CreatedInOwnerSchemaUId = new Guid("e8e2a77e-01df-4f4b-ae62-12e67d8b0435"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("97d3892e-2f06-495c-9e03-0de6fae043a5"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("97d3892e-2f06-495c-9e03-0de6fae043a5"),
				Name = @"LaneCashflowSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(995, 273),
				UseBackgroundMode = false
			};
			return schemaLaneCashflowSaved;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("6a91956c-f304-4c1b-aa4a-3eadcd22194e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("afece26f-83c8-4cff-aaa8-f8b6e2a5a8b5"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("97d3892e-2f06-495c-9e03-0de6fae043a5"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("97d3892e-2f06-495c-9e03-0de6fae043a5"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(35, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(602, 245),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCashflowSavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("21887e77-b9c4-47ff-8c2a-204b055efd40"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6a91956c-f304-4c1b-aa4a-3eadcd22194e"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("97d3892e-2f06-495c-9e03-0de6fae043a5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CashflowSaved",
				ModifiedInSchemaUId = new Guid("97d3892e-2f06-495c-9e03-0de6fae043a5"),
				Name = @"CashflowSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSetGenerateParamScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("89160baa-9d0e-4f12-86b8-0e2939dd0620"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6a91956c-f304-4c1b-aa4a-3eadcd22194e"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("97d3892e-2f06-495c-9e03-0de6fae043a5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("97d3892e-2f06-495c-9e03-0de6fae043a5"),
				Name = @"SetGenerateParamScript",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(106, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,79,205,75,45,74,44,73,245,43,205,77,74,45,10,45,78,45,10,73,44,206,214,115,205,43,201,44,169,12,78,206,72,205,77,84,176,85,128,112,245,32,124,107,94,174,162,212,146,210,162,60,133,146,162,210,84,107,0,137,141,144,78,66,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("1c976ec0-27c0-4103-ad83-77b73c6066cc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6a91956c-f304-4c1b-aa4a-3eadcd22194e"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("97d3892e-2f06-495c-9e03-0de6fae043a5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("97d3892e-2f06-495c-9e03-0de6fae043a5"),
				Name = @"Terminate1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(232, 170),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("156294f2-f76f-4fc8-8d88-5b4ce378d6fa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6a91956c-f304-4c1b-aa4a-3eadcd22194e"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("97d3892e-2f06-495c-9e03-0de6fae043a5"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("97d3892e-2f06-495c-9e03-0de6fae043a5"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(218, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateSetGeneratedNumberScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ed95b7b8-319a-4496-8a53-a0c5d3c09824"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6a91956c-f304-4c1b-aa4a-3eadcd22194e"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("97d3892e-2f06-495c-9e03-0de6fae043a5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("97d3892e-2f06-495c-9e03-0de6fae043a5"),
				Name = @"SetGeneratedNumberScript",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(435, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,142,203,110,194,64,12,69,215,32,241,15,163,172,38,18,154,31,64,93,69,17,98,131,16,175,174,221,228,170,68,100,28,240,216,180,252,61,19,210,93,151,246,61,190,62,73,165,227,111,215,12,45,220,135,91,131,33,164,216,90,252,130,156,18,228,72,233,26,246,72,214,107,149,153,213,98,254,32,113,118,107,51,149,15,24,63,238,244,30,252,72,87,3,51,26,237,6,94,186,154,181,211,103,56,52,23,68,10,91,138,40,23,243,89,56,64,125,49,245,23,75,87,13,189,69,14,59,146,156,43,196,143,34,229,27,252,188,64,224,139,77,91,148,97,147,234,187,81,239,255,225,127,79,118,210,69,146,231,20,159,169,183,220,145,85,39,205,80,255,162,177,108,56,174,4,106,194,78,197,176,122,1,78,21,183,212,252,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateGenerateNumberUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("6cf2afd6-e92e-46dc-9746-efa152a8304e"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6a91956c-f304-4c1b-aa4a-3eadcd22194e"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c"),
				CreatedInSchemaUId = new Guid("97d3892e-2f06-495c-9e03-0de6fae043a5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("97d3892e-2f06-495c-9e03-0de6fae043a5"),
				Name = @"GenerateNumberUserTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(309, 51),
				SchemaUId = new Guid("b9b23348-b89c-4836-8c5b-283ef5ed8666"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeGenerateNumberUserTaskParameters(schemaTask);
			return schemaTask;
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
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("6ab05131-1cb5-4886-8c5e-4437f132bb8c")
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
			return new CashflowEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("97d3892e-2f06-495c-9e03-0de6fae043a5"));
		}

		#endregion

	}

	#endregion


	#region Class: CashflowEventsProcess

	/// <exclude/>
	public class CashflowEventsProcess : Cashflow_ProjectEventsProcess
	{

		public CashflowEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

