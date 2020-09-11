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

	#region Class: Lead_PRMBase_TerrasoftSchema

	/// <exclude/>
	public class Lead_PRMBase_TerrasoftSchema : Terrasoft.Configuration.Lead_CoreLeadOpportunity_TerrasoftSchema
	{

		#region Constructors: Public

		public Lead_PRMBase_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Lead_PRMBase_TerrasoftSchema(Lead_PRMBase_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Lead_PRMBase_TerrasoftSchema(Lead_PRMBase_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIMLLeadModifiedOnIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("e0ee791a-7d9e-4ef7-8653-eb995a3f6d74");
			index.Name = "IMLLeadModifiedOn";
			index.CreatedInSchemaUId = new Guid("d9947110-c8c4-49c9-8bc1-344ec81a0258");
			index.ModifiedInSchemaUId = new Guid("d9947110-c8c4-49c9-8bc1-344ec81a0258");
			index.CreatedInPackageId = new Guid("296a0a1e-e6de-4406-bbd8-86a62e047ff0");
			EntitySchemaIndexColumn modifiedOnIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("aaa8ad09-ce33-4f85-9c6f-46d679ad61ee"),
				ColumnUId = new Guid("9928edec-4272-425a-93bb-48743fee4b04"),
				CreatedInSchemaUId = new Guid("d9947110-c8c4-49c9-8bc1-344ec81a0258"),
				ModifiedInSchemaUId = new Guid("d9947110-c8c4-49c9-8bc1-344ec81a0258"),
				CreatedInPackageId = new Guid("296a0a1e-e6de-4406-bbd8-86a62e047ff0"),
				OrderDirection = OrderDirectionStrict.Descending
			};
			index.Columns.Add(modifiedOnIndexColumn);
			return index;
		}

		private EntitySchemaIndex CreateIDX_LeadNameIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("bf3f62f3-5d38-4031-a648-58b036f8f19d");
			index.Name = "IDX_LeadName";
			index.CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			index.ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			index.CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06");
			EntitySchemaIndexColumn leadNameIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("2c3ed9bd-ff44-447d-b4af-c6a4e4090a5a"),
				ColumnUId = new Guid("d06ba9af-faf5-4741-a672-e154ae561a94"),
				CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(leadNameIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("55020fdb-b605-40c2-ac32-4aa3e46c5406");
			Name = "Lead_PRMBase_Terrasoft";
			ParentSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			ExtendParent = true;
			CreatedInPackageId = new Guid("de8ae9a8-a9a7-4323-ba50-b61a787183b3");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("693f56bf-b9bb-4f39-bca2-1b307f60cca5")) == null) {
				Columns.Add(CreatePartnerColumn());
			}
			if (Columns.FindByUId(new Guid("becf8a84-8327-4864-97d3-209b2a7dc67e")) == null) {
				Columns.Add(CreatePartnerOwnerColumn());
			}
			if (Columns.FindByUId(new Guid("215eb46b-7973-42c0-bb8f-8b011a8fbd67")) == null) {
				Columns.Add(CreatePartnerTypeColumn());
			}
			if (Columns.FindByUId(new Guid("33cf5522-8fdc-4d80-ae7a-07c96cefebca")) == null) {
				Columns.Add(CreateSalesChannelColumn());
			}
		}

		protected virtual EntitySchemaColumn CreatePartnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("693f56bf-b9bb-4f39-bca2-1b307f60cca5"),
				Name = @"Partner",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("55020fdb-b605-40c2-ac32-4aa3e46c5406"),
				ModifiedInSchemaUId = new Guid("55020fdb-b605-40c2-ac32-4aa3e46c5406"),
				CreatedInPackageId = new Guid("de8ae9a8-a9a7-4323-ba50-b61a787183b3")
			};
		}

		protected virtual EntitySchemaColumn CreatePartnerOwnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("becf8a84-8327-4864-97d3-209b2a7dc67e"),
				Name = @"PartnerOwner",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("55020fdb-b605-40c2-ac32-4aa3e46c5406"),
				ModifiedInSchemaUId = new Guid("55020fdb-b605-40c2-ac32-4aa3e46c5406"),
				CreatedInPackageId = new Guid("de8ae9a8-a9a7-4323-ba50-b61a787183b3")
			};
		}

		protected virtual EntitySchemaColumn CreatePartnerTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("215eb46b-7973-42c0-bb8f-8b011a8fbd67"),
				Name = @"PartnerType",
				ReferenceSchemaUId = new Guid("43cadf79-8d33-4697-8344-ec24fa905332"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("55020fdb-b605-40c2-ac32-4aa3e46c5406"),
				ModifiedInSchemaUId = new Guid("55020fdb-b605-40c2-ac32-4aa3e46c5406"),
				CreatedInPackageId = new Guid("c753c9c2-3fc1-46be-9c9c-b15f50a19487")
			};
		}

		protected virtual EntitySchemaColumn CreateSalesChannelColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("33cf5522-8fdc-4d80-ae7a-07c96cefebca"),
				Name = @"SalesChannel",
				ReferenceSchemaUId = new Guid("85fe0df7-a970-4717-8f7b-8caba783906b"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("55020fdb-b605-40c2-ac32-4aa3e46c5406"),
				ModifiedInSchemaUId = new Guid("55020fdb-b605-40c2-ac32-4aa3e46c5406"),
				CreatedInPackageId = new Guid("ee0be05f-9653-462f-890a-39e216314520"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"3c3865f2-ada4-480c-ac91-e2d39c5bbaf9"
				}
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIMLLeadModifiedOnIndex());
			Indexes.Add(CreateIDX_LeadNameIndex());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateLead_PRMBase_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateLead_PRMBase_TerrasoftEventsProcessSchema() {
			var schema = new Lead_PRMBase_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Lead_PRMBase_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Lead_PRMBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Lead_PRMBase_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Lead_PRMBase_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("55020fdb-b605-40c2-ac32-4aa3e46c5406"));
		}

		#endregion

	}

	#endregion

	#region Class: Lead_PRMBase_Terrasoft

	/// <summary>
	/// Lead.
	/// </summary>
	public class Lead_PRMBase_Terrasoft : Terrasoft.Configuration.Lead_CoreLeadOpportunity_Terrasoft
	{

		#region Constructors: Public

		public Lead_PRMBase_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Lead_PRMBase_Terrasoft";
		}

		public Lead_PRMBase_Terrasoft(Lead_PRMBase_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid PartnerId {
			get {
				return GetTypedColumnValue<Guid>("PartnerId");
			}
			set {
				SetColumnValue("PartnerId", value);
				_partner = null;
			}
		}

		/// <exclude/>
		public string PartnerName {
			get {
				return GetTypedColumnValue<string>("PartnerName");
			}
			set {
				SetColumnValue("PartnerName", value);
				if (_partner != null) {
					_partner.Name = value;
				}
			}
		}

		private Account _partner;
		/// <summary>
		/// Partner.
		/// </summary>
		public Account Partner {
			get {
				return _partner ??
					(_partner = LookupColumnEntities.GetEntity("Partner") as Account);
			}
		}

		/// <exclude/>
		public Guid PartnerOwnerId {
			get {
				return GetTypedColumnValue<Guid>("PartnerOwnerId");
			}
			set {
				SetColumnValue("PartnerOwnerId", value);
				_partnerOwner = null;
			}
		}

		/// <exclude/>
		public string PartnerOwnerName {
			get {
				return GetTypedColumnValue<string>("PartnerOwnerName");
			}
			set {
				SetColumnValue("PartnerOwnerName", value);
				if (_partnerOwner != null) {
					_partnerOwner.Name = value;
				}
			}
		}

		private Contact _partnerOwner;
		/// <summary>
		/// Partner's deal owner.
		/// </summary>
		public Contact PartnerOwner {
			get {
				return _partnerOwner ??
					(_partnerOwner = LookupColumnEntities.GetEntity("PartnerOwner") as Contact);
			}
		}

		/// <exclude/>
		public Guid PartnerTypeId {
			get {
				return GetTypedColumnValue<Guid>("PartnerTypeId");
			}
			set {
				SetColumnValue("PartnerTypeId", value);
				_partnerType = null;
			}
		}

		/// <exclude/>
		public string PartnerTypeName {
			get {
				return GetTypedColumnValue<string>("PartnerTypeName");
			}
			set {
				SetColumnValue("PartnerTypeName", value);
				if (_partnerType != null) {
					_partnerType.Name = value;
				}
			}
		}

		private PartnerType _partnerType;
		/// <summary>
		/// Partner type.
		/// </summary>
		public PartnerType PartnerType {
			get {
				return _partnerType ??
					(_partnerType = LookupColumnEntities.GetEntity("PartnerType") as PartnerType);
			}
		}

		/// <exclude/>
		public Guid SalesChannelId {
			get {
				return GetTypedColumnValue<Guid>("SalesChannelId");
			}
			set {
				SetColumnValue("SalesChannelId", value);
				_salesChannel = null;
			}
		}

		/// <exclude/>
		public string SalesChannelName {
			get {
				return GetTypedColumnValue<string>("SalesChannelName");
			}
			set {
				SetColumnValue("SalesChannelName", value);
				if (_salesChannel != null) {
					_salesChannel.Name = value;
				}
			}
		}

		private OpportunityType _salesChannel;
		/// <summary>
		/// Sales channel.
		/// </summary>
		public OpportunityType SalesChannel {
			get {
				return _salesChannel ??
					(_salesChannel = LookupColumnEntities.GetEntity("SalesChannel") as OpportunityType);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Lead_PRMBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Lead_PRMBase_TerrasoftDeleted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Lead_PRMBase_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Lead_PRMBaseEventsProcess

	/// <exclude/>
	public partial class Lead_PRMBaseEventsProcess<TEntity> : Terrasoft.Configuration.Lead_CoreLeadOpportunityEventsProcess<TEntity> where TEntity : Lead_PRMBase_Terrasoft
	{

		public Lead_PRMBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Lead_PRMBaseEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("55020fdb-b605-40c2-ac32-4aa3e46c5406");
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

	#region Class: Lead_PRMBaseEventsProcess

	/// <exclude/>
	public class Lead_PRMBaseEventsProcess : Lead_PRMBaseEventsProcess<Lead_PRMBase_Terrasoft>
	{

		public Lead_PRMBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Lead_PRMBaseEventsProcess

	public partial class Lead_PRMBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void LeadInserted() {
			base.LeadInserted();
			if (Entity.GetIsColumnValueLoaded("QualifiedContactId") && Guid.Empty != Entity.QualifiedContactId ||
					Entity.GetIsColumnValueLoaded("WebFormId") && Guid.Empty == Entity.WebFormId) {	
				return;
			}
			ProcessSchema schema = UserConnection.ProcessSchemaManager.GetInstanceByName("LeadManagementIdentification");
			bool canUseFlowEngine = ProcessSchemaManager.GetCanUseFlowEngine(UserConnection, schema);
			if (canUseFlowEngine) {
				var flowEngine = new FlowEngine(UserConnection);
				var param = new Dictionary<string, string>();
				param["LeadId"] = Entity.Id.ToString();
				flowEngine.RunProcess(schema, param);
			}  else {
				Process process = schema.CreateProcess(UserConnection);
				process.SetPropertyValue("LeadId", Entity.Id);
				process.Execute(UserConnection);
			}
		}

		public override void LeadInserting() {
			base.LeadInserting();
			string bpmHrefColumnName = "BpmHref";
			string bpmRefColumnName = "BpmRef";
			string bpmHref = Entity.IsColumnValueLoaded(bpmHrefColumnName) 
				? Entity.GetTypedColumnValue<string>(bpmHrefColumnName) : String.Empty;
			string bpmRef = Entity.IsColumnValueLoaded(bpmRefColumnName) 
				? Entity.GetTypedColumnValue<string>(bpmRefColumnName) : String.Empty;
			Terrasoft.Configuration.LeadSourceHelper lsh = 
				new Terrasoft.Configuration.LeadSourceHelper(UserConnection, bpmHref, bpmRef);
			lsh.ComputeMediumAndSource();
			Guid resultLeadMediumId = lsh.ResultLeadMediumId;
			Guid resultLeadSourceId = lsh.ResultLeadSourceId;
			if (resultLeadMediumId != Guid.Empty) {
				Entity.SetColumnValue("LeadMediumId", resultLeadMediumId);
			}
			if (resultLeadSourceId != Guid.Empty) {
				Entity.SetColumnValue("LeadSourceId", resultLeadSourceId);
			}
		}

		#endregion

	}

	#endregion

	#region Class: Lead_PRMBase_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Lead_PRMBase_TerrasoftEventsProcessSchema : Terrasoft.Configuration.Lead_CoreLeadOpportunity_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public Lead_PRMBase_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Lead_PRMBase_TerrasoftEventsProcessSchema(Lead_PRMBase_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Lead_PRMBaseEventsProcess";
			UId = new Guid("7aab369d-7bba-44b1-b168-ff2d07d26e0b");
			CreatedInPackageId = new Guid("de8ae9a8-a9a7-4323-ba50-b61a787183b3");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("7da36be2-d18a-48e3-bee4-f2081049a18f");
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
				CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64")
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

		protected override SchemaMethod CreateLeadInsertedMethod() {
			SchemaMethod method = base.CreateLeadInsertedMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,146,203,78,195,48,16,69,215,201,87,152,44,170,84,170,242,3,37,44,40,105,85,169,32,160,60,22,136,197,52,153,22,75,201,56,178,29,74,68,251,239,56,142,251,110,197,198,179,240,241,157,123,199,51,3,133,209,4,33,27,147,66,169,49,11,187,125,159,207,89,152,144,230,186,142,70,168,199,106,32,242,170,160,55,200,43,156,8,200,12,20,60,85,144,243,57,199,108,32,72,67,170,199,89,208,101,157,14,27,85,60,139,146,162,212,53,187,138,153,19,57,133,217,106,229,123,222,63,61,222,113,54,20,178,56,35,29,111,165,183,76,151,253,122,190,39,81,87,146,250,254,218,127,148,34,69,165,166,233,23,22,192,84,91,98,246,106,82,26,23,132,169,230,130,162,3,234,30,8,22,40,173,31,82,26,40,197,219,250,1,10,12,131,102,66,237,117,129,100,252,155,195,4,74,161,17,9,204,196,102,66,228,44,5,50,242,195,92,44,19,90,112,66,211,238,146,254,224,8,13,15,125,245,156,97,247,23,199,194,38,171,239,125,131,100,243,253,94,132,75,118,81,209,40,217,23,37,72,40,28,124,199,237,21,200,250,90,105,201,105,97,218,218,122,211,44,129,103,209,15,27,221,124,193,39,219,206,124,156,69,47,98,106,73,11,238,92,68,207,21,185,200,97,155,160,215,118,52,216,154,49,204,21,54,214,29,194,74,87,99,23,55,26,72,4,141,27,133,211,4,238,65,52,69,109,160,210,44,108,109,55,38,220,184,236,237,60,238,243,201,15,166,149,62,51,147,245,31,255,10,48,235,0,3,0,0 };
			return method;
		}

		protected override SchemaMethod CreateLeadInsertingMethod() {
			SchemaMethod method = base.CreateLeadInsertingMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,145,223,78,131,48,20,198,175,225,41,42,87,144,16,30,192,57,141,46,203,70,50,189,128,233,125,183,30,102,19,218,146,254,137,33,198,119,183,93,193,32,16,167,222,53,61,231,247,125,223,57,231,128,21,100,59,192,36,231,10,164,166,252,20,39,139,80,105,105,95,232,208,176,173,132,106,37,106,195,248,19,102,128,150,40,122,240,159,209,176,171,152,105,42,70,61,14,178,165,53,215,84,183,89,174,60,240,130,107,3,59,129,9,144,120,98,151,160,48,184,235,137,13,232,125,219,0,25,112,55,94,253,118,142,188,70,229,185,152,173,89,163,219,81,216,139,57,138,255,198,40,126,78,177,7,41,177,18,149,206,86,130,87,244,100,36,214,84,240,243,5,74,97,228,17,182,80,55,32,81,173,94,109,200,48,224,240,134,126,11,197,207,246,132,182,133,195,209,213,211,126,235,105,55,181,61,172,149,181,34,172,49,26,30,129,80,195,238,121,39,225,206,190,49,148,32,9,202,212,218,105,251,142,156,216,32,142,43,38,133,9,225,165,102,136,190,176,8,105,133,226,25,139,171,37,114,90,126,79,9,122,15,131,110,223,37,232,193,170,227,104,72,69,233,76,90,59,199,199,200,229,43,214,159,92,122,234,155,75,255,233,92,62,1,17,117,220,216,60,3,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Lead_PRMBase_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7aab369d-7bba-44b1-b168-ff2d07d26e0b"));
		}

		#endregion

	}

	#endregion

}

