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

	#region Class: AccountBillingInfoSchema

	/// <exclude/>
	public class AccountBillingInfoSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public AccountBillingInfoSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AccountBillingInfoSchema(AccountBillingInfoSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AccountBillingInfoSchema(AccountBillingInfoSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4f0e44ce-343c-45b6-ae14-ff0533d4add9");
			RealUId = new Guid("4f0e44ce-343c-45b6-ae14-ff0533d4add9");
			Name = "AccountBillingInfo";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("b9d48ea8-9084-479a-819f-8b802eb1f93a")) == null) {
				Columns.Add(CreateAccountColumn());
			}
			if (Columns.FindByUId(new Guid("62ceb4ed-df4b-41bb-a712-bb461c853eec")) == null) {
				Columns.Add(CreateCountryColumn());
			}
			if (Columns.FindByUId(new Guid("491be940-68f3-45a8-aa68-90e7def2bd36")) == null) {
				Columns.Add(CreateBillingInfoColumn());
			}
			if (Columns.FindByUId(new Guid("d66f5ffb-d469-44d2-97e0-040a28a9f266")) == null) {
				Columns.Add(CreateAccountManagerColumn());
			}
			if (Columns.FindByUId(new Guid("387f30c7-9b1f-4efd-8ba4-5c4084729550")) == null) {
				Columns.Add(CreateChiefAccountantColumn());
			}
			if (Columns.FindByUId(new Guid("a5482c7e-e947-4daf-b73d-9b3aca5ff73d")) == null) {
				Columns.Add(CreateLegalUnitColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("4f0e44ce-343c-45b6-ae14-ff0533d4add9");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("4f0e44ce-343c-45b6-ae14-ff0533d4add9");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("4f0e44ce-343c-45b6-ae14-ff0533d4add9");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected virtual EntitySchemaColumn CreateAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b9d48ea8-9084-479a-819f-8b802eb1f93a"),
				Name = @"Account",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("4f0e44ce-343c-45b6-ae14-ff0533d4add9"),
				ModifiedInSchemaUId = new Guid("4f0e44ce-343c-45b6-ae14-ff0533d4add9"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateCountryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("62ceb4ed-df4b-41bb-a712-bb461c853eec"),
				Name = @"Country",
				ReferenceSchemaUId = new Guid("09fce1f8-515c-4296-95cd-8cd93f79a6cf"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("4f0e44ce-343c-45b6-ae14-ff0533d4add9"),
				ModifiedInSchemaUId = new Guid("4f0e44ce-343c-45b6-ae14-ff0533d4add9"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateBillingInfoColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("491be940-68f3-45a8-aa68-90e7def2bd36"),
				Name = @"BillingInfo",
				CreatedInSchemaUId = new Guid("4f0e44ce-343c-45b6-ae14-ff0533d4add9"),
				ModifiedInSchemaUId = new Guid("4f0e44ce-343c-45b6-ae14-ff0533d4add9"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateAccountManagerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d66f5ffb-d469-44d2-97e0-040a28a9f266"),
				Name = @"AccountManager",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("4f0e44ce-343c-45b6-ae14-ff0533d4add9"),
				ModifiedInSchemaUId = new Guid("4f0e44ce-343c-45b6-ae14-ff0533d4add9"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateChiefAccountantColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("387f30c7-9b1f-4efd-8ba4-5c4084729550"),
				Name = @"ChiefAccountant",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("4f0e44ce-343c-45b6-ae14-ff0533d4add9"),
				ModifiedInSchemaUId = new Guid("4f0e44ce-343c-45b6-ae14-ff0533d4add9"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateLegalUnitColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("a5482c7e-e947-4daf-b73d-9b3aca5ff73d"),
				Name = @"LegalUnit",
				CreatedInSchemaUId = new Guid("4f0e44ce-343c-45b6-ae14-ff0533d4add9"),
				ModifiedInSchemaUId = new Guid("4f0e44ce-343c-45b6-ae14-ff0533d4add9"),
				CreatedInPackageId = new Guid("960590ca-7694-45ea-8480-d4c05f2f9315")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAccountBillingInfoEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateAccountBillingInfoEventsProcessSchema() {
			var schema = new AccountBillingInfoEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new AccountBillingInfo(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AccountBillingInfo_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AccountBillingInfoSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AccountBillingInfoSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4f0e44ce-343c-45b6-ae14-ff0533d4add9"));
		}

		#endregion

	}

	#endregion

	#region Class: AccountBillingInfo

	/// <summary>
	/// Banking details.
	/// </summary>
	public class AccountBillingInfo : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public AccountBillingInfo(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AccountBillingInfo";
		}

		public AccountBillingInfo(AccountBillingInfo source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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
		public Guid CountryId {
			get {
				return GetTypedColumnValue<Guid>("CountryId");
			}
			set {
				SetColumnValue("CountryId", value);
				_country = null;
			}
		}

		/// <exclude/>
		public string CountryName {
			get {
				return GetTypedColumnValue<string>("CountryName");
			}
			set {
				SetColumnValue("CountryName", value);
				if (_country != null) {
					_country.Name = value;
				}
			}
		}

		private Country _country;
		/// <summary>
		/// Country.
		/// </summary>
		public Country Country {
			get {
				return _country ??
					(_country = LookupColumnEntities.GetEntity("Country") as Country);
			}
		}

		/// <summary>
		/// Banking details.
		/// </summary>
		public string BillingInfo {
			get {
				return GetTypedColumnValue<string>("BillingInfo");
			}
			set {
				SetColumnValue("BillingInfo", value);
			}
		}

		/// <exclude/>
		public Guid AccountManagerId {
			get {
				return GetTypedColumnValue<Guid>("AccountManagerId");
			}
			set {
				SetColumnValue("AccountManagerId", value);
				_accountManager = null;
			}
		}

		/// <exclude/>
		public string AccountManagerName {
			get {
				return GetTypedColumnValue<string>("AccountManagerName");
			}
			set {
				SetColumnValue("AccountManagerName", value);
				if (_accountManager != null) {
					_accountManager.Name = value;
				}
			}
		}

		private Contact _accountManager;
		/// <summary>
		/// Manager.
		/// </summary>
		public Contact AccountManager {
			get {
				return _accountManager ??
					(_accountManager = LookupColumnEntities.GetEntity("AccountManager") as Contact);
			}
		}

		/// <exclude/>
		public Guid ChiefAccountantId {
			get {
				return GetTypedColumnValue<Guid>("ChiefAccountantId");
			}
			set {
				SetColumnValue("ChiefAccountantId", value);
				_chiefAccountant = null;
			}
		}

		/// <exclude/>
		public string ChiefAccountantName {
			get {
				return GetTypedColumnValue<string>("ChiefAccountantName");
			}
			set {
				SetColumnValue("ChiefAccountantName", value);
				if (_chiefAccountant != null) {
					_chiefAccountant.Name = value;
				}
			}
		}

		private Contact _chiefAccountant;
		/// <summary>
		/// Chief accountant.
		/// </summary>
		public Contact ChiefAccountant {
			get {
				return _chiefAccountant ??
					(_chiefAccountant = LookupColumnEntities.GetEntity("ChiefAccountant") as Contact);
			}
		}

		/// <summary>
		/// Legal entity.
		/// </summary>
		public string LegalUnit {
			get {
				return GetTypedColumnValue<string>("LegalUnit");
			}
			set {
				SetColumnValue("LegalUnit", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AccountBillingInfo_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AccountBillingInfoDeleted", e);
			Deleting += (s, e) => ThrowEvent("AccountBillingInfoDeleting", e);
			Inserted += (s, e) => ThrowEvent("AccountBillingInfoInserted", e);
			Inserting += (s, e) => ThrowEvent("AccountBillingInfoInserting", e);
			Saved += (s, e) => ThrowEvent("AccountBillingInfoSaved", e);
			Saving += (s, e) => ThrowEvent("AccountBillingInfoSaving", e);
			Validating += (s, e) => ThrowEvent("AccountBillingInfoValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AccountBillingInfo(this);
		}

		#endregion

	}

	#endregion

	#region Class: AccountBillingInfo_BaseEventsProcess

	/// <exclude/>
	public partial class AccountBillingInfo_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_BaseEventsProcess<TEntity> where TEntity : AccountBillingInfo
	{

		public AccountBillingInfo_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AccountBillingInfo_BaseEventsProcess";
			SchemaUId = new Guid("4f0e44ce-343c-45b6-ae14-ff0533d4add9");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("4f0e44ce-343c-45b6-ae14-ff0533d4add9");
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

	#region Class: AccountBillingInfo_BaseEventsProcess

	/// <exclude/>
	public class AccountBillingInfo_BaseEventsProcess : AccountBillingInfo_BaseEventsProcess<AccountBillingInfo>
	{

		public AccountBillingInfo_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AccountBillingInfo_BaseEventsProcess

	public partial class AccountBillingInfo_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void CheckCanManageLookups() {
		}

		#endregion

	}

	#endregion

	#region Class: AccountBillingInfoEventsProcessSchema

	/// <exclude/>
	public class AccountBillingInfoEventsProcessSchema : Terrasoft.Configuration.BaseLookupEventsProcessSchema
	{

		#region Constructors: Public

		public AccountBillingInfoEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AccountBillingInfoEventsProcessSchema(AccountBillingInfoEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AccountBillingInfo_BaseEventsProcess";
			UId = new Guid("ed4e1494-e98b-4fd9-8f72-52f2189c2710");
			CreatedInPackageId = new Guid("b466acb1-8049-4776-835c-a1e006a6057c");
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

		protected override SchemaMethod CreateCheckCanManageLookupsMethod() {
			SchemaMethod method = base.CreateCheckCanManageLookupsMethod();
			method.IsOverride = true;
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AccountBillingInfoEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ed4e1494-e98b-4fd9-8f72-52f2189c2710"));
		}

		#endregion

	}

	#endregion


	#region Class: AccountBillingInfoEventsProcess

	/// <exclude/>
	public class AccountBillingInfoEventsProcess : AccountBillingInfo_BaseEventsProcess
	{

		public AccountBillingInfoEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

