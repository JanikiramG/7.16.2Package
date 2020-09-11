namespace Terrasoft.Configuration
{

	using DataContract = Terrasoft.Nui.ServiceModel.DataContract;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using System.Text;
	using System.Text.RegularExpressions;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration.RightsService;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Mail;
	using Terrasoft.Messaging.Common;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: BaseVisaSchema

	/// <exclude/>
	[IsVirtual]
	public class BaseVisaSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public BaseVisaSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BaseVisaSchema(BaseVisaSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BaseVisaSchema(BaseVisaSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5fa90d0d-64eb-4f52-8d3d-c51fa6443b66");
			RealUId = new Guid("5fa90d0d-64eb-4f52-8d3d-c51fa6443b66");
			Name = "BaseVisa";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateObjectiveColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("f33a75e0-7ed4-4b06-a410-b9e9323645b1")) == null) {
				Columns.Add(CreateVisaOwnerColumn());
			}
			if (Columns.FindByUId(new Guid("7d4534be-4800-4793-b848-6771da492076")) == null) {
				Columns.Add(CreateIsAllowedToDelegateColumn());
			}
			if (Columns.FindByUId(new Guid("2800e792-e676-4b25-b8a0-aa7f0e714056")) == null) {
				Columns.Add(CreateDelegatedFromColumn());
			}
			if (Columns.FindByUId(new Guid("58ebe36e-7384-4abd-b09c-407c6f508a4d")) == null) {
				Columns.Add(CreateStatusColumn());
			}
			if (Columns.FindByUId(new Guid("1a4e2821-3b74-460c-8877-c06f743702c5")) == null) {
				Columns.Add(CreateSetByColumn());
			}
			if (Columns.FindByUId(new Guid("b4fedd4a-ca45-4ade-960a-c0f4417fe442")) == null) {
				Columns.Add(CreateSetDateColumn());
			}
			if (Columns.FindByUId(new Guid("c7d206aa-401c-4095-ba43-757c8f1914e9")) == null) {
				Columns.Add(CreateIsCanceledColumn());
			}
			if (Columns.FindByUId(new Guid("9b44ad39-b9e1-489e-a2c5-6090c3522434")) == null) {
				Columns.Add(CreateCommentColumn());
			}
			if (Columns.FindByUId(new Guid("453a7c65-0418-4684-be8f-641427eb6837")) == null) {
				Columns.Add(CreateIsRequiredDigitalSignatureColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("5fa90d0d-64eb-4f52-8d3d-c51fa6443b66");
			column.CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("5fa90d0d-64eb-4f52-8d3d-c51fa6443b66");
			column.CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("5fa90d0d-64eb-4f52-8d3d-c51fa6443b66");
			column.CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("5fa90d0d-64eb-4f52-8d3d-c51fa6443b66");
			column.CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("5fa90d0d-64eb-4f52-8d3d-c51fa6443b66");
			column.CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("5fa90d0d-64eb-4f52-8d3d-c51fa6443b66");
			column.CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524");
			return column;
		}

		protected virtual EntitySchemaColumn CreateObjectiveColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("c282c824-7aa1-44b4-b8f0-dca0fe3d8b4b"),
				Name = @"Objective",
				CreatedInSchemaUId = new Guid("5fa90d0d-64eb-4f52-8d3d-c51fa6443b66"),
				ModifiedInSchemaUId = new Guid("5fa90d0d-64eb-4f52-8d3d-c51fa6443b66"),
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			};
		}

		protected virtual EntitySchemaColumn CreateVisaOwnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f33a75e0-7ed4-4b06-a410-b9e9323645b1"),
				Name = @"VisaOwner",
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5fa90d0d-64eb-4f52-8d3d-c51fa6443b66"),
				ModifiedInSchemaUId = new Guid("5fa90d0d-64eb-4f52-8d3d-c51fa6443b66"),
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			};
		}

		protected virtual EntitySchemaColumn CreateIsAllowedToDelegateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("7d4534be-4800-4793-b848-6771da492076"),
				Name = @"IsAllowedToDelegate",
				CreatedInSchemaUId = new Guid("5fa90d0d-64eb-4f52-8d3d-c51fa6443b66"),
				ModifiedInSchemaUId = new Guid("5fa90d0d-64eb-4f52-8d3d-c51fa6443b66"),
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			};
		}

		protected virtual EntitySchemaColumn CreateDelegatedFromColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("2800e792-e676-4b25-b8a0-aa7f0e714056"),
				Name = @"DelegatedFrom",
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5fa90d0d-64eb-4f52-8d3d-c51fa6443b66"),
				ModifiedInSchemaUId = new Guid("5fa90d0d-64eb-4f52-8d3d-c51fa6443b66"),
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			};
		}

		protected virtual EntitySchemaColumn CreateStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("58ebe36e-7384-4abd-b09c-407c6f508a4d"),
				Name = @"Status",
				ReferenceSchemaUId = new Guid("66c8f5ac-57d2-4fe8-95a0-89a98e37f57f"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5fa90d0d-64eb-4f52-8d3d-c51fa6443b66"),
				ModifiedInSchemaUId = new Guid("5fa90d0d-64eb-4f52-8d3d-c51fa6443b66"),
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"3462594d-77a7-4b0a-874a-6d8b54b293bc"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateSetByColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("1a4e2821-3b74-460c-8877-c06f743702c5"),
				Name = @"SetBy",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5fa90d0d-64eb-4f52-8d3d-c51fa6443b66"),
				ModifiedInSchemaUId = new Guid("5fa90d0d-64eb-4f52-8d3d-c51fa6443b66"),
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			};
		}

		protected virtual EntitySchemaColumn CreateSetDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("b4fedd4a-ca45-4ade-960a-c0f4417fe442"),
				Name = @"SetDate",
				CreatedInSchemaUId = new Guid("5fa90d0d-64eb-4f52-8d3d-c51fa6443b66"),
				ModifiedInSchemaUId = new Guid("5fa90d0d-64eb-4f52-8d3d-c51fa6443b66"),
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			};
		}

		protected virtual EntitySchemaColumn CreateIsCanceledColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("c7d206aa-401c-4095-ba43-757c8f1914e9"),
				Name = @"IsCanceled",
				CreatedInSchemaUId = new Guid("5fa90d0d-64eb-4f52-8d3d-c51fa6443b66"),
				ModifiedInSchemaUId = new Guid("5fa90d0d-64eb-4f52-8d3d-c51fa6443b66"),
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			};
		}

		protected virtual EntitySchemaColumn CreateCommentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("9b44ad39-b9e1-489e-a2c5-6090c3522434"),
				Name = @"Comment",
				CreatedInSchemaUId = new Guid("5fa90d0d-64eb-4f52-8d3d-c51fa6443b66"),
				ModifiedInSchemaUId = new Guid("5fa90d0d-64eb-4f52-8d3d-c51fa6443b66"),
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			};
		}

		protected virtual EntitySchemaColumn CreateIsRequiredDigitalSignatureColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("453a7c65-0418-4684-be8f-641427eb6837"),
				Name = @"IsRequiredDigitalSignature",
				CreatedInSchemaUId = new Guid("5fa90d0d-64eb-4f52-8d3d-c51fa6443b66"),
				ModifiedInSchemaUId = new Guid("5fa90d0d-64eb-4f52-8d3d-c51fa6443b66"),
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBaseVisaEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateBaseVisaEventsProcessSchema() {
			var schema = new BaseVisaEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BaseVisa(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BaseVisa_NUIEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BaseVisaSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BaseVisaSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5fa90d0d-64eb-4f52-8d3d-c51fa6443b66"));
		}

		#endregion

	}

	#endregion

	#region Class: BaseVisa

	/// <summary>
	/// Base approval.
	/// </summary>
	public class BaseVisa : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public BaseVisa(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BaseVisa";
		}

		public BaseVisa(BaseVisa source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Approval purpose.
		/// </summary>
		public string Objective {
			get {
				return GetTypedColumnValue<string>("Objective");
			}
			set {
				SetColumnValue("Objective", value);
			}
		}

		/// <exclude/>
		public Guid VisaOwnerId {
			get {
				return GetTypedColumnValue<Guid>("VisaOwnerId");
			}
			set {
				SetColumnValue("VisaOwnerId", value);
				_visaOwner = null;
			}
		}

		/// <exclude/>
		public string VisaOwnerName {
			get {
				return GetTypedColumnValue<string>("VisaOwnerName");
			}
			set {
				SetColumnValue("VisaOwnerName", value);
				if (_visaOwner != null) {
					_visaOwner.Name = value;
				}
			}
		}

		private SysAdminUnit _visaOwner;
		/// <summary>
		/// Approver.
		/// </summary>
		public SysAdminUnit VisaOwner {
			get {
				return _visaOwner ??
					(_visaOwner = LookupColumnEntities.GetEntity("VisaOwner") as SysAdminUnit);
			}
		}

		/// <summary>
		/// Delegation permitted.
		/// </summary>
		public bool IsAllowedToDelegate {
			get {
				return GetTypedColumnValue<bool>("IsAllowedToDelegate");
			}
			set {
				SetColumnValue("IsAllowedToDelegate", value);
			}
		}

		/// <exclude/>
		public Guid DelegatedFromId {
			get {
				return GetTypedColumnValue<Guid>("DelegatedFromId");
			}
			set {
				SetColumnValue("DelegatedFromId", value);
				_delegatedFrom = null;
			}
		}

		/// <exclude/>
		public string DelegatedFromName {
			get {
				return GetTypedColumnValue<string>("DelegatedFromName");
			}
			set {
				SetColumnValue("DelegatedFromName", value);
				if (_delegatedFrom != null) {
					_delegatedFrom.Name = value;
				}
			}
		}

		private SysAdminUnit _delegatedFrom;
		/// <summary>
		/// Delegated from.
		/// </summary>
		public SysAdminUnit DelegatedFrom {
			get {
				return _delegatedFrom ??
					(_delegatedFrom = LookupColumnEntities.GetEntity("DelegatedFrom") as SysAdminUnit);
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

		private VisaStatus _status;
		/// <summary>
		/// Status.
		/// </summary>
		public VisaStatus Status {
			get {
				return _status ??
					(_status = LookupColumnEntities.GetEntity("Status") as VisaStatus);
			}
		}

		/// <exclude/>
		public Guid SetById {
			get {
				return GetTypedColumnValue<Guid>("SetById");
			}
			set {
				SetColumnValue("SetById", value);
				_setBy = null;
			}
		}

		/// <exclude/>
		public string SetByName {
			get {
				return GetTypedColumnValue<string>("SetByName");
			}
			set {
				SetColumnValue("SetByName", value);
				if (_setBy != null) {
					_setBy.Name = value;
				}
			}
		}

		private Contact _setBy;
		/// <summary>
		/// Set by.
		/// </summary>
		public Contact SetBy {
			get {
				return _setBy ??
					(_setBy = LookupColumnEntities.GetEntity("SetBy") as Contact);
			}
		}

		/// <summary>
		/// Set on.
		/// </summary>
		public DateTime SetDate {
			get {
				return GetTypedColumnValue<DateTime>("SetDate");
			}
			set {
				SetColumnValue("SetDate", value);
			}
		}

		/// <summary>
		/// Canceled.
		/// </summary>
		public bool IsCanceled {
			get {
				return GetTypedColumnValue<bool>("IsCanceled");
			}
			set {
				SetColumnValue("IsCanceled", value);
			}
		}

		/// <summary>
		/// Notes.
		/// </summary>
		public string Comment {
			get {
				return GetTypedColumnValue<string>("Comment");
			}
			set {
				SetColumnValue("Comment", value);
			}
		}

		/// <summary>
		/// Required of the digital signature.
		/// </summary>
		public bool IsRequiredDigitalSignature {
			get {
				return GetTypedColumnValue<bool>("IsRequiredDigitalSignature");
			}
			set {
				SetColumnValue("IsRequiredDigitalSignature", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BaseVisa_NUIEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserted += (s, e) => ThrowEvent("BaseVisaInserted", e);
			Inserting += (s, e) => ThrowEvent("BaseVisaInserting", e);
			Saved += (s, e) => ThrowEvent("BaseVisaSaved", e);
			Saving += (s, e) => ThrowEvent("BaseVisaSaving", e);
			Validating += (s, e) => ThrowEvent("BaseVisaValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseVisa(this);
		}

		#endregion

	}

	#endregion

	#region Class: BaseVisa_NUIEventsProcess

	/// <exclude/>
	public partial class BaseVisa_NUIEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : BaseVisa
	{

		public BaseVisa_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseVisa_NUIEventsProcess";
			SchemaUId = new Guid("5fa90d0d-64eb-4f52-8d3d-c51fa6443b66");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			_isNew = () => {{ return false; }};
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5fa90d0d-64eb-4f52-8d3d-c51fa6443b66");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual bool NeedSendEmail {
			get;
			set;
		}

		public virtual Guid SysModuleEntityId {
			get;
			set;
		}

		public virtual Guid oldVisaOwnerId {
			get;
			set;
		}

		public virtual Guid oldDelegatedFromId {
			get;
			set;
		}

		public virtual Object AddedTemplateColumns {
			get;
			set;
		}

		private Func<bool> _isNew;
		public virtual bool IsNew {
			get {
				return (_isNew ?? (_isNew = () => false)).Invoke();
			}
			set {
				_isNew = () => { return value; };
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
					SchemaElementUId = new Guid("83b1242b-739d-4352-9e6b-80b3f5c26dd8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseVisaSavingStartMessage;
		public ProcessFlowElement BaseVisaSavingStartMessage {
			get {
				return _baseVisaSavingStartMessage ?? (_baseVisaSavingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseVisaSavingStartMessage",
					SchemaElementUId = new Guid("7a568490-371a-4edc-bfd4-ff9f3f2948bc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseVisaInsertedStartMessage;
		public ProcessFlowElement BaseVisaInsertedStartMessage {
			get {
				return _baseVisaInsertedStartMessage ?? (_baseVisaInsertedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseVisaInsertedStartMessage",
					SchemaElementUId = new Guid("cd9d5068-1d66-4ac4-bc08-e823a6c71e72"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _baseVisaInsertedScriptTask;
		public ProcessScriptTask BaseVisaInsertedScriptTask {
			get {
				return _baseVisaInsertedScriptTask ?? (_baseVisaInsertedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BaseVisaInsertedScriptTask",
					SchemaElementUId = new Guid("aa346743-5d89-469e-a9a6-c0e32ebe5532"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = BaseVisaInsertedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _baseVisaSavedStartMessage;
		public ProcessFlowElement BaseVisaSavedStartMessage {
			get {
				return _baseVisaSavedStartMessage ?? (_baseVisaSavedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseVisaSavedStartMessage",
					SchemaElementUId = new Guid("6dec2d63-206a-456c-b12e-977dfab8fd3b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _baseVisaSavedScriptTask;
		public ProcessScriptTask BaseVisaSavedScriptTask {
			get {
				return _baseVisaSavedScriptTask ?? (_baseVisaSavedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BaseVisaSavedScriptTask",
					SchemaElementUId = new Guid("111279fd-e865-4b9a-acbc-aef0ab315916"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = BaseVisaSavedScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent1BaseVisaSaving;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent1BaseVisaSaving {
			get {
				return _intermediateThrowMessageEvent1BaseVisaSaving ?? (_intermediateThrowMessageEvent1BaseVisaSaving = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent1BaseVisaSaving",
					SchemaElementUId = new Guid("ccc3e746-0a9a-45f8-9293-4a34d26a8948"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "BaseVisaSaving",
						ThrowToBase = true,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent2BaseVisaSaved;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent2BaseVisaSaved {
			get {
				return _intermediateThrowMessageEvent2BaseVisaSaved ?? (_intermediateThrowMessageEvent2BaseVisaSaved = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent2BaseVisaSaved",
					SchemaElementUId = new Guid("4bea3148-3b2a-4e3f-a71d-82e77a3072bc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "BaseVisaSaved",
						ThrowToBase = true,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent3BaseVisaInserted;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent3BaseVisaInserted {
			get {
				return _intermediateThrowMessageEvent3BaseVisaInserted ?? (_intermediateThrowMessageEvent3BaseVisaInserted = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent3BaseVisaInserted",
					SchemaElementUId = new Guid("33896526-da17-42d4-b819-5aeb2e10ad7c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "BaseVisaInserted",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _baseVisaSavingScriptTask;
		public ProcessScriptTask BaseVisaSavingScriptTask {
			get {
				return _baseVisaSavingScriptTask ?? (_baseVisaSavingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BaseVisaSavingScriptTask",
					SchemaElementUId = new Guid("01fe088d-9a82-46d9-9c30-693c6cec6768"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = BaseVisaSavingScriptTaskExecute,
				});
			}
		}

		private LocalizableString _bodyMessage;
		public LocalizableString BodyMessage {
			get {
				return _bodyMessage ?? (_bodyMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.BodyMessage.Value"));
			}
		}

		private LocalizableString _subjectString;
		public LocalizableString SubjectString {
			get {
				return _subjectString ?? (_subjectString = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.SubjectString.Value"));
			}
		}

		private LocalizableString _popupTitleTemplate;
		public LocalizableString PopupTitleTemplate {
			get {
				return _popupTitleTemplate ?? (_popupTitleTemplate = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.PopupTitleTemplate.Value"));
			}
		}

		private LocalizableString _popupBodyTemplate;
		public LocalizableString PopupBodyTemplate {
			get {
				return _popupBodyTemplate ?? (_popupBodyTemplate = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.PopupBodyTemplate.Value"));
			}
		}

		private LocalizableString _popupBodyDateFormat;
		public LocalizableString PopupBodyDateFormat {
			get {
				return _popupBodyDateFormat ?? (_popupBodyDateFormat = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.PopupBodyDateFormat.Value"));
			}
		}

		private LocalizableString _popupBodyDefaultTemplate;
		public LocalizableString PopupBodyDefaultTemplate {
			get {
				return _popupBodyDefaultTemplate ?? (_popupBodyDefaultTemplate = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.PopupBodyDefaultTemplate.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[BaseVisaSavingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseVisaSavingStartMessage };
			FlowElements[BaseVisaInsertedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseVisaInsertedStartMessage };
			FlowElements[BaseVisaInsertedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseVisaInsertedScriptTask };
			FlowElements[BaseVisaSavedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseVisaSavedStartMessage };
			FlowElements[BaseVisaSavedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseVisaSavedScriptTask };
			FlowElements[IntermediateThrowMessageEvent1BaseVisaSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1BaseVisaSaving };
			FlowElements[IntermediateThrowMessageEvent2BaseVisaSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent2BaseVisaSaved };
			FlowElements[IntermediateThrowMessageEvent3BaseVisaInserted.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent3BaseVisaInserted };
			FlowElements[BaseVisaSavingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseVisaSavingScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "BaseVisaSavingStartMessage":
						e.Context.QueueTasks.Enqueue("BaseVisaSavingScriptTask");
						break;
					case "BaseVisaInsertedStartMessage":
						e.Context.QueueTasks.Enqueue("BaseVisaInsertedScriptTask");
						break;
					case "BaseVisaInsertedScriptTask":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent3BaseVisaInserted");
						break;
					case "BaseVisaSavedStartMessage":
						e.Context.QueueTasks.Enqueue("BaseVisaSavedScriptTask");
						break;
					case "BaseVisaSavedScriptTask":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent2BaseVisaSaved");
						break;
					case "IntermediateThrowMessageEvent1BaseVisaSaving":
						break;
					case "IntermediateThrowMessageEvent2BaseVisaSaved":
						break;
					case "IntermediateThrowMessageEvent3BaseVisaInserted":
						break;
					case "BaseVisaSavingScriptTask":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1BaseVisaSaving");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("BaseVisaSavingStartMessage");
			ActivatedEventElements.Add("BaseVisaInsertedStartMessage");
			ActivatedEventElements.Add("BaseVisaSavedStartMessage");
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
				case "BaseVisaSavingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseVisaSavingStartMessage";
					result = BaseVisaSavingStartMessage.Execute(context);
					break;
				case "BaseVisaInsertedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseVisaInsertedStartMessage";
					result = BaseVisaInsertedStartMessage.Execute(context);
					break;
				case "BaseVisaInsertedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseVisaInsertedScriptTask";
					result = BaseVisaInsertedScriptTask.Execute(context, BaseVisaInsertedScriptTaskExecute);
					break;
				case "BaseVisaSavedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseVisaSavedStartMessage";
					result = BaseVisaSavedStartMessage.Execute(context);
					break;
				case "BaseVisaSavedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseVisaSavedScriptTask";
					result = BaseVisaSavedScriptTask.Execute(context, BaseVisaSavedScriptTaskExecute);
					break;
				case "IntermediateThrowMessageEvent1BaseVisaSaving":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "BaseVisaSaving");
					result = IntermediateThrowMessageEvent1BaseVisaSaving.Execute(context);
					break;
				case "IntermediateThrowMessageEvent2BaseVisaSaved":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "BaseVisaSaved");
					result = IntermediateThrowMessageEvent2BaseVisaSaved.Execute(context);
					break;
				case "IntermediateThrowMessageEvent3BaseVisaInserted":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "BaseVisaInserted");
					result = IntermediateThrowMessageEvent3BaseVisaInserted.Execute(context);
					break;
				case "BaseVisaSavingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseVisaSavingScriptTask";
					result = BaseVisaSavingScriptTask.Execute(context, BaseVisaSavingScriptTaskExecute);
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
				case "AddedTemplateColumns":
					AddedTemplateColumns = reader.GetSerializableObjectValue();
				break;
				case "oldDelegatedFromId":
					oldDelegatedFromId = reader.GetValue<System.Guid>();
				break;
				case "oldVisaOwnerId":
					oldVisaOwnerId = reader.GetValue<System.Guid>();
				break;
				case "SysModuleEntityId":
					SysModuleEntityId = reader.GetValue<System.Guid>();
				break;
				case "NeedSendEmail":
					NeedSendEmail = reader.GetValue<System.Boolean>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool BaseVisaInsertedScriptTaskExecute(ProcessExecutingContext context) {
			return BaseVisaInserted(context);
		}

		public virtual bool BaseVisaSavedScriptTaskExecute(ProcessExecutingContext context) {
			return BaseVisaSaved(context);
		}

		public virtual bool BaseVisaSavingScriptTaskExecute(ProcessExecutingContext context) {
			return BaseVisaSaving(context);
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "BaseVisaSaving":
							if (ActivatedEventElements.Contains("BaseVisaSavingStartMessage")) {
							context.QueueTasks.Enqueue("BaseVisaSavingStartMessage");
						}
						break;
					case "BaseVisaInserted":
							if (ActivatedEventElements.Contains("BaseVisaInsertedStartMessage")) {
							context.QueueTasks.Enqueue("BaseVisaInsertedStartMessage");
						}
						break;
					case "BaseVisaSaved":
							if (ActivatedEventElements.Contains("BaseVisaSavedStartMessage")) {
							context.QueueTasks.Enqueue("BaseVisaSavedStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (AddedTemplateColumns != null) {
				if (AddedTemplateColumns.GetType().IsSerializable ||
					AddedTemplateColumns.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("AddedTemplateColumns", AddedTemplateColumns, null);
				}
			}
			if (!HasMapping("oldDelegatedFromId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("oldDelegatedFromId", oldDelegatedFromId, Guid.Empty);
			}
			if (!HasMapping("oldVisaOwnerId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("oldVisaOwnerId", oldVisaOwnerId, Guid.Empty);
			}
			if (!HasMapping("SysModuleEntityId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SysModuleEntityId", SysModuleEntityId, Guid.Empty);
			}
			if (!HasMapping("NeedSendEmail") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("NeedSendEmail", NeedSendEmail, false);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: BaseVisa_NUIEventsProcess

	/// <exclude/>
	public class BaseVisa_NUIEventsProcess : BaseVisa_NUIEventsProcess<BaseVisa>
	{

		public BaseVisa_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BaseVisaEventsProcessSchema

	/// <exclude/>
	public class BaseVisaEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public BaseVisaEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BaseVisaEventsProcessSchema(BaseVisaEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BaseVisa_NUIEventsProcess";
			UId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e");
			CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524");
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

		protected virtual ProcessSchemaParameter CreateNeedSendEmailParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("475cccfc-8978-4ccc-ae7d-0c29093319be"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Name = @"NeedSendEmail",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSysModuleEntityIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9ea0a027-768d-4588-9d26-96fe15287938"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Name = @"SysModuleEntityId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateoldVisaOwnerIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("17f3ef58-4150-4a9f-8a94-9f9958078e81"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Name = @"oldVisaOwnerId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateoldDelegatedFromIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4d93d5f3-6ecc-4629-9916-72b43124aa3d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Name = @"oldDelegatedFromId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateAddedTemplateColumnsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d042e699-faf4-4bed-aa85-75d74c4e25e4"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Name = @"AddedTemplateColumns",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsNewParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("249fe037-e845-46ee-b451-c2e49fceb217"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Name = @"IsNew",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"false",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateNeedSendEmailParameter());
			Parameters.Add(CreateSysModuleEntityIdParameter());
			Parameters.Add(CreateoldVisaOwnerIdParameter());
			Parameters.Add(CreateoldDelegatedFromIdParameter());
			Parameters.Add(CreateAddedTemplateColumnsParameter());
			Parameters.Add(CreateIsNewParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaStartMessageEvent basevisasavingstartmessage = CreateBaseVisaSavingStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(basevisasavingstartmessage);
			ProcessSchemaStartMessageEvent basevisainsertedstartmessage = CreateBaseVisaInsertedStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(basevisainsertedstartmessage);
			ProcessSchemaScriptTask basevisainsertedscripttask = CreateBaseVisaInsertedScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(basevisainsertedscripttask);
			ProcessSchemaStartMessageEvent basevisasavedstartmessage = CreateBaseVisaSavedStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(basevisasavedstartmessage);
			ProcessSchemaScriptTask basevisasavedscripttask = CreateBaseVisaSavedScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(basevisasavedscripttask);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1basevisasaving = CreateIntermediateThrowMessageEvent1BaseVisaSavingIntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(intermediatethrowmessageevent1basevisasaving);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent2basevisasaved = CreateIntermediateThrowMessageEvent2BaseVisaSavedIntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(intermediatethrowmessageevent2basevisasaved);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent3basevisainserted = CreateIntermediateThrowMessageEvent3BaseVisaInsertedIntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(intermediatethrowmessageevent3basevisainserted);
			ProcessSchemaScriptTask basevisasavingscripttask = CreateBaseVisaSavingScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(basevisasavingscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4BaseVisaSavingSequenceFlow());
			FlowElements.Add(CreateSequenceFlow5BaseVisaInsertedSequenceFlow());
			FlowElements.Add(CreateSequenceFlow6BaseVisaSavedSequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateBodyMessageLocalizableString());
			LocalizableStrings.Add(CreateSubjectStringLocalizableString());
			LocalizableStrings.Add(CreatePopupTitleTemplateLocalizableString());
			LocalizableStrings.Add(CreatePopupBodyTemplateLocalizableString());
			LocalizableStrings.Add(CreatePopupBodyDateFormatLocalizableString());
			LocalizableStrings.Add(CreatePopupBodyDefaultTemplateLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateBodyMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5e22aaf4-de9d-4ec6-9ac6-9c749aa8d673"),
				Name = "BodyMessage",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524"),
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSubjectStringLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5827220a-58da-4d5c-9d73-60de4040fefc"),
				Name = "SubjectString",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524"),
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreatePopupTitleTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("cd9be940-ec6e-40db-a3b4-437717c68444"),
				Name = "PopupTitleTemplate",
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreatePopupBodyTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e9b3842a-e6d9-443f-ab46-b72116fd4876"),
				Name = "PopupBodyTemplate",
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreatePopupBodyDateFormatLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("8c03b7b6-e52b-4026-b966-ae50e84ca7d5"),
				Name = "PopupBodyDateFormat",
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreatePopupBodyDefaultTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("70d9a6cb-2430-47d8-944f-d8b9e01b690e"),
				Name = "PopupBodyDefaultTemplate",
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("f9435435-3b5a-4853-83ec-527fe4ed73b7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524"),
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				CurveCenterPosition = new Point(192, 106),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(154, 81),
				SequenceFlowStartPointPosition = new Point(102, 81),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7a568490-371a-4edc-bfd4-ff9f3f2948bc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("01fe088d-9a82-46d9-9c30-693c6cec6768"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("c0ea95b5-2451-408d-acf9-2a61c2f28e16"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524"),
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				CurveCenterPosition = new Point(196, 226),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(457, 81),
				SequenceFlowStartPointPosition = new Point(410, 81),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cd9d5068-1d66-4ac4-bc08-e823a6c71e72"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("aa346743-5d89-469e-a9a6-c0e32ebe5532"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("de8df54e-a133-43be-831c-bcb333ced124"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da"),
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				CurveCenterPosition = new Point(178, 226),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(154, 211),
				SequenceFlowStartPointPosition = new Point(102, 211),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6dec2d63-206a-456c-b12e-977dfab8fd3b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("111279fd-e865-4b9a-acbc-aef0ab315916"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4BaseVisaSavingSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4BaseVisaSaving",
				UId = new Guid("75052b96-e412-4aa2-98eb-fa59f9692740"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("2c390582-306b-458b-afe1-2a3764ac60ce"),
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				CurveCenterPosition = new Point(272, 84),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(271, 81),
				SequenceFlowStartPointPosition = new Point(223, 81),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("01fe088d-9a82-46d9-9c30-693c6cec6768"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ccc3e746-0a9a-45f8-9293-4a34d26a8948"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5BaseVisaInsertedSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5BaseVisaInserted",
				UId = new Guid("7986c175-cbe7-4516-af43-f664e3d10216"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("2c390582-306b-458b-afe1-2a3764ac60ce"),
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				CurveCenterPosition = new Point(538, 81),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(581, 81),
				SequenceFlowStartPointPosition = new Point(526, 81),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("aa346743-5d89-469e-a9a6-c0e32ebe5532"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("33896526-da17-42d4-b819-5aeb2e10ad7c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6BaseVisaSavedSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6BaseVisaSaved",
				UId = new Guid("4e107b8f-2068-4264-8033-362ee26f2e87"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("2c390582-306b-458b-afe1-2a3764ac60ce"),
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				CurveCenterPosition = new Point(305, 224),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(271, 211),
				SequenceFlowStartPointPosition = new Point(223, 211),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("111279fd-e865-4b9a-acbc-aef0ab315916"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4bea3148-3b2a-4e3f-a71d-82e77a3072bc"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("cf60ca83-7649-4912-b552-765c16a854d0"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524"),
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
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
				UId = new Guid("58093fcd-79e6-4466-82e4-6acb2c49642d"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("cf60ca83-7649-4912-b552-765c16a854d0"),
				CreatedInOwnerSchemaUId = new Guid("5fa90d0d-64eb-4f52-8d3d-c51fa6443b66"),
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524"),
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("83b1242b-739d-4352-9e6b-80b3f5c26dd8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("58093fcd-79e6-4466-82e4-6acb2c49642d"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524"),
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(42, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(631, 305),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBaseVisaSavingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7a568490-371a-4edc-bfd4-ff9f3f2948bc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("83b1242b-739d-4352-9e6b-80b3f5c26dd8"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524"),
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"BaseVisaSaving",
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Name = @"BaseVisaSavingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 51),
				SerializeToDB = false,
				Size = new Size(31, 31),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBaseVisaInsertedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("cd9d5068-1d66-4ac4-bc08-e823a6c71e72"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("83b1242b-739d-4352-9e6b-80b3f5c26dd8"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524"),
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"BaseVisaInserted",
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Name = @"BaseVisaInsertedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(337, 51),
				SerializeToDB = false,
				Size = new Size(31, 31),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateBaseVisaInsertedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("aa346743-5d89-469e-a9a6-c0e32ebe5532"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("83b1242b-739d-4352-9e6b-80b3f5c26dd8"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524"),
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Name = @"BaseVisaInsertedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(415, 39),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,112,74,44,78,13,203,44,78,244,204,43,78,45,42,73,77,209,72,206,207,43,73,173,40,209,180,6,0,16,146,137,210,33,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBaseVisaSavedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6dec2d63-206a-456c-b12e-977dfab8fd3b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("83b1242b-739d-4352-9e6b-80b3f5c26dd8"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da"),
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"BaseVisaSaved",
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Name = @"BaseVisaSavedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 181),
				SerializeToDB = false,
				Size = new Size(31, 31),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateBaseVisaSavedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("111279fd-e865-4b9a-acbc-aef0ab315916"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("83b1242b-739d-4352-9e6b-80b3f5c26dd8"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da"),
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Name = @"BaseVisaSavedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(112, 169),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,112,74,44,78,13,203,44,78,12,78,44,75,77,209,72,206,207,43,73,173,40,209,180,6,0,105,42,162,90,30,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1BaseVisaSavingIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("ccc3e746-0a9a-45f8-9293-4a34d26a8948"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("83b1242b-739d-4352-9e6b-80b3f5c26dd8"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("2c390582-306b-458b-afe1-2a3764ac60ce"),
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"BaseVisaSaving",
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Name = @"IntermediateThrowMessageEvent1BaseVisaSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(229, 51),
				SerializeToDB = false,
				Size = new Size(31, 31),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent2BaseVisaSavedIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("4bea3148-3b2a-4e3f-a71d-82e77a3072bc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("83b1242b-739d-4352-9e6b-80b3f5c26dd8"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("2c390582-306b-458b-afe1-2a3764ac60ce"),
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"BaseVisaSaved",
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Name = @"IntermediateThrowMessageEvent2BaseVisaSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(229, 181),
				SerializeToDB = false,
				Size = new Size(31, 31),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent3BaseVisaInsertedIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("33896526-da17-42d4-b819-5aeb2e10ad7c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("83b1242b-739d-4352-9e6b-80b3f5c26dd8"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("2c390582-306b-458b-afe1-2a3764ac60ce"),
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"BaseVisaInserted",
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Name = @"IntermediateThrowMessageEvent3BaseVisaInserted",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(539, 51),
				SerializeToDB = false,
				Size = new Size(31, 31),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateBaseVisaSavingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("01fe088d-9a82-46d9-9c30-693c6cec6768"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("83b1242b-739d-4352-9e6b-80b3f5c26dd8"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524"),
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Name = @"BaseVisaSavingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(112, 39),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,112,74,44,78,13,203,44,78,12,78,44,203,204,75,215,72,206,207,43,73,173,40,209,180,6,0,20,253,214,235,31,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateSendEmailMethod());
			Methods.Add(CreateGetGroupContactsMethod());
			Methods.Add(CreateGetSchemaTypeColumnUIdMethod());
			Methods.Add(CreateGetSchemaTypeColumnValueMethod());
			Methods.Add(CreateGetCardSchemaUIdMethod());
			Methods.Add(CreateGetCardSchemaNameMethod());
			Methods.Add(CreateSetRightMethod());
			Methods.Add(CreateGetVisaLinkMethod());
			Methods.Add(CreateAddWriteRightsMethod());
			Methods.Add(CreateRemoveWriteRightsMethod());
			Methods.Add(CreateProcessEmailBodyMethod());
			Methods.Add(CreateGetEmailTemplateIdMethod());
			Methods.Add(CreateGetVisaTemplateEntitySchemaQueryMethod());
			Methods.Add(CreateGetVisaTemplateSchemaQueryColumnsMethod());
			Methods.Add(CreateBaseVisaSavingMethod());
			Methods.Add(CreateBaseVisaSavedMethod());
			Methods.Add(CreateBaseVisaInsertedMethod());
			Methods.Add(CreateGetSectionNameMethod());
			Methods.Add(CreatePublishClientRemindingInfoMethod());
			Methods.Add(CreateGetEmailAttachmentsFromTemplateMethod());
			Methods.Add(CreateGetSysAdminUnitsInGroupMethod());
			Methods.Add(CreateGetNotificationInfoMethod());
			Methods.Add(CreateSendNotificationMethod());
			Methods.Add(CreateGetPopupBodyMethod());
			Methods.Add(CreateGetFetchedReferenceEntityMethod());
			Methods.Add(CreatePublishClientVisaInfoMethod());
			Methods.Add(CreateIsFinalStatusMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
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
				UId = new Guid("b4ea420f-1747-4595-ab25-789126e98c6b"),
				Name = "Terrasoft.Mail",
				Alias = "",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b77beabe-3462-4019-89ec-c7f463df7906"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("995f3b91-8c49-4a3e-91e8-844a842e4cf2"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("370cbd11-d7ba-41e3-92a8-c2e20475dfbc"),
				Name = "Terrasoft.Configuration.RightsService",
				Alias = "",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("60de445f-ad8e-4e3f-9462-87883ee929ac"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("868a8008-4580-40bf-9a3e-88b0ed6fd0af"),
				Name = "System.Collections",
				Alias = "",
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fdad31d6-a4d0-48ab-ac06-588a5897466d"),
				Name = "System.Text.RegularExpressions",
				Alias = "",
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("af74f3ab-a423-4d68-94c0-9cf65b0acea5"),
				Name = "Terrasoft.Messaging.Common",
				Alias = "",
				CreatedInPackageId = new Guid("7f0d2206-b4d4-499c-aac2-6529fbb3d8c3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("be94874c-996f-4f96-b0a8-7dfeaccae86f"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9ac56059-c7f9-4d05-8a21-85b433ae01b0"),
				Name = "System.Globalization",
				Alias = "",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
		}

		protected virtual SchemaMethod CreateSendEmailMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("434c3f3a-3670-4b93-8195-cac97a18d2da"),
				Name = "SendEmail",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("5372d249-808f-41d1-9f70-5d8617165f82"),
				Name = "recepients",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<Guid, string>",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,85,203,110,219,48,16,60,219,95,193,234,16,72,128,192,220,155,7,144,56,110,19,20,78,92,200,205,37,200,129,150,214,54,11,138,116,73,170,169,144,248,223,187,164,158,86,221,52,135,244,98,88,228,106,102,103,184,28,169,229,119,72,45,41,12,76,115,198,133,57,25,243,21,9,23,160,53,51,106,101,233,68,105,192,31,185,226,235,66,51,203,149,164,73,105,18,176,150,203,181,161,11,93,126,6,123,207,68,1,225,55,3,26,43,37,226,97,89,76,130,4,100,118,207,13,243,200,65,76,84,209,35,138,34,242,60,30,57,178,118,137,112,67,150,74,9,114,116,68,62,132,161,251,27,13,234,71,26,108,161,229,201,120,180,27,239,198,63,153,38,22,242,45,19,22,110,50,114,70,176,23,95,189,192,69,193,220,98,24,85,138,250,101,88,87,240,140,78,243,173,45,61,106,3,90,33,130,249,129,80,18,158,200,84,90,110,203,36,221,64,206,190,22,160,203,129,70,218,47,152,49,201,214,160,81,247,94,11,1,54,128,136,244,34,203,38,74,20,185,12,131,164,240,166,31,216,185,84,89,121,96,249,198,92,219,92,252,101,115,198,82,173,140,219,104,236,112,180,168,96,239,20,251,7,184,215,95,228,224,156,111,94,202,31,135,216,249,214,51,178,34,64,143,10,33,14,24,104,114,187,157,8,14,210,214,62,118,141,204,144,153,38,237,254,128,174,214,144,106,200,112,147,51,28,137,51,226,17,220,123,147,110,217,157,106,175,138,94,43,227,184,66,99,53,142,101,244,230,241,125,101,118,177,71,135,26,12,152,230,74,59,38,46,45,157,51,109,224,237,87,229,117,46,135,27,68,116,161,18,47,33,140,6,188,248,82,98,132,211,232,175,197,59,177,78,37,91,10,7,60,148,233,170,111,89,14,239,111,106,131,124,136,113,206,140,121,82,58,251,63,172,13,122,80,79,114,197,64,111,204,45,142,241,157,246,113,16,14,167,42,34,47,47,228,159,149,141,168,104,112,27,86,216,51,75,55,161,155,106,13,41,108,253,165,224,178,123,48,109,12,30,36,105,235,168,23,87,135,96,170,144,87,22,224,99,112,228,192,151,152,13,232,218,92,171,20,140,241,23,220,197,69,123,91,169,123,138,59,90,250,5,202,184,13,11,103,222,101,105,193,84,14,182,145,130,70,141,174,184,247,145,233,242,212,165,102,76,22,197,86,192,233,18,203,31,30,227,218,154,243,115,194,172,69,165,185,147,212,11,226,139,110,245,147,86,121,19,58,225,94,172,120,5,57,246,141,249,137,239,118,241,65,241,202,99,245,172,218,10,151,94,67,219,116,29,163,49,26,226,34,162,234,228,225,145,60,15,76,219,197,228,208,89,245,144,186,124,141,251,58,92,107,86,151,222,242,94,83,238,179,214,180,84,119,189,199,224,94,219,145,148,217,116,67,66,127,203,126,97,63,206,68,2,213,249,29,31,147,197,221,213,221,71,34,212,154,64,179,91,125,211,126,3,202,198,250,84,145,7,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetGroupContactsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ccbb92af-522d-4872-bb42-f0b0ba68861e"),
				Name = "GetGroupContacts",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524"),
				ResultValueTypeName = "Dictionary<Guid, string>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("79a8356a-514f-4c0f-8952-0c5713711322"),
				Name = "sysAdminUnitId",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,86,75,79,219,64,16,62,7,137,255,176,228,128,214,82,100,137,208,27,165,18,121,180,77,139,8,37,161,151,138,195,214,158,192,74,246,110,186,15,32,66,252,247,206,62,156,216,73,156,83,15,141,242,176,103,190,249,190,153,241,236,110,70,60,51,92,10,166,86,31,191,88,158,247,136,54,138,139,199,79,4,74,198,11,77,46,137,128,23,50,106,65,209,228,226,248,232,153,41,82,50,241,36,173,250,202,65,49,149,61,241,140,21,51,40,32,51,145,32,220,208,123,13,106,40,133,0,79,151,28,31,117,210,161,44,108,41,104,119,182,210,87,121,201,197,189,224,166,219,35,221,73,222,77,210,43,77,253,69,29,136,241,134,101,77,76,180,29,128,142,93,57,17,29,175,247,32,251,13,214,1,211,112,152,185,191,77,237,66,246,208,111,23,119,203,20,8,115,39,11,88,139,53,77,46,248,179,146,229,86,168,183,95,195,194,76,173,1,245,77,242,90,145,141,78,244,241,118,186,175,174,137,30,255,177,172,216,77,105,171,208,45,17,68,187,103,55,17,46,193,200,221,180,33,5,26,214,37,181,234,180,11,212,202,244,165,212,77,253,3,154,222,208,170,217,63,32,186,105,221,116,207,96,181,211,213,122,69,152,142,195,141,43,97,119,252,167,75,55,232,154,200,248,27,86,67,43,142,38,228,13,243,196,215,173,226,37,46,183,48,64,55,172,4,12,117,105,245,162,219,79,75,211,219,152,160,136,11,236,243,213,210,33,118,101,157,35,29,62,241,34,199,208,24,50,17,89,97,115,184,134,103,40,130,0,134,26,101,161,242,235,17,215,134,11,191,182,157,221,155,223,177,252,31,22,92,198,34,231,174,24,220,35,152,66,220,227,198,114,89,245,33,157,69,95,163,204,53,16,185,118,130,253,179,27,191,46,21,104,29,184,92,39,163,164,139,222,248,194,158,177,151,164,122,166,33,36,197,150,97,243,112,30,168,174,61,227,73,190,189,68,123,100,14,74,49,45,23,6,215,116,89,202,90,232,136,171,176,157,165,19,177,180,38,113,194,173,219,97,90,55,77,215,67,17,219,130,145,86,99,190,132,186,61,53,255,61,126,133,204,26,169,16,209,220,57,211,177,208,86,193,104,176,49,209,36,204,78,141,64,1,203,193,5,183,167,19,20,224,206,35,233,70,49,146,117,94,112,54,128,208,192,148,58,88,165,211,233,240,5,161,39,209,131,67,49,184,177,69,65,207,146,36,78,176,203,32,171,22,202,110,5,163,129,27,62,52,60,131,194,46,226,253,79,86,88,152,75,119,192,68,193,95,103,15,174,155,21,155,63,146,144,41,58,251,15,233,92,206,252,65,68,43,152,207,41,28,78,152,147,203,104,170,198,229,210,172,168,15,78,200,233,41,57,9,71,91,234,87,49,23,250,59,172,232,58,209,117,117,157,78,132,93,229,249,198,221,11,73,84,114,239,97,246,219,219,113,254,79,219,113,126,168,29,31,254,171,118,184,47,252,224,251,248,72,129,177,74,196,127,20,23,127,1,223,197,93,3,114,8,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSchemaTypeColumnUIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d772332f-4a7d-4c8d-954e-3f681279445b"),
				Name = "GetSchemaTypeColumnUId",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524"),
				ResultValueTypeName = "Guid"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2a85154c-79ba-4bfd-a566-927108bfd5f9"),
				Name = "schemaUId",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,65,79,194,48,24,61,111,201,254,67,179,211,150,44,13,119,149,196,44,147,112,192,160,136,30,8,135,202,62,165,102,107,103,215,206,52,132,255,110,75,113,96,199,129,211,178,126,239,123,239,245,189,118,68,32,96,146,74,189,216,108,161,38,79,10,132,70,119,136,193,15,42,252,243,100,217,130,200,57,99,176,145,148,51,124,14,152,17,70,62,65,100,40,94,232,118,198,75,85,129,27,199,233,77,20,118,70,166,17,180,38,66,231,188,82,53,123,36,53,24,153,129,52,190,47,75,135,72,134,179,103,206,165,251,199,19,144,115,159,47,73,83,108,191,71,61,169,27,112,195,105,121,133,92,252,210,227,151,211,50,238,169,162,112,184,245,64,43,9,162,181,219,23,108,230,2,136,4,135,121,163,114,59,39,194,80,217,133,196,29,230,188,110,136,160,45,103,86,19,23,223,138,84,89,20,218,228,206,35,181,54,178,67,19,252,253,203,68,190,90,239,218,191,193,62,77,15,222,186,190,63,99,189,114,189,92,188,168,9,172,240,112,94,157,142,208,207,206,104,25,190,137,162,37,46,234,70,106,3,162,31,40,241,53,113,206,21,147,104,140,70,41,218,69,97,112,242,213,187,57,129,87,163,181,161,9,124,17,7,179,78,109,44,199,94,94,73,165,224,214,234,143,19,191,81,235,56,240,158,219,117,76,131,183,104,169,246,81,40,64,42,193,254,95,223,76,126,1,69,248,107,109,38,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSchemaTypeColumnValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6e63ac4b-32c3-4327-9c37-92676f02de96"),
				Name = "GetSchemaTypeColumnValue",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524"),
				ResultValueTypeName = "Guid"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("aac498c4-764f-4f61-8c2c-618271f8f40c"),
				Name = "referenceSchemaName",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("1568f3ff-c91e-4345-86c1-1e03ab617b22"),
				Name = "typeColumnName",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("49ede350-542b-4968-8212-c47b519cd4e4"),
				Name = "primaryColumnValue",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,145,205,10,194,48,16,132,207,22,250,14,241,86,161,244,5,170,130,72,233,73,65,252,185,135,118,171,129,102,91,214,164,18,196,119,55,37,150,134,214,235,206,236,206,151,73,199,137,41,211,194,190,169,181,196,27,175,53,176,13,203,181,40,147,76,182,202,164,97,16,6,157,53,1,42,161,204,185,120,128,228,39,13,100,172,13,225,197,178,233,60,186,62,129,246,13,34,20,74,52,152,248,134,3,71,126,7,138,25,65,5,4,88,128,155,31,185,132,85,234,130,70,26,155,48,75,77,118,101,233,212,104,52,14,235,62,233,223,229,28,148,195,153,64,198,172,37,33,57,25,175,134,254,160,168,88,244,59,183,180,207,213,117,189,98,239,48,88,204,27,115,174,62,224,98,181,210,19,215,125,153,91,143,54,25,112,63,97,64,160,52,225,244,7,210,47,22,254,255,189,150,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetCardSchemaUIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f521ad99-5746-425e-8d1f-ba83be7da654"),
				Name = "GetCardSchemaUId",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524"),
				ResultValueTypeName = "Guid"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("1b580753-6af1-4dde-ae91-ce06597ab1f8"),
				Name = "typeColumnValue",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("63244a5a-3568-456c-a1c8-9bc7f6183503"),
				Name = "sysModuleEntityId",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,147,193,79,194,48,20,198,207,107,210,255,161,238,212,37,100,225,142,146,152,101,18,14,24,13,160,7,194,161,210,167,212,108,45,118,45,102,33,252,239,118,43,113,163,243,236,181,253,222,123,223,239,235,235,145,105,178,99,154,47,119,123,40,217,122,206,201,29,153,89,193,211,188,60,152,122,130,17,70,71,39,1,105,132,169,189,232,217,130,174,157,76,194,55,201,195,115,186,174,64,103,74,74,216,25,161,100,218,23,44,152,100,31,160,71,36,94,214,213,66,113,91,64,206,133,137,147,137,31,98,234,3,100,170,176,165,116,221,7,19,211,123,206,253,45,141,179,190,227,182,30,163,97,193,131,40,12,232,170,41,164,195,219,76,3,51,224,53,175,194,236,159,152,102,37,52,5,212,31,102,170,60,48,45,42,37,87,206,88,154,127,89,86,140,48,234,153,111,123,198,163,54,9,245,246,233,144,55,219,83,117,125,61,231,231,196,27,20,239,132,222,116,140,47,172,176,151,174,21,237,34,79,18,114,194,40,250,47,154,40,94,93,59,10,113,2,195,30,230,220,2,245,87,195,73,10,255,228,127,190,221,12,76,30,232,130,77,233,50,10,27,166,153,178,210,144,41,25,251,104,186,161,191,163,58,241,102,188,117,141,162,112,165,189,172,177,209,224,242,30,208,109,19,253,148,118,152,233,163,11,174,133,196,72,131,177,90,94,127,144,11,58,70,63,178,7,232,65,59,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetCardSchemaNameMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ac71cd71-d5a4-495f-ae99-a4946dea1824"),
				Name = "GetCardSchemaName",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("42764593-931e-45f1-b5b3-2d7564270049"),
				Name = "cardSchemaUId",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,82,193,78,195,48,12,61,175,82,255,33,234,169,149,166,106,247,194,36,84,10,218,1,4,26,131,195,180,67,104,205,22,212,38,197,113,134,170,105,255,78,178,0,157,90,184,218,207,239,61,63,123,207,145,149,28,171,101,185,131,134,223,243,6,24,187,100,154,80,200,109,90,52,45,117,89,24,132,193,222,194,64,146,160,206,3,31,13,96,103,129,18,62,89,49,172,199,43,13,152,43,41,161,36,161,100,122,14,184,227,146,111,1,167,44,90,118,218,151,162,36,243,2,212,181,144,171,218,52,210,50,143,212,210,171,170,242,221,56,114,62,79,99,97,48,198,45,244,181,208,36,100,73,150,134,208,192,63,184,27,81,19,160,118,188,241,184,155,35,112,2,143,121,17,180,123,224,104,69,221,64,236,139,185,106,90,142,66,43,249,100,125,167,197,135,225,245,52,12,162,213,162,138,166,167,96,212,235,187,77,96,189,57,244,1,219,230,49,241,198,207,67,181,123,213,62,172,63,55,191,5,42,6,184,65,198,158,82,188,177,120,72,152,230,202,72,98,115,54,75,216,33,12,38,189,232,175,84,15,94,207,54,150,104,50,120,136,31,156,243,225,118,253,62,195,51,175,13,92,248,87,153,199,253,241,82,55,228,12,29,157,39,4,50,40,7,63,150,125,1,10,78,147,103,119,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetRightMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("266c4a08-a3f9-49aa-bb57-1da59c836150"),
				Name = "SetRight",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c8d918b9-53eb-4e32-ae72-5b349aeeef54"),
				Name = "adminUnitId",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("fdaa17d8-8a8c-45b8-a70a-6a8e67e7900c"),
				Name = "operation",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "int",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b677c96f-a2ee-45fe-acf9-f7459022ed94"),
				Name = "rightLevel",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "int",
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,143,203,10,194,48,16,69,247,130,255,144,101,11,165,63,80,117,83,180,10,34,210,170,251,161,25,218,129,60,36,153,22,250,247,134,4,180,11,151,243,56,103,238,120,118,100,6,225,251,17,53,220,64,163,216,139,163,97,226,165,236,190,189,106,187,241,105,15,164,38,67,161,0,70,217,98,111,157,188,200,31,114,119,164,193,45,181,85,147,54,47,80,19,150,15,219,69,52,203,131,101,6,39,28,13,35,251,51,170,55,186,64,214,10,188,63,65,207,214,45,101,131,188,107,87,243,67,164,154,137,100,194,226,173,181,160,236,144,83,140,136,101,49,223,211,80,216,44,86,79,21,255,131,23,194,6,7,48,89,83,36,237,21,103,84,121,245,1,191,224,55,239,22,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetVisaLinkMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b0666a18-710e-4a5f-92ef-f9ebc3b5421b"),
				Name = "GetVisaLink",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,84,219,110,211,64,16,125,142,191,98,49,82,229,136,104,3,225,209,128,84,66,40,145,104,133,200,133,231,141,61,105,86,248,214,221,113,105,20,249,223,217,139,131,189,206,86,188,244,37,138,103,230,204,204,57,51,179,143,76,16,153,28,32,103,243,50,171,243,66,146,143,100,81,32,199,35,93,25,51,109,237,113,240,168,66,5,236,65,64,145,128,117,222,177,28,20,64,162,224,197,61,93,228,21,30,189,113,155,101,170,194,110,106,158,158,131,108,141,85,175,178,250,205,32,65,94,22,67,116,215,89,81,103,89,28,4,251,82,0,75,14,36,210,165,18,227,37,188,112,121,140,201,41,24,241,61,137,94,217,0,186,148,203,226,0,130,35,164,228,234,170,133,209,47,12,217,150,101,53,172,143,21,168,152,239,101,249,187,174,12,120,228,39,219,2,127,186,78,170,189,241,37,200,50,127,6,163,156,30,72,71,247,25,216,191,137,140,154,160,49,114,231,140,23,86,81,83,174,29,224,13,160,102,149,218,120,195,242,131,158,193,167,200,199,236,13,9,151,105,56,182,243,67,133,179,176,118,116,128,54,116,221,119,12,243,40,83,139,79,152,72,125,43,50,47,139,132,161,175,254,132,132,63,216,61,132,23,9,46,119,199,76,213,233,144,46,30,106,150,201,168,139,26,155,17,186,84,218,86,252,114,107,181,62,31,53,41,39,243,152,158,197,161,74,157,120,152,210,136,234,215,199,184,252,76,221,150,38,206,248,20,255,209,5,121,192,121,223,20,13,26,152,144,213,81,222,150,105,157,129,63,77,203,220,201,163,109,145,83,73,97,26,2,153,4,45,221,127,123,232,180,126,193,242,102,246,210,62,3,58,162,219,190,206,22,249,170,13,112,222,106,110,222,243,166,67,94,101,12,253,207,152,122,104,114,134,43,20,23,94,251,69,118,76,194,70,100,202,189,6,33,152,44,247,72,127,193,78,237,121,158,151,133,254,187,65,158,113,228,32,131,145,89,49,5,184,174,170,140,171,51,80,189,40,108,228,34,191,33,86,244,122,167,242,51,211,173,52,22,117,55,8,79,72,231,181,80,219,132,234,73,120,168,65,226,216,30,67,143,152,190,48,84,235,36,163,112,59,11,237,21,244,40,134,167,247,205,244,174,230,211,45,135,63,86,68,202,100,245,244,186,213,215,154,182,179,233,105,214,76,79,111,155,41,164,28,167,167,119,141,94,125,143,26,95,141,41,58,87,152,12,14,223,93,237,73,127,66,147,179,118,206,214,57,173,206,252,173,234,169,218,111,211,225,163,114,191,92,135,189,166,226,64,0,214,162,232,182,32,14,254,2,110,62,90,139,47,7,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateAddWriteRightsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6d1a0a51-eff0-4fe4-901e-f51a86573243"),
				Name = "AddWriteRights",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("0cb0defb-be94-4a77-b674-8c73bdebea31"),
				Name = "adminUnitId",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,143,205,10,130,64,20,133,215,249,20,46,11,100,94,160,149,153,72,16,21,138,237,47,51,55,189,48,115,71,198,107,225,219,39,90,171,104,213,166,229,57,124,156,159,186,199,144,121,102,212,66,158,213,126,87,161,30,2,201,152,115,67,140,170,66,201,89,38,93,233,22,29,148,168,125,48,37,53,173,28,241,142,118,13,198,17,215,76,114,48,73,188,144,106,65,213,9,28,38,209,234,101,94,2,57,8,99,230,237,224,248,10,118,192,55,255,145,124,238,48,192,60,167,68,48,95,177,121,128,74,173,245,143,148,77,17,128,101,170,43,6,50,42,119,157,140,73,124,3,219,227,102,27,213,127,125,50,55,36,191,159,124,2,35,22,28,125,201,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateRemoveWriteRightsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f7a64fe8-e4b4-46dc-aa09-7b49e557e10e"),
				Name = "RemoveWriteRights",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("af30e57b-f970-4042-9f76-7604011f7271"),
				Name = "adminUnitId",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,142,193,10,194,48,16,68,207,250,21,61,42,148,252,128,55,219,32,130,168,180,212,251,146,172,237,66,178,41,233,70,200,223,91,90,61,137,199,25,30,51,175,155,48,86,129,25,141,80,96,85,31,91,52,41,146,100,205,61,49,170,22,69,179,204,185,53,3,122,104,208,132,104,27,234,7,185,224,11,221,14,172,39,238,152,228,108,203,98,37,213,138,170,43,120,44,183,155,79,121,143,228,33,230,42,184,228,249,1,46,225,151,255,89,190,141,24,97,209,209,150,228,47,182,8,168,26,57,207,47,167,68,86,105,63,74,46,139,39,184,9,247,135,55,43,214,0,211,219,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateProcessEmailBodyMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ff6af76f-4e0e-45d7-973e-c9891a8f4344"),
				Name = "ProcessEmailBody",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("440e3e06-2616-4fc8-97f4-d462f5843716"),
				Name = "body",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("5c63b825-44a6-4d0e-9db2-e55b83520f8b"),
				Name = "contactId",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8ac79cf4-5d74-4ae1-8ae7-d2685c54138f"),
				Name = "macrosBytes",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "byte[]",
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,84,93,79,219,48,20,125,166,18,255,193,74,31,112,166,44,244,113,130,182,8,218,50,117,2,166,209,210,151,182,147,76,114,11,214,28,39,216,78,105,134,248,239,243,71,2,77,2,123,104,147,92,223,115,239,57,247,195,91,34,80,46,24,26,160,239,160,22,84,146,43,202,255,96,255,244,176,115,159,198,133,54,75,37,40,127,8,47,83,145,16,133,141,49,48,0,227,113,216,217,106,244,86,131,38,92,81,85,204,162,71,72,200,175,28,68,241,30,111,14,73,198,136,130,150,139,77,82,15,48,74,25,131,72,209,148,107,252,135,113,67,29,181,233,139,239,36,136,81,202,185,251,52,97,233,6,225,143,194,134,163,52,231,10,13,6,168,231,163,23,116,216,57,16,160,114,193,145,209,165,113,175,77,70,53,30,239,113,150,189,117,73,158,196,49,196,250,32,79,184,212,206,248,138,74,213,111,209,118,14,67,255,220,120,87,21,41,81,182,144,51,91,229,139,156,178,24,4,146,247,23,174,248,136,195,51,170,157,217,14,24,137,155,84,0,137,30,17,254,36,25,2,249,84,190,81,94,163,169,149,107,225,86,39,97,57,212,36,154,250,58,183,133,57,195,111,65,194,27,146,128,201,107,129,110,40,22,21,220,62,169,68,99,173,106,78,19,64,103,8,227,234,195,183,199,126,56,79,103,143,169,80,198,236,20,97,31,157,56,172,57,43,77,85,134,136,100,229,28,188,83,24,57,91,195,219,244,218,125,135,83,121,147,51,246,83,76,146,76,21,120,143,164,239,52,219,200,2,158,96,151,181,38,219,235,142,129,129,130,233,198,162,187,120,249,187,187,254,114,230,175,86,203,238,75,239,181,187,90,173,43,147,126,63,174,59,123,65,69,216,82,58,184,133,7,216,33,161,147,152,6,218,47,236,242,186,243,183,230,93,19,165,31,137,253,215,109,18,161,53,128,116,109,46,89,31,184,121,8,111,65,207,77,4,216,186,135,86,88,80,169,176,60,92,112,61,196,246,215,64,53,228,58,85,107,205,252,127,5,246,131,253,94,251,110,69,26,129,155,149,243,218,164,90,136,118,253,62,129,76,185,94,110,133,123,1,242,250,49,221,106,183,130,193,96,229,109,82,174,190,110,72,66,89,113,130,142,22,32,98,194,201,209,233,202,27,122,123,232,243,44,3,30,99,175,127,172,177,238,164,186,214,156,67,109,148,204,116,36,36,18,169,52,91,172,157,126,72,93,140,49,104,6,148,48,250,23,250,118,187,199,212,222,1,68,20,122,103,68,49,28,226,89,33,21,36,225,28,118,42,156,240,40,141,141,146,187,249,229,55,179,78,101,2,23,248,162,80,32,253,61,30,147,132,80,86,221,8,119,138,50,179,132,101,157,110,33,162,25,5,174,174,45,214,132,47,47,224,72,171,39,145,154,198,193,30,225,0,181,47,194,250,245,246,15,241,136,118,226,237,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetEmailTemplateIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c782512b-f337-4fad-a027-0f6de9c84192"),
				Name = "GetEmailTemplateId",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da"),
				ResultValueTypeName = "Guid"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,144,63,11,194,64,12,197,103,11,253,14,193,65,90,40,135,187,56,73,21,23,151,86,247,168,169,158,244,238,36,151,27,138,248,221,189,170,80,69,92,50,252,222,203,159,23,183,191,208,65,64,200,92,177,21,90,31,103,105,226,133,181,61,1,89,209,210,85,135,51,25,220,160,33,152,67,249,68,234,197,84,15,7,123,63,162,69,161,170,243,21,137,68,180,112,199,190,233,165,171,165,99,131,146,141,111,211,123,105,80,183,245,219,63,46,126,54,229,113,170,110,32,171,137,25,189,107,68,45,28,83,44,182,209,167,192,40,218,89,53,236,241,170,230,110,69,178,195,54,80,182,245,196,209,105,99,172,104,43,254,220,85,128,11,159,177,115,152,76,210,100,52,0,208,30,86,65,71,225,22,57,147,4,182,144,61,201,215,179,238,105,242,22,123,77,149,230,42,221,236,1,89,175,195,112,86,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetVisaTemplateEntitySchemaQueryMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("89e39e48-b884-4bab-ac34-3f29297b3f68"),
				Name = "GetVisaTemplateEntitySchemaQuery",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da"),
				ResultValueTypeName = "EntitySchemaQuery"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,81,221,74,195,48,20,190,182,208,119,200,101,10,210,23,152,10,163,84,111,100,108,108,204,235,99,115,180,129,36,237,146,147,73,17,223,221,196,152,174,211,203,124,231,251,59,39,103,176,140,224,85,97,187,223,177,123,102,240,131,181,134,36,77,251,174,71,13,59,143,118,226,9,169,19,84,173,202,226,28,84,221,160,188,54,46,136,158,144,142,210,193,1,245,168,128,112,161,108,18,135,103,13,8,129,162,153,133,49,237,89,58,186,251,23,153,56,15,63,194,183,193,34,116,61,119,100,165,121,255,205,221,128,70,38,77,110,81,177,207,178,184,89,218,215,107,33,120,222,44,62,18,206,47,242,42,154,127,149,197,58,170,114,249,75,185,165,89,32,206,86,143,82,17,218,63,254,77,168,72,152,70,47,146,250,45,216,144,16,121,60,129,205,160,71,176,210,13,230,48,141,88,183,39,15,234,150,133,206,87,183,173,195,41,183,86,106,200,23,136,61,121,181,36,94,141,143,160,124,218,195,34,121,107,230,175,92,125,3,174,192,87,152,216,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetVisaTemplateSchemaQueryColumnsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("691e2835-e082-4b43-9995-8670510be586"),
				Name = "GetVisaTemplateSchemaQueryColumns",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da"),
				ResultValueTypeName = "List<string>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,201,44,46,177,41,46,41,202,204,75,183,83,72,206,207,41,205,205,43,86,176,85,200,75,45,87,240,65,146,210,208,84,168,230,226,84,10,203,44,78,244,47,207,75,45,210,243,75,204,77,85,210,1,10,249,39,101,165,38,151,100,150,165,42,113,213,90,115,21,165,150,148,22,229,193,12,178,6,0,47,254,98,90,94,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateBaseVisaSavingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b699e815-43f3-4836-82a5-96237cbfd1d8"),
				Name = "BaseVisaSaving",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("0abdaa0a-7111-474b-9478-95dfeb6fb8b4"),
				Name = "context",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext",
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,207,73,9,203,44,78,244,47,207,75,45,242,76,81,176,85,112,205,43,201,44,169,212,115,79,45,9,169,44,72,77,241,207,73,113,206,207,41,205,205,11,75,204,41,77,181,113,47,205,76,177,211,80,66,210,162,164,105,205,203,149,159,147,226,146,154,147,154,158,88,146,154,226,86,148,159,75,188,73,104,218,192,166,21,165,150,148,22,229,41,148,20,149,166,90,3,0,238,69,216,8,160,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateBaseVisaSavedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("08ff0265-fee1-4922-8f01-bc00502dd7c8"),
				Name = "BaseVisaSaved",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("5a5912dc-2cd4-4976-95d4-a3619ea80c8f"),
				Name = "context",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext",
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,83,193,106,220,48,16,61,59,144,127,80,125,8,94,88,76,233,53,164,208,58,222,96,40,105,216,165,219,179,214,154,245,10,228,209,34,75,14,75,155,127,239,72,246,182,182,200,54,144,131,15,242,188,153,55,239,233,169,231,134,245,178,227,223,159,17,76,37,216,29,43,209,74,123,202,183,255,126,222,94,95,245,4,19,160,160,225,22,196,202,232,118,10,189,159,23,8,46,247,44,155,76,205,171,238,81,219,178,61,218,83,182,96,55,55,51,198,15,119,76,43,49,161,91,176,95,215,87,137,103,132,150,75,213,17,209,3,216,7,163,221,177,208,104,121,109,187,233,240,5,241,37,158,112,64,231,133,118,104,217,103,246,113,152,147,108,0,69,233,75,35,32,224,95,232,251,34,196,79,35,45,172,101,115,184,48,146,22,139,196,205,164,248,241,164,102,190,254,219,136,81,114,52,249,34,52,242,125,148,181,134,86,247,48,21,16,185,120,150,233,117,252,232,192,144,119,8,181,149,26,115,178,179,234,86,192,173,51,80,34,223,41,16,89,74,75,203,189,172,185,71,108,63,165,139,145,103,180,225,146,192,17,149,60,185,157,146,221,161,80,18,208,122,112,133,123,29,53,46,89,234,181,88,72,195,114,97,187,112,61,83,234,236,188,248,203,16,35,34,131,231,129,37,74,149,247,38,18,86,56,99,136,223,255,205,255,58,21,97,238,191,110,160,118,228,219,169,196,70,34,228,27,176,67,144,55,245,129,34,178,134,90,27,17,60,253,6,61,168,216,188,57,199,50,168,31,31,194,48,32,127,228,45,44,207,143,227,201,200,150,155,83,161,149,107,113,203,149,163,210,235,68,20,93,142,107,224,33,9,201,239,255,161,138,3,199,6,60,54,20,150,108,207,85,7,145,115,239,191,244,157,214,138,201,110,37,145,171,141,165,14,255,6,171,233,57,59,43,14,167,201,139,153,117,141,23,240,122,54,250,139,193,240,18,24,41,133,208,62,235,166,212,75,20,18,155,48,34,117,71,193,199,46,106,50,64,218,144,89,227,224,246,15,107,134,96,210,216,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateBaseVisaInsertedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("83c51e9b-7f53-4418-9ff1-239c6f660ef1"),
				Name = "BaseVisaInserted",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ddd00273-c41d-4b74-94cb-24e8ac22b95b"),
				Name = "context",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext",
				CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,44,246,75,45,87,176,85,40,41,42,77,181,230,42,74,45,41,45,202,131,112,0,81,246,91,196,26,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSectionNameMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("fdbdecd2-ac5e-494e-a1ab-b290b29c8d8e"),
				Name = "GetSectionName",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				CreatedInPackageId = new Guid("bdf5e7a6-6217-42ac-a803-164d54ce38e7"),
				ResultValueTypeName = "Guid"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6d100490-6323-48b8-bf2f-6bd341fc7f41"),
				Name = "Id",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("bdf5e7a6-6217-42ac-a803-164d54ce38e7")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,82,65,106,195,48,16,60,199,160,63,8,159,108,48,34,119,183,129,98,220,144,67,74,139,155,246,16,114,80,173,109,163,34,75,174,44,165,152,144,191,87,142,74,156,202,189,238,206,206,204,206,238,129,106,92,83,205,170,122,15,13,221,172,24,190,197,75,203,25,41,155,214,244,57,138,80,116,112,16,144,134,155,222,131,158,44,232,222,193,36,124,227,50,172,39,155,14,116,161,164,132,218,112,37,201,53,96,77,37,253,0,157,225,184,234,187,181,98,86,64,156,230,94,192,244,45,20,74,216,70,58,230,137,26,185,99,204,119,147,184,242,204,23,195,103,10,20,77,103,238,185,48,160,187,97,54,153,118,11,13,212,128,199,188,114,179,127,164,154,54,48,12,36,190,88,168,166,165,154,119,74,62,59,111,164,252,178,84,100,40,26,189,251,213,226,236,28,132,122,251,116,190,182,187,227,138,157,210,52,200,205,89,23,222,245,191,203,45,193,148,1,46,136,209,19,242,119,156,132,132,164,80,86,26,188,192,243,20,31,81,52,27,69,47,82,35,120,59,223,57,162,89,120,111,15,27,108,12,155,254,6,253,66,133,133,155,225,21,22,201,120,28,242,224,66,26,220,156,80,164,193,88,45,255,126,79,254,3,73,232,248,22,80,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreatePublishClientRemindingInfoMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9a6555de-18b1-4956-b8f1-3122138aeadf"),
				Name = "PublishClientRemindingInfo",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				CreatedInPackageId = new Guid("7f0d2206-b4d4-499c-aac2-6529fbb3d8c3"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c1741515-306a-497c-b038-b50323724531"),
				Name = "operation",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("7f0d2206-b4d4-499c-aac2-6529fbb3d8c3")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,206,191,14,130,48,16,199,241,89,18,222,161,97,42,137,225,5,252,179,32,16,22,117,48,236,53,61,244,146,210,35,229,138,33,198,119,87,92,68,226,224,254,187,207,125,123,229,68,143,157,58,220,44,184,82,139,141,200,44,35,15,73,1,124,26,90,208,41,25,223,216,74,25,15,235,194,163,222,202,168,250,236,163,120,21,6,253,203,208,96,224,162,24,116,238,168,249,211,217,125,223,188,173,163,63,27,236,174,169,65,176,60,62,42,109,77,114,82,184,20,212,130,83,140,100,199,61,214,66,146,209,147,164,164,236,246,196,89,211,242,32,227,88,220,195,96,241,27,157,37,207,224,199,19,241,191,143,47,26,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetEmailAttachmentsFromTemplateMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6b5c7d27-49fd-4b7c-a1b5-64b149a9d220"),
				Name = "GetEmailAttachmentsFromTemplate",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				CreatedInPackageId = new Guid("611e9039-f1ff-48b5-869d-f34bdfcc83e1"),
				ResultValueTypeName = "Dictionary<Guid, Tuple<byte[], string>>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("5f577ff0-f573-4b00-ab58-cb758733fb18"),
				Name = "templateId",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("611e9039-f1ff-48b5-869d-f34bdfcc83e1")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,77,79,227,48,16,61,167,82,254,131,213,147,43,69,249,3,180,149,74,105,81,37,88,1,45,203,1,237,193,36,211,214,82,108,7,127,128,162,21,255,125,199,177,67,147,130,86,162,167,102,252,230,205,155,55,99,191,49,77,52,24,87,89,50,35,18,222,201,21,47,44,87,146,233,102,122,237,120,153,145,157,171,43,152,190,52,22,158,255,100,196,88,205,229,97,62,167,147,139,116,244,134,201,32,45,183,205,182,56,130,96,72,241,104,64,47,149,148,208,178,228,171,222,233,45,147,236,0,58,191,6,187,145,198,50,89,192,101,243,139,9,160,227,149,96,188,218,129,168,43,102,97,205,43,24,119,244,70,23,171,237,125,212,214,103,187,119,160,27,218,175,238,83,2,60,223,152,43,110,44,151,133,239,202,106,7,145,141,151,75,85,57,33,201,44,2,23,101,140,208,24,120,80,202,6,58,175,243,78,115,129,78,4,72,43,117,210,9,147,248,213,145,145,47,108,99,15,198,38,18,66,200,167,42,108,204,130,54,30,214,149,91,106,8,29,227,193,19,183,199,59,166,49,209,163,104,8,46,149,168,153,230,70,201,93,83,67,190,122,117,172,202,200,208,176,113,70,108,252,187,41,39,61,231,110,208,132,147,58,236,39,24,136,26,171,48,31,58,28,87,151,186,199,9,60,64,173,12,183,74,55,200,176,172,152,49,107,86,248,79,207,51,93,15,16,115,154,142,146,36,241,35,66,50,92,17,231,145,11,125,112,2,7,68,199,110,80,5,229,158,149,245,117,247,10,173,40,142,132,70,237,132,203,174,133,9,249,139,252,97,126,97,54,125,227,243,56,174,16,51,94,94,92,171,110,218,185,255,242,53,146,174,185,77,25,115,17,236,125,141,192,223,172,114,208,174,253,156,14,75,229,61,192,128,205,175,193,79,52,157,214,230,171,42,31,248,143,174,109,184,122,244,188,228,183,218,156,65,108,48,83,128,192,25,97,54,48,17,47,210,109,47,132,43,221,250,219,202,120,121,215,28,183,46,194,46,185,127,7,158,218,16,237,211,180,37,78,110,202,189,194,140,225,214,228,55,138,149,126,77,6,119,52,127,220,224,147,18,70,144,117,213,2,219,183,239,12,97,214,250,173,152,133,103,40,222,151,115,212,64,91,190,83,11,173,89,67,39,217,167,171,161,66,120,231,218,235,215,41,8,244,237,241,71,18,126,233,232,35,29,165,35,13,214,105,25,223,198,139,127,222,131,225,92,39,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSysAdminUnitsInGroupMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("fd849ebd-6bd6-4e10-8556-f89ecaf04353"),
				Name = "GetSysAdminUnitsInGroup",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				ResultValueTypeName = "IEnumerable<Guid>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("59890cce-0d6d-4b5f-aca7-ee381f0cc2be"),
				Name = "sysAdminUnit",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,80,203,78,195,48,16,60,147,175,88,229,228,72,81,126,160,164,82,21,149,40,7,36,32,20,206,110,179,165,70,246,58,245,3,148,191,199,174,211,170,42,221,211,218,179,59,51,59,63,220,0,218,35,212,64,248,11,107,114,194,77,253,238,128,138,191,122,52,19,219,88,52,141,38,194,157,19,154,170,235,129,103,78,252,11,77,9,121,63,217,56,215,209,155,150,152,23,139,44,48,86,171,97,104,180,244,138,216,25,191,143,156,119,186,127,226,79,66,186,192,234,80,193,254,212,6,151,113,191,49,200,29,38,244,83,184,195,11,55,92,97,120,88,150,62,27,173,70,110,132,213,244,62,141,88,173,143,158,203,50,131,80,23,193,18,152,222,126,135,171,10,59,217,213,160,4,109,72,184,217,96,98,177,209,40,75,202,1,72,246,130,113,153,178,0,131,214,75,55,123,106,209,221,14,220,100,151,78,244,10,13,223,74,124,108,189,24,150,112,45,222,81,107,180,31,161,206,30,66,37,246,170,199,200,198,240,196,13,245,18,82,23,245,226,109,115,144,31,92,250,153,242,146,118,55,228,69,208,52,232,188,161,123,66,139,63,79,5,136,155,252,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetNotificationInfoMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9c4eb591-09a2-4c7d-8f36-ffe2ad62f824"),
				Name = "GetNotificationInfo",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				ResultValueTypeName = "INotificationInfo"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,146,65,110,194,48,16,69,215,225,20,46,171,84,66,185,0,165,18,80,64,89,148,34,66,216,187,201,64,45,37,118,100,143,139,162,170,119,175,199,73,9,65,192,206,246,252,255,231,141,237,120,173,80,28,68,198,81,40,153,0,162,144,71,179,133,74,25,129,74,215,76,62,46,79,216,188,224,198,44,121,70,219,104,5,248,242,56,240,53,28,4,65,32,225,196,230,74,26,212,150,140,83,125,180,37,72,12,135,214,128,118,5,9,25,217,135,35,150,246,14,158,159,199,206,190,178,34,103,162,228,71,136,115,71,240,24,145,152,46,145,98,242,133,11,137,2,235,40,201,190,160,228,81,26,231,35,38,109,81,248,248,111,174,153,134,3,104,144,25,52,66,215,197,197,44,1,157,62,223,246,107,225,217,244,169,114,82,186,169,28,66,180,40,43,172,239,228,121,110,26,163,83,53,46,102,60,209,154,151,64,135,226,192,194,107,148,167,73,131,202,126,232,38,219,158,142,110,163,42,91,205,220,246,218,225,249,130,91,4,87,103,209,70,187,91,213,245,92,21,182,148,123,94,88,15,17,116,76,55,60,73,15,248,151,65,97,160,65,235,217,110,171,7,196,133,86,75,70,63,162,247,76,242,160,154,152,89,51,33,13,58,162,253,59,24,243,255,244,109,170,123,62,170,220,159,172,21,236,4,22,4,227,175,202,111,118,80,86,5,71,240,229,248,252,165,218,207,117,145,154,92,14,211,77,230,21,73,109,166,121,41,100,42,5,118,80,123,97,248,199,73,130,110,115,182,224,36,249,78,248,132,55,215,147,150,81,138,217,90,157,188,96,165,149,173,218,14,67,114,15,233,138,198,127,114,176,79,166,162,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSendNotificationMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("fbcee102-b801-4c9b-aa3e-2d71377e6308"),
				Name = "SendNotification",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,143,193,10,194,48,12,134,207,14,246,14,101,167,14,100,47,48,29,200,152,210,139,23,217,73,60,212,153,73,97,166,144,102,138,136,239,110,139,167,181,167,64,242,243,125,127,212,209,178,25,205,160,217,88,84,56,90,129,241,98,43,14,192,113,76,150,117,158,169,14,231,7,144,190,78,176,81,113,162,73,72,206,163,16,94,231,139,248,196,167,175,167,197,128,158,205,100,216,128,171,188,191,119,64,78,18,140,41,117,45,194,177,181,136,48,132,101,104,246,212,180,8,158,0,111,64,222,223,78,218,185,189,30,216,210,59,112,151,189,255,177,70,230,217,202,23,21,158,233,152,230,16,222,209,221,191,138,44,139,121,33,43,18,123,208,167,234,42,12,153,116,47,235,31,251,143,218,159,129,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetPopupBodyMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("636a671d-90d9-4e14-b74d-747297fdedaf"),
				Name = "GetPopupBody",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("99869584-c42c-4baf-b01a-2c873583e9f6"),
				Name = "referenceEntity",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,143,203,10,194,64,12,69,215,206,87,12,226,162,133,210,31,24,220,248,2,55,42,40,186,142,53,181,3,243,34,147,17,138,248,239,150,209,133,138,219,220,115,146,220,200,164,221,85,198,166,67,11,115,8,172,189,147,83,73,216,34,161,107,112,233,88,115,95,239,115,94,191,1,37,110,64,242,162,99,48,208,31,193,36,252,163,236,72,91,160,126,241,162,230,222,36,235,50,171,132,110,101,241,105,215,235,184,241,188,73,198,108,233,212,105,198,125,128,6,139,178,148,119,49,250,57,51,25,87,242,254,57,123,140,149,120,228,135,206,254,210,15,68,204,149,234,149,39,11,92,236,124,72,97,54,36,11,108,33,25,62,160,29,84,198,234,187,115,245,85,167,84,130,144,19,185,188,83,61,1,143,156,162,72,37,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetFetchedReferenceEntityMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("aa80b355-0921-4c1c-909c-554dacba6a81"),
				Name = "GetFetchedReferenceEntity",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				ResultValueTypeName = "Entity"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,83,79,111,130,48,20,63,195,167,232,56,24,72,76,191,128,195,131,58,141,7,183,69,167,151,197,67,83,30,147,164,20,211,22,23,98,252,238,107,105,137,192,88,150,108,23,18,30,143,223,191,247,222,133,8,36,43,185,41,146,146,193,33,147,100,71,79,144,19,20,163,189,4,49,47,56,7,170,178,130,227,39,174,50,85,217,175,27,194,201,7,8,188,204,120,178,230,82,17,78,97,86,61,147,28,194,96,215,6,11,162,137,111,127,236,146,184,90,60,68,141,231,2,136,2,219,18,118,85,104,184,139,22,76,11,86,230,220,240,105,136,96,67,164,50,77,166,182,95,39,65,67,105,225,108,29,9,72,65,128,214,105,223,135,122,244,147,89,26,71,32,53,186,109,195,141,52,91,159,248,89,138,194,1,71,120,9,138,158,150,162,200,23,179,48,184,123,50,178,198,61,44,93,27,35,14,159,239,71,116,109,59,186,69,17,186,250,158,241,153,119,157,245,243,114,120,43,80,111,213,25,18,219,119,32,172,132,199,85,153,37,211,240,142,170,131,243,122,17,104,52,103,83,207,81,72,245,34,22,144,146,146,169,144,162,120,138,40,174,25,227,190,8,141,116,67,192,36,52,34,161,86,225,134,209,177,104,106,120,11,103,70,40,216,52,116,8,65,240,23,45,219,166,223,173,231,67,140,120,201,24,26,141,124,207,251,246,25,91,53,113,75,155,145,93,79,173,207,236,144,162,174,157,127,94,65,143,100,80,159,137,193,221,1,52,231,208,38,255,229,14,60,104,109,220,171,200,114,34,170,53,79,139,102,249,218,27,247,243,134,244,133,182,58,106,141,118,86,170,20,220,105,51,49,186,130,137,109,242,5,91,178,109,164,64,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreatePublishClientVisaInfoMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b82dd379-d4be-4c8b-80b2-69eaaa6f9d3f"),
				Name = "PublishClientVisaInfo",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("13ac9a17-c248-42aa-b48b-0fe3633d82db"),
				Name = "visaOwnerId",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("20ca17a1-2893-4922-bd31-1e056304d663"),
				Name = "operation",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,82,93,79,195,48,12,124,46,18,255,33,226,169,149,80,254,0,31,210,152,96,20,49,64,148,241,30,106,111,51,106,157,41,73,135,10,226,191,227,180,213,88,97,143,57,251,206,231,115,182,198,41,3,53,241,130,41,228,224,213,133,98,252,80,247,228,195,249,172,33,184,76,179,179,227,163,173,116,249,214,79,118,141,60,115,182,217,72,243,12,67,177,87,240,67,37,221,146,55,143,31,140,46,135,76,191,216,168,215,41,209,82,165,7,148,244,132,219,52,203,212,215,241,81,178,111,71,79,0,158,13,175,240,16,41,234,125,43,172,60,30,228,141,60,196,214,126,143,218,176,89,161,19,239,115,191,154,174,13,51,86,243,30,211,57,251,96,184,196,97,229,26,189,23,124,200,36,206,112,88,90,7,57,8,116,205,129,66,171,115,56,21,156,109,160,37,149,38,144,221,69,243,240,23,155,90,145,215,175,226,42,82,236,6,93,87,139,15,25,27,26,255,171,90,116,239,94,155,252,52,122,170,112,127,234,14,147,189,196,237,210,58,52,229,90,165,255,46,5,138,120,116,225,62,228,216,87,246,203,139,234,144,137,190,33,134,60,96,125,213,46,114,24,71,222,69,152,196,243,237,104,18,75,83,85,189,94,82,90,113,198,77,140,46,249,30,6,120,170,55,21,206,71,41,22,35,172,163,94,89,104,165,122,231,45,75,68,91,116,65,23,232,200,84,244,137,143,111,239,88,134,116,184,68,22,243,72,186,248,199,230,226,208,56,121,52,81,223,162,1,217,170,64,134,238,224,39,139,13,152,128,207,40,60,32,94,157,68,202,176,142,126,178,62,12,196,116,36,211,253,157,31,198,186,160,234,40,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateIsFinalStatusMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ff79caad-7087-4d92-aaf7-794a9bc8c040"),
				Name = "IsFinalStatus",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d930cdb3-0838-41d8-8477-3fecde3fa0e4"),
				Name = "statusId",
				CreatedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				ModifiedInSchemaUId = new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,47,205,76,137,142,85,72,203,204,75,204,201,169,12,46,73,44,41,45,78,45,86,176,85,240,203,47,201,76,203,76,78,44,201,204,207,11,45,201,204,201,44,201,76,45,214,115,79,45,113,131,40,13,203,44,78,132,41,215,8,45,78,45,114,206,207,203,75,77,6,41,215,180,230,229,42,74,45,41,45,202,67,55,87,15,168,168,36,49,51,175,88,163,24,44,226,153,162,105,13,0,157,230,40,135,130,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseVisaEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b6f56217-8a0d-48ad-b310-021cd49f651e"));
		}

		#endregion

	}

	#endregion


	#region Class: BaseVisaEventsProcess

	/// <exclude/>
	public class BaseVisaEventsProcess : BaseVisa_NUIEventsProcess
	{

		public BaseVisaEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

