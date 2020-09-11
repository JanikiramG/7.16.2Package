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

	#region Class: OpportunityCompetitor_Opportunity_TerrasoftSchema

	/// <exclude/>
	public class OpportunityCompetitor_Opportunity_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public OpportunityCompetitor_Opportunity_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OpportunityCompetitor_Opportunity_TerrasoftSchema(OpportunityCompetitor_Opportunity_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OpportunityCompetitor_Opportunity_TerrasoftSchema(OpportunityCompetitor_Opportunity_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("60631073-00cf-469f-b99b-8078eceb345b");
			RealUId = new Guid("60631073-00cf-469f-b99b-8078eceb345b");
			Name = "OpportunityCompetitor_Opportunity_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("a7997ccf-7474-4456-9f66-8119ce1211bf")) == null) {
				Columns.Add(CreateOpportunityColumn());
			}
			if (Columns.FindByUId(new Guid("c296bd96-22a5-4cb0-95bc-66ff808055b4")) == null) {
				Columns.Add(CreateCompetitorColumn());
			}
			if (Columns.FindByUId(new Guid("2f2dc07f-85f0-49e3-8351-60af95139874")) == null) {
				Columns.Add(CreateWeaknessColumn());
			}
			if (Columns.FindByUId(new Guid("51284b53-a6f6-457f-bb2f-31232cfc57e3")) == null) {
				Columns.Add(CreateStrengthsColumn());
			}
			if (Columns.FindByUId(new Guid("a3d6b036-d259-4040-9634-0cce1f08e686")) == null) {
				Columns.Add(CreateCompetitorProductColumn());
			}
			if (Columns.FindByUId(new Guid("110996ff-1738-44b8-b18d-a69e1f1f44f8")) == null) {
				Columns.Add(CreateCompetitorAmountColumn());
			}
			if (Columns.FindByUId(new Guid("de694946-ec43-48ac-ab5e-10a9c6ac2a27")) == null) {
				Columns.Add(CreateIsWinnerColumn());
			}
			if (Columns.FindByUId(new Guid("29c447b1-0a38-4d4b-ba03-746c05526659")) == null) {
				Columns.Add(CreateSupplierColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateOpportunityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a7997ccf-7474-4456-9f66-8119ce1211bf"),
				Name = @"Opportunity",
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("60631073-00cf-469f-b99b-8078eceb345b"),
				ModifiedInSchemaUId = new Guid("60631073-00cf-469f-b99b-8078eceb345b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateCompetitorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c296bd96-22a5-4cb0-95bc-66ff808055b4"),
				Name = @"Competitor",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("60631073-00cf-469f-b99b-8078eceb345b"),
				ModifiedInSchemaUId = new Guid("60631073-00cf-469f-b99b-8078eceb345b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateWeaknessColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("2f2dc07f-85f0-49e3-8351-60af95139874"),
				Name = @"Weakness",
				CreatedInSchemaUId = new Guid("60631073-00cf-469f-b99b-8078eceb345b"),
				ModifiedInSchemaUId = new Guid("60631073-00cf-469f-b99b-8078eceb345b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateStrengthsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("51284b53-a6f6-457f-bb2f-31232cfc57e3"),
				Name = @"Strengths",
				CreatedInSchemaUId = new Guid("60631073-00cf-469f-b99b-8078eceb345b"),
				ModifiedInSchemaUId = new Guid("60631073-00cf-469f-b99b-8078eceb345b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateCompetitorProductColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a3d6b036-d259-4040-9634-0cce1f08e686"),
				Name = @"CompetitorProduct",
				ReferenceSchemaUId = new Guid("a90cf5af-917c-4b33-8eee-832906dbe6d5"),
				CreatedInSchemaUId = new Guid("60631073-00cf-469f-b99b-8078eceb345b"),
				ModifiedInSchemaUId = new Guid("60631073-00cf-469f-b99b-8078eceb345b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateCompetitorAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("110996ff-1738-44b8-b18d-a69e1f1f44f8"),
				Name = @"CompetitorAmount",
				CreatedInSchemaUId = new Guid("60631073-00cf-469f-b99b-8078eceb345b"),
				ModifiedInSchemaUId = new Guid("60631073-00cf-469f-b99b-8078eceb345b"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21")
			};
		}

		protected virtual EntitySchemaColumn CreateIsWinnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("de694946-ec43-48ac-ab5e-10a9c6ac2a27"),
				Name = @"IsWinner",
				CreatedInSchemaUId = new Guid("60631073-00cf-469f-b99b-8078eceb345b"),
				ModifiedInSchemaUId = new Guid("60631073-00cf-469f-b99b-8078eceb345b"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21")
			};
		}

		protected virtual EntitySchemaColumn CreateSupplierColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("29c447b1-0a38-4d4b-ba03-746c05526659"),
				Name = @"Supplier",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("60631073-00cf-469f-b99b-8078eceb345b"),
				ModifiedInSchemaUId = new Guid("60631073-00cf-469f-b99b-8078eceb345b"),
				CreatedInPackageId = new Guid("d5fd37cc-1f9c-4f35-91fb-f2d079cb26f9")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateOpportunityCompetitor_Opportunity_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateOpportunityCompetitor_Opportunity_TerrasoftEventsProcessSchema() {
			var schema = new OpportunityCompetitor_Opportunity_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new OpportunityCompetitor_Opportunity_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OpportunityCompetitor_OpportunityEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OpportunityCompetitor_Opportunity_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OpportunityCompetitor_Opportunity_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("60631073-00cf-469f-b99b-8078eceb345b"));
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityCompetitor_Opportunity_Terrasoft

	/// <summary>
	/// Competitor.
	/// </summary>
	public class OpportunityCompetitor_Opportunity_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public OpportunityCompetitor_Opportunity_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OpportunityCompetitor_Opportunity_Terrasoft";
		}

		public OpportunityCompetitor_Opportunity_Terrasoft(OpportunityCompetitor_Opportunity_Terrasoft source)
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
		public Guid CompetitorId {
			get {
				return GetTypedColumnValue<Guid>("CompetitorId");
			}
			set {
				SetColumnValue("CompetitorId", value);
				_competitor = null;
			}
		}

		/// <exclude/>
		public string CompetitorName {
			get {
				return GetTypedColumnValue<string>("CompetitorName");
			}
			set {
				SetColumnValue("CompetitorName", value);
				if (_competitor != null) {
					_competitor.Name = value;
				}
			}
		}

		private Account _competitor;
		/// <summary>
		/// Manufacturer.
		/// </summary>
		public Account Competitor {
			get {
				return _competitor ??
					(_competitor = LookupColumnEntities.GetEntity("Competitor") as Account);
			}
		}

		/// <summary>
		/// Weaknesses.
		/// </summary>
		public string Weakness {
			get {
				return GetTypedColumnValue<string>("Weakness");
			}
			set {
				SetColumnValue("Weakness", value);
			}
		}

		/// <summary>
		/// Strengths.
		/// </summary>
		public string Strengths {
			get {
				return GetTypedColumnValue<string>("Strengths");
			}
			set {
				SetColumnValue("Strengths", value);
			}
		}

		/// <exclude/>
		public Guid CompetitorProductId {
			get {
				return GetTypedColumnValue<Guid>("CompetitorProductId");
			}
			set {
				SetColumnValue("CompetitorProductId", value);
				_competitorProduct = null;
			}
		}

		/// <exclude/>
		public string CompetitorProductName {
			get {
				return GetTypedColumnValue<string>("CompetitorProductName");
			}
			set {
				SetColumnValue("CompetitorProductName", value);
				if (_competitorProduct != null) {
					_competitorProduct.Name = value;
				}
			}
		}

		private CompetitorProduct _competitorProduct;
		/// <summary>
		/// Competitor product.
		/// </summary>
		public CompetitorProduct CompetitorProduct {
			get {
				return _competitorProduct ??
					(_competitorProduct = LookupColumnEntities.GetEntity("CompetitorProduct") as CompetitorProduct);
			}
		}

		/// <summary>
		/// Amount offered.
		/// </summary>
		public Decimal CompetitorAmount {
			get {
				return GetTypedColumnValue<Decimal>("CompetitorAmount");
			}
			set {
				SetColumnValue("CompetitorAmount", value);
			}
		}

		/// <summary>
		/// Winner.
		/// </summary>
		public bool IsWinner {
			get {
				return GetTypedColumnValue<bool>("IsWinner");
			}
			set {
				SetColumnValue("IsWinner", value);
			}
		}

		/// <exclude/>
		public Guid SupplierId {
			get {
				return GetTypedColumnValue<Guid>("SupplierId");
			}
			set {
				SetColumnValue("SupplierId", value);
				_supplier = null;
			}
		}

		/// <exclude/>
		public string SupplierName {
			get {
				return GetTypedColumnValue<string>("SupplierName");
			}
			set {
				SetColumnValue("SupplierName", value);
				if (_supplier != null) {
					_supplier.Name = value;
				}
			}
		}

		private Account _supplier;
		/// <summary>
		/// Supplier.
		/// </summary>
		public Account Supplier {
			get {
				return _supplier ??
					(_supplier = LookupColumnEntities.GetEntity("Supplier") as Account);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OpportunityCompetitor_OpportunityEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("OpportunityCompetitor_Opportunity_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("OpportunityCompetitor_Opportunity_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("OpportunityCompetitor_Opportunity_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("OpportunityCompetitor_Opportunity_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("OpportunityCompetitor_Opportunity_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("OpportunityCompetitor_Opportunity_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("OpportunityCompetitor_Opportunity_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OpportunityCompetitor_Opportunity_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityCompetitor_OpportunityEventsProcess

	/// <exclude/>
	public partial class OpportunityCompetitor_OpportunityEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : OpportunityCompetitor_Opportunity_Terrasoft
	{

		public OpportunityCompetitor_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpportunityCompetitor_OpportunityEventsProcess";
			SchemaUId = new Guid("60631073-00cf-469f-b99b-8078eceb345b");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("60631073-00cf-469f-b99b-8078eceb345b");
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

	#region Class: OpportunityCompetitor_OpportunityEventsProcess

	/// <exclude/>
	public class OpportunityCompetitor_OpportunityEventsProcess : OpportunityCompetitor_OpportunityEventsProcess<OpportunityCompetitor_Opportunity_Terrasoft>
	{

		public OpportunityCompetitor_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OpportunityCompetitor_OpportunityEventsProcess

	public partial class OpportunityCompetitor_OpportunityEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: OpportunityCompetitor_Opportunity_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class OpportunityCompetitor_Opportunity_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public OpportunityCompetitor_Opportunity_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public OpportunityCompetitor_Opportunity_TerrasoftEventsProcessSchema(OpportunityCompetitor_Opportunity_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "OpportunityCompetitor_OpportunityEventsProcess";
			UId = new Guid("c82def12-8f6f-4d7f-bb13-90f68df16c68");
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
			return new OpportunityCompetitor_Opportunity_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c82def12-8f6f-4d7f-bb13-90f68df16c68"));
		}

		#endregion

	}

	#endregion

}

