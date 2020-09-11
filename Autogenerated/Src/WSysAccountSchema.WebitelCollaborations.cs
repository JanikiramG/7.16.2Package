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

	#region Class: WSysAccountSchema

	/// <exclude/>
	public class WSysAccountSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public WSysAccountSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public WSysAccountSchema(WSysAccountSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public WSysAccountSchema(WSysAccountSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("38dbbdd4-9ab4-473a-bb99-9ca8f830163f");
			RealUId = new Guid("38dbbdd4-9ab4-473a-bb99-9ca8f830163f");
			Name = "WSysAccount";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("1303b630-da63-4ee7-9918-95b9adb4dd98");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateLoginColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("5a46f90b-3674-4bce-9082-6ce7149dc68d")) == null) {
				Columns.Add(CreateNameColumn());
			}
			if (Columns.FindByUId(new Guid("40d78b2e-4f84-44ec-881b-65810e36828f")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("f51b1d57-00db-4894-b35d-a179c630589d")) == null) {
				Columns.Add(CreatePasswordColumn());
			}
			if (Columns.FindByUId(new Guid("9af38cca-2a03-413f-9a6f-a802cda16b73")) == null) {
				Columns.Add(CreateRoleColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("38dbbdd4-9ab4-473a-bb99-9ca8f830163f");
			column.CreatedInPackageId = new Guid("1303b630-da63-4ee7-9918-95b9adb4dd98");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("38dbbdd4-9ab4-473a-bb99-9ca8f830163f");
			column.CreatedInPackageId = new Guid("1303b630-da63-4ee7-9918-95b9adb4dd98");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("38dbbdd4-9ab4-473a-bb99-9ca8f830163f");
			column.CreatedInPackageId = new Guid("1303b630-da63-4ee7-9918-95b9adb4dd98");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("38dbbdd4-9ab4-473a-bb99-9ca8f830163f");
			column.CreatedInPackageId = new Guid("1303b630-da63-4ee7-9918-95b9adb4dd98");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("38dbbdd4-9ab4-473a-bb99-9ca8f830163f");
			column.CreatedInPackageId = new Guid("1303b630-da63-4ee7-9918-95b9adb4dd98");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("38dbbdd4-9ab4-473a-bb99-9ca8f830163f");
			column.CreatedInPackageId = new Guid("1303b630-da63-4ee7-9918-95b9adb4dd98");
			return column;
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("5a46f90b-3674-4bce-9082-6ce7149dc68d"),
				Name = @"Name",
				CreatedInSchemaUId = new Guid("38dbbdd4-9ab4-473a-bb99-9ca8f830163f"),
				ModifiedInSchemaUId = new Guid("38dbbdd4-9ab4-473a-bb99-9ca8f830163f"),
				CreatedInPackageId = new Guid("1303b630-da63-4ee7-9918-95b9adb4dd98"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("40d78b2e-4f84-44ec-881b-65810e36828f"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("38dbbdd4-9ab4-473a-bb99-9ca8f830163f"),
				ModifiedInSchemaUId = new Guid("38dbbdd4-9ab4-473a-bb99-9ca8f830163f"),
				CreatedInPackageId = new Guid("1303b630-da63-4ee7-9918-95b9adb4dd98")
			};
		}

		protected virtual EntitySchemaColumn CreateLoginColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("ffcce46c-8ef0-48ff-a470-383898b51f25"),
				Name = @"Login",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("38dbbdd4-9ab4-473a-bb99-9ca8f830163f"),
				ModifiedInSchemaUId = new Guid("38dbbdd4-9ab4-473a-bb99-9ca8f830163f"),
				CreatedInPackageId = new Guid("1303b630-da63-4ee7-9918-95b9adb4dd98")
			};
		}

		protected virtual EntitySchemaColumn CreatePasswordColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("f51b1d57-00db-4894-b35d-a179c630589d"),
				Name = @"Password",
				IsValueCloneable = false,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("38dbbdd4-9ab4-473a-bb99-9ca8f830163f"),
				ModifiedInSchemaUId = new Guid("38dbbdd4-9ab4-473a-bb99-9ca8f830163f"),
				CreatedInPackageId = new Guid("1303b630-da63-4ee7-9918-95b9adb4dd98")
			};
		}

		protected virtual EntitySchemaColumn CreateRoleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("9af38cca-2a03-413f-9a6f-a802cda16b73"),
				Name = @"Role",
				ReferenceSchemaUId = new Guid("3367e5f9-0903-4702-8444-537f67ee2fc9"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("38dbbdd4-9ab4-473a-bb99-9ca8f830163f"),
				ModifiedInSchemaUId = new Guid("38dbbdd4-9ab4-473a-bb99-9ca8f830163f"),
				CreatedInPackageId = new Guid("1303b630-da63-4ee7-9918-95b9adb4dd98")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateWSysAccountEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateWSysAccountEventsProcessSchema() {
			var schema = new WSysAccountEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new WSysAccount(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new WSysAccount_WebitelCollaborationsEventsProcess(userConnection);
		}

		public override object Clone() {
			return new WSysAccountSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new WSysAccountSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("38dbbdd4-9ab4-473a-bb99-9ca8f830163f"));
		}

		#endregion

	}

	#endregion

	#region Class: WSysAccount

	/// <summary>
	/// Webitel users.
	/// </summary>
	public class WSysAccount : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public WSysAccount(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "WSysAccount";
		}

		public WSysAccount(WSysAccount source)
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

		/// <summary>
		/// User login.
		/// </summary>
		public string Login {
			get {
				return GetTypedColumnValue<string>("Login");
			}
			set {
				SetColumnValue("Login", value);
			}
		}

		/// <summary>
		/// Password.
		/// </summary>
		public string Password {
			get {
				return GetTypedColumnValue<string>("Password");
			}
			set {
				SetColumnValue("Password", value);
			}
		}

		/// <exclude/>
		public Guid RoleId {
			get {
				return GetTypedColumnValue<Guid>("RoleId");
			}
			set {
				SetColumnValue("RoleId", value);
				_role = null;
			}
		}

		/// <exclude/>
		public string RoleName {
			get {
				return GetTypedColumnValue<string>("RoleName");
			}
			set {
				SetColumnValue("RoleName", value);
				if (_role != null) {
					_role.Name = value;
				}
			}
		}

		private WSysAccountRole _role;
		/// <summary>
		/// Role.
		/// </summary>
		public WSysAccountRole Role {
			get {
				return _role ??
					(_role = LookupColumnEntities.GetEntity("Role") as WSysAccountRole);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new WSysAccount_WebitelCollaborationsEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("WSysAccountDeleted", e);
			Inserting += (s, e) => ThrowEvent("WSysAccountInserting", e);
			Validating += (s, e) => ThrowEvent("WSysAccountValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new WSysAccount(this);
		}

		#endregion

	}

	#endregion

	#region Class: WSysAccount_WebitelCollaborationsEventsProcess

	/// <exclude/>
	public partial class WSysAccount_WebitelCollaborationsEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : WSysAccount
	{

		public WSysAccount_WebitelCollaborationsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "WSysAccount_WebitelCollaborationsEventsProcess";
			SchemaUId = new Guid("38dbbdd4-9ab4-473a-bb99-9ca8f830163f");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("38dbbdd4-9ab4-473a-bb99-9ca8f830163f");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual bool AllowSave {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess1;
		public ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("5ca1ba77-79ca-4eae-8d0d-affddad05d94"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _entitySavingStartMessage;
		public ProcessFlowElement EntitySavingStartMessage {
			get {
				return _entitySavingStartMessage ?? (_entitySavingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "EntitySavingStartMessage",
					SchemaElementUId = new Guid("e3ba08f2-a1dd-4adc-b7d5-a87c3ed82662"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask1;
		public ProcessScriptTask ScriptTask1 {
			get {
				return _scriptTask1 ?? (_scriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask1",
					SchemaElementUId = new Guid("73275ff0-3f99-4174-8d40-fc1607417ccc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
				});
			}
		}

		private ProcessThrowMessageEvent _entitySaving;
		public ProcessThrowMessageEvent EntitySaving {
			get {
				return _entitySaving ?? (_entitySaving = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "EntitySaving",
					SchemaElementUId = new Guid("8d9a7781-8407-4cfb-bb41-08e47cc31023"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "BaseEntitySaving",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("034e9f2b-0708-4ccd-8565-01221fe4983f"),
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
					SchemaElementUId = new Guid("81cbae76-fcb4-40be-92b9-50d6fcde12b6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow2;
		public ProcessConditionalFlow ConditionalFlow2 {
			get {
				return _conditionalFlow2 ?? (_conditionalFlow2 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow2",
					SchemaElementUId = new Guid("fe898e09-11b3-492d-999f-de4c103987ac"),
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
			FlowElements[EntitySavingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EntitySavingStartMessage };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[EntitySaving.SchemaElementUId] = new Collection<ProcessFlowElement> { EntitySaving };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "EntitySavingStartMessage":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "ScriptTask1":
						if (ConditionalFlow1ExpressionExecute()) {
						e.Context.QueueTasks.Enqueue("EntitySaving");
							break;
						}
						if (ConditionalFlow2ExpressionExecute()) {
						e.Context.QueueTasks.Enqueue("Terminate1");
							break;
						}
						break;
					case "EntitySaving":
						break;
					case "Terminate1":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalFlow1ExpressionExecute() {
			return Convert.ToBoolean(AllowSave);
		}

		private bool ConditionalFlow2ExpressionExecute() {
			return Convert.ToBoolean(!AllowSave);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("EntitySavingStartMessage");
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
				case "EntitySavingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "EntitySavingStartMessage";
					result = EntitySavingStartMessage.Execute(context);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
					break;
				case "EntitySaving":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "BaseEntitySaving");
					result = EntitySaving.Execute(context);
					break;
				case "Terminate1":
					context.QueueTasks.Dequeue();
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
				case "AllowSave":
					AllowSave = reader.GetValue<System.Boolean>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
				Guid ContactId = Entity.GetTypedColumnValue<Guid>("ContactId");
				Guid curentId = Entity.GetTypedColumnValue<Guid>("Id");
				string Login = Entity.GetTypedColumnValue<string>("Login");
				
			
				Select select = new Select(UserConnection)
					.Column(Func.Count(Column.Asterisk()))
					.From("WSysAccount").As("d")
					.Where("d", "Id").IsNotEqual(Column.Parameter(curentId))
					.And()
					.OpenBlock("d", "Login").IsEqual(Column.Parameter(Login))
					.Or("d", "ContactId").IsEqual(Column.Parameter(ContactId))
					.CloseBlock()
					as Select;
			AllowSave = (select.ExecuteScalar<int>() == 0);
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "BaseEntitySaving":
							if (ActivatedEventElements.Contains("EntitySavingStartMessage")) {
							context.QueueTasks.Enqueue("EntitySavingStartMessage");
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
			if (!HasMapping("AllowSave") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("AllowSave", AllowSave, false);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: WSysAccount_WebitelCollaborationsEventsProcess

	/// <exclude/>
	public class WSysAccount_WebitelCollaborationsEventsProcess : WSysAccount_WebitelCollaborationsEventsProcess<WSysAccount>
	{

		public WSysAccount_WebitelCollaborationsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: WSysAccount_WebitelCollaborationsEventsProcess

	public partial class WSysAccount_WebitelCollaborationsEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: WSysAccountEventsProcessSchema

	/// <exclude/>
	public class WSysAccountEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public WSysAccountEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public WSysAccountEventsProcessSchema(WSysAccountEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "WSysAccount_WebitelCollaborationsEventsProcess";
			UId = new Guid("4171eb8d-8f64-4367-8eac-e9c0af455558");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
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

		protected virtual ProcessSchemaParameter CreateAllowSaveParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6c7a7e37-bcaf-476e-8f4d-988443b374a2"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4171eb8d-8f64-4367-8eac-e9c0af455558"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4171eb8d-8f64-4367-8eac-e9c0af455558"),
				Name = @"AllowSave",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateAllowSaveParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaStartMessageEvent entitysavingstartmessage = CreateEntitySavingStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(entitysavingstartmessage);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			eventsubprocess1.FlowElements.Add(scripttask1);
			ProcessSchemaIntermediateThrowMessageEvent entitysaving = CreateEntitySavingIntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(entitysaving);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			eventsubprocess1.FlowElements.Add(terminate1);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateConditionalFlow2ConditionalFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("3a072653-5207-49eb-b709-6876f0212120"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("1303b630-da63-4ee7-9918-95b9adb4dd98"),
				CreatedInSchemaUId = new Guid("4171eb8d-8f64-4367-8eac-e9c0af455558"),
				CurveCenterPosition = new Point(168, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4171eb8d-8f64-4367-8eac-e9c0af455558"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e3ba08f2-a1dd-4adc-b7d5-a87c3ed82662"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("73275ff0-3f99-4174-8d40-fc1607417ccc"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("81cbae76-fcb4-40be-92b9-50d6fcde12b6"),
				ConditionExpression = @"AllowSave",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("1303b630-da63-4ee7-9918-95b9adb4dd98"),
				CreatedInSchemaUId = new Guid("4171eb8d-8f64-4367-8eac-e9c0af455558"),
				CurveCenterPosition = new Point(341, 62),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("4171eb8d-8f64-4367-8eac-e9c0af455558"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("73275ff0-3f99-4174-8d40-fc1607417ccc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8d9a7781-8407-4cfb-bb41-08e47cc31023"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow2",
				UId = new Guid("fe898e09-11b3-492d-999f-de4c103987ac"),
				ConditionExpression = @"!AllowSave",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("1303b630-da63-4ee7-9918-95b9adb4dd98"),
				CreatedInSchemaUId = new Guid("4171eb8d-8f64-4367-8eac-e9c0af455558"),
				CurveCenterPosition = new Point(338, 104),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("4171eb8d-8f64-4367-8eac-e9c0af455558"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("73275ff0-3f99-4174-8d40-fc1607417ccc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("034e9f2b-0708-4ccd-8565-01221fe4983f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("34dc944c-d764-4169-b077-9cc1ab34bd13"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("1303b630-da63-4ee7-9918-95b9adb4dd98"),
				CreatedInSchemaUId = new Guid("4171eb8d-8f64-4367-8eac-e9c0af455558"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("4171eb8d-8f64-4367-8eac-e9c0af455558"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(792, 177),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("138aa4c3-f1d1-4a3c-bc66-f24366468680"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("34dc944c-d764-4169-b077-9cc1ab34bd13"),
				CreatedInOwnerSchemaUId = new Guid("38dbbdd4-9ab4-473a-bb99-9ca8f830163f"),
				CreatedInPackageId = new Guid("1303b630-da63-4ee7-9918-95b9adb4dd98"),
				CreatedInSchemaUId = new Guid("4171eb8d-8f64-4367-8eac-e9c0af455558"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("4171eb8d-8f64-4367-8eac-e9c0af455558"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(763, 177),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5ca1ba77-79ca-4eae-8d0d-affddad05d94"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("138aa4c3-f1d1-4a3c-bc66-f24366468680"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("1303b630-da63-4ee7-9918-95b9adb4dd98"),
				CreatedInSchemaUId = new Guid("4171eb8d-8f64-4367-8eac-e9c0af455558"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("4171eb8d-8f64-4367-8eac-e9c0af455558"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(28, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(481, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateEntitySavingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e3ba08f2-a1dd-4adc-b7d5-a87c3ed82662"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5ca1ba77-79ca-4eae-8d0d-affddad05d94"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("1303b630-da63-4ee7-9918-95b9adb4dd98"),
				CreatedInSchemaUId = new Guid("4171eb8d-8f64-4367-8eac-e9c0af455558"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"BaseEntitySaving",
				ModifiedInSchemaUId = new Guid("4171eb8d-8f64-4367-8eac-e9c0af455558"),
				Name = @"EntitySavingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(28, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("73275ff0-3f99-4174-8d40-fc1607417ccc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5ca1ba77-79ca-4eae-8d0d-affddad05d94"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("1303b630-da63-4ee7-9918-95b9adb4dd98"),
				CreatedInSchemaUId = new Guid("4171eb8d-8f64-4367-8eac-e9c0af455558"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("4171eb8d-8f64-4367-8eac-e9c0af455558"),
				Name = @"ScriptTask1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(154, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,145,81,107,194,48,16,199,159,43,248,29,66,159,82,24,101,239,90,161,43,42,194,152,131,110,243,57,164,135,11,198,139,75,46,115,253,246,75,155,40,123,113,248,210,94,174,191,255,175,201,37,91,123,213,177,198,32,9,73,155,142,85,108,137,164,168,47,215,64,111,253,9,186,198,104,127,196,15,161,61,204,7,118,193,243,43,157,23,179,233,36,27,13,210,91,192,123,5,151,164,35,171,112,207,158,205,94,225,255,193,72,134,232,200,198,244,116,18,30,45,104,144,196,92,124,85,12,225,204,98,143,191,59,176,97,171,24,106,101,176,8,112,86,70,39,95,121,148,161,246,72,60,118,202,218,17,88,229,14,188,40,34,185,178,230,200,243,93,219,187,90,202,129,204,139,0,241,60,108,125,252,190,251,4,11,195,242,129,141,231,41,55,238,197,208,242,203,11,125,113,190,10,43,142,16,188,252,50,157,228,174,177,227,177,218,158,0,159,180,145,135,100,74,199,11,178,27,166,17,72,154,173,77,169,63,23,114,59,121,133,82,186,209,198,65,252,247,216,16,46,13,46,204,182,214,218,156,91,241,13,97,162,60,206,182,92,254,128,244,4,173,20,90,216,185,66,90,240,130,85,21,123,28,46,195,2,121,139,140,172,135,217,47,49,146,121,193,83,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateEntitySavingIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("8d9a7781-8407-4cfb-bb41-08e47cc31023"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5ca1ba77-79ca-4eae-8d0d-affddad05d94"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("1303b630-da63-4ee7-9918-95b9adb4dd98"),
				CreatedInSchemaUId = new Guid("4171eb8d-8f64-4367-8eac-e9c0af455558"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"BaseEntitySaving",
				ModifiedInSchemaUId = new Guid("4171eb8d-8f64-4367-8eac-e9c0af455558"),
				Name = @"EntitySaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(330, 9),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("034e9f2b-0708-4ccd-8565-01221fe4983f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5ca1ba77-79ca-4eae-8d0d-affddad05d94"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("1303b630-da63-4ee7-9918-95b9adb4dd98"),
				CreatedInSchemaUId = new Guid("4171eb8d-8f64-4367-8eac-e9c0af455558"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("4171eb8d-8f64-4367-8eac-e9c0af455558"),
				Name = @"Terminate1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(330, 100),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
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
			return new WSysAccountEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4171eb8d-8f64-4367-8eac-e9c0af455558"));
		}

		#endregion

	}

	#endregion


	#region Class: WSysAccountEventsProcess

	/// <exclude/>
	public class WSysAccountEventsProcess : WSysAccount_WebitelCollaborationsEventsProcess
	{

		public WSysAccountEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

