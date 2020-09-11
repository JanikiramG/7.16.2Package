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
	using Terrasoft.Core.OperationLog;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;
	using Terrasoft.Web.Common;

	#region Class: VwSysAdminUnit_Base_TerrasoftSchema

	/// <exclude/>
	public class VwSysAdminUnit_Base_TerrasoftSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public VwSysAdminUnit_Base_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwSysAdminUnit_Base_TerrasoftSchema(VwSysAdminUnit_Base_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwSysAdminUnit_Base_TerrasoftSchema(VwSysAdminUnit_Base_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364");
			RealUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364");
			Name = "VwSysAdminUnit_Base_Terrasoft";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = true;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeHierarchyColumn() {
			base.InitializeHierarchyColumn();
			HierarchyColumn = CreateParentRoleColumn();
			if (Columns.FindByUId(HierarchyColumn.UId) == null) {
				Columns.Add(HierarchyColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("3b1b6e4c-aa09-413c-9ded-a6ad81bb93c1")) == null) {
				Columns.Add(CreateSysAdminUnitTypeColumn());
			}
			if (Columns.FindByUId(new Guid("328f73e7-ebde-432f-9052-a0365b3105e8")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("45d5d808-1ad8-42bf-aaf2-177dcd2079c7")) == null) {
				Columns.Add(CreateAccountColumn());
			}
			if (Columns.FindByUId(new Guid("72a7351e-36cf-40f9-b334-0a7563bd60fb")) == null) {
				Columns.Add(CreateIsDirectoryEntryColumn());
			}
			if (Columns.FindByUId(new Guid("8280981b-5189-40a1-b700-6a35c572dba2")) == null) {
				Columns.Add(CreateTimeZoneColumn());
			}
			if (Columns.FindByUId(new Guid("a07a30ff-b3df-45db-a83c-bf89027250d8")) == null) {
				Columns.Add(CreateUserPasswordColumn());
			}
			if (Columns.FindByUId(new Guid("a986b074-459c-40b1-b4b6-0e286b3ef123")) == null) {
				Columns.Add(CreateActiveColumn());
			}
			if (Columns.FindByUId(new Guid("937f2044-f446-4975-9caf-de9e7c972fb9")) == null) {
				Columns.Add(CreateLoggedInColumn());
			}
			if (Columns.FindByUId(new Guid("2e25fe29-ea38-4db2-84d5-03a8db9b2491")) == null) {
				Columns.Add(CreateLDAPEntryColumn());
			}
			if (Columns.FindByUId(new Guid("184336ef-e07a-4f5a-9850-8d4ccaff520f")) == null) {
				Columns.Add(CreateSynchronizeWithLDAPColumn());
			}
			if (Columns.FindByUId(new Guid("c2748d54-0f48-4251-bfc0-ff6e2478348d")) == null) {
				Columns.Add(CreateLDAPEntryIdColumn());
			}
			if (Columns.FindByUId(new Guid("e161e2fc-4fac-4ae0-ba3c-e9f70d52ecb4")) == null) {
				Columns.Add(CreateLDAPEntryDNColumn());
			}
			if (Columns.FindByUId(new Guid("9eb0071c-72bd-48e1-b9e7-36c81e6aa232")) == null) {
				Columns.Add(CreateSysCultureColumn());
			}
			if (Columns.FindByUId(new Guid("088ae956-eb2f-4df7-ad9c-1fb9a6596a9f")) == null) {
				Columns.Add(CreatePasswordExpireDateColumn());
			}
			if (Columns.FindByUId(new Guid("5f009f32-31e0-41c2-9506-a9aa73ed64ae")) == null) {
				Columns.Add(CreateHomePageColumn());
			}
			if (Columns.FindByUId(new Guid("4acc2d13-7573-41ec-9a30-e20696bf0314")) == null) {
				Columns.Add(CreateConnectionTypeColumn());
			}
			if (Columns.FindByUId(new Guid("57235d0d-5e90-4767-89dd-6ca3f1ba24c6")) == null) {
				Columns.Add(CreateUserConnectionTypeColumn());
			}
			if (Columns.FindByUId(new Guid("a3c751b9-544a-420b-8df0-dc3a0e3bc147")) == null) {
				Columns.Add(CreateForceChangePasswordColumn());
			}
			if (Columns.FindByUId(new Guid("057c3dcc-44e5-4f9d-ae7f-a78e24f255bf")) == null) {
				Columns.Add(CreateDateTimeFormatColumn());
			}
			if (Columns.FindByUId(new Guid("812c55bd-f398-4747-af46-3fa83c335c9d")) == null) {
				Columns.Add(CreateSysAdminUnitColumn());
			}
			if (Columns.FindByUId(new Guid("2e74086a-2d4c-48d1-80da-b0d2467597fb")) == null) {
				Columns.Add(CreateSessionTimeoutColumn());
			}
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.IsLocalizable = false;
			column.ModifiedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.IsLocalizable = false;
			column.ModifiedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected virtual EntitySchemaColumn CreateSysAdminUnitTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("3b1b6e4c-aa09-413c-9ded-a6ad81bb93c1"),
				Name = @"SysAdminUnitType",
				ReferenceSchemaUId = new Guid("e58cf897-de3a-48fb-a0a2-38943bf0ad06"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				ModifiedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateParentRoleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("3678b2d1-343e-4e0c-8a93-f082143be510"),
				Name = @"ParentRole",
				ReferenceSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				ModifiedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("328f73e7-ebde-432f-9052-a0365b3105e8"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				ModifiedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("45d5d808-1ad8-42bf-aaf2-177dcd2079c7"),
				Name = @"Account",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				ModifiedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateIsDirectoryEntryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("72a7351e-36cf-40f9-b334-0a7563bd60fb"),
				Name = @"IsDirectoryEntry",
				CreatedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				ModifiedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateTimeZoneColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8280981b-5189-40a1-b700-6a35c572dba2"),
				Name = @"TimeZone",
				ReferenceSchemaUId = new Guid("a394a569-92d6-44d0-bdda-fa0578373b4f"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				ModifiedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Settings,
					ValueSource = @"DefaultTimeZone"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateUserPasswordColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("HashText")) {
				UId = new Guid("a07a30ff-b3df-45db-a83c-bf89027250d8"),
				Name = @"UserPassword",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				ModifiedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateActiveColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("a986b074-459c-40b1-b4b6-0e286b3ef123"),
				Name = @"Active",
				CreatedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				ModifiedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"True"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateLoggedInColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("937f2044-f446-4975-9caf-de9e7c972fb9"),
				Name = @"LoggedIn",
				CreatedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				ModifiedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateLDAPEntryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("2e25fe29-ea38-4db2-84d5-03a8db9b2491"),
				Name = @"LDAPEntry",
				CreatedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				ModifiedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSynchronizeWithLDAPColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("184336ef-e07a-4f5a-9850-8d4ccaff520f"),
				Name = @"SynchronizeWithLDAP",
				CreatedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				ModifiedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateLDAPEntryIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("c2748d54-0f48-4251-bfc0-ff6e2478348d"),
				Name = @"LDAPEntryId",
				CreatedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				ModifiedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateLDAPEntryDNColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("e161e2fc-4fac-4ae0-ba3c-e9f70d52ecb4"),
				Name = @"LDAPEntryDN",
				CreatedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				ModifiedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSysCultureColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("9eb0071c-72bd-48e1-b9e7-36c81e6aa232"),
				Name = @"SysCulture",
				ReferenceSchemaUId = new Guid("ffc193e1-04bc-472b-bdc0-3333d1df84e4"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				ModifiedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreatePasswordExpireDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("088ae956-eb2f-4df7-ad9c-1fb9a6596a9f"),
				Name = @"PasswordExpireDate",
				CreatedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				ModifiedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376")
			};
		}

		protected virtual EntitySchemaColumn CreateHomePageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("5f009f32-31e0-41c2-9506-a9aa73ed64ae"),
				Name = @"HomePage",
				ReferenceSchemaUId = new Guid("2b2ed767-0b4b-4a7b-9de2-d48e14a2c0c5"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				ModifiedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90")
			};
		}

		protected virtual EntitySchemaColumn CreateConnectionTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("4acc2d13-7573-41ec-9a30-e20696bf0314"),
				Name = @"ConnectionType",
				CreatedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				ModifiedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866")
			};
		}

		protected virtual EntitySchemaColumn CreateUserConnectionTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("57235d0d-5e90-4767-89dd-6ca3f1ba24c6"),
				Name = @"UserConnectionType",
				ReferenceSchemaUId = new Guid("15ae9439-ba1c-415d-875c-c2aa884f658e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				ModifiedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateForceChangePasswordColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("a3c751b9-544a-420b-8df0-dc3a0e3bc147"),
				Name = @"ForceChangePassword",
				CreatedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				ModifiedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				CreatedInPackageId = new Guid("0e850392-6b68-4c42-8cac-7764bc62a6bb")
			};
		}

		protected virtual EntitySchemaColumn CreateDateTimeFormatColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("057c3dcc-44e5-4f9d-ae7f-a78e24f255bf"),
				Name = @"DateTimeFormat",
				ReferenceSchemaUId = new Guid("2f96cb61-7e14-41e5-980a-bcb856edab51"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				ModifiedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				CreatedInPackageId = new Guid("99cdc391-b063-4233-bdba-da67108d1d1e")
			};
		}

		protected virtual EntitySchemaColumn CreateSysAdminUnitColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("812c55bd-f398-4747-af46-3fa83c335c9d"),
				Name = @"SysAdminUnit",
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				ModifiedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateSessionTimeoutColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("2e74086a-2d4c-48d1-80da-b0d2467597fb"),
				Name = @"SessionTimeout",
				CreatedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				ModifiedInSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwSysAdminUnit_Base_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwSysAdminUnit_Base_TerrasoftEventsProcessSchema() {
			var schema = new VwSysAdminUnit_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwSysAdminUnit_Base_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwSysAdminUnit_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwSysAdminUnit_Base_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwSysAdminUnit_Base_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"));
		}

		#endregion

	}

	#endregion

	#region Class: VwSysAdminUnit_Base_Terrasoft

	/// <summary>
	/// Users/roles (view).
	/// </summary>
	public class VwSysAdminUnit_Base_Terrasoft : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public VwSysAdminUnit_Base_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwSysAdminUnit_Base_Terrasoft";
		}

		public VwSysAdminUnit_Base_Terrasoft(VwSysAdminUnit_Base_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid SysAdminUnitTypeId {
			get {
				return GetTypedColumnValue<Guid>("SysAdminUnitTypeId");
			}
			set {
				SetColumnValue("SysAdminUnitTypeId", value);
				_sysAdminUnitType = null;
			}
		}

		/// <exclude/>
		public string SysAdminUnitTypeName {
			get {
				return GetTypedColumnValue<string>("SysAdminUnitTypeName");
			}
			set {
				SetColumnValue("SysAdminUnitTypeName", value);
				if (_sysAdminUnitType != null) {
					_sysAdminUnitType.Name = value;
				}
			}
		}

		private SysAdminUnitType _sysAdminUnitType;
		/// <summary>
		/// Type.
		/// </summary>
		public SysAdminUnitType SysAdminUnitType {
			get {
				return _sysAdminUnitType ??
					(_sysAdminUnitType = LookupColumnEntities.GetEntity("SysAdminUnitType") as SysAdminUnitType);
			}
		}

		/// <exclude/>
		public Guid ParentRoleId {
			get {
				return GetTypedColumnValue<Guid>("ParentRoleId");
			}
			set {
				SetColumnValue("ParentRoleId", value);
				_parentRole = null;
			}
		}

		/// <exclude/>
		public string ParentRoleName {
			get {
				return GetTypedColumnValue<string>("ParentRoleName");
			}
			set {
				SetColumnValue("ParentRoleName", value);
				if (_parentRole != null) {
					_parentRole.Name = value;
				}
			}
		}

		private VwSysAdminUnit _parentRole;
		/// <summary>
		/// Inherited from.
		/// </summary>
		public VwSysAdminUnit ParentRole {
			get {
				return _parentRole ??
					(_parentRole = LookupColumnEntities.GetEntity("ParentRole") as VwSysAdminUnit);
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

		/// <summary>
		/// Domain user.
		/// </summary>
		public bool IsDirectoryEntry {
			get {
				return GetTypedColumnValue<bool>("IsDirectoryEntry");
			}
			set {
				SetColumnValue("IsDirectoryEntry", value);
			}
		}

		/// <exclude/>
		public Guid TimeZoneId {
			get {
				return GetTypedColumnValue<Guid>("TimeZoneId");
			}
			set {
				SetColumnValue("TimeZoneId", value);
				_timeZone = null;
			}
		}

		/// <exclude/>
		public string TimeZoneName {
			get {
				return GetTypedColumnValue<string>("TimeZoneName");
			}
			set {
				SetColumnValue("TimeZoneName", value);
				if (_timeZone != null) {
					_timeZone.Name = value;
				}
			}
		}

		private TimeZone _timeZone;
		/// <summary>
		/// Time zone.
		/// </summary>
		public TimeZone TimeZone {
			get {
				return _timeZone ??
					(_timeZone = LookupColumnEntities.GetEntity("TimeZone") as TimeZone);
			}
		}

		/// <summary>
		/// Password.
		/// </summary>
		public string UserPassword {
			get {
				return GetTypedColumnValue<string>("UserPassword");
			}
			set {
				SetColumnValue("UserPassword", value);
			}
		}

		/// <summary>
		/// Active.
		/// </summary>
		public bool Active {
			get {
				return GetTypedColumnValue<bool>("Active");
			}
			set {
				SetColumnValue("Active", value);
			}
		}

		/// <summary>
		/// Logged in now.
		/// </summary>
		public bool LoggedIn {
			get {
				return GetTypedColumnValue<bool>("LoggedIn");
			}
			set {
				SetColumnValue("LoggedIn", value);
			}
		}

		/// <summary>
		/// LDAP element.
		/// </summary>
		public string LDAPEntry {
			get {
				return GetTypedColumnValue<string>("LDAPEntry");
			}
			set {
				SetColumnValue("LDAPEntry", value);
			}
		}

		/// <summary>
		/// Synchronize with LDAP.
		/// </summary>
		public bool SynchronizeWithLDAP {
			get {
				return GetTypedColumnValue<bool>("SynchronizeWithLDAP");
			}
			set {
				SetColumnValue("SynchronizeWithLDAP", value);
			}
		}

		/// <summary>
		/// LDAP element Id.
		/// </summary>
		public string LDAPEntryId {
			get {
				return GetTypedColumnValue<string>("LDAPEntryId");
			}
			set {
				SetColumnValue("LDAPEntryId", value);
			}
		}

		/// <summary>
		/// LDAP element unique name .
		/// </summary>
		public string LDAPEntryDN {
			get {
				return GetTypedColumnValue<string>("LDAPEntryDN");
			}
			set {
				SetColumnValue("LDAPEntryDN", value);
			}
		}

		/// <exclude/>
		public Guid SysCultureId {
			get {
				return GetTypedColumnValue<Guid>("SysCultureId");
			}
			set {
				SetColumnValue("SysCultureId", value);
				_sysCulture = null;
			}
		}

		/// <exclude/>
		public string SysCultureName {
			get {
				return GetTypedColumnValue<string>("SysCultureName");
			}
			set {
				SetColumnValue("SysCultureName", value);
				if (_sysCulture != null) {
					_sysCulture.Name = value;
				}
			}
		}

		private SysCulture _sysCulture;
		/// <summary>
		/// Culture.
		/// </summary>
		public SysCulture SysCulture {
			get {
				return _sysCulture ??
					(_sysCulture = LookupColumnEntities.GetEntity("SysCulture") as SysCulture);
			}
		}

		/// <summary>
		/// Password expiration date.
		/// </summary>
		public DateTime PasswordExpireDate {
			get {
				return GetTypedColumnValue<DateTime>("PasswordExpireDate");
			}
			set {
				SetColumnValue("PasswordExpireDate", value);
			}
		}

		/// <exclude/>
		public Guid HomePageId {
			get {
				return GetTypedColumnValue<Guid>("HomePageId");
			}
			set {
				SetColumnValue("HomePageId", value);
				_homePage = null;
			}
		}

		/// <exclude/>
		public string HomePageCaption {
			get {
				return GetTypedColumnValue<string>("HomePageCaption");
			}
			set {
				SetColumnValue("HomePageCaption", value);
				if (_homePage != null) {
					_homePage.Caption = value;
				}
			}
		}

		private SysModule _homePage;
		/// <summary>
		/// Home page.
		/// </summary>
		public SysModule HomePage {
			get {
				return _homePage ??
					(_homePage = LookupColumnEntities.GetEntity("HomePage") as SysModule);
			}
		}

		/// <summary>
		/// Connection type.
		/// </summary>
		public int ConnectionType {
			get {
				return GetTypedColumnValue<int>("ConnectionType");
			}
			set {
				SetColumnValue("ConnectionType", value);
			}
		}

		/// <exclude/>
		public Guid UserConnectionTypeId {
			get {
				return GetTypedColumnValue<Guid>("UserConnectionTypeId");
			}
			set {
				SetColumnValue("UserConnectionTypeId", value);
				_userConnectionType = null;
			}
		}

		/// <exclude/>
		public string UserConnectionTypeName {
			get {
				return GetTypedColumnValue<string>("UserConnectionTypeName");
			}
			set {
				SetColumnValue("UserConnectionTypeName", value);
				if (_userConnectionType != null) {
					_userConnectionType.Name = value;
				}
			}
		}

		private ConnectionType _userConnectionType;
		/// <summary>
		/// User Connection Type.
		/// </summary>
		public ConnectionType UserConnectionType {
			get {
				return _userConnectionType ??
					(_userConnectionType = LookupColumnEntities.GetEntity("UserConnectionType") as ConnectionType);
			}
		}

		/// <summary>
		/// Reset password.
		/// </summary>
		public bool ForceChangePassword {
			get {
				return GetTypedColumnValue<bool>("ForceChangePassword");
			}
			set {
				SetColumnValue("ForceChangePassword", value);
			}
		}

		/// <exclude/>
		public Guid DateTimeFormatId {
			get {
				return GetTypedColumnValue<Guid>("DateTimeFormatId");
			}
			set {
				SetColumnValue("DateTimeFormatId", value);
				_dateTimeFormat = null;
			}
		}

		/// <exclude/>
		public string DateTimeFormatName {
			get {
				return GetTypedColumnValue<string>("DateTimeFormatName");
			}
			set {
				SetColumnValue("DateTimeFormatName", value);
				if (_dateTimeFormat != null) {
					_dateTimeFormat.Name = value;
				}
			}
		}

		private SysLanguage _dateTimeFormat;
		/// <summary>
		/// Date and time format.
		/// </summary>
		public SysLanguage DateTimeFormat {
			get {
				return _dateTimeFormat ??
					(_dateTimeFormat = LookupColumnEntities.GetEntity("DateTimeFormat") as SysLanguage);
			}
		}

		/// <exclude/>
		public Guid SysAdminUnitId {
			get {
				return GetTypedColumnValue<Guid>("SysAdminUnitId");
			}
			set {
				SetColumnValue("SysAdminUnitId", value);
				_sysAdminUnit = null;
			}
		}

		/// <exclude/>
		public string SysAdminUnitName {
			get {
				return GetTypedColumnValue<string>("SysAdminUnitName");
			}
			set {
				SetColumnValue("SysAdminUnitName", value);
				if (_sysAdminUnit != null) {
					_sysAdminUnit.Name = value;
				}
			}
		}

		private SysAdminUnit _sysAdminUnit;
		/// <summary>
		/// System administration object.
		/// </summary>
		public SysAdminUnit SysAdminUnit {
			get {
				return _sysAdminUnit ??
					(_sysAdminUnit = LookupColumnEntities.GetEntity("SysAdminUnit") as SysAdminUnit);
			}
		}

		/// <summary>
		/// Session timeout.
		/// </summary>
		public int SessionTimeout {
			get {
				return GetTypedColumnValue<int>("SessionTimeout");
			}
			set {
				SetColumnValue("SessionTimeout", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwSysAdminUnit_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwSysAdminUnit_Base_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("VwSysAdminUnit_Base_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("VwSysAdminUnit_Base_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("VwSysAdminUnit_Base_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("VwSysAdminUnit_Base_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("VwSysAdminUnit_Base_TerrasoftSaving", e);
			Updated += (s, e) => ThrowEvent("VwSysAdminUnit_Base_TerrasoftUpdated", e);
			Validating += (s, e) => ThrowEvent("VwSysAdminUnit_Base_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwSysAdminUnit_Base_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwSysAdminUnit_BaseEventsProcess

	/// <exclude/>
	public partial class VwSysAdminUnit_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_BaseEventsProcess<TEntity> where TEntity : VwSysAdminUnit_Base_Terrasoft
	{

		public VwSysAdminUnit_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwSysAdminUnit_BaseEventsProcess";
			SchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private Guid _userTypeId = new Guid("472E97C7-6BD7-DF11-9B2A-001D60E938C6");
		public Guid UserTypeId {
			get {
				return _userTypeId;
			}
			set {
				_userTypeId = value;
			}
		}

		private Guid _sSPUserTypeId = new Guid("F4044C41-DF2B-E111-851E-00155D04C01D");
		public Guid SSPUserTypeId {
			get {
				return _sSPUserTypeId;
			}
			set {
				_sSPUserTypeId = value;
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
					SchemaElementUId = new Guid("c1d3a6df-d9ef-443d-9491-d7d8f810d9b0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _vwSysAdminUnitUpdated_StartMessage;
		public ProcessFlowElement VwSysAdminUnitUpdated_StartMessage {
			get {
				return _vwSysAdminUnitUpdated_StartMessage ?? (_vwSysAdminUnitUpdated_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "VwSysAdminUnitUpdated_StartMessage",
					SchemaElementUId = new Guid("9e74411c-5510-4baa-8e91-4ccc903a1566"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _logUpdate_ScriptTask;
		public ProcessScriptTask LogUpdate_ScriptTask {
			get {
				return _logUpdate_ScriptTask ?? (_logUpdate_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "LogUpdate_ScriptTask",
					SchemaElementUId = new Guid("ba71e6e4-5861-4c7a-b5f8-1bf026ab2b29"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = LogUpdate_ScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _vwSysAdminUnitUpdated_IntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent VwSysAdminUnitUpdated_IntermediateThrowMessageEvent {
			get {
				return _vwSysAdminUnitUpdated_IntermediateThrowMessageEvent ?? (_vwSysAdminUnitUpdated_IntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "VwSysAdminUnitUpdated_IntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("c5d63d9b-ca86-45bd-b10d-883ffc70c77c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "VwSysAdminUnitUpdated",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _updatePersonalSessionTimeouts;
		public ProcessScriptTask UpdatePersonalSessionTimeouts {
			get {
				return _updatePersonalSessionTimeouts ?? (_updatePersonalSessionTimeouts = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "UpdatePersonalSessionTimeouts",
					SchemaElementUId = new Guid("6e4c059d-a258-4019-bc47-303f122c13a1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = UpdatePersonalSessionTimeoutsExecute,
				});
			}
		}

		private ProcessFlowElement _subProcess1;
		public ProcessFlowElement SubProcess1 {
			get {
				return _subProcess1 ?? (_subProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess1",
					SchemaElementUId = new Guid("f3c0248d-0dca-48ac-9a01-fb51c132df08"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _vwSysAdminUnitInsertedMessage;
		public ProcessFlowElement VwSysAdminUnitInsertedMessage {
			get {
				return _vwSysAdminUnitInsertedMessage ?? (_vwSysAdminUnitInsertedMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "VwSysAdminUnitInsertedMessage",
					SchemaElementUId = new Guid("d4567378-dd77-438e-a7f5-11a484ddc247"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptVwSysAdminUnitInserted;
		public ProcessScriptTask ScriptVwSysAdminUnitInserted {
			get {
				return _scriptVwSysAdminUnitInserted ?? (_scriptVwSysAdminUnitInserted = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptVwSysAdminUnitInserted",
					SchemaElementUId = new Guid("a7c19b39-2437-4822-a248-ef50bf96c8a8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptVwSysAdminUnitInsertedExecute,
				});
			}
		}

		private ProcessScriptTask _logInsert_ScriptTask;
		public ProcessScriptTask LogInsert_ScriptTask {
			get {
				return _logInsert_ScriptTask ?? (_logInsert_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "LogInsert_ScriptTask",
					SchemaElementUId = new Guid("9f67ae88-4ef9-4578-9174-65bce94b91ca"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = LogInsert_ScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _checkCanChangeBeforeInsertScriptTask;
		public ProcessScriptTask CheckCanChangeBeforeInsertScriptTask {
			get {
				return _checkCanChangeBeforeInsertScriptTask ?? (_checkCanChangeBeforeInsertScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CheckCanChangeBeforeInsertScriptTask",
					SchemaElementUId = new Guid("8f66879a-a664-49b1-bc0b-8ed5c177c591"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CheckCanChangeBeforeInsertScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _insertPersonalTimeouts;
		public ProcessScriptTask InsertPersonalTimeouts {
			get {
				return _insertPersonalTimeouts ?? (_insertPersonalTimeouts = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InsertPersonalTimeouts",
					SchemaElementUId = new Guid("1dfe094f-eaad-4acc-9f31-bc1b463a60c1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InsertPersonalTimeoutsExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessVwSysAdminUnitDeleted;
		public ProcessFlowElement EventSubProcessVwSysAdminUnitDeleted {
			get {
				return _eventSubProcessVwSysAdminUnitDeleted ?? (_eventSubProcessVwSysAdminUnitDeleted = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessVwSysAdminUnitDeleted",
					SchemaElementUId = new Guid("790bf442-6d7b-439b-b68e-c0144ba8a625"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _vwSysAdminUnitSaved;
		public ProcessFlowElement VwSysAdminUnitSaved {
			get {
				return _vwSysAdminUnitSaved ?? (_vwSysAdminUnitSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "VwSysAdminUnitSaved",
					SchemaElementUId = new Guid("c321a464-5ba2-45ab-8263-73617977ccb2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _vwSysAdminUnitDeleted;
		public ProcessFlowElement VwSysAdminUnitDeleted {
			get {
				return _vwSysAdminUnitDeleted ?? (_vwSysAdminUnitDeleted = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "VwSysAdminUnitDeleted",
					SchemaElementUId = new Guid("07af8d7f-31ab-47f5-92d9-9e4a83d6b66e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _logDelete_ScriptTask;
		public ProcessScriptTask LogDelete_ScriptTask {
			get {
				return _logDelete_ScriptTask ?? (_logDelete_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "LogDelete_ScriptTask",
					SchemaElementUId = new Guid("694eafe5-6474-4ee2-8861-e21318f77d29"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = LogDelete_ScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _scriptTaskVwSysAdminUnitDeleted;
		public ProcessScriptTask ScriptTaskVwSysAdminUnitDeleted {
			get {
				return _scriptTaskVwSysAdminUnitDeleted ?? (_scriptTaskVwSysAdminUnitDeleted = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskVwSysAdminUnitDeleted",
					SchemaElementUId = new Guid("e615cb4a-53c7-4822-a32b-aa87e44f8d93"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskVwSysAdminUnitDeletedExecute,
				});
			}
		}

		private ProcessScriptTask _checkCanChangeBeforeSaveScriptTask;
		public ProcessScriptTask CheckCanChangeBeforeSaveScriptTask {
			get {
				return _checkCanChangeBeforeSaveScriptTask ?? (_checkCanChangeBeforeSaveScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CheckCanChangeBeforeSaveScriptTask",
					SchemaElementUId = new Guid("9c8daa2b-2fb5-45c6-a66f-74962a05945c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CheckCanChangeBeforeSaveScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _checkCanChangeBeforeDeleteScriptTask;
		public ProcessScriptTask CheckCanChangeBeforeDeleteScriptTask {
			get {
				return _checkCanChangeBeforeDeleteScriptTask ?? (_checkCanChangeBeforeDeleteScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CheckCanChangeBeforeDeleteScriptTask",
					SchemaElementUId = new Guid("0bfb173f-9eeb-41bd-b2a4-26f2fd9ce0b7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CheckCanChangeBeforeDeleteScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _removePersonalUserSessionTimeout;
		public ProcessScriptTask RemovePersonalUserSessionTimeout {
			get {
				return _removePersonalUserSessionTimeout ?? (_removePersonalUserSessionTimeout = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "RemovePersonalUserSessionTimeout",
					SchemaElementUId = new Guid("193cc7d6-1344-486f-b0bd-797644eb81e5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = RemovePersonalUserSessionTimeoutExecute,
				});
			}
		}

		private ProcessFlowElement _vwSysAdminUnitSaving;
		public ProcessFlowElement VwSysAdminUnitSaving {
			get {
				return _vwSysAdminUnitSaving ?? (_vwSysAdminUnitSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "VwSysAdminUnitSaving",
					SchemaElementUId = new Guid("a1561e7e-fec3-4e8a-949c-4074c9b529f3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage1;
		public ProcessFlowElement StartMessage1 {
			get {
				return _startMessage1 ?? (_startMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage1",
					SchemaElementUId = new Guid("c51669ff-65da-4bb7-98e0-1d1e3399a259"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _checkCanManageUsers;
		public ProcessScriptTask checkCanManageUsers {
			get {
				return _checkCanManageUsers ?? (_checkCanManageUsers = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "checkCanManageUsers",
					SchemaElementUId = new Guid("140b62d5-8948-4aa5-862d-2a3a4581a855"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = checkCanManageUsersExecute,
				});
			}
		}

		private LocalizableString _chiefCaption;
		public LocalizableString ChiefCaption {
			get {
				return _chiefCaption ?? (_chiefCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ChiefCaption.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[VwSysAdminUnitUpdated_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { VwSysAdminUnitUpdated_StartMessage };
			FlowElements[LogUpdate_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { LogUpdate_ScriptTask };
			FlowElements[VwSysAdminUnitUpdated_IntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { VwSysAdminUnitUpdated_IntermediateThrowMessageEvent };
			FlowElements[UpdatePersonalSessionTimeouts.SchemaElementUId] = new Collection<ProcessFlowElement> { UpdatePersonalSessionTimeouts };
			FlowElements[SubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess1 };
			FlowElements[VwSysAdminUnitInsertedMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { VwSysAdminUnitInsertedMessage };
			FlowElements[ScriptVwSysAdminUnitInserted.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptVwSysAdminUnitInserted };
			FlowElements[LogInsert_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { LogInsert_ScriptTask };
			FlowElements[CheckCanChangeBeforeInsertScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckCanChangeBeforeInsertScriptTask };
			FlowElements[InsertPersonalTimeouts.SchemaElementUId] = new Collection<ProcessFlowElement> { InsertPersonalTimeouts };
			FlowElements[EventSubProcessVwSysAdminUnitDeleted.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessVwSysAdminUnitDeleted };
			FlowElements[VwSysAdminUnitSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { VwSysAdminUnitSaved };
			FlowElements[VwSysAdminUnitDeleted.SchemaElementUId] = new Collection<ProcessFlowElement> { VwSysAdminUnitDeleted };
			FlowElements[LogDelete_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { LogDelete_ScriptTask };
			FlowElements[ScriptTaskVwSysAdminUnitDeleted.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskVwSysAdminUnitDeleted };
			FlowElements[CheckCanChangeBeforeSaveScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckCanChangeBeforeSaveScriptTask };
			FlowElements[CheckCanChangeBeforeDeleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckCanChangeBeforeDeleteScriptTask };
			FlowElements[RemovePersonalUserSessionTimeout.SchemaElementUId] = new Collection<ProcessFlowElement> { RemovePersonalUserSessionTimeout };
			FlowElements[VwSysAdminUnitSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { VwSysAdminUnitSaving };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[checkCanManageUsers.SchemaElementUId] = new Collection<ProcessFlowElement> { checkCanManageUsers };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "VwSysAdminUnitUpdated_StartMessage":
						e.Context.QueueTasks.Enqueue("LogUpdate_ScriptTask");
						break;
					case "LogUpdate_ScriptTask":
						e.Context.QueueTasks.Enqueue("UpdatePersonalSessionTimeouts");
						break;
					case "VwSysAdminUnitUpdated_IntermediateThrowMessageEvent":
						break;
					case "UpdatePersonalSessionTimeouts":
						e.Context.QueueTasks.Enqueue("VwSysAdminUnitUpdated_IntermediateThrowMessageEvent");
						break;
					case "SubProcess1":
						break;
					case "VwSysAdminUnitInsertedMessage":
						e.Context.QueueTasks.Enqueue("CheckCanChangeBeforeInsertScriptTask");
						break;
					case "ScriptVwSysAdminUnitInserted":
						e.Context.QueueTasks.Enqueue("InsertPersonalTimeouts");
						break;
					case "LogInsert_ScriptTask":
						e.Context.QueueTasks.Enqueue("ScriptVwSysAdminUnitInserted");
						break;
					case "CheckCanChangeBeforeInsertScriptTask":
						e.Context.QueueTasks.Enqueue("LogInsert_ScriptTask");
						break;
					case "InsertPersonalTimeouts":
						break;
					case "EventSubProcessVwSysAdminUnitDeleted":
						break;
					case "VwSysAdminUnitSaved":
						e.Context.QueueTasks.Enqueue("CheckCanChangeBeforeSaveScriptTask");
						break;
					case "VwSysAdminUnitDeleted":
						e.Context.QueueTasks.Enqueue("CheckCanChangeBeforeDeleteScriptTask");
						break;
					case "LogDelete_ScriptTask":
						e.Context.QueueTasks.Enqueue("ScriptTaskVwSysAdminUnitDeleted");
						break;
					case "ScriptTaskVwSysAdminUnitDeleted":
						break;
					case "CheckCanChangeBeforeSaveScriptTask":
						e.Context.QueueTasks.Enqueue("ScriptTaskVwSysAdminUnitDeleted");
						break;
					case "CheckCanChangeBeforeDeleteScriptTask":
						e.Context.QueueTasks.Enqueue("RemovePersonalUserSessionTimeout");
						break;
					case "RemovePersonalUserSessionTimeout":
						e.Context.QueueTasks.Enqueue("LogDelete_ScriptTask");
						break;
					case "VwSysAdminUnitSaving":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("checkCanManageUsers");
						break;
					case "checkCanManageUsers":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("VwSysAdminUnitUpdated_StartMessage");
			ActivatedEventElements.Add("VwSysAdminUnitInsertedMessage");
			ActivatedEventElements.Add("VwSysAdminUnitSaved");
			ActivatedEventElements.Add("VwSysAdminUnitDeleted");
			ActivatedEventElements.Add("StartMessage1");
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
				case "VwSysAdminUnitUpdated_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "VwSysAdminUnitUpdated_StartMessage";
					result = VwSysAdminUnitUpdated_StartMessage.Execute(context);
					break;
				case "LogUpdate_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "LogUpdate_ScriptTask";
					result = LogUpdate_ScriptTask.Execute(context, LogUpdate_ScriptTaskExecute);
					break;
				case "VwSysAdminUnitUpdated_IntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "VwSysAdminUnitUpdated");
					result = VwSysAdminUnitUpdated_IntermediateThrowMessageEvent.Execute(context);
					break;
				case "UpdatePersonalSessionTimeouts":
					context.QueueTasks.Dequeue();
					context.SenderName = "UpdatePersonalSessionTimeouts";
					result = UpdatePersonalSessionTimeouts.Execute(context, UpdatePersonalSessionTimeoutsExecute);
					break;
				case "SubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "VwSysAdminUnitInsertedMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "VwSysAdminUnitInsertedMessage";
					result = VwSysAdminUnitInsertedMessage.Execute(context);
					break;
				case "ScriptVwSysAdminUnitInserted":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptVwSysAdminUnitInserted";
					result = ScriptVwSysAdminUnitInserted.Execute(context, ScriptVwSysAdminUnitInsertedExecute);
					break;
				case "LogInsert_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "LogInsert_ScriptTask";
					result = LogInsert_ScriptTask.Execute(context, LogInsert_ScriptTaskExecute);
					break;
				case "CheckCanChangeBeforeInsertScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CheckCanChangeBeforeInsertScriptTask";
					result = CheckCanChangeBeforeInsertScriptTask.Execute(context, CheckCanChangeBeforeInsertScriptTaskExecute);
					break;
				case "InsertPersonalTimeouts":
					context.QueueTasks.Dequeue();
					context.SenderName = "InsertPersonalTimeouts";
					result = InsertPersonalTimeouts.Execute(context, InsertPersonalTimeoutsExecute);
					break;
				case "EventSubProcessVwSysAdminUnitDeleted":
					context.QueueTasks.Dequeue();
					break;
				case "VwSysAdminUnitSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "VwSysAdminUnitSaved";
					result = VwSysAdminUnitSaved.Execute(context);
					break;
				case "VwSysAdminUnitDeleted":
					context.QueueTasks.Dequeue();
					context.SenderName = "VwSysAdminUnitDeleted";
					result = VwSysAdminUnitDeleted.Execute(context);
					break;
				case "LogDelete_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "LogDelete_ScriptTask";
					result = LogDelete_ScriptTask.Execute(context, LogDelete_ScriptTaskExecute);
					break;
				case "ScriptTaskVwSysAdminUnitDeleted":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskVwSysAdminUnitDeleted";
					result = ScriptTaskVwSysAdminUnitDeleted.Execute(context, ScriptTaskVwSysAdminUnitDeletedExecute);
					break;
				case "CheckCanChangeBeforeSaveScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CheckCanChangeBeforeSaveScriptTask";
					result = CheckCanChangeBeforeSaveScriptTask.Execute(context, CheckCanChangeBeforeSaveScriptTaskExecute);
					break;
				case "CheckCanChangeBeforeDeleteScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CheckCanChangeBeforeDeleteScriptTask";
					result = CheckCanChangeBeforeDeleteScriptTask.Execute(context, CheckCanChangeBeforeDeleteScriptTaskExecute);
					break;
				case "RemovePersonalUserSessionTimeout":
					context.QueueTasks.Dequeue();
					context.SenderName = "RemovePersonalUserSessionTimeout";
					result = RemovePersonalUserSessionTimeout.Execute(context, RemovePersonalUserSessionTimeoutExecute);
					break;
				case "VwSysAdminUnitSaving":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1";
					result = StartMessage1.Execute(context);
					break;
				case "checkCanManageUsers":
					context.QueueTasks.Dequeue();
					context.SenderName = "checkCanManageUsers";
					result = checkCanManageUsers.Execute(context, checkCanManageUsersExecute);
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
				case "SSPUserTypeId":
					SSPUserTypeId = reader.GetValue<System.Guid>();
				break;
				case "UserTypeId":
					UserTypeId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool LogUpdate_ScriptTaskExecute(ProcessExecutingContext context) {
			if (GetIsAdminUnitNotUser()) {
				OperationLogger.Instance.LogAdminUnitEdit(UserConnection, Entity.Name, Entity.GetChangedColumnValues().Where(c => c.Column.UsageType != Terrasoft.Core.Entities.EntitySchemaColumnUsageType.Advanced));
			}
			else {
				OperationLogger.Instance.LogUserEdit(UserConnection, Entity.Name, Entity.GetChangedColumnValues().Where(c => c.Column.UsageType != Terrasoft.Core.Entities.EntitySchemaColumnUsageType.Advanced));
			}
			return true;
		}

		public virtual bool UpdatePersonalSessionTimeoutsExecute(ProcessExecutingContext context) {
			#if !NETSTANDARD2_0 // TODO CRM-44388
			SessionHelper sessionHelper = new SessionHelper();
			var changedSessionTimeoutColumn = Entity.GetChangedColumnValues().Where(changedColumn => changedColumn.Name == "SessionTimeout");
			if (changedSessionTimeoutColumn.Count() == 0) {
				return true;
			}
			var sessionTimeoutColumn = changedSessionTimeoutColumn.First();
			if (GetIsAdminUnitNotUser()) {
				sessionHelper.SetPersonalUserSessionTimeouts(UserConnection.AppConnection.SystemUserConnection);
			} else {
				object newValue = sessionTimeoutColumn.Value;
				if (newValue.ToString() == string.Empty) {
					sessionHelper.UpdatePersonalUserSessionTimeoutFromDB(UserConnection.AppConnection.SystemUserConnection, Entity.Id);
				} else {
					sessionHelper.UpdatePersonalUserSessionTimeoutInCache(Entity.Name, Entity.SessionTimeout);
				}
			}
			#endif
			return true;
		}

		public virtual bool ScriptVwSysAdminUnitInsertedExecute(ProcessExecutingContext context) {
			if (Entity.SysAdminUnitTypeId == new Guid("DF93DCB9-6BD7-DF11-9B2A-001D60E938C6") || Entity.SysAdminUnitTypeId == new Guid("B659F1C0-6BD7-DF11-9B2A-001D60E938C6")) {
				var selectCount = new Terrasoft.Core.DB.Select(Entity.UserConnection)
						.Column(Terrasoft.Core.DB.Func.Count(Terrasoft.Core.DB.Column.Asterisk()))
					.From("SysAdminUnit")
					.Where("SysAdminUnitTypeValue").IsEqual(Terrasoft.Core.DB.Column.Parameter(2))
					.And("ParentRoleId").IsEqual(Terrasoft.Core.DB.Column.Parameter(Entity.Id)) as Terrasoft.Core.DB.Select;
				using (var dbExecutor = UserConnection.EnsureDBConnection()) {	
					using (var reader = selectCount.ExecuteReader(dbExecutor)) {
						if (reader.Read()) {
							if (UserConnection.DBTypeConverter.DBValueToInt(reader[0]) > 0) {
							return true;
							}
						}
					}
				}
				Guid acountId = Entity.AccountId;
				string adminUnitName = string.Concat(Entity.Name, ". ", ChiefCaption);
				var nullParameter = Terrasoft.Core.DB.Column.Parameter(DBNull.Value, new GuidDataValueType(UserConnection.DataValueTypeManager));
				var insert = new Terrasoft.Core.DB.Insert(Entity.UserConnection).Into("SysAdminUnit")
					.Set("Id", Terrasoft.Core.DB.Column.Parameter(Guid.NewGuid()))
					.Set("CreatedOn", Terrasoft.Core.DB.Column.Parameter(DateTime.UtcNow))
					.Set("CreatedById", Terrasoft.Core.DB.Column.Parameter(Entity.UserConnection.CurrentUser.ContactId))
					.Set("ModifiedOn", Terrasoft.Core.DB.Column.Parameter(DateTime.UtcNow))
					.Set("ModifiedById", Terrasoft.Core.DB.Column.Parameter(Entity.UserConnection.CurrentUser.ContactId))
					.Set("Name", Terrasoft.Core.DB.Column.Parameter(adminUnitName))
					.Set("SysAdminUnitTypeValue", Terrasoft.Core.DB.Column.Parameter(2))
					.Set("ParentRoleId", Terrasoft.Core.DB.Column.Parameter(Entity.Id))
					.Set("AccountId", acountId.Equals(Guid.Empty) ? nullParameter : Terrasoft.Core.DB.Column.Parameter(acountId))
					.Set("ConnectionType",
						new Select(Entity.UserConnection)
							.Column("ConnectionType")
						.From("SysAdminUnit")
						.Where("Id").IsEqual(Terrasoft.Core.DB.Column.Parameter(Entity.Id)) as Select);
				insert.Execute();
				OperationLogger.Instance.LogAdminUnitAdd(UserConnection, adminUnitName);
			}
			return true;
		}

		public virtual bool LogInsert_ScriptTaskExecute(ProcessExecutingContext context) {
			if (GetIsAdminUnitNotUser()) {
				OperationLogger.Instance.LogAdminUnitAdd(UserConnection, Entity.Name);
			}
			else {
				OperationLogger.Instance.LogUserAdd(UserConnection, Entity.Name);
			}
			return true;
		}

		public virtual bool CheckCanChangeBeforeInsertScriptTaskExecute(ProcessExecutingContext context) {
			return ValidateCanChangeRecord();
		}

		public virtual bool InsertPersonalTimeoutsExecute(ProcessExecutingContext context) {
			#if !NETSTANDARD2_0 // TODO CRM-44388
			if (!GetIsAdminUnitNotUser()) {
				SessionHelper sessionHelper = new SessionHelper();
				sessionHelper.UpdatePersonalUserSessionTimeoutInCache(Entity.Name, Entity.SessionTimeout);
			}
			#endif
			return true;
		}

		public virtual bool LogDelete_ScriptTaskExecute(ProcessExecutingContext context) {
			if (GetIsAdminUnitNotUser()) {
				OperationLogger.Instance.LogAdminUnitDelete(UserConnection, Entity.Name);
			}
			else {
				OperationLogger.Instance.LogUserDelete(UserConnection, Entity.Name);
			}
			return true;
		}

		public virtual bool ScriptTaskVwSysAdminUnitDeletedExecute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool CheckCanChangeBeforeSaveScriptTaskExecute(ProcessExecutingContext context) {
			return ValidateCanChangeRecord();
		}

		public virtual bool CheckCanChangeBeforeDeleteScriptTaskExecute(ProcessExecutingContext context) {
			return ValidateCanChangeRecord();
		}

		public virtual bool RemovePersonalUserSessionTimeoutExecute(ProcessExecutingContext context) {
			#if !NETSTANDARD2_0 // TODO CRM-44388
			if (!GetIsAdminUnitNotUser()) {
				SessionHelper sessionHelper = new SessionHelper();
				sessionHelper.RemovePersonalUserSessionTimeoutFromCache(Entity.Name);
			}
			#endif
			return true;
		}

		public virtual bool checkCanManageUsersExecute(ProcessExecutingContext context) {
			return ValidateCanChangeRecord();
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "VwSysAdminUnit_Base_TerrasoftUpdated":
							if (ActivatedEventElements.Contains("VwSysAdminUnitUpdated_StartMessage")) {
							context.QueueTasks.Enqueue("VwSysAdminUnitUpdated_StartMessage");
						}
						break;
					case "VwSysAdminUnit_Base_TerrasoftInserted":
							if (ActivatedEventElements.Contains("VwSysAdminUnitInsertedMessage")) {
							context.QueueTasks.Enqueue("VwSysAdminUnitInsertedMessage");
						}
						break;
					case "VwSysAdminUnit_Base_TerrasoftSaved":
							if (ActivatedEventElements.Contains("VwSysAdminUnitSaved")) {
							context.QueueTasks.Enqueue("VwSysAdminUnitSaved");
						}
						break;
					case "VwSysAdminUnit_Base_TerrasoftDeleted":
							if (ActivatedEventElements.Contains("VwSysAdminUnitDeleted")) {
							context.QueueTasks.Enqueue("VwSysAdminUnitDeleted");
						}
						break;
					case "VwSysAdminUnit_Base_TerrasoftSaving":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("SSPUserTypeId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SSPUserTypeId", SSPUserTypeId, Guid.Empty);
			}
			if (!HasMapping("UserTypeId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("UserTypeId", UserTypeId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: VwSysAdminUnit_BaseEventsProcess

	/// <exclude/>
	public class VwSysAdminUnit_BaseEventsProcess : VwSysAdminUnit_BaseEventsProcess<VwSysAdminUnit_Base_Terrasoft>
	{

		public VwSysAdminUnit_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwSysAdminUnit_BaseEventsProcess

	public partial class VwSysAdminUnit_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual bool GetIsAdminUnitNotUser() {
			var currentTypeId = Entity.GetTypedColumnValue<Guid>("SysAdminUnitTypeId");
			return (currentTypeId != UserTypeId) && (currentTypeId != SSPUserTypeId);
		}

		public virtual bool ValidateCanChangeRecord() {
			UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageAdministration");
			return true;
		}

		public override void CheckCanManageLookups() {
		}

		#endregion

	}

	#endregion

	#region Class: VwSysAdminUnit_Base_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class VwSysAdminUnit_Base_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseLookupEventsProcessSchema
	{

		#region Constructors: Public

		public VwSysAdminUnit_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwSysAdminUnit_Base_TerrasoftEventsProcessSchema(VwSysAdminUnit_Base_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwSysAdminUnit_BaseEventsProcess";
			UId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109");
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

		protected virtual ProcessSchemaParameter CreateUserTypeIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b3406346-ea6f-457b-9009-85aa3f110f19"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				Name = @"UserTypeId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"472E97C7-6BD7-DF11-9B2A-001D60E938C6",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateSSPUserTypeIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("39175790-4b46-43e4-9d97-6b38b3047abd"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				Name = @"SSPUserTypeId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"F4044C41-DF2B-E111-851E-00155D04C01D",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateUserTypeIdParameter());
			Parameters.Add(CreateSSPUserTypeIdParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet899 = CreateLaneSet899LaneSet();
			LaneSets.Add(schemaLaneSet899);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet899.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess subprocess1 = CreateSubProcess1EventSubProcess();
			FlowElements.Add(subprocess1);
			ProcessSchemaEventSubProcess eventsubprocessvwsysadminunitdeleted = CreateEventSubProcessVwSysAdminUnitDeletedEventSubProcess();
			FlowElements.Add(eventsubprocessvwsysadminunitdeleted);
			ProcessSchemaEventSubProcess vwsysadminunitsaving = CreateVwSysAdminUnitSavingEventSubProcess();
			FlowElements.Add(vwsysadminunitsaving);
			ProcessSchemaStartMessageEvent vwsysadminunitupdated_startmessage = CreateVwSysAdminUnitUpdated_StartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(vwsysadminunitupdated_startmessage);
			ProcessSchemaScriptTask logupdate_scripttask = CreateLogUpdate_ScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(logupdate_scripttask);
			ProcessSchemaIntermediateThrowMessageEvent vwsysadminunitupdated_intermediatethrowmessageevent = CreateVwSysAdminUnitUpdated_IntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(vwsysadminunitupdated_intermediatethrowmessageevent);
			ProcessSchemaScriptTask updatepersonalsessiontimeouts = CreateUpdatePersonalSessionTimeoutsScriptTask();
			eventsubprocess1.FlowElements.Add(updatepersonalsessiontimeouts);
			ProcessSchemaStartMessageEvent vwsysadminunitinsertedmessage = CreateVwSysAdminUnitInsertedMessageStartMessageEvent();
			subprocess1.FlowElements.Add(vwsysadminunitinsertedmessage);
			ProcessSchemaScriptTask scriptvwsysadminunitinserted = CreateScriptVwSysAdminUnitInsertedScriptTask();
			subprocess1.FlowElements.Add(scriptvwsysadminunitinserted);
			ProcessSchemaScriptTask loginsert_scripttask = CreateLogInsert_ScriptTaskScriptTask();
			subprocess1.FlowElements.Add(loginsert_scripttask);
			ProcessSchemaScriptTask checkcanchangebeforeinsertscripttask = CreateCheckCanChangeBeforeInsertScriptTaskScriptTask();
			subprocess1.FlowElements.Add(checkcanchangebeforeinsertscripttask);
			ProcessSchemaScriptTask insertpersonaltimeouts = CreateInsertPersonalTimeoutsScriptTask();
			subprocess1.FlowElements.Add(insertpersonaltimeouts);
			ProcessSchemaStartMessageEvent vwsysadminunitsaved = CreateVwSysAdminUnitSavedStartMessageEvent();
			eventsubprocessvwsysadminunitdeleted.FlowElements.Add(vwsysadminunitsaved);
			ProcessSchemaStartMessageEvent vwsysadminunitdeleted = CreateVwSysAdminUnitDeletedStartMessageEvent();
			eventsubprocessvwsysadminunitdeleted.FlowElements.Add(vwsysadminunitdeleted);
			ProcessSchemaScriptTask logdelete_scripttask = CreateLogDelete_ScriptTaskScriptTask();
			eventsubprocessvwsysadminunitdeleted.FlowElements.Add(logdelete_scripttask);
			ProcessSchemaScriptTask scripttaskvwsysadminunitdeleted = CreateScriptTaskVwSysAdminUnitDeletedScriptTask();
			eventsubprocessvwsysadminunitdeleted.FlowElements.Add(scripttaskvwsysadminunitdeleted);
			ProcessSchemaScriptTask checkcanchangebeforesavescripttask = CreateCheckCanChangeBeforeSaveScriptTaskScriptTask();
			eventsubprocessvwsysadminunitdeleted.FlowElements.Add(checkcanchangebeforesavescripttask);
			ProcessSchemaScriptTask checkcanchangebeforedeletescripttask = CreateCheckCanChangeBeforeDeleteScriptTaskScriptTask();
			eventsubprocessvwsysadminunitdeleted.FlowElements.Add(checkcanchangebeforedeletescripttask);
			ProcessSchemaScriptTask removepersonalusersessiontimeout = CreateRemovePersonalUserSessionTimeoutScriptTask();
			eventsubprocessvwsysadminunitdeleted.FlowElements.Add(removepersonalusersessiontimeout);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			vwsysadminunitsaving.FlowElements.Add(startmessage1);
			ProcessSchemaScriptTask checkcanmanageusers = CreatecheckCanManageUsersScriptTask();
			vwsysadminunitsaving.FlowElements.Add(checkcanmanageusers);
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13_a2d36af31dc743deb8f2213906008fa1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14_ae729db1763943739eb446787091304cSequenceFlow());
			FlowElements.Add(CreateSequenceFlow15_01b50f8b87b247b7897de04797aebae9SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateChiefCaptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateChiefCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("0461d863-8fd7-40f4-8654-92c11b4a9565"),
				Name = "ChiefCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("c3cf03f8-c521-41c2-8f08-a05fe4114dce"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				CurveCenterPosition = new Point(222, 432),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("07af8d7f-31ab-47f5-92d9-9e4a83d6b66e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0bfb173f-9eeb-41bd-b2a4-26f2fd9ce0b7"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("700ce215-a94c-4750-bd36-91ddf9855bed"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				CurveCenterPosition = new Point(400, 406),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("694eafe5-6474-4ee2-8861-e21318f77d29"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e615cb4a-53c7-4822-a32b-aa87e44f8d93"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(534, 578));
			schemaFlow.PolylinePointPositions.Add(new Point(557, 578));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("11866824-7996-4563-9a61-832e5098ac1b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				CurveCenterPosition = new Point(233, 115),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d4567378-dd77-438e-a7f5-11a484ddc247"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8f66879a-a664-49b1-bc0b-8ed5c177c591"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("dc1e7a7d-9062-4a68-aa3d-0908cc6ea963"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				CurveCenterPosition = new Point(401, 118),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9f67ae88-4ef9-4578-9174-65bce94b91ca"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a7c19b39-2437-4822-a248-ef50bf96c8a8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("4e79d4d3-4bc1-43b0-ab26-fc877c94a81a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				CurveCenterPosition = new Point(220, 196),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9e74411c-5510-4baa-8e91-4ccc903a1566"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ba71e6e4-5861-4c7a-b5f8-1bf026ab2b29"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(149, 79));
			schemaFlow.PolylinePointPositions.Add(new Point(149, 78));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("16d16350-82ea-45c6-b9bb-1244768d0e73"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				CurveCenterPosition = new Point(387, 198),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ba71e6e4-5861-4c7a-b5f8-1bf026ab2b29"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6e4c059d-a258-4019-bc47-303f122c13a1"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("5aee1f1a-516c-4546-bba5-5ed20e0d6dc4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("6ff020f5-e34d-4da9-8c0d-3678e6f20dbf"),
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				CurveCenterPosition = new Point(221, 488),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c321a464-5ba2-45ab-8263-73617977ccb2"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9c8daa2b-2fb5-45c6-a66f-74962a05945c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("35f1e851-1cb3-4a8a-8c57-7d1f6ff1cfb6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("6ff020f5-e34d-4da9-8c0d-3678e6f20dbf"),
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				CurveCenterPosition = new Point(456, 494),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9c8daa2b-2fb5-45c6-a66f-74962a05945c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e615cb4a-53c7-4822-a32b-aa87e44f8d93"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("29c4ff33-16aa-4568-9b7e-320735d3f35c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("6ff020f5-e34d-4da9-8c0d-3678e6f20dbf"),
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				CurveCenterPosition = new Point(389, 604),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0bfb173f-9eeb-41bd-b2a4-26f2fd9ce0b7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("193cc7d6-1344-486f-b0bd-797644eb81e5"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("5019d08f-b4de-4b58-ab04-d0262ef8efb1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("6ff020f5-e34d-4da9-8c0d-3678e6f20dbf"),
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				CurveCenterPosition = new Point(307, 296),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8f66879a-a664-49b1-bc0b-8ed5c177c591"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9f67ae88-4ef9-4578-9174-65bce94b91ca"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("6e94a050-7472-40df-90b0-42c82df36133"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("8d614e33-8093-46bf-987f-21093279b4e0"),
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c51669ff-65da-4bb7-98e0-1d1e3399a259"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("140b62d5-8948-4aa5-862d-2a3a4581a855"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13_a2d36af31dc743deb8f2213906008fa1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13_a2d36af31dc743deb8f2213906008fa1",
				UId = new Guid("a2d36af3-1dc7-43de-b8f2-213906008fa1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("193cc7d6-1344-486f-b0bd-797644eb81e5"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("694eafe5-6474-4ee2-8861-e21318f77d29"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14_ae729db1763943739eb446787091304cSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14_ae729db1763943739eb446787091304c",
				UId = new Guid("ae729db1-7639-4373-9eb4-46787091304c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a7c19b39-2437-4822-a248-ef50bf96c8a8"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1dfe094f-eaad-4acc-9f31-bc1b463a60c1"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15_01b50f8b87b247b7897de04797aebae9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow15_01b50f8b87b247b7897de04797aebae9",
				UId = new Guid("01b50f8b-87b2-47b7-897d-e04797aebae9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6e4c059d-a258-4019-bc47-303f122c13a1"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c5d63d9b-ca86-45bd-b10d-883ffc70c77c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet899LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet899 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("2d65fe46-9373-4eb0-9467-05bab04d9d93"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				Name = @"LaneSet899",
				Position = new Point(5, 5),
				Size = new Size(853, 165),
				UseBackgroundMode = false
			};
			return schemaLaneSet899;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("ef7835d8-24c8-4f91-8e44-b3b2dc32abee"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("2d65fe46-9373-4eb0-9467-05bab04d9d93"),
				CreatedInOwnerSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(824, 165),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c1d3a6df-d9ef-443d-9491-d7d8f810d9b0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ef7835d8-24c8-4f91-8e44-b3b2dc32abee"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(49, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(449, 144),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateVwSysAdminUnitUpdated_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("9e74411c-5510-4baa-8e91-4ccc903a1566"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c1d3a6df-d9ef-443d-9491-d7d8f810d9b0"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"VwSysAdminUnitUpdated",
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				Name = @"VwSysAdminUnitUpdated_StartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(50, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateLogUpdate_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ba71e6e4-5861-4c7a-b5f8-1bf026ab2b29"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c1d3a6df-d9ef-443d-9491-d7d8f810d9b0"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				Name = @"LogUpdate_ScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(123, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,143,193,106,195,48,16,68,207,53,248,31,148,155,4,69,63,16,82,8,38,132,64,73,15,137,211,179,144,38,182,192,94,133,213,186,96,66,255,189,118,13,190,246,220,219,14,179,111,119,38,222,149,62,66,78,121,31,250,72,53,69,57,39,169,51,88,27,163,158,101,241,242,241,0,59,137,137,222,83,211,128,237,137,178,56,242,176,147,94,153,67,136,162,103,170,74,68,240,243,250,171,58,144,68,25,237,217,245,88,197,244,170,106,29,53,8,85,234,134,158,110,174,27,144,181,177,159,45,24,218,171,221,155,242,118,241,108,157,93,131,235,248,128,218,236,212,21,204,46,167,187,76,46,195,254,222,139,200,203,48,94,124,139,222,45,220,138,217,125,248,154,163,6,99,182,101,241,93,22,232,50,254,44,53,215,248,39,125,24,50,48,41,225,1,219,31,23,4,150,51,201,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateVwSysAdminUnitUpdated_IntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("c5d63d9b-ca86-45bd-b10d-883ffc70c77c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c1d3a6df-d9ef-443d-9491-d7d8f810d9b0"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"VwSysAdminUnitUpdated",
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				Name = @"VwSysAdminUnitUpdated_IntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(351, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateUpdatePersonalSessionTimeoutsScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6e4c059d-a258-4019-bc47-303f122c13a1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c1d3a6df-d9ef-443d-9491-d7d8f810d9b0"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				Name = @"UpdatePersonalSessionTimeouts",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(209, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,81,79,194,48,16,199,159,217,167,168,240,210,37,90,136,242,64,66,102,50,55,80,30,28,134,13,125,52,115,59,160,102,107,151,182,211,16,195,119,183,29,160,212,32,9,111,237,221,191,247,191,223,245,58,116,129,46,162,81,18,39,126,20,250,179,240,250,181,135,186,93,148,76,195,41,10,102,143,87,253,254,205,96,224,196,32,37,229,236,1,138,10,4,146,214,205,67,12,62,145,165,192,238,208,249,72,5,202,86,41,91,66,190,203,37,180,4,94,171,128,23,117,201,244,179,17,83,84,173,201,61,168,96,171,219,102,158,211,162,6,137,93,242,178,2,1,56,59,204,33,239,22,89,1,18,165,37,32,207,67,109,219,164,173,59,208,100,248,68,7,36,224,53,83,216,53,175,123,46,250,114,90,2,84,45,24,82,162,134,161,179,105,8,228,241,214,79,149,29,83,33,21,222,249,107,184,137,244,243,146,178,57,163,42,226,106,46,205,120,26,59,107,140,36,6,245,4,66,114,150,22,70,99,151,150,216,196,2,206,24,100,74,135,137,95,85,7,183,120,45,21,148,182,68,55,176,65,80,72,48,86,252,237,93,71,205,71,53,211,213,4,199,192,72,147,28,58,45,211,249,94,75,18,30,43,65,217,114,59,41,217,156,201,168,172,212,186,161,248,131,49,175,242,84,193,255,36,99,193,203,240,238,124,156,203,253,186,76,114,77,214,250,69,59,211,127,194,130,52,91,1,222,85,51,235,243,83,218,86,54,54,122,13,58,192,114,186,112,14,151,227,27,245,195,96,132,53,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f3c0248d-0dca-48ac-9a01-fb51c132df08"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ef7835d8-24c8-4f91-8e44-b3b2dc32abee"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				Name = @"SubProcess1",
				Position = new Point(20, 180),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(625, 240),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateVwSysAdminUnitInsertedMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d4567378-dd77-438e-a7f5-11a484ddc247"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f3c0248d-0dca-48ac-9a01-fb51c132df08"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"VwSysAdminUnitInserted",
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				Name = @"VwSysAdminUnitInsertedMessage",
				Position = new Point(42, 77),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptVwSysAdminUnitInsertedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a7c19b39-2437-4822-a248-ef50bf96c8a8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f3c0248d-0dca-48ac-9a01-fb51c132df08"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				Name = @"ScriptVwSysAdminUnitInserted",
				Position = new Point(344, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,85,77,111,211,64,16,61,7,137,255,176,242,201,150,146,85,82,68,32,84,5,197,118,130,34,209,20,181,41,28,16,135,197,158,180,43,146,117,88,175,91,34,202,127,103,102,253,81,59,77,192,21,112,136,35,207,120,223,204,188,153,121,43,151,204,157,40,35,205,150,95,108,211,113,188,150,234,82,73,179,216,110,96,22,179,147,19,166,224,150,189,205,100,236,58,225,116,244,44,12,252,81,111,232,135,47,122,225,116,48,232,141,252,163,113,175,223,31,132,195,254,100,244,236,101,48,116,60,118,119,199,90,2,250,195,231,163,233,32,232,255,30,208,99,63,158,62,233,220,8,205,82,88,65,100,130,36,83,134,229,56,11,208,90,164,201,210,240,32,209,192,67,159,95,216,111,202,146,46,83,208,65,162,20,154,100,162,60,196,233,116,240,211,85,182,86,238,195,179,211,76,69,220,194,239,113,230,167,248,56,53,160,101,250,213,245,60,11,199,167,58,89,187,78,189,84,39,119,124,188,6,13,77,15,145,240,65,172,50,112,60,62,75,39,223,50,177,58,28,233,189,208,98,13,24,205,61,42,66,141,21,146,134,102,80,230,60,89,33,157,143,131,41,56,153,197,72,169,72,15,114,119,140,177,178,84,170,43,230,18,233,241,151,201,119,136,50,147,104,228,188,201,39,159,168,52,211,16,250,247,38,151,218,213,161,108,107,16,26,68,12,116,188,214,64,158,163,194,185,245,185,247,81,138,126,119,58,18,39,51,63,201,233,35,183,114,88,207,78,38,161,79,220,162,225,6,52,214,138,239,150,231,69,50,195,102,230,40,159,250,159,61,246,154,245,43,24,13,38,211,138,25,157,193,113,110,249,105,255,236,147,30,244,163,73,101,34,162,148,105,124,203,209,30,71,133,137,78,166,70,83,173,162,108,243,28,9,167,106,173,25,217,85,145,168,38,146,124,93,230,112,230,116,89,112,45,97,25,136,141,157,205,227,98,200,85,182,90,85,61,67,148,22,141,13,253,57,30,226,182,226,110,181,95,161,48,34,39,1,153,121,192,87,221,121,42,148,184,2,100,190,204,65,42,252,250,240,142,205,172,251,192,142,161,215,36,123,23,226,2,140,235,224,208,118,219,212,68,21,240,57,220,90,165,40,119,205,34,4,216,78,3,241,153,106,7,132,149,194,66,174,129,95,154,104,158,220,238,65,242,183,109,147,218,91,49,15,50,77,43,73,86,106,182,17,145,161,29,187,143,115,154,196,114,41,255,73,202,37,212,127,207,153,230,180,93,128,198,216,215,33,246,43,95,43,204,163,58,78,67,241,30,83,115,179,162,106,101,17,163,92,104,110,197,51,205,167,109,178,222,152,173,199,222,236,172,224,171,86,36,20,128,141,241,170,232,166,234,157,174,21,23,218,168,63,223,81,213,37,181,11,82,92,97,135,46,157,234,214,249,203,187,33,207,208,234,65,174,5,165,92,187,214,118,182,1,45,40,167,119,201,21,10,7,9,130,17,42,2,142,239,85,70,227,56,222,81,157,110,83,34,9,10,37,182,46,195,191,0,122,56,178,229,142,8,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateLogInsert_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9f67ae88-4ef9-4578-9174-65bce94b91ca"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f3c0248d-0dca-48ac-9a01-fb51c132df08"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				Name = @"LogInsert_ScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(238, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,112,79,45,241,44,118,76,201,205,204,11,205,203,44,241,203,47,9,45,78,45,210,208,212,84,168,230,229,226,244,47,72,45,74,44,201,204,207,243,201,79,79,79,45,210,243,204,43,46,73,204,75,78,213,3,242,225,122,28,83,82,52,64,154,156,243,243,242,82,147,65,170,117,20,92,243,74,50,75,42,245,252,18,115,83,53,173,121,185,106,121,185,82,115,138,83,9,154,9,50,134,56,227,138,82,75,74,139,242,20,74,138,74,83,173,1,209,8,253,48,199,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateCheckCanChangeBeforeInsertScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8f66879a-a664-49b1-bc0b-8ed5c177c591"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f3c0248d-0dca-48ac-9a01-fb51c132df08"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("6ff020f5-e34d-4da9-8c0d-3678e6f20dbf"),
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				Name = @"CheckCanChangeBeforeInsertScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(120, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,8,75,204,201,76,73,44,73,117,78,204,115,206,72,204,75,79,13,74,77,206,47,74,209,208,180,6,0,130,136,27,238,33,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateInsertPersonalTimeoutsScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1dfe094f-eaad-4acc-9f31-bc1b463a60c1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f3c0248d-0dca-48ac-9a01-fb51c132df08"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				Name = @"InsertPersonalTimeouts",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(511, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,204,193,10,130,64,20,133,225,117,243,20,87,218,140,80,22,213,66,144,22,162,81,45,210,208,113,29,146,87,26,200,107,204,92,137,136,222,61,131,54,179,60,240,157,127,170,91,240,178,157,42,85,156,165,113,145,174,46,75,88,44,64,229,105,14,73,113,154,111,54,235,48,20,35,146,222,30,249,104,227,166,211,84,145,230,172,231,202,162,145,190,15,111,49,41,209,90,221,211,1,239,15,52,96,157,181,5,194,39,56,66,250,145,152,56,42,168,30,77,205,120,70,99,123,170,239,191,244,255,161,116,135,253,192,71,74,234,235,13,229,142,88,243,43,200,234,14,103,240,31,174,28,219,31,49,69,106,116,43,12,242,96,8,216,12,24,125,1,52,32,189,124,235,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessVwSysAdminUnitDeletedEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessVwSysAdminUnitDeleted = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("790bf442-6d7b-439b-b68e-c0144ba8a625"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ef7835d8-24c8-4f91-8e44-b3b2dc32abee"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81"),
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				Name = @"EventSubProcessVwSysAdminUnitDeleted",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(57, 465),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(753, 240),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessVwSysAdminUnitDeleted;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateVwSysAdminUnitSavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c321a464-5ba2-45ab-8263-73617977ccb2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("790bf442-6d7b-439b-b68e-c0144ba8a625"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81"),
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"VwSysAdminUnitSaved",
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				Name = @"VwSysAdminUnitSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(35, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateVwSysAdminUnitDeletedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("07af8d7f-31ab-47f5-92d9-9e4a83d6b66e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("790bf442-6d7b-439b-b68e-c0144ba8a625"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81"),
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"VwSysAdminUnitDeleted",
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				Name = @"VwSysAdminUnitDeleted",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(35, 152),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateLogDelete_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("694eafe5-6474-4ee2-8861-e21318f77d29"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("790bf442-6d7b-439b-b68e-c0144ba8a625"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				Name = @"LogDelete_ScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(443, 138),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,204,177,10,194,48,20,70,225,217,64,222,33,99,2,146,23,232,36,42,82,144,118,234,3,132,250,91,46,180,55,114,115,59,72,241,221,53,139,171,142,103,248,14,221,157,191,64,219,114,184,45,196,3,147,118,89,135,2,241,33,184,205,154,93,255,128,36,165,204,215,60,77,144,216,114,209,196,35,226,167,191,230,132,25,10,95,221,49,51,99,172,96,239,206,172,164,207,216,165,5,161,177,230,101,13,230,130,159,219,186,249,251,40,208,85,216,169,172,104,222,186,84,148,19,205,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskVwSysAdminUnitDeletedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e615cb4a-53c7-4822-a32b-aa87e44f8d93"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("790bf442-6d7b-439b-b68e-c0144ba8a625"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81"),
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				Name = @"ScriptTaskVwSysAdminUnitDeleted",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(466, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateCheckCanChangeBeforeSaveScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9c8daa2b-2fb5-45c6-a66f-74962a05945c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("790bf442-6d7b-439b-b68e-c0144ba8a625"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("6ff020f5-e34d-4da9-8c0d-3678e6f20dbf"),
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				Name = @"CheckCanChangeBeforeSaveScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(154, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,8,75,204,201,76,73,44,73,117,78,204,115,206,72,204,75,79,13,74,77,206,47,74,209,208,180,6,0,130,136,27,238,33,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateCheckCanChangeBeforeDeleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0bfb173f-9eeb-41bd-b2a4-26f2fd9ce0b7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("790bf442-6d7b-439b-b68e-c0144ba8a625"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("6ff020f5-e34d-4da9-8c0d-3678e6f20dbf"),
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				Name = @"CheckCanChangeBeforeDeleteScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(147, 138),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,8,75,204,201,76,73,44,73,117,78,204,115,206,72,204,75,79,13,74,77,206,47,74,209,208,180,6,0,130,136,27,238,33,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateRemovePersonalUserSessionTimeoutScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("193cc7d6-1344-486f-b0bd-797644eb81e5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("790bf442-6d7b-439b-b68e-c0144ba8a625"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				Name = @"RemovePersonalUserSessionTimeout",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(292, 138),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,204,79,11,130,48,28,198,241,179,123,21,63,241,162,135,52,202,67,32,29,68,237,207,161,25,58,207,33,249,147,6,110,139,109,22,17,189,247,12,186,120,124,224,243,124,61,222,131,75,11,86,179,148,230,105,149,175,46,75,136,34,96,101,94,66,86,157,22,113,188,222,108,200,132,124,119,143,246,104,210,78,112,217,72,110,169,178,141,65,237,7,1,188,137,83,163,49,92,201,3,14,119,212,96,102,107,11,18,159,48,19,126,144,16,103,166,194,10,133,122,224,25,181,81,178,29,126,233,255,131,113,129,106,180,59,173,68,214,94,111,232,23,210,114,251,10,105,43,112,202,124,136,135,178,227,61,209,104,71,45,193,234,17,147,47,29,76,34,87,214,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateVwSysAdminUnitSavingEventSubProcess() {
			ProcessSchemaEventSubProcess schemaVwSysAdminUnitSaving = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a1561e7e-fec3-4e8a-949c-4074c9b529f3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ef7835d8-24c8-4f91-8e44-b3b2dc32abee"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("8d614e33-8093-46bf-987f-21093279b4e0"),
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				Name = @"VwSysAdminUnitSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(57, 740),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(300, 160),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaVwSysAdminUnitSaving;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c51669ff-65da-4bb7-98e0-1d1e3399a259"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a1561e7e-fec3-4e8a-949c-4074c9b529f3"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("8d614e33-8093-46bf-987f-21093279b4e0"),
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"VwSysAdminUnitSaving",
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				Name = @"StartMessage1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(56, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatecheckCanManageUsersScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("140b62d5-8948-4aa5-862d-2a3a4581a855"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a1561e7e-fec3-4e8a-949c-4074c9b529f3"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("8d614e33-8093-46bf-987f-21093279b4e0"),
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				Name = @"checkCanManageUsers",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(163, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,8,75,204,201,76,73,44,73,117,78,204,115,206,72,204,75,79,13,74,77,206,47,74,209,208,180,6,0,130,136,27,238,33,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetIsAdminUnitNotUserMethod());
			Methods.Add(CreateValidateCanChangeRecordMethod());
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
				UId = new Guid("95aee64a-275c-41cb-bd10-56c1b25c6635"),
				Name = "Terrasoft.Core.OperationLog",
				Alias = "",
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("097b2e1f-2827-4107-9958-89dc67979364"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b")
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
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ad63647f-80ed-400c-82b0-79cd39694ed1"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
		}

		protected override SchemaMethod CreateCheckCanManageLookupsMethod() {
			SchemaMethod method = base.CreateCheckCanManageLookupsMethod();
			method.IsOverride = true;
			return method;
		}

		protected virtual SchemaMethod CreateGetIsAdminUnitNotUserMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6d1a16f4-bb73-44a2-8124-5a4fc05cadc1"),
				Name = "GetIsAdminUnitNotUser",
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,46,45,42,74,205,43,9,169,44,72,245,76,81,176,85,112,205,43,201,44,169,212,115,79,5,11,165,56,231,231,148,230,230,133,37,230,148,166,218,184,151,102,166,216,105,40,5,87,22,59,166,228,102,230,133,230,101,66,181,41,105,90,243,114,21,165,150,148,22,229,41,104,160,26,168,104,171,16,90,156,90,4,225,105,42,168,169,97,81,16,28,28,128,164,198,26,0,16,34,203,51,150,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateValidateCanChangeRecordMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e66b35ed-8270-416f-b1b9-a3dfacaf1741"),
				Name = "ValidateCanChangeRecord",
				CreatedInSchemaUId = new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"),
				CreatedInPackageId = new Guid("6ff020f5-e34d-4da9-8c0d-3678e6f20dbf"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,78,45,114,206,207,203,75,77,46,201,204,207,211,115,113,10,78,77,46,45,202,44,169,116,205,75,207,204,75,213,115,206,72,77,206,118,78,204,115,173,0,138,151,164,250,23,164,22,37,130,84,106,40,1,5,125,19,243,18,211,83,29,83,114,51,243,50,139,75,32,18,74,154,214,188,92,69,169,37,165,69,121,10,37,69,165,169,214,0,208,129,106,2,98,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwSysAdminUnit_Base_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("83d997e8-8ef3-4b2f-9b1e-7c896589e109"));
		}

		#endregion

	}

	#endregion

}

