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

	#region Class: Document_Document_TerrasoftSchema

	/// <exclude/>
	public class Document_Document_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public Document_Document_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Document_Document_TerrasoftSchema(Document_Document_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Document_Document_TerrasoftSchema(Document_Document_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09");
			RealUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09");
			Name = "Document_Document_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
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

		protected override void InitializeOwnerColumn() {
			base.InitializeOwnerColumn();
			OwnerColumn = CreateOwnerColumn();
			if (Columns.FindByUId(OwnerColumn.UId) == null) {
				Columns.Add(OwnerColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("964aedc1-7673-4d96-8b3f-8bc8f2829fff")) == null) {
				Columns.Add(CreateDateColumn());
			}
			if (Columns.FindByUId(new Guid("923d55f5-b690-46ae-9337-0400d63814d1")) == null) {
				Columns.Add(CreateTypeColumn());
			}
			if (Columns.FindByUId(new Guid("6f97a26f-a592-40f0-a233-d4363a35f471")) == null) {
				Columns.Add(CreateAccountColumn());
			}
			if (Columns.FindByUId(new Guid("cf24fdae-dd9e-43d8-a5d6-47b6fd9e4daa")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("3a5ca495-43bc-4b03-af8a-c297f9166fd0")) == null) {
				Columns.Add(CreateNotesColumn());
			}
			if (Columns.FindByUId(new Guid("e2596e4a-8da7-47f5-9898-e6cce28fc2f8")) == null) {
				Columns.Add(CreatePaymentAmountColumn());
			}
			if (Columns.FindByUId(new Guid("570b8a4d-9d3e-49b6-8e71-a77e27b2dad3")) == null) {
				Columns.Add(CreatePrimaryPaymentAmountColumn());
			}
			if (Columns.FindByUId(new Guid("03791254-7218-4176-8e38-7c053da06e40")) == null) {
				Columns.Add(CreatePaymentDateColumn());
			}
			if (Columns.FindByUId(new Guid("b02642bd-8ec6-45af-9998-ea803ca5c9c3")) == null) {
				Columns.Add(CreateStateColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.IsTrackChangesInDB = true;
			column.ModifiedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.IsTrackChangesInDB = true;
			column.ModifiedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.IsTrackChangesInDB = true;
			column.ModifiedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09");
			return column;
		}

		protected virtual EntitySchemaColumn CreateNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("927e4338-f861-42c1-8b0b-7bbb78ffff4b"),
				Name = @"Number",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				ModifiedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsTrackChangesInDB = true
			};
		}

		protected virtual EntitySchemaColumn CreateDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("964aedc1-7673-4d96-8b3f-8bc8f2829fff"),
				Name = @"Date",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				ModifiedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsTrackChangesInDB = true,
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentDate")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("923d55f5-b690-46ae-9337-0400d63814d1"),
				Name = @"Type",
				ReferenceSchemaUId = new Guid("fe5e6306-c1ae-454f-87fb-108461dd71f5"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				ModifiedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsTrackChangesInDB = true
			};
		}

		protected virtual EntitySchemaColumn CreateAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6f97a26f-a592-40f0-a233-d4363a35f471"),
				Name = @"Account",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				ModifiedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsTrackChangesInDB = true
			};
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("cf24fdae-dd9e-43d8-a5d6-47b6fd9e4daa"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				ModifiedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsTrackChangesInDB = true
			};
		}

		protected virtual EntitySchemaColumn CreateOwnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8f214196-e457-4163-90b3-3b397961215c"),
				Name = @"Owner",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				ModifiedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentUserContact")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateNotesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("3a5ca495-43bc-4b03-af8a-c297f9166fd0"),
				Name = @"Notes",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				ModifiedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreatePaymentAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("e2596e4a-8da7-47f5-9898-e6cce28fc2f8"),
				Name = @"PaymentAmount",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				ModifiedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				CreatedInPackageId = new Guid("648f05a8-9401-440d-98ee-c77984ac3b4b")
			};
		}

		protected virtual EntitySchemaColumn CreatePrimaryPaymentAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("570b8a4d-9d3e-49b6-8e71-a77e27b2dad3"),
				Name = @"PrimaryPaymentAmount",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				ModifiedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				CreatedInPackageId = new Guid("648f05a8-9401-440d-98ee-c77984ac3b4b")
			};
		}

		protected virtual EntitySchemaColumn CreatePaymentDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("03791254-7218-4176-8e38-7c053da06e40"),
				Name = @"PaymentDate",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				ModifiedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				CreatedInPackageId = new Guid("648f05a8-9401-440d-98ee-c77984ac3b4b")
			};
		}

		protected virtual EntitySchemaColumn CreateStateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b02642bd-8ec6-45af-9998-ea803ca5c9c3"),
				Name = @"State",
				ReferenceSchemaUId = new Guid("3fa49baa-57d4-40d7-9293-1e6742b1b0dd"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				ModifiedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				CreatedInPackageId = new Guid("93f2b0e4-b421-42dc-86e5-35e5b932239c"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"2144d9a6-b446-4afd-a52d-41f1b1910546"
				}
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateDocument_Document_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateDocument_Document_TerrasoftEventsProcessSchema() {
			var schema = new Document_Document_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Document_Document_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Document_DocumentEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Document_Document_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Document_Document_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"));
		}

		#endregion

	}

	#endregion

	#region Class: Document_Document_Terrasoft

	/// <summary>
	/// Document.
	/// </summary>
	public class Document_Document_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public Document_Document_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Document_Document_Terrasoft";
		}

		public Document_Document_Terrasoft(Document_Document_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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

		private DocumentType _type;
		/// <summary>
		/// Type.
		/// </summary>
		public DocumentType Type {
			get {
				return _type ??
					(_type = LookupColumnEntities.GetEntity("Type") as DocumentType);
			}
		}

		/// <exclude/>
		public Guid AccountId {
			get {
				return GetTypedColumnValue<Guid>("AccountId");
			}
			set {
				SetColumnValue("AccountId", value);
				_account = null;
			}
		}

		/// <exclude/>
		public string AccountName {
			get {
				return GetTypedColumnValue<string>("AccountName");
			}
			set {
				SetColumnValue("AccountName", value);
				if (_account != null) {
					_account.Name = value;
				}
			}
		}

		private Account _account;
		/// <summary>
		/// Account.
		/// </summary>
		public Account Account {
			get {
				return _account ??
					(_account = LookupColumnEntities.GetEntity("Account") as Account);
			}
		}

		/// <exclude/>
		public Guid ContactId {
			get {
				return GetTypedColumnValue<Guid>("ContactId");
			}
			set {
				SetColumnValue("ContactId", value);
				_contact = null;
			}
		}

		/// <exclude/>
		public string ContactName {
			get {
				return GetTypedColumnValue<string>("ContactName");
			}
			set {
				SetColumnValue("ContactName", value);
				if (_contact != null) {
					_contact.Name = value;
				}
			}
		}

		private Contact _contact;
		/// <summary>
		/// Contact.
		/// </summary>
		public Contact Contact {
			get {
				return _contact ??
					(_contact = LookupColumnEntities.GetEntity("Contact") as Contact);
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
		/// Payment amount.
		/// </summary>
		public Decimal PaymentAmount {
			get {
				return GetTypedColumnValue<Decimal>("PaymentAmount");
			}
			set {
				SetColumnValue("PaymentAmount", value);
			}
		}

		/// <summary>
		/// Payment amount, base currency.
		/// </summary>
		public Decimal PrimaryPaymentAmount {
			get {
				return GetTypedColumnValue<Decimal>("PrimaryPaymentAmount");
			}
			set {
				SetColumnValue("PrimaryPaymentAmount", value);
			}
		}

		/// <summary>
		/// Paid on.
		/// </summary>
		public DateTime PaymentDate {
			get {
				return GetTypedColumnValue<DateTime>("PaymentDate");
			}
			set {
				SetColumnValue("PaymentDate", value);
			}
		}

		/// <exclude/>
		public Guid StateId {
			get {
				return GetTypedColumnValue<Guid>("StateId");
			}
			set {
				SetColumnValue("StateId", value);
				_state = null;
			}
		}

		/// <exclude/>
		public string StateName {
			get {
				return GetTypedColumnValue<string>("StateName");
			}
			set {
				SetColumnValue("StateName", value);
				if (_state != null) {
					_state.Name = value;
				}
			}
		}

		private DocumentState _state;
		/// <summary>
		/// Status.
		/// </summary>
		public DocumentState State {
			get {
				return _state ??
					(_state = LookupColumnEntities.GetEntity("State") as DocumentState);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Document_DocumentEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Document_Document_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("Document_Document_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("Document_Document_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("Document_Document_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("Document_Document_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Document_Document_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Document_Document_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Document_Document_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Document_DocumentEventsProcess

	/// <exclude/>
	public partial class Document_DocumentEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : Document_Document_Terrasoft
	{

		#region Class: GenerateNumberUserTaskFlowElement

		/// <exclude/>
		public class GenerateNumberUserTaskFlowElement : GenerateSequenseNumberUserTask
		{

			public GenerateNumberUserTaskFlowElement(UserConnection userConnection, Document_DocumentEventsProcess<TEntity> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "GenerateNumberUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("bb924708-fdf2-4864-a070-ef328b4eba6e");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public Document_DocumentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Document_DocumentEventsProcess";
			SchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual bool IsNew {
			get;
			set;
		}

		public virtual bool NeedFinRecalc {
			get;
			set;
		}

		private ProcessFlowElement _subProcess1;
		public ProcessFlowElement SubProcess1 {
			get {
				return _subProcess1 ?? (_subProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess1",
					SchemaElementUId = new Guid("29ab6612-b1bd-4d61-953e-a377f6471c01"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _documentSaved;
		public ProcessFlowElement DocumentSaved {
			get {
				return _documentSaved ?? (_documentSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DocumentSaved",
					SchemaElementUId = new Guid("5e4fc7be-dce7-4805-9a0c-ccb83a6b422f"),
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
					SchemaElementUId = new Guid("959d55af-d85a-46d3-83e5-d7f54cfbffcc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SetGenerateParamScriptExecute,
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
					SchemaElementUId = new Guid("09ecf56e-5ce5-4794-895e-e95971f31de6"),
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

		private GenerateNumberUserTaskFlowElement _generateNumberUserTask;
		public GenerateNumberUserTaskFlowElement GenerateNumberUserTask {
			get {
				return _generateNumberUserTask ?? (_generateNumberUserTask = new GenerateNumberUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("a4b2d458-95cb-48fd-998f-2386b064b78f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SetGeneratedNumberScriptExecute,
				});
			}
		}

		private ProcessEndEvent _end1;
		public ProcessEndEvent End1 {
			get {
				return _end1 ?? (_end1 = new ProcessEndEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEndEvent",
					Name = "End1",
					SchemaElementUId = new Guid("fd6d7db4-299c-4fdf-9124-9108834f34bf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _changeRightsScriptTask;
		public ProcessScriptTask ChangeRightsScriptTask {
			get {
				return _changeRightsScriptTask ?? (_changeRightsScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChangeRightsScriptTask",
					SchemaElementUId = new Guid("bd556e16-5646-48ab-af01-3f6e4efbacd7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChangeRightsScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _financeRecalculationScriptTask;
		public ProcessScriptTask FinanceRecalculationScriptTask {
			get {
				return _financeRecalculationScriptTask ?? (_financeRecalculationScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "FinanceRecalculationScriptTask",
					SchemaElementUId = new Guid("faf5856b-ebb1-473d-a2ef-bf0805288e6e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = FinanceRecalculationScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessDocumentSaving;
		public ProcessFlowElement EventSubProcessDocumentSaving {
			get {
				return _eventSubProcessDocumentSaving ?? (_eventSubProcessDocumentSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessDocumentSaving",
					SchemaElementUId = new Guid("95eea31a-db9c-433a-b136-7c5b5dc41f46"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _documentSaving;
		public ProcessFlowElement DocumentSaving {
			get {
				return _documentSaving ?? (_documentSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DocumentSaving",
					SchemaElementUId = new Guid("532a7731-ee3a-456f-a96f-d01f310467ba"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptDocumentSaving;
		public ProcessScriptTask ScriptDocumentSaving {
			get {
				return _scriptDocumentSaving ?? (_scriptDocumentSaving = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptDocumentSaving",
					SchemaElementUId = new Guid("303ec553-1575-4a73-86c2-67e615c148f4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDocumentSavingExecute,
				});
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
					SchemaElementUId = new Guid("65d38b9c-13f0-42ac-af9b-b0f7a714c9ed"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage1DocumentDeleting;
		public ProcessFlowElement StartMessage1DocumentDeleting {
			get {
				return _startMessage1DocumentDeleting ?? (_startMessage1DocumentDeleting = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage1DocumentDeleting",
					SchemaElementUId = new Guid("af09f93a-a018-47a2-a34b-057237316bc2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _documentDeletingScriptTask;
		public ProcessScriptTask DocumentDeletingScriptTask {
			get {
				return _documentDeletingScriptTask ?? (_documentDeletingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DocumentDeletingScriptTask",
					SchemaElementUId = new Guid("178bd67b-1f83-44df-ad20-ce8d70425680"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DocumentDeletingScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess2;
		public ProcessFlowElement EventSubProcess2 {
			get {
				return _eventSubProcess2 ?? (_eventSubProcess2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess2",
					SchemaElementUId = new Guid("945c922f-6ce6-4766-8fc7-c20e7120b611"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _documentInsertedScriptTask;
		public ProcessScriptTask DocumentInsertedScriptTask {
			get {
				return _documentInsertedScriptTask ?? (_documentInsertedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DocumentInsertedScriptTask",
					SchemaElementUId = new Guid("880ea32c-dd15-4516-8be3-d8464b1caa25"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DocumentInsertedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _documentInsertedStartMessage;
		public ProcessFlowElement DocumentInsertedStartMessage {
			get {
				return _documentInsertedStartMessage ?? (_documentInsertedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DocumentInsertedStartMessage",
					SchemaElementUId = new Guid("970007fc-ed3e-48fc-9837-5a0812a2eb2d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
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
					SchemaElementUId = new Guid("c0b177ac-b0fa-4fba-ac7d-b5ed41db73c1"),
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
			FlowElements[SubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess1 };
			FlowElements[DocumentSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { DocumentSaved };
			FlowElements[SetGenerateParamScript.SchemaElementUId] = new Collection<ProcessFlowElement> { SetGenerateParamScript };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[GenerateNumberUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { GenerateNumberUserTask };
			FlowElements[SetGeneratedNumberScript.SchemaElementUId] = new Collection<ProcessFlowElement> { SetGeneratedNumberScript };
			FlowElements[End1.SchemaElementUId] = new Collection<ProcessFlowElement> { End1 };
			FlowElements[ChangeRightsScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeRightsScriptTask };
			FlowElements[FinanceRecalculationScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { FinanceRecalculationScriptTask };
			FlowElements[EventSubProcessDocumentSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessDocumentSaving };
			FlowElements[DocumentSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { DocumentSaving };
			FlowElements[ScriptDocumentSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDocumentSaving };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessage1DocumentDeleting.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1DocumentDeleting };
			FlowElements[DocumentDeletingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DocumentDeletingScriptTask };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[DocumentInsertedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DocumentInsertedScriptTask };
			FlowElements[DocumentInsertedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DocumentInsertedStartMessage };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SubProcess1":
						break;
					case "DocumentSaved":
						e.Context.QueueTasks.Enqueue("SetGenerateParamScript");
						e.Context.QueueTasks.Enqueue("ChangeRightsScriptTask");
						e.Context.QueueTasks.Enqueue("FinanceRecalculationScriptTask");
						break;
					case "SetGenerateParamScript":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway1");
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("GenerateNumberUserTask");
							break;
						}
						e.Context.QueueTasks.Enqueue("End1");
						break;
					case "GenerateNumberUserTask":
							e.Context.QueueTasks.Enqueue("SetGeneratedNumberScript");
						break;
					case "SetGeneratedNumberScript":
						break;
					case "End1":
						break;
					case "ChangeRightsScriptTask":
						break;
					case "FinanceRecalculationScriptTask":
						break;
					case "EventSubProcessDocumentSaving":
						break;
					case "DocumentSaving":
						e.Context.QueueTasks.Enqueue("ScriptDocumentSaving");
						break;
					case "ScriptDocumentSaving":
						break;
					case "EventSubProcess1":
						break;
					case "StartMessage1DocumentDeleting":
						e.Context.QueueTasks.Enqueue("DocumentDeletingScriptTask");
						break;
					case "DocumentDeletingScriptTask":
						break;
					case "EventSubProcess2":
						break;
					case "DocumentInsertedScriptTask":
						break;
					case "DocumentInsertedStartMessage":
						e.Context.QueueTasks.Enqueue("DocumentInsertedScriptTask");
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
			ActivatedEventElements.Add("DocumentSaved");
			ActivatedEventElements.Add("DocumentSaving");
			ActivatedEventElements.Add("StartMessage1DocumentDeleting");
			ActivatedEventElements.Add("DocumentInsertedStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "DocumentSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "DocumentSaved";
					result = DocumentSaved.Execute(context);
					break;
				case "SetGenerateParamScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetGenerateParamScript";
					result = SetGenerateParamScript.Execute(context, SetGenerateParamScriptExecute);
					break;
				case "ExclusiveGateway1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway1";
					result = ExclusiveGateway1.Execute(context);
					break;
				case "GenerateNumberUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "GenerateNumberUserTask";
					result = GenerateNumberUserTask.Execute(context);
					break;
				case "SetGeneratedNumberScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetGeneratedNumberScript";
					result = SetGeneratedNumberScript.Execute(context, SetGeneratedNumberScriptExecute);
					break;
				case "End1":
					context.QueueTasks.Dequeue();
					break;
				case "ChangeRightsScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeRightsScriptTask";
					result = ChangeRightsScriptTask.Execute(context, ChangeRightsScriptTaskExecute);
					break;
				case "FinanceRecalculationScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "FinanceRecalculationScriptTask";
					result = FinanceRecalculationScriptTask.Execute(context, FinanceRecalculationScriptTaskExecute);
					break;
				case "EventSubProcessDocumentSaving":
					context.QueueTasks.Dequeue();
					break;
				case "DocumentSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "DocumentSaving";
					result = DocumentSaving.Execute(context);
					break;
				case "ScriptDocumentSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptDocumentSaving";
					result = ScriptDocumentSaving.Execute(context, ScriptDocumentSavingExecute);
					break;
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage1DocumentDeleting":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1DocumentDeleting";
					result = StartMessage1DocumentDeleting.Execute(context);
					break;
				case "DocumentDeletingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DocumentDeletingScriptTask";
					result = DocumentDeletingScriptTask.Execute(context, DocumentDeletingScriptTaskExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "DocumentInsertedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DocumentInsertedScriptTask";
					result = DocumentInsertedScriptTask.Execute(context, DocumentInsertedScriptTaskExecute);
					break;
				case "DocumentInsertedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "DocumentInsertedStartMessage";
					result = DocumentInsertedStartMessage.Execute(context);
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
				case "NeedFinRecalc":
					NeedFinRecalc = reader.GetValue<System.Boolean>();
				break;
				case "IsNew":
					IsNew = reader.GetValue<System.Boolean>();
				break;
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

		public virtual bool ChangeRightsScriptTaskExecute(ProcessExecutingContext context) {
			var ownerId = Entity.GetTypedColumnValue<Guid>("OwnerId");
			var oldOwnerId = Entity.GetTypedOldColumnValue<Guid>("OwnerId");
			if (ownerId != oldOwnerId) {
				if (ownerId != Guid.Empty && ownerId != UserConnection.CurrentUser.ContactId) {
					//AddWrightRights(ownerId);
				}
				if (oldOwnerId != Guid.Empty && oldOwnerId != UserConnection.CurrentUser.ContactId) {
					//RemoveWrightRights(oldOwnerId);
				}
			}
			return true;
		}

		public virtual bool FinanceRecalculationScriptTaskExecute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool ScriptDocumentSavingExecute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool DocumentDeletingScriptTaskExecute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool DocumentInsertedScriptTaskExecute(ProcessExecutingContext context) {
			IsNew = true;
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Document_Document_TerrasoftSaved":
							if (ActivatedEventElements.Contains("DocumentSaved")) {
							context.QueueTasks.Enqueue("DocumentSaved");
						}
						break;
					case "Document_Document_TerrasoftSaving":
							if (ActivatedEventElements.Contains("DocumentSaving")) {
							context.QueueTasks.Enqueue("DocumentSaving");
						}
						break;
					case "Document_Document_TerrasoftDeleting":
							if (ActivatedEventElements.Contains("StartMessage1DocumentDeleting")) {
							context.QueueTasks.Enqueue("StartMessage1DocumentDeleting");
						}
						break;
					case "Document_Document_TerrasoftInserted":
							if (ActivatedEventElements.Contains("DocumentInsertedStartMessage")) {
							context.QueueTasks.Enqueue("DocumentInsertedStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("NeedFinRecalc") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("NeedFinRecalc", NeedFinRecalc, false);
			}
			if (!HasMapping("IsNew") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsNew", IsNew, false);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: Document_DocumentEventsProcess

	/// <exclude/>
	public class Document_DocumentEventsProcess : Document_DocumentEventsProcess<Document_Document_Terrasoft>
	{

		public Document_DocumentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Document_DocumentEventsProcess

	public partial class Document_DocumentEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual decimal Multiply(decimal arg1, decimal arg2) {
			return Math.Round(arg1 * arg2,2);
		}

		public virtual decimal Division(decimal arg1, decimal arg2) {
			decimal result = 0;
			if(arg2 > 0){
				result = Math.Round(arg1 / arg2, 2);
			}
			return result;
		}

		public virtual void AddWrightRights(Guid documentOwnerId) {
			var dbSecurityEngine = UserConnection.DBSecurityEngine;
			var sysAdminUnitESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "SysAdminUnit");
			var primaryColumn = sysAdminUnitESQ.AddColumn(sysAdminUnitESQ.RootSchema.GetPrimaryColumnName()); 
			sysAdminUnitESQ.Filters.Add(sysAdminUnitESQ.CreateFilterWithParameters(FilterComparisonType.Equal, "Contact", documentOwnerId));
			var sysAdminUnits = sysAdminUnitESQ.GetEntityCollection(UserConnection);
			if (sysAdminUnits.Count > 0) {
				var adminUnitId = Guid.Empty;
				foreach (var sysAdminUnit in sysAdminUnits) {
					adminUnitId = sysAdminUnit.GetTypedColumnValue<Guid>(primaryColumn.Name);
					if (dbSecurityEngine.GetIsEntitySchemaAdministratedByRecords("Document")) {
						dbSecurityEngine.SetEntitySchemaRecordRightLevel(adminUnitId, Entity.Schema.Name, Entity.PrimaryColumnValue,
								EntitySchemaRecordRightOperation.Read, EntitySchemaRecordRightLevel.AllowAndGrant, Guid.Empty, true);
						dbSecurityEngine.SetEntitySchemaRecordRightLevel(adminUnitId, Entity.Schema.Name, Entity.PrimaryColumnValue,
								EntitySchemaRecordRightOperation.Edit, EntitySchemaRecordRightLevel.AllowAndGrant, Guid.Empty, true);
					}
				}
			}
			
		}

		public virtual void RemoveWrightRights(Guid documentOwnerId) {
			var dbSecurityEngine = UserConnection.DBSecurityEngine;
			var sysAdminUnitESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "SysAdminUnit");
			var primaryColumn = sysAdminUnitESQ.AddColumn(sysAdminUnitESQ.RootSchema.GetPrimaryColumnName()); 
			sysAdminUnitESQ.Filters.Add(sysAdminUnitESQ.CreateFilterWithParameters(FilterComparisonType.Equal, "Contact", documentOwnerId));
			var sysAdminUnits = sysAdminUnitESQ.GetEntityCollection(UserConnection);
			if (sysAdminUnits.Count > 0) {
				var adminUnitId = Guid.Empty;
				foreach (var sysAdminUnit in sysAdminUnits) {
					adminUnitId = sysAdminUnit.GetTypedColumnValue<Guid>(primaryColumn.Name);
					if (UserConnection.DBSecurityEngine.GetIsEntitySchemaAdministratedByRecords("Document")) {
						UserConnection.DBSecurityEngine.SetEntitySchemaRecordRightLevel(adminUnitId, Entity.Schema.Name, Entity.PrimaryColumnValue,
										EntitySchemaRecordRightOperation.Edit, EntitySchemaRecordRightLevel.Deny, Guid.Empty, true);
					}
				}
			}
		}

		#endregion

	}

	#endregion

	#region Class: Document_Document_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Document_Document_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public Document_Document_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Document_Document_TerrasoftEventsProcessSchema(Document_Document_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Document_DocumentEventsProcess";
			UId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4");
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

		protected virtual ProcessSchemaParameter CreateIsNewParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c1045dc6-8853-4c2d-ac2f-8fad707ab570"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				Name = @"IsNew",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNeedFinRecalcParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4d1722e0-2bbc-4df6-9d42-d5f7c903ce15"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				Name = @"NeedFinRecalc",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateIsNewParameter());
			Parameters.Add(CreateNeedFinRecalcParameter());
		}

		protected virtual void InitializeGenerateNumberUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("ba2536c3-880e-4dbe-b4bc-29ba00839df2"),
				ContainerUId = new Guid("bb924708-fdf2-4864-a070-ef328b4eba6e"),
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
				UId = new Guid("044f9ea4-9717-42ba-9d62-2d4924ea8ff3"),
				ContainerUId = new Guid("bb924708-fdf2-4864-a070-ef328b4eba6e"),
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
			ProcessSchemaLaneSet schemaLaneSet394 = CreateLaneSet394LaneSet();
			LaneSets.Add(schemaLaneSet394);
			ProcessSchemaLane schemaLane1192 = CreateLane1192Lane();
			schemaLaneSet394.Lanes.Add(schemaLane1192);
			ProcessSchemaEventSubProcess subprocess1 = CreateSubProcess1EventSubProcess();
			FlowElements.Add(subprocess1);
			ProcessSchemaEventSubProcess eventsubprocessdocumentsaving = CreateEventSubProcessDocumentSavingEventSubProcess();
			FlowElements.Add(eventsubprocessdocumentsaving);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaStartMessageEvent documentsaved = CreateDocumentSavedStartMessageEvent();
			subprocess1.FlowElements.Add(documentsaved);
			ProcessSchemaScriptTask setgenerateparamscript = CreateSetGenerateParamScriptScriptTask();
			subprocess1.FlowElements.Add(setgenerateparamscript);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			subprocess1.FlowElements.Add(exclusivegateway1);
			ProcessSchemaUserTask generatenumberusertask = CreateGenerateNumberUserTaskUserTask();
			subprocess1.FlowElements.Add(generatenumberusertask);
			ProcessSchemaScriptTask setgeneratednumberscript = CreateSetGeneratedNumberScriptScriptTask();
			subprocess1.FlowElements.Add(setgeneratednumberscript);
			ProcessSchemaEndEvent end1 = CreateEnd1EndEvent();
			subprocess1.FlowElements.Add(end1);
			ProcessSchemaScriptTask changerightsscripttask = CreateChangeRightsScriptTaskScriptTask();
			subprocess1.FlowElements.Add(changerightsscripttask);
			ProcessSchemaScriptTask financerecalculationscripttask = CreateFinanceRecalculationScriptTaskScriptTask();
			subprocess1.FlowElements.Add(financerecalculationscripttask);
			ProcessSchemaStartMessageEvent documentsaving = CreateDocumentSavingStartMessageEvent();
			eventsubprocessdocumentsaving.FlowElements.Add(documentsaving);
			ProcessSchemaScriptTask scriptdocumentsaving = CreateScriptDocumentSavingScriptTask();
			eventsubprocessdocumentsaving.FlowElements.Add(scriptdocumentsaving);
			ProcessSchemaStartMessageEvent startmessage1documentdeleting = CreateStartMessage1DocumentDeletingStartMessageEvent();
			eventsubprocess1.FlowElements.Add(startmessage1documentdeleting);
			ProcessSchemaScriptTask documentdeletingscripttask = CreateDocumentDeletingScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(documentdeletingscripttask);
			ProcessSchemaScriptTask documentinsertedscripttask = CreateDocumentInsertedScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(documentinsertedscripttask);
			ProcessSchemaStartMessageEvent documentinsertedstartmessage = CreateDocumentInsertedStartMessageStartMessageEvent();
			eventsubprocess2.FlowElements.Add(documentinsertedstartmessage);
			FlowElements.Add(CreateDocumentSavingSequenceFlowSequenceFlow());
			FlowElements.Add(CreateSequenceFlow1223SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1327SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1776SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateDocumentDeletingSequenceFlowSequenceFlow());
			FlowElements.Add(CreateChangeRightsScriptTaskSequenceFlowSequenceFlow());
			FlowElements.Add(CreateDocumentInsertedSequenceFlowSequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateDocumentSavingSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "DocumentSavingSequenceFlow",
				UId = new Guid("17734062-0d53-4937-96eb-c53e9b60c1fb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				CurveCenterPosition = new Point(145, 252),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("532a7731-ee3a-456f-a96f-d01f310467ba"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("303ec553-1575-4a73-86c2-67e615c148f4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1223SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1223",
				UId = new Guid("70ebf43c-2d72-4d68-83e3-f66311d8d6b1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				CurveCenterPosition = new Point(126, 157),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5e4fc7be-dce7-4805-9a0c-ccb83a6b422f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("959d55af-d85a-46d3-83e5-d7f54cfbffcc"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1327SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1327",
				UId = new Guid("47c0baac-f98f-4188-846b-a20ba602a53f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				CurveCenterPosition = new Point(246, 208),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("959d55af-d85a-46d3-83e5-d7f54cfbffcc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("09ecf56e-5ce5-4794-895e-e95971f31de6"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1776SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1776",
				UId = new Guid("eb8750c7-23fa-4979-ab8c-8aa36cef13d5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				CurveCenterPosition = new Point(476, 214),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bb924708-fdf2-4864-a070-ef328b4eba6e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a4b2d458-95cb-48fd-998f-2386b064b78f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("c0b177ac-b0fa-4fba-ac7d-b5ed41db73c1"),
				ConditionExpression = @"string.IsNullOrEmpty(Entity.GetTypedColumnValue<string>(""Number""))",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				CurveCenterPosition = new Point(355, 209),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("09ecf56e-5ce5-4794-895e-e95971f31de6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bb924708-fdf2-4864-a070-ef328b4eba6e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow1",
				UId = new Guid("26bac238-30cd-420a-ae29-cc4e14cbfedc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				CurveCenterPosition = new Point(288, 286),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("09ecf56e-5ce5-4794-895e-e95971f31de6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fd6d7db4-299c-4fdf-9124-9108834f34bf"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDocumentDeletingSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "DocumentDeletingSequenceFlow",
				UId = new Guid("3b109332-bd6e-40f9-96ed-3ce456c1ab21"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				CurveCenterPosition = new Point(416, 463),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("af09f93a-a018-47a2-a34b-057237316bc2"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("178bd67b-1f83-44df-ad20-ce8d70425680"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateChangeRightsScriptTaskSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "ChangeRightsScriptTaskSequenceFlow",
				UId = new Guid("e242f766-c2b5-40ed-bfa0-6d762e293f3a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21"),
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				CurveCenterPosition = new Point(126, 216),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5e4fc7be-dce7-4805-9a0c-ccb83a6b422f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bd556e16-5646-48ab-af01-3f6e4efbacd7"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDocumentInsertedSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "DocumentInsertedSequenceFlow",
				UId = new Guid("82c6f24d-f1d3-4d7d-a03c-ce9eba0a4736"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21"),
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				CurveCenterPosition = new Point(768, 504),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("970007fc-ed3e-48fc-9837-5a0812a2eb2d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("880ea32c-dd15-4516-8be3-d8464b1caa25"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("03f52d8b-edd3-4c52-b8b7-3efb27974ec3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("5bcf65fb-5c2e-494d-916e-953498111abd"),
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				CurveCenterPosition = new Point(124, 250),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5e4fc7be-dce7-4805-9a0c-ccb83a6b422f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("faf5856b-ebb1-473d-a2ef-bf0805288e6e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet394LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet394 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("eef7b578-9859-443d-a0f2-485364e1d58f"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				Name = @"LaneSet394",
				Position = new Point(5, 5),
				Size = new Size(817, 772),
				UseBackgroundMode = false
			};
			return schemaLaneSet394;
		}

		protected virtual ProcessSchemaLane CreateLane1192Lane() {
			ProcessSchemaLane schemaLane1192 = new ProcessSchemaLane(this) {
				UId = new Guid("b60760e5-96bb-49a5-8aa5-c9ee2fbeca82"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("eef7b578-9859-443d-a0f2-485364e1d58f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				Name = @"Lane1192",
				Position = new Point(29, 0),
				Size = new Size(788, 772),
				UseBackgroundMode = false
			};
			return schemaLane1192;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("29ab6612-b1bd-4d61-953e-a377f6471c01"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b60760e5-96bb-49a5-8aa5-c9ee2fbeca82"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				Name = @"SubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(42, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(538, 452),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDocumentSavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5e4fc7be-dce7-4805-9a0c-ccb83a6b422f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("29ab6612-b1bd-4d61-953e-a377f6471c01"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DocumentSaved",
				ModifiedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				Name = @"DocumentSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(8, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSetGenerateParamScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("959d55af-d85a-46d3-83e5-d7f54cfbffcc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("29ab6612-b1bd-4d61-953e-a377f6471c01"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				Name = @"SetGenerateParamScript",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(71, 170),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,79,205,75,45,74,44,73,245,43,205,77,74,45,10,45,78,45,10,73,44,206,214,115,205,43,201,44,169,12,78,206,72,205,77,84,176,85,128,112,245,32,124,107,94,174,162,212,146,210,162,60,133,146,162,210,84,107,0,137,141,144,78,66,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("09ecf56e-5ce5-4794-895e-e95971f31de6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("29ab6612-b1bd-4d61-953e-a377f6471c01"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(183, 170),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateGenerateNumberUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("bb924708-fdf2-4864-a070-ef328b4eba6e"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("29ab6612-b1bd-4d61-953e-a377f6471c01"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				Name = @"GenerateNumberUserTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(295, 170),
				SchemaUId = new Guid("b9b23348-b89c-4836-8c5b-283ef5ed8666"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeGenerateNumberUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateSetGeneratedNumberScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a4b2d458-95cb-48fd-998f-2386b064b78f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("29ab6612-b1bd-4d61-953e-a377f6471c01"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				Name = @"SetGeneratedNumberScript",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(428, 170),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,142,203,110,194,64,12,69,215,32,241,15,163,172,38,18,154,31,64,93,69,17,98,131,16,175,174,221,228,170,68,100,28,240,216,180,252,61,19,210,93,151,246,61,190,62,73,165,227,111,215,12,45,220,135,91,131,33,164,216,90,252,130,156,18,228,72,233,26,246,72,214,107,149,153,213,98,254,32,113,118,107,51,149,15,24,63,238,244,30,252,72,87,3,51,26,237,6,94,186,154,181,211,103,56,52,23,68,10,91,138,40,23,243,89,56,64,125,49,245,23,75,87,13,189,69,14,59,146,156,43,196,143,34,229,27,252,188,64,224,139,77,91,148,97,147,234,187,81,239,255,225,127,79,118,210,69,146,231,20,159,169,183,220,145,85,39,205,80,255,162,177,108,56,174,4,106,194,78,197,176,122,1,78,21,183,212,252,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEndEvent CreateEnd1EndEvent() {
			ProcessSchemaEndEvent schemaEndEvent = new ProcessSchemaEndEvent(this) {
				UId = new Guid("fd6d7db4-299c-4fdf-9124-9108834f34bf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("29ab6612-b1bd-4d61-953e-a377f6471c01"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("45ceaae2-4e1f-4c0c-86aa-cd4aeb4da913"),
				ModifiedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				Name = @"End1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(197, 303),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaEndEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChangeRightsScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("bd556e16-5646-48ab-af01-3f6e4efbacd7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("29ab6612-b1bd-4d61-953e-a377f6471c01"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21"),
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				Name = @"ChangeRightsScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(70, 280),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,143,207,10,194,48,12,198,207,19,124,135,186,195,208,203,246,0,58,65,134,12,79,131,225,159,243,88,163,22,186,118,196,116,50,196,119,215,162,101,83,17,17,66,14,249,146,239,247,165,41,144,233,179,2,92,113,22,179,165,34,65,109,152,2,173,219,26,120,162,165,169,212,182,144,6,102,169,17,124,62,246,179,199,174,63,153,14,7,141,189,149,60,251,118,158,201,95,14,98,207,198,142,62,138,123,102,19,118,25,14,188,55,217,26,132,203,170,166,150,5,1,235,9,155,19,96,162,149,130,146,132,86,97,98,16,65,145,157,134,247,49,21,37,57,71,47,138,22,156,239,80,28,142,148,219,118,114,0,27,199,187,58,104,247,213,39,247,69,251,11,157,67,165,27,120,165,119,47,63,3,220,11,129,12,42,70,104,96,122,3,250,111,94,162,161,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateFinanceRecalculationScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("faf5856b-ebb1-473d-a2ef-bf0805288e6e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("29ab6612-b1bd-4d61-953e-a377f6471c01"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("5bcf65fb-5c2e-494d-916e-953498111abd"),
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				Name = @"FinanceRecalculationScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(71, 352),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessDocumentSavingEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessDocumentSaving = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("95eea31a-db9c-433a-b136-7c5b5dc41f46"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b60760e5-96bb-49a5-8aa5-c9ee2fbeca82"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				Name = @"EventSubProcessDocumentSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(42, 420),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(181, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessDocumentSaving;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDocumentSavingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("532a7731-ee3a-456f-a96f-d01f310467ba"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("95eea31a-db9c-433a-b136-7c5b5dc41f46"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DocumentSaving",
				ModifiedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				Name = @"DocumentSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(7, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDocumentSavingScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("303ec553-1575-4a73-86c2-67e615c148f4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("95eea31a-db9c-433a-b136-7c5b5dc41f46"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				Name = @"ScriptDocumentSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(77, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("65d38b9c-13f0-42ac-af9b-b0f7a714c9ed"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b60760e5-96bb-49a5-8aa5-c9ee2fbeca82"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(414, 597),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(314, 158),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1DocumentDeletingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("af09f93a-a018-47a2-a34b-057237316bc2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65d38b9c-13f0-42ac-af9b-b0f7a714c9ed"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DocumentDeleting",
				ModifiedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				Name = @"StartMessage1DocumentDeleting",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(28, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDocumentDeletingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("178bd67b-1f83-44df-ad20-ce8d70425680"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65d38b9c-13f0-42ac-af9b-b0f7a714c9ed"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				Name = @"DocumentDeletingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(119, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("945c922f-6ce6-4766-8fc7-c20e7120b611"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b60760e5-96bb-49a5-8aa5-c9ee2fbeca82"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21"),
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(260, 422),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(192, 162),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaScriptTask CreateDocumentInsertedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("880ea32c-dd15-4516-8be3-d8464b1caa25"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("945c922f-6ce6-4766-8fc7-c20e7120b611"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21"),
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				Name = @"DocumentInsertedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(91, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,44,246,75,45,87,176,85,40,41,42,77,181,230,229,42,74,45,41,45,202,131,240,0,137,94,118,228,27,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDocumentInsertedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("970007fc-ed3e-48fc-9837-5a0812a2eb2d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("945c922f-6ce6-4766-8fc7-c20e7120b611"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21"),
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DocumentInserted",
				ModifiedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				Name = @"DocumentInsertedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(14, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateMultiplyMethod());
			Methods.Add(CreateDivisionMethod());
			Methods.Add(CreateAddWrightRightsMethod());
			Methods.Add(CreateRemoveWrightRightsMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("732e3c5c-38b6-422d-987c-6ebcf4fed92d"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9d6e76e7-88ac-4db8-9ded-f71a34df90a0"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
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

		protected virtual SchemaMethod CreateMultiplyMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("57c92bd7-7302-4aaa-8a90-35878639089f"),
				Name = "Multiply",
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "decimal"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("1e17512a-c016-42d9-885d-99e189398702"),
				Name = "arg1",
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				ModifiedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "decimal",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8e37a846-5d2a-4984-a254-9a0945b354bd"),
				Name = "arg2",
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				ModifiedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "decimal",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,240,77,44,201,208,11,202,47,205,75,209,72,44,74,55,84,208,82,0,82,70,58,70,154,214,0,253,17,30,67,33,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateDivisionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e35ccf70-fc8e-4092-b719-35542f5bdfbc"),
				Name = "Division",
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6"),
				ResultValueTypeName = "decimal"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("369ae26d-e14c-4c9a-b59a-bbb22aeb325c"),
				Name = "arg1",
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				ModifiedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "decimal",
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("129be0c0-3379-46ef-ac2e-534d2d4c9a4f"),
				Name = "arg2",
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				ModifiedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "decimal",
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,73,77,206,204,77,204,81,40,74,45,46,205,41,81,176,85,48,176,230,202,76,211,72,44,74,55,82,176,83,48,208,172,230,226,132,75,249,38,150,100,232,5,229,151,230,165,128,228,13,21,244,21,64,202,116,20,140,52,173,185,106,185,138,82,75,74,139,242,160,6,89,3,0,45,233,89,84,88,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateAddWrightRightsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("efc2ece2-c3e1-4bad-a958-2f93837e68f2"),
				Name = "AddWrightRights",
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f7b608bc-158d-4c65-8184-74ad2b268e01"),
				Name = "documentOwnerId",
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				ModifiedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,82,79,107,219,48,20,63,59,144,239,32,124,178,193,152,222,187,21,82,215,13,129,110,109,227,117,59,107,214,107,34,176,159,92,233,41,193,148,126,247,73,145,91,108,55,187,237,48,176,124,144,222,251,253,123,239,192,53,19,191,43,168,173,150,212,151,184,147,8,236,43,123,50,160,11,133,8,53,73,133,249,205,245,180,226,114,185,56,184,70,211,155,149,104,37,62,161,164,178,122,116,125,8,71,86,34,185,194,170,222,67,203,31,45,232,62,153,161,141,11,190,113,228,59,208,25,139,171,17,88,156,14,12,157,150,45,215,125,161,26,219,162,195,159,49,230,43,33,194,91,50,127,217,42,69,129,34,95,3,61,140,113,190,243,22,146,52,189,100,203,197,188,235,86,54,4,218,120,220,79,136,133,6,78,16,42,126,73,218,63,112,237,128,124,121,18,46,11,213,118,92,75,163,240,71,223,65,94,190,88,222,56,99,206,57,241,154,226,140,9,85,219,22,144,238,143,8,122,35,210,244,76,142,230,140,75,103,32,100,230,244,55,33,196,89,166,30,73,62,179,137,102,147,23,202,34,177,43,118,145,178,215,229,34,242,84,252,253,117,35,28,209,218,74,145,151,109,71,189,235,143,158,149,115,88,239,89,50,215,196,36,78,53,6,188,104,10,54,174,240,146,125,8,195,116,126,242,198,194,23,207,118,149,76,70,154,251,89,120,241,81,228,229,207,55,209,195,108,204,120,95,78,12,210,144,118,163,16,215,253,22,106,165,133,73,226,155,33,218,56,29,180,69,159,176,170,247,20,3,82,104,221,202,221,158,238,224,0,77,50,114,147,13,75,156,15,27,228,85,126,220,77,118,233,228,44,59,17,70,209,95,224,239,59,112,114,253,230,111,129,127,96,159,87,145,175,154,70,29,87,40,214,154,35,101,163,9,101,140,180,29,178,250,47,205,149,66,210,191,48,247,230,126,238,184,111,185,248,3,197,118,36,53,159,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateRemoveWrightRightsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("534dc1ae-236a-4b63-a06c-2b1dc9302dcc"),
				Name = "RemoveWrightRights",
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("5bbdee69-e5aa-4866-bf13-344d9d5b6112"),
				Name = "documentOwnerId",
				CreatedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				ModifiedInSchemaUId = new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,83,205,110,156,48,16,62,179,210,190,131,197,9,36,100,245,158,38,82,194,210,104,165,166,73,150,166,61,187,120,178,107,9,198,196,30,111,132,162,188,123,237,53,169,128,166,13,18,28,236,153,239,111,134,163,48,76,254,170,161,113,70,209,80,225,94,33,176,115,246,96,193,148,26,17,26,82,26,249,230,106,94,113,182,94,29,125,163,29,236,165,236,20,62,160,162,170,190,247,125,8,207,172,66,242,133,117,115,128,78,220,59,48,67,182,64,155,22,220,8,20,123,48,5,75,235,9,88,154,143,12,189,81,157,48,67,169,91,215,161,199,95,48,242,75,41,227,93,182,188,217,105,77,145,130,95,3,221,77,113,190,137,14,178,60,63,99,235,213,178,235,139,106,9,140,13,184,127,33,150,6,4,65,172,248,169,232,112,39,140,7,10,229,89,60,44,117,215,11,163,172,198,239,67,15,188,122,114,162,245,198,188,115,18,13,165,5,147,186,113,29,32,221,62,35,152,173,204,243,119,114,180,239,184,244,6,98,102,94,127,27,67,92,100,26,144,212,35,155,105,182,188,212,14,137,93,176,79,57,123,89,175,146,64,37,222,110,183,210,19,93,59,37,121,213,245,52,248,254,228,81,123,135,205,129,101,75,77,76,225,92,99,196,75,230,96,211,138,32,57,132,48,78,231,135,104,29,124,14,108,23,217,108,164,60,204,34,136,79,146,32,255,131,181,11,168,91,59,93,159,19,161,178,100,252,100,228,213,176,131,70,27,105,179,116,51,38,157,230,163,212,228,35,232,250,45,227,8,28,145,118,106,127,160,175,112,132,54,155,120,45,198,21,231,227,126,5,15,127,206,102,155,118,242,93,156,248,195,243,15,130,219,30,188,254,211,159,33,21,21,236,127,58,248,6,112,40,38,131,43,24,25,55,70,248,234,63,254,125,253,13,222,253,187,172,213,3,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Document_Document_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ac7c88d3-6cc2-460c-8415-064480a3acd4"));
		}

		#endregion

	}

	#endregion

}

