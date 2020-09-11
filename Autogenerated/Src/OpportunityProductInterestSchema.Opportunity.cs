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

	#region Class: OpportunityProductInterest_Opportunity_TerrasoftSchema

	/// <exclude/>
	public class OpportunityProductInterest_Opportunity_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public OpportunityProductInterest_Opportunity_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OpportunityProductInterest_Opportunity_TerrasoftSchema(OpportunityProductInterest_Opportunity_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OpportunityProductInterest_Opportunity_TerrasoftSchema(OpportunityProductInterest_Opportunity_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860");
			RealUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860");
			Name = "OpportunityProductInterest_Opportunity_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("a95a4e48-7891-4394-bebc-94a52d2c83db")) == null) {
				Columns.Add(CreateOpportunityColumn());
			}
			if (Columns.FindByUId(new Guid("31fb834c-0d66-4272-a002-92f7ee99dcc4")) == null) {
				Columns.Add(CreateProductColumn());
			}
			if (Columns.FindByUId(new Guid("c8aebeb1-1cfa-40e0-9d13-9e5a833a7af8")) == null) {
				Columns.Add(CreateQuantityColumn());
			}
			if (Columns.FindByUId(new Guid("b7a9f0bb-fc54-4767-bb31-e282f72fa1a0")) == null) {
				Columns.Add(CreateOfferDateColumn());
			}
			if (Columns.FindByUId(new Guid("0d863985-10fd-4b5d-9135-c20b1522f626")) == null) {
				Columns.Add(CreateOfferResultColumn());
			}
			if (Columns.FindByUId(new Guid("9b6e7c1d-1407-474b-925a-e50da9f36419")) == null) {
				Columns.Add(CreateCommentColumn());
			}
			if (Columns.FindByUId(new Guid("8b1b514f-1ad8-46af-a324-5a9096a066dc")) == null) {
				Columns.Add(CreatePriceColumn());
			}
			if (Columns.FindByUId(new Guid("329a1823-df3b-4846-a6fb-c5f9fc259993")) == null) {
				Columns.Add(CreateAmountColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateOpportunityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a95a4e48-7891-4394-bebc-94a52d2c83db"),
				Name = @"Opportunity",
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				IsCascade = true,
				CreatedInSchemaUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860"),
				ModifiedInSchemaUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateProductColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("31fb834c-0d66-4272-a002-92f7ee99dcc4"),
				Name = @"Product",
				ReferenceSchemaUId = new Guid("4c7a6ead-4eb8-4fc0-863e-98a664569fed"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860"),
				ModifiedInSchemaUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateQuantityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("c8aebeb1-1cfa-40e0-9d13-9e5a833a7af8"),
				Name = @"Quantity",
				CreatedInSchemaUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860"),
				ModifiedInSchemaUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"1"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateOfferDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("b7a9f0bb-fc54-4767-bb31-e282f72fa1a0"),
				Name = @"OfferDate",
				CreatedInSchemaUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860"),
				ModifiedInSchemaUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentDate")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateOfferResultColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0d863985-10fd-4b5d-9135-c20b1522f626"),
				Name = @"OfferResult",
				ReferenceSchemaUId = new Guid("801a201c-7040-4489-a705-5896b20d2f52"),
				CreatedInSchemaUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860"),
				ModifiedInSchemaUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateCommentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("9b6e7c1d-1407-474b-925a-e50da9f36419"),
				Name = @"Comment",
				CreatedInSchemaUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860"),
				ModifiedInSchemaUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreatePriceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("8b1b514f-1ad8-46af-a324-5a9096a066dc"),
				Name = @"Price",
				CreatedInSchemaUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860"),
				ModifiedInSchemaUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21")
			};
		}

		protected virtual EntitySchemaColumn CreateAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("329a1823-df3b-4846-a6fb-c5f9fc259993"),
				Name = @"Amount",
				CreatedInSchemaUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860"),
				ModifiedInSchemaUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateOpportunityProductInterest_Opportunity_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateOpportunityProductInterest_Opportunity_TerrasoftEventsProcessSchema() {
			var schema = new OpportunityProductInterest_Opportunity_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new OpportunityProductInterest_Opportunity_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OpportunityProductInterest_OpportunityEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OpportunityProductInterest_Opportunity_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OpportunityProductInterest_Opportunity_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860"));
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityProductInterest_Opportunity_Terrasoft

	/// <summary>
	/// Opportunity product.
	/// </summary>
	public class OpportunityProductInterest_Opportunity_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public OpportunityProductInterest_Opportunity_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OpportunityProductInterest_Opportunity_Terrasoft";
		}

		public OpportunityProductInterest_Opportunity_Terrasoft(OpportunityProductInterest_Opportunity_Terrasoft source)
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
		public Guid ProductId {
			get {
				return GetTypedColumnValue<Guid>("ProductId");
			}
			set {
				SetColumnValue("ProductId", value);
				_product = null;
			}
		}

		/// <exclude/>
		public string ProductName {
			get {
				return GetTypedColumnValue<string>("ProductName");
			}
			set {
				SetColumnValue("ProductName", value);
				if (_product != null) {
					_product.Name = value;
				}
			}
		}

		private Product _product;
		/// <summary>
		/// Product.
		/// </summary>
		public Product Product {
			get {
				return _product ??
					(_product = LookupColumnEntities.GetEntity("Product") as Product);
			}
		}

		/// <summary>
		/// Quantity.
		/// </summary>
		public Decimal Quantity {
			get {
				return GetTypedColumnValue<Decimal>("Quantity");
			}
			set {
				SetColumnValue("Quantity", value);
			}
		}

		/// <summary>
		/// Quoted on.
		/// </summary>
		public DateTime OfferDate {
			get {
				return GetTypedColumnValue<DateTime>("OfferDate");
			}
			set {
				SetColumnValue("OfferDate", value);
			}
		}

		/// <exclude/>
		public Guid OfferResultId {
			get {
				return GetTypedColumnValue<Guid>("OfferResultId");
			}
			set {
				SetColumnValue("OfferResultId", value);
				_offerResult = null;
			}
		}

		/// <exclude/>
		public string OfferResultName {
			get {
				return GetTypedColumnValue<string>("OfferResultName");
			}
			set {
				SetColumnValue("OfferResultName", value);
				if (_offerResult != null) {
					_offerResult.Name = value;
				}
			}
		}

		private PropositionResult _offerResult;
		/// <summary>
		/// Interest.
		/// </summary>
		public PropositionResult OfferResult {
			get {
				return _offerResult ??
					(_offerResult = LookupColumnEntities.GetEntity("OfferResult") as PropositionResult);
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
		/// Price.
		/// </summary>
		public Decimal Price {
			get {
				return GetTypedColumnValue<Decimal>("Price");
			}
			set {
				SetColumnValue("Price", value);
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

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OpportunityProductInterest_OpportunityEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("OpportunityProductInterest_Opportunity_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("OpportunityProductInterest_Opportunity_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("OpportunityProductInterest_Opportunity_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("OpportunityProductInterest_Opportunity_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("OpportunityProductInterest_Opportunity_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("OpportunityProductInterest_Opportunity_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("OpportunityProductInterest_Opportunity_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OpportunityProductInterest_Opportunity_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityProductInterest_OpportunityEventsProcess

	/// <exclude/>
	public partial class OpportunityProductInterest_OpportunityEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : OpportunityProductInterest_Opportunity_Terrasoft
	{

		public OpportunityProductInterest_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpportunityProductInterest_OpportunityEventsProcess";
			SchemaUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual Guid OpportunityId {
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
					SchemaElementUId = new Guid("094878a5-9cd7-4342-8c89-cb1841a7cc22"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _calckOpportunityAmountOpportunityProductInterestSaved;
		public ProcessFlowElement CalckOpportunityAmountOpportunityProductInterestSaved {
			get {
				return _calckOpportunityAmountOpportunityProductInterestSaved ?? (_calckOpportunityAmountOpportunityProductInterestSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CalckOpportunityAmountOpportunityProductInterestSaved",
					SchemaElementUId = new Guid("64e54c47-2b33-4472-aceb-ffd60d7b815d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _calckOpportunityAmountIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent CalckOpportunityAmountIntermediateThrowMessageEvent {
			get {
				return _calckOpportunityAmountIntermediateThrowMessageEvent ?? (_calckOpportunityAmountIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "CalckOpportunityAmountIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("86602499-a7e6-40c2-8ee2-57de6f20fb48"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OpportunityProductInterestSaved",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _calckOpportunityAmountAfterSevedScriptTask;
		public ProcessScriptTask CalckOpportunityAmountAfterSevedScriptTask {
			get {
				return _calckOpportunityAmountAfterSevedScriptTask ?? (_calckOpportunityAmountAfterSevedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CalckOpportunityAmountAfterSevedScriptTask",
					SchemaElementUId = new Guid("7ea89087-bafe-48a8-847d-9762ed8ed734"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CalckOpportunityAmountAfterSevedScriptTaskExecute,
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
					SchemaElementUId = new Guid("bb26cd7e-54ac-4d39-a295-3cb3ee9cd070"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _opportunityProductInterestDeletingStartMessage;
		public ProcessFlowElement OpportunityProductInterestDeletingStartMessage {
			get {
				return _opportunityProductInterestDeletingStartMessage ?? (_opportunityProductInterestDeletingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OpportunityProductInterestDeletingStartMessage",
					SchemaElementUId = new Guid("576f1eb3-3ea5-4741-b152-930e2af4a3da"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _opportunityProductInterestDeletingIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent OpportunityProductInterestDeletingIntermediateThrowMessageEvent {
			get {
				return _opportunityProductInterestDeletingIntermediateThrowMessageEvent ?? (_opportunityProductInterestDeletingIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "OpportunityProductInterestDeletingIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("3da1d3c9-a0f4-418c-9d4d-7d256022999b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OpportunityProductInterestDeleting",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _getParamsBeforDeleteScriptTask;
		public ProcessScriptTask GetParamsBeforDeleteScriptTask {
			get {
				return _getParamsBeforDeleteScriptTask ?? (_getParamsBeforDeleteScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "GetParamsBeforDeleteScriptTask",
					SchemaElementUId = new Guid("87244ea0-827c-420f-8d0f-771a27aef1c3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = GetParamsBeforDeleteScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess3;
		public ProcessFlowElement EventSubProcess3 {
			get {
				return _eventSubProcess3 ?? (_eventSubProcess3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3",
					SchemaElementUId = new Guid("fe132501-9c48-48e9-a2c5-c591183965c6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _opportunityProductInterestDeletedStartMessage;
		public ProcessFlowElement OpportunityProductInterestDeletedStartMessage {
			get {
				return _opportunityProductInterestDeletedStartMessage ?? (_opportunityProductInterestDeletedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OpportunityProductInterestDeletedStartMessage",
					SchemaElementUId = new Guid("ea498719-b448-4c10-b1ee-ff9fa45d9312"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _opportunityProductInterestDeletedIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent OpportunityProductInterestDeletedIntermediateThrowMessageEvent {
			get {
				return _opportunityProductInterestDeletedIntermediateThrowMessageEvent ?? (_opportunityProductInterestDeletedIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "OpportunityProductInterestDeletedIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("ee2df171-dafc-4514-922d-8e8a1001784b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OpportunityProductInterestDeleted",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _calckOpportunityAmountAfterDeletedScriptTask;
		public ProcessScriptTask CalckOpportunityAmountAfterDeletedScriptTask {
			get {
				return _calckOpportunityAmountAfterDeletedScriptTask ?? (_calckOpportunityAmountAfterDeletedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CalckOpportunityAmountAfterDeletedScriptTask",
					SchemaElementUId = new Guid("cd4f967e-b9bd-4b6a-afd6-aac170daa6b4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CalckOpportunityAmountAfterDeletedScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[CalckOpportunityAmountOpportunityProductInterestSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { CalckOpportunityAmountOpportunityProductInterestSaved };
			FlowElements[CalckOpportunityAmountIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { CalckOpportunityAmountIntermediateThrowMessageEvent };
			FlowElements[CalckOpportunityAmountAfterSevedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CalckOpportunityAmountAfterSevedScriptTask };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[OpportunityProductInterestDeletingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { OpportunityProductInterestDeletingStartMessage };
			FlowElements[OpportunityProductInterestDeletingIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { OpportunityProductInterestDeletingIntermediateThrowMessageEvent };
			FlowElements[GetParamsBeforDeleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { GetParamsBeforDeleteScriptTask };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[OpportunityProductInterestDeletedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { OpportunityProductInterestDeletedStartMessage };
			FlowElements[OpportunityProductInterestDeletedIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { OpportunityProductInterestDeletedIntermediateThrowMessageEvent };
			FlowElements[CalckOpportunityAmountAfterDeletedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CalckOpportunityAmountAfterDeletedScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "CalckOpportunityAmountOpportunityProductInterestSaved":
						e.Context.QueueTasks.Enqueue("CalckOpportunityAmountAfterSevedScriptTask");
						break;
					case "CalckOpportunityAmountIntermediateThrowMessageEvent":
						break;
					case "CalckOpportunityAmountAfterSevedScriptTask":
						e.Context.QueueTasks.Enqueue("CalckOpportunityAmountIntermediateThrowMessageEvent");
						break;
					case "EventSubProcess2":
						break;
					case "OpportunityProductInterestDeletingStartMessage":
						e.Context.QueueTasks.Enqueue("GetParamsBeforDeleteScriptTask");
						break;
					case "OpportunityProductInterestDeletingIntermediateThrowMessageEvent":
						break;
					case "GetParamsBeforDeleteScriptTask":
						e.Context.QueueTasks.Enqueue("OpportunityProductInterestDeletingIntermediateThrowMessageEvent");
						break;
					case "EventSubProcess3":
						break;
					case "OpportunityProductInterestDeletedStartMessage":
						e.Context.QueueTasks.Enqueue("CalckOpportunityAmountAfterDeletedScriptTask");
						break;
					case "OpportunityProductInterestDeletedIntermediateThrowMessageEvent":
						break;
					case "CalckOpportunityAmountAfterDeletedScriptTask":
						e.Context.QueueTasks.Enqueue("OpportunityProductInterestDeletedIntermediateThrowMessageEvent");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("CalckOpportunityAmountOpportunityProductInterestSaved");
			ActivatedEventElements.Add("OpportunityProductInterestDeletingStartMessage");
			ActivatedEventElements.Add("OpportunityProductInterestDeletedStartMessage");
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
				case "CalckOpportunityAmountOpportunityProductInterestSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "CalckOpportunityAmountOpportunityProductInterestSaved";
					result = CalckOpportunityAmountOpportunityProductInterestSaved.Execute(context);
					break;
				case "CalckOpportunityAmountIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OpportunityProductInterestSaved");
					result = CalckOpportunityAmountIntermediateThrowMessageEvent.Execute(context);
					break;
				case "CalckOpportunityAmountAfterSevedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CalckOpportunityAmountAfterSevedScriptTask";
					result = CalckOpportunityAmountAfterSevedScriptTask.Execute(context, CalckOpportunityAmountAfterSevedScriptTaskExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "OpportunityProductInterestDeletingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpportunityProductInterestDeletingStartMessage";
					result = OpportunityProductInterestDeletingStartMessage.Execute(context);
					break;
				case "OpportunityProductInterestDeletingIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OpportunityProductInterestDeleting");
					result = OpportunityProductInterestDeletingIntermediateThrowMessageEvent.Execute(context);
					break;
				case "GetParamsBeforDeleteScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "GetParamsBeforDeleteScriptTask";
					result = GetParamsBeforDeleteScriptTask.Execute(context, GetParamsBeforDeleteScriptTaskExecute);
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "OpportunityProductInterestDeletedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpportunityProductInterestDeletedStartMessage";
					result = OpportunityProductInterestDeletedStartMessage.Execute(context);
					break;
				case "OpportunityProductInterestDeletedIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OpportunityProductInterestDeleted");
					result = OpportunityProductInterestDeletedIntermediateThrowMessageEvent.Execute(context);
					break;
				case "CalckOpportunityAmountAfterDeletedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CalckOpportunityAmountAfterDeletedScriptTask";
					result = CalckOpportunityAmountAfterDeletedScriptTask.Execute(context, CalckOpportunityAmountAfterDeletedScriptTaskExecute);
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
				case "OpportunityId":
					OpportunityId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool CalckOpportunityAmountAfterSevedScriptTaskExecute(ProcessExecutingContext context) {
			var opportunityId = Entity.GetTypedColumnValue<Guid>("OpportunityId");
			CalckOpportunityAmount(opportunityId);
			return true;
		}

		public virtual bool GetParamsBeforDeleteScriptTaskExecute(ProcessExecutingContext context) {
			OpportunityId = Entity.GetTypedColumnValue<Guid>("OpportunityId");
			return true;
		}

		public virtual bool CalckOpportunityAmountAfterDeletedScriptTaskExecute(ProcessExecutingContext context) {
			CalckOpportunityAmount(OpportunityId);
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "OpportunityProductInterest_Opportunity_TerrasoftSaved":
							if (ActivatedEventElements.Contains("CalckOpportunityAmountOpportunityProductInterestSaved")) {
							context.QueueTasks.Enqueue("CalckOpportunityAmountOpportunityProductInterestSaved");
						}
						break;
					case "OpportunityProductInterest_Opportunity_TerrasoftDeleting":
							if (ActivatedEventElements.Contains("OpportunityProductInterestDeletingStartMessage")) {
							context.QueueTasks.Enqueue("OpportunityProductInterestDeletingStartMessage");
						}
						break;
					case "OpportunityProductInterest_Opportunity_TerrasoftDeleted":
							if (ActivatedEventElements.Contains("OpportunityProductInterestDeletedStartMessage")) {
							context.QueueTasks.Enqueue("OpportunityProductInterestDeletedStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("OpportunityId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("OpportunityId", OpportunityId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityProductInterest_OpportunityEventsProcess

	/// <exclude/>
	public class OpportunityProductInterest_OpportunityEventsProcess : OpportunityProductInterest_OpportunityEventsProcess<OpportunityProductInterest_Opportunity_Terrasoft>
	{

		public OpportunityProductInterest_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OpportunityProductInterest_OpportunityEventsProcess

	public partial class OpportunityProductInterest_OpportunityEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void CalckOpportunityAmount(Guid opportunityId) {
			var oppotrunityAmountSelect = new Select(UserConnection)
				.Column("Amount")
				.From("OpportunityProductInterest")
				.Where("OpportunityId").IsEqual(Column.Parameter(opportunityId)) as Select;
			double opportunityAmount = 0.0;
			using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				using (IDataReader dr = oppotrunityAmountSelect.ExecuteReader(dbExecutor)) {
					while (dr.Read()) {
						if(!dr.IsDBNull(0)){
							opportunityAmount += (double)UserConnection.DBTypeConverter.DBValueToDecimal(dr[0]);
						}
					}
				}
			}
			var update = new Update(UserConnection, "Opportunity")
					.Set("Amount", Column.Parameter(opportunityAmount))
					.Where("Id").IsEqual(Column.Parameter(opportunityId));
				update.Execute();
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityProductInterest_Opportunity_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class OpportunityProductInterest_Opportunity_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public OpportunityProductInterest_Opportunity_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public OpportunityProductInterest_Opportunity_TerrasoftEventsProcessSchema(OpportunityProductInterest_Opportunity_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "OpportunityProductInterest_OpportunityEventsProcess";
			UId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98");
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

		protected virtual ProcessSchemaParameter CreateOpportunityIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e67b751d-419d-4e4d-815a-91c17db1eb69"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				Name = @"OpportunityId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateOpportunityIdParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaLane schemaLane2 = CreateLane2Lane();
			schemaLaneSet1.Lanes.Add(schemaLane2);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaStartMessageEvent calckopportunityamountopportunityproductinterestsaved = CreateCalckOpportunityAmountOpportunityProductInterestSavedStartMessageEvent();
			eventsubprocess1.FlowElements.Add(calckopportunityamountopportunityproductinterestsaved);
			ProcessSchemaIntermediateThrowMessageEvent calckopportunityamountintermediatethrowmessageevent = CreateCalckOpportunityAmountIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(calckopportunityamountintermediatethrowmessageevent);
			ProcessSchemaScriptTask calckopportunityamountaftersevedscripttask = CreateCalckOpportunityAmountAfterSevedScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(calckopportunityamountaftersevedscripttask);
			ProcessSchemaStartMessageEvent opportunityproductinterestdeletingstartmessage = CreateOpportunityProductInterestDeletingStartMessageStartMessageEvent();
			eventsubprocess2.FlowElements.Add(opportunityproductinterestdeletingstartmessage);
			ProcessSchemaIntermediateThrowMessageEvent opportunityproductinterestdeletingintermediatethrowmessageevent = CreateOpportunityProductInterestDeletingIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess2.FlowElements.Add(opportunityproductinterestdeletingintermediatethrowmessageevent);
			ProcessSchemaScriptTask getparamsbefordeletescripttask = CreateGetParamsBeforDeleteScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(getparamsbefordeletescripttask);
			ProcessSchemaStartMessageEvent opportunityproductinterestdeletedstartmessage = CreateOpportunityProductInterestDeletedStartMessageStartMessageEvent();
			eventsubprocess3.FlowElements.Add(opportunityproductinterestdeletedstartmessage);
			ProcessSchemaIntermediateThrowMessageEvent opportunityproductinterestdeletedintermediatethrowmessageevent = CreateOpportunityProductInterestDeletedIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess3.FlowElements.Add(opportunityproductinterestdeletedintermediatethrowmessageevent);
			ProcessSchemaScriptTask calckopportunityamountafterdeletedscripttask = CreateCalckOpportunityAmountAfterDeletedScriptTaskScriptTask();
			eventsubprocess3.FlowElements.Add(calckopportunityamountafterdeletedscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("2f1e925d-14e3-458b-a9e9-62ad7cf0c700"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21"),
				CreatedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				CurveCenterPosition = new Point(133, 91),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("64e54c47-2b33-4472-aceb-ffd60d7b815d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7ea89087-bafe-48a8-847d-9762ed8ed734"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("9ba918e2-d9c4-4da3-8da9-c94a4320a03c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21"),
				CreatedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				CurveCenterPosition = new Point(242, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7ea89087-bafe-48a8-847d-9762ed8ed734"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("86602499-a7e6-40c2-8ee2-57de6f20fb48"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("38a0178f-e8c9-4e9d-9298-35f7efde1f52"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21"),
				CreatedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				CurveCenterPosition = new Point(150, 272),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("576f1eb3-3ea5-4741-b152-930e2af4a3da"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("87244ea0-827c-420f-8d0f-771a27aef1c3"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("05581dfc-4504-4169-893c-ccc39ee58084"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21"),
				CreatedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				CurveCenterPosition = new Point(272, 270),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("87244ea0-827c-420f-8d0f-771a27aef1c3"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3da1d3c9-a0f4-418c-9d4d-7d256022999b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("eefeb284-7adf-4776-91f7-248afdcef3c5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21"),
				CreatedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				CurveCenterPosition = new Point(452, 273),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ea498719-b448-4c10-b1ee-ff9fa45d9312"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cd4f967e-b9bd-4b6a-afd6-aac170daa6b4"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("62df1185-b498-4ca6-b98e-4cf4534fd029"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21"),
				CreatedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				CurveCenterPosition = new Point(566, 276),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cd4f967e-b9bd-4b6a-afd6-aac170daa6b4"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ee2df171-dafc-4514-922d-8e8a1001784b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("5fe0912f-7d06-49c0-ae45-28f71002623e"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21"),
				CreatedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1169, 361),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("f0d49c88-a243-4b39-bb11-67cfb9428081"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("5fe0912f-7d06-49c0-ae45-28f71002623e"),
				CreatedInOwnerSchemaUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21"),
				CreatedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1140, 174),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("7ab33829-867c-4036-a40e-beee2d3c2e58"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("5fe0912f-7d06-49c0-ae45-28f71002623e"),
				CreatedInOwnerSchemaUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21"),
				CreatedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				Name = @"Lane2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 179),
				Size = new Size(1140, 182),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("094878a5-9cd7-4342-8c89-cb1841a7cc22"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f0d49c88-a243-4b39-bb11-67cfb9428081"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21"),
				CreatedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(56, 0),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(245, 158),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCalckOpportunityAmountOpportunityProductInterestSavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("64e54c47-2b33-4472-aceb-ffd60d7b815d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("094878a5-9cd7-4342-8c89-cb1841a7cc22"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21"),
				CreatedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OpportunityProductInterestSaved",
				ModifiedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				Name = @"CalckOpportunityAmountOpportunityProductInterestSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(1, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateCalckOpportunityAmountIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("86602499-a7e6-40c2-8ee2-57de6f20fb48"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("094878a5-9cd7-4342-8c89-cb1841a7cc22"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21"),
				CreatedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OpportunityProductInterestSaved",
				ModifiedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				Name = @"CalckOpportunityAmountIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(176, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCalckOpportunityAmountAfterSevedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7ea89087-bafe-48a8-847d-9762ed8ed734"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("094878a5-9cd7-4342-8c89-cb1841a7cc22"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21"),
				CreatedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				Name = @"CalckOpportunityAmountAfterSevedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(71, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,200,47,40,200,47,42,41,205,203,44,169,244,76,81,176,85,112,205,43,1,50,245,220,83,75,66,42,11,82,83,156,243,115,74,115,243,194,18,115,74,83,109,220,75,51,83,236,52,148,252,145,117,40,105,90,243,114,57,39,230,36,103,35,9,59,230,230,151,230,149,104,160,24,13,82,87,148,90,82,90,148,167,80,82,84,154,106,13,0,177,128,153,82,124,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("bb26cd7e-54ac-4d39-a295-3cb3ee9cd070"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7ab33829-867c-4036-a40e-beee2d3c2e58"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21"),
				CreatedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(49, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(279, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOpportunityProductInterestDeletingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("576f1eb3-3ea5-4741-b152-930e2af4a3da"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bb26cd7e-54ac-4d39-a295-3cb3ee9cd070"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21"),
				CreatedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OpportunityProductInterestDeleting",
				ModifiedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				Name = @"OpportunityProductInterestDeletingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(8, 68),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateOpportunityProductInterestDeletingIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("3da1d3c9-a0f4-418c-9d4d-7d256022999b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bb26cd7e-54ac-4d39-a295-3cb3ee9cd070"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21"),
				CreatedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OpportunityProductInterestDeleting",
				ModifiedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				Name = @"OpportunityProductInterestDeletingIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(211, 68),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateGetParamsBeforDeleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("87244ea0-827c-420f-8d0f-771a27aef1c3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bb26cd7e-54ac-4d39-a295-3cb3ee9cd070"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21"),
				CreatedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				Name = @"GetParamsBeforDeleteScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(92, 54),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,47,40,200,47,42,41,205,203,44,169,244,76,81,176,85,112,205,43,1,50,245,220,83,75,66,42,11,82,83,156,243,115,74,115,243,194,18,115,74,83,109,220,75,51,83,236,52,148,252,145,117,40,105,90,243,114,21,165,150,148,22,229,41,148,20,149,166,90,3,0,219,86,135,164,80,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("fe132501-9c48-48e9-a2c5-c591183965c6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7ab33829-867c-4036-a40e-beee2d3c2e58"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21"),
				CreatedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				Name = @"EventSubProcess3",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(357, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(260, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOpportunityProductInterestDeletedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ea498719-b448-4c10-b1ee-ff9fa45d9312"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fe132501-9c48-48e9-a2c5-c591183965c6"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21"),
				CreatedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OpportunityProductInterestDeleted",
				ModifiedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				Name = @"OpportunityProductInterestDeletedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(8, 61),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateOpportunityProductInterestDeletedIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("ee2df171-dafc-4514-922d-8e8a1001784b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fe132501-9c48-48e9-a2c5-c591183965c6"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21"),
				CreatedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OpportunityProductInterestDeleted",
				ModifiedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				Name = @"OpportunityProductInterestDeletedIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(190, 61),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCalckOpportunityAmountAfterDeletedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("cd4f967e-b9bd-4b6a-afd6-aac170daa6b4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fe132501-9c48-48e9-a2c5-c591183965c6"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21"),
				CreatedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				Name = @"CalckOpportunityAmountAfterDeletedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(85, 47),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,78,204,73,206,246,47,40,200,47,42,41,205,203,44,169,116,204,205,47,205,43,209,64,18,241,76,209,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,13,151,189,96,52,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateCalckOpportunityAmountMethod());
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

		protected virtual SchemaMethod CreateCalckOpportunityAmountMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6696048c-68e1-47c3-a8ac-51920a7d4153"),
				Name = "CalckOpportunityAmount",
				CreatedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("bc55f213-40ca-4508-92c1-556638449f28"),
				Name = "opportunityId",
				CreatedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				ModifiedInSchemaUId = new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,82,203,78,195,48,16,60,167,82,255,193,228,100,139,202,202,189,234,129,54,69,202,5,42,218,194,1,113,112,227,133,70,114,236,224,216,45,21,226,223,217,196,233,19,129,132,148,88,222,245,120,118,118,199,27,97,137,169,42,227,172,215,133,219,221,148,198,107,55,7,5,185,35,35,162,97,75,66,64,151,53,216,137,209,26,247,133,209,172,223,139,248,196,40,95,106,26,135,75,113,155,187,181,166,164,241,61,50,90,215,50,206,172,145,62,119,153,118,96,161,238,80,79,107,12,206,96,153,140,25,207,234,233,187,23,138,6,98,62,19,86,148,128,247,168,57,5,50,70,68,221,201,26,246,123,210,248,149,2,114,2,9,122,80,126,194,19,4,248,186,208,111,132,110,176,83,185,154,126,64,238,157,177,120,122,222,17,159,234,218,91,72,199,199,20,197,74,159,40,183,35,200,82,225,196,3,8,9,72,212,16,252,50,55,30,106,64,128,210,99,205,142,46,218,174,11,20,76,165,229,13,100,95,37,138,138,87,122,133,201,172,78,199,119,94,41,154,48,22,14,162,159,205,93,143,144,160,237,156,93,244,145,142,23,187,10,48,177,1,139,179,195,248,81,40,15,11,147,66,94,148,56,93,105,159,147,23,54,108,153,191,154,181,89,240,199,175,153,145,175,164,112,208,153,191,108,131,11,243,7,228,212,185,214,209,136,207,193,29,94,194,128,252,229,96,0,177,112,173,123,9,255,178,191,145,30,84,238,71,77,217,240,27,177,223,102,71,201,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OpportunityProductInterest_Opportunity_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("46ad895d-8074-4a95-b13c-df1ab3582c98"));
		}

		#endregion

	}

	#endregion

}

