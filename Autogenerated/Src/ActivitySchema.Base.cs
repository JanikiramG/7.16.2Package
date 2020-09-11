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
	using System.Text;
	using System.Text.RegularExpressions;
	using System.Web;
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
	using Terrasoft.Core.Store;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: Activity_Base_TerrasoftSchema

	/// <exclude/>
	public class Activity_Base_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public Activity_Base_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Activity_Base_TerrasoftSchema(Activity_Base_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Activity_Base_TerrasoftSchema(Activity_Base_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
			RealUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
			Name = "Activity_Base_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateTitleColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializePrimaryOrderColumn() {
			base.InitializePrimaryOrderColumn();
			PrimaryOrderColumn = CreateStartDateColumn();
			if (Columns.FindByUId(PrimaryOrderColumn.UId) == null) {
				Columns.Add(PrimaryOrderColumn);
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
			if (Columns.FindByUId(new Guid("4038ce1f-15b2-4630-abb6-0c7377ab4c9b")) == null) {
				Columns.Add(CreateDueDateColumn());
			}
			if (Columns.FindByUId(new Guid("4248a634-bad1-4a20-a6af-4cd85fd24630")) == null) {
				Columns.Add(CreatePriorityColumn());
			}
			if (Columns.FindByUId(new Guid("60c813ae-ce04-4c50-9049-affa1ce6e7b8")) == null) {
				Columns.Add(CreateAuthorColumn());
			}
			if (Columns.FindByUId(new Guid("0d677c6b-95fd-47e2-a8b1-eadea6767eff")) == null) {
				Columns.Add(CreateRemindToAuthorColumn());
			}
			if (Columns.FindByUId(new Guid("69e70c11-5851-467a-b74b-15d3505e4f57")) == null) {
				Columns.Add(CreateRemindToAuthorDateColumn());
			}
			if (Columns.FindByUId(new Guid("de2d9c7f-a8b4-4f28-85d3-ee2593ac0f00")) == null) {
				Columns.Add(CreateRemindToOwnerColumn());
			}
			if (Columns.FindByUId(new Guid("9917a146-aa6a-46d0-bd35-a9356c4d4992")) == null) {
				Columns.Add(CreateRemindToOwnerDateColumn());
			}
			if (Columns.FindByUId(new Guid("5491c33f-e927-4ca8-a579-d4810ea54c56")) == null) {
				Columns.Add(CreateTypeColumn());
			}
			if (Columns.FindByUId(new Guid("c814fa71-e01b-4325-ac8d-8d4a293ed138")) == null) {
				Columns.Add(CreateActivityCategoryColumn());
			}
			if (Columns.FindByUId(new Guid("ff2dec51-885c-428a-8e6a-80c0c14b1434")) == null) {
				Columns.Add(CreateShowInSchedulerColumn());
			}
			if (Columns.FindByUId(new Guid("c8d84f9c-b48b-479b-9ac6-4412f3436ca2")) == null) {
				Columns.Add(CreateStatusColumn());
			}
			if (Columns.FindByUId(new Guid("ae372cfa-a21f-47f0-8a64-17d137ebe966")) == null) {
				Columns.Add(CreateResultColumn());
			}
			if (Columns.FindByUId(new Guid("070b689f-c9d8-46e3-bb52-bcb1f430f5cf")) == null) {
				Columns.Add(CreateDetailedResultColumn());
			}
			if (Columns.FindByUId(new Guid("06ff3e76-36f0-44d2-8f07-ffb752ffde09")) == null) {
				Columns.Add(CreateTimeZoneColumn());
			}
			if (Columns.FindByUId(new Guid("fb0d6fd1-17a1-4a04-a155-a4b643c6d048")) == null) {
				Columns.Add(CreateAccountColumn());
			}
			if (Columns.FindByUId(new Guid("bfaa9c7f-c368-4402-8310-a17660faf148")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("52b16ed8-6a96-4c0d-9887-4ba8cbb953e9")) == null) {
				Columns.Add(CreateSenderColumn());
			}
			if (Columns.FindByUId(new Guid("0cb5732f-80c0-41ab-a51a-8a509143a98b")) == null) {
				Columns.Add(CreateRecepientColumn());
			}
			if (Columns.FindByUId(new Guid("b2e5a95e-72e6-4985-b9b2-af1c335ed333")) == null) {
				Columns.Add(CreateCopyRecepientColumn());
			}
			if (Columns.FindByUId(new Guid("a1502eb1-c06a-4e2e-8010-f51eed7315d4")) == null) {
				Columns.Add(CreateBlindCopyRecepientColumn());
			}
			if (Columns.FindByUId(new Guid("618e7503-83b1-452d-aa33-8f76792853b5")) == null) {
				Columns.Add(CreateBodyColumn());
			}
			if (Columns.FindByUId(new Guid("961b5183-9eff-4424-b7f8-ee5267b489b6")) == null) {
				Columns.Add(CreateNotesColumn());
			}
			if (Columns.FindByUId(new Guid("b5b47ef8-e084-4cb0-bf59-19b3199014c7")) == null) {
				Columns.Add(CreateColorColumn());
			}
			if (Columns.FindByUId(new Guid("6689a019-c904-4b25-a89d-d17f3f3767cc")) == null) {
				Columns.Add(CreateSendDateColumn());
			}
			if (Columns.FindByUId(new Guid("4935a122-b7bc-443c-a282-72bd82f76ec4")) == null) {
				Columns.Add(CreateEmailSendStatusColumn());
			}
			if (Columns.FindByUId(new Guid("dd115e6f-5443-4238-97d5-3f9c36d8a9db")) == null) {
				Columns.Add(CreateDurationInMinutesColumn());
			}
			if (Columns.FindByUId(new Guid("5ff0586c-bedc-4c23-84f3-086402411dbb")) == null) {
				Columns.Add(CreateErrorOnSendColumn());
			}
			if (Columns.FindByUId(new Guid("487c8731-254d-4f2d-b152-9d823db2fc51")) == null) {
				Columns.Add(CreateDurationInMnutesAndHoursColumn());
			}
			if (Columns.FindByUId(new Guid("7bb00970-c11a-4a5a-82e5-d0a613afde06")) == null) {
				Columns.Add(CreateAllowedResultColumn());
			}
			if (Columns.FindByUId(new Guid("c7636768-5007-4cb9-800f-0d729fcadf4f")) == null) {
				Columns.Add(CreateCreatedByInvCRMColumn());
			}
			if (Columns.FindByUId(new Guid("af5a73d3-20ec-4419-819b-1575ce196bd2")) == null) {
				Columns.Add(CreateMessageTypeColumn());
			}
			if (Columns.FindByUId(new Guid("80fd1395-7e28-485e-a566-82fa964ba80b")) == null) {
				Columns.Add(CreateIsHtmlBodyColumn());
			}
			if (Columns.FindByUId(new Guid("1c19adcd-d3b5-4403-b515-b5c2cc9e481c")) == null) {
				Columns.Add(CreateMailHashColumn());
			}
			if (Columns.FindByUId(new Guid("ee2173fc-0840-4735-8c14-b58b6e3d9b99")) == null) {
				Columns.Add(CreateProcessElementIdColumn());
			}
			if (Columns.FindByUId(new Guid("d480d73a-f329-47f2-a0a2-cac4e82a2a40")) == null) {
				Columns.Add(CreateGlobalActivityIDColumn());
			}
			if (Columns.FindByUId(new Guid("004b1104-cc46-4865-b079-f23d2665c922")) == null) {
				Columns.Add(CreateIsNeedProcessColumn());
			}
			if (Columns.FindByUId(new Guid("2bbd4d7c-2727-47d6-bde1-311fdbbbb97e")) == null) {
				Columns.Add(CreateActivityConnectionColumn());
			}
			if (Columns.FindByUId(new Guid("734dfca1-2478-4719-8f3c-bfe3c6d1813d")) == null) {
				Columns.Add(CreateOrganizerColumn());
			}
			if (Columns.FindByUId(new Guid("a3d9fc18-5ad2-486f-9efd-be29f0d4429a")) == null) {
				Columns.Add(CreateCallDirectionColumn());
			}
			if (Columns.FindByUId(new Guid("3f1f6edd-5b9c-45d5-9575-edcf22c54893")) == null) {
				Columns.Add(CreateHeaderPropertiesColumn());
			}
			if (Columns.FindByUId(new Guid("7737db5f-7bab-4188-9d8e-a89636a84370")) == null) {
				Columns.Add(CreateIsAutoSubmittedColumn());
			}
			if (Columns.FindByUId(new Guid("67551707-45c4-4d2b-a77b-683eb8aa5fe1")) == null) {
				Columns.Add(CreateSenderContactColumn());
			}
			if (Columns.FindByUId(new Guid("6bb4799d-c450-4d98-ae51-a92e9689c358")) == null) {
				Columns.Add(CreatePreviewColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
			return column;
		}

		protected virtual EntitySchemaColumn CreateTitleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("4dcf0a31-7fd7-4dba-a004-e413b1753431"),
				Name = @"Title",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsTrackChangesInDB = true
			};
		}

		protected virtual EntitySchemaColumn CreateStartDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("a12ca538-61b1-4907-9fdf-01969163d4dd"),
				Name = @"StartDate",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsTrackChangesInDB = true,
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentDateTime")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateDueDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("4038ce1f-15b2-4630-abb6-0c7377ab4c9b"),
				Name = @"DueDate",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsTrackChangesInDB = true,
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentDateTime")
				}
			};
		}

		protected virtual EntitySchemaColumn CreatePriorityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("4248a634-bad1-4a20-a6af-4cd85fd24630"),
				Name = @"Priority",
				ReferenceSchemaUId = new Guid("b934f48c-5dea-49b9-bde3-697cb4be5d8b"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"ab96fa02-7fe6-df11-971b-001d60e938c6"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateAuthorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("60c813ae-ce04-4c50-9049-affa1ce6e7b8"),
				Name = @"Author",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsTrackChangesInDB = true,
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentUserContact")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateRemindToAuthorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("0d677c6b-95fd-47e2-a8b1-eadea6767eff"),
				Name = @"RemindToAuthor",
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateRemindToAuthorDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("69e70c11-5851-467a-b74b-15d3505e4f57"),
				Name = @"RemindToAuthorDate",
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateOwnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f0736fa3-79d1-4760-ae69-96ec56993491"),
				Name = @"Owner",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentUserContact")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateRemindToOwnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("de2d9c7f-a8b4-4f28-85d3-ee2593ac0f00"),
				Name = @"RemindToOwner",
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateRemindToOwnerDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("9917a146-aa6a-46d0-bd35-a9356c4d4992"),
				Name = @"RemindToOwnerDate",
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("5491c33f-e927-4ca8-a579-d4810ea54c56"),
				Name = @"Type",
				ReferenceSchemaUId = new Guid("75b4d39b-55dc-4bd6-8d10-3f49a58d96c7"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsTrackChangesInDB = true,
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"fbe0acdc-cfc0-df11-b00f-001d60e938c6"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateActivityCategoryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c814fa71-e01b-4325-ac8d-8d4a293ed138"),
				Name = @"ActivityCategory",
				ReferenceSchemaUId = new Guid("961e2086-a12b-4d27-b095-40b1e64d6cc0"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsTrackChangesInDB = true,
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"f51c4643-58e6-df11-971b-001d60e938c6"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateShowInSchedulerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("ff2dec51-885c-428a-8e6a-80c0c14b1434"),
				Name = @"ShowInScheduler",
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c8d84f9c-b48b-479b-9ac6-4412f3436ca2"),
				Name = @"Status",
				ReferenceSchemaUId = new Guid("805aace4-8604-40e7-a9eb-0f54174593c0"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsTrackChangesInDB = true,
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"384d4b84-58e6-df11-971b-001d60e938c6"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateResultColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ae372cfa-a21f-47f0-8a64-17d137ebe966"),
				Name = @"Result",
				ReferenceSchemaUId = new Guid("329bd06e-f95f-4824-a0fb-85edff2f2948"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsTrackChangesInDB = true
			};
		}

		protected virtual EntitySchemaColumn CreateDetailedResultColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("070b689f-c9d8-46e3-bb52-bcb1f430f5cf"),
				Name = @"DetailedResult",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateTimeZoneColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("06ff3e76-36f0-44d2-8f07-ffb752ffde09"),
				Name = @"TimeZone",
				ReferenceSchemaUId = new Guid("a394a569-92d6-44d0-bdda-fa0578373b4f"),
				IsIndexed = true,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("fb0d6fd1-17a1-4a04-a155-a4b643c6d048"),
				Name = @"Account",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsTrackChangesInDB = true
			};
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("bfaa9c7f-c368-4402-8310-a17660faf148"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsTrackChangesInDB = true
			};
		}

		protected virtual EntitySchemaColumn CreateSenderColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("52b16ed8-6a96-4c0d-9887-4ba8cbb953e9"),
				Name = @"Sender",
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsTrackChangesInDB = true
			};
		}

		protected virtual EntitySchemaColumn CreateRecepientColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("0cb5732f-80c0-41ab-a51a-8a509143a98b"),
				Name = @"Recepient",
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateCopyRecepientColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("b2e5a95e-72e6-4985-b9b2-af1c335ed333"),
				Name = @"CopyRecepient",
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsTrackChangesInDB = true
			};
		}

		protected virtual EntitySchemaColumn CreateBlindCopyRecepientColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("a1502eb1-c06a-4e2e-8010-f51eed7315d4"),
				Name = @"BlindCopyRecepient",
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateBodyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("618e7503-83b1-452d-aa33-8f76792853b5"),
				Name = @"Body",
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsTrackChangesInDB = true
			};
		}

		protected virtual EntitySchemaColumn CreateNotesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("961b5183-9eff-4424-b7f8-ee5267b489b6"),
				Name = @"Notes",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateColorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Color")) {
				UId = new Guid("b5b47ef8-e084-4cb0-bf59-19b3199014c7"),
				Name = @"Color",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"#405f97"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateSendDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("6689a019-c904-4b25-a89d-d17f3f3767cc"),
				Name = @"SendDate",
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateEmailSendStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("4935a122-b7bc-443c-a282-72bd82f76ec4"),
				Name = @"EmailSendStatus",
				ReferenceSchemaUId = new Guid("f3f1789f-fb2d-436f-a590-93667c0e8644"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateDurationInMinutesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("dd115e6f-5443-4238-97d5-3f9c36d8a9db"),
				Name = @"DurationInMinutes",
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateErrorOnSendColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("5ff0586c-bedc-4c23-84f3-086402411dbb"),
				Name = @"ErrorOnSend",
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateDurationInMnutesAndHoursColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("487c8731-254d-4f2d-b152-9d823db2fc51"),
				Name = @"DurationInMnutesAndHours",
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateAllowedResultColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("7bb00970-c11a-4a5a-82e5-d0a613afde06"),
				Name = @"AllowedResult",
				IsValueCloneable = false,
				UsageType = EntitySchemaColumnUsageType.Advanced,
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateCreatedByInvCRMColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("c7636768-5007-4cb9-800f-0d729fcadf4f"),
				Name = @"CreatedByInvCRM",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateMessageTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("af5a73d3-20ec-4419-819b-1575ce196bd2"),
				Name = @"MessageType",
				ReferenceSchemaUId = new Guid("4b276ad6-71c1-4b9a-be9d-379edc60012f"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsTrackChangesInDB = true
			};
		}

		protected virtual EntitySchemaColumn CreateIsHtmlBodyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("80fd1395-7e28-485e-a566-82fa964ba80b"),
				Name = @"IsHtmlBody",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateMailHashColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("1c19adcd-d3b5-4403-b515-b5c2cc9e481c"),
				Name = @"MailHash",
				IsIndexed = true,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("22efb752-2950-4da1-988b-653cc43dc44c")
			};
		}

		protected virtual EntitySchemaColumn CreateProcessElementIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("ee2173fc-0840-4735-8c14-b58b6e3d9b99"),
				Name = @"ProcessElementId",
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("5ca48210-97af-47ed-9943-795346aceaf8")
			};
		}

		protected virtual EntitySchemaColumn CreateGlobalActivityIDColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("d480d73a-f329-47f2-a0a2-cac4e82a2a40"),
				Name = @"GlobalActivityID",
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("02c41552-6138-41c7-b1d8-208f324fe99a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsNeedProcessColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("004b1104-cc46-4865-b079-f23d2665c922"),
				Name = @"IsNeedProcess",
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("e2abafdc-6941-48ad-bc50-34f0bc9897c4")
			};
		}

		protected virtual EntitySchemaColumn CreateActivityConnectionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("2bbd4d7c-2727-47d6-bde1-311fdbbbb97e"),
				Name = @"ActivityConnection",
				ReferenceSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("61ccc0bd-2b82-4636-a566-7b489433a0ee")
			};
		}

		protected virtual EntitySchemaColumn CreateOrganizerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("734dfca1-2478-4719-8f3c-bfe3c6d1813d"),
				Name = @"Organizer",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("9dae2167-8d3b-4948-9812-c7a970f9490e")
			};
		}

		protected virtual EntitySchemaColumn CreateCallDirectionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a3d9fc18-5ad2-486f-9efd-be29f0d4429a"),
				Name = @"CallDirection",
				ReferenceSchemaUId = new Guid("c58a425d-5e45-49ed-bfbe-bd15a9340b7e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("53c6a55b-73f6-4900-9445-a818892f6106"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"1d96a65f-2131-4916-8825-2d142b1000b2"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateHeaderPropertiesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("3f1f6edd-5b9c-45d5-9575-edcf22c54893"),
				Name = @"HeaderProperties",
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateIsAutoSubmittedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("7737db5f-7bab-4188-9d8e-a89636a84370"),
				Name = @"IsAutoSubmitted",
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateSenderContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("67551707-45c4-4d2b-a77b-683eb8aa5fe1"),
				Name = @"SenderContact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("79d5e1e4-18af-4001-8dc1-26f09fca92c2")
			};
		}

		protected virtual EntitySchemaColumn CreatePreviewColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("6bb4799d-c450-4d98-ae51-a92e9689c358"),
				Name = @"Preview",
				CreatedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				ModifiedInSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateActivity_Base_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateActivity_Base_TerrasoftEventsProcessSchema() {
			var schema = new Activity_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Activity_Base_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Activity_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Activity_Base_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Activity_Base_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"));
		}

		#endregion

	}

	#endregion

	#region Class: Activity_Base_Terrasoft

	/// <summary>
	/// Activity.
	/// </summary>
	public class Activity_Base_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public Activity_Base_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Activity_Base_Terrasoft";
		}

		public Activity_Base_Terrasoft(Activity_Base_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Subject.
		/// </summary>
		public string Title {
			get {
				return GetTypedColumnValue<string>("Title");
			}
			set {
				SetColumnValue("Title", value);
			}
		}

		/// <summary>
		/// Start.
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
		/// Due.
		/// </summary>
		public DateTime DueDate {
			get {
				return GetTypedColumnValue<DateTime>("DueDate");
			}
			set {
				SetColumnValue("DueDate", value);
			}
		}

		/// <exclude/>
		public Guid PriorityId {
			get {
				return GetTypedColumnValue<Guid>("PriorityId");
			}
			set {
				SetColumnValue("PriorityId", value);
				_priority = null;
			}
		}

		/// <exclude/>
		public string PriorityName {
			get {
				return GetTypedColumnValue<string>("PriorityName");
			}
			set {
				SetColumnValue("PriorityName", value);
				if (_priority != null) {
					_priority.Name = value;
				}
			}
		}

		private ActivityPriority _priority;
		/// <summary>
		/// Priority.
		/// </summary>
		public ActivityPriority Priority {
			get {
				return _priority ??
					(_priority = LookupColumnEntities.GetEntity("Priority") as ActivityPriority);
			}
		}

		/// <exclude/>
		public Guid AuthorId {
			get {
				return GetTypedColumnValue<Guid>("AuthorId");
			}
			set {
				SetColumnValue("AuthorId", value);
				_author = null;
			}
		}

		/// <exclude/>
		public string AuthorName {
			get {
				return GetTypedColumnValue<string>("AuthorName");
			}
			set {
				SetColumnValue("AuthorName", value);
				if (_author != null) {
					_author.Name = value;
				}
			}
		}

		private Contact _author;
		/// <summary>
		/// Reporter.
		/// </summary>
		public Contact Author {
			get {
				return _author ??
					(_author = LookupColumnEntities.GetEntity("Author") as Contact);
			}
		}

		/// <summary>
		/// Remind reporter.
		/// </summary>
		public bool RemindToAuthor {
			get {
				return GetTypedColumnValue<bool>("RemindToAuthor");
			}
			set {
				SetColumnValue("RemindToAuthor", value);
			}
		}

		/// <summary>
		/// Remind author on.
		/// </summary>
		public DateTime RemindToAuthorDate {
			get {
				return GetTypedColumnValue<DateTime>("RemindToAuthorDate");
			}
			set {
				SetColumnValue("RemindToAuthorDate", value);
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

		private ActivityType _type;
		/// <summary>
		/// Type.
		/// </summary>
		public ActivityType Type {
			get {
				return _type ??
					(_type = LookupColumnEntities.GetEntity("Type") as ActivityType);
			}
		}

		/// <exclude/>
		public Guid ActivityCategoryId {
			get {
				return GetTypedColumnValue<Guid>("ActivityCategoryId");
			}
			set {
				SetColumnValue("ActivityCategoryId", value);
				_activityCategory = null;
			}
		}

		/// <exclude/>
		public string ActivityCategoryName {
			get {
				return GetTypedColumnValue<string>("ActivityCategoryName");
			}
			set {
				SetColumnValue("ActivityCategoryName", value);
				if (_activityCategory != null) {
					_activityCategory.Name = value;
				}
			}
		}

		private ActivityCategory _activityCategory;
		/// <summary>
		/// Category.
		/// </summary>
		public ActivityCategory ActivityCategory {
			get {
				return _activityCategory ??
					(_activityCategory = LookupColumnEntities.GetEntity("ActivityCategory") as ActivityCategory);
			}
		}

		/// <summary>
		/// Show in calendar.
		/// </summary>
		public bool ShowInScheduler {
			get {
				return GetTypedColumnValue<bool>("ShowInScheduler");
			}
			set {
				SetColumnValue("ShowInScheduler", value);
			}
		}

		/// <exclude/>
		public Guid StatusId {
			get {
				return GetTypedColumnValue<Guid>("StatusId");
			}
			set {
				SetColumnValue("StatusId", value);
				_status = null;
			}
		}

		/// <exclude/>
		public string StatusName {
			get {
				return GetTypedColumnValue<string>("StatusName");
			}
			set {
				SetColumnValue("StatusName", value);
				if (_status != null) {
					_status.Name = value;
				}
			}
		}

		private ActivityStatus _status;
		/// <summary>
		/// Status.
		/// </summary>
		public ActivityStatus Status {
			get {
				return _status ??
					(_status = LookupColumnEntities.GetEntity("Status") as ActivityStatus);
			}
		}

		/// <exclude/>
		public Guid ResultId {
			get {
				return GetTypedColumnValue<Guid>("ResultId");
			}
			set {
				SetColumnValue("ResultId", value);
				_result = null;
			}
		}

		/// <exclude/>
		public string ResultName {
			get {
				return GetTypedColumnValue<string>("ResultName");
			}
			set {
				SetColumnValue("ResultName", value);
				if (_result != null) {
					_result.Name = value;
				}
			}
		}

		private ActivityResult _result;
		/// <summary>
		/// Result.
		/// </summary>
		public ActivityResult Result {
			get {
				return _result ??
					(_result = LookupColumnEntities.GetEntity("Result") as ActivityResult);
			}
		}

		/// <summary>
		/// Result details.
		/// </summary>
		public string DetailedResult {
			get {
				return GetTypedColumnValue<string>("DetailedResult");
			}
			set {
				SetColumnValue("DetailedResult", value);
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

		/// <summary>
		/// From.
		/// </summary>
		public string Sender {
			get {
				return GetTypedColumnValue<string>("Sender");
			}
			set {
				SetColumnValue("Sender", value);
			}
		}

		/// <summary>
		/// To.
		/// </summary>
		public string Recepient {
			get {
				return GetTypedColumnValue<string>("Recepient");
			}
			set {
				SetColumnValue("Recepient", value);
			}
		}

		/// <summary>
		/// Cc.
		/// </summary>
		public string CopyRecepient {
			get {
				return GetTypedColumnValue<string>("CopyRecepient");
			}
			set {
				SetColumnValue("CopyRecepient", value);
			}
		}

		/// <summary>
		/// Bcc.
		/// </summary>
		public string BlindCopyRecepient {
			get {
				return GetTypedColumnValue<string>("BlindCopyRecepient");
			}
			set {
				SetColumnValue("BlindCopyRecepient", value);
			}
		}

		/// <summary>
		/// Body.
		/// </summary>
		public string Body {
			get {
				return GetTypedColumnValue<string>("Body");
			}
			set {
				SetColumnValue("Body", value);
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
		/// Color.
		/// </summary>
		/// <remarks>
		/// Color of task.
		/// </remarks>
		public Color Color {
			get {
				return GetTypedColumnValue<Color>("Color");
			}
			set {
				SetColumnValue("Color", value);
			}
		}

		/// <summary>
		/// Sent on.
		/// </summary>
		public DateTime SendDate {
			get {
				return GetTypedColumnValue<DateTime>("SendDate");
			}
			set {
				SetColumnValue("SendDate", value);
			}
		}

		/// <exclude/>
		public Guid EmailSendStatusId {
			get {
				return GetTypedColumnValue<Guid>("EmailSendStatusId");
			}
			set {
				SetColumnValue("EmailSendStatusId", value);
				_emailSendStatus = null;
			}
		}

		/// <exclude/>
		public string EmailSendStatusName {
			get {
				return GetTypedColumnValue<string>("EmailSendStatusName");
			}
			set {
				SetColumnValue("EmailSendStatusName", value);
				if (_emailSendStatus != null) {
					_emailSendStatus.Name = value;
				}
			}
		}

		private EmailSendStatus _emailSendStatus;
		/// <summary>
		/// Email status.
		/// </summary>
		public EmailSendStatus EmailSendStatus {
			get {
				return _emailSendStatus ??
					(_emailSendStatus = LookupColumnEntities.GetEntity("EmailSendStatus") as EmailSendStatus);
			}
		}

		/// <summary>
		/// Duration (minutes).
		/// </summary>
		public int DurationInMinutes {
			get {
				return GetTypedColumnValue<int>("DurationInMinutes");
			}
			set {
				SetColumnValue("DurationInMinutes", value);
			}
		}

		/// <summary>
		/// Email status details.
		/// </summary>
		public string ErrorOnSend {
			get {
				return GetTypedColumnValue<string>("ErrorOnSend");
			}
			set {
				SetColumnValue("ErrorOnSend", value);
			}
		}

		/// <summary>
		/// Duration (hours, minutes).
		/// </summary>
		public string DurationInMnutesAndHours {
			get {
				return GetTypedColumnValue<string>("DurationInMnutesAndHours");
			}
			set {
				SetColumnValue("DurationInMnutesAndHours", value);
			}
		}

		/// <summary>
		/// Possible results.
		/// </summary>
		public string AllowedResult {
			get {
				return GetTypedColumnValue<string>("AllowedResult");
			}
			set {
				SetColumnValue("AllowedResult", value);
			}
		}

		/// <summary>
		/// Created in InvisibleCRM.
		/// </summary>
		public bool CreatedByInvCRM {
			get {
				return GetTypedColumnValue<bool>("CreatedByInvCRM");
			}
			set {
				SetColumnValue("CreatedByInvCRM", value);
			}
		}

		/// <exclude/>
		public Guid MessageTypeId {
			get {
				return GetTypedColumnValue<Guid>("MessageTypeId");
			}
			set {
				SetColumnValue("MessageTypeId", value);
				_messageType = null;
			}
		}

		/// <exclude/>
		public string MessageTypeName {
			get {
				return GetTypedColumnValue<string>("MessageTypeName");
			}
			set {
				SetColumnValue("MessageTypeName", value);
				if (_messageType != null) {
					_messageType.Name = value;
				}
			}
		}

		private EmailType _messageType;
		/// <summary>
		/// Message type.
		/// </summary>
		public EmailType MessageType {
			get {
				return _messageType ??
					(_messageType = LookupColumnEntities.GetEntity("MessageType") as EmailType);
			}
		}

		/// <summary>
		/// IsHtmlBody.
		/// </summary>
		public bool IsHtmlBody {
			get {
				return GetTypedColumnValue<bool>("IsHtmlBody");
			}
			set {
				SetColumnValue("IsHtmlBody", value);
			}
		}

		/// <summary>
		/// Hash code.
		/// </summary>
		public string MailHash {
			get {
				return GetTypedColumnValue<string>("MailHash");
			}
			set {
				SetColumnValue("MailHash", value);
			}
		}

		/// <summary>
		/// Process item.
		/// </summary>
		public Guid ProcessElementId {
			get {
				return GetTypedColumnValue<Guid>("ProcessElementId");
			}
			set {
				SetColumnValue("ProcessElementId", value);
			}
		}

		/// <summary>
		/// Outlook activity global identifier.
		/// </summary>
		public string GlobalActivityID {
			get {
				return GetTypedColumnValue<string>("GlobalActivityID");
			}
			set {
				SetColumnValue("GlobalActivityID", value);
			}
		}

		/// <summary>
		/// Needs processing.
		/// </summary>
		public bool IsNeedProcess {
			get {
				return GetTypedColumnValue<bool>("IsNeedProcess");
			}
			set {
				SetColumnValue("IsNeedProcess", value);
			}
		}

		/// <exclude/>
		public Guid ActivityConnectionId {
			get {
				return GetTypedColumnValue<Guid>("ActivityConnectionId");
			}
			set {
				SetColumnValue("ActivityConnectionId", value);
				_activityConnection = null;
			}
		}

		/// <exclude/>
		public string ActivityConnectionTitle {
			get {
				return GetTypedColumnValue<string>("ActivityConnectionTitle");
			}
			set {
				SetColumnValue("ActivityConnectionTitle", value);
				if (_activityConnection != null) {
					_activityConnection.Title = value;
				}
			}
		}

		private Activity _activityConnection;
		/// <summary>
		/// Activity.
		/// </summary>
		public Activity ActivityConnection {
			get {
				return _activityConnection ??
					(_activityConnection = LookupColumnEntities.GetEntity("ActivityConnection") as Activity);
			}
		}

		/// <exclude/>
		public Guid OrganizerId {
			get {
				return GetTypedColumnValue<Guid>("OrganizerId");
			}
			set {
				SetColumnValue("OrganizerId", value);
				_organizer = null;
			}
		}

		/// <exclude/>
		public string OrganizerName {
			get {
				return GetTypedColumnValue<string>("OrganizerName");
			}
			set {
				SetColumnValue("OrganizerName", value);
				if (_organizer != null) {
					_organizer.Name = value;
				}
			}
		}

		private Contact _organizer;
		/// <summary>
		/// Organizer.
		/// </summary>
		public Contact Organizer {
			get {
				return _organizer ??
					(_organizer = LookupColumnEntities.GetEntity("Organizer") as Contact);
			}
		}

		/// <exclude/>
		public Guid CallDirectionId {
			get {
				return GetTypedColumnValue<Guid>("CallDirectionId");
			}
			set {
				SetColumnValue("CallDirectionId", value);
				_callDirection = null;
			}
		}

		/// <exclude/>
		public string CallDirectionName {
			get {
				return GetTypedColumnValue<string>("CallDirectionName");
			}
			set {
				SetColumnValue("CallDirectionName", value);
				if (_callDirection != null) {
					_callDirection.Name = value;
				}
			}
		}

		private CallDirection _callDirection;
		/// <summary>
		/// Call direction.
		/// </summary>
		public CallDirection CallDirection {
			get {
				return _callDirection ??
					(_callDirection = LookupColumnEntities.GetEntity("CallDirection") as CallDirection);
			}
		}

		/// <summary>
		/// Header Properties.
		/// </summary>
		public string HeaderProperties {
			get {
				return GetTypedColumnValue<string>("HeaderProperties");
			}
			set {
				SetColumnValue("HeaderProperties", value);
			}
		}

		/// <summary>
		/// Is auto submitted.
		/// </summary>
		public bool IsAutoSubmitted {
			get {
				return GetTypedColumnValue<bool>("IsAutoSubmitted");
			}
			set {
				SetColumnValue("IsAutoSubmitted", value);
			}
		}

		/// <exclude/>
		public Guid SenderContactId {
			get {
				return GetTypedColumnValue<Guid>("SenderContactId");
			}
			set {
				SetColumnValue("SenderContactId", value);
				_senderContact = null;
			}
		}

		/// <exclude/>
		public string SenderContactName {
			get {
				return GetTypedColumnValue<string>("SenderContactName");
			}
			set {
				SetColumnValue("SenderContactName", value);
				if (_senderContact != null) {
					_senderContact.Name = value;
				}
			}
		}

		private Contact _senderContact;
		/// <summary>
		/// Sender contact.
		/// </summary>
		public Contact SenderContact {
			get {
				return _senderContact ??
					(_senderContact = LookupColumnEntities.GetEntity("SenderContact") as Contact);
			}
		}

		/// <summary>
		/// Preview.
		/// </summary>
		public string Preview {
			get {
				return GetTypedColumnValue<string>("Preview");
			}
			set {
				SetColumnValue("Preview", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Activity_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Activity_Base_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("Activity_Base_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("Activity_Base_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("Activity_Base_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("Activity_Base_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Activity_Base_TerrasoftSaving", e);
			Updated += (s, e) => ThrowEvent("Activity_Base_TerrasoftUpdated", e);
			Validating += (s, e) => ThrowEvent("Activity_Base_TerrasoftValidating", e);
			DefColumnValuesSet += (s, e) => ThrowEvent("Activity_Base_TerrasoftDefColumnValuesSet", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Activity_Base_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Activity_BaseEventsProcess

	/// <exclude/>
	public partial class Activity_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : Activity_Base_Terrasoft
	{

		#region Class: SynchronizeSubjectRemindingOwnerFlowElement

		/// <exclude/>
		public class SynchronizeSubjectRemindingOwnerFlowElement : SynchronizeSubjectRemindingUserTask
		{

			public SynchronizeSubjectRemindingOwnerFlowElement(UserConnection userConnection, Activity_BaseEventsProcess<TEntity> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "SynchronizeSubjectRemindingOwner";
				IsLogging = false;
				SchemaElementUId = new Guid("4ebed4c4-db85-492e-ae3e-30ea37ce7801");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: SynchronizeSubjectRemindingAuthorFlowElement

		/// <exclude/>
		public class SynchronizeSubjectRemindingAuthorFlowElement : SynchronizeSubjectRemindingUserTask
		{

			public SynchronizeSubjectRemindingAuthorFlowElement(UserConnection userConnection, Activity_BaseEventsProcess<TEntity> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "SynchronizeSubjectRemindingAuthor";
				IsLogging = false;
				SchemaElementUId = new Guid("4567ea18-f5a1-4ba9-aa5f-b7c4b7a1e09e");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public Activity_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Activity_BaseEventsProcess";
			SchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual Object InsertedValues {
			get;
			set;
		}

		public virtual Object DeletedValues {
			get;
			set;
		}

		public virtual bool IsDifferentContacts {
			get;
			set;
		}

		public virtual Object RecepientsEmails {
			get;
			set;
		}

		public virtual Object CopyRecepientsEmails {
			get;
			set;
		}

		public virtual Object BlindCopyRecepientsEmails {
			get;
			set;
		}

		public virtual Object RecepientsEmailsForDelete {
			get;
			set;
		}

		public virtual Guid oldOwnerId {
			get;
			set;
		}

		public virtual Guid newOwnerId {
			get;
			set;
		}

		public virtual Guid oldContactId {
			get;
			set;
		}

		public virtual Guid newContactId {
			get;
			set;
		}

		public virtual string SenderEmail {
			get;
			set;
		}

		public virtual Guid SenderId {
			get;
			set;
		}

		public virtual bool IsNew {
			get;
			set;
		}

		public virtual bool IsNeedAutoEmailRelation {
			get;
			set;
		}

		public virtual Object EmailParticipantHelper {
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

		private ProcessFlowElement _activitySavedSubProcess;
		public ProcessFlowElement ActivitySavedSubProcess {
			get {
				return _activitySavedSubProcess ?? (_activitySavedSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ActivitySavedSubProcess",
					SchemaElementUId = new Guid("cec59e3a-99bd-4af7-bcab-ed936238fc72"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageActivitySaved;
		public ProcessFlowElement StartMessageActivitySaved {
			get {
				return _startMessageActivitySaved ?? (_startMessageActivitySaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageActivitySaved",
					SchemaElementUId = new Guid("60828812-b879-4291-a03e-325b2cc89fa5"),
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
					SchemaElementUId = new Guid("4e7601f9-de28-48b6-bd1f-e9c20fe849ef"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "SynchronizeRemindings",
				});
			}
		}

		private ProcessScriptTask _activitySavedScriptTask;
		public ProcessScriptTask ActivitySavedScriptTask {
			get {
				return _activitySavedScriptTask ?? (_activitySavedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ActivitySavedScriptTask",
					SchemaElementUId = new Guid("242e3956-ea08-4383-b3e4-0c5226d72265"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ActivitySavedScriptTaskExecute,
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
					SchemaElementUId = new Guid("7c214338-8ceb-405d-998b-154439a24622"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = UpdateRemindingsExecute,
				});
			}
		}

		private ProcessFlowElement _activitySavingSubProcess;
		public ProcessFlowElement ActivitySavingSubProcess {
			get {
				return _activitySavingSubProcess ?? (_activitySavingSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ActivitySavingSubProcess",
					SchemaElementUId = new Guid("3fbd2388-ab69-48d4-b802-8fe8efad9978"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _activitySavingStartMessage;
		public ProcessFlowElement ActivitySavingStartMessage {
			get {
				return _activitySavingStartMessage ?? (_activitySavingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ActivitySavingStartMessage",
					SchemaElementUId = new Guid("5444156a-a20a-4e76-a7ef-c321a7553570"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _activitySavingScriptTask;
		public ProcessScriptTask ActivitySavingScriptTask {
			get {
				return _activitySavingScriptTask ?? (_activitySavingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ActivitySavingScriptTask",
					SchemaElementUId = new Guid("7ff002e9-e185-412b-a40f-a18c71dd8be2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ActivitySavingScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _activityInsertingEventSubProcess;
		public ProcessFlowElement ActivityInsertingEventSubProcess {
			get {
				return _activityInsertingEventSubProcess ?? (_activityInsertingEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ActivityInsertingEventSubProcess",
					SchemaElementUId = new Guid("fdc25270-216b-4cf9-bcc8-c94d500860f7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _activityInserting;
		public ProcessFlowElement ActivityInserting {
			get {
				return _activityInserting ?? (_activityInserting = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ActivityInserting",
					SchemaElementUId = new Guid("0c5dc6d7-e051-4e24-b8f2-d0cd1dadb4fa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptActivityInserting;
		public ProcessScriptTask ScriptActivityInserting {
			get {
				return _scriptActivityInserting ?? (_scriptActivityInserting = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptActivityInserting",
					SchemaElementUId = new Guid("a1ca2b05-103a-4752-a317-e8e0577c9a7e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptActivityInsertingExecute,
				});
			}
		}

		private ProcessFlowElement _activityDefColumnValuesSetEventSubProcess;
		public ProcessFlowElement ActivityDefColumnValuesSetEventSubProcess {
			get {
				return _activityDefColumnValuesSetEventSubProcess ?? (_activityDefColumnValuesSetEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ActivityDefColumnValuesSetEventSubProcess",
					SchemaElementUId = new Guid("635fa9cb-7360-4e6c-9ab7-d95b48a6c9ad"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _activityDefColumnValuesSet;
		public ProcessFlowElement ActivityDefColumnValuesSet {
			get {
				return _activityDefColumnValuesSet ?? (_activityDefColumnValuesSet = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ActivityDefColumnValuesSet",
					SchemaElementUId = new Guid("5ef784c0-f459-416d-8a35-da718a515473"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _activityDefColumnValuesSetScriptTask;
		public ProcessScriptTask ActivityDefColumnValuesSetScriptTask {
			get {
				return _activityDefColumnValuesSetScriptTask ?? (_activityDefColumnValuesSetScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ActivityDefColumnValuesSetScriptTask",
					SchemaElementUId = new Guid("0644828a-9ba4-4328-bbbc-120722acce56"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ActivityDefColumnValuesSetScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _activityDeletingEventSubProcess;
		public ProcessFlowElement ActivityDeletingEventSubProcess {
			get {
				return _activityDeletingEventSubProcess ?? (_activityDeletingEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ActivityDeletingEventSubProcess",
					SchemaElementUId = new Guid("0d943db0-ee11-46b4-90c5-46a02cc28819"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _activityDeletingStartMessage;
		public ProcessFlowElement ActivityDeletingStartMessage {
			get {
				return _activityDeletingStartMessage ?? (_activityDeletingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ActivityDeletingStartMessage",
					SchemaElementUId = new Guid("cede14f1-3821-47d0-8677-059509518170"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _activityDeletingScriptTask;
		public ProcessScriptTask ActivityDeletingScriptTask {
			get {
				return _activityDeletingScriptTask ?? (_activityDeletingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ActivityDeletingScriptTask",
					SchemaElementUId = new Guid("f9ac769f-4ad2-4537-8e36-5a552312a4f9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ActivityDeletingScriptTaskExecute,
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
					SchemaElementUId = new Guid("8b15e558-03f8-4435-bdc6-57a990231738"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "SynchronizeRemindings",
				});
			}
		}

		private ProcessFlowElement _remindingsSynchronizeEventSubProcess;
		public ProcessFlowElement RemindingsSynchronizeEventSubProcess {
			get {
				return _remindingsSynchronizeEventSubProcess ?? (_remindingsSynchronizeEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "RemindingsSynchronizeEventSubProcess",
					SchemaElementUId = new Guid("a0ff1647-9846-4530-9692-fda7f87ec9ab"),
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
					SchemaElementUId = new Guid("6870ffad-93d9-4841-a511-07de9af2d792"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _synchronizeSubjectRemindingOwnerScript;
		public ProcessScriptTask SynchronizeSubjectRemindingOwnerScript {
			get {
				return _synchronizeSubjectRemindingOwnerScript ?? (_synchronizeSubjectRemindingOwnerScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SynchronizeSubjectRemindingOwnerScript",
					SchemaElementUId = new Guid("75c05abb-9798-41e2-b0bb-09150b07ab1e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SynchronizeSubjectRemindingOwnerScriptExecute,
				});
			}
		}

		private SynchronizeSubjectRemindingOwnerFlowElement _synchronizeSubjectRemindingOwner;
		public SynchronizeSubjectRemindingOwnerFlowElement SynchronizeSubjectRemindingOwner {
			get {
				return _synchronizeSubjectRemindingOwner ?? (_synchronizeSubjectRemindingOwner = new SynchronizeSubjectRemindingOwnerFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _synchronizeSubjectRemindingAuthorScript;
		public ProcessScriptTask SynchronizeSubjectRemindingAuthorScript {
			get {
				return _synchronizeSubjectRemindingAuthorScript ?? (_synchronizeSubjectRemindingAuthorScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SynchronizeSubjectRemindingAuthorScript",
					SchemaElementUId = new Guid("005cc890-8c70-4098-88ec-80950340fe5a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SynchronizeSubjectRemindingAuthorScriptExecute,
				});
			}
		}

		private SynchronizeSubjectRemindingAuthorFlowElement _synchronizeSubjectRemindingAuthor;
		public SynchronizeSubjectRemindingAuthorFlowElement SynchronizeSubjectRemindingAuthor {
			get {
				return _synchronizeSubjectRemindingAuthor ?? (_synchronizeSubjectRemindingAuthor = new SynchronizeSubjectRemindingAuthorFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _activityInsertedEventSubProcess;
		public ProcessFlowElement ActivityInsertedEventSubProcess {
			get {
				return _activityInsertedEventSubProcess ?? (_activityInsertedEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ActivityInsertedEventSubProcess",
					SchemaElementUId = new Guid("90556cbb-797c-4592-baba-c65e4c525176"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _activityInserted;
		public ProcessFlowElement ActivityInserted {
			get {
				return _activityInserted ?? (_activityInserted = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ActivityInserted",
					SchemaElementUId = new Guid("201f36e9-3509-40c4-9630-c4a30c1cff66"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptActivityInserted;
		public ProcessScriptTask ScriptActivityInserted {
			get {
				return _scriptActivityInserted ?? (_scriptActivityInserted = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptActivityInserted",
					SchemaElementUId = new Guid("ba458700-4412-44e1-ae92-b324e4da2990"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptActivityInsertedExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess3_194a2b9eda6c440ba0883a59c753280a;
		public ProcessFlowElement EventSubProcess3_194a2b9eda6c440ba0883a59c753280a {
			get {
				return _eventSubProcess3_194a2b9eda6c440ba0883a59c753280a ?? (_eventSubProcess3_194a2b9eda6c440ba0883a59c753280a = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3_194a2b9eda6c440ba0883a59c753280a",
					SchemaElementUId = new Guid("194a2b9e-da6c-440b-a088-3a59c753280a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3_9d37e41aabe548ae868128ec71992033;
		public ProcessFlowElement StartMessage3_9d37e41aabe548ae868128ec71992033 {
			get {
				return _startMessage3_9d37e41aabe548ae868128ec71992033 ?? (_startMessage3_9d37e41aabe548ae868128ec71992033 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3_9d37e41aabe548ae868128ec71992033",
					SchemaElementUId = new Guid("9d37e41a-abe5-48ae-8681-28ec71992033"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _activityUpdatedScriptTask_42f1f750f7be4667b75eeb7454a4a25d;
		public ProcessScriptTask ActivityUpdatedScriptTask_42f1f750f7be4667b75eeb7454a4a25d {
			get {
				return _activityUpdatedScriptTask_42f1f750f7be4667b75eeb7454a4a25d ?? (_activityUpdatedScriptTask_42f1f750f7be4667b75eeb7454a4a25d = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ActivityUpdatedScriptTask_42f1f750f7be4667b75eeb7454a4a25d",
					SchemaElementUId = new Guid("42f1f750-f7be-4667-b75e-eb7454a4a25d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ActivityUpdatedScriptTask_42f1f750f7be4667b75eeb7454a4a25dExecute,
				});
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow1_91b0fd7fdfd7441c9a9c9652b3e2f653;
		public ProcessConditionalFlow ConditionalSequenceFlow1_91b0fd7fdfd7441c9a9c9652b3e2f653 {
			get {
				return _conditionalSequenceFlow1_91b0fd7fdfd7441c9a9c9652b3e2f653 ?? (_conditionalSequenceFlow1_91b0fd7fdfd7441c9a9c9652b3e2f653 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow1_91b0fd7fdfd7441c9a9c9652b3e2f653",
					SchemaElementUId = new Guid("91b0fd7f-dfd7-441c-9a9c-9652b3e2f653"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow2_a34effe2af294a52a41439c626702dc4;
		public ProcessConditionalFlow ConditionalSequenceFlow2_a34effe2af294a52a41439c626702dc4 {
			get {
				return _conditionalSequenceFlow2_a34effe2af294a52a41439c626702dc4 ?? (_conditionalSequenceFlow2_a34effe2af294a52a41439c626702dc4 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow2_a34effe2af294a52a41439c626702dc4",
					SchemaElementUId = new Guid("a34effe2-af29-4a52-a414-39c626702dc4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private LocalizableString _hour;
		public LocalizableString Hour {
			get {
				return _hour ?? (_hour = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.Hour.Value"));
			}
		}

		private LocalizableString _minute;
		public LocalizableString Minute {
			get {
				return _minute ?? (_minute = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.Minute.Value"));
			}
		}

		private LocalizableString _senderEmailMoreThenOne;
		public LocalizableString SenderEmailMoreThenOne {
			get {
				return _senderEmailMoreThenOne ?? (_senderEmailMoreThenOne = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.SenderEmailMoreThenOne.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[ActivitySavedSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivitySavedSubProcess };
			FlowElements[StartMessageActivitySaved.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageActivitySaved };
			FlowElements[SynchronizeRemindingsIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { SynchronizeRemindingsIntermediateThrowMessageEvent };
			FlowElements[ActivitySavedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivitySavedScriptTask };
			FlowElements[UpdateRemindings.SchemaElementUId] = new Collection<ProcessFlowElement> { UpdateRemindings };
			FlowElements[ActivitySavingSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivitySavingSubProcess };
			FlowElements[ActivitySavingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivitySavingStartMessage };
			FlowElements[ActivitySavingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivitySavingScriptTask };
			FlowElements[ActivityInsertingEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityInsertingEventSubProcess };
			FlowElements[ActivityInserting.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityInserting };
			FlowElements[ScriptActivityInserting.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptActivityInserting };
			FlowElements[ActivityDefColumnValuesSetEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityDefColumnValuesSetEventSubProcess };
			FlowElements[ActivityDefColumnValuesSet.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityDefColumnValuesSet };
			FlowElements[ActivityDefColumnValuesSetScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityDefColumnValuesSetScriptTask };
			FlowElements[ActivityDeletingEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityDeletingEventSubProcess };
			FlowElements[ActivityDeletingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityDeletingStartMessage };
			FlowElements[ActivityDeletingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityDeletingScriptTask };
			FlowElements[SynchronizeRemindingsOnDeleteIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { SynchronizeRemindingsOnDeleteIntermediateThrowMessageEvent };
			FlowElements[RemindingsSynchronizeEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { RemindingsSynchronizeEventSubProcess };
			FlowElements[SynchronizeRemindingsStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SynchronizeRemindingsStartMessage };
			FlowElements[SynchronizeSubjectRemindingOwnerScript.SchemaElementUId] = new Collection<ProcessFlowElement> { SynchronizeSubjectRemindingOwnerScript };
			FlowElements[SynchronizeSubjectRemindingOwner.SchemaElementUId] = new Collection<ProcessFlowElement> { SynchronizeSubjectRemindingOwner };
			FlowElements[SynchronizeSubjectRemindingAuthorScript.SchemaElementUId] = new Collection<ProcessFlowElement> { SynchronizeSubjectRemindingAuthorScript };
			FlowElements[SynchronizeSubjectRemindingAuthor.SchemaElementUId] = new Collection<ProcessFlowElement> { SynchronizeSubjectRemindingAuthor };
			FlowElements[ActivityInsertedEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityInsertedEventSubProcess };
			FlowElements[ActivityInserted.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityInserted };
			FlowElements[ScriptActivityInserted.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptActivityInserted };
			FlowElements[EventSubProcess3_194a2b9eda6c440ba0883a59c753280a.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3_194a2b9eda6c440ba0883a59c753280a };
			FlowElements[StartMessage3_9d37e41aabe548ae868128ec71992033.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3_9d37e41aabe548ae868128ec71992033 };
			FlowElements[ActivityUpdatedScriptTask_42f1f750f7be4667b75eeb7454a4a25d.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityUpdatedScriptTask_42f1f750f7be4667b75eeb7454a4a25d };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "ActivitySavedSubProcess":
						break;
					case "StartMessageActivitySaved":
						e.Context.QueueTasks.Enqueue("SynchronizeRemindingsIntermediateThrowMessageEvent");
						e.Context.QueueTasks.Enqueue("ActivitySavedScriptTask");
						e.Context.QueueTasks.Enqueue("UpdateRemindings");
						break;
					case "SynchronizeRemindingsIntermediateThrowMessageEvent":
						break;
					case "ActivitySavedScriptTask":
						break;
					case "UpdateRemindings":
						break;
					case "ActivitySavingSubProcess":
						break;
					case "ActivitySavingStartMessage":
						e.Context.QueueTasks.Enqueue("ActivitySavingScriptTask");
						break;
					case "ActivitySavingScriptTask":
						break;
					case "ActivityInsertingEventSubProcess":
						break;
					case "ActivityInserting":
						e.Context.QueueTasks.Enqueue("ScriptActivityInserting");
						break;
					case "ScriptActivityInserting":
						break;
					case "ActivityDefColumnValuesSetEventSubProcess":
						break;
					case "ActivityDefColumnValuesSet":
						e.Context.QueueTasks.Enqueue("ActivityDefColumnValuesSetScriptTask");
						break;
					case "ActivityDefColumnValuesSetScriptTask":
						break;
					case "ActivityDeletingEventSubProcess":
						break;
					case "ActivityDeletingStartMessage":
						e.Context.QueueTasks.Enqueue("ActivityDeletingScriptTask");
						break;
					case "ActivityDeletingScriptTask":
						e.Context.QueueTasks.Enqueue("SynchronizeRemindingsOnDeleteIntermediateThrowMessageEvent");
						break;
					case "SynchronizeRemindingsOnDeleteIntermediateThrowMessageEvent":
						break;
					case "RemindingsSynchronizeEventSubProcess":
						break;
					case "SynchronizeRemindingsStartMessage":
						e.Context.QueueTasks.Enqueue("SynchronizeSubjectRemindingAuthorScript");
						e.Context.QueueTasks.Enqueue("SynchronizeSubjectRemindingOwnerScript");
						break;
					case "SynchronizeSubjectRemindingOwnerScript":
						if (ConditionalSequenceFlow1_91b0fd7fdfd7441c9a9c9652b3e2f653ExpressionExecute()) {
						e.Context.QueueTasks.Enqueue("SynchronizeSubjectRemindingOwner");
							break;
						}
						break;
					case "SynchronizeSubjectRemindingOwner":
						break;
					case "SynchronizeSubjectRemindingAuthorScript":
						if (ConditionalSequenceFlow2_a34effe2af294a52a41439c626702dc4ExpressionExecute()) {
						e.Context.QueueTasks.Enqueue("SynchronizeSubjectRemindingAuthor");
							break;
						}
						break;
					case "SynchronizeSubjectRemindingAuthor":
						break;
					case "ActivityInsertedEventSubProcess":
						break;
					case "ActivityInserted":
						e.Context.QueueTasks.Enqueue("ScriptActivityInserted");
						break;
					case "ScriptActivityInserted":
						break;
					case "EventSubProcess3_194a2b9eda6c440ba0883a59c753280a":
						break;
					case "StartMessage3_9d37e41aabe548ae868128ec71992033":
						e.Context.QueueTasks.Enqueue("ActivityUpdatedScriptTask_42f1f750f7be4667b75eeb7454a4a25d");
						break;
					case "ActivityUpdatedScriptTask_42f1f750f7be4667b75eeb7454a4a25d":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalSequenceFlow1_91b0fd7fdfd7441c9a9c9652b3e2f653ExpressionExecute() {
			return Convert.ToBoolean(Entity.GetTypedColumnValue<Guid>("TypeId") != ActivityConsts.EmailTypeUId);
		}

		private bool ConditionalSequenceFlow2_a34effe2af294a52a41439c626702dc4ExpressionExecute() {
			return Convert.ToBoolean(Entity.GetTypedColumnValue<Guid>("TypeId") != ActivityConsts.EmailTypeUId);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessageActivitySaved");
			ActivatedEventElements.Add("ActivitySavingStartMessage");
			ActivatedEventElements.Add("ActivityInserting");
			ActivatedEventElements.Add("ActivityDefColumnValuesSet");
			ActivatedEventElements.Add("ActivityDeletingStartMessage");
			ActivatedEventElements.Add("SynchronizeRemindingsStartMessage");
			ActivatedEventElements.Add("ActivityInserted");
			ActivatedEventElements.Add("StartMessage3_9d37e41aabe548ae868128ec71992033");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "ActivitySavedSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageActivitySaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageActivitySaved";
					result = StartMessageActivitySaved.Execute(context);
					break;
				case "SynchronizeRemindingsIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					result = SynchronizeRemindingsIntermediateThrowMessageEvent.Execute(context);
					break;
				case "ActivitySavedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActivitySavedScriptTask";
					result = ActivitySavedScriptTask.Execute(context, ActivitySavedScriptTaskExecute);
					break;
				case "UpdateRemindings":
					context.QueueTasks.Dequeue();
					context.SenderName = "UpdateRemindings";
					result = UpdateRemindings.Execute(context, UpdateRemindingsExecute);
					break;
				case "ActivitySavingSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ActivitySavingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActivitySavingStartMessage";
					result = ActivitySavingStartMessage.Execute(context);
					break;
				case "ActivitySavingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActivitySavingScriptTask";
					result = ActivitySavingScriptTask.Execute(context, ActivitySavingScriptTaskExecute);
					break;
				case "ActivityInsertingEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ActivityInserting":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActivityInserting";
					result = ActivityInserting.Execute(context);
					break;
				case "ScriptActivityInserting":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptActivityInserting";
					result = ScriptActivityInserting.Execute(context, ScriptActivityInsertingExecute);
					break;
				case "ActivityDefColumnValuesSetEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ActivityDefColumnValuesSet":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActivityDefColumnValuesSet";
					result = ActivityDefColumnValuesSet.Execute(context);
					break;
				case "ActivityDefColumnValuesSetScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActivityDefColumnValuesSetScriptTask";
					result = ActivityDefColumnValuesSetScriptTask.Execute(context, ActivityDefColumnValuesSetScriptTaskExecute);
					break;
				case "ActivityDeletingEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ActivityDeletingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActivityDeletingStartMessage";
					result = ActivityDeletingStartMessage.Execute(context);
					break;
				case "ActivityDeletingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActivityDeletingScriptTask";
					result = ActivityDeletingScriptTask.Execute(context, ActivityDeletingScriptTaskExecute);
					break;
				case "SynchronizeRemindingsOnDeleteIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					result = SynchronizeRemindingsOnDeleteIntermediateThrowMessageEvent.Execute(context);
					break;
				case "RemindingsSynchronizeEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "SynchronizeRemindingsStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SynchronizeRemindingsStartMessage";
					result = SynchronizeRemindingsStartMessage.Execute(context);
					break;
				case "SynchronizeSubjectRemindingOwnerScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "SynchronizeSubjectRemindingOwnerScript";
					result = SynchronizeSubjectRemindingOwnerScript.Execute(context, SynchronizeSubjectRemindingOwnerScriptExecute);
					break;
				case "SynchronizeSubjectRemindingOwner":
					context.QueueTasks.Dequeue();
					context.SenderName = "SynchronizeSubjectRemindingOwner";
					result = SynchronizeSubjectRemindingOwner.Execute(context);
					break;
				case "SynchronizeSubjectRemindingAuthorScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "SynchronizeSubjectRemindingAuthorScript";
					result = SynchronizeSubjectRemindingAuthorScript.Execute(context, SynchronizeSubjectRemindingAuthorScriptExecute);
					break;
				case "SynchronizeSubjectRemindingAuthor":
					context.QueueTasks.Dequeue();
					context.SenderName = "SynchronizeSubjectRemindingAuthor";
					result = SynchronizeSubjectRemindingAuthor.Execute(context);
					break;
				case "ActivityInsertedEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ActivityInserted":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActivityInserted";
					result = ActivityInserted.Execute(context);
					break;
				case "ScriptActivityInserted":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptActivityInserted";
					result = ScriptActivityInserted.Execute(context, ScriptActivityInsertedExecute);
					break;
				case "EventSubProcess3_194a2b9eda6c440ba0883a59c753280a":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3_9d37e41aabe548ae868128ec71992033":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3_9d37e41aabe548ae868128ec71992033";
					result = StartMessage3_9d37e41aabe548ae868128ec71992033.Execute(context);
					break;
				case "ActivityUpdatedScriptTask_42f1f750f7be4667b75eeb7454a4a25d":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActivityUpdatedScriptTask_42f1f750f7be4667b75eeb7454a4a25d";
					result = ActivityUpdatedScriptTask_42f1f750f7be4667b75eeb7454a4a25d.Execute(context, ActivityUpdatedScriptTask_42f1f750f7be4667b75eeb7454a4a25dExecute);
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
				case "EmailParticipantHelper":
					EmailParticipantHelper = reader.GetSerializableObjectValue();
				break;
				case "IsNeedAutoEmailRelation":
					IsNeedAutoEmailRelation = reader.GetValue<System.Boolean>();
				break;
				case "IsNew":
					IsNew = reader.GetValue<System.Boolean>();
				break;
				case "SenderId":
					SenderId = reader.GetValue<System.Guid>();
				break;
				case "SenderEmail":
					SenderEmail = reader.GetValue<System.String>();
				break;
				case "newContactId":
					newContactId = reader.GetValue<System.Guid>();
				break;
				case "oldContactId":
					oldContactId = reader.GetValue<System.Guid>();
				break;
				case "newOwnerId":
					newOwnerId = reader.GetValue<System.Guid>();
				break;
				case "oldOwnerId":
					oldOwnerId = reader.GetValue<System.Guid>();
				break;
				case "RecepientsEmailsForDelete":
					RecepientsEmailsForDelete = reader.GetSerializableObjectValue();
				break;
				case "BlindCopyRecepientsEmails":
					BlindCopyRecepientsEmails = reader.GetSerializableObjectValue();
				break;
				case "CopyRecepientsEmails":
					CopyRecepientsEmails = reader.GetSerializableObjectValue();
				break;
				case "RecepientsEmails":
					RecepientsEmails = reader.GetSerializableObjectValue();
				break;
				case "IsDifferentContacts":
					IsDifferentContacts = reader.GetValue<System.Boolean>();
				break;
				case "DeletedValues":
					DeletedValues = reader.GetSerializableObjectValue();
				break;
				case "InsertedValues":
					InsertedValues = reader.GetSerializableObjectValue();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ActivitySavedScriptTaskExecute(ProcessExecutingContext context) {
			return OnActivitySaved(context);
		}

		public virtual bool UpdateRemindingsExecute(ProcessExecutingContext context) {
			GenerateRemindings();
			return true;
		}

		public virtual bool ActivitySavingScriptTaskExecute(ProcessExecutingContext context) {
			return OnActivitySaving(context);
		}

		public virtual bool ScriptActivityInsertingExecute(ProcessExecutingContext context) {
			return OnActivityInserting(context);
		}

		public virtual bool ActivityDefColumnValuesSetScriptTaskExecute(ProcessExecutingContext context) {
			if (Entity.Schema.FindSchemaColumnByPath("StartDate") != null && 
				Entity.Schema.FindSchemaColumnByPath("DueDate") != null) {
				var startDate = Entity.GetTypedColumnValue<DateTime>("StartDate");
				if (startDate == DateTime.MinValue) {
					startDate = UserConnection.CurrentUser.GetCurrentDateTime();
					int startMinute = startDate.Minute;
					startMinute = (((startMinute / 5) + 2 * (startMinute % 5) / 5) * 5) % 60;
					var val = startDate.AddMinutes(-startDate.Minute);
					startDate = val.AddMinutes(startMinute);
					startDate = startDate.AddSeconds(-startDate.Second);
					Entity.SetColumnValue("StartDate", startDate);
					Entity.SetColumnValue("DueDate", startDate.AddMinutes(30));
				}
				var dueDate = Entity.GetTypedColumnValue<DateTime>("DueDate");
				if (dueDate == DateTime.MinValue) {
					Entity.SetColumnValue("DueDate", startDate.AddMinutes(30));
				}
			}
			return true;
		}

		public virtual bool ActivityDeletingScriptTaskExecute(ProcessExecutingContext context) {
			return ActivityDeleting(context);
		}

		public virtual bool SynchronizeSubjectRemindingOwnerScriptExecute(ProcessExecutingContext context) {
			var ownerRemindingSourceTypeId = new Guid("a76d08e1-2e2d-e011-ac0a-00155d043205");
			var remindToOwner = Entity.GetTypedColumnValue<bool>("RemindToOwner");
			var owner = Entity.GetTypedColumnValue<Guid>("OwnerId");
			if (remindToOwner && (newOwnerId.IsNotEmpty() && !newOwnerId.Equals(oldOwnerId))) {
				SynchronizeSubjectRemindingOwner.IsSingleReminder = true;
			}
			var remindToOwnerDate = Entity.GetTypedColumnValue<DateTime>("RemindToOwnerDate");
			if (remindToOwnerDate == null || remindToOwnerDate.Equals(DateTime.MinValue)) {
				remindToOwnerDate = Entity.GetTypedColumnValue<DateTime>("StartDate");
			}
			PrepereSynchronizeSubjectRemindingUserTask(
				SynchronizeSubjectRemindingOwner, 
				owner, 
				remindToOwnerDate, 
				(bool)remindToOwner,
				ownerRemindingSourceTypeId
			);
			return true;
		}

		public virtual bool SynchronizeSubjectRemindingAuthorScriptExecute(ProcessExecutingContext context) {
			var authorRemindingSourceTypeId = new Guid("a66d08e1-2e2d-e011-ac0a-00155d043205");
			var remindToAuthor = Entity.GetTypedColumnValue<bool>("RemindToAuthor");
			var author = Entity.GetTypedColumnValue<Guid>("AuthorId");
			var remindToAuthorDate = Entity.GetTypedColumnValue<DateTime>("RemindToAuthorDate");
			if (remindToAuthorDate == null || remindToAuthorDate.Equals(DateTime.MinValue)) {
				remindToAuthorDate = Entity.GetTypedColumnValue<DateTime>("DueDate");
			}
			PrepereSynchronizeSubjectRemindingUserTask(
				SynchronizeSubjectRemindingAuthor, 
				author, 
				remindToAuthorDate, 
				(bool)remindToAuthor,
				authorRemindingSourceTypeId
			);
			return true;
		}

		public virtual bool ScriptActivityInsertedExecute(ProcessExecutingContext context) {
			return OnActivityInserted(context);
		}

		public virtual bool ActivityUpdatedScriptTask_42f1f750f7be4667b75eeb7454a4a25dExecute(ProcessExecutingContext context) {
			OnActivityUpdated_aa5f074ac858455d865435cc7584e9ca(context);
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Activity_Base_TerrasoftSaved":
							if (ActivatedEventElements.Contains("StartMessageActivitySaved")) {
							context.QueueTasks.Enqueue("StartMessageActivitySaved");
						}
						break;
					case "Activity_Base_TerrasoftSaving":
							if (ActivatedEventElements.Contains("ActivitySavingStartMessage")) {
							context.QueueTasks.Enqueue("ActivitySavingStartMessage");
						}
						break;
					case "Activity_Base_TerrasoftInserting":
							if (ActivatedEventElements.Contains("ActivityInserting")) {
							context.QueueTasks.Enqueue("ActivityInserting");
						}
						break;
					case "Activity_Base_TerrasoftDefColumnValuesSet":
							if (ActivatedEventElements.Contains("ActivityDefColumnValuesSet")) {
							context.QueueTasks.Enqueue("ActivityDefColumnValuesSet");
						}
						break;
					case "Activity_Base_TerrasoftDeleting":
							if (ActivatedEventElements.Contains("ActivityDeletingStartMessage")) {
							context.QueueTasks.Enqueue("ActivityDeletingStartMessage");
						}
						break;
					case "SynchronizeRemindings":
							if (ActivatedEventElements.Contains("SynchronizeRemindingsStartMessage")) {
							context.QueueTasks.Enqueue("SynchronizeRemindingsStartMessage");
						}
						break;
					case "Activity_Base_TerrasoftInserted":
							if (ActivatedEventElements.Contains("ActivityInserted")) {
							context.QueueTasks.Enqueue("ActivityInserted");
						}
						break;
					case "Activity_Base_TerrasoftUpdated":
							if (ActivatedEventElements.Contains("StartMessage3_9d37e41aabe548ae868128ec71992033")) {
							context.QueueTasks.Enqueue("StartMessage3_9d37e41aabe548ae868128ec71992033");
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
			if (EmailParticipantHelper != null) {
				if (EmailParticipantHelper.GetType().IsSerializable ||
					EmailParticipantHelper.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("EmailParticipantHelper", EmailParticipantHelper, null);
				}
			}
			if (!HasMapping("IsNeedAutoEmailRelation") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsNeedAutoEmailRelation", IsNeedAutoEmailRelation, false);
			}
			if (!HasMapping("IsNew") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsNew", IsNew, false);
			}
			if (!HasMapping("SenderId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SenderId", SenderId, Guid.Empty);
			}
			if (!HasMapping("SenderEmail") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SenderEmail", SenderEmail, null);
			}
			if (!HasMapping("newContactId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("newContactId", newContactId, Guid.Empty);
			}
			if (!HasMapping("oldContactId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("oldContactId", oldContactId, Guid.Empty);
			}
			if (!HasMapping("newOwnerId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("newOwnerId", newOwnerId, Guid.Empty);
			}
			if (!HasMapping("oldOwnerId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("oldOwnerId", oldOwnerId, Guid.Empty);
			}
			if (RecepientsEmailsForDelete != null) {
				if (RecepientsEmailsForDelete.GetType().IsSerializable ||
					RecepientsEmailsForDelete.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("RecepientsEmailsForDelete", RecepientsEmailsForDelete, null);
				}
			}
			if (BlindCopyRecepientsEmails != null) {
				if (BlindCopyRecepientsEmails.GetType().IsSerializable ||
					BlindCopyRecepientsEmails.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("BlindCopyRecepientsEmails", BlindCopyRecepientsEmails, null);
				}
			}
			if (CopyRecepientsEmails != null) {
				if (CopyRecepientsEmails.GetType().IsSerializable ||
					CopyRecepientsEmails.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("CopyRecepientsEmails", CopyRecepientsEmails, null);
				}
			}
			if (RecepientsEmails != null) {
				if (RecepientsEmails.GetType().IsSerializable ||
					RecepientsEmails.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("RecepientsEmails", RecepientsEmails, null);
				}
			}
			if (!HasMapping("IsDifferentContacts") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsDifferentContacts", IsDifferentContacts, false);
			}
			if (DeletedValues != null) {
				if (DeletedValues.GetType().IsSerializable ||
					DeletedValues.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("DeletedValues", DeletedValues, null);
				}
			}
			if (InsertedValues != null) {
				if (InsertedValues.GetType().IsSerializable ||
					InsertedValues.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("InsertedValues", InsertedValues, null);
				}
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: Activity_BaseEventsProcess

	/// <exclude/>
	public class Activity_BaseEventsProcess : Activity_BaseEventsProcess<Activity_Base_Terrasoft>
	{

		public Activity_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Activity_BaseEventsProcess

	public partial class Activity_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual Guid FindEmailSendStatusByCode(string emailSendStatusCode) {
			var emailSendStatusSchemaQuery = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "EmailSendStatus") {
				UseAdminRights = GlobalAppSettings.FeatureUseAdminRightsInEmbeddedLogic,
				Cache = UserConnection.ApplicationCache,
				CacheItemName = string.Format("EmailSendStatus_GetByCode_{0}", emailSendStatusCode)
			};
			emailSendStatusSchemaQuery.PrimaryQueryColumn.IsAlwaysSelect = true;
			var codeQueryColumn = emailSendStatusSchemaQuery.AddColumn("Code");
			emailSendStatusSchemaQuery.Filters.Add(
				emailSendStatusSchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "Code", emailSendStatusCode));
			var entityCollection = emailSendStatusSchemaQuery.GetEntityCollection(UserConnection);
			if (entityCollection.Count > 0) {
				return entityCollection[0].PrimaryColumnValue;
			}
			return Guid.Empty;
		}

		public virtual string FindActivityTypeCodeById(Guid activityTypeId) {
			var activityTypeCode = string.Empty;
			var activitySchemaQuery = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "ActivityType") {
				UseAdminRights = GlobalAppSettings.FeatureUseAdminRightsInEmbeddedLogic,
				Cache = UserConnection.ApplicationCache,
				CacheItemName = string.Format("ActivityType_GetCodeById_{0}", activityTypeId)
			};
			activitySchemaQuery.PrimaryQueryColumn.IsAlwaysSelect = true;
			var codeQueryColumn = activitySchemaQuery.AddColumn("Code");
			var activityTypeEntity = activitySchemaQuery.GetEntity(UserConnection, activityTypeId);
			if (activityTypeEntity != null) {
				activityTypeCode = activityTypeEntity.GetTypedColumnValue<string>(codeQueryColumn.Name);
			}
			return activityTypeCode;
		}

		public virtual void SetEmailParticipants() {
			var entity = Entity;
			string senderEmail = SenderEmail;
			var recepientsEmails = (List<string>)RecepientsEmails;
			var copyRecepientsEmails = (List<string>)CopyRecepientsEmails;
			var blindCopyRecepientsEmails = (List<string>)BlindCopyRecepientsEmails;
			var recepientsEmailsForDelete = (List<string>)RecepientsEmailsForDelete;
			RemoveEmailParticipants();
			var emails = GetUsedEmails();
			if (emails.Count == 0) {
				return;
			}
			if (senderEmail == null) {
				senderEmail = GetSenderEmail();
			}
			var contacts = ContactUtilities.GetContactsByEmails(UserConnection, emails);
			Dictionary<string, Guid> participantRoles = new Dictionary<string, Guid>();
			Dictionary<Guid, string[]> rolesToEmailsResolverDictionary = new Dictionary<Guid, string[]>();
			if (contacts.Count > 0) {
				participantRoles = ActivityUtils.GetParticipantsRoles(UserConnection);
				rolesToEmailsResolverDictionary.Add(participantRoles["To"], recepientsEmails.ToArray());
				rolesToEmailsResolverDictionary.Add(participantRoles["CC"], copyRecepientsEmails.ToArray());
				rolesToEmailsResolverDictionary.Add(participantRoles["From"], new string[] {senderEmail});
				rolesToEmailsResolverDictionary.Add(participantRoles["BCC"], blindCopyRecepientsEmails.ToArray());
			}
			foreach (KeyValuePair<Guid, string> contact in contacts) {
				string email = contact.Value;
				Guid contactId = contact.Key;
				foreach (var resolverValue in rolesToEmailsResolverDictionary) {
					if (resolverValue.Value.Contains(email, StringComparer.OrdinalIgnoreCase)) {
						AddActivityParticipantToInsertedValues(
							contactId, 
							new Dictionary<string, object> {
									{"ReadMark", resolverValue.Key.Equals(participantRoles["From"])},
									{"RoleId", resolverValue.Key}
							},
							true
						);
					} 
				}
			}
		}

		public virtual List<string> GetEmailsByFormatedEmails(string formatedEmails) {
			return formatedEmails.ParseEmailAddress();
		}

		public virtual List<string> GetRecepientsForAdding(List<string> newRecepientsEmails, List<string> oldRecepientsEmails) {
			var recepientsEmailForAdding = new List<string>();
			foreach(var email in newRecepientsEmails) {
				if (!oldRecepientsEmails.Contains(email)) {
					recepientsEmailForAdding.Add(email);
				}
			}
			return recepientsEmailForAdding;
		}

		public virtual List<string> GetRecepientsEmailsForDelete(List<string> newRecepientsEmails, List<string> oldRecepientsEmails) {
			var participantsEmailsForDelete = new List<string>();
			foreach (var email in oldRecepientsEmails){
				if (!newRecepientsEmails.Contains(email)) {
					participantsEmailsForDelete.Add(email);
				}
			}
			return participantsEmailsForDelete;
		}

		public virtual void RemoveEmailParticipants() {
			var recepientEmails = RecepientsEmailsForDelete as List<string>;
			if ((recepientEmails != null) && (recepientEmails.Count > 0)) {
				var queryParameters = recepientEmails.Select(item => new QueryParameter(item)).ToList();
				new Delete(UserConnection)
					.From("ActivityParticipant")
					.Where("ActivityId").IsEqual(Column.Parameter(Entity.PrimaryColumnValue))
					.And("ParticipantId").In(
						new Select(UserConnection)
							.Column("Id")
							.From("Contact")
							.Where("Email").In(queryParameters)).Execute();
			}
		}

		public virtual void UpdateParticipantsByOwnerContact() {
			DeleteOldOwnerAndContactParticipants();
			var participantRoles = ActivityUtils.GetParticipantsRoles(UserConnection);
			if ((newOwnerId != oldOwnerId) && (newOwnerId != Guid.Empty) && (newOwnerId != SenderId)) {
				AddActivityParticipantToInsertedValues(
					newOwnerId, 
					new Dictionary<string, object> {
						{"RoleId", participantRoles["Responsible"]}
					},
					true
				);
				if (oldOwnerId != Guid.Empty) {
					var authorColumn = Entity.Schema.Columns.FindByName("Author");
					if (authorColumn != null) {
						var authorId = Entity.GetTypedColumnValue<Guid>(authorColumn.ColumnValueName);
						AddActivityParticipantToInsertedValues(
							authorId, 
							new Dictionary<string, object> {
								{"RoleId", participantRoles["Participant"]}
							}, 
							false
						);
					}
				}
			}
			if ((newContactId != oldContactId) && (newContactId != Guid.Empty) && (newContactId != newOwnerId) && (newContactId != SenderId)) {
				AddActivityParticipantToInsertedValues(
					newContactId,
					new Dictionary<string, object> {
						{"RoleId", participantRoles["Participant"]}
					},
					false
				);
			}
		}

		public virtual string GetSenderEmail() {
			var senderColumn = Entity.Schema.Columns.FindByName("Sender");
			if (senderColumn != null) {
				string sender = Entity.GetTypedColumnValue<string>(senderColumn.ColumnValueName);
				string[] strSplit = sender.Split(new string[] {"<", "<"}, sender.Length, StringSplitOptions.None);
				string result = strSplit[1].Replace(">", "").Replace(">", "").Replace(" ", "");
				return result;
			} else {
				return null;
			}
		}

		public virtual void SetParticipantSender() {
			if (Entity.MessageTypeId == Terrasoft.Configuration.ActivityConsts.OutgoingEmailTypeId) {
				var senderColumn = Entity.Schema.Columns.FindByName("Sender");
				if (senderColumn == null) {
					return;
				}
				string sender = Entity.GetTypedColumnValue<string>(senderColumn.ColumnValueName);
				string[] strSplit = sender.Split(new string[] {"<", ">"}, sender.Length, StringSplitOptions.None);
				if (strSplit.Length == 0) {
					return;
				}
				string senderName = strSplit[0];
				Dictionary<string, Guid> participantRoles = ActivityUtils.GetParticipantsRoles(UserConnection);
				var entitySchemaManager = UserConnection.EntitySchemaManager;
				var contactESQ = new EntitySchemaQuery(entitySchemaManager, "Contact") {
					UseAdminRights = GlobalAppSettings.FeatureUseAdminRightsInEmbeddedLogic
				};
				contactESQ.PrimaryQueryColumn.IsAlwaysSelect = true;
				contactESQ.Filters.Add(
					contactESQ.CreateFilterWithParameters(
						FilterComparisonType.Equal, "Name",	senderName));
				EntitySchemaQueryColumn createdOn = contactESQ.AddColumn("CreatedOn");
				createdOn.OrderDirection = OrderDirection.Ascending; 
				var contactCollection = contactESQ.GetEntityCollection(UserConnection);
				if(contactCollection.Count > 0) {
					var contactEntity = contactCollection[0];
					AddActivityParticipantToInsertedValues(
						contactEntity.PrimaryColumnValue, 
						new Dictionary<string, object> {
							{"RoleId", participantRoles["From"]}
						},
						false
					);
				}
			}
		}

		public virtual List<string> GetUsedEmails() {
			var emails = new List<string>() {SenderEmail};
			return Enumerable.Union(
				Enumerable.Union((IEnumerable<string>)emails, (IEnumerable<string>)RecepientsEmails),
				Enumerable.Union((IEnumerable<string>)CopyRecepientsEmails,(IEnumerable<string>)BlindCopyRecepientsEmails))
				.ToList();
		}

		public virtual void SetFromParticipantOnSent() {
			Dictionary<string, Guid> participantRoles = ActivityUtils.GetParticipantsRoles(UserConnection);
			Guid contactId = UserConnection.CurrentUser.ContactId;
			AddActivityParticipantToInsertedValues(
				contactId, 
				new Dictionary<string, object> {
					{"RoleId", participantRoles["From"]},
					{"ReadMark", true}
				},
				false
			);
		}

		public virtual void UpdateParticipantsByOwnerContactEmail() {
			DeleteOldOwnerAndContactParticipants();
			Dictionary<string, Guid> participantRoles = ActivityUtils.GetParticipantsRoles(UserConnection);
			bool isOutgoing = Entity.MessageTypeId == Terrasoft.Configuration.ActivityConsts.OutgoingEmailTypeId;
			if (newOwnerId != Guid.Empty) {
				AddActivityParticipantToInsertedValues(
					newOwnerId, 
					new Dictionary<string, object> {
						{"ReadMark", isOutgoing},
						{"RoleId", participantRoles["Responsible"]}
					},
					true
				);
				if ((newOwnerId != oldOwnerId) && (oldOwnerId != Guid.Empty)) {
					var authorColumn = Entity.Schema.Columns.FindByName("Author");
					if (authorColumn != null) {
						Guid authorId = Entity.GetTypedColumnValue<Guid>(authorColumn.ColumnValueName);
						AddActivityParticipantToInsertedValues(
							authorId, 
							new Dictionary<string, object> {
								{"RoleId", participantRoles["Participant"]}
							}, 
							false
						);
					}
				}
			}
			if (newContactId != Guid.Empty && (newContactId != SenderId || isOutgoing)) {
				AddActivityParticipantToInsertedValues(
					newContactId,
					new Dictionary<string, object>() {
						{"ReadMark", isOutgoing},
						{"RoleId", participantRoles["Participant"]}
					},
					false
				);
			}
		}

		public virtual void DeleteOldOwnerAndContactParticipants() {
			Dictionary<string, Guid> participantRoles = ActivityUtils.GetParticipantsRoles(UserConnection);
			if ((newOwnerId != oldOwnerId) && (oldOwnerId != Guid.Empty)) {
				var del = new Delete(UserConnection).From("ActivityParticipant")
					.Where("ActivityId").IsEqual(Column.Parameter(Entity.PrimaryColumnValue)).
					And("ParticipantId").IsEqual(Column.Parameter(oldOwnerId)).
					And("RoleId").Not().IsEqual(Column.Parameter(participantRoles["To"])).
					And("RoleId").Not().IsEqual(Column.Parameter(participantRoles["CC"])).
					And("RoleId").Not().IsEqual(Column.Parameter(participantRoles["BCC"])).
					And("RoleId").Not().IsEqual(Column.Parameter(participantRoles["From"])) as Delete;
				del.Execute();
			}
			if ((newContactId != oldContactId) && (oldContactId != Guid.Empty) && (oldContactId != oldOwnerId)) {
				var del = new Delete(UserConnection).From("ActivityParticipant")
					.Where("ActivityId").IsEqual(Column.Parameter(Entity.PrimaryColumnValue)).
					And("ParticipantId").IsEqual(Column.Parameter(oldContactId)).
					And("RoleId").Not().IsEqual(Column.Parameter(participantRoles["To"])).
					And("RoleId").Not().IsEqual(Column.Parameter(participantRoles["CC"])).
					And("RoleId").Not().IsEqual(Column.Parameter(participantRoles["BCC"])).
					And("RoleId").Not().IsEqual(Column.Parameter(participantRoles["From"])) as Delete;
				del.Execute();
			}
		}

		public virtual bool DoCollectEmailParticipants() {
			Guid typeId = Entity.GetTypedColumnValue<Guid>("TypeId");
			return typeId == Terrasoft.Configuration.ActivityConsts.EmailTypeUId;
		}

		public virtual bool ActivityDeleting(ProcessExecutingContext  context) {
			return true;
		}

		public virtual void PrepereSynchronizeSubjectRemindingUserTask(SynchronizeSubjectRemindingUserTask userTask, Guid contact, DateTime remindTime, bool active, Guid source) {
			Guid typeId = Entity.GetTypedColumnValue<Guid>("TypeId");
			var activityTypeQuery = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "ActivityType") {
				UseAdminRights = GlobalAppSettings.FeatureUseAdminRightsInEmbeddedLogic,
				Cache = UserConnection.ApplicationCache,
				CacheItemName = string.Format("ActivityType_GetNameById_{0}", typeId)
			};
			activityTypeQuery.PrimaryQueryColumn.IsAlwaysSelect = true;
			var nameColumn = activityTypeQuery.AddColumn("Name");
			var activityTypeEntity = activityTypeQuery.GetEntity(UserConnection, typeId);
			if (activityTypeEntity != null) {
				userTask.TypeCaption = activityTypeEntity.GetTypedColumnValue<string>(nameColumn.Name);
			}
			userTask.IsSubjectDelete = Entity.IsInDeleting;
			userTask.Active = !Entity.IsInDeleting && !IsFinalStatus() && active;
			userTask.SubjectPrimaryColumnValue = Entity.PrimaryColumnValue;
			userTask.Contact = contact;
			userTask.Source = source;
			userTask.RemindTime = remindTime;
			userTask.SysEntitySchema = Entity.Schema.UId;
			userTask.Description = Entity.GetTypedColumnValue<string>("Title");
			userTask.NotificationType = RemindingConsts.NotificationTypeRemindingId;
		}

		public virtual bool IsFinalStatus() {
			Guid statusId = Entity.GetTypedColumnValue<Guid>("StatusId");
			var entitySchemaQuery = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "ActivityStatus") {
				UseAdminRights = GlobalAppSettings.FeatureUseAdminRightsInEmbeddedLogic,
				Cache = UserConnection.ApplicationCache,
				CacheItemName = string.Format("ActivityStatus_GetFinishById_{0}", statusId)
			};
			string finalColumnName = entitySchemaQuery.AddColumn("Finish").Name;
			var entity = entitySchemaQuery.GetEntity(UserConnection, statusId);
			if (entity != null) {
				return entity.GetTypedColumnValue<bool>(finalColumnName);
			}
			return false;
		}

		public virtual void SetActivityParticipantProcessPropertyValue(Entity activityParticipant, string propertyName, object value) {
			activityParticipant.Process.SetPropertyValue(propertyName, value);
		}

		public virtual void AddActivityParticipantToInsertedValues(Guid participantId, Dictionary<string, object> participantParams, bool overrideExistingParticipant) {
			var insertedValues = (InsertedValues as Dictionary<Guid, object>) ?? new Dictionary<Guid, object>();
			InsertedValues = insertedValues;
			if (overrideExistingParticipant || !insertedValues.ContainsKey(participantId)) {
				insertedValues[participantId] = participantParams;
			}
		}

		public virtual bool OnActivitySaved(ProcessExecutingContext context) {
			SetActivityParticipantRightsOnSaved();
			string typeColumnValueName = Entity.Schema.Columns.FindByName("Type").ColumnValueName;
			Guid typeId = Entity.GetTypedColumnValue<Guid>(typeColumnValueName);
						if (typeId == Terrasoft.Configuration.ActivityConsts.EmailTypeUId) {
							InitializeEmailParticipantHelper().InitializeParameters(Entity);
							AutoEmailRelationProceed();
							InitializeEmailParticipantHelper().SetEmailParticipants();
						} else {
							UpdateParticipantsByOwnerContact();
							SynchronizeActivityOnSaved();
							AutoEmailRelationProceed();
							CreateActivityParticipantsFromInsertedValues();
						}
						return true;
		}

		public virtual void SetActivityParticipantRightsOnSaved() {
			Guid author = Entity.GetTypedColumnValue<Guid>("AuthorId");
			Guid owner = Entity.GetTypedColumnValue<Guid>("OwnerId");
			IsDifferentContacts = !author.Equals(owner);
			if (Entity.GetTypedColumnValue<Guid>("EmailSendStatusId") == Terrasoft.Configuration.ActivityConsts.IncomingEmailTypeId) {
				var entitySchemaQuery = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "SysAdminUnit") {
					UseAdminRights = GlobalAppSettings.FeatureUseAdminRightsInEmbeddedLogic
				};
				entitySchemaQuery.PrimaryQueryColumn.IsAlwaysSelect = true;
				entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
					"[ContactCommunication:Contact:Contact].Number", SenderEmail));
				var entities = entitySchemaQuery.GetEntityCollection(UserConnection);
				if (entities.Count > 0) {
					Guid adminUnitId = entities[0].PrimaryColumnValue;
					UserConnection.DBSecurityEngine.SetEntitySchemaRecordRightLevel(adminUnitId, Entity.Schema,
						Entity.PrimaryColumnValue, SchemaRecordRightLevels.All); 
				}
				entitySchemaQuery = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "SysAdminUnit") {
					UseAdminRights = GlobalAppSettings.FeatureUseAdminRightsInEmbeddedLogic
				};
				entitySchemaQuery.PrimaryQueryColumn.IsAlwaysSelect = true;
				entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
					"Contact", owner));
				entities = entitySchemaQuery.GetEntityCollection(UserConnection);
				if (entities.Count > 0) {
						Guid adminUnitId = entities[0].PrimaryColumnValue;
						UserConnection.DBSecurityEngine.SetEntitySchemaRecordRightLevel(adminUnitId, Entity.Schema,
							Entity.PrimaryColumnValue, SchemaRecordRightLevels.All); 
				}
			}
		}

		public virtual void SynchronizeActivityOnSaved() {
			//оставил метод для обратной совместимости
		}

		public virtual bool OnActivitySaving(ProcessExecutingContext context) {
			SaveOldValuesOnSaving();
			SetRemindDatesOnSaving();
			CalculateDurationOnSaving();
			SavingEmailOnSaving();
			SetTypeByCategoryOnSaving();
			CheckNeedAutoEmailRelation();
			InitCanGenerateAnniversaryReminding();
			return true;
		}

		public virtual void SaveOldValuesOnSaving() {
			//оставил метод для обратной совместимости
			if (InsertedValues == null) {
				InsertedValues = new Dictionary<Guid, object>();
			}
		}

		public virtual void CalculateDurationOnSaving() {
			TimeSpan duration = Entity.DueDate - Entity.StartDate;
			Entity.DurationInMinutes = (int)duration.TotalMinutes;
			Entity.DurationInMnutesAndHours = String.Concat((int)duration.TotalHours, Hour, duration.Minutes, Minute);
		}

		public virtual void SavingEmailOnSaving() {
			string ownerIdColumnName = Entity.Schema.Columns.GetByName("Owner").ColumnValueName;
			string contactIdColumnName = Entity.Schema.Columns.GetByName("Contact").ColumnValueName;
			if (Entity.GetColumnOldValue(ownerIdColumnName) != null) {
				oldOwnerId = new Guid(Entity.GetColumnOldValue(ownerIdColumnName).ToString());
			}
			if (Entity.GetColumnOldValue(contactIdColumnName) != null) {
				oldContactId = new Guid(Entity.GetColumnOldValue(contactIdColumnName).ToString());
			}
			if (Entity.GetColumnValue(ownerIdColumnName) != null) {
				newOwnerId = new Guid(Entity.GetColumnValue(ownerIdColumnName).ToString());
			}
			if (Entity.GetColumnValue(contactIdColumnName) != null) {
				newContactId = new Guid(Entity.GetColumnValue(contactIdColumnName).ToString());
			}
			if (!DoCollectEmailParticipants()) {
				return;
			}
			InitializeEmailParticipantHelper().InitializeParameters(Entity);
			string body = (string)Entity.GetColumnValue("Body");
			Entity.SetColumnValue("Preview", StringUtilities.GetPlainTextFromHtml(body, 245));
			if (Entity.GetColumnValue("SendDate") != null) {
				string hash = Entity.GetTypedColumnValue<string>("MailHash");
				if (string.IsNullOrEmpty(hash)) {
					string title = (string)Entity.GetColumnValue("Title");
					DateTime sendDate = (DateTime)Entity.GetColumnValue("SendDate");
					hash = ActivityUtils.GetEmailHash(UserConnection, sendDate, title, body, UserConnection.CurrentUser.TimeZone);
					Entity.SetColumnValue("MailHash", hash);
				}
			}
			EmailRightsManager rightsManager = GetEmailRightsManager();
			rightsManager.SetUseDefRights(Entity);
		}

		public virtual void SetTypeByCategoryOnSaving() {
			if (Entity.GetTypedColumnValue<Guid>("TypeId") == Guid.Empty) {
				Guid categoryId = Entity.GetTypedColumnValue<Guid>("ActivityCategoryId");
				var schemaQuery = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "ActivityCategory") {
					UseAdminRights = GlobalAppSettings.FeatureUseAdminRightsInEmbeddedLogic,
					Cache = UserConnection.ApplicationCache,
					CacheItemName = string.Format("ActivityCategory_GetActivityTypeById_{0}", categoryId)
				};
				var typeColumn = schemaQuery.AddColumn("ActivityType.Id");
				var category = schemaQuery.GetEntity(UserConnection, categoryId);
				Entity.SetColumnValue("TypeId", category.GetTypedColumnValue<Guid>(typeColumn.Name));
			};
		}

		public virtual bool OnActivityInserting(ProcessExecutingContext context) {
			string activityTypeColumnName = Entity.Schema.Columns.GetByName("Type").ColumnValueName;
			Guid activityTypeId = Entity.GetTypedColumnValue<Guid>(activityTypeColumnName);
			string activityTypeCode = FindActivityTypeCodeById(activityTypeId);
			if (activityTypeCode == "Email") { 
				if (Entity.EmailSendStatusId.IsEmpty()) {
					Guid notSendStatusId = FindEmailSendStatusByCode("NotSend");
					Entity.EmailSendStatusId = notSendStatusId;
				}
				Entity.SetColumnValue("IsNeedProcess", true);
			}
			InitializeEmailParticipantHelper().InitializeParameters(Entity);
			InitializeEmailParticipantHelper().IsNew = true;
			IsNew = true;
			return true;
		}

		public virtual void CreateActivityParticipantsFromInsertedValues() {
			var insertedValues = InsertedValues as System.Collections.Generic.Dictionary<Guid, object>;
			foreach(var kvp in insertedValues) {
				var participantParams = kvp.Value as Dictionary<string, object>;
				if (participantParams != null) {
					var activityParticipantSchema = UserConnection.EntitySchemaManager.GetInstanceByName("ActivityParticipant");
					var activityParticipant = activityParticipantSchema.CreateEntity(UserConnection);
					activityParticipant.UseAdminRights = GlobalAppSettings.FeatureUseAdminRightsInEmbeddedLogic;
					activityParticipant.SetDefColumnValues();
					activityParticipant.SetColumnValue("ActivityId", Entity.PrimaryColumnValue);
					activityParticipant.SetColumnValue("ParticipantId", kvp.Key);
					foreach(var parameter in participantParams) {
						activityParticipant.SetColumnValue(parameter.Key, parameter.Value);
					}
					if (IsNew) {
						SetActivityParticipantProcessPropertyValue(activityParticipant, "IsUnique", true);
					}
					activityParticipant.Save();
				}
			}
		}

		public virtual bool OnActivityInserted(ProcessExecutingContext context) {
			EmailRightsManager rightsManager = GetEmailRightsManager();
			rightsManager.SetAuthorRights(Entity);
			string typeColumnValueName = Entity.Schema.Columns.FindByName("Type").ColumnValueName;
			Guid typeId = Entity.GetTypedColumnValue<Guid>(typeColumnValueName);
			if (typeId == Terrasoft.Configuration.ActivityConsts.EmailTypeUId && Entity.GetColumnValue("SendDate") == null) {
				EmailMessageHelper helper = ClassFactory.Get<EmailMessageHelper>(
						new ConstructorArgument("userConnection", UserConnection));
				helper.CreateEmailMessage(Entity, Guid.Empty);
			}
			return true;
		}

		public virtual void SetEmailIsNeedProcess() {
			var id = Entity.GetTypedColumnValue<Guid>("Id");
			var contactIsEmpty = Guid.Empty == Entity.GetTypedColumnValue<Guid>("Contact");
			var accountIsEmpty = Guid.Empty == Entity.GetTypedColumnValue<Guid>("Account");
			var thirdPartEntitiesIsEmpty = true;
			var schemaUId = Entity.InstanceUId;
			
			var esq = new EntitySchemaQuery(Entity.EntitySchemaManager, "EntityConnection") {
				UseAdminRights = GlobalAppSettings.FeatureUseAdminRightsInEmbeddedLogic
			};
			var columnUIdName = esq.AddColumn("ColumnUId").Name;
			esq.CreateFilterWithParameters(FilterComparisonType.Equal, "SysEntitySchemaUId", schemaUId);
			var activityConnections = esq.GetEntityCollection(UserConnection);
			
			foreach (var activityConnection in activityConnections) {
				var columnName = Entity.Schema.Columns.GetByUId(activityConnection.GetTypedColumnValue<Guid>(columnUIdName));
				if (Entity.GetTypedColumnValue<Guid>(columnName) != Guid.Empty) {
					thirdPartEntitiesIsEmpty = false;
				}
			}
			
			var update = (Update)new Update(UserConnection, "Activity").Where("Id").IsEqual(Column.Parameter(id));
			var needUpdate = false;
			if (contactIsEmpty && accountIsEmpty) {
				update.Set("IsNeedProcess", Column.Parameter(true));
				needUpdate = true;
			}
			if (!contactIsEmpty && !accountIsEmpty && thirdPartEntitiesIsEmpty) {
				update.Set("IsNeedProcess", Column.Parameter(true));
				needUpdate = true;
			}
			if (needUpdate) {
				update.Execute();
			}
		}

		public virtual void AutoEmailRelationProceed() {
			if (IsNeedAutoEmailRelation) {
				var autoEmailRelation = new Terrasoft.Configuration.AutoEmailRelation.AutoEmailRelation(UserConnection);
				autoEmailRelation.ProceedRelation(Entity);
			}
		}

		public virtual void CheckNeedAutoEmailRelation() {
			if (Entity.GetTypedColumnValue<Guid>("TypeId") != Terrasoft.Configuration.ActivityConsts.EmailTypeUId) {
				return;
			}
			
			IsNeedAutoEmailRelation = false;
			
			string titleValue = Entity.GetTypedColumnValue<string>("Title");
			string titleOldValue = Entity.GetTypedOldColumnValue<string>("Title");
			if (titleValue != titleOldValue) {
				IsNeedAutoEmailRelation = true;
				return;
			}
			
			string senderValue = Entity.GetTypedColumnValue<string>("Sender");
			string senderOldValue = Entity.GetTypedOldColumnValue<string>("Sender");
			if (senderValue != senderOldValue) {
				IsNeedAutoEmailRelation = true;
				return;
			}
			
			string recepientValue = Entity.GetTypedColumnValue<string>("Recepient");
			string recepientcOldValue = Entity.GetTypedOldColumnValue<string>("Recepient");
			if (recepientValue != recepientcOldValue) {
				IsNeedAutoEmailRelation = true;
				return;
			}
			
			string copyRecepientValue = Entity.GetTypedColumnValue<string>("CopyRecepient");
			string copyRecepientOldValue = Entity.GetTypedOldColumnValue<string>("CopyRecepient");
			if (copyRecepientValue != copyRecepientOldValue) {
				IsNeedAutoEmailRelation = true;
				return;
			}
			
			string blindCopyRecepientValue = Entity.GetTypedColumnValue<string>("BlindCopyRecepient");
			string blindCopyRecepientOldValue = Entity.GetTypedOldColumnValue<string>("BlindCopyRecepient");
			if (blindCopyRecepientValue != blindCopyRecepientOldValue) {
				IsNeedAutoEmailRelation = true;
				return;
			}
		}

		public virtual EmailParticipantHelper InitializeEmailParticipantHelper() {
			EmailParticipantHelper = EmailParticipantHelper ??
							ClassFactory.Get<EmailParticipantHelper>(new ConstructorArgument("userConnection", UserConnection));
				return (EmailParticipantHelper)EmailParticipantHelper;
		}

		public virtual void SetRemindDatesOnSaving() {
			var newStartDate = Entity.GetTypedColumnValue<DateTime>("StartDate");
			var oldStartDate = Entity.GetTypedOldColumnValue<DateTime>("StartDate");
			
			if(!oldStartDate.Equals(DateTime.MinValue) && !newStartDate.Equals(oldStartDate)) {
				var dateDiff = newStartDate.Subtract(oldStartDate);
				var hasAuthorRemind = Entity.GetTypedColumnValue<bool>("RemindToAuthor");
				var hasOwnerRemind = Entity.GetTypedColumnValue<bool>("RemindToOwner");
				if (hasAuthorRemind) {
					var authorRemindDate = Entity.GetTypedColumnValue<DateTime>("RemindToAuthorDate");
					var oldAuthorRemindDate = Entity.GetTypedOldColumnValue<DateTime>("RemindToAuthorDate");
					if (authorRemindDate.Equals(oldAuthorRemindDate) && authorRemindDate > DateTime.MinValue) {
						authorRemindDate = authorRemindDate.Add(dateDiff);
						Entity.SetColumnValue("RemindToAuthorDate", authorRemindDate);
					}
				}
				if (hasOwnerRemind) {
					var ownerRemindDate = Entity.GetTypedColumnValue<DateTime>("RemindToOwnerDate");
					var oldOwnerRemindDate = Entity.GetTypedOldColumnValue<DateTime>("RemindToOwnerDate");
					if (ownerRemindDate.Equals(oldOwnerRemindDate) && ownerRemindDate > DateTime.MinValue) {
						ownerRemindDate = ownerRemindDate.Add(dateDiff);
						Entity.SetColumnValue("RemindToOwnerDate", ownerRemindDate);
					}
				}
			};
		}

		public virtual void OnActivityUpdated_aa5f074ac858455d865435cc7584e9ca(ProcessExecutingContext context) {
			UserConnection.IProcessEngine.SynchronizeProcessNotification(Entity, context);
		}

		public virtual EmailRightsManager GetEmailRightsManager() {
			return ClassFactory.Get<EmailRightsManager>(new ConstructorArgument("userConnection", UserConnection));
		}

		public virtual void InitCanGenerateAnniversaryReminding() {
			bool isNew = Entity.StoringState == StoringObjectState.New;
			bool isContactNotEmpty = Entity.GetTypedColumnValue<Guid>("ContactId").IsNotEmpty();
			bool isAccountNotEmpty = Entity.GetTypedColumnValue<Guid>("AccountId").IsNotEmpty();
			var columns = GetAnniversaryDependentColumns();
			var changedColumns = Entity.GetChangedColumnValues();
			EntityChangedColumns = changedColumns.ToList();
			bool anniversaryColumnsChanged = changedColumns.Any(col => columns.Contains(col.Name));
			CanGenerateAnniversaryReminding = (isContactNotEmpty || isAccountNotEmpty) && anniversaryColumnsChanged;
		}

		public virtual IEnumerable<string> GetAnniversaryDependentColumns() {
			return  new[] { "ContactId", "AccountId", "OwnerId" };
		}

		public virtual IEnumerable<string> GetRemindingOptions() {
			var options = new List<string>();
			var changedColumns = EntityChangedColumns as List<EntityColumnValue> ?? new List<EntityColumnValue>();
			if (changedColumns.Any(col => col.Name == "OwnerId")) {
				options.AddRange(new[] {
					ActivityAnniversaryReminding.AccountOption,
					ActivityAnniversaryReminding.ContactOption,
					ActivityAnniversaryReminding.ParticipantOption
				});
				return options;
			}
			if (changedColumns.Any(col => col.Name == "ContactId")) {
				options.Add(ActivityAnniversaryReminding.ContactOption);
			}
			if (changedColumns.Any(col => col.Name == "AccountId")) {
				options.Add(ActivityAnniversaryReminding.AccountOption);
			}
			return options;
		}

		public virtual void GenerateRemindings() {
			if (!CanGenerateAnniversaryReminding) {
				return;
			}
			Guid id = Entity.GetTypedColumnValue<Guid>("Id");
			if (Entity.GetTypedColumnValue<Guid>("TypeId") != ActivityConsts.EmailTypeUId) {
				ActivityAnniversaryReminding remindingsGenerator = new ActivityAnniversaryReminding(UserConnection, id);
				remindingsGenerator.Options = GetRemindingOptions();
				remindingsGenerator.GenerateActualRemindings();
			}
		}

		#endregion

	}

	#endregion

	#region Class: Activity_Base_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Activity_Base_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public Activity_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Activity_Base_TerrasoftEventsProcessSchema(Activity_Base_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Activity_BaseEventsProcess";
			UId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797");
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

		protected virtual ProcessSchemaParameter CreateInsertedValuesParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("03ae59e8-fd0b-4e0c-8cbc-99e1ac728017"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"InsertedValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDeletedValuesParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6af7872f-04b0-4d24-b894-83cdd244ebf2"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"DeletedValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsDifferentContactsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("bb682892-6d03-4eeb-850a-61962a0d5a00"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"IsDifferentContacts",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateRecepientsEmailsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("030e151b-8b3d-4835-812a-4ed2e787e2ae"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"RecepientsEmails",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCopyRecepientsEmailsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a3257a08-1efc-4b44-9f6c-3b264923b50a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"CopyRecepientsEmails",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateBlindCopyRecepientsEmailsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a1793bb7-1f37-401c-9359-323eb49b63ff"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"BlindCopyRecepientsEmails",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateRecepientsEmailsForDeleteParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("8ea25d04-4b09-4d99-b393-670fcec697b9"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"RecepientsEmailsForDelete",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateoldOwnerIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ba1bf580-d4d1-40ae-a792-da9d71116a69"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"oldOwnerId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreatenewOwnerIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d5b3a0cd-7f26-46ec-aa6b-6090cf6e936d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"newOwnerId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateoldContactIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f957ec50-312d-46d7-a672-a444d7d7b9cc"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"oldContactId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreatenewContactIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2b5bcb47-c0ca-4486-8797-651fce3609ae"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"newContactId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSenderEmailParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6ad87af3-e0c3-467a-aabd-ac027cf87cbf"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"SenderEmail",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSenderIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("05c8800d-7c1e-4178-af4f-eb8ef16626ac"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"SenderId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsNewParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("5c24d57f-a0bc-4079-868a-a8546cc75b41"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"IsNew",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsNeedAutoEmailRelationParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("41ac774d-c30b-49dc-ac8b-97761c4df130"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"IsNeedAutoEmailRelation",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEmailParticipantHelperParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f816138f-ad44-4484-a1ee-a104ba37247b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"EmailParticipantHelper",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCanGenerateAnniversaryRemindingParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("bc942ef6-0f50-4ac2-a068-606ef27f2abd"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"CanGenerateAnniversaryReminding",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEntityChangedColumnsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a138e403-72dd-4f10-8bfd-d54215f07d83"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"EntityChangedColumns",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateInsertedValuesParameter());
			Parameters.Add(CreateDeletedValuesParameter());
			Parameters.Add(CreateIsDifferentContactsParameter());
			Parameters.Add(CreateRecepientsEmailsParameter());
			Parameters.Add(CreateCopyRecepientsEmailsParameter());
			Parameters.Add(CreateBlindCopyRecepientsEmailsParameter());
			Parameters.Add(CreateRecepientsEmailsForDeleteParameter());
			Parameters.Add(CreateoldOwnerIdParameter());
			Parameters.Add(CreatenewOwnerIdParameter());
			Parameters.Add(CreateoldContactIdParameter());
			Parameters.Add(CreatenewContactIdParameter());
			Parameters.Add(CreateSenderEmailParameter());
			Parameters.Add(CreateSenderIdParameter());
			Parameters.Add(CreateIsNewParameter());
			Parameters.Add(CreateIsNeedAutoEmailRelationParameter());
			Parameters.Add(CreateEmailParticipantHelperParameter());
			Parameters.Add(CreateCanGenerateAnniversaryRemindingParameter());
			Parameters.Add(CreateEntityChangedColumnsParameter());
		}

		protected virtual void InitializeSynchronizeSubjectRemindingOwnerParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("5b70dee2-6f75-4a2c-8c33-748945f95ab2"),
				ContainerUId = new Guid("4ebed4c4-db85-492e-ae3e-30ea37ce7801"),
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
				UId = new Guid("44fd6b0c-be8f-46d9-a390-9a7184b1b8bd"),
				ContainerUId = new Guid("4ebed4c4-db85-492e-ae3e-30ea37ce7801"),
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
				UId = new Guid("ac4b02d7-c991-4a5e-a454-12449b7d3b70"),
				ContainerUId = new Guid("4ebed4c4-db85-492e-ae3e-30ea37ce7801"),
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
				UId = new Guid("2b3857b6-0c14-45b7-9400-4a2014aefe06"),
				ContainerUId = new Guid("4ebed4c4-db85-492e-ae3e-30ea37ce7801"),
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
				UId = new Guid("1891bbc3-ae67-4ba6-9968-8b8da1834e2b"),
				ContainerUId = new Guid("4ebed4c4-db85-492e-ae3e-30ea37ce7801"),
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
				UId = new Guid("0dc938d0-9ffe-439b-93f3-58cff27291df"),
				ContainerUId = new Guid("4ebed4c4-db85-492e-ae3e-30ea37ce7801"),
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
				UId = new Guid("d7bdc4f6-b138-48fd-9101-95b0a6d3786b"),
				ContainerUId = new Guid("4ebed4c4-db85-492e-ae3e-30ea37ce7801"),
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
				UId = new Guid("090fa0d5-57d2-4c08-9ef7-f773cab5bf3d"),
				ContainerUId = new Guid("4ebed4c4-db85-492e-ae3e-30ea37ce7801"),
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
				UId = new Guid("421ae7bf-b124-4348-84c0-1703a4f762ee"),
				ContainerUId = new Guid("4ebed4c4-db85-492e-ae3e-30ea37ce7801"),
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
				UId = new Guid("8b1cb224-3623-4766-a91e-b88dbb61b76e"),
				ContainerUId = new Guid("4ebed4c4-db85-492e-ae3e-30ea37ce7801"),
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
				UId = new Guid("52462f01-e118-4c8b-aa44-4a3259f0e9cd"),
				ContainerUId = new Guid("4ebed4c4-db85-492e-ae3e-30ea37ce7801"),
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
				UId = new Guid("6ea552ab-1ba2-43fc-901e-ee5777631913"),
				ContainerUId = new Guid("4ebed4c4-db85-492e-ae3e-30ea37ce7801"),
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
				UId = new Guid("b32e9f3d-33e7-4b19-af87-d245882d3e78"),
				ContainerUId = new Guid("4ebed4c4-db85-492e-ae3e-30ea37ce7801"),
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
				UId = new Guid("0e22e350-89f5-4802-8848-54c566be9eb2"),
				ContainerUId = new Guid("4ebed4c4-db85-492e-ae3e-30ea37ce7801"),
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
				UId = new Guid("2dee85d4-d306-4a8d-ad96-bcf629b9360c"),
				ContainerUId = new Guid("4ebed4c4-db85-492e-ae3e-30ea37ce7801"),
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
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
		}

		protected virtual void InitializeSynchronizeSubjectRemindingAuthorParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("ef533f39-12b2-4f75-856b-7c36c065ea70"),
				ContainerUId = new Guid("4567ea18-f5a1-4ba9-aa5f-b7c4b7a1e09e"),
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
				UId = new Guid("de94dd77-741c-4ccd-b390-6bbe52d61ae3"),
				ContainerUId = new Guid("4567ea18-f5a1-4ba9-aa5f-b7c4b7a1e09e"),
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
				UId = new Guid("34045350-39e5-4d94-80f6-29015513ed2b"),
				ContainerUId = new Guid("4567ea18-f5a1-4ba9-aa5f-b7c4b7a1e09e"),
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
				UId = new Guid("c7606dc3-e21e-4a61-afaa-01085966d198"),
				ContainerUId = new Guid("4567ea18-f5a1-4ba9-aa5f-b7c4b7a1e09e"),
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
				UId = new Guid("0c41dedb-c7e0-4bca-900c-9087d494bdd8"),
				ContainerUId = new Guid("4567ea18-f5a1-4ba9-aa5f-b7c4b7a1e09e"),
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
				UId = new Guid("0af2e75c-7459-46a9-9144-7b476f08e571"),
				ContainerUId = new Guid("4567ea18-f5a1-4ba9-aa5f-b7c4b7a1e09e"),
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
				UId = new Guid("777c0d09-3373-4ad6-8110-7403e75b35cb"),
				ContainerUId = new Guid("4567ea18-f5a1-4ba9-aa5f-b7c4b7a1e09e"),
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
				UId = new Guid("e476c2bf-1fb4-412d-a7bb-181850864b63"),
				ContainerUId = new Guid("4567ea18-f5a1-4ba9-aa5f-b7c4b7a1e09e"),
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
				UId = new Guid("0d807853-9a95-491a-a3d0-0ea2cdb819b2"),
				ContainerUId = new Guid("4567ea18-f5a1-4ba9-aa5f-b7c4b7a1e09e"),
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
				UId = new Guid("00db4061-a2c8-4292-8ead-c1eb5bc7e733"),
				ContainerUId = new Guid("4567ea18-f5a1-4ba9-aa5f-b7c4b7a1e09e"),
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
				UId = new Guid("4115f16a-8dcd-4fba-b28c-907a5d7ce158"),
				ContainerUId = new Guid("4567ea18-f5a1-4ba9-aa5f-b7c4b7a1e09e"),
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
				UId = new Guid("ec757e19-33d5-438d-b503-d9de31bd49b9"),
				ContainerUId = new Guid("4567ea18-f5a1-4ba9-aa5f-b7c4b7a1e09e"),
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
				UId = new Guid("6e7c40b0-3db6-4bba-8d1d-95c342d70e83"),
				ContainerUId = new Guid("4567ea18-f5a1-4ba9-aa5f-b7c4b7a1e09e"),
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
				UId = new Guid("2acb378d-9f3c-4519-a4b2-2c938bc4efdc"),
				ContainerUId = new Guid("4567ea18-f5a1-4ba9-aa5f-b7c4b7a1e09e"),
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
				UId = new Guid("7e6af026-a5dd-44b3-944d-53a84a11ecaa"),
				ContainerUId = new Guid("4567ea18-f5a1-4ba9-aa5f-b7c4b7a1e09e"),
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
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet388 = CreateLaneSet388LaneSet();
			LaneSets.Add(schemaLaneSet388);
			ProcessSchemaLane schemaLane1186 = CreateLane1186Lane();
			schemaLaneSet388.Lanes.Add(schemaLane1186);
			ProcessSchemaEventSubProcess activitysavedsubprocess = CreateActivitySavedSubProcessEventSubProcess();
			FlowElements.Add(activitysavedsubprocess);
			ProcessSchemaEventSubProcess activitysavingsubprocess = CreateActivitySavingSubProcessEventSubProcess();
			FlowElements.Add(activitysavingsubprocess);
			ProcessSchemaEventSubProcess activityinsertingeventsubprocess = CreateActivityInsertingEventSubProcessEventSubProcess();
			FlowElements.Add(activityinsertingeventsubprocess);
			ProcessSchemaEventSubProcess activitydefcolumnvaluesseteventsubprocess = CreateActivityDefColumnValuesSetEventSubProcessEventSubProcess();
			FlowElements.Add(activitydefcolumnvaluesseteventsubprocess);
			ProcessSchemaEventSubProcess activitydeletingeventsubprocess = CreateActivityDeletingEventSubProcessEventSubProcess();
			FlowElements.Add(activitydeletingeventsubprocess);
			ProcessSchemaEventSubProcess remindingssynchronizeeventsubprocess = CreateRemindingsSynchronizeEventSubProcessEventSubProcess();
			FlowElements.Add(remindingssynchronizeeventsubprocess);
			ProcessSchemaEventSubProcess activityinsertedeventsubprocess = CreateActivityInsertedEventSubProcessEventSubProcess();
			FlowElements.Add(activityinsertedeventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess3_194a2b9eda6c440ba0883a59c753280a = CreateEventSubProcess3_194a2b9eda6c440ba0883a59c753280aEventSubProcess();
			FlowElements.Add(eventsubprocess3_194a2b9eda6c440ba0883a59c753280a);
			ProcessSchemaStartMessageEvent startmessageactivitysaved = CreateStartMessageActivitySavedStartMessageEvent();
			activitysavedsubprocess.FlowElements.Add(startmessageactivitysaved);
			ProcessSchemaIntermediateThrowMessageEvent synchronizeremindingsintermediatethrowmessageevent = CreateSynchronizeRemindingsIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			activitysavedsubprocess.FlowElements.Add(synchronizeremindingsintermediatethrowmessageevent);
			ProcessSchemaScriptTask activitysavedscripttask = CreateActivitySavedScriptTaskScriptTask();
			activitysavedsubprocess.FlowElements.Add(activitysavedscripttask);
			ProcessSchemaScriptTask updateremindings = CreateUpdateRemindingsScriptTask();
			activitysavedsubprocess.FlowElements.Add(updateremindings);
			ProcessSchemaStartMessageEvent activitysavingstartmessage = CreateActivitySavingStartMessageStartMessageEvent();
			activitysavingsubprocess.FlowElements.Add(activitysavingstartmessage);
			ProcessSchemaScriptTask activitysavingscripttask = CreateActivitySavingScriptTaskScriptTask();
			activitysavingsubprocess.FlowElements.Add(activitysavingscripttask);
			ProcessSchemaStartMessageEvent activityinserting = CreateActivityInsertingStartMessageEvent();
			activityinsertingeventsubprocess.FlowElements.Add(activityinserting);
			ProcessSchemaScriptTask scriptactivityinserting = CreateScriptActivityInsertingScriptTask();
			activityinsertingeventsubprocess.FlowElements.Add(scriptactivityinserting);
			ProcessSchemaStartMessageEvent activitydefcolumnvaluesset = CreateActivityDefColumnValuesSetStartMessageEvent();
			activitydefcolumnvaluesseteventsubprocess.FlowElements.Add(activitydefcolumnvaluesset);
			ProcessSchemaScriptTask activitydefcolumnvaluessetscripttask = CreateActivityDefColumnValuesSetScriptTaskScriptTask();
			activitydefcolumnvaluesseteventsubprocess.FlowElements.Add(activitydefcolumnvaluessetscripttask);
			ProcessSchemaStartMessageEvent activitydeletingstartmessage = CreateActivityDeletingStartMessageStartMessageEvent();
			activitydeletingeventsubprocess.FlowElements.Add(activitydeletingstartmessage);
			ProcessSchemaScriptTask activitydeletingscripttask = CreateActivityDeletingScriptTaskScriptTask();
			activitydeletingeventsubprocess.FlowElements.Add(activitydeletingscripttask);
			ProcessSchemaIntermediateThrowMessageEvent synchronizeremindingsondeleteintermediatethrowmessageevent = CreateSynchronizeRemindingsOnDeleteIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			activitydeletingeventsubprocess.FlowElements.Add(synchronizeremindingsondeleteintermediatethrowmessageevent);
			ProcessSchemaStartMessageEvent synchronizeremindingsstartmessage = CreateSynchronizeRemindingsStartMessageStartMessageEvent();
			remindingssynchronizeeventsubprocess.FlowElements.Add(synchronizeremindingsstartmessage);
			ProcessSchemaScriptTask synchronizesubjectremindingownerscript = CreateSynchronizeSubjectRemindingOwnerScriptScriptTask();
			remindingssynchronizeeventsubprocess.FlowElements.Add(synchronizesubjectremindingownerscript);
			ProcessSchemaUserTask synchronizesubjectremindingowner = CreateSynchronizeSubjectRemindingOwnerUserTask();
			remindingssynchronizeeventsubprocess.FlowElements.Add(synchronizesubjectremindingowner);
			ProcessSchemaScriptTask synchronizesubjectremindingauthorscript = CreateSynchronizeSubjectRemindingAuthorScriptScriptTask();
			remindingssynchronizeeventsubprocess.FlowElements.Add(synchronizesubjectremindingauthorscript);
			ProcessSchemaUserTask synchronizesubjectremindingauthor = CreateSynchronizeSubjectRemindingAuthorUserTask();
			remindingssynchronizeeventsubprocess.FlowElements.Add(synchronizesubjectremindingauthor);
			ProcessSchemaStartMessageEvent activityinserted = CreateActivityInsertedStartMessageEvent();
			activityinsertedeventsubprocess.FlowElements.Add(activityinserted);
			ProcessSchemaScriptTask scriptactivityinserted = CreateScriptActivityInsertedScriptTask();
			activityinsertedeventsubprocess.FlowElements.Add(scriptactivityinserted);
			ProcessSchemaStartMessageEvent startmessage3_9d37e41aabe548ae868128ec71992033 = CreateStartMessage3_9d37e41aabe548ae868128ec71992033StartMessageEvent();
			eventsubprocess3_194a2b9eda6c440ba0883a59c753280a.FlowElements.Add(startmessage3_9d37e41aabe548ae868128ec71992033);
			ProcessSchemaScriptTask activityupdatedscripttask_42f1f750f7be4667b75eeb7454a4a25d = CreateActivityUpdatedScriptTask_42f1f750f7be4667b75eeb7454a4a25dScriptTask();
			eventsubprocess3_194a2b9eda6c440ba0883a59c753280a.FlowElements.Add(activityupdatedscripttask_42f1f750f7be4667b75eeb7454a4a25d);
			FlowElements.Add(CreateScriptTaskSaveOldValuesSequenceFlowSequenceFlow());
			FlowElements.Add(CreateConditionScriptSequenceFlowSequenceFlow());
			FlowElements.Add(CreateSynchronizeSubjectRemindingAuthorSequenceFlowSequenceFlow());
			FlowElements.Add(CreateScriptActivityInsertingSequenceFlowSequenceFlow());
			FlowElements.Add(CreateSequenceFlow6778SequenceFlow());
			FlowElements.Add(CreateSynchronizeSubjectRemindingOwnerSequenceFlowSequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateActivityDeletingSequenceFlowSequenceFlow());
			FlowElements.Add(CreateSynchronizeRemindingsOnDeleteSequenceFlowSequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow366666SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5_6f9d9ffdba8149b0a245e49b727e8957SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow1_91b0fd7fdfd7441c9a9c9652b3e2f653ConditionalFlow());
			FlowElements.Add(CreateConditionalSequenceFlow2_a34effe2af294a52a41439c626702dc4ConditionalFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateHourLocalizableString());
			LocalizableStrings.Add(CreateMinuteLocalizableString());
			LocalizableStrings.Add(CreateSenderEmailMoreThenOneLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateHourLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("518f59b0-4843-4368-b233-60f0866909b5"),
				Name = "Hour",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateMinuteLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("3117a1be-b175-47e3-821b-dc314339821f"),
				Name = "Minute",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSenderEmailMoreThenOneLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c40b4a8e-4561-4246-8882-80301ffa3013"),
				Name = "SenderEmailMoreThenOne",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateScriptTaskSaveOldValuesSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "ScriptTaskSaveOldValuesSequenceFlow",
				UId = new Guid("3639bf43-3980-4b13-a231-5a59952367a8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CurveCenterPosition = new Point(157, 282),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5444156a-a20a-4e76-a7ef-c321a7553570"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7ff002e9-e185-412b-a40f-a18c71dd8be2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateConditionScriptSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "ConditionScriptSequenceFlow",
				UId = new Guid("7d35ce70-4e85-48f7-af13-4e9549430248"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CurveCenterPosition = new Point(165, 153),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("60828812-b879-4291-a03e-325b2cc89fa5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4e7601f9-de28-48b6-bd1f-e9c20fe849ef"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(63, 884));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSynchronizeSubjectRemindingAuthorSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SynchronizeSubjectRemindingAuthorSequenceFlow",
				UId = new Guid("f75a2ceb-dd2d-4c39-8a0d-746bb8658a0b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CurveCenterPosition = new Point(256, 275),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6870ffad-93d9-4841-a511-07de9af2d792"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("005cc890-8c70-4098-88ec-80950340fe5a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(68, 392));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateScriptActivityInsertingSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "ScriptActivityInsertingSequenceFlow",
				UId = new Guid("a77b56b0-d767-438e-b171-a04e8156b383"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CurveCenterPosition = new Point(556, 326),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0c5dc6d7-e051-4e24-b8f2-d0cd1dadb4fa"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a1ca2b05-103a-4752-a317-e8e0577c9a7e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6778SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6778",
				UId = new Guid("6d27acd6-ef88-4ec1-b792-79d8e063b78c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CurveCenterPosition = new Point(162, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("60828812-b879-4291-a03e-325b2cc89fa5"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("242e3956-ea08-4383-b3e4-0c5226d72265"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSynchronizeSubjectRemindingOwnerSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SynchronizeSubjectRemindingOwnerSequenceFlow",
				UId = new Guid("22de38c6-d04b-4a6d-af84-a0758ba63cf0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CurveCenterPosition = new Point(187, 290),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6870ffad-93d9-4841-a511-07de9af2d792"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("75c05abb-9798-41e2-b0bb-09150b07ab1e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(36, 313));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("346cf7a9-36ba-4a53-bc22-980aabf01a1b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CurveCenterPosition = new Point(150, 504),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5ef784c0-f459-416d-8a35-da718a515473"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0644828a-9ba4-4328-bbbc-120722acce56"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateActivityDeletingSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "ActivityDeletingSequenceFlow",
				UId = new Guid("87061f12-be4d-4c4e-b33e-276a4f9ffb08"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CurveCenterPosition = new Point(176, 678),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cede14f1-3821-47d0-8677-059509518170"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f9ac769f-4ad2-4537-8e36-5a552312a4f9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSynchronizeRemindingsOnDeleteSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SynchronizeRemindingsOnDeleteSequenceFlow",
				UId = new Guid("e9319b80-68f4-4604-bd92-2c0b25d33b0b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8a3e6264-0c74-497d-8a11-cebe83e81070"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CurveCenterPosition = new Point(308, 665),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f9ac769f-4ad2-4537-8e36-5a552312a4f9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8b15e558-03f8-4435-bdc6-57a990231738"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("583479f0-2d61-4fe9-823c-e6a91093353c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e2abafdc-6941-48ad-bc50-34f0bc9897c4"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CurveCenterPosition = new Point(737, 583),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("201f36e9-3509-40c4-9630-c4a30c1cff66"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ba458700-4412-44e1-ae92-b324e4da2990"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow366666SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow366666",
				UId = new Guid("5380ee25-f2de-4128-8a7d-10250a3e819e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e0462cc6-6899-44cf-a039-39d70fd9f47b"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CurveCenterPosition = new Point(388, 170),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("60828812-b879-4291-a03e-325b2cc89fa5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7c214338-8ceb-405d-998b-154439a24622"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(63, 972));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5_6f9d9ffdba8149b0a245e49b727e8957SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5_6f9d9ffdba8149b0a245e49b727e8957",
				UId = new Guid("6f9d9ffd-ba81-49b0-a245-e49b727e8957"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9d37e41a-abe5-48ae-8681-28ec71992033"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("42f1f750-f7be-4667-b75e-eb7454a4a25d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow1_91b0fd7fdfd7441c9a9c9652b3e2f653ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow1_91b0fd7fdfd7441c9a9c9652b3e2f653",
				UId = new Guid("91b0fd7f-dfd7-441c-9a9c-9652b3e2f653"),
				ConditionExpression = @"Entity.GetTypedColumnValue<Guid>(""TypeId"") != ActivityConsts.EmailTypeUId",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("79d5e1e4-18af-4001-8dc1-26f09fca92c2"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("75c05abb-9798-41e2-b0bb-09150b07ab1e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4ebed4c4-db85-492e-ae3e-30ea37ce7801"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow2_a34effe2af294a52a41439c626702dc4ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow2_a34effe2af294a52a41439c626702dc4",
				UId = new Guid("a34effe2-af29-4a52-a414-39c626702dc4"),
				ConditionExpression = @"Entity.GetTypedColumnValue<Guid>(""TypeId"") != ActivityConsts.EmailTypeUId",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("79d5e1e4-18af-4001-8dc1-26f09fca92c2"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("005cc890-8c70-4098-88ec-80950340fe5a"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4567ea18-f5a1-4ba9-aa5f-b7c4b7a1e09e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet388LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet388 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("6cb1db60-f4de-458f-a4fd-7d706369a3a7"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"LaneSet388",
				Position = new Point(5, 5),
				Size = new Size(1044, 1077),
				UseBackgroundMode = false
			};
			return schemaLaneSet388;
		}

		protected virtual ProcessSchemaLane CreateLane1186Lane() {
			ProcessSchemaLane schemaLane1186 = new ProcessSchemaLane(this) {
				UId = new Guid("5d371268-e31a-4104-8514-98ca7e33ba40"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("6cb1db60-f4de-458f-a4fd-7d706369a3a7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"Lane1186",
				Position = new Point(29, 0),
				Size = new Size(1015, 1077),
				UseBackgroundMode = false
			};
			return schemaLane1186;
		}

		protected virtual ProcessSchemaEventSubProcess CreateActivitySavedSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaActivitySavedSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("cec59e3a-99bd-4af7-bcab-ed936238fc72"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5d371268-e31a-4104-8514-98ca7e33ba40"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"ActivitySavedSubProcess",
				Position = new Point(35, 708),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(650, 572),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaActivitySavedSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageActivitySavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("60828812-b879-4291-a03e-325b2cc89fa5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cec59e3a-99bd-4af7-bcab-ed936238fc72"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ActivitySaved",
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"StartMessageActivitySaved",
				Position = new Point(15, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateSynchronizeRemindingsIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("4e7601f9-de28-48b6-bd1f-e9c20fe849ef"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cec59e3a-99bd-4af7-bcab-ed936238fc72"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8a3e6264-0c74-497d-8a11-cebe83e81070"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"SynchronizeRemindings",
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"SynchronizeRemindingsIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(127, 163),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateActivitySavedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("242e3956-ea08-4383-b3e4-0c5226d72265"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cec59e3a-99bd-4af7-bcab-ed936238fc72"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("afbb269b-fc54-494c-b1eb-1fd3a323385c"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"ActivitySavedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(106, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,240,207,115,76,46,201,44,203,44,169,12,78,44,75,77,209,72,206,207,43,73,173,40,209,180,6,0,151,111,146,106,32,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateUpdateRemindingsScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7c214338-8ceb-405d-998b-154439a24622"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cec59e3a-99bd-4af7-bcab-ed936238fc72"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e0462cc6-6899-44cf-a039-39d70fd9f47b"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"UpdateRemindings",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(232, 237),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,79,205,75,45,74,44,73,13,74,205,205,204,75,201,204,75,47,214,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,254,31,73,67,35,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateActivitySavingSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaActivitySavingSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("3fbd2388-ab69-48d4-b802-8fe8efad9978"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5d371268-e31a-4104-8514-98ca7e33ba40"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"ActivitySavingSubProcess",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(241, 247),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaActivitySavingSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateActivitySavingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5444156a-a20a-4e76-a7ef-c321a7553570"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3fbd2388-ab69-48d4-b802-8fe8efad9978"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ActivitySaving",
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"ActivitySavingStartMessage",
				Position = new Point(38, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateActivitySavingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7ff002e9-e185-412b-a40f-a18c71dd8be2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3fbd2388-ab69-48d4-b802-8fe8efad9978"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("afbb269b-fc54-494c-b1eb-1fd3a323385c"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"ActivitySavingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(126, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,240,207,115,76,46,201,44,203,44,169,12,78,44,203,204,75,215,72,206,207,43,73,173,40,209,180,6,0,74,18,227,177,33,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateActivityInsertingEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaActivityInsertingEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("fdc25270-216b-4cf9-bcc8-c94d500860f7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5d371268-e31a-4104-8514-98ca7e33ba40"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"ActivityInsertingEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(305, 20),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(319, 200),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaActivityInsertingEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateActivityInsertingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("0c5dc6d7-e051-4e24-b8f2-d0cd1dadb4fa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fdc25270-216b-4cf9-bcc8-c94d500860f7"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ActivityInserting",
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"ActivityInserting",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(40, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptActivityInsertingScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a1ca2b05-103a-4752-a317-e8e0577c9a7e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fdc25270-216b-4cf9-bcc8-c94d500860f7"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"ScriptActivityInserting",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(125, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,240,207,115,76,46,201,44,203,44,169,244,204,43,78,45,42,201,204,75,215,72,206,207,43,73,173,40,209,180,6,0,212,55,240,43,36,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateActivityDefColumnValuesSetEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaActivityDefColumnValuesSetEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("635fa9cb-7360-4e6c-9ab7-d95b48a6c9ad"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5d371268-e31a-4104-8514-98ca7e33ba40"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"ActivityDefColumnValuesSetEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(588, 266),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(322, 217),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaActivityDefColumnValuesSetEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateActivityDefColumnValuesSetStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5ef784c0-f459-416d-8a35-da718a515473"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("635fa9cb-7360-4e6c-9ab7-d95b48a6c9ad"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ActivityDefColumnValuesSet",
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"ActivityDefColumnValuesSet",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateActivityDefColumnValuesSetScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0644828a-9ba4-4328-bbbc-120722acce56"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("635fa9cb-7360-4e6c-9ab7-d95b48a6c9ad"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"ActivityDefColumnValuesSetScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(196, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,82,93,75,195,48,20,125,158,224,127,184,14,54,210,57,235,80,244,165,86,208,78,247,36,8,157,190,135,230,202,2,109,42,105,50,40,226,127,55,109,154,174,153,31,12,132,82,154,211,123,206,185,55,247,240,55,32,15,66,113,85,135,105,182,193,130,134,143,92,48,251,153,148,185,46,196,125,253,76,213,134,140,83,69,165,90,82,133,227,0,78,98,16,58,207,97,58,133,227,163,209,97,252,165,70,159,29,192,135,33,111,169,132,202,73,67,12,157,216,10,213,186,126,71,102,53,94,105,174,241,166,169,88,243,2,111,189,102,34,35,194,205,20,3,145,24,92,105,248,196,45,217,154,141,134,78,47,21,202,164,20,2,51,197,75,17,38,90,74,20,170,65,27,247,238,232,132,72,235,51,226,66,217,110,141,174,110,85,122,197,208,66,81,111,211,151,16,66,134,192,57,92,5,112,10,23,48,3,15,159,52,120,251,115,214,188,38,112,189,104,197,154,27,218,210,220,243,186,99,204,178,42,114,182,223,65,16,237,79,106,216,67,198,192,244,123,173,231,145,98,86,10,230,121,88,200,242,220,226,205,109,237,214,52,92,206,124,39,247,39,195,101,99,254,243,136,151,139,160,165,127,118,121,97,182,252,224,180,244,209,115,89,233,5,126,79,202,191,59,53,143,68,165,165,0,37,53,70,95,179,174,13,77,105,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateActivityDeletingEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaActivityDeletingEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("0d943db0-ee11-46b4-90c5-46a02cc28819"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5d371268-e31a-4104-8514-98ca7e33ba40"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"ActivityDeletingEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(35, 504),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(533, 158),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaActivityDeletingEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateActivityDeletingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("cede14f1-3821-47d0-8677-059509518170"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0d943db0-ee11-46b4-90c5-46a02cc28819"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ActivityDeleting",
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"ActivityDeletingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(22, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateActivityDeletingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f9ac769f-4ad2-4537-8e36-5a552312a4f9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0d943db0-ee11-46b4-90c5-46a02cc28819"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"ActivityDeletingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(155, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,112,76,46,201,44,203,44,169,116,73,205,73,45,201,204,75,215,72,206,207,43,73,173,40,209,180,6,0,224,83,8,63,33,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateSynchronizeRemindingsOnDeleteIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("8b15e558-03f8-4435-bdc6-57a990231738"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0d943db0-ee11-46b4-90c5-46a02cc28819"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8a3e6264-0c74-497d-8a11-cebe83e81070"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"SynchronizeRemindings",
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"SynchronizeRemindingsOnDeleteIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(337, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateRemindingsSynchronizeEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaRemindingsSynchronizeEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a0ff1647-9846-4530-9692-fda7f87ec9ab"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5d371268-e31a-4104-8514-98ca7e33ba40"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8a3e6264-0c74-497d-8a11-cebe83e81070"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"RemindingsSynchronizeEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(35, 266),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(531, 221),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaRemindingsSynchronizeEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSynchronizeRemindingsStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6870ffad-93d9-4841-a511-07de9af2d792"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a0ff1647-9846-4530-9692-fda7f87ec9ab"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8a3e6264-0c74-497d-8a11-cebe83e81070"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SynchronizeRemindings",
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"SynchronizeRemindingsStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 79),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSynchronizeSubjectRemindingOwnerScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("75c05abb-9798-41e2-b0bb-09150b07ab1e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a0ff1647-9846-4530-9692-fda7f87ec9ab"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"SynchronizeSubjectRemindingOwnerScript",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(116, 20),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,82,77,79,2,49,16,61,75,194,127,168,28,76,55,97,73,23,69,77,252,184,40,33,28,252,8,187,122,47,219,81,171,221,22,187,45,100,21,255,187,237,46,108,64,8,26,111,147,153,121,111,222,123,237,148,106,164,102,18,244,8,50,46,25,151,207,177,178,58,133,164,152,192,144,161,11,36,97,134,6,150,51,220,162,39,199,140,156,66,20,118,161,203,66,32,81,20,210,148,208,144,144,168,215,99,228,232,176,75,122,173,224,172,217,152,58,78,93,210,37,234,206,115,59,154,190,52,220,20,157,1,24,207,204,174,148,176,153,124,164,194,194,249,88,41,113,137,91,163,85,68,205,163,126,199,123,117,14,95,226,134,172,68,242,39,132,215,21,28,28,32,236,172,44,150,58,195,252,86,153,126,54,49,5,14,252,108,127,101,214,127,183,84,228,88,9,182,232,4,65,128,62,155,141,189,184,144,233,139,86,146,127,64,108,199,175,144,154,58,180,114,211,177,198,174,22,80,181,75,221,70,91,112,130,190,182,164,114,77,13,236,118,230,55,18,158,193,207,116,124,127,187,207,138,211,189,154,21,2,205,231,155,7,151,238,150,212,157,27,94,29,91,120,252,191,194,216,80,109,106,101,206,240,189,134,9,104,216,145,218,67,14,58,161,249,27,254,67,184,109,228,150,84,93,109,232,44,187,216,255,165,96,109,214,94,194,182,126,240,102,195,139,213,96,172,150,213,91,125,3,216,150,201,199,17,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateSynchronizeSubjectRemindingOwnerUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("4ebed4c4-db85-492e-ae3e-30ea37ce7801"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a0ff1647-9846-4530-9692-fda7f87ec9ab"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"SynchronizeSubjectRemindingOwner",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(316, 20),
				SchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeSynchronizeSubjectRemindingOwnerParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateSynchronizeSubjectRemindingAuthorScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("005cc890-8c70-4098-88ec-80950340fe5a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a0ff1647-9846-4530-9692-fda7f87ec9ab"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"SynchronizeSubjectRemindingAuthorScript",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(126, 99),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,146,93,75,195,48,20,134,175,45,244,63,132,94,165,176,150,180,218,33,76,5,113,99,236,66,144,181,122,159,53,71,23,77,147,153,38,147,234,252,239,246,3,43,99,117,8,222,133,156,247,60,231,33,39,91,170,17,181,102,173,244,18,10,46,25,151,79,169,178,58,135,172,218,192,130,161,75,36,225,13,205,45,103,216,163,227,49,35,231,16,5,49,196,44,0,18,69,1,205,9,13,8,137,146,132,145,179,211,152,36,158,63,113,157,109,13,213,45,46,83,215,45,188,230,204,164,225,166,10,231,96,26,52,187,81,194,22,242,129,10,11,23,43,165,196,21,246,150,123,45,61,137,254,129,208,8,214,132,174,115,193,126,177,152,82,3,199,57,77,34,227,5,28,216,52,133,150,202,31,17,30,162,214,15,101,133,64,187,221,192,204,112,246,106,169,40,241,55,61,188,229,221,60,223,71,31,174,115,242,15,203,169,133,94,237,211,117,238,52,108,64,67,90,201,124,173,149,228,239,144,218,213,51,228,166,223,238,125,9,58,163,229,11,174,231,30,137,117,42,35,84,167,232,207,241,80,180,189,198,205,2,253,253,226,168,239,28,252,88,174,211,24,107,48,86,75,100,180,133,201,23,225,166,162,56,138,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateSynchronizeSubjectRemindingAuthorUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("4567ea18-f5a1-4ba9-aa5f-b7c4b7a1e09e"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a0ff1647-9846-4530-9692-fda7f87ec9ab"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"SynchronizeSubjectRemindingAuthor",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(316, 99),
				SchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeSynchronizeSubjectRemindingAuthorParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateActivityInsertedEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaActivityInsertedEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("90556cbb-797c-4592-baba-c65e4c525176"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5d371268-e31a-4104-8514-98ca7e33ba40"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e2abafdc-6941-48ad-bc50-34f0bc9897c4"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"ActivityInsertedEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(588, 497),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(413, 161),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaActivityInsertedEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateActivityInsertedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("201f36e9-3509-40c4-9630-c4a30c1cff66"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("90556cbb-797c-4592-baba-c65e4c525176"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e2abafdc-6941-48ad-bc50-34f0bc9897c4"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ActivityInserted",
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"ActivityInserted",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptActivityInsertedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ba458700-4412-44e1-ae92-b324e4da2990"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("90556cbb-797c-4592-baba-c65e4c525176"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e2abafdc-6941-48ad-bc50-34f0bc9897c4"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"ScriptActivityInserted",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(127, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,240,207,115,76,46,201,44,203,44,169,244,204,43,78,45,42,73,77,209,72,206,207,43,73,173,40,209,180,6,0,22,71,4,198,35,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3_194a2b9eda6c440ba0883a59c753280aEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3_194a2b9eda6c440ba0883a59c753280a = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("194a2b9e-da6c-440b-a088-3a59c753280a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5d371268-e31a-4104-8514-98ca7e33ba40"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"EventSubProcess3_194a2b9eda6c440ba0883a59c753280a",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(675, 20),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(250, 158),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3_194a2b9eda6c440ba0883a59c753280a;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage3_9d37e41aabe548ae868128ec71992033StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("9d37e41a-abe5-48ae-8681-28ec71992033"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("194a2b9e-da6c-440b-a088-3a59c753280a"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ActivityUpdated",
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"StartMessage3_9d37e41aabe548ae868128ec71992033",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(31, 69),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateActivityUpdatedScriptTask_42f1f750f7be4667b75eeb7454a4a25dScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("42f1f750-f7be-4667-b75e-eb7454a4a25d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("194a2b9e-da6c-440b-a088-3a59c753280a"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Name = @"ActivityUpdatedScriptTask_42f1f750f7be4667b75eeb7454a4a25d",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(140, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,115,76,46,201,44,203,44,169,12,45,72,73,44,73,77,137,79,76,52,77,51,48,55,73,76,182,48,181,48,49,53,77,177,48,51,53,49,54,77,78,54,7,114,83,45,147,19,53,146,243,243,74,82,43,74,52,173,185,138,82,75,74,139,242,20,74,138,74,83,173,1,145,29,194,204,73,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateFindEmailSendStatusByCodeMethod());
			Methods.Add(CreateFindActivityTypeCodeByIdMethod());
			Methods.Add(CreateSetEmailParticipantsMethod());
			Methods.Add(CreateGetEmailsByFormatedEmailsMethod());
			Methods.Add(CreateGetRecepientsForAddingMethod());
			Methods.Add(CreateGetRecepientsEmailsForDeleteMethod());
			Methods.Add(CreateRemoveEmailParticipantsMethod());
			Methods.Add(CreateUpdateParticipantsByOwnerContactMethod());
			Methods.Add(CreateGetSenderEmailMethod());
			Methods.Add(CreateSetParticipantSenderMethod());
			Methods.Add(CreateGetUsedEmailsMethod());
			Methods.Add(CreateSetFromParticipantOnSentMethod());
			Methods.Add(CreateUpdateParticipantsByOwnerContactEmailMethod());
			Methods.Add(CreateDeleteOldOwnerAndContactParticipantsMethod());
			Methods.Add(CreateDoCollectEmailParticipantsMethod());
			Methods.Add(CreateActivityDeletingMethod());
			Methods.Add(CreatePrepereSynchronizeSubjectRemindingUserTaskMethod());
			Methods.Add(CreateIsFinalStatusMethod());
			Methods.Add(CreateSetActivityParticipantProcessPropertyValueMethod());
			Methods.Add(CreateAddActivityParticipantToInsertedValuesMethod());
			Methods.Add(CreateOnActivitySavedMethod());
			Methods.Add(CreateSetActivityParticipantRightsOnSavedMethod());
			Methods.Add(CreateSynchronizeActivityOnSavedMethod());
			Methods.Add(CreateOnActivitySavingMethod());
			Methods.Add(CreateSaveOldValuesOnSavingMethod());
			Methods.Add(CreateCalculateDurationOnSavingMethod());
			Methods.Add(CreateSavingEmailOnSavingMethod());
			Methods.Add(CreateSetTypeByCategoryOnSavingMethod());
			Methods.Add(CreateOnActivityInsertingMethod());
			Methods.Add(CreateCreateActivityParticipantsFromInsertedValuesMethod());
			Methods.Add(CreateOnActivityInsertedMethod());
			Methods.Add(CreateSetEmailIsNeedProcessMethod());
			Methods.Add(CreateAutoEmailRelationProceedMethod());
			Methods.Add(CreateCheckNeedAutoEmailRelationMethod());
			Methods.Add(CreateInitializeEmailParticipantHelperMethod());
			Methods.Add(CreateSetRemindDatesOnSavingMethod());
			Methods.Add(CreateOnActivityUpdated_aa5f074ac858455d865435cc7584e9caMethod());
			Methods.Add(CreateGetEmailRightsManagerMethod());
			Methods.Add(CreateInitCanGenerateAnniversaryRemindingMethod());
			Methods.Add(CreateGetAnniversaryDependentColumnsMethod());
			Methods.Add(CreateGetRemindingOptionsMethod());
			Methods.Add(CreateGenerateRemindingsMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f83cbea2-10c5-4739-96f1-116937efce77"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("19024591-23ea-4b03-9800-93149198129b"),
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
				UId = new Guid("ca241c6a-6bd2-4e33-ae26-164063bfb504"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ed374225-e41d-4643-8234-a4c89997d648"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("9b2ffa7b-51c7-46d9-b749-4bade78db945")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("49a41b26-e223-4e0d-a40a-f81877cefa7a"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847")
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
				UId = new Guid("c8f03a62-627b-4c3c-a7a8-dca7a5be0e70"),
				Name = "System.Text.RegularExpressions",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("8141ed71-f702-4246-8bcd-71fef757fdc4"),
				Name = "System.Web",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
		}

		protected virtual SchemaMethod CreateFindEmailSendStatusByCodeMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("24a2abfb-4ded-4fc2-9560-73908a938140"),
				Name = "FindEmailSendStatusByCode",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Guid"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9de4e06c-57ab-4885-803c-93db26ffb93a"),
				Name = "emailSendStatusCode",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,82,77,75,195,64,20,60,27,232,127,88,114,74,161,132,222,139,66,12,105,41,168,84,227,199,65,164,108,179,207,118,97,63,226,238,75,75,40,253,239,190,36,85,106,212,222,146,221,153,121,179,51,111,203,29,3,205,165,202,193,136,28,57,86,62,47,54,116,114,95,129,171,217,37,51,176,99,153,65,137,245,201,121,244,228,193,165,214,24,40,80,90,19,159,2,110,185,225,107,112,35,22,102,63,117,195,33,219,15,130,11,162,38,66,75,243,32,215,27,244,52,97,166,236,138,171,164,44,115,64,148,102,237,227,41,16,222,193,79,228,220,100,122,5,66,128,184,177,107,89,140,72,42,229,52,145,20,122,110,72,74,201,130,55,223,45,226,27,58,71,208,119,92,55,20,143,142,70,197,83,235,52,199,168,111,117,57,3,188,174,83,43,96,185,31,31,194,81,63,162,230,102,56,8,14,147,65,240,127,120,241,194,73,205,93,221,254,164,86,85,218,196,115,159,168,29,175,125,14,138,204,146,15,116,21,144,202,150,106,40,72,244,4,75,151,103,180,19,33,58,88,20,54,102,194,225,121,43,83,169,16,156,111,104,17,165,113,6,153,58,10,31,58,252,139,196,205,130,59,74,172,33,71,221,97,106,117,201,157,244,214,60,214,37,196,217,71,197,21,149,221,186,248,59,168,225,241,129,208,110,9,217,86,93,81,231,95,72,21,100,61,66,111,237,26,93,249,206,162,190,110,156,218,202,32,187,98,227,110,227,28,208,54,153,95,227,95,199,111,95,21,117,81,62,115,213,150,113,24,4,71,202,172,146,34,206,116,137,245,228,19,229,194,249,83,41,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFindActivityTypeCodeByIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0ffaf9b0-7150-4880-8b34-b2292110c6d3"),
				Name = "FindActivityTypeCodeById",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("3a3ca2fd-ec3b-41d9-8e7d-7e1869fcdd0e"),
				Name = "activityTypeId",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,82,77,107,131,64,16,61,87,240,63,108,61,25,8,210,123,218,130,149,36,8,109,105,155,182,215,176,113,167,102,97,63,100,93,19,150,224,127,239,108,12,69,141,189,185,206,155,247,222,188,153,3,53,132,22,150,31,184,117,159,174,130,76,51,32,15,164,182,134,171,50,89,202,202,186,69,24,28,122,168,77,177,7,73,223,27,48,14,129,10,142,100,169,236,240,127,252,85,131,201,180,82,128,61,90,37,125,192,11,85,180,4,51,39,81,218,147,141,102,228,20,6,55,216,151,50,201,213,7,47,247,182,70,250,181,208,59,42,210,170,218,128,181,232,168,78,86,64,109,99,96,136,204,213,82,238,128,49,96,207,186,228,197,28,169,50,138,114,200,48,178,130,84,130,23,212,127,159,17,127,208,220,130,124,165,178,55,252,74,27,73,109,60,240,185,93,131,245,17,61,185,156,109,79,119,109,52,31,164,151,179,89,24,180,24,216,68,88,201,155,225,146,26,119,126,100,90,52,82,37,121,157,138,35,117,245,6,4,250,67,105,107,26,184,228,93,160,76,15,139,197,41,210,148,177,174,30,71,222,87,52,27,109,203,187,234,226,255,135,0,7,234,234,163,165,93,13,134,196,252,135,196,19,196,183,120,6,141,16,221,10,39,142,233,186,197,171,250,215,197,251,55,21,13,220,119,177,63,198,163,193,19,191,21,175,222,134,129,1,220,189,186,58,216,197,47,202,242,29,63,198,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetEmailParticipantsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6c6692e4-e252-45ce-be67-6f67586d524c"),
				Name = "SetEmailParticipants",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,84,193,110,226,48,16,61,39,95,97,113,74,164,40,218,59,75,36,72,105,133,118,87,91,81,186,151,170,7,55,158,182,238,6,155,181,29,86,17,202,191,239,216,78,128,64,16,82,181,156,194,204,155,55,111,198,207,222,82,69,64,24,110,106,50,33,115,247,49,14,181,81,92,188,17,13,130,129,154,175,41,47,49,249,112,248,55,14,183,88,166,160,128,13,199,98,237,130,26,49,209,119,174,205,87,95,158,197,203,19,128,47,43,228,166,62,205,156,149,230,3,32,95,254,82,114,193,134,210,103,28,179,75,200,97,249,183,82,221,64,9,6,174,206,177,71,142,195,37,172,229,22,92,248,158,42,195,11,190,161,136,139,98,223,3,58,101,119,96,30,53,48,95,111,179,252,149,68,62,155,230,178,18,134,76,38,228,75,76,118,97,160,192,84,74,140,195,198,97,122,103,48,33,162,42,75,135,234,159,13,210,31,29,143,229,111,218,93,11,67,11,99,21,228,254,243,209,240,146,27,14,58,197,154,54,166,103,117,43,12,53,42,12,10,40,12,151,34,105,245,35,221,13,119,17,170,234,118,43,9,185,171,56,203,200,230,48,245,82,150,96,59,9,248,75,46,225,163,62,151,141,37,196,35,158,158,51,162,44,197,74,122,53,75,208,178,220,130,58,224,207,201,79,8,186,205,118,115,183,187,205,218,213,14,136,157,34,213,22,77,111,247,226,118,114,124,140,14,116,178,20,236,16,92,145,153,78,25,139,78,123,61,141,86,114,244,156,156,217,46,93,201,169,82,180,142,226,207,51,231,185,101,30,186,88,255,131,253,86,201,181,229,183,171,239,54,77,118,71,6,108,62,207,61,243,210,47,94,234,158,254,38,124,149,10,104,241,78,162,111,80,255,162,101,5,247,148,171,158,9,178,206,243,132,139,189,253,253,141,241,143,26,180,87,166,205,165,142,6,245,91,146,46,184,96,71,0,108,133,233,125,103,255,116,248,241,92,173,109,116,101,120,215,63,176,198,236,85,250,222,169,187,133,92,104,255,30,36,228,193,9,205,229,26,215,5,42,253,169,24,23,180,92,188,9,148,144,83,13,177,167,11,112,163,157,123,143,76,187,146,11,129,134,53,192,28,187,142,44,52,216,15,150,16,247,255,194,29,149,47,31,232,242,204,243,227,111,55,90,2,101,63,168,250,61,74,250,83,219,181,164,243,63,21,197,87,227,146,101,226,38,57,240,96,98,193,134,88,26,135,105,161,70,85,96,63,172,163,130,6,181,54,97,243,15,7,37,158,141,163,6,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetEmailsByFormatedEmailsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("74ce028d-4ed7-418f-9c7f-8de9d890c4de"),
				Name = "GetEmailsByFormatedEmails",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "List<string>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("903bd584-9c44-4ba4-8124-22fd2c0d06d0"),
				Name = "formatedEmails",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,203,47,202,77,44,73,77,113,205,77,204,204,41,214,11,72,44,42,78,5,179,29,83,82,138,82,139,139,53,52,173,1,8,79,158,59,42,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetRecepientsForAddingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("65c21234-0844-4164-aa8e-9ec8cdae7766"),
				Name = "GetRecepientsForAdding",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "List<string>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("7d252089-93a8-4d3c-9839-c452fa970830"),
				Name = "newRecepientsEmails",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "List<string>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("aab42bad-7df5-4d4a-8bae-4b92ef7421a7"),
				Name = "oldRecepientsEmails",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "List<string>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,40,74,77,78,45,200,76,205,43,41,118,205,77,204,204,113,203,47,114,76,73,201,204,75,87,176,85,200,75,45,87,240,201,44,46,177,41,46,41,2,138,216,105,104,90,243,114,165,229,23,165,38,38,103,104,148,1,245,166,130,116,40,100,230,129,84,6,161,154,83,172,169,80,205,203,197,153,153,166,160,161,152,159,147,130,46,171,231,156,159,87,146,152,153,87,172,1,54,67,19,162,154,19,151,99,244,128,20,84,37,208,9,156,181,188,92,64,84,148,90,82,90,148,135,211,3,214,0,1,94,54,140,222,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetRecepientsEmailsForDeleteMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2ace6974-a0f3-40cc-b054-cbeb427b7b84"),
				Name = "GetRecepientsEmailsForDelete",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "List<string>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f695ec58-ff26-483e-a156-d3a10e22e414"),
				Name = "newRecepientsEmails",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "List<string>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4933c5e4-a2b1-4d46-bbd5-5aa55a26184a"),
				Name = "oldRecepientsEmails",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "List<string>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,143,177,14,194,48,12,68,231,70,234,63,152,45,89,250,3,5,36,4,101,98,226,15,162,198,5,75,197,137,28,83,6,196,191,147,34,196,192,80,233,182,187,123,186,155,188,64,242,162,212,83,242,172,185,187,121,26,243,49,202,1,71,84,132,13,48,62,224,68,89,215,89,133,248,178,181,174,173,205,16,5,125,127,5,59,149,62,206,29,32,134,56,134,51,246,152,8,127,36,247,172,77,69,3,216,85,225,252,155,205,62,178,122,226,108,63,8,231,96,78,87,11,123,154,93,8,223,112,89,81,189,106,83,36,168,119,225,165,27,237,27,142,67,109,49,231,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateRemoveEmailParticipantsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("28453bb5-9c41-4c4a-a73e-b3f8014fa951"),
				Name = "RemoveEmailParticipants",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,144,79,75,3,49,16,197,207,45,244,59,140,123,40,201,101,241,174,91,40,117,11,5,15,245,255,57,108,71,13,36,147,54,153,84,139,248,221,77,154,213,234,226,245,189,153,55,191,121,123,229,193,99,135,91,141,196,173,85,218,4,104,224,246,91,9,69,90,58,127,133,6,25,65,5,184,214,129,47,3,123,77,47,179,139,201,88,63,131,16,195,136,179,6,40,26,35,97,58,133,161,89,47,92,36,134,25,156,75,9,31,147,241,104,159,24,118,17,253,97,173,188,178,233,138,207,12,195,173,187,4,208,177,208,140,22,154,25,16,190,193,205,159,165,163,37,101,125,239,50,161,144,137,109,148,167,10,185,120,8,232,23,142,40,133,104,71,50,153,163,122,233,157,21,213,60,41,123,205,57,137,117,167,183,138,184,42,254,211,43,122,60,13,172,54,149,172,87,161,221,69,101,196,194,153,104,169,62,157,111,137,211,76,189,246,218,42,127,40,246,163,50,17,101,9,155,211,70,84,191,110,148,52,18,217,60,130,246,31,254,3,154,182,75,158,168,242,86,47,21,250,52,202,170,227,31,181,103,62,182,86,14,12,186,77,21,181,239,216,197,212,73,238,232,243,11,28,55,121,182,3,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateParticipantsByOwnerContactMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("55ad5b0c-575a-408c-b0f0-5cecb4dd6caf"),
				Name = "UpdateParticipantsByOwnerContact",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,82,203,110,194,48,16,60,59,95,225,230,128,130,20,229,7,10,72,180,80,196,165,84,60,122,169,122,48,120,41,174,140,19,197,14,40,66,249,247,174,29,8,9,32,181,85,123,137,108,239,238,204,236,100,6,32,193,192,68,242,201,94,65,218,87,252,49,86,134,173,204,11,75,141,88,137,132,41,163,131,246,189,183,99,41,77,206,111,211,88,130,166,93,218,95,25,177,19,38,95,24,33,117,52,130,198,156,107,10,22,26,82,4,85,128,173,177,66,40,177,166,65,160,96,239,24,199,156,222,117,105,124,228,31,243,54,109,181,232,69,117,148,9,30,13,183,137,201,111,85,103,160,184,155,108,211,131,71,250,156,159,52,213,164,204,227,177,66,25,6,248,43,147,25,138,242,8,57,163,132,180,188,210,129,112,26,89,154,119,180,73,133,250,8,105,188,252,68,225,61,11,77,200,193,183,43,141,185,31,94,121,241,230,79,65,39,177,210,98,41,193,127,47,176,189,8,241,99,210,12,60,130,91,19,187,246,121,207,203,189,44,190,245,152,101,102,19,163,95,50,219,42,244,119,168,12,110,18,205,86,27,216,178,168,124,214,209,147,80,252,33,127,102,91,8,252,190,27,240,45,131,163,104,0,32,137,202,164,44,225,107,248,200,95,97,227,79,155,231,9,240,114,196,249,211,177,202,122,13,168,168,86,182,196,142,239,23,110,19,114,98,118,110,255,204,239,111,28,175,81,150,142,91,207,75,244,53,147,26,236,201,233,196,90,225,21,85,240,142,17,175,162,87,221,171,120,53,58,110,196,175,81,63,7,233,118,253,15,1,173,112,194,255,72,232,149,95,46,161,71,171,208,168,226,11,67,177,213,203,13,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSenderEmailMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("22c83e68-0e00-430c-97f6-2308d4ecb0dd"),
				Name = "GetSenderEmail",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,75,107,2,49,20,133,215,21,252,15,215,172,102,96,8,116,93,117,209,210,118,83,44,116,196,141,184,8,206,237,24,200,220,25,242,168,12,226,127,55,47,91,221,116,19,146,115,207,249,14,185,63,66,131,65,106,80,191,244,202,117,4,11,120,37,43,237,200,235,253,1,59,193,147,108,248,155,164,230,121,92,137,14,11,86,199,0,43,159,166,19,249,13,197,93,126,182,0,114,74,149,112,154,78,30,140,213,146,218,92,240,135,126,71,187,30,7,108,82,100,35,148,195,121,178,46,239,96,252,198,16,154,67,97,102,110,119,224,47,245,160,164,245,220,20,226,241,89,16,30,225,215,116,98,115,86,129,63,206,213,213,245,129,212,218,67,5,117,244,196,204,231,96,101,239,63,185,234,233,182,4,52,26,167,98,65,238,218,62,238,248,23,14,74,236,253,26,150,129,204,202,127,4,72,66,32,106,180,78,83,38,122,225,12,168,12,198,45,229,81,88,91,24,92,0,169,162,131,100,147,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetParticipantSenderMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a10206bc-f0d5-437a-9c41-a1d13eb84e5d"),
				Name = "SetParticipantSender",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,83,193,78,227,48,16,61,135,175,176,114,74,165,200,226,14,173,212,45,5,85,2,10,4,118,15,21,7,19,79,83,175,28,59,107,59,160,10,245,223,119,108,167,77,178,32,237,165,74,147,247,230,189,121,51,35,182,36,91,42,39,220,158,222,129,181,172,130,231,125,3,43,78,166,83,242,12,198,48,171,183,142,46,180,218,138,170,53,204,9,173,232,188,116,226,29,25,248,214,58,75,215,173,171,180,80,213,178,102,66,70,246,132,124,158,37,239,204,16,11,138,131,89,104,217,214,138,76,73,167,84,148,59,168,25,141,175,45,189,22,138,255,216,223,179,26,178,180,8,132,116,114,113,150,8,180,54,230,79,137,106,165,12,197,19,3,174,53,10,97,135,179,196,58,131,250,157,88,47,115,3,206,219,225,145,254,147,201,22,46,35,116,54,42,76,7,0,239,194,139,71,220,230,149,224,67,209,72,225,176,108,228,208,240,55,83,240,65,78,160,207,244,50,205,73,58,75,15,249,17,117,11,170,114,187,156,20,1,19,56,235,198,199,103,233,189,86,112,106,176,43,223,225,125,143,231,255,105,208,91,244,110,58,230,230,252,21,65,87,162,244,197,153,217,119,45,230,228,166,21,124,70,26,102,156,40,69,195,148,123,210,18,44,50,143,243,123,113,66,90,159,210,67,143,177,1,148,189,88,31,142,82,16,170,122,179,126,154,16,114,141,211,187,99,10,151,197,167,61,198,210,229,87,80,71,47,181,114,172,116,203,226,17,89,62,191,33,244,177,5,179,207,190,81,192,92,23,145,152,198,96,80,111,206,107,161,158,68,181,115,190,159,27,169,223,152,156,55,77,1,206,97,235,184,81,192,48,60,24,35,87,106,89,191,1,231,192,111,117,37,74,12,22,125,245,158,232,131,17,53,230,23,140,116,139,177,178,115,249,193,246,182,0,137,221,161,148,51,45,140,89,215,66,58,48,150,206,57,207,208,220,224,203,194,160,11,136,223,127,9,183,195,148,113,114,30,236,129,73,252,176,208,53,78,72,88,173,252,170,210,229,159,150,73,236,216,207,56,205,147,126,224,19,63,131,47,121,117,135,81,6,37,190,246,39,54,48,128,150,34,32,75,23,71,68,184,172,19,158,174,13,214,191,18,38,206,14,233,227,23,116,110,75,180,128,153,94,144,209,12,177,174,60,113,6,146,184,76,209,100,15,248,102,151,196,54,251,82,7,143,176,85,142,204,142,235,63,92,152,80,177,23,234,73,113,247,19,108,244,184,211,131,85,126,214,43,133,210,216,104,184,236,152,250,168,228,113,228,131,251,207,137,71,249,229,252,230,162,244,219,111,212,157,5,127,73,242,153,250,91,89,113,188,252,127,143,108,147,94,27,93,167,175,7,15,60,228,254,119,203,164,5,124,152,132,139,62,252,5,213,235,248,193,120,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetUsedEmailsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("eec83043-a200-4472-a0e3-ad870cca0607"),
				Name = "GetUsedEmails",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("0286a991-6b56-414c-9a9f-0cb9245f03d9"),
				ResultValueTypeName = "List<string>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,205,77,204,204,41,86,176,85,200,75,45,87,240,201,44,46,177,41,46,41,202,204,75,183,211,208,84,168,14,78,205,75,73,45,114,5,41,169,181,230,229,42,74,45,41,45,202,83,112,205,43,205,77,45,74,76,202,73,213,11,205,203,204,207,211,224,229,226,196,16,211,240,68,8,193,140,212,132,88,166,163,128,85,50,40,53,57,181,32,51,53,175,164,24,108,97,177,166,14,209,230,58,231,23,84,162,107,215,193,170,210,41,39,51,47,5,155,114,77,77,160,109,122,33,249,160,32,208,208,180,6,0,185,54,188,88,27,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetFromParticipantOnSentMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3f1f8a78-c2fe-4a31-be75-58449a826e11"),
				Name = "SetFromParticipantOnSent",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("0286a991-6b56-414c-9a9f-0cb9245f03d9"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,143,203,10,194,48,16,69,215,201,87,132,174,20,74,127,192,7,72,197,210,133,32,98,221,136,139,216,140,18,173,19,153,76,21,41,254,187,169,226,11,183,153,195,57,185,99,91,178,117,168,233,218,247,76,22,119,177,202,106,107,134,234,164,137,109,105,79,26,121,238,42,240,106,160,70,1,61,91,190,22,108,43,159,100,192,179,15,227,31,80,167,240,64,169,67,132,135,181,219,147,173,76,149,14,89,151,156,155,32,249,37,146,180,38,2,228,246,53,73,95,88,79,142,140,121,213,190,34,11,151,99,0,25,204,82,87,117,200,73,241,86,199,74,10,132,139,26,255,15,114,155,125,168,13,85,35,133,104,162,246,163,185,137,226,191,133,171,104,66,238,24,173,111,241,147,3,109,166,154,14,129,100,170,225,38,69,123,216,234,202,131,12,195,238,9,47,175,45,57,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateParticipantsByOwnerContactEmailMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d70b17f3-eca7-4ba5-9f33-7bf96de4c597"),
				Name = "UpdateParticipantsByOwnerContactEmail",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("0286a991-6b56-414c-9a9f-0cb9245f03d9"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,147,193,78,220,48,16,134,207,206,83,184,57,160,68,138,252,2,176,72,219,178,69,123,160,91,193,194,5,113,240,174,103,23,183,142,29,217,14,40,130,188,59,99,39,97,179,105,37,138,122,139,61,158,239,159,153,127,114,1,10,60,172,148,88,61,107,176,115,45,190,25,237,249,214,255,228,214,203,173,172,184,246,46,203,79,147,11,185,245,210,104,110,155,51,231,173,212,251,130,94,214,82,156,211,234,240,240,218,40,112,116,70,231,248,244,73,250,230,214,75,229,216,37,28,193,226,163,236,214,129,69,37,13,145,138,252,141,49,138,74,183,170,253,222,32,29,41,11,237,145,193,174,192,57,190,135,117,83,193,82,208,217,140,174,193,90,238,204,206,51,4,236,228,190,182,60,48,216,160,138,183,206,59,54,144,22,37,151,170,203,62,77,228,142,102,26,158,99,175,72,251,50,139,77,176,69,89,249,38,167,47,9,153,11,49,112,70,69,175,205,82,99,193,30,196,29,87,53,150,159,16,114,192,20,180,59,210,191,204,200,108,126,97,139,231,1,77,200,75,122,13,92,92,113,251,59,45,70,189,182,69,31,196,201,44,5,134,166,35,189,199,60,87,97,91,114,163,32,125,104,241,121,204,241,182,134,132,224,240,72,232,107,210,152,233,45,93,138,156,158,156,208,236,112,158,180,29,251,38,79,220,82,94,251,71,131,182,168,186,212,7,3,110,182,143,80,114,214,93,59,246,93,106,241,181,249,193,75,200,210,121,76,72,67,5,177,132,35,0,170,232,90,169,14,79,130,96,47,16,108,28,224,184,28,193,27,209,229,196,233,158,197,189,58,98,177,81,56,40,71,193,79,120,69,200,160,28,189,250,55,183,62,176,100,36,217,89,18,76,233,232,59,174,28,132,175,88,39,198,218,164,29,86,175,255,189,166,46,68,139,166,225,27,208,34,26,246,250,58,90,151,252,243,139,250,78,45,62,220,212,44,255,223,93,253,99,48,49,167,159,9,78,164,125,3,255,54,27,136,115,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateDeleteOldOwnerAndContactParticipantsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b12ac03f-fde2-4ed3-aaec-46f107c820e0"),
				Name = "DeleteOldOwnerAndContactParticipants",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("0286a991-6b56-414c-9a9f-0cb9245f03d9"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,146,193,78,195,48,12,134,207,237,83,152,30,166,68,66,121,129,49,164,209,149,105,23,152,16,131,3,226,16,181,6,34,165,73,73,220,141,9,241,238,164,99,180,101,66,59,245,132,56,90,254,253,57,241,255,207,84,78,202,26,233,182,103,158,156,50,207,167,48,175,85,113,14,149,116,164,114,85,73,67,55,86,163,135,9,76,131,116,173,104,187,34,165,189,152,35,45,59,141,223,137,216,202,163,75,173,49,184,163,242,113,172,158,128,49,131,155,235,141,65,183,40,224,100,2,86,23,251,138,195,104,4,172,171,155,110,179,93,100,101,69,91,206,225,61,142,214,210,65,129,58,172,15,20,152,161,70,194,195,53,226,210,217,146,37,223,239,235,61,43,225,113,20,137,251,23,116,216,245,23,69,194,197,194,103,175,181,212,44,181,186,46,141,8,51,178,12,104,199,50,67,65,35,150,78,149,225,42,95,237,59,169,107,228,92,4,216,212,20,44,233,109,56,14,235,253,181,155,110,78,181,27,187,178,196,142,12,31,90,240,144,220,218,228,113,16,80,154,14,4,186,24,140,212,120,216,160,64,250,189,205,227,56,10,206,139,236,13,243,58,152,30,210,244,209,230,41,184,79,50,167,54,81,109,221,102,234,135,162,151,170,95,251,125,159,254,68,234,186,123,252,231,110,128,220,125,2,6,186,58,102,39,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateDoCollectEmailParticipantsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("afa9d922-a287-4059-9555-ee92b5e9ced9"),
				Name = "DoCollectEmailParticipants",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("344c869e-7241-4322-83bf-1ed453e55f7b"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,61,140,65,10,131,48,16,0,239,5,255,16,60,217,75,62,96,21,138,72,240,158,246,30,204,90,22,226,166,108,118,5,127,223,180,135,94,135,153,113,138,209,200,249,134,37,154,193,204,36,40,167,117,32,190,162,56,229,164,59,61,67,82,184,185,42,142,93,235,127,106,123,237,155,11,131,40,211,63,30,140,7,230,80,242,38,118,202,180,225,75,57,8,102,178,247,85,240,168,223,74,139,20,59,239,1,211,247,243,88,98,255,1,94,38,72,180,128,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateActivityDeletingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5ff3c931-1248-48a8-a44a-135500d913c5"),
				Name = "ActivityDeleting",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("8a3e6264-0c74-497d-8a11-cebe83e81070"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("fc473ac8-debf-4773-8806-e0f3934b72a2"),
				Name = "context",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext ",
				CreatedInPackageId = new Guid("8a3e6264-0c74-497d-8a11-cebe83e81070")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreatePrepereSynchronizeSubjectRemindingUserTaskMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d4b44200-0933-47ae-b690-03af8654236c"),
				Name = "PrepereSynchronizeSubjectRemindingUserTask",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("8a3e6264-0c74-497d-8a11-cebe83e81070"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9fe272fe-872a-4a8f-89a5-9eeeaae0d580"),
				Name = "userTask",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "SynchronizeSubjectRemindingUserTask",
				CreatedInPackageId = new Guid("8a3e6264-0c74-497d-8a11-cebe83e81070")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("aa753256-6d50-4435-b6fa-83ffe6576e44"),
				Name = "contact",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("8a3e6264-0c74-497d-8a11-cebe83e81070")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9750902d-3610-43ad-85e5-1f2b3192ad01"),
				Name = "remindTime",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DateTime",
				CreatedInPackageId = new Guid("8a3e6264-0c74-497d-8a11-cebe83e81070")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d4c588e8-6185-4dfc-9f56-6c02dbfc89fd"),
				Name = "active",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("8a3e6264-0c74-497d-8a11-cebe83e81070")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c40df54d-2c96-4cb7-95e6-26f557c5a68d"),
				Name = "source",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("8a3e6264-0c74-497d-8a11-cebe83e81070")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,193,110,219,48,12,61,215,95,225,248,80,56,64,96,236,158,173,128,151,54,129,129,173,216,106,119,215,66,177,216,84,173,44,7,18,213,194,40,242,239,163,100,215,86,147,96,216,77,34,31,31,159,248,168,141,21,60,198,110,15,5,143,191,197,55,10,5,118,217,6,176,162,16,95,181,210,54,234,15,147,22,190,110,8,120,149,38,149,135,38,243,101,244,202,116,204,106,20,175,84,225,162,191,45,232,142,56,20,188,13,60,101,253,4,13,243,241,244,222,128,94,181,74,1,85,180,42,11,1,63,153,98,59,208,139,56,201,3,186,100,30,191,71,23,84,150,243,70,168,59,177,123,66,67,236,27,217,110,153,204,247,251,18,16,133,218,153,108,13,12,173,134,207,200,66,221,52,91,224,28,248,143,118,39,234,69,116,177,98,212,140,8,142,132,16,147,20,53,115,103,143,248,64,22,8,205,45,107,92,133,65,77,141,178,117,171,27,134,233,39,145,15,52,41,135,250,222,21,252,225,253,203,33,89,12,179,156,71,135,101,116,50,157,236,151,22,13,211,157,191,244,195,205,10,147,203,55,214,153,18,36,73,162,118,168,45,244,211,85,196,220,163,40,124,74,150,243,193,160,52,113,26,206,121,210,143,249,108,53,41,239,179,71,214,140,47,88,70,226,49,78,207,176,205,200,99,43,165,247,199,82,109,197,204,75,230,242,43,182,119,12,71,237,254,177,83,253,100,175,210,233,161,153,123,9,181,62,68,35,115,97,74,187,125,38,113,215,52,33,132,105,75,11,114,217,199,136,99,57,225,189,63,14,54,59,131,139,47,47,227,89,97,214,66,49,89,34,45,142,73,231,46,230,5,67,192,50,244,28,12,11,68,79,253,79,115,65,61,13,20,153,247,179,238,79,33,119,107,117,237,55,203,31,130,204,29,208,6,243,74,248,189,211,227,37,172,237,76,248,119,38,53,253,61,187,47,120,128,190,6,83,107,241,225,202,127,56,145,84,2,165,95,165,145,227,182,69,241,56,124,17,87,71,68,189,76,42,160,87,26,52,39,144,49,239,196,252,5,218,29,226,107,98,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateIsFinalStatusMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("fc2b9371-beb8-44e3-8d49-e15ccdc1b77e"),
				Name = "IsFinalStatus",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("8a3e6264-0c74-497d-8a11-cebe83e81070"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,146,93,107,194,48,20,134,175,87,232,127,200,114,213,130,148,221,187,9,157,104,41,108,131,205,109,183,146,54,199,26,200,135,36,169,163,136,255,125,167,54,136,86,239,74,250,190,207,57,121,218,162,21,156,56,207,124,235,74,78,94,200,66,123,225,187,172,0,255,221,237,128,207,141,108,149,254,101,178,133,231,2,163,179,132,174,66,152,166,211,56,218,51,75,224,84,89,213,91,80,236,179,5,219,33,70,195,95,64,93,156,39,63,14,236,220,104,13,181,23,70,103,151,129,119,166,89,3,118,66,104,142,47,247,253,249,105,14,77,201,33,142,30,176,153,115,37,244,151,104,182,222,225,128,66,154,138,201,124,183,91,129,247,66,55,46,91,2,230,45,92,39,75,189,80,21,112,14,252,205,52,162,158,32,106,206,112,32,18,70,203,32,74,138,154,245,207,167,196,57,90,122,80,31,76,245,21,231,45,142,202,150,198,42,230,147,209,166,107,116,182,20,90,184,237,107,87,242,245,225,233,72,39,103,179,105,28,29,81,215,0,32,27,161,153,28,212,6,242,141,195,44,231,65,126,66,7,42,77,179,62,124,37,253,110,19,247,24,204,142,124,95,108,131,16,177,33,73,128,60,226,247,106,165,28,76,91,64,139,58,96,239,254,7,149,49,114,150,140,238,208,35,143,113,20,218,27,38,29,76,255,1,64,109,222,238,92,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetActivityParticipantProcessPropertyValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f5d47d90-5532-4c6e-8689-89d1aa584e62"),
				Name = "SetActivityParticipantProcessPropertyValue",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("afbb269b-fc54-494c-b1eb-1fd3a323385c"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d37f259d-3915-44fd-9154-ed0505922822"),
				Name = "activityParticipant",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("afbb269b-fc54-494c-b1eb-1fd3a323385c")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9abdbd33-c52f-4b8d-bfa0-9718851052e9"),
				Name = "propertyName",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("afbb269b-fc54-494c-b1eb-1fd3a323385c")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f1a1f173-52b9-4661-885d-f03eb1414ff0"),
				Name = "value",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("afbb269b-fc54-494c-b1eb-1fd3a323385c")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,76,46,201,44,203,44,169,12,72,44,42,201,76,206,44,72,204,43,209,11,40,202,79,78,45,46,214,11,78,45,1,50,11,82,139,74,42,195,18,115,74,83,53,10,160,60,191,196,220,84,29,133,50,144,152,166,53,0,175,210,82,201,66,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateAddActivityParticipantToInsertedValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("455a7279-3af4-4d03-93eb-58f1acf7bc46"),
				Name = "AddActivityParticipantToInsertedValues",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("afbb269b-fc54-494c-b1eb-1fd3a323385c"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8b1f30ba-7394-4a75-86a0-6b148321eaea"),
				Name = "participantId",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("afbb269b-fc54-494c-b1eb-1fd3a323385c")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("3dbb5466-383e-4e2d-867d-1db1ecdf0a77"),
				Name = "participantParams",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, object>",
				CreatedInPackageId = new Guid("afbb269b-fc54-494c-b1eb-1fd3a323385c")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f5e3c093-57a5-457e-bf50-4b17bff28c3d"),
				Name = "overrideExistingParticipant",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("afbb269b-fc54-494c-b1eb-1fd3a323385c")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,142,189,10,194,48,20,70,103,11,190,195,117,75,64,124,1,127,58,168,72,113,113,114,17,135,107,115,149,43,154,148,228,182,90,172,239,110,156,52,130,235,225,124,156,175,65,15,108,3,121,33,179,197,75,77,1,166,160,138,148,96,128,5,151,194,206,162,111,39,171,154,205,16,220,225,76,165,204,52,228,57,88,186,253,21,148,30,247,179,226,183,144,38,163,193,71,80,174,33,239,217,208,242,206,65,216,158,54,232,133,75,174,208,10,116,29,12,210,209,104,238,172,96,100,107,106,85,245,81,11,163,53,60,250,89,47,213,119,137,178,143,31,190,64,44,225,245,125,227,249,2,111,189,137,252,16,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnActivitySavedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4f2c7516-1648-4aa8-bdf1-1ea31d739d93"),
				Name = "OnActivitySaved",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("afbb269b-fc54-494c-b1eb-1fd3a323385c"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("950b2692-5aa1-4dda-b59d-46b28ff2867d"),
				Name = "context",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext",
				CreatedInPackageId = new Guid("afbb269b-fc54-494c-b1eb-1fd3a323385c")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,189,110,194,48,16,158,195,83,88,76,201,226,23,160,84,2,196,79,150,130,8,116,183,226,3,78,114,236,232,124,161,74,171,190,123,157,132,148,8,49,176,120,240,247,123,103,103,192,179,156,241,138,92,239,20,49,230,88,42,203,123,60,95,216,111,109,166,174,160,227,100,50,242,76,104,207,130,235,18,22,206,84,133,253,84,166,130,15,85,128,152,138,165,229,32,151,89,126,129,66,201,14,247,114,133,86,207,235,134,18,143,15,65,55,78,228,131,116,50,90,87,168,91,211,84,223,125,214,192,13,95,15,216,111,13,241,61,126,18,31,186,69,81,132,39,17,247,54,83,113,0,34,229,221,137,67,160,61,225,185,34,197,232,172,236,7,13,183,158,189,92,22,10,77,147,116,76,117,34,126,26,159,40,181,200,168,12,126,67,139,14,86,178,1,83,2,197,137,188,83,2,26,26,48,144,143,187,234,93,153,104,86,177,107,229,123,48,109,242,142,92,14,221,34,95,12,201,128,31,49,127,147,255,10,48,30,110,125,143,165,86,12,67,214,188,222,126,89,160,48,35,171,156,251,200,172,182,249,133,156,13,153,253,22,6,175,251,74,233,5,65,72,122,242,87,252,138,92,145,90,15,196,160,219,119,249,111,218,28,4,92,145,21,76,21,76,254,0,41,49,163,54,109,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetActivityParticipantRightsOnSavedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8cdd7f97-ef2b-4e01-aaea-13b4f5141a3b"),
				Name = "SetActivityParticipantRightsOnSaved",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("afbb269b-fc54-494c-b1eb-1fd3a323385c"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,84,77,111,211,64,16,61,167,82,255,195,226,147,35,69,171,158,9,173,100,210,52,178,84,160,212,45,28,170,30,182,222,137,179,210,122,55,236,71,34,11,229,191,51,187,107,151,64,34,129,128,222,56,69,30,207,188,247,102,222,115,22,94,112,194,188,91,105,67,206,201,92,57,225,58,186,0,119,215,173,129,207,180,244,173,250,196,164,135,55,11,108,188,200,179,34,182,150,60,27,79,79,79,66,141,232,173,130,223,155,253,16,58,251,209,210,94,138,229,18,12,40,55,211,202,177,218,89,196,120,149,148,208,249,23,207,164,205,35,116,232,22,75,146,255,26,127,222,50,33,43,80,188,114,204,121,27,152,200,249,57,185,3,99,152,213,75,71,145,105,41,26,111,152,19,90,209,162,118,98,131,144,88,181,206,210,82,213,186,21,170,137,40,129,162,228,99,242,245,244,100,180,97,134,64,36,175,234,21,180,236,163,7,211,161,88,5,219,126,233,189,122,126,111,193,32,162,130,58,146,236,55,188,99,138,53,96,38,36,171,58,91,112,36,187,87,194,101,137,101,132,131,177,118,43,154,85,60,198,66,234,39,38,139,245,186,2,231,80,152,165,87,128,123,25,248,177,179,84,243,246,9,56,7,126,173,27,81,35,212,14,47,54,58,80,76,111,140,104,153,233,226,67,186,30,45,109,33,183,172,179,21,72,212,139,156,206,120,56,62,125,37,164,3,99,105,193,121,126,248,118,102,80,26,164,158,207,194,173,110,152,97,45,132,129,60,21,103,186,93,51,35,172,86,225,180,201,224,9,9,123,103,15,125,0,176,165,245,74,212,209,157,215,125,113,248,125,164,239,61,174,105,178,9,9,14,131,137,54,141,67,56,190,27,36,32,220,237,80,29,102,38,249,128,107,203,100,204,79,62,69,156,144,178,1,7,179,226,149,35,23,228,172,183,39,102,157,13,166,149,124,32,194,222,135,179,199,225,184,123,169,156,246,166,238,167,225,242,109,5,181,55,168,100,174,26,161,128,86,131,178,36,247,22,106,109,120,244,245,26,54,32,243,61,194,201,240,133,165,214,73,128,31,245,165,67,118,60,211,81,68,52,80,202,241,52,92,126,119,204,231,255,185,254,103,185,238,147,139,137,77,255,99,227,103,1,47,153,211,63,12,234,139,39,245,111,163,186,251,6,252,106,22,44,170,6,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSynchronizeActivityOnSavedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c9347d5f-6f8b-413b-9ebc-1bedff2a547a"),
				Name = "SynchronizeActivityOnSaved",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("afbb269b-fc54-494c-b1eb-1fd3a323385c"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,37,140,209,13,128,32,16,67,87,185,13,88,81,92,192,85,144,96,114,6,101,134,119,27,81,241,171,175,77,219,148,24,145,99,167,80,113,186,241,112,201,14,154,209,232,113,152,248,140,141,162,244,21,223,22,89,82,87,241,91,186,232,255,240,9,160,53,56,155,78,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnActivitySavingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("49ca613b-e295-4038-9702-8dbb15b1853d"),
				Name = "OnActivitySaving",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("afbb269b-fc54-494c-b1eb-1fd3a323385c"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("1b162a02-4715-4fdb-89b3-718256674dd7"),
				Name = "context",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext",
				CreatedInPackageId = new Guid("afbb269b-fc54-494c-b1eb-1fd3a323385c")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,142,193,14,130,64,12,68,239,126,133,71,253,6,78,8,198,120,145,132,37,222,27,118,130,141,75,49,165,75,178,127,47,162,151,245,54,233,228,189,142,163,5,77,240,119,10,17,115,35,142,22,150,225,112,44,118,14,214,98,100,241,53,89,222,84,20,250,24,214,107,29,149,140,39,201,176,45,157,71,226,240,103,235,210,11,167,84,173,220,48,105,202,132,15,244,207,27,224,203,104,211,134,182,8,155,249,211,94,133,173,34,185,64,176,190,67,41,194,11,116,38,77,223,125,63,137,194,162,202,222,52,162,120,3,198,70,169,0,213,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSaveOldValuesOnSavingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e3c5c812-58fe-4990-ae32-acdd04c1dc3e"),
				Name = "SaveOldValuesOnSaving",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("afbb269b-fc54-494c-b1eb-1fd3a323385c"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,215,191,176,239,98,227,197,166,11,27,46,108,186,176,227,194,110,133,11,123,46,108,5,114,247,93,216,162,112,97,203,133,221,23,251,21,128,236,141,23,27,46,108,0,138,238,5,178,119,42,92,108,4,82,155,192,10,65,58,119,0,89,16,51,118,112,101,166,41,104,120,230,21,167,22,149,164,166,132,37,230,148,166,22,43,216,218,42,228,149,230,228,104,42,84,115,113,162,75,41,228,165,150,43,184,100,38,151,100,230,231,37,22,85,218,184,151,102,166,232,40,228,39,101,165,38,151,216,105,104,90,115,213,2,0,195,233,45,238,160,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCalculateDurationOnSavingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f3a6f416-8b0e-461b-a83e-49206ae2a3a5"),
				Name = "CalculateDurationOnSaving",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("afbb269b-fc54-494c-b1eb-1fd3a323385c"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,201,204,77,13,46,72,204,83,72,41,45,74,44,201,204,207,83,176,85,112,205,43,201,44,169,212,115,41,77,117,73,44,73,85,208,133,9,4,151,36,22,149,128,132,172,185,224,74,32,154,60,243,124,51,243,74,75,82,139,129,186,53,50,243,74,52,97,166,233,133,228,151,36,230,64,37,177,105,3,75,56,230,165,120,228,151,22,129,116,7,151,20,101,230,165,235,57,231,231,37,39,150,104,96,49,11,172,80,71,1,68,233,192,29,173,7,181,65,71,1,194,208,180,6,0,181,240,139,167,216,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSavingEmailOnSavingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1c7cb357-0e6d-48af-a72a-74cad3c2dc81"),
				Name = "SavingEmailOnSaving",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("afbb269b-fc54-494c-b1eb-1fd3a323385c"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,84,207,111,218,48,20,62,195,95,225,230,228,72,81,14,211,118,234,168,180,2,43,28,90,208,72,119,216,205,75,94,193,146,99,35,219,41,99,83,255,247,189,23,39,176,180,176,5,237,152,188,239,125,191,236,196,121,43,245,154,153,157,6,59,47,198,70,85,165,126,16,37,176,17,155,106,47,253,62,93,229,27,40,69,26,70,46,189,3,127,187,39,4,143,22,180,20,197,205,232,171,80,21,208,224,122,232,2,105,110,180,23,185,191,148,118,28,214,78,17,203,39,198,155,125,92,8,227,133,42,106,4,127,147,33,102,87,35,166,43,165,98,246,107,56,48,170,88,4,4,154,208,176,99,119,149,44,46,97,75,51,179,170,131,241,56,190,30,190,252,221,204,137,236,111,236,140,91,76,47,67,167,24,251,88,234,85,14,202,247,40,231,127,154,233,89,11,106,247,170,229,178,78,174,38,6,17,10,114,63,45,133,84,75,97,189,204,229,86,104,239,16,69,186,22,124,101,53,225,231,90,122,41,148,252,9,175,177,51,80,91,176,60,78,143,16,156,162,166,7,235,26,135,241,225,246,127,55,197,30,19,240,240,24,159,14,16,221,34,42,194,165,246,171,120,53,94,90,120,150,176,139,18,22,50,61,122,169,80,27,234,15,102,169,132,212,25,252,240,159,173,41,103,190,84,156,52,19,246,238,253,7,138,126,254,20,162,21,232,98,34,60,68,221,242,27,231,27,225,54,199,15,21,119,179,253,22,138,63,8,62,6,224,13,143,238,177,161,25,194,41,194,128,4,195,36,157,187,7,36,93,216,105,185,245,123,78,132,161,230,86,2,153,21,252,187,157,140,96,53,247,128,236,102,18,255,32,174,241,78,219,237,203,115,251,199,156,68,209,228,250,148,123,249,140,104,234,178,238,177,62,103,74,193,31,29,88,188,126,26,47,138,52,58,57,104,37,193,112,194,66,193,93,88,58,174,172,5,237,233,109,74,110,190,25,13,181,224,153,67,61,148,150,212,85,19,244,5,47,94,109,227,139,92,111,188,187,23,90,172,193,50,219,121,26,177,214,108,7,197,145,160,3,36,65,52,51,129,167,128,59,92,205,223,190,39,154,57,237,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetTypeByCategoryOnSavingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("91124f74-70b9-4040-9619-cca264dbc14c"),
				Name = "SetTypeByCategoryOnSaving",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("afbb269b-fc54-494c-b1eb-1fd3a323385c"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,146,81,75,195,48,16,199,159,39,248,29,66,159,90,24,193,247,57,161,150,173,20,84,208,169,175,35,107,206,46,208,36,37,189,78,202,216,119,247,226,186,181,235,64,223,218,227,127,191,59,126,23,245,197,194,133,65,133,45,79,1,223,219,10,100,98,203,70,155,79,81,54,112,159,54,74,62,132,129,175,103,50,136,216,124,206,124,137,47,116,133,109,196,246,183,55,19,255,207,114,129,80,88,215,102,146,205,217,255,188,56,71,181,163,76,114,110,11,162,25,177,118,194,177,58,223,130,22,175,13,184,150,88,6,190,59,222,170,175,135,31,53,184,196,26,3,196,177,134,15,3,207,194,136,2,220,148,93,13,9,142,251,78,168,57,150,90,153,55,85,108,177,166,25,105,105,55,162,140,171,106,5,136,202,20,53,95,130,192,198,193,101,50,51,11,189,1,41,65,62,217,66,229,83,207,74,4,13,37,196,104,33,98,149,138,156,208,247,111,162,207,102,8,250,69,104,223,83,163,163,97,124,105,157,22,120,237,100,77,254,78,53,239,241,145,44,173,247,119,135,96,58,176,29,17,248,112,50,135,148,58,202,246,244,94,23,143,101,119,132,126,138,39,242,161,246,19,115,212,74,75,28,237,142,156,95,44,225,25,221,209,73,225,224,222,231,151,211,199,255,120,22,253,254,220,43,138,60,247,48,251,1,40,115,45,7,162,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnActivityInsertingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("90bc03ea-163d-425e-b7ec-1413a5000296"),
				Name = "OnActivityInserting",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("afbb269b-fc54-494c-b1eb-1fd3a323385c"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("972382d2-272a-437b-9841-25d1b332a84d"),
				Name = "context",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext",
				CreatedInPackageId = new Guid("afbb269b-fc54-494c-b1eb-1fd3a323385c")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,80,205,106,132,48,16,62,235,83,132,156,34,20,95,96,187,133,90,236,54,23,89,176,244,30,204,180,27,208,40,201,216,98,203,190,123,39,106,89,181,91,232,113,190,249,254,102,60,58,99,223,152,170,208,188,27,28,158,135,14,30,218,186,111,108,161,26,96,123,150,91,36,56,45,171,19,52,42,157,86,62,61,0,102,67,96,8,30,20,60,153,55,47,170,238,33,224,187,248,208,27,189,178,149,250,98,71,250,0,233,133,234,54,8,238,196,245,34,201,46,246,215,138,234,80,241,209,88,125,191,129,179,65,106,177,78,39,15,243,202,196,111,131,61,227,121,163,76,205,19,246,197,226,40,144,230,154,35,92,130,213,37,42,236,189,212,169,244,121,211,225,32,18,226,198,81,52,30,105,91,92,114,230,70,27,109,54,132,48,193,139,137,204,169,77,20,253,21,67,22,27,83,98,159,227,31,126,9,184,120,156,224,210,23,0,250,232,218,10,188,231,55,12,93,31,62,118,142,165,53,104,84,109,62,97,140,56,42,135,166,50,157,178,248,4,117,7,78,36,233,133,66,91,250,52,130,243,243,249,100,241,31,3,10,255,160,194,33,148,4,171,201,1,246,206,78,195,55,125,30,119,19,105,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateActivityParticipantsFromInsertedValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("33621c58-9f0d-4c68-9ffe-4e367bb10c86"),
				Name = "CreateActivityParticipantsFromInsertedValues",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("afbb269b-fc54-494c-b1eb-1fd3a323385c"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,147,223,78,194,48,20,198,175,33,241,29,234,174,70,66,250,2,136,9,2,146,69,37,139,4,239,15,221,97,84,183,110,182,221,204,98,120,119,79,169,202,16,48,220,108,201,250,245,251,125,231,207,106,208,76,42,131,218,98,242,2,89,133,134,13,89,116,248,1,12,91,52,198,98,206,199,69,150,161,176,178,80,134,207,80,161,150,130,79,228,238,3,232,230,102,86,201,164,207,138,213,43,105,110,7,87,221,117,161,17,196,38,172,9,242,86,151,4,250,195,234,177,207,171,110,199,29,151,160,173,20,178,4,101,99,208,144,187,24,116,133,239,116,46,65,11,99,172,150,42,109,131,58,114,205,194,99,139,235,33,83,85,150,121,202,14,3,100,82,75,219,196,123,237,66,108,48,7,194,45,41,217,184,80,202,23,200,167,202,146,208,159,62,129,130,20,53,213,108,169,55,22,148,192,187,102,14,57,134,193,232,216,49,232,13,254,225,17,233,108,10,62,166,134,89,244,232,240,48,144,55,61,113,149,147,110,148,228,82,61,203,116,99,93,227,102,89,177,130,108,84,150,11,180,150,90,101,248,61,217,86,26,15,149,145,154,230,43,76,18,76,30,139,84,138,179,254,228,50,193,53,205,190,202,149,159,91,120,62,12,137,91,202,125,127,162,36,232,51,95,24,143,181,204,105,144,45,221,229,126,173,179,157,165,91,146,7,108,188,65,123,225,74,183,3,104,209,237,247,241,122,125,239,196,37,200,95,35,199,233,239,125,121,43,249,214,61,220,18,70,102,142,31,63,230,100,116,98,61,98,93,8,52,134,94,37,253,10,141,135,156,200,209,103,65,100,150,74,190,87,72,117,90,125,192,58,153,27,106,244,147,33,201,246,11,193,165,251,112,218,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnActivityInsertedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d6af1890-3bc5-448b-95bf-4f985447e631"),
				Name = "OnActivityInserted",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("e2abafdc-6941-48ad-bc50-34f0bc9897c4"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("595648c7-f40e-4f34-a901-b05e9e90f395"),
				Name = "context",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext",
				CreatedInPackageId = new Guid("e2abafdc-6941-48ad-bc50-34f0bc9897c4")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,145,77,110,194,48,16,133,215,201,41,172,44,144,35,33,95,128,31,137,166,64,187,160,139,2,221,91,201,144,88,114,28,52,30,183,66,85,239,222,113,210,170,161,176,178,60,254,230,189,231,153,117,171,141,125,53,117,67,126,167,157,174,1,5,94,221,22,98,11,180,190,161,100,62,75,175,64,181,7,90,5,106,58,28,56,185,118,100,232,194,152,39,52,174,22,116,57,67,209,217,208,186,55,109,3,188,232,22,88,124,160,212,190,108,160,213,106,120,247,106,99,92,245,112,137,136,204,14,220,151,229,234,95,235,44,221,6,83,245,162,207,213,159,14,103,141,124,53,162,231,17,92,202,59,246,156,205,156,132,252,213,88,136,3,32,106,223,157,136,221,220,201,212,1,53,153,206,169,85,73,230,157,229,185,234,201,171,126,26,209,230,200,109,147,201,200,123,100,32,179,61,184,234,81,19,135,143,218,46,88,155,139,207,52,233,187,119,224,61,79,237,9,236,153,103,220,12,199,66,20,86,123,191,209,37,117,216,235,205,111,225,165,76,147,36,113,240,33,250,52,24,34,188,194,58,180,224,72,102,193,3,242,131,131,50,38,207,166,226,120,85,200,249,207,201,96,167,10,4,78,55,118,248,217,217,84,196,145,241,55,207,253,254,190,82,4,10,232,4,155,193,236,27,7,183,169,124,49,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetEmailIsNeedProcessMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("830817fb-8ee8-42aa-a6b9-6ec8e547bf27"),
				Name = "SetEmailIsNeedProcess",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("e2abafdc-6941-48ad-bc50-34f0bc9897c4"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,84,203,110,219,48,16,60,219,128,255,65,214,33,160,128,128,63,208,7,160,26,78,32,160,13,210,186,110,206,12,185,182,8,72,164,66,82,110,133,194,255,222,165,73,89,150,157,166,1,130,222,68,238,238,236,236,204,82,59,102,18,41,146,15,201,82,57,233,58,122,11,238,123,215,128,88,232,170,173,213,15,86,181,240,254,182,149,226,35,73,11,145,102,239,102,211,29,86,112,173,28,227,174,176,203,186,113,29,86,251,20,26,15,175,193,90,4,128,35,32,227,92,183,234,13,128,121,0,56,2,186,82,26,113,207,140,59,148,74,176,3,180,51,45,196,44,203,75,168,217,186,56,17,160,80,214,49,197,1,47,49,41,164,129,125,194,4,5,63,99,210,234,80,246,181,5,211,145,88,118,26,248,194,20,219,130,185,78,210,112,139,195,42,224,78,106,149,102,201,239,217,116,178,182,144,139,90,170,111,114,91,58,235,167,173,244,35,171,242,166,89,129,115,82,109,45,189,1,230,90,3,227,204,66,45,235,71,16,2,196,103,189,149,124,54,221,31,253,240,130,32,229,59,86,3,226,33,97,154,139,168,147,87,59,134,211,140,250,12,172,242,25,11,131,77,224,70,86,14,204,131,116,37,202,133,65,60,88,18,46,23,186,110,152,145,86,43,47,59,93,62,181,172,194,169,86,157,61,29,215,227,94,15,82,14,150,58,185,27,77,111,35,51,180,177,23,166,170,66,136,224,160,102,200,204,14,210,111,52,18,228,101,66,158,135,75,164,122,174,73,144,120,80,37,74,18,125,10,148,105,80,196,122,42,159,58,36,77,46,129,94,216,182,145,220,153,39,59,145,155,132,252,115,75,7,66,89,50,63,221,241,192,121,242,194,210,110,88,101,189,111,147,61,186,222,239,101,219,8,52,16,163,100,125,248,202,252,138,134,207,51,65,209,181,60,78,136,59,240,80,130,129,240,160,41,182,240,182,146,192,150,30,119,128,72,145,245,86,42,0,177,238,123,245,76,252,196,103,255,129,171,171,179,135,28,230,10,52,41,238,54,246,180,119,8,118,111,52,7,107,113,109,46,218,250,215,25,36,29,117,141,143,118,31,250,206,47,27,207,207,126,33,120,245,55,57,255,23,171,33,52,234,176,252,5,188,69,71,124,249,254,15,252,17,224,206,112,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateAutoEmailRelationProceedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0185b944-69a1-4587-820f-279aea7fd32a"),
				Name = "AutoEmailRelationProceed",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("71317f69-6dea-434b-937e-898e51005dca"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,240,44,246,75,77,77,113,44,45,201,119,205,77,204,204,9,74,205,73,44,201,204,207,211,84,168,230,229,226,44,75,44,82,72,68,151,82,176,85,200,75,45,87,8,73,45,42,74,44,206,79,43,209,115,206,207,75,203,76,47,45,2,203,234,97,24,133,41,162,17,90,156,90,4,212,149,151,154,12,182,203,26,104,21,134,53,122,1,69,249,201,64,167,193,53,185,230,149,100,150,84,130,20,215,2,0,220,150,57,82,185,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCheckNeedAutoEmailRelationMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a9d8d55d-014b-4576-9fa6-ed7a6f206387"),
				Name = "CheckNeedAutoEmailRelation",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("64f44868-3737-4cbb-9e9b-c28a9f464ee6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,144,209,78,131,48,20,134,175,37,225,29,234,174,198,13,47,128,51,153,100,89,184,209,4,167,247,72,15,75,147,174,37,237,169,9,49,190,187,45,168,41,99,104,58,110,219,115,190,243,127,63,107,200,122,39,144,97,151,238,1,15,93,11,52,151,220,156,196,107,197,13,220,237,13,163,247,235,149,123,47,232,42,33,183,27,114,0,165,42,45,27,76,115,41,26,118,52,170,66,38,69,186,173,145,189,91,142,125,213,168,211,221,169,98,220,237,189,20,52,33,31,113,116,163,0,141,18,89,28,125,198,81,28,21,250,17,128,110,13,202,126,178,4,222,99,200,134,52,21,215,144,185,25,141,138,137,35,177,233,56,244,121,236,239,31,97,135,113,23,215,45,172,146,108,76,120,226,116,6,98,127,254,225,48,91,147,23,195,214,48,66,14,130,243,74,168,140,51,58,171,224,59,156,6,65,65,133,248,61,247,27,190,224,192,8,55,244,72,78,209,143,98,29,199,212,69,146,10,106,104,25,8,12,241,44,127,150,124,213,95,82,29,174,59,6,58,227,179,92,86,122,202,95,36,94,203,182,43,175,145,207,253,69,191,128,17,49,188,131,41,215,245,112,33,166,237,226,226,169,69,117,188,113,38,104,126,109,39,15,147,109,191,152,41,59,188,157,153,11,174,162,185,232,182,167,249,203,225,101,125,1,194,107,176,199,146,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitializeEmailParticipantHelperMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e0f72183-7343-46a0-8722-9095bbd715a9"),
				Name = "InitializeEmailParticipantHelper",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("d702c996-3cae-4e74-a7fe-414987972104"),
				ResultValueTypeName = "EmailParticipantHelper"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,140,65,10,131,48,16,69,215,122,138,193,85,2,226,5,108,43,34,106,151,221,244,0,67,24,74,32,78,100,50,65,188,125,237,178,144,191,124,239,241,231,13,125,120,161,168,119,126,71,214,39,133,157,4,238,48,151,197,48,212,213,181,41,96,74,11,58,141,114,118,43,233,173,156,63,12,211,1,83,228,164,146,127,241,40,159,188,17,171,105,114,34,185,4,147,83,31,185,105,225,253,7,172,237,235,74,72,179,48,152,242,185,45,227,254,11,71,42,128,103,211,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetRemindDatesOnSavingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("27d15b85-941b-4012-a7c2-6f50eb909498"),
				Name = "SetRemindDatesOnSaving",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,146,223,106,131,48,24,197,175,245,41,82,47,74,132,226,11,184,21,100,45,187,26,194,148,221,167,75,164,129,104,54,27,91,202,232,187,47,127,234,140,81,235,90,240,198,144,243,251,206,249,78,142,168,6,21,57,101,2,213,98,131,4,1,207,96,91,9,42,206,209,43,17,249,249,139,224,23,206,154,178,250,64,172,33,79,234,70,78,75,178,134,193,159,34,8,99,255,40,41,156,225,27,148,148,253,11,228,211,2,46,108,82,180,253,110,16,59,192,86,16,189,81,131,8,193,114,9,22,182,245,246,170,45,15,67,240,227,123,202,30,150,127,27,90,20,210,90,79,148,53,59,81,163,79,209,151,197,70,180,71,135,164,17,123,94,191,147,146,86,248,246,114,118,156,51,153,199,92,205,185,17,6,22,42,61,85,228,17,146,214,105,16,45,0,116,60,233,128,122,2,178,78,239,170,178,239,184,173,194,64,229,86,146,89,238,116,185,83,104,21,196,245,107,245,231,142,212,101,15,242,173,193,200,171,80,219,240,70,86,49,152,150,96,12,219,71,161,61,121,215,84,25,17,86,154,209,12,171,1,78,19,46,190,250,174,37,89,109,119,29,241,238,240,161,138,52,116,208,80,58,71,157,47,200,1,171,12,142,87,171,30,103,158,110,199,77,54,93,206,112,7,238,164,187,171,233,220,175,92,88,87,204,37,254,5,25,186,80,241,237,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnActivityUpdated_aa5f074ac858455d865435cc7584e9caMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("aa5f074a-c858-455d-8654-35cc7584e9ca"),
				Name = "OnActivityUpdated_aa5f074ac858455d865435cc7584e9ca",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("90c3dafc-6846-434a-9ab5-1d51c730a76d"),
				Name = "context",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				ModifiedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,78,45,114,206,207,203,75,77,46,201,204,207,211,243,12,40,202,79,78,45,46,118,205,75,207,204,75,213,11,174,204,75,206,40,202,207,203,172,74,133,74,248,229,151,100,166,101,38,39,130,84,107,184,230,149,100,150,84,234,40,36,231,231,149,164,86,148,104,90,3,0,249,41,42,226,78,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetEmailRightsManagerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("470d8e58-78b9-4055-9e2e-a8b037a9c205"),
				Name = "GetEmailRightsManager",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("79d5e1e4-18af-4001-8dc1-26f09fca92c2"),
				ResultValueTypeName = "EmailRightsManager"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,112,206,73,44,46,118,75,76,46,201,47,170,212,115,79,45,177,113,205,77,204,204,9,202,76,207,40,41,246,77,204,75,76,79,45,178,211,200,75,45,87,112,206,207,43,46,41,42,5,41,116,44,74,47,205,77,205,43,209,80,42,45,78,45,2,74,228,165,38,151,100,230,231,41,233,40,132,162,8,104,106,90,3,0,127,136,45,35,103,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitCanGenerateAnniversaryRemindingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f28a271f-cc90-426b-96f8-b5ff423019b9"),
				Name = "InitCanGenerateAnniversaryReminding",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,145,205,106,195,48,16,132,239,125,10,145,67,176,47,122,129,212,1,163,6,19,40,46,52,161,119,89,94,82,5,123,101,172,117,138,33,15,223,69,254,73,82,183,135,30,37,205,124,154,217,45,156,171,132,245,57,124,137,68,236,144,44,245,242,64,174,181,120,58,144,38,16,73,34,198,243,91,113,6,67,225,86,178,126,243,84,12,94,229,144,180,161,220,209,174,110,168,191,113,50,160,99,223,64,169,92,213,213,248,161,171,14,158,179,206,150,219,104,53,122,246,229,42,150,123,63,89,163,120,134,166,198,184,14,255,7,29,61,191,64,47,186,21,38,24,60,147,24,145,34,218,11,180,94,183,253,11,52,128,37,32,13,68,63,235,63,53,158,166,127,252,67,0,117,255,20,34,4,215,32,80,63,125,143,32,121,116,175,214,211,92,85,223,146,140,138,17,176,116,166,216,71,220,66,36,219,169,140,12,115,180,28,154,47,100,174,107,136,153,171,52,102,128,208,242,162,238,122,190,67,109,177,228,61,50,56,90,110,237,122,93,78,61,22,235,245,223,1,55,223,148,26,125,74,60,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetAnniversaryDependentColumnsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7660a6a6-eb3a-4100-af8e-6ab636ed7d16"),
				Name = "GetAnniversaryDependentColumns",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "IEnumerable<string>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,80,200,75,45,143,142,85,168,86,80,114,206,207,43,73,76,46,241,76,81,210,81,80,114,76,78,206,47,205,131,114,252,203,243,82,139,128,76,133,90,107,0,157,190,249,112,54,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetRemindingOptionsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e28d1d82-1003-405c-9dad-da48a60b5983"),
				Name = "GetRemindingOptions",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "IEnumerable<string>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,144,193,106,195,48,16,68,207,14,228,31,150,156,100,40,254,129,214,14,194,244,16,8,77,201,161,151,210,131,144,212,116,193,94,5,105,237,96,74,254,189,138,171,80,220,22,154,244,36,216,157,209,219,153,94,121,112,123,70,71,1,74,32,123,128,53,6,190,11,236,145,118,149,200,111,231,179,62,74,244,155,162,157,53,181,107,186,118,84,222,19,35,15,245,116,172,194,167,59,45,199,233,147,106,58,91,193,114,249,245,249,207,245,200,193,87,16,83,78,33,105,16,218,53,80,86,16,159,226,65,181,22,202,18,22,155,3,89,191,50,139,60,135,247,249,44,75,1,10,105,204,246,228,23,17,245,252,50,174,50,169,25,251,136,147,68,216,91,31,148,31,182,182,69,50,49,95,33,181,118,29,241,102,244,223,252,41,175,29,177,210,23,203,31,149,103,212,184,87,103,66,116,28,79,73,51,111,185,243,116,46,62,78,142,87,197,79,119,252,90,128,184,60,65,126,53,56,245,245,15,240,164,233,4,254,214,194,7,223,174,150,145,139,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGenerateRemindingsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f17f915a-546b-4b14-a26c-5baf5eaed9dd"),
				Name = "GenerateRemindings",
				CreatedInSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,144,207,10,130,64,16,198,207,250,20,107,39,133,240,5,202,64,68,164,83,16,213,125,113,167,24,208,217,216,63,134,68,239,222,108,148,39,43,216,195,50,243,251,102,190,111,240,44,210,164,146,212,0,129,145,14,74,34,28,192,88,105,198,61,244,72,10,233,146,137,123,28,25,112,222,208,42,126,196,141,71,37,248,21,162,38,135,110,204,27,112,135,241,10,170,210,157,239,233,36,59,15,235,0,109,210,197,86,45,178,85,140,188,228,63,27,234,129,23,73,33,202,214,225,192,124,165,201,58,155,215,189,196,46,244,143,91,245,114,243,233,207,217,21,230,243,179,239,84,218,176,89,130,155,248,37,75,143,22,12,239,35,96,72,211,146,35,178,245,104,102,88,190,187,6,194,242,80,142,51,13,120,87,211,111,170,233,196,173,243,178,155,100,47,193,227,9,93,92,39,233,136,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Activity_Base_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("402a0d89-2ee2-4795-9391-05e13257c797"));
		}

		#endregion

	}

	#endregion

}

