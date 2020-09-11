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

	#region Class: SysAdminUnit_Base_TerrasoftSchema

	/// <exclude/>
	public class SysAdminUnit_Base_TerrasoftSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public SysAdminUnit_Base_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysAdminUnit_Base_TerrasoftSchema(SysAdminUnit_Base_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysAdminUnit_Base_TerrasoftSchema(SysAdminUnit_Base_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIUSysAdminUnitNameIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = true
			};
			index.UId = new Guid("a09035f6-13ab-41d9-af1c-c095e5cf9ac1");
			index.Name = "IUSysAdminUnitName";
			index.CreatedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c");
			index.ModifiedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c");
			index.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			EntitySchemaIndexColumn nameIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("5c950219-374c-425c-8082-7e7de785ba20"),
				ColumnUId = new Guid("736c30a7-c0ec-4fa9-b034-2552b319b633"),
				CreatedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				ModifiedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(nameIndexColumn);
			EntitySchemaIndexColumn parentRoleIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("3c1b73d7-6adf-4567-88c8-8b95952dc03c"),
				ColumnUId = new Guid("fa4483b3-a2db-4651-a462-689be18351e7"),
				CreatedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				ModifiedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				CreatedInPackageId = new Guid("81adfa8e-1f43-43a3-9652-1b782e1a0cf1"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(parentRoleIdIndexColumn);
			return index;
		}

		private EntitySchemaIndex CreateISAULoggedInActiveIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("cf9e2407-d54a-4930-bdfc-ce9bc64ddfb4");
			index.Name = "ISAULoggedInActive";
			index.CreatedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c");
			index.ModifiedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c");
			index.CreatedInPackageId = new Guid("3c624d29-361c-47f2-ac8f-7824eb3cde6f");
			EntitySchemaIndexColumn loggedInIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("d9c799ef-023d-492c-879d-52d11308d0e8"),
				ColumnUId = new Guid("b0cc6131-e034-4562-9526-3f3a81f0a161"),
				CreatedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				ModifiedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				CreatedInPackageId = new Guid("3c624d29-361c-47f2-ac8f-7824eb3cde6f"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(loggedInIndexColumn);
			EntitySchemaIndexColumn activeIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("670a80ef-4ebe-4c5d-a5d1-e03f9edc4367"),
				ColumnUId = new Guid("48f37442-a2da-4407-9178-72073ba6b09f"),
				CreatedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				ModifiedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				CreatedInPackageId = new Guid("3c624d29-361c-47f2-ac8f-7824eb3cde6f"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(activeIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c");
			RealUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c");
			Name = "SysAdminUnit_Base_Terrasoft";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
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
			if (Columns.FindByUId(new Guid("9fe61fde-536b-4cef-9be7-d44a23ca6dfd")) == null) {
				Columns.Add(CreateSysAdminUnitTypeValueColumn());
			}
			if (Columns.FindByUId(new Guid("14f78dc8-e6ef-48a4-b5e1-0fe3360ee7b3")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("c7d4cc94-ccea-4c6d-a600-0be32fb246e9")) == null) {
				Columns.Add(CreateAccountColumn());
			}
			if (Columns.FindByUId(new Guid("e51e9d6c-a0ac-4821-8a9d-2eb60a7fb0af")) == null) {
				Columns.Add(CreateIsDirectoryEntryColumn());
			}
			if (Columns.FindByUId(new Guid("f55f68c3-6fa7-4f18-9fa7-cbd290313d6f")) == null) {
				Columns.Add(CreateTimeZoneIdColumn());
			}
			if (Columns.FindByUId(new Guid("ac9e4b9c-ee3c-49de-b850-640e6e5027a6")) == null) {
				Columns.Add(CreateUserPasswordColumn());
			}
			if (Columns.FindByUId(new Guid("48f37442-a2da-4407-9178-72073ba6b09f")) == null) {
				Columns.Add(CreateActiveColumn());
			}
			if (Columns.FindByUId(new Guid("45170632-a64e-4639-bdd4-a260e339e3a6")) == null) {
				Columns.Add(CreateSynchronizeWithLDAPColumn());
			}
			if (Columns.FindByUId(new Guid("6bc5084a-56d6-40a1-a796-db979322ee81")) == null) {
				Columns.Add(CreateLDAPEntryColumn());
			}
			if (Columns.FindByUId(new Guid("a059e7cc-2a06-4b03-96ac-473b705515ad")) == null) {
				Columns.Add(CreateLDAPEntryIdColumn());
			}
			if (Columns.FindByUId(new Guid("afee2179-455d-4836-b29f-b2f136918669")) == null) {
				Columns.Add(CreateLDAPEntryDNColumn());
			}
			if (Columns.FindByUId(new Guid("b0cc6131-e034-4562-9526-3f3a81f0a161")) == null) {
				Columns.Add(CreateLoggedInColumn());
			}
			if (Columns.FindByUId(new Guid("939bf64d-89a5-4613-9240-d0abc127dff5")) == null) {
				Columns.Add(CreateSysCultureColumn());
			}
			if (Columns.FindByUId(new Guid("1a8cff58-add0-4390-b00c-f6f0da971c52")) == null) {
				Columns.Add(CreateLoginAttemptCountColumn());
			}
			if (Columns.FindByUId(new Guid("d05ec764-2e70-4238-b972-b5194cd493e7")) == null) {
				Columns.Add(CreateSourceControlLoginColumn());
			}
			if (Columns.FindByUId(new Guid("2bcf9b58-9cd3-48ed-892e-c57dd8c6eede")) == null) {
				Columns.Add(CreateSourceControlPasswordColumn());
			}
			if (Columns.FindByUId(new Guid("4d03eb04-195b-43e5-9238-c9864b08b44b")) == null) {
				Columns.Add(CreatePasswordExpireDateColumn());
			}
			if (Columns.FindByUId(new Guid("b06d0431-a020-469f-b929-77cb3e6d6170")) == null) {
				Columns.Add(CreateHomePageColumn());
			}
			if (Columns.FindByUId(new Guid("61e854be-0394-4c7c-b703-cd1ded0aab45")) == null) {
				Columns.Add(CreateConnectionTypeColumn());
			}
			if (Columns.FindByUId(new Guid("b9e2d8e5-55b7-4b81-adb3-19796d751140")) == null) {
				Columns.Add(CreateUnblockTimeColumn());
			}
			if (Columns.FindByUId(new Guid("7e132411-1beb-453b-9ed4-30141fcc0894")) == null) {
				Columns.Add(CreateForceChangePasswordColumn());
			}
			if (Columns.FindByUId(new Guid("d95527e7-b728-4142-8559-e9af9ee8d22d")) == null) {
				Columns.Add(CreateDateTimeFormatColumn());
			}
			if (Columns.FindByUId(new Guid("c619e945-1ea9-40ab-af0c-7e6f71f92ce7")) == null) {
				Columns.Add(CreateSessionTimeoutColumn());
			}
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.IsLocalizable = false;
			column.ModifiedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.IsLocalizable = false;
			column.ModifiedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected virtual EntitySchemaColumn CreateSysAdminUnitTypeValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("9fe61fde-536b-4cef-9be7-d44a23ca6dfd"),
				Name = @"SysAdminUnitTypeValue",
				CreatedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				ModifiedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateParentRoleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("fa4483b3-a2db-4651-a462-689be18351e7"),
				Name = @"ParentRole",
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				ModifiedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("14f78dc8-e6ef-48a4-b5e1-0fe3360ee7b3"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				ModifiedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c7d4cc94-ccea-4c6d-a600-0be32fb246e9"),
				Name = @"Account",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				ModifiedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateIsDirectoryEntryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("e51e9d6c-a0ac-4821-8a9d-2eb60a7fb0af"),
				Name = @"IsDirectoryEntry",
				CreatedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				ModifiedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateTimeZoneIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Text")) {
				UId = new Guid("f55f68c3-6fa7-4f18-9fa7-cbd290313d6f"),
				Name = @"TimeZoneId",
				CreatedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				ModifiedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateUserPasswordColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("HashText")) {
				UId = new Guid("ac9e4b9c-ee3c-49de-b850-640e6e5027a6"),
				Name = @"UserPassword",
				CreatedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				ModifiedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateActiveColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("48f37442-a2da-4407-9178-72073ba6b09f"),
				Name = @"Active",
				CreatedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				ModifiedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSynchronizeWithLDAPColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("45170632-a64e-4639-bdd4-a260e339e3a6"),
				Name = @"SynchronizeWithLDAP",
				CreatedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				ModifiedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateLDAPEntryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("6bc5084a-56d6-40a1-a796-db979322ee81"),
				Name = @"LDAPEntry",
				CreatedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				ModifiedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateLDAPEntryIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("a059e7cc-2a06-4b03-96ac-473b705515ad"),
				Name = @"LDAPEntryId",
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				ModifiedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateLDAPEntryDNColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("afee2179-455d-4836-b29f-b2f136918669"),
				Name = @"LDAPEntryDN",
				CreatedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				ModifiedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateLoggedInColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("b0cc6131-e034-4562-9526-3f3a81f0a161"),
				Name = @"LoggedIn",
				CreatedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				ModifiedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSysCultureColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("939bf64d-89a5-4613-9240-d0abc127dff5"),
				Name = @"SysCulture",
				ReferenceSchemaUId = new Guid("ffc193e1-04bc-472b-bdc0-3333d1df84e4"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				ModifiedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateLoginAttemptCountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("1a8cff58-add0-4390-b00c-f6f0da971c52"),
				Name = @"LoginAttemptCount",
				CreatedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				ModifiedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSourceControlLoginColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("d05ec764-2e70-4238-b972-b5194cd493e7"),
				Name = @"SourceControlLogin",
				CreatedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				ModifiedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSourceControlPasswordColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("SecureText")) {
				UId = new Guid("2bcf9b58-9cd3-48ed-892e-c57dd8c6eede"),
				Name = @"SourceControlPassword",
				CreatedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				ModifiedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreatePasswordExpireDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("4d03eb04-195b-43e5-9238-c9864b08b44b"),
				Name = @"PasswordExpireDate",
				CreatedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				ModifiedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376")
			};
		}

		protected virtual EntitySchemaColumn CreateHomePageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b06d0431-a020-469f-b929-77cb3e6d6170"),
				Name = @"HomePage",
				ReferenceSchemaUId = new Guid("2b2ed767-0b4b-4a7b-9de2-d48e14a2c0c5"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				ModifiedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90")
			};
		}

		protected virtual EntitySchemaColumn CreateConnectionTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("61e854be-0394-4c7c-b703-cd1ded0aab45"),
				Name = @"ConnectionType",
				CreatedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				ModifiedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866")
			};
		}

		protected virtual EntitySchemaColumn CreateUnblockTimeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("b9e2d8e5-55b7-4b81-adb3-19796d751140"),
				Name = @"UnblockTime",
				CreatedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				ModifiedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7")
			};
		}

		protected virtual EntitySchemaColumn CreateForceChangePasswordColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("7e132411-1beb-453b-9ed4-30141fcc0894"),
				Name = @"ForceChangePassword",
				CreatedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				ModifiedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				CreatedInPackageId = new Guid("0e850392-6b68-4c42-8cac-7764bc62a6bb")
			};
		}

		protected virtual EntitySchemaColumn CreateDateTimeFormatColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d95527e7-b728-4142-8559-e9af9ee8d22d"),
				Name = @"DateTimeFormat",
				ReferenceSchemaUId = new Guid("2f96cb61-7e14-41e5-980a-bcb856edab51"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				ModifiedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				CreatedInPackageId = new Guid("387d653a-7f45-49ea-a9e5-1ab1b4fdb1de")
			};
		}

		protected virtual EntitySchemaColumn CreateSessionTimeoutColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("c619e945-1ea9-40ab-af0c-7e6f71f92ce7"),
				Name = @"SessionTimeout",
				CreatedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				ModifiedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIUSysAdminUnitNameIndex());
			Indexes.Add(CreateISAULoggedInActiveIndex());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysAdminUnit_Base_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysAdminUnit_Base_TerrasoftEventsProcessSchema() {
			var schema = new SysAdminUnit_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysAdminUnit_Base_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysAdminUnit_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysAdminUnit_Base_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysAdminUnit_Base_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"));
		}

		#endregion

	}

	#endregion

	#region Class: SysAdminUnit_Base_Terrasoft

	/// <summary>
	/// System administration object.
	/// </summary>
	public class SysAdminUnit_Base_Terrasoft : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public SysAdminUnit_Base_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysAdminUnit_Base_Terrasoft";
		}

		public SysAdminUnit_Base_Terrasoft(SysAdminUnit_Base_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Type.
		/// </summary>
		public int SysAdminUnitTypeValue {
			get {
				return GetTypedColumnValue<int>("SysAdminUnitTypeValue");
			}
			set {
				SetColumnValue("SysAdminUnitTypeValue", value);
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

		private SysAdminUnit _parentRole;
		/// <summary>
		/// Inherited from.
		/// </summary>
		public SysAdminUnit ParentRole {
			get {
				return _parentRole ??
					(_parentRole = LookupColumnEntities.GetEntity("ParentRole") as SysAdminUnit);
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

		/// <summary>
		/// Time zone.
		/// </summary>
		public string TimeZoneId {
			get {
				return GetTypedColumnValue<string>("TimeZoneId");
			}
			set {
				SetColumnValue("TimeZoneId", value);
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
		/// LDAP element unique name.
		/// </summary>
		public string LDAPEntryDN {
			get {
				return GetTypedColumnValue<string>("LDAPEntryDN");
			}
			set {
				SetColumnValue("LDAPEntryDN", value);
			}
		}

		/// <summary>
		/// Logged in.
		/// </summary>
		public bool LoggedIn {
			get {
				return GetTypedColumnValue<bool>("LoggedIn");
			}
			set {
				SetColumnValue("LoggedIn", value);
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
		/// Number of logon attempts.
		/// </summary>
		public int LoginAttemptCount {
			get {
				return GetTypedColumnValue<int>("LoginAttemptCount");
			}
			set {
				SetColumnValue("LoginAttemptCount", value);
			}
		}

		/// <summary>
		/// Repository login.
		/// </summary>
		public string SourceControlLogin {
			get {
				return GetTypedColumnValue<string>("SourceControlLogin");
			}
			set {
				SetColumnValue("SourceControlLogin", value);
			}
		}

		/// <summary>
		/// Repository password.
		/// </summary>
		public string SourceControlPassword {
			get {
				return GetTypedColumnValue<string>("SourceControlPassword");
			}
			set {
				SetColumnValue("SourceControlPassword", value);
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

		/// <summary>
		/// Unlocking time.
		/// </summary>
		public DateTime UnblockTime {
			get {
				return GetTypedColumnValue<DateTime>("UnblockTime");
			}
			set {
				SetColumnValue("UnblockTime", value);
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
		/// Display date and time format.
		/// </summary>
		public SysLanguage DateTimeFormat {
			get {
				return _dateTimeFormat ??
					(_dateTimeFormat = LookupColumnEntities.GetEntity("DateTimeFormat") as SysLanguage);
			}
		}

		/// <summary>
		/// Session timeout (minutes).
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
			var process = new SysAdminUnit_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysAdminUnit_Base_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("SysAdminUnit_Base_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("SysAdminUnit_Base_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("SysAdminUnit_Base_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("SysAdminUnit_Base_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("SysAdminUnit_Base_TerrasoftSaving", e);
			Updated += (s, e) => ThrowEvent("SysAdminUnit_Base_TerrasoftUpdated", e);
			Validating += (s, e) => ThrowEvent("SysAdminUnit_Base_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysAdminUnit_Base_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysAdminUnit_BaseEventsProcess

	/// <exclude/>
	public partial class SysAdminUnit_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_BaseEventsProcess<TEntity> where TEntity : SysAdminUnit_Base_Terrasoft
	{

		public SysAdminUnit_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysAdminUnit_BaseEventsProcess";
			SchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			_sSPUserTypeId = () => {{ return new Guid("F4044C41-DF2B-E111-851E-00155D04C01D"); }};
			_userTypeId = () => {{ return new Guid("472E97C7-6BD7-DF11-9B2A-001D60E938C6"); }};
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private Func<Guid> _sSPUserTypeId;
		public virtual Guid SSPUserTypeId {
			get {
				return (_sSPUserTypeId ?? (_sSPUserTypeId = () => Guid.Empty)).Invoke();
			}
			set {
				_sSPUserTypeId = () => { return value; };
			}
		}

		private Func<Guid> _userTypeId;
		public virtual Guid UserTypeId {
			get {
				return (_userTypeId ?? (_userTypeId = () => Guid.Empty)).Invoke();
			}
			set {
				_userTypeId = () => { return value; };
			}
		}

		private ProcessFlowElement _eventSubProcess932740;
		public ProcessFlowElement EventSubProcess932740 {
			get {
				return _eventSubProcess932740 ?? (_eventSubProcess932740 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess932740",
					SchemaElementUId = new Guid("fce84846-b48b-4e67-8252-fe857f8ca425"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _sysAdminUnitSaved;
		public ProcessFlowElement SysAdminUnitSaved {
			get {
				return _sysAdminUnitSaved ?? (_sysAdminUnitSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SysAdminUnitSaved",
					SchemaElementUId = new Guid("20987e1c-f233-4bf9-b989-c2861e102451"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask125763056;
		public ProcessScriptTask ScriptTask125763056 {
			get {
				return _scriptTask125763056 ?? (_scriptTask125763056 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask125763056",
					SchemaElementUId = new Guid("54220b82-3313-4f1d-a03a-0828b66a4111"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask125763056Execute,
				});
			}
		}

		private ProcessFlowElement _sysAdminUnitDeleted;
		public ProcessFlowElement SysAdminUnitDeleted {
			get {
				return _sysAdminUnitDeleted ?? (_sysAdminUnitDeleted = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SysAdminUnitDeleted",
					SchemaElementUId = new Guid("a67398c4-f8ed-4600-a5e3-f39c973e003e"),
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
					SchemaElementUId = new Guid("a2e358c5-d873-40bb-8e2b-bbddbd63ce62"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = LogDelete_ScriptTaskExecute,
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
					SchemaElementUId = new Guid("37a00e18-c28c-4539-9974-010bb7ec07cc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = RemovePersonalUserSessionTimeoutExecute,
				});
			}
		}

		private ProcessFlowElement _sysAdminUnitInserted;
		public ProcessFlowElement SysAdminUnitInserted {
			get {
				return _sysAdminUnitInserted ?? (_sysAdminUnitInserted = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SysAdminUnitInserted",
					SchemaElementUId = new Guid("610fd78f-317c-4910-807e-b4ed17f2fc74"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _insertPersonalSessionTimeout;
		public ProcessScriptTask InsertPersonalSessionTimeout {
			get {
				return _insertPersonalSessionTimeout ?? (_insertPersonalSessionTimeout = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InsertPersonalSessionTimeout",
					SchemaElementUId = new Guid("52b031c6-fe86-4e33-bc1b-9a1ea581ffc5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InsertPersonalSessionTimeoutExecute,
				});
			}
		}

		private ProcessFlowElement _sysAdminUnitUpdated;
		public ProcessFlowElement SysAdminUnitUpdated {
			get {
				return _sysAdminUnitUpdated ?? (_sysAdminUnitUpdated = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SysAdminUnitUpdated",
					SchemaElementUId = new Guid("c658b72a-3d51-4237-92d9-912437696368"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _updatePersonalSessionTimeout;
		public ProcessScriptTask UpdatePersonalSessionTimeout {
			get {
				return _updatePersonalSessionTimeout ?? (_updatePersonalSessionTimeout = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "UpdatePersonalSessionTimeout",
					SchemaElementUId = new Guid("516b32ab-ef63-46e0-ad20-f2f4a2792a89"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = UpdatePersonalSessionTimeoutExecute,
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
					SchemaElementUId = new Guid("f5e8f47f-14d8-4c2c-8be8-a6107e0d2420"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _validateCanChangeRecord;
		public ProcessScriptTask ValidateCanChangeRecord {
			get {
				return _validateCanChangeRecord ?? (_validateCanChangeRecord = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ValidateCanChangeRecord",
					SchemaElementUId = new Guid("8430682a-7728-492f-a57f-3e855a70de24"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ValidateCanChangeRecordExecute,
				});
			}
		}

		private ProcessFlowElement _sysAdminUnitDeleting;
		public ProcessFlowElement SysAdminUnitDeleting {
			get {
				return _sysAdminUnitDeleting ?? (_sysAdminUnitDeleting = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SysAdminUnitDeleting",
					SchemaElementUId = new Guid("949da708-5e6d-4553-9d7c-7ffea318e55b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _sysAdminUnitSaving;
		public ProcessFlowElement SysAdminUnitSaving {
			get {
				return _sysAdminUnitSaving ?? (_sysAdminUnitSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SysAdminUnitSaving",
					SchemaElementUId = new Guid("f6b52288-d021-4042-ba1d-9fdf2782b2c8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _sysAdminUnitInserting;
		public ProcessFlowElement SysAdminUnitInserting {
			get {
				return _sysAdminUnitInserting ?? (_sysAdminUnitInserting = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SysAdminUnitInserting",
					SchemaElementUId = new Guid("34d62e7b-9c4c-4cac-b0c2-4c5a3dd6325e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess932740.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess932740 };
			FlowElements[SysAdminUnitSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { SysAdminUnitSaved };
			FlowElements[ScriptTask125763056.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask125763056 };
			FlowElements[SysAdminUnitDeleted.SchemaElementUId] = new Collection<ProcessFlowElement> { SysAdminUnitDeleted };
			FlowElements[LogDelete_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { LogDelete_ScriptTask };
			FlowElements[RemovePersonalUserSessionTimeout.SchemaElementUId] = new Collection<ProcessFlowElement> { RemovePersonalUserSessionTimeout };
			FlowElements[SysAdminUnitInserted.SchemaElementUId] = new Collection<ProcessFlowElement> { SysAdminUnitInserted };
			FlowElements[InsertPersonalSessionTimeout.SchemaElementUId] = new Collection<ProcessFlowElement> { InsertPersonalSessionTimeout };
			FlowElements[SysAdminUnitUpdated.SchemaElementUId] = new Collection<ProcessFlowElement> { SysAdminUnitUpdated };
			FlowElements[UpdatePersonalSessionTimeout.SchemaElementUId] = new Collection<ProcessFlowElement> { UpdatePersonalSessionTimeout };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[ValidateCanChangeRecord.SchemaElementUId] = new Collection<ProcessFlowElement> { ValidateCanChangeRecord };
			FlowElements[SysAdminUnitDeleting.SchemaElementUId] = new Collection<ProcessFlowElement> { SysAdminUnitDeleting };
			FlowElements[SysAdminUnitSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { SysAdminUnitSaving };
			FlowElements[SysAdminUnitInserting.SchemaElementUId] = new Collection<ProcessFlowElement> { SysAdminUnitInserting };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess932740":
						break;
					case "SysAdminUnitSaved":
						e.Context.QueueTasks.Enqueue("ScriptTask125763056");
						break;
					case "ScriptTask125763056":
						break;
					case "SysAdminUnitDeleted":
						e.Context.QueueTasks.Enqueue("LogDelete_ScriptTask");
						break;
					case "LogDelete_ScriptTask":
						e.Context.QueueTasks.Enqueue("RemovePersonalUserSessionTimeout");
						break;
					case "RemovePersonalUserSessionTimeout":
						e.Context.QueueTasks.Enqueue("ScriptTask125763056");
						break;
					case "SysAdminUnitInserted":
						e.Context.QueueTasks.Enqueue("InsertPersonalSessionTimeout");
						break;
					case "InsertPersonalSessionTimeout":
						break;
					case "SysAdminUnitUpdated":
						e.Context.QueueTasks.Enqueue("UpdatePersonalSessionTimeout");
						break;
					case "UpdatePersonalSessionTimeout":
						break;
					case "EventSubProcess1":
						break;
					case "ValidateCanChangeRecord":
						break;
					case "SysAdminUnitDeleting":
						e.Context.QueueTasks.Enqueue("ValidateCanChangeRecord");
						break;
					case "SysAdminUnitSaving":
						e.Context.QueueTasks.Enqueue("ValidateCanChangeRecord");
						break;
					case "SysAdminUnitInserting":
						e.Context.QueueTasks.Enqueue("ValidateCanChangeRecord");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("SysAdminUnitSaved");
			ActivatedEventElements.Add("SysAdminUnitDeleted");
			ActivatedEventElements.Add("SysAdminUnitInserted");
			ActivatedEventElements.Add("SysAdminUnitUpdated");
			ActivatedEventElements.Add("SysAdminUnitDeleting");
			ActivatedEventElements.Add("SysAdminUnitSaving");
			ActivatedEventElements.Add("SysAdminUnitInserting");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess932740":
					context.QueueTasks.Dequeue();
					break;
				case "SysAdminUnitSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysAdminUnitSaved";
					result = SysAdminUnitSaved.Execute(context);
					break;
				case "ScriptTask125763056":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask125763056";
					result = ScriptTask125763056.Execute(context, ScriptTask125763056Execute);
					break;
				case "SysAdminUnitDeleted":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysAdminUnitDeleted";
					result = SysAdminUnitDeleted.Execute(context);
					break;
				case "LogDelete_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "LogDelete_ScriptTask";
					result = LogDelete_ScriptTask.Execute(context, LogDelete_ScriptTaskExecute);
					break;
				case "RemovePersonalUserSessionTimeout":
					context.QueueTasks.Dequeue();
					context.SenderName = "RemovePersonalUserSessionTimeout";
					result = RemovePersonalUserSessionTimeout.Execute(context, RemovePersonalUserSessionTimeoutExecute);
					break;
				case "SysAdminUnitInserted":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysAdminUnitInserted";
					result = SysAdminUnitInserted.Execute(context);
					break;
				case "InsertPersonalSessionTimeout":
					context.QueueTasks.Dequeue();
					context.SenderName = "InsertPersonalSessionTimeout";
					result = InsertPersonalSessionTimeout.Execute(context, InsertPersonalSessionTimeoutExecute);
					break;
				case "SysAdminUnitUpdated":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysAdminUnitUpdated";
					result = SysAdminUnitUpdated.Execute(context);
					break;
				case "UpdatePersonalSessionTimeout":
					context.QueueTasks.Dequeue();
					context.SenderName = "UpdatePersonalSessionTimeout";
					result = UpdatePersonalSessionTimeout.Execute(context, UpdatePersonalSessionTimeoutExecute);
					break;
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "ValidateCanChangeRecord":
					context.QueueTasks.Dequeue();
					context.SenderName = "ValidateCanChangeRecord";
					result = ValidateCanChangeRecord.Execute(context, ValidateCanChangeRecordExecute);
					break;
				case "SysAdminUnitDeleting":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysAdminUnitDeleting";
					result = SysAdminUnitDeleting.Execute(context);
					break;
				case "SysAdminUnitSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysAdminUnitSaving";
					result = SysAdminUnitSaving.Execute(context);
					break;
				case "SysAdminUnitInserting":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysAdminUnitInserting";
					result = SysAdminUnitInserting.Execute(context);
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

		public virtual bool ScriptTask125763056Execute(ProcessExecutingContext context) {
			Terrasoft.Web.Http.Abstractions.HttpContext httpContext = Terrasoft.Web.Http.Abstractions.HttpContext.Current;
			if (httpContext == null) {
				return true;
			}
			var contactId = Entity.ContactId;
			if (contactId == Guid.Empty) {
				var key = string.Format("SysAdminUnit_{0}", contactId.ToString());
				RemoveItemFromCache(key);
			}
			return true;
		}

		public virtual bool LogDelete_ScriptTaskExecute(ProcessExecutingContext context) {
			OperationLogger.Instance.LogAdminUnitDelete(UserConnection, Entity.Name);
			return true;
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

		public virtual bool InsertPersonalSessionTimeoutExecute(ProcessExecutingContext context) {
			#if !NETSTANDARD2_0 // TODO CRM-44388
			if (!GetIsAdminUnitNotUser()) {
				SessionHelper sessionHelper = new SessionHelper();
				sessionHelper.UpdatePersonalUserSessionTimeoutInCache(Entity.Name, Entity.SessionTimeout);
			}
			#endif
			return true;
		}

		public virtual bool UpdatePersonalSessionTimeoutExecute(ProcessExecutingContext context) {
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

		public virtual bool ValidateCanChangeRecordExecute(ProcessExecutingContext context) {
			UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageAdministration");
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "SysAdminUnit_Base_TerrasoftSaved":
							if (ActivatedEventElements.Contains("SysAdminUnitSaved")) {
							context.QueueTasks.Enqueue("SysAdminUnitSaved");
						}
						break;
					case "SysAdminUnit_Base_TerrasoftDeleted":
							if (ActivatedEventElements.Contains("SysAdminUnitDeleted")) {
							context.QueueTasks.Enqueue("SysAdminUnitDeleted");
						}
						break;
					case "SysAdminUnit_Base_TerrasoftInserted":
							if (ActivatedEventElements.Contains("SysAdminUnitInserted")) {
							context.QueueTasks.Enqueue("SysAdminUnitInserted");
						}
						break;
					case "SysAdminUnit_Base_TerrasoftUpdated":
							if (ActivatedEventElements.Contains("SysAdminUnitUpdated")) {
							context.QueueTasks.Enqueue("SysAdminUnitUpdated");
						}
						break;
					case "SysAdminUnit_Base_TerrasoftDeleting":
							if (ActivatedEventElements.Contains("SysAdminUnitDeleting")) {
							context.QueueTasks.Enqueue("SysAdminUnitDeleting");
						}
						break;
					case "SysAdminUnit_Base_TerrasoftSaving":
							if (ActivatedEventElements.Contains("SysAdminUnitSaving")) {
							context.QueueTasks.Enqueue("SysAdminUnitSaving");
						}
						break;
					case "SysAdminUnit_Base_TerrasoftInserting":
							if (ActivatedEventElements.Contains("SysAdminUnitInserting")) {
							context.QueueTasks.Enqueue("SysAdminUnitInserting");
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

	#region Class: SysAdminUnit_BaseEventsProcess

	/// <exclude/>
	public class SysAdminUnit_BaseEventsProcess : SysAdminUnit_BaseEventsProcess<SysAdminUnit_Base_Terrasoft>
	{

		public SysAdminUnit_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysAdminUnit_BaseEventsProcess

	public partial class SysAdminUnit_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void RemoveItemFromCache(string key) {
			ActivityUtils.SetOrRemoveItemInActivityCache(UserConnection, key);
		}

		public override void CheckCanManageLookups() {
		}

		public virtual bool GetIsAdminUnitNotUser() {
			return (Entity.SysAdminUnitTypeValue != 4) && (Entity.SysAdminUnitTypeValue != 5);
		}

		#endregion

	}

	#endregion

	#region Class: SysAdminUnit_Base_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class SysAdminUnit_Base_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseLookupEventsProcessSchema
	{

		#region Constructors: Public

		public SysAdminUnit_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysAdminUnit_Base_TerrasoftEventsProcessSchema(SysAdminUnit_Base_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysAdminUnit_BaseEventsProcess";
			UId = new Guid("640d3991-ca95-464a-b7b7-58941417973c");
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

		protected virtual ProcessSchemaParameter CreateSSPUserTypeIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d84e0501-d686-400d-a9d4-8e65e512ae69"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				Name = @"SSPUserTypeId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"new Guid(""F4044C41-DF2B-E111-851E-00155D04C01D"")",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateUserTypeIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("1240d81e-2880-4270-80b8-10e322c4fc78"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				Name = @"UserTypeId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"new Guid(""472E97C7-6BD7-DF11-9B2A-001D60E938C6"")",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateSSPUserTypeIdParameter());
			Parameters.Add(CreateUserTypeIdParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet183057 = CreateLaneSet183057LaneSet();
			LaneSets.Add(schemaLaneSet183057);
			ProcessSchemaLane schemaLane173905 = CreateLane173905Lane();
			schemaLaneSet183057.Lanes.Add(schemaLane173905);
			ProcessSchemaEventSubProcess eventsubprocess932740 = CreateEventSubProcess932740EventSubProcess();
			FlowElements.Add(eventsubprocess932740);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaStartMessageEvent sysadminunitsaved = CreateSysAdminUnitSavedStartMessageEvent();
			eventsubprocess932740.FlowElements.Add(sysadminunitsaved);
			ProcessSchemaScriptTask scripttask125763056 = CreateScriptTask125763056ScriptTask();
			eventsubprocess932740.FlowElements.Add(scripttask125763056);
			ProcessSchemaStartMessageEvent sysadminunitdeleted = CreateSysAdminUnitDeletedStartMessageEvent();
			eventsubprocess932740.FlowElements.Add(sysadminunitdeleted);
			ProcessSchemaScriptTask logdelete_scripttask = CreateLogDelete_ScriptTaskScriptTask();
			eventsubprocess932740.FlowElements.Add(logdelete_scripttask);
			ProcessSchemaScriptTask removepersonalusersessiontimeout = CreateRemovePersonalUserSessionTimeoutScriptTask();
			eventsubprocess932740.FlowElements.Add(removepersonalusersessiontimeout);
			ProcessSchemaStartMessageEvent sysadminunitinserted = CreateSysAdminUnitInsertedStartMessageEvent();
			eventsubprocess932740.FlowElements.Add(sysadminunitinserted);
			ProcessSchemaScriptTask insertpersonalsessiontimeout = CreateInsertPersonalSessionTimeoutScriptTask();
			eventsubprocess932740.FlowElements.Add(insertpersonalsessiontimeout);
			ProcessSchemaStartMessageEvent sysadminunitupdated = CreateSysAdminUnitUpdatedStartMessageEvent();
			eventsubprocess932740.FlowElements.Add(sysadminunitupdated);
			ProcessSchemaScriptTask updatepersonalsessiontimeout = CreateUpdatePersonalSessionTimeoutScriptTask();
			eventsubprocess932740.FlowElements.Add(updatepersonalsessiontimeout);
			ProcessSchemaScriptTask validatecanchangerecord = CreateValidateCanChangeRecordScriptTask();
			eventsubprocess1.FlowElements.Add(validatecanchangerecord);
			ProcessSchemaStartMessageEvent sysadminunitdeleting = CreateSysAdminUnitDeletingStartMessageEvent();
			eventsubprocess1.FlowElements.Add(sysadminunitdeleting);
			ProcessSchemaStartMessageEvent sysadminunitsaving = CreateSysAdminUnitSavingStartMessageEvent();
			eventsubprocess1.FlowElements.Add(sysadminunitsaving);
			ProcessSchemaStartMessageEvent sysadminunitinserting = CreateSysAdminUnitInsertingStartMessageEvent();
			eventsubprocess1.FlowElements.Add(sysadminunitinserting);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8_aaced13f26df49f9bcbd0b82bdafc9e9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9_0e908b5d58504542a45c357cf626495aSequenceFlow());
			FlowElements.Add(CreateSequenceFlow10_380ccb49125542b3a63abe116d416594SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("4f7e8c30-15b6-42ae-8753-30f78d0bacba"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81"),
				CreatedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				CurveCenterPosition = new Point(217, 106),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("20987e1c-f233-4bf9-b989-c2861e102451"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("54220b82-3313-4f1d-a03a-0828b66a4111"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(244, 68));
			schemaFlow.PolylinePointPositions.Add(new Point(244, 109));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("b2c6f97d-2158-4abe-8054-396d792baf4c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81"),
				CreatedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				CurveCenterPosition = new Point(217, 176),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a67398c4-f8ed-4600-a5e3-f39c973e003e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a2e358c5-d873-40bb-8e2b-bbddbd63ce62"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("7c510d9c-3f62-4c92-91fe-857ea2fe6882"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("6ff020f5-e34d-4da9-8c0d-3678e6f20dbf"),
				CreatedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				CurveCenterPosition = new Point(194, 378),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("34d62e7b-9c4c-4cac-b0c2-4c5a3dd6325e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8430682a-7728-492f-a57f-3e855a70de24"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("482106f1-6a4f-4c5c-a75e-3e9c35e72b0d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("6ff020f5-e34d-4da9-8c0d-3678e6f20dbf"),
				CreatedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				CurveCenterPosition = new Point(197, 346),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f6b52288-d021-4042-ba1d-9fdf2782b2c8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8430682a-7728-492f-a57f-3e855a70de24"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(211, 547));
			schemaFlow.PolylinePointPositions.Add(new Point(211, 604));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("b8f6b351-f7cd-4f61-a604-95af23070475"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("6ff020f5-e34d-4da9-8c0d-3678e6f20dbf"),
				CreatedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				CurveCenterPosition = new Point(194, 414),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("949da708-5e6d-4553-9d7c-7ffea318e55b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8430682a-7728-492f-a57f-3e855a70de24"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(211, 674));
			schemaFlow.PolylinePointPositions.Add(new Point(211, 604));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("e4ab40f1-7e69-45de-af94-0074a9259856"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a2e358c5-d873-40bb-8e2b-bbddbd63ce62"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("37a00e18-c28c-4539-9974-010bb7ec07cc"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8_aaced13f26df49f9bcbd0b82bdafc9e9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8_aaced13f26df49f9bcbd0b82bdafc9e9",
				UId = new Guid("aaced13f-26df-49f9-bcbd-0b82bdafc9e9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("37a00e18-c28c-4539-9974-010bb7ec07cc"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("54220b82-3313-4f1d-a03a-0828b66a4111"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(351, 207));
			schemaFlow.PolylinePointPositions.Add(new Point(351, 109));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9_0e908b5d58504542a45c357cf626495aSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9_0e908b5d58504542a45c357cf626495a",
				UId = new Guid("0e908b5d-5850-4542-a45c-357cf626495a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("610fd78f-317c-4910-807e-b4ed17f2fc74"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("52b031c6-fe86-4e33-bc1b-9a1ea581ffc5"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10_380ccb49125542b3a63abe116d416594SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10_380ccb49125542b3a63abe116d416594",
				UId = new Guid("380ccb49-1255-42b3-a63a-be116d416594"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c658b72a-3d51-4237-92d9-912437696368"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("516b32ab-ef63-46e0-ad20-f2f4a2792a89"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet183057LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet183057 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("982517b4-f3f4-4cf5-ab1d-9524348dfb42"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81"),
				CreatedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				Name = @"LaneSet183057",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(560, 270),
				UseBackgroundMode = false
			};
			return schemaLaneSet183057;
		}

		protected virtual ProcessSchemaLane CreateLane173905Lane() {
			ProcessSchemaLane schemaLane173905 = new ProcessSchemaLane(this) {
				UId = new Guid("37fbf684-3407-456f-a966-354619f0ee64"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("982517b4-f3f4-4cf5-ab1d-9524348dfb42"),
				CreatedInOwnerSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81"),
				CreatedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				Name = @"Lane173905",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(531, 270),
				UseBackgroundMode = false
			};
			return schemaLane173905;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess932740EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess932740 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("fce84846-b48b-4e67-8252-fe857f8ca425"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("37fbf684-3407-456f-a966-354619f0ee64"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81"),
				CreatedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				Name = @"EventSubProcess932740",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 20),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(469, 482),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess932740;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSysAdminUnitSavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("20987e1c-f233-4bf9-b989-c2861e102451"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fce84846-b48b-4e67-8252-fe857f8ca425"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81"),
				CreatedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysAdminUnitSaved",
				ModifiedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				Name = @"SysAdminUnitSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(42, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask125763056ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("54220b82-3313-4f1d-a03a-0828b66a4111"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fce84846-b48b-4e67-8252-fe857f8ca425"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81"),
				CreatedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				Name = @"ScriptTask125763056",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(380, 62),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,142,203,10,194,48,16,69,215,22,250,15,193,85,11,18,220,75,23,165,248,218,106,197,165,164,237,168,65,51,145,233,68,44,226,191,27,91,197,186,115,55,12,231,158,123,115,32,82,181,221,179,220,66,33,23,204,23,153,22,53,147,42,89,91,172,219,79,102,145,225,198,226,216,187,19,145,255,159,148,153,35,2,228,73,24,232,189,136,126,60,137,64,119,62,199,226,30,6,3,2,118,132,130,201,129,71,31,97,112,85,36,74,79,122,231,178,242,157,83,100,205,141,204,62,175,183,176,135,36,98,238,116,37,167,230,194,77,39,125,57,78,208,248,180,31,167,241,32,103,150,140,226,104,184,110,234,180,50,26,55,168,121,119,31,63,134,163,111,151,204,237,186,165,163,56,246,37,131,21,24,123,133,37,131,153,145,53,153,42,143,16,121,105,220,205,236,239,126,2,119,183,216,21,81,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSysAdminUnitDeletedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a67398c4-f8ed-4600-a5e3-f39c973e003e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fce84846-b48b-4e67-8252-fe857f8ca425"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81"),
				CreatedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysAdminUnitDeleted",
				ModifiedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				Name = @"SysAdminUnitDeleted",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 174),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateLogDelete_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a2e358c5-d873-40bb-8e2b-bbddbd63ce62"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fce84846-b48b-4e67-8252-fe857f8ca425"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				Name = @"LogDelete_ScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(124, 160),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,47,72,45,74,44,201,204,207,243,201,79,79,79,45,210,243,204,43,46,73,204,75,78,213,3,242,29,83,114,51,243,66,243,50,75,92,82,115,82,75,82,53,66,139,83,139,156,243,243,242,82,147,65,26,116,20,92,243,74,50,75,42,245,252,18,115,83,53,173,121,185,138,82,75,74,139,242,20,74,138,74,83,173,1,64,28,150,214,87,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateRemovePersonalUserSessionTimeoutScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("37a00e18-c28c-4539-9974-010bb7ec07cc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fce84846-b48b-4e67-8252-fe857f8ca425"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				Name = @"RemovePersonalUserSessionTimeout",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(213, 160),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,204,79,11,130,48,28,198,241,179,123,21,63,241,162,135,52,202,67,32,29,68,237,207,161,25,58,207,33,249,147,6,110,139,109,22,17,189,247,12,186,120,124,224,243,124,61,222,131,75,11,86,179,148,230,105,149,175,46,75,136,34,96,101,94,66,86,157,22,113,188,222,108,200,132,124,119,143,246,104,210,78,112,217,72,110,169,178,141,65,237,7,1,188,137,83,163,49,92,201,3,14,119,212,96,102,107,11,18,159,48,19,126,144,16,103,166,194,10,133,122,224,25,181,81,178,29,126,233,255,131,113,129,106,180,59,173,68,214,94,111,232,23,210,114,251,10,105,43,112,202,124,136,135,178,227,61,209,104,71,45,193,234,17,147,47,29,76,34,87,214,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSysAdminUnitInsertedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("610fd78f-317c-4910-807e-b4ed17f2fc74"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fce84846-b48b-4e67-8252-fe857f8ca425"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysAdminUnitInserted",
				ModifiedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				Name = @"SysAdminUnitInserted",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(42, 293),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInsertPersonalSessionTimeoutScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("52b031c6-fe86-4e33-bc1b-9a1ea581ffc5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fce84846-b48b-4e67-8252-fe857f8ca425"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				Name = @"InsertPersonalSessionTimeout",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(162, 279),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,204,193,10,130,64,20,133,225,117,243,20,87,218,140,80,22,213,66,144,22,162,81,45,210,208,113,29,146,87,26,200,107,204,92,137,136,222,61,131,54,179,60,240,157,127,170,91,240,178,157,42,85,156,165,113,145,174,46,75,88,44,64,229,105,14,73,113,154,111,54,235,48,20,35,146,222,30,249,104,227,166,211,84,145,230,172,231,202,162,145,190,15,111,49,41,209,90,221,211,1,239,15,52,96,157,181,5,194,39,56,66,250,145,152,56,42,168,30,77,205,120,70,99,123,170,239,191,244,255,161,116,135,253,192,71,74,234,235,13,229,142,88,243,43,200,234,14,103,240,31,174,28,219,31,49,69,106,116,43,12,242,96,8,216,12,24,125,1,52,32,189,124,235,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSysAdminUnitUpdatedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c658b72a-3d51-4237-92d9-912437696368"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fce84846-b48b-4e67-8252-fe857f8ca425"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysAdminUnitUpdated",
				ModifiedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				Name = @"SysAdminUnitUpdated",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(42, 408),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateUpdatePersonalSessionTimeoutScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("516b32ab-ef63-46e0-ad20-f2f4a2792a89"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fce84846-b48b-4e67-8252-fe857f8ca425"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				Name = @"UpdatePersonalSessionTimeout",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(197, 394),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,81,79,194,48,16,199,159,217,167,168,240,210,37,90,136,242,64,66,102,50,55,80,30,28,134,13,125,52,115,59,160,102,107,151,182,211,16,195,119,183,29,160,212,32,9,111,237,221,191,247,191,223,245,58,116,129,46,162,81,18,39,126,20,250,179,240,250,181,135,186,93,148,76,195,41,10,102,143,87,253,254,205,96,224,196,32,37,229,236,1,138,10,4,146,214,205,67,12,62,145,165,192,238,208,249,72,5,202,86,41,91,66,190,203,37,180,4,94,171,128,23,117,201,244,179,17,83,84,173,201,61,168,96,171,219,102,158,211,162,6,137,93,242,178,2,1,56,59,204,33,239,22,89,1,18,165,37,32,207,67,109,219,164,173,59,208,100,248,68,7,36,224,53,83,216,53,175,123,46,250,114,90,2,84,45,24,82,162,134,161,179,105,8,228,241,214,79,149,29,83,33,21,222,249,107,184,137,244,243,146,178,57,163,42,226,106,46,205,120,26,59,107,140,36,6,245,4,66,114,150,22,70,99,151,150,216,196,2,206,24,100,74,135,137,95,85,7,183,120,45,21,148,182,68,55,176,65,80,72,48,86,252,237,93,71,205,71,53,211,213,4,199,192,72,147,28,58,45,211,249,94,75,18,30,43,65,217,114,59,41,217,156,201,168,172,212,186,161,248,131,49,175,242,84,193,255,36,99,193,203,240,238,124,156,203,253,186,76,114,77,214,250,69,59,211,127,194,130,52,91,1,222,85,51,235,243,83,218,86,54,54,122,13,58,192,114,186,112,14,151,227,27,245,195,96,132,53,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f5e8f47f-14d8-4c2c-8be8-a6107e0d2420"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("37fbf684-3407-456f-a966-354619f0ee64"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("6ff020f5-e34d-4da9-8c0d-3678e6f20dbf"),
				CreatedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(89, 514),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(326, 226),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaScriptTask CreateValidateCanChangeRecordScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8430682a-7728-492f-a57f-3e855a70de24"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f5e8f47f-14d8-4c2c-8be8-a6107e0d2420"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("6ff020f5-e34d-4da9-8c0d-3678e6f20dbf"),
				CreatedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				Name = @"ValidateCanChangeRecord",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(188, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,78,45,114,206,207,203,75,77,46,201,204,207,211,115,113,10,78,77,46,45,202,44,169,116,205,75,207,204,75,213,115,206,72,77,206,118,78,204,115,173,0,138,151,164,250,23,164,22,37,130,84,106,40,1,5,125,19,243,18,211,83,29,83,114,51,243,50,139,75,32,18,74,154,214,188,92,69,169,37,165,69,121,10,37,69,165,169,214,0,208,129,106,2,98,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSysAdminUnitDeletingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("949da708-5e6d-4553-9d7c-7ffea318e55b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f5e8f47f-14d8-4c2c-8be8-a6107e0d2420"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("6ff020f5-e34d-4da9-8c0d-3678e6f20dbf"),
				CreatedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysAdminUnitDeleting",
				ModifiedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				Name = @"SysAdminUnitDeleting",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(28, 147),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSysAdminUnitSavingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f6b52288-d021-4042-ba1d-9fdf2782b2c8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f5e8f47f-14d8-4c2c-8be8-a6107e0d2420"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("6ff020f5-e34d-4da9-8c0d-3678e6f20dbf"),
				CreatedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysAdminUnitSaving",
				ModifiedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				Name = @"SysAdminUnitSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(28, 20),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSysAdminUnitInsertingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("34d62e7b-9c4c-4cac-b0c2-4c5a3dd6325e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f5e8f47f-14d8-4c2c-8be8-a6107e0d2420"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("6ff020f5-e34d-4da9-8c0d-3678e6f20dbf"),
				CreatedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysAdminUnitInserting",
				ModifiedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				Name = @"SysAdminUnitInserting",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(28, 77),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateRemoveItemFromCacheMethod());
			Methods.Add(CreateGetIsAdminUnitNotUserMethod());
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
				UId = new Guid("a1f8c6a6-798f-4d77-9ab8-0688bc1d077a"),
				Name = "Terrasoft.Core.OperationLog",
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
				UId = new Guid("18e14ca5-82d5-49d5-b3d8-12c73a25a787"),
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

		protected virtual SchemaMethod CreateRemoveItemFromCacheMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("bd677d69-ff8c-48c2-aaf3-e6d3a6b45cff"),
				Name = "RemoveItemFromCache",
				CreatedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e7609615-033c-42d7-9be9-2b7405923440"),
				Name = "key",
				CreatedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				ModifiedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,76,46,201,44,203,44,169,12,45,201,204,41,214,11,78,45,241,47,10,74,205,205,47,75,245,44,73,205,245,204,115,132,74,59,39,38,103,164,106,132,22,167,22,57,231,231,229,165,2,69,243,243,116,20,178,83,43,53,173,1,244,116,55,98,66,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsAdminUnitNotUserMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ad1b20e5-ea10-4ca6-b86b-8895abbb810c"),
				Name = "GetIsAdminUnitNotUser",
				CreatedInSchemaUId = new Guid("640d3991-ca95-464a-b7b7-58941417973c"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,208,112,205,43,201,44,169,212,11,174,44,118,76,201,205,204,11,205,203,44,9,169,44,72,13,75,204,41,77,85,80,180,85,48,209,84,80,83,35,172,204,84,211,26,0,105,123,234,91,82,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysAdminUnit_Base_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("640d3991-ca95-464a-b7b7-58941417973c"));
		}

		#endregion

	}

	#endregion

}

