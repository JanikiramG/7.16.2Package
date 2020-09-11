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

	#region Class: Lead_WebLeadForm_TerrasoftSchema

	/// <exclude/>
	public class Lead_WebLeadForm_TerrasoftSchema : Terrasoft.Configuration.Lead_CoreLead_TerrasoftSchema
	{

		#region Constructors: Public

		public Lead_WebLeadForm_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Lead_WebLeadForm_TerrasoftSchema(Lead_WebLeadForm_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Lead_WebLeadForm_TerrasoftSchema(Lead_WebLeadForm_TerrasoftSchema source)
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
			RealUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			Name = "Lead_WebLeadForm_Terrasoft";
			ParentSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			ExtendParent = true;
			CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("dc75275f-426d-4f50-a4ec-dc7296c7d1cd")) == null) {
				Columns.Add(CreateCountryStrColumn());
			}
			if (Columns.FindByUId(new Guid("eef401ef-dda7-4ba1-8a29-6adf42a527fb")) == null) {
				Columns.Add(CreateRegionStrColumn());
			}
			if (Columns.FindByUId(new Guid("a5f6978f-18e4-47c6-938d-9390b9386db6")) == null) {
				Columns.Add(CreateCityStrColumn());
			}
			if (Columns.FindByUId(new Guid("9389d289-6386-48fc-9bd5-2c5872332662")) == null) {
				Columns.Add(CreateWebFormColumn());
			}
			if (Columns.FindByUId(new Guid("33099014-9741-4d65-aec1-8f0fbe5da8b3")) == null) {
				Columns.Add(CreateBpmHrefColumn());
			}
			if (Columns.FindByUId(new Guid("80755b15-6dcc-400e-99ad-cfd9ac5a08a9")) == null) {
				Columns.Add(CreateBpmRefColumn());
			}
			if (Columns.FindByUId(new Guid("f904f43e-672c-42f8-a5ed-e484d6d799ce")) == null) {
				Columns.Add(CreateQualifiedColumn());
			}
			if (Columns.FindByUId(new Guid("2917b3c0-75e0-41d3-be64-764da1f5369a")) == null) {
				Columns.Add(CreateSaleParticipantColumn());
			}
			if (Columns.FindByUId(new Guid("6e8ab674-b580-4620-912a-78cdc93ddc7f")) == null) {
				Columns.Add(CreateQualifiedPercentColumn());
			}
			if (Columns.FindByUId(new Guid("35c9d777-642d-455a-8011-0bf9fdf797fd")) == null) {
				Columns.Add(CreateSalePercentColumn());
			}
			if (Columns.FindByUId(new Guid("63835aed-0d82-40d3-b102-75140767b1e5")) == null) {
				Columns.Add(CreateBpmSessionIdColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateNotesColumn() {
			EntitySchemaColumn column = base.CreateNotesColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateLeadNameColumn() {
			EntitySchemaColumn column = base.CreateLeadNameColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateAccountColumn() {
			EntitySchemaColumn column = base.CreateAccountColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateContactColumn() {
			EntitySchemaColumn column = base.CreateContactColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateTitleColumn() {
			EntitySchemaColumn column = base.CreateTitleColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateFullJobTitleColumn() {
			EntitySchemaColumn column = base.CreateFullJobTitleColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateStatusColumn() {
			EntitySchemaColumn column = base.CreateStatusColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateInformationSourceColumn() {
			EntitySchemaColumn column = base.CreateInformationSourceColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateIndustryColumn() {
			EntitySchemaColumn column = base.CreateIndustryColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateAnnualRevenueColumn() {
			EntitySchemaColumn column = base.CreateAnnualRevenueColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateEmployeesNumberColumn() {
			EntitySchemaColumn column = base.CreateEmployeesNumberColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateBusinesPhoneColumn() {
			EntitySchemaColumn column = base.CreateBusinesPhoneColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateMobilePhoneColumn() {
			EntitySchemaColumn column = base.CreateMobilePhoneColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateEmailColumn() {
			EntitySchemaColumn column = base.CreateEmailColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateFaxColumn() {
			EntitySchemaColumn column = base.CreateFaxColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateWebsiteColumn() {
			EntitySchemaColumn column = base.CreateWebsiteColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateAddressTypeColumn() {
			EntitySchemaColumn column = base.CreateAddressTypeColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateCountryColumn() {
			EntitySchemaColumn column = base.CreateCountryColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateRegionColumn() {
			EntitySchemaColumn column = base.CreateRegionColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateCityColumn() {
			EntitySchemaColumn column = base.CreateCityColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateZipColumn() {
			EntitySchemaColumn column = base.CreateZipColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateAddressColumn() {
			EntitySchemaColumn column = base.CreateAddressColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateDoNotUseEmailColumn() {
			EntitySchemaColumn column = base.CreateDoNotUseEmailColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateDoNotUsePhoneColumn() {
			EntitySchemaColumn column = base.CreateDoNotUsePhoneColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateDoNotUseFaxColumn() {
			EntitySchemaColumn column = base.CreateDoNotUseFaxColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateDoNotUseSMSColumn() {
			EntitySchemaColumn column = base.CreateDoNotUseSMSColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateDoNotUseMailColumn() {
			EntitySchemaColumn column = base.CreateDoNotUseMailColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateCommentaryColumn() {
			EntitySchemaColumn column = base.CreateCommentaryColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateQualifiedContactColumn() {
			EntitySchemaColumn column = base.CreateQualifiedContactColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateQualifiedAccountColumn() {
			EntitySchemaColumn column = base.CreateQualifiedAccountColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected virtual EntitySchemaColumn CreateCountryStrColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("dc75275f-426d-4f50-a4ec-dc7296c7d1cd"),
				Name = @"CountryStr",
				UsageType = EntitySchemaColumnUsageType.Advanced,
				CreatedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23"),
				ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23"),
				CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64")
			};
		}

		protected virtual EntitySchemaColumn CreateRegionStrColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("eef401ef-dda7-4ba1-8a29-6adf42a527fb"),
				Name = @"RegionStr",
				UsageType = EntitySchemaColumnUsageType.Advanced,
				CreatedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23"),
				ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23"),
				CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64")
			};
		}

		protected virtual EntitySchemaColumn CreateCityStrColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("a5f6978f-18e4-47c6-938d-9390b9386db6"),
				Name = @"CityStr",
				UsageType = EntitySchemaColumnUsageType.Advanced,
				CreatedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23"),
				ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23"),
				CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64")
			};
		}

		protected virtual EntitySchemaColumn CreateWebFormColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("9389d289-6386-48fc-9bd5-2c5872332662"),
				Name = @"WebForm",
				ReferenceSchemaUId = new Guid("41ae7d8d-bec3-41df-a6f0-2ab0d08b3967"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23"),
				ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23"),
				CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64")
			};
		}

		protected virtual EntitySchemaColumn CreateBpmHrefColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("33099014-9741-4d65-aec1-8f0fbe5da8b3"),
				Name = @"BpmHref",
				IsValueCloneable = false,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23"),
				ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23"),
				CreatedInPackageId = new Guid("e3031532-a059-4130-8d2e-6bdf35a52945")
			};
		}

		protected virtual EntitySchemaColumn CreateBpmRefColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("80755b15-6dcc-400e-99ad-cfd9ac5a08a9"),
				Name = @"BpmRef",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23"),
				ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23"),
				CreatedInPackageId = new Guid("e3031532-a059-4130-8d2e-6bdf35a52945")
			};
		}

		protected virtual EntitySchemaColumn CreateQualifiedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("f904f43e-672c-42f8-a5ed-e484d6d799ce"),
				Name = @"Qualified",
				IsValueCloneable = false,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23"),
				ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23"),
				CreatedInPackageId = new Guid("e3031532-a059-4130-8d2e-6bdf35a52945")
			};
		}

		protected virtual EntitySchemaColumn CreateSaleParticipantColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("2917b3c0-75e0-41d3-be64-764da1f5369a"),
				Name = @"SaleParticipant",
				IsValueCloneable = false,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23"),
				ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23"),
				CreatedInPackageId = new Guid("e3031532-a059-4130-8d2e-6bdf35a52945")
			};
		}

		protected virtual EntitySchemaColumn CreateQualifiedPercentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("6e8ab674-b580-4620-912a-78cdc93ddc7f"),
				Name = @"QualifiedPercent",
				IsValueCloneable = false,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23"),
				ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23"),
				CreatedInPackageId = new Guid("e3031532-a059-4130-8d2e-6bdf35a52945")
			};
		}

		protected virtual EntitySchemaColumn CreateSalePercentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("35c9d777-642d-455a-8011-0bf9fdf797fd"),
				Name = @"SalePercent",
				IsValueCloneable = false,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23"),
				ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23"),
				CreatedInPackageId = new Guid("e3031532-a059-4130-8d2e-6bdf35a52945")
			};
		}

		protected virtual EntitySchemaColumn CreateBpmSessionIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("63835aed-0d82-40d3-b102-75140767b1e5"),
				Name = @"BpmSessionId",
				CreatedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23"),
				ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23"),
				CreatedInPackageId = new Guid("a604af94-e112-445c-b72d-ae1a2a5d6178")
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
			EventsProcessSchema = CreateLead_WebLeadForm_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateLead_WebLeadForm_TerrasoftEventsProcessSchema() {
			var schema = new Lead_WebLeadForm_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Lead_WebLeadForm_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Lead_WebLeadFormEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Lead_WebLeadForm_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Lead_WebLeadForm_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2eaad242-2409-4730-b249-bf36a3be9e23"));
		}

		#endregion

	}

	#endregion

	#region Class: Lead_WebLeadForm_Terrasoft

	/// <summary>
	/// Lead.
	/// </summary>
	public class Lead_WebLeadForm_Terrasoft : Terrasoft.Configuration.Lead_CoreLead_Terrasoft
	{

		#region Constructors: Public

		public Lead_WebLeadForm_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Lead_WebLeadForm_Terrasoft";
		}

		public Lead_WebLeadForm_Terrasoft(Lead_WebLeadForm_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Country (string).
		/// </summary>
		public string CountryStr {
			get {
				return GetTypedColumnValue<string>("CountryStr");
			}
			set {
				SetColumnValue("CountryStr", value);
			}
		}

		/// <summary>
		/// State/province (string).
		/// </summary>
		public string RegionStr {
			get {
				return GetTypedColumnValue<string>("RegionStr");
			}
			set {
				SetColumnValue("RegionStr", value);
			}
		}

		/// <summary>
		/// City (string).
		/// </summary>
		public string CityStr {
			get {
				return GetTypedColumnValue<string>("CityStr");
			}
			set {
				SetColumnValue("CityStr", value);
			}
		}

		/// <exclude/>
		public Guid WebFormId {
			get {
				return GetTypedColumnValue<Guid>("WebFormId");
			}
			set {
				SetColumnValue("WebFormId", value);
				_webForm = null;
			}
		}

		/// <exclude/>
		public string WebFormName {
			get {
				return GetTypedColumnValue<string>("WebFormName");
			}
			set {
				SetColumnValue("WebFormName", value);
				if (_webForm != null) {
					_webForm.Name = value;
				}
			}
		}

		private GeneratedWebForm _webForm;
		/// <summary>
		/// Landing page.
		/// </summary>
		public GeneratedWebForm WebForm {
			get {
				return _webForm ??
					(_webForm = LookupColumnEntities.GetEntity("WebForm") as GeneratedWebForm);
			}
		}

		/// <summary>
		/// BpmHref.
		/// </summary>
		public string BpmHref {
			get {
				return GetTypedColumnValue<string>("BpmHref");
			}
			set {
				SetColumnValue("BpmHref", value);
			}
		}

		/// <summary>
		/// Redirection website.
		/// </summary>
		public string BpmRef {
			get {
				return GetTypedColumnValue<string>("BpmRef");
			}
			set {
				SetColumnValue("BpmRef", value);
			}
		}

		/// <summary>
		/// Qualified.
		/// </summary>
		public int Qualified {
			get {
				return GetTypedColumnValue<int>("Qualified");
			}
			set {
				SetColumnValue("Qualified", value);
			}
		}

		/// <summary>
		/// Opportunity participant.
		/// </summary>
		public int SaleParticipant {
			get {
				return GetTypedColumnValue<int>("SaleParticipant");
			}
			set {
				SetColumnValue("SaleParticipant", value);
			}
		}

		/// <summary>
		/// % of qualified.
		/// </summary>
		public Decimal QualifiedPercent {
			get {
				return GetTypedColumnValue<Decimal>("QualifiedPercent");
			}
			set {
				SetColumnValue("QualifiedPercent", value);
			}
		}

		/// <summary>
		/// % of opportunities.
		/// </summary>
		public Decimal SalePercent {
			get {
				return GetTypedColumnValue<Decimal>("SalePercent");
			}
			set {
				SetColumnValue("SalePercent", value);
			}
		}

		/// <summary>
		/// BpmSessionId.
		/// </summary>
		public Guid BpmSessionId {
			get {
				return GetTypedColumnValue<Guid>("BpmSessionId");
			}
			set {
				SetColumnValue("BpmSessionId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Lead_WebLeadFormEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Lead_WebLeadForm_TerrasoftDeleted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Lead_WebLeadForm_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Lead_WebLeadFormEventsProcess

	/// <exclude/>
	public partial class Lead_WebLeadFormEventsProcess<TEntity> : Terrasoft.Configuration.Lead_CoreLeadEventsProcess<TEntity> where TEntity : Lead_WebLeadForm_Terrasoft
	{

		public Lead_WebLeadFormEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Lead_WebLeadFormEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
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

	#region Class: Lead_WebLeadFormEventsProcess

	/// <exclude/>
	public class Lead_WebLeadFormEventsProcess : Lead_WebLeadFormEventsProcess<Lead_WebLeadForm_Terrasoft>
	{

		public Lead_WebLeadFormEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Lead_WebLeadFormEventsProcess

	public partial class Lead_WebLeadFormEventsProcess<TEntity>
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

	#region Class: Lead_WebLeadForm_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Lead_WebLeadForm_TerrasoftEventsProcessSchema : Terrasoft.Configuration.Lead_CoreLead_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public Lead_WebLeadForm_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Lead_WebLeadForm_TerrasoftEventsProcessSchema(Lead_WebLeadForm_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Lead_WebLeadFormEventsProcess";
			UId = new Guid("8809225a-873c-47d0-b036-0b91f1749b42");
			CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("60550bfb-e424-448d-bc5b-ccf6184f7414");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaWebLeadFormLaneSet3 = CreateWebLeadFormLaneSet3LaneSet();
			LaneSets.Add(schemaWebLeadFormLaneSet3);
			ProcessSchemaLane schemaWebLeadFormLaneLane1 = CreateWebLeadFormLaneLane1Lane();
			schemaWebLeadFormLaneSet3.Lanes.Add(schemaWebLeadFormLaneLane1);
		}

		protected virtual ProcessSchemaLaneSet CreateWebLeadFormLaneSet3LaneSet() {
			ProcessSchemaLaneSet schemaWebLeadFormLaneSet3 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("fe5352f7-5956-4baa-a271-34d7644bcb32"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("065de26f-5ffd-4bc4-b862-ab37d85ac483"),
				CreatedInPackageId = new Guid("70885459-eb74-4f01-8b36-f019cf6455dd"),
				CreatedInSchemaUId = new Guid("8809225a-873c-47d0-b036-0b91f1749b42"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("8809225a-873c-47d0-b036-0b91f1749b42"),
				Name = @"WebLeadFormLaneSet3",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaWebLeadFormLaneSet3;
		}

		protected virtual ProcessSchemaLane CreateWebLeadFormLaneLane1Lane() {
			ProcessSchemaLane schemaWebLeadFormLaneLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("b7f68d21-6e1d-4242-bac9-6b5012f33e8c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fe5352f7-5956-4baa-a271-34d7644bcb32"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("70885459-eb74-4f01-8b36-f019cf6455dd"),
				CreatedInSchemaUId = new Guid("8809225a-873c-47d0-b036-0b91f1749b42"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("8809225a-873c-47d0-b036-0b91f1749b42"),
				Name = @"WebLeadFormLaneLane1",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaWebLeadFormLaneLane1;
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
			return new Lead_WebLeadForm_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8809225a-873c-47d0-b036-0b91f1749b42"));
		}

		#endregion

	}

	#endregion

}

