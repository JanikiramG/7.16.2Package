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
	using Terrasoft.Configuration;
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

	#region Class: Invoice_Invoice_TerrasoftSchema

	/// <exclude/>
	public class Invoice_Invoice_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public Invoice_Invoice_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Invoice_Invoice_TerrasoftSchema(Invoice_Invoice_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Invoice_Invoice_TerrasoftSchema(Invoice_Invoice_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5");
			RealUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5");
			Name = "Invoice_Invoice_Terrasoft";
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
			if (Columns.FindByUId(new Guid("60364b7c-e7c4-43e3-81bf-5899e49a01aa")) == null) {
				Columns.Add(CreateStartDateColumn());
			}
			if (Columns.FindByUId(new Guid("420f8d90-f6b1-4140-81b8-53e1f39d1379")) == null) {
				Columns.Add(CreatePrimaryAmountColumn());
			}
			if (Columns.FindByUId(new Guid("76ec81f5-b0ea-4a33-a4bc-eddd91d0dcca")) == null) {
				Columns.Add(CreatePrimaryPaymentAmountColumn());
			}
			if (Columns.FindByUId(new Guid("77ce961a-530c-49f1-a1f9-981cda246cb9")) == null) {
				Columns.Add(CreatePaymentStatusColumn());
			}
			if (Columns.FindByUId(new Guid("dcf334e9-8a73-430b-ab97-17d9b9de64a3")) == null) {
				Columns.Add(CreateSupplierBillingInfoColumn());
			}
			if (Columns.FindByUId(new Guid("2a25b353-2d85-4ce6-b26e-894b514369ff")) == null) {
				Columns.Add(CreateRemindToOwnerColumn());
			}
			if (Columns.FindByUId(new Guid("e96ea96f-dc5d-4164-b182-e227978ac6e2")) == null) {
				Columns.Add(CreateRemindToOwnerDateColumn());
			}
			if (Columns.FindByUId(new Guid("8c7dd99b-d5c2-4cb5-ab16-84e1d0332ed6")) == null) {
				Columns.Add(CreateCustomerBillingInfoColumn());
			}
			if (Columns.FindByUId(new Guid("d7d9c859-18ad-408d-96ef-5a9f3090c168")) == null) {
				Columns.Add(CreateCurrencyColumn());
			}
			if (Columns.FindByUId(new Guid("734583ef-459f-45f5-9e5e-a1808e435fcf")) == null) {
				Columns.Add(CreateCurrencyRateColumn());
			}
			if (Columns.FindByUId(new Guid("ec9d2333-9e2d-4f70-b831-5be130a4b4ac")) == null) {
				Columns.Add(CreateAmountColumn());
			}
			if (Columns.FindByUId(new Guid("0d587626-2ccb-45e2-b582-27815c74f835")) == null) {
				Columns.Add(CreateDueDateColumn());
			}
			if (Columns.FindByUId(new Guid("07547348-9989-4367-9325-b1fa3281bf78")) == null) {
				Columns.Add(CreatePaymentAmountColumn());
			}
			if (Columns.FindByUId(new Guid("7c5a1586-bac8-433c-adda-30e45d8a71a4")) == null) {
				Columns.Add(CreateNotesColumn());
			}
			if (Columns.FindByUId(new Guid("b52f52a0-c983-4477-a4c3-6127cb052db4")) == null) {
				Columns.Add(CreateAccountColumn());
			}
			if (Columns.FindByUId(new Guid("8cf3941e-8061-42b9-80fa-d7936b228e84")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("2d36486c-1e97-434d-82f8-aed0e3162d8f")) == null) {
				Columns.Add(CreateSupplierColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5");
			return column;
		}

		protected virtual EntitySchemaColumn CreateNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("fdd77a82-fa25-4c0f-94d6-56cf0254521f"),
				Name = @"Number",
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				ModifiedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateStartDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("60364b7c-e7c4-43e3-81bf-5899e49a01aa"),
				Name = @"StartDate",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				ModifiedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentDate")
				}
			};
		}

		protected virtual EntitySchemaColumn CreatePrimaryAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("420f8d90-f6b1-4140-81b8-53e1f39d1379"),
				Name = @"PrimaryAmount",
				CreatedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				ModifiedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreatePrimaryPaymentAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("76ec81f5-b0ea-4a33-a4bc-eddd91d0dcca"),
				Name = @"PrimaryPaymentAmount",
				CreatedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				ModifiedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreatePaymentStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("77ce961a-530c-49f1-a1f9-981cda246cb9"),
				Name = @"PaymentStatus",
				ReferenceSchemaUId = new Guid("4a75f63d-e1b2-453b-a19d-fe614c158861"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				ModifiedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Settings,
					ValueSource = @"InvoicePaymentStatusDef"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateOwnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c3d2e53a-5062-4930-adac-7cbcd9d3f58c"),
				Name = @"Owner",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				ModifiedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentUserContact")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateSupplierBillingInfoColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("dcf334e9-8a73-430b-ab97-17d9b9de64a3"),
				Name = @"SupplierBillingInfo",
				ReferenceSchemaUId = new Guid("4f0e44ce-343c-45b6-ae14-ff0533d4add9"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				ModifiedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateRemindToOwnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("2a25b353-2d85-4ce6-b26e-894b514369ff"),
				Name = @"RemindToOwner",
				CreatedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				ModifiedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateRemindToOwnerDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("e96ea96f-dc5d-4164-b182-e227978ac6e2"),
				Name = @"RemindToOwnerDate",
				CreatedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				ModifiedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateCustomerBillingInfoColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8c7dd99b-d5c2-4cb5-ab16-84e1d0332ed6"),
				Name = @"CustomerBillingInfo",
				ReferenceSchemaUId = new Guid("4f0e44ce-343c-45b6-ae14-ff0533d4add9"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				ModifiedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateCurrencyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d7d9c859-18ad-408d-96ef-5a9f3090c168"),
				Name = @"Currency",
				ReferenceSchemaUId = new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				ModifiedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Settings,
					ValueSource = @"PrimaryCurrency"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateCurrencyRateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float8")) {
				UId = new Guid("734583ef-459f-45f5-9e5e-a1808e435fcf"),
				Name = @"CurrencyRate",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				ModifiedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"1"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("ec9d2333-9e2d-4f70-b831-5be130a4b4ac"),
				Name = @"Amount",
				CreatedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				ModifiedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateDueDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("0d587626-2ccb-45e2-b582-27815c74f835"),
				Name = @"DueDate",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				ModifiedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreatePaymentAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("07547348-9989-4367-9325-b1fa3281bf78"),
				Name = @"PaymentAmount",
				CreatedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				ModifiedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateNotesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("7c5a1586-bac8-433c-adda-30e45d8a71a4"),
				Name = @"Notes",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				ModifiedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b52f52a0-c983-4477-a4c3-6127cb052db4"),
				Name = @"Account",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				ModifiedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8cf3941e-8061-42b9-80fa-d7936b228e84"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				ModifiedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSupplierColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("2d36486c-1e97-434d-82f8-aed0e3162d8f"),
				Name = @"Supplier",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				ModifiedInSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"e308b781-3c5b-4ecb-89ef-5c1ed4da488e"
				}
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateInvoice_Invoice_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateInvoice_Invoice_TerrasoftEventsProcessSchema() {
			var schema = new Invoice_Invoice_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Invoice_Invoice_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Invoice_InvoiceEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Invoice_Invoice_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Invoice_Invoice_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"));
		}

		#endregion

	}

	#endregion

	#region Class: Invoice_Invoice_Terrasoft

	/// <summary>
	/// Invoice.
	/// </summary>
	public class Invoice_Invoice_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public Invoice_Invoice_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Invoice_Invoice_Terrasoft";
		}

		public Invoice_Invoice_Terrasoft(Invoice_Invoice_Terrasoft source)
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
		public DateTime StartDate {
			get {
				return GetTypedColumnValue<DateTime>("StartDate");
			}
			set {
				SetColumnValue("StartDate", value);
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

		/// <exclude/>
		public Guid PaymentStatusId {
			get {
				return GetTypedColumnValue<Guid>("PaymentStatusId");
			}
			set {
				SetColumnValue("PaymentStatusId", value);
				_paymentStatus = null;
			}
		}

		/// <exclude/>
		public string PaymentStatusName {
			get {
				return GetTypedColumnValue<string>("PaymentStatusName");
			}
			set {
				SetColumnValue("PaymentStatusName", value);
				if (_paymentStatus != null) {
					_paymentStatus.Name = value;
				}
			}
		}

		private InvoicePaymentStatus _paymentStatus;
		/// <summary>
		/// Payment status.
		/// </summary>
		public InvoicePaymentStatus PaymentStatus {
			get {
				return _paymentStatus ??
					(_paymentStatus = LookupColumnEntities.GetEntity("PaymentStatus") as InvoicePaymentStatus);
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

		/// <exclude/>
		public Guid SupplierBillingInfoId {
			get {
				return GetTypedColumnValue<Guid>("SupplierBillingInfoId");
			}
			set {
				SetColumnValue("SupplierBillingInfoId", value);
				_supplierBillingInfo = null;
			}
		}

		/// <exclude/>
		public string SupplierBillingInfoName {
			get {
				return GetTypedColumnValue<string>("SupplierBillingInfoName");
			}
			set {
				SetColumnValue("SupplierBillingInfoName", value);
				if (_supplierBillingInfo != null) {
					_supplierBillingInfo.Name = value;
				}
			}
		}

		private AccountBillingInfo _supplierBillingInfo;
		/// <summary>
		/// Supplier banking details.
		/// </summary>
		public AccountBillingInfo SupplierBillingInfo {
			get {
				return _supplierBillingInfo ??
					(_supplierBillingInfo = LookupColumnEntities.GetEntity("SupplierBillingInfo") as AccountBillingInfo);
			}
		}

		/// <summary>
		/// Remind owner.
		/// </summary>
		public bool RemindToOwner {
			get {
				return GetTypedColumnValue<bool>("RemindToOwner");
			}
			set {
				SetColumnValue("RemindToOwner", value);
			}
		}

		/// <summary>
		/// Remind owner on.
		/// </summary>
		public DateTime RemindToOwnerDate {
			get {
				return GetTypedColumnValue<DateTime>("RemindToOwnerDate");
			}
			set {
				SetColumnValue("RemindToOwnerDate", value);
			}
		}

		/// <exclude/>
		public Guid CustomerBillingInfoId {
			get {
				return GetTypedColumnValue<Guid>("CustomerBillingInfoId");
			}
			set {
				SetColumnValue("CustomerBillingInfoId", value);
				_customerBillingInfo = null;
			}
		}

		/// <exclude/>
		public string CustomerBillingInfoName {
			get {
				return GetTypedColumnValue<string>("CustomerBillingInfoName");
			}
			set {
				SetColumnValue("CustomerBillingInfoName", value);
				if (_customerBillingInfo != null) {
					_customerBillingInfo.Name = value;
				}
			}
		}

		private AccountBillingInfo _customerBillingInfo;
		/// <summary>
		/// Customer banking details.
		/// </summary>
		public AccountBillingInfo CustomerBillingInfo {
			get {
				return _customerBillingInfo ??
					(_customerBillingInfo = LookupColumnEntities.GetEntity("CustomerBillingInfo") as AccountBillingInfo);
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
		/// Paid on.
		/// </summary>
		public DateTime DueDate {
			get {
				return GetTypedColumnValue<DateTime>("DueDate");
			}
			set {
				SetColumnValue("DueDate", value);
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
			var process = new Invoice_InvoiceEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Invoice_Invoice_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("Invoice_Invoice_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("Invoice_Invoice_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("Invoice_Invoice_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("Invoice_Invoice_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Invoice_Invoice_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Invoice_Invoice_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Invoice_Invoice_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Invoice_InvoiceEventsProcess

	/// <exclude/>
	public partial class Invoice_InvoiceEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : Invoice_Invoice_Terrasoft
	{

		#region Class: GenerateNumberUserTaskFlowElement

		/// <exclude/>
		public class GenerateNumberUserTaskFlowElement : GenerateSequenseNumberUserTask
		{

			public GenerateNumberUserTaskFlowElement(UserConnection userConnection, Invoice_InvoiceEventsProcess<TEntity> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "GenerateNumberUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("8dab3385-2701-4725-80fc-27c54030fbf6");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: SynchronizeSubjectRemindingFlowElement

		/// <exclude/>
		public class SynchronizeSubjectRemindingFlowElement : SynchronizeSubjectRemindingUserTask
		{

			public SynchronizeSubjectRemindingFlowElement(UserConnection userConnection, Invoice_InvoiceEventsProcess<TEntity> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "SynchronizeSubjectReminding";
				IsLogging = false;
				SchemaElementUId = new Guid("3c6005fd-a117-442c-8427-c203d746ed51");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public Invoice_InvoiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Invoice_InvoiceEventsProcess";
			SchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual bool NeedFinRecalc {
			get;
			set;
		}

		public virtual bool IsOwnerChanged {
			get;
			set;
		}

		private ProcessFlowElement _subProcess2;
		public ProcessFlowElement SubProcess2 {
			get {
				return _subProcess2 ?? (_subProcess2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess2",
					SchemaElementUId = new Guid("600f4891-58d2-4768-9e09-fb50e58f391b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _invoiceSaved;
		public ProcessFlowElement InvoiceSaved {
			get {
				return _invoiceSaved ?? (_invoiceSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "InvoiceSaved",
					SchemaElementUId = new Guid("a681928e-edbd-45cb-a02d-2046ff936b42"),
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
					SchemaElementUId = new Guid("dc09bbd6-4778-42ac-a53e-a9ac7ab71b62"),
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
					SchemaElementUId = new Guid("e946380f-a4ba-41cd-8a57-555d70783d02"),
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
					SchemaElementUId = new Guid("8d23462f-1f9e-4374-8130-2c354ef753d5"),
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

		private ProcessEndEvent _end1;
		public ProcessEndEvent End1 {
			get {
				return _end1 ?? (_end1 = new ProcessEndEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEndEvent",
					Name = "End1",
					SchemaElementUId = new Guid("fbc67e68-18cc-4551-959c-98606e98c15f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _synchronizeRemindingsIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent SynchronizeRemindingsIntermediateThrowMessageEvent {
			get {
				return _synchronizeRemindingsIntermediateThrowMessageEvent ?? (_synchronizeRemindingsIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "SynchronizeRemindingsIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("d6c244f3-6c71-4628-b201-9d316e0e8a49"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "SynchronizeRemindings",
				});
			}
		}

		private ProcessFlowElement _invoiceDeletingStartMessage;
		public ProcessFlowElement InvoiceDeletingStartMessage {
			get {
				return _invoiceDeletingStartMessage ?? (_invoiceDeletingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "InvoiceDeletingStartMessage",
					SchemaElementUId = new Guid("24d8d007-ed4b-428c-b143-a6419ac70a1e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _invoiceDeletingScriptTask;
		public ProcessScriptTask InvoiceDeletingScriptTask {
			get {
				return _invoiceDeletingScriptTask ?? (_invoiceDeletingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InvoiceDeletingScriptTask",
					SchemaElementUId = new Guid("4035ee82-8704-4bdb-86f7-d6343ca90aea"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InvoiceDeletingScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _synchronizeRemindingsOnDeleteIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent SynchronizeRemindingsOnDeleteIntermediateThrowMessageEvent {
			get {
				return _synchronizeRemindingsOnDeleteIntermediateThrowMessageEvent ?? (_synchronizeRemindingsOnDeleteIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "SynchronizeRemindingsOnDeleteIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("e9fbc8ee-59a6-4cb2-9082-a1d2c0c2a761"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "SynchronizeRemindings",
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
					SchemaElementUId = new Guid("8a7fb915-f0b7-41c0-a267-c16e4e43a453"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = FinanceRecalculationScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessInvoiceSaving;
		public ProcessFlowElement EventSubProcessInvoiceSaving {
			get {
				return _eventSubProcessInvoiceSaving ?? (_eventSubProcessInvoiceSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessInvoiceSaving",
					SchemaElementUId = new Guid("24930fed-85ce-4bac-b106-80b153e77f60"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _invoiceSaving;
		public ProcessFlowElement InvoiceSaving {
			get {
				return _invoiceSaving ?? (_invoiceSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "InvoiceSaving",
					SchemaElementUId = new Guid("25ec6644-43bc-41f6-a035-41533607406f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptInvoiceSaving;
		public ProcessScriptTask ScriptInvoiceSaving {
			get {
				return _scriptInvoiceSaving ?? (_scriptInvoiceSaving = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptInvoiceSaving",
					SchemaElementUId = new Guid("d62bc1f1-6877-47dd-9867-08a945bf15f9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptInvoiceSavingExecute,
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
					SchemaElementUId = new Guid("3918b5f8-efc0-4125-9866-2873e64f7def"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
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
					SchemaElementUId = new Guid("b08ae33b-1834-4fec-baba-6243dd7f9bd8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _synchronizeRemindingsStartMessage;
		public ProcessFlowElement SynchronizeRemindingsStartMessage {
			get {
				return _synchronizeRemindingsStartMessage ?? (_synchronizeRemindingsStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SynchronizeRemindingsStartMessage",
					SchemaElementUId = new Guid("c759c244-a35b-4ccd-bf1c-4828672c1207"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptInvoiceSaved;
		public ProcessScriptTask ScriptInvoiceSaved {
			get {
				return _scriptInvoiceSaved ?? (_scriptInvoiceSaved = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptInvoiceSaved",
					SchemaElementUId = new Guid("4c57ec31-3ad8-4db2-ab54-cb1e6e947b63"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptInvoiceSavedExecute,
				});
			}
		}

		private SynchronizeSubjectRemindingFlowElement _synchronizeSubjectReminding;
		public SynchronizeSubjectRemindingFlowElement SynchronizeSubjectReminding {
			get {
				return _synchronizeSubjectReminding ?? (_synchronizeSubjectReminding = new SynchronizeSubjectRemindingFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessConditionalFlow _conditionalFlow1232;
		public ProcessConditionalFlow ConditionalFlow1232 {
			get {
				return _conditionalFlow1232 ?? (_conditionalFlow1232 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow1232",
					SchemaElementUId = new Guid("ce0e476f-1e81-402c-ba88-17acc054f388"),
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
			FlowElements[SubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess2 };
			FlowElements[InvoiceSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { InvoiceSaved };
			FlowElements[SetGenerateParamScript.SchemaElementUId] = new Collection<ProcessFlowElement> { SetGenerateParamScript };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[SetGeneratedNumberScript.SchemaElementUId] = new Collection<ProcessFlowElement> { SetGeneratedNumberScript };
			FlowElements[GenerateNumberUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { GenerateNumberUserTask };
			FlowElements[End1.SchemaElementUId] = new Collection<ProcessFlowElement> { End1 };
			FlowElements[SynchronizeRemindingsIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { SynchronizeRemindingsIntermediateThrowMessageEvent };
			FlowElements[InvoiceDeletingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { InvoiceDeletingStartMessage };
			FlowElements[InvoiceDeletingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InvoiceDeletingScriptTask };
			FlowElements[SynchronizeRemindingsOnDeleteIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { SynchronizeRemindingsOnDeleteIntermediateThrowMessageEvent };
			FlowElements[FinanceRecalculationScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { FinanceRecalculationScriptTask };
			FlowElements[EventSubProcessInvoiceSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessInvoiceSaving };
			FlowElements[InvoiceSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { InvoiceSaving };
			FlowElements[ScriptInvoiceSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptInvoiceSaving };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[SynchronizeRemindingsStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SynchronizeRemindingsStartMessage };
			FlowElements[ScriptInvoiceSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptInvoiceSaved };
			FlowElements[SynchronizeSubjectReminding.SchemaElementUId] = new Collection<ProcessFlowElement> { SynchronizeSubjectReminding };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SubProcess2":
						break;
					case "InvoiceSaved":
						e.Context.QueueTasks.Enqueue("SetGenerateParamScript");
						e.Context.QueueTasks.Enqueue("SynchronizeRemindingsIntermediateThrowMessageEvent");
						e.Context.QueueTasks.Enqueue("FinanceRecalculationScriptTask");
						break;
					case "SetGenerateParamScript":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway1");
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow1232ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("GenerateNumberUserTask");
							break;
						}
						e.Context.QueueTasks.Enqueue("End1");
						break;
					case "SetGeneratedNumberScript":
						break;
					case "GenerateNumberUserTask":
							e.Context.QueueTasks.Enqueue("SetGeneratedNumberScript");
						break;
					case "End1":
						break;
					case "SynchronizeRemindingsIntermediateThrowMessageEvent":
						break;
					case "InvoiceDeletingStartMessage":
						e.Context.QueueTasks.Enqueue("InvoiceDeletingScriptTask");
						break;
					case "InvoiceDeletingScriptTask":
						e.Context.QueueTasks.Enqueue("SynchronizeRemindingsOnDeleteIntermediateThrowMessageEvent");
						break;
					case "SynchronizeRemindingsOnDeleteIntermediateThrowMessageEvent":
						break;
					case "FinanceRecalculationScriptTask":
						break;
					case "EventSubProcessInvoiceSaving":
						break;
					case "InvoiceSaving":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "ScriptInvoiceSaving":
						break;
					case "ScriptTask1":
						e.Context.QueueTasks.Enqueue("ScriptInvoiceSaving");
						break;
					case "EventSubProcess1":
						break;
					case "SynchronizeRemindingsStartMessage":
						e.Context.QueueTasks.Enqueue("ScriptInvoiceSaved");
						break;
					case "ScriptInvoiceSaved":
						e.Context.QueueTasks.Enqueue("SynchronizeSubjectReminding");
						break;
					case "SynchronizeSubjectReminding":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalFlow1232ExpressionExecute() {
			return Convert.ToBoolean(string.IsNullOrEmpty(Entity.GetTypedColumnValue<string>("Number")));
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("InvoiceSaved");
			ActivatedEventElements.Add("InvoiceDeletingStartMessage");
			ActivatedEventElements.Add("InvoiceSaving");
			ActivatedEventElements.Add("SynchronizeRemindingsStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "InvoiceSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "InvoiceSaved";
					result = InvoiceSaved.Execute(context);
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
				case "End1":
					context.QueueTasks.Dequeue();
					break;
				case "SynchronizeRemindingsIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					result = SynchronizeRemindingsIntermediateThrowMessageEvent.Execute(context);
					break;
				case "InvoiceDeletingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "InvoiceDeletingStartMessage";
					result = InvoiceDeletingStartMessage.Execute(context);
					break;
				case "InvoiceDeletingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "InvoiceDeletingScriptTask";
					result = InvoiceDeletingScriptTask.Execute(context, InvoiceDeletingScriptTaskExecute);
					break;
				case "SynchronizeRemindingsOnDeleteIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					result = SynchronizeRemindingsOnDeleteIntermediateThrowMessageEvent.Execute(context);
					break;
				case "FinanceRecalculationScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "FinanceRecalculationScriptTask";
					result = FinanceRecalculationScriptTask.Execute(context, FinanceRecalculationScriptTaskExecute);
					break;
				case "EventSubProcessInvoiceSaving":
					context.QueueTasks.Dequeue();
					break;
				case "InvoiceSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "InvoiceSaving";
					result = InvoiceSaving.Execute(context);
					break;
				case "ScriptInvoiceSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptInvoiceSaving";
					result = ScriptInvoiceSaving.Execute(context, ScriptInvoiceSavingExecute);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
					break;
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "SynchronizeRemindingsStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SynchronizeRemindingsStartMessage";
					result = SynchronizeRemindingsStartMessage.Execute(context);
					break;
				case "ScriptInvoiceSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptInvoiceSaved";
					result = ScriptInvoiceSaved.Execute(context, ScriptInvoiceSavedExecute);
					break;
				case "SynchronizeSubjectReminding":
					context.QueueTasks.Dequeue();
					context.SenderName = "SynchronizeSubjectReminding";
					result = SynchronizeSubjectReminding.Execute(context);
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
				case "IsOwnerChanged":
					IsOwnerChanged = reader.GetValue<System.Boolean>();
				break;
				case "NeedFinRecalc":
					NeedFinRecalc = reader.GetValue<System.Boolean>();
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

		public virtual bool InvoiceDeletingScriptTaskExecute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool FinanceRecalculationScriptTaskExecute(ProcessExecutingContext context) {
			OnSaved();
			return true;
		}

		public virtual bool ScriptInvoiceSavingExecute(ProcessExecutingContext context) {
			OnSaving();
			return true;
		}

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			return UpdatePrimaryAmount();
		}

		public virtual bool ScriptInvoiceSavedExecute(ProcessExecutingContext context) {
			var active = !Entity.IsInDeleting && !IsFinalStatus() && Entity.GetTypedColumnValue<bool>("RemindToOwner");
			var ownerRemindingSourceTypeId = "a76d08e1-2e2d-e011-ac0a-00155d043205";
			SynchronizeSubjectReminding.Active = active;
			SynchronizeSubjectReminding.SubjectPrimaryColumnValue = Entity.GetTypedColumnValue<Guid>("Id");
			SynchronizeSubjectReminding.Contact = Entity.GetTypedColumnValue<Guid>("OwnerId");
			SynchronizeSubjectReminding.Source = new Guid(ownerRemindingSourceTypeId);
			SynchronizeSubjectReminding.RemindTime = Entity.GetTypedColumnValue<DateTime>("RemindToOwnerDate");
			SynchronizeSubjectReminding.SysEntitySchema = Entity.Schema.UId;
			SynchronizeSubjectReminding.NotificationType = RemindingConsts.NotificationTypeRemindingId;
			if (UserConnection.GetIsFeatureEnabled("NotificationV2") && active) {
				IRemindingTextFormer textFormer = ClassFactory.Get<InvoiceRemindingTextFormer>(
					new ConstructorArgument("userConnection", UserConnection));
				string invoiceNumber = Entity.GetTypedColumnValue<string>("Number");
				DateTime startDate = Entity.GetTypedColumnValue<DateTime>("StartDate");
				string accountName = GetLookupDisplayColumnValue(Entity, "Account");
				string contactName = GetLookupDisplayColumnValue(Entity, "Contact");
				SynchronizeSubjectReminding.SubjectCaption =  textFormer.GetBody(new Dictionary<string, object> {
					{"Number", invoiceNumber},
					{"StartDate", startDate},
					{"AccountName", accountName},
					{"ContactName", contactName}
				});
				SynchronizeSubjectReminding.Description = invoiceNumber;
				SynchronizeSubjectReminding.PopupTitle = textFormer.GetTitle(null);
				SynchronizeSubjectReminding.IsSingleReminder = IsOwnerChanged;
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Invoice_Invoice_TerrasoftSaved":
							if (ActivatedEventElements.Contains("InvoiceSaved")) {
							context.QueueTasks.Enqueue("InvoiceSaved");
						}
						break;
					case "Invoice_Invoice_TerrasoftDeleting":
							if (ActivatedEventElements.Contains("InvoiceDeletingStartMessage")) {
							context.QueueTasks.Enqueue("InvoiceDeletingStartMessage");
						}
						break;
					case "Invoice_Invoice_TerrasoftSaving":
							if (ActivatedEventElements.Contains("InvoiceSaving")) {
							context.QueueTasks.Enqueue("InvoiceSaving");
						}
						break;
					case "SynchronizeRemindings":
							if (ActivatedEventElements.Contains("SynchronizeRemindingsStartMessage")) {
							context.QueueTasks.Enqueue("SynchronizeRemindingsStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("IsOwnerChanged") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsOwnerChanged", IsOwnerChanged, false);
			}
			if (!HasMapping("NeedFinRecalc") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("NeedFinRecalc", NeedFinRecalc, false);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: Invoice_InvoiceEventsProcess

	/// <exclude/>
	public class Invoice_InvoiceEventsProcess : Invoice_InvoiceEventsProcess<Invoice_Invoice_Terrasoft>
	{

		public Invoice_InvoiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Invoice_InvoiceEventsProcess

	public partial class Invoice_InvoiceEventsProcess<TEntity>
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

		public virtual bool IsFinalStatus() {
			var statusId = Entity.GetTypedColumnValue<Guid>("PaymentStatusId");
			var entitySchemaQuery = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "InvoicePaymentStatus");
			var finalColumnName = entitySchemaQuery.AddColumn("FinalStatus").Name;
			var entity = entitySchemaQuery.GetEntity(UserConnection, statusId);
			if (entity != null) {
				return entity.GetTypedColumnValue<bool>(finalColumnName);
			}
			return false;
		}

		public virtual void OnSaving() {
			if (Entity.StoringState == StoringObjectState.New) {
				return;
			}
			NeedFinRecalc = false;
			var oldCurrencyRate = Entity.GetTypedOldColumnValue<decimal>("CurrencyRate");
			var newCurrencyRate = Entity.GetTypedColumnValue<decimal>("CurrencyRate");
			var oldCurrency = Entity.GetTypedOldColumnValue<Guid>("CurrencyId");
			var newCurrency = Entity.GetTypedColumnValue<Guid>("CurrencyId");
			NeedFinRecalc = (oldCurrencyRate != newCurrencyRate) || (oldCurrency != newCurrency);
			
			var oldOwnerId = Entity.GetTypedOldColumnValue<Guid>("OwnerId");
			var newOwnerId = Entity.GetTypedColumnValue<Guid>("OwnerId");
			if (!oldOwnerId.Equals(newOwnerId)) {
				IsOwnerChanged = true;
			}
		}

		public virtual void OnSaved() {
			if (NeedFinRecalc) {
				ProductEntryUtils utils = Core.Factories.ClassFactory.Get<ProductEntryUtils>(new Core.Factories.ConstructorArgument("userConnection", UserConnection));
				utils.UpdateRecordProductAmounts(Entity);
			}
		}

		public virtual bool UpdatePrimaryAmount() {
			var amount = Entity.GetTypedColumnValue<decimal>("Amount");
			var primaryAmount = Entity.GetTypedColumnValue<decimal>("PrimaryAmount");
			if (primaryAmount != 0 || amount == 0) {
				return true;
			}
			Guid currencyId = Entity.GetTypedColumnValue<Guid>("CurrencyId");
			DateTime startDate = Entity.GetTypedColumnValue<DateTime>("StartDate");
			var currencyRateStorage = Terrasoft.Core.Factories.ClassFactory.Get<Terrasoft.Configuration.CurrencyRateStorage>(
				new Terrasoft.Core.Factories.ConstructorArgument("userConnection", UserConnection));
			var currencyInfo = currencyRateStorage.GetActualCurrencyRates(currencyId).FirstOrDefault();
			if (currencyInfo != null) {
				decimal currencyRate = Terrasoft.Configuration.CurrencyRateHelper.SetMantissaToRate(currencyInfo.Rate, currencyInfo.RateMantissa);
				int currencyDivision = currencyInfo.Division;
				if (currencyDivision != 0) {
					primaryAmount = amount * currencyDivision / currencyRate;
					Entity.SetColumnValue("PrimaryAmount", primaryAmount);
					Entity.SetColumnValue("CurrencyRate", currencyRate);
				}
			}
			return true;
		}

		public virtual string GetLookupDisplayColumnValue(Entity entity, string lookupName) {
			var rootEntitySchema = entity.Schema;
			var result = string.Empty;
			try {
				var rootEntityColumn = rootEntitySchema.Columns.GetByName(lookupName);
				var recordId = entity.GetTypedColumnValue<Guid>(rootEntityColumn.ColumnValueName);
				result = recordId.IsNotEmpty() 
					? GetFetchedDisplayColumnValue(entity, lookupName, recordId)
					: string.Empty;
			} catch (Exception ex) {
				result = string.Empty;
			}
			return result;
		}

		public virtual string GetFetchedDisplayColumnValue(Entity entity, string lookupName, Guid recordId) {
			var userConnection = entity.UserConnection;
			var lookupEntitySchema = userConnection.EntitySchemaManager.FindInstanceByName(lookupName);
			var lookupEntity = lookupEntitySchema.CreateEntity(userConnection);
			lookupEntity.FetchPrimaryInfoFromDB(lookupEntitySchema.GetPrimaryColumnName(), recordId);
			return lookupEntity.PrimaryDisplayColumnValue;
		}

		#endregion

	}

	#endregion

	#region Class: Invoice_Invoice_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Invoice_Invoice_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public Invoice_Invoice_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Invoice_Invoice_TerrasoftEventsProcessSchema(Invoice_Invoice_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Invoice_InvoiceEventsProcess";
			UId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637");
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

		protected virtual ProcessSchemaParameter CreateNeedFinRecalcParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7f79c85f-9966-47b6-a628-b1fb06201684"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				Name = @"NeedFinRecalc",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsOwnerChangedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c45f8468-5a33-4e3a-a08d-4db91158763f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				Name = @"IsOwnerChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateNeedFinRecalcParameter());
			Parameters.Add(CreateIsOwnerChangedParameter());
		}

		protected virtual void InitializeGenerateNumberUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("85c3cacb-1c64-437d-86aa-a4df139eb359"),
				ContainerUId = new Guid("8dab3385-2701-4725-80fc-27c54030fbf6"),
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
				UId = new Guid("bac9ddf4-1cec-4bbf-b45c-5dec851dd6f1"),
				ContainerUId = new Guid("8dab3385-2701-4725-80fc-27c54030fbf6"),
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

		protected virtual void InitializeSynchronizeSubjectRemindingParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("7668bda0-4c7c-43fc-a092-675416d5810f"),
				ContainerUId = new Guid("3c6005fd-a117-442c-8427-c203d746ed51"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"Active",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("32f6818a-b662-4b32-b7b5-5172d4677d6e"),
				ContainerUId = new Guid("3c6005fd-a117-442c-8427-c203d746ed51"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"SubjectPrimaryColumnValue",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("dd3d7c46-2a47-423e-a925-db1f5276843c"),
				ContainerUId = new Guid("3c6005fd-a117-442c-8427-c203d746ed51"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"Author",
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
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("79968a79-9ddb-49a4-b9f7-b2efe797f9f6"),
				ContainerUId = new Guid("3c6005fd-a117-442c-8427-c203d746ed51"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"Contact",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("01d8e057-ba7b-40ab-9d3d-85b46113bf92"),
				ContainerUId = new Guid("3c6005fd-a117-442c-8427-c203d746ed51"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"Source",
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
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("33ed3930-bc80-4a46-8177-46d3feeeba35"),
				ContainerUId = new Guid("3c6005fd-a117-442c-8427-c203d746ed51"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"RemindTime",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("688391a9-0226-4ac0-82c8-ada4a4e87d4c"),
				ContainerUId = new Guid("3c6005fd-a117-442c-8427-c203d746ed51"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"Description",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("925b663c-312e-4df7-82e7-742c9aaca689"),
				ContainerUId = new Guid("3c6005fd-a117-442c-8427-c203d746ed51"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"SysEntitySchema",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("76ac8c4b-9d51-40ff-8f70-2787510d4592"),
				ContainerUId = new Guid("3c6005fd-a117-442c-8427-c203d746ed51"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"SubjectCaption",
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
				UId = new Guid("93984d84-fa33-4a52-a041-c6db51bdd733"),
				ContainerUId = new Guid("3c6005fd-a117-442c-8427-c203d746ed51"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"TypeCaption",
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
				UId = new Guid("e71188ad-0980-4779-b565-be0f4689ebf6"),
				ContainerUId = new Guid("3c6005fd-a117-442c-8427-c203d746ed51"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"IsListSubjectReminds",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = @"",
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("95aaad20-fede-4866-9c14-5033bc1ab011"),
				ContainerUId = new Guid("3c6005fd-a117-442c-8427-c203d746ed51"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"IsSubjectDelete",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = @"",
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("463f3341-fe32-484f-841f-6fc09f71d2f4"),
				ContainerUId = new Guid("3c6005fd-a117-442c-8427-c203d746ed51"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"NotificationType",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = @"",
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("44e2d35c-f134-48fa-9f98-de3a146c2096"),
				ContainerUId = new Guid("3c6005fd-a117-442c-8427-c203d746ed51"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"PopupTitle",
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
				UId = new Guid("b67f44f0-df51-4af3-9d4d-a6211a6cb454"),
				ContainerUId = new Guid("3c6005fd-a117-442c-8427-c203d746ed51"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"IsSingleReminder",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = @"",
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet393 = CreateLaneSet393LaneSet();
			LaneSets.Add(schemaLaneSet393);
			ProcessSchemaLane schemaLane1191 = CreateLane1191Lane();
			schemaLaneSet393.Lanes.Add(schemaLane1191);
			ProcessSchemaEventSubProcess subprocess2 = CreateSubProcess2EventSubProcess();
			FlowElements.Add(subprocess2);
			ProcessSchemaEventSubProcess eventsubprocessinvoicesaving = CreateEventSubProcessInvoiceSavingEventSubProcess();
			FlowElements.Add(eventsubprocessinvoicesaving);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaStartMessageEvent invoicesaved = CreateInvoiceSavedStartMessageEvent();
			subprocess2.FlowElements.Add(invoicesaved);
			ProcessSchemaScriptTask setgenerateparamscript = CreateSetGenerateParamScriptScriptTask();
			subprocess2.FlowElements.Add(setgenerateparamscript);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			subprocess2.FlowElements.Add(exclusivegateway1);
			ProcessSchemaScriptTask setgeneratednumberscript = CreateSetGeneratedNumberScriptScriptTask();
			subprocess2.FlowElements.Add(setgeneratednumberscript);
			ProcessSchemaUserTask generatenumberusertask = CreateGenerateNumberUserTaskUserTask();
			subprocess2.FlowElements.Add(generatenumberusertask);
			ProcessSchemaEndEvent end1 = CreateEnd1EndEvent();
			subprocess2.FlowElements.Add(end1);
			ProcessSchemaIntermediateThrowMessageEvent synchronizeremindingsintermediatethrowmessageevent = CreateSynchronizeRemindingsIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			subprocess2.FlowElements.Add(synchronizeremindingsintermediatethrowmessageevent);
			ProcessSchemaStartMessageEvent invoicedeletingstartmessage = CreateInvoiceDeletingStartMessageStartMessageEvent();
			subprocess2.FlowElements.Add(invoicedeletingstartmessage);
			ProcessSchemaScriptTask invoicedeletingscripttask = CreateInvoiceDeletingScriptTaskScriptTask();
			subprocess2.FlowElements.Add(invoicedeletingscripttask);
			ProcessSchemaIntermediateThrowMessageEvent synchronizeremindingsondeleteintermediatethrowmessageevent = CreateSynchronizeRemindingsOnDeleteIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			subprocess2.FlowElements.Add(synchronizeremindingsondeleteintermediatethrowmessageevent);
			ProcessSchemaScriptTask financerecalculationscripttask = CreateFinanceRecalculationScriptTaskScriptTask();
			subprocess2.FlowElements.Add(financerecalculationscripttask);
			ProcessSchemaStartMessageEvent invoicesaving = CreateInvoiceSavingStartMessageEvent();
			eventsubprocessinvoicesaving.FlowElements.Add(invoicesaving);
			ProcessSchemaScriptTask scriptinvoicesaving = CreateScriptInvoiceSavingScriptTask();
			eventsubprocessinvoicesaving.FlowElements.Add(scriptinvoicesaving);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			eventsubprocessinvoicesaving.FlowElements.Add(scripttask1);
			ProcessSchemaStartMessageEvent synchronizeremindingsstartmessage = CreateSynchronizeRemindingsStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(synchronizeremindingsstartmessage);
			ProcessSchemaScriptTask scriptinvoicesaved = CreateScriptInvoiceSavedScriptTask();
			eventsubprocess1.FlowElements.Add(scriptinvoicesaved);
			ProcessSchemaUserTask synchronizesubjectreminding = CreateSynchronizeSubjectRemindingUserTask();
			eventsubprocess1.FlowElements.Add(synchronizesubjectreminding);
			FlowElements.Add(CreateSynchronizeRemindingsSequenceFlowSequenceFlow());
			FlowElements.Add(CreateSynchronizeRemindingsSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateCalcPrimaryAmountToSequenceFlow());
			FlowElements.Add(CreateSequenceFlow1111SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2322SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1232ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow3321SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4223SequenceFlow());
			FlowElements.Add(CreateSynchronizeRemindingsSavedSequenceFlowSequenceFlow());
			FlowElements.Add(CreateInvoiceDeletingSequenceFlowSequenceFlow());
			FlowElements.Add(CreateInvoiceDeletingSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateCalcPrimaryAmountFromSequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSynchronizeRemindingsSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SynchronizeRemindingsSequenceFlow",
				UId = new Guid("ebfb49df-55c9-4d50-b4fd-ab528736a007"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				CurveCenterPosition = new Point(168, 264),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c759c244-a35b-4ccd-bf1c-4828672c1207"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4c57ec31-3ad8-4db2-ab54-cb1e6e947b63"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSynchronizeRemindingsSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SynchronizeRemindingsSequenceFlow2",
				UId = new Guid("17c5e265-b161-4a36-8a5f-8317da624b7d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				CurveCenterPosition = new Point(324, 263),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4c57ec31-3ad8-4db2-ab54-cb1e6e947b63"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3c6005fd-a117-442c-8427-c203d746ed51"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateCalcPrimaryAmountToSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "CalcPrimaryAmountTo",
				UId = new Guid("f7700885-ac28-44bf-94c6-0b074aef3a49"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				CurveCenterPosition = new Point(144, 96),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("25ec6644-43bc-41f6-a035-41533607406f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3918b5f8-efc0-4125-9866-2873e64f7def"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1111SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1111",
				UId = new Guid("93400cd9-23e9-4b61-b3b6-8cb710077dc9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				CurveCenterPosition = new Point(130, 339),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a681928e-edbd-45cb-a02d-2046ff936b42"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("dc09bbd6-4778-42ac-a53e-a9ac7ab71b62"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2322SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2322",
				UId = new Guid("4fe9e8eb-55d1-452b-a888-86b86321a56e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				CurveCenterPosition = new Point(268, 400),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dc09bbd6-4778-42ac-a53e-a9ac7ab71b62"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e946380f-a4ba-41cd-8a57-555d70783d02"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1232ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1232",
				UId = new Guid("ce0e476f-1e81-402c-ba88-17acc054f388"),
				ConditionExpression = @"string.IsNullOrEmpty(Entity.GetTypedColumnValue<string>(""Number""))",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				CurveCenterPosition = new Point(375, 400),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e946380f-a4ba-41cd-8a57-555d70783d02"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8dab3385-2701-4725-80fc-27c54030fbf6"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3321SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3321",
				UId = new Guid("ef0b21a2-699c-4085-8d8f-7ea33145ac73"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				CurveCenterPosition = new Point(496, 400),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8dab3385-2701-4725-80fc-27c54030fbf6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8d23462f-1f9e-4374-8130-2c354ef753d5"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4223SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow4223",
				UId = new Guid("292e72ee-3f96-4722-a88b-8b97c52a2ed9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				CurveCenterPosition = new Point(323, 454),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e946380f-a4ba-41cd-8a57-555d70783d02"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fbc67e68-18cc-4551-959c-98606e98c15f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSynchronizeRemindingsSavedSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SynchronizeRemindingsSavedSequenceFlow",
				UId = new Guid("24abaf1c-d70b-4aea-8d28-87e987b98cbe"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8a3e6264-0c74-497d-8a11-cebe83e81070"),
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				CurveCenterPosition = new Point(152, 268),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a681928e-edbd-45cb-a02d-2046ff936b42"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d6c244f3-6c71-4628-b201-9d316e0e8a49"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(113, 481));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateInvoiceDeletingSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "InvoiceDeletingSequenceFlow",
				UId = new Guid("6e869ad8-9e6a-41c8-8693-6c2956fc3383"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8a3e6264-0c74-497d-8a11-cebe83e81070"),
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				CurveCenterPosition = new Point(157, 484),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("24d8d007-ed4b-428c-b143-a6419ac70a1e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4035ee82-8704-4bdb-86f7-d6343ca90aea"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateInvoiceDeletingSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "InvoiceDeletingSequenceFlow2",
				UId = new Guid("57106d6f-325a-4aac-8b84-82b4668596f3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8a3e6264-0c74-497d-8a11-cebe83e81070"),
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				CurveCenterPosition = new Point(284, 484),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4035ee82-8704-4bdb-86f7-d6343ca90aea"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e9fbc8ee-59a6-4cb2-9082-a1d2c0c2a761"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("89e34f01-096c-46dd-936d-13b3089da062"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("40620cec-072b-4865-b05c-978dcd5f52b4"),
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				CurveCenterPosition = new Point(172, 350),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a681928e-edbd-45cb-a02d-2046ff936b42"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8a7fb915-f0b7-41c0-a267-c16e4e43a453"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(113, 530));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateCalcPrimaryAmountFromSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "CalcPrimaryAmountFrom",
				UId = new Guid("a2bf84c4-7ab0-43bb-b314-e92eaa182a6c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("5f05e5ce-515a-40bc-b6f5-74b884e9a4aa"),
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3918b5f8-efc0-4125-9866-2873e64f7def"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d62bc1f1-6877-47dd-9867-08a945bf15f9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet393LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet393 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("cb711f70-8998-48fc-a73e-b2605e94b7d6"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				Name = @"LaneSet393",
				Position = new Point(5, 5),
				Size = new Size(1576, 571),
				UseBackgroundMode = false
			};
			return schemaLaneSet393;
		}

		protected virtual ProcessSchemaLane CreateLane1191Lane() {
			ProcessSchemaLane schemaLane1191 = new ProcessSchemaLane(this) {
				UId = new Guid("cbaf6684-24d5-444d-bdd2-4745d143b5e3"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("cb711f70-8998-48fc-a73e-b2605e94b7d6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				Name = @"Lane1191",
				Position = new Point(29, 0),
				Size = new Size(1547, 571),
				UseBackgroundMode = false
			};
			return schemaLane1191;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("600f4891-58d2-4768-9e09-fb50e58f391b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cbaf6684-24d5-444d-bdd2-4745d143b5e3"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				Name = @"SubProcess2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(80, 300),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(611, 373),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInvoiceSavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a681928e-edbd-45cb-a02d-2046ff936b42"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("600f4891-58d2-4768-9e09-fb50e58f391b"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"InvoiceSaved",
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				Name = @"InvoiceSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSetGenerateParamScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("dc09bbd6-4778-42ac-a53e-a9ac7ab71b62"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("600f4891-58d2-4768-9e09-fb50e58f391b"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				Name = @"SetGenerateParamScript",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(112, 49),
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
				UId = new Guid("e946380f-a4ba-41cd-8a57-555d70783d02"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("600f4891-58d2-4768-9e09-fb50e58f391b"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(238, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateSetGeneratedNumberScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8d23462f-1f9e-4374-8130-2c354ef753d5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("600f4891-58d2-4768-9e09-fb50e58f391b"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				Name = @"SetGeneratedNumberScript",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(497, 49),
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
				UId = new Guid("8dab3385-2701-4725-80fc-27c54030fbf6"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("600f4891-58d2-4768-9e09-fb50e58f391b"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				Name = @"GenerateNumberUserTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(357, 49),
				SchemaUId = new Guid("b9b23348-b89c-4836-8c5b-283ef5ed8666"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeGenerateNumberUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEndEvent CreateEnd1EndEvent() {
			ProcessSchemaEndEvent schemaEndEvent = new ProcessSchemaEndEvent(this) {
				UId = new Guid("fbc67e68-18cc-4551-959c-98606e98c15f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("600f4891-58d2-4768-9e09-fb50e58f391b"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("45ceaae2-4e1f-4c0c-86aa-cd4aeb4da913"),
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				Name = @"End1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(252, 154),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaEndEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateSynchronizeRemindingsIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("d6c244f3-6c71-4628-b201-9d316e0e8a49"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("600f4891-58d2-4768-9e09-fb50e58f391b"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8a3e6264-0c74-497d-8a11-cebe83e81070"),
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"SynchronizeRemindings",
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				Name = @"SynchronizeRemindingsIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(63, 168),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInvoiceDeletingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("24d8d007-ed4b-428c-b143-a6419ac70a1e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("600f4891-58d2-4768-9e09-fb50e58f391b"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8a3e6264-0c74-497d-8a11-cebe83e81070"),
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"InvoiceDeleting",
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				Name = @"InvoiceDeletingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 280),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInvoiceDeletingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4035ee82-8704-4bdb-86f7-d6343ca90aea"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("600f4891-58d2-4768-9e09-fb50e58f391b"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8a3e6264-0c74-497d-8a11-cebe83e81070"),
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				Name = @"InvoiceDeletingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(105, 266),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateSynchronizeRemindingsOnDeleteIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("e9fbc8ee-59a6-4cb2-9082-a1d2c0c2a761"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("600f4891-58d2-4768-9e09-fb50e58f391b"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8a3e6264-0c74-497d-8a11-cebe83e81070"),
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"SynchronizeRemindings",
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				Name = @"SynchronizeRemindingsOnDeleteIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(231, 280),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateFinanceRecalculationScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8a7fb915-f0b7-41c0-a267-c16e4e43a453"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("600f4891-58d2-4768-9e09-fb50e58f391b"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("40620cec-072b-4865-b05c-978dcd5f52b4"),
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				Name = @"FinanceRecalculationScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(322, 203),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,11,78,44,75,77,209,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,30,55,8,237,24,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessInvoiceSavingEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessInvoiceSaving = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("24930fed-85ce-4bac-b106-80b153e77f60"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cbaf6684-24d5-444d-bdd2-4745d143b5e3"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				Name = @"EventSubProcessInvoiceSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(80, 79),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(341, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessInvoiceSaving;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInvoiceSavingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("25ec6644-43bc-41f6-a035-41533607406f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("24930fed-85ce-4bac-b106-80b153e77f60"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"InvoiceSaving",
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				Name = @"InvoiceSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 38),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptInvoiceSavingScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d62bc1f1-6877-47dd-9867-08a945bf15f9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("24930fed-85ce-4bac-b106-80b153e77f60"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				Name = @"ScriptInvoiceSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(224, 24),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,11,78,44,203,204,75,215,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,67,6,145,232,25,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3918b5f8-efc0-4125-9866-2873e64f7def"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("24930fed-85ce-4bac-b106-80b153e77f60"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("5f05e5ce-515a-40bc-b6f5-74b884e9a4aa"),
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				Name = @"ScriptTask1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(109, 24),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,8,45,72,73,44,73,13,40,202,204,77,44,170,116,204,205,47,205,43,209,208,180,6,0,133,138,255,238,29,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b08ae33b-1834-4fec-baba-6243dd7f9bd8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cbaf6684-24d5-444d-bdd2-4745d143b5e3"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8a3e6264-0c74-497d-8a11-cebe83e81070"),
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(473, 86),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(388, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSynchronizeRemindingsStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c759c244-a35b-4ccd-bf1c-4828672c1207"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b08ae33b-1834-4fec-baba-6243dd7f9bd8"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8a3e6264-0c74-497d-8a11-cebe83e81070"),
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SynchronizeRemindings",
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				Name = @"SynchronizeRemindingsStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(43, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptInvoiceSavedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4c57ec31-3ad8-4db2-ab54-cb1e6e947b63"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b08ae33b-1834-4fec-baba-6243dd7f9bd8"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				Name = @"ScriptInvoiceSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(134, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,219,110,218,64,16,125,38,82,254,97,227,135,200,72,128,12,45,109,165,36,72,20,146,200,82,69,163,154,228,125,177,39,176,173,189,139,246,66,66,35,254,189,179,187,24,76,47,152,62,193,238,204,57,59,231,204,140,87,84,18,154,106,182,2,114,67,46,110,185,102,122,221,137,85,204,199,144,131,102,124,78,46,47,201,69,172,238,24,167,121,162,169,54,42,108,218,187,109,234,61,232,233,122,9,217,72,228,166,224,79,52,55,112,61,19,34,31,132,193,55,40,24,207,166,226,235,11,7,25,52,175,206,207,86,248,152,176,39,31,66,246,68,24,153,130,101,136,51,44,32,160,31,63,100,209,39,232,182,123,208,203,218,16,117,187,109,154,70,180,29,69,221,126,63,139,222,191,235,69,253,0,153,146,53,79,23,82,112,246,19,18,51,251,14,169,222,81,118,134,165,28,175,171,38,123,123,241,32,89,65,229,186,34,3,9,142,104,188,55,44,67,141,113,230,132,29,123,96,36,184,198,74,78,162,115,86,157,192,233,109,67,74,14,47,196,98,195,127,219,90,199,181,109,19,43,106,20,143,169,6,155,245,123,103,237,125,125,193,107,229,169,147,116,1,5,221,191,228,207,157,199,56,171,97,152,8,205,158,89,74,53,19,220,214,134,20,187,32,90,172,180,250,35,101,23,119,228,236,153,132,143,10,36,38,115,100,198,28,43,19,39,27,112,168,37,220,114,58,203,33,11,131,42,203,83,47,112,195,238,39,169,73,222,206,207,26,241,142,118,10,175,250,78,200,2,36,209,251,191,55,100,148,83,165,238,16,35,164,179,242,58,230,43,193,82,248,11,112,16,34,99,195,118,209,105,144,198,130,134,114,110,10,224,58,12,204,65,189,65,139,28,10,104,90,219,27,8,179,123,202,252,35,19,83,204,92,21,71,90,233,17,216,72,159,236,186,215,40,251,75,148,166,82,219,211,201,243,144,148,136,160,90,16,77,83,97,184,158,80,55,89,72,241,69,136,31,102,57,102,106,153,211,234,166,133,254,149,22,9,134,30,114,64,147,250,253,249,31,154,237,202,121,154,19,150,127,68,151,214,78,164,175,52,210,138,254,44,178,117,104,187,51,102,206,112,252,66,108,205,107,17,225,160,3,55,19,141,183,210,202,214,97,31,54,45,31,221,59,212,218,251,91,6,135,123,163,48,92,177,173,76,24,237,45,192,132,138,33,27,140,111,106,85,142,65,165,146,149,18,15,234,171,131,62,136,165,89,78,153,206,173,247,135,222,184,219,144,155,60,175,45,32,86,9,254,228,219,5,112,211,25,43,247,241,24,45,40,159,131,93,79,148,34,1,23,145,19,220,2,184,250,5,180,102,89,233,152,6,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateSynchronizeSubjectRemindingUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("3c6005fd-a117-442c-8427-c203d746ed51"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b08ae33b-1834-4fec-baba-6243dd7f9bd8"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				Name = @"SynchronizeSubjectReminding",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(274, 51),
				SchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeSynchronizeSubjectRemindingParameters(schemaTask);
			return schemaTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateMultiplyMethod());
			Methods.Add(CreateDivisionMethod());
			Methods.Add(CreateIsFinalStatusMethod());
			Methods.Add(CreateOnSavingMethod());
			Methods.Add(CreateOnSavedMethod());
			Methods.Add(CreateUpdatePrimaryAmountMethod());
			Methods.Add(CreateGetLookupDisplayColumnValueMethod());
			Methods.Add(CreateGetFetchedDisplayColumnValueMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("14309d58-28f0-4db9-b520-bf2b1c42dd81"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("301fa723-04d8-4fb4-8b85-b788d7ec5200"),
				Name = "Terrasoft.Core.DB",
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
				UId = new Guid("039fff2c-6377-49c9-b0c4-212f9c778c5b"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("40620cec-072b-4865-b05c-978dcd5f52b4")
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
				UId = new Guid("a7d86598-c4ed-440d-bb25-68d898b60ed1"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("5f05e5ce-515a-40bc-b6f5-74b884e9a4aa")
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
				UId = new Guid("40a95b21-1ccf-48ad-ad10-696f3faf8c50"),
				Name = "Multiply",
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "decimal"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("177d332b-26be-47b6-9f57-b00e01bd61a2"),
				Name = "arg1",
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "decimal",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c78ac476-0205-49ad-ba8a-a97041137885"),
				Name = "arg2",
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "decimal",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,240,77,44,201,208,11,202,47,205,75,209,72,44,74,55,84,208,82,0,82,70,58,70,154,214,0,253,17,30,67,33,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateDivisionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f45ac0b2-4933-4e6c-bfd0-33c26fa2a02a"),
				Name = "Division",
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "decimal"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f130af74-4632-49d0-a7a6-7db0c6133b38"),
				Name = "arg1",
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "decimal",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("483691bf-361c-4061-b59f-b771559870a4"),
				Name = "arg2",
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "decimal",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,73,77,206,204,77,204,81,40,74,45,46,205,41,81,176,85,48,176,230,229,202,76,211,72,44,74,55,82,176,83,48,208,172,230,229,226,132,75,250,38,150,100,232,5,229,151,230,165,128,20,24,42,232,43,128,212,233,40,24,105,2,117,213,242,114,21,165,150,148,22,229,65,13,179,6,0,111,233,240,209,92,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateIsFinalStatusMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("85cd11ec-0499-4b2f-bf8d-ae4901b2d29f"),
				Name = "IsFinalStatus",
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				CreatedInPackageId = new Guid("8a3e6264-0c74-497d-8a11-cebe83e81070"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,144,219,138,194,48,16,134,175,45,244,29,98,175,34,72,95,192,3,136,172,210,11,69,169,238,253,216,78,215,64,58,145,52,169,148,101,223,221,68,179,226,233,118,152,255,251,191,153,22,52,107,12,24,219,100,37,155,176,47,50,194,116,233,18,205,174,59,97,57,87,210,214,244,13,210,226,120,105,69,57,229,201,6,186,26,201,228,33,147,12,70,113,212,58,8,94,147,121,113,196,26,182,22,117,231,104,132,231,64,124,152,243,125,131,122,174,136,176,48,66,81,250,184,176,2,130,31,212,67,150,100,212,42,81,224,83,219,189,171,18,4,242,230,182,134,26,93,211,91,123,58,43,131,61,79,22,126,253,31,145,250,196,147,243,199,184,251,192,77,236,69,119,120,255,150,151,17,21,227,1,210,119,231,90,41,7,236,55,142,122,26,141,213,20,176,31,191,121,80,74,78,249,203,33,30,249,23,71,33,93,129,108,188,233,5,171,100,35,15,163,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnSavingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f916e8f6-11c0-4c3c-9c6f-2839b3eeb4ea"),
				Name = "OnSaving",
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				CreatedInPackageId = new Guid("505c3aa0-d270-4a5e-aaf3-90031bf8dda9"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,193,78,195,48,16,68,207,228,43,182,61,37,151,252,64,9,151,170,84,185,52,82,139,184,27,123,90,140,220,13,184,107,162,136,242,239,164,33,168,33,42,161,71,91,179,111,103,86,99,183,20,47,88,172,212,233,70,74,111,121,183,17,37,160,44,163,238,93,60,189,64,75,251,155,174,80,37,244,17,221,120,72,240,60,139,62,163,21,96,238,45,175,161,149,211,148,209,86,185,3,102,209,187,242,84,58,51,15,222,131,117,189,110,145,212,45,90,66,30,234,87,152,162,17,148,46,236,249,81,185,128,91,3,109,247,202,221,197,211,254,216,52,249,166,49,170,113,218,245,168,158,177,127,77,45,131,53,61,76,110,46,248,25,247,114,145,48,60,91,60,60,214,36,27,38,78,232,120,252,165,27,104,26,234,79,186,162,98,248,220,92,27,174,147,247,146,253,9,24,159,182,77,153,38,231,253,233,226,45,52,117,136,207,192,164,109,79,126,104,159,243,103,197,59,156,150,136,15,56,149,233,11,202,8,134,139,141,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnSavedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("380ec7e3-6065-46cb-8432-04e9c4096001"),
				Name = "OnSaved",
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				CreatedInPackageId = new Guid("505c3aa0-d270-4a5e-aaf3-90031bf8dda9"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,142,205,10,194,48,16,132,207,10,190,67,232,41,5,201,11,248,3,165,180,222,68,132,62,64,72,86,9,180,27,217,221,32,69,124,119,211,234,69,122,25,152,217,29,230,11,55,165,207,0,190,13,120,5,103,123,87,170,215,102,189,186,80,244,201,73,131,66,99,39,161,103,149,102,61,168,58,18,152,214,58,137,20,128,77,221,91,230,175,29,205,9,100,191,104,30,53,194,115,81,139,200,66,105,178,21,221,211,0,40,186,72,12,148,15,8,78,66,196,98,171,186,191,160,44,119,153,108,230,48,221,195,91,129,76,28,201,255,22,171,33,38,20,214,121,57,200,56,253,190,63,40,143,82,26,221,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdatePrimaryAmountMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("21bcf7f7-0dc7-492b-9c2a-9c089f27ebf1"),
				Name = "UpdatePrimaryAmount",
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				CreatedInPackageId = new Guid("5f05e5ce-515a-40bc-b6f5-74b884e9a4aa"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,83,75,79,194,64,16,62,183,191,98,233,169,53,164,122,7,73,72,17,228,96,52,130,222,55,101,74,54,217,238,146,217,89,12,81,255,187,179,72,177,5,37,241,184,179,223,99,158,91,137,66,214,214,27,18,183,226,206,144,162,93,62,3,90,238,54,176,42,172,246,181,121,149,218,195,112,5,165,170,165,30,165,201,120,143,78,178,65,188,101,238,6,57,140,187,241,191,36,158,218,164,160,164,42,145,118,149,122,183,226,70,124,124,28,115,227,103,38,222,227,8,129,60,26,65,232,97,16,127,198,51,175,86,162,244,136,96,202,221,124,117,57,129,0,102,247,226,8,15,214,19,73,176,84,53,8,71,18,41,188,46,139,52,120,22,90,52,140,166,25,77,34,207,28,91,144,69,185,14,98,75,64,148,206,86,148,23,22,33,159,202,146,191,20,184,188,208,210,185,239,231,222,107,216,70,154,74,173,61,74,82,214,228,197,185,238,40,141,35,3,111,23,196,173,113,220,165,240,28,227,218,215,96,40,77,188,3,228,15,3,101,208,77,250,226,165,19,200,78,234,152,155,202,114,1,191,148,21,210,29,151,228,165,110,231,230,210,159,81,100,249,84,161,163,71,156,64,37,189,166,244,48,230,142,54,79,217,120,173,247,147,61,172,71,199,237,164,123,127,245,228,30,244,6,48,95,0,61,72,158,156,115,114,105,67,188,99,150,135,72,95,156,133,26,10,231,23,41,94,181,6,48,81,91,229,216,169,213,128,61,167,137,7,120,171,158,35,188,215,172,106,116,122,27,135,93,190,58,183,184,238,84,205,202,209,97,3,185,164,214,242,157,94,78,191,123,126,217,5,98,187,93,73,191,99,23,104,159,124,75,237,211,250,2,171,168,197,207,23,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetLookupDisplayColumnValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4e620f64-089b-4942-af93-70b8934c7f04"),
				Name = "GetLookupDisplayColumnValue",
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				CreatedInPackageId = new Guid("0831ed7d-04c4-455d-af2c-3fdb5376a294"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("5df4ed2d-e6d9-4324-97a5-3cbdf454b6e2"),
				Name = "entity",
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("0831ed7d-04c4-455d-af2c-3fdb5376a294")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("48562c7b-beab-4659-8417-ec4d446b7850"),
				Name = "lookupName",
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("0831ed7d-04c4-455d-af2c-3fdb5376a294")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,144,207,106,195,48,12,198,207,13,228,29,116,116,160,248,1,214,253,129,109,89,233,165,151,141,221,77,44,54,51,199,54,182,28,106,70,223,125,74,179,166,93,96,55,203,250,244,211,167,111,80,17,162,247,212,58,50,84,94,187,79,236,21,220,1,158,74,57,213,155,186,26,70,25,166,108,137,155,137,162,113,31,178,237,3,21,238,81,44,240,93,87,171,225,15,234,201,219,220,59,86,47,233,114,234,36,185,69,122,44,123,213,163,176,222,127,229,48,62,155,205,25,132,157,143,122,167,47,94,88,254,86,2,234,105,252,93,217,140,183,219,108,244,189,88,46,149,87,146,25,58,187,63,147,229,46,237,121,110,60,66,52,192,138,213,3,240,142,23,36,182,169,159,77,10,86,149,43,146,152,124,172,225,226,118,61,195,154,113,254,102,153,204,17,58,197,52,16,237,161,195,64,198,59,192,67,115,10,235,191,48,143,117,21,145,114,116,191,113,243,215,15,23,113,205,94,163,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetFetchedDisplayColumnValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2e43b19c-8e09-4004-ab3b-657f1d763f6c"),
				Name = "GetFetchedDisplayColumnValue",
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				CreatedInPackageId = new Guid("0831ed7d-04c4-455d-af2c-3fdb5376a294"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b43f156f-e227-41db-a34b-87c8fcf7c5de"),
				Name = "entity",
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("0831ed7d-04c4-455d-af2c-3fdb5376a294")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2da58872-900d-4804-a26e-79c29120dcc1"),
				Name = "lookupName",
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("0831ed7d-04c4-455d-af2c-3fdb5376a294")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("51f46f8d-36fb-4d4b-bd1b-1398898e3953"),
				Name = "recordId",
				CreatedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				ModifiedInSchemaUId = new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("0831ed7d-04c4-455d-af2c-3fdb5376a294")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,142,193,14,130,48,16,68,239,126,69,143,144,152,254,128,241,2,136,225,160,49,49,122,223,148,85,26,233,150,44,45,9,127,111,5,14,52,120,219,204,206,188,153,1,88,248,30,57,183,68,168,156,182,36,142,2,201,105,55,202,71,164,31,118,67,240,182,214,126,124,119,154,12,119,213,160,129,224,143,1,114,253,189,0,193,27,89,150,154,234,138,122,7,164,48,27,175,96,48,153,81,191,51,221,178,3,117,91,37,115,70,112,56,75,73,220,26,24,235,128,44,209,169,230,198,218,0,143,21,189,108,201,214,20,89,242,7,122,70,183,248,114,219,122,67,211,184,116,47,24,149,229,186,170,3,153,209,121,166,104,145,92,50,133,238,187,22,150,232,19,90,143,135,47,224,132,19,69,84,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Invoice_Invoice_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("627ff9b5-4acd-4f22-9b44-cc579765e637"));
		}

		#endregion

	}

	#endregion

}

