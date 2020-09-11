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

	#region Class: Account_Base_TerrasoftSchema

	/// <exclude/>
	public class Account_Base_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public Account_Base_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Account_Base_TerrasoftSchema(Account_Base_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Account_Base_TerrasoftSchema(Account_Base_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e");
			RealUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e");
			Name = "Account_Base_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializePrimaryImageColumn() {
			base.InitializePrimaryImageColumn();
			PrimaryImageColumn = CreateAccountLogoColumn();
			if (Columns.FindByUId(PrimaryImageColumn.UId) == null) {
				Columns.Add(PrimaryImageColumn);
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
			if (Columns.FindByUId(new Guid("dedb8f3b-4cb0-46ec-99e8-483ab92e10bb")) == null) {
				Columns.Add(CreateOwnershipColumn());
			}
			if (Columns.FindByUId(new Guid("165072a8-b718-4490-ab89-223f30390d81")) == null) {
				Columns.Add(CreatePrimaryContactColumn());
			}
			if (Columns.FindByUId(new Guid("f25a5087-fab6-4c7a-9cd0-177325f6e715")) == null) {
				Columns.Add(CreateParentColumn());
			}
			if (Columns.FindByUId(new Guid("d7da954f-d0d8-4eca-a2b4-7d4f7121f6b4")) == null) {
				Columns.Add(CreateIndustryColumn());
			}
			if (Columns.FindByUId(new Guid("60cc5643-4ee2-4adf-b76b-06000ad0b067")) == null) {
				Columns.Add(CreateCodeColumn());
			}
			if (Columns.FindByUId(new Guid("d60a9c06-1170-4cd6-9dc1-c972bc451533")) == null) {
				Columns.Add(CreateTypeColumn());
			}
			if (Columns.FindByUId(new Guid("9dbe8164-58b4-42c9-a75e-7c568d430d50")) == null) {
				Columns.Add(CreatePhoneColumn());
			}
			if (Columns.FindByUId(new Guid("9411651f-b785-4920-a542-e8ac11d2cf8d")) == null) {
				Columns.Add(CreateAdditionalPhoneColumn());
			}
			if (Columns.FindByUId(new Guid("40bf89ca-5927-47a6-b3fe-8955deb5f3ce")) == null) {
				Columns.Add(CreateFaxColumn());
			}
			if (Columns.FindByUId(new Guid("a1d2ad98-d068-4fc2-8454-8a7c944cd0a1")) == null) {
				Columns.Add(CreateWebColumn());
			}
			if (Columns.FindByUId(new Guid("9f5af167-9ab8-4c83-99db-7503df0eb650")) == null) {
				Columns.Add(CreateAddressTypeColumn());
			}
			if (Columns.FindByUId(new Guid("8cfabb54-64ca-413d-a4e0-81ce9d2f0c8f")) == null) {
				Columns.Add(CreateAddressColumn());
			}
			if (Columns.FindByUId(new Guid("13bbd624-a13b-4bc2-b05c-fff21e9f7b92")) == null) {
				Columns.Add(CreateCityColumn());
			}
			if (Columns.FindByUId(new Guid("8f532bba-53fb-4f56-babd-38402cb57b2a")) == null) {
				Columns.Add(CreateRegionColumn());
			}
			if (Columns.FindByUId(new Guid("3fe38c61-ff55-4012-b28d-67e59d5b1986")) == null) {
				Columns.Add(CreateZipColumn());
			}
			if (Columns.FindByUId(new Guid("2a7c00bd-0519-4742-b905-d8ce5f1b70ca")) == null) {
				Columns.Add(CreateCountryColumn());
			}
			if (Columns.FindByUId(new Guid("0039b8f7-f5cf-44c9-8828-4b9cb2fd6634")) == null) {
				Columns.Add(CreateAccountCategoryColumn());
			}
			if (Columns.FindByUId(new Guid("8696b76a-1f0b-42a4-8279-934399c0207f")) == null) {
				Columns.Add(CreateEmployeesNumberColumn());
			}
			if (Columns.FindByUId(new Guid("a006d013-4ef6-47a1-a000-d25346fcb392")) == null) {
				Columns.Add(CreateAnnualRevenueColumn());
			}
			if (Columns.FindByUId(new Guid("0136fb47-c018-4b7f-8ed3-0eb6bd686b20")) == null) {
				Columns.Add(CreateNotesColumn());
			}
			if (Columns.FindByUId(new Guid("c8abae85-5c2e-45bc-826b-fd53a88660c8")) == null) {
				Columns.Add(CreateLogoColumn());
			}
			if (Columns.FindByUId(new Guid("e36ae687-347d-4bf7-b260-90129862e357")) == null) {
				Columns.Add(CreateAlternativeNameColumn());
			}
			if (Columns.FindByUId(new Guid("f1f01f71-ddef-48bb-bc88-0fd2f3526ad9")) == null) {
				Columns.Add(CreateGPSNColumn());
			}
			if (Columns.FindByUId(new Guid("2ce4d59d-2ae4-4840-b4a7-33eee33fdb60")) == null) {
				Columns.Add(CreateGPSEColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("7c81a01e-f59b-47df-830c-8e830f1bf889"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				ModifiedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateOwnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("7c85a229-8cfa-4c29-8ab9-9463560a92ec"),
				Name = @"Owner",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				ModifiedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentUserContact")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateOwnershipColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("dedb8f3b-4cb0-46ec-99e8-483ab92e10bb"),
				Name = @"Ownership",
				ReferenceSchemaUId = new Guid("ce243c2c-b7d3-4dc4-b474-ab24c677801b"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				ModifiedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreatePrimaryContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("165072a8-b718-4490-ab89-223f30390d81"),
				Name = @"PrimaryContact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				ModifiedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateParentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f25a5087-fab6-4c7a-9cd0-177325f6e715"),
				Name = @"Parent",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				ModifiedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateIndustryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d7da954f-d0d8-4eca-a2b4-7d4f7121f6b4"),
				Name = @"Industry",
				ReferenceSchemaUId = new Guid("95de3d3b-b909-40d9-a3fa-e80d38ec208e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				ModifiedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateCodeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("60cc5643-4ee2-4adf-b76b-06000ad0b067"),
				Name = @"Code",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				ModifiedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d60a9c06-1170-4cd6-9dc1-c972bc451533"),
				Name = @"Type",
				ReferenceSchemaUId = new Guid("3ae4a2bb-d3dc-48bf-8271-9ca91dcdeba1"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				ModifiedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreatePhoneColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("9dbe8164-58b4-42c9-a75e-7c568d430d50"),
				Name = @"Phone",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				ModifiedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateAdditionalPhoneColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("9411651f-b785-4920-a542-e8ac11d2cf8d"),
				Name = @"AdditionalPhone",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				ModifiedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateFaxColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("40bf89ca-5927-47a6-b3fe-8955deb5f3ce"),
				Name = @"Fax",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				ModifiedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateWebColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("a1d2ad98-d068-4fc2-8454-8a7c944cd0a1"),
				Name = @"Web",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				ModifiedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateAddressTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("9f5af167-9ab8-4c83-99db-7503df0eb650"),
				Name = @"AddressType",
				ReferenceSchemaUId = new Guid("50837bfc-43ff-466b-94bb-de0847eecd1b"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				ModifiedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateAddressColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("8cfabb54-64ca-413d-a4e0-81ce9d2f0c8f"),
				Name = @"Address",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				ModifiedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateCityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("13bbd624-a13b-4bc2-b05c-fff21e9f7b92"),
				Name = @"City",
				ReferenceSchemaUId = new Guid("5ca90b6a-93e7-4448-befe-ab5166ec2cfe"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				ModifiedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateRegionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8f532bba-53fb-4f56-babd-38402cb57b2a"),
				Name = @"Region",
				ReferenceSchemaUId = new Guid("fa4eb497-e6a3-4f8c-8568-5df4bd2a8b91"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				ModifiedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateZipColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("3fe38c61-ff55-4012-b28d-67e59d5b1986"),
				Name = @"Zip",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				ModifiedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateCountryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("2a7c00bd-0519-4742-b905-d8ce5f1b70ca"),
				Name = @"Country",
				ReferenceSchemaUId = new Guid("09fce1f8-515c-4296-95cd-8cd93f79a6cf"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				ModifiedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateAccountCategoryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0039b8f7-f5cf-44c9-8828-4b9cb2fd6634"),
				Name = @"AccountCategory",
				ReferenceSchemaUId = new Guid("a6ff9860-2b37-4da2-9537-5cd6cedf9665"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				ModifiedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateEmployeesNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8696b76a-1f0b-42a4-8279-934399c0207f"),
				Name = @"EmployeesNumber",
				ReferenceSchemaUId = new Guid("ccf7d7bf-b4b7-4eb3-a191-3f47d6c4ee8d"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				ModifiedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateAnnualRevenueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a006d013-4ef6-47a1-a000-d25346fcb392"),
				Name = @"AnnualRevenue",
				ReferenceSchemaUId = new Guid("24d201f8-5f03-47f3-9e7b-1c967c11d7b9"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				ModifiedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateNotesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("0136fb47-c018-4b7f-8ed3-0eb6bd686b20"),
				Name = @"Notes",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				ModifiedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateLogoColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Image")) {
				UId = new Guid("c8abae85-5c2e-45bc-826b-fd53a88660c8"),
				Name = @"Logo",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				ModifiedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateAlternativeNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("e36ae687-347d-4bf7-b260-90129862e357"),
				Name = @"AlternativeName",
				CreatedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				ModifiedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateGPSNColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("f1f01f71-ddef-48bb-bc88-0fd2f3526ad9"),
				Name = @"GPSN",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				ModifiedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				CreatedInPackageId = new Guid("88ca8859-5a70-4347-94ce-f17e86447db4")
			};
		}

		protected virtual EntitySchemaColumn CreateGPSEColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("2ce4d59d-2ae4-4840-b4a7-33eee33fdb60"),
				Name = @"GPSE",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				ModifiedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				CreatedInPackageId = new Guid("88ca8859-5a70-4347-94ce-f17e86447db4")
			};
		}

		protected virtual EntitySchemaColumn CreateAccountLogoColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ImageLookup")) {
				UId = new Guid("27a77271-50e0-436f-a559-38ce3f8f7f37"),
				Name = @"AccountLogo",
				ReferenceSchemaUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				ModifiedInSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAccount_Base_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateAccount_Base_TerrasoftEventsProcessSchema() {
			var schema = new Account_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Account_Base_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Account_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Account_Base_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Account_Base_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"));
		}

		#endregion

	}

	#endregion

	#region Class: Account_Base_Terrasoft

	/// <summary>
	/// Account.
	/// </summary>
	public class Account_Base_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public Account_Base_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Account_Base_Terrasoft";
		}

		public Account_Base_Terrasoft(Account_Base_Terrasoft source)
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
		public Guid OwnershipId {
			get {
				return GetTypedColumnValue<Guid>("OwnershipId");
			}
			set {
				SetColumnValue("OwnershipId", value);
				_ownership = null;
			}
		}

		/// <exclude/>
		public string OwnershipName {
			get {
				return GetTypedColumnValue<string>("OwnershipName");
			}
			set {
				SetColumnValue("OwnershipName", value);
				if (_ownership != null) {
					_ownership.Name = value;
				}
			}
		}

		private AccountOwnership _ownership;
		/// <summary>
		/// Business entity.
		/// </summary>
		public AccountOwnership Ownership {
			get {
				return _ownership ??
					(_ownership = LookupColumnEntities.GetEntity("Ownership") as AccountOwnership);
			}
		}

		/// <exclude/>
		public Guid PrimaryContactId {
			get {
				return GetTypedColumnValue<Guid>("PrimaryContactId");
			}
			set {
				SetColumnValue("PrimaryContactId", value);
				_primaryContact = null;
			}
		}

		/// <exclude/>
		public string PrimaryContactName {
			get {
				return GetTypedColumnValue<string>("PrimaryContactName");
			}
			set {
				SetColumnValue("PrimaryContactName", value);
				if (_primaryContact != null) {
					_primaryContact.Name = value;
				}
			}
		}

		private Contact _primaryContact;
		/// <summary>
		/// Primary contact.
		/// </summary>
		public Contact PrimaryContact {
			get {
				return _primaryContact ??
					(_primaryContact = LookupColumnEntities.GetEntity("PrimaryContact") as Contact);
			}
		}

		/// <exclude/>
		public Guid ParentId {
			get {
				return GetTypedColumnValue<Guid>("ParentId");
			}
			set {
				SetColumnValue("ParentId", value);
				_parent = null;
			}
		}

		/// <exclude/>
		public string ParentName {
			get {
				return GetTypedColumnValue<string>("ParentName");
			}
			set {
				SetColumnValue("ParentName", value);
				if (_parent != null) {
					_parent.Name = value;
				}
			}
		}

		private Account _parent;
		/// <summary>
		/// Parent account.
		/// </summary>
		public Account Parent {
			get {
				return _parent ??
					(_parent = LookupColumnEntities.GetEntity("Parent") as Account);
			}
		}

		/// <exclude/>
		public Guid IndustryId {
			get {
				return GetTypedColumnValue<Guid>("IndustryId");
			}
			set {
				SetColumnValue("IndustryId", value);
				_industry = null;
			}
		}

		/// <exclude/>
		public string IndustryName {
			get {
				return GetTypedColumnValue<string>("IndustryName");
			}
			set {
				SetColumnValue("IndustryName", value);
				if (_industry != null) {
					_industry.Name = value;
				}
			}
		}

		private AccountIndustry _industry;
		/// <summary>
		/// Industry.
		/// </summary>
		public AccountIndustry Industry {
			get {
				return _industry ??
					(_industry = LookupColumnEntities.GetEntity("Industry") as AccountIndustry);
			}
		}

		/// <summary>
		/// Code.
		/// </summary>
		public string Code {
			get {
				return GetTypedColumnValue<string>("Code");
			}
			set {
				SetColumnValue("Code", value);
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

		private AccountType _type;
		/// <summary>
		/// Type.
		/// </summary>
		public AccountType Type {
			get {
				return _type ??
					(_type = LookupColumnEntities.GetEntity("Type") as AccountType);
			}
		}

		/// <summary>
		/// Primary phone.
		/// </summary>
		public string Phone {
			get {
				return GetTypedColumnValue<string>("Phone");
			}
			set {
				SetColumnValue("Phone", value);
			}
		}

		/// <summary>
		/// Alternate phone.
		/// </summary>
		public string AdditionalPhone {
			get {
				return GetTypedColumnValue<string>("AdditionalPhone");
			}
			set {
				SetColumnValue("AdditionalPhone", value);
			}
		}

		/// <summary>
		/// Fax.
		/// </summary>
		public string Fax {
			get {
				return GetTypedColumnValue<string>("Fax");
			}
			set {
				SetColumnValue("Fax", value);
			}
		}

		/// <summary>
		/// Web.
		/// </summary>
		public string Web {
			get {
				return GetTypedColumnValue<string>("Web");
			}
			set {
				SetColumnValue("Web", value);
			}
		}

		/// <exclude/>
		public Guid AddressTypeId {
			get {
				return GetTypedColumnValue<Guid>("AddressTypeId");
			}
			set {
				SetColumnValue("AddressTypeId", value);
				_addressType = null;
			}
		}

		/// <exclude/>
		public string AddressTypeName {
			get {
				return GetTypedColumnValue<string>("AddressTypeName");
			}
			set {
				SetColumnValue("AddressTypeName", value);
				if (_addressType != null) {
					_addressType.Name = value;
				}
			}
		}

		private AddressType _addressType;
		/// <summary>
		/// Address type.
		/// </summary>
		public AddressType AddressType {
			get {
				return _addressType ??
					(_addressType = LookupColumnEntities.GetEntity("AddressType") as AddressType);
			}
		}

		/// <summary>
		/// Address.
		/// </summary>
		public string Address {
			get {
				return GetTypedColumnValue<string>("Address");
			}
			set {
				SetColumnValue("Address", value);
			}
		}

		/// <exclude/>
		public Guid CityId {
			get {
				return GetTypedColumnValue<Guid>("CityId");
			}
			set {
				SetColumnValue("CityId", value);
				_city = null;
			}
		}

		/// <exclude/>
		public string CityName {
			get {
				return GetTypedColumnValue<string>("CityName");
			}
			set {
				SetColumnValue("CityName", value);
				if (_city != null) {
					_city.Name = value;
				}
			}
		}

		private City _city;
		/// <summary>
		/// City.
		/// </summary>
		public City City {
			get {
				return _city ??
					(_city = LookupColumnEntities.GetEntity("City") as City);
			}
		}

		/// <exclude/>
		public Guid RegionId {
			get {
				return GetTypedColumnValue<Guid>("RegionId");
			}
			set {
				SetColumnValue("RegionId", value);
				_region = null;
			}
		}

		/// <exclude/>
		public string RegionName {
			get {
				return GetTypedColumnValue<string>("RegionName");
			}
			set {
				SetColumnValue("RegionName", value);
				if (_region != null) {
					_region.Name = value;
				}
			}
		}

		private Region _region;
		/// <summary>
		/// State/province.
		/// </summary>
		public Region Region {
			get {
				return _region ??
					(_region = LookupColumnEntities.GetEntity("Region") as Region);
			}
		}

		/// <summary>
		/// ZIP/postal code.
		/// </summary>
		public string Zip {
			get {
				return GetTypedColumnValue<string>("Zip");
			}
			set {
				SetColumnValue("Zip", value);
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

		/// <exclude/>
		public Guid AccountCategoryId {
			get {
				return GetTypedColumnValue<Guid>("AccountCategoryId");
			}
			set {
				SetColumnValue("AccountCategoryId", value);
				_accountCategory = null;
			}
		}

		/// <exclude/>
		public string AccountCategoryName {
			get {
				return GetTypedColumnValue<string>("AccountCategoryName");
			}
			set {
				SetColumnValue("AccountCategoryName", value);
				if (_accountCategory != null) {
					_accountCategory.Name = value;
				}
			}
		}

		private AccountCategory _accountCategory;
		/// <summary>
		/// Category.
		/// </summary>
		public AccountCategory AccountCategory {
			get {
				return _accountCategory ??
					(_accountCategory = LookupColumnEntities.GetEntity("AccountCategory") as AccountCategory);
			}
		}

		/// <exclude/>
		public Guid EmployeesNumberId {
			get {
				return GetTypedColumnValue<Guid>("EmployeesNumberId");
			}
			set {
				SetColumnValue("EmployeesNumberId", value);
				_employeesNumber = null;
			}
		}

		/// <exclude/>
		public string EmployeesNumberName {
			get {
				return GetTypedColumnValue<string>("EmployeesNumberName");
			}
			set {
				SetColumnValue("EmployeesNumberName", value);
				if (_employeesNumber != null) {
					_employeesNumber.Name = value;
				}
			}
		}

		private AccountEmployeesNumber _employeesNumber;
		/// <summary>
		/// No. of employees.
		/// </summary>
		public AccountEmployeesNumber EmployeesNumber {
			get {
				return _employeesNumber ??
					(_employeesNumber = LookupColumnEntities.GetEntity("EmployeesNumber") as AccountEmployeesNumber);
			}
		}

		/// <exclude/>
		public Guid AnnualRevenueId {
			get {
				return GetTypedColumnValue<Guid>("AnnualRevenueId");
			}
			set {
				SetColumnValue("AnnualRevenueId", value);
				_annualRevenue = null;
			}
		}

		/// <exclude/>
		public string AnnualRevenueName {
			get {
				return GetTypedColumnValue<string>("AnnualRevenueName");
			}
			set {
				SetColumnValue("AnnualRevenueName", value);
				if (_annualRevenue != null) {
					_annualRevenue.Name = value;
				}
			}
		}

		private AccountAnnualRevenue _annualRevenue;
		/// <summary>
		/// Annual revenue.
		/// </summary>
		public AccountAnnualRevenue AnnualRevenue {
			get {
				return _annualRevenue ??
					(_annualRevenue = LookupColumnEntities.GetEntity("AnnualRevenue") as AccountAnnualRevenue);
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
		/// Also known as.
		/// </summary>
		public string AlternativeName {
			get {
				return GetTypedColumnValue<string>("AlternativeName");
			}
			set {
				SetColumnValue("AlternativeName", value);
			}
		}

		/// <summary>
		/// GPS N.
		/// </summary>
		public string GPSN {
			get {
				return GetTypedColumnValue<string>("GPSN");
			}
			set {
				SetColumnValue("GPSN", value);
			}
		}

		/// <summary>
		/// GPS E.
		/// </summary>
		public string GPSE {
			get {
				return GetTypedColumnValue<string>("GPSE");
			}
			set {
				SetColumnValue("GPSE", value);
			}
		}

		/// <exclude/>
		public Guid AccountLogoId {
			get {
				return GetTypedColumnValue<Guid>("AccountLogoId");
			}
			set {
				SetColumnValue("AccountLogoId", value);
				_accountLogo = null;
			}
		}

		/// <exclude/>
		public string AccountLogoName {
			get {
				return GetTypedColumnValue<string>("AccountLogoName");
			}
			set {
				SetColumnValue("AccountLogoName", value);
				if (_accountLogo != null) {
					_accountLogo.Name = value;
				}
			}
		}

		private SysImage _accountLogo;
		/// <summary>
		/// Account logo.
		/// </summary>
		public SysImage AccountLogo {
			get {
				return _accountLogo ??
					(_accountLogo = LookupColumnEntities.GetEntity("AccountLogo") as SysImage);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Account_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Account_Base_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("Account_Base_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("Account_Base_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Account_Base_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Account_Base_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Account_Base_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Account_BaseEventsProcess

	/// <exclude/>
	public partial class Account_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : Account_Base_Terrasoft
	{

		#region Class: GenerateNumberUserTaskFlowElement

		/// <exclude/>
		public class GenerateNumberUserTaskFlowElement : GenerateSequenseNumberUserTask
		{

			public GenerateNumberUserTaskFlowElement(UserConnection userConnection, Account_BaseEventsProcess<TEntity> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "GenerateNumberUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("23f80421-a6e3-43ce-935b-490631fc9c22");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public Account_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Account_BaseEventsProcess";
			SchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual Guid OldParentId {
			get;
			set;
		}

		public virtual bool ParentIdIsNotNull {
			get;
			set;
		}

		public virtual Object CommunicationSynchronizer {
			get;
			set;
		}

		public virtual bool CanGenerateAnniversaryReminding {
			get;
			set;
		}

		public virtual Object EntityChangedColumns {
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
					SchemaElementUId = new Guid("a3c39c58-36fa-41f9-978a-41f4ec5defe7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _accountSaved;
		public ProcessFlowElement AccountSaved {
			get {
				return _accountSaved ?? (_accountSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AccountSaved",
					SchemaElementUId = new Guid("e63b0109-ceea-4da8-b0d4-b0cfda08fe27"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _synchronizeAccountAddressScriptTask;
		public ProcessScriptTask SynchronizeAccountAddressScriptTask {
			get {
				return _synchronizeAccountAddressScriptTask ?? (_synchronizeAccountAddressScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SynchronizeAccountAddressScriptTask",
					SchemaElementUId = new Guid("f30faa55-8788-4cd8-8f5f-358532e6f92b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SynchronizeAccountAddressScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _synchronizeAccountCommunication;
		public ProcessScriptTask SynchronizeAccountCommunication {
			get {
				return _synchronizeAccountCommunication ?? (_synchronizeAccountCommunication = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SynchronizeAccountCommunication",
					SchemaElementUId = new Guid("8daa7139-ad38-4748-9d7b-b3f957254876"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SynchronizeAccountCommunicationExecute,
				});
			}
		}

		private ProcessScriptTask _scriptAccountParentSaved;
		public ProcessScriptTask ScriptAccountParentSaved {
			get {
				return _scriptAccountParentSaved ?? (_scriptAccountParentSaved = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptAccountParentSaved",
					SchemaElementUId = new Guid("356c651f-eb15-4ba0-b31c-dc367acecdd6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptAccountParentSavedExecute,
				});
			}
		}

		private ProcessScriptTask _needGenerateScript;
		public ProcessScriptTask NeedGenerateScript {
			get {
				return _needGenerateScript ?? (_needGenerateScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "NeedGenerateScript",
					SchemaElementUId = new Guid("2d13f163-9406-40fd-a471-238f99046454"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = NeedGenerateScriptExecute,
				});
			}
		}

		private GenerateNumberUserTaskFlowElement _generateNumberUserTask;
		public GenerateNumberUserTaskFlowElement GenerateNumberUserTask {
			get {
				return _generateNumberUserTask ?? (_generateNumberUserTask = new GenerateNumberUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _needGeenerateNumberExclusiveGateway;
		public ProcessExclusiveGateway NeedGeenerateNumberExclusiveGateway {
			get {
				return _needGeenerateNumberExclusiveGateway ?? (_needGeenerateNumberExclusiveGateway = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "NeedGeenerateNumberExclusiveGateway",
					SchemaElementUId = new Guid("f9d48047-c089-464f-9c0e-eabd04f0f45f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.NeedGeenerateNumberExclusiveGateway.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
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
					SchemaElementUId = new Guid("8b8b9071-51d8-416c-ac2f-913cdc0bc7e2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("cb92e71d-1b18-439a-9821-f2f1b6e17740"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SetGeneratedNumberScriptExecute,
				});
			}
		}

		private ProcessScriptTask _scriptUpdateCampaignTargetCustomer;
		public ProcessScriptTask ScriptUpdateCampaignTargetCustomer {
			get {
				return _scriptUpdateCampaignTargetCustomer ?? (_scriptUpdateCampaignTargetCustomer = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptUpdateCampaignTargetCustomer",
					SchemaElementUId = new Guid("7a8a7f26-df98-41f9-b7d6-216928ec2507"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptUpdateCampaignTargetCustomerExecute,
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
					SchemaElementUId = new Guid("12429ad4-daac-4657-b543-6809b5928197"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = UpdateRemindingsExecute,
				});
			}
		}

		private ProcessScriptTask _initPrimaryContactAccountScriptTask;
		public ProcessScriptTask InitPrimaryContactAccountScriptTask {
			get {
				return _initPrimaryContactAccountScriptTask ?? (_initPrimaryContactAccountScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InitPrimaryContactAccountScriptTask",
					SchemaElementUId = new Guid("157a7f7c-9e1c-468b-87dd-f0e34c919c91"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitPrimaryContactAccountScriptTaskExecute,
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
					SchemaElementUId = new Guid("13734a1f-49cc-4fa2-9bab-dbe73a4dc714"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _accountSavingStartMessage;
		public ProcessFlowElement AccountSavingStartMessage {
			get {
				return _accountSavingStartMessage ?? (_accountSavingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AccountSavingStartMessage",
					SchemaElementUId = new Guid("1e590ddb-3f7a-41be-a10a-4f737b059754"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _accountSavingScriptTask;
		public ProcessScriptTask AccountSavingScriptTask {
			get {
				return _accountSavingScriptTask ?? (_accountSavingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "AccountSavingScriptTask",
					SchemaElementUId = new Guid("03fc7fc9-e572-406a-9d56-895f390391d5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = AccountSavingScriptTaskExecute,
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
					SchemaElementUId = new Guid("015c6ee2-b03d-4d96-b1a0-655d13a07b97"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _accountDeleted;
		public ProcessFlowElement AccountDeleted {
			get {
				return _accountDeleted ?? (_accountDeleted = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AccountDeleted",
					SchemaElementUId = new Guid("e6aefae8-1e05-4df5-b99e-a1f285635209"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _deleteRemindings;
		public ProcessScriptTask DeleteRemindings {
			get {
				return _deleteRemindings ?? (_deleteRemindings = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DeleteRemindings",
					SchemaElementUId = new Guid("7f528bdc-4a27-43f0-99eb-6c41c212dfc3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DeleteRemindingsExecute,
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow1324;
		public ProcessConditionalFlow ConditionalFlow1324 {
			get {
				return _conditionalFlow1324 ?? (_conditionalFlow1324 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow1324",
					SchemaElementUId = new Guid("2b2e6f45-8346-46d4-8c0c-de9addade517"),
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
			FlowElements[AccountSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { AccountSaved };
			FlowElements[SynchronizeAccountAddressScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SynchronizeAccountAddressScriptTask };
			FlowElements[SynchronizeAccountCommunication.SchemaElementUId] = new Collection<ProcessFlowElement> { SynchronizeAccountCommunication };
			FlowElements[ScriptAccountParentSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptAccountParentSaved };
			FlowElements[NeedGenerateScript.SchemaElementUId] = new Collection<ProcessFlowElement> { NeedGenerateScript };
			FlowElements[GenerateNumberUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { GenerateNumberUserTask };
			FlowElements[NeedGeenerateNumberExclusiveGateway.SchemaElementUId] = new Collection<ProcessFlowElement> { NeedGeenerateNumberExclusiveGateway };
			FlowElements[End1.SchemaElementUId] = new Collection<ProcessFlowElement> { End1 };
			FlowElements[SetGeneratedNumberScript.SchemaElementUId] = new Collection<ProcessFlowElement> { SetGeneratedNumberScript };
			FlowElements[ScriptUpdateCampaignTargetCustomer.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptUpdateCampaignTargetCustomer };
			FlowElements[UpdateRemindings.SchemaElementUId] = new Collection<ProcessFlowElement> { UpdateRemindings };
			FlowElements[InitPrimaryContactAccountScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InitPrimaryContactAccountScriptTask };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[AccountSavingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { AccountSavingStartMessage };
			FlowElements[AccountSavingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AccountSavingScriptTask };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[AccountDeleted.SchemaElementUId] = new Collection<ProcessFlowElement> { AccountDeleted };
			FlowElements[DeleteRemindings.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteRemindings };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "AccountSaved":
						e.Context.QueueTasks.Enqueue("SynchronizeAccountAddressScriptTask");
						e.Context.QueueTasks.Enqueue("SynchronizeAccountCommunication");
						e.Context.QueueTasks.Enqueue("ScriptAccountParentSaved");
						e.Context.QueueTasks.Enqueue("NeedGenerateScript");
						e.Context.QueueTasks.Enqueue("ScriptUpdateCampaignTargetCustomer");
						e.Context.QueueTasks.Enqueue("UpdateRemindings");
						e.Context.QueueTasks.Enqueue("InitPrimaryContactAccountScriptTask");
						break;
					case "SynchronizeAccountAddressScriptTask":
						break;
					case "SynchronizeAccountCommunication":
						break;
					case "ScriptAccountParentSaved":
						break;
					case "NeedGenerateScript":
						e.Context.QueueTasks.Enqueue("NeedGeenerateNumberExclusiveGateway");
						break;
					case "GenerateNumberUserTask":
							e.Context.QueueTasks.Enqueue("SetGeneratedNumberScript");
						break;
					case "NeedGeenerateNumberExclusiveGateway":
						if (ConditionalFlow1324ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("GenerateNumberUserTask");
							break;
						}
						e.Context.QueueTasks.Enqueue("End1");
						break;
					case "End1":
						break;
					case "SetGeneratedNumberScript":
						break;
					case "ScriptUpdateCampaignTargetCustomer":
						break;
					case "UpdateRemindings":
						break;
					case "InitPrimaryContactAccountScriptTask":
						break;
					case "EventSubProcess2":
						break;
					case "AccountSavingStartMessage":
						e.Context.QueueTasks.Enqueue("AccountSavingScriptTask");
						break;
					case "AccountSavingScriptTask":
						break;
					case "EventSubProcess3":
						break;
					case "AccountDeleted":
						e.Context.QueueTasks.Enqueue("DeleteRemindings");
						break;
					case "DeleteRemindings":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalFlow1324ExpressionExecute() {
			return Convert.ToBoolean(string.IsNullOrEmpty(Entity.GetTypedColumnValue<string>("Code")));
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("AccountSaved");
			ActivatedEventElements.Add("AccountSavingStartMessage");
			ActivatedEventElements.Add("AccountDeleted");
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
				case "AccountSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "AccountSaved";
					result = AccountSaved.Execute(context);
					break;
				case "SynchronizeAccountAddressScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SynchronizeAccountAddressScriptTask";
					result = SynchronizeAccountAddressScriptTask.Execute(context, SynchronizeAccountAddressScriptTaskExecute);
					break;
				case "SynchronizeAccountCommunication":
					context.QueueTasks.Dequeue();
					context.SenderName = "SynchronizeAccountCommunication";
					result = SynchronizeAccountCommunication.Execute(context, SynchronizeAccountCommunicationExecute);
					break;
				case "ScriptAccountParentSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptAccountParentSaved";
					result = ScriptAccountParentSaved.Execute(context, ScriptAccountParentSavedExecute);
					break;
				case "NeedGenerateScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "NeedGenerateScript";
					result = NeedGenerateScript.Execute(context, NeedGenerateScriptExecute);
					break;
				case "GenerateNumberUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "GenerateNumberUserTask";
					result = GenerateNumberUserTask.Execute(context);
					break;
				case "NeedGeenerateNumberExclusiveGateway":
					context.QueueTasks.Dequeue();
					context.SenderName = "NeedGeenerateNumberExclusiveGateway";
					result = NeedGeenerateNumberExclusiveGateway.Execute(context);
					break;
				case "End1":
					context.QueueTasks.Dequeue();
					break;
				case "SetGeneratedNumberScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetGeneratedNumberScript";
					result = SetGeneratedNumberScript.Execute(context, SetGeneratedNumberScriptExecute);
					break;
				case "ScriptUpdateCampaignTargetCustomer":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptUpdateCampaignTargetCustomer";
					result = ScriptUpdateCampaignTargetCustomer.Execute(context, ScriptUpdateCampaignTargetCustomerExecute);
					break;
				case "UpdateRemindings":
					context.QueueTasks.Dequeue();
					context.SenderName = "UpdateRemindings";
					result = UpdateRemindings.Execute(context, UpdateRemindingsExecute);
					break;
				case "InitPrimaryContactAccountScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitPrimaryContactAccountScriptTask";
					result = InitPrimaryContactAccountScriptTask.Execute(context, InitPrimaryContactAccountScriptTaskExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "AccountSavingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "AccountSavingStartMessage";
					result = AccountSavingStartMessage.Execute(context);
					break;
				case "AccountSavingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "AccountSavingScriptTask";
					result = AccountSavingScriptTask.Execute(context, AccountSavingScriptTaskExecute);
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "AccountDeleted":
					context.QueueTasks.Dequeue();
					context.SenderName = "AccountDeleted";
					result = AccountDeleted.Execute(context);
					break;
				case "DeleteRemindings":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteRemindings";
					result = DeleteRemindings.Execute(context, DeleteRemindingsExecute);
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
				case "EntityChangedColumns":
					EntityChangedColumns = reader.GetSerializableObjectValue();
				break;
				case "CanGenerateAnniversaryReminding":
					CanGenerateAnniversaryReminding = reader.GetValue<System.Boolean>();
				break;
				case "CommunicationSynchronizer":
					CommunicationSynchronizer = reader.GetSerializableObjectValue();
				break;
				case "ParentIdIsNotNull":
					ParentIdIsNotNull = reader.GetValue<System.Boolean>();
				break;
				case "OldParentId":
					OldParentId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool SynchronizeAccountAddressScriptTaskExecute(ProcessExecutingContext context) {
			// TODO: П.Тарасов. Актуализировать после возможности добавлять пользовательские атрибуты
			return SyncronizeAccountAddress();
		}

		public virtual bool SynchronizeAccountCommunicationExecute(ProcessExecutingContext context) {
			return SynchronizeCommunication();
		}

		public virtual bool ScriptAccountParentSavedExecute(ProcessExecutingContext context) {
			return SynchronizeRelationship();
		}

		public virtual bool NeedGenerateScriptExecute(ProcessExecutingContext context) {
			GenerateNumberUserTask.EntitySchema = Entity.Schema;
			return true;
		}

		public virtual bool SetGeneratedNumberScriptExecute(ProcessExecutingContext context) {
			string code = GenerateNumberUserTask.ResultCode;
			var update = new Update(UserConnection, Entity.Schema.Name)
				.Set("Code", Column.Parameter(code))
				.Where("Id").IsEqual(Column.Parameter(Entity.PrimaryColumnValue));
			update.Execute();
			return true;
		}

		public virtual bool ScriptUpdateCampaignTargetCustomerExecute(ProcessExecutingContext context) {
			var accountName = Entity.GetTypedColumnValue<string>(Entity.Schema.FindPrimaryDisplayColumnName());
			var accountId   = Entity.GetTypedColumnValue<string>("Id"); 
			/*new Update(UserConnection, "CampaignTarget")
				.Set("Customer", Column.Parameter(accountName))
				.Where("AccountId").IsEqual(Column.Parameter(accountId))
				.Execute();*/
			return true;
		}

		public virtual bool UpdateRemindingsExecute(ProcessExecutingContext context) {
			GenerateRemindings();
			return true;
		}

		public virtual bool InitPrimaryContactAccountScriptTaskExecute(ProcessExecutingContext context) {
			InitPrimaryContactAccount();
			return true;
		}

		public virtual bool AccountSavingScriptTaskExecute(ProcessExecutingContext context) {
			OldParentId = Entity.GetTypedOldColumnValue<Guid>("ParentId");
			InitializeCommunicationSynchronizer();
			InitCanGenerateAnniversaryReminding();
			return true;
		}

		public virtual bool DeleteRemindingsExecute(ProcessExecutingContext context) {
			Guid id = Entity.GetTypedColumnValue<Guid>("Id");
			Guid schemaUid = Entity.Schema.UId;
			AccountAnniversaryReminding remindingsGenerator = new AccountAnniversaryReminding(UserConnection, id);
			remindingsGenerator.DeleteRecordRemindings(schemaUid);
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Account_Base_TerrasoftSaved":
							if (ActivatedEventElements.Contains("AccountSaved")) {
							context.QueueTasks.Enqueue("AccountSaved");
						}
						break;
					case "Account_Base_TerrasoftSaving":
							if (ActivatedEventElements.Contains("AccountSavingStartMessage")) {
							context.QueueTasks.Enqueue("AccountSavingStartMessage");
						}
						break;
					case "Account_Base_TerrasoftDeleted":
							if (ActivatedEventElements.Contains("AccountDeleted")) {
							context.QueueTasks.Enqueue("AccountDeleted");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (EntityChangedColumns != null) {
				if (EntityChangedColumns.GetType().IsSerializable ||
					EntityChangedColumns.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("EntityChangedColumns", EntityChangedColumns, null);
				}
			}
			if (!HasMapping("CanGenerateAnniversaryReminding") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CanGenerateAnniversaryReminding", CanGenerateAnniversaryReminding, false);
			}
			if (CommunicationSynchronizer != null) {
				if (CommunicationSynchronizer.GetType().IsSerializable ||
					CommunicationSynchronizer.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("CommunicationSynchronizer", CommunicationSynchronizer, null);
				}
			}
			if (!HasMapping("ParentIdIsNotNull") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ParentIdIsNotNull", ParentIdIsNotNull, false);
			}
			if (!HasMapping("OldParentId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("OldParentId", OldParentId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: Account_BaseEventsProcess

	/// <exclude/>
	public class Account_BaseEventsProcess : Account_BaseEventsProcess<Account_Base_Terrasoft>
	{

		public Account_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Account_BaseEventsProcess

	public partial class Account_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void CreateCommunication(UserConnection userConnection, EntitySchema schema, string typeId, Guid primaryEntityId, string number) {
			var communication = schema.CreateEntity(userConnection);
			communication.SetDefColumnValues();
			communication.SetColumnValue("CommunicationTypeId", Guid.Parse(typeId));
			communication.SetColumnValue("AccountId", primaryEntityId);
			communication.SetColumnValue("Number", number);
			communication.Save();
		}

		public virtual bool SyncronizeAccountAddress() {
			return SynchronizeAddress();
		}

		public virtual Guid GetRelationTypeId() {
			return (Guid)Terrasoft.Core.Configuration.SysSettings.GetValue(UserConnection, "ParentAccountRelationType");
		}

		public virtual Guid GetReverseRelationTypeId() {
			Guid reverseRelationTypeId = Guid.Empty;
			var relationTypeTableESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "RelationType");
			var idColumn = relationTypeTableESQ.AddColumn("Id");
			var reverseRelationTypeColumn = relationTypeTableESQ.AddColumn("ReverseRelationType.Id");
			var relationTypeEntity = relationTypeTableESQ.GetEntity(UserConnection, GetRelationTypeId());
			if (relationTypeEntity != null) {
				reverseRelationTypeId = relationTypeEntity.GetTypedColumnValue<Guid>(reverseRelationTypeColumn.Name);
			}
			return reverseRelationTypeId;
		}

		public virtual bool SynchronizeAddress() {
			var accountId = Entity.PrimaryColumnValue;
			var addressTypeId = Entity.GetTypedColumnValue<Guid>("AddressTypeId");
			var address = Entity.GetTypedColumnValue<string>("Address");
			var cityId = Entity.GetTypedColumnValue<Guid>("CityId");
			var regionId = Entity.GetTypedColumnValue<Guid>("RegionId");
			var countryId = Entity.GetTypedColumnValue<Guid>("CountryId");
			var zip = Entity.GetTypedColumnValue<string>("Zip");
			var gpsN = Entity.GetTypedColumnValue<string>("GPSN");
			var gpsE = Entity.GetTypedColumnValue<string>("GPSE");
			bool isEmptyAddressTypeId = addressTypeId.IsEmpty();
			bool isEmptyAddress = address.IsNullOrEmpty();
			bool isEmptyCityId = cityId.IsEmpty();
			bool isEmptyRegionId = regionId.IsEmpty();
			bool isEmptyCountryId = countryId.IsEmpty();
			bool isEmptyZip = zip.IsNullOrEmpty();
			bool isEmptyGPSN = gpsN.IsNullOrEmpty();
			bool isEmptyGPSE = gpsE.IsNullOrEmpty();
			if (isEmptyAddressTypeId && isEmptyAddress && isEmptyCityId &&
				isEmptyRegionId && isEmptyCountryId && isEmptyZip && isEmptyGPSN && isEmptyGPSE) {
				return true;
			}
			var addressESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "AccountAddress");
			var createdOnColumn = addressESQ.AddColumn("CreatedOn");
			addressESQ.AddAllSchemaColumns();
			createdOnColumn.OrderByAsc();
			var accountFilter = addressESQ.CreateFilterWithParameters(
				FilterComparisonType.Equal, "Account", accountId);
			addressESQ.Filters.Add(accountFilter);
			var primaryFilter = addressESQ.CreateFilterWithParameters(
				FilterComparisonType.Equal, "Primary", true);
			addressESQ.Filters.Add(primaryFilter);
			var options = new EntitySchemaQueryOptions {
				PageableDirection = PageableSelectDirection.First,
				PageableRowCount = 1,
				PageableConditionValues = new Dictionary<string, object>()
			};
			var addresses = addressESQ.GetEntityCollection(UserConnection, options);
			if (addresses.Count > 0) {
				var accountAddress = addresses[0];
				var entityChanged = false;
				if (!isEmptyAddressTypeId && !accountAddress.GetTypedColumnValue<Guid>("AddressTypeId").Equals(addressTypeId)) {
					accountAddress.SetColumnValue("AddressTypeId", addressTypeId);
					entityChanged = true;
				}
				if (!accountAddress.GetTypedColumnValue<string>("Address").Equals(address)) {
					accountAddress.SetColumnValue("Address", address);
					entityChanged = true;
				}
				if (!isEmptyCityId && !accountAddress.GetTypedColumnValue<Guid>("CityId").Equals(cityId)) {
					accountAddress.SetColumnValue("CityId", cityId);
					entityChanged = true;
				}
				if (!isEmptyRegionId && !accountAddress.GetTypedColumnValue<Guid>("RegionId").Equals(regionId)) {
					accountAddress.SetColumnValue("RegionId", regionId);
					entityChanged = true;
				}
				if (!isEmptyCountryId && !accountAddress.GetTypedColumnValue<Guid>("CountryId").Equals(countryId)) {
					accountAddress.SetColumnValue("CountryId", countryId);
					entityChanged = true;
				}
				if (!accountAddress.GetTypedColumnValue<string>("Zip").Equals(zip)) {
					accountAddress.SetColumnValue("Zip", zip);
					entityChanged = true;
				}
				if (!accountAddress.GetTypedColumnValue<string>("GPSN").Equals(gpsN)) {
					accountAddress.SetColumnValue("GPSN", gpsN);
					entityChanged = true;
				}
				if (!accountAddress.GetTypedColumnValue<string>("GPSE").Equals(gpsE)) {
					accountAddress.SetColumnValue("GPSE", gpsE);
					entityChanged = true;
				}
				if (entityChanged) {
					accountAddress.Save();
				}
			} else {
				var schema = UserConnection.EntitySchemaManager.GetInstanceByName("AccountAddress");
				var accountEntity = schema.CreateEntity(UserConnection);
				accountEntity.SetDefColumnValues();
				accountEntity.SetColumnValue("AccountId", accountId);
				accountEntity.SetColumnValue("Primary", true);
				if (!isEmptyAddressTypeId) {
					accountEntity.SetColumnValue("AddressTypeId", addressTypeId);
				}
				accountEntity.SetColumnValue("Address", address);
				if (!isEmptyCityId) {
					accountEntity.SetColumnValue("CityId", cityId);
				}
				if (!isEmptyRegionId) {
					accountEntity.SetColumnValue("RegionId", regionId);
				}
				if (!isEmptyCountryId) {
					accountEntity.SetColumnValue("CountryId", countryId);
				}
				accountEntity.SetColumnValue("Zip", zip);
				accountEntity.SetColumnValue("GPSN", gpsN);
				accountEntity.SetColumnValue("GPSE", gpsE);
				accountEntity.Save();
			}
			return true;
		}

		public virtual bool SynchronizeCommunication() {
			var helper = GetCommunicationSynchronizer();
			helper.SynchronizeCommunications();
			return true;
		}

		public virtual bool SynchronizeRelationship() {
			if (Entity.GetColumnValue("ParentId") != null || OldParentId != Guid.Empty) {
				Guid relationTypeId = GetRelationTypeId();
				Guid reverseRelationTypeId = GetReverseRelationTypeId();
				Guid accountId = Entity.GetTypedColumnValue<Guid>("Id");
				Guid parentId = Entity.GetTypedColumnValue<Guid>("ParentId");
				Guid searchParentId = OldParentId != Guid.Empty ? OldParentId : parentId;
				bool removeRelationship = parentId == Guid.Empty;
				Guid relationshipId = Guid.Empty;
				string parentAccountColumnName = "";
			
				Select select = (Select)new Select(UserConnection)
					.Column("Id")
					.Column("AccountAId")
					.Column("AccountBId")
					.From("Relationship")
					.Where()
						.OpenBlock()
							.OpenBlock("AccountAId").IsEqual(Column.Parameter(accountId))
							.And("AccountBId").IsEqual(Column.Parameter(searchParentId))
							.CloseBlock()
						.Or()
							.OpenBlock("AccountAId").IsEqual(Column.Parameter(searchParentId))
							.And("AccountBId").IsEqual(Column.Parameter(accountId))
							.CloseBlock()
						.CloseBlock()
					.And()
						.OpenBlock("RelationTypeId").IsEqual(Column.Parameter(relationTypeId))
						.Or("ReverseRelationTypeId").IsEqual(Column.Parameter(relationTypeId))
						.CloseBlock();
				using (DBExecutor executor = UserConnection.EnsureDBConnection()) {
					using (IDataReader dataReader = select.ExecuteReader(executor)) {
						while (dataReader.Read()) {
							relationshipId = dataReader.GetColumnValue<Guid>("Id");
							if (dataReader.GetColumnValue<Guid>("AccountAId") == accountId) {
								parentAccountColumnName = "AccountBId";
							} else {
								parentAccountColumnName = "AccountAId";
							}
						}
					}
					if (removeRelationship && relationshipId != Guid.Empty) {
						Delete deleteRelationshipQuery = new Delete(UserConnection);
						deleteRelationshipQuery.From("Relationship");
						deleteRelationshipQuery.Where("Id").IsEqual(Column.Parameter(relationshipId));
						deleteRelationshipQuery.Execute(executor);
					} else {
						if (relationshipId != Guid.Empty) {
							Update updateRelationshipQuery = new Update(UserConnection, "Relationship");
							updateRelationshipQuery.Set(parentAccountColumnName, Column.Parameter(parentId));
							updateRelationshipQuery.Where("Id").IsEqual(Column.Parameter(relationshipId));
							updateRelationshipQuery.Execute(executor);
						} else if (parentId != Guid.Empty) {
							Insert insertRelationshipQuery = new Insert(UserConnection);
							insertRelationshipQuery.Into("Relationship");
							insertRelationshipQuery.Set("Active", Column.Parameter(true));
							insertRelationshipQuery.Set("AccountBId", Column.Parameter(accountId));
							insertRelationshipQuery.Set("RelationTypeId", Column.Parameter(relationTypeId));
							insertRelationshipQuery.Set("AccountAId", Column.Parameter(parentId));
							insertRelationshipQuery.Set("ReverseRelationTypeId", Column.Parameter(reverseRelationTypeId));
							insertRelationshipQuery.Execute(executor);
						}
					}
				}
			}
			return true;
		}

		public virtual CommunicationSynchronizer GetCommunicationSynchronizer() {
			CommunicationSynchronizer = CommunicationSynchronizer ?? ClassFactory.Get<CommunicationSynchronizer>(
				new ConstructorArgument("userConnection", UserConnection), new ConstructorArgument("entity", Entity));
			return (CommunicationSynchronizer) CommunicationSynchronizer;
		}

		public virtual void InitializeCommunicationSynchronizer() {
			var communicationColumns = new Dictionary<string, Guid> {
				{"Web", new Guid(CommunicationTypeConsts.WebId)},
				{"Fax", new Guid(CommunicationTypeConsts.FaxId)},
				{"Phone", new Guid(CommunicationTypeConsts.MainPhoneId)},
				{"AdditionalPhone", new Guid(CommunicationTypeConsts.AdditionalPhoneId)}
			};
			var helper = GetCommunicationSynchronizer();
			helper.InitializeCommunicationItems(communicationColumns);
		}

		public virtual void InitPrimaryContactAccount() {
			object primaryContactId = Entity.GetColumnValue("PrimaryContactId");
			if (primaryContactId == null) {
				return;
			}
			EntitySchema contactSchema = UserConnection.EntitySchemaManager.GetInstanceByName("Contact");
			Entity primaryContact = contactSchema.CreateEntity(UserConnection);
			if (!primaryContact.FetchFromDB(primaryContactId) || primaryContact.GetColumnValue("AccountId") != null) {
				return;
			}
			primaryContact.SetColumnValue("AccountId", Entity.PrimaryColumnValue);
			primaryContact.Save();
		}

		public virtual void InitCanGenerateAnniversaryReminding() {
			bool isNew = Entity.StoringState == StoringObjectState.New;
			bool isPrimaryContactNotEmpty = Entity.GetTypedColumnValue<Guid>("PrimaryContactId").IsNotEmpty();
			var columns = GetAnniversaryDependentColumns();
			var changedColumns = Entity.GetChangedColumnValues();
			EntityChangedColumns =changedColumns.ToList();
			bool anniversaryColumnsChanged = changedColumns.Any(col => columns.Contains(col.Name));
			CanGenerateAnniversaryReminding = (isPrimaryContactNotEmpty || !isNew) && anniversaryColumnsChanged;
		}

		public virtual IEnumerable<string> GetAnniversaryDependentColumns() {
			return new[] { "PrimaryContactId", "OwnerId" };
		}

		public virtual void GenerateRemindings() {
			if (!CanGenerateAnniversaryReminding) {
				return;
			}
			Guid id = Entity.GetTypedColumnValue<Guid>("Id");
			AccountAnniversaryReminding remindingsGenerator = new AccountAnniversaryReminding(UserConnection, id);
			remindingsGenerator.Options = GetRemindingOptions();
			remindingsGenerator.GenerateActualRemindings();
		}

		public virtual IEnumerable<string> GetRemindingOptions() {
			var options = new List<string>();
			var changedColumns = EntityChangedColumns as List<EntityColumnValue> ?? new List<EntityColumnValue>();
			if (changedColumns.Any(col => col.Name == "OwnerId")) {
				options.AddRange(new[] {
					AccountAnniversaryReminding.AccountOption,
					AccountAnniversaryReminding.ContactOption
				});
			} else if (changedColumns.Any(col => col.Name == "PrimaryContactId")) {
				options.Add(AccountAnniversaryReminding.ContactOption);
			}
			return options;
		}

		#endregion

	}

	#endregion

	#region Class: Account_Base_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Account_Base_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public Account_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Account_Base_TerrasoftEventsProcessSchema(Account_Base_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Account_BaseEventsProcess";
			UId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa");
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

		protected virtual ProcessSchemaParameter CreateOldParentIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f68c4e68-1e4b-4e41-8a4a-c8886eeb71ac"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				Name = @"OldParentId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateParentIdIsNotNullParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("588c737f-b2a8-46df-932d-442c9b3c128a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				Name = @"ParentIdIsNotNull",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCommunicationSynchronizerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f1fc71cd-6b7e-47ab-83bc-db5f85f0b9ae"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				Name = @"CommunicationSynchronizer",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCanGenerateAnniversaryRemindingParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("be94d9e2-f3c5-40bc-9d9b-821f5fca62ee"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				Name = @"CanGenerateAnniversaryReminding",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEntityChangedColumnsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d68a3ded-cb71-43ac-b1e1-6a6351097b0a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				Name = @"EntityChangedColumns",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateOldParentIdParameter());
			Parameters.Add(CreateParentIdIsNotNullParameter());
			Parameters.Add(CreateCommunicationSynchronizerParameter());
			Parameters.Add(CreateCanGenerateAnniversaryRemindingParameter());
			Parameters.Add(CreateEntityChangedColumnsParameter());
		}

		protected virtual void InitializeGenerateNumberUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("7949a2fa-51fa-4ad5-a1de-6e3f5ef128a3"),
				ContainerUId = new Guid("23f80421-a6e3-43ce-935b-490631fc9c22"),
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
				UId = new Guid("aec8d912-5776-4055-9111-c13e541771fb"),
				ContainerUId = new Guid("23f80421-a6e3-43ce-935b-490631fc9c22"),
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
			ProcessSchemaLaneSet schemaLaneSet391 = CreateLaneSet391LaneSet();
			LaneSets.Add(schemaLaneSet391);
			ProcessSchemaLane schemaLane1189 = CreateLane1189Lane();
			schemaLaneSet391.Lanes.Add(schemaLane1189);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaStartMessageEvent accountsaved = CreateAccountSavedStartMessageEvent();
			eventsubprocess1.FlowElements.Add(accountsaved);
			ProcessSchemaScriptTask synchronizeaccountaddressscripttask = CreateSynchronizeAccountAddressScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(synchronizeaccountaddressscripttask);
			ProcessSchemaScriptTask synchronizeaccountcommunication = CreateSynchronizeAccountCommunicationScriptTask();
			eventsubprocess1.FlowElements.Add(synchronizeaccountcommunication);
			ProcessSchemaScriptTask scriptaccountparentsaved = CreateScriptAccountParentSavedScriptTask();
			eventsubprocess1.FlowElements.Add(scriptaccountparentsaved);
			ProcessSchemaScriptTask needgeneratescript = CreateNeedGenerateScriptScriptTask();
			eventsubprocess1.FlowElements.Add(needgeneratescript);
			ProcessSchemaUserTask generatenumberusertask = CreateGenerateNumberUserTaskUserTask();
			eventsubprocess1.FlowElements.Add(generatenumberusertask);
			ProcessSchemaExclusiveGateway needgeeneratenumberexclusivegateway = CreateNeedGeenerateNumberExclusiveGatewayExclusiveGateway();
			eventsubprocess1.FlowElements.Add(needgeeneratenumberexclusivegateway);
			ProcessSchemaEndEvent end1 = CreateEnd1EndEvent();
			eventsubprocess1.FlowElements.Add(end1);
			ProcessSchemaScriptTask setgeneratednumberscript = CreateSetGeneratedNumberScriptScriptTask();
			eventsubprocess1.FlowElements.Add(setgeneratednumberscript);
			ProcessSchemaScriptTask scriptupdatecampaigntargetcustomer = CreateScriptUpdateCampaignTargetCustomerScriptTask();
			eventsubprocess1.FlowElements.Add(scriptupdatecampaigntargetcustomer);
			ProcessSchemaScriptTask updateremindings = CreateUpdateRemindingsScriptTask();
			eventsubprocess1.FlowElements.Add(updateremindings);
			ProcessSchemaScriptTask initprimarycontactaccountscripttask = CreateInitPrimaryContactAccountScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(initprimarycontactaccountscripttask);
			ProcessSchemaStartMessageEvent accountsavingstartmessage = CreateAccountSavingStartMessageStartMessageEvent();
			eventsubprocess2.FlowElements.Add(accountsavingstartmessage);
			ProcessSchemaScriptTask accountsavingscripttask = CreateAccountSavingScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(accountsavingscripttask);
			ProcessSchemaStartMessageEvent accountdeleted = CreateAccountDeletedStartMessageEvent();
			eventsubprocess3.FlowElements.Add(accountdeleted);
			ProcessSchemaScriptTask deleteremindings = CreateDeleteRemindingsScriptTask();
			eventsubprocess3.FlowElements.Add(deleteremindings);
			FlowElements.Add(CreateSequenceFlow6797SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6799SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6801SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1212SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1324ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow2212SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3212SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1742SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6797SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6797",
				UId = new Guid("278b3884-b226-4f35-b0a7-f5fb38c8e004"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				CurveCenterPosition = new Point(230, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e63b0109-ceea-4da8-b0d4-b0cfda08fe27"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f30faa55-8788-4cd8-8f5f-358532e6f92b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6799SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6799",
				UId = new Guid("4bbe3ccc-1031-4da3-b929-4d1049909c33"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				CurveCenterPosition = new Point(226, 133),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e63b0109-ceea-4da8-b0d4-b0cfda08fe27"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8daa7139-ad38-4748-9d7b-b3f957254876"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(104, 207));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6801SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6801",
				UId = new Guid("a567512c-d61a-446d-8563-9723e532645e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				CurveCenterPosition = new Point(222, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e63b0109-ceea-4da8-b0d4-b0cfda08fe27"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("356c651f-eb15-4ba0-b31c-dc367acecdd6"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(104, 319));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1212SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow1212",
				UId = new Guid("9e28c48a-387e-4a94-8309-eabeab10a237"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				CurveCenterPosition = new Point(435, 438),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f9d48047-c089-464f-9c0e-eabd04f0f45f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8b8b9071-51d8-416c-ac2f-913cdc0bc7e2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1324ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1324",
				UId = new Guid("2b2e6f45-8346-46d4-8c0c-de9addade517"),
				ConditionExpression = @"string.IsNullOrEmpty(Entity.GetTypedColumnValue<string>(""Code""))",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				CurveCenterPosition = new Point(496, 490),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f9d48047-c089-464f-9c0e-eabd04f0f45f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("23f80421-a6e3-43ce-935b-490631fc9c22"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2212SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2212",
				UId = new Guid("c02bf340-13b5-4e97-a98e-e35a57fba272"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				CurveCenterPosition = new Point(375, 490),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2d13f163-9406-40fd-a471-238f99046454"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f9d48047-c089-464f-9c0e-eabd04f0f45f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3212SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3212",
				UId = new Guid("e55b0931-8e6a-4f34-986a-68cf35799108"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				CurveCenterPosition = new Point(225, 290),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e63b0109-ceea-4da8-b0d4-b0cfda08fe27"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2d13f163-9406-40fd-a471-238f99046454"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(104, 522));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1742SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1742",
				UId = new Guid("945ccc20-9457-4bb4-b505-22c15a3f2893"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				CurveCenterPosition = new Point(634, 490),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("23f80421-a6e3-43ce-935b-490631fc9c22"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cb92e71d-1b18-439a-9821-f2f1b6e17740"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("ea46388a-e3f7-4c2f-af91-89f635f317b5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				CurveCenterPosition = new Point(220, 333),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e63b0109-ceea-4da8-b0d4-b0cfda08fe27"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7a8a7f26-df98-41f9-b7d6-216928ec2507"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(104, 606));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("fa731968-6d47-4f98-8094-4865e070200b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669"),
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				CurveCenterPosition = new Point(228, 722),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1e590ddb-3f7a-41be-a10a-4f737b059754"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("03fc7fc9-e572-406a-9d56-895f390391d5"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("7b76a5f1-e38a-4034-b528-71e143cbbf59"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("7094e60e-83c9-4747-8d9c-40b7b1b1c58b"),
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e63b0109-ceea-4da8-b0d4-b0cfda08fe27"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("12429ad4-daac-4657-b543-6809b5928197"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(104, 412));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("975398d4-c330-4ca7-ac01-446ac37908c6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e6aefae8-1e05-4df5-b99e-a1f285635209"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7f528bdc-4a27-43f0-99eb-6c41c212dfc3"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("ad101639-5a1b-4dc6-ab1d-9b151ec34699"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e63b0109-ceea-4da8-b0d4-b0cfda08fe27"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("157a7f7c-9e1c-468b-87dd-f0e34c919c91"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(104, 690));
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet391LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet391 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("403fe58d-9b33-451f-9ef0-5cbd86bee7bb"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				Name = @"LaneSet391",
				Position = new Point(5, 5),
				Size = new Size(1062, 898),
				UseBackgroundMode = false
			};
			return schemaLaneSet391;
		}

		protected virtual ProcessSchemaLane CreateLane1189Lane() {
			ProcessSchemaLane schemaLane1189 = new ProcessSchemaLane(this) {
				UId = new Guid("b56b5525-4aec-4dd4-9f09-4a1f96dcb0d7"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("403fe58d-9b33-451f-9ef0-5cbd86bee7bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				Name = @"Lane1189",
				Position = new Point(29, 0),
				Size = new Size(1033, 898),
				UseBackgroundMode = false
			};
			return schemaLane1189;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a3c39c58-36fa-41f9-978a-41f4ec5defe7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b56b5525-4aec-4dd4-9f09-4a1f96dcb0d7"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				Name = @"EventSubProcess1",
				Position = new Point(48, 59),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(672, 721),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAccountSavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e63b0109-ceea-4da8-b0d4-b0cfda08fe27"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a3c39c58-36fa-41f9-978a-41f4ec5defe7"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AccountSaved",
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				Name = @"AccountSaved",
				Position = new Point(43, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSynchronizeAccountAddressScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f30faa55-8788-4cd8-8f5f-358532e6f92b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a3c39c58-36fa-41f9-978a-41f4ec5defe7"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				Name = @"SynchronizeAccountAddressScriptTask",
				Position = new Point(148, 21),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,61,77,59,14,130,64,16,237,73,184,195,148,218,96,175,21,137,61,133,222,0,40,108,150,100,129,66,43,132,82,18,189,129,137,39,0,34,74,64,241,10,111,111,228,35,49,22,51,153,247,157,197,66,182,222,218,91,10,174,14,110,168,76,198,57,98,68,227,8,46,232,77,110,10,84,24,208,225,137,142,42,21,58,114,83,10,62,24,105,29,208,10,185,145,250,139,251,129,247,68,155,28,157,224,78,162,102,188,193,96,206,255,16,65,73,247,175,9,237,132,89,212,243,7,171,166,242,140,103,109,10,94,39,219,210,97,146,106,37,155,189,242,117,164,118,135,208,245,253,40,85,137,27,4,58,140,227,217,124,101,91,95,226,147,79,244,199,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateSynchronizeAccountCommunicationScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8daa7139-ad38-4748-9d7b-b3f957254876"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a3c39c58-36fa-41f9-978a-41f4ec5defe7"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				Name = @"SynchronizeAccountCommunication",
				Position = new Point(148, 121),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,8,174,204,75,206,40,202,207,203,172,74,117,206,207,205,45,205,203,76,78,44,201,204,207,211,208,180,6,0,38,105,137,83,34,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptAccountParentSavedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("356c651f-eb15-4ba0-b31c-dc367acecdd6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a3c39c58-36fa-41f9-978a-41f4ec5defe7"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				Name = @"ScriptAccountParentSaved",
				Position = new Point(148, 233),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,8,174,204,75,206,40,202,207,203,172,74,13,74,205,73,44,201,204,207,43,206,200,44,208,208,180,6,0,128,125,117,27,33,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateNeedGenerateScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2d13f163-9406-40fd-a471-238f99046454"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a3c39c58-36fa-41f9-978a-41f4ec5defe7"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				Name = @"NeedGenerateScript",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(148, 436),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,79,205,75,45,74,44,73,245,43,205,77,74,45,10,45,78,45,10,73,44,206,214,115,205,43,201,44,169,12,78,206,72,205,77,84,176,85,128,112,245,32,124,107,94,174,162,212,146,210,162,60,133,146,162,210,84,107,0,137,141,144,78,66,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateGenerateNumberUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("23f80421-a6e3-43ce-935b-490631fc9c22"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a3c39c58-36fa-41f9-978a-41f4ec5defe7"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				Name = @"GenerateNumberUserTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(407, 436),
				SchemaUId = new Guid("b9b23348-b89c-4836-8c5b-283ef5ed8666"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeGenerateNumberUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateNeedGeenerateNumberExclusiveGatewayExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("f9d48047-c089-464f-9c0e-eabd04f0f45f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a3c39c58-36fa-41f9-978a-41f4ec5defe7"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				Name = @"NeedGeenerateNumberExclusiveGateway",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(288, 436),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaEndEvent CreateEnd1EndEvent() {
			ProcessSchemaEndEvent schemaEndEvent = new ProcessSchemaEndEvent(this) {
				UId = new Guid("8b8b9071-51d8-416c-ac2f-913cdc0bc7e2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a3c39c58-36fa-41f9-978a-41f4ec5defe7"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("45ceaae2-4e1f-4c0c-86aa-cd4aeb4da913"),
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				Name = @"End1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(302, 366),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaEndEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSetGeneratedNumberScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("cb92e71d-1b18-439a-9821-f2f1b6e17740"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a3c39c58-36fa-41f9-978a-41f4ec5defe7"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				Name = @"SetGeneratedNumberScript",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(547, 436),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,142,203,110,194,64,12,69,215,69,226,31,70,89,77,36,52,63,128,88,69,81,197,38,66,60,215,110,114,85,34,50,14,120,108,90,254,158,9,116,215,165,125,143,175,79,82,233,249,219,181,99,7,183,114,159,96,8,41,26,139,95,144,67,130,236,41,93,194,22,201,6,173,50,179,156,207,238,36,206,174,93,166,242,1,227,199,29,94,131,159,232,106,100,70,171,253,200,11,87,179,246,250,8,187,246,140,72,161,161,136,114,62,251,8,59,168,47,166,170,98,225,170,113,176,200,97,67,146,83,133,248,73,163,124,97,167,51,4,190,88,119,69,25,214,169,190,25,13,254,31,254,247,98,35,125,36,121,188,227,35,13,150,59,178,232,91,50,212,191,104,45,251,77,43,129,154,176,83,49,44,159,47,134,243,101,250,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptUpdateCampaignTargetCustomerScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7a8a7f26-df98-41f9-b7d6-216928ec2507"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a3c39c58-36fa-41f9-978a-41f4ec5defe7"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				Name = @"ScriptUpdateCampaignTargetCustomer",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(148, 520),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,143,193,78,195,48,16,68,207,68,202,63,88,62,217,85,229,126,64,0,169,10,1,229,130,42,181,133,243,42,94,165,150,226,117,216,172,11,249,123,10,1,193,5,137,251,188,153,55,103,96,5,93,151,50,201,35,68,84,55,170,33,9,50,187,7,148,195,60,162,175,211,144,35,61,193,144,241,122,18,14,212,223,154,175,200,190,59,97,4,119,31,200,239,56,68,224,249,46,76,227,0,243,194,124,244,25,107,171,178,56,255,140,180,94,169,255,141,232,214,107,91,169,178,216,172,8,95,213,113,244,32,104,142,19,114,157,136,176,147,144,104,173,116,13,113,132,208,211,1,184,71,209,182,44,174,220,30,197,232,58,79,146,34,178,94,171,165,222,237,128,47,74,130,108,126,61,182,159,196,243,9,25,141,222,126,75,106,235,218,169,121,201,48,152,191,224,214,47,104,243,134,93,190,152,217,106,181,41,11,70,201,76,74,56,99,245,14,63,127,151,213,92,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateUpdateRemindingsScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("12429ad4-daac-4657-b543-6809b5928197"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a3c39c58-36fa-41f9-978a-41f4ec5defe7"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("7094e60e-83c9-4747-8d9c-40b7b1b1c58b"),
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				Name = @"UpdateRemindings",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(148, 326),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,79,205,75,45,74,44,73,13,74,205,205,204,75,201,204,75,47,214,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,254,31,73,67,35,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateInitPrimaryContactAccountScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("157a7f7c-9e1c-468b-87dd-f0e34c919c91"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a3c39c58-36fa-41f9-978a-41f4ec5defe7"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				Name = @"InitPrimaryContactAccountScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(148, 604),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,204,203,44,9,40,202,204,77,44,170,116,206,207,43,73,76,46,113,76,78,206,47,205,43,209,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,48,161,216,128,41,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("13734a1f-49cc-4fa2-9bab-dbe73a4dc714"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b56b5525-4aec-4dd4-9f09-4a1f96dcb0d7"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669"),
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(48, 796),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(672, 157),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAccountSavingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("1e590ddb-3f7a-41be-a10a-4f737b059754"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("13734a1f-49cc-4fa2-9bab-dbe73a4dc714"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669"),
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"AccountSaving",
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				Name = @"AccountSavingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(43, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateAccountSavingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("03fc7fc9-e572-406a-9d56-895f390391d5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("13734a1f-49cc-4fa2-9bab-dbe73a4dc714"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669"),
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				Name = @"AccountSavingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(183, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,53,202,65,10,194,48,16,5,208,189,224,29,66,87,117,227,5,170,130,4,41,93,85,84,220,15,205,160,3,201,79,25,39,66,60,189,34,116,251,120,99,12,103,82,134,13,193,237,221,9,38,86,183,61,219,173,206,28,198,24,124,142,37,225,78,177,240,174,47,18,14,109,179,252,102,211,173,87,3,196,132,162,124,216,231,148,10,100,34,147,140,107,197,244,212,140,159,107,187,60,79,232,25,172,100,124,4,228,205,250,34,173,23,78,130,32,120,252,159,178,21,133,51,45,220,125,1,200,9,35,226,156,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("015c6ee2-b03d-4d96-b1a0-655d13a07b97"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b56b5525-4aec-4dd4-9f09-4a1f96dcb0d7"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				Name = @"EventSubProcess3",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(50, 964),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(670, 196),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAccountDeletedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e6aefae8-1e05-4df5-b99e-a1f285635209"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("015c6ee2-b03d-4d96-b1a0-655d13a07b97"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"AccountDeleted",
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				Name = @"AccountDeleted",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(41, 60),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDeleteRemindingsScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7f528bdc-4a27-43f0-99eb-6c41c212dfc3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("015c6ee2-b03d-4d96-b1a0-655d13a07b97"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				Name = @"DeleteRemindings",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(162, 46),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,142,65,10,194,48,16,69,247,130,119,8,93,85,144,94,160,42,148,42,165,219,106,221,151,228,163,129,118,34,147,137,210,219,155,42,22,23,34,204,98,102,248,239,243,170,96,141,138,179,85,7,18,43,99,86,65,78,227,13,166,116,125,24,232,220,245,1,155,42,134,118,105,82,155,100,149,47,23,211,165,188,190,98,232,218,111,242,248,122,101,109,109,98,168,208,218,5,146,130,200,222,193,190,227,177,193,96,201,88,186,40,254,108,190,2,129,59,113,28,91,8,15,245,135,74,91,15,46,29,17,180,88,71,235,40,61,201,252,232,202,246,232,33,104,160,29,155,153,247,233,172,252,230,36,48,41,225,128,252,9,149,250,34,119,4,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateCreateCommunicationMethod());
			Methods.Add(CreateSyncronizeAccountAddressMethod());
			Methods.Add(CreateGetRelationTypeIdMethod());
			Methods.Add(CreateGetReverseRelationTypeIdMethod());
			Methods.Add(CreateSynchronizeAddressMethod());
			Methods.Add(CreateSynchronizeCommunicationMethod());
			Methods.Add(CreateSynchronizeRelationshipMethod());
			Methods.Add(CreateGetCommunicationSynchronizerMethod());
			Methods.Add(CreateInitializeCommunicationSynchronizerMethod());
			Methods.Add(CreateInitPrimaryContactAccountMethod());
			Methods.Add(CreateInitCanGenerateAnniversaryRemindingMethod());
			Methods.Add(CreateGetAnniversaryDependentColumnsMethod());
			Methods.Add(CreateGenerateRemindingsMethod());
			Methods.Add(CreateGetRemindingOptionsMethod());
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
				UId = new Guid("19435ec9-e585-4b01-a7b6-0a11d4877ad6"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e7a7acf9-9ccf-4a9b-b612-ba2a5292290e"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("5603834c-d982-4f87-a976-a9411eeb30f3")
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

		protected virtual SchemaMethod CreateCreateCommunicationMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4f729d05-43c7-4be6-a2ff-f545c266b180"),
				Name = "CreateCommunication",
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8e765b3b-77eb-4ea1-88e8-59eed012e751"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("7aafb4bc-464e-4493-ae6a-c957b49a8484"),
				Name = "schema",
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntitySchema",
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("217bae7e-a137-4146-b3a9-7c5743fc4991"),
				Name = "typeId",
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d7758bb3-f8ea-4f9c-a950-56af3e734687"),
				Name = "primaryEntityId",
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("0cb2d02c-591b-4339-b5d5-bbe4b401dcf5"),
				Name = "number",
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				ModifiedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,207,193,10,194,48,12,6,224,187,224,59,148,157,58,144,189,128,120,144,42,226,69,4,197,123,236,34,22,214,116,164,201,96,111,239,156,151,9,131,221,66,242,127,33,233,128,141,79,49,42,5,15,18,18,153,157,201,254,141,17,42,199,8,130,71,146,32,189,213,140,236,18,17,250,111,168,220,174,87,127,170,186,161,28,240,229,82,163,145,30,208,40,102,59,27,154,36,108,225,166,211,123,223,226,185,46,54,230,164,161,174,174,192,25,173,140,189,114,121,211,222,251,164,36,163,111,57,68,224,254,119,248,160,23,241,69,227,19,121,144,52,22,51,0,58,28,222,249,0,178,178,83,237,44,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSyncronizeAccountAddressMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("37c93222-afea-4625-a3d8-11c17635d6e3"),
				Name = "SyncronizeAccountAddress",
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,8,174,204,75,206,40,202,207,203,172,74,117,76,73,41,74,45,46,214,208,180,6,0,176,28,128,240,28,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetRelationTypeIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ca883833-18a2-4b21-ad78-a14587e3cf3a"),
				Name = "GetRelationTypeId",
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7"),
				ResultValueTypeName = "Guid"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,29,203,59,10,128,48,16,69,209,173,136,149,130,100,3,86,98,145,86,252,245,33,190,72,64,38,50,153,41,178,123,63,205,173,206,101,136,50,85,141,213,120,180,43,152,93,78,65,204,152,24,111,40,196,83,217,73,76,100,150,146,23,136,68,58,179,177,144,221,93,138,102,203,224,151,17,252,103,186,170,158,28,131,100,240,62,41,201,140,235,127,215,114,163,110,251,7,229,186,181,252,108,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetReverseRelationTypeIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b506b9c7-69bf-486e-8ca2-e89c69a5ecc7"),
				Name = "GetReverseRelationTypeId",
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7"),
				ResultValueTypeName = "Guid"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,221,10,130,48,24,189,78,240,29,150,87,19,100,47,96,5,17,34,93,20,148,213,253,106,95,53,152,83,214,86,72,244,238,109,36,105,165,208,229,246,157,159,157,243,45,53,156,33,5,87,80,23,88,131,160,154,23,114,83,149,48,103,104,140,82,59,36,73,94,234,42,246,189,43,85,22,216,32,54,116,47,32,201,86,22,39,225,134,18,169,185,174,178,195,25,114,186,50,160,42,188,189,128,154,21,82,194,193,81,72,27,176,160,146,158,64,69,40,104,123,6,97,109,195,217,172,16,38,151,86,186,203,145,76,89,13,192,193,156,189,89,29,41,254,150,89,255,114,201,135,116,115,255,202,209,167,153,130,126,1,190,226,71,200,78,62,11,198,161,147,231,71,132,59,228,135,182,85,35,68,136,238,190,55,232,219,207,47,207,249,187,83,29,108,71,133,129,145,91,227,4,247,214,67,150,52,7,247,148,135,239,41,208,70,201,238,15,17,63,1,131,183,128,62,44,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSynchronizeAddressMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("768d6ff3-a0e7-4859-9f09-74ac9d431b7c"),
				Name = "SynchronizeAddress",
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,87,93,111,218,48,20,125,166,210,254,67,202,3,10,82,20,117,207,221,42,81,154,85,125,24,208,178,15,169,211,30,92,226,82,79,193,201,236,164,21,155,248,239,187,182,227,196,54,164,49,210,250,136,115,206,245,241,189,246,185,151,103,196,2,180,90,229,21,45,111,210,224,99,144,208,146,148,219,120,193,200,6,177,237,52,207,170,13,253,134,178,10,159,191,59,121,22,216,52,101,152,243,47,219,2,155,248,107,92,138,165,212,32,124,184,174,72,122,17,14,39,38,99,56,182,227,188,30,129,151,140,208,117,27,163,97,175,128,225,185,253,84,66,27,38,195,107,146,83,79,238,93,13,110,247,21,121,98,222,91,107,116,195,255,67,10,207,19,223,147,162,97,173,11,62,243,164,93,47,150,51,147,151,248,243,18,201,123,200,243,44,32,60,217,20,229,118,226,212,218,170,125,124,163,64,97,7,171,197,3,114,86,101,217,156,29,198,79,117,45,85,81,59,227,222,181,149,211,69,236,196,78,141,58,53,53,235,68,223,203,170,64,109,122,148,138,228,2,80,148,163,31,153,40,100,114,0,73,30,131,240,96,138,71,35,55,137,237,74,157,166,209,232,221,201,192,205,136,129,106,14,222,174,137,227,181,191,228,33,172,159,201,56,248,11,65,25,46,43,70,131,146,201,183,190,179,158,105,178,188,133,227,80,252,82,95,166,229,234,9,111,208,109,133,217,54,252,202,49,155,230,148,226,85,9,106,98,19,240,25,81,180,198,44,10,134,19,101,49,123,239,152,97,84,226,116,78,213,165,108,239,12,108,24,3,88,45,195,75,210,56,201,180,49,147,44,83,187,41,48,151,41,118,2,199,115,150,98,118,185,157,240,85,216,56,144,146,244,137,100,37,102,246,206,106,59,245,229,59,41,159,22,136,161,13,134,31,60,132,68,169,245,105,190,41,16,35,60,167,162,120,113,242,187,66,89,123,208,97,212,186,170,35,89,209,185,144,30,90,26,180,176,66,121,239,127,22,86,59,58,8,19,21,126,69,147,181,189,214,148,23,162,184,188,235,18,204,235,207,226,30,45,160,228,232,33,195,87,132,169,43,1,36,189,182,196,25,172,53,95,96,95,198,203,200,32,221,229,47,242,10,3,231,189,185,14,23,44,37,130,34,125,75,235,184,34,50,12,168,173,157,44,10,242,135,95,16,251,34,28,195,21,182,91,13,230,118,46,193,15,213,57,224,138,100,74,143,115,151,35,125,108,253,104,155,72,177,18,121,17,156,169,183,99,220,167,61,251,195,252,199,217,207,243,26,132,213,142,79,136,174,177,48,167,71,148,113,241,220,6,34,252,105,151,41,156,218,177,143,232,182,170,252,60,180,172,123,172,68,15,156,168,75,92,26,1,221,80,145,109,255,34,37,131,129,123,156,218,60,6,59,125,34,15,225,251,77,222,17,125,156,220,86,168,167,68,215,95,143,201,182,30,46,180,98,213,194,60,5,215,228,168,110,124,199,201,53,189,255,8,193,237,68,163,37,235,94,234,41,186,9,16,53,93,248,200,60,155,29,234,152,84,183,195,84,147,109,189,228,155,240,38,68,212,78,5,111,112,145,229,236,166,69,194,88,225,41,79,208,34,49,134,188,129,36,53,23,106,77,98,130,241,20,37,137,145,156,121,222,70,86,98,201,74,252,101,37,74,86,226,39,203,250,222,177,7,122,198,114,58,16,164,93,128,193,153,27,115,231,178,215,65,220,254,105,71,156,248,134,242,18,209,21,190,220,206,160,63,135,135,198,31,179,103,168,40,16,93,109,83,183,121,181,234,244,36,73,181,104,34,55,87,248,209,72,143,26,129,246,81,182,93,234,241,196,29,85,122,120,251,115,68,119,239,178,243,220,37,164,183,205,236,250,15,115,208,251,247,237,221,75,208,33,95,238,178,95,175,128,93,158,217,105,141,126,50,59,221,172,63,95,182,213,188,142,117,29,160,23,109,61,76,7,173,159,24,72,180,255,111,252,3,230,141,123,17,136,16,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSynchronizeCommunicationMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("bb8fbc4f-3bd0-4a0c-9295-c70833284b62"),
				Name = "SynchronizeCommunication",
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,200,72,205,41,72,45,82,176,85,112,79,45,113,206,207,205,45,205,203,76,78,44,201,204,207,11,174,204,75,206,40,202,207,203,172,74,45,210,208,180,230,130,40,212,67,18,70,81,94,12,82,83,148,90,82,90,148,167,80,82,84,154,106,13,0,212,160,36,82,93,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSynchronizeRelationshipMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e1e68192-fad6-4510-b662-258bde8ed95c"),
				Name = "SynchronizeRelationship",
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				CreatedInPackageId = new Guid("704e7bb5-6f6c-4f11-bfc1-a9d2fb413669"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,86,219,114,211,48,16,125,54,51,252,131,240,67,71,158,233,248,3,8,129,201,141,78,94,72,233,5,158,141,189,37,30,20,217,200,82,74,134,242,239,72,150,47,146,45,229,2,153,54,82,87,103,207,238,30,175,214,205,159,16,94,81,158,243,67,124,3,124,81,16,177,163,95,18,34,0,135,183,9,3,202,215,89,24,161,55,83,68,5,33,232,229,5,109,72,214,30,40,243,141,200,179,120,181,43,249,33,66,191,95,191,10,212,223,136,1,73,120,94,208,135,67,9,18,38,81,192,239,44,27,142,38,61,120,15,172,130,59,167,143,227,200,112,77,210,180,16,117,38,83,212,23,161,96,153,81,201,59,133,125,143,67,85,73,231,90,182,53,156,227,217,43,209,249,87,144,176,116,123,219,179,120,117,65,31,172,179,183,93,104,197,245,173,40,136,84,96,87,236,187,42,171,109,94,74,190,62,65,147,108,50,148,88,161,181,92,22,166,226,44,167,223,27,146,153,150,73,23,246,41,217,129,132,135,161,132,73,224,61,16,72,185,44,167,94,166,8,107,67,68,225,25,233,45,126,172,128,45,10,74,229,94,6,140,164,83,16,107,46,173,169,101,104,98,205,124,7,243,238,224,35,43,118,56,52,171,110,14,190,110,129,1,174,247,65,188,41,129,206,73,145,254,104,12,166,197,10,22,175,171,213,79,145,16,172,3,198,82,112,89,41,7,134,187,46,137,90,138,25,205,236,132,252,206,246,115,238,24,22,164,168,192,204,43,222,176,127,207,208,19,228,130,52,199,53,142,51,28,90,106,254,145,204,161,125,219,142,5,181,175,121,212,11,17,58,47,238,229,84,102,198,170,171,69,165,154,26,47,231,171,95,144,10,94,48,4,237,102,138,236,54,141,87,180,18,12,150,243,222,132,35,61,162,90,154,245,50,225,201,29,36,25,48,148,245,219,105,115,25,98,29,4,180,25,183,145,90,146,224,121,155,19,64,184,247,140,213,210,5,9,130,209,21,53,160,246,172,29,78,40,249,201,159,44,106,55,222,236,46,53,39,250,46,104,115,8,142,76,0,163,179,154,160,127,16,144,10,46,240,157,25,190,245,82,127,215,95,170,0,199,96,187,186,26,142,46,199,75,36,8,150,242,17,112,64,89,189,152,4,159,5,176,131,204,64,205,39,13,26,206,39,157,143,199,211,57,117,142,123,232,113,20,158,215,191,186,166,232,4,101,211,89,125,79,213,112,75,125,45,223,105,161,130,199,82,182,9,32,81,47,62,165,52,104,160,212,53,114,234,16,120,168,226,123,224,216,211,18,215,104,164,72,217,77,179,19,180,255,161,175,151,211,45,112,171,176,210,182,60,242,63,140,252,172,169,148,138,163,188,94,124,170,106,144,187,255,2,143,107,188,166,188,112,55,160,215,69,9,47,111,28,207,247,16,58,148,230,76,64,116,38,71,119,227,29,60,198,59,228,28,178,193,112,119,16,14,135,250,5,41,206,220,140,163,166,58,145,161,235,45,228,76,212,1,60,25,195,215,100,237,8,148,191,242,135,1,23,140,34,245,144,38,127,1,81,93,53,115,109,11,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetCommunicationSynchronizerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("33fb7c82-d8b7-4b07-b23c-13eaa52a8c12"),
				Name = "GetCommunicationSynchronizer",
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "CommunicationSynchronizer"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,143,65,10,2,49,12,69,215,206,41,194,172,90,24,188,192,168,131,148,209,3,136,7,40,37,104,193,166,144,166,72,61,189,29,119,46,178,249,132,255,243,66,190,203,41,85,138,193,75,204,116,107,20,158,156,41,126,144,225,8,78,205,150,5,220,203,151,114,241,65,50,183,253,21,229,160,110,159,204,176,35,124,247,115,84,132,235,70,156,249,81,19,146,152,177,22,228,30,16,134,13,27,39,184,255,25,118,2,21,237,18,165,117,100,253,13,214,206,3,163,84,38,48,234,47,86,47,53,127,1,198,156,66,128,11,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitializeCommunicationSynchronizerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c824c8b7-e10b-4cd9-89b8-53ed8376bc3c"),
				Name = "InitializeCommunicationSynchronizer",
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,209,10,130,48,24,133,175,243,41,134,87,10,226,11,88,65,24,137,23,65,80,208,245,218,126,114,48,255,201,54,45,19,223,189,105,32,25,93,120,123,248,190,195,225,52,84,19,166,202,178,70,193,168,21,10,83,37,235,18,13,217,16,132,7,217,11,54,132,84,183,107,99,181,192,123,68,178,90,240,45,233,188,85,231,95,225,230,71,35,55,132,65,250,221,115,105,43,72,21,26,107,98,135,229,60,236,163,65,57,208,231,18,197,97,147,114,42,20,194,18,233,72,5,142,240,164,238,56,23,227,126,185,184,228,71,25,170,188,62,241,26,247,83,1,178,2,237,158,201,192,206,244,115,139,172,208,10,197,11,116,16,38,222,7,140,115,116,77,84,186,116,70,231,22,74,19,252,59,61,76,222,174,40,134,73,143,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitPrimaryContactAccountMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("148d2603-2caa-45be-a4ad-462b9168f998"),
				Name = "InitPrimaryContactAccount",
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,145,207,106,194,64,16,198,207,230,41,38,158,18,144,188,64,200,65,99,45,30,90,4,209,251,116,59,173,145,236,108,217,204,10,65,125,119,215,38,149,102,211,30,23,190,253,125,127,198,188,29,73,9,124,217,74,163,109,75,195,130,74,214,239,80,192,19,75,37,109,246,76,82,154,218,105,222,99,237,40,153,110,2,229,52,205,163,234,3,146,49,161,0,118,117,157,194,57,154,88,18,103,57,143,174,81,71,221,170,3,105,4,213,137,251,87,1,187,134,172,7,176,79,84,25,206,126,107,95,144,241,147,236,61,206,154,27,65,86,180,104,95,81,251,68,189,229,61,72,247,35,104,227,193,3,163,172,180,132,66,157,54,25,122,246,101,226,33,33,91,145,168,195,202,26,189,92,140,138,166,112,185,4,142,163,209,230,74,25,199,223,107,65,252,231,46,1,96,251,47,96,246,115,152,199,33,30,50,31,62,196,224,137,146,52,191,1,221,164,11,32,229,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitCanGenerateAnniversaryRemindingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a0521acb-0caa-43f3-9a9a-abd6737f2eaa"),
				Name = "InitCanGenerateAnniversaryReminding",
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,145,193,106,195,48,12,134,239,131,189,131,219,67,73,46,126,129,46,133,146,150,80,40,217,88,203,238,78,34,58,143,68,14,182,210,97,232,195,79,115,18,210,20,122,180,172,255,211,255,75,133,49,181,208,46,135,95,145,136,61,146,38,47,79,100,172,198,203,137,20,129,72,18,49,188,223,139,31,40,41,84,37,247,175,95,95,138,94,252,97,117,163,172,79,13,146,42,41,55,180,111,90,242,19,47,3,58,251,22,170,212,212,93,131,95,170,238,224,45,235,116,181,137,150,115,233,161,90,198,242,224,70,66,20,243,140,171,178,162,12,66,199,68,70,109,17,245,21,172,99,217,14,90,192,10,144,122,178,155,4,223,10,47,227,64,55,115,146,222,127,5,47,189,172,239,72,31,132,115,144,60,155,163,118,20,250,67,118,53,121,25,90,6,0,143,124,144,110,209,71,156,67,36,155,49,142,12,169,53,219,230,130,204,85,3,241,63,56,85,152,1,130,229,53,223,69,253,132,70,99,197,87,96,114,244,116,229,183,155,88,132,99,198,98,181,122,238,110,253,7,208,102,114,31,246,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetAnniversaryDependentColumnsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("87d55c33-36e2-49cd-a429-76d2c076f0d4"),
				Name = "GetAnniversaryDependentColumns",
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "IEnumerable<string>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,143,142,85,168,86,80,10,40,202,204,77,44,170,116,206,207,43,73,76,46,241,76,81,210,81,80,242,47,207,75,45,2,50,21,106,173,1,188,17,74,11,47,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGenerateRemindingsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e03a759d-48e1-4156-b317-93fe29c0043d"),
				Name = "GenerateRemindings",
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,65,10,194,48,16,69,215,230,20,177,171,20,164,23,168,10,82,164,184,18,68,221,135,100,148,64,59,41,147,137,82,196,187,155,66,237,170,10,89,12,225,191,55,159,113,55,169,150,149,198,26,16,72,51,236,16,221,3,40,104,234,79,208,58,180,14,239,185,124,137,5,1,71,194,82,188,69,29,157,149,233,109,228,30,217,113,95,212,192,231,190,3,91,249,38,182,120,213,77,132,245,16,218,170,236,96,179,188,20,59,99,124,68,158,115,75,250,78,97,172,224,41,153,17,158,242,15,165,46,1,168,242,136,96,216,121,92,165,58,105,205,140,170,56,118,67,32,36,101,106,57,241,227,175,250,1,77,199,48,28,117,51,81,67,254,3,160,56,109,22,48,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetRemindingOptionsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4b424172-a85e-4f9e-9e0f-fb56b8526b7c"),
				Name = "GetRemindingOptions",
				CreatedInSchemaUId = new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "IEnumerable<string>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,81,205,138,194,48,16,62,91,232,59,12,158,82,144,190,128,182,82,138,7,65,84,60,236,101,217,67,72,70,13,180,19,73,210,74,17,223,221,152,141,136,236,194,174,167,192,124,255,164,231,6,244,201,41,77,22,10,32,60,195,74,89,55,179,206,40,58,148,44,155,166,73,239,41,226,200,233,128,178,214,77,215,6,230,130,156,114,67,253,122,230,246,91,29,193,112,253,224,77,135,37,204,231,79,243,159,112,200,81,123,96,175,57,121,69,3,19,186,129,162,4,255,228,107,222,34,20,5,140,55,103,66,179,148,227,44,131,75,154,140,226,128,188,146,114,119,215,51,31,245,249,21,160,81,37,132,238,200,85,68,170,71,99,185,25,118,216,42,146,126,94,30,177,77,144,79,254,98,215,154,28,23,145,237,201,215,123,233,43,96,99,17,222,232,190,53,170,245,190,209,237,215,17,236,223,53,66,133,52,49,232,58,67,143,143,156,222,0,166,190,103,26,213,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Account_Base_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("95d5d3e4-fe7f-4dca-b994-2b7d156509fa"));
		}

		#endregion

	}

	#endregion

}

