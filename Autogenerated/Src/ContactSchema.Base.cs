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
	using System.Runtime.Remoting;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration;
	using Terrasoft.Configuration.EntitySynchronization;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.Messaging.Common;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: Contact_Base_TerrasoftSchema

	/// <exclude/>
	public class Contact_Base_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public Contact_Base_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Contact_Base_TerrasoftSchema(Contact_Base_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Contact_Base_TerrasoftSchema(Contact_Base_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3");
			RealUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3");
			Name = "Contact_Base_Terrasoft";
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
			PrimaryImageColumn = CreatePhotoColumn();
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
			if (Columns.FindByUId(new Guid("c5d7c4d3-f308-40d3-8469-6ab6882bd70a")) == null) {
				Columns.Add(CreateDearColumn());
			}
			if (Columns.FindByUId(new Guid("f16cbd03-a8a8-4bdd-9970-a0c7985a1996")) == null) {
				Columns.Add(CreateSalutationTypeColumn());
			}
			if (Columns.FindByUId(new Guid("3a3317c0-09f6-4a26-998b-018d1caa2c36")) == null) {
				Columns.Add(CreateGenderColumn());
			}
			if (Columns.FindByUId(new Guid("5c6ca10e-1180-4c1e-8a50-55a72ff9bdd4")) == null) {
				Columns.Add(CreateAccountColumn());
			}
			if (Columns.FindByUId(new Guid("f70c762a-1038-49a7-a3e8-f24fb8cfdeef")) == null) {
				Columns.Add(CreateDecisionRoleColumn());
			}
			if (Columns.FindByUId(new Guid("a49571cc-a9a9-4c3e-a346-46c466e9a0d3")) == null) {
				Columns.Add(CreateTypeColumn());
			}
			if (Columns.FindByUId(new Guid("344436e4-9d6b-4a30-936f-f8ea45f2adb4")) == null) {
				Columns.Add(CreateJobColumn());
			}
			if (Columns.FindByUId(new Guid("8b680ac7-e46c-466c-b630-e5cb4da13a55")) == null) {
				Columns.Add(CreateJobTitleColumn());
			}
			if (Columns.FindByUId(new Guid("94cb8750-ad6f-4e80-b553-7d9e194a856e")) == null) {
				Columns.Add(CreateDepartmentColumn());
			}
			if (Columns.FindByUId(new Guid("3f08db69-6d2f-4b1c-87a4-acddc6c3b9d6")) == null) {
				Columns.Add(CreateBirthDateColumn());
			}
			if (Columns.FindByUId(new Guid("84c5808a-7859-4198-ba6a-243c95a3300b")) == null) {
				Columns.Add(CreatePhoneColumn());
			}
			if (Columns.FindByUId(new Guid("98e085c7-ad4d-4ac6-8c1c-09be09876d44")) == null) {
				Columns.Add(CreateMobilePhoneColumn());
			}
			if (Columns.FindByUId(new Guid("0a455b85-133c-4944-aff1-2ce7f7e50fee")) == null) {
				Columns.Add(CreateHomePhoneColumn());
			}
			if (Columns.FindByUId(new Guid("5ff9516e-251c-41de-a085-67fa199cdfe7")) == null) {
				Columns.Add(CreateSkypeColumn());
			}
			if (Columns.FindByUId(new Guid("dbf202ec-c444-479b-bcf4-d8e5b1863201")) == null) {
				Columns.Add(CreateEmailColumn());
			}
			if (Columns.FindByUId(new Guid("5ad029c6-0fa7-4db6-8fef-c72a0f535682")) == null) {
				Columns.Add(CreateAddressTypeColumn());
			}
			if (Columns.FindByUId(new Guid("0fb61bc8-a195-4d90-aecc-18b411b51814")) == null) {
				Columns.Add(CreateAddressColumn());
			}
			if (Columns.FindByUId(new Guid("cf58ca72-531b-4dd2-b4d5-f0d5b7c556f6")) == null) {
				Columns.Add(CreateCityColumn());
			}
			if (Columns.FindByUId(new Guid("0e50f221-470e-482b-8580-f61c74b8b1c1")) == null) {
				Columns.Add(CreateRegionColumn());
			}
			if (Columns.FindByUId(new Guid("0737d99d-eebc-4b8e-9859-634414f7cc04")) == null) {
				Columns.Add(CreateZipColumn());
			}
			if (Columns.FindByUId(new Guid("9463dea9-2576-4d37-812f-342ee57ddf32")) == null) {
				Columns.Add(CreateCountryColumn());
			}
			if (Columns.FindByUId(new Guid("1b1d8f33-4d26-4353-a1ed-07e11fc82112")) == null) {
				Columns.Add(CreateDoNotUseEmailColumn());
			}
			if (Columns.FindByUId(new Guid("a6bcf6fe-a06d-42ed-a263-f829ece05fd9")) == null) {
				Columns.Add(CreateDoNotUseCallColumn());
			}
			if (Columns.FindByUId(new Guid("d9deaed5-8e42-40c0-9bb1-a6bfe6716ca4")) == null) {
				Columns.Add(CreateDoNotUseFaxColumn());
			}
			if (Columns.FindByUId(new Guid("7e295464-4dee-4448-832c-97434b1f2943")) == null) {
				Columns.Add(CreateDoNotUseSmsColumn());
			}
			if (Columns.FindByUId(new Guid("238d9e74-ff12-4e40-8467-350bd9d4b58d")) == null) {
				Columns.Add(CreateDoNotUseMailColumn());
			}
			if (Columns.FindByUId(new Guid("fd73da4b-2b3d-483e-89d2-383a6db099ac")) == null) {
				Columns.Add(CreateNotesColumn());
			}
			if (Columns.FindByUId(new Guid("5282096d-e4af-470a-bfbc-3e3542f04515")) == null) {
				Columns.Add(CreateFacebookColumn());
			}
			if (Columns.FindByUId(new Guid("644a4505-9c9c-477e-8037-b73c14d109df")) == null) {
				Columns.Add(CreateLinkedInColumn());
			}
			if (Columns.FindByUId(new Guid("83239d8b-efb5-4a28-80b7-219bdbd2a752")) == null) {
				Columns.Add(CreateTwitterColumn());
			}
			if (Columns.FindByUId(new Guid("21a16860-9d95-4f60-9c23-66b3392ea5f4")) == null) {
				Columns.Add(CreateFacebookIdColumn());
			}
			if (Columns.FindByUId(new Guid("10ebe04c-3e1e-4606-93a5-dbdfdb230e71")) == null) {
				Columns.Add(CreateLinkedInIdColumn());
			}
			if (Columns.FindByUId(new Guid("2e96804c-cf03-4ab0-a532-79b032dc4529")) == null) {
				Columns.Add(CreateTwitterIdColumn());
			}
			if (Columns.FindByUId(new Guid("327e44bd-0b97-48c0-b11a-4686d6605b4f")) == null) {
				Columns.Add(CreateContactPhotoColumn());
			}
			if (Columns.FindByUId(new Guid("d1732e56-de5f-4bf6-ac22-228d7f768aa3")) == null) {
				Columns.Add(CreateTwitterAFDAColumn());
			}
			if (Columns.FindByUId(new Guid("3ed551e5-7963-4056-95fb-6b6c871145af")) == null) {
				Columns.Add(CreateFacebookAFDAColumn());
			}
			if (Columns.FindByUId(new Guid("b3cf002a-466c-4ea7-a457-b3630ec24e9d")) == null) {
				Columns.Add(CreateLinkedInAFDAColumn());
			}
			if (Columns.FindByUId(new Guid("b903e71d-74cd-4b79-9dd9-d0c84ef6ad44")) == null) {
				Columns.Add(CreateGPSNColumn());
			}
			if (Columns.FindByUId(new Guid("b9021fa0-6606-4027-8335-bf0624b58218")) == null) {
				Columns.Add(CreateGPSEColumn());
			}
			if (Columns.FindByUId(new Guid("771a60e2-020c-4dd2-8512-b428b8a47dba")) == null) {
				Columns.Add(CreateSurnameColumn());
			}
			if (Columns.FindByUId(new Guid("cc26b1c5-4254-4287-9c15-0b5acd319811")) == null) {
				Columns.Add(CreateGivenNameColumn());
			}
			if (Columns.FindByUId(new Guid("33a879a3-d466-4b3f-b529-377a69ff0819")) == null) {
				Columns.Add(CreateMiddleNameColumn());
			}
			if (Columns.FindByUId(new Guid("ced280cc-7423-4175-9896-ea592a9e81a6")) == null) {
				Columns.Add(CreateConfirmedColumn());
			}
			if (Columns.FindByUId(new Guid("a855b7ae-45be-4d73-9074-9d84e4ae66c4")) == null) {
				Columns.Add(CreateLanguageColumn());
			}
			if (Columns.FindByUId(new Guid("bcdc7a32-4332-4caf-858d-0078b56856fe")) == null) {
				Columns.Add(CreateAgeColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3");
			return column;
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("a5cca792-47dd-428a-83fb-5c92bdd97ff8"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateOwnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("64fa90dd-0cf5-45d7-88e4-6fa691d3c425"),
				Name = @"Owner",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentUserContact")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateDearColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("c5d7c4d3-f308-40d3-8469-6ab6882bd70a"),
				Name = @"Dear",
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSalutationTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f16cbd03-a8a8-4bdd-9970-a0c7985a1996"),
				Name = @"SalutationType",
				ReferenceSchemaUId = new Guid("e3c92284-1491-4438-986f-4bf5dbe4b847"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateGenderColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("3a3317c0-09f6-4a26-998b-018d1caa2c36"),
				Name = @"Gender",
				ReferenceSchemaUId = new Guid("0bc5d826-8e8f-48cd-b087-30b33d133120"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("5c6ca10e-1180-4c1e-8a50-55a72ff9bdd4"),
				Name = @"Account",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateDecisionRoleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f70c762a-1038-49a7-a3e8-f24fb8cfdeef"),
				Name = @"DecisionRole",
				ReferenceSchemaUId = new Guid("54aa771f-fba6-4d76-9239-bff3f00ee3e5"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a49571cc-a9a9-4c3e-a346-46c466e9a0d3"),
				Name = @"Type",
				ReferenceSchemaUId = new Guid("0b5ff414-e00a-4115-af0c-fe872e826f07"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateJobColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("344436e4-9d6b-4a30-936f-f8ea45f2adb4"),
				Name = @"Job",
				ReferenceSchemaUId = new Guid("c82ab6f0-0e36-4376-9ab3-c583d714b7b6"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateJobTitleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("8b680ac7-e46c-466c-b630-e5cb4da13a55"),
				Name = @"JobTitle",
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateDepartmentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("94cb8750-ad6f-4e80-b553-7d9e194a856e"),
				Name = @"Department",
				ReferenceSchemaUId = new Guid("7a269220-a657-4b5f-bfb4-ebe596e419d8"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateBirthDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("3f08db69-6d2f-4b1c-87a4-acddc6c3b9d6"),
				Name = @"BirthDate",
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreatePhoneColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("84c5808a-7859-4198-ba6a-243c95a3300b"),
				Name = @"Phone",
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateMobilePhoneColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("98e085c7-ad4d-4ac6-8c1c-09be09876d44"),
				Name = @"MobilePhone",
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateHomePhoneColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("0a455b85-133c-4944-aff1-2ce7f7e50fee"),
				Name = @"HomePhone",
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSkypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("5ff9516e-251c-41de-a085-67fa199cdfe7"),
				Name = @"Skype",
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateEmailColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("dbf202ec-c444-479b-bcf4-d8e5b1863201"),
				Name = @"Email",
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateAddressTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("5ad029c6-0fa7-4db6-8fef-c72a0f535682"),
				Name = @"AddressType",
				ReferenceSchemaUId = new Guid("50837bfc-43ff-466b-94bb-de0847eecd1b"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateAddressColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("0fb61bc8-a195-4d90-aecc-18b411b51814"),
				Name = @"Address",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateCityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("cf58ca72-531b-4dd2-b4d5-f0d5b7c556f6"),
				Name = @"City",
				ReferenceSchemaUId = new Guid("5ca90b6a-93e7-4448-befe-ab5166ec2cfe"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateRegionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0e50f221-470e-482b-8580-f61c74b8b1c1"),
				Name = @"Region",
				ReferenceSchemaUId = new Guid("fa4eb497-e6a3-4f8c-8568-5df4bd2a8b91"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateZipColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("0737d99d-eebc-4b8e-9859-634414f7cc04"),
				Name = @"Zip",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateCountryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("9463dea9-2576-4d37-812f-342ee57ddf32"),
				Name = @"Country",
				ReferenceSchemaUId = new Guid("09fce1f8-515c-4296-95cd-8cd93f79a6cf"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateDoNotUseEmailColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("1b1d8f33-4d26-4353-a1ed-07e11fc82112"),
				Name = @"DoNotUseEmail",
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"False"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateDoNotUseCallColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("a6bcf6fe-a06d-42ed-a263-f829ece05fd9"),
				Name = @"DoNotUseCall",
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"False"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateDoNotUseFaxColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("d9deaed5-8e42-40c0-9bb1-a6bfe6716ca4"),
				Name = @"DoNotUseFax",
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"False"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateDoNotUseSmsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("7e295464-4dee-4448-832c-97434b1f2943"),
				Name = @"DoNotUseSms",
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"False"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateDoNotUseMailColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("238d9e74-ff12-4e40-8467-350bd9d4b58d"),
				Name = @"DoNotUseMail",
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"False"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateNotesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("fd73da4b-2b3d-483e-89d2-383a6db099ac"),
				Name = @"Notes",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateFacebookColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("5282096d-e4af-470a-bfbc-3e3542f04515"),
				Name = @"Facebook",
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateLinkedInColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("644a4505-9c9c-477e-8037-b73c14d109df"),
				Name = @"LinkedIn",
				IsValueCloneable = false,
				IsIndexed = true,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateTwitterColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("83239d8b-efb5-4a28-80b7-219bdbd2a752"),
				Name = @"Twitter",
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateFacebookIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("21a16860-9d95-4f60-9c23-66b3392ea5f4"),
				Name = @"FacebookId",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateLinkedInIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("10ebe04c-3e1e-4606-93a5-dbdfdb230e71"),
				Name = @"LinkedInId",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateTwitterIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("2e96804c-cf03-4ab0-a532-79b032dc4529"),
				Name = @"TwitterId",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateContactPhotoColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Binary")) {
				UId = new Guid("327e44bd-0b97-48c0-b11a-4686d6605b4f"),
				Name = @"ContactPhoto",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateTwitterAFDAColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d1732e56-de5f-4bf6-ac22-228d7f768aa3"),
				Name = @"TwitterAFDA",
				ReferenceSchemaUId = new Guid("76e3d8e8-6c6b-48b5-9f43-3b361c368bff"),
				IsIndexed = true,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateFacebookAFDAColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("3ed551e5-7963-4056-95fb-6b6c871145af"),
				Name = @"FacebookAFDA",
				ReferenceSchemaUId = new Guid("76e3d8e8-6c6b-48b5-9f43-3b361c368bff"),
				IsIndexed = true,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateLinkedInAFDAColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b3cf002a-466c-4ea7-a457-b3630ec24e9d"),
				Name = @"LinkedInAFDA",
				ReferenceSchemaUId = new Guid("76e3d8e8-6c6b-48b5-9f43-3b361c368bff"),
				IsIndexed = true,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreatePhotoColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ImageLookup")) {
				UId = new Guid("0495373c-5053-4ae3-b553-dc92779c4702"),
				Name = @"Photo",
				ReferenceSchemaUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("abc2d3f4-826b-4178-b0c1-b277e94aed5f")
			};
		}

		protected virtual EntitySchemaColumn CreateGPSNColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("b903e71d-74cd-4b79-9dd9-d0c84ef6ad44"),
				Name = @"GPSN",
				IsValueCloneable = false,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("88ca8859-5a70-4347-94ce-f17e86447db4")
			};
		}

		protected virtual EntitySchemaColumn CreateGPSEColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("b9021fa0-6606-4027-8335-bf0624b58218"),
				Name = @"GPSE",
				IsValueCloneable = false,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("88ca8859-5a70-4347-94ce-f17e86447db4")
			};
		}

		protected virtual EntitySchemaColumn CreateSurnameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("771a60e2-020c-4dd2-8512-b428b8a47dba"),
				Name = @"Surname",
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847")
			};
		}

		protected virtual EntitySchemaColumn CreateGivenNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("cc26b1c5-4254-4287-9c15-0b5acd319811"),
				Name = @"GivenName",
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847")
			};
		}

		protected virtual EntitySchemaColumn CreateMiddleNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("33a879a3-d466-4b3f-b529-377a69ff0819"),
				Name = @"MiddleName",
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847")
			};
		}

		protected virtual EntitySchemaColumn CreateConfirmedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("ced280cc-7423-4175-9896-ea592a9e81a6"),
				Name = @"Confirmed",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("4fc0058c-8585-4c70-9e25-887f84d29fa9"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"True"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateLanguageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a855b7ae-45be-4d73-9074-9d84e4ae66c4"),
				Name = @"Language",
				ReferenceSchemaUId = new Guid("2f96cb61-7e14-41e5-980a-bcb856edab51"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateAgeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("bcdc7a32-4332-4caf-858d-0078b56856fe"),
				Name = @"Age",
				CreatedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				ModifiedInSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateContact_Base_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateContact_Base_TerrasoftEventsProcessSchema() {
			var schema = new Contact_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Contact_Base_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Contact_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Contact_Base_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Contact_Base_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"));
		}

		#endregion

	}

	#endregion

	#region Class: Contact_Base_Terrasoft

	/// <summary>
	/// Contact.
	/// </summary>
	public class Contact_Base_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public Contact_Base_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Contact_Base_Terrasoft";
		}

		public Contact_Base_Terrasoft(Contact_Base_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Full name.
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

		/// <summary>
		/// Recipient's name.
		/// </summary>
		public string Dear {
			get {
				return GetTypedColumnValue<string>("Dear");
			}
			set {
				SetColumnValue("Dear", value);
			}
		}

		/// <exclude/>
		public Guid SalutationTypeId {
			get {
				return GetTypedColumnValue<Guid>("SalutationTypeId");
			}
			set {
				SetColumnValue("SalutationTypeId", value);
				_salutationType = null;
			}
		}

		/// <exclude/>
		public string SalutationTypeName {
			get {
				return GetTypedColumnValue<string>("SalutationTypeName");
			}
			set {
				SetColumnValue("SalutationTypeName", value);
				if (_salutationType != null) {
					_salutationType.Name = value;
				}
			}
		}

		private ContactSalutationType _salutationType;
		/// <summary>
		/// Title.
		/// </summary>
		public ContactSalutationType SalutationType {
			get {
				return _salutationType ??
					(_salutationType = LookupColumnEntities.GetEntity("SalutationType") as ContactSalutationType);
			}
		}

		/// <exclude/>
		public Guid GenderId {
			get {
				return GetTypedColumnValue<Guid>("GenderId");
			}
			set {
				SetColumnValue("GenderId", value);
				_gender = null;
			}
		}

		/// <exclude/>
		public string GenderName {
			get {
				return GetTypedColumnValue<string>("GenderName");
			}
			set {
				SetColumnValue("GenderName", value);
				if (_gender != null) {
					_gender.Name = value;
				}
			}
		}

		private Gender _gender;
		/// <summary>
		/// Gender.
		/// </summary>
		public Gender Gender {
			get {
				return _gender ??
					(_gender = LookupColumnEntities.GetEntity("Gender") as Gender);
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
		public Guid DecisionRoleId {
			get {
				return GetTypedColumnValue<Guid>("DecisionRoleId");
			}
			set {
				SetColumnValue("DecisionRoleId", value);
				_decisionRole = null;
			}
		}

		/// <exclude/>
		public string DecisionRoleName {
			get {
				return GetTypedColumnValue<string>("DecisionRoleName");
			}
			set {
				SetColumnValue("DecisionRoleName", value);
				if (_decisionRole != null) {
					_decisionRole.Name = value;
				}
			}
		}

		private ContactDecisionRole _decisionRole;
		/// <summary>
		/// Role.
		/// </summary>
		public ContactDecisionRole DecisionRole {
			get {
				return _decisionRole ??
					(_decisionRole = LookupColumnEntities.GetEntity("DecisionRole") as ContactDecisionRole);
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

		private ContactType _type;
		/// <summary>
		/// Type.
		/// </summary>
		public ContactType Type {
			get {
				return _type ??
					(_type = LookupColumnEntities.GetEntity("Type") as ContactType);
			}
		}

		/// <exclude/>
		public Guid JobId {
			get {
				return GetTypedColumnValue<Guid>("JobId");
			}
			set {
				SetColumnValue("JobId", value);
				_job = null;
			}
		}

		/// <exclude/>
		public string JobName {
			get {
				return GetTypedColumnValue<string>("JobName");
			}
			set {
				SetColumnValue("JobName", value);
				if (_job != null) {
					_job.Name = value;
				}
			}
		}

		private Job _job;
		/// <summary>
		/// Job title.
		/// </summary>
		public Job Job {
			get {
				return _job ??
					(_job = LookupColumnEntities.GetEntity("Job") as Job);
			}
		}

		/// <summary>
		/// Full job title.
		/// </summary>
		public string JobTitle {
			get {
				return GetTypedColumnValue<string>("JobTitle");
			}
			set {
				SetColumnValue("JobTitle", value);
			}
		}

		/// <exclude/>
		public Guid DepartmentId {
			get {
				return GetTypedColumnValue<Guid>("DepartmentId");
			}
			set {
				SetColumnValue("DepartmentId", value);
				_department = null;
			}
		}

		/// <exclude/>
		public string DepartmentName {
			get {
				return GetTypedColumnValue<string>("DepartmentName");
			}
			set {
				SetColumnValue("DepartmentName", value);
				if (_department != null) {
					_department.Name = value;
				}
			}
		}

		private Department _department;
		/// <summary>
		/// Department.
		/// </summary>
		public Department Department {
			get {
				return _department ??
					(_department = LookupColumnEntities.GetEntity("Department") as Department);
			}
		}

		/// <summary>
		/// Birth date.
		/// </summary>
		public DateTime BirthDate {
			get {
				return GetTypedColumnValue<DateTime>("BirthDate");
			}
			set {
				SetColumnValue("BirthDate", value);
			}
		}

		/// <summary>
		/// Business phone.
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
		/// Mobile phone.
		/// </summary>
		public string MobilePhone {
			get {
				return GetTypedColumnValue<string>("MobilePhone");
			}
			set {
				SetColumnValue("MobilePhone", value);
			}
		}

		/// <summary>
		/// Home phone.
		/// </summary>
		public string HomePhone {
			get {
				return GetTypedColumnValue<string>("HomePhone");
			}
			set {
				SetColumnValue("HomePhone", value);
			}
		}

		/// <summary>
		/// Skype.
		/// </summary>
		public string Skype {
			get {
				return GetTypedColumnValue<string>("Skype");
			}
			set {
				SetColumnValue("Skype", value);
			}
		}

		/// <summary>
		/// Email.
		/// </summary>
		public string Email {
			get {
				return GetTypedColumnValue<string>("Email");
			}
			set {
				SetColumnValue("Email", value);
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

		/// <summary>
		/// Do not use email.
		/// </summary>
		public bool DoNotUseEmail {
			get {
				return GetTypedColumnValue<bool>("DoNotUseEmail");
			}
			set {
				SetColumnValue("DoNotUseEmail", value);
			}
		}

		/// <summary>
		/// Do not use phone.
		/// </summary>
		public bool DoNotUseCall {
			get {
				return GetTypedColumnValue<bool>("DoNotUseCall");
			}
			set {
				SetColumnValue("DoNotUseCall", value);
			}
		}

		/// <summary>
		/// Do not use fax.
		/// </summary>
		public bool DoNotUseFax {
			get {
				return GetTypedColumnValue<bool>("DoNotUseFax");
			}
			set {
				SetColumnValue("DoNotUseFax", value);
			}
		}

		/// <summary>
		/// Do not use SMS.
		/// </summary>
		public bool DoNotUseSms {
			get {
				return GetTypedColumnValue<bool>("DoNotUseSms");
			}
			set {
				SetColumnValue("DoNotUseSms", value);
			}
		}

		/// <summary>
		/// Do not use mail.
		/// </summary>
		public bool DoNotUseMail {
			get {
				return GetTypedColumnValue<bool>("DoNotUseMail");
			}
			set {
				SetColumnValue("DoNotUseMail", value);
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
		/// Facebook.
		/// </summary>
		public string Facebook {
			get {
				return GetTypedColumnValue<string>("Facebook");
			}
			set {
				SetColumnValue("Facebook", value);
			}
		}

		/// <summary>
		/// LinkedIn.
		/// </summary>
		public string LinkedIn {
			get {
				return GetTypedColumnValue<string>("LinkedIn");
			}
			set {
				SetColumnValue("LinkedIn", value);
			}
		}

		/// <summary>
		/// Twitter.
		/// </summary>
		public string Twitter {
			get {
				return GetTypedColumnValue<string>("Twitter");
			}
			set {
				SetColumnValue("Twitter", value);
			}
		}

		/// <summary>
		/// FacebookId.
		/// </summary>
		public string FacebookId {
			get {
				return GetTypedColumnValue<string>("FacebookId");
			}
			set {
				SetColumnValue("FacebookId", value);
			}
		}

		/// <summary>
		/// LinkedInId.
		/// </summary>
		public string LinkedInId {
			get {
				return GetTypedColumnValue<string>("LinkedInId");
			}
			set {
				SetColumnValue("LinkedInId", value);
			}
		}

		/// <summary>
		/// TwitterId.
		/// </summary>
		public string TwitterId {
			get {
				return GetTypedColumnValue<string>("TwitterId");
			}
			set {
				SetColumnValue("TwitterId", value);
			}
		}

		/// <exclude/>
		public Guid TwitterAFDAId {
			get {
				return GetTypedColumnValue<Guid>("TwitterAFDAId");
			}
			set {
				SetColumnValue("TwitterAFDAId", value);
				_twitterAFDA = null;
			}
		}

		/// <exclude/>
		public string TwitterAFDALogin {
			get {
				return GetTypedColumnValue<string>("TwitterAFDALogin");
			}
			set {
				SetColumnValue("TwitterAFDALogin", value);
				if (_twitterAFDA != null) {
					_twitterAFDA.Login = value;
				}
			}
		}

		private SocialAccount _twitterAFDA;
		/// <summary>
		/// Twitter Account for Data Access.
		/// </summary>
		/// <remarks>
		/// Twitter Account for Data Access.
		/// </remarks>
		public SocialAccount TwitterAFDA {
			get {
				return _twitterAFDA ??
					(_twitterAFDA = LookupColumnEntities.GetEntity("TwitterAFDA") as SocialAccount);
			}
		}

		/// <exclude/>
		public Guid FacebookAFDAId {
			get {
				return GetTypedColumnValue<Guid>("FacebookAFDAId");
			}
			set {
				SetColumnValue("FacebookAFDAId", value);
				_facebookAFDA = null;
			}
		}

		/// <exclude/>
		public string FacebookAFDALogin {
			get {
				return GetTypedColumnValue<string>("FacebookAFDALogin");
			}
			set {
				SetColumnValue("FacebookAFDALogin", value);
				if (_facebookAFDA != null) {
					_facebookAFDA.Login = value;
				}
			}
		}

		private SocialAccount _facebookAFDA;
		/// <summary>
		/// Facebook Account for Data Access.
		/// </summary>
		/// <remarks>
		/// Facebook Account for Data Access.
		/// </remarks>
		public SocialAccount FacebookAFDA {
			get {
				return _facebookAFDA ??
					(_facebookAFDA = LookupColumnEntities.GetEntity("FacebookAFDA") as SocialAccount);
			}
		}

		/// <exclude/>
		public Guid LinkedInAFDAId {
			get {
				return GetTypedColumnValue<Guid>("LinkedInAFDAId");
			}
			set {
				SetColumnValue("LinkedInAFDAId", value);
				_linkedInAFDA = null;
			}
		}

		/// <exclude/>
		public string LinkedInAFDALogin {
			get {
				return GetTypedColumnValue<string>("LinkedInAFDALogin");
			}
			set {
				SetColumnValue("LinkedInAFDALogin", value);
				if (_linkedInAFDA != null) {
					_linkedInAFDA.Login = value;
				}
			}
		}

		private SocialAccount _linkedInAFDA;
		/// <summary>
		/// LinkedIn Account for Data Access.
		/// </summary>
		/// <remarks>
		/// LinkedIn Account for Data Access.
		/// </remarks>
		public SocialAccount LinkedInAFDA {
			get {
				return _linkedInAFDA ??
					(_linkedInAFDA = LookupColumnEntities.GetEntity("LinkedInAFDA") as SocialAccount);
			}
		}

		/// <exclude/>
		public Guid PhotoId {
			get {
				return GetTypedColumnValue<Guid>("PhotoId");
			}
			set {
				SetColumnValue("PhotoId", value);
				_photo = null;
			}
		}

		/// <exclude/>
		public string PhotoName {
			get {
				return GetTypedColumnValue<string>("PhotoName");
			}
			set {
				SetColumnValue("PhotoName", value);
				if (_photo != null) {
					_photo.Name = value;
				}
			}
		}

		private SysImage _photo;
		/// <summary>
		/// Photo.
		/// </summary>
		public SysImage Photo {
			get {
				return _photo ??
					(_photo = LookupColumnEntities.GetEntity("Photo") as SysImage);
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

		/// <summary>
		/// Last name.
		/// </summary>
		public string Surname {
			get {
				return GetTypedColumnValue<string>("Surname");
			}
			set {
				SetColumnValue("Surname", value);
			}
		}

		/// <summary>
		/// First name.
		/// </summary>
		public string GivenName {
			get {
				return GetTypedColumnValue<string>("GivenName");
			}
			set {
				SetColumnValue("GivenName", value);
			}
		}

		/// <summary>
		/// Middle name.
		/// </summary>
		public string MiddleName {
			get {
				return GetTypedColumnValue<string>("MiddleName");
			}
			set {
				SetColumnValue("MiddleName", value);
			}
		}

		/// <summary>
		/// Confirmed.
		/// </summary>
		public bool Confirmed {
			get {
				return GetTypedColumnValue<bool>("Confirmed");
			}
			set {
				SetColumnValue("Confirmed", value);
			}
		}

		/// <exclude/>
		public Guid LanguageId {
			get {
				return GetTypedColumnValue<Guid>("LanguageId");
			}
			set {
				SetColumnValue("LanguageId", value);
				_language = null;
			}
		}

		/// <exclude/>
		public string LanguageName {
			get {
				return GetTypedColumnValue<string>("LanguageName");
			}
			set {
				SetColumnValue("LanguageName", value);
				if (_language != null) {
					_language.Name = value;
				}
			}
		}

		private SysLanguage _language;
		/// <summary>
		/// Preferred language.
		/// </summary>
		public SysLanguage Language {
			get {
				return _language ??
					(_language = LookupColumnEntities.GetEntity("Language") as SysLanguage);
			}
		}

		/// <summary>
		/// Age.
		/// </summary>
		public int Age {
			get {
				return GetTypedColumnValue<int>("Age");
			}
			set {
				SetColumnValue("Age", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Contact_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Contact_Base_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("Contact_Base_TerrasoftDeleting", e);
			Inserting += (s, e) => ThrowEvent("Contact_Base_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("Contact_Base_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Contact_Base_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Contact_Base_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Contact_Base_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Contact_BaseEventsProcess

	/// <exclude/>
	public partial class Contact_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : Contact_Base_Terrasoft
	{

		#region Class: SynchronizeAnniversaryFlowElement

		/// <exclude/>
		public class SynchronizeAnniversaryFlowElement : SynchronizeChildEntityData
		{

			public SynchronizeAnniversaryFlowElement(UserConnection userConnection, Contact_BaseEventsProcess<TEntity> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "SynchronizeAnniversary";
				IsLogging = false;
				SchemaElementUId = new Guid("3a05881c-2d6c-4b29-aced-b2e655151398");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public Contact_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Contact_BaseEventsProcess";
			SchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private bool _isCareerChanged = true;
		public bool IsCareerChanged {
			get {
				return _isCareerChanged;
			}
			set {
				_isCareerChanged = value;
			}
		}

		public virtual bool Current {
			get;
			set;
		}

		private bool _needUpdate = true;
		public bool NeedUpdate {
			get {
				return _needUpdate;
			}
			set {
				_needUpdate = value;
			}
		}

		public virtual Object ProcessSchemaParameter1 {
			get;
			set;
		}

		public virtual bool IsCurrentUserPhoroChanged {
			get;
			set;
		}

		public virtual bool NeedUpdateCareer {
			get;
			set;
		}

		public virtual bool NeedInsertCareer {
			get;
			set;
		}

		public virtual Object CommunicationSynchronizer {
			get;
			set;
		}

		public virtual bool NeedDeleteCareer {
			get;
			set;
		}

		public virtual Guid PreviousAccountValue {
			get;
			set;
		}

		public virtual bool CanGenerateAnniversaryReminding {
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
					SchemaElementUId = new Guid("ac1862f6-5081-47bb-9e5a-1d801f37648e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _contactSaved;
		public ProcessFlowElement ContactSaved {
			get {
				return _contactSaved ?? (_contactSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ContactSaved",
					SchemaElementUId = new Guid("767e7517-bb79-4680-b6e3-4fe8162501e6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _synchronizeContactAddressScriptTask;
		public ProcessScriptTask SynchronizeContactAddressScriptTask {
			get {
				return _synchronizeContactAddressScriptTask ?? (_synchronizeContactAddressScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SynchronizeContactAddressScriptTask",
					SchemaElementUId = new Guid("193c9932-6748-4236-bea9-d5cc48807672"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SynchronizeContactAddressScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _synchronizeContactCommunication;
		public ProcessScriptTask SynchronizeContactCommunication {
			get {
				return _synchronizeContactCommunication ?? (_synchronizeContactCommunication = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SynchronizeContactCommunication",
					SchemaElementUId = new Guid("baff5e90-c8e3-4458-927d-dbeb1b295e9f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SynchronizeContactCommunicationExecute,
				});
			}
		}

		private ProcessScriptTask _scriptSynchronizeAnniversary;
		public ProcessScriptTask ScriptSynchronizeAnniversary {
			get {
				return _scriptSynchronizeAnniversary ?? (_scriptSynchronizeAnniversary = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptSynchronizeAnniversary",
					SchemaElementUId = new Guid("4a1a63ac-66ea-4123-981f-52c401d078ba"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptSynchronizeAnniversaryExecute,
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
					SchemaElementUId = new Guid("2e282bfa-9287-4113-a46a-da1bbec3b4de"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = UpdateRemindingsExecute,
				});
			}
		}

		private SynchronizeAnniversaryFlowElement _synchronizeAnniversary;
		public SynchronizeAnniversaryFlowElement SynchronizeAnniversary {
			get {
				return _synchronizeAnniversary ?? (_synchronizeAnniversary = new SynchronizeAnniversaryFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _updateCareerScriptTask;
		public ProcessScriptTask UpdateCareerScriptTask {
			get {
				return _updateCareerScriptTask ?? (_updateCareerScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "UpdateCareerScriptTask",
					SchemaElementUId = new Guid("5d623849-3c39-4bb3-b94c-9678cb0a2ae8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = UpdateCareerScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _synchronizeNameScriptTast;
		public ProcessScriptTask SynchronizeNameScriptTast {
			get {
				return _synchronizeNameScriptTast ?? (_synchronizeNameScriptTast = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SynchronizeNameScriptTast",
					SchemaElementUId = new Guid("1d75978c-1eba-428d-98de-6319ff5257b3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SynchronizeNameScriptTastExecute,
				});
			}
		}

		private ProcessFlowElement _contactSavingEventSubProcess;
		public ProcessFlowElement ContactSavingEventSubProcess {
			get {
				return _contactSavingEventSubProcess ?? (_contactSavingEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ContactSavingEventSubProcess",
					SchemaElementUId = new Guid("a8975df4-ae3d-4cfa-ad27-0666ece40f37"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _contactSaving;
		public ProcessFlowElement ContactSaving {
			get {
				return _contactSaving ?? (_contactSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ContactSaving",
					SchemaElementUId = new Guid("5e79f0ee-c33c-44ea-88e2-6375b47106ca"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _contactSavingScriptTask;
		public ProcessScriptTask ContactSavingScriptTask {
			get {
				return _contactSavingScriptTask ?? (_contactSavingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ContactSavingScriptTask",
					SchemaElementUId = new Guid("a858ee01-adbc-4740-b449-e5868ac1cbf2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ContactSavingScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess2s;
		public ProcessFlowElement EventSubProcess2s {
			get {
				return _eventSubProcess2s ?? (_eventSubProcess2s = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess2s",
					SchemaElementUId = new Guid("bd823e8f-6967-4022-a2b8-1e23cd411050"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _contactDeleting;
		public ProcessFlowElement ContactDeleting {
			get {
				return _contactDeleting ?? (_contactDeleting = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ContactDeleting",
					SchemaElementUId = new Guid("d4f5150a-1aab-4bf4-98ca-e891eb03ff43"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _synchronizeContactCorrespondenceScriptTask;
		public ProcessScriptTask SynchronizeContactCorrespondenceScriptTask {
			get {
				return _synchronizeContactCorrespondenceScriptTask ?? (_synchronizeContactCorrespondenceScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SynchronizeContactCorrespondenceScriptTask",
					SchemaElementUId = new Guid("d1983277-3250-4b98-bef8-5f3dc94fccaf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SynchronizeContactCorrespondenceScriptTaskExecute,
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
					SchemaElementUId = new Guid("12d88f28-b68f-4628-98fa-d1d76ebb3050"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _contactDeleted;
		public ProcessFlowElement ContactDeleted {
			get {
				return _contactDeleted ?? (_contactDeleted = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ContactDeleted",
					SchemaElementUId = new Guid("b610ca25-5e69-4cfe-b077-c0ba24de5e5f"),
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
					SchemaElementUId = new Guid("52789257-7720-4840-982e-f8dcd9e06a89"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DeleteRemindingsExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[ContactSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { ContactSaved };
			FlowElements[SynchronizeContactAddressScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SynchronizeContactAddressScriptTask };
			FlowElements[SynchronizeContactCommunication.SchemaElementUId] = new Collection<ProcessFlowElement> { SynchronizeContactCommunication };
			FlowElements[ScriptSynchronizeAnniversary.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptSynchronizeAnniversary };
			FlowElements[UpdateRemindings.SchemaElementUId] = new Collection<ProcessFlowElement> { UpdateRemindings };
			FlowElements[SynchronizeAnniversary.SchemaElementUId] = new Collection<ProcessFlowElement> { SynchronizeAnniversary };
			FlowElements[UpdateCareerScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { UpdateCareerScriptTask };
			FlowElements[SynchronizeNameScriptTast.SchemaElementUId] = new Collection<ProcessFlowElement> { SynchronizeNameScriptTast };
			FlowElements[ContactSavingEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ContactSavingEventSubProcess };
			FlowElements[ContactSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { ContactSaving };
			FlowElements[ContactSavingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ContactSavingScriptTask };
			FlowElements[EventSubProcess2s.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2s };
			FlowElements[ContactDeleting.SchemaElementUId] = new Collection<ProcessFlowElement> { ContactDeleting };
			FlowElements[SynchronizeContactCorrespondenceScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SynchronizeContactCorrespondenceScriptTask };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[ContactDeleted.SchemaElementUId] = new Collection<ProcessFlowElement> { ContactDeleted };
			FlowElements[DeleteRemindings.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteRemindings };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "ContactSaved":
						e.Context.QueueTasks.Enqueue("SynchronizeContactAddressScriptTask");
						e.Context.QueueTasks.Enqueue("SynchronizeContactCommunication");
						e.Context.QueueTasks.Enqueue("ScriptSynchronizeAnniversary");
						e.Context.QueueTasks.Enqueue("UpdateRemindings");
						e.Context.QueueTasks.Enqueue("UpdateCareerScriptTask");
						e.Context.QueueTasks.Enqueue("SynchronizeNameScriptTast");
						break;
					case "SynchronizeContactAddressScriptTask":
						break;
					case "SynchronizeContactCommunication":
						break;
					case "ScriptSynchronizeAnniversary":
						e.Context.QueueTasks.Enqueue("SynchronizeAnniversary");
						break;
					case "UpdateRemindings":
						break;
					case "SynchronizeAnniversary":
						break;
					case "UpdateCareerScriptTask":
						break;
					case "SynchronizeNameScriptTast":
						break;
					case "ContactSavingEventSubProcess":
						break;
					case "ContactSaving":
						e.Context.QueueTasks.Enqueue("ContactSavingScriptTask");
						break;
					case "ContactSavingScriptTask":
						break;
					case "EventSubProcess2s":
						break;
					case "ContactDeleting":
						e.Context.QueueTasks.Enqueue("SynchronizeContactCorrespondenceScriptTask");
						break;
					case "SynchronizeContactCorrespondenceScriptTask":
						break;
					case "EventSubProcess2":
						break;
					case "ContactDeleted":
						e.Context.QueueTasks.Enqueue("DeleteRemindings");
						break;
					case "DeleteRemindings":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ContactSaved");
			ActivatedEventElements.Add("ContactSaving");
			ActivatedEventElements.Add("ContactDeleting");
			ActivatedEventElements.Add("ContactDeleted");
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
				case "ContactSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "ContactSaved";
					result = ContactSaved.Execute(context);
					break;
				case "SynchronizeContactAddressScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SynchronizeContactAddressScriptTask";
					result = SynchronizeContactAddressScriptTask.Execute(context, SynchronizeContactAddressScriptTaskExecute);
					break;
				case "SynchronizeContactCommunication":
					context.QueueTasks.Dequeue();
					context.SenderName = "SynchronizeContactCommunication";
					result = SynchronizeContactCommunication.Execute(context, SynchronizeContactCommunicationExecute);
					break;
				case "ScriptSynchronizeAnniversary":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptSynchronizeAnniversary";
					result = ScriptSynchronizeAnniversary.Execute(context, ScriptSynchronizeAnniversaryExecute);
					break;
				case "UpdateRemindings":
					context.QueueTasks.Dequeue();
					context.SenderName = "UpdateRemindings";
					result = UpdateRemindings.Execute(context, UpdateRemindingsExecute);
					break;
				case "SynchronizeAnniversary":
					context.QueueTasks.Dequeue();
					context.SenderName = "SynchronizeAnniversary";
					result = SynchronizeAnniversary.Execute(context);
					break;
				case "UpdateCareerScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "UpdateCareerScriptTask";
					result = UpdateCareerScriptTask.Execute(context, UpdateCareerScriptTaskExecute);
					break;
				case "SynchronizeNameScriptTast":
					context.QueueTasks.Dequeue();
					context.SenderName = "SynchronizeNameScriptTast";
					result = SynchronizeNameScriptTast.Execute(context, SynchronizeNameScriptTastExecute);
					break;
				case "ContactSavingEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ContactSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "ContactSaving";
					result = ContactSaving.Execute(context);
					break;
				case "ContactSavingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ContactSavingScriptTask";
					result = ContactSavingScriptTask.Execute(context, ContactSavingScriptTaskExecute);
					break;
				case "EventSubProcess2s":
					context.QueueTasks.Dequeue();
					break;
				case "ContactDeleting":
					context.QueueTasks.Dequeue();
					context.SenderName = "ContactDeleting";
					result = ContactDeleting.Execute(context);
					break;
				case "SynchronizeContactCorrespondenceScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SynchronizeContactCorrespondenceScriptTask";
					result = SynchronizeContactCorrespondenceScriptTask.Execute(context, SynchronizeContactCorrespondenceScriptTaskExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "ContactDeleted":
					context.QueueTasks.Dequeue();
					context.SenderName = "ContactDeleted";
					result = ContactDeleted.Execute(context);
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
				case "CanGenerateAnniversaryReminding":
					CanGenerateAnniversaryReminding = reader.GetValue<System.Boolean>();
				break;
				case "PreviousAccountValue":
					PreviousAccountValue = reader.GetValue<System.Guid>();
				break;
				case "NeedDeleteCareer":
					NeedDeleteCareer = reader.GetValue<System.Boolean>();
				break;
				case "CommunicationSynchronizer":
					CommunicationSynchronizer = reader.GetSerializableObjectValue();
				break;
				case "NeedInsertCareer":
					NeedInsertCareer = reader.GetValue<System.Boolean>();
				break;
				case "NeedUpdateCareer":
					NeedUpdateCareer = reader.GetValue<System.Boolean>();
				break;
				case "IsCurrentUserPhoroChanged":
					IsCurrentUserPhoroChanged = reader.GetValue<System.Boolean>();
				break;
				case "ProcessSchemaParameter1":
					ProcessSchemaParameter1 = reader.GetSerializableObjectValue();
				break;
				case "NeedUpdate":
					NeedUpdate = reader.GetValue<System.Boolean>();
				break;
				case "Current":
					Current = reader.GetValue<System.Boolean>();
				break;
				case "IsCareerChanged":
					IsCareerChanged = reader.GetValue<System.Boolean>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool SynchronizeContactAddressScriptTaskExecute(ProcessExecutingContext context) {
			return SynchronizeContactAddress();
		}

		public virtual bool SynchronizeContactCommunicationExecute(ProcessExecutingContext context) {
			return SynchronizeCommunication();
		}

		public virtual bool ScriptSynchronizeAnniversaryExecute(ProcessExecutingContext context) {
			var ContactAnniversarySchema = UserConnection.EntitySchemaManager.GetInstanceByName("ContactAnniversary");
			Guid columnUId;
			Guid childObjectColumnUId;
			
			var mappingCoulmns = new System.Collections.Generic.Dictionary<
			Guid, System.Collections.Generic.Dictionary<
			Guid, object>>();
			var searchFilters = new System.Collections.Generic.Dictionary<
			Guid, object>();
			
			//--------------- Filters ----------------
			childObjectColumnUId = ContactAnniversarySchema.Columns.GetByName("Contact").UId;
			searchFilters.Add(childObjectColumnUId, Entity.GetColumnValue(Entity.Schema.GetPrimaryColumnName()));
			
			childObjectColumnUId = ContactAnniversarySchema.Columns.GetByName("AnniversaryType").UId;
			searchFilters.Add(childObjectColumnUId, new Guid("173D56D2-FDCA-DF11-9B2A-001D60E938C6"));
			
			
			//--------------- Map Params ----------------
			columnUId = Entity.Schema.Columns.GetByName("BirthDate").UId;
			childObjectColumnUId = ContactAnniversarySchema.Columns.GetByName("Date").UId;
			var column = new System.Collections.Generic.Dictionary<
			Guid, object>();
			column.Add(childObjectColumnUId, columnUId);
			mappingCoulmns.Add(columnUId, column);
			
			columnUId = Entity.Schema.Columns.GetByName("Id").UId;
			childObjectColumnUId = ContactAnniversarySchema.Columns.GetByName("Contact").UId;
			column = new System.Collections.Generic.Dictionary<
			Guid, object>();
			column.Add(childObjectColumnUId, columnUId);
			mappingCoulmns.Add(columnUId, column);
			
			//--------------- Def Values ----------------
			var defaultValues = new System.Collections.Generic.Dictionary<
			Guid, object>();
			childObjectColumnUId = ContactAnniversarySchema.Columns.GetByName("AnniversaryType").UId;
			defaultValues.Add(childObjectColumnUId, new Guid("173D56D2-FDCA-DF11-9B2A-001D60E938C6"));
			
			SynchronizeAnniversary.ChildEntitySchemaUId = new Guid("FA36E9A5-C2FC-47B2-B5CB-2B58EF61D4E6");
			SynchronizeAnniversary.SingleRowSearchFilters = searchFilters;
			SynchronizeAnniversary.MappingColumns = mappingCoulmns;
			SynchronizeAnniversary.DefaultValues = defaultValues;
			SynchronizeAnniversary.RequiredFields = new string[]{"Date"};
			SynchronizeAnniversary.RequiredAllFields = true;
			
			
			return true;
		}

		public virtual bool UpdateRemindingsExecute(ProcessExecutingContext context) {
			ExecuteUpdateRemindings();
			return true;
		}

		public virtual bool UpdateCareerScriptTaskExecute(ProcessExecutingContext context) {
			ChangeCareer();
			return true;
		}

		public virtual bool SynchronizeNameScriptTastExecute(ProcessExecutingContext context) {
			SynchronizeContactName();
			return true;
		}

		public virtual bool ContactSavingScriptTaskExecute(ProcessExecutingContext context) {
			IsCurrentUserPhoroChanged = (Entity.GetTypedColumnValue<Guid>("PhotoId") !=
				Entity.GetTypedOldColumnValue<Guid>("PhotoId") && Entity.GetTypedColumnValue<Guid>("Id") ==
			UserConnection.CurrentUser.ContactId);
			PreviousAccountValue = Entity.GetTypedOldColumnValue<Guid>("AccountId");
			FillSgmOrNameField();
			CheckIsCareerChanged();
			InitializeCommunicationSynchronizer();
			InitCanGenerateAnniversaryReminding();
			UpdateContactAge();
			return true;
		}

		public virtual bool SynchronizeContactCorrespondenceScriptTaskExecute(ProcessExecutingContext context) {
			new Update(UserConnection, "ContactCorrespondence")
				.Set("ModifiedOn", Column.Parameter(DateTime.UtcNow))
				.Where("ContactId").IsEqual(Column.Parameter(Entity.PrimaryColumnValue)).Execute();
			return true;
		}

		public virtual bool DeleteRemindingsExecute(ProcessExecutingContext context) {
			ExecuteDeleteRemindings();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Contact_Base_TerrasoftSaved":
							if (ActivatedEventElements.Contains("ContactSaved")) {
							context.QueueTasks.Enqueue("ContactSaved");
						}
						break;
					case "Contact_Base_TerrasoftSaving":
							if (ActivatedEventElements.Contains("ContactSaving")) {
							context.QueueTasks.Enqueue("ContactSaving");
						}
						break;
					case "Contact_Base_TerrasoftDeleting":
							if (ActivatedEventElements.Contains("ContactDeleting")) {
							context.QueueTasks.Enqueue("ContactDeleting");
						}
						break;
					case "Contact_Base_TerrasoftDeleted":
							if (ActivatedEventElements.Contains("ContactDeleted")) {
							context.QueueTasks.Enqueue("ContactDeleted");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("CanGenerateAnniversaryReminding") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CanGenerateAnniversaryReminding", CanGenerateAnniversaryReminding, false);
			}
			if (!HasMapping("PreviousAccountValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("PreviousAccountValue", PreviousAccountValue, Guid.Empty);
			}
			if (!HasMapping("NeedDeleteCareer") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("NeedDeleteCareer", NeedDeleteCareer, false);
			}
			if (CommunicationSynchronizer != null) {
				if (CommunicationSynchronizer.GetType().IsSerializable ||
					CommunicationSynchronizer.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("CommunicationSynchronizer", CommunicationSynchronizer, null);
				}
			}
			if (!HasMapping("NeedInsertCareer") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("NeedInsertCareer", NeedInsertCareer, false);
			}
			if (!HasMapping("NeedUpdateCareer") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("NeedUpdateCareer", NeedUpdateCareer, false);
			}
			if (!HasMapping("IsCurrentUserPhoroChanged") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsCurrentUserPhoroChanged", IsCurrentUserPhoroChanged, false);
			}
			if (ProcessSchemaParameter1 != null) {
				if (ProcessSchemaParameter1.GetType().IsSerializable ||
					ProcessSchemaParameter1.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ProcessSchemaParameter1", ProcessSchemaParameter1, null);
				}
			}
			if (!HasMapping("NeedUpdate") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("NeedUpdate", NeedUpdate, false);
			}
			if (!HasMapping("Current") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("Current", Current, false);
			}
			if (!HasMapping("IsCareerChanged") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsCareerChanged", IsCareerChanged, false);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: Contact_BaseEventsProcess

	/// <exclude/>
	public class Contact_BaseEventsProcess : Contact_BaseEventsProcess<Contact_Base_Terrasoft>
	{

		public Contact_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Contact_Base_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Contact_Base_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public Contact_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Contact_Base_TerrasoftEventsProcessSchema(Contact_Base_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Contact_BaseEventsProcess";
			UId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e");
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

		protected virtual ProcessSchemaParameter CreateIsCareerChangedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("fed8b535-5a6d-410a-9b4f-7c520fab2a86"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Name = @"IsCareerChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"true",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateCurrentParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9a8a8dc2-a148-4b44-944d-94716b7473a2"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Name = @"Current",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNeedUpdateParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("0b5d12e0-bdd2-44fd-bb72-9f1376286b65"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Name = @"NeedUpdate",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"true",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateProcessSchemaParameter1Parameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4e8d1a71-e5f0-4b62-8e30-a26345c7e742"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Name = @"ProcessSchemaParameter1",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsCurrentUserPhoroChangedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9d8fb529-c128-46eb-81be-055ba54c338c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Name = @"IsCurrentUserPhoroChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNeedUpdateCareerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("185c81c9-d5c0-4790-979d-d898e94badb7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Name = @"NeedUpdateCareer",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNeedInsertCareerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4fe289ac-460a-4886-9535-bfaeb8ce1013"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Name = @"NeedInsertCareer",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCommunicationSynchronizerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("83e70ae2-4c61-45b1-9c35-880061102403"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Name = @"CommunicationSynchronizer",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNeedDeleteCareerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("61f121da-53b2-4637-9af1-209fdad29018"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Name = @"NeedDeleteCareer",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreatePreviousAccountValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("016fa794-770f-4d4d-8762-66081ee15da8"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Name = @"PreviousAccountValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCanGenerateAnniversaryRemindingParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("66dbb801-577d-4bd3-bcf1-f82fefb88d71"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Name = @"CanGenerateAnniversaryReminding",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateIsCareerChangedParameter());
			Parameters.Add(CreateCurrentParameter());
			Parameters.Add(CreateNeedUpdateParameter());
			Parameters.Add(CreateProcessSchemaParameter1Parameter());
			Parameters.Add(CreateIsCurrentUserPhoroChangedParameter());
			Parameters.Add(CreateNeedUpdateCareerParameter());
			Parameters.Add(CreateNeedInsertCareerParameter());
			Parameters.Add(CreateCommunicationSynchronizerParameter());
			Parameters.Add(CreateNeedDeleteCareerParameter());
			Parameters.Add(CreatePreviousAccountValueParameter());
			Parameters.Add(CreateCanGenerateAnniversaryRemindingParameter());
		}

		protected virtual void InitializeSynchronizeAnniversaryParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("8500abdc-9ced-4229-9815-25719c9c3c2a"),
				ContainerUId = new Guid("3a05881c-2d6c-4b29-aced-b2e655151398"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Name = @"ChildEntitySchemaUId",
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
				UId = new Guid("3c556009-b40c-49ea-badc-7d8832462f18"),
				ContainerUId = new Guid("3a05881c-2d6c-4b29-aced-b2e655151398"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Name = @"SingleRowSearchFilters",
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
				UId = new Guid("e9a9c647-5a19-42cd-95c7-11c56cbc4eb1"),
				ContainerUId = new Guid("3a05881c-2d6c-4b29-aced-b2e655151398"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Name = @"MultiRowsSearchFilters",
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
				UId = new Guid("d8ba2ecc-0748-487c-98da-53c4ab8f97c5"),
				ContainerUId = new Guid("3a05881c-2d6c-4b29-aced-b2e655151398"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Name = @"MappingColumns",
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
				UId = new Guid("696d891e-711a-4767-ae1b-4e487ab8b199"),
				ContainerUId = new Guid("3a05881c-2d6c-4b29-aced-b2e655151398"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Name = @"DefaultValues",
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
				UId = new Guid("59a2d8f5-ff17-444f-a7e7-b73d77879764"),
				ContainerUId = new Guid("3a05881c-2d6c-4b29-aced-b2e655151398"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Name = @"RequiredAllFields",
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
				UId = new Guid("d6b4f3b9-821a-4bf4-a66c-9e8ea7847938"),
				ContainerUId = new Guid("3a05881c-2d6c-4b29-aced-b2e655151398"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Name = @"RequiredFields",
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
				UId = new Guid("69da10d0-e7d0-472d-9ad8-4636d40ec1b8"),
				ContainerUId = new Guid("3a05881c-2d6c-4b29-aced-b2e655151398"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				Name = @"DeletingFilters",
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
			ProcessSchemaLaneSet schemaLaneSet396 = CreateLaneSet396LaneSet();
			LaneSets.Add(schemaLaneSet396);
			ProcessSchemaLane schemaLane1195 = CreateLane1195Lane();
			schemaLaneSet396.Lanes.Add(schemaLane1195);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess contactsavingeventsubprocess = CreateContactSavingEventSubProcessEventSubProcess();
			FlowElements.Add(contactsavingeventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess2s = CreateEventSubProcess2sEventSubProcess();
			FlowElements.Add(eventsubprocess2s);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaStartMessageEvent contactsaved = CreateContactSavedStartMessageEvent();
			eventsubprocess1.FlowElements.Add(contactsaved);
			ProcessSchemaScriptTask synchronizecontactaddressscripttask = CreateSynchronizeContactAddressScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(synchronizecontactaddressscripttask);
			ProcessSchemaScriptTask synchronizecontactcommunication = CreateSynchronizeContactCommunicationScriptTask();
			eventsubprocess1.FlowElements.Add(synchronizecontactcommunication);
			ProcessSchemaScriptTask scriptsynchronizeanniversary = CreateScriptSynchronizeAnniversaryScriptTask();
			eventsubprocess1.FlowElements.Add(scriptsynchronizeanniversary);
			ProcessSchemaScriptTask updateremindings = CreateUpdateRemindingsScriptTask();
			eventsubprocess1.FlowElements.Add(updateremindings);
			ProcessSchemaUserTask synchronizeanniversary = CreateSynchronizeAnniversaryUserTask();
			eventsubprocess1.FlowElements.Add(synchronizeanniversary);
			ProcessSchemaScriptTask updatecareerscripttask = CreateUpdateCareerScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(updatecareerscripttask);
			ProcessSchemaScriptTask synchronizenamescripttast = CreateSynchronizeNameScriptTastScriptTask();
			eventsubprocess1.FlowElements.Add(synchronizenamescripttast);
			ProcessSchemaStartMessageEvent contactsaving = CreateContactSavingStartMessageEvent();
			contactsavingeventsubprocess.FlowElements.Add(contactsaving);
			ProcessSchemaScriptTask contactsavingscripttask = CreateContactSavingScriptTaskScriptTask();
			contactsavingeventsubprocess.FlowElements.Add(contactsavingscripttask);
			ProcessSchemaStartMessageEvent contactdeleting = CreateContactDeletingStartMessageEvent();
			eventsubprocess2s.FlowElements.Add(contactdeleting);
			ProcessSchemaScriptTask synchronizecontactcorrespondencescripttask = CreateSynchronizeContactCorrespondenceScriptTaskScriptTask();
			eventsubprocess2s.FlowElements.Add(synchronizecontactcorrespondencescripttask);
			ProcessSchemaStartMessageEvent contactdeleted = CreateContactDeletedStartMessageEvent();
			eventsubprocess2.FlowElements.Add(contactdeleted);
			ProcessSchemaScriptTask deleteremindings = CreateDeleteRemindingsScriptTask();
			eventsubprocess2.FlowElements.Add(deleteremindings);
			FlowElements.Add(CreateSequenceFlow6817SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6818SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6821SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6822SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3BasePhotoSequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow223SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6817SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6817",
				UId = new Guid("97688964-7262-4af2-8b85-2c9e5d762bf8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CurveCenterPosition = new Point(176, 198),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("767e7517-bb79-4680-b6e3-4fe8162501e6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("193c9932-6748-4236-bea9-d5cc48807672"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(128, 56));
			schemaFlow.PolylinePointPositions.Add(new Point(128, 70));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6818SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6818",
				UId = new Guid("8817618d-c21e-4e95-a983-c69dc3f2d182"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CurveCenterPosition = new Point(169, 236),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("767e7517-bb79-4680-b6e3-4fe8162501e6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("baff5e90-c8e3-4458-927d-dbeb1b295e9f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(53, 153));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6821SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6821",
				UId = new Guid("7cd3e027-9edc-4029-9b53-51ef8b2d33b0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CurveCenterPosition = new Point(163, 138),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("767e7517-bb79-4680-b6e3-4fe8162501e6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4a1a63ac-66ea-4123-981f-52c401d078ba"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(53, 257));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6822SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6822",
				UId = new Guid("48acb332-75b9-4525-8ca0-dcc1b1a8c915"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CurveCenterPosition = new Point(298, 215),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4a1a63ac-66ea-4123-981f-52c401d078ba"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3a05881c-2d6c-4b29-aced-b2e655151398"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(284, 117));
			schemaFlow.PolylinePointPositions.Add(new Point(284, 110));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3BasePhotoSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3BasePhoto",
				UId = new Guid("ed2a1cee-3b98-4f8a-a88f-8a4ac6d3aa5f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90"),
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CurveCenterPosition = new Point(238, 682),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5e79f0ee-c33c-44ea-88e2-6375b47106ca"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a858ee01-adbc-4740-b449-e5868ac1cbf2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("4b4c67bd-cfc6-4959-a7f6-3340ca601dcc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e0462cc6-6899-44cf-a039-39d70fd9f47b"),
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CurveCenterPosition = new Point(167, 230),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("767e7517-bb79-4680-b6e3-4fe8162501e6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2e282bfa-9287-4113-a46a-da1bbec3b4de"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(53, 361));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow223SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow223",
				UId = new Guid("5b1a7c36-6543-457f-b67f-52d6e5892dd0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("45b7d114-643d-4217-a8b2-b9950d3eddb7"),
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d4f5150a-1aab-4bf4-98ca-e891eb03ff43"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d1983277-3250-4b98-bef8-5f3dc94fccaf"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("aace3ee8-0c37-4e15-bb8b-944c9935790e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b610ca25-5e69-4cfe-b077-c0ba24de5e5f"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("52789257-7720-4840-982e-f8dcd9e06a89"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("8ece5a5a-c300-4bbf-be7b-1de180fd03ab"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("2e3e95a4-2024-4552-b820-30e9633c8933"),
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("767e7517-bb79-4680-b6e3-4fe8162501e6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5d623849-3c39-4bb3-b94c-9678cb0a2ae8"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(53, 472));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("e2e84b8b-a5cc-4720-9cb1-d283ae0bd10b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("767e7517-bb79-4680-b6e3-4fe8162501e6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1d75978c-1eba-428d-98de-6319ff5257b3"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(53, 552));
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet396LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet396 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("308c2794-42b0-4706-91b7-295fee4106d6"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Name = @"LaneSet396",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet396;
		}

		protected virtual ProcessSchemaLane CreateLane1195Lane() {
			ProcessSchemaLane schemaLane1195 = new ProcessSchemaLane(this) {
				UId = new Guid("e6f6df02-7274-484d-8edc-361390d3970a"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("308c2794-42b0-4706-91b7-295fee4106d6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Name = @"Lane1195",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1195;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ac1862f6-5081-47bb-9e5a-1d801f37648e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6f6df02-7274-484d-8edc-361390d3970a"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 20),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(433, 608),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateContactSavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("767e7517-bb79-4680-b6e3-4fe8162501e6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ac1862f6-5081-47bb-9e5a-1d801f37648e"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ContactSaved",
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Name = @"ContactSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 23),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSynchronizeContactAddressScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("193c9932-6748-4236-bea9-d5cc48807672"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ac1862f6-5081-47bb-9e5a-1d801f37648e"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Name = @"SynchronizeContactAddressScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(169, 23),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,8,174,204,75,206,40,202,207,203,172,74,117,206,207,43,73,76,46,113,76,73,41,74,45,46,214,208,180,230,229,2,0,123,169,0,198,37,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateSynchronizeContactCommunicationScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("baff5e90-c8e3-4458-927d-dbeb1b295e9f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ac1862f6-5081-47bb-9e5a-1d801f37648e"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Name = @"SynchronizeContactCommunication",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(169, 106),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,8,174,204,75,206,40,202,207,203,172,74,117,206,207,205,45,205,203,76,78,44,201,204,207,211,208,180,6,0,38,105,137,83,34,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptSynchronizeAnniversaryScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4a1a63ac-66ea-4123-981f-52c401d078ba"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ac1862f6-5081-47bb-9e5a-1d801f37648e"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Name = @"ScriptSynchronizeAnniversary",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(140, 210),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,85,93,111,155,48,20,125,207,175,64,60,17,169,208,124,52,180,209,182,74,128,67,149,135,172,85,211,238,101,218,131,7,183,141,39,99,50,99,82,165,211,254,251,108,76,82,160,176,41,107,38,141,55,236,123,207,57,247,220,107,123,131,185,17,164,76,224,72,120,140,145,13,240,12,243,237,50,90,65,130,141,15,198,125,6,92,110,51,136,4,73,153,51,99,130,136,114,119,129,25,126,4,238,92,129,152,179,76,96,22,129,191,253,136,19,176,204,215,128,102,255,93,239,42,39,177,17,165,52,79,216,253,60,222,253,175,8,141,175,191,126,147,4,193,203,86,111,35,101,37,120,189,38,236,49,72,115,154,176,76,138,97,240,100,44,183,153,128,196,145,177,84,107,202,164,0,6,156,68,14,34,197,130,100,123,95,96,159,28,22,156,22,34,46,47,45,41,85,209,103,128,121,180,10,9,21,178,132,191,97,47,1,21,94,239,244,212,174,127,198,14,184,177,110,247,218,28,145,244,93,77,114,116,144,18,34,26,254,155,125,167,112,179,86,137,227,197,177,213,198,113,98,232,238,42,32,189,248,9,211,28,172,114,181,100,147,155,55,156,36,146,94,199,20,132,253,190,170,241,8,194,43,65,119,219,53,28,90,128,106,145,242,222,50,135,231,99,52,113,209,200,14,81,224,217,40,28,14,237,169,63,242,236,193,96,136,220,193,108,58,190,8,92,179,80,221,210,154,5,94,27,55,152,227,164,173,59,149,202,234,206,180,148,227,19,46,86,8,139,125,33,71,176,168,10,167,198,84,11,122,227,124,106,144,223,56,187,47,91,6,215,207,165,78,106,70,22,243,112,136,85,243,248,136,30,53,230,255,255,181,232,245,236,33,120,48,138,115,215,50,123,170,221,49,60,224,156,138,50,228,141,37,253,179,3,91,83,121,228,3,187,220,178,104,197,83,70,158,161,194,238,4,138,160,250,62,233,98,94,24,66,111,236,206,166,222,196,14,70,97,96,159,157,251,35,219,159,4,190,61,242,39,23,179,208,29,162,179,153,171,158,169,14,252,165,236,39,133,219,244,105,217,120,23,106,151,83,103,250,98,55,17,133,133,50,173,62,34,157,121,168,209,239,154,179,157,89,183,240,61,39,28,226,144,0,141,119,99,146,9,46,9,63,127,249,161,239,144,159,127,204,246,40,221,3,8,158,131,186,45,57,136,156,179,242,247,23,169,198,39,32,61,8,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateUpdateRemindingsScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2e282bfa-9287-4113-a46a-da1bbec3b4de"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ac1862f6-5081-47bb-9e5a-1d801f37648e"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e0462cc6-6899-44cf-a039-39d70fd9f47b"),
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Name = @"UpdateRemindings",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(169, 314),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,173,72,77,46,45,73,13,45,72,73,44,73,13,74,205,205,204,75,201,204,75,47,214,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,204,143,128,196,40,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateSynchronizeAnniversaryUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("3a05881c-2d6c-4b29-aced-b2e655151398"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ac1862f6-5081-47bb-9e5a-1d801f37648e"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Name = @"SynchronizeAnniversary",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(320, 203),
				SchemaUId = new Guid("15b17a16-09c5-4350-9636-904aade4b5aa"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false
			};
			InitializeSynchronizeAnniversaryParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateUpdateCareerScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5d623849-3c39-4bb3-b94c-9678cb0a2ae8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ac1862f6-5081-47bb-9e5a-1d801f37648e"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("2e3e95a4-2024-4552-b820-30e9633c8933"),
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Name = @"UpdateCareerScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(169, 425),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,206,72,204,75,79,117,78,44,74,77,45,210,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,15,134,125,166,28,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateSynchronizeNameScriptTastScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1d75978c-1eba-428d-98de-6319ff5257b3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ac1862f6-5081-47bb-9e5a-1d801f37648e"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Name = @"SynchronizeNameScriptTast",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(169, 505),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,174,204,75,206,40,202,207,203,172,74,117,206,207,43,73,76,46,241,75,204,77,213,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,220,213,27,251,38,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateContactSavingEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaContactSavingEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a8975df4-ae3d-4cfa-ad27-0666ece40f37"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6f6df02-7274-484d-8edc-361390d3970a"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90"),
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Name = @"ContactSavingEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(60, 686),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(329, 158),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaContactSavingEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateContactSavingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5e79f0ee-c33c-44ea-88e2-6375b47106ca"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a8975df4-ae3d-4cfa-ad27-0666ece40f37"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90"),
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ContactSaving",
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Name = @"ContactSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(43, 72),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateContactSavingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a858ee01-adbc-4740-b449-e5868ac1cbf2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a8975df4-ae3d-4cfa-ad27-0666ece40f37"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90"),
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Name = @"ContactSavingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(171, 58),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,65,79,195,48,12,133,207,76,218,127,8,59,76,221,165,127,96,20,169,138,182,170,23,54,49,198,61,74,172,214,34,113,38,215,153,84,126,61,105,153,16,226,0,92,159,223,123,254,236,118,208,137,25,72,206,3,240,177,143,28,117,111,168,3,167,42,85,236,72,80,198,178,1,121,25,47,224,116,244,41,208,171,241,9,30,154,132,238,177,88,229,132,196,214,173,54,234,190,90,46,238,126,4,14,254,247,204,122,173,254,94,49,59,171,220,62,17,234,72,4,86,48,82,249,141,187,204,178,24,43,173,219,108,151,139,35,195,21,99,26,106,107,99,34,153,203,242,53,255,98,187,101,166,157,185,105,143,222,159,186,112,224,39,19,96,143,224,93,49,201,186,7,251,214,14,218,48,100,162,207,119,205,131,150,80,208,120,124,7,29,67,72,132,214,76,168,167,145,108,207,145,178,206,95,62,109,168,1,2,54,2,53,17,94,129,7,195,227,51,4,36,135,212,205,190,243,197,229,241,237,184,186,131,89,100,144,196,164,132,19,108,63,0,115,144,213,108,190,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2sEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2s = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("bd823e8f-6967-4022-a2b8-1e23cd411050"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6f6df02-7274-484d-8edc-361390d3970a"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("45b7d114-643d-4217-a8b2-b9950d3eddb7"),
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Name = @"EventSubProcess2s",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(491, 20),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(300, 185),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2s;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateContactDeletingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d4f5150a-1aab-4bf4-98ca-e891eb03ff43"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bd823e8f-6967-4022-a2b8-1e23cd411050"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("45b7d114-643d-4217-a8b2-b9950d3eddb7"),
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ContactDeleting",
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Name = @"ContactDeleting",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(40, 47),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSynchronizeContactCorrespondenceScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d1983277-3250-4b98-bef8-5f3dc94fccaf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bd823e8f-6967-4022-a2b8-1e23cd411050"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("45b7d114-643d-4217-a8b2-b9950d3eddb7"),
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Name = @"SynchronizeContactCorrespondenceScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(147, 33),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,142,177,10,194,48,20,69,103,253,138,144,41,1,201,15,116,172,29,28,212,130,86,231,144,92,49,208,190,212,215,23,170,127,111,69,156,28,47,135,115,184,132,89,117,99,244,2,211,77,224,58,19,33,72,202,180,81,122,25,226,131,212,153,25,211,152,41,130,2,180,93,175,220,9,98,244,62,199,116,75,136,71,210,27,85,231,190,12,228,90,207,126,128,128,205,118,73,158,211,0,215,73,56,228,217,126,180,235,29,12,243,235,238,162,182,110,55,53,143,226,123,243,231,55,36,73,94,174,229,52,120,126,125,241,197,247,5,214,186,230,137,80,150,199,182,90,51,164,48,41,225,130,234,13,168,63,161,84,204,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("12d88f28-b68f-4628-98fa-d1d76ebb3050"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6f6df02-7274-484d-8edc-361390d3970a"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(496, 240),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(300, 220),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateContactDeletedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b610ca25-5e69-4cfe-b077-c0ba24de5e5f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("12d88f28-b68f-4628-98fa-d1d76ebb3050"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ContactDeleted",
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Name = @"ContactDeleted",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(24, 105),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDeleteRemindingsScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("52789257-7720-4840-982e-f8dcd9e06a89"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("12d88f28-b68f-4628-98fa-d1d76ebb3050"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Name = @"DeleteRemindings",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(142, 91),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,173,72,77,46,45,73,117,73,205,73,45,73,13,74,205,205,204,75,201,204,75,47,214,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,76,167,12,48,40,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateCloseCurrentJobMethod());
			Methods.Add(CreateCreateCommunicationMethod());
			Methods.Add(CreateSynchronizeContactAddressMethod());
			Methods.Add(CreateSynchronizeCommunicationMethod());
			Methods.Add(CreateFillSgmOrNameFieldMethod());
			Methods.Add(CreateSetSgmMethod());
			Methods.Add(CreateSetNameMethod());
			Methods.Add(CreateGetContactConverterMethod());
			Methods.Add(CreateNamePartColumnChangedMethod());
			Methods.Add(CreateAddCommunicationValueMethod());
			Methods.Add(CreateGetIsSocialMediaIdMethod());
			Methods.Add(CreateCheckIsCareerChangedMethod());
			Methods.Add(CreateChangeCareerMethod());
			Methods.Add(CreateUpdateOldCareerMethod());
			Methods.Add(CreateFillCareerEntityMethod());
			Methods.Add(CreateFillCareerDefaultValuesMethod());
			Methods.Add(CreateGetCommunicationSynchronizerMethod());
			Methods.Add(CreateInitializeCommunicationSynchronizerMethod());
			Methods.Add(CreateExecuteUpdateRemindingsMethod());
			Methods.Add(CreateExecuteDeleteRemindingsMethod());
			Methods.Add(CreateSynchronizeContactNameMethod());
			Methods.Add(CreateCreateEntitySynchronizationProviderMethod());
			Methods.Add(CreateCreateColumnValuesSynchronizerMethod());
			Methods.Add(CreateActualizeContactCareerCurrentStateMethod());
			Methods.Add(CreateInitCanGenerateAnniversaryRemindingMethod());
			Methods.Add(CreateGetAnniversaryDependentColumnsMethod());
			Methods.Add(CreateGetRemindingsGeneratorMethod());
		}

		protected override void InitializeUsings() {
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
				UId = new Guid("73bbc987-2ab8-4ce5-b0ec-c0299d1e72fc"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0017f56e-396d-4e72-a989-2c9800690b07"),
				Name = "Terrasoft.Messaging.Common",
				Alias = "",
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("169a8f30-18f7-46d5-9a44-edcbb48f0929"),
				Name = "System.Runtime.Remoting",
				Alias = "",
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6cb575e2-395e-47ee-968f-9e85ebbb0e57"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("03538de8-86d4-4eea-8c1d-8051bbb379ed"),
				Name = "Terrasoft.Configuration.EntitySynchronization",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
		}

		protected virtual SchemaMethod CreateCloseCurrentJobMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7b04a9c5-07ca-4fa9-bbe9-6141e7da68a5"),
				Name = "CloseCurrentJob",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,147,209,106,194,48,20,134,239,247,20,197,171,22,36,47,32,187,152,109,25,94,40,130,117,187,62,212,223,89,104,19,119,114,162,235,219,47,109,195,112,232,64,168,236,178,201,127,190,255,11,73,79,196,17,180,84,210,110,202,3,26,90,146,166,15,112,244,28,109,45,56,53,90,163,148,202,104,149,95,135,102,79,39,63,109,251,37,63,112,3,163,94,33,11,109,133,116,137,121,187,162,6,241,196,51,133,74,73,137,1,158,36,3,196,29,119,36,240,16,141,115,84,128,153,172,217,139,74,13,67,101,115,181,237,183,227,223,74,211,80,173,58,110,224,148,166,118,141,246,156,176,149,246,223,182,243,248,233,119,204,94,181,107,30,90,213,6,18,15,131,33,255,70,181,67,151,158,222,112,25,34,106,77,236,3,2,142,247,84,91,159,12,132,140,132,250,249,162,61,34,241,37,119,40,101,14,126,12,143,83,234,104,69,213,64,173,204,121,148,89,184,172,11,179,247,3,24,127,184,37,106,97,243,79,71,117,124,135,227,240,160,212,154,171,134,184,189,32,141,19,190,186,221,23,189,123,132,174,240,72,179,112,208,255,54,11,93,249,23,74,231,127,161,100,246,13,49,242,204,124,242,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateCommunicationMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("141b7460-c6f6-41a8-a8f8-6d55c38c3832"),
				Name = "CreateCommunication",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("1b34f871-37da-49c1-9937-15e5850c1b19"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("5517dc57-b6a2-4eef-b336-e1ef64e80436"),
				Name = "schema",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntitySchema",
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("102bc907-1499-443a-b3d5-3e932c0b9da1"),
				Name = "typeId",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("3b0c003e-bafb-4c19-ba89-d830a7cd96b4"),
				Name = "primaryEntityId",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2c8088f3-df0d-4a54-8a0b-93cdca327fb4"),
				Name = "number",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("95037745-c8c7-439b-ac68-e1bc3d872166"),
				Name = "socialMediaId",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,77,11,130,64,16,134,207,9,254,135,205,211,10,225,31,136,78,22,225,33,11,140,238,211,58,210,194,126,200,126,8,18,253,247,86,187,40,69,117,27,102,222,231,153,97,58,48,132,105,41,189,226,12,28,215,138,108,136,101,55,148,144,229,6,193,225,78,57,238,122,234,45,154,92,43,133,108,8,165,235,56,154,81,89,133,110,139,77,174,133,151,234,2,194,163,165,31,67,147,4,77,242,233,244,220,183,88,212,201,138,236,61,175,179,19,24,139,212,141,189,244,31,147,114,192,220,200,183,134,75,48,253,235,240,64,255,132,75,47,175,104,2,169,198,98,0,120,67,232,210,106,198,65,28,176,230,80,212,89,97,75,47,196,209,236,100,27,254,145,166,228,30,71,139,239,226,106,42,8,254,153,112,88,243,120,59,13,58,12,143,123,2,174,117,12,213,150,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSynchronizeContactAddressMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6624e92e-f496-443f-8255-d18f4faadf43"),
				Name = "SynchronizeContactAddress",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,86,77,79,227,48,16,61,183,191,34,112,64,169,20,69,236,153,93,164,82,186,136,195,82,160,251,33,177,218,131,73,76,241,42,117,178,182,3,234,174,242,223,25,199,118,18,59,201,214,149,56,118,58,243,230,249,121,252,38,47,136,5,73,78,5,74,196,117,26,124,10,150,84,16,177,139,111,25,217,34,182,91,228,89,185,165,223,81,86,226,179,233,11,164,162,52,101,152,243,175,187,2,119,211,175,176,144,161,180,147,255,241,170,36,233,121,120,60,239,86,28,207,44,152,255,3,112,193,8,221,180,16,166,56,129,2,207,230,139,58,213,20,50,188,33,57,245,44,189,215,201,77,215,188,164,130,121,55,54,217,166,252,47,41,60,79,251,64,10,89,244,152,231,89,64,248,114,91,136,221,220,81,221,186,133,248,90,37,133,195,69,109,58,36,222,148,89,182,98,131,233,11,163,170,146,119,12,245,190,213,208,200,57,150,186,232,40,214,168,55,150,252,80,235,3,42,245,89,146,167,32,28,20,226,228,196,61,107,27,209,199,105,3,13,241,78,78,67,176,141,1,143,89,240,111,58,97,88,148,140,6,130,201,201,175,186,67,187,92,223,1,83,138,95,245,109,174,147,103,188,69,119,37,102,187,240,27,199,108,145,83,138,19,1,205,226,110,194,23,68,209,6,179,40,128,217,168,159,155,59,213,12,35,129,211,21,85,67,209,94,27,244,139,33,87,133,97,178,76,158,44,180,83,230,89,166,122,169,92,46,197,115,96,227,21,75,49,187,216,205,121,18,54,131,93,211,249,76,50,129,153,221,86,245,82,255,252,32,226,249,22,49,180,197,240,131,135,211,137,10,47,242,109,129,24,225,57,149,151,18,47,255,148,40,107,207,120,28,181,230,98,211,85,213,92,210,14,45,6,154,85,161,12,232,125,89,105,87,3,86,242,94,199,9,89,205,53,161,188,144,87,202,199,174,126,165,255,134,209,185,133,123,70,143,25,190,36,76,205,1,212,152,216,26,103,16,107,254,129,174,140,139,168,173,185,207,95,235,169,132,146,15,157,48,200,153,18,89,80,123,133,33,113,73,106,16,96,170,221,35,10,242,199,223,128,124,30,206,166,149,229,180,152,219,26,130,3,169,35,192,88,100,138,139,51,188,145,57,177,126,129,13,80,172,8,158,7,167,245,67,233,140,80,207,113,48,255,121,250,235,76,229,96,213,238,25,209,13,150,142,240,132,50,14,79,107,34,177,143,70,12,77,190,203,35,27,252,128,85,163,174,157,135,22,248,44,168,89,79,28,212,53,22,29,64,23,42,178,29,23,20,153,76,220,243,40,167,152,84,250,68,30,172,251,251,205,97,60,59,132,106,75,210,139,158,99,242,7,42,109,246,170,33,172,224,252,248,234,218,72,47,26,31,182,253,77,115,32,223,118,153,27,198,6,210,143,115,83,31,53,91,207,111,8,122,91,239,80,161,219,239,136,70,107,19,242,148,187,65,136,218,45,252,222,19,92,127,179,24,130,176,196,253,168,201,170,72,238,124,15,58,214,191,195,232,232,5,203,157,6,21,85,128,193,92,140,59,241,218,165,1,113,255,118,150,167,188,166,92,32,154,224,139,221,13,172,149,112,96,93,119,61,79,129,0,184,234,162,151,147,138,58,142,42,43,173,42,41,200,37,126,234,104,82,175,236,126,146,115,161,122,161,58,203,117,79,89,111,247,169,91,30,250,176,178,228,29,129,219,107,144,213,62,66,131,190,213,229,164,140,194,135,204,128,165,84,54,150,121,192,62,104,35,143,221,65,108,222,149,23,193,177,71,184,87,37,235,141,56,169,122,224,171,169,245,177,250,6,100,189,48,136,210,13,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSynchronizeCommunicationMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5c47ca42-2cbf-4c87-9e51-fd7dd3acd133"),
				Name = "SynchronizeCommunication",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,200,72,205,41,72,45,82,176,85,112,79,45,113,206,207,205,45,205,203,76,78,44,201,204,207,11,174,204,75,206,40,202,207,203,172,74,45,210,208,180,230,229,130,168,212,67,18,71,81,95,12,86,84,148,90,82,90,148,167,80,82,84,154,106,13,0,104,127,252,82,95,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFillSgmOrNameFieldMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6de6bbc2-26a5-4327-9b4e-828558d43e4a"),
				Name = "FillSgmOrNameField",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,143,203,10,194,48,16,69,215,22,250,15,67,87,41,136,63,224,99,83,74,113,97,17,10,238,99,59,214,64,50,133,102,34,136,245,223,53,141,139,186,16,234,114,230,158,123,224,238,115,114,6,123,121,214,184,201,137,21,223,179,78,59,67,39,169,29,238,160,190,74,106,177,9,63,11,91,8,204,170,64,206,166,209,136,91,145,174,227,72,93,64,148,210,224,81,246,28,194,15,41,190,101,75,72,60,150,164,41,60,226,104,81,33,87,173,17,193,15,210,66,214,17,203,154,189,242,9,168,45,130,55,191,201,153,242,202,245,52,250,97,24,230,183,10,117,67,42,255,239,29,84,211,104,156,14,242,139,252,253,99,210,11,227,112,39,247,121,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetSgmMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d0c9cc7d-02fb-4776-9862-76c29a5d5feb"),
				Name = "SetSgm",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d334347d-489e-4abf-90e4-fb4a3394ebd6"),
				Name = "contact",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Contact",
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,72,206,207,43,73,76,46,81,176,181,85,200,43,205,201,209,84,168,230,226,44,74,45,41,45,202,179,230,170,229,130,202,234,185,101,230,228,4,167,231,186,101,166,230,164,20,107,184,167,150,56,67,36,128,84,89,106,81,73,106,145,134,166,166,53,0,13,133,68,201,79,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetNameMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7dceadbb-7406-47d3-a4b0-22bdf6323c4f"),
				Name = "SetName",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("98dc2f8e-f054-43ff-b8f6-fa1c9505bdaf"),
				Name = "contact",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Contact",
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,72,206,207,43,73,76,46,81,176,181,85,200,43,205,201,209,84,168,230,229,226,44,74,45,41,45,202,179,230,229,170,229,229,130,42,208,115,203,204,201,241,75,204,77,117,203,76,205,73,209,112,79,45,113,134,72,0,169,178,212,162,146,212,34,13,77,77,107,0,25,249,180,252,82,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetContactConverterMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("93794d56-4c4e-4d17-b5b2-85416b0720aa"),
				Name = "GetContactConverter",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847"),
				ResultValueTypeName = "IContactFieldConverter"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,116,206,207,43,73,76,46,113,203,76,205,73,1,178,203,82,139,74,82,139,20,146,225,44,91,5,168,138,208,146,204,156,204,146,204,212,98,61,247,212,18,168,24,92,131,70,104,113,106,17,144,151,151,154,92,146,153,159,167,105,205,203,85,148,90,82,90,148,135,48,201,26,0,16,41,150,174,107,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateNamePartColumnChangedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("82bbd2cf-f53f-4ae9-8ba3-4600a4e65258"),
				Name = "NamePartColumnChanged",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CreatedInPackageId = new Guid("f5f592f7-1387-477f-bb9f-f61aedb1d531"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("53d9ea2e-9f4f-43b4-bea1-e9a0024b5072"),
				Name = "changedColumns",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "IEnumerable<EntityColumnValue>",
				CreatedInPackageId = new Guid("f5f592f7-1387-477f-bb9f-f61aedb1d531")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("7f7bbb0f-6e7b-4a05-9b27-fad704f83d48"),
				Name = "namePart",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("f5f592f7-1387-477f-bb9f-f61aedb1d531")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,206,72,204,75,79,77,113,206,207,41,205,205,43,214,115,204,171,212,72,6,179,21,108,237,20,170,121,185,56,139,32,234,128,44,78,136,132,158,95,98,110,170,130,173,173,66,30,144,14,72,44,42,81,80,83,67,150,14,75,204,41,77,85,80,4,202,151,230,228,0,229,64,82,138,197,37,69,153,121,233,122,158,197,126,64,65,255,34,215,220,130,18,152,69,16,13,122,33,249,193,96,53,26,154,154,48,77,40,242,174,133,165,137,57,197,48,61,254,57,41,96,97,77,107,94,174,90,77,107,0,142,119,51,12,205,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateAddCommunicationValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3bd4b36a-60b2-4b1e-995a-57fd91a615e7"),
				Name = "AddCommunicationValue",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("60e98631-a0ec-43f2-86ee-56dca2731a2f"),
				Name = "communications",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<Guid, string>",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("7e84a1fc-0e0a-4682-a9cc-e0c23436d93b"),
				Name = "communicationIdValue",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("73263304-8e98-43bd-beb7-57f36ad4a24c"),
				Name = "value",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,40,75,204,41,77,213,243,44,246,43,205,201,241,47,114,205,45,40,169,212,208,212,84,168,230,226,44,74,45,41,45,202,179,230,170,229,74,206,207,205,45,205,203,76,78,44,201,204,207,43,214,115,76,73,209,200,75,45,87,112,47,205,76,209,64,145,243,76,9,3,25,167,169,163,0,54,86,211,26,0,107,160,140,107,98,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsSocialMediaIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("63dc76ca-5159-4ec9-a787-54974179f2b1"),
				Name = "GetIsSocialMediaId",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("28056d2f-785b-43fc-96f7-b94ffc0295cc"),
				Name = "communicationTypeId",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,200,201,204,203,78,77,241,204,243,76,81,176,85,200,75,45,87,112,47,205,76,209,112,206,207,205,45,205,203,76,78,44,201,204,207,11,169,44,72,117,206,207,43,46,41,214,243,129,171,214,180,230,42,3,106,47,41,207,44,41,73,45,34,78,119,8,76,49,84,115,90,98,114,106,82,126,126,54,113,186,221,224,170,129,218,139,82,75,74,139,242,20,146,209,213,130,140,178,69,246,84,77,13,46,69,8,167,227,86,131,112,161,53,0,178,35,177,227,45,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCheckIsCareerChangedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9f057ee2-a3d0-4284-8a62-bce3f7b0525a"),
				Name = "CheckIsCareerChanged",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CreatedInPackageId = new Guid("2e3e95a4-2024-4552-b820-30e9633c8933"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,86,77,115,155,48,16,61,155,95,161,248,144,17,23,166,119,199,158,73,137,147,113,15,113,167,73,154,179,10,155,132,68,22,174,16,105,61,141,255,123,37,196,135,132,145,1,79,78,54,218,125,111,159,158,150,21,239,132,35,18,69,105,206,196,42,70,115,180,100,34,17,187,224,6,196,253,110,11,113,152,210,124,195,126,18,154,195,197,77,158,196,11,60,189,172,178,167,254,204,123,151,240,24,182,132,139,13,12,102,184,50,0,21,201,107,250,107,32,250,155,202,108,106,71,73,150,164,236,71,74,97,112,117,19,98,212,191,79,4,133,227,20,153,224,9,123,214,34,138,244,10,94,90,184,166,113,151,10,185,60,206,200,81,60,14,59,71,113,56,77,29,169,228,152,181,18,211,75,228,52,56,34,28,128,175,178,240,133,176,103,80,68,77,215,158,205,109,255,189,201,199,135,221,149,50,163,109,110,145,164,187,78,70,43,191,74,168,213,84,5,184,237,72,5,215,77,163,25,170,93,218,138,151,155,173,216,153,122,131,114,13,251,232,252,220,210,105,71,10,113,237,100,83,89,19,243,38,58,191,80,32,151,111,115,74,215,188,12,206,188,91,128,248,10,40,8,8,11,81,82,77,219,79,137,183,4,207,188,228,9,97,107,201,71,255,188,201,68,113,173,88,6,92,212,92,79,132,102,48,43,99,15,219,152,24,117,234,24,7,145,115,54,243,246,5,49,118,159,158,84,98,62,171,221,164,162,220,138,175,125,199,125,135,107,249,218,65,163,89,14,78,191,116,221,9,24,210,24,173,83,58,86,188,171,119,20,254,204,120,110,31,166,239,60,5,193,243,158,67,216,35,144,191,104,180,255,159,97,254,56,231,63,205,246,193,158,15,179,188,229,171,105,121,247,59,177,247,188,59,249,226,69,2,69,41,19,36,42,19,66,101,111,25,152,35,6,127,144,126,192,15,153,10,50,38,255,203,157,72,217,129,158,142,248,58,103,81,80,192,240,84,141,86,21,186,230,233,6,79,67,147,120,170,214,31,95,128,67,29,80,217,202,137,223,57,161,88,179,5,223,9,39,27,57,14,56,238,191,47,139,106,146,22,145,172,84,169,103,131,107,220,20,110,185,118,27,92,178,88,141,171,73,176,222,2,251,74,211,232,205,156,245,110,157,85,53,95,131,121,11,165,20,96,63,8,105,154,129,102,245,235,126,239,147,51,178,126,53,194,58,230,121,255,214,205,75,191,150,61,92,169,141,118,72,173,133,53,90,187,47,153,1,114,237,111,139,19,20,31,16,56,68,155,10,27,221,173,43,112,128,224,242,67,230,4,165,13,210,221,2,182,167,221,119,241,32,87,237,239,164,147,124,61,160,112,58,107,102,54,250,157,252,203,191,16,229,2,238,34,66,9,191,72,152,88,200,143,143,5,250,82,108,236,200,168,251,15,200,122,221,111,75,12,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateChangeCareerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("264178e4-9c47-42be-8673-888cb0b40937"),
				Name = "ChangeCareer",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CreatedInPackageId = new Guid("2e3e95a4-2024-4552-b820-30e9633c8933"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,84,77,79,227,48,16,61,167,191,194,228,228,74,85,180,156,119,65,42,105,65,28,160,101,187,236,158,173,120,186,88,114,236,50,182,139,2,226,191,227,216,134,38,105,180,203,137,99,60,111,222,188,249,120,217,51,36,21,67,0,220,84,15,80,51,114,70,238,13,96,169,149,130,202,10,173,138,165,178,194,54,49,122,195,20,251,11,88,92,129,189,86,198,50,85,193,69,115,203,106,160,185,207,176,172,178,101,224,202,167,223,39,251,15,230,200,224,153,187,133,138,18,129,89,136,49,218,175,233,179,197,150,208,91,0,238,203,0,38,214,41,121,153,100,247,59,238,211,86,146,199,55,234,177,217,165,144,50,126,46,96,203,156,180,191,153,116,96,104,183,124,31,151,202,14,1,221,239,98,195,246,208,210,191,18,144,6,200,187,162,40,160,163,40,52,218,237,126,185,185,243,205,42,120,34,221,217,221,57,192,97,163,99,195,157,145,227,89,102,67,254,226,167,126,42,181,83,214,23,58,29,139,207,57,159,75,25,137,75,45,93,173,76,24,85,43,182,214,92,108,5,240,149,138,145,118,51,35,249,49,72,243,155,15,120,144,50,204,46,86,200,1,47,154,5,152,138,142,106,245,99,183,128,166,229,164,71,193,120,6,17,242,71,216,135,53,67,127,79,45,158,198,199,82,215,59,134,194,104,245,171,217,65,177,124,116,76,30,102,148,207,38,89,150,22,182,70,81,51,108,162,172,112,2,211,175,210,227,69,228,169,124,62,35,22,83,233,131,7,188,40,25,119,62,54,109,239,167,216,195,1,118,108,137,172,189,192,33,91,17,175,224,156,124,11,183,152,141,58,174,3,191,20,104,108,88,211,255,221,144,14,255,165,135,253,183,195,62,65,250,57,151,45,64,66,207,101,35,190,127,157,132,159,12,171,170,118,6,215,220,247,155,72,253,60,219,229,240,206,41,252,184,114,130,159,211,124,254,142,206,211,95,102,141,176,23,218,153,20,8,96,114,114,118,160,13,229,231,149,245,123,22,207,208,243,102,233,16,65,217,141,245,210,130,162,55,106,41,249,84,79,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateOldCareerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("fba9bb77-d19e-4064-b054-1c9481be6e05"),
				Name = "UpdateOldCareer",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CreatedInPackageId = new Guid("2e3e95a4-2024-4552-b820-30e9633c8933"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,143,205,10,130,64,16,128,207,249,20,203,158,118,65,246,5,164,67,136,7,111,66,88,231,65,39,18,214,49,103,103,43,223,62,77,59,68,208,113,126,190,15,190,59,176,138,183,22,4,43,238,122,224,73,237,21,225,67,213,239,157,169,3,114,62,16,97,35,221,64,169,210,243,32,208,72,14,140,200,218,38,59,119,68,49,122,131,117,170,242,193,199,158,92,5,12,61,10,178,185,128,15,104,151,207,243,21,25,205,71,81,182,218,186,50,20,99,4,111,126,168,130,164,147,201,109,222,245,124,2,31,87,211,129,218,217,19,153,145,228,159,69,120,1,20,132,173,39,75,190,90,93,241,196,38,206,153,54,123,1,108,164,83,77,8,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFillCareerEntityMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e2004d6b-2fd2-42bf-b7fd-26d371b117b6"),
				Name = "FillCareerEntity",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CreatedInPackageId = new Guid("2e3e95a4-2024-4552-b820-30e9633c8933"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e6ed0b4c-61ac-47b7-a669-b95435679049"),
				Name = "careerEntity",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("2e3e95a4-2024-4552-b820-30e9633c8933")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,65,10,194,48,16,69,247,158,34,116,101,33,120,129,226,66,84,196,46,85,220,199,116,22,145,52,145,56,41,244,246,53,164,181,137,144,198,245,188,199,103,94,199,12,97,156,107,171,240,220,144,45,57,42,20,216,111,78,128,123,45,109,171,238,76,90,88,23,187,9,41,202,106,213,125,156,6,94,204,96,11,203,218,33,160,38,243,169,31,78,73,24,181,187,206,35,92,188,133,86,23,45,97,121,38,228,130,161,155,64,9,105,175,30,9,103,112,102,0,204,8,94,147,239,211,185,86,78,138,158,167,81,177,188,26,61,68,127,74,228,116,31,145,250,212,127,192,62,2,253,22,43,171,1,202,197,159,90,23,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFillCareerDefaultValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3e395015-de14-40bf-ba5f-1ed699308771"),
				Name = "FillCareerDefaultValues",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CreatedInPackageId = new Guid("2e3e95a4-2024-4552-b820-30e9633c8933"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("1cfd5ef6-dd38-4af3-a51c-e9bebb32c234"),
				Name = "careerEntity",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("2e3e95a4-2024-4552-b820-30e9633c8933")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,206,177,10,131,48,16,6,224,189,79,81,156,18,40,121,1,71,149,210,173,160,118,63,210,19,2,230,2,231,159,193,183,55,82,7,233,226,120,119,223,255,115,158,148,89,59,65,192,234,122,70,203,83,147,230,28,229,67,115,230,197,216,250,230,255,200,233,110,170,38,9,200,227,245,173,30,247,131,188,53,68,210,245,196,46,75,178,42,11,74,5,244,90,247,32,69,75,224,226,199,133,181,188,32,236,17,146,184,163,104,223,186,103,137,253,198,221,14,33,178,177,182,222,0,30,77,75,102,240,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetCommunicationSynchronizerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("fc98d37b-28f3-42f9-ad8c-5d379fa30c69"),
				Name = "GetCommunicationSynchronizer",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "CommunicationSynchronizer"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,193,10,194,48,12,134,207,238,41,74,79,43,12,95,96,234,208,162,226,197,139,248,0,165,6,45,172,169,164,41,82,159,222,110,23,241,80,47,33,228,207,151,252,137,14,222,39,116,214,176,11,120,201,104,31,20,208,189,129,196,90,232,170,54,12,66,143,38,198,131,177,28,40,47,143,192,171,106,247,166,109,22,8,175,50,14,35,83,154,136,45,221,147,7,228,86,166,8,84,4,4,59,97,178,19,215,159,130,234,68,21,45,193,113,46,200,126,78,84,247,103,205,147,156,55,148,117,24,147,199,179,241,80,48,121,138,154,192,48,220,118,249,235,119,182,47,149,234,27,2,78,132,162,173,30,166,234,31,234,63,186,92,0,29,88,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitializeCommunicationSynchronizerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1d818bf4-f0f8-444c-b8c4-fee597f914c4"),
				Name = "InitializeCommunicationSynchronizer",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,210,205,138,194,48,16,192,241,179,125,138,224,169,133,226,11,116,215,75,253,234,65,16,20,60,199,56,216,161,201,140,36,169,210,21,223,125,219,238,110,80,216,67,174,153,255,111,46,147,155,180,66,177,49,45,161,146,30,153,74,214,173,33,39,62,5,193,93,44,80,13,143,210,118,31,206,91,164,75,46,214,45,158,231,226,145,76,30,211,195,29,189,7,59,205,199,118,24,164,229,235,174,67,119,133,146,201,121,55,251,77,171,115,246,204,7,186,146,10,78,204,77,140,253,107,3,94,26,137,58,70,142,97,96,251,166,159,196,176,49,12,108,195,6,118,53,83,20,13,113,224,91,62,161,142,95,240,146,135,21,209,248,200,182,9,52,121,22,201,173,63,111,13,250,10,182,63,232,26,252,27,220,119,164,106,203,132,95,96,211,172,72,126,194,89,69,232,81,234,254,245,173,174,60,24,151,254,247,87,178,226,27,91,183,25,4,70,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateExecuteUpdateRemindingsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e713a6cc-963f-44bf-a89a-df303ec9ba76"),
				Name = "ExecuteUpdateRemindings",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CreatedInPackageId = new Guid("ae62e634-fbce-473f-afeb-ae2f3fadfe02"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,80,116,78,204,115,79,205,75,45,74,44,73,117,204,203,203,44,75,45,42,78,44,170,12,74,205,205,204,75,201,204,75,215,84,168,230,226,44,74,45,41,45,202,179,230,170,229,114,74,44,198,170,76,161,8,198,42,134,154,150,95,164,96,171,224,158,90,18,132,41,161,225,154,87,146,89,82,169,105,205,133,69,151,30,220,53,201,37,165,137,57,8,237,26,154,214,0,106,52,98,169,177,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateExecuteDeleteRemindingsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("fc26242a-e600-45be-836a-0756870aadd6"),
				Name = "ExecuteDeleteRemindings",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CreatedInPackageId = new Guid("ae62e634-fbce-473f-afeb-ae2f3fadfe02"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,47,205,76,81,40,78,206,72,205,77,12,5,178,108,21,92,243,74,50,75,42,245,130,193,66,122,161,158,41,214,92,78,137,197,169,142,121,121,153,101,169,69,197,137,69,149,65,169,185,153,121,41,153,121,233,10,69,48,86,177,123,106,94,106,81,98,73,126,17,208,4,247,212,146,32,76,9,13,136,193,154,214,92,88,116,233,185,164,230,164,150,164,6,165,38,231,23,165,32,52,107,192,29,166,105,13,0,86,233,202,55,169,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSynchronizeContactNameMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6396bf2d-d6de-4ad9-9429-53b10986c155"),
				Name = "SynchronizeContactName",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,145,77,106,195,48,16,133,215,54,248,14,170,87,14,8,95,160,105,55,78,10,129,182,4,12,221,171,202,52,157,34,75,70,146,83,220,224,187,87,63,113,170,6,154,174,108,241,190,121,51,243,102,211,40,49,116,242,133,137,1,76,59,74,254,174,149,196,47,208,196,164,143,59,210,104,96,22,254,162,171,197,109,145,111,156,42,128,91,84,114,249,35,50,255,142,117,79,172,239,81,238,239,9,79,159,198,185,75,248,36,143,104,236,63,117,199,34,207,60,122,141,10,80,214,170,65,243,211,184,207,172,3,215,163,244,223,146,122,117,5,198,162,76,106,127,33,142,152,138,124,242,27,173,165,69,59,94,180,219,106,117,192,157,75,165,159,127,230,120,174,226,33,163,72,16,232,122,161,70,240,61,103,147,250,1,229,46,202,85,185,62,233,37,13,209,172,48,164,202,244,184,52,86,187,37,41,81,175,31,46,234,24,201,177,108,148,180,140,91,135,71,135,122,171,177,115,120,114,47,191,146,159,0,223,72,117,110,127,227,162,31,132,88,4,155,244,226,117,114,221,96,137,96,170,232,77,207,211,211,139,67,122,251,108,22,235,150,29,32,236,60,125,3,97,95,11,108,101,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateEntitySynchronizationProviderMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("93233790-4b00-4faa-b661-e9a8356e334b"),
				Name = "CreateEntitySynchronizationProvider",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "IEntitySynchronizationProvider"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,112,206,73,44,46,118,75,76,46,201,47,170,212,115,79,45,177,113,205,43,201,44,169,12,174,204,75,206,40,202,207,203,172,74,44,201,204,207,11,40,202,47,203,76,73,45,178,211,200,75,45,87,112,206,207,43,46,41,42,5,233,113,44,74,47,205,77,205,43,209,80,42,45,78,45,2,74,228,165,38,131,52,40,233,40,132,162,8,104,106,90,3,0,209,45,217,69,114,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateColumnValuesSynchronizerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("dd82c0b0-848a-4e20-8634-0573b980662f"),
				Name = "CreateColumnValuesSynchronizer",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "IColumnValuesSynchronizer"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,112,206,73,44,46,118,75,76,46,201,47,170,212,115,79,45,177,113,206,207,41,205,205,11,75,204,41,77,45,14,174,204,75,206,40,202,207,203,172,74,45,178,211,208,180,6,0,0,87,121,214,52,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateActualizeContactCareerCurrentStateMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8a463f63-bac1-4e98-8b8a-3c05de81fc8f"),
				Name = "ActualizeContactCareerCurrentState",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,144,193,106,3,49,12,68,207,205,87,24,159,108,8,254,129,144,67,216,44,37,183,133,54,205,89,120,85,106,216,149,83,89,74,155,191,207,110,226,20,74,91,122,28,105,244,70,204,9,216,232,177,7,193,70,153,145,100,67,125,75,253,118,26,152,181,33,252,48,251,235,214,237,11,114,147,137,48,74,202,180,52,118,18,2,81,26,96,68,182,126,241,16,158,80,156,173,24,187,52,77,30,116,164,208,1,195,136,130,236,94,97,40,232,191,156,91,197,57,230,55,231,247,176,80,153,243,52,60,162,84,57,31,63,167,17,157,191,50,15,111,200,232,238,111,237,122,235,195,174,180,239,10,131,251,193,111,73,146,156,67,199,105,4,62,223,214,47,48,232,237,187,169,2,103,55,49,102,165,127,56,29,227,41,101,45,213,92,17,6,74,109,109,181,248,163,219,208,126,98,212,169,86,191,186,0,208,146,217,238,130,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitCanGenerateAnniversaryRemindingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("34db6d4a-5bc6-4111-af86-65e39b6ad203"),
				Name = "InitCanGenerateAnniversaryReminding",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,144,59,14,194,64,12,68,123,36,238,176,80,160,164,217,11,240,145,32,137,168,72,129,16,189,33,22,88,202,122,195,198,137,180,183,199,40,252,10,104,237,25,191,25,247,16,204,217,215,157,227,214,44,205,22,101,205,76,61,134,22,66,204,177,65,174,144,37,27,4,73,58,31,143,78,222,215,134,218,13,5,185,230,32,88,122,41,92,35,81,221,147,130,133,36,90,189,114,136,13,86,131,237,8,117,135,139,135,244,64,14,87,201,244,109,157,166,182,184,117,80,183,201,107,107,119,52,232,223,36,248,196,121,166,200,174,192,23,172,148,247,193,61,103,95,64,13,107,215,28,19,237,102,150,171,87,69,155,121,22,32,173,162,3,91,130,195,244,65,202,128,183,200,24,52,197,87,253,61,58,226,138,248,162,168,255,49,102,179,95,223,152,223,1,17,235,15,226,88,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetAnniversaryDependentColumnsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("51c4ddfe-4a0f-42bd-85bd-bc99acb8b41c"),
				Name = "GetAnniversaryDependentColumns",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "IEnumerable<string>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,80,200,75,45,143,142,85,168,86,80,242,47,207,75,45,242,76,81,210,81,80,114,76,78,206,47,205,43,129,112,66,42,11,82,129,44,133,90,107,0,194,175,214,185,51,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetRemindingsGeneratorMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b5d240ae-493c-4bc5-b9e7-d8066bad09b0"),
				Name = "GetRemindingsGenerator",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "BaseAnniversaryReminding"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ba42309c-ad8f-4f25-8f4b-13ea6eec5b49"),
				Name = "contactEntity",
				CreatedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				ModifiedInSchemaUId = new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,80,205,10,130,64,16,62,235,83,12,158,20,194,23,40,131,8,9,175,81,221,23,157,98,96,157,141,221,209,176,232,221,115,51,3,41,162,211,192,204,247,59,116,132,184,52,44,170,148,156,133,164,75,55,40,187,238,140,213,218,232,166,230,131,210,13,46,54,13,85,203,56,242,251,162,138,18,200,50,88,15,164,126,56,113,105,94,159,181,233,16,7,68,2,183,48,176,40,141,101,96,188,192,120,93,49,83,139,214,41,219,109,177,38,174,136,79,241,222,161,237,85,24,75,33,195,51,248,59,141,79,146,204,195,59,160,118,232,29,91,101,193,142,186,5,31,13,100,79,251,87,212,111,238,30,21,247,34,193,132,151,22,76,66,74,211,21,167,207,25,144,239,94,63,132,63,106,77,12,124,236,7,37,143,5,25,122,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Contact_Base_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2b3832d5-1237-4e8e-af64-288161ef598e"));
		}

		#endregion

	}

	#endregion

}

