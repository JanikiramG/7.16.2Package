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

	#region Class: OpportunityContact_Opportunity_TerrasoftSchema

	/// <exclude/>
	public class OpportunityContact_Opportunity_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public OpportunityContact_Opportunity_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OpportunityContact_Opportunity_TerrasoftSchema(OpportunityContact_Opportunity_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OpportunityContact_Opportunity_TerrasoftSchema(OpportunityContact_Opportunity_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2");
			RealUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2");
			Name = "OpportunityContact_Opportunity_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("545b14da-ca86-4a72-a58f-5daf3a0bbfd0")) == null) {
				Columns.Add(CreateOpportunityColumn());
			}
			if (Columns.FindByUId(new Guid("a628d3aa-7961-4943-886b-136561ddcc96")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("5c06b2ae-7c74-4fda-8952-b73989325268")) == null) {
				Columns.Add(CreateIsMainContactColumn());
			}
			if (Columns.FindByUId(new Guid("194ac7b8-2f54-4e80-b2c1-549d893f7670")) == null) {
				Columns.Add(CreateRoleColumn());
			}
			if (Columns.FindByUId(new Guid("464956de-fea2-414d-9c41-a61dbd542143")) == null) {
				Columns.Add(CreateInfluenceColumn());
			}
			if (Columns.FindByUId(new Guid("97bbbefb-b020-4887-9b6d-cf385d972a85")) == null) {
				Columns.Add(CreateContactMotivatorColumn());
			}
			if (Columns.FindByUId(new Guid("1d8a938b-f6aa-4459-b848-eb438f52d6b0")) == null) {
				Columns.Add(CreateContactLoyalityColumn());
			}
			if (Columns.FindByUId(new Guid("398febc8-14db-4f88-80f4-485ca96465ff")) == null) {
				Columns.Add(CreateDescriptionColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2");
			column.CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2");
			column.CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2");
			column.CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2");
			column.CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2");
			column.CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2");
			column.CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33");
			return column;
		}

		protected virtual EntitySchemaColumn CreateOpportunityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("545b14da-ca86-4a72-a58f-5daf3a0bbfd0"),
				Name = @"Opportunity",
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"),
				ModifiedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a628d3aa-7961-4943-886b-136561ddcc96"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"),
				ModifiedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected virtual EntitySchemaColumn CreateIsMainContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("5c06b2ae-7c74-4fda-8952-b73989325268"),
				Name = @"IsMainContact",
				CreatedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"),
				ModifiedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected virtual EntitySchemaColumn CreateRoleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("194ac7b8-2f54-4e80-b2c1-549d893f7670"),
				Name = @"Role",
				ReferenceSchemaUId = new Guid("a85932a3-30a5-49d7-9627-7f749a055ab7"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"),
				ModifiedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected virtual EntitySchemaColumn CreateInfluenceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("464956de-fea2-414d-9c41-a61dbd542143"),
				Name = @"Influence",
				ReferenceSchemaUId = new Guid("e0aa5fa2-0910-478d-943b-e9c2579ad7b4"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"),
				ModifiedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected virtual EntitySchemaColumn CreateContactMotivatorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("97bbbefb-b020-4887-9b6d-cf385d972a85"),
				Name = @"ContactMotivator",
				CreatedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"),
				ModifiedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected virtual EntitySchemaColumn CreateContactLoyalityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("1d8a938b-f6aa-4459-b848-eb438f52d6b0"),
				Name = @"ContactLoyality",
				ReferenceSchemaUId = new Guid("90a3e9f6-12d4-45b5-9122-7c4aadb41f28"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"),
				ModifiedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected virtual EntitySchemaColumn CreateDescriptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("398febc8-14db-4f88-80f4-485ca96465ff"),
				Name = @"Description",
				CreatedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"),
				ModifiedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateOpportunityContact_Opportunity_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateOpportunityContact_Opportunity_TerrasoftEventsProcessSchema() {
			var schema = new OpportunityContact_Opportunity_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new OpportunityContact_Opportunity_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OpportunityContact_OpportunityEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OpportunityContact_Opportunity_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OpportunityContact_Opportunity_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"));
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityContact_Opportunity_Terrasoft

	/// <summary>
	/// Contact in opportunity.
	/// </summary>
	public class OpportunityContact_Opportunity_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public OpportunityContact_Opportunity_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OpportunityContact_Opportunity_Terrasoft";
		}

		public OpportunityContact_Opportunity_Terrasoft(OpportunityContact_Opportunity_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid OpportunityId {
			get {
				return GetTypedColumnValue<Guid>("OpportunityId");
			}
			set {
				SetColumnValue("OpportunityId", value);
				_opportunity = null;
			}
		}

		/// <exclude/>
		public string OpportunityTitle {
			get {
				return GetTypedColumnValue<string>("OpportunityTitle");
			}
			set {
				SetColumnValue("OpportunityTitle", value);
				if (_opportunity != null) {
					_opportunity.Title = value;
				}
			}
		}

		private Opportunity _opportunity;
		/// <summary>
		/// Opportunity.
		/// </summary>
		public Opportunity Opportunity {
			get {
				return _opportunity ??
					(_opportunity = LookupColumnEntities.GetEntity("Opportunity") as Opportunity);
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
		/// Primary contact.
		/// </summary>
		public bool IsMainContact {
			get {
				return GetTypedColumnValue<bool>("IsMainContact");
			}
			set {
				SetColumnValue("IsMainContact", value);
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

		private OppContactRole _role;
		/// <summary>
		/// Role.
		/// </summary>
		public OppContactRole Role {
			get {
				return _role ??
					(_role = LookupColumnEntities.GetEntity("Role") as OppContactRole);
			}
		}

		/// <exclude/>
		public Guid InfluenceId {
			get {
				return GetTypedColumnValue<Guid>("InfluenceId");
			}
			set {
				SetColumnValue("InfluenceId", value);
				_influence = null;
			}
		}

		/// <exclude/>
		public string InfluenceName {
			get {
				return GetTypedColumnValue<string>("InfluenceName");
			}
			set {
				SetColumnValue("InfluenceName", value);
				if (_influence != null) {
					_influence.Name = value;
				}
			}
		}

		private OppContactInfluence _influence;
		/// <summary>
		/// Influence.
		/// </summary>
		public OppContactInfluence Influence {
			get {
				return _influence ??
					(_influence = LookupColumnEntities.GetEntity("Influence") as OppContactInfluence);
			}
		}

		/// <summary>
		/// Decision-making factors.
		/// </summary>
		public string ContactMotivator {
			get {
				return GetTypedColumnValue<string>("ContactMotivator");
			}
			set {
				SetColumnValue("ContactMotivator", value);
			}
		}

		/// <exclude/>
		public Guid ContactLoyalityId {
			get {
				return GetTypedColumnValue<Guid>("ContactLoyalityId");
			}
			set {
				SetColumnValue("ContactLoyalityId", value);
				_contactLoyality = null;
			}
		}

		/// <exclude/>
		public string ContactLoyalityName {
			get {
				return GetTypedColumnValue<string>("ContactLoyalityName");
			}
			set {
				SetColumnValue("ContactLoyalityName", value);
				if (_contactLoyality != null) {
					_contactLoyality.Name = value;
				}
			}
		}

		private OppContactLoyality _contactLoyality;
		/// <summary>
		/// Loyalty.
		/// </summary>
		public OppContactLoyality ContactLoyality {
			get {
				return _contactLoyality ??
					(_contactLoyality = LookupColumnEntities.GetEntity("ContactLoyality") as OppContactLoyality);
			}
		}

		/// <summary>
		/// Description.
		/// </summary>
		public string Description {
			get {
				return GetTypedColumnValue<string>("Description");
			}
			set {
				SetColumnValue("Description", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OpportunityContact_OpportunityEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("OpportunityContact_Opportunity_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("OpportunityContact_Opportunity_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("OpportunityContact_Opportunity_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("OpportunityContact_Opportunity_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("OpportunityContact_Opportunity_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OpportunityContact_Opportunity_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityContact_OpportunityEventsProcess

	/// <exclude/>
	public partial class OpportunityContact_OpportunityEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : OpportunityContact_Opportunity_Terrasoft
	{

		public OpportunityContact_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpportunityContact_OpportunityEventsProcess";
			SchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2");
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
					SchemaElementUId = new Guid("efd04b81-7add-47cf-9e96-3c955826b02a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageOpportunityContactSaving;
		public ProcessFlowElement StartMessageOpportunityContactSaving {
			get {
				return _startMessageOpportunityContactSaving ?? (_startMessageOpportunityContactSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageOpportunityContactSaving",
					SchemaElementUId = new Guid("5c9b116b-ee58-42d3-a3bf-e5dafe70b539"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptOpportunityContactSaving;
		public ProcessScriptTask ScriptOpportunityContactSaving {
			get {
				return _scriptOpportunityContactSaving ?? (_scriptOpportunityContactSaving = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptOpportunityContactSaving",
					SchemaElementUId = new Guid("2811d4d4-b788-4dc8-b353-fa8538be439b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptOpportunityContactSavingExecute,
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
					SchemaElementUId = new Guid("e6b995b5-d3ad-49a3-b1cc-1e7179375166"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _opportunityContactSaved;
		public ProcessFlowElement OpportunityContactSaved {
			get {
				return _opportunityContactSaved ?? (_opportunityContactSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OpportunityContactSaved",
					SchemaElementUId = new Guid("d112f396-bd6c-4757-8f0c-09f6c22f9ae0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _updateRemindings;
		public ProcessScriptTask UpdateRemindings {
			get {
				return _updateRemindings ?? (_updateRemindings = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "UpdateRemindings",
					SchemaElementUId = new Guid("3f9a2eb3-b79e-4ffb-bf95-203818f9e310"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = UpdateRemindingsExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessageOpportunityContactSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageOpportunityContactSaving };
			FlowElements[ScriptOpportunityContactSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptOpportunityContactSaving };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[OpportunityContactSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { OpportunityContactSaved };
			FlowElements[UpdateRemindings.SchemaElementUId] = new Collection<ProcessFlowElement> { UpdateRemindings };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "StartMessageOpportunityContactSaving":
						e.Context.QueueTasks.Enqueue("ScriptOpportunityContactSaving");
						break;
					case "ScriptOpportunityContactSaving":
						break;
					case "EventSubProcess2":
						break;
					case "OpportunityContactSaved":
						e.Context.QueueTasks.Enqueue("UpdateRemindings");
						break;
					case "UpdateRemindings":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessageOpportunityContactSaving");
			ActivatedEventElements.Add("OpportunityContactSaved");
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
				case "StartMessageOpportunityContactSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageOpportunityContactSaving";
					result = StartMessageOpportunityContactSaving.Execute(context);
					break;
				case "ScriptOpportunityContactSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptOpportunityContactSaving";
					result = ScriptOpportunityContactSaving.Execute(context, ScriptOpportunityContactSavingExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "OpportunityContactSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpportunityContactSaved";
					result = OpportunityContactSaved.Execute(context);
					break;
				case "UpdateRemindings":
					context.QueueTasks.Dequeue();
					context.SenderName = "UpdateRemindings";
					result = UpdateRemindings.Execute(context, UpdateRemindingsExecute);
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

		public virtual bool ScriptOpportunityContactSavingExecute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool UpdateRemindingsExecute(ProcessExecutingContext context) {
			Guid id = Entity.GetTypedColumnValue<Guid>("OpportunityId");
			OpportunityAnniversaryReminding remindingsGenerator = new OpportunityAnniversaryReminding(UserConnection, id);
			remindingsGenerator.GenerateActualRemindings();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "OpportunityContact_Opportunity_TerrasoftSaving":
							if (ActivatedEventElements.Contains("StartMessageOpportunityContactSaving")) {
							context.QueueTasks.Enqueue("StartMessageOpportunityContactSaving");
						}
						break;
					case "OpportunityContact_Opportunity_TerrasoftSaved":
							if (ActivatedEventElements.Contains("OpportunityContactSaved")) {
							context.QueueTasks.Enqueue("OpportunityContactSaved");
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

	#region Class: OpportunityContact_OpportunityEventsProcess

	/// <exclude/>
	public class OpportunityContact_OpportunityEventsProcess : OpportunityContact_OpportunityEventsProcess<OpportunityContact_Opportunity_Terrasoft>
	{

		public OpportunityContact_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OpportunityContact_OpportunityEventsProcess

	public partial class OpportunityContact_OpportunityEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: OpportunityContact_Opportunity_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class OpportunityContact_Opportunity_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public OpportunityContact_Opportunity_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public OpportunityContact_Opportunity_TerrasoftEventsProcessSchema(OpportunityContact_Opportunity_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "OpportunityContact_OpportunityEventsProcess";
			UId = new Guid("8b0b51c2-c1df-42b8-8ba8-7d555e5d07fd");
			CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33");
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
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaStartMessageEvent startmessageopportunitycontactsaving = CreateStartMessageOpportunityContactSavingStartMessageEvent();
			eventsubprocess1.FlowElements.Add(startmessageopportunitycontactsaving);
			ProcessSchemaScriptTask scriptopportunitycontactsaving = CreateScriptOpportunityContactSavingScriptTask();
			eventsubprocess1.FlowElements.Add(scriptopportunitycontactsaving);
			ProcessSchemaStartMessageEvent opportunitycontactsaved = CreateOpportunityContactSavedStartMessageEvent();
			eventsubprocess2.FlowElements.Add(opportunitycontactsaved);
			ProcessSchemaScriptTask updateremindings = CreateUpdateRemindingsScriptTask();
			eventsubprocess2.FlowElements.Add(updateremindings);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("19ec1f13-3b5c-4887-8201-e7e3e7ed1fde"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("3ac2053e-84cb-463e-bb9d-eb4781e31c4f"),
				CreatedInSchemaUId = new Guid("8b0b51c2-c1df-42b8-8ba8-7d555e5d07fd"),
				CurveCenterPosition = new Point(232, 158),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8b0b51c2-c1df-42b8-8ba8-7d555e5d07fd"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5c9b116b-ee58-42d3-a3bf-e5dafe70b539"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2811d4d4-b788-4dc8-b353-fa8538be439b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("3cb86380-089e-43ea-9c66-d08a6701da13"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13"),
				CreatedInSchemaUId = new Guid("8b0b51c2-c1df-42b8-8ba8-7d555e5d07fd"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8b0b51c2-c1df-42b8-8ba8-7d555e5d07fd"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d112f396-bd6c-4757-8f0c-09f6c22f9ae0"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3f9a2eb3-b79e-4ffb-bf95-203818f9e310"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("6f29cf4a-1779-4511-a82a-a451428e41d0"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("3ac2053e-84cb-463e-bb9d-eb4781e31c4f"),
				CreatedInSchemaUId = new Guid("8b0b51c2-c1df-42b8-8ba8-7d555e5d07fd"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("8b0b51c2-c1df-42b8-8ba8-7d555e5d07fd"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1130, 514),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("a1c56191-9cba-47b1-8a94-9cb03c806353"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("6f29cf4a-1779-4511-a82a-a451428e41d0"),
				CreatedInOwnerSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"),
				CreatedInPackageId = new Guid("3ac2053e-84cb-463e-bb9d-eb4781e31c4f"),
				CreatedInSchemaUId = new Guid("8b0b51c2-c1df-42b8-8ba8-7d555e5d07fd"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("8b0b51c2-c1df-42b8-8ba8-7d555e5d07fd"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1101, 514),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("efd04b81-7add-47cf-9e96-3c955826b02a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a1c56191-9cba-47b1-8a94-9cb03c806353"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("3ac2053e-84cb-463e-bb9d-eb4781e31c4f"),
				CreatedInSchemaUId = new Guid("8b0b51c2-c1df-42b8-8ba8-7d555e5d07fd"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("8b0b51c2-c1df-42b8-8ba8-7d555e5d07fd"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(35, 20),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(1008, 462),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageOpportunityContactSavingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5c9b116b-ee58-42d3-a3bf-e5dafe70b539"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("efd04b81-7add-47cf-9e96-3c955826b02a"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("3ac2053e-84cb-463e-bb9d-eb4781e31c4f"),
				CreatedInSchemaUId = new Guid("8b0b51c2-c1df-42b8-8ba8-7d555e5d07fd"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OpportunityContactSaving",
				ModifiedInSchemaUId = new Guid("8b0b51c2-c1df-42b8-8ba8-7d555e5d07fd"),
				Name = @"StartMessageOpportunityContactSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(50, 121),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptOpportunityContactSavingScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2811d4d4-b788-4dc8-b353-fa8538be439b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("efd04b81-7add-47cf-9e96-3c955826b02a"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("3ac2053e-84cb-463e-bb9d-eb4781e31c4f"),
				CreatedInSchemaUId = new Guid("8b0b51c2-c1df-42b8-8ba8-7d555e5d07fd"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("8b0b51c2-c1df-42b8-8ba8-7d555e5d07fd"),
				Name = @"ScriptOpportunityContactSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(246, 107),
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
				UId = new Guid("e6b995b5-d3ad-49a3-b1cc-1e7179375166"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a1c56191-9cba-47b1-8a94-9cb03c806353"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13"),
				CreatedInSchemaUId = new Guid("8b0b51c2-c1df-42b8-8ba8-7d555e5d07fd"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("8b0b51c2-c1df-42b8-8ba8-7d555e5d07fd"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(22, 497),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(300, 300),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOpportunityContactSavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d112f396-bd6c-4757-8f0c-09f6c22f9ae0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6b995b5-d3ad-49a3-b1cc-1e7179375166"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13"),
				CreatedInSchemaUId = new Guid("8b0b51c2-c1df-42b8-8ba8-7d555e5d07fd"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OpportunityContactSaved",
				ModifiedInSchemaUId = new Guid("8b0b51c2-c1df-42b8-8ba8-7d555e5d07fd"),
				Name = @"OpportunityContactSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(27, 141),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateUpdateRemindingsScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3f9a2eb3-b79e-4ffb-bf95-203818f9e310"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6b995b5-d3ad-49a3-b1cc-1e7179375166"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13"),
				CreatedInSchemaUId = new Guid("8b0b51c2-c1df-42b8-8ba8-7d555e5d07fd"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("8b0b51c2-c1df-42b8-8ba8-7d555e5d07fd"),
				Name = @"UpdateRemindings",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(157, 134),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,78,203,10,194,48,16,188,11,254,67,232,169,130,244,7,170,66,41,18,60,9,162,222,67,179,72,160,157,148,205,174,210,191,55,226,3,15,130,48,135,97,152,151,213,224,77,198,218,108,33,65,166,202,146,28,167,145,124,27,123,29,112,118,189,210,202,102,211,166,44,246,227,24,89,20,217,182,243,197,162,158,207,190,148,6,8,87,226,228,120,58,208,16,224,3,46,134,223,44,89,2,177,147,200,121,9,116,51,127,146,229,41,17,183,17,160,78,66,196,50,95,124,236,253,232,171,94,140,154,78,212,245,159,134,84,62,3,162,12,35,172,84,223,1,98,60,193,223,235,0,0,0 }
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
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
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
			return new OpportunityContact_Opportunity_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8b0b51c2-c1df-42b8-8ba8-7d555e5d07fd"));
		}

		#endregion

	}

	#endregion

}

